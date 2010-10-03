<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShutdownFrm
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
        Me.components = New System.ComponentModel.Container
        Me.ShutdownLabel = New System.Windows.Forms.Label
        Me.CntProgressBar = New System.Windows.Forms.ProgressBar
        Me.CancelBTN = New System.Windows.Forms.Button
        Me.CntTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ShutdownPanel = New System.Windows.Forms.Panel
        Me.ShutdownPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ShutdownLabel
        '
        Me.ShutdownLabel.AutoSize = True
        Me.ShutdownLabel.Location = New System.Drawing.Point(12, 13)
        Me.ShutdownLabel.Name = "ShutdownLabel"
        Me.ShutdownLabel.Size = New System.Drawing.Size(165, 12)
        Me.ShutdownLabel.TabIndex = 0
        Me.ShutdownLabel.Text = "30초 뒤 시스템이 종료됩니다."
        '
        'CntProgressBar
        '
        Me.CntProgressBar.Location = New System.Drawing.Point(14, 34)
        Me.CntProgressBar.Maximum = 300
        Me.CntProgressBar.Name = "CntProgressBar"
        Me.CntProgressBar.Size = New System.Drawing.Size(298, 15)
        Me.CntProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.CntProgressBar.TabIndex = 1
        '
        'CancelBTN
        '
        Me.CancelBTN.Location = New System.Drawing.Point(327, 26)
        Me.CancelBTN.Name = "CancelBTN"
        Me.CancelBTN.Size = New System.Drawing.Size(90, 25)
        Me.CancelBTN.TabIndex = 12
        Me.CancelBTN.Text = "취소"
        Me.CancelBTN.UseVisualStyleBackColor = True
        '
        'CntTimer
        '
        '
        'ShutdownPanel
        '
        Me.ShutdownPanel.Controls.Add(Me.CancelBTN)
        Me.ShutdownPanel.Controls.Add(Me.ShutdownLabel)
        Me.ShutdownPanel.Controls.Add(Me.CntProgressBar)
        Me.ShutdownPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ShutdownPanel.Location = New System.Drawing.Point(0, 0)
        Me.ShutdownPanel.Name = "ShutdownPanel"
        Me.ShutdownPanel.Size = New System.Drawing.Size(435, 66)
        Me.ShutdownPanel.TabIndex = 13
        '
        'ShutdownFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 66)
        Me.Controls.Add(Me.ShutdownPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ShutdownFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "시스템 종료"
        Me.TopMost = True
        Me.ShutdownPanel.ResumeLayout(False)
        Me.ShutdownPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ShutdownLabel As System.Windows.Forms.Label
    Friend WithEvents CntProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents CancelBTN As System.Windows.Forms.Button
    Friend WithEvents CntTimer As System.Windows.Forms.Timer
    Friend WithEvents ShutdownPanel As System.Windows.Forms.Panel
End Class
