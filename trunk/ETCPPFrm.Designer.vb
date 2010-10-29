<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ETCPPFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ETCPPFrm))
        Me.RateGroupBox = New System.Windows.Forms.GroupBox
        Me.RatePCheckBox = New System.Windows.Forms.CheckBox
        Me.RateCheckBox = New System.Windows.Forms.CheckBox
        Me.RateNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.DefBTN = New System.Windows.Forms.Button
        Me.OKBTN = New System.Windows.Forms.Button
        Me.CancelBTN = New System.Windows.Forms.Button
        Me.EPP_Panel = New System.Windows.Forms.Panel
        Me.RateGroupBox.SuspendLayout()
        CType(Me.RateNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPP_Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'RateGroupBox
        '
        Me.RateGroupBox.Controls.Add(Me.RatePCheckBox)
        Me.RateGroupBox.Controls.Add(Me.RateCheckBox)
        Me.RateGroupBox.Controls.Add(Me.RateNumericUpDown)
        resources.ApplyResources(Me.RateGroupBox, "RateGroupBox")
        Me.RateGroupBox.Name = "RateGroupBox"
        Me.RateGroupBox.TabStop = False
        '
        'RatePCheckBox
        '
        resources.ApplyResources(Me.RatePCheckBox, "RatePCheckBox")
        Me.RatePCheckBox.Name = "RatePCheckBox"
        Me.RatePCheckBox.UseVisualStyleBackColor = True
        '
        'RateCheckBox
        '
        resources.ApplyResources(Me.RateCheckBox, "RateCheckBox")
        Me.RateCheckBox.Name = "RateCheckBox"
        Me.RateCheckBox.UseVisualStyleBackColor = True
        '
        'RateNumericUpDown
        '
        Me.RateNumericUpDown.DecimalPlaces = 2
        resources.ApplyResources(Me.RateNumericUpDown, "RateNumericUpDown")
        Me.RateNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.RateNumericUpDown.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.RateNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.RateNumericUpDown.Name = "RateNumericUpDown"
        Me.RateNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'DefBTN
        '
        resources.ApplyResources(Me.DefBTN, "DefBTN")
        Me.DefBTN.Name = "DefBTN"
        Me.DefBTN.UseVisualStyleBackColor = True
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
        'EPP_Panel
        '
        Me.EPP_Panel.Controls.Add(Me.RateGroupBox)
        Me.EPP_Panel.Controls.Add(Me.DefBTN)
        Me.EPP_Panel.Controls.Add(Me.CancelBTN)
        Me.EPP_Panel.Controls.Add(Me.OKBTN)
        resources.ApplyResources(Me.EPP_Panel, "EPP_Panel")
        Me.EPP_Panel.Name = "EPP_Panel"
        '
        'ETCPPFrm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.EPP_Panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ETCPPFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.RateGroupBox.ResumeLayout(False)
        Me.RateGroupBox.PerformLayout()
        CType(Me.RateNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPP_Panel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RateGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents RatePCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents RateCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents RateNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents DefBTN As System.Windows.Forms.Button
    Friend WithEvents OKBTN As System.Windows.Forms.Button
    Friend WithEvents CancelBTN As System.Windows.Forms.Button
    Friend WithEvents EPP_Panel As System.Windows.Forms.Panel
End Class
