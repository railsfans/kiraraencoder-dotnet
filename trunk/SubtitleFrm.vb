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

Imports System.Xml
Imports System.IO

Public Class SubtitleFrm

    Private Sub DefBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefBTN.Click

        '자막
        SubtitleCheckBox.Checked = True
        EncComboBox.Text = "DEFAULT (1)"
        FontComboBox.Text = "Arial"
        SizeUpDown.Value = 22
        ItalicCheckBox.Checked = False
        BoldCheckBox.Checked = False
        PrimaryColourTrackBar.Value = 0
        OutlineColourTrackBar.Value = 0
        BackColourTrackBar.Value = 128
        OutlineUpDown.Value = 1.0
        BackUpDown.Value = 2.0
        BorderStyle1.Checked = True
        BorderStyle3.Checked = False
        Alignment5RadioButton.Checked = False
        Alignment6RadioButton.Checked = False
        Alignment4RadioButton.Checked = False
        Alignment9RadioButton.Checked = False
        Alignment7RadioButton.Checked = False
        Alignment8RadioButton.Checked = False
        Alignment1RadioButton.Checked = False
        Alignment2RadioButton.Checked = True
        Alignment3RadioButton.Checked = False
        MarginLNumericUpDown.Value = 10
        MarginRNumericUpDown.Value = 10
        MarginVNumericUpDown.Value = 20
        PrimaryColourPanel.BackColor = Color.FromArgb(-1)
        OutlineColourPanel.BackColor = Color.FromArgb(-16777216)
        BackColourPanel.BackColor = Color.FromArgb(-16777216)
        SecondaryColourPanel.BackColor = Color.FromArgb(-256)
        SecondaryColourTrackBar.Value = 0
        StrikeOutCheckBox.Checked = False
        UnderlineCheckBox.Checked = False
        SpacingNumericUpDown.Value = 0.0
        AngleNumericUpDown.Value = 0
        ScaleXNumericUpDown.Value = 100.0
        ScaleYNumericUpDown.Value = 100.0

        '============================
        '폰트미리보기
        PreviewF()

    End Sub

    Private Sub PreviewF()

        PreviewLabel.Text = FontComboBox.Text
        If SizeUpDown.Text = 0 OrElse SizeUpDown.Text = "" Then
            Exit Sub
        End If

        Try
            PreviewLabel.Font = New Font(FontComboBox.Text, SizeUpDown.Text, FontStyle.Regular, GraphicsUnit.Point)
        Catch ex As Exception
            Try
                PreviewLabel.Font = New Font(FontComboBox.Text, SizeUpDown.Text, FontStyle.Bold, GraphicsUnit.Point)
            Catch ex2 As Exception
                Try
                    PreviewLabel.Font = New Font(FontComboBox.Text, SizeUpDown.Text, FontStyle.Italic, GraphicsUnit.Point)
                Catch ex3 As Exception
                End Try
            End Try
        End Try

        Try
            Dim ItalicCheckBoxV As FontStyle
            If ItalicCheckBox.Checked = True Then
                ItalicCheckBoxV = FontStyle.Italic
            Else
                ItalicCheckBoxV = Nothing
            End If

            Dim BoldCheckBoxV As FontStyle
            If BoldCheckBox.Checked = True Then
                BoldCheckBoxV = FontStyle.Bold
            Else
                BoldCheckBoxV = Nothing
            End If

            Dim StrikeOutCheckBoxV As FontStyle
            If StrikeOutCheckBox.Checked = True Then
                StrikeOutCheckBoxV = FontStyle.Strikeout
            Else
                StrikeOutCheckBoxV = Nothing
            End If

            Dim UnderlineCheckBoxV As FontStyle
            If UnderlineCheckBox.Checked = True Then
                UnderlineCheckBoxV = FontStyle.Underline
            Else
                UnderlineCheckBoxV = Nothing
            End If

            PreviewLabel.Font = New Font(FontComboBox.Text, SizeUpDown.Text, PreviewLabel.Font.Style Xor BoldCheckBoxV Or ItalicCheckBoxV Or StrikeOutCheckBoxV Or UnderlineCheckBoxV, GraphicsUnit.Point)

        Catch ex As Exception
        End Try

    End Sub

    Private Sub XML_CHANGE(ByVal src As String)

        '접근권한이 있을 때 까지 반복
