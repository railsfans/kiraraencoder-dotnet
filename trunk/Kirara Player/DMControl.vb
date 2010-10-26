Public Class DMControl

    Inherits System.Windows.Forms.Panel
    Private Const WM_ERASEBKGND As Integer = &H14
    Private Const WM_DISPLAYCHANGE As Integer = &H7E

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)

        Select Case m.Msg

            Case WM_ERASEBKGND

                If MainFrm.VideoWidth <> 0 And MainFrm.VideoHeight <> 0 Then
                    Return
                End If

            Case WM_DISPLAYCHANGE

                If MainFrm.VMRWindowlessControl9 IsNot Nothing Then
                    MainFrm.VMRWindowlessControl9.DisplayModeChanged()
                ElseIf MainFrm.VMRWindowlessControl IsNot Nothing Then
                    MainFrm.VMRWindowlessControl.DisplayModeChanged()
                End If

        End Select

        MyBase.WndProc(m) '<- 삭제금지

    End Sub

End Class