<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AudioPPFrm
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
        Me.components = New System.ComponentModel.Container
        Me.AmplifyGroupBox = New System.Windows.Forms.GroupBox
        Me.dBLabel = New System.Windows.Forms.Label
        Me.AmplifyCheckBox = New System.Windows.Forms.CheckBox
        Me.AmplifyTrackBar = New System.Windows.Forms.TrackBar
        Me.AmplifyNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.EQGroupBox = New System.Windows.Forms.GroupBox
        Me.EQCheckBox = New System.Windows.Forms.CheckBox
        Me.EQZeroButton = New System.Windows.Forms.Button
        Me.EQ18Label = New System.Windows.Forms.Label
        Me.EQ17Label = New System.Windows.Forms.Label
        Me.EQ16Label = New System.Windows.Forms.Label
        Me.EQ15Label = New System.Windows.Forms.Label
        Me.EQ14Label = New System.Windows.Forms.Label
        Me.EQ13Label = New System.Windows.Forms.Label
        Me.EQ12Label = New System.Windows.Forms.Label
        Me.EQ11Label = New System.Windows.Forms.Label
        Me.EQ10Label = New System.Windows.Forms.Label
        Me.EQ9Label = New System.Windows.Forms.Label
        Me.EQ8Label = New System.Windows.Forms.Label
        Me.EQ7Label = New System.Windows.Forms.Label
        Me.EQ6Label = New System.Windows.Forms.Label
        Me.EQ5Label = New System.Windows.Forms.Label
        Me.EQ4Label = New System.Windows.Forms.Label
        Me.EQ3Label = New System.Windows.Forms.Label
        Me.EQ2Label = New System.Windows.Forms.Label
        Me.EQ1Label = New System.Windows.Forms.Label
        Me.m20dbLabel = New System.Windows.Forms.Label
        Me.p20dBLabel = New System.Windows.Forms.Label
        Me.EQ18TrackBar = New System.Windows.Forms.TrackBar
        Me.EQ17TrackBar = New System.Windows.Forms.TrackBar
        Me.EQ16TrackBar = New System.Windows.Forms.TrackBar
        Me.EQ15TrackBar = New System.Windows.Forms.TrackBar
        Me.EQ14TrackBar = New System.Windows.Forms.TrackBar
        Me.EQ13TrackBar = New System.Windows.Forms.TrackBar
        Me.EQ12TrackBar = New System.Windows.Forms.TrackBar
        Me.EQ11TrackBar = New System.Windows.Forms.TrackBar
        Me.EQ10TrackBar = New System.Windows.Forms.TrackBar
        Me.EQ9TrackBar = New System.Windows.Forms.TrackBar
        Me.EQ8TrackBar = New System.Windows.Forms.TrackBar
        Me.EQ7TrackBar = New System.Windows.Forms.TrackBar
        Me.EQ6TrackBar = New System.Windows.Forms.TrackBar
        Me.EQ5TrackBar = New System.Windows.Forms.TrackBar
        Me.EQ4TrackBar = New System.Windows.Forms.TrackBar
        Me.EQ3TrackBar = New System.Windows.Forms.TrackBar
        Me.EQ2TrackBar = New System.Windows.Forms.TrackBar
        Me.EQ1TrackBar = New System.Windows.Forms.TrackBar
        Me.CancelBTN = New System.Windows.Forms.Button
        Me.OKBTN = New System.Windows.Forms.Button
        Me.DefBTN = New System.Windows.Forms.Button
        Me.EQToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.APP_Panel = New System.Windows.Forms.Panel
        Me.AviSynthChGroupBox = New System.Windows.Forms.GroupBox
        Me.AviSynthChComboBox = New System.Windows.Forms.ComboBox
        Me.AmplifyGroupBox.SuspendLayout()
        CType(Me.AmplifyTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmplifyNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EQGroupBox.SuspendLayout()
        CType(Me.EQ18TrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EQ17TrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EQ16TrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EQ15TrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EQ14TrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EQ13TrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EQ12TrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EQ11TrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EQ10TrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EQ9TrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EQ8TrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EQ7TrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EQ6TrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EQ5TrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EQ4TrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EQ3TrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EQ2TrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EQ1TrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.APP_Panel.SuspendLayout()
        Me.AviSynthChGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'AmplifyGroupBox
        '
        Me.AmplifyGroupBox.Controls.Add(Me.dBLabel)
        Me.AmplifyGroupBox.Controls.Add(Me.AmplifyCheckBox)
        Me.AmplifyGroupBox.Controls.Add(Me.AmplifyTrackBar)
        Me.AmplifyGroupBox.Controls.Add(Me.AmplifyNumericUpDown)
        Me.AmplifyGroupBox.Location = New System.Drawing.Point(13, 73)
        Me.AmplifyGroupBox.Name = "AmplifyGroupBox"
        Me.AmplifyGroupBox.Size = New System.Drawing.Size(354, 89)
        Me.AmplifyGroupBox.TabIndex = 1
        Me.AmplifyGroupBox.TabStop = False
        Me.AmplifyGroupBox.Text = "증폭"
        '
        'dBLabel
        '
        Me.dBLabel.AutoSize = True
        Me.dBLabel.Location = New System.Drawing.Point(303, 53)
        Me.dBLabel.Name = "dBLabel"
        Me.dBLabel.Size = New System.Drawing.Size(20, 12)
        Me.dBLabel.TabIndex = 30
        Me.dBLabel.Text = "dB"
        '
        'AmplifyCheckBox
        '
        Me.AmplifyCheckBox.AutoSize = True
        Me.AmplifyCheckBox.Location = New System.Drawing.Point(19, 25)
        Me.AmplifyCheckBox.Name = "AmplifyCheckBox"
        Me.AmplifyCheckBox.Size = New System.Drawing.Size(48, 16)
        Me.AmplifyCheckBox.TabIndex = 29
        Me.AmplifyCheckBox.Text = "사용"
        Me.AmplifyCheckBox.UseVisualStyleBackColor = True
        '
        'AmplifyTrackBar
        '
        Me.AmplifyTrackBar.AutoSize = False
        Me.AmplifyTrackBar.Enabled = False
        Me.AmplifyTrackBar.Location = New System.Drawing.Point(23, 48)
        Me.AmplifyTrackBar.Maximum = 1000
        Me.AmplifyTrackBar.Minimum = -1000
        Me.AmplifyTrackBar.Name = "AmplifyTrackBar"
        Me.AmplifyTrackBar.Size = New System.Drawing.Size(195, 23)
        Me.AmplifyTrackBar.TabIndex = 26
        Me.AmplifyTrackBar.TickFrequency = 0
        Me.AmplifyTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'AmplifyNumericUpDown
        '
        Me.AmplifyNumericUpDown.DecimalPlaces = 1
        Me.AmplifyNumericUpDown.Enabled = False
        Me.AmplifyNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.AmplifyNumericUpDown.Location = New System.Drawing.Point(225, 49)
        Me.AmplifyNumericUpDown.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.AmplifyNumericUpDown.Name = "AmplifyNumericUpDown"
        Me.AmplifyNumericUpDown.Size = New System.Drawing.Size(69, 21)
        Me.AmplifyNumericUpDown.TabIndex = 27
        '
        'EQGroupBox
        '
        Me.EQGroupBox.Controls.Add(Me.EQCheckBox)
        Me.EQGroupBox.Controls.Add(Me.EQZeroButton)
        Me.EQGroupBox.Controls.Add(Me.EQ18Label)
        Me.EQGroupBox.Controls.Add(Me.EQ17Label)
        Me.EQGroupBox.Controls.Add(Me.EQ16Label)
        Me.EQGroupBox.Controls.Add(Me.EQ15Label)
        Me.EQGroupBox.Controls.Add(Me.EQ14Label)
        Me.EQGroupBox.Controls.Add(Me.EQ13Label)
        Me.EQGroupBox.Controls.Add(Me.EQ12Label)
        Me.EQGroupBox.Controls.Add(Me.EQ11Label)
        Me.EQGroupBox.Controls.Add(Me.EQ10Label)
        Me.EQGroupBox.Controls.Add(Me.EQ9Label)
        Me.EQGroupBox.Controls.Add(Me.EQ8Label)
        Me.EQGroupBox.Controls.Add(Me.EQ7Label)
        Me.EQGroupBox.Controls.Add(Me.EQ6Label)
        Me.EQGroupBox.Controls.Add(Me.EQ5Label)
        Me.EQGroupBox.Controls.Add(Me.EQ4Label)
        Me.EQGroupBox.Controls.Add(Me.EQ3Label)
        Me.EQGroupBox.Controls.Add(Me.EQ2Label)
        Me.EQGroupBox.Controls.Add(Me.EQ1Label)
        Me.EQGroupBox.Controls.Add(Me.m20dbLabel)
        Me.EQGroupBox.Controls.Add(Me.p20dBLabel)
        Me.EQGroupBox.Controls.Add(Me.EQ18TrackBar)
        Me.EQGroupBox.Controls.Add(Me.EQ17TrackBar)
        Me.EQGroupBox.Controls.Add(Me.EQ16TrackBar)
        Me.EQGroupBox.Controls.Add(Me.EQ15TrackBar)
        Me.EQGroupBox.Controls.Add(Me.EQ14TrackBar)
        Me.EQGroupBox.Controls.Add(Me.EQ13TrackBar)
        Me.EQGroupBox.Controls.Add(Me.EQ12TrackBar)
        Me.EQGroupBox.Controls.Add(Me.EQ11TrackBar)
        Me.EQGroupBox.Controls.Add(Me.EQ10TrackBar)
        Me.EQGroupBox.Controls.Add(Me.EQ9TrackBar)
        Me.EQGroupBox.Controls.Add(Me.EQ8TrackBar)
        Me.EQGroupBox.Controls.Add(Me.EQ7TrackBar)
        Me.EQGroupBox.Controls.Add(Me.EQ6TrackBar)
        Me.EQGroupBox.Controls.Add(Me.EQ5TrackBar)
        Me.EQGroupBox.Controls.Add(Me.EQ4TrackBar)
        Me.EQGroupBox.Controls.Add(Me.EQ3TrackBar)
        Me.EQGroupBox.Controls.Add(Me.EQ2TrackBar)
        Me.EQGroupBox.Controls.Add(Me.EQ1TrackBar)
        Me.EQGroupBox.Location = New System.Drawing.Point(12, 172)
        Me.EQGroupBox.Name = "EQGroupBox"
        Me.EQGroupBox.Size = New System.Drawing.Size(656, 209)
        Me.EQGroupBox.TabIndex = 2
        Me.EQGroupBox.TabStop = False
        Me.EQGroupBox.Text = "이퀄라이저"
        '
        'EQCheckBox
        '
        Me.EQCheckBox.AutoSize = True
        Me.EQCheckBox.Location = New System.Drawing.Point(19, 24)
        Me.EQCheckBox.Name = "EQCheckBox"
        Me.EQCheckBox.Size = New System.Drawing.Size(48, 16)
        Me.EQCheckBox.TabIndex = 38
        Me.EQCheckBox.Text = "사용"
        Me.EQCheckBox.UseVisualStyleBackColor = True
        '
        'EQZeroButton
        '
        Me.EQZeroButton.Enabled = False
        Me.EQZeroButton.Location = New System.Drawing.Point(458, 17)
        Me.EQZeroButton.Name = "EQZeroButton"
        Me.EQZeroButton.Size = New System.Drawing.Size(184, 23)
        Me.EQZeroButton.TabIndex = 37
        Me.EQZeroButton.Text = "모든 값을 0으로"
        Me.EQZeroButton.UseVisualStyleBackColor = True
        '
        'EQ18Label
        '
        Me.EQ18Label.AutoSize = True
        Me.EQ18Label.Enabled = False
        Me.EQ18Label.Location = New System.Drawing.Point(613, 178)
        Me.EQ18Label.Name = "EQ18Label"
        Me.EQ18Label.Size = New System.Drawing.Size(25, 12)
        Me.EQ18Label.TabIndex = 35
        Me.EQ18Label.Text = "20K"
        Me.EQ18Label.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'EQ17Label
        '
        Me.EQ17Label.AutoSize = True
        Me.EQ17Label.Enabled = False
        Me.EQ17Label.Location = New System.Drawing.Point(580, 161)
        Me.EQ17Label.Name = "EQ17Label"
        Me.EQ17Label.Size = New System.Drawing.Size(25, 12)
        Me.EQ17Label.TabIndex = 36
        Me.EQ17Label.Text = "14K"
        Me.EQ17Label.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'EQ16Label
        '
        Me.EQ16Label.AutoSize = True
        Me.EQ16Label.Enabled = False
        Me.EQ16Label.Location = New System.Drawing.Point(547, 178)
        Me.EQ16Label.Name = "EQ16Label"
        Me.EQ16Label.Size = New System.Drawing.Size(25, 12)
        Me.EQ16Label.TabIndex = 33
        Me.EQ16Label.Text = "10K"
        Me.EQ16Label.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'EQ15Label
        '
        Me.EQ15Label.AutoSize = True
        Me.EQ15Label.Enabled = False
        Me.EQ15Label.Location = New System.Drawing.Point(518, 161)
        Me.EQ15Label.Name = "EQ15Label"
        Me.EQ15Label.Size = New System.Drawing.Size(19, 12)
        Me.EQ15Label.TabIndex = 34
        Me.EQ15Label.Text = "7K"
        Me.EQ15Label.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'EQ14Label
        '
        Me.EQ14Label.AutoSize = True
        Me.EQ14Label.Enabled = False
        Me.EQ14Label.Location = New System.Drawing.Point(484, 178)
        Me.EQ14Label.Name = "EQ14Label"
        Me.EQ14Label.Size = New System.Drawing.Size(19, 12)
        Me.EQ14Label.TabIndex = 32
        Me.EQ14Label.Text = "5K"
        Me.EQ14Label.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'EQ13Label
        '
        Me.EQ13Label.AutoSize = True
        Me.EQ13Label.Enabled = False
        Me.EQ13Label.Location = New System.Drawing.Point(447, 161)
        Me.EQ13Label.Name = "EQ13Label"
        Me.EQ13Label.Size = New System.Drawing.Size(29, 12)
        Me.EQ13Label.TabIndex = 31
        Me.EQ13Label.Text = "3.5K"
        Me.EQ13Label.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'EQ12Label
        '
        Me.EQ12Label.AutoSize = True
        Me.EQ12Label.Enabled = False
        Me.EQ12Label.Location = New System.Drawing.Point(414, 178)
        Me.EQ12Label.Name = "EQ12Label"
        Me.EQ12Label.Size = New System.Drawing.Size(29, 12)
        Me.EQ12Label.TabIndex = 29
        Me.EQ12Label.Text = "2.5K"
        Me.EQ12Label.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'EQ11Label
        '
        Me.EQ11Label.AutoSize = True
        Me.EQ11Label.Enabled = False
        Me.EQ11Label.Location = New System.Drawing.Point(379, 161)
        Me.EQ11Label.Name = "EQ11Label"
        Me.EQ11Label.Size = New System.Drawing.Size(29, 12)
        Me.EQ11Label.TabIndex = 30
        Me.EQ11Label.Text = "1.8K"
        Me.EQ11Label.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'EQ10Label
        '
        Me.EQ10Label.AutoSize = True
        Me.EQ10Label.Enabled = False
        Me.EQ10Label.Location = New System.Drawing.Point(348, 178)
        Me.EQ10Label.Name = "EQ10Label"
        Me.EQ10Label.Size = New System.Drawing.Size(29, 12)
        Me.EQ10Label.TabIndex = 28
        Me.EQ10Label.Text = "1.2K"
        Me.EQ10Label.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'EQ9Label
        '
        Me.EQ9Label.AutoSize = True
        Me.EQ9Label.Enabled = False
        Me.EQ9Label.Location = New System.Drawing.Point(315, 161)
        Me.EQ9Label.Name = "EQ9Label"
        Me.EQ9Label.Size = New System.Drawing.Size(23, 12)
        Me.EQ9Label.TabIndex = 27
        Me.EQ9Label.Text = "880"
        Me.EQ9Label.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'EQ8Label
        '
        Me.EQ8Label.AutoSize = True
        Me.EQ8Label.Enabled = False
        Me.EQ8Label.Location = New System.Drawing.Point(282, 178)
        Me.EQ8Label.Name = "EQ8Label"
        Me.EQ8Label.Size = New System.Drawing.Size(23, 12)
        Me.EQ8Label.TabIndex = 25
        Me.EQ8Label.Text = "622"
        Me.EQ8Label.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'EQ7Label
        '
        Me.EQ7Label.AutoSize = True
        Me.EQ7Label.Enabled = False
        Me.EQ7Label.Location = New System.Drawing.Point(249, 161)
        Me.EQ7Label.Name = "EQ7Label"
        Me.EQ7Label.Size = New System.Drawing.Size(23, 12)
        Me.EQ7Label.TabIndex = 26
        Me.EQ7Label.Text = "440"
        Me.EQ7Label.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'EQ6Label
        '
        Me.EQ6Label.AutoSize = True
        Me.EQ6Label.Enabled = False
        Me.EQ6Label.Location = New System.Drawing.Point(216, 178)
        Me.EQ6Label.Name = "EQ6Label"
        Me.EQ6Label.Size = New System.Drawing.Size(23, 12)
        Me.EQ6Label.TabIndex = 24
        Me.EQ6Label.Text = "311"
        Me.EQ6Label.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'EQ5Label
        '
        Me.EQ5Label.AutoSize = True
        Me.EQ5Label.Enabled = False
        Me.EQ5Label.Location = New System.Drawing.Point(183, 161)
        Me.EQ5Label.Name = "EQ5Label"
        Me.EQ5Label.Size = New System.Drawing.Size(23, 12)
        Me.EQ5Label.TabIndex = 23
        Me.EQ5Label.Text = "220"
        Me.EQ5Label.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'EQ4Label
        '
        Me.EQ4Label.AutoSize = True
        Me.EQ4Label.Enabled = False
        Me.EQ4Label.Location = New System.Drawing.Point(150, 178)
        Me.EQ4Label.Name = "EQ4Label"
        Me.EQ4Label.Size = New System.Drawing.Size(23, 12)
        Me.EQ4Label.TabIndex = 22
        Me.EQ4Label.Text = "156"
        Me.EQ4Label.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'EQ3Label
        '
        Me.EQ3Label.AutoSize = True
        Me.EQ3Label.Enabled = False
        Me.EQ3Label.Location = New System.Drawing.Point(117, 161)
        Me.EQ3Label.Name = "EQ3Label"
        Me.EQ3Label.Size = New System.Drawing.Size(23, 12)
        Me.EQ3Label.TabIndex = 22
        Me.EQ3Label.Text = "110"
        Me.EQ3Label.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'EQ2Label
        '
        Me.EQ2Label.AutoSize = True
        Me.EQ2Label.Enabled = False
        Me.EQ2Label.Location = New System.Drawing.Point(88, 178)
        Me.EQ2Label.Name = "EQ2Label"
        Me.EQ2Label.Size = New System.Drawing.Size(17, 12)
        Me.EQ2Label.TabIndex = 21
        Me.EQ2Label.Text = "77"
        Me.EQ2Label.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'EQ1Label
        '
        Me.EQ1Label.AutoSize = True
        Me.EQ1Label.Enabled = False
        Me.EQ1Label.Location = New System.Drawing.Point(55, 161)
        Me.EQ1Label.Name = "EQ1Label"
        Me.EQ1Label.Size = New System.Drawing.Size(17, 12)
        Me.EQ1Label.TabIndex = 20
        Me.EQ1Label.Text = "55"
        Me.EQ1Label.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'm20dbLabel
        '
        Me.m20dbLabel.Enabled = False
        Me.m20dbLabel.Location = New System.Drawing.Point(6, 143)
        Me.m20dbLabel.Name = "m20dbLabel"
        Me.m20dbLabel.Size = New System.Drawing.Size(41, 21)
        Me.m20dbLabel.TabIndex = 19
        Me.m20dbLabel.Text = "-20dB"
        Me.m20dbLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'p20dBLabel
        '
        Me.p20dBLabel.Enabled = False
        Me.p20dBLabel.Location = New System.Drawing.Point(12, 51)
        Me.p20dBLabel.Name = "p20dBLabel"
        Me.p20dBLabel.Size = New System.Drawing.Size(35, 23)
        Me.p20dBLabel.TabIndex = 18
        Me.p20dBLabel.Text = "20dB"
        Me.p20dBLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'EQ18TrackBar
        '
        Me.EQ18TrackBar.AutoSize = False
        Me.EQ18TrackBar.Enabled = False
        Me.EQ18TrackBar.LargeChange = 0
        Me.EQ18TrackBar.Location = New System.Drawing.Point(615, 51)
        Me.EQ18TrackBar.Maximum = 20
        Me.EQ18TrackBar.Minimum = -20
        Me.EQ18TrackBar.Name = "EQ18TrackBar"
        Me.EQ18TrackBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.EQ18TrackBar.Size = New System.Drawing.Size(23, 104)
        Me.EQ18TrackBar.SmallChange = 0
        Me.EQ18TrackBar.TabIndex = 17
        Me.EQ18TrackBar.TickFrequency = 0
        Me.EQ18TrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'EQ17TrackBar
        '
        Me.EQ17TrackBar.AutoSize = False
        Me.EQ17TrackBar.Enabled = False
        Me.EQ17TrackBar.LargeChange = 0
        Me.EQ17TrackBar.Location = New System.Drawing.Point(582, 51)
        Me.EQ17TrackBar.Maximum = 20
        Me.EQ17TrackBar.Minimum = -20
        Me.EQ17TrackBar.Name = "EQ17TrackBar"
        Me.EQ17TrackBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.EQ17TrackBar.Size = New System.Drawing.Size(23, 104)
        Me.EQ17TrackBar.SmallChange = 0
        Me.EQ17TrackBar.TabIndex = 16
        Me.EQ17TrackBar.TickFrequency = 0
        Me.EQ17TrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'EQ16TrackBar
        '
        Me.EQ16TrackBar.AutoSize = False
        Me.EQ16TrackBar.Enabled = False
        Me.EQ16TrackBar.LargeChange = 0
        Me.EQ16TrackBar.Location = New System.Drawing.Point(549, 51)
        Me.EQ16TrackBar.Maximum = 20
        Me.EQ16TrackBar.Minimum = -20
        Me.EQ16TrackBar.Name = "EQ16TrackBar"
        Me.EQ16TrackBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.EQ16TrackBar.Size = New System.Drawing.Size(23, 104)
        Me.EQ16TrackBar.SmallChange = 0
        Me.EQ16TrackBar.TabIndex = 15
        Me.EQ16TrackBar.TickFrequency = 0
        Me.EQ16TrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'EQ15TrackBar
        '
        Me.EQ15TrackBar.AutoSize = False
        Me.EQ15TrackBar.Enabled = False
        Me.EQ15TrackBar.LargeChange = 0
        Me.EQ15TrackBar.Location = New System.Drawing.Point(516, 51)
        Me.EQ15TrackBar.Maximum = 20
        Me.EQ15TrackBar.Minimum = -20
        Me.EQ15TrackBar.Name = "EQ15TrackBar"
        Me.EQ15TrackBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.EQ15TrackBar.Size = New System.Drawing.Size(23, 104)
        Me.EQ15TrackBar.SmallChange = 0
        Me.EQ15TrackBar.TabIndex = 14
        Me.EQ15TrackBar.TickFrequency = 0
        Me.EQ15TrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'EQ14TrackBar
        '
        Me.EQ14TrackBar.AutoSize = False
        Me.EQ14TrackBar.Enabled = False
        Me.EQ14TrackBar.LargeChange = 0
        Me.EQ14TrackBar.Location = New System.Drawing.Point(482, 51)
        Me.EQ14TrackBar.Maximum = 20
        Me.EQ14TrackBar.Minimum = -20
        Me.EQ14TrackBar.Name = "EQ14TrackBar"
        Me.EQ14TrackBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.EQ14TrackBar.Size = New System.Drawing.Size(23, 104)
        Me.EQ14TrackBar.SmallChange = 0
        Me.EQ14TrackBar.TabIndex = 13
        Me.EQ14TrackBar.TickFrequency = 0
        Me.EQ14TrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'EQ13TrackBar
        '
        Me.EQ13TrackBar.AutoSize = False
        Me.EQ13TrackBar.Enabled = False
        Me.EQ13TrackBar.LargeChange = 0
        Me.EQ13TrackBar.Location = New System.Drawing.Point(449, 51)
        Me.EQ13TrackBar.Maximum = 20
        Me.EQ13TrackBar.Minimum = -20
        Me.EQ13TrackBar.Name = "EQ13TrackBar"
        Me.EQ13TrackBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.EQ13TrackBar.Size = New System.Drawing.Size(23, 104)
        Me.EQ13TrackBar.SmallChange = 0
        Me.EQ13TrackBar.TabIndex = 12
        Me.EQ13TrackBar.TickFrequency = 0
        Me.EQ13TrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'EQ12TrackBar
        '
        Me.EQ12TrackBar.AutoSize = False
        Me.EQ12TrackBar.Enabled = False
        Me.EQ12TrackBar.LargeChange = 0
        Me.EQ12TrackBar.Location = New System.Drawing.Point(416, 51)
        Me.EQ12TrackBar.Maximum = 20
        Me.EQ12TrackBar.Minimum = -20
        Me.EQ12TrackBar.Name = "EQ12TrackBar"
        Me.EQ12TrackBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.EQ12TrackBar.Size = New System.Drawing.Size(23, 104)
        Me.EQ12TrackBar.SmallChange = 0
        Me.EQ12TrackBar.TabIndex = 11
        Me.EQ12TrackBar.TickFrequency = 0
        Me.EQ12TrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'EQ11TrackBar
        '
        Me.EQ11TrackBar.AutoSize = False
        Me.EQ11TrackBar.Enabled = False
        Me.EQ11TrackBar.LargeChange = 0
        Me.EQ11TrackBar.Location = New System.Drawing.Point(383, 51)
        Me.EQ11TrackBar.Maximum = 20
        Me.EQ11TrackBar.Minimum = -20
        Me.EQ11TrackBar.Name = "EQ11TrackBar"
        Me.EQ11TrackBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.EQ11TrackBar.Size = New System.Drawing.Size(23, 104)
        Me.EQ11TrackBar.SmallChange = 0
        Me.EQ11TrackBar.TabIndex = 10
        Me.EQ11TrackBar.TickFrequency = 0
        Me.EQ11TrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'EQ10TrackBar
        '
        Me.EQ10TrackBar.AutoSize = False
        Me.EQ10TrackBar.Enabled = False
        Me.EQ10TrackBar.LargeChange = 0
        Me.EQ10TrackBar.Location = New System.Drawing.Point(350, 51)
        Me.EQ10TrackBar.Maximum = 20
        Me.EQ10TrackBar.Minimum = -20
        Me.EQ10TrackBar.Name = "EQ10TrackBar"
        Me.EQ10TrackBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.EQ10TrackBar.Size = New System.Drawing.Size(23, 104)
        Me.EQ10TrackBar.SmallChange = 0
        Me.EQ10TrackBar.TabIndex = 9
        Me.EQ10TrackBar.TickFrequency = 0
        Me.EQ10TrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'EQ9TrackBar
        '
        Me.EQ9TrackBar.AutoSize = False
        Me.EQ9TrackBar.Enabled = False
        Me.EQ9TrackBar.LargeChange = 0
        Me.EQ9TrackBar.Location = New System.Drawing.Point(317, 51)
        Me.EQ9TrackBar.Maximum = 20
        Me.EQ9TrackBar.Minimum = -20
        Me.EQ9TrackBar.Name = "EQ9TrackBar"
        Me.EQ9TrackBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.EQ9TrackBar.Size = New System.Drawing.Size(23, 104)
        Me.EQ9TrackBar.SmallChange = 0
        Me.EQ9TrackBar.TabIndex = 8
        Me.EQ9TrackBar.TickFrequency = 0
        Me.EQ9TrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'EQ8TrackBar
        '
        Me.EQ8TrackBar.AutoSize = False
        Me.EQ8TrackBar.Enabled = False
        Me.EQ8TrackBar.LargeChange = 0
        Me.EQ8TrackBar.Location = New System.Drawing.Point(284, 51)
        Me.EQ8TrackBar.Maximum = 20
        Me.EQ8TrackBar.Minimum = -20
        Me.EQ8TrackBar.Name = "EQ8TrackBar"
        Me.EQ8TrackBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.EQ8TrackBar.Size = New System.Drawing.Size(23, 104)
        Me.EQ8TrackBar.SmallChange = 0
        Me.EQ8TrackBar.TabIndex = 7
        Me.EQ8TrackBar.TickFrequency = 0
        Me.EQ8TrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'EQ7TrackBar
        '
        Me.EQ7TrackBar.AutoSize = False
        Me.EQ7TrackBar.Enabled = False
        Me.EQ7TrackBar.LargeChange = 0
        Me.EQ7TrackBar.Location = New System.Drawing.Point(251, 51)
        Me.EQ7TrackBar.Maximum = 20
        Me.EQ7TrackBar.Minimum = -20
        Me.EQ7TrackBar.Name = "EQ7TrackBar"
        Me.EQ7TrackBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.EQ7TrackBar.Size = New System.Drawing.Size(23, 104)
        Me.EQ7TrackBar.SmallChange = 0
        Me.EQ7TrackBar.TabIndex = 6
        Me.EQ7TrackBar.TickFrequency = 0
        Me.EQ7TrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'EQ6TrackBar
        '
        Me.EQ6TrackBar.AutoSize = False
        Me.EQ6TrackBar.Enabled = False
        Me.EQ6TrackBar.LargeChange = 0
        Me.EQ6TrackBar.Location = New System.Drawing.Point(218, 51)
        Me.EQ6TrackBar.Maximum = 20
        Me.EQ6TrackBar.Minimum = -20
        Me.EQ6TrackBar.Name = "EQ6TrackBar"
        Me.EQ6TrackBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.EQ6TrackBar.Size = New System.Drawing.Size(23, 104)
        Me.EQ6TrackBar.SmallChange = 0
        Me.EQ6TrackBar.TabIndex = 5
        Me.EQ6TrackBar.TickFrequency = 0
        Me.EQ6TrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'EQ5TrackBar
        '
        Me.EQ5TrackBar.AutoSize = False
        Me.EQ5TrackBar.Enabled = False
        Me.EQ5TrackBar.LargeChange = 0
        Me.EQ5TrackBar.Location = New System.Drawing.Point(185, 51)
        Me.EQ5TrackBar.Maximum = 20
        Me.EQ5TrackBar.Minimum = -20
        Me.EQ5TrackBar.Name = "EQ5TrackBar"
        Me.EQ5TrackBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.EQ5TrackBar.Size = New System.Drawing.Size(23, 104)
        Me.EQ5TrackBar.SmallChange = 0
        Me.EQ5TrackBar.TabIndex = 4
        Me.EQ5TrackBar.TickFrequency = 0
        Me.EQ5TrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'EQ4TrackBar
        '
        Me.EQ4TrackBar.AutoSize = False
        Me.EQ4TrackBar.Enabled = False
        Me.EQ4TrackBar.LargeChange = 0
        Me.EQ4TrackBar.Location = New System.Drawing.Point(152, 51)
        Me.EQ4TrackBar.Maximum = 20
        Me.EQ4TrackBar.Minimum = -20
        Me.EQ4TrackBar.Name = "EQ4TrackBar"
        Me.EQ4TrackBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.EQ4TrackBar.Size = New System.Drawing.Size(23, 104)
        Me.EQ4TrackBar.SmallChange = 0
        Me.EQ4TrackBar.TabIndex = 3
        Me.EQ4TrackBar.TickFrequency = 0
        Me.EQ4TrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'EQ3TrackBar
        '
        Me.EQ3TrackBar.AutoSize = False
        Me.EQ3TrackBar.Enabled = False
        Me.EQ3TrackBar.LargeChange = 0
        Me.EQ3TrackBar.Location = New System.Drawing.Point(119, 51)
        Me.EQ3TrackBar.Maximum = 20
        Me.EQ3TrackBar.Minimum = -20
        Me.EQ3TrackBar.Name = "EQ3TrackBar"
        Me.EQ3TrackBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.EQ3TrackBar.Size = New System.Drawing.Size(23, 104)
        Me.EQ3TrackBar.SmallChange = 0
        Me.EQ3TrackBar.TabIndex = 2
        Me.EQ3TrackBar.TickFrequency = 0
        Me.EQ3TrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'EQ2TrackBar
        '
        Me.EQ2TrackBar.AutoSize = False
        Me.EQ2TrackBar.Enabled = False
        Me.EQ2TrackBar.LargeChange = 0
        Me.EQ2TrackBar.Location = New System.Drawing.Point(86, 51)
        Me.EQ2TrackBar.Maximum = 20
        Me.EQ2TrackBar.Minimum = -20
        Me.EQ2TrackBar.Name = "EQ2TrackBar"
        Me.EQ2TrackBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.EQ2TrackBar.Size = New System.Drawing.Size(23, 104)
        Me.EQ2TrackBar.SmallChange = 0
        Me.EQ2TrackBar.TabIndex = 1
        Me.EQ2TrackBar.TickFrequency = 0
        Me.EQ2TrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'EQ1TrackBar
        '
        Me.EQ1TrackBar.AutoSize = False
        Me.EQ1TrackBar.Enabled = False
        Me.EQ1TrackBar.LargeChange = 0
        Me.EQ1TrackBar.Location = New System.Drawing.Point(53, 51)
        Me.EQ1TrackBar.Maximum = 20
        Me.EQ1TrackBar.Minimum = -20
        Me.EQ1TrackBar.Name = "EQ1TrackBar"
        Me.EQ1TrackBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.EQ1TrackBar.Size = New System.Drawing.Size(23, 104)
        Me.EQ1TrackBar.SmallChange = 0
        Me.EQ1TrackBar.TabIndex = 0
        Me.EQ1TrackBar.TickFrequency = 0
        Me.EQ1TrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'CancelBTN
        '
        Me.CancelBTN.Location = New System.Drawing.Point(579, 394)
        Me.CancelBTN.Name = "CancelBTN"
        Me.CancelBTN.Size = New System.Drawing.Size(90, 25)
        Me.CancelBTN.TabIndex = 11
        Me.CancelBTN.Text = "취소"
        Me.CancelBTN.UseVisualStyleBackColor = True
        '
        'OKBTN
        '
        Me.OKBTN.Location = New System.Drawing.Point(479, 394)
        Me.OKBTN.Name = "OKBTN"
        Me.OKBTN.Size = New System.Drawing.Size(90, 25)
        Me.OKBTN.TabIndex = 12
        Me.OKBTN.Text = "확인"
        Me.OKBTN.UseVisualStyleBackColor = True
        '
        'DefBTN
        '
        Me.DefBTN.Location = New System.Drawing.Point(13, 394)
        Me.DefBTN.Name = "DefBTN"
        Me.DefBTN.Size = New System.Drawing.Size(90, 25)
        Me.DefBTN.TabIndex = 10
        Me.DefBTN.Text = "기본값"
        Me.DefBTN.UseVisualStyleBackColor = True
        '
        'APP_Panel
        '
        Me.APP_Panel.Controls.Add(Me.AviSynthChGroupBox)
        Me.APP_Panel.Controls.Add(Me.AmplifyGroupBox)
        Me.APP_Panel.Controls.Add(Me.DefBTN)
        Me.APP_Panel.Controls.Add(Me.OKBTN)
        Me.APP_Panel.Controls.Add(Me.CancelBTN)
        Me.APP_Panel.Controls.Add(Me.EQGroupBox)
        Me.APP_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.APP_Panel.Location = New System.Drawing.Point(0, 0)
        Me.APP_Panel.Name = "APP_Panel"
        Me.APP_Panel.Size = New System.Drawing.Size(688, 436)
        Me.APP_Panel.TabIndex = 13
        '
        'AviSynthChGroupBox
        '
        Me.AviSynthChGroupBox.Controls.Add(Me.AviSynthChComboBox)
        Me.AviSynthChGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.AviSynthChGroupBox.Name = "AviSynthChGroupBox"
        Me.AviSynthChGroupBox.Size = New System.Drawing.Size(354, 53)
        Me.AviSynthChGroupBox.TabIndex = 13
        Me.AviSynthChGroupBox.TabStop = False
        Me.AviSynthChGroupBox.Text = "오디오 채널"
        '
        'AviSynthChComboBox
        '
        Me.AviSynthChComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AviSynthChComboBox.FormattingEnabled = True
        Me.AviSynthChComboBox.Location = New System.Drawing.Point(14, 20)
        Me.AviSynthChComboBox.Name = "AviSynthChComboBox"
        Me.AviSynthChComboBox.Size = New System.Drawing.Size(324, 20)
        Me.AviSynthChComboBox.TabIndex = 14
        '
        'AudioPPFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 436)
        Me.Controls.Add(Me.APP_Panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AudioPPFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "오디오 설정"
        Me.AmplifyGroupBox.ResumeLayout(False)
        Me.AmplifyGroupBox.PerformLayout()
        CType(Me.AmplifyTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmplifyNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EQGroupBox.ResumeLayout(False)
        Me.EQGroupBox.PerformLayout()
        CType(Me.EQ18TrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EQ17TrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EQ16TrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EQ15TrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EQ14TrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EQ13TrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EQ12TrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EQ11TrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EQ10TrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EQ9TrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EQ8TrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EQ7TrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EQ6TrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EQ5TrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EQ4TrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EQ3TrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EQ2TrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EQ1TrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.APP_Panel.ResumeLayout(False)
        Me.AviSynthChGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AmplifyGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents AmplifyCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AmplifyTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents AmplifyNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents EQGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents EQCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents EQZeroButton As System.Windows.Forms.Button
    Friend WithEvents EQ18Label As System.Windows.Forms.Label
    Friend WithEvents EQ17Label As System.Windows.Forms.Label
    Friend WithEvents EQ16Label As System.Windows.Forms.Label
    Friend WithEvents EQ15Label As System.Windows.Forms.Label
    Friend WithEvents EQ14Label As System.Windows.Forms.Label
    Friend WithEvents EQ13Label As System.Windows.Forms.Label
    Friend WithEvents EQ12Label As System.Windows.Forms.Label
    Friend WithEvents EQ11Label As System.Windows.Forms.Label
    Friend WithEvents EQ10Label As System.Windows.Forms.Label
    Friend WithEvents EQ9Label As System.Windows.Forms.Label
    Friend WithEvents EQ8Label As System.Windows.Forms.Label
    Friend WithEvents EQ7Label As System.Windows.Forms.Label
    Friend WithEvents EQ6Label As System.Windows.Forms.Label
    Friend WithEvents EQ5Label As System.Windows.Forms.Label
    Friend WithEvents EQ4Label As System.Windows.Forms.Label
    Friend WithEvents EQ3Label As System.Windows.Forms.Label
    Friend WithEvents EQ2Label As System.Windows.Forms.Label
    Friend WithEvents EQ1Label As System.Windows.Forms.Label
    Friend WithEvents m20dbLabel As System.Windows.Forms.Label
    Friend WithEvents p20dBLabel As System.Windows.Forms.Label
    Friend WithEvents EQ18TrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents EQ17TrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents EQ16TrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents EQ15TrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents EQ14TrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents EQ13TrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents EQ12TrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents EQ11TrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents EQ10TrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents EQ9TrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents EQ8TrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents EQ7TrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents EQ6TrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents EQ5TrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents EQ4TrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents EQ3TrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents EQ2TrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents EQ1TrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents CancelBTN As System.Windows.Forms.Button
    Friend WithEvents OKBTN As System.Windows.Forms.Button
    Friend WithEvents DefBTN As System.Windows.Forms.Button
    Friend WithEvents EQToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents APP_Panel As System.Windows.Forms.Panel
    Friend WithEvents AviSynthChGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents AviSynthChComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents dBLabel As System.Windows.Forms.Label
End Class
