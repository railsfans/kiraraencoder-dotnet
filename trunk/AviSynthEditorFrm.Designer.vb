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
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 447)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(735, 22)
        Me.StatusStrip1.TabIndex = 13
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(180, 17)
        Me.ToolStripStatusLabel1.Spring = True
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(180, 17)
        Me.ToolStripStatusLabel2.Spring = True
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(180, 17)
        Me.ToolStripStatusLabel3.Spring = True
        '
        'LineColToolStripStatusLabel
        '
        Me.LineColToolStripStatusLabel.AutoSize = False
        Me.LineColToolStripStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.LineColToolStripStatusLabel.Name = "LineColToolStripStatusLabel"
        Me.LineColToolStripStatusLabel.Size = New System.Drawing.Size(180, 17)
        Me.LineColToolStripStatusLabel.Spring = True
        Me.LineColToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Def_FFmpegSourceTextBox
        '
        Me.Def_FFmpegSourceTextBox.BackColor = System.Drawing.Color.White
        Me.Def_FFmpegSourceTextBox.Location = New System.Drawing.Point(0, 30)
        Me.Def_FFmpegSourceTextBox.MaxLength = 2147483647
        Me.Def_FFmpegSourceTextBox.Multiline = True
        Me.Def_FFmpegSourceTextBox.Name = "Def_FFmpegSourceTextBox"
        Me.Def_FFmpegSourceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Def_FFmpegSourceTextBox.Size = New System.Drawing.Size(50, 50)
        Me.Def_FFmpegSourceTextBox.TabIndex = 27
        Me.Def_FFmpegSourceTextBox.Text = resources.GetString("Def_FFmpegSourceTextBox.Text")
        Me.Def_FFmpegSourceTextBox.Visible = False
        Me.Def_FFmpegSourceTextBox.WordWrap = False
        '
        'FFmpegSourceTextBox
        '
        Me.FFmpegSourceTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FFmpegSourceTextBox.BackColor = System.Drawing.Color.White
        Me.FFmpegSourceTextBox.Location = New System.Drawing.Point(0, 30)
        Me.FFmpegSourceTextBox.MaxLength = 2147483647
        Me.FFmpegSourceTextBox.Multiline = True
        Me.FFmpegSourceTextBox.Name = "FFmpegSourceTextBox"
        Me.FFmpegSourceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.FFmpegSourceTextBox.Size = New System.Drawing.Size(705, 284)
        Me.FFmpegSourceTextBox.TabIndex = 23
        Me.FFmpegSourceTextBox.WordWrap = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ConPanel)
        Me.Panel1.Controls.Add(Me.SubSButton)
        Me.Panel1.Controls.Add(Me.AudSButton)
        Me.Panel1.Controls.Add(Me.ImgSButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(735, 37)
        Me.Panel1.TabIndex = 16
        '
        'ConPanel
        '
        Me.ConPanel.Controls.Add(Me.PreviewButton)
        Me.ConPanel.Controls.Add(Me.ListenButton)
        Me.ConPanel.Controls.Add(Me.RefButton)
        Me.ConPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.ConPanel.Location = New System.Drawing.Point(375, 0)
        Me.ConPanel.Name = "ConPanel"
        Me.ConPanel.Size = New System.Drawing.Size(360, 37)
        Me.ConPanel.TabIndex = 6
        '
        'PreviewButton
        '
        Me.PreviewButton.Location = New System.Drawing.Point(5, 8)
        Me.PreviewButton.Name = "PreviewButton"
        Me.PreviewButton.Size = New System.Drawing.Size(110, 25)
        Me.PreviewButton.TabIndex = 3
        Me.PreviewButton.Text = "미리 보기"
        Me.PreviewButton.UseVisualStyleBackColor = True
        '
        'ListenButton
        '
        Me.ListenButton.Location = New System.Drawing.Point(238, 8)
        Me.ListenButton.Name = "ListenButton"
        Me.ListenButton.Size = New System.Drawing.Size(110, 25)
        Me.ListenButton.TabIndex = 5
        Me.ListenButton.Text = "미리 듣기"
        Me.ListenButton.UseVisualStyleBackColor = True
        '
        'RefButton
        '
        Me.RefButton.Enabled = False
        Me.RefButton.Location = New System.Drawing.Point(122, 8)
        Me.RefButton.Name = "RefButton"
        Me.RefButton.Size = New System.Drawing.Size(110, 25)
        Me.RefButton.TabIndex = 4
        Me.RefButton.Text = "새로 고침"
        Me.RefButton.UseVisualStyleBackColor = True
        '
        'SubSButton
        '
        Me.SubSButton.Location = New System.Drawing.Point(242, 8)
        Me.SubSButton.Name = "SubSButton"
        Me.SubSButton.Size = New System.Drawing.Size(110, 25)
        Me.SubSButton.TabIndex = 2
        Me.SubSButton.Text = "자막설정"
        Me.SubSButton.UseVisualStyleBackColor = True
        '
        'AudSButton
        '
        Me.AudSButton.Location = New System.Drawing.Point(126, 8)
        Me.AudSButton.Name = "AudSButton"
        Me.AudSButton.Size = New System.Drawing.Size(110, 25)
        Me.AudSButton.TabIndex = 1
        Me.AudSButton.Text = "음성설정"
        Me.AudSButton.UseVisualStyleBackColor = True
        '
        'ImgSButton
        '
        Me.ImgSButton.Location = New System.Drawing.Point(10, 8)
        Me.ImgSButton.Name = "ImgSButton"
        Me.ImgSButton.Size = New System.Drawing.Size(110, 25)
        Me.ImgSButton.TabIndex = 0
        Me.ImgSButton.Text = "영상설정"
        Me.ImgSButton.UseVisualStyleBackColor = True
        '
        'ChannelTextBox
        '
        Me.ChannelTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChannelTextBox.BackColor = System.Drawing.Color.White
        Me.ChannelTextBox.Location = New System.Drawing.Point(0, 30)
        Me.ChannelTextBox.MaxLength = 2147483647
        Me.ChannelTextBox.Multiline = True
        Me.ChannelTextBox.Name = "ChannelTextBox"
        Me.ChannelTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ChannelTextBox.Size = New System.Drawing.Size(705, 284)
        Me.ChannelTextBox.TabIndex = 25
        Me.ChannelTextBox.WordWrap = False
        '
        'Def_ChannelTextBox
        '
        Me.Def_ChannelTextBox.BackColor = System.Drawing.Color.White
        Me.Def_ChannelTextBox.Location = New System.Drawing.Point(0, 30)
        Me.Def_ChannelTextBox.MaxLength = 2147483647
        Me.Def_ChannelTextBox.Multiline = True
        Me.Def_ChannelTextBox.Name = "Def_ChannelTextBox"
        Me.Def_ChannelTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Def_ChannelTextBox.Size = New System.Drawing.Size(50, 50)
        Me.Def_ChannelTextBox.TabIndex = 26
        Me.Def_ChannelTextBox.Text = resources.GetString("Def_ChannelTextBox.Text")
        Me.Def_ChannelTextBox.Visible = False
        Me.Def_ChannelTextBox.WordWrap = False
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.FFmpegSourceTabPage)
        Me.TabControl1.Controls.Add(Me.MPEG2SourceTabPage)
        Me.TabControl1.Controls.Add(Me.BassAudioTabPage)
        Me.TabControl1.Controls.Add(Me.NicAudioTabPage)
        Me.TabControl1.Controls.Add(Me.ChannelScriptTabPage)
        Me.TabControl1.Location = New System.Drawing.Point(10, 43)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(713, 340)
        Me.TabControl1.TabIndex = 28
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ScriptTextBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(705, 314)
        Me.TabPage1.TabIndex = 6
        Me.TabPage1.Text = "Script"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ScriptTextBox
        '
        Me.ScriptTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ScriptTextBox.BackColor = System.Drawing.Color.White
        Me.ScriptTextBox.Location = New System.Drawing.Point(0, 0)
        Me.ScriptTextBox.MaxLength = 2147483647
        Me.ScriptTextBox.Multiline = True
        Me.ScriptTextBox.Name = "ScriptTextBox"
        Me.ScriptTextBox.ReadOnly = True
        Me.ScriptTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ScriptTextBox.Size = New System.Drawing.Size(705, 314)
        Me.ScriptTextBox.TabIndex = 24
        Me.ScriptTextBox.WordWrap = False
        '
        'FFmpegSourceTabPage
        '
        Me.FFmpegSourceTabPage.Controls.Add(Me.FFmpegSourceLabel)
        Me.FFmpegSourceTabPage.Controls.Add(Me.Def_FFmpegSourceTextBox)
        Me.FFmpegSourceTabPage.Controls.Add(Me.FFmpegSourceTextBox)
        Me.FFmpegSourceTabPage.Location = New System.Drawing.Point(4, 22)
        Me.FFmpegSourceTabPage.Name = "FFmpegSourceTabPage"
        Me.FFmpegSourceTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.FFmpegSourceTabPage.Size = New System.Drawing.Size(705, 314)
        Me.FFmpegSourceTabPage.TabIndex = 0
        Me.FFmpegSourceTabPage.Text = "FFmpegSource"
        Me.FFmpegSourceTabPage.UseVisualStyleBackColor = True
        '
        'FFmpegSourceLabel
        '
        Me.FFmpegSourceLabel.AutoSize = True
        Me.FFmpegSourceLabel.Location = New System.Drawing.Point(7, 7)
        Me.FFmpegSourceLabel.Name = "FFmpegSourceLabel"
        Me.FFmpegSourceLabel.Size = New System.Drawing.Size(164, 12)
        Me.FFmpegSourceLabel.TabIndex = 28
        Me.FFmpegSourceLabel.Text = "비디오 파일, 오디오 RM 파일"
        '
        'MPEG2SourceTabPage
        '
        Me.MPEG2SourceTabPage.Controls.Add(Me.MPEG2SourceLabel)
        Me.MPEG2SourceTabPage.Controls.Add(Me.Def_MPEG2SourceTextBox)
        Me.MPEG2SourceTabPage.Controls.Add(Me.MPEG2SourceTextBox)
        Me.MPEG2SourceTabPage.Location = New System.Drawing.Point(4, 22)
        Me.MPEG2SourceTabPage.Name = "MPEG2SourceTabPage"
        Me.MPEG2SourceTabPage.Size = New System.Drawing.Size(705, 314)
        Me.MPEG2SourceTabPage.TabIndex = 5
        Me.MPEG2SourceTabPage.Text = "MPEG2Source"
        Me.MPEG2SourceTabPage.UseVisualStyleBackColor = True
        '
        'MPEG2SourceLabel
        '
        Me.MPEG2SourceLabel.AutoSize = True
        Me.MPEG2SourceLabel.Location = New System.Drawing.Point(7, 7)
        Me.MPEG2SourceLabel.Name = "MPEG2SourceLabel"
        Me.MPEG2SourceLabel.Size = New System.Drawing.Size(546, 12)
        Me.MPEG2SourceLabel.TabIndex = 29
        Me.MPEG2SourceLabel.Text = "비디오 MPEGTS, MPEG 파일(AVC제외) / MPEGTS 파일은 기본 오디오 스트림으로 인코딩됩니다."
        '
        'Def_MPEG2SourceTextBox
        '
        Me.Def_MPEG2SourceTextBox.BackColor = System.Drawing.Color.White
        Me.Def_MPEG2SourceTextBox.Location = New System.Drawing.Point(0, 30)
        Me.Def_MPEG2SourceTextBox.MaxLength = 2147483647
        Me.Def_MPEG2SourceTextBox.Multiline = True
        Me.Def_MPEG2SourceTextBox.Name = "Def_MPEG2SourceTextBox"
        Me.Def_MPEG2SourceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Def_MPEG2SourceTextBox.Size = New System.Drawing.Size(50, 50)
        Me.Def_MPEG2SourceTextBox.TabIndex = 28
        Me.Def_MPEG2SourceTextBox.Text = resources.GetString("Def_MPEG2SourceTextBox.Text")
        Me.Def_MPEG2SourceTextBox.Visible = False
        Me.Def_MPEG2SourceTextBox.WordWrap = False
        '
        'MPEG2SourceTextBox
        '
        Me.MPEG2SourceTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MPEG2SourceTextBox.BackColor = System.Drawing.Color.White
        Me.MPEG2SourceTextBox.Location = New System.Drawing.Point(0, 30)
        Me.MPEG2SourceTextBox.MaxLength = 2147483647
        Me.MPEG2SourceTextBox.Multiline = True
        Me.MPEG2SourceTextBox.Name = "MPEG2SourceTextBox"
        Me.MPEG2SourceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.MPEG2SourceTextBox.Size = New System.Drawing.Size(705, 284)
        Me.MPEG2SourceTextBox.TabIndex = 24
        Me.MPEG2SourceTextBox.WordWrap = False
        '
        'BassAudioTabPage
        '
        Me.BassAudioTabPage.Controls.Add(Me.BassAudioLabel)
        Me.BassAudioTabPage.Controls.Add(Me.Def_BassAudioTextBox)
        Me.BassAudioTabPage.Controls.Add(Me.BassAudioTextBox)
        Me.BassAudioTabPage.Location = New System.Drawing.Point(4, 22)
        Me.BassAudioTabPage.Name = "BassAudioTabPage"
        Me.BassAudioTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.BassAudioTabPage.Size = New System.Drawing.Size(705, 314)
        Me.BassAudioTabPage.TabIndex = 1
        Me.BassAudioTabPage.Text = "BassAudio"
        Me.BassAudioTabPage.UseVisualStyleBackColor = True
        '
        'BassAudioLabel
        '
        Me.BassAudioLabel.AutoSize = True
        Me.BassAudioLabel.Location = New System.Drawing.Point(7, 7)
        Me.BassAudioLabel.Name = "BassAudioLabel"
        Me.BassAudioLabel.Size = New System.Drawing.Size(69, 12)
        Me.BassAudioLabel.TabIndex = 29
        Me.BassAudioLabel.Text = "오디오 파일"
        '
        'Def_BassAudioTextBox
        '
        Me.Def_BassAudioTextBox.BackColor = System.Drawing.Color.White
        Me.Def_BassAudioTextBox.Location = New System.Drawing.Point(0, 30)
        Me.Def_BassAudioTextBox.MaxLength = 2147483647
        Me.Def_BassAudioTextBox.Multiline = True
        Me.Def_BassAudioTextBox.Name = "Def_BassAudioTextBox"
        Me.Def_BassAudioTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Def_BassAudioTextBox.Size = New System.Drawing.Size(50, 50)
        Me.Def_BassAudioTextBox.TabIndex = 28
        Me.Def_BassAudioTextBox.Text = "LoadPlugin(""#<pluginpath>BassAudio.dll"")" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "BassAudioSource(""#<source>"")" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "#<chann" & _
            "el>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "#<trim>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "#<amplifydb>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "#<supereq>"
        Me.Def_BassAudioTextBox.Visible = False
        Me.Def_BassAudioTextBox.WordWrap = False
        '
        'BassAudioTextBox
        '
        Me.BassAudioTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BassAudioTextBox.BackColor = System.Drawing.Color.White
        Me.BassAudioTextBox.Location = New System.Drawing.Point(0, 30)
        Me.BassAudioTextBox.MaxLength = 2147483647
        Me.BassAudioTextBox.Multiline = True
        Me.BassAudioTextBox.Name = "BassAudioTextBox"
        Me.BassAudioTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.BassAudioTextBox.Size = New System.Drawing.Size(705, 284)
        Me.BassAudioTextBox.TabIndex = 24
        Me.BassAudioTextBox.WordWrap = False
        '
        'NicAudioTabPage
        '
        Me.NicAudioTabPage.Controls.Add(Me.NicAudioLabel)
        Me.NicAudioTabPage.Controls.Add(Me.Def_NicAudioTextBox)
        Me.NicAudioTabPage.Controls.Add(Me.NicAudioTextBox)
        Me.NicAudioTabPage.Location = New System.Drawing.Point(4, 22)
        Me.NicAudioTabPage.Name = "NicAudioTabPage"
        Me.NicAudioTabPage.Size = New System.Drawing.Size(705, 314)
        Me.NicAudioTabPage.TabIndex = 3
        Me.NicAudioTabPage.Text = "NicAudio"
        Me.NicAudioTabPage.UseVisualStyleBackColor = True
        '
        'NicAudioLabel
        '
        Me.NicAudioLabel.AutoSize = True
        Me.NicAudioLabel.Location = New System.Drawing.Point(7, 7)
        Me.NicAudioLabel.Name = "NicAudioLabel"
        Me.NicAudioLabel.Size = New System.Drawing.Size(128, 12)
        Me.NicAudioLabel.TabIndex = 30
        Me.NicAudioLabel.Text = "오디오 AC3, DTS 파일"
        '
        'Def_NicAudioTextBox
        '
        Me.Def_NicAudioTextBox.BackColor = System.Drawing.Color.White
        Me.Def_NicAudioTextBox.Location = New System.Drawing.Point(0, 30)
        Me.Def_NicAudioTextBox.MaxLength = 2147483647
        Me.Def_NicAudioTextBox.Multiline = True
        Me.Def_NicAudioTextBox.Name = "Def_NicAudioTextBox"
        Me.Def_NicAudioTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Def_NicAudioTextBox.Size = New System.Drawing.Size(50, 50)
        Me.Def_NicAudioTextBox.TabIndex = 29
        Me.Def_NicAudioTextBox.Text = resources.GetString("Def_NicAudioTextBox.Text")
        Me.Def_NicAudioTextBox.Visible = False
        Me.Def_NicAudioTextBox.WordWrap = False
        '
        'NicAudioTextBox
        '
        Me.NicAudioTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NicAudioTextBox.BackColor = System.Drawing.Color.White
        Me.NicAudioTextBox.Location = New System.Drawing.Point(0, 30)
        Me.NicAudioTextBox.MaxLength = 2147483647
        Me.NicAudioTextBox.Multiline = True
        Me.NicAudioTextBox.Name = "NicAudioTextBox"
        Me.NicAudioTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.NicAudioTextBox.Size = New System.Drawing.Size(705, 284)
        Me.NicAudioTextBox.TabIndex = 25
        Me.NicAudioTextBox.WordWrap = False
        '
        'ChannelScriptTabPage
        '
        Me.ChannelScriptTabPage.Controls.Add(Me.ChannelLabel)
        Me.ChannelScriptTabPage.Controls.Add(Me.Def_ChannelTextBox)
        Me.ChannelScriptTabPage.Controls.Add(Me.ChannelTextBox)
        Me.ChannelScriptTabPage.Location = New System.Drawing.Point(4, 22)
        Me.ChannelScriptTabPage.Name = "ChannelScriptTabPage"
        Me.ChannelScriptTabPage.Size = New System.Drawing.Size(705, 314)
        Me.ChannelScriptTabPage.TabIndex = 2
        Me.ChannelScriptTabPage.Text = "Channel"
        Me.ChannelScriptTabPage.UseVisualStyleBackColor = True
        '
        'ChannelLabel
        '
        Me.ChannelLabel.AutoSize = True
        Me.ChannelLabel.Location = New System.Drawing.Point(7, 7)
        Me.ChannelLabel.Name = "ChannelLabel"
        Me.ChannelLabel.Size = New System.Drawing.Size(81, 12)
        Me.ChannelLabel.TabIndex = 31
        Me.ChannelLabel.Text = "채널 스크립트"
        '
        'ProcessDetTimer
        '
        Me.ProcessDetTimer.Interval = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FolderToolStripMenuItem, Me.InitializationToolStripMenuItem, Me.PresetToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(735, 24)
        Me.MenuStrip1.TabIndex = 29
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FolderToolStripMenuItem
        '
        Me.FolderToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PluginToolStripMenuItem, Me.ToolsToolStripMenuItem})
        Me.FolderToolStripMenuItem.Name = "FolderToolStripMenuItem"
        Me.FolderToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.FolderToolStripMenuItem.Text = "폴더(&F)"
        '
        'PluginToolStripMenuItem
        '
        Me.PluginToolStripMenuItem.Name = "PluginToolStripMenuItem"
        Me.PluginToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.PluginToolStripMenuItem.Text = "플러그인"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.ToolsToolStripMenuItem.Text = "도구"
        '
        'InitializationToolStripMenuItem
        '
        Me.InitializationToolStripMenuItem.Enabled = False
        Me.InitializationToolStripMenuItem.Name = "InitializationToolStripMenuItem"
        Me.InitializationToolStripMenuItem.Size = New System.Drawing.Size(107, 20)
        Me.InitializationToolStripMenuItem.Text = "스크립트 초기화"
        '
        'PresetToolStripMenuItem
        '
        Me.PresetToolStripMenuItem.Name = "PresetToolStripMenuItem"
        Me.PresetToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.PresetToolStripMenuItem.Text = "프리셋"
        '
        'AVSPanel
        '
        Me.AVSPanel.Controls.Add(Me.Panel2)
        Me.AVSPanel.Controls.Add(Me.Panel1)
        Me.AVSPanel.Controls.Add(Me.TabControl1)
        Me.AVSPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AVSPanel.Location = New System.Drawing.Point(0, 24)
        Me.AVSPanel.Name = "AVSPanel"
        Me.AVSPanel.Size = New System.Drawing.Size(735, 423)
        Me.AVSPanel.TabIndex = 30
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 388)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(735, 35)
        Me.Panel2.TabIndex = 29
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.CancelBTN)
        Me.Panel3.Controls.Add(Me.OKBTN)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(524, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(211, 35)
        Me.Panel3.TabIndex = 0
        '
        'CancelBTN
        '
        Me.CancelBTN.Location = New System.Drawing.Point(108, 3)
        Me.CancelBTN.Name = "CancelBTN"
        Me.CancelBTN.Size = New System.Drawing.Size(90, 25)
        Me.CancelBTN.TabIndex = 10
        Me.CancelBTN.Text = "취소"
        Me.CancelBTN.UseVisualStyleBackColor = True
        '
        'OKBTN
        '
        Me.OKBTN.Location = New System.Drawing.Point(12, 3)
        Me.OKBTN.Name = "OKBTN"
        Me.OKBTN.Size = New System.Drawing.Size(90, 25)
        Me.OKBTN.TabIndex = 11
        Me.OKBTN.Text = "확인"
        Me.OKBTN.UseVisualStyleBackColor = True
        '
        'AviSynthEditorFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 469)
        Me.Controls.Add(Me.AVSPanel)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MinimizeBox = False
        Me.Name = "AviSynthEditorFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AviSynth 스크립트"
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
End Class
