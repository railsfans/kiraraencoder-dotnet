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
        Me.TimeRemainingTXTLabel = New System.Windows.Forms.Label
        Me.TimeRemainingLabel = New System.Windows.Forms.Label
        Me.TimeElapsedTXTLabel = New System.Windows.Forms.Label
        Me.TimeElapsedLabel = New System.Windows.Forms.Label
        Me.ProcessingRateTXTLabel = New System.Windows.Forms.Label
        Me.ProcessingRateLabel = New System.Windows.Forms.Label
        Me.BitrateTXTLabel = New System.Windows.Forms.Label
        Me.BitrateLabel = New System.Windows.Forms.Label
        Me.QTXTLabel = New System.Windows.Forms.Label
        Me.QLabel = New System.Windows.Forms.Label
        Me.FilesizeTXTLabel = New System.Windows.Forms.Label
        Me.FilesizeLabel = New System.Windows.Forms.Label
        Me.FrameTXTLabel = New System.Windows.Forms.Label
        Me.FrameLabel = New System.Windows.Forms.Label
        Me.PositionDurationTXTLabel = New System.Windows.Forms.Label
        Me.PositionDurationLabel = New System.Windows.Forms.Label
        Me.ProgressBar = New System.Windows.Forms.ProgressBar
        Me.LogStr = New System.Windows.Forms.Label
        Me.EncPanel = New System.Windows.Forms.Panel
        Me.ShutdownCheckBox = New System.Windows.Forms.CheckBox
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.EncToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.PriorityComboBox = New System.Windows.Forms.ComboBox
        Me.SuspendResumeButton = New System.Windows.Forms.Button
        Me.ForceStopButton = New System.Windows.Forms.Button
        Me.ProgressLabel = New System.Windows.Forms.Label
        Me.PriorityLabel = New System.Windows.Forms.Label
        Me.TimeElapsedTimer = New System.Windows.Forms.Timer(Me.components)
        Me.CapTimer = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.EncPanel.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
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
        Me.GroupBox1.Controls.Add(Me.TimeRemainingTXTLabel)
        Me.GroupBox1.Controls.Add(Me.TimeRemainingLabel)
        Me.GroupBox1.Controls.Add(Me.TimeElapsedTXTLabel)
        Me.GroupBox1.Controls.Add(Me.TimeElapsedLabel)
        Me.GroupBox1.Controls.Add(Me.ProcessingRateTXTLabel)
        Me.GroupBox1.Controls.Add(Me.ProcessingRateLabel)
        Me.GroupBox1.Controls.Add(Me.BitrateTXTLabel)
        Me.GroupBox1.Controls.Add(Me.BitrateLabel)
        Me.GroupBox1.Controls.Add(Me.QTXTLabel)
        Me.GroupBox1.Controls.Add(Me.QLabel)
        Me.GroupBox1.Controls.Add(Me.FilesizeTXTLabel)
        Me.GroupBox1.Controls.Add(Me.FilesizeLabel)
        Me.GroupBox1.Controls.Add(Me.FrameTXTLabel)
        Me.GroupBox1.Controls.Add(Me.FrameLabel)
        Me.GroupBox1.Controls.Add(Me.PositionDurationTXTLabel)
        Me.GroupBox1.Controls.Add(Me.PositionDurationLabel)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'TimeRemainingTXTLabel
        '
        resources.ApplyResources(Me.TimeRemainingTXTLabel, "TimeRemainingTXTLabel")
        Me.TimeRemainingTXTLabel.Name = "TimeRemainingTXTLabel"
        '
        'TimeRemainingLabel
        '
        resources.ApplyResources(Me.TimeRemainingLabel, "TimeRemainingLabel")
        Me.TimeRemainingLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
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
        Me.TimeElapsedLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TimeElapsedLabel.Name = "TimeElapsedLabel"
        '
        'ProcessingRateTXTLabel
        '
        resources.ApplyResources(Me.ProcessingRateTXTLabel, "ProcessingRateTXTLabel")
        Me.ProcessingRateTXTLabel.Name = "ProcessingRateTXTLabel"
        '
        'ProcessingRateLabel
        '
        resources.ApplyResources(Me.ProcessingRateLabel, "ProcessingRateLabel")
        Me.ProcessingRateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ProcessingRateLabel.Name = "ProcessingRateLabel"
        '
        'BitrateTXTLabel
        '
        resources.ApplyResources(Me.BitrateTXTLabel, "BitrateTXTLabel")
        Me.BitrateTXTLabel.Name = "BitrateTXTLabel"
        '
        'BitrateLabel
        '
        resources.ApplyResources(Me.BitrateLabel, "BitrateLabel")
        Me.BitrateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BitrateLabel.Name = "BitrateLabel"
        '
        'QTXTLabel
        '
        resources.ApplyResources(Me.QTXTLabel, "QTXTLabel")
        Me.QTXTLabel.Name = "QTXTLabel"
        '
        'QLabel
        '
        resources.ApplyResources(Me.QLabel, "QLabel")
        Me.QLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.QLabel.Name = "QLabel"
        '
        'FilesizeTXTLabel
        '
        resources.ApplyResources(Me.FilesizeTXTLabel, "FilesizeTXTLabel")
        Me.FilesizeTXTLabel.Name = "FilesizeTXTLabel"
        '
        'FilesizeLabel
        '
        resources.ApplyResources(Me.FilesizeLabel, "FilesizeLabel")
        Me.FilesizeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FilesizeLabel.Name = "FilesizeLabel"
        '
        'FrameTXTLabel
        '
        resources.ApplyResources(Me.FrameTXTLabel, "FrameTXTLabel")
        Me.FrameTXTLabel.Name = "FrameTXTLabel"
        '
        'FrameLabel
        '
        resources.ApplyResources(Me.FrameLabel, "FrameLabel")
        Me.FrameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FrameLabel.Name = "FrameLabel"
        '
        'PositionDurationTXTLabel
        '
        resources.ApplyResources(Me.PositionDurationTXTLabel, "PositionDurationTXTLabel")
        Me.PositionDurationTXTLabel.Name = "PositionDurationTXTLabel"
        '
        'PositionDurationLabel
        '
        resources.ApplyResources(Me.PositionDurationLabel, "PositionDurationLabel")
        Me.PositionDurationLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PositionDurationLabel.Name = "PositionDurationLabel"
        '
        'ProgressBar
        '
        resources.ApplyResources(Me.ProgressBar, "ProgressBar")
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'LogStr
        '
        resources.ApplyResources(Me.LogStr, "LogStr")
        Me.LogStr.Name = "LogStr"
        '
        'EncPanel
        '
        Me.EncPanel.Controls.Add(Me.InfoTextBox)
        Me.EncPanel.Controls.Add(Me.ShutdownCheckBox)
        Me.EncPanel.Controls.Add(Me.StatusStrip1)
        Me.EncPanel.Controls.Add(Me.PriorityComboBox)
        Me.EncPanel.Controls.Add(Me.SuspendResumeButton)
        Me.EncPanel.Controls.Add(Me.ForceStopButton)
        Me.EncPanel.Controls.Add(Me.OutputBox_EI)
        Me.EncPanel.Controls.Add(Me.ProgressLabel)
        Me.EncPanel.Controls.Add(Me.ProgressBar)
        Me.EncPanel.Controls.Add(Me.GroupBox1)
        Me.EncPanel.Controls.Add(Me.StopButton)
        Me.EncPanel.Controls.Add(Me.PriorityLabel)
        resources.ApplyResources(Me.EncPanel, "EncPanel")
        Me.EncPanel.Name = "EncPanel"
        '
        'ShutdownCheckBox
        '
        resources.ApplyResources(Me.ShutdownCheckBox, "ShutdownCheckBox")
        Me.ShutdownCheckBox.Name = "ShutdownCheckBox"
        Me.ShutdownCheckBox.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EncToolStripStatusLabel})
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
        'PriorityComboBox
        '
        Me.PriorityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PriorityComboBox.FormattingEnabled = True
        resources.ApplyResources(Me.PriorityComboBox, "PriorityComboBox")
        Me.PriorityComboBox.Name = "PriorityComboBox"
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
        'ProgressLabel
        '
        resources.ApplyResources(Me.ProgressLabel, "ProgressLabel")
        Me.ProgressLabel.Name = "ProgressLabel"
        '
        'PriorityLabel
        '
        resources.ApplyResources(Me.PriorityLabel, "PriorityLabel")
        Me.PriorityLabel.Name = "PriorityLabel"
        '
        'TimeElapsedTimer
        '
        Me.TimeElapsedTimer.Interval = 1000
        '
        'CapTimer
        '
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
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OutputBox_EI As System.Windows.Forms.TextBox
    Friend WithEvents StopButton As System.Windows.Forms.Button
    Friend WithEvents IndexTimer As System.Windows.Forms.Timer
    Friend WithEvents InfoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LogStr As System.Windows.Forms.Label
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
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
    Friend WithEvents ProcessingRateTXTLabel As System.Windows.Forms.Label
    Friend WithEvents ProcessingRateLabel As System.Windows.Forms.Label
    Friend WithEvents TimeRemainingTXTLabel As System.Windows.Forms.Label
    Friend WithEvents TimeRemainingLabel As System.Windows.Forms.Label
    Friend WithEvents TimeElapsedTXTLabel As System.Windows.Forms.Label
    Friend WithEvents TimeElapsedLabel As System.Windows.Forms.Label
    Friend WithEvents TimeElapsedTimer As System.Windows.Forms.Timer
    Friend WithEvents ProgressLabel As System.Windows.Forms.Label
    Friend WithEvents ForceStopButton As System.Windows.Forms.Button
    Friend WithEvents SuspendResumeButton As System.Windows.Forms.Button
    Friend WithEvents PriorityLabel As System.Windows.Forms.Label
    Friend WithEvents PriorityComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ShutdownCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents CapTimer As System.Windows.Forms.Timer
    Friend WithEvents EncToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
End Class
