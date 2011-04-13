<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ETCPPFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ETCPPFrm))
        Me.RateGroupBox = New System.Windows.Forms.GroupBox
        Me.RatePCheckBox = New System.Windows.Forms.CheckBox
        Me.RateCheckBox = New System.Windows.Forms.CheckBox
        Me.RateNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.DefBTN = New System.Windows.Forms.Button
        Me.OKBTN = New System.Windows.Forms.Button
        Me.CancelBTN = New System.Windows.Forms.Button
        Me.EPP_Panel = New System.Windows.Forms.Panel
        Me.Logo3FrameTextBox = New System.Windows.Forms.TextBox
        Me.Logo1FrameTextBox = New System.Windows.Forms.TextBox
        Me.Logo0FrameTextBox = New System.Windows.Forms.TextBox
        Me.LogoGroupBox = New System.Windows.Forms.GroupBox
        Me.LogoPanel = New System.Windows.Forms.Panel
        Me.ModeComboBox = New System.Windows.Forms.ComboBox
        Me.ModeLabel = New System.Windows.Forms.Label
        Me.LogoTrPaLabel = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.YNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.XNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.LAlignmentGroupBox = New System.Windows.Forms.GroupBox
        Me.LAlignment3RadioButton = New System.Windows.Forms.RadioButton
        Me.LAlignment2RadioButton = New System.Windows.Forms.RadioButton
        Me.LAlignment1RadioButton = New System.Windows.Forms.RadioButton
        Me.LAlignment8RadioButton = New System.Windows.Forms.RadioButton
        Me.LAlignment7RadioButton = New System.Windows.Forms.RadioButton
        Me.LAlignment9RadioButton = New System.Windows.Forms.RadioButton
        Me.LAlignment4RadioButton = New System.Windows.Forms.RadioButton
        Me.LAlignment6RadioButton = New System.Windows.Forms.RadioButton
        Me.LAlignment5RadioButton = New System.Windows.Forms.RadioButton
        Me.LogoImgLabel = New System.Windows.Forms.Label
        Me.fadeoutNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.LSMTextBox = New System.Windows.Forms.TextBox
        Me.LSP2Label = New System.Windows.Forms.Label
        Me.fadeoutLabel = New System.Windows.Forms.Label
        Me.LSP1Label = New System.Windows.Forms.Label
        Me.LECheckBox = New System.Windows.Forms.CheckBox
        Me.fadeinNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.LSHTextBox = New System.Windows.Forms.TextBox
        Me.LEHTextBox = New System.Windows.Forms.TextBox
        Me.fadeinLabel = New System.Windows.Forms.Label
        Me.LSCheckBox = New System.Windows.Forms.CheckBox
        Me.LEP1Label = New System.Windows.Forms.Label
        Me.FadeCheckBox = New System.Windows.Forms.CheckBox
        Me.AlphaCheckBox = New System.Windows.Forms.CheckBox
        Me.LEMTextBox = New System.Windows.Forms.TextBox
        Me.LogoTrPaTrackBar = New System.Windows.Forms.TrackBar
        Me.LogoImgButton = New System.Windows.Forms.Button
        Me.LEP2Label = New System.Windows.Forms.Label
        Me.LogoTrPaCheckBox = New System.Windows.Forms.CheckBox
        Me.LogoImgTextBox = New System.Windows.Forms.TextBox
        Me.LSSTextBox = New System.Windows.Forms.TextBox
        Me.LESTextBox = New System.Windows.Forms.TextBox
        Me.LogoCheckBox = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.reverseCheckBox = New System.Windows.Forms.CheckBox
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.RateGroupBox.SuspendLayout()
        CType(Me.RateNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPP_Panel.SuspendLayout()
        Me.LogoGroupBox.SuspendLayout()
        Me.LogoPanel.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.YNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.XNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LAlignmentGroupBox.SuspendLayout()
        CType(Me.fadeoutNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fadeinNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogoTrPaTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RateGroupBox
        '
        Me.RateGroupBox.Controls.Add(Me.RatePCheckBox)
        Me.RateGroupBox.Controls.Add(Me.RateCheckBox)
        Me.RateGroupBox.Controls.Add(Me.RateNumericUpDown)
        resources.ApplyResources(Me.RateGroupBox, "RateGroupBox")
        Me.RateGroupBox.Name = "RateGroupBox"
        Me.RateGroupBox.TabStop = False
        '
        'RatePCheckBox
        '
        resources.ApplyResources(Me.RatePCheckBox, "RatePCheckBox")
        Me.RatePCheckBox.Name = "RatePCheckBox"
        Me.RatePCheckBox.UseVisualStyleBackColor = True
        '
        'RateCheckBox
        '
        resources.ApplyResources(Me.RateCheckBox, "RateCheckBox")
        Me.RateCheckBox.Name = "RateCheckBox"
        Me.RateCheckBox.UseVisualStyleBackColor = True
        '
        'RateNumericUpDown
        '
        Me.RateNumericUpDown.DecimalPlaces = 2
        resources.ApplyResources(Me.RateNumericUpDown, "RateNumericUpDown")
        Me.RateNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.RateNumericUpDown.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.RateNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.RateNumericUpDown.Name = "RateNumericUpDown"
        Me.RateNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'DefBTN
        '
        resources.ApplyResources(Me.DefBTN, "DefBTN")
        Me.DefBTN.Name = "DefBTN"
        Me.DefBTN.UseVisualStyleBackColor = True
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
        'EPP_Panel
        '
        Me.EPP_Panel.Controls.Add(Me.Logo3FrameTextBox)
        Me.EPP_Panel.Controls.Add(Me.Logo1FrameTextBox)
        Me.EPP_Panel.Controls.Add(Me.Logo0FrameTextBox)
        Me.EPP_Panel.Controls.Add(Me.LogoGroupBox)
        Me.EPP_Panel.Controls.Add(Me.RateGroupBox)
        Me.EPP_Panel.Controls.Add(Me.DefBTN)
        Me.EPP_Panel.Controls.Add(Me.CancelBTN)
        Me.EPP_Panel.Controls.Add(Me.OKBTN)
        Me.EPP_Panel.Controls.Add(Me.GroupBox1)
        resources.ApplyResources(Me.EPP_Panel, "EPP_Panel")
        Me.EPP_Panel.Name = "EPP_Panel"
        '
        'Logo3FrameTextBox
        '
        Me.Logo3FrameTextBox.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.Logo3FrameTextBox, "Logo3FrameTextBox")
        Me.Logo3FrameTextBox.Name = "Logo3FrameTextBox"
        '
        'Logo1FrameTextBox
        '
        Me.Logo1FrameTextBox.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.Logo1FrameTextBox, "Logo1FrameTextBox")
        Me.Logo1FrameTextBox.Name = "Logo1FrameTextBox"
        '
        'Logo0FrameTextBox
        '
        Me.Logo0FrameTextBox.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.Logo0FrameTextBox, "Logo0FrameTextBox")
        Me.Logo0FrameTextBox.Name = "Logo0FrameTextBox"
        '
        'LogoGroupBox
        '
        Me.LogoGroupBox.Controls.Add(Me.LogoPanel)
        Me.LogoGroupBox.Controls.Add(Me.LogoCheckBox)
        resources.ApplyResources(Me.LogoGroupBox, "LogoGroupBox")
        Me.LogoGroupBox.Name = "LogoGroupBox"
        Me.LogoGroupBox.TabStop = False
        '
        'LogoPanel
        '
        Me.LogoPanel.Controls.Add(Me.ModeComboBox)
        Me.LogoPanel.Controls.Add(Me.ModeLabel)
        Me.LogoPanel.Controls.Add(Me.LogoTrPaLabel)
        Me.LogoPanel.Controls.Add(Me.GroupBox3)
        Me.LogoPanel.Controls.Add(Me.GroupBox2)
        Me.LogoPanel.Controls.Add(Me.LAlignmentGroupBox)
        Me.LogoPanel.Controls.Add(Me.LogoImgLabel)
        Me.LogoPanel.Controls.Add(Me.fadeoutNumericUpDown)
        Me.LogoPanel.Controls.Add(Me.LSMTextBox)
        Me.LogoPanel.Controls.Add(Me.LSP2Label)
        Me.LogoPanel.Controls.Add(Me.fadeoutLabel)
        Me.LogoPanel.Controls.Add(Me.LSP1Label)
        Me.LogoPanel.Controls.Add(Me.LECheckBox)
        Me.LogoPanel.Controls.Add(Me.fadeinNumericUpDown)
        Me.LogoPanel.Controls.Add(Me.LSHTextBox)
        Me.LogoPanel.Controls.Add(Me.LEHTextBox)
        Me.LogoPanel.Controls.Add(Me.fadeinLabel)
        Me.LogoPanel.Controls.Add(Me.LSCheckBox)
        Me.LogoPanel.Controls.Add(Me.LEP1Label)
        Me.LogoPanel.Controls.Add(Me.FadeCheckBox)
        Me.LogoPanel.Controls.Add(Me.AlphaCheckBox)
        Me.LogoPanel.Controls.Add(Me.LEMTextBox)
        Me.LogoPanel.Controls.Add(Me.LogoTrPaTrackBar)
        Me.LogoPanel.Controls.Add(Me.LogoImgButton)
        Me.LogoPanel.Controls.Add(Me.LEP2Label)
        Me.LogoPanel.Controls.Add(Me.LogoTrPaCheckBox)
        Me.LogoPanel.Controls.Add(Me.LogoImgTextBox)
        Me.LogoPanel.Controls.Add(Me.LSSTextBox)
        Me.LogoPanel.Controls.Add(Me.LESTextBox)
        resources.ApplyResources(Me.LogoPanel, "LogoPanel")
        Me.LogoPanel.Name = "LogoPanel"
        '
        'ModeComboBox
        '
        Me.ModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ModeComboBox.FormattingEnabled = True
        Me.ModeComboBox.Items.AddRange(New Object() {resources.GetString("ModeComboBox.Items"), resources.GetString("ModeComboBox.Items1"), resources.GetString("ModeComboBox.Items2"), resources.GetString("ModeComboBox.Items3"), resources.GetString("ModeComboBox.Items4"), resources.GetString("ModeComboBox.Items5"), resources.GetString("ModeComboBox.Items6"), resources.GetString("ModeComboBox.Items7"), resources.GetString("ModeComboBox.Items8"), resources.GetString("ModeComboBox.Items9"), resources.GetString("ModeComboBox.Items10"), resources.GetString("ModeComboBox.Items11")})
        resources.ApplyResources(Me.ModeComboBox, "ModeComboBox")
        Me.ModeComboBox.Name = "ModeComboBox"
        '
        'ModeLabel
        '
        resources.ApplyResources(Me.ModeLabel, "ModeLabel")
        Me.ModeLabel.Name = "ModeLabel"
        '
        'LogoTrPaLabel
        '
        resources.ApplyResources(Me.LogoTrPaLabel, "LogoTrPaLabel")
        Me.LogoTrPaLabel.Name = "LogoTrPaLabel"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.YNumericUpDown)
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'YNumericUpDown
        '
        resources.ApplyResources(Me.YNumericUpDown, "YNumericUpDown")
        Me.YNumericUpDown.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.YNumericUpDown.Minimum = New Decimal(New Integer() {10000, 0, 0, -2147483648})
        Me.YNumericUpDown.Name = "YNumericUpDown"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.XNumericUpDown)
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'XNumericUpDown
        '
        resources.ApplyResources(Me.XNumericUpDown, "XNumericUpDown")
        Me.XNumericUpDown.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.XNumericUpDown.Minimum = New Decimal(New Integer() {10000, 0, 0, -2147483648})
        Me.XNumericUpDown.Name = "XNumericUpDown"
        '
        'LAlignmentGroupBox
        '
        Me.LAlignmentGroupBox.Controls.Add(Me.LAlignment3RadioButton)
        Me.LAlignmentGroupBox.Controls.Add(Me.LAlignment2RadioButton)
        Me.LAlignmentGroupBox.Controls.Add(Me.LAlignment1RadioButton)
        Me.LAlignmentGroupBox.Controls.Add(Me.LAlignment8RadioButton)
        Me.LAlignmentGroupBox.Controls.Add(Me.LAlignment7RadioButton)
        Me.LAlignmentGroupBox.Controls.Add(Me.LAlignment9RadioButton)
        Me.LAlignmentGroupBox.Controls.Add(Me.LAlignment4RadioButton)
        Me.LAlignmentGroupBox.Controls.Add(Me.LAlignment6RadioButton)
        Me.LAlignmentGroupBox.Controls.Add(Me.LAlignment5RadioButton)
        resources.ApplyResources(Me.LAlignmentGroupBox, "LAlignmentGroupBox")
        Me.LAlignmentGroupBox.Name = "LAlignmentGroupBox"
        Me.LAlignmentGroupBox.TabStop = False
        '
        'LAlignment3RadioButton
        '
        resources.ApplyResources(Me.LAlignment3RadioButton, "LAlignment3RadioButton")
        Me.LAlignment3RadioButton.Name = "LAlignment3RadioButton"
        Me.LAlignment3RadioButton.TabStop = True
        Me.LAlignment3RadioButton.UseVisualStyleBackColor = True
        '
        'LAlignment2RadioButton
        '
        resources.ApplyResources(Me.LAlignment2RadioButton, "LAlignment2RadioButton")
        Me.LAlignment2RadioButton.Name = "LAlignment2RadioButton"
        Me.LAlignment2RadioButton.TabStop = True
        Me.LAlignment2RadioButton.UseVisualStyleBackColor = True
        '
        'LAlignment1RadioButton
        '
        resources.ApplyResources(Me.LAlignment1RadioButton, "LAlignment1RadioButton")
        Me.LAlignment1RadioButton.Name = "LAlignment1RadioButton"
        Me.LAlignment1RadioButton.TabStop = True
        Me.LAlignment1RadioButton.UseVisualStyleBackColor = True
        '
        'LAlignment8RadioButton
        '
        resources.ApplyResources(Me.LAlignment8RadioButton, "LAlignment8RadioButton")
        Me.LAlignment8RadioButton.Name = "LAlignment8RadioButton"
        Me.LAlignment8RadioButton.TabStop = True
        Me.LAlignment8RadioButton.UseVisualStyleBackColor = True
        '
        'LAlignment7RadioButton
        '
        resources.ApplyResources(Me.LAlignment7RadioButton, "LAlignment7RadioButton")
        Me.LAlignment7RadioButton.Name = "LAlignment7RadioButton"
        Me.LAlignment7RadioButton.TabStop = True
        Me.LAlignment7RadioButton.UseVisualStyleBackColor = True
        '
        'LAlignment9RadioButton
        '
        resources.ApplyResources(Me.LAlignment9RadioButton, "LAlignment9RadioButton")
        Me.LAlignment9RadioButton.Name = "LAlignment9RadioButton"
        Me.LAlignment9RadioButton.TabStop = True
        Me.LAlignment9RadioButton.UseVisualStyleBackColor = True
        '
        'LAlignment4RadioButton
        '
        resources.ApplyResources(Me.LAlignment4RadioButton, "LAlignment4RadioButton")
        Me.LAlignment4RadioButton.Name = "LAlignment4RadioButton"
        Me.LAlignment4RadioButton.TabStop = True
        Me.LAlignment4RadioButton.UseVisualStyleBackColor = True
        '
        'LAlignment6RadioButton
        '
        resources.ApplyResources(Me.LAlignment6RadioButton, "LAlignment6RadioButton")
        Me.LAlignment6RadioButton.Name = "LAlignment6RadioButton"
        Me.LAlignment6RadioButton.TabStop = True
        Me.LAlignment6RadioButton.UseVisualStyleBackColor = True
        '
        'LAlignment5RadioButton
        '
        resources.ApplyResources(Me.LAlignment5RadioButton, "LAlignment5RadioButton")
        Me.LAlignment5RadioButton.Name = "LAlignment5RadioButton"
        Me.LAlignment5RadioButton.TabStop = True
        Me.LAlignment5RadioButton.UseVisualStyleBackColor = True
        '
        'LogoImgLabel
        '
        resources.ApplyResources(Me.LogoImgLabel, "LogoImgLabel")
        Me.LogoImgLabel.Name = "LogoImgLabel"
        '
        'fadeoutNumericUpDown
        '
        Me.fadeoutNumericUpDown.DecimalPlaces = 1
        resources.ApplyResources(Me.fadeoutNumericUpDown, "fadeoutNumericUpDown")
        Me.fadeoutNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.fadeoutNumericUpDown.Name = "fadeoutNumericUpDown"
        '
        'LSMTextBox
        '
        Me.LSMTextBox.BackColor = System.Drawing.Color.LightYellow
        resources.ApplyResources(Me.LSMTextBox, "LSMTextBox")
        Me.LSMTextBox.Name = "LSMTextBox"
        '
        'LSP2Label
        '
        resources.ApplyResources(Me.LSP2Label, "LSP2Label")
        Me.LSP2Label.Name = "LSP2Label"
        '
        'fadeoutLabel
        '
        resources.ApplyResources(Me.fadeoutLabel, "fadeoutLabel")
        Me.fadeoutLabel.Name = "fadeoutLabel"
        '
        'LSP1Label
        '
        resources.ApplyResources(Me.LSP1Label, "LSP1Label")
        Me.LSP1Label.Name = "LSP1Label"
        '
        'LECheckBox
        '
        resources.ApplyResources(Me.LECheckBox, "LECheckBox")
        Me.LECheckBox.Name = "LECheckBox"
        Me.LECheckBox.UseVisualStyleBackColor = True
        '
        'fadeinNumericUpDown
        '
        Me.fadeinNumericUpDown.DecimalPlaces = 1
        resources.ApplyResources(Me.fadeinNumericUpDown, "fadeinNumericUpDown")
        Me.fadeinNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.fadeinNumericUpDown.Name = "fadeinNumericUpDown"
        '
        'LSHTextBox
        '
        Me.LSHTextBox.BackColor = System.Drawing.Color.LightYellow
        resources.ApplyResources(Me.LSHTextBox, "LSHTextBox")
        Me.LSHTextBox.Name = "LSHTextBox"
        '
        'LEHTextBox
        '
        Me.LEHTextBox.BackColor = System.Drawing.Color.LightYellow
        resources.ApplyResources(Me.LEHTextBox, "LEHTextBox")
        Me.LEHTextBox.Name = "LEHTextBox"
        '
        'fadeinLabel
        '
        resources.ApplyResources(Me.fadeinLabel, "fadeinLabel")
        Me.fadeinLabel.Name = "fadeinLabel"
        '
        'LSCheckBox
        '
        resources.ApplyResources(Me.LSCheckBox, "LSCheckBox")
        Me.LSCheckBox.Name = "LSCheckBox"
        Me.LSCheckBox.UseVisualStyleBackColor = True
        '
        'LEP1Label
        '
        resources.ApplyResources(Me.LEP1Label, "LEP1Label")
        Me.LEP1Label.Name = "LEP1Label"
        '
        'FadeCheckBox
        '
        resources.ApplyResources(Me.FadeCheckBox, "FadeCheckBox")
        Me.FadeCheckBox.Name = "FadeCheckBox"
        Me.FadeCheckBox.UseVisualStyleBackColor = True
        '
        'AlphaCheckBox
        '
        resources.ApplyResources(Me.AlphaCheckBox, "AlphaCheckBox")
        Me.AlphaCheckBox.Name = "AlphaCheckBox"
        Me.AlphaCheckBox.UseVisualStyleBackColor = True
        '
        'LEMTextBox
        '
        Me.LEMTextBox.BackColor = System.Drawing.Color.LightYellow
        resources.ApplyResources(Me.LEMTextBox, "LEMTextBox")
        Me.LEMTextBox.Name = "LEMTextBox"
        '
        'LogoTrPaTrackBar
        '
        resources.ApplyResources(Me.LogoTrPaTrackBar, "LogoTrPaTrackBar")
        Me.LogoTrPaTrackBar.Maximum = 100
        Me.LogoTrPaTrackBar.Name = "LogoTrPaTrackBar"
        Me.LogoTrPaTrackBar.TickFrequency = 0
        Me.LogoTrPaTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        Me.LogoTrPaTrackBar.Value = 100
        '
        'LogoImgButton
        '
        resources.ApplyResources(Me.LogoImgButton, "LogoImgButton")
        Me.LogoImgButton.Name = "LogoImgButton"
        Me.LogoImgButton.UseVisualStyleBackColor = True
        '
        'LEP2Label
        '
        resources.ApplyResources(Me.LEP2Label, "LEP2Label")
        Me.LEP2Label.Name = "LEP2Label"
        '
        'LogoTrPaCheckBox
        '
        resources.ApplyResources(Me.LogoTrPaCheckBox, "LogoTrPaCheckBox")
        Me.LogoTrPaCheckBox.Name = "LogoTrPaCheckBox"
        Me.LogoTrPaCheckBox.UseVisualStyleBackColor = True
        '
        'LogoImgTextBox
        '
        resources.ApplyResources(Me.LogoImgTextBox, "LogoImgTextBox")
        Me.LogoImgTextBox.Name = "LogoImgTextBox"
        '
        'LSSTextBox
        '
        Me.LSSTextBox.BackColor = System.Drawing.Color.LightYellow
        resources.ApplyResources(Me.LSSTextBox, "LSSTextBox")
        Me.LSSTextBox.Name = "LSSTextBox"
        '
        'LESTextBox
        '
        Me.LESTextBox.BackColor = System.Drawing.Color.LightYellow
        resources.ApplyResources(Me.LESTextBox, "LESTextBox")
        Me.LESTextBox.Name = "LESTextBox"
        '
        'LogoCheckBox
        '
        resources.ApplyResources(Me.LogoCheckBox, "LogoCheckBox")
        Me.LogoCheckBox.Name = "LogoCheckBox"
        Me.LogoCheckBox.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.reverseCheckBox)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'reverseCheckBox
        '
        resources.ApplyResources(Me.reverseCheckBox, "reverseCheckBox")
        Me.reverseCheckBox.Name = "reverseCheckBox"
        Me.reverseCheckBox.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        resources.ApplyResources(Me.OpenFileDialog1, "OpenFileDialog1")
        '
        'ETCPPFrm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.EPP_Panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ETCPPFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.RateGroupBox.ResumeLayout(False)
        Me.RateGroupBox.PerformLayout()
        CType(Me.RateNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPP_Panel.ResumeLayout(False)
        Me.EPP_Panel.PerformLayout()
        Me.LogoGroupBox.ResumeLayout(False)
        Me.LogoGroupBox.PerformLayout()
        Me.LogoPanel.ResumeLayout(False)
        Me.LogoPanel.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.YNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.XNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LAlignmentGroupBox.ResumeLayout(False)
        Me.LAlignmentGroupBox.PerformLayout()
        CType(Me.fadeoutNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fadeinNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogoTrPaTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RateGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents RatePCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents RateCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents RateNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents DefBTN As System.Windows.Forms.Button
    Friend WithEvents OKBTN As System.Windows.Forms.Button
    Friend WithEvents CancelBTN As System.Windows.Forms.Button
    Friend WithEvents EPP_Panel As System.Windows.Forms.Panel
    Friend WithEvents LogoGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents LogoImgButton As System.Windows.Forms.Button
    Friend WithEvents LogoImgTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LogoImgLabel As System.Windows.Forms.Label
    Friend WithEvents LogoCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AlphaCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents LogoTrPaCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents LESTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LSSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LEP2Label As System.Windows.Forms.Label
    Friend WithEvents LEMTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LEP1Label As System.Windows.Forms.Label
    Friend WithEvents LEHTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LECheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents LSP2Label As System.Windows.Forms.Label
    Friend WithEvents LSMTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LSP1Label As System.Windows.Forms.Label
    Friend WithEvents LSHTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LSCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents LogoTrPaTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents fadeoutNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents fadeoutLabel As System.Windows.Forms.Label
    Friend WithEvents fadeinNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents fadeinLabel As System.Windows.Forms.Label
    Friend WithEvents FadeCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Logo3FrameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Logo1FrameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Logo0FrameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LogoPanel As System.Windows.Forms.Panel
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents LAlignmentGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents LAlignment3RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents LAlignment2RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents LAlignment1RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents LAlignment8RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents LAlignment7RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents LAlignment9RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents LAlignment4RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents LAlignment6RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents LAlignment5RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents YNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents XNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents LogoTrPaLabel As System.Windows.Forms.Label
    Friend WithEvents ModeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ModeLabel As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents reverseCheckBox As System.Windows.Forms.CheckBox
End Class
