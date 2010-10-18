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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StreamFrm))
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
        resources.ApplyResources(Me.TPrePanel, "TPrePanel")
        Me.TPrePanel.BackColor = System.Drawing.Color.Gray
        Me.TPrePanel.Controls.Add(Me.InTPrePanel)
        Me.TPrePanel.Controls.Add(Me.CropGroupBox)
        Me.TPrePanel.Controls.Add(Me.TimeSpGroupBox)
        Me.TPrePanel.Name = "TPrePanel"
        '
        'InTPrePanel
        '
        Me.InTPrePanel.Controls.Add(Me.LoadingLabel)
        Me.InTPrePanel.Controls.Add(Me.PrePanel)
        Me.InTPrePanel.Controls.Add(Me.OutputBox_Stream)
        resources.ApplyResources(Me.InTPrePanel, "InTPrePanel")
        Me.InTPrePanel.Name = "InTPrePanel"
        '
        'LoadingLabel
        '
        resources.ApplyResources(Me.LoadingLabel, "LoadingLabel")
        Me.LoadingLabel.ForeColor = System.Drawing.Color.White
        Me.LoadingLabel.Name = "LoadingLabel"
        '
        'PrePanel
        '
        resources.ApplyResources(Me.PrePanel, "PrePanel")
        Me.PrePanel.Controls.Add(Me.RightPanel)
        Me.PrePanel.Controls.Add(Me.LeftPanel)
        Me.PrePanel.Controls.Add(Me.BottomPanel)
        Me.PrePanel.Controls.Add(Me.TopPanel)
        Me.PrePanel.Controls.Add(Me.PrePanel1)
        Me.PrePanel.Name = "PrePanel"
        '
        'RightPanel
        '
        Me.RightPanel.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.RightPanel, "RightPanel")
        Me.RightPanel.Name = "RightPanel"
        '
        'LeftPanel
        '
        Me.LeftPanel.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.LeftPanel, "LeftPanel")
        Me.LeftPanel.Name = "LeftPanel"
        '
        'BottomPanel
        '
        Me.BottomPanel.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.BottomPanel, "BottomPanel")
        Me.BottomPanel.Name = "BottomPanel"
        '
        'TopPanel
        '
        Me.TopPanel.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.TopPanel, "TopPanel")
        Me.TopPanel.Name = "TopPanel"
        '
        'PrePanel1
        '
        resources.ApplyResources(Me.PrePanel1, "PrePanel1")
        Me.PrePanel1.Name = "PrePanel1"
        '
        'OutputBox_Stream
        '
        resources.ApplyResources(Me.OutputBox_Stream, "OutputBox_Stream")
        Me.OutputBox_Stream.BackColor = System.Drawing.Color.Gray
        Me.OutputBox_Stream.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.OutputBox_Stream.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.OutputBox_Stream.ForeColor = System.Drawing.Color.White
        Me.OutputBox_Stream.Name = "OutputBox_Stream"
        Me.OutputBox_Stream.ReadOnly = True
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
        resources.ApplyResources(Me.CropGroupBox, "CropGroupBox")
        Me.CropGroupBox.Name = "CropGroupBox"
        Me.CropGroupBox.TabStop = False
        '
        'SizeTextBox
        '
        resources.ApplyResources(Me.SizeTextBox, "SizeTextBox")
        Me.SizeTextBox.Name = "SizeTextBox"
        Me.SizeTextBox.ReadOnly = True
        '
        'SizeLabel
        '
        resources.ApplyResources(Me.SizeLabel, "SizeLabel")
        Me.SizeLabel.Name = "SizeLabel"
        '
        'RightLabel
        '
        resources.ApplyResources(Me.RightLabel, "RightLabel")
        Me.RightLabel.Name = "RightLabel"
        '
        'BottomLabel
        '
        resources.ApplyResources(Me.BottomLabel, "BottomLabel")
        Me.BottomLabel.Name = "BottomLabel"
        '
        'TopLabel
        '
        resources.ApplyResources(Me.TopLabel, "TopLabel")
        Me.TopLabel.Name = "TopLabel"
        '
        'LeftLabel
        '
        resources.ApplyResources(Me.LeftLabel, "LeftLabel")
        Me.LeftLabel.Name = "LeftLabel"
        '
        'RightNumericUpDown
        '
        resources.ApplyResources(Me.RightNumericUpDown, "RightNumericUpDown")
        Me.RightNumericUpDown.Name = "RightNumericUpDown"
        '
        'TopNumericUpDown
        '
        resources.ApplyResources(Me.TopNumericUpDown, "TopNumericUpDown")
        Me.TopNumericUpDown.Name = "TopNumericUpDown"
        '
        'BottomNumericUpDown
        '
        resources.ApplyResources(Me.BottomNumericUpDown, "BottomNumericUpDown")
        Me.BottomNumericUpDown.Name = "BottomNumericUpDown"
        '
        'LeftNumericUpDown
        '
        resources.ApplyResources(Me.LeftNumericUpDown, "LeftNumericUpDown")
        Me.LeftNumericUpDown.Name = "LeftNumericUpDown"
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
        resources.ApplyResources(Me.TimeSpGroupBox, "TimeSpGroupBox")
        Me.TimeSpGroupBox.Name = "TimeSpGroupBox"
        Me.TimeSpGroupBox.TabStop = False
        '
        'EMSTextBox
        '
        resources.ApplyResources(Me.EMSTextBox, "EMSTextBox")
        Me.EMSTextBox.Name = "EMSTextBox"
        '
        'SMSTextBox
        '
        resources.ApplyResources(Me.SMSTextBox, "SMSTextBox")
        Me.SMSTextBox.Name = "SMSTextBox"
        '
        'ESTextBox
        '
        Me.ESTextBox.BackColor = System.Drawing.Color.LightYellow
        resources.ApplyResources(Me.ESTextBox, "ESTextBox")
        Me.ESTextBox.Name = "ESTextBox"
        '
        'SSTextBox
        '
        Me.SSTextBox.BackColor = System.Drawing.Color.LightYellow
        resources.ApplyResources(Me.SSTextBox, "SSTextBox")
        Me.SSTextBox.Name = "SSTextBox"
        '
        'ENDCKButton
        '
        resources.ApplyResources(Me.ENDCKButton, "ENDCKButton")
        Me.ENDCKButton.Name = "ENDCKButton"
        Me.ENDCKButton.UseVisualStyleBackColor = True
        '
        'STRCKButton
        '
        resources.ApplyResources(Me.STRCKButton, "STRCKButton")
        Me.STRCKButton.Name = "STRCKButton"
        Me.STRCKButton.UseVisualStyleBackColor = True
        '
        'EP3Label
        '
        resources.ApplyResources(Me.EP3Label, "EP3Label")
        Me.EP3Label.Name = "EP3Label"
        '
        'EP2Label
        '
        resources.ApplyResources(Me.EP2Label, "EP2Label")
        Me.EP2Label.Name = "EP2Label"
        '
        'EMTextBox
        '
        Me.EMTextBox.BackColor = System.Drawing.Color.LightYellow
        resources.ApplyResources(Me.EMTextBox, "EMTextBox")
        Me.EMTextBox.Name = "EMTextBox"
        '
        'EP1Label
        '
        resources.ApplyResources(Me.EP1Label, "EP1Label")
        Me.EP1Label.Name = "EP1Label"
        '
        'EHTextBox
        '
        Me.EHTextBox.BackColor = System.Drawing.Color.LightYellow
        resources.ApplyResources(Me.EHTextBox, "EHTextBox")
        Me.EHTextBox.Name = "EHTextBox"
        '
        'ECheckBox
        '
        resources.ApplyResources(Me.ECheckBox, "ECheckBox")
        Me.ECheckBox.Name = "ECheckBox"
        Me.ECheckBox.UseVisualStyleBackColor = True
        '
        'SP3Label
        '
        resources.ApplyResources(Me.SP3Label, "SP3Label")
        Me.SP3Label.Name = "SP3Label"
        '
        'SP2Label
        '
        resources.ApplyResources(Me.SP2Label, "SP2Label")
        Me.SP2Label.Name = "SP2Label"
        '
        'SMTextBox
        '
        Me.SMTextBox.BackColor = System.Drawing.Color.LightYellow
        resources.ApplyResources(Me.SMTextBox, "SMTextBox")
        Me.SMTextBox.Name = "SMTextBox"
        '
        'SP1Label
        '
        resources.ApplyResources(Me.SP1Label, "SP1Label")
        Me.SP1Label.Name = "SP1Label"
        '
        'SHTextBox
        '
        Me.SHTextBox.BackColor = System.Drawing.Color.LightYellow
        resources.ApplyResources(Me.SHTextBox, "SHTextBox")
        Me.SHTextBox.Name = "SHTextBox"
        '
        'SCheckBox
        '
        resources.ApplyResources(Me.SCheckBox, "SCheckBox")
        Me.SCheckBox.Name = "SCheckBox"
        Me.SCheckBox.UseVisualStyleBackColor = True
        '
        'PreviewGroupBox
        '
        resources.ApplyResources(Me.PreviewGroupBox, "PreviewGroupBox")
        Me.PreviewGroupBox.Controls.Add(Me.TPrePanel)
        Me.PreviewGroupBox.Controls.Add(Me.PreviewPanel)
        Me.PreviewGroupBox.Name = "PreviewGroupBox"
        Me.PreviewGroupBox.TabStop = False
        '
        'PreviewPanel
        '
        Me.PreviewPanel.Controls.Add(Me.Panel5)
        Me.PreviewPanel.Controls.Add(Me.Panel3)
        Me.PreviewPanel.Controls.Add(Me.SeekTrackBar)
        resources.ApplyResources(Me.PreviewPanel, "PreviewPanel")
        Me.PreviewPanel.Name = "PreviewPanel"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.VolTrackBar)
        resources.ApplyResources(Me.Panel5, "Panel5")
        Me.Panel5.Name = "Panel5"
        '
        'VolTrackBar
        '
        resources.ApplyResources(Me.VolTrackBar, "VolTrackBar")
        Me.VolTrackBar.LargeChange = 0
        Me.VolTrackBar.Maximum = 100
        Me.VolTrackBar.Name = "VolTrackBar"
        Me.VolTrackBar.SmallChange = 0
        Me.VolTrackBar.TickFrequency = 0
        Me.VolTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
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
        resources.ApplyResources(Me.Panel3, "Panel3")
        Me.Panel3.Name = "Panel3"
        '
        'Panel4
        '
        resources.ApplyResources(Me.Panel4, "Panel4")
        Me.Panel4.Controls.Add(Me.TPanel)
        Me.Panel4.Name = "Panel4"
        '
        'TPanel
        '
        Me.TPanel.Controls.Add(Me.Nowhms)
        Me.TPanel.Controls.Add(Me.Totalhms)
        resources.ApplyResources(Me.TPanel, "TPanel")
        Me.TPanel.Name = "TPanel"
        '
        'Nowhms
        '
        resources.ApplyResources(Me.Nowhms, "Nowhms")
        Me.Nowhms.Name = "Nowhms"
        '
        'Totalhms
        '
        resources.ApplyResources(Me.Totalhms, "Totalhms")
        Me.Totalhms.Name = "Totalhms"
        '
        'PlayPauseBTN
        '
        resources.ApplyResources(Me.PlayPauseBTN, "PlayPauseBTN")
        Me.PlayPauseBTN.Name = "PlayPauseBTN"
        Me.PlayPauseBTN.UseVisualStyleBackColor = True
        '
        'ForwardBTN
        '
        resources.ApplyResources(Me.ForwardBTN, "ForwardBTN")
        Me.ForwardBTN.Name = "ForwardBTN"
        Me.ForwardBTN.UseVisualStyleBackColor = True
        '
        'BackwardBTN
        '
        resources.ApplyResources(Me.BackwardBTN, "BackwardBTN")
        Me.BackwardBTN.Name = "BackwardBTN"
        Me.BackwardBTN.UseVisualStyleBackColor = True
        '
        'StopBTN
        '
        resources.ApplyResources(Me.StopBTN, "StopBTN")
        Me.StopBTN.Name = "StopBTN"
        Me.StopBTN.UseVisualStyleBackColor = True
        '
        'FrameStepButton
        '
        resources.ApplyResources(Me.FrameStepButton, "FrameStepButton")
        Me.FrameStepButton.Name = "FrameStepButton"
        Me.FrameStepButton.UseVisualStyleBackColor = True
        '
        'SeekTrackBar
        '
        resources.ApplyResources(Me.SeekTrackBar, "SeekTrackBar")
        Me.SeekTrackBar.LargeChange = 0
        Me.SeekTrackBar.Maximum = 100
        Me.SeekTrackBar.Name = "SeekTrackBar"
        Me.SeekTrackBar.SmallChange = 0
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
        resources.ApplyResources(Me.ASListBox, "ASListBox")
        Me.ASListBox.Name = "ASListBox"
        '
        'GETPP
        '
        '
        'NowhmsTimer
        '
        Me.NowhmsTimer.Interval = 1
        '
        'SoundM
        '
        '
        'StreamSelGroupBox
        '
        resources.ApplyResources(Me.StreamSelGroupBox, "StreamSelGroupBox")
        Me.StreamSelGroupBox.Controls.Add(Me.AudioComboBox)
        Me.StreamSelGroupBox.Name = "StreamSelGroupBox"
        Me.StreamSelGroupBox.TabStop = False
        '
        'AudioComboBox
        '
        resources.ApplyResources(Me.AudioComboBox, "AudioComboBox")
        Me.AudioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AudioComboBox.FormattingEnabled = True
        Me.AudioComboBox.Name = "AudioComboBox"
        '
        'SeekTimer
        '
        Me.SeekTimer.Interval = 1
        '
        'BPanel
        '
        Me.BPanel.Controls.Add(Me.Panel2)
        Me.BPanel.Controls.Add(Me.StreamSelGroupBox)
        resources.ApplyResources(Me.BPanel, "BPanel")
        Me.BPanel.Name = "BPanel"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CropButton)
        Me.Panel2.Controls.Add(Me.TimeSpButton)
        Me.Panel2.Controls.Add(Me.ASListBox)
        Me.Panel2.Controls.Add(Me.Panel6)
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'CropButton
        '
        resources.ApplyResources(Me.CropButton, "CropButton")
        Me.CropButton.Name = "CropButton"
        Me.CropButton.UseVisualStyleBackColor = True
        '
        'TimeSpButton
        '
        resources.ApplyResources(Me.TimeSpButton, "TimeSpButton")
        Me.TimeSpButton.Name = "TimeSpButton"
        Me.TimeSpButton.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.CancelBTN)
        Me.Panel6.Controls.Add(Me.OKBTN)
        resources.ApplyResources(Me.Panel6, "Panel6")
        Me.Panel6.Name = "Panel6"
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
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptsToolStripMenuItem, Me.SpDfToolStripMenuItem, Me.SpDnToolStripMenuItem, Me.SpDuToolStripMenuItem, Me.SpeedXVToolStripMenuItem})
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'OptsToolStripMenuItem
        '
        Me.OptsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllChToolStripMenuItem, Me.LeftChToolStripMenuItem, Me.RightChToolStripMenuItem, Me.ToolStripMenuItem2, Me.SizeOriginToolStripMenuItem, Me.AspectOriginToolStripMenuItem, Me.ToolStripMenuItem1, Me.scaletempoToolStripMenuItem, Me.extrastereoToolStripMenuItem, Me.karaokeToolStripMenuItem, Me.VisualizeMotionVectorsToolStripMenuItem, Me.VisualizeBlockTypesToolStripMenuItem, Me.FFmpegDeinterlacerToolStripMenuItem})
        Me.OptsToolStripMenuItem.Name = "OptsToolStripMenuItem"
        resources.ApplyResources(Me.OptsToolStripMenuItem, "OptsToolStripMenuItem")
        '
        'AllChToolStripMenuItem
        '
        Me.AllChToolStripMenuItem.Checked = True
        Me.AllChToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AllChToolStripMenuItem.Name = "AllChToolStripMenuItem"
        resources.ApplyResources(Me.AllChToolStripMenuItem, "AllChToolStripMenuItem")
        '
        'LeftChToolStripMenuItem
        '
        Me.LeftChToolStripMenuItem.Name = "LeftChToolStripMenuItem"
        resources.ApplyResources(Me.LeftChToolStripMenuItem, "LeftChToolStripMenuItem")
        '
        'RightChToolStripMenuItem
        '
        Me.RightChToolStripMenuItem.Name = "RightChToolStripMenuItem"
        resources.ApplyResources(Me.RightChToolStripMenuItem, "RightChToolStripMenuItem")
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        resources.ApplyResources(Me.ToolStripMenuItem2, "ToolStripMenuItem2")
        '
        'SizeOriginToolStripMenuItem
        '
        Me.SizeOriginToolStripMenuItem.Name = "SizeOriginToolStripMenuItem"
        resources.ApplyResources(Me.SizeOriginToolStripMenuItem, "SizeOriginToolStripMenuItem")
        '
        'AspectOriginToolStripMenuItem
        '
        Me.AspectOriginToolStripMenuItem.Checked = True
        Me.AspectOriginToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AspectOriginToolStripMenuItem.Name = "AspectOriginToolStripMenuItem"
        resources.ApplyResources(Me.AspectOriginToolStripMenuItem, "AspectOriginToolStripMenuItem")
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        resources.ApplyResources(Me.ToolStripMenuItem1, "ToolStripMenuItem1")
        '
        'scaletempoToolStripMenuItem
        '
        Me.scaletempoToolStripMenuItem.CheckOnClick = True
        Me.scaletempoToolStripMenuItem.Name = "scaletempoToolStripMenuItem"
        resources.ApplyResources(Me.scaletempoToolStripMenuItem, "scaletempoToolStripMenuItem")
        '
        'extrastereoToolStripMenuItem
        '
        Me.extrastereoToolStripMenuItem.CheckOnClick = True
        Me.extrastereoToolStripMenuItem.Name = "extrastereoToolStripMenuItem"
        resources.ApplyResources(Me.extrastereoToolStripMenuItem, "extrastereoToolStripMenuItem")
        '
        'karaokeToolStripMenuItem
        '
        Me.karaokeToolStripMenuItem.CheckOnClick = True
        Me.karaokeToolStripMenuItem.Name = "karaokeToolStripMenuItem"
        resources.ApplyResources(Me.karaokeToolStripMenuItem, "karaokeToolStripMenuItem")
        '
        'VisualizeMotionVectorsToolStripMenuItem
        '
        Me.VisualizeMotionVectorsToolStripMenuItem.CheckOnClick = True
        Me.VisualizeMotionVectorsToolStripMenuItem.Name = "VisualizeMotionVectorsToolStripMenuItem"
        resources.ApplyResources(Me.VisualizeMotionVectorsToolStripMenuItem, "VisualizeMotionVectorsToolStripMenuItem")
        '
        'VisualizeBlockTypesToolStripMenuItem
        '
        Me.VisualizeBlockTypesToolStripMenuItem.CheckOnClick = True
        Me.VisualizeBlockTypesToolStripMenuItem.Name = "VisualizeBlockTypesToolStripMenuItem"
        resources.ApplyResources(Me.VisualizeBlockTypesToolStripMenuItem, "VisualizeBlockTypesToolStripMenuItem")
        '
        'FFmpegDeinterlacerToolStripMenuItem
        '
        Me.FFmpegDeinterlacerToolStripMenuItem.CheckOnClick = True
        Me.FFmpegDeinterlacerToolStripMenuItem.Name = "FFmpegDeinterlacerToolStripMenuItem"
        resources.ApplyResources(Me.FFmpegDeinterlacerToolStripMenuItem, "FFmpegDeinterlacerToolStripMenuItem")
        '
        'SpDfToolStripMenuItem
        '
        Me.SpDfToolStripMenuItem.Name = "SpDfToolStripMenuItem"
        resources.ApplyResources(Me.SpDfToolStripMenuItem, "SpDfToolStripMenuItem")
        '
        'SpDnToolStripMenuItem
        '
        Me.SpDnToolStripMenuItem.Name = "SpDnToolStripMenuItem"
        resources.ApplyResources(Me.SpDnToolStripMenuItem, "SpDnToolStripMenuItem")
        '
        'SpDuToolStripMenuItem
        '
        Me.SpDuToolStripMenuItem.Name = "SpDuToolStripMenuItem"
        resources.ApplyResources(Me.SpDuToolStripMenuItem, "SpDuToolStripMenuItem")
        '
        'SpeedXVToolStripMenuItem
        '
        Me.SpeedXVToolStripMenuItem.Name = "SpeedXVToolStripMenuItem"
        resources.ApplyResources(Me.SpeedXVToolStripMenuItem, "SpeedXVToolStripMenuItem")
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        resources.ApplyResources(Me.StatusStrip1, "StatusStrip1")
        Me.StatusStrip1.Name = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        resources.ApplyResources(Me.ToolStripStatusLabel1, "ToolStripStatusLabel1")
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        '
        'StreamFrm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BPanel)
        Me.Controls.Add(Me.PreviewGroupBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimizeBox = False
        Me.Name = "StreamFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
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
