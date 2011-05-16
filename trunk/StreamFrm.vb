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

Imports System.Runtime.InteropServices
Imports Microsoft.Win32.SafeHandles
Imports System.IO

Public Class StreamFrm

    'MPEGTS형식은 cache사용시 음성이 안 들리는 버그로 인해 예외 코드가 추가되어있습니다.

    '우선순위 설정
    Private Declare Function SetPriorityClass Lib "kernel32" (ByVal HPROCESS As Integer, ByVal dwPriorityClass As Integer) As Integer
    Private Declare Function GetPriorityClass Lib "kernel32" (ByVal HPROCESS As Integer) As Integer
    Private Declare Function GetCurrentProcess Lib "kernel32" () As Integer

    '프론트엔드 코어
    Private OutputHandle_Stream As SafeFileHandle = Nothing
    Private InputHandle_Stream As SafeFileHandle = Nothing
    Private ProcessHandle_Stream As IntPtr = Nothing
    Private ThreadSignal_Stream As New Threading.ManualResetEvent(False)
    Private ProcessID_Stream As UInteger

    '프로세스 우선 순위
    Enum PriorityClass
        REALTIME_PRIORITY_CLASS = &H100
        HIGH_PRIORITY_CLASS = &H80
        ABOVE_NORMAL_PRIORITY_CLASS = 32768
        NORMAL_PRIORITY_CLASS = &H20
        BELOW_NORMAL_PRIORITY_CLASS = 16384
        IDLE_PRIORITY_CLASS = &H40
    End Enum

    '처리여부
    Dim ProcessV As Boolean = False

    '핸들
    Dim MainFrmHWNDV

    '오디오스트림
    Dim ASTRM As Boolean = False

    '열려져있는지 여부
    Public OpenVL As Boolean = False

    '새로고침
    Dim NowTimeSecV As Single = Nothing
    Dim RefBool As Boolean = False

    '이동
    Dim ForwardTimerMV
    Dim BackwardTimerMV

    '프로세스 종료 확인
    Dim ProcessEChkB As Boolean = False

    '정보를가져오는 부분
    Dim GetInfoL As Boolean = True

    'Sub처리중
    Dim SubTask As Boolean = False
    Dim SubTaskLoop1 As Boolean = False
    Dim SubTaskLoop2 As Boolean = False

    '오디오 스트림이나 자막 정보를 받아옴
    Dim DetailInfoTextLog As String = ""
    Dim DetailInfoBool As Boolean = False
    Dim RefAudioStream As String = ""
    Dim RefAudioStreamFStr As String = ""
    Public InfoLoopExit As Boolean = False

    '트랙바
    Dim SEEKSTA As Boolean = False

    '초기시간, 현재시간
    Dim IntTimeTXT As Single = 0.0
    Dim NowTimeSec As Single = 0.0

    '실시간으로 시간과 퍼센트를 받아옴
    Dim GETPP_PV As Integer
    Dim GETPP_TV As Single

    '배속변수
    Public rateM As Single = 1.0

    '재생시간추출
    Dim PHHMMSSEMSV As String = ""

    '원본사이즈
    Dim SZH As Integer = 1
    Dim SZW As Integer = 1

#Region "프론트엔드 코어"

    '=================================
    '코드 출처: http://www.vbforums.com/showthread.php?t=618110
    '위의 URL에 있는 핵심 소스를 사용하여 제작되었습니다.

    Private Sub WriteToOutputBox(ByVal MsgV As String)
        Dim k As Long = 1
        Dim kk As Long = 0
        Dim l As String = ""

        If OutputBox_Stream.InvokeRequired Then
            Try
                Invoke(New Action(Of String)(AddressOf WriteToOutputBox), MsgV)
            Catch ex As Exception
            End Try
        Else

            '캐리지리턴(Cr), 라인피드(Lf) 처리
            If InStr(MsgV, " " & vbCr) <> 0 Then MsgV = Replace(MsgV, " " & vbCr, vbNewLine)
            If InStr(MsgV, vbCr & vbCrLf) <> 0 Then MsgV = Replace(MsgV, vbCr & vbCrLf, vbNewLine)
            If InStr(MsgV, vbLf) <> 0 Then MsgV = Replace(MsgV, vbLf, vbNewLine)

            '정보받기
            If GetInfoL = True Then
                OutputBox_Stream.AppendText(MsgV)
            End If

            '================

            Dim i As Long = 1
            Dim ii As Long
            Dim t As String = ""
            Dim t2 As String = ""
            Dim ts As String = ""

            If InStrRev(MsgV, " V:") Then
                ii = InStrRev(MsgV, " V:")
                If InStr(ii, MsgV, vbCr, CompareMethod.Text) Then
                    i = InStr(ii, MsgV, vbCr, CompareMethod.Text) + 1
                    t = Mid(MsgV, ii, i - ii - 1)
                    t2 = " V:"
                End If
            ElseIf InStrRev(MsgV, "A:") Then
                ii = InStrRev(MsgV, "A:")
                If InStr(ii, MsgV, vbCr, CompareMethod.Text) Then
                    i = InStr(ii, MsgV, vbCr, CompareMethod.Text) + 1
                    t = Mid(MsgV, ii, i - ii - 1)
                    t2 = "A:"
                End If
            ElseIf InStrRev(MsgV, "V:") Then
                ii = InStrRev(MsgV, "V:")
                If InStr(ii, MsgV, vbCr, CompareMethod.Text) Then
                    i = InStr(ii, MsgV, vbCr, CompareMethod.Text) + 1
                    t = Mid(MsgV, ii, i - ii - 1)
                    t2 = "V:"
                End If
            Else
                i = i + 1
            End If

            If t <> "" Then
                Try
                    Dim t3 As String = Split(LTrim(Mid(t, InStrRev(t, t2) + Len(t2))), " ")(0)
                    If SEEKSTA = False Then NowTimeSec = Val(t3) - Val(IntTimeTXT)
                    Dim str As String = LTrim(RTrim(Replace(t, vbCr, vbNullString)))
                    If t2 = " V:" Then
                        ToolStripStatusLabel1.Text = Mid(str, InStr(str, "A-V:", CompareMethod.Text))
                    Else
                        ToolStripStatusLabel1.Text = str
                    End If

                    '---------------------------
                    '한번만진행
                    If ProcessV = False Then
                        '스트림 선택 및 밸런스 관련
                        If ASListBox.Items.Count > AudioComboBox.SelectedIndex Then

                            '밸런스
                            If AllChToolStripMenuItem.Checked = True Then
                                MsgSend("pausing_keep_force balance 0 1 ")
                            ElseIf LeftChToolStripMenuItem.Checked = True Then
                                MsgSend("pausing_keep_force balance -1 1 ")
                            ElseIf RightChToolStripMenuItem.Checked = True Then
                                MsgSend("pausing_keep_force balance 1 1 ")
                            End If

                            '설정
                            If AudioComboBox.SelectedIndex <> 0 AndAlso AudioComboBox.Items.Count <> 0 Then
                                MsgSend("pausing_keep_force switch_audio " & ASListBox.Items.Item(AudioComboBox.SelectedIndex) & " ")
                                MsgSend("pausing_keep_force volume " & VolTrackBar.Value & " 1 ")
                                MsgSend("pausing_keep seek " & NowTimeSec & " 2 ")
                            Else
                                MsgSend("pausing_keep_force volume " & VolTrackBar.Value & " 1 ")
                            End If

                            ProcessV = True
                        End If
                    End If
                    '---------------------------

                Catch ex As Exception
                End Try
            End If

            '================

            If MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(3).Text = "ASF" Then

                k = 1
                kk = 0
                l = ""
                If InStrRev(MsgV, "ANS_PERCENT_POSITION=") Then
                    kk = InStrRev(MsgV, "ANS_PERCENT_POSITION=")
                    If InStr(kk, MsgV, vbNewLine, CompareMethod.Text) Then
                        k = InStr(kk, MsgV, vbNewLine, CompareMethod.Text) + 1
                        l = Mid(MsgV, kk, k - kk - 1)
                    End If
                Else
                    k = k + 1
                End If
                If l <> "" Then
                    If SEEKSTA = False Then GETPP_PV = Mid(l, InStrRev(l, "ANS_PERCENT_POSITION=") + 21)
                End If

            End If

            End If
    End Sub

    Public Sub MsgSend(ByVal msg As String)

        If InputHandle_Stream.IsClosed = False Then
            Dim MessageBytes() As Byte = System.Text.Encoding.GetEncoding(0).GetBytes(msg & vbCrLf & vbCr)
            Dim BytesWritten As UInteger = 0

            Dim WaitOnHandles(1) As IntPtr
            WaitOnHandles(0) = ProcessHandle_Stream
            WaitOnHandles(1) = ThreadSignal_Stream.SafeWaitHandle.DangerousGetHandle
            If WinAPI.WaitForMultipleObjects(2, WaitOnHandles, False, 0) <> 0 Then
                WinAPI.WriteFile(InputHandle_Stream, MessageBytes, CUInt(MessageBytes.Length - 1), BytesWritten, 0)
            End If

        End If

    End Sub

    Private Sub GETPP_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GETPP.Tick

        If InputHandle_Stream.IsClosed = False Then
            Dim MessageBytes() As Byte = System.Text.Encoding.GetEncoding(0).GetBytes("pausing_keep_force get_percent_pos " & vbCrLf & vbCr)
            Dim BytesWritten As UInteger = 0

            Dim WaitOnHandles(1) As IntPtr
            WaitOnHandles(0) = ProcessHandle_Stream
            WaitOnHandles(1) = ThreadSignal_Stream.SafeWaitHandle.DangerousGetHandle
            If WinAPI.WaitForMultipleObjects(2, WaitOnHandles, False, 0) <> 0 Then
                WinAPI.WriteFile(InputHandle_Stream, MessageBytes, CUInt(MessageBytes.Length - 1), BytesWritten, 0)
            End If

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
                If Not OutputHandle_Stream Is Nothing Then
                    PNP = WinAPI.PeekNamedPipe(OutputHandle_Stream, Nothing, 0, 0, BytesAvailable, 0)
                End If

                If PNP = True Then
                    If BytesAvailable > 0 Then
                        ReDim Buffer(CInt(BytesAvailable))
                        If WinAPI.ReadFile(OutputHandle_Stream, Buffer, CUInt(Buffer.Length), BytesRead, 0) Then
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

            If WinAPI.IsHungAppWindow(MainFrmHWNDV) = True Then
                WinAPI.TerminateProcess(ProcessHandle_Stream, 0&)
                '응답없음 강제종료..
            Else
                'Debug.Print("응답")
            End If

            Dim WaitOnHandles(1) As IntPtr
            WaitOnHandles(0) = ProcessHandle_Stream
            WaitOnHandles(1) = ThreadSignal_Stream.SafeWaitHandle.DangerousGetHandle
            If WinAPI.WaitForMultipleObjects(2, WaitOnHandles, False, 0) = 0 Then
                EndOfProcess()
                Exit Do
            End If

            Application.DoEvents()
        Loop

    End Sub

    Private Sub EndOfProcess()

        If OutputBox_Stream.InvokeRequired Then
            Invoke(New MethodInvoker(AddressOf EndOfProcess))
        Else

            '끝
            InfoLoopExit = False
            DetailInfoBool = False
            DetailStreamInfoTimer.Enabled = False
            GetInfoL = False
            SubTaskLoop1 = False
            '타이머
            NowhmsTimer.Enabled = False
            GETPP.Enabled = False
            SeekTimer.Enabled = False
            '로딩
            PrePanel.Visible = False
            LoadingLabel.Visible = False
            OutputBox_Stream.Visible = False
            '프로세스 종료 확인
            ProcessEChkB = True
            '정보받기용
            InfoLoopExit = True
            '기타
            ASListBox.Items.Clear()
            IntTimeTXT = 0.0
            If RefBool = False Then
                NowTimeSec = 0.0
                SeekTrackBar.Value = 0
            End If
            PlayPauseBTN.Enabled = True '활성/비활성(재생)
            '활성/비활성
            SeekTrackBar.Enabled = False
            VolTrackBar.Enabled = False
            StopBTN.Enabled = False
            AudioComboBox.Enabled = False
            BackwardBTN.Enabled = False
            ForwardBTN.Enabled = False
            FrameStepButton.Enabled = False
            Nowhms.Enabled = False
            Totalhms.Enabled = False

            DestroyHandles()
            RefBool = False
            OpenVL = False

        End If

    End Sub

    Public Sub DestroyHandles()

        If ProcessHandle_Stream <> IntPtr.Zero Then
            WinAPI.CloseHandle(ProcessHandle_Stream)
        End If

        If Not InputHandle_Stream Is Nothing AndAlso Not InputHandle_Stream.IsClosed Then
            InputHandle_Stream.Close()
        End If

        If Not OutputHandle_Stream Is Nothing AndAlso Not OutputHandle_Stream.IsClosed Then
            OutputHandle_Stream.Close()
        End If

    End Sub

    '=================================

