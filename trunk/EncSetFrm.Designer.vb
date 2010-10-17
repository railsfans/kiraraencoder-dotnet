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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EncSetFrm))
        Me.EncSetPanel = New System.Windows.Forms.Panel
        Me.OutFGroupBox = New System.Windows.Forms.GroupBox
        Me.OutFComboBox = New System.Windows.Forms.ComboBox
        Me.PresetButton = New System.Windows.Forms.Button
        Me.CancelBTN = New System.Windows.Forms.Button
        Me.OKBTN = New System.Windows.Forms.Button
        Me.DefBTN = New System.Windows.Forms.Button
        Me.SettingTabControl = New System.Windows.Forms.TabControl
        Me.VideoTabPage = New System.Windows.Forms.TabPage
        Me.MP4OptsGroupBox = New System.Windows.Forms.GroupBox
        Me.PSPMP4CheckBox = New System.Windows.Forms.CheckBox
        Me.KeyFrameGroupBox = New System.Windows.Forms.GroupBox
        Me.MinGOPSizeTextBox = New System.Windows.Forms.TextBox
        Me.GOPSizeTextBox = New System.Windows.Forms.TextBox
        Me.MinGOPSizeLabel = New System.Windows.Forms.Label
        Me.GOPSizeLabel = New System.Windows.Forms.Label
        Me.GOPSizeCheckBox = New System.Windows.Forms.CheckBox
        Me.VideoGroupBox = New System.Windows.Forms.GroupBox
        Me.AdvanOptsPanel = New System.Windows.Forms.Panel
        Me.AdvanOptsButton = New System.Windows.Forms.Button
        Me.AdvanOptsCheckBox = New System.Windows.Forms.CheckBox
        Me.AdvanOptsLabel = New System.Windows.Forms.Label
        Me.QuantizerCQPNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.QuantizerCQPTrackBar = New System.Windows.Forms.TrackBar
        Me.QuantizerCQPLabel = New System.Windows.Forms.Label
        Me.FramerateCheckBox = New System.Windows.Forms.CheckBox
        Me.FramerateLabel2 = New System.Windows.Forms.Label
        Me.FramerateComboBox = New System.Windows.Forms.ComboBox
        Me.FramerateLabel = New System.Windows.Forms.Label
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
        Me.ImageTabPage = New System.Windows.Forms.TabPage
        Me.ImageTabControl = New System.Windows.Forms.TabControl
        Me.ImgTabPage = New System.Windows.Forms.TabPage
        Me.ImageGroupBox = New System.Windows.Forms.GroupBox
        Me.DeinterlaceCheckBox = New System.Windows.Forms.CheckBox
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
        Me.ImgPPTabPage = New System.Windows.Forms.TabPage
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
        Me.AudioTabPage = New System.Windows.Forms.TabPage
        Me.AudioGroupBox = New System.Windows.Forms.GroupBox
        Me.SampleratePanel = New System.Windows.Forms.Panel
        Me.SamplerateCheckBox = New System.Windows.Forms.CheckBox
        Me.SamplerateLabel2 = New System.Windows.Forms.Label
        Me.SamplerateComboBox = New System.Windows.Forms.ComboBox
        Me.SamplerateLabel = New System.Windows.Forms.Label
        Me.BitrateNPanel = New System.Windows.Forms.Panel
        Me.AudioBitrateNLabel = New System.Windows.Forms.Label
        Me.AudioVolNLabel = New System.Windows.Forms.Label
        Me.AudioVolButton = New System.Windows.Forms.Button
        Me.AudioVolTrackBar = New System.Windows.Forms.TrackBar
        Me.AudioVolNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.AudioVolLabel = New System.Windows.Forms.Label
        Me.FFmpegChComboBox = New System.Windows.Forms.ComboBox
        Me.FFmpegChLabel = New System.Windows.Forms.Label
        Me.AAMRBitratePanel = New System.Windows.Forms.Panel
        Me.AMRBitrateComboBox = New System.Windows.Forms.ComboBox
        Me.AMRBitrateLabel = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.AbitratePanel = New System.Windows.Forms.Panel
        Me.AudioBitrateComboBox = New System.Windows.Forms.ComboBox
        Me.AudioBitrateLabel = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.AVorbisQPanel = New System.Windows.Forms.Panel
        Me.VorbisQTrackBar = New System.Windows.Forms.TrackBar
        Me.VorbisQNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.VorbisQLabel = New System.Windows.Forms.Label
        Me.AudioCodecComboBox = New System.Windows.Forms.ComboBox
        Me.ACodecLabel = New System.Windows.Forms.Label
        Me.NeroAACGroupBox = New System.Windows.Forms.GroupBox
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
        Me.ETCTabPage = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
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
        Me.hflipCheckBox = New System.Windows.Forms.CheckBox
        Me.vflipCheckBox = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.EncSetPanel.SuspendLayout()
        Me.OutFGroupBox.SuspendLayout()
        Me.SettingTabControl.SuspendLayout()
        Me.VideoTabPage.SuspendLayout()
        Me.MP4OptsGroupBox.SuspendLayout()
        Me.KeyFrameGroupBox.SuspendLayout()
        Me.VideoGroupBox.SuspendLayout()
        Me.AdvanOptsPanel.SuspendLayout()
        CType(Me.QuantizerCQPNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantizerCQPTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QualityNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QualityTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantizerNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantizerTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ImageTabPage.SuspendLayout()
        Me.ImageTabControl.SuspendLayout()
        Me.ImgTabPage.SuspendLayout()
        Me.ImageGroupBox.SuspendLayout()
        Me.ImgPPTabPage.SuspendLayout()
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
        Me.AudioTabPage.SuspendLayout()
        Me.AudioGroupBox.SuspendLayout()
        Me.SampleratePanel.SuspendLayout()
        Me.BitrateNPanel.SuspendLayout()
        CType(Me.AudioVolTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AudioVolNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ETCTabPage.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.FFmpegCommandGroupBox.SuspendLayout()
        Me.SizeLimitGroupBox.SuspendLayout()
        Me.NameGroupBox.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'EncSetPanel
        '
        Me.EncSetPanel.Controls.Add(Me.OutFGroupBox)
        Me.EncSetPanel.Controls.Add(Me.CancelBTN)
        Me.EncSetPanel.Controls.Add(Me.OKBTN)
        Me.EncSetPanel.Controls.Add(Me.DefBTN)
        Me.EncSetPanel.Controls.Add(Me.SettingTabControl)
        resources.ApplyResources(Me.EncSetPanel, "EncSetPanel")
        Me.EncSetPanel.Name = "EncSetPanel"
        '
        'OutFGroupBox
        '
        Me.OutFGroupBox.Controls.Add(Me.OutFComboBox)
        Me.OutFGroupBox.Controls.Add(Me.PresetButton)
        resources.ApplyResources(Me.OutFGroupBox, "OutFGroupBox")
        Me.OutFGroupBox.Name = "OutFGroupBox"
        Me.OutFGroupBox.TabStop = False
        '
        'OutFComboBox
        '
        Me.OutFComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.OutFComboBox.FormattingEnabled = True
        Me.OutFComboBox.Items.AddRange(New Object() {resources.GetString("OutFComboBox.Items"), resources.GetString("OutFComboBox.Items1"), resources.GetString("OutFComboBox.Items2"), resources.GetString("OutFComboBox.Items3"), resources.GetString("OutFComboBox.Items4"), resources.GetString("OutFComboBox.Items5"), resources.GetString("OutFComboBox.Items6"), resources.GetString("OutFComboBox.Items7"), resources.GetString("OutFComboBox.Items8"), resources.GetString("OutFComboBox.Items9"), resources.GetString("OutFComboBox.Items10"), resources.GetString("OutFComboBox.Items11"), resources.GetString("OutFComboBox.Items12")})
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
        Me.VideoTabPage.Controls.Add(Me.MP4OptsGroupBox)
        Me.VideoTabPage.Controls.Add(Me.KeyFrameGroupBox)
        Me.VideoTabPage.Controls.Add(Me.VideoGroupBox)
        resources.ApplyResources(Me.VideoTabPage, "VideoTabPage")
        Me.VideoTabPage.Name = "VideoTabPage"
        Me.VideoTabPage.UseVisualStyleBackColor = True
        '
        'MP4OptsGroupBox
        '
        Me.MP4OptsGroupBox.Controls.Add(Me.PSPMP4CheckBox)
        resources.ApplyResources(Me.MP4OptsGroupBox, "MP4OptsGroupBox")
        Me.MP4OptsGroupBox.Name = "MP4OptsGroupBox"
        Me.MP4OptsGroupBox.TabStop = False
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
        Me.VideoGroupBox.Controls.Add(Me.FramerateCheckBox)
        Me.VideoGroupBox.Controls.Add(Me.FramerateLabel2)
        Me.VideoGroupBox.Controls.Add(Me.FramerateComboBox)
        Me.VideoGroupBox.Controls.Add(Me.FramerateLabel)
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
        Me.AdvanOptsPanel.Controls.Add(Me.AdvanOptsButton)
        Me.AdvanOptsPanel.Controls.Add(Me.AdvanOptsCheckBox)
        Me.AdvanOptsPanel.Controls.Add(Me.AdvanOptsLabel)
        resources.ApplyResources(Me.AdvanOptsPanel, "AdvanOptsPanel")
        Me.AdvanOptsPanel.Name = "AdvanOptsPanel"
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
        Me.QuantizerCQPNumericUpDown.Maximum = New Decimal(New Integer() {51, 0, 0, 0})
        Me.QuantizerCQPNumericUpDown.Name = "QuantizerCQPNumericUpDown"
        '
        'QuantizerCQPTrackBar
        '
        resources.ApplyResources(Me.QuantizerCQPTrackBar, "QuantizerCQPTrackBar")
        Me.QuantizerCQPTrackBar.Maximum = 51
        Me.QuantizerCQPTrackBar.Name = "QuantizerCQPTrackBar"
        Me.QuantizerCQPTrackBar.TickFrequency = 0
        Me.QuantizerCQPTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'QuantizerCQPLabel
        '
        resources.ApplyResources(Me.QuantizerCQPLabel, "QuantizerCQPLabel")
        Me.QuantizerCQPLabel.Name = "QuantizerCQPLabel"
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
        'FramerateComboBox
        '
        Me.FramerateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FramerateComboBox.FormattingEnabled = True
        Me.FramerateComboBox.Items.AddRange(New Object() {resources.GetString("FramerateComboBox.Items"), resources.GetString("FramerateComboBox.Items1"), resources.GetString("FramerateComboBox.Items2"), resources.GetString("FramerateComboBox.Items3"), resources.GetString("FramerateComboBox.Items4"), resources.GetString("FramerateComboBox.Items5"), resources.GetString("FramerateComboBox.Items6"), resources.GetString("FramerateComboBox.Items7"), resources.GetString("FramerateComboBox.Items8"), resources.GetString("FramerateComboBox.Items9"), resources.GetString("FramerateComboBox.Items10"), resources.GetString("FramerateComboBox.Items11"), resources.GetString("FramerateComboBox.Items12"), resources.GetString("FramerateComboBox.Items13"), resources.GetString("FramerateComboBox.Items14"), resources.GetString("FramerateComboBox.Items15"), resources.GetString("FramerateComboBox.Items16"), resources.GetString("FramerateComboBox.Items17"), resources.GetString("FramerateComboBox.Items18"), resources.GetString("FramerateComboBox.Items19"), resources.GetString("FramerateComboBox.Items20"), resources.GetString("FramerateComboBox.Items21"), resources.GetString("FramerateComboBox.Items22")})
        resources.ApplyResources(Me.FramerateComboBox, "FramerateComboBox")
        Me.FramerateComboBox.Name = "FramerateComboBox"
        '
        'FramerateLabel
        '
        resources.ApplyResources(Me.FramerateLabel, "FramerateLabel")
        Me.FramerateLabel.Name = "FramerateLabel"
        '
        'QualityNumericUpDown
        '
        Me.QualityNumericUpDown.DecimalPlaces = 1
        Me.QualityNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        resources.ApplyResources(Me.QualityNumericUpDown, "QualityNumericUpDown")
        Me.QualityNumericUpDown.Maximum = New Decimal(New Integer() {51, 0, 0, 0})
        Me.QualityNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.QualityNumericUpDown.Name = "QualityNumericUpDown"
        Me.QualityNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 65536})
        '
        'QualityTrackBar
        '
        resources.ApplyResources(Me.QualityTrackBar, "QualityTrackBar")
        Me.QualityTrackBar.Maximum = 510
        Me.QualityTrackBar.Minimum = 1
        Me.QualityTrackBar.Name = "QualityTrackBar"
        Me.QualityTrackBar.TickFrequency = 0
        Me.QualityTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        Me.QualityTrackBar.Value = 10
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
        Me.BitrateComboBox.Items.AddRange(New Object() {resources.GetString("BitrateComboBox.Items"), resources.GetString("BitrateComboBox.Items1"), resources.GetString("BitrateComboBox.Items2"), resources.GetString("BitrateComboBox.Items3"), resources.GetString("BitrateComboBox.Items4"), resources.GetString("BitrateComboBox.Items5"), resources.GetString("BitrateComboBox.Items6"), resources.GetString("BitrateComboBox.Items7"), resources.GetString("BitrateComboBox.Items8"), resources.GetString("BitrateComboBox.Items9"), resources.GetString("BitrateComboBox.Items10"), resources.GetString("BitrateComboBox.Items11"), resources.GetString("BitrateComboBox.Items12")})
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
        'ImageTabPage
        '
        Me.ImageTabPage.BackColor = System.Drawing.Color.Transparent
        Me.ImageTabPage.Controls.Add(Me.ImageTabControl)
        resources.ApplyResources(Me.ImageTabPage, "ImageTabPage")
        Me.ImageTabPage.Name = "ImageTabPage"
        Me.ImageTabPage.UseVisualStyleBackColor = True
        '
        'ImageTabControl
        '
        Me.ImageTabControl.Controls.Add(Me.ImgTabPage)
        Me.ImageTabControl.Controls.Add(Me.ImgPPTabPage)
        resources.ApplyResources(Me.ImageTabControl, "ImageTabControl")
        Me.ImageTabControl.Name = "ImageTabControl"
        Me.ImageTabControl.SelectedIndex = 0
        '
        'ImgTabPage
        '
        Me.ImgTabPage.Controls.Add(Me.ImageGroupBox)
        resources.ApplyResources(Me.ImgTabPage, "ImgTabPage")
        Me.ImgTabPage.Name = "ImgTabPage"
        Me.ImgTabPage.UseVisualStyleBackColor = True
        '
        'ImageGroupBox
        '
        Me.ImageGroupBox.Controls.Add(Me.DeinterlaceCheckBox)
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
        'DeinterlaceCheckBox
        '
        resources.ApplyResources(Me.DeinterlaceCheckBox, "DeinterlaceCheckBox")
        Me.DeinterlaceCheckBox.Name = "DeinterlaceCheckBox"
        Me.DeinterlaceCheckBox.UseVisualStyleBackColor = True
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
        'ImgPPTabPage
        '
        Me.ImgPPTabPage.Controls.Add(Me.GroupBox2)
        Me.ImgPPTabPage.Controls.Add(Me.ImagePPGroupBox)
        resources.ApplyResources(Me.ImgPPTabPage, "ImgPPTabPage")
        Me.ImgPPTabPage.Name = "ImgPPTabPage"
        Me.ImgPPTabPage.UseVisualStyleBackColor = True
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
        Me.LumaEffectSNumericUpDown.DecimalPlaces = 1
        resources.ApplyResources(Me.LumaEffectSNumericUpDown, "LumaEffectSNumericUpDown")
        Me.LumaEffectSNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.LumaEffectSNumericUpDown.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.LumaEffectSNumericUpDown.Minimum = New Decimal(New Integer() {2, 0, 0, -2147483648})
        Me.LumaEffectSNumericUpDown.Name = "LumaEffectSNumericUpDown"
        Me.LumaEffectSNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ChromaEffectSNumericUpDown
        '
        Me.ChromaEffectSNumericUpDown.DecimalPlaces = 1
        resources.ApplyResources(Me.ChromaEffectSNumericUpDown, "ChromaEffectSNumericUpDown")
        Me.ChromaEffectSNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.ChromaEffectSNumericUpDown.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.ChromaEffectSNumericUpDown.Minimum = New Decimal(New Integer() {2, 0, 0, -2147483648})
        Me.ChromaEffectSNumericUpDown.Name = "ChromaEffectSNumericUpDown"
        Me.ChromaEffectSNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ChromaEffectSTrackBar
        '
        resources.ApplyResources(Me.ChromaEffectSTrackBar, "ChromaEffectSTrackBar")
        Me.ChromaEffectSTrackBar.Maximum = 50
        Me.ChromaEffectSTrackBar.Minimum = -20
        Me.ChromaEffectSTrackBar.Name = "ChromaEffectSTrackBar"
        Me.ChromaEffectSTrackBar.TickFrequency = 0
        Me.ChromaEffectSTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        Me.ChromaEffectSTrackBar.Value = 10
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
        Me.ChromaMatrixVSNumericUpDown.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.ChromaMatrixVSNumericUpDown.Name = "ChromaMatrixVSNumericUpDown"
        Me.ChromaMatrixVSNumericUpDown.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'ChromaMatrixVSTrackBar
        '
        resources.ApplyResources(Me.ChromaMatrixVSTrackBar, "ChromaMatrixVSTrackBar")
        Me.ChromaMatrixVSTrackBar.Maximum = 13
        Me.ChromaMatrixVSTrackBar.Minimum = 3
        Me.ChromaMatrixVSTrackBar.Name = "ChromaMatrixVSTrackBar"
        Me.ChromaMatrixVSTrackBar.TickFrequency = 0
        Me.ChromaMatrixVSTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        Me.ChromaMatrixVSTrackBar.Value = 5
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
        Me.ChromaMatrixHSNumericUpDown.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.ChromaMatrixHSNumericUpDown.Name = "ChromaMatrixHSNumericUpDown"
        Me.ChromaMatrixHSNumericUpDown.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'ChromaMatrixHSTrackBar
        '
        resources.ApplyResources(Me.ChromaMatrixHSTrackBar, "ChromaMatrixHSTrackBar")
        Me.ChromaMatrixHSTrackBar.Maximum = 13
        Me.ChromaMatrixHSTrackBar.Minimum = 3
        Me.ChromaMatrixHSTrackBar.Name = "ChromaMatrixHSTrackBar"
        Me.ChromaMatrixHSTrackBar.TickFrequency = 0
        Me.ChromaMatrixHSTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        Me.ChromaMatrixHSTrackBar.Value = 5
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
        Me.LumaEffectSTrackBar.Maximum = 50
        Me.LumaEffectSTrackBar.Minimum = -20
        Me.LumaEffectSTrackBar.Name = "LumaEffectSTrackBar"
        Me.LumaEffectSTrackBar.TickFrequency = 0
        Me.LumaEffectSTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        Me.LumaEffectSTrackBar.Value = 10
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
        'AudioTabPage
        '
        Me.AudioTabPage.BackColor = System.Drawing.Color.Transparent
        Me.AudioTabPage.Controls.Add(Me.AudioGroupBox)
        Me.AudioTabPage.Controls.Add(Me.NeroAACGroupBox)
        resources.ApplyResources(Me.AudioTabPage, "AudioTabPage")
        Me.AudioTabPage.Name = "AudioTabPage"
        Me.AudioTabPage.UseVisualStyleBackColor = True
        '
        'AudioGroupBox
        '
        Me.AudioGroupBox.Controls.Add(Me.SampleratePanel)
        Me.AudioGroupBox.Controls.Add(Me.BitrateNPanel)
        Me.AudioGroupBox.Controls.Add(Me.AudioVolNLabel)
        Me.AudioGroupBox.Controls.Add(Me.AudioVolButton)
        Me.AudioGroupBox.Controls.Add(Me.AudioVolTrackBar)
        Me.AudioGroupBox.Controls.Add(Me.AudioVolNumericUpDown)
        Me.AudioGroupBox.Controls.Add(Me.AudioVolLabel)
        Me.AudioGroupBox.Controls.Add(Me.FFmpegChComboBox)
        Me.AudioGroupBox.Controls.Add(Me.FFmpegChLabel)
        Me.AudioGroupBox.Controls.Add(Me.AAMRBitratePanel)
        Me.AudioGroupBox.Controls.Add(Me.AbitratePanel)
        Me.AudioGroupBox.Controls.Add(Me.AVorbisQPanel)
        Me.AudioGroupBox.Controls.Add(Me.AudioCodecComboBox)
        Me.AudioGroupBox.Controls.Add(Me.ACodecLabel)
        resources.ApplyResources(Me.AudioGroupBox, "AudioGroupBox")
        Me.AudioGroupBox.Name = "AudioGroupBox"
        Me.AudioGroupBox.TabStop = False
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
        'AudioVolNLabel
        '
        resources.ApplyResources(Me.AudioVolNLabel, "AudioVolNLabel")
        Me.AudioVolNLabel.ForeColor = System.Drawing.Color.Green
        Me.AudioVolNLabel.Name = "AudioVolNLabel"
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
        Me.AudioVolTrackBar.Maximum = 3840
        Me.AudioVolTrackBar.Name = "AudioVolTrackBar"
        Me.AudioVolTrackBar.TickFrequency = 0
        Me.AudioVolTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'AudioVolNumericUpDown
        '
        resources.ApplyResources(Me.AudioVolNumericUpDown, "AudioVolNumericUpDown")
        Me.AudioVolNumericUpDown.Maximum = New Decimal(New Integer() {3840, 0, 0, 0})
        Me.AudioVolNumericUpDown.Name = "AudioVolNumericUpDown"
        '
        'AudioVolLabel
        '
        resources.ApplyResources(Me.AudioVolLabel, "AudioVolLabel")
        Me.AudioVolLabel.Name = "AudioVolLabel"
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
        Me.AudioBitrateComboBox.Items.AddRange(New Object() {resources.GetString("AudioBitrateComboBox.Items"), resources.GetString("AudioBitrateComboBox.Items1"), resources.GetString("AudioBitrateComboBox.Items2"), resources.GetString("AudioBitrateComboBox.Items3"), resources.GetString("AudioBitrateComboBox.Items4"), resources.GetString("AudioBitrateComboBox.Items5"), resources.GetString("AudioBitrateComboBox.Items6"), resources.GetString("AudioBitrateComboBox.Items7"), resources.GetString("AudioBitrateComboBox.Items8"), resources.GetString("AudioBitrateComboBox.Items9"), resources.GetString("AudioBitrateComboBox.Items10"), resources.GetString("AudioBitrateComboBox.Items11"), resources.GetString("AudioBitrateComboBox.Items12"), resources.GetString("AudioBitrateComboBox.Items13"), resources.GetString("AudioBitrateComboBox.Items14"), resources.GetString("AudioBitrateComboBox.Items15"), resources.GetString("AudioBitrateComboBox.Items16"), resources.GetString("AudioBitrateComboBox.Items17")})
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
        Me.AVorbisQPanel.Controls.Add(Me.VorbisQTrackBar)
        Me.AVorbisQPanel.Controls.Add(Me.VorbisQNumericUpDown)
        Me.AVorbisQPanel.Controls.Add(Me.VorbisQLabel)
        resources.ApplyResources(Me.AVorbisQPanel, "AVorbisQPanel")
        Me.AVorbisQPanel.Name = "AVorbisQPanel"
        '
        'VorbisQTrackBar
        '
        resources.ApplyResources(Me.VorbisQTrackBar, "VorbisQTrackBar")
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
        'NeroAACQTrackBar
        '
        resources.ApplyResources(Me.NeroAACQTrackBar, "NeroAACQTrackBar")
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
        'ETCTabPage
        '
        Me.ETCTabPage.Controls.Add(Me.GroupBox1)
        Me.ETCTabPage.Controls.Add(Me.FFmpegCommandGroupBox)
        Me.ETCTabPage.Controls.Add(Me.SizeLimitGroupBox)
        Me.ETCTabPage.Controls.Add(Me.NameGroupBox)
        resources.ApplyResources(Me.ETCTabPage, "ETCTabPage")
        Me.ETCTabPage.Name = "ETCTabPage"
        Me.ETCTabPage.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SubtitleRecordingCheckBox)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.hflipCheckBox)
        Me.GroupBox2.Controls.Add(Me.vflipCheckBox)
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
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
        Me.OutFGroupBox.ResumeLayout(False)
        Me.SettingTabControl.ResumeLayout(False)
        Me.VideoTabPage.ResumeLayout(False)
        Me.MP4OptsGroupBox.ResumeLayout(False)
        Me.MP4OptsGroupBox.PerformLayout()
        Me.KeyFrameGroupBox.ResumeLayout(False)
        Me.KeyFrameGroupBox.PerformLayout()
        Me.VideoGroupBox.ResumeLayout(False)
        Me.VideoGroupBox.PerformLayout()
        Me.AdvanOptsPanel.ResumeLayout(False)
        Me.AdvanOptsPanel.PerformLayout()
        CType(Me.QuantizerCQPNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantizerCQPTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QualityNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QualityTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantizerNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantizerTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ImageTabPage.ResumeLayout(False)
        Me.ImageTabControl.ResumeLayout(False)
        Me.ImgTabPage.ResumeLayout(False)
        Me.ImageGroupBox.ResumeLayout(False)
        Me.ImageGroupBox.PerformLayout()
        Me.ImgPPTabPage.ResumeLayout(False)
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
        Me.AudioTabPage.ResumeLayout(False)
        Me.AudioGroupBox.ResumeLayout(False)
        Me.AudioGroupBox.PerformLayout()
        Me.SampleratePanel.ResumeLayout(False)
        Me.SampleratePanel.PerformLayout()
        Me.BitrateNPanel.ResumeLayout(False)
        Me.BitrateNPanel.PerformLayout()
        CType(Me.AudioVolTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AudioVolNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AAMRBitratePanel.ResumeLayout(False)
        Me.AAMRBitratePanel.PerformLayout()
        Me.AbitratePanel.ResumeLayout(False)
        Me.AbitratePanel.PerformLayout()
        Me.AVorbisQPanel.ResumeLayout(False)
        CType(Me.VorbisQTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VorbisQNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NeroAACGroupBox.ResumeLayout(False)
        Me.NeroAACGroupBox.PerformLayout()
        CType(Me.NeroAACQTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NeroAACQNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NeroAACBitrateTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NeroAACBitrateNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ETCTabPage.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.FFmpegCommandGroupBox.ResumeLayout(False)
        Me.FFmpegCommandGroupBox.PerformLayout()
        Me.SizeLimitGroupBox.ResumeLayout(False)
        Me.SizeLimitGroupBox.PerformLayout()
        Me.NameGroupBox.ResumeLayout(False)
        Me.NameGroupBox.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
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
    Friend WithEvents MP4OptsGroupBox As System.Windows.Forms.GroupBox
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
    Friend WithEvents OutFGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents PresetButton As System.Windows.Forms.Button
    Friend WithEvents ImageTabControl As System.Windows.Forms.TabControl
    Friend WithEvents ImgTabPage As System.Windows.Forms.TabPage
    Friend WithEvents ImgPPTabPage As System.Windows.Forms.TabPage
    Friend WithEvents SamplerateCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SampleratePanel As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SubtitleRecordingCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents hflipCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents vflipCheckBox As System.Windows.Forms.CheckBox
End Class
