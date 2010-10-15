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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogFrm))
        Me.LogPanel = New System.Windows.Forms.Panel
        Me.LogTextBox = New System.Windows.Forms.TextBox
        Me.LogPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'LogPanel
        '
        Me.LogPanel.Controls.Add(Me.LogTextBox)
        resources.ApplyResources(Me.LogPanel, "LogPanel")
        Me.LogPanel.Name = "LogPanel"
        '
        'LogTextBox
        '
        resources.ApplyResources(Me.LogTextBox, "LogTextBox")
        Me.LogTextBox.BackColor = System.Drawing.Color.White
        Me.LogTextBox.Name = "LogTextBox"
        Me.LogTextBox.ReadOnly = True
        '
        'LogFrm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LogPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LogFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.LogPanel.ResumeLayout(False)
        Me.LogPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LogPanel As System.Windows.Forms.Panel
    Friend WithEvents LogTextBox As System.Windows.Forms.TextBox
End Class
