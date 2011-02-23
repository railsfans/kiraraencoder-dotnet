﻿' ---------------------------------------------------------------------------------------
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

Public Class EncodingFrm

    '우선순위 설정
    Private Declare Function SetPriorityClass Lib "kernel32" (ByVal HPROCESS As Integer, ByVal dwPriorityClass As Integer) As Integer

    '일시정지/재시작
    Private Declare Function SuspendThread Lib "kernel32" (ByVal hThread As Long) As Long
    Private Declare Function ResumeThread Lib "kernel32" (ByVal hThread As Long) As Long

    '프론트엔드 코어
    Private OutputHandle_EI As SafeFileHandle = Nothing
    Private InputHandle_EI As SafeFileHandle = Nothing
    Private ProcessHandle_EI As IntPtr = Nothing
    Private ThreadHandle_EI As IntPtr = Nothing
    Private ThreadSignal_EI As New Threading.ManualResetEvent(False)
    Private ProcessID_EI As UInteger
    Private HWNDV As Long

    '프로세스 우선 순위
    Enum PriorityClass
        REALTIME_PRIORITY_CLASS = &H100
        HIGH_PRIORITY_CLASS = &H80
        ABOVE_NORMAL_PRIORITY_CLASS = 32768
        NORMAL_PRIORITY_CLASS = &H20
        BELOW_NORMAL_PRIORITY_CLASS = 16384
        IDLE_PRIORITY_CLASS = &H40
    End Enum

    '프로세스 종료 확인
    Dim ProcessEChkB As Boolean = False

    '중지여부
    Dim EncSTOPBool As Boolean = False

    '인코딩여부
    Public EncProcBool As Boolean = False

    'Pipe
    Dim PipeMode As Boolean = False

    'IndexProc
    Dim IndexProc As Boolean = False

    '제목표시줄백업
    Dim MainFrmTitleBack As String = ""

    '********************************
    '인덱스
    Public EncindexI As Integer = 0
    '********************************

    '인코딩 로그 부분
    Dim EncNMStartB As Boolean = False

    '저장경로
    Public SavePathStr As String = ""

    '메시지
    Public MessageBoxBTN As String = ""

    '-------------------------------------------
    Dim EncDuration As String = ""
    Dim EncDurationD As Single = 0.0
    Dim EncPositionD As Single = 0.0
    Dim TimeElapsed As Integer = 0
    Dim TimeS As Single = 0.0
    Dim FPSv As Single = 0.0
    Dim SpeedV As Single = 0.0
    Dim SuspendB As Boolean = False
    Dim FrameSumV As Integer = 0
    Dim EncPassStr As String = ""
    '-------------------------------------------

    'Win7진행바
    Dim _ITaskbarList3 As WinAPI.ITaskbarList3

    '오버라이드
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Const WM_SYSCOMMAND As Integer = &H112
        Const SC_MINIMIZE As Integer = &HF020

        Select Case m.Msg
            Case WM_SYSCOMMAND
                If m.WParam.ToInt32() = SC_MINIMIZE Then
                    MainFrm.WindowState = FormWindowState.Minimized
                    Exit Sub
                End If
        End Select

        MyBase.WndProc(m)
    End Sub

#Region "프론트엔드 코어"

    '=================================
    '코드 출처: http://www.vbforums.com/showthread.php?t=618110
    '위의 URL에 있는 핵심 소스를 사용하여 제작되었습니다.

    Private Sub WriteToOutputBox(ByVal MsgV As String)
        If OutputBox_EI.InvokeRequired Then
            Try
                Invoke(New Action(Of String)(AddressOf WriteToOutputBox), MsgV)
            Catch ex As Exception
            End Try
        Else
            '캐리지리턴/라인피드 처리(윈도우2000 대비//)
            If InStr(MsgV, vbCr & vbCr & vbLf & vbLf) <> 0 Then MsgV = Replace(MsgV, vbCr & vbCr & vbLf & vbLf, vbNewLine)

            '=====================================================
            If EncNMStartB = False Then
                InfoTextBox.AppendText(Replace(MsgV, vbCr, vbCrLf))
            End If

            '정보가져오기
            If InStr(MsgV, "Press [q] to stop encoding", CompareMethod.Text) <> 0 Then

                '정보 가져오기 시작
                Dim ia2 As Integer = 1, iia2 As Integer = 0
                Dim ta2 As String = ""

                '------------------
                'EncDuration
                '------------------
                If MainFrm.AVSCheckBox.Checked = True AndAlso PipeMode = False AndAlso (InStr(EncSetFrm.OutFComboBox.SelectedItem, "[AUDIO]", CompareMethod.Text) = 0) Then 'AviSynth 사용 (오디오만 인코딩 모드 아님)
                    ia2 = 1
                    iia2 = 0
                    ta2 = ""
                    If InStr(ia2, MsgV, "Duration:", CompareMethod.Text) Then
                        iia2 = InStr(ia2, MsgV, "Duration:", CompareMethod.Text)
                        If InStr(iia2, MsgV, ",", CompareMethod.Text) Then
                            ia2 = InStr(iia2, MsgV, ",", CompareMethod.Text) + 1
                            ta2 = Mid(MsgV, iia2, ia2 - iia2 - 1)
                        End If
                    Else
                        ia2 = ia2 + 1
                    End If
                    If ta2 <> "" Then
                        EncDuration = Replace(ta2, "Duration: ", "")
                        Try
                            EncDurationD = Val((Split(EncDuration, ":")(0) * 3600)) + Val((Split(EncDuration, ":")(1) * 60)) + Val(Split(Split(EncDuration, ":")(2), ".")(0)) + Val("0." & Split(EncDuration, ".")(1))
                            ProgressBar.Maximum = EncDurationD
                        Catch ex As Exception
                        End Try
                    End If
                Else
                    Dim PTimeInfo As String = MainFrm.EncListListView.Items(EncindexI).SubItems(11).Text
                    Dim SHTextBoxV As String = "00"
                    Dim SMTextBoxV As String = "00"
                    Dim SSTextBoxV As String = "00"
                    Dim SMSTextBoxV As String = "00"
                    Dim EHTextBoxV As String = "00"
                    Dim EMTextBoxV As String = "00"
                    Dim ESTextBoxV As String = "00"
                    Dim EMSTextBoxV As String = "00"

                    '시작시간
                    Dim i As Long = 1
                    Dim ii As Long = 0
                    Dim t As String = ""
                    If InStr(i, PTimeInfo, "[", CompareMethod.Text) Then
                        ii = InStr(i, PTimeInfo, "[", CompareMethod.Text)
                        If InStr(ii, PTimeInfo, " ", CompareMethod.Text) Then
                            i = InStr(ii, PTimeInfo, " ", CompareMethod.Text) + 1
                            t = Mid(PTimeInfo, ii, i - ii - 1)
                        End If
                    Else
                        i = i + 1
                    End If
                    If t <> "" Then
                        t = Mid(t, InStrRev(t, "[") + 1)
                        Try
                            SHTextBoxV = Split(t, ":")(0)
                            SMTextBoxV = Split(t, ":")(1)
                            SSTextBoxV = Split(Split(t, ":")(2), ".")(0)
                            SMSTextBoxV = Split(t, ".")(1)
                        Catch ex As Exception
                        End Try
                    End If
                    '종료시간
                    i = 1
                    ii = 0
                    t = ""
                    If InStr(i, PTimeInfo, "- ", CompareMethod.Text) Then
                        ii = InStr(i, PTimeInfo, "- ", CompareMethod.Text)
                        If InStr(ii, PTimeInfo, "]", CompareMethod.Text) Then
                            i = InStr(ii, PTimeInfo, "]", CompareMethod.Text) + 1
                            t = Mid(PTimeInfo, ii, i - ii - 1)
                        End If
                    Else
                        i = i + 1
                    End If
                    If t <> "" Then
                        t = Mid(t, InStrRev(t, "- ") + 2)
                        Try
                            EHTextBoxV = Split(t, ":")(0)
                            EMTextBoxV = Split(t, ":")(1)
                            ESTextBoxV = Split(Split(t, ":")(2), ".")(0)
                            EMSTextBoxV = Split(t, ".")(1)
                        Catch ex As Exception
                        End Try
                    End If
                    Dim STimeV As Single = (Val(SHTextBoxV) * 3600) + (Val(SMTextBoxV) * 60) + Val(SSTextBoxV) + Val("0." & SMSTextBoxV)
                    Dim ETimeV As Single = (Val(EHTextBoxV) * 3600) + (Val(EMTextBoxV) * 60) + Val(ESTextBoxV) + Val("0." & EMSTextBoxV)
                    Dim _TimeV As Double = 0.0
                    Dim __TimeV As Double = 0.0
                    If (ETimeV - STimeV) = 0 Then
                        Try
                            __TimeV = Val((Split(MainFrm.EncListListView.Items(EncindexI).SubItems(1).Text, ":")(0) * 3600)) + Val((Split(MainFrm.EncListListView.Items(EncindexI).SubItems(1).Text, ":")(1) * 60)) + Val(Split(Split(MainFrm.EncListListView.Items(EncindexI).SubItems(1).Text, ":")(2), ".")(0)) + Val("0." & Split(MainFrm.EncListListView.Items(EncindexI).SubItems(1).Text, ".")(1))
                            If MainFrm.AVSCheckBox.Checked = True AndAlso ETCPPFrm.RateCheckBox.Checked = True Then 'AviSynth 사용하고 배속모드 사용..(보통 오디오만 인코딩할 때 적용 된다.)
                                _TimeV = (1 / ETCPPFrm.RateNumericUpDown.Value) * __TimeV
                            Else
                                _TimeV = __TimeV
                            End If
                        Catch ex As Exception
                            _TimeV = 0.0
                        End Try
                    Else
                        Try
                            If MainFrm.AVSCheckBox.Checked = True AndAlso ETCPPFrm.RateCheckBox.Checked = True Then 'AviSynth 사용하고 배속모드 사용..(보통 오디오만 인코딩할 때 적용 된다.)
                                _TimeV = (1 / ETCPPFrm.RateNumericUpDown.Value) * (ETimeV - STimeV)
                            Else
                                _TimeV = ETimeV - STimeV
                            End If
                        Catch ex As Exception
                            _TimeV = 0.0
                        End Try
                    End If
                    EncDuration = FunctionCls.TIME_TO_HMSMSTIME(_TimeV, True)
                    EncDurationD = _TimeV
                    ProgressBar.Maximum = EncDurationD
                End If
                '------------------
                '프레임
                '------------------
                If MainFrm.AVSCheckBox.Checked = True Then 'AviSynth 사용
                    If ImagePPFrm.AviSynthFramerateCheckBox.Checked = True Then
                        Try
                            FPSv = Split(MainFrm.EncListListView.Items(EncindexI).SubItems(12).Text, ",")(1)
                        Catch ex As Exception
                        End Try
                    Else
                        FPSv = ImagePPFrm.AviSynthFramerateComboBox.Text
                    End If
                Else
                    If EncSetFrm.FramerateCheckBox.Checked = True Then
                        Try
                            FPSv = Split(MainFrm.EncListListView.Items(EncindexI).SubItems(12).Text, ",")(1)
                        Catch ex As Exception
                        End Try
                    Else
                        FPSv = EncSetFrm.FramerateComboBox.Text
                    End If
                End If
                '일시 정지/재시작 버튼 활성화//
                If PipeMode = False Then SuspendResumeButton.Enabled = True
            End If
            If InStr(MsgV, "global headers", CompareMethod.Text) <> 0 AndAlso InStr(MsgV, "muxing overhead", CompareMethod.Text) <> 0 AndAlso _
            InStr(InfoTextBox.Text, "global headers", CompareMethod.Text) = 0 AndAlso InStr(InfoTextBox.Text, "muxing overhead", CompareMethod.Text) = 0 Then
                InfoTextBox.AppendText(Strings.Mid(MsgV, InStr(MsgV, "video:", CompareMethod.Text)))
            End If

            '======================================================

            '정보얻기
            GETINFO(MsgV)
            LogStr.Text = MsgV

        End If
    End Sub

    Public Sub MsgSend(ByVal msg As String)

        If Not InputHandle_EI Is Nothing AndAlso Not InputHandle_EI.IsClosed Then
            Dim MessageBytes() As Byte = System.Text.Encoding.GetEncoding(0).GetBytes(msg & vbCrLf & vbCr)
            Dim BytesWritten As UInteger = 0
            WinAPI.WriteFile(InputHandle_EI, MessageBytes, CUInt(MessageBytes.Length - 1), BytesWritten, 0)
        End If

    End Sub

    Private Sub OutputInfo()

        Do
            Threading.Thread.Sleep(10)

            Do
                Threading.Thread.Sleep(10)

                Dim Buffer(0) As Byte
                Dim BytesRead As UInteger = 0
                Dim BytesAvailable As UInteger = 0

                Dim PNP As Boolean
                If Not OutputHandle_EI Is Nothing Then
                    PNP = WinAPI.PeekNamedPipe(OutputHandle_EI, Nothing, 0, 0, BytesAvailable, 0)
                End If

                If PNP = True Then
                    If BytesAvailable > 0 Then
                        ReDim Buffer(CInt(BytesAvailable))
                        If WinAPI.ReadFile(OutputHandle_EI, Buffer, CUInt(Buffer.Length), BytesRead, 0) Then
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

            If PipeMode = True Then
                HWNDV = WinAPI.FindWindowW(vbNullString, Environ("ComSpec"))
            Else
                HWNDV = WinAPI.FindWindowW(vbNullString, My.Application.Info.DirectoryPath & "\tools\ffmpeg\ffmpeg.exe")
            End If
            Dim WaitOnHandles(1) As IntPtr
            WaitOnHandles(0) = ProcessHandle_EI
            WaitOnHandles(1) = ThreadSignal_EI.SafeWaitHandle.DangerousGetHandle
            If WinAPI.WaitForMultipleObjects(2, WaitOnHandles, False, 0) = 0 Then
                EndOfProcess()
                Exit Do
            End If

            Application.DoEvents()
        Loop

    End Sub

    Private Sub EndOfProcess()

        If OutputBox_EI.InvokeRequired Then
            Invoke(New MethodInvoker(AddressOf EndOfProcess))
        Else
            DestroyHandles()
            ProcessEChkB = True
        End If

    End Sub

    Public Sub DestroyHandles()

        If ProcessHandle_EI <> IntPtr.Zero Then
            WinAPI.CloseHandle(ProcessHandle_EI)
        End If

        If Not InputHandle_EI Is Nothing AndAlso Not InputHandle_EI.IsClosed Then
            InputHandle_EI.Close()
        End If

        If Not OutputHandle_EI Is Nothing AndAlso Not OutputHandle_EI.IsClosed Then
            OutputHandle_EI.Close()
        End If

    End Sub

    '=================================

