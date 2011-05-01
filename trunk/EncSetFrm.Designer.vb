<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EncSetFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EncSetFrm))
        Me.EncSetPanel = New System.Windows.Forms.Panel
        Me.OutFLabel = New System.Windows.Forms.Label
        Me.OutFComboBox = New System.Windows.Forms.ComboBox
        Me.PresetButton = New System.Windows.Forms.Button
        Me.CancelBTN = New System.Windows.Forms.Button
        Me.OKBTN = New System.Windows.Forms.Button
        Me.DefBTN = New System.Windows.Forms.Button
        Me.SettingTabControl = New System.Windows.Forms.TabControl
        Me.VideoTabPage = New System.Windows.Forms.TabPage
        Me.MP4OptsPanel = New System.Windows.Forms.Panel
        Me.PSPMP4CheckBox = New System.Windows.Forms.CheckBox
        Me.KeyFrameGroupBox = New System.Windows.Forms.GroupBox
        Me.MinGOPSizeTextBox = New System.Windows.Forms.TextBox
        Me.GOPSizeTextBox = New System.Windows.Forms.TextBox
        Me.MinGOPSizeLabel = New System.Windows.Forms.Label
        Me.GOPSizeLabel = New System.Windows.Forms.Label
        Me.GOPSizeCheckBox = New System.Windows.Forms.CheckBox
        Me.VideoGroupBox = New System.Windows.Forms.GroupBox
        Me.AdvanOptsPanel = New System.Windows.Forms.Panel
        Me.EasyPanel = New System.Windows.Forms.Panel
        Me.EasyButton = New System.Windows.Forms.Button
        Me.EasyLabel = New System.Windows.Forms.Label
        Me.AdvanOptsButton = New System.Windows.Forms.Button
        Me.AdvanOptsCheckBox = New System.Windows.Forms.CheckBox
        Me.AdvanOptsLabel = New System.Windows.Forms.Label
        Me.QuantizerCQPNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.QuantizerCQPTrackBar = New System.Windows.Forms.TrackBar
        Me.QuantizerCQPLabel = New System.Windows.Forms.Label
        Me.QualityNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.QualityTrackBar = New System.Windows.Forms.TrackBar
        Me.QualityLabel = New System.Windows.Forms.Label
        Me.QuantizerNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.QuantizerTrackBar = New System.Windows.Forms.TrackBar
        Me.QuantizerLabel = New System.Windows.Forms.Label
        Me.BitrateComboBox = New System.Windows.Forms.ComboBox
        Me.BitrateLabel2 = New System.Windows.Forms.Label
        Me.BitrateLabel = New System.Windows.Forms.Label
        Me.VideoModeComboBox = New System.Windows.Forms.ComboBox
        Me.VideoCodecComboBox = New System.Windows.Forms.ComboBox
        Me.VCodecLabel = New System.Windows.Forms.Label
        Me.FFFPSGroupBox = New System.Windows.Forms.GroupBox
        Me.FFFPSDOCheckBox = New System.Windows.Forms.CheckBox
        Me.FramerateLabel = New System.Windows.Forms.Label
        Me.FramerateComboBox = New System.Windows.Forms.ComboBox
        Me.FramerateCheckBox = New System.Windows.Forms.CheckBox
        Me.FramerateLabel2 = New System.Windows.Forms.Label
        Me.VFTabPage = New System.Windows.Forms.TabPage
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.ParityLabel = New System.Windows.Forms.Label
        Me.DeinterlaceParityComboBox = New System.Windows.Forms.ComboBox
        Me.DeinterlaceModeComboBox = New System.Windows.Forms.ComboBox
        Me.DeinterlaceCheckBox = New System.Windows.Forms.CheckBox
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.ImagePPGroupBox = New System.Windows.Forms.GroupBox
        Me.FFmpegImageUnsharpCheckBox = New System.Windows.Forms.CheckBox
        Me.FFmpegImageUnsharpLabel = New System.Windows.Forms.Label
        Me.LumaEffectSNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.ChromaEffectSNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.ChromaEffectSTrackBar = New System.Windows.Forms.TrackBar
        Me.ChromaEffectSButton = New System.Windows.Forms.Button
        Me.ChromaMatrixVSNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.ChromaMatrixVSTrackBar = New System.Windows.Forms.TrackBar
        Me.ChromaMatrixVSButton = New System.Windows.Forms.Button
        Me.ChromaMatrixHSNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.ChromaMatrixHSTrackBar = New System.Windows.Forms.TrackBar
        Me.ChromaMatrixHSButton = New System.Windows.Forms.Button
        Me.LumaEffectSTrackBar = New System.Windows.Forms.TrackBar
        Me.LumaEffectSButton = New System.Windows.Forms.Button
        Me.LumaMatrixVSNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.LumaMatrixVSTrackBar = New System.Windows.Forms.TrackBar
        Me.LumaMatrixVSButton = New System.Windows.Forms.Button
        Me.LumaMatrixHSNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.LumaMatrixHSTrackBar = New System.Windows.Forms.TrackBar
        Me.LumaMatrixHSButton = New System.Windows.Forms.Button
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.hqdn3dPanel = New System.Windows.Forms.Panel
        Me.hqdn3dAutGroupBox = New System.Windows.Forms.GroupBox
        Me.hqdn3d_2TextBox = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.hqdn3d_3TextBox = New System.Windows.Forms.TextBox
        Me.hqdn3d_auto_NumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.Label8 = New System.Windows.Forms.Label
        Me.hqdn3d_4TextBox = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.hqdn3dManGroupBox = New System.Windows.Forms.GroupBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.hqdn3d_manual_TextBox = New System.Windows.Forms.TextBox
        Me.hqdn3dAutomodeCheckBox = New System.Windows.Forms.CheckBox
        Me.hqdn3dUseCheckBox = New System.Windows.Forms.CheckBox
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.gradfun_radiusNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.gradfun_radiusTrackBar = New System.Windows.Forms.TrackBar
        Me.gradfun_radiusButton = New System.Windows.Forms.Button
        Me.gradfun_strengthNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.gradfun_strengthTrackBar = New System.Windows.Forms.TrackBar
        Me.gradfun_strengthButton = New System.Windows.Forms.Button
        Me.gradfunCheckBox = New System.Windows.Forms.CheckBox
        Me.ImageTabPage = New System.Windows.Forms.TabPage
        Me.ImageGroupBox = New System.Windows.Forms.GroupBox
        Me.AspectSLabel = New System.Windows.Forms.Label
        Me.AspectHTextBox = New System.Windows.Forms.TextBox
        Me.AspectWTextBox = New System.Windows.Forms.TextBox
        Me.AspectComboBox2 = New System.Windows.Forms.ComboBox
        Me.AspectComboBox = New System.Windows.Forms.ComboBox
        Me.AspectLabel = New System.Windows.Forms.Label
        Me.FFmpegResizeFilterComboBox = New System.Windows.Forms.ComboBox
        Me.FFmpegResizeFilterLabel = New System.Windows.Forms.Label
        Me.ImageSizeCheckBox = New System.Windows.Forms.CheckBox
        Me.ImageSizeSLabel = New System.Windows.Forms.Label
        Me.ImageSizeHeightTextBox = New System.Windows.Forms.TextBox
        Me.ImageSizeWidthTextBox = New System.Windows.Forms.TextBox
        Me.ImageSizeComboBox = New System.Windows.Forms.ComboBox
        Me.ImageSizeLabel = New System.Windows.Forms.Label
        Me.FFTurnGroupBox = New System.Windows.Forms.GroupBox
        Me.FFVerticallyCheckBox = New System.Windows.Forms.CheckBox
        Me.FFTurnCheckBox = New System.Windows.Forms.CheckBox
        Me.FFTurnRightRadioButton = New System.Windows.Forms.RadioButton
        Me.FFTurnLeftRadioButton = New System.Windows.Forms.RadioButton
        Me.flipGroupBox = New System.Windows.Forms.GroupBox
        Me.hflipCheckBox = New System.Windows.Forms.CheckBox
        Me.vflipCheckBox = New System.Windows.Forms.CheckBox
        Me.AudioTabPage = New System.Windows.Forms.TabPage
        Me.AudioGroupBox = New System.Windows.Forms.GroupBox
        Me.AAMRWBBitratePanel = New System.Windows.Forms.Panel
        Me.AMRWBBitrateComboBox = New System.Windows.Forms.ComboBox
        Me.AMRWBBitrateLabel = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.LAMEMP3QPanel = New System.Windows.Forms.Panel
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.LAMEMP3QLabel2 = New System.Windows.Forms.Label
        Me.LAMEMP3QComboBox = New System.Windows.Forms.ComboBox
        Me.LAMEMP3QTrackBar = New System.Windows.Forms.TrackBar
        Me.LAMEMP3QNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.LAMEMP3QLabel = New System.Windows.Forms.Label
        Me.SampleratePanel = New System.Windows.Forms.Panel
        Me.SamplerateCheckBox = New System.Windows.Forms.CheckBox
        Me.SamplerateLabel2 = New System.Windows.Forms.Label
        Me.SamplerateComboBox = New System.Windows.Forms.ComboBox
        Me.SamplerateLabel = New System.Windows.Forms.Label
        Me.BitrateNPanel = New System.Windows.Forms.Panel
        Me.AudioBitrateNLabel = New System.Windows.Forms.Label
        Me.AAMRBitratePanel = New System.Windows.Forms.Panel
        Me.AMRBitrateComboBox = New System.Windows.Forms.ComboBox
        Me.AMRBitrateLabel = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.AbitratePanel = New System.Windows.Forms.Panel
        Me.AudioBitrateComboBox = New System.Windows.Forms.ComboBox
        Me.AudioBitrateLabel = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.AVorbisQPanel = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.VorbisQTrackBar = New System.Windows.Forms.TrackBar
        Me.VorbisQNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.VorbisQLabel = New System.Windows.Forms.Label
        Me.AudioCodecComboBox = New System.Windows.Forms.ComboBox
        Me.ACodecLabel = New System.Windows.Forms.Label
        Me.NeroAACGroupBox = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.NeroAACQTrackBar = New System.Windows.Forms.TrackBar
        Me.NeroAACQNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.NeroAACQLabel = New System.Windows.Forms.Label
        Me.NeroAACVBRRadioButton = New System.Windows.Forms.RadioButton
        Me.NeroAACCBRRadioButton = New System.Windows.Forms.RadioButton
        Me.NeroAACABRRadioButton = New System.Windows.Forms.RadioButton
        Me.NeroAACBitrateTrackBar = New System.Windows.Forms.TrackBar
        Me.NeroAACBitrateNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.NeroAACBitrateLabel = New System.Windows.Forms.Label
        Me.NeroAACSALabel = New System.Windows.Forms.Label
        Me.NeroAACProfileComboBox = New System.Windows.Forms.ComboBox
        Me.NeroAACProfileLabel = New System.Windows.Forms.Label
        Me.FFAudGroupBox = New System.Windows.Forms.GroupBox
        Me.FFmpegChComboBox = New System.Windows.Forms.ComboBox
        Me.FFmpegChLabel = New System.Windows.Forms.Label
        Me.AudioVolLabel = New System.Windows.Forms.Label
        Me.AudioVolNLabel = New System.Windows.Forms.Label
        Me.AudioVolNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.AudioVolButton = New System.Windows.Forms.Button
        Me.AudioVolTrackBar = New System.Windows.Forms.TrackBar
        Me.ETCTabPage = New System.Windows.Forms.TabPage
        Me.SizeEncGroupBox = New System.Windows.Forms.GroupBox
        Me.SizeButton = New System.Windows.Forms.Button
        Me.SizeEncGBLabel = New System.Windows.Forms.Label
        Me.SizeEncMBLabel = New System.Windows.Forms.Label
        Me.SizeEncTextBox = New System.Windows.Forms.TextBox
        Me.SizeEncLabel = New System.Windows.Forms.Label
        Me.SizeEncCheckBox = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RemoveMeatadataCheckBox = New System.Windows.Forms.CheckBox
        Me.SubtitleRecordingCheckBox = New System.Windows.Forms.CheckBox
        Me.FFmpegCommandGroupBox = New System.Windows.Forms.GroupBox
        Me.FFmpegCommandButton = New System.Windows.Forms.Button
        Me.FFmpegCommandTextBox = New System.Windows.Forms.TextBox
        Me.SizeLimitGroupBox = New System.Windows.Forms.GroupBox
        Me.SizeLimitCheckBox = New System.Windows.Forms.CheckBox
        Me.SizeLimitLabel = New System.Windows.Forms.Label
        Me.SizeLimitTextBox = New System.Windows.Forms.TextBox
        Me.NameGroupBox = New System.Windows.Forms.GroupBox
        Me.NameALabel = New System.Windows.Forms.Label
        Me.ExtensionTextBox = New System.Windows.Forms.TextBox
        Me.ExtensionLabel = New System.Windows.Forms.Label
        Me.HeaderTextBox = New System.Windows.Forms.TextBox
        Me.HeaderLabel = New System.Windows.Forms.Label
        Me.TargetContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CD175MBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CD350MBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CD700MBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CDs1400MBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CDs2100MBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DVD896MBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DVD1120MBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DVD1492MBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DVD2240MBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DVDOrBD54480MBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DVD6720MBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DVDDLOrBD98145MBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BD23450MBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BDDL46900MBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.FFDeinterlaceCheckBox = New System.Windows.Forms.CheckBox
        Me.EncSetPanel.SuspendLayout()
        Me.SettingTabControl.SuspendLayout()
        Me.VideoTabPage.SuspendLayout()
        Me.MP4OptsPanel.SuspendLayout()
        Me.KeyFrameGroupBox.SuspendLayout()
        Me.VideoGroupBox.SuspendLayout()
        Me.AdvanOptsPanel.SuspendLayout()
        Me.EasyPanel.SuspendLayout()
        CType(Me.QuantizerCQPNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantizerCQPTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QualityNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QualityTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantizerNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantizerTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FFFPSGroupBox.SuspendLayout()
        Me.VFTabPage.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.ImagePPGroupBox.SuspendLayout()
        CType(Me.LumaEffectSNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChromaEffectSNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChromaEffectSTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChromaMatrixVSNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChromaMatrixVSTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChromaMatrixHSNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChromaMatrixHSTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LumaEffectSTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LumaMatrixVSNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LumaMatrixVSTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LumaMatrixHSNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LumaMatrixHSTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.hqdn3dPanel.SuspendLayout()
        Me.hqdn3dAutGroupBox.SuspendLayout()
        CType(Me.hqdn3d_auto_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hqdn3dManGroupBox.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.gradfun_radiusNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gradfun_radiusTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gradfun_strengthNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gradfun_strengthTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ImageTabPage.SuspendLayout()
        Me.ImageGroupBox.SuspendLayout()
        Me.FFTurnGroupBox.SuspendLayout()
        Me.flipGroupBox.SuspendLayout()
        Me.AudioTabPage.SuspendLayout()
        Me.AudioGroupBox.SuspendLayout()
        Me.AAMRWBBitratePanel.SuspendLayout()
        Me.LAMEMP3QPanel.SuspendLayout()
        CType(Me.LAMEMP3QTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LAMEMP3QNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SampleratePanel.SuspendLayout()
        Me.BitrateNPanel.SuspendLayout()
        Me.AAMRBitratePanel.SuspendLayout()
        Me.AbitratePanel.SuspendLayout()
        Me.AVorbisQPanel.SuspendLayout()
        CType(Me.VorbisQTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VorbisQNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NeroAACGroupBox.SuspendLayout()
        CType(Me.NeroAACQTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NeroAACQNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NeroAACBitrateTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NeroAACBitrateNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FFAudGroupBox.SuspendLayout()
        CType(Me.AudioVolNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AudioVolTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ETCTabPage.SuspendLayout()
        Me.SizeEncGroupBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.FFmpegCommandGroupBox.SuspendLayout()
        Me.SizeLimitGroupBox.SuspendLayout()
        Me.NameGroupBox.SuspendLayout()
        Me.TargetContextMenuStrip.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'EncSetPanel
        '
        Me.EncSetPanel.Controls.Add(Me.OutFLabel)
        Me.EncSetPanel.Controls.Add(Me.OutFComboBox)
        Me.EncSetPanel.Controls.Add(Me.PresetButton)
        Me.EncSetPanel.Controls.Add(Me.CancelBTN)
        Me.EncSetPanel.Controls.Add(Me.OKBTN)
        Me.EncSetPanel.Controls.Add(Me.DefBTN)
        Me.EncSetPanel.Controls.Add(Me.SettingTabControl)
        resources.ApplyResources(Me.EncSetPanel, "EncSetPanel")
        Me.EncSetPanel.Name = "EncSetPanel"
        '
        'OutFLabel
        '
        resources.ApplyResources(Me.OutFLabel, "OutFLabel")
        Me.OutFLabel.Name = "OutFLabel"
        '
        'OutFComboBox
        '
        Me.OutFComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.OutFComboBox.FormattingEnabled = True
        Me.OutFComboBox.Items.AddRange(New Object() {resources.GetString("OutFComboBox.Items"), resources.GetString("OutFComboBox.Items1"), resources.GetString("OutFComboBox.Items2"), resources.GetString("OutFComboBox.Items3"), resources.GetString("OutFComboBox.Items4"), resources.GetString("OutFComboBox.Items5"), resources.GetString("OutFComboBox.Items6"), resources.GetString("OutFComboBox.Items7"), resources.GetString("OutFComboBox.Items8"), resources.GetString("OutFComboBox.Items9"), resources.GetString("OutFComboBox.Items10"), resources.GetString("OutFComboBox.Items11"), resources.GetString("OutFComboBox.Items12"), resources.GetString("OutFComboBox.Items13"), resources.GetString("OutFComboBox.Items14"), resources.GetString("OutFComboBox.Items15"), resources.GetString("OutFComboBox.Items16")})
        resources.ApplyResources(Me.OutFComboBox, "OutFComboBox")
        Me.OutFComboBox.Name = "OutFComboBox"
        '
        'PresetButton
        '
        resources.ApplyResources(Me.PresetButton, "PresetButton")
        Me.PresetButton.Name = "PresetButton"
        Me.PresetButton.UseVisualStyleBackColor = True
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
        'DefBTN
        '
        resources.ApplyResources(Me.DefBTN, "DefBTN")
        Me.DefBTN.Name = "DefBTN"
        Me.DefBTN.UseVisualStyleBackColor = True
        '
        'SettingTabControl
        '
        Me.SettingTabControl.Controls.Add(Me.VideoTabPage)
        Me.SettingTabControl.Controls.Add(Me.VFTabPage)
        Me.SettingTabControl.Controls.Add(Me.ImageTabPage)
        Me.SettingTabControl.Controls.Add(Me.AudioTabPage)
        Me.SettingTabControl.Controls.Add(Me.ETCTabPage)
        resources.ApplyResources(Me.SettingTabControl, "SettingTabControl")
        Me.SettingTabControl.Name = "SettingTabControl"
        Me.SettingTabControl.SelectedIndex = 0
        '
        'VideoTabPage
        '
        Me.VideoTabPage.BackColor = System.Drawing.Color.Transparent
        Me.VideoTabPage.Controls.Add(Me.MP4OptsPanel)
        Me.VideoTabPage.Controls.Add(Me.KeyFrameGroupBox)
        Me.VideoTabPage.Controls.Add(Me.VideoGroupBox)
        Me.VideoTabPage.Controls.Add(Me.FFFPSGroupBox)
        resources.ApplyResources(Me.VideoTabPage, "VideoTabPage")
        Me.VideoTabPage.Name = "VideoTabPage"
        Me.VideoTabPage.UseVisualStyleBackColor = True
        '
        'MP4OptsPanel
        '
        Me.MP4OptsPanel.Controls.Add(Me.PSPMP4CheckBox)
        resources.ApplyResources(Me.MP4OptsPanel, "MP4OptsPanel")
        Me.MP4OptsPanel.Name = "MP4OptsPanel"
        '
        'PSPMP4CheckBox
        '
        resources.ApplyResources(Me.PSPMP4CheckBox, "PSPMP4CheckBox")
        Me.PSPMP4CheckBox.Name = "PSPMP4CheckBox"
        Me.PSPMP4CheckBox.UseVisualStyleBackColor = True
        '
        'KeyFrameGroupBox
        '
        Me.KeyFrameGroupBox.Controls.Add(Me.MinGOPSizeTextBox)
        Me.KeyFrameGroupBox.Controls.Add(Me.GOPSizeTextBox)
        Me.KeyFrameGroupBox.Controls.Add(Me.MinGOPSizeLabel)
        Me.KeyFrameGroupBox.Controls.Add(Me.GOPSizeLabel)
        Me.KeyFrameGroupBox.Controls.Add(Me.GOPSizeCheckBox)
        resources.ApplyResources(Me.KeyFrameGroupBox, "KeyFrameGroupBox")
        Me.KeyFrameGroupBox.Name = "KeyFrameGroupBox"
        Me.KeyFrameGroupBox.TabStop = False
        '
        'MinGOPSizeTextBox
        '
        resources.ApplyResources(Me.MinGOPSizeTextBox, "MinGOPSizeTextBox")
        Me.MinGOPSizeTextBox.Name = "MinGOPSizeTextBox"
        '
        'GOPSizeTextBox
        '
        resources.ApplyResources(Me.GOPSizeTextBox, "GOPSizeTextBox")
        Me.GOPSizeTextBox.Name = "GOPSizeTextBox"
        '
        'MinGOPSizeLabel
        '
        resources.ApplyResources(Me.MinGOPSizeLabel, "MinGOPSizeLabel")
        Me.MinGOPSizeLabel.Name = "MinGOPSizeLabel"
        '
        'GOPSizeLabel
        '
        resources.ApplyResources(Me.GOPSizeLabel, "GOPSizeLabel")
        Me.GOPSizeLabel.Name = "GOPSizeLabel"
        '
        'GOPSizeCheckBox
        '
        resources.ApplyResources(Me.GOPSizeCheckBox, "GOPSizeCheckBox")
        Me.GOPSizeCheckBox.Name = "GOPSizeCheckBox"
        Me.GOPSizeCheckBox.UseVisualStyleBackColor = True
        '
        'VideoGroupBox
        '
        Me.VideoGroupBox.Controls.Add(Me.AdvanOptsPanel)
        Me.VideoGroupBox.Controls.Add(Me.QuantizerCQPNumericUpDown)
        Me.VideoGroupBox.Controls.Add(Me.QuantizerCQPTrackBar)
        Me.VideoGroupBox.Controls.Add(Me.QuantizerCQPLabel)
        Me.VideoGroupBox.Controls.Add(Me.QualityNumericUpDown)
        Me.VideoGroupBox.Controls.Add(Me.QualityTrackBar)
        Me.VideoGroupBox.Controls.Add(Me.QualityLabel)
        Me.VideoGroupBox.Controls.Add(Me.QuantizerNumericUpDown)
        Me.VideoGroupBox.Controls.Add(Me.QuantizerTrackBar)
        Me.VideoGroupBox.Controls.Add(Me.QuantizerLabel)
        Me.VideoGroupBox.Controls.Add(Me.BitrateComboBox)
        Me.VideoGroupBox.Controls.Add(Me.BitrateLabel2)
        Me.VideoGroupBox.Controls.Add(Me.BitrateLabel)
        Me.VideoGroupBox.Controls.Add(Me.VideoModeComboBox)
        Me.VideoGroupBox.Controls.Add(Me.VideoCodecComboBox)
        Me.VideoGroupBox.Controls.Add(Me.VCodecLabel)
        resources.ApplyResources(Me.VideoGroupBox, "VideoGroupBox")
        Me.VideoGroupBox.Name = "VideoGroupBox"
        Me.VideoGroupBox.TabStop = False
        '
        'AdvanOptsPanel
        '
        Me.AdvanOptsPanel.Controls.Add(Me.EasyPanel)
        Me.AdvanOptsPanel.Controls.Add(Me.AdvanOptsButton)
        Me.AdvanOptsPanel.Controls.Add(Me.AdvanOptsCheckBox)
        Me.AdvanOptsPanel.Controls.Add(Me.AdvanOptsLabel)
        resources.ApplyResources(Me.AdvanOptsPanel, "AdvanOptsPanel")
        Me.AdvanOptsPanel.Name = "AdvanOptsPanel"
        '
        'EasyPanel
        '
        Me.EasyPanel.Controls.Add(Me.EasyButton)
        Me.EasyPanel.Controls.Add(Me.EasyLabel)
        resources.ApplyResources(Me.EasyPanel, "EasyPanel")
        Me.EasyPanel.Name = "EasyPanel"
        '
        'EasyButton
        '
        resources.ApplyResources(Me.EasyButton, "EasyButton")
        Me.EasyButton.Name = "EasyButton"
        Me.EasyButton.UseVisualStyleBackColor = True
        '
        'EasyLabel
        '
        resources.ApplyResources(Me.EasyLabel, "EasyLabel")
        Me.EasyLabel.Name = "EasyLabel"
        '
        'AdvanOptsButton
        '
        resources.ApplyResources(Me.AdvanOptsButton, "AdvanOptsButton")
        Me.AdvanOptsButton.Name = "AdvanOptsButton"
        Me.AdvanOptsButton.UseVisualStyleBackColor = True
        '
        'AdvanOptsCheckBox
        '
        resources.ApplyResources(Me.AdvanOptsCheckBox, "AdvanOptsCheckBox")
        Me.AdvanOptsCheckBox.Name = "AdvanOptsCheckBox"
        Me.AdvanOptsCheckBox.UseVisualStyleBackColor = True
        '
        'AdvanOptsLabel
        '
        resources.ApplyResources(Me.AdvanOptsLabel, "AdvanOptsLabel")
        Me.AdvanOptsLabel.Name = "AdvanOptsLabel"
        '
        'QuantizerCQPNumericUpDown
        '
        resources.ApplyResources(Me.QuantizerCQPNumericUpDown, "QuantizerCQPNumericUpDown")
        Me.QuantizerCQPNumericUpDown.Maximum = New Decimal(New Integer() {69, 0, 0, 0})
        Me.QuantizerCQPNumericUpDown.Name = "QuantizerCQPNumericUpDown"
        '
        'QuantizerCQPTrackBar
        '
        resources.ApplyResources(Me.QuantizerCQPTrackBar, "QuantizerCQPTrackBar")
        Me.QuantizerCQPTrackBar.BackColor = System.Drawing.Color.White
        Me.QuantizerCQPTrackBar.Maximum = 69
        Me.QuantizerCQPTrackBar.Name = "QuantizerCQPTrackBar"
        Me.QuantizerCQPTrackBar.TickFrequency = 0
        Me.QuantizerCQPTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'QuantizerCQPLabel
        '
        resources.ApplyResources(Me.QuantizerCQPLabel, "QuantizerCQPLabel")
        Me.QuantizerCQPLabel.Name = "QuantizerCQPLabel"
        '
        'QualityNumericUpDown
        '
        Me.QualityNumericUpDown.DecimalPlaces = 1
        Me.QualityNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        resources.ApplyResources(Me.QualityNumericUpDown, "QualityNumericUpDown")
        Me.QualityNumericUpDown.Maximum = New Decimal(New Integer() {69, 0, 0, 0})
        Me.QualityNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.QualityNumericUpDown.Name = "QualityNumericUpDown"
        Me.QualityNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 65536})
        '
        'QualityTrackBar
        '
        resources.ApplyResources(Me.QualityTrackBar, "QualityTrackBar")
        Me.QualityTrackBar.BackColor = System.Drawing.Color.White
        Me.QualityTrackBar.Maximum = 690
        Me.QualityTrackBar.Minimum = 1
        Me.QualityTrackBar.Name = "QualityTrackBar"
        Me.QualityTrackBar.TickFrequency = 0
        Me.QualityTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        Me.QualityTrackBar.Value = 1
        '
        'QualityLabel
        '
        resources.ApplyResources(Me.QualityLabel, "QualityLabel")
        Me.QualityLabel.Name = "QualityLabel"
        '
        'QuantizerNumericUpDown
        '
        Me.QuantizerNumericUpDown.DecimalPlaces = 1
        Me.QuantizerNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        resources.ApplyResources(Me.QuantizerNumericUpDown, "QuantizerNumericUpDown")
        Me.QuantizerNumericUpDown.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.QuantizerNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.QuantizerNumericUpDown.Name = "QuantizerNumericUpDown"
        Me.QuantizerNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'QuantizerTrackBar
        '
        resources.ApplyResources(Me.QuantizerTrackBar, "QuantizerTrackBar")
        Me.QuantizerTrackBar.BackColor = System.Drawing.Color.White
        Me.QuantizerTrackBar.Maximum = 310
        Me.QuantizerTrackBar.Minimum = 10
        Me.QuantizerTrackBar.Name = "QuantizerTrackBar"
        Me.QuantizerTrackBar.TickFrequency = 0
        Me.QuantizerTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        Me.QuantizerTrackBar.Value = 10
        '
        'QuantizerLabel
        '
        resources.ApplyResources(Me.QuantizerLabel, "QuantizerLabel")
        Me.QuantizerLabel.Name = "QuantizerLabel"
        '
        'BitrateComboBox
        '
        Me.BitrateComboBox.FormattingEnabled = True
        resources.ApplyResources(Me.BitrateComboBox, "BitrateComboBox")
        Me.BitrateComboBox.Name = "BitrateComboBox"
        '
        'BitrateLabel2
        '
        resources.ApplyResources(Me.BitrateLabel2, "BitrateLabel2")
        Me.BitrateLabel2.Name = "BitrateLabel2"
        '
        'BitrateLabel
        '
        resources.ApplyResources(Me.BitrateLabel, "BitrateLabel")
        Me.BitrateLabel.Name = "BitrateLabel"
        '
        'VideoModeComboBox
        '
        Me.VideoModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.VideoModeComboBox.FormattingEnabled = True
        resources.ApplyResources(Me.VideoModeComboBox, "VideoModeComboBox")
        Me.VideoModeComboBox.Name = "VideoModeComboBox"
        '
        'VideoCodecComboBox
        '
        Me.VideoCodecComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.VideoCodecComboBox.FormattingEnabled = True
        resources.ApplyResources(Me.VideoCodecComboBox, "VideoCodecComboBox")
        Me.VideoCodecComboBox.Name = "VideoCodecComboBox"
        '
        'VCodecLabel
        '
        resources.ApplyResources(Me.VCodecLabel, "VCodecLabel")
        Me.VCodecLabel.Name = "VCodecLabel"
        '
        'FFFPSGroupBox
        '
        Me.FFFPSGroupBox.Controls.Add(Me.FFFPSDOCheckBox)
        Me.FFFPSGroupBox.Controls.Add(Me.FramerateLabel)
        Me.FFFPSGroupBox.Controls.Add(Me.FramerateComboBox)
        Me.FFFPSGroupBox.Controls.Add(Me.FramerateCheckBox)
        Me.FFFPSGroupBox.Controls.Add(Me.FramerateLabel2)
        resources.ApplyResources(Me.FFFPSGroupBox, "FFFPSGroupBox")
        Me.FFFPSGroupBox.Name = "FFFPSGroupBox"
        Me.FFFPSGroupBox.TabStop = False
        '
        'FFFPSDOCheckBox
        '
        resources.ApplyResources(Me.FFFPSDOCheckBox, "FFFPSDOCheckBox")
        Me.FFFPSDOCheckBox.Name = "FFFPSDOCheckBox"
        Me.FFFPSDOCheckBox.UseVisualStyleBackColor = True
        '
        'FramerateLabel
        '
        resources.ApplyResources(Me.FramerateLabel, "FramerateLabel")
        Me.FramerateLabel.Name = "FramerateLabel"
        '
        'FramerateComboBox
        '
        Me.FramerateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FramerateComboBox.FormattingEnabled = True
        Me.FramerateComboBox.Items.AddRange(New Object() {resources.GetString("FramerateComboBox.Items"), resources.GetString("FramerateComboBox.Items1"), resources.GetString("FramerateComboBox.Items2"), resources.GetString("FramerateComboBox.Items3"), resources.GetString("FramerateComboBox.Items4"), resources.GetString("FramerateComboBox.Items5"), resources.GetString("FramerateComboBox.Items6"), resources.GetString("FramerateComboBox.Items7"), resources.GetString("FramerateComboBox.Items8"), resources.GetString("FramerateComboBox.Items9"), resources.GetString("FramerateComboBox.Items10"), resources.GetString("FramerateComboBox.Items11"), resources.GetString("FramerateComboBox.Items12"), resources.GetString("FramerateComboBox.Items13"), resources.GetString("FramerateComboBox.Items14"), resources.GetString("FramerateComboBox.Items15"), resources.GetString("FramerateComboBox.Items16"), resources.GetString("FramerateComboBox.Items17"), resources.GetString("FramerateComboBox.Items18"), resources.GetString("FramerateComboBox.Items19"), resources.GetString("FramerateComboBox.Items20"), resources.GetString("FramerateComboBox.Items21"), resources.GetString("FramerateComboBox.Items22")})
        resources.ApplyResources(Me.FramerateComboBox, "FramerateComboBox")
        Me.FramerateComboBox.Name = "FramerateComboBox"
        '
        'FramerateCheckBox
        '
        resources.ApplyResources(Me.FramerateCheckBox, "FramerateCheckBox")
        Me.FramerateCheckBox.Name = "FramerateCheckBox"
        Me.FramerateCheckBox.UseVisualStyleBackColor = True
        '
        'FramerateLabel2
        '
        resources.ApplyResources(Me.FramerateLabel2, "FramerateLabel2")
        Me.FramerateLabel2.Name = "FramerateLabel2"
        '
        'VFTabPage
        '
        Me.VFTabPage.Controls.Add(Me.TabControl1)
        resources.ApplyResources(Me.VFTabPage, "VFTabPage")
        Me.VFTabPage.Name = "VFTabPage"
        Me.VFTabPage.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        resources.ApplyResources(Me.TabControl1, "TabControl1")
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        resources.ApplyResources(Me.TabPage1, "TabPage1")
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ParityLabel)
        Me.GroupBox3.Controls.Add(Me.DeinterlaceParityComboBox)
        Me.GroupBox3.Controls.Add(Me.DeinterlaceModeComboBox)
        Me.GroupBox3.Controls.Add(Me.DeinterlaceCheckBox)
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'ParityLabel
        '
        resources.ApplyResources(Me.ParityLabel, "ParityLabel")
        Me.ParityLabel.Name = "ParityLabel"
        '
        'DeinterlaceParityComboBox
        '
        Me.DeinterlaceParityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.DeinterlaceParityComboBox, "DeinterlaceParityComboBox")
        Me.DeinterlaceParityComboBox.FormattingEnabled = True
        Me.DeinterlaceParityComboBox.Items.AddRange(New Object() {resources.GetString("DeinterlaceParityComboBox.Items"), resources.GetString("DeinterlaceParityComboBox.Items1"), resources.GetString("DeinterlaceParityComboBox.Items2")})
        Me.DeinterlaceParityComboBox.Name = "DeinterlaceParityComboBox"
        '
        'DeinterlaceModeComboBox
        '
        Me.DeinterlaceModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.DeinterlaceModeComboBox, "DeinterlaceModeComboBox")
        Me.DeinterlaceModeComboBox.FormattingEnabled = True
        Me.DeinterlaceModeComboBox.Items.AddRange(New Object() {resources.GetString("DeinterlaceModeComboBox.Items"), resources.GetString("DeinterlaceModeComboBox.Items1"), resources.GetString("DeinterlaceModeComboBox.Items2"), resources.GetString("DeinterlaceModeComboBox.Items3")})
        Me.DeinterlaceModeComboBox.Name = "DeinterlaceModeComboBox"
        '
        'DeinterlaceCheckBox
        '
        resources.ApplyResources(Me.DeinterlaceCheckBox, "DeinterlaceCheckBox")
        Me.DeinterlaceCheckBox.Name = "DeinterlaceCheckBox"
        Me.DeinterlaceCheckBox.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.ImagePPGroupBox)
        resources.ApplyResources(Me.TabPage4, "TabPage4")
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'ImagePPGroupBox
        '
        Me.ImagePPGroupBox.Controls.Add(Me.FFmpegImageUnsharpCheckBox)
        Me.ImagePPGroupBox.Controls.Add(Me.FFmpegImageUnsharpLabel)
        Me.ImagePPGroupBox.Controls.Add(Me.LumaEffectSNumericUpDown)
        Me.ImagePPGroupBox.Controls.Add(Me.ChromaEffectSNumericUpDown)
        Me.ImagePPGroupBox.Controls.Add(Me.ChromaEffectSTrackBar)
        Me.ImagePPGroupBox.Controls.Add(Me.ChromaEffectSButton)
        Me.ImagePPGroupBox.Controls.Add(Me.ChromaMatrixVSNumericUpDown)
        Me.ImagePPGroupBox.Controls.Add(Me.ChromaMatrixVSTrackBar)
        Me.ImagePPGroupBox.Controls.Add(Me.ChromaMatrixVSButton)
        Me.ImagePPGroupBox.Controls.Add(Me.ChromaMatrixHSNumericUpDown)
        Me.ImagePPGroupBox.Controls.Add(Me.ChromaMatrixHSTrackBar)
        Me.ImagePPGroupBox.Controls.Add(Me.ChromaMatrixHSButton)
        Me.ImagePPGroupBox.Controls.Add(Me.LumaEffectSTrackBar)
        Me.ImagePPGroupBox.Controls.Add(Me.LumaEffectSButton)
        Me.ImagePPGroupBox.Controls.Add(Me.LumaMatrixVSNumericUpDown)
        Me.ImagePPGroupBox.Controls.Add(Me.LumaMatrixVSTrackBar)
        Me.ImagePPGroupBox.Controls.Add(Me.LumaMatrixVSButton)
        Me.ImagePPGroupBox.Controls.Add(Me.LumaMatrixHSNumericUpDown)
        Me.ImagePPGroupBox.Controls.Add(Me.LumaMatrixHSTrackBar)
        Me.ImagePPGroupBox.Controls.Add(Me.LumaMatrixHSButton)
        resources.ApplyResources(Me.ImagePPGroupBox, "ImagePPGroupBox")
        Me.ImagePPGroupBox.Name = "ImagePPGroupBox"
        Me.ImagePPGroupBox.TabStop = False
        '
        'FFmpegImageUnsharpCheckBox
        '
        resources.ApplyResources(Me.FFmpegImageUnsharpCheckBox, "FFmpegImageUnsharpCheckBox")
        Me.FFmpegImageUnsharpCheckBox.Name = "FFmpegImageUnsharpCheckBox"
        Me.FFmpegImageUnsharpCheckBox.UseVisualStyleBackColor = True
        '
        'FFmpegImageUnsharpLabel
        '
        resources.ApplyResources(Me.FFmpegImageUnsharpLabel, "FFmpegImageUnsharpLabel")
        Me.FFmpegImageUnsharpLabel.ForeColor = System.Drawing.Color.Green
        Me.FFmpegImageUnsharpLabel.Name = "FFmpegImageUnsharpLabel"
        '
        'LumaEffectSNumericUpDown
        '
        Me.LumaEffectSNumericUpDown.DecimalPlaces = 2
        resources.ApplyResources(Me.LumaEffectSNumericUpDown, "LumaEffectSNumericUpDown")
        Me.LumaEffectSNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.LumaEffectSNumericUpDown.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.LumaEffectSNumericUpDown.Minimum = New Decimal(New Integer() {2, 0, 0, -2147483648})
        Me.LumaEffectSNumericUpDown.Name = "LumaEffectSNumericUpDown"
        '
        'ChromaEffectSNumericUpDown
        '
        Me.ChromaEffectSNumericUpDown.DecimalPlaces = 1
        resources.ApplyResources(Me.ChromaEffectSNumericUpDown, "ChromaEffectSNumericUpDown")
        Me.ChromaEffectSNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.ChromaEffectSNumericUpDown.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.ChromaEffectSNumericUpDown.Minimum = New Decimal(New Integer() {2, 0, 0, -2147483648})
        Me.ChromaEffectSNumericUpDown.Name = "ChromaEffectSNumericUpDown"
        '
        'ChromaEffectSTrackBar
        '
        resources.ApplyResources(Me.ChromaEffectSTrackBar, "ChromaEffectSTrackBar")
        Me.ChromaEffectSTrackBar.BackColor = System.Drawing.Color.White
        Me.ChromaEffectSTrackBar.Maximum = 50
        Me.ChromaEffectSTrackBar.Minimum = -20
        Me.ChromaEffectSTrackBar.Name = "ChromaEffectSTrackBar"
        Me.ChromaEffectSTrackBar.TickFrequency = 0
        Me.ChromaEffectSTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'ChromaEffectSButton
        '
        resources.ApplyResources(Me.ChromaEffectSButton, "ChromaEffectSButton")
        Me.ChromaEffectSButton.Name = "ChromaEffectSButton"
        Me.ChromaEffectSButton.UseVisualStyleBackColor = True
        '
        'ChromaMatrixVSNumericUpDown
        '
        resources.ApplyResources(Me.ChromaMatrixVSNumericUpDown, "ChromaMatrixVSNumericUpDown")
        Me.ChromaMatrixVSNumericUpDown.Maximum = New Decimal(New Integer() {13, 0, 0, 0})
        Me.ChromaMatrixVSNumericUpDown.Name = "ChromaMatrixVSNumericUpDown"
        '
        'ChromaMatrixVSTrackBar
        '
        resources.ApplyResources(Me.ChromaMatrixVSTrackBar, "ChromaMatrixVSTrackBar")
        Me.ChromaMatrixVSTrackBar.BackColor = System.Drawing.Color.White
        Me.ChromaMatrixVSTrackBar.Maximum = 13
        Me.ChromaMatrixVSTrackBar.Name = "ChromaMatrixVSTrackBar"
        Me.ChromaMatrixVSTrackBar.TickFrequency = 0
        Me.ChromaMatrixVSTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'ChromaMatrixVSButton
        '
        resources.ApplyResources(Me.ChromaMatrixVSButton, "ChromaMatrixVSButton")
        Me.ChromaMatrixVSButton.Name = "ChromaMatrixVSButton"
        Me.ChromaMatrixVSButton.UseVisualStyleBackColor = True
        '
        'ChromaMatrixHSNumericUpDown
        '
        resources.ApplyResources(Me.ChromaMatrixHSNumericUpDown, "ChromaMatrixHSNumericUpDown")
        Me.ChromaMatrixHSNumericUpDown.Maximum = New Decimal(New Integer() {13, 0, 0, 0})
        Me.ChromaMatrixHSNumericUpDown.Name = "ChromaMatrixHSNumericUpDown"
        '
        'ChromaMatrixHSTrackBar
        '
        resources.ApplyResources(Me.ChromaMatrixHSTrackBar, "ChromaMatrixHSTrackBar")
        Me.ChromaMatrixHSTrackBar.BackColor = System.Drawing.Color.White
        Me.ChromaMatrixHSTrackBar.Maximum = 13
        Me.ChromaMatrixHSTrackBar.Name = "ChromaMatrixHSTrackBar"
        Me.ChromaMatrixHSTrackBar.TickFrequency = 0
        Me.ChromaMatrixHSTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'ChromaMatrixHSButton
        '
        resources.ApplyResources(Me.ChromaMatrixHSButton, "ChromaMatrixHSButton")
        Me.ChromaMatrixHSButton.Name = "ChromaMatrixHSButton"
        Me.ChromaMatrixHSButton.UseVisualStyleBackColor = True
        '
        'LumaEffectSTrackBar
        '
        resources.ApplyResources(Me.LumaEffectSTrackBar, "LumaEffectSTrackBar")
        Me.LumaEffectSTrackBar.BackColor = System.Drawing.Color.White
        Me.LumaEffectSTrackBar.Maximum = 500
        Me.LumaEffectSTrackBar.Minimum = -200
        Me.LumaEffectSTrackBar.Name = "LumaEffectSTrackBar"
        Me.LumaEffectSTrackBar.TickFrequency = 0
        Me.LumaEffectSTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'LumaEffectSButton
        '
        resources.ApplyResources(Me.LumaEffectSButton, "LumaEffectSButton")
        Me.LumaEffectSButton.Name = "LumaEffectSButton"
        Me.LumaEffectSButton.UseVisualStyleBackColor = True
        '
        'LumaMatrixVSNumericUpDown
        '
        resources.ApplyResources(Me.LumaMatrixVSNumericUpDown, "LumaMatrixVSNumericUpDown")
        Me.LumaMatrixVSNumericUpDown.Maximum = New Decimal(New Integer() {13, 0, 0, 0})
        Me.LumaMatrixVSNumericUpDown.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.LumaMatrixVSNumericUpDown.Name = "LumaMatrixVSNumericUpDown"
        Me.LumaMatrixVSNumericUpDown.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'LumaMatrixVSTrackBar
        '
        resources.ApplyResources(Me.LumaMatrixVSTrackBar, "LumaMatrixVSTrackBar")
        Me.LumaMatrixVSTrackBar.BackColor = System.Drawing.Color.White
        Me.LumaMatrixVSTrackBar.Maximum = 13
        Me.LumaMatrixVSTrackBar.Minimum = 3
        Me.LumaMatrixVSTrackBar.Name = "LumaMatrixVSTrackBar"
        Me.LumaMatrixVSTrackBar.TickFrequency = 0
        Me.LumaMatrixVSTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        Me.LumaMatrixVSTrackBar.Value = 5
        '
        'LumaMatrixVSButton
        '
        resources.ApplyResources(Me.LumaMatrixVSButton, "LumaMatrixVSButton")
        Me.LumaMatrixVSButton.Name = "LumaMatrixVSButton"
        Me.LumaMatrixVSButton.UseVisualStyleBackColor = True
        '
        'LumaMatrixHSNumericUpDown
        '
        resources.ApplyResources(Me.LumaMatrixHSNumericUpDown, "LumaMatrixHSNumericUpDown")
        Me.LumaMatrixHSNumericUpDown.Maximum = New Decimal(New Integer() {13, 0, 0, 0})
        Me.LumaMatrixHSNumericUpDown.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.LumaMatrixHSNumericUpDown.Name = "LumaMatrixHSNumericUpDown"
        Me.LumaMatrixHSNumericUpDown.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'LumaMatrixHSTrackBar
        '
        resources.ApplyResources(Me.LumaMatrixHSTrackBar, "LumaMatrixHSTrackBar")
        Me.LumaMatrixHSTrackBar.BackColor = System.Drawing.Color.White
        Me.LumaMatrixHSTrackBar.Maximum = 13
        Me.LumaMatrixHSTrackBar.Minimum = 3
        Me.LumaMatrixHSTrackBar.Name = "LumaMatrixHSTrackBar"
        Me.LumaMatrixHSTrackBar.TickFrequency = 0
        Me.LumaMatrixHSTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        Me.LumaMatrixHSTrackBar.Value = 5
        '
        'LumaMatrixHSButton
        '
        resources.ApplyResources(Me.LumaMatrixHSButton, "LumaMatrixHSButton")
        Me.LumaMatrixHSButton.Name = "LumaMatrixHSButton"
        Me.LumaMatrixHSButton.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        resources.ApplyResources(Me.TabPage2, "TabPage2")
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.hqdn3dPanel)
        Me.GroupBox2.Controls.Add(Me.hqdn3dAutomodeCheckBox)
        Me.GroupBox2.Controls.Add(Me.hqdn3dUseCheckBox)
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'hqdn3dPanel
        '
        Me.hqdn3dPanel.Controls.Add(Me.hqdn3dAutGroupBox)
        Me.hqdn3dPanel.Controls.Add(Me.hqdn3dManGroupBox)
        resources.ApplyResources(Me.hqdn3dPanel, "hqdn3dPanel")
        Me.hqdn3dPanel.Name = "hqdn3dPanel"
        '
        'hqdn3dAutGroupBox
        '
        Me.hqdn3dAutGroupBox.Controls.Add(Me.hqdn3d_2TextBox)
        Me.hqdn3dAutGroupBox.Controls.Add(Me.Label9)
        Me.hqdn3dAutGroupBox.Controls.Add(Me.Label11)
        Me.hqdn3dAutGroupBox.Controls.Add(Me.hqdn3d_3TextBox)
        Me.hqdn3dAutGroupBox.Controls.Add(Me.hqdn3d_auto_NumericUpDown)
        Me.hqdn3dAutGroupBox.Controls.Add(Me.Label8)
        Me.hqdn3dAutGroupBox.Controls.Add(Me.hqdn3d_4TextBox)
        Me.hqdn3dAutGroupBox.Controls.Add(Me.Label12)
        resources.ApplyResources(Me.hqdn3dAutGroupBox, "hqdn3dAutGroupBox")
        Me.hqdn3dAutGroupBox.Name = "hqdn3dAutGroupBox"
        Me.hqdn3dAutGroupBox.TabStop = False
        '
        'hqdn3d_2TextBox
        '
        resources.ApplyResources(Me.hqdn3d_2TextBox, "hqdn3d_2TextBox")
        Me.hqdn3d_2TextBox.Name = "hqdn3d_2TextBox"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.Name = "Label11"
        '
        'hqdn3d_3TextBox
        '
        resources.ApplyResources(Me.hqdn3d_3TextBox, "hqdn3d_3TextBox")
        Me.hqdn3d_3TextBox.Name = "hqdn3d_3TextBox"
        '
        'hqdn3d_auto_NumericUpDown
        '
        Me.hqdn3d_auto_NumericUpDown.DecimalPlaces = 1
        Me.hqdn3d_auto_NumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        resources.ApplyResources(Me.hqdn3d_auto_NumericUpDown, "hqdn3d_auto_NumericUpDown")
        Me.hqdn3d_auto_NumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.hqdn3d_auto_NumericUpDown.Name = "hqdn3d_auto_NumericUpDown"
        Me.hqdn3d_auto_NumericUpDown.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'hqdn3d_4TextBox
        '
        resources.ApplyResources(Me.hqdn3d_4TextBox, "hqdn3d_4TextBox")
        Me.hqdn3d_4TextBox.Name = "hqdn3d_4TextBox"
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.Name = "Label12"
        '
        'hqdn3dManGroupBox
        '
        Me.hqdn3dManGroupBox.Controls.Add(Me.Label13)
        Me.hqdn3dManGroupBox.Controls.Add(Me.Label14)
        Me.hqdn3dManGroupBox.Controls.Add(Me.hqdn3d_manual_TextBox)
        resources.ApplyResources(Me.hqdn3dManGroupBox, "hqdn3dManGroupBox")
        Me.hqdn3dManGroupBox.Name = "hqdn3dManGroupBox"
        Me.hqdn3dManGroupBox.TabStop = False
        '
        'Label13
        '
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.Name = "Label13"
        '
        'Label14
        '
        resources.ApplyResources(Me.Label14, "Label14")
        Me.Label14.Name = "Label14"
        '
        'hqdn3d_manual_TextBox
        '
        resources.ApplyResources(Me.hqdn3d_manual_TextBox, "hqdn3d_manual_TextBox")
        Me.hqdn3d_manual_TextBox.Name = "hqdn3d_manual_TextBox"
        '
        'hqdn3dAutomodeCheckBox
        '
        resources.ApplyResources(Me.hqdn3dAutomodeCheckBox, "hqdn3dAutomodeCheckBox")
        Me.hqdn3dAutomodeCheckBox.Name = "hqdn3dAutomodeCheckBox"
        Me.hqdn3dAutomodeCheckBox.UseVisualStyleBackColor = True
        '
        'hqdn3dUseCheckBox
        '
        resources.ApplyResources(Me.hqdn3dUseCheckBox, "hqdn3dUseCheckBox")
        Me.hqdn3dUseCheckBox.Name = "hqdn3dUseCheckBox"
        Me.hqdn3dUseCheckBox.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox4)
        resources.ApplyResources(Me.TabPage3, "TabPage3")
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.gradfun_radiusNumericUpDown)
        Me.GroupBox4.Controls.Add(Me.gradfun_radiusTrackBar)
        Me.GroupBox4.Controls.Add(Me.gradfun_radiusButton)
        Me.GroupBox4.Controls.Add(Me.gradfun_strengthNumericUpDown)
        Me.GroupBox4.Controls.Add(Me.gradfun_strengthTrackBar)
        Me.GroupBox4.Controls.Add(Me.gradfun_strengthButton)
        Me.GroupBox4.Controls.Add(Me.gradfunCheckBox)
        resources.ApplyResources(Me.GroupBox4, "GroupBox4")
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.TabStop = False
        '
        'gradfun_radiusNumericUpDown
        '
        resources.ApplyResources(Me.gradfun_radiusNumericUpDown, "gradfun_radiusNumericUpDown")
        Me.gradfun_radiusNumericUpDown.Maximum = New Decimal(New Integer() {32, 0, 0, 0})
        Me.gradfun_radiusNumericUpDown.Minimum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.gradfun_radiusNumericUpDown.Name = "gradfun_radiusNumericUpDown"
        Me.gradfun_radiusNumericUpDown.Value = New Decimal(New Integer() {16, 0, 0, 0})
        '
        'gradfun_radiusTrackBar
        '
        resources.ApplyResources(Me.gradfun_radiusTrackBar, "gradfun_radiusTrackBar")
        Me.gradfun_radiusTrackBar.BackColor = System.Drawing.Color.White
        Me.gradfun_radiusTrackBar.Maximum = 32
        Me.gradfun_radiusTrackBar.Minimum = 8
        Me.gradfun_radiusTrackBar.Name = "gradfun_radiusTrackBar"
        Me.gradfun_radiusTrackBar.TickFrequency = 0
        Me.gradfun_radiusTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        Me.gradfun_radiusTrackBar.Value = 16
        '
        'gradfun_radiusButton
        '
        resources.ApplyResources(Me.gradfun_radiusButton, "gradfun_radiusButton")
        Me.gradfun_radiusButton.Name = "gradfun_radiusButton"
        Me.gradfun_radiusButton.UseVisualStyleBackColor = True
        '
        'gradfun_strengthNumericUpDown
        '
        Me.gradfun_strengthNumericUpDown.DecimalPlaces = 2
        resources.ApplyResources(Me.gradfun_strengthNumericUpDown, "gradfun_strengthNumericUpDown")
        Me.gradfun_strengthNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.gradfun_strengthNumericUpDown.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.gradfun_strengthNumericUpDown.Minimum = New Decimal(New Integer() {51, 0, 0, 131072})
        Me.gradfun_strengthNumericUpDown.Name = "gradfun_strengthNumericUpDown"
        Me.gradfun_strengthNumericUpDown.Value = New Decimal(New Integer() {12, 0, 0, 65536})
        '
        'gradfun_strengthTrackBar
        '
        resources.ApplyResources(Me.gradfun_strengthTrackBar, "gradfun_strengthTrackBar")
        Me.gradfun_strengthTrackBar.BackColor = System.Drawing.Color.White
        Me.gradfun_strengthTrackBar.Maximum = 25500
        Me.gradfun_strengthTrackBar.Minimum = 51
        Me.gradfun_strengthTrackBar.Name = "gradfun_strengthTrackBar"
        Me.gradfun_strengthTrackBar.TickFrequency = 0
        Me.gradfun_strengthTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        Me.gradfun_strengthTrackBar.Value = 120
        '
        'gradfun_strengthButton
        '
        resources.ApplyResources(Me.gradfun_strengthButton, "gradfun_strengthButton")
        Me.gradfun_strengthButton.Name = "gradfun_strengthButton"
        Me.gradfun_strengthButton.UseVisualStyleBackColor = True
        '
        'gradfunCheckBox
        '
        resources.ApplyResources(Me.gradfunCheckBox, "gradfunCheckBox")
        Me.gradfunCheckBox.Name = "gradfunCheckBox"
        Me.gradfunCheckBox.UseVisualStyleBackColor = True
        '
        'ImageTabPage
        '
        Me.ImageTabPage.BackColor = System.Drawing.Color.Transparent
        Me.ImageTabPage.Controls.Add(Me.ImageGroupBox)
        Me.ImageTabPage.Controls.Add(Me.FFTurnGroupBox)
        Me.ImageTabPage.Controls.Add(Me.flipGroupBox)
        resources.ApplyResources(Me.ImageTabPage, "ImageTabPage")
        Me.ImageTabPage.Name = "ImageTabPage"
        Me.ImageTabPage.UseVisualStyleBackColor = True
        '
        'ImageGroupBox
        '
        Me.ImageGroupBox.Controls.Add(Me.AspectSLabel)
        Me.ImageGroupBox.Controls.Add(Me.AspectHTextBox)
        Me.ImageGroupBox.Controls.Add(Me.AspectWTextBox)
        Me.ImageGroupBox.Controls.Add(Me.AspectComboBox2)
        Me.ImageGroupBox.Controls.Add(Me.AspectComboBox)
        Me.ImageGroupBox.Controls.Add(Me.AspectLabel)
        Me.ImageGroupBox.Controls.Add(Me.FFmpegResizeFilterComboBox)
        Me.ImageGroupBox.Controls.Add(Me.FFmpegResizeFilterLabel)
        Me.ImageGroupBox.Controls.Add(Me.ImageSizeCheckBox)
        Me.ImageGroupBox.Controls.Add(Me.ImageSizeSLabel)
        Me.ImageGroupBox.Controls.Add(Me.ImageSizeHeightTextBox)
        Me.ImageGroupBox.Controls.Add(Me.ImageSizeWidthTextBox)
        Me.ImageGroupBox.Controls.Add(Me.ImageSizeComboBox)
        Me.ImageGroupBox.Controls.Add(Me.ImageSizeLabel)
        resources.ApplyResources(Me.ImageGroupBox, "ImageGroupBox")
        Me.ImageGroupBox.Name = "ImageGroupBox"
        Me.ImageGroupBox.TabStop = False
        '
        'AspectSLabel
        '
        resources.ApplyResources(Me.AspectSLabel, "AspectSLabel")
        Me.AspectSLabel.Name = "AspectSLabel"
        '
        'AspectHTextBox
        '
        resources.ApplyResources(Me.AspectHTextBox, "AspectHTextBox")
        Me.AspectHTextBox.Name = "AspectHTextBox"
        '
        'AspectWTextBox
        '
        resources.ApplyResources(Me.AspectWTextBox, "AspectWTextBox")
        Me.AspectWTextBox.Name = "AspectWTextBox"
        '
        'AspectComboBox2
        '
        Me.AspectComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AspectComboBox2.FormattingEnabled = True
        resources.ApplyResources(Me.AspectComboBox2, "AspectComboBox2")
        Me.AspectComboBox2.Name = "AspectComboBox2"
        '
        'AspectComboBox
        '
        Me.AspectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AspectComboBox.FormattingEnabled = True
        resources.ApplyResources(Me.AspectComboBox, "AspectComboBox")
        Me.AspectComboBox.Name = "AspectComboBox"
        '
        'AspectLabel
        '
        resources.ApplyResources(Me.AspectLabel, "AspectLabel")
        Me.AspectLabel.Name = "AspectLabel"
        '
        'FFmpegResizeFilterComboBox
        '
        Me.FFmpegResizeFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FFmpegResizeFilterComboBox.FormattingEnabled = True
        resources.ApplyResources(Me.FFmpegResizeFilterComboBox, "FFmpegResizeFilterComboBox")
        Me.FFmpegResizeFilterComboBox.Name = "FFmpegResizeFilterComboBox"
        '
        'FFmpegResizeFilterLabel
        '
        resources.ApplyResources(Me.FFmpegResizeFilterLabel, "FFmpegResizeFilterLabel")
        Me.FFmpegResizeFilterLabel.Name = "FFmpegResizeFilterLabel"
        '
        'ImageSizeCheckBox
        '
        resources.ApplyResources(Me.ImageSizeCheckBox, "ImageSizeCheckBox")
        Me.ImageSizeCheckBox.Name = "ImageSizeCheckBox"
        Me.ImageSizeCheckBox.UseVisualStyleBackColor = True
        '
        'ImageSizeSLabel
        '
        resources.ApplyResources(Me.ImageSizeSLabel, "ImageSizeSLabel")
        Me.ImageSizeSLabel.Name = "ImageSizeSLabel"
        '
        'ImageSizeHeightTextBox
        '
        resources.ApplyResources(Me.ImageSizeHeightTextBox, "ImageSizeHeightTextBox")
        Me.ImageSizeHeightTextBox.Name = "ImageSizeHeightTextBox"
        '
        'ImageSizeWidthTextBox
        '
        resources.ApplyResources(Me.ImageSizeWidthTextBox, "ImageSizeWidthTextBox")
        Me.ImageSizeWidthTextBox.Name = "ImageSizeWidthTextBox"
        '
        'ImageSizeComboBox
        '
        Me.ImageSizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ImageSizeComboBox.FormattingEnabled = True
        resources.ApplyResources(Me.ImageSizeComboBox, "ImageSizeComboBox")
        Me.ImageSizeComboBox.Name = "ImageSizeComboBox"
        '
        'ImageSizeLabel
        '
        resources.ApplyResources(Me.ImageSizeLabel, "ImageSizeLabel")
        Me.ImageSizeLabel.Name = "ImageSizeLabel"
        '
        'FFTurnGroupBox
        '
        Me.FFTurnGroupBox.Controls.Add(Me.FFVerticallyCheckBox)
        Me.FFTurnGroupBox.Controls.Add(Me.FFTurnCheckBox)
        Me.FFTurnGroupBox.Controls.Add(Me.FFTurnRightRadioButton)
        Me.FFTurnGroupBox.Controls.Add(Me.FFTurnLeftRadioButton)
        resources.ApplyResources(Me.FFTurnGroupBox, "FFTurnGroupBox")
        Me.FFTurnGroupBox.Name = "FFTurnGroupBox"
        Me.FFTurnGroupBox.TabStop = False
        '
        'FFVerticallyCheckBox
        '
        resources.ApplyResources(Me.FFVerticallyCheckBox, "FFVerticallyCheckBox")
        Me.FFVerticallyCheckBox.Name = "FFVerticallyCheckBox"
        Me.FFVerticallyCheckBox.UseVisualStyleBackColor = True
        '
        'FFTurnCheckBox
        '
        resources.ApplyResources(Me.FFTurnCheckBox, "FFTurnCheckBox")
        Me.FFTurnCheckBox.Name = "FFTurnCheckBox"
        Me.FFTurnCheckBox.UseVisualStyleBackColor = True
        '
        'FFTurnRightRadioButton
        '
        resources.ApplyResources(Me.FFTurnRightRadioButton, "FFTurnRightRadioButton")
        Me.FFTurnRightRadioButton.Name = "FFTurnRightRadioButton"
        Me.FFTurnRightRadioButton.TabStop = True
        Me.FFTurnRightRadioButton.UseVisualStyleBackColor = True
        '
        'FFTurnLeftRadioButton
        '
        resources.ApplyResources(Me.FFTurnLeftRadioButton, "FFTurnLeftRadioButton")
        Me.FFTurnLeftRadioButton.Name = "FFTurnLeftRadioButton"
        Me.FFTurnLeftRadioButton.TabStop = True
        Me.FFTurnLeftRadioButton.UseVisualStyleBackColor = True
        '
        'flipGroupBox
        '
        Me.flipGroupBox.Controls.Add(Me.hflipCheckBox)
        Me.flipGroupBox.Controls.Add(Me.vflipCheckBox)
        resources.ApplyResources(Me.flipGroupBox, "flipGroupBox")
        Me.flipGroupBox.Name = "flipGroupBox"
        Me.flipGroupBox.TabStop = False
        '
        'hflipCheckBox
        '
        resources.ApplyResources(Me.hflipCheckBox, "hflipCheckBox")
        Me.hflipCheckBox.Name = "hflipCheckBox"
        Me.hflipCheckBox.UseVisualStyleBackColor = True
        '
        'vflipCheckBox
        '
        resources.ApplyResources(Me.vflipCheckBox, "vflipCheckBox")
        Me.vflipCheckBox.Name = "vflipCheckBox"
        Me.vflipCheckBox.UseVisualStyleBackColor = True
        '
        'AudioTabPage
        '
        Me.AudioTabPage.BackColor = System.Drawing.Color.Transparent
        Me.AudioTabPage.Controls.Add(Me.AudioGroupBox)
        Me.AudioTabPage.Controls.Add(Me.NeroAACGroupBox)
        Me.AudioTabPage.Controls.Add(Me.FFAudGroupBox)
        resources.ApplyResources(Me.AudioTabPage, "AudioTabPage")
        Me.AudioTabPage.Name = "AudioTabPage"
        Me.AudioTabPage.UseVisualStyleBackColor = True
        '
        'AudioGroupBox
        '
        Me.AudioGroupBox.Controls.Add(Me.AAMRWBBitratePanel)
        Me.AudioGroupBox.Controls.Add(Me.LAMEMP3QPanel)
        Me.AudioGroupBox.Controls.Add(Me.SampleratePanel)
        Me.AudioGroupBox.Controls.Add(Me.BitrateNPanel)
        Me.AudioGroupBox.Controls.Add(Me.AAMRBitratePanel)
        Me.AudioGroupBox.Controls.Add(Me.AbitratePanel)
        Me.AudioGroupBox.Controls.Add(Me.AVorbisQPanel)
        Me.AudioGroupBox.Controls.Add(Me.AudioCodecComboBox)
        Me.AudioGroupBox.Controls.Add(Me.ACodecLabel)
        resources.ApplyResources(Me.AudioGroupBox, "AudioGroupBox")
        Me.AudioGroupBox.Name = "AudioGroupBox"
        Me.AudioGroupBox.TabStop = False
        '
        'AAMRWBBitratePanel
        '
        Me.AAMRWBBitratePanel.Controls.Add(Me.AMRWBBitrateComboBox)
        Me.AAMRWBBitratePanel.Controls.Add(Me.AMRWBBitrateLabel)
        Me.AAMRWBBitratePanel.Controls.Add(Me.Label16)
        resources.ApplyResources(Me.AAMRWBBitratePanel, "AAMRWBBitratePanel")
        Me.AAMRWBBitratePanel.Name = "AAMRWBBitratePanel"
        '
        'AMRWBBitrateComboBox
        '
        Me.AMRWBBitrateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AMRWBBitrateComboBox.FormattingEnabled = True
        Me.AMRWBBitrateComboBox.Items.AddRange(New Object() {resources.GetString("AMRWBBitrateComboBox.Items"), resources.GetString("AMRWBBitrateComboBox.Items1"), resources.GetString("AMRWBBitrateComboBox.Items2"), resources.GetString("AMRWBBitrateComboBox.Items3"), resources.GetString("AMRWBBitrateComboBox.Items4"), resources.GetString("AMRWBBitrateComboBox.Items5"), resources.GetString("AMRWBBitrateComboBox.Items6"), resources.GetString("AMRWBBitrateComboBox.Items7"), resources.GetString("AMRWBBitrateComboBox.Items8")})
        resources.ApplyResources(Me.AMRWBBitrateComboBox, "AMRWBBitrateComboBox")
        Me.AMRWBBitrateComboBox.Name = "AMRWBBitrateComboBox"
        '
        'AMRWBBitrateLabel
        '
        resources.ApplyResources(Me.AMRWBBitrateLabel, "AMRWBBitrateLabel")
        Me.AMRWBBitrateLabel.Name = "AMRWBBitrateLabel"
        '
        'Label16
        '
        resources.ApplyResources(Me.Label16, "Label16")
        Me.Label16.Name = "Label16"
        '
        'LAMEMP3QPanel
        '
        Me.LAMEMP3QPanel.Controls.Add(Me.Label7)
        Me.LAMEMP3QPanel.Controls.Add(Me.Label6)
        Me.LAMEMP3QPanel.Controls.Add(Me.LAMEMP3QLabel2)
        Me.LAMEMP3QPanel.Controls.Add(Me.LAMEMP3QComboBox)
        Me.LAMEMP3QPanel.Controls.Add(Me.LAMEMP3QTrackBar)
        Me.LAMEMP3QPanel.Controls.Add(Me.LAMEMP3QNumericUpDown)
        Me.LAMEMP3QPanel.Controls.Add(Me.LAMEMP3QLabel)
        resources.ApplyResources(Me.LAMEMP3QPanel, "LAMEMP3QPanel")
        Me.LAMEMP3QPanel.Name = "LAMEMP3QPanel"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'LAMEMP3QLabel2
        '
        resources.ApplyResources(Me.LAMEMP3QLabel2, "LAMEMP3QLabel2")
        Me.LAMEMP3QLabel2.Name = "LAMEMP3QLabel2"
        '
        'LAMEMP3QComboBox
        '
        Me.LAMEMP3QComboBox.FormattingEnabled = True
        resources.ApplyResources(Me.LAMEMP3QComboBox, "LAMEMP3QComboBox")
        Me.LAMEMP3QComboBox.Name = "LAMEMP3QComboBox"
        '
        'LAMEMP3QTrackBar
        '
        resources.ApplyResources(Me.LAMEMP3QTrackBar, "LAMEMP3QTrackBar")
        Me.LAMEMP3QTrackBar.BackColor = System.Drawing.Color.White
        Me.LAMEMP3QTrackBar.Maximum = 1000
        Me.LAMEMP3QTrackBar.Name = "LAMEMP3QTrackBar"
        Me.LAMEMP3QTrackBar.TickFrequency = 0
        Me.LAMEMP3QTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        Me.LAMEMP3QTrackBar.Value = 400
        '
        'LAMEMP3QNumericUpDown
        '
        Me.LAMEMP3QNumericUpDown.DecimalPlaces = 2
        Me.LAMEMP3QNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        resources.ApplyResources(Me.LAMEMP3QNumericUpDown, "LAMEMP3QNumericUpDown")
        Me.LAMEMP3QNumericUpDown.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.LAMEMP3QNumericUpDown.Name = "LAMEMP3QNumericUpDown"
        Me.LAMEMP3QNumericUpDown.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'LAMEMP3QLabel
        '
        resources.ApplyResources(Me.LAMEMP3QLabel, "LAMEMP3QLabel")
        Me.LAMEMP3QLabel.Name = "LAMEMP3QLabel"
        '
        'SampleratePanel
        '
        Me.SampleratePanel.Controls.Add(Me.SamplerateCheckBox)
        Me.SampleratePanel.Controls.Add(Me.SamplerateLabel2)
        Me.SampleratePanel.Controls.Add(Me.SamplerateComboBox)
        Me.SampleratePanel.Controls.Add(Me.SamplerateLabel)
        resources.ApplyResources(Me.SampleratePanel, "SampleratePanel")
        Me.SampleratePanel.Name = "SampleratePanel"
        '
        'SamplerateCheckBox
        '
        resources.ApplyResources(Me.SamplerateCheckBox, "SamplerateCheckBox")
        Me.SamplerateCheckBox.Name = "SamplerateCheckBox"
        Me.SamplerateCheckBox.UseVisualStyleBackColor = True
        '
        'SamplerateLabel2
        '
        resources.ApplyResources(Me.SamplerateLabel2, "SamplerateLabel2")
        Me.SamplerateLabel2.Name = "SamplerateLabel2"
        '
        'SamplerateComboBox
        '
        Me.SamplerateComboBox.FormattingEnabled = True
        Me.SamplerateComboBox.Items.AddRange(New Object() {resources.GetString("SamplerateComboBox.Items"), resources.GetString("SamplerateComboBox.Items1"), resources.GetString("SamplerateComboBox.Items2"), resources.GetString("SamplerateComboBox.Items3"), resources.GetString("SamplerateComboBox.Items4"), resources.GetString("SamplerateComboBox.Items5"), resources.GetString("SamplerateComboBox.Items6"), resources.GetString("SamplerateComboBox.Items7"), resources.GetString("SamplerateComboBox.Items8"), resources.GetString("SamplerateComboBox.Items9"), resources.GetString("SamplerateComboBox.Items10"), resources.GetString("SamplerateComboBox.Items11")})
        resources.ApplyResources(Me.SamplerateComboBox, "SamplerateComboBox")
        Me.SamplerateComboBox.Name = "SamplerateComboBox"
        '
        'SamplerateLabel
        '
        resources.ApplyResources(Me.SamplerateLabel, "SamplerateLabel")
        Me.SamplerateLabel.Name = "SamplerateLabel"
        '
        'BitrateNPanel
        '
        Me.BitrateNPanel.Controls.Add(Me.AudioBitrateNLabel)
        resources.ApplyResources(Me.BitrateNPanel, "BitrateNPanel")
        Me.BitrateNPanel.Name = "BitrateNPanel"
        '
        'AudioBitrateNLabel
        '
        resources.ApplyResources(Me.AudioBitrateNLabel, "AudioBitrateNLabel")
        Me.AudioBitrateNLabel.ForeColor = System.Drawing.Color.Green
        Me.AudioBitrateNLabel.Name = "AudioBitrateNLabel"
        '
        'AAMRBitratePanel
        '
        Me.AAMRBitratePanel.Controls.Add(Me.AMRBitrateComboBox)
        Me.AAMRBitratePanel.Controls.Add(Me.AMRBitrateLabel)
        Me.AAMRBitratePanel.Controls.Add(Me.Label10)
        resources.ApplyResources(Me.AAMRBitratePanel, "AAMRBitratePanel")
        Me.AAMRBitratePanel.Name = "AAMRBitratePanel"
        '
        'AMRBitrateComboBox
        '
        Me.AMRBitrateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AMRBitrateComboBox.FormattingEnabled = True
        Me.AMRBitrateComboBox.Items.AddRange(New Object() {resources.GetString("AMRBitrateComboBox.Items"), resources.GetString("AMRBitrateComboBox.Items1"), resources.GetString("AMRBitrateComboBox.Items2"), resources.GetString("AMRBitrateComboBox.Items3"), resources.GetString("AMRBitrateComboBox.Items4"), resources.GetString("AMRBitrateComboBox.Items5"), resources.GetString("AMRBitrateComboBox.Items6"), resources.GetString("AMRBitrateComboBox.Items7")})
        resources.ApplyResources(Me.AMRBitrateComboBox, "AMRBitrateComboBox")
        Me.AMRBitrateComboBox.Name = "AMRBitrateComboBox"
        '
        'AMRBitrateLabel
        '
        resources.ApplyResources(Me.AMRBitrateLabel, "AMRBitrateLabel")
        Me.AMRBitrateLabel.Name = "AMRBitrateLabel"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        '
        'AbitratePanel
        '
        Me.AbitratePanel.Controls.Add(Me.AudioBitrateComboBox)
        Me.AbitratePanel.Controls.Add(Me.AudioBitrateLabel)
        Me.AbitratePanel.Controls.Add(Me.Label3)
        resources.ApplyResources(Me.AbitratePanel, "AbitratePanel")
        Me.AbitratePanel.Name = "AbitratePanel"
        '
        'AudioBitrateComboBox
        '
        Me.AudioBitrateComboBox.FormattingEnabled = True
        resources.ApplyResources(Me.AudioBitrateComboBox, "AudioBitrateComboBox")
        Me.AudioBitrateComboBox.Name = "AudioBitrateComboBox"
        '
        'AudioBitrateLabel
        '
        resources.ApplyResources(Me.AudioBitrateLabel, "AudioBitrateLabel")
        Me.AudioBitrateLabel.Name = "AudioBitrateLabel"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'AVorbisQPanel
        '
        Me.AVorbisQPanel.Controls.Add(Me.Label5)
        Me.AVorbisQPanel.Controls.Add(Me.Label4)
        Me.AVorbisQPanel.Controls.Add(Me.VorbisQTrackBar)
        Me.AVorbisQPanel.Controls.Add(Me.VorbisQNumericUpDown)
        Me.AVorbisQPanel.Controls.Add(Me.VorbisQLabel)
        resources.ApplyResources(Me.AVorbisQPanel, "AVorbisQPanel")
        Me.AVorbisQPanel.Name = "AVorbisQPanel"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'VorbisQTrackBar
        '
        resources.ApplyResources(Me.VorbisQTrackBar, "VorbisQTrackBar")
        Me.VorbisQTrackBar.BackColor = System.Drawing.Color.White
        Me.VorbisQTrackBar.Minimum = -1
        Me.VorbisQTrackBar.Name = "VorbisQTrackBar"
        Me.VorbisQTrackBar.TickFrequency = 0
        Me.VorbisQTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'VorbisQNumericUpDown
        '
        resources.ApplyResources(Me.VorbisQNumericUpDown, "VorbisQNumericUpDown")
        Me.VorbisQNumericUpDown.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.VorbisQNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.VorbisQNumericUpDown.Name = "VorbisQNumericUpDown"
        Me.VorbisQNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'VorbisQLabel
        '
        resources.ApplyResources(Me.VorbisQLabel, "VorbisQLabel")
        Me.VorbisQLabel.Name = "VorbisQLabel"
        '
        'AudioCodecComboBox
        '
        Me.AudioCodecComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AudioCodecComboBox.FormattingEnabled = True
        resources.ApplyResources(Me.AudioCodecComboBox, "AudioCodecComboBox")
        Me.AudioCodecComboBox.Name = "AudioCodecComboBox"
        '
        'ACodecLabel
        '
        resources.ApplyResources(Me.ACodecLabel, "ACodecLabel")
        Me.ACodecLabel.Name = "ACodecLabel"
        '
        'NeroAACGroupBox
        '
        Me.NeroAACGroupBox.Controls.Add(Me.Label2)
        Me.NeroAACGroupBox.Controls.Add(Me.Label1)
        Me.NeroAACGroupBox.Controls.Add(Me.NeroAACQTrackBar)
        Me.NeroAACGroupBox.Controls.Add(Me.NeroAACQNumericUpDown)
        Me.NeroAACGroupBox.Controls.Add(Me.NeroAACQLabel)
        Me.NeroAACGroupBox.Controls.Add(Me.NeroAACVBRRadioButton)
        Me.NeroAACGroupBox.Controls.Add(Me.NeroAACCBRRadioButton)
        Me.NeroAACGroupBox.Controls.Add(Me.NeroAACABRRadioButton)
        Me.NeroAACGroupBox.Controls.Add(Me.NeroAACBitrateTrackBar)
        Me.NeroAACGroupBox.Controls.Add(Me.NeroAACBitrateNumericUpDown)
        Me.NeroAACGroupBox.Controls.Add(Me.NeroAACBitrateLabel)
        Me.NeroAACGroupBox.Controls.Add(Me.NeroAACSALabel)
        Me.NeroAACGroupBox.Controls.Add(Me.NeroAACProfileComboBox)
        Me.NeroAACGroupBox.Controls.Add(Me.NeroAACProfileLabel)
        resources.ApplyResources(Me.NeroAACGroupBox, "NeroAACGroupBox")
        Me.NeroAACGroupBox.Name = "NeroAACGroupBox"
        Me.NeroAACGroupBox.TabStop = False
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'NeroAACQTrackBar
        '
        resources.ApplyResources(Me.NeroAACQTrackBar, "NeroAACQTrackBar")
        Me.NeroAACQTrackBar.BackColor = System.Drawing.Color.White
        Me.NeroAACQTrackBar.Maximum = 100
        Me.NeroAACQTrackBar.Name = "NeroAACQTrackBar"
        Me.NeroAACQTrackBar.TickFrequency = 0
        Me.NeroAACQTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'NeroAACQNumericUpDown
        '
        Me.NeroAACQNumericUpDown.DecimalPlaces = 2
        Me.NeroAACQNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        resources.ApplyResources(Me.NeroAACQNumericUpDown, "NeroAACQNumericUpDown")
        Me.NeroAACQNumericUpDown.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NeroAACQNumericUpDown.Name = "NeroAACQNumericUpDown"
        '
        'NeroAACQLabel
        '
        resources.ApplyResources(Me.NeroAACQLabel, "NeroAACQLabel")
        Me.NeroAACQLabel.Name = "NeroAACQLabel"
        '
        'NeroAACVBRRadioButton
        '
        resources.ApplyResources(Me.NeroAACVBRRadioButton, "NeroAACVBRRadioButton")
        Me.NeroAACVBRRadioButton.Name = "NeroAACVBRRadioButton"
        Me.NeroAACVBRRadioButton.TabStop = True
        Me.NeroAACVBRRadioButton.UseVisualStyleBackColor = True
        '
        'NeroAACCBRRadioButton
        '
        resources.ApplyResources(Me.NeroAACCBRRadioButton, "NeroAACCBRRadioButton")
        Me.NeroAACCBRRadioButton.Name = "NeroAACCBRRadioButton"
        Me.NeroAACCBRRadioButton.TabStop = True
        Me.NeroAACCBRRadioButton.UseVisualStyleBackColor = True
        '
        'NeroAACABRRadioButton
        '
        resources.ApplyResources(Me.NeroAACABRRadioButton, "NeroAACABRRadioButton")
        Me.NeroAACABRRadioButton.Name = "NeroAACABRRadioButton"
        Me.NeroAACABRRadioButton.TabStop = True
        Me.NeroAACABRRadioButton.UseVisualStyleBackColor = True
        '
        'NeroAACBitrateTrackBar
        '
        resources.ApplyResources(Me.NeroAACBitrateTrackBar, "NeroAACBitrateTrackBar")
        Me.NeroAACBitrateTrackBar.BackColor = System.Drawing.Color.White
        Me.NeroAACBitrateTrackBar.Maximum = 640
        Me.NeroAACBitrateTrackBar.Minimum = 8
        Me.NeroAACBitrateTrackBar.Name = "NeroAACBitrateTrackBar"
        Me.NeroAACBitrateTrackBar.TickFrequency = 0
        Me.NeroAACBitrateTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        Me.NeroAACBitrateTrackBar.Value = 8
        '
        'NeroAACBitrateNumericUpDown
        '
        resources.ApplyResources(Me.NeroAACBitrateNumericUpDown, "NeroAACBitrateNumericUpDown")
        Me.NeroAACBitrateNumericUpDown.Maximum = New Decimal(New Integer() {640, 0, 0, 0})
        Me.NeroAACBitrateNumericUpDown.Minimum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.NeroAACBitrateNumericUpDown.Name = "NeroAACBitrateNumericUpDown"
        Me.NeroAACBitrateNumericUpDown.Value = New Decimal(New Integer() {8, 0, 0, 0})
        '
        'NeroAACBitrateLabel
        '
        resources.ApplyResources(Me.NeroAACBitrateLabel, "NeroAACBitrateLabel")
        Me.NeroAACBitrateLabel.Name = "NeroAACBitrateLabel"
        '
        'NeroAACSALabel
        '
        resources.ApplyResources(Me.NeroAACSALabel, "NeroAACSALabel")
        Me.NeroAACSALabel.ForeColor = System.Drawing.Color.Green
        Me.NeroAACSALabel.Name = "NeroAACSALabel"
        '
        'NeroAACProfileComboBox
        '
        Me.NeroAACProfileComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NeroAACProfileComboBox.FormattingEnabled = True
        Me.NeroAACProfileComboBox.Items.AddRange(New Object() {resources.GetString("NeroAACProfileComboBox.Items"), resources.GetString("NeroAACProfileComboBox.Items1"), resources.GetString("NeroAACProfileComboBox.Items2"), resources.GetString("NeroAACProfileComboBox.Items3")})
        resources.ApplyResources(Me.NeroAACProfileComboBox, "NeroAACProfileComboBox")
        Me.NeroAACProfileComboBox.Name = "NeroAACProfileComboBox"
        '
        'NeroAACProfileLabel
        '
        resources.ApplyResources(Me.NeroAACProfileLabel, "NeroAACProfileLabel")
        Me.NeroAACProfileLabel.Name = "NeroAACProfileLabel"
        '
        'FFAudGroupBox
        '
        Me.FFAudGroupBox.Controls.Add(Me.FFmpegChComboBox)
        Me.FFAudGroupBox.Controls.Add(Me.FFmpegChLabel)
        Me.FFAudGroupBox.Controls.Add(Me.AudioVolLabel)
        Me.FFAudGroupBox.Controls.Add(Me.AudioVolNLabel)
        Me.FFAudGroupBox.Controls.Add(Me.AudioVolNumericUpDown)
        Me.FFAudGroupBox.Controls.Add(Me.AudioVolButton)
        Me.FFAudGroupBox.Controls.Add(Me.AudioVolTrackBar)
        resources.ApplyResources(Me.FFAudGroupBox, "FFAudGroupBox")
        Me.FFAudGroupBox.Name = "FFAudGroupBox"
        Me.FFAudGroupBox.TabStop = False
        '
        'FFmpegChComboBox
        '
        Me.FFmpegChComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FFmpegChComboBox.FormattingEnabled = True
        resources.ApplyResources(Me.FFmpegChComboBox, "FFmpegChComboBox")
        Me.FFmpegChComboBox.Name = "FFmpegChComboBox"
        '
        'FFmpegChLabel
        '
        resources.ApplyResources(Me.FFmpegChLabel, "FFmpegChLabel")
        Me.FFmpegChLabel.Name = "FFmpegChLabel"
        '
        'AudioVolLabel
        '
        resources.ApplyResources(Me.AudioVolLabel, "AudioVolLabel")
        Me.AudioVolLabel.Name = "AudioVolLabel"
        '
        'AudioVolNLabel
        '
        resources.ApplyResources(Me.AudioVolNLabel, "AudioVolNLabel")
        Me.AudioVolNLabel.ForeColor = System.Drawing.Color.Green
        Me.AudioVolNLabel.Name = "AudioVolNLabel"
        '
        'AudioVolNumericUpDown
        '
        resources.ApplyResources(Me.AudioVolNumericUpDown, "AudioVolNumericUpDown")
        Me.AudioVolNumericUpDown.Maximum = New Decimal(New Integer() {3840, 0, 0, 0})
        Me.AudioVolNumericUpDown.Name = "AudioVolNumericUpDown"
        '
        'AudioVolButton
        '
        resources.ApplyResources(Me.AudioVolButton, "AudioVolButton")
        Me.AudioVolButton.Name = "AudioVolButton"
        Me.AudioVolButton.UseVisualStyleBackColor = True
        '
        'AudioVolTrackBar
        '
        resources.ApplyResources(Me.AudioVolTrackBar, "AudioVolTrackBar")
        Me.AudioVolTrackBar.BackColor = System.Drawing.Color.White
        Me.AudioVolTrackBar.Maximum = 3840
        Me.AudioVolTrackBar.Name = "AudioVolTrackBar"
        Me.AudioVolTrackBar.TickFrequency = 0
        Me.AudioVolTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'ETCTabPage
        '
        Me.ETCTabPage.Controls.Add(Me.SizeEncGroupBox)
        Me.ETCTabPage.Controls.Add(Me.GroupBox1)
        Me.ETCTabPage.Controls.Add(Me.FFmpegCommandGroupBox)
        Me.ETCTabPage.Controls.Add(Me.SizeLimitGroupBox)
        Me.ETCTabPage.Controls.Add(Me.NameGroupBox)
        resources.ApplyResources(Me.ETCTabPage, "ETCTabPage")
        Me.ETCTabPage.Name = "ETCTabPage"
        Me.ETCTabPage.UseVisualStyleBackColor = True
        '
        'SizeEncGroupBox
        '
        Me.SizeEncGroupBox.Controls.Add(Me.SizeButton)
        Me.SizeEncGroupBox.Controls.Add(Me.SizeEncGBLabel)
        Me.SizeEncGroupBox.Controls.Add(Me.SizeEncMBLabel)
        Me.SizeEncGroupBox.Controls.Add(Me.SizeEncTextBox)
        Me.SizeEncGroupBox.Controls.Add(Me.SizeEncLabel)
        Me.SizeEncGroupBox.Controls.Add(Me.SizeEncCheckBox)
        resources.ApplyResources(Me.SizeEncGroupBox, "SizeEncGroupBox")
        Me.SizeEncGroupBox.Name = "SizeEncGroupBox"
        Me.SizeEncGroupBox.TabStop = False
        '
        'SizeButton
        '
        resources.ApplyResources(Me.SizeButton, "SizeButton")
        Me.SizeButton.Name = "SizeButton"
        Me.SizeButton.UseVisualStyleBackColor = True
        '
        'SizeEncGBLabel
        '
        resources.ApplyResources(Me.SizeEncGBLabel, "SizeEncGBLabel")
        Me.SizeEncGBLabel.Name = "SizeEncGBLabel"
        '
        'SizeEncMBLabel
        '
        resources.ApplyResources(Me.SizeEncMBLabel, "SizeEncMBLabel")
        Me.SizeEncMBLabel.Name = "SizeEncMBLabel"
        '
        'SizeEncTextBox
        '
        resources.ApplyResources(Me.SizeEncTextBox, "SizeEncTextBox")
        Me.SizeEncTextBox.Name = "SizeEncTextBox"
        '
        'SizeEncLabel
        '
        resources.ApplyResources(Me.SizeEncLabel, "SizeEncLabel")
        Me.SizeEncLabel.ForeColor = System.Drawing.Color.Green
        Me.SizeEncLabel.Name = "SizeEncLabel"
        '
        'SizeEncCheckBox
        '
        resources.ApplyResources(Me.SizeEncCheckBox, "SizeEncCheckBox")
        Me.SizeEncCheckBox.Name = "SizeEncCheckBox"
        Me.SizeEncCheckBox.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RemoveMeatadataCheckBox)
        Me.GroupBox1.Controls.Add(Me.SubtitleRecordingCheckBox)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'RemoveMeatadataCheckBox
        '
        resources.ApplyResources(Me.RemoveMeatadataCheckBox, "RemoveMeatadataCheckBox")
        Me.RemoveMeatadataCheckBox.Name = "RemoveMeatadataCheckBox"
        Me.RemoveMeatadataCheckBox.UseVisualStyleBackColor = True
        '
        'SubtitleRecordingCheckBox
        '
        resources.ApplyResources(Me.SubtitleRecordingCheckBox, "SubtitleRecordingCheckBox")
        Me.SubtitleRecordingCheckBox.Name = "SubtitleRecordingCheckBox"
        Me.SubtitleRecordingCheckBox.UseVisualStyleBackColor = True
        '
        'FFmpegCommandGroupBox
        '
        Me.FFmpegCommandGroupBox.Controls.Add(Me.FFmpegCommandButton)
        Me.FFmpegCommandGroupBox.Controls.Add(Me.FFmpegCommandTextBox)
        resources.ApplyResources(Me.FFmpegCommandGroupBox, "FFmpegCommandGroupBox")
        Me.FFmpegCommandGroupBox.Name = "FFmpegCommandGroupBox"
        Me.FFmpegCommandGroupBox.TabStop = False
        '
        'FFmpegCommandButton
        '
        resources.ApplyResources(Me.FFmpegCommandButton, "FFmpegCommandButton")
        Me.FFmpegCommandButton.Name = "FFmpegCommandButton"
        Me.FFmpegCommandButton.UseVisualStyleBackColor = True
        '
        'FFmpegCommandTextBox
        '
        resources.ApplyResources(Me.FFmpegCommandTextBox, "FFmpegCommandTextBox")
        Me.FFmpegCommandTextBox.Name = "FFmpegCommandTextBox"
        '
        'SizeLimitGroupBox
        '
        Me.SizeLimitGroupBox.Controls.Add(Me.SizeLimitCheckBox)
        Me.SizeLimitGroupBox.Controls.Add(Me.SizeLimitLabel)
        Me.SizeLimitGroupBox.Controls.Add(Me.SizeLimitTextBox)
        resources.ApplyResources(Me.SizeLimitGroupBox, "SizeLimitGroupBox")
        Me.SizeLimitGroupBox.Name = "SizeLimitGroupBox"
        Me.SizeLimitGroupBox.TabStop = False
        '
        'SizeLimitCheckBox
        '
        resources.ApplyResources(Me.SizeLimitCheckBox, "SizeLimitCheckBox")
        Me.SizeLimitCheckBox.Name = "SizeLimitCheckBox"
        Me.SizeLimitCheckBox.UseVisualStyleBackColor = True
        '
        'SizeLimitLabel
        '
        resources.ApplyResources(Me.SizeLimitLabel, "SizeLimitLabel")
        Me.SizeLimitLabel.Name = "SizeLimitLabel"
        '
        'SizeLimitTextBox
        '
        resources.ApplyResources(Me.SizeLimitTextBox, "SizeLimitTextBox")
        Me.SizeLimitTextBox.Name = "SizeLimitTextBox"
        '
        'NameGroupBox
        '
        Me.NameGroupBox.Controls.Add(Me.NameALabel)
        Me.NameGroupBox.Controls.Add(Me.ExtensionTextBox)
        Me.NameGroupBox.Controls.Add(Me.ExtensionLabel)
        Me.NameGroupBox.Controls.Add(Me.HeaderTextBox)
        Me.NameGroupBox.Controls.Add(Me.HeaderLabel)
        resources.ApplyResources(Me.NameGroupBox, "NameGroupBox")
        Me.NameGroupBox.Name = "NameGroupBox"
        Me.NameGroupBox.TabStop = False
        '
        'NameALabel
        '
        resources.ApplyResources(Me.NameALabel, "NameALabel")
        Me.NameALabel.ForeColor = System.Drawing.Color.Green
        Me.NameALabel.Name = "NameALabel"
        '
        'ExtensionTextBox
        '
        resources.ApplyResources(Me.ExtensionTextBox, "ExtensionTextBox")
        Me.ExtensionTextBox.Name = "ExtensionTextBox"
        '
        'ExtensionLabel
        '
        resources.ApplyResources(Me.ExtensionLabel, "ExtensionLabel")
        Me.ExtensionLabel.Name = "ExtensionLabel"
        '
        'HeaderTextBox
        '
        resources.ApplyResources(Me.HeaderTextBox, "HeaderTextBox")
        Me.HeaderTextBox.Name = "HeaderTextBox"
        '
        'HeaderLabel
        '
        resources.ApplyResources(Me.HeaderLabel, "HeaderLabel")
        Me.HeaderLabel.Name = "HeaderLabel"
        '
        'TargetContextMenuStrip
        '
        Me.TargetContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CD175MBToolStripMenuItem, Me.CD350MBToolStripMenuItem, Me.CD700MBToolStripMenuItem, Me.CDs1400MBToolStripMenuItem, Me.CDs2100MBToolStripMenuItem, Me.DVD896MBToolStripMenuItem, Me.DVD1120MBToolStripMenuItem, Me.DVD1492MBToolStripMenuItem, Me.DVD2240MBToolStripMenuItem, Me.DVDOrBD54480MBToolStripMenuItem, Me.DVD6720MBToolStripMenuItem, Me.DVDDLOrBD98145MBToolStripMenuItem, Me.BD23450MBToolStripMenuItem, Me.BDDL46900MBToolStripMenuItem})
        Me.TargetContextMenuStrip.Name = "TargetContextMenuStrip"
        resources.ApplyResources(Me.TargetContextMenuStrip, "TargetContextMenuStrip")
        '
        'CD175MBToolStripMenuItem
        '
        Me.CD175MBToolStripMenuItem.Name = "CD175MBToolStripMenuItem"
        resources.ApplyResources(Me.CD175MBToolStripMenuItem, "CD175MBToolStripMenuItem")
        '
        'CD350MBToolStripMenuItem
        '
        Me.CD350MBToolStripMenuItem.Name = "CD350MBToolStripMenuItem"
        resources.ApplyResources(Me.CD350MBToolStripMenuItem, "CD350MBToolStripMenuItem")
        '
        'CD700MBToolStripMenuItem
        '
        Me.CD700MBToolStripMenuItem.Name = "CD700MBToolStripMenuItem"
        resources.ApplyResources(Me.CD700MBToolStripMenuItem, "CD700MBToolStripMenuItem")
        '
        'CDs1400MBToolStripMenuItem
        '
        Me.CDs1400MBToolStripMenuItem.Name = "CDs1400MBToolStripMenuItem"
        resources.ApplyResources(Me.CDs1400MBToolStripMenuItem, "CDs1400MBToolStripMenuItem")
        '
        'CDs2100MBToolStripMenuItem
        '
        Me.CDs2100MBToolStripMenuItem.Name = "CDs2100MBToolStripMenuItem"
        resources.ApplyResources(Me.CDs2100MBToolStripMenuItem, "CDs2100MBToolStripMenuItem")
        '
        'DVD896MBToolStripMenuItem
        '
        Me.DVD896MBToolStripMenuItem.Name = "DVD896MBToolStripMenuItem"
        resources.ApplyResources(Me.DVD896MBToolStripMenuItem, "DVD896MBToolStripMenuItem")
        '
        'DVD1120MBToolStripMenuItem
        '
        Me.DVD1120MBToolStripMenuItem.Name = "DVD1120MBToolStripMenuItem"
        resources.ApplyResources(Me.DVD1120MBToolStripMenuItem, "DVD1120MBToolStripMenuItem")
        '
        'DVD1492MBToolStripMenuItem
        '
        Me.DVD1492MBToolStripMenuItem.Name = "DVD1492MBToolStripMenuItem"
        resources.ApplyResources(Me.DVD1492MBToolStripMenuItem, "DVD1492MBToolStripMenuItem")
        '
        'DVD2240MBToolStripMenuItem
        '
        Me.DVD2240MBToolStripMenuItem.Name = "DVD2240MBToolStripMenuItem"
        resources.ApplyResources(Me.DVD2240MBToolStripMenuItem, "DVD2240MBToolStripMenuItem")
        '
        'DVDOrBD54480MBToolStripMenuItem
        '
        Me.DVDOrBD54480MBToolStripMenuItem.Name = "DVDOrBD54480MBToolStripMenuItem"
        resources.ApplyResources(Me.DVDOrBD54480MBToolStripMenuItem, "DVDOrBD54480MBToolStripMenuItem")
        '
        'DVD6720MBToolStripMenuItem
        '
        Me.DVD6720MBToolStripMenuItem.Name = "DVD6720MBToolStripMenuItem"
        resources.ApplyResources(Me.DVD6720MBToolStripMenuItem, "DVD6720MBToolStripMenuItem")
        '
        'DVDDLOrBD98145MBToolStripMenuItem
        '
        Me.DVDDLOrBD98145MBToolStripMenuItem.Name = "DVDDLOrBD98145MBToolStripMenuItem"
        resources.ApplyResources(Me.DVDDLOrBD98145MBToolStripMenuItem, "DVDDLOrBD98145MBToolStripMenuItem")
        '
        'BD23450MBToolStripMenuItem
        '
        Me.BD23450MBToolStripMenuItem.Name = "BD23450MBToolStripMenuItem"
        resources.ApplyResources(Me.BD23450MBToolStripMenuItem, "BD23450MBToolStripMenuItem")
        '
        'BDDL46900MBToolStripMenuItem
        '
        Me.BDDL46900MBToolStripMenuItem.Name = "BDDL46900MBToolStripMenuItem"
        resources.ApplyResources(Me.BDDL46900MBToolStripMenuItem, "BDDL46900MBToolStripMenuItem")
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.FFDeinterlaceCheckBox)
        resources.ApplyResources(Me.GroupBox5, "GroupBox5")
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.TabStop = False
        '
        'FFDeinterlaceCheckBox
        '
        resources.ApplyResources(Me.FFDeinterlaceCheckBox, "FFDeinterlaceCheckBox")
        Me.FFDeinterlaceCheckBox.Name = "FFDeinterlaceCheckBox"
        Me.FFDeinterlaceCheckBox.UseVisualStyleBackColor = True
        '
        'EncSetFrm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.EncSetPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EncSetFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.EncSetPanel.ResumeLayout(False)
        Me.EncSetPanel.PerformLayout()
        Me.SettingTabControl.ResumeLayout(False)
        Me.VideoTabPage.ResumeLayout(False)
        Me.MP4OptsPanel.ResumeLayout(False)
        Me.MP4OptsPanel.PerformLayout()
        Me.KeyFrameGroupBox.ResumeLayout(False)
        Me.KeyFrameGroupBox.PerformLayout()
        Me.VideoGroupBox.ResumeLayout(False)
        Me.VideoGroupBox.PerformLayout()
        Me.AdvanOptsPanel.ResumeLayout(False)
        Me.AdvanOptsPanel.PerformLayout()
        Me.EasyPanel.ResumeLayout(False)
        CType(Me.QuantizerCQPNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantizerCQPTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QualityNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QualityTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantizerNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantizerTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FFFPSGroupBox.ResumeLayout(False)
        Me.FFFPSGroupBox.PerformLayout()
        Me.VFTabPage.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.ImagePPGroupBox.ResumeLayout(False)
        Me.ImagePPGroupBox.PerformLayout()
        CType(Me.LumaEffectSNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChromaEffectSNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChromaEffectSTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChromaMatrixVSNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChromaMatrixVSTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChromaMatrixHSNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChromaMatrixHSTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LumaEffectSTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LumaMatrixVSNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LumaMatrixVSTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LumaMatrixHSNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LumaMatrixHSTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.hqdn3dPanel.ResumeLayout(False)
        Me.hqdn3dAutGroupBox.ResumeLayout(False)
        Me.hqdn3dAutGroupBox.PerformLayout()
        CType(Me.hqdn3d_auto_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hqdn3dManGroupBox.ResumeLayout(False)
        Me.hqdn3dManGroupBox.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.gradfun_radiusNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gradfun_radiusTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gradfun_strengthNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gradfun_strengthTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ImageTabPage.ResumeLayout(False)
        Me.ImageGroupBox.ResumeLayout(False)
        Me.ImageGroupBox.PerformLayout()
        Me.FFTurnGroupBox.ResumeLayout(False)
        Me.FFTurnGroupBox.PerformLayout()
        Me.flipGroupBox.ResumeLayout(False)
        Me.flipGroupBox.PerformLayout()
        Me.AudioTabPage.ResumeLayout(False)
        Me.AudioGroupBox.ResumeLayout(False)
        Me.AAMRWBBitratePanel.ResumeLayout(False)
        Me.AAMRWBBitratePanel.PerformLayout()
        Me.LAMEMP3QPanel.ResumeLayout(False)
        Me.LAMEMP3QPanel.PerformLayout()
        CType(Me.LAMEMP3QTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LAMEMP3QNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SampleratePanel.ResumeLayout(False)
        Me.SampleratePanel.PerformLayout()
        Me.BitrateNPanel.ResumeLayout(False)
        Me.BitrateNPanel.PerformLayout()
        Me.AAMRBitratePanel.ResumeLayout(False)
        Me.AAMRBitratePanel.PerformLayout()
        Me.AbitratePanel.ResumeLayout(False)
        Me.AbitratePanel.PerformLayout()
        Me.AVorbisQPanel.ResumeLayout(False)
        Me.AVorbisQPanel.PerformLayout()
        CType(Me.VorbisQTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VorbisQNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NeroAACGroupBox.ResumeLayout(False)
        Me.NeroAACGroupBox.PerformLayout()
        CType(Me.NeroAACQTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NeroAACQNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NeroAACBitrateTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NeroAACBitrateNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FFAudGroupBox.ResumeLayout(False)
        Me.FFAudGroupBox.PerformLayout()
        CType(Me.AudioVolNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AudioVolTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ETCTabPage.ResumeLayout(False)
        Me.SizeEncGroupBox.ResumeLayout(False)
        Me.SizeEncGroupBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.FFmpegCommandGroupBox.ResumeLayout(False)
        Me.FFmpegCommandGroupBox.PerformLayout()
        Me.SizeLimitGroupBox.ResumeLayout(False)
        Me.SizeLimitGroupBox.PerformLayout()
        Me.NameGroupBox.ResumeLayout(False)
        Me.NameGroupBox.PerformLayout()
        Me.TargetContextMenuStrip.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EncSetPanel As System.Windows.Forms.Panel
    Friend WithEvents OutFComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SettingTabControl As System.Windows.Forms.TabControl
    Friend WithEvents VideoTabPage As System.Windows.Forms.TabPage
    Friend WithEvents ImageTabPage As System.Windows.Forms.TabPage
    Friend WithEvents DefBTN As System.Windows.Forms.Button
    Friend WithEvents VideoGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents VideoCodecComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents VCodecLabel As System.Windows.Forms.Label
    Friend WithEvents VideoModeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BitrateLabel As System.Windows.Forms.Label
    Friend WithEvents BitrateLabel2 As System.Windows.Forms.Label
    Friend WithEvents QuantizerNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents QuantizerTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents QuantizerLabel As System.Windows.Forms.Label
    Friend WithEvents BitrateComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents QualityNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents QualityTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents QualityLabel As System.Windows.Forms.Label
    Friend WithEvents FramerateLabel2 As System.Windows.Forms.Label
    Friend WithEvents FramerateComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FramerateLabel As System.Windows.Forms.Label
    Friend WithEvents KeyFrameGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents FramerateCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents QuantizerCQPNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents QuantizerCQPTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents QuantizerCQPLabel As System.Windows.Forms.Label
    Friend WithEvents AdvanOptsLabel As System.Windows.Forms.Label
    Friend WithEvents AdvanOptsButton As System.Windows.Forms.Button
    Friend WithEvents GOPSizeCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AdvanOptsCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents PSPMP4CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents MinGOPSizeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GOPSizeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MinGOPSizeLabel As System.Windows.Forms.Label
    Friend WithEvents GOPSizeLabel As System.Windows.Forms.Label
    Friend WithEvents OKBTN As System.Windows.Forms.Button
    Friend WithEvents CancelBTN As System.Windows.Forms.Button
    Friend WithEvents ImageGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ImageSizeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ImageSizeLabel As System.Windows.Forms.Label
    Friend WithEvents ImageSizeCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ImageSizeSLabel As System.Windows.Forms.Label
    Friend WithEvents ImageSizeHeightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ImageSizeWidthTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FFmpegResizeFilterComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FFmpegResizeFilterLabel As System.Windows.Forms.Label
    Friend WithEvents AspectComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents AspectComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AspectLabel As System.Windows.Forms.Label
    Friend WithEvents AspectSLabel As System.Windows.Forms.Label
    Friend WithEvents AspectHTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AspectWTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AudioTabPage As System.Windows.Forms.TabPage
    Friend WithEvents AudioGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents AudioCodecComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ACodecLabel As System.Windows.Forms.Label
    Friend WithEvents VorbisQLabel As System.Windows.Forms.Label
    Friend WithEvents AudioBitrateComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents AudioBitrateLabel As System.Windows.Forms.Label
    Friend WithEvents VorbisQNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents VorbisQTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents AbitratePanel As System.Windows.Forms.Panel
    Friend WithEvents AVorbisQPanel As System.Windows.Forms.Panel
    Friend WithEvents AAMRBitratePanel As System.Windows.Forms.Panel
    Friend WithEvents AMRBitrateComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AMRBitrateLabel As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents FFmpegChComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FFmpegChLabel As System.Windows.Forms.Label
    Friend WithEvents SamplerateComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SamplerateLabel As System.Windows.Forms.Label
    Friend WithEvents SamplerateLabel2 As System.Windows.Forms.Label
    Friend WithEvents AudioVolTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents AudioVolNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents AudioVolLabel As System.Windows.Forms.Label
    Friend WithEvents NeroAACGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents NeroAACProfileComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NeroAACProfileLabel As System.Windows.Forms.Label
    Friend WithEvents NeroAACSALabel As System.Windows.Forms.Label
    Friend WithEvents NeroAACABRRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents NeroAACBitrateTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents NeroAACBitrateNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents NeroAACBitrateLabel As System.Windows.Forms.Label
    Friend WithEvents NeroAACQTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents NeroAACQNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents NeroAACQLabel As System.Windows.Forms.Label
    Friend WithEvents NeroAACVBRRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents NeroAACCBRRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents AudioVolNLabel As System.Windows.Forms.Label
    Friend WithEvents AudioVolButton As System.Windows.Forms.Button
    Friend WithEvents BitrateNPanel As System.Windows.Forms.Panel
    Friend WithEvents AudioBitrateNLabel As System.Windows.Forms.Label
    Friend WithEvents ETCTabPage As System.Windows.Forms.TabPage
    Friend WithEvents NameGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents NameALabel As System.Windows.Forms.Label
    Friend WithEvents ExtensionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ExtensionLabel As System.Windows.Forms.Label
    Friend WithEvents HeaderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HeaderLabel As System.Windows.Forms.Label
    Friend WithEvents SizeLimitGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents SizeLimitCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SizeLimitLabel As System.Windows.Forms.Label
    Friend WithEvents SizeLimitTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DeinterlaceCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents FFmpegCommandGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents FFmpegCommandButton As System.Windows.Forms.Button
    Friend WithEvents FFmpegCommandTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ImagePPGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents LumaMatrixHSNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents LumaMatrixHSTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents LumaMatrixHSButton As System.Windows.Forms.Button
    Friend WithEvents ChromaEffectSNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents ChromaEffectSTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents ChromaEffectSButton As System.Windows.Forms.Button
    Friend WithEvents ChromaMatrixVSNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents ChromaMatrixVSTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents ChromaMatrixVSButton As System.Windows.Forms.Button
    Friend WithEvents ChromaMatrixHSNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents ChromaMatrixHSTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents ChromaMatrixHSButton As System.Windows.Forms.Button
    Friend WithEvents LumaEffectSNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents LumaEffectSTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents LumaEffectSButton As System.Windows.Forms.Button
    Friend WithEvents LumaMatrixVSNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents LumaMatrixVSTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents LumaMatrixVSButton As System.Windows.Forms.Button
    Friend WithEvents FFmpegImageUnsharpLabel As System.Windows.Forms.Label
    Friend WithEvents FFmpegImageUnsharpCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AdvanOptsPanel As System.Windows.Forms.Panel
    Friend WithEvents PresetButton As System.Windows.Forms.Button
    Friend WithEvents SamplerateCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SampleratePanel As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SubtitleRecordingCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents flipGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents hflipCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents vflipCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SizeEncGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents SizeEncGBLabel As System.Windows.Forms.Label
    Friend WithEvents SizeEncMBLabel As System.Windows.Forms.Label
    Friend WithEvents SizeEncTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SizeEncLabel As System.Windows.Forms.Label
    Friend WithEvents SizeEncCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SizeButton As System.Windows.Forms.Button
    Friend WithEvents TargetContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CD175MBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CD350MBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CD700MBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CDs1400MBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CDs2100MBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DVD896MBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DVD1120MBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DVD1492MBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DVD2240MBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DVDOrBD54480MBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DVD6720MBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DVDDLOrBD98145MBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BD23450MBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BDDL46900MBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LAMEMP3QPanel As System.Windows.Forms.Panel
    Friend WithEvents LAMEMP3QTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents LAMEMP3QNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents LAMEMP3QLabel As System.Windows.Forms.Label
    Friend WithEvents LAMEMP3QLabel2 As System.Windows.Forms.Label
    Friend WithEvents LAMEMP3QComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FFTurnGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents FFVerticallyCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents FFTurnCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents FFTurnRightRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents FFTurnLeftRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ParityLabel As System.Windows.Forms.Label
    Friend WithEvents DeinterlaceParityComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DeinterlaceModeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents VFTabPage As System.Windows.Forms.TabPage
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents hqdn3d_auto_NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents hqdn3dUseCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents hqdn3d_4TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents hqdn3d_3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents hqdn3d_2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents hqdn3dAutGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents hqdn3dAutomodeCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents hqdn3d_manual_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents hqdn3dManGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents hqdn3dPanel As System.Windows.Forms.Panel
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents gradfun_radiusNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents gradfun_radiusTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents gradfun_radiusButton As System.Windows.Forms.Button
    Friend WithEvents gradfun_strengthNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents gradfun_strengthTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents gradfun_strengthButton As System.Windows.Forms.Button
    Friend WithEvents gradfunCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents RemoveMeatadataCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents FFFPSDOCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents MP4OptsPanel As System.Windows.Forms.Panel
    Friend WithEvents OutFLabel As System.Windows.Forms.Label
    Friend WithEvents FFFPSGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents FFAudGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents AAMRWBBitratePanel As System.Windows.Forms.Panel
    Friend WithEvents AMRWBBitrateComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AMRWBBitrateLabel As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents EasyPanel As System.Windows.Forms.Panel
    Friend WithEvents EasyButton As System.Windows.Forms.Button
    Friend WithEvents EasyLabel As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents FFDeinterlaceCheckBox As System.Windows.Forms.CheckBox
End Class
