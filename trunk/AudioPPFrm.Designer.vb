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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AudioPPFrm))
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
        resources.ApplyResources(Me.AmplifyGroupBox, "AmplifyGroupBox")
        Me.AmplifyGroupBox.Name = "AmplifyGroupBox"
        Me.AmplifyGroupBox.TabStop = False
        '
        'dBLabel
        '
        resources.ApplyResources(Me.dBLabel, "dBLabel")
        Me.dBLabel.Name = "dBLabel"
        '
        'AmplifyCheckBox
        '
        resources.ApplyResources(Me.AmplifyCheckBox, "AmplifyCheckBox")
        Me.AmplifyCheckBox.Name = "AmplifyCheckBox"
        Me.AmplifyCheckBox.UseVisualStyleBackColor = True
        '
        'AmplifyTrackBar
        '
        resources.ApplyResources(Me.AmplifyTrackBar, "AmplifyTrackBar")
        Me.AmplifyTrackBar.Maximum = 1000
        Me.AmplifyTrackBar.Minimum = -1000
        Me.AmplifyTrackBar.Name = "AmplifyTrackBar"
        Me.AmplifyTrackBar.TickFrequency = 0
        Me.AmplifyTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'AmplifyNumericUpDown
        '
        Me.AmplifyNumericUpDown.DecimalPlaces = 1
        resources.ApplyResources(Me.AmplifyNumericUpDown, "AmplifyNumericUpDown")
        Me.AmplifyNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.AmplifyNumericUpDown.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.AmplifyNumericUpDown.Name = "AmplifyNumericUpDown"
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
        resources.ApplyResources(Me.EQGroupBox, "EQGroupBox")
        Me.EQGroupBox.Name = "EQGroupBox"
        Me.EQGroupBox.TabStop = False
        '
        'EQCheckBox
        '
        resources.ApplyResources(Me.EQCheckBox, "EQCheckBox")
        Me.EQCheckBox.Name = "EQCheckBox"
        Me.EQCheckBox.UseVisualStyleBackColor = True
        '
        'EQZeroButton
        '
        resources.ApplyResources(Me.EQZeroButton, "EQZeroButton")
        Me.EQZeroButton.Name = "EQZeroButton"
        Me.EQZeroButton.UseVisualStyleBackColor = True
        '
        'EQ18Label
        '
        resources.ApplyResources(Me.EQ18Label, "EQ18Label")
        Me.EQ18Label.Name = "EQ18Label"
        '
        'EQ17Label
        '
        resources.ApplyResources(Me.EQ17Label, "EQ17Label")
        Me.EQ17Label.Name = "EQ17Label"
        '
        'EQ16Label
        '
        resources.ApplyResources(Me.EQ16Label, "EQ16Label")
        Me.EQ16Label.Name = "EQ16Label"
        '
        'EQ15Label
        '
        resources.ApplyResources(Me.EQ15Label, "EQ15Label")
        Me.EQ15Label.Name = "EQ15Label"
        '
        'EQ14Label
        '
        resources.ApplyResources(Me.EQ14Label, "EQ14Label")
        Me.EQ14Label.Name = "EQ14Label"
        '
        'EQ13Label
        '
        resources.ApplyResources(Me.EQ13Label, "EQ13Label")
        Me.EQ13Label.Name = "EQ13Label"
        '
        'EQ12Label
        '
        resources.ApplyResources(Me.EQ12Label, "EQ12Label")
        Me.EQ12Label.Name = "EQ12Label"
        '
        'EQ11Label
        '
        resources.ApplyResources(Me.EQ11Label, "EQ11Label")
        Me.EQ11Label.Name = "EQ11Label"
        '
        'EQ10Label
        '
        resources.ApplyResources(Me.EQ10Label, "EQ10Label")
        Me.EQ10Label.Name = "EQ10Label"
        '
        'EQ9Label
        '
        resources.ApplyResources(Me.EQ9Label, "EQ9Label")
        Me.EQ9Label.Name = "EQ9Label"
        '
        'EQ8Label
        '
        resources.ApplyResources(Me.EQ8Label, "EQ8Label")
        Me.EQ8Label.Name = "EQ8Label"
        '
        'EQ7Label
        '
        resources.ApplyResources(Me.EQ7Label, "EQ7Label")
        Me.EQ7Label.Name = "EQ7Label"
        '
        'EQ6Label
        '
        resources.ApplyResources(Me.EQ6Label, "EQ6Label")
        Me.EQ6Label.Name = "EQ6Label"
        '
        'EQ5Label
        '
        resources.ApplyResources(Me.EQ5Label, "EQ5Label")
        Me.EQ5Label.Name = "EQ5Label"
        '
        'EQ4Label
        '
        resources.ApplyResources(Me.EQ4Label, "EQ4Label")
        Me.EQ4Label.Name = "EQ4Label"
        '
        'EQ3Label
        '
        resources.ApplyResources(Me.EQ3Label, "EQ3Label")
        Me.EQ3Label.Name = "EQ3Label"
        '
        'EQ2Label
        '
        resources.ApplyResources(Me.EQ2Label, "EQ2Label")
        Me.EQ2Label.Name = "EQ2Label"
        '
        'EQ1Label
        '
        resources.ApplyResources(Me.EQ1Label, "EQ1Label")
        Me.EQ1Label.Name = "EQ1Label"
        '
        'm20dbLabel
        '
        resources.ApplyResources(Me.m20dbLabel, "m20dbLabel")
        Me.m20dbLabel.Name = "m20dbLabel"
        '
        'p20dBLabel
        '
        resources.ApplyResources(Me.p20dBLabel, "p20dBLabel")
        Me.p20dBLabel.Name = "p20dBLabel"
        '
        'EQ18TrackBar
        '
        resources.ApplyResources(Me.EQ18TrackBar, "EQ18TrackBar")
        Me.EQ18TrackBar.LargeChange = 0
        Me.EQ18TrackBar.Maximum = 20
        Me.EQ18TrackBar.Minimum = -20
        Me.EQ18TrackBar.Name = "EQ18TrackBar"
        Me.EQ18TrackBar.SmallChange = 0
        Me.EQ18TrackBar.TickFrequency = 0
        Me.EQ18TrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'EQ17TrackBar
        '
        resources.ApplyResources(Me.EQ17TrackBar, "EQ17TrackBar")
        Me.EQ17TrackBar.LargeChange = 0
        Me.EQ17TrackBar.Maximum = 20
        Me.EQ17TrackBar.Minimum = -20
        Me.EQ17TrackBar.Name = "EQ17TrackBar"
        Me.EQ17TrackBar.SmallChange = 0
        Me.EQ17TrackBar.TickFrequency = 0
        Me.EQ17TrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'EQ16TrackBar
        '
        resources.ApplyResources(Me.EQ16TrackBar, "EQ16TrackBar")
        Me.EQ16TrackBar.LargeChange = 0
        Me.EQ16TrackBar.Maximum = 20
        Me.EQ16TrackBar.Minimum = -20
        Me.EQ16TrackBar.Name = "EQ16TrackBar"
        Me.EQ16TrackBar.SmallChange = 0
        Me.EQ16TrackBar.TickFrequency = 0
        Me.EQ16TrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'EQ15TrackBar
        '
        resources.ApplyResources(Me.EQ15TrackBar, "EQ15TrackBar")
        Me.EQ15TrackBar.LargeChange = 0
        Me.EQ15TrackBar.Maximum = 20
        Me.EQ15TrackBar.Minimum = -20
        Me.EQ15TrackBar.Name = "EQ15TrackBar"
        Me.EQ15TrackBar.SmallChange = 0
        Me.EQ15TrackBar.TickFrequency = 0
        Me.EQ15TrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'EQ14TrackBar
        '
        resources.ApplyResources(Me.EQ14TrackBar, "EQ14TrackBar")
        Me.EQ14TrackBar.LargeChange = 0
        Me.EQ14TrackBar.Maximum = 20
        Me.EQ14TrackBar.Minimum = -20
        Me.EQ14TrackBar.Name = "EQ14TrackBar"
        Me.EQ14TrackBar.SmallChange = 0
        Me.EQ14TrackBar.TickFrequency = 0
        Me.EQ14TrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'EQ13TrackBar
        '
        resources.ApplyResources(Me.EQ13TrackBar, "EQ13TrackBar")
        Me.EQ13TrackBar.LargeChange = 0
        Me.EQ13TrackBar.Maximum = 20
        Me.EQ13TrackBar.Minimum = -20
        Me.EQ13TrackBar.Name = "EQ13TrackBar"
        Me.EQ13TrackBar.SmallChange = 0
        Me.EQ13TrackBar.TickFrequency = 0
        Me.EQ13TrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'EQ12TrackBar
        '
        resources.ApplyResources(Me.EQ12TrackBar, "EQ12TrackBar")
        Me.EQ12TrackBar.LargeChange = 0
        Me.EQ12TrackBar.Maximum = 20
        Me.EQ12TrackBar.Minimum = -20
        Me.EQ12TrackBar.Name = "EQ12TrackBar"
        Me.EQ12TrackBar.SmallChange = 0
        Me.EQ12TrackBar.TickFrequency = 0
        Me.EQ12TrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'EQ11TrackBar
        '
        resources.ApplyResources(Me.EQ11TrackBar, "EQ11TrackBar")
        Me.EQ11TrackBar.LargeChange = 0
        Me.EQ11TrackBar.Maximum = 20
        Me.EQ11TrackBar.Minimum = -20
        Me.EQ11TrackBar.Name = "EQ11TrackBar"
        Me.EQ11TrackBar.SmallChange = 0
        Me.EQ11TrackBar.TickFrequency = 0
        Me.EQ11TrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'EQ10TrackBar
        '
        resources.ApplyResources(Me.EQ10TrackBar, "EQ10TrackBar")
        Me.EQ10TrackBar.LargeChange = 0
        Me.EQ10TrackBar.Maximum = 20
        Me.EQ10TrackBar.Minimum = -20
        Me.EQ10TrackBar.Name = "EQ10TrackBar"
        Me.EQ10TrackBar.SmallChange = 0
        Me.EQ10TrackBar.TickFrequency = 0
        Me.EQ10TrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'EQ9TrackBar
        '
        resources.ApplyResources(Me.EQ9TrackBar, "EQ9TrackBar")
        Me.EQ9TrackBar.LargeChange = 0
        Me.EQ9TrackBar.Maximum = 20
        Me.EQ9TrackBar.Minimum = -20
        Me.EQ9TrackBar.Name = "EQ9TrackBar"
        Me.EQ9TrackBar.SmallChange = 0
        Me.EQ9TrackBar.TickFrequency = 0
        Me.EQ9TrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'EQ8TrackBar
        '
        resources.ApplyResources(Me.EQ8TrackBar, "EQ8TrackBar")
        Me.EQ8TrackBar.LargeChange = 0
        Me.EQ8TrackBar.Maximum = 20
        Me.EQ8TrackBar.Minimum = -20
        Me.EQ8TrackBar.Name = "EQ8TrackBar"
        Me.EQ8TrackBar.SmallChange = 0
        Me.EQ8TrackBar.TickFrequency = 0
        Me.EQ8TrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'EQ7TrackBar
        '
        resources.ApplyResources(Me.EQ7TrackBar, "EQ7TrackBar")
        Me.EQ7TrackBar.LargeChange = 0
        Me.EQ7TrackBar.Maximum = 20
        Me.EQ7TrackBar.Minimum = -20
        Me.EQ7TrackBar.Name = "EQ7TrackBar"
        Me.EQ7TrackBar.SmallChange = 0
        Me.EQ7TrackBar.TickFrequency = 0
        Me.EQ7TrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'EQ6TrackBar
        '
        resources.ApplyResources(Me.EQ6TrackBar, "EQ6TrackBar")
        Me.EQ6TrackBar.LargeChange = 0
        Me.EQ6TrackBar.Maximum = 20
        Me.EQ6TrackBar.Minimum = -20
        Me.EQ6TrackBar.Name = "EQ6TrackBar"
        Me.EQ6TrackBar.SmallChange = 0
        Me.EQ6TrackBar.TickFrequency = 0
        Me.EQ6TrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'EQ5TrackBar
        '
        resources.ApplyResources(Me.EQ5TrackBar, "EQ5TrackBar")
        Me.EQ5TrackBar.LargeChange = 0
        Me.EQ5TrackBar.Maximum = 20
        Me.EQ5TrackBar.Minimum = -20
        Me.EQ5TrackBar.Name = "EQ5TrackBar"
        Me.EQ5TrackBar.SmallChange = 0
        Me.EQ5TrackBar.TickFrequency = 0
        Me.EQ5TrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'EQ4TrackBar
        '
        resources.ApplyResources(Me.EQ4TrackBar, "EQ4TrackBar")
        Me.EQ4TrackBar.LargeChange = 0
        Me.EQ4TrackBar.Maximum = 20
        Me.EQ4TrackBar.Minimum = -20
        Me.EQ4TrackBar.Name = "EQ4TrackBar"
        Me.EQ4TrackBar.SmallChange = 0
        Me.EQ4TrackBar.TickFrequency = 0
        Me.EQ4TrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'EQ3TrackBar
        '
        resources.ApplyResources(Me.EQ3TrackBar, "EQ3TrackBar")
        Me.EQ3TrackBar.LargeChange = 0
        Me.EQ3TrackBar.Maximum = 20
        Me.EQ3TrackBar.Minimum = -20
        Me.EQ3TrackBar.Name = "EQ3TrackBar"
        Me.EQ3TrackBar.SmallChange = 0
        Me.EQ3TrackBar.TickFrequency = 0
        Me.EQ3TrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'EQ2TrackBar
        '
        resources.ApplyResources(Me.EQ2TrackBar, "EQ2TrackBar")
        Me.EQ2TrackBar.LargeChange = 0
        Me.EQ2TrackBar.Maximum = 20
        Me.EQ2TrackBar.Minimum = -20
        Me.EQ2TrackBar.Name = "EQ2TrackBar"
        Me.EQ2TrackBar.SmallChange = 0
        Me.EQ2TrackBar.TickFrequency = 0
        Me.EQ2TrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'EQ1TrackBar
        '
        resources.ApplyResources(Me.EQ1TrackBar, "EQ1TrackBar")
        Me.EQ1TrackBar.LargeChange = 0
        Me.EQ1TrackBar.Maximum = 20
        Me.EQ1TrackBar.Minimum = -20
        Me.EQ1TrackBar.Name = "EQ1TrackBar"
        Me.EQ1TrackBar.SmallChange = 0
        Me.EQ1TrackBar.TickFrequency = 0
        Me.EQ1TrackBar.TickStyle = System.Windows.Forms.TickStyle.None
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
        'DefBTN
        '
        resources.ApplyResources(Me.DefBTN, "DefBTN")
        Me.DefBTN.Name = "DefBTN"
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
        resources.ApplyResources(Me.APP_Panel, "APP_Panel")
        Me.APP_Panel.Name = "APP_Panel"
        '
        'AviSynthChGroupBox
        '
        Me.AviSynthChGroupBox.Controls.Add(Me.AviSynthChComboBox)
        resources.ApplyResources(Me.AviSynthChGroupBox, "AviSynthChGroupBox")
        Me.AviSynthChGroupBox.Name = "AviSynthChGroupBox"
        Me.AviSynthChGroupBox.TabStop = False
        '
        'AviSynthChComboBox
        '
        Me.AviSynthChComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AviSynthChComboBox.FormattingEnabled = True
        resources.ApplyResources(Me.AviSynthChComboBox, "AviSynthChComboBox")
        Me.AviSynthChComboBox.Name = "AviSynthChComboBox"
        '
        'AudioPPFrm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.APP_Panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AudioPPFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
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
