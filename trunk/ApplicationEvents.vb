Namespace My

    ' MyApplication에 대해 다음 이벤트를 사용할 수 있습니다.
    ' 
    ' Startup: 응용 프로그램이 시작되고 시작 폼이 만들어지기 전에 발생합니다.
    ' Shutdown: 모든 응용 프로그램 폼이 닫힌 후에 발생합니다. 이 이벤트는 응용 프로그램이 비정상적으로 종료되는 경우에는 발생하지 않습니다.
    ' UnhandledException: 응용 프로그램에서 처리되지 않은 예외가 발생하는 경우 이 이벤트가 발생합니다.
    ' StartupNextInstance: 단일 인스턴스 응용 프로그램을 시작할 때 해당 응용 프로그램이 이미 활성 상태인 경우 발생합니다. 
    ' NetworkAvailabilityChanged: 네트워크가 연결되거나 연결이 끊어질 때 발생합니다.
    Partial Friend Class MyApplication

        Private Sub MyApplication_StartupNextInstance(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupNextInstanceEventArgs) Handles Me.StartupNextInstance

            MessageBox.Show("Kirara Encoder is already running.", "Kirara Encoder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            '최소화시 -> 일반상태로
            If MainFrm.WindowState = FormWindowState.Minimized Then MainFrm.WindowState = FormWindowState.Normal

            '트레이시 -> 일반상태로
            If MainFrm.NotifyIcon.Visible = True Then
                If EncodingFrm.EncProcBool = True Then
                    EncodingFrm.Show()
                End If
                MainFrm.Show()
                MainFrm.NotifyIcon.Visible = False
            End If

            '시야밖일경우 시야내로
            If MainFrm.Location.X < Screen.GetBounds(MainFrm).Left Then
                MainFrm.Location = New System.Drawing.Point(Screen.GetBounds(MainFrm).Left, MainFrm.Location.Y)
            End If

            If MainFrm.Location.Y < Screen.GetBounds(MainFrm).Top Then
                MainFrm.Location = New System.Drawing.Point(MainFrm.Location.X, Screen.GetBounds(MainFrm).Top)
            End If

            If MainFrm.Location.X > Screen.GetBounds(MainFrm).Right - MainFrm.Width Then
                MainFrm.Location = New System.Drawing.Point(Screen.GetBounds(MainFrm).Right - MainFrm.Width, MainFrm.Location.Y)
            End If

            If MainFrm.Location.Y > Screen.GetBounds(MainFrm).Bottom - MainFrm.Height Then
                MainFrm.Location = New System.Drawing.Point(MainFrm.Location.X, Screen.GetBounds(MainFrm).Bottom - MainFrm.Height)
            End If

        End Sub
    End Class

End Namespace

