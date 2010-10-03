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
        Me.AVSIPanel = New System.Windows.Forms.Panel
        Me.InfoLabel = New System.Windows.Forms.Label
        Me.FileVersionLabel = New System.Windows.Forms.Label
        Me.OldVerCheckBox = New System.Windows.Forms.CheckBox
        Me.OKBTN = New System.Windows.Forms.Button
        Me.RefBTN = New System.Windows.Forms.Button
        Me.IGroupBox = New System.Windows.Forms.GroupBox
        Me.ProductVersionLabel = New System.Windows.Forms.Label
        Me.InstallButton = New System.Windows.Forms.Button
        Me.AVSIPanel.SuspendLayout()
        Me.IGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'AVSIPanel
        '
        Me.AVSIPanel.Controls.Add(Me.InstallButton)
        Me.AVSIPanel.Controls.Add(Me.IGroupBox)
        Me.AVSIPanel.Controls.Add(Me.RefBTN)
        Me.AVSIPanel.Controls.Add(Me.OKBTN)
        Me.AVSIPanel.Controls.Add(Me.OldVerCheckBox)
        Me.AVSIPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AVSIPanel.Location = New System.Drawing.Point(0, 0)
        Me.AVSIPanel.Name = "AVSIPanel"
        Me.AVSIPanel.Size = New System.Drawing.Size(445, 191)
        Me.AVSIPanel.TabIndex = 0
        '
        'InfoLabel
        '
        Me.InfoLabel.AutoSize = True
        Me.InfoLabel.Location = New System.Drawing.Point(15, 25)
        Me.InfoLabel.Name = "InfoLabel"
        Me.InfoLabel.Size = New System.Drawing.Size(11, 12)
        Me.InfoLabel.TabIndex = 1
        Me.InfoLabel.Text = "-"
        '
        'FileVersionLabel
        '
        Me.FileVersionLabel.AutoSize = True
        Me.FileVersionLabel.Location = New System.Drawing.Point(15, 72)
        Me.FileVersionLabel.Name = "FileVersionLabel"
        Me.FileVersionLabel.Size = New System.Drawing.Size(71, 12)
        Me.FileVersionLabel.TabIndex = 2
        Me.FileVersionLabel.Text = "파일 버전: -"
        '
        'OldVerCheckBox
        '
        Me.OldVerCheckBox.AutoSize = True
        Me.OldVerCheckBox.Location = New System.Drawing.Point(16, 125)
        Me.OldVerCheckBox.Name = "OldVerCheckBox"
        Me.OldVerCheckBox.Size = New System.Drawing.Size(208, 16)
        Me.OldVerCheckBox.TabIndex = 3
        Me.OldVerCheckBox.Text = "구버전 사용에 관해서 알리지 않음"
        Me.OldVerCheckBox.UseVisualStyleBackColor = True
        '
        'OKBTN
        '
        Me.OKBTN.Location = New System.Drawing.Point(338, 152)
        Me.OKBTN.Name = "OKBTN"
        Me.OKBTN.Size = New System.Drawing.Size(90, 25)
        Me.OKBTN.TabIndex = 13
        Me.OKBTN.Text = "확인"
        Me.OKBTN.UseVisualStyleBackColor = True
        '
        'RefBTN
        '
        Me.RefBTN.Location = New System.Drawing.Point(222, 152)
        Me.RefBTN.Name = "RefBTN"
        Me.RefBTN.Size = New System.Drawing.Size(110, 25)
        Me.RefBTN.TabIndex = 14
        Me.RefBTN.Text = "새로 고침"
        Me.RefBTN.UseVisualStyleBackColor = True
        '
        'IGroupBox
        '
        Me.IGroupBox.Controls.Add(Me.ProductVersionLabel)
        Me.IGroupBox.Controls.Add(Me.InfoLabel)
        Me.IGroupBox.Controls.Add(Me.FileVersionLabel)
        Me.IGroupBox.Location = New System.Drawing.Point(16, 12)
        Me.IGroupBox.Name = "IGroupBox"
        Me.IGroupBox.Size = New System.Drawing.Size(412, 104)
        Me.IGroupBox.TabIndex = 15
        Me.IGroupBox.TabStop = False
        Me.IGroupBox.Text = "파일버전 2.5.8.5 버전 이상 필요"
        '
        'ProductVersionLabel
        '
        Me.ProductVersionLabel.AutoSize = True
        Me.ProductVersionLabel.Location = New System.Drawing.Point(15, 53)
        Me.ProductVersionLabel.Name = "ProductVersionLabel"
        Me.ProductVersionLabel.Size = New System.Drawing.Size(71, 12)
        Me.ProductVersionLabel.TabIndex = 3
        Me.ProductVersionLabel.Text = "제품 버전: -"
        '
        'InstallButton
        '
        Me.InstallButton.Location = New System.Drawing.Point(16, 152)
        Me.InstallButton.Name = "InstallButton"
        Me.InstallButton.Size = New System.Drawing.Size(149, 25)
        Me.InstallButton.TabIndex = 16
        Me.InstallButton.Text = "설치하기"
        Me.InstallButton.UseVisualStyleBackColor = True
        '
        'AVSIFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 191)
        Me.ControlBox = False
        Me.Controls.Add(Me.AVSIPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AVSIFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AviSynth 설치확인"
        Me.AVSIPanel.ResumeLayout(False)
        Me.AVSIPanel.PerformLayout()
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
End Class
