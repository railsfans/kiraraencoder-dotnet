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

    Dim _AviSynthScriptEnvironment As New AvisynthWrapper.AviSynthScriptEnvironment()
    Dim _AviSynthClip As AvisynthWrapper.AviSynthClip
    Dim BitmapV
    Dim BitMapB As Boolean = False
    Public FrameI As Integer = 0
    Dim PLAYVL As Boolean = False
    Dim GETIMG As Boolean = False
    Public TR As Boolean = False
    Dim TTIME As String = ""

#Region "코어"

    Private Sub VideoWindowFrm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        '닫기
        FrameTimer.Enabled = False
        RealtimeTimer.Enabled = False
        If _AviSynthClip IsNot Nothing Then
            _AviSynthClip.IDisposable_Dispose()
        End If
        If BitmapV IsNot Nothing Then
            BitmapV.Dispose()
        End If
        '활성
        AviSynthEditorFrm.RefButton.Enabled = False
        AviSynthEditorFrm.PreviewButton.Enabled = True

    End Sub

    Private Sub OPEN_SUB()

        Try
            '_AviSynthClip = _AviSynthScriptEnvironment.ParseScript(AviSynthEditorFrm.AVTextBox.Text, AvisynthWrapper.AviSynthColorspace.RGB32)
            '_AviSynthClip = _AviSynthScriptEnvironment.OpenScriptFile(My.Application.Info.DirectoryPath & "AVS파일", AvisynthWrapper.AviSynthColorspace.RGB32)
            If BitMapB = False Then
                _AviSynthClip = _AviSynthScriptEnvironment.OpenScriptFile(My.Application.Info.DirectoryPath & "\temp\AviSynthScript(" & MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(13).Text & ").avs", AvisynthWrapper.AviSynthColorspace.RGB32)
                BitmapV = New Bitmap(_AviSynthClip.VideoWidth, _AviSynthClip.VideoHeight, System.Drawing.Imaging.PixelFormat.Format32bppRgb)
                BitMapB = True
            Else
                If _AviSynthClip IsNot Nothing Then
                    _AviSynthClip.IDisposable_Dispose()
                End If
                If BitmapV IsNot Nothing Then
                    BitmapV.Dispose()
                End If
                _AviSynthClip = _AviSynthScriptEnvironment.OpenScriptFile(My.Application.Info.DirectoryPath & "\temp\AviSynthScript(" & MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(13).Text & ").avs", AvisynthWrapper.AviSynthColorspace.RGB32)
                BitmapV = New Bitmap(_AviSynthClip.VideoWidth, _AviSynthClip.VideoHeight, System.Drawing.Imaging.PixelFormat.Format32bppRgb)
            End If
            VideoPictureBox.Image = BitmapV
            'FrameI 값이 최댓값보다 크면 최댓값으로
            If FrameI > _AviSynthClip.num_frames Then
                FrameI = _AviSynthClip.num_frames
            End If
            '0번째 프레임 이미지 얻기
            GET_IMAGE(FrameI)
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
            AviSynthEditorFrm.PreviewButton.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
            Close()
        End Try

    End Sub

    Public Sub Ref_SUB()

        Dim PLAYVL2 As Boolean = PLAYVL '재생여부저장

        Try
            Me.Text = "Loading..."
            '활성
            AviSynthEditorFrm.RefButton.Enabled = False
            '닫기
            FrameTimer.Enabled = False
            RealtimeTimer.Enabled = False
            If _AviSynthClip IsNot Nothing Then
                _AviSynthClip.IDisposable_Dispose()
            End If
            If BitmapV IsNot Nothing Then
                BitmapV.Dispose()
            End If
            PLAYVL = False
            '---------------
            '새로고침
            AviSynthPP.AviSynthPreprocess(MainFrm.SelIndex, True, Nothing, False, False)
            'SEEKMODE 체크
            If MainFrm.SEEKMODEM1B = True Then Throw New Exception(AviSynthEditorFrm.StatusLabel.Text)
            '열기
            OPEN_SUB()
            '재생여부
            If PLAYVL2 = True Then PlayButton_Click(Nothing, Nothing)
        Catch ex As Exception
            MsgBox(ex.Message)
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
                    VideoWindowPanel.Font = New Font(FNXP, FS)
                Else
                    VideoWindowPanel.Font = New Font(FN, FS)
                End If

                If XTR.Name = "VideoWindowFrmV" Then LangCls.VideoWindowFrmV = XTR.ReadString
                If XTR.Name = "VideoWindowFrmMoveToolStripMenuItem" Then MoveToolStripMenuItem.Text = XTR.ReadString
                If XTR.Name = "VideoWindowFrmSizeModeToolStripMenuItem" Then SizeModeToolStripMenuItem.Text = XTR.ReadString

            Loop
        Catch ex As Exception
            MsgBox("LANG_LOAD_ERROR :" & ex.Message)
        Finally
            XTR.Close()
            SR.Close()
        End Try
LANG_SKIP:
        '=========================================

        OPEN_SUB()

    End Sub

    Public Sub GET_IMAGE(ByVal frameV As Integer)

        If TR = False Then
            If GETIMG = True Then
                Exit Sub
            End If
        End If

        If InStr(Me.Text, " - Loading...", CompareMethod.Text) <> 0 Then Exit Sub

        '========================================================================================

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
            If TR = False Then
                _AviSynthClip.ReadFrame(BitmapDataV.Scan0, BitmapDataV.Stride, frameV)
            Else '오류로인한 새로고침일경우 TR(T두번 R새로고침)은 True가 됨.
                _AviSynthClip.ReadFrame2(BitmapDataV.Scan0, BitmapDataV.Stride, frameV)
            End If
            BitmapV.UnlockBits(BitmapDataV)
            BitmapV.RotateFlip(RotateFlipType.Rotate180FlipX)
        Catch ex As Exception
        End Try
        GETIMG = False

    End Sub

    Private Sub RealtimeTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RealtimeTimer.Tick

        If FrameI <= VideoTrackBar.Maximum Then
            VideoTrackBar.Value = FrameI
        End If

        Me.Text = LangCls.VideoWindowFrmV & " - " & _
        FunctionCls.TIME_TO_HMSMSTIME(FrameI / (_AviSynthClip.raten / _AviSynthClip.rated), True) & " / " & TTIME & _
        " [ " & FrameI & " / " & VideoTrackBar.Maximum & " ] "

        If FrameTimer.Enabled = True Then PLAYVL = True Else PLAYVL = False

    End Sub

    Private Sub RCTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FrameTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FrameTimer.Tick

        If Me.CanFocus = False Then Exit Sub

        '-----------------------------------------------------

        If FrameI < VideoTrackBar.Maximum Then
            FrameI += 1
        End If
        GET_IMAGE(FrameI)

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
        FrameTimer.Enabled = False
        If FrameI > 0 Then FrameI -= 1
        GET_IMAGE(FrameI)
    End Sub

    Private Sub NFButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NFButton.Click
        FrameTimer.Enabled = False
        If FrameI < VideoTrackBar.Maximum Then FrameI += 1
        GET_IMAGE(FrameI)
    End Sub

    Private Sub PPFButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PPFButton.Click
        FrameTimer.Enabled = False
        If FrameI > 0 Then
            FrameI -= 1000 / FrameTimer.Interval
            If FrameI < 0 Then FrameI = 0
        End If
        GET_IMAGE(FrameI)
    End Sub

    Private Sub NNFButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NNFButton.Click
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

End Class