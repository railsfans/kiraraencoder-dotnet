﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VideoWindowFrm))
        Me.VideoTrackBar = New System.Windows.Forms.TrackBar
        Me.VideoWindowPanel = New System.Windows.Forms.Panel
        Me.VideoPictureBox = New System.Windows.Forms.PictureBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ETextBox = New System.Windows.Forms.TextBox
        Me.STextBox = New System.Windows.Forms.TextBox
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
        Me.ModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SetStartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SetEndToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ApplyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RealtimeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.FrameTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.VideoTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VideoWindowPanel.SuspendLayout()
        CType(Me.VideoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'VideoTrackBar
        '
        resources.ApplyResources(Me.VideoTrackBar, "VideoTrackBar")
        Me.VideoTrackBar.Name = "VideoTrackBar"
        Me.VideoTrackBar.TickFrequency = 0
        Me.VideoTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'VideoWindowPanel
        '
        Me.VideoWindowPanel.Controls.Add(Me.VideoPictureBox)
        Me.VideoWindowPanel.Controls.Add(Me.Panel1)
        Me.VideoWindowPanel.Controls.Add(Me.Panel2)
        Me.VideoWindowPanel.Controls.Add(Me.MenuStrip1)
        resources.ApplyResources(Me.VideoWindowPanel, "VideoWindowPanel")
        Me.VideoWindowPanel.Name = "VideoWindowPanel"
        '
        'VideoPictureBox
        '
        Me.VideoPictureBox.BackColor = System.Drawing.Color.DarkGray
        resources.ApplyResources(Me.VideoPictureBox, "VideoPictureBox")
        Me.VideoPictureBox.Name = "VideoPictureBox"
        Me.VideoPictureBox.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ETextBox)
        Me.Panel1.Controls.Add(Me.STextBox)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'ETextBox
        '
        resources.ApplyResources(Me.ETextBox, "ETextBox")
        Me.ETextBox.Name = "ETextBox"
        Me.ETextBox.ReadOnly = True
        '
        'STextBox
        '
        resources.ApplyResources(Me.STextBox, "STextBox")
        Me.STextBox.Name = "STextBox"
        Me.STextBox.ReadOnly = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.VideoTrackBar)
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.NNFButton)
        Me.Panel3.Controls.Add(Me.PPFButton)
        Me.Panel3.Controls.Add(Me.StopButton)
        Me.Panel3.Controls.Add(Me.PlayButton)
        Me.Panel3.Controls.Add(Me.PFButton)
        Me.Panel3.Controls.Add(Me.NFButton)
        resources.ApplyResources(Me.Panel3, "Panel3")
        Me.Panel3.Name = "Panel3"
        '
        'NNFButton
        '
        resources.ApplyResources(Me.NNFButton, "NNFButton")
        Me.NNFButton.Name = "NNFButton"
        Me.NNFButton.UseVisualStyleBackColor = True
        '
        'PPFButton
        '
        resources.ApplyResources(Me.PPFButton, "PPFButton")
        Me.PPFButton.Name = "PPFButton"
        Me.PPFButton.UseVisualStyleBackColor = True
        '
        'StopButton
        '
        resources.ApplyResources(Me.StopButton, "StopButton")
        Me.StopButton.Name = "StopButton"
        Me.StopButton.UseVisualStyleBackColor = True
        '
        'PlayButton
        '
        resources.ApplyResources(Me.PlayButton, "PlayButton")
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.UseVisualStyleBackColor = True
        '
        'PFButton
        '
        resources.ApplyResources(Me.PFButton, "PFButton")
        Me.PFButton.Name = "PFButton"
        Me.PFButton.UseVisualStyleBackColor = True
        '
        'NFButton
        '
        resources.ApplyResources(Me.NFButton, "NFButton")
        Me.NFButton.Name = "NFButton"
        Me.NFButton.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MoveToolStripMenuItem, Me.SizeModeToolStripMenuItem, Me.ModeToolStripMenuItem, Me.SetStartToolStripMenuItem, Me.SetEndToolStripMenuItem, Me.ApplyToolStripMenuItem})
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'MoveToolStripMenuItem
        '
        Me.MoveToolStripMenuItem.Name = "MoveToolStripMenuItem"
        resources.ApplyResources(Me.MoveToolStripMenuItem, "MoveToolStripMenuItem")
        '
        'SizeModeToolStripMenuItem
        '
        Me.SizeModeToolStripMenuItem.Name = "SizeModeToolStripMenuItem"
        resources.ApplyResources(Me.SizeModeToolStripMenuItem, "SizeModeToolStripMenuItem")
        '
        'ModeToolStripMenuItem
        '
        Me.ModeToolStripMenuItem.Name = "ModeToolStripMenuItem"
        resources.ApplyResources(Me.ModeToolStripMenuItem, "ModeToolStripMenuItem")
        '
        'SetStartToolStripMenuItem
        '
        Me.SetStartToolStripMenuItem.Name = "SetStartToolStripMenuItem"
        resources.ApplyResources(Me.SetStartToolStripMenuItem, "SetStartToolStripMenuItem")
        '
        'SetEndToolStripMenuItem
        '
        Me.SetEndToolStripMenuItem.Name = "SetEndToolStripMenuItem"
        resources.ApplyResources(Me.SetEndToolStripMenuItem, "SetEndToolStripMenuItem")
        '
        'ApplyToolStripMenuItem
        '
        resources.ApplyResources(Me.ApplyToolStripMenuItem, "ApplyToolStripMenuItem")
        Me.ApplyToolStripMenuItem.Name = "ApplyToolStripMenuItem"
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
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.VideoWindowPanel)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "VideoWindowFrm"
        Me.ShowIcon = False
        CType(Me.VideoTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VideoWindowPanel.ResumeLayout(False)
        Me.VideoWindowPanel.PerformLayout()
        CType(Me.VideoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
    Friend WithEvents SetStartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetEndToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ETextBox As System.Windows.Forms.TextBox
    Friend WithEvents STextBox As System.Windows.Forms.TextBox
    Friend WithEvents ApplyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

    Public Sub New()

        ' 이 호출은 Windows Form 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

    End Sub
End Class
