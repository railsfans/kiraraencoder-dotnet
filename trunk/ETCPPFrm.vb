Imports System.IO

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

Public Class ETCPPFrm

    Dim OKBTNCLK As Boolean = False

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

                If XTR.Name = "ETCPPFrm_RateCheckBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then RateCheckBox.Checked = XTRSTR Else RateCheckBox.Checked = False
                End If

                If XTR.Name = "ETCPPFrm_RateNumericUpDown" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then RateNumericUpDown.Value = XTRSTR Else RateNumericUpDown.Value = 1.0
                End If

                If XTR.Name = "ETCPPFrm_RatePCheckBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then RatePCheckBox.Checked = XTRSTR Else RatePCheckBox.Checked = True
                End If

                '로고
                If XTR.Name = "ETCPPFrm_LogoCheckBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then LogoCheckBox.Checked = XTRSTR Else LogoCheckBox.Checked = False
                End If

                If XTR.Name = "ETCPPFrm_LogoImgTextBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> vbNullChar Then LogoImgTextBox.Text = XTRSTR Else LogoImgTextBox.Text = ""
                End If

                If XTR.Name = "ETCPPFrm_AlphaCheckBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then AlphaCheckBox.Checked = XTRSTR Else AlphaCheckBox.Checked = False
                End If

                If XTR.Name = "ETCPPFrm_LSCheckBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then LSCheckBox.Checked = XTRSTR Else LSCheckBox.Checked = False
                End If

                If XTR.Name = "ETCPPFrm_LECheckBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then LECheckBox.Checked = XTRSTR Else LECheckBox.Checked = False
                End If

                If XTR.Name = "ETCPPFrm_LogoTrPaCheckBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then LogoTrPaCheckBox.Checked = XTRSTR Else LogoTrPaCheckBox.Checked = False
                End If

                If XTR.Name = "ETCPPFrm_FadeCheckBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then FadeCheckBox.Checked = XTRSTR Else FadeCheckBox.Checked = False
                End If

                If XTR.Name = "ETCPPFrm_LSHTextBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then LSHTextBox.Text = XTRSTR Else LSHTextBox.Text = "00"
                End If

                If XTR.Name = "ETCPPFrm_LSMTextBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then LSMTextBox.Text = XTRSTR Else LSMTextBox.Text = "00"
                End If

                If XTR.Name = "ETCPPFrm_LSSTextBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then LSSTextBox.Text = XTRSTR Else LSSTextBox.Text = "00"
                End If

                If XTR.Name = "ETCPPFrm_LEHTextBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then LEHTextBox.Text = XTRSTR Else LEHTextBox.Text = "00"
                End If

                If XTR.Name = "ETCPPFrm_LEMTextBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then LEMTextBox.Text = XTRSTR Else LEMTextBox.Text = "00"
                End If

                If XTR.Name = "ETCPPFrm_LESTextBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then LESTextBox.Text = XTRSTR Else LESTextBox.Text = "00"
                End If

                If XTR.Name = "ETCPPFrm_LogoTrPaTrackBar" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then LogoTrPaTrackBar.Value = XTRSTR Else LogoTrPaTrackBar.Value = 100
                End If

                If XTR.Name = "ETCPPFrm_fadeinNumericUpDown" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then fadeinNumericUpDown.Value = XTRSTR Else fadeinNumericUpDown.Value = 0.0
                End If

                If XTR.Name = "ETCPPFrm_fadeoutNumericUpDown" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then fadeoutNumericUpDown.Value = XTRSTR Else fadeoutNumericUpDown.Value = 0.0
                End If

                If XTR.Name = "ETCPPFrm_Alignment5RadioButton" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then LAlignment5RadioButton.Checked = XTRSTR Else LAlignment5RadioButton.Checked = False
                End If

                If XTR.Name = "ETCPPFrm_Alignment6RadioButton" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then LAlignment6RadioButton.Checked = XTRSTR Else LAlignment6RadioButton.Checked = False
                End If

                If XTR.Name = "ETCPPFrm_Alignment4RadioButton" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then LAlignment4RadioButton.Checked = XTRSTR Else LAlignment4RadioButton.Checked = False
                End If

                If XTR.Name = "ETCPPFrm_Alignment9RadioButton" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then LAlignment9RadioButton.Checked = XTRSTR Else LAlignment9RadioButton.Checked = False
                End If

                If XTR.Name = "ETCPPFrm_Alignment7RadioButton" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then LAlignment7RadioButton.Checked = XTRSTR Else LAlignment7RadioButton.Checked = True
                End If

                If XTR.Name = "ETCPPFrm_Alignment8RadioButton" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then LAlignment8RadioButton.Checked = XTRSTR Else LAlignment8RadioButton.Checked = False
                End If

                If XTR.Name = "ETCPPFrm_Alignment1RadioButton" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then LAlignment1RadioButton.Checked = XTRSTR Else LAlignment1RadioButton.Checked = False
                End If

                If XTR.Name = "ETCPPFrm_Alignment2RadioButton" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then LAlignment2RadioButton.Checked = XTRSTR Else LAlignment2RadioButton.Checked = False
                End If

                If XTR.Name = "ETCPPFrm_Alignment3RadioButton" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then LAlignment3RadioButton.Checked = XTRSTR Else LAlignment3RadioButton.Checked = False
                End If

                If XTR.Name = "ETCPPFrm_XNumericUpDown" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then XNumericUpDown.Value = XTRSTR Else XNumericUpDown.Value = 0
                End If

                If XTR.Name = "ETCPPFrm_YNumericUpDown" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then YNumericUpDown.Value = XTRSTR Else YNumericUpDown.Value = 0
                End If

                If XTR.Name = "ETCPPFrm_ModeComboBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then ModeComboBox.Text = XTRSTR Else ModeComboBox.Text = "Blend"
                End If

            Loop

        Catch ex As Exception
            MsgBox("XML_LOAD_ERROR :" & ex.Message)
        Finally
            XTR.Close()
            SR.Close()
        End Try

    End Sub

    Private Sub ETCPPFrm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If OKBTNCLK = False Then XML_LOAD(My.Application.Info.DirectoryPath & "\settings.xml")
    End Sub

    Private Sub ETCPPFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
                    EPP_Panel.Font = New Font(FNXP, FS)
                Else
                    EPP_Panel.Font = New Font(FN, FS)
                End If

                If XTR.Name = "OKBTN" Then OKBTN.Text = XTR.ReadString
                If XTR.Name = "CancelBTN" Then CancelBTN.Text = XTR.ReadString
                If XTR.Name = "DefBTN" Then DefBTN.Text = XTR.ReadString

                If XTR.Name = "ETCPPFrm" Then Me.Text = XTR.ReadString
                If XTR.Name = "ETCPPFrmRateGroupBox" Then RateGroupBox.Text = XTR.ReadString
                If XTR.Name = "ETCPPFrmRateCheckBox" Then RateCheckBox.Text = XTR.ReadString
                If XTR.Name = "ETCPPFrmRatePCheckBox" Then RatePCheckBox.Text = XTR.ReadString
                If XTR.Name = "ETCPPFrmLogoGroupBox" Then LogoGroupBox.Text = XTR.ReadString
                If XTR.Name = "ETCPPFrmLogoCheckBox" Then LogoCheckBox.Text = XTR.ReadString
                If XTR.Name = "ETCPPFrmLogoImgLabel" Then LogoImgLabel.Text = XTR.ReadString
                If XTR.Name = "ETCPPFrmAlphaCheckBox" Then AlphaCheckBox.Text = XTR.ReadString
                If XTR.Name = "ETCPPFrmLSCheckBox" Then LSCheckBox.Text = XTR.ReadString
                If XTR.Name = "ETCPPFrmLECheckBox" Then LECheckBox.Text = XTR.ReadString
                If XTR.Name = "ETCPPFrmLogoTrPaCheckBox" Then LogoTrPaCheckBox.Text = XTR.ReadString
                If XTR.Name = "ETCPPFrmFadeCheckBox" Then FadeCheckBox.Text = XTR.ReadString
                If XTR.Name = "ETCPPFrmfadeinLabel" Then fadeinLabel.Text = XTR.ReadString
                If XTR.Name = "ETCPPFrmfadeoutLabel" Then fadeoutLabel.Text = XTR.ReadString
                If XTR.Name = "ETCPPFrmLAlignmentGroupBox" Then LAlignmentGroupBox.Text = XTR.ReadString

            Loop
        Catch ex As Exception
            MsgBox("LANG_LOAD_ERROR :" & ex.Message)
        Finally
            XTR.Close()
            SR.Close()
        End Try
