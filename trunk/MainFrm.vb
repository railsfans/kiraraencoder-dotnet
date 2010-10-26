﻿' ---------------------------------------------------------------------------------------
' 
' Copyright (C) 2008-2010 LEE KIWON
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

Imports System.Runtime.InteropServices
Imports Microsoft.Win32.SafeHandles
Imports System.IO
Imports System.Xml

Public Class MainFrm

    'AviSynthDLL 위치
    Public PubAVSPATHStr As String = Environ("SystemRoot") & "\system32\avisynth.dll"

    '-------------------------------

    '핸들
    Public MainFrmHWNDV As Long = 0

    '열기 오류여부
    Dim OpenErrV As Boolean = False
    Dim AVS_OpenErrV As Boolean = False
    Dim APP_OpenErrV As Boolean = False

    '프론트엔드 코어
    Private OutputHandle_GI As SafeFileHandle = Nothing
    Private InputHandle_GI As SafeFileHandle = Nothing
    Public ProcessHandle_GI As IntPtr = Nothing
    Private ThreadSignal_GI As New Threading.ManualResetEvent(False)

    '프로세스 우선 순위
    Enum PriorityClass
        REALTIME_PRIORITY_CLASS = &H100
        HIGH_PRIORITY_CLASS = &H80
        ABOVE_NORMAL_PRIORITY_CLASS = 32768
        NORMAL_PRIORITY_CLASS = &H20
        BELOW_NORMAL_PRIORITY_CLASS = 16384
        IDLE_PRIORITY_CLASS = &H40
    End Enum

    '캐시파일 인덱스
    Dim Cache_i As Integer = 0

    '프로세스 종료 확인
    Dim ProcessEChkB As Boolean = False

    '강제중단 체크
    Public InfoGExit As Boolean = False

    'FLoadFrm
    Public FLoadFrmFileName() As String

    'EncListListView
    Dim EncListListViewChkB As Boolean = False

    '선택된인덱스
    Public SelIndex As Integer = -1

    '폼의 위치 및 크기를 기억
    Dim RzWidth As String
    Dim RzHeight As String
    Dim RzX As String
    Dim RzY As String

    'MPLAYER
    Public MPLAYEREXESTR As String = ""

    '명령어
    Public AviSynthCommandStr As String = ""
    Public AviSynthCommand2PassStr As String = ""
    Public FFmpegCommandStr As String = ""
    Public FFmpegCommand2PassStr As String = ""
    Public VF_TextBox As String = ""
    Public NeroAACSTRFFmpeg As String = ""
    Public NeroAACSTRAviSynth As String = ""
    Public NeroAACSTRNEP As String = ""

    '외부폼설정
    Public VolTrackBarStreamFrmV As Integer = 100
    Public AllChToolStripMenuItemStreamFrmV As Boolean = True
    Public LeftChToolStripMenuItemStreamFrmV As Boolean = False
    Public RightChToolStripMenuItemStreamFrmV As Boolean = False
    Public rateMStreamFrmV As Single = 1.0
    Public scaletempoToolStripMenuItemStreamFrmV As Boolean = False
    Public extrastereoToolStripMenuItemStreamFrmV As Boolean = False
    Public karaokeToolStripMenuItemStreamFrmV As Boolean = False
    Public VisualizeMotionVectorsToolStripMenuItemStreamFrmV As Boolean = False
    Public VisualizeBlockTypesToolStripMenuItemStreamFrmV As Boolean = False
    Public FFmpegDeinterlacerToolStripMenuItemStreamFrmV As Boolean = False
    Public AspectOriginToolStripMenuItemStreamFrmV As Boolean = True
    Public SizeOriginToolStripMenuItemStreamFrmV As Boolean = False
    Public OldVerCheckBoxAVSIFrmV As Boolean = False
    Public PriorityComboBoxEncodingFrmV As Integer = 2

    '설정
    Dim MainWidth As String = ""
    Dim MainHeight As String = ""
    Dim MainX As String = ""
    Dim MainY As String = ""
    Dim MainWindowState As String = ""
    Dim LangToolStripMenuItemV As String = "Auto-select"

    'SEEKMODE = -1?
    Public SEEKMODEM1B As Boolean = False

#Region "프론트엔드 코어"

    '=================================
    '코드 출처: http://www.vbforums.com/showthread.php?t=618110
    '위의 URL에 있는 핵심 소스를 사용하여 제작되었습니다.

    Private Sub WriteToOutputBox(ByVal MsgV As String)
        If OutputBox_GI.InvokeRequired Then
            Try
                Invoke(New Action(Of String)(AddressOf WriteToOutputBox), MsgV)
            Catch ex As Exception
            End Try
        Else
            OutputBox_GI.AppendText(MsgV)
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
                If Not OutputHandle_GI Is Nothing Then
                    PNP = WinAPI.PeekNamedPipe(OutputHandle_GI, Nothing, 0, 0, BytesAvailable, 0)
                End If

                If PNP = True Then
                    If BytesAvailable > 0 Then
                        ReDim Buffer(CInt(BytesAvailable))
                        If WinAPI.ReadFile(OutputHandle_GI, Buffer, CUInt(Buffer.Length), BytesRead, 0) Then
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
            WaitOnHandles(0) = ProcessHandle_GI
            WaitOnHandles(1) = ThreadSignal_GI.SafeWaitHandle.DangerousGetHandle
            If WinAPI.WaitForMultipleObjects(2, WaitOnHandles, False, 0) = 0 Then
                EndOfProcess()
                Exit Do
            End If

            Application.DoEvents()
        Loop

    End Sub

    Private Sub EndOfProcess()

        If OutputBox_GI.InvokeRequired Then
            Invoke(New MethodInvoker(AddressOf EndOfProcess))
        Else
            DestroyHandles()
            '프로세스 종료 확인
            ProcessEChkB = True
        End If

    End Sub

    Public Sub DestroyHandles()

        If ProcessHandle_GI <> IntPtr.Zero Then
            WinAPI.CloseHandle(ProcessHandle_GI)
        End If

        If Not InputHandle_GI Is Nothing AndAlso Not InputHandle_GI.IsClosed Then
            InputHandle_GI.Close()
        End If

        If Not OutputHandle_GI Is Nothing AndAlso Not OutputHandle_GI.IsClosed Then
            OutputHandle_GI.Close()
        End If

    End Sub

    '=================================

#End Region

