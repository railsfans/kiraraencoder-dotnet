' ---------------------------------------------------------------------------------------
' 
' Copyright (C) 2008-2011 LEE KIWON
' 
' This program is free software; you can redistribute it and/or
' modify it under the terms of the GNU General Public License
' as published by the Free Software Foundation; either version 2
' of the License, or (at your option) any later version.
' 
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
' 
' You should have received a copy of the GNU General Public License
' along with this program; if not, write to the Free Software
' Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
' 
' =======================================================================================

Imports Microsoft.Win32.SafeHandles
Imports System.Runtime.InteropServices
Imports System.IO

Public Class FFMSIndexFrm

    '프론트엔드 코어
    Private OutputHandle_ID As SafeFileHandle = Nothing
    Private InputHandle_ID As SafeFileHandle = Nothing
    Public ProcessHandle_ID As IntPtr = Nothing
    Private ThreadSignal_ID As New Threading.ManualResetEvent(False)

    '프로세스 우선 순위
    Enum PriorityClass
        REALTIME_PRIORITY_CLASS = &H100
        HIGH_PRIORITY_CLASS = &H80
        ABOVE_NORMAL_PRIORITY_CLASS = 32768
        NORMAL_PRIORITY_CLASS = &H20
        BELOW_NORMAL_PRIORITY_CLASS = 16384
        IDLE_PRIORITY_CLASS = &H40
    End Enum

    '남은시간
    Dim OnePV As Single = 0.0
    Dim R_OnePV As Single = 0.0

    '디먹서 선택
    Dim DEMUXER As String = "default"
    Public DEStr As String = "" '그냥 보여주기위한...

    '종료여부
    Dim ExitBool As Boolean = False

#Region "프론트엔드 코어"

    '=================================
    '코드 출처: http://www.vbforums.com/showthread.php?t=618110
    '위의 URL에 있는 핵심 소스를 사용하여 제작되었습니다.

    Private Sub WriteToOutputBox(ByVal MsgV As String)
        If OutputBox_ID.InvokeRequired Then
            Try
                Invoke(New Action(Of String)(AddressOf WriteToOutputBox), MsgV)
            Catch ex As Exception
            End Try
        Else

            '인덱스 관련
            Dim k As Long = 1
            Dim kk As Long = 0
            Dim l As String = ""
            If InStrRev(MsgV, "Indexing, please wait... ") Then
                kk = InStrRev(MsgV, "Indexing, please wait... ")
                If InStr(kk, MsgV, "%", CompareMethod.Text) Then
                    k = InStr(kk, MsgV, "%", CompareMethod.Text) + 1
                    l = Mid(MsgV, kk, k - kk - 1)
                End If
            Else
                k = k + 1
            End If
            If l <> "" Then
                l = Replace(l, "Indexing, please wait... ", "")
                AviSynthPP.INDEX_PStr = l

                '남은시간
                R_OnePV = OnePV * (ProgressBar.Maximum - ProgressBar.Value)

                '진행률
                PLabel.Text = AviSynthPP.INDEX_PStr & "%"
                Try
                    If ProgressBar.Maximum >= AviSynthPP.INDEX_PStr Then
                        ProgressBar.Value = AviSynthPP.INDEX_PStr
                    Else
                        ProgressBar.Maximum = AviSynthPP.INDEX_PStr
                        ProgressBar.Value = AviSynthPP.INDEX_PStr
                    End If
                Catch ex As Exception
                End Try

                '남은시간
                OnePV = 0.0

            End If

        End If
    End Sub

    'Public Sub MsgSend(ByVal msg As String)

    '    If Not InputHandle_GI Is Nothing AndAlso Not InputHandle_GI.IsClosed Then
    '        Dim MessageBytes() As Byte = System.Text.Encoding.GetEncoding(0).GetBytes(msg & vbCrLf & vbCr)
    '        Dim BytesWritten As UInteger = 0
    '        WinAPI.WriteFile(InputHandle_GI, MessageBytes, CUInt(MessageBytes.Length - 1), BytesWritten, 0)
    '    End If

    'End Sub

    Private Sub OutputInfo()

        Do
            Threading.Thread.Sleep(10)

            Do
                Threading.Thread.Sleep(10)

                Dim Buffer(0) As Byte
                Dim BytesRead As UInteger = 0
                Dim BytesAvailable As UInteger = 0

                Dim PNP As Boolean
                If Not OutputHandle_ID Is Nothing Then
                    PNP = WinAPI.PeekNamedPipe(OutputHandle_ID, Nothing, 0, 0, BytesAvailable, 0)
                End If

                If PNP = True Then
                    If BytesAvailable > 0 Then
                        ReDim Buffer(CInt(BytesAvailable))
                        If WinAPI.ReadFile(OutputHandle_ID, Buffer, CUInt(Buffer.Length), BytesRead, 0) Then
                            WriteToOutputBox(System.Text.Encoding.GetEncoding(0).GetString(Buffer))
                        Else
                            Exit Do
                        End If
                    Else
                        Exit Do
                    End If
                Else
                    Exit Do
                End If


                Application.DoEvents()
            Loop

            Dim WaitOnHandles(1) As IntPtr
            WaitOnHandles(0) = ProcessHandle_ID
            WaitOnHandles(1) = ThreadSignal_ID.SafeWaitHandle.DangerousGetHandle
            If WinAPI.WaitForMultipleObjects(2, WaitOnHandles, False, 0) = 0 Then
                EndOfProcess()
                Exit Do
            End If

            Application.DoEvents()
        Loop

    End Sub

    Private Sub EndOfProcess()

        If OutputBox_ID.InvokeRequired Then
            Invoke(New MethodInvoker(AddressOf EndOfProcess))
        Else
            DestroyHandles()
            '남은시간 계산용
            OnePTimer.Enabled = False
            TLabelTimer.Enabled = False
            '프로세스 종료
            AviSynthPP.INDEX_ProcessEChk = True
            ExitBool = True
            Close()
        End If

    End Sub

    Public Sub DestroyHandles()

        If ProcessHandle_ID <> IntPtr.Zero Then
            WinAPI.CloseHandle(ProcessHandle_ID)
        End If

        If Not InputHandle_ID Is Nothing AndAlso Not InputHandle_ID.IsClosed Then
            InputHandle_ID.Close()
        End If

        If Not OutputHandle_ID Is Nothing AndAlso Not OutputHandle_ID.IsClosed Then
            OutputHandle_ID.Close()
        End If

    End Sub

    '=================================

