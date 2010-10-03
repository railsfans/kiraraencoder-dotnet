<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileInfoFrm
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
        Me.FileInfoTextBox = New System.Windows.Forms.TextBox
        Me.FileInfoPanel = New System.Windows.Forms.Panel
        Me.FileInfoPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'FileInfoTextBox
        '
        Me.FileInfoTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FileInfoTextBox.BackColor = System.Drawing.Color.White
        Me.FileInfoTextBox.Location = New System.Drawing.Point(12, 12)
        Me.FileInfoTextBox.MaxLength = 2147483647
        Me.FileInfoTextBox.Multiline = True
        Me.FileInfoTextBox.Name = "FileInfoTextBox"
        Me.FileInfoTextBox.ReadOnly = True
        Me.FileInfoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.FileInfoTextBox.Size = New System.Drawing.Size(462, 506)
        Me.FileInfoTextBox.TabIndex = 0
        '
        'FileInfoPanel
        '
        Me.FileInfoPanel.Controls.Add(Me.FileInfoTextBox)
        Me.FileInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FileInfoPanel.Location = New System.Drawing.Point(0, 0)
        Me.FileInfoPanel.Name = "FileInfoPanel"
        Me.FileInfoPanel.Size = New System.Drawing.Size(486, 530)
        Me.FileInfoPanel.TabIndex = 1
        '
        'FileInfoFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 530)
        Me.Controls.Add(Me.FileInfoPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FileInfoFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "파일정보"
        Me.FileInfoPanel.ResumeLayout(False)
        Me.FileInfoPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FileInfoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FileInfoPanel As System.Windows.Forms.Panel
End Class
