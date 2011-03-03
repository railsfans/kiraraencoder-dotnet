' ---------------------------------------------------------------------------------------
' 
' Copyright (C) 2008-2011 LEE KIWON
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

Imports System.IO

Public Class ShutdownFrm

#Region "시스템종료"

    '코드출처: http://www.xtremedotnettalk.com/showthread.php?t=90500

    Private Declare Function GetCurrentProcess Lib "kernel32.dll" () As IntPtr
    Private Declare Function OpenProcessToken Lib "advapi32.dll" (ByVal ProcessHandle As IntPtr, ByVal DesiredAccess As Int32, ByRef TokenHandle As IntPtr) As Int32
    Private Declare Function LookupPrivilegeValue Lib "advapi32.dll" Alias "LookupPrivilegeValueA" (ByVal lpSystemName As String, ByVal lpName As String, ByRef lpLuid As LUID) As Int32
    Private Declare Function AdjustTokenPrivileges Lib "advapi32.dll" (ByVal TokenHandle As IntPtr, ByVal DisableAllPrivileges As Int32, ByRef NewState As TOKEN_PRIVILEGES, ByVal BufferLength As Int32, ByRef PreviousState As TOKEN_PRIVILEGES, ByRef ReturnLength As Int32) As Int32
    Private Declare Function ExitWindowsEx Lib "user32.dll" (ByVal uFlags As Int32, ByVal dwReserved As Int32) As Int32
    Private Const EWX_FORCE As Int32 = 4
    Private Const EWX_SHUTDOWN As Int32 = 1

    Public Structure LUID
        Dim LowPart As Int32
        Dim HighPart As Int32
    End Structure

    Public Structure TOKEN_PRIVILEGES
        Public PrivilegeCount As Integer
        Public Privileges As LUID
        Public Attributes As Int32
    End Structure

    Private Sub ShutDown()
        Dim platform As New PlatformID
        Select Case Environment.OSVersion.Platform
            Case PlatformID.Win32NT
                Dim token As TOKEN_PRIVILEGES
                Dim blank_token As TOKEN_PRIVILEGES
                Dim token_handle As IntPtr
                Dim uid As LUID
                Dim ret_length As Integer
                Dim ptr As IntPtr = GetCurrentProcess() '/// get the process handle                
                OpenProcessToken(ptr, &H20 Or &H8, token_handle)
                LookupPrivilegeValue("", "SeShutdownPrivilege", uid)
                token.PrivilegeCount = 1
                token.Privileges = uid
                token.Attributes = &H2
                AdjustTokenPrivileges(token_handle, 0, token, System.Runtime.InteropServices.Marshal.SizeOf(blank_token), blank_token, ret_length)
                ExitWindowsEx(EWX_SHUTDOWN Or EWX_FORCE, &HFFFF)
            Case Else
                ExitWindowsEx(EWX_SHUTDOWN Or EWX_FORCE, &HFFFF)
        End Select
    End Sub

#End Region

    Private Sub CancelBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBTN.Click
        Close()
    End Sub

    Private Sub CntTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CntTimer.Tick
        If CntProgressBar.Value <> CntProgressBar.Maximum Then
            CntProgressBar.Value += 1
        Else
            CntTimer.Enabled = False
            ShutDown()
        End If
    End Sub

    Private Sub ShutdownFrm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        CntTimer.Enabled = False
    End Sub

    Private Sub ShutdownFrm_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        CntTimer.Enabled = True
    End Sub

    Private Sub ShutdownFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '=========================================
        'Rev 1.2
        '언어로드

        '함수에서 언어파일 선택
        Dim LangXMLFV As String = FunctionCls.LangSel

        'Auto-select 면 스킵
        If LangXMLFV = "Auto-select" Then
            GoTo LANG_SKIP
        End If

        '선택한 언어파일이 없으면 스킵
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\lang\" & LangXMLFV) = False Then
            MsgBox(LangXMLFV & " not found")
            GoTo LANG_SKIP
        End If

        Dim SR As New StreamReader(My.Application.Info.DirectoryPath & "\lang\" & LangXMLFV, System.Text.Encoding.UTF8)
        Dim XTR As New System.Xml.XmlTextReader(SR)
        Try
            Dim FN As String = Me.Font.Name, FNXP As String = Me.Font.Name, FS As Single = Me.Font.Size
            Do While XTR.Read
                Application.DoEvents()

                If XTR.Name = "FontName" Then FN = XTR.ReadString
                If XTR.Name = "FontNameXP" Then FNXP = XTR.ReadString
                If XTR.Name = "FontSize" Then FS = XTR.ReadString

                If Environment.OSVersion.Version.Major < 6 Then 'NT 5.X 이하
                    ShutdownPanel.Font = New Font(FNXP, FS)
                Else
                    ShutdownPanel.Font = New Font(FN, FS)
                End If

                If XTR.Name = "CancelBTN" Then CancelBTN.Text = XTR.ReadString

                If XTR.Name = "ShutdownFrm" Then Me.Text = XTR.ReadString
                If XTR.Name = "ShutdownFrmShutdownLabel" Then ShutdownLabel.Text = XTR.ReadString

            Loop
        Catch ex As Exception
            MsgBox("LANG_LOAD_ERROR :" & ex.Message)
        Finally
            XTR.Close()
            SR.Close()
        End Try
LANG_SKIP:
        '=========================================

    End Sub
End Class