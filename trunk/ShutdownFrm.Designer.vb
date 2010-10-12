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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ShutdownFrm))
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
        resources.ApplyResources(Me.ShutdownLabel, "ShutdownLabel")
        Me.ShutdownLabel.Name = "ShutdownLabel"
        '
        'CntProgressBar
        '
        resources.ApplyResources(Me.CntProgressBar, "CntProgressBar")
        Me.CntProgressBar.Maximum = 300
        Me.CntProgressBar.Name = "CntProgressBar"
        Me.CntProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'CancelBTN
        '
        resources.ApplyResources(Me.CancelBTN, "CancelBTN")
        Me.CancelBTN.Name = "CancelBTN"
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
        resources.ApplyResources(Me.ShutdownPanel, "ShutdownPanel")
        Me.ShutdownPanel.Name = "ShutdownPanel"
        '
        'ShutdownFrm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ShutdownPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ShutdownFrm"
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
