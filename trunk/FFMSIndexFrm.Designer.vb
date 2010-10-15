<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FFMSIndexFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FFMSIndexFrm))
        Me.PLabel = New System.Windows.Forms.Label
        Me.CancelBTN = New System.Windows.Forms.Button
        Me.OutputBox_ID = New System.Windows.Forms.TextBox
        Me.ProgressBar = New System.Windows.Forms.ProgressBar
        Me.TLabel = New System.Windows.Forms.Label
        Me.OnePTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TLabelTimer = New System.Windows.Forms.Timer(Me.components)
        Me.IndexPanel = New System.Windows.Forms.Panel
        Me.IndexPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'PLabel
        '
        resources.ApplyResources(Me.PLabel, "PLabel")
        Me.PLabel.Name = "PLabel"
        '
        'CancelBTN
        '
        resources.ApplyResources(Me.CancelBTN, "CancelBTN")
        Me.CancelBTN.Name = "CancelBTN"
        Me.CancelBTN.UseVisualStyleBackColor = True
        '
        'OutputBox_ID
        '
        Me.OutputBox_ID.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.OutputBox_ID, "OutputBox_ID")
        Me.OutputBox_ID.Name = "OutputBox_ID"
        Me.OutputBox_ID.ReadOnly = True
        '
        'ProgressBar
        '
        resources.ApplyResources(Me.ProgressBar, "ProgressBar")
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'TLabel
        '
        resources.ApplyResources(Me.TLabel, "TLabel")
        Me.TLabel.Name = "TLabel"
        '
        'OnePTimer
        '
        '
        'TLabelTimer
        '
        Me.TLabelTimer.Interval = 1000
        '
        'IndexPanel
        '
        Me.IndexPanel.Controls.Add(Me.ProgressBar)
        Me.IndexPanel.Controls.Add(Me.OutputBox_ID)
        Me.IndexPanel.Controls.Add(Me.PLabel)
        Me.IndexPanel.Controls.Add(Me.TLabel)
        Me.IndexPanel.Controls.Add(Me.CancelBTN)
        resources.ApplyResources(Me.IndexPanel, "IndexPanel")
        Me.IndexPanel.Name = "IndexPanel"
        '
        'FFMSIndexFrm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ControlBox = False
        Me.Controls.Add(Me.IndexPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FFMSIndexFrm"
        Me.Opacity = 0.9
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.IndexPanel.ResumeLayout(False)
        Me.IndexPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PLabel As System.Windows.Forms.Label
    Friend WithEvents CancelBTN As System.Windows.Forms.Button
    Friend WithEvents OutputBox_ID As System.Windows.Forms.TextBox
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents TLabel As System.Windows.Forms.Label
    Friend WithEvents OnePTimer As System.Windows.Forms.Timer
    Friend WithEvents TLabelTimer As System.Windows.Forms.Timer
    Friend WithEvents IndexPanel As System.Windows.Forms.Panel
End Class
