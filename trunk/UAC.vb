' ---------------------------------------------------------------------------------------
' 
' Copyright (C) 2008-2010 LEE KIWON
' 
' This program is free software; you can redistribute it and/or
' modify it under the terms of the GNU General Public License
' as published by the Free Software Foundation; either version 2
' of the License, or (at your option) any later version.
' 
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
' 
' You should have received a copy of the GNU General Public License
' along with this program; if not, write to the Free Software
' Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
' 
' =======================================================================================

Imports System.Security.Principal

Module UAC

    Private Const BCM_FIRST As Int32 = &H1600
    Private Const BCM_SETSHIELD As Int32 = (BCM_FIRST + &HC)

    Public Function IsVistaOrHigher() As Boolean
        Return Environment.OSVersion.Version.Major < 6
    End Function

    Public Function IsAdmin() As Boolean
        Dim id As WindowsIdentity = WindowsIdentity.GetCurrent()
        Dim p As WindowsPrincipal = New WindowsPrincipal(id)
        Return p.IsInRole(WindowsBuiltInRole.Administrator)
    End Function

    Public Sub AddShieldToButton(ByRef b As Button)
        b.FlatStyle = FlatStyle.System
        WinAPI.SendMessage(b.Handle, BCM_SETSHIELD, 0, &HFFFFFFFF)
    End Sub

    Public Sub RestartElevated()
        Dim startInfo As ProcessStartInfo = New ProcessStartInfo()
        startInfo.UseShellExecute = True
        startInfo.WorkingDirectory = Environment.CurrentDirectory
        startInfo.FileName = Application.ExecutablePath
        startInfo.Verb = "runas"
        Try
            Dim p As Process = Process.Start(startInfo)
        Catch ex As Exception
            Return
        End Try
        Process.GetCurrentProcess.Kill()
    End Sub

End Module
