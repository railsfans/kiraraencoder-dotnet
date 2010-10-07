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

Public Class MessageFrm

    Private Sub MessageFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim MessageFrmFileExistsV As String = ""
        Dim MessageFrmOverwriteV As String = ""

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
                    MessagePanel.Font = New Font(FNXP, FS)
                Else
                    MessagePanel.Font = New Font(FN, FS)
                End If

                If XTR.Name = "MessageFrmYesToAllBTN" Then YesToAllBTN.Text = XTR.ReadString
                If XTR.Name = "MessageFrmNoToAllBTN" Then NoToAllBTN.Text = XTR.ReadString
                If XTR.Name = "MessageFrmYesBTN" Then YesBTN.Text = XTR.ReadString
                If XTR.Name = "MessageFrmNoBTN" Then NoBTN.Text = XTR.ReadString
                If XTR.Name = "MessageFrmFileExists" Then MessageFrmFileExistsV = XTR.ReadString
                If XTR.Name = "MessageFrmOverwrite" Then MessageFrmOverwriteV = XTR.ReadString

            Loop
        Catch ex As Exception
            MsgBox("LANG_LOAD_ERROR :" & ex.Message)
        Finally
            XTR.Close()
        End Try
LANG_SKIP:
        '=========================================

        Me.Text = MessageFrmFileExistsV
        FileLabel.Text = MessageFrmFileExistsV & " " & MessageFrmOverwriteV

    End Sub

    Private Sub YesBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YesBTN.Click
        EncodingFrm.MessageBoxBTN = "YES"
        Me.Close()
    End Sub

    Private Sub YesToAllBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YesToAllBTN.Click
        EncodingFrm.MessageBoxBTN = "YESTOALL"
        Me.Close()
    End Sub

    Private Sub NoBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoBTN.Click
        EncodingFrm.MessageBoxBTN = "NO"
        Me.Close()
    End Sub

    Private Sub NoToAllBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoToAllBTN.Click
        EncodingFrm.MessageBoxBTN = "NOTOALL"
        Me.Close()
    End Sub

    Private Sub MessageFrm_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        '포커스
        YesBTN.Focus()
    End Sub
End Class