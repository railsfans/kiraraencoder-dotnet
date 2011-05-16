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

Imports System.IO

Public Class VideoWindowFrm
    Dim _AviSynthClip As AvisynthWrapper.AviSynthClip = Nothing
    Dim _AviSynthScriptEnvironment As New AvisynthWrapper.AviSynthScriptEnvironment()
    Dim BitmapV As Bitmap = Nothing
    Public FrameI As Integer = 0
    Dim PLAYVL As Boolean = False
    Public GETIMG As Boolean = False
    Dim TTIME As String = ""
    Dim RealFrameI As Integer = 0
    Dim FraemT As Boolean = False
    '재생시간추출
    Dim SHV As String = ""
    Dim SMV As String = ""
    Dim SSV As String = ""
    Dim SMSV As String = ""
    Dim EHV As String = ""
    Dim EMV As String = ""
    Dim ESV As String = ""
    Dim EMSV As String = ""
    Dim SetSTextBoxV As Single = 0.0
    Dim SetETextBoxV As Single = 0.0

    'time
    Public PTime As Single = 0.0

    'EXITCALL
    Public ref_call As Boolean = False

    '로드기준, 배속 사용여부
    Dim SpeedXChg As Boolean = False

#Region "코어"

    Private Sub img_cleanup()
        If _AviSynthClip IsNot Nothing Then
            TryCast(_AviSynthClip, IDisposable).Dispose()
            _AviSynthClip = Nothing
        End If
        If _AviSynthScriptEnvironment IsNot Nothing Then
            TryCast(_AviSynthScriptEnvironment, IDisposable).Dispose()
            _AviSynthScriptEnvironment = Nothing
        End If
    End Sub

    Private Sub VideoWindowFrm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If GETIMG = True OrElse AviSynthEditorFrm.waitbool = True Then
            e.Cancel = True
            Exit Sub
        End If

        '--------

        '저장
        MainFrm.VideoWindowMode = VideoPictureBox.SizeMode
        MainFrm.VideoWindowFrmW = Me.Width
        MainFrm.VideoWindowFrmH = Me.Height
        AviSynthEditorFrm.VWX = Me.Location.X
        AviSynthEditorFrm.VWY = Me.Location.Y

        '닫기
        FrameTimer.Enabled = False
        RealtimeTimer.Enabled = False
        img_cleanup()

        '활성
        If ref_call = False Then
            AviSynthEditorFrm.RefButton.Enabled = False
            ApplyToolStripMenuItem.Enabled = False
            AviSynthEditorFrm.PreviewButton.Enabled = True
        End If

        '원위치
        AviSynthEditorFrm.PtimeB = 0.0

        Me.Dispose()

    End Sub

    Private Sub OPEN_SUB()

        '배속사용여부 진단(로드기준)
        If MainFrm.AVSCheckBox.Checked = True AndAlso ETCPPFrm.RateCheckBox.Checked = True Then 'AviSynth 사용하고 배속모드 사용..
            SpeedXChg = True
        Else
            SpeedXChg = False
        End If

        Try
            If _AviSynthScriptEnvironment Is Nothing Then
                _AviSynthScriptEnvironment = New AvisynthWrapper.AviSynthScriptEnvironment()
            End If
            '_AviSynthClip = _AviSynthScriptEnvironment.ParseScript(AviSynthEditorFrm.AVTextBox.Text, AvisynthWrapper.AviSynthColorspace.RGB32)
            '_AviSynthClip = _AviSynthScriptEnvironment.OpenScriptFile(Mainfrm.ApplicationInfoDirectoryPath & "AVS파일", AvisynthWrapper.AviSynthColorspace.RGB32)
            _AviSynthClip = _AviSynthScriptEnvironment.OpenScriptFile(FunctionCls.AppInfoDirectoryPath & "\temp\AviSynthScript(" & MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(13).Text & ").avs", AvisynthWrapper.AviSynthColorspace.RGB32)
            BitmapV = New Bitmap(_AviSynthClip.VideoWidth, _AviSynthClip.VideoHeight, System.Drawing.Imaging.PixelFormat.Format32bppRgb)
            VideoPictureBox.Image = BitmapV
            'FrameI 값이 최댓값보다 크면 최댓값으로
            If FrameI > _AviSynthClip.num_frames Then
                FrameI = _AviSynthClip.num_frames
            End If

            If AviSynthEditorFrm.PtimeB <> 0.0 Then
                'x번째 프레임 이미지 얻기
                Dim FPSV As Single = _AviSynthClip.raten / _AviSynthClip.rated
                Dim TIMEV As Integer = FPSV * AviSynthEditorFrm.PtimeB
                If TIMEV >= _AviSynthClip.num_frames Then TIMEV = _AviSynthClip.num_frames
                GET_IMAGE(TIMEV)
            Else
                '0번째 프레임 이미지 얻기
                GET_IMAGE(FrameI)
            End If

            '최댓값 설정
            VideoTrackBar.Maximum = _AviSynthClip.num_frames
            '프레임 설정
            FrameTimer.Interval = 1000 / (_AviSynthClip.raten / _AviSynthClip.rated)
            '재생시간 표시
            TTIME = FunctionCls.TIME_TO_HMSMSTIME(VideoTrackBar.Maximum / (_AviSynthClip.raten / _AviSynthClip.rated), True)
            '실시간 타이머 온
            RealtimeTimer.Enabled = True
            '활성
            AviSynthEditorFrm.RefButton.Enabled = True
            ApplyToolStripMenuItem.Enabled = True
            AviSynthEditorFrm.PreviewButton.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
            GETIMG = False
            AviSynthEditorFrm.waitbool = False
            Close()
        End Try

    End Sub

    Private Sub VideoWindowFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
                    VideoWindowPanel.Font = New Font(FNXP, FS)
                Else
                    VideoWindowPanel.Font = New Font(FN, FS)
                End If

                If XTR.Name = "VideoWindowFrmV" Then LangCls.VideoWindowFrmV = XTR.ReadString
                If XTR.Name = "VideoWindowFrmMoveToolStripMenuItem" Then MoveToolStripMenuItem.Text = XTR.ReadString
                If XTR.Name = "VideoWindowFrmSizeModeToolStripMenuItem" Then SizeModeToolStripMenuItem.Text = XTR.ReadString
                If XTR.Name = "VideoWindowFrmSetStartToolStripMenuItem" Then SetStartToolStripMenuItem.Text = XTR.ReadString
                If XTR.Name = "VideoWindowFrmSetEndToolStripMenuItem" Then SetEndToolStripMenuItem.Text = XTR.ReadString
                If XTR.Name = "VideoWindowFrmApplyToolStripMenuItem" Then ApplyToolStripMenuItem.Text = XTR.ReadString

            Loop
        Catch ex As Exception
            MsgBox("LANG_LOAD_ERROR :" & ex.Message)
        Finally
            XTR.Close()
            SR.Close()
        End Try