#End Region

    Private Sub PlaySub()

        If SubTask = True AndAlso SubTaskLoop1 = True Then
            Exit Sub
        End If
        If SubTaskLoop2 = True Then
            Exit Sub
        End If

        '-------------------------

        Dim StartSet As String = ""
        If RefBool = True Then
            StartSet = " -ss " & NowTimeSecV
        End If

        '만일 열려 있다면 깨끗하게
        If OpenVL = True Then
            If WinAPI.TerminateProcess(ProcessHandle_Stream, 0&) <> Nothing Then
                WinAPI.TerminateProcess(ProcessHandle_Stream, 0&)
            End If
        End If

        Do Until OpenVL = False
            SubTaskLoop2 = True
            Application.DoEvents()
        Loop
        SubTaskLoop2 = False

        '===============

        SubTask = True
        PlayPauseBTN.Enabled = False '활성/비활성(재생)
        Totalhms.Text = "/ " & Strings.Left(MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(1).Text, 11) & " "
        Try
            SeekTrackBar.Maximum = (Split(Mid(MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(1).Text, 1, 10), ":")(0) * "60" + _
                                    Split(Mid(MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(1).Text, 1, 10), ":")(1)) * "60" + _
                                    Split(Mid(MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(1).Text, 1, 10), ":")(2)
        Catch ex As Exception
        End Try

        SetAsp() '비율맞춤

        '===========

        Dim ThreadV As String = ""
        If InStr(1, MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(8).Text, "h264", CompareMethod.Text) <> 0 Then ThreadV = " -lavdopts threads=" & System.Environment.ProcessorCount
        Dim scaletempoV As String = ""
        If scaletempoToolStripMenuItem.Checked = True Then
            scaletempoV = " -af-add scaletempo"
        End If
        Dim extrastereoV As String = ""
        If extrastereoToolStripMenuItem.Checked = True Then
            extrastereoV = " -af-add extrastereo"
        End If
        Dim karaokeV As String = ""
        If karaokeToolStripMenuItem.Checked = True Then
            karaokeV = " -af-add karaoke"
        End If
        Dim VisualizeMotionVectorsV As String = ""
        If VisualizeMotionVectorsToolStripMenuItem.Checked = True Then
            VisualizeMotionVectorsV = " -lavdopts vismv=1"
        End If
        Dim VisualizeBlockTypesV As String = ""
        If VisualizeBlockTypesToolStripMenuItem.Checked = True Then
            VisualizeBlockTypesV = " -lavdopts debug=0x4000"
        End If
        Dim DeinterlaceV As String = ""
        If FFmpegDeinterlacerToolStripMenuItem.Checked = True Then
            DeinterlaceV = " -vf-add pp=fd"
        End If

        '캐시예외
        Dim CACHEV As String = ""
        If MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(3).Text = "MPEGTS" Then CACHEV = " -cache 8192"
        '볼륨예외
        Dim VOLV As String = " -volume 0"
        If MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(3).Text = "MPEGTS" Then VOLV = " -volume " & VolTrackBar.Value

        ProcessV = False '처리 부분 초기화

        '--------------
        '비디오출력드라이버
        Dim MPlayerVideoOutputDeviceStr As String = "direct3d"
        If MainFrm.VideoODComboBoxV = "DirectX" Then
            MPlayerVideoOutputDeviceStr = "directx"
        ElseIf MainFrm.VideoODComboBoxV = "DirectX noaccel" Then
            MPlayerVideoOutputDeviceStr = "directx:noaccel"
        ElseIf MainFrm.VideoODComboBoxV = "Direct3D 9 Renderer" Then
            MPlayerVideoOutputDeviceStr = "direct3d"
        ElseIf MainFrm.VideoODComboBoxV = "OpenGL" Then
            MPlayerVideoOutputDeviceStr = "gl"
        ElseIf MainFrm.VideoODComboBoxV = "OpenGL YUV" Then
            MPlayerVideoOutputDeviceStr = "gl:yuv=4:force-pbo:ati-hack"
        ElseIf MainFrm.VideoODComboBoxV = "OpenGL multiple textures version" Then
            MPlayerVideoOutputDeviceStr = "gl2"
        ElseIf MainFrm.VideoODComboBoxV = "MatrixView" Then
            MPlayerVideoOutputDeviceStr = "matrixview"
        ElseIf MainFrm.VideoODComboBoxV = "Colour AsCii Art library" Then
            MPlayerVideoOutputDeviceStr = "caca"
        End If
        '--------------

        '컬러키
        Dim RV As String = "00", GV As String = "00", BV As String = "00"
        If Len(Hex(PrePanel1.BackColor.R.ToString)) = 1 Then RV = "0" & Hex(PrePanel1.BackColor.R) Else RV = Hex(PrePanel1.BackColor.R)
        If Len(Hex(PrePanel1.BackColor.G.ToString)) = 1 Then GV = "0" & Hex(PrePanel1.BackColor.G) Else GV = Hex(PrePanel1.BackColor.G)
        If Len(Hex(PrePanel1.BackColor.B.ToString)) = 1 Then BV = "0" & Hex(PrePanel1.BackColor.B) Else BV = Hex(PrePanel1.BackColor.B)

        Dim MSGB As String = ""
        MSGB = FunctionCls.AppInfoDirectoryPath & "\tools\mplayer\mplayer.exe " & Chr(34) & MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(10).Text & Chr(34) & _
        " -slave -identify -noquiet -nokeepaspect -nofontconfig -osdlevel 0 -colorkey 0x" & RV & GV & BV & " -idx -vo " & MPlayerVideoOutputDeviceStr & " -wid " & PrePanel1.Handle.ToString & " -speed " & rateM & _
        CACHEV & ThreadV & StartSet & scaletempoV & extrastereoV & karaokeV & VisualizeMotionVectorsV & VisualizeBlockTypesV & DeinterlaceV & VOLV

        Dim TempOutputHandle As SafeFileHandle = Nothing
        Dim TempInputHandle As SafeFileHandle = Nothing

        Dim StartupInfo As New WinAPI.STARTUPINFO
        StartupInfo.cb = Marshal.SizeOf(StartupInfo)
        If MPlayerVideoOutputDeviceStr = "caca" Then 'CACA
            StartupInfo.dwFlags = WinAPI.STARTF_USESTDHANDLES
        Else
            StartupInfo.dwFlags = WinAPI.STARTF_USESTDHANDLES Or WinAPI.STARTF_USESHOWWINDOW
        End If

        Dim SecurityAttributes As New WinAPI.SECURITY_ATTRIBUTES
        SecurityAttributes.nLength = Marshal.SizeOf(SecurityAttributes)
        SecurityAttributes.bInheritHandle = True
        WinAPI.CreatePipe(TempOutputHandle, StartupInfo.hStdOutput, SecurityAttributes, 0)
        WinAPI.CreatePipe(StartupInfo.hStdInput, TempInputHandle, SecurityAttributes, 0)
        WinAPI.DuplicateHandle(New HandleRef(Me, Process.GetCurrentProcess.Handle), StartupInfo.hStdOutput, _
                               New HandleRef(Me, Process.GetCurrentProcess.Handle), StartupInfo.hStdError, 0, True, WinAPI.DUPLICATE_SAME_ACCESS)
        WinAPI.DuplicateHandle(New HandleRef(Me, Process.GetCurrentProcess.Handle), TempInputHandle, _
                               New HandleRef(Me, Process.GetCurrentProcess.Handle), InputHandle_Stream, 0, False, WinAPI.DUPLICATE_SAME_ACCESS)
        WinAPI.DuplicateHandle(New HandleRef(Me, Process.GetCurrentProcess.Handle), TempOutputHandle, _
                               New HandleRef(Me, Process.GetCurrentProcess.Handle), OutputHandle_Stream, 0, False, WinAPI.DUPLICATE_SAME_ACCESS)

        TempOutputHandle.Close()
        TempInputHandle.Close()
        TempOutputHandle.Dispose()
        TempInputHandle.Dispose()

        '프로세스 우선순위 설정
        Dim PPInt As Integer = PriorityClass.NORMAL_PRIORITY_CLASS
        If System.Environment.ProcessorCount = 1 Then
            PPInt = PriorityClass.NORMAL_PRIORITY_CLASS
            If GetCurrentProcess <> Nothing Then SetPriorityClass(GetCurrentProcess, PriorityClass.NORMAL_PRIORITY_CLASS)
        Else
            PPInt = PriorityClass.HIGH_PRIORITY_CLASS
            If GetCurrentProcess <> Nothing Then SetPriorityClass(GetCurrentProcess, PriorityClass.HIGH_PRIORITY_CLASS)
        End If

        'GetInfoL
        GetInfoL = True

        Dim ProcessInformation As New WinAPI.PROCESS_INFORMATION
        WinAPI.CreateProcess(Nothing, MSGB, SecurityAttributes, SecurityAttributes, True, PPInt, IntPtr.Zero, Nothing, StartupInfo, ProcessInformation)

        If ProcessInformation.dwProcessId <> 0 AndAlso ProcessInformation.hProcess <> IntPtr.Zero Then
            OpenVL = True
            '비어있게
            OutputBox_Stream.Text = ""
            '정보받기용
            InfoLoopExit = False
            DetailInfoBool = False
            DetailStreamInfoTimer.Enabled = True
            '타이머
            NowhmsTimer.Enabled = True
            SeekTimer.Enabled = True
            '프로세스 종료 확인
            ProcessEChkB = False

            ProcessHandle_Stream = ProcessInformation.hProcess
            ProcessID_Stream = ProcessInformation.dwProcessId
            Dim ThreadSTR As New Threading.Thread(AddressOf OutputInfo)
            ThreadSTR.IsBackground = True
            ThreadSTR.Start()
        End If

        SubTask = False

    End Sub

    Private Sub StreamFrm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        'If e.KeyCode = 37 Then    '<        10 Backward
        '    MsgSend("pausing_keep seek -10 0 ")
        'End If

        'If e.KeyCode = 39 Then    '>        10 Forward
        '    MsgSend("pausing_keep seek 10 0 ")
        'End If

        'If e.KeyCode = 32 Then    'spacebar        play/pause
        '    PreviewGroupBox.Focus()
        '    If OpenVL = False Then
        '        PlaySub()
        '    Else
        '        MsgSend("pause ")
        '    End If
        'End If

    End Sub

    Private Sub StreamFrm_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        '포커스
        PreviewGroupBox.Focus()

        PlaySub()
    End Sub

    Private Sub PlayPauseBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayPauseBTN.Click
        PreviewGroupBox.Focus()
        If OpenVL = False Then
            PlaySub()
        Else
            MsgSend("pause ")
        End If
    End Sub

    Private Sub StopBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopBTN.Click
        PreviewGroupBox.Focus()
        MsgSend("pausing seek 0 2 ")
    End Sub

