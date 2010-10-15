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

Imports System.IO

Public Class NeroAACNoticeFrm

    Private Sub ClsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClsButton.Click
        Close()
    End Sub

    Private Sub DnButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DnButton.Click
        System.Diagnostics.Process.Start("http://www.nero.com/eng/downloads-nerodigital-nero-aac-codec.php")
    End Sub

    Private Sub OButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OButton.Click
        Process.Start("explorer.exe", My.Application.Info.DirectoryPath & "\tools")
    End Sub

    Private Sub NeroAACNoticeFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '=========================================
        'Rev 1.1
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
                    NeroPanel.Font = New Font(FNXP, FS)
                Else
                    NeroPanel.Font = New Font(FN, FS)
                End If

                'If XTR.Name = "FileInfoFormFileInfo" Then FormTXT = XTR.ReadString
                If XTR.Name = "NeroAACNoticeFrmLabel1" Then Label1.Text = XTR.ReadString
                If XTR.Name = "NeroAACNoticeFrmLabel2" Then Label2.Text = XTR.ReadString
                If XTR.Name = "NeroAACNoticeFrmLabel3" Then Label3.Text = XTR.ReadString
                If XTR.Name = "NeroAACNoticeFrmLabel4" Then Label4.Text = XTR.ReadString
                If XTR.Name = "NeroAACNoticeFrmDnButton" Then DnButton.Text = XTR.ReadString
                If XTR.Name = "NeroAACNoticeFrmOButton" Then OButton.Text = XTR.ReadString
                If XTR.Name = "NeroAACNoticeFrmClsButton" Then ClsButton.Text = XTR.ReadString

            Loop
        Catch ex As Exception
            MsgBox("LANG_LOAD_ERROR :" & ex.Message)
        Finally
            XTR.Close()
        End Try
LANG_SKIP:
        '=========================================

    End Sub
End Class