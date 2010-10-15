<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPresetFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddPresetFrm))
        Me.NameTextBox = New System.Windows.Forms.TextBox
        Me.NameLabel = New System.Windows.Forms.Label
        Me.OKBTN = New System.Windows.Forms.Button
        Me.CancelBTN = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.AP_Panel = New System.Windows.Forms.Panel
        Me.AP_Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'NameTextBox
        '
        resources.ApplyResources(Me.NameTextBox, "NameTextBox")
        Me.NameTextBox.Name = "NameTextBox"
        '
        'NameLabel
        '
        resources.ApplyResources(Me.NameLabel, "NameLabel")
        Me.NameLabel.Name = "NameLabel"
        '
        'OKBTN
        '
        resources.ApplyResources(Me.OKBTN, "OKBTN")
        Me.OKBTN.Name = "OKBTN"
        Me.OKBTN.UseVisualStyleBackColor = True
        '
        'CancelBTN
        '
        resources.ApplyResources(Me.CancelBTN, "CancelBTN")
        Me.CancelBTN.Name = "CancelBTN"
        Me.CancelBTN.UseVisualStyleBackColor = True
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'AP_Panel
        '
        Me.AP_Panel.Controls.Add(Me.NameLabel)
        Me.AP_Panel.Controls.Add(Me.Label2)
        Me.AP_Panel.Controls.Add(Me.NameTextBox)
        Me.AP_Panel.Controls.Add(Me.CancelBTN)
        Me.AP_Panel.Controls.Add(Me.OKBTN)
        resources.ApplyResources(Me.AP_Panel, "AP_Panel")
        Me.AP_Panel.Name = "AP_Panel"
        '
        'AddPresetFrm
        '
        Me.AcceptButton = Me.OKBTN
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.AP_Panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddPresetFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.AP_Panel.ResumeLayout(False)
        Me.AP_Panel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents OKBTN As System.Windows.Forms.Button
    Friend WithEvents CancelBTN As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AP_Panel As System.Windows.Forms.Panel
End Class
