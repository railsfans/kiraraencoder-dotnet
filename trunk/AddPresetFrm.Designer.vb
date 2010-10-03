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
        Me.NameTextBox.Location = New System.Drawing.Point(104, 15)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(300, 21)
        Me.NameTextBox.TabIndex = 0
        '
        'NameLabel
        '
        Me.NameLabel.Location = New System.Drawing.Point(12, 15)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(86, 21)
        Me.NameLabel.TabIndex = 1
        Me.NameLabel.Text = "이름:"
        Me.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'OKBTN
        '
        Me.OKBTN.Location = New System.Drawing.Point(261, 49)
        Me.OKBTN.Name = "OKBTN"
        Me.OKBTN.Size = New System.Drawing.Size(90, 25)
        Me.OKBTN.TabIndex = 14
        Me.OKBTN.Text = "확인"
        Me.OKBTN.UseVisualStyleBackColor = True
        '
        'CancelBTN
        '
        Me.CancelBTN.Location = New System.Drawing.Point(357, 49)
        Me.CancelBTN.Name = "CancelBTN"
        Me.CancelBTN.Size = New System.Drawing.Size(90, 25)
        Me.CancelBTN.TabIndex = 13
        Me.CancelBTN.Text = "취소"
        Me.CancelBTN.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(410, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 21)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = ".xml"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AP_Panel
        '
        Me.AP_Panel.Controls.Add(Me.NameLabel)
        Me.AP_Panel.Controls.Add(Me.Label2)
        Me.AP_Panel.Controls.Add(Me.NameTextBox)
        Me.AP_Panel.Controls.Add(Me.CancelBTN)
        Me.AP_Panel.Controls.Add(Me.OKBTN)
        Me.AP_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AP_Panel.Location = New System.Drawing.Point(0, 0)
        Me.AP_Panel.Name = "AP_Panel"
        Me.AP_Panel.Size = New System.Drawing.Size(469, 91)
        Me.AP_Panel.TabIndex = 17
        '
        'AddPresetFrm
        '
        Me.AcceptButton = Me.OKBTN
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 91)
        Me.Controls.Add(Me.AP_Panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddPresetFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "프리셋 추가"
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
