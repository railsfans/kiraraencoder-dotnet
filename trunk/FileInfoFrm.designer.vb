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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FileInfoFrm))
        Me.FileInfoTextBox = New System.Windows.Forms.TextBox
        Me.FileInfoPanel = New System.Windows.Forms.Panel
        Me.FileInfoPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'FileInfoTextBox
        '
        resources.ApplyResources(Me.FileInfoTextBox, "FileInfoTextBox")
        Me.FileInfoTextBox.BackColor = System.Drawing.Color.White
        Me.FileInfoTextBox.Name = "FileInfoTextBox"
        Me.FileInfoTextBox.ReadOnly = True
        '
        'FileInfoPanel
        '
        Me.FileInfoPanel.Controls.Add(Me.FileInfoTextBox)
        resources.ApplyResources(Me.FileInfoPanel, "FileInfoPanel")
        Me.FileInfoPanel.Name = "FileInfoPanel"
        '
        'FileInfoFrm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.FileInfoPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FileInfoFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.FileInfoPanel.ResumeLayout(False)
        Me.FileInfoPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FileInfoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FileInfoPanel As System.Windows.Forms.Panel
End Class