LANG_SKIP:
        '=========================================

        '열기
        VideoPictureBox.SizeMode = MainFrm.VideoWindowMode
        ModeToolStripMenuItem.Text = VideoPictureBox.SizeMode.ToString

        If AviSynthEditorFrm.VWX <> 0 AndAlso AviSynthEditorFrm.VWY <> 0 Then
            Me.Location = New System.Drawing.Point(AviSynthEditorFrm.VWX, AviSynthEditorFrm.VWY)
        Else
            Try
                Me.Location = New System.Drawing.Point((Screen.GetBounds(Me).Width / 2) - Me.Width / 2, (Screen.GetBounds(Me).Height / 2) - Me.Height / 2)
            Catch ex As Exception
            End Try
        End If

        '시야밖일경우 시야내로
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

        If MainFrm.VideoWindowFrmW <> 0 AndAlso MainFrm.VideoWindowFrmH <> 0 Then
            Me.Width = MainFrm.VideoWindowFrmW
            Me.Height = MainFrm.VideoWindowFrmH
        End If

        GUGAN()
        OPEN_SUB()

    End Sub

    Private Sub GUGAN()

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
                SHV = Split(t, ":")(0)
                SMV = Split(t, ":")(1)
                SSV = Split(Split(t, ":")(2), ".")(0)
                SMSV = Split(t, ".")(1)
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
                EHV = Split(t, ":")(0)
                EMV = Split(t, ":")(1)
                ESV = Split(Split(t, ":")(2), ".")(0)
                EMSV = Split(t, ".")(1)
            Catch ex As Exception
            End Try
        End If

        '구간설정 초기화
        SetSTextBoxV = 0.0
        SetETextBoxV = 0.0
        STextBox.Text = "00:00:00.00"
        ETextBox.Text = "00:00:00.00"

    End Sub

    Public Sub GET_IMAGE(ByVal frameV As Integer)

        If GETIMG = True Then
            Exit Sub
        End If

        If InStr(Me.Text, " - Loading...", CompareMethod.Text) <> 0 Then Exit Sub

        '------------------------------------------------------------

        GETIMG = True

        If FrameTimer.Enabled = False OrElse FrameMoveFrm.Visible = True Then
            If Me.Text = "" Then
                Me.Text = "Loading... [ Please wait while processing. ]"
            ElseIf Me.Text = "Loading..." Then
            Else
                Me.Text &= " - Loading..."
            End If
        End If

        Try
            VideoPictureBox.Image = BitmapV
            Dim rectV As New Rectangle(0, 0, BitmapV.Width, BitmapV.Height)
            Dim BitmapDataV As System.Drawing.Imaging.BitmapData = BitmapV.LockBits(rectV, System.Drawing.Imaging.ImageLockMode.ReadWrite, BitmapV.PixelFormat)
            _AviSynthClip.ReadFrame(BitmapDataV.Scan0, BitmapDataV.Stride, frameV)
            BitmapV.UnlockBits(BitmapDataV)
            BitmapV.RotateFlip(RotateFlipType.Rotate180FlipX)
            RealFrameI = frameV
            FrameI = frameV
            PTime = FrameI / (_AviSynthClip.raten / _AviSynthClip.rated)
            AviSynthEditorFrm.PtimeB = PTime
        Catch ex As Exception
            MsgBox(ex.Message)
            GETIMG = False
            AviSynthEditorFrm.waitbool = False
            Close()
        End Try

        GETIMG = False


    End Sub

    Private Sub RealtimeTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RealtimeTimer.Tick

        'FrameI CHK
        If RealFrameI <> FrameI Then
            FrameI = RealFrameI
        End If

        If FrameI <= VideoTrackBar.Maximum Then
            VideoTrackBar.Value = FrameI
        End If

        Me.Text = LangCls.VideoWindowFrmV & " - " & _
          FunctionCls.TIME_TO_HMSMSTIME(FrameI / (_AviSynthClip.raten / _AviSynthClip.rated), True) & " / " & TTIME & _
          " [ " & FrameI & " / " & VideoTrackBar.Maximum & " ] "

        If FrameTimer.Enabled = True Then PLAYVL = True Else PLAYVL = False

        'ref관련
        If AviSynthEditorFrm.waitbool = True Then
            PTime = FrameI / (_AviSynthClip.raten / _AviSynthClip.rated)
            AviSynthEditorFrm.RefButton.Enabled = True
            ApplyToolStripMenuItem.Enabled = True
            AviSynthEditorFrm.waitbool = False
        End If

    End Sub

    Private Sub RCTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FrameTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FrameTimer.Tick
        FraemT = True
        If Me.CanFocus = False Then Exit Sub

        '-----------------------------------------------------

        If FrameI < VideoTrackBar.Maximum Then
            FrameI += 1
        End If
        GET_IMAGE(FrameI)
        FraemT = False
    End Sub

