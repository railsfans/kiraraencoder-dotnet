<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EncodingFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EncodingFrm))
        Me.OutputBox_EI = New System.Windows.Forms.TextBox
        Me.StopButton = New System.Windows.Forms.Button
        Me.IndexTimer = New System.Windows.Forms.Timer(Me.components)
        Me.InfoTextBox = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BitrateTXTLabel = New System.Windows.Forms.Label
        Me.BitrateLabel = New System.Windows.Forms.Label
        Me.QTXTLabel = New System.Windows.Forms.Label
        Me.QLabel = New System.Windows.Forms.Label
        Me.FrameTXTLabel = New System.Windows.Forms.Label
        Me.FrameLabel = New System.Windows.Forms.Label
        Me.TimeRemainingTXTLabel = New System.Windows.Forms.Label
        Me.TimeRemainingLabel = New System.Windows.Forms.Label
        Me.TimeElapsedTXTLabel = New System.Windows.Forms.Label
        Me.TimeElapsedLabel = New System.Windows.Forms.Label
        Me.FilesizeTXTLabel = New System.Windows.Forms.Label
        Me.FilesizeLabel = New System.Windows.Forms.Label
        Me.PositionDurationTXTLabel = New System.Windows.Forms.Label
        Me.PositionDurationLabel = New System.Windows.Forms.Label
        Me.LogStr = New System.Windows.Forms.Label
        Me.EncPanel = New System.Windows.Forms.Panel
        Me.AlertLabel = New System.Windows.Forms.Label
        Me.LCopyButton = New System.Windows.Forms.Button
        Me.ImgPanel = New System.Windows.Forms.Panel
        Me.InfoPanel = New System.Windows.Forms.Panel
        Me.PInfoTextBox = New System.Windows.Forms.TextBox
        Me.FileNameLabel = New System.Windows.Forms.Label
        Me.DebugLabel = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.PreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PreviewGroupBox = New System.Windows.Forms.GroupBox
        Me.DebugCheckBox = New System.Windows.Forms.CheckBox
        Me.OutPRadioButton = New System.Windows.Forms.RadioButton
        Me.InPRadioButton = New System.Windows.Forms.RadioButton
        Me.PreviewCheckBox = New System.Windows.Forms.CheckBox
        Me.PriorityGroupBox = New System.Windows.Forms.GroupBox
        Me.PriorityComboBox = New System.Windows.Forms.ComboBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.ShutdownCheckBox = New System.Windows.Forms.CheckBox
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.EncToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.CPUToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.ProgressBar = New System.Windows.Forms.ToolStripProgressBar
        Me.PCNTToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.SuspendResumeButton = New System.Windows.Forms.Button
        Me.ForceStopButton = New System.Windows.Forms.Button
        Me.SnapshotPictureBox = New System.Windows.Forms.PictureBox
        Me.TimeElapsedTimer = New System.Windows.Forms.Timer(Me.components)
        Me.CapTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SnapshotTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SFTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SlideTimer = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.EncPanel.SuspendLayout()
        Me.InfoPanel.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.PreviewGroupBox.SuspendLayout()
        Me.PriorityGroupBox.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.SnapshotPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OutputBox_EI
        '
        Me.OutputBox_EI.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.OutputBox_EI, "OutputBox_EI")
        Me.OutputBox_EI.Name = "OutputBox_EI"
        Me.OutputBox_EI.ReadOnly = True
        '
        'StopButton
        '
        resources.ApplyResources(Me.StopButton, "StopButton")
        Me.StopButton.Name = "StopButton"
        Me.StopButton.UseVisualStyleBackColor = True
        '
        'IndexTimer
        '
        Me.IndexTimer.Interval = 1
        '
        'InfoTextBox
        '
        Me.InfoTextBox.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.InfoTextBox, "InfoTextBox")
        Me.InfoTextBox.Name = "InfoTextBox"
        Me.InfoTextBox.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BitrateTXTLabel)
        Me.GroupBox1.Controls.Add(Me.BitrateLabel)
        Me.GroupBox1.Controls.Add(Me.QTXTLabel)
        Me.GroupBox1.Controls.Add(Me.QLabel)
        Me.GroupBox1.Controls.Add(Me.FrameTXTLabel)
        Me.GroupBox1.Controls.Add(Me.FrameLabel)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'BitrateTXTLabel
        '
        resources.ApplyResources(Me.BitrateTXTLabel, "BitrateTXTLabel")
        Me.BitrateTXTLabel.Name = "BitrateTXTLabel"
        '
        'BitrateLabel
        '
        Me.BitrateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        resources.ApplyResources(Me.BitrateLabel, "BitrateLabel")
        Me.BitrateLabel.Name = "BitrateLabel"
        '
        'QTXTLabel
        '
        resources.ApplyResources(Me.QTXTLabel, "QTXTLabel")
        Me.QTXTLabel.Name = "QTXTLabel"
        '
        'QLabel
        '
        Me.QLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        resources.ApplyResources(Me.QLabel, "QLabel")
        Me.QLabel.Name = "QLabel"
        '
        'FrameTXTLabel
        '
        resources.ApplyResources(Me.FrameTXTLabel, "FrameTXTLabel")
        Me.FrameTXTLabel.Name = "FrameTXTLabel"
        '
        'FrameLabel
        '
        Me.FrameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        resources.ApplyResources(Me.FrameLabel, "FrameLabel")
        Me.FrameLabel.Name = "FrameLabel"
        '
        'TimeRemainingTXTLabel
        '
        resources.ApplyResources(Me.TimeRemainingTXTLabel, "TimeRemainingTXTLabel")
        Me.TimeRemainingTXTLabel.Name = "TimeRemainingTXTLabel"
        '
        'TimeRemainingLabel
        '
        resources.ApplyResources(Me.TimeRemainingLabel, "TimeRemainingLabel")
        Me.TimeRemainingLabel.Name = "TimeRemainingLabel"
        '
        'TimeElapsedTXTLabel
        '
        resources.ApplyResources(Me.TimeElapsedTXTLabel, "TimeElapsedTXTLabel")
        Me.TimeElapsedTXTLabel.Name = "TimeElapsedTXTLabel"
        '
        'TimeElapsedLabel
        '
        resources.ApplyResources(Me.TimeElapsedLabel, "TimeElapsedLabel")
        Me.TimeElapsedLabel.Name = "TimeElapsedLabel"
        '
        'FilesizeTXTLabel
        '
        resources.ApplyResources(Me.FilesizeTXTLabel, "FilesizeTXTLabel")
        Me.FilesizeTXTLabel.Name = "FilesizeTXTLabel"
        '
        'FilesizeLabel
        '
        resources.ApplyResources(Me.FilesizeLabel, "FilesizeLabel")
        Me.FilesizeLabel.Name = "FilesizeLabel"
        '
        'PositionDurationTXTLabel
        '
        resources.ApplyResources(Me.PositionDurationTXTLabel, "PositionDurationTXTLabel")
        Me.PositionDurationTXTLabel.Name = "PositionDurationTXTLabel"
        '
        'PositionDurationLabel
        '
        resources.ApplyResources(Me.PositionDurationLabel, "PositionDurationLabel")
        Me.PositionDurationLabel.Name = "PositionDurationLabel"
        '
        'LogStr
        '
        resources.ApplyResources(Me.LogStr, "LogStr")
        Me.LogStr.Name = "LogStr"
        '
        'EncPanel
        '
        Me.EncPanel.Controls.Add(Me.ImgPanel)
        Me.EncPanel.Controls.Add(Me.InfoPanel)
        Me.EncPanel.Controls.Add(Me.DebugLabel)
        Me.EncPanel.Controls.Add(Me.AlertLabel)
        Me.EncPanel.Controls.Add(Me.LCopyButton)
        Me.EncPanel.Controls.Add(Me.MenuStrip1)
        Me.EncPanel.Controls.Add(Me.InfoTextBox)
        Me.EncPanel.Controls.Add(Me.OutputBox_EI)
        Me.EncPanel.Controls.Add(Me.PreviewGroupBox)
        Me.EncPanel.Controls.Add(Me.PreviewCheckBox)
        Me.EncPanel.Controls.Add(Me.PriorityGroupBox)
        Me.EncPanel.Controls.Add(Me.GroupBox3)
        Me.EncPanel.Controls.Add(Me.ShutdownCheckBox)
        Me.EncPanel.Controls.Add(Me.StatusStrip1)
        Me.EncPanel.Controls.Add(Me.SuspendResumeButton)
        Me.EncPanel.Controls.Add(Me.ForceStopButton)
        Me.EncPanel.Controls.Add(Me.GroupBox1)
        Me.EncPanel.Controls.Add(Me.StopButton)
        Me.EncPanel.Controls.Add(Me.SnapshotPictureBox)
        resources.ApplyResources(Me.EncPanel, "EncPanel")
        Me.EncPanel.Name = "EncPanel"
        '
        'AlertLabel
        '
        resources.ApplyResources(Me.AlertLabel, "AlertLabel")
        Me.AlertLabel.Name = "AlertLabel"
        '
        'LCopyButton
        '
        resources.ApplyResources(Me.LCopyButton, "LCopyButton")
        Me.LCopyButton.Name = "LCopyButton"
        Me.LCopyButton.UseVisualStyleBackColor = True
        '
        'ImgPanel
        '
        Me.ImgPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.ImgPanel, "ImgPanel")
        Me.ImgPanel.Name = "ImgPanel"
        '
        'InfoPanel
        '
        Me.InfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InfoPanel.Controls.Add(Me.PInfoTextBox)
        Me.InfoPanel.Controls.Add(Me.FileNameLabel)
        resources.ApplyResources(Me.InfoPanel, "InfoPanel")
        Me.InfoPanel.Name = "InfoPanel"
        '
        'PInfoTextBox
        '
        Me.PInfoTextBox.BackColor = System.Drawing.Color.White
        Me.PInfoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.PInfoTextBox, "PInfoTextBox")
        Me.PInfoTextBox.Name = "PInfoTextBox"
        Me.PInfoTextBox.ReadOnly = True
        '
        'FileNameLabel
        '
        resources.ApplyResources(Me.FileNameLabel, "FileNameLabel")
        Me.FileNameLabel.Name = "FileNameLabel"
        '
        'DebugLabel
        '
        resources.ApplyResources(Me.DebugLabel, "DebugLabel")
        Me.DebugLabel.Name = "DebugLabel"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PreviewToolStripMenuItem, Me.LogToolStripMenuItem, Me.ImageToolStripMenuItem})
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'PreviewToolStripMenuItem
        '
        Me.PreviewToolStripMenuItem.Name = "PreviewToolStripMenuItem"
        resources.ApplyResources(Me.PreviewToolStripMenuItem, "PreviewToolStripMenuItem")
        '
        'LogToolStripMenuItem
        '
        Me.LogToolStripMenuItem.Name = "LogToolStripMenuItem"
        resources.ApplyResources(Me.LogToolStripMenuItem, "LogToolStripMenuItem")
        '
        'ImageToolStripMenuItem
        '
        Me.ImageToolStripMenuItem.Name = "ImageToolStripMenuItem"
        resources.ApplyResources(Me.ImageToolStripMenuItem, "ImageToolStripMenuItem")
        '
        'PreviewGroupBox
        '
        Me.PreviewGroupBox.Controls.Add(Me.DebugCheckBox)
        Me.PreviewGroupBox.Controls.Add(Me.OutPRadioButton)
        Me.PreviewGroupBox.Controls.Add(Me.InPRadioButton)
        resources.ApplyResources(Me.PreviewGroupBox, "PreviewGroupBox")
        Me.PreviewGroupBox.Name = "PreviewGroupBox"
        Me.PreviewGroupBox.TabStop = False
        '
        'DebugCheckBox
        '
        resources.ApplyResources(Me.DebugCheckBox, "DebugCheckBox")
        Me.DebugCheckBox.Name = "DebugCheckBox"
        Me.DebugCheckBox.UseVisualStyleBackColor = True
        '
        'OutPRadioButton
        '
        resources.ApplyResources(Me.OutPRadioButton, "OutPRadioButton")
        Me.OutPRadioButton.Name = "OutPRadioButton"
        Me.OutPRadioButton.TabStop = True
        Me.OutPRadioButton.UseVisualStyleBackColor = True
        '
        'InPRadioButton
        '
        resources.ApplyResources(Me.InPRadioButton, "InPRadioButton")
        Me.InPRadioButton.Name = "InPRadioButton"
        Me.InPRadioButton.TabStop = True
        Me.InPRadioButton.UseVisualStyleBackColor = True
        '
        'PreviewCheckBox
        '
        resources.ApplyResources(Me.PreviewCheckBox, "PreviewCheckBox")
        Me.PreviewCheckBox.Name = "PreviewCheckBox"
        Me.PreviewCheckBox.UseVisualStyleBackColor = True
        '
        'PriorityGroupBox
        '
        Me.PriorityGroupBox.Controls.Add(Me.PriorityComboBox)
        resources.ApplyResources(Me.PriorityGroupBox, "PriorityGroupBox")
        Me.PriorityGroupBox.Name = "PriorityGroupBox"
        Me.PriorityGroupBox.TabStop = False
        '
        'PriorityComboBox
        '
        Me.PriorityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PriorityComboBox.FormattingEnabled = True
        resources.ApplyResources(Me.PriorityComboBox, "PriorityComboBox")
        Me.PriorityComboBox.Name = "PriorityComboBox"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PositionDurationTXTLabel)
        Me.GroupBox3.Controls.Add(Me.TimeRemainingTXTLabel)
        Me.GroupBox3.Controls.Add(Me.PositionDurationLabel)
        Me.GroupBox3.Controls.Add(Me.FilesizeTXTLabel)
        Me.GroupBox3.Controls.Add(Me.TimeRemainingLabel)
        Me.GroupBox3.Controls.Add(Me.FilesizeLabel)
        Me.GroupBox3.Controls.Add(Me.TimeElapsedLabel)
        Me.GroupBox3.Controls.Add(Me.TimeElapsedTXTLabel)
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'ShutdownCheckBox
        '
        resources.ApplyResources(Me.ShutdownCheckBox, "ShutdownCheckBox")
        Me.ShutdownCheckBox.Name = "ShutdownCheckBox"
        Me.ShutdownCheckBox.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EncToolStripStatusLabel, Me.CPUToolStripStatusLabel, Me.ProgressBar, Me.PCNTToolStripStatusLabel})
        resources.ApplyResources(Me.StatusStrip1, "StatusStrip1")
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.SizingGrip = False
        '
        'EncToolStripStatusLabel
        '
        resources.ApplyResources(Me.EncToolStripStatusLabel, "EncToolStripStatusLabel")
        Me.EncToolStripStatusLabel.Name = "EncToolStripStatusLabel"
        Me.EncToolStripStatusLabel.Spring = True
        '
        'CPUToolStripStatusLabel
        '
        resources.ApplyResources(Me.CPUToolStripStatusLabel, "CPUToolStripStatusLabel")
        Me.CPUToolStripStatusLabel.BorderSides = CType((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.CPUToolStripStatusLabel.Name = "CPUToolStripStatusLabel"
        '
        'ProgressBar
        '
        Me.ProgressBar.Name = "ProgressBar"
        resources.ApplyResources(Me.ProgressBar, "ProgressBar")
        Me.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'PCNTToolStripStatusLabel
        '
        resources.ApplyResources(Me.PCNTToolStripStatusLabel, "PCNTToolStripStatusLabel")
        Me.PCNTToolStripStatusLabel.Name = "PCNTToolStripStatusLabel"
        '
        'SuspendResumeButton
        '
        resources.ApplyResources(Me.SuspendResumeButton, "SuspendResumeButton")
        Me.SuspendResumeButton.Name = "SuspendResumeButton"
        Me.SuspendResumeButton.UseVisualStyleBackColor = True
        '
        'ForceStopButton
        '
        resources.ApplyResources(Me.ForceStopButton, "ForceStopButton")
        Me.ForceStopButton.Name = "ForceStopButton"
        Me.ForceStopButton.UseVisualStyleBackColor = True
        '
        'SnapshotPictureBox
        '
        Me.SnapshotPictureBox.BackColor = System.Drawing.Color.DarkGray
        Me.SnapshotPictureBox.ErrorImage = Nothing
        resources.ApplyResources(Me.SnapshotPictureBox, "SnapshotPictureBox")
        Me.SnapshotPictureBox.InitialImage = Nothing
        Me.SnapshotPictureBox.Name = "SnapshotPictureBox"
        Me.SnapshotPictureBox.TabStop = False
        '
        'TimeElapsedTimer
        '
        Me.TimeElapsedTimer.Interval = 1000
        '
        'CapTimer
        '
        '
        'SnapshotTimer
        '
        Me.SnapshotTimer.Interval = 1000
        '
        'SFTimer
        '
        Me.SFTimer.Interval = 1
        '
        'SlideTimer
        '
        Me.SlideTimer.Interval = 50
        '
        'EncodingFrm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.EncPanel)
        Me.Controls.Add(Me.LogStr)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "EncodingFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.GroupBox1.ResumeLayout(False)
        Me.EncPanel.ResumeLayout(False)
        Me.EncPanel.PerformLayout()
        Me.InfoPanel.ResumeLayout(False)
        Me.InfoPanel.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PreviewGroupBox.ResumeLayout(False)
        Me.PreviewGroupBox.PerformLayout()
        Me.PriorityGroupBox.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.SnapshotPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OutputBox_EI As System.Windows.Forms.TextBox
    Friend WithEvents StopButton As System.Windows.Forms.Button
    Friend WithEvents IndexTimer As System.Windows.Forms.Timer
    Friend WithEvents InfoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LogStr As System.Windows.Forms.Label
    Friend WithEvents PositionDurationLabel As System.Windows.Forms.Label
    Friend WithEvents PositionDurationTXTLabel As System.Windows.Forms.Label
    Friend WithEvents FrameTXTLabel As System.Windows.Forms.Label
    Friend WithEvents FrameLabel As System.Windows.Forms.Label
    Friend WithEvents FilesizeTXTLabel As System.Windows.Forms.Label
    Friend WithEvents FilesizeLabel As System.Windows.Forms.Label
    Friend WithEvents EncPanel As System.Windows.Forms.Panel
    Friend WithEvents BitrateTXTLabel As System.Windows.Forms.Label
    Friend WithEvents BitrateLabel As System.Windows.Forms.Label
    Friend WithEvents QTXTLabel As System.Windows.Forms.Label
    Friend WithEvents QLabel As System.Windows.Forms.Label
    Friend WithEvents TimeRemainingTXTLabel As System.Windows.Forms.Label
    Friend WithEvents TimeRemainingLabel As System.Windows.Forms.Label
    Friend WithEvents TimeElapsedTXTLabel As System.Windows.Forms.Label
    Friend WithEvents TimeElapsedLabel As System.Windows.Forms.Label
    Friend WithEvents TimeElapsedTimer As System.Windows.Forms.Timer
    Friend WithEvents ForceStopButton As System.Windows.Forms.Button
    Friend WithEvents SuspendResumeButton As System.Windows.Forms.Button
    Friend WithEvents PriorityComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ShutdownCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents CapTimer As System.Windows.Forms.Timer
    Friend WithEvents EncToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SnapshotTimer As System.Windows.Forms.Timer
    Friend WithEvents SnapshotPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents ProgressBar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PriorityGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents PreviewCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents PreviewGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents OutPRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents InPRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents SFTimer As System.Windows.Forms.Timer
    Friend WithEvents DebugLabel As System.Windows.Forms.Label
    Friend WithEvents DebugCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents InfoPanel As System.Windows.Forms.Panel
    Friend WithEvents FileNameLabel As System.Windows.Forms.Label
    Friend WithEvents SlideTimer As System.Windows.Forms.Timer
    Friend WithEvents PInfoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CPUToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PCNTToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ImgPanel As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PreviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LCopyButton As System.Windows.Forms.Button
    Friend WithEvents AlertLabel As System.Windows.Forms.Label
End Class
