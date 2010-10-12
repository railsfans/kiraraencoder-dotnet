<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AviSynthEditorFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AviSynthEditorFrm))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.LineColToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.Def_FFmpegSourceTextBox = New System.Windows.Forms.TextBox
        Me.FFmpegSourceTextBox = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ConPanel = New System.Windows.Forms.Panel
        Me.PreviewButton = New System.Windows.Forms.Button
        Me.ListenButton = New System.Windows.Forms.Button
        Me.RefButton = New System.Windows.Forms.Button
        Me.SubSButton = New System.Windows.Forms.Button
        Me.AudSButton = New System.Windows.Forms.Button
        Me.ImgSButton = New System.Windows.Forms.Button
        Me.ChannelTextBox = New System.Windows.Forms.TextBox
        Me.Def_ChannelTextBox = New System.Windows.Forms.TextBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.ScriptTextBox = New System.Windows.Forms.TextBox
        Me.FFmpegSourceTabPage = New System.Windows.Forms.TabPage
        Me.FFmpegSourceLabel = New System.Windows.Forms.Label
        Me.MPEG2SourceTabPage = New System.Windows.Forms.TabPage
        Me.MPEG2SourceLabel = New System.Windows.Forms.Label
        Me.Def_MPEG2SourceTextBox = New System.Windows.Forms.TextBox
        Me.MPEG2SourceTextBox = New System.Windows.Forms.TextBox
        Me.AVCTabPage = New System.Windows.Forms.TabPage
        Me.AVCLabel = New System.Windows.Forms.Label
        Me.Def_AVCTextBox = New System.Windows.Forms.TextBox
        Me.AVCTextBox = New System.Windows.Forms.TextBox
        Me.VC1TabPage = New System.Windows.Forms.TabPage
        Me.VC1Label = New System.Windows.Forms.Label
        Me.Def_VC1TextBox = New System.Windows.Forms.TextBox
        Me.VC1TextBox = New System.Windows.Forms.TextBox
        Me.BassAudioTabPage = New System.Windows.Forms.TabPage
        Me.BassAudioLabel = New System.Windows.Forms.Label
        Me.Def_BassAudioTextBox = New System.Windows.Forms.TextBox
        Me.BassAudioTextBox = New System.Windows.Forms.TextBox
        Me.NicAudioTabPage = New System.Windows.Forms.TabPage
        Me.NicAudioLabel = New System.Windows.Forms.Label
        Me.Def_NicAudioTextBox = New System.Windows.Forms.TextBox
        Me.NicAudioTextBox = New System.Windows.Forms.TextBox
        Me.ChannelScriptTabPage = New System.Windows.Forms.TabPage
        Me.ChannelLabel = New System.Windows.Forms.Label
        Me.ProcessDetTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PluginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InitializationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PresetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AVSPanel = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.CancelBTN = New System.Windows.Forms.Button
        Me.OKBTN = New System.Windows.Forms.Button
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ConPanel.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.FFmpegSourceTabPage.SuspendLayout()
        Me.MPEG2SourceTabPage.SuspendLayout()
        Me.AVCTabPage.SuspendLayout()
        Me.VC1TabPage.SuspendLayout()
        Me.BassAudioTabPage.SuspendLayout()
        Me.NicAudioTabPage.SuspendLayout()
        Me.ChannelScriptTabPage.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.AVSPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.LineColToolStripStatusLabel})
        resources.ApplyResources(Me.StatusStrip1, "StatusStrip1")
        Me.StatusStrip1.Name = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        resources.ApplyResources(Me.ToolStripStatusLabel1, "ToolStripStatusLabel1")
        Me.ToolStripStatusLabel1.Spring = True
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        resources.ApplyResources(Me.ToolStripStatusLabel2, "ToolStripStatusLabel2")
        Me.ToolStripStatusLabel2.Spring = True
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        resources.ApplyResources(Me.ToolStripStatusLabel3, "ToolStripStatusLabel3")
        Me.ToolStripStatusLabel3.Spring = True
        '
        'LineColToolStripStatusLabel
        '
        resources.ApplyResources(Me.LineColToolStripStatusLabel, "LineColToolStripStatusLabel")
        Me.LineColToolStripStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.LineColToolStripStatusLabel.Name = "LineColToolStripStatusLabel"
        Me.LineColToolStripStatusLabel.Spring = True
        '
        'Def_FFmpegSourceTextBox
        '
        Me.Def_FFmpegSourceTextBox.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.Def_FFmpegSourceTextBox, "Def_FFmpegSourceTextBox")
        Me.Def_FFmpegSourceTextBox.Name = "Def_FFmpegSourceTextBox"
        '
        'FFmpegSourceTextBox
        '
        resources.ApplyResources(Me.FFmpegSourceTextBox, "FFmpegSourceTextBox")
        Me.FFmpegSourceTextBox.BackColor = System.Drawing.Color.White
        Me.FFmpegSourceTextBox.Name = "FFmpegSourceTextBox"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ConPanel)
        Me.Panel1.Controls.Add(Me.SubSButton)
        Me.Panel1.Controls.Add(Me.AudSButton)
        Me.Panel1.Controls.Add(Me.ImgSButton)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'ConPanel
        '
        Me.ConPanel.Controls.Add(Me.PreviewButton)
        Me.ConPanel.Controls.Add(Me.ListenButton)
        Me.ConPanel.Controls.Add(Me.RefButton)
        resources.ApplyResources(Me.ConPanel, "ConPanel")
        Me.ConPanel.Name = "ConPanel"
        '
        'PreviewButton
        '
        resources.ApplyResources(Me.PreviewButton, "PreviewButton")
        Me.PreviewButton.Name = "PreviewButton"
        Me.PreviewButton.UseVisualStyleBackColor = True
        '
        'ListenButton
        '
        resources.ApplyResources(Me.ListenButton, "ListenButton")
        Me.ListenButton.Name = "ListenButton"
        Me.ListenButton.UseVisualStyleBackColor = True
        '
        'RefButton
        '
        resources.ApplyResources(Me.RefButton, "RefButton")
        Me.RefButton.Name = "RefButton"
        Me.RefButton.UseVisualStyleBackColor = True
        '
        'SubSButton
        '
        resources.ApplyResources(Me.SubSButton, "SubSButton")
        Me.SubSButton.Name = "SubSButton"
        Me.SubSButton.UseVisualStyleBackColor = True
        '
        'AudSButton
        '
        resources.ApplyResources(Me.AudSButton, "AudSButton")
        Me.AudSButton.Name = "AudSButton"
        Me.AudSButton.UseVisualStyleBackColor = True
        '
        'ImgSButton
        '
        resources.ApplyResources(Me.ImgSButton, "ImgSButton")
        Me.ImgSButton.Name = "ImgSButton"
        Me.ImgSButton.UseVisualStyleBackColor = True
        '
        'ChannelTextBox
        '
        resources.ApplyResources(Me.ChannelTextBox, "ChannelTextBox")
        Me.ChannelTextBox.BackColor = System.Drawing.Color.White
        Me.ChannelTextBox.Name = "ChannelTextBox"
        '
        'Def_ChannelTextBox
        '
        Me.Def_ChannelTextBox.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.Def_ChannelTextBox, "Def_ChannelTextBox")
        Me.Def_ChannelTextBox.Name = "Def_ChannelTextBox"
        '
        'TabControl1
        '
        resources.ApplyResources(Me.TabControl1, "TabControl1")
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.FFmpegSourceTabPage)
        Me.TabControl1.Controls.Add(Me.MPEG2SourceTabPage)
        Me.TabControl1.Controls.Add(Me.AVCTabPage)
        Me.TabControl1.Controls.Add(Me.VC1TabPage)
        Me.TabControl1.Controls.Add(Me.BassAudioTabPage)
        Me.TabControl1.Controls.Add(Me.NicAudioTabPage)
        Me.TabControl1.Controls.Add(Me.ChannelScriptTabPage)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ScriptTextBox)
        resources.ApplyResources(Me.TabPage1, "TabPage1")
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ScriptTextBox
        '
        resources.ApplyResources(Me.ScriptTextBox, "ScriptTextBox")
        Me.ScriptTextBox.BackColor = System.Drawing.Color.White
        Me.ScriptTextBox.Name = "ScriptTextBox"
        Me.ScriptTextBox.ReadOnly = True
        '
        'FFmpegSourceTabPage
        '
        Me.FFmpegSourceTabPage.Controls.Add(Me.FFmpegSourceLabel)
        Me.FFmpegSourceTabPage.Controls.Add(Me.Def_FFmpegSourceTextBox)
        Me.FFmpegSourceTabPage.Controls.Add(Me.FFmpegSourceTextBox)
        resources.ApplyResources(Me.FFmpegSourceTabPage, "FFmpegSourceTabPage")
        Me.FFmpegSourceTabPage.Name = "FFmpegSourceTabPage"
        Me.FFmpegSourceTabPage.UseVisualStyleBackColor = True
        '
        'FFmpegSourceLabel
        '
        resources.ApplyResources(Me.FFmpegSourceLabel, "FFmpegSourceLabel")
        Me.FFmpegSourceLabel.Name = "FFmpegSourceLabel"
        '
        'MPEG2SourceTabPage
        '
        Me.MPEG2SourceTabPage.Controls.Add(Me.MPEG2SourceLabel)
        Me.MPEG2SourceTabPage.Controls.Add(Me.Def_MPEG2SourceTextBox)
        Me.MPEG2SourceTabPage.Controls.Add(Me.MPEG2SourceTextBox)
        resources.ApplyResources(Me.MPEG2SourceTabPage, "MPEG2SourceTabPage")
        Me.MPEG2SourceTabPage.Name = "MPEG2SourceTabPage"
        Me.MPEG2SourceTabPage.UseVisualStyleBackColor = True
        '
        'MPEG2SourceLabel
        '
        resources.ApplyResources(Me.MPEG2SourceLabel, "MPEG2SourceLabel")
        Me.MPEG2SourceLabel.Name = "MPEG2SourceLabel"
        '
        'Def_MPEG2SourceTextBox
        '
        Me.Def_MPEG2SourceTextBox.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.Def_MPEG2SourceTextBox, "Def_MPEG2SourceTextBox")
        Me.Def_MPEG2SourceTextBox.Name = "Def_MPEG2SourceTextBox"
        '
        'MPEG2SourceTextBox
        '
        resources.ApplyResources(Me.MPEG2SourceTextBox, "MPEG2SourceTextBox")
        Me.MPEG2SourceTextBox.BackColor = System.Drawing.Color.White
        Me.MPEG2SourceTextBox.Name = "MPEG2SourceTextBox"
        '
        'AVCTabPage
        '
        Me.AVCTabPage.Controls.Add(Me.AVCLabel)
        Me.AVCTabPage.Controls.Add(Me.Def_AVCTextBox)
        Me.AVCTabPage.Controls.Add(Me.AVCTextBox)
        resources.ApplyResources(Me.AVCTabPage, "AVCTabPage")
        Me.AVCTabPage.Name = "AVCTabPage"
        Me.AVCTabPage.UseVisualStyleBackColor = True
        '
        'AVCLabel
        '
        resources.ApplyResources(Me.AVCLabel, "AVCLabel")
        Me.AVCLabel.Name = "AVCLabel"
        '
        'Def_AVCTextBox
        '
        Me.Def_AVCTextBox.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.Def_AVCTextBox, "Def_AVCTextBox")
        Me.Def_AVCTextBox.Name = "Def_AVCTextBox"
        '
        'AVCTextBox
        '
        resources.ApplyResources(Me.AVCTextBox, "AVCTextBox")
        Me.AVCTextBox.BackColor = System.Drawing.Color.White
        Me.AVCTextBox.Name = "AVCTextBox"
        '
        'VC1TabPage
        '
        Me.VC1TabPage.Controls.Add(Me.VC1Label)
        Me.VC1TabPage.Controls.Add(Me.Def_VC1TextBox)
        Me.VC1TabPage.Controls.Add(Me.VC1TextBox)
        resources.ApplyResources(Me.VC1TabPage, "VC1TabPage")
        Me.VC1TabPage.Name = "VC1TabPage"
        Me.VC1TabPage.UseVisualStyleBackColor = True
        '
        'VC1Label
        '
        resources.ApplyResources(Me.VC1Label, "VC1Label")
        Me.VC1Label.Name = "VC1Label"
        '
        'Def_VC1TextBox
        '
        Me.Def_VC1TextBox.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.Def_VC1TextBox, "Def_VC1TextBox")
        Me.Def_VC1TextBox.Name = "Def_VC1TextBox"
        '
        'VC1TextBox
        '
        resources.ApplyResources(Me.VC1TextBox, "VC1TextBox")
        Me.VC1TextBox.BackColor = System.Drawing.Color.White
        Me.VC1TextBox.Name = "VC1TextBox"
        '
        'BassAudioTabPage
        '
        Me.BassAudioTabPage.Controls.Add(Me.BassAudioLabel)
        Me.BassAudioTabPage.Controls.Add(Me.Def_BassAudioTextBox)
        Me.BassAudioTabPage.Controls.Add(Me.BassAudioTextBox)
        resources.ApplyResources(Me.BassAudioTabPage, "BassAudioTabPage")
        Me.BassAudioTabPage.Name = "BassAudioTabPage"
        Me.BassAudioTabPage.UseVisualStyleBackColor = True
        '
        'BassAudioLabel
        '
        resources.ApplyResources(Me.BassAudioLabel, "BassAudioLabel")
        Me.BassAudioLabel.Name = "BassAudioLabel"
        '
        'Def_BassAudioTextBox
        '
        Me.Def_BassAudioTextBox.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.Def_BassAudioTextBox, "Def_BassAudioTextBox")
        Me.Def_BassAudioTextBox.Name = "Def_BassAudioTextBox"
        '
        'BassAudioTextBox
        '
        resources.ApplyResources(Me.BassAudioTextBox, "BassAudioTextBox")
        Me.BassAudioTextBox.BackColor = System.Drawing.Color.White
        Me.BassAudioTextBox.Name = "BassAudioTextBox"
        '
        'NicAudioTabPage
        '
        Me.NicAudioTabPage.Controls.Add(Me.NicAudioLabel)
        Me.NicAudioTabPage.Controls.Add(Me.Def_NicAudioTextBox)
        Me.NicAudioTabPage.Controls.Add(Me.NicAudioTextBox)
        resources.ApplyResources(Me.NicAudioTabPage, "NicAudioTabPage")
        Me.NicAudioTabPage.Name = "NicAudioTabPage"
        Me.NicAudioTabPage.UseVisualStyleBackColor = True
        '
        'NicAudioLabel
        '
        resources.ApplyResources(Me.NicAudioLabel, "NicAudioLabel")
        Me.NicAudioLabel.Name = "NicAudioLabel"
        '
        'Def_NicAudioTextBox
        '
        Me.Def_NicAudioTextBox.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.Def_NicAudioTextBox, "Def_NicAudioTextBox")
        Me.Def_NicAudioTextBox.Name = "Def_NicAudioTextBox"
        '
        'NicAudioTextBox
        '
        resources.ApplyResources(Me.NicAudioTextBox, "NicAudioTextBox")
        Me.NicAudioTextBox.BackColor = System.Drawing.Color.White
        Me.NicAudioTextBox.Name = "NicAudioTextBox"
        '
        'ChannelScriptTabPage
        '
        Me.ChannelScriptTabPage.Controls.Add(Me.ChannelLabel)
        Me.ChannelScriptTabPage.Controls.Add(Me.Def_ChannelTextBox)
        Me.ChannelScriptTabPage.Controls.Add(Me.ChannelTextBox)
        resources.ApplyResources(Me.ChannelScriptTabPage, "ChannelScriptTabPage")
        Me.ChannelScriptTabPage.Name = "ChannelScriptTabPage"
        Me.ChannelScriptTabPage.UseVisualStyleBackColor = True
        '
        'ChannelLabel
        '
        resources.ApplyResources(Me.ChannelLabel, "ChannelLabel")
        Me.ChannelLabel.Name = "ChannelLabel"
        '
        'ProcessDetTimer
        '
        Me.ProcessDetTimer.Interval = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FolderToolStripMenuItem, Me.InitializationToolStripMenuItem, Me.PresetToolStripMenuItem})
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'FolderToolStripMenuItem
        '
        Me.FolderToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PluginToolStripMenuItem, Me.ToolsToolStripMenuItem})
        Me.FolderToolStripMenuItem.Name = "FolderToolStripMenuItem"
        resources.ApplyResources(Me.FolderToolStripMenuItem, "FolderToolStripMenuItem")
        '
        'PluginToolStripMenuItem
        '
        Me.PluginToolStripMenuItem.Name = "PluginToolStripMenuItem"
        resources.ApplyResources(Me.PluginToolStripMenuItem, "PluginToolStripMenuItem")
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        resources.ApplyResources(Me.ToolsToolStripMenuItem, "ToolsToolStripMenuItem")
        '
        'InitializationToolStripMenuItem
        '
        resources.ApplyResources(Me.InitializationToolStripMenuItem, "InitializationToolStripMenuItem")
        Me.InitializationToolStripMenuItem.Name = "InitializationToolStripMenuItem"
        '
        'PresetToolStripMenuItem
        '
        Me.PresetToolStripMenuItem.Name = "PresetToolStripMenuItem"
        resources.ApplyResources(Me.PresetToolStripMenuItem, "PresetToolStripMenuItem")
        '
        'AVSPanel
        '
        Me.AVSPanel.Controls.Add(Me.Panel2)
        Me.AVSPanel.Controls.Add(Me.Panel1)
        Me.AVSPanel.Controls.Add(Me.TabControl1)
        resources.ApplyResources(Me.AVSPanel, "AVSPanel")
        Me.AVSPanel.Name = "AVSPanel"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.CancelBTN)
        Me.Panel3.Controls.Add(Me.OKBTN)
        resources.ApplyResources(Me.Panel3, "Panel3")
        Me.Panel3.Name = "Panel3"
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
        'AviSynthEditorFrm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.AVSPanel)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MinimizeBox = False
        Me.Name = "AviSynthEditorFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ConPanel.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.FFmpegSourceTabPage.ResumeLayout(False)
        Me.FFmpegSourceTabPage.PerformLayout()
        Me.MPEG2SourceTabPage.ResumeLayout(False)
        Me.MPEG2SourceTabPage.PerformLayout()
        Me.AVCTabPage.ResumeLayout(False)
        Me.AVCTabPage.PerformLayout()
        Me.VC1TabPage.ResumeLayout(False)
        Me.VC1TabPage.PerformLayout()
        Me.BassAudioTabPage.ResumeLayout(False)
        Me.BassAudioTabPage.PerformLayout()
        Me.NicAudioTabPage.ResumeLayout(False)
        Me.NicAudioTabPage.PerformLayout()
        Me.ChannelScriptTabPage.ResumeLayout(False)
        Me.ChannelScriptTabPage.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.AVSPanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SubSButton As System.Windows.Forms.Button
    Friend WithEvents AudSButton As System.Windows.Forms.Button
    Friend WithEvents ImgSButton As System.Windows.Forms.Button
    Friend WithEvents PreviewButton As System.Windows.Forms.Button
    Friend WithEvents LineColToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents RefButton As System.Windows.Forms.Button
    Friend WithEvents FFmpegSourceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ListenButton As System.Windows.Forms.Button
    Friend WithEvents Def_FFmpegSourceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ChannelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Def_ChannelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents FFmpegSourceTabPage As System.Windows.Forms.TabPage
    Friend WithEvents BassAudioTabPage As System.Windows.Forms.TabPage
    Friend WithEvents ChannelScriptTabPage As System.Windows.Forms.TabPage
    Friend WithEvents BassAudioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Def_BassAudioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NicAudioTabPage As System.Windows.Forms.TabPage
    Friend WithEvents Def_NicAudioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NicAudioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MPEG2SourceTabPage As System.Windows.Forms.TabPage
    Friend WithEvents Def_MPEG2SourceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MPEG2SourceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents FFmpegSourceLabel As System.Windows.Forms.Label
    Friend WithEvents BassAudioLabel As System.Windows.Forms.Label
    Friend WithEvents NicAudioLabel As System.Windows.Forms.Label
    Friend WithEvents ChannelLabel As System.Windows.Forms.Label
    Friend WithEvents MPEG2SourceLabel As System.Windows.Forms.Label
    Friend WithEvents ProcessDetTimer As System.Windows.Forms.Timer
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents ScriptTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FolderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PluginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InitializationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PresetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AVSPanel As System.Windows.Forms.Panel
    Friend WithEvents ConPanel As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents CancelBTN As System.Windows.Forms.Button
    Friend WithEvents OKBTN As System.Windows.Forms.Button
    Friend WithEvents AVCTabPage As System.Windows.Forms.TabPage
    Friend WithEvents VC1TabPage As System.Windows.Forms.TabPage
    Friend WithEvents AVCLabel As System.Windows.Forms.Label
    Friend WithEvents Def_AVCTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AVCTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VC1Label As System.Windows.Forms.Label
    Friend WithEvents Def_VC1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents VC1TextBox As System.Windows.Forms.TextBox
End Class