#Region "Sub 모음"

    Public Sub GetInfo(ByVal MPATHV As String)

        'FFmpeg 없으면 통과//
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\tools\ffmpeg\ffmpeg.exe") = False Then
            Exit Sub
        End If

        '유니코드처리...
        Dim UnicodeMPATHV As String = ""
        Dim FNGBytes() As Byte = System.Text.Encoding.Default.GetBytes(MPATHV)
        If InStr(System.Text.Encoding.Default.GetString(FNGBytes), "?") <> 0 Then
            UnicodeMPATHV = MPATHV
            MPATHV = WinAPI.GetShortPathName(MPATHV)
        End If

        Dim MSGB As String = ""
        MSGB = My.Application.Info.DirectoryPath & "\tools\ffmpeg\ffmpeg.exe -y -i " & Chr(34) & MPATHV & Chr(34)

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
                               New HandleRef(Me, Process.GetCurrentProcess.Handle), InputHandle_GI, 0, False, WinAPI.DUPLICATE_SAME_ACCESS)
        WinAPI.DuplicateHandle(New HandleRef(Me, Process.GetCurrentProcess.Handle), TempOutputHandle, _
                               New HandleRef(Me, Process.GetCurrentProcess.Handle), OutputHandle_GI, 0, False, WinAPI.DUPLICATE_SAME_ACCESS)

        TempOutputHandle.Close()
        TempInputHandle.Close()
        TempOutputHandle.Dispose()
        TempInputHandle.Dispose()

        '프로세스 우선순위 설정
        Dim PPInt As Integer = PriorityClass.NORMAL_PRIORITY_CLASS
        Dim ProcessInformation As New WinAPI.PROCESS_INFORMATION
        WinAPI.CreateProcess(Nothing, MSGB, SecurityAttributes, SecurityAttributes, True, PPInt, IntPtr.Zero, Nothing, StartupInfo, ProcessInformation)

        If ProcessInformation.dwProcessId <> 0 AndAlso ProcessInformation.hProcess <> IntPtr.Zero Then
            '비어있게
            OutputBox_GI.Text = ""
            '프로세스 종료 확인
            ProcessEChkB = False

            ProcessHandle_GI = ProcessInformation.hProcess
            Dim ThreadSTR As New Threading.Thread(AddressOf OutputInfo)
            ThreadSTR.IsBackground = True
            ThreadSTR.Start()
        End If

        '-----

        Do Until ProcessEChkB = True
            Application.DoEvents()
            Threading.Thread.Sleep(10)
        Loop

        If InfoGExit = True Then
            InfoGExit = False
            Exit Sub
        End If

        '-----
        Dim ELVI As ListViewItem
        '유니코드처리...
        If UnicodeMPATHV = "" Then
            ELVI = EncListListView.Items.Add(Mid(MPATHV, InStrRev(MPATHV, "\") + 1))
        Else
            ELVI = EncListListView.Items.Add(Mid(UnicodeMPATHV, InStrRev(UnicodeMPATHV, "\") + 1))
        End If

        For ELVCI = 1 To EncListListView.Columns.Count
            ELVI.SubItems.Add(String.Empty)
        Next
        If EncListListView.Columns.Count = 0 Then
            Exit Sub
        End If
        ELVI.SubItems(10).Text = MPATHV

        '정보 가져오기 시작
        Dim ia2 As Integer = 1, iia2 As Integer = 0
        Dim ta2 As String = ""

        '재생시간
        ia2 = 1
        iia2 = 0
        ta2 = ""
        If InStr(ia2, OutputBox_GI.Text, "  Duration: ", CompareMethod.Text) Then
            iia2 = InStr(ia2, OutputBox_GI.Text, "  Duration: ", CompareMethod.Text)
            If InStr(iia2, OutputBox_GI.Text, ",", CompareMethod.Text) Then
                ia2 = InStr(iia2, OutputBox_GI.Text, ",", CompareMethod.Text) + 1
                ta2 = Mid(OutputBox_GI.Text, iia2, ia2 - iia2 - 1)
            End If
        Else
            ia2 = ia2 + 1
        End If
        If ta2 <> "" Then
            ta2 = Mid(ta2, InStrRev(ta2, ": ") + 2)
        End If
        ELVI.SubItems(1).Text = ta2
        ELVI.SubItems(11).Text = ta2 & " [00:00:00.00 - 00:00:00.00]"

        '화면크기
        ia2 = 1
        iia2 = 0
        ta2 = ""
        If InStr(ia2, OutputBox_GI.Text, "Video: ", CompareMethod.Text) Then
            iia2 = InStr(ia2, OutputBox_GI.Text, "Video: ", CompareMethod.Text)
            If InStr(iia2, OutputBox_GI.Text, vbNewLine, CompareMethod.Text) Then
                ia2 = InStr(iia2, OutputBox_GI.Text, vbNewLine, CompareMethod.Text) + 1
                ta2 = Mid(OutputBox_GI.Text, iia2, ia2 - iia2 - 1)
            End If
        Else
            ia2 = ia2 + 1
        End If

        If InStr(1, ta2, " / 0x") <> 0 Then
            Try
                If InStr(ta2, ",", CompareMethod.Text) <> 0 Then ta2 = Split(ta2, ",")(1)
            Catch ex As Exception
            End Try
        Else
            Try
                If InStr(ta2, ",", CompareMethod.Text) <> 0 Then ta2 = Split(ta2, ",")(2)
            Catch ex As Exception
            End Try
        End If
        If ta2 <> "" Then
            Try
                If InStr(ta2, " ", CompareMethod.Text) <> 0 Then ELVI.SubItems(12).Text = Split(ta2, " ")(1)
            Catch ex As Exception
            End Try
        End If
        If ELVI.SubItems(12).Text = "" Then
            ELVI.SubItems(12).Text = "0x0"
        End If

        '비디오프레임 미디어 인포
        Dim _MI As MediaInfo
        _MI = New MediaInfo
        _MI.Open(MPATHV)
        ta2 = _MI.Get_(StreamKind.Visual, 0, "FrameRate")
        If IsNumeric(ta2) = False Then
            If InStr(ta2, " ") <> 0 Then
                ta2 = Split(ta2, " ")(0)
                If IsNumeric(ta2) = False Then
                    ta2 = ""
                End If
            Else
                ta2 = ""
            End If
        End If
        _MI.Close()
        '비디오프레임 fps
        If ta2 = "" Then
            ia2 = 1
            iia2 = 0
            ta2 = ""
            If InStr(ia2, OutputBox_GI.Text, "Video: ", CompareMethod.Text) Then
                iia2 = InStr(ia2, OutputBox_GI.Text, "Video: ", CompareMethod.Text)
                If InStr(iia2, OutputBox_GI.Text, " fps", CompareMethod.Text) Then
                    ia2 = InStr(iia2, OutputBox_GI.Text, " fps", CompareMethod.Text) + 1
                    ta2 = Mid(OutputBox_GI.Text, iia2, ia2 - iia2 - 1)
                End If
            Else
                ia2 = ia2 + 1
            End If
            If ta2 <> "" Then
                ta2 = Mid(ta2, InStrRev(ta2, " ") + 1)
                If IsNumeric(ta2) = False Then
                    ta2 = ""
                End If
            End If
        End If
        '비디오프레임 tbr
        If ta2 = "" Then
            ia2 = 1
            iia2 = 0
            If InStr(ia2, OutputBox_GI.Text, "Video: ", CompareMethod.Text) Then
                iia2 = InStr(ia2, OutputBox_GI.Text, "Video: ", CompareMethod.Text)
                If InStr(iia2, OutputBox_GI.Text, " tbr", CompareMethod.Text) Then
                    ia2 = InStr(iia2, OutputBox_GI.Text, " tbr", CompareMethod.Text) + 1
                    ta2 = Mid(OutputBox_GI.Text, iia2, ia2 - iia2 - 1)
                End If
            Else
                ia2 = ia2 + 1
            End If
            If ta2 <> "" Then
                ta2 = Mid(ta2, InStrRev(ta2, " ") + 1)
                If IsNumeric(ta2) = False Then
                    ta2 = ""
                End If
            End If
        End If
        If ta2 = "" Then
            ta2 = 0
        End If
        ELVI.SubItems(12).Text = ELVI.SubItems(12).Text & "," & ta2

        '형식
        ia2 = 1
        iia2 = 0
        ta2 = ""
        If InStr(ia2, OutputBox_GI.Text, "Input #0, ", CompareMethod.Text) Then
            iia2 = InStr(ia2, OutputBox_GI.Text, "Input #0, ", CompareMethod.Text)
            If InStr(iia2, OutputBox_GI.Text, ", from", CompareMethod.Text) Then
                ia2 = InStr(iia2, OutputBox_GI.Text, ", from", CompareMethod.Text) + 1
                ta2 = Mid(OutputBox_GI.Text, iia2, ia2 - iia2 - 1)
            End If
        Else
            ia2 = ia2 + 1
        End If
        If ta2 <> "" Then
            ELVI.SubItems(3).Text = UCase(Mid(ta2, InStrRev(ta2, " ") + 1))
        End If

        '여러스트림 출력(텍스트화) #1
        Dim StreamIO As String = ""
        ia2 = 1
        iia2 = 0
        ta2 = ""
        If InStr(ia2, OutputBox_GI.Text, "Stream #", CompareMethod.Text) Then
            iia2 = InStr(ia2, OutputBox_GI.Text, "Stream #", CompareMethod.Text)
            If InStr(iia2, OutputBox_GI.Text, "At least one output file must be specified", CompareMethod.Text) Then
                ia2 = InStr(iia2, OutputBox_GI.Text, "At least one output file must be specified", CompareMethod.Text)
                ta2 = Mid(OutputBox_GI.Text, iia2, ia2 - iia2 - 1)
            End If
        Else
            ia2 = ia2 + 1
        End If
        StreamIO = ta2 & vbNewLine

        '여러스트림 출력(목록화) #2
        '---------------------------------------------
        '오디오 스트림 개수 저장
        Dim AudioStramCntStr As String = "0"
        Dim MI2 As MediaInfo
        MI2 = New MediaInfo
        MI2.Open(MPATHV)
        AudioStramCntStr = MI2.Get_(StreamKind.Audio, 0, "StreamCount")
        MI2.Close()
        '---------------------------------------------
        Dim StreamIOListBox As New ListBox
        StreamIOListBox.Items.Clear()
        ta2 = "LoopSTR"
        Do Until ta2 = ""
            ia2 = 1
            iia2 = 0
            ta2 = ""
            If InStr(ia2, StreamIO, "Stream #", CompareMethod.Text) Then
                iia2 = InStr(ia2, StreamIO, "Stream #", CompareMethod.Text)
                If InStr(iia2, StreamIO, vbNewLine, CompareMethod.Text) Then
                    ia2 = InStr(iia2, StreamIO, vbNewLine, CompareMethod.Text) + 1
                    ta2 = Mid(StreamIO, iia2, ia2 - iia2 - 1)
                End If
            Else
                ia2 = ia2 + 1
            End If
            If ta2 <> "" Then

                StreamIO = Replace(StreamIO, ta2, "")
                If InStr(ta2, "[0x") <> 0 AndAlso InStr(ta2, "Audio") <> 0 Then
                    Try
                        Dim MI As MediaInfo
                        MI = New MediaInfo
                        MI.Open(MPATHV)
                        If AudioStramCntStr <> "" OrElse AudioStramCntStr <> "0" Then
                            Dim i As Integer
                            For i = 0 To AudioStramCntStr - 1
                                Dim ta2v As String = MI.Get_(StreamKind.Audio, i, "ID")
                                If ta2v <> "" Then
                                    Dim ta3 As String = UCase(Strings.Right(Split(Split(ta2, "[0x")(1), "]")(0), 2))
                                    Dim hex3 As String = Strings.Right(Hex(ta2v), 2)
                                    If ta3 = hex3 Then
                                        ta2 = Split(ta2, "[0x")(0) & "[0x" & Hex(ta2v) & "]" & Split(ta2, "]")(1)
                                        StreamIOListBox.Items.Add(ta2)
                                        Exit For
                                    End If
                                End If
                            Next
                        End If
                        MI.Close()
                    Catch ex As Exception
                    End Try
                Else
                    StreamIOListBox.Items.Add(ta2)
                End If

            End If
            Application.DoEvents()
        Loop

        '여러스트림 비디오, 오디오 출력(구분) #3
        For SCHK = 1 To StreamIOListBox.Items.Count
            If InStr(StreamIOListBox.Items(SCHK - 1), "Video") <> 0 Then 'vbCr 윈도우 2000 캐리지 리턴(음표) 제거
                ELVI.SubItems(8).Text = ELVI.SubItems(8).Text & Replace(StreamIOListBox.Items(SCHK - 1), vbCr, "") & " | "
            ElseIf InStr(StreamIOListBox.Items(SCHK - 1), "Audio") <> 0 Then
                ELVI.SubItems(9).Text = ELVI.SubItems(9).Text & Replace(StreamIOListBox.Items(SCHK - 1), vbCr, "") & " | "
            End If
        Next
        If ELVI.SubItems(8).Text = "" Then
            ELVI.SubItems(8).Text = "None"
        End If
        If ELVI.SubItems(9).Text = "" Then
            ELVI.SubItems(9).Text = "None"
        End If

        '오디오스트림
        Try
            ELVI.SubItems(4).Text = Split(ELVI.SubItems(9).Text, ":")(0)
        Catch ex As Exception
        End Try

        '자막
        If Dir(Mid(MPATHV, 1, InStrRev(MPATHV, ".", -1, CompareMethod.Text)) & "ass") <> "" Then
            ELVI.SubItems(2).Text = "ASS"
        ElseIf Dir(Mid(MPATHV, 1, InStrRev(MPATHV, ".", -1, CompareMethod.Text)) & "smi") <> "" Then
            ELVI.SubItems(2).Text = "SMI"
        ElseIf Dir(Mid(MPATHV, 1, InStrRev(MPATHV, ".", -1, CompareMethod.Text)) & "srt") <> "" Then
            ELVI.SubItems(2).Text = "SRT"
        ElseIf Dir(Mid(MPATHV, 1, InStrRev(MPATHV, ".", -1, CompareMethod.Text)) & "ssa") <> "" Then
            ELVI.SubItems(2).Text = "SSA"
        ElseIf Dir(Mid(MPATHV, 1, InStrRev(MPATHV, ".", -1, CompareMethod.Text)) & "sub") <> "" Then
            ELVI.SubItems(2).Text = "SUB"
        Else
            ELVI.SubItems(2).Text = "X"
        End If

        '내장코덱
        If InStr(1, ELVI.SubItems(8).Text, " / 0x", CompareMethod.Text) <> 0 Then
            ELVI.SubItems(5).Text = "V_" & "None"
        ElseIf InStr(1, ELVI.SubItems(9).Text, " / 0x", CompareMethod.Text) <> 0 Then
            ELVI.SubItems(5).Text = "A_" & "None"
        ElseIf ELVI.SubItems(8).Text = "None" And ELVI.SubItems(9).Text = "None" Then
            ELVI.SubItems(5).Text = ""
        Else
            ELVI.SubItems(5).Text = "O"
        End If

        'FFINDEX_FILENAME_i
        ELVI.SubItems(13).Text = Format(Now, "yyyyMMddHHmmss") & Cache_i
        Cache_i += 1

        'Crop
        ELVI.SubItems(15).Text = "0,0,0,0"

        '상태
        ELVI.SubItems(6).Text = LangCls.MainWaitStr
        ELVI.Checked = True

    End Sub

    Public Sub RefPreset()

        PresetContextMenuStrip.Items.Clear()
        PresetContextMenuStrip.Items.Add(LangCls.MainAddStr, Nothing, AddressOf AddPreset)
        PresetContextMenuStrip.Items.Add(LangCls.MainRefreshStr, Nothing, AddressOf RefPreset)
        PresetContextMenuStrip.Items.Add(LangCls.MainOpenPresetFolderStr, Nothing, AddressOf OpenPresetFolder)
        PresetContextMenuStrip.Items.Add("-", Nothing, Nothing)
        PresetContextMenuStrip.Items.Add(LangCls.MainSInitializationStr, Nothing, AddressOf InitializationPreset)
        PresetContextMenuStrip.Items.Add("-", Nothing, Nothing)

        '프리셋 폴더의 파일
        For Each IOGF As IO.FileInfo In New IO.DirectoryInfo(My.Application.Info.DirectoryPath & "\preset").GetFiles("*.xml")
            PresetContextMenuStrip.Items.Add(Strings.Left(IOGF.Name, InStrRev(IOGF.Name, ".") - 1), Nothing, AddressOf OutSelectPreset)
        Next

        '프리셋 폴더의 하위 폴더 및 하위 폴더의 파일
        For Each IOGF As IO.DirectoryInfo In New IO.DirectoryInfo(My.Application.Info.DirectoryPath & "\preset").GetDirectories
            Dim TSM As New ToolStripMenuItem
            TSM.Text = IOGF.Name
            For Each IOGF2 As IO.FileInfo In New IO.DirectoryInfo(My.Application.Info.DirectoryPath & "\preset\" & IOGF.Name).GetFiles("*.xml")
                PresetContextMenuStrip.Items.Add(TSM)
                TSM.DropDownItems.Add(Strings.Left(IOGF2.Name, InStrRev(IOGF2.Name, ".") - 1), Nothing, AddressOf OutSelectPreset)
            Next
        Next

    End Sub

    Private Sub InitializationPreset(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim MSGV = MessageBox.Show(LangCls.MainSetEncAVSStr & vbNewLine & LangCls.MainInitializationQ, sender.ToString, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If MSGV = Windows.Forms.DialogResult.Yes Then
            '설정초기화
            DefSUB()
            '설정저장
            XML_SAVE(My.Application.Info.DirectoryPath & "\settings.xml")
            '프리셋 표시
            PresetLabel.Text = LangCls.MainUserStr
            '명령어 받기
            EncSetFrm.GETFFCMD()
        End If
    End Sub

    Private Sub AddPreset(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            AddPresetFrm.ShowDialog(Me)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub OpenPresetFolder(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("explorer.exe", My.Application.Info.DirectoryPath & "\preset")
    End Sub

    Private Sub OutSelectPreset(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim PathV As String = ""
        Dim TSM As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        If TSM.OwnerItem Is Nothing Then
            PathV = sender.ToString & ".xml"
        Else
            PathV = TSM.OwnerItem.Text & "\" & sender.ToString & ".xml"
        End If

        Try
            If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\preset\" & PathV) = True Then
                '기본값 - 새로운 설정이 나올때 기본값을 안 해버리면 그대로 이전 설정 나오게 됨
                DefSUB()
                '설정열고저장
                XML_LOAD(My.Application.Info.DirectoryPath & "\preset\" & PathV)
                XML_SAVE(My.Application.Info.DirectoryPath & "\settings.xml")
                '프리셋 표시
                PresetLabel.Text = PathV
                '명령어 받기
                EncSetFrm.GETFFCMD()
            Else
                MsgBox(My.Application.Info.DirectoryPath & "\preset\" & PathV & " not found")
                '새로고침
                RefPreset()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub MAINLANGLOAD()
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
                    MainPanel.Font = New Font(FNXP, FS)
                Else
                    MainPanel.Font = New Font(FN, FS)
                End If
                'EncListListView.Font = New Font(Me.Font.Name, Me.Font.Size)

                If XTR.Name = "MainFrmLangToolStripMenuItem" Then LangToolStripMenuItem.Text = XTR.ReadString
                If XTR.Name = "MainFrmAboutToolStripMenuItem" Then AboutToolStripMenuItem.Text = XTR.ReadString
                If XTR.Name = "MainFrmEncListGroupBox" Then EncListGroupBox.Text = XTR.ReadString
                If XTR.Name = "MainFrmEncListListView0" Then EncListListView.Columns(0).Text = XTR.ReadString
                If XTR.Name = "MainFrmEncListListView1" Then EncListListView.Columns(1).Text = XTR.ReadString
                If XTR.Name = "MainFrmEncListListView2" Then EncListListView.Columns(2).Text = XTR.ReadString
                If XTR.Name = "MainFrmEncListListView3" Then EncListListView.Columns(3).Text = XTR.ReadString
                If XTR.Name = "MainFrmEncListListView4" Then EncListListView.Columns(4).Text = XTR.ReadString
                If XTR.Name = "MainFrmEncListListView5" Then EncListListView.Columns(5).Text = XTR.ReadString
                If XTR.Name = "MainFrmEncListListView6" Then EncListListView.Columns(6).Text = XTR.ReadString
                If XTR.Name = "MainFrmAddButton" Then AddButton.Text = XTR.ReadString
                If XTR.Name = "MainFrmRemoveButton" Then RemoveButton.Text = XTR.ReadString
                If XTR.Name = "MainFrmAllRemoveButton" Then AllRemoveButton.Text = XTR.ReadString
                If XTR.Name = "MainFrmFileInfoButton" Then FileInfoButton.Text = XTR.ReadString
                If XTR.Name = "MainFrmStreamSelButton" Then StreamSelButton.Text = XTR.ReadString
                If XTR.Name = "MainFrmOutputGroupBox" Then OutputGroupBox.Text = XTR.ReadString
                If XTR.Name = "MainFrm_FileLabel" Then _FileLabel.Text = XTR.ReadString
                If XTR.Name = "MainFrm_VideoLabel" Then _VideoLabel.Text = XTR.ReadString
                If XTR.Name = "MainFrm_AudioLabel" Then _AudioLabel.Text = XTR.ReadString
                If XTR.Name = "MainFrmAVSCheckBox" Then AVSCheckBox.Text = XTR.ReadString
                If XTR.Name = "MainFrmSetButton" Then
                    AVSSetButton.Text = XTR.ReadString
                    EncSetButton.Text = AVSSetButton.Text
                End If
                If XTR.Name = "MainFrmEncSetGroupBox" Then EncSetGroupBox.Text = XTR.ReadString
                If XTR.Name = "MainFrmPresetButton" Then PresetButton.Text = XTR.ReadString
                If XTR.Name = "MainFrmSaveFolderGroupBox" Then SaveFolderGroupBox.Text = XTR.ReadString
                If XTR.Name = "MainFrmSetFolderButton" Then SetFolderButton.Text = XTR.ReadString
                If XTR.Name = "MainFrmOpenFolderButton" Then OpenFolderButton.Text = XTR.ReadString
                If XTR.Name = "MainFrmEncSButton" Then EncSButton.Text = XTR.ReadString
                If XTR.Name = "MainSupportedFilesStr" Then LangCls.MainSupportedFilesStr = XTR.ReadString
                If XTR.Name = "MainVideoFilesStr" Then LangCls.MainVideoFilesStr = XTR.ReadString
                If XTR.Name = "MainAudioFilesStr" Then LangCls.MainAudioFilesStr = XTR.ReadString
                If XTR.Name = "MainAllFilesStr" Then LangCls.MainAllFilesStr = XTR.ReadString
                If XTR.Name = "MainWaitStr" Then LangCls.MainWaitStr = XTR.ReadString
                If XTR.Name = "MainDoneStr" Then LangCls.MainDoneStr = XTR.ReadString
                If XTR.Name = "MainErrorStr" Then LangCls.MainErrorStr = XTR.ReadString
                If XTR.Name = "MainStopStr" Then LangCls.MainStopStr = XTR.ReadString
                If XTR.Name = "MainSkipStr" Then LangCls.MainSkipStr = XTR.ReadString
                If XTR.Name = "MainEncodingStr" Then LangCls.MainEncodingStr = XTR.ReadString
                If XTR.Name = "MainUACV" Then LangCls.MainUACV = XTR.ReadString
                If XTR.Name = "MainVideoStr" Then LangCls.MainVideoStr = XTR.ReadString
                If XTR.Name = "MainAudioStr" Then LangCls.MainAudioStr = XTR.ReadString
                If XTR.Name = "MainNotCalAVByteC" Then LangCls.MainNotCalAVByteC = XTR.ReadString
                If XTR.Name = "MainExAVByteC" Then LangCls.MainExAVByteC = XTR.ReadString
                If XTR.Name = "MainOriginAspect" Then LangCls.MainOriginAspect = XTR.ReadString
                If XTR.Name = "MainNoKeepAspect" Then LangCls.MainNoKeepAspect = XTR.ReadString
                If XTR.Name = "MainAspectLetterBox" Then LangCls.MainAspectLetterBox = XTR.ReadString
                If XTR.Name = "MainAspectCrop" Then LangCls.MainAspectCrop = XTR.ReadString
                If XTR.Name = "MainOutputAspect" Then LangCls.MainOutputAspect = XTR.ReadString
                If XTR.Name = "MainOriginalAspect" Then LangCls.MainOriginalAspect = XTR.ReadString
                If XTR.Name = "MainOriginalSamplerate" Then LangCls.MainOriginalSamplerate = XTR.ReadString
                If XTR.Name = "MainchoriginComboBox" Then LangCls.MainchoriginComboBox = XTR.ReadString
                If XTR.Name = "Mainch10Str" Then LangCls.Mainch10Str = XTR.ReadString
                If XTR.Name = "Mainch20Str" Then LangCls.Mainch20Str = XTR.ReadString
                If XTR.Name = "Mainch51Str" Then LangCls.Mainch51Str = XTR.ReadString
                If XTR.Name = "MaindolbysStr" Then LangCls.MaindolbysStr = XTR.ReadString
                If XTR.Name = "MaindolbypStr" Then LangCls.MaindolbypStr = XTR.ReadString
                If XTR.Name = "MainNSABitrateStr" Then LangCls.MainNSABitrateStr = XTR.ReadString
                If XTR.Name = "MainNAmplifyStr" Then LangCls.MainNAmplifyStr = XTR.ReadString
                If XTR.Name = "MainAmplifyStr" Then LangCls.MainAmplifyStr = XTR.ReadString
                If XTR.Name = "MainUserStr" Then
                    If PresetLabel.Text = LangCls.MainUserStr Then
                        LangCls.MainUserStr = XTR.ReadString
                        PresetLabel.Text = LangCls.MainUserStr
                    Else
                        LangCls.MainUserStr = XTR.ReadString
                    End If
                End If
                If XTR.Name = "MainSelectListA" Then LangCls.MainSelectListA = XTR.ReadString
                If XTR.Name = "MainAddStr" Then LangCls.MainAddStr = XTR.ReadString
                If XTR.Name = "MainRefreshStr" Then LangCls.MainRefreshStr = XTR.ReadString
                If XTR.Name = "MainOpenPresetFolderStr" Then LangCls.MainOpenPresetFolderStr = XTR.ReadString
                If XTR.Name = "MainSInitializationStr" Then LangCls.MainSInitializationStr = XTR.ReadString
                If XTR.Name = "MainSetEncAVSStr" Then LangCls.MainSetEncAVSStr = XTR.ReadString
                If XTR.Name = "MainInitializationQ" Then LangCls.MainInitializationQ = XTR.ReadString
                If XTR.Name = "MainTrayToolStripMenuItem" Then TrayToolStripMenuItem.Text = XTR.ReadString
                If XTR.Name = "MainAddToolStripMenuItem" Then AddToolStripMenuItem.Text = XTR.ReadString
                If XTR.Name = "MainErrToolStripMenuItem" Then
                    ErrToolStripMenuItem.Text = XTR.ReadString
                    ErrToolStripMenuItem2.Text = ErrToolStripMenuItem.Text
                End If
                If XTR.Name = "MainCheckAllToolStripMenuItem" Then CheckAllToolStripMenuItem.Text = XTR.ReadString
                If XTR.Name = "MainUncheckAllToolStripMenuItem" Then UncheckAllToolStripMenuItem.Text = XTR.ReadString
                If XTR.Name = "MainInPlayToolStripMenuItem" Then InPlayToolStripMenuItem.Text = XTR.ReadString
                If XTR.Name = "MainInInfoToolStripMenuItem" Then InInfoToolStripMenuItem.Text = XTR.ReadString
                If XTR.Name = "MainOutPlayToolStripMenuItem" Then OutPlayToolStripMenuItem.Text = XTR.ReadString
                If XTR.Name = "MainOutInfoToolStripMenuItem" Then OutInfoToolStripMenuItem.Text = XTR.ReadString
                If XTR.Name = "MainFrmInChkToolStripMenuItem" Then InChkToolStripMenuItem.Text = XTR.ReadString
                If XTR.Name = "MainDirectoryNotFound" Then LangCls.MainDirectoryNotFound = XTR.ReadString
                If XTR.Name = "MainFileSame" Then LangCls.MainFileSame = XTR.ReadString
                If XTR.Name = "MainFileNotFound" Then LangCls.MainFileNotFound = XTR.ReadString
                If XTR.Name = "MainFileSizeIsTooLow" Then LangCls.MainFileSizeIsTooLow = XTR.ReadString
               
            Loop
        Catch ex As Exception
            MsgBox("LANG_LOAD_ERROR :" & ex.Message)
        Finally
            XTR.Close()
        End Try
LANG_SKIP:

        '=========================================
    End Sub

    Private Sub GET_AVINFO(ByVal index As Integer)

        'AV정보
        If EncListListView.Items(index).SubItems(8).Text = "None" Then
            VideoTextBox.Text = LangCls.MainVideoStr & ": " & "None"
        Else
            If InStrRev(EncListListView.Items(index).SubItems(8).Text, " |") <> 0 Then
                VideoTextBox.Text = LangCls.MainVideoStr & ": " & Strings.Left(EncListListView.Items(index).SubItems(8).Text, InStrRev(EncListListView.Items(index).SubItems(8).Text, " |") - 1)
            Else
                VideoTextBox.Text = LangCls.MainVideoStr & ": " & "None"
            End If
        End If

        If EncListListView.Items(index).SubItems(9).Text = "None" Then
            AudioTextBox.Text = LangCls.MainAudioStr & ": " & "None"
        Else
            If InStrRev(EncListListView.Items(index).SubItems(9).Text, " |") <> 0 Then
                AudioTextBox.Text = LangCls.MainAudioStr & ": " & Strings.Left(EncListListView.Items(index).SubItems(9).Text, InStrRev(EncListListView.Items(index).SubItems(9).Text, " |") - 1)
            Else
                AudioTextBox.Text = LangCls.MainAudioStr & ": " & "None"
            End If
        End If

    End Sub

    Public Sub GET_OutputINFO(ByVal index As Integer)

        '파일
        '---------------------------------
        ' 원본 파일의 파일 이름만 추출
        '=================================
        Dim FilenameV As String = ""
        If InStrRev(EncListListView.Items(index).SubItems(0).Text, ".") <> 0 Then
            FilenameV = Strings.Left(EncListListView.Items(index).SubItems(0).Text, InStrRev(EncListListView.Items(index).SubItems(0).Text, ".") - 1)
        Else
            FilenameV = EncListListView.Items(index).SubItems(0).Text
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
        ' 출력형식
        '=================================
        Dim OutFComboBoxV As String = ""
        Try
            OutFComboBoxV = Replace(Split(EncSetFrm.OutFComboBox.Text, "]")(0), "[", "")
        Catch ex As Exception
        End Try

        '---------------------------------
        ' 구간설정
        '=================================
        Dim PTimeInfo As String = EncListListView.Items(index).SubItems(11).Text
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
        Dim _GTimeV As String = "" '구간타임
        If (ETimeV - STimeV) = 0 Then
            _GTimeV = EncListListView.Items(index).SubItems(1).Text
        Else
            _GTimeV = FunctionCls.TIME_TO_HMSMSTIME(ETimeV - STimeV, True)
        End If

        Dim GTimeV As String = "" '구간타임
        If InStr(PTimeInfo, "[", CompareMethod.Text) <> 0 Then
            GTimeV = "[" & Split(PTimeInfo, "[")(1)
        End If

        '----------------------------------------------------------------------
        '---------------------------------
        ' 예상 용량
        '=================================
        Dim AVKByteC As String = ""
        '비디오 부분
        Dim ExVideoB As Boolean = False '예외스킵
        Dim VKByteV As Single = Val(EncSetFrm.BitrateComboBox.Text) / 8
        '모드
        If InStr(EncSetFrm.VideoModeComboBox.SelectedItem, "[1PASS-CBR]", CompareMethod.Text) <> 0 Then
        ElseIf InStr(EncSetFrm.VideoModeComboBox.SelectedItem, "[2PASS-CBR]", CompareMethod.Text) <> 0 Then
        Else
            ExVideoB = True
        End If
        '코덱
        If ExVideoB = False Then
            If EncSetFrm.VideoCodecComboBox.Text = "Huffyuv Lossless Video Codec" Then
                ExVideoB = True
            End If
        End If
        '///
        '오디오 부분
        Dim ExAudioB As Boolean = False '예외스킵
        Dim AKByteV As Single = Val(EncSetFrm.AudioBitrateComboBox.Text) / 8
        '코덱
        If ExAudioB = False Then
            If EncSetFrm.AudioCodecComboBox.Text = "[WAV] signed 16-bit little-endian PCM" Then 'WAV
                Dim ACHV As Integer = 0
                If AVSCheckBox.Checked = True Then 'AviSynth 사용
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
        '결과
        Dim __GTimeV As Single = (ETimeV - STimeV)
        If __GTimeV = 0 Then
            Try
                __GTimeV = (Val(Split(EncListListView.Items(index).SubItems(1).Text, ":")(0)) * 3600) + _
                           (Val(Split(EncListListView.Items(index).SubItems(1).Text, ":")(1)) * 60) + _
                           Val(Split(Split(EncListListView.Items(index).SubItems(1).Text, ":")(2), ".")(0)) + _
                           Val("0." & Split(EncListListView.Items(index).SubItems(1).Text, ".")(1))
            Catch ex As Exception
            End Try
        End If
        '//////////////
        ' 아래는 역으로 EncodingFrm 에서 가져옴.
        '========================================================
        '용량을 기준으로 비트레이트 계산 부분
        Dim CalcVideoBitrateStr As String = ""
        Dim ThrowCalcVB_ERR_B As Boolean = False

        If EncSetFrm.SizeEncCheckBox.Checked = True Then '용량을 기준으로 인코딩 여부 (참)
            If EncSetFrm.VideoModeComboBox.SelectedIndex = EncSetFrm.VideoModeComboBox.FindString("[1PASS-CBR]", -1) OrElse _
            EncSetFrm.VideoModeComboBox.SelectedIndex = EncSetFrm.VideoModeComboBox.FindString("[2PASS-CBR]", -1) Then  'CBR 체크

                If InStr(EncSetFrm.OutFComboBox.SelectedItem, "[AUDIO]", CompareMethod.Text) <> 0 Then '오디오만이므로 비디오 제외.
                Else '둘다

                    If ExAudioB = True Then
                        ThrowCalcVB_ERR_B = True
                    Else
                        Try
                            CalcVideoBitrateStr = ((Val(EncSetFrm.SizeEncTextBox.Text) * (1024 ^ 2)) / __GTimeV) - (AKByteV * 1000)
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
                        CalcVideoBitrateStr = EncSetFrm.BitrateComboBox.Text
                    Else
                        CalcVideoBitrateStr = CalcVideoBitrateStr
                        VKByteV = Val(CalcVideoBitrateStr) / 8
                    End If

                End If

            End If
        End If
        '용량을 기준으로 비트레이트 계산 부분 끝
        '========================================================
        '//////////////
        If InStr(EncSetFrm.OutFComboBox.SelectedItem, "[AUDIO]", CompareMethod.Text) <> 0 Then '오디오만이므로 비디오 제외.
            If ExAudioB = True Then '스킵
                AVKByteC = ""
            Else '용량계산
                AVKByteC = ((AKByteV * 1000) * __GTimeV) / 1024
            End If
        Else '둘다
            If ExVideoB = True OrElse ExAudioB = True Then '스킵
                AVKByteC = ""
            Else '용량계산
                '비디오 부분은 추후에 고칠 예정 ㅇ_ㅇ...
                AVKByteC = (((VKByteV * 1000) + (AKByteV * 1000)) * __GTimeV) / 1024
            End If
        End If
        If AVKByteC <> "" Then
            If Val(AVKByteC) >= (1024 ^ 4) Then
                AVKByteC = Format((Val(AVKByteC) / (1024 ^ 4)), "0.00") & "PB(" & LangCls.MainExAVByteC & ")"
            ElseIf Val(AVKByteC) >= (1024 ^ 3) Then
                AVKByteC = Format((Val(AVKByteC) / (1024 ^ 3)), "0.00") & "TB(" & LangCls.MainExAVByteC & ")"
            ElseIf Val(AVKByteC) >= (1024 ^ 2) Then
                AVKByteC = Format((Val(AVKByteC) / (1024 ^ 2)), "0.00") & "GB(" & LangCls.MainExAVByteC & ")"
            ElseIf Val(AVKByteC) >= 1024 Then
                AVKByteC = Format((Val(AVKByteC) / 1024), "0.00") & "MB(" & LangCls.MainExAVByteC & ")"
            Else
                AVKByteC = Format(Val(AVKByteC), "0.00") & "KB(" & LangCls.MainExAVByteC & ")"
            End If
        Else
            AVKByteC = LangCls.MainNotCalAVByteC
        End If

        '예상용량 지정정관련 (너무 낮은 용량 메세지)
        Dim FileSizeIsTooLowStr As String = ""

        '비디오 부분 ///////////
        Dim ImageSizeV As String = ""
        Dim ImageAspectV As String = ""
        Dim ImageFramerateV As String = ""
        Dim VideoBitrateV As String = ""
        If InStr(EncSetFrm.OutFComboBox.SelectedItem, "[AUDIO]", CompareMethod.Text) <> 0 Then
        Else '비디오 부분이면.
            '---------------------------------
            ' 영상 사이즈
            '=================================
            If AVSCheckBox.Checked = True Then 'AviSynth 사용
                If EncListListView.Items(index).SubItems(8).Text = "None" AndAlso _
                EncListListView.Items(index).SubItems(9).Text <> "None" Then '오디오 파일 AviSynth 인코딩
                    ImageSizeV = "176x144"
                Else
                    If ImagePPFrm.AviSynthImageSizeCheckBox.Checked = True Then '원본영상사이즈
                        Try
                            ImageSizeV = Split(EncListListView.Items(index).SubItems(12).Text, ",")(0)
                        Catch ex As Exception
                        End Try
                    Else
                        ImageSizeV = ImagePPFrm.AviSynthImageSizeWidthTextBox.Text & "x" & ImagePPFrm.AviSynthImageSizeHeightTextBox.Text
                    End If
                End If
            Else
                If EncSetFrm.ImageSizeCheckBox.Checked = True Then '원본영상사이즈
                    Try
                        ImageSizeV = Split(EncListListView.Items(index).SubItems(12).Text, ",")(0)
                    Catch ex As Exception
                    End Try
                Else
                    ImageSizeV = EncSetFrm.ImageSizeWidthTextBox.Text & "x" & EncSetFrm.ImageSizeHeightTextBox.Text
                End If
            End If
            '---------------------------------
            ' 비율
            '=================================
            If AVSCheckBox.Checked = True Then 'AviSynth 사용
                If EncListListView.Items(index).SubItems(8).Text = "None" AndAlso _
                EncListListView.Items(index).SubItems(9).Text <> "None" Then '오디오 파일 AviSynth 인코딩
                    ImageAspectV = LangCls.MainOriginAspect
                Else
                    If ImagePPFrm.AviSynthImageSizeCheckBox.Checked = True Then '원본영상사이즈
                        ImageAspectV = LangCls.MainOriginAspect
                    Else
                        Dim AviSynthAspectComboBoxV As String = ""
                        If ImagePPFrm.AviSynthAspectComboBox2.Text = LangCls.ImagePPOutputAviSynthAspectComboBox2 Then
                            AviSynthAspectComboBoxV = LangCls.MainOutputAspect
                        ElseIf ImagePPFrm.AviSynthAspectComboBox2.Text = LangCls.ImagePPOriginalAviSynthAspectComboBox2 Then
                            AviSynthAspectComboBoxV = LangCls.MainOriginalAspect
                        Else
                            AviSynthAspectComboBoxV = ImagePPFrm.AviSynthAspectWTextBox.Text & ":" & ImagePPFrm.AviSynthAspectHTextBox.Text
                        End If
                        If ImagePPFrm.AviSynthAspectComboBox.Text = LangCls.ImagePPNoKeepAviSynthAspectComboBox Then
                            ImageAspectV = LangCls.MainNoKeepAspect
                        ElseIf ImagePPFrm.AviSynthAspectComboBox.Text = LangCls.ImagePPLetterBoxAviSynthAspectComboBox Then
                            ImageAspectV = AviSynthAspectComboBoxV & ", " & LangCls.MainAspectLetterBox
                        ElseIf ImagePPFrm.AviSynthAspectComboBox.Text = LangCls.ImagePPCropAviSynthAspectComboBox Then
                            ImageAspectV = AviSynthAspectComboBoxV & ", " & LangCls.MainAspectCrop
                        End If
                    End If
                End If
            Else
                If EncSetFrm.ImageSizeCheckBox.Checked = True Then '원본영상사이즈
                    ImageAspectV = LangCls.MainOriginAspect
                Else
                    Dim AspectComboBoxV As String = ""
                    If EncSetFrm.AspectComboBox2.Text = LangCls.EncSetOutputAspectComboBox2 Then
                        AspectComboBoxV = LangCls.MainOutputAspect
                    ElseIf EncSetFrm.AspectComboBox2.Text = LangCls.EncSetOriginalAspectComboBox2 Then
                        AspectComboBoxV = LangCls.MainOriginalAspect
                    Else
                        AspectComboBoxV = EncSetFrm.AspectWTextBox.Text & ":" & EncSetFrm.AspectHTextBox.Text
                    End If
                    If EncSetFrm.AspectComboBox.Text = LangCls.EncSetNoKeepAspectComboBox Then
                        ImageAspectV = LangCls.MainNoKeepAspect
                    ElseIf EncSetFrm.AspectComboBox.Text = LangCls.EncSetLetterBoxAspectComboBox Then
                        ImageAspectV = AspectComboBoxV & ", " & LangCls.MainAspectLetterBox
                    ElseIf EncSetFrm.AspectComboBox.Text = LangCls.EncSetCropAspectComboBox Then
                        ImageAspectV = AspectComboBoxV & ", " & LangCls.MainAspectCrop
                    End If
                End If
            End If
            '---------------------------------
            ' 프레임레이트
            '=================================
            If AVSCheckBox.Checked = True Then 'AviSynth 사용
                Dim bobv As Integer = 1
                Dim bobstr As String = ""
                With ImagePPFrm
                    If .AVSMPEG2DeinterlaceCheckBox.Checked = True Then
                        If .AVSMPEG2DeinterlaceComboBox.Text = "Yadif mode=1 double framerate (bob)" OrElse .AVSMPEG2DeinterlaceComboBox.Text = "Yadif mode=3 double framerate (bob)" Then
                            If EncListListView.Items(index).SubItems(8).Text = "None" AndAlso _
                            EncListListView.Items(index).SubItems(9).Text <> "None" Then '오디오 파일 AviSynth 인코딩
                            Else
                                bobv = 2
                                bobstr = " - double framerate (bob)"
                            End If
                        End If
                    End If
                End With

                If EncListListView.Items(index).SubItems(8).Text = "None" AndAlso _
                EncListListView.Items(index).SubItems(9).Text <> "None" Then '오디오 파일 AviSynth 인코딩
                    ImageFramerateV = "25 fps" & bobstr
                Else
                    If ImagePPFrm.AviSynthFramerateCheckBox.Checked = True Then
                        Try
                            ImageFramerateV = (Val(Split(EncListListView.Items(index).SubItems(12).Text, ",")(1)) * bobv) & " fps" & bobstr
                        Catch ex As Exception
                        End Try
                    Else
                        ImageFramerateV = (Val(ImagePPFrm.AviSynthFramerateComboBox.Text) * bobv) & " fps" & bobstr
                    End If
                End If

            Else
                If EncSetFrm.FramerateCheckBox.Checked = True Then
                    Try
                        ImageFramerateV = Split(EncListListView.Items(index).SubItems(12).Text, ",")(1) & " fps"
                    Catch ex As Exception
                    End Try
                Else
                    ImageFramerateV = EncSetFrm.FramerateComboBox.Text & " fps"
                End If
            End If
            '---------------------------------
            ' 비트레이트
            '=================================
            If EncSetFrm.VideoModeComboBox.SelectedIndex = EncSetFrm.VideoModeComboBox.FindString("[1PASS-CBR]", -1) Then

                If EncSetFrm.SizeEncCheckBox.Checked = True AndAlso ExAudioB = False Then
                    If ThrowCalcVB_ERR_B = True Then
                        FileSizeIsTooLowStr = " - " & LangCls.MainFileSizeIsTooLow
                    End If
                    VideoBitrateV = "[1PASS-CBR] " & Int(CalcVideoBitrateStr) & " Kbit/s"
                Else
                    VideoBitrateV = "[1PASS-CBR] " & EncSetFrm.BitrateComboBox.Text & " Kbit/s"
                End If

            ElseIf EncSetFrm.VideoModeComboBox.SelectedIndex = EncSetFrm.VideoModeComboBox.FindString("[1PASS-CQP]", -1) Then
                VideoBitrateV = "[1PASS-CQP] Q=" & EncSetFrm.QuantizerCQPNumericUpDown.Value
            ElseIf EncSetFrm.VideoModeComboBox.SelectedIndex = EncSetFrm.VideoModeComboBox.FindString("[1PASS-CRF]", -1) Then
                VideoBitrateV = "[1PASS-CRF] Q=" & EncSetFrm.QualityNumericUpDown.Value
            ElseIf EncSetFrm.VideoModeComboBox.SelectedIndex = EncSetFrm.VideoModeComboBox.FindString("[1PASS-VBR]", -1) Then
                VideoBitrateV = "[1PASS-VBR] Q=" & EncSetFrm.QuantizerNumericUpDown.Value
            ElseIf EncSetFrm.VideoModeComboBox.SelectedIndex = EncSetFrm.VideoModeComboBox.FindString("[2PASS-CBR]", -1) Then

                If EncSetFrm.SizeEncCheckBox.Checked = True AndAlso ExAudioB = False Then
                    If ThrowCalcVB_ERR_B = True Then
                        FileSizeIsTooLowStr = " - " & LangCls.MainFileSizeIsTooLow
                    End If
                    VideoBitrateV = "[2PASS-CBR] " & Int(CalcVideoBitrateStr) & " Kbit/s"
                Else
                    VideoBitrateV = "[2PASS-CBR] " & EncSetFrm.BitrateComboBox.Text & " Kbit/s"
                End If

            ElseIf EncSetFrm.VideoModeComboBox.SelectedIndex = EncSetFrm.VideoModeComboBox.FindString("[LOSSLESS]", -1) Then
                VideoBitrateV = "[LOSSLESS]"
            End If

        End If

        '오디오부분
        '---------------------------------
        ' 샘플레이트
        '=================================
        Dim SamplerateV As String = ""
        '예외코덱
        If EncSetFrm.AudioCodecComboBox.Text = "[AMR] AMR-NB(libopencore)" OrElse EncSetFrm.AudioCodecComboBox.Text = "AMR-NB(libopencore)" Then 'AMR
            SamplerateV = "8000 Hz"
        Else
            If EncSetFrm.SamplerateCheckBox.Checked = True Then
                SamplerateV = LangCls.MainOriginalSamplerate
            Else
                SamplerateV = EncSetFrm.SamplerateComboBox.Text & " Hz"
            End If
        End If

        '---------------------------------
        ' 채널
        '=================================
        Dim ChannelV As String = ""
        '예외코덱
        If EncSetFrm.AudioCodecComboBox.Text = "[AMR] AMR-NB(libopencore)" OrElse EncSetFrm.AudioCodecComboBox.Text = "AMR-NB(libopencore)" Then 'AMR
            ChannelV = LangCls.Mainch10Str
        Else
            If AVSCheckBox.Checked = True Then 'AviSynth 사용
                If AudioPPFrm.AviSynthChComboBox.Text = LangCls.AudioPPchoriginComboBox Then
                    ChannelV = LangCls.MainchoriginComboBox
                ElseIf AudioPPFrm.AviSynthChComboBox.Text = LangCls.AudioPPch10ComboBox Then
                    ChannelV = LangCls.Mainch10Str
                ElseIf AudioPPFrm.AviSynthChComboBox.Text = LangCls.AudioPPch20ComboBox Then
                    ChannelV = LangCls.Mainch20Str
                ElseIf AudioPPFrm.AviSynthChComboBox.Text = LangCls.AudioPPch51ComboBox Then
                    ChannelV = LangCls.Mainch51Str
                ElseIf AudioPPFrm.AviSynthChComboBox.Text = LangCls.AudioPPdolbysComboBox Then
                    ChannelV = LangCls.MaindolbysStr
                ElseIf AudioPPFrm.AviSynthChComboBox.Text = LangCls.AudioPPdolbypComboBox Then
                    ChannelV = LangCls.MaindolbypStr
                End If
            Else
                If EncSetFrm.FFmpegChComboBox.Text = LangCls.EncSetchoriginComboBox Then
                    ChannelV = LangCls.MainchoriginComboBox
                ElseIf EncSetFrm.FFmpegChComboBox.Text = LangCls.EncSetch10ComboBox Then
                    ChannelV = LangCls.Mainch10Str
                ElseIf EncSetFrm.FFmpegChComboBox.Text = LangCls.EncSetch20ComboBox Then
                    ChannelV = LangCls.Mainch20Str
                ElseIf EncSetFrm.FFmpegChComboBox.Text = LangCls.EncSetch51ComboBox Then
                    ChannelV = LangCls.Mainch51Str
                End If
            End If
        End If

        '---------------------------------
        ' 오디오 비트레이트
        '=================================
        Dim AudioBitrateV As String = ""
        '예외코덱
        If EncSetFrm.AudioCodecComboBox.Text = "[WAV] signed 16-bit little-endian PCM" Then 'WAV
            AudioBitrateV = LangCls.MainNSABitrateStr
        ElseIf EncSetFrm.AudioCodecComboBox.Text = "[MP4] Nero AAC" OrElse EncSetFrm.AudioCodecComboBox.Text = "Nero AAC" Then 'NeroAAC
            If EncSetFrm.NeroAACABRRadioButton.Checked = True Then
                AudioBitrateV = "ABR " & EncSetFrm.NeroAACBitrateNumericUpDown.Value & " Kbit/s"
            ElseIf EncSetFrm.NeroAACCBRRadioButton.Checked = True Then
                AudioBitrateV = "CBR " & EncSetFrm.NeroAACBitrateNumericUpDown.Value & " Kbit/s"
            ElseIf EncSetFrm.NeroAACVBRRadioButton.Checked = True Then
                AudioBitrateV = "VBR Q=" & EncSetFrm.NeroAACQNumericUpDown.Value
            End If
        ElseIf EncSetFrm.AudioCodecComboBox.Text = "[AMR] AMR-NB(libopencore)" OrElse EncSetFrm.AudioCodecComboBox.Text = "AMR-NB(libopencore)" Then 'AMR
            AudioBitrateV = EncSetFrm.AMRBitrateComboBox.Text & " Kbit/s"
        ElseIf EncSetFrm.AudioCodecComboBox.Text = "[OGG] Vorbis" OrElse EncSetFrm.AudioCodecComboBox.Text = "Vorbis" Then 'Vorbis
            AudioBitrateV = "Q=" & EncSetFrm.VorbisQNumericUpDown.Value
        ElseIf EncSetFrm.AudioCodecComboBox.Text = "[FLAC] Free Lossless Audio Codec(FLAC)" OrElse EncSetFrm.AudioCodecComboBox.Text = "Free Lossless Audio Codec(FLAC)" Then 'FLAC
            AudioBitrateV = LangCls.MainNSABitrateStr
        Else
            AudioBitrateV = EncSetFrm.AudioBitrateComboBox.Text & " Kbit/s"
        End If

        '---------------------------------
        ' 증폭
        '=================================
        Dim AmplifyV As String = ""
        If AVSCheckBox.Checked = True Then 'AviSynth 사용

            If AudioPPFrm.AmplifyCheckBox.Checked = True Then
                AmplifyV = LangCls.MainAmplifyStr & ": " & AudioPPFrm.AmplifyNumericUpDown.Value & "dB"
            Else
                AmplifyV = LangCls.MainNAmplifyStr
            End If

        Else
            If EncSetFrm.AudioVolTrackBar.Value = 256 Then
                AmplifyV = LangCls.MainNAmplifyStr
            Else
                AmplifyV = LangCls.MainAmplifyStr & ": " & EncSetFrm.AudioVolTrackBar.Value
            End If
        End If

        '==========================================================================================


        '출력 정보
        _FileLabel1.Text = EncSetFrm.HeaderTextBox.Text & FilenameV & ExtensionV
        _FileLabel2.Text = OutFComboBoxV & ", " & _GTimeV & " " & GTimeV & ", " & AVKByteC & FileSizeIsTooLowStr
        If InStr(EncSetFrm.OutFComboBox.SelectedItem, "[AUDIO]", CompareMethod.Text) <> 0 Then
            _VideoLabel1.Text = ""
            _VideoLabel2.Text = ""
        Else
            'If EncListListView.Items(index).SubItems(8).Text = "None" Then
            '    _VideoLabel1.Text = ""
            '    _VideoLabel2.Text = ""
            'Else
            If AVSCheckBox.Checked = False Then 'AviSynth 사용 안 함
                If EncListListView.Items(index).SubItems(8).Text = "None" AndAlso _
                EncListListView.Items(index).SubItems(9).Text <> "None" Then '오디오 파일 FFmpeg 인코딩
                    _VideoLabel1.Text = ""
                    _VideoLabel2.Text = ""
                Else
                    _VideoLabel1.Text = EncSetFrm.VideoCodecComboBox.Text
                    _VideoLabel2.Text = ImageSizeV & ", " & ImageAspectV & ", " & ImageFramerateV & ", " & VideoBitrateV
                End If
            Else
                _VideoLabel1.Text = EncSetFrm.VideoCodecComboBox.Text
                _VideoLabel2.Text = ImageSizeV & ", " & ImageAspectV & ", " & ImageFramerateV & ", " & VideoBitrateV
            End If
            'End If
        End If
        'If EncListListView.Items(index).SubItems(9).Text = "None" Then
        '    _AudioLabel1.Text = ""
        '    _AudioLabel2.Text = ""
        'Else
        _AudioLabel1.Text = EncSetFrm.AudioCodecComboBox.Text
        _AudioLabel2.Text = SamplerateV & ", " & ChannelV & ", " & AudioBitrateV & ", " & AmplifyV
        'End If


    End Sub

#End Region

#Region "활성화 구간"

    Private Sub EnableArea()
        If EncListListView.SelectedItems.Count = 0 Then
            RemoveButton.Enabled = False
            TTListButton.Enabled = False
            TListButton.Enabled = False
            BListButton.Enabled = False
            BBListButton.Enabled = False
            FileInfoButton.Enabled = False
            StreamSelButton.Enabled = False
            AviSynthEditorFrm.ConPanel.Enabled = False

            '비어있게
            VideoTextBox.Text = ""
            AudioTextBox.Text = ""
            _FileLabel1.Text = ""
            _FileLabel2.Text = ""
            _VideoLabel1.Text = ""
            _VideoLabel2.Text = ""
            _AudioLabel1.Text = ""
            _AudioLabel2.Text = ""

            '기타
            ErrToolStripMenuItem.Enabled = False
        Else
            RemoveButton.Enabled = True
            TTListButton.Enabled = True
            TListButton.Enabled = True
            BListButton.Enabled = True
            BBListButton.Enabled = True
            FileInfoButton.Enabled = True
            StreamSelButton.Enabled = True
            AviSynthEditorFrm.ConPanel.Enabled = True
        End If
    End Sub

#End Region


    Private Sub MainForm_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        '폼이 일반 상태일때 기억한다
        If Me.WindowState = FormWindowState.Normal Then
            RzWidth = Me.Size.Width
            RzHeight = Me.Size.Height
        End If
    End Sub

    Private Sub MainForm_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LocationChanged
        '폼이 일반 상태일때 기억한다
        If Me.WindowState = FormWindowState.Normal Then
            RzX = Me.Location.X
            RzY = Me.Location.Y
        End If
    End Sub

    Private Sub MainFrm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        '인코딩중이면 종료금지
        If EncodingFrm.EncProcBool = True Then Exit Sub

        '----------------------------------------------------

        '폼 위치 크기 저장
        MainX = RzX
        MainY = RzY
        MainWidth = RzWidth
        MainHeight = RzHeight
        MainWindowState = Me.WindowState

        '언어설정저장
        For i2 = 0 To LangToolStripMenuItem.DropDownItems.Count - 1
            If CType(LangToolStripMenuItem.DropDownItems(i2), ToolStripMenuItem).Checked = True Then
                LangToolStripMenuItemV = LangToolStripMenuItem.DropDownItems(i2).Text
            End If
        Next

        '최종 파일에 설정저장
        APP_XML_SAVE(My.Application.Info.DirectoryPath & "\app_settings.xml")
        '예외저장
        XML_SAVE(My.Application.Info.DirectoryPath & "\settings.xml")



        '-----------------------------------------------------------




        '작업한 파일삭제
        For i = 0 To CleanUpListBox.Items.Count - 1
            Try
                If My.Computer.FileSystem.FileExists(CleanUpListBox.Items(i)) = True Then My.Computer.FileSystem.DeleteFile(CleanUpListBox.Items(i))
            Catch ex As Exception
            End Try
        Next

        '작업한 파일 삭제 2단계//
        Try
            If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\temp\AviSynthScript.avs") = True Then _
               My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath & "\temp\AviSynthScript.avs")
        Catch ex As Exception
        End Try
        Try
            If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\temp\AviSynthScriptN.avs") = True Then _
               My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath & "\temp\AviSynthScriptN.avs")
        Catch ex As Exception
        End Try
        Try
            If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\temp\Equalizer.feq") = True Then _
               My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath & "\temp\Equalizer.feq")
        Catch ex As Exception
        End Try
        Try
            If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\temp\Subtitle.smi") = True Then _
               My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath & "\temp\Subtitle.smi")
        Catch ex As Exception
        End Try
        Try
            If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\temp\Subtitle.smi.style") = True Then _
               My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath & "\temp\Subtitle.smi.style")
        Catch ex As Exception
        End Try
        Try
            If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\temp\CLIneroAacEnc.bat") = True Then _
               My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath & "\temp\CLIneroAacEnc.bat")
        Catch ex As Exception
        End Try

    End Sub

    Private Sub MainFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '운영체제검사
        If Environment.OSVersion.Platform <> PlatformID.Win32NT Then '윈도우 NT 운영체제가 아닐경우
            MsgBox("Kirara Encoder is not supported on this operating system.")
            Close()
        Else
            If Environment.OSVersion.Version.Major < 5 Then '윈도우 2000 이상의 운영체제가 아닐경우
                MsgBox("Kirara Encoder is not supported on this operating system.")
                Close()
            End If
        End If

        '==================================================

        '관리자모드 필요여부 검사
        Try
            '쓰기
            My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath & "\check.xml", "", False)
            '삭제
            My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath & "\check.xml")
        Catch ex As Exception
            GoTo UAC
        End Try

        '저장폴더 생성
        If My.Computer.FileSystem.DirectoryExists(My.Application.Info.DirectoryPath & "\temp") = False Then
            My.Computer.FileSystem.CreateDirectory(My.Application.Info.DirectoryPath & "\temp")
        End If

        '캐시 저장폴더 생성
        If My.Computer.FileSystem.DirectoryExists(My.Application.Info.DirectoryPath & "\temp\Caches") = False Then
            My.Computer.FileSystem.CreateDirectory(My.Application.Info.DirectoryPath & "\temp\Caches")
        End If

        '프리셋폴더 생성
        If My.Computer.FileSystem.DirectoryExists(My.Application.Info.DirectoryPath & "\preset") = False Then
            My.Computer.FileSystem.CreateDirectory(My.Application.Info.DirectoryPath & "\preset")
        End If

        '-----------------------------------------------------------------------------------------------------------------------------------------------------

        '설정로드
        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        '프로그램 설정
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\app_settings.xml") = False Then '설정파일이 없으면
            APP_DefSUB()
            APP_XML_SAVE(My.Application.Info.DirectoryPath & "\app_settings.xml")
        Else
            APP_DefSUB()
            APP_XML_LOAD(My.Application.Info.DirectoryPath & "\app_settings.xml")
            If APP_OpenErrV = False Then APP_XML_SAVE(My.Application.Info.DirectoryPath & "\app_settings.xml") '오류가 없다면 파일기록, 새롭게 추가된 부분 저장관련..
        End If
        '프로그램 설정파일 오류처리
        If APP_OpenErrV = True Then
            APP_DefSUB()
            APP_XML_SAVE(My.Application.Info.DirectoryPath & "\app_settings.xml")
            APP_OpenErrV = False
        End If
        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        '언어파일 불러옴
        LangToolStripMenuItem.DropDownItems.Add("Auto-select", Nothing, AddressOf OutSelectLang)
        For Each IOGF As IO.FileInfo In New IO.DirectoryInfo(My.Application.Info.DirectoryPath & "\lang").GetFiles("*.xml")
            LangToolStripMenuItem.DropDownItems.Add(IOGF.Name, Nothing, AddressOf OutSelectLang)
        Next

        '언어설정로드
        Dim Cnt As Integer = 0
        For i2 = 0 To LangToolStripMenuItem.DropDownItems.Count - 1
            If LangToolStripMenuItem.DropDownItems(i2).Text = LangToolStripMenuItemV Then
                CType(LangToolStripMenuItem.DropDownItems(i2), ToolStripMenuItem).Checked = True
                Cnt = 1
            End If
        Next
        '선택된 아이템이 없으면 자동선택으로//
        If Cnt = 0 Then
            CType(LangToolStripMenuItem.DropDownItems(0), ToolStripMenuItem).Checked = True
        End If

        '언어파일 적용
        MAINLANGLOAD()

        '프리셋 불러옴
        RefPreset()

        '영상부분 초기화
        With EncSetFrm
            .ImageSizeComboBox.Items.Clear()
            .ImageSizeComboBox.Items.AddRange(New Object() {"160 x 120", "176 x 144 - QCIF", "240 x 180", "320 x 180", "320 x 240 - QVGA", "400 x 240 - WQVGA", "400 x 300", "480 x 272", "480 x 360", "640 x 360 - 16:9", "640 x 480", "800 x 600", "960 x 540", "1280 x 720 - HD 720", "1920 x 1080 - HD 1080"})
            .ImageSizeComboBox.Items.Add(LangCls.EncSetUserInputComboBox)

            .FFmpegResizeFilterComboBox.Items.Clear()
            .FFmpegResizeFilterComboBox.Items.Add("Fast_Bilinear")
            .FFmpegResizeFilterComboBox.Items.Add("Bilinear")
            .FFmpegResizeFilterComboBox.Items.Add("Bicubic")
            .FFmpegResizeFilterComboBox.Items.Add("Experimental")
            .FFmpegResizeFilterComboBox.Items.Add("Neighbor")
            .FFmpegResizeFilterComboBox.Items.Add("Area")
            .FFmpegResizeFilterComboBox.Items.Add("Bicublin")
            .FFmpegResizeFilterComboBox.Items.Add("Gauss")
            .FFmpegResizeFilterComboBox.Items.Add("Sinc")
            .FFmpegResizeFilterComboBox.Items.Add("Lanczos")
            .FFmpegResizeFilterComboBox.Items.Add("Spline")

            .AspectComboBox.Items.Clear()
            .AspectComboBox.Items.Add(LangCls.EncSetNoKeepAspectComboBox)
            .AspectComboBox.Items.Add(LangCls.EncSetLetterBoxAspectComboBox)
            .AspectComboBox.Items.Add(LangCls.EncSetCropAspectComboBox)

            .AspectComboBox2.Items.Clear()
            .AspectComboBox2.Items.Add(LangCls.EncSetOutputAspectComboBox2)
            .AspectComboBox2.Items.Add(LangCls.EncSetOriginalAspectComboBox2)
            .AspectComboBox2.Items.Add(LangCls.EncSet43AspectComboBox2)
            .AspectComboBox2.Items.Add(LangCls.EncSet169AspectComboBox2)
            .AspectComboBox2.Items.Add(LangCls.EncSet1851AspectComboBox2)
            .AspectComboBox2.Items.Add(LangCls.EncSet2351AspectComboBox2)
            .AspectComboBox2.Items.Add(LangCls.EncSetUserInputComboBox)
        End With

        '음성부분 초기화
        With EncSetFrm
            .FFmpegChComboBox.Items.Clear()
            .FFmpegChComboBox.Items.Add(LangCls.EncSetchoriginComboBox)
            .FFmpegChComboBox.Items.Add(LangCls.EncSetch10ComboBox)
            .FFmpegChComboBox.Items.Add(LangCls.EncSetch20ComboBox)
            .FFmpegChComboBox.Items.Add(LangCls.EncSetch51ComboBox)
        End With

        '영상부분 초기화
        With ImagePPFrm
            .AviSynthImageSizeComboBox.Items.Clear()
            .AviSynthImageSizeComboBox.Items.AddRange(New Object() {"160 x 120", "176 x 144 - QCIF", "240 x 180", "320 x 180", "320 x 240 - QVGA", "400 x 240 - WQVGA", "400 x 300", "480 x 272", "480 x 360", "640 x 360 - 16:9", "640 x 480", "800 x 600", "960 x 540", "1280 x 720 - HD 720", "1920 x 1080 - HD 1080"})
            .AviSynthImageSizeComboBox.Items.Add(LangCls.ImagePPUserInputComboBox)

            .AviSynthResizeFilterComboBox.Items.Clear()
            .AviSynthResizeFilterComboBox.Items.Add("Bicubic " & LangCls.ImagePPBlurStr)
            .AviSynthResizeFilterComboBox.Items.Add("Bicubic " & LangCls.ImagePPSharpStr)
            .AviSynthResizeFilterComboBox.Items.Add("Bicubic " & LangCls.ImagePPMiddleStr)
            .AviSynthResizeFilterComboBox.Items.Add("Bilinear " & LangCls.ImagePPBlurStr)
            .AviSynthResizeFilterComboBox.Items.Add("Blackman " & LangCls.ImagePPSharpStr)
            .AviSynthResizeFilterComboBox.Items.Add("Gauss " & LangCls.ImagePPMiddleStr)
            .AviSynthResizeFilterComboBox.Items.Add("Lanczos " & LangCls.ImagePPSharpStr)
            .AviSynthResizeFilterComboBox.Items.Add("Lanczos4 " & LangCls.ImagePPSharpStr)
            .AviSynthResizeFilterComboBox.Items.Add("Point " & LangCls.ImagePPSharpStr)
            .AviSynthResizeFilterComboBox.Items.Add("Spline16 " & LangCls.ImagePPMiddleStr)
            .AviSynthResizeFilterComboBox.Items.Add("Spline36 " & LangCls.ImagePPMiddleStr)
            .AviSynthResizeFilterComboBox.Items.Add("Spline64 " & LangCls.ImagePPMiddleStr)

            .AviSynthAspectComboBox.Items.Clear()
            .AviSynthAspectComboBox.Items.Add(LangCls.ImagePPNoKeepAviSynthAspectComboBox)
            .AviSynthAspectComboBox.Items.Add(LangCls.ImagePPLetterBoxAviSynthAspectComboBox)
            .AviSynthAspectComboBox.Items.Add(LangCls.ImagePPCropAviSynthAspectComboBox)

            .AviSynthAspectComboBox2.Items.Clear()
            .AviSynthAspectComboBox2.Items.Add(LangCls.ImagePPOutputAviSynthAspectComboBox2)
            .AviSynthAspectComboBox2.Items.Add(LangCls.ImagePPOriginalAviSynthAspectComboBox2)
            .AviSynthAspectComboBox2.Items.Add(LangCls.ImagePP43AviSynthAspectComboBox2)
            .AviSynthAspectComboBox2.Items.Add(LangCls.ImagePP169AviSynthAspectComboBox2)
            .AviSynthAspectComboBox2.Items.Add(LangCls.ImagePP1851AviSynthAspectComboBox2)
            .AviSynthAspectComboBox2.Items.Add(LangCls.ImagePP2351AviSynthAspectComboBox2)
            .AviSynthAspectComboBox2.Items.Add(LangCls.ImagePPUserInputComboBox)
        End With

        '음성부분 초기화
        With AudioPPFrm
            .AviSynthChComboBox.Items.Clear()
            .AviSynthChComboBox.Items.Add(LangCls.AudioPPchoriginComboBox)
            .AviSynthChComboBox.Items.Add(LangCls.AudioPPch10ComboBox)
            .AviSynthChComboBox.Items.Add(LangCls.AudioPPch20ComboBox)
            .AviSynthChComboBox.Items.Add(LangCls.AudioPPch51ComboBox)
            .AviSynthChComboBox.Items.Add(LangCls.AudioPPdolbysComboBox)
            .AviSynthChComboBox.Items.Add(LangCls.AudioPPdolbypComboBox)
        End With

        'Def_FFmpegSourceTextBox 초기화 32 / 64
        If Environ("PROCESSOR_ARCHITECTURE") = "AMD64" Then
            AviSynthEditorFrm.Def_FFmpegSourceTextBox.Text = "LoadCPlugin(" & Chr(34) & "#<toolspath>ffms\ffms2.dll" & Chr(34) & ")" & vbNewLine & AviSynthEditorFrm.Def_FFmpegSourceTextBox.Text
            AviSynthEditorFrm.Def_AVCTextBox.Text = "LoadCPlugin(" & Chr(34) & "#<toolspath>ffms\ffms2.dll" & Chr(34) & ")" & vbNewLine & AviSynthEditorFrm.Def_AVCTextBox.Text
            AviSynthEditorFrm.Def_VC1TextBox.Text = "LoadCPlugin(" & Chr(34) & "#<toolspath>ffms\ffms2.dll" & Chr(34) & ")" & vbNewLine & AviSynthEditorFrm.Def_VC1TextBox.Text
        Else
            AviSynthEditorFrm.Def_FFmpegSourceTextBox.Text = "LoadPlugin(" & Chr(34) & "#<toolspath>ffms\ffms2.dll" & Chr(34) & ")" & vbNewLine & AviSynthEditorFrm.Def_FFmpegSourceTextBox.Text
            AviSynthEditorFrm.Def_AVCTextBox.Text = "LoadPlugin(" & Chr(34) & "#<toolspath>ffms\ffms2.dll" & Chr(34) & ")" & vbNewLine & AviSynthEditorFrm.Def_AVCTextBox.Text
            AviSynthEditorFrm.Def_VC1TextBox.Text = "LoadPlugin(" & Chr(34) & "#<toolspath>ffms\ffms2.dll" & Chr(34) & ")" & vbNewLine & AviSynthEditorFrm.Def_VC1TextBox.Text
        End If

        '****************************************************************
        '설정
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\settings.xml") = False Then '설정파일이 없으면
            DefSUB()
            XML_SAVE(My.Application.Info.DirectoryPath & "\settings.xml")
        Else
            DefSUB()
            XML_LOAD(My.Application.Info.DirectoryPath & "\settings.xml")
            If OpenErrV = False Then XML_SAVE(My.Application.Info.DirectoryPath & "\settings.xml") '오류가 없다면 파일기록, 새롭게 추가된 부분 저장관련..
        End If
        '설정파일 오류처리
        If OpenErrV = True Then
            DefSUB()
            XML_SAVE(My.Application.Info.DirectoryPath & "\settings.xml")
            OpenErrV = False
        End If
        '****************************************************************
        'AviSynth 설정
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\avs_settings.xml") = False Then '설정파일이 없으면
            AVS_DefSUB()
            AVS_XML_SAVE(My.Application.Info.DirectoryPath & "\avs_settings.xml")
        Else
            AVS_DefSUB()
            AVS_XML_LOAD(My.Application.Info.DirectoryPath & "\avs_settings.xml")
            If AVS_OpenErrV = False Then AVS_XML_SAVE(My.Application.Info.DirectoryPath & "\avs_settings.xml") '오류가 없다면 파일기록, 새롭게 추가된 부분 저장관련..
        End If
        'AviSynth 설정파일 오류처리
        If AVS_OpenErrV = True Then
            AVS_DefSUB()
            AVS_XML_SAVE(My.Application.Info.DirectoryPath & "\avs_settings.xml")
            AVS_OpenErrV = False
        End If
        '****************************************************************

        '-----------------------------------------------------------------------
        ' 그 외 설정
        '-----------------------------------------------------------------------

        '활성화 지역
        EnableArea()

        '저장경로 비어있으면 바탕화면을 기본으로
        If SavePathTextBox.Text = "" Then
            SavePathTextBox.Text = My.Computer.FileSystem.SpecialDirectories.Desktop
        End If

        '프리셋 지정한파일 이름 비어있으면 기본으로
        If PresetLabel.Text = "" Then
            PresetLabel.Text = LangCls.MainUserStr
        End If

        '어플리케이션 설정
        If Environ("PROCESSOR_ARCHITECTURE") = "AMD64" Then
            Me.Text = "Kirara Encoder v" & _
            My.Application.Info.Version.Major & "." & _
            My.Application.Info.Version.Minor & "." & _
            My.Application.Info.Version.Revision & " x64"
        Else
            Me.Text = "Kirara Encoder v" & _
            My.Application.Info.Version.Major & "." & _
            My.Application.Info.Version.Minor & "." & _
            My.Application.Info.Version.Revision
        End If

        'MPLAYEREXESTR 설정
        If InStr(Environ("PROCESSOR_IDENTIFIER"), "intel", CompareMethod.Text) <> 0 Then
            MPLAYEREXESTR = "p4"
        ElseIf InStr(Environ("PROCESSOR_IDENTIFIER"), "amd", CompareMethod.Text) <> 0 Then
            MPLAYEREXESTR = "athlon-xp"
        Else
            MPLAYEREXESTR = "rtm"
        End If

        '관리자계정 여부
        If UAC.IsAdmin Then
            If Environment.OSVersion.Version.Major > 5 Then
                Me.Text = Me.Text & " (" & LangCls.MainUACV & ")"
            End If
        End If

        '----------------------------------------------------------------------------------------

        '저장된 폼의 위치와 크기를 적용한다
        If MainWidth <> "" AndAlso MainHeight <> "" Then
            Me.Size = New System.Drawing.Size(MainWidth, MainHeight)
        End If

        If MainX <> "" AndAlso MainY <> "" Then
            Me.Location = New System.Drawing.Point(MainX, MainY)
        End If

        If Me.Location.X < Screen.GetBounds(Me).Left Then
            Me.Location = New System.Drawing.Point(Screen.GetBounds(Me).Left, Me.Location.Y)
        End If

        If Me.Location.Y < Screen.GetBounds(Me).Top Then
            Me.Location = New System.Drawing.Point(Me.Location.X, Screen.GetBounds(Me).Top)
        End If

        If Me.Location.X > Screen.GetBounds(Me).Right - Me.Width Then
            Me.Location = New System.Drawing.Point(Screen.GetBounds(Me).Right - Me.Width, Me.Location.Y)
        End If

        If Me.Location.Y > Screen.GetBounds(Me).Bottom - Me.Height Then
            Me.Location = New System.Drawing.Point(Me.Location.X, Screen.GetBounds(Me).Bottom - Me.Height)
        End If

        '아래 코드부터 폼이 보여짐.
        If MainWindowState <> "" Then
            If MainWindowState = FormWindowState.Minimized Then
                Me.WindowState = FormWindowState.Normal
            Else
                Me.WindowState = MainWindowState
            End If
        End If

        '----------------------------------------------------------------------------------------
        Exit Sub
UAC:
        UAC.RestartElevated()
        Process.GetCurrentProcess.Kill()
    End Sub

    Private Sub OutSelectLang(ByVal sender As Object, ByVal e As EventArgs)

        Dim _MainUACVB As String = LangCls.MainUACV

        For i = 0 To LangToolStripMenuItem.DropDownItems.Count - 1
            If LangToolStripMenuItem.DropDownItems(i).Text = sender.ToString Then
                CType(LangToolStripMenuItem.DropDownItems(i), ToolStripMenuItem).Checked = True
            Else
                CType(LangToolStripMenuItem.DropDownItems(i), ToolStripMenuItem).Checked = False
            End If
        Next
        '언어파일 적용
        MAINLANGLOAD()

        '프리셋 부분 새로고침
        RefPreset()

        'SAVE용 - 언어설정 예외적용
        If EncListListView.SelectedItems.Count <> 0 Then
            Dim index As Integer = EncListListView.SelectedItems(index).Index
            GET_OutputINFO(index)  '출력정보
            GET_AVINFO(index) 'AV정보
        End If

        '관리자표시 변경된 언어로 바꿈.//
        Me.Text = Replace(Me.Text, _MainUACVB, LangCls.MainUACV)

    End Sub

    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click

        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = LangCls.MainSupportedFilesStr & "|*.3gp;*.asf;*.avi;*.flv;*.k3g;*.m2t;*.m2ts;*.mkv;*.mov;*.mpg;*.mpeg;*.mp4;*.mts;*.rm;*.skm;*.wmv;*.tp;*.ts;*.trp;*.m2ts;*.m2v;*.mpv;*.pva;*.rmvb;*.vob;*.vro;*.aac;*.ac3;*.dts;*.flac;*.m4a;*.mp2;*.mp3;*.mp4;*.ogg;*.ra;*.ram;*.wav;*.webm;*.wma;*.wv;|" & _
                                 LangCls.MainVideoFilesStr & "|*.3gp;*.asf;*.avi;*.flv;*.k3g;*.m2t;*.m2ts;*.mkv;*.mov;*.mpg;*.mpeg;*.mp4;*.mts;*.rm;*.skm;*.wmv;*.tp;*.ts;*.trp;*.m2ts;*.m2v;*.mpv;*.pva;*.rmvb;*.vob;*.vro;*.webm;|" & _
                                 LangCls.MainAudioFilesStr & "|*.aac;*.ac3;*.dts;*.flac;*.m4a;*.mp2;*.mp3;*.mp4;*.ogg;*.ra;*.ram;*.wav;*.wma;*.wv;|" & _
                                 LangCls.MainAllFilesStr & "(*.*)|*.*"
        OpenFileDialog1.ShowDialog(Me)

        '열었을 때 파일이름이 비어있으면 종료
        If OpenFileDialog1.FileName = "" Then
            Exit Sub
        End If

        FLoadFrmFileName = OpenFileDialog1.FileNames
        FLoadFrm.FileCheckB = False
        Try
            FLoadFrm.ShowDialog(Me)
        Catch ex As Exception
        End Try

        '목록에 아이템이 있지만 선택된 아이템이없으면 첫번째아이템 선택//
        If EncListListView.Items.Count > 0 Then
            If EncListListView.SelectedItems.Count = 0 Then
                EncListListView.Items(0).Selected = True
            End If
        End If
    End Sub

    Private Sub RemoveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveButton.Click

        '포커스 이동
        EncListListView.Focus()

        For Each LVI As ListViewItem In EncListListView.SelectedItems
            If EncodingFrm.EncProcBool = False OrElse LVI.Index > EncodingFrm.EncindexI Then '인코딩 중 제거방지
                LVI.Remove()
            End If
        Next
        EnableArea()

    End Sub

    Private Sub AllRemoveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllRemoveButton.Click
        EncListListView.Items.Clear()
        EnableArea()
    End Sub

    Private Sub EncListListView_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles EncListListView.DragDrop

        FLoadFrmFileName = DirectCast(e.Data.GetData(DataFormats.FileDrop), String())
        FLoadFrm.FileCheckB = True
        Try
            FLoadFrm.ShowDialog(Me)
        Catch ex As Exception
        End Try

        '목록에 아이템이 있지만 선택된 아이템이없으면 첫번째아이템 선택//
        If EncListListView.Items.Count > 0 Then
            If EncListListView.SelectedItems.Count = 0 Then
                EncListListView.Items(0).Selected = True
            End If
        End If

    End Sub

    Private Sub EncListListView_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles EncListListView.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub EncListListView_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles EncListListView.ItemCheck
        If EncListListViewChkB = True Then
            If e.NewValue <> e.CurrentValue Then
                e.NewValue = e.CurrentValue
            Else
                e.NewValue = e.NewValue
            End If
        End If
    End Sub


    Private Sub ErrToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ErrToolStripMenuItem.Click

        '선택된 아이템이 없으면 종료
        If EncListListView.SelectedItems.Count = 0 Then
            MsgBox(LangCls.MainSelectListA)
            Exit Sub
        End If

        If LogFrm.Visible = True Then
            LogFrm.GET_TXT()
        Else
            LogFrm.Show(Me)
        End If

    End Sub

    Private Sub EncListListView_ItemSelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles EncListListView.ItemSelectionChanged

        '인덱스
        If EncListListView.SelectedItems.Count = 0 Then
            SelIndex = -1
        Else
            SelIndex = e.ItemIndex
        End If

        Try
            If SelIndex <> -1 Then
                GET_AVINFO(e.ItemIndex) 'AV정보
                GET_OutputINFO(e.ItemIndex)  '출력정보
                EncListListView.Focus() '포커스
            End If
        Catch ex As Exception
            SelIndex = -1
        End Try

    End Sub

    Private Sub EncListListView_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles EncListListView.MouseDoubleClick
        '선택된 아이템이 없으면 종료
        If EncListListView.SelectedItems.Count = 0 Then
            Exit Sub
        End If
        '인코딩중이 아니면
        If EncodingFrm.EncProcBool = False Then
            Try
                StreamFrm.ShowDialog(Me)

                'SAVE용 - 구간 설정/스트림 선택/잘라내기 예외적용
                If EncListListView.SelectedItems.Count <> 0 Then
                    Dim index As Integer = EncListListView.SelectedItems(index).Index
                    GET_OutputINFO(index)  '출력정보
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub EncListListView_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles EncListListView.MouseDown
        EncListListViewChkB = True
    End Sub

    Private Sub TListButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TListButton.Click

        If EncListListView.SelectedIndices.Count = 0 Then Exit Sub '선택된 목록 제로 -> 중단
        Dim i(EncListListView.SelectedIndices.Count - 1) As Integer '선택된 목록 개수를 배열의 범위로
        Dim a As Integer = 0
        For Each LVI As ListViewItem In EncListListView.SelectedItems
            i(a) = LVI.Index
            a += 1
        Next
        For i2 = 0 To a - 1
            Dim SI As Integer = i(i2)
            Dim LVI As ListViewItem

            If EncodingFrm.EncProcBool = False OrElse (SI - 1) > EncodingFrm.EncindexI Then '인코딩 중 이동방지
                If SI <> 0 Then
                    If EncListListView.Items(SI - 1).Selected = False Then
                        LVI = EncListListView.Items(SI - 1)
                        EncListListView.Items(SI - 1) = EncListListView.Items(SI).Clone
                        '-------------
                        For i3 = 0 To LVI.SubItems.Count - 1
                            EncListListView.Items(SI).SubItems(i3).Text = LVI.SubItems(i3).Text
                        Next
                        EncListListView.Items(SI).Checked = LVI.Checked
                        EncListListView.Items(SI).Selected = False
                        '-------------
                        EncListListView.Items(SI - 1).Selected = True
                    End If
                End If
            End If

        Next

    End Sub

    Private Sub BListButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BListButton.Click

        If EncListListView.SelectedIndices.Count = 0 Then Exit Sub '선택된 목록 제로 -> 중단
        Dim i(EncListListView.SelectedIndices.Count - 1) As Integer '선택된 목록 개수를 배열의 범위로
        Dim a As Integer = 0
        For Each LVI As ListViewItem In EncListListView.SelectedItems
            i(a) = LVI.Index
            a += 1
        Next
        For i2 = a - 1 To 0 Step -1
            Dim SI As Integer = i(i2)
            Dim LVI As ListViewItem

            If EncodingFrm.EncProcBool = False OrElse SI > EncodingFrm.EncindexI Then '인코딩 중 이동방지
                If SI <> EncListListView.Items.Count - 1 Then
                    If EncListListView.Items(SI + 1).Selected = False Then
                        LVI = EncListListView.Items(SI + 1)
                        EncListListView.Items(SI + 1) = EncListListView.Items(SI).Clone
                        '-------------
                        For i3 = 0 To LVI.SubItems.Count - 1
                            EncListListView.Items(SI).SubItems(i3).Text = LVI.SubItems(i3).Text
                        Next
                        EncListListView.Items(SI).Checked = LVI.Checked
                        EncListListView.Items(SI).Selected = False
                        '-------------
                        EncListListView.Items(SI + 1).Selected = True
                    End If
                End If
            End If

        Next

    End Sub

    Private Sub TTListButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TTListButton.Click

        If EncListListView.SelectedIndices.Count = 0 Then Exit Sub '선택된 목록 제로 -> 중단
        Dim i(EncListListView.SelectedIndices.Count - 1) As Integer '선택된 목록 개수를 배열의 범위로
        Dim a As Integer = 0
        For Each LVI As ListViewItem In EncListListView.SelectedItems
            i(a) = LVI.Index
            a += 1
        Next
        Dim Cnt As Integer
        If EncodingFrm.EncProcBool = True Then
            Cnt = 2 + EncodingFrm.EncindexI
        Else
            Cnt = 1
        End If
        For i2 = 0 To a - 1

            If EncodingFrm.EncProcBool = False OrElse (i(i2) - 1) > EncodingFrm.EncindexI Then '인코딩 중 이동방지
                If Cnt <> 0 Then
                    If EncListListView.Items(Cnt - 1).Selected = False Then
                        EncListListView.Items.Insert(Cnt - 1, EncListListView.Items(i(i2)).Clone)
                        EncListListView.Items.RemoveAt(i(i2) + 1)
                        EncListListView.Items(i(i2)).Selected = False
                        EncListListView.Items(Cnt - 1).Selected = True
                    End If
                End If
                Cnt += 1
            End If

        Next

    End Sub

    Private Sub BBListButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BBListButton.Click

        If EncListListView.SelectedIndices.Count = 0 Then Exit Sub '선택된 목록 제로 -> 중단
        Dim i(EncListListView.SelectedIndices.Count - 1) As Integer '선택된 목록 개수를 배열의 범위로
        Dim a As Integer = 0
        For Each LVI As ListViewItem In EncListListView.SelectedItems
            i(a) = LVI.Index
            a += 1
        Next
        Dim Cnt As Integer = EncListListView.Items.Count - 2
        For i2 = a - 1 To 0 Step -1

            If EncodingFrm.EncProcBool = False OrElse i(i2) > EncodingFrm.EncindexI Then '인코딩 중 이동방지
                If Cnt <> EncListListView.Items.Count - 1 Then
                    If EncListListView.Items(Cnt + 1).Selected = False Then
                        EncListListView.Items.Insert(Cnt + 2, EncListListView.Items(i(i2)).Clone)
                        EncListListView.Items.RemoveAt(i(i2))
                        EncListListView.Items(Cnt + 1).Selected = True
                    End If
                End If
                Cnt -= 1
            End If

        Next

    End Sub

    Private Sub StreamSelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StreamSelButton.Click

        '선택된 아이템이 없으면 종료
        If EncListListView.SelectedItems.Count = 0 Then
            MsgBox(LangCls.MainSelectListA)
            Exit Sub
        End If

        Try
            StreamFrm.ShowDialog(Me)

            'SAVE용 - 구간 설정/스트림 선택/잘라내기 예외적용
            If EncListListView.SelectedItems.Count <> 0 Then
                Dim index As Integer = EncListListView.SelectedItems(index).Index
                GET_OutputINFO(index)  '출력정보
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub MainFrm_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        '핸들
        MainFrmHWNDV = Me.Handle.ToString

        '////////////////////////////
        'AviSynth 검사//
        If My.Computer.FileSystem.FileExists(Me.PubAVSPATHStr) = False Then
            Try
                AVSIFrm.ShowDialog(Me)
            Catch ex As Exception
            End Try
            Exit Sub
        End If
        '----------------------------------- P1
        Dim AVSFV As String = ""
        Try
            AVSFV = Diagnostics.FileVersionInfo.GetVersionInfo(Me.PubAVSPATHStr).FileVersion
            AVSFV = Replace(AVSFV, ",", ".")
            AVSFV = Replace(AVSFV, " ", "")
        Catch ex As Exception
            AVSFV = ""
        End Try
        If AVSFV = "" Then
            Try
                AVSIFrm.ShowDialog(Me)
            Catch ex As Exception
            End Try
            Exit Sub
        End If
        '----------------------------------- P2
        If AVSFV < "2.5.8.5" Then '버전 검사
            If AVSIFrm.OldVerCheckBox.Checked = False Then
                Try
                    AVSIFrm.ShowDialog(Me)
                Catch ex As Exception
                End Try
            End If
        End If
        '////////////////////////////

    End Sub

    Private Sub FileInfoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileInfoButton.Click

        '선택된 아이템이 없으면 종료
        If EncListListView.SelectedItems.Count = 0 Then
            MsgBox(LangCls.MainSelectListA)
            Exit Sub
        End If

        If My.Computer.FileSystem.FileExists(EncListListView.Items(SelIndex).SubItems(10).Text) = False Then
            MsgBox(LangCls.MainFileNotFound)
            Exit Sub
        End If

        If FileInfoFrm.Visible = True Then
            FileInfoFrm.GET_TXT(WinAPI.GetLongPathName(EncListListView.Items(SelIndex).SubItems(10).Text))
        Else
            FileInfoFrm.Show(Me)
            FileInfoFrm.GET_TXT(WinAPI.GetLongPathName(EncListListView.Items(SelIndex).SubItems(10).Text))
        End If

    End Sub

    Private Sub EncSetButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EncSetButton.Click

        Try
            EncSetFrm.ShowDialog(Me)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub EncSButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EncSButton.Click

        '포커스 이동
        EncListListView.Focus()

        '목록에 아이템이 없으면 추가 버튼을//
        If EncListListView.Items.Count = 0 Then
            AddButton_Click(Nothing, Nothing)
            Exit Sub
        End If

        'neroAacEnc.exe 체크 (Nero AAC 코덱 선택했으면)
        If EncSetFrm.AudioCodecComboBox.Text = "[MP4] Nero AAC" OrElse EncSetFrm.AudioCodecComboBox.Text = "Nero AAC" Then 'NeroAAC
            If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\tools\neroaac\neroAacEnc.exe") = False Then
                Try
                    NeroAACNoticeFrm.ShowDialog(Me)
                Catch ex As Exception
                End Try
                Exit Sub
            End If
        End If

        '저장 폴더체크
        If My.Computer.FileSystem.DirectoryExists(SavePathTextBox.Text) = False Then
            MsgBox(LangCls.MainDirectoryNotFound)
            SetFolderButton_Click(Nothing, Nothing)
            Exit Sub
        End If

        '===============================

        Try
            EncodingFrm.Show(Me)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub AVS_DefSUB()

        '//////////////////////////////////////////////////////////// AviSynthEditorFrm
        With AviSynthEditorFrm
            .FFmpegSourceTextBox.Text = .Def_FFmpegSourceTextBox.Text
            .DirectShowSourceTextBox.Text = .Def_DirectShowSourceTextBox.Text
            .MPEG2SourceTextBox.Text = .Def_MPEG2SourceTextBox.Text
            .BassAudioTextBox.Text = .Def_BassAudioTextBox.Text
            .NicAudioTextBox.Text = .Def_NicAudioTextBox.Text
            .ChannelTextBox.Text = .Def_ChannelTextBox.Text
            .AVCTextBox.Text = .Def_AVCTextBox.Text
            .VC1TextBox.Text = .Def_VC1TextBox.Text
        End With

    End Sub

    Private Sub APP_DefSUB()

        VolTrackBarStreamFrmV = 100
        AllChToolStripMenuItemStreamFrmV = True
        LeftChToolStripMenuItemStreamFrmV = False
        RightChToolStripMenuItemStreamFrmV = False
        rateMStreamFrmV = 1
        scaletempoToolStripMenuItemStreamFrmV = False
        extrastereoToolStripMenuItemStreamFrmV = False
        karaokeToolStripMenuItemStreamFrmV = False
        VisualizeMotionVectorsToolStripMenuItemStreamFrmV = False
        VisualizeBlockTypesToolStripMenuItemStreamFrmV = False
        FFmpegDeinterlacerToolStripMenuItemStreamFrmV = False
        AspectOriginToolStripMenuItemStreamFrmV = True
        SizeOriginToolStripMenuItemStreamFrmV = False

        SavePathTextBox.Text = ""
        PresetLabel.Text = ""
        MainWidth = ""
        MainHeight = ""
        MainX = ""
        MainY = ""
        MainWindowState = ""
        EncListListView.Columns(0).Width = 240

        OldVerCheckBoxAVSIFrmV = False

        PriorityComboBoxEncodingFrmV = 2

        LangToolStripMenuItemV = "Auto-select"

    End Sub

    Private Sub DefSUB()

        '//////////////////////////////////////////////////////////// EncSetFrm
        With EncSetFrm

            '설정 기본값
            .OutFComboBox.SelectedIndex = .OutFComboBox.FindString("[AVI]", -1)
            '비디오
            .VideoCodecComboBox.Text = "Xvid MPEG-4 Codec"
            .VideoModeComboBox.SelectedIndex = .VideoModeComboBox.FindString("[1PASS-CBR]", -1)
            .BitrateComboBox.Text = "700"
            .QuantizerNumericUpDown.Value = 2.5
            .QuantizerCQPNumericUpDown.Value = 26
            .QualityNumericUpDown.Value = 26.0
            .FramerateComboBox.Text = "23.976"
            .FramerateCheckBox.Checked = False
            .AdvanOptsCheckBox.Checked = False
            .GOPSizeCheckBox.Checked = False
            .GOPSizeTextBox.Text = "250"
            .MinGOPSizeTextBox.Text = "25"
            .PSPMP4CheckBox.Checked = False
            '영상
            .ImageSizeComboBox.Text = "480 x 272"
            .ImageSizeWidthTextBox.Text = "480"
            .ImageSizeHeightTextBox.Text = "272"
            .ImageSizeCheckBox.Checked = False
            .FFmpegResizeFilterComboBox.Text = "Bicubic"
            .AspectComboBox.Text = LangCls.EncSetLetterBoxAspectComboBox
            .AspectComboBox2.Text = LangCls.EncSetOutputAspectComboBox2
            .AspectWTextBox.Text = "0"
            .AspectHTextBox.Text = "0"
            '영상 처리
            .FFmpegImageUnsharpCheckBox.Checked = False
            .LumaMatrixHSNumericUpDown.Value = 5
            .LumaMatrixVSNumericUpDown.Value = 5
            .LumaEffectSNumericUpDown.Value = 1.0
            .ChromaMatrixHSNumericUpDown.Value = 5
            .ChromaMatrixVSNumericUpDown.Value = 5
            .ChromaEffectSNumericUpDown.Value = 1.0
            .hflipCheckBox.Checked = False
            .vflipCheckBox.Checked = False
            '오디오
            .AudioCodecComboBox.Text = "MPEG-1 Audio layer 3(MP3) Lame"
            .AudioBitrateComboBox.Text = "128"
            .FFmpegChComboBox.Text = LangCls.EncSetch20ComboBox
            .SamplerateComboBox.Text = "44100"
            .SamplerateCheckBox.Checked = False
            .AudioVolNumericUpDown.Value = 256
            .VorbisQNumericUpDown.Value = 10
            .AMRBitrateComboBox.Text = "12.2"
            .NeroAACProfileComboBox.Text = "AAC LC"
            .NeroAACBitrateNumericUpDown.Value = 128
            .NeroAACQNumericUpDown.Value = 0.5
            .NeroAACABRRadioButton.Checked = True
            .NeroAACCBRRadioButton.Checked = False
            .NeroAACVBRRadioButton.Checked = False
            '기타
            .HeaderTextBox.Text = "[KIRARA]"
            .ExtensionTextBox.Text = ""
            .SizeLimitTextBox.Text = "0"
            .SizeLimitCheckBox.Checked = False
            .DeinterlaceCheckBox.Checked = False
            .FFmpegCommandTextBox.Text = ""
            .SubtitleRecordingCheckBox.Checked = False
            .SizeEncCheckBox.Checked = False
            .SizeEncTextBox.Text = "0"
            '예외
            AVSCheckBox.Checked = True

        End With

        '//////////////////////////////////////////////////////////// x264optsFrm
        With x264optsFrm

            'Main
            .ThreadsNumericUpDown.Value = 0
            .ProfileComboBox.Text = "Baseline Profile"
            .LevelComboBox.Text = "Unrestricted AutoGuess"
            .FastfirstpassCheckBox.Checked = False
            'Frame-Type
            .DeblockingCheckBox.Checked = True
            .DeblockingAlphaNumericUpDown.Value = 0
            .DeblockingBetaNumericUpDown.Value = 0
            .CABACCheckBox.Checked = False
            .BFramesNumericUpDown.Value = 0
            .BFrameBiasNumericUpDown.Value = 0
            .AdaptiveBFramesComboBox.Text = "1 - Fast"
            .BFramePyramidCheckBox.Checked = False
            .BFrameWeightedPredictionCheckBox.Checked = False
            .ReferenceFramesNumericUpDown.Value = 1
            .ExtraIFramesNumericUpDown.Value = 40
            .PframeWeightedPredictionComboBox.Text = "Smart analysis"
            .AdaptiveIFramesDecisionCheckBox.Checked = True
            'Rate Control
            .QMinNumericUpDown.Value = 10
            .QMaxNumericUpDown.Value = 51
            .QDeltaNumericUpDown.Value = 4
            .QIPRatioNumericUpDown.Value = 1.4
            .QPBRatioNumericUpDown.Value = 1.3
            .ChromaandLumaQPOffsetNumericUpDown.Value = 0
            .VBVBufferSizeNumericUpDown.Value = 0
            .VBVMaximumBitrateNumericUpDown.Value = 0
            .VBVInitialBufferNumericUpDown.Value = 0.9
            .AverageBitrateVarianceNumericUpDown.Value = 1.0
            .QuantizerCompressionNumericUpDown.Value = 0.6
            .NumberofFramesforLookaheadNumericUpDown.Value = 40
            .UseMBTreeCheckBox.Checked = True
            .AdaptiveQuantizersModeComboBox.Text = "Variance AQ"
            .AdaptiveQuantizersStrengthNumericUpDown.Value = 1.0
            'Analysis
            .ChromaMECheckBox.Checked = True
            .MERangeNumericUpDown.Value = 16
            .MEMethodComboBox.Text = "Hexagon"
            .SubpixelMEComboBox.Text = "7 - RD on all frames"
            .MVPredictionModeComboBox.Text = "Spatial"
            .TrellisComboBox.Text = "0 - None"
            .PsyRDStrengthNumericUpDown.Value = 1.0
            .PsyTrellisStrengthNumericUpDown.Value = 0.0
            .NoMixedReferenceFramesCheckBox.Checked = False
            .NoFastPSkipCheckBox.Checked = False
            .NoPsychovisualEnhancementsCheckBox.Checked = False
            .MacroblocksComboBox.Text = "Default"
            .Adaptive8x8DCTCheckBox.Checked = False
            .I4x4CheckBox.Checked = True
            .P4x4CheckBox.Checked = False
            .I8x8CheckBox.Checked = False
            .P8x8CheckBox.Checked = True
            .B8x8CheckBox.Checked = True
            .NoiseReductionNumericUpDown.Value = 0
            .UseaccessunitdelimitersCheckBox.Checked = False

        End With

        '//////////////////////////////////////////////////////////// MPEG4optsFrm
        With MPEG4optsFrm

            'Main
            .ThreadsNumericUpDown.Value = 0
            .QuantizationTypeComboBox.Text = "H.263"
            .AdaptiveQuantizationCheckBox.Checked = False
            .InterlacedEncodingCheckBox.Checked = False
            .GrayscaleCheckBox.Checked = False
            .TopFieldFirstCheckBox.Checked = False
            ._4MotionVectorCheckBox.Checked = False
            .QPELCheckBox.Checked = False
            'B-VOPs
            .BFramesCheckBox.Checked = False
            .BVOPsNumericUpDown.Value = 1
            .ClosedGOPCheckBox.Checked = False
            .DownscalesffdBfdCheckBox.Checked = False
            .RefinettmvuibmCheckBox.Checked = False
            'Motion Estimation
            .DiamondtsfmeComboBox.Text = "ZERO"
            .HQModeComboBox.Text = "MBCMP"
            .FpmcfComboBox.Text = "SAD"
            .SpmcfComboBox.Text = "SAD"
            .McfComboBox.Text = "SAD"
            .IdcfComboBox.Text = "SAD"
            .PmecfComboBox.Text = "SAD"
            'Rate Control
            .QMinNumericUpDown.Value = 2
            .QMaxNumericUpDown.Value = 31
            .QDeltaNumericUpDown.Value = 3
            .QuantizerCompressionNumericUpDown.Value = 0.5
            .QuantizerBlurNumericUpDown.Value = 0.5
            .MaxVBTextBox.Text = "0"
            .MinVBTextBox.Text = "0"
            .RCBufferSizeTextBox.Text = "0"
            .TrellisQuantizationCheckBox.Checked = False
            .DCTalgorithmComboBox.Text = "AUTO"

        End With

        '//////////////////////////////////////////////////////////// SubtitleFrm
        With SubtitleFrm

            '자막
            .SubtitleCheckBox.Checked = True
            .EncComboBox.Text = "DEFAULT (1)"
            .FontComboBox.Text = "Tahoma"
            .SizeUpDown.Value = 22
            .ItalicCheckBox.Checked = False
            .BoldCheckBox.Checked = False
            .PrimaryColourTrackBar.Value = 0
            .OutlineColourTrackBar.Value = 0
            .BackColourTrackBar.Value = 128
            .OutlineUpDown.Value = 1.0
            .BackUpDown.Value = 2.0
            .BorderStyle1.Checked = True
            .BorderStyle3.Checked = False
            .Alignment5RadioButton.Checked = False
            .Alignment6RadioButton.Checked = False
            .Alignment4RadioButton.Checked = False
            .Alignment9RadioButton.Checked = False
            .Alignment7RadioButton.Checked = False
            .Alignment8RadioButton.Checked = False
            .Alignment1RadioButton.Checked = False
            .Alignment2RadioButton.Checked = True
            .Alignment3RadioButton.Checked = False
            .MarginLNumericUpDown.Value = 10
            .MarginRNumericUpDown.Value = 10
            .MarginVNumericUpDown.Value = 20
            .PrimaryColourPanel.BackColor = Color.FromArgb(-1)
            .OutlineColourPanel.BackColor = Color.FromArgb(-16777216)
            .BackColourPanel.BackColor = Color.FromArgb(-16777216)
            .SecondaryColourPanel.BackColor = Color.FromArgb(-256)
            .SecondaryColourTrackBar.Value = 0
            .StrikeOutCheckBox.Checked = False
            .UnderlineCheckBox.Checked = False
            .SpacingNumericUpDown.Value = 0.0
            .AngleNumericUpDown.Value = 0
            .ScaleXNumericUpDown.Value = 100.0
            .ScaleYNumericUpDown.Value = 100.0

        End With

        '//////////////////////////////////////////////////////////// AudioPPFrm
        With AudioPPFrm

            .AviSynthChComboBox.Text = LangCls.AudioPPch20ComboBox
            .AmplifyCheckBox.Checked = False
            .AmplifyNumericUpDown.Value = 0.0
            .EQCheckBox.Checked = False
            .EQ1TrackBar.Value = 0
            .EQ2TrackBar.Value = 0
            .EQ3TrackBar.Value = 0
            .EQ4TrackBar.Value = 0
            .EQ5TrackBar.Value = 0
            .EQ6TrackBar.Value = 0
            .EQ7TrackBar.Value = 0
            .EQ8TrackBar.Value = 0
            .EQ9TrackBar.Value = 0
            .EQ10TrackBar.Value = 0
            .EQ11TrackBar.Value = 0
            .EQ12TrackBar.Value = 0
            .EQ13TrackBar.Value = 0
            .EQ14TrackBar.Value = 0
            .EQ15TrackBar.Value = 0
            .EQ16TrackBar.Value = 0
            .EQ17TrackBar.Value = 0
            .EQ18TrackBar.Value = 0
            .NormalizeCheckBox.Checked = False
            .NormalizeTrackBar.Value = 100
            .NormalizeNumericUpDown.Value = 1.0
            .AudioASCheckBox.Checked = False

        End With

        '//////////////////////////////////////////////////////////// ImagePPFrm
        With ImagePPFrm

            .AviSynthFramerateComboBox.Text = "23.976"
            .AviSynthFramerateCheckBox.Checked = False
            .AviSynthImageSizeComboBox.Text = "480 x 272"
            .AviSynthImageSizeWidthTextBox.Text = "480"
            .AviSynthImageSizeHeightTextBox.Text = "272"
            .AviSynthImageSizeCheckBox.Checked = False
            .AviSynthResizeFilterComboBox.Text = "Bicubic " & LangCls.ImagePPMiddleStr
            .AviSynthAspectComboBox.Text = LangCls.EncSetLetterBoxAspectComboBox
            .AviSynthAspectComboBox2.Text = LangCls.EncSetOutputAspectComboBox2
            .AviSynthAspectWTextBox.Text = "0"
            .AviSynthAspectHTextBox.Text = "0"
            .AviSynthDeinterlaceCheckBox.Checked = False
            .AviSynthDeinterlaceComboBox.Text = "linear blend deinterlacer (lb)"
            .brightnessNumericUpDown.Value = 0
            .contrastNumericUpDown.Value = 1
            .saturationNumericUpDown.Value = 1
            .hueNumericUpDown.Value = 0
            .SharpenNumericUpDown.Value = 0
            .ColorYUVTVPCRadioButton.Checked = False
            .ColorYUVPCTVRadioButton.Checked = False
            .ColorYUVNRadioButton.Checked = True
            .ColorYUVASCheckBox.Checked = False
            .AVSMPEG2DeinterlaceCheckBox.Checked = False
            .AVSMPEG2DeinterlaceComboBox.Text = "Yadif mode=0"
            .FieldorderComboBox.Text = "Varying field order"
            .FFPP_hb_CheckBox.Checked = False
            .FFPP_vb_CheckBox.Checked = False
            .FFPP_ha_CheckBox.Checked = False
            .FFPP_va_CheckBox.Checked = False
            .FFPP_h1_CheckBox.Checked = False
            .FFPP_v1_CheckBox.Checked = False
            .FFPP_dr_CheckBox.Checked = False

        End With

    End Sub

    Public Sub APP_XML_LOAD(ByVal src As String)

        '접근권한이 있을 때 까지 반복
        If My.Computer.FileSystem.FileExists(src) = True Then
RELOAD:
            Try
                Dim _SRL As New StreamReader(src, System.Text.Encoding.UTF8)
                _SRL.Close()
            Catch ex As Exception
                GoTo RELOAD
            End Try
        End If

        Dim SR As New StreamReader(src, System.Text.Encoding.UTF8)
        Dim XTR As New System.Xml.XmlTextReader(SR)

        Try

            Do While XTR.Read
                Application.DoEvents()

                If XTR.Name = "VolTrackBarStreamFrmV" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then VolTrackBarStreamFrmV = XTRSTR Else VolTrackBarStreamFrmV = 100
                End If

                If XTR.Name = "AllChToolStripMenuItemStreamFrmV" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then AllChToolStripMenuItemStreamFrmV = XTRSTR Else AllChToolStripMenuItemStreamFrmV = True
                End If

                If XTR.Name = "LeftChToolStripMenuItemStreamFrmV" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then LeftChToolStripMenuItemStreamFrmV = XTRSTR Else LeftChToolStripMenuItemStreamFrmV = False
                End If

                If XTR.Name = "RightChToolStripMenuItemStreamFrmV" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then RightChToolStripMenuItemStreamFrmV = XTRSTR Else RightChToolStripMenuItemStreamFrmV = False
                End If

                If XTR.Name = "rateMStreamFrmV" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then rateMStreamFrmV = XTRSTR Else rateMStreamFrmV = 1
                End If

                If XTR.Name = "scaletempoToolStripMenuItemStreamFrmV" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then scaletempoToolStripMenuItemStreamFrmV = XTRSTR Else scaletempoToolStripMenuItemStreamFrmV = False
                End If

                If XTR.Name = "extrastereoToolStripMenuItemStreamFrmV" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then extrastereoToolStripMenuItemStreamFrmV = XTRSTR Else extrastereoToolStripMenuItemStreamFrmV = False
                End If

                If XTR.Name = "karaokeToolStripMenuItemStreamFrmV" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then karaokeToolStripMenuItemStreamFrmV = XTRSTR Else karaokeToolStripMenuItemStreamFrmV = False
                End If

                If XTR.Name = "VisualizeMotionVectorsToolStripMenuItemStreamFrmV" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then VisualizeMotionVectorsToolStripMenuItemStreamFrmV = XTRSTR Else VisualizeMotionVectorsToolStripMenuItemStreamFrmV = False
                End If

                If XTR.Name = "VisualizeBlockTypesToolStripMenuItemStreamFrmV" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then VisualizeBlockTypesToolStripMenuItemStreamFrmV = XTRSTR Else VisualizeBlockTypesToolStripMenuItemStreamFrmV = False
                End If

                If XTR.Name = "FFmpegDeinterlacerToolStripMenuItemStreamFrmV" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then FFmpegDeinterlacerToolStripMenuItemStreamFrmV = XTRSTR Else FFmpegDeinterlacerToolStripMenuItemStreamFrmV = False
                End If

                If XTR.Name = "AspectOriginToolStripMenuItemStreamFrmV" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then AspectOriginToolStripMenuItemStreamFrmV = XTRSTR Else AspectOriginToolStripMenuItemStreamFrmV = True
                End If

                If XTR.Name = "SizeOriginToolStripMenuItemStreamFrmV" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then SizeOriginToolStripMenuItemStreamFrmV = XTRSTR Else SizeOriginToolStripMenuItemStreamFrmV = False
                End If

                If XTR.Name = "SavePathTextBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then SavePathTextBox.Text = XTRSTR Else SavePathTextBox.Text = ""
                End If

                If XTR.Name = "PresetLabel" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then PresetLabel.Text = XTRSTR Else PresetLabel.Text = ""
                End If

                If XTR.Name = "MainWidth" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then MainWidth = XTRSTR Else MainWidth = ""
                End If

                If XTR.Name = "MainHeight" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then MainHeight = XTRSTR Else MainHeight = ""
                End If

                If XTR.Name = "MainX" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then MainX = XTRSTR Else MainX = ""
                End If

                If XTR.Name = "MainY" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then MainY = XTRSTR Else MainY = ""
                End If

                If XTR.Name = "MainWindowState" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then MainWindowState = XTRSTR Else MainWindowState = ""
                End If

                If XTR.Name = "EncListListView0" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then EncListListView.Columns(0).Width = XTRSTR Else EncListListView.Columns(0).Width = 240
                End If

                If XTR.Name = "OldVerCheckBoxAVSIFrmV" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then OldVerCheckBoxAVSIFrmV = XTRSTR Else OldVerCheckBoxAVSIFrmV = False
                End If

                If XTR.Name = "PriorityComboBoxEncodingFrmV" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then PriorityComboBoxEncodingFrmV = XTRSTR Else PriorityComboBoxEncodingFrmV = 2
                End If

                If XTR.Name = "LangToolStripMenuItemV" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then LangToolStripMenuItemV = XTRSTR Else LangToolStripMenuItemV = "Auto-select"
                End If

            Loop

        Catch ex As Exception
            MsgBox("XML_LOAD_ERROR :" & ex.Message)
            '오류가 있으면 오류변수 ON
            APP_OpenErrV = True
        Finally
            XTR.Close()
        End Try

    End Sub

    Public Sub AVS_XML_LOAD(ByVal src As String)

        '접근권한이 있을 때 까지 반복
        If My.Computer.FileSystem.FileExists(src) = True Then
RELOAD:
            Try
                Dim _SRL As New StreamReader(src, System.Text.Encoding.UTF8)
                _SRL.Close()
            Catch ex As Exception
                GoTo RELOAD
            End Try
        End If

        Dim SR As New StreamReader(src, System.Text.Encoding.UTF8)
        Dim XTR As New System.Xml.XmlTextReader(SR)

        Try

            Do While XTR.Read
                Application.DoEvents()

                '//////////////////////////////////////////////////////////// AviSynthEditorFrm
                With AviSynthEditorFrm

                    If XTR.Name = "AviSynthEditorFrm_FFmpegSourceTextBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .FFmpegSourceTextBox.Text = XTRSTR Else .FFmpegSourceTextBox.Text = .Def_FFmpegSourceTextBox.Text
                    End If

                    If XTR.Name = "AviSynthEditorFrm_ASFTextBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .DirectShowSourceTextBox.Text = XTRSTR Else .DirectShowSourceTextBox.Text = .Def_DirectShowSourceTextBox.Text
                    End If

                    If XTR.Name = "AviSynthEditorFrm_MPEG2SourceTextBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .MPEG2SourceTextBox.Text = XTRSTR Else .MPEG2SourceTextBox.Text = .Def_MPEG2SourceTextBox.Text
                    End If

                    If XTR.Name = "AviSynthEditorFrm_BassAudioTextBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .BassAudioTextBox.Text = XTRSTR Else .BassAudioTextBox.Text = .Def_BassAudioTextBox.Text
                    End If

                    If XTR.Name = "AviSynthEditorFrm_NicAudioTextBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .NicAudioTextBox.Text = XTRSTR Else .NicAudioTextBox.Text = .Def_NicAudioTextBox.Text
                    End If

                    If XTR.Name = "AviSynthEditorFrm_ChannelTextBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .ChannelTextBox.Text = XTRSTR Else .ChannelTextBox.Text = .Def_ChannelTextBox.Text
                    End If

                    If XTR.Name = "AviSynthEditorFrm_AVCTextBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .AVCTextBox.Text = XTRSTR Else .AVCTextBox.Text = .Def_AVCTextBox.Text
                    End If

                    If XTR.Name = "AviSynthEditorFrm_VC1TextBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .VC1TextBox.Text = XTRSTR Else .VC1TextBox.Text = .Def_VC1TextBox.Text
                    End If

                End With

            Loop

        Catch ex As Exception
            MsgBox("XML_LOAD_ERROR :" & ex.Message)
            '오류가 있으면 오류변수 ON
            AVS_OpenErrV = True
        Finally
            XTR.Close()
        End Try

    End Sub

    Public Sub XML_LOAD(ByVal src As String)

        '접근권한이 있을 때 까지 반복
        If My.Computer.FileSystem.FileExists(src) = True Then
RELOAD:
            Try
                Dim _SRL As New StreamReader(src, System.Text.Encoding.UTF8)
                _SRL.Close()
            Catch ex As Exception
                GoTo RELOAD
            End Try
        End If

        Dim SR As New StreamReader(src, System.Text.Encoding.UTF8)
        Dim XTR As New System.Xml.XmlTextReader(SR)

        Try

            Do While XTR.Read
                Application.DoEvents()

                '//////////////////////////////////////////////////////////// EncSetFrm
                With EncSetFrm

                    '설정 기본값
                    If XTR.Name = "EncSetFrm_OutFComboBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .OutFComboBox.SelectedIndex = .OutFComboBox.FindString(XTRSTR, -1) Else .OutFComboBox.SelectedIndex = .OutFComboBox.FindString("[AVI]", -1)
                    End If

                    '비디오
                    If XTR.Name = "EncSetFrm_VideoCodecComboBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .VideoCodecComboBox.Text = XTRSTR Else .VideoCodecComboBox.Text = "Xvid MPEG-4 Codec"
                    End If

                    If XTR.Name = "EncSetFrm_VideoModeComboBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .VideoModeComboBox.SelectedIndex = .VideoModeComboBox.FindString(XTRSTR, -1) Else .VideoModeComboBox.SelectedIndex = .VideoModeComboBox.FindString("[1PASS-CBR]", -1)
                    End If

                    If XTR.Name = "EncSetFrm_BitrateComboBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .BitrateComboBox.Text = XTRSTR Else .BitrateComboBox.Text = "700"
                    End If

                    If XTR.Name = "EncSetFrm_QuantizerNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .QuantizerNumericUpDown.Value = XTRSTR Else .QuantizerNumericUpDown.Value = 2.5
                    End If

                    If XTR.Name = "EncSetFrm_QuantizerCQPNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .QuantizerCQPNumericUpDown.Value = XTRSTR Else .QuantizerCQPNumericUpDown.Value = 26
                    End If

                    If XTR.Name = "EncSetFrm_QualityNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .QualityNumericUpDown.Value = XTRSTR Else .QualityNumericUpDown.Value = 26.0
                    End If

                    If XTR.Name = "EncSetFrm_FramerateComboBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .FramerateComboBox.Text = XTRSTR Else .FramerateComboBox.Text = "23.976"
                    End If

                    If XTR.Name = "EncSetFrm_FramerateCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .FramerateCheckBox.Checked = XTRSTR Else .FramerateCheckBox.Checked = False
                    End If

                    If XTR.Name = "EncSetFrm_AdvanOptsCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .AdvanOptsCheckBox.Checked = XTRSTR Else .AdvanOptsCheckBox.Checked = False
                    End If

                    If XTR.Name = "EncSetFrm_GOPSizeCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .GOPSizeCheckBox.Checked = XTRSTR Else .GOPSizeCheckBox.Checked = False
                    End If

                    If XTR.Name = "EncSetFrm_GOPSizeTextBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .GOPSizeTextBox.Text = XTRSTR Else .GOPSizeTextBox.Text = "250"
                    End If

                    If XTR.Name = "EncSetFrm_MinGOPSizeTextBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .MinGOPSizeTextBox.Text = XTRSTR Else .MinGOPSizeTextBox.Text = "25"
                    End If

                    If XTR.Name = "EncSetFrm_PSPMP4CheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .PSPMP4CheckBox.Checked = XTRSTR Else .PSPMP4CheckBox.Checked = False
                    End If

                    '영상
                    'ImageSizeComboBox
                    If XTR.Name = "EncSetFrm_ImageSizeComboBox" Then
                        Dim ImageSizeComboBoxV As String = ""
                        ImageSizeComboBoxV = XTR.ReadString
                        If ImageSizeComboBoxV = "LangCls.EncSetUserInputComboBox" Then
                            .ImageSizeComboBox.Text = LangCls.EncSetUserInputComboBox
                        Else
                            If ImageSizeComboBoxV <> "" Then
                                .ImageSizeComboBox.Text = ImageSizeComboBoxV
                            Else '기본값
                                .ImageSizeComboBox.Text = "480 x 272"
                            End If
                        End If
                    End If
                    'ImageSizeComboBox

                    If XTR.Name = "EncSetFrm_ImageSizeWidthTextBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .ImageSizeWidthTextBox.Text = XTRSTR Else .ImageSizeWidthTextBox.Text = "480"
                    End If

                    If XTR.Name = "EncSetFrm_ImageSizeHeightTextBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .ImageSizeHeightTextBox.Text = XTRSTR Else .ImageSizeHeightTextBox.Text = "272"
                    End If

                    If XTR.Name = "EncSetFrm_ImageSizeCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .ImageSizeCheckBox.Checked = XTRSTR Else .ImageSizeCheckBox.Checked = False
                    End If

                    If XTR.Name = "EncSetFrm_FFmpegResizeFilterComboBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .FFmpegResizeFilterComboBox.Text = XTRSTR Else .FFmpegResizeFilterComboBox.Text = "Bicubic"
                    End If

                    'AspectComboBox
                    If XTR.Name = "EncSetFrm_AspectComboBox" Then
                        Dim AspectComboBoxV As String = ""
                        AspectComboBoxV = XTR.ReadString
                        If AspectComboBoxV = "LangCls.EncSetNoKeepAspectComboBox" Then
                            .AspectComboBox.Text = LangCls.EncSetNoKeepAspectComboBox
                        ElseIf AspectComboBoxV = "LangCls.EncSetLetterBoxAspectComboBox" Then
                            .AspectComboBox.Text = LangCls.EncSetLetterBoxAspectComboBox
                        ElseIf AspectComboBoxV = "LangCls.EncSetCropAspectComboBox" Then
                            .AspectComboBox.Text = LangCls.EncSetCropAspectComboBox
                        Else '기본값
                            .AspectComboBox.Text = LangCls.EncSetLetterBoxAspectComboBox
                        End If
                    End If
                    'AspectComboBox

                    'AspectComboBox2
                    If XTR.Name = "EncSetFrm_AspectComboBox2" Then
                        Dim AspectComboBox2V As String = ""
                        AspectComboBox2V = XTR.ReadString
                        If AspectComboBox2V = "LangCls.EncSetOutputAspectComboBox2" Then
                            .AspectComboBox2.Text = LangCls.EncSetOutputAspectComboBox2
                        ElseIf AspectComboBox2V = "LangCls.EncSetOriginalAspectComboBox2" Then
                            .AspectComboBox2.Text = LangCls.EncSetOriginalAspectComboBox2
                        ElseIf AspectComboBox2V = "LangCls.EncSet43AspectComboBox2" Then
                            .AspectComboBox2.Text = LangCls.EncSet43AspectComboBox2
                        ElseIf AspectComboBox2V = "LangCls.EncSet169AspectComboBox2" Then
                            .AspectComboBox2.Text = LangCls.EncSet169AspectComboBox2
                        ElseIf AspectComboBox2V = "LangCls.EncSet1851AspectComboBox2" Then
                            .AspectComboBox2.Text = LangCls.EncSet1851AspectComboBox2
                        ElseIf AspectComboBox2V = "LangCls.EncSet2351AspectComboBox2" Then
                            .AspectComboBox2.Text = LangCls.EncSet2351AspectComboBox2
                        ElseIf AspectComboBox2V = "LangCls.EncSetUserInputComboBox" Then
                            .AspectComboBox2.Text = LangCls.EncSetUserInputComboBox
                        Else '기본값
                            .AspectComboBox2.Text = LangCls.EncSetOutputAspectComboBox2
                        End If
                    End If
                    'AspectComboBox2

                    If XTR.Name = "EncSetFrm_AspectWTextBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .AspectWTextBox.Text = XTRSTR Else .AspectWTextBox.Text = "0"
                    End If

                    If XTR.Name = "EncSetFrm_AspectHTextBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .AspectHTextBox.Text = XTRSTR Else .AspectHTextBox.Text = "0"
                    End If

                    '영상 처리
                    If XTR.Name = "EncSetFrm_FFmpegImageUnsharpCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .FFmpegImageUnsharpCheckBox.Checked = XTRSTR Else .FFmpegImageUnsharpCheckBox.Checked = False
                    End If

                    If XTR.Name = "EncSetFrm_LumaMatrixHSNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .LumaMatrixHSNumericUpDown.Value = XTRSTR Else .LumaMatrixHSNumericUpDown.Value = 5
                    End If

                    If XTR.Name = "EncSetFrm_LumaMatrixVSNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .LumaMatrixVSNumericUpDown.Value = XTRSTR Else .LumaMatrixVSNumericUpDown.Value = 5
                    End If

                    If XTR.Name = "EncSetFrm_LumaEffectSNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .LumaEffectSNumericUpDown.Value = XTRSTR Else .LumaEffectSNumericUpDown.Value = 1.0
                    End If

                    If XTR.Name = "EncSetFrm_ChromaMatrixHSNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .ChromaMatrixHSNumericUpDown.Value = XTRSTR Else .ChromaMatrixHSNumericUpDown.Value = 5
                    End If

                    If XTR.Name = "EncSetFrm_ChromaMatrixVSNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .ChromaMatrixVSNumericUpDown.Value = XTRSTR Else .ChromaMatrixVSNumericUpDown.Value = 5
                    End If

                    If XTR.Name = "EncSetFrm_ChromaEffectSNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .ChromaEffectSNumericUpDown.Value = XTRSTR Else .ChromaEffectSNumericUpDown.Value = 1.0
                    End If

                    If XTR.Name = "EncSetFrm_hflipCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .hflipCheckBox.Checked = XTRSTR Else .hflipCheckBox.Checked = False
                    End If

                    If XTR.Name = "EncSetFrm_vflipCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .vflipCheckBox.Checked = XTRSTR Else .vflipCheckBox.Checked = False
                    End If

                    '오디오
                    If XTR.Name = "EncSetFrm_AudioCodecComboBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .AudioCodecComboBox.Text = XTRSTR Else .AudioCodecComboBox.Text = "MPEG-1 Audio layer 3(MP3) Lame"
                    End If

                    If XTR.Name = "EncSetFrm_AudioBitrateComboBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .AudioBitrateComboBox.Text = XTRSTR Else .AudioBitrateComboBox.Text = "128"
                    End If

                    'FFmpegChComboBox
                    If XTR.Name = "EncSetFrm_FFmpegChComboBox" Then
                        Dim FFmpegChComboBoxV As String = ""
                        FFmpegChComboBoxV = XTR.ReadString
                        If FFmpegChComboBoxV = "LangCls.EncSetchoriginComboBox" Then
                            .FFmpegChComboBox.Text = LangCls.EncSetchoriginComboBox
                        ElseIf FFmpegChComboBoxV = "LangCls.EncSetch10ComboBox" Then
                            .FFmpegChComboBox.Text = LangCls.EncSetch10ComboBox
                        ElseIf FFmpegChComboBoxV = "LangCls.EncSetch20ComboBox" Then
                            .FFmpegChComboBox.Text = LangCls.EncSetch20ComboBox
                        ElseIf FFmpegChComboBoxV = "LangCls.EncSetch51ComboBox" Then
                            .FFmpegChComboBox.Text = LangCls.EncSetch51ComboBox
                        Else '기본값
                            .FFmpegChComboBox.Text = LangCls.EncSetch20ComboBox
                        End If
                    End If
                    'FFmpegChComboBox

                    If XTR.Name = "EncSetFrm_SamplerateComboBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .SamplerateComboBox.Text = XTRSTR Else .SamplerateComboBox.Text = "44100"
                    End If

                    If XTR.Name = "EncSetFrm_SamplerateCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .SamplerateCheckBox.Checked = XTRSTR Else .SamplerateCheckBox.Checked = False
                    End If

                    If XTR.Name = "EncSetFrm_AudioVolNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .AudioVolNumericUpDown.Value = XTRSTR Else .AudioVolNumericUpDown.Value = 256
                    End If

                    If XTR.Name = "EncSetFrm_VorbisQNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .VorbisQNumericUpDown.Value = XTRSTR Else .VorbisQNumericUpDown.Value = 10
                    End If

                    If XTR.Name = "EncSetFrm_AMRBitrateComboBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .AMRBitrateComboBox.Text = XTRSTR Else .AMRBitrateComboBox.Text = "12.2"
                    End If

                    If XTR.Name = "EncSetFrm_NeroAACProfileComboBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .NeroAACProfileComboBox.Text = XTRSTR Else .NeroAACProfileComboBox.Text = "AAC LC"
                    End If

                    If XTR.Name = "EncSetFrm_NeroAACBitrateNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .NeroAACBitrateNumericUpDown.Value = XTRSTR Else .NeroAACBitrateNumericUpDown.Value = 128
                    End If

                    If XTR.Name = "EncSetFrm_NeroAACQNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .NeroAACQNumericUpDown.Value = XTRSTR Else .NeroAACQNumericUpDown.Value = 0.5
                    End If

                    If XTR.Name = "EncSetFrm_NeroAACABRRadioButton" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .NeroAACABRRadioButton.Checked = XTRSTR Else .NeroAACABRRadioButton.Checked = True
                    End If

                    If XTR.Name = "EncSetFrm_NeroAACCBRRadioButton" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .NeroAACCBRRadioButton.Checked = XTRSTR Else .NeroAACCBRRadioButton.Checked = False
                    End If

                    If XTR.Name = "EncSetFrm_NeroAACVBRRadioButton" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .NeroAACVBRRadioButton.Checked = XTRSTR Else .NeroAACVBRRadioButton.Checked = False
                    End If

                    '기타
                    If XTR.Name = "EncSetFrm_HeaderTextBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> vbNullChar Then .HeaderTextBox.Text = XTRSTR Else .HeaderTextBox.Text = "" '[예외]
                    End If

                    If XTR.Name = "EncSetFrm_ExtensionTextBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> vbNullChar Then .ExtensionTextBox.Text = XTRSTR Else .ExtensionTextBox.Text = ""
                    End If

                    If XTR.Name = "EncSetFrm_SizeLimitTextBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .SizeLimitTextBox.Text = XTRSTR Else .SizeLimitTextBox.Text = "0"
                    End If

                    If XTR.Name = "EncSetFrm_SizeLimitCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .SizeLimitCheckBox.Checked = XTRSTR Else .SizeLimitCheckBox.Checked = False
                    End If

                    If XTR.Name = "EncSetFrm_DeinterlaceCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .DeinterlaceCheckBox.Checked = XTRSTR Else .DeinterlaceCheckBox.Checked = False
                    End If

                    If XTR.Name = "EncSetFrm_FFmpegCommandTextBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> vbNullChar Then .FFmpegCommandTextBox.Text = XTRSTR Else .FFmpegCommandTextBox.Text = ""
                    End If

                    If XTR.Name = "EncSetFrm_SubtitleRecordingCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .SubtitleRecordingCheckBox.Checked = XTRSTR Else .SubtitleRecordingCheckBox.Checked = False
                    End If

                    If XTR.Name = "EncSetFrm_SizeEncCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .SizeEncCheckBox.Checked = XTRSTR Else .SizeEncCheckBox.Checked = False
                    End If

                    If XTR.Name = "EncSetFrm_SizeEncTextBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .SizeEncTextBox.Text = XTRSTR Else .SizeEncTextBox.Text = "0"
                    End If

                End With

                '//////////////////////////////////////////////////////////// x264optsFrm
                With x264optsFrm

                    'Main
                    If XTR.Name = "x264optsFrm_ThreadsNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .ThreadsNumericUpDown.Value = XTRSTR Else .ThreadsNumericUpDown.Value = 0
                    End If

                    If XTR.Name = "x264optsFrm_ProfileComboBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .ProfileComboBox.Text = XTRSTR Else .ProfileComboBox.Text = "Baseline Profile"
                    End If

                    If XTR.Name = "x264optsFrm_LevelComboBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .LevelComboBox.Text = XTRSTR Else .LevelComboBox.Text = "Unrestricted AutoGuess"
                    End If

                    If XTR.Name = "x264optsFrm_FastfirstpassCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .FastfirstpassCheckBox.Checked = XTRSTR Else .FastfirstpassCheckBox.Checked = False
                    End If

                    'Frame-Type
                    If XTR.Name = "x264optsFrm_DeblockingCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .DeblockingCheckBox.Checked = XTRSTR Else .DeblockingCheckBox.Checked = True
                    End If

                    If XTR.Name = "x264optsFrm_DeblockingAlphaNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .DeblockingAlphaNumericUpDown.Value = XTRSTR Else .DeblockingAlphaNumericUpDown.Value = 0
                    End If

                    If XTR.Name = "x264optsFrm_DeblockingBetaNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .DeblockingBetaNumericUpDown.Value = XTRSTR Else .DeblockingBetaNumericUpDown.Value = 0
                    End If

                    If XTR.Name = "x264optsFrm_CABACCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .CABACCheckBox.Checked = XTRSTR Else .CABACCheckBox.Checked = False
                    End If

                    If XTR.Name = "x264optsFrm_BFramesNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .BFramesNumericUpDown.Value = XTRSTR Else .BFramesNumericUpDown.Value = 0
                    End If

                    If XTR.Name = "x264optsFrm_BFrameBiasNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .BFrameBiasNumericUpDown.Value = XTRSTR Else .BFrameBiasNumericUpDown.Value = 0
                    End If

                    If XTR.Name = "x264optsFrm_AdaptiveBFramesComboBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .AdaptiveBFramesComboBox.Text = XTRSTR Else .AdaptiveBFramesComboBox.Text = "1 - Fast"
                    End If

                    If XTR.Name = "x264optsFrm_BFramePyramidCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .BFramePyramidCheckBox.Checked = XTRSTR Else .BFramePyramidCheckBox.Checked = False
                    End If

                    If XTR.Name = "x264optsFrm_BFrameWeightedPredictionCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .BFrameWeightedPredictionCheckBox.Checked = XTRSTR Else .BFrameWeightedPredictionCheckBox.Checked = False
                    End If

                    If XTR.Name = "x264optsFrm_ReferenceFramesNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .ReferenceFramesNumericUpDown.Value = XTRSTR Else .ReferenceFramesNumericUpDown.Value = 1
                    End If

                    If XTR.Name = "x264optsFrm_ExtraIFramesNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .ExtraIFramesNumericUpDown.Value = XTRSTR Else .ExtraIFramesNumericUpDown.Value = 40
                    End If

                    If XTR.Name = "x264optsFrm_PframeWeightedPredictionComboBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .PframeWeightedPredictionComboBox.Text = XTRSTR Else .PframeWeightedPredictionComboBox.Text = "Smart analysis"
                    End If

                    If XTR.Name = "x264optsFrm_AdaptiveIFramesDecisionCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .AdaptiveIFramesDecisionCheckBox.Checked = XTRSTR Else .AdaptiveIFramesDecisionCheckBox.Checked = True
                    End If

                    'Rate Control
                    If XTR.Name = "x264optsFrm_QMinNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .QMinNumericUpDown.Value = XTRSTR Else .QMinNumericUpDown.Value = 10
                    End If

                    If XTR.Name = "x264optsFrm_QMaxNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .QMaxNumericUpDown.Value = XTRSTR Else .QMaxNumericUpDown.Value = 51
                    End If

                    If XTR.Name = "x264optsFrm_QDeltaNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .QDeltaNumericUpDown.Value = XTRSTR Else .QDeltaNumericUpDown.Value = 4
                    End If

                    If XTR.Name = "x264optsFrm_QIPRatioNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .QIPRatioNumericUpDown.Value = XTRSTR Else .QIPRatioNumericUpDown.Value = 1.4
                    End If

                    If XTR.Name = "x264optsFrm_QPBRatioNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .QPBRatioNumericUpDown.Value = XTRSTR Else .QPBRatioNumericUpDown.Value = 1.3
                    End If

                    If XTR.Name = "x264optsFrm_ChromaandLumaQPOffsetNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .ChromaandLumaQPOffsetNumericUpDown.Value = XTRSTR Else .ChromaandLumaQPOffsetNumericUpDown.Value = 0
                    End If

                    If XTR.Name = "x264optsFrm_VBVBufferSizeNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .VBVBufferSizeNumericUpDown.Value = XTRSTR Else .VBVBufferSizeNumericUpDown.Value = 0
                    End If

                    If XTR.Name = "x264optsFrm_VBVMaximumBitrateNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .VBVMaximumBitrateNumericUpDown.Value = XTRSTR Else .VBVMaximumBitrateNumericUpDown.Value = 0
                    End If

                    If XTR.Name = "x264optsFrm_VBVInitialBufferNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .VBVInitialBufferNumericUpDown.Value = XTRSTR Else .VBVInitialBufferNumericUpDown.Value = 0.9
                    End If

                    If XTR.Name = "x264optsFrm_AverageBitrateVarianceNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .AverageBitrateVarianceNumericUpDown.Value = XTRSTR Else .AverageBitrateVarianceNumericUpDown.Value = 1.0
                    End If

                    If XTR.Name = "x264optsFrm_QuantizerCompressionNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .QuantizerCompressionNumericUpDown.Value = XTRSTR Else .QuantizerCompressionNumericUpDown.Value = 0.6
                    End If

                    If XTR.Name = "x264optsFrm_NumberofFramesforLookaheadNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .NumberofFramesforLookaheadNumericUpDown.Value = XTRSTR Else .NumberofFramesforLookaheadNumericUpDown.Value = 40
                    End If

                    If XTR.Name = "x264optsFrm_UseMBTreeCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .UseMBTreeCheckBox.Checked = XTRSTR Else .UseMBTreeCheckBox.Checked = True
                    End If

                    If XTR.Name = "x264optsFrm_AdaptiveQuantizersModeComboBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .AdaptiveQuantizersModeComboBox.Text = XTRSTR Else .AdaptiveQuantizersModeComboBox.Text = "Variance AQ"
                    End If

                    If XTR.Name = "x264optsFrm_AdaptiveQuantizersStrengthNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .AdaptiveQuantizersStrengthNumericUpDown.Value = XTRSTR Else .AdaptiveQuantizersStrengthNumericUpDown.Value = 1.0
                    End If

                    'Analysis
                    If XTR.Name = "x264optsFrm_ChromaMECheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .ChromaMECheckBox.Checked = XTRSTR Else .ChromaMECheckBox.Checked = True
                    End If

                    If XTR.Name = "x264optsFrm_MERangeNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .MERangeNumericUpDown.Value = XTRSTR Else .MERangeNumericUpDown.Value = 16
                    End If

                    If XTR.Name = "x264optsFrm_MEMethodComboBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .MEMethodComboBox.Text = XTRSTR Else .MEMethodComboBox.Text = "Hexagon"
                    End If

                    If XTR.Name = "x264optsFrm_SubpixelMEComboBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .SubpixelMEComboBox.Text = XTRSTR Else .SubpixelMEComboBox.Text = "7 - RD on all frames"
                    End If

                    If XTR.Name = "x264optsFrm_MVPredictionModeComboBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .MVPredictionModeComboBox.Text = XTRSTR Else .MVPredictionModeComboBox.Text = "Spatial"
                    End If

                    If XTR.Name = "x264optsFrm_TrellisComboBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .TrellisComboBox.Text = XTRSTR Else .TrellisComboBox.Text = "0 - None"
                    End If

                    If XTR.Name = "x264optsFrm_PsyRDStrengthNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .PsyRDStrengthNumericUpDown.Value = XTRSTR Else .PsyRDStrengthNumericUpDown.Value = 1.0
                    End If

                    If XTR.Name = "x264optsFrm_PsyTrellisStrengthNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .PsyTrellisStrengthNumericUpDown.Value = XTRSTR Else .PsyTrellisStrengthNumericUpDown.Value = 0.0
                    End If

                    If XTR.Name = "x264optsFrm_NoMixedReferenceFramesCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .NoMixedReferenceFramesCheckBox.Checked = XTRSTR Else .NoMixedReferenceFramesCheckBox.Checked = False
                    End If

                    If XTR.Name = "x264optsFrm_NoFastPSkipCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .NoFastPSkipCheckBox.Checked = XTRSTR Else .NoFastPSkipCheckBox.Checked = False
                    End If

                    If XTR.Name = "x264optsFrm_NoPsychovisualEnhancementsCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .NoPsychovisualEnhancementsCheckBox.Checked = XTRSTR Else .NoPsychovisualEnhancementsCheckBox.Checked = False
                    End If

                    If XTR.Name = "x264optsFrm_MacroblocksComboBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .MacroblocksComboBox.Text = XTRSTR Else .MacroblocksComboBox.Text = "Default"
                    End If

                    If XTR.Name = "x264optsFrm_Adaptive8x8DCTCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .Adaptive8x8DCTCheckBox.Checked = XTRSTR Else .Adaptive8x8DCTCheckBox.Checked = False
                    End If

                    If XTR.Name = "x264optsFrm_I4x4CheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .I4x4CheckBox.Checked = XTRSTR Else .I4x4CheckBox.Checked = True
                    End If

                    If XTR.Name = "x264optsFrm_P4x4CheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .P4x4CheckBox.Checked = XTRSTR Else .P4x4CheckBox.Checked = False
                    End If

                    If XTR.Name = "x264optsFrm_I8x8CheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .I8x8CheckBox.Checked = XTRSTR Else .I8x8CheckBox.Checked = False
                    End If

                    If XTR.Name = "x264optsFrm_P8x8CheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .P8x8CheckBox.Checked = XTRSTR Else .P8x8CheckBox.Checked = True
                    End If

                    If XTR.Name = "x264optsFrm_B8x8CheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .B8x8CheckBox.Checked = XTRSTR Else .B8x8CheckBox.Checked = True
                    End If

                    If XTR.Name = "x264optsFrm_NoiseReductionNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .NoiseReductionNumericUpDown.Value = XTRSTR Else .NoiseReductionNumericUpDown.Value = 0
                    End If

                    If XTR.Name = "x264optsFrm_UseaccessunitdelimitersCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .UseaccessunitdelimitersCheckBox.Checked = XTRSTR Else .UseaccessunitdelimitersCheckBox.Checked = False
                    End If

                End With

                '//////////////////////////////////////////////////////////// MPEG4optsFrm
                With MPEG4optsFrm

                    'Main
                    If XTR.Name = "MPEG4optsFrm_ThreadsNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .ThreadsNumericUpDown.Value = XTRSTR Else .ThreadsNumericUpDown.Value = 0
                    End If

                    If XTR.Name = "MPEG4optsFrm_QuantizationTypeComboBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .QuantizationTypeComboBox.Text = XTRSTR Else .QuantizationTypeComboBox.Text = "H.263"
                    End If

                    If XTR.Name = "MPEG4optsFrm_AdaptiveQuantizationCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .AdaptiveQuantizationCheckBox.Checked = XTRSTR Else .AdaptiveQuantizationCheckBox.Checked = False
                    End If

                    If XTR.Name = "MPEG4optsFrm_InterlacedEncodingCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .InterlacedEncodingCheckBox.Checked = XTRSTR Else .InterlacedEncodingCheckBox.Checked = False
                    End If

                    If XTR.Name = "MPEG4optsFrm_GrayscaleCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .GrayscaleCheckBox.Checked = XTRSTR Else .GrayscaleCheckBox.Checked = False
                    End If

                    If XTR.Name = "MPEG4optsFrm_TopFieldFirstCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .TopFieldFirstCheckBox.Checked = XTRSTR Else .TopFieldFirstCheckBox.Checked = False
                    End If

                    If XTR.Name = "MPEG4optsFrm__4MotionVectorCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then ._4MotionVectorCheckBox.Checked = XTRSTR Else ._4MotionVectorCheckBox.Checked = False
                    End If

                    If XTR.Name = "MPEG4optsFrm_QPELCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .QPELCheckBox.Checked = XTRSTR Else .QPELCheckBox.Checked = False
                    End If

                    'B-VOPs
                    If XTR.Name = "MPEG4optsFrm_BFramesCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .BFramesCheckBox.Checked = XTRSTR Else .BFramesCheckBox.Checked = False
                    End If

                    If XTR.Name = "MPEG4optsFrm_BVOPsNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .BVOPsNumericUpDown.Value = XTRSTR Else .BVOPsNumericUpDown.Value = 1
                    End If

                    If XTR.Name = "MPEG4optsFrm_ClosedGOPCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .ClosedGOPCheckBox.Checked = XTRSTR Else .ClosedGOPCheckBox.Checked = False
                    End If

                    If XTR.Name = "MPEG4optsFrm_DownscalesffdBfdCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .DownscalesffdBfdCheckBox.Checked = XTRSTR Else .DownscalesffdBfdCheckBox.Checked = False
                    End If

                    If XTR.Name = "MPEG4optsFrm_RefinettmvuibmCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .RefinettmvuibmCheckBox.Checked = XTRSTR Else .RefinettmvuibmCheckBox.Checked = False
                    End If

                    'Motion Estimation
                    If XTR.Name = "MPEG4optsFrm_DiamondtsfmeComboBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .DiamondtsfmeComboBox.Text = XTRSTR Else .DiamondtsfmeComboBox.Text = "ZERO"
                    End If

                    If XTR.Name = "MPEG4optsFrm_HQModeComboBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .HQModeComboBox.Text = XTRSTR Else .HQModeComboBox.Text = "MBCMP"
                    End If

                    If XTR.Name = "MPEG4optsFrm_FpmcfComboBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .FpmcfComboBox.Text = XTRSTR Else .FpmcfComboBox.Text = "SAD"
                    End If

                    If XTR.Name = "MPEG4optsFrm_SpmcfComboBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .SpmcfComboBox.Text = XTRSTR Else .SpmcfComboBox.Text = "SAD"
                    End If

                    If XTR.Name = "MPEG4optsFrm_McfComboBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .McfComboBox.Text = XTRSTR Else .McfComboBox.Text = "SAD"
                    End If

                    If XTR.Name = "MPEG4optsFrm_IdcfComboBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .IdcfComboBox.Text = XTRSTR Else .IdcfComboBox.Text = "SAD"
                    End If

                    If XTR.Name = "MPEG4optsFrm_PmecfComboBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .PmecfComboBox.Text = XTRSTR Else .PmecfComboBox.Text = "SAD"
                    End If

                    'Rate Control
                    If XTR.Name = "MPEG4optsFrm_QMinNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .QMinNumericUpDown.Value = XTRSTR Else .QMinNumericUpDown.Value = 2
                    End If

                    If XTR.Name = "MPEG4optsFrm_QMaxNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .QMaxNumericUpDown.Value = XTRSTR Else .QMaxNumericUpDown.Value = 31
                    End If

                    If XTR.Name = "MPEG4optsFrm_QDeltaNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .QDeltaNumericUpDown.Value = XTRSTR Else .QDeltaNumericUpDown.Value = 3
                    End If

                    If XTR.Name = "MPEG4optsFrm_QuantizerCompressionNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .QuantizerCompressionNumericUpDown.Value = XTRSTR Else .QuantizerCompressionNumericUpDown.Value = 0.5
                    End If

                    If XTR.Name = "MPEG4optsFrm_QuantizerBlurNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .QuantizerBlurNumericUpDown.Value = XTRSTR Else .QuantizerBlurNumericUpDown.Value = 0.5
                    End If

                    If XTR.Name = "MPEG4optsFrm_MaxVBTextBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .MaxVBTextBox.Text = XTRSTR Else .MaxVBTextBox.Text = "0"
                    End If

                    If XTR.Name = "MPEG4optsFrm_MinVBTextBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .MinVBTextBox.Text = XTRSTR Else .MinVBTextBox.Text = "0"
                    End If

                    If XTR.Name = "MPEG4optsFrm_RCBufferSizeTextBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .RCBufferSizeTextBox.Text = XTRSTR Else .RCBufferSizeTextBox.Text = "0"
                    End If

                    If XTR.Name = "MPEG4optsFrm_TrellisQuantizationCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .TrellisQuantizationCheckBox.Checked = XTRSTR Else .TrellisQuantizationCheckBox.Checked = False
                    End If

                    If XTR.Name = "MPEG4optsFrm_DCTalgorithmComboBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .DCTalgorithmComboBox.Text = XTRSTR Else .DCTalgorithmComboBox.Text = "AUTO"
                    End If

                End With

                '//////////////////////////////////////////////////////////// SubtitleFrm
                With SubtitleFrm

                    If XTR.Name = "SubtitleFrm_SubtitleCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .SubtitleCheckBox.Checked = XTRSTR Else .SubtitleCheckBox.Checked = True
                    End If

                    If XTR.Name = "SubtitleFrm_EncComboBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .EncComboBox.Text = XTRSTR Else .EncComboBox.Text = "DEFAULT (1)"
                    End If

                    If XTR.Name = "SubtitleFrm_FontComboBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .FontComboBox.Text = XTRSTR Else .FontComboBox.Text = "Tahoma"
                    End If

                    If XTR.Name = "SubtitleFrm_SizeUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .SizeUpDown.Value = XTRSTR Else .SizeUpDown.Value = 22
                    End If

                    If XTR.Name = "SubtitleFrm_ItalicCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .ItalicCheckBox.Checked = XTRSTR Else .ItalicCheckBox.Checked = False
                    End If

                    If XTR.Name = "SubtitleFrm_BoldCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .BoldCheckBox.Checked = XTRSTR Else .BoldCheckBox.Checked = False
                    End If

                    If XTR.Name = "SubtitleFrm_PrimaryColourTrackBar" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .PrimaryColourTrackBar.Value = XTRSTR Else .PrimaryColourTrackBar.Value = 0
                    End If

                    If XTR.Name = "SubtitleFrm_OutlineColourTrackBar" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .OutlineColourTrackBar.Value = XTRSTR Else .OutlineColourTrackBar.Value = 0
                    End If

                    If XTR.Name = "SubtitleFrm_BackColourTrackBar" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .BackColourTrackBar.Value = XTRSTR Else .BackColourTrackBar.Value = 128
                    End If

                    If XTR.Name = "SubtitleFrm_OutlineUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .OutlineUpDown.Value = XTRSTR Else .OutlineUpDown.Value = 1.0
                    End If

                    If XTR.Name = "SubtitleFrm_ShadowUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .BackUpDown.Value = XTRSTR Else .BackUpDown.Value = 2.0
                    End If

                    If XTR.Name = "SubtitleFrm_BorderStyle1" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .BorderStyle1.Checked = XTRSTR Else .BorderStyle1.Checked = True
                    End If

                    If XTR.Name = "SubtitleFrm_BorderStyle3" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .BorderStyle3.Checked = XTRSTR Else .BorderStyle3.Checked = False
                    End If

                    If XTR.Name = "SubtitleFrm_Alignment5RadioButton" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .Alignment5RadioButton.Checked = XTRSTR Else .Alignment5RadioButton.Checked = False
                    End If

                    If XTR.Name = "SubtitleFrm_Alignment6RadioButton" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .Alignment6RadioButton.Checked = XTRSTR Else .Alignment6RadioButton.Checked = False
                    End If

                    If XTR.Name = "SubtitleFrm_Alignment4RadioButton" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .Alignment4RadioButton.Checked = XTRSTR Else .Alignment4RadioButton.Checked = False
                    End If

                    If XTR.Name = "SubtitleFrm_Alignment9RadioButton" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .Alignment9RadioButton.Checked = XTRSTR Else .Alignment9RadioButton.Checked = False
                    End If

                    If XTR.Name = "SubtitleFrm_Alignment7RadioButton" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .Alignment7RadioButton.Checked = XTRSTR Else .Alignment7RadioButton.Checked = False
                    End If

                    If XTR.Name = "SubtitleFrm_Alignment8RadioButton" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .Alignment8RadioButton.Checked = XTRSTR Else .Alignment8RadioButton.Checked = False
                    End If

                    If XTR.Name = "SubtitleFrm_Alignment1RadioButton" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .Alignment1RadioButton.Checked = XTRSTR Else .Alignment1RadioButton.Checked = False
                    End If

                    If XTR.Name = "SubtitleFrm_Alignment2RadioButton" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .Alignment2RadioButton.Checked = XTRSTR Else .Alignment2RadioButton.Checked = True
                    End If

                    If XTR.Name = "SubtitleFrm_Alignment3RadioButton" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .Alignment3RadioButton.Checked = XTRSTR Else .Alignment3RadioButton.Checked = False
                    End If

                    If XTR.Name = "SubtitleFrm_MarginLNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .MarginLNumericUpDown.Value = XTRSTR Else .MarginLNumericUpDown.Value = 10
                    End If

                    If XTR.Name = "SubtitleFrm_MarginRNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .MarginRNumericUpDown.Value = XTRSTR Else .MarginRNumericUpDown.Value = 10
                    End If

                    If XTR.Name = "SubtitleFrm_MarginVNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .MarginVNumericUpDown.Value = XTRSTR Else .MarginVNumericUpDown.Value = 20
                    End If

                    If XTR.Name = "SubtitleFrm_PrimaryColourPanel" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .PrimaryColourPanel.BackColor = Color.FromArgb(XTRSTR) Else .PrimaryColourPanel.BackColor = Color.FromArgb(-1)
                    End If

                    If XTR.Name = "SubtitleFrm_OutlineColourPanel" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .OutlineColourPanel.BackColor = Color.FromArgb(XTRSTR) Else .OutlineColourPanel.BackColor = Color.FromArgb(-16777216)
                    End If

                    If XTR.Name = "SubtitleFrm_BackColourPanel" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .BackColourPanel.BackColor = Color.FromArgb(XTRSTR) Else .BackColourPanel.BackColor = Color.FromArgb(-16777216)
                    End If

                    If XTR.Name = "SubtitleFrm_SecondaryColourPanel" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .SecondaryColourPanel.BackColor = Color.FromArgb(XTRSTR) Else .SecondaryColourPanel.BackColor = Color.FromArgb(-256)
                    End If

                    If XTR.Name = "SubtitleFrm_SecondaryColourTrackBar" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .SecondaryColourTrackBar.Value = XTRSTR Else .SecondaryColourTrackBar.Value = 0
                    End If

                    If XTR.Name = "SubtitleFrm_StrikeOutCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .StrikeOutCheckBox.Checked = XTRSTR Else .StrikeOutCheckBox.Checked = False
                    End If

                    If XTR.Name = "SubtitleFrm_UnderlineCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .UnderlineCheckBox.Checked = XTRSTR Else .UnderlineCheckBox.Checked = False
                    End If

                    If XTR.Name = "SubtitleFrm_SpacingNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .SpacingNumericUpDown.Value = XTRSTR Else .SpacingNumericUpDown.Value = 0.0
                    End If

                    If XTR.Name = "SubtitleFrm_AngleNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .AngleNumericUpDown.Value = XTRSTR Else .AngleNumericUpDown.Value = 0
                    End If

                    If XTR.Name = "SubtitleFrm_ScaleXNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .ScaleXNumericUpDown.Value = XTRSTR Else .ScaleXNumericUpDown.Value = 100.0
                    End If

                    If XTR.Name = "SubtitleFrm_ScaleYNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .ScaleYNumericUpDown.Value = XTRSTR Else .ScaleYNumericUpDown.Value = 100.0
                    End If

                End With

                '//////////////////////////////////////////////////////////// AudioPPFrm
                With AudioPPFrm

                    'AviSynthChComboBox
                    If XTR.Name = "AudioPPFrm_AviSynthChComboBox" Then
                        Dim AviSynthChComboBoxV As String = ""
                        AviSynthChComboBoxV = XTR.ReadString
                        If AviSynthChComboBoxV = "LangCls.AudioPPchoriginComboBox" Then
                            .AviSynthChComboBox.Text = LangCls.AudioPPchoriginComboBox
                        ElseIf AviSynthChComboBoxV = "LangCls.AudioPPch10ComboBox" Then
                            .AviSynthChComboBox.Text = LangCls.AudioPPch10ComboBox
                        ElseIf AviSynthChComboBoxV = "LangCls.AudioPPch20ComboBox" Then
                            .AviSynthChComboBox.Text = LangCls.AudioPPch20ComboBox
                        ElseIf AviSynthChComboBoxV = "LangCls.AudioPPch51ComboBox" Then
                            .AviSynthChComboBox.Text = LangCls.AudioPPch51ComboBox
                        ElseIf AviSynthChComboBoxV = "LangCls.AudioPPdolbysComboBox" Then
                            .AviSynthChComboBox.Text = LangCls.AudioPPdolbysComboBox
                        ElseIf AviSynthChComboBoxV = "LangCls.AudioPPdolbypComboBox" Then
                            .AviSynthChComboBox.Text = LangCls.AudioPPdolbypComboBox
                        Else '기본값
                            .AviSynthChComboBox.Text = LangCls.AudioPPch20ComboBox
                        End If
                    End If
                    'AviSynthChComboBox

                    If XTR.Name = "AudioPPFrm_AmplifyCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .AmplifyCheckBox.Checked = XTRSTR Else .AmplifyCheckBox.Checked = False
                    End If

                    If XTR.Name = "AudioPPFrm_AmplifyNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .AmplifyNumericUpDown.Value = XTRSTR Else .AmplifyNumericUpDown.Value = 0.0
                    End If

                    If XTR.Name = "AudioPPFrm_EQCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .EQCheckBox.Checked = XTRSTR Else .EQCheckBox.Checked = False
                    End If

                    If XTR.Name = "AudioPPFrm_EQ1TrackBar" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .EQ1TrackBar.Value = XTRSTR Else .EQ1TrackBar.Value = 0
                    End If

                    If XTR.Name = "AudioPPFrm_EQ2TrackBar" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .EQ2TrackBar.Value = XTRSTR Else .EQ2TrackBar.Value = 0
                    End If

                    If XTR.Name = "AudioPPFrm_EQ3TrackBar" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .EQ3TrackBar.Value = XTRSTR Else .EQ3TrackBar.Value = 0
                    End If

                    If XTR.Name = "AudioPPFrm_EQ4TrackBar" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .EQ4TrackBar.Value = XTRSTR Else .EQ4TrackBar.Value = 0
                    End If

                    If XTR.Name = "AudioPPFrm_EQ5TrackBar" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .EQ5TrackBar.Value = XTRSTR Else .EQ5TrackBar.Value = 0
                    End If

                    If XTR.Name = "AudioPPFrm_EQ6TrackBar" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .EQ6TrackBar.Value = XTRSTR Else .EQ6TrackBar.Value = 0
                    End If

                    If XTR.Name = "AudioPPFrm_EQ7TrackBar" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .EQ7TrackBar.Value = XTRSTR Else .EQ7TrackBar.Value = 0
                    End If

                    If XTR.Name = "AudioPPFrm_EQ8TrackBar" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .EQ8TrackBar.Value = XTRSTR Else .EQ8TrackBar.Value = 0
                    End If

                    If XTR.Name = "AudioPPFrm_EQ9TrackBar" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .EQ9TrackBar.Value = XTRSTR Else .EQ9TrackBar.Value = 0
                    End If

                    If XTR.Name = "AudioPPFrm_EQ10TrackBar" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .EQ10TrackBar.Value = XTRSTR Else .EQ10TrackBar.Value = 0
                    End If

                    If XTR.Name = "AudioPPFrm_EQ11TrackBar" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .EQ11TrackBar.Value = XTRSTR Else .EQ11TrackBar.Value = 0
                    End If

                    If XTR.Name = "AudioPPFrm_EQ12TrackBar" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .EQ12TrackBar.Value = XTRSTR Else .EQ12TrackBar.Value = 0
                    End If

                    If XTR.Name = "AudioPPFrm_EQ13TrackBar" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .EQ13TrackBar.Value = XTRSTR Else .EQ13TrackBar.Value = 0
                    End If

                    If XTR.Name = "AudioPPFrm_EQ14TrackBar" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .EQ14TrackBar.Value = XTRSTR Else .EQ14TrackBar.Value = 0
                    End If

                    If XTR.Name = "AudioPPFrm_EQ15TrackBar" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .EQ15TrackBar.Value = XTRSTR Else .EQ15TrackBar.Value = 0
                    End If

                    If XTR.Name = "AudioPPFrm_EQ16TrackBar" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .EQ16TrackBar.Value = XTRSTR Else .EQ16TrackBar.Value = 0
                    End If

                    If XTR.Name = "AudioPPFrm_EQ17TrackBar" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .EQ17TrackBar.Value = XTRSTR Else .EQ17TrackBar.Value = 0
                    End If

                    If XTR.Name = "AudioPPFrm_EQ18TrackBar" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .EQ18TrackBar.Value = XTRSTR Else .EQ18TrackBar.Value = 0
                    End If

                    If XTR.Name = "AudioPPFrm_NormalizeCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .NormalizeCheckBox.Checked = XTRSTR Else .NormalizeCheckBox.Checked = False
                    End If

                    If XTR.Name = "AudioPPFrm_NormalizeTrackBar" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .NormalizeTrackBar.Value = XTRSTR Else .NormalizeTrackBar.Value = 100
                    End If

                    If XTR.Name = "AudioPPFrm_NormalizeNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .NormalizeNumericUpDown.Value = XTRSTR Else .NormalizeNumericUpDown.Value = 1.0
                    End If

                    If XTR.Name = "AudioPPFrm_AudioASCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .AudioASCheckBox.Checked = XTRSTR Else .AudioASCheckBox.Checked = False
                    End If

                End With

                '//////////////////////////////////////////////////////////// ImagePPFrm
                With ImagePPFrm

                    If XTR.Name = "ImagePPFrm_AviSynthFramerateComboBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .AviSynthFramerateComboBox.Text = XTRSTR Else .AviSynthFramerateComboBox.Text = "23.976"
                    End If

                    If XTR.Name = "ImagePPFrm_AviSynthFramerateCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .AviSynthFramerateCheckBox.Checked = XTRSTR Else .AviSynthFramerateCheckBox.Checked = False
                    End If

                    'AviSynthImageSizeComboBox
                    If XTR.Name = "ImagePPFrm_AviSynthImageSizeComboBox" Then
                        Dim AviSynthImageSizeComboBoxV As String = ""
                        AviSynthImageSizeComboBoxV = XTR.ReadString
                        If AviSynthImageSizeComboBoxV = "LangCls.ImagePPUserInputComboBox" Then
                            .AviSynthImageSizeComboBox.Text = LangCls.ImagePPUserInputComboBox
                        Else
                            If AviSynthImageSizeComboBoxV <> "" Then
                                .AviSynthImageSizeComboBox.Text = AviSynthImageSizeComboBoxV
                            Else '기본값
                                .AviSynthImageSizeComboBox.Text = "480 x 272"
                            End If
                        End If
                    End If
                    'AviSynthImageSizeComboBox

                    If XTR.Name = "ImagePPFrm_AviSynthImageSizeWidthTextBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .AviSynthImageSizeWidthTextBox.Text = XTRSTR Else .AviSynthImageSizeWidthTextBox.Text = "480"
                    End If

                    If XTR.Name = "ImagePPFrm_AviSynthImageSizeHeightTextBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .AviSynthImageSizeHeightTextBox.Text = XTRSTR Else .AviSynthImageSizeHeightTextBox.Text = "272"
                    End If

                    If XTR.Name = "ImagePPFrm_AviSynthImageSizeCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .AviSynthImageSizeCheckBox.Checked = XTRSTR Else .AviSynthImageSizeCheckBox.Checked = False
                    End If

                    'AviSynthResizeFilterComboBox
                    If XTR.Name = "ImagePPFrm_AviSynthResizeFilterComboBox" Then
                        Dim AviSynthResizeFilterComboBoxV As String = ""
                        Dim AviSynthResizeFilterComboBox1V As String = ""
                        Dim AviSynthResizeFilterComboBox2V As String = ""
                        AviSynthResizeFilterComboBoxV = XTR.ReadString
                        Try
                            AviSynthResizeFilterComboBox1V = Split(AviSynthResizeFilterComboBoxV, " ")(0)
                            AviSynthResizeFilterComboBox2V = Split(AviSynthResizeFilterComboBoxV, " ")(1)
                        Catch ex As Exception
                        End Try
                        If AviSynthResizeFilterComboBox2V = "LangCls.ImagePPBlurStr" Then
                            .AviSynthResizeFilterComboBox.Text = AviSynthResizeFilterComboBox1V & " " & LangCls.ImagePPBlurStr
                        ElseIf AviSynthResizeFilterComboBox2V = "LangCls.ImagePPSharpStr" Then
                            .AviSynthResizeFilterComboBox.Text = AviSynthResizeFilterComboBox1V & " " & LangCls.ImagePPSharpStr
                        ElseIf AviSynthResizeFilterComboBox2V = "LangCls.ImagePPMiddleStr" Then
                            .AviSynthResizeFilterComboBox.Text = AviSynthResizeFilterComboBox1V & " " & LangCls.ImagePPMiddleStr
                        Else '기본값
                            .AviSynthResizeFilterComboBox.Text = "Bicubic " & LangCls.ImagePPMiddleStr
                        End If
                    End If
                    'AviSynthResizeFilterComboBox

                    'AviSynthAspectComboBox
                    If XTR.Name = "ImagePPFrm_AviSynthAspectComboBox" Then
                        Dim AviSynthAspectComboBoxV As String = ""
                        AviSynthAspectComboBoxV = XTR.ReadString
                        If AviSynthAspectComboBoxV = "LangCls.ImagePPNoKeepAviSynthAspectComboBox" Then
                            .AviSynthAspectComboBox.Text = LangCls.ImagePPNoKeepAviSynthAspectComboBox
                        ElseIf AviSynthAspectComboBoxV = "LangCls.ImagePPLetterBoxAviSynthAspectComboBox" Then
                            .AviSynthAspectComboBox.Text = LangCls.ImagePPLetterBoxAviSynthAspectComboBox
                        ElseIf AviSynthAspectComboBoxV = "LangCls.ImagePPCropAviSynthAspectComboBox" Then
                            .AviSynthAspectComboBox.Text = LangCls.ImagePPCropAviSynthAspectComboBox
                        Else '기본값
                            .AviSynthAspectComboBox.Text = LangCls.ImagePPLetterBoxAviSynthAspectComboBox
                        End If
                    End If
                    'AviSynthAspectComboBox

                    'AviSynthAspectComboBox2
                    If XTR.Name = "ImagePPFrm_AviSynthAspectComboBox2" Then
                        Dim AviSynthAspectComboBox2V As String = ""
                        AviSynthAspectComboBox2V = XTR.ReadString
                        If AviSynthAspectComboBox2V = "LangCls.ImagePPOutputAviSynthAspectComboBox2" Then
                            .AviSynthAspectComboBox2.Text = LangCls.ImagePPOutputAviSynthAspectComboBox2
                        ElseIf AviSynthAspectComboBox2V = "LangCls.ImagePPOriginalAviSynthAspectComboBox2" Then
                            .AviSynthAspectComboBox2.Text = LangCls.ImagePPOriginalAviSynthAspectComboBox2
                        ElseIf AviSynthAspectComboBox2V = "LangCls.ImagePP43AviSynthAspectComboBox2" Then
                            .AviSynthAspectComboBox2.Text = LangCls.ImagePP43AviSynthAspectComboBox2
                        ElseIf AviSynthAspectComboBox2V = "LangCls.ImagePP169AviSynthAspectComboBox2" Then
                            .AviSynthAspectComboBox2.Text = LangCls.ImagePP169AviSynthAspectComboBox2
                        ElseIf AviSynthAspectComboBox2V = "LangCls.ImagePP1851AviSynthAspectComboBox2" Then
                            .AviSynthAspectComboBox2.Text = LangCls.ImagePP1851AviSynthAspectComboBox2
                        ElseIf AviSynthAspectComboBox2V = "LangCls.ImagePP2351AviSynthAspectComboBox2" Then
                            .AviSynthAspectComboBox2.Text = LangCls.ImagePP2351AviSynthAspectComboBox2
                        ElseIf AviSynthAspectComboBox2V = "LangCls.ImagePPUserInputComboBox" Then
                            .AviSynthAspectComboBox2.Text = LangCls.ImagePPUserInputComboBox
                        Else '기본값
                            .AviSynthAspectComboBox2.Text = LangCls.ImagePPOutputAviSynthAspectComboBox2
                        End If
                    End If
                    'AviSynthAspectComboBox2

                    If XTR.Name = "ImagePPFrm_AviSynthAspectWTextBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .AviSynthAspectWTextBox.Text = XTRSTR Else .AviSynthAspectWTextBox.Text = "0"
                    End If

                    If XTR.Name = "ImagePPFrm_AviSynthAspectHTextBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .AviSynthAspectHTextBox.Text = XTRSTR Else .AviSynthAspectHTextBox.Text = "0"
                    End If

                    If XTR.Name = "ImagePPFrm_AviSynthDeinterlaceCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .AviSynthDeinterlaceCheckBox.Checked = XTRSTR Else .AviSynthDeinterlaceCheckBox.Checked = False
                    End If

                    If XTR.Name = "ImagePPFrm_AviSynthDeinterlaceComboBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .AviSynthDeinterlaceComboBox.Text = XTRSTR Else .AviSynthDeinterlaceComboBox.Text = "linear blend deinterlacer (lb)"
                    End If

                    If XTR.Name = "ImagePPFrm_brightnessNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .brightnessNumericUpDown.Value = XTRSTR Else .brightnessNumericUpDown.Value = 0
                    End If

                    If XTR.Name = "ImagePPFrm_contrastNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .contrastNumericUpDown.Value = XTRSTR Else .contrastNumericUpDown.Value = 1
                    End If

                    If XTR.Name = "ImagePPFrm_saturationNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .saturationNumericUpDown.Value = XTRSTR Else .saturationNumericUpDown.Value = 1
                    End If

                    If XTR.Name = "ImagePPFrm_hueNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .hueNumericUpDown.Value = XTRSTR Else .hueNumericUpDown.Value = 0
                    End If

                    If XTR.Name = "ImagePPFrm_SharpenNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .SharpenNumericUpDown.Value = XTRSTR Else .SharpenNumericUpDown.Value = 0
                    End If

                    If XTR.Name = "ImagePPFrm_ColorYUVTVPCRadioButton" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .ColorYUVTVPCRadioButton.Checked = XTRSTR Else .ColorYUVTVPCRadioButton.Checked = False
                    End If

                    If XTR.Name = "ImagePPFrm_ColorYUVPCTVRadioButton" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .ColorYUVPCTVRadioButton.Checked = XTRSTR Else .ColorYUVPCTVRadioButton.Checked = False
                    End If

                    If XTR.Name = "ImagePPFrm_ColorYUVNRadioButton" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .ColorYUVNRadioButton.Checked = XTRSTR Else .ColorYUVNRadioButton.Checked = True
                    End If

                    If XTR.Name = "ImagePPFrm_ColorYUVASCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .ColorYUVASCheckBox.Checked = XTRSTR Else .ColorYUVASCheckBox.Checked = False
                    End If

                    If XTR.Name = "ImagePPFrm_AVSMPEG2DeinterlaceCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .AVSMPEG2DeinterlaceCheckBox.Checked = XTRSTR Else .AVSMPEG2DeinterlaceCheckBox.Checked = False
                    End If

                    If XTR.Name = "ImagePPFrm_AVSMPEG2DeinterlaceComboBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .AVSMPEG2DeinterlaceComboBox.Text = XTRSTR Else .AVSMPEG2DeinterlaceComboBox.Text = "Yadif mode=0"
                    End If

                    If XTR.Name = "ImagePPFrm_FieldorderComboBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .FieldorderComboBox.Text = XTRSTR Else .FieldorderComboBox.Text = "Varying field order"
                    End If

                    If XTR.Name = "ImagePPFrm_FFPP_hb_CheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .FFPP_hb_CheckBox.Checked = XTRSTR Else .FFPP_hb_CheckBox.Checked = False
                    End If

                    If XTR.Name = "ImagePPFrm_FFPP_vb_CheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .FFPP_vb_CheckBox.Checked = XTRSTR Else .FFPP_vb_CheckBox.Checked = False
                    End If

                    If XTR.Name = "ImagePPFrm_FFPP_ha_CheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .FFPP_ha_CheckBox.Checked = XTRSTR Else .FFPP_ha_CheckBox.Checked = False
                    End If

                    If XTR.Name = "ImagePPFrm_FFPP_va_CheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .FFPP_va_CheckBox.Checked = XTRSTR Else .FFPP_va_CheckBox.Checked = False
                    End If

                    If XTR.Name = "ImagePPFrm_FFPP_h1_CheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .FFPP_h1_CheckBox.Checked = XTRSTR Else .FFPP_h1_CheckBox.Checked = False
                    End If

                    If XTR.Name = "ImagePPFrm_FFPP_v1_CheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .FFPP_v1_CheckBox.Checked = XTRSTR Else .FFPP_v1_CheckBox.Checked = False
                    End If

                    If XTR.Name = "ImagePPFrm_FFPP_dr_CheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .FFPP_dr_CheckBox.Checked = XTRSTR Else .FFPP_dr_CheckBox.Checked = False
                    End If

                End With

                '예외
                If XTR.Name = "AVSCheckBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then AVSCheckBox.Checked = XTRSTR Else AVSCheckBox.Checked = True
                End If

            Loop

        Catch ex As Exception
            MsgBox("XML_LOAD_ERROR :" & ex.Message)
            '오류가 있으면 오류변수 ON
            OpenErrV = True
        Finally
            XTR.Close()
        End Try

    End Sub

    Public Sub APP_XML_SAVE(ByVal src As String)

        '접근권한이 있을 때 까지 반복
        If My.Computer.FileSystem.FileExists(src) = True Then
RELOAD:
            Try
                Dim _SRL As New StreamReader(src, System.Text.Encoding.UTF8)
                _SRL.Close()
            Catch ex As Exception
                GoTo RELOAD
            End Try
        End If

        Dim XTWriter As New XmlTextWriter(src, System.Text.Encoding.UTF8)

        Try

            XTWriter.Formatting = Formatting.Indented
            XTWriter.Indentation = 4
            XTWriter.WriteStartDocument()
            XTWriter.WriteComment("Kirara Encoder Settings")
            XTWriter.WriteStartElement("KiraraEncoderSettings")

            '-----------------------

            XTWriter.WriteStartElement("VolTrackBarStreamFrmV")
            XTWriter.WriteString(VolTrackBarStreamFrmV)
            XTWriter.WriteEndElement()

            XTWriter.WriteStartElement("AllChToolStripMenuItemStreamFrmV")
            XTWriter.WriteString(AllChToolStripMenuItemStreamFrmV)
            XTWriter.WriteEndElement()

            XTWriter.WriteStartElement("LeftChToolStripMenuItemStreamFrmV")
            XTWriter.WriteString(LeftChToolStripMenuItemStreamFrmV)
            XTWriter.WriteEndElement()

            XTWriter.WriteStartElement("RightChToolStripMenuItemStreamFrmV")
            XTWriter.WriteString(RightChToolStripMenuItemStreamFrmV)
            XTWriter.WriteEndElement()

            XTWriter.WriteStartElement("rateMStreamFrmV")
            XTWriter.WriteString(rateMStreamFrmV)
            XTWriter.WriteEndElement()

            XTWriter.WriteStartElement("scaletempoToolStripMenuItemStreamFrmV")
            XTWriter.WriteString(scaletempoToolStripMenuItemStreamFrmV)
            XTWriter.WriteEndElement()

            XTWriter.WriteStartElement("extrastereoToolStripMenuItemStreamFrmV")
            XTWriter.WriteString(extrastereoToolStripMenuItemStreamFrmV)
            XTWriter.WriteEndElement()

            XTWriter.WriteStartElement("karaokeToolStripMenuItemStreamFrmV")
            XTWriter.WriteString(karaokeToolStripMenuItemStreamFrmV)
            XTWriter.WriteEndElement()

            XTWriter.WriteStartElement("VisualizeMotionVectorsToolStripMenuItemStreamFrmV")
            XTWriter.WriteString(VisualizeMotionVectorsToolStripMenuItemStreamFrmV)
            XTWriter.WriteEndElement()

            XTWriter.WriteStartElement("VisualizeBlockTypesToolStripMenuItemStreamFrmV")
            XTWriter.WriteString(VisualizeBlockTypesToolStripMenuItemStreamFrmV)
            XTWriter.WriteEndElement()

            XTWriter.WriteStartElement("FFmpegDeinterlacerToolStripMenuItemStreamFrmV")
            XTWriter.WriteString(FFmpegDeinterlacerToolStripMenuItemStreamFrmV)
            XTWriter.WriteEndElement()

            XTWriter.WriteStartElement("AspectOriginToolStripMenuItemStreamFrmV")
            XTWriter.WriteString(AspectOriginToolStripMenuItemStreamFrmV)
            XTWriter.WriteEndElement()

            XTWriter.WriteStartElement("SizeOriginToolStripMenuItemStreamFrmV")
            XTWriter.WriteString(SizeOriginToolStripMenuItemStreamFrmV)
            XTWriter.WriteEndElement()

            XTWriter.WriteStartElement("SavePathTextBox")
            XTWriter.WriteString(SavePathTextBox.Text)
            XTWriter.WriteEndElement()

            XTWriter.WriteStartElement("PresetLabel")
            XTWriter.WriteString(PresetLabel.Text)
            XTWriter.WriteEndElement()

            XTWriter.WriteStartElement("MainWidth")
            XTWriter.WriteString(MainWidth)
            XTWriter.WriteEndElement()

            XTWriter.WriteStartElement("MainHeight")
            XTWriter.WriteString(MainHeight)
            XTWriter.WriteEndElement()

            XTWriter.WriteStartElement("MainX")
            XTWriter.WriteString(MainX)
            XTWriter.WriteEndElement()

            XTWriter.WriteStartElement("MainY")
            XTWriter.WriteString(MainY)
            XTWriter.WriteEndElement()

            XTWriter.WriteStartElement("MainWindowState")
            XTWriter.WriteString(MainWindowState)
            XTWriter.WriteEndElement()

            XTWriter.WriteStartElement("EncListListView0")
            XTWriter.WriteString(EncListListView.Columns(0).Width)
            XTWriter.WriteEndElement()

            XTWriter.WriteStartElement("OldVerCheckBoxAVSIFrmV")
            XTWriter.WriteString(OldVerCheckBoxAVSIFrmV)
            XTWriter.WriteEndElement()

            XTWriter.WriteStartElement("PriorityComboBoxEncodingFrmV")
            XTWriter.WriteString(PriorityComboBoxEncodingFrmV)
            XTWriter.WriteEndElement()

            XTWriter.WriteStartElement("LangToolStripMenuItemV")
            XTWriter.WriteString(LangToolStripMenuItemV)
            XTWriter.WriteEndElement()

            '----------------------

            XTWriter.WriteEndDocument()

        Catch ex As Exception
            MsgBox("XML_SAVE_ERROR :" & ex.Message)
        Finally
            XTWriter.Close()
        End Try

    End Sub

    Public Sub AVS_XML_SAVE(ByVal src As String)

        '접근권한이 있을 때 까지 반복
        If My.Computer.FileSystem.FileExists(src) = True Then
RELOAD:
            Try
                Dim _SRL As New StreamReader(src, System.Text.Encoding.UTF8)
                _SRL.Close()
            Catch ex As Exception
                GoTo RELOAD
            End Try
        End If

        Dim XTWriter As New XmlTextWriter(src, System.Text.Encoding.UTF8)

        Try

            XTWriter.Formatting = Formatting.Indented
            XTWriter.Indentation = 4
            XTWriter.WriteStartDocument()
            XTWriter.WriteComment("Kirara Encoder Settings")
            XTWriter.WriteStartElement("KiraraEncoderSettings")

            '//////////////////////////////////////////////////////////// AviSynthEditorFrm
            With AviSynthEditorFrm

                XTWriter.WriteStartElement("AviSynthEditorFrm_FFmpegSourceTextBox")
                XTWriter.WriteString(.FFmpegSourceTextBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("AviSynthEditorFrm_ASFTextBox")
                XTWriter.WriteString(.DirectShowSourceTextBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("AviSynthEditorFrm_MPEG2SourceTextBox")
                XTWriter.WriteString(.MPEG2SourceTextBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("AviSynthEditorFrm_BassAudioTextBox")
                XTWriter.WriteString(.BassAudioTextBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("AviSynthEditorFrm_NicAudioTextBox")
                XTWriter.WriteString(.NicAudioTextBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("AviSynthEditorFrm_ChannelTextBox")
                XTWriter.WriteString(.ChannelTextBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("AviSynthEditorFrm_AVCTextBox")
                XTWriter.WriteString(.AVCTextBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("AviSynthEditorFrm_VC1TextBox")
                XTWriter.WriteString(.VC1TextBox.Text)
                XTWriter.WriteEndElement()

            End With

            XTWriter.WriteEndDocument()

        Catch ex As Exception
            MsgBox("XML_SAVE_ERROR :" & ex.Message)
        Finally
            XTWriter.Close()
        End Try

        'SAVE용
        If EncListListView.SelectedItems.Count <> 0 Then
            Dim index As Integer = EncListListView.SelectedItems(index).Index
            GET_OutputINFO(index)  '출력정보
        End If

    End Sub

    Public Sub XML_SAVE(ByVal src As String)

        '접근권한이 있을 때 까지 반복
        If My.Computer.FileSystem.FileExists(src) = True Then
RELOAD:
            Try
                Dim _SRL As New StreamReader(src, System.Text.Encoding.UTF8)
                _SRL.Close()
            Catch ex As Exception
                GoTo RELOAD
            End Try
        End If

        Dim XTWriter As New XmlTextWriter(src, System.Text.Encoding.UTF8)

        Try

            XTWriter.Formatting = Formatting.Indented
            XTWriter.Indentation = 4
            XTWriter.WriteStartDocument()
            XTWriter.WriteComment("Kirara Encoder Settings")
            XTWriter.WriteStartElement("KiraraEncoderSettings")

            '//////////////////////////////////////////////////////////// EncSetFrm
            With EncSetFrm

                '설정 기본값
                XTWriter.WriteStartElement("EncSetFrm_OutFComboBox")
                XTWriter.WriteString(Split(.OutFComboBox.Text, " ")(0))
                XTWriter.WriteEndElement()

                '비디오
                XTWriter.WriteStartElement("EncSetFrm_VideoCodecComboBox")
                XTWriter.WriteString(.VideoCodecComboBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("EncSetFrm_VideoModeComboBox")
                XTWriter.WriteString(Split(.VideoModeComboBox.Text, " ")(0))
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("EncSetFrm_BitrateComboBox")
                XTWriter.WriteString(.BitrateComboBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("EncSetFrm_QuantizerNumericUpDown")
                XTWriter.WriteString(.QuantizerNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("EncSetFrm_QuantizerCQPNumericUpDown")
                XTWriter.WriteString(.QuantizerCQPNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("EncSetFrm_QualityNumericUpDown")
                XTWriter.WriteString(.QualityNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("EncSetFrm_FramerateComboBox")
                XTWriter.WriteString(.FramerateComboBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("EncSetFrm_FramerateCheckBox")
                XTWriter.WriteString(.FramerateCheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("EncSetFrm_AdvanOptsCheckBox")
                XTWriter.WriteString(.AdvanOptsCheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("EncSetFrm_GOPSizeCheckBox")
                XTWriter.WriteString(.GOPSizeCheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("EncSetFrm_GOPSizeTextBox")
                XTWriter.WriteString(.GOPSizeTextBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("EncSetFrm_MinGOPSizeTextBox")
                XTWriter.WriteString(.MinGOPSizeTextBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("EncSetFrm_PSPMP4CheckBox")
                XTWriter.WriteString(.PSPMP4CheckBox.Checked)
                XTWriter.WriteEndElement()

                '영상
                'ImageSizeComboBox
                XTWriter.WriteStartElement("EncSetFrm_ImageSizeComboBox")
                If .ImageSizeComboBox.Text = LangCls.EncSetUserInputComboBox Then
                    XTWriter.WriteString("LangCls.EncSetUserInputComboBox")
                Else
                    XTWriter.WriteString(.ImageSizeComboBox.Text)
                End If
                XTWriter.WriteEndElement()
                'ImageSizeComboBox

                XTWriter.WriteStartElement("EncSetFrm_ImageSizeWidthTextBox")
                XTWriter.WriteString(.ImageSizeWidthTextBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("EncSetFrm_ImageSizeHeightTextBox")
                XTWriter.WriteString(.ImageSizeHeightTextBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("EncSetFrm_ImageSizeCheckBox")
                XTWriter.WriteString(.ImageSizeCheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("EncSetFrm_FFmpegResizeFilterComboBox")
                XTWriter.WriteString(.FFmpegResizeFilterComboBox.Text)
                XTWriter.WriteEndElement()

                'AspectComboBox
                XTWriter.WriteStartElement("EncSetFrm_AspectComboBox")
                If .AspectComboBox.Text = LangCls.EncSetNoKeepAspectComboBox Then
                    XTWriter.WriteString("LangCls.EncSetNoKeepAspectComboBox")
                ElseIf .AspectComboBox.Text = LangCls.EncSetLetterBoxAspectComboBox Then
                    XTWriter.WriteString("LangCls.EncSetLetterBoxAspectComboBox")
                ElseIf .AspectComboBox.Text = LangCls.EncSetCropAspectComboBox Then
                    XTWriter.WriteString("LangCls.EncSetCropAspectComboBox")
                End If
                XTWriter.WriteEndElement()
                'AspectComboBox

                'AspectComboBox2
                XTWriter.WriteStartElement("EncSetFrm_AspectComboBox2")
                If .AspectComboBox2.Text = LangCls.EncSetOutputAspectComboBox2 Then
                    XTWriter.WriteString("LangCls.EncSetOutputAspectComboBox2")
                ElseIf .AspectComboBox2.Text = LangCls.EncSetOriginalAspectComboBox2 Then
                    XTWriter.WriteString("LangCls.EncSetOriginalAspectComboBox2")
                ElseIf .AspectComboBox2.Text = LangCls.EncSet43AspectComboBox2 Then
                    XTWriter.WriteString("LangCls.EncSet43AspectComboBox2")
                ElseIf .AspectComboBox2.Text = LangCls.EncSet169AspectComboBox2 Then
                    XTWriter.WriteString("LangCls.EncSet169AspectComboBox2")
                ElseIf .AspectComboBox2.Text = LangCls.EncSet1851AspectComboBox2 Then
                    XTWriter.WriteString("LangCls.EncSet1851AspectComboBox2")
                ElseIf .AspectComboBox2.Text = LangCls.EncSet2351AspectComboBox2 Then
                    XTWriter.WriteString("LangCls.EncSet2351AspectComboBox2")
                ElseIf .AspectComboBox2.Text = LangCls.EncSetUserInputComboBox Then
                    XTWriter.WriteString("LangCls.EncSetUserInputComboBox")
                End If
                XTWriter.WriteEndElement()
                'AspectComboBox2

                XTWriter.WriteStartElement("EncSetFrm_AspectWTextBox")
                XTWriter.WriteString(.AspectWTextBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("EncSetFrm_AspectHTextBox")
                XTWriter.WriteString(.AspectHTextBox.Text)
                XTWriter.WriteEndElement()

                '영상 처리
                XTWriter.WriteStartElement("EncSetFrm_FFmpegImageUnsharpCheckBox")
                XTWriter.WriteString(.FFmpegImageUnsharpCheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("EncSetFrm_LumaMatrixHSNumericUpDown")
                XTWriter.WriteString(.LumaMatrixHSNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("EncSetFrm_LumaMatrixVSNumericUpDown")
                XTWriter.WriteString(.LumaMatrixVSNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("EncSetFrm_LumaEffectSNumericUpDown")
                XTWriter.WriteString(.LumaEffectSNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("EncSetFrm_ChromaMatrixHSNumericUpDown")
                XTWriter.WriteString(.ChromaMatrixHSNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("EncSetFrm_ChromaMatrixVSNumericUpDown")
                XTWriter.WriteString(.ChromaMatrixVSNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("EncSetFrm_ChromaEffectSNumericUpDown")
                XTWriter.WriteString(.ChromaEffectSNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("EncSetFrm_hflipCheckBox")
                XTWriter.WriteString(.hflipCheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("EncSetFrm_vflipCheckBox")
                XTWriter.WriteString(.vflipCheckBox.Checked)
                XTWriter.WriteEndElement()

                '오디오
                XTWriter.WriteStartElement("EncSetFrm_AudioCodecComboBox")
                XTWriter.WriteString(.AudioCodecComboBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("EncSetFrm_AudioBitrateComboBox")
                XTWriter.WriteString(.AudioBitrateComboBox.Text)
                XTWriter.WriteEndElement()

                'FFmpegChComboBox
                XTWriter.WriteStartElement("EncSetFrm_FFmpegChComboBox")
                If .FFmpegChComboBox.Text = LangCls.EncSetchoriginComboBox Then
                    XTWriter.WriteString("LangCls.EncSetchoriginComboBox")
                ElseIf .FFmpegChComboBox.Text = LangCls.EncSetch10ComboBox Then
                    XTWriter.WriteString("LangCls.EncSetch10ComboBox")
                ElseIf .FFmpegChComboBox.Text = LangCls.EncSetch20ComboBox Then
                    XTWriter.WriteString("LangCls.EncSetch20ComboBox")
                ElseIf .FFmpegChComboBox.Text = LangCls.EncSetch51ComboBox Then
                    XTWriter.WriteString("LangCls.EncSetch51ComboBox")
                End If
                XTWriter.WriteEndElement()
                'FFmpegChComboBox

                XTWriter.WriteStartElement("EncSetFrm_SamplerateComboBox")
                XTWriter.WriteString(.SamplerateComboBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("EncSetFrm_SamplerateCheckBox")
                XTWriter.WriteString(.SamplerateCheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("EncSetFrm_AudioVolNumericUpDown")
                XTWriter.WriteString(.AudioVolNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("EncSetFrm_VorbisQNumericUpDown")
                XTWriter.WriteString(.VorbisQNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("EncSetFrm_AMRBitrateComboBox")
                XTWriter.WriteString(.AMRBitrateComboBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("EncSetFrm_NeroAACProfileComboBox")
                XTWriter.WriteString(.NeroAACProfileComboBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("EncSetFrm_NeroAACBitrateNumericUpDown")
                XTWriter.WriteString(.NeroAACBitrateNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("EncSetFrm_NeroAACQNumericUpDown")
                XTWriter.WriteString(.NeroAACQNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("EncSetFrm_NeroAACABRRadioButton")
                XTWriter.WriteString(.NeroAACABRRadioButton.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("EncSetFrm_NeroAACCBRRadioButton")
                XTWriter.WriteString(.NeroAACCBRRadioButton.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("EncSetFrm_NeroAACVBRRadioButton")
                XTWriter.WriteString(.NeroAACVBRRadioButton.Checked)
                XTWriter.WriteEndElement()

                '기타
                XTWriter.WriteStartElement("EncSetFrm_HeaderTextBox")
                XTWriter.WriteString(.HeaderTextBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("EncSetFrm_ExtensionTextBox")
                XTWriter.WriteString(.ExtensionTextBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("EncSetFrm_SizeLimitTextBox")
                XTWriter.WriteString(.SizeLimitTextBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("EncSetFrm_SizeLimitCheckBox")
                XTWriter.WriteString(.SizeLimitCheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("EncSetFrm_DeinterlaceCheckBox")
                XTWriter.WriteString(.DeinterlaceCheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("EncSetFrm_FFmpegCommandTextBox")
                XTWriter.WriteString(.FFmpegCommandTextBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("EncSetFrm_SubtitleRecordingCheckBox")
                XTWriter.WriteString(.SubtitleRecordingCheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("EncSetFrm_SizeEncCheckBox")
                XTWriter.WriteString(.SizeEncCheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("EncSetFrm_SizeEncTextBox")
                XTWriter.WriteString(.SizeEncTextBox.Text)
                XTWriter.WriteEndElement()

                '===

            End With

            '//////////////////////////////////////////////////////////// x264optsFrm
            With x264optsFrm

                'Main
                XTWriter.WriteStartElement("x264optsFrm_ThreadsNumericUpDown")
                XTWriter.WriteString(.ThreadsNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("x264optsFrm_ProfileComboBox")
                XTWriter.WriteString(.ProfileComboBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("x264optsFrm_LevelComboBox")
                XTWriter.WriteString(.LevelComboBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("x264optsFrm_FastfirstpassCheckBox")
                XTWriter.WriteString(.FastfirstpassCheckBox.Checked)
                XTWriter.WriteEndElement()

                'Frame-Type
                XTWriter.WriteStartElement("x264optsFrm_DeblockingCheckBox")
                XTWriter.WriteString(.DeblockingCheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("x264optsFrm_DeblockingAlphaNumericUpDown")
                XTWriter.WriteString(.DeblockingAlphaNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("x264optsFrm_DeblockingBetaNumericUpDown")
                XTWriter.WriteString(.DeblockingBetaNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("x264optsFrm_CABACCheckBox")
                XTWriter.WriteString(.CABACCheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("x264optsFrm_BFramesNumericUpDown")
                XTWriter.WriteString(.BFramesNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("x264optsFrm_BFrameBiasNumericUpDown")
                XTWriter.WriteString(.BFrameBiasNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("x264optsFrm_AdaptiveBFramesComboBox")
                XTWriter.WriteString(.AdaptiveBFramesComboBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("x264optsFrm_BFramePyramidCheckBox")
                XTWriter.WriteString(.BFramePyramidCheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("x264optsFrm_BFrameWeightedPredictionCheckBox")
                XTWriter.WriteString(.BFrameWeightedPredictionCheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("x264optsFrm_ReferenceFramesNumericUpDown")
                XTWriter.WriteString(.ReferenceFramesNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("x264optsFrm_ExtraIFramesNumericUpDown")
                XTWriter.WriteString(.ExtraIFramesNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("x264optsFrm_PframeWeightedPredictionComboBox")
                XTWriter.WriteString(.PframeWeightedPredictionComboBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("x264optsFrm_AdaptiveIFramesDecisionCheckBox")
                XTWriter.WriteString(.AdaptiveIFramesDecisionCheckBox.Checked)
                XTWriter.WriteEndElement()

                'Rate Control
                XTWriter.WriteStartElement("x264optsFrm_QMinNumericUpDown")
                XTWriter.WriteString(.QMinNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("x264optsFrm_QMaxNumericUpDown")
                XTWriter.WriteString(.QMaxNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("x264optsFrm_QDeltaNumericUpDown")
                XTWriter.WriteString(.QDeltaNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("x264optsFrm_QIPRatioNumericUpDown")
                XTWriter.WriteString(.QIPRatioNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("x264optsFrm_QPBRatioNumericUpDown")
                XTWriter.WriteString(.QPBRatioNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("x264optsFrm_ChromaandLumaQPOffsetNumericUpDown")
                XTWriter.WriteString(.ChromaandLumaQPOffsetNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("x264optsFrm_VBVBufferSizeNumericUpDown")
                XTWriter.WriteString(.VBVBufferSizeNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("x264optsFrm_VBVMaximumBitrateNumericUpDown")
                XTWriter.WriteString(.VBVMaximumBitrateNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("x264optsFrm_VBVInitialBufferNumericUpDown")
                XTWriter.WriteString(.VBVInitialBufferNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("x264optsFrm_AverageBitrateVarianceNumericUpDown")
                XTWriter.WriteString(.AverageBitrateVarianceNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("x264optsFrm_QuantizerCompressionNumericUpDown")
                XTWriter.WriteString(.QuantizerCompressionNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("x264optsFrm_NumberofFramesforLookaheadNumericUpDown")
                XTWriter.WriteString(.NumberofFramesforLookaheadNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("x264optsFrm_UseMBTreeCheckBox")
                XTWriter.WriteString(.UseMBTreeCheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("x264optsFrm_AdaptiveQuantizersModeComboBox")
                XTWriter.WriteString(.AdaptiveQuantizersModeComboBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("x264optsFrm_AdaptiveQuantizersStrengthNumericUpDown")
                XTWriter.WriteString(.AdaptiveQuantizersStrengthNumericUpDown.Value)
                XTWriter.WriteEndElement()

                'Analysis
                XTWriter.WriteStartElement("x264optsFrm_ChromaMECheckBox")
                XTWriter.WriteString(.ChromaMECheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("x264optsFrm_MERangeNumericUpDown")
                XTWriter.WriteString(.MERangeNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("x264optsFrm_MEMethodComboBox")
                XTWriter.WriteString(.MEMethodComboBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("x264optsFrm_SubpixelMEComboBox")
                XTWriter.WriteString(.SubpixelMEComboBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("x264optsFrm_MVPredictionModeComboBox")
                XTWriter.WriteString(.MVPredictionModeComboBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("x264optsFrm_TrellisComboBox")
                XTWriter.WriteString(.TrellisComboBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("x264optsFrm_PsyRDStrengthNumericUpDown")
                XTWriter.WriteString(.PsyRDStrengthNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("x264optsFrm_PsyTrellisStrengthNumericUpDown")
                XTWriter.WriteString(.PsyTrellisStrengthNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("x264optsFrm_NoMixedReferenceFramesCheckBox")
                XTWriter.WriteString(.NoMixedReferenceFramesCheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("x264optsFrm_NoFastPSkipCheckBox")
                XTWriter.WriteString(.NoFastPSkipCheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("x264optsFrm_NoPsychovisualEnhancementsCheckBox")
                XTWriter.WriteString(.NoPsychovisualEnhancementsCheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("x264optsFrm_MacroblocksComboBox")
                XTWriter.WriteString(.MacroblocksComboBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("x264optsFrm_Adaptive8x8DCTCheckBox")
                XTWriter.WriteString(.Adaptive8x8DCTCheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("x264optsFrm_I4x4CheckBox")
                XTWriter.WriteString(.I4x4CheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("x264optsFrm_P4x4CheckBox")
                XTWriter.WriteString(.P4x4CheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("x264optsFrm_I8x8CheckBox")
                XTWriter.WriteString(.I8x8CheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("x264optsFrm_P8x8CheckBox")
                XTWriter.WriteString(.P8x8CheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("x264optsFrm_B8x8CheckBox")
                XTWriter.WriteString(.B8x8CheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("x264optsFrm_NoiseReductionNumericUpDown")
                XTWriter.WriteString(.NoiseReductionNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("x264optsFrm_UseaccessunitdelimitersCheckBox")
                XTWriter.WriteString(.UseaccessunitdelimitersCheckBox.Checked)
                XTWriter.WriteEndElement()

            End With

            '//////////////////////////////////////////////////////////// MPEG4optsFrm
            With MPEG4optsFrm

                'Main
                XTWriter.WriteStartElement("MPEG4optsFrm_ThreadsNumericUpDown")
                XTWriter.WriteString(.ThreadsNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("MPEG4optsFrm_QuantizationTypeComboBox")
                XTWriter.WriteString(.QuantizationTypeComboBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("MPEG4optsFrm_AdaptiveQuantizationCheckBox")
                XTWriter.WriteString(.AdaptiveQuantizationCheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("MPEG4optsFrm_InterlacedEncodingCheckBox")
                XTWriter.WriteString(.InterlacedEncodingCheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("MPEG4optsFrm_GrayscaleCheckBox")
                XTWriter.WriteString(.GrayscaleCheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("MPEG4optsFrm_TopFieldFirstCheckBox")
                XTWriter.WriteString(.TopFieldFirstCheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("MPEG4optsFrm__4MotionVectorCheckBox")
                XTWriter.WriteString(._4MotionVectorCheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("MPEG4optsFrm_QPELCheckBox")
                XTWriter.WriteString(.QPELCheckBox.Checked)
                XTWriter.WriteEndElement()

                'B-VOPs
                XTWriter.WriteStartElement("MPEG4optsFrm_BFramesCheckBox")
                XTWriter.WriteString(.BFramesCheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("MPEG4optsFrm_BVOPsNumericUpDown")
                XTWriter.WriteString(.BVOPsNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("MPEG4optsFrm_ClosedGOPCheckBox")
                XTWriter.WriteString(.ClosedGOPCheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("MPEG4optsFrm_DownscalesffdBfdCheckBox")
                XTWriter.WriteString(.DownscalesffdBfdCheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("MPEG4optsFrm_RefinettmvuibmCheckBox")
                XTWriter.WriteString(.RefinettmvuibmCheckBox.Checked)
                XTWriter.WriteEndElement()

                'Motion Estimation
                XTWriter.WriteStartElement("MPEG4optsFrm_DiamondtsfmeComboBox")
                XTWriter.WriteString(.DiamondtsfmeComboBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("MPEG4optsFrm_HQModeComboBox")
                XTWriter.WriteString(.HQModeComboBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("MPEG4optsFrm_FpmcfComboBox")
                XTWriter.WriteString(.FpmcfComboBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("MPEG4optsFrm_SpmcfComboBox")
                XTWriter.WriteString(.SpmcfComboBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("MPEG4optsFrm_McfComboBox")
                XTWriter.WriteString(.McfComboBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("MPEG4optsFrm_IdcfComboBox")
                XTWriter.WriteString(.IdcfComboBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("MPEG4optsFrm_PmecfComboBox")
                XTWriter.WriteString(.PmecfComboBox.Text)
                XTWriter.WriteEndElement()

                'Rate Control
                XTWriter.WriteStartElement("MPEG4optsFrm_QMinNumericUpDown")
                XTWriter.WriteString(.QMinNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("MPEG4optsFrm_QMaxNumericUpDown")
                XTWriter.WriteString(.QMaxNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("MPEG4optsFrm_QDeltaNumericUpDown")
                XTWriter.WriteString(.QDeltaNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("MPEG4optsFrm_QuantizerCompressionNumericUpDown")
                XTWriter.WriteString(.QuantizerCompressionNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("MPEG4optsFrm_QuantizerBlurNumericUpDown")
                XTWriter.WriteString(.QuantizerBlurNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("MPEG4optsFrm_MaxVBTextBox")
                XTWriter.WriteString(.MaxVBTextBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("MPEG4optsFrm_MinVBTextBox")
                XTWriter.WriteString(.MinVBTextBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("MPEG4optsFrm_RCBufferSizeTextBox")
                XTWriter.WriteString(.RCBufferSizeTextBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("MPEG4optsFrm_TrellisQuantizationCheckBox")
                XTWriter.WriteString(.TrellisQuantizationCheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("MPEG4optsFrm_DCTalgorithmComboBox")
                XTWriter.WriteString(.DCTalgorithmComboBox.Text)
                XTWriter.WriteEndElement()

            End With

            '//////////////////////////////////////////////////////////// SubtitleFrm
            With SubtitleFrm

                XTWriter.WriteStartElement("SubtitleFrm_SubtitleCheckBox")
                XTWriter.WriteString(.SubtitleCheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("SubtitleFrm_EncComboBox")
                XTWriter.WriteString(.EncComboBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("SubtitleFrm_FontComboBox")
                XTWriter.WriteString(.FontComboBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("SubtitleFrm_SizeUpDown")
                XTWriter.WriteString(.SizeUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("SubtitleFrm_ItalicCheckBox")
                XTWriter.WriteString(.ItalicCheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("SubtitleFrm_BoldCheckBox")
                XTWriter.WriteString(.BoldCheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("SubtitleFrm_PrimaryColourTrackBar")
                XTWriter.WriteString(.PrimaryColourTrackBar.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("SubtitleFrm_OutlineColourTrackBar")
                XTWriter.WriteString(.OutlineColourTrackBar.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("SubtitleFrm_BackColourTrackBar")
                XTWriter.WriteString(.BackColourTrackBar.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("SubtitleFrm_OutlineUpDown")
                XTWriter.WriteString(.OutlineUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("SubtitleFrm_ShadowUpDown")
                XTWriter.WriteString(.BackUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("SubtitleFrm_BorderStyle1")
                XTWriter.WriteString(.BorderStyle1.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("SubtitleFrm_BorderStyle3")
                XTWriter.WriteString(.BorderStyle3.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("SubtitleFrm_Alignment5RadioButton")
                XTWriter.WriteString(.Alignment5RadioButton.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("SubtitleFrm_Alignment6RadioButton")
                XTWriter.WriteString(.Alignment6RadioButton.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("SubtitleFrm_Alignment4RadioButton")
                XTWriter.WriteString(.Alignment4RadioButton.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("SubtitleFrm_Alignment9RadioButton")
                XTWriter.WriteString(.Alignment9RadioButton.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("SubtitleFrm_Alignment7RadioButton")
                XTWriter.WriteString(.Alignment7RadioButton.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("SubtitleFrm_Alignment8RadioButton")
                XTWriter.WriteString(.Alignment8RadioButton.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("SubtitleFrm_Alignment1RadioButton")
                XTWriter.WriteString(.Alignment1RadioButton.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("SubtitleFrm_Alignment2RadioButton")
                XTWriter.WriteString(.Alignment2RadioButton.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("SubtitleFrm_Alignment3RadioButton")
                XTWriter.WriteString(.Alignment3RadioButton.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("SubtitleFrm_MarginLNumericUpDown")
                XTWriter.WriteString(.MarginLNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("SubtitleFrm_MarginRNumericUpDown")
                XTWriter.WriteString(.MarginRNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("SubtitleFrm_MarginVNumericUpDown")
                XTWriter.WriteString(.MarginVNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("SubtitleFrm_PrimaryColourPanel")
                XTWriter.WriteString(.PrimaryColourPanel.BackColor.ToArgb.ToString)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("SubtitleFrm_OutlineColourPanel")
                XTWriter.WriteString(.OutlineColourPanel.BackColor.ToArgb.ToString)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("SubtitleFrm_BackColourPanel")
                XTWriter.WriteString(.BackColourPanel.BackColor.ToArgb.ToString)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("SubtitleFrm_SecondaryColourPanel")
                XTWriter.WriteString(.SecondaryColourPanel.BackColor.ToArgb.ToString)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("SubtitleFrm_SecondaryColourTrackBar")
                XTWriter.WriteString(.SecondaryColourTrackBar.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("SubtitleFrm_StrikeOutCheckBox")
                XTWriter.WriteString(.StrikeOutCheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("SubtitleFrm_UnderlineCheckBox")
                XTWriter.WriteString(.UnderlineCheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("SubtitleFrm_SpacingNumericUpDown")
                XTWriter.WriteString(.SpacingNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("SubtitleFrm_AngleNumericUpDown")
                XTWriter.WriteString(.AngleNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("SubtitleFrm_ScaleXNumericUpDown")
                XTWriter.WriteString(.ScaleXNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("SubtitleFrm_ScaleYNumericUpDown")
                XTWriter.WriteString(.ScaleYNumericUpDown.Value)
                XTWriter.WriteEndElement()

            End With

            '//////////////////////////////////////////////////////////// AudioPPFrm
            With AudioPPFrm

                'AviSynthChComboBox
                XTWriter.WriteStartElement("AudioPPFrm_AviSynthChComboBox")
                If .AviSynthChComboBox.Text = LangCls.AudioPPchoriginComboBox Then
                    XTWriter.WriteString("LangCls.AudioPPchoriginComboBox")
                ElseIf .AviSynthChComboBox.Text = LangCls.AudioPPch10ComboBox Then
                    XTWriter.WriteString("LangCls.AudioPPch10ComboBox")
                ElseIf .AviSynthChComboBox.Text = LangCls.AudioPPch20ComboBox Then
                    XTWriter.WriteString("LangCls.AudioPPch20ComboBox")
                ElseIf .AviSynthChComboBox.Text = LangCls.AudioPPch51ComboBox Then
                    XTWriter.WriteString("LangCls.AudioPPch51ComboBox")
                ElseIf .AviSynthChComboBox.Text = LangCls.AudioPPdolbysComboBox Then
                    XTWriter.WriteString("LangCls.AudioPPdolbysComboBox")
                ElseIf .AviSynthChComboBox.Text = LangCls.AudioPPdolbypComboBox Then
                    XTWriter.WriteString("LangCls.AudioPPdolbypComboBox")
                End If
                XTWriter.WriteEndElement()
                'AviSynthChComboBox

                XTWriter.WriteStartElement("AudioPPFrm_AmplifyCheckBox")
                XTWriter.WriteString(.AmplifyCheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("AudioPPFrm_AmplifyNumericUpDown")
                XTWriter.WriteString(.AmplifyNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("AudioPPFrm_EQCheckBox")
                XTWriter.WriteString(.EQCheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("AudioPPFrm_EQ1TrackBar")
                XTWriter.WriteString(.EQ1TrackBar.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("AudioPPFrm_EQ2TrackBar")
                XTWriter.WriteString(.EQ2TrackBar.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("AudioPPFrm_EQ3TrackBar")
                XTWriter.WriteString(.EQ3TrackBar.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("AudioPPFrm_EQ4TrackBar")
                XTWriter.WriteString(.EQ4TrackBar.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("AudioPPFrm_EQ5TrackBar")
                XTWriter.WriteString(.EQ5TrackBar.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("AudioPPFrm_EQ6TrackBar")
                XTWriter.WriteString(.EQ6TrackBar.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("AudioPPFrm_EQ7TrackBar")
                XTWriter.WriteString(.EQ7TrackBar.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("AudioPPFrm_EQ8TrackBar")
                XTWriter.WriteString(.EQ8TrackBar.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("AudioPPFrm_EQ9TrackBar")
                XTWriter.WriteString(.EQ9TrackBar.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("AudioPPFrm_EQ10TrackBar")
                XTWriter.WriteString(.EQ10TrackBar.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("AudioPPFrm_EQ11TrackBar")
                XTWriter.WriteString(.EQ11TrackBar.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("AudioPPFrm_EQ12TrackBar")
                XTWriter.WriteString(.EQ12TrackBar.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("AudioPPFrm_EQ13TrackBar")
                XTWriter.WriteString(.EQ13TrackBar.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("AudioPPFrm_EQ14TrackBar")
                XTWriter.WriteString(.EQ14TrackBar.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("AudioPPFrm_EQ15TrackBar")
                XTWriter.WriteString(.EQ15TrackBar.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("AudioPPFrm_EQ16TrackBar")
                XTWriter.WriteString(.EQ16TrackBar.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("AudioPPFrm_EQ17TrackBar")
                XTWriter.WriteString(.EQ17TrackBar.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("AudioPPFrm_EQ18TrackBar")
                XTWriter.WriteString(.EQ18TrackBar.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("AudioPPFrm_NormalizeCheckBox")
                XTWriter.WriteString(.NormalizeCheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("AudioPPFrm_NormalizeTrackBar")
                XTWriter.WriteString(.NormalizeTrackBar.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("AudioPPFrm_NormalizeNumericUpDown")
                XTWriter.WriteString(.NormalizeNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("AudioPPFrm_AudioASCheckBox")
                XTWriter.WriteString(.AudioASCheckBox.Checked)
                XTWriter.WriteEndElement()

            End With

            '//////////////////////////////////////////////////////////// ImagePPFrm
            With ImagePPFrm

                XTWriter.WriteStartElement("ImagePPFrm_AviSynthFramerateComboBox")
                XTWriter.WriteString(.AviSynthFramerateComboBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("ImagePPFrm_AviSynthFramerateCheckBox")
                XTWriter.WriteString(.AviSynthFramerateCheckBox.Checked)
                XTWriter.WriteEndElement()

                'AviSynthImageSizeComboBox
                XTWriter.WriteStartElement("ImagePPFrm_AviSynthImageSizeComboBox")
                If .AviSynthImageSizeComboBox.Text = LangCls.ImagePPUserInputComboBox Then
                    XTWriter.WriteString("LangCls.ImagePPUserInputComboBox")
                Else
                    XTWriter.WriteString(.AviSynthImageSizeComboBox.Text)
                End If
                XTWriter.WriteEndElement()
                'AviSynthImageSizeComboBox

                XTWriter.WriteStartElement("ImagePPFrm_AviSynthImageSizeWidthTextBox")
                XTWriter.WriteString(.AviSynthImageSizeWidthTextBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("ImagePPFrm_AviSynthImageSizeHeightTextBox")
                XTWriter.WriteString(.AviSynthImageSizeHeightTextBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("ImagePPFrm_AviSynthImageSizeCheckBox")
                XTWriter.WriteString(.AviSynthImageSizeCheckBox.Checked)
                XTWriter.WriteEndElement()

                'AviSynthResizeFilterComboBox
                XTWriter.WriteStartElement("ImagePPFrm_AviSynthResizeFilterComboBox")
                If InStr(.AviSynthResizeFilterComboBox.Text, LangCls.ImagePPBlurStr) <> 0 Then
                    XTWriter.WriteString(Split(.AviSynthResizeFilterComboBox.Text, " ")(0) & " LangCls.ImagePPBlurStr")
                ElseIf InStr(.AviSynthResizeFilterComboBox.Text, LangCls.ImagePPSharpStr) <> 0 Then
                    XTWriter.WriteString(Split(.AviSynthResizeFilterComboBox.Text, " ")(0) & " LangCls.ImagePPSharpStr")
                ElseIf InStr(.AviSynthResizeFilterComboBox.Text, LangCls.ImagePPMiddleStr) <> 0 Then
                    XTWriter.WriteString(Split(.AviSynthResizeFilterComboBox.Text, " ")(0) & " LangCls.ImagePPMiddleStr")
                End If
                XTWriter.WriteEndElement()
                'AviSynthResizeFilterComboBox

                'AviSynthAspectComboBox
                XTWriter.WriteStartElement("ImagePPFrm_AviSynthAspectComboBox")
                If .AviSynthAspectComboBox.Text = LangCls.ImagePPNoKeepAviSynthAspectComboBox Then
                    XTWriter.WriteString("LangCls.ImagePPNoKeepAviSynthAspectComboBox")
                ElseIf .AviSynthAspectComboBox.Text = LangCls.ImagePPLetterBoxAviSynthAspectComboBox Then
                    XTWriter.WriteString("LangCls.ImagePPLetterBoxAviSynthAspectComboBox")
                ElseIf .AviSynthAspectComboBox.Text = LangCls.ImagePPCropAviSynthAspectComboBox Then
                    XTWriter.WriteString("LangCls.ImagePPCropAviSynthAspectComboBox")
                End If
                XTWriter.WriteEndElement()
                'AviSynthAspectComboBox

                'AviSynthAspectComboBox2
                XTWriter.WriteStartElement("ImagePPFrm_AviSynthAspectComboBox2")
                If .AviSynthAspectComboBox2.Text = LangCls.ImagePPOutputAviSynthAspectComboBox2 Then
                    XTWriter.WriteString("LangCls.ImagePPOutputAviSynthAspectComboBox2")
                ElseIf .AviSynthAspectComboBox2.Text = LangCls.ImagePPOriginalAviSynthAspectComboBox2 Then
                    XTWriter.WriteString("LangCls.ImagePPOriginalAviSynthAspectComboBox2")
                ElseIf .AviSynthAspectComboBox2.Text = LangCls.ImagePP43AviSynthAspectComboBox2 Then
                    XTWriter.WriteString("LangCls.ImagePP43AviSynthAspectComboBox2")
                ElseIf .AviSynthAspectComboBox2.Text = LangCls.ImagePP169AviSynthAspectComboBox2 Then
                    XTWriter.WriteString("LangCls.ImagePP169AviSynthAspectComboBox2")
                ElseIf .AviSynthAspectComboBox2.Text = LangCls.ImagePP1851AviSynthAspectComboBox2 Then
                    XTWriter.WriteString("LangCls.ImagePP1851AviSynthAspectComboBox2")
                ElseIf .AviSynthAspectComboBox2.Text = LangCls.ImagePP2351AviSynthAspectComboBox2 Then
                    XTWriter.WriteString("LangCls.ImagePP2351AviSynthAspectComboBox2")
                ElseIf .AviSynthAspectComboBox2.Text = LangCls.ImagePPUserInputComboBox Then
                    XTWriter.WriteString("LangCls.ImagePPUserInputComboBox")
                End If
                XTWriter.WriteEndElement()
                'AviSynthAspectComboBox2

                XTWriter.WriteStartElement("ImagePPFrm_AviSynthAspectWTextBox")
                XTWriter.WriteString(.AviSynthAspectWTextBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("ImagePPFrm_AviSynthAspectHTextBox")
                XTWriter.WriteString(.AviSynthAspectHTextBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("ImagePPFrm_AviSynthDeinterlaceCheckBox")
                XTWriter.WriteString(.AviSynthDeinterlaceCheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("ImagePPFrm_AviSynthDeinterlaceComboBox")
                XTWriter.WriteString(.AviSynthDeinterlaceComboBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("ImagePPFrm_brightnessNumericUpDown")
                XTWriter.WriteString(.brightnessNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("ImagePPFrm_contrastNumericUpDown")
                XTWriter.WriteString(.contrastNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("ImagePPFrm_saturationNumericUpDown")
                XTWriter.WriteString(.saturationNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("ImagePPFrm_hueNumericUpDown")
                XTWriter.WriteString(.hueNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("ImagePPFrm_SharpenNumericUpDown")
                XTWriter.WriteString(.SharpenNumericUpDown.Value)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("ImagePPFrm_ColorYUVTVPCRadioButton")
                XTWriter.WriteString(.ColorYUVTVPCRadioButton.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("ImagePPFrm_ColorYUVPCTVRadioButton")
                XTWriter.WriteString(.ColorYUVPCTVRadioButton.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("ImagePPFrm_ColorYUVNRadioButton")
                XTWriter.WriteString(.ColorYUVNRadioButton.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("ImagePPFrm_ColorYUVASCheckBox")
                XTWriter.WriteString(.ColorYUVASCheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("ImagePPFrm_AVSMPEG2DeinterlaceCheckBox")
                XTWriter.WriteString(.AVSMPEG2DeinterlaceCheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("ImagePPFrm_AVSMPEG2DeinterlaceComboBox")
                XTWriter.WriteString(.AVSMPEG2DeinterlaceComboBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("ImagePPFrm_FieldorderComboBox")
                XTWriter.WriteString(.FieldorderComboBox.Text)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("ImagePPFrm_FFPP_hb_CheckBox")
                XTWriter.WriteString(.FFPP_hb_CheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("ImagePPFrm_FFPP_vb_CheckBox")
                XTWriter.WriteString(.FFPP_vb_CheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("ImagePPFrm_FFPP_ha_CheckBox")
                XTWriter.WriteString(.FFPP_ha_CheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("ImagePPFrm_FFPP_va_CheckBox")
                XTWriter.WriteString(.FFPP_va_CheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("ImagePPFrm_FFPP_h1_CheckBox")
                XTWriter.WriteString(.FFPP_h1_CheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("ImagePPFrm_FFPP_v1_CheckBox")
                XTWriter.WriteString(.FFPP_v1_CheckBox.Checked)
                XTWriter.WriteEndElement()

                XTWriter.WriteStartElement("ImagePPFrm_FFPP_dr_CheckBox")
                XTWriter.WriteString(.FFPP_dr_CheckBox.Checked)
                XTWriter.WriteEndElement()

            End With

            '예외
            XTWriter.WriteStartElement("AVSCheckBox")
            XTWriter.WriteString(AVSCheckBox.Checked)
            XTWriter.WriteEndElement()

            XTWriter.WriteEndDocument()

        Catch ex As Exception
            MsgBox("XML_SAVE_ERROR :" & ex.Message)
        Finally
            XTWriter.Close()
        End Try

        'SAVE용
        If EncListListView.SelectedItems.Count <> 0 Then
            Dim index As Integer = EncListListView.SelectedItems(index).Index
            GET_OutputINFO(index)  '출력정보
        End If

    End Sub

    Private Sub AVSSetButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AVSSetButton.Click

        Try
            AviSynthEditorFrm.ShowDialog(Me)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub PresetButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PresetButton.Click
        PresetContextMenuStrip.Show(Control.MousePosition)
    End Sub

    Private Sub AVSCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AVSCheckBox.CheckedChanged

        '설정활성화 여부
        If AVSCheckBox.Checked = True Then
            AVSSetButton.Enabled = True
        Else
            AVSSetButton.Enabled = False
        End If

        '-------------------------------------------------------------------------

        'SAVE용 - AviSynth 사용여부 예외적용
        If EncListListView.SelectedItems.Count <> 0 Then
            Dim index As Integer = EncListListView.SelectedItems(index).Index
            GET_OutputINFO(index)  '출력정보
        End If

    End Sub

    Private Sub OpenFolderButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenFolderButton.Click
        Process.Start("explorer.exe", SavePathTextBox.Text)
    End Sub

    Private Sub SetFolderButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetFolderButton.Click
        FolderBrowserDialog1.SelectedPath = SavePathTextBox.Text
        FolderBrowserDialog1.ShowDialog()
        SavePathTextBox.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub TrayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrayToolStripMenuItem.Click
        NotifyIcon.Icon = Me.Icon
        NotifyIcon.Visible = True
        If EncodingFrm.EncProcBool = True Then
            EncodingFrm.Hide()
        Else
            NotifyIcon.Text = Strings.Left(Me.Text, 63)
        End If
        Me.Hide()
    End Sub

    Public Sub NotifyIcon_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon.Click
        If EncodingFrm.EncProcBool = True Then
            EncodingFrm.Show()
        End If
        Me.Show()
        NotifyIcon.Visible = False
    End Sub

    Private Sub EncListListView_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles EncListListView.MouseUp
        EncListListViewChkB = False

        Try
            '오류로그..
            If SelIndex <> -1 Then
                If EncListListView.Items(SelIndex).SubItems(7).Text = "" Then
                    ErrToolStripMenuItem.Enabled = False
                Else
                    ErrToolStripMenuItem.Enabled = True
                End If
            Else
                ErrToolStripMenuItem.Enabled = False
            End If
        Catch ex As Exception
            SelIndex = -1
        End Try

    End Sub

    Private Sub EncListListView_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles EncListListView.KeyUp

        Try
            '오류로그..
            If SelIndex <> -1 Then
                If EncListListView.Items(SelIndex).SubItems(7).Text = "" Then
                    ErrToolStripMenuItem.Enabled = False
                Else
                    ErrToolStripMenuItem.Enabled = True
                End If
            Else
                ErrToolStripMenuItem.Enabled = False
            End If
        Catch ex As Exception
            SelIndex = -1
        End Try

    End Sub

    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick

        '인덱스관련
        If EncListListView.Items.Count = 0 Then
            SelIndex = -1
            AllRemoveButton.Enabled = False
        Else
            If EncodingFrm.EncProcBool = False Then '인코딩중이 아닐때만 활성화
                AllRemoveButton.Enabled = True
            End If
        End If

        EnableArea()
        '=====================================
        '인코딩 중 활성구역
        If EncodingFrm.EncProcBool = False OrElse SelIndex > EncodingFrm.EncindexI Then
            MovePanel.Enabled = True
            RemovePanel.Enabled = True
        Else
            MovePanel.Enabled = False
            RemovePanel.Enabled = False
        End If
        '=====================================
        '오류로그
        ErrToolStripMenuItem2.Enabled = ErrToolStripMenuItem.Enabled

    End Sub

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        AddButton_Click(Nothing, Nothing)
    End Sub

    Private Sub CheckAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckAllToolStripMenuItem.Click
        For i = 0 To EncListListView.Items.Count - 1
            EncListListView.Items(i).Checked = True
        Next
    End Sub

    Private Sub UncheckAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UncheckAllToolStripMenuItem.Click
        For i = 0 To EncListListView.Items.Count - 1
            EncListListView.Items(i).Checked = False
        Next
    End Sub

    Private Sub IInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InInfoToolStripMenuItem.Click

        FileInfoButton_Click(Nothing, Nothing)

    End Sub

    Private Sub OInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OutInfoToolStripMenuItem.Click

        '선택된 아이템이 없으면 종료
        If EncListListView.SelectedItems.Count = 0 Then
            MsgBox(LangCls.MainSelectListA)
            Exit Sub
        End If

        '파일
        '---------------------------------
        ' 원본 파일의 파일 이름만 추출
        '=================================
        Dim FilenameV As String = ""
        If InStrRev(EncListListView.Items(SelIndex).SubItems(0).Text, ".") <> 0 Then
            FilenameV = Strings.Left(EncListListView.Items(SelIndex).SubItems(0).Text, InStrRev(EncListListView.Items(SelIndex).SubItems(0).Text, ".") - 1)
        Else
            FilenameV = EncListListView.Items(SelIndex).SubItems(0).Text
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
        If Strings.Right(SavePathTextBox.Text, 1) = "\" Then
            SavePathTextBoxV = SavePathTextBox.Text
        Else
            SavePathTextBoxV = SavePathTextBox.Text & "\"
        End If

        If My.Computer.FileSystem.FileExists(SavePathTextBoxV & EncSetFrm.HeaderTextBox.Text & FilenameV & ExtensionV) = False Then
            MsgBox(LangCls.MainFileNotFound)
            Exit Sub
        End If

        If FileInfoFrm.Visible = True Then
            FileInfoFrm.GET_TXT(SavePathTextBoxV & EncSetFrm.HeaderTextBox.Text & FilenameV & ExtensionV)
        Else
            FileInfoFrm.Show(Me)
            FileInfoFrm.GET_TXT(SavePathTextBoxV & EncSetFrm.HeaderTextBox.Text & FilenameV & ExtensionV)
        End If

    End Sub

    Private Sub IPlayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InPlayToolStripMenuItem.Click

        '선택된 아이템이 없으면 종료
        If EncListListView.SelectedItems.Count = 0 Then
            MsgBox(LangCls.MainSelectListA)
            Exit Sub
        End If

        '캐시예외
        Dim CACHEV As String = ""
        If EncListListView.Items(SelIndex).SubItems(3).Text = "MPEGTS" Then CACHEV = " -demuxer lavf -cache 8192"
        Dim ThreadV As String = ""
        If InStr(1, EncListListView.Items(SelIndex).SubItems(8).Text, "h264", CompareMethod.Text) <> 0 Then ThreadV = " -lavdopts threads=" & Environ("NUMBER_OF_PROCESSORS")

        Dim MSGB As String = ""
        MSGB = My.Application.Info.DirectoryPath & "\tools\mplayer\mplayer-" & Me.MPLAYEREXESTR & ".exe " & Chr(34) & EncListListView.Items(SelIndex).SubItems(10).Text & Chr(34) & _
        " -identify -noquiet -nofontconfig -vo direct3d -idx" & CACHEV & ThreadV
        Shell(MSGB, AppWinStyle.NormalFocus)

    End Sub

    Private Sub OPlayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OutPlayToolStripMenuItem.Click

        '선택된 아이템이 없으면 종료
        If EncListListView.SelectedItems.Count = 0 Then
            MsgBox(LangCls.MainSelectListA)
            Exit Sub
        End If

        '파일
        '---------------------------------
        ' 원본 파일의 파일 이름만 추출
        '=================================
        Dim FilenameV As String = ""
        If InStrRev(EncListListView.Items(SelIndex).SubItems(0).Text, ".") <> 0 Then
            FilenameV = Strings.Left(EncListListView.Items(SelIndex).SubItems(0).Text, InStrRev(EncListListView.Items(SelIndex).SubItems(0).Text, ".") - 1)
        Else
            FilenameV = EncListListView.Items(SelIndex).SubItems(0).Text
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
        If Strings.Right(SavePathTextBox.Text, 1) = "\" Then
            SavePathTextBoxV = SavePathTextBox.Text
        Else
            SavePathTextBoxV = SavePathTextBox.Text & "\"
        End If


        Dim MPATHV As String = SavePathTextBoxV & EncSetFrm.HeaderTextBox.Text & FilenameV & ExtensionV

        If My.Computer.FileSystem.FileExists(MPATHV) = False Then
            MsgBox(LangCls.MainFileNotFound)
            Exit Sub
        End If

        '유니코드처리...
        Dim FNGBytes() As Byte = System.Text.Encoding.Default.GetBytes(MPATHV)
        If InStr(System.Text.Encoding.Default.GetString(FNGBytes), "?") <> 0 Then
            MPATHV = WinAPI.GetShortPathName(MPATHV)
        End If

        Dim MSGB As String = ""
        MSGB = My.Application.Info.DirectoryPath & "\tools\mplayer\mplayer-" & Me.MPLAYEREXESTR & ".exe " & Chr(34) & MPATHV & Chr(34) & _
        " -identify -noquiet -nofontconfig -vo direct3d -idx"
        Shell(MSGB, AppWinStyle.NormalFocus)

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        If PInfoFrm.Visible = False Then
            PInfoFrm.Show(Me)
        End If
    End Sub

    Private Sub InChkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InChkToolStripMenuItem.Click
        Try
            AVSIFrm.ShowDialog(Me)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ErrToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ErrToolStripMenuItem2.Click
        ErrToolStripMenuItem_Click(Nothing, Nothing)
    End Sub

    Private Sub AVSCheckBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AVSCheckBox.Click
        '프리셋 설정된 파일 표시 지우기 (저장은 프로그램이 종료될 때 하므로 여기에)
        PresetLabel.Text = LangCls.MainUserStr
    End Sub

End Class
