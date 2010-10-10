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
        Me.SuspendLayout()
        '
        'EncSetPanel
        '
        Me.EncSetPanel.Controls.Add(Me.OutFGroupBox)
        Me.EncSetPanel.Controls.Add(Me.CancelBTN)
        Me.EncSetPanel.Controls.Add(Me.OKBTN)
        Me.EncSetPanel.Controls.Add(Me.DefBTN)
        Me.EncSetPanel.Controls.Add(Me.SettingTabControl)
        Me.EncSetPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EncSetPanel.Location = New System.Drawing.Point(0, 0)
        Me.EncSetPanel.Name = "EncSetPanel"
        Me.EncSetPanel.Size = New System.Drawing.Size(524, 605)
        Me.EncSetPanel.TabIndex = 0
        '
        'OutFGroupBox
        '
        Me.OutFGroupBox.Controls.Add(Me.OutFComboBox)
        Me.OutFGroupBox.Controls.Add(Me.PresetButton)
        Me.OutFGroupBox.Location = New System.Drawing.Point(9, 10)
        Me.OutFGroupBox.Name = "OutFGroupBox"
        Me.OutFGroupBox.Size = New System.Drawing.Size(503, 50)
        Me.OutFGroupBox.TabIndex = 11
        Me.OutFGroupBox.TabStop = False
        Me.OutFGroupBox.Text = "출력형식"
        '
        'OutFComboBox
        '
        Me.OutFComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.OutFComboBox.FormattingEnabled = True
        Me.OutFComboBox.Items.AddRange(New Object() {"[AVI] - Audio Video Interleave", "[3GP] - 3GPP(GSM)", "[3G2] - 3GPP2(CDMA)", "[MP4] - MPEG-4 Part 14", "[MOV] - QuickTime", "[MKV] - Matroska Video", "[ASF] - Advanced Systems Format ", "[WMV] - Windows Media Video", "[MPEG] - Moving Picture Experts Group", "[FLV] - Flash Video", "[SWF] - Shock Wave Flash", "[WEBM] - WebM", "[AUDIO] - Audio Only"})
        Me.OutFComboBox.Location = New System.Drawing.Point(13, 19)
        Me.OutFComboBox.Name = "OutFComboBox"
        Me.OutFComboBox.Size = New System.Drawing.Size(349, 20)
        Me.OutFComboBox.TabIndex = 1
        '
        'PresetButton
        '
        Me.PresetButton.Location = New System.Drawing.Point(372, 17)
        Me.PresetButton.Name = "PresetButton"
        Me.PresetButton.Size = New System.Drawing.Size(118, 25)
        Me.PresetButton.TabIndex = 6
        Me.PresetButton.Text = "프리셋"
        Me.PresetButton.UseVisualStyleBackColor = True
        '
        'CancelBTN
        '
        Me.CancelBTN.Location = New System.Drawing.Point(424, 569)
        Me.CancelBTN.Name = "CancelBTN"
        Me.CancelBTN.Size = New System.Drawing.Size(90, 25)
        Me.CancelBTN.TabIndex = 8
        Me.CancelBTN.Text = "취소"
        Me.CancelBTN.UseVisualStyleBackColor = True
        '
        'OKBTN
        '
        Me.OKBTN.Location = New System.Drawing.Point(328, 569)
        Me.OKBTN.Name = "OKBTN"
        Me.OKBTN.Size = New System.Drawing.Size(90, 25)
        Me.OKBTN.TabIndex = 9
        Me.OKBTN.Text = "확인"
        Me.OKBTN.UseVisualStyleBackColor = True
        '
        'DefBTN
        '
        Me.DefBTN.Location = New System.Drawing.Point(8, 569)
        Me.DefBTN.Name = "DefBTN"
        Me.DefBTN.Size = New System.Drawing.Size(90, 25)
        Me.DefBTN.TabIndex = 3
        Me.DefBTN.Text = "기본값"
        Me.DefBTN.UseVisualStyleBackColor = True
        '
        'SettingTabControl
        '
        Me.SettingTabControl.Controls.Add(Me.VideoTabPage)
        Me.SettingTabControl.Controls.Add(Me.ImageTabPage)
        Me.SettingTabControl.Controls.Add(Me.AudioTabPage)
        Me.SettingTabControl.Controls.Add(Me.ETCTabPage)
        Me.SettingTabControl.Location = New System.Drawing.Point(9, 66)
        Me.SettingTabControl.Name = "SettingTabControl"
        Me.SettingTabControl.SelectedIndex = 0
        Me.SettingTabControl.Size = New System.Drawing.Size(507, 497)
        Me.SettingTabControl.TabIndex = 0
        '
        'VideoTabPage
        '
        Me.VideoTabPage.BackColor = System.Drawing.Color.Transparent
        Me.VideoTabPage.Controls.Add(Me.MP4OptsGroupBox)
        Me.VideoTabPage.Controls.Add(Me.KeyFrameGroupBox)
        Me.VideoTabPage.Controls.Add(Me.VideoGroupBox)
        Me.VideoTabPage.Location = New System.Drawing.Point(4, 22)
        Me.VideoTabPage.Name = "VideoTabPage"
        Me.VideoTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.VideoTabPage.Size = New System.Drawing.Size(499, 471)
        Me.VideoTabPage.TabIndex = 0
        Me.VideoTabPage.Text = "비디오"
        Me.VideoTabPage.UseVisualStyleBackColor = True
        '
        'MP4OptsGroupBox
        '
        Me.MP4OptsGroupBox.Controls.Add(Me.PSPMP4CheckBox)
        Me.MP4OptsGroupBox.Location = New System.Drawing.Point(9, 408)
        Me.MP4OptsGroupBox.Name = "MP4OptsGroupBox"
        Me.MP4OptsGroupBox.Size = New System.Drawing.Size(480, 53)
        Me.MP4OptsGroupBox.TabIndex = 2
        Me.MP4OptsGroupBox.TabStop = False
        Me.MP4OptsGroupBox.Text = "MP4 옵션"
        '
        'PSPMP4CheckBox
        '
        Me.PSPMP4CheckBox.AutoSize = True
        Me.PSPMP4CheckBox.Location = New System.Drawing.Point(15, 21)
        Me.PSPMP4CheckBox.Name = "PSPMP4CheckBox"
        Me.PSPMP4CheckBox.Size = New System.Drawing.Size(257, 16)
        Me.PSPMP4CheckBox.TabIndex = 0
        Me.PSPMP4CheckBox.Text = "PSP에서 재생가능한 MP4파일을 만듭니다."
        Me.PSPMP4CheckBox.UseVisualStyleBackColor = True
        '
        'KeyFrameGroupBox
        '
        Me.KeyFrameGroupBox.Controls.Add(Me.MinGOPSizeTextBox)
        Me.KeyFrameGroupBox.Controls.Add(Me.GOPSizeTextBox)
        Me.KeyFrameGroupBox.Controls.Add(Me.MinGOPSizeLabel)
        Me.KeyFrameGroupBox.Controls.Add(Me.GOPSizeLabel)
        Me.KeyFrameGroupBox.Controls.Add(Me.GOPSizeCheckBox)
        Me.KeyFrameGroupBox.Location = New System.Drawing.Point(9, 297)
        Me.KeyFrameGroupBox.Name = "KeyFrameGroupBox"
        Me.KeyFrameGroupBox.Size = New System.Drawing.Size(480, 105)
        Me.KeyFrameGroupBox.TabIndex = 1
        Me.KeyFrameGroupBox.TabStop = False
        Me.KeyFrameGroupBox.Text = "키프레임"
        '
        'MinGOPSizeTextBox
        '
        Me.MinGOPSizeTextBox.Enabled = False
        Me.MinGOPSizeTextBox.Location = New System.Drawing.Point(263, 68)
        Me.MinGOPSizeTextBox.Name = "MinGOPSizeTextBox"
        Me.MinGOPSizeTextBox.Size = New System.Drawing.Size(89, 21)
        Me.MinGOPSizeTextBox.TabIndex = 4
        '
        'GOPSizeTextBox
        '
        Me.GOPSizeTextBox.Enabled = False
        Me.GOPSizeTextBox.Location = New System.Drawing.Point(263, 41)
        Me.GOPSizeTextBox.Name = "GOPSizeTextBox"
        Me.GOPSizeTextBox.Size = New System.Drawing.Size(89, 21)
        Me.GOPSizeTextBox.TabIndex = 3
        '
        'MinGOPSizeLabel
        '
        Me.MinGOPSizeLabel.Enabled = False
        Me.MinGOPSizeLabel.Location = New System.Drawing.Point(14, 73)
        Me.MinGOPSizeLabel.Name = "MinGOPSizeLabel"
        Me.MinGOPSizeLabel.Size = New System.Drawing.Size(243, 23)
        Me.MinGOPSizeLabel.TabIndex = 2
        Me.MinGOPSizeLabel.Text = "Min Keyframe Interval(Min GOP Size):"
        Me.MinGOPSizeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GOPSizeLabel
        '
        Me.GOPSizeLabel.Enabled = False
        Me.GOPSizeLabel.Location = New System.Drawing.Point(14, 46)
        Me.GOPSizeLabel.Name = "GOPSizeLabel"
        Me.GOPSizeLabel.Size = New System.Drawing.Size(243, 23)
        Me.GOPSizeLabel.TabIndex = 1
        Me.GOPSizeLabel.Text = "Keyframe Interval(GOP Size):"
        Me.GOPSizeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GOPSizeCheckBox
        '
        Me.GOPSizeCheckBox.AutoSize = True
        Me.GOPSizeCheckBox.Location = New System.Drawing.Point(15, 22)
        Me.GOPSizeCheckBox.Name = "GOPSizeCheckBox"
        Me.GOPSizeCheckBox.Size = New System.Drawing.Size(135, 16)
        Me.GOPSizeCheckBox.TabIndex = 0
        Me.GOPSizeCheckBox.Text = "GOP Size 설정 사용"
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
        Me.VideoGroupBox.Location = New System.Drawing.Point(9, 9)
        Me.VideoGroupBox.Name = "VideoGroupBox"
        Me.VideoGroupBox.Size = New System.Drawing.Size(480, 282)
        Me.VideoGroupBox.TabIndex = 0
        Me.VideoGroupBox.TabStop = False
        Me.VideoGroupBox.Text = "비디오"
        '
        'AdvanOptsPanel
        '
        Me.AdvanOptsPanel.Controls.Add(Me.AdvanOptsButton)
        Me.AdvanOptsPanel.Controls.Add(Me.AdvanOptsCheckBox)
        Me.AdvanOptsPanel.Controls.Add(Me.AdvanOptsLabel)
        Me.AdvanOptsPanel.Enabled = False
        Me.AdvanOptsPanel.Location = New System.Drawing.Point(8, 206)
        Me.AdvanOptsPanel.Name = "AdvanOptsPanel"
        Me.AdvanOptsPanel.Size = New System.Drawing.Size(465, 30)
        Me.AdvanOptsPanel.TabIndex = 25
        '
        'AdvanOptsButton
        '
        Me.AdvanOptsButton.Enabled = False
        Me.AdvanOptsButton.Location = New System.Drawing.Point(139, 2)
        Me.AdvanOptsButton.Name = "AdvanOptsButton"
        Me.AdvanOptsButton.Size = New System.Drawing.Size(125, 25)
        Me.AdvanOptsButton.TabIndex = 22
        Me.AdvanOptsButton.Text = "고급설정"
        Me.AdvanOptsButton.UseVisualStyleBackColor = True
        '
        'AdvanOptsCheckBox
        '
        Me.AdvanOptsCheckBox.AutoSize = True
        Me.AdvanOptsCheckBox.Location = New System.Drawing.Point(297, 6)
        Me.AdvanOptsCheckBox.Name = "AdvanOptsCheckBox"
        Me.AdvanOptsCheckBox.Size = New System.Drawing.Size(100, 16)
        Me.AdvanOptsCheckBox.TabIndex = 24
        Me.AdvanOptsCheckBox.Text = "고급설정 사용"
        Me.AdvanOptsCheckBox.UseVisualStyleBackColor = True
        '
        'AdvanOptsLabel
        '
        Me.AdvanOptsLabel.Enabled = False
        Me.AdvanOptsLabel.Location = New System.Drawing.Point(6, 8)
        Me.AdvanOptsLabel.Name = "AdvanOptsLabel"
        Me.AdvanOptsLabel.Size = New System.Drawing.Size(127, 16)
        Me.AdvanOptsLabel.TabIndex = 23
        Me.AdvanOptsLabel.Text = "고급설정:"
        Me.AdvanOptsLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'QuantizerCQPNumericUpDown
        '
        Me.QuantizerCQPNumericUpDown.Location = New System.Drawing.Point(401, 148)
        Me.QuantizerCQPNumericUpDown.Maximum = New Decimal(New Integer() {51, 0, 0, 0})
        Me.QuantizerCQPNumericUpDown.Name = "QuantizerCQPNumericUpDown"
        Me.QuantizerCQPNumericUpDown.Size = New System.Drawing.Size(53, 21)
        Me.QuantizerCQPNumericUpDown.TabIndex = 20
        '
        'QuantizerCQPTrackBar
        '
        Me.QuantizerCQPTrackBar.AutoSize = False
        Me.QuantizerCQPTrackBar.Location = New System.Drawing.Point(181, 146)
        Me.QuantizerCQPTrackBar.Maximum = 51
        Me.QuantizerCQPTrackBar.Name = "QuantizerCQPTrackBar"
        Me.QuantizerCQPTrackBar.Size = New System.Drawing.Size(205, 23)
        Me.QuantizerCQPTrackBar.TabIndex = 19
        Me.QuantizerCQPTrackBar.TickFrequency = 0
        Me.QuantizerCQPTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'QuantizerCQPLabel
        '
        Me.QuantizerCQPLabel.Location = New System.Drawing.Point(14, 151)
        Me.QuantizerCQPLabel.Name = "QuantizerCQPLabel"
        Me.QuantizerCQPLabel.Size = New System.Drawing.Size(157, 18)
        Me.QuantizerCQPLabel.TabIndex = 18
        Me.QuantizerCQPLabel.Text = "퀀타이저(CQP):"
        Me.QuantizerCQPLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FramerateCheckBox
        '
        Me.FramerateCheckBox.AutoSize = True
        Me.FramerateCheckBox.Location = New System.Drawing.Point(305, 247)
        Me.FramerateCheckBox.Name = "FramerateCheckBox"
        Me.FramerateCheckBox.Size = New System.Drawing.Size(124, 16)
        Me.FramerateCheckBox.TabIndex = 17
        Me.FramerateCheckBox.Text = "원본 프레임레이트"
        Me.FramerateCheckBox.UseVisualStyleBackColor = True
        '
        'FramerateLabel2
        '
        Me.FramerateLabel2.AutoSize = True
        Me.FramerateLabel2.Location = New System.Drawing.Point(243, 248)
        Me.FramerateLabel2.Name = "FramerateLabel2"
        Me.FramerateLabel2.Size = New System.Drawing.Size(22, 12)
        Me.FramerateLabel2.TabIndex = 16
        Me.FramerateLabel2.Text = "fps"
        '
        'FramerateComboBox
        '
        Me.FramerateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FramerateComboBox.FormattingEnabled = True
        Me.FramerateComboBox.Items.AddRange(New Object() {"5", "6", "7", "8", "9", "10", "11", "12", "13", "14.985", "15", "16", "17", "18", "19", "20", "23.976", "24", "25", "29.97", "30", "59.94", "60"})
        Me.FramerateComboBox.Location = New System.Drawing.Point(147, 244)
        Me.FramerateComboBox.Name = "FramerateComboBox"
        Me.FramerateComboBox.Size = New System.Drawing.Size(89, 20)
        Me.FramerateComboBox.TabIndex = 15
        '
        'FramerateLabel
        '
        Me.FramerateLabel.Location = New System.Drawing.Point(14, 249)
        Me.FramerateLabel.Name = "FramerateLabel"
        Me.FramerateLabel.Size = New System.Drawing.Size(127, 16)
        Me.FramerateLabel.TabIndex = 13
        Me.FramerateLabel.Text = "프레임레이트:"
        Me.FramerateLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'QualityNumericUpDown
        '
        Me.QualityNumericUpDown.DecimalPlaces = 1
        Me.QualityNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.QualityNumericUpDown.Location = New System.Drawing.Point(401, 177)
        Me.QualityNumericUpDown.Maximum = New Decimal(New Integer() {51, 0, 0, 0})
        Me.QualityNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.QualityNumericUpDown.Name = "QualityNumericUpDown"
        Me.QualityNumericUpDown.Size = New System.Drawing.Size(53, 21)
        Me.QualityNumericUpDown.TabIndex = 12
        Me.QualityNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 65536})
        '
        'QualityTrackBar
        '
        Me.QualityTrackBar.AutoSize = False
        Me.QualityTrackBar.Location = New System.Drawing.Point(181, 176)
        Me.QualityTrackBar.Maximum = 510
        Me.QualityTrackBar.Minimum = 1
        Me.QualityTrackBar.Name = "QualityTrackBar"
        Me.QualityTrackBar.Size = New System.Drawing.Size(205, 23)
        Me.QualityTrackBar.TabIndex = 11
        Me.QualityTrackBar.TickFrequency = 0
        Me.QualityTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        Me.QualityTrackBar.Value = 10
        '
        'QualityLabel
        '
        Me.QualityLabel.Location = New System.Drawing.Point(14, 181)
        Me.QualityLabel.Name = "QualityLabel"
        Me.QualityLabel.Size = New System.Drawing.Size(157, 18)
        Me.QualityLabel.TabIndex = 10
        Me.QualityLabel.Text = "퀄리티(CRF):"
        Me.QualityLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'QuantizerNumericUpDown
        '
        Me.QuantizerNumericUpDown.DecimalPlaces = 1
        Me.QuantizerNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.QuantizerNumericUpDown.Location = New System.Drawing.Point(401, 119)
        Me.QuantizerNumericUpDown.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.QuantizerNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.QuantizerNumericUpDown.Name = "QuantizerNumericUpDown"
        Me.QuantizerNumericUpDown.Size = New System.Drawing.Size(53, 21)
        Me.QuantizerNumericUpDown.TabIndex = 9
        Me.QuantizerNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'QuantizerTrackBar
        '
        Me.QuantizerTrackBar.AutoSize = False
        Me.QuantizerTrackBar.Location = New System.Drawing.Point(181, 116)
        Me.QuantizerTrackBar.Maximum = 310
        Me.QuantizerTrackBar.Minimum = 10
        Me.QuantizerTrackBar.Name = "QuantizerTrackBar"
        Me.QuantizerTrackBar.Size = New System.Drawing.Size(205, 23)
        Me.QuantizerTrackBar.TabIndex = 8
        Me.QuantizerTrackBar.TickFrequency = 0
        Me.QuantizerTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        Me.QuantizerTrackBar.Value = 10
        '
        'QuantizerLabel
        '
        Me.QuantizerLabel.Location = New System.Drawing.Point(14, 122)
        Me.QuantizerLabel.Name = "QuantizerLabel"
        Me.QuantizerLabel.Size = New System.Drawing.Size(157, 18)
        Me.QuantizerLabel.TabIndex = 7
        Me.QuantizerLabel.Text = "퀀타이저(VBR):"
        Me.QuantizerLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'BitrateComboBox
        '
        Me.BitrateComboBox.FormattingEnabled = True
        Me.BitrateComboBox.Items.AddRange(New Object() {"50", "100", "150", "200", "250", "300", "400", "500", "700", "1000", "2000", "5000", "10000"})
        Me.BitrateComboBox.Location = New System.Drawing.Point(181, 88)
        Me.BitrateComboBox.Name = "BitrateComboBox"
        Me.BitrateComboBox.Size = New System.Drawing.Size(205, 20)
        Me.BitrateComboBox.TabIndex = 6
        '
        'BitrateLabel2
        '
        Me.BitrateLabel2.AutoSize = True
        Me.BitrateLabel2.Location = New System.Drawing.Point(399, 92)
        Me.BitrateLabel2.Name = "BitrateLabel2"
        Me.BitrateLabel2.Size = New System.Drawing.Size(39, 12)
        Me.BitrateLabel2.TabIndex = 5
        Me.BitrateLabel2.Text = "Kbit/s"
        '
        'BitrateLabel
        '
        Me.BitrateLabel.Location = New System.Drawing.Point(16, 92)
        Me.BitrateLabel.Name = "BitrateLabel"
        Me.BitrateLabel.Size = New System.Drawing.Size(155, 17)
        Me.BitrateLabel.TabIndex = 3
        Me.BitrateLabel.Text = "비트레이트(CBR):"
        Me.BitrateLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'VideoModeComboBox
        '
        Me.VideoModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.VideoModeComboBox.FormattingEnabled = True
        Me.VideoModeComboBox.Location = New System.Drawing.Point(125, 51)
        Me.VideoModeComboBox.Name = "VideoModeComboBox"
        Me.VideoModeComboBox.Size = New System.Drawing.Size(330, 20)
        Me.VideoModeComboBox.TabIndex = 2
        '
        'VideoCodecComboBox
        '
        Me.VideoCodecComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.VideoCodecComboBox.FormattingEnabled = True
        Me.VideoCodecComboBox.Location = New System.Drawing.Point(125, 20)
        Me.VideoCodecComboBox.Name = "VideoCodecComboBox"
        Me.VideoCodecComboBox.Size = New System.Drawing.Size(330, 20)
        Me.VideoCodecComboBox.TabIndex = 1
        '
        'VCodecLabel
        '
        Me.VCodecLabel.Location = New System.Drawing.Point(14, 25)
        Me.VCodecLabel.Name = "VCodecLabel"
        Me.VCodecLabel.Size = New System.Drawing.Size(105, 42)
        Me.VCodecLabel.TabIndex = 0
        Me.VCodecLabel.Text = "압축코덱:"
        Me.VCodecLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ImageTabPage
        '
        Me.ImageTabPage.BackColor = System.Drawing.Color.Transparent
        Me.ImageTabPage.Controls.Add(Me.ImageTabControl)
        Me.ImageTabPage.Location = New System.Drawing.Point(4, 22)
        Me.ImageTabPage.Name = "ImageTabPage"
        Me.ImageTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.ImageTabPage.Size = New System.Drawing.Size(499, 471)
        Me.ImageTabPage.TabIndex = 1
        Me.ImageTabPage.Text = "영상"
        Me.ImageTabPage.UseVisualStyleBackColor = True
        '
        'ImageTabControl
        '
        Me.ImageTabControl.Controls.Add(Me.ImgTabPage)
        Me.ImageTabControl.Controls.Add(Me.ImgPPTabPage)
        Me.ImageTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ImageTabControl.Location = New System.Drawing.Point(3, 3)
        Me.ImageTabControl.Name = "ImageTabControl"
        Me.ImageTabControl.SelectedIndex = 0
        Me.ImageTabControl.Size = New System.Drawing.Size(493, 465)
        Me.ImageTabControl.TabIndex = 37
        '
        'ImgTabPage
        '
        Me.ImgTabPage.Controls.Add(Me.ImageGroupBox)
        Me.ImgTabPage.Location = New System.Drawing.Point(4, 22)
        Me.ImgTabPage.Name = "ImgTabPage"
        Me.ImgTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.ImgTabPage.Size = New System.Drawing.Size(485, 439)
        Me.ImgTabPage.TabIndex = 0
        Me.ImgTabPage.Text = "영상"
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
        Me.ImageGroupBox.Location = New System.Drawing.Point(8, 3)
        Me.ImageGroupBox.Name = "ImageGroupBox"
        Me.ImageGroupBox.Size = New System.Drawing.Size(468, 230)
        Me.ImageGroupBox.TabIndex = 0
        Me.ImageGroupBox.TabStop = False
        '
        'DeinterlaceCheckBox
        '
        Me.DeinterlaceCheckBox.AutoSize = True
        Me.DeinterlaceCheckBox.Location = New System.Drawing.Point(124, 200)
        Me.DeinterlaceCheckBox.Name = "DeinterlaceCheckBox"
        Me.DeinterlaceCheckBox.Size = New System.Drawing.Size(96, 16)
        Me.DeinterlaceCheckBox.TabIndex = 31
        Me.DeinterlaceCheckBox.Text = "디인터레이스"
        Me.DeinterlaceCheckBox.UseVisualStyleBackColor = True
        '
        'AspectSLabel
        '
        Me.AspectSLabel.AutoSize = True
        Me.AspectSLabel.Enabled = False
        Me.AspectSLabel.Location = New System.Drawing.Point(200, 172)
        Me.AspectSLabel.Name = "AspectSLabel"
        Me.AspectSLabel.Size = New System.Drawing.Size(9, 12)
        Me.AspectSLabel.TabIndex = 17
        Me.AspectSLabel.Text = ":"
        Me.AspectSLabel.Visible = False
        '
        'AspectHTextBox
        '
        Me.AspectHTextBox.Enabled = False
        Me.AspectHTextBox.Location = New System.Drawing.Point(217, 167)
        Me.AspectHTextBox.Name = "AspectHTextBox"
        Me.AspectHTextBox.Size = New System.Drawing.Size(68, 21)
        Me.AspectHTextBox.TabIndex = 16
        Me.AspectHTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.AspectHTextBox.Visible = False
        '
        'AspectWTextBox
        '
        Me.AspectWTextBox.Enabled = False
        Me.AspectWTextBox.Location = New System.Drawing.Point(124, 167)
        Me.AspectWTextBox.Name = "AspectWTextBox"
        Me.AspectWTextBox.Size = New System.Drawing.Size(68, 21)
        Me.AspectWTextBox.TabIndex = 15
        Me.AspectWTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.AspectWTextBox.Visible = False
        '
        'AspectComboBox2
        '
        Me.AspectComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AspectComboBox2.FormattingEnabled = True
        Me.AspectComboBox2.Location = New System.Drawing.Point(124, 141)
        Me.AspectComboBox2.Name = "AspectComboBox2"
        Me.AspectComboBox2.Size = New System.Drawing.Size(328, 20)
        Me.AspectComboBox2.TabIndex = 14
        Me.AspectComboBox2.Visible = False
        '
        'AspectComboBox
        '
        Me.AspectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AspectComboBox.FormattingEnabled = True
        Me.AspectComboBox.Location = New System.Drawing.Point(124, 115)
        Me.AspectComboBox.Name = "AspectComboBox"
        Me.AspectComboBox.Size = New System.Drawing.Size(328, 20)
        Me.AspectComboBox.TabIndex = 13
        '
        'AspectLabel
        '
        Me.AspectLabel.Location = New System.Drawing.Point(13, 118)
        Me.AspectLabel.Name = "AspectLabel"
        Me.AspectLabel.Size = New System.Drawing.Size(105, 27)
        Me.AspectLabel.TabIndex = 12
        Me.AspectLabel.Text = "비율:"
        Me.AspectLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FFmpegResizeFilterComboBox
        '
        Me.FFmpegResizeFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FFmpegResizeFilterComboBox.FormattingEnabled = True
        Me.FFmpegResizeFilterComboBox.Location = New System.Drawing.Point(124, 83)
        Me.FFmpegResizeFilterComboBox.Name = "FFmpegResizeFilterComboBox"
        Me.FFmpegResizeFilterComboBox.Size = New System.Drawing.Size(328, 20)
        Me.FFmpegResizeFilterComboBox.TabIndex = 11
        '
        'FFmpegResizeFilterLabel
        '
        Me.FFmpegResizeFilterLabel.Location = New System.Drawing.Point(13, 87)
        Me.FFmpegResizeFilterLabel.Name = "FFmpegResizeFilterLabel"
        Me.FFmpegResizeFilterLabel.Size = New System.Drawing.Size(105, 18)
        Me.FFmpegResizeFilterLabel.TabIndex = 10
        Me.FFmpegResizeFilterLabel.Text = "리사이즈 필터:"
        Me.FFmpegResizeFilterLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ImageSizeCheckBox
        '
        Me.ImageSizeCheckBox.AutoSize = True
        Me.ImageSizeCheckBox.Location = New System.Drawing.Point(309, 59)
        Me.ImageSizeCheckBox.Name = "ImageSizeCheckBox"
        Me.ImageSizeCheckBox.Size = New System.Drawing.Size(100, 16)
        Me.ImageSizeCheckBox.TabIndex = 6
        Me.ImageSizeCheckBox.Text = "원본 영상크기"
        Me.ImageSizeCheckBox.UseVisualStyleBackColor = True
        '
        'ImageSizeSLabel
        '
        Me.ImageSizeSLabel.AutoSize = True
        Me.ImageSizeSLabel.Enabled = False
        Me.ImageSizeSLabel.Location = New System.Drawing.Point(198, 61)
        Me.ImageSizeSLabel.Name = "ImageSizeSLabel"
        Me.ImageSizeSLabel.Size = New System.Drawing.Size(13, 12)
        Me.ImageSizeSLabel.TabIndex = 5
        Me.ImageSizeSLabel.Text = "X"
        '
        'ImageSizeHeightTextBox
        '
        Me.ImageSizeHeightTextBox.Enabled = False
        Me.ImageSizeHeightTextBox.Location = New System.Drawing.Point(217, 56)
        Me.ImageSizeHeightTextBox.Name = "ImageSizeHeightTextBox"
        Me.ImageSizeHeightTextBox.Size = New System.Drawing.Size(68, 21)
        Me.ImageSizeHeightTextBox.TabIndex = 4
        Me.ImageSizeHeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ImageSizeWidthTextBox
        '
        Me.ImageSizeWidthTextBox.Enabled = False
        Me.ImageSizeWidthTextBox.Location = New System.Drawing.Point(124, 56)
        Me.ImageSizeWidthTextBox.Name = "ImageSizeWidthTextBox"
        Me.ImageSizeWidthTextBox.Size = New System.Drawing.Size(68, 21)
        Me.ImageSizeWidthTextBox.TabIndex = 3
        Me.ImageSizeWidthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ImageSizeComboBox
        '
        Me.ImageSizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ImageSizeComboBox.FormattingEnabled = True
        Me.ImageSizeComboBox.Location = New System.Drawing.Point(124, 25)
        Me.ImageSizeComboBox.Name = "ImageSizeComboBox"
        Me.ImageSizeComboBox.Size = New System.Drawing.Size(328, 20)
        Me.ImageSizeComboBox.TabIndex = 2
        '
        'ImageSizeLabel
        '
        Me.ImageSizeLabel.Location = New System.Drawing.Point(15, 30)
        Me.ImageSizeLabel.Name = "ImageSizeLabel"
        Me.ImageSizeLabel.Size = New System.Drawing.Size(105, 42)
        Me.ImageSizeLabel.TabIndex = 1
        Me.ImageSizeLabel.Text = "영상크기:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(픽셀)"
        Me.ImageSizeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ImgPPTabPage
        '
        Me.ImgPPTabPage.Controls.Add(Me.ImagePPGroupBox)
        Me.ImgPPTabPage.Location = New System.Drawing.Point(4, 22)
        Me.ImgPPTabPage.Name = "ImgPPTabPage"
        Me.ImgPPTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.ImgPPTabPage.Size = New System.Drawing.Size(485, 439)
        Me.ImgPPTabPage.TabIndex = 1
        Me.ImgPPTabPage.Text = "영상 설정"
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
        Me.ImagePPGroupBox.Location = New System.Drawing.Point(8, 3)
        Me.ImagePPGroupBox.Name = "ImagePPGroupBox"
        Me.ImagePPGroupBox.Size = New System.Drawing.Size(468, 243)
        Me.ImagePPGroupBox.TabIndex = 20
        Me.ImagePPGroupBox.TabStop = False
        '
        'FFmpegImageUnsharpCheckBox
        '
        Me.FFmpegImageUnsharpCheckBox.AutoSize = True
        Me.FFmpegImageUnsharpCheckBox.Location = New System.Drawing.Point(391, 25)
        Me.FFmpegImageUnsharpCheckBox.Name = "FFmpegImageUnsharpCheckBox"
        Me.FFmpegImageUnsharpCheckBox.Size = New System.Drawing.Size(48, 16)
        Me.FFmpegImageUnsharpCheckBox.TabIndex = 25
        Me.FFmpegImageUnsharpCheckBox.Text = "사용"
        Me.FFmpegImageUnsharpCheckBox.UseVisualStyleBackColor = True
        '
        'FFmpegImageUnsharpLabel
        '
        Me.FFmpegImageUnsharpLabel.AutoSize = True
        Me.FFmpegImageUnsharpLabel.Enabled = False
        Me.FFmpegImageUnsharpLabel.ForeColor = System.Drawing.Color.Green
        Me.FFmpegImageUnsharpLabel.Location = New System.Drawing.Point(15, 22)
        Me.FFmpegImageUnsharpLabel.Name = "FFmpegImageUnsharpLabel"
        Me.FFmpegImageUnsharpLabel.Size = New System.Drawing.Size(306, 24)
        Me.FFmpegImageUnsharpLabel.TabIndex = 24
        Me.FFmpegImageUnsharpLabel.Text = "luma effect strength, chroma effect strength 두 설정이" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1 보다 크면 날카롭게, 1 보다 작으면 부드럽게"
        '
        'LumaEffectSNumericUpDown
        '
        Me.LumaEffectSNumericUpDown.DecimalPlaces = 1
        Me.LumaEffectSNumericUpDown.Enabled = False
        Me.LumaEffectSNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.LumaEffectSNumericUpDown.Location = New System.Drawing.Point(391, 114)
        Me.LumaEffectSNumericUpDown.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.LumaEffectSNumericUpDown.Minimum = New Decimal(New Integer() {2, 0, 0, -2147483648})
        Me.LumaEffectSNumericUpDown.Name = "LumaEffectSNumericUpDown"
        Me.LumaEffectSNumericUpDown.Size = New System.Drawing.Size(62, 21)
        Me.LumaEffectSNumericUpDown.TabIndex = 14
        Me.LumaEffectSNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ChromaEffectSNumericUpDown
        '
        Me.ChromaEffectSNumericUpDown.DecimalPlaces = 1
        Me.ChromaEffectSNumericUpDown.Enabled = False
        Me.ChromaEffectSNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.ChromaEffectSNumericUpDown.Location = New System.Drawing.Point(391, 201)
        Me.ChromaEffectSNumericUpDown.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.ChromaEffectSNumericUpDown.Minimum = New Decimal(New Integer() {2, 0, 0, -2147483648})
        Me.ChromaEffectSNumericUpDown.Name = "ChromaEffectSNumericUpDown"
        Me.ChromaEffectSNumericUpDown.Size = New System.Drawing.Size(62, 21)
        Me.ChromaEffectSNumericUpDown.TabIndex = 23
        Me.ChromaEffectSNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ChromaEffectSTrackBar
        '
        Me.ChromaEffectSTrackBar.AutoSize = False
        Me.ChromaEffectSTrackBar.Enabled = False
        Me.ChromaEffectSTrackBar.Location = New System.Drawing.Point(251, 203)
        Me.ChromaEffectSTrackBar.Maximum = 50
        Me.ChromaEffectSTrackBar.Minimum = -20
        Me.ChromaEffectSTrackBar.Name = "ChromaEffectSTrackBar"
        Me.ChromaEffectSTrackBar.Size = New System.Drawing.Size(134, 23)
        Me.ChromaEffectSTrackBar.TabIndex = 22
        Me.ChromaEffectSTrackBar.TickFrequency = 0
        Me.ChromaEffectSTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        Me.ChromaEffectSTrackBar.Value = 10
        '
        'ChromaEffectSButton
        '
        Me.ChromaEffectSButton.Enabled = False
        Me.ChromaEffectSButton.Location = New System.Drawing.Point(16, 203)
        Me.ChromaEffectSButton.Name = "ChromaEffectSButton"
        Me.ChromaEffectSButton.Size = New System.Drawing.Size(228, 23)
        Me.ChromaEffectSButton.TabIndex = 21
        Me.ChromaEffectSButton.Text = "chroma effect strength"
        Me.ChromaEffectSButton.UseVisualStyleBackColor = True
        '
        'ChromaMatrixVSNumericUpDown
        '
        Me.ChromaMatrixVSNumericUpDown.Enabled = False
        Me.ChromaMatrixVSNumericUpDown.Location = New System.Drawing.Point(391, 172)
        Me.ChromaMatrixVSNumericUpDown.Maximum = New Decimal(New Integer() {13, 0, 0, 0})
        Me.ChromaMatrixVSNumericUpDown.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.ChromaMatrixVSNumericUpDown.Name = "ChromaMatrixVSNumericUpDown"
        Me.ChromaMatrixVSNumericUpDown.Size = New System.Drawing.Size(62, 21)
        Me.ChromaMatrixVSNumericUpDown.TabIndex = 20
        Me.ChromaMatrixVSNumericUpDown.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'ChromaMatrixVSTrackBar
        '
        Me.ChromaMatrixVSTrackBar.AutoSize = False
        Me.ChromaMatrixVSTrackBar.Enabled = False
        Me.ChromaMatrixVSTrackBar.Location = New System.Drawing.Point(251, 174)
        Me.ChromaMatrixVSTrackBar.Maximum = 13
        Me.ChromaMatrixVSTrackBar.Minimum = 3
        Me.ChromaMatrixVSTrackBar.Name = "ChromaMatrixVSTrackBar"
        Me.ChromaMatrixVSTrackBar.Size = New System.Drawing.Size(134, 23)
        Me.ChromaMatrixVSTrackBar.TabIndex = 19
        Me.ChromaMatrixVSTrackBar.TickFrequency = 0
        Me.ChromaMatrixVSTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        Me.ChromaMatrixVSTrackBar.Value = 5
        '
        'ChromaMatrixVSButton
        '
        Me.ChromaMatrixVSButton.Enabled = False
        Me.ChromaMatrixVSButton.Location = New System.Drawing.Point(16, 174)
        Me.ChromaMatrixVSButton.Name = "ChromaMatrixVSButton"
        Me.ChromaMatrixVSButton.Size = New System.Drawing.Size(228, 23)
        Me.ChromaMatrixVSButton.TabIndex = 18
        Me.ChromaMatrixVSButton.Text = "chroma matrix vertical size"
        Me.ChromaMatrixVSButton.UseVisualStyleBackColor = True
        '
        'ChromaMatrixHSNumericUpDown
        '
        Me.ChromaMatrixHSNumericUpDown.Enabled = False
        Me.ChromaMatrixHSNumericUpDown.Location = New System.Drawing.Point(391, 143)
        Me.ChromaMatrixHSNumericUpDown.Maximum = New Decimal(New Integer() {13, 0, 0, 0})
        Me.ChromaMatrixHSNumericUpDown.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.ChromaMatrixHSNumericUpDown.Name = "ChromaMatrixHSNumericUpDown"
        Me.ChromaMatrixHSNumericUpDown.Size = New System.Drawing.Size(62, 21)
        Me.ChromaMatrixHSNumericUpDown.TabIndex = 17
        Me.ChromaMatrixHSNumericUpDown.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'ChromaMatrixHSTrackBar
        '
        Me.ChromaMatrixHSTrackBar.AutoSize = False
        Me.ChromaMatrixHSTrackBar.Enabled = False
        Me.ChromaMatrixHSTrackBar.Location = New System.Drawing.Point(251, 145)
        Me.ChromaMatrixHSTrackBar.Maximum = 13
        Me.ChromaMatrixHSTrackBar.Minimum = 3
        Me.ChromaMatrixHSTrackBar.Name = "ChromaMatrixHSTrackBar"
        Me.ChromaMatrixHSTrackBar.Size = New System.Drawing.Size(134, 23)
        Me.ChromaMatrixHSTrackBar.TabIndex = 16
        Me.ChromaMatrixHSTrackBar.TickFrequency = 0
        Me.ChromaMatrixHSTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        Me.ChromaMatrixHSTrackBar.Value = 5
        '
        'ChromaMatrixHSButton
        '
        Me.ChromaMatrixHSButton.Enabled = False
        Me.ChromaMatrixHSButton.Location = New System.Drawing.Point(16, 145)
        Me.ChromaMatrixHSButton.Name = "ChromaMatrixHSButton"
        Me.ChromaMatrixHSButton.Size = New System.Drawing.Size(228, 23)
        Me.ChromaMatrixHSButton.TabIndex = 15
        Me.ChromaMatrixHSButton.Text = "chroma matrix horizontal size"
        Me.ChromaMatrixHSButton.UseVisualStyleBackColor = True
        '
        'LumaEffectSTrackBar
        '
        Me.LumaEffectSTrackBar.AutoSize = False
        Me.LumaEffectSTrackBar.Enabled = False
        Me.LumaEffectSTrackBar.Location = New System.Drawing.Point(251, 116)
        Me.LumaEffectSTrackBar.Maximum = 50
        Me.LumaEffectSTrackBar.Minimum = -20
        Me.LumaEffectSTrackBar.Name = "LumaEffectSTrackBar"
        Me.LumaEffectSTrackBar.Size = New System.Drawing.Size(134, 23)
        Me.LumaEffectSTrackBar.TabIndex = 13
        Me.LumaEffectSTrackBar.TickFrequency = 0
        Me.LumaEffectSTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        Me.LumaEffectSTrackBar.Value = 10
        '
        'LumaEffectSButton
        '
        Me.LumaEffectSButton.Enabled = False
        Me.LumaEffectSButton.Location = New System.Drawing.Point(16, 116)
        Me.LumaEffectSButton.Name = "LumaEffectSButton"
        Me.LumaEffectSButton.Size = New System.Drawing.Size(228, 23)
        Me.LumaEffectSButton.TabIndex = 12
        Me.LumaEffectSButton.Text = "luma effect strength"
        Me.LumaEffectSButton.UseVisualStyleBackColor = True
        '
        'LumaMatrixVSNumericUpDown
        '
        Me.LumaMatrixVSNumericUpDown.Enabled = False
        Me.LumaMatrixVSNumericUpDown.Location = New System.Drawing.Point(391, 85)
        Me.LumaMatrixVSNumericUpDown.Maximum = New Decimal(New Integer() {13, 0, 0, 0})
        Me.LumaMatrixVSNumericUpDown.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.LumaMatrixVSNumericUpDown.Name = "LumaMatrixVSNumericUpDown"
        Me.LumaMatrixVSNumericUpDown.Size = New System.Drawing.Size(62, 21)
        Me.LumaMatrixVSNumericUpDown.TabIndex = 11
        Me.LumaMatrixVSNumericUpDown.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'LumaMatrixVSTrackBar
        '
        Me.LumaMatrixVSTrackBar.AutoSize = False
        Me.LumaMatrixVSTrackBar.Enabled = False
        Me.LumaMatrixVSTrackBar.Location = New System.Drawing.Point(251, 87)
        Me.LumaMatrixVSTrackBar.Maximum = 13
        Me.LumaMatrixVSTrackBar.Minimum = 3
        Me.LumaMatrixVSTrackBar.Name = "LumaMatrixVSTrackBar"
        Me.LumaMatrixVSTrackBar.Size = New System.Drawing.Size(134, 23)
        Me.LumaMatrixVSTrackBar.TabIndex = 10
        Me.LumaMatrixVSTrackBar.TickFrequency = 0
        Me.LumaMatrixVSTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        Me.LumaMatrixVSTrackBar.Value = 5
        '
        'LumaMatrixVSButton
        '
        Me.LumaMatrixVSButton.Enabled = False
        Me.LumaMatrixVSButton.Location = New System.Drawing.Point(16, 87)
        Me.LumaMatrixVSButton.Name = "LumaMatrixVSButton"
        Me.LumaMatrixVSButton.Size = New System.Drawing.Size(228, 23)
        Me.LumaMatrixVSButton.TabIndex = 9
        Me.LumaMatrixVSButton.Text = "luma matrix vertical size"
        Me.LumaMatrixVSButton.UseVisualStyleBackColor = True
        '
        'LumaMatrixHSNumericUpDown
        '
        Me.LumaMatrixHSNumericUpDown.Enabled = False
        Me.LumaMatrixHSNumericUpDown.Location = New System.Drawing.Point(391, 56)
        Me.LumaMatrixHSNumericUpDown.Maximum = New Decimal(New Integer() {13, 0, 0, 0})
        Me.LumaMatrixHSNumericUpDown.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.LumaMatrixHSNumericUpDown.Name = "LumaMatrixHSNumericUpDown"
        Me.LumaMatrixHSNumericUpDown.Size = New System.Drawing.Size(62, 21)
        Me.LumaMatrixHSNumericUpDown.TabIndex = 8
        Me.LumaMatrixHSNumericUpDown.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'LumaMatrixHSTrackBar
        '
        Me.LumaMatrixHSTrackBar.AutoSize = False
        Me.LumaMatrixHSTrackBar.Enabled = False
        Me.LumaMatrixHSTrackBar.Location = New System.Drawing.Point(251, 58)
        Me.LumaMatrixHSTrackBar.Maximum = 13
        Me.LumaMatrixHSTrackBar.Minimum = 3
        Me.LumaMatrixHSTrackBar.Name = "LumaMatrixHSTrackBar"
        Me.LumaMatrixHSTrackBar.Size = New System.Drawing.Size(134, 23)
        Me.LumaMatrixHSTrackBar.TabIndex = 7
        Me.LumaMatrixHSTrackBar.TickFrequency = 0
        Me.LumaMatrixHSTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        Me.LumaMatrixHSTrackBar.Value = 5
        '
        'LumaMatrixHSButton
        '
        Me.LumaMatrixHSButton.Enabled = False
        Me.LumaMatrixHSButton.Location = New System.Drawing.Point(16, 58)
        Me.LumaMatrixHSButton.Name = "LumaMatrixHSButton"
        Me.LumaMatrixHSButton.Size = New System.Drawing.Size(228, 23)
        Me.LumaMatrixHSButton.TabIndex = 6
        Me.LumaMatrixHSButton.Text = "luma matrix horizontal size"
        Me.LumaMatrixHSButton.UseVisualStyleBackColor = True
        '
        'AudioTabPage
        '
        Me.AudioTabPage.BackColor = System.Drawing.Color.Transparent
        Me.AudioTabPage.Controls.Add(Me.AudioGroupBox)
        Me.AudioTabPage.Controls.Add(Me.NeroAACGroupBox)
        Me.AudioTabPage.Location = New System.Drawing.Point(4, 22)
        Me.AudioTabPage.Name = "AudioTabPage"
        Me.AudioTabPage.Size = New System.Drawing.Size(499, 471)
        Me.AudioTabPage.TabIndex = 3
        Me.AudioTabPage.Text = "오디오"
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
        Me.AudioGroupBox.Location = New System.Drawing.Point(9, 9)
        Me.AudioGroupBox.Name = "AudioGroupBox"
        Me.AudioGroupBox.Size = New System.Drawing.Size(480, 206)
        Me.AudioGroupBox.TabIndex = 0
        Me.AudioGroupBox.TabStop = False
        Me.AudioGroupBox.Text = "오디오"
        '
        'SampleratePanel
        '
        Me.SampleratePanel.Controls.Add(Me.SamplerateCheckBox)
        Me.SampleratePanel.Controls.Add(Me.SamplerateLabel2)
        Me.SampleratePanel.Controls.Add(Me.SamplerateComboBox)
        Me.SampleratePanel.Controls.Add(Me.SamplerateLabel)
        Me.SampleratePanel.Location = New System.Drawing.Point(15, 80)
        Me.SampleratePanel.Name = "SampleratePanel"
        Me.SampleratePanel.Size = New System.Drawing.Size(445, 31)
        Me.SampleratePanel.TabIndex = 30
        '
        'SamplerateCheckBox
        '
        Me.SamplerateCheckBox.AutoSize = True
        Me.SamplerateCheckBox.Location = New System.Drawing.Point(263, 6)
        Me.SamplerateCheckBox.Name = "SamplerateCheckBox"
        Me.SamplerateCheckBox.Size = New System.Drawing.Size(112, 16)
        Me.SamplerateCheckBox.TabIndex = 29
        Me.SamplerateCheckBox.Text = "원본 샘플레이트"
        Me.SamplerateCheckBox.UseVisualStyleBackColor = True
        '
        'SamplerateLabel2
        '
        Me.SamplerateLabel2.AutoSize = True
        Me.SamplerateLabel2.Location = New System.Drawing.Point(214, 7)
        Me.SamplerateLabel2.Name = "SamplerateLabel2"
        Me.SamplerateLabel2.Size = New System.Drawing.Size(20, 12)
        Me.SamplerateLabel2.TabIndex = 21
        Me.SamplerateLabel2.Text = "Hz"
        '
        'SamplerateComboBox
        '
        Me.SamplerateComboBox.FormattingEnabled = True
        Me.SamplerateComboBox.Items.AddRange(New Object() {"8000", "11025", "12000", "16000", "22050", "24000", "32000", "44100", "48000", "96000", "128000", "192000"})
        Me.SamplerateComboBox.Location = New System.Drawing.Point(109, 4)
        Me.SamplerateComboBox.Name = "SamplerateComboBox"
        Me.SamplerateComboBox.Size = New System.Drawing.Size(96, 20)
        Me.SamplerateComboBox.TabIndex = 22
        '
        'SamplerateLabel
        '
        Me.SamplerateLabel.Location = New System.Drawing.Point(3, 7)
        Me.SamplerateLabel.Name = "SamplerateLabel"
        Me.SamplerateLabel.Size = New System.Drawing.Size(100, 17)
        Me.SamplerateLabel.TabIndex = 20
        Me.SamplerateLabel.Text = "샘플레이트:"
        Me.SamplerateLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'BitrateNPanel
        '
        Me.BitrateNPanel.Controls.Add(Me.AudioBitrateNLabel)
        Me.BitrateNPanel.Location = New System.Drawing.Point(16, 323)
        Me.BitrateNPanel.Name = "BitrateNPanel"
        Me.BitrateNPanel.Size = New System.Drawing.Size(445, 35)
        Me.BitrateNPanel.TabIndex = 28
        '
        'AudioBitrateNLabel
        '
        Me.AudioBitrateNLabel.AutoSize = True
        Me.AudioBitrateNLabel.ForeColor = System.Drawing.Color.Green
        Me.AudioBitrateNLabel.Location = New System.Drawing.Point(5, 12)
        Me.AudioBitrateNLabel.Name = "AudioBitrateNLabel"
        Me.AudioBitrateNLabel.Size = New System.Drawing.Size(11, 12)
        Me.AudioBitrateNLabel.TabIndex = 28
        Me.AudioBitrateNLabel.Text = "-"
        '
        'AudioVolNLabel
        '
        Me.AudioVolNLabel.AutoSize = True
        Me.AudioVolNLabel.ForeColor = System.Drawing.Color.Green
        Me.AudioVolNLabel.Location = New System.Drawing.Point(21, 176)
        Me.AudioVolNLabel.Name = "AudioVolNLabel"
        Me.AudioVolNLabel.Size = New System.Drawing.Size(233, 12)
        Me.AudioVolNLabel.TabIndex = 27
        Me.AudioVolNLabel.Text = "256=기본값, 512=볼륨 2배, 2560=볼륨 10배"
        '
        'AudioVolButton
        '
        Me.AudioVolButton.Location = New System.Drawing.Point(382, 145)
        Me.AudioVolButton.Name = "AudioVolButton"
        Me.AudioVolButton.Size = New System.Drawing.Size(73, 23)
        Me.AudioVolButton.TabIndex = 26
        Me.AudioVolButton.Text = "기본값"
        Me.AudioVolButton.UseVisualStyleBackColor = True
        '
        'AudioVolTrackBar
        '
        Me.AudioVolTrackBar.AutoSize = False
        Me.AudioVolTrackBar.Location = New System.Drawing.Point(123, 145)
        Me.AudioVolTrackBar.Maximum = 3840
        Me.AudioVolTrackBar.Name = "AudioVolTrackBar"
        Me.AudioVolTrackBar.Size = New System.Drawing.Size(173, 23)
        Me.AudioVolTrackBar.TabIndex = 24
        Me.AudioVolTrackBar.TickFrequency = 0
        Me.AudioVolTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'AudioVolNumericUpDown
        '
        Me.AudioVolNumericUpDown.Location = New System.Drawing.Point(302, 146)
        Me.AudioVolNumericUpDown.Maximum = New Decimal(New Integer() {3840, 0, 0, 0})
        Me.AudioVolNumericUpDown.Name = "AudioVolNumericUpDown"
        Me.AudioVolNumericUpDown.Size = New System.Drawing.Size(66, 21)
        Me.AudioVolNumericUpDown.TabIndex = 25
        '
        'AudioVolLabel
        '
        Me.AudioVolLabel.Location = New System.Drawing.Point(19, 151)
        Me.AudioVolLabel.Name = "AudioVolLabel"
        Me.AudioVolLabel.Size = New System.Drawing.Size(100, 17)
        Me.AudioVolLabel.TabIndex = 23
        Me.AudioVolLabel.Text = "볼륨:"
        Me.AudioVolLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FFmpegChComboBox
        '
        Me.FFmpegChComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FFmpegChComboBox.FormattingEnabled = True
        Me.FFmpegChComboBox.Location = New System.Drawing.Point(123, 115)
        Me.FFmpegChComboBox.Name = "FFmpegChComboBox"
        Me.FFmpegChComboBox.Size = New System.Drawing.Size(331, 20)
        Me.FFmpegChComboBox.TabIndex = 19
        '
        'FFmpegChLabel
        '
        Me.FFmpegChLabel.Location = New System.Drawing.Point(18, 118)
        Me.FFmpegChLabel.Name = "FFmpegChLabel"
        Me.FFmpegChLabel.Size = New System.Drawing.Size(100, 17)
        Me.FFmpegChLabel.TabIndex = 18
        Me.FFmpegChLabel.Text = "채널:"
        Me.FFmpegChLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'AAMRBitratePanel
        '
        Me.AAMRBitratePanel.Controls.Add(Me.AMRBitrateComboBox)
        Me.AAMRBitratePanel.Controls.Add(Me.AMRBitrateLabel)
        Me.AAMRBitratePanel.Controls.Add(Me.Label10)
        Me.AAMRBitratePanel.Location = New System.Drawing.Point(16, 278)
        Me.AAMRBitratePanel.Name = "AAMRBitratePanel"
        Me.AAMRBitratePanel.Size = New System.Drawing.Size(445, 35)
        Me.AAMRBitratePanel.TabIndex = 17
        '
        'AMRBitrateComboBox
        '
        Me.AMRBitrateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AMRBitrateComboBox.FormattingEnabled = True
        Me.AMRBitrateComboBox.Items.AddRange(New Object() {"4.75", "5.15", "5.9", "6.7", "7.4", "7.95", "10.2", "12.2"})
        Me.AMRBitrateComboBox.Location = New System.Drawing.Point(109, 7)
        Me.AMRBitrateComboBox.Name = "AMRBitrateComboBox"
        Me.AMRBitrateComboBox.Size = New System.Drawing.Size(94, 20)
        Me.AMRBitrateComboBox.TabIndex = 9
        '
        'AMRBitrateLabel
        '
        Me.AMRBitrateLabel.Location = New System.Drawing.Point(4, 12)
        Me.AMRBitrateLabel.Name = "AMRBitrateLabel"
        Me.AMRBitrateLabel.Size = New System.Drawing.Size(100, 17)
        Me.AMRBitrateLabel.TabIndex = 7
        Me.AMRBitrateLabel.Text = "비트레이트:"
        Me.AMRBitrateLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(213, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 12)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Kbit/s"
        '
        'AbitratePanel
        '
        Me.AbitratePanel.Controls.Add(Me.AudioBitrateComboBox)
        Me.AbitratePanel.Controls.Add(Me.AudioBitrateLabel)
        Me.AbitratePanel.Controls.Add(Me.Label3)
        Me.AbitratePanel.Location = New System.Drawing.Point(15, 46)
        Me.AbitratePanel.Name = "AbitratePanel"
        Me.AbitratePanel.Size = New System.Drawing.Size(445, 35)
        Me.AbitratePanel.TabIndex = 16
        '
        'AudioBitrateComboBox
        '
        Me.AudioBitrateComboBox.FormattingEnabled = True
        Me.AudioBitrateComboBox.Items.AddRange(New Object() {"32", "40", "48", "56", "64", "80", "96", "112", "128", "160", "192", "224", "256", "320", "384", "448", "512", "640"})
        Me.AudioBitrateComboBox.Location = New System.Drawing.Point(109, 7)
        Me.AudioBitrateComboBox.Name = "AudioBitrateComboBox"
        Me.AudioBitrateComboBox.Size = New System.Drawing.Size(144, 20)
        Me.AudioBitrateComboBox.TabIndex = 9
        '
        'AudioBitrateLabel
        '
        Me.AudioBitrateLabel.Location = New System.Drawing.Point(4, 12)
        Me.AudioBitrateLabel.Name = "AudioBitrateLabel"
        Me.AudioBitrateLabel.Size = New System.Drawing.Size(100, 17)
        Me.AudioBitrateLabel.TabIndex = 7
        Me.AudioBitrateLabel.Text = "비트레이트:"
        Me.AudioBitrateLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(261, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 12)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Kbit/s"
        '
        'AVorbisQPanel
        '
        Me.AVorbisQPanel.Controls.Add(Me.VorbisQTrackBar)
        Me.AVorbisQPanel.Controls.Add(Me.VorbisQNumericUpDown)
        Me.AVorbisQPanel.Controls.Add(Me.VorbisQLabel)
        Me.AVorbisQPanel.Location = New System.Drawing.Point(16, 237)
        Me.AVorbisQPanel.Name = "AVorbisQPanel"
        Me.AVorbisQPanel.Size = New System.Drawing.Size(445, 35)
        Me.AVorbisQPanel.TabIndex = 15
        '
        'VorbisQTrackBar
        '
        Me.VorbisQTrackBar.AutoSize = False
        Me.VorbisQTrackBar.Location = New System.Drawing.Point(109, 5)
        Me.VorbisQTrackBar.Minimum = -1
        Me.VorbisQTrackBar.Name = "VorbisQTrackBar"
        Me.VorbisQTrackBar.Size = New System.Drawing.Size(252, 23)
        Me.VorbisQTrackBar.TabIndex = 13
        Me.VorbisQTrackBar.TickFrequency = 0
        Me.VorbisQTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'VorbisQNumericUpDown
        '
        Me.VorbisQNumericUpDown.Location = New System.Drawing.Point(367, 7)
        Me.VorbisQNumericUpDown.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.VorbisQNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.VorbisQNumericUpDown.Name = "VorbisQNumericUpDown"
        Me.VorbisQNumericUpDown.Size = New System.Drawing.Size(74, 21)
        Me.VorbisQNumericUpDown.TabIndex = 14
        Me.VorbisQNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'VorbisQLabel
        '
        Me.VorbisQLabel.Location = New System.Drawing.Point(4, 11)
        Me.VorbisQLabel.Name = "VorbisQLabel"
        Me.VorbisQLabel.Size = New System.Drawing.Size(100, 17)
        Me.VorbisQLabel.TabIndex = 12
        Me.VorbisQLabel.Text = "Vorbis Q:"
        Me.VorbisQLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'AudioCodecComboBox
        '
        Me.AudioCodecComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AudioCodecComboBox.FormattingEnabled = True
        Me.AudioCodecComboBox.Location = New System.Drawing.Point(125, 20)
        Me.AudioCodecComboBox.Name = "AudioCodecComboBox"
        Me.AudioCodecComboBox.Size = New System.Drawing.Size(330, 20)
        Me.AudioCodecComboBox.TabIndex = 3
        '
        'ACodecLabel
        '
        Me.ACodecLabel.Location = New System.Drawing.Point(19, 25)
        Me.ACodecLabel.Name = "ACodecLabel"
        Me.ACodecLabel.Size = New System.Drawing.Size(100, 17)
        Me.ACodecLabel.TabIndex = 2
        Me.ACodecLabel.Text = "압축코덱:"
        Me.ACodecLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        Me.NeroAACGroupBox.Location = New System.Drawing.Point(9, 224)
        Me.NeroAACGroupBox.Name = "NeroAACGroupBox"
        Me.NeroAACGroupBox.Size = New System.Drawing.Size(480, 210)
        Me.NeroAACGroupBox.TabIndex = 1
        Me.NeroAACGroupBox.TabStop = False
        Me.NeroAACGroupBox.Text = "Nero AAC"
        Me.NeroAACGroupBox.Visible = False
        '
        'NeroAACQTrackBar
        '
        Me.NeroAACQTrackBar.AutoSize = False
        Me.NeroAACQTrackBar.Location = New System.Drawing.Point(123, 169)
        Me.NeroAACQTrackBar.Maximum = 100
        Me.NeroAACQTrackBar.Name = "NeroAACQTrackBar"
        Me.NeroAACQTrackBar.Size = New System.Drawing.Size(254, 23)
        Me.NeroAACQTrackBar.TabIndex = 33
        Me.NeroAACQTrackBar.TickFrequency = 0
        Me.NeroAACQTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'NeroAACQNumericUpDown
        '
        Me.NeroAACQNumericUpDown.DecimalPlaces = 2
        Me.NeroAACQNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.NeroAACQNumericUpDown.Location = New System.Drawing.Point(383, 171)
        Me.NeroAACQNumericUpDown.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NeroAACQNumericUpDown.Name = "NeroAACQNumericUpDown"
        Me.NeroAACQNumericUpDown.Size = New System.Drawing.Size(72, 21)
        Me.NeroAACQNumericUpDown.TabIndex = 34
        '
        'NeroAACQLabel
        '
        Me.NeroAACQLabel.Location = New System.Drawing.Point(19, 169)
        Me.NeroAACQLabel.Name = "NeroAACQLabel"
        Me.NeroAACQLabel.Size = New System.Drawing.Size(100, 32)
        Me.NeroAACQLabel.TabIndex = 32
        Me.NeroAACQLabel.Text = "가변비트레이트" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Q)"
        Me.NeroAACQLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'NeroAACVBRRadioButton
        '
        Me.NeroAACVBRRadioButton.AutoSize = True
        Me.NeroAACVBRRadioButton.Location = New System.Drawing.Point(125, 143)
        Me.NeroAACVBRRadioButton.Name = "NeroAACVBRRadioButton"
        Me.NeroAACVBRRadioButton.Size = New System.Drawing.Size(108, 16)
        Me.NeroAACVBRRadioButton.TabIndex = 31
        Me.NeroAACVBRRadioButton.TabStop = True
        Me.NeroAACVBRRadioButton.Text = "Variable Bitrate"
        Me.NeroAACVBRRadioButton.UseVisualStyleBackColor = True
        '
        'NeroAACCBRRadioButton
        '
        Me.NeroAACCBRRadioButton.AutoSize = True
        Me.NeroAACCBRRadioButton.Location = New System.Drawing.Point(290, 82)
        Me.NeroAACCBRRadioButton.Name = "NeroAACCBRRadioButton"
        Me.NeroAACCBRRadioButton.Size = New System.Drawing.Size(112, 16)
        Me.NeroAACCBRRadioButton.TabIndex = 30
        Me.NeroAACCBRRadioButton.TabStop = True
        Me.NeroAACCBRRadioButton.Text = "Constant Bitrate"
        Me.NeroAACCBRRadioButton.UseVisualStyleBackColor = True
        '
        'NeroAACABRRadioButton
        '
        Me.NeroAACABRRadioButton.AutoSize = True
        Me.NeroAACABRRadioButton.Location = New System.Drawing.Point(125, 82)
        Me.NeroAACABRRadioButton.Name = "NeroAACABRRadioButton"
        Me.NeroAACABRRadioButton.Size = New System.Drawing.Size(110, 16)
        Me.NeroAACABRRadioButton.TabIndex = 29
        Me.NeroAACABRRadioButton.TabStop = True
        Me.NeroAACABRRadioButton.Text = "Adaptive Bitrate"
        Me.NeroAACABRRadioButton.UseVisualStyleBackColor = True
        '
        'NeroAACBitrateTrackBar
        '
        Me.NeroAACBitrateTrackBar.AutoSize = False
        Me.NeroAACBitrateTrackBar.Location = New System.Drawing.Point(123, 108)
        Me.NeroAACBitrateTrackBar.Maximum = 640
        Me.NeroAACBitrateTrackBar.Minimum = 8
        Me.NeroAACBitrateTrackBar.Name = "NeroAACBitrateTrackBar"
        Me.NeroAACBitrateTrackBar.Size = New System.Drawing.Size(254, 23)
        Me.NeroAACBitrateTrackBar.TabIndex = 27
        Me.NeroAACBitrateTrackBar.TickFrequency = 0
        Me.NeroAACBitrateTrackBar.TickStyle = System.Windows.Forms.TickStyle.None
        Me.NeroAACBitrateTrackBar.Value = 8
        '
        'NeroAACBitrateNumericUpDown
        '
        Me.NeroAACBitrateNumericUpDown.Location = New System.Drawing.Point(383, 110)
        Me.NeroAACBitrateNumericUpDown.Maximum = New Decimal(New Integer() {640, 0, 0, 0})
        Me.NeroAACBitrateNumericUpDown.Minimum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.NeroAACBitrateNumericUpDown.Name = "NeroAACBitrateNumericUpDown"
        Me.NeroAACBitrateNumericUpDown.Size = New System.Drawing.Size(72, 21)
        Me.NeroAACBitrateNumericUpDown.TabIndex = 28
        Me.NeroAACBitrateNumericUpDown.Value = New Decimal(New Integer() {8, 0, 0, 0})
        '
        'NeroAACBitrateLabel
        '
        Me.NeroAACBitrateLabel.Location = New System.Drawing.Point(19, 108)
        Me.NeroAACBitrateLabel.Name = "NeroAACBitrateLabel"
        Me.NeroAACBitrateLabel.Size = New System.Drawing.Size(100, 32)
        Me.NeroAACBitrateLabel.TabIndex = 26
        Me.NeroAACBitrateLabel.Text = "비트레이트" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Kbit/s)"
        Me.NeroAACBitrateLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'NeroAACSALabel
        '
        Me.NeroAACSALabel.AutoSize = True
        Me.NeroAACSALabel.ForeColor = System.Drawing.Color.Green
        Me.NeroAACSALabel.Location = New System.Drawing.Point(13, 60)
        Me.NeroAACSALabel.Name = "NeroAACSALabel"
        Me.NeroAACSALabel.Size = New System.Drawing.Size(270, 12)
        Me.NeroAACSALabel.TabIndex = 14
        Me.NeroAACSALabel.Text = "샘플레이트는 22050~48000 사이로 선택해주세요."
        Me.NeroAACSALabel.Visible = False
        '
        'NeroAACProfileComboBox
        '
        Me.NeroAACProfileComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NeroAACProfileComboBox.FormattingEnabled = True
        Me.NeroAACProfileComboBox.Items.AddRange(New Object() {"Automatically", "AAC LC", "HE-AAC (AAC LC-SBR)", "HE-AAC v2 (AAC LC-SBR+PS)"})
        Me.NeroAACProfileComboBox.Location = New System.Drawing.Point(125, 29)
        Me.NeroAACProfileComboBox.Name = "NeroAACProfileComboBox"
        Me.NeroAACProfileComboBox.Size = New System.Drawing.Size(243, 20)
        Me.NeroAACProfileComboBox.TabIndex = 13
        '
        'NeroAACProfileLabel
        '
        Me.NeroAACProfileLabel.Location = New System.Drawing.Point(20, 33)
        Me.NeroAACProfileLabel.Name = "NeroAACProfileLabel"
        Me.NeroAACProfileLabel.Size = New System.Drawing.Size(100, 17)
        Me.NeroAACProfileLabel.TabIndex = 12
        Me.NeroAACProfileLabel.Text = "AAC 프로필:"
        Me.NeroAACProfileLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ETCTabPage
        '
        Me.ETCTabPage.Controls.Add(Me.GroupBox1)
        Me.ETCTabPage.Controls.Add(Me.FFmpegCommandGroupBox)
        Me.ETCTabPage.Controls.Add(Me.SizeLimitGroupBox)
        Me.ETCTabPage.Controls.Add(Me.NameGroupBox)
        Me.ETCTabPage.Location = New System.Drawing.Point(4, 22)
        Me.ETCTabPage.Name = "ETCTabPage"
        Me.ETCTabPage.Size = New System.Drawing.Size(499, 471)
        Me.ETCTabPage.TabIndex = 6
        Me.ETCTabPage.Text = "기타"
        Me.ETCTabPage.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SubtitleRecordingCheckBox)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 178)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(480, 55)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FFmpeg Subtitle Recording"
        '
        'SubtitleRecordingCheckBox
        '
        Me.SubtitleRecordingCheckBox.AutoSize = True
        Me.SubtitleRecordingCheckBox.Location = New System.Drawing.Point(19, 24)
        Me.SubtitleRecordingCheckBox.Name = "SubtitleRecordingCheckBox"
        Me.SubtitleRecordingCheckBox.Size = New System.Drawing.Size(48, 16)
        Me.SubtitleRecordingCheckBox.TabIndex = 31
        Me.SubtitleRecordingCheckBox.Text = "사용"
        Me.SubtitleRecordingCheckBox.UseVisualStyleBackColor = True
        '
        'FFmpegCommandGroupBox
        '
        Me.FFmpegCommandGroupBox.Controls.Add(Me.FFmpegCommandButton)
        Me.FFmpegCommandGroupBox.Controls.Add(Me.FFmpegCommandTextBox)
        Me.FFmpegCommandGroupBox.Location = New System.Drawing.Point(9, 242)
        Me.FFmpegCommandGroupBox.Name = "FFmpegCommandGroupBox"
        Me.FFmpegCommandGroupBox.Size = New System.Drawing.Size(480, 57)
        Me.FFmpegCommandGroupBox.TabIndex = 3
        Me.FFmpegCommandGroupBox.TabStop = False
        Me.FFmpegCommandGroupBox.Text = "FFmpeg 추가 명령어"
        '
        'FFmpegCommandButton
        '
        Me.FFmpegCommandButton.Location = New System.Drawing.Point(295, 21)
        Me.FFmpegCommandButton.Name = "FFmpegCommandButton"
        Me.FFmpegCommandButton.Size = New System.Drawing.Size(167, 23)
        Me.FFmpegCommandButton.TabIndex = 5
        Me.FFmpegCommandButton.Text = "명령어 보기"
        Me.FFmpegCommandButton.UseVisualStyleBackColor = True
        '
        'FFmpegCommandTextBox
        '
        Me.FFmpegCommandTextBox.Location = New System.Drawing.Point(15, 22)
        Me.FFmpegCommandTextBox.Name = "FFmpegCommandTextBox"
        Me.FFmpegCommandTextBox.Size = New System.Drawing.Size(274, 21)
        Me.FFmpegCommandTextBox.TabIndex = 4
        '
        'SizeLimitGroupBox
        '
        Me.SizeLimitGroupBox.Controls.Add(Me.SizeLimitCheckBox)
        Me.SizeLimitGroupBox.Controls.Add(Me.SizeLimitLabel)
        Me.SizeLimitGroupBox.Controls.Add(Me.SizeLimitTextBox)
        Me.SizeLimitGroupBox.Location = New System.Drawing.Point(9, 114)
        Me.SizeLimitGroupBox.Name = "SizeLimitGroupBox"
        Me.SizeLimitGroupBox.Size = New System.Drawing.Size(477, 55)
        Me.SizeLimitGroupBox.TabIndex = 1
        Me.SizeLimitGroupBox.TabStop = False
        Me.SizeLimitGroupBox.Text = "인코딩 용량 제한"
        '
        'SizeLimitCheckBox
        '
        Me.SizeLimitCheckBox.AutoSize = True
        Me.SizeLimitCheckBox.Location = New System.Drawing.Point(19, 24)
        Me.SizeLimitCheckBox.Name = "SizeLimitCheckBox"
        Me.SizeLimitCheckBox.Size = New System.Drawing.Size(48, 16)
        Me.SizeLimitCheckBox.TabIndex = 30
        Me.SizeLimitCheckBox.Text = "사용"
        Me.SizeLimitCheckBox.UseVisualStyleBackColor = True
        '
        'SizeLimitLabel
        '
        Me.SizeLimitLabel.AutoSize = True
        Me.SizeLimitLabel.Enabled = False
        Me.SizeLimitLabel.Location = New System.Drawing.Point(226, 26)
        Me.SizeLimitLabel.Name = "SizeLimitLabel"
        Me.SizeLimitLabel.Size = New System.Drawing.Size(52, 12)
        Me.SizeLimitLabel.TabIndex = 2
        Me.SizeLimitLabel.Text = "MB 이하"
        '
        'SizeLimitTextBox
        '
        Me.SizeLimitTextBox.Enabled = False
        Me.SizeLimitTextBox.Location = New System.Drawing.Point(130, 22)
        Me.SizeLimitTextBox.Name = "SizeLimitTextBox"
        Me.SizeLimitTextBox.Size = New System.Drawing.Size(88, 21)
        Me.SizeLimitTextBox.TabIndex = 1
        Me.SizeLimitTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NameGroupBox
        '
        Me.NameGroupBox.Controls.Add(Me.NameALabel)
        Me.NameGroupBox.Controls.Add(Me.ExtensionTextBox)
        Me.NameGroupBox.Controls.Add(Me.ExtensionLabel)
        Me.NameGroupBox.Controls.Add(Me.HeaderTextBox)
        Me.NameGroupBox.Controls.Add(Me.HeaderLabel)
        Me.NameGroupBox.Location = New System.Drawing.Point(9, 9)
        Me.NameGroupBox.Name = "NameGroupBox"
        Me.NameGroupBox.Size = New System.Drawing.Size(480, 96)
        Me.NameGroupBox.TabIndex = 0
        Me.NameGroupBox.TabStop = False
        Me.NameGroupBox.Text = "앞 부분 이름 / 확장자"
        '
        'NameALabel
        '
        Me.NameALabel.AutoSize = True
        Me.NameALabel.ForeColor = System.Drawing.Color.Green
        Me.NameALabel.Location = New System.Drawing.Point(19, 70)
        Me.NameALabel.Name = "NameALabel"
        Me.NameALabel.Size = New System.Drawing.Size(357, 12)
        Me.NameALabel.TabIndex = 4
        Me.NameALabel.Text = "확장자가 지정되어 있지 않으면 출력형식의 확장자로 사용됩니다."
        '
        'ExtensionTextBox
        '
        Me.ExtensionTextBox.Location = New System.Drawing.Point(307, 40)
        Me.ExtensionTextBox.Name = "ExtensionTextBox"
        Me.ExtensionTextBox.Size = New System.Drawing.Size(115, 21)
        Me.ExtensionTextBox.TabIndex = 3
        '
        'ExtensionLabel
        '
        Me.ExtensionLabel.AutoSize = True
        Me.ExtensionLabel.Location = New System.Drawing.Point(305, 22)
        Me.ExtensionLabel.Name = "ExtensionLabel"
        Me.ExtensionLabel.Size = New System.Drawing.Size(45, 12)
        Me.ExtensionLabel.TabIndex = 2
        Me.ExtensionLabel.Text = "확장자:"
        Me.ExtensionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'HeaderTextBox
        '
        Me.HeaderTextBox.Location = New System.Drawing.Point(21, 40)
        Me.HeaderTextBox.Name = "HeaderTextBox"
        Me.HeaderTextBox.Size = New System.Drawing.Size(235, 21)
        Me.HeaderTextBox.TabIndex = 1
        '
        'HeaderLabel
        '
        Me.HeaderLabel.AutoSize = True
        Me.HeaderLabel.Location = New System.Drawing.Point(19, 22)
        Me.HeaderLabel.Name = "HeaderLabel"
        Me.HeaderLabel.Size = New System.Drawing.Size(77, 12)
        Me.HeaderLabel.TabIndex = 0
        Me.HeaderLabel.Text = "앞 부분 이름:"
        Me.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'EncSetFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 605)
        Me.Controls.Add(Me.EncSetPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EncSetFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "인코딩 설정"
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
End Class
