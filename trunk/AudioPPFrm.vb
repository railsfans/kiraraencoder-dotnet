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

Public Class AudioPPFrm

    Dim OKBTNCLK As Boolean = False

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
        NormalizeCheckBox.Checked = False
        NormalizeTrackBar.Value = 100
        NormalizeNumericUpDown.Value = 1.0
        AudioASCheckBox.Checked = False
        EQComboBox.Text = "Customize"
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

                If XTR.Name = "AudioPPFrm_NormalizeCheckBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then NormalizeCheckBox.Checked = XTRSTR Else NormalizeCheckBox.Checked = False
                End If

                If XTR.Name = "AudioPPFrm_NormalizeTrackBar" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then NormalizeTrackBar.Value = XTRSTR Else NormalizeTrackBar.Value = 100
                End If

                If XTR.Name = "AudioPPFrm_NormalizeNumericUpDown" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then NormalizeNumericUpDown.Value = XTRSTR Else NormalizeNumericUpDown.Value = 1.0
                End If

                If XTR.Name = "AudioPPFrm_AudioASCheckBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then AudioASCheckBox.Checked = XTRSTR Else AudioASCheckBox.Checked = False
                End If

                If XTR.Name = "AudioPPFrm_EQComboBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then EQComboBox.Text = XTRSTR Else EQComboBox.Text = "Customize"
                End If

            Loop

        Catch ex As Exception
            MsgBox("XML_LOAD_ERROR :" & ex.Message)
        Finally
            XTR.Close()
            SR.Close()
        End Try

    End Sub

    Private Sub AudioPPFrm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Timer1.Enabled = False

        If OKBTNCLK = False Then XML_LOAD(FunctionCls.AppInfoDirectoryPath & "\settings.xml")
    End Sub

    Private Sub AudioPPFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
                If XTR.Name = "AudioPPFrmAudioASCheckBox" Then AudioASCheckBox.Text = XTR.ReadString
                If XTR.Name = "AudioPPFrmNormalizeGroupBox" Then NormalizeGroupBox.Text = XTR.ReadString
                If XTR.Name = "AudioPPFrmNormalizeCheckBox" Then NormalizeCheckBox.Text = XTR.ReadString
                If XTR.Name = "AudioPPFrmLoadPresetBTN" Then LoadPresetBTN.Text = XTR.ReadString
                If XTR.Name = "AudioPPFrmSavePresetBTN" Then SavePresetBTN.Text = XTR.ReadString

            Loop
        Catch ex As Exception
            MsgBox("LANG_LOAD_ERROR :" & ex.Message)
        Finally
            XTR.Close()
            SR.Close()
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

        XML_LOAD(FunctionCls.AppInfoDirectoryPath & "\settings.xml")

        Timer1.Enabled = True

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
        EQComboBox.Text = "Customize"
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
            Label1.Enabled = True
            Label2.Enabled = True
            Label3.Enabled = True
            Label4.Enabled = True
            Label5.Enabled = True
            Label6.Enabled = True
            Label7.Enabled = True
            Label8.Enabled = True
            Label9.Enabled = True
            Label10.Enabled = True
            Label11.Enabled = True
            Label12.Enabled = True
            Label13.Enabled = True
            Label14.Enabled = True
            Label15.Enabled = True
            Label16.Enabled = True
            Label17.Enabled = True
            Label18.Enabled = True
            EQComboBox.Enabled = True
            LoadPresetBTN.Enabled = True
            SavePresetBTN.Enabled = True
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
            Label1.Enabled = False
            Label2.Enabled = False
            Label3.Enabled = False
            Label4.Enabled = False
            Label5.Enabled = False
            Label6.Enabled = False
            Label7.Enabled = False
            Label8.Enabled = False
            Label9.Enabled = False
            Label10.Enabled = False
            Label11.Enabled = False
            Label12.Enabled = False
            Label13.Enabled = False
            Label14.Enabled = False
            Label15.Enabled = False
            Label16.Enabled = False
            Label17.Enabled = False
            Label18.Enabled = False
            EQComboBox.Enabled = False
            LoadPresetBTN.Enabled = False
            SavePresetBTN.Enabled = False
        End If
    End Sub

    Private Sub OKBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKBTN.Click
        OKBTNCLK = True

        MainFrm.XML_SAVE(FunctionCls.AppInfoDirectoryPath & "\settings.xml")

        '프리셋 설정된 파일 표시 지우기
        MainFrm.PresetLabel.Text = LangCls.MainUserStr

        Close()
    End Sub

    Private Sub CancelBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBTN.Click
        Close()
    End Sub

    Private Sub NormalizeCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NormalizeCheckBox.CheckedChanged
        If NormalizeCheckBox.Checked = True Then
            NormalizeNumericUpDown.Enabled = True
            NormalizeTrackBar.Enabled = True
        Else
            NormalizeNumericUpDown.Enabled = False
            NormalizeTrackBar.Enabled = False
        End If
    End Sub

    Private Sub NormalizeTrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NormalizeTrackBar.Scroll
        NormalizeNumericUpDown.Value = NormalizeTrackBar.Value / 100
    End Sub

    Private Sub NormalizeNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles NormalizeNumericUpDown.LostFocus
        NormalizeNumericUpDown.Text = NormalizeNumericUpDown.Value
    End Sub

    Private Sub NormalizeNumericUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NormalizeNumericUpDown.ValueChanged
        NormalizeTrackBar.Value = NormalizeNumericUpDown.Value * 100
    End Sub

    Private Sub OpenPresetBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadPresetBTN.Click

        OpenFileDialog1.FileName = ""
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName = "" Then Exit Sub

        Using SR As StreamReader = New StreamReader(OpenFileDialog1.FileName)

            Dim i As Integer = 1
            Dim RL As String = SR.ReadLine

            Do While (Not RL Is Nothing)

                If i = 1 Then
                    EQ1TrackBar.Value = RL
                ElseIf i = 2 Then
                    EQ2TrackBar.Value = RL
                ElseIf i = 3 Then
                    EQ3TrackBar.Value = RL
                ElseIf i = 4 Then
                    EQ4TrackBar.Value = RL
                ElseIf i = 5 Then
                    EQ5TrackBar.Value = RL
                ElseIf i = 6 Then
                    EQ6TrackBar.Value = RL
                ElseIf i = 7 Then
                    EQ7TrackBar.Value = RL
                ElseIf i = 8 Then
                    EQ8TrackBar.Value = RL
                ElseIf i = 9 Then
                    EQ9TrackBar.Value = RL
                ElseIf i = 10 Then
                    EQ10TrackBar.Value = RL
                ElseIf i = 11 Then
                    EQ11TrackBar.Value = RL
                ElseIf i = 12 Then
                    EQ12TrackBar.Value = RL
                ElseIf i = 13 Then
                    EQ13TrackBar.Value = RL
                ElseIf i = 14 Then
                    EQ14TrackBar.Value = RL
                ElseIf i = 15 Then
                    EQ15TrackBar.Value = RL
                ElseIf i = 16 Then
                    EQ16TrackBar.Value = RL
                ElseIf i = 17 Then
                    EQ17TrackBar.Value = RL
                ElseIf i = 18 Then
                    EQ18TrackBar.Value = RL
                End If

                i += 1
                RL = SR.ReadLine

            Loop

            SR.Close()
        End Using

        EQComboBox.Text = "Customize"

    End Sub

    Private Sub SavePresetBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SavePresetBTN.Click

        SaveFileDialog1.FileName = ""
        SaveFileDialog1.ShowDialog()
        If SaveFileDialog1.FileName = "" Then Exit Sub

        Dim EQV As String = ""
        EQV = EQ1TrackBar.Value & vbNewLine & _
                EQ2TrackBar.Value & vbNewLine & _
                EQ3TrackBar.Value & vbNewLine & _
                EQ4TrackBar.Value & vbNewLine & _
                EQ5TrackBar.Value & vbNewLine & _
                EQ6TrackBar.Value & vbNewLine & _
                EQ7TrackBar.Value & vbNewLine & _
                EQ8TrackBar.Value & vbNewLine & _
                EQ9TrackBar.Value & vbNewLine & _
                EQ10TrackBar.Value & vbNewLine & _
                EQ11TrackBar.Value & vbNewLine & _
                EQ12TrackBar.Value & vbNewLine & _
                EQ13TrackBar.Value & vbNewLine & _
                EQ14TrackBar.Value & vbNewLine & _
                EQ15TrackBar.Value & vbNewLine & _
                EQ16TrackBar.Value & vbNewLine & _
                EQ17TrackBar.Value & vbNewLine & _
                EQ18TrackBar.Value
        Dim SW As New StreamWriter(SaveFileDialog1.FileName, False, System.Text.Encoding.Default)
        SW.Write(EQV)
        SW.Close()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Text = EQ1TrackBar.Value
        Label2.Text = EQ2TrackBar.Value
        Label3.Text = EQ3TrackBar.Value
        Label4.Text = EQ4TrackBar.Value
        Label5.Text = EQ5TrackBar.Value
        Label6.Text = EQ6TrackBar.Value
        Label7.Text = EQ7TrackBar.Value
        Label8.Text = EQ8TrackBar.Value
        Label9.Text = EQ9TrackBar.Value
        Label10.Text = EQ10TrackBar.Value
        Label11.Text = EQ11TrackBar.Value
        Label12.Text = EQ12TrackBar.Value
        Label13.Text = EQ13TrackBar.Value
        Label14.Text = EQ14TrackBar.Value
        Label15.Text = EQ15TrackBar.Value
        Label16.Text = EQ16TrackBar.Value
        Label17.Text = EQ17TrackBar.Value
        Label18.Text = EQ18TrackBar.Value
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EQComboBox.SelectedIndexChanged
        If EQComboBox.Text = "Customize" Then
        ElseIf EQComboBox.Text = "1965" Then
            EQ1TrackBar.Value = -20
            EQ2TrackBar.Value = -16
            EQ3TrackBar.Value = -7
            EQ4TrackBar.Value = -4
            EQ5TrackBar.Value = -4
            EQ6TrackBar.Value = -4
            EQ7TrackBar.Value = -7
            EQ8TrackBar.Value = -7
            EQ9TrackBar.Value = 3
            EQ10TrackBar.Value = 3
            EQ11TrackBar.Value = -2
            EQ12TrackBar.Value = -4
            EQ13TrackBar.Value = 4
            EQ14TrackBar.Value = 1
            EQ15TrackBar.Value = 1
            EQ16TrackBar.Value = -4
            EQ17TrackBar.Value = -6
            EQ18TrackBar.Value = -12
        ElseIf EQComboBox.Text = "Air" Then
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
            EQ17TrackBar.Value = 3
            EQ18TrackBar.Value = 2
        ElseIf EQComboBox.Text = "Brittle" Then
            EQ1TrackBar.Value = -12
            EQ2TrackBar.Value = -10
            EQ3TrackBar.Value = -9
            EQ4TrackBar.Value = -8
            EQ5TrackBar.Value = -7
            EQ6TrackBar.Value = -6
            EQ7TrackBar.Value = -5
            EQ8TrackBar.Value = -3
            EQ9TrackBar.Value = -2
            EQ10TrackBar.Value = -2
            EQ11TrackBar.Value = -2
            EQ12TrackBar.Value = -2
            EQ13TrackBar.Value = -1
            EQ14TrackBar.Value = 1
            EQ15TrackBar.Value = 4
            EQ16TrackBar.Value = 4
            EQ17TrackBar.Value = 1
            EQ18TrackBar.Value = 0
        ElseIf EQComboBox.Text = "Car Stereo" Then
            EQ1TrackBar.Value = -5
            EQ2TrackBar.Value = 0
            EQ3TrackBar.Value = 1
            EQ4TrackBar.Value = 0
            EQ5TrackBar.Value = 0
            EQ6TrackBar.Value = -4
            EQ7TrackBar.Value = -4
            EQ8TrackBar.Value = -5
            EQ9TrackBar.Value = -5
            EQ10TrackBar.Value = -5
            EQ11TrackBar.Value = -3
            EQ12TrackBar.Value = -2
            EQ13TrackBar.Value = -2
            EQ14TrackBar.Value = 0
            EQ15TrackBar.Value = 1
            EQ16TrackBar.Value = 0
            EQ17TrackBar.Value = -2
            EQ18TrackBar.Value = -5
        ElseIf EQComboBox.Text = "Classic V" Then
            EQ1TrackBar.Value = 5
            EQ2TrackBar.Value = 2
            EQ3TrackBar.Value = 0
            EQ4TrackBar.Value = -2
            EQ5TrackBar.Value = -5
            EQ6TrackBar.Value = -6
            EQ7TrackBar.Value = -8
            EQ8TrackBar.Value = -8
            EQ9TrackBar.Value = -7
            EQ10TrackBar.Value = -7
            EQ11TrackBar.Value = -4
            EQ12TrackBar.Value = -3
            EQ13TrackBar.Value = -1
            EQ14TrackBar.Value = 1
            EQ15TrackBar.Value = 3
            EQ16TrackBar.Value = 5
            EQ17TrackBar.Value = 5
            EQ18TrackBar.Value = 4
        ElseIf EQComboBox.Text = "Clear" Then
            EQ1TrackBar.Value = 1
            EQ2TrackBar.Value = 1
            EQ3TrackBar.Value = 0
            EQ4TrackBar.Value = 0
            EQ5TrackBar.Value = 0
            EQ6TrackBar.Value = -3
            EQ7TrackBar.Value = 0
            EQ8TrackBar.Value = 0
            EQ9TrackBar.Value = 0
            EQ10TrackBar.Value = 0
            EQ11TrackBar.Value = 0
            EQ12TrackBar.Value = 0
            EQ13TrackBar.Value = 0
            EQ14TrackBar.Value = 0
            EQ15TrackBar.Value = 2
            EQ16TrackBar.Value = 2
            EQ17TrackBar.Value = 2
            EQ18TrackBar.Value = 1
        ElseIf EQComboBox.Text = "Dark" Then
            EQ1TrackBar.Value = -6
            EQ2TrackBar.Value = -2
            EQ3TrackBar.Value = -2
            EQ4TrackBar.Value = -2
            EQ5TrackBar.Value = -2
            EQ6TrackBar.Value = -2
            EQ7TrackBar.Value = -2
            EQ8TrackBar.Value = -2
            EQ9TrackBar.Value = -2
            EQ10TrackBar.Value = -2
            EQ11TrackBar.Value = -2
            EQ12TrackBar.Value = -5
            EQ13TrackBar.Value = -8
            EQ14TrackBar.Value = -10
            EQ15TrackBar.Value = -12
            EQ16TrackBar.Value = -14
            EQ17TrackBar.Value = -18
            EQ18TrackBar.Value = -18
        ElseIf EQComboBox.Text = "DEATH" Then
            EQ1TrackBar.Value = 20
            EQ2TrackBar.Value = 17
            EQ3TrackBar.Value = 12
            EQ4TrackBar.Value = 8
            EQ5TrackBar.Value = 4
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
        ElseIf EQComboBox.Text = "Drums" Then
            EQ1TrackBar.Value = 2
            EQ2TrackBar.Value = 1
            EQ3TrackBar.Value = 0
            EQ4TrackBar.Value = 0
            EQ5TrackBar.Value = 0
            EQ6TrackBar.Value = -2
            EQ7TrackBar.Value = 0
            EQ8TrackBar.Value = -2
            EQ9TrackBar.Value = 0
            EQ10TrackBar.Value = 0
            EQ11TrackBar.Value = 0
            EQ12TrackBar.Value = 0
            EQ13TrackBar.Value = 2
            EQ14TrackBar.Value = 0
            EQ15TrackBar.Value = 0
            EQ16TrackBar.Value = 3
            EQ17TrackBar.Value = 0
            EQ18TrackBar.Value = 0
        ElseIf EQComboBox.Text = "Flat" Then
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
        ElseIf EQComboBox.Text = "Home Theater" Then
            EQ1TrackBar.Value = 5
            EQ2TrackBar.Value = 2
            EQ3TrackBar.Value = 0
            EQ4TrackBar.Value = -2
            EQ5TrackBar.Value = -3
            EQ6TrackBar.Value = -5
            EQ7TrackBar.Value = -6
            EQ8TrackBar.Value = -6
            EQ9TrackBar.Value = -5
            EQ10TrackBar.Value = -2
            EQ11TrackBar.Value = -1
            EQ12TrackBar.Value = 0
            EQ13TrackBar.Value = -1
            EQ14TrackBar.Value = -3
            EQ15TrackBar.Value = 3
            EQ16TrackBar.Value = 4
            EQ17TrackBar.Value = 3
            EQ18TrackBar.Value = 0
        ElseIf EQComboBox.Text = "Loudness" Then
            EQ1TrackBar.Value = 4
            EQ2TrackBar.Value = 4
            EQ3TrackBar.Value = 4
            EQ4TrackBar.Value = 2
            EQ5TrackBar.Value = -2
            EQ6TrackBar.Value = -2
            EQ7TrackBar.Value = -2
            EQ8TrackBar.Value = -2
            EQ9TrackBar.Value = -2
            EQ10TrackBar.Value = -2
            EQ11TrackBar.Value = -2
            EQ12TrackBar.Value = -4
            EQ13TrackBar.Value = -10
            EQ14TrackBar.Value = -7
            EQ15TrackBar.Value = 0
            EQ16TrackBar.Value = 3
            EQ17TrackBar.Value = 4
            EQ18TrackBar.Value = 4
        ElseIf EQComboBox.Text = "Pop" Then
            EQ1TrackBar.Value = 6
            EQ2TrackBar.Value = 5
            EQ3TrackBar.Value = 3
            EQ4TrackBar.Value = 0
            EQ5TrackBar.Value = -2
            EQ6TrackBar.Value = -4
            EQ7TrackBar.Value = -4
            EQ8TrackBar.Value = -6
            EQ9TrackBar.Value = -3
            EQ10TrackBar.Value = 1
            EQ11TrackBar.Value = 0
            EQ12TrackBar.Value = 0
            EQ13TrackBar.Value = 2
            EQ14TrackBar.Value = 1
            EQ15TrackBar.Value = 2
            EQ16TrackBar.Value = 4
            EQ17TrackBar.Value = 5
            EQ18TrackBar.Value = 6
        ElseIf EQComboBox.Text = "Premaster" Then
            EQ1TrackBar.Value = 0
            EQ2TrackBar.Value = 1
            EQ3TrackBar.Value = 3
            EQ4TrackBar.Value = 0
            EQ5TrackBar.Value = -3
            EQ6TrackBar.Value = -3
            EQ7TrackBar.Value = 0
            EQ8TrackBar.Value = 0
            EQ9TrackBar.Value = 0
            EQ10TrackBar.Value = 2
            EQ11TrackBar.Value = 0
            EQ12TrackBar.Value = 0
            EQ13TrackBar.Value = 3
            EQ14TrackBar.Value = 0
            EQ15TrackBar.Value = 3
            EQ16TrackBar.Value = 1
            EQ17TrackBar.Value = 3
            EQ18TrackBar.Value = 2
        ElseIf EQComboBox.Text = "Presence" Then
            EQ1TrackBar.Value = 0
            EQ2TrackBar.Value = 0
            EQ3TrackBar.Value = 0
            EQ4TrackBar.Value = 0
            EQ5TrackBar.Value = 0
            EQ6TrackBar.Value = 0
            EQ7TrackBar.Value = 0
            EQ8TrackBar.Value = 0
            EQ9TrackBar.Value = 0
            EQ10TrackBar.Value = 3
            EQ11TrackBar.Value = 5
            EQ12TrackBar.Value = 4
            EQ13TrackBar.Value = 3
            EQ14TrackBar.Value = 2
            EQ15TrackBar.Value = 0
            EQ16TrackBar.Value = 0
            EQ17TrackBar.Value = 0
            EQ18TrackBar.Value = 0
        ElseIf EQComboBox.Text = "Punch & Sparkle" Then
            EQ1TrackBar.Value = 3
            EQ2TrackBar.Value = 5
            EQ3TrackBar.Value = 3
            EQ4TrackBar.Value = -1
            EQ5TrackBar.Value = -3
            EQ6TrackBar.Value = -5
            EQ7TrackBar.Value = -5
            EQ8TrackBar.Value = -3
            EQ9TrackBar.Value = -2
            EQ10TrackBar.Value = 1
            EQ11TrackBar.Value = 1
            EQ12TrackBar.Value = 1
            EQ13TrackBar.Value = 0
            EQ14TrackBar.Value = 2
            EQ15TrackBar.Value = 1
            EQ16TrackBar.Value = 3
            EQ17TrackBar.Value = 5
            EQ18TrackBar.Value = 3
        ElseIf EQComboBox.Text = "Shimmer" Then
            EQ1TrackBar.Value = 0
            EQ2TrackBar.Value = 0
            EQ3TrackBar.Value = 0
            EQ4TrackBar.Value = -2
            EQ5TrackBar.Value = -2
            EQ6TrackBar.Value = -7
            EQ7TrackBar.Value = -5
            EQ8TrackBar.Value = 0
            EQ9TrackBar.Value = 0
            EQ10TrackBar.Value = 0
            EQ11TrackBar.Value = 0
            EQ12TrackBar.Value = 0
            EQ13TrackBar.Value = 4
            EQ14TrackBar.Value = 1
            EQ15TrackBar.Value = 3
            EQ16TrackBar.Value = 3
            EQ17TrackBar.Value = 4
            EQ18TrackBar.Value = 0
        ElseIf EQComboBox.Text = "Soft Bass" Then
            EQ1TrackBar.Value = 3
            EQ2TrackBar.Value = 5
            EQ3TrackBar.Value = 4
            EQ4TrackBar.Value = 0
            EQ5TrackBar.Value = -13
            EQ6TrackBar.Value = -7
            EQ7TrackBar.Value = -5
            EQ8TrackBar.Value = -5
            EQ9TrackBar.Value = -1
            EQ10TrackBar.Value = 2
            EQ11TrackBar.Value = 5
            EQ12TrackBar.Value = 1
            EQ13TrackBar.Value = -1
            EQ14TrackBar.Value = -1
            EQ15TrackBar.Value = -2
            EQ16TrackBar.Value = -7
            EQ17TrackBar.Value = -9
            EQ18TrackBar.Value = -14
        ElseIf EQComboBox.Text = "Strings" Then
            EQ1TrackBar.Value = -3
            EQ2TrackBar.Value = -4
            EQ3TrackBar.Value = -4
            EQ4TrackBar.Value = -5
            EQ5TrackBar.Value = -5
            EQ6TrackBar.Value = -4
            EQ7TrackBar.Value = -4
            EQ8TrackBar.Value = -3
            EQ9TrackBar.Value = -2
            EQ10TrackBar.Value = -2
            EQ11TrackBar.Value = -2
            EQ12TrackBar.Value = -2
            EQ13TrackBar.Value = -1
            EQ14TrackBar.Value = 2
            EQ15TrackBar.Value = 3
            EQ16TrackBar.Value = 0
            EQ17TrackBar.Value = -2
            EQ18TrackBar.Value = -2
        End If
    End Sub

    Private Sub EQ1TrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EQ1TrackBar.Scroll
        EQComboBox.Text = "Customize"
    End Sub

    Private Sub EQ2TrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EQ2TrackBar.Scroll
        EQComboBox.Text = "Customize"
    End Sub

    Private Sub EQ3TrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EQ3TrackBar.Scroll
        EQComboBox.Text = "Customize"
    End Sub

    Private Sub EQ4TrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EQ4TrackBar.Scroll
        EQComboBox.Text = "Customize"
    End Sub

    Private Sub EQ5TrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EQ5TrackBar.Scroll
        EQComboBox.Text = "Customize"
    End Sub

    Private Sub EQ6TrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EQ6TrackBar.Scroll
        EQComboBox.Text = "Customize"
    End Sub

    Private Sub EQ7TrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EQ7TrackBar.Scroll
        EQComboBox.Text = "Customize"
    End Sub

    Private Sub EQ8TrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EQ8TrackBar.Scroll
        EQComboBox.Text = "Customize"
    End Sub

    Private Sub EQ9TrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EQ9TrackBar.Scroll
        EQComboBox.Text = "Customize"
    End Sub

    Private Sub EQ10TrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EQ10TrackBar.Scroll
        EQComboBox.Text = "Customize"
    End Sub

    Private Sub EQ11TrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EQ11TrackBar.Scroll
        EQComboBox.Text = "Customize"
    End Sub

    Private Sub EQ12TrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EQ12TrackBar.Scroll
        EQComboBox.Text = "Customize"
    End Sub

    Private Sub EQ13TrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EQ13TrackBar.Scroll
        EQComboBox.Text = "Customize"
    End Sub

    Private Sub EQ14TrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EQ14TrackBar.Scroll
        EQComboBox.Text = "Customize"
    End Sub

    Private Sub EQ15TrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EQ15TrackBar.Scroll
        EQComboBox.Text = "Customize"
    End Sub

    Private Sub EQ16TrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EQ16TrackBar.Scroll
        EQComboBox.Text = "Customize"
    End Sub

    Private Sub EQ17TrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EQ17TrackBar.Scroll
        EQComboBox.Text = "Customize"
    End Sub

    Private Sub EQ18TrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EQ18TrackBar.Scroll
        EQComboBox.Text = "Customize"
    End Sub
End Class