<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PreviewFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PreviewFrm))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.MovePanel = New System.Windows.Forms.Panel
        Me.DMVideoWindow = New KiraraPlayer.DMControl
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.RendererToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OverlayMixerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VideoMixingRenderer7WindowlessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VideoMixingRenderer9WindowedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VideoMixingRenderer9WindowlessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EnhancedVideoRendererToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HaaliVideoRendererToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.madVRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FilterControlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MovePanel.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MovePanel
        '
        Me.MovePanel.BackColor = System.Drawing.Color.Black
        Me.MovePanel.Controls.Add(Me.DMVideoWindow)
        resources.ApplyResources(Me.MovePanel, "MovePanel")
        Me.MovePanel.Name = "MovePanel"
        '
        'DMVideoWindow
        '
        Me.DMVideoWindow.BackColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.DMVideoWindow, "DMVideoWindow")
        Me.DMVideoWindow.Name = "DMVideoWindow"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.CloseToolStripMenuItem, Me.RefreshToolStripMenuItem, Me.ToolStripMenuItem2, Me.RendererToolStripMenuItem, Me.FilterControlToolStripMenuItem, Me.ToolStripMenuItem1, Me.AboutToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        resources.ApplyResources(Me.ContextMenuStrip1, "ContextMenuStrip1")
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        resources.ApplyResources(Me.OpenToolStripMenuItem, "OpenToolStripMenuItem")
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        resources.ApplyResources(Me.CloseToolStripMenuItem, "CloseToolStripMenuItem")
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        resources.ApplyResources(Me.ToolStripMenuItem2, "ToolStripMenuItem2")
        '
        'RendererToolStripMenuItem
        '
        Me.RendererToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OverlayMixerToolStripMenuItem, Me.VideoMixingRenderer7WindowlessToolStripMenuItem, Me.VideoMixingRenderer9WindowedToolStripMenuItem, Me.VideoMixingRenderer9WindowlessToolStripMenuItem, Me.EnhancedVideoRendererToolStripMenuItem, Me.HaaliVideoRendererToolStripMenuItem, Me.madVRToolStripMenuItem})
        Me.RendererToolStripMenuItem.Name = "RendererToolStripMenuItem"
        resources.ApplyResources(Me.RendererToolStripMenuItem, "RendererToolStripMenuItem")
        '
        'OverlayMixerToolStripMenuItem
        '
        Me.OverlayMixerToolStripMenuItem.Name = "OverlayMixerToolStripMenuItem"
        resources.ApplyResources(Me.OverlayMixerToolStripMenuItem, "OverlayMixerToolStripMenuItem")
        '
        'VideoMixingRenderer7WindowlessToolStripMenuItem
        '
        Me.VideoMixingRenderer7WindowlessToolStripMenuItem.Name = "VideoMixingRenderer7WindowlessToolStripMenuItem"
        resources.ApplyResources(Me.VideoMixingRenderer7WindowlessToolStripMenuItem, "VideoMixingRenderer7WindowlessToolStripMenuItem")
        '
        'VideoMixingRenderer9WindowedToolStripMenuItem
        '
        Me.VideoMixingRenderer9WindowedToolStripMenuItem.Checked = True
        Me.VideoMixingRenderer9WindowedToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.VideoMixingRenderer9WindowedToolStripMenuItem.Name = "VideoMixingRenderer9WindowedToolStripMenuItem"
        resources.ApplyResources(Me.VideoMixingRenderer9WindowedToolStripMenuItem, "VideoMixingRenderer9WindowedToolStripMenuItem")
        '
        'VideoMixingRenderer9WindowlessToolStripMenuItem
        '
        Me.VideoMixingRenderer9WindowlessToolStripMenuItem.Name = "VideoMixingRenderer9WindowlessToolStripMenuItem"
        resources.ApplyResources(Me.VideoMixingRenderer9WindowlessToolStripMenuItem, "VideoMixingRenderer9WindowlessToolStripMenuItem")
        '
        'EnhancedVideoRendererToolStripMenuItem
        '
        Me.EnhancedVideoRendererToolStripMenuItem.Name = "EnhancedVideoRendererToolStripMenuItem"
        resources.ApplyResources(Me.EnhancedVideoRendererToolStripMenuItem, "EnhancedVideoRendererToolStripMenuItem")
        '
        'HaaliVideoRendererToolStripMenuItem
        '
        Me.HaaliVideoRendererToolStripMenuItem.Name = "HaaliVideoRendererToolStripMenuItem"
        resources.ApplyResources(Me.HaaliVideoRendererToolStripMenuItem, "HaaliVideoRendererToolStripMenuItem")
        '
        'madVRToolStripMenuItem
        '
        Me.madVRToolStripMenuItem.Name = "madVRToolStripMenuItem"
        resources.ApplyResources(Me.madVRToolStripMenuItem, "madVRToolStripMenuItem")
        '
        'FilterControlToolStripMenuItem
        '
        Me.FilterControlToolStripMenuItem.Name = "FilterControlToolStripMenuItem"
        resources.ApplyResources(Me.FilterControlToolStripMenuItem, "FilterControlToolStripMenuItem")
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        resources.ApplyResources(Me.ToolStripMenuItem1, "ToolStripMenuItem1")
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        resources.ApplyResources(Me.AboutToolStripMenuItem, "AboutToolStripMenuItem")
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        resources.ApplyResources(Me.QuitToolStripMenuItem, "QuitToolStripMenuItem")
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        resources.ApplyResources(Me.RefreshToolStripMenuItem, "RefreshToolStripMenuItem")
        '
        'PreviewFrm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.MovePanel)
        Me.KeyPreview = True
        Me.Name = "PreviewFrm"
        Me.TopMost = True
        Me.MovePanel.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DMVideoWindow As KiraraPlayer.DMControl
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents MovePanel As System.Windows.Forms.Panel
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents QuitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FilterControlToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RendererToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OverlayMixerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VideoMixingRenderer7WindowlessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents VideoMixingRenderer9WindowedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VideoMixingRenderer9WindowlessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnhancedVideoRendererToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HaaliVideoRendererToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents madVRToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