RELOAD:
        Try
            Dim _SRL As New StreamReader(src, System.Text.Encoding.UTF8)
            _SRL.Close()
        Catch ex As Exception
            GoTo RELOAD
        End Try

        Try
            Dim XDoc As New XmlDocument()
            Dim XNode As XmlNode
            XDoc.Load(src)
            '============== 시작


            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/SubtitleFrm_SubtitleCheckBox")
            If Not XNode Is Nothing Then XNode.InnerText = SubtitleCheckBox.Checked

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/SubtitleFrm_EncComboBox")
            If Not XNode Is Nothing Then XNode.InnerText = EncComboBox.Text

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/SubtitleFrm_FontComboBox")
            If Not XNode Is Nothing Then XNode.InnerText = FontComboBox.Text

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/SubtitleFrm_SizeUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = SizeUpDown.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/SubtitleFrm_ItalicCheckBox")
            If Not XNode Is Nothing Then XNode.InnerText = ItalicCheckBox.Checked

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/SubtitleFrm_BoldCheckBox")
            If Not XNode Is Nothing Then XNode.InnerText = BoldCheckBox.Checked

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/SubtitleFrm_PrimaryColourTrackBar")
            If Not XNode Is Nothing Then XNode.InnerText = PrimaryColourTrackBar.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/SubtitleFrm_OutlineColourTrackBar")
            If Not XNode Is Nothing Then XNode.InnerText = OutlineColourTrackBar.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/SubtitleFrm_BackColourTrackBar")
            If Not XNode Is Nothing Then XNode.InnerText = BackColourTrackBar.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/SubtitleFrm_OutlineUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = OutlineUpDown.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/SubtitleFrm_ShadowUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = BackUpDown.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/SubtitleFrm_BorderStyle1")
            If Not XNode Is Nothing Then XNode.InnerText = BorderStyle1.Checked

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/SubtitleFrm_BorderStyle3")
            If Not XNode Is Nothing Then XNode.InnerText = BorderStyle3.Checked

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/SubtitleFrm_Alignment5RadioButton")
            If Not XNode Is Nothing Then XNode.InnerText = Alignment5RadioButton.Checked

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/SubtitleFrm_Alignment6RadioButton")
            If Not XNode Is Nothing Then XNode.InnerText = Alignment6RadioButton.Checked

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/SubtitleFrm_Alignment4RadioButton")
            If Not XNode Is Nothing Then XNode.InnerText = Alignment4RadioButton.Checked

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/SubtitleFrm_Alignment9RadioButton")
            If Not XNode Is Nothing Then XNode.InnerText = Alignment9RadioButton.Checked

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/SubtitleFrm_Alignment7RadioButton")
            If Not XNode Is Nothing Then XNode.InnerText = Alignment7RadioButton.Checked

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/SubtitleFrm_Alignment8RadioButton")
            If Not XNode Is Nothing Then XNode.InnerText = Alignment8RadioButton.Checked

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/SubtitleFrm_Alignment1RadioButton")
            If Not XNode Is Nothing Then XNode.InnerText = Alignment1RadioButton.Checked

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/SubtitleFrm_Alignment2RadioButton")
            If Not XNode Is Nothing Then XNode.InnerText = Alignment2RadioButton.Checked

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/SubtitleFrm_Alignment3RadioButton")
            If Not XNode Is Nothing Then XNode.InnerText = Alignment3RadioButton.Checked

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/SubtitleFrm_MarginLNumericUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = MarginLNumericUpDown.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/SubtitleFrm_MarginRNumericUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = MarginRNumericUpDown.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/SubtitleFrm_MarginVNumericUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = MarginVNumericUpDown.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/SubtitleFrm_PrimaryColourPanel")
            If Not XNode Is Nothing Then XNode.InnerText = PrimaryColourPanel.BackColor.ToArgb.ToString

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/SubtitleFrm_OutlineColourPanel")
            If Not XNode Is Nothing Then XNode.InnerText = OutlineColourPanel.BackColor.ToArgb.ToString

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/SubtitleFrm_BackColourPanel")
            If Not XNode Is Nothing Then XNode.InnerText = BackColourPanel.BackColor.ToArgb.ToString

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/SubtitleFrm_SecondaryColourPanel")
            If Not XNode Is Nothing Then XNode.InnerText = SecondaryColourPanel.BackColor.ToArgb.ToString

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/SubtitleFrm_SecondaryColourTrackBar")
            If Not XNode Is Nothing Then XNode.InnerText = SecondaryColourTrackBar.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/SubtitleFrm_StrikeOutCheckBox")
            If Not XNode Is Nothing Then XNode.InnerText = StrikeOutCheckBox.Checked

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/SubtitleFrm_UnderlineCheckBox")
            If Not XNode Is Nothing Then XNode.InnerText = UnderlineCheckBox.Checked

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/SubtitleFrm_SpacingNumericUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = SpacingNumericUpDown.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/SubtitleFrm_AngleNumericUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = AngleNumericUpDown.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/SubtitleFrm_ScaleXNumericUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = ScaleXNumericUpDown.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/SubtitleFrm_ScaleYNumericUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = ScaleYNumericUpDown.Value

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

    Private Sub XML_LOAD(ByVal src As String)

        '접근권한이 있을 때 까지 반복
