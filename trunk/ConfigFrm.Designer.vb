<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfigFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConfigFrm))
        Me.PreviewGroupBox = New System.Windows.Forms.GroupBox
        Me.imgXButton = New System.Windows.Forms.Button
        Me.ModeComboBox = New System.Windows.Forms.ComboBox
        Me.ModeLabel = New System.Windows.Forms.Label
        Me.ImgButton = New System.Windows.Forms.Button
        Me.ImgTextBox = New System.Windows.Forms.TextBox
        Me.ImgLabel = New System.Windows.Forms.Label
        Me.BackColorPanel = New System.Windows.Forms.Panel
        Me.BackColorLabel = New System.Windows.Forms.Label
        Me.PreviewImgPanel = New System.Windows.Forms.Panel
        Me.OKBTN = New System.Windows.Forms.Button
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.ConfigPanel = New System.Windows.Forms.Panel
        Me.CancelBTN = New System.Windows.Forms.Button
        Me.DefBTN = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.PreviewGroupBox.SuspendLayout()
        Me.ConfigPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'PreviewGroupBox
        '
        Me.PreviewGroupBox.Controls.Add(Me.imgXButton)
        Me.PreviewGroupBox.Controls.Add(Me.ModeComboBox)
        Me.PreviewGroupBox.Controls.Add(Me.ModeLabel)
        Me.PreviewGroupBox.Controls.Add(Me.ImgButton)
        Me.PreviewGroupBox.Controls.Add(Me.ImgTextBox)
        Me.PreviewGroupBox.Controls.Add(Me.ImgLabel)
        Me.PreviewGroupBox.Controls.Add(Me.BackColorPanel)
        Me.PreviewGroupBox.Controls.Add(Me.BackColorLabel)
        Me.PreviewGroupBox.Controls.Add(Me.PreviewImgPanel)
        resources.ApplyResources(Me.PreviewGroupBox, "PreviewGroupBox")
        Me.PreviewGroupBox.Name = "PreviewGroupBox"
        Me.PreviewGroupBox.TabStop = False
        '
        'imgXButton
        '
        resources.ApplyResources(Me.imgXButton, "imgXButton")
        Me.imgXButton.Name = "imgXButton"
        Me.imgXButton.UseVisualStyleBackColor = True
        '
        'ModeComboBox
        '
        Me.ModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ModeComboBox.FormattingEnabled = True
        Me.ModeComboBox.Items.AddRange(New Object() {resources.GetString("ModeComboBox.Items"), resources.GetString("ModeComboBox.Items1"), resources.GetString("ModeComboBox.Items2"), resources.GetString("ModeComboBox.Items3"), resources.GetString("ModeComboBox.Items4")})
        resources.ApplyResources(Me.ModeComboBox, "ModeComboBox")
        Me.ModeComboBox.Name = "ModeComboBox"
        '
        'ModeLabel
        '
        resources.ApplyResources(Me.ModeLabel, "ModeLabel")
        Me.ModeLabel.Name = "ModeLabel"
        '
        'ImgButton
        '
        resources.ApplyResources(Me.ImgButton, "ImgButton")
        Me.ImgButton.Name = "ImgButton"
        Me.ImgButton.UseVisualStyleBackColor = True
        '
        'ImgTextBox
        '
        resources.ApplyResources(Me.ImgTextBox, "ImgTextBox")
        Me.ImgTextBox.Name = "ImgTextBox"
        Me.ImgTextBox.ReadOnly = True
        '
        'ImgLabel
        '
        resources.ApplyResources(Me.ImgLabel, "ImgLabel")
        Me.ImgLabel.Name = "ImgLabel"
        '
        'BackColorPanel
        '
        Me.BackColorPanel.BackColor = System.Drawing.Color.Black
        Me.BackColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.BackColorPanel, "BackColorPanel")
        Me.BackColorPanel.Name = "BackColorPanel"
        '
        'BackColorLabel
        '
        resources.ApplyResources(Me.BackColorLabel, "BackColorLabel")
        Me.BackColorLabel.Name = "BackColorLabel"
        '
        'PreviewImgPanel
        '
        Me.PreviewImgPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.PreviewImgPanel, "PreviewImgPanel")
        Me.PreviewImgPanel.Name = "PreviewImgPanel"
        '
        'OKBTN
        '
        resources.ApplyResources(Me.OKBTN, "OKBTN")
        Me.OKBTN.Name = "OKBTN"
        Me.OKBTN.UseVisualStyleBackColor = True
        '
        'ConfigPanel
        '
        Me.ConfigPanel.Controls.Add(Me.CancelBTN)
        Me.ConfigPanel.Controls.Add(Me.DefBTN)
        Me.ConfigPanel.Controls.Add(Me.PreviewGroupBox)
        Me.ConfigPanel.Controls.Add(Me.OKBTN)
        resources.ApplyResources(Me.ConfigPanel, "ConfigPanel")
        Me.ConfigPanel.Name = "ConfigPanel"
        '
        'CancelBTN
        '
        resources.ApplyResources(Me.CancelBTN, "CancelBTN")
        Me.CancelBTN.Name = "CancelBTN"
        Me.CancelBTN.UseVisualStyleBackColor = True
        '
        'DefBTN
        '
        resources.ApplyResources(Me.DefBTN, "DefBTN")
        Me.DefBTN.Name = "DefBTN"
        Me.DefBTN.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        resources.ApplyResources(Me.OpenFileDialog1, "OpenFileDialog1")
        '
        'ConfigFrm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ConfigPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ConfigFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.PreviewGroupBox.ResumeLayout(False)
        Me.PreviewGroupBox.PerformLayout()
        Me.ConfigPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PreviewGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents BackColorLabel As System.Windows.Forms.Label
    Friend WithEvents PreviewImgPanel As System.Windows.Forms.Panel
    Friend WithEvents ImgLabel As System.Windows.Forms.Label
    Friend WithEvents BackColorPanel As System.Windows.Forms.Panel
    Friend WithEvents ImgButton As System.Windows.Forms.Button
    Friend WithEvents ImgTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OKBTN As System.Windows.Forms.Button
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents ConfigPanel As System.Windows.Forms.Panel
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents CancelBTN As System.Windows.Forms.Button
    Friend WithEvents ModeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ModeLabel As System.Windows.Forms.Label
    Friend WithEvents imgXButton As System.Windows.Forms.Button
    Friend WithEvents DefBTN As System.Windows.Forms.Button
End Class
