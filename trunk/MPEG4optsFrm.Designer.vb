<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MPEG4optsFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MPEG4optsFrm))
        Me.SettingTabControl = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.ffmpegPictureBox = New System.Windows.Forms.PictureBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.QPELCheckBox = New System.Windows.Forms.CheckBox
        Me.TopFieldFirstCheckBox = New System.Windows.Forms.CheckBox
        Me.InterlacedEncodingCheckBox = New System.Windows.Forms.CheckBox
        Me._4MotionVectorCheckBox = New System.Windows.Forms.CheckBox
        Me.GrayscaleCheckBox = New System.Windows.Forms.CheckBox
        Me.AdaptiveQuantizationCheckBox = New System.Windows.Forms.CheckBox
        Me.QuantizationTypeComboBox = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ThreadsNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.RefinettmvuibmCheckBox = New System.Windows.Forms.CheckBox
        Me.DownscalesffdBfdCheckBox = New System.Windows.Forms.CheckBox
        Me.ClosedGOPCheckBox = New System.Windows.Forms.CheckBox
        Me.BVOPsNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.BVOPsLabel = New System.Windows.Forms.Label
        Me.BFramesCheckBox = New System.Windows.Forms.CheckBox
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.PmecfComboBox = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.IdcfComboBox = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.McfComboBox = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.SpmcfComboBox = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.FpmcfComboBox = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.HQModeComboBox = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.DiamondtsfmeComboBox = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.DCTalgorithmComboBox = New System.Windows.Forms.ComboBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.TrellisQuantizationCheckBox = New System.Windows.Forms.CheckBox
        Me.RateControlGroupBox = New System.Windows.Forms.GroupBox
        Me.MaxVBTextBox = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.RCBufferSizeTextBox = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.MinVBTextBox = New System.Windows.Forms.TextBox
        Me.QuantizerGroupBox = New System.Windows.Forms.GroupBox
        Me.QuantizerBlurNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.Label16 = New System.Windows.Forms.Label
        Me.QuantizerCompressionNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.Label25 = New System.Windows.Forms.Label
        Me.QDeltaNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.QMaxNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.QMinNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.Label15 = New System.Windows.Forms.Label
        Me.BPanel = New System.Windows.Forms.Panel
        Me.OKBTN = New System.Windows.Forms.Button
        Me.CancelBTN = New System.Windows.Forms.Button
        Me.DefBTN = New System.Windows.Forms.Button
        Me.SettingTabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.ffmpegPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ThreadsNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.BVOPsNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.RateControlGroupBox.SuspendLayout()
        Me.QuantizerGroupBox.SuspendLayout()
        CType(Me.QuantizerBlurNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantizerCompressionNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QDeltaNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QMaxNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QMinNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabPage1.Controls.Add(Me.ffmpegPictureBox)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        resources.ApplyResources(Me.TabPage1, "TabPage1")
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ffmpegPictureBox
        '
        Me.ffmpegPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ffmpegPictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.ffmpegPictureBox, "ffmpegPictureBox")
        Me.ffmpegPictureBox.Name = "ffmpegPictureBox"
        Me.ffmpegPictureBox.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.QPELCheckBox)
        Me.GroupBox2.Controls.Add(Me.TopFieldFirstCheckBox)
        Me.GroupBox2.Controls.Add(Me.InterlacedEncodingCheckBox)
        Me.GroupBox2.Controls.Add(Me._4MotionVectorCheckBox)
        Me.GroupBox2.Controls.Add(Me.GrayscaleCheckBox)
        Me.GroupBox2.Controls.Add(Me.AdaptiveQuantizationCheckBox)
        Me.GroupBox2.Controls.Add(Me.QuantizationTypeComboBox)
        Me.GroupBox2.Controls.Add(Me.Label2)
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'QPELCheckBox
        '
        resources.ApplyResources(Me.QPELCheckBox, "QPELCheckBox")
        Me.QPELCheckBox.Name = "QPELCheckBox"
        Me.QPELCheckBox.UseVisualStyleBackColor = True
        '
        'TopFieldFirstCheckBox
        '
        resources.ApplyResources(Me.TopFieldFirstCheckBox, "TopFieldFirstCheckBox")
        Me.TopFieldFirstCheckBox.Name = "TopFieldFirstCheckBox"
        Me.TopFieldFirstCheckBox.UseVisualStyleBackColor = True
        '
        'InterlacedEncodingCheckBox
        '
        resources.ApplyResources(Me.InterlacedEncodingCheckBox, "InterlacedEncodingCheckBox")
        Me.InterlacedEncodingCheckBox.Name = "InterlacedEncodingCheckBox"
        Me.InterlacedEncodingCheckBox.UseVisualStyleBackColor = True
        '
        '_4MotionVectorCheckBox
        '
        resources.ApplyResources(Me._4MotionVectorCheckBox, "_4MotionVectorCheckBox")
        Me._4MotionVectorCheckBox.Name = "_4MotionVectorCheckBox"
        Me._4MotionVectorCheckBox.UseVisualStyleBackColor = True
        '
        'GrayscaleCheckBox
        '
        resources.ApplyResources(Me.GrayscaleCheckBox, "GrayscaleCheckBox")
        Me.GrayscaleCheckBox.Name = "GrayscaleCheckBox"
        Me.GrayscaleCheckBox.UseVisualStyleBackColor = True
        '
        'AdaptiveQuantizationCheckBox
        '
        resources.ApplyResources(Me.AdaptiveQuantizationCheckBox, "AdaptiveQuantizationCheckBox")
        Me.AdaptiveQuantizationCheckBox.Name = "AdaptiveQuantizationCheckBox"
        Me.AdaptiveQuantizationCheckBox.UseVisualStyleBackColor = True
        '
        'QuantizationTypeComboBox
        '
        Me.QuantizationTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.QuantizationTypeComboBox.FormattingEnabled = True
        Me.QuantizationTypeComboBox.Items.AddRange(New Object() {resources.GetString("QuantizationTypeComboBox.Items"), resources.GetString("QuantizationTypeComboBox.Items1")})
        resources.ApplyResources(Me.QuantizationTypeComboBox, "QuantizationTypeComboBox")
        Me.QuantizationTypeComboBox.Name = "QuantizationTypeComboBox"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ThreadsNumericUpDown)
        Me.GroupBox1.Controls.Add(Me.Label1)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'ThreadsNumericUpDown
        '
        resources.ApplyResources(Me.ThreadsNumericUpDown, "ThreadsNumericUpDown")
        Me.ThreadsNumericUpDown.Name = "ThreadsNumericUpDown"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        resources.ApplyResources(Me.TabPage2, "TabPage2")
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RefinettmvuibmCheckBox)
        Me.GroupBox3.Controls.Add(Me.DownscalesffdBfdCheckBox)
        Me.GroupBox3.Controls.Add(Me.ClosedGOPCheckBox)
        Me.GroupBox3.Controls.Add(Me.BVOPsNumericUpDown)
        Me.GroupBox3.Controls.Add(Me.BVOPsLabel)
        Me.GroupBox3.Controls.Add(Me.BFramesCheckBox)
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'RefinettmvuibmCheckBox
        '
        resources.ApplyResources(Me.RefinettmvuibmCheckBox, "RefinettmvuibmCheckBox")
        Me.RefinettmvuibmCheckBox.Name = "RefinettmvuibmCheckBox"
        Me.RefinettmvuibmCheckBox.UseVisualStyleBackColor = True
        '
        'DownscalesffdBfdCheckBox
        '
        resources.ApplyResources(Me.DownscalesffdBfdCheckBox, "DownscalesffdBfdCheckBox")
        Me.DownscalesffdBfdCheckBox.Name = "DownscalesffdBfdCheckBox"
        Me.DownscalesffdBfdCheckBox.UseVisualStyleBackColor = True
        '
        'ClosedGOPCheckBox
        '
        resources.ApplyResources(Me.ClosedGOPCheckBox, "ClosedGOPCheckBox")
        Me.ClosedGOPCheckBox.Name = "ClosedGOPCheckBox"
        Me.ClosedGOPCheckBox.UseVisualStyleBackColor = True
        '
        'BVOPsNumericUpDown
        '
        resources.ApplyResources(Me.BVOPsNumericUpDown, "BVOPsNumericUpDown")
        Me.BVOPsNumericUpDown.Maximum = New Decimal(New Integer() {16, 0, 0, 0})
        Me.BVOPsNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.BVOPsNumericUpDown.Name = "BVOPsNumericUpDown"
        Me.BVOPsNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'BVOPsLabel
        '
        resources.ApplyResources(Me.BVOPsLabel, "BVOPsLabel")
        Me.BVOPsLabel.Name = "BVOPsLabel"
        '
        'BFramesCheckBox
        '
        resources.ApplyResources(Me.BFramesCheckBox, "BFramesCheckBox")
        Me.BFramesCheckBox.Name = "BFramesCheckBox"
        Me.BFramesCheckBox.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox5)
        Me.TabPage3.Controls.Add(Me.GroupBox4)
        resources.ApplyResources(Me.TabPage3, "TabPage3")
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.PmecfComboBox)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.IdcfComboBox)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.McfComboBox)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.SpmcfComboBox)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.FpmcfComboBox)
        Me.GroupBox5.Controls.Add(Me.Label8)
        resources.ApplyResources(Me.GroupBox5, "GroupBox5")
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.TabStop = False
        '
        'PmecfComboBox
        '
        Me.PmecfComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PmecfComboBox.FormattingEnabled = True
        Me.PmecfComboBox.Items.AddRange(New Object() {resources.GetString("PmecfComboBox.Items"), resources.GetString("PmecfComboBox.Items1"), resources.GetString("PmecfComboBox.Items2"), resources.GetString("PmecfComboBox.Items3"), resources.GetString("PmecfComboBox.Items4"), resources.GetString("PmecfComboBox.Items5"), resources.GetString("PmecfComboBox.Items6"), resources.GetString("PmecfComboBox.Items7"), resources.GetString("PmecfComboBox.Items8"), resources.GetString("PmecfComboBox.Items9"), resources.GetString("PmecfComboBox.Items10"), resources.GetString("PmecfComboBox.Items11"), resources.GetString("PmecfComboBox.Items12"), resources.GetString("PmecfComboBox.Items13"), resources.GetString("PmecfComboBox.Items14")})
        resources.ApplyResources(Me.PmecfComboBox, "PmecfComboBox")
        Me.PmecfComboBox.Name = "PmecfComboBox"
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.Name = "Label12"
        '
        'IdcfComboBox
        '
        Me.IdcfComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IdcfComboBox.FormattingEnabled = True
        Me.IdcfComboBox.Items.AddRange(New Object() {resources.GetString("IdcfComboBox.Items"), resources.GetString("IdcfComboBox.Items1"), resources.GetString("IdcfComboBox.Items2"), resources.GetString("IdcfComboBox.Items3"), resources.GetString("IdcfComboBox.Items4"), resources.GetString("IdcfComboBox.Items5"), resources.GetString("IdcfComboBox.Items6"), resources.GetString("IdcfComboBox.Items7"), resources.GetString("IdcfComboBox.Items8"), resources.GetString("IdcfComboBox.Items9"), resources.GetString("IdcfComboBox.Items10"), resources.GetString("IdcfComboBox.Items11"), resources.GetString("IdcfComboBox.Items12"), resources.GetString("IdcfComboBox.Items13"), resources.GetString("IdcfComboBox.Items14")})
        resources.ApplyResources(Me.IdcfComboBox, "IdcfComboBox")
        Me.IdcfComboBox.Name = "IdcfComboBox"
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.Name = "Label11"
        '
        'McfComboBox
        '
        Me.McfComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.McfComboBox.FormattingEnabled = True
        Me.McfComboBox.Items.AddRange(New Object() {resources.GetString("McfComboBox.Items"), resources.GetString("McfComboBox.Items1"), resources.GetString("McfComboBox.Items2"), resources.GetString("McfComboBox.Items3"), resources.GetString("McfComboBox.Items4"), resources.GetString("McfComboBox.Items5"), resources.GetString("McfComboBox.Items6"), resources.GetString("McfComboBox.Items7"), resources.GetString("McfComboBox.Items8"), resources.GetString("McfComboBox.Items9"), resources.GetString("McfComboBox.Items10"), resources.GetString("McfComboBox.Items11"), resources.GetString("McfComboBox.Items12"), resources.GetString("McfComboBox.Items13"), resources.GetString("McfComboBox.Items14")})
        resources.ApplyResources(Me.McfComboBox, "McfComboBox")
        Me.McfComboBox.Name = "McfComboBox"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        '
        'SpmcfComboBox
        '
        Me.SpmcfComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SpmcfComboBox.FormattingEnabled = True
        Me.SpmcfComboBox.Items.AddRange(New Object() {resources.GetString("SpmcfComboBox.Items"), resources.GetString("SpmcfComboBox.Items1"), resources.GetString("SpmcfComboBox.Items2"), resources.GetString("SpmcfComboBox.Items3"), resources.GetString("SpmcfComboBox.Items4"), resources.GetString("SpmcfComboBox.Items5"), resources.GetString("SpmcfComboBox.Items6"), resources.GetString("SpmcfComboBox.Items7"), resources.GetString("SpmcfComboBox.Items8"), resources.GetString("SpmcfComboBox.Items9"), resources.GetString("SpmcfComboBox.Items10"), resources.GetString("SpmcfComboBox.Items11"), resources.GetString("SpmcfComboBox.Items12"), resources.GetString("SpmcfComboBox.Items13"), resources.GetString("SpmcfComboBox.Items14")})
        resources.ApplyResources(Me.SpmcfComboBox, "SpmcfComboBox")
        Me.SpmcfComboBox.Name = "SpmcfComboBox"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'FpmcfComboBox
        '
        Me.FpmcfComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FpmcfComboBox.FormattingEnabled = True
        Me.FpmcfComboBox.Items.AddRange(New Object() {resources.GetString("FpmcfComboBox.Items"), resources.GetString("FpmcfComboBox.Items1"), resources.GetString("FpmcfComboBox.Items2"), resources.GetString("FpmcfComboBox.Items3"), resources.GetString("FpmcfComboBox.Items4"), resources.GetString("FpmcfComboBox.Items5"), resources.GetString("FpmcfComboBox.Items6"), resources.GetString("FpmcfComboBox.Items7"), resources.GetString("FpmcfComboBox.Items8"), resources.GetString("FpmcfComboBox.Items9"), resources.GetString("FpmcfComboBox.Items10"), resources.GetString("FpmcfComboBox.Items11"), resources.GetString("FpmcfComboBox.Items12"), resources.GetString("FpmcfComboBox.Items13"), resources.GetString("FpmcfComboBox.Items14")})
        resources.ApplyResources(Me.FpmcfComboBox, "FpmcfComboBox")
        Me.FpmcfComboBox.Name = "FpmcfComboBox"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.HQModeComboBox)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.DiamondtsfmeComboBox)
        Me.GroupBox4.Controls.Add(Me.Label6)
        resources.ApplyResources(Me.GroupBox4, "GroupBox4")
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.TabStop = False
        '
        'HQModeComboBox
        '
        Me.HQModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.HQModeComboBox.FormattingEnabled = True
        Me.HQModeComboBox.Items.AddRange(New Object() {resources.GetString("HQModeComboBox.Items"), resources.GetString("HQModeComboBox.Items1"), resources.GetString("HQModeComboBox.Items2")})
        resources.ApplyResources(Me.HQModeComboBox, "HQModeComboBox")
        Me.HQModeComboBox.Name = "HQModeComboBox"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'DiamondtsfmeComboBox
        '
        Me.DiamondtsfmeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DiamondtsfmeComboBox.FormattingEnabled = True
        Me.DiamondtsfmeComboBox.Items.AddRange(New Object() {resources.GetString("DiamondtsfmeComboBox.Items"), resources.GetString("DiamondtsfmeComboBox.Items1"), resources.GetString("DiamondtsfmeComboBox.Items2"), resources.GetString("DiamondtsfmeComboBox.Items3"), resources.GetString("DiamondtsfmeComboBox.Items4"), resources.GetString("DiamondtsfmeComboBox.Items5"), resources.GetString("DiamondtsfmeComboBox.Items6"), resources.GetString("DiamondtsfmeComboBox.Items7"), resources.GetString("DiamondtsfmeComboBox.Items8"), resources.GetString("DiamondtsfmeComboBox.Items9"), resources.GetString("DiamondtsfmeComboBox.Items10"), resources.GetString("DiamondtsfmeComboBox.Items11")})
        resources.ApplyResources(Me.DiamondtsfmeComboBox, "DiamondtsfmeComboBox")
        Me.DiamondtsfmeComboBox.Name = "DiamondtsfmeComboBox"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GroupBox7)
        Me.TabPage4.Controls.Add(Me.RateControlGroupBox)
        Me.TabPage4.Controls.Add(Me.QuantizerGroupBox)
        resources.ApplyResources(Me.TabPage4, "TabPage4")
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.DCTalgorithmComboBox)
        Me.GroupBox7.Controls.Add(Me.Label18)
        Me.GroupBox7.Controls.Add(Me.TrellisQuantizationCheckBox)
        resources.ApplyResources(Me.GroupBox7, "GroupBox7")
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.TabStop = False
        '
        'DCTalgorithmComboBox
        '
        Me.DCTalgorithmComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DCTalgorithmComboBox.FormattingEnabled = True
        Me.DCTalgorithmComboBox.Items.AddRange(New Object() {resources.GetString("DCTalgorithmComboBox.Items"), resources.GetString("DCTalgorithmComboBox.Items1"), resources.GetString("DCTalgorithmComboBox.Items2"), resources.GetString("DCTalgorithmComboBox.Items3"), resources.GetString("DCTalgorithmComboBox.Items4"), resources.GetString("DCTalgorithmComboBox.Items5"), resources.GetString("DCTalgorithmComboBox.Items6")})
        resources.ApplyResources(Me.DCTalgorithmComboBox, "DCTalgorithmComboBox")
        Me.DCTalgorithmComboBox.Name = "DCTalgorithmComboBox"
        '
        'Label18
        '
        resources.ApplyResources(Me.Label18, "Label18")
        Me.Label18.Name = "Label18"
        '
        'TrellisQuantizationCheckBox
        '
        resources.ApplyResources(Me.TrellisQuantizationCheckBox, "TrellisQuantizationCheckBox")
        Me.TrellisQuantizationCheckBox.Name = "TrellisQuantizationCheckBox"
        Me.TrellisQuantizationCheckBox.UseVisualStyleBackColor = True
        '
        'RateControlGroupBox
        '
        Me.RateControlGroupBox.Controls.Add(Me.MaxVBTextBox)
        Me.RateControlGroupBox.Controls.Add(Me.Label17)
        Me.RateControlGroupBox.Controls.Add(Me.Label14)
        Me.RateControlGroupBox.Controls.Add(Me.RCBufferSizeTextBox)
        Me.RateControlGroupBox.Controls.Add(Me.Label13)
        Me.RateControlGroupBox.Controls.Add(Me.MinVBTextBox)
        resources.ApplyResources(Me.RateControlGroupBox, "RateControlGroupBox")
        Me.RateControlGroupBox.Name = "RateControlGroupBox"
        Me.RateControlGroupBox.TabStop = False
        '
        'MaxVBTextBox
        '
        resources.ApplyResources(Me.MaxVBTextBox, "MaxVBTextBox")
        Me.MaxVBTextBox.Name = "MaxVBTextBox"
        '
        'Label17
        '
        resources.ApplyResources(Me.Label17, "Label17")
        Me.Label17.Name = "Label17"
        '
        'Label14
        '
        resources.ApplyResources(Me.Label14, "Label14")
        Me.Label14.Name = "Label14"
        '
        'RCBufferSizeTextBox
        '
        resources.ApplyResources(Me.RCBufferSizeTextBox, "RCBufferSizeTextBox")
        Me.RCBufferSizeTextBox.Name = "RCBufferSizeTextBox"
        '
        'Label13
        '
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.Name = "Label13"
        '
        'MinVBTextBox
        '
        resources.ApplyResources(Me.MinVBTextBox, "MinVBTextBox")
        Me.MinVBTextBox.Name = "MinVBTextBox"
        '
        'QuantizerGroupBox
        '
        Me.QuantizerGroupBox.Controls.Add(Me.QuantizerBlurNumericUpDown)
        Me.QuantizerGroupBox.Controls.Add(Me.Label16)
        Me.QuantizerGroupBox.Controls.Add(Me.QuantizerCompressionNumericUpDown)
        Me.QuantizerGroupBox.Controls.Add(Me.Label25)
        Me.QuantizerGroupBox.Controls.Add(Me.QDeltaNumericUpDown)
        Me.QuantizerGroupBox.Controls.Add(Me.QMaxNumericUpDown)
        Me.QuantizerGroupBox.Controls.Add(Me.QMinNumericUpDown)
        Me.QuantizerGroupBox.Controls.Add(Me.Label15)
        resources.ApplyResources(Me.QuantizerGroupBox, "QuantizerGroupBox")
        Me.QuantizerGroupBox.Name = "QuantizerGroupBox"
        Me.QuantizerGroupBox.TabStop = False
        '
        'QuantizerBlurNumericUpDown
        '
        Me.QuantizerBlurNumericUpDown.DecimalPlaces = 1
        Me.QuantizerBlurNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        resources.ApplyResources(Me.QuantizerBlurNumericUpDown, "QuantizerBlurNumericUpDown")
        Me.QuantizerBlurNumericUpDown.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.QuantizerBlurNumericUpDown.Name = "QuantizerBlurNumericUpDown"
        Me.QuantizerBlurNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label16
        '
        resources.ApplyResources(Me.Label16, "Label16")
        Me.Label16.Name = "Label16"
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
        'QDeltaNumericUpDown
        '
        resources.ApplyResources(Me.QDeltaNumericUpDown, "QDeltaNumericUpDown")
        Me.QDeltaNumericUpDown.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.QDeltaNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.QDeltaNumericUpDown.Name = "QDeltaNumericUpDown"
        Me.QDeltaNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'QMaxNumericUpDown
        '
        resources.ApplyResources(Me.QMaxNumericUpDown, "QMaxNumericUpDown")
        Me.QMaxNumericUpDown.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.QMaxNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.QMaxNumericUpDown.Name = "QMaxNumericUpDown"
        Me.QMaxNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'QMinNumericUpDown
        '
        resources.ApplyResources(Me.QMinNumericUpDown, "QMinNumericUpDown")
        Me.QMinNumericUpDown.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.QMinNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.QMinNumericUpDown.Name = "QMinNumericUpDown"
        Me.QMinNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label15
        '
        resources.ApplyResources(Me.Label15, "Label15")
        Me.Label15.Name = "Label15"
        '
        'BPanel
        '
        Me.BPanel.Controls.Add(Me.OKBTN)
        Me.BPanel.Controls.Add(Me.CancelBTN)
        Me.BPanel.Controls.Add(Me.DefBTN)
        Me.BPanel.Controls.Add(Me.SettingTabControl)
        resources.ApplyResources(Me.BPanel, "BPanel")
        Me.BPanel.Name = "BPanel"
        '
        'OKBTN
        '
        resources.ApplyResources(Me.OKBTN, "OKBTN")
        Me.OKBTN.Name = "OKBTN"
        Me.OKBTN.UseVisualStyleBackColor = True
        '
        'CancelBTN
        '
        resources.ApplyResources(Me.CancelBTN, "CancelBTN")
        Me.CancelBTN.Name = "CancelBTN"
        Me.CancelBTN.UseVisualStyleBackColor = True
        '
        'DefBTN
        '
        resources.ApplyResources(Me.DefBTN, "DefBTN")
        Me.DefBTN.Name = "DefBTN"
        Me.DefBTN.UseVisualStyleBackColor = True
        '
        'MPEG4optsFrm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MPEG4optsFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SettingTabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.ffmpegPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ThreadsNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.BVOPsNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.RateControlGroupBox.ResumeLayout(False)
        Me.RateControlGroupBox.PerformLayout()
        Me.QuantizerGroupBox.ResumeLayout(False)
        CType(Me.QuantizerBlurNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantizerCompressionNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QDeltaNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QMaxNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QMinNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SettingTabControl As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents BPanel As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ThreadsNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ffmpegPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents QuantizationTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TopFieldFirstCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents InterlacedEncodingCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents _4MotionVectorCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GrayscaleCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AdaptiveQuantizationCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents QPELCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BVOPsNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents BVOPsLabel As System.Windows.Forms.Label
    Friend WithEvents BFramesCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents RefinettmvuibmCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents DownscalesffdBfdCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ClosedGOPCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DiamondtsfmeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents HQModeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents PmecfComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents IdcfComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents McfComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents SpmcfComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents FpmcfComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents QuantizerGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents QMaxNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents QMinNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents RCBufferSizeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MinVBTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MaxVBTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QDeltaNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents QuantizerBlurNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents QuantizerCompressionNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents RateControlGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents DCTalgorithmComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TrellisQuantizationCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents DefBTN As System.Windows.Forms.Button
    Friend WithEvents OKBTN As System.Windows.Forms.Button
    Friend WithEvents CancelBTN As System.Windows.Forms.Button
End Class