RELOAD:
        Try
            Dim _SRL As New StreamReader(src, System.Text.Encoding.UTF8)
            _SRL.Close()
        Catch ex As Exception
            GoTo RELOAD
        End Try

        Dim SR As New StreamReader(src, System.Text.Encoding.UTF8)
        Dim XTR As New System.Xml.XmlTextReader(SR)

        Try

            Do While XTR.Read
                Application.DoEvents()

                If XTR.Name = "SubtitleFrm_SubtitleCheckBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then SubtitleCheckBox.Checked = XTRSTR Else SubtitleCheckBox.Checked = True
                End If

                If XTR.Name = "SubtitleFrm_EncComboBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then EncComboBox.Text = XTRSTR Else EncComboBox.Text = "DEFAULT (1)"
                End If

                If XTR.Name = "SubtitleFrm_FontComboBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then FontComboBox.Text = XTRSTR Else FontComboBox.Text = "Arial"
                End If

                If XTR.Name = "SubtitleFrm_SizeUpDown" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then SizeUpDown.Value = XTRSTR Else SizeUpDown.Value = 22
                End If

                If XTR.Name = "SubtitleFrm_ItalicCheckBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then ItalicCheckBox.Checked = XTRSTR Else ItalicCheckBox.Checked = False
                End If

                If XTR.Name = "SubtitleFrm_BoldCheckBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then BoldCheckBox.Checked = XTRSTR Else BoldCheckBox.Checked = False
                End If

                If XTR.Name = "SubtitleFrm_PrimaryColourTrackBar" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then PrimaryColourTrackBar.Value = XTRSTR Else PrimaryColourTrackBar.Value = 0
                End If

                If XTR.Name = "SubtitleFrm_OutlineColourTrackBar" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then OutlineColourTrackBar.Value = XTRSTR Else OutlineColourTrackBar.Value = 0
                End If

                If XTR.Name = "SubtitleFrm_BackColourTrackBar" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then BackColourTrackBar.Value = XTRSTR Else BackColourTrackBar.Value = 128
                End If

                If XTR.Name = "SubtitleFrm_OutlineUpDown" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then OutlineUpDown.Value = XTRSTR Else OutlineUpDown.Value = 1.0
                End If

                If XTR.Name = "SubtitleFrm_ShadowUpDown" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then BackUpDown.Value = XTRSTR Else BackUpDown.Value = 2.0
                End If

                If XTR.Name = "SubtitleFrm_BorderStyle1" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then BorderStyle1.Checked = XTRSTR Else BorderStyle1.Checked = True
                End If

                If XTR.Name = "SubtitleFrm_BorderStyle3" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then BorderStyle3.Checked = XTRSTR Else BorderStyle3.Checked = False
                End If

                If XTR.Name = "SubtitleFrm_Alignment5RadioButton" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then Alignment5RadioButton.Checked = XTRSTR Else Alignment5RadioButton.Checked = False
                End If

                If XTR.Name = "SubtitleFrm_Alignment6RadioButton" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then Alignment6RadioButton.Checked = XTRSTR Else Alignment6RadioButton.Checked = False
                End If

                If XTR.Name = "SubtitleFrm_Alignment4RadioButton" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then Alignment4RadioButton.Checked = XTRSTR Else Alignment4RadioButton.Checked = False
                End If

                If XTR.Name = "SubtitleFrm_Alignment9RadioButton" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then Alignment9RadioButton.Checked = XTRSTR Else Alignment9RadioButton.Checked = False
                End If

                If XTR.Name = "SubtitleFrm_Alignment7RadioButton" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then Alignment7RadioButton.Checked = XTRSTR Else Alignment7RadioButton.Checked = False
                End If

                If XTR.Name = "SubtitleFrm_Alignment8RadioButton" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then Alignment8RadioButton.Checked = XTRSTR Else Alignment8RadioButton.Checked = False
                End If

                If XTR.Name = "SubtitleFrm_Alignment1RadioButton" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then Alignment1RadioButton.Checked = XTRSTR Else Alignment1RadioButton.Checked = False
                End If

                If XTR.Name = "SubtitleFrm_Alignment2RadioButton" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then Alignment2RadioButton.Checked = XTRSTR Else Alignment2RadioButton.Checked = True
                End If

                If XTR.Name = "SubtitleFrm_Alignment3RadioButton" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then Alignment3RadioButton.Checked = XTRSTR Else Alignment3RadioButton.Checked = False
                End If

                If XTR.Name = "SubtitleFrm_MarginLNumericUpDown" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then MarginLNumericUpDown.Value = XTRSTR Else MarginLNumericUpDown.Value = 10
                End If

                If XTR.Name = "SubtitleFrm_MarginRNumericUpDown" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then MarginRNumericUpDown.Value = XTRSTR Else MarginRNumericUpDown.Value = 10
                End If

                If XTR.Name = "SubtitleFrm_MarginVNumericUpDown" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then MarginVNumericUpDown.Value = XTRSTR Else MarginVNumericUpDown.Value = 20
                End If

                If XTR.Name = "SubtitleFrm_PrimaryColourPanel" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then PrimaryColourPanel.BackColor = Color.FromArgb(XTRSTR) Else PrimaryColourPanel.BackColor = Color.FromArgb(-1)
                End If

                If XTR.Name = "SubtitleFrm_OutlineColourPanel" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then OutlineColourPanel.BackColor = Color.FromArgb(XTRSTR) Else OutlineColourPanel.BackColor = Color.FromArgb(-16777216)
                End If

                If XTR.Name = "SubtitleFrm_BackColourPanel" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then BackColourPanel.BackColor = Color.FromArgb(XTRSTR) Else BackColourPanel.BackColor = Color.FromArgb(-16777216)
                End If

                If XTR.Name = "SubtitleFrm_SecondaryColourPanel" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then SecondaryColourPanel.BackColor = Color.FromArgb(XTRSTR) Else SecondaryColourPanel.BackColor = Color.FromArgb(-256)
                End If

                If XTR.Name = "SubtitleFrm_SecondaryColourTrackBar" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then SecondaryColourTrackBar.Value = XTRSTR Else SecondaryColourTrackBar.Value = 0
                End If

                If XTR.Name = "SubtitleFrm_StrikeOutCheckBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then StrikeOutCheckBox.Checked = XTRSTR Else StrikeOutCheckBox.Checked = False
                End If

                If XTR.Name = "SubtitleFrm_UnderlineCheckBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then UnderlineCheckBox.Checked = XTRSTR Else UnderlineCheckBox.Checked = False
                End If

                If XTR.Name = "SubtitleFrm_SpacingNumericUpDown" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then SpacingNumericUpDown.Value = XTRSTR Else SpacingNumericUpDown.Value = 0.0
                End If

                If XTR.Name = "SubtitleFrm_AngleNumericUpDown" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then AngleNumericUpDown.Value = XTRSTR Else AngleNumericUpDown.Value = 0
                End If

                If XTR.Name = "SubtitleFrm_ScaleXNumericUpDown" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then ScaleXNumericUpDown.Value = XTRSTR Else ScaleXNumericUpDown.Value = 100.0
                End If

                If XTR.Name = "SubtitleFrm_ScaleYNumericUpDown" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then ScaleYNumericUpDown.Value = XTRSTR Else ScaleYNumericUpDown.Value = 100.0
                End If

            Loop

        Catch ex As Exception
            MsgBox("XML_LOAD_ERROR :" & ex.Message)
        Finally
            XTR.Close()
        End Try

    End Sub

    Private Sub FontComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontComboBox.SelectedIndexChanged
        PreviewF()
    End Sub

    Private Sub SizeUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles SizeUpDown.LostFocus
        SizeUpDown.Text = SizeUpDown.Value
    End Sub

    Private Sub SizeUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SizeUpDown.ValueChanged
        PreviewF()
    End Sub

    Private Sub ItalicCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItalicCheckBox.CheckedChanged
        PreviewF()
    End Sub

    Private Sub BoldCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoldCheckBox.CheckedChanged
        PreviewF()
    End Sub

    Private Sub SubtitleFrm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        XML_LOAD(My.Application.Info.DirectoryPath & "\settings.xml")
    End Sub

    Private Sub SubtitleFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '폰트로드
        Dim ff As FontFamily
        For Each ff In System.Drawing.FontFamily.Families
            FontComboBox.Items.Add(ff.Name)
        Next

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
                    SubPanel.Font = New Font(FNXP, FS)
                Else
                    SubPanel.Font = New Font(FN, FS)
                End If

                If XTR.Name = "OKBTN" Then OKBTN.Text = XTR.ReadString
                If XTR.Name = "CancelBTN" Then CancelBTN.Text = XTR.ReadString
                If XTR.Name = "DefBTN" Then DefBTN.Text = XTR.ReadString

                If XTR.Name = "SubtitleFrm" Then Me.Text = XTR.ReadString
                If XTR.Name = "SubtitleFrmSubtitleTabPage" Then SubtitleTabPage.Text = XTR.ReadString
                If XTR.Name = "SubtitleFrmSubtitleCheckBox" Then SubtitleCheckBox.Text = XTR.ReadString
                If XTR.Name = "SubtitleFrmEncLabel" Then EncLabel.Text = XTR.ReadString
                If XTR.Name = "SubtitleFrmFontGroupBox" Then FontGroupBox.Text = XTR.ReadString
                If XTR.Name = "SubtitleFrmFontLabel" Then FontLabel.Text = XTR.ReadString
                If XTR.Name = "SubtitleFrmSizeLabel" Then SizeLabel.Text = XTR.ReadString
                If XTR.Name = "SubtitleFrmStyleLabel" Then StyleLabel.Text = XTR.ReadString
                If XTR.Name = "SubtitleFrmItalicCheckBox" Then ItalicCheckBox.Text = XTR.ReadString
                If XTR.Name = "SubtitleFrmBoldCheckBox" Then BoldCheckBox.Text = XTR.ReadString
                If XTR.Name = "SubtitleFrmPreviewLabel2" Then PreviewLabel2.Text = XTR.ReadString
                If XTR.Name = "SubtitleFrmColorGroupBox" Then ColorGroupBox.Text = XTR.ReadString
                If XTR.Name = "SubtitleFrmPrimaryLabel" Then PrimaryLabel.Text = XTR.ReadString
                If XTR.Name = "SubtitleFrmOutlineLabel" Then OutlineLabel.Text = XTR.ReadString
                If XTR.Name = "SubtitleFrmBackLabel" Then BackLabel.Text = XTR.ReadString
                If XTR.Name = "SubtitleFrmOutlineLabel2" Then OutlineLabel2.Text = XTR.ReadString
                If XTR.Name = "SubtitleFrmBackLabel2" Then BackLabel2.Text = XTR.ReadString
                If XTR.Name = "SubtitleFrmBorderStyleGroupBox" Then BorderStyleGroupBox.Text = XTR.ReadString
                If XTR.Name = "SubtitleFrmBorderStyle1" Then BorderStyle1.Text = XTR.ReadString
                If XTR.Name = "SubtitleFrmBorderStyle3" Then BorderStyle3.Text = XTR.ReadString
                If XTR.Name = "SubtitleFrmAlignmentGroupBox" Then AlignmentGroupBox.Text = XTR.ReadString
                If XTR.Name = "SubtitleFrmMarginGroupBox" Then MarginGroupBox.Text = XTR.ReadString
                If XTR.Name = "SubtitleFrmMarginLLabel" Then MarginLLabel.Text = XTR.ReadString
                If XTR.Name = "SubtitleFrmMarginRLabel" Then MarginRLabel.Text = XTR.ReadString
                If XTR.Name = "SubtitleFrmMarginVLabel" Then MarginVLabel.Text = XTR.ReadString
                If XTR.Name = "SubtitleFrmStrikeOutCheckBox" Then StrikeOutCheckBox.Text = XTR.ReadString
                If XTR.Name = "SubtitleFrmUnderlineCheckBox" Then UnderlineCheckBox.Text = XTR.ReadString
                If XTR.Name = "SubtitleFrmSecondaryLabel" Then SecondaryLabel.Text = XTR.ReadString
                If XTR.Name = "SubtitleFrmSpacingLabel" Then SpacingLabel.Text = XTR.ReadString
                If XTR.Name = "SubtitleFrmAngleLabel" Then AngleLabel.Text = XTR.ReadString
                If XTR.Name = "SubtitleFrmScaleXLabel" Then ScaleXLabel.Text = XTR.ReadString
                If XTR.Name = "SubtitleFrmScaleYLabel" Then ScaleYLabel.Text = XTR.ReadString
                If XTR.Name = "SubtitleFrmScaleGroupBox" Then ScaleGroupBox.Text = XTR.ReadString

            Loop
        Catch ex As Exception
            MsgBox("LANG_LOAD_ERROR :" & ex.Message)
        Finally
            XTR.Close()
        End Try
