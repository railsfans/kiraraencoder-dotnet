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
        Me.FFmpegSourceTextBox = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ConPanel = New System.Windows.Forms.Panel
        Me.PreviewButton = New System.Windows.Forms.Button
        Me.ListenButton = New System.Windows.Forms.Button
        Me.RefButton = New System.Windows.Forms.Button
        Me.EtcSButton = New System.Windows.Forms.Button
        Me.SubSButton = New System.Windows.Forms.Button
        Me.AudSButton = New System.Windows.Forms.Button
        Me.ImgSButton = New System.Windows.Forms.Button
        Me.ChannelTextBox = New System.Windows.Forms.TextBox
        Me.Def_ChannelTextBox = New System.Windows.Forms.TextBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.ScriptTextBox = New System.Windows.Forms.TextBox
        Me.FFmpegSourceTabPage = New System.Windows.Forms.TabPage
        Me.Def_FFmpegSourceTextBox = New System.Windows.Forms.TextBox
        Me.DirectShowSourceTabPage = New System.Windows.Forms.TabPage
        Me.Def_DirectShowSourceTextBox = New System.Windows.Forms.TextBox
        Me.DirectShowSourceTextBox = New System.Windows.Forms.TextBox
        Me.MPEG2SourceTabPage = New System.Windows.Forms.TabPage
        Me.Def_MPEG2SourceTextBox = New System.Windows.Forms.TextBox
        Me.MPEG2SourceTextBox = New System.Windows.Forms.TextBox
        Me.BassAudioTabPage = New System.Windows.Forms.TabPage
        Me.Def_BassAudioTextBox = New System.Windows.Forms.TextBox
        Me.BassAudioTextBox = New System.Windows.Forms.TextBox
        Me.NicAudioTabPage = New System.Windows.Forms.TabPage
        Me.Def_NicAudioTextBox = New System.Windows.Forms.TextBox
        Me.NicAudioTextBox = New System.Windows.Forms.TextBox
        Me.ChannelScriptTabPage = New System.Windows.Forms.TabPage
        Me.ProcessDetTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PluginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InitializationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PresetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.디코드설정ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AllMovieFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AllMovieFilesFFmpegSourceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AllMovieFilesDirectShowSourceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MPEGTSMPEGFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MPEGTSMPEGFilesFFmpegSourceToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.MPEGTSMPEGFilesMPEG2SourceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ASFFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ASFFilesFFmpegSourceToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ASFFilesDirectShowSourceToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.M2TSFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.M2TSFilesFFmpegSourceToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.AllAudioFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AllAudioFilesFFmpegSourceToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.AllAudioFilesBassAudioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AC3DTSFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AC3DTSFilesFFmpegSourceToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem
        Me.AC3DTSFilesNicAudioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RMAMRFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RMAMRFilesFFmpegSourceToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.InitializationDSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AVSPanel = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.StatusLabel = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.CancelBTN = New System.Windows.Forms.Button
        Me.OKBTN = New System.Windows.Forms.Button
        Me.MPEGTSMPEGFilesDirectShowSourceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.M2TSFilesDirectShowSourceToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.AllAudioFilesDirectShowSourceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AC3DTSFilesDirectShowSourceToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.RMAMRFilesDirectShowSourceToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.AllICToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AllOCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ConPanel.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.FFmpegSourceTabPage.SuspendLayout()
        Me.DirectShowSourceTabPage.SuspendLayout()
        Me.MPEG2SourceTabPage.SuspendLayout()
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
        'FFmpegSourceTextBox
        '
        resources.ApplyResources(Me.FFmpegSourceTextBox, "FFmpegSourceTextBox")
        Me.FFmpegSourceTextBox.BackColor = System.Drawing.Color.White
        Me.FFmpegSourceTextBox.Name = "FFmpegSourceTextBox"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ConPanel)
        Me.Panel1.Controls.Add(Me.EtcSButton)
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
        'EtcSButton
        '
        resources.ApplyResources(Me.EtcSButton, "EtcSButton")
        Me.EtcSButton.Name = "EtcSButton"
        Me.EtcSButton.UseVisualStyleBackColor = True
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
        Me.TabControl1.Controls.Add(Me.DirectShowSourceTabPage)
        Me.TabControl1.Controls.Add(Me.MPEG2SourceTabPage)
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
        Me.FFmpegSourceTabPage.Controls.Add(Me.Def_FFmpegSourceTextBox)
        Me.FFmpegSourceTabPage.Controls.Add(Me.FFmpegSourceTextBox)
        resources.ApplyResources(Me.FFmpegSourceTabPage, "FFmpegSourceTabPage")
        Me.FFmpegSourceTabPage.Name = "FFmpegSourceTabPage"
        Me.FFmpegSourceTabPage.UseVisualStyleBackColor = True
        '
        'Def_FFmpegSourceTextBox
        '
        Me.Def_FFmpegSourceTextBox.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.Def_FFmpegSourceTextBox, "Def_FFmpegSourceTextBox")
        Me.Def_FFmpegSourceTextBox.Name = "Def_FFmpegSourceTextBox"
        '
        'DirectShowSourceTabPage
        '
        Me.DirectShowSourceTabPage.Controls.Add(Me.Def_DirectShowSourceTextBox)
        Me.DirectShowSourceTabPage.Controls.Add(Me.DirectShowSourceTextBox)
        resources.ApplyResources(Me.DirectShowSourceTabPage, "DirectShowSourceTabPage")
        Me.DirectShowSourceTabPage.Name = "DirectShowSourceTabPage"
        Me.DirectShowSourceTabPage.UseVisualStyleBackColor = True
        '
        'Def_DirectShowSourceTextBox
        '
        Me.Def_DirectShowSourceTextBox.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.Def_DirectShowSourceTextBox, "Def_DirectShowSourceTextBox")
        Me.Def_DirectShowSourceTextBox.Name = "Def_DirectShowSourceTextBox"
        '
        'DirectShowSourceTextBox
        '
        resources.ApplyResources(Me.DirectShowSourceTextBox, "DirectShowSourceTextBox")
        Me.DirectShowSourceTextBox.BackColor = System.Drawing.Color.White
        Me.DirectShowSourceTextBox.Name = "DirectShowSourceTextBox"
        '
        'MPEG2SourceTabPage
        '
        Me.MPEG2SourceTabPage.Controls.Add(Me.Def_MPEG2SourceTextBox)
        Me.MPEG2SourceTabPage.Controls.Add(Me.MPEG2SourceTextBox)
        resources.ApplyResources(Me.MPEG2SourceTabPage, "MPEG2SourceTabPage")
        Me.MPEG2SourceTabPage.Name = "MPEG2SourceTabPage"
        Me.MPEG2SourceTabPage.UseVisualStyleBackColor = True
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
        'BassAudioTabPage
        '
        Me.BassAudioTabPage.Controls.Add(Me.Def_BassAudioTextBox)
        Me.BassAudioTabPage.Controls.Add(Me.BassAudioTextBox)
        resources.ApplyResources(Me.BassAudioTabPage, "BassAudioTabPage")
        Me.BassAudioTabPage.Name = "BassAudioTabPage"
        Me.BassAudioTabPage.UseVisualStyleBackColor = True
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
        Me.NicAudioTabPage.Controls.Add(Me.Def_NicAudioTextBox)
        Me.NicAudioTabPage.Controls.Add(Me.NicAudioTextBox)
        resources.ApplyResources(Me.NicAudioTabPage, "NicAudioTabPage")
        Me.NicAudioTabPage.Name = "NicAudioTabPage"
        Me.NicAudioTabPage.UseVisualStyleBackColor = True
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
        Me.ChannelScriptTabPage.Controls.Add(Me.Def_ChannelTextBox)
        Me.ChannelScriptTabPage.Controls.Add(Me.ChannelTextBox)
        resources.ApplyResources(Me.ChannelScriptTabPage, "ChannelScriptTabPage")
        Me.ChannelScriptTabPage.Name = "ChannelScriptTabPage"
        Me.ChannelScriptTabPage.UseVisualStyleBackColor = True
        '
        'ProcessDetTimer
        '
        Me.ProcessDetTimer.Interval = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FolderToolStripMenuItem, Me.InitializationToolStripMenuItem, Me.PresetToolStripMenuItem, Me.디코드설정ToolStripMenuItem})
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
        '디코드설정ToolStripMenuItem
        '
        Me.디코드설정ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllMovieFilesToolStripMenuItem, Me.MPEGTSMPEGFilesToolStripMenuItem, Me.ASFFilesToolStripMenuItem, Me.M2TSFilesToolStripMenuItem, Me.ToolStripMenuItem1, Me.AllAudioFilesToolStripMenuItem, Me.AC3DTSFilesToolStripMenuItem, Me.RMAMRFilesToolStripMenuItem, Me.ToolStripMenuItem2, Me.InitializationDSToolStripMenuItem, Me.AllICToolStripMenuItem, Me.AllOCToolStripMenuItem})
        Me.디코드설정ToolStripMenuItem.Name = "디코드설정ToolStripMenuItem"
        resources.ApplyResources(Me.디코드설정ToolStripMenuItem, "디코드설정ToolStripMenuItem")
        '
        'AllMovieFilesToolStripMenuItem
        '
        Me.AllMovieFilesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllMovieFilesFFmpegSourceToolStripMenuItem, Me.AllMovieFilesDirectShowSourceToolStripMenuItem})
        Me.AllMovieFilesToolStripMenuItem.Name = "AllMovieFilesToolStripMenuItem"
        resources.ApplyResources(Me.AllMovieFilesToolStripMenuItem, "AllMovieFilesToolStripMenuItem")
        '
        'AllMovieFilesFFmpegSourceToolStripMenuItem
        '
        Me.AllMovieFilesFFmpegSourceToolStripMenuItem.Name = "AllMovieFilesFFmpegSourceToolStripMenuItem"
        resources.ApplyResources(Me.AllMovieFilesFFmpegSourceToolStripMenuItem, "AllMovieFilesFFmpegSourceToolStripMenuItem")
        '
        'AllMovieFilesDirectShowSourceToolStripMenuItem
        '
        Me.AllMovieFilesDirectShowSourceToolStripMenuItem.Name = "AllMovieFilesDirectShowSourceToolStripMenuItem"
        resources.ApplyResources(Me.AllMovieFilesDirectShowSourceToolStripMenuItem, "AllMovieFilesDirectShowSourceToolStripMenuItem")
        '
        'MPEGTSMPEGFilesToolStripMenuItem
        '
        Me.MPEGTSMPEGFilesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MPEGTSMPEGFilesFFmpegSourceToolStripMenuItem1, Me.MPEGTSMPEGFilesMPEG2SourceToolStripMenuItem, Me.MPEGTSMPEGFilesDirectShowSourceToolStripMenuItem})
        Me.MPEGTSMPEGFilesToolStripMenuItem.Name = "MPEGTSMPEGFilesToolStripMenuItem"
        resources.ApplyResources(Me.MPEGTSMPEGFilesToolStripMenuItem, "MPEGTSMPEGFilesToolStripMenuItem")
        '
        'MPEGTSMPEGFilesFFmpegSourceToolStripMenuItem1
        '
        Me.MPEGTSMPEGFilesFFmpegSourceToolStripMenuItem1.Name = "MPEGTSMPEGFilesFFmpegSourceToolStripMenuItem1"
        resources.ApplyResources(Me.MPEGTSMPEGFilesFFmpegSourceToolStripMenuItem1, "MPEGTSMPEGFilesFFmpegSourceToolStripMenuItem1")
        '
        'MPEGTSMPEGFilesMPEG2SourceToolStripMenuItem
        '
        Me.MPEGTSMPEGFilesMPEG2SourceToolStripMenuItem.Name = "MPEGTSMPEGFilesMPEG2SourceToolStripMenuItem"
        resources.ApplyResources(Me.MPEGTSMPEGFilesMPEG2SourceToolStripMenuItem, "MPEGTSMPEGFilesMPEG2SourceToolStripMenuItem")
        '
        'ASFFilesToolStripMenuItem
        '
        Me.ASFFilesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ASFFilesFFmpegSourceToolStripMenuItem2, Me.ASFFilesDirectShowSourceToolStripMenuItem1})
        Me.ASFFilesToolStripMenuItem.Name = "ASFFilesToolStripMenuItem"
        resources.ApplyResources(Me.ASFFilesToolStripMenuItem, "ASFFilesToolStripMenuItem")
        '
        'ASFFilesFFmpegSourceToolStripMenuItem2
        '
        Me.ASFFilesFFmpegSourceToolStripMenuItem2.Name = "ASFFilesFFmpegSourceToolStripMenuItem2"
        resources.ApplyResources(Me.ASFFilesFFmpegSourceToolStripMenuItem2, "ASFFilesFFmpegSourceToolStripMenuItem2")
        '
        'ASFFilesDirectShowSourceToolStripMenuItem1
        '
        Me.ASFFilesDirectShowSourceToolStripMenuItem1.Name = "ASFFilesDirectShowSourceToolStripMenuItem1"
        resources.ApplyResources(Me.ASFFilesDirectShowSourceToolStripMenuItem1, "ASFFilesDirectShowSourceToolStripMenuItem1")
        '
        'M2TSFilesToolStripMenuItem
        '
        Me.M2TSFilesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.M2TSFilesFFmpegSourceToolStripMenuItem6, Me.M2TSFilesDirectShowSourceToolStripMenuItem1})
        Me.M2TSFilesToolStripMenuItem.Name = "M2TSFilesToolStripMenuItem"
        resources.ApplyResources(Me.M2TSFilesToolStripMenuItem, "M2TSFilesToolStripMenuItem")
        '
        'M2TSFilesFFmpegSourceToolStripMenuItem6
        '
        Me.M2TSFilesFFmpegSourceToolStripMenuItem6.Name = "M2TSFilesFFmpegSourceToolStripMenuItem6"
        resources.ApplyResources(Me.M2TSFilesFFmpegSourceToolStripMenuItem6, "M2TSFilesFFmpegSourceToolStripMenuItem6")
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        resources.ApplyResources(Me.ToolStripMenuItem1, "ToolStripMenuItem1")
        '
        'AllAudioFilesToolStripMenuItem
        '
        Me.AllAudioFilesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllAudioFilesFFmpegSourceToolStripMenuItem3, Me.AllAudioFilesBassAudioToolStripMenuItem, Me.AllAudioFilesDirectShowSourceToolStripMenuItem})
        Me.AllAudioFilesToolStripMenuItem.Name = "AllAudioFilesToolStripMenuItem"
        resources.ApplyResources(Me.AllAudioFilesToolStripMenuItem, "AllAudioFilesToolStripMenuItem")
        '
        'AllAudioFilesFFmpegSourceToolStripMenuItem3
        '
        Me.AllAudioFilesFFmpegSourceToolStripMenuItem3.Name = "AllAudioFilesFFmpegSourceToolStripMenuItem3"
        resources.ApplyResources(Me.AllAudioFilesFFmpegSourceToolStripMenuItem3, "AllAudioFilesFFmpegSourceToolStripMenuItem3")
        '
        'AllAudioFilesBassAudioToolStripMenuItem
        '
        Me.AllAudioFilesBassAudioToolStripMenuItem.Name = "AllAudioFilesBassAudioToolStripMenuItem"
        resources.ApplyResources(Me.AllAudioFilesBassAudioToolStripMenuItem, "AllAudioFilesBassAudioToolStripMenuItem")
        '
        'AC3DTSFilesToolStripMenuItem
        '
        Me.AC3DTSFilesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AC3DTSFilesFFmpegSourceToolStripMenuItem4, Me.AC3DTSFilesNicAudioToolStripMenuItem, Me.AC3DTSFilesDirectShowSourceToolStripMenuItem1})
        Me.AC3DTSFilesToolStripMenuItem.Name = "AC3DTSFilesToolStripMenuItem"
        resources.ApplyResources(Me.AC3DTSFilesToolStripMenuItem, "AC3DTSFilesToolStripMenuItem")
        '
        'AC3DTSFilesFFmpegSourceToolStripMenuItem4
        '
        Me.AC3DTSFilesFFmpegSourceToolStripMenuItem4.Name = "AC3DTSFilesFFmpegSourceToolStripMenuItem4"
        resources.ApplyResources(Me.AC3DTSFilesFFmpegSourceToolStripMenuItem4, "AC3DTSFilesFFmpegSourceToolStripMenuItem4")
        '
        'AC3DTSFilesNicAudioToolStripMenuItem
        '
        Me.AC3DTSFilesNicAudioToolStripMenuItem.Name = "AC3DTSFilesNicAudioToolStripMenuItem"
        resources.ApplyResources(Me.AC3DTSFilesNicAudioToolStripMenuItem, "AC3DTSFilesNicAudioToolStripMenuItem")
        '
        'RMAMRFilesToolStripMenuItem
        '
        Me.RMAMRFilesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RMAMRFilesFFmpegSourceToolStripMenuItem5, Me.RMAMRFilesDirectShowSourceToolStripMenuItem2})
        Me.RMAMRFilesToolStripMenuItem.Name = "RMAMRFilesToolStripMenuItem"
        resources.ApplyResources(Me.RMAMRFilesToolStripMenuItem, "RMAMRFilesToolStripMenuItem")
        '
        'RMAMRFilesFFmpegSourceToolStripMenuItem5
        '
        Me.RMAMRFilesFFmpegSourceToolStripMenuItem5.Name = "RMAMRFilesFFmpegSourceToolStripMenuItem5"
        resources.ApplyResources(Me.RMAMRFilesFFmpegSourceToolStripMenuItem5, "RMAMRFilesFFmpegSourceToolStripMenuItem5")
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        resources.ApplyResources(Me.ToolStripMenuItem2, "ToolStripMenuItem2")
        '
        'InitializationDSToolStripMenuItem
        '
        Me.InitializationDSToolStripMenuItem.Name = "InitializationDSToolStripMenuItem"
        resources.ApplyResources(Me.InitializationDSToolStripMenuItem, "InitializationDSToolStripMenuItem")
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
        Me.Panel2.Controls.Add(Me.StatusLabel)
        Me.Panel2.Controls.Add(Me.Panel3)
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'StatusLabel
        '
        resources.ApplyResources(Me.StatusLabel, "StatusLabel")
        Me.StatusLabel.ForeColor = System.Drawing.Color.Green
        Me.StatusLabel.Name = "StatusLabel"
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
        'MPEGTSMPEGFilesDirectShowSourceToolStripMenuItem
        '
        Me.MPEGTSMPEGFilesDirectShowSourceToolStripMenuItem.Name = "MPEGTSMPEGFilesDirectShowSourceToolStripMenuItem"
        resources.ApplyResources(Me.MPEGTSMPEGFilesDirectShowSourceToolStripMenuItem, "MPEGTSMPEGFilesDirectShowSourceToolStripMenuItem")
        '
        'M2TSFilesDirectShowSourceToolStripMenuItem1
        '
        Me.M2TSFilesDirectShowSourceToolStripMenuItem1.Name = "M2TSFilesDirectShowSourceToolStripMenuItem1"
        resources.ApplyResources(Me.M2TSFilesDirectShowSourceToolStripMenuItem1, "M2TSFilesDirectShowSourceToolStripMenuItem1")
        '
        'AllAudioFilesDirectShowSourceToolStripMenuItem
        '
        Me.AllAudioFilesDirectShowSourceToolStripMenuItem.Name = "AllAudioFilesDirectShowSourceToolStripMenuItem"
        resources.ApplyResources(Me.AllAudioFilesDirectShowSourceToolStripMenuItem, "AllAudioFilesDirectShowSourceToolStripMenuItem")
        '
        'AC3DTSFilesDirectShowSourceToolStripMenuItem1
        '
        Me.AC3DTSFilesDirectShowSourceToolStripMenuItem1.Name = "AC3DTSFilesDirectShowSourceToolStripMenuItem1"
        resources.ApplyResources(Me.AC3DTSFilesDirectShowSourceToolStripMenuItem1, "AC3DTSFilesDirectShowSourceToolStripMenuItem1")
        '
        'RMAMRFilesDirectShowSourceToolStripMenuItem2
        '
        Me.RMAMRFilesDirectShowSourceToolStripMenuItem2.Name = "RMAMRFilesDirectShowSourceToolStripMenuItem2"
        resources.ApplyResources(Me.RMAMRFilesDirectShowSourceToolStripMenuItem2, "RMAMRFilesDirectShowSourceToolStripMenuItem2")
        '
        'AllICToolStripMenuItem
        '
        Me.AllICToolStripMenuItem.Name = "AllICToolStripMenuItem"
        resources.ApplyResources(Me.AllICToolStripMenuItem, "AllICToolStripMenuItem")
        '
        'AllOCToolStripMenuItem
        '
        Me.AllOCToolStripMenuItem.Name = "AllOCToolStripMenuItem"
        resources.ApplyResources(Me.AllOCToolStripMenuItem, "AllOCToolStripMenuItem")
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
        Me.DirectShowSourceTabPage.ResumeLayout(False)
        Me.DirectShowSourceTabPage.PerformLayout()
        Me.MPEG2SourceTabPage.ResumeLayout(False)
        Me.MPEG2SourceTabPage.PerformLayout()
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
        Me.Panel2.PerformLayout()
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
    Friend WithEvents DirectShowSourceTabPage As System.Windows.Forms.TabPage
    Friend WithEvents Def_DirectShowSourceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DirectShowSourceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Def_FFmpegSourceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StatusLabel As System.Windows.Forms.Label
    Friend WithEvents EtcSButton As System.Windows.Forms.Button
    Friend WithEvents 디코드설정ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllMovieFilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllMovieFilesFFmpegSourceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllMovieFilesDirectShowSourceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MPEGTSMPEGFilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ASFFilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MPEGTSMPEGFilesFFmpegSourceToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MPEGTSMPEGFilesMPEG2SourceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ASFFilesFFmpegSourceToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ASFFilesDirectShowSourceToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M2TSFilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M2TSFilesFFmpegSourceToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AllAudioFilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllAudioFilesFFmpegSourceToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllAudioFilesBassAudioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AC3DTSFilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AC3DTSFilesFFmpegSourceToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AC3DTSFilesNicAudioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RMAMRFilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RMAMRFilesFFmpegSourceToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents InitializationDSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MPEGTSMPEGFilesDirectShowSourceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents M2TSFilesDirectShowSourceToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllAudioFilesDirectShowSourceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AC3DTSFilesDirectShowSourceToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RMAMRFilesDirectShowSourceToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllICToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllOCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