#End Region

    Private Sub LoadInitialization()

        '== 오브젝트
        OutputBox_EI.Text = ""
        InfoTextBox.Text = ""
        SuspendResumeButton.Text = LangCls.EncodingSuspend
        SuspendResumeButton.Enabled = False
        '== 로그
        PositionDurationLabel.Text = "--- / ---"
        FrameLabel.Text = "---"
        FilesizeLabel.Text = "---"
        QLabel.Text = "---"
        BitrateLabel.Text = "---"
        ProcessingRateLabel.Text = "---"
        TimeElapsedLabel.Text = "---"
        TimeRemainingLabel.Text = "---"
        '== 진행바
        ProgressBar.Maximum = 100
        ProgressBar.Value = 0
        '== 변수
        EncDuration = ""
        EncDurationD = 0.0
        EncPositionD = 0.0
        TimeElapsed = 0
        TimeS = 0.0
        FPSv = 0.0
        SpeedV = 0.0
        SuspendB = False
        FrameSumV = 0
        '== QStopB (로그관련부분)
        EncNMStartB = False

    End Sub

    Public Sub EncSub(ByVal InPATHV As String, ByVal CommandV As String, ByVal OutPATHV As String, ByVal FFMODE As Boolean, ByVal MUXMODE As Boolean)

        Dim MSGB As String = ""
        If FFMODE = True Then

            PipeMode = False
            MSGB = My.Application.Info.DirectoryPath & "\tools\ffmpeg\ffmpeg.exe -y -i " & Chr(34) & InPATHV & Chr(34) & " " & CommandV & " " & Chr(34) & OutPATHV & Chr(34)

        ElseIf MUXMODE = True Then

            PipeMode = False
            Try
                MSGB = My.Application.Info.DirectoryPath & "\tools\ffmpeg\ffmpeg.exe -y -i " & Chr(34) & Split(InPATHV, "|")(0) & Chr(34) & " -i " & Chr(34) & Split(InPATHV, "|")(1) & Chr(34) & _
                       " -map 0.0 -map 1.0 -vcodec copy -acodec copy " & CommandV & " " & Chr(34) & OutPATHV & Chr(34)
            Catch ex As Exception
                Exit Sub
            End Try

        ElseIf FFMODE = False AndAlso MUXMODE = False Then

            PipeMode = True
            MSGB = Chr(34) & InPATHV & Chr(34)

        Else
            Exit Sub
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
                               New HandleRef(Me, Process.GetCurrentProcess.Handle), InputHandle_EI, 0, False, WinAPI.DUPLICATE_SAME_ACCESS)
        WinAPI.DuplicateHandle(New HandleRef(Me, Process.GetCurrentProcess.Handle), TempOutputHandle, _
                               New HandleRef(Me, Process.GetCurrentProcess.Handle), OutputHandle_EI, 0, False, WinAPI.DUPLICATE_SAME_ACCESS)

        TempOutputHandle.Close()
        TempInputHandle.Close()
        TempOutputHandle.Dispose()
        TempInputHandle.Dispose()

        '프로세스 우선순위 설정
        Dim PPInt As Integer
        If PriorityComboBox.SelectedIndex = 0 Then
            PPInt = PriorityClass.IDLE_PRIORITY_CLASS
        ElseIf PriorityComboBox.SelectedIndex = 1 Then
            PPInt = PriorityClass.BELOW_NORMAL_PRIORITY_CLASS
        ElseIf PriorityComboBox.SelectedIndex = 2 Then
            PPInt = PriorityClass.NORMAL_PRIORITY_CLASS
        ElseIf PriorityComboBox.SelectedIndex = 3 Then
            PPInt = PriorityClass.ABOVE_NORMAL_PRIORITY_CLASS
        ElseIf PriorityComboBox.SelectedIndex = 4 Then
            PPInt = PriorityClass.HIGH_PRIORITY_CLASS
        ElseIf PriorityComboBox.SelectedIndex = 5 Then
            PPInt = PriorityClass.REALTIME_PRIORITY_CLASS
        Else
            PPInt = PriorityClass.NORMAL_PRIORITY_CLASS
        End If
        Dim ProcessInformation As New WinAPI.PROCESS_INFORMATION
        WinAPI.CreateProcess(Nothing, MSGB, SecurityAttributes, SecurityAttributes, True, PPInt, IntPtr.Zero, Nothing, StartupInfo, ProcessInformation)

        If ProcessInformation.dwProcessId <> 0 AndAlso ProcessInformation.hProcess <> IntPtr.Zero Then

            LoadInitialization()

            '타이머
            TimeElapsedTimer.Enabled = True

            '프로세스 종료 확인
            ProcessEChkB = False

            ProcessHandle_EI = ProcessInformation.hProcess
            ThreadHandle_EI = ProcessInformation.hThread
            ProcessID_EI = ProcessInformation.dwProcessId
            HWNDV = 0
            Dim ThreadSTR As New Threading.Thread(AddressOf OutputInfo)
            ThreadSTR.IsBackground = True
            ThreadSTR.Start()

            Do Until ProcessEChkB = True
                Application.DoEvents()
                Threading.Thread.Sleep(10)
            Loop
        Else
            Exit Sub
        End If

            '---------------------------------------

            '타이머
            TimeElapsedTimer.Enabled = False

    End Sub

    Private Sub GETINFO(ByVal MSGV As String)

        '정보 가져오기 시작
        Dim ia2 As Integer = 1, iia2 As Integer = 0
        Dim ta2 As String = ""

        '------------------
        '진행위치
        '------------------
        ia2 = 1
        iia2 = 0
        ta2 = ""
        If InStr(ia2, MSGV, "time=", CompareMethod.Text) Then
            iia2 = InStr(ia2, MSGV, "time=", CompareMethod.Text)
            If InStr(iia2, MSGV, "bitrate=", CompareMethod.Text) Then
                ia2 = InStr(iia2, MSGV, "bitrate=", CompareMethod.Text) + 1
                ta2 = Mid(MSGV, iia2, ia2 - iia2 - 1)
            End If
        Else
            ia2 = ia2 + 1
        End If
        If ta2 <> "" Then
            ta2 = Trim(Replace(ta2, "time=", ""))
            If IsNumeric(ta2) = True Then
                If ta2 = "10000000000.00" Then
                    PositionDurationLabel.Text = "Please wait..."
                Else
                    EncNMStartB = True
                    EncPositionD = ta2
                    If EncPositionD <= ProgressBar.Maximum Then
                        ProgressBar.Value = EncPositionD
                    Else
                        ProgressBar.Value = ProgressBar.Maximum
                    End If
                    PositionDurationLabel.Text = FunctionCls.TIME_TO_HMSMSTIME(ta2, True) & " / " & EncDuration
                End If

            End If
        End If
        '------------------
        '프레임
        '------------------
        ia2 = 1
        iia2 = 0
        ta2 = ""
        If InStr(ia2, MSGV, "frame=", CompareMethod.Text) Then
            iia2 = InStr(ia2, MSGV, "frame=", CompareMethod.Text)
            If InStr(iia2, MSGV, "fps=", CompareMethod.Text) Then
                ia2 = InStr(iia2, MSGV, "fps=", CompareMethod.Text) + 1
                ta2 = Mid(MSGV, iia2, ia2 - iia2 - 1)
            End If
        Else
            ia2 = ia2 + 1
        End If
        If ta2 <> "" Then
            ta2 = Trim(Replace(ta2, "frame=", ""))
            If IsNumeric(ta2) = True Then
                FrameLabel.Text = ta2
            End If
        End If
        '------------------
        '사이즈(파일)
        '------------------
        ia2 = 1
        iia2 = 0
        ta2 = ""
        If InStr(ia2, MSGV, "size=", CompareMethod.Text) Then
            iia2 = InStr(ia2, MSGV, "size=", CompareMethod.Text)
            If InStr(iia2, MSGV, "kB", CompareMethod.Text) Then
                ia2 = InStr(iia2, MSGV, "kB", CompareMethod.Text) + 1
                ta2 = Mid(MSGV, iia2, ia2 - iia2 - 1)
            End If
        Else
            ia2 = ia2 + 1
        End If
        If ta2 <> "" Then
            ta2 = Trim(Replace(ta2, "size=", ""))

            '네로AAC일경우
            If EncSetFrm.AudioCodecComboBox.Text = "[MP4] Nero AAC" Then
                If My.Computer.FileSystem.FileExists(SavePathStr) = True Then
                    ta2 = My.Computer.FileSystem.GetFileInfo(SavePathStr).Length
                    ta2 = Int(ta2 / 1024) 'KB로
                End If
            ElseIf EncSetFrm.AudioCodecComboBox.Text = "Nero AAC" AndAlso EncToolStripStatusLabel.Text = LangCls.EncodingNeroAACEncoding Then
                If My.Computer.FileSystem.FileExists(SavePathStr & "A") = True Then
                    ta2 = My.Computer.FileSystem.GetFileInfo(SavePathStr & "A").Length
                    ta2 = Int(ta2 / 1024) 'KB로
                End If
            End If

            If IsNumeric(ta2) = True Then
                '파일사이즈 단위//
                Dim ta3 As String = ""
                If Val(ta2) >= (1024 ^ 4) Then
                    ta3 = Format((Val(ta2) / (1024 ^ 4)), "0.00") & "PB" & " (" & ta2 & "kB)"
                ElseIf Val(ta2) >= (1024 ^ 3) Then
                    ta3 = Format((Val(ta2) / (1024 ^ 3)), "0.00") & "TB" & " (" & ta2 & "kB)"
                ElseIf Val(ta2) >= (1024 ^ 2) Then
                    ta3 = Format((Val(ta2) / (1024 ^ 2)), "0.00") & "GB" & " (" & ta2 & "kB)"
                ElseIf Val(ta2) >= 1024 Then
                    ta3 = Format((Val(ta2) / 1024), "0.00") & "MB" & " (" & ta2 & "kB)"
                Else
                    ta3 = ta2 & "kB"
                End If
                FilesizeLabel.Text = ta3
            End If
        End If
        '------------------
        '큐
        '------------------
        ia2 = 1
        iia2 = 0
        ta2 = ""
        If InStr(ia2, MSGV, "q=", CompareMethod.Text) Then
            iia2 = InStr(ia2, MSGV, "q=", CompareMethod.Text)
            If InStr(iia2, MSGV, "size=", CompareMethod.Text) Then
                ia2 = InStr(iia2, MSGV, "size=", CompareMethod.Text) + 1
                ta2 = Mid(MSGV, iia2, ia2 - iia2 - 1)
            End If
        Else
            ia2 = ia2 + 1
        End If
        If ta2 <> "" Then
            ta2 = Trim(Replace(ta2, "q=", ""))
            If IsNumeric(ta2) = True Then
                QLabel.Text = ta2
            End If
        End If
        '------------------
        '비트레이트
        '------------------
        ia2 = 1
        iia2 = 0
        ta2 = ""
        If InStr(ia2, MSGV, "bitrate=", CompareMethod.Text) Then
            iia2 = InStr(ia2, MSGV, "bitrate=", CompareMethod.Text)
            If InStr(iia2, MSGV, "kbits/s", CompareMethod.Text) Then
                ia2 = InStr(iia2, MSGV, "kbits/s", CompareMethod.Text) + 1
                ta2 = Mid(MSGV, iia2, ia2 - iia2 - 1)
            End If
        Else
            ia2 = ia2 + 1
        End If
        If ta2 <> "" Then
            ta2 = Trim(Replace(ta2, "bitrate=", ""))

            '네로AAC일경우
            If EncSetFrm.AudioCodecComboBox.Text = "[MP4] Nero AAC" Then
                BitrateLabel.Text = "---"
            ElseIf EncSetFrm.AudioCodecComboBox.Text = "Nero AAC" AndAlso EncToolStripStatusLabel.Text = LangCls.EncodingNeroAACEncoding Then
                BitrateLabel.Text = "---"
            Else '아니면
                If IsNumeric(ta2) = True Then
                    BitrateLabel.Text = ta2 & " Kbit/s"
                End If
            End If

        End If
        '------------------
        '속도
        '------------------
        'ia2 = 1
        'iia2 = 0
        'ta2 = ""
        'If InStr(ia2, MSGV, "fps=", CompareMethod.Text) Then
        '    iia2 = InStr(ia2, MSGV, "fps=", CompareMethod.Text)
        '    If InStr(iia2, MSGV, "q=", CompareMethod.Text) Then
        '        ia2 = InStr(iia2, MSGV, "q=", CompareMethod.Text) + 1
        '        ta2 = Mid(MSGV, iia2, ia2 - iia2 - 1)
        '    End If
        'Else
        '    ia2 = ia2 + 1
        'End If
        'If ta2 <> "" Then
        '    ta2 = Trim(Replace(ta2, "fps=", ""))
        '    If IsNumeric(ta2) = True Then
        '        ProcessingRateLabel.Text = ta2 & " fps"
        '        TimeRemainingLabel.Text = FunctionCls.TIME_TO_HMSMSTIME((EncDurationD - EncPositionD) / (Val(ta2) / FPSv), False)
        '    End If
        'End If
        '------------------
        '남은시간
        '------------------
        If SpeedV > 0 Then
            TimeRemainingLabel.Text = FunctionCls.TIME_TO_HMSMSTIME(((EncDurationD - EncPositionD) / SpeedV), False)
        End If

    End Sub
    Private Sub ENCSTRSUB()
        '인코딩온
        EncProcBool = True
        '메인폼타이틀
        MainFrmTitleBack = MainFrm.Text
        '캡션타이머온
        CapTimer.Enabled = True
        '*************************************************

        '대기상태로
        For Me.EncindexI = 0 To MainFrm.EncListListView.Items.Count - 1
            MainFrm.EncListListView.Items(EncindexI).SubItems(6).Text = LangCls.MainWaitStr
            MainFrm.EncListListView.Items(EncindexI).SubItems(7).Text = ""
        Next

        '--------------

        Dim EncI As Integer = MainFrm.EncListListView.Items.Count
        Me.EncindexI = 0
        Do Until EncI <= Me.EncindexI

            Try

                '체크여부 확인
                If MainFrm.EncListListView.Items(EncindexI).Checked = False Then
                    MainFrm.EncListListView.Items(EncindexI).SubItems(6).Text = LangCls.MainSkipStr
                    GoTo SKIP
                Else
                    MainFrm.EncListListView.Items(EncindexI).SubItems(6).Text = LangCls.MainEncodingStr
                End If

                '비디오와 오디오 둘다 없으면 오류처리
                If MainFrm.EncListListView.Items(EncindexI).SubItems(8).Text = "None" AndAlso MainFrm.EncListListView.Items(EncindexI).SubItems(9).Text = "None" Then
                    MainFrm.EncListListView.Items(EncindexI).SubItems(6).Text = LangCls.MainErrorStr
                    GoTo SKIP
                End If


                '++++++++++++++++++++++++++++++++++++++++++++++++++++++




                '---------------------------------
                ' 원본 파일의 파일 이름만 추출
                '=================================
                Dim FilenameV As String = ""
                If InStrRev(MainFrm.EncListListView.Items(EncindexI).SubItems(0).Text, ".") <> 0 Then
                    FilenameV = Strings.Left(MainFrm.EncListListView.Items(EncindexI).SubItems(0).Text, InStrRev(MainFrm.EncListListView.Items(EncindexI).SubItems(0).Text, ".") - 1)
                Else
                    FilenameV = MainFrm.EncListListView.Items(EncindexI).SubItems(0).Text
                End If

                '---------------------------------
                ' 확장자 (출력형식 확장자)
                '=================================
                Dim ExtensionV As String = ""
                Try
                    If EncSetFrm.ExtensionTextBox.Text = "" Then
                        If InStr(EncSetFrm.OutFComboBox.SelectedItem, "[AUDIO]", CompareMethod.Text) = 0 Then '오디오만 인코딩 아님//
                            ExtensionV = "." & LCase(Replace(Split(EncSetFrm.OutFComboBox.Text, "]")(0), "[", ""))
                        Else
                            ExtensionV = "." & LCase(Replace(Split(EncSetFrm.AudioCodecComboBox.Text, "]")(0), "[", ""))
                        End If
                    Else
                        ExtensionV = "." & EncSetFrm.ExtensionTextBox.Text
                    End If
                Catch ex As Exception
                End Try

                '---------------------------------
                ' 출력경로검사
                '=================================
                Dim SavePathTextBoxV As String = ""
                If Strings.Right(MainFrm.SavePathTextBox.Text, 1) = "\" Then
                    SavePathTextBoxV = MainFrm.SavePathTextBox.Text
                Else
                    SavePathTextBoxV = MainFrm.SavePathTextBox.Text & "\"
                End If

                '---------------------------------
                ' 저장파일
                '=================================
                SavePathStr = SavePathTextBoxV & EncSetFrm.HeaderTextBox.Text & FilenameV & ExtensionV

                '***********************************************
                '출력과 원본이 같으면 스킵//
                '***********************************************
                If MainFrm.EncListListView.Items(EncindexI).SubItems(10).Text = SavePathStr Then
                    MainFrm.EncListListView.Items(EncindexI).SubItems(6).Text = LangCls.MainErrorStr
                    MainFrm.EncListListView.Items(EncindexI).SubItems(7).Text = LangCls.MainFileSame
                    GoTo SKIP
                End If

                '***********************************************
                '저장파일 덮어쓰기 부분//
                '***********************************************
                If My.Computer.FileSystem.FileExists(SavePathStr) = True Then
                    If MessageBoxBTN = "" OrElse MessageBoxBTN = "YES" OrElse MessageBoxBTN = "NO" Then
                        MessageFrm.FilePathLabel.Text = SavePathStr
                        Try
                            MessageFrm.ShowDialog(Me)
                        Catch ex As Exception
                        End Try
                    End If
                    If MessageBoxBTN = "NO" OrElse MessageBoxBTN = "NOTOALL" Then
                        MainFrm.EncListListView.Items(EncindexI).SubItems(6).Text = LangCls.MainSkipStr
                        GoTo SKIP
                    End If
                End If









                '++++++++++++++++++++++++++++++++++++++++++++++++++++++







                '***********************************
                ' 비디오필터 crop
                '***********************************
                Dim VF_CropV As String = ""
                If InStr(EncSetFrm.OutFComboBox.SelectedItem, "[AUDIO]", CompareMethod.Text) = 0 Then '오디오만 인코딩 아님//
                    If MainFrm.AVSCheckBox.Checked = False Then 'AviSynth 사용 안 함
                        Try
                            Dim LeftCV As Integer = 0
                            Dim TopCV As Integer = 0
                            Dim RightCV As Integer = 0
                            Dim BottomCV As Integer = 0
                            LeftCV = Split(MainFrm.EncListListView.Items(EncindexI).SubItems(15).Text, ",")(0)
                            TopCV = Split(MainFrm.EncListListView.Items(EncindexI).SubItems(15).Text, ",")(1)
                            RightCV = Split(MainFrm.EncListListView.Items(EncindexI).SubItems(15).Text, ",")(2)
                            BottomCV = Split(MainFrm.EncListListView.Items(EncindexI).SubItems(15).Text, ",")(3)
                            If LeftCV = 0 AndAlso TopCV = 0 AndAlso RightCV = 0 AndAlso BottomCV = 0 Then
                                VF_CropV = ""
                            Else
                                VF_CropV = ", crop=" & Val(Split(Split(MainFrm.EncListListView.Items(EncindexI).SubItems(12).Text, ",")(0), "x")(0)) - LeftCV - RightCV & ":" & _
                                                       Val(Split(Split(MainFrm.EncListListView.Items(EncindexI).SubItems(12).Text, ",")(0), "x")(1)) - TopCV - BottomCV & ":" & _
                                                       LeftCV & ":" & _
                                                       TopCV
                            End If
                        Catch ex As Exception
                            VF_CropV = ""
                        End Try
                    End If
                End If

                '***********************************
                ' 비디오필터 image = crop, scale, pad
                '***********************************
                Dim VF_imageVTextBox As String = ""
                If InStr(EncSetFrm.OutFComboBox.SelectedItem, "[AUDIO]", CompareMethod.Text) = 0 Then '오디오만 인코딩 아님//
                    If MainFrm.AVSCheckBox.Checked = False Then 'AviSynth 사용 안 함
                        With EncSetFrm

                            Dim SettingSizeWidthV, SettingSizeHeightV As Integer
                            Dim SourceSizeV, SourceWidthV, SourceHeightV
                            Dim ResizeWidthV, ResizeHeightV
                            Dim LetterWidthV, LetterHeightV
                            Dim CropWidthV, CropHeightV
                            Dim RealnputWidthV, RealnputHeightV, RealnputLetterWidthV, RealnputLetterHeightV, RealnputCropWidthV, RealnputCropHeightV

                            If .ImageSizeCheckBox.Checked = False Then

                                SettingSizeWidthV = .ImageSizeWidthTextBox.Text
                                SettingSizeHeightV = .ImageSizeHeightTextBox.Text

                                Try
                                    SourceSizeV = Split(MainFrm.EncListListView.Items(EncindexI).SubItems(12).Text, ",")(0)
                                Catch ex As Exception
                                    SourceSizeV = "0x0"
                                    GoTo ImageSkip
                                End Try

                                If SourceSizeV = "x" Then
                                    GoTo ImageSkip
                                End If

                                If SourceSizeV <> "" AndAlso .AspectComboBox.Text = LangCls.EncSetLetterBoxAspectComboBox Then '사이즈입력받고, 레터박스 붙이기면

                                    '/////비율 시작
                                    If .AspectComboBox2.Text = LangCls.EncSetOutputAspectComboBox2 Then 'DAR(출력 비율)

                                        Dim DAR0 As Integer = 1, DAR00 As Integer = 0
                                        Dim DARtes As String = ""
                                        If InStr(DAR0, MainFrm.EncListListView.Items(EncindexI).SubItems(8).Text, "DAR ", CompareMethod.Text) Then
                                            DAR00 = InStr(DAR0, MainFrm.EncListListView.Items(EncindexI).SubItems(8).Text, "DAR ", CompareMethod.Text) + 4
                                            If InStr(DAR00, MainFrm.EncListListView.Items(EncindexI).SubItems(8).Text, " ", CompareMethod.Text) Then
                                                DAR0 = InStr(DAR00, MainFrm.EncListListView.Items(EncindexI).SubItems(8).Text, " ", CompareMethod.Text) + 1
                                                DARtes = Mid(MainFrm.EncListListView.Items(EncindexI).SubItems(8).Text, DAR00, DAR0 - DAR00 - 1)
                                                DARtes = Replace(Replace(DARtes, ",", ""), "]", "")
                                            End If
                                        Else
                                            DAR0 = DAR0 + 1
                                        End If

                                        If DARtes <> "" Then 'else Location Blank
                                            Try
                                                SourceWidthV = Split(DARtes, ":")(0)
                                                SourceHeightV = Split(DARtes, ":")(1)
                                            Catch ex As Exception
                                                SourceWidthV = 0
                                                SourceHeightV = 0
                                            End Try
                                        Else
                                            Try
                                                SourceWidthV = Split(SourceSizeV, "x")(0)
                                                SourceHeightV = Split(SourceSizeV, "x")(1)
                                            Catch ex As Exception
                                                SourceWidthV = 0
                                                SourceHeightV = 0
                                            End Try
                                        End If

                                    ElseIf .AspectComboBox2.Text = LangCls.EncSetOriginalAspectComboBox2 Then 'SAR(원본 비율)
                                        Try
                                            SourceWidthV = Split(SourceSizeV, "x")(0)
                                            SourceHeightV = Split(SourceSizeV, "x")(1)
                                        Catch ex As Exception
                                            SourceWidthV = 0
                                            SourceHeightV = 0
                                        End Try
                                    Else '아니면
                                        SourceWidthV = .AspectWTextBox.Text
                                        SourceHeightV = .AspectHTextBox.Text
                                    End If
                                    '/////비율 끝

                                    ResizeWidthV = Format((SourceWidthV / SourceHeightV / 4) * SettingSizeHeightV, 0) * 4
                                    ResizeHeightV = Format((SourceHeightV / SourceWidthV / 4) * SettingSizeWidthV, 0) * 4

                                    LetterWidthV = (.ImageSizeWidthTextBox.Text - ResizeWidthV) / 2
                                    LetterHeightV = (.ImageSizeHeightTextBox.Text - ResizeHeightV) / 2

                                    If (100 * (SourceWidthV / SourceHeightV)) - (100 * (SettingSizeWidthV / SettingSizeHeightV)) > 0 Then
                                        RealnputWidthV = SettingSizeWidthV
                                        RealnputHeightV = ResizeHeightV
                                        RealnputLetterWidthV = 0
                                        RealnputLetterHeightV = LetterHeightV
                                        RealnputCropWidthV = 0
                                        RealnputCropHeightV = 0
                                    ElseIf (100 * (SettingSizeWidthV / SettingSizeHeightV)) - (100 * (SourceWidthV / SourceHeightV)) > 0 Then
                                        RealnputWidthV = ResizeWidthV
                                        RealnputHeightV = SettingSizeHeightV
                                        RealnputLetterWidthV = LetterWidthV
                                        RealnputLetterHeightV = 0
                                        RealnputCropWidthV = 0
                                        RealnputCropHeightV = 0
                                    Else
                                        RealnputWidthV = SettingSizeWidthV
                                        RealnputHeightV = SettingSizeHeightV
                                        RealnputLetterWidthV = 0
                                        RealnputLetterHeightV = 0
                                        RealnputCropWidthV = 0
                                        RealnputCropHeightV = 0
                                    End If

                                ElseIf SourceSizeV <> "" AndAlso .AspectComboBox.Text = LangCls.EncSetCropAspectComboBox Then '사이즈입력받고, 비율 자르기면

                                    '/////비율 시작
                                    If .AspectComboBox2.Text = LangCls.EncSetOutputAspectComboBox2 Then 'DAR(출력 비율)

                                        Dim DAR0 As Integer = 1, DAR00 As Integer = 0
                                        Dim DARtes As String = ""
                                        If InStr(DAR0, MainFrm.EncListListView.Items(EncindexI).SubItems(8).Text, "DAR ", CompareMethod.Text) Then
                                            DAR00 = InStr(DAR0, MainFrm.EncListListView.Items(EncindexI).SubItems(8).Text, "DAR ", CompareMethod.Text) + 4
                                            If InStr(DAR00, MainFrm.EncListListView.Items(EncindexI).SubItems(8).Text, " ", CompareMethod.Text) Then
                                                DAR0 = InStr(DAR00, MainFrm.EncListListView.Items(EncindexI).SubItems(8).Text, " ", CompareMethod.Text) + 1
                                                DARtes = Mid(MainFrm.EncListListView.Items(EncindexI).SubItems(8).Text, DAR00, DAR0 - DAR00 - 1)
                                                DARtes = Replace(Replace(DARtes, ",", ""), "]", "")
                                            End If
                                        Else
                                            DAR0 = DAR0 + 1
                                        End If

                                        If DARtes <> "" Then 'else Location Blank
                                            Try
                                                SourceWidthV = Split(DARtes, ":")(0)
                                                SourceHeightV = Split(DARtes, ":")(1)
                                            Catch ex As Exception
                                                SourceWidthV = 0
                                                SourceHeightV = 0
                                            End Try
                                        Else
                                            Try
                                                SourceWidthV = Split(SourceSizeV, "x")(0)
                                                SourceHeightV = Split(SourceSizeV, "x")(1)
                                            Catch ex As Exception
                                                SourceWidthV = 0
                                                SourceHeightV = 0
                                            End Try
                                        End If

                                    ElseIf .AspectComboBox2.Text = LangCls.EncSetOriginalAspectComboBox2 Then 'SAR(원본 비율)
                                        Try
                                            SourceWidthV = Split(SourceSizeV, "x")(0)
                                            SourceHeightV = Split(SourceSizeV, "x")(1)
                                        Catch ex As Exception
                                            SourceWidthV = 0
                                            SourceHeightV = 0
                                        End Try
                                    Else '아니면
                                        SourceWidthV = .AspectWTextBox.Text
                                        SourceHeightV = .AspectHTextBox.Text
                                    End If
                                    '/////비율 끝

                                    ResizeWidthV = Format((SourceWidthV / SourceHeightV / 4) * SettingSizeHeightV, 0) * 4
                                    ResizeHeightV = Format((SourceHeightV / SourceWidthV / 4) * SettingSizeWidthV, 0) * 4

                                    CropWidthV = (.ImageSizeWidthTextBox.Text - ResizeWidthV) / 2
                                    CropHeightV = (.ImageSizeHeightTextBox.Text - ResizeHeightV) / 2

                                    If (100 * (SourceWidthV / SourceHeightV)) - (100 * (SettingSizeWidthV / SettingSizeHeightV)) > 0 Then
                                        RealnputWidthV = SettingSizeWidthV - (CropWidthV * 2)
                                        RealnputHeightV = SettingSizeHeightV
                                        RealnputLetterWidthV = 0
                                        RealnputLetterHeightV = 0
                                        RealnputCropWidthV = CropWidthV
                                        RealnputCropHeightV = 0
                                    ElseIf (100 * (SettingSizeWidthV / SettingSizeHeightV)) - (100 * (SourceWidthV / SourceHeightV)) > 0 Then
                                        RealnputWidthV = SettingSizeWidthV
                                        RealnputHeightV = SettingSizeHeightV - (CropHeightV * 2)
                                        RealnputLetterWidthV = 0
                                        RealnputLetterHeightV = 0
                                        RealnputCropWidthV = 0
                                        RealnputCropHeightV = CropHeightV
                                    Else
                                        RealnputWidthV = SettingSizeWidthV
                                        RealnputHeightV = SettingSizeHeightV
                                        RealnputLetterWidthV = 0
                                        RealnputLetterHeightV = 0
                                        RealnputCropWidthV = 0
                                        RealnputCropHeightV = 0
                                    End If

                                Else '아니면
