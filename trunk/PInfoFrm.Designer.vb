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
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(354, 175)
        Me.TabControl1.TabIndex = 0
        '
        'InfoTabPage
        '
        Me.InfoTabPage.Controls.Add(Me.CopyrightLabel)
        Me.InfoTabPage.Controls.Add(Me.PictureBox1)
        Me.InfoTabPage.Controls.Add(Me.Label4)
        Me.InfoTabPage.Controls.Add(Me.VersionLabel)
        Me.InfoTabPage.Controls.Add(Me.NameLabel)
        Me.InfoTabPage.Location = New System.Drawing.Point(4, 22)
        Me.InfoTabPage.Name = "InfoTabPage"
        Me.InfoTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.InfoTabPage.Size = New System.Drawing.Size(346, 149)
        Me.InfoTabPage.TabIndex = 0
        Me.InfoTabPage.Text = "정보"
        Me.InfoTabPage.UseVisualStyleBackColor = True
        '
        'CopyrightLabel
        '
        Me.CopyrightLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CopyrightLabel.AutoSize = True
        Me.CopyrightLabel.Location = New System.Drawing.Point(10, 117)
        Me.CopyrightLabel.Name = "CopyrightLabel"
        Me.CopyrightLabel.Size = New System.Drawing.Size(59, 12)
        Me.CopyrightLabel.TabIndex = 4
        Me.CopyrightLabel.Text = "Copyright"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 12)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Licensed under the GPL v2"
        '
        'VersionLabel
        '
        Me.VersionLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VersionLabel.AutoSize = True
        Me.VersionLabel.Location = New System.Drawing.Point(81, 35)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(49, 12)
        Me.VersionLabel.TabIndex = 1
        Me.VersionLabel.Text = "버전 -.-"
        '
        'NameLabel
        '
        Me.NameLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(81, 16)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(121, 12)
        Me.NameLabel.TabIndex = 0
        Me.NameLabel.Text = "키라라 인코더 --비트"
        '
        'LicenseTabPage
        '
        Me.LicenseTabPage.Controls.Add(Me.FileInfoTextBox)
        Me.LicenseTabPage.Location = New System.Drawing.Point(4, 22)
        Me.LicenseTabPage.Name = "LicenseTabPage"
        Me.LicenseTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.LicenseTabPage.Size = New System.Drawing.Size(346, 149)
        Me.LicenseTabPage.TabIndex = 1
        Me.LicenseTabPage.Text = "라이선스"
        Me.LicenseTabPage.UseVisualStyleBackColor = True
        '
        'FileInfoTextBox
        '
        Me.FileInfoTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FileInfoTextBox.BackColor = System.Drawing.Color.White
        Me.FileInfoTextBox.Location = New System.Drawing.Point(6, 6)
        Me.FileInfoTextBox.MaxLength = 2147483647
        Me.FileInfoTextBox.Multiline = True
        Me.FileInfoTextBox.Name = "FileInfoTextBox"
        Me.FileInfoTextBox.ReadOnly = True
        Me.FileInfoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.FileInfoTextBox.Size = New System.Drawing.Size(360, 137)
        Me.FileInfoTextBox.TabIndex = 1
        Me.FileInfoTextBox.Text = resources.GetString("FileInfoTextBox.Text")
        Me.FileInfoTextBox.WordWrap = False
        '
        'OKBTN
        '
        Me.OKBTN.Location = New System.Drawing.Point(262, 199)
        Me.OKBTN.Name = "OKBTN"
        Me.OKBTN.Size = New System.Drawing.Size(104, 30)
        Me.OKBTN.TabIndex = 10
        Me.OKBTN.Text = "확인"
        Me.OKBTN.UseVisualStyleBackColor = True
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(10, 215)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(136, 12)
        Me.LinkLabel2.TabIndex = 11
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Download source code"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(10, 195)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(160, 12)
        Me.LinkLabel1.TabIndex = 12
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Official Kirara Encoder Blog"
        '
        'PPanel
        '
        Me.PPanel.Controls.Add(Me.TabControl1)
        Me.PPanel.Controls.Add(Me.LinkLabel2)
        Me.PPanel.Controls.Add(Me.OKBTN)
        Me.PPanel.Controls.Add(Me.LinkLabel1)
        Me.PPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PPanel.Location = New System.Drawing.Point(0, 0)
        Me.PPanel.Name = "PPanel"
        Me.PPanel.Size = New System.Drawing.Size(383, 241)
        Me.PPanel.TabIndex = 13
        '
        'PInfoFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 241)
        Me.Controls.Add(Me.PPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PInfoFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "키라라 인코더 정보"
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
