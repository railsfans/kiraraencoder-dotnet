﻿' ---------------------------------------------------------------------------------------
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

Imports KiraraEncoder.AvisynthWrapper
Imports System.IO
Imports System.Xml

Public Class AviSynthEditorFrm

    'wait
    Dim waitbool As Boolean = False
    Dim shellpid As Integer

    'ListenButtonP
    Public ListenButtonP As Boolean = False

    Private Sub ImgSButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImgSButton.Click
        ImagePPFrm.ShowDialog(Me)
    End Sub

    Private Sub AudSButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AudSButton.Click
        AudioPPFrm.ShowDialog(Me)
    End Sub

    Private Sub SubSButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubSButton.Click
        SubtitleFrm.ShowDialog(Me)
    End Sub

    Private Sub PreviewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreviewButton.Click

        '선택된 아이템이 없으면 종료
        If MainFrm.EncListListView.SelectedItems.Count = 0 Then
            MsgBox(LangCls.MainSelectListA)
            Exit Sub
        End If

        AviSynthPP.AviSynthPreprocess(MainFrm.SelIndex, True, Nothing, False)
        If AviSynthPP.INDEX_ProcessStopChk = True Then
            AviSynthPP.INDEX_ProcessStopChk = False
        Else
            VideoWindowFrm.Close()
            VideoWindowFrm.Show(Me)
        End If

    End Sub

    Private Sub RefButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefButton.Click
        waitbool = True
        VideoWindowFrm.Ref_SUB()
        waitbool = False
    End Sub

    Private Sub AviSynthEditorFrm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        '새로고침 상태면 닫기 취소.
        If waitbool = True Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If

        If shellpid <> 0 Then
            Try
                If Process.GetProcessById(shellpid).HasExited = False Then
                    Process.GetProcessById(shellpid).Kill()
                End If
            Catch ex As Exception
            End Try
        End If


        Do Until VideoWindowFrm.Visible = False
            VideoWindowFrm.Close()
        Loop

    End Sub

    Private Sub Get_LineCol(ByVal AVSTextBoxV As TextBox)
        If AVSTextBoxV.SelectionStart - AVSTextBoxV.GetFirstCharIndexOfCurrentLine + 1 < 0 Then
        Else
            LineColToolStripStatusLabel.Text = "   Line " & AVSTextBoxV.GetLineFromCharIndex(AVSTextBoxV.SelectionStart) + 1 & _
                                               ", Col " & AVSTextBoxV.SelectionStart - AVSTextBoxV.GetFirstCharIndexOfCurrentLine + 1
        End If
    End Sub

    Private Sub AVS_XML_LOAD(ByVal src As String)


        Dim SR As New StreamReader(src, System.Text.Encoding.UTF8)
        Dim XTR As New System.Xml.XmlTextReader(SR)

        Try

            Do While XTR.Read
                Application.DoEvents()

                If XTR.Name = "AviSynthEditorFrm_FFmpegSourceTextBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then FFmpegSourceTextBox.Text = XTRSTR Else FFmpegSourceTextBox.Text = Def_FFmpegSourceTextBox.Text
                End If

                If XTR.Name = "AviSynthEditorFrm_MPEG2SourceTextBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then MPEG2SourceTextBox.Text = XTRSTR Else MPEG2SourceTextBox.Text = Def_MPEG2SourceTextBox.Text
                End If

                If XTR.Name = "AviSynthEditorFrm_BassAudioTextBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then BassAudioTextBox.Text = XTRSTR Else BassAudioTextBox.Text = Def_BassAudioTextBox.Text
                End If

                If XTR.Name = "AviSynthEditorFrm_NicAudioTextBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then NicAudioTextBox.Text = XTRSTR Else NicAudioTextBox.Text = Def_NicAudioTextBox.Text
                End If

                If XTR.Name = "AviSynthEditorFrm_ChannelTextBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then ChannelTextBox.Text = XTRSTR Else ChannelTextBox.Text = Def_ChannelTextBox.Text
                End If

            Loop

        Catch ex As Exception
            MsgBox("XML_LOAD_ERROR :" & ex.Message)
        Finally
            XTR.Close()
        End Try

    End Sub

    Private Sub AVS_XML_CHANGE(ByVal src As String)

        Try
            Dim XDoc As New XmlDocument()
            Dim XNode As XmlNode
            XDoc.Load(src)
            '============== 시작

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/AviSynthEditorFrm_FFmpegSourceTextBox")
            If Not XNode Is Nothing Then XNode.InnerText = FFmpegSourceTextBox.Text

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/AviSynthEditorFrm_MPEG2SourceTextBox")
            If Not XNode Is Nothing Then XNode.InnerText = MPEG2SourceTextBox.Text

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/AviSynthEditorFrm_BassAudioTextBox")
            If Not XNode Is Nothing Then XNode.InnerText = BassAudioTextBox.Text

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/AviSynthEditorFrm_NicAudioTextBox")
            If Not XNode Is Nothing Then XNode.InnerText = NicAudioTextBox.Text

            XNode = XDoc.SelectSingleNode("/KiraraEncoderSettings/AviSynthEditorFrm_ChannelTextBox")
            If Not XNode Is Nothing Then XNode.InnerText = ChannelTextBox.Text

            '============== 끝
            XDoc.Save(src)
        Catch ex As Exception
            MsgBox("XML_CHANGE_ERROR :" & ex.Message)
        End Try

        'SAVE, Change용
        If MainFrm.EncListListView.SelectedItems.Count <> 0 Then
            Dim index As Integer = MainFrm.EncListListView.SelectedItems(index).Index
            MainFrm.GET_OutputINFO(index)  '출력정보
        End If
        'Change용 프리셋 설정된 파일 표시 지우기
        MainFrm.PresetLabel.Text = LangCls.MainUserStr

    End Sub

    Private Sub AviSynthEditorFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
                    AVSPanel.Font = New Font(FNXP, FS)
                Else
                    AVSPanel.Font = New Font(FN, FS)
                End If

                If XTR.Name = "OKBTN" Then OKBTN.Text = XTR.ReadString
                If XTR.Name = "CancelBTN" Then CancelBTN.Text = XTR.ReadString

                If XTR.Name = "AviSynthEditorFrm" Then Me.Text = XTR.ReadString
                If XTR.Name = "AviSynthEditorFrmFolderToolStripMenuItem" Then FolderToolStripMenuItem.Text = XTR.ReadString
                If XTR.Name = "AviSynthEditorFrmPluginToolStripMenuItem" Then PluginToolStripMenuItem.Text = XTR.ReadString
                If XTR.Name = "AviSynthEditorFrmToolsToolStripMenuItem" Then ToolsToolStripMenuItem.Text = XTR.ReadString
                If XTR.Name = "AviSynthEditorFrmInitializationToolStripMenuItem" Then InitializationToolStripMenuItem.Text = XTR.ReadString
                If XTR.Name = "AviSynthEditorFrmPresetToolStripMenuItem" Then PresetToolStripMenuItem.Text = XTR.ReadString
                If XTR.Name = "AviSynthEditorFrmImgSButton" Then ImgSButton.Text = XTR.ReadString
                If XTR.Name = "AviSynthEditorFrmAudSButton" Then AudSButton.Text = XTR.ReadString
                If XTR.Name = "AviSynthEditorFrmSubSButton" Then SubSButton.Text = XTR.ReadString
                If XTR.Name = "AviSynthEditorFrmPreviewButton" Then PreviewButton.Text = XTR.ReadString
                If XTR.Name = "AviSynthEditorFrmRefButton" Then RefButton.Text = XTR.ReadString
                If XTR.Name = "AviSynthEditorFrmListenButton" Then ListenButton.Text = XTR.ReadString
                If XTR.Name = "AviSynthEditorFrmFFmpegSourceLabel" Then FFmpegSourceLabel.Text = XTR.ReadString
                If XTR.Name = "AviSynthEditorFrmMPEG2SourceLabel" Then MPEG2SourceLabel.Text = XTR.ReadString
                If XTR.Name = "AviSynthEditorFrmBassAudioLabel" Then BassAudioLabel.Text = XTR.ReadString
                If XTR.Name = "AviSynthEditorFrmNicAudioLabel" Then NicAudioLabel.Text = XTR.ReadString
                If XTR.Name = "AviSynthEditorFrmChannelLabel" Then ChannelLabel.Text = XTR.ReadString
                If XTR.Name = "AviSynthEditorInitializationQ" Then LangCls.AviSynthEditorInitializationQ = XTR.ReadString

            Loop
        Catch ex As Exception
            MsgBox("LANG_LOAD_ERROR :" & ex.Message)
        Finally
            XTR.Close()
        End Try