ImageSkip:
                                    RealnputWidthV = SettingSizeWidthV
                                    RealnputHeightV = SettingSizeHeightV
                                    RealnputLetterWidthV = 0
                                    RealnputLetterHeightV = 0
                                    RealnputCropWidthV = 0
                                    RealnputCropHeightV = 0
                                End If

                                If SourceSizeV <> "" AndAlso .AspectComboBox.Text = LangCls.EncSetLetterBoxAspectComboBox Then '사이즈입력받고, 레터박스 붙이기면
                                    VF_imageVTextBox = ", scale=" & RealnputWidthV & ":" & RealnputHeightV & ", pad=" & Val(RealnputWidthV) + (Val(RealnputLetterWidthV) * 2) & ":" & Val(RealnputHeightV) + (Val(RealnputLetterHeightV) * 2) & ":" & RealnputLetterWidthV & ":" & RealnputLetterHeightV
                                ElseIf SourceSizeV <> "" AndAlso .AspectComboBox.Text = LangCls.EncSetCropAspectComboBox Then '사이즈입력받고, 비율 자르기면
                                    VF_imageVTextBox = ", scale=" & RealnputWidthV & ":" & RealnputHeightV & ", crop=" & Val(RealnputWidthV) + (Val(RealnputCropWidthV) * 2) & ":" & Val(RealnputHeightV) + (Val(RealnputCropHeightV) * 2) & ":" & -1 * Val(RealnputCropWidthV) & ":" & -1 * Val(RealnputCropHeightV)
                                Else
                                    VF_imageVTextBox = ", scale=" & RealnputWidthV & ":" & RealnputHeightV
                                End If

                            End If

                        End With
                    End If
                End If

                '***********************************
                ' 비디오, 오디오 맵
                '***********************************
                Dim VideoMapV As String = ""
                Dim AudioMapV As String = ""
                Dim NeroAACAudioMapV As String = ""
                Dim AVMapV As String = ""
                If MainFrm.AVSCheckBox.Checked = False Then 'AviSynth 사용 안 함

                    Try
                        VideoMapV = Split(Split(Split(MainFrm.EncListListView.Items(EncindexI).SubItems(8).Text, ":")(0), "#")(1), "(")(0)
                        If IsNumeric(VideoMapV) = False Then
                            VideoMapV = Split(Split(Split(MainFrm.EncListListView.Items(EncindexI).SubItems(8).Text, ":")(0), "#")(1), "[")(0)
                        End If
                    Catch ex As Exception
                    End Try
                    Try
                        AudioMapV = Split(Split(MainFrm.EncListListView.Items(EncindexI).SubItems(4).Text, "#")(1), "(")(0)
                        If IsNumeric(AudioMapV) = False Then
                            AudioMapV = Split(Split(MainFrm.EncListListView.Items(EncindexI).SubItems(4).Text, "#")(1), "[")(0)
                        End If
                    Catch ex As Exception
                    End Try

                    If EncSetFrm.AudioCodecComboBox.Text <> "Nero AAC" Then '네로 AAC 가 아니면
                        If InStr(EncSetFrm.OutFComboBox.SelectedItem, "[AUDIO]", CompareMethod.Text) = 0 Then '오디오만 인코딩 아님//
                            If VideoMapV <> "" AndAlso AudioMapV <> "" Then
                                AVMapV = " -map " & VideoMapV & " -map " & AudioMapV
                            End If
                        Else '오디오만 인코딩, 오디오맵만,.,.
                            If AudioMapV <> "" Then
                                AVMapV = " -map " & AudioMapV
                            End If
                        End If
                    Else
                        If AudioMapV <> "" Then
                            NeroAACAudioMapV = " -map " & AudioMapV
                        End If
                    End If

                End If




                ' 위의 코드는 FFmpeg 에서만! AviSynth 무관 //
                ' 영상에따라 값이 다르므로 인코딩 시작전에 분석을 해야 함 //
                '============================================================================================



                '***********************************
                ' 구간설정
                '***********************************
                Dim PTimeInfo As String = MainFrm.EncListListView.Items(EncindexI).SubItems(11).Text
                Dim StartHMSV As Single = 0.0
                Dim EndHMSV As Single = 0.0
                Dim PlayHMSV As Single = 0.0
                Dim SSTV As String = ""
                '시작시간
                Dim i As Long = 1
                Dim ii As Long = 0
                Dim t As String = ""
                If InStr(i, PTimeInfo, "[", CompareMethod.Text) Then
                    ii = InStr(i, PTimeInfo, "[", CompareMethod.Text)
                    If InStr(ii, PTimeInfo, " ", CompareMethod.Text) Then
                        i = InStr(ii, PTimeInfo, " ", CompareMethod.Text) + 1
                        t = Mid(PTimeInfo, ii, i - ii - 1)
                    End If
                Else
                    i = i + 1
                End If
                If t <> "" Then
                    t = Mid(t, InStrRev(t, "[") + 1)
                    Try
                        StartHMSV = Val((Split(t, ":")(0) * 3600)) + Val((Split(t, ":")(1) * 60)) + Val(Split(Split(t, ":")(2), ".")(0)) + Val("0." & Split(t, ".")(1))
                    Catch ex As Exception
                    End Try
                End If
                '종료시간
                i = 1
                ii = 0
                t = ""
                If InStr(i, PTimeInfo, "- ", CompareMethod.Text) Then
                    ii = InStr(i, PTimeInfo, "- ", CompareMethod.Text)
                    If InStr(ii, PTimeInfo, "]", CompareMethod.Text) Then
                        i = InStr(ii, PTimeInfo, "]", CompareMethod.Text) + 1
                        t = Mid(PTimeInfo, ii, i - ii - 1)
                    End If
                Else
                    i = i + 1
                End If
                If t <> "" Then
                    t = Mid(t, InStrRev(t, "- ") + 2)
                    Try
                        EndHMSV = Val((Split(t, ":")(0) * 3600)) + Val((Split(t, ":")(1) * 60)) + Val(Split(Split(t, ":")(2), ".")(0)) + Val("0." & Split(t, ".")(1))
                    Catch ex As Exception
                    End Try
                End If
                '재생시간
                i = 1
                ii = 0
                t = ""
                If InStr(i, PTimeInfo, "", CompareMethod.Text) Then
                    ii = InStr(i, PTimeInfo, "", CompareMethod.Text)
                    If InStr(ii, PTimeInfo, " ", CompareMethod.Text) Then
                        i = InStr(ii, PTimeInfo, " ", CompareMethod.Text) + 1
                        t = Mid(PTimeInfo, ii, i - ii - 1)
                    End If
                Else
                    i = i + 1
                End If
                If t <> "" Then
                    Try
                        PlayHMSV = Val((Split(t, ":")(0) * 3600)) + Val((Split(t, ":")(1) * 60)) + Val(Split(Split(t, ":")(2), ".")(0)) + Val("0." & Split(t, ".")(1))
                    Catch ex As Exception
                    End Try
                End If
                If MainFrm.AVSCheckBox.Checked = False Then 'AviSynth 사용 안 함
                    If StartHMSV = 0 AndAlso EndHMSV <> 0 Then '종료시간만
                        SSTV = " -t " & EndHMSV
                    ElseIf StartHMSV <> 0 AndAlso EndHMSV <> 0 Then '시작시간 or 시작시간과 종료시간
                        SSTV = " -ss " & StartHMSV & " -t " & EndHMSV - StartHMSV
                    End If
                End If

                Dim _TimeV As Double = 0.0
                Dim __TimeV As Double = 0.0
                If (EndHMSV - StartHMSV) = 0 Then
                    Try
                        __TimeV = Val((Split(MainFrm.EncListListView.Items(EncindexI).SubItems(1).Text, ":")(0) * 3600)) + Val((Split(MainFrm.EncListListView.Items(EncindexI).SubItems(1).Text, ":")(1) * 60)) + Val(Split(Split(MainFrm.EncListListView.Items(EncindexI).SubItems(1).Text, ":")(2), ".")(0)) + Val("0." & Split(MainFrm.EncListListView.Items(EncindexI).SubItems(1).Text, ".")(1))
                        If MainFrm.AVSCheckBox.Checked = True AndAlso ETCPPFrm.RateCheckBox.Checked = True Then 'AviSynth 사용하고 배속모드 사용..
                            _TimeV = (1 / ETCPPFrm.RateNumericUpDown.Value) * __TimeV
                        Else
                            _TimeV = __TimeV
                        End If
                    Catch ex As Exception
                        _TimeV = 0.0
                    End Try
                Else
                    Try
                        If MainFrm.AVSCheckBox.Checked = True AndAlso ETCPPFrm.RateCheckBox.Checked = True Then 'AviSynth 사용하고 배속모드 사용..
                            _TimeV = (1 / ETCPPFrm.RateNumericUpDown.Value) * (EndHMSV - StartHMSV)
                        Else
                            _TimeV = EndHMSV - StartHMSV
                        End If
                    Catch ex As Exception
                        _TimeV = 0.0
                    End Try
                End If

                '---------------------------------
                ' 재생시간과, 오디오 비트레이트, 용량을 기준으로 비디오 비트레이트 값 산출(v1.0a)
                '=================================
                Dim CalcVideoBitrateStr As String = ""
                If EncSetFrm.SizeEncCheckBox.Checked = True Then '용량을 기준으로 인코딩 여부 (참)
                    If EncSetFrm.VideoModeComboBox.SelectedIndex = EncSetFrm.VideoModeComboBox.FindString("[1PASS-CBR]", -1) OrElse _
                    EncSetFrm.VideoModeComboBox.SelectedIndex = EncSetFrm.VideoModeComboBox.FindString("[2PASS-CBR]", -1) Then  'CBR 체크

                        If InStr(EncSetFrm.OutFComboBox.SelectedItem, "[AUDIO]", CompareMethod.Text) <> 0 Then '오디오만이므로 비디오 제외.
                        Else '둘다

                            '*****************
                            ' MainFrm 에 예상용량 추출부분에서 그대로 퍼옴 ㄷㄷ
                            '*****************

                            '//////////////////////////////
                            '여기부터
                            '///
                            '오디오 부분
                            Dim ExAudioB As Boolean = False '예외스킵
                            Dim AKByteV As Single = Val(EncSetFrm.AudioBitrateComboBox.Text) / 8
                            '코덱
                            If ExAudioB = False Then
                                If EncSetFrm.AudioCodecComboBox.Text = "[WAV] signed 16-bit little-endian PCM" Then 'WAV
                                    Dim ACHV As Integer = 0
                                    If MainFrm.AVSCheckBox.Checked = True Then 'AviSynth 사용
                                        If AudioPPFrm.AviSynthChComboBox.Text = LangCls.AudioPPdolbypComboBox Then
                                            ACHV = 2
                                        ElseIf AudioPPFrm.AviSynthChComboBox.Text = LangCls.AudioPPdolbysComboBox Then
                                            ACHV = 2
                                        ElseIf AudioPPFrm.AviSynthChComboBox.Text = LangCls.AudioPPch51ComboBox Then
                                            ACHV = 6
                                        ElseIf AudioPPFrm.AviSynthChComboBox.Text = LangCls.AudioPPch20ComboBox Then
                                            ACHV = 2
                                        ElseIf AudioPPFrm.AviSynthChComboBox.Text = LangCls.AudioPPch10ComboBox Then
                                            ACHV = 1
                                        Else
                                            ExAudioB = True
                                        End If
                                    Else 'AviSynth 사용 안 함
                                        If EncSetFrm.FFmpegChComboBox.Text = LangCls.EncSetch51ComboBox Then
                                            ACHV = 6
                                        ElseIf EncSetFrm.FFmpegChComboBox.Text = LangCls.EncSetch20ComboBox Then
                                            ACHV = 2
                                        ElseIf EncSetFrm.FFmpegChComboBox.Text = LangCls.EncSetch10ComboBox Then
                                            ACHV = 1
                                        Else
                                            ExAudioB = True
                                        End If
                                    End If
                                    Dim SAMV As Integer = 0
                                    If EncSetFrm.SamplerateCheckBox.Checked = True Then '원본 샘플
                                        ExAudioB = True
                                    Else
                                        SAMV = EncSetFrm.SamplerateComboBox.Text
                                    End If
                                    AKByteV = ((16 * ACHV * SAMV) / 1000) / 8
                                ElseIf EncSetFrm.AudioCodecComboBox.Text = "[MP4] Nero AAC" OrElse EncSetFrm.AudioCodecComboBox.Text = "Nero AAC" Then 'NeroAAC
                                    If EncSetFrm.NeroAACVBRRadioButton.Checked = True Then
                                        ExAudioB = True
                                    Else
                                        AKByteV = Val(EncSetFrm.NeroAACBitrateNumericUpDown.Value) / 8
                                    End If
                                ElseIf EncSetFrm.AudioCodecComboBox.Text = "[AMR] AMR-NB(libopencore)" OrElse EncSetFrm.AudioCodecComboBox.Text = "AMR-NB(libopencore)" Then 'AMR
                                    AKByteV = Val(EncSetFrm.AMRBitrateComboBox.Text) / 8
                                ElseIf EncSetFrm.AudioCodecComboBox.Text = "[OGG] Vorbis" OrElse EncSetFrm.AudioCodecComboBox.Text = "Vorbis" Then 'Vorbis
                                    ExAudioB = True
                                ElseIf EncSetFrm.AudioCodecComboBox.Text = "[FLAC] Free Lossless Audio Codec(FLAC)" OrElse EncSetFrm.AudioCodecComboBox.Text = "Free Lossless Audio Codec(FLAC)" Then 'FLAC
                                    ExAudioB = True
                                End If
                            End If
                            '///
                            '여기까지
                            '//////////////////////////////

                            Dim ThrowCalcVB_ERR_B As Boolean = False

                            If ExAudioB = True Then
                                ThrowCalcVB_ERR_B = True
                            Else
                                Try
                                    CalcVideoBitrateStr = ((Val(EncSetFrm.SizeEncTextBox.Text) * (1024 ^ 2)) / _TimeV) - (AKByteV * 1000)
                                    CalcVideoBitrateStr = Val(CalcVideoBitrateStr) * 8 / 1000 'Kbit/s 단위로..

                                    If IsNumeric(CalcVideoBitrateStr) = False Then
                                        ThrowCalcVB_ERR_B = True
                                    Else
                                        If Val(CalcVideoBitrateStr) < 1 Then
                                            ThrowCalcVB_ERR_B = True
                                        Else
                                            ThrowCalcVB_ERR_B = False
                                        End If
                                    End If
                                Catch ex As Exception
                                    ThrowCalcVB_ERR_B = True
                                End Try
                            End If

                            If ThrowCalcVB_ERR_B = True Then
                                CalcVideoBitrateStr = " -b " & EncSetFrm.BitrateComboBox.Text & "k"
                            Else
                                CalcVideoBitrateStr = " -b " & Int(CalcVideoBitrateStr) & "k"
                            End If

                        End If

                    End If
                End If

                '---------------------------------
                ' 비율
                '=================================
                Dim VF_AspectV As String = ""
                Dim AspectV As String = ""
                If InStr(EncSetFrm.OutFComboBox.SelectedItem, "[AUDIO]", CompareMethod.Text) = 0 Then '오디오만 인코딩 아님//
                    Dim OriginW = 0
                    Dim OriginH = 0
                    Try
                        OriginW = Val(Split(Split(MainFrm.EncListListView.Items(EncindexI).SubItems(12).Text, ",")(0), "x")(0))
                        OriginH = Val(Split(Split(MainFrm.EncListListView.Items(EncindexI).SubItems(12).Text, ",")(0), "x")(1))
                    Catch ex As Exception
                    End Try
                    Dim _LeftCV As Integer = 0
                    Dim _TopCV As Integer = 0
                    Dim _RightCV As Integer = 0
                    Dim _BottomCV As Integer = 0
                    Try
                        _LeftCV = Split(MainFrm.EncListListView.Items(EncindexI).SubItems(15).Text, ",")(0)
                        _TopCV = Split(MainFrm.EncListListView.Items(EncindexI).SubItems(15).Text, ",")(1)
                        _RightCV = Split(MainFrm.EncListListView.Items(EncindexI).SubItems(15).Text, ",")(2)
                        _BottomCV = Split(MainFrm.EncListListView.Items(EncindexI).SubItems(15).Text, ",")(3)
                    Catch ex As Exception
                    End Try

                    '비율공통 설정
                    VF_AspectV = ", setsar=1:1"

                    If MainFrm.AVSCheckBox.Checked = False Then 'AviSynth 사용 안함

                        '======================================================
                        'PAR 1:1 아닌경우 원본사이즈 비율적용//
                        Dim PAR0 As Integer = 1, PAR00 As Integer = 0
                        Dim PARtes As String = ""
                        If InStr(PAR0, MainFrm.EncListListView.Items(EncindexI).SubItems(8).Text, "PAR ", CompareMethod.Text) Then
                            PAR00 = InStr(PAR0, MainFrm.EncListListView.Items(EncindexI).SubItems(8).Text, "PAR ", CompareMethod.Text) + 4
                            If InStr(PAR00, MainFrm.EncListListView.Items(EncindexI).SubItems(8).Text, " ", CompareMethod.Text) Then
                                PAR0 = InStr(PAR00, MainFrm.EncListListView.Items(EncindexI).SubItems(8).Text, " ", CompareMethod.Text) + 1
                                PARtes = Mid(MainFrm.EncListListView.Items(EncindexI).SubItems(8).Text, PAR00, PAR0 - PAR00 - 1)
                                PARtes = Replace(Replace(PARtes, ",", ""), "]", "")
                            End If
                        Else
                            PAR0 = PAR0 + 1
                        End If
                        If PARtes <> "" Then
                            Dim LP, RP As String
                            If InStr(PARtes, ":", CompareMethod.Text) <> 0 Then
                                Try
                                    PARtes = Split(PARtes, " ")(0)
                                    LP = Split(PARtes, ":")(0)
                                    RP = Split(PARtes, ":")(1)
                                Catch ex As Exception
                                    PARtes = "1:1"
                                    LP = 1
                                    RP = 1
                                End Try
                                If LP = "1" AndAlso RP = "1" Then
                                Else
                                    AspectV = " -aspect " & Val(OriginW) & ":" & Val(OriginH)
                                End If
                            End If
                        End If
                        '======================================================

                    End If

                End If

                '---------------------------------
                ' 비디오필터 vf!
                '=================================
                Dim VideoFilterV As String = ""
                If InStr(EncSetFrm.OutFComboBox.SelectedItem, "[AUDIO]", CompareMethod.Text) = 0 Then '오디오만 인코딩 아님//
                    If MainFrm.AVSCheckBox.Checked = True Then 'AviSynth 사용

                        If MainFrm.VF_TextBox = "" AndAlso VF_AspectV = "" Then
                            VideoFilterV = ""
                        Else
                            VideoFilterV = Chr(34) & MainFrm.VF_TextBox & VF_AspectV & Chr(34)
                            VideoFilterV = " -vf " & Replace(VideoFilterV, ", ", "", 1, 1)
                        End If

                    Else 'AviSynth 사용 안 함

                        If VF_CropV = "" AndAlso VF_imageVTextBox = "" AndAlso MainFrm.VF_TextBox = "" AndAlso VF_AspectV = "" Then
                            VideoFilterV = ""
                        Else
                            VideoFilterV = Chr(34) & VF_CropV & VF_imageVTextBox & MainFrm.VF_TextBox & VF_AspectV & Chr(34)
                            VideoFilterV = " -vf " & Replace(VideoFilterV, ", ", "", 1, 1)
                        End If

                    End If
                End If

                '***************************************************

                '---------------------------------
                ' 입력파일
                '=================================
                Dim InputFilePath As String = ""
                Dim InputFilePathN As String = ""
                If MainFrm.AVSCheckBox.Checked = True Then 'AviSynth 사용

                    '초기화//
                    AviSynthPP.INDEX_PStr = ""
                    AviSynthPP.INDEX_PVStr = ""

                    ProgressBar.Maximum = 100

                    IndexTimer.Enabled = True
                    IndexProc = True

                    '우선순위//
                    Dim PriorityV As Integer
                    If PriorityComboBox.SelectedIndex = 0 Then
                        PriorityV = PriorityClass.IDLE_PRIORITY_CLASS
                    ElseIf PriorityComboBox.SelectedIndex = 1 Then
                        PriorityV = PriorityClass.BELOW_NORMAL_PRIORITY_CLASS
                    ElseIf PriorityComboBox.SelectedIndex = 2 Then
                        PriorityV = PriorityClass.NORMAL_PRIORITY_CLASS
                    ElseIf PriorityComboBox.SelectedIndex = 3 Then
                        PriorityV = PriorityClass.ABOVE_NORMAL_PRIORITY_CLASS
                    ElseIf PriorityComboBox.SelectedIndex = 4 Then
                        PriorityV = PriorityClass.HIGH_PRIORITY_CLASS
                    ElseIf PriorityComboBox.SelectedIndex = 5 Then
                        PriorityV = PriorityClass.REALTIME_PRIORITY_CLASS
                    Else
                        PriorityV = PriorityClass.NORMAL_PRIORITY_CLASS
                    End If
                    'EncToolStripStatusLabel.Text = LangCls.EncodingCreatingD2V or EncodingCreatingFFINDEX // 아래에서
                    Try
                        AviSynthPP.AviSynthPreprocess(EncindexI, False, PriorityV, True, False)
                    Catch ex As Exception
                        MainFrm.EncListListView.Items(EncindexI).SubItems(6).Text = LangCls.MainErrorStr
                        MainFrm.EncListListView.Items(EncindexI).SubItems(7).Text = ex.Message
                        GoTo SKIP
                    End Try
                    EncToolStripStatusLabel.Text = ""
                    IndexProc = False
                    IndexTimer.Enabled = False

                    If AviSynthPP.INDEX_ProcessStopChk = True Then
                        AviSynthPP.INDEX_ProcessStopChk = False
                        GoTo ENC_STOP
                    Else
                        InputFilePath = My.Application.Info.DirectoryPath & "\temp\AviSynthScript(" & MainFrm.EncListListView.Items(EncindexI).SubItems(13).Text & ").avs"
                        InputFilePathN = My.Application.Info.DirectoryPath & "\temp\AviSynthScriptN(" & MainFrm.EncListListView.Items(EncindexI).SubItems(13).Text & ").avs"
                    End If

                Else
                    InputFilePath = MainFrm.EncListListView.Items(EncindexI).SubItems(10).Text
                    InputFilePathN = MainFrm.EncListListView.Items(EncindexI).SubItems(10).Text
                End If

                '***************************************************

                '---------------------------------
                ' 저장경로 유니코드처리
                '=================================
                Dim UnicodeMPATHV As String = ""
                Dim FNGBytes() As Byte = System.Text.Encoding.Default.GetBytes(SavePathStr)
                If InStr(System.Text.Encoding.Default.GetString(FNGBytes), "?") <> 0 Then
                    'NULL파일 생성(유니코드처리용)
                    Try
                        Dim _StreamWriter As New StreamWriter(SavePathStr, False, System.Text.Encoding.Default)
                        _StreamWriter.Write("")
                        _StreamWriter.Close()
                    Catch ex As Exception
                        MainFrm.EncListListView.Items(EncindexI).SubItems(6).Text = LangCls.MainErrorStr
                        MainFrm.EncListListView.Items(EncindexI).SubItems(7).Text = ex.Message
                        GoTo SKIP
                    End Try
                    '경로백업
                    UnicodeMPATHV = SavePathStr
                    '저장경로지정
                    SavePathStr = WinAPI.GetShortPathName(SavePathStr)
                End If

                '---------------------------------
                ' 타임스탬프
                '=================================
                Dim timestampV As String = ""
                If InStr(EncSetFrm.OutFComboBox.SelectedItem, "[3GP]", CompareMethod.Text) <> 0 OrElse _
                 InStr(EncSetFrm.OutFComboBox.SelectedItem, "[3G2]", CompareMethod.Text) <> 0 OrElse _
                 InStr(EncSetFrm.OutFComboBox.SelectedItem, "[MP4]", CompareMethod.Text) <> 0 OrElse _
                 InStr(EncSetFrm.OutFComboBox.SelectedItem, "[MOV]", CompareMethod.Text) <> 0 Then
                    timestampV = " -timestamp now" ' & Chr(34) & Format(Now, "yyyy-MM-dd HH:mm:ss") & Chr(34)
                End If

                '---------------------------------
                ' FFmpeg 프레임 레이트 지정(VBR전용)
                '=================================
                Dim FramerateStr As String = ""
                If MainFrm.AVSCheckBox.Checked = False Then 'AviSynth 사용 안함
                    If EncSetFrm.FramerateCheckBox.Checked = True Then
                        Try
                            If Val(Split(MainFrm.EncListListView.Items(EncindexI).SubItems(12).Text, ",")(1)) >= 119 Then
                                FramerateStr = " -r " & Split(MainFrm.EncListListView.Items(EncindexI).SubItems(12).Text, ",")(1)
                            End If
                        Catch ex As Exception
                        End Try
                    End If
                End If

                '---------------------------------
                ' FLV 원본 샘플링 가변적//
                '=================================
                Dim AudioListV As String = MainFrm.EncListListView.Items(EncindexI).SubItems(9).Text
                Dim FLVSamplerateV As String = ""
                Dim _i As Long = 1
                Dim _ii As Long = 0
                Dim _t As String = ""
                'FLV 일경우 [libmp3lame @ 0x170a530] flv does not support that sample rate, choose from (44100, 22050, 11025).
                If InStr(EncSetFrm.OutFComboBox.SelectedItem, "[FLV]", CompareMethod.Text) <> 0 AndAlso EncSetFrm.AudioCodecComboBox.Text = "MPEG-1 Audio layer 3(MP3) Lame" Then
                    If EncSetFrm.SamplerateCheckBox.Checked = True Then '원본 샘플레이트 체크
                        _i = 1
                        _ii = 0
                        _t = ""
                        If InStr(_i, AudioListV, MainFrm.EncListListView.Items(EncindexI).SubItems(4).Text, CompareMethod.Text) Then
                            _ii = InStr(_i, AudioListV, MainFrm.EncListListView.Items(EncindexI).SubItems(4).Text, CompareMethod.Text)
                            If InStr(_ii, AudioListV, "Hz", CompareMethod.Text) Then
                                _i = InStr(_ii, AudioListV, "Hz", CompareMethod.Text) + 1
                                _t = Mid(AudioListV, _ii, _i - _ii - 1)
                            End If
                        Else
                            _i = _i + 1
                        End If
                        If _t <> "" Then
                            _t = Strings.Mid(RTrim(_t), InStrRev(RTrim(_t), " ") + 1)
                            If Val(_t) >= 44100 Then
                                FLVSamplerateV = " -ar 44100"
                            ElseIf Val(_t) >= 22050 Then
                                FLVSamplerateV = " -ar 22050"
                            Else
                                FLVSamplerateV = " -ar 11025"
                            End If
                        End If
                    End If
                End If




                '---------------------------------------------------------------------------------------------------------------------------------------------






                '-------------------------------------
                '-------------------------------------
                '
                '           인코딩 시작
                '
                '=====================================
                '=====================================









                '네로 AAC 인코딩 부분//
                If EncSetFrm.AudioCodecComboBox.Text = "Nero AAC" OrElse EncSetFrm.AudioCodecComboBox.Text = "[MP4] Nero AAC" Then

                    Dim NeroAACPath As String = Chr(34) & My.Application.Info.DirectoryPath & "\tools\neroaac\neroAacEnc.exe" & Chr(34)
                    Dim InPATHV As String = ""
                    Dim OutPATHV As String = ""
                    If EncSetFrm.AudioCodecComboBox.Text = "Nero AAC" Then '비디오 + 오디오
                        InPATHV = InputFilePathN
                        OutPATHV = SavePathStr & "A"
                    Else '오디오만
                        InPATHV = InputFilePath
                        OutPATHV = SavePathStr
                    End If

                    Dim CommandV As String = ""
                    If MainFrm.AVSCheckBox.Checked = True Then 'AviSynth 사용
                        CommandV = MainFrm.NeroAACSTRAviSynth & NeroAACPath & MainFrm.NeroAACSTRNEP
                    Else 'AviSynth 사용 안 함
                        CommandV = NeroAACAudioMapV & SSTV & MainFrm.NeroAACSTRFFmpeg & NeroAACPath & MainFrm.NeroAACSTRNEP
                    End If

                    Dim MSGB As String = Chr(34) & My.Application.Info.DirectoryPath & "\tools\ffmpeg\ffmpeg.exe" & Chr(34) & " -y -i " & Chr(34) & InPATHV & Chr(34) & CommandV & Chr(34) & OutPATHV & Chr(34)

                    '경로
                    Dim NeroBATCMDPathV As String = My.Application.Info.DirectoryPath & "\temp\CLIneroAacEnc.bat"

                    '저장
                    Try
                        Dim _StreamWriter As New StreamWriter(NeroBATCMDPathV, False, System.Text.Encoding.Default)
                        _StreamWriter.Write(MSGB)
                        _StreamWriter.Close()
                    Catch ex As Exception
                        MainFrm.EncListListView.Items(EncindexI).SubItems(6).Text = LangCls.MainErrorStr
                        MainFrm.EncListListView.Items(EncindexI).SubItems(7).Text = ex.Message
                        GoTo SKIP
                    End Try

                    '실행
                    EncToolStripStatusLabel.Text = LangCls.EncodingNeroAACEncoding
                    EncSub(NeroBATCMDPathV, Nothing, Nothing, False, False)
                    EncToolStripStatusLabel.Text = ""
                    If EncSTOPBool = True Then GoTo ENC_STOP
                    If EncERRBool(EncindexI) = True Then
                        MainFrm.EncListListView.Items(EncindexI).SubItems(6).Text = LangCls.MainErrorStr
                        GoTo SKIP
                    End If
                End If
                '네로 AAC 인코딩 부분//


                '***********************************
                ' 출력 형식 NeroAAC MUX용 -f 는 확장자 뒤에 붙은 V 와 A 를 합칠때 쓴다 mp4V + mp4A = 각 포맷으로 , 지정을 안 하면 오류발생../ 지우지 말것.
                '***********************************
                Dim OUTPUTFORMAT As String = ""
                Dim OUTPUTFORMAT2 As String = ""
                If EncSetFrm.AudioCodecComboBox.Text = "Nero AAC" Then
                    Try
                        OUTPUTFORMAT = LCase(Replace(Split(EncSetFrm.OutFComboBox.Text, "]")(0), "[", ""))
                        If OUTPUTFORMAT = "3gp" Then
                            OUTPUTFORMAT2 = " -f 3gp"
                        ElseIf OUTPUTFORMAT = "3g2" Then
                            OUTPUTFORMAT2 = " -f 3g2"
                        ElseIf OUTPUTFORMAT = "mp4" Then
                            OUTPUTFORMAT2 = " -f mp4"
                        ElseIf OUTPUTFORMAT = "mov" Then
                            OUTPUTFORMAT2 = " -f mov"
                        ElseIf OUTPUTFORMAT = "mkv" Then
                            OUTPUTFORMAT2 = " -f matroska"
                        ElseIf OUTPUTFORMAT = "flv" Then
                            OUTPUTFORMAT2 = " -f flv"
                        End If
                    Catch ex As Exception
                        OUTPUTFORMAT = ""
                        OUTPUTFORMAT2 = ""
                    End Try
                End If
                '***********************************
                ' 용량 제한 NeroAAC MUX용
                '***********************************
                Dim SizeLimitTextBoxV As String = ""
                If EncSetFrm.AudioCodecComboBox.Text = "Nero AAC" Then
                    If Val(EncSetFrm.SizeLimitTextBox.Text) <> 0 Then
                        SizeLimitTextBoxV = " -fs " & Val(EncSetFrm.SizeLimitTextBox.Text) * Val(1048576)
                    End If
                End If




                '===========================================





                '오디오 비디오 인코딩 // MP4 Nero AAC 예외를 준 이유는 위에서 이미 인코딩을 진행했기 때문./ 일반 Nero AAC 코덱은 아래와 같이 진행./ 비디오 인코딩 및 MUX 과정을 행함.
                If EncSetFrm.AudioCodecComboBox.Text <> "[MP4] Nero AAC" Then

                    Dim VextV As String = ""
                    Dim AnV As String = ""
                    If EncSetFrm.AudioCodecComboBox.Text = "Nero AAC" Then '네로 에에씨 인코딩이면, -an 과(2-1패스는 제외), 파일 확장자뒤에 V를 붙어줌.
                        VextV = "V"
                        AnV = " -an"
                        EncToolStripStatusLabel.Text = LangCls.EncodingVEncoding
                    Else
                        VextV = ""
                        AnV = ""
                        If InStr(EncSetFrm.OutFComboBox.SelectedItem, "[AUDIO]", CompareMethod.Text) = 0 Then '오디오만 인코딩 아님//
                            EncToolStripStatusLabel.Text = LangCls.EncodingAVEncoding
                        Else
                            EncToolStripStatusLabel.Text = LangCls.EncodingAEncoding
                        End If
                    End If

                    '---------------------------------------------------------
                    '=========================================================

                    If MainFrm.AVSCheckBox.Checked = True Then 'AviSynth 사용

                        If EncSetFrm.VideoModeComboBox.SelectedIndex = EncSetFrm.VideoModeComboBox.FindString("[2PASS-CBR]", -1) AndAlso MainFrm.EncListListView.Items(EncindexI).SubItems(8).Text <> "None" Then

                            EncPassStr = "[1/2Pass]"
                            EncSub(InputFilePath, VideoFilterV & timestampV & MainFrm.AviSynthCommand2PassStr & CalcVideoBitrateStr, SavePathStr & VextV, True, False)
                            If EncSTOPBool = True Then GoTo ENC_STOP
                            If EncERRBool(EncindexI) = True Then
                                MainFrm.EncListListView.Items(EncindexI).SubItems(6).Text = LangCls.MainErrorStr
                                GoTo SKIP
                            End If

                            EncPassStr = "[2/2Pass]"
                            EncSub(InputFilePath, VideoFilterV & FLVSamplerateV & timestampV & " -pass 2" & MainFrm.AviSynthCommandStr & CalcVideoBitrateStr & AnV, SavePathStr & VextV, True, False)
                            If EncSTOPBool = True Then GoTo ENC_STOP
                            If EncERRBool(EncindexI) = True Then
                                MainFrm.EncListListView.Items(EncindexI).SubItems(6).Text = LangCls.MainErrorStr
                                GoTo SKIP
                            End If

                            '패스표시 초기화
                            EncPassStr = ""

                        Else

                            EncSub(InputFilePath, VideoFilterV & FLVSamplerateV & timestampV & MainFrm.AviSynthCommandStr & CalcVideoBitrateStr & AnV, SavePathStr & VextV, True, False)
                            If EncSTOPBool = True Then GoTo ENC_STOP
                            If EncERRBool(EncindexI) = True Then
                                MainFrm.EncListListView.Items(EncindexI).SubItems(6).Text = LangCls.MainErrorStr
                                GoTo SKIP
                            End If

                        End If

                    Else 'AviSynth 사용 안 함

                        If EncSetFrm.VideoModeComboBox.SelectedIndex = EncSetFrm.VideoModeComboBox.FindString("[2PASS-CBR]", -1) AndAlso MainFrm.EncListListView.Items(EncindexI).SubItems(8).Text <> "None" Then

                            EncPassStr = "[1/2Pass]"
                            EncSub(InputFilePath, SSTV & VideoFilterV & AspectV & timestampV & MainFrm.FFmpegCommand2PassStr & CalcVideoBitrateStr & FramerateStr, SavePathStr & VextV, True, False)
                            If EncSTOPBool = True Then GoTo ENC_STOP
                            If EncERRBool(EncindexI) = True Then
                                MainFrm.EncListListView.Items(EncindexI).SubItems(6).Text = LangCls.MainErrorStr
                                GoTo SKIP
                            End If

                            EncPassStr = "[2/2Pass]"
                            EncSub(InputFilePath, AVMapV & SSTV & VideoFilterV & AspectV & FLVSamplerateV & timestampV & " -pass 2" & MainFrm.FFmpegCommandStr & CalcVideoBitrateStr & FramerateStr & AnV, SavePathStr & VextV, True, False)
                            If EncSTOPBool = True Then GoTo ENC_STOP
                            If EncERRBool(EncindexI) = True Then
                                MainFrm.EncListListView.Items(EncindexI).SubItems(6).Text = LangCls.MainErrorStr
                                GoTo SKIP
                            End If

                            '패스표시 초기화
                            EncPassStr = ""

                        Else

                            EncSub(InputFilePath, AVMapV & SSTV & VideoFilterV & AspectV & FLVSamplerateV & timestampV & MainFrm.FFmpegCommandStr & CalcVideoBitrateStr & FramerateStr & AnV, SavePathStr & VextV, True, False)
                            If EncSTOPBool = True Then GoTo ENC_STOP
                            If EncERRBool(EncindexI) = True Then
                                MainFrm.EncListListView.Items(EncindexI).SubItems(6).Text = LangCls.MainErrorStr
                                GoTo SKIP
                            End If

                        End If

                    End If

                    '---------------------------------------------------------
                    '=========================================================

                    EncToolStripStatusLabel.Text = ""

                    '---------------------------------------------------------
                    '=========================================================

                    If EncSetFrm.AudioCodecComboBox.Text = "Nero AAC" Then 'Nero AAC 비디오 인코딩 MUX

                        '유니코드처리용//
                        If UnicodeMPATHV <> "" Then
                            If My.Computer.FileSystem.FileExists(SavePathStr) = False Then
                                'NULL파일 생성(유니코드처리용)
                                Try
                                    Dim _StreamWriter As New StreamWriter(UnicodeMPATHV, False, System.Text.Encoding.Default)
                                    _StreamWriter.Write("")
                                    _StreamWriter.Close()
                                Catch ex As Exception
                                    MainFrm.EncListListView.Items(EncindexI).SubItems(6).Text = LangCls.MainErrorStr
                                    MainFrm.EncListListView.Items(EncindexI).SubItems(7).Text = ex.Message
                                    GoTo SKIP
                                End Try
                                '저장경로지정
                                SavePathStr = WinAPI.GetShortPathName(UnicodeMPATHV)
                            End If
                        End If

                        EncToolStripStatusLabel.Text = LangCls.EncodingAVMux
                        EncSub(SavePathStr & "V|" & SavePathStr & "A", _
                               OUTPUTFORMAT2 & timestampV & SizeLimitTextBoxV, _
                               SavePathStr, False, True)
                        EncToolStripStatusLabel.Text = ""
                        If EncSTOPBool = True Then GoTo ENC_STOP
                        If EncERRBool(EncindexI) = True Then
                            MainFrm.EncListListView.Items(EncindexI).SubItems(6).Text = LangCls.MainErrorStr
                            GoTo SKIP
                        End If

                    End If

                    '클린업//
                    Try
                        If My.Computer.FileSystem.FileExists(SavePathStr & "A") = True Then _
                           My.Computer.FileSystem.DeleteFile(SavePathStr & "A")
                    Catch ex As Exception
                    End Try
                    Try
                        If My.Computer.FileSystem.FileExists(SavePathStr & "V") = True Then _
                           My.Computer.FileSystem.DeleteFile(SavePathStr & "V")
                    Catch ex As Exception
                    End Try

                    '---------------------------------------------------------
                    '=========================================================

                End If
                '오디오 비디오 인코딩 //

                '완료//
                MainFrm.EncListListView.Items(EncindexI).SubItems(6).Text = LangCls.MainDoneStr

            Catch ex As Exception
                Try
                    MainFrm.EncListListView.Items(EncindexI).SubItems(6).Text = LangCls.MainErrorStr
                    MainFrm.EncListListView.Items(EncindexI).SubItems(7).Text = ex.Message
                Catch ex2 As Exception
                End Try
            End Try

