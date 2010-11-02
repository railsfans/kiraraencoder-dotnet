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

Public Class PInfoFrm

    Private Sub OKBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKBTN.Click
        Close()
    End Sub

    Private Sub PInfoFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim BitV As String = "32"
        If Environ("PROCESSOR_ARCHITECTURE") = "AMD64" Then
            BitV = "64"
        End If
        Dim NameLabelV As String = "키라라 인코더"
        Dim NameLabel2V As String = "비트"
        Dim VersionLabelV As String = "버전"

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
                    PPanel.Font = New Font(FNXP, FS)
                Else
                    PPanel.Font = New Font(FN, FS)
                End If

                If XTR.Name = "OKBTN" Then OKBTN.Text = XTR.ReadString

                If XTR.Name = "PInfoFrm" Then Me.Text = XTR.ReadString
                If XTR.Name = "PInfoFrmInfoTabPage" Then InfoTabPage.Text = XTR.ReadString
                If XTR.Name = "PInfoFrmLicenseTabPage" Then LicenseTabPage.Text = XTR.ReadString
                If XTR.Name = "PInfoFrmNameLabel" Then NameLabelV = XTR.ReadString
                If XTR.Name = "PInfoFrmNameLabel2" Then NameLabel2V = XTR.ReadString
                If XTR.Name = "PInfoFrmVersionLabel" Then VersionLabelV = XTR.ReadString

            Loop
        Catch ex As Exception
            MsgBox("LANG_LOAD_ERROR :" & ex.Message)
        Finally
            XTR.Close()
        End Try
LANG_SKIP:
        '=========================================

        NameLabel.Text = NameLabelV & " " & BitV & NameLabel2V
        CopyrightLabel.Text = My.Application.Info.Copyright
        VersionLabel.Text = VersionLabelV & " " & _
        My.Application.Info.Version.Major & "." & _
        My.Application.Info.Version.Minor & "." & _
        My.Application.Info.Version.Revision

    End Sub

    Private Sub OfficialKiraraEncoderWebsiteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OfficialKiraraEncoderWebsiteToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://www.kiraraencoder.pe.kr")
    End Sub

    Private Sub DownloadSourceCodeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DownloadSourceCodeToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://code.google.com/p/kiraraencoder-dotnet")
    End Sub

    Private Sub BitDonGToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BitDonGToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://bitdong.org")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        WebsiteContextMenuStrip.Show(Control.MousePosition)
    End Sub

    Private Sub BittalkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BittalkToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://bittalk.org")
    End Sub
End Class