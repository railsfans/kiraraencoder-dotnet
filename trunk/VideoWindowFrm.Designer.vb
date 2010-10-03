<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VideoWindowFrm
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
        Me.VideoTrackBar = New System.Windows.Forms.TrackBar
        Me.VideoWindowPanel = New System.Windows.Forms.Panel
        Me.VideoPictureBox = New System.Windows.Forms.PictureBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.NNFButton = New System.Windows.Forms.Button
        Me.PPFButton = New System.Windows.Forms.Button
        Me.StopButton = New System.Windows.Forms.Button
        Me.PlayButton = New System.Windows.Forms.Button
        Me.PFButton = New System.Windows.Forms.Button
        Me.NFButton = New System.Windows.Forms.Button
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.MoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SizeModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RealtimeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.FrameTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.VideoTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VideoWindowPanel.SuspendLayout()
        CType(Me.VideoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'VideoTrackBar
        '
        Me.VideoTrackBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VideoTrackBar.Location = New System.Drawing.Point(251, -3)
        Me.VideoTrackBar.Name = "VideoTrackBar"
        Me.VideoTrackBar.Size = New System.Drawing.Size(226, 45)
        Me.VideoTrackBar.TabIndex = 15
        Me.VideoTrackBar.TickFrequency = 0
        Me.VideoTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'VideoWindowPanel
        '
        Me.VideoWindowPanel.Controls.Add(Me.VideoPictureBox)
        Me.VideoWindowPanel.Controls.Add(Me.Panel2)
        Me.VideoWindowPanel.Controls.Add(Me.MenuStrip1)
        Me.VideoWindowPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VideoWindowPanel.Location = New System.Drawing.Point(0, 0)
        Me.VideoWindowPanel.Name = "VideoWindowPanel"
        Me.VideoWindowPanel.Size = New System.Drawing.Size(480, 331)
        Me.VideoWindowPanel.TabIndex = 17
        '
        'VideoPictureBox
        '
        Me.VideoPictureBox.BackColor = System.Drawing.Color.DarkGray
        Me.VideoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VideoPictureBox.Location = New System.Drawing.Point(0, 24)
        Me.VideoPictureBox.Name = "VideoPictureBox"
        Me.VideoPictureBox.Size = New System.Drawing.Size(480, 272)
        Me.VideoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.VideoPictureBox.TabIndex = 18
        Me.VideoPictureBox.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.VideoTrackBar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 296)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(480, 35)
        Me.Panel2.TabIndex = 17
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.NNFButton)
        Me.Panel3.Controls.Add(Me.PPFButton)
        Me.Panel3.Controls.Add(Me.StopButton)
        Me.Panel3.Controls.Add(Me.PlayButton)
        Me.Panel3.Controls.Add(Me.PFButton)
        Me.Panel3.Controls.Add(Me.NFButton)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(252, 35)
        Me.Panel3.TabIndex = 16
        '
        'NNFButton
        '
        Me.NNFButton.Location = New System.Drawing.Point(206, 5)
        Me.NNFButton.Name = "NNFButton"
        Me.NNFButton.Size = New System.Drawing.Size(42, 25)
        Me.NNFButton.TabIndex = 5
        Me.NNFButton.Text = ">>"
        Me.NNFButton.UseVisualStyleBackColor = True
        '
        'PPFButton
        '
        Me.PPFButton.Location = New System.Drawing.Point(90, 5)
        Me.PPFButton.Name = "PPFButton"
        Me.PPFButton.Size = New System.Drawing.Size(42, 25)
        Me.PPFButton.TabIndex = 2
        Me.PPFButton.Text = "<<"
        Me.PPFButton.UseVisualStyleBackColor = True
        '
        'StopButton
        '
        Me.StopButton.Location = New System.Drawing.Point(56, 5)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(28, 25)
        Me.StopButton.TabIndex = 1
        Me.StopButton.Text = "[]"
        Me.StopButton.UseVisualStyleBackColor = True
        '
        'PlayButton
        '
        Me.PlayButton.Location = New System.Drawing.Point(8, 5)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(42, 25)
        Me.PlayButton.TabIndex = 0
        Me.PlayButton.Text = ">||"
        Me.PlayButton.UseVisualStyleBackColor = True
        '
        'PFButton
        '
        Me.PFButton.Location = New System.Drawing.Point(138, 5)
        Me.PFButton.Name = "PFButton"
        Me.PFButton.Size = New System.Drawing.Size(28, 25)
        Me.PFButton.TabIndex = 3
        Me.PFButton.Text = "<"
        Me.PFButton.UseVisualStyleBackColor = True
        '
        'NFButton
        '
        Me.NFButton.Location = New System.Drawing.Point(172, 5)
        Me.NFButton.Name = "NFButton"
        Me.NFButton.Size = New System.Drawing.Size(28, 25)
        Me.NFButton.TabIndex = 4
        Me.NFButton.Text = ">"
        Me.NFButton.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MoveToolStripMenuItem, Me.SizeModeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(480, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MoveToolStripMenuItem
        '
        Me.MoveToolStripMenuItem.Name = "MoveToolStripMenuItem"
        Me.MoveToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.MoveToolStripMenuItem.Text = "이동"
        '
        'SizeModeToolStripMenuItem
        '
        Me.SizeModeToolStripMenuItem.Name = "SizeModeToolStripMenuItem"
        Me.SizeModeToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.SizeModeToolStripMenuItem.Text = "사이즈 모드"
        '
        'RealtimeTimer
        '
        Me.RealtimeTimer.Interval = 1
        '
        'FrameTimer
        '
        '
        'VideoWindowFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 331)
        Me.Controls.Add(Me.VideoWindowPanel)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "VideoWindowFrm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.VideoTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VideoWindowPanel.ResumeLayout(False)
        Me.VideoWindowPanel.PerformLayout()
        CType(Me.VideoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents VideoTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents VideoWindowPanel As System.Windows.Forms.Panel
    Friend WithEvents VideoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents NNFButton As System.Windows.Forms.Button
    Friend WithEvents NFButton As System.Windows.Forms.Button
    Friend WithEvents PFButton As System.Windows.Forms.Button
    Friend WithEvents PPFButton As System.Windows.Forms.Button
    Friend WithEvents StopButton As System.Windows.Forms.Button
    Friend WithEvents PlayButton As System.Windows.Forms.Button
    Friend WithEvents RealtimeTimer As System.Windows.Forms.Timer
    Friend WithEvents FrameTimer As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MoveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SizeModeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
End Class