LANG_SKIP:
        '=========================================

        XML_LOAD(My.Application.Info.DirectoryPath & "\settings.xml")

    End Sub

    Private Sub OutlineUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles OutlineUpDown.LostFocus
        OutlineUpDown.Text = OutlineUpDown.Value
    End Sub

    Private Sub MarginLNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MarginLNumericUpDown.LostFocus
        MarginLNumericUpDown.Text = MarginLNumericUpDown.Value
    End Sub

    Private Sub MarginRNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MarginRNumericUpDown.LostFocus
        MarginRNumericUpDown.Text = MarginRNumericUpDown.Value
    End Sub

    Private Sub MarginVNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MarginVNumericUpDown.LostFocus
        MarginVNumericUpDown.Text = MarginVNumericUpDown.Value
    End Sub

    Private Sub PrimaryColourPanel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PrimaryColourPanel.Click
        ColorDialog1.Color = PrimaryColourPanel.BackColor
        ColorDialog1.ShowDialog()
        PrimaryColourPanel.BackColor = ColorDialog1.Color
    End Sub

    Private Sub OutlineColourPanel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OutlineColourPanel.Click
        ColorDialog1.Color = OutlineColourPanel.BackColor
        ColorDialog1.ShowDialog()
        OutlineColourPanel.BackColor = ColorDialog1.Color
    End Sub

    Private Sub BackColourPanel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BackColourPanel.Click
        ColorDialog1.Color = BackColourPanel.BackColor
        ColorDialog1.ShowDialog()
        BackColourPanel.BackColor = ColorDialog1.Color
    End Sub

    Private Sub OKBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKBTN.Click
        XML_CHANGE(My.Application.Info.DirectoryPath & "\settings.xml")
        Close()
    End Sub

    Private Sub CancelBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBTN.Click
        Close()
    End Sub

    Private Sub BackUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BackUpDown.LostFocus
        BackUpDown.Text = BackUpDown.Value
    End Sub

    Private Sub BackUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackUpDown.ValueChanged

    End Sub

    Private Sub PrimaryColourPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PrimaryColourPanel.Paint

    End Sub

    Private Sub SecondaryColourPanel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SecondaryColourPanel.Click
        ColorDialog1.Color = SecondaryColourPanel.BackColor
        ColorDialog1.ShowDialog()
        SecondaryColourPanel.BackColor = ColorDialog1.Color
    End Sub

    Private Sub SecondaryColourPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SecondaryColourPanel.Paint

    End Sub

    Private Sub StrikeOutCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StrikeOutCheckBox.CheckedChanged
        PreviewF()
    End Sub

    Private Sub UnderlineCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnderlineCheckBox.CheckedChanged
        PreviewF()
    End Sub

    Private Sub MarginLNumericUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MarginLNumericUpDown.ValueChanged

    End Sub

    Private Sub SpacingNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles SpacingNumericUpDown.LostFocus
        SpacingNumericUpDown.Text = SpacingNumericUpDown.Value
    End Sub

    Private Sub SpacingNumericUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpacingNumericUpDown.ValueChanged

    End Sub

    Private Sub AngleNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles AngleNumericUpDown.LostFocus
        AngleNumericUpDown.Text = AngleNumericUpDown.Value
    End Sub

    Private Sub AngleNumericUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AngleNumericUpDown.ValueChanged

    End Sub

    Private Sub ScaleXNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ScaleXNumericUpDown.LostFocus
        ScaleXNumericUpDown.Text = ScaleXNumericUpDown.Value
    End Sub

    Private Sub ScaleXNumericUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScaleXNumericUpDown.ValueChanged

    End Sub

    Private Sub ScaleYNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ScaleYNumericUpDown.LostFocus
        ScaleYNumericUpDown.Text = ScaleYNumericUpDown.Value
    End Sub

    Private Sub ScaleYNumericUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScaleYNumericUpDown.ValueChanged

    End Sub

End Class