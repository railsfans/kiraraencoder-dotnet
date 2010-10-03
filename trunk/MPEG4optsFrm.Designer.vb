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
        Me.SettingTabControl.Location = New System.Drawing.Point(10, 10)
        Me.SettingTabControl.Name = "SettingTabControl"
        Me.SettingTabControl.SelectedIndex = 0
        Me.SettingTabControl.Size = New System.Drawing.Size(464, 385)
        Me.SettingTabControl.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ffmpegPictureBox)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(456, 359)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Main"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ffmpegPictureBox
        '
        Me.ffmpegPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ffmpegPictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ffmpegPictureBox.Image = CType(resources.GetObject("ffmpegPictureBox.Image"), System.Drawing.Image)
        Me.ffmpegPictureBox.Location = New System.Drawing.Point(164, 273)
        Me.ffmpegPictureBox.Name = "ffmpegPictureBox"
        Me.ffmpegPictureBox.Size = New System.Drawing.Size(276, 67)
        Me.ffmpegPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ffmpegPictureBox.TabIndex = 6
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
        Me.GroupBox2.Location = New System.Drawing.Point(10, 83)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(430, 172)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Main"
        '
        'QPELCheckBox
        '
        Me.QPELCheckBox.AutoSize = True
        Me.QPELCheckBox.Location = New System.Drawing.Point(18, 136)
        Me.QPELCheckBox.Name = "QPELCheckBox"
        Me.QPELCheckBox.Size = New System.Drawing.Size(139, 16)
        Me.QPELCheckBox.TabIndex = 8
        Me.QPELCheckBox.Text = "QPEL(Quarter Pixel)"
        Me.QPELCheckBox.UseVisualStyleBackColor = True
        '
        'TopFieldFirstCheckBox
        '
        Me.TopFieldFirstCheckBox.AutoSize = True
        Me.TopFieldFirstCheckBox.Location = New System.Drawing.Point(230, 83)
        Me.TopFieldFirstCheckBox.Name = "TopFieldFirstCheckBox"
        Me.TopFieldFirstCheckBox.Size = New System.Drawing.Size(105, 16)
        Me.TopFieldFirstCheckBox.TabIndex = 7
        Me.TopFieldFirstCheckBox.Text = "Top Field First"
        Me.TopFieldFirstCheckBox.UseVisualStyleBackColor = True
        '
        'InterlacedEncodingCheckBox
        '
        Me.InterlacedEncodingCheckBox.AutoSize = True
        Me.InterlacedEncodingCheckBox.Location = New System.Drawing.Point(230, 61)
        Me.InterlacedEncodingCheckBox.Name = "InterlacedEncodingCheckBox"
        Me.InterlacedEncodingCheckBox.Size = New System.Drawing.Size(136, 16)
        Me.InterlacedEncodingCheckBox.TabIndex = 6
        Me.InterlacedEncodingCheckBox.Text = "Interlaced Encoding"
        Me.InterlacedEncodingCheckBox.UseVisualStyleBackColor = True
        '
        '_4MotionVectorCheckBox
        '
        Me._4MotionVectorCheckBox.AutoSize = True
        Me._4MotionVectorCheckBox.Location = New System.Drawing.Point(18, 105)
        Me._4MotionVectorCheckBox.Name = "_4MotionVectorCheckBox"
        Me._4MotionVectorCheckBox.Size = New System.Drawing.Size(112, 16)
        Me._4MotionVectorCheckBox.TabIndex = 5
        Me._4MotionVectorCheckBox.Text = "4 Motion Vector"
        Me._4MotionVectorCheckBox.UseVisualStyleBackColor = True
        '
        'GrayscaleCheckBox
        '
        Me.GrayscaleCheckBox.AutoSize = True
        Me.GrayscaleCheckBox.Location = New System.Drawing.Point(18, 83)
        Me.GrayscaleCheckBox.Name = "GrayscaleCheckBox"
        Me.GrayscaleCheckBox.Size = New System.Drawing.Size(82, 16)
        Me.GrayscaleCheckBox.TabIndex = 4
        Me.GrayscaleCheckBox.Text = "Grayscale"
        Me.GrayscaleCheckBox.UseVisualStyleBackColor = True
        '
        'AdaptiveQuantizationCheckBox
        '
        Me.AdaptiveQuantizationCheckBox.AutoSize = True
        Me.AdaptiveQuantizationCheckBox.Location = New System.Drawing.Point(18, 61)
        Me.AdaptiveQuantizationCheckBox.Name = "AdaptiveQuantizationCheckBox"
        Me.AdaptiveQuantizationCheckBox.Size = New System.Drawing.Size(146, 16)
        Me.AdaptiveQuantizationCheckBox.TabIndex = 3
        Me.AdaptiveQuantizationCheckBox.Text = "Adaptive Quantization"
        Me.AdaptiveQuantizationCheckBox.UseVisualStyleBackColor = True
        '
        'QuantizationTypeComboBox
        '
        Me.QuantizationTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.QuantizationTypeComboBox.FormattingEnabled = True
        Me.QuantizationTypeComboBox.Items.AddRange(New Object() {"H.263", "MPEG"})
        Me.QuantizationTypeComboBox.Location = New System.Drawing.Point(173, 24)
        Me.QuantizationTypeComboBox.Name = "QuantizationTypeComboBox"
        Me.QuantizationTypeComboBox.Size = New System.Drawing.Size(116, 20)
        Me.QuantizationTypeComboBox.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 12)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Quantization Type:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ThreadsNumericUpDown)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(217, 64)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Threads(0=Auto)"
        '
        'ThreadsNumericUpDown
        '
        Me.ThreadsNumericUpDown.Location = New System.Drawing.Point(105, 25)
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
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(456, 359)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "B-VOPs"
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
        Me.GroupBox3.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(430, 164)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "B-VOPs"
        '
        'RefinettmvuibmCheckBox
        '
        Me.RefinettmvuibmCheckBox.AutoSize = True
        Me.RefinettmvuibmCheckBox.Enabled = False
        Me.RefinettmvuibmCheckBox.Location = New System.Drawing.Point(15, 128)
        Me.RefinettmvuibmCheckBox.Name = "RefinettmvuibmCheckBox"
        Me.RefinettmvuibmCheckBox.Size = New System.Drawing.Size(386, 16)
        Me.RefinettmvuibmCheckBox.TabIndex = 11
        Me.RefinettmvuibmCheckBox.Text = "Refine the two motion vectors used in bidirectional macroblocks"
        Me.RefinettmvuibmCheckBox.UseVisualStyleBackColor = True
        '
        'DownscalesffdBfdCheckBox
        '
        Me.DownscalesffdBfdCheckBox.AutoSize = True
        Me.DownscalesffdBfdCheckBox.Enabled = False
        Me.DownscalesffdBfdCheckBox.Location = New System.Drawing.Point(15, 106)
        Me.DownscalesffdBfdCheckBox.Name = "DownscalesffdBfdCheckBox"
        Me.DownscalesffdBfdCheckBox.Size = New System.Drawing.Size(310, 16)
        Me.DownscalesffdBfdCheckBox.TabIndex = 10
        Me.DownscalesffdBfdCheckBox.Text = "Downscales frames for dynamic B-frame decision"
        Me.DownscalesffdBfdCheckBox.UseVisualStyleBackColor = True
        '
        'ClosedGOPCheckBox
        '
        Me.ClosedGOPCheckBox.AutoSize = True
        Me.ClosedGOPCheckBox.Enabled = False
        Me.ClosedGOPCheckBox.Location = New System.Drawing.Point(15, 84)
        Me.ClosedGOPCheckBox.Name = "ClosedGOPCheckBox"
        Me.ClosedGOPCheckBox.Size = New System.Drawing.Size(94, 16)
        Me.ClosedGOPCheckBox.TabIndex = 9
        Me.ClosedGOPCheckBox.Text = "Closed GOP"
        Me.ClosedGOPCheckBox.UseVisualStyleBackColor = True
        '
        'BVOPsNumericUpDown
        '
        Me.BVOPsNumericUpDown.Enabled = False
        Me.BVOPsNumericUpDown.Location = New System.Drawing.Point(274, 46)
        Me.BVOPsNumericUpDown.Maximum = New Decimal(New Integer() {16, 0, 0, 0})
        Me.BVOPsNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.BVOPsNumericUpDown.Name = "BVOPsNumericUpDown"
        Me.BVOPsNumericUpDown.Size = New System.Drawing.Size(66, 21)
        Me.BVOPsNumericUpDown.TabIndex = 2
        Me.BVOPsNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'BVOPsLabel
        '
        Me.BVOPsLabel.Enabled = False
        Me.BVOPsLabel.Location = New System.Drawing.Point(13, 46)
        Me.BVOPsLabel.Name = "BVOPsLabel"
        Me.BVOPsLabel.Size = New System.Drawing.Size(255, 21)
        Me.BVOPsLabel.TabIndex = 1
        Me.BVOPsLabel.Text = "B-VOPs - Max consecutive BVOPs:"
        Me.BVOPsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BFramesCheckBox
        '
        Me.BFramesCheckBox.AutoSize = True
        Me.BFramesCheckBox.Location = New System.Drawing.Point(15, 22)
        Me.BFramesCheckBox.Name = "BFramesCheckBox"
        Me.BFramesCheckBox.Size = New System.Drawing.Size(81, 16)
        Me.BFramesCheckBox.TabIndex = 0
        Me.BFramesCheckBox.Text = "B-Frames"
        Me.BFramesCheckBox.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox5)
        Me.TabPage3.Controls.Add(Me.GroupBox4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(456, 359)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Motion Estimation"
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
        Me.GroupBox5.Location = New System.Drawing.Point(10, 107)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(430, 169)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Compare Function"
        '
        'PmecfComboBox
        '
        Me.PmecfComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PmecfComboBox.FormattingEnabled = True
        Me.PmecfComboBox.Items.AddRange(New Object() {"SAD", "SSE", "SATD", "DCT", "PSNR", "BIT", "RD", "ZERO", "VSAD", "VSSE", "NSSE", "W53", "W97", "DCTMAX", "CHROMA"})
        Me.PmecfComboBox.Location = New System.Drawing.Point(290, 130)
        Me.PmecfComboBox.Name = "PmecfComboBox"
        Me.PmecfComboBox.Size = New System.Drawing.Size(115, 20)
        Me.PmecfComboBox.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(21, 130)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(263, 20)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Pre motion estimation compare function:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'IdcfComboBox
        '
        Me.IdcfComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IdcfComboBox.FormattingEnabled = True
        Me.IdcfComboBox.Items.AddRange(New Object() {"SAD", "SSE", "SATD", "DCT", "PSNR", "BIT", "RD", "ZERO", "VSAD", "VSSE", "NSSE", "W53", "W97", "DCTMAX", "CHROMA"})
        Me.IdcfComboBox.Location = New System.Drawing.Point(290, 104)
        Me.IdcfComboBox.Name = "IdcfComboBox"
        Me.IdcfComboBox.Size = New System.Drawing.Size(115, 20)
        Me.IdcfComboBox.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(21, 104)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(263, 20)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Interlaced dct compare function:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'McfComboBox
        '
        Me.McfComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.McfComboBox.FormattingEnabled = True
        Me.McfComboBox.Items.AddRange(New Object() {"SAD", "SSE", "SATD", "DCT", "PSNR", "BIT", "RD", "ZERO", "VSAD", "VSSE", "NSSE", "W53", "W97", "DCTMAX", "CHROMA"})
        Me.McfComboBox.Location = New System.Drawing.Point(290, 78)
        Me.McfComboBox.Name = "McfComboBox"
        Me.McfComboBox.Size = New System.Drawing.Size(115, 20)
        Me.McfComboBox.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(21, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(263, 20)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Macroblock compare function:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SpmcfComboBox
        '
        Me.SpmcfComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SpmcfComboBox.FormattingEnabled = True
        Me.SpmcfComboBox.Items.AddRange(New Object() {"SAD", "SSE", "SATD", "DCT", "PSNR", "BIT", "RD", "ZERO", "VSAD", "VSSE", "NSSE", "W53", "W97", "DCTMAX", "CHROMA"})
        Me.SpmcfComboBox.Location = New System.Drawing.Point(290, 52)
        Me.SpmcfComboBox.Name = "SpmcfComboBox"
        Me.SpmcfComboBox.Size = New System.Drawing.Size(115, 20)
        Me.SpmcfComboBox.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(21, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(263, 20)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Sub pel me compare function:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FpmcfComboBox
        '
        Me.FpmcfComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FpmcfComboBox.FormattingEnabled = True
        Me.FpmcfComboBox.Items.AddRange(New Object() {"SAD", "SSE", "SATD", "DCT", "PSNR", "BIT", "RD", "ZERO", "VSAD", "VSSE", "NSSE", "W53", "W97", "DCTMAX", "CHROMA"})
        Me.FpmcfComboBox.Location = New System.Drawing.Point(290, 26)
        Me.FpmcfComboBox.Name = "FpmcfComboBox"
        Me.FpmcfComboBox.Size = New System.Drawing.Size(115, 20)
        Me.FpmcfComboBox.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(21, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(263, 20)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Full pel me compare function:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.HQModeComboBox)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.DiamondtsfmeComboBox)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(430, 88)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Motion Estimation"
        '
        'HQModeComboBox
        '
        Me.HQModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.HQModeComboBox.FormattingEnabled = True
        Me.HQModeComboBox.Items.AddRange(New Object() {"MBCMP", "FEWEST BITS", "BEST RATE DISTORTION"})
        Me.HQModeComboBox.Location = New System.Drawing.Point(204, 51)
        Me.HQModeComboBox.Name = "HQModeComboBox"
        Me.HQModeComboBox.Size = New System.Drawing.Size(201, 20)
        Me.HQModeComboBox.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(19, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(179, 20)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "HQ Mode:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DiamondtsfmeComboBox
        '
        Me.DiamondtsfmeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DiamondtsfmeComboBox.FormattingEnabled = True
        Me.DiamondtsfmeComboBox.Items.AddRange(New Object() {"ZERO", "FULL", "EPZS", "ESA", "TESA", "DIA", "LOG", "PHODS", "X1", "HEX", "UMH", "ITER"})
        Me.DiamondtsfmeComboBox.Location = New System.Drawing.Point(290, 25)
        Me.DiamondtsfmeComboBox.Name = "DiamondtsfmeComboBox"
        Me.DiamondtsfmeComboBox.Size = New System.Drawing.Size(115, 20)
        Me.DiamondtsfmeComboBox.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(19, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(265, 20)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Diamond type && size for motion estimation:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GroupBox7)
        Me.TabPage4.Controls.Add(Me.RateControlGroupBox)
        Me.TabPage4.Controls.Add(Me.QuantizerGroupBox)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(456, 359)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Rate Control"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.DCTalgorithmComboBox)
        Me.GroupBox7.Controls.Add(Me.Label18)
        Me.GroupBox7.Controls.Add(Me.TrellisQuantizationCheckBox)
        Me.GroupBox7.Location = New System.Drawing.Point(10, 257)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(430, 81)
        Me.GroupBox7.TabIndex = 17
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Trellis/DCT"
        '
        'DCTalgorithmComboBox
        '
        Me.DCTalgorithmComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DCTalgorithmComboBox.FormattingEnabled = True
        Me.DCTalgorithmComboBox.Items.AddRange(New Object() {"AUTO", "FASTINT", "INT", "MMX", "MLIB", "ALTIVEC", "FAAN"})
        Me.DCTalgorithmComboBox.Location = New System.Drawing.Point(155, 44)
        Me.DCTalgorithmComboBox.Name = "DCTalgorithmComboBox"
        Me.DCTalgorithmComboBox.Size = New System.Drawing.Size(148, 20)
        Me.DCTalgorithmComboBox.TabIndex = 3
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(15, 50)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(90, 12)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "DCT algorithm:"
        '
        'TrellisQuantizationCheckBox
        '
        Me.TrellisQuantizationCheckBox.AutoSize = True
        Me.TrellisQuantizationCheckBox.Location = New System.Drawing.Point(17, 24)
        Me.TrellisQuantizationCheckBox.Name = "TrellisQuantizationCheckBox"
        Me.TrellisQuantizationCheckBox.Size = New System.Drawing.Size(133, 16)
        Me.TrellisQuantizationCheckBox.TabIndex = 0
        Me.TrellisQuantizationCheckBox.Text = "Trellis Quantization"
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
        Me.RateControlGroupBox.Location = New System.Drawing.Point(10, 138)
        Me.RateControlGroupBox.Name = "RateControlGroupBox"
        Me.RateControlGroupBox.Size = New System.Drawing.Size(430, 110)
        Me.RateControlGroupBox.TabIndex = 16
        Me.RateControlGroupBox.TabStop = False
        Me.RateControlGroupBox.Text = "Rate Control"
        '
        'MaxVBTextBox
        '
        Me.MaxVBTextBox.Location = New System.Drawing.Point(226, 47)
        Me.MaxVBTextBox.Name = "MaxVBTextBox"
        Me.MaxVBTextBox.Size = New System.Drawing.Size(77, 21)
        Me.MaxVBTextBox.TabIndex = 13
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(15, 74)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(205, 21)
        Me.Label17.TabIndex = 11
        Me.Label17.Text = "Ratecontrol buffer size(Kbit/s):"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(15, 47)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(205, 21)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Max video bitrate(Kbit/s):"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RCBufferSizeTextBox
        '
        Me.RCBufferSizeTextBox.Location = New System.Drawing.Point(226, 74)
        Me.RCBufferSizeTextBox.Name = "RCBufferSizeTextBox"
        Me.RCBufferSizeTextBox.Size = New System.Drawing.Size(77, 21)
        Me.RCBufferSizeTextBox.TabIndex = 15
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(15, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(205, 21)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Min video bitrate(Kbit/s):"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MinVBTextBox
        '
        Me.MinVBTextBox.Location = New System.Drawing.Point(226, 20)
        Me.MinVBTextBox.Name = "MinVBTextBox"
        Me.MinVBTextBox.Size = New System.Drawing.Size(77, 21)
        Me.MinVBTextBox.TabIndex = 14
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
        Me.QuantizerGroupBox.Location = New System.Drawing.Point(10, 10)
        Me.QuantizerGroupBox.Name = "QuantizerGroupBox"
        Me.QuantizerGroupBox.Size = New System.Drawing.Size(430, 119)
        Me.QuantizerGroupBox.TabIndex = 3
        Me.QuantizerGroupBox.TabStop = False
        Me.QuantizerGroupBox.Text = "Quantizer"
        '
        'QuantizerBlurNumericUpDown
        '
        Me.QuantizerBlurNumericUpDown.DecimalPlaces = 1
        Me.QuantizerBlurNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.QuantizerBlurNumericUpDown.Location = New System.Drawing.Point(226, 80)
        Me.QuantizerBlurNumericUpDown.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.QuantizerBlurNumericUpDown.Name = "QuantizerBlurNumericUpDown"
        Me.QuantizerBlurNumericUpDown.Size = New System.Drawing.Size(77, 21)
        Me.QuantizerBlurNumericUpDown.TabIndex = 22
        Me.QuantizerBlurNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(15, 80)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(205, 21)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Quantizer Blur:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'QuantizerCompressionNumericUpDown
        '
        Me.QuantizerCompressionNumericUpDown.DecimalPlaces = 1
        Me.QuantizerCompressionNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.QuantizerCompressionNumericUpDown.Location = New System.Drawing.Point(226, 53)
        Me.QuantizerCompressionNumericUpDown.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.QuantizerCompressionNumericUpDown.Name = "QuantizerCompressionNumericUpDown"
        Me.QuantizerCompressionNumericUpDown.Size = New System.Drawing.Size(77, 21)
        Me.QuantizerCompressionNumericUpDown.TabIndex = 20
        Me.QuantizerCompressionNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(15, 53)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(205, 21)
        Me.Label25.TabIndex = 19
        Me.Label25.Text = "Quantizer Compression:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'QDeltaNumericUpDown
        '
        Me.QDeltaNumericUpDown.Location = New System.Drawing.Point(346, 26)
        Me.QDeltaNumericUpDown.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.QDeltaNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.QDeltaNumericUpDown.Name = "QDeltaNumericUpDown"
        Me.QDeltaNumericUpDown.Size = New System.Drawing.Size(54, 21)
        Me.QDeltaNumericUpDown.TabIndex = 18
        Me.QDeltaNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'QMaxNumericUpDown
        '
        Me.QMaxNumericUpDown.Location = New System.Drawing.Point(286, 26)
        Me.QMaxNumericUpDown.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.QMaxNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.QMaxNumericUpDown.Name = "QMaxNumericUpDown"
        Me.QMaxNumericUpDown.Size = New System.Drawing.Size(54, 21)
        Me.QMaxNumericUpDown.TabIndex = 5
        Me.QMaxNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'QMinNumericUpDown
        '
        Me.QMinNumericUpDown.Location = New System.Drawing.Point(226, 26)
        Me.QMinNumericUpDown.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.QMinNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.QMinNumericUpDown.Name = "QMinNumericUpDown"
        Me.QMinNumericUpDown.Size = New System.Drawing.Size(54, 21)
        Me.QMinNumericUpDown.TabIndex = 3
        Me.QMinNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(15, 26)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(205, 21)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Min/Max/Delta:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BPanel
        '
        Me.BPanel.Controls.Add(Me.OKBTN)
        Me.BPanel.Controls.Add(Me.CancelBTN)
        Me.BPanel.Controls.Add(Me.DefBTN)
        Me.BPanel.Controls.Add(Me.SettingTabControl)
        Me.BPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BPanel.Location = New System.Drawing.Point(0, 0)
        Me.BPanel.Name = "BPanel"
        Me.BPanel.Size = New System.Drawing.Size(488, 439)
        Me.BPanel.TabIndex = 1
        '
        'OKBTN
        '
        Me.OKBTN.Location = New System.Drawing.Point(264, 401)
        Me.OKBTN.Name = "OKBTN"
        Me.OKBTN.Size = New System.Drawing.Size(100, 25)
        Me.OKBTN.TabIndex = 5
        Me.OKBTN.Text = "확인"
        Me.OKBTN.UseVisualStyleBackColor = True
        '
        'CancelBTN
        '
        Me.CancelBTN.Location = New System.Drawing.Point(370, 401)
        Me.CancelBTN.Name = "CancelBTN"
        Me.CancelBTN.Size = New System.Drawing.Size(100, 25)
        Me.CancelBTN.TabIndex = 4
        Me.CancelBTN.Text = "취소"
        Me.CancelBTN.UseVisualStyleBackColor = True
        '
        'DefBTN
        '
        Me.DefBTN.Location = New System.Drawing.Point(10, 401)
        Me.DefBTN.Name = "DefBTN"
        Me.DefBTN.Size = New System.Drawing.Size(100, 25)
        Me.DefBTN.TabIndex = 2
        Me.DefBTN.Text = "기본값"
        Me.DefBTN.UseVisualStyleBackColor = True
        '
        'MPEG4optsFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 439)
        Me.Controls.Add(Me.BPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MPEG4optsFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "MPEG4 configuration"
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