SKIP:
            '갱신
            EncI = MainFrm.EncListListView.Items.Count
            Me.EncindexI += 1
        Loop

        '-------------------------------------------------------------------------------------
        ' 작업종료
        '-------------------------------------------------------------------------------------
        EncExitSub()


        Exit Sub
        '-------------------------------------------------------------------------------------
        ' 중지
        '-------------------------------------------------------------------------------------
ENC_STOP:
        EncSTOPBool = False
        MainFrm.EncListListView.Items(EncindexI).SubItems(6).Text = LangCls.MainStopStr
        EncExitSub()
    End Sub

    Private Sub EncExitSub()

        '캡션타이머오프
        CapTimer.Enabled = False
        '메인폼타이틀
        MainFrm.Text = MainFrmTitleBack
        '인코딩오프
        EncProcBool = False
        '닫기
        Close()

    End Sub


    Private Function EncERRBool(ByVal index As Integer) As Boolean

        If InStr(InfoTextBox.Text, "Stream #0.0: Video: rawvideo, bgra", CompareMethod.Text) <> 0 AndAlso _
        MainFrm.AVSCheckBox.Checked = True Then 'AviSynth 사용하면서 rawvideo 에 bgra

            '스크립트검사
            Try
                Dim _AviSynthScriptEnvironment As New AvisynthWrapper.AviSynthScriptEnvironment()
                Dim _AviSynthClip As AvisynthWrapper.AviSynthClip
                _AviSynthClip = _AviSynthScriptEnvironment.OpenScriptFile(My.Application.Info.DirectoryPath & "\temp\AviSynthScript(" & MainFrm.EncListListView.Items(EncindexI).SubItems(13).Text & ").avs")
                _AviSynthClip.IDisposable_Dispose()

                If InStr(InfoTextBox.Text, "Duration: 00:00:10.00", CompareMethod.Text) <> 0 Then '오류를 못 찾았지만 10초일경우 오류로 처리// (YV12에러는 못 찾음.)
                    MainFrm.EncListListView.Items(EncindexI).SubItems(7).Text = InfoTextBox.Text
                    Return True
                Else
                    Return False
                End If

            Catch ex As Exception
                MainFrm.EncListListView.Items(EncindexI).SubItems(7).Text = ex.Message
                Return True
            End Try

        ElseIf InStr(InfoTextBox.Text, "global headers", CompareMethod.Text) <> 0 AndAlso InStr(InfoTextBox.Text, "muxing overhead", CompareMethod.Text) <> 0 Then '일반적인 경우 오류 아님
            Return False

        Else '그 외에는 모두 오류...
            MainFrm.EncListListView.Items(EncindexI).SubItems(7).Text = InfoTextBox.Text
            Return True

        End If

    End Function

    Private Sub IndexTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IndexTimer.Tick

        '퍼센트
        Try
            If AviSynthPP.INDEX_PStr <> "" AndAlso IsNumeric(AviSynthPP.INDEX_PStr) = True Then
                If AviSynthPP.INDEX_PStr <= ProgressBar.Maximum Then
                    ProgressBar.Value = AviSynthPP.INDEX_PStr
                Else
                    ProgressBar.Value = ProgressBar.Maximum
                End If
            End If
        Catch ex As Exception
        End Try

        '남은시간
        If AviSynthPP.INDEX_PVStr <> "" Then
            TimeRemainingLabel.Text = AviSynthPP.INDEX_PVStr
        End If

    End Sub

    Private Sub EncodingFrm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        '인코딩중이면 강제종료 버튼 클릭
        If EncProcBool = True Then
            e.Cancel = True
            ForceStopButton_Click(Nothing, Nothing)
            Exit Sub
        Else
            e.Cancel = False
        End If

        '--------------------

        MainFrm.PriorityComboBoxEncodingFrmV = PriorityComboBox.SelectedIndex

        '---------------------

        'Win7진행바
        Try
            If (Environment.OSVersion.Version.Major = 6 AndAlso Environment.OSVersion.Version.Minor >= 1) OrElse Environment.OSVersion.Version.Major > 6 Then
                _ITaskbarList3.SetProgressState(MainFrm.Handle, WinAPI.TBPFLAG.NoProgress)
                Marshal.ReleaseComObject(_ITaskbarList3)
            End If
        Catch ex As Exception
        End Try

        '활성화
        MainFrm.AVSGroupBox.Enabled = True
        MainFrm.EncSetGroupBox.Enabled = True
        MainFrm.EncSButton.Enabled = True
        MainFrm.StreamSelPanel.Enabled = True
        MainFrm.LangToolStripMenuItem.Enabled = True
        MainFrm.SavePathTextBox.Enabled = True
        MainFrm.SetFolderButton.Enabled = True
        MainFrm.AboutToolStripMenuItem.Enabled = True
        MainFrm.DecSToolStripMenuItem.Enabled = True
        MainFrm.AviSynthToolStripMenuItem.Enabled = True

        '********************************

        '보이기
        If Me.Visible = False AndAlso MainFrm.Visible = False Then
            MainFrm.NotifyIcon_Click(Nothing, Nothing)
        End If

        '시스템종료관련
        If ShutdownCheckBox.Checked = True Then ShutdownFrm.Show(MainFrm)

    End Sub

    Private Sub EncodingFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '=========================================
        'Rev 1.1
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
                    EncPanel.Font = New Font(FNXP, FS)
                    EncToolStripStatusLabel.Font = New Font(FNXP, FS)
                Else
                    EncPanel.Font = New Font(FN, FS)
                    EncToolStripStatusLabel.Font = New Font(FN, FS)
                End If

                If XTR.Name = "EncodingFrmV" Then LangCls.EncodingFrmV = XTR.ReadString
                If XTR.Name = "EncodingFrmFrame" Then FrameTXTLabel.Text = XTR.ReadString
                If XTR.Name = "EncodingFrmQ" Then QTXTLabel.Text = XTR.ReadString
                If XTR.Name = "EncodingFrmBitrate" Then BitrateTXTLabel.Text = XTR.ReadString
                If XTR.Name = "EncodingFrmPositionDuration" Then PositionDurationTXTLabel.Text = XTR.ReadString
                If XTR.Name = "EncodingFrmTimeElapsed" Then TimeElapsedTXTLabel.Text = XTR.ReadString
                If XTR.Name = "EncodingFrmTimeRemaining" Then TimeRemainingTXTLabel.Text = XTR.ReadString
                If XTR.Name = "EncodingFrmProcessingRate" Then ProcessingRateTXTLabel.Text = XTR.ReadString
                If XTR.Name = "EncodingFrmFilesize" Then FilesizeTXTLabel.Text = XTR.ReadString
                If XTR.Name = "EncodingFrmProgress" Then ProgressLabel.Text = XTR.ReadString
                If XTR.Name = "EncodingFrmPriority" Then PriorityLabel.Text = XTR.ReadString
                If XTR.Name = "EncodingPriorityLow" Then LangCls.EncodingPriorityLow = XTR.ReadString
                If XTR.Name = "EncodingPriorityBelowNormal" Then LangCls.EncodingPriorityBelowNormal = XTR.ReadString
                If XTR.Name = "EncodingPriorityNormal" Then LangCls.EncodingPriorityNormal = XTR.ReadString
                If XTR.Name = "EncodingPriorityAboveNormal" Then LangCls.EncodingPriorityAboveNormal = XTR.ReadString
                If XTR.Name = "EncodingPriorityHigh" Then LangCls.EncodingPriorityHigh = XTR.ReadString
                If XTR.Name = "EncodingPriorityRealtime" Then LangCls.EncodingPriorityRealtime = XTR.ReadString
                If XTR.Name = "EncodingSuspend" Then LangCls.EncodingSuspend = XTR.ReadString
                If XTR.Name = "EncodingResume" Then LangCls.EncodingResume = XTR.ReadString
                If XTR.Name = "EncodingCreatingD2V" Then LangCls.EncodingCreatingD2V = XTR.ReadString
                If XTR.Name = "EncodingCreatingFFINDEX" Then LangCls.EncodingCreatingFFINDEX = XTR.ReadString
                If XTR.Name = "EncodingAVEncoding" Then LangCls.EncodingAVEncoding = XTR.ReadString
                If XTR.Name = "EncodingAEncoding" Then LangCls.EncodingAEncoding = XTR.ReadString
                If XTR.Name = "EncodingVEncoding" Then LangCls.EncodingVEncoding = XTR.ReadString
                If XTR.Name = "EncodingNeroAACEncoding" Then LangCls.EncodingNeroAACEncoding = XTR.ReadString
                If XTR.Name = "EncodingAVMux" Then LangCls.EncodingAVMux = XTR.ReadString
                If XTR.Name = "EncodingStopButtonQ" Then LangCls.EncodingStopButtonQ = XTR.ReadString
                If XTR.Name = "EncodingForceStopButtonQ" Then LangCls.EncodingForceStopButtonQ = XTR.ReadString
                If XTR.Name = "EncodingFrmForceStopButton" Then ForceStopButton.Text = XTR.ReadString
                If XTR.Name = "EncodingFrmStopButton" Then StopButton.Text = XTR.ReadString
                If XTR.Name = "EncodingFrmShutdownCheckBox" Then ShutdownCheckBox.Text = XTR.ReadString

            Loop
        Catch ex As Exception
            MsgBox("LANG_LOAD_ERROR :" & ex.Message)
        Finally
            XTR.Close()
        End Try
