﻿' ---------------------------------------------------------------------------------------
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

Public Class EncSetFrm

    Private Sub OutFComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OutFComboBox.SelectedIndexChanged

        If InStr(OutFComboBox.SelectedItem, "[AVI]", CompareMethod.Text) <> 0 Then

            '비디오->압축코덱
            VideoCodecComboBox.Items.Clear()
            VideoCodecComboBox.Items.Add("Xvid MPEG-4 Codec")
            VideoCodecComboBox.Items.Add("Xvid MPEG-4 Codec(Xvid Core)")
            VideoCodecComboBox.Items.Add("DivX 3 Codec")
            VideoCodecComboBox.Items.Add("DivX 4 Codec(Open Divx)")
            VideoCodecComboBox.Items.Add("DivX 5 Codec")
            VideoCodecComboBox.Items.Add("Microsoft MPEG-4 v2")
            VideoCodecComboBox.Items.Add("Microsoft MPEG-4 v3")
            VideoCodecComboBox.Items.Add("ITU-T H.263 Version 2(H.263+)")
            VideoCodecComboBox.Items.Add("H.264(AVC) x264 core")
            MP4OptsGroupBox.Visible = False 'MP4 옵션

            '오디오->압축코덱
            AudioCodecComboBox.Items.Clear()
            AudioCodecComboBox.Items.Add("MPEG-1 Audio layer 2(MP2)")
            AudioCodecComboBox.Items.Add("MPEG-1 Audio layer 3(MP3) Lame")
            AudioCodecComboBox.Items.Add("Dolby Digital Audio Coding-3(AC3)")
            AudioCodecComboBox.Items.Add("Windows Media Audio 1")
            AudioCodecComboBox.Items.Add("Windows Media Audio 2")

        ElseIf InStr(OutFComboBox.SelectedItem, "[3GP]", CompareMethod.Text) <> 0 Then

            '비디오->압축코덱
            VideoCodecComboBox.Items.Clear()
            VideoCodecComboBox.Items.Add("MPEG-4 Video")
            VideoCodecComboBox.Items.Add("Xvid MPEG-4 Codec(Xvid Core)")
            VideoCodecComboBox.Items.Add("ITU-T H.263")
            VideoCodecComboBox.Items.Add("H.264(AVC) x264 core")
            MP4OptsGroupBox.Visible = False 'MP4 옵션

            '오디오->압축코덱
            AudioCodecComboBox.Items.Clear()
            AudioCodecComboBox.Items.Add("FAAC")
            AudioCodecComboBox.Items.Add("Nero AAC")
            AudioCodecComboBox.Items.Add("AMR-NB(libopencore)")

        ElseIf InStr(OutFComboBox.SelectedItem, "[3G2]", CompareMethod.Text) <> 0 Then

            '비디오->압축코덱
            VideoCodecComboBox.Items.Clear()
            VideoCodecComboBox.Items.Add("MPEG-4 Video")
            VideoCodecComboBox.Items.Add("Xvid MPEG-4 Codec(Xvid Core)")
            VideoCodecComboBox.Items.Add("ITU-T H.263")
            VideoCodecComboBox.Items.Add("H.264(AVC) x264 core")
            MP4OptsGroupBox.Visible = False 'MP4 옵션

            '오디오->압축코덱
            AudioCodecComboBox.Items.Clear()
            AudioCodecComboBox.Items.Add("FAAC")
            AudioCodecComboBox.Items.Add("Nero AAC")
            AudioCodecComboBox.Items.Add("AMR-NB(libopencore)")

        ElseIf InStr(OutFComboBox.SelectedItem, "[MP4]", CompareMethod.Text) <> 0 Then

            '비디오->압축코덱
            VideoCodecComboBox.Items.Clear()
            VideoCodecComboBox.Items.Add("MPEG-4 Video")
            VideoCodecComboBox.Items.Add("Xvid MPEG-4 Codec(Xvid Core)")
            VideoCodecComboBox.Items.Add("H.264(AVC) x264 core")
            MP4OptsGroupBox.Visible = True 'MP4 옵션

            '오디오->압축코덱
            AudioCodecComboBox.Items.Clear()
            AudioCodecComboBox.Items.Add("MPEG-1 Audio layer 2(MP2)")
            AudioCodecComboBox.Items.Add("MPEG-1 Audio layer 3(MP3) Lame")
            AudioCodecComboBox.Items.Add("FAAC")
            AudioCodecComboBox.Items.Add("Nero AAC")
            AudioCodecComboBox.Items.Add("Vorbis")

        ElseIf InStr(OutFComboBox.SelectedItem, "[MOV]", CompareMethod.Text) <> 0 Then

            '비디오->압축코덱
            VideoCodecComboBox.Items.Clear()
            VideoCodecComboBox.Items.Add("MPEG-4 Video")
            VideoCodecComboBox.Items.Add("Xvid MPEG-4 Codec(Xvid Core)")
            VideoCodecComboBox.Items.Add("ITU-T H.261")
            VideoCodecComboBox.Items.Add("ITU-T H.263")
            VideoCodecComboBox.Items.Add("H.264(AVC) x264 core")
            MP4OptsGroupBox.Visible = False 'MP4 옵션

            '오디오->압축코덱
            AudioCodecComboBox.Items.Clear()
            AudioCodecComboBox.Items.Add("MPEG-1 Audio layer 3(MP3) Lame")
            AudioCodecComboBox.Items.Add("FAAC")
            AudioCodecComboBox.Items.Add("Nero AAC")
            AudioCodecComboBox.Items.Add("AMR-NB(libopencore)")
            AudioCodecComboBox.Items.Add("Free Lossless Audio Codec(FLAC)")

        ElseIf InStr(OutFComboBox.SelectedItem, "[MKV]", CompareMethod.Text) <> 0 Then

            '비디오->압축코덱
            VideoCodecComboBox.Items.Clear()
            VideoCodecComboBox.Items.Add("Xvid MPEG-4 Codec")
            VideoCodecComboBox.Items.Add("Xvid MPEG-4 Codec(Xvid Core)")
            VideoCodecComboBox.Items.Add("DivX 4 Codec(Open Divx)")
            VideoCodecComboBox.Items.Add("DivX 5 Codec")
            VideoCodecComboBox.Items.Add("Microsoft MPEG-4 v2")
            VideoCodecComboBox.Items.Add("ITU-T H.263 Version 2(H.263+)")
            VideoCodecComboBox.Items.Add("H.264(AVC) x264 core")
            VideoCodecComboBox.Items.Add("Theora Video Codec")
            VideoCodecComboBox.Items.Add("VP8 Codec(libvpx)")
            VideoCodecComboBox.Items.Add("Windows Media Video 7")
            VideoCodecComboBox.Items.Add("Windows Media Video 8")
            VideoCodecComboBox.Items.Add("Huffyuv Lossless Video Codec")
            MP4OptsGroupBox.Visible = False 'MP4 옵션

            '오디오->압축코덱
            AudioCodecComboBox.Items.Clear()
            AudioCodecComboBox.Items.Add("MPEG-1 Audio layer 2(MP2)")
            AudioCodecComboBox.Items.Add("MPEG-1 Audio layer 3(MP3) Lame")
            AudioCodecComboBox.Items.Add("FAAC")
            AudioCodecComboBox.Items.Add("Nero AAC")
            AudioCodecComboBox.Items.Add("Dolby Digital Audio Coding-3(AC3)")
            AudioCodecComboBox.Items.Add("Vorbis")
            AudioCodecComboBox.Items.Add("Windows Media Audio 1")
            AudioCodecComboBox.Items.Add("Windows Media Audio 2")
            AudioCodecComboBox.Items.Add("Free Lossless Audio Codec(FLAC)")

        ElseIf InStr(OutFComboBox.SelectedItem, "[ASF]", CompareMethod.Text) <> 0 Then

            '비디오->압축코덱
            VideoCodecComboBox.Items.Clear()
            VideoCodecComboBox.Items.Add("Microsoft MPEG-4 v2")
            VideoCodecComboBox.Items.Add("Microsoft MPEG-4 v3")
            MP4OptsGroupBox.Visible = False 'MP4 옵션

            '오디오->압축코덱
            AudioCodecComboBox.Items.Clear()
            AudioCodecComboBox.Items.Add("Windows Media Audio 1")
            AudioCodecComboBox.Items.Add("Windows Media Audio 2")

        ElseIf InStr(OutFComboBox.SelectedItem, "[WMV]", CompareMethod.Text) <> 0 Then

            '비디오->압축코덱
            VideoCodecComboBox.Items.Clear()
            VideoCodecComboBox.Items.Add("Windows Media Video 7")
            VideoCodecComboBox.Items.Add("Windows Media Video 8")
            MP4OptsGroupBox.Visible = False 'MP4 옵션

            '오디오->압축코덱
            AudioCodecComboBox.Items.Clear()
            AudioCodecComboBox.Items.Add("Windows Media Audio 1")
            AudioCodecComboBox.Items.Add("Windows Media Audio 2")

        ElseIf InStr(OutFComboBox.SelectedItem, "[RM]", CompareMethod.Text) <> 0 Then

            '비디오->압축코덱
            VideoCodecComboBox.Items.Clear()
            VideoCodecComboBox.Items.Add("RealVideo 1.0")
            VideoCodecComboBox.Items.Add("RealVideo G2")
            MP4OptsGroupBox.Visible = False 'MP4 옵션

            '오디오->압축코덱
            AudioCodecComboBox.Items.Clear()
            AudioCodecComboBox.Items.Add("Dolby Digital Audio Coding-3(AC3)")

        ElseIf InStr(OutFComboBox.SelectedItem, "[MPEG]", CompareMethod.Text) <> 0 Then

            '비디오->압축코덱
            VideoCodecComboBox.Items.Clear()
            VideoCodecComboBox.Items.Add("MPEG-1 Video")
            VideoCodecComboBox.Items.Add("MPEG-2 Video")
            MP4OptsGroupBox.Visible = False 'MP4 옵션

            '오디오->압축코덱
            AudioCodecComboBox.Items.Clear()
            AudioCodecComboBox.Items.Add("MPEG-1 Audio layer 2(MP2)")
            AudioCodecComboBox.Items.Add("MPEG-1 Audio layer 3(MP3) Lame")

        ElseIf InStr(OutFComboBox.SelectedItem, "[FLV]", CompareMethod.Text) <> 0 Then

            '비디오->압축코덱
            VideoCodecComboBox.Items.Clear()
            VideoCodecComboBox.Items.Add("Sorenson H.263")
            VideoCodecComboBox.Items.Add("H.264(AVC) x264 core")
            MP4OptsGroupBox.Visible = False 'MP4 옵션

            '오디오->압축코덱
            AudioCodecComboBox.Items.Clear()
            AudioCodecComboBox.Items.Add("MPEG-1 Audio layer 3(MP3) Lame")
            AudioCodecComboBox.Items.Add("FAAC")
            AudioCodecComboBox.Items.Add("Nero AAC")

        ElseIf InStr(OutFComboBox.SelectedItem, "[SWF]", CompareMethod.Text) <> 0 Then

            '비디오->압축코덱
            VideoCodecComboBox.Items.Clear()
            VideoCodecComboBox.Items.Add("Sorenson H.263")
            MP4OptsGroupBox.Visible = False 'MP4 옵션

            '오디오->압축코덱
            AudioCodecComboBox.Items.Clear()
            AudioCodecComboBox.Items.Add("MPEG-1 Audio layer 3(MP3) Lame")

        ElseIf InStr(OutFComboBox.SelectedItem, "[WEBM]", CompareMethod.Text) <> 0 Then

            '비디오->압축코덱
            VideoCodecComboBox.Items.Clear()
            VideoCodecComboBox.Items.Add("VP8 Codec(libvpx)")
            MP4OptsGroupBox.Visible = False 'MP4 옵션

            '오디오->압축코덱
            AudioCodecComboBox.Items.Clear()
            AudioCodecComboBox.Items.Add("Vorbis")

        ElseIf InStr(OutFComboBox.SelectedItem, "[AUDIO]", CompareMethod.Text) <> 0 Then

            '비디오->압축코덱
            VideoCodecComboBox.Items.Clear()
            VideoCodecComboBox.Items.Add("No video")
            MP4OptsGroupBox.Visible = False 'MP4 옵션

            '오디오->압축코덱
            AudioCodecComboBox.Items.Clear()
            AudioCodecComboBox.Items.Add("[MP2] MPEG-1 Audio layer 2(MP2)")
            AudioCodecComboBox.Items.Add("[MP3] MPEG-1 Audio layer 3(MP3) Lame")
            AudioCodecComboBox.Items.Add("[MP4] FAAC")
            AudioCodecComboBox.Items.Add("[M4A] FAAC")
            AudioCodecComboBox.Items.Add("[MP4] Nero AAC")
            AudioCodecComboBox.Items.Add("[AMR] AMR-NB(libopencore)")
            AudioCodecComboBox.Items.Add("[AC3] Dolby Digital Audio Coding-3(AC3)")
            AudioCodecComboBox.Items.Add("[OGG] Vorbis")
            AudioCodecComboBox.Items.Add("[WMA] Windows Media Audio 1")
            AudioCodecComboBox.Items.Add("[WMA] Windows Media Audio 2")
            AudioCodecComboBox.Items.Add("[FLAC] Free Lossless Audio Codec(FLAC)")
            AudioCodecComboBox.Items.Add("[WAV] signed 16-bit little-endian PCM")

        End If

        '비디오->압축코덱 선택X -> 0번째선택
        If VideoCodecComboBox.SelectedIndex = -1 Then
            If VideoCodecComboBox.Items.Count > 0 Then
                VideoCodecComboBox.SelectedIndex = 0
            End If
        End If

        '오디오->압축코덱 선택X -> 0번째선택
        If AudioCodecComboBox.SelectedIndex = -1 Then
            If AudioCodecComboBox.Items.Count > 0 Then
                AudioCodecComboBox.SelectedIndex = 0
            End If
        End If

        '오디오만 인코딩
        If InStr(OutFComboBox.SelectedItem, "[AUDIO]", CompareMethod.Text) <> 0 Then
            '일반
            VideoTabPage.Enabled = False
            ImageTabPage.Enabled = False
            AudioTabPage.Enabled = True
            ETCTabPage.Enabled = True
        Else
            '일반
            VideoTabPage.Enabled = True
            ImageTabPage.Enabled = True
            AudioTabPage.Enabled = True
            ETCTabPage.Enabled = True
        End If


    End Sub

    Private Sub VideoCodecComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VideoCodecComboBox.SelectedIndexChanged

        '압축코덱->모드
        If InStr(VideoCodecComboBox.SelectedItem, "H.264(AVC) x264 core", CompareMethod.Text) <> 0 Then
            VideoModeComboBox.Items.Clear()
            VideoModeComboBox.Items.Add("[1PASS-CBR] " & LangCls.EncSetCBRVideoModeComboBox)
            VideoModeComboBox.Items.Add("[1PASS-CQP] " & LangCls.EncSetCQPVideoModeComboBox)
            VideoModeComboBox.Items.Add("[1PASS-CRF] " & LangCls.EncSetCRFVideoModeComboBox)
            VideoModeComboBox.Items.Add("[2PASS-CBR] " & LangCls.EncSetCBR2VideoModeComboBox)
            VideoModeComboBox.SelectedIndex = 0
        ElseIf InStr(VideoCodecComboBox.SelectedItem, "Theora Video Codec", CompareMethod.Text) <> 0 Then
            VideoModeComboBox.Items.Clear()
            VideoModeComboBox.Items.Add("[1PASS-CBR] " & LangCls.EncSetCBRVideoModeComboBox)
            VideoModeComboBox.Items.Add("[2PASS-CBR] " & LangCls.EncSetCBR2VideoModeComboBox)
            VideoModeComboBox.SelectedIndex = 0
        ElseIf InStr(VideoCodecComboBox.SelectedItem, "VP8 Codec(libvpx)", CompareMethod.Text) <> 0 Then
            VideoModeComboBox.Items.Clear()
            VideoModeComboBox.Items.Add("[1PASS-CBR] " & LangCls.EncSetCBRVideoModeComboBox)
            VideoModeComboBox.Items.Add("[2PASS-CBR] " & LangCls.EncSetCBR2VideoModeComboBox)
            VideoModeComboBox.SelectedIndex = 0
        ElseIf InStr(VideoCodecComboBox.SelectedItem, "Huffyuv Lossless Video Codec", CompareMethod.Text) <> 0 Then
            VideoModeComboBox.Items.Clear()
            VideoModeComboBox.Items.Add("[LOSSLESS]")
            VideoModeComboBox.SelectedIndex = 0
        Else
            VideoModeComboBox.Items.Clear()
            VideoModeComboBox.Items.Add("[1PASS-CBR] " & LangCls.EncSetCBRVideoModeComboBox)
            VideoModeComboBox.Items.Add("[1PASS-VBR] " & LangCls.EncSetVBRVideoModeComboBox)
            VideoModeComboBox.Items.Add("[2PASS-CBR] " & LangCls.EncSetCBR2VideoModeComboBox)
            VideoModeComboBox.SelectedIndex = 0
        End If

        '고급모드
        If VideoCodecComboBox.Text = "H.264(AVC) x264 core" OrElse _
            VideoCodecComboBox.Text = "Xvid MPEG-4 Codec" OrElse _
            VideoCodecComboBox.Text = "DivX 4 Codec(Open Divx)" OrElse _
             VideoCodecComboBox.Text = "DivX 5 Codec" OrElse _
             VideoCodecComboBox.Text = "MPEG-4 Video" Then
            AdvanOptsPanel.Enabled = True
        Else
            AdvanOptsPanel.Enabled = False
        End If

    End Sub

    Private Sub VideoModeComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VideoModeComboBox.SelectedIndexChanged

        '모드->비트레이트, 퀀타이저, 퀄리티
        If InStr(VideoModeComboBox.SelectedItem, "[1PASS-CBR]", CompareMethod.Text) <> 0 Then
            BitrateLabel.Enabled = True
            BitrateComboBox.Enabled = True
            BitrateLabel2.Enabled = True
            QuantizerLabel.Enabled = False
            QuantizerTrackBar.Enabled = False
            QuantizerNumericUpDown.Enabled = False
            QuantizerCQPLabel.Enabled = False
            QuantizerCQPTrackBar.Enabled = False
            QuantizerCQPNumericUpDown.Enabled = False
            QualityLabel.Enabled = False
            QualityTrackBar.Enabled = False
            QualityNumericUpDown.Enabled = False
        ElseIf InStr(VideoModeComboBox.SelectedItem, "[1PASS-VBR]", CompareMethod.Text) <> 0 Then
            BitrateLabel.Enabled = False
            BitrateComboBox.Enabled = False
            BitrateLabel2.Enabled = False
            QuantizerLabel.Enabled = True
            QuantizerTrackBar.Enabled = True
            QuantizerNumericUpDown.Enabled = True
            QuantizerCQPLabel.Enabled = False
            QuantizerCQPTrackBar.Enabled = False
            QuantizerCQPNumericUpDown.Enabled = False
            QualityLabel.Enabled = False
            QualityTrackBar.Enabled = False
            QualityNumericUpDown.Enabled = False
        ElseIf InStr(VideoModeComboBox.SelectedItem, "[1PASS-CQP]", CompareMethod.Text) <> 0 Then
            BitrateLabel.Enabled = False
            BitrateComboBox.Enabled = False
            BitrateLabel2.Enabled = False
            QuantizerLabel.Enabled = False
            QuantizerTrackBar.Enabled = False
            QuantizerNumericUpDown.Enabled = False
            QuantizerCQPLabel.Enabled = True
            QuantizerCQPTrackBar.Enabled = True
            QuantizerCQPNumericUpDown.Enabled = True
            QualityLabel.Enabled = False
            QualityTrackBar.Enabled = False
            QualityNumericUpDown.Enabled = False
        ElseIf InStr(VideoModeComboBox.SelectedItem, "[1PASS-CRF]", CompareMethod.Text) <> 0 Then
            BitrateLabel.Enabled = False
            BitrateComboBox.Enabled = False
            BitrateLabel2.Enabled = False
            QuantizerLabel.Enabled = False
            QuantizerTrackBar.Enabled = False
            QuantizerNumericUpDown.Enabled = False
            QuantizerCQPLabel.Enabled = False
            QuantizerCQPTrackBar.Enabled = False
            QuantizerCQPNumericUpDown.Enabled = False
            QualityLabel.Enabled = True
            QualityTrackBar.Enabled = True
            QualityNumericUpDown.Enabled = True
        ElseIf InStr(VideoModeComboBox.SelectedItem, "[2PASS-CBR]", CompareMethod.Text) <> 0 Then
            BitrateLabel.Enabled = True
            BitrateComboBox.Enabled = True
            BitrateLabel2.Enabled = True
            QuantizerLabel.Enabled = False
            QuantizerTrackBar.Enabled = False
            QuantizerNumericUpDown.Enabled = False
            QuantizerCQPLabel.Enabled = False
            QuantizerCQPTrackBar.Enabled = False
            QuantizerCQPNumericUpDown.Enabled = False
            QualityLabel.Enabled = False
            QualityTrackBar.Enabled = False
            QualityNumericUpDown.Enabled = False
        ElseIf InStr(VideoModeComboBox.SelectedItem, "[LOSSLESS]", CompareMethod.Text) <> 0 Then
            BitrateLabel.Enabled = False
            BitrateComboBox.Enabled = False
            BitrateLabel2.Enabled = False
            QuantizerLabel.Enabled = False
            QuantizerTrackBar.Enabled = False
            QuantizerNumericUpDown.Enabled = False
            QuantizerCQPLabel.Enabled = False
            QuantizerCQPTrackBar.Enabled = False
            QuantizerCQPNumericUpDown.Enabled = False
            QualityLabel.Enabled = False
            QualityTrackBar.Enabled = False
            QualityNumericUpDown.Enabled = False
        End If

    End Sub

    Private Sub FramerateCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FramerateCheckBox.CheckedChanged

        If FramerateCheckBox.Checked = True Then
            FramerateLabel.Enabled = False
            FramerateComboBox.Enabled = False
            FramerateLabel2.Enabled = False
        Else
            FramerateLabel.Enabled = True
            FramerateComboBox.Enabled = True
            FramerateLabel2.Enabled = True
        End If

    End Sub

    Private Sub EncSetFrm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        XML_LOAD(My.Application.Info.DirectoryPath & "\settings.xml")
        GETFFCMD()
    End Sub

    Public Sub EncSetFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
                    EncSetPanel.Font = New Font(FNXP, FS)
                Else
                    EncSetPanel.Font = New Font(FN, FS)
                End If

                If XTR.Name = "OKBTN" Then OKBTN.Text = XTR.ReadString
                If XTR.Name = "CancelBTN" Then CancelBTN.Text = XTR.ReadString
                If XTR.Name = "DefBTN" Then DefBTN.Text = XTR.ReadString

                If XTR.Name = "EncSetFrm" Then Me.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmOutFGroupBox" Then OutFGroupBox.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmPresetButton" Then PresetButton.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmVideoTabPage" Then VideoTabPage.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmImageTabPage" Then ImageTabPage.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmAudioTabPage" Then AudioTabPage.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmETCTabPage" Then ETCTabPage.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmVideoGroupBox" Then VideoGroupBox.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmVCodecLabel" Then VCodecLabel.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmBitrateLabel" Then BitrateLabel.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmQuantizerLabel" Then QuantizerLabel.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmQuantizerCQPLabel" Then QuantizerCQPLabel.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmQualityLabel" Then QualityLabel.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmFramerateLabel" Then FramerateLabel.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmFramerateCheckBox" Then FramerateCheckBox.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmAdvanOptsLabel" Then AdvanOptsLabel.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmAdvanOptsButton" Then AdvanOptsButton.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmAdvanOptsCheckBox" Then AdvanOptsCheckBox.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmKeyFrameGroupBox" Then KeyFrameGroupBox.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmGOPSizeCheckBox" Then GOPSizeCheckBox.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmMP4OptsGroupBox" Then MP4OptsGroupBox.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmPSPMP4CheckBox" Then PSPMP4CheckBox.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmImageSizeLabel" Then ImageSizeLabel.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmImageSizeCheckBox" Then ImageSizeCheckBox.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmFFmpegResizeFilterLabel" Then FFmpegResizeFilterLabel.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmAspectLabel" Then AspectLabel.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmImgTabPage" Then ImgTabPage.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmImgPPTabPage" Then ImgPPTabPage.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmFFmpegImageUnsharpLabel" Then FFmpegImageUnsharpLabel.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmFFmpegImageUnsharpCheckBox" Then FFmpegImageUnsharpCheckBox.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmAudioGroupBox" Then AudioGroupBox.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmACodecLabel" Then ACodecLabel.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmAudioBitrateLabel" Then AudioBitrateLabel.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmFFmpegChLabel" Then FFmpegChLabel.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmSamplerateLabel" Then SamplerateLabel.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmSamplerateCheckBox" Then SamplerateCheckBox.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmAudioVolLabel" Then AudioVolLabel.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmAudioVolButton" Then AudioVolButton.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmAudioVolNLabel" Then AudioVolNLabel.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmNeroAACProfileLabel" Then NeroAACProfileLabel.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmNeroAACSALabel" Then NeroAACSALabel.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmNeroAACBitrateLabel" Then NeroAACBitrateLabel.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmNeroAACQLabel" Then NeroAACQLabel.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmAMRBitrateLabel" Then AMRBitrateLabel.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmNameGroupBox" Then NameGroupBox.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmHeaderLabel" Then HeaderLabel.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmExtensionLabel" Then ExtensionLabel.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmNameALabel" Then NameALabel.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmSizeLimitGroupBox" Then SizeLimitGroupBox.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmSizeLimitLabel" Then SizeLimitLabel.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmSizeLimitCheckBox" Then SizeLimitCheckBox.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmDeinterlaceCheckBox" Then DeinterlaceCheckBox.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmFFmpegCommandGroupBox" Then FFmpegCommandGroupBox.Text = XTR.ReadString
                If XTR.Name = "EncSetFrmFFmpegCommandButton" Then FFmpegCommandButton.Text = XTR.ReadString
                If XTR.Name = "EncSetCBRVideoModeComboBox" Then LangCls.EncSetCBRVideoModeComboBox = XTR.ReadString
                If XTR.Name = "EncSetVBRVideoModeComboBox" Then LangCls.EncSetVBRVideoModeComboBox = XTR.ReadString
                If XTR.Name = "EncSetCQPVideoModeComboBox" Then LangCls.EncSetCQPVideoModeComboBox = XTR.ReadString
                If XTR.Name = "EncSetCRFVideoModeComboBox" Then LangCls.EncSetCRFVideoModeComboBox = XTR.ReadString
                If XTR.Name = "EncSetCBR2VideoModeComboBox" Then LangCls.EncSetCBR2VideoModeComboBox = XTR.ReadString
                If XTR.Name = "EncSetUserInputComboBox" Then LangCls.EncSetUserInputComboBox = XTR.ReadString
                If XTR.Name = "EncSetNoKeepAspectComboBox" Then LangCls.EncSetNoKeepAspectComboBox = XTR.ReadString
                If XTR.Name = "EncSetLetterBoxAspectComboBox" Then LangCls.EncSetLetterBoxAspectComboBox = XTR.ReadString
                If XTR.Name = "EncSetCropAspectComboBox" Then LangCls.EncSetCropAspectComboBox = XTR.ReadString
                If XTR.Name = "EncSetOutputAspectComboBox2" Then LangCls.EncSetOutputAspectComboBox2 = XTR.ReadString
                If XTR.Name = "EncSetOriginalAspectComboBox2" Then LangCls.EncSetOriginalAspectComboBox2 = XTR.ReadString
                If XTR.Name = "EncSet43AspectComboBox2" Then LangCls.EncSet43AspectComboBox2 = XTR.ReadString
                If XTR.Name = "EncSet169AspectComboBox2" Then LangCls.EncSet169AspectComboBox2 = XTR.ReadString
                If XTR.Name = "EncSet1851AspectComboBox2" Then LangCls.EncSet1851AspectComboBox2 = XTR.ReadString
                If XTR.Name = "EncSet2351AspectComboBox2" Then LangCls.EncSet2351AspectComboBox2 = XTR.ReadString
                If XTR.Name = "EncSetchoriginComboBox" Then LangCls.EncSetchoriginComboBox = XTR.ReadString
                If XTR.Name = "EncSetch10ComboBox" Then LangCls.EncSetch10ComboBox = XTR.ReadString
                If XTR.Name = "EncSetch20ComboBox" Then LangCls.EncSetch20ComboBox = XTR.ReadString
                If XTR.Name = "EncSetch51ComboBox" Then LangCls.EncSetch51ComboBox = XTR.ReadString
                If XTR.Name = "EncSetNeroAACBP" Then LangCls.EncSetNeroAACBP = XTR.ReadString
                If XTR.Name = "EncSetFLACBP" Then LangCls.EncSetFLACBP = XTR.ReadString
                If XTR.Name = "EncSetPCMBP" Then LangCls.EncSetPCMBP = XTR.ReadString
                If XTR.Name = "EncSetCharERR" Then LangCls.EncSetCharERR = XTR.ReadString

            Loop
        Catch ex As Exception
            MsgBox("LANG_LOAD_ERROR :" & ex.Message)
        Finally
            XTR.Close()
        End Try
