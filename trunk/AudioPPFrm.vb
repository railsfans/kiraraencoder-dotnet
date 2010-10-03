' ---------------------------------------------------------------------------------------
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

Imports System.IO
Imports System.Xml

Public Class AudioPPFrm

    Private Sub DefBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefBTN.Click
        AviSynthChComboBox.Text = LangCls.AudioPPch20ComboBox
        AmplifyCheckBox.Checked = False
        AmplifyNumericUpDown.Value = 0.0
        EQCheckBox.Checked = False
        EQ1TrackBar.Value = 0
        EQ2TrackBar.Value = 0
        EQ3TrackBar.Value = 0
        EQ4TrackBar.Value = 0
        EQ5TrackBar.Value = 0
        EQ6TrackBar.Value = 0
        EQ7TrackBar.Value = 0
        EQ8TrackBar.Value = 0
        EQ9TrackBar.Value = 0
        EQ10TrackBar.Value = 0
        EQ11TrackBar.Value = 0
        EQ12TrackBar.Value = 0
        EQ13TrackBar.Value = 0
        EQ14TrackBar.Value = 0
        EQ15TrackBar.Value = 0
        EQ16TrackBar.Value = 0
        EQ17TrackBar.Value = 0
        EQ18TrackBar.Value = 0
    End Sub

    Private Sub XML_LOAD(ByVal src As String)

        Dim SR As New StreamReader(src, System.Text.Encoding.UTF8)
        Dim XTR As New System.Xml.XmlTextReader(SR)

        Try

            Do While XTR.Read
                Application.DoEvents()

                'AviSynthChComboBox
                If XTR.Name = "AudioPPFrm_AviSynthChComboBox" Then
                    Dim AviSynthChComboBoxV As String = ""
                    AviSynthChComboBoxV = XTR.ReadString
                    If AviSynthChComboBoxV = "LangCls.AudioPPchoriginComboBox" Then
                        AviSynthChComboBox.Text = LangCls.AudioPPchoriginComboBox
                    ElseIf AviSynthChComboBoxV = "LangCls.AudioPPch10ComboBox" Then
                        AviSynthChComboBox.Text = LangCls.AudioPPch10ComboBox
                    ElseIf AviSynthChComboBoxV = "LangCls.AudioPPch20ComboBox" Then
                        AviSynthChComboBox.Text = LangCls.AudioPPch20ComboBox
                    ElseIf AviSynthChComboBoxV = "LangCls.AudioPPch51ComboBox" Then
                        AviSynthChComboBox.Text = LangCls.AudioPPch51ComboBox
                    ElseIf AviSynthChComboBoxV = "LangCls.AudioPPdolbysComboBox" Then
                        AviSynthChComboBox.Text = LangCls.AudioPPdolbysComboBox
                    ElseIf AviSynthChComboBoxV = "LangCls.AudioPPdolbypComboBox" Then
                        AviSynthChComboBox.Text = LangCls.AudioPPdolbypComboBox
                    Else '기본값
                        AviSynthChComboBox.Text = LangCls.AudioPPch20ComboBox
                    End If
                End If
                'AviSynthChComboBox

                If XTR.Name = "AudioPPFrm_AmplifyCheckBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then AmplifyCheckBox.Checked = XTRSTR Else AmplifyCheckBox.Checked = False
                End If

                If XTR.Name = "AudioPPFrm_AmplifyNumericUpDown" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then AmplifyNumericUpDown.Value = XTRSTR Else AmplifyNumericUpDown.Value = 0.0
                End If

                If XTR.Name = "AudioPPFrm_EQCheckBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then EQCheckBox.Checked = XTRSTR Else EQCheckBox.Checked = False
                End If

                If XTR.Name = "AudioPPFrm_EQ1TrackBar" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then EQ1TrackBar.Value = XTRSTR Else EQ1TrackBar.Value = 0
                End If

                If XTR.Name = "AudioPPFrm_EQ2TrackBar" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then EQ2TrackBar.Value = XTRSTR Else EQ2TrackBar.Value = 0
                End If

                If XTR.Name = "AudioPPFrm_EQ3TrackBar" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then EQ3TrackBar.Value = XTRSTR Else EQ3TrackBar.Value = 0
                End If

                If XTR.Name = "AudioPPFrm_EQ4TrackBar" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then EQ4TrackBar.Value = XTRSTR Else EQ4TrackBar.Value = 0
                End If

                If XTR.Name = "AudioPPFrm_EQ5TrackBar" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then EQ5TrackBar.Value = XTRSTR Else EQ5TrackBar.Value = 0
                End If

                If XTR.Name = "AudioPPFrm_EQ6TrackBar" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then EQ6TrackBar.Value = XTRSTR Else EQ6TrackBar.Value = 0
                End If

                If XTR.Name = "AudioPPFrm_EQ7TrackBar" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then EQ7TrackBar.Value = XTRSTR Else EQ7TrackBar.Value = 0
                End If

                If XTR.Name = "AudioPPFrm_EQ8TrackBar" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then EQ8TrackBar.Value = XTRSTR Else EQ8TrackBar.Value = 0
                End If

                If XTR.Name = "AudioPPFrm_EQ9TrackBar" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then EQ9TrackBar.Value = XTRSTR Else EQ9TrackBar.Value = 0
                End If

                If XTR.Name = "AudioPPFrm_EQ10TrackBar" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then EQ10TrackBar.Value = XTRSTR Else EQ10TrackBar.Value = 0
                End If

                If XTR.Name = "AudioPPFrm_EQ11TrackBar" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then EQ11TrackBar.Value = XTRSTR Else EQ11TrackBar.Value = 0
                End If

                If XTR.Name = "AudioPPFrm_EQ12TrackBar" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then EQ12TrackBar.Value = XTRSTR Else EQ12TrackBar.Value = 0
                End If

                If XTR.Name = "AudioPPFrm_EQ13TrackBar" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then EQ13TrackBar.Value = XTRSTR Else EQ13TrackBar.Value = 0
                End If

                If XTR.Name = "AudioPPFrm_EQ14TrackBar" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then EQ14TrackBar.Value = XTRSTR Else EQ14TrackBar.Value = 0
                End If

                If XTR.Name = "AudioPPFrm_EQ15TrackBar" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then EQ15TrackBar.Value = XTRSTR Else EQ15TrackBar.Value = 0
                End If

                If XTR.Name = "AudioPPFrm_EQ16TrackBar" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then EQ16TrackBar.Value = XTRSTR Else EQ16TrackBar.Value = 0
                End If

                If XTR.Name = "AudioPPFrm_EQ17TrackBar" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then EQ17TrackBar.Value = XTRSTR Else EQ17TrackBar.Value = 0
                End If

                If XTR.Name = "AudioPPFrm_EQ18TrackBar" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then EQ18TrackBar.Value = XTRSTR Else EQ18TrackBar.Value = 0
                End If

            Loop

        Catch ex As Exception
            MsgBox("XML_LOAD_ERROR :" & ex.Message)
        Finally
            XTR.Close()
        End Try

    End Sub

    Private Sub AudioPPFrm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        XML_LOAD(My.Application.Info.DirectoryPath & "\settings.xml")
    End Sub

    Private Sub AudioPPFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
                    APP_Panel.Font = New Font(FNXP, FS)
                Else
                    APP_Panel.Font = New Font(FN, FS)
                End If

                If XTR.Name = "OKBTN" Then OKBTN.Text = XTR.ReadString
                If XTR.Name = "CancelBTN" Then CancelBTN.Text = XTR.ReadString
                If XTR.Name = "DefBTN" Then DefBTN.Text = XTR.ReadString

                If XTR.Name = "AudioPPFrm" Then Me.Text = XTR.ReadString
                If XTR.Name = "AudioPPFrmAviSynthChGroupBox" Then AviSynthChGroupBox.Text = XTR.ReadString
                If XTR.Name = "AudioPPFrmAmplifyGroupBox" Then AmplifyGroupBox.Text = XTR.ReadString
                If XTR.Name = "AudioPPFrmAmplifyCheckBox" Then AmplifyCheckBox.Text = XTR.ReadString
                If XTR.Name = "AudioPPFrmEQGroupBox" Then EQGroupBox.Text = XTR.ReadString
                If XTR.Name = "AudioPPFrmEQCheckBox" Then EQCheckBox.Text = XTR.ReadString
                If XTR.Name = "AudioPPFrmEQZeroButton" Then EQZeroButton.Text = XTR.ReadString
                If XTR.Name = "AudioPPchoriginComboBox" Then LangCls.AudioPPchoriginComboBox = XTR.ReadString
                If XTR.Name = "AudioPPch10ComboBox" Then LangCls.AudioPPch10ComboBox = XTR.ReadString
                If XTR.Name = "AudioPPch20ComboBox" Then LangCls.AudioPPch20ComboBox = XTR.ReadString
                If XTR.Name = "AudioPPch51ComboBox" Then LangCls.AudioPPch51ComboBox = XTR.ReadString
                If XTR.Name = "AudioPPdolbysComboBox" Then LangCls.AudioPPdolbysComboBox = XTR.ReadString
                If XTR.Name = "AudioPPdolbypComboBox" Then LangCls.AudioPPdolbypComboBox = XTR.ReadString

            Loop
        Catch ex As Exception
            MsgBox("LANG_LOAD_ERROR :" & ex.Message)
        Finally
            XTR.Close()
        End Try