#End Region

    Public Sub IDSTR(ByVal IN_PATHV As String, ByVal OUT_PATHV As String, ByVal PriorityInt As Integer, ByVal VideoOnly As Boolean, ByVal index As Integer, ByVal MATROSKAERR As Integer)

        '종료여부
        ExitBool = False

        Dim MSGB As String = ""

        '디먹서 선택
        If InStr(MainFrm.EncListListView.Items(index).SubItems(3).Text, "matroska", CompareMethod.Text) <> 0 AndAlso MATROSKAERR = 1 Then
            DEMUXER = "lavf"
            '---
            DEStr = "libavformat"
        Else
            DEMUXER = "default"
            '---
            If InStr(MainFrm.EncListListView.Items(index).SubItems(3).Text, "matroska", CompareMethod.Text) <> 0 Then
                DEStr = "matroska"
            Else
                DEStr = "libavformat"
            End If
        End If

        '인덱스파일 이미 있으면 삭제
        If My.Computer.FileSystem.FileExists(OUT_PATHV) = True Then
            Try
                My.Computer.FileSystem.DeleteFile(OUT_PATHV)
            Catch ex As Exception
            End Try
        End If

        If VideoOnly = False Then
            MSGB = My.Application.Info.DirectoryPath & "\tools\ffms\ffmsindex.exe" & " -f -t -1 -s 3 -d 0 " & "-m " & DEMUXER & " " & Chr(34) & IN_PATHV & Chr(34) & " " & Chr(34) & OUT_PATHV & Chr(34)
        Else '비디오 부분만 인덱스//
            MSGB = My.Application.Info.DirectoryPath & "\tools\ffms\ffmsindex.exe" & " -f -t 0 -s 3 -d 0 " & "-m " & DEMUXER & " " & Chr(34) & IN_PATHV & Chr(34) & " " & Chr(34) & OUT_PATHV & Chr(34)
        End If

        Dim TempOutputHandle As SafeFileHandle = Nothing
        Dim TempInputHandle As SafeFileHandle = Nothing

        Dim StartupInfo As New WinAPI.STARTUPINFO
        StartupInfo.cb = Marshal.SizeOf(StartupInfo)
        StartupInfo.dwFlags = WinAPI.STARTF_USESTDHANDLES Or WinAPI.STARTF_USESHOWWINDOW

        Dim SecurityAttributes As New WinAPI.SECURITY_ATTRIBUTES
        SecurityAttributes.nLength = Marshal.SizeOf(SecurityAttributes)
        SecurityAttributes.bInheritHandle = True
        WinAPI.CreatePipe(TempOutputHandle, StartupInfo.hStdOutput, SecurityAttributes, 0)
        WinAPI.CreatePipe(StartupInfo.hStdInput, TempInputHandle, SecurityAttributes, 0)
        WinAPI.DuplicateHandle(New HandleRef(Me, Process.GetCurrentProcess.Handle), StartupInfo.hStdOutput, _
                               New HandleRef(Me, Process.GetCurrentProcess.Handle), StartupInfo.hStdError, 0, True, WinAPI.DUPLICATE_SAME_ACCESS)
        WinAPI.DuplicateHandle(New HandleRef(Me, Process.GetCurrentProcess.Handle), TempInputHandle, _
                               New HandleRef(Me, Process.GetCurrentProcess.Handle), InputHandle_ID, 0, False, WinAPI.DUPLICATE_SAME_ACCESS)
        WinAPI.DuplicateHandle(New HandleRef(Me, Process.GetCurrentProcess.Handle), TempOutputHandle, _
                               New HandleRef(Me, Process.GetCurrentProcess.Handle), OutputHandle_ID, 0, False, WinAPI.DUPLICATE_SAME_ACCESS)

        TempOutputHandle.Close()
        TempInputHandle.Close()
        TempOutputHandle.Dispose()
        TempInputHandle.Dispose()

        '프로세스 우선순위 설정
        Dim ProcessInformation As New WinAPI.PROCESS_INFORMATION
        WinAPI.CreateProcess(Nothing, MSGB, SecurityAttributes, SecurityAttributes, True, PriorityInt, IntPtr.Zero, Nothing, StartupInfo, ProcessInformation)

        If ProcessInformation.dwProcessId <> 0 AndAlso ProcessInformation.hProcess <> IntPtr.Zero Then
            '진행바
            PLabel.Text = ""
            ProgressBar.Value = 0

            '남은시간 계산용
            OnePV = 0.0
            R_OnePV = 0.0
            OnePTimer.Enabled = True
            TLabelTimer.Enabled = True
            TLabel.Text = ""

            ProcessHandle_ID = ProcessInformation.hProcess
            AviSynthPP.INDEX_ProcessHandle_ID = ProcessInformation.hProcess
            Dim ThreadSTR As New Threading.Thread(AddressOf OutputInfo)
            ThreadSTR.IsBackground = True
            ThreadSTR.Start()
        End If

    End Sub

    Private Sub CancelBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBTN.Click
        AviSynthPP.INDEX_ProcessStopChk = True
        WinAPI.TerminateProcess(ProcessHandle_ID, 0&)
        If ExitBool = True Then
            Close()
        End If
    End Sub

    Private Sub IndexFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '=========================================
        'Rev 1.2
        '언어로드

        '함수에서 언어파일 선택
        Dim LangXMLFV As String = FunctionCls.LangSel

        'Auto-select 면 스킵
        If LangXMLFV = "Auto-select" Then
            GoTo LANG_SKIP
        End If

        '선택한 언어파일이 없으면 스킵
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\lang\" & LangXMLFV) = False Then
            MsgBox(LangXMLFV & " not found")
            GoTo LANG_SKIP
        End If

        Dim SR As New StreamReader(My.Application.Info.DirectoryPath & "\lang\" & LangXMLFV, System.Text.Encoding.UTF8)
        Dim XTR As New System.Xml.XmlTextReader(SR)
        Try
            Dim FN As String = Me.Font.Name, FNXP As String = Me.Font.Name, FS As Single = Me.Font.Size
            Do While XTR.Read
                Application.DoEvents()

                If XTR.Name = "FontName" Then FN = XTR.ReadString
                If XTR.Name = "FontNameXP" Then FNXP = XTR.ReadString
                If XTR.Name = "FontSize" Then FS = XTR.ReadString

                If Environment.OSVersion.Version.Major < 6 Then 'NT 5.X 이하
                    IndexPanel.Font = New Font(FNXP, FS)
                Else
                    IndexPanel.Font = New Font(FN, FS)
                End If

                If XTR.Name = "CancelBTN" Then CancelBTN.Text = XTR.ReadString

                If XTR.Name = "AVSIndexingV" Then LangCls.AVSIndexingV = XTR.ReadString

            Loop
        Catch ex As Exception
            MsgBox("LANG_LOAD_ERROR :" & ex.Message)
        Finally
            XTR.Close()
            SR.Close()
        End Try
LANG_SKIP:
        '=========================================

        Me.Text = LangCls.AVSIndexingV & " - FFmpegSource, " & DEStr

    End Sub

    Private Sub OnePTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OnePTimer.Tick
        OnePV += 0.1
        R_OnePV -= 0.1
    End Sub

    Private Sub TLabelTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TLabelTimer.Tick

        Dim hmsValue As String = ""
        Dim NowTimeSec = R_OnePV
        If NowTimeSec < 0 Then Exit Sub
        hmsValue = FunctionCls.TIME_TO_HMSMSTIME(NowTimeSec, False)
        If hmsValue <> "00:00:00" AndAlso ProgressBar.Value > 0 Then
            TLabel.Text = hmsValue
            AviSynthPP.INDEX_PVStr = hmsValue
        End If

    End Sub

End Class