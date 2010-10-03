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

Public Class x264optsFrm

    Private Sub DefBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefBTN.Click

        'Main
        ThreadsNumericUpDown.Value = 0
        ProfileComboBox.Text = "Baseline Profile"
        LevelComboBox.Text = "Unrestricted AutoGuess"
        FastfirstpassCheckBox.Checked = False
        'Frame-Type
        DeblockingCheckBox.Checked = True
        DeblockingAlphaNumericUpDown.Value = 0
        DeblockingBetaNumericUpDown.Value = 0
        CABACCheckBox.Checked = False
        BFramesNumericUpDown.Value = 0
        BFrameBiasNumericUpDown.Value = 0
        AdaptiveBFramesComboBox.Text = "1 - Fast"
        BFramePyramidCheckBox.Checked = False
        BFrameWeightedPredictionCheckBox.Checked = False
        ReferenceFramesNumericUpDown.Value = 1
        ExtraIFramesNumericUpDown.Value = 40
        PframeWeightedPredictionComboBox.Text = "Smart analysis"
        AdaptiveIFramesDecisionCheckBox.Checked = True
        'Rate Control
        QMinNumericUpDown.Value = 10
        QMaxNumericUpDown.Value = 51
        QDeltaNumericUpDown.Value = 4
        QIPRatioNumericUpDown.Value = 1.4
        QPBRatioNumericUpDown.Value = 1.3
        ChromaandLumaQPOffsetNumericUpDown.Value = 0
        VBVBufferSizeNumericUpDown.Value = 0
        VBVMaximumBitrateNumericUpDown.Value = 0
        VBVInitialBufferNumericUpDown.Value = 0.9
        AverageBitrateVarianceNumericUpDown.Value = 1.0
        QuantizerCompressionNumericUpDown.Value = 0.6
        NumberofFramesforLookaheadNumericUpDown.Value = 40
        UseMBTreeCheckBox.Checked = True
        AdaptiveQuantizersModeComboBox.Text = "Variance AQ"
        AdaptiveQuantizersStrengthNumericUpDown.Value = 1.0
        'Analysis
        ChromaMECheckBox.Checked = True
        MERangeNumericUpDown.Value = 16
        MEMethodComboBox.Text = "Hexagon"
        SubpixelMEComboBox.Text = "7 - RD on all frames"
        MVPredictionModeComboBox.Text = "Spatial"
        TrellisComboBox.Text = "0 - None"
        PsyRDStrengthNumericUpDown.Value = 1.0
        PsyTrellisStrengthNumericUpDown.Value = 0.0
        NoMixedReferenceFramesCheckBox.Checked = False
        NoFastPSkipCheckBox.Checked = False
        NoPsychovisualEnhancementsCheckBox.Checked = False
        MacroblocksComboBox.Text = "Default"
        Adaptive8x8DCTCheckBox.Checked = False
        I4x4CheckBox.Checked = True
        P4x4CheckBox.Checked = False
        I8x8CheckBox.Checked = False
        P8x8CheckBox.Checked = True
        B8x8CheckBox.Checked = True
        NoiseReductionNumericUpDown.Value = 0
        UseaccessunitdelimitersCheckBox.Checked = False

    End Sub