#Region "이동관련(버튼)"

    Private Sub ForwardTimerM_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForwardTimerM.Tick
        MsgSend("pausing_keep seek " & ForwardTimerMV & " 0 ")
    End Sub

    Private Sub BackwardTimerM_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackwardTimerM.Tick
        MsgSend("pausing_keep seek " & BackwardTimerMV & " 0 ")
    End Sub

    Private Sub ForwardBTN_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ForwardBTN.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If ForwardTimerM.Enabled = True Then
                Exit Sub
            End If
            If MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(3).Text <> "MPEGTS" Then MsgSend("pausing_keep_force volume 0 1 ")
            ForwardTimerMV = 10
            MsgSend("pausing_keep seek " & ForwardTimerMV & " 0 ")
            ForwardTimerM.Enabled = True
        End If
    End Sub

    Private Sub ForwardBTN_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ForwardBTN.MouseUp
        PreviewGroupBox.Focus()
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If ForwardTimerM.Enabled = True Then
                ForwardTimerMV = ""
                MsgSend("pausing_keep_force volume " & VolTrackBar.Value & " 1 ")
                ForwardTimerM.Enabled = False
            End If
        End If
    End Sub

    Private Sub ForwardBTN_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ForwardBTN.MouseLeave
        If ForwardTimerM.Enabled = True Then
            ForwardTimerMV = ""
            MsgSend("pausing_keep_force volume " & VolTrackBar.Value & " 1 ")
            ForwardTimerM.Enabled = False
        End If
    End Sub

    Private Sub BackwardBTN_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BackwardBTN.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If BackwardTimerM.Enabled = True Then
                Exit Sub
            End If
            If MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(3).Text <> "MPEGTS" Then MsgSend("pausing_keep_force volume 0 1 ")
            If NowTimeSec <= 10 Then
                MsgSend("pausing_keep seek 0 2 ")
            Else
                BackwardTimerMV = -10
                MsgSend("pausing_keep seek " & BackwardTimerMV & " 0 ")
            End If
            BackwardTimerM.Enabled = True
        End If
    End Sub

    Private Sub BackwardBTN_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BackwardBTN.MouseUp
        PreviewGroupBox.Focus()
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If BackwardTimerM.Enabled = True Then
                BackwardTimerMV = ""
                MsgSend("pausing_keep_force volume " & VolTrackBar.Value & " 1 ")
                BackwardTimerM.Enabled = False
            End If
        End If
    End Sub

    Private Sub BackwardBTN_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BackwardBTN.MouseLeave
        If BackwardTimerM.Enabled = True Then
            BackwardTimerMV = ""
            MsgSend("pausing_keep_force volume " & VolTrackBar.Value & " 1 ")
            BackwardTimerM.Enabled = False
        End If
    End Sub

#End Region

    Private Sub DetailStreamInfoTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetailStreamInfoTimer.Tick
        If DetailInfoBool = False Then
            DetailAudioInfo()
        End If
    End Sub

    Public Sub RefreshFN()

        If OpenVL = False Then
            Exit Sub
        End If
        RefBool = True
        NowTimeSecV = NowTimeSec
        PlaySub()

    End Sub

    Private Sub DetailAudioInfo()

        If SubTaskLoop1 = True Then Exit Sub '이미 작업중이면 강제종료

        SubTaskLoop1 = True

        PrePanel.Visible = False
        LoadingLabel.Visible = True
        OutputBox_Stream.Visible = True

        Dim i As Long
        Dim ii As Long
        Dim t As String
        Dim subsel As Boolean = False

        DetailInfoBool = True

        Do Until InStr(OutputBox_Stream.Text, "Starting playback...") <> "0"
            Application.DoEvents()
            Threading.Thread.Sleep(10)
            If InfoLoopExit = True Then
                GoTo skip
            End If
        Loop

        GetInfoL = False

        DetailInfoTextLog = Replace(OutputBox_Stream.Text, vbCr, vbNewLine)

        '---------------------------------------------------------------------------


        '///////////////////
        '////  정보
        '///////////////////



        '시작시간
        Dim ID_START_TIMEV As String = "0.0"
        t = "LoopSTR"
        Do Until t = "" '비어 있을 때 까지~

            '빈 상태로.
            t = ""

            i = 1
            If InStr(DetailInfoTextLog, "ID_START_TIME=") Then
                ii = InStr(DetailInfoTextLog, "ID_START_TIME=")
                If InStr(ii, DetailInfoTextLog, vbNewLine, CompareMethod.Text) Then
                    i = InStr(ii, DetailInfoTextLog, vbNewLine, CompareMethod.Text) + 1
                    t = Mid(DetailInfoTextLog, ii, i - ii - 1)
                End If
            Else
                i = i + 1
            End If

            If t <> "" Then

                DetailInfoTextLog = Replace(DetailInfoTextLog, t, "")
                ID_START_TIMEV = Mid(t, InStrRev(t, "ID_START_TIME=") + 14)
                If ID_START_TIMEV = "unknown" Then
                    IntTimeTXT = "0.0"
                Else
                    IntTimeTXT = ID_START_TIMEV
                End If


            End If

            Application.DoEvents()
        Loop
        If MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(3).Text = "ASF" Then GETPP.Enabled = True


        '---------------------------------------------------------------------------


        '///////////////////
        '////  오디오
        '///////////////////


        ASListBox.Items.Clear()
        Dim ID_AUDIO_IDV As String = ""
        Dim ID_AUDIO_IDV_L As New ListBox
        ID_AUDIO_IDV_L.Items.Clear()

        Do

            t = ""
            i = 1
            If InStr(DetailInfoTextLog, "ID_AUDIO_ID=") Then
                ii = InStr(DetailInfoTextLog, "ID_AUDIO_ID=")
                If InStr(ii, DetailInfoTextLog, vbNewLine, CompareMethod.Text) Then
                    i = InStr(ii, DetailInfoTextLog, vbNewLine, CompareMethod.Text) + 1
                    t = Mid(DetailInfoTextLog, ii, i - ii - 1)
                End If
            Else
                i = i + 1
            End If

            If t <> "" Then

                DetailInfoTextLog = Replace(DetailInfoTextLog, t, "")
                ID_AUDIO_IDV = Mid(t, InStrRev(t, "ID_AUDIO_ID=") + 12)
                ASListBox.Items.Add(ID_AUDIO_IDV)

                t = ""
                i = 1
                If InStr(DetailInfoTextLog, "ID_AID_" & ID_AUDIO_IDV & "_NAME=") Then
                    ii = InStr(DetailInfoTextLog, "ID_AID_" & ID_AUDIO_IDV & "_NAME=")
                    If InStr(ii, DetailInfoTextLog, vbNewLine, CompareMethod.Text) Then
                        i = InStr(ii, DetailInfoTextLog, vbNewLine, CompareMethod.Text) + 1
                        t = Mid(DetailInfoTextLog, ii, i - ii - 1)
                    End If
                Else
                    i = i + 1
                End If

                If t <> "" Then
                    If InStr(t, "=", CompareMethod.Text) <> 0 Then
                        Try
                            ID_AUDIO_IDV_L.Items.Add(" (" & Split(t, "=")(1) & ")")
                        Catch ex As Exception
                        End Try
                    Else
                        ID_AUDIO_IDV_L.Items.Add(" (" & t & ")")
                    End If
                Else
                    ID_AUDIO_IDV_L.Items.Add("")
                    t = "LOOPSTR" '루프 계속하기 위해 추가
                End If

            End If

            Application.DoEvents()
        Loop Until t = ""

        If ASTRM = False Then
            For i = 0 To ASListBox.Items.Count - 1
                If AudioComboBox.Items.Count > i AndAlso AudioComboBox.Items.Count <> 0 Then
                    AudioComboBox.Items.Item(i) = AudioComboBox.Items.Item(i) & ", -aid " & ASListBox.Items.Item(i) & ID_AUDIO_IDV_L.Items.Item(i)
                End If
            Next
            ASTRM = True
        End If

