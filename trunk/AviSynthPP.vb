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

Public Class AviSynthPP

    Public Shared INDEX_ProcessStopChk As Boolean = False
    Public Shared INDEX_ProcessEChk As Boolean = False
    Public Shared INDEX_PStr As String = ""
    Public Shared INDEX_PVStr As String = ""
    Public Shared INDEX_ProcessHandle_ID As IntPtr = Nothing

    '프로세스 우선 순위
    Enum PriorityClass
        REALTIME_PRIORITY_CLASS = &H100
        HIGH_PRIORITY_CLASS = &H80
        ABOVE_NORMAL_PRIORITY_CLASS = 32768
        NORMAL_PRIORITY_CLASS = &H20
        BELOW_NORMAL_PRIORITY_CLASS = 16384
        IDLE_PRIORITY_CLASS = &H40
    End Enum

    Public Shared Sub AviSynthPreprocess(ByVal index As Integer, ByVal ShowModeV As Boolean, ByVal PriorityInt As Integer, ByVal ShowStatus As Boolean)

        Dim SelAudioStreamStr As String = ""

        '오디오 모드는 미리듣기용으로 자막 복사를 하지 않음//
        '-------------------------------------------------------

        '우선순위 설정관련// 기본값선택//
        If PriorityInt = Nothing Then
            PriorityInt = PriorityClass.NORMAL_PRIORITY_CLASS
        End If

        '/////////////////////////////////////////////////////////////////////////////////// 미디어 인포 _MI 변수 구간
        Dim _MI As MediaInfo
        _MI = New MediaInfo
        Try
            _MI.Open(MainFrm.EncListListView.Items(index).SubItems(10).Text)

            '-----------------------------------------
            ' 프레임
            '=========================================
            Dim fpsnumV, fpsdenV As Integer
            Dim fpsV As Double = 0.0
            If MainFrm.EncListListView.Items(index).SubItems(8).Text = "None" AndAlso _
            MainFrm.EncListListView.Items(index).SubItems(9).Text <> "None" Then '비디오 파일용
            Else

                If ImagePPFrm.AviSynthFramerateCheckBox.Checked = True Then '원본 프레임 레이트
                    Try
                        fpsV = Split(MainFrm.EncListListView.Items(index).SubItems(12).Text, ",")(1)
                        If ImagePPFrm.VFR60CheckBox.Checked = True Then '원본 프레임 레이트 인코딩시 최대 60 프레임 레이트로 제한
                            If fpsV > 60 Then fpsV = 60
                        End If
                    Catch ex As Exception
                        '에러나면 지정한 프레임 레이트로
                        fpsV = ImagePPFrm.AviSynthFramerateComboBox.Text
                    End Try
                Else
                    Try
                        fpsV = ImagePPFrm.AviSynthFramerateComboBox.Text
                        If ImagePPFrm.FPSDOCheckBox.Checked = True Then '선택한 fps보다 원본 파일의 fps가 작을 경우 원본 프레임 레이트 사용
                            If Val(Split(MainFrm.EncListListView.Items(index).SubItems(12).Text, ",")(1)) < fpsV Then fpsV = Val(Split(MainFrm.EncListListView.Items(index).SubItems(12).Text, ",")(1))
                        End If
                    Catch ex As Exception
                        '에러나면 지정한 프레임 레이트로
                        fpsV = ImagePPFrm.AviSynthFramerateComboBox.Text
                    End Try
                End If

                If fpsV = 14.99 OrElse fpsV = 14.985 Then
                    fpsnumV = 15000
                    fpsdenV = 1001
                ElseIf fpsV = 23.98 OrElse fpsV = 23.976 Then
                    fpsnumV = 24000
                    fpsdenV = 1001
                ElseIf fpsV = 29.97 Then
                    fpsnumV = 30000
                    fpsdenV = 1001
                ElseIf fpsV = 59.94 Then
                    fpsnumV = 60000
                    fpsdenV = 1001
                Else
                    If InStr(Str(fpsV), ".", CompareMethod.Text) <> 0 Then ' 소수점이 있으면
                        Dim FN As String = "0" '소수점 이하 숫자 구함(문자열로)
                        Dim FNDEN As Integer = 0 '나눌값을 지정
                        FN = Split(Str(fpsV), ".")(1)
                        FNDEN = 10 ^ Len(FN)
                        fpsnumV = Replace(Str(fpsV), ".", "")
                        fpsdenV = FNDEN
                    Else '없으면
                        fpsnumV = fpsV
                        fpsdenV = 1
                    End If
                End If

            End If

            '-----------------------------------------
            ' 프레임 #<changefps>
            '=========================================
            Dim changefpsV As String = "#<changefps>"
            If ImagePPFrm.AviSynthFramerateCheckBox.Checked = False Then
                changefpsV = "ChangeFPS(" & fpsV & ")"
            End If

            '-----------------------------------------
            ' #<image>
            '=========================================
            Dim ImageV As String = "#<image>"
            If MainFrm.EncListListView.Items(index).SubItems(8).Text = "None" AndAlso _
            MainFrm.EncListListView.Items(index).SubItems(9).Text <> "None" Then '비디오 파일용
            Else
                With ImagePPFrm

                    Dim SettingSizeWidthV, SettingSizeHeightV As Integer
                    Dim SourceSizeV, SourceWidthV, SourceHeightV
                    Dim ResizeWidthV, ResizeHeightV
                    Dim LetterWidthV, LetterHeightV
                    Dim CropWidthV, CropHeightV
                    Dim RealnputWidthV, RealnputHeightV, RealnputLetterWidthV, RealnputLetterHeightV, RealnputCropWidthV, RealnputCropHeightV

                    If .AviSynthImageSizeCheckBox.Checked = False Then

                        SettingSizeWidthV = .AviSynthImageSizeWidthTextBox.Text
                        SettingSizeHeightV = .AviSynthImageSizeHeightTextBox.Text

                        Try
                            SourceSizeV = Split(MainFrm.EncListListView.Items(index).SubItems(12).Text, ",")(0)
                        Catch ex As Exception
                            SourceSizeV = "0x0"
                            GoTo ImageSkip
                        End Try

                        If SourceSizeV = "x" Then
                            GoTo ImageSkip
                        End If

                        If SourceSizeV <> "" AndAlso .AviSynthAspectComboBox.Text = LangCls.ImagePPLetterBoxAviSynthAspectComboBox Then '사이즈입력받고, 레터박스 붙이기면

                            '/////비율 시작
                            If .AviSynthAspectComboBox2.Text = LangCls.ImagePPOutputAviSynthAspectComboBox2 Then 'DAR(출력 비율)

                                Dim DAR0 As Integer = 1, DAR00 As Integer = 0
                                Dim DARtes As String = ""
                                If InStr(DAR0, MainFrm.EncListListView.Items(index).SubItems(8).Text, "DAR ", CompareMethod.Text) Then
                                    DAR00 = InStr(DAR0, MainFrm.EncListListView.Items(index).SubItems(8).Text, "DAR ", CompareMethod.Text) + 4
                                    If InStr(DAR00, MainFrm.EncListListView.Items(index).SubItems(8).Text, "]", CompareMethod.Text) Then
                                        DAR0 = InStr(DAR00, MainFrm.EncListListView.Items(index).SubItems(8).Text, "]", CompareMethod.Text) + 1
                                        DARtes = Mid(MainFrm.EncListListView.Items(index).SubItems(8).Text, DAR00, DAR0 - DAR00 - 1)
                                    End If
                                Else
                                    DAR0 = DAR0 + 1
                                End If

                                If DARtes <> "" Then 'else Location Blank
                                    Try
                                        SourceWidthV = Split(DARtes, ":")(0)
                                        SourceHeightV = Split(DARtes, ":")(1)
                                    Catch ex As Exception
                                        SourceWidthV = 0
                                        SourceHeightV = 0
                                    End Try
                                Else
                                    Try
                                        SourceWidthV = Split(SourceSizeV, "x")(0)
                                        SourceHeightV = Split(SourceSizeV, "x")(1)
                                    Catch ex As Exception
                                        SourceWidthV = 0
                                        SourceHeightV = 0
                                    End Try
                                End If

                            ElseIf .AviSynthAspectComboBox2.Text = LangCls.ImagePPOriginalAviSynthAspectComboBox2 Then 'SAR(원본 비율)
                                Try
                                    SourceWidthV = Split(SourceSizeV, "x")(0)
                                    SourceHeightV = Split(SourceSizeV, "x")(1)
                                Catch ex As Exception
                                    SourceWidthV = 0
                                    SourceHeightV = 0
                                End Try
                            Else '아니면
                                SourceWidthV = .AviSynthAspectWTextBox.Text
                                SourceHeightV = .AviSynthAspectHTextBox.Text
                            End If
                            '회전
                            If ImagePPFrm.TurnCheckBox.Checked = True AndAlso (ImagePPFrm.TurnLeftRadioButton.Checked = True OrElse ImagePPFrm.TurnRightRadioButton.Checked = True) Then
                                Dim SourceWidthV2 = SourceWidthV
                                SourceWidthV = SourceHeightV
                                SourceHeightV = SourceWidthV2
                            End If
                            '------------------
                            '/////비율 끝

                            ResizeWidthV = Format((SourceWidthV / SourceHeightV / 4) * SettingSizeHeightV, 0) * 4
                            ResizeHeightV = Format((SourceHeightV / SourceWidthV / 4) * SettingSizeWidthV, 0) * 4

                            LetterWidthV = (.AviSynthImageSizeWidthTextBox.Text - ResizeWidthV) / 2
                            LetterHeightV = (.AviSynthImageSizeHeightTextBox.Text - ResizeHeightV) / 2

                            If (100 * (SourceWidthV / SourceHeightV)) - (100 * (SettingSizeWidthV / SettingSizeHeightV)) > 0 Then
                                RealnputWidthV = SettingSizeWidthV
                                RealnputHeightV = ResizeHeightV
                                RealnputLetterWidthV = 0
                                RealnputLetterHeightV = LetterHeightV
                                RealnputCropWidthV = 0
                                RealnputCropHeightV = 0
                            ElseIf (100 * (SettingSizeWidthV / SettingSizeHeightV)) - (100 * (SourceWidthV / SourceHeightV)) > 0 Then
                                RealnputWidthV = ResizeWidthV
                                RealnputHeightV = SettingSizeHeightV
                                RealnputLetterWidthV = LetterWidthV
                                RealnputLetterHeightV = 0
                                RealnputCropWidthV = 0
                                RealnputCropHeightV = 0
                            Else
                                RealnputWidthV = SettingSizeWidthV
                                RealnputHeightV = SettingSizeHeightV
                                RealnputLetterWidthV = 0
                                RealnputLetterHeightV = 0
                                RealnputCropWidthV = 0
                                RealnputCropHeightV = 0
                            End If

                        ElseIf SourceSizeV <> "" AndAlso .AviSynthAspectComboBox.Text = LangCls.ImagePPCropAviSynthAspectComboBox Then '사이즈입력받고, 비율 자르기면

                            '/////비율 시작
                            If .AviSynthAspectComboBox2.Text = LangCls.ImagePPOutputAviSynthAspectComboBox2 Then 'DAR(출력 비율)

                                Dim DAR0 As Integer = 1, DAR00 As Integer = 0
                                Dim DARtes As String = ""
                                If InStr(DAR0, MainFrm.EncListListView.Items(index).SubItems(8).Text, "DAR ", CompareMethod.Text) Then
                                    DAR00 = InStr(DAR0, MainFrm.EncListListView.Items(index).SubItems(8).Text, "DAR ", CompareMethod.Text) + 4
                                    If InStr(DAR00, MainFrm.EncListListView.Items(index).SubItems(8).Text, "]", CompareMethod.Text) Then
                                        DAR0 = InStr(DAR00, MainFrm.EncListListView.Items(index).SubItems(8).Text, "]", CompareMethod.Text) + 1
                                        DARtes = Mid(MainFrm.EncListListView.Items(index).SubItems(8).Text, DAR00, DAR0 - DAR00 - 1)
                                    End If
                                Else
                                    DAR0 = DAR0 + 1
                                End If

                                If DARtes <> "" Then 'else Location Blank
                                    Try
                                        SourceWidthV = Split(DARtes, ":")(0)
                                        SourceHeightV = Split(DARtes, ":")(1)
                                    Catch ex As Exception
                                        SourceWidthV = 0
                                        SourceHeightV = 0
                                    End Try
                                Else
                                    Try
                                        SourceWidthV = Split(SourceSizeV, "x")(0)
                                        SourceHeightV = Split(SourceSizeV, "x")(1)
                                    Catch ex As Exception
                                        SourceWidthV = 0
                                        SourceHeightV = 0
                                    End Try
                                End If

                            ElseIf .AviSynthAspectComboBox2.Text = LangCls.ImagePPOriginalAviSynthAspectComboBox2 Then 'SAR(원본 비율)
                                Try
                                    SourceWidthV = Split(SourceSizeV, "x")(0)
                                    SourceHeightV = Split(SourceSizeV, "x")(1)
                                Catch ex As Exception
                                    SourceWidthV = 0
                                    SourceHeightV = 0
                                End Try
                            Else '아니면
                                SourceWidthV = .AviSynthAspectWTextBox.Text
                                SourceHeightV = .AviSynthAspectHTextBox.Text
                            End If
                            '회전
                            If ImagePPFrm.TurnCheckBox.Checked = True AndAlso (ImagePPFrm.TurnLeftRadioButton.Checked = True OrElse ImagePPFrm.TurnRightRadioButton.Checked = True) Then
                                Dim SourceWidthV2 = SourceWidthV
                                SourceWidthV = SourceHeightV
                                SourceHeightV = SourceWidthV2
                            End If
                            '------------------
                            '/////비율 끝

                            ResizeWidthV = Format((SourceWidthV / SourceHeightV / 4) * SettingSizeHeightV, 0) * 4
                            ResizeHeightV = Format((SourceHeightV / SourceWidthV / 4) * SettingSizeWidthV, 0) * 4

                            CropWidthV = (.AviSynthImageSizeWidthTextBox.Text - ResizeWidthV) / 2
                            CropHeightV = (.AviSynthImageSizeHeightTextBox.Text - ResizeHeightV) / 2

                            If (100 * (SourceWidthV / SourceHeightV)) - (100 * (SettingSizeWidthV / SettingSizeHeightV)) > 0 Then
                                RealnputWidthV = SettingSizeWidthV - (CropWidthV * 2)
                                RealnputHeightV = SettingSizeHeightV
                                RealnputLetterWidthV = 0
                                RealnputLetterHeightV = 0
                                RealnputCropWidthV = CropWidthV
                                RealnputCropHeightV = 0
                            ElseIf (100 * (SettingSizeWidthV / SettingSizeHeightV)) - (100 * (SourceWidthV / SourceHeightV)) > 0 Then
                                RealnputWidthV = SettingSizeWidthV
                                RealnputHeightV = SettingSizeHeightV - (CropHeightV * 2)
                                RealnputLetterWidthV = 0
                                RealnputLetterHeightV = 0
                                RealnputCropWidthV = 0
                                RealnputCropHeightV = CropHeightV
                            Else
                                RealnputWidthV = SettingSizeWidthV
                                RealnputHeightV = SettingSizeHeightV
                                RealnputLetterWidthV = 0
                                RealnputLetterHeightV = 0
                                RealnputCropWidthV = 0
                                RealnputCropHeightV = 0
                            End If

                        Else '아니면
