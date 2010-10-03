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
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "파일 다운로드 및 설치방법"
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
        Me.NeroPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NeroPanel.Location = New System.Drawing.Point(0, 0)
        Me.NeroPanel.Name = "NeroPanel"
        Me.NeroPanel.Size = New System.Drawing.Size(623, 397)
        Me.NeroPanel.TabIndex = 1
        '
        'ClsButton
        '
        Me.ClsButton.Location = New System.Drawing.Point(38, 339)
        Me.ClsButton.Name = "ClsButton"
        Me.ClsButton.Size = New System.Drawing.Size(378, 28)
        Me.ClsButton.TabIndex = 6
        Me.ClsButton.Text = "닫기"
        Me.ClsButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(23, 270)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(561, 60)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "3. neroaac 폴더안에 neroAacEnc.exe 를 넣으면 완료되며 정상적으로 설치가 되었다면 다시 인코딩 시작할 때 이 창이 보이지 않을" & _
            "것입니다."
        '
        'OButton
        '
        Me.OButton.Location = New System.Drawing.Point(38, 228)
        Me.OButton.Name = "OButton"
        Me.OButton.Size = New System.Drawing.Size(378, 28)
        Me.OButton.TabIndex = 4
        Me.OButton.Text = "tools폴더열기"
        Me.OButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(23, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(561, 60)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "2. 다운로드 받은 Nero AAC Codec 을 압축을 푼 뒤 win32 폴더에 들어가서 neroAacEnc.exe 파일을 아래 tools 폴더" & _
            " 열기 버튼을 클릭하며 나오는 neroaac 폴더 안에 넣습니다."
        '
        'DnButton
        '
        Me.DnButton.Location = New System.Drawing.Point(38, 117)
        Me.DnButton.Name = "DnButton"
        Me.DnButton.Size = New System.Drawing.Size(378, 28)
        Me.DnButton.TabIndex = 2
        Me.DnButton.Text = "Nero AAC Codec 다운로드 사이트 방문"
        Me.DnButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(561, 60)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "1. 아래 버튼을 클릭하여 Nero AAC Codec 을 다운로드 받는 페이지로 이동을 합니다."
        '
        'NeroAACNoticeFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 397)
        Me.Controls.Add(Me.NeroPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NeroAACNoticeFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "neroAacEnc.exe not found"
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