#Region "MACROBLOCKS"

    Private Sub MACROBLOCKS()
        If MacroblocksComboBox.Text = "Default" Then
            Adaptive8x8DCTCheckBox.Enabled = False
            I4x4CheckBox.Enabled = False
            P4x4CheckBox.Enabled = False
            I8x8CheckBox.Enabled = False
            P8x8CheckBox.Enabled = False
            B8x8CheckBox.Enabled = False
            If ProfileComboBox.Text = "High Profile" Then
                Adaptive8x8DCTCheckBox.Checked = True
                I4x4CheckBox.Checked = True
                P4x4CheckBox.Checked = False
                I8x8CheckBox.Checked = True
                P8x8CheckBox.Checked = True
                B8x8CheckBox.Checked = True
            Else
                Adaptive8x8DCTCheckBox.Checked = False
                I4x4CheckBox.Checked = True
                P4x4CheckBox.Checked = False
                I8x8CheckBox.Checked = False
                P8x8CheckBox.Checked = True
                B8x8CheckBox.Checked = True
            End If
        ElseIf MacroblocksComboBox.Text = "Custom" Then
            If ProfileComboBox.Text = "High Profile" Then
                Adaptive8x8DCTCheckBox.Enabled = True
                I4x4CheckBox.Enabled = True
                P4x4CheckBox.Enabled = True
                I8x8CheckBox.Enabled = True
                P8x8CheckBox.Enabled = True
                B8x8CheckBox.Enabled = True
            Else
                Adaptive8x8DCTCheckBox.Enabled = False
                I4x4CheckBox.Enabled = True
                P4x4CheckBox.Enabled = True
                I8x8CheckBox.Enabled = False
                P8x8CheckBox.Enabled = True
                B8x8CheckBox.Enabled = True
                Adaptive8x8DCTCheckBox.Checked = False
                I8x8CheckBox.Checked = False
            End If

        End If
    End Sub

    Private Sub MACROBLOCKS_CHK()
        If MacroblocksComboBox.Text = "Custom" Then
            '선택관련
            If P8x8CheckBox.Checked = True Then
                P4x4CheckBox.Enabled = True
            Else
                P4x4CheckBox.Enabled = False
                P4x4CheckBox.Checked = False
            End If
            If Adaptive8x8DCTCheckBox.Checked = True Then
                I8x8CheckBox.Enabled = True
            Else
                I8x8CheckBox.Enabled = False
                I8x8CheckBox.Checked = False
            End If
        End If
    End Sub

    Private Sub MacroblocksComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MacroblocksComboBox.SelectedIndexChanged
        MACROBLOCKS()
        MACROBLOCKS_CHK()
    End Sub

    Private Sub Adaptive8x8DCTCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Adaptive8x8DCTCheckBox.CheckedChanged
        MACROBLOCKS_CHK()
    End Sub

    Private Sub I4x4CheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles I4x4CheckBox.CheckedChanged
        MACROBLOCKS_CHK()
    End Sub

    Private Sub P4x4CheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P4x4CheckBox.CheckedChanged
        MACROBLOCKS_CHK()
    End Sub

    Private Sub I8x8CheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles I8x8CheckBox.CheckedChanged
        MACROBLOCKS_CHK()
    End Sub

    Private Sub P8x8CheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P8x8CheckBox.CheckedChanged
        MACROBLOCKS_CHK()
    End Sub

    Private Sub B8x8CheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B8x8CheckBox.CheckedChanged
        MACROBLOCKS_CHK()
    End Sub

