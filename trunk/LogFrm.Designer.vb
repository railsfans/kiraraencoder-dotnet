<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogFrm
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
        Me.LogPanel = New System.Windows.Forms.Panel
        Me.LogTextBox = New System.Windows.Forms.TextBox
        Me.LogPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'LogPanel
        '
        Me.LogPanel.Controls.Add(Me.LogTextBox)
        Me.LogPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogPanel.Location = New System.Drawing.Point(0, 0)
        Me.LogPanel.Name = "LogPanel"
        Me.LogPanel.Size = New System.Drawing.Size(729, 417)
        Me.LogPanel.TabIndex = 2
        '
        'LogTextBox
        '
        Me.LogTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LogTextBox.BackColor = System.Drawing.Color.White
        Me.LogTextBox.Location = New System.Drawing.Point(12, 12)
        Me.LogTextBox.MaxLength = 2147483647
        Me.LogTextBox.Multiline = True
        Me.LogTextBox.Name = "LogTextBox"
        Me.LogTextBox.ReadOnly = True
        Me.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.LogTextBox.Size = New System.Drawing.Size(705, 393)
        Me.LogTextBox.TabIndex = 0
        '
        'LogFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 417)
        Me.Controls.Add(Me.LogPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LogFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "오류로그"
        Me.LogPanel.ResumeLayout(False)
        Me.LogPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LogPanel As System.Windows.Forms.Panel
    Friend WithEvents LogTextBox As System.Windows.Forms.TextBox
End Class