LANG_SKIP:
        '=========================================

        'Win7진행바
        Try
            If (Environment.OSVersion.Version.Major = 6 AndAlso Environment.OSVersion.Version.Minor >= 1) OrElse Environment.OSVersion.Version.Major > 6 Then
                _ITaskbarList3 = DirectCast(New WinAPI.TaskbarList(), WinAPI.ITaskbarList3)
                _ITaskbarList3.SetProgressState(MainFrm.Handle, WinAPI.TBPFLAG.Normal)
            End If
        Catch ex As Exception
        End Try

        '우선순위 초기화
        PriorityComboBox.Items.Clear()
        PriorityComboBox.Items.Add(LangCls.EncodingPriorityLow)
        PriorityComboBox.Items.Add(LangCls.EncodingPriorityBelowNormal)
        PriorityComboBox.Items.Add(LangCls.EncodingPriorityNormal)
        PriorityComboBox.Items.Add(LangCls.EncodingPriorityAboveNormal)
        PriorityComboBox.Items.Add(LangCls.EncodingPriorityHigh)
        PriorityComboBox.Items.Add(LangCls.EncodingPriorityRealtime)

        '설정 불러옴
        PriorityComboBox.SelectedIndex = MainFrm.PriorityComboBoxEncodingFrmV

        '초기화
        LoadInitialization()

        '명령어 초기화
        MainFrm.AviSynthCommandStr = ""
        MainFrm.AviSynthCommand2PassStr = ""
        MainFrm.FFmpegCommandStr = ""
        MainFrm.FFmpegCommand2PassStr = ""
        MainFrm.VF_TextBox = ""
        MainFrm.NeroAACSTRFFmpeg = ""
        MainFrm.NeroAACSTRAviSynth = ""
        MainFrm.NeroAACSTRNEP = ""

        '명령어 받기
        EncSetFrm.GETFFCMD()

    End Sub

    Private Sub EncodingFrm_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            MainFrm.WindowState = FormWindowState.Minimized
        End If
    End Sub

    Private Sub EncodingFrm_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        '인코딩 시작
        ENCSTRSUB()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub TimeElapsedTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeElapsedTimer.Tick

        '속도체크
        If EncPositionD <> TimeS AndAlso EncPositionD > TimeS Then
            ProcessingRateLabel.Text = Format(EncPositionD - TimeS, "0.00") & "x"
            SpeedV = Format(EncPositionD - TimeS, "0.00")
        End If

        TimeS = EncPositionD
        TimeElapsed += 1

        Dim Minute As Single
        Dim Hour As Single
        Dim hmsValue As String = ""
        Dim NowTimeSec = TimeElapsed

        If NowTimeSec < 0 Then Exit Sub

        If NowTimeSec < 60 Then
            If NowTimeSec < 0 Then
                hmsValue = "00:" & "00:" & "00.00"
            ElseIf Format(NowTimeSec, "0.00") < 10 Then
                hmsValue = "00:" & "00:" & "0" & Format(NowTimeSec, "0.00")
            Else
                hmsValue = "00:" & "00:" & Format(NowTimeSec, "0.00")
            End If
        End If

        If NowTimeSec > 59 Then
            Minute = NowTimeSec / 60
            If Int(NowTimeSec - "60" * Split(Minute, ".")(0)) < 10 Then
                If Split(Minute, ".")(0) < 10 Then
                    hmsValue = "00:" & "0" & Split(Minute, ".")(0) & ":" & "0" & Format(NowTimeSec - "60" * Split(Minute, ".")(0), "0.00")
                Else
                    hmsValue = "00:" & Split(Minute, ".")(0) & ":" & "0" & Format(NowTimeSec - "60" * Split(Minute, ".")(0), "0.00")
                End If
            Else
                If Split(Minute, ".")(0) < 10 Then
                    hmsValue = "00:" & "0" & Split(Minute, ".")(0) & ":" & Format(NowTimeSec - "60" * Split(Minute, ".")(0), "0.00")
                Else
                    hmsValue = "00:" & Split(Minute, ".")(0) & ":" & Format(NowTimeSec - "60" * Split(Minute, ".")(0), "0.00")
                End If
            End If
        End If

        If Split(Minute, ".")(0) > 59 Then
            Hour = Split(Minute, ".")(0) / 60
            If Split(Hour, ".")(0) < 10 Then
                If Int(Minute - "60" * Split(Hour, ".")(0)) < 10 Then
                    If Int(NowTimeSec - "60" * Split(Minute, ".")(0)) < 10 Then
                        hmsValue = "0" & Split(Hour, ".")(0) & ":" & "0" & Int(Minute - "60" * Split(Hour, ".")(0)) & ":" & "0" & Format(NowTimeSec - "60" * Split(Minute, ".")(0), "0.00")
                    Else
                        hmsValue = "0" & Split(Hour, ".")(0) & ":" & "0" & Int(Minute - "60" * Split(Hour, ".")(0)) & ":" & Format(NowTimeSec - "60" * Split(Minute, ".")(0), "0.00")
                    End If
                Else
                    If Int(NowTimeSec - "60" * Split(Minute, ".")(0)) < 10 Then
                        hmsValue = "0" & Split(Hour, ".")(0) & ":" & Int(Minute - "60" * Split(Hour, ".")(0)) & ":" & "0" & Format(NowTimeSec - "60" * Split(Minute, ".")(0), "0.00")
                    Else
                        hmsValue = "0" & Split(Hour, ".")(0) & ":" & Int(Minute - "60" * Split(Hour, ".")(0)) & ":" & Format(NowTimeSec - "60" * Split(Minute, ".")(0), "0.00")
                    End If
                End If

            Else

                If Int(Minute - "60" * Split(Hour, ".")(0)) < 10 Then
                    If Int(NowTimeSec - "60" * Split(Minute, ".")(0)) < 10 Then
                        hmsValue = Split(Hour, ".")(0) & ":" & "0" & Int(Minute - "60" * Split(Hour, ".")(0)) & ":" & "0" & Format(NowTimeSec - "60" * Split(Minute, ".")(0), "0.00")
                    Else
                        hmsValue = Split(Hour, ".")(0) & ":" & "0" & Int(Minute - "60" * Split(Hour, ".")(0)) & ":" & Format(NowTimeSec - "60" * Split(Minute, ".")(0), "0.00")
                    End If
                Else
                    If Int(NowTimeSec - "60" * Split(Minute, ".")(0)) < 10 Then
                        hmsValue = Split(Hour, ".")(0) & ":" & Int(Minute - "60" * Split(Hour, ".")(0)) & ":" & "0" & Format(NowTimeSec - "60" * Split(Minute, ".")(0), "0.00")
                    Else
                        hmsValue = Split(Hour, ".")(0) & ":" & Int(Minute - "60" * Split(Hour, ".")(0)) & ":" & Format(NowTimeSec - "60" * Split(Minute, ".")(0), "0.00")
                    End If
                End If

            End If

        End If

        hmsValue = Split(hmsValue, ".")(0)
        TimeElapsedLabel.Text = hmsValue

    End Sub

    Private Sub PriorityComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PriorityComboBox.SelectedIndexChanged
        Dim PHandle As IntPtr
        If IndexProc = True Then
            PHandle = AviSynthPP.INDEX_ProcessHandle_ID
        Else
            PHandle = ProcessHandle_EI
        End If
        If PriorityComboBox.SelectedIndex = 0 Then
            SetPriorityClass(PHandle, PriorityClass.IDLE_PRIORITY_CLASS)
        ElseIf PriorityComboBox.SelectedIndex = 1 Then
            SetPriorityClass(PHandle, PriorityClass.BELOW_NORMAL_PRIORITY_CLASS)
        ElseIf PriorityComboBox.SelectedIndex = 2 Then
            SetPriorityClass(PHandle, PriorityClass.NORMAL_PRIORITY_CLASS)
        ElseIf PriorityComboBox.SelectedIndex = 3 Then
            SetPriorityClass(PHandle, PriorityClass.ABOVE_NORMAL_PRIORITY_CLASS)
        ElseIf PriorityComboBox.SelectedIndex = 4 Then
            SetPriorityClass(PHandle, PriorityClass.HIGH_PRIORITY_CLASS)
        ElseIf PriorityComboBox.SelectedIndex = 5 Then
            SetPriorityClass(PHandle, PriorityClass.REALTIME_PRIORITY_CLASS)
        Else
            SetPriorityClass(PHandle, PriorityClass.NORMAL_PRIORITY_CLASS)
        End If
    End Sub

    Private Sub SuspendResumeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuspendResumeButton.Click
        If SuspendB = False Then
            SuspendB = True
            SuspendResumeButton.Text = LangCls.EncodingResume
            TimeElapsedTimer.Enabled = False
            SuspendThread(ThreadHandle_EI)

            'Win7진행바
            Try
                If (Environment.OSVersion.Version.Major = 6 AndAlso Environment.OSVersion.Version.Minor >= 1) OrElse Environment.OSVersion.Version.Major > 6 Then
                    _ITaskbarList3.SetProgressState(MainFrm.Handle, WinAPI.TBPFLAG.Paused)
                End If
            Catch ex As Exception
            End Try
        Else
            ResumeThread(ThreadHandle_EI)
            TimeElapsedTimer.Enabled = True
            SuspendResumeButton.Text = LangCls.EncodingSuspend
            SuspendB = False

            'Win7진행바
            Try
                If (Environment.OSVersion.Version.Major = 6 AndAlso Environment.OSVersion.Version.Minor >= 1) OrElse Environment.OSVersion.Version.Major > 6 Then
                    _ITaskbarList3.SetProgressState(MainFrm.Handle, WinAPI.TBPFLAG.Normal)
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub ForceStopButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForceStopButton.Click
        Dim MSG = MessageBox.Show(LangCls.EncodingForceStopButtonQ, ForceStopButton.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If MSG = Windows.Forms.DialogResult.Yes Then
        Else
            Exit Sub
        End If
        '------------------
        If SuspendB = True Then
            SuspendResumeButton_Click(Nothing, Nothing)
        End If
        '------------------ 상단코드일시정지처리 
        Try
            EncSTOPBool = True
            If IndexProc = True Then
                AviSynthPP.INDEX_ProcessStopChk = True
                WinAPI.TerminateProcess(AviSynthPP.INDEX_ProcessHandle_ID, 0&)
            Else
                If PipeMode = True Then
                    WinAPI.PostMessageW(HWNDV, WinAPI.WM_CLOSE, 0&, 0&)
                Else
                    WinAPI.TerminateProcess(ProcessHandle_EI, 0&)
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub StopButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopButton.Click
        Dim MSG = MessageBox.Show(LangCls.EncodingStopButtonQ, StopButton.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If MSG = Windows.Forms.DialogResult.Yes Then
        Else
            Exit Sub
        End If
        '------------------
        If SuspendB = True Then
            SuspendResumeButton_Click(Nothing, Nothing)
        End If
        '------------------ 상단코드일시정지처리 
        Try
            EncSTOPBool = True
            If IndexProc = True Then
                AviSynthPP.INDEX_ProcessStopChk = True
                WinAPI.TerminateProcess(AviSynthPP.INDEX_ProcessHandle_ID, 0&)
            Else
                WinAPI.PostMessageW(HWNDV, WinAPI.WM_KEYDOWN, Keys.Q, 0&)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub CapTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CapTimer.Tick
        Dim Pnt As Double = EncPositionD / EncDurationD
        Dim PntS As String = "0.00%"

        If IndexProc = True Then
            If AviSynthPP.INDEX_PStr = "" Then
                PntS = "0%"
            End If
            PntS = AviSynthPP.INDEX_PStr & "%"
        Else
            If IsNumeric(Pnt) = True AndAlso EncDurationD <> 0 Then
                PntS = Format(Pnt, "0.00%")
            End If
        End If

        Me.Text = LangCls.EncodingFrmV & ": " & PntS & " " & EncPassStr
        MainFrm.Text = PntS & " [" & EncindexI + 1 & "/" & MainFrm.EncListListView.Items.Count & "] " & MainFrm.EncListListView.Items(EncindexI).SubItems(0).Text & " - " & MainFrmTitleBack
        MainFrm.NotifyIcon.Text = Strings.Left(MainFrm.Text, 63)

        'Win7진행바
        Try
            If (Environment.OSVersion.Version.Major = 6 AndAlso Environment.OSVersion.Version.Minor >= 1) OrElse Environment.OSVersion.Version.Major > 6 Then
                _ITaskbarList3.SetProgressValue(MainFrm.Handle, Convert.ToInt64(ProgressBar.Value), Convert.ToInt64(ProgressBar.Maximum))
            End If
        Catch ex As Exception
        End Try
    End Sub

End Class