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

Public Class ImagePPFrm

    Private Sub ImagePPFrm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        XML_LOAD(My.Application.Info.DirectoryPath & "\settings.xml")
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
                    IPP_Panel.Font = New Font(FNXP, FS)
                Else
                    IPP_Panel.Font = New Font(FN, FS)
                End If

                If XTR.Name = "OKBTN" Then OKBTN.Text = XTR.ReadString
                If XTR.Name = "CancelBTN" Then CancelBTN.Text = XTR.ReadString
                If XTR.Name = "DefBTN" Then DefBTN.Text = XTR.ReadString

                If XTR.Name = "ImagePPFrm" Then Me.Text = XTR.ReadString
                If XTR.Name = "ImagePPFrmAviSynthFramerateCheckBox" Then AviSynthFramerateCheckBox.Text = XTR.ReadString
                If XTR.Name = "ImagePPFrmAviSynthFramerateGroupBox" Then AviSynthFramerateGroupBox.Text = XTR.ReadString
                If XTR.Name = "ImagePPFrmAviSynthImageGroupBox" Then AviSynthImageGroupBox.Text = XTR.ReadString
                If XTR.Name = "ImagePPFrmAviSynthImageSizeLabel" Then AviSynthImageSizeLabel.Text = XTR.ReadString
                If XTR.Name = "ImagePPFrmAviSynthImageSizeCheckBox" Then AviSynthImageSizeCheckBox.Text = XTR.ReadString
                If XTR.Name = "ImagePPFrmAviSynthResizeFilterLabel" Then AviSynthResizeFilterLabel.Text = XTR.ReadString
                If XTR.Name = "ImagePPFrmAviSynthAspectLabel" Then AviSynthAspectLabel.Text = XTR.ReadString
                If XTR.Name = "ImagePPFrmAviSynthDeinterlaceCheckBox" Then
                    AviSynthDeinterlaceCheckBox.Text = XTR.ReadString
                    AVSMPEG2DeinterlaceCheckBox.Text = AviSynthDeinterlaceCheckBox.Text
                End If
                If XTR.Name = "ImagePPFrmAviSynthImageControlGroupBox" Then AviSynthImageControlGroupBox.Text = XTR.ReadString
                If XTR.Name = "ImagePPFrmbrightnessButton" Then brightnessButton.Text = XTR.ReadString
                If XTR.Name = "ImagePPFrmcontrastButton" Then contrastButton.Text = XTR.ReadString
                If XTR.Name = "ImagePPFrmsaturationButton" Then saturationButton.Text = XTR.ReadString
                If XTR.Name = "ImagePPFrmhueButton" Then hueButton.Text = XTR.ReadString
                If XTR.Name = "ImagePPFrmSharpenButton" Then SharpenButton.Text = XTR.ReadString
                If XTR.Name = "ImagePPFrmColorYUVNRadioButton" Then ColorYUVNRadioButton.Text = XTR.ReadString
                If XTR.Name = "ImagePPFrmColorYUVASCheckBox" Then ColorYUVASCheckBox.Text = XTR.ReadString
                If XTR.Name = "ImagePPUserInputComboBox" Then LangCls.ImagePPUserInputComboBox = XTR.ReadString
                If XTR.Name = "ImagePPBlurStr" Then LangCls.ImagePPBlurStr = XTR.ReadString
                If XTR.Name = "ImagePPSharpStr" Then LangCls.ImagePPSharpStr = XTR.ReadString
                If XTR.Name = "ImagePPMiddleStr" Then LangCls.ImagePPMiddleStr = XTR.ReadString
                If XTR.Name = "ImagePPNoKeepAviSynthAspectComboBox" Then LangCls.ImagePPNoKeepAviSynthAspectComboBox = XTR.ReadString
                If XTR.Name = "ImagePPLetterBoxAviSynthAspectComboBox" Then LangCls.ImagePPLetterBoxAviSynthAspectComboBox = XTR.ReadString
                If XTR.Name = "ImagePPCropAviSynthAspectComboBox" Then LangCls.ImagePPCropAviSynthAspectComboBox = XTR.ReadString
                If XTR.Name = "ImagePPOutputAviSynthAspectComboBox2" Then LangCls.ImagePPOutputAviSynthAspectComboBox2 = XTR.ReadString
                If XTR.Name = "ImagePPOriginalAviSynthAspectComboBox2" Then LangCls.ImagePPOriginalAviSynthAspectComboBox2 = XTR.ReadString
                If XTR.Name = "ImagePP43AviSynthAspectComboBox2" Then LangCls.ImagePP43AviSynthAspectComboBox2 = XTR.ReadString
                If XTR.Name = "ImagePP169AviSynthAspectComboBox2" Then LangCls.ImagePP169AviSynthAspectComboBox2 = XTR.ReadString
                If XTR.Name = "ImagePP1851AviSynthAspectComboBox2" Then LangCls.ImagePP1851AviSynthAspectComboBox2 = XTR.ReadString
                If XTR.Name = "ImagePP2351AviSynthAspectComboBox2" Then LangCls.ImagePP2351AviSynthAspectComboBox2 = XTR.ReadString

            Loop
        Catch ex As Exception
            MsgBox("LANG_LOAD_ERROR :" & ex.Message)
        Finally
            XTR.Close()
        End Try