LANG_SKIP:
        '=========================================

        XML_LOAD(My.Application.Info.DirectoryPath & "\settings.xml")

    End Sub

    Private Sub DefBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefBTN.Click
        RateCheckBox.Checked = False
        RateNumericUpDown.Value = 1.0
        RatePCheckBox.Checked = True
        '로고
        LogoCheckBox.Checked = False
        LogoImgTextBox.Text = ""
        AlphaCheckBox.Checked = False
        LSCheckBox.Checked = False
        LECheckBox.Checked = False
        LogoTrPaCheckBox.Checked = False
        FadeCheckBox.Checked = False
        LSHTextBox.Text = "00"
        LSMTextBox.Text = "00"
        LSSTextBox.Text = "00"
        LEHTextBox.Text = "00"
        LEMTextBox.Text = "00"
        LESTextBox.Text = "00"
        LogoTrPaTrackBar.Value = 100
        fadeinNumericUpDown.Value = 0.0
        fadeoutNumericUpDown.Value = 0.0
        LAlignment5RadioButton.Checked = False
        LAlignment6RadioButton.Checked = False
        LAlignment4RadioButton.Checked = False
        LAlignment9RadioButton.Checked = False
        LAlignment7RadioButton.Checked = True
        LAlignment8RadioButton.Checked = False
        LAlignment1RadioButton.Checked = False
        LAlignment2RadioButton.Checked = False
        LAlignment3RadioButton.Checked = False
        XNumericUpDown.Value = 0
        YNumericUpDown.Value = 0
        ModeComboBox.Text = "Blend"
    End Sub

    Private Sub CancelBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBTN.Click
        Close()
    End Sub

    Private Sub OKBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKBTN.Click
        OKBTNCLK = True

        MainFrm.XML_SAVE(My.Application.Info.DirectoryPath & "\settings.xml")

        '프리셋 설정된 파일 표시 지우기
        MainFrm.PresetLabel.Text = LangCls.MainUserStr

        Close()
    End Sub

    Private Sub RateCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RateCheckBox.CheckedChanged
        If RateCheckBox.Checked = True Then
            RateNumericUpDown.Enabled = True
            RatePCheckBox.Enabled = True
        Else
            RateNumericUpDown.Enabled = False
            RatePCheckBox.Enabled = False
        End If
    End Sub

    Private Sub LogoCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoCheckBox.CheckedChanged
        If LogoCheckBox.Checked = True Then
            LogoPanel.Enabled = True
        Else
            LogoPanel.Enabled = False
        End If
    End Sub

    Private Sub LSCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LSCheckBox.CheckedChanged
        If LSCheckBox.Checked = True Then
            LSP1Label.Enabled = True
            LSP2Label.Enabled = True
            LSHTextBox.Enabled = True
            LSMTextBox.Enabled = True
            LSSTextBox.Enabled = True
        Else
            LSP1Label.Enabled = False
            LSP2Label.Enabled = False
            LSHTextBox.Enabled = False
            LSMTextBox.Enabled = False
            LSSTextBox.Enabled = False
        End If
    End Sub

    Private Sub LECheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LECheckBox.CheckedChanged
        If LECheckBox.Checked = True Then
            LEP1Label.Enabled = True
            LEP2Label.Enabled = True
            LEHTextBox.Enabled = True
            LEMTextBox.Enabled = True
            LESTextBox.Enabled = True
        Else
            LEP1Label.Enabled = False
            LEP2Label.Enabled = False
            LEHTextBox.Enabled = False
            LEMTextBox.Enabled = False
            LESTextBox.Enabled = False
        End If
    End Sub

    Private Sub LogoTrPaCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoTrPaCheckBox.CheckedChanged
        If LogoTrPaCheckBox.Checked = True Then
            LogoTrPaTrackBar.Enabled = True
            LogoTrPaLabel.Enabled = True
        Else
            LogoTrPaTrackBar.Enabled = False
            LogoTrPaLabel.Enabled = False
        End If
    End Sub

    Private Sub FadeCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FadeCheckBox.CheckedChanged
        If FadeCheckBox.Checked = True Then
            fadeinLabel.Enabled = True
            fadeinNumericUpDown.Enabled = True
            fadeoutLabel.Enabled = True
            fadeoutNumericUpDown.Enabled = True
        Else
            fadeinLabel.Enabled = False
            fadeinNumericUpDown.Enabled = False
            fadeoutLabel.Enabled = False
            fadeoutNumericUpDown.Enabled = False
        End If
    End Sub

    Private Sub LogoImgButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoImgButton.Click

        OpenFileDialog1.FileName = ""
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName = "" Then Exit Sub
        LogoImgTextBox.Text = OpenFileDialog1.FileName

    End Sub

    Private Sub LSHTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LSHTextBox.KeyPress
        If FunctionCls.InputCheck_NUMBER(e, False, False) = True Then e.Handled = True
    End Sub

    Private Sub LSHTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles LSHTextBox.LostFocus
        LSHTextBox.Text = FunctionCls.Input_nint_zero(LSHTextBox.Text)
    End Sub

    Private Sub LSHTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LSHTextBox.TextChanged

    End Sub

    Private Sub LSMTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LSMTextBox.KeyPress
        If FunctionCls.InputCheck_NUMBER(e, False, False) = True Then e.Handled = True
    End Sub

    Private Sub LSMTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles LSMTextBox.LostFocus
        LSMTextBox.Text = FunctionCls.Input_nint_zero(LSMTextBox.Text)
    End Sub

    Private Sub LSMTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LSMTextBox.TextChanged

    End Sub

    Private Sub LSSTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LSSTextBox.KeyPress
        If FunctionCls.InputCheck_NUMBER(e, False, False) = True Then e.Handled = True
    End Sub

    Private Sub LSSTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles LSSTextBox.LostFocus
        LSSTextBox.Text = FunctionCls.Input_nint_zero(LSSTextBox.Text)
    End Sub

    Private Sub LSSTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LSSTextBox.TextChanged

    End Sub

    Private Sub LEHTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LEHTextBox.KeyPress
        If FunctionCls.InputCheck_NUMBER(e, False, False) = True Then e.Handled = True
    End Sub

    Private Sub LEHTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles LEHTextBox.LostFocus
        LEHTextBox.Text = FunctionCls.Input_nint_zero(LEHTextBox.Text)
    End Sub

    Private Sub LEHTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LEHTextBox.TextChanged

    End Sub

    Private Sub LEMTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LEMTextBox.KeyPress
        If FunctionCls.InputCheck_NUMBER(e, False, False) = True Then e.Handled = True
    End Sub

    Private Sub LEMTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles LEMTextBox.LostFocus
        LEMTextBox.Text = FunctionCls.Input_nint_zero(LEMTextBox.Text)
    End Sub

    Private Sub LEMTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LEMTextBox.TextChanged

    End Sub

    Private Sub LESTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LESTextBox.KeyPress
        If FunctionCls.InputCheck_NUMBER(e, False, False) = True Then e.Handled = True
    End Sub

    Private Sub LESTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles LESTextBox.LostFocus
        LESTextBox.Text = FunctionCls.Input_nint_zero(LESTextBox.Text)
    End Sub

    Private Sub LESTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LESTextBox.TextChanged

    End Sub

    Private Sub LogoTrPaTrackBar_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LogoTrPaTrackBar.ValueChanged
        LogoTrPaLabel.Text = LogoTrPaTrackBar.Value
    End Sub
End Class