<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FLoadFrm
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
        Me.FLoadLabel = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'FLoadLabel
        '
        Me.FLoadLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FLoadLabel.Location = New System.Drawing.Point(0, 0)
        Me.FLoadLabel.Name = "FLoadLabel"
        Me.FLoadLabel.Size = New System.Drawing.Size(444, 70)
        Me.FLoadLabel.TabIndex = 5
        Me.FLoadLabel.Text = "파일을 목록에 추가하면서 정보를 추출하는 중입니다."
        Me.FLoadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FLoadFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 70)
        Me.Controls.Add(Me.FLoadLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FLoadFrm"
        Me.Opacity = 0.9
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Kirara Encoder"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FLoadLabel As System.Windows.Forms.Label
End Class
