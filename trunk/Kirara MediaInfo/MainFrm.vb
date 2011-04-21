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

Public Class MainFrm

    Dim FormTXT As String = "Kirara MediaInfo"

    Private Sub FileInfoForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '어플리케이션 설정
        If Environ("PROCESSOR_ARCHITECTURE") = "AMD64" Then
            Me.Text = "Kirara MediaInfo v" & _
            My.Application.Info.Version.Major & "." & _
            My.Application.Info.Version.Minor & "." & _
            My.Application.Info.Version.Revision & " x64"
        Else
            Me.Text = "Kirara MediaInfo v" & _
            My.Application.Info.Version.Major & "." & _
            My.Application.Info.Version.Minor & "." & _
            My.Application.Info.Version.Revision
        End If
        FormTXT = Me.Text
        Me.Show()
        OpenMF(True)

    End Sub

    Private Sub OpenMF(ByVal LoadB As Boolean)

        '//명령 ( 맨 마지막 부분에만 삽입 ㅇㅅㅇ )
        Dim CommandV As String = ""
        If Command() <> "" AndAlso LoadB = True Then
            CommandV = Command()
            CommandV = Replace(CommandV, Chr(34) & " ", "")
            CommandV = Replace(CommandV, Chr(34), "")
        Else
            OpenFileDialog1.FileName = ""
            OpenFileDialog1.Filter = "Supported Files|*.avs;*.3g2;*.3gp;*.asf;*.avi;*.flv;*.k3g;*.m2t;*.m2ts;*.mkv;*.mov;*.mpg;*.mpeg;*.mp4;*.mts;*.rm;*.skm;*.wmv;*.tp;*.trp;*.ts;*.tta;*.m2ts;*.m2v;*.mpv;*.pva;*.rmvb;*.vob;*.vro;*.aac;*.ac3;*.amr;*.dts;*.flac;*.m4a;*.mp2;*.mp3;*.mp4;*.ogg;*.ra;*.ram;*.wav;*.webm;*.wma;*.wv|" & _
                                     "Video Files|*.avs;*.3g2;*.3gp;*.asf;*.avi;*.flv;*.k3g;*.m2t;*.m2ts;*.mkv;*.mov;*.mpg;*.mpeg;*.mp4;*.mts;*.rm;*.skm;*.wmv;*.tp;*.trp;*.ts;*.m2ts;*.m2v;*.mpv;*.pva;*.rmvb;*.vob;*.vro;*.webm|" & _
                                     "Audio Files|*.avs;*.aac;*.ac3;*.amr;*.dts;*.flac;*.m4a;*.mp2;*.mp3;*.mp4;*.ogg;*.ra;*.ram;*.tta;*.wav;*.wma;*.wv|" & _
                                     "All Files(*.*)|*.*"
            OpenFileDialog1.ShowDialog(Me)
            If OpenFileDialog1.FileName = "" Then
                Exit Sub
            End If
            CommandV = OpenFileDialog1.FileName
        End If
        GET_TXT(CommandV)

    End Sub

    Public Sub GET_TXT(ByVal Path As String)

        Dim MI As MediaInfo
        MI = New MediaInfo
        Dim To_Display As String = ""
        To_Display = MI.Option_("Info_Version", "0.7.0.0;MediaInfoDLL_Example_MSVB;0.7.0.0") + vbCrLf + vbCrLf
        If (To_Display.Length() = 0) Then
            FileInfoTextBox.Text = "MediaInfo.Dll: this version of the DLL is not compatible"
            Return
        End If
        Try
            MI.Open(Path)
            Me.Text = Mid(Path, InStrRev(Path, "\") + 1) & " - " & FormTXT
            MI.Option_("Complete")
            To_Display += MI.Inform()
            MI.Close()
        Catch ex As Exception
            MI.Close()
        End Try
        FileInfoTextBox.Text = To_Display
        FileInfoTextBox.SelectionStart = 0

    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        OpenMF(False)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutFrm.ShowDialog(Me)
    End Sub
End Class