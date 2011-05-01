<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class x264optsFrm
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(x264optsFrm))
        Me.SettingTabControl = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TuningsGroupBox = New System.Windows.Forms.GroupBox
        Me.TuningsComboBox = New System.Windows.Forms.ComboBox
        Me.PresetsGroupBox = New System.Windows.Forms.GroupBox
        Me.PresetsLabel = New System.Windows.Forms.Label
        Me.PresetsTrackBar = New System.Windows.Forms.TrackBar
        Me.ffmpegPictureBox = New System.Windows.Forms.PictureBox
        Me.x264PictureBox = New System.Windows.Forms.PictureBox
        Me.SlowfirstpassGroupBox = New System.Windows.Forms.GroupBox
        Me.SlowfirstpassCheckBox = New System.Windows.Forms.CheckBox
        Me.LevelGroupBox = New System.Windows.Forms.GroupBox
        Me.LevelComboBox = New System.Windows.Forms.ComboBox
        Me.ProfileGroupBox = New System.Windows.Forms.GroupBox
        Me.ProfileComboBox = New System.Windows.Forms.ComboBox
        Me.ThreadsGroupBox = New System.Windows.Forms.GroupBox
        Me.ThreadsNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.ThreadsLabel = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.CABACGroupBox = New System.Windows.Forms.GroupBox
        Me.CABACCheckBox = New System.Windows.Forms.CheckBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.AdaptiveIFramesDecisionCheckBox = New System.Windows.Forms.CheckBox
        Me.PframeWeightedPredictionComboBox = New System.Windows.Forms.ComboBox
        Me.PframeWeightedPredictionLabel = New System.Windows.Forms.Label
        Me.ExtraIFramesNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.ExtraIFramesLabel = New System.Windows.Forms.Label
        Me.ReferenceFramesNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.Label8 = New System.Windows.Forms.Label
        Me.BFramesGroupBox = New System.Windows.Forms.GroupBox
        Me.BFrameWeightedPredictionCheckBox = New System.Windows.Forms.CheckBox
        Me.BFramePyramidCheckBox = New System.Windows.Forms.CheckBox
        Me.AdaptiveBFramesComboBox = New System.Windows.Forms.ComboBox
        Me.BFrameBiasNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.BFramesNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.BFrameBiasLabel = New System.Windows.Forms.Label
        Me.AdaptiveBFramesLabel = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.DeblockingBetaNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.DeblockingAlphaNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.DeblockingBetaLabel = New System.Windows.Forms.Label
        Me.DeblockingAlphaLabel = New System.Windows.Forms.Label
        Me.DeblockingCheckBox = New System.Windows.Forms.CheckBox
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.RateControlGroupBox = New System.Windows.Forms.GroupBox
        Me.TempBlurofQuantafterCCNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.TempBlurofQuantafterCCLabel = New System.Windows.Forms.Label
        Me.TempBlurofestFramecomplexityNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.TempBlurofestFramecomplexityLabel = New System.Windows.Forms.Label
        Me.UseMBTreeCheckBox = New System.Windows.Forms.CheckBox
        Me.NumberofFramesforLookaheadNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.Label26 = New System.Windows.Forms.Label
        Me.QuantizerCompressionNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.Label25 = New System.Windows.Forms.Label
        Me.AverageBitrateVarianceNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.AverageBitrateVarianceLabel = New System.Windows.Forms.Label
        Me.VBVInitialBufferNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.Label23 = New System.Windows.Forms.Label
        Me.VBVMaximumBitrateNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.Label22 = New System.Windows.Forms.Label
        Me.VBVBufferSizeNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.Label21 = New System.Windows.Forms.Label
        Me.AdaptiveQuantizersGroupBox = New System.Windows.Forms.GroupBox
        Me.AdaptiveQuantizersStrengthNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.Label20 = New System.Windows.Forms.Label
        Me.AdaptiveQuantizersModeComboBox = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.ChromaandLumaQPOffsetNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.Label17 = New System.Windows.Forms.Label
        Me.QPBRatioNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.Label13 = New System.Windows.Forms.Label
        Me.QIPRatioNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.Label11 = New System.Windows.Forms.Label
        Me.QDeltaNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.QMaxNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.QMinNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.Label12 = New System.Windows.Forms.Label
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.GroupBox17 = New System.Windows.Forms.GroupBox
        Me.UseaccessunitdelimitersCheckBox = New System.Windows.Forms.CheckBox
        Me.GroupBox16 = New System.Windows.Forms.GroupBox
        Me.NoiseReductionNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.GroupBox14 = New System.Windows.Forms.GroupBox
        Me.NoPsychovisualEnhancementsCheckBox = New System.Windows.Forms.CheckBox
        Me.NoFastPSkipCheckBox = New System.Windows.Forms.CheckBox
        Me.NoMixedReferenceFramesCheckBox = New System.Windows.Forms.CheckBox
        Me.PsyTrellisStrengthNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.Label33 = New System.Windows.Forms.Label
        Me.PsyRDStrengthNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.Label32 = New System.Windows.Forms.Label
        Me.TrellisComboBox = New System.Windows.Forms.ComboBox
        Me.TrellisLabel = New System.Windows.Forms.Label
        Me.MVPredictionModeComboBox = New System.Windows.Forms.ComboBox
        Me.MVPredictionModeLabel = New System.Windows.Forms.Label
        Me.GroupBox13 = New System.Windows.Forms.GroupBox
        Me.MacroblocksComboBox = New System.Windows.Forms.ComboBox
        Me.B8x8CheckBox = New System.Windows.Forms.CheckBox
        Me.P8x8CheckBox = New System.Windows.Forms.CheckBox
        Me.I8x8CheckBox = New System.Windows.Forms.CheckBox
        Me.P4x4CheckBox = New System.Windows.Forms.CheckBox
        Me.I4x4CheckBox = New System.Windows.Forms.CheckBox
        Me.Adaptive8x8DCTCheckBox = New System.Windows.Forms.CheckBox
        Me.GroupBox12 = New System.Windows.Forms.GroupBox
        Me.SubpixelMEComboBox = New System.Windows.Forms.ComboBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.MEMethodComboBox = New System.Windows.Forms.ComboBox
        Me.ChromaMECheckBox = New System.Windows.Forms.CheckBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.MERangeNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.Label30 = New System.Windows.Forms.Label
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.NumericUpDown13 = New System.Windows.Forms.NumericUpDown
        Me.Label14 = New System.Windows.Forms.Label
        Me.NumericUpDown14 = New System.Windows.Forms.NumericUpDown
        Me.Label15 = New System.Windows.Forms.Label
        Me.NumericUpDown15 = New System.Windows.Forms.NumericUpDown
        Me.NumericUpDown16 = New System.Windows.Forms.NumericUpDown
        Me.NumericUpDown17 = New System.Windows.Forms.NumericUpDown
        Me.Label16 = New System.Windows.Forms.Label
        Me.DefBTN = New System.Windows.Forms.Button
        Me.CancelBTN = New System.Windows.Forms.Button
        Me.OKBTN = New System.Windows.Forms.Button
        Me.BPanel = New System.Windows.Forms.Panel
        Me.SLabel = New System.Windows.Forms.Label
        Me.SettingTabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TuningsGroupBox.SuspendLayout()
        Me.PresetsGroupBox.SuspendLayout()
        CType(Me.PresetsTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ffmpegPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.x264PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SlowfirstpassGroupBox.SuspendLayout()
        Me.LevelGroupBox.SuspendLayout()
        Me.ProfileGroupBox.SuspendLayout()
        Me.ThreadsGroupBox.SuspendLayout()
        CType(Me.ThreadsNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.CABACGroupBox.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.ExtraIFramesNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReferenceFramesNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BFramesGroupBox.SuspendLayout()
        CType(Me.BFrameBiasNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BFramesNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DeblockingBetaNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeblockingAlphaNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.RateControlGroupBox.SuspendLayout()
        CType(Me.TempBlurofQuantafterCCNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TempBlurofestFramecomplexityNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumberofFramesforLookaheadNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantizerCompressionNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AverageBitrateVarianceNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VBVInitialBufferNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VBVMaximumBitrateNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VBVBufferSizeNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AdaptiveQuantizersGroupBox.SuspendLayout()
        CType(Me.AdaptiveQuantizersStrengthNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        CType(Me.ChromaandLumaQPOffsetNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QPBRatioNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QIPRatioNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QDeltaNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QMaxNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QMinNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox17.SuspendLayout()
        Me.GroupBox16.SuspendLayout()
        CType(Me.NoiseReductionNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox14.SuspendLayout()
        CType(Me.PsyTrellisStrengthNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PsyRDStrengthNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox13.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        CType(Me.MERangeNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox9.SuspendLayout()
        CType(Me.NumericUpDown13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown17, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'SettingTabControl
        '
        Me.SettingTabControl.Controls.Add(Me.TabPage1)
        Me.SettingTabControl.Controls.Add(Me.TabPage2)
        Me.SettingTabControl.Controls.Add(Me.TabPage3)
        Me.SettingTabControl.Controls.Add(Me.TabPage4)
        resources.ApplyResources(Me.SettingTabControl, "SettingTabControl")
        Me.SettingTabControl.Name = "SettingTabControl"
        Me.SettingTabControl.SelectedIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TuningsGroupBox)
        Me.TabPage1.Controls.Add(Me.PresetsGroupBox)
        Me.TabPage1.Controls.Add(Me.ffmpegPictureBox)
        Me.TabPage1.Controls.Add(Me.x264PictureBox)
        Me.TabPage1.Controls.Add(Me.SlowfirstpassGroupBox)
        Me.TabPage1.Controls.Add(Me.LevelGroupBox)
        Me.TabPage1.Controls.Add(Me.ProfileGroupBox)
        Me.TabPage1.Controls.Add(Me.ThreadsGroupBox)
        resources.ApplyResources(Me.TabPage1, "TabPage1")
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TuningsGroupBox
        '
        Me.TuningsGroupBox.Controls.Add(Me.TuningsComboBox)
        resources.ApplyResources(Me.TuningsGroupBox, "TuningsGroupBox")
        Me.TuningsGroupBox.Name = "TuningsGroupBox"
        Me.TuningsGroupBox.TabStop = False
        '
        'TuningsComboBox
        '
        Me.TuningsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TuningsComboBox.FormattingEnabled = True
        Me.TuningsComboBox.Items.AddRange(New Object() {resources.GetString("TuningsComboBox.Items"), resources.GetString("TuningsComboBox.Items1"), resources.GetString("TuningsComboBox.Items2"), resources.GetString("TuningsComboBox.Items3"), resources.GetString("TuningsComboBox.Items4"), resources.GetString("TuningsComboBox.Items5"), resources.GetString("TuningsComboBox.Items6")})
        resources.ApplyResources(Me.TuningsComboBox, "TuningsComboBox")
        Me.TuningsComboBox.Name = "TuningsComboBox"
        '
        'PresetsGroupBox
        '
        Me.PresetsGroupBox.Controls.Add(Me.PresetsLabel)
        Me.PresetsGroupBox.Controls.Add(Me.PresetsTrackBar)
        resources.ApplyResources(Me.PresetsGroupBox, "PresetsGroupBox")
        Me.PresetsGroupBox.Name = "PresetsGroupBox"
        Me.PresetsGroupBox.TabStop = False
        '
        'PresetsLabel
        '
        resources.ApplyResources(Me.PresetsLabel, "PresetsLabel")
        Me.PresetsLabel.Name = "PresetsLabel"
        '
        'PresetsTrackBar
        '
        Me.PresetsTrackBar.BackColor = System.Drawing.Color.White
        Me.PresetsTrackBar.LargeChange = 1
        resources.ApplyResources(Me.PresetsTrackBar, "PresetsTrackBar")
        Me.PresetsTrackBar.Maximum = 9
        Me.PresetsTrackBar.Name = "PresetsTrackBar"
        Me.PresetsTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'ffmpegPictureBox
        '
        Me.ffmpegPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ffmpegPictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.ffmpegPictureBox, "ffmpegPictureBox")
        Me.ffmpegPictureBox.Name = "ffmpegPictureBox"
        Me.ffmpegPictureBox.TabStop = False
        '
        'x264PictureBox
        '
        Me.x264PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.x264PictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.x264PictureBox, "x264PictureBox")
        Me.x264PictureBox.Name = "x264PictureBox"
        Me.x264PictureBox.TabStop = False
        '
        'SlowfirstpassGroupBox
        '
        Me.SlowfirstpassGroupBox.Controls.Add(Me.SlowfirstpassCheckBox)
        resources.ApplyResources(Me.SlowfirstpassGroupBox, "SlowfirstpassGroupBox")
        Me.SlowfirstpassGroupBox.Name = "SlowfirstpassGroupBox"
        Me.SlowfirstpassGroupBox.TabStop = False
        '
        'SlowfirstpassCheckBox
        '
        resources.ApplyResources(Me.SlowfirstpassCheckBox, "SlowfirstpassCheckBox")
        Me.SlowfirstpassCheckBox.Name = "SlowfirstpassCheckBox"
        Me.SlowfirstpassCheckBox.UseVisualStyleBackColor = True
        '
        'LevelGroupBox
        '
        Me.LevelGroupBox.Controls.Add(Me.LevelComboBox)
        resources.ApplyResources(Me.LevelGroupBox, "LevelGroupBox")
        Me.LevelGroupBox.Name = "LevelGroupBox"
        Me.LevelGroupBox.TabStop = False
        '
        'LevelComboBox
        '
        Me.LevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LevelComboBox.FormattingEnabled = True
        Me.LevelComboBox.Items.AddRange(New Object() {resources.GetString("LevelComboBox.Items"), resources.GetString("LevelComboBox.Items1"), resources.GetString("LevelComboBox.Items2"), resources.GetString("LevelComboBox.Items3"), resources.GetString("LevelComboBox.Items4"), resources.GetString("LevelComboBox.Items5"), resources.GetString("LevelComboBox.Items6"), resources.GetString("LevelComboBox.Items7"), resources.GetString("LevelComboBox.Items8"), resources.GetString("LevelComboBox.Items9"), resources.GetString("LevelComboBox.Items10"), resources.GetString("LevelComboBox.Items11"), resources.GetString("LevelComboBox.Items12"), resources.GetString("LevelComboBox.Items13"), resources.GetString("LevelComboBox.Items14"), resources.GetString("LevelComboBox.Items15")})
        resources.ApplyResources(Me.LevelComboBox, "LevelComboBox")
        Me.LevelComboBox.Name = "LevelComboBox"
        '
        'ProfileGroupBox
        '
        Me.ProfileGroupBox.Controls.Add(Me.ProfileComboBox)
        resources.ApplyResources(Me.ProfileGroupBox, "ProfileGroupBox")
        Me.ProfileGroupBox.Name = "ProfileGroupBox"
        Me.ProfileGroupBox.TabStop = False
        '
        'ProfileComboBox
        '
        Me.ProfileComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ProfileComboBox.FormattingEnabled = True
        Me.ProfileComboBox.Items.AddRange(New Object() {resources.GetString("ProfileComboBox.Items"), resources.GetString("ProfileComboBox.Items1"), resources.GetString("ProfileComboBox.Items2")})
        resources.ApplyResources(Me.ProfileComboBox, "ProfileComboBox")
        Me.ProfileComboBox.Name = "ProfileComboBox"
        '
        'ThreadsGroupBox
        '
        Me.ThreadsGroupBox.Controls.Add(Me.ThreadsNumericUpDown)
        Me.ThreadsGroupBox.Controls.Add(Me.ThreadsLabel)
        resources.ApplyResources(Me.ThreadsGroupBox, "ThreadsGroupBox")
        Me.ThreadsGroupBox.Name = "ThreadsGroupBox"
        Me.ThreadsGroupBox.TabStop = False
        '
        'ThreadsNumericUpDown
        '
        resources.ApplyResources(Me.ThreadsNumericUpDown, "ThreadsNumericUpDown")
        Me.ThreadsNumericUpDown.Maximum = New Decimal(New Integer() {16, 0, 0, 0})
        Me.ThreadsNumericUpDown.Name = "ThreadsNumericUpDown"
        '
        'ThreadsLabel
        '
        resources.ApplyResources(Me.ThreadsLabel, "ThreadsLabel")
        Me.ThreadsLabel.Name = "ThreadsLabel"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.CABACGroupBox)
        Me.TabPage2.Controls.Add(Me.GroupBox6)
        Me.TabPage2.Controls.Add(Me.BFramesGroupBox)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        resources.ApplyResources(Me.TabPage2, "TabPage2")
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'CABACGroupBox
        '
        Me.CABACGroupBox.Controls.Add(Me.CABACCheckBox)
        resources.ApplyResources(Me.CABACGroupBox, "CABACGroupBox")
        Me.CABACGroupBox.Name = "CABACGroupBox"
        Me.CABACGroupBox.TabStop = False
        '
        'CABACCheckBox
        '
        resources.ApplyResources(Me.CABACCheckBox, "CABACCheckBox")
        Me.CABACCheckBox.Name = "CABACCheckBox"
        Me.CABACCheckBox.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.AdaptiveIFramesDecisionCheckBox)
        Me.GroupBox6.Controls.Add(Me.PframeWeightedPredictionComboBox)
        Me.GroupBox6.Controls.Add(Me.PframeWeightedPredictionLabel)
        Me.GroupBox6.Controls.Add(Me.ExtraIFramesNumericUpDown)
        Me.GroupBox6.Controls.Add(Me.ExtraIFramesLabel)
        Me.GroupBox6.Controls.Add(Me.ReferenceFramesNumericUpDown)
        Me.GroupBox6.Controls.Add(Me.Label8)
        resources.ApplyResources(Me.GroupBox6, "GroupBox6")
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.TabStop = False
        '
        'AdaptiveIFramesDecisionCheckBox
        '
        resources.ApplyResources(Me.AdaptiveIFramesDecisionCheckBox, "AdaptiveIFramesDecisionCheckBox")
        Me.AdaptiveIFramesDecisionCheckBox.Name = "AdaptiveIFramesDecisionCheckBox"
        Me.AdaptiveIFramesDecisionCheckBox.UseVisualStyleBackColor = True
        '
        'PframeWeightedPredictionComboBox
        '
        Me.PframeWeightedPredictionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PframeWeightedPredictionComboBox.FormattingEnabled = True
        Me.PframeWeightedPredictionComboBox.Items.AddRange(New Object() {resources.GetString("PframeWeightedPredictionComboBox.Items"), resources.GetString("PframeWeightedPredictionComboBox.Items1"), resources.GetString("PframeWeightedPredictionComboBox.Items2")})
        resources.ApplyResources(Me.PframeWeightedPredictionComboBox, "PframeWeightedPredictionComboBox")
        Me.PframeWeightedPredictionComboBox.Name = "PframeWeightedPredictionComboBox"
        '
        'PframeWeightedPredictionLabel
        '
        resources.ApplyResources(Me.PframeWeightedPredictionLabel, "PframeWeightedPredictionLabel")
        Me.PframeWeightedPredictionLabel.Name = "PframeWeightedPredictionLabel"
        '
        'ExtraIFramesNumericUpDown
        '
        resources.ApplyResources(Me.ExtraIFramesNumericUpDown, "ExtraIFramesNumericUpDown")
        Me.ExtraIFramesNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.ExtraIFramesNumericUpDown.Name = "ExtraIFramesNumericUpDown"
        '
        'ExtraIFramesLabel
        '
        resources.ApplyResources(Me.ExtraIFramesLabel, "ExtraIFramesLabel")
        Me.ExtraIFramesLabel.Name = "ExtraIFramesLabel"
        '
        'ReferenceFramesNumericUpDown
        '
        resources.ApplyResources(Me.ReferenceFramesNumericUpDown, "ReferenceFramesNumericUpDown")
        Me.ReferenceFramesNumericUpDown.Maximum = New Decimal(New Integer() {16, 0, 0, 0})
        Me.ReferenceFramesNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ReferenceFramesNumericUpDown.Name = "ReferenceFramesNumericUpDown"
        Me.ReferenceFramesNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'BFramesGroupBox
        '
        Me.BFramesGroupBox.Controls.Add(Me.BFrameWeightedPredictionCheckBox)
        Me.BFramesGroupBox.Controls.Add(Me.BFramePyramidCheckBox)
        Me.BFramesGroupBox.Controls.Add(Me.AdaptiveBFramesComboBox)
        Me.BFramesGroupBox.Controls.Add(Me.BFrameBiasNumericUpDown)
        Me.BFramesGroupBox.Controls.Add(Me.BFramesNumericUpDown)
        Me.BFramesGroupBox.Controls.Add(Me.BFrameBiasLabel)
        Me.BFramesGroupBox.Controls.Add(Me.AdaptiveBFramesLabel)
        Me.BFramesGroupBox.Controls.Add(Me.Label4)
        resources.ApplyResources(Me.BFramesGroupBox, "BFramesGroupBox")
        Me.BFramesGroupBox.Name = "BFramesGroupBox"
        Me.BFramesGroupBox.TabStop = False
        '
        'BFrameWeightedPredictionCheckBox
        '
        resources.ApplyResources(Me.BFrameWeightedPredictionCheckBox, "BFrameWeightedPredictionCheckBox")
        Me.BFrameWeightedPredictionCheckBox.Name = "BFrameWeightedPredictionCheckBox"
        Me.BFrameWeightedPredictionCheckBox.UseVisualStyleBackColor = True
        '
        'BFramePyramidCheckBox
        '
        resources.ApplyResources(Me.BFramePyramidCheckBox, "BFramePyramidCheckBox")
        Me.BFramePyramidCheckBox.Name = "BFramePyramidCheckBox"
        Me.BFramePyramidCheckBox.UseVisualStyleBackColor = True
        '
        'AdaptiveBFramesComboBox
        '
        Me.AdaptiveBFramesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.AdaptiveBFramesComboBox, "AdaptiveBFramesComboBox")
        Me.AdaptiveBFramesComboBox.FormattingEnabled = True
        Me.AdaptiveBFramesComboBox.Items.AddRange(New Object() {resources.GetString("AdaptiveBFramesComboBox.Items"), resources.GetString("AdaptiveBFramesComboBox.Items1"), resources.GetString("AdaptiveBFramesComboBox.Items2")})
        Me.AdaptiveBFramesComboBox.Name = "AdaptiveBFramesComboBox"
        '
        'BFrameBiasNumericUpDown
        '
        resources.ApplyResources(Me.BFrameBiasNumericUpDown, "BFrameBiasNumericUpDown")
        Me.BFrameBiasNumericUpDown.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.BFrameBiasNumericUpDown.Name = "BFrameBiasNumericUpDown"
        '
        'BFramesNumericUpDown
        '
        resources.ApplyResources(Me.BFramesNumericUpDown, "BFramesNumericUpDown")
        Me.BFramesNumericUpDown.Maximum = New Decimal(New Integer() {16, 0, 0, 0})
        Me.BFramesNumericUpDown.Name = "BFramesNumericUpDown"
        '
        'BFrameBiasLabel
        '
        resources.ApplyResources(Me.BFrameBiasLabel, "BFrameBiasLabel")
        Me.BFrameBiasLabel.Name = "BFrameBiasLabel"
        '
        'AdaptiveBFramesLabel
        '
        resources.ApplyResources(Me.AdaptiveBFramesLabel, "AdaptiveBFramesLabel")
        Me.AdaptiveBFramesLabel.Name = "AdaptiveBFramesLabel"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DeblockingBetaNumericUpDown)
        Me.GroupBox4.Controls.Add(Me.DeblockingAlphaNumericUpDown)
        Me.GroupBox4.Controls.Add(Me.DeblockingBetaLabel)
        Me.GroupBox4.Controls.Add(Me.DeblockingAlphaLabel)
        Me.GroupBox4.Controls.Add(Me.DeblockingCheckBox)
        resources.ApplyResources(Me.GroupBox4, "GroupBox4")
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.TabStop = False
        '
        'DeblockingBetaNumericUpDown
        '
        resources.ApplyResources(Me.DeblockingBetaNumericUpDown, "DeblockingBetaNumericUpDown")
        Me.DeblockingBetaNumericUpDown.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.DeblockingBetaNumericUpDown.Minimum = New Decimal(New Integer() {6, 0, 0, -2147483648})
        Me.DeblockingBetaNumericUpDown.Name = "DeblockingBetaNumericUpDown"
        '
        'DeblockingAlphaNumericUpDown
        '
        resources.ApplyResources(Me.DeblockingAlphaNumericUpDown, "DeblockingAlphaNumericUpDown")
        Me.DeblockingAlphaNumericUpDown.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.DeblockingAlphaNumericUpDown.Minimum = New Decimal(New Integer() {6, 0, 0, -2147483648})
        Me.DeblockingAlphaNumericUpDown.Name = "DeblockingAlphaNumericUpDown"
        '
        'DeblockingBetaLabel
        '
        resources.ApplyResources(Me.DeblockingBetaLabel, "DeblockingBetaLabel")
        Me.DeblockingBetaLabel.Name = "DeblockingBetaLabel"
        '
        'DeblockingAlphaLabel
        '
        resources.ApplyResources(Me.DeblockingAlphaLabel, "DeblockingAlphaLabel")
        Me.DeblockingAlphaLabel.Name = "DeblockingAlphaLabel"
        '
        'DeblockingCheckBox
        '
        resources.ApplyResources(Me.DeblockingCheckBox, "DeblockingCheckBox")
        Me.DeblockingCheckBox.Name = "DeblockingCheckBox"
        Me.DeblockingCheckBox.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.RateControlGroupBox)
        Me.TabPage3.Controls.Add(Me.AdaptiveQuantizersGroupBox)
        Me.TabPage3.Controls.Add(Me.GroupBox8)
        resources.ApplyResources(Me.TabPage3, "TabPage3")
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'RateControlGroupBox
        '
        Me.RateControlGroupBox.Controls.Add(Me.TempBlurofQuantafterCCNumericUpDown)
        Me.RateControlGroupBox.Controls.Add(Me.TempBlurofQuantafterCCLabel)
        Me.RateControlGroupBox.Controls.Add(Me.TempBlurofestFramecomplexityNumericUpDown)
        Me.RateControlGroupBox.Controls.Add(Me.TempBlurofestFramecomplexityLabel)
        Me.RateControlGroupBox.Controls.Add(Me.UseMBTreeCheckBox)
        Me.RateControlGroupBox.Controls.Add(Me.NumberofFramesforLookaheadNumericUpDown)
        Me.RateControlGroupBox.Controls.Add(Me.Label26)
        Me.RateControlGroupBox.Controls.Add(Me.QuantizerCompressionNumericUpDown)
        Me.RateControlGroupBox.Controls.Add(Me.Label25)
        Me.RateControlGroupBox.Controls.Add(Me.AverageBitrateVarianceNumericUpDown)
        Me.RateControlGroupBox.Controls.Add(Me.AverageBitrateVarianceLabel)
        Me.RateControlGroupBox.Controls.Add(Me.VBVInitialBufferNumericUpDown)
        Me.RateControlGroupBox.Controls.Add(Me.Label23)
        Me.RateControlGroupBox.Controls.Add(Me.VBVMaximumBitrateNumericUpDown)
        Me.RateControlGroupBox.Controls.Add(Me.Label22)
        Me.RateControlGroupBox.Controls.Add(Me.VBVBufferSizeNumericUpDown)
        Me.RateControlGroupBox.Controls.Add(Me.Label21)
        resources.ApplyResources(Me.RateControlGroupBox, "RateControlGroupBox")
        Me.RateControlGroupBox.Name = "RateControlGroupBox"
        Me.RateControlGroupBox.TabStop = False
        '
        'TempBlurofQuantafterCCNumericUpDown
        '
        Me.TempBlurofQuantafterCCNumericUpDown.DecimalPlaces = 1
        Me.TempBlurofQuantafterCCNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        resources.ApplyResources(Me.TempBlurofQuantafterCCNumericUpDown, "TempBlurofQuantafterCCNumericUpDown")
        Me.TempBlurofQuantafterCCNumericUpDown.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.TempBlurofQuantafterCCNumericUpDown.Name = "TempBlurofQuantafterCCNumericUpDown"
        '
        'TempBlurofQuantafterCCLabel
        '
        resources.ApplyResources(Me.TempBlurofQuantafterCCLabel, "TempBlurofQuantafterCCLabel")
        Me.TempBlurofQuantafterCCLabel.Name = "TempBlurofQuantafterCCLabel"
        '
        'TempBlurofestFramecomplexityNumericUpDown
        '
        Me.TempBlurofestFramecomplexityNumericUpDown.DecimalPlaces = 1
        Me.TempBlurofestFramecomplexityNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        resources.ApplyResources(Me.TempBlurofestFramecomplexityNumericUpDown, "TempBlurofestFramecomplexityNumericUpDown")
        Me.TempBlurofestFramecomplexityNumericUpDown.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.TempBlurofestFramecomplexityNumericUpDown.Name = "TempBlurofestFramecomplexityNumericUpDown"
        '
        'TempBlurofestFramecomplexityLabel
        '
        resources.ApplyResources(Me.TempBlurofestFramecomplexityLabel, "TempBlurofestFramecomplexityLabel")
        Me.TempBlurofestFramecomplexityLabel.Name = "TempBlurofestFramecomplexityLabel"
        '
        'UseMBTreeCheckBox
        '
        resources.ApplyResources(Me.UseMBTreeCheckBox, "UseMBTreeCheckBox")
        Me.UseMBTreeCheckBox.Name = "UseMBTreeCheckBox"
        Me.UseMBTreeCheckBox.UseVisualStyleBackColor = True
        '
        'NumberofFramesforLookaheadNumericUpDown
        '
        resources.ApplyResources(Me.NumberofFramesforLookaheadNumericUpDown, "NumberofFramesforLookaheadNumericUpDown")
        Me.NumberofFramesforLookaheadNumericUpDown.Maximum = New Decimal(New Integer() {250, 0, 0, 0})
        Me.NumberofFramesforLookaheadNumericUpDown.Name = "NumberofFramesforLookaheadNumericUpDown"
        Me.NumberofFramesforLookaheadNumericUpDown.Value = New Decimal(New Integer() {40, 0, 0, 0})
        '
        'Label26
        '
        resources.ApplyResources(Me.Label26, "Label26")
        Me.Label26.Name = "Label26"
        '
        'QuantizerCompressionNumericUpDown
        '
        Me.QuantizerCompressionNumericUpDown.DecimalPlaces = 1
        Me.QuantizerCompressionNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        resources.ApplyResources(Me.QuantizerCompressionNumericUpDown, "QuantizerCompressionNumericUpDown")
        Me.QuantizerCompressionNumericUpDown.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.QuantizerCompressionNumericUpDown.Name = "QuantizerCompressionNumericUpDown"
        Me.QuantizerCompressionNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label25
        '
        resources.ApplyResources(Me.Label25, "Label25")
        Me.Label25.Name = "Label25"
        '
        'AverageBitrateVarianceNumericUpDown
        '
        Me.AverageBitrateVarianceNumericUpDown.DecimalPlaces = 1
        Me.AverageBitrateVarianceNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        resources.ApplyResources(Me.AverageBitrateVarianceNumericUpDown, "AverageBitrateVarianceNumericUpDown")
        Me.AverageBitrateVarianceNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.AverageBitrateVarianceNumericUpDown.Name = "AverageBitrateVarianceNumericUpDown"
        Me.AverageBitrateVarianceNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'AverageBitrateVarianceLabel
        '
        resources.ApplyResources(Me.AverageBitrateVarianceLabel, "AverageBitrateVarianceLabel")
        Me.AverageBitrateVarianceLabel.Name = "AverageBitrateVarianceLabel"
        '
        'VBVInitialBufferNumericUpDown
        '
        Me.VBVInitialBufferNumericUpDown.DecimalPlaces = 1
        Me.VBVInitialBufferNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        resources.ApplyResources(Me.VBVInitialBufferNumericUpDown, "VBVInitialBufferNumericUpDown")
        Me.VBVInitialBufferNumericUpDown.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.VBVInitialBufferNumericUpDown.Name = "VBVInitialBufferNumericUpDown"
        Me.VBVInitialBufferNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label23
        '
        resources.ApplyResources(Me.Label23, "Label23")
        Me.Label23.Name = "Label23"
        '
        'VBVMaximumBitrateNumericUpDown
        '
        resources.ApplyResources(Me.VBVMaximumBitrateNumericUpDown, "VBVMaximumBitrateNumericUpDown")
        Me.VBVMaximumBitrateNumericUpDown.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.VBVMaximumBitrateNumericUpDown.Name = "VBVMaximumBitrateNumericUpDown"
        Me.VBVMaximumBitrateNumericUpDown.Value = New Decimal(New Integer() {100000, 0, 0, 0})
        '
        'Label22
        '
        resources.ApplyResources(Me.Label22, "Label22")
        Me.Label22.Name = "Label22"
        '
        'VBVBufferSizeNumericUpDown
        '
        resources.ApplyResources(Me.VBVBufferSizeNumericUpDown, "VBVBufferSizeNumericUpDown")
        Me.VBVBufferSizeNumericUpDown.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.VBVBufferSizeNumericUpDown.Name = "VBVBufferSizeNumericUpDown"
        Me.VBVBufferSizeNumericUpDown.Value = New Decimal(New Integer() {100000, 0, 0, 0})
        '
        'Label21
        '
        resources.ApplyResources(Me.Label21, "Label21")
        Me.Label21.Name = "Label21"
        '
        'AdaptiveQuantizersGroupBox
        '
        Me.AdaptiveQuantizersGroupBox.Controls.Add(Me.AdaptiveQuantizersStrengthNumericUpDown)
        Me.AdaptiveQuantizersGroupBox.Controls.Add(Me.Label20)
        Me.AdaptiveQuantizersGroupBox.Controls.Add(Me.AdaptiveQuantizersModeComboBox)
        Me.AdaptiveQuantizersGroupBox.Controls.Add(Me.Label19)
        resources.ApplyResources(Me.AdaptiveQuantizersGroupBox, "AdaptiveQuantizersGroupBox")
        Me.AdaptiveQuantizersGroupBox.Name = "AdaptiveQuantizersGroupBox"
        Me.AdaptiveQuantizersGroupBox.TabStop = False
        '
        'AdaptiveQuantizersStrengthNumericUpDown
        '
        Me.AdaptiveQuantizersStrengthNumericUpDown.DecimalPlaces = 1
        Me.AdaptiveQuantizersStrengthNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        resources.ApplyResources(Me.AdaptiveQuantizersStrengthNumericUpDown, "AdaptiveQuantizersStrengthNumericUpDown")
        Me.AdaptiveQuantizersStrengthNumericUpDown.Maximum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.AdaptiveQuantizersStrengthNumericUpDown.Name = "AdaptiveQuantizersStrengthNumericUpDown"
        Me.AdaptiveQuantizersStrengthNumericUpDown.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label20
        '
        resources.ApplyResources(Me.Label20, "Label20")
        Me.Label20.Name = "Label20"
        '
        'AdaptiveQuantizersModeComboBox
        '
        Me.AdaptiveQuantizersModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AdaptiveQuantizersModeComboBox.FormattingEnabled = True
        Me.AdaptiveQuantizersModeComboBox.Items.AddRange(New Object() {resources.GetString("AdaptiveQuantizersModeComboBox.Items"), resources.GetString("AdaptiveQuantizersModeComboBox.Items1"), resources.GetString("AdaptiveQuantizersModeComboBox.Items2")})
        resources.ApplyResources(Me.AdaptiveQuantizersModeComboBox, "AdaptiveQuantizersModeComboBox")
        Me.AdaptiveQuantizersModeComboBox.Name = "AdaptiveQuantizersModeComboBox"
        '
        'Label19
        '
        resources.ApplyResources(Me.Label19, "Label19")
        Me.Label19.Name = "Label19"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.ChromaandLumaQPOffsetNumericUpDown)
        Me.GroupBox8.Controls.Add(Me.Label17)
        Me.GroupBox8.Controls.Add(Me.QPBRatioNumericUpDown)
        Me.GroupBox8.Controls.Add(Me.Label13)
        Me.GroupBox8.Controls.Add(Me.QIPRatioNumericUpDown)
        Me.GroupBox8.Controls.Add(Me.Label11)
        Me.GroupBox8.Controls.Add(Me.QDeltaNumericUpDown)
        Me.GroupBox8.Controls.Add(Me.QMaxNumericUpDown)
        Me.GroupBox8.Controls.Add(Me.QMinNumericUpDown)
        Me.GroupBox8.Controls.Add(Me.Label12)
        resources.ApplyResources(Me.GroupBox8, "GroupBox8")
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.TabStop = False
        '
        'ChromaandLumaQPOffsetNumericUpDown
        '
        resources.ApplyResources(Me.ChromaandLumaQPOffsetNumericUpDown, "ChromaandLumaQPOffsetNumericUpDown")
        Me.ChromaandLumaQPOffsetNumericUpDown.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.ChromaandLumaQPOffsetNumericUpDown.Minimum = New Decimal(New Integer() {12, 0, 0, -2147483648})
        Me.ChromaandLumaQPOffsetNumericUpDown.Name = "ChromaandLumaQPOffsetNumericUpDown"
        Me.ChromaandLumaQPOffsetNumericUpDown.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label17
        '
        resources.ApplyResources(Me.Label17, "Label17")
        Me.Label17.Name = "Label17"
        '
        'QPBRatioNumericUpDown
        '
        Me.QPBRatioNumericUpDown.DecimalPlaces = 1
        Me.QPBRatioNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        resources.ApplyResources(Me.QPBRatioNumericUpDown, "QPBRatioNumericUpDown")
        Me.QPBRatioNumericUpDown.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.QPBRatioNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.QPBRatioNumericUpDown.Name = "QPBRatioNumericUpDown"
        Me.QPBRatioNumericUpDown.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label13
        '
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.Name = "Label13"
        '
        'QIPRatioNumericUpDown
        '
        Me.QIPRatioNumericUpDown.DecimalPlaces = 2
        Me.QIPRatioNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        resources.ApplyResources(Me.QIPRatioNumericUpDown, "QIPRatioNumericUpDown")
        Me.QIPRatioNumericUpDown.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.QIPRatioNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.QIPRatioNumericUpDown.Name = "QIPRatioNumericUpDown"
        Me.QIPRatioNumericUpDown.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.Name = "Label11"
        '
        'QDeltaNumericUpDown
        '
        resources.ApplyResources(Me.QDeltaNumericUpDown, "QDeltaNumericUpDown")
        Me.QDeltaNumericUpDown.Maximum = New Decimal(New Integer() {51, 0, 0, 0})
        Me.QDeltaNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.QDeltaNumericUpDown.Name = "QDeltaNumericUpDown"
        Me.QDeltaNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'QMaxNumericUpDown
        '
        resources.ApplyResources(Me.QMaxNumericUpDown, "QMaxNumericUpDown")
        Me.QMaxNumericUpDown.Maximum = New Decimal(New Integer() {69, 0, 0, 0})
        Me.QMaxNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.QMaxNumericUpDown.Name = "QMaxNumericUpDown"
        Me.QMaxNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'QMinNumericUpDown
        '
        resources.ApplyResources(Me.QMinNumericUpDown, "QMinNumericUpDown")
        Me.QMinNumericUpDown.Maximum = New Decimal(New Integer() {51, 0, 0, 0})
        Me.QMinNumericUpDown.Name = "QMinNumericUpDown"
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.Name = "Label12"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GroupBox17)
        Me.TabPage4.Controls.Add(Me.GroupBox16)
        Me.TabPage4.Controls.Add(Me.GroupBox14)
        Me.TabPage4.Controls.Add(Me.GroupBox13)
        Me.TabPage4.Controls.Add(Me.GroupBox12)
        resources.ApplyResources(Me.TabPage4, "TabPage4")
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GroupBox17
        '
        Me.GroupBox17.Controls.Add(Me.UseaccessunitdelimitersCheckBox)
        resources.ApplyResources(Me.GroupBox17, "GroupBox17")
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.TabStop = False
        '
        'UseaccessunitdelimitersCheckBox
        '
        resources.ApplyResources(Me.UseaccessunitdelimitersCheckBox, "UseaccessunitdelimitersCheckBox")
        Me.UseaccessunitdelimitersCheckBox.Name = "UseaccessunitdelimitersCheckBox"
        Me.UseaccessunitdelimitersCheckBox.UseVisualStyleBackColor = True
        '
        'GroupBox16
        '
        Me.GroupBox16.Controls.Add(Me.NoiseReductionNumericUpDown)
        resources.ApplyResources(Me.GroupBox16, "GroupBox16")
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.TabStop = False
        '
        'NoiseReductionNumericUpDown
        '
        resources.ApplyResources(Me.NoiseReductionNumericUpDown, "NoiseReductionNumericUpDown")
        Me.NoiseReductionNumericUpDown.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NoiseReductionNumericUpDown.Name = "NoiseReductionNumericUpDown"
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.NoPsychovisualEnhancementsCheckBox)
        Me.GroupBox14.Controls.Add(Me.NoFastPSkipCheckBox)
        Me.GroupBox14.Controls.Add(Me.NoMixedReferenceFramesCheckBox)
        Me.GroupBox14.Controls.Add(Me.PsyTrellisStrengthNumericUpDown)
        Me.GroupBox14.Controls.Add(Me.Label33)
        Me.GroupBox14.Controls.Add(Me.PsyRDStrengthNumericUpDown)
        Me.GroupBox14.Controls.Add(Me.Label32)
        Me.GroupBox14.Controls.Add(Me.TrellisComboBox)
        Me.GroupBox14.Controls.Add(Me.TrellisLabel)
        Me.GroupBox14.Controls.Add(Me.MVPredictionModeComboBox)
        Me.GroupBox14.Controls.Add(Me.MVPredictionModeLabel)
        resources.ApplyResources(Me.GroupBox14, "GroupBox14")
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.TabStop = False
        '
        'NoPsychovisualEnhancementsCheckBox
        '
        resources.ApplyResources(Me.NoPsychovisualEnhancementsCheckBox, "NoPsychovisualEnhancementsCheckBox")
        Me.NoPsychovisualEnhancementsCheckBox.Name = "NoPsychovisualEnhancementsCheckBox"
        Me.NoPsychovisualEnhancementsCheckBox.UseVisualStyleBackColor = True
        '
        'NoFastPSkipCheckBox
        '
        resources.ApplyResources(Me.NoFastPSkipCheckBox, "NoFastPSkipCheckBox")
        Me.NoFastPSkipCheckBox.Name = "NoFastPSkipCheckBox"
        Me.NoFastPSkipCheckBox.UseVisualStyleBackColor = True
        '
        'NoMixedReferenceFramesCheckBox
        '
        resources.ApplyResources(Me.NoMixedReferenceFramesCheckBox, "NoMixedReferenceFramesCheckBox")
        Me.NoMixedReferenceFramesCheckBox.Name = "NoMixedReferenceFramesCheckBox"
        Me.NoMixedReferenceFramesCheckBox.UseVisualStyleBackColor = True
        '
        'PsyTrellisStrengthNumericUpDown
        '
        Me.PsyTrellisStrengthNumericUpDown.DecimalPlaces = 2
        Me.PsyTrellisStrengthNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        resources.ApplyResources(Me.PsyTrellisStrengthNumericUpDown, "PsyTrellisStrengthNumericUpDown")
        Me.PsyTrellisStrengthNumericUpDown.Name = "PsyTrellisStrengthNumericUpDown"
        Me.PsyTrellisStrengthNumericUpDown.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label33
        '
        resources.ApplyResources(Me.Label33, "Label33")
        Me.Label33.Name = "Label33"
        '
        'PsyRDStrengthNumericUpDown
        '
        Me.PsyRDStrengthNumericUpDown.DecimalPlaces = 2
        Me.PsyRDStrengthNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        resources.ApplyResources(Me.PsyRDStrengthNumericUpDown, "PsyRDStrengthNumericUpDown")
        Me.PsyRDStrengthNumericUpDown.Maximum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.PsyRDStrengthNumericUpDown.Name = "PsyRDStrengthNumericUpDown"
        Me.PsyRDStrengthNumericUpDown.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label32
        '
        resources.ApplyResources(Me.Label32, "Label32")
        Me.Label32.Name = "Label32"
        '
        'TrellisComboBox
        '
        Me.TrellisComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TrellisComboBox.FormattingEnabled = True
        Me.TrellisComboBox.Items.AddRange(New Object() {resources.GetString("TrellisComboBox.Items"), resources.GetString("TrellisComboBox.Items1"), resources.GetString("TrellisComboBox.Items2")})
        resources.ApplyResources(Me.TrellisComboBox, "TrellisComboBox")
        Me.TrellisComboBox.Name = "TrellisComboBox"
        '
        'TrellisLabel
        '
        resources.ApplyResources(Me.TrellisLabel, "TrellisLabel")
        Me.TrellisLabel.Name = "TrellisLabel"
        '
        'MVPredictionModeComboBox
        '
        Me.MVPredictionModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MVPredictionModeComboBox.FormattingEnabled = True
        Me.MVPredictionModeComboBox.Items.AddRange(New Object() {resources.GetString("MVPredictionModeComboBox.Items"), resources.GetString("MVPredictionModeComboBox.Items1"), resources.GetString("MVPredictionModeComboBox.Items2"), resources.GetString("MVPredictionModeComboBox.Items3")})
        resources.ApplyResources(Me.MVPredictionModeComboBox, "MVPredictionModeComboBox")
        Me.MVPredictionModeComboBox.Name = "MVPredictionModeComboBox"
        '
        'MVPredictionModeLabel
        '
        resources.ApplyResources(Me.MVPredictionModeLabel, "MVPredictionModeLabel")
        Me.MVPredictionModeLabel.Name = "MVPredictionModeLabel"
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.MacroblocksComboBox)
        Me.GroupBox13.Controls.Add(Me.B8x8CheckBox)
        Me.GroupBox13.Controls.Add(Me.P8x8CheckBox)
        Me.GroupBox13.Controls.Add(Me.I8x8CheckBox)
        Me.GroupBox13.Controls.Add(Me.P4x4CheckBox)
        Me.GroupBox13.Controls.Add(Me.I4x4CheckBox)
        Me.GroupBox13.Controls.Add(Me.Adaptive8x8DCTCheckBox)
        resources.ApplyResources(Me.GroupBox13, "GroupBox13")
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.TabStop = False
        '
        'MacroblocksComboBox
        '
        Me.MacroblocksComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MacroblocksComboBox.FormattingEnabled = True
        Me.MacroblocksComboBox.Items.AddRange(New Object() {resources.GetString("MacroblocksComboBox.Items"), resources.GetString("MacroblocksComboBox.Items1")})
        resources.ApplyResources(Me.MacroblocksComboBox, "MacroblocksComboBox")
        Me.MacroblocksComboBox.Name = "MacroblocksComboBox"
        '
        'B8x8CheckBox
        '
        resources.ApplyResources(Me.B8x8CheckBox, "B8x8CheckBox")
        Me.B8x8CheckBox.Name = "B8x8CheckBox"
        Me.B8x8CheckBox.UseVisualStyleBackColor = True
        '
        'P8x8CheckBox
        '
        resources.ApplyResources(Me.P8x8CheckBox, "P8x8CheckBox")
        Me.P8x8CheckBox.Name = "P8x8CheckBox"
        Me.P8x8CheckBox.UseVisualStyleBackColor = True
        '
        'I8x8CheckBox
        '
        resources.ApplyResources(Me.I8x8CheckBox, "I8x8CheckBox")
        Me.I8x8CheckBox.Name = "I8x8CheckBox"
        Me.I8x8CheckBox.UseVisualStyleBackColor = True
        '
        'P4x4CheckBox
        '
        resources.ApplyResources(Me.P4x4CheckBox, "P4x4CheckBox")
        Me.P4x4CheckBox.Name = "P4x4CheckBox"
        Me.P4x4CheckBox.UseVisualStyleBackColor = True
        '
        'I4x4CheckBox
        '
        resources.ApplyResources(Me.I4x4CheckBox, "I4x4CheckBox")
        Me.I4x4CheckBox.Name = "I4x4CheckBox"
        Me.I4x4CheckBox.UseVisualStyleBackColor = True
        '
        'Adaptive8x8DCTCheckBox
        '
        resources.ApplyResources(Me.Adaptive8x8DCTCheckBox, "Adaptive8x8DCTCheckBox")
        Me.Adaptive8x8DCTCheckBox.Name = "Adaptive8x8DCTCheckBox"
        Me.Adaptive8x8DCTCheckBox.UseVisualStyleBackColor = True
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.SubpixelMEComboBox)
        Me.GroupBox12.Controls.Add(Me.Label27)
        Me.GroupBox12.Controls.Add(Me.MEMethodComboBox)
        Me.GroupBox12.Controls.Add(Me.ChromaMECheckBox)
        Me.GroupBox12.Controls.Add(Me.Label29)
        Me.GroupBox12.Controls.Add(Me.MERangeNumericUpDown)
        Me.GroupBox12.Controls.Add(Me.Label30)
        resources.ApplyResources(Me.GroupBox12, "GroupBox12")
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.TabStop = False
        '
        'SubpixelMEComboBox
        '
        Me.SubpixelMEComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SubpixelMEComboBox.FormattingEnabled = True
        Me.SubpixelMEComboBox.Items.AddRange(New Object() {resources.GetString("SubpixelMEComboBox.Items"), resources.GetString("SubpixelMEComboBox.Items1"), resources.GetString("SubpixelMEComboBox.Items2"), resources.GetString("SubpixelMEComboBox.Items3"), resources.GetString("SubpixelMEComboBox.Items4"), resources.GetString("SubpixelMEComboBox.Items5"), resources.GetString("SubpixelMEComboBox.Items6"), resources.GetString("SubpixelMEComboBox.Items7"), resources.GetString("SubpixelMEComboBox.Items8"), resources.GetString("SubpixelMEComboBox.Items9")})
        resources.ApplyResources(Me.SubpixelMEComboBox, "SubpixelMEComboBox")
        Me.SubpixelMEComboBox.Name = "SubpixelMEComboBox"
        '
        'Label27
        '
        resources.ApplyResources(Me.Label27, "Label27")
        Me.Label27.Name = "Label27"
        '
        'MEMethodComboBox
        '
        Me.MEMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MEMethodComboBox.FormattingEnabled = True
        Me.MEMethodComboBox.Items.AddRange(New Object() {resources.GetString("MEMethodComboBox.Items"), resources.GetString("MEMethodComboBox.Items1"), resources.GetString("MEMethodComboBox.Items2"), resources.GetString("MEMethodComboBox.Items3"), resources.GetString("MEMethodComboBox.Items4")})
        resources.ApplyResources(Me.MEMethodComboBox, "MEMethodComboBox")
        Me.MEMethodComboBox.Name = "MEMethodComboBox"
        '
        'ChromaMECheckBox
        '
        resources.ApplyResources(Me.ChromaMECheckBox, "ChromaMECheckBox")
        Me.ChromaMECheckBox.Name = "ChromaMECheckBox"
        Me.ChromaMECheckBox.UseVisualStyleBackColor = True
        '
        'Label29
        '
        resources.ApplyResources(Me.Label29, "Label29")
        Me.Label29.Name = "Label29"
        '
        'MERangeNumericUpDown
        '
        resources.ApplyResources(Me.MERangeNumericUpDown, "MERangeNumericUpDown")
        Me.MERangeNumericUpDown.Maximum = New Decimal(New Integer() {64, 0, 0, 0})
        Me.MERangeNumericUpDown.Minimum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.MERangeNumericUpDown.Name = "MERangeNumericUpDown"
        Me.MERangeNumericUpDown.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label30
        '
        resources.ApplyResources(Me.Label30, "Label30")
        Me.Label30.Name = "Label30"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.NumericUpDown13)
        Me.GroupBox9.Controls.Add(Me.Label14)
        Me.GroupBox9.Controls.Add(Me.NumericUpDown14)
        Me.GroupBox9.Controls.Add(Me.Label15)
        Me.GroupBox9.Controls.Add(Me.NumericUpDown15)
        Me.GroupBox9.Controls.Add(Me.NumericUpDown16)
        Me.GroupBox9.Controls.Add(Me.NumericUpDown17)
        Me.GroupBox9.Controls.Add(Me.Label16)
        resources.ApplyResources(Me.GroupBox9, "GroupBox9")
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.TabStop = False
        '
        'NumericUpDown13
        '
        Me.NumericUpDown13.DecimalPlaces = 1
        Me.NumericUpDown13.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        resources.ApplyResources(Me.NumericUpDown13, "NumericUpDown13")
        Me.NumericUpDown13.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown13.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown13.Name = "NumericUpDown13"
        Me.NumericUpDown13.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label14
        '
        resources.ApplyResources(Me.Label14, "Label14")
        Me.Label14.Name = "Label14"
        '
        'NumericUpDown14
        '
        Me.NumericUpDown14.DecimalPlaces = 1
        Me.NumericUpDown14.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        resources.ApplyResources(Me.NumericUpDown14, "NumericUpDown14")
        Me.NumericUpDown14.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown14.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown14.Name = "NumericUpDown14"
        Me.NumericUpDown14.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label15
        '
        resources.ApplyResources(Me.Label15, "Label15")
        Me.Label15.Name = "Label15"
        '
        'NumericUpDown15
        '
        resources.ApplyResources(Me.NumericUpDown15, "NumericUpDown15")
        Me.NumericUpDown15.Maximum = New Decimal(New Integer() {51, 0, 0, 0})
        Me.NumericUpDown15.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown15.Name = "NumericUpDown15"
        Me.NumericUpDown15.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NumericUpDown16
        '
        resources.ApplyResources(Me.NumericUpDown16, "NumericUpDown16")
        Me.NumericUpDown16.Maximum = New Decimal(New Integer() {51, 0, 0, 0})
        Me.NumericUpDown16.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown16.Name = "NumericUpDown16"
        Me.NumericUpDown16.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NumericUpDown17
        '
        resources.ApplyResources(Me.NumericUpDown17, "NumericUpDown17")
        Me.NumericUpDown17.Maximum = New Decimal(New Integer() {51, 0, 0, 0})
        Me.NumericUpDown17.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown17.Name = "NumericUpDown17"
        Me.NumericUpDown17.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label16
        '
        resources.ApplyResources(Me.Label16, "Label16")
        Me.Label16.Name = "Label16"
        '
        'DefBTN
        '
        resources.ApplyResources(Me.DefBTN, "DefBTN")
        Me.DefBTN.Name = "DefBTN"
        Me.DefBTN.UseVisualStyleBackColor = True
        '
        'CancelBTN
        '
        resources.ApplyResources(Me.CancelBTN, "CancelBTN")
        Me.CancelBTN.Name = "CancelBTN"
        Me.CancelBTN.UseVisualStyleBackColor = True
        '
        'OKBTN
        '
        resources.ApplyResources(Me.OKBTN, "OKBTN")
        Me.OKBTN.Name = "OKBTN"
        Me.OKBTN.UseVisualStyleBackColor = True
        '
        'BPanel
        '
        Me.BPanel.Controls.Add(Me.SettingTabControl)
        Me.BPanel.Controls.Add(Me.OKBTN)
        Me.BPanel.Controls.Add(Me.DefBTN)
        Me.BPanel.Controls.Add(Me.CancelBTN)
        resources.ApplyResources(Me.BPanel, "BPanel")
        Me.BPanel.Name = "BPanel"
        '
        'SLabel
        '
        resources.ApplyResources(Me.SLabel, "SLabel")
        Me.SLabel.Name = "SLabel"
        '
        'x264optsFrm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "x264optsFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SettingTabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TuningsGroupBox.ResumeLayout(False)
        Me.PresetsGroupBox.ResumeLayout(False)
        Me.PresetsGroupBox.PerformLayout()
        CType(Me.PresetsTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ffmpegPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.x264PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SlowfirstpassGroupBox.ResumeLayout(False)
        Me.SlowfirstpassGroupBox.PerformLayout()
        Me.LevelGroupBox.ResumeLayout(False)
        Me.ProfileGroupBox.ResumeLayout(False)
        Me.ThreadsGroupBox.ResumeLayout(False)
        Me.ThreadsGroupBox.PerformLayout()
        CType(Me.ThreadsNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.CABACGroupBox.ResumeLayout(False)
        Me.CABACGroupBox.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.ExtraIFramesNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReferenceFramesNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BFramesGroupBox.ResumeLayout(False)
        Me.BFramesGroupBox.PerformLayout()
        CType(Me.BFrameBiasNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BFramesNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DeblockingBetaNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeblockingAlphaNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.RateControlGroupBox.ResumeLayout(False)
        Me.RateControlGroupBox.PerformLayout()
        CType(Me.TempBlurofQuantafterCCNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TempBlurofestFramecomplexityNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumberofFramesforLookaheadNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantizerCompressionNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AverageBitrateVarianceNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VBVInitialBufferNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VBVMaximumBitrateNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VBVBufferSizeNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AdaptiveQuantizersGroupBox.ResumeLayout(False)
        CType(Me.AdaptiveQuantizersStrengthNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        CType(Me.ChromaandLumaQPOffsetNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QPBRatioNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QIPRatioNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QDeltaNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QMaxNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QMinNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox17.ResumeLayout(False)
        Me.GroupBox17.PerformLayout()
        Me.GroupBox16.ResumeLayout(False)
        CType(Me.NoiseReductionNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        CType(Me.PsyTrellisStrengthNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PsyRDStrengthNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        CType(Me.MERangeNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox9.ResumeLayout(False)
        CType(Me.NumericUpDown13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown17, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SettingTabControl As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ProfileGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ThreadsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ThreadsNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents ThreadsLabel As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents LevelComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ProfileComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents LevelGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DeblockingAlphaLabel As System.Windows.Forms.Label
    Friend WithEvents DeblockingCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents BFramesGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents DeblockingBetaNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents DeblockingAlphaNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents DeblockingBetaLabel As System.Windows.Forms.Label
    Friend WithEvents BFrameBiasNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents BFramesNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents BFrameBiasLabel As System.Windows.Forms.Label
    Friend WithEvents AdaptiveBFramesLabel As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BFrameWeightedPredictionCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents BFramePyramidCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AdaptiveBFramesComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents ExtraIFramesNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents ExtraIFramesLabel As System.Windows.Forms.Label
    Friend WithEvents ReferenceFramesNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents AdaptiveIFramesDecisionCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents PframeWeightedPredictionComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PframeWeightedPredictionLabel As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents QMinNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ChromaandLumaQPOffsetNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents QPBRatioNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents QIPRatioNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents QDeltaNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents QMaxNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents NumericUpDown13 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown14 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown15 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown16 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown17 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents AdaptiveQuantizersGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents AdaptiveQuantizersModeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents AdaptiveQuantizersStrengthNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents RateControlGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents VBVBufferSizeNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents AverageBitrateVarianceNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents AverageBitrateVarianceLabel As System.Windows.Forms.Label
    Friend WithEvents VBVInitialBufferNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents VBVMaximumBitrateNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents QuantizerCompressionNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents NumberofFramesforLookaheadNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents UseMBTreeCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents ChromaMECheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents MERangeNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents SubpixelMEComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents MEMethodComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents B8x8CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents P8x8CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents I8x8CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents P4x4CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents I4x4CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Adaptive8x8DCTCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
    Friend WithEvents MVPredictionModeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MVPredictionModeLabel As System.Windows.Forms.Label
    Friend WithEvents TrellisComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TrellisLabel As System.Windows.Forms.Label
    Friend WithEvents PsyTrellisStrengthNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents PsyRDStrengthNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents CABACGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents CABACCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents NoFastPSkipCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents NoMixedReferenceFramesCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox17 As System.Windows.Forms.GroupBox
    Friend WithEvents UseaccessunitdelimitersCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox16 As System.Windows.Forms.GroupBox
    Friend WithEvents NoiseReductionNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents NoPsychovisualEnhancementsCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents MacroblocksComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DefBTN As System.Windows.Forms.Button
    Friend WithEvents CancelBTN As System.Windows.Forms.Button
    Friend WithEvents OKBTN As System.Windows.Forms.Button
    Friend WithEvents BPanel As System.Windows.Forms.Panel
    Friend WithEvents SlowfirstpassGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents SlowfirstpassCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents x264PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents ffmpegPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents TempBlurofQuantafterCCNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents TempBlurofQuantafterCCLabel As System.Windows.Forms.Label
    Friend WithEvents TempBlurofestFramecomplexityNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents TempBlurofestFramecomplexityLabel As System.Windows.Forms.Label
    Friend WithEvents PresetsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents PresetsLabel As System.Windows.Forms.Label
    Friend WithEvents PresetsTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents TuningsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents SLabel As System.Windows.Forms.Label
    Friend WithEvents TuningsComboBox As System.Windows.Forms.ComboBox
End Class
