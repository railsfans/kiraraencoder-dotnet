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
        Me.PriorityLabel = New System.Windows.Forms.Label
        Me.PriorityComboBox = New System.Windows.Forms.ComboBox
        Me.SuspendResumeButton = New System.Windows.Forms.Button
        Me.ForceStopButton = New System.Windows.Forms.Button
        Me.ProgressLabel = New System.Windows.Forms.Label
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
        Me.OutputBox_EI.Location = New System.Drawing.Point(119, 214)
        Me.OutputBox_EI.MaxLength = 2147483647
        Me.OutputBox_EI.Multiline = True
        Me.OutputBox_EI.Name = "OutputBox_EI"
        Me.OutputBox_EI.ReadOnly = True
        Me.OutputBox_EI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.OutputBox_EI.Size = New System.Drawing.Size(25, 25)
        Me.OutputBox_EI.TabIndex = 22
        Me.OutputBox_EI.Visible = False
        '
        'StopButton
        '
        Me.StopButton.Location = New System.Drawing.Point(244, 301)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(100, 25)
        Me.StopButton.TabIndex = 24
        Me.StopButton.Text = "중지"
        Me.StopButton.UseVisualStyleBackColor = True
        '
        'IndexTimer
        '
        Me.IndexTimer.Interval = 1
        '
        'InfoTextBox
        '
        Me.InfoTextBox.BackColor = System.Drawing.Color.White
        Me.InfoTextBox.Location = New System.Drawing.Point(90, 214)
        Me.InfoTextBox.MaxLength = 2147483647
        Me.InfoTextBox.Multiline = True
        Me.InfoTextBox.Name = "InfoTextBox"
        Me.InfoTextBox.ReadOnly = True
        Me.InfoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.InfoTextBox.Size = New System.Drawing.Size(25, 25)
        Me.InfoTextBox.TabIndex = 30
        Me.InfoTextBox.Visible = False
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(332, 200)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        '
        'TimeRemainingTXTLabel
        '
        Me.TimeRemainingTXTLabel.Location = New System.Drawing.Point(14, 171)
        Me.TimeRemainingTXTLabel.Name = "TimeRemainingTXTLabel"
        Me.TimeRemainingTXTLabel.Size = New System.Drawing.Size(118, 20)
        Me.TimeRemainingTXTLabel.TabIndex = 47
        Me.TimeRemainingTXTLabel.Text = "남은시간:"
        Me.TimeRemainingTXTLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TimeRemainingLabel
        '
        Me.TimeRemainingLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TimeRemainingLabel.Location = New System.Drawing.Point(138, 171)
        Me.TimeRemainingLabel.Name = "TimeRemainingLabel"
        Me.TimeRemainingLabel.Size = New System.Drawing.Size(181, 20)
        Me.TimeRemainingLabel.TabIndex = 46
        Me.TimeRemainingLabel.Text = "---"
        Me.TimeRemainingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TimeElapsedTXTLabel
        '
        Me.TimeElapsedTXTLabel.Location = New System.Drawing.Point(14, 149)
        Me.TimeElapsedTXTLabel.Name = "TimeElapsedTXTLabel"
        Me.TimeElapsedTXTLabel.Size = New System.Drawing.Size(118, 20)
        Me.TimeElapsedTXTLabel.TabIndex = 45
        Me.TimeElapsedTXTLabel.Text = "경과시간:"
        Me.TimeElapsedTXTLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TimeElapsedLabel
        '
        Me.TimeElapsedLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TimeElapsedLabel.Location = New System.Drawing.Point(138, 149)
        Me.TimeElapsedLabel.Name = "TimeElapsedLabel"
        Me.TimeElapsedLabel.Size = New System.Drawing.Size(181, 20)
        Me.TimeElapsedLabel.TabIndex = 44
        Me.TimeElapsedLabel.Text = "---"
        Me.TimeElapsedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ProcessingRateTXTLabel
        '
        Me.ProcessingRateTXTLabel.Location = New System.Drawing.Point(14, 127)
        Me.ProcessingRateTXTLabel.Name = "ProcessingRateTXTLabel"
        Me.ProcessingRateTXTLabel.Size = New System.Drawing.Size(118, 20)
        Me.ProcessingRateTXTLabel.TabIndex = 43
        Me.ProcessingRateTXTLabel.Text = "속도:"
        Me.ProcessingRateTXTLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ProcessingRateLabel
        '
        Me.ProcessingRateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ProcessingRateLabel.Location = New System.Drawing.Point(138, 127)
        Me.ProcessingRateLabel.Name = "ProcessingRateLabel"
        Me.ProcessingRateLabel.Size = New System.Drawing.Size(181, 20)
        Me.ProcessingRateLabel.TabIndex = 42
        Me.ProcessingRateLabel.Text = "---"
        Me.ProcessingRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BitrateTXTLabel
        '
        Me.BitrateTXTLabel.Location = New System.Drawing.Point(14, 105)
        Me.BitrateTXTLabel.Name = "BitrateTXTLabel"
        Me.BitrateTXTLabel.Size = New System.Drawing.Size(118, 20)
        Me.BitrateTXTLabel.TabIndex = 41
        Me.BitrateTXTLabel.Text = "비트레이트:"
        Me.BitrateTXTLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BitrateLabel
        '
        Me.BitrateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BitrateLabel.Location = New System.Drawing.Point(138, 105)
        Me.BitrateLabel.Name = "BitrateLabel"
        Me.BitrateLabel.Size = New System.Drawing.Size(181, 20)
        Me.BitrateLabel.TabIndex = 40
        Me.BitrateLabel.Text = "---"
        Me.BitrateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'QTXTLabel
        '
        Me.QTXTLabel.Location = New System.Drawing.Point(14, 83)
        Me.QTXTLabel.Name = "QTXTLabel"
        Me.QTXTLabel.Size = New System.Drawing.Size(118, 20)
        Me.QTXTLabel.TabIndex = 39
        Me.QTXTLabel.Text = "큐:"
        Me.QTXTLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'QLabel
        '
        Me.QLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.QLabel.Location = New System.Drawing.Point(138, 83)
        Me.QLabel.Name = "QLabel"
        Me.QLabel.Size = New System.Drawing.Size(181, 20)
        Me.QLabel.TabIndex = 38
        Me.QLabel.Text = "---"
        Me.QLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FilesizeTXTLabel
        '
        Me.FilesizeTXTLabel.Location = New System.Drawing.Point(14, 61)
        Me.FilesizeTXTLabel.Name = "FilesizeTXTLabel"
        Me.FilesizeTXTLabel.Size = New System.Drawing.Size(118, 20)
        Me.FilesizeTXTLabel.TabIndex = 37
        Me.FilesizeTXTLabel.Text = "파일크기:"
        Me.FilesizeTXTLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FilesizeLabel
        '
        Me.FilesizeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FilesizeLabel.Location = New System.Drawing.Point(138, 61)
        Me.FilesizeLabel.Name = "FilesizeLabel"
        Me.FilesizeLabel.Size = New System.Drawing.Size(181, 20)
        Me.FilesizeLabel.TabIndex = 36
        Me.FilesizeLabel.Text = "---"
        Me.FilesizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrameTXTLabel
        '
        Me.FrameTXTLabel.Location = New System.Drawing.Point(14, 39)
        Me.FrameTXTLabel.Name = "FrameTXTLabel"
        Me.FrameTXTLabel.Size = New System.Drawing.Size(118, 20)
        Me.FrameTXTLabel.TabIndex = 35
        Me.FrameTXTLabel.Text = "프레임:"
        Me.FrameTXTLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrameLabel
        '
        Me.FrameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FrameLabel.Location = New System.Drawing.Point(138, 39)
        Me.FrameLabel.Name = "FrameLabel"
        Me.FrameLabel.Size = New System.Drawing.Size(181, 20)
        Me.FrameLabel.TabIndex = 34
        Me.FrameLabel.Text = "---"
        Me.FrameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PositionDurationTXTLabel
        '
        Me.PositionDurationTXTLabel.Location = New System.Drawing.Point(14, 17)
        Me.PositionDurationTXTLabel.Name = "PositionDurationTXTLabel"
        Me.PositionDurationTXTLabel.Size = New System.Drawing.Size(118, 20)
        Me.PositionDurationTXTLabel.TabIndex = 33
        Me.PositionDurationTXTLabel.Text = "진행위치:"
        Me.PositionDurationTXTLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PositionDurationLabel
        '
        Me.PositionDurationLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PositionDurationLabel.Location = New System.Drawing.Point(138, 17)
        Me.PositionDurationLabel.Name = "PositionDurationLabel"
        Me.PositionDurationLabel.Size = New System.Drawing.Size(181, 20)
        Me.PositionDurationLabel.TabIndex = 32
        Me.PositionDurationLabel.Text = "--- / ---"
        Me.PositionDurationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(150, 212)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(194, 22)
        Me.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar.TabIndex = 32
        '
        'LogStr
        '
        Me.LogStr.Location = New System.Drawing.Point(53, 209)
        Me.LogStr.Name = "LogStr"
        Me.LogStr.Size = New System.Drawing.Size(494, 20)
        Me.LogStr.TabIndex = 1
        '
        'EncPanel
        '
        Me.EncPanel.Controls.Add(Me.InfoTextBox)
        Me.EncPanel.Controls.Add(Me.ShutdownCheckBox)
        Me.EncPanel.Controls.Add(Me.StatusStrip1)
        Me.EncPanel.Controls.Add(Me.PriorityLabel)
        Me.EncPanel.Controls.Add(Me.PriorityComboBox)
        Me.EncPanel.Controls.Add(Me.SuspendResumeButton)
        Me.EncPanel.Controls.Add(Me.ForceStopButton)
        Me.EncPanel.Controls.Add(Me.OutputBox_EI)
        Me.EncPanel.Controls.Add(Me.ProgressLabel)
        Me.EncPanel.Controls.Add(Me.ProgressBar)
        Me.EncPanel.Controls.Add(Me.GroupBox1)
        Me.EncPanel.Controls.Add(Me.StopButton)
        Me.EncPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EncPanel.Location = New System.Drawing.Point(0, 0)
        Me.EncPanel.Name = "EncPanel"
        Me.EncPanel.Size = New System.Drawing.Size(358, 361)
        Me.EncPanel.TabIndex = 33
        '
        'ShutdownCheckBox
        '
        Me.ShutdownCheckBox.AutoSize = True
        Me.ShutdownCheckBox.Location = New System.Drawing.Point(12, 274)
        Me.ShutdownCheckBox.Name = "ShutdownCheckBox"
        Me.ShutdownCheckBox.Size = New System.Drawing.Size(172, 16)
        Me.ShutdownCheckBox.TabIndex = 55
        Me.ShutdownCheckBox.Text = "인코딩 완료 후 시스템 종료"
        Me.ShutdownCheckBox.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EncToolStripStatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 339)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(358, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 54
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'EncToolStripStatusLabel
        '
        Me.EncToolStripStatusLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EncToolStripStatusLabel.Name = "EncToolStripStatusLabel"
        Me.EncToolStripStatusLabel.Size = New System.Drawing.Size(343, 17)
        Me.EncToolStripStatusLabel.Spring = True
        Me.EncToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PriorityLabel
        '
        Me.PriorityLabel.Location = New System.Drawing.Point(12, 240)
        Me.PriorityLabel.Name = "PriorityLabel"
        Me.PriorityLabel.Size = New System.Drawing.Size(132, 20)
        Me.PriorityLabel.TabIndex = 53
        Me.PriorityLabel.Text = "우선순위:"
        Me.PriorityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PriorityComboBox
        '
        Me.PriorityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PriorityComboBox.FormattingEnabled = True
        Me.PriorityComboBox.Location = New System.Drawing.Point(150, 240)
        Me.PriorityComboBox.Name = "PriorityComboBox"
        Me.PriorityComboBox.Size = New System.Drawing.Size(194, 20)
        Me.PriorityComboBox.TabIndex = 51
        '
        'SuspendResumeButton
        '
        Me.SuspendResumeButton.Enabled = False
        Me.SuspendResumeButton.Location = New System.Drawing.Point(12, 301)
        Me.SuspendResumeButton.Name = "SuspendResumeButton"
        Me.SuspendResumeButton.Size = New System.Drawing.Size(100, 25)
        Me.SuspendResumeButton.TabIndex = 50
        Me.SuspendResumeButton.Text = "일시 정지"
        Me.SuspendResumeButton.UseVisualStyleBackColor = True
        '
        'ForceStopButton
        '
        Me.ForceStopButton.Location = New System.Drawing.Point(138, 301)
        Me.ForceStopButton.Name = "ForceStopButton"
        Me.ForceStopButton.Size = New System.Drawing.Size(100, 25)
        Me.ForceStopButton.TabIndex = 49
        Me.ForceStopButton.Text = "강제중지"
        Me.ForceStopButton.UseVisualStyleBackColor = True
        '
        'ProgressLabel
        '
        Me.ProgressLabel.Location = New System.Drawing.Point(12, 212)
        Me.ProgressLabel.Name = "ProgressLabel"
        Me.ProgressLabel.Size = New System.Drawing.Size(132, 20)
        Me.ProgressLabel.TabIndex = 48
        Me.ProgressLabel.Text = "진행률:"
        Me.ProgressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 361)
        Me.Controls.Add(Me.EncPanel)
        Me.Controls.Add(Me.LogStr)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "EncodingFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