LANG_SKIP:
        '=========================================

        '영상(Image)부분 초기화
        ImageSizeComboBox.Items.Clear()
        ImageSizeComboBox.Items.AddRange(New Object() {"160 x 120", "176 x 144 - QCIF", "240 x 180", "320 x 180", "320 x 240 - QVGA", "400 x 240 - WQVGA", "400 x 300", "480 x 272", "480 x 360", "640 x 360 - 16:9", "640 x 480", "800 x 600", "960 x 540", "1280 x 720 - HD 720", "1920 x 1080 - HD 1080"})
        ImageSizeComboBox.Items.Add(LangCls.EncSetUserInputComboBox)

        FFmpegResizeFilterComboBox.Items.Clear()
        FFmpegResizeFilterComboBox.Items.Add("Fast_Bilinear")
        FFmpegResizeFilterComboBox.Items.Add("Bilinear")
        FFmpegResizeFilterComboBox.Items.Add("Bicubic")
        FFmpegResizeFilterComboBox.Items.Add("Experimental")
        FFmpegResizeFilterComboBox.Items.Add("Neighbor")
        FFmpegResizeFilterComboBox.Items.Add("Area")
        FFmpegResizeFilterComboBox.Items.Add("Bicublin")
        FFmpegResizeFilterComboBox.Items.Add("Gauss")
        FFmpegResizeFilterComboBox.Items.Add("Sinc")
        FFmpegResizeFilterComboBox.Items.Add("Lanczos")
        FFmpegResizeFilterComboBox.Items.Add("Spline")

        AspectComboBox.Items.Clear()
        AspectComboBox.Items.Add(LangCls.EncSetNoKeepAspectComboBox)
        AspectComboBox.Items.Add(LangCls.EncSetLetterBoxAspectComboBox)
        AspectComboBox.Items.Add(LangCls.EncSetCropAspectComboBox)

        AspectComboBox2.Items.Clear()
        AspectComboBox2.Items.Add(LangCls.EncSetOutputAspectComboBox2)
        AspectComboBox2.Items.Add(LangCls.EncSetOriginalAspectComboBox2)
        AspectComboBox2.Items.Add(LangCls.EncSet43AspectComboBox2)
        AspectComboBox2.Items.Add(LangCls.EncSet169AspectComboBox2)
        AspectComboBox2.Items.Add(LangCls.EncSet1851AspectComboBox2)
        AspectComboBox2.Items.Add(LangCls.EncSet2351AspectComboBox2)
        AspectComboBox2.Items.Add(LangCls.EncSetUserInputComboBox)

        FFmpegChComboBox.Items.Clear()
        FFmpegChComboBox.Items.Add(LangCls.EncSetchoriginComboBox)
        FFmpegChComboBox.Items.Add(LangCls.EncSetch10ComboBox)
        FFmpegChComboBox.Items.Add(LangCls.EncSetch20ComboBox)
        FFmpegChComboBox.Items.Add(LangCls.EncSetch51ComboBox)

        '------------------------

        '언어관련
        OutFComboBox.SelectedIndex = -1
        XML_LOAD(My.Application.Info.DirectoryPath & "\settings.xml")

        'AviSynth
        If MainFrm.AVSCheckBox.Checked = True Then
            FramerateLabel.Visible = False
            FramerateComboBox.Visible = False
            FramerateCheckBox.Visible = False
            FramerateLabel2.Visible = False
            VideoGroupBox.Height = 245
            KeyFrameGroupBox.Top = 263
            MP4OptsGroupBox.Top = 377

            FFmpegChComboBox.Visible = False
            FFmpegChLabel.Visible = False
            AudioGroupBox.Height = 120
            NeroAACGroupBox.Top = 135

            If ImageTabControl.TabCount = 2 Then
                ImageTabControl.TabPages.Remove(ImgTabPage)
                ImageTabControl.TabPages.Remove(ImgPPTabPage)
                ImageTabControl.TabPages.Add(ImgPPTabPage)
            End If

        Else
            FramerateLabel.Visible = True
            FramerateComboBox.Visible = True
            FramerateCheckBox.Visible = True
            FramerateLabel2.Visible = True
            VideoGroupBox.Height = 282
            KeyFrameGroupBox.Top = 297
            MP4OptsGroupBox.Top = 408

            FFmpegChComboBox.Visible = True
            FFmpegChLabel.Visible = True
            AudioGroupBox.Height = 206
            NeroAACGroupBox.Top = 224

            If ImageTabControl.TabCount = 1 Then
                ImageTabControl.TabPages.Remove(ImgTabPage)
                ImageTabControl.TabPages.Remove(ImgPPTabPage)
                ImageTabControl.TabPages.Add(ImgTabPage)
                ImageTabControl.TabPages.Add(ImgPPTabPage)
            End If

        End If

    End Sub

    Private Sub QuantizerNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles QuantizerNumericUpDown.LostFocus
        QuantizerNumericUpDown.Text = QuantizerNumericUpDown.Value
    End Sub

    Private Sub QuantizerNumericUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuantizerNumericUpDown.ValueChanged
        QuantizerTrackBar.Value = QuantizerNumericUpDown.Value * 10
    End Sub

    Private Sub QuantizerTrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuantizerTrackBar.Scroll
        QuantizerNumericUpDown.Value = QuantizerTrackBar.Value / 10
    End Sub

    Private Sub QuantizerCQPNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles QuantizerCQPNumericUpDown.LostFocus
        QuantizerCQPNumericUpDown.Text = QuantizerCQPNumericUpDown.Value
    End Sub

    Private Sub QuantizerCQPNumericUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuantizerCQPNumericUpDown.ValueChanged
        QuantizerCQPTrackBar.Value = QuantizerCQPNumericUpDown.Value
    End Sub

    Private Sub QuantizerCQPTrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuantizerCQPTrackBar.Scroll
        QuantizerCQPNumericUpDown.Value = QuantizerCQPTrackBar.Value
    End Sub

    Private Sub QualityNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles QualityNumericUpDown.LostFocus
        QualityNumericUpDown.Text = QualityNumericUpDown.Value
    End Sub

    Private Sub QualityNumericUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QualityNumericUpDown.ValueChanged
        QualityTrackBar.Value = QualityNumericUpDown.Value * 10
    End Sub

    Private Sub QualityTrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QualityTrackBar.Scroll
        QualityNumericUpDown.Value = QualityTrackBar.Value / 10
    End Sub

    Private Sub DefBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefBTN.Click

        '설정 기본값
        OutFComboBox.SelectedIndex = OutFComboBox.FindString("[AVI]", -1)
        '비디오
        VideoCodecComboBox.Text = "Xvid MPEG-4 Codec"
        VideoModeComboBox.SelectedIndex = VideoModeComboBox.FindString("[1PASS-CBR]", -1)
        BitrateComboBox.Text = "700"
        QuantizerNumericUpDown.Value = 2.5
        QuantizerCQPNumericUpDown.Value = 26
        QualityNumericUpDown.Value = 26.0
        FramerateComboBox.Text = "23.976"
        FramerateCheckBox.Checked = False
        AdvanOptsCheckBox.Checked = False
        GOPSizeCheckBox.Checked = False
        GOPSizeTextBox.Text = "250"
        MinGOPSizeTextBox.Text = "25"
        PSPMP4CheckBox.Checked = False
        '영상
        ImageSizeComboBox.Text = "480 x 272"
        ImageSizeWidthTextBox.Text = "480"
        ImageSizeHeightTextBox.Text = "272"
        ImageSizeCheckBox.Checked = False
        FFmpegResizeFilterComboBox.Text = "Bicubic"
        AspectComboBox.Text = LangCls.EncSetLetterBoxAspectComboBox
        AspectComboBox2.Text = LangCls.EncSetOutputAspectComboBox2
        AspectWTextBox.Text = "0"
        AspectHTextBox.Text = "0"
        '영상 처리
        FFmpegImageUnsharpCheckBox.Checked = False
        LumaMatrixHSNumericUpDown.Value = 5
        LumaMatrixVSNumericUpDown.Value = 5
        LumaEffectSNumericUpDown.Value = 1.0
        ChromaMatrixHSNumericUpDown.Value = 5
        ChromaMatrixVSNumericUpDown.Value = 5
        ChromaEffectSNumericUpDown.Value = 1.0
        '오디오
        AudioCodecComboBox.Text = "MPEG-1 Audio layer 3(MP3) Lame"
        AudioBitrateComboBox.Text = "128"
        FFmpegChComboBox.Text = LangCls.EncSetch20ComboBox
        SamplerateComboBox.Text = "44100"
        SamplerateCheckBox.Checked = False
        AudioVolNumericUpDown.Value = 256
        VorbisQNumericUpDown.Value = 10
        AMRBitrateComboBox.Text = "12.2"
        NeroAACProfileComboBox.Text = "AAC LC"
        NeroAACBitrateNumericUpDown.Value = 128
        NeroAACQNumericUpDown.Value = 0.5
        NeroAACABRRadioButton.Checked = True
        NeroAACCBRRadioButton.Checked = False
        NeroAACVBRRadioButton.Checked = False
        '기타
        HeaderTextBox.Text = "[KIRARA]"
        ExtensionTextBox.Text = ""
        SizeLimitTextBox.Text = "0"
        SizeLimitCheckBox.Checked = False
        DeinterlaceCheckBox.Checked = False
        FFmpegCommandTextBox.Text = ""

    End Sub

    Private Sub GOPSizeCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GOPSizeCheckBox.CheckedChanged

        If GOPSizeCheckBox.Checked = True Then
            GOPSizeTextBox.Enabled = True
            MinGOPSizeTextBox.Enabled = True
            GOPSizeLabel.Enabled = True
            MinGOPSizeLabel.Enabled = True
        Else
            GOPSizeTextBox.Enabled = False
            MinGOPSizeTextBox.Enabled = False
            GOPSizeLabel.Enabled = False
            MinGOPSizeLabel.Enabled = False
        End If

    End Sub

    Private Sub ImageSizeComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImageSizeComboBox.SelectedIndexChanged

        If ImageSizeComboBox.SelectedIndex = ImageSizeComboBox.Items.Count - 1 Then
            If ImageSizeCheckBox.Checked = True Then '원본 사이즈로
                ImageSizeWidthTextBox.Enabled = False
                ImageSizeHeightTextBox.Enabled = False
                ImageSizeSLabel.Enabled = False
            Else
                ImageSizeWidthTextBox.Enabled = True
                ImageSizeHeightTextBox.Enabled = True
                ImageSizeSLabel.Enabled = True
            End If
            ImageSizeWidthTextBox.Text = "0"
            ImageSizeHeightTextBox.Text = "0"
        Else
            ImageSizeWidthTextBox.Enabled = False
            ImageSizeHeightTextBox.Enabled = False
            ImageSizeSLabel.Enabled = False
            Try
                If InStr(ImageSizeComboBox.Text, " x ", CompareMethod.Text) <> 0 Then ImageSizeWidthTextBox.Text = Split(ImageSizeComboBox.Text, " x ")(0)
                If InStr(ImageSizeComboBox.Text, " x ", CompareMethod.Text) <> 0 Then
                    If InStr(ImageSizeComboBox.Text, " - ", CompareMethod.Text) <> 0 Then
                        ImageSizeHeightTextBox.Text = Split(Split(ImageSizeComboBox.Text, " x ")(1), " - ")(0)
                    Else
                        ImageSizeHeightTextBox.Text = Split(ImageSizeComboBox.Text, " x ")(1)
                    End If
                End If

            Catch ex As Exception
            End Try
        End If

    End Sub

    Private Sub AspectComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AspectComboBox.SelectedIndexChanged

        If AspectComboBox.SelectedIndex = 0 Then
            AspectComboBox2.Visible = False
            AspectWTextBox.Visible = False
            AspectHTextBox.Visible = False
            AspectSLabel.Visible = False
        Else
            AspectComboBox2.Visible = True
            AspectWTextBox.Visible = True
            AspectHTextBox.Visible = True
            AspectSLabel.Visible = True
        End If

    End Sub

    Private Sub AspectComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AspectComboBox2.SelectedIndexChanged

        If AspectComboBox2.SelectedIndex = 0 Then 'DAR
            AspectWTextBox.Enabled = False
            AspectSLabel.Enabled = False
            AspectHTextBox.Enabled = False
            AspectWTextBox.Text = "0"
            AspectHTextBox.Text = "0"

        ElseIf AspectComboBox2.SelectedIndex = 1 Then 'SAR
            AspectWTextBox.Enabled = False
            AspectSLabel.Enabled = False
            AspectHTextBox.Enabled = False
            AspectWTextBox.Text = "0"
            AspectHTextBox.Text = "0"

        ElseIf AspectComboBox2.SelectedIndex = 2 Then '4:3
            AspectWTextBox.Enabled = False
            AspectSLabel.Enabled = False
            AspectHTextBox.Enabled = False
            AspectWTextBox.Text = "4"
            AspectHTextBox.Text = "3"

        ElseIf AspectComboBox2.SelectedIndex = 3 Then '16:9
            AspectWTextBox.Enabled = False
            AspectSLabel.Enabled = False
            AspectHTextBox.Enabled = False
            AspectWTextBox.Text = "16"
            AspectHTextBox.Text = "9"

        ElseIf AspectComboBox2.SelectedIndex = 4 Then '1.85:1
            AspectWTextBox.Enabled = False
            AspectSLabel.Enabled = False
            AspectHTextBox.Enabled = False
            AspectWTextBox.Text = "1.85"
            AspectHTextBox.Text = "1"

        ElseIf AspectComboBox2.SelectedIndex = 5 Then '2.35:1
            AspectWTextBox.Enabled = False
            AspectSLabel.Enabled = False
            AspectHTextBox.Enabled = False
            AspectWTextBox.Text = "2.35"
            AspectHTextBox.Text = "1"

        ElseIf AspectComboBox2.SelectedIndex = AspectComboBox2.Items.Count - 1 Then '사용자
            AspectWTextBox.Enabled = True
            AspectSLabel.Enabled = True
            AspectHTextBox.Enabled = True
            AspectWTextBox.Text = "0"
            AspectHTextBox.Text = "0"

        End If

    End Sub

    Private Sub ImageSizeCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImageSizeCheckBox.CheckedChanged

        If ImageSizeCheckBox.Checked = True Then '원본 사이즈로
            ImageSizeLabel.Enabled = False
            ImageSizeComboBox.Enabled = False
            ImageSizeWidthTextBox.Enabled = False
            ImageSizeSLabel.Enabled = False
            ImageSizeHeightTextBox.Enabled = False
            FFmpegResizeFilterLabel.Enabled = False
            FFmpegResizeFilterComboBox.Enabled = False
            AspectLabel.Enabled = False
            AspectComboBox.Enabled = False
            AspectComboBox2.Enabled = False
            AspectWTextBox.Enabled = False
            AspectSLabel.Enabled = False
            AspectHTextBox.Enabled = False
        Else
            ImageSizeLabel.Enabled = True
            ImageSizeComboBox.Enabled = True
            If ImageSizeComboBox.SelectedIndex = ImageSizeComboBox.Items.Count - 1 Then
                ImageSizeWidthTextBox.Enabled = True
                ImageSizeHeightTextBox.Enabled = True
                ImageSizeSLabel.Enabled = True
            Else
                ImageSizeWidthTextBox.Enabled = False
                ImageSizeHeightTextBox.Enabled = False
                ImageSizeSLabel.Enabled = False
            End If
            FFmpegResizeFilterLabel.Enabled = True
            FFmpegResizeFilterComboBox.Enabled = True
            AspectLabel.Enabled = True
            AspectComboBox.Enabled = True
            AspectComboBox2.Enabled = True
            If AspectComboBox2.SelectedIndex = AspectComboBox2.Items.Count - 1 Then
                AspectWTextBox.Enabled = True
                AspectSLabel.Enabled = True
                AspectHTextBox.Enabled = True
            Else
                AspectWTextBox.Enabled = False
                AspectSLabel.Enabled = False
                AspectHTextBox.Enabled = False
            End If
        End If

    End Sub

    Private Sub AudioVolNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles AudioVolNumericUpDown.LostFocus
        AudioVolNumericUpDown.Text = AudioVolNumericUpDown.Value
    End Sub

    Private Sub AudioVolNumericUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AudioVolNumericUpDown.ValueChanged
        AudioVolTrackBar.Value = AudioVolNumericUpDown.Value
    End Sub

    Private Sub AudioVolTrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AudioVolTrackBar.Scroll
        AudioVolNumericUpDown.Value = AudioVolTrackBar.Value
    End Sub

    Private Sub VorbisQNumericUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VorbisQNumericUpDown.ValueChanged
        VorbisQTrackBar.Value = VorbisQNumericUpDown.Value
    End Sub

    Private Sub VorbisQTrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VorbisQTrackBar.Scroll
        VorbisQNumericUpDown.Value = VorbisQTrackBar.Value
    End Sub

    Private Sub AudioCodecComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AudioCodecComboBox.SelectedIndexChanged

        If AudioCodecComboBox.Text = "AMR-NB(libopencore)" OrElse AudioCodecComboBox.Text = "[AMR] AMR-NB(libopencore)" Then

            AbitratePanel.Visible = False
            AVorbisQPanel.Visible = False
            AAMRBitratePanel.Visible = True
            BitrateNPanel.Visible = False
            AAMRBitratePanel.Left = 15
            AAMRBitratePanel.Top = 46
            NeroAACGroupBox.Visible = False
            SampleratePanel.Enabled = False
            '채널
            AudioPPFrm.AviSynthChGroupBox.Enabled = False
            FFmpegChComboBox.Enabled = False
            FFmpegChLabel.Enabled = False

        ElseIf AudioCodecComboBox.Text = "Vorbis" OrElse AudioCodecComboBox.Text = "[OGG] Vorbis" Then

            AbitratePanel.Visible = False
            AVorbisQPanel.Visible = True
            AAMRBitratePanel.Visible = False
            BitrateNPanel.Visible = False
            AVorbisQPanel.Left = 15
            AVorbisQPanel.Top = 46
            NeroAACGroupBox.Visible = False
            SampleratePanel.Enabled = True
            '채널
            AudioPPFrm.AviSynthChGroupBox.Enabled = True
            FFmpegChComboBox.Enabled = True
            FFmpegChLabel.Enabled = True

        ElseIf AudioCodecComboBox.Text = "Nero AAC" OrElse AudioCodecComboBox.Text = "[MP4] Nero AAC" Then

            AbitratePanel.Visible = False
            AVorbisQPanel.Visible = False
            AAMRBitratePanel.Visible = False
            BitrateNPanel.Visible = True
            BitrateNPanel.Left = 15
            BitrateNPanel.Top = 46
            NeroAACGroupBox.Visible = True
            AudioBitrateNLabel.Text = LangCls.EncSetNeroAACBP
            SampleratePanel.Enabled = True
            '채널
            AudioPPFrm.AviSynthChGroupBox.Enabled = True
            FFmpegChComboBox.Enabled = True
            FFmpegChLabel.Enabled = True

        ElseIf AudioCodecComboBox.Text = "Free Lossless Audio Codec(FLAC)" OrElse AudioCodecComboBox.Text = "[FLAC] Free Lossless Audio Codec(FLAC)" Then

            AbitratePanel.Visible = False
            AVorbisQPanel.Visible = False
            AAMRBitratePanel.Visible = False
            BitrateNPanel.Visible = True
            BitrateNPanel.Left = 15
            BitrateNPanel.Top = 46
            NeroAACGroupBox.Visible = False
            AudioBitrateNLabel.Text = LangCls.EncSetFLACBP
            SampleratePanel.Enabled = True
            '채널
            AudioPPFrm.AviSynthChGroupBox.Enabled = True
            FFmpegChComboBox.Enabled = True
            FFmpegChLabel.Enabled = True

        ElseIf AudioCodecComboBox.Text = "[WAV] signed 16-bit little-endian PCM" Then

            AbitratePanel.Visible = False
            AVorbisQPanel.Visible = False
            AAMRBitratePanel.Visible = False
            BitrateNPanel.Visible = True
            BitrateNPanel.Left = 15
            BitrateNPanel.Top = 46
            NeroAACGroupBox.Visible = False
            AudioBitrateNLabel.Text = LangCls.EncSetPCMBP
            SampleratePanel.Enabled = True
            '채널
            AudioPPFrm.AviSynthChGroupBox.Enabled = True
            FFmpegChComboBox.Enabled = True
            FFmpegChLabel.Enabled = True

        Else

            AbitratePanel.Visible = True
            AVorbisQPanel.Visible = False
            AAMRBitratePanel.Visible = False
            BitrateNPanel.Visible = False
            AbitratePanel.Left = 15
            AbitratePanel.Top = 46
            NeroAACGroupBox.Visible = False
            SampleratePanel.Enabled = True
            '채널
            AudioPPFrm.AviSynthChGroupBox.Enabled = True
            FFmpegChComboBox.Enabled = True
            FFmpegChLabel.Enabled = True

        End If

    End Sub

    Private Sub NeroAACBitrateNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles NeroAACBitrateNumericUpDown.LostFocus
        NeroAACBitrateNumericUpDown.Text = NeroAACBitrateNumericUpDown.Value
    End Sub

    Private Sub NeroAACBitrateNumericUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NeroAACBitrateNumericUpDown.ValueChanged
        NeroAACBitrateTrackBar.Value = NeroAACBitrateNumericUpDown.Value
    End Sub

    Private Sub NeroAACBitrateTrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NeroAACBitrateTrackBar.Scroll
        NeroAACBitrateNumericUpDown.Value = NeroAACBitrateTrackBar.Value
    End Sub

    Private Sub NeroAACQNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles NeroAACQNumericUpDown.LostFocus
        NeroAACQNumericUpDown.Text = NeroAACQNumericUpDown.Value
    End Sub

    Private Sub NeroAACQNumericUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NeroAACQNumericUpDown.ValueChanged
        NeroAACQTrackBar.Value = NeroAACQNumericUpDown.Value * 100
    End Sub

    Private Sub NeroAACQTrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NeroAACQTrackBar.Scroll
        NeroAACQNumericUpDown.Value = NeroAACQTrackBar.Value / 100
    End Sub

    Private Sub NeroAACProfileComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NeroAACProfileComboBox.SelectedIndexChanged
        If NeroAACProfileComboBox.SelectedIndex = 0 OrElse NeroAACProfileComboBox.SelectedIndex = 1 Then
            NeroAACSALabel.Visible = False
        Else
            NeroAACSALabel.Visible = True
        End If
    End Sub

    Private Sub AudioVolButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AudioVolButton.Click
        AudioVolNumericUpDown.Value = 256
    End Sub

    Private Sub NeroAACABRRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NeroAACABRRadioButton.CheckedChanged
        NeroAACBitrateLabel.Enabled = True
        NeroAACBitrateTrackBar.Enabled = True
        NeroAACBitrateNumericUpDown.Enabled = True
        NeroAACQLabel.Enabled = False
        NeroAACQTrackBar.Enabled = False
        NeroAACQNumericUpDown.Enabled = False
    End Sub

    Private Sub NeroAACCBRRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NeroAACCBRRadioButton.CheckedChanged
        NeroAACBitrateLabel.Enabled = True
        NeroAACBitrateTrackBar.Enabled = True
        NeroAACBitrateNumericUpDown.Enabled = True
        NeroAACQLabel.Enabled = False
        NeroAACQTrackBar.Enabled = False
        NeroAACQNumericUpDown.Enabled = False
    End Sub

    Private Sub NeroAACVBRRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NeroAACVBRRadioButton.CheckedChanged
        NeroAACBitrateLabel.Enabled = False
        NeroAACBitrateTrackBar.Enabled = False
        NeroAACBitrateNumericUpDown.Enabled = False
        NeroAACQLabel.Enabled = True
        NeroAACQTrackBar.Enabled = True
        NeroAACQNumericUpDown.Enabled = True
    End Sub

    Private Sub FFmpegCommandButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FFmpegCommandButton.Click
        MsgBox(FFmpegCommandTextBox.Text)
    End Sub

    Private Sub SizeLimitCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SizeLimitCheckBox.CheckedChanged
        If SizeLimitCheckBox.Checked = True Then
            SizeLimitTextBox.Enabled = True
            SizeLimitLabel.Enabled = True
        Else
            SizeLimitTextBox.Enabled = False
            SizeLimitLabel.Enabled = False
        End If
    End Sub

    Private Sub LumaMatrixHSTrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LumaMatrixHSTrackBar.Scroll
        LumaMatrixHSNumericUpDown.Value = LumaMatrixHSTrackBar.Value
    End Sub

    Private Sub LumaMatrixHSNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles LumaMatrixHSNumericUpDown.LostFocus
        LumaMatrixHSNumericUpDown.Text = LumaMatrixHSNumericUpDown.Value
    End Sub

    Private Sub LumaMatrixHSNumericUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LumaMatrixHSNumericUpDown.ValueChanged
        LumaMatrixHSTrackBar.Value = LumaMatrixHSNumericUpDown.Value
    End Sub

    Private Sub LumaMatrixVSTrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LumaMatrixVSTrackBar.Scroll
        LumaMatrixVSNumericUpDown.Value = LumaMatrixVSTrackBar.Value
    End Sub

    Private Sub LumaMatrixVSNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles LumaMatrixVSNumericUpDown.LostFocus
        LumaMatrixVSNumericUpDown.Text = LumaMatrixVSNumericUpDown.Value
    End Sub

    Private Sub LumaMatrixVSNumericUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LumaMatrixVSNumericUpDown.ValueChanged
        LumaMatrixVSTrackBar.Value = LumaMatrixVSNumericUpDown.Value
    End Sub

    Private Sub LumaEffectSTrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LumaEffectSTrackBar.Scroll
        LumaEffectSNumericUpDown.Value = LumaEffectSTrackBar.Value / 10
    End Sub

    Private Sub LumaEffectSNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles LumaEffectSNumericUpDown.LostFocus
        LumaEffectSNumericUpDown.Text = LumaEffectSNumericUpDown.Value
    End Sub

    Private Sub LumaEffectSNumericUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LumaEffectSNumericUpDown.ValueChanged
        LumaEffectSTrackBar.Value = LumaEffectSNumericUpDown.Value * 10
    End Sub

    Private Sub ChromaMatrixHSTrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChromaMatrixHSTrackBar.Scroll
        ChromaMatrixHSNumericUpDown.Value = ChromaMatrixHSTrackBar.Value
    End Sub

    Private Sub ChromaMatrixHSNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChromaMatrixHSNumericUpDown.LostFocus
        ChromaMatrixHSNumericUpDown.Text = ChromaMatrixHSNumericUpDown.Value
    End Sub

    Private Sub ChromaMatrixHSNumericUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChromaMatrixHSNumericUpDown.ValueChanged
        ChromaMatrixHSTrackBar.Value = ChromaMatrixHSNumericUpDown.Value
    End Sub

    Private Sub ChromaMatrixVSTrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChromaMatrixVSTrackBar.Scroll
        ChromaMatrixVSNumericUpDown.Value = ChromaMatrixVSTrackBar.Value
    End Sub

    Private Sub ChromaMatrixVSNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChromaMatrixVSNumericUpDown.LostFocus
        ChromaMatrixVSNumericUpDown.Text = ChromaMatrixVSNumericUpDown.Value
    End Sub

    Private Sub ChromaMatrixVSNumericUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChromaMatrixVSNumericUpDown.ValueChanged
        ChromaMatrixVSTrackBar.Value = ChromaMatrixVSNumericUpDown.Value
    End Sub

    Private Sub ChromaEffectSTrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChromaEffectSTrackBar.Scroll
        ChromaEffectSNumericUpDown.Value = ChromaEffectSTrackBar.Value / 10
    End Sub

    Private Sub ChromaEffectSNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChromaEffectSNumericUpDown.LostFocus
        ChromaEffectSNumericUpDown.Text = ChromaEffectSNumericUpDown.Value
    End Sub

    Private Sub ChromaEffectSNumericUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChromaEffectSNumericUpDown.ValueChanged
        ChromaEffectSTrackBar.Value = ChromaEffectSNumericUpDown.Value * 10
    End Sub

    Private Sub LumaMatrixHSButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LumaMatrixHSButton.Click
        LumaMatrixHSNumericUpDown.Value = 5
    End Sub

    Private Sub LumaMatrixVSButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LumaMatrixVSButton.Click
        LumaMatrixVSNumericUpDown.Value = 5
    End Sub

    Private Sub LumaEffectSButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LumaEffectSButton.Click
        LumaEffectSNumericUpDown.Value = 1.0
    End Sub

    Private Sub ChromaMatrixHSButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChromaMatrixHSButton.Click
        ChromaMatrixHSNumericUpDown.Value = 5
    End Sub

    Private Sub ChromaMatrixVSButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChromaMatrixVSButton.Click
        ChromaMatrixVSNumericUpDown.Value = 5
    End Sub

    Private Sub ChromaEffectSButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChromaEffectSButton.Click
        ChromaEffectSNumericUpDown.Value = 1.0
    End Sub

    Private Sub XML_CHANGE(ByVal src As String)

        Try
            Dim XDoc As New XmlDocument()
            Dim XNode As XmlNode
            XDoc.Load(src)
            '============== 시작

            '설정 기본값
            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/EncSetFrm_OutFComboBox")
            If Not XNode Is Nothing Then XNode.InnerText = Split(OutFComboBox.Text, " ")(0)

            '비디오
            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/EncSetFrm_VideoCodecComboBox")
            If Not XNode Is Nothing Then XNode.InnerText = VideoCodecComboBox.Text

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/EncSetFrm_VideoModeComboBox")
            If Not XNode Is Nothing Then XNode.InnerText = Split(VideoModeComboBox.Text, " ")(0)

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/EncSetFrm_BitrateComboBox")
            If Not XNode Is Nothing Then If BitrateComboBox.Text = "" Then XNode.InnerText = "700" Else XNode.InnerText = BitrateComboBox.Text

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/EncSetFrm_QuantizerNumericUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = QuantizerNumericUpDown.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/EncSetFrm_QuantizerCQPNumericUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = QuantizerCQPNumericUpDown.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/EncSetFrm_QualityNumericUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = QualityNumericUpDown.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/EncSetFrm_FramerateComboBox")
            If Not XNode Is Nothing Then XNode.InnerText = FramerateComboBox.Text

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/EncSetFrm_FramerateCheckBox")
            If Not XNode Is Nothing Then XNode.InnerText = FramerateCheckBox.Checked

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/EncSetFrm_AdvanOptsCheckBox")
            If Not XNode Is Nothing Then XNode.InnerText = AdvanOptsCheckBox.Checked

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/EncSetFrm_GOPSizeCheckBox")
            If Not XNode Is Nothing Then XNode.InnerText = GOPSizeCheckBox.Checked

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/EncSetFrm_GOPSizeTextBox")
            If Not XNode Is Nothing Then If GOPSizeTextBox.Text = "" Then XNode.InnerText = "250" Else XNode.InnerText = GOPSizeTextBox.Text

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/EncSetFrm_MinGOPSizeTextBox")
            If Not XNode Is Nothing Then If MinGOPSizeTextBox.Text = "" Then XNode.InnerText = "25" Else XNode.InnerText = MinGOPSizeTextBox.Text

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/EncSetFrm_PSPMP4CheckBox")
            If Not XNode Is Nothing Then XNode.InnerText = PSPMP4CheckBox.Checked

            '영상
            'ImageSizeComboBox
            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/EncSetFrm_ImageSizeComboBox")
            If ImageSizeComboBox.Text = LangCls.EncSetUserInputComboBox Then
                If Not XNode Is Nothing Then XNode.InnerText = "LangCls.EncSetUserInputComboBox"
            Else
                If Not XNode Is Nothing Then XNode.InnerText = ImageSizeComboBox.Text
            End If
            'ImageSizeComboBox

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/EncSetFrm_ImageSizeWidthTextBox")
            If Not XNode Is Nothing Then If ImageSizeWidthTextBox.Text = "" Then XNode.InnerText = "480" Else XNode.InnerText = ImageSizeWidthTextBox.Text

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/EncSetFrm_ImageSizeHeightTextBox")
            If Not XNode Is Nothing Then If ImageSizeHeightTextBox.Text = "" Then XNode.InnerText = "272" Else XNode.InnerText = ImageSizeHeightTextBox.Text

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/EncSetFrm_ImageSizeCheckBox")
            If Not XNode Is Nothing Then XNode.InnerText = ImageSizeCheckBox.Checked

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/EncSetFrm_FFmpegResizeFilterComboBox")
            If Not XNode Is Nothing Then XNode.InnerText = FFmpegResizeFilterComboBox.Text

            'AspectComboBox
            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/EncSetFrm_AspectComboBox")
            If AspectComboBox.Text = LangCls.EncSetNoKeepAspectComboBox Then
                If Not XNode Is Nothing Then XNode.InnerText = "LangCls.EncSetNoKeepAspectComboBox"
            ElseIf AspectComboBox.Text = LangCls.EncSetLetterBoxAspectComboBox Then
                If Not XNode Is Nothing Then XNode.InnerText = "LangCls.EncSetLetterBoxAspectComboBox"
            ElseIf AspectComboBox.Text = LangCls.EncSetCropAspectComboBox Then
                If Not XNode Is Nothing Then XNode.InnerText = "LangCls.EncSetCropAspectComboBox"
            End If
            'AspectComboBox

            'AspectComboBox2
            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/EncSetFrm_AspectComboBox2")
            If AspectComboBox2.Text = LangCls.EncSetOutputAspectComboBox2 Then
                If Not XNode Is Nothing Then XNode.InnerText = "LangCls.EncSetOutputAspectComboBox2"
            ElseIf AspectComboBox2.Text = LangCls.EncSetOriginalAspectComboBox2 Then
                If Not XNode Is Nothing Then XNode.InnerText = "LangCls.EncSetOriginalAspectComboBox2"
            ElseIf AspectComboBox2.Text = LangCls.EncSet43AspectComboBox2 Then
                If Not XNode Is Nothing Then XNode.InnerText = "LangCls.EncSet43AspectComboBox2"
            ElseIf AspectComboBox2.Text = LangCls.EncSet169AspectComboBox2 Then
                If Not XNode Is Nothing Then XNode.InnerText = "LangCls.EncSet169AspectComboBox2"
            ElseIf AspectComboBox2.Text = LangCls.EncSet1851AspectComboBox2 Then
                If Not XNode Is Nothing Then XNode.InnerText = "LangCls.EncSet1851AspectComboBox2"
            ElseIf AspectComboBox2.Text = LangCls.EncSet2351AspectComboBox2 Then
                If Not XNode Is Nothing Then XNode.InnerText = "LangCls.EncSet2351AspectComboBox2"
            ElseIf AspectComboBox2.Text = LangCls.EncSetUserInputComboBox Then
                If Not XNode Is Nothing Then XNode.InnerText = "LangCls.EncSetUserInputComboBox"
            End If
            'AspectComboBox2

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/EncSetFrm_AspectWTextBox")
            If Not XNode Is Nothing Then If AspectWTextBox.Text = "" Then XNode.InnerText = "0" Else XNode.InnerText = AspectWTextBox.Text

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/EncSetFrm_AspectHTextBox")
            If Not XNode Is Nothing Then If AspectHTextBox.Text = "" Then XNode.InnerText = "0" Else XNode.InnerText = AspectHTextBox.Text

            '영상 처리
            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/EncSetFrm_FFmpegImageUnsharpCheckBox")
            If Not XNode Is Nothing Then XNode.InnerText = FFmpegImageUnsharpCheckBox.Checked

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/EncSetFrm_LumaMatrixHSNumericUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = LumaMatrixHSNumericUpDown.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/EncSetFrm_LumaMatrixVSNumericUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = LumaMatrixVSNumericUpDown.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/EncSetFrm_LumaEffectSNumericUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = LumaEffectSNumericUpDown.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/EncSetFrm_ChromaMatrixHSNumericUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = ChromaMatrixHSNumericUpDown.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/EncSetFrm_ChromaMatrixVSNumericUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = ChromaMatrixVSNumericUpDown.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/EncSetFrm_ChromaEffectSNumericUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = ChromaEffectSNumericUpDown.Value

            '오디오
            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/EncSetFrm_AudioCodecComboBox")
            If Not XNode Is Nothing Then XNode.InnerText = AudioCodecComboBox.Text

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/EncSetFrm_AudioBitrateComboBox")
            If Not XNode Is Nothing Then If AudioBitrateComboBox.Text = "" Then XNode.InnerText = "128" Else XNode.InnerText = AudioBitrateComboBox.Text

            'FFmpegChComboBox
            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/EncSetFrm_FFmpegChComboBox")
            If FFmpegChComboBox.Text = LangCls.EncSetchoriginComboBox Then
                If Not XNode Is Nothing Then XNode.InnerText = "LangCls.EncSetchoriginComboBox"
            ElseIf FFmpegChComboBox.Text = LangCls.EncSetch10ComboBox Then
                If Not XNode Is Nothing Then XNode.InnerText = "LangCls.EncSetch10ComboBox"
            ElseIf FFmpegChComboBox.Text = LangCls.EncSetch20ComboBox Then
                If Not XNode Is Nothing Then XNode.InnerText = "LangCls.EncSetch20ComboBox"
            ElseIf FFmpegChComboBox.Text = LangCls.EncSetch51ComboBox Then
                If Not XNode Is Nothing Then XNode.InnerText = "LangCls.EncSetch51ComboBox"
            End If
            'FFmpegChComboBox

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/EncSetFrm_SamplerateComboBox")
            If Not XNode Is Nothing Then If SamplerateComboBox.Text = "" Then XNode.InnerText = "44100" Else XNode.InnerText = SamplerateComboBox.Text

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/EncSetFrm_SamplerateCheckBox")
            If Not XNode Is Nothing Then XNode.InnerText = SamplerateCheckBox.Checked

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/EncSetFrm_AudioVolNumericUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = AudioVolNumericUpDown.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/EncSetFrm_VorbisQNumericUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = VorbisQNumericUpDown.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/EncSetFrm_AMRBitrateComboBox")
            If Not XNode Is Nothing Then XNode.InnerText = AMRBitrateComboBox.Text

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/EncSetFrm_NeroAACProfileComboBox")
            If Not XNode Is Nothing Then XNode.InnerText = NeroAACProfileComboBox.Text

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/EncSetFrm_NeroAACBitrateNumericUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = NeroAACBitrateNumericUpDown.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/EncSetFrm_NeroAACQNumericUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = NeroAACQNumericUpDown.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/EncSetFrm_NeroAACABRRadioButton")
            If Not XNode Is Nothing Then XNode.InnerText = NeroAACABRRadioButton.Checked

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/EncSetFrm_NeroAACCBRRadioButton")
            If Not XNode Is Nothing Then XNode.InnerText = NeroAACCBRRadioButton.Checked

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/EncSetFrm_NeroAACVBRRadioButton")
            If Not XNode Is Nothing Then XNode.InnerText = NeroAACVBRRadioButton.Checked

            '기타
            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/EncSetFrm_HeaderTextBox")
            If Not XNode Is Nothing Then If HeaderTextBox.Text = "" Then XNode.InnerText = vbNullChar Else XNode.InnerText = HeaderTextBox.Text

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/EncSetFrm_ExtensionTextBox")
            If Not XNode Is Nothing Then If ExtensionTextBox.Text = "" Then XNode.InnerText = vbNullChar Else XNode.InnerText = ExtensionTextBox.Text

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/EncSetFrm_SizeLimitTextBox")
            If Not XNode Is Nothing Then If SizeLimitTextBox.Text = "" Then XNode.InnerText = "0" Else XNode.InnerText = SizeLimitTextBox.Text

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/EncSetFrm_SizeLimitCheckBox")
            If Not XNode Is Nothing Then XNode.InnerText = SizeLimitCheckBox.Checked

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/EncSetFrm_DeinterlaceCheckBox")
            If Not XNode Is Nothing Then XNode.InnerText = DeinterlaceCheckBox.Checked

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/EncSetFrm_FFmpegCommandTextBox")
            If Not XNode Is Nothing Then If FFmpegCommandTextBox.Text = "" Then XNode.InnerText = vbNullChar Else XNode.InnerText = FFmpegCommandTextBox.Text

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

        Dim SR As New StreamReader(src, System.Text.Encoding.UTF8)
        Dim XTR As New System.Xml.XmlTextReader(SR)

        Try

            Do While XTR.Read
                Application.DoEvents()

                '설정 기본값
                If XTR.Name = "EncSetFrm_OutFComboBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then OutFComboBox.SelectedIndex = OutFComboBox.FindString(XTRSTR, -1) Else OutFComboBox.SelectedIndex = OutFComboBox.FindString("[AVI]", -1)
                End If

                '비디오
                If XTR.Name = "EncSetFrm_VideoCodecComboBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then VideoCodecComboBox.Text = XTRSTR Else VideoCodecComboBox.Text = "Xvid MPEG-4 Codec"
                End If

                If XTR.Name = "EncSetFrm_VideoModeComboBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then VideoModeComboBox.SelectedIndex = VideoModeComboBox.FindString(XTRSTR, -1) Else VideoModeComboBox.SelectedIndex = VideoModeComboBox.FindString("[1PASS-CBR]", -1)
                End If

                If XTR.Name = "EncSetFrm_BitrateComboBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then BitrateComboBox.Text = XTRSTR Else BitrateComboBox.Text = "700"
                End If

                If XTR.Name = "EncSetFrm_QuantizerNumericUpDown" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then QuantizerNumericUpDown.Value = XTRSTR Else QuantizerNumericUpDown.Value = 2.5
                End If

                If XTR.Name = "EncSetFrm_QuantizerCQPNumericUpDown" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then QuantizerCQPNumericUpDown.Value = XTRSTR Else QuantizerCQPNumericUpDown.Value = 26
                End If

                If XTR.Name = "EncSetFrm_QualityNumericUpDown" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then QualityNumericUpDown.Value = XTRSTR Else QualityNumericUpDown.Value = 26.0
                End If

                If XTR.Name = "EncSetFrm_FramerateComboBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then FramerateComboBox.Text = XTRSTR Else FramerateComboBox.Text = "23.976"
                End If

                If XTR.Name = "EncSetFrm_FramerateCheckBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then FramerateCheckBox.Checked = XTRSTR Else FramerateCheckBox.Checked = False
                End If

                If XTR.Name = "EncSetFrm_AdvanOptsCheckBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then AdvanOptsCheckBox.Checked = XTRSTR Else AdvanOptsCheckBox.Checked = False
                End If

                If XTR.Name = "EncSetFrm_GOPSizeCheckBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then GOPSizeCheckBox.Checked = XTRSTR Else GOPSizeCheckBox.Checked = False
                End If

                If XTR.Name = "EncSetFrm_GOPSizeTextBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then GOPSizeTextBox.Text = XTRSTR Else GOPSizeTextBox.Text = "250"
                End If

                If XTR.Name = "EncSetFrm_MinGOPSizeTextBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then MinGOPSizeTextBox.Text = XTRSTR Else MinGOPSizeTextBox.Text = "25"
                End If

                If XTR.Name = "EncSetFrm_PSPMP4CheckBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then PSPMP4CheckBox.Checked = XTRSTR Else PSPMP4CheckBox.Checked = False
                End If

                '영상
                'ImageSizeComboBox
                If XTR.Name = "EncSetFrm_ImageSizeComboBox" Then
                    Dim ImageSizeComboBoxV As String = ""
                    ImageSizeComboBoxV = XTR.ReadString
                    If ImageSizeComboBoxV = "LangCls.EncSetUserInputComboBox" Then
                        ImageSizeComboBox.Text = LangCls.EncSetUserInputComboBox
                    Else
                        If ImageSizeComboBoxV <> "" Then
                            ImageSizeComboBox.Text = ImageSizeComboBoxV
                        Else '기본값
                            ImageSizeComboBox.Text = "480 x 272"
                        End If
                    End If
                End If
                'ImageSizeComboBox

                If XTR.Name = "EncSetFrm_ImageSizeWidthTextBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then ImageSizeWidthTextBox.Text = XTRSTR Else ImageSizeWidthTextBox.Text = "480"
                End If

                If XTR.Name = "EncSetFrm_ImageSizeHeightTextBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then ImageSizeHeightTextBox.Text = XTRSTR Else ImageSizeHeightTextBox.Text = "272"
                End If

                If XTR.Name = "EncSetFrm_ImageSizeCheckBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then ImageSizeCheckBox.Checked = XTRSTR Else ImageSizeCheckBox.Checked = False
                End If

                If XTR.Name = "EncSetFrm_FFmpegResizeFilterComboBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then FFmpegResizeFilterComboBox.Text = XTRSTR Else FFmpegResizeFilterComboBox.Text = "Bicubic"
                End If

                'AspectComboBox
                If XTR.Name = "EncSetFrm_AspectComboBox" Then
                    Dim AspectComboBoxV As String = ""
                    AspectComboBoxV = XTR.ReadString
                    If AspectComboBoxV = "LangCls.EncSetNoKeepAspectComboBox" Then
                        AspectComboBox.Text = LangCls.EncSetNoKeepAspectComboBox
                    ElseIf AspectComboBoxV = "LangCls.EncSetLetterBoxAspectComboBox" Then
                        AspectComboBox.Text = LangCls.EncSetLetterBoxAspectComboBox
                    ElseIf AspectComboBoxV = "LangCls.EncSetCropAspectComboBox" Then
                        AspectComboBox.Text = LangCls.EncSetCropAspectComboBox
                    Else '기본값
                        AspectComboBox.Text = LangCls.EncSetLetterBoxAspectComboBox
                    End If
                End If
                'AspectComboBox

                'AspectComboBox2
                If XTR.Name = "EncSetFrm_AspectComboBox2" Then
                    Dim AspectComboBox2V As String = ""
                    AspectComboBox2V = XTR.ReadString
                    If AspectComboBox2V = "LangCls.EncSetOutputAspectComboBox2" Then
                        AspectComboBox2.Text = LangCls.EncSetOutputAspectComboBox2
                    ElseIf AspectComboBox2V = "LangCls.EncSetOriginalAspectComboBox2" Then
                        AspectComboBox2.Text = LangCls.EncSetOriginalAspectComboBox2
                    ElseIf AspectComboBox2V = "LangCls.EncSet43AspectComboBox2" Then
                        AspectComboBox2.Text = LangCls.EncSet43AspectComboBox2
                    ElseIf AspectComboBox2V = "LangCls.EncSet169AspectComboBox2" Then
                        AspectComboBox2.Text = LangCls.EncSet169AspectComboBox2
                    ElseIf AspectComboBox2V = "LangCls.EncSet1851AspectComboBox2" Then
                        AspectComboBox2.Text = LangCls.EncSet1851AspectComboBox2
                    ElseIf AspectComboBox2V = "LangCls.EncSet2351AspectComboBox2" Then
                        AspectComboBox2.Text = LangCls.EncSet2351AspectComboBox2
                    ElseIf AspectComboBox2V = "LangCls.EncSetUserInputComboBox" Then
                        AspectComboBox2.Text = LangCls.EncSetUserInputComboBox
                    Else '기본값
                        AspectComboBox2.Text = LangCls.EncSetOutputAspectComboBox2
                    End If
                End If
                'AspectComboBox2

                If XTR.Name = "EncSetFrm_AspectWTextBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then AspectWTextBox.Text = XTRSTR Else AspectWTextBox.Text = "0"
                End If

                If XTR.Name = "EncSetFrm_AspectHTextBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then AspectHTextBox.Text = XTRSTR Else AspectHTextBox.Text = "0"
                End If

                '영상 처리
                If XTR.Name = "EncSetFrm_FFmpegImageUnsharpCheckBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then FFmpegImageUnsharpCheckBox.Checked = XTRSTR Else FFmpegImageUnsharpCheckBox.Checked = False
                End If

                If XTR.Name = "EncSetFrm_LumaMatrixHSNumericUpDown" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then LumaMatrixHSNumericUpDown.Value = XTRSTR Else LumaMatrixHSNumericUpDown.Value = 5
                End If

                If XTR.Name = "EncSetFrm_LumaMatrixVSNumericUpDown" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then LumaMatrixVSNumericUpDown.Value = XTRSTR Else LumaMatrixVSNumericUpDown.Value = 5
                End If

                If XTR.Name = "EncSetFrm_LumaEffectSNumericUpDown" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then LumaEffectSNumericUpDown.Value = XTRSTR Else LumaEffectSNumericUpDown.Value = 1.0
                End If

                If XTR.Name = "EncSetFrm_ChromaMatrixHSNumericUpDown" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then ChromaMatrixHSNumericUpDown.Value = XTRSTR Else ChromaMatrixHSNumericUpDown.Value = 5
                End If

                If XTR.Name = "EncSetFrm_ChromaMatrixVSNumericUpDown" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then ChromaMatrixVSNumericUpDown.Value = XTRSTR Else ChromaMatrixVSNumericUpDown.Value = 5
                End If

                If XTR.Name = "EncSetFrm_ChromaEffectSNumericUpDown" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then ChromaEffectSNumericUpDown.Value = XTRSTR Else ChromaEffectSNumericUpDown.Value = 1.0
                End If

                '오디오
                If XTR.Name = "EncSetFrm_AudioCodecComboBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then AudioCodecComboBox.Text = XTRSTR Else AudioCodecComboBox.Text = "MPEG-1 Audio layer 3(MP3) Lame"
                End If

                If XTR.Name = "EncSetFrm_AudioBitrateComboBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then AudioBitrateComboBox.Text = XTRSTR Else AudioBitrateComboBox.Text = "128"
                End If

                'FFmpegChComboBox
                If XTR.Name = "EncSetFrm_FFmpegChComboBox" Then
                    Dim FFmpegChComboBoxV As String = ""
                    FFmpegChComboBoxV = XTR.ReadString
                    If FFmpegChComboBoxV = "LangCls.EncSetchoriginComboBox" Then
                        FFmpegChComboBox.Text = LangCls.EncSetchoriginComboBox
                    ElseIf FFmpegChComboBoxV = "LangCls.EncSetch10ComboBox" Then
                        FFmpegChComboBox.Text = LangCls.EncSetch10ComboBox
                    ElseIf FFmpegChComboBoxV = "LangCls.EncSetch20ComboBox" Then
                        FFmpegChComboBox.Text = LangCls.EncSetch20ComboBox
                    ElseIf FFmpegChComboBoxV = "LangCls.EncSetch51ComboBox" Then
                        FFmpegChComboBox.Text = LangCls.EncSetch51ComboBox
                    Else '기본값
                        FFmpegChComboBox.Text = LangCls.EncSetch20ComboBox
                    End If
                End If
                'FFmpegChComboBox

                If XTR.Name = "EncSetFrm_SamplerateComboBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then SamplerateComboBox.Text = XTRSTR Else SamplerateComboBox.Text = "44100"
                End If

                If XTR.Name = "EncSetFrm_SamplerateCheckBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then SamplerateCheckBox.Checked = XTRSTR Else SamplerateCheckBox.Checked = False
                End If

                If XTR.Name = "EncSetFrm_AudioVolNumericUpDown" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then AudioVolNumericUpDown.Value = XTRSTR Else AudioVolNumericUpDown.Value = 256
                End If

                If XTR.Name = "EncSetFrm_VorbisQNumericUpDown" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then VorbisQNumericUpDown.Value = XTRSTR Else VorbisQNumericUpDown.Value = 10
                End If

                If XTR.Name = "EncSetFrm_AMRBitrateComboBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then AMRBitrateComboBox.Text = XTRSTR Else AMRBitrateComboBox.Text = "12.2"
                End If

                If XTR.Name = "EncSetFrm_NeroAACProfileComboBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then NeroAACProfileComboBox.Text = XTRSTR Else NeroAACProfileComboBox.Text = "AAC LC"
                End If

                If XTR.Name = "EncSetFrm_NeroAACBitrateNumericUpDown" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then NeroAACBitrateNumericUpDown.Value = XTRSTR Else NeroAACBitrateNumericUpDown.Value = 128
                End If

                If XTR.Name = "EncSetFrm_NeroAACQNumericUpDown" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then NeroAACQNumericUpDown.Value = XTRSTR Else NeroAACQNumericUpDown.Value = 0.5
                End If

                If XTR.Name = "EncSetFrm_NeroAACABRRadioButton" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then NeroAACABRRadioButton.Checked = XTRSTR Else NeroAACABRRadioButton.Checked = True
                End If

                If XTR.Name = "EncSetFrm_NeroAACCBRRadioButton" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then NeroAACCBRRadioButton.Checked = XTRSTR Else NeroAACCBRRadioButton.Checked = False
                End If

                If XTR.Name = "EncSetFrm_NeroAACVBRRadioButton" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then NeroAACVBRRadioButton.Checked = XTRSTR Else NeroAACVBRRadioButton.Checked = False
                End If

                '기타
                If XTR.Name = "EncSetFrm_HeaderTextBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> vbNullChar Then HeaderTextBox.Text = XTRSTR Else HeaderTextBox.Text = "" '[예외]
                End If

                If XTR.Name = "EncSetFrm_ExtensionTextBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> vbNullChar Then ExtensionTextBox.Text = XTRSTR Else ExtensionTextBox.Text = ""
                End If

                If XTR.Name = "EncSetFrm_SizeLimitTextBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then SizeLimitTextBox.Text = XTRSTR Else SizeLimitTextBox.Text = "0"
                End If

                If XTR.Name = "EncSetFrm_SizeLimitCheckBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then SizeLimitCheckBox.Checked = XTRSTR Else SizeLimitCheckBox.Checked = False
                End If

                If XTR.Name = "EncSetFrm_DeinterlaceCheckBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then DeinterlaceCheckBox.Checked = XTRSTR Else DeinterlaceCheckBox.Checked = False
                End If

                If XTR.Name = "EncSetFrm_FFmpegCommandTextBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> vbNullChar Then FFmpegCommandTextBox.Text = XTRSTR Else FFmpegCommandTextBox.Text = ""
                End If

            Loop

        Catch ex As Exception
            MsgBox("XML_LOAD_ERROR :" & ex.Message)
        Finally
            XTR.Close()
        End Try

    End Sub

    Public Sub GETFFCMD()

        '***********************************
        '  x264 고급설정
        '***********************************
        Dim x264optsV As String = ""
        Dim x264opts_2passV As String = ""
        If VideoCodecComboBox.Text = "H.264(AVC) x264 core" AndAlso AdvanOptsCheckBox.Checked = True Then
            With x264optsFrm

                '------------------------
                ' LEVEL
                '------------------------.
                Dim LevelComboBoxV As String = ""
                If .LevelComboBox.Text <> "Unrestricted AutoGuess" Then
                    LevelComboBoxV = " -level " & Replace(.LevelComboBox.Text, ".", "")
                End If

                '------------------------
                ' Deblocking
                '------------------------
                Dim DeblockingCheckBoxV As String = ""
                If .DeblockingCheckBox.Checked = True Then
                    DeblockingCheckBoxV = " -flags +loop -deblockalpha " & .DeblockingAlphaNumericUpDown.Value & " -deblockbeta " & .DeblockingBetaNumericUpDown.Value
                End If

                '------------------------
                ' CABAC
                '------------------------
                Dim CABACCheckBoxV As String = ""
                If .ProfileComboBox.Text <> "Baseline Profile" Then
                    If .CABACCheckBox.Checked = True Then
                        CABACCheckBoxV = " -coder 1"
                    Else
                        CABACCheckBoxV = " -coder 0"
                    End If
                End If

                '------------------------
                ' B-Frames, MVPrediction
                '------------------------
                Dim BFramesV As String = ""
                If .ProfileComboBox.Text <> "Baseline Profile" Then
                    'BFramePyramid
                    Dim BFramePyramidV As String = ""
                    If .BFramePyramidCheckBox.Checked = True Then
                        BFramePyramidV = " -flags2 +bpyramid"
                    Else
                        BFramePyramidV = " -flags2 -bpyramid"
                    End If
                    'BFrameWeightedPrediction
                    Dim BFrameWeightedPredictionV As String = ""
                    If .BFrameWeightedPredictionCheckBox.Checked = True Then
                        BFrameWeightedPredictionV = " -flags2 +wpred"
                    Else
                        BFrameWeightedPredictionV = " -flags2 -wpred"
                    End If
                    'MVPrediction
                    Dim MVPredictionV As String = ""
                    If .MVPredictionModeComboBox.Text = "None" Then
                        MVPredictionV = " -directpred 0"
                    ElseIf .MVPredictionModeComboBox.Text = "Spatial" Then
                        MVPredictionV = " -directpred 1"
                    ElseIf .MVPredictionModeComboBox.Text = "Temporal" Then
                        MVPredictionV = " -directpred 2"
                    ElseIf .MVPredictionModeComboBox.Text = "Auto" Then
                        MVPredictionV = " -directpred 3"
                    End If
                    '------
                    If .BFramesNumericUpDown.Value = 0 Then
                        BFramesV = " -bf " & .BFramesNumericUpDown.Value
                    ElseIf .BFramesNumericUpDown.Value = 1 Then
                        BFramesV = " -bf " & .BFramesNumericUpDown.Value & " -bframebias " & .BFrameBiasNumericUpDown.Value & " -b_strategy " & Strings.Left(.AdaptiveBFramesComboBox.Text, 1) & _
                        BFrameWeightedPredictionV & MVPredictionV
                    Else
                        BFramesV = " -bf " & .BFramesNumericUpDown.Value & " -bframebias " & .BFrameBiasNumericUpDown.Value & " -b_strategy " & Strings.Left(.AdaptiveBFramesComboBox.Text, 1) & _
                        BFramePyramidV & BFrameWeightedPredictionV & MVPredictionV
                    End If
                End If

                '------------------------
                ' AdaptiveIFramesDecision, ExtraIFrames
                '------------------------
                Dim AdaptiveIFramesDecisionV As String = ""
                If .AdaptiveIFramesDecisionCheckBox.Checked = True Then
                    AdaptiveIFramesDecisionV = " -sc_threshold " & .ExtraIFramesNumericUpDown.Value
                End If

                '------------------------
                ' PframeWeightedPrediction
                '------------------------
                Dim PframeWeightedPredictionV As String = ""
                If .ProfileComboBox.Text <> "Baseline Profile" Then
                    If .PframeWeightedPredictionComboBox.Text = "Disabled" Then
                        PframeWeightedPredictionV = " -wpredp 0"
                    ElseIf .PframeWeightedPredictionComboBox.Text = "Blind offset" Then
                        PframeWeightedPredictionV = " -wpredp 1"
                    ElseIf .PframeWeightedPredictionComboBox.Text = "Smart analysis" Then
                        PframeWeightedPredictionV = " -wpredp 2"
                    End If
                End If

                '------------------------
                ' 모드별 Rate Control
                '------------------------
                'AdaptiveQuantizersMode
                Dim AdaptiveQuantizersModeV As String = ""
                If .AdaptiveQuantizersModeComboBox.Text = "Disabled" Then
                    AdaptiveQuantizersModeV = " -aq_mode 0"
                ElseIf .AdaptiveQuantizersModeComboBox.Text = "Variance AQ" Then
                    AdaptiveQuantizersModeV = " -aq_mode 1"
                ElseIf .AdaptiveQuantizersModeComboBox.Text = "Auto-variance AQ" Then
                    AdaptiveQuantizersModeV = " -aq_mode 2"
                End If
                'UseMBTree
                Dim UseMBTreeV As String = ""
                If .UseMBTreeCheckBox.Checked = True Then
                    UseMBTreeV = " -flags2 +mbtree"
                Else
                    UseMBTreeV = " -flags2 -mbtree"
                End If
                'RateControlMV
                Dim RateControlMV As String = ""
                If InStr(VideoModeComboBox.SelectedItem, "[1PASS-CQP]", CompareMethod.Text) <> 0 Then '퀀타이저
                    RateControlMV = ""
                ElseIf InStr(VideoModeComboBox.SelectedItem, "[1PASS-CRF]", CompareMethod.Text) <> 0 Then '퀄리티
                    RateControlMV = AdaptiveQuantizersModeV & " -aq_strength " & .AdaptiveQuantizersStrengthNumericUpDown.Value & _
                                    " -bufsize " & .VBVBufferSizeNumericUpDown.Value & "k" & " -maxrate " & .VBVMaximumBitrateNumericUpDown.Value & "k" & " -rc_init_occupancy " & .VBVInitialBufferNumericUpDown.Value & _
                                    " -qcomp " & .QuantizerCompressionNumericUpDown.Value & _
                                    " -rc_lookahead " & .NumberofFramesforLookaheadNumericUpDown.Value & UseMBTreeV
                Else '비트레이트
                    RateControlMV = AdaptiveQuantizersModeV & " -aq_strength " & .AdaptiveQuantizersStrengthNumericUpDown.Value & _
                                    " -bufsize " & .VBVBufferSizeNumericUpDown.Value & "k" & " -maxrate " & .VBVMaximumBitrateNumericUpDown.Value & "k" & " -rc_init_occupancy " & .VBVInitialBufferNumericUpDown.Value & _
                                     " -bt " & Val(BitrateComboBox.Text) * Val(.AverageBitrateVarianceNumericUpDown.Value) & "k" & " -qcomp " & .QuantizerCompressionNumericUpDown.Value & _
                                    " -rc_lookahead " & .NumberofFramesforLookaheadNumericUpDown.Value & UseMBTreeV
                End If

                '------------------------
                ' Chroma M.E.
                '------------------------
                Dim ChromaMEV As String = ""
                If .ChromaMECheckBox.Checked = True Then
                    ChromaMEV = " -cmp -chroma"
                End If

                '------------------------
                ' MEMethod
                '------------------------
                Dim MEMethodV As String = ""
                If .MEMethodComboBox.Text = "Diamond" Then
                    MEMethodV = " -me_method epzs"
                ElseIf .MEMethodComboBox.Text = "Hexagon" Then
                    MEMethodV = " -me_method hex"
                ElseIf .MEMethodComboBox.Text = "Multi Hex" Then
                    MEMethodV = " -me_method umh"
                ElseIf .MEMethodComboBox.Text = "Exhaustive" Then
                    MEMethodV = " -me_method full"
                ElseIf .MEMethodComboBox.Text = "SATD Exhaustive" Then
                    MEMethodV = " -me_method tesa"
                End If

                '------------------------
                ' SubpixelME
                '------------------------
                Dim SubpixelMEV As String = ""
                If InStr(.SubpixelMEComboBox.Text, " ") <> 0 Then SubpixelMEV = " -subq " & Split(.SubpixelMEComboBox.Text, " ")(0)

                '------------------------
                ' Trellis
                '------------------------
                Dim TrellisV As String = ""
                If .ProfileComboBox.Text <> "Baseline Profile" Then
                    TrellisV = " -trellis " & Strings.Left(.TrellisComboBox.Text, 1)
                End If

                '------------------------
                ' NoMixedReferenceFrames
                '------------------------
                Dim NoMixedReferenceFramesV As String = ""
                If .NoMixedReferenceFramesCheckBox.Checked = True Then
                    NoMixedReferenceFramesV = " -flags2 -mixed_refs"
                Else
                    NoMixedReferenceFramesV = " -flags2 +mixed_refs"
                End If

                '------------------------
                ' NoFastPSkip
                '------------------------
                Dim NoFastPSkipV As String = ""
                If .NoFastPSkipCheckBox.Checked = True Then
                    NoFastPSkipV = " -flags2 -fastpskip"
                Else
                    NoFastPSkipV = " -flags2 +fastpskip"
                End If

                '------------------------
                ' NoPsychovisualEnhancements
                '------------------------
                Dim NoPsychovisualEnhancementsV As String = ""
                If .NoPsychovisualEnhancementsCheckBox.Checked = True Then
                    NoPsychovisualEnhancementsV = " -flags2 -psy"
                Else
                    NoPsychovisualEnhancementsV = " -flags2 +psy"
                End If

                '------------------------
                ' Macroblocks Adaptive8x8DCT
                '------------------------
                Dim Adaptive8x8DCTV As String = ""
                If .Adaptive8x8DCTCheckBox.Checked = True Then
                    Adaptive8x8DCTV = " -flags2 +dct8x8"
                Else
                    Adaptive8x8DCTV = " -flags2 -dct8x8"
                End If

                '------------------------
                ' Macroblocks
                '------------------------
                Dim MacroblocksV As String = ""
                Dim I4x4V As String = ""
                Dim P4x4V As String = ""
                Dim I8x8V As String = ""
                Dim P8x8V As String = ""
                Dim B8x8V As String = ""
                If .I4x4CheckBox.Checked = True Then
                    I4x4V = "+parti4x4"
                End If
                If .P4x4CheckBox.Checked = True Then
                    P4x4V = "+partp4x4"
                End If
                If .I8x8CheckBox.Checked = True Then
                    I8x8V = "+parti8x8"
                End If
                If .P8x8CheckBox.Checked = True Then
                    P8x8V = "+partp8x8"
                End If
                If .B8x8CheckBox.Checked = True Then
                    B8x8V = "+partb8x8"
                End If
                If I4x4V = "" AndAlso P4x4V = "" AndAlso I8x8V = "" AndAlso P8x8V = "" AndAlso B8x8V = "" Then
                    MacroblocksV = ""
                Else
                    MacroblocksV = " -partitions " & I4x4V & P4x4V & I8x8V & P8x8V & B8x8V
                End If

                '------------------------
                ' Useaccessunitdelimiters
                '------------------------
                Dim UseaccessunitdelimitersV As String = ""
                If .UseaccessunitdelimitersCheckBox.Checked = True Then
                    UseaccessunitdelimitersV = " -flags2 +aud"
                Else
                    UseaccessunitdelimitersV = " -flags2 -aud"
                End If

                '---------------------------------------------------------------------------------------------------------
                '모든모드공통
                x264optsV = " -threads " & .ThreadsNumericUpDown.Value & LevelComboBoxV & _
                            DeblockingCheckBoxV & CABACCheckBoxV & BFramesV & " -refs " & .ReferenceFramesNumericUpDown.Value & AdaptiveIFramesDecisionV & PframeWeightedPredictionV & _
                            " -qmin " & .QMinNumericUpDown.Value & " -qmax " & .QMaxNumericUpDown.Value & " -qdiff " & .QDeltaNumericUpDown.Value & " -i_qfactor " & .QIPRatioNumericUpDown.Value & " -b_qfactor " & .QPBRatioNumericUpDown.Value & " -chromaoffset " & .ChromaandLumaQPOffsetNumericUpDown.Value & RateControlMV & _
                            ChromaMEV & " -me_range " & .MERangeNumericUpDown.Value & MEMethodV & SubpixelMEV & TrellisV & " -psy_rd " & .PsyRDStrengthNumericUpDown.Value & " -psy_trellis " & .PsyTrellisStrengthNumericUpDown.Value & NoMixedReferenceFramesV & NoFastPSkipV & NoPsychovisualEnhancementsV & _
                            Adaptive8x8DCTV & MacroblocksV & " -nr " & .NoiseReductionNumericUpDown.Value & UseaccessunitdelimitersV

                If .FastfirstpassCheckBox.Checked = True Then '터보
                    x264opts_2passV = " -threads " & .ThreadsNumericUpDown.Value & LevelComboBoxV & _
                                 DeblockingCheckBoxV & CABACCheckBoxV & BFramesV & " -refs 1" & AdaptiveIFramesDecisionV & PframeWeightedPredictionV & _
                                 " -qmin " & .QMinNumericUpDown.Value & " -qmax " & .QMaxNumericUpDown.Value & " -qdiff " & .QDeltaNumericUpDown.Value & " -i_qfactor " & .QIPRatioNumericUpDown.Value & " -b_qfactor " & .QPBRatioNumericUpDown.Value & " -chromaoffset " & .ChromaandLumaQPOffsetNumericUpDown.Value & RateControlMV & _
                                 ChromaMEV & " -me_range 16 -me_method epzs -subq 1" & TrellisV & " -psy_rd " & .PsyRDStrengthNumericUpDown.Value & " -psy_trellis " & .PsyTrellisStrengthNumericUpDown.Value & NoMixedReferenceFramesV & NoFastPSkipV & NoPsychovisualEnhancementsV & _
                                 Adaptive8x8DCTV & MacroblocksV & " -nr " & .NoiseReductionNumericUpDown.Value & UseaccessunitdelimitersV

                Else
                    x264opts_2passV = x264optsV
                End If
                '---------------------------------------------------------------------------------------------------------

            End With
        End If
        If VideoCodecComboBox.Text = "H.264(AVC) x264 core" AndAlso AdvanOptsCheckBox.Checked = False Then '고급설정 사용 안 함
            x264optsV = " -threads " & x264optsFrm.ThreadsNumericUpDown.Value & " -level 13 -qmin 10 -qmax 51 -qdiff 4 -i_qfactor 1.4 -b_qfactor 1.3 -chromaoffset 0"
            x264opts_2passV = x264optsV
        End If

        '***********************************
        '  MPEG4 고급설정
        '***********************************
        Dim MPEG4optsV As String = ""
        If (VideoCodecComboBox.Text = "Xvid MPEG-4 Codec" OrElse _
        VideoCodecComboBox.Text = "DivX 4 Codec(Open Divx)" OrElse _
        VideoCodecComboBox.Text = "DivX 5 Codec" OrElse _
        VideoCodecComboBox.Text = "MPEG-4 Video") AndAlso AdvanOptsCheckBox.Checked = True Then
            With MPEG4optsFrm

                '------------------------
                ' Threads
                '------------------------
                Dim ThreadsV As String = ""
                If .ThreadsNumericUpDown.Value = 0 Then
                    ThreadsV = " -threads " & Environ("NUMBER_OF_PROCESSORS")
                Else
                    ThreadsV = " -threads " & .ThreadsNumericUpDown.Value
                End If

                '------------------------
                ' QuantizationType
                '------------------------
                Dim QuantizationTypeV As String = ""
                If .QuantizationTypeComboBox.Text = "H.263" Then
                    QuantizationTypeV = " -mpeg_quant 0"
                ElseIf .QuantizationTypeComboBox.Text = "MPEG" Then
                    QuantizationTypeV = " -mpeg_quant 1"
                End If

                '------------------------
                ' AdaptiveQuantization
                '------------------------
                Dim AdaptiveQuantizationV As String = ""
                If .AdaptiveQuantizationCheckBox.Checked = True Then
                    AdaptiveQuantizationV = " -lumi_mask 1"
                End If

                '------------------------
                ' InterlacedEncoding
                '------------------------
                Dim InterlacedEncodingV As String = ""
                If .InterlacedEncodingCheckBox.Checked = True Then
                    InterlacedEncodingV = " -flags +ilme"
                End If

                '------------------------
                ' Grayscale
                '------------------------
                Dim GrayscaleV As String = ""
                If .GrayscaleCheckBox.Checked = True Then
                    GrayscaleV = " -flags +gray"
                End If

                '------------------------
                ' TopFieldFirst
                '------------------------
                Dim TopFieldFirstV As String = ""
                If .TopFieldFirstCheckBox.Checked = True Then
                    TopFieldFirstV = " -top 1"
                End If

                '------------------------
                ' _4MotionVector
                '------------------------
                Dim _4MotionVectorV As String = ""
                If ._4MotionVectorCheckBox.Checked = True Then
                    _4MotionVectorV = " -flags +mv4"
                End If

                '------------------------
                ' QPEL
                '------------------------
                Dim QPELV As String = ""
                If .QPELCheckBox.Checked = True Then
                    QPELV = " -flags +qpel"
                End If

                '------------------------
                ' BFrames
                '------------------------
                Dim BFramesV As String = ""
                If .BFramesCheckBox.Checked = True Then
                    'ClosedGOPCheckBox
                    Dim ClosedGOPCheckBoxV As String = ""
                    If .ClosedGOPCheckBox.Checked = True Then
                        ClosedGOPCheckBoxV = " -flags +cgop -sc_threshold 1000000000"
                    End If
                    'DownscalesffdBfdCheckBox
                    Dim DownscalesffdBfdCheckBoxV As String = ""
                    If .DownscalesffdBfdCheckBox.Checked = True Then
                        DownscalesffdBfdCheckBoxV = " -brd_scale 1"
                    End If
                    'RefinettmvuibmCheckBox
                    Dim RefinettmvuibmCheckBoxV As String = ""
                    If .RefinettmvuibmCheckBox.Checked = True Then
                        RefinettmvuibmCheckBoxV = " -bidir_refine 1"
                    End If
                    BFramesV = " -bf " & .BVOPsNumericUpDown.Value & ClosedGOPCheckBoxV & DownscalesffdBfdCheckBoxV & RefinettmvuibmCheckBoxV
                End If

                '------------------------
                ' HQMode
                '------------------------
                Dim HQModeV As String = ""
                If .HQModeComboBox.Text = "MBCMP" Then
                    HQModeV = " -mbd 0"
                ElseIf .HQModeComboBox.Text = "FEWEST BITS" Then
                    HQModeV = " -mbd 1"
                ElseIf .HQModeComboBox.Text = "BEST RATE DISTORTION" Then
                    HQModeV = " -mbd 2"
                End If

                '------------------------
                ' Rate Control
                '------------------------
                'MinVBTextBox
                Dim MinVBTextBoxV As String = ""
                If .MinVBTextBox.Text <> "0" Then
                    MinVBTextBoxV = " -minrate " & .MinVBTextBox.Text & "k"
                End If
                'MaxVBTextBox
                Dim MaxVBTextBoxV As String = ""
                If .MaxVBTextBox.Text <> "0" Then
                    MaxVBTextBoxV = " -maxrate " & .MaxVBTextBox.Text & "k"
                End If
                'RCBufferSizeTextBox
                Dim RCBufferSizeTextBoxV As String = ""
                If .RCBufferSizeTextBox.Text <> "0" Then
                    RCBufferSizeTextBoxV = " -bufsize " & .RCBufferSizeTextBox.Text & "k"
                End If
                Dim RateControlV As String = ""
                If InStr(VideoModeComboBox.SelectedItem, "[1PASS-VBR]", CompareMethod.Text) <> 0 Then '퀀타이저
                Else
                    RateControlV = " -qmin " & .QMinNumericUpDown.Value & " -qmax " & .QMaxNumericUpDown.Value & " -qdiff " & .QDeltaNumericUpDown.Value & " -qcomp " & .QuantizerCompressionNumericUpDown.Value & " -qblur " & .QuantizerBlurNumericUpDown.Value & _
                                   MinVBTextBoxV & MaxVBTextBoxV & RCBufferSizeTextBoxV
                End If

                '------------------------
                ' TrellisQuantization
                '------------------------
                Dim TrellisQuantizationV As String = ""
                If .TrellisQuantizationCheckBox.Checked = True Then
                    TrellisQuantizationV = " -trellis 1"
                End If

                '---------------------------------------------------------------------------------------------------------
                '모든모드공통
                MPEG4optsV = ThreadsV & QuantizationTypeV & AdaptiveQuantizationV & InterlacedEncodingV & GrayscaleV & TopFieldFirstV & _4MotionVectorV & QPELV & _
                             BFramesV & " -dia_size " & LCase(.DiamondtsfmeComboBox.Text) & HQModeV & " -cmp " & LCase(.FpmcfComboBox.Text) & " -subcmp " & LCase(.SpmcfComboBox.Text) & " -mbcmp " & LCase(.McfComboBox.Text) & " -ildctcmp " & LCase(.IdcfComboBox.Text) & " -precmp " & LCase(.PmecfComboBox.Text) & _
                             RateControlV & TrellisQuantizationV & " -dct " & LCase(.DCTalgorithmComboBox.Text)
                '---------------------------------------------------------------------------------------------------------

            End With
        End If
        If (VideoCodecComboBox.Text = "Xvid MPEG-4 Codec" OrElse _
        VideoCodecComboBox.Text = "DivX 4 Codec(Open Divx)" OrElse _
        VideoCodecComboBox.Text = "DivX 5 Codec" OrElse _
        VideoCodecComboBox.Text = "MPEG-4 Video") AndAlso AdvanOptsCheckBox.Checked = False Then '고급설정 사용 안 함
            With MPEG4optsFrm
                '------------------------
                ' Threads
                '------------------------
                Dim ThreadsV As String = ""
                If .ThreadsNumericUpDown.Value = 0 Then
                    ThreadsV = " -threads " & Environ("NUMBER_OF_PROCESSORS")
                Else
                    ThreadsV = " -threads " & .ThreadsNumericUpDown.Value
                End If
                MPEG4optsV = ThreadsV
            End With
        End If

        '***********************************
        '  비디오 코덱
        '***********************************
        Dim VideoCodecComboBoxV As String = ""
        If VideoCodecComboBox.Text = "Xvid MPEG-4 Codec" Then
            VideoCodecComboBoxV = " -vcodec mpeg4 -vtag XVID"
        ElseIf VideoCodecComboBox.Text = "DivX 3 Codec" Then
            VideoCodecComboBoxV = " -vcodec msmpeg4 -vtag DIV3"
        ElseIf VideoCodecComboBox.Text = "DivX 4 Codec(Open Divx)" Then
            VideoCodecComboBoxV = " -vcodec mpeg4 -vtag DIVX"
        ElseIf VideoCodecComboBox.Text = "DivX 5 Codec" Then
            VideoCodecComboBoxV = " -vcodec mpeg4 -vtag DX50"
        ElseIf VideoCodecComboBox.Text = "Microsoft MPEG-4 v2" Then
            VideoCodecComboBoxV = " -vcodec msmpeg4v2 -vtag MP42"
        ElseIf VideoCodecComboBox.Text = "Microsoft MPEG-4 v3" Then
            VideoCodecComboBoxV = " -vcodec msmpeg4 -vtag MP43"
        ElseIf VideoCodecComboBox.Text = "ITU-T H.263 Version 2(H.263+)" Then
            VideoCodecComboBoxV = " -vcodec h263p -vtag H263"
        ElseIf VideoCodecComboBox.Text = "MPEG-4 Video" Then
            VideoCodecComboBoxV = " -vcodec mpeg4"
        ElseIf VideoCodecComboBox.Text = "ITU-T H.263" Then
            VideoCodecComboBoxV = " -vcodec h263"
        ElseIf VideoCodecComboBox.Text = "Theora Video Codec" Then
            VideoCodecComboBoxV = " -vcodec libtheora"
        ElseIf VideoCodecComboBox.Text = "Windows Media Video 7" Then
            VideoCodecComboBoxV = " -vcodec wmv1"
        ElseIf VideoCodecComboBox.Text = "Windows Media Video 8" Then
            VideoCodecComboBoxV = " -vcodec wmv2"
        ElseIf VideoCodecComboBox.Text = "Huffyuv Lossless Video Codec" Then
            VideoCodecComboBoxV = " -vcodec huffyuv"
        ElseIf VideoCodecComboBox.Text = "MPEG-1 Video" Then
            VideoCodecComboBoxV = " -vcodec mpeg1video"
        ElseIf VideoCodecComboBox.Text = "MPEG-2 Video" Then
            VideoCodecComboBoxV = " -vcodec mpeg2video"
        ElseIf VideoCodecComboBox.Text = "Sorenson H.263" Then
            VideoCodecComboBoxV = " -vcodec flv"
        ElseIf VideoCodecComboBox.Text = "VP8 Codec(libvpx)" Then
            VideoCodecComboBoxV = " -vcodec libvpx"
        ElseIf VideoCodecComboBox.Text = "ITU-T H.261" Then
            VideoCodecComboBoxV = " -vcodec h261"
        ElseIf VideoCodecComboBox.Text = "RealVideo 1.0" Then
            VideoCodecComboBoxV = " -vcodec rv10"
        ElseIf VideoCodecComboBox.Text = "RealVideo G2" Then
            VideoCodecComboBoxV = " -vcodec rv20"
        End If
        'Xvid 
        If VideoCodecComboBox.Text = "Xvid MPEG-4 Codec(Xvid Core)" Then
            If InStr(OutFComboBox.SelectedItem, "[3GP]", CompareMethod.Text) <> 0 OrElse _
            InStr(OutFComboBox.SelectedItem, "[3G2]", CompareMethod.Text) <> 0 OrElse _
            InStr(OutFComboBox.SelectedItem, "[MP4]", CompareMethod.Text) <> 0 OrElse _
            InStr(OutFComboBox.SelectedItem, "[MOV]", CompareMethod.Text) <> 0 Then
                VideoCodecComboBoxV = " -vcodec libxvid"
            Else
                VideoCodecComboBoxV = " -vcodec libxvid -vtag XVID"
            End If
        End If
        'x264
        If VideoCodecComboBox.Text = "H.264(AVC) x264 core" Then
            If InStr(OutFComboBox.SelectedItem, "[3GP]", CompareMethod.Text) <> 0 OrElse _
            InStr(OutFComboBox.SelectedItem, "[3G2]", CompareMethod.Text) <> 0 OrElse _
            InStr(OutFComboBox.SelectedItem, "[MP4]", CompareMethod.Text) <> 0 OrElse _
            InStr(OutFComboBox.SelectedItem, "[MOV]", CompareMethod.Text) <> 0 OrElse _
            InStr(OutFComboBox.SelectedItem, "[FLV]", CompareMethod.Text) <> 0 Then
                VideoCodecComboBoxV = " -vcodec libx264"
            Else
                VideoCodecComboBoxV = " -vcodec libx264 -vtag H264"
            End If
        End If

        '***********************************
        '  비디오 비트레이트
        '***********************************
        Dim VideoModeComboBoxV As String = ""
        If VideoModeComboBox.SelectedIndex = VideoModeComboBox.FindString("[1PASS-CBR]", -1) Then
            VideoModeComboBoxV = " -b " & BitrateComboBox.Text & "k"
        ElseIf VideoModeComboBox.SelectedIndex = VideoModeComboBox.FindString("[1PASS-CQP]", -1) Then
            VideoModeComboBoxV = " -cqp " & QuantizerCQPNumericUpDown.Value
        ElseIf VideoModeComboBox.SelectedIndex = VideoModeComboBox.FindString("[1PASS-CRF]", -1) Then
            VideoModeComboBoxV = " -crf " & QualityNumericUpDown.Value
        ElseIf VideoModeComboBox.SelectedIndex = VideoModeComboBox.FindString("[1PASS-VBR]", -1) Then
            VideoModeComboBoxV = " -qscale " & QuantizerNumericUpDown.Value
        ElseIf VideoModeComboBox.SelectedIndex = VideoModeComboBox.FindString("[2PASS-CBR]", -1) Then
            VideoModeComboBoxV = " -b " & BitrateComboBox.Text & "k"
        ElseIf VideoModeComboBox.SelectedIndex = VideoModeComboBox.FindString("[LOSSLESS]", -1) Then
            VideoModeComboBoxV = ""
        End If

        '***********************************
        '  비디오 프레임
        '***********************************
        Dim FramerateComboBoxV As String = ""
        If FramerateCheckBox.Checked = False Then
            FramerateComboBoxV = " -r " & FramerateComboBox.Text
        End If

        '***********************************
        '  키프레임
        '***********************************
        Dim GOPSizeCheckBoxV As String = ""
        Dim GOPSizeCheckBox2V As String = ""
        If GOPSizeCheckBox.Checked = True Then
            GOPSizeCheckBoxV = " -g " & GOPSizeTextBox.Text
            GOPSizeCheckBox2V = " -keyint_min " & MinGOPSizeTextBox.Text
        End If

        '***********************************
        '  PSP
        '***********************************
        Dim PSPMP4CheckBoxV As String = ""
        If PSPMP4CheckBox.Checked = True AndAlso InStr(OutFComboBox.SelectedItem, "[MP4]", CompareMethod.Text) <> 0 Then
            PSPMP4CheckBoxV = " -f psp"
        End If

        '***********************************
        '리사이즈 필터 설정 (FFmpeg)
        '***********************************
        Dim SwscaleV As String = ""
        If ImageSizeCheckBox.Checked = False Then
            SwscaleV = " -sws_flags " & LCase(FFmpegResizeFilterComboBox.Text)
        End If

        '***********************************
        '  오디오 코덱
        '***********************************
        Dim AudioCodecComboBoxV As String = ""
        If AudioCodecComboBox.Text = "MPEG-1 Audio layer 2(MP2)" OrElse AudioCodecComboBox.Text = "[MP2] MPEG-1 Audio layer 2(MP2)" Then
            AudioCodecComboBoxV = " -acodec mp2"
        ElseIf AudioCodecComboBox.Text = "MPEG-1 Audio layer 3(MP3) Lame" OrElse AudioCodecComboBox.Text = "[MP3] MPEG-1 Audio layer 3(MP3) Lame" Then
            AudioCodecComboBoxV = " -acodec libmp3lame"
        ElseIf AudioCodecComboBox.Text = "FAAC" OrElse AudioCodecComboBox.Text = "[MP4] FAAC" OrElse AudioCodecComboBox.Text = "[M4A] FAAC" Then
            AudioCodecComboBoxV = " -acodec libfaac"
        ElseIf AudioCodecComboBox.Text = "Nero AAC" OrElse AudioCodecComboBox.Text = "[MP4] Nero AAC" Then
            AudioCodecComboBoxV = " -acodec pcm_s16le"
        ElseIf AudioCodecComboBox.Text = "AMR-NB(libopencore)" OrElse AudioCodecComboBox.Text = "[AMR] AMR-NB(libopencore)" Then
            AudioCodecComboBoxV = " -acodec libopencore_amrnb"
        ElseIf AudioCodecComboBox.Text = "Dolby Digital Audio Coding-3(AC3)" OrElse AudioCodecComboBox.Text = "[AC3] Dolby Digital Audio Coding-3(AC3)" Then
            AudioCodecComboBoxV = " -acodec ac3"
        ElseIf AudioCodecComboBox.Text = "Vorbis" OrElse AudioCodecComboBox.Text = "[OGG] Vorbis" Then
            AudioCodecComboBoxV = " -acodec libvorbis"
        ElseIf AudioCodecComboBox.Text = "Windows Media Audio 1" OrElse AudioCodecComboBox.Text = "[WMA] Windows Media Audio 1" Then
            AudioCodecComboBoxV = " -acodec wmav1"
        ElseIf AudioCodecComboBox.Text = "Windows Media Audio 2" OrElse AudioCodecComboBox.Text = "[WMA] Windows Media Audio 2" Then
            AudioCodecComboBoxV = " -acodec wmav2"
        ElseIf AudioCodecComboBox.Text = "Free Lossless Audio Codec(FLAC)" OrElse AudioCodecComboBox.Text = "[FLAC] Free Lossless Audio Codec(FLAC)" Then
            AudioCodecComboBoxV = " -acodec flac"
        ElseIf AudioCodecComboBox.Text = "signed 16-bit little-endian PCM" OrElse AudioCodecComboBox.Text = "[WAV] signed 16-bit little-endian PCM" Then
            AudioCodecComboBoxV = " -acodec pcm_s16le"
        End If

        '***********************************
        ' AviSynth 오디오채널
        '***********************************
        Dim AviSynthChComboBoxV As String = ""
        If AudioCodecComboBox.Text = "AMR-NB(libopencore)" OrElse AudioCodecComboBox.Text = "[AMR] AMR-NB(libopencore)" Then 'AMR 일경우 예외로 1채널
            AviSynthChComboBoxV = " -ac 1"
        End If

        '***********************************
        ' FFmpeg 오디오채널
        '***********************************
        Dim FFmpegChComboBoxV As String = ""
        If AudioCodecComboBox.Text = "AMR-NB(libopencore)" OrElse AudioCodecComboBox.Text = "[AMR] AMR-NB(libopencore)" Then 'AMR 일경우 예외로 1채널
            FFmpegChComboBoxV = " -ac 1"
        Else
            If FFmpegChComboBox.Text = LangCls.EncSetch10ComboBox Then
                FFmpegChComboBoxV = " -ac 1"
            ElseIf FFmpegChComboBox.Text = LangCls.EncSetch20ComboBox Then
                FFmpegChComboBoxV = " -ac 2"
            ElseIf FFmpegChComboBox.Text = LangCls.EncSetch51ComboBox Then
                FFmpegChComboBoxV = " -ac 6"
            End If
        End If

        '***********************************
        ' 오디오 샘플레이트
        '***********************************
        Dim SamplerateComboBoxV As String = ""
        If AudioCodecComboBox.Text = "AMR-NB(libopencore)" OrElse AudioCodecComboBox.Text = "[AMR] AMR-NB(libopencore)" Then 'AMR 일경우 예외로 8000Hz
            SamplerateComboBoxV = " -ar 8000"
        Else
            If SamplerateCheckBox.Checked = False Then SamplerateComboBoxV = " -ar " & SamplerateComboBox.Text
        End If

        '***********************************
        ' 오디오 비트레이트
        '***********************************
        Dim AudioBitrateComboBoxV As String = ""
        If AudioCodecComboBox.Text = "Free Lossless Audio Codec(FLAC)" OrElse _
           AudioCodecComboBox.Text = "[FLAC] Free Lossless Audio Codec(FLAC)" OrElse _
           AudioCodecComboBox.Text = "signed 16-bit little-endian PCM" OrElse _
           AudioCodecComboBox.Text = "[WAV] signed 16-bit little-endian PCM" Then
            '설정불가

        ElseIf AudioCodecComboBox.Text = "Nero AAC" OrElse AudioCodecComboBox.Text = "[MP4] Nero AAC" Then
            '설정불가

        ElseIf AudioCodecComboBox.Text = "Vorbis" OrElse AudioCodecComboBox.Text = "[OGG] Vorbis" Then
            AudioBitrateComboBoxV = " -aq " & VorbisQNumericUpDown.Value

        ElseIf AudioCodecComboBox.Text = "AMR-NB(libopencore)" OrElse AudioCodecComboBox.Text = "[AMR] AMR-NB(libopencore)" Then
            AudioBitrateComboBoxV = " -ab " & AMRBitrateComboBox.Text & "k"

        Else
            AudioBitrateComboBoxV = " -ab " & AudioBitrateComboBox.Text & "k"

        End If

        '***********************************
        ' 오디오 증폭
        '***********************************
        Dim AudioVolNumericUpDownV As String = ""
        AudioVolNumericUpDownV = " -vol " & AudioVolNumericUpDown.Value

        '***********************************
        ' 컨테이너(포맷)설정
        '***********************************
        Dim FormatV As String = ""
        If InStr(OutFComboBox.SelectedItem, "[AVI]", CompareMethod.Text) <> 0 Then
            FormatV = " -f avi"
        ElseIf InStr(OutFComboBox.SelectedItem, "[3GP]", CompareMethod.Text) <> 0 Then
            FormatV = " -f 3gp"
        ElseIf InStr(OutFComboBox.SelectedItem, "[3G2]", CompareMethod.Text) <> 0 Then
            FormatV = " -f 3g2"
        ElseIf InStr(OutFComboBox.SelectedItem, "[MP4]", CompareMethod.Text) <> 0 Then
            If PSPMP4CheckBox.Checked = False Then 'PSP모드 아니면
                FormatV = " -f mp4"
            End If
        ElseIf InStr(OutFComboBox.SelectedItem, "[MOV]", CompareMethod.Text) <> 0 Then
            FormatV = " -f mov"
        ElseIf InStr(OutFComboBox.SelectedItem, "[MKV]", CompareMethod.Text) <> 0 Then
            FormatV = " -f matroska"
        ElseIf InStr(OutFComboBox.SelectedItem, "[ASF]", CompareMethod.Text) <> 0 Then
            FormatV = " -f asf"
        ElseIf InStr(OutFComboBox.SelectedItem, "[WMV]", CompareMethod.Text) <> 0 Then
            FormatV = " -f asf"
        ElseIf InStr(OutFComboBox.SelectedItem, "[RM]", CompareMethod.Text) <> 0 Then
            FormatV = " -f rm"
        ElseIf InStr(OutFComboBox.SelectedItem, "[MPEG]", CompareMethod.Text) <> 0 Then
            FormatV = " -f mpeg"
        ElseIf InStr(OutFComboBox.SelectedItem, "[FLV]", CompareMethod.Text) <> 0 Then
            FormatV = " -f flv"
        ElseIf InStr(OutFComboBox.SelectedItem, "[SWF]", CompareMethod.Text) <> 0 Then
            FormatV = " -f swf"
        ElseIf InStr(OutFComboBox.SelectedItem, "[WEBM]", CompareMethod.Text) <> 0 Then
            FormatV = " -f webm"
        ElseIf InStr(OutFComboBox.SelectedItem, "[AUDIO]", CompareMethod.Text) <> 0 Then

            If AudioCodecComboBox.Text = "[MP2] MPEG-1 Audio layer 2(MP2)" Then
                FormatV = " -f mp2"
            ElseIf AudioCodecComboBox.Text = "[MP3] MPEG-1 Audio layer 3(MP3) Lame" Then
                FormatV = " -f mp3"
            ElseIf AudioCodecComboBox.Text = "[MP4] FAAC" Then
                FormatV = " -f mp4"
            ElseIf AudioCodecComboBox.Text = "[M4A] FAAC" Then
                FormatV = " -f ipod"
            ElseIf AudioCodecComboBox.Text = "[MP4] Nero AAC" Then
                FormatV = "" '네로 AAC 예외//
            ElseIf AudioCodecComboBox.Text = "[AMR] AMR-NB(libopencore)" Then
                FormatV = " -f amr"
            ElseIf AudioCodecComboBox.Text = "[AC3] Dolby Digital Audio Coding-3(AC3)" Then
                FormatV = " -f ac3"
            ElseIf AudioCodecComboBox.Text = "[OGG] Vorbis" Then
                FormatV = " -f ogg"
            ElseIf AudioCodecComboBox.Text = "[WMA] Windows Media Audio 1" Then
                FormatV = " -f asf"
            ElseIf AudioCodecComboBox.Text = "[WMA] Windows Media Audio 2" Then
                FormatV = " -f asf"
            ElseIf AudioCodecComboBox.Text = "[FLAC] Free Lossless Audio Codec(FLAC)" Then
                FormatV = " -f flac"
            ElseIf AudioCodecComboBox.Text = "[WAV] signed 16-bit little-endian PCM" Then
                FormatV = " -f wav"
            End If

        End If

        '***********************************
        ' 용량 제한
        '***********************************
        Dim SizeLimitTextBoxV As String = ""
        If AudioCodecComboBox.Text = "Nero AAC" Then 'Nero AAC 는 MUX 때 용량 제한.
        Else
            If Val(SizeLimitTextBox.Text) <> 0 Then
                SizeLimitTextBoxV = " -fs " & Val(SizeLimitTextBox.Text) * Val(1048576)
            End If
        End If

        '***********************************
        ' 추가명령어
        '***********************************
        Dim FFmpegCommandTextBoxV As String = ""
        If FFmpegCommandTextBox.Text <> "" Then
            FFmpegCommandTextBoxV = " " & FFmpegCommandTextBox.Text
        End If

        '***********************************
        ' 디인터레이스
        '***********************************
        Dim DeinterlaceCheckBoxV As String = ""
        If DeinterlaceCheckBox.Checked = True Then
            DeinterlaceCheckBoxV = " -deinterlace"
        End If

        '***********************************
        ' 비디오필터 unsharp
        '***********************************
        If FFmpegImageUnsharpCheckBox.Checked = True Then
            MainFrm.VF_unsharpVTextBox = ", unsharp=" & LumaMatrixHSNumericUpDown.Value & ":" & LumaMatrixVSNumericUpDown.Value & ":" & _
                                               LumaEffectSNumericUpDown.Value & ":" & ChromaMatrixHSNumericUpDown.Value & ":" & _
                                               ChromaMatrixVSNumericUpDown.Value & ":" & ChromaEffectSNumericUpDown.Value
        Else
            MainFrm.VF_unsharpVTextBox = ""
        End If






        '===================================================================================================================================






        'Nero AAC // 컨테이너 지정에서 예외됨.
        If AudioCodecComboBox.Text = "Nero AAC" OrElse AudioCodecComboBox.Text = "[MP4] Nero AAC" Then

            '---------------------------------------
            ' Nero AAC 프로필
            '---------------------------------------
            Dim NeroProfileV As String = ""
            If NeroAACProfileComboBox.Text = "Automatically" Then
                NeroProfileV = ""
            ElseIf NeroAACProfileComboBox.Text = "AAC LC" Then
                NeroProfileV = " -lc"
            ElseIf NeroAACProfileComboBox.Text = "HE-AAC (AAC LC-SBR)" Then
                NeroProfileV = " -he"
            ElseIf NeroAACProfileComboBox.Text = "HE-AAC v2 (AAC LC-SBR+PS)" Then
                NeroProfileV = " -hev2"
            End If
            '---------------------------------------
            ' Nero AAC ABR, CBR, VBR
            '---------------------------------------
            Dim NeroBitrateV As String = ""
            If NeroAACABRRadioButton.Checked = True Then 'ABR
                NeroBitrateV = " -br " & NeroAACBitrateNumericUpDown.Value & "000"
            ElseIf NeroAACCBRRadioButton.Checked = True Then 'CBR
                NeroBitrateV = " -cbr " & NeroAACBitrateNumericUpDown.Value & "000"
            ElseIf NeroAACVBRRadioButton.Checked = True Then 'VBR
                NeroBitrateV = " -q " & NeroAACQNumericUpDown.Value
            End If
            '---------------------------------------

            MainFrm.NeroAACSTRAviSynth = " -f wav -vn" & AudioCodecComboBoxV & SamplerateComboBoxV & " - | "

            MainFrm.NeroAACSTRFFmpeg = " -f wav -vn" & AudioCodecComboBoxV & SamplerateComboBoxV & _
                                                        FFmpegChComboBoxV & AudioVolNumericUpDownV & " - | "

            MainFrm.NeroAACSTRNEP = " -ignorelength -if -" & NeroProfileV & NeroBitrateV & " -of "

        End If
        'Nero AAC //






        If InStr(OutFComboBox.SelectedItem, "[AUDIO]", CompareMethod.Text) <> 0 Then '오디오만 인코딩


            MainFrm.AviSynthCommandStr = FormatV & AudioCodecComboBoxV & SamplerateComboBoxV & AviSynthChComboBoxV & AudioBitrateComboBoxV & _
                                              SizeLimitTextBoxV & FFmpegCommandTextBoxV

            MainFrm.FFmpegCommandStr = FormatV & " -vn" & AudioCodecComboBoxV & SamplerateComboBoxV & FFmpegChComboBoxV & AudioBitrateComboBoxV & _
                                                          AudioVolNumericUpDownV & SizeLimitTextBoxV & FFmpegCommandTextBoxV


        Else '비디오와 오디오 인코딩


            MainFrm.AviSynthCommandStr = FormatV & VideoCodecComboBoxV & VideoModeComboBoxV & GOPSizeCheckBoxV & GOPSizeCheckBox2V & _
                                            PSPMP4CheckBoxV & _
                                            AudioCodecComboBoxV & SamplerateComboBoxV & AviSynthChComboBoxV & AudioBitrateComboBoxV & _
                                            SizeLimitTextBoxV & FFmpegCommandTextBoxV & _
                                            x264optsV & MPEG4optsV

            MainFrm.AviSynthCommand2PassStr = FormatV & " -an -pass 1" & VideoCodecComboBoxV & VideoModeComboBoxV & GOPSizeCheckBoxV & GOPSizeCheckBox2V & _
                                                 FFmpegCommandTextBoxV & _
                                                 x264opts_2passV & MPEG4optsV

            MainFrm.FFmpegCommandStr = FormatV & VideoCodecComboBoxV & VideoModeComboBoxV & FramerateComboBoxV & GOPSizeCheckBoxV & GOPSizeCheckBox2V & _
                                            PSPMP4CheckBoxV & SwscaleV & _
                                            AudioCodecComboBoxV & SamplerateComboBoxV & FFmpegChComboBoxV & AudioBitrateComboBoxV & AudioVolNumericUpDownV & _
                                            SizeLimitTextBoxV & DeinterlaceCheckBoxV & FFmpegCommandTextBoxV & _
                                            x264optsV & MPEG4optsV

            MainFrm.FFmpegCommand2PassStr = FormatV & " -an -pass 1" & VideoCodecComboBoxV & VideoModeComboBoxV & FramerateComboBoxV & GOPSizeCheckBoxV & GOPSizeCheckBox2V & _
                                                 SwscaleV & _
                                                 DeinterlaceCheckBoxV & FFmpegCommandTextBoxV & _
                                                 x264opts_2passV & MPEG4optsV

        End If




    End Sub
    Private Sub OKBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKBTN.Click

        '특수문자
        Dim TCharI As Integer
        TCharI = InStr(HeaderTextBox.Text, "\")
        If TCharI = 0 Then
            TCharI = InStr(HeaderTextBox.Text, "/")
        End If
        If TCharI = 0 Then
            TCharI = InStr(HeaderTextBox.Text, ":")
        End If
        If TCharI = 0 Then
            TCharI = InStr(HeaderTextBox.Text, "*")
        End If
        If TCharI = 0 Then
            TCharI = InStr(HeaderTextBox.Text, "?")
        End If
        If TCharI = 0 Then
            TCharI = InStr(HeaderTextBox.Text, "<")
        End If
        If TCharI = 0 Then
            TCharI = InStr(HeaderTextBox.Text, ">")
        End If
        If TCharI = 0 Then
            TCharI = InStr(HeaderTextBox.Text, "|")
        End If

        If TCharI = 0 Then
            TCharI = InStr(ExtensionTextBox.Text, "\")
        End If
        If TCharI = 0 Then
            TCharI = InStr(ExtensionTextBox.Text, "/")
        End If
        If TCharI = 0 Then
            TCharI = InStr(ExtensionTextBox.Text, ":")
        End If
        If TCharI = 0 Then
            TCharI = InStr(ExtensionTextBox.Text, "*")
        End If
        If TCharI = 0 Then
            TCharI = InStr(ExtensionTextBox.Text, "?")
        End If
        If TCharI = 0 Then
            TCharI = InStr(ExtensionTextBox.Text, "<")
        End If
        If TCharI = 0 Then
            TCharI = InStr(ExtensionTextBox.Text, ">")
        End If
        If TCharI = 0 Then
            TCharI = InStr(ExtensionTextBox.Text, "|")
        End If

        If TCharI > 0 Then
            MsgBox(LangCls.EncSetCharERR)
            Exit Sub
        End If

        '=================================

        XML_CHANGE(My.Application.Info.DirectoryPath & "\settings.xml")
        Close()
    End Sub

    Private Sub CancelBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBTN.Click
        Close()
    End Sub

    Private Sub FFmpegImageUnsharpCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FFmpegImageUnsharpCheckBox.CheckedChanged
        If FFmpegImageUnsharpCheckBox.Checked = True Then
            FFmpegImageUnsharpLabel.Enabled = True

            LumaMatrixHSButton.Enabled = True
            LumaMatrixVSButton.Enabled = True
            LumaEffectSButton.Enabled = True
            ChromaMatrixHSButton.Enabled = True
            ChromaMatrixVSButton.Enabled = True
            ChromaEffectSButton.Enabled = True
            LumaMatrixHSButton.Enabled = True
            LumaMatrixVSButton.Enabled = True

            LumaEffectSTrackBar.Enabled = True
            ChromaMatrixHSTrackBar.Enabled = True
            ChromaMatrixVSTrackBar.Enabled = True
            ChromaEffectSTrackBar.Enabled = True
            ChromaMatrixVSTrackBar.Enabled = True
            ChromaEffectSTrackBar.Enabled = True
            LumaMatrixHSTrackBar.Enabled = True
            LumaMatrixVSTrackBar.Enabled = True

            LumaEffectSNumericUpDown.Enabled = True
            ChromaMatrixHSNumericUpDown.Enabled = True
            ChromaMatrixVSNumericUpDown.Enabled = True
            ChromaEffectSNumericUpDown.Enabled = True
            ChromaMatrixVSNumericUpDown.Enabled = True
            ChromaEffectSNumericUpDown.Enabled = True
            LumaMatrixHSNumericUpDown.Enabled = True
            LumaMatrixVSNumericUpDown.Enabled = True
        Else
            FFmpegImageUnsharpLabel.Enabled = False

            LumaMatrixHSButton.Enabled = False
            LumaMatrixVSButton.Enabled = False
            LumaEffectSButton.Enabled = False
            ChromaMatrixHSButton.Enabled = False
            ChromaMatrixVSButton.Enabled = False
            ChromaEffectSButton.Enabled = False
            LumaMatrixHSButton.Enabled = False
            LumaMatrixVSButton.Enabled = False

            LumaEffectSTrackBar.Enabled = False
            ChromaMatrixHSTrackBar.Enabled = False
            ChromaMatrixVSTrackBar.Enabled = False
            ChromaEffectSTrackBar.Enabled = False
            ChromaMatrixVSTrackBar.Enabled = False
            ChromaEffectSTrackBar.Enabled = False
            LumaMatrixHSTrackBar.Enabled = False
            LumaMatrixVSTrackBar.Enabled = False

            LumaEffectSNumericUpDown.Enabled = False
            ChromaMatrixHSNumericUpDown.Enabled = False
            ChromaMatrixVSNumericUpDown.Enabled = False
            ChromaEffectSNumericUpDown.Enabled = False
            ChromaMatrixVSNumericUpDown.Enabled = False
            ChromaEffectSNumericUpDown.Enabled = False
            LumaMatrixHSNumericUpDown.Enabled = False
            LumaMatrixVSNumericUpDown.Enabled = False
        End If
    End Sub


    Private Sub GOPSizeTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles GOPSizeTextBox.KeyPress
        If FunctionCls.InputCheck_NUMBER(e, True, False) = True Then e.Handled = True
    End Sub

    Private Sub GOPSizeTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GOPSizeTextBox.LostFocus
        If GOPSizeTextBox.Text <> "" Then GOPSizeTextBox.Text = Val(GOPSizeTextBox.Text)
    End Sub

    Private Sub GOPSizeTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GOPSizeTextBox.TextChanged

    End Sub

    Private Sub MinGOPSizeTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MinGOPSizeTextBox.KeyPress
        If FunctionCls.InputCheck_NUMBER(e, True, False) = True Then e.Handled = True
    End Sub

    Private Sub MinGOPSizeTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MinGOPSizeTextBox.LostFocus
        If MinGOPSizeTextBox.Text <> "" Then MinGOPSizeTextBox.Text = Val(MinGOPSizeTextBox.Text)
    End Sub

    Private Sub MinGOPSizeTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinGOPSizeTextBox.TextChanged

    End Sub

    Private Sub AspectWTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AspectWTextBox.KeyPress
        If FunctionCls.InputCheck_NUMBER(e, True, False) = True Then e.Handled = True
    End Sub

    Private Sub AspectWTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles AspectWTextBox.LostFocus
        If AspectWTextBox.Text <> "" Then AspectWTextBox.Text = Val(AspectWTextBox.Text)
    End Sub

    Private Sub AspectWTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AspectWTextBox.TextChanged

    End Sub

    Private Sub AspectHTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AspectHTextBox.KeyPress
        If FunctionCls.InputCheck_NUMBER(e, True, False) = True Then e.Handled = True
    End Sub

    Private Sub AspectHTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles AspectHTextBox.LostFocus
        If AspectHTextBox.Text <> "" Then AspectHTextBox.Text = Val(AspectHTextBox.Text)
    End Sub

    Private Sub AspectHTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AspectHTextBox.TextChanged

    End Sub

    Private Sub ImageSizeWidthTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ImageSizeWidthTextBox.KeyPress
        If FunctionCls.InputCheck_NUMBER(e, False, False) = True Then e.Handled = True
    End Sub

    Private Sub ImageSizeWidthTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ImageSizeWidthTextBox.LostFocus
        If ImageSizeWidthTextBox.Text <> "" Then ImageSizeWidthTextBox.Text = Val(ImageSizeWidthTextBox.Text)
    End Sub

    Private Sub ImageSizeWidthTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImageSizeWidthTextBox.TextChanged

    End Sub

    Private Sub ImageSizeHeightTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ImageSizeHeightTextBox.KeyPress
        If FunctionCls.InputCheck_NUMBER(e, False, False) = True Then e.Handled = True
    End Sub

    Private Sub ImageSizeHeightTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ImageSizeHeightTextBox.LostFocus
        If ImageSizeHeightTextBox.Text <> "" Then ImageSizeHeightTextBox.Text = Val(ImageSizeHeightTextBox.Text)
    End Sub

    Private Sub SizeLimitTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SizeLimitTextBox.KeyPress
        If FunctionCls.InputCheck_NUMBER(e, True, False) = True Then e.Handled = True
    End Sub

    Private Sub SizeLimitTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles SizeLimitTextBox.LostFocus
        If SizeLimitTextBox.Text <> "" Then SizeLimitTextBox.Text = Val(SizeLimitTextBox.Text)
    End Sub

    Private Sub AdvanOptsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdvanOptsButton.Click
        If VideoCodecComboBox.Text = "H.264(AVC) x264 core" Then
            x264optsFrm.ShowDialog(Me)
        ElseIf VideoCodecComboBox.Text = "Xvid MPEG-4 Codec" OrElse _
        VideoCodecComboBox.Text = "DivX 4 Codec(Open Divx)" OrElse _
         VideoCodecComboBox.Text = "DivX 5 Codec" OrElse _
         VideoCodecComboBox.Text = "MPEG-4 Video" Then
            MPEG4optsFrm.ShowDialog(Me)
        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub EncSetPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles EncSetPanel.Paint

    End Sub

    Private Sub AdvanOptsCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdvanOptsCheckBox.CheckedChanged
        If AdvanOptsCheckBox.Checked = True Then
            AdvanOptsLabel.Enabled = True
            AdvanOptsButton.Enabled = True
        Else
            AdvanOptsLabel.Enabled = False
            AdvanOptsButton.Enabled = False
        End If
    End Sub

    Private Sub BitrateComboBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles BitrateComboBox.KeyPress
        If FunctionCls.InputCheck_NUMBER(e, False, False) = True Then e.Handled = True
    End Sub

    Private Sub AudioBitrateComboBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AudioBitrateComboBox.KeyPress
        If FunctionCls.InputCheck_NUMBER(e, False, False) = True Then e.Handled = True
    End Sub

    Private Sub AudioBitrateComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AudioBitrateComboBox.SelectedIndexChanged

    End Sub

    Private Sub SamplerateComboBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SamplerateComboBox.KeyPress
        If FunctionCls.InputCheck_NUMBER(e, False, False) = True Then e.Handled = True
    End Sub

    Private Sub SamplerateComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SamplerateComboBox.SelectedIndexChanged

    End Sub

    Private Sub SizeLimitTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SizeLimitTextBox.TextChanged

    End Sub

    Private Sub ExtensionTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExtensionTextBox.TextChanged

    End Sub

    Private Sub EncSetFrm_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        BitrateComboBox.SelectionLength = 0 '포커스 이동
    End Sub

    Private Sub CropTTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If FunctionCls.InputCheck_NUMBER(e, False, False) = True Then e.Handled = True
    End Sub

    Private Sub CropTTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CropLTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If FunctionCls.InputCheck_NUMBER(e, False, False) = True Then e.Handled = True
    End Sub

    Private Sub CropLTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CropRTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If FunctionCls.InputCheck_NUMBER(e, False, False) = True Then e.Handled = True
    End Sub

    Private Sub CropRTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CropBTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If FunctionCls.InputCheck_NUMBER(e, False, False) = True Then e.Handled = True
    End Sub

    Private Sub CropBTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SamplerateCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SamplerateCheckBox.CheckedChanged

        If SamplerateCheckBox.Checked = True Then
            SamplerateLabel.Enabled = False
            SamplerateLabel2.Enabled = False
            SamplerateComboBox.Enabled = False
        Else
            SamplerateLabel.Enabled = True
            SamplerateLabel2.Enabled = True
            SamplerateComboBox.Enabled = True
        End If

    End Sub

    Private Sub ImgToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ImagePPFrm.ShowDialog(Me)
    End Sub

    Private Sub AudToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AudioPPFrm.ShowDialog(Me)
    End Sub

    Private Sub SubToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SubtitleFrm.ShowDialog(Me)
    End Sub

    Private Sub PresetButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PresetButton.Click
        MainFrm.PresetContextMenuStrip.Show(Control.MousePosition)
    End Sub

End Class