LANG_SKIP:
        '=========================================

        '음성부분 초기화
        AviSynthChComboBox.Items.Clear()
        AviSynthChComboBox.Items.Add(LangCls.AudioPPchoriginComboBox)
        AviSynthChComboBox.Items.Add(LangCls.AudioPPch10ComboBox)
        AviSynthChComboBox.Items.Add(LangCls.AudioPPch20ComboBox)
        AviSynthChComboBox.Items.Add(LangCls.AudioPPch51ComboBox)
        AviSynthChComboBox.Items.Add(LangCls.AudioPPdolbysComboBox)
        AviSynthChComboBox.Items.Add(LangCls.AudioPPdolbypComboBox)

        XML_LOAD(My.Application.Info.DirectoryPath & "\settings.xml")

    End Sub

    Private Sub AmplifyNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles AmplifyNumericUpDown.LostFocus
        AmplifyNumericUpDown.Text = AmplifyNumericUpDown.Value
    End Sub

    Private Sub AmplifyNumericUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AmplifyNumericUpDown.ValueChanged
        AmplifyTrackBar.Value = AmplifyNumericUpDown.Value * 10
    End Sub

    Private Sub AmplifyTrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AmplifyTrackBar.Scroll
        AmplifyNumericUpDown.Value = AmplifyTrackBar.Value / 10
    End Sub

    Private Sub EQZeroButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EQZeroButton.Click
        EQ1TrackBar.Value = 0
        EQ2TrackBar.Value = 0
        EQ3TrackBar.Value = 0
        EQ4TrackBar.Value = 0
        EQ5TrackBar.Value = 0
        EQ6TrackBar.Value = 0
        EQ7TrackBar.Value = 0
        EQ8TrackBar.Value = 0
        EQ9TrackBar.Value = 0
        EQ10TrackBar.Value = 0
        EQ11TrackBar.Value = 0
        EQ12TrackBar.Value = 0
        EQ13TrackBar.Value = 0
        EQ14TrackBar.Value = 0
        EQ15TrackBar.Value = 0
        EQ16TrackBar.Value = 0
        EQ17TrackBar.Value = 0
        EQ18TrackBar.Value = 0
    End Sub

    Private Sub EQ1TrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EQ1TrackBar.Scroll
        EQToolTip.SetToolTip(EQ1TrackBar, EQ1TrackBar.Value)
    End Sub

    Private Sub EQ2TrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EQ2TrackBar.Scroll
        EQToolTip.SetToolTip(EQ2TrackBar, EQ2TrackBar.Value)
    End Sub

    Private Sub EQ3TrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EQ3TrackBar.Scroll
        EQToolTip.SetToolTip(EQ3TrackBar, EQ3TrackBar.Value)
    End Sub

    Private Sub EQ4TrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EQ4TrackBar.Scroll
        EQToolTip.SetToolTip(EQ4TrackBar, EQ4TrackBar.Value)
    End Sub

    Private Sub EQ5TrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EQ5TrackBar.Scroll
        EQToolTip.SetToolTip(EQ5TrackBar, EQ5TrackBar.Value)
    End Sub

    Private Sub EQ6TrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EQ6TrackBar.Scroll
        EQToolTip.SetToolTip(EQ6TrackBar, EQ6TrackBar.Value)
    End Sub

    Private Sub EQ7TrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EQ7TrackBar.Scroll
        EQToolTip.SetToolTip(EQ7TrackBar, EQ7TrackBar.Value)
    End Sub

    Private Sub EQ8TrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EQ8TrackBar.Scroll
        EQToolTip.SetToolTip(EQ8TrackBar, EQ8TrackBar.Value)
    End Sub

    Private Sub EQ9TrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EQ9TrackBar.Scroll
        EQToolTip.SetToolTip(EQ9TrackBar, EQ9TrackBar.Value)
    End Sub

    Private Sub EQ10TrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EQ10TrackBar.Scroll
        EQToolTip.SetToolTip(EQ10TrackBar, EQ10TrackBar.Value)
    End Sub

    Private Sub EQ11TrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EQ11TrackBar.Scroll
        EQToolTip.SetToolTip(EQ11TrackBar, EQ11TrackBar.Value)
    End Sub

    Private Sub EQ12TrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EQ12TrackBar.Scroll
        EQToolTip.SetToolTip(EQ12TrackBar, EQ12TrackBar.Value)
    End Sub

    Private Sub EQ13TrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EQ13TrackBar.Scroll
        EQToolTip.SetToolTip(EQ13TrackBar, EQ13TrackBar.Value)
    End Sub

    Private Sub EQ14TrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EQ14TrackBar.Scroll
        EQToolTip.SetToolTip(EQ14TrackBar, EQ14TrackBar.Value)
    End Sub

    Private Sub EQ15TrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EQ15TrackBar.Scroll
        EQToolTip.SetToolTip(EQ15TrackBar, EQ15TrackBar.Value)
    End Sub

    Private Sub EQ16TrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EQ16TrackBar.Scroll
        EQToolTip.SetToolTip(EQ16TrackBar, EQ16TrackBar.Value)
    End Sub

    Private Sub EQ17TrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EQ17TrackBar.Scroll
        EQToolTip.SetToolTip(EQ17TrackBar, EQ17TrackBar.Value)
    End Sub

    Private Sub EQ18TrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EQ18TrackBar.Scroll
        EQToolTip.SetToolTip(EQ18TrackBar, EQ18TrackBar.Value)
    End Sub

    Private Sub AmplifyCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AmplifyCheckBox.CheckedChanged
        If AmplifyCheckBox.Checked = True Then
            AmplifyNumericUpDown.Enabled = True
            AmplifyTrackBar.Enabled = True
            dBLabel.Enabled = True
        Else
            AmplifyNumericUpDown.Enabled = False
            AmplifyTrackBar.Enabled = False
            dBLabel.Enabled = False
        End If
    End Sub

    Private Sub EQCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EQCheckBox.CheckedChanged
        If EQCheckBox.Checked = True Then
            p20dBLabel.Enabled = True
            m20dbLabel.Enabled = True
            EQZeroButton.Enabled = True
            EQ1TrackBar.Enabled = True
            EQ2TrackBar.Enabled = True
            EQ3TrackBar.Enabled = True
            EQ4TrackBar.Enabled = True
            EQ5TrackBar.Enabled = True
            EQ6TrackBar.Enabled = True
            EQ7TrackBar.Enabled = True
            EQ8TrackBar.Enabled = True
            EQ9TrackBar.Enabled = True
            EQ10TrackBar.Enabled = True
            EQ11TrackBar.Enabled = True
            EQ12TrackBar.Enabled = True
            EQ13TrackBar.Enabled = True
            EQ14TrackBar.Enabled = True
            EQ15TrackBar.Enabled = True
            EQ16TrackBar.Enabled = True
            EQ17TrackBar.Enabled = True
            EQ18TrackBar.Enabled = True
            EQ1Label.Enabled = True
            EQ2Label.Enabled = True
            EQ3Label.Enabled = True
            EQ4Label.Enabled = True
            EQ5Label.Enabled = True
            EQ6Label.Enabled = True
            EQ7Label.Enabled = True
            EQ8Label.Enabled = True
            EQ9Label.Enabled = True
            EQ10Label.Enabled = True
            EQ11Label.Enabled = True
            EQ12Label.Enabled = True
            EQ13Label.Enabled = True
            EQ14Label.Enabled = True
            EQ15Label.Enabled = True
            EQ16Label.Enabled = True
            EQ17Label.Enabled = True
            EQ18Label.Enabled = True
        Else
            p20dBLabel.Enabled = False
            m20dbLabel.Enabled = False
            EQZeroButton.Enabled = False
            EQ1TrackBar.Enabled = False
            EQ2TrackBar.Enabled = False
            EQ3TrackBar.Enabled = False
            EQ4TrackBar.Enabled = False
            EQ5TrackBar.Enabled = False
            EQ6TrackBar.Enabled = False
            EQ7TrackBar.Enabled = False
            EQ8TrackBar.Enabled = False
            EQ9TrackBar.Enabled = False
            EQ10TrackBar.Enabled = False
            EQ11TrackBar.Enabled = False
            EQ12TrackBar.Enabled = False
            EQ13TrackBar.Enabled = False
            EQ14TrackBar.Enabled = False
            EQ15TrackBar.Enabled = False
            EQ16TrackBar.Enabled = False
            EQ17TrackBar.Enabled = False
            EQ18TrackBar.Enabled = False
            EQ1Label.Enabled = False
            EQ2Label.Enabled = False
            EQ3Label.Enabled = False
            EQ4Label.Enabled = False
            EQ5Label.Enabled = False
            EQ6Label.Enabled = False
            EQ7Label.Enabled = False
            EQ8Label.Enabled = False
            EQ9Label.Enabled = False
            EQ10Label.Enabled = False
            EQ11Label.Enabled = False
            EQ12Label.Enabled = False
            EQ13Label.Enabled = False
            EQ14Label.Enabled = False
            EQ15Label.Enabled = False
            EQ16Label.Enabled = False
            EQ17Label.Enabled = False
            EQ18Label.Enabled = False
        End If
    End Sub

    Private Sub OKBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKBTN.Click
        XML_CHANGE(My.Application.Info.DirectoryPath & "\settings.xml")
        Close()
    End Sub

    Private Sub CancelBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBTN.Click
        Close()
    End Sub

    Private Sub XML_CHANGE(ByVal src As String)

        Try
            Dim XDoc As New XmlDocument()
            Dim XNode As XmlNode
            XDoc.Load(src)
            '============== 시작

            'AviSynthChComboBox
            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/AudioPPFrm_AviSynthChComboBox")
            If AviSynthChComboBox.Text = LangCls.AudioPPchoriginComboBox Then
                If Not XNode Is Nothing Then XNode.InnerText = "LangCls.AudioPPchoriginComboBox"
            ElseIf AviSynthChComboBox.Text = LangCls.AudioPPch10ComboBox Then
                If Not XNode Is Nothing Then XNode.InnerText = "LangCls.AudioPPch10ComboBox"
            ElseIf AviSynthChComboBox.Text = LangCls.AudioPPch20ComboBox Then
                If Not XNode Is Nothing Then XNode.InnerText = "LangCls.AudioPPch20ComboBox"
            ElseIf AviSynthChComboBox.Text = LangCls.AudioPPch51ComboBox Then
                If Not XNode Is Nothing Then XNode.InnerText = "LangCls.AudioPPch51ComboBox"
            ElseIf AviSynthChComboBox.Text = LangCls.AudioPPdolbysComboBox Then
                If Not XNode Is Nothing Then XNode.InnerText = "LangCls.AudioPPdolbysComboBox"
            ElseIf AviSynthChComboBox.Text = LangCls.AudioPPdolbypComboBox Then
                If Not XNode Is Nothing Then XNode.InnerText = "LangCls.AudioPPdolbypComboBox"
            End If
            'AviSynthChComboBox

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/AudioPPFrm_AmplifyCheckBox")
            If Not XNode Is Nothing Then XNode.InnerText = AmplifyCheckBox.Checked

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/AudioPPFrm_AmplifyNumericUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = AmplifyNumericUpDown.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/AudioPPFrm_EQCheckBox")
            If Not XNode Is Nothing Then XNode.InnerText = EQCheckBox.Checked

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/AudioPPFrm_EQ1TrackBar")
            If Not XNode Is Nothing Then XNode.InnerText = EQ1TrackBar.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/AudioPPFrm_EQ2TrackBar")
            If Not XNode Is Nothing Then XNode.InnerText = EQ2TrackBar.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/AudioPPFrm_EQ3TrackBar")
            If Not XNode Is Nothing Then XNode.InnerText = EQ3TrackBar.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/AudioPPFrm_EQ4TrackBar")
            If Not XNode Is Nothing Then XNode.InnerText = EQ4TrackBar.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/AudioPPFrm_EQ5TrackBar")
            If Not XNode Is Nothing Then XNode.InnerText = EQ5TrackBar.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/AudioPPFrm_EQ6TrackBar")
            If Not XNode Is Nothing Then XNode.InnerText = EQ6TrackBar.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/AudioPPFrm_EQ7TrackBar")
            If Not XNode Is Nothing Then XNode.InnerText = EQ7TrackBar.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/AudioPPFrm_EQ8TrackBar")
            If Not XNode Is Nothing Then XNode.InnerText = EQ8TrackBar.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/AudioPPFrm_EQ9TrackBar")
            If Not XNode Is Nothing Then XNode.InnerText = EQ9TrackBar.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/AudioPPFrm_EQ10TrackBar")
            If Not XNode Is Nothing Then XNode.InnerText = EQ10TrackBar.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/AudioPPFrm_EQ11TrackBar")
            If Not XNode Is Nothing Then XNode.InnerText = EQ11TrackBar.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/AudioPPFrm_EQ12TrackBar")
            If Not XNode Is Nothing Then XNode.InnerText = EQ12TrackBar.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/AudioPPFrm_EQ13TrackBar")
            If Not XNode Is Nothing Then XNode.InnerText = EQ13TrackBar.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/AudioPPFrm_EQ14TrackBar")
            If Not XNode Is Nothing Then XNode.InnerText = EQ14TrackBar.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/AudioPPFrm_EQ15TrackBar")
            If Not XNode Is Nothing Then XNode.InnerText = EQ15TrackBar.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/AudioPPFrm_EQ16TrackBar")
            If Not XNode Is Nothing Then XNode.InnerText = EQ16TrackBar.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/AudioPPFrm_EQ17TrackBar")
            If Not XNode Is Nothing Then XNode.InnerText = EQ17TrackBar.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/AudioPPFrm_EQ18TrackBar")
            If Not XNode Is Nothing Then XNode.InnerText = EQ18TrackBar.Value

            '============== 끝
            XDoc.Save(src)
        Catch ex As Exception
            MsgBox("XML_CHANGE_ERROR :" & ex.Message)
        End Try

        'SAVE, Change용
        If MainFrm.EncListListView.SelectedItems.Count <> 0 Then
            Dim index As Integer = MainFrm.EncListListView.SelectedItems(index).Index
            MainFrm.GET_OutputINFO(index)  '출력정보
        End If
        'Change용 프리셋 설정된 파일 표시 지우기
        MainFrm.PresetLabel.Text = LangCls.MainUserStr

    End Sub

    Private Sub APP_Panel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles APP_Panel.Paint

    End Sub
End Class