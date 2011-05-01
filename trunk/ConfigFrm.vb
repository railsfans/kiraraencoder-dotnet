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

Public Class ConfigFrm

    Private Sub ConfigFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
                    ConfigPanel.Font = New Font(FNXP, FS)
                Else
                    ConfigPanel.Font = New Font(FN, FS)
                End If

                If XTR.Name = "OKBTN" Then OKBTN.Text = XTR.ReadString
                If XTR.Name = "CancelBTN" Then CancelBTN.Text = XTR.ReadString
                If XTR.Name = "DefBTN" Then DefBTN.Text = XTR.ReadString

                If XTR.Name = "ConfigFrm" Then Me.Text = XTR.ReadString
                If XTR.Name = "ConfigFrmPreviewTabPage" Then PreviewTabPage.Text = XTR.ReadString
                If XTR.Name = "ConfigFrmPreviewGroupBox" Then PreviewGroupBox.Text = XTR.ReadString
                If XTR.Name = "ConfigFrmBackColorLabel" Then BackColorLabel.Text = XTR.ReadString
                If XTR.Name = "ConfigFrmImgLabel" Then ImgLabel.Text = XTR.ReadString
                If XTR.Name = "ConfigFrmModeLabel" Then ModeLabel.Text = XTR.ReadString
                If XTR.Name = "ConfigFrmVideoODGroupBox" Then VideoODGroupBox.Text = XTR.ReadString
                If XTR.Name = "ConfigFrmMPVolumeGroupBox" Then MPVolumeGroupBox.Text = XTR.ReadString
                If XTR.Name = "ConfigFrmVideoODLabel" Then VideoODLabel.Text = XTR.ReadString

            Loop
        Catch ex As Exception
            MsgBox("LANG_LOAD_ERROR :" & ex.Message)
        Finally
            XTR.Close()
            SR.Close()
        End Try
LANG_SKIP:
        '=========================================

        '설정 불러옴
        BackColorPanel.BackColor = MainFrm.BackColorPanelV
        ImgTextBox.Text = MainFrm.ImgTextBoxV
        ModeComboBox.Text = MainFrm.ModeComboBoxV
        MPVolumeTrackBar.Value = MainFrm.MPVolumeTrackBarV
        VideoODComboBox.Text = MainFrm.VideoODComboBoxV

        '미리보기 이미지 적용
        PreviewImgPanel_Apply()

        '윈도우 2000 디자이너
        If Environment.OSVersion.Version.Major = 5 AndAlso Environment.OSVersion.Version.Minor = 0 Then
            MPVolumeTrackBar.BackColor = Color.FromKnownColor(KnownColor.Control)
        End If

    End Sub

    Private Sub FLoadLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PreviewImgPanel_Apply()

        '이미지
        If My.Computer.FileSystem.FileExists(ImgTextBox.Text) = True Then
            PreviewImgPanel.BackgroundImage = Image.FromFile(ImgTextBox.Text)
        Else
            PreviewImgPanel.BackgroundImage = MainFrm.DefPreviewImg.BackgroundImage
        End If
        '배경색
        PreviewImgPanel.BackColor = BackColorPanel.BackColor
        '모드
        If ModeComboBox.Text = "None" Then
            PreviewImgPanel.BackgroundImageLayout = ImageLayout.None
        ElseIf ModeComboBox.Text = "Tile" Then
            PreviewImgPanel.BackgroundImageLayout = ImageLayout.Tile
        ElseIf ModeComboBox.Text = "Center" Then
            PreviewImgPanel.BackgroundImageLayout = ImageLayout.Center
        ElseIf ModeComboBox.Text = "Stretch" Then
            PreviewImgPanel.BackgroundImageLayout = ImageLayout.Stretch
        ElseIf ModeComboBox.Text = "Zoom" Then
            PreviewImgPanel.BackgroundImageLayout = ImageLayout.Zoom
        Else
            PreviewImgPanel.BackgroundImageLayout = ImageLayout.Center
        End If

    End Sub

    Private Sub PreviewImgColorPanel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BackColorPanel.Click
        ColorDialog1.Color = BackColorPanel.BackColor
        ColorDialog1.ShowDialog()
        BackColorPanel.BackColor = ColorDialog1.Color

        PreviewImgPanel_Apply()
    End Sub

    Private Sub PreviewImgButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImgButton.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName = "" Then Exit Sub
        ImgTextBox.Text = OpenFileDialog1.FileName

        PreviewImgPanel_Apply()
    End Sub

    Private Sub ModeComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModeComboBox.SelectedIndexChanged
        PreviewImgPanel_Apply()
    End Sub

    Private Sub DefBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefBTN.Click
        BackColorPanel.BackColor = Color.FromArgb(-16777216)
        ImgTextBox.Text = ""
        ModeComboBox.Text = "Center"
        MPVolumeTrackBar.Value = 100
        VideoODComboBox.Text = "Direct3D 9 Renderer"

        PreviewImgPanel_Apply()
    End Sub

    Private Sub xButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgXButton.Click
        ImgTextBox.Text = ""

        PreviewImgPanel_Apply()
    End Sub

    Private Sub OKBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKBTN.Click
        '설정 저장
        MainFrm.BackColorPanelV = BackColorPanel.BackColor
        MainFrm.ImgTextBoxV = ImgTextBox.Text
        MainFrm.ModeComboBoxV = ModeComboBox.Text
        MainFrm.MPVolumeTrackBarV = MPVolumeTrackBar.Value
        MainFrm.VideoODComboBoxV = VideoODComboBox.Text

        Close()
    End Sub

    Private Sub CancelBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBTN.Click
        Close()
    End Sub

    Private Sub MPVolumeTrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MPVolumeTrackBar.Scroll

    End Sub

    Private Sub MPVolumeTrackBar_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MPVolumeTrackBar.ValueChanged
        MPVolumeLabel.Text = MPVolumeTrackBar.Value & "%"
    End Sub
End Class