skip:
        If OpenVL = False Then Exit Sub

        '끝
        InfoLoopExit = False
        DetailInfoBool = False
        DetailStreamInfoTimer.Enabled = False
        GetInfoL = False
        SubTaskLoop1 = False

        '로딩
        PrePanel.Visible = True
        LoadingLabel.Visible = False
        OutputBox_Stream.Visible = False

        PlayPauseBTN.Enabled = True '활성/비활성(재생)
        '활성/비활성
        SeekTrackBar.Enabled = True
        VolTrackBar.Enabled = True
        StopBTN.Enabled = True
        AudioComboBox.Enabled = True
        BackwardBTN.Enabled = True
        ForwardBTN.Enabled = True
        FrameStepButton.Enabled = True
        Nowhms.Enabled = True
        Totalhms.Enabled = True

    End Sub

    Private Sub StreamFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '설정로드
        With MainFrm
            VolTrackBar.Value = .VolTrackBarStreamFrmV
            AllChToolStripMenuItem.Checked = .AllChToolStripMenuItemStreamFrmV
            LeftChToolStripMenuItem.Checked = .LeftChToolStripMenuItemStreamFrmV
            RightChToolStripMenuItem.Checked = .RightChToolStripMenuItemStreamFrmV
            rateM = .rateMStreamFrmV
            scaletempoToolStripMenuItem.Checked = .scaletempoToolStripMenuItemStreamFrmV
            extrastereoToolStripMenuItem.Checked = .extrastereoToolStripMenuItemStreamFrmV
            karaokeToolStripMenuItem.Checked = .karaokeToolStripMenuItemStreamFrmV
            VisualizeMotionVectorsToolStripMenuItem.Checked = .VisualizeMotionVectorsToolStripMenuItemStreamFrmV
            VisualizeBlockTypesToolStripMenuItem.Checked = .VisualizeBlockTypesToolStripMenuItemStreamFrmV
            FFmpegDeinterlacerToolStripMenuItem.Checked = .FFmpegDeinterlacerToolStripMenuItemStreamFrmV
            AspectOriginToolStripMenuItem.Checked = .AspectOriginToolStripMenuItemStreamFrmV
            SizeOriginToolStripMenuItem.Checked = .SizeOriginToolStripMenuItemStreamFrmV
        End With

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
        If My.Computer.FileSystem.FileExists(FunctionCls.AppInfoDirectoryPath & "\lang\" & LangXMLFV) = False Then
            MsgBox(LangXMLFV & " not found")
            GoTo LANG_SKIP
        End If

        Dim SR As New StreamReader(FunctionCls.AppInfoDirectoryPath & "\lang\" & LangXMLFV, System.Text.Encoding.UTF8)
        Dim XTR As New System.Xml.XmlTextReader(SR)
        Try
            Dim FN As String = Me.Font.Name, FNXP As String = Me.Font.Name, FS As Single = Me.Font.Size
            Do While XTR.Read
                Application.DoEvents()

                If XTR.Name = "FontName" Then FN = XTR.ReadString
                If XTR.Name = "FontNameXP" Then FNXP = XTR.ReadString
                If XTR.Name = "FontSize" Then FS = XTR.ReadString

                If Environment.OSVersion.Version.Major < 6 Then 'NT 5.X 이하
                    PreviewGroupBox.Font = New Font(FNXP, FS)
                    BPanel.Font = New Font(FNXP, FS)
                Else
                    PreviewGroupBox.Font = New Font(FN, FS)
                    BPanel.Font = New Font(FN, FS)
                End If

                If XTR.Name = "StreamFrm" Then Me.Text = XTR.ReadString
                If XTR.Name = "StreamFrmOptsToolStripMenuItem" Then OptsToolStripMenuItem.Text = XTR.ReadString
                If XTR.Name = "StreamFrmAllChToolStripMenuItem" Then AllChToolStripMenuItem.Text = XTR.ReadString
                If XTR.Name = "StreamFrmLeftChToolStripMenuItem" Then LeftChToolStripMenuItem.Text = XTR.ReadString
                If XTR.Name = "StreamFrmRightChToolStripMenuItem" Then RightChToolStripMenuItem.Text = XTR.ReadString
                If XTR.Name = "StreamFrmscaletempoToolStripMenuItem" Then scaletempoToolStripMenuItem.Text = XTR.ReadString
                If XTR.Name = "StreamFrmextrastereoToolStripMenuItem" Then extrastereoToolStripMenuItem.Text = XTR.ReadString
                If XTR.Name = "StreamFrmkaraokeToolStripMenuItem" Then karaokeToolStripMenuItem.Text = XTR.ReadString
                If XTR.Name = "StreamFrmVisualizeMotionVectorsToolStripMenuItem" Then VisualizeMotionVectorsToolStripMenuItem.Text = XTR.ReadString
                If XTR.Name = "StreamFrmVisualizeBlockTypesToolStripMenuItem" Then VisualizeBlockTypesToolStripMenuItem.Text = XTR.ReadString
                If XTR.Name = "StreamFrmFFmpegDeinterlacerToolStripMenuItem" Then FFmpegDeinterlacerToolStripMenuItem.Text = XTR.ReadString
                If XTR.Name = "StreamFrmSpDnToolStripMenuItem" Then SpDnToolStripMenuItem.Text = XTR.ReadString
                If XTR.Name = "StreamFrmSpDfToolStripMenuItem" Then SpDfToolStripMenuItem.Text = XTR.ReadString
                If XTR.Name = "StreamFrmSpDuToolStripMenuItem" Then SpDuToolStripMenuItem.Text = XTR.ReadString
                If XTR.Name = "StreamFrmPreviewGroupBox" Then PreviewGroupBox.Text = XTR.ReadString
                If XTR.Name = "StreamFrmStreamSelGroupBox" Then StreamSelGroupBox.Text = XTR.ReadString
                If XTR.Name = "StreamFrmTimeSpGroupBox" Then
                    TimeSpGroupBox.Text = XTR.ReadString
                    TimeSpButton.Text = TimeSpGroupBox.Text
                End If
                If XTR.Name = "StreamFrmSCheckBox" Then SCheckBox.Text = XTR.ReadString
                If XTR.Name = "StreamFrmECheckBox" Then ECheckBox.Text = XTR.ReadString
                If XTR.Name = "StreamFrmSTRENDCKButton" Then
                    STRCKButton.Text = XTR.ReadString
                    ENDCKButton.Text = STRCKButton.Text
                End If
                If XTR.Name = "OKBTN" Then OKBTN.Text = XTR.ReadString
                If XTR.Name = "CancelBTN" Then CancelBTN.Text = XTR.ReadString
                If XTR.Name = "StreamERRSChkEChk" Then LangCls.StreamERRSChkEChk = XTR.ReadString
                If XTR.Name = "StreamFrmCropButton" Then CropButton.Text = XTR.ReadString
                If XTR.Name = "StreamFrmCropGroupBox" Then CropGroupBox.Text = XTR.ReadString
                If XTR.Name = "StreamFrmLeftLabel" Then LeftLabel.Text = XTR.ReadString
                If XTR.Name = "StreamFrmTopLabel" Then TopLabel.Text = XTR.ReadString
                If XTR.Name = "StreamFrmBottomLabel" Then BottomLabel.Text = XTR.ReadString
                If XTR.Name = "StreamFrmRightLabel" Then RightLabel.Text = XTR.ReadString
                If XTR.Name = "StreamFrmSizeLabel" Then SizeLabel.Text = XTR.ReadString
                If XTR.Name = "StreamFrmSizeOriginToolStripMenuItem" Then SizeOriginToolStripMenuItem.Text = XTR.ReadString
                If XTR.Name = "StreamFrmAspectOriginToolStripMenuItem" Then AspectOriginToolStripMenuItem.Text = XTR.ReadString
            Loop
        Catch ex As Exception
            MsgBox("LANG_LOAD_ERROR :" & ex.Message)
        Finally
            XTR.Close()
            SR.Close()
        End Try
LANG_SKIP:
        '=========================================

        '재생중인파일 이름
        Me.Text = MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(0).Text & " - " & Me.Text

        '핸들
        MainFrmHWNDV = MainFrm.MainFrmHWNDV

        '재생속도
        SpeedXVToolStripMenuItem.Text = Format(rateM, "0.0") & "x"

        '하단 상태바
        ToolStripStatusLabel1.Text = ""

        '비율
        If AspectOriginToolStripMenuItem.Checked = True Then
            PrePanel1.Cursor = Cursors.Default
            LeftPanel.Cursor = Cursors.Default
            TopPanel.Cursor = Cursors.Default
            RightPanel.Cursor = Cursors.Default
            BottomPanel.Cursor = Cursors.Default
        ElseIf SizeOriginToolStripMenuItem.Checked = True Then
            PrePanel1.Cursor = Cursors.SizeAll
            LeftPanel.Cursor = Cursors.SizeAll
            TopPanel.Cursor = Cursors.SizeAll
            RightPanel.Cursor = Cursors.SizeAll
            BottomPanel.Cursor = Cursors.SizeAll
        End If

        '======================
        '잘라내기
        '======================
        If MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(8).Text = "None" Then '비디오가 없음
            SZH = 1
            SZW = 1
            LeftNumericUpDown.Maximum = 0
            RightNumericUpDown.Maximum = 0
            TopNumericUpDown.Maximum = 0
            BottomNumericUpDown.Maximum = 0
            LeftNumericUpDown.Value = 0
            TopNumericUpDown.Value = 0
            RightNumericUpDown.Value = 0
            BottomNumericUpDown.Value = 0
            SizeTextBox.Text = "0x0"
            CropGroupBox.Enabled = False
        Else
            Try
                Dim SizeTextBoxV As String = Split(MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(12).Text, ",")(0)
                SZH = Split(SizeTextBoxV, "x")(1)
                SZW = Split(SizeTextBoxV, "x")(0)
                LeftNumericUpDown.Minimum = 0
                RightNumericUpDown.Minimum = 0
                TopNumericUpDown.Minimum = 0
                BottomNumericUpDown.Minimum = 0
                LeftNumericUpDown.Maximum = SZW - RightNumericUpDown.Value
                RightNumericUpDown.Maximum = SZW - LeftNumericUpDown.Value
                TopNumericUpDown.Maximum = SZH - BottomNumericUpDown.Value
                BottomNumericUpDown.Maximum = SZH - TopNumericUpDown.Value
                LeftNumericUpDown.Value = Split(MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(15).Text, ",")(0)
                TopNumericUpDown.Value = Split(MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(15).Text, ",")(1)
                RightNumericUpDown.Value = Split(MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(15).Text, ",")(2)
                BottomNumericUpDown.Value = Split(MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(15).Text, ",")(3)
                SizeTextBox.Text = (SZW - LeftNumericUpDown.Value - RightNumericUpDown.Value) & "x" & (SZH - TopNumericUpDown.Value - BottomNumericUpDown.Value)
                CropGroupBox.Enabled = True
            Catch ex As Exception
                SZH = 1
                SZW = 1
                LeftNumericUpDown.Maximum = 0
                RightNumericUpDown.Maximum = 0
                TopNumericUpDown.Maximum = 0
                BottomNumericUpDown.Maximum = 0
                LeftNumericUpDown.Value = 0
                TopNumericUpDown.Value = 0
                RightNumericUpDown.Value = 0
                BottomNumericUpDown.Value = 0
                SizeTextBox.Text = "0x0"
                CropGroupBox.Enabled = False
            End Try
        End If

        '======================
        '오디오스트림
        '======================

        '오디오스트림
        ASTRM = False

        '리스트뷰에 있는 오디오를 목록화
        Dim LvAudioList As String = MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(9).Text
        Dim ia2 As Long = 0, iia2 As Long = 0
        Dim ta2 As String = ""

        AudioComboBox.Items.Clear()
        Do
            ia2 = 1
            iia2 = 1
            ta2 = ""
            If InStr(ia2, LvAudioList, "Stream #", CompareMethod.Text) Then
                iia2 = InStr(ia2, LvAudioList, "Stream #", CompareMethod.Text)
                If InStr(iia2, LvAudioList, "|", CompareMethod.Text) Then
                    ia2 = InStr(iia2, LvAudioList, "|", CompareMethod.Text)
                    ta2 = Mid(LvAudioList, iia2, ia2 - iia2 - 1)
                End If
            Else
                ia2 = ia2 + 1
            End If

            If ta2 <> "" Then
                AudioComboBox.Items.Add(ta2)
                LvAudioList = Replace(LvAudioList, ta2, "")
            End If

            Application.DoEvents()
        Loop Until (ta2 = "")

        '오디오 스트림 선택
        For AudioStreamSelV = 1 To AudioComboBox.Items.Count
            Try
                If MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(4).Text = Split(AudioComboBox.Items(AudioStreamSelV - 1), ":")(0) Then
                    AudioComboBox.SelectedIndex = AudioStreamSelV - 1
                End If
            Catch ex As Exception
            End Try
        Next

        '스트림 선택 그룹박스 활성화 관련
        If AudioComboBox.Items.Count = 0 Then
            StreamSelGroupBox.Enabled = False
        Else
            StreamSelGroupBox.Enabled = True
        End If

        '======================
        '구간설정
        '======================
        Dim PTimeInfo As String = MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(11).Text

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
                SHTextBox.Text = Split(t, ":")(0)
                SMTextBox.Text = Split(t, ":")(1)
                SSTextBox.Text = Split(Split(t, ":")(2), ".")(0)
                SMSTextBox.Text = Split(t, ".")(1)
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
                EHTextBox.Text = Split(t, ":")(0)
                EMTextBox.Text = Split(t, ":")(1)
                ESTextBox.Text = Split(Split(t, ":")(2), ".")(0)
                EMSTextBox.Text = Split(t, ".")(1)
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
            PHHMMSSEMSV = t
        End If
        '체크버튼 활성화 여부
        If SHTextBox.Text = "00" AndAlso SMTextBox.Text = "00" AndAlso SSTextBox.Text = "00" AndAlso SMSTextBox.Text = "00" Then
            SCheckBox.Checked = False
        Else
            SCheckBox.Checked = True
        End If
        If (EHTextBox.Text = "00" AndAlso EMTextBox.Text = "00" AndAlso ESTextBox.Text = "00" AndAlso EMSTextBox.Text = "00") OrElse _
        (EHTextBox.Text & ":" & EMTextBox.Text & ":" & ESTextBox.Text & "." & EMSTextBox.Text = PHHMMSSEMSV) Then
            ECheckBox.Checked = False
        Else
            ECheckBox.Checked = True
        End If
        '구간설정 활성화 여부
        If MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(8).Text = "None" AndAlso MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(9).Text = "None" Then '비디오, 오디오가 없음
            TimeSpGroupBox.Enabled = False
        Else
            TimeSpGroupBox.Enabled = True
        End If
    
    End Sub

    Private Sub StreamFrm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        WinAPI.TerminateProcess(ProcessHandle_Stream, 0&) '프로세스 종료
        If GetCurrentProcess <> Nothing Then SetPriorityClass(GetCurrentProcess, PriorityClass.NORMAL_PRIORITY_CLASS) '노멀 우선순위로
        Do Until ProcessEChkB = True
            Application.DoEvents()
        Loop

        '설정저장
        With MainFrm
            .VolTrackBarStreamFrmV = VolTrackBar.Value
            .AllChToolStripMenuItemStreamFrmV = AllChToolStripMenuItem.Checked
            .LeftChToolStripMenuItemStreamFrmV = LeftChToolStripMenuItem.Checked
            .RightChToolStripMenuItemStreamFrmV = RightChToolStripMenuItem.Checked
            .rateMStreamFrmV = rateM
            .scaletempoToolStripMenuItemStreamFrmV = scaletempoToolStripMenuItem.Checked
            .extrastereoToolStripMenuItemStreamFrmV = extrastereoToolStripMenuItem.Checked
            .karaokeToolStripMenuItemStreamFrmV = karaokeToolStripMenuItem.Checked
            .VisualizeMotionVectorsToolStripMenuItemStreamFrmV = VisualizeMotionVectorsToolStripMenuItem.Checked
            .VisualizeBlockTypesToolStripMenuItemStreamFrmV = VisualizeBlockTypesToolStripMenuItem.Checked
            .FFmpegDeinterlacerToolStripMenuItemStreamFrmV = FFmpegDeinterlacerToolStripMenuItem.Checked
            .AspectOriginToolStripMenuItemStreamFrmV = AspectOriginToolStripMenuItem.Checked
            .SizeOriginToolStripMenuItemStreamFrmV = SizeOriginToolStripMenuItem.Checked
        End With

    End Sub

    Private Sub NowhmsTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NowhmsTimer.Tick

        Nowhms.Text = FunctionCls.TIME_TO_HMSMSTIME(NowTimeSec, True)


    End Sub

    Private Sub FrameStepButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FrameStepButton.Click
        PreviewGroupBox.Focus()
        MsgSend("frame_step ")
    End Sub

    Private Sub VolTrackBar_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles VolTrackBar.MouseDown
        SoundM.Enabled = True
    End Sub

    Private Sub VolTrackBar_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles VolTrackBar.MouseUp
        SoundM.Enabled = False

        Dim VTBV As Integer = Int(((e.X - 8) / (VolTrackBar.Width - (8 * 2))) * VolTrackBar.Maximum)
        If VTBV >= VolTrackBar.Maximum Then
            VolTrackBar.Value = VolTrackBar.Maximum
        ElseIf VTBV <= VolTrackBar.Minimum Then
            VolTrackBar.Value = VolTrackBar.Minimum
        Else
            VolTrackBar.Value = VTBV
        End If

        MsgSend("pausing_keep_force volume " & VolTrackBar.Value & " 1 ")
    End Sub

    Private Sub SoundM_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SoundM.Tick
        MsgSend("pausing_keep_force volume " & VolTrackBar.Value & " 1 ")
    End Sub

    Private Sub VolTrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VolTrackBar.Scroll

    End Sub

    Private Sub SeekTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeekTimer.Tick

        Try
            If MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(3).Text = "ASF" Then 'ASF 형식은 퍼센트로.
                If SeekTrackBar.Maximum >= ((GETPP_PV * SeekTrackBar.Maximum) / 100) Then
                    SeekTrackBar.Value = (GETPP_PV * SeekTrackBar.Maximum) / 100
                End If
            Else
                If SeekTrackBar.Maximum >= NowTimeSec Then
                    SeekTrackBar.Value = NowTimeSec
                End If
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub SeekTrackBar_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles SeekTrackBar.MouseDown
        SEEKSTA = True
        SeekTimer.Enabled = False
    End Sub


    Private Sub SeekTrackBar_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles SeekTrackBar.MouseUp

        If MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(3).Text <> "MPEGTS" Then MsgSend("pausing_keep_force volume 0 1 ")

        Dim VTBV As Integer = Int(((e.X - 8) / (SeekTrackBar.Width - (8 * 2))) * SeekTrackBar.Maximum)
        If VTBV >= SeekTrackBar.Maximum Then
            VTBV = SeekTrackBar.Minimum
        ElseIf VTBV <= SeekTrackBar.Minimum Then
            VTBV = SeekTrackBar.Minimum
        End If

        If MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(3).Text = "ASF" OrElse MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(3).Text = "MPEGTS" Then '디먹서 변경으로 인해 MPEGTS도 퍼센트시크
            MsgSend("pausing_keep seek " & (VTBV / SeekTrackBar.Maximum) * 100 & " 1 ")
        Else
            MsgSend("pausing_keep seek " & VTBV & " 2 ")
        End If

        MsgSend("pausing_keep_force volume " & VolTrackBar.Value & " 1 ")

        SEEKSTA = False
        SeekTimer.Enabled = True

    End Sub

    Private Sub SeekTrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeekTrackBar.Scroll
        NowTimeSec = SeekTrackBar.Value
    End Sub

    Private Sub StreamFrm_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        SetAsp()
    End Sub

    Private Sub SpDnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpDnToolStripMenuItem.Click

        If rateM > 0 Then
            rateM = Format(rateM - 0.1, "0.0")
            SpeedXVToolStripMenuItem.Text = Format(rateM, "0.0") & "x"
        End If
        MsgSend("pausing_keep_force speed_set " & rateM & " ")

    End Sub

    Private Sub SpDuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpDuToolStripMenuItem.Click

        If rateM < 100 Then
            rateM = Format(rateM + 0.1, "0.0")
            SpeedXVToolStripMenuItem.Text = Format(rateM, "0.0") & "x"
        End If
        MsgSend("pausing_keep_force speed_set " & rateM & " ")

    End Sub

    Private Sub PitchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles scaletempoToolStripMenuItem.Click
        RefreshFN()
    End Sub

    Private Sub AllChToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllChToolStripMenuItem.Click
        AllChToolStripMenuItem.Checked = True
        LeftChToolStripMenuItem.Checked = False
        RightChToolStripMenuItem.Checked = False
        MsgSend("pausing_keep_force balance 0 1 ")
    End Sub

    Private Sub LeftChToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeftChToolStripMenuItem.Click
        AllChToolStripMenuItem.Checked = False
        LeftChToolStripMenuItem.Checked = True
        RightChToolStripMenuItem.Checked = False
        MsgSend("pausing_keep_force balance -1 1 ")
    End Sub

    Private Sub RightChToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RightChToolStripMenuItem.Click
        AllChToolStripMenuItem.Checked = False
        LeftChToolStripMenuItem.Checked = False
        RightChToolStripMenuItem.Checked = True
        MsgSend("pausing_keep_force balance 1 1 ")
    End Sub

    Private Sub extrastereoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles extrastereoToolStripMenuItem.Click
        RefreshFN()
    End Sub

    Private Sub karaokeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles karaokeToolStripMenuItem.Click
        RefreshFN()
    End Sub

    Private Sub VisualizeMotionVectorsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VisualizeMotionVectorsToolStripMenuItem.Click
        RefreshFN()
    End Sub

    Private Sub VisualizeBlockTypesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VisualizeBlockTypesToolStripMenuItem.Click
        RefreshFN()
    End Sub

    Private Sub FFmpegDeinterlacerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FFmpegDeinterlacerToolStripMenuItem.Click
        RefreshFN()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If StopBTN.Enabled = True Then
            WinAPI.TerminateProcess(ProcessHandle_Stream, 0&)
        Else
            PlayPauseBTN_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub BackwardBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackwardBTN.Click

    End Sub

    Private Sub ASListBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ASListBox.SelectedIndexChanged

    End Sub

    Private Sub AudioComboBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AudioComboBox.Click

    End Sub

    Private Sub AudioComboBox_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles AudioComboBox.SelectionChangeCommitted
        If ASListBox.Items.Count > AudioComboBox.SelectedIndex Then

            '설정
            MsgSend("pausing_keep_force switch_audio " & ASListBox.Items.Item(AudioComboBox.SelectedIndex) & " ")
            MsgSend("pausing_keep_force volume " & VolTrackBar.Value & " 1 ")
            MsgSend("pausing_keep seek " & NowTimeSec & " 2 ")

            '밸런스
            If AllChToolStripMenuItem.Checked = True Then
                MsgSend("pausing_keep_force balance 0 1 ")
            ElseIf LeftChToolStripMenuItem.Checked = True Then
                MsgSend("pausing_keep_force balance -1 1 ")
            ElseIf RightChToolStripMenuItem.Checked = True Then
                MsgSend("pausing_keep_force balance 1 1 ")
            End If

        End If
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKBTN.Click

        '오류체크
        If SHTextBox.Text & ":" & SMTextBox.Text & ":" & SSTextBox.Text & "." & SMSTextBox.Text > EHTextBox.Text & ":" & EMTextBox.Text & ":" & ESTextBox.Text & "." & EMSTextBox.Text _
        AndAlso SCheckBox.Checked = True AndAlso ECheckBox.Checked = True Then
            MsgBox(LangCls.StreamERRSChkEChk)
            Exit Sub
        End If

        '오디오 스트림 지정
        If AudioComboBox.Items.Count <> 0 Then
            If InStr(AudioComboBox.Items.Item(AudioComboBox.SelectedIndex), ":", CompareMethod.Text) <> 0 Then
                Try
                    MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(4).Text = Split(AudioComboBox.Items.Item(AudioComboBox.SelectedIndex), ":")(0)
                Catch ex As Exception
                End Try
            End If
        End If

        '구간 설정
        If SHTextBox.Text & ":" & SMTextBox.Text & ":" & SSTextBox.Text & "." & SMSTextBox.Text = "00:00:00.00" AndAlso SCheckBox.Checked = True Then
            SCheckBox.Checked = False
        End If
        If EHTextBox.Text & ":" & EMTextBox.Text & ":" & ESTextBox.Text & "." & EMSTextBox.Text = "00:00:00.00" AndAlso ECheckBox.Checked = True Then
            ECheckBox.Checked = False
        End If
        If SCheckBox.Checked = True AndAlso ECheckBox.Checked = True Then
            MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(11).Text = PHHMMSSEMSV & _
            " [" & SHTextBox.Text & ":" & SMTextBox.Text & ":" & SSTextBox.Text & "." & SMSTextBox.Text & _
            " - " & EHTextBox.Text & ":" & EMTextBox.Text & ":" & ESTextBox.Text & "." & EMSTextBox.Text & "]"
        ElseIf SCheckBox.Checked = True AndAlso ECheckBox.Checked = False Then
            MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(11).Text = PHHMMSSEMSV & _
        " [" & SHTextBox.Text & ":" & SMTextBox.Text & ":" & SSTextBox.Text & "." & SMSTextBox.Text & _
        " - " & PHHMMSSEMSV & "]"
        ElseIf SCheckBox.Checked = False AndAlso ECheckBox.Checked = True Then
            MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(11).Text = PHHMMSSEMSV & _
        " [00:00:00.00" & _
        " - " & EHTextBox.Text & ":" & EMTextBox.Text & ":" & ESTextBox.Text & "." & EMSTextBox.Text & "]"
        ElseIf SCheckBox.Checked = False AndAlso ECheckBox.Checked = False Then
            MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(11).Text = PHHMMSSEMSV & _
        " [00:00:00.00 - 00:00:00.00]"
        End If

        '잘라내기
        MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(15).Text = LeftNumericUpDown.Value & "," & _
                                                                        TopNumericUpDown.Value & "," & _
                                                                        RightNumericUpDown.Value & "," & _
                                                                        BottomNumericUpDown.Value

        '새로고침
        MainFrm.GET_AVINFO(MainFrm.SelIndex)
        Me.Close()

    End Sub

    Private Sub SCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SCheckBox.CheckedChanged
        If SCheckBox.Checked = False Then

            SHTextBox.Enabled = False
            SMTextBox.Enabled = False
            SSTextBox.Enabled = False
            SMSTextBox.Enabled = False
            SP1Label.Enabled = False
            SP2Label.Enabled = False
            SP3Label.Enabled = False

        ElseIf SCheckBox.Checked = True Then

            SHTextBox.Enabled = True
            SMTextBox.Enabled = True
            SSTextBox.Enabled = True
            SMSTextBox.Enabled = True
            SP1Label.Enabled = True
            SP2Label.Enabled = True
            SP3Label.Enabled = True

        End If
    End Sub

    Private Sub ECheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ECheckBox.CheckedChanged
        If ECheckBox.Checked = False Then

            EHTextBox.Enabled = False
            EMTextBox.Enabled = False
            ESTextBox.Enabled = False
            EMSTextBox.Enabled = False
            EP1Label.Enabled = False
            EP2Label.Enabled = False
            EP3Label.Enabled = False

        ElseIf ECheckBox.Checked = True Then

            EHTextBox.Enabled = True
            EMTextBox.Enabled = True
            ESTextBox.Enabled = True
            EMSTextBox.Enabled = True
            EP1Label.Enabled = True
            EP2Label.Enabled = True
            EP3Label.Enabled = True

        End If
    End Sub

    Private Sub AudioComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AudioComboBox.SelectedIndexChanged

    End Sub

    Private Sub SHTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SHTextBox.KeyPress
        If FunctionCls.InputCheck_NUMBER(e, False, False) = True Then e.Handled = True
    End Sub

    Private Sub SMTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SMTextBox.KeyPress
        If FunctionCls.InputCheck_NUMBER(e, False, False) = True Then e.Handled = True
    End Sub

    Private Sub SSTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SSTextBox.KeyPress
        If FunctionCls.InputCheck_NUMBER(e, False, False) = True Then e.Handled = True
    End Sub

    Private Sub SMSTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SMSTextBox.KeyPress
        If FunctionCls.InputCheck_NUMBER(e, False, False) = True Then e.Handled = True
    End Sub

    Private Sub EHTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles EHTextBox.KeyPress
        If FunctionCls.InputCheck_NUMBER(e, False, False) = True Then e.Handled = True
    End Sub

    Private Sub EMTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles EMTextBox.KeyPress
        If FunctionCls.InputCheck_NUMBER(e, False, False) = True Then e.Handled = True
    End Sub

    Private Sub ESTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ESTextBox.KeyPress
        If FunctionCls.InputCheck_NUMBER(e, False, False) = True Then e.Handled = True
    End Sub

    Private Sub EMSTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles EMSTextBox.KeyPress
        If FunctionCls.InputCheck_NUMBER(e, False, False) = True Then e.Handled = True
    End Sub

    Private Sub SHTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles SHTextBox.LostFocus
        SHTextBox.Text = FunctionCls.Input_nint_zero(SHTextBox.Text)
    End Sub

    Private Sub SMTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles SMTextBox.LostFocus
        SMTextBox.Text = FunctionCls.Input_nint_zero(SMTextBox.Text)
    End Sub

    Private Sub SSTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles SSTextBox.LostFocus
        SSTextBox.Text = FunctionCls.Input_nint_zero(SSTextBox.Text)
    End Sub

    Private Sub SMSTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles SMSTextBox.LostFocus
        SMSTextBox.Text = FunctionCls.Input_nint_zero(SMSTextBox.Text)
    End Sub

    Private Sub EHTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles EHTextBox.LostFocus
        EHTextBox.Text = FunctionCls.Input_nint_zero(EHTextBox.Text)
    End Sub

    Private Sub EMTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles EMTextBox.LostFocus
        EMTextBox.Text = FunctionCls.Input_nint_zero(EMTextBox.Text)
    End Sub

    Private Sub ESTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ESTextBox.LostFocus
        ESTextBox.Text = FunctionCls.Input_nint_zero(ESTextBox.Text)
    End Sub

    Private Sub EMSTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles EMSTextBox.LostFocus
        EMSTextBox.Text = FunctionCls.Input_nint_zero(EMSTextBox.Text)
    End Sub

    Private Sub SpDfToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpDfToolStripMenuItem.Click

        rateM = 1.0
        SpeedXVToolStripMenuItem.Text = Format(rateM, "0.0") & "x"
        MsgSend("pausing_keep_force speed_set " & rateM & " ")

    End Sub

    Private Sub STRCKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STRCKButton.Click
        PreviewGroupBox.Focus()
        Try
            SCheckBox.Checked = True
            SHTextBox.Text = Split(Nowhms.Text, ":")(0)
            SMTextBox.Text = Split(Nowhms.Text, ":")(1)
            SSTextBox.Text = Split(Split(Nowhms.Text, ":")(2), ".")(0)
            SMSTextBox.Text = Split(Nowhms.Text, ".")(1)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub ENDCKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ENDCKButton.Click
        PreviewGroupBox.Focus()
        Try
            ECheckBox.Checked = True
            EHTextBox.Text = Split(Nowhms.Text, ":")(0)
            EMTextBox.Text = Split(Nowhms.Text, ":")(1)
            ESTextBox.Text = Split(Split(Nowhms.Text, ":")(2), ".")(0)
            EMSTextBox.Text = Split(Nowhms.Text, ".")(1)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub CancelBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBTN.Click
        Me.Close()
    End Sub

    Private Sub SHTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SHTextBox.TextChanged

    End Sub

    Private Sub SMSTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SMSTextBox.TextChanged

    End Sub

    Private Sub SetAsp()

        'MPLAYER 멈춤 방지용.
        Application.DoEvents()
        Dim OriWidthSz As Integer = 0
        Dim OriHeightSz As Integer = 0
        Try
            OriWidthSz = Split(Split(MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(12).Text, ",")(0), "x")(0)
            OriHeightSz = Split(Split(MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(12).Text, ",")(0), "x")(1)
        Catch ex As Exception
        End Try

        Dim XSz As Single = 0.0, YSz As Single = 0.0, PXSz As Single = 0.0, PYSz As Single = 0.0

        'If OriWidthSz <= TPrePanel.Width And OriHeightSz <= TPrePanel.Height Then
        '    XSz = OriWidthSz
        '    YSz = OriHeightSz
        '    PXSz = (TPrePanel.Width - OriWidthSz) / 2
        '    PYSz = (TPrePanel.Height - OriHeightSz) / 2

        'Else '크면 비례식 에 맞게 리사이즈

        If (OriWidthSz * InTPrePanel.Height) / OriHeightSz <= InTPrePanel.Width Then
            XSz = (OriWidthSz * InTPrePanel.Height) / OriHeightSz
            YSz = InTPrePanel.Height
            PXSz = (InTPrePanel.Width - (OriWidthSz * InTPrePanel.Height) / OriHeightSz) / 2
            PYSz = 0

        ElseIf (OriHeightSz * InTPrePanel.Width) / OriWidthSz <= InTPrePanel.Height Then
            XSz = InTPrePanel.Width
            YSz = (OriHeightSz * InTPrePanel.Width) / OriWidthSz
            PXSz = 0
            PYSz = (InTPrePanel.Height - (OriHeightSz * InTPrePanel.Width) / OriWidthSz) / 2

        Else
            XSz = InTPrePanel.Width
            YSz = InTPrePanel.Height
            PXSz = 0
            PYSz = 0

        End If

        'End If

        If SizeOriginToolStripMenuItem.Checked = True Then
            PrePanel.Width = OriWidthSz
            PrePanel.Height = OriHeightSz
            PrePanel.Left = (InTPrePanel.Width - OriWidthSz) / 2
            PrePanel.Top = (InTPrePanel.Height - OriHeightSz) / 2
            PrePanel1.Width = OriWidthSz
            PrePanel1.Height = OriHeightSz
            PrePanel1.Left = 0
            PrePanel1.Top = 0
        ElseIf AspectOriginToolStripMenuItem.Checked = True Then
            PrePanel.Width = Int(XSz)
            PrePanel.Height = Int(YSz)
            PrePanel.Left = Int(PXSz)
            PrePanel.Top = Int(PYSz)
            PrePanel1.Width = Int(XSz)
            PrePanel1.Height = Int(YSz)
            PrePanel1.Left = 0
            PrePanel1.Top = 0
        End If


        'Crop
        If MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(8).Text = "None" Then '비디오가 없음
            TopPanel.Height = 0
            BottomPanel.Height = 0
            LeftPanel.Width = 0
            RightPanel.Width = 0
        Else
            TopPanel.Height = (PrePanel1.Height / SZH) * TopNumericUpDown.Value
            BottomPanel.Height = (PrePanel1.Height / SZH) * BottomNumericUpDown.Value
            LeftPanel.Width = (PrePanel1.Width / SZW) * LeftNumericUpDown.Value
            RightPanel.Width = (PrePanel1.Width / SZW) * RightNumericUpDown.Value

            TopPanel.Refresh()
            BottomPanel.Refresh()
            LeftPanel.Refresh()
            RightPanel.Refresh()
        End If

    End Sub

    Private Sub TimeSpButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeSpButton.Click
        PreviewGroupBox.Focus()
        CropGroupBox.Visible = False
        If TimeSpGroupBox.Visible = False Then
            TimeSpGroupBox.Visible = True
        Else
            TimeSpGroupBox.Visible = False
        End If
        SetAsp()
    End Sub

    Private Sub CropButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CropButton.Click
        PreviewGroupBox.Focus()
        TimeSpGroupBox.Visible = False
        If CropGroupBox.Visible = False Then
            CropGroupBox.Visible = True
        Else
            CropGroupBox.Visible = False
        End If
        SetAsp()
    End Sub

    Private Sub TopNumericUpDown_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TopNumericUpDown.KeyUp
        TopPanel.Height = (PrePanel1.Height / SZH) * TopNumericUpDown.Value
        TopPanel.Refresh()
        SizeTextBox.Text = (SZW - LeftNumericUpDown.Value - RightNumericUpDown.Value) & "x" & (SZH - TopNumericUpDown.Value - BottomNumericUpDown.Value)
        '-------
        LeftNumericUpDown.Maximum = SZW - RightNumericUpDown.Value
        RightNumericUpDown.Maximum = SZW - LeftNumericUpDown.Value
        TopNumericUpDown.Maximum = SZH - BottomNumericUpDown.Value
        BottomNumericUpDown.Maximum = SZH - TopNumericUpDown.Value
        LeftNumericUpDown.Minimum = 0
        RightNumericUpDown.Minimum = 0
        TopNumericUpDown.Minimum = 0
        BottomNumericUpDown.Minimum = 0
    End Sub

    Private Sub TopNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TopNumericUpDown.LostFocus
        TopNumericUpDown.Text = TopNumericUpDown.Value
    End Sub

    Private Sub TopNumericUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TopNumericUpDown.ValueChanged
        TopPanel.Height = (PrePanel1.Height / SZH) * TopNumericUpDown.Value
        TopPanel.Refresh()
        SizeTextBox.Text = (SZW - LeftNumericUpDown.Value - RightNumericUpDown.Value) & "x" & (SZH - TopNumericUpDown.Value - BottomNumericUpDown.Value)
        '-------
        LeftNumericUpDown.Maximum = SZW - RightNumericUpDown.Value
        RightNumericUpDown.Maximum = SZW - LeftNumericUpDown.Value
        TopNumericUpDown.Maximum = SZH - BottomNumericUpDown.Value
        BottomNumericUpDown.Maximum = SZH - TopNumericUpDown.Value
        LeftNumericUpDown.Minimum = 0
        RightNumericUpDown.Minimum = 0
        TopNumericUpDown.Minimum = 0
        BottomNumericUpDown.Minimum = 0
    End Sub

    Private Sub BottomNumericUpDown_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BottomNumericUpDown.KeyUp
        BottomPanel.Height = (PrePanel1.Height / SZH) * BottomNumericUpDown.Value
        BottomPanel.Refresh()
        SizeTextBox.Text = (SZW - LeftNumericUpDown.Value - RightNumericUpDown.Value) & "x" & (SZH - TopNumericUpDown.Value - BottomNumericUpDown.Value)
        '-------
        LeftNumericUpDown.Maximum = SZW - RightNumericUpDown.Value
        RightNumericUpDown.Maximum = SZW - LeftNumericUpDown.Value
        TopNumericUpDown.Maximum = SZH - BottomNumericUpDown.Value
        BottomNumericUpDown.Maximum = SZH - TopNumericUpDown.Value
        LeftNumericUpDown.Minimum = 0
        RightNumericUpDown.Minimum = 0
        TopNumericUpDown.Minimum = 0
        BottomNumericUpDown.Minimum = 0
    End Sub

    Private Sub BottomNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BottomNumericUpDown.LostFocus
        BottomNumericUpDown.Text = BottomNumericUpDown.Value
    End Sub

    Private Sub BottomNumericUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BottomNumericUpDown.ValueChanged
        BottomPanel.Height = (PrePanel1.Height / SZH) * BottomNumericUpDown.Value
        BottomPanel.Refresh()
        SizeTextBox.Text = (SZW - LeftNumericUpDown.Value - RightNumericUpDown.Value) & "x" & (SZH - TopNumericUpDown.Value - BottomNumericUpDown.Value)
        '-------
        LeftNumericUpDown.Maximum = SZW - RightNumericUpDown.Value
        RightNumericUpDown.Maximum = SZW - LeftNumericUpDown.Value
        TopNumericUpDown.Maximum = SZH - BottomNumericUpDown.Value
        BottomNumericUpDown.Maximum = SZH - TopNumericUpDown.Value
        LeftNumericUpDown.Minimum = 0
        RightNumericUpDown.Minimum = 0
        TopNumericUpDown.Minimum = 0
        BottomNumericUpDown.Minimum = 0
    End Sub

    Private Sub LeftNumericUpDown_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LeftNumericUpDown.KeyUp
        LeftPanel.Width = (PrePanel1.Width / SZW) * LeftNumericUpDown.Value
        LeftPanel.Refresh()
        SizeTextBox.Text = (SZW - LeftNumericUpDown.Value - RightNumericUpDown.Value) & "x" & (SZH - TopNumericUpDown.Value - BottomNumericUpDown.Value)
        '-------
        LeftNumericUpDown.Maximum = SZW - RightNumericUpDown.Value
        RightNumericUpDown.Maximum = SZW - LeftNumericUpDown.Value
        TopNumericUpDown.Maximum = SZH - BottomNumericUpDown.Value
        BottomNumericUpDown.Maximum = SZH - TopNumericUpDown.Value
        LeftNumericUpDown.Minimum = 0
        RightNumericUpDown.Minimum = 0
        TopNumericUpDown.Minimum = 0
        BottomNumericUpDown.Minimum = 0
    End Sub

    Private Sub LeftNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles LeftNumericUpDown.LostFocus
        LeftNumericUpDown.Text = LeftNumericUpDown.Value
    End Sub

    Private Sub LeftNumericUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeftNumericUpDown.ValueChanged
        LeftPanel.Width = (PrePanel1.Width / SZW) * LeftNumericUpDown.Value
        LeftPanel.Refresh()
        SizeTextBox.Text = (SZW - LeftNumericUpDown.Value - RightNumericUpDown.Value) & "x" & (SZH - TopNumericUpDown.Value - BottomNumericUpDown.Value)
        '-------
        LeftNumericUpDown.Maximum = SZW - RightNumericUpDown.Value
        RightNumericUpDown.Maximum = SZW - LeftNumericUpDown.Value
        TopNumericUpDown.Maximum = SZH - BottomNumericUpDown.Value
        BottomNumericUpDown.Maximum = SZH - TopNumericUpDown.Value
        LeftNumericUpDown.Minimum = 0
        RightNumericUpDown.Minimum = 0
        TopNumericUpDown.Minimum = 0
        BottomNumericUpDown.Minimum = 0
    End Sub

    Private Sub RightNumericUpDown_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles RightNumericUpDown.KeyUp
        RightPanel.Width = (PrePanel1.Width / SZW) * RightNumericUpDown.Value
        RightPanel.Refresh()
        SizeTextBox.Text = (SZW - LeftNumericUpDown.Value - RightNumericUpDown.Value) & "x" & (SZH - TopNumericUpDown.Value - BottomNumericUpDown.Value)
        '-------
        LeftNumericUpDown.Maximum = SZW - RightNumericUpDown.Value
        RightNumericUpDown.Maximum = SZW - LeftNumericUpDown.Value
        TopNumericUpDown.Maximum = SZH - BottomNumericUpDown.Value
        BottomNumericUpDown.Maximum = SZH - TopNumericUpDown.Value
        LeftNumericUpDown.Minimum = 0
        RightNumericUpDown.Minimum = 0
        TopNumericUpDown.Minimum = 0
        BottomNumericUpDown.Minimum = 0
    End Sub

    Private Sub RightNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles RightNumericUpDown.LostFocus
        RightNumericUpDown.Text = RightNumericUpDown.Value
    End Sub

    Private Sub RightNumericUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RightNumericUpDown.ValueChanged
        RightPanel.Width = (PrePanel1.Width / SZW) * RightNumericUpDown.Value
        RightPanel.Refresh()
        SizeTextBox.Text = (SZW - LeftNumericUpDown.Value - RightNumericUpDown.Value) & "x" & (SZH - TopNumericUpDown.Value - BottomNumericUpDown.Value)
        '-------
        LeftNumericUpDown.Maximum = SZW - RightNumericUpDown.Value
        RightNumericUpDown.Maximum = SZW - LeftNumericUpDown.Value
        TopNumericUpDown.Maximum = SZH - BottomNumericUpDown.Value
        BottomNumericUpDown.Maximum = SZH - TopNumericUpDown.Value
        LeftNumericUpDown.Minimum = 0
        RightNumericUpDown.Minimum = 0
        TopNumericUpDown.Minimum = 0
        BottomNumericUpDown.Minimum = 0
    End Sub

    Private Sub AspectOriginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AspectOriginToolStripMenuItem.Click
        AspectOriginToolStripMenuItem.Checked = True
        SizeOriginToolStripMenuItem.Checked = False
        PrePanel1.Cursor = Cursors.Default
        LeftPanel.Cursor = Cursors.Default
        TopPanel.Cursor = Cursors.Default
        RightPanel.Cursor = Cursors.Default
        BottomPanel.Cursor = Cursors.Default
        SetAsp()
    End Sub

    Private Sub SizeOriginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SizeOriginToolStripMenuItem.Click
        AspectOriginToolStripMenuItem.Checked = False
        SizeOriginToolStripMenuItem.Checked = True
        PrePanel1.Cursor = Cursors.SizeAll
        LeftPanel.Cursor = Cursors.SizeAll
        TopPanel.Cursor = Cursors.SizeAll
        RightPanel.Cursor = Cursors.SizeAll
        BottomPanel.Cursor = Cursors.SizeAll
        SetAsp()
    End Sub

    Private Sub PrePanel1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PrePanel1.MouseDown
        If SizeOriginToolStripMenuItem.Checked = True Then
            WinAPI.ReleaseCapture()
            WinAPI.SendMessage(PrePanel.Handle, WinAPI.WM_NCLBUTTONDOWN, WinAPI.HTCAPTION, 0)
        End If
    End Sub

    Private Sub TopPanel_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TopPanel.MouseDown
        If SizeOriginToolStripMenuItem.Checked = True Then
            WinAPI.ReleaseCapture()
            WinAPI.SendMessage(PrePanel.Handle, WinAPI.WM_NCLBUTTONDOWN, WinAPI.HTCAPTION, 0)
        End If
    End Sub

    Private Sub LeftPanel_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LeftPanel.MouseDown
        If SizeOriginToolStripMenuItem.Checked = True Then
            WinAPI.ReleaseCapture()
            WinAPI.SendMessage(PrePanel.Handle, WinAPI.WM_NCLBUTTONDOWN, WinAPI.HTCAPTION, 0)
        End If
    End Sub

    Private Sub BottomPanel_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BottomPanel.MouseDown
        If SizeOriginToolStripMenuItem.Checked = True Then
            WinAPI.ReleaseCapture()
            WinAPI.SendMessage(PrePanel.Handle, WinAPI.WM_NCLBUTTONDOWN, WinAPI.HTCAPTION, 0)
        End If
    End Sub

    Private Sub RightPanel_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RightPanel.MouseDown
        If SizeOriginToolStripMenuItem.Checked = True Then
            WinAPI.ReleaseCapture()
            WinAPI.SendMessage(PrePanel.Handle, WinAPI.WM_NCLBUTTONDOWN, WinAPI.HTCAPTION, 0)
        End If
    End Sub

    Private Sub PrePanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PrePanel.Paint

    End Sub

    Private Sub InTPrePanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles InTPrePanel.Paint

    End Sub

    Private Sub Nowhms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nowhms.Click

    End Sub

    Private Sub ForwardBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForwardBTN.Click

    End Sub
End Class