#End Region

    Private Sub ProfileComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfileComboBox.SelectedIndexChanged
        If ProfileComboBox.Text = "Baseline Profile" Then
            '제한
            '----
            CABACGroupBox.Enabled = False
            CABACCheckBox.Checked = False
            '----
            BFramesNumericUpDown.Value = 0 'B프레임 0으로 설정
            BFramesGroupBox.Enabled = False
            '----
            PframeWeightedPredictionLabel.Enabled = False
            PframeWeightedPredictionComboBox.Enabled = False
            MVPredictionModeLabel.Enabled = False
            MVPredictionModeComboBox.Enabled = False
            TrellisLabel.Enabled = False
            TrellisComboBox.Enabled = False

        Else
            '제한
            CABACGroupBox.Enabled = True
            BFramesGroupBox.Enabled = True
            PframeWeightedPredictionLabel.Enabled = True
            PframeWeightedPredictionComboBox.Enabled = True
            MVPredictionModeLabel.Enabled = True
            MVPredictionModeComboBox.Enabled = True
            TrellisLabel.Enabled = True
            TrellisComboBox.Enabled = True
        End If

        MACROBLOCKS()
        MACROBLOCKS_CHK()
    End Sub

    Private Sub DeblockingCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeblockingCheckBox.CheckedChanged
        If DeblockingCheckBox.Checked = True Then
            DeblockingAlphaLabel.Enabled = True
            DeblockingBetaLabel.Enabled = True
            DeblockingAlphaNumericUpDown.Enabled = True
            DeblockingBetaNumericUpDown.Enabled = True
        Else
            DeblockingAlphaLabel.Enabled = False
            DeblockingBetaLabel.Enabled = False
            DeblockingAlphaNumericUpDown.Enabled = False
            DeblockingBetaNumericUpDown.Enabled = False
        End If
    End Sub

    Private Sub ReferenceFramesNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReferenceFramesNumericUpDown.LostFocus
        ReferenceFramesNumericUpDown.Text = ReferenceFramesNumericUpDown.Value
    End Sub

    Private Sub ReferenceFramesNumericUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReferenceFramesNumericUpDown.ValueChanged
        '조건
        If ReferenceFramesNumericUpDown.Value = 1 Then
            '---
            NoMixedReferenceFramesCheckBox.Enabled = False
            NoMixedReferenceFramesCheckBox.Checked = False
            '---
        Else
            NoMixedReferenceFramesCheckBox.Enabled = True
        End If
    End Sub

    Private Sub NoMixedReferenceFramesCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoMixedReferenceFramesCheckBox.CheckedChanged
        '조건
        If ReferenceFramesNumericUpDown.Value = 1 Then
            '---
            NoMixedReferenceFramesCheckBox.Enabled = False
            NoMixedReferenceFramesCheckBox.Checked = False
            '---
        Else
            NoMixedReferenceFramesCheckBox.Enabled = True
        End If
    End Sub

    Private Sub BFramesNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BFramesNumericUpDown.LostFocus
        BFramesNumericUpDown.Text = BFramesNumericUpDown.Value
    End Sub

    Private Sub BFramesNumericUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BFramesNumericUpDown.ValueChanged

        If ProfileComboBox.Text <> "Baseline Profile" Then
            If BFramesNumericUpDown.Value = 0 Then
                BFrameBiasLabel.Enabled = False
                BFrameBiasNumericUpDown.Enabled = False
                AdaptiveBFramesLabel.Enabled = False
                AdaptiveBFramesComboBox.Enabled = False
                '---
                BFramePyramidCheckBox.Enabled = False
                BFramePyramidCheckBox.Checked = False
                BFrameWeightedPredictionCheckBox.Enabled = False
                BFrameWeightedPredictionCheckBox.Checked = False
                '---
                MVPredictionModeLabel.Enabled = False
                MVPredictionModeComboBox.Enabled = False

            ElseIf BFramesNumericUpDown.Value = 1 Then
                BFrameBiasLabel.Enabled = True
                BFrameBiasNumericUpDown.Enabled = True
                AdaptiveBFramesLabel.Enabled = True
                AdaptiveBFramesComboBox.Enabled = True
                '---
                BFramePyramidCheckBox.Enabled = False
                BFramePyramidCheckBox.Checked = False
                '---
                BFrameWeightedPredictionCheckBox.Enabled = True
                MVPredictionModeLabel.Enabled = True
                MVPredictionModeComboBox.Enabled = True

            Else
                BFrameBiasLabel.Enabled = True
                BFrameBiasNumericUpDown.Enabled = True
                AdaptiveBFramesLabel.Enabled = True
                AdaptiveBFramesComboBox.Enabled = True
                BFramePyramidCheckBox.Enabled = True
                BFrameWeightedPredictionCheckBox.Enabled = True
                MVPredictionModeLabel.Enabled = True
                MVPredictionModeComboBox.Enabled = True

            End If
        Else
            BFrameBiasLabel.Enabled = False
            BFrameBiasNumericUpDown.Enabled = False
            AdaptiveBFramesLabel.Enabled = False
            AdaptiveBFramesComboBox.Enabled = False
            '---
            BFramePyramidCheckBox.Enabled = False
            BFramePyramidCheckBox.Checked = False
            BFrameWeightedPredictionCheckBox.Enabled = False
            BFrameWeightedPredictionCheckBox.Checked = False
            '---
            MVPredictionModeLabel.Enabled = False
            MVPredictionModeComboBox.Enabled = False

        End If

    End Sub

    Private Sub XML_CHANGE(ByVal src As String)

        Try
            Dim XDoc As New XmlDocument()
            Dim XNode As XmlNode
            XDoc.Load(src)
            '============== 시작

            'Main
            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_ThreadsNumericUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = ThreadsNumericUpDown.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_ProfileComboBox")
            If Not XNode Is Nothing Then XNode.InnerText = ProfileComboBox.Text

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_LevelComboBox")
            If Not XNode Is Nothing Then XNode.InnerText = LevelComboBox.Text

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_FastfirstpassCheckBox")
            If Not XNode Is Nothing Then XNode.InnerText = FastfirstpassCheckBox.Checked

            'Frame-Type
            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_DeblockingCheckBox")
            If Not XNode Is Nothing Then XNode.InnerText = DeblockingCheckBox.Checked

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_DeblockingAlphaNumericUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = DeblockingAlphaNumericUpDown.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_DeblockingBetaNumericUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = DeblockingBetaNumericUpDown.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_CABACCheckBox")
            If Not XNode Is Nothing Then XNode.InnerText = CABACCheckBox.Checked

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_BFramesNumericUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = BFramesNumericUpDown.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_BFrameBiasNumericUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = BFrameBiasNumericUpDown.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_AdaptiveBFramesComboBox")
            If Not XNode Is Nothing Then XNode.InnerText = AdaptiveBFramesComboBox.Text

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_BFramePyramidCheckBox")
            If Not XNode Is Nothing Then XNode.InnerText = BFramePyramidCheckBox.Checked

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_BFrameWeightedPredictionCheckBox")
            If Not XNode Is Nothing Then XNode.InnerText = BFrameWeightedPredictionCheckBox.Checked

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_ReferenceFramesNumericUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = ReferenceFramesNumericUpDown.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_ExtraIFramesNumericUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = ExtraIFramesNumericUpDown.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_PframeWeightedPredictionComboBox")
            If Not XNode Is Nothing Then XNode.InnerText = PframeWeightedPredictionComboBox.Text

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_AdaptiveIFramesDecisionCheckBox")
            If Not XNode Is Nothing Then XNode.InnerText = AdaptiveIFramesDecisionCheckBox.Checked

            'Rate Control
            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_QMinNumericUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = QMinNumericUpDown.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_QMaxNumericUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = QMaxNumericUpDown.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_QDeltaNumericUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = QDeltaNumericUpDown.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_QIPRatioNumericUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = QIPRatioNumericUpDown.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_QPBRatioNumericUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = QPBRatioNumericUpDown.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_ChromaandLumaQPOffsetNumericUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = ChromaandLumaQPOffsetNumericUpDown.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_VBVBufferSizeNumericUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = VBVBufferSizeNumericUpDown.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_VBVMaximumBitrateNumericUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = VBVMaximumBitrateNumericUpDown.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_VBVInitialBufferNumericUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = VBVInitialBufferNumericUpDown.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_AverageBitrateVarianceNumericUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = AverageBitrateVarianceNumericUpDown.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_QuantizerCompressionNumericUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = QuantizerCompressionNumericUpDown.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_NumberofFramesforLookaheadNumericUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = NumberofFramesforLookaheadNumericUpDown.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_UseMBTreeCheckBox")
            If Not XNode Is Nothing Then XNode.InnerText = UseMBTreeCheckBox.Checked

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_AdaptiveQuantizersModeComboBox")
            If Not XNode Is Nothing Then XNode.InnerText = AdaptiveQuantizersModeComboBox.Text

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_AdaptiveQuantizersStrengthNumericUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = AdaptiveQuantizersStrengthNumericUpDown.Value

            'Analysis
            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_ChromaMECheckBox")
            If Not XNode Is Nothing Then XNode.InnerText = ChromaMECheckBox.Checked

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_MERangeNumericUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = MERangeNumericUpDown.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_MEMethodComboBox")
            If Not XNode Is Nothing Then XNode.InnerText = MEMethodComboBox.Text

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_SubpixelMEComboBox")
            If Not XNode Is Nothing Then XNode.InnerText = SubpixelMEComboBox.Text

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_MVPredictionModeComboBox")
            If Not XNode Is Nothing Then XNode.InnerText = MVPredictionModeComboBox.Text

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_TrellisComboBox")
            If Not XNode Is Nothing Then XNode.InnerText = TrellisComboBox.Text

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_PsyRDStrengthNumericUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = PsyRDStrengthNumericUpDown.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_PsyTrellisStrengthNumericUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = PsyTrellisStrengthNumericUpDown.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_NoMixedReferenceFramesCheckBox")
            If Not XNode Is Nothing Then XNode.InnerText = NoMixedReferenceFramesCheckBox.Checked

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_NoFastPSkipCheckBox")
            If Not XNode Is Nothing Then XNode.InnerText = NoFastPSkipCheckBox.Checked

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_NoPsychovisualEnhancementsCheckBox")
            If Not XNode Is Nothing Then XNode.InnerText = NoPsychovisualEnhancementsCheckBox.Checked

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_MacroblocksComboBox")
            If Not XNode Is Nothing Then XNode.InnerText = MacroblocksComboBox.Text

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_Adaptive8x8DCTCheckBox")
            If Not XNode Is Nothing Then XNode.InnerText = Adaptive8x8DCTCheckBox.Checked

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_I4x4CheckBox")
            If Not XNode Is Nothing Then XNode.InnerText = I4x4CheckBox.Checked

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_P4x4CheckBox")
            If Not XNode Is Nothing Then XNode.InnerText = P4x4CheckBox.Checked

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_I8x8CheckBox")
            If Not XNode Is Nothing Then XNode.InnerText = I8x8CheckBox.Checked

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_P8x8CheckBox")
            If Not XNode Is Nothing Then XNode.InnerText = P8x8CheckBox.Checked

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_B8x8CheckBox")
            If Not XNode Is Nothing Then XNode.InnerText = B8x8CheckBox.Checked

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_NoiseReductionNumericUpDown")
            If Not XNode Is Nothing Then XNode.InnerText = NoiseReductionNumericUpDown.Value

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/x264optsFrm_UseaccessunitdelimitersCheckBox")
            If Not XNode Is Nothing Then XNode.InnerText = UseaccessunitdelimitersCheckBox.Checked

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

                '//////////////////////////////////////////////////////////// x264optsFrm
                With Me

                    'Main
                    If XTR.Name = "x264optsFrm_ThreadsNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .ThreadsNumericUpDown.Value = XTRSTR Else .ThreadsNumericUpDown.Value = 0
                    End If

                    If XTR.Name = "x264optsFrm_ProfileComboBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .ProfileComboBox.Text = XTRSTR Else .ProfileComboBox.Text = "Baseline Profile"
                    End If

                    If XTR.Name = "x264optsFrm_LevelComboBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .LevelComboBox.Text = XTRSTR Else .LevelComboBox.Text = "Unrestricted AutoGuess"
                    End If

                    If XTR.Name = "x264optsFrm_FastfirstpassCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .FastfirstpassCheckBox.Checked = XTRSTR Else .FastfirstpassCheckBox.Checked = False
                    End If

                    'Frame-Type
                    If XTR.Name = "x264optsFrm_DeblockingCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .DeblockingCheckBox.Checked = XTRSTR Else .DeblockingCheckBox.Checked = True
                    End If

                    If XTR.Name = "x264optsFrm_DeblockingAlphaNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .DeblockingAlphaNumericUpDown.Value = XTRSTR Else .DeblockingAlphaNumericUpDown.Value = 0
                    End If

                    If XTR.Name = "x264optsFrm_DeblockingBetaNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .DeblockingBetaNumericUpDown.Value = XTRSTR Else .DeblockingBetaNumericUpDown.Value = 0
                    End If

                    If XTR.Name = "x264optsFrm_CABACCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .CABACCheckBox.Checked = XTRSTR Else .CABACCheckBox.Checked = False
                    End If

                    If XTR.Name = "x264optsFrm_BFramesNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .BFramesNumericUpDown.Value = XTRSTR Else .BFramesNumericUpDown.Value = 0
                    End If

                    If XTR.Name = "x264optsFrm_BFrameBiasNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .BFrameBiasNumericUpDown.Value = XTRSTR Else .BFrameBiasNumericUpDown.Value = 0
                    End If

                    If XTR.Name = "x264optsFrm_AdaptiveBFramesComboBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .AdaptiveBFramesComboBox.Text = XTRSTR Else .AdaptiveBFramesComboBox.Text = "1 - Fast"
                    End If

                    If XTR.Name = "x264optsFrm_BFramePyramidCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .BFramePyramidCheckBox.Checked = XTRSTR Else .BFramePyramidCheckBox.Checked = False
                    End If

                    If XTR.Name = "x264optsFrm_BFrameWeightedPredictionCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .BFrameWeightedPredictionCheckBox.Checked = XTRSTR Else .BFrameWeightedPredictionCheckBox.Checked = False
                    End If

                    If XTR.Name = "x264optsFrm_ReferenceFramesNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .ReferenceFramesNumericUpDown.Value = XTRSTR Else .ReferenceFramesNumericUpDown.Value = 1
                    End If

                    If XTR.Name = "x264optsFrm_ExtraIFramesNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .ExtraIFramesNumericUpDown.Value = XTRSTR Else .ExtraIFramesNumericUpDown.Value = 40
                    End If

                    If XTR.Name = "x264optsFrm_PframeWeightedPredictionComboBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .PframeWeightedPredictionComboBox.Text = XTRSTR Else .PframeWeightedPredictionComboBox.Text = "Smart analysis"
                    End If

                    If XTR.Name = "x264optsFrm_AdaptiveIFramesDecisionCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .AdaptiveIFramesDecisionCheckBox.Checked = XTRSTR Else .AdaptiveIFramesDecisionCheckBox.Checked = True
                    End If

                    'Rate Control
                    If XTR.Name = "x264optsFrm_QMinNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .QMinNumericUpDown.Value = XTRSTR Else .QMinNumericUpDown.Value = 10
                    End If

                    If XTR.Name = "x264optsFrm_QMaxNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .QMaxNumericUpDown.Value = XTRSTR Else .QMaxNumericUpDown.Value = 51
                    End If

                    If XTR.Name = "x264optsFrm_QDeltaNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .QDeltaNumericUpDown.Value = XTRSTR Else .QDeltaNumericUpDown.Value = 4
                    End If

                    If XTR.Name = "x264optsFrm_QIPRatioNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .QIPRatioNumericUpDown.Value = XTRSTR Else .QIPRatioNumericUpDown.Value = 1.4
                    End If

                    If XTR.Name = "x264optsFrm_QPBRatioNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .QPBRatioNumericUpDown.Value = XTRSTR Else .QPBRatioNumericUpDown.Value = 1.3
                    End If

                    If XTR.Name = "x264optsFrm_ChromaandLumaQPOffsetNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .ChromaandLumaQPOffsetNumericUpDown.Value = XTRSTR Else .ChromaandLumaQPOffsetNumericUpDown.Value = 0
                    End If

                    If XTR.Name = "x264optsFrm_VBVBufferSizeNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .VBVBufferSizeNumericUpDown.Value = XTRSTR Else .VBVBufferSizeNumericUpDown.Value = 0
                    End If

                    If XTR.Name = "x264optsFrm_VBVMaximumBitrateNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .VBVMaximumBitrateNumericUpDown.Value = XTRSTR Else .VBVMaximumBitrateNumericUpDown.Value = 0
                    End If

                    If XTR.Name = "x264optsFrm_VBVInitialBufferNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .VBVInitialBufferNumericUpDown.Value = XTRSTR Else .VBVInitialBufferNumericUpDown.Value = 0.9
                    End If

                    If XTR.Name = "x264optsFrm_AverageBitrateVarianceNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .AverageBitrateVarianceNumericUpDown.Value = XTRSTR Else .AverageBitrateVarianceNumericUpDown.Value = 1.0
                    End If

                    If XTR.Name = "x264optsFrm_QuantizerCompressionNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .QuantizerCompressionNumericUpDown.Value = XTRSTR Else .QuantizerCompressionNumericUpDown.Value = 0.6
                    End If

                    If XTR.Name = "x264optsFrm_NumberofFramesforLookaheadNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .NumberofFramesforLookaheadNumericUpDown.Value = XTRSTR Else .NumberofFramesforLookaheadNumericUpDown.Value = 40
                    End If

                    If XTR.Name = "x264optsFrm_UseMBTreeCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .UseMBTreeCheckBox.Checked = XTRSTR Else .UseMBTreeCheckBox.Checked = True
                    End If

                    If XTR.Name = "x264optsFrm_AdaptiveQuantizersModeComboBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .AdaptiveQuantizersModeComboBox.Text = XTRSTR Else .AdaptiveQuantizersModeComboBox.Text = "Variance AQ"
                    End If

                    If XTR.Name = "x264optsFrm_AdaptiveQuantizersStrengthNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .AdaptiveQuantizersStrengthNumericUpDown.Value = XTRSTR Else .AdaptiveQuantizersStrengthNumericUpDown.Value = 1.0
                    End If

                    'Analysis
                    If XTR.Name = "x264optsFrm_ChromaMECheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .ChromaMECheckBox.Checked = XTRSTR Else .ChromaMECheckBox.Checked = True
                    End If

                    If XTR.Name = "x264optsFrm_MERangeNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .MERangeNumericUpDown.Value = XTRSTR Else .MERangeNumericUpDown.Value = 16
                    End If

                    If XTR.Name = "x264optsFrm_MEMethodComboBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .MEMethodComboBox.Text = XTRSTR Else .MEMethodComboBox.Text = "Hexagon"
                    End If

                    If XTR.Name = "x264optsFrm_SubpixelMEComboBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .SubpixelMEComboBox.Text = XTRSTR Else .SubpixelMEComboBox.Text = "7 - RD on all frames"
                    End If

                    If XTR.Name = "x264optsFrm_MVPredictionModeComboBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .MVPredictionModeComboBox.Text = XTRSTR Else .MVPredictionModeComboBox.Text = "Spatial"
                    End If

                    If XTR.Name = "x264optsFrm_TrellisComboBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .TrellisComboBox.Text = XTRSTR Else .TrellisComboBox.Text = "0 - None"
                    End If

                    If XTR.Name = "x264optsFrm_PsyRDStrengthNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .PsyRDStrengthNumericUpDown.Value = XTRSTR Else .PsyRDStrengthNumericUpDown.Value = 1.0
                    End If

                    If XTR.Name = "x264optsFrm_PsyTrellisStrengthNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .PsyTrellisStrengthNumericUpDown.Value = XTRSTR Else .PsyTrellisStrengthNumericUpDown.Value = 0.0
                    End If

                    If XTR.Name = "x264optsFrm_NoMixedReferenceFramesCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .NoMixedReferenceFramesCheckBox.Checked = XTRSTR Else .NoMixedReferenceFramesCheckBox.Checked = False
                    End If

                    If XTR.Name = "x264optsFrm_NoFastPSkipCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .NoFastPSkipCheckBox.Checked = XTRSTR Else .NoFastPSkipCheckBox.Checked = False
                    End If

                    If XTR.Name = "x264optsFrm_NoPsychovisualEnhancementsCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .NoPsychovisualEnhancementsCheckBox.Checked = XTRSTR Else .NoPsychovisualEnhancementsCheckBox.Checked = False
                    End If

                    If XTR.Name = "x264optsFrm_MacroblocksComboBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .MacroblocksComboBox.Text = XTRSTR Else .MacroblocksComboBox.Text = "Default"
                    End If

                    If XTR.Name = "x264optsFrm_Adaptive8x8DCTCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .Adaptive8x8DCTCheckBox.Checked = XTRSTR Else .Adaptive8x8DCTCheckBox.Checked = False
                    End If

                    If XTR.Name = "x264optsFrm_I4x4CheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .I4x4CheckBox.Checked = XTRSTR Else .I4x4CheckBox.Checked = True
                    End If

                    If XTR.Name = "x264optsFrm_P4x4CheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .P4x4CheckBox.Checked = XTRSTR Else .P4x4CheckBox.Checked = False
                    End If

                    If XTR.Name = "x264optsFrm_I8x8CheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .I8x8CheckBox.Checked = XTRSTR Else .I8x8CheckBox.Checked = False
                    End If

                    If XTR.Name = "x264optsFrm_P8x8CheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .P8x8CheckBox.Checked = XTRSTR Else .P8x8CheckBox.Checked = True
                    End If

                    If XTR.Name = "x264optsFrm_B8x8CheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .B8x8CheckBox.Checked = XTRSTR Else .B8x8CheckBox.Checked = True
                    End If

                    If XTR.Name = "x264optsFrm_NoiseReductionNumericUpDown" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .NoiseReductionNumericUpDown.Value = XTRSTR Else .NoiseReductionNumericUpDown.Value = 0
                    End If

                    If XTR.Name = "x264optsFrm_UseaccessunitdelimitersCheckBox" Then
                        Dim XTRSTR As String = XTR.ReadString
                        If XTRSTR <> "" Then .UseaccessunitdelimitersCheckBox.Checked = XTRSTR Else .UseaccessunitdelimitersCheckBox.Checked = False
                    End If

                End With

            Loop

        Catch ex As Exception
            MsgBox("XML_LOAD_ERROR :" & ex.Message)
        Finally
            XTR.Close()
        End Try

    End Sub

    Private Sub x264optsFrm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        XML_LOAD(My.Application.Info.DirectoryPath & "\settings.xml")
    End Sub

    Private Sub x264optsFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
        End Try
LANG_SKIP:
        '=========================================

        '퀀타이저 / 퀄리티 설정
        If InStr(EncSetFrm.VideoModeComboBox.SelectedItem, "[1PASS-CQP]", CompareMethod.Text) <> 0 Then '퀀타이저
            TurboGroupBox.Enabled = False

            RateControlGroupBox.Enabled = False
            AdaptiveQuantizersGroupBox.Enabled = False
            AverageBitrateVarianceLabel.Enabled = False
            AverageBitrateVarianceNumericUpDown.Enabled = False

        ElseIf InStr(EncSetFrm.VideoModeComboBox.SelectedItem, "[1PASS-CRF]", CompareMethod.Text) <> 0 Then '퀄리티
            TurboGroupBox.Enabled = False

            RateControlGroupBox.Enabled = True
            AdaptiveQuantizersGroupBox.Enabled = True
            AverageBitrateVarianceLabel.Enabled = False
            AverageBitrateVarianceNumericUpDown.Enabled = False
        ElseIf InStr(EncSetFrm.VideoModeComboBox.SelectedItem, "[2PASS-CBR]", CompareMethod.Text) <> 0 Then '2패스 비트레이트
            TurboGroupBox.Enabled = True

            RateControlGroupBox.Enabled = True
            AdaptiveQuantizersGroupBox.Enabled = True
            AverageBitrateVarianceLabel.Enabled = True
            AverageBitrateVarianceNumericUpDown.Enabled = True
        Else
            TurboGroupBox.Enabled = False

            RateControlGroupBox.Enabled = True
            AdaptiveQuantizersGroupBox.Enabled = True
            AverageBitrateVarianceLabel.Enabled = True
            AverageBitrateVarianceNumericUpDown.Enabled = True
        End If

        XML_LOAD(My.Application.Info.DirectoryPath & "\settings.xml")

    End Sub

    Private Sub OKBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKBTN.Click
        XML_CHANGE(My.Application.Info.DirectoryPath & "\settings.xml")
        Close()
    End Sub

    Private Sub CancelBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBTN.Click
        Close()
    End Sub

    Private Sub ExtraIFramesNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExtraIFramesNumericUpDown.LostFocus
        ExtraIFramesNumericUpDown.Text = ExtraIFramesNumericUpDown.Value
    End Sub

    Private Sub ExtraIFramesNumericUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExtraIFramesNumericUpDown.ValueChanged

    End Sub

    Private Sub AdaptiveIFramesDecisionCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdaptiveIFramesDecisionCheckBox.CheckedChanged
        If AdaptiveIFramesDecisionCheckBox.Checked = True Then
            ExtraIFramesLabel.Enabled = True
            ExtraIFramesNumericUpDown.Enabled = True
        Else
            ExtraIFramesLabel.Enabled = False
            ExtraIFramesNumericUpDown.Enabled = False
        End If
    End Sub

    Private Sub x264PictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles x264PictureBox.Click
        System.Diagnostics.Process.Start("http://www.videolan.org/developers/x264.html")
    End Sub

    Private Sub ffmpegPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ffmpegPictureBox.Click
        System.Diagnostics.Process.Start("http://ffmpeg.org")
    End Sub

    Private Sub ThreadsNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ThreadsNumericUpDown.LostFocus
        ThreadsNumericUpDown.Text = ThreadsNumericUpDown.Value
    End Sub

    Private Sub DeblockingAlphaNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DeblockingAlphaNumericUpDown.LostFocus
        DeblockingAlphaNumericUpDown.Text = DeblockingAlphaNumericUpDown.Value
    End Sub

    Private Sub DeblockingBetaNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DeblockingBetaNumericUpDown.LostFocus
        DeblockingBetaNumericUpDown.Text = DeblockingBetaNumericUpDown.Value
    End Sub

    Private Sub BFrameBiasNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BFrameBiasNumericUpDown.LostFocus
        BFrameBiasNumericUpDown.Text = BFrameBiasNumericUpDown.Value
    End Sub

    Private Sub QMinNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles QMinNumericUpDown.LostFocus
        QMinNumericUpDown.Text = QMinNumericUpDown.Value
    End Sub

    Private Sub QMaxNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles QMaxNumericUpDown.LostFocus
        QMaxNumericUpDown.Text = QMaxNumericUpDown.Value
    End Sub

    Private Sub QDeltaNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles QDeltaNumericUpDown.LostFocus
        QDeltaNumericUpDown.Text = QDeltaNumericUpDown.Value
    End Sub

    Private Sub QIPRatioNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles QIPRatioNumericUpDown.LostFocus
        QIPRatioNumericUpDown.Text = QIPRatioNumericUpDown.Value
    End Sub

    Private Sub QPBRatioNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles QPBRatioNumericUpDown.LostFocus
        QPBRatioNumericUpDown.Text = QPBRatioNumericUpDown.Value
    End Sub

    Private Sub ChromaandLumaQPOffsetNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChromaandLumaQPOffsetNumericUpDown.LostFocus
        ChromaandLumaQPOffsetNumericUpDown.Text = ChromaandLumaQPOffsetNumericUpDown.Value
    End Sub

    Private Sub AdaptiveQuantizersStrengthNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles AdaptiveQuantizersStrengthNumericUpDown.LostFocus
        AdaptiveQuantizersStrengthNumericUpDown.Text = AdaptiveQuantizersStrengthNumericUpDown.Value
    End Sub

    Private Sub VBVBufferSizeNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles VBVBufferSizeNumericUpDown.LostFocus
        VBVBufferSizeNumericUpDown.Text = VBVBufferSizeNumericUpDown.Value
    End Sub

    Private Sub VBVMaximumBitrateNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles VBVMaximumBitrateNumericUpDown.LostFocus
        VBVMaximumBitrateNumericUpDown.Text = VBVMaximumBitrateNumericUpDown.Value
    End Sub

    Private Sub AverageBitrateVarianceNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles AverageBitrateVarianceNumericUpDown.LostFocus
        AverageBitrateVarianceNumericUpDown.Text = AverageBitrateVarianceNumericUpDown.Value
    End Sub

    Private Sub QuantizerCompressionNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles QuantizerCompressionNumericUpDown.LostFocus
        QuantizerCompressionNumericUpDown.Text = QuantizerCompressionNumericUpDown.Value
    End Sub

    Private Sub NumberofFramesforLookaheadNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles NumberofFramesforLookaheadNumericUpDown.LostFocus
        NumberofFramesforLookaheadNumericUpDown.Text = NumberofFramesforLookaheadNumericUpDown.Value
    End Sub

    Private Sub MERangeNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MERangeNumericUpDown.LostFocus
        MERangeNumericUpDown.Text = MERangeNumericUpDown.Value
    End Sub

    Private Sub PsyRDStrengthNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles PsyRDStrengthNumericUpDown.LostFocus
        PsyRDStrengthNumericUpDown.Text = PsyRDStrengthNumericUpDown.Value
    End Sub

    Private Sub PsyTrellisStrengthNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles PsyTrellisStrengthNumericUpDown.LostFocus
        PsyTrellisStrengthNumericUpDown.Text = PsyTrellisStrengthNumericUpDown.Value
    End Sub

    Private Sub NoiseReductionNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles NoiseReductionNumericUpDown.LostFocus
        NoiseReductionNumericUpDown.Text = NoiseReductionNumericUpDown.Value
    End Sub

    Private Sub VBVInitialBufferNumericUpDown_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles VBVInitialBufferNumericUpDown.LostFocus
        VBVInitialBufferNumericUpDown.Text = VBVInitialBufferNumericUpDown.Value
    End Sub

End Class