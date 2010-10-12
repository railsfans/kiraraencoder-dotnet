<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrameMoveFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrameMoveFrm))
        Me.FrameNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.MoveButton = New System.Windows.Forms.Button
        Me.FrameMovePanel = New System.Windows.Forms.Panel
        CType(Me.FrameNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FrameMovePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'FrameNumericUpDown
        '
        resources.ApplyResources(Me.FrameNumericUpDown, "FrameNumericUpDown")
        Me.FrameNumericUpDown.Name = "FrameNumericUpDown"
        '
        'MoveButton
        '
        resources.ApplyResources(Me.MoveButton, "MoveButton")
        Me.MoveButton.Name = "MoveButton"
        Me.MoveButton.UseVisualStyleBackColor = True
        '
        'FrameMovePanel
        '
        Me.FrameMovePanel.Controls.Add(Me.FrameNumericUpDown)
        Me.FrameMovePanel.Controls.Add(Me.MoveButton)
        resources.ApplyResources(Me.FrameMovePanel, "FrameMovePanel")
        Me.FrameMovePanel.Name = "FrameMovePanel"
        '
        'FrameMoveFrm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.FrameMovePanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrameMoveFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        CType(Me.FrameNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FrameMovePanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FrameNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents MoveButton As System.Windows.Forms.Button
    Friend WithEvents FrameMovePanel As System.Windows.Forms.Panel
End Class
