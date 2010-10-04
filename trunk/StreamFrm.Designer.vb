<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StreamFrm
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
        Me.TPrePanel = New System.Windows.Forms.Panel
        Me.InTPrePanel = New System.Windows.Forms.Panel
        Me.LoadingLabel = New System.Windows.Forms.Label
        Me.PrePanel = New System.Windows.Forms.Panel
        Me.RightPanel = New System.Windows.Forms.Panel
        Me.LeftPanel = New System.Windows.Forms.Panel
        Me.BottomPanel = New System.Windows.Forms.Panel
        Me.TopPanel = New System.Windows.Forms.Panel
        Me.PrePanel1 = New System.Windows.Forms.Panel
        Me.OutputBox_Stream = New System.Windows.Forms.TextBox
        Me.CropGroupBox = New System.Windows.Forms.GroupBox
        Me.SizeTextBox = New System.Windows.Forms.TextBox
        Me.SizeLabel = New System.Windows.Forms.Label
        Me.RightLabel = New System.Windows.Forms.Label
        Me.BottomLabel = New System.Windows.Forms.Label
        Me.TopLabel = New System.Windows.Forms.Label
        Me.LeftLabel = New System.Windows.Forms.Label
        Me.RightNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.TopNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.BottomNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.LeftNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.TimeSpGroupBox = New System.Windows.Forms.GroupBox
        Me.EMSTextBox = New System.Windows.Forms.TextBox
        Me.SMSTextBox = New System.Windows.Forms.TextBox
        Me.ESTextBox = New System.Windows.Forms.TextBox
        Me.SSTextBox = New System.Windows.Forms.TextBox
        Me.ENDCKButton = New System.Windows.Forms.Button
        Me.STRCKButton = New System.Windows.Forms.Button
        Me.EP3Label = New System.Windows.Forms.Label
        Me.EP2Label = New System.Windows.Forms.Label
        Me.EMTextBox = New System.Windows.Forms.TextBox
        Me.EP1Label = New System.Windows.Forms.Label
        Me.EHTextBox = New System.Windows.Forms.TextBox
        Me.ECheckBox = New System.Windows.Forms.CheckBox
        Me.SP3Label = New System.Windows.Forms.Label
        Me.SP2Label = New System.Windows.Forms.Label
        Me.SMTextBox = New System.Windows.Forms.TextBox
        Me.SP1Label = New System.Windows.Forms.Label
        Me.SHTextBox = New System.Windows.Forms.TextBox
        Me.SCheckBox = New System.Windows.Forms.CheckBox
        Me.PreviewGroupBox = New System.Windows.Forms.GroupBox
        Me.PreviewPanel = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.VolTrackBar = New System.Windows.Forms.TrackBar
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.TPanel = New System.Windows.Forms.Panel
        Me.Nowhms = New System.Windows.Forms.Label
        Me.Totalhms = New System.Windows.Forms.Label
        Me.PlayPauseBTN = New System.Windows.Forms.Button
        Me.ForwardBTN = New System.Windows.Forms.Button
        Me.BackwardBTN = New System.Windows.Forms.Button
        Me.StopBTN = New System.Windows.Forms.Button
        Me.FrameStepButton = New System.Windows.Forms.Button
        Me.SeekTrackBar = New System.Windows.Forms.TrackBar
        Me.BackwardTimerM = New System.Windows.Forms.Timer(Me.components)
        Me.ForwardTimerM = New System.Windows.Forms.Timer(Me.components)
        Me.DetailStreamInfoTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ASListBox = New System.Windows.Forms.ListBox
        Me.GETPP = New System.Windows.Forms.Timer(Me.components)
        Me.NowhmsTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SoundM = New System.Windows.Forms.Timer(Me.components)
        Me.StreamSelGroupBox = New System.Windows.Forms.GroupBox
        Me.AudioComboBox = New System.Windows.Forms.ComboBox
        Me.SeekTimer = New System.Windows.Forms.Timer(Me.components)
        Me.BPanel = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.CropButton = New System.Windows.Forms.Button
        Me.TimeSpButton = New System.Windows.Forms.Button
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.CancelBTN = New System.Windows.Forms.Button
        Me.OKBTN = New System.Windows.Forms.Button
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.OptsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AllChToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LeftChToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RightChToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.SizeOriginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AspectOriginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.scaletempoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.extrastereoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.karaokeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VisualizeMotionVectorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VisualizeBlockTypesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FFmpegDeinterlacerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SpDfToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SpDnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SpDuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SpeedXVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.TPrePanel.SuspendLayout()
        Me.InTPrePanel.SuspendLayout()
        Me.PrePanel.SuspendLayout()
        Me.CropGroupBox.SuspendLayout()
        CType(Me.RightNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BottomNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TimeSpGroupBox.SuspendLayout()
        Me.PreviewGroupBox.SuspendLayout()
        Me.PreviewPanel.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.VolTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TPanel.SuspendLayout()
        CType(Me.SeekTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StreamSelGroupBox.SuspendLayout()
        Me.BPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TPrePanel
        '
        Me.TPrePanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TPrePanel.BackColor = System.Drawing.Color.Gray
        Me.TPrePanel.Controls.Add(Me.InTPrePanel)
        Me.TPrePanel.Controls.Add(Me.CropGroupBox)
        Me.TPrePanel.Controls.Add(Me.TimeSpGroupBox)
        Me.TPrePanel.Location = New System.Drawing.Point(12, 19)
        Me.TPrePanel.Name = "TPrePanel"
        Me.TPrePanel.Size = New System.Drawing.Size(384, 216)
        Me.TPrePanel.TabIndex = 0
        '
        'InTPrePanel
        '
        Me.InTPrePanel.Controls.Add(Me.LoadingLabel)
        Me.InTPrePanel.Controls.Add(Me.PrePanel)
        Me.InTPrePanel.Controls.Add(Me.OutputBox_Stream)
        Me.InTPrePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InTPrePanel.Location = New System.Drawing.Point(0, 0)
        Me.InTPrePanel.Name = "InTPrePanel"
        Me.InTPrePanel.Size = New System.Drawing.Size(384, 56)
        Me.InTPrePanel.TabIndex = 34
        '
        'LoadingLabel
        '
        Me.LoadingLabel.AutoSize = True
        Me.LoadingLabel.Font = New System.Drawing.Font("굴림", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.LoadingLabel.ForeColor = System.Drawing.Color.White
        Me.LoadingLabel.Location = New System.Drawing.Point(10, 10)
        Me.LoadingLabel.Name = "LoadingLabel"
        Me.LoadingLabel.Size = New System.Drawing.Size(150, 27)
        Me.LoadingLabel.TabIndex = 23
        Me.LoadingLabel.Text = "Loading..."
        Me.LoadingLabel.Visible = False
        '
        'PrePanel
        '
        Me.PrePanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrePanel.Controls.Add(Me.RightPanel)
        Me.PrePanel.Controls.Add(Me.LeftPanel)
        Me.PrePanel.Controls.Add(Me.BottomPanel)
        Me.PrePanel.Controls.Add(Me.TopPanel)
        Me.PrePanel.Controls.Add(Me.PrePanel1)
        Me.PrePanel.Location = New System.Drawing.Point(0, 0)
        Me.PrePanel.Name = "PrePanel"
        Me.PrePanel.Size = New System.Drawing.Size(292, 28)
        Me.PrePanel.TabIndex = 0
        Me.PrePanel.Visible = False
        '
        'RightPanel
        '
        Me.RightPanel.BackColor = System.Drawing.Color.White
        Me.RightPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightPanel.Location = New System.Drawing.Point(282, 10)
        Me.RightPanel.Name = "RightPanel"
        Me.RightPanel.Size = New System.Drawing.Size(10, 7)
        Me.RightPanel.TabIndex = 39
        '
        'LeftPanel
        '
        Me.LeftPanel.BackColor = System.Drawing.Color.White
        Me.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftPanel.Location = New System.Drawing.Point(0, 10)
        Me.LeftPanel.Name = "LeftPanel"
        Me.LeftPanel.Size = New System.Drawing.Size(10, 7)
        Me.LeftPanel.TabIndex = 38
        '
        'BottomPanel
        '
        Me.BottomPanel.BackColor = System.Drawing.Color.White
        Me.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomPanel.Location = New System.Drawing.Point(0, 17)
        Me.BottomPanel.Name = "BottomPanel"
        Me.BottomPanel.Size = New System.Drawing.Size(292, 11)
        Me.BottomPanel.TabIndex = 37
        '
        'TopPanel
        '
        Me.TopPanel.BackColor = System.Drawing.Color.White
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(292, 10)
        Me.TopPanel.TabIndex = 36
        '
        'PrePanel1
        '
        Me.PrePanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrePanel1.Location = New System.Drawing.Point(0, 0)
        Me.PrePanel1.Name = "PrePanel1"
        Me.PrePanel1.Size = New System.Drawing.Size(207, 25)
        Me.PrePanel1.TabIndex = 34
        '
        'OutputBox_Stream
        '
        Me.OutputBox_Stream.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OutputBox_Stream.BackColor = System.Drawing.Color.Gray
        Me.OutputBox_Stream.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.OutputBox_Stream.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.OutputBox_Stream.ForeColor = System.Drawing.Color.White
        Me.OutputBox_Stream.Location = New System.Drawing.Point(16, 50)
        Me.OutputBox_Stream.MaxLength = 2147483647
        Me.OutputBox_Stream.Multiline = True
        Me.OutputBox_Stream.Name = "OutputBox_Stream"
        Me.OutputBox_Stream.ReadOnly = True
        Me.OutputBox_Stream.Size = New System.Drawing.Size(351, 10)
        Me.OutputBox_Stream.TabIndex = 22
        Me.OutputBox_Stream.Visible = False
        '
        'CropGroupBox
        '
        Me.CropGroupBox.BackColor = System.Drawing.SystemColors.Control
        Me.CropGroupBox.Controls.Add(Me.SizeTextBox)
        Me.CropGroupBox.Controls.Add(Me.SizeLabel)
        Me.CropGroupBox.Controls.Add(Me.RightLabel)
        Me.CropGroupBox.Controls.Add(Me.BottomLabel)
        Me.CropGroupBox.Controls.Add(Me.TopLabel)
        Me.CropGroupBox.Controls.Add(Me.LeftLabel)
        Me.CropGroupBox.Controls.Add(Me.RightNumericUpDown)
        Me.CropGroupBox.Controls.Add(Me.TopNumericUpDown)
        Me.CropGroupBox.Controls.Add(Me.BottomNumericUpDown)
        Me.CropGroupBox.Controls.Add(Me.LeftNumericUpDown)
        Me.CropGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CropGroupBox.Location = New System.Drawing.Point(0, 56)
        Me.CropGroupBox.Name = "CropGroupBox"
        Me.CropGroupBox.Size = New System.Drawing.Size(384, 80)
        Me.CropGroupBox.TabIndex = 33
        Me.CropGroupBox.TabStop = False
        Me.CropGroupBox.Text = "잘라내기"
        Me.CropGroupBox.Visible = False
        '
        'SizeTextBox
        '
        Me.SizeTextBox.Location = New System.Drawing.Point(282, 41)
        Me.SizeTextBox.Name = "SizeTextBox"
        Me.SizeTextBox.ReadOnly = True
        Me.SizeTextBox.Size = New System.Drawing.Size(85, 21)
        Me.SizeTextBox.TabIndex = 12
        Me.SizeTextBox.Text = "0x0"
        Me.SizeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SizeLabel
        '
        Me.SizeLabel.AutoSize = True
        Me.SizeLabel.Location = New System.Drawing.Point(280, 23)
        Me.SizeLabel.Name = "SizeLabel"
        Me.SizeLabel.Size = New System.Drawing.Size(45, 12)
        Me.SizeLabel.TabIndex = 11
        Me.SizeLabel.Text = "사이즈:"
        '
        'RightLabel
        '
        Me.RightLabel.AutoSize = True
        Me.RightLabel.Location = New System.Drawing.Point(209, 23)
        Me.RightLabel.Name = "RightLabel"
        Me.RightLabel.Size = New System.Drawing.Size(21, 12)
        Me.RightLabel.TabIndex = 10
        Me.RightLabel.Text = "우:"
        '
        'BottomLabel
        '
        Me.BottomLabel.AutoSize = True
        Me.BottomLabel.Location = New System.Drawing.Point(149, 23)
        Me.BottomLabel.Name = "BottomLabel"
        Me.BottomLabel.Size = New System.Drawing.Size(21, 12)
        Me.BottomLabel.TabIndex = 9
        Me.BottomLabel.Text = "하:"
        '
        'TopLabel
        '
        Me.TopLabel.AutoSize = True
        Me.TopLabel.Location = New System.Drawing.Point(82, 23)
        Me.TopLabel.Name = "TopLabel"
        Me.TopLabel.Size = New System.Drawing.Size(21, 12)
        Me.TopLabel.TabIndex = 8
        Me.TopLabel.Text = "상:"
        '
        'LeftLabel
        '
        Me.LeftLabel.AutoSize = True
        Me.LeftLabel.Location = New System.Drawing.Point(19, 23)
        Me.LeftLabel.Name = "LeftLabel"
        Me.LeftLabel.Size = New System.Drawing.Size(21, 12)
        Me.LeftLabel.TabIndex = 7
        Me.LeftLabel.Text = "좌:"
        '
        'RightNumericUpDown
        '
        Me.RightNumericUpDown.Location = New System.Drawing.Point(212, 41)
        Me.RightNumericUpDown.Name = "RightNumericUpDown"
        Me.RightNumericUpDown.Size = New System.Drawing.Size(58, 21)
        Me.RightNumericUpDown.TabIndex = 6
        Me.RightNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TopNumericUpDown
        '
        Me.TopNumericUpDown.Location = New System.Drawing.Point(84, 41)
        Me.TopNumericUpDown.Name = "TopNumericUpDown"
        Me.TopNumericUpDown.Size = New System.Drawing.Size(58, 21)
        Me.TopNumericUpDown.TabIndex = 4
        Me.TopNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BottomNumericUpDown
        '
        Me.BottomNumericUpDown.Location = New System.Drawing.Point(148, 41)
        Me.BottomNumericUpDown.Name = "BottomNumericUpDown"
        Me.BottomNumericUpDown.Size = New System.Drawing.Size(58, 21)
        Me.BottomNumericUpDown.TabIndex = 2
        Me.BottomNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LeftNumericUpDown
        '
        Me.LeftNumericUpDown.Location = New System.Drawing.Point(20, 41)
        Me.LeftNumericUpDown.Name = "LeftNumericUpDown"
        Me.LeftNumericUpDown.Size = New System.Drawing.Size(58, 21)
        Me.LeftNumericUpDown.TabIndex = 0
        Me.LeftNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TimeSpGroupBox
        '
        Me.TimeSpGroupBox.BackColor = System.Drawing.SystemColors.Control
        Me.TimeSpGroupBox.Controls.Add(Me.EMSTextBox)
        Me.TimeSpGroupBox.Controls.Add(Me.SMSTextBox)
        Me.TimeSpGroupBox.Controls.Add(Me.ESTextBox)
        Me.TimeSpGroupBox.Controls.Add(Me.SSTextBox)
        Me.TimeSpGroupBox.Controls.Add(Me.ENDCKButton)
        Me.TimeSpGroupBox.Controls.Add(Me.STRCKButton)
        Me.TimeSpGroupBox.Controls.Add(Me.EP3Label)
        Me.TimeSpGroupBox.Controls.Add(Me.EP2Label)
        Me.TimeSpGroupBox.Controls.Add(Me.EMTextBox)
        Me.TimeSpGroupBox.Controls.Add(Me.EP1Label)
        Me.TimeSpGroupBox.Controls.Add(Me.EHTextBox)
        Me.TimeSpGroupBox.Controls.Add(Me.ECheckBox)
        Me.TimeSpGroupBox.Controls.Add(Me.SP3Label)
        Me.TimeSpGroupBox.Controls.Add(Me.SP2Label)
        Me.TimeSpGroupBox.Controls.Add(Me.SMTextBox)
        Me.TimeSpGroupBox.Controls.Add(Me.SP1Label)
        Me.TimeSpGroupBox.Controls.Add(Me.SHTextBox)
        Me.TimeSpGroupBox.Controls.Add(Me.SCheckBox)
        Me.TimeSpGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TimeSpGroupBox.Location = New System.Drawing.Point(0, 136)
        Me.TimeSpGroupBox.Name = "TimeSpGroupBox"
        Me.TimeSpGroupBox.Size = New System.Drawing.Size(384, 80)
        Me.TimeSpGroupBox.TabIndex = 27
        Me.TimeSpGroupBox.TabStop = False
        Me.TimeSpGroupBox.Text = "구간 설정"
        Me.TimeSpGroupBox.Visible = False
        '
        'EMSTextBox
        '
        Me.EMSTextBox.Enabled = False
        Me.EMSTextBox.Location = New System.Drawing.Point(247, 47)
        Me.EMSTextBox.MaxLength = 2
        Me.EMSTextBox.Name = "EMSTextBox"
        Me.EMSTextBox.Size = New System.Drawing.Size(31, 21)
        Me.EMSTextBox.TabIndex = 45
        Me.EMSTextBox.Text = "00"
        Me.EMSTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SMSTextBox
        '
        Me.SMSTextBox.Enabled = False
        Me.SMSTextBox.Location = New System.Drawing.Point(247, 21)
        Me.SMSTextBox.MaxLength = 2
        Me.SMSTextBox.Name = "SMSTextBox"
        Me.SMSTextBox.Size = New System.Drawing.Size(31, 21)
        Me.SMSTextBox.TabIndex = 37
        Me.SMSTextBox.Text = "00"
        Me.SMSTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ESTextBox
        '
        Me.ESTextBox.BackColor = System.Drawing.Color.LightYellow
        Me.ESTextBox.Enabled = False
        Me.ESTextBox.Location = New System.Drawing.Point(199, 47)
        Me.ESTextBox.MaxLength = 2
        Me.ESTextBox.Name = "ESTextBox"
        Me.ESTextBox.Size = New System.Drawing.Size(31, 21)
        Me.ESTextBox.TabIndex = 43
        Me.ESTextBox.Text = "00"
        Me.ESTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SSTextBox
        '
        Me.SSTextBox.BackColor = System.Drawing.Color.LightYellow
        Me.SSTextBox.Enabled = False
        Me.SSTextBox.Location = New System.Drawing.Point(199, 21)
        Me.SSTextBox.MaxLength = 2
        Me.SSTextBox.Name = "SSTextBox"
        Me.SSTextBox.Size = New System.Drawing.Size(31, 21)
        Me.SSTextBox.TabIndex = 35
        Me.SSTextBox.Text = "00"
        Me.SSTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ENDCKButton
        '
        Me.ENDCKButton.Location = New System.Drawing.Point(281, 46)
        Me.ENDCKButton.Name = "ENDCKButton"
        Me.ENDCKButton.Size = New System.Drawing.Size(92, 23)
        Me.ENDCKButton.TabIndex = 47
        Me.ENDCKButton.Text = "구간표시"
        Me.ENDCKButton.UseVisualStyleBackColor = True
        '
        'STRCKButton
        '
        Me.STRCKButton.Location = New System.Drawing.Point(281, 20)
        Me.STRCKButton.Name = "STRCKButton"
        Me.STRCKButton.Size = New System.Drawing.Size(92, 23)
        Me.STRCKButton.TabIndex = 46
        Me.STRCKButton.Text = "구간표시"
        Me.STRCKButton.UseVisualStyleBackColor = True
        '
        'EP3Label
        '
        Me.EP3Label.AutoSize = True
        Me.EP3Label.Enabled = False
        Me.EP3Label.Location = New System.Drawing.Point(233, 51)
        Me.EP3Label.Name = "EP3Label"
        Me.EP3Label.Size = New System.Drawing.Size(11, 12)
        Me.EP3Label.TabIndex = 44
        Me.EP3Label.Text = "/"
        '
        'EP2Label
        '
        Me.EP2Label.AutoSize = True
        Me.EP2Label.Enabled = False
        Me.EP2Label.Location = New System.Drawing.Point(188, 50)
        Me.EP2Label.Name = "EP2Label"
        Me.EP2Label.Size = New System.Drawing.Size(9, 12)
        Me.EP2Label.TabIndex = 42
        Me.EP2Label.Text = ":"
        '
        'EMTextBox
        '
        Me.EMTextBox.BackColor = System.Drawing.Color.LightYellow
        Me.EMTextBox.Enabled = False
        Me.EMTextBox.Location = New System.Drawing.Point(154, 47)
        Me.EMTextBox.MaxLength = 2
        Me.EMTextBox.Name = "EMTextBox"
        Me.EMTextBox.Size = New System.Drawing.Size(31, 21)
        Me.EMTextBox.TabIndex = 41
        Me.EMTextBox.Text = "00"
        Me.EMTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EP1Label
        '
        Me.EP1Label.AutoSize = True
        Me.EP1Label.Enabled = False
        Me.EP1Label.Location = New System.Drawing.Point(142, 50)
        Me.EP1Label.Name = "EP1Label"
        Me.EP1Label.Size = New System.Drawing.Size(9, 12)
        Me.EP1Label.TabIndex = 40
        Me.EP1Label.Text = ":"
        '
        'EHTextBox
        '
        Me.EHTextBox.BackColor = System.Drawing.Color.LightYellow
        Me.EHTextBox.Enabled = False
        Me.EHTextBox.Location = New System.Drawing.Point(110, 47)
        Me.EHTextBox.MaxLength = 2
        Me.EHTextBox.Name = "EHTextBox"
        Me.EHTextBox.Size = New System.Drawing.Size(31, 21)
        Me.EHTextBox.TabIndex = 39
        Me.EHTextBox.Text = "00"
        Me.EHTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ECheckBox
        '
        Me.ECheckBox.AutoSize = True
        Me.ECheckBox.Location = New System.Drawing.Point(12, 51)
        Me.ECheckBox.Name = "ECheckBox"
        Me.ECheckBox.Size = New System.Drawing.Size(72, 16)
        Me.ECheckBox.TabIndex = 38
        Me.ECheckBox.Text = "종료시간"
        Me.ECheckBox.UseVisualStyleBackColor = True
        '
        'SP3Label
        '
        Me.SP3Label.AutoSize = True
        Me.SP3Label.Enabled = False
        Me.SP3Label.Location = New System.Drawing.Point(233, 25)
        Me.SP3Label.Name = "SP3Label"
        Me.SP3Label.Size = New System.Drawing.Size(11, 12)
        Me.SP3Label.TabIndex = 36
        Me.SP3Label.Text = "/"
        '
        'SP2Label
        '
        Me.SP2Label.AutoSize = True
        Me.SP2Label.Enabled = False
        Me.SP2Label.Location = New System.Drawing.Point(188, 24)
        Me.SP2Label.Name = "SP2Label"
        Me.SP2Label.Size = New System.Drawing.Size(9, 12)
        Me.SP2Label.TabIndex = 34
        Me.SP2Label.Text = ":"
        '
        'SMTextBox
        '
        Me.SMTextBox.BackColor = System.Drawing.Color.LightYellow
        Me.SMTextBox.Enabled = False
        Me.SMTextBox.Location = New System.Drawing.Point(154, 21)
        Me.SMTextBox.MaxLength = 2
        Me.SMTextBox.Name = "SMTextBox"
        Me.SMTextBox.Size = New System.Drawing.Size(31, 21)
        Me.SMTextBox.TabIndex = 33
        Me.SMTextBox.Text = "00"
        Me.SMTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SP1Label
        '
        Me.SP1Label.AutoSize = True
        Me.SP1Label.Enabled = False
        Me.SP1Label.Location = New System.Drawing.Point(142, 24)
        Me.SP1Label.Name = "SP1Label"
        Me.SP1Label.Size = New System.Drawing.Size(9, 12)
        Me.SP1Label.TabIndex = 32
        Me.SP1Label.Text = ":"
        '
        'SHTextBox
        '
        Me.SHTextBox.BackColor = System.Drawing.Color.LightYellow
        Me.SHTextBox.Enabled = False
        Me.SHTextBox.Location = New System.Drawing.Point(110, 21)
        Me.SHTextBox.MaxLength = 2
        Me.SHTextBox.Name = "SHTextBox"
        Me.SHTextBox.Size = New System.Drawing.Size(31, 21)
        Me.SHTextBox.TabIndex = 31
        Me.SHTextBox.Text = "00"
        Me.SHTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SCheckBox
        '
        Me.SCheckBox.AutoSize = True
        Me.SCheckBox.Location = New System.Drawing.Point(12, 25)
        Me.SCheckBox.Name = "SCheckBox"
        Me.SCheckBox.Size = New System.Drawing.Size(72, 16)
        Me.SCheckBox.TabIndex = 30
        Me.SCheckBox.Text = "시작시간"
        Me.SCheckBox.UseVisualStyleBackColor = True
        '
        'PreviewGroupBox
        '
        Me.PreviewGroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PreviewGroupBox.Controls.Add(Me.TPrePanel)
        Me.PreviewGroupBox.Controls.Add(Me.PreviewPanel)
        Me.PreviewGroupBox.Location = New System.Drawing.Point(12, 30)
        Me.PreviewGroupBox.Name = "PreviewGroupBox"
        Me.PreviewGroupBox.Size = New System.Drawing.Size(408, 303)
        Me.PreviewGroupBox.TabIndex = 23
        Me.PreviewGroupBox.TabStop = False
        Me.PreviewGroupBox.Text = "원본 파일 보기"
        '
        'PreviewPanel
        '
        Me.PreviewPanel.Controls.Add(Me.Panel5)
        Me.PreviewPanel.Controls.Add(Me.Panel3)
        Me.PreviewPanel.Controls.Add(Me.SeekTrackBar)
        Me.PreviewPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PreviewPanel.Location = New System.Drawing.Point(3, 240)
        Me.PreviewPanel.Name = "PreviewPanel"
        Me.PreviewPanel.Size = New System.Drawing.Size(402, 60)
        Me.PreviewPanel.TabIndex = 31
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.VolTrackBar)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(311, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(91, 25)
        Me.Panel5.TabIndex = 32
        '
        'VolTrackBar
        '
        Me.VolTrackBar.AutoSize = False
        Me.VolTrackBar.Enabled = False
        Me.VolTrackBar.LargeChange = 0
        Me.VolTrackBar.Location = New System.Drawing.Point(2, 2)
        Me.VolTrackBar.Maximum = 100
        Me.VolTrackBar.Name = "VolTrackBar"
        Me.VolTrackBar.Size = New System.Drawing.Size(87, 23)
        Me.VolTrackBar.SmallChange = 0
        Me.VolTrackBar.TabIndex = 28
        Me.VolTrackBar.TickFrequency = 10
        Me.VolTrackBar.Value = 100
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.PlayPauseBTN)
        Me.Panel3.Controls.Add(Me.ForwardBTN)
        Me.Panel3.Controls.Add(Me.BackwardBTN)
        Me.Panel3.Controls.Add(Me.StopBTN)
        Me.Panel3.Controls.Add(Me.FrameStepButton)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 25)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(402, 35)
        Me.Panel3.TabIndex = 31
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.Controls.Add(Me.TPanel)
        Me.Panel4.Location = New System.Drawing.Point(213, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(189, 35)
        Me.Panel4.TabIndex = 31
        '
        'TPanel
        '
        Me.TPanel.Controls.Add(Me.Nowhms)
        Me.TPanel.Controls.Add(Me.Totalhms)
        Me.TPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TPanel.Location = New System.Drawing.Point(0, 13)
        Me.TPanel.Name = "TPanel"
        Me.TPanel.Size = New System.Drawing.Size(189, 22)
        Me.TPanel.TabIndex = 31
        '
        'Nowhms
        '
        Me.Nowhms.AutoSize = True
        Me.Nowhms.Dock = System.Windows.Forms.DockStyle.Right
        Me.Nowhms.Enabled = False
        Me.Nowhms.Location = New System.Drawing.Point(45, 0)
        Me.Nowhms.Name = "Nowhms"
        Me.Nowhms.Size = New System.Drawing.Size(65, 12)
        Me.Nowhms.TabIndex = 26
        Me.Nowhms.Text = "00:00:00.00"
        Me.Nowhms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Totalhms
        '
        Me.Totalhms.AutoSize = True
        Me.Totalhms.Dock = System.Windows.Forms.DockStyle.Right
        Me.Totalhms.Enabled = False
        Me.Totalhms.Location = New System.Drawing.Point(110, 0)
        Me.Totalhms.Name = "Totalhms"
        Me.Totalhms.Size = New System.Drawing.Size(79, 12)
        Me.Totalhms.TabIndex = 30
        Me.Totalhms.Text = "/ 00:00:00.00 "
        Me.Totalhms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PlayPauseBTN
        '
        Me.PlayPauseBTN.Location = New System.Drawing.Point(9, 4)
        Me.PlayPauseBTN.Name = "PlayPauseBTN"
        Me.PlayPauseBTN.Size = New System.Drawing.Size(42, 25)
        Me.PlayPauseBTN.TabIndex = 24
        Me.PlayPauseBTN.Text = ">||"
        Me.PlayPauseBTN.UseVisualStyleBackColor = True
        '
        'ForwardBTN
        '
        Me.ForwardBTN.Enabled = False
        Me.ForwardBTN.Location = New System.Drawing.Point(135, 4)
        Me.ForwardBTN.Name = "ForwardBTN"
        Me.ForwardBTN.Size = New System.Drawing.Size(28, 25)
        Me.ForwardBTN.TabIndex = 27
        Me.ForwardBTN.Text = ">"
        Me.ForwardBTN.UseVisualStyleBackColor = True
        '
        'BackwardBTN
        '
        Me.BackwardBTN.Enabled = False
        Me.BackwardBTN.Location = New System.Drawing.Point(101, 4)
        Me.BackwardBTN.Name = "BackwardBTN"
        Me.BackwardBTN.Size = New System.Drawing.Size(28, 25)
        Me.BackwardBTN.TabIndex = 26
        Me.BackwardBTN.Text = "<"
        Me.BackwardBTN.UseVisualStyleBackColor = True
        '
        'StopBTN
        '
        Me.StopBTN.Enabled = False
        Me.StopBTN.Location = New System.Drawing.Point(56, 4)
        Me.StopBTN.Name = "StopBTN"
        Me.StopBTN.Size = New System.Drawing.Size(28, 25)
        Me.StopBTN.TabIndex = 25
        Me.StopBTN.Text = "[]"
        Me.StopBTN.UseVisualStyleBackColor = True
        '
        'FrameStepButton
        '
        Me.FrameStepButton.Enabled = False
        Me.FrameStepButton.Location = New System.Drawing.Point(169, 4)
        Me.FrameStepButton.Name = "FrameStepButton"
        Me.FrameStepButton.Size = New System.Drawing.Size(28, 25)
        Me.FrameStepButton.TabIndex = 29
        Me.FrameStepButton.Text = "."
        Me.FrameStepButton.UseVisualStyleBackColor = True
        '
        'SeekTrackBar
        '
        Me.SeekTrackBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeekTrackBar.AutoSize = False
        Me.SeekTrackBar.Enabled = False
        Me.SeekTrackBar.LargeChange = 0
        Me.SeekTrackBar.Location = New System.Drawing.Point(2, 2)
        Me.SeekTrackBar.Maximum = 100
        Me.SeekTrackBar.Name = "SeekTrackBar"
        Me.SeekTrackBar.Size = New System.Drawing.Size(308, 22)
        Me.SeekTrackBar.SmallChange = 0
        Me.SeekTrackBar.TabIndex = 29
        Me.SeekTrackBar.TickFrequency = 0
        Me.SeekTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'BackwardTimerM
        '
        '
        'ForwardTimerM
        '
        '
        'DetailStreamInfoTimer
        '
        Me.DetailStreamInfoTimer.Interval = 1
        '
        'ASListBox
        '
        Me.ASListBox.FormattingEnabled = True
        Me.ASListBox.ItemHeight = 12
        Me.ASListBox.Location = New System.Drawing.Point(12, 8)
        Me.ASListBox.Name = "ASListBox"
        Me.ASListBox.Size = New System.Drawing.Size(75, 16)
        Me.ASListBox.TabIndex = 25
        Me.ASListBox.Visible = False
        '
        'GETPP
        '
        '
        'NowhmsTimer
        '
        Me.NowhmsTimer.Enabled = True
        Me.NowhmsTimer.Interval = 1
        '
        'SoundM
        '
        '
        'StreamSelGroupBox
        '
        Me.StreamSelGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StreamSelGroupBox.Controls.Add(Me.AudioComboBox)
        Me.StreamSelGroupBox.Location = New System.Drawing.Point(12, 8)
        Me.StreamSelGroupBox.Name = "StreamSelGroupBox"
        Me.StreamSelGroupBox.Size = New System.Drawing.Size(408, 50)
        Me.StreamSelGroupBox.TabIndex = 28
        Me.StreamSelGroupBox.TabStop = False
        Me.StreamSelGroupBox.Text = "스트림 선택"
        '
        'AudioComboBox
        '
        Me.AudioComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AudioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AudioComboBox.Enabled = False
        Me.AudioComboBox.FormattingEnabled = True
        Me.AudioComboBox.Location = New System.Drawing.Point(11, 19)
        Me.AudioComboBox.Name = "AudioComboBox"
        Me.AudioComboBox.Size = New System.Drawing.Size(385, 20)
        Me.AudioComboBox.TabIndex = 0
        '
        'SeekTimer
        '
        Me.SeekTimer.Interval = 1
        '
        'BPanel
        '
        Me.BPanel.Controls.Add(Me.Panel2)
        Me.BPanel.Controls.Add(Me.StreamSelGroupBox)
        Me.BPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BPanel.Location = New System.Drawing.Point(0, 331)
        Me.BPanel.Name = "BPanel"
        Me.BPanel.Size = New System.Drawing.Size(434, 99)
        Me.BPanel.TabIndex = 29
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CropButton)
        Me.Panel2.Controls.Add(Me.TimeSpButton)
        Me.Panel2.Controls.Add(Me.ASListBox)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 63)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(434, 36)
        Me.Panel2.TabIndex = 31
        '
        'CropButton
        '
        Me.CropButton.Location = New System.Drawing.Point(117, 5)
        Me.CropButton.Name = "CropButton"
        Me.CropButton.Size = New System.Drawing.Size(90, 25)
        Me.CropButton.TabIndex = 33
        Me.CropButton.Text = "잘라내기"
        Me.CropButton.UseVisualStyleBackColor = True
        '
        'TimeSpButton
        '
        Me.TimeSpButton.Location = New System.Drawing.Point(11, 5)
        Me.TimeSpButton.Name = "TimeSpButton"
        Me.TimeSpButton.Size = New System.Drawing.Size(100, 25)
        Me.TimeSpButton.TabIndex = 32
        Me.TimeSpButton.Text = "구간 설정"
        Me.TimeSpButton.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.CancelBTN)
        Me.Panel6.Controls.Add(Me.OKBTN)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(226, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(208, 36)
        Me.Panel6.TabIndex = 31
        '
        'CancelBTN
        '
        Me.CancelBTN.Location = New System.Drawing.Point(108, 5)
        Me.CancelBTN.Name = "CancelBTN"
        Me.CancelBTN.Size = New System.Drawing.Size(88, 25)
        Me.CancelBTN.TabIndex = 29
        Me.CancelBTN.Text = "취소"
        Me.CancelBTN.UseVisualStyleBackColor = True
        '
        'OKBTN
        '
        Me.OKBTN.Location = New System.Drawing.Point(11, 5)
        Me.OKBTN.Name = "OKBTN"
        Me.OKBTN.Size = New System.Drawing.Size(88, 25)
        Me.OKBTN.TabIndex = 30
        Me.OKBTN.Text = "확인"
        Me.OKBTN.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptsToolStripMenuItem, Me.SpDfToolStripMenuItem, Me.SpDnToolStripMenuItem, Me.SpDuToolStripMenuItem, Me.SpeedXVToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(434, 24)
        Me.MenuStrip1.TabIndex = 32
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OptsToolStripMenuItem
        '
        Me.OptsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllChToolStripMenuItem, Me.LeftChToolStripMenuItem, Me.RightChToolStripMenuItem, Me.ToolStripMenuItem2, Me.SizeOriginToolStripMenuItem, Me.AspectOriginToolStripMenuItem, Me.ToolStripMenuItem1, Me.scaletempoToolStripMenuItem, Me.extrastereoToolStripMenuItem, Me.karaokeToolStripMenuItem, Me.VisualizeMotionVectorsToolStripMenuItem, Me.VisualizeBlockTypesToolStripMenuItem, Me.FFmpegDeinterlacerToolStripMenuItem})
        Me.OptsToolStripMenuItem.Name = "OptsToolStripMenuItem"
        Me.OptsToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.OptsToolStripMenuItem.Text = "재생옵션(&O)"
        '
        'AllChToolStripMenuItem
        '
        Me.AllChToolStripMenuItem.Checked = True
        Me.AllChToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AllChToolStripMenuItem.Name = "AllChToolStripMenuItem"
        Me.AllChToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.AllChToolStripMenuItem.Text = "모든 채널"
        '
        'LeftChToolStripMenuItem
        '
        Me.LeftChToolStripMenuItem.Name = "LeftChToolStripMenuItem"
        Me.LeftChToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.LeftChToolStripMenuItem.Text = "좌측 채널"
        '
        'RightChToolStripMenuItem
        '
        Me.RightChToolStripMenuItem.Name = "RightChToolStripMenuItem"
        Me.RightChToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.RightChToolStripMenuItem.Text = "우측 채널"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(190, 6)
        '
        'SizeOriginToolStripMenuItem
        '
        Me.SizeOriginToolStripMenuItem.Name = "SizeOriginToolStripMenuItem"
        Me.SizeOriginToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.SizeOriginToolStripMenuItem.Text = "원본 사이즈"
        '
        'AspectOriginToolStripMenuItem
        '
        Me.AspectOriginToolStripMenuItem.Checked = True
        Me.AspectOriginToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AspectOriginToolStripMenuItem.Name = "AspectOriginToolStripMenuItem"
        Me.AspectOriginToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.AspectOriginToolStripMenuItem.Text = "원본 비율로 유지"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(190, 6)
        '
        'scaletempoToolStripMenuItem
        '
        Me.scaletempoToolStripMenuItem.CheckOnClick = True
        Me.scaletempoToolStripMenuItem.Name = "scaletempoToolStripMenuItem"
        Me.scaletempoToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.scaletempoToolStripMenuItem.Text = "피치 보정"
        '
        'extrastereoToolStripMenuItem
        '
        Me.extrastereoToolStripMenuItem.CheckOnClick = True
        Me.extrastereoToolStripMenuItem.Name = "extrastereoToolStripMenuItem"
        Me.extrastereoToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.extrastereoToolStripMenuItem.Text = "엑스트라 스테레오"
        '
        'karaokeToolStripMenuItem
        '
        Me.karaokeToolStripMenuItem.CheckOnClick = True
        Me.karaokeToolStripMenuItem.Name = "karaokeToolStripMenuItem"
        Me.karaokeToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.karaokeToolStripMenuItem.Text = "목소리 제거"
        '
        'VisualizeMotionVectorsToolStripMenuItem
        '
        Me.VisualizeMotionVectorsToolStripMenuItem.CheckOnClick = True
        Me.VisualizeMotionVectorsToolStripMenuItem.Name = "VisualizeMotionVectorsToolStripMenuItem"
        Me.VisualizeMotionVectorsToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.VisualizeMotionVectorsToolStripMenuItem.Text = "벡터 보기"
        '
        'VisualizeBlockTypesToolStripMenuItem
        '
        Me.VisualizeBlockTypesToolStripMenuItem.CheckOnClick = True
        Me.VisualizeBlockTypesToolStripMenuItem.Name = "VisualizeBlockTypesToolStripMenuItem"
        Me.VisualizeBlockTypesToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.VisualizeBlockTypesToolStripMenuItem.Text = "블럭 타입 보기"
        '
        'FFmpegDeinterlacerToolStripMenuItem
        '
        Me.FFmpegDeinterlacerToolStripMenuItem.CheckOnClick = True
        Me.FFmpegDeinterlacerToolStripMenuItem.Name = "FFmpegDeinterlacerToolStripMenuItem"
        Me.FFmpegDeinterlacerToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.FFmpegDeinterlacerToolStripMenuItem.Text = "FFmpeg 디인터레이스"
        '
        'SpDfToolStripMenuItem
        '
        Me.SpDfToolStripMenuItem.Name = "SpDfToolStripMenuItem"
        Me.SpDfToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.SpDfToolStripMenuItem.Text = "정상배속"
        '
        'SpDnToolStripMenuItem
        '
        Me.SpDnToolStripMenuItem.Name = "SpDnToolStripMenuItem"
        Me.SpDnToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.SpDnToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.SpDnToolStripMenuItem.Text = "배속감소"
        '
        'SpDuToolStripMenuItem
        '
        Me.SpDuToolStripMenuItem.Name = "SpDuToolStripMenuItem"
        Me.SpDuToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.SpDuToolStripMenuItem.Text = "배속증가"
        '
        'SpeedXVToolStripMenuItem
        '
        Me.SpeedXVToolStripMenuItem.Name = "SpeedXVToolStripMenuItem"
        Me.SpeedXVToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.SpeedXVToolStripMenuItem.Text = "1.0x"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 430)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(434, 22)
        Me.StatusStrip1.TabIndex = 33
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(12, 17)
        Me.ToolStripStatusLabel1.Text = "-"
        '
        'StreamFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 452)
        Me.Controls.Add(Me.BPanel)
        Me.Controls.Add(Me.PreviewGroupBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(450, 490)
        Me.Name = "StreamFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "구간 설정/스트림 선택/잘라내기"
        Me.TPrePanel.ResumeLayout(False)
        Me.InTPrePanel.ResumeLayout(False)
        Me.InTPrePanel.PerformLayout()
        Me.PrePanel.ResumeLayout(False)
        Me.CropGroupBox.ResumeLayout(False)
        Me.CropGroupBox.PerformLayout()
        CType(Me.RightNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BottomNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TimeSpGroupBox.ResumeLayout(False)
        Me.TimeSpGroupBox.PerformLayout()
        Me.PreviewGroupBox.ResumeLayout(False)
        Me.PreviewPanel.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.VolTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.TPanel.ResumeLayout(False)
        Me.TPanel.PerformLayout()
        CType(Me.SeekTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StreamSelGroupBox.ResumeLayout(False)
        Me.BPanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TPrePanel As System.Windows.Forms.Panel
    Friend WithEvents PrePanel As System.Windows.Forms.Panel
    Friend WithEvents OutputBox_Stream As System.Windows.Forms.TextBox
    Friend WithEvents PreviewGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ForwardBTN As System.Windows.Forms.Button
    Friend WithEvents BackwardBTN As System.Windows.Forms.Button
    Friend WithEvents PlayPauseBTN As System.Windows.Forms.Button
    Friend WithEvents StopBTN As System.Windows.Forms.Button
    Friend WithEvents BackwardTimerM As System.Windows.Forms.Timer
    Friend WithEvents ForwardTimerM As System.Windows.Forms.Timer
    Friend WithEvents VolTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents DetailStreamInfoTimer As System.Windows.Forms.Timer
    Friend WithEvents ASListBox As System.Windows.Forms.ListBox
    Friend WithEvents GETPP As System.Windows.Forms.Timer
    Friend WithEvents Nowhms As System.Windows.Forms.Label
    Friend WithEvents NowhmsTimer As System.Windows.Forms.Timer
    Friend WithEvents FrameStepButton As System.Windows.Forms.Button
    Friend WithEvents SoundM As System.Windows.Forms.Timer
    Friend WithEvents TimeSpGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents SCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SeekTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents StreamSelGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents SHTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EMSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EP3Label As System.Windows.Forms.Label
    Friend WithEvents ESTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EP2Label As System.Windows.Forms.Label
    Friend WithEvents EMTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EP1Label As System.Windows.Forms.Label
    Friend WithEvents EHTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ECheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SMSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SP3Label As System.Windows.Forms.Label
    Friend WithEvents SSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SP2Label As System.Windows.Forms.Label
    Friend WithEvents SMTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SP1Label As System.Windows.Forms.Label
    Friend WithEvents ENDCKButton As System.Windows.Forms.Button
    Friend WithEvents STRCKButton As System.Windows.Forms.Button
    Friend WithEvents Totalhms As System.Windows.Forms.Label
    Friend WithEvents SeekTimer As System.Windows.Forms.Timer
    Friend WithEvents PreviewPanel As System.Windows.Forms.Panel
    Friend WithEvents BPanel As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents AudioComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents OKBTN As System.Windows.Forms.Button
    Friend WithEvents CancelBTN As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SpDnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SpDuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SpeedXVToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents scaletempoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents karaokeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents extrastereoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VisualizeMotionVectorsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FFmpegDeinterlacerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AllChToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LeftChToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RightChToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VisualizeBlockTypesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents SpDfToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TPanel As System.Windows.Forms.Panel
    Friend WithEvents TimeSpButton As System.Windows.Forms.Button
    Friend WithEvents CropGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents RightLabel As System.Windows.Forms.Label
    Friend WithEvents BottomLabel As System.Windows.Forms.Label
    Friend WithEvents TopLabel As System.Windows.Forms.Label
    Friend WithEvents LeftLabel As System.Windows.Forms.Label
    Friend WithEvents RightNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents TopNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents BottomNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents LeftNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents CropButton As System.Windows.Forms.Button
    Friend WithEvents TopPanel As System.Windows.Forms.Panel
    Friend WithEvents PrePanel1 As System.Windows.Forms.Panel
    Friend WithEvents SizeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SizeLabel As System.Windows.Forms.Label
    Friend WithEvents RightPanel As System.Windows.Forms.Panel
    Friend WithEvents LeftPanel As System.Windows.Forms.Panel
    Friend WithEvents BottomPanel As System.Windows.Forms.Panel
    Friend WithEvents LoadingLabel As System.Windows.Forms.Label
    Friend WithEvents AspectOriginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SizeOriginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents InTPrePanel As System.Windows.Forms.Panel
End Class
