<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImagePPFrm
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
        Me.AviSynthImageControlGroupBox = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.ColorYUVASCheckBox = New System.Windows.Forms.CheckBox
        Me.SharpenTrackBar = New System.Windows.Forms.TrackBar
        Me.ColorYUVTVPCRadioButton = New System.Windows.Forms.RadioButton
        Me.SharpenNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.ColorYUVPCTVRadioButton = New System.Windows.Forms.RadioButton
        Me.ColorYUVNRadioButton = New System.Windows.Forms.RadioButton
        Me.hueNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.SharpenButton = New System.Windows.Forms.Button
        Me.hueTrackBar = New System.Windows.Forms.TrackBar
        Me.hueButton = New System.Windows.Forms.Button
        Me.saturationNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.saturationTrackBar = New System.Windows.Forms.TrackBar
        Me.saturationButton = New System.Windows.Forms.Button
        Me.contrastNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.contrastTrackBar = New System.Windows.Forms.TrackBar
        Me.contrastButton = New System.Windows.Forms.Button
        Me.brightnessNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.brightnessTrackBar = New System.Windows.Forms.TrackBar
        Me.brightnessButton = New System.Windows.Forms.Button
        Me.AviSynthResizeFilterComboBox = New System.Windows.Forms.ComboBox
        Me.AviSynthImageGroupBox = New System.Windows.Forms.GroupBox
        Me.AviSynthAspectSLabel = New System.Windows.Forms.Label
        Me.AviSynthAspectHTextBox = New System.Windows.Forms.TextBox
        Me.AviSynthAspectWTextBox = New System.Windows.Forms.TextBox
        Me.AviSynthAspectComboBox2 = New System.Windows.Forms.ComboBox
        Me.AviSynthAspectComboBox = New System.Windows.Forms.ComboBox
        Me.AviSynthAspectLabel = New System.Windows.Forms.Label
        Me.AviSynthResizeFilterLabel = New System.Windows.Forms.Label
        Me.AviSynthImageSizeCheckBox = New System.Windows.Forms.CheckBox
        Me.AviSynthImageSizeSLabel = New System.Windows.Forms.Label
        Me.AviSynthImageSizeHeightTextBox = New System.Windows.Forms.TextBox
        Me.AviSynthImageSizeWidthTextBox = New System.Windows.Forms.TextBox
        Me.AviSynthImageSizeComboBox = New System.Windows.Forms.ComboBox
        Me.AviSynthImageSizeLabel = New System.Windows.Forms.Label
        Me.DefBTN = New System.Windows.Forms.Button
        Me.OKBTN = New System.Windows.Forms.Button
        Me.CancelBTN = New System.Windows.Forms.Button
        Me.IPP_Panel = New System.Windows.Forms.Panel
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.AviSynthDeinterlaceComboBox = New System.Windows.Forms.ComboBox
        Me.AviSynthDeinterlaceCheckBox = New System.Windows.Forms.CheckBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.FieldorderLabel = New System.Windows.Forms.Label
        Me.FieldorderComboBox = New System.Windows.Forms.ComboBox
        Me.AVSMPEG2DeinterlaceComboBox = New System.Windows.Forms.ComboBox
        Me.AVSMPEG2DeinterlaceCheckBox = New System.Windows.Forms.CheckBox
        Me.AviSynthFramerateGroupBox = New System.Windows.Forms.GroupBox
        Me.AviSynthFramerateCheckBox = New System.Windows.Forms.CheckBox
        Me.AviSynthFramerateLabel = New System.Windows.Forms.Label
        Me.AviSynthFramerateComboBox = New System.Windows.Forms.ComboBox
        Me.AviSynthImageControlGroupBox.SuspendLayout()
        CType(Me.SharpenTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SharpenNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hueNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hueTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.saturationNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.saturationTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.contrastNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.contrastTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.brightnessNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.brightnessTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AviSynthImageGroupBox.SuspendLayout()
        Me.IPP_Panel.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.AviSynthFramerateGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'AviSynthImageControlGroupBox
        '
        Me.AviSynthImageControlGroupBox.Controls.Add(Me.Label7)
        Me.AviSynthImageControlGroupBox.Controls.Add(Me.ColorYUVASCheckBox)
        Me.AviSynthImageControlGroupBox.Controls.Add(Me.SharpenTrackBar)
        Me.AviSynthImageControlGroupBox.Controls.Add(Me.ColorYUVTVPCRadioButton)
        Me.AviSynthImageControlGroupBox.Controls.Add(Me.SharpenNumericUpDown)
        Me.AviSynthImageControlGroupBox.Controls.Add(Me.ColorYUVPCTVRadioButton)
        Me.AviSynthImageControlGroupBox.Controls.Add(Me.ColorYUVNRadioButton)
        Me.AviSynthImageControlGroupBox.Controls.Add(Me.hueNumericUpDown)
        Me.AviSynthImageControlGroupBox.Controls.Add(Me.SharpenButton)
        Me.AviSynthImageControlGroupBox.Controls.Add(Me.hueTrackBar)
        Me.AviSynthImageControlGroupBox.Controls.Add(Me.hueButton)
        Me.AviSynthImageControlGroupBox.Controls.Add(Me.saturationNumericUpDown)
        Me.AviSynthImageControlGroupBox.Controls.Add(Me.saturationTrackBar)
        Me.AviSynthImageControlGroupBox.Controls.Add(Me.saturationButton)
        Me.AviSynthImageControlGroupBox.Controls.Add(Me.contrastNumericUpDown)
        Me.AviSynthImageControlGroupBox.Controls.Add(Me.contrastTrackBar)
        Me.AviSynthImageControlGroupBox.Controls.Add(Me.contrastButton)
        Me.AviSynthImageControlGroupBox.Controls.Add(Me.brightnessNumericUpDown)
        Me.AviSynthImageControlGroupBox.Controls.Add(Me.brightnessTrackBar)
        Me.AviSynthImageControlGroupBox.Controls.Add(Me.brightnessButton)
        Me.AviSynthImageControlGroupBox.Location = New System.Drawing.Point(12, 216)
        Me.AviSynthImageControlGroupBox.Name = "AviSynthImageControlGroupBox"
        Me.AviSynthImageControlGroupBox.Size = New System.Drawing.Size(480, 230)
        Me.AviSynthImageControlGroupBox.TabIndex = 3
        Me.AviSynthImageControlGroupBox.TabStop = False
        Me.AviSynthImageControlGroupBox.Text = "영상 조절"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 177)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 12)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "ColorYUV:"
        '
        'ColorYUVASCheckBox
        '
        Me.ColorYUVASCheckBox.AutoSize = True
        Me.ColorYUVASCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ColorYUVASCheckBox.Location = New System.Drawing.Point(148, 202)
        Me.ColorYUVASCheckBox.Name = "ColorYUVASCheckBox"
        Me.ColorYUVASCheckBox.Size = New System.Drawing.Size(124, 16)
        Me.ColorYUVASCheckBox.TabIndex = 20
        Me.ColorYUVASCheckBox.Text = "영상분석창 보이기"
        Me.ColorYUVASCheckBox.UseVisualStyleBackColor = True
        '
        'SharpenTrackBar
        '
        Me.SharpenTrackBar.AutoSize = False
        Me.SharpenTrackBar.Location = New System.Drawing.Point(140, 139)
        Me.SharpenTrackBar.Maximum = 100
        Me.SharpenTrackBar.Name = "SharpenTrackBar"
        Me.SharpenTrackBar.Size = New System.Drawing.Size(241, 23)
        Me.SharpenTrackBar.TabIndex = 1
        Me.SharpenTrackBar.TickFrequency = 0
        Me.SharpenTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'ColorYUVTVPCRadioButton
        '
        Me.ColorYUVTVPCRadioButton.AutoSize = True
        Me.ColorYUVTVPCRadioButton.Location = New System.Drawing.Point(148, 174)
        Me.ColorYUVTVPCRadioButton.Name = "ColorYUVTVPCRadioButton"
        Me.ColorYUVTVPCRadioButton.Size = New System.Drawing.Size(70, 16)
        Me.ColorYUVTVPCRadioButton.TabIndex = 15
        Me.ColorYUVTVPCRadioButton.TabStop = True
        Me.ColorYUVTVPCRadioButton.Text = "TV->PC"
        Me.ColorYUVTVPCRadioButton.UseVisualStyleBackColor = True
        '
        'SharpenNumericUpDown
        '
        Me.SharpenNumericUpDown.DecimalPlaces = 2
        Me.SharpenNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.SharpenNumericUpDown.Location = New System.Drawing.Point(387, 141)
        Me.SharpenNumericUpDown.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SharpenNumericUpDown.Name = "SharpenNumericUpDown"
        Me.SharpenNumericUpDown.Size = New System.Drawing.Size(71, 21)
        Me.SharpenNumericUpDown.TabIndex = 2
        '
        'ColorYUVPCTVRadioButton
        '
        Me.ColorYUVPCTVRadioButton.AutoSize = True
        Me.ColorYUVPCTVRadioButton.Location = New System.Drawing.Point(242, 174)
        Me.ColorYUVPCTVRadioButton.Name = "ColorYUVPCTVRadioButton"
        Me.ColorYUVPCTVRadioButton.Size = New System.Drawing.Size(70, 16)
        Me.ColorYUVPCTVRadioButton.TabIndex = 16
        Me.ColorYUVPCTVRadioButton.TabStop = True
        Me.ColorYUVPCTVRadioButton.Text = "PC->TV"
        Me.ColorYUVPCTVRadioButton.UseVisualStyleBackColor = True
        '
        'ColorYUVNRadioButton
        '
        Me.ColorYUVNRadioButton.AutoSize = True
        Me.ColorYUVNRadioButton.Location = New System.Drawing.Point(330, 174)
        Me.ColorYUVNRadioButton.Name = "ColorYUVNRadioButton"
        Me.ColorYUVNRadioButton.Size = New System.Drawing.Size(99, 16)
        Me.ColorYUVNRadioButton.TabIndex = 17
        Me.ColorYUVNRadioButton.TabStop = True
        Me.ColorYUVNRadioButton.Text = "사용하지 않음"
        Me.ColorYUVNRadioButton.UseVisualStyleBackColor = True
        '
        'hueNumericUpDown
        '
        Me.hueNumericUpDown.DecimalPlaces = 1
        Me.hueNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.hueNumericUpDown.Location = New System.Drawing.Point(387, 111)
        Me.hueNumericUpDown.Maximum = New Decimal(New Integer() {180, 0, 0, 0})
        Me.hueNumericUpDown.Minimum = New Decimal(New Integer() {180, 0, 0, -2147483648})
        Me.hueNumericUpDown.Name = "hueNumericUpDown"
        Me.hueNumericUpDown.Size = New System.Drawing.Size(71, 21)
        Me.hueNumericUpDown.TabIndex = 14
        '
        'SharpenButton
        '
        Me.SharpenButton.Location = New System.Drawing.Point(19, 139)
        Me.SharpenButton.Name = "SharpenButton"
        Me.SharpenButton.Size = New System.Drawing.Size(115, 23)
        Me.SharpenButton.TabIndex = 0
        Me.SharpenButton.Text = "샤픈"
        Me.SharpenButton.UseVisualStyleBackColor = True
        '
        'hueTrackBar
        '
        Me.hueTrackBar.AutoSize = False
        Me.hueTrackBar.Location = New System.Drawing.Point(140, 109)
        Me.hueTrackBar.Maximum = 180
        Me.hueTrackBar.Minimum = -180
        Me.hueTrackBar.Name = "hueTrackBar"
        Me.hueTrackBar.Size = New System.Drawing.Size(241, 23)
        Me.hueTrackBar.TabIndex = 13
        Me.hueTrackBar.TickFrequency = 0
        Me.hueTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'hueButton
        '
        Me.hueButton.Location = New System.Drawing.Point(19, 109)
        Me.hueButton.Name = "hueButton"
        Me.hueButton.Size = New System.Drawing.Size(115, 23)
        Me.hueButton.TabIndex = 12
        Me.hueButton.Text = "색상"
        Me.hueButton.UseVisualStyleBackColor = True
        '
        'saturationNumericUpDown
        '
        Me.saturationNumericUpDown.DecimalPlaces = 2
        Me.saturationNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.saturationNumericUpDown.Location = New System.Drawing.Point(387, 82)
        Me.saturationNumericUpDown.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.saturationNumericUpDown.Name = "saturationNumericUpDown"
        Me.saturationNumericUpDown.Size = New System.Drawing.Size(71, 21)
        Me.saturationNumericUpDown.TabIndex = 11
        '
        'saturationTrackBar
        '
        Me.saturationTrackBar.AutoSize = False
        Me.saturationTrackBar.Location = New System.Drawing.Point(140, 81)
        Me.saturationTrackBar.Maximum = 300
        Me.saturationTrackBar.Name = "saturationTrackBar"
        Me.saturationTrackBar.Size = New System.Drawing.Size(241, 23)
        Me.saturationTrackBar.TabIndex = 10
        Me.saturationTrackBar.TickFrequency = 0
        Me.saturationTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'saturationButton
        '
        Me.saturationButton.Location = New System.Drawing.Point(19, 80)
        Me.saturationButton.Name = "saturationButton"
        Me.saturationButton.Size = New System.Drawing.Size(115, 23)
        Me.saturationButton.TabIndex = 9
        Me.saturationButton.Text = "채도"
        Me.saturationButton.UseVisualStyleBackColor = True
        '
        'contrastNumericUpDown
        '
        Me.contrastNumericUpDown.DecimalPlaces = 2
        Me.contrastNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.contrastNumericUpDown.Location = New System.Drawing.Point(387, 53)
        Me.contrastNumericUpDown.Maximum = New Decimal(New Integer() {300, 0, 0, 131072})
        Me.contrastNumericUpDown.Name = "contrastNumericUpDown"
        Me.contrastNumericUpDown.Size = New System.Drawing.Size(71, 21)
        Me.contrastNumericUpDown.TabIndex = 8
        '
        'contrastTrackBar
        '
        Me.contrastTrackBar.AutoSize = False
        Me.contrastTrackBar.Location = New System.Drawing.Point(140, 52)
        Me.contrastTrackBar.Maximum = 300
        Me.contrastTrackBar.Name = "contrastTrackBar"
        Me.contrastTrackBar.Size = New System.Drawing.Size(241, 23)
        Me.contrastTrackBar.TabIndex = 7
        Me.contrastTrackBar.TickFrequency = 0
        Me.contrastTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'contrastButton
        '
        Me.contrastButton.Location = New System.Drawing.Point(19, 51)
        Me.contrastButton.Name = "contrastButton"
        Me.contrastButton.Size = New System.Drawing.Size(115, 23)
        Me.contrastButton.TabIndex = 6
        Me.contrastButton.Text = "대비"
        Me.contrastButton.UseVisualStyleBackColor = True
        '
        'brightnessNumericUpDown
        '
        Me.brightnessNumericUpDown.Location = New System.Drawing.Point(387, 24)
        Me.brightnessNumericUpDown.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.brightnessNumericUpDown.Minimum = New Decimal(New Integer() {255, 0, 0, -2147483648})
        Me.brightnessNumericUpDown.Name = "brightnessNumericUpDown"
        Me.brightnessNumericUpDown.Size = New System.Drawing.Size(71, 21)
        Me.brightnessNumericUpDown.TabIndex = 5
        '
        'brightnessTrackBar
        '
        Me.brightnessTrackBar.AutoSize = False
        Me.brightnessTrackBar.Location = New System.Drawing.Point(140, 22)
        Me.brightnessTrackBar.Maximum = 255
        Me.brightnessTrackBar.Minimum = -255
        Me.brightnessTrackBar.Name = "brightnessTrackBar"
        Me.brightnessTrackBar.Size = New System.Drawing.Size(241, 23)
        Me.brightnessTrackBar.TabIndex = 4
        Me.brightnessTrackBar.TickFrequency = 0
        Me.brightnessTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'brightnessButton
        '
        Me.brightnessButton.Location = New System.Drawing.Point(19, 22)
        Me.brightnessButton.Name = "brightnessButton"
        Me.brightnessButton.Size = New System.Drawing.Size(115, 23)
        Me.brightnessButton.TabIndex = 3
        Me.brightnessButton.Text = "명도"
        Me.brightnessButton.UseVisualStyleBackColor = True
        '
        'AviSynthResizeFilterComboBox
        '
        Me.AviSynthResizeFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AviSynthResizeFilterComboBox.FormattingEnabled = True
        Me.AviSynthResizeFilterComboBox.Location = New System.Drawing.Point(124, 78)
        Me.AviSynthResizeFilterComboBox.Name = "AviSynthResizeFilterComboBox"
        Me.AviSynthResizeFilterComboBox.Size = New System.Drawing.Size(330, 20)
        Me.AviSynthResizeFilterComboBox.TabIndex = 11
        '
        'AviSynthImageGroupBox
        '
        Me.AviSynthImageGroupBox.Controls.Add(Me.AviSynthAspectSLabel)
        Me.AviSynthImageGroupBox.Controls.Add(Me.AviSynthResizeFilterComboBox)
        Me.AviSynthImageGroupBox.Controls.Add(Me.AviSynthAspectHTextBox)
        Me.AviSynthImageGroupBox.Controls.Add(Me.AviSynthAspectWTextBox)
        Me.AviSynthImageGroupBox.Controls.Add(Me.AviSynthAspectComboBox2)
        Me.AviSynthImageGroupBox.Controls.Add(Me.AviSynthAspectComboBox)
        Me.AviSynthImageGroupBox.Controls.Add(Me.AviSynthAspectLabel)
        Me.AviSynthImageGroupBox.Controls.Add(Me.AviSynthResizeFilterLabel)
        Me.AviSynthImageGroupBox.Controls.Add(Me.AviSynthImageSizeCheckBox)
        Me.AviSynthImageGroupBox.Controls.Add(Me.AviSynthImageSizeSLabel)
        Me.AviSynthImageGroupBox.Controls.Add(Me.AviSynthImageSizeHeightTextBox)
        Me.AviSynthImageGroupBox.Controls.Add(Me.AviSynthImageSizeWidthTextBox)
        Me.AviSynthImageGroupBox.Controls.Add(Me.AviSynthImageSizeComboBox)
        Me.AviSynthImageGroupBox.Controls.Add(Me.AviSynthImageSizeLabel)
        Me.AviSynthImageGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.AviSynthImageGroupBox.Name = "AviSynthImageGroupBox"
        Me.AviSynthImageGroupBox.Size = New System.Drawing.Size(480, 198)
        Me.AviSynthImageGroupBox.TabIndex = 34
        Me.AviSynthImageGroupBox.TabStop = False
        Me.AviSynthImageGroupBox.Text = "영상"
        '
        'AviSynthAspectSLabel
        '
        Me.AviSynthAspectSLabel.AutoSize = True
        Me.AviSynthAspectSLabel.Enabled = False
        Me.AviSynthAspectSLabel.Location = New System.Drawing.Point(199, 167)
        Me.AviSynthAspectSLabel.Name = "AviSynthAspectSLabel"
        Me.AviSynthAspectSLabel.Size = New System.Drawing.Size(9, 12)
        Me.AviSynthAspectSLabel.TabIndex = 17
        Me.AviSynthAspectSLabel.Text = ":"
        Me.AviSynthAspectSLabel.Visible = False
        '
        'AviSynthAspectHTextBox
        '
        Me.AviSynthAspectHTextBox.Enabled = False
        Me.AviSynthAspectHTextBox.Location = New System.Drawing.Point(216, 162)
        Me.AviSynthAspectHTextBox.Name = "AviSynthAspectHTextBox"
        Me.AviSynthAspectHTextBox.Size = New System.Drawing.Size(68, 21)
        Me.AviSynthAspectHTextBox.TabIndex = 16
        Me.AviSynthAspectHTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.AviSynthAspectHTextBox.Visible = False
        '
        'AviSynthAspectWTextBox
        '
        Me.AviSynthAspectWTextBox.Enabled = False
        Me.AviSynthAspectWTextBox.Location = New System.Drawing.Point(124, 162)
        Me.AviSynthAspectWTextBox.Name = "AviSynthAspectWTextBox"
        Me.AviSynthAspectWTextBox.Size = New System.Drawing.Size(68, 21)
        Me.AviSynthAspectWTextBox.TabIndex = 15
        Me.AviSynthAspectWTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.AviSynthAspectWTextBox.Visible = False
        '
        'AviSynthAspectComboBox2
        '
        Me.AviSynthAspectComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AviSynthAspectComboBox2.FormattingEnabled = True
        Me.AviSynthAspectComboBox2.Location = New System.Drawing.Point(124, 136)
        Me.AviSynthAspectComboBox2.Name = "AviSynthAspectComboBox2"
        Me.AviSynthAspectComboBox2.Size = New System.Drawing.Size(330, 20)
        Me.AviSynthAspectComboBox2.TabIndex = 14
        Me.AviSynthAspectComboBox2.Visible = False
        '
        'AviSynthAspectComboBox
        '
        Me.AviSynthAspectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AviSynthAspectComboBox.FormattingEnabled = True
        Me.AviSynthAspectComboBox.Location = New System.Drawing.Point(124, 110)
        Me.AviSynthAspectComboBox.Name = "AviSynthAspectComboBox"
        Me.AviSynthAspectComboBox.Size = New System.Drawing.Size(330, 20)
        Me.AviSynthAspectComboBox.TabIndex = 13
        '
        'AviSynthAspectLabel
        '
        Me.AviSynthAspectLabel.Location = New System.Drawing.Point(12, 113)
        Me.AviSynthAspectLabel.Name = "AviSynthAspectLabel"
        Me.AviSynthAspectLabel.Size = New System.Drawing.Size(105, 27)
        Me.AviSynthAspectLabel.TabIndex = 12
        Me.AviSynthAspectLabel.Text = "비율:"
        Me.AviSynthAspectLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'AviSynthResizeFilterLabel
        '
        Me.AviSynthResizeFilterLabel.Location = New System.Drawing.Point(14, 84)
        Me.AviSynthResizeFilterLabel.Name = "AviSynthResizeFilterLabel"
        Me.AviSynthResizeFilterLabel.Size = New System.Drawing.Size(103, 18)
        Me.AviSynthResizeFilterLabel.TabIndex = 10
        Me.AviSynthResizeFilterLabel.Text = "리사이즈 필터:"
        Me.AviSynthResizeFilterLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'AviSynthImageSizeCheckBox
        '
        Me.AviSynthImageSizeCheckBox.AutoSize = True
        Me.AviSynthImageSizeCheckBox.Location = New System.Drawing.Point(308, 54)
        Me.AviSynthImageSizeCheckBox.Name = "AviSynthImageSizeCheckBox"
        Me.AviSynthImageSizeCheckBox.Size = New System.Drawing.Size(100, 16)
        Me.AviSynthImageSizeCheckBox.TabIndex = 6
        Me.AviSynthImageSizeCheckBox.Text = "원본 영상크기"
        Me.AviSynthImageSizeCheckBox.UseVisualStyleBackColor = True
        '
        'AviSynthImageSizeSLabel
        '
        Me.AviSynthImageSizeSLabel.AutoSize = True
        Me.AviSynthImageSizeSLabel.Enabled = False
        Me.AviSynthImageSizeSLabel.Location = New System.Drawing.Point(198, 56)
        Me.AviSynthImageSizeSLabel.Name = "AviSynthImageSizeSLabel"
        Me.AviSynthImageSizeSLabel.Size = New System.Drawing.Size(13, 12)
        Me.AviSynthImageSizeSLabel.TabIndex = 5
        Me.AviSynthImageSizeSLabel.Text = "X"
        '
        'AviSynthImageSizeHeightTextBox
        '
        Me.AviSynthImageSizeHeightTextBox.Enabled = False
        Me.AviSynthImageSizeHeightTextBox.Location = New System.Drawing.Point(217, 51)
        Me.AviSynthImageSizeHeightTextBox.Name = "AviSynthImageSizeHeightTextBox"
        Me.AviSynthImageSizeHeightTextBox.Size = New System.Drawing.Size(68, 21)
        Me.AviSynthImageSizeHeightTextBox.TabIndex = 4
        Me.AviSynthImageSizeHeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AviSynthImageSizeWidthTextBox
        '
        Me.AviSynthImageSizeWidthTextBox.Enabled = False
        Me.AviSynthImageSizeWidthTextBox.Location = New System.Drawing.Point(124, 51)
        Me.AviSynthImageSizeWidthTextBox.Name = "AviSynthImageSizeWidthTextBox"
        Me.AviSynthImageSizeWidthTextBox.Size = New System.Drawing.Size(68, 21)
        Me.AviSynthImageSizeWidthTextBox.TabIndex = 3
        Me.AviSynthImageSizeWidthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AviSynthImageSizeComboBox
        '
        Me.AviSynthImageSizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AviSynthImageSizeComboBox.FormattingEnabled = True
        Me.AviSynthImageSizeComboBox.Location = New System.Drawing.Point(124, 20)
        Me.AviSynthImageSizeComboBox.Name = "AviSynthImageSizeComboBox"
        Me.AviSynthImageSizeComboBox.Size = New System.Drawing.Size(330, 20)
        Me.AviSynthImageSizeComboBox.TabIndex = 2
        '
        'AviSynthImageSizeLabel
        '
        Me.AviSynthImageSizeLabel.Location = New System.Drawing.Point(14, 25)
        Me.AviSynthImageSizeLabel.Name = "AviSynthImageSizeLabel"
        Me.AviSynthImageSizeLabel.Size = New System.Drawing.Size(105, 42)
        Me.AviSynthImageSizeLabel.TabIndex = 1
        Me.AviSynthImageSizeLabel.Text = "영상크기:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(픽셀)"
        Me.AviSynthImageSizeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DefBTN
        '
        Me.DefBTN.Location = New System.Drawing.Point(502, 422)
        Me.DefBTN.Name = "DefBTN"
        Me.DefBTN.Size = New System.Drawing.Size(90, 25)
        Me.DefBTN.TabIndex = 35
        Me.DefBTN.Text = "기본값"
        Me.DefBTN.UseVisualStyleBackColor = True
        '
        'OKBTN
        '
        Me.OKBTN.Location = New System.Drawing.Point(746, 421)
        Me.OKBTN.Name = "OKBTN"
        Me.OKBTN.Size = New System.Drawing.Size(90, 25)
        Me.OKBTN.TabIndex = 37
        Me.OKBTN.Text = "확인"
        Me.OKBTN.UseVisualStyleBackColor = True
        '
        'CancelBTN
        '
        Me.CancelBTN.Location = New System.Drawing.Point(846, 421)
        Me.CancelBTN.Name = "CancelBTN"
        Me.CancelBTN.Size = New System.Drawing.Size(90, 25)
        Me.CancelBTN.TabIndex = 36
        Me.CancelBTN.Text = "취소"
        Me.CancelBTN.UseVisualStyleBackColor = True
        '
        'IPP_Panel
        '
        Me.IPP_Panel.Controls.Add(Me.TabControl1)
        Me.IPP_Panel.Controls.Add(Me.AviSynthFramerateGroupBox)
        Me.IPP_Panel.Controls.Add(Me.AviSynthImageGroupBox)
        Me.IPP_Panel.Controls.Add(Me.DefBTN)
        Me.IPP_Panel.Controls.Add(Me.AviSynthImageControlGroupBox)
        Me.IPP_Panel.Controls.Add(Me.OKBTN)
        Me.IPP_Panel.Controls.Add(Me.CancelBTN)
        Me.IPP_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IPP_Panel.Location = New System.Drawing.Point(0, 0)
        Me.IPP_Panel.Name = "IPP_Panel"
        Me.IPP_Panel.Size = New System.Drawing.Size(952, 464)
        Me.IPP_Panel.TabIndex = 38
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(502, 80)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(438, 170)
        Me.TabControl1.TabIndex = 40
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.AviSynthDeinterlaceComboBox)
        Me.TabPage1.Controls.Add(Me.AviSynthDeinterlaceCheckBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(430, 144)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "FFmpegSource(MPEG/MPEGTS AVC, VC1)"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'AviSynthDeinterlaceComboBox
        '
        Me.AviSynthDeinterlaceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AviSynthDeinterlaceComboBox.Enabled = False
        Me.AviSynthDeinterlaceComboBox.FormattingEnabled = True
        Me.AviSynthDeinterlaceComboBox.Items.AddRange(New Object() {"linear blend deinterlacer (lb)", "linear interpolating deinterlace (li)", "cubic interpolating deinterlacer (ci)", "median deinterlacer (md)", "ffmpeg deinterlacer (fd)", "FIR lowpass deinterlacer (l5)"})
        Me.AviSynthDeinterlaceComboBox.Location = New System.Drawing.Point(36, 42)
        Me.AviSynthDeinterlaceComboBox.Name = "AviSynthDeinterlaceComboBox"
        Me.AviSynthDeinterlaceComboBox.Size = New System.Drawing.Size(350, 20)
        Me.AviSynthDeinterlaceComboBox.TabIndex = 33
        '
        'AviSynthDeinterlaceCheckBox
        '
        Me.AviSynthDeinterlaceCheckBox.AutoSize = True
        Me.AviSynthDeinterlaceCheckBox.Location = New System.Drawing.Point(18, 20)
        Me.AviSynthDeinterlaceCheckBox.Name = "AviSynthDeinterlaceCheckBox"
        Me.AviSynthDeinterlaceCheckBox.Size = New System.Drawing.Size(96, 16)
        Me.AviSynthDeinterlaceCheckBox.TabIndex = 34
        Me.AviSynthDeinterlaceCheckBox.Text = "디인터레이스"
        Me.AviSynthDeinterlaceCheckBox.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.FieldorderLabel)
        Me.TabPage2.Controls.Add(Me.FieldorderComboBox)
        Me.TabPage2.Controls.Add(Me.AVSMPEG2DeinterlaceComboBox)
        Me.TabPage2.Controls.Add(Me.AVSMPEG2DeinterlaceCheckBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(430, 144)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "MPEG2Source"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'FieldorderLabel
        '
        Me.FieldorderLabel.AutoSize = True
        Me.FieldorderLabel.Location = New System.Drawing.Point(32, 74)
        Me.FieldorderLabel.Name = "FieldorderLabel"
        Me.FieldorderLabel.Size = New System.Drawing.Size(69, 12)
        Me.FieldorderLabel.TabIndex = 38
        Me.FieldorderLabel.Text = "Field order:"
        '
        'FieldorderComboBox
        '
        Me.FieldorderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FieldorderComboBox.FormattingEnabled = True
        Me.FieldorderComboBox.Items.AddRange(New Object() {"Top Field First", "Bottom Field First", "Varying field order"})
        Me.FieldorderComboBox.Location = New System.Drawing.Point(36, 94)
        Me.FieldorderComboBox.Name = "FieldorderComboBox"
        Me.FieldorderComboBox.Size = New System.Drawing.Size(350, 20)
        Me.FieldorderComboBox.TabIndex = 37
        '
        'AVSMPEG2DeinterlaceComboBox
        '
        Me.AVSMPEG2DeinterlaceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AVSMPEG2DeinterlaceComboBox.Enabled = False
        Me.AVSMPEG2DeinterlaceComboBox.FormattingEnabled = True
        Me.AVSMPEG2DeinterlaceComboBox.Items.AddRange(New Object() {"Yadif mode=0", "Yadif mode=1 double framerate (bob)", "Yadif mode=2", "Yadif mode=3 double framerate (bob)"})
        Me.AVSMPEG2DeinterlaceComboBox.Location = New System.Drawing.Point(36, 42)
        Me.AVSMPEG2DeinterlaceComboBox.Name = "AVSMPEG2DeinterlaceComboBox"
        Me.AVSMPEG2DeinterlaceComboBox.Size = New System.Drawing.Size(350, 20)
        Me.AVSMPEG2DeinterlaceComboBox.TabIndex = 35
        '
        'AVSMPEG2DeinterlaceCheckBox
        '
        Me.AVSMPEG2DeinterlaceCheckBox.AutoSize = True
        Me.AVSMPEG2DeinterlaceCheckBox.Location = New System.Drawing.Point(18, 20)
        Me.AVSMPEG2DeinterlaceCheckBox.Name = "AVSMPEG2DeinterlaceCheckBox"
        Me.AVSMPEG2DeinterlaceCheckBox.Size = New System.Drawing.Size(96, 16)
        Me.AVSMPEG2DeinterlaceCheckBox.TabIndex = 36
        Me.AVSMPEG2DeinterlaceCheckBox.Text = "디인터레이스"
        Me.AVSMPEG2DeinterlaceCheckBox.UseVisualStyleBackColor = True
        '
        'AviSynthFramerateGroupBox
        '
        Me.AviSynthFramerateGroupBox.Controls.Add(Me.AviSynthFramerateCheckBox)
        Me.AviSynthFramerateGroupBox.Controls.Add(Me.AviSynthFramerateLabel)
        Me.AviSynthFramerateGroupBox.Controls.Add(Me.AviSynthFramerateComboBox)
        Me.AviSynthFramerateGroupBox.Location = New System.Drawing.Point(502, 12)
        Me.AviSynthFramerateGroupBox.Name = "AviSynthFramerateGroupBox"
        Me.AviSynthFramerateGroupBox.Size = New System.Drawing.Size(434, 57)
        Me.AviSynthFramerateGroupBox.TabIndex = 35
        Me.AviSynthFramerateGroupBox.TabStop = False
        Me.AviSynthFramerateGroupBox.Text = "프레임레이트"
        '
        'AviSynthFramerateCheckBox
        '
        Me.AviSynthFramerateCheckBox.AutoSize = True
        Me.AviSynthFramerateCheckBox.Location = New System.Drawing.Point(254, 25)
        Me.AviSynthFramerateCheckBox.Name = "AviSynthFramerateCheckBox"
        Me.AviSynthFramerateCheckBox.Size = New System.Drawing.Size(124, 16)
        Me.AviSynthFramerateCheckBox.TabIndex = 21
        Me.AviSynthFramerateCheckBox.Text = "원본 프레임레이트"
        Me.AviSynthFramerateCheckBox.UseVisualStyleBackColor = True
        '
        'AviSynthFramerateLabel
        '
        Me.AviSynthFramerateLabel.AutoSize = True
        Me.AviSynthFramerateLabel.Location = New System.Drawing.Point(164, 27)
        Me.AviSynthFramerateLabel.Name = "AviSynthFramerateLabel"
        Me.AviSynthFramerateLabel.Size = New System.Drawing.Size(22, 12)
        Me.AviSynthFramerateLabel.TabIndex = 20
        Me.AviSynthFramerateLabel.Text = "fps"
        '
        'AviSynthFramerateComboBox
        '
        Me.AviSynthFramerateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AviSynthFramerateComboBox.FormattingEnabled = True
        Me.AviSynthFramerateComboBox.Items.AddRange(New Object() {"5", "6", "7", "8", "9", "10", "11", "12", "13", "14.985", "15", "16", "17", "18", "19", "20", "23.976", "24", "25", "29.97", "30", "59.94", "60"})
        Me.AviSynthFramerateComboBox.Location = New System.Drawing.Point(23, 22)
        Me.AviSynthFramerateComboBox.Name = "AviSynthFramerateComboBox"
        Me.AviSynthFramerateComboBox.Size = New System.Drawing.Size(128, 20)
        Me.AviSynthFramerateComboBox.TabIndex = 19
        '
        'ImagePPFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 464)
        Me.Controls.Add(Me.IPP_Panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ImagePPFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "영상 설정"
        Me.AviSynthImageControlGroupBox.ResumeLayout(False)
        Me.AviSynthImageControlGroupBox.PerformLayout()
        CType(Me.SharpenTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SharpenNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hueNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hueTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.saturationNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.saturationTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.contrastNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.contrastTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.brightnessNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.brightnessTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AviSynthImageGroupBox.ResumeLayout(False)
        Me.AviSynthImageGroupBox.PerformLayout()
        Me.IPP_Panel.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.AviSynthFramerateGroupBox.ResumeLayout(False)
        Me.AviSynthFramerateGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AviSynthImageControlGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ColorYUVASCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SharpenTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents ColorYUVTVPCRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents SharpenNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents ColorYUVPCTVRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ColorYUVNRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents hueNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents SharpenButton As System.Windows.Forms.Button
    Friend WithEvents hueTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents hueButton As System.Windows.Forms.Button
    Friend WithEvents saturationNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents saturationTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents saturationButton As System.Windows.Forms.Button
    Friend WithEvents contrastNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents contrastTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents contrastButton As System.Windows.Forms.Button
    Friend WithEvents brightnessNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents brightnessTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents brightnessButton As System.Windows.Forms.Button
    Friend WithEvents AviSynthResizeFilterComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AviSynthImageGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents AviSynthAspectSLabel As System.Windows.Forms.Label
    Friend WithEvents AviSynthAspectHTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AviSynthAspectWTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AviSynthAspectComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents AviSynthAspectComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AviSynthAspectLabel As System.Windows.Forms.Label
    Friend WithEvents AviSynthResizeFilterLabel As System.Windows.Forms.Label
    Friend WithEvents AviSynthImageSizeCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AviSynthImageSizeSLabel As System.Windows.Forms.Label
    Friend WithEvents AviSynthImageSizeHeightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AviSynthImageSizeWidthTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AviSynthImageSizeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AviSynthImageSizeLabel As System.Windows.Forms.Label
    Friend WithEvents DefBTN As System.Windows.Forms.Button
    Friend WithEvents OKBTN As System.Windows.Forms.Button
    Friend WithEvents CancelBTN As System.Windows.Forms.Button
    Friend WithEvents IPP_Panel As System.Windows.Forms.Panel
    Friend WithEvents AviSynthFramerateGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents AviSynthFramerateCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AviSynthFramerateLabel As System.Windows.Forms.Label
    Friend WithEvents AviSynthFramerateComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents AviSynthDeinterlaceComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AviSynthDeinterlaceCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AVSMPEG2DeinterlaceComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AVSMPEG2DeinterlaceCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents FieldorderLabel As System.Windows.Forms.Label
    Friend WithEvents FieldorderComboBox As System.Windows.Forms.ComboBox
End Class
