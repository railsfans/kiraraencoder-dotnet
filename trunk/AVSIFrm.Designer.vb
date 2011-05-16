<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AVSIFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AVSIFrm))
        Me.AVSIPanel = New System.Windows.Forms.Panel
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.IGroupBox = New System.Windows.Forms.GroupBox
        Me.ProductVersionLabel = New System.Windows.Forms.Label
        Me.InfoLabel = New System.Windows.Forms.Label
        Me.FileVersionLabel = New System.Windows.Forms.Label
        Me.RefBTN = New System.Windows.Forms.Button
        Me.InstallButton = New System.Windows.Forms.Button
        Me.AVSOFFLabel = New System.Windows.Forms.Label
        Me.OldVerCheckBox = New System.Windows.Forms.CheckBox
        Me.AVSOFFCheckBox = New System.Windows.Forms.CheckBox
        Me.OKBTN = New System.Windows.Forms.Button
        Me.AVSIPanel.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.IGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'AVSIPanel
        '
        Me.AVSIPanel.Controls.Add(Me.TabControl1)
        Me.AVSIPanel.Controls.Add(Me.OKBTN)
        resources.ApplyResources(Me.AVSIPanel, "AVSIPanel")
        Me.AVSIPanel.Name = "AVSIPanel"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        resources.ApplyResources(Me.TabControl1, "TabControl1")
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.IGroupBox)
        Me.TabPage1.Controls.Add(Me.RefBTN)
        Me.TabPage1.Controls.Add(Me.InstallButton)
        Me.TabPage1.Controls.Add(Me.AVSOFFLabel)
        Me.TabPage1.Controls.Add(Me.OldVerCheckBox)
        Me.TabPage1.Controls.Add(Me.AVSOFFCheckBox)
        resources.ApplyResources(Me.TabPage1, "TabPage1")
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'IGroupBox
        '
        Me.IGroupBox.Controls.Add(Me.ProductVersionLabel)
        Me.IGroupBox.Controls.Add(Me.InfoLabel)
        Me.IGroupBox.Controls.Add(Me.FileVersionLabel)
        resources.ApplyResources(Me.IGroupBox, "IGroupBox")
        Me.IGroupBox.Name = "IGroupBox"
        Me.IGroupBox.TabStop = False
        '
        'ProductVersionLabel
        '
        resources.ApplyResources(Me.ProductVersionLabel, "ProductVersionLabel")
        Me.ProductVersionLabel.Name = "ProductVersionLabel"
        '
        'InfoLabel
        '
        resources.ApplyResources(Me.InfoLabel, "InfoLabel")
        Me.InfoLabel.Name = "InfoLabel"
        '
        'FileVersionLabel
        '
        resources.ApplyResources(Me.FileVersionLabel, "FileVersionLabel")
        Me.FileVersionLabel.Name = "FileVersionLabel"
        '
        'RefBTN
        '
        resources.ApplyResources(Me.RefBTN, "RefBTN")
        Me.RefBTN.Name = "RefBTN"
        Me.RefBTN.UseVisualStyleBackColor = True
        '
        'InstallButton
        '
        resources.ApplyResources(Me.InstallButton, "InstallButton")
        Me.InstallButton.Name = "InstallButton"
        Me.InstallButton.UseVisualStyleBackColor = True
        '
        'AVSOFFLabel
        '
        resources.ApplyResources(Me.AVSOFFLabel, "AVSOFFLabel")
        Me.AVSOFFLabel.ForeColor = System.Drawing.Color.Green
        Me.AVSOFFLabel.Name = "AVSOFFLabel"
        '
        'OldVerCheckBox
        '
        resources.ApplyResources(Me.OldVerCheckBox, "OldVerCheckBox")
        Me.OldVerCheckBox.Name = "OldVerCheckBox"
        Me.OldVerCheckBox.UseVisualStyleBackColor = True
        '
        'AVSOFFCheckBox
        '
        resources.ApplyResources(Me.AVSOFFCheckBox, "AVSOFFCheckBox")
        Me.AVSOFFCheckBox.Name = "AVSOFFCheckBox"
        Me.AVSOFFCheckBox.UseVisualStyleBackColor = True
        '
        'OKBTN
        '
        resources.ApplyResources(Me.OKBTN, "OKBTN")
        Me.OKBTN.Name = "OKBTN"
        Me.OKBTN.UseVisualStyleBackColor = True
        '
        'AVSIFrm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ControlBox = False
        Me.Controls.Add(Me.AVSIPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AVSIFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.AVSIPanel.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.IGroupBox.ResumeLayout(False)
        Me.IGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AVSIPanel As System.Windows.Forms.Panel
    Friend WithEvents OldVerCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents FileVersionLabel As System.Windows.Forms.Label
    Friend WithEvents InfoLabel As System.Windows.Forms.Label
    Friend WithEvents RefBTN As System.Windows.Forms.Button
    Friend WithEvents OKBTN As System.Windows.Forms.Button
    Friend WithEvents IGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ProductVersionLabel As System.Windows.Forms.Label
    Friend WithEvents InstallButton As System.Windows.Forms.Button
    Friend WithEvents AVSOFFCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AVSOFFLabel As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
End Class
