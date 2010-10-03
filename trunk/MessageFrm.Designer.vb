<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MessageFrm
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
        Me.YesToAllBTN = New System.Windows.Forms.Button
        Me.YesBTN = New System.Windows.Forms.Button
        Me.NoBTN = New System.Windows.Forms.Button
        Me.NoToAllBTN = New System.Windows.Forms.Button
        Me.FileLabel = New System.Windows.Forms.Label
        Me.FilePathLabel = New System.Windows.Forms.Label
        Me.MessagePanel = New System.Windows.Forms.Panel
        Me.MessagePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'YesToAllBTN
        '
        Me.YesToAllBTN.Location = New System.Drawing.Point(135, 96)
        Me.YesToAllBTN.Name = "YesToAllBTN"
        Me.YesToAllBTN.Size = New System.Drawing.Size(115, 25)
        Me.YesToAllBTN.TabIndex = 1
        Me.YesToAllBTN.Text = "모두 예"
        Me.YesToAllBTN.UseVisualStyleBackColor = True
        '
        'YesBTN
        '
        Me.YesBTN.Location = New System.Drawing.Point(14, 96)
        Me.YesBTN.Name = "YesBTN"
        Me.YesBTN.Size = New System.Drawing.Size(115, 25)
        Me.YesBTN.TabIndex = 0
        Me.YesBTN.Text = "예"
        Me.YesBTN.UseVisualStyleBackColor = True
        '
        'NoBTN
        '
        Me.NoBTN.Location = New System.Drawing.Point(269, 96)
        Me.NoBTN.Name = "NoBTN"
        Me.NoBTN.Size = New System.Drawing.Size(115, 25)
        Me.NoBTN.TabIndex = 3
        Me.NoBTN.Text = "아니요"
        Me.NoBTN.UseVisualStyleBackColor = True
        '
        'NoToAllBTN
        '
        Me.NoToAllBTN.Location = New System.Drawing.Point(390, 96)
        Me.NoToAllBTN.Name = "NoToAllBTN"
        Me.NoToAllBTN.Size = New System.Drawing.Size(115, 25)
        Me.NoToAllBTN.TabIndex = 2
        Me.NoToAllBTN.Text = "모두 아니요"
        Me.NoToAllBTN.UseVisualStyleBackColor = True
        '
        'FileLabel
        '
        Me.FileLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FileLabel.Location = New System.Drawing.Point(14, 64)
        Me.FileLabel.Name = "FileLabel"
        Me.FileLabel.Size = New System.Drawing.Size(491, 20)
        Me.FileLabel.TabIndex = 6
        '
        'FilePathLabel
        '
        Me.FilePathLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FilePathLabel.Location = New System.Drawing.Point(14, 14)
        Me.FilePathLabel.Name = "FilePathLabel"
        Me.FilePathLabel.Size = New System.Drawing.Size(491, 40)
        Me.FilePathLabel.TabIndex = 5
        '
        'MessagePanel
        '
        Me.MessagePanel.Controls.Add(Me.FilePathLabel)
        Me.MessagePanel.Controls.Add(Me.FileLabel)
        Me.MessagePanel.Controls.Add(Me.YesToAllBTN)
        Me.MessagePanel.Controls.Add(Me.YesBTN)
        Me.MessagePanel.Controls.Add(Me.NoBTN)
        Me.MessagePanel.Controls.Add(Me.NoToAllBTN)
        Me.MessagePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MessagePanel.Location = New System.Drawing.Point(0, 0)
        Me.MessagePanel.Name = "MessagePanel"
        Me.MessagePanel.Size = New System.Drawing.Size(521, 134)
        Me.MessagePanel.TabIndex = 7
        '
        'MessageFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 134)
        Me.ControlBox = False
        Me.Controls.Add(Me.MessagePanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MessageFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "MessageFrm"
        Me.MessagePanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents YesToAllBTN As System.Windows.Forms.Button
    Friend WithEvents YesBTN As System.Windows.Forms.Button
    Friend WithEvents NoBTN As System.Windows.Forms.Button
    Friend WithEvents NoToAllBTN As System.Windows.Forms.Button
    Friend WithEvents FileLabel As System.Windows.Forms.Label
    Friend WithEvents FilePathLabel As System.Windows.Forms.Label
    Friend WithEvents MessagePanel As System.Windows.Forms.Panel
End Class