LANG_SKIP:
        '=========================================

        '영상(Image)부분 초기화
        AviSynthImageSizeComboBox.Items.Clear()
        AviSynthImageSizeComboBox.Items.AddRange(New Object() {"160 x 120", "176 x 144 - QCIF", "240 x 180", "320 x 180", "320 x 240 - QVGA", "400 x 240 - WQVGA", "400 x 300", "480 x 272", "480 x 360", "640 x 360 - 16:9", "640 x 480", "800 x 600", "960 x 540", "1280 x 720 - HD 720", "1920 x 1080 - HD 1080"})
        AviSynthImageSizeComboBox.Items.Add(LangCls.ImagePPUserInputComboBox)

        AviSynthResizeFilterComboBox.Items.Clear()
        AviSynthResizeFilterComboBox.Items.Add("Bicubic " & LangCls.ImagePPBlurStr)
        AviSynthResizeFilterComboBox.Items.Add("Bicubic " & LangCls.ImagePPSharpStr)
        AviSynthResizeFilterComboBox.Items.Add("Bicubic " & LangCls.ImagePPMiddleStr)
        AviSynthResizeFilterComboBox.Items.Add("Bilinear " & LangCls.ImagePPBlurStr)
        AviSynthResizeFilterComboBox.Items.Add("Blackman " & LangCls.ImagePPSharpStr)
        AviSynthResizeFilterComboBox.Items.Add("Gauss " & LangCls.ImagePPMiddleStr)
        AviSynthResizeFilterComboBox.Items.Add("Lanczos " & LangCls.ImagePPSharpStr)
        AviSynthResizeFilterComboBox.Items.Add("Lanczos4 " & LangCls.ImagePPSharpStr)
        AviSynthResizeFilterComboBox.Items.Add("Point " & LangCls.ImagePPSharpStr)
        AviSynthResizeFilterComboBox.Items.Add("Spline16 " & LangCls.ImagePPMiddleStr)
        AviSynthResizeFilterComboBox.Items.Add("Spline36 " & LangCls.ImagePPMiddleStr)
        AviSynthResizeFilterComboBox.Items.Add("Spline64 " & LangCls.ImagePPMiddleStr)

        AviSynthAspectComboBox.Items.Clear()
        AviSynthAspectComboBox.Items.Add(LangCls.ImagePPNoKeepAviSynthAspectComboBox)
        AviSynthAspectComboBox.Items.Add(LangCls.ImagePPLetterBoxAviSynthAspectComboBox)
        AviSynthAspectComboBox.Items.Add(LangCls.ImagePPCropAviSynthAspectComboBox)

        AviSynthAspectComboBox2.Items.Clear()
        AviSynthAspectComboBox2.Items.Add(LangCls.ImagePPOutputAviSynthAspectComboBox2)
        AviSynthAspectComboBox2.Items.Add(LangCls.ImagePPOriginalAviSynthAspectComboBox2)
        AviSynthAspectComboBox2.Items.Add(LangCls.ImagePP43AviSynthAspectComboBox2)
        AviSynthAspectComboBox2.Items.Add(LangCls.ImagePP169AviSynthAspectComboBox2)
        AviSynthAspectComboBox2.Items.Add(LangCls.ImagePP1851AviSynthAspectComboBox2)
        AviSynthAspectComboBox2.Items.Add(LangCls.ImagePP2351AviSynthAspectComboBox2)
        AviSynthAspectComboBox2.Items.Add(LangCls.ImagePPUserInputComboBox)

        XML_LOAD(My.Application.Info.DirectoryPath & "\settings.xml")

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

                If XTR.Name = "ImagePPFrm_AviSynthFramerateComboBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then AviSynthFramerateComboBox.Text = XTRSTR Else AviSynthFramerateComboBox.Text = "23.976"
                End If

                If XTR.Name = "ImagePPFrm_AviSynthFramerateCheckBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then AviSynthFramerateCheckBox.Checked = XTRSTR Else AviSynthFramerateCheckBox.Checked = False
                End If

                'AviSynthImageSizeComboBox
                If XTR.Name = "ImagePPFrm_AviSynthImageSizeComboBox" Then
                    Dim AviSynthImageSizeComboBoxV As String = ""
                    AviSynthImageSizeComboBoxV = XTR.ReadString
                    If AviSynthImageSizeComboBoxV = "LangCls.ImagePPUserInputComboBox" Then
                        AviSynthImageSizeComboBox.Text = LangCls.ImagePPUserInputComboBox
                    Else
                        If AviSynthImageSizeComboBoxV <> "" Then
                            AviSynthImageSizeComboBox.Text = AviSynthImageSizeComboBoxV
                        Else '기본값
                            AviSynthImageSizeComboBox.Text = "480 x 272"
                        End If
                    End If
                End If
                'AviSynthImageSizeComboBox

                If XTR.Name = "ImagePPFrm_AviSynthImageSizeWidthTextBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then AviSynthImageSizeWidthTextBox.Text = XTRSTR Else AviSynthImageSizeWidthTextBox.Text = "480"
                End If

                If XTR.Name = "ImagePPFrm_AviSynthImageSizeHeightTextBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then AviSynthImageSizeHeightTextBox.Text = XTRSTR Else AviSynthImageSizeHeightTextBox.Text = "272"
                End If

                If XTR.Name = "ImagePPFrm_AviSynthImageSizeCheckBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then AviSynthImageSizeCheckBox.Checked = XTRSTR Else AviSynthImageSizeCheckBox.Checked = False
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
                        AviSynthResizeFilterComboBox.Text = AviSynthResizeFilterComboBox1V & " " & LangCls.ImagePPBlurStr
                    ElseIf AviSynthResizeFilterComboBox2V = "LangCls.ImagePPSharpStr" Then
                        AviSynthResizeFilterComboBox.Text = AviSynthResizeFilterComboBox1V & " " & LangCls.ImagePPSharpStr
                    ElseIf AviSynthResizeFilterComboBox2V = "LangCls.ImagePPMiddleStr" Then
                        AviSynthResizeFilterComboBox.Text = AviSynthResizeFilterComboBox1V & " " & LangCls.ImagePPMiddleStr
                    Else '기본값
                        AviSynthResizeFilterComboBox.Text = "Bicubic " & LangCls.ImagePPMiddleStr
                    End If
                End If
                'AviSynthResizeFilterComboBox

                'AviSynthAspectComboBox
                If XTR.Name = "ImagePPFrm_AviSynthAspectComboBox" Then
                    Dim AviSynthAspectComboBoxV As String = ""
                    AviSynthAspectComboBoxV = XTR.ReadString
                    If AviSynthAspectComboBoxV = "LangCls.ImagePPNoKeepAviSynthAspectComboBox" Then
                        AviSynthAspectComboBox.Text = LangCls.ImagePPNoKeepAviSynthAspectComboBox
                    ElseIf AviSynthAspectComboBoxV = "LangCls.ImagePPLetterBoxAviSynthAspectComboBox" Then
                        AviSynthAspectComboBox.Text = LangCls.ImagePPLetterBoxAviSynthAspectComboBox
                    ElseIf AviSynthAspectComboBoxV = "LangCls.ImagePPCropAviSynthAspectComboBox" Then
                        AviSynthAspectComboBox.Text = LangCls.ImagePPCropAviSynthAspectComboBox
                    Else '기본값
                        AviSynthAspectComboBox.Text = LangCls.ImagePPLetterBoxAviSynthAspectComboBox
                    End If
                End If
                'AviSynthAspectComboBox

                'AviSynthAspectComboBox2
                If XTR.Name = "ImagePPFrm_AviSynthAspectComboBox2" Then
                    Dim AviSynthAspectComboBox2V As String = ""
                    AviSynthAspectComboBox2V = XTR.ReadString
                    If AviSynthAspectComboBox2V = "LangCls.ImagePPOutputAviSynthAspectComboBox2" Then
                        AviSynthAspectComboBox2.Text = LangCls.ImagePPOutputAviSynthAspectComboBox2
                    ElseIf AviSynthAspectComboBox2V = "LangCls.ImagePPOriginalAviSynthAspectComboBox2" Then
                        AviSynthAspectComboBox2.Text = LangCls.ImagePPOriginalAviSynthAspectComboBox2
                    ElseIf AviSynthAspectComboBox2V = "LangCls.ImagePP43AviSynthAspectComboBox2" Then
                        AviSynthAspectComboBox2.Text = LangCls.ImagePP43AviSynthAspectComboBox2
                    ElseIf AviSynthAspectComboBox2V = "LangCls.ImagePP169AviSynthAspectComboBox2" Then
                        AviSynthAspectComboBox2.Text = LangCls.ImagePP169AviSynthAspectComboBox2
                    ElseIf AviSynthAspectComboBox2V = "LangCls.ImagePP1851AviSynthAspectComboBox2" Then
                        AviSynthAspectComboBox2.Text = LangCls.ImagePP1851AviSynthAspectComboBox2
                    ElseIf AviSynthAspectComboBox2V = "LangCls.ImagePP2351AviSynthAspectComboBox2" Then
                        AviSynthAspectComboBox2.Text = LangCls.ImagePP2351AviSynthAspectComboBox2
                    ElseIf AviSynthAspectComboBox2V = "LangCls.ImagePPUserInputComboBox" Then
                        AviSynthAspectComboBox2.Text = LangCls.ImagePPUserInputComboBox
                    Else '기본값
                        AviSynthAspectComboBox2.Text = LangCls.ImagePPOutputAviSynthAspectComboBox2
                    End If
                End If
                'AviSynthAspectComboBox2

                If XTR.Name = "ImagePPFrm_AviSynthAspectWTextBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then AviSynthAspectWTextBox.Text = XTRSTR Else AviSynthAspectWTextBox.Text = "0"
                End If

                If XTR.Name = "ImagePPFrm_AviSynthAspectHTextBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then AviSynthAspectHTextBox.Text = XTRSTR Else AviSynthAspectHTextBox.Text = "0"
                End If

                If XTR.Name = "ImagePPFrm_AviSynthDeinterlaceCheckBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then AviSynthDeinterlaceCheckBox.Checked = XTRSTR Else AviSynthDeinterlaceCheckBox.Checked = False
                End If

                If XTR.Name = "ImagePPFrm_AviSynthDeinterlaceComboBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then AviSynthDeinterlaceComboBox.Text = XTRSTR Else AviSynthDeinterlaceComboBox.Text = "linear blend deinterlacer (lb)"
                End If

                If XTR.Name = "ImagePPFrm_brightnessNumericUpDown" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then brightnessNumericUpDown.Value = XTRSTR Else brightnessNumericUpDown.Value = 0
                End If

                If XTR.Name = "ImagePPFrm_contrastNumericUpDown" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then contrastNumericUpDown.Value = XTRSTR Else contrastNumericUpDown.Value = 1
                End If

                If XTR.Name = "ImagePPFrm_saturationNumericUpDown" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then saturationNumericUpDown.Value = XTRSTR Else saturationNumericUpDown.Value = 1
                End If

                If XTR.Name = "ImagePPFrm_hueNumericUpDown" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then hueNumericUpDown.Value = XTRSTR Else hueNumericUpDown.Value = 0
                End If

                If XTR.Name = "ImagePPFrm_SharpenNumericUpDown" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then SharpenNumericUpDown.Value = XTRSTR Else SharpenNumericUpDown.Value = 0
                End If

                If XTR.Name = "ImagePPFrm_ColorYUVTVPCRadioButton" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then ColorYUVTVPCRadioButton.Checked = XTRSTR Else ColorYUVTVPCRadioButton.Checked = False
                End If

                If XTR.Name = "ImagePPFrm_ColorYUVPCTVRadioButton" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then ColorYUVPCTVRadioButton.Checked = XTRSTR Else ColorYUVPCTVRadioButton.Checked = False
                End If

                If XTR.Name = "ImagePPFrm_ColorYUVNRadioButton" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then ColorYUVNRadioButton.Checked = XTRSTR Else ColorYUVNRadioButton.Checked = True
                End If

                If XTR.Name = "ImagePPFrm_ColorYUVASCheckBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then ColorYUVASCheckBox.Checked = XTRSTR Else ColorYUVASCheckBox.Checked = False
                End If

                If XTR.Name = "ImagePPFrm_AVSMPEG2DeinterlaceCheckBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then AVSMPEG2DeinterlaceCheckBox.Checked = XTRSTR Else AVSMPEG2DeinterlaceCheckBox.Checked = False
                End If

                If XTR.Name = "ImagePPFrm_AVSMPEG2DeinterlaceComboBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then AVSMPEG2DeinterlaceComboBox.Text = XTRSTR Else AVSMPEG2DeinterlaceComboBox.Text = "Yadif mode=0"
                End If

                If XTR.Name = "ImagePPFrm_FieldorderComboBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then FieldorderComboBox.Text = XTRSTR Else FieldorderComboBox.Text = "Varying field order"
                End If

            Loop

        Catch ex As Exception
            MsgBox("XML_LOAD_ERROR :" & ex.Message)
        Finally
            XTR.Close()
        End Try

    End Sub

    Private Sub XML_CHANGE(ByVal src As String)

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

        Try
            Dim XDoc As New XmlDocument()
            Dim XNode As XmlNode
            XDoc.Load(src)
            '============== 시작

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/ImagePPFrm_AviSynthFramerateComboBox")
            If Not XNode Is Nothing Then XNode.InnerText = AviSynthFramerateComboBox.Text

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/ImagePPFrm_AviSynthFramerateCheckBox")
            If Not XNode Is Nothing Then XNode.InnerText = AviSynthFramerateCheckBox.Checked

            'AviSynthImageSizeComboBox
            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/ImagePPFrm_AviSynthImageSizeComboBox")
            If AviSynthImageSizeComboBox.Text = LangCls.ImagePPUserInputComboBox Then
                If Not XNode Is Nothing Then XNode.InnerText = "LangCls.ImagePPUserInputComboBox"
            Else
                If Not XNode Is Nothing Then XNode.InnerText = AviSynthImageSizeComboBox.Text
            End If
            'AviSynthImageSizeComboBox

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/ImagePPFrm_AviSynthImageSizeWidthTextBox")
            If Not XNode Is Nothing Then If AviSynthImageSizeWidthTextBox.Text = "" Then XNode.InnerText = "480" Else XNode.InnerText = AviSynthImageSizeWidthTextBox.Text

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/ImagePPFrm_AviSynthImageSizeHeightTextBox")
            If Not XNode Is Nothing Then If AviSynthImageSizeHeightTextBox.Text = "" Then XNode.InnerText = "272" Else XNode.InnerText = AviSynthImageSizeHeightTextBox.Text

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/ImagePPFrm_AviSynthImageSizeCheckBox")
            If Not XNode Is Nothing Then XNode.InnerText = AviSynthImageSizeCheckBox.Checked

            'AviSynthResizeFilterComboBox
            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/ImagePPFrm_AviSynthResizeFilterComboBox")
            If InStr(AviSynthResizeFilterComboBox.Text, LangCls.ImagePPBlurStr) <> 0 Then
                If Not XNode Is Nothing Then XNode.InnerText = Split(AviSynthResizeFilterComboBox.Text, " ")(0) & " LangCls.ImagePPBlurStr"
            ElseIf InStr(AviSynthResizeFilterComboBox.Text, LangCls.ImagePPSharpStr) <> 0 Then
                If Not XNode Is Nothing Then XNode.InnerText = Split(AviSynthResizeFilterComboBox.Text, " ")(0) & " LangCls.ImagePPSharpStr"
            ElseIf InStr(AviSynthResizeFilterComboBox.Text, LangCls.ImagePPMiddleStr) <> 0 Then
                If Not XNode Is Nothing Then XNode.InnerText = Split(AviSynthResizeFilterComboBox.Text, " ")(0) & " LangCls.ImagePPMiddleStr"
            End If
            'AviSynthResizeFilterComboBox

            'AviSynthAspectComboBox
            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/ImagePPFrm_AviSynthAspectComboBox")
            If AviSynthAspectComboBox.Text = LangCls.ImagePPNoKeepAviSynthAspectComboBox Then
                If Not XNode Is Nothing Then XNode.InnerText = "LangCls.ImagePPNoKeepAviSynthAspectComboBox"
            ElseIf AviSynthAspectComboBox.Text = LangCls.ImagePPLetterBoxAviSynthAspectComboBox Then
                If Not XNode Is Nothing Then XNode.InnerText = "LangCls.ImagePPLetterBoxAviSynthAspectComboBox"
            ElseIf AviSynthAspectComboBox.Text = LangCls.ImagePPCropAviSynthAspectComboBox Then
                If Not XNode Is Nothing Then XNode.InnerText = "LangCls.ImagePPCropAviSynthAspectComboBox"
            End If
            'AviSynthAspectComboBox

            'AviSynthAspectComboBox2
            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/ImagePPFrm_AviSynthAspectComboBox2")
            If AviSynthAspectComboBox2.Text = LangCls.ImagePPOutputAviSynthAspectComboBox2 Then
                If Not XNode Is Nothing Then XNode.InnerText = "LangCls.ImagePPOutputAviSynthAspectComboBox2"
            ElseIf AviSynthAspectComboBox2.Text = LangCls.ImagePPOriginalAviSynthAspectComboBox2 Then
                If Not XNode Is Nothing Then XNode.InnerText = "LangCls.ImagePPOriginalAviSynthAspectComboBox2"
            ElseIf AviSynthAspectComboBox2.Text = LangCls.ImagePP43AviSynthAspectComboBox2 Then
                If Not XNode Is Nothing Then XNode.InnerText = "LangCls.ImagePP43AviSynthAspectComboBox2"
            ElseIf AviSynthAspectComboBox2.Text = LangCls.ImagePP169AviSynthAspectComboBox2 Then
                If Not XNode Is Nothing Then XNode.InnerText = "LangCls.ImagePP169AviSynthAspectComboBox2"
            ElseIf AviSynthAspectComboBox2.Text = LangCls.ImagePP1851AviSynthAspectComboBox2 Then
                If Not XNode Is Nothing Then XNode.InnerText = "LangCls.ImagePP1851AviSynthAspectComboBox2"
            ElseIf AviSynthAspectComboBox2.Text = LangCls.ImagePP2351AviSynthAspectComboBox2 Then
                If Not XNode Is Nothing Then XNode.InnerText = "LangCls.ImagePP2351AviSynthAspectComboBox2"
            ElseIf AviSynthAspectComboBox2.Text = LangCls.ImagePPUserInputComboBox Then
                If Not XNode Is Nothing Then XNode.InnerText = "LangCls.ImagePPUserInputComboBox"
            End If
            'AviSynthAspectComboBox2

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/ImagePPFrm_AviSynthAspectWTextBox")
            If Not XNode Is Nothing Then If AviSynthAspectWTextBox.Text = "" Then XNode.InnerText = "0" Else XNode.InnerText = AviSynthAspectWTextBox.Text

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/ImagePPFrm_AviSynthAspectHTextBox")
            If Not XNode Is Nothing Then If AviSynthAspectHTextBox.Text = "" Then XNode.InnerText = "0" Else XNode.InnerText = AviSynthAspectHTextBox.Text

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/ImagePPFrm_AviSynthDeinterlaceCheckBox")
            If Not XNode Is Nothing Then XNode.InnerText = AviSynthDeinterlaceCheckBox.Checked

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/ImagePPFrm_AviSynthDeinterlaceComboBox")
            If Not XNode Is Nothing Then XNode.InnerText = AviSynthDeinterlaceComboBox.Text

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/ImagePPFrm_brightnessNumericUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = brightnessNumericUpDown.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/ImagePPFrm_contrastNumericUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = contrastNumericUpDown.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/ImagePPFrm_saturationNumericUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = saturationNumericUpDown.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/ImagePPFrm_hueNumericUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = hueNumericUpDown.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/ImagePPFrm_SharpenNumericUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = SharpenNumericUpDown.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/ImagePPFrm_ColorYUVTVPCRadioButton")
            If Not XNode Is Nothing Then XNode.InnerText = ColorYUVTVPCRadioButton.Checked

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/ImagePPFrm_ColorYUVPCTVRadioButton")
            If Not XNode Is Nothing Then XNode.InnerText = ColorYUVPCTVRadioButton.Checked

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/ImagePPFrm_ColorYUVNRadioButton")
            If Not XNode Is Nothing Then XNode.InnerText = ColorYUVNRadioButton.Checked

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/ImagePPFrm_ColorYUVASCheckBox")
            If Not XNode Is Nothing Then XNode.InnerText = ColorYUVASCheckBox.Checked

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/ImagePPFrm_AVSMPEG2DeinterlaceCheckBox")
            If Not XNode Is Nothing Then XNode.InnerText = AVSMPEG2DeinterlaceCheckBox.Checked

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/ImagePPFrm_AVSMPEG2DeinterlaceComboBox")
            If Not XNode Is Nothing Then XNode.InnerText = AVSMPEG2DeinterlaceComboBox.Text

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/ImagePPFrm_FieldorderComboBox")
            If Not XNode Is Nothing Then XNode.InnerText = FieldorderComboBox.Text

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

    Private Sub brightnessNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles brightnessNumericUpDown.LostFocus
        brightnessNumericUpDown.Text = brightnessNumericUpDown.Value
    End Sub

    Private Sub brightnessNumericUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brightnessNumericUpDown.ValueChanged
        brightnessTrackBar.Value = brightnessNumericUpDown.Value
    End Sub

    Private Sub brightnessTrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brightnessTrackBar.Scroll
        brightnessNumericUpDown.Value = brightnessTrackBar.Value
    End Sub

    Private Sub contrastNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles contrastNumericUpDown.LostFocus
        contrastNumericUpDown.Text = contrastNumericUpDown.Value
    End Sub

    Private Sub contrastNumericUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles contrastNumericUpDown.ValueChanged
        contrastTrackBar.Value = contrastNumericUpDown.Value * 100
    End Sub

    Private Sub contrastTrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles contrastTrackBar.Scroll
        contrastNumericUpDown.Value = contrastTrackBar.Value / 100
    End Sub

    Private Sub saturationNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles saturationNumericUpDown.LostFocus
        saturationNumericUpDown.Text = saturationNumericUpDown.Value
    End Sub

    Private Sub saturationNumericUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saturationNumericUpDown.ValueChanged
        saturationTrackBar.Value = saturationNumericUpDown.Value * 100
    End Sub

    Private Sub saturationTrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saturationTrackBar.Scroll
        saturationNumericUpDown.Value = saturationTrackBar.Value / 100
    End Sub

    Private Sub hueNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles hueNumericUpDown.LostFocus
        hueNumericUpDown.Text = hueNumericUpDown.Value
    End Sub

    Private Sub hueNumericUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hueNumericUpDown.ValueChanged
        hueTrackBar.Value = hueNumericUpDown.Value
    End Sub

    Private Sub hueTrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hueTrackBar.Scroll
        hueNumericUpDown.Value = hueTrackBar.Value
    End Sub

    Private Sub brightnessButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brightnessButton.Click
        brightnessNumericUpDown.Value = 0
    End Sub

    Private Sub contrastButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles contrastButton.Click
        contrastNumericUpDown.Value = 1
    End Sub

    Private Sub saturationButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saturationButton.Click
        saturationNumericUpDown.Value = 1
    End Sub

    Private Sub hueButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hueButton.Click
        hueNumericUpDown.Value = 0
    End Sub

    Private Sub SharpenNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles SharpenNumericUpDown.LostFocus
        SharpenNumericUpDown.Text = SharpenNumericUpDown.Value
    End Sub

    Private Sub SharpenNumericUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SharpenNumericUpDown.ValueChanged
        SharpenTrackBar.Value = SharpenNumericUpDown.Value * 100
    End Sub

    Private Sub SharpenTrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SharpenTrackBar.Scroll
        SharpenNumericUpDown.Value = SharpenTrackBar.Value / 100
    End Sub

    Private Sub SharpenButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SharpenButton.Click
        SharpenNumericUpDown.Value = 0
    End Sub

    Private Sub AviSynthImageSizeComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AviSynthImageSizeComboBox.SelectedIndexChanged

        If AviSynthImageSizeComboBox.SelectedIndex = AviSynthImageSizeComboBox.Items.Count - 1 Then
            If AviSynthImageSizeCheckBox.Checked = True Then '원본 사이즈로
                AviSynthImageSizeWidthTextBox.Enabled = False
                AviSynthImageSizeHeightTextBox.Enabled = False
                AviSynthImageSizeSLabel.Enabled = False
            Else
                AviSynthImageSizeWidthTextBox.Enabled = True
                AviSynthImageSizeHeightTextBox.Enabled = True
                AviSynthImageSizeSLabel.Enabled = True
            End If
            AviSynthImageSizeWidthTextBox.Text = "0"
            AviSynthImageSizeHeightTextBox.Text = "0"
        Else
            AviSynthImageSizeWidthTextBox.Enabled = False
            AviSynthImageSizeHeightTextBox.Enabled = False
            AviSynthImageSizeSLabel.Enabled = False
            Try
                If InStr(AviSynthImageSizeComboBox.Text, " x ", CompareMethod.Text) <> 0 Then AviSynthImageSizeWidthTextBox.Text = Split(AviSynthImageSizeComboBox.Text, " x ")(0)
                If InStr(AviSynthImageSizeComboBox.Text, " x ", CompareMethod.Text) <> 0 Then
                    If InStr(AviSynthImageSizeComboBox.Text, " - ", CompareMethod.Text) <> 0 Then
                        AviSynthImageSizeHeightTextBox.Text = Split(Split(AviSynthImageSizeComboBox.Text, " x ")(1), " - ")(0)
                    Else
                        AviSynthImageSizeHeightTextBox.Text = Split(AviSynthImageSizeComboBox.Text, " x ")(1)
                    End If
                End If

            Catch ex As Exception
            End Try
        End If


    End Sub

    Private Sub AviSynthImageSizeCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AviSynthImageSizeCheckBox.CheckedChanged

        If AviSynthImageSizeCheckBox.Checked = True Then '원본 사이즈로
            AviSynthImageSizeLabel.Enabled = False
            AviSynthImageSizeComboBox.Enabled = False
            AviSynthImageSizeWidthTextBox.Enabled = False
            AviSynthImageSizeSLabel.Enabled = False
            AviSynthImageSizeHeightTextBox.Enabled = False
            AviSynthResizeFilterLabel.Enabled = False
            AviSynthResizeFilterComboBox.Enabled = False
            AviSynthAspectLabel.Enabled = False
            AviSynthAspectComboBox.Enabled = False
            AviSynthAspectComboBox2.Enabled = False
            AviSynthAspectWTextBox.Enabled = False
            AviSynthAspectSLabel.Enabled = False
            AviSynthAspectHTextBox.Enabled = False
        Else
            AviSynthImageSizeLabel.Enabled = True
            AviSynthImageSizeComboBox.Enabled = True
            If AviSynthImageSizeComboBox.SelectedIndex = AviSynthImageSizeComboBox.Items.Count - 1 Then
                AviSynthImageSizeWidthTextBox.Enabled = True
                AviSynthImageSizeHeightTextBox.Enabled = True
                AviSynthImageSizeSLabel.Enabled = True
            Else
                AviSynthImageSizeWidthTextBox.Enabled = False
                AviSynthImageSizeHeightTextBox.Enabled = False
                AviSynthImageSizeSLabel.Enabled = False
            End If
            AviSynthResizeFilterLabel.Enabled = True
            AviSynthResizeFilterComboBox.Enabled = True
            AviSynthAspectLabel.Enabled = True
            AviSynthAspectComboBox.Enabled = True
            AviSynthAspectComboBox2.Enabled = True
            If AviSynthAspectComboBox2.SelectedIndex = AviSynthAspectComboBox2.Items.Count - 1 Then
                AviSynthAspectWTextBox.Enabled = True
                AviSynthAspectSLabel.Enabled = True
                AviSynthAspectHTextBox.Enabled = True
            Else
                AviSynthAspectWTextBox.Enabled = False
                AviSynthAspectSLabel.Enabled = False
                AviSynthAspectHTextBox.Enabled = False
            End If
        End If

    End Sub

    Private Sub AviSynthImageSizeWidthTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AviSynthImageSizeWidthTextBox.KeyPress
        If FunctionCls.InputCheck_NUMBER(e, False, False) = True Then e.Handled = True
    End Sub

    Private Sub AviSynthImageSizeWidthTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles AviSynthImageSizeWidthTextBox.LostFocus
        If AviSynthImageSizeWidthTextBox.Text <> "" Then AviSynthImageSizeWidthTextBox.Text = Val(AviSynthImageSizeWidthTextBox.Text)
    End Sub

    Private Sub AviSynthImageSizeWidthTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AviSynthImageSizeWidthTextBox.TextChanged

    End Sub

    Private Sub AviSynthImageSizeHeightTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AviSynthImageSizeHeightTextBox.KeyPress
        If FunctionCls.InputCheck_NUMBER(e, False, False) = True Then e.Handled = True
    End Sub

    Private Sub AviSynthImageSizeHeightTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles AviSynthImageSizeHeightTextBox.LostFocus
        If AviSynthImageSizeHeightTextBox.Text <> "" Then AviSynthImageSizeHeightTextBox.Text = Val(AviSynthImageSizeHeightTextBox.Text)
    End Sub

    Private Sub AviSynthImageSizeHeightTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AviSynthImageSizeHeightTextBox.TextChanged

    End Sub

    Private Sub AviSynthAspectComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AviSynthAspectComboBox.SelectedIndexChanged

        If AviSynthAspectComboBox.SelectedIndex = 0 Then
            AviSynthAspectComboBox2.Visible = False
            AviSynthAspectWTextBox.Visible = False
            AviSynthAspectHTextBox.Visible = False
            AviSynthAspectSLabel.Visible = False
        Else
            AviSynthAspectComboBox2.Visible = True
            AviSynthAspectWTextBox.Visible = True
            AviSynthAspectHTextBox.Visible = True
            AviSynthAspectSLabel.Visible = True
        End If

    End Sub

    Private Sub AviSynthAspectComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AviSynthAspectComboBox2.SelectedIndexChanged

        If AviSynthAspectComboBox2.SelectedIndex = 0 Then 'DAR
            AviSynthAspectWTextBox.Enabled = False
            AviSynthAspectSLabel.Enabled = False
            AviSynthAspectHTextBox.Enabled = False
            AviSynthAspectWTextBox.Text = "0"
            AviSynthAspectHTextBox.Text = "0"

        ElseIf AviSynthAspectComboBox2.SelectedIndex = 1 Then 'SAR
            AviSynthAspectWTextBox.Enabled = False
            AviSynthAspectSLabel.Enabled = False
            AviSynthAspectHTextBox.Enabled = False
            AviSynthAspectWTextBox.Text = "0"
            AviSynthAspectHTextBox.Text = "0"

        ElseIf AviSynthAspectComboBox2.SelectedIndex = 2 Then '4:3
            AviSynthAspectWTextBox.Enabled = False
            AviSynthAspectSLabel.Enabled = False
            AviSynthAspectHTextBox.Enabled = False
            AviSynthAspectWTextBox.Text = "4"
            AviSynthAspectHTextBox.Text = "3"

        ElseIf AviSynthAspectComboBox2.SelectedIndex = 3 Then '16:9
            AviSynthAspectWTextBox.Enabled = False
            AviSynthAspectSLabel.Enabled = False
            AviSynthAspectHTextBox.Enabled = False
            AviSynthAspectWTextBox.Text = "16"
            AviSynthAspectHTextBox.Text = "9"

        ElseIf AviSynthAspectComboBox2.SelectedIndex = 4 Then '1.85:1
            AviSynthAspectWTextBox.Enabled = False
            AviSynthAspectSLabel.Enabled = False
            AviSynthAspectHTextBox.Enabled = False
            AviSynthAspectWTextBox.Text = "1.85"
            AviSynthAspectHTextBox.Text = "1"

        ElseIf AviSynthAspectComboBox2.SelectedIndex = 5 Then '2.35:1
            AviSynthAspectWTextBox.Enabled = False
            AviSynthAspectSLabel.Enabled = False
            AviSynthAspectHTextBox.Enabled = False
            AviSynthAspectWTextBox.Text = "2.35"
            AviSynthAspectHTextBox.Text = "1"

        ElseIf AviSynthAspectComboBox2.SelectedIndex = AviSynthAspectComboBox2.Items.Count - 1 Then '사용자
            AviSynthAspectWTextBox.Enabled = True
            AviSynthAspectSLabel.Enabled = True
            AviSynthAspectHTextBox.Enabled = True
            AviSynthAspectWTextBox.Text = "0"
            AviSynthAspectHTextBox.Text = "0"

        End If

    End Sub

    Private Sub AviSynthAspectWTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AviSynthAspectWTextBox.KeyPress
        If FunctionCls.InputCheck_NUMBER(e, True, False) = True Then e.Handled = True
    End Sub

    Private Sub AviSynthAspectWTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles AviSynthAspectWTextBox.LostFocus
        If AviSynthAspectWTextBox.Text <> "" Then AviSynthAspectWTextBox.Text = Val(AviSynthAspectWTextBox.Text)
    End Sub

    Private Sub AviSynthAspectWTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AviSynthAspectWTextBox.TextChanged

    End Sub

    Private Sub AviSynthAspectHTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AviSynthAspectHTextBox.KeyPress
        If FunctionCls.InputCheck_NUMBER(e, True, False) = True Then e.Handled = True
    End Sub

    Private Sub AviSynthAspectHTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles AviSynthAspectHTextBox.LostFocus
        If AviSynthAspectHTextBox.Text <> "" Then AviSynthAspectHTextBox.Text = Val(AviSynthAspectHTextBox.Text)
    End Sub

    Private Sub AviSynthAspectHTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AviSynthAspectHTextBox.TextChanged

    End Sub

    Private Sub AviSynthDeinterlaceCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AviSynthDeinterlaceCheckBox.CheckedChanged
        If AviSynthDeinterlaceCheckBox.Checked = True Then
            AviSynthDeinterlaceComboBox.Enabled = True
        Else
            AviSynthDeinterlaceComboBox.Enabled = False
        End If
    End Sub

    Private Sub DefBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefBTN.Click
        AviSynthFramerateComboBox.Text = "23.976"
        AviSynthFramerateCheckBox.Checked = False
        AviSynthImageSizeComboBox.Text = "480 x 272"
        AviSynthImageSizeWidthTextBox.Text = "480"
        AviSynthImageSizeHeightTextBox.Text = "272"
        AviSynthImageSizeCheckBox.Checked = False
        AviSynthResizeFilterComboBox.Text = "Bicubic " & LangCls.ImagePPMiddleStr
        AviSynthAspectComboBox.Text = LangCls.EncSetLetterBoxAspectComboBox
        AviSynthAspectComboBox2.Text = LangCls.EncSetOutputAspectComboBox2
        AviSynthAspectWTextBox.Text = "0"
        AviSynthAspectHTextBox.Text = "0"
        AviSynthDeinterlaceCheckBox.Checked = False
        AviSynthDeinterlaceComboBox.Text = "linear blend deinterlacer (lb)"
        brightnessNumericUpDown.Value = 0
        contrastNumericUpDown.Value = 1
        saturationNumericUpDown.Value = 1
        hueNumericUpDown.Value = 0
        SharpenNumericUpDown.Value = 0
        ColorYUVTVPCRadioButton.Checked = False
        ColorYUVPCTVRadioButton.Checked = False
        ColorYUVNRadioButton.Checked = True
        ColorYUVASCheckBox.Checked = False
        AVSMPEG2DeinterlaceCheckBox.Checked = False
        AVSMPEG2DeinterlaceComboBox.Text = "Yadif mode=0"
        FieldorderComboBox.Text = "Varying field order"
    End Sub

    Private Sub OKBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKBTN.Click
        XML_CHANGE(My.Application.Info.DirectoryPath & "\settings.xml")
        Close()
    End Sub

    Private Sub CancelBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBTN.Click
        Close()
    End Sub

    Private Sub AviSynthFramerateCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AviSynthFramerateCheckBox.CheckedChanged


        If AviSynthFramerateCheckBox.Checked = True Then
            AviSynthFramerateLabel.Enabled = False
            AviSynthFramerateComboBox.Enabled = False
        Else
            AviSynthFramerateLabel.Enabled = True
            AviSynthFramerateComboBox.Enabled = True
        End If


    End Sub


    Private Sub AVSMPEG2DeinterlaceCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AVSMPEG2DeinterlaceCheckBox.CheckedChanged
        If AVSMPEG2DeinterlaceCheckBox.Checked = True Then
            AVSMPEG2DeinterlaceComboBox.Enabled = True
        Else
            AVSMPEG2DeinterlaceComboBox.Enabled = False
        End If
    End Sub

    Private Sub AviSynthFramerateComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AviSynthFramerateComboBox.SelectedIndexChanged

    End Sub
End Class