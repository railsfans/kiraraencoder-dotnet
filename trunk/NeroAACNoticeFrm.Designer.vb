<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NeroAACNoticeFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NeroAACNoticeFrm))
        Me.Label1 = New System.Windows.Forms.Label
        Me.NeroPanel = New System.Windows.Forms.Panel
        Me.ClsButton = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.OButton = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.DnButton = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.NeroPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'NeroPanel
        '
        Me.NeroPanel.Controls.Add(Me.ClsButton)
        Me.NeroPanel.Controls.Add(Me.Label4)
        Me.NeroPanel.Controls.Add(Me.OButton)
        Me.NeroPanel.Controls.Add(Me.Label3)
        Me.NeroPanel.Controls.Add(Me.DnButton)
        Me.NeroPanel.Controls.Add(Me.Label2)
        Me.NeroPanel.Controls.Add(Me.Label1)
        resources.ApplyResources(Me.NeroPanel, "NeroPanel")
        Me.NeroPanel.Name = "NeroPanel"
        '
        'ClsButton
        '
        resources.ApplyResources(Me.ClsButton, "ClsButton")
        Me.ClsButton.Name = "ClsButton"
        Me.ClsButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'OButton
        '
        resources.ApplyResources(Me.OButton, "OButton")
        Me.OButton.Name = "OButton"
        Me.OButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'DnButton
        '
        resources.ApplyResources(Me.DnButton, "DnButton")
        Me.DnButton.Name = "DnButton"
        Me.DnButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'NeroAACNoticeFrm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.NeroPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NeroAACNoticeFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.NeroPanel.ResumeLayout(False)
        Me.NeroPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NeroPanel As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents OButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DnButton As System.Windows.Forms.Button
    Friend WithEvents ClsButton As System.Windows.Forms.Button
End Class