#End Region

    Private Sub PlayButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayButton.Click
        If PLAYVL = False Then
            FrameTimer.Enabled = True
        Else
            FrameTimer.Enabled = False
        End If
    End Sub

    Private Sub StopButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopButton.Click
        FrameTimer.Enabled = False
        FrameI = 0
        GET_IMAGE(0)
    End Sub

    Private Sub VideoTrackBar_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles VideoTrackBar.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            RealtimeTimer.Enabled = False
            FrameTimer.Enabled = False
        End If
    End Sub

    Private Sub VideoTrackBar_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles VideoTrackBar.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            FrameI = VideoTrackBar.Value

            Me.Text = LangCls.VideoWindowFrmV & " - " & _
            FunctionCls.TIME_TO_HMSMSTIME(FrameI / (_AviSynthClip.raten / _AviSynthClip.rated), True) & " / " & TTIME & _
            " [ " & FrameI & " / " & VideoTrackBar.Maximum & " ] "
        End If
    End Sub

    Private Sub VideoTrackBar_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles VideoTrackBar.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then

            Dim VTBV As Integer = Int(((e.X - 8) / (VideoTrackBar.Width - (8 * 2))) * VideoTrackBar.Maximum)
            If VTBV >= VideoTrackBar.Maximum Then
                VTBV = VideoTrackBar.Maximum
            ElseIf VTBV <= VideoTrackBar.Minimum Then
                VTBV = VideoTrackBar.Minimum
            End If

            FrameI = VTBV
            GET_IMAGE(FrameI)

            If PLAYVL = True Then
                FrameTimer.Enabled = True
            Else
                FrameTimer.Enabled = False
            End If
            RealtimeTimer.Enabled = True

        End If
    End Sub

    Private Sub PFButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PFButton.Click
        If GETIMG = True Then Exit Sub
        FrameTimer.Enabled = False
        If FrameI > 0 Then FrameI -= 1
        GET_IMAGE(FrameI)
    End Sub

    Private Sub NFButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NFButton.Click
        If GETIMG = True Then Exit Sub
        FrameTimer.Enabled = False
        If FrameI < VideoTrackBar.Maximum Then FrameI += 1
        GET_IMAGE(FrameI)
    End Sub

    Private Sub PPFButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PPFButton.Click
        If GETIMG = True Then Exit Sub
        FrameTimer.Enabled = False
        If FrameI > 0 Then
            FrameI -= 1000 / FrameTimer.Interval
            If FrameI < 0 Then FrameI = 0
        End If
        GET_IMAGE(FrameI)
    End Sub

    Private Sub NNFButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NNFButton.Click
        If GETIMG = True Then Exit Sub
        FrameTimer.Enabled = False
        If FrameI < VideoTrackBar.Maximum Then
            FrameI += 1000 / FrameTimer.Interval
            If FrameI > VideoTrackBar.Maximum Then FrameI = VideoTrackBar.Maximum
        End If
        GET_IMAGE(FrameI)
    End Sub

    Private Sub SizeModeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SizeModeToolStripMenuItem.Click
        If VideoPictureBox.SizeMode = PictureBoxSizeMode.CenterImage Then
            VideoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        ElseIf VideoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage Then
            VideoPictureBox.SizeMode = PictureBoxSizeMode.Zoom
        ElseIf VideoPictureBox.SizeMode = PictureBoxSizeMode.Zoom Then
            VideoPictureBox.SizeMode = PictureBoxSizeMode.CenterImage
        End If
        ModeToolStripMenuItem.Text = VideoPictureBox.SizeMode.ToString
    End Sub

    Private Sub MoveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoveToolStripMenuItem.Click
        FrameMoveFrm.FrameNumericUpDown.Maximum = VideoTrackBar.Maximum
        FrameMoveFrm.FrameNumericUpDown.Value = FrameI
        Try
            FrameMoveFrm.ShowDialog(Me)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub VideoTrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VideoTrackBar.Scroll

    End Sub

    Private Sub SetStartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetStartToolStripMenuItem.Click

        STextBox.Text = FunctionCls.TIME_TO_HMSMSTIME(FrameI / (_AviSynthClip.raten / _AviSynthClip.rated), True)

        '계산
        Dim STextBoxV As Single = 0.0
        Try
            STextBoxV = Val((Split(STextBox.Text, ":")(0) * 3600)) + Val((Split(STextBox.Text, ":")(1) * 60)) + Val(Split(Split(STextBox.Text, ":")(2), ".")(0)) + Val("0." & Split(STextBox.Text, ".")(1))
        Catch ex As Exception
        End Try

        '배속대응
        If SpeedXChg = True Then STextBoxV *= ETCPPFrm.RateNumericUpDown.Value

        '계산 - 원래 지정된 거
        Dim OriginSTextBoxV As Single = 0.0
        Try
            OriginSTextBoxV = Val(SHV * 3600) + Val(SMV * 60) + Val(SSV) + Val("0." & SMSV)
        Catch ex As Exception
        End Try
        '-------

        If OriginSTextBoxV = 0 Then
            SetSTextBoxV = STextBoxV
        Else
            SetSTextBoxV = OriginSTextBoxV + STextBoxV
        End If

    End Sub

    Private Sub SetEndToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetEndToolStripMenuItem.Click

        ETextBox.Text = FunctionCls.TIME_TO_HMSMSTIME(FrameI / (_AviSynthClip.raten / _AviSynthClip.rated), True)

        '계산
        Dim ETextBoxV As Single = 0.0
        Try
            ETextBoxV = Val((Split(ETextBox.Text, ":")(0) * 3600)) + Val((Split(ETextBox.Text, ":")(1) * 60)) + Val(Split(Split(ETextBox.Text, ":")(2), ".")(0)) + Val("0." & Split(ETextBox.Text, ".")(1))
        Catch ex As Exception
        End Try

        '배속대응
        If SpeedXChg = True Then ETextBoxV *= ETCPPFrm.RateNumericUpDown.Value

        '계산 - 원래 지정된 거
        Dim OriginETextBoxV As Single = 0.0
        Try
            OriginETextBoxV = Val(EHV * 3600) + Val(EMV * 60) + Val(ESV) + Val("0." & EMSV)
        Catch ex As Exception
        End Try
        '-------

        Dim TotalS As Single = VideoTrackBar.Maximum / (_AviSynthClip.raten / _AviSynthClip.rated)

        '배속대응
        If SpeedXChg = True Then TotalS *= ETCPPFrm.RateNumericUpDown.Value

        If OriginETextBoxV = 0 Then
            SetETextBoxV = ETextBoxV
        Else
            Dim valstr As String = Format(VideoTrackBar.Maximum / (_AviSynthClip.raten / _AviSynthClip.rated), "0.00")

            '배속대응 
            If SpeedXChg = True Then valstr *= ETCPPFrm.RateNumericUpDown.Value

            SetETextBoxV = Val(valstr) - (ETextBoxV + (TotalS / VideoTrackBar.Maximum))
        End If

    End Sub

    Private Sub ApplyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplyToolStripMenuItem.Click

        If AviSynthEditorFrm.waitbool = True Then Exit Sub '중복 새로고침 클릭방지

        Dim StartTimeSetEndTime As Boolean = False
        Dim StartTimeSetEndTimeV As String = ""

        '시작시간
        If SetSTextBoxV <> 0 Then
            '계산 - 원래 지정된 거
            Dim OriginSTextBoxV As Single = 0.0
            Try
                OriginSTextBoxV = Val(SHV * 3600) + Val(SMV * 60) + Val(SSV) + Val("0." & SMSV)
            Catch ex As Exception
            End Try
            If OriginSTextBoxV = 0 Then
                MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(11).Text = Replace(MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(11).Text, _
                                    "[00:00:00.00", "[" & FunctionCls.TIME_TO_HMSMSTIME(SetSTextBoxV, True))
            Else
                MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(11).Text = Replace(MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(11).Text, _
                                    "[" & FunctionCls.TIME_TO_HMSMSTIME(OriginSTextBoxV, True), "[" & FunctionCls.TIME_TO_HMSMSTIME(SetSTextBoxV, True))
            End If

            '==============================================
            Dim OriginETextBoxV As Single = 0.0
            Try
                OriginETextBoxV = Val(EHV * 3600) + Val(EMV * 60) + Val(ESV) + Val("0." & EMSV)
            Catch ex As Exception
            End Try
            If OriginETextBoxV = 0 Then '종료시간 임의지정
                StartTimeSetEndTime = True
                StartTimeSetEndTimeV = TTIME
                MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(11).Text = Replace(MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(11).Text, _
                           "00:00:00.00]", StartTimeSetEndTimeV & "]")
            End If
        End If


        '종료시간
        If SetETextBoxV <> 0 Then
            '계산 - 원래 지정된 거
            Dim OriginETextBoxV As Single = 0.0
            Try
                OriginETextBoxV = Val(EHV * 3600) + Val(EMV * 60) + Val(ESV) + Val("0." & EMSV)
            Catch ex As Exception
            End Try
            If OriginETextBoxV = 0 Then
                If StartTimeSetEndTime = True Then
                    MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(11).Text = Replace(MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(11).Text, _
                                                 StartTimeSetEndTimeV, FunctionCls.TIME_TO_HMSMSTIME(SetETextBoxV, True) & "]")
                Else
                    MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(11).Text = Replace(MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(11).Text, _
                                                 "00:00:00.00]", FunctionCls.TIME_TO_HMSMSTIME(SetETextBoxV, True) & "]")
                End If
            Else
                MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(11).Text = Replace(MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(11).Text, _
                                     FunctionCls.TIME_TO_HMSMSTIME(OriginETextBoxV, True) & "]", FunctionCls.TIME_TO_HMSMSTIME(Val(OriginETextBoxV - SetETextBoxV), True) & "]")
            End If
        End If

        '=============================

        '새로고침
        AviSynthEditorFrm.RefButton_Click(Nothing, Nothing)

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Public Sub Ref_SUB()

        Dim PLAYVL2 As Boolean = PLAYVL '재생여부저장

        Try

            If Me.Text = "Loading..." Then Exit Sub

            '--------------------------

            Me.Text = "Loading..."

            '재생여부
            PLAYVL = False

            '닫기
            FrameTimer.Enabled = False
            RealtimeTimer.Enabled = False
            img_cleanup()

            '활성
            AviSynthEditorFrm.RefButton.Enabled = False
            ApplyToolStripMenuItem.Enabled = False

            '---------------

            '새로고침
            AviSynthPP.AviSynthPreprocess(MainFrm.SelIndex, True, Nothing, False, False, False, False)
            If AviSynthPP.INDEX_ProcessStopChk = True Then
                AviSynthPP.INDEX_ProcessStopChk = False
            End If

            'SEEKMODE 체크
            If MainFrm.SEEKMODEM1B = True Then Throw New Exception(AviSynthEditorFrm.StatusLabel.Text)

            '열기
            GUGAN()
            OPEN_SUB()

            '재생여부
            If PLAYVL2 = True Then PlayButton_Click(Nothing, Nothing)

        Catch ex As Exception

            MsgBox(ex.Message)
            GETIMG = False
            AviSynthEditorFrm.waitbool = False
            Close()

        End Try

    End Sub

End Class