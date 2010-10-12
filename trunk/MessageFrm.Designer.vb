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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MessageFrm))
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
        resources.ApplyResources(Me.YesToAllBTN, "YesToAllBTN")
        Me.YesToAllBTN.Name = "YesToAllBTN"
        Me.YesToAllBTN.UseVisualStyleBackColor = True
        '
        'YesBTN
        '
        resources.ApplyResources(Me.YesBTN, "YesBTN")
        Me.YesBTN.Name = "YesBTN"
        Me.YesBTN.UseVisualStyleBackColor = True
        '
        'NoBTN
        '
        resources.ApplyResources(Me.NoBTN, "NoBTN")
        Me.NoBTN.Name = "NoBTN"
        Me.NoBTN.UseVisualStyleBackColor = True
        '
        'NoToAllBTN
        '
        resources.ApplyResources(Me.NoToAllBTN, "NoToAllBTN")
        Me.NoToAllBTN.Name = "NoToAllBTN"
        Me.NoToAllBTN.UseVisualStyleBackColor = True
        '
        'FileLabel
        '
        resources.ApplyResources(Me.FileLabel, "FileLabel")
        Me.FileLabel.Name = "FileLabel"
        '
        'FilePathLabel
        '
        resources.ApplyResources(Me.FilePathLabel, "FilePathLabel")
        Me.FilePathLabel.Name = "FilePathLabel"
        '
        'MessagePanel
        '
        Me.MessagePanel.Controls.Add(Me.FilePathLabel)
        Me.MessagePanel.Controls.Add(Me.FileLabel)
        Me.MessagePanel.Controls.Add(Me.YesToAllBTN)
        Me.MessagePanel.Controls.Add(Me.YesBTN)
        Me.MessagePanel.Controls.Add(Me.NoBTN)
        Me.MessagePanel.Controls.Add(Me.NoToAllBTN)
        resources.ApplyResources(Me.MessagePanel, "MessagePanel")
        Me.MessagePanel.Name = "MessagePanel"
        '
        'MessageFrm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ControlBox = False
        Me.Controls.Add(Me.MessagePanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MessageFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
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
