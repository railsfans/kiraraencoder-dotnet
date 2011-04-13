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

Public Class AddPresetFrm

    Private Sub CancelBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBTN.Click
        Close()
    End Sub

    Private Sub OKBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKBTN.Click

        '공백
        If NameTextBox.Text = "" Then
            MsgBox(LangCls.AddPresetEmptyERR)
            Exit Sub
        End If

        '특수문자
        Dim TCharI As Integer
        TCharI = InStr(NameTextBox.Text, "\")
        If TCharI = 0 Then
            TCharI = InStr(NameTextBox.Text, "/")
        End If
        If TCharI = 0 Then
            TCharI = InStr(NameTextBox.Text, ":")
        End If
        If TCharI = 0 Then
            TCharI = InStr(NameTextBox.Text, "*")
        End If
        If TCharI = 0 Then
            TCharI = InStr(NameTextBox.Text, "?")
        End If
        If TCharI = 0 Then
            TCharI = InStr(NameTextBox.Text, "<")
        End If
        If TCharI = 0 Then
            TCharI = InStr(NameTextBox.Text, ">")
        End If
        If TCharI = 0 Then
            TCharI = InStr(NameTextBox.Text, "|")
        End If
        If TCharI > 0 Then
            MsgBox(LangCls.AddPresetCharERR)
            Exit Sub
        End If

        '--------------------------------

        '저장
        MainFrm.XML_SAVE(FunctionCls.AppInfoDirectoryPath & "\preset\" & NameTextBox.Text & ".xml")
        '목록새로고침
        MainFrm.RefPreset()
        '닫기
        Close()

    End Sub

    Private Sub AddPresetFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
        If My.Computer.FileSystem.FileExists(FunctionCls.AppInfoDirectoryPath & "\lang\" & LangXMLFV) = False Then
            MsgBox(LangXMLFV & " not found")
            GoTo LANG_SKIP
        End If

        Dim SR As New StreamReader(FunctionCls.AppInfoDirectoryPath & "\lang\" & LangXMLFV, System.Text.Encoding.UTF8)
        Dim XTR As New System.Xml.XmlTextReader(SR)
        Try
            Dim FN As String = Me.Font.Name, FNXP As String = Me.Font.Name, FS As Single = Me.Font.Size
            Do While XTR.Read
                Application.DoEvents()

                If XTR.Name = "FontName" Then FN = XTR.ReadString
                If XTR.Name = "FontNameXP" Then FNXP = XTR.ReadString
                If XTR.Name = "FontSize" Then FS = XTR.ReadString

                If Environment.OSVersion.Version.Major < 6 Then 'NT 5.X 이하
                    AP_Panel.Font = New Font(FNXP, FS)
                Else
                    AP_Panel.Font = New Font(FN, FS)
                End If

                If XTR.Name = "OKBTN" Then OKBTN.Text = XTR.ReadString
                If XTR.Name = "CancelBTN" Then CancelBTN.Text = XTR.ReadString

                If XTR.Name = "AddPresetFrm" Then Me.Text = XTR.ReadString
                If XTR.Name = "AddPresetFrmNameLabel" Then NameLabel.Text = XTR.ReadString
                If XTR.Name = "AddPresetCharERR" Then LangCls.AddPresetCharERR = XTR.ReadString
                If XTR.Name = "AddPresetEmptyERR" Then LangCls.AddPresetEmptyERR = XTR.ReadString

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