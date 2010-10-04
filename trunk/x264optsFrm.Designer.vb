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
        Me.ffmpegPictureBox = New System.Windows.Forms.PictureBox
        Me.x264PictureBox = New System.Windows.Forms.PictureBox
        Me.TurboGroupBox = New System.Windows.Forms.GroupBox
        Me.FastfirstpassCheckBox = New System.Windows.Forms.CheckBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.LevelComboBox = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ProfileComboBox = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ThreadsNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.Label1 = New System.Windows.Forms.Label
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
        Me.SettingTabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.ffmpegPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.x264PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TurboGroupBox.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
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
        Me.SettingTabControl.Location = New System.Drawing.Point(10, 10)
        Me.SettingTabControl.Name = "SettingTabControl"
        Me.SettingTabControl.SelectedIndex = 0
        Me.SettingTabControl.Size = New System.Drawing.Size(668, 395)
        Me.SettingTabControl.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ffmpegPictureBox)
        Me.TabPage1.Controls.Add(Me.x264PictureBox)
        Me.TabPage1.Controls.Add(Me.TurboGroupBox)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(660, 369)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Main"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ffmpegPictureBox
        '
        Me.ffmpegPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ffmpegPictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ffmpegPictureBox.Image = CType(resources.GetObject("ffmpegPictureBox.Image"), System.Drawing.Image)
        Me.ffmpegPictureBox.Location = New System.Drawing.Point(365, 282)
        Me.ffmpegPictureBox.Name = "ffmpegPictureBox"
        Me.ffmpegPictureBox.Size = New System.Drawing.Size(276, 67)
        Me.ffmpegPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ffmpegPictureBox.TabIndex = 5
        Me.ffmpegPictureBox.TabStop = False
        '
        'x264PictureBox
        '
        Me.x264PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.x264PictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.x264PictureBox.Image = CType(resources.GetObject("x264PictureBox.Image"), System.Drawing.Image)
        Me.x264PictureBox.Location = New System.Drawing.Point(124, 282)
        Me.x264PictureBox.Name = "x264PictureBox"
        Me.x264PictureBox.Size = New System.Drawing.Size(222, 67)
        Me.x264PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.x264PictureBox.TabIndex = 4
        Me.x264PictureBox.TabStop = False
        '
        'TurboGroupBox
        '
        Me.TurboGroupBox.Controls.Add(Me.FastfirstpassCheckBox)
        Me.TurboGroupBox.Location = New System.Drawing.Point(238, 10)
        Me.TurboGroupBox.Name = "TurboGroupBox"
        Me.TurboGroupBox.Size = New System.Drawing.Size(198, 64)
        Me.TurboGroupBox.TabIndex = 3
        Me.TurboGroupBox.TabStop = False
        Me.TurboGroupBox.Text = "Turbo(2pass only)"
        '
        'FastfirstpassCheckBox
        '
        Me.FastfirstpassCheckBox.AutoSize = True
        Me.FastfirstpassCheckBox.Location = New System.Drawing.Point(21, 27)
        Me.FastfirstpassCheckBox.Name = "FastfirstpassCheckBox"
        Me.FastfirstpassCheckBox.Size = New System.Drawing.Size(104, 16)
        Me.FastfirstpassCheckBox.TabIndex = 0
        Me.FastfirstpassCheckBox.Text = "Fast first pass"
        Me.FastfirstpassCheckBox.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LevelComboBox)
        Me.GroupBox3.Location = New System.Drawing.Point(299, 80)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(274, 60)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Level"
        '
        'LevelComboBox
        '
        Me.LevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LevelComboBox.FormattingEnabled = True
        Me.LevelComboBox.Items.AddRange(New Object() {"Unrestricted AutoGuess", "1.0", "1.1", "1.2", "1.3", "2.0", "2.1", "2.2", "3.0", "3.1", "3.2", "4.0", "4.1", "4.2", "5.0", "5.1"})
        Me.LevelComboBox.Location = New System.Drawing.Point(18, 25)
        Me.LevelComboBox.Name = "LevelComboBox"
        Me.LevelComboBox.Size = New System.Drawing.Size(235, 20)
        Me.LevelComboBox.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ProfileComboBox)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 80)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(277, 60)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Profile"
        '
        'ProfileComboBox
        '
        Me.ProfileComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ProfileComboBox.FormattingEnabled = True
        Me.ProfileComboBox.Items.AddRange(New Object() {"Baseline Profile", "Main Profile", "High Profile"})
        Me.ProfileComboBox.Location = New System.Drawing.Point(18, 25)
        Me.ProfileComboBox.Name = "ProfileComboBox"
        Me.ProfileComboBox.Size = New System.Drawing.Size(235, 20)
        Me.ProfileComboBox.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ThreadsNumericUpDown)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(217, 64)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Threads(0=Auto)"
        '
        'ThreadsNumericUpDown
        '
        Me.ThreadsNumericUpDown.Location = New System.Drawing.Point(105, 25)
        Me.ThreadsNumericUpDown.Maximum = New Decimal(New Integer() {16, 0, 0, 0})
        Me.ThreadsNumericUpDown.Name = "ThreadsNumericUpDown"
        Me.ThreadsNumericUpDown.Size = New System.Drawing.Size(87, 21)
        Me.ThreadsNumericUpDown.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Threads:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.CABACGroupBox)
        Me.TabPage2.Controls.Add(Me.GroupBox6)
        Me.TabPage2.Controls.Add(Me.BFramesGroupBox)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(660, 369)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Frame-Type"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'CABACGroupBox
        '
        Me.CABACGroupBox.Controls.Add(Me.CABACCheckBox)
        Me.CABACGroupBox.Location = New System.Drawing.Point(10, 126)
        Me.CABACGroupBox.Name = "CABACGroupBox"
        Me.CABACGroupBox.Size = New System.Drawing.Size(315, 54)
        Me.CABACGroupBox.TabIndex = 4
        Me.CABACGroupBox.TabStop = False
        Me.CABACGroupBox.Text = "CABAC"
        '
        'CABACCheckBox
        '
        Me.CABACCheckBox.AutoSize = True
        Me.CABACCheckBox.Location = New System.Drawing.Point(21, 22)
        Me.CABACCheckBox.Name = "CABACCheckBox"
        Me.CABACCheckBox.Size = New System.Drawing.Size(66, 16)
        Me.CABACCheckBox.TabIndex = 1
        Me.CABACCheckBox.Text = "CABAC"
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
        Me.GroupBox6.Location = New System.Drawing.Point(10, 187)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(636, 140)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Other"
        '
        'AdaptiveIFramesDecisionCheckBox
        '
        Me.AdaptiveIFramesDecisionCheckBox.AutoSize = True
        Me.AdaptiveIFramesDecisionCheckBox.Location = New System.Drawing.Point(16, 106)
        Me.AdaptiveIFramesDecisionCheckBox.Name = "AdaptiveIFramesDecisionCheckBox"
        Me.AdaptiveIFramesDecisionCheckBox.Size = New System.Drawing.Size(181, 16)
        Me.AdaptiveIFramesDecisionCheckBox.TabIndex = 11
        Me.AdaptiveIFramesDecisionCheckBox.Text = "Adaptive I-Frames Decision"
        Me.AdaptiveIFramesDecisionCheckBox.UseVisualStyleBackColor = True
        '
        'PframeWeightedPredictionComboBox
        '
        Me.PframeWeightedPredictionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PframeWeightedPredictionComboBox.FormattingEnabled = True
        Me.PframeWeightedPredictionComboBox.Items.AddRange(New Object() {"Disabled", "Blind offset", "Smart analysis"})
        Me.PframeWeightedPredictionComboBox.Location = New System.Drawing.Point(220, 75)
        Me.PframeWeightedPredictionComboBox.Name = "PframeWeightedPredictionComboBox"
        Me.PframeWeightedPredictionComboBox.Size = New System.Drawing.Size(192, 20)
        Me.PframeWeightedPredictionComboBox.TabIndex = 10
        '
        'PframeWeightedPredictionLabel
        '
        Me.PframeWeightedPredictionLabel.Location = New System.Drawing.Point(22, 74)
        Me.PframeWeightedPredictionLabel.Name = "PframeWeightedPredictionLabel"
        Me.PframeWeightedPredictionLabel.Size = New System.Drawing.Size(192, 21)
        Me.PframeWeightedPredictionLabel.TabIndex = 9
        Me.PframeWeightedPredictionLabel.Text = "P-frame Weighted Prediction:"
        Me.PframeWeightedPredictionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ExtraIFramesNumericUpDown
        '
        Me.ExtraIFramesNumericUpDown.Enabled = False
        Me.ExtraIFramesNumericUpDown.Location = New System.Drawing.Point(220, 48)
        Me.ExtraIFramesNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.ExtraIFramesNumericUpDown.Name = "ExtraIFramesNumericUpDown"
        Me.ExtraIFramesNumericUpDown.Size = New System.Drawing.Size(77, 21)
        Me.ExtraIFramesNumericUpDown.TabIndex = 8
        '
        'ExtraIFramesLabel
        '
        Me.ExtraIFramesLabel.Enabled = False
        Me.ExtraIFramesLabel.Location = New System.Drawing.Point(18, 48)
        Me.ExtraIFramesLabel.Name = "ExtraIFramesLabel"
        Me.ExtraIFramesLabel.Size = New System.Drawing.Size(196, 21)
        Me.ExtraIFramesLabel.TabIndex = 7
        Me.ExtraIFramesLabel.Text = "Extra I-Frames:"
        Me.ExtraIFramesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ReferenceFramesNumericUpDown
        '
        Me.ReferenceFramesNumericUpDown.Location = New System.Drawing.Point(220, 21)
        Me.ReferenceFramesNumericUpDown.Maximum = New Decimal(New Integer() {16, 0, 0, 0})
        Me.ReferenceFramesNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ReferenceFramesNumericUpDown.Name = "ReferenceFramesNumericUpDown"
        Me.ReferenceFramesNumericUpDown.Size = New System.Drawing.Size(77, 21)
        Me.ReferenceFramesNumericUpDown.TabIndex = 6
        Me.ReferenceFramesNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(20, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(194, 21)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Reference Frames:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.BFramesGroupBox.Location = New System.Drawing.Point(331, 10)
        Me.BFramesGroupBox.Name = "BFramesGroupBox"
        Me.BFramesGroupBox.Size = New System.Drawing.Size(315, 170)
        Me.BFramesGroupBox.TabIndex = 2
        Me.BFramesGroupBox.TabStop = False
        Me.BFramesGroupBox.Text = "B-Frames"
        '
        'BFrameWeightedPredictionCheckBox
        '
        Me.BFrameWeightedPredictionCheckBox.AutoSize = True
        Me.BFrameWeightedPredictionCheckBox.Enabled = False
        Me.BFrameWeightedPredictionCheckBox.Location = New System.Drawing.Point(16, 136)
        Me.BFrameWeightedPredictionCheckBox.Name = "BFrameWeightedPredictionCheckBox"
        Me.BFrameWeightedPredictionCheckBox.Size = New System.Drawing.Size(189, 16)
        Me.BFrameWeightedPredictionCheckBox.TabIndex = 11
        Me.BFrameWeightedPredictionCheckBox.Text = "B-Frame Weighted Prediction"
        Me.BFrameWeightedPredictionCheckBox.UseVisualStyleBackColor = True
        '
        'BFramePyramidCheckBox
        '
        Me.BFramePyramidCheckBox.AutoSize = True
        Me.BFramePyramidCheckBox.Enabled = False
        Me.BFramePyramidCheckBox.Location = New System.Drawing.Point(16, 109)
        Me.BFramePyramidCheckBox.Name = "BFramePyramidCheckBox"
        Me.BFramePyramidCheckBox.Size = New System.Drawing.Size(125, 16)
        Me.BFramePyramidCheckBox.TabIndex = 10
        Me.BFramePyramidCheckBox.Text = "B-Frame Pyramid"
        Me.BFramePyramidCheckBox.UseVisualStyleBackColor = True
        '
        'AdaptiveBFramesComboBox
        '
        Me.AdaptiveBFramesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AdaptiveBFramesComboBox.Enabled = False
        Me.AdaptiveBFramesComboBox.FormattingEnabled = True
        Me.AdaptiveBFramesComboBox.Items.AddRange(New Object() {"0 - Off", "1 - Fast", "2 - Optimal"})
        Me.AdaptiveBFramesComboBox.Location = New System.Drawing.Point(174, 80)
        Me.AdaptiveBFramesComboBox.Name = "AdaptiveBFramesComboBox"
        Me.AdaptiveBFramesComboBox.Size = New System.Drawing.Size(123, 20)
        Me.AdaptiveBFramesComboBox.TabIndex = 8
        '
        'BFrameBiasNumericUpDown
        '
        Me.BFrameBiasNumericUpDown.Enabled = False
        Me.BFrameBiasNumericUpDown.Location = New System.Drawing.Point(174, 53)
        Me.BFrameBiasNumericUpDown.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.BFrameBiasNumericUpDown.Name = "BFrameBiasNumericUpDown"
        Me.BFrameBiasNumericUpDown.Size = New System.Drawing.Size(77, 21)
        Me.BFrameBiasNumericUpDown.TabIndex = 7
        '
        'BFramesNumericUpDown
        '
        Me.BFramesNumericUpDown.Location = New System.Drawing.Point(174, 26)
        Me.BFramesNumericUpDown.Maximum = New Decimal(New Integer() {16, 0, 0, 0})
        Me.BFramesNumericUpDown.Name = "BFramesNumericUpDown"
        Me.BFramesNumericUpDown.Size = New System.Drawing.Size(77, 21)
        Me.BFramesNumericUpDown.TabIndex = 6
        '
        'BFrameBiasLabel
        '
        Me.BFrameBiasLabel.Enabled = False
        Me.BFrameBiasLabel.Location = New System.Drawing.Point(14, 53)
        Me.BFrameBiasLabel.Name = "BFrameBiasLabel"
        Me.BFrameBiasLabel.Size = New System.Drawing.Size(154, 21)
        Me.BFrameBiasLabel.TabIndex = 5
        Me.BFrameBiasLabel.Text = "B-Frame Bias:"
        Me.BFrameBiasLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AdaptiveBFramesLabel
        '
        Me.AdaptiveBFramesLabel.Enabled = False
        Me.AdaptiveBFramesLabel.Location = New System.Drawing.Point(14, 79)
        Me.AdaptiveBFramesLabel.Name = "AdaptiveBFramesLabel"
        Me.AdaptiveBFramesLabel.Size = New System.Drawing.Size(154, 21)
        Me.AdaptiveBFramesLabel.TabIndex = 3
        Me.AdaptiveBFramesLabel.Text = "Adaptive B-Frames:"
        Me.AdaptiveBFramesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(14, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 21)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "B-Frames:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DeblockingBetaNumericUpDown)
        Me.GroupBox4.Controls.Add(Me.DeblockingAlphaNumericUpDown)
        Me.GroupBox4.Controls.Add(Me.DeblockingBetaLabel)
        Me.GroupBox4.Controls.Add(Me.DeblockingAlphaLabel)
        Me.GroupBox4.Controls.Add(Me.DeblockingCheckBox)
        Me.GroupBox4.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(315, 110)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Deblocking"
        '
        'DeblockingBetaNumericUpDown
        '
        Me.DeblockingBetaNumericUpDown.Location = New System.Drawing.Point(220, 73)
        Me.DeblockingBetaNumericUpDown.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.DeblockingBetaNumericUpDown.Minimum = New Decimal(New Integer() {6, 0, 0, -2147483648})
        Me.DeblockingBetaNumericUpDown.Name = "DeblockingBetaNumericUpDown"
        Me.DeblockingBetaNumericUpDown.Size = New System.Drawing.Size(77, 21)
        Me.DeblockingBetaNumericUpDown.TabIndex = 4
        '
        'DeblockingAlphaNumericUpDown
        '
        Me.DeblockingAlphaNumericUpDown.Location = New System.Drawing.Point(220, 46)
        Me.DeblockingAlphaNumericUpDown.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.DeblockingAlphaNumericUpDown.Minimum = New Decimal(New Integer() {6, 0, 0, -2147483648})
        Me.DeblockingAlphaNumericUpDown.Name = "DeblockingAlphaNumericUpDown"
        Me.DeblockingAlphaNumericUpDown.Size = New System.Drawing.Size(77, 21)
        Me.DeblockingAlphaNumericUpDown.TabIndex = 3
        '
        'DeblockingBetaLabel
        '
        Me.DeblockingBetaLabel.Location = New System.Drawing.Point(14, 73)
        Me.DeblockingBetaLabel.Name = "DeblockingBetaLabel"
        Me.DeblockingBetaLabel.Size = New System.Drawing.Size(200, 21)
        Me.DeblockingBetaLabel.TabIndex = 2
        Me.DeblockingBetaLabel.Text = "Deblocking Beta(Threshold):"
        Me.DeblockingBetaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DeblockingAlphaLabel
        '
        Me.DeblockingAlphaLabel.Location = New System.Drawing.Point(14, 46)
        Me.DeblockingAlphaLabel.Name = "DeblockingAlphaLabel"
        Me.DeblockingAlphaLabel.Size = New System.Drawing.Size(200, 21)
        Me.DeblockingAlphaLabel.TabIndex = 1
        Me.DeblockingAlphaLabel.Text = "Deblocking Alpha(Strength):"
        Me.DeblockingAlphaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DeblockingCheckBox
        '
        Me.DeblockingCheckBox.AutoSize = True
        Me.DeblockingCheckBox.Location = New System.Drawing.Point(21, 23)
        Me.DeblockingCheckBox.Name = "DeblockingCheckBox"
        Me.DeblockingCheckBox.Size = New System.Drawing.Size(86, 16)
        Me.DeblockingCheckBox.TabIndex = 0
        Me.DeblockingCheckBox.Text = "Deblocking"
        Me.DeblockingCheckBox.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.RateControlGroupBox)
        Me.TabPage3.Controls.Add(Me.AdaptiveQuantizersGroupBox)
        Me.TabPage3.Controls.Add(Me.GroupBox8)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(660, 369)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Rate Control"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'RateControlGroupBox
        '
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
        Me.RateControlGroupBox.Location = New System.Drawing.Point(10, 161)
        Me.RateControlGroupBox.Name = "RateControlGroupBox"
        Me.RateControlGroupBox.Size = New System.Drawing.Size(638, 163)
        Me.RateControlGroupBox.TabIndex = 4
        Me.RateControlGroupBox.TabStop = False
        Me.RateControlGroupBox.Text = "Rate Control"
        '
        'UseMBTreeCheckBox
        '
        Me.UseMBTreeCheckBox.AutoSize = True
        Me.UseMBTreeCheckBox.Location = New System.Drawing.Point(439, 59)
        Me.UseMBTreeCheckBox.Name = "UseMBTreeCheckBox"
        Me.UseMBTreeCheckBox.Size = New System.Drawing.Size(101, 16)
        Me.UseMBTreeCheckBox.TabIndex = 21
        Me.UseMBTreeCheckBox.Text = "Use MB-Tree"
        Me.UseMBTreeCheckBox.UseVisualStyleBackColor = True
        '
        'NumberofFramesforLookaheadNumericUpDown
        '
        Me.NumberofFramesforLookaheadNumericUpDown.Location = New System.Drawing.Point(546, 23)
        Me.NumberofFramesforLookaheadNumericUpDown.Maximum = New Decimal(New Integer() {250, 0, 0, 0})
        Me.NumberofFramesforLookaheadNumericUpDown.Name = "NumberofFramesforLookaheadNumericUpDown"
        Me.NumberofFramesforLookaheadNumericUpDown.Size = New System.Drawing.Size(77, 21)
        Me.NumberofFramesforLookaheadNumericUpDown.TabIndex = 20
        Me.NumberofFramesforLookaheadNumericUpDown.Value = New Decimal(New Integer() {40, 0, 0, 0})
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(335, 24)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(205, 21)
        Me.Label26.TabIndex = 19
        Me.Label26.Text = "Number of Frames for Lookahead:"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'QuantizerCompressionNumericUpDown
        '
        Me.QuantizerCompressionNumericUpDown.DecimalPlaces = 1
        Me.QuantizerCompressionNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.QuantizerCompressionNumericUpDown.Location = New System.Drawing.Point(226, 129)
        Me.QuantizerCompressionNumericUpDown.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.QuantizerCompressionNumericUpDown.Name = "QuantizerCompressionNumericUpDown"
        Me.QuantizerCompressionNumericUpDown.Size = New System.Drawing.Size(77, 21)
        Me.QuantizerCompressionNumericUpDown.TabIndex = 18
        Me.QuantizerCompressionNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(15, 129)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(205, 21)
        Me.Label25.TabIndex = 17
        Me.Label25.Text = "Quantizer Compression:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AverageBitrateVarianceNumericUpDown
        '
        Me.AverageBitrateVarianceNumericUpDown.DecimalPlaces = 1
        Me.AverageBitrateVarianceNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.AverageBitrateVarianceNumericUpDown.Location = New System.Drawing.Point(226, 102)
        Me.AverageBitrateVarianceNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.AverageBitrateVarianceNumericUpDown.Name = "AverageBitrateVarianceNumericUpDown"
        Me.AverageBitrateVarianceNumericUpDown.Size = New System.Drawing.Size(77, 21)
        Me.AverageBitrateVarianceNumericUpDown.TabIndex = 16
        Me.AverageBitrateVarianceNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'AverageBitrateVarianceLabel
        '
        Me.AverageBitrateVarianceLabel.Location = New System.Drawing.Point(15, 102)
        Me.AverageBitrateVarianceLabel.Name = "AverageBitrateVarianceLabel"
        Me.AverageBitrateVarianceLabel.Size = New System.Drawing.Size(205, 21)
        Me.AverageBitrateVarianceLabel.TabIndex = 15
        Me.AverageBitrateVarianceLabel.Text = "Average Bitrate Variance:"
        Me.AverageBitrateVarianceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'VBVInitialBufferNumericUpDown
        '
        Me.VBVInitialBufferNumericUpDown.DecimalPlaces = 1
        Me.VBVInitialBufferNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.VBVInitialBufferNumericUpDown.Location = New System.Drawing.Point(226, 75)
        Me.VBVInitialBufferNumericUpDown.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.VBVInitialBufferNumericUpDown.Name = "VBVInitialBufferNumericUpDown"
        Me.VBVInitialBufferNumericUpDown.Size = New System.Drawing.Size(77, 21)
        Me.VBVInitialBufferNumericUpDown.TabIndex = 14
        Me.VBVInitialBufferNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(15, 75)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(205, 21)
        Me.Label23.TabIndex = 13
        Me.Label23.Text = "VBV Initial Buffer:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'VBVMaximumBitrateNumericUpDown
        '
        Me.VBVMaximumBitrateNumericUpDown.Location = New System.Drawing.Point(226, 48)
        Me.VBVMaximumBitrateNumericUpDown.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.VBVMaximumBitrateNumericUpDown.Name = "VBVMaximumBitrateNumericUpDown"
        Me.VBVMaximumBitrateNumericUpDown.Size = New System.Drawing.Size(77, 21)
        Me.VBVMaximumBitrateNumericUpDown.TabIndex = 12
        Me.VBVMaximumBitrateNumericUpDown.Value = New Decimal(New Integer() {100000, 0, 0, 0})
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(15, 48)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(205, 21)
        Me.Label22.TabIndex = 11
        Me.Label22.Text = "VBV Maximum Bitrate(Kbit/s):"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'VBVBufferSizeNumericUpDown
        '
        Me.VBVBufferSizeNumericUpDown.Location = New System.Drawing.Point(226, 20)
        Me.VBVBufferSizeNumericUpDown.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.VBVBufferSizeNumericUpDown.Name = "VBVBufferSizeNumericUpDown"
        Me.VBVBufferSizeNumericUpDown.Size = New System.Drawing.Size(77, 21)
        Me.VBVBufferSizeNumericUpDown.TabIndex = 10
        Me.VBVBufferSizeNumericUpDown.Value = New Decimal(New Integer() {100000, 0, 0, 0})
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(15, 21)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(205, 21)
        Me.Label21.TabIndex = 9
        Me.Label21.Text = "VBV Buffer Size(Kbit/s):"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AdaptiveQuantizersGroupBox
        '
        Me.AdaptiveQuantizersGroupBox.Controls.Add(Me.AdaptiveQuantizersStrengthNumericUpDown)
        Me.AdaptiveQuantizersGroupBox.Controls.Add(Me.Label20)
        Me.AdaptiveQuantizersGroupBox.Controls.Add(Me.AdaptiveQuantizersModeComboBox)
        Me.AdaptiveQuantizersGroupBox.Controls.Add(Me.Label19)
        Me.AdaptiveQuantizersGroupBox.Location = New System.Drawing.Point(443, 10)
        Me.AdaptiveQuantizersGroupBox.Name = "AdaptiveQuantizersGroupBox"
        Me.AdaptiveQuantizersGroupBox.Size = New System.Drawing.Size(205, 145)
        Me.AdaptiveQuantizersGroupBox.TabIndex = 3
        Me.AdaptiveQuantizersGroupBox.TabStop = False
        Me.AdaptiveQuantizersGroupBox.Text = "Adaptive Quantizers"
        '
        'AdaptiveQuantizersStrengthNumericUpDown
        '
        Me.AdaptiveQuantizersStrengthNumericUpDown.DecimalPlaces = 1
        Me.AdaptiveQuantizersStrengthNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.AdaptiveQuantizersStrengthNumericUpDown.Location = New System.Drawing.Point(129, 81)
        Me.AdaptiveQuantizersStrengthNumericUpDown.Maximum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.AdaptiveQuantizersStrengthNumericUpDown.Name = "AdaptiveQuantizersStrengthNumericUpDown"
        Me.AdaptiveQuantizersStrengthNumericUpDown.Size = New System.Drawing.Size(61, 21)
        Me.AdaptiveQuantizersStrengthNumericUpDown.TabIndex = 12
        Me.AdaptiveQuantizersStrengthNumericUpDown.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(16, 81)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(94, 21)
        Me.Label20.TabIndex = 11
        Me.Label20.Text = "Strength:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AdaptiveQuantizersModeComboBox
        '
        Me.AdaptiveQuantizersModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AdaptiveQuantizersModeComboBox.FormattingEnabled = True
        Me.AdaptiveQuantizersModeComboBox.Items.AddRange(New Object() {"Disabled", "Variance AQ", "Auto-variance AQ"})
        Me.AdaptiveQuantizersModeComboBox.Location = New System.Drawing.Point(18, 48)
        Me.AdaptiveQuantizersModeComboBox.Name = "AdaptiveQuantizersModeComboBox"
        Me.AdaptiveQuantizersModeComboBox.Size = New System.Drawing.Size(172, 20)
        Me.AdaptiveQuantizersModeComboBox.TabIndex = 10
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(16, 24)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(174, 21)
        Me.Label19.TabIndex = 9
        Me.Label19.Text = "Mode:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.GroupBox8.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(423, 145)
        Me.GroupBox8.TabIndex = 2
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Quantizers"
        '
        'ChromaandLumaQPOffsetNumericUpDown
        '
        Me.ChromaandLumaQPOffsetNumericUpDown.Location = New System.Drawing.Point(226, 108)
        Me.ChromaandLumaQPOffsetNumericUpDown.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.ChromaandLumaQPOffsetNumericUpDown.Minimum = New Decimal(New Integer() {12, 0, 0, -2147483648})
        Me.ChromaandLumaQPOffsetNumericUpDown.Name = "ChromaandLumaQPOffsetNumericUpDown"
        Me.ChromaandLumaQPOffsetNumericUpDown.Size = New System.Drawing.Size(77, 21)
        Me.ChromaandLumaQPOffsetNumericUpDown.TabIndex = 12
        Me.ChromaandLumaQPOffsetNumericUpDown.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(15, 108)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(205, 21)
        Me.Label17.TabIndex = 11
        Me.Label17.Text = "Chroma and Luma QP Offset:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'QPBRatioNumericUpDown
        '
        Me.QPBRatioNumericUpDown.DecimalPlaces = 1
        Me.QPBRatioNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.QPBRatioNumericUpDown.Location = New System.Drawing.Point(226, 81)
        Me.QPBRatioNumericUpDown.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.QPBRatioNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.QPBRatioNumericUpDown.Name = "QPBRatioNumericUpDown"
        Me.QPBRatioNumericUpDown.Size = New System.Drawing.Size(77, 21)
        Me.QPBRatioNumericUpDown.TabIndex = 10
        Me.QPBRatioNumericUpDown.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(15, 81)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(205, 21)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Quantizer P-B Ratio:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'QIPRatioNumericUpDown
        '
        Me.QIPRatioNumericUpDown.DecimalPlaces = 2
        Me.QIPRatioNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.QIPRatioNumericUpDown.Location = New System.Drawing.Point(226, 54)
        Me.QIPRatioNumericUpDown.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.QIPRatioNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.QIPRatioNumericUpDown.Name = "QIPRatioNumericUpDown"
        Me.QIPRatioNumericUpDown.Size = New System.Drawing.Size(77, 21)
        Me.QIPRatioNumericUpDown.TabIndex = 8
        Me.QIPRatioNumericUpDown.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(15, 54)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(205, 21)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Quantizer I-P Ratio:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'QDeltaNumericUpDown
        '
        Me.QDeltaNumericUpDown.Location = New System.Drawing.Point(346, 26)
        Me.QDeltaNumericUpDown.Maximum = New Decimal(New Integer() {51, 0, 0, 0})
        Me.QDeltaNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.QDeltaNumericUpDown.Name = "QDeltaNumericUpDown"
        Me.QDeltaNumericUpDown.Size = New System.Drawing.Size(54, 21)
        Me.QDeltaNumericUpDown.TabIndex = 6
        Me.QDeltaNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'QMaxNumericUpDown
        '
        Me.QMaxNumericUpDown.Location = New System.Drawing.Point(286, 26)
        Me.QMaxNumericUpDown.Maximum = New Decimal(New Integer() {51, 0, 0, 0})
        Me.QMaxNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.QMaxNumericUpDown.Name = "QMaxNumericUpDown"
        Me.QMaxNumericUpDown.Size = New System.Drawing.Size(54, 21)
        Me.QMaxNumericUpDown.TabIndex = 5
        Me.QMaxNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'QMinNumericUpDown
        '
        Me.QMinNumericUpDown.Location = New System.Drawing.Point(226, 26)
        Me.QMinNumericUpDown.Maximum = New Decimal(New Integer() {51, 0, 0, 0})
        Me.QMinNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.QMinNumericUpDown.Name = "QMinNumericUpDown"
        Me.QMinNumericUpDown.Size = New System.Drawing.Size(54, 21)
        Me.QMinNumericUpDown.TabIndex = 3
        Me.QMinNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(15, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(205, 21)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Min/Max/Delta:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GroupBox17)
        Me.TabPage4.Controls.Add(Me.GroupBox16)
        Me.TabPage4.Controls.Add(Me.GroupBox14)
        Me.TabPage4.Controls.Add(Me.GroupBox13)
        Me.TabPage4.Controls.Add(Me.GroupBox12)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(660, 369)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Analysis"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GroupBox17
        '
        Me.GroupBox17.Controls.Add(Me.UseaccessunitdelimitersCheckBox)
        Me.GroupBox17.Location = New System.Drawing.Point(393, 219)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(253, 54)
        Me.GroupBox17.TabIndex = 7
        Me.GroupBox17.TabStop = False
        Me.GroupBox17.Text = "Blu-ray"
        '
        'UseaccessunitdelimitersCheckBox
        '
        Me.UseaccessunitdelimitersCheckBox.AutoSize = True
        Me.UseaccessunitdelimitersCheckBox.Location = New System.Drawing.Point(24, 22)
        Me.UseaccessunitdelimitersCheckBox.Name = "UseaccessunitdelimitersCheckBox"
        Me.UseaccessunitdelimitersCheckBox.Size = New System.Drawing.Size(175, 16)
        Me.UseaccessunitdelimitersCheckBox.TabIndex = 0
        Me.UseaccessunitdelimitersCheckBox.Text = "Use access unit delimiters"
        Me.UseaccessunitdelimitersCheckBox.UseVisualStyleBackColor = True
        '
        'GroupBox16
        '
        Me.GroupBox16.Controls.Add(Me.NoiseReductionNumericUpDown)
        Me.GroupBox16.Location = New System.Drawing.Point(393, 154)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(253, 59)
        Me.GroupBox16.TabIndex = 6
        Me.GroupBox16.TabStop = False
        Me.GroupBox16.Text = "Noise Reduction"
        '
        'NoiseReductionNumericUpDown
        '
        Me.NoiseReductionNumericUpDown.Location = New System.Drawing.Point(24, 23)
        Me.NoiseReductionNumericUpDown.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NoiseReductionNumericUpDown.Name = "NoiseReductionNumericUpDown"
        Me.NoiseReductionNumericUpDown.Size = New System.Drawing.Size(77, 21)
        Me.NoiseReductionNumericUpDown.TabIndex = 0
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
        Me.GroupBox14.Location = New System.Drawing.Point(10, 154)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(372, 205)
        Me.GroupBox14.TabIndex = 5
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "Extra"
        '
        'NoPsychovisualEnhancementsCheckBox
        '
        Me.NoPsychovisualEnhancementsCheckBox.AutoSize = True
        Me.NoPsychovisualEnhancementsCheckBox.Location = New System.Drawing.Point(21, 175)
        Me.NoPsychovisualEnhancementsCheckBox.Name = "NoPsychovisualEnhancementsCheckBox"
        Me.NoPsychovisualEnhancementsCheckBox.Size = New System.Drawing.Size(209, 16)
        Me.NoPsychovisualEnhancementsCheckBox.TabIndex = 19
        Me.NoPsychovisualEnhancementsCheckBox.Text = "No Psychovisual Enhancements"
        Me.NoPsychovisualEnhancementsCheckBox.UseVisualStyleBackColor = True
        '
        'NoFastPSkipCheckBox
        '
        Me.NoFastPSkipCheckBox.AutoSize = True
        Me.NoFastPSkipCheckBox.Location = New System.Drawing.Point(21, 154)
        Me.NoFastPSkipCheckBox.Name = "NoFastPSkipCheckBox"
        Me.NoFastPSkipCheckBox.Size = New System.Drawing.Size(110, 16)
        Me.NoFastPSkipCheckBox.TabIndex = 18
        Me.NoFastPSkipCheckBox.Text = "No Fast P-Skip"
        Me.NoFastPSkipCheckBox.UseVisualStyleBackColor = True
        '
        'NoMixedReferenceFramesCheckBox
        '
        Me.NoMixedReferenceFramesCheckBox.AutoSize = True
        Me.NoMixedReferenceFramesCheckBox.Location = New System.Drawing.Point(21, 133)
        Me.NoMixedReferenceFramesCheckBox.Name = "NoMixedReferenceFramesCheckBox"
        Me.NoMixedReferenceFramesCheckBox.Size = New System.Drawing.Size(187, 16)
        Me.NoMixedReferenceFramesCheckBox.TabIndex = 17
        Me.NoMixedReferenceFramesCheckBox.Text = "No Mixed Reference Frames"
        Me.NoMixedReferenceFramesCheckBox.UseVisualStyleBackColor = True
        '
        'PsyTrellisStrengthNumericUpDown
        '
        Me.PsyTrellisStrengthNumericUpDown.DecimalPlaces = 2
        Me.PsyTrellisStrengthNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.PsyTrellisStrengthNumericUpDown.Location = New System.Drawing.Point(226, 106)
        Me.PsyTrellisStrengthNumericUpDown.Name = "PsyTrellisStrengthNumericUpDown"
        Me.PsyTrellisStrengthNumericUpDown.Size = New System.Drawing.Size(85, 21)
        Me.PsyTrellisStrengthNumericUpDown.TabIndex = 16
        Me.PsyTrellisStrengthNumericUpDown.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label33
        '
        Me.Label33.Location = New System.Drawing.Point(15, 106)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(205, 21)
        Me.Label33.TabIndex = 15
        Me.Label33.Text = "Psy-Trellis Strength:"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PsyRDStrengthNumericUpDown
        '
        Me.PsyRDStrengthNumericUpDown.DecimalPlaces = 2
        Me.PsyRDStrengthNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.PsyRDStrengthNumericUpDown.Location = New System.Drawing.Point(226, 79)
        Me.PsyRDStrengthNumericUpDown.Maximum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.PsyRDStrengthNumericUpDown.Name = "PsyRDStrengthNumericUpDown"
        Me.PsyRDStrengthNumericUpDown.Size = New System.Drawing.Size(85, 21)
        Me.PsyRDStrengthNumericUpDown.TabIndex = 14
        Me.PsyRDStrengthNumericUpDown.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label32
        '
        Me.Label32.Location = New System.Drawing.Point(15, 79)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(205, 21)
        Me.Label32.TabIndex = 13
        Me.Label32.Text = "Psy-RD Strength:"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TrellisComboBox
        '
        Me.TrellisComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TrellisComboBox.FormattingEnabled = True
        Me.TrellisComboBox.Items.AddRange(New Object() {"0 - None", "1 - Final MB", "2 - Always"})
        Me.TrellisComboBox.Location = New System.Drawing.Point(226, 50)
        Me.TrellisComboBox.Name = "TrellisComboBox"
        Me.TrellisComboBox.Size = New System.Drawing.Size(124, 20)
        Me.TrellisComboBox.TabIndex = 12
        '
        'TrellisLabel
        '
        Me.TrellisLabel.Location = New System.Drawing.Point(15, 49)
        Me.TrellisLabel.Name = "TrellisLabel"
        Me.TrellisLabel.Size = New System.Drawing.Size(205, 21)
        Me.TrellisLabel.TabIndex = 11
        Me.TrellisLabel.Text = "Trellis:"
        Me.TrellisLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MVPredictionModeComboBox
        '
        Me.MVPredictionModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MVPredictionModeComboBox.FormattingEnabled = True
        Me.MVPredictionModeComboBox.Items.AddRange(New Object() {"None", "Spatial", "Temporal", "Auto"})
        Me.MVPredictionModeComboBox.Location = New System.Drawing.Point(226, 24)
        Me.MVPredictionModeComboBox.Name = "MVPredictionModeComboBox"
        Me.MVPredictionModeComboBox.Size = New System.Drawing.Size(124, 20)
        Me.MVPredictionModeComboBox.TabIndex = 10
        '
        'MVPredictionModeLabel
        '
        Me.MVPredictionModeLabel.Location = New System.Drawing.Point(15, 23)
        Me.MVPredictionModeLabel.Name = "MVPredictionModeLabel"
        Me.MVPredictionModeLabel.Size = New System.Drawing.Size(205, 21)
        Me.MVPredictionModeLabel.TabIndex = 9
        Me.MVPredictionModeLabel.Text = "MV Prediction Mode:"
        Me.MVPredictionModeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.GroupBox13.Location = New System.Drawing.Point(393, 10)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(253, 138)
        Me.GroupBox13.TabIndex = 4
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Macroblocks"
        '
        'MacroblocksComboBox
        '
        Me.MacroblocksComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MacroblocksComboBox.FormattingEnabled = True
        Me.MacroblocksComboBox.Items.AddRange(New Object() {"Default", "Custom"})
        Me.MacroblocksComboBox.Location = New System.Drawing.Point(24, 23)
        Me.MacroblocksComboBox.Name = "MacroblocksComboBox"
        Me.MacroblocksComboBox.Size = New System.Drawing.Size(200, 20)
        Me.MacroblocksComboBox.TabIndex = 11
        '
        'B8x8CheckBox
        '
        Me.B8x8CheckBox.AutoSize = True
        Me.B8x8CheckBox.Location = New System.Drawing.Point(173, 103)
        Me.B8x8CheckBox.Name = "B8x8CheckBox"
        Me.B8x8CheckBox.Size = New System.Drawing.Size(51, 16)
        Me.B8x8CheckBox.TabIndex = 5
        Me.B8x8CheckBox.Text = "B8x8"
        Me.B8x8CheckBox.UseVisualStyleBackColor = True
        '
        'P8x8CheckBox
        '
        Me.P8x8CheckBox.AutoSize = True
        Me.P8x8CheckBox.Location = New System.Drawing.Point(97, 103)
        Me.P8x8CheckBox.Name = "P8x8CheckBox"
        Me.P8x8CheckBox.Size = New System.Drawing.Size(51, 16)
        Me.P8x8CheckBox.TabIndex = 4
        Me.P8x8CheckBox.Text = "P8x8"
        Me.P8x8CheckBox.UseVisualStyleBackColor = True
        '
        'I8x8CheckBox
        '
        Me.I8x8CheckBox.AutoSize = True
        Me.I8x8CheckBox.Location = New System.Drawing.Point(24, 103)
        Me.I8x8CheckBox.Name = "I8x8CheckBox"
        Me.I8x8CheckBox.Size = New System.Drawing.Size(46, 16)
        Me.I8x8CheckBox.TabIndex = 3
        Me.I8x8CheckBox.Text = "I8x8"
        Me.I8x8CheckBox.UseVisualStyleBackColor = True
        '
        'P4x4CheckBox
        '
        Me.P4x4CheckBox.AutoSize = True
        Me.P4x4CheckBox.Location = New System.Drawing.Point(97, 80)
        Me.P4x4CheckBox.Name = "P4x4CheckBox"
        Me.P4x4CheckBox.Size = New System.Drawing.Size(51, 16)
        Me.P4x4CheckBox.TabIndex = 2
        Me.P4x4CheckBox.Text = "P4x4"
        Me.P4x4CheckBox.UseVisualStyleBackColor = True
        '
        'I4x4CheckBox
        '
        Me.I4x4CheckBox.AutoSize = True
        Me.I4x4CheckBox.Location = New System.Drawing.Point(24, 80)
        Me.I4x4CheckBox.Name = "I4x4CheckBox"
        Me.I4x4CheckBox.Size = New System.Drawing.Size(46, 16)
        Me.I4x4CheckBox.TabIndex = 1
        Me.I4x4CheckBox.Text = "I4x4"
        Me.I4x4CheckBox.UseVisualStyleBackColor = True
        '
        'Adaptive8x8DCTCheckBox
        '
        Me.Adaptive8x8DCTCheckBox.AutoSize = True
        Me.Adaptive8x8DCTCheckBox.Location = New System.Drawing.Point(24, 57)
        Me.Adaptive8x8DCTCheckBox.Name = "Adaptive8x8DCTCheckBox"
        Me.Adaptive8x8DCTCheckBox.Size = New System.Drawing.Size(124, 16)
        Me.Adaptive8x8DCTCheckBox.TabIndex = 0
        Me.Adaptive8x8DCTCheckBox.Text = "Adaptive 8x8 DCT"
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
        Me.GroupBox12.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(372, 138)
        Me.GroupBox12.TabIndex = 3
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Motion Estimation"
        '
        'SubpixelMEComboBox
        '
        Me.SubpixelMEComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SubpixelMEComboBox.FormattingEnabled = True
        Me.SubpixelMEComboBox.Items.AddRange(New Object() {"1 - QPel SAD 1 iteration", "2 - QPel SATD 2 iterations", "3 - HPel on MB then QPel", "4 - Always QPel", "5 - Multi QPel + bime", "6 - RD on I/P frames", "7 - RD on all frames", "8 - RD refinement on I/P frames", "9 - RD refinement on all frames", "10 - QP-RD"})
        Me.SubpixelMEComboBox.Location = New System.Drawing.Point(127, 100)
        Me.SubpixelMEComboBox.Name = "SubpixelMEComboBox"
        Me.SubpixelMEComboBox.Size = New System.Drawing.Size(223, 20)
        Me.SubpixelMEComboBox.TabIndex = 18
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(15, 99)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(106, 21)
        Me.Label27.TabIndex = 17
        Me.Label27.Text = "Subpixel M.E.:"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MEMethodComboBox
        '
        Me.MEMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MEMethodComboBox.FormattingEnabled = True
        Me.MEMethodComboBox.Items.AddRange(New Object() {"Diamond", "Hexagon", "Multi Hex", "Exhaustive", "SATD Exhaustive"})
        Me.MEMethodComboBox.Location = New System.Drawing.Point(127, 74)
        Me.MEMethodComboBox.Name = "MEMethodComboBox"
        Me.MEMethodComboBox.Size = New System.Drawing.Size(161, 20)
        Me.MEMethodComboBox.TabIndex = 16
        '
        'ChromaMECheckBox
        '
        Me.ChromaMECheckBox.AutoSize = True
        Me.ChromaMECheckBox.Location = New System.Drawing.Point(21, 23)
        Me.ChromaMECheckBox.Name = "ChromaMECheckBox"
        Me.ChromaMECheckBox.Size = New System.Drawing.Size(100, 16)
        Me.ChromaMECheckBox.TabIndex = 15
        Me.ChromaMECheckBox.Text = "Chroma M.E."
        Me.ChromaMECheckBox.UseVisualStyleBackColor = True
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(15, 73)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(106, 21)
        Me.Label29.TabIndex = 9
        Me.Label29.Text = "M.E. Method:"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MERangeNumericUpDown
        '
        Me.MERangeNumericUpDown.Location = New System.Drawing.Point(127, 46)
        Me.MERangeNumericUpDown.Maximum = New Decimal(New Integer() {64, 0, 0, 0})
        Me.MERangeNumericUpDown.Minimum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.MERangeNumericUpDown.Name = "MERangeNumericUpDown"
        Me.MERangeNumericUpDown.Size = New System.Drawing.Size(77, 21)
        Me.MERangeNumericUpDown.TabIndex = 8
        Me.MERangeNumericUpDown.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(15, 46)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(106, 21)
        Me.Label30.TabIndex = 7
        Me.Label30.Text = "M.E. Range:"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.GroupBox9.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(366, 146)
        Me.GroupBox9.TabIndex = 2
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Quantizers"
        '
        'NumericUpDown13
        '
        Me.NumericUpDown13.DecimalPlaces = 1
        Me.NumericUpDown13.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown13.Location = New System.Drawing.Point(161, 81)
        Me.NumericUpDown13.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown13.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown13.Name = "NumericUpDown13"
        Me.NumericUpDown13.Size = New System.Drawing.Size(77, 21)
        Me.NumericUpDown13.TabIndex = 10
        Me.NumericUpDown13.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(15, 81)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(140, 21)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "Quantizer P-B Ratio:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumericUpDown14
        '
        Me.NumericUpDown14.DecimalPlaces = 1
        Me.NumericUpDown14.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown14.Location = New System.Drawing.Point(161, 54)
        Me.NumericUpDown14.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown14.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown14.Name = "NumericUpDown14"
        Me.NumericUpDown14.Size = New System.Drawing.Size(77, 21)
        Me.NumericUpDown14.TabIndex = 8
        Me.NumericUpDown14.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(15, 54)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(140, 21)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "Quantizer I-P Ratio:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumericUpDown15
        '
        Me.NumericUpDown15.Location = New System.Drawing.Point(281, 26)
        Me.NumericUpDown15.Maximum = New Decimal(New Integer() {51, 0, 0, 0})
        Me.NumericUpDown15.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown15.Name = "NumericUpDown15"
        Me.NumericUpDown15.Size = New System.Drawing.Size(54, 21)
        Me.NumericUpDown15.TabIndex = 6
        Me.NumericUpDown15.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NumericUpDown16
        '
        Me.NumericUpDown16.Location = New System.Drawing.Point(221, 26)
        Me.NumericUpDown16.Maximum = New Decimal(New Integer() {51, 0, 0, 0})
        Me.NumericUpDown16.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown16.Name = "NumericUpDown16"
        Me.NumericUpDown16.Size = New System.Drawing.Size(54, 21)
        Me.NumericUpDown16.TabIndex = 5
        Me.NumericUpDown16.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NumericUpDown17
        '
        Me.NumericUpDown17.Location = New System.Drawing.Point(161, 26)
        Me.NumericUpDown17.Maximum = New Decimal(New Integer() {51, 0, 0, 0})
        Me.NumericUpDown17.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown17.Name = "NumericUpDown17"
        Me.NumericUpDown17.Size = New System.Drawing.Size(54, 21)
        Me.NumericUpDown17.TabIndex = 3
        Me.NumericUpDown17.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(15, 26)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(140, 21)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Min/Max/Delta:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DefBTN
        '
        Me.DefBTN.Location = New System.Drawing.Point(10, 413)
        Me.DefBTN.Name = "DefBTN"
        Me.DefBTN.Size = New System.Drawing.Size(100, 25)
        Me.DefBTN.TabIndex = 1
        Me.DefBTN.Text = "기본값"
        Me.DefBTN.UseVisualStyleBackColor = True
        '
        'CancelBTN
        '
        Me.CancelBTN.Location = New System.Drawing.Point(578, 413)
        Me.CancelBTN.Name = "CancelBTN"
        Me.CancelBTN.Size = New System.Drawing.Size(100, 25)
        Me.CancelBTN.TabIndex = 2
        Me.CancelBTN.Text = "취소"
        Me.CancelBTN.UseVisualStyleBackColor = True
        '
        'OKBTN
        '
        Me.OKBTN.Location = New System.Drawing.Point(472, 413)
        Me.OKBTN.Name = "OKBTN"
        Me.OKBTN.Size = New System.Drawing.Size(100, 25)
        Me.OKBTN.TabIndex = 3
        Me.OKBTN.Text = "확인"
        Me.OKBTN.UseVisualStyleBackColor = True
        '
        'BPanel
        '
        Me.BPanel.Controls.Add(Me.SettingTabControl)
        Me.BPanel.Controls.Add(Me.OKBTN)
        Me.BPanel.Controls.Add(Me.DefBTN)
        Me.BPanel.Controls.Add(Me.CancelBTN)
        Me.BPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BPanel.Location = New System.Drawing.Point(0, 0)
        Me.BPanel.Name = "BPanel"
        Me.BPanel.Size = New System.Drawing.Size(690, 450)
        Me.BPanel.TabIndex = 4
        '
        'x264optsFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 450)
        Me.Controls.Add(Me.BPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "x264optsFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "x264 configuration"
        Me.SettingTabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.ffmpegPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.x264PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TurboGroupBox.ResumeLayout(False)
        Me.TurboGroupBox.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ThreadsNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents LevelComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ProfileComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
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
    Friend WithEvents TurboGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents FastfirstpassCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents x264PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents ffmpegPictureBox As System.Windows.Forms.PictureBox
End Class