ImageSkip:
                            RealnputWidthV = SettingSizeWidthV
                            RealnputHeightV = SettingSizeHeightV
                            RealnputLetterWidthV = 0
                            RealnputLetterHeightV = 0
                            RealnputCropWidthV = 0
                            RealnputCropHeightV = 0
                        End If

                        '20100927 비율부분 수정//
                        Dim LCSizeV As String = ""
                        If SourceSizeV <> "" AndAlso .AviSynthAspectComboBox.Text = LangCls.ImagePPLetterBoxAviSynthAspectComboBox Then '사이즈입력받고, 레터박스 붙이기면
                            LCSizeV = ".AddBorders(" & RealnputLetterWidthV & "," & RealnputLetterHeightV & "," & RealnputLetterWidthV & "," & RealnputLetterHeightV & ")"
                        ElseIf SourceSizeV <> "" AndAlso .AviSynthAspectComboBox.Text = LangCls.ImagePPCropAviSynthAspectComboBox Then '사이즈입력받고, 비율 자르기면
                            LCSizeV = ".Crop(" & (-1 * Val(RealnputCropWidthV)) & "," & (-1 * Val(RealnputCropHeightV)) & "," & RealnputCropWidthV & "," & RealnputCropHeightV & ")"
                        End If

                        If .AviSynthResizeFilterComboBox.Text = "Bicubic " & LangCls.ImagePPSharpStr Then
                            ImageV = "BicubicResize(" & RealnputWidthV & "," & RealnputHeightV & ",0,0.75)" & LCSizeV
                        ElseIf .AviSynthResizeFilterComboBox.Text = "Bicubic " & LangCls.ImagePPMiddleStr Then
                            ImageV = "BicubicResize(" & RealnputWidthV & "," & RealnputHeightV & ",0,0.5)" & LCSizeV
                        ElseIf .AviSynthResizeFilterComboBox.Text = "Bicubic " & LangCls.ImagePPBlurStr Then
                            ImageV = "BicubicResize(" & RealnputWidthV & "," & RealnputHeightV & ",0.333,0.333)" & LCSizeV
                        Else
                            Try
                                ImageV = Split(.AviSynthResizeFilterComboBox.Text, " (")(0) & "Resize(" & RealnputWidthV & "," & RealnputHeightV & ")" & LCSizeV
                            Catch ex As Exception
                            End Try
                        End If

                    End If

                End With
            End If

            '-----------------------------------------
            ' #<amplifydb>
            '=========================================
            Dim amplifydbV As String = "#<amplifydb>"
            If AudioPPFrm.AmplifyCheckBox.Checked = True Then
                amplifydbV = "AmplifydB(" & AudioPPFrm.AmplifyNumericUpDown.Value & ")"
            End If

            '-----------------------------------------
            ' #<supereq>
            '=========================================
            Dim SuperEqV As String = "#<supereq>"
            With AudioPPFrm
                If .EQCheckBox.Checked = True Then

                    Dim EQV As String = ""
                    EQV = .EQ1TrackBar.Value & vbNewLine & _
                            .EQ2TrackBar.Value & vbNewLine & _
                            .EQ3TrackBar.Value & vbNewLine & _
                            .EQ4TrackBar.Value & vbNewLine & _
                            .EQ5TrackBar.Value & vbNewLine & _
                            .EQ6TrackBar.Value & vbNewLine & _
                            .EQ7TrackBar.Value & vbNewLine & _
                            .EQ8TrackBar.Value & vbNewLine & _
                            .EQ9TrackBar.Value & vbNewLine & _
                            .EQ10TrackBar.Value & vbNewLine & _
                            .EQ11TrackBar.Value & vbNewLine & _
                            .EQ12TrackBar.Value & vbNewLine & _
                            .EQ13TrackBar.Value & vbNewLine & _
                            .EQ14TrackBar.Value & vbNewLine & _
                            .EQ15TrackBar.Value & vbNewLine & _
                            .EQ16TrackBar.Value & vbNewLine & _
                            .EQ17TrackBar.Value & vbNewLine & _
                            .EQ18TrackBar.Value
                    Dim _StreamWriter As New StreamWriter(My.Application.Info.DirectoryPath & "\temp\Equalizer.feq", False, System.Text.Encoding.Default)
                    _StreamWriter.Write(EQV)
                    _StreamWriter.Close()
                    SuperEqV = "SuperEq(" & Chr(34) & My.Application.Info.DirectoryPath & "\temp\Equalizer.feq" & Chr(34) & ")"

                End If
            End With

            '-----------------------------------------
            ' #<textsub>
            '=========================================
            Dim TextSubV As String = "#<textsub>"
            Dim SubPathV As String = Strings.Left(MainFrm.EncListListView.Items(index).SubItems(10).Text, InStrRev(MainFrm.EncListListView.Items(index).SubItems(10).Text, "."))
            Dim SubFileExistsV As Boolean = True

            If MainFrm.EncListListView.Items(index).SubItems(8).Text = "None" AndAlso _
            MainFrm.EncListListView.Items(index).SubItems(9).Text <> "None" Then '비디오 파일용
            Else
                With SubtitleFrm

                    '---------------
                    ' 스타일 저장 (PSB, SMI, SRT, SUB)
                    '---------------
                    If MainFrm.EncListListView.Items(index).SubItems(2).Text = "PSB" OrElse MainFrm.EncListListView.Items(index).SubItems(2).Text = "SMI" _
                    OrElse MainFrm.EncListListView.Items(index).SubItems(2).Text = "SRT" OrElse MainFrm.EncListListView.Items(index).SubItems(2).Text = "SUB" Then

                        Dim SubExtenV As String = LCase(MainFrm.EncListListView.Items(index).SubItems(2).Text)
                        Dim ASSHEADERV As String = "[V4+ Styles]" & vbNewLine & _
                                                    "Format: Name, Fontname, Fontsize, PrimaryColour, SecondaryColour, OutlineColour, BackColour, Bold, Italic, Underline, StrikeOut, ScaleX, ScaleY, Spacing, Angle, BorderStyle, Outline, Shadow, Alignment, MarginL, MarginR, MarginV, Encoding" & vbNewLine & _
                                                    "Style: Default,"

                        '굵게
                        Dim BoldV As String
                        If .BoldCheckBox.Checked = True Then
                            BoldV = "-1"
                        Else
                            BoldV = "0"
                        End If

                        '기울임
                        Dim ItalicV As String
                        If .ItalicCheckBox.Checked = True Then
                            ItalicV = "-1"
                        Else
                            ItalicV = "0"
                        End If

                        '밑줄
                        Dim UnderlineV As String
                        If .UnderlineCheckBox.Checked = True Then
                            UnderlineV = "-1"
                        Else
                            UnderlineV = "0"
                        End If

                        '취소선
                        Dim StrikeOutV As String
                        If .StrikeOutCheckBox.Checked = True Then
                            StrikeOutV = "-1"
                        Else
                            StrikeOutV = "0"
                        End If

                        '경계 스타일
                        Dim BorderStyleV As String
                        If .BorderStyle1.Checked = True Then
                            BorderStyleV = "1"
                        Else
                            BorderStyleV = "3"
                        End If

                        '위치
                        Dim AlignmentV As String
                        If .Alignment1RadioButton.Checked = True Then
                            AlignmentV = "1"
                        ElseIf .Alignment2RadioButton.Checked = True Then
                            AlignmentV = "2"
                        ElseIf .Alignment3RadioButton.Checked = True Then
                            AlignmentV = "3"
                        ElseIf .Alignment5RadioButton.Checked = True Then
                            AlignmentV = "5"
                        ElseIf .Alignment6RadioButton.Checked = True Then
                            AlignmentV = "6"
                        ElseIf .Alignment4RadioButton.Checked = True Then
                            AlignmentV = "4"
                        ElseIf .Alignment9RadioButton.Checked = True Then
                            AlignmentV = "9"
                        ElseIf .Alignment7RadioButton.Checked = True Then
                            AlignmentV = "10"
                        Else
                            AlignmentV = "11"
                        End If

                        '문자인코딩
                        Dim EncodingV As String
                        Try
                            EncodingV = Replace(Split(.EncComboBox.Text, "(")(1), ")", "")
                        Catch ex As Exception
                            EncodingV = "1"
                        End Try

                        Dim ASSV As String = ""
                        ASSV = ASSHEADERV & .FontComboBox.Text & "," & .SizeUpDown.Value & "," & _
                        FunctionCls.ColorToHEX(.PrimaryColourPanel.BackColor.ToArgb.ToString, .PrimaryColourTrackBar.Value) & "," & _
                        FunctionCls.ColorToHEX(.SecondaryColourPanel.BackColor.ToArgb.ToString, .SecondaryColourTrackBar.Value) & "," & _
                        FunctionCls.ColorToHEX(.OutlineColourPanel.BackColor.ToArgb.ToString, .OutlineColourTrackBar.Value) & "," & _
                        FunctionCls.ColorToHEX(.BackColourPanel.BackColor.ToArgb.ToString, .BackColourTrackBar.Value) & "," & _
                        BoldV & "," & ItalicV & "," & UnderlineV & "," & StrikeOutV & "," & _
                        .ScaleXNumericUpDown.Value & "," & .ScaleYNumericUpDown.Value & "," & .SpacingNumericUpDown.Value & "," & .AngleNumericUpDown.Value & "," & _
                        BorderStyleV & "," & _
                        .OutlineUpDown.Value & "," & .BackUpDown.Value & "," & _
                        AlignmentV & "," & _
                        .MarginLNumericUpDown.Value & "," & .MarginRNumericUpDown.Value & "," & .MarginVNumericUpDown.Value & "," & _
                        EncodingV

                        Dim _StreamWriter As New StreamWriter(My.Application.Info.DirectoryPath & "\temp\Subtitle." & SubExtenV & ".style", False, System.Text.Encoding.Unicode)
                        _StreamWriter.Write(ASSV)
                        _StreamWriter.Close()

                        '---------------
                        ' 파일 복사
                        '---------------
                        Dim RECOPY As Integer = 0
                        If My.Computer.FileSystem.FileExists(SubPathV & SubExtenV) = True Then
                            Try
RECOPY:
                                My.Computer.FileSystem.CopyFile(SubPathV & SubExtenV, My.Application.Info.DirectoryPath & "\temp\Subtitle." & SubExtenV, True)
                            Catch ex As Exception
                                Threading.Thread.Sleep(100)
                                RECOPY += 1
                                Debug.Print("파일복사실패 " & RECOPY & " : " & ex.Message)
                                If RECOPY > 1000 Then '1000번(100초) = 1분 40초
                                    Dim MessageBoxV = MessageBox.Show("File copy failed, Retry?", "ERROR", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
                                    If MessageBoxV = DialogResult.Yes Then
                                        GoTo RECOPY
                                    Else
                                        GoTo ERRSKIP
                                    End If
                                End If
                                GoTo RECOPY
                            End Try
                            SubFileExistsV = True
                        Else
ERRSKIP:
                            SubFileExistsV = False
                        End If

                    End If 'PSB, SMI, SRT, SUB 자막 처리 부분 End If

                    '---------------
                    ' 스크립트 작성
                    '---------------
                    If SubFileExistsV = True AndAlso .SubtitleCheckBox.Checked = True Then
                        If MainFrm.EncListListView.Items(index).SubItems(2).Text = "ASS" Then
                            If My.Computer.FileSystem.FileExists(SubPathV & "ass") = True Then TextSubV = "TextSub(" & Chr(34) & SubPathV & "ass" & Chr(34) & ")"

                        ElseIf MainFrm.EncListListView.Items(index).SubItems(2).Text = "PSB" Then '스타일 적용
                            If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\temp\Subtitle.psb") = True Then TextSubV = "TextSub(" & Chr(34) & My.Application.Info.DirectoryPath & "\temp\Subtitle.psb" & Chr(34) & ")"

                        ElseIf MainFrm.EncListListView.Items(index).SubItems(2).Text = "SMI" Then '스타일 적용
                            If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\temp\Subtitle.smi") = True Then TextSubV = "TextSub(" & Chr(34) & My.Application.Info.DirectoryPath & "\temp\Subtitle.smi" & Chr(34) & ")"

                        ElseIf MainFrm.EncListListView.Items(index).SubItems(2).Text = "SRT" Then '스타일 적용
                            If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\temp\Subtitle.srt") = True Then TextSubV = "TextSub(" & Chr(34) & My.Application.Info.DirectoryPath & "\temp\Subtitle.srt" & Chr(34) & ")"

                        ElseIf MainFrm.EncListListView.Items(index).SubItems(2).Text = "SSA" Then
                            If My.Computer.FileSystem.FileExists(SubPathV & "ssa") = True Then TextSubV = "TextSub(" & Chr(34) & SubPathV & "ssa" & Chr(34) & ")"

                        ElseIf MainFrm.EncListListView.Items(index).SubItems(2).Text = "SUB" Then '스타일 적용
                            If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\temp\Subtitle.sub") = True Then TextSubV = "TextSub(" & Chr(34) & My.Application.Info.DirectoryPath & "\temp\Subtitle.sub" & Chr(34) & ")"

                        ElseIf MainFrm.EncListListView.Items(index).SubItems(2).Text = "IDX/SUB" Then
                            If My.Computer.FileSystem.FileExists(SubPathV & "idx") = True AndAlso My.Computer.FileSystem.FileExists(SubPathV & "sub") = True Then TextSubV = "VobSub(" & Chr(34) & SubPathV & "sub" & Chr(34) & ")"

                        End If
                    End If

                End With
            End If

            '------------------------
            ' #<channel>
            '========================
            '5.1 채널 -> 2채널 변환시 돌비디지털 사용여부 체크
            Dim EncListViewAudioV As String = MainFrm.EncListListView.Items(index).SubItems(9).Text
            Dim ia2 As Integer = 1, iia2 As Integer = 0
            Dim ta2 As String = ""
            Dim ChannelV As String = "#<channel>"
            '채널스크립트
            Dim CHTextBoxV As String = AviSynthEditorFrm.ChannelTextBox.Text

            If InStr(ia2, EncListViewAudioV, MainFrm.EncListListView.Items(index).SubItems(4).Text, CompareMethod.Text) Then
                iia2 = InStr(ia2, EncListViewAudioV, MainFrm.EncListListView.Items(index).SubItems(4).Text, CompareMethod.Text)
                If InStr(iia2, EncListViewAudioV, "|", CompareMethod.Text) Then
                    ia2 = InStr(iia2, EncListViewAudioV, "|", CompareMethod.Text)
                    ta2 = Mid(EncListViewAudioV, iia2, ia2 - iia2 - 1)
                End If
            Else
                ia2 = ia2 + 1
            End If
            SelAudioStreamStr = ta2
            If ta2 <> "" Then

                If InStr(1, ta2, "6 channels", CompareMethod.Text) <> 0 OrElse InStr(1, ta2, " 5.1", CompareMethod.Text) <> 0 Then

                    If AudioPPFrm.AviSynthChComboBox.Text = LangCls.AudioPPch10ComboBox Then
                        ChannelV = "ConvertToMono"

                    ElseIf AudioPPFrm.AviSynthChComboBox.Text = LangCls.AudioPPch20ComboBox Then
                        ChannelV = "Stereo6KE()"

                    ElseIf AudioPPFrm.AviSynthChComboBox.Text = LangCls.AudioPPch51ComboBox Then
                        ChannelV = "LFE516KE()"

                    ElseIf AudioPPFrm.AviSynthChComboBox.Text = LangCls.AudioPPdolbysComboBox Then
                        ChannelV = "DolbySurroundProLogic6KE()"

                    ElseIf AudioPPFrm.AviSynthChComboBox.Text = LangCls.AudioPPdolbypComboBox Then
                        ChannelV = "DolbyProLogicII6KE()"

                    End If

                ElseIf InStr(1, ta2, "2 channels", CompareMethod.Text) <> 0 OrElse InStr(1, ta2, " stereo", CompareMethod.Text) <> 0 Then

                    If AudioPPFrm.AviSynthChComboBox.Text = LangCls.AudioPPch10ComboBox Then
                        ChannelV = "ConvertToMono"

                    End If

                ElseIf InStr(1, ta2, "1 channels", CompareMethod.Text) <> 0 OrElse InStr(1, ta2, " mono", CompareMethod.Text) <> 0 Then

                    ChannelV = "ConvertToMono"

                Else

                    If AudioPPFrm.AviSynthChComboBox.Text = LangCls.AudioPPch10ComboBox Then
                        ChannelV = "ConvertToMono"

                    Else
                        ChannelV = "Stereo2KE()"

                    End If

                End If

                'If InStr(1, ta2, "ac3") <> 0 Then 'AC3
                '    CHTextBoxV = Replace(CHTextBoxV, "%FL%", "1")
                '    CHTextBoxV = Replace(CHTextBoxV, "%FC%", "2")
                '    CHTextBoxV = Replace(CHTextBoxV, "%FR%", "3")
                '    CHTextBoxV = Replace(CHTextBoxV, "%RL%", "4")
                '    CHTextBoxV = Replace(CHTextBoxV, "%RR%", "5")
                '    CHTextBoxV = Replace(CHTextBoxV, "%LFE%", "6")
                'If InStr(1, ta2, "dca") <> 0 Then 'DTS
                '    CHTextBoxV = Replace(CHTextBoxV, "%FC%", "1")
                '    CHTextBoxV = Replace(CHTextBoxV, "%FL%", "2")
                '    CHTextBoxV = Replace(CHTextBoxV, "%FR%", "3")
                '    CHTextBoxV = Replace(CHTextBoxV, "%RL%", "4")
                '    CHTextBoxV = Replace(CHTextBoxV, "%RR%", "5")
                '    CHTextBoxV = Replace(CHTextBoxV, "%LFE%", "6")
                'If InStr(1, ta2, "libfaad") <> 0 Or InStr(1, ta2, "aac") <> 0 Then 'AAC
                '    CHTextBoxV = Replace(CHTextBoxV, "%FC%", "1")
                '    CHTextBoxV = Replace(CHTextBoxV, "%FL%", "2")
                '    CHTextBoxV = Replace(CHTextBoxV, "%FR%", "3")
                '    CHTextBoxV = Replace(CHTextBoxV, "%RL%", "4")
                '    CHTextBoxV = Replace(CHTextBoxV, "%RR%", "5")
                '    CHTextBoxV = Replace(CHTextBoxV, "%LFE%", "6")
                'If InStr(1, ta2, "flac") <> 0 Then 'FLAC
                '    CHTextBoxV = Replace(CHTextBoxV, "%FL%", "1")
                '    CHTextBoxV = Replace(CHTextBoxV, "%FR%", "2")
                '    CHTextBoxV = Replace(CHTextBoxV, "%FC%", "3")
                '    CHTextBoxV = Replace(CHTextBoxV, "%LFE%", "4")
                '    CHTextBoxV = Replace(CHTextBoxV, "%RL%", "5")
                '    CHTextBoxV = Replace(CHTextBoxV, "%RR%", "6")
                'If InStr(1, ta2, "aiff") <> 0 Then 'AIFF
                '    CHTextBoxV = Replace(CHTextBoxV, "%FL%", "1")
                '    CHTextBoxV = Replace(CHTextBoxV, "%RL%", "2")
                '    CHTextBoxV = Replace(CHTextBoxV, "%FC%", "3")
                '    CHTextBoxV = Replace(CHTextBoxV, "%FR%", "4")
                '    CHTextBoxV = Replace(CHTextBoxV, "%RR%", "5")
                '    CHTextBoxV = Replace(CHTextBoxV, "%LFE%", "6")
                'Else
                CHTextBoxV = Replace(CHTextBoxV, "%FL%", "1")
                CHTextBoxV = Replace(CHTextBoxV, "%FR%", "2")
                CHTextBoxV = Replace(CHTextBoxV, "%FC%", "3")
                CHTextBoxV = Replace(CHTextBoxV, "%LFE%", "4")
                CHTextBoxV = Replace(CHTextBoxV, "%RL%", "5")
                CHTextBoxV = Replace(CHTextBoxV, "%RR%", "6")
                'End If

            End If

            '------------------------
            ' 비디오, 오디오 맵
            '========================
            Dim VideoMapV As String = ""
            Dim AudioMapV As String = ""
            Try
                VideoMapV = Split(Split(Split(MainFrm.EncListListView.Items(index).SubItems(8).Text, ":")(0), "#")(1), "(")(0)
                If IsNumeric(VideoMapV) = False Then
                    VideoMapV = Split(Split(Split(MainFrm.EncListListView.Items(index).SubItems(8).Text, ":")(0), "#")(1), "[")(0)
                End If
                VideoMapV = Replace(VideoMapV, "0.", "")
            Catch ex As Exception
            End Try

            Try
                AudioMapV = Split(Split(MainFrm.EncListListView.Items(index).SubItems(4).Text, "#")(1), "(")(0)
                If IsNumeric(AudioMapV) = False Then
                    AudioMapV = Split(Split(MainFrm.EncListListView.Items(index).SubItems(4).Text, "#")(1), "[")(0)
                End If
                AudioMapV = Replace(AudioMapV, "0.", "")
            Catch ex As Exception
            End Try

            '------------------------
            ' 구간설정
            '========================
            Dim PTimeInfo As String = MainFrm.EncListListView.Items(index).SubItems(11).Text
            Dim StartHMSV As Single = 0.0
            Dim EndHMSV As Single = 0.0
            Dim PlayHMSV As Single = 0.0

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
                    StartHMSV = Val((Split(t, ":")(0) * 3600)) + Val((Split(t, ":")(1) * 60)) + Val(Split(Split(t, ":")(2), ".")(0)) + Val("0." & Split(t, ".")(1))
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
                    EndHMSV = Val((Split(t, ":")(0) * 3600)) + Val((Split(t, ":")(1) * 60)) + Val(Split(Split(t, ":")(2), ".")(0)) + Val("0." & Split(t, ".")(1))
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
                Try
                    PlayHMSV = Val((Split(t, ":")(0) * 3600)) + Val((Split(t, ":")(1) * 60)) + Val(Split(Split(t, ":")(2), ".")(0)) + Val("0." & Split(t, ".")(1))
                Catch ex As Exception
                End Try
            End If

            '-------------------------
            ' 원본 샘플레이트 추출
            '=========================
            Dim AudioListV As String = MainFrm.EncListListView.Items(index).SubItems(9).Text
            Dim SSRCV As Integer = 48000
            i = 1
            ii = 0
            t = ""
            If InStr(i, AudioListV, MainFrm.EncListListView.Items(index).SubItems(4).Text, CompareMethod.Text) Then
                ii = InStr(i, AudioListV, MainFrm.EncListListView.Items(index).SubItems(4).Text, CompareMethod.Text)
                If InStr(ii, AudioListV, "Hz", CompareMethod.Text) Then
                    i = InStr(ii, AudioListV, "Hz", CompareMethod.Text) + 1
                    t = Mid(AudioListV, ii, i - ii - 1)
                End If
            Else
                i = i + 1
            End If
            If t <> "" Then
                SSRCV = Strings.Mid(RTrim(t), InStrRev(RTrim(t), " ") + 1)
            End If


            '-------------------------
            ' #<deinterlace>
            '=========================
            Dim DeinterlaceV As String = "#<deinterlace>"
            With ImagePPFrm
                If .AVSMPEG2DeinterlaceCheckBox.Checked = True Then
                    Dim ModeV As Integer = 0
                    If .AVSMPEG2DeinterlaceComboBox.Text = "Yadif mode=0" Then
                        ModeV = 0
                    ElseIf .AVSMPEG2DeinterlaceComboBox.Text = "Yadif mode=1 double framerate (bob)" Then
                        ModeV = 1
                    ElseIf .AVSMPEG2DeinterlaceComboBox.Text = "Yadif mode=2" Then
                        ModeV = 2
                    ElseIf .AVSMPEG2DeinterlaceComboBox.Text = "Yadif mode=3 double framerate (bob)" Then
                        ModeV = 3
                    End If
                    Dim FieldorderV As Integer = -1
                    If .FieldorderComboBox.Text = "Top Field First" Then
                        FieldorderV = 1
                    ElseIf .FieldorderComboBox.Text = "Bottom Field First" Then
                        FieldorderV = 0
                    ElseIf .FieldorderComboBox.Text = "Varying field order" Then
                        FieldorderV = -1
                    End If
                    DeinterlaceV = "Load_Stdcall_Plugin(" & Chr(34) & My.Application.Info.DirectoryPath & "\plugin\yadif.dll" & Chr(34) & ")" & vbNewLine & "Yadif(mode=" & ModeV & ",order=" & FieldorderV & ")"
                End If

            End With




            '========================================== 완료 ================================================




            '---------------------------------------
            '스크립트 변수에 저장
            '---------------------------------------
            '비디오, 오디오부분 존재 여부
            Dim AVTextBoxV As String = ""
            If (MainFrm.EncListListView.Items(index).SubItems(8).Text = "None" AndAlso MainFrm.EncListListView.Items(index).SubItems(9).Text <> "None") Then '오디오만 있는 경우




                '==================================================  오디오 
                If MainFrm.EncListListView.Items(index).SubItems(3).Text = "AC3" Then

                    If AviSynthEditorFrm.AC3DTSFilesFFmpegSourceToolStripMenuItem4.Checked = True Then
                        AVTextBoxV = AviSynthEditorFrm.FFmpegSourceTextBox.Text
                    ElseIf AviSynthEditorFrm.AC3DTSFilesNicAudioToolStripMenuItem.Checked = True Then
                        AVTextBoxV = AviSynthEditorFrm.NicAudioTextBox.Text
                        AVTextBoxV = Replace(AVTextBoxV, "#<nicsourcename>", "AC3")
                        AVTextBoxV = Replace(AVTextBoxV, "#<nicsourcelength>", Int(PlayHMSV * 25) + 1)
                        AVTextBoxV = Replace(AVTextBoxV, "#<nicsourcefps>", "25")
                    ElseIf AviSynthEditorFrm.AC3DTSFilesDirectShowSourceToolStripMenuItem1.Checked = True Then
                        AVTextBoxV = AviSynthEditorFrm.DirectShowSourceTextBox.Text
                    End If

                ElseIf MainFrm.EncListListView.Items(index).SubItems(3).Text = "DTS" Then

                    If AviSynthEditorFrm.AC3DTSFilesFFmpegSourceToolStripMenuItem4.Checked = True Then
                        AVTextBoxV = AviSynthEditorFrm.FFmpegSourceTextBox.Text
                    ElseIf AviSynthEditorFrm.AC3DTSFilesNicAudioToolStripMenuItem.Checked = True Then
                        AVTextBoxV = AviSynthEditorFrm.NicAudioTextBox.Text
                        AVTextBoxV = Replace(AVTextBoxV, "#<nicsourcename>", "DTS")
                        AVTextBoxV = Replace(AVTextBoxV, "#<nicsourcelength>", Int(PlayHMSV * 25) + 1)
                        AVTextBoxV = Replace(AVTextBoxV, "#<nicsourcefps>", "25")
                    ElseIf AviSynthEditorFrm.AC3DTSFilesDirectShowSourceToolStripMenuItem1.Checked = True Then
                        AVTextBoxV = AviSynthEditorFrm.DirectShowSourceTextBox.Text
                    End If

                ElseIf MainFrm.EncListListView.Items(index).SubItems(3).Text = "RM" OrElse MainFrm.EncListListView.Items(index).SubItems(3).Text = "AMR" Then

                    If AviSynthEditorFrm.RMAMRFilesFFmpegSourceToolStripMenuItem5.Checked = True Then
                        AVTextBoxV = AviSynthEditorFrm.FFmpegSourceTextBox.Text
                    ElseIf AviSynthEditorFrm.RMAMRFilesDirectShowSourceToolStripMenuItem2.Checked = True Then
                        AVTextBoxV = AviSynthEditorFrm.DirectShowSourceTextBox.Text
                    End If

                Else

                    If AviSynthEditorFrm.AllAudioFilesFFmpegSourceToolStripMenuItem3.Checked = True Then
                        AVTextBoxV = AviSynthEditorFrm.FFmpegSourceTextBox.Text
                    ElseIf AviSynthEditorFrm.AllAudioFilesBassAudioToolStripMenuItem.Checked = True Then
                        AVTextBoxV = AviSynthEditorFrm.BassAudioTextBox.Text
                    ElseIf AviSynthEditorFrm.AllAudioFilesDirectShowSourceToolStripMenuItem.Checked = True Then
                        AVTextBoxV = AviSynthEditorFrm.DirectShowSourceTextBox.Text
                    End If

                End If
                '==================================================  오디오 



            Else




                '================================================== 비디오 + 오디오 or 비디오
                If MainFrm.EncListListView.Items(index).SubItems(3).Text = "MPEGTS" OrElse MainFrm.EncListListView.Items(index).SubItems(3).Text = "MPEG" Then

                    If (InStr(MainFrm.EncListListView.Items(index).SubItems(8).Text, "h264", CompareMethod.Text) <> 0) OrElse (InStr(MainFrm.EncListListView.Items(index).SubItems(8).Text, "vc1", CompareMethod.Text) <> 0) Then 'M2TSFiles
                        If AviSynthEditorFrm.M2TSFilesFFmpegSourceToolStripMenuItem6.Checked = True Then
                            AVTextBoxV = AviSynthEditorFrm.FFmpegSourceTextBox.Text
                            AVTextBoxV = Replace(AVTextBoxV, "seekmode=auto", "seekmode=-1")
                        ElseIf AviSynthEditorFrm.M2TSFilesDirectShowSourceToolStripMenuItem1.Checked = True Then
                            AVTextBoxV = AviSynthEditorFrm.DirectShowSourceTextBox.Text
                        End If
                    Else
                        If AviSynthEditorFrm.MPEGTSMPEGFilesFFmpegSourceToolStripMenuItem1.Checked = True Then
                            AVTextBoxV = AviSynthEditorFrm.FFmpegSourceTextBox.Text
                            AVTextBoxV = Replace(AVTextBoxV, "seekmode=auto", "seekmode=-1")
                        ElseIf AviSynthEditorFrm.MPEGTSMPEGFilesMPEG2SourceToolStripMenuItem.Checked = True Then
                            AVTextBoxV = AviSynthEditorFrm.MPEG2SourceTextBox.Text
                        ElseIf AviSynthEditorFrm.MPEGTSMPEGFilesDirectShowSourceToolStripMenuItem.Checked = True Then
                            AVTextBoxV = AviSynthEditorFrm.DirectShowSourceTextBox.Text
                        End If
                    End If

                ElseIf MainFrm.EncListListView.Items(index).SubItems(3).Text = "ASF" Then

                    If AviSynthEditorFrm.ASFFilesFFmpegSourceToolStripMenuItem2.Checked = True Then
                        AVTextBoxV = AviSynthEditorFrm.FFmpegSourceTextBox.Text
                        AVTextBoxV = Replace(AVTextBoxV, "seekmode=auto", "seekmode=-1")
                    ElseIf AviSynthEditorFrm.ASFFilesDirectShowSourceToolStripMenuItem1.Checked = True Then
                        AVTextBoxV = AviSynthEditorFrm.DirectShowSourceTextBox.Text
                    End If

                Else

                    If AviSynthEditorFrm.AllMovieFilesFFmpegSourceToolStripMenuItem.Checked = True Then
                        AVTextBoxV = AviSynthEditorFrm.FFmpegSourceTextBox.Text
                    ElseIf AviSynthEditorFrm.AllMovieFilesDirectShowSourceToolStripMenuItem.Checked = True Then
                        AVTextBoxV = AviSynthEditorFrm.DirectShowSourceTextBox.Text
                    End If

                End If
                '================================================== 비디오 + 오디오 or 비디오





            End If











            '=========================================================================================================









            '-----------------------------------------
            'seekmode=auto
            '=========================================
            If InStr(AVTextBoxV, "seekmode=auto", CompareMethod.Text) <> 0 Then
                AVTextBoxV = Replace(AVTextBoxV, "seekmode=auto", "seekmode=1")
            End If

            '-----------------------------------------
            ' SEEKMODE CHECK
            '=========================================
            If InStr(AVTextBoxV, "seekmode=-1", CompareMethod.Text) <> 0 Then
                MainFrm.SEEKMODEM1B = True
                AviSynthEditorFrm.StatusLabel.Text = "FFVideoSource: Non-linear access attempted [seekmode=-1] // Playback only"
            Else
                MainFrm.SEEKMODEM1B = False
                AviSynthEditorFrm.StatusLabel.Text = ""
            End If


            '-----------------------------------------
            ' #<coloryuv>, #<coloryuv_analyze>
            '=========================================
            Dim ColorYUVV As String = "#<coloryuv>"
            Dim ColorYUVASV As String = "#<coloryuv_analyze>"
            If MainFrm.EncListListView.Items(index).SubItems(8).Text = "None" AndAlso _
            MainFrm.EncListListView.Items(index).SubItems(9).Text <> "None" Then '비디오 파일용
            Else
                With ImagePPFrm

                    If .ColorYUVTVPCRadioButton.Checked = True Then
                        ColorYUVV = "ColorYUV(levels=" & Chr(34) & "tv->pc" & Chr(34) & ")"
                    ElseIf .ColorYUVPCTVRadioButton.Checked = True Then
                        ColorYUVV = "ColorYUV(levels=" & Chr(34) & "pc->tv" & Chr(34) & ")"
                    End If

                    If .ColorYUVASCheckBox.Checked = True Then
                        ColorYUVASV = "ColorYUV(analyze=true).Histogram(" & Chr(34) & "classic" & Chr(34) & ").Histogram(" & Chr(34) & "color2" & Chr(34) & ")"
                    End If

                End With
            End If


            '==================================================== 완료 2번째

            Dim delayaudioV2 As String = "0"

            '(FFMSIndex)
            If (InStr(1, AVTextBoxV, "FFAudioSource", CompareMethod.Text) <> 0 OrElse InStr(1, AVTextBoxV, "FFVideoSource", CompareMethod.Text) <> 0) Then 'FFAudioSource, FFVideoSource

                '===========================
                '인덱스 생성관련
                '===========================
                If MainFrm.EncListListView.Items(index).SubItems(14).Text <> "" Then
                    If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\temp\caches\cache(" & MainFrm.EncListListView.Items(index).SubItems(13).Text & ").ffindex") = True Then '파일이 존재하면
                        If My.Computer.FileSystem.GetFileInfo(MainFrm.EncListListView.Items(index).SubItems(10).Text).LastWriteTime.Ticks.ToString = MainFrm.EncListListView.Items(index).SubItems(14).Text Then
                            GoTo skip
                        End If
                    End If
                End If

                '인덱스 프로그램이 없으면 스킵//
                If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\tools\ffms\ffmsindex.exe") = False Then
                    GoTo skip
                End If

                '비디오만 인덱스 여부
                Dim IndexVideoOnly As Boolean = False
                If MainFrm.EncListListView.Items(index).SubItems(3).Text = "MPEGTS" OrElse MainFrm.EncListListView.Items(index).SubItems(3).Text = "MPEG" Then
                    If InStr(MainFrm.EncListListView.Items(index).SubItems(8).Text, "h264", CompareMethod.Text) <> 0 OrElse _
                       InStr(MainFrm.EncListListView.Items(index).SubItems(8).Text, "vc1", CompareMethod.Text) <> 0 Then
                        If InStr(1, AVTextBoxV, "A=DirectShowSource(", CompareMethod.Text) <> 0 AndAlso InStr(1, AVTextBoxV, "FFAudioSource", CompareMethod.Text) = 0 Then
                            IndexVideoOnly = True
                        End If
                    End If
                End If

                If ShowModeV = True Then
                    '----------------
                    'ShowMode
                    '----------------
                    INDEX_PStr = ""
                    FFMSIndexFrm.IDSTR(MainFrm.EncListListView.Items(index).SubItems(10).Text, My.Application.Info.DirectoryPath & "\temp\caches\cache(" & MainFrm.EncListListView.Items(index).SubItems(13).Text & ").ffindex", PriorityInt, IndexVideoOnly)
                    Try
                        FFMSIndexFrm.ShowDialog()
                    Catch ex As Exception
                    End Try
                Else
                    '----------------
                    'HideMode
                    '----------------
                    INDEX_ProcessEChk = False
                    INDEX_PStr = ""
                    FFMSIndexFrm.IDSTR(MainFrm.EncListListView.Items(index).SubItems(10).Text, My.Application.Info.DirectoryPath & "\temp\caches\cache(" & MainFrm.EncListListView.Items(index).SubItems(13).Text & ").ffindex", PriorityInt, IndexVideoOnly)
                    If ShowStatus = True Then EncodingFrm.EncToolStripStatusLabel.Text = LangCls.EncodingCreatingFFINDEX
                    Do Until INDEX_ProcessEChk = True
                        Application.DoEvents()
                        Threading.Thread.Sleep(10)
                    Loop
                End If

                If INDEX_ProcessStopChk = True Then
                    Exit Sub '중지됨//
                Else
                    MainFrm.EncListListView.Items(index).SubItems(14).Text = My.Computer.FileSystem.GetFileInfo(MainFrm.EncListListView.Items(index).SubItems(10).Text).LastWriteTime.Ticks.ToString
                    MainFrm.CleanUpListBox.Items.Add(My.Application.Info.DirectoryPath & "\temp\caches\cache(" & MainFrm.EncListListView.Items(index).SubItems(13).Text & ").ffindex") '클린업
                End If
                '===========================

skip:

                '비디오, 오디오부분 존재 여부
                If (MainFrm.EncListListView.Items(index).SubItems(8).Text <> "None" AndAlso MainFrm.EncListListView.Items(index).SubItems(9).Text = "None") OrElse MainFrm.EncListListView.Items(index).SubItems(5).Text = "A_None" Then '비디오만 있는 경우

                    '오디오 부분 주석 처리
                    AVTextBoxV = Replace(AVTextBoxV, "A=FFAudioSource(source=", "#A=FFAudioSource(source=")
                    '비디오 부분
                    AVTextBoxV = Replace(AVTextBoxV, "V=FFVideoSource(source=", "FFVideoSource(source=")
                    '오디오 덥 부분 주석 처리
                    AVTextBoxV = Replace(AVTextBoxV, "AudioDub(V,A)", "#AudioDub(V,A)")
                    '증폭
                    AVTextBoxV = Replace(AVTextBoxV, "#<amplifydb>", "##<amplifydb>")
                    '이퀄라이저
                    AVTextBoxV = Replace(AVTextBoxV, "#<supereq>", "##<supereq>")

                ElseIf (MainFrm.EncListListView.Items(index).SubItems(8).Text = "None" AndAlso MainFrm.EncListListView.Items(index).SubItems(9).Text <> "None") OrElse MainFrm.EncListListView.Items(index).SubItems(5).Text = "V_None" Then '오디오만 있는 경우

                    '비디오 부분
                    AVTextBoxV = Replace(AVTextBoxV, "V=FFVideoSource(source=", "V=Blankclip(length=" & Int(PlayHMSV * 25) + 1 & ", width=176, height=144, fps=25)" & vbNewLine & "#V=FFVideoSource(source=")
                    '크롭
                    AVTextBoxV = Replace(AVTextBoxV, "#<crop>", "##<crop>")
                    '이미지
                    AVTextBoxV = Replace(AVTextBoxV, "#<image>", "##<image>")
                    'ConvertToYV12()
                    AVTextBoxV = Replace(AVTextBoxV, "ConvertToYV12()", "#ConvertToYV12()")
                    '컬러YUV
                    AVTextBoxV = Replace(AVTextBoxV, "#<coloryuv>", "##<coloryuv>")
                    '샤픈
                    AVTextBoxV = Replace(AVTextBoxV, "#<sharpen>", "##<sharpen>")
                    '트윅
                    AVTextBoxV = Replace(AVTextBoxV, "#<tweak>", "##<tweak>")
                    '컬러YUV분석
                    AVTextBoxV = Replace(AVTextBoxV, "#<coloryuv_analyze>", "##<coloryuv_analyze>")
                    '자막
                    AVTextBoxV = Replace(AVTextBoxV, "#<textsub>", "##<textsub>")

                End If

                '#<delayaudio>, '#<delayaudio2>
                Dim delayaudioV As String = "0"
                '미디어 인포 비디오딜레이값 검사
                Dim AudioStramCntStr As String = "0"
                AudioStramCntStr = _MI.Get_(StreamKind.Audio, 0, "StreamCount")
                If AudioStramCntStr = "" OrElse AudioStramCntStr = "0" Then
                    GoTo DelayAudioSkip
                End If
                'SN구하기 (스트림 ID비교)//
                Dim SN As Integer = 0
                Dim i2 As Integer
                For i2 = 0 To AudioStramCntStr - 1
                    Dim ta2v0 As String = _MI.Get_(StreamKind.Audio, i2, "ID")
                    Dim AudioMapV2 As String = ""
                    If ta2v0 <> "" Then
                        If InStr(AudioMapV, ".", CompareMethod.Text) <> 0 Then
                            Try
                                AudioMapV2 = Split(AudioMapV, ".")(1)
                            Catch ex As Exception
                            End Try
                        Else
                            AudioMapV2 = AudioMapV
                        End If
                        AudioMapV2 = Val(AudioMapV2) + 1
                        If ta2v0 = AudioMapV2 Then
                            SN = i2
                            Exit For
                        End If
                    End If
                Next
                Dim ta2v1 As String = _MI.Get_(StreamKind.Audio, SN, "Video_Delay")
                If ta2v1 = "0" OrElse ta2v1 = "" Then
                    delayaudioV = 0
                    'delayaudioV2 = 0
                Else
                    delayaudioV = ta2v1
                    'delayaudioV2 = ta2v1
                End If
                If MainFrm.EncListListView.Items(index).SubItems(3).Text = "MATROSKA" OrElse MainFrm.EncListListView.Items(index).SubItems(3).Text = "MATROSKA,WEBM" Then 'FFmpegSource에 의해 어드저스트 딜레이 -3 설정은 자동싱크 조절 된다. 그러므로 0.
                    delayaudioV = 0
                End If
DelayAudioSkip:
                AVTextBoxV = Replace(AVTextBoxV, "#<delayaudio>", "DelayAudio(" & delayaudioV & "/1000.0)")

                '#<ffpp>
                Dim FFPPStr As String = ""
                With ImagePPFrm
                    If .FFPP_hb_CheckBox.Checked = True Then
                        FFPPStr = FFPPStr & "/hb:a"
                    End If
                    If .FFPP_vb_CheckBox.Checked = True Then
                        FFPPStr = FFPPStr & "/vb:a"
                    End If
                    If .FFPP_ha_CheckBox.Checked = True Then
                        FFPPStr = FFPPStr & "/ha:a"
                    End If
                    If .FFPP_va_CheckBox.Checked = True Then
                        FFPPStr = FFPPStr & "/va:a"
                    End If
                    If .FFPP_h1_CheckBox.Checked = True Then
                        FFPPStr = FFPPStr & "/h1:a"
                    End If
                    If .FFPP_v1_CheckBox.Checked = True Then
                        FFPPStr = FFPPStr & "/v1:a"
                    End If
                    If .FFPP_dr_CheckBox.Checked = True Then
                        FFPPStr = FFPPStr & "/dr:a"
                    End If
                    If ImagePPFrm.AviSynthDeinterlaceCheckBox.Checked = True Then '디인터레이스 여부
                        Try
                            FFPPStr = FFPPStr & "/" & Replace(Split(ImagePPFrm.AviSynthDeinterlaceComboBox.Text, "(")(1), ")", "")
                        Catch ex As Exception
                        End Try
                    End If
                    If Left(FFPPStr, 1) = "/" Then
                        FFPPStr = ".FFPP(" & Chr(34) & Replace(FFPPStr, "/", "", 1, 1) & Chr(34) & ")"
                    End If
                End With
                AVTextBoxV = Replace(AVTextBoxV, "#<ffpp>", FFPPStr)

                '#<cachefile>
                AVTextBoxV = Replace(AVTextBoxV, "#<cachefile>", My.Application.Info.DirectoryPath & "\temp\caches\cache(" & MainFrm.EncListListView.Items(index).SubItems(13).Text & ").ffindex")

                '#<atrack>
                AVTextBoxV = Replace(AVTextBoxV, "#<atrack>", AudioMapV)

                '#<vtrack>
                AVTextBoxV = Replace(AVTextBoxV, "#<vtrack>", VideoMapV)


                '(DGIndex)
            ElseIf InStr(1, AVTextBoxV, "MPEG2Source", CompareMethod.Text) <> 0 Then 'MPEG2Source 있을 때 작동.

                '===========================
                '인덱스 생성관련
                '===========================
                If MainFrm.EncListListView.Items(index).SubItems(16).Text <> "" Then
                    If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\temp\caches\cache(" & MainFrm.EncListListView.Items(index).SubItems(13).Text & ").d2v") = True Then '파일이 존재하면
                        If My.Computer.FileSystem.GetFileInfo(MainFrm.EncListListView.Items(index).SubItems(10).Text).LastWriteTime.Ticks.ToString = MainFrm.EncListListView.Items(index).SubItems(16).Text Then
                            GoTo skip2
                        End If
                    End If
                End If

                '인덱스 프로그램이 없으면 스킵//
                If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\tools\dgindex\dgindex.exe") = False Then
                    GoTo skip2
                End If

                If ShowModeV = True Then
                    '----------------
                    'ShowMode
                    '----------------
                    INDEX_PStr = ""
                    DGIndexFrm.IDSTR(MainFrm.EncListListView.Items(index).SubItems(10).Text, My.Application.Info.DirectoryPath & "\temp\caches\cache(" & MainFrm.EncListListView.Items(index).SubItems(13).Text & ")", index, PriorityInt)
                    Try
                        DGIndexFrm.ShowDialog()
                    Catch ex As Exception
                    End Try
                Else
                    '----------------
                    'HideMode
                    '----------------
                    INDEX_ProcessEChk = False
                    INDEX_PStr = ""
                    DGIndexFrm.IDSTR(MainFrm.EncListListView.Items(index).SubItems(10).Text, My.Application.Info.DirectoryPath & "\temp\caches\cache(" & MainFrm.EncListListView.Items(index).SubItems(13).Text & ")", index, PriorityInt)
                    If ShowStatus = True Then EncodingFrm.EncToolStripStatusLabel.Text = LangCls.EncodingCreatingD2V
                    Do Until INDEX_ProcessEChk = True
                        Application.DoEvents()
                        Threading.Thread.Sleep(10)
                    Loop
                End If

                '============================================
                '-- 오디오 파일 찾아서 선택 관련 부분 -- 기본 스트림(첫번째)으로 사용한다.
                '============================================
                '확장자      = FFmpeg
                'mp1 or mpa  = mp1
                'mp2 or mpa  = mp2
                'mp3 or mpa  = mp3
                'ac3         = ac3 or liba52
                'wav or lpcm = pcm
                'dts         = dca
                'aac         = aac or libfaad
                Dim LvAudioList As String = MainFrm.EncListListView.Items(index).SubItems(9).Text
                Dim FileListBox2 As New ListBox
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

                        Dim EXV As String = ""
                        Dim EXV2 As String = ""
                        If InStr(ta2, "mp1", CompareMethod.Text) <> 0 Then
                            EXV = "*.mp1"
                            EXV2 = "*.mpa"
                        ElseIf InStr(ta2, "mp2", CompareMethod.Text) <> 0 Then
                            EXV = "*.mp2"
                            EXV2 = "*.mpa"
                        ElseIf InStr(ta2, "mp3", CompareMethod.Text) <> 0 Then
                            EXV = "*.mp3"
                            EXV2 = "*.mpa"
                        ElseIf InStr(ta2, "ac3", CompareMethod.Text) <> 0 OrElse InStr(ta2, "liba52", CompareMethod.Text) <> 0 Then
                            EXV = "*.ac3"
                        ElseIf InStr(ta2, "pcm", CompareMethod.Text) <> 0 Then
                            EXV = "*.wav"
                            EXV2 = "*.lpcm"
                        ElseIf InStr(ta2, "dca", CompareMethod.Text) <> 0 Then
                            EXV = "*.dts"
                        ElseIf InStr(ta2, "aac", CompareMethod.Text) <> 0 OrElse InStr(ta2, "libfaad", CompareMethod.Text) <> 0 Then
                            EXV = "*.aac"
                        End If

                        Dim FileListBox1 As New ListBox
                        FileListBox1.Items.Clear()
                        FileListBox1.Items.AddRange(Directory.GetFiles(My.Application.Info.DirectoryPath & "\temp\caches", EXV, SearchOption.TopDirectoryOnly))
                        If FileListBox1.Items.Count = 0 Then
                            FileListBox1.Items.AddRange(Directory.GetFiles(My.Application.Info.DirectoryPath & "\temp\caches", EXV2, SearchOption.TopDirectoryOnly))
                        End If

                        FileListBox2.Items.Clear()
                        If FileListBox1.Items.Count > 0 Then
                            For FLBI = 1 To FileListBox1.Items.Count
                                If InStr(FileListBox1.Items(FLBI - 1), "cache(" & MainFrm.EncListListView.Items(index).SubItems(13).Text & ")") <> 0 Then
                                    FileListBox2.Items.Add(FileListBox1.Items(FLBI - 1))
                                End If
                            Next
                        End If

                        LvAudioList = Replace(LvAudioList, ta2, "")
                    End If

                    Application.DoEvents()
                Loop Until (ta2 = "")

                If FileListBox2.Items.Count > 0 Then

                    For i = 0 To FileListBox2.Items.Count - 1

                        '중단상태(X) 인덱스한 오디오 파일경로 저장
                        If INDEX_ProcessStopChk = False Then
                            MainFrm.EncListListView.Items(index).SubItems(17).Text = MainFrm.EncListListView.Items(index).SubItems(17).Text & Mid(FileListBox2.Items(i), InStrRev(FileListBox2.Items(i), "\") + 1) & " |"
                        End If

                        'd2a파일 생성되는 여부
                        Dim _DAExtensionV As String = ""
                        Dim _d2aV As Boolean = False
                        If My.Computer.FileSystem.FileExists(FileListBox2.Items(i)) = True Then
                            _DAExtensionV = My.Computer.FileSystem.GetFileInfo(FileListBox2.Items(i)).Extension
                        End If
                        If _DAExtensionV = ".mp1" OrElse _DAExtensionV = ".mp2" OrElse _DAExtensionV = ".mp3" OrElse _DAExtensionV = ".mpa" Then
                            _d2aV = True
                        Else
                            _d2aV = False
                        End If

                        If INDEX_ProcessStopChk = True Then
                            '중지된 상태, 삭제(클린업)
                            Try
                                If My.Computer.FileSystem.FileExists(FileListBox2.Items(i)) = True Then
                                    My.Computer.FileSystem.DeleteFile(FileListBox2.Items(i))
                                End If
                                If _d2aV = True Then
                                    If My.Computer.FileSystem.FileExists(FileListBox2.Items(i) & ".d2a") = True Then
                                        My.Computer.FileSystem.DeleteFile(FileListBox2.Items(i) & ".d2a")
                                    End If
                                End If
                            Catch ex As Exception
                            End Try
                        Else
                            MainFrm.CleanUpListBox.Items.Add(FileListBox2.Items(i)) '클린업
                            If _d2aV = True Then
                                MainFrm.CleanUpListBox.Items.Add(FileListBox2.Items(i) & ".d2a") '클린업
                            End If
                        End If

                    Next

                End If

                '-------------------------------

                If INDEX_ProcessStopChk = True Then
                    '중지된 상태, 삭제(클린업)
                    Try
                        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\temp\caches\cache(" & MainFrm.EncListListView.Items(index).SubItems(13).Text & ").d2v") = True Then
                            My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath & "\temp\caches\cache(" & MainFrm.EncListListView.Items(index).SubItems(13).Text & ").d2v")
                        End If
                    Catch ex As Exception
                    End Try

                    Exit Sub '중지됨//
                Else
                    MainFrm.CleanUpListBox.Items.Add(My.Application.Info.DirectoryPath & "\temp\caches\cache(" & MainFrm.EncListListView.Items(index).SubItems(13).Text & ").d2v") '클린업
                    MainFrm.EncListListView.Items(index).SubItems(16).Text = My.Computer.FileSystem.GetFileInfo(MainFrm.EncListListView.Items(index).SubItems(10).Text).LastWriteTime.Ticks.ToString
                End If

                '===========================

skip2:

                '비디오 존재 여부
                If (MainFrm.EncListListView.Items(index).SubItems(8).Text <> "None" AndAlso MainFrm.EncListListView.Items(index).SubItems(9).Text = "None") Then '비디오만 있는 경우

                    '오디오 부분 주석 처리
                    AVTextBoxV = Replace(AVTextBoxV, "A=#<audiosource>", "#A=#<audiosource>")
                    '비디오 부분
                    AVTextBoxV = Replace(AVTextBoxV, "V=MPEG2Source(", "MPEG2Source(")
                    '오디오 덥 부분 주석 처리
                    AVTextBoxV = Replace(AVTextBoxV, "AudioDub(V,A)", "#AudioDub(V,A)")
                    '증폭
                    AVTextBoxV = Replace(AVTextBoxV, "#<amplifydb>", "##<amplifydb>")
                    '이퀄라이저
                    AVTextBoxV = Replace(AVTextBoxV, "#<supereq>", "##<supereq>")

                End If

                '#<d2vsource>
                AVTextBoxV = Replace(AVTextBoxV, "#<d2vsource>", My.Application.Info.DirectoryPath & "\temp\caches\cache(" & MainFrm.EncListListView.Items(index).SubItems(13).Text & ").d2v")

                '===========================
                Dim DGIndexAudioStramPathV As String = ""
                '인덱스된 오디오 파일을 목록화
                Dim LvAudioList2 As String = MainFrm.EncListListView.Items(index).SubItems(17).Text
                Dim AudioComboBox As New ListBox
                AudioComboBox.Items.Clear()
                Do
                    ia2 = 1
                    iia2 = 1
                    ta2 = ""
                    If InStr(ia2, LvAudioList2, "", CompareMethod.Text) Then
                        iia2 = InStr(ia2, LvAudioList2, "", CompareMethod.Text)
                        If InStr(iia2, LvAudioList2, "|", CompareMethod.Text) Then
                            ia2 = InStr(iia2, LvAudioList2, "|", CompareMethod.Text)
                            ta2 = Mid(LvAudioList2, iia2, ia2 - iia2 - 1)
                        End If
                    Else
                        ia2 = ia2 + 1
                    End If

                    If ta2 <> "" Then
                        AudioComboBox.Items.Add(ta2)
                        LvAudioList2 = Replace(LvAudioList2, ta2 & " |", "")
                    End If

                    Application.DoEvents()
                Loop Until (ta2 = "")
                'HEX
                Dim AudioStreamHEXV = MainFrm.EncListListView.Items(index).SubItems(4).Text
                Try
                    AudioStreamHEXV = Split(Split(AudioStreamHEXV, "0x")(1), "]")(0)
                Catch ex As Exception
                    AudioStreamHEXV = ""
                End Try

                '오디오 스트림 선택
                For AudioStreamSelV = 1 To AudioComboBox.Items.Count


                    If MainFrm.EncListListView.Items(index).SubItems(3).Text = "MPEGTS" Then

                        DGIndexAudioStramPathV = My.Application.Info.DirectoryPath & "\temp\caches\" & AudioComboBox.Items(0)

                        '여러스트림 선택용. (PID 앞에 0이 더 붙는 경우가 있다.)
                        'If InStr(AudioComboBox.Items(AudioStreamSelV - 1), "cache(" & MainFrm.EncListListView.Items(index).SubItems(13).Text & ") PID " & AudioStreamHEXV & " ", CompareMethod.Text) <> 0 Then
                        '    DGIndexAudioStramPathV = My.Application.Info.DirectoryPath & "\temp\caches\" & AudioComboBox.Items(AudioStreamSelV - 1)
                        'End If


                    ElseIf MainFrm.EncListListView.Items(index).SubItems(3).Text = "MPEG" Then

                        If InStr(AudioComboBox.Items(AudioStreamSelV - 1), "cache(" & MainFrm.EncListListView.Items(index).SubItems(13).Text & ") T" & AudioStreamHEXV & " ", CompareMethod.Text) <> 0 Then
                            DGIndexAudioStramPathV = My.Application.Info.DirectoryPath & "\temp\caches\" & AudioComboBox.Items(AudioStreamSelV - 1)
                        End If

                    End If

                Next
                '===========================

                '#<delayaudio1>
                Dim delayaudioV As String = "0"
                If InStr(DGIndexAudioStramPathV, "delay", CompareMethod.Text) <> 0 Then
                    delayaudioV = Mid(DGIndexAudioStramPathV, InStr(DGIndexAudioStramPathV, "delay", CompareMethod.Text) + 5)
                    If InStr(delayaudioV, "ms") <> 0 Then
                        delayaudioV = LTrim(Strings.Left(delayaudioV, InStr(delayaudioV, "ms") - 1))
                    Else
                        delayaudioV = "0"
                    End If
                Else
                    delayaudioV = "0"
                End If
                '미디어 인포 비디오딜레이값 검사(MPEG/MPEGTS)
                Dim SN As Integer = 0
                If MainFrm.EncListListView.Items(index).SubItems(3).Text = "MPEG" Then '선택된 스트림 번호 가져오기// MPEG전용

                    'SN구하기 (스트림 ID비교)//
                    Dim AudioStramCntStr As String = "0"
                    AudioStramCntStr = _MI.Get_(StreamKind.Audio, 0, "StreamCount")
                    If AudioStramCntStr = "" OrElse AudioStramCntStr = "0" Then
                        GoTo DelayAudioSkip2
                    End If
                    Dim i2 As Integer
                    For i2 = 0 To AudioStramCntStr - 1
                        Dim ta2v2 As String = _MI.Get_(StreamKind.Audio, i2, "ID")
                        If ta2v2 <> "" Then
                            Dim ta3 As String = ""
                            Try
                                ta3 = UCase(Strings.Right(Split(Split(MainFrm.EncListListView.Items(index).SubItems(4).Text, "[0x")(1), "]")(0), 2))
                            Catch ex As Exception
                            End Try
                            Dim hex3 As String = Strings.Right(Hex(ta2v2), 2)
                            If ta3 = hex3 Then
                                SN = i2
                                Exit For
                            End If
                        End If
                    Next

                End If
                Dim ta2v3 As String = _MI.Get_(StreamKind.Audio, SN, "Video_Delay")
                If ta2v3 = "0" OrElse ta2v3 = "" Then
                    delayaudioV = 0
                End If
DelayAudioSkip2:
                AVTextBoxV = Replace(AVTextBoxV, "#<delayaudio1>", "DelayAudio(" & delayaudioV & "/1000.0)")

                '#<audiosource>
                Dim DAExtension2V As String = ""
                Dim DAExtensionV As String = ""
                If My.Computer.FileSystem.FileExists(DGIndexAudioStramPathV) = True Then
                    DAExtensionV = My.Computer.FileSystem.GetFileInfo(DGIndexAudioStramPathV).Extension
                End If
                If DAExtensionV = ".mp1" OrElse DAExtensionV = ".mp2" OrElse DAExtensionV = ".mp3" OrElse DAExtensionV = ".mpa" Then
                    DAExtension2V = "NicMPG123Source"

                ElseIf DAExtensionV = ".ac3" Then
                    DAExtension2V = "NicAC3Source"

                ElseIf DAExtensionV = ".wav" Then
                    DAExtension2V = "BassAudioSource"

                ElseIf DAExtensionV = ".lpcm" Then
                    DAExtension2V = "NicLPCMSource"

                ElseIf DAExtensionV = ".dts" Then
                    DAExtension2V = "NicDTSSource"

                ElseIf DAExtensionV = ".aac" Then
                    DAExtension2V = "BassAudioSource"

                End If
                If DAExtension2V = "NicMPG123Source" Then
                    AVTextBoxV = Replace(AVTextBoxV, "#<audiosource>", DAExtension2V & "(" & Chr(34) & DGIndexAudioStramPathV & Chr(34) & ",true)")
                Else
                    AVTextBoxV = Replace(AVTextBoxV, "#<audiosource>", DAExtension2V & "(" & Chr(34) & DGIndexAudioStramPathV & Chr(34) & ")")
                End If


                End If

                '------------------------------------------------------------------------------------------------------------------------
                '공통
                '-----------------------

                '#<pluginpath>
                AVTextBoxV = Replace(AVTextBoxV, "#<pluginpath>", My.Application.Info.DirectoryPath & "\plugin\")

                '#<toolspath>
                AVTextBoxV = Replace(AVTextBoxV, "#<toolspath>", My.Application.Info.DirectoryPath & "\tools\")

                '#<source>
                AVTextBoxV = Replace(AVTextBoxV, "#<source>", MainFrm.EncListListView.Items(index).SubItems(10).Text)

                '#<trim>
                If MainFrm.EncListListView.Items(index).SubItems(8).Text = "None" AndAlso _
                MainFrm.EncListListView.Items(index).SubItems(9).Text <> "None" Then '오디오 파일 AviSynth 인코딩// BassAudio 에서는 기본 프레임이 25
                    fpsV = 25
                End If
                Dim bobv As Integer = 1
                With ImagePPFrm
                    If InStr(AVTextBoxV, "#<deinterlace>", CompareMethod.Text) <> 0 Then
                        If .AVSMPEG2DeinterlaceCheckBox.Checked = True Then
                            If .AVSMPEG2DeinterlaceComboBox.Text = "Yadif mode=1 double framerate (bob)" OrElse .AVSMPEG2DeinterlaceComboBox.Text = "Yadif mode=3 double framerate (bob)" Then
                                If MainFrm.EncListListView.Items(index).SubItems(8).Text = "None" AndAlso _
                                MainFrm.EncListListView.Items(index).SubItems(9).Text <> "None" Then '오디오 파일 AviSynth 인코딩
                                Else
                                    bobv = 2
                                End If
                            End If
                        End If
                    End If
                End With
                If PlayHMSV = EndHMSV Then '파일의 시간과 종료시간이 같으면 종료부분은 0으로 처리.
                    AVTextBoxV = Replace(AVTextBoxV, "#<trim>", "Trim(" & Int(StartHMSV * fpsV * bobv) & ",0)")
                Else
                    AVTextBoxV = Replace(AVTextBoxV, "#<trim>", "Trim(" & Int(StartHMSV * fpsV * bobv) & "," & Int(EndHMSV * fpsV * bobv) & ")")
                End If

                '#<delayaudio2>
                '구간설정(Trim) 아래에 놓아야 함
                Dim ta2v4 As String = _MI.Get_(StreamKind.Audio, 0, "Video_Delay")
                If ta2v4 = "0" OrElse ta2v4 = "" Then
                    delayaudioV2 = 0
                Else
                    delayaudioV2 = ta2v4
                End If
                If Int(StartHMSV * fpsV * bobv) > (Val(delayaudioV2) / 1000) * fpsV * bobv Then
                    delayaudioV2 = 0
                End If
                AVTextBoxV = Replace(AVTextBoxV, "#<delayaudio2>", "DelayAudio(" & delayaudioV2 & "/1000.0)")

                '------------------------
                '영상
                '------------------------
                If MainFrm.EncListListView.Items(index).SubItems(8).Text = "None" AndAlso MainFrm.EncListListView.Items(index).SubItems(9).Text <> "None" Then '오디오만 있는 경우
                Else '아니면

                    '#<fps>
                    AVTextBoxV = Replace(AVTextBoxV, "#<fps>", fpsV)

                    '#<fpsnum>
                    AVTextBoxV = Replace(AVTextBoxV, "#<fpsnum>", fpsnumV)

                    '#<fpsden>
                    AVTextBoxV = Replace(AVTextBoxV, "#<fpsden>", fpsdenV)

                    '#<changefps>
                    AVTextBoxV = Replace(AVTextBoxV, "#<changefps>", changefpsV)

                    '#<image>
                    AVTextBoxV = Replace(AVTextBoxV, "#<image>", ImageV)

                    '#<coloryuv>
                    AVTextBoxV = Replace(AVTextBoxV, "#<coloryuv>", ColorYUVV)

                    '#<coloryuv_analyze>
                    AVTextBoxV = Replace(AVTextBoxV, "#<coloryuv_analyze>", ColorYUVASV)

                    '#<textsub>
                    AVTextBoxV = Replace(AVTextBoxV, "#<textsub>", TextSubV)

                    '#<sharpen>
                    AVTextBoxV = Replace(AVTextBoxV, "#<sharpen>", "Sharpen(" & ImagePPFrm.SharpenNumericUpDown.Value & ")")

                    '#<tweak>
                    AVTextBoxV = Replace(AVTextBoxV, "#<tweak>", "Tweak(" & ImagePPFrm.hueNumericUpDown.Value & "," & ImagePPFrm.saturationNumericUpDown.Value & "," & ImagePPFrm.brightnessNumericUpDown.Value & "," & ImagePPFrm.contrastNumericUpDown.Value & ")")

                    '#<crop>
                    Try
                        Dim LeftCV, TopCV, RightCV, BottomCV As Integer
                        LeftCV = Split(MainFrm.EncListListView.Items(index).SubItems(15).Text, ",")(0)
                        TopCV = Split(MainFrm.EncListListView.Items(index).SubItems(15).Text, ",")(1)
                        RightCV = Split(MainFrm.EncListListView.Items(index).SubItems(15).Text, ",")(2)
                        BottomCV = Split(MainFrm.EncListListView.Items(index).SubItems(15).Text, ",")(3)
                        If (LeftCV Mod 2) = 0 AndAlso (TopCV Mod 2) = 0 AndAlso (RightCV Mod 2) = 0 AndAlso (BottomCV Mod 2) = 0 Then
                            AVTextBoxV = Replace(AVTextBoxV, "#<crop>", "Crop(" & LeftCV & "," & TopCV & ",-" & RightCV & ",-" & BottomCV & ")")
                        Else
                            AVTextBoxV = Replace(AVTextBoxV, "#<crop>", "ConvertToRGB.Crop(" & LeftCV & "," & TopCV & ",-" & RightCV & ",-" & BottomCV & ")")
                        End If
                    Catch ex As Exception
                    End Try

                    '#<deinterlace>
                    AVTextBoxV = Replace(AVTextBoxV, "#<deinterlace>", DeinterlaceV)

                    '#<turn>
                    If ImagePPFrm.TurnCheckBox.Checked = True Then
                        If ImagePPFrm.TurnLeftRadioButton.Checked = True Then
                            AVTextBoxV = Replace(AVTextBoxV, "#<turn>", "TurnLeft()")
                        ElseIf ImagePPFrm.TurnRightRadioButton.Checked = True Then
                            AVTextBoxV = Replace(AVTextBoxV, "#<turn>", "TurnRight()")
                        ElseIf ImagePPFrm.Turn180RadioButton.Checked = True Then
                            AVTextBoxV = Replace(AVTextBoxV, "#<turn>", "Turn180()")
                        End If
                    End If

                End If

                '------------------------
                ' 음성
                '------------------------
                If MainFrm.EncListListView.Items(index).SubItems(8).Text <> "None" AndAlso MainFrm.EncListListView.Items(index).SubItems(9).Text = "None" Then '비디오만 있는 경우
                Else '아니면

                    '#<channel>
                    AVTextBoxV = Replace(AVTextBoxV, "#<channel>", ChannelV)

                    '#<amplifydb>
                    AVTextBoxV = Replace(AVTextBoxV, "#<amplifydb>", amplifydbV)

                    '#<supereq>
                    AVTextBoxV = Replace(AVTextBoxV, "#<supereq>", SuperEqV)

                    '#<ssrc>
                    AVTextBoxV = Replace(AVTextBoxV, "#<ssrc>", "SSRC(" & SSRCV & ")")

                    '#<normalize>
                    Dim normalizeV As String = "#<normalize>"
                    With AudioPPFrm
                        If .NormalizeCheckBox.Checked = True Then
                            normalizeV = "normalize(" & .NormalizeNumericUpDown.Value & ")"
                        End If
                    End With
                    AVTextBoxV = Replace(AVTextBoxV, "#<normalize>", normalizeV)

                    '#<audio_analyze>
                    Dim audio_analyzeV As String = "#<audio_analyze>"
                    If AudioPPFrm.AudioASCheckBox.Checked = True Then
                        audio_analyzeV = "Histogram(" & Chr(34) & "audiolevels" & Chr(34) & ")"
                    End If
                    AVTextBoxV = Replace(AVTextBoxV, "#<audio_analyze>", audio_analyzeV)

                End If

                '------------------------------------------------------------------------------------------------------------------------

                '------------------------
                ' 기타
                '------------------------
                '#<rate>
                If ETCPPFrm.RateCheckBox.Checked = True Then
                    Dim rateV As String = ""
                    If ETCPPFrm.RatePCheckBox.Checked = True Then '피치보정
                        rateV = "AssumeFPS(" & fpsV & " * " & ETCPPFrm.RateNumericUpDown.Value & ").TimeStretch(tempo=100 * " & ETCPPFrm.RateNumericUpDown.Value & ").ChangeFPS(" & fpsV & ")"
                    Else
                        rateV = "AssumeFPS(" & fpsV & " * " & ETCPPFrm.RateNumericUpDown.Value & ").TimeStretch(tempo=100 * " & ETCPPFrm.RateNumericUpDown.Value & ", pitch=100 * " & ETCPPFrm.RateNumericUpDown.Value & ").ChangeFPS(" & fpsV & ")"
                    End If
                    AVTextBoxV = Replace(AVTextBoxV, "#<rate>", rateV)
                End If



                '------------------------------------------------------------------------------------------------------------------------

                '====================================
                '채널스크립트 추가
                '------------------------------------
                '비디오, 오디오부분 존재 여부
                If MainFrm.EncListListView.Items(index).SubItems(8).Text <> "None" AndAlso MainFrm.EncListListView.Items(index).SubItems(9).Text = "None" Then '비디오만 있는 경우
                ElseIf MainFrm.EncListListView.Items(index).SubItems(8).Text = "None" AndAlso MainFrm.EncListListView.Items(index).SubItems(9).Text <> "None" Then '오디오만 있는 경우
                    AVTextBoxV = AVTextBoxV & vbNewLine & vbNewLine & CHTextBoxV
                ElseIf MainFrm.EncListListView.Items(index).SubItems(8).Text <> "None" AndAlso MainFrm.EncListListView.Items(index).SubItems(9).Text <> "None" Then '비디오 + 오디오
                    AVTextBoxV = AVTextBoxV & vbNewLine & vbNewLine & CHTextBoxV
                End If

                'ScriptTextBox 추가
                AviSynthEditorFrm.ScriptTextBox.Text = AVTextBoxV

                '------------------------------------------

                '저장
                Dim _StreamWriter2 As New StreamWriter(My.Application.Info.DirectoryPath & "\temp\AviSynthScript.avs", False, System.Text.Encoding.Default)
                If (InStr(EncSetFrm.OutFComboBox.SelectedItem, "[AUDIO]", CompareMethod.Text) <> 0) AndAlso ShowModeV = False AndAlso ShowStatus = True Then '오디오만 인코딩일경우 맨 마지막에 프레임 1로 설정..(인코딩할때만 추가되는 스크립트..)
                    _StreamWriter2.Write(AVTextBoxV & vbNewLine & "AssumeFPS(1)")
                Else
                    _StreamWriter2.Write(AVTextBoxV)
                End If
                _StreamWriter2.Close()

                '네로AAC 오디오용 저장
                If EncSetFrm.AudioCodecComboBox.Text = "Nero AAC" OrElse EncSetFrm.AudioCodecComboBox.Text = "[MP4] Nero AAC" Then
                    Dim _StreamWriter3 As New StreamWriter(My.Application.Info.DirectoryPath & "\temp\AviSynthScriptN.avs", False, System.Text.Encoding.Default)
                    _StreamWriter3.Write(AVTextBoxV & vbNewLine & "AssumeFPS(1)")
                    _StreamWriter3.Close()
                End If

                _MI.Close()
        Catch ex As Exception
            _MI.Close()
            Throw New Exception(ex.Message)
        End Try
        '/////////////////////////////////////////////////////////////////////////////////// 미디어 인포 _MI 변수 구간

    End Sub

End Class