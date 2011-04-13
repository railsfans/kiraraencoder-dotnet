Public Class LoadingFrm

    Public LOADSTR As String = ""

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Text = LOADSTR
    End Sub

    Private Sub LoadingFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '난수 -> 색상
        Dim Rnd As New Random
        Dim Rndi As Integer = Rnd.Next(0, 10)
        If Rndi = 0 Then
            Panel1.BackColor = Color.FromKnownColor(KnownColor.Ivory)
        ElseIf Rndi = 1 Then
            Panel1.BackColor = Color.FromKnownColor(KnownColor.MistyRose)
        ElseIf Rndi = 2 Then
            Panel1.BackColor = Color.FromKnownColor(KnownColor.Bisque)
        ElseIf Rndi = 3 Then
            Panel1.BackColor = Color.FromKnownColor(KnownColor.Khaki)
        ElseIf Rndi = 4 Then
            Panel1.BackColor = Color.FromKnownColor(KnownColor.LightGreen)
        ElseIf Rndi = 5 Then
            Panel1.BackColor = Color.FromKnownColor(KnownColor.PaleTurquoise)
        ElseIf Rndi = 6 Then
            Panel1.BackColor = Color.FromKnownColor(KnownColor.MediumPurple)
        ElseIf Rndi = 7 Then
            Panel1.BackColor = Color.FromKnownColor(KnownColor.Violet)
        ElseIf Rndi = 8 Then
            Panel1.BackColor = Color.FromKnownColor(KnownColor.HotPink)
        ElseIf Rndi = 9 Then
            Panel1.BackColor = Color.FromKnownColor(KnownColor.Pink)
        ElseIf Rndi = 10 Then
            Panel1.BackColor = Color.FromKnownColor(KnownColor.Black)
            Label1.ForeColor = Color.FromKnownColor(KnownColor.White)
        End If
        VersionLabel.Text = "Kirara Encoder v" & _
        My.Application.Info.Version.Major & "." & _
        My.Application.Info.Version.Minor & "." & _
        My.Application.Info.Version.Build & "." & _
        My.Application.Info.Version.Revision & " " & MainFrm.PDATA
        '보이기
        Me.Show()
    End Sub
End Class