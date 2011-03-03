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
Imports System.Xml

Public Class MPEG4optsFrm

    Dim OKBTNCLK As Boolean = False

    Private Sub ffmpegPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ffmpegPictureBox.Click
        System.Diagnostics.Process.Start("http://ffmpeg.org")
    End Sub

    Private Sub MaxVBTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MaxVBTextBox.KeyPress
        If FunctionCls.InputCheck_NUMBER(e, False, False) = True Then e.Handled = True
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaxVBTextBox.TextChanged

    End Sub

    Private Sub MinVBTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MinVBTextBox.KeyPress
        If FunctionCls.InputCheck_NUMBER(e, False, False) = True Then e.Handled = True
    End Sub

    Private Sub MinVBTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinVBTextBox.TextChanged

    End Sub

    Private Sub RCBufferSizeTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RCBufferSizeTextBox.KeyPress
        If FunctionCls.InputCheck_NUMBER(e, False, False) = True Then e.Handled = True
    End Sub

    Private Sub RCBufferSizeTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RCBufferSizeTextBox.TextChanged

    End Sub

    Private Sub DefBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefBTN.Click

        'Main
        ThreadsNumericUpDown.Value = 0
        QuantizationTypeComboBox.Text = "H.263"
        AdaptiveQuantizationCheckBox.Checked = False
        InterlacedEncodingCheckBox.Checked = False
        GrayscaleCheckBox.Checked = False
        TopFieldFirstCheckBox.Checked = False
        _4MotionVectorCheckBox.Checked = False
        QPELCheckBox.Checked = False
        'B-VOPs
        BFramesCheckBox.Checked = False
        BVOPsNumericUpDown.Value = 1
        ClosedGOPCheckBox.Checked = False
        DownscalesffdBfdCheckBox.Checked = False
        RefinettmvuibmCheckBox.Checked = False
        'Motion Estimation
        DiamondtsfmeComboBox.Text = "ZERO"
        HQModeComboBox.Text = "MBCMP"
        FpmcfComboBox.Text = "SAD"
        SpmcfComboBox.Text = "SAD"
        McfComboBox.Text = "SAD"
        IdcfComboBox.Text = "SAD"
        PmecfComboBox.Text = "SAD"
        'Rate Control
        QMinNumericUpDown.Value = 2
        QMaxNumericUpDown.Value = 31
        QDeltaNumericUpDown.Value = 3
        QuantizerCompressionNumericUpDown.Value = 0.5
        QuantizerBlurNumericUpDown.Value = 0.5
        MaxVBTextBox.Text = "0"
        MinVBTextBox.Text = "0"
        RCBufferSizeTextBox.Text = "0"
        TrellisQuantizationCheckBox.Checked = False
        DCTalgorithmComboBox.Text = "AUTO"

    End Sub

    Private Sub XML_LOAD(ByVal src As String)

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

                '//////////////////////////////////////////////////////////// MPEG4optsFrm
                With Me

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

            Loop

        Catch ex As Exception
            MsgBox("XML_LOAD_ERROR :" & ex.Message)
        Finally
            XTR.Close()
            SR.Close()
        End Try

    End Sub

    Private Sub OKBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKBTN.Click
        OKBTNCLK = True

        MainFrm.XML_SAVE(My.Application.Info.DirectoryPath & "\settings.xml")

        '프리셋 설정된 파일 표시 지우기
        MainFrm.PresetLabel.Text = LangCls.MainUserStr

        Close()
    End Sub

    Private Sub CancelBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBTN.Click
        Close()
    End Sub

    Private Sub MPEG4optsFrm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If OKBTNCLK = False Then XML_LOAD(My.Application.Info.DirectoryPath & "\settings.xml")
    End Sub

    Private Sub MPEG4optsFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        OKBTNCLK = False

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
                    BPanel.Font = New Font(FNXP, FS)
                Else
                    BPanel.Font = New Font(FN, FS)
                End If

                If XTR.Name = "OKBTN" Then OKBTN.Text = XTR.ReadString
                If XTR.Name = "CancelBTN" Then CancelBTN.Text = XTR.ReadString
                If XTR.Name = "DefBTN" Then DefBTN.Text = XTR.ReadString

            Loop
        Catch ex As Exception
            MsgBox("LANG_LOAD_ERROR :" & ex.Message)
        Finally
            XTR.Close()
            SR.Close()
        End Try
LANG_SKIP:
        '=========================================

        '퀀타이저 설정
        If InStr(EncSetFrm.VideoModeComboBox.SelectedItem, "[1PASS-VBR]", CompareMethod.Text) <> 0 Then '퀀타이저
            QuantizerGroupBox.Enabled = False
            RateControlGroupBox.Enabled = False
        Else
            QuantizerGroupBox.Enabled = True
            RateControlGroupBox.Enabled = True
        End If

        XML_LOAD(My.Application.Info.DirectoryPath & "\settings.xml")

    End Sub

    Private Sub BFramesCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BFramesCheckBox.CheckedChanged
        If BFramesCheckBox.Checked = True Then
            BVOPsLabel.Enabled = True
            BVOPsNumericUpDown.Enabled = True
            ClosedGOPCheckBox.Enabled = True
            DownscalesffdBfdCheckBox.Enabled = True
            RefinettmvuibmCheckBox.Enabled = True
        Else
            BVOPsLabel.Enabled = False
            BVOPsNumericUpDown.Enabled = False
            ClosedGOPCheckBox.Enabled = False
            DownscalesffdBfdCheckBox.Enabled = False
            RefinettmvuibmCheckBox.Enabled = False
        End If
    End Sub
End Class