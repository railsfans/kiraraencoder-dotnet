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
        Me.PLabel.Location = New System.Drawing.Point(174, 31)
        Me.PLabel.Name = "PLabel"
        Me.PLabel.Size = New System.Drawing.Size(83, 20)
        Me.PLabel.TabIndex = 1
        Me.PLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'CancelBTN
        '
        Me.CancelBTN.Location = New System.Drawing.Point(273, 9)
        Me.CancelBTN.Name = "CancelBTN"
        Me.CancelBTN.Size = New System.Drawing.Size(110, 34)
        Me.CancelBTN.TabIndex = 2
        Me.CancelBTN.Text = "취소"
        Me.CancelBTN.UseVisualStyleBackColor = True
        '
        'OutputBox_ID
        '
        Me.OutputBox_ID.BackColor = System.Drawing.Color.White
        Me.OutputBox_ID.Location = New System.Drawing.Point(327, 9)
        Me.OutputBox_ID.MaxLength = 2147483647
        Me.OutputBox_ID.Multiline = True
        Me.OutputBox_ID.Name = "OutputBox_ID"
        Me.OutputBox_ID.ReadOnly = True
        Me.OutputBox_ID.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.OutputBox_ID.Size = New System.Drawing.Size(38, 31)
        Me.OutputBox_ID.TabIndex = 22
        Me.OutputBox_ID.Visible = False
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(12, 9)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(242, 16)
        Me.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar.TabIndex = 23
        '
        'TLabel
        '
        Me.TLabel.Location = New System.Drawing.Point(10, 31)
        Me.TLabel.Name = "TLabel"
        Me.TLabel.Size = New System.Drawing.Size(153, 20)
        Me.TLabel.TabIndex = 24
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
        Me.IndexPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IndexPanel.Location = New System.Drawing.Point(0, 0)
        Me.IndexPanel.Name = "IndexPanel"
        Me.IndexPanel.Size = New System.Drawing.Size(399, 54)
        Me.IndexPanel.TabIndex = 25
        '
        'FFMSIndexFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 54)
        Me.ControlBox = False
        Me.Controls.Add(Me.IndexPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FFMSIndexFrm"
        Me.Opacity = 0.9
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FFmpegSource"
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