LANG_SKIP:
        '=========================================

        AVS_XML_LOAD(My.Application.Info.DirectoryPath & "\avs_settings.xml")

    End Sub

    Private Sub ListenButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListenButton.Click

        '선택된 아이템이 없으면 종료
        If MainFrm.EncListListView.SelectedItems.Count = 0 Then
            MsgBox(LangCls.MainSelectListA)
            Exit Sub
        End If

        ListenButtonP = True
        Try
            ListenButton.Enabled = False
            Dim MSGB As String = ""
            Dim _AviSynthScriptEnvironment As New AvisynthWrapper.AviSynthScriptEnvironment()
            Dim _AviSynthClip As AvisynthWrapper.AviSynthClip

            AviSynthPP.AviSynthPreprocess(MainFrm.SelIndex, True, Nothing, False)
            If AviSynthPP.INDEX_ProcessStopChk = True Then
                AviSynthPP.INDEX_ProcessStopChk = False
                ListenButton.Enabled = True
            Else
                _AviSynthClip = _AviSynthScriptEnvironment.OpenScriptFile(My.Application.Info.DirectoryPath & "\temp\AviSynthScript.avs")
                _AviSynthClip.IDisposable_Dispose()
                MSGB = My.Application.Info.DirectoryPath & "\tools\mplayer\mplayer-" & MainFrm.MPLAYEREXESTR & ".exe " & Chr(34) & My.Application.Info.DirectoryPath & "\temp\AviSynthScript.avs" & Chr(34) & _
                " -identify -noquiet -nofontconfig -novideo"
                shellpid = Shell(MSGB, AppWinStyle.NormalFocus)
                ProcessDetTimer.Enabled = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            ListenButton.Enabled = True
        End Try
        ListenButtonP = False
    End Sub

    Private Sub FFmpegSourceTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles FFmpegSourceTextBox.KeyDown
        Get_LineCol(FFmpegSourceTextBox)
    End Sub

    Private Sub FFmpegSourceTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FFmpegSourceTextBox.KeyPress
        Get_LineCol(FFmpegSourceTextBox)
    End Sub

    Private Sub FFmpegSourceTextBox_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles FFmpegSourceTextBox.KeyUp
        Get_LineCol(FFmpegSourceTextBox)
    End Sub

    Private Sub FFmpegSourceTextBox_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles FFmpegSourceTextBox.MouseDown
        Get_LineCol(FFmpegSourceTextBox)
    End Sub

    Private Sub FFmpegSourceTextBox_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles FFmpegSourceTextBox.MouseMove
        Get_LineCol(FFmpegSourceTextBox)
    End Sub

    Private Sub FFmpegSourceTextBox_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles FFmpegSourceTextBox.MouseUp
        Get_LineCol(FFmpegSourceTextBox)
    End Sub

    Private Sub FFmpegSourceTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FFmpegSourceTextBox.TextChanged

    End Sub

    Private Sub BassAudioTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BassAudioTextBox.KeyDown
        Get_LineCol(BassAudioTextBox)
    End Sub

    Private Sub BassAudioTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles BassAudioTextBox.KeyPress
        Get_LineCol(BassAudioTextBox)
    End Sub

    Private Sub BassAudioTextBox_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BassAudioTextBox.KeyUp
        Get_LineCol(BassAudioTextBox)
    End Sub

    Private Sub BassAudioTextBox_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BassAudioTextBox.MouseDown
        Get_LineCol(BassAudioTextBox)
    End Sub

    Private Sub BassAudioTextBox_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BassAudioTextBox.MouseMove
        Get_LineCol(BassAudioTextBox)
    End Sub

    Private Sub BassAudioTextBox_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BassAudioTextBox.MouseUp
        Get_LineCol(BassAudioTextBox)
    End Sub

    Private Sub BassAudioTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BassAudioTextBox.TextChanged

    End Sub

    Private Sub NicAudioTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles NicAudioTextBox.KeyDown
        Get_LineCol(NicAudioTextBox)
    End Sub

    Private Sub NicAudioTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NicAudioTextBox.KeyPress
        Get_LineCol(NicAudioTextBox)
    End Sub

    Private Sub NicAudioTextBox_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles NicAudioTextBox.KeyUp
        Get_LineCol(NicAudioTextBox)
    End Sub

    Private Sub NicAudioTextBox_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NicAudioTextBox.MouseDown
        Get_LineCol(NicAudioTextBox)
    End Sub

    Private Sub NicAudioTextBox_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NicAudioTextBox.MouseMove
        Get_LineCol(NicAudioTextBox)
    End Sub

    Private Sub NicAudioTextBox_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NicAudioTextBox.MouseUp
        Get_LineCol(NicAudioTextBox)
    End Sub

    Private Sub NicAudioTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NicAudioTextBox.TextChanged

    End Sub

    Private Sub ChannelTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ChannelTextBox.KeyDown
        Get_LineCol(ChannelTextBox)
    End Sub

    Private Sub ChannelTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ChannelTextBox.KeyPress
        Get_LineCol(ChannelTextBox)
    End Sub

    Private Sub ChannelTextBox_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ChannelTextBox.KeyUp
        Get_LineCol(ChannelTextBox)
    End Sub

    Private Sub ChannelTextBox_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ChannelTextBox.MouseDown
        Get_LineCol(ChannelTextBox)
    End Sub

    Private Sub ChannelTextBox_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ChannelTextBox.MouseMove
        Get_LineCol(ChannelTextBox)
    End Sub

    Private Sub ChannelTextBox_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ChannelTextBox.MouseUp
        Get_LineCol(ChannelTextBox)
    End Sub

    Private Sub ChannelTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChannelTextBox.TextChanged

    End Sub

    Private Sub ProcessDetTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcessDetTimer.Tick
        Try
            If Process.GetProcessById(shellpid).HasExited = False Then
                ListenButton.Enabled = False
            End If
        Catch ex As Exception
            Debug.Print("미리듣기 끝 " & ex.Message)
            shellpid = 0
            ProcessDetTimer.Enabled = False
            ListenButton.Enabled = True
        End Try
    End Sub

    Private Sub MPEG2SourceTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MPEG2SourceTextBox.KeyDown
        Get_LineCol(MPEG2SourceTextBox)
    End Sub

    Private Sub MPEG2SourceTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MPEG2SourceTextBox.KeyPress
        Get_LineCol(MPEG2SourceTextBox)
    End Sub

    Private Sub MPEG2SourceTextBox_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MPEG2SourceTextBox.KeyUp
        Get_LineCol(MPEG2SourceTextBox)
    End Sub

    Private Sub MPEG2SourceTextBox_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MPEG2SourceTextBox.MouseDown
        Get_LineCol(MPEG2SourceTextBox)
    End Sub

    Private Sub MPEG2SourceTextBox_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MPEG2SourceTextBox.MouseMove
        Get_LineCol(MPEG2SourceTextBox)
    End Sub

    Private Sub MPEG2SourceTextBox_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MPEG2SourceTextBox.MouseUp
        Get_LineCol(MPEG2SourceTextBox)
    End Sub

    Private Sub MPEG2SourceTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MPEG2SourceTextBox.TextChanged

    End Sub

    Private Sub ScriptTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ScriptTextBox.KeyDown
        Get_LineCol(ScriptTextBox)
    End Sub

    Private Sub ScriptTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ScriptTextBox.KeyPress
        Get_LineCol(ScriptTextBox)
    End Sub

    Private Sub ScriptTextBox_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ScriptTextBox.KeyUp
        Get_LineCol(ScriptTextBox)
    End Sub

    Private Sub ScriptTextBox_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ScriptTextBox.MouseDown
        Get_LineCol(ScriptTextBox)
    End Sub

    Private Sub ScriptTextBox_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ScriptTextBox.MouseMove
        Get_LineCol(ScriptTextBox)
    End Sub

    Private Sub ScriptTextBox_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ScriptTextBox.MouseUp
        Get_LineCol(ScriptTextBox)
    End Sub

    Private Sub ScriptTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScriptTextBox.TextChanged

    End Sub

    Private Sub PluginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PluginToolStripMenuItem.Click
        Process.Start("explorer.exe", My.Application.Info.DirectoryPath & "\plugin")
    End Sub

    Private Sub ToolsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolsToolStripMenuItem.Click
        Process.Start("explorer.exe", My.Application.Info.DirectoryPath & "\tools")
    End Sub

    Private Sub PresetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PresetToolStripMenuItem.Click
        MainFrm.PresetContextMenuStrip.Show(Control.MousePosition)
    End Sub

    Private Sub InitializationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InitializationToolStripMenuItem.Click

        Dim MSGV = MessageBox.Show(TabControl1.SelectedTab.Text & vbNewLine & LangCls.AviSynthEditorInitializationQ, Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If MSGV = Windows.Forms.DialogResult.Yes Then
            If TabControl1.SelectedTab.Text = "FFmpegSource" Then
                FFmpegSourceTextBox.Text = Def_FFmpegSourceTextBox.Text
            ElseIf TabControl1.SelectedTab.Text = "MPEG2Source" Then
                MPEG2SourceTextBox.Text = Def_MPEG2SourceTextBox.Text
            ElseIf TabControl1.SelectedTab.Text = "BassAudio" Then
                BassAudioTextBox.Text = Def_BassAudioTextBox.Text
            ElseIf TabControl1.SelectedTab.Text = "NicAudio" Then
                NicAudioTextBox.Text = Def_NicAudioTextBox.Text
            ElseIf TabControl1.SelectedTab.Text = "Channel" Then
                ChannelTextBox.Text = Def_ChannelTextBox.Text
            End If
        Else
            Exit Sub
        End If
        '설정저장//
        AVS_XML_CHANGE(My.Application.Info.DirectoryPath & "\avs_settings.xml")

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedTab.Text = "Script" Then
            InitializationToolStripMenuItem.Enabled = False
        Else
            InitializationToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub OKBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKBTN.Click
        AVS_XML_CHANGE(My.Application.Info.DirectoryPath & "\avs_settings.xml")
        Close()
    End Sub

    Private Sub CancelBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBTN.Click
        Close()
    End Sub

End Class