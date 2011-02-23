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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PInfoFrm))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.InfoTabPage = New System.Windows.Forms.TabPage
        Me.CopyrightLabel = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.VersionLabel = New System.Windows.Forms.Label
        Me.NameLabel = New System.Windows.Forms.Label
        Me.LicenseTabPage = New System.Windows.Forms.TabPage
        Me.FileInfoTextBox = New System.Windows.Forms.TextBox
        Me.OKBTN = New System.Windows.Forms.Button
        Me.PPanel = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.WebsiteContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OfficialKiraraEncoderWebsiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DownloadSourceCodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.BittalkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BitDonGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.InChkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TabControl1.SuspendLayout()
        Me.InfoTabPage.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LicenseTabPage.SuspendLayout()
        Me.PPanel.SuspendLayout()
        Me.WebsiteContextMenuStrip.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
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
        Me.InfoTabPage.Controls.Add(Me.Label1)
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
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
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
        'PPanel
        '
        Me.PPanel.Controls.Add(Me.Button1)
        Me.PPanel.Controls.Add(Me.TabControl1)
        Me.PPanel.Controls.Add(Me.OKBTN)
        resources.ApplyResources(Me.PPanel, "PPanel")
        Me.PPanel.Name = "PPanel"
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'WebsiteContextMenuStrip
        '
        Me.WebsiteContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OfficialKiraraEncoderWebsiteToolStripMenuItem, Me.DownloadSourceCodeToolStripMenuItem, Me.ToolStripMenuItem1, Me.BittalkToolStripMenuItem, Me.BitDonGToolStripMenuItem})
        Me.WebsiteContextMenuStrip.Name = "ContextMenuStrip1"
        resources.ApplyResources(Me.WebsiteContextMenuStrip, "WebsiteContextMenuStrip")
        '
        'OfficialKiraraEncoderWebsiteToolStripMenuItem
        '
        Me.OfficialKiraraEncoderWebsiteToolStripMenuItem.Name = "OfficialKiraraEncoderWebsiteToolStripMenuItem"
        resources.ApplyResources(Me.OfficialKiraraEncoderWebsiteToolStripMenuItem, "OfficialKiraraEncoderWebsiteToolStripMenuItem")
        '
        'DownloadSourceCodeToolStripMenuItem
        '
        Me.DownloadSourceCodeToolStripMenuItem.Name = "DownloadSourceCodeToolStripMenuItem"
        resources.ApplyResources(Me.DownloadSourceCodeToolStripMenuItem, "DownloadSourceCodeToolStripMenuItem")
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        resources.ApplyResources(Me.ToolStripMenuItem1, "ToolStripMenuItem1")
        '
        'BittalkToolStripMenuItem
        '
        Me.BittalkToolStripMenuItem.Name = "BittalkToolStripMenuItem"
        resources.ApplyResources(Me.BittalkToolStripMenuItem, "BittalkToolStripMenuItem")
        '
        'BitDonGToolStripMenuItem
        '
        Me.BitDonGToolStripMenuItem.Name = "BitDonGToolStripMenuItem"
        resources.ApplyResources(Me.BitDonGToolStripMenuItem, "BitDonGToolStripMenuItem")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InChkToolStripMenuItem})
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'InChkToolStripMenuItem
        '
        Me.InChkToolStripMenuItem.Name = "InChkToolStripMenuItem"
        resources.ApplyResources(Me.InChkToolStripMenuItem, "InChkToolStripMenuItem")
        '
        'PInfoFrm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
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
        Me.WebsiteContextMenuStrip.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents PPanel As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents WebsiteContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OfficialKiraraEncoderWebsiteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DownloadSourceCodeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BitDonGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BittalkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents InChkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
