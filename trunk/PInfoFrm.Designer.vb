﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.VersionLabel = New System.Windows.Forms.Label
        Me.NameLabel = New System.Windows.Forms.Label
        Me.LicenseTabPage = New System.Windows.Forms.TabPage
        Me.TextBox0 = New System.Windows.Forms.TextBox
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.CopyrightLabel = New System.Windows.Forms.Label
        Me.OKBTN = New System.Windows.Forms.Button
        Me.PPanel = New System.Windows.Forms.Panel
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.InChkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TabControl1.SuspendLayout()
        Me.InfoTabPage.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LicenseTabPage.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.PPanel.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.InfoTabPage)
        Me.TabControl1.Controls.Add(Me.LicenseTabPage)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        resources.ApplyResources(Me.TabControl1, "TabControl1")
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        '
        'InfoTabPage
        '
        Me.InfoTabPage.Controls.Add(Me.LinkLabel3)
        Me.InfoTabPage.Controls.Add(Me.LinkLabel1)
        Me.InfoTabPage.Controls.Add(Me.LinkLabel2)
        Me.InfoTabPage.Controls.Add(Me.Label1)
        Me.InfoTabPage.Controls.Add(Me.PictureBox1)
        Me.InfoTabPage.Controls.Add(Me.VersionLabel)
        Me.InfoTabPage.Controls.Add(Me.NameLabel)
        resources.ApplyResources(Me.InfoTabPage, "InfoTabPage")
        Me.InfoTabPage.Name = "InfoTabPage"
        Me.InfoTabPage.UseVisualStyleBackColor = True
        '
        'LinkLabel3
        '
        resources.ApplyResources(Me.LinkLabel3, "LinkLabel3")
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.TabStop = True
        '
        'LinkLabel1
        '
        resources.ApplyResources(Me.LinkLabel1, "LinkLabel1")
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.TabStop = True
        '
        'LinkLabel2
        '
        resources.ApplyResources(Me.LinkLabel2, "LinkLabel2")
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.TabStop = True
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
        Me.LicenseTabPage.Controls.Add(Me.TextBox0)
        resources.ApplyResources(Me.LicenseTabPage, "LicenseTabPage")
        Me.LicenseTabPage.Name = "LicenseTabPage"
        Me.LicenseTabPage.UseVisualStyleBackColor = True
        '
        'TextBox0
        '
        resources.ApplyResources(Me.TextBox0, "TextBox0")
        Me.TextBox0.BackColor = System.Drawing.Color.White
        Me.TextBox0.Name = "TextBox0"
        Me.TextBox0.ReadOnly = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TextBox1)
        resources.ApplyResources(Me.TabPage1, "TabPage1")
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        resources.ApplyResources(Me.TextBox1, "TextBox1")
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        '
        'CopyrightLabel
        '
        resources.ApplyResources(Me.CopyrightLabel, "CopyrightLabel")
        Me.CopyrightLabel.Name = "CopyrightLabel"
        '
        'OKBTN
        '
        resources.ApplyResources(Me.OKBTN, "OKBTN")
        Me.OKBTN.Name = "OKBTN"
        Me.OKBTN.UseVisualStyleBackColor = True
        '
        'PPanel
        '
        Me.PPanel.Controls.Add(Me.OKBTN)
        Me.PPanel.Controls.Add(Me.TabControl1)
        Me.PPanel.Controls.Add(Me.CopyrightLabel)
        resources.ApplyResources(Me.PPanel, "PPanel")
        Me.PPanel.Name = "PPanel"
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
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.PPanel.ResumeLayout(False)
        Me.PPanel.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents InfoTabPage As System.Windows.Forms.TabPage
    Friend WithEvents LicenseTabPage As System.Windows.Forms.TabPage
    Friend WithEvents VersionLabel As System.Windows.Forms.Label
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CopyrightLabel As System.Windows.Forms.Label
    Friend WithEvents TextBox0 As System.Windows.Forms.TextBox
    Friend WithEvents PPanel As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents InChkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents OKBTN As System.Windows.Forms.Button
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
End Class
