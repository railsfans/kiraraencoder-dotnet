<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PInfoFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PInfoFrm))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.InfoTabPage = New System.Windows.Forms.TabPage
        Me.CopyrightLabel = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.VersionLabel = New System.Windows.Forms.Label
        Me.NameLabel = New System.Windows.Forms.Label
        Me.LicenseTabPage = New System.Windows.Forms.TabPage
        Me.FileInfoTextBox = New System.Windows.Forms.TextBox
        Me.OKBTN = New System.Windows.Forms.Button
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.PPanel = New System.Windows.Forms.Panel
        Me.TabControl1.SuspendLayout()
        Me.InfoTabPage.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LicenseTabPage.SuspendLayout()
        Me.PPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.InfoTabPage)
        Me.TabControl1.Controls.Add(Me.LicenseTabPage)
        resources.ApplyResources(Me.TabControl1, "TabControl1")
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        '
        'InfoTabPage
        '
        Me.InfoTabPage.Controls.Add(Me.CopyrightLabel)
        Me.InfoTabPage.Controls.Add(Me.PictureBox1)
        Me.InfoTabPage.Controls.Add(Me.Label4)
        Me.InfoTabPage.Controls.Add(Me.VersionLabel)
        Me.InfoTabPage.Controls.Add(Me.NameLabel)
        resources.ApplyResources(Me.InfoTabPage, "InfoTabPage")
        Me.InfoTabPage.Name = "InfoTabPage"
        Me.InfoTabPage.UseVisualStyleBackColor = True
        '
        'CopyrightLabel
        '
        resources.ApplyResources(Me.CopyrightLabel, "CopyrightLabel")
        Me.CopyrightLabel.Name = "CopyrightLabel"
        '
        'PictureBox1
        '
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'VersionLabel
        '
        resources.ApplyResources(Me.VersionLabel, "VersionLabel")
        Me.VersionLabel.Name = "VersionLabel"
        '
        'NameLabel
        '
        resources.ApplyResources(Me.NameLabel, "NameLabel")
        Me.NameLabel.Name = "NameLabel"
        '
        'LicenseTabPage
        '
        Me.LicenseTabPage.Controls.Add(Me.FileInfoTextBox)
        resources.ApplyResources(Me.LicenseTabPage, "LicenseTabPage")
        Me.LicenseTabPage.Name = "LicenseTabPage"
        Me.LicenseTabPage.UseVisualStyleBackColor = True
        '
        'FileInfoTextBox
        '
        resources.ApplyResources(Me.FileInfoTextBox, "FileInfoTextBox")
        Me.FileInfoTextBox.BackColor = System.Drawing.Color.White
        Me.FileInfoTextBox.Name = "FileInfoTextBox"
        Me.FileInfoTextBox.ReadOnly = True
        '
        'OKBTN
        '
        resources.ApplyResources(Me.OKBTN, "OKBTN")
        Me.OKBTN.Name = "OKBTN"
        Me.OKBTN.UseVisualStyleBackColor = True
        '
        'LinkLabel2
        '
        resources.ApplyResources(Me.LinkLabel2, "LinkLabel2")
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.TabStop = True
        '
        'LinkLabel1
        '
        resources.ApplyResources(Me.LinkLabel1, "LinkLabel1")
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.TabStop = True
        '
        'PPanel
        '
        Me.PPanel.Controls.Add(Me.TabControl1)
        Me.PPanel.Controls.Add(Me.LinkLabel2)
        Me.PPanel.Controls.Add(Me.OKBTN)
        Me.PPanel.Controls.Add(Me.LinkLabel1)
        resources.ApplyResources(Me.PPanel, "PPanel")
        Me.PPanel.Name = "PPanel"
        '
        'PInfoFrm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PInfoFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.TabControl1.ResumeLayout(False)
        Me.InfoTabPage.ResumeLayout(False)
        Me.InfoTabPage.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LicenseTabPage.ResumeLayout(False)
        Me.LicenseTabPage.PerformLayout()
        Me.PPanel.ResumeLayout(False)
        Me.PPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents InfoTabPage As System.Windows.Forms.TabPage
    Friend WithEvents LicenseTabPage As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents VersionLabel As System.Windows.Forms.Label
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CopyrightLabel As System.Windows.Forms.Label
    Friend WithEvents FileInfoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OKBTN As System.Windows.Forms.Button
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents PPanel As System.Windows.Forms.Panel
End Class
