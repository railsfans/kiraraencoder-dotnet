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

Imports KiraraEncoder.AvisynthWrapper
Imports System.IO
Imports System.Xml

Public Class AviSynthEditorFrm

    Dim OKBTNCLK As Boolean = False

    'wait
    Public waitbool As Boolean = False
    Dim shellpid As Integer
    Dim shellpid2 As Integer

    'ListenButtonP
    Public ListenButtonP As Boolean = False

    Private Sub ImgSButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImgSButton.Click

        Try
            ImagePPFrm.ShowDialog(Me)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub AudSButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AudSButton.Click

        Try
            AudioPPFrm.ShowDialog(Me)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub SubSButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubSButton.Click

        Try
            SubtitleFrm.ShowDialog(Me)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub PreviewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreviewButton.Click

        TabControl1.Focus()

        '선택된 아이템이 없으면 종료
        If MainFrm.EncListListView.SelectedItems.Count = 0 Then
            MsgBox(LangCls.MainSelectListA)
            Exit Sub
        End If

        PreviewButton.Enabled = False

        AviSynthPP.AviSynthPreprocess(MainFrm.SelIndex, True, Nothing, False, False)
        If AviSynthPP.INDEX_ProcessStopChk = True Then
            AviSynthPP.INDEX_ProcessStopChk = False
            PreviewButton.Enabled = True
        Else

            '구별//
            If MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(3).Text = "MPEGTS" OrElse MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(3).Text = "MPEG" Then

                If InStr(MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(8).Text, "h264", CompareMethod.Text) <> 0 OrElse _
                   InStr(MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(8).Text, "vc1", CompareMethod.Text) <> 0 Then 'AVC, VC1
                    Dim MSGB As String = ""
                    MSGB = My.Application.Info.DirectoryPath & "\tools\mplayer\mplayer-" & MainFrm.MPLAYEREXESTR & ".exe " & Chr(34) & My.Application.Info.DirectoryPath & "\temp\AviSynthScript.avs" & Chr(34) & _
                    " -identify -noquiet -nofontconfig -nosound -vo direct3d"
                    shellpid2 = Shell(MSGB, AppWinStyle.NormalFocus)
                    ProcessDetTimer2.Enabled = True
                Else
                    VideoWindowFrm.Close()
                    VideoWindowFrm.Show(Me)
                End If

            Else
                VideoWindowFrm.Close()
                VideoWindowFrm.Show(Me)
            End If

        End If

    End Sub

    Private Sub RefButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefButton.Click

        TabControl1.Focus()

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

        If shellpid2 <> 0 Then
            Try
                If Process.GetProcessById(shellpid2).HasExited = False Then
                    Process.GetProcessById(shellpid2).Kill()
                End If
            Catch ex As Exception
            End Try
        End If

        Do Until VideoWindowFrm.Visible = False
            VideoWindowFrm.Close()
        Loop

        If OKBTNCLK = False Then AVS_XML_LOAD(My.Application.Info.DirectoryPath & "\avs_settings.xml")

    End Sub

    Private Sub Get_LineCol(ByVal AVSTextBoxV As TextBox)
        If AVSTextBoxV.SelectionStart - AVSTextBoxV.GetFirstCharIndexOfCurrentLine + 1 < 0 Then
        Else
            LineColToolStripStatusLabel.Text = "   Line " & AVSTextBoxV.GetLineFromCharIndex(AVSTextBoxV.SelectionStart) + 1 & _
                                               ", Col " & AVSTextBoxV.SelectionStart - AVSTextBoxV.GetFirstCharIndexOfCurrentLine + 1
        End If
    End Sub

    Private Sub AVS_XML_LOAD(ByVal src As String)

        '접근권한이 있을 때 까지 반복
        If My.Computer.FileSystem.FileExists(src) = True Then
RELOAD:
            Try
                Dim _SRL As New StreamReader(src, System.Text.Encoding.UTF8)
                _SRL.Close()
            Catch ex As Exception
                GoTo RELOAD
            End Try
        End If

        Dim SR As New StreamReader(src, System.Text.Encoding.UTF8)
        Dim XTR As New System.Xml.XmlTextReader(SR)

        Try

            Do While XTR.Read
                Application.DoEvents()

                If XTR.Name = "AviSynthEditorFrm_FFmpegSourceTextBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then FFmpegSourceTextBox.Text = XTRSTR Else FFmpegSourceTextBox.Text = Def_FFmpegSourceTextBox.Text
                End If

                If XTR.Name = "AviSynthEditorFrm_ASFTextBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then ASFTextBox.Text = XTRSTR Else ASFTextBox.Text = Def_ASFTextBox.Text
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

                If XTR.Name = "AviSynthEditorFrm_AVCTextBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then AVCTextBox.Text = XTRSTR Else AVCTextBox.Text = Def_AVCTextBox.Text
                End If

                If XTR.Name = "AviSynthEditorFrm_VC1TextBox" Then
                    Dim XTRSTR As String = XTR.ReadString
                    If XTRSTR <> "" Then VC1TextBox.Text = XTRSTR Else VC1TextBox.Text = Def_VC1TextBox.Text
                End If

            Loop

        Catch ex As Exception
            MsgBox("XML_LOAD_ERROR :" & ex.Message)
        Finally
            XTR.Close()
        End Try

    End Sub

    Private Sub AviSynthEditorFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        OKBTNCLK = False

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
                If XTR.Name = "AviSynthEditorFrmAVCLabel" Then AVCLabel.Text = XTR.ReadString
                If XTR.Name = "AviSynthEditorFrmVC1Label" Then VC1Label.Text = XTR.ReadString
                If XTR.Name = "AviSynthEditorFrmASFLabel" Then ASFLabel.Text = XTR.ReadString

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

        TabControl1.Focus()

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

            AviSynthPP.AviSynthPreprocess(MainFrm.SelIndex, True, Nothing, False, True)
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
            ElseIf TabControl1.SelectedTab.Text = "ASF/WMV" Then
                ASFTextBox.Text = Def_ASFTextBox.Text
            ElseIf TabControl1.SelectedTab.Text = "MPEG2Source" Then
                MPEG2SourceTextBox.Text = Def_MPEG2SourceTextBox.Text
            ElseIf TabControl1.SelectedTab.Text = "BassAudio" Then
                BassAudioTextBox.Text = Def_BassAudioTextBox.Text
            ElseIf TabControl1.SelectedTab.Text = "NicAudio" Then
                NicAudioTextBox.Text = Def_NicAudioTextBox.Text
            ElseIf TabControl1.SelectedTab.Text = "Channel" Then
                ChannelTextBox.Text = Def_ChannelTextBox.Text
            ElseIf TabControl1.SelectedTab.Text = "MPEG/MPEGTS(AVC)" Then
                AVCTextBox.Text = Def_AVCTextBox.Text
            ElseIf TabControl1.SelectedTab.Text = "MPEG/MPEGTS(VC1)" Then
                VC1TextBox.Text = Def_VC1TextBox.Text
            End If
        Else
            Exit Sub
        End If
        '설정저장//
        MainFrm.AVS_XML_SAVE(My.Application.Info.DirectoryPath & "\avs_settings.xml")

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedTab.Text = "Script" Then
            InitializationToolStripMenuItem.Enabled = False
        Else
            InitializationToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub OKBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKBTN.Click
        OKBTNCLK = True

        MainFrm.AVS_XML_SAVE(My.Application.Info.DirectoryPath & "\avs_settings.xml")
        Close()
    End Sub

    Private Sub CancelBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBTN.Click
        Close()
    End Sub

    Private Sub AVCTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles AVCTextBox.KeyDown
        Get_LineCol(AVCTextBox)
    End Sub

    Private Sub AVCTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AVCTextBox.KeyPress
        Get_LineCol(AVCTextBox)
    End Sub

    Private Sub AVCTextBox_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles AVCTextBox.KeyUp
        Get_LineCol(AVCTextBox)
    End Sub

    Private Sub AVCTextBox_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles AVCTextBox.MouseDown
        Get_LineCol(AVCTextBox)
    End Sub

    Private Sub AVCTextBox_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles AVCTextBox.MouseMove
        Get_LineCol(AVCTextBox)
    End Sub

    Private Sub AVCTextBox_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles AVCTextBox.MouseUp
        Get_LineCol(AVCTextBox)
    End Sub

    Private Sub AVCTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AVCTextBox.TextChanged

    End Sub

    Private Sub VC1TextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles VC1TextBox.KeyDown
        Get_LineCol(VC1TextBox)
    End Sub

    Private Sub VC1TextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles VC1TextBox.KeyPress
        Get_LineCol(VC1TextBox)
    End Sub

    Private Sub VC1TextBox_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles VC1TextBox.KeyUp
        Get_LineCol(VC1TextBox)
    End Sub

    Private Sub VC1TextBox_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles VC1TextBox.MouseDown
        Get_LineCol(VC1TextBox)
    End Sub

    Private Sub VC1TextBox_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles VC1TextBox.MouseMove
        Get_LineCol(VC1TextBox)
    End Sub

    Private Sub VC1TextBox_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles VC1TextBox.MouseUp
        Get_LineCol(VC1TextBox)
    End Sub

    Private Sub VC1TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VC1TextBox.TextChanged

    End Sub

    Private Sub ASFTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ASFTextBox.KeyDown
        Get_LineCol(ASFTextBox)
    End Sub

    Private Sub ASFTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ASFTextBox.KeyPress
        Get_LineCol(ASFTextBox)
    End Sub

    Private Sub ASFTextBox_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ASFTextBox.KeyUp
        Get_LineCol(ASFTextBox)
    End Sub

    Private Sub ASFTextBox_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ASFTextBox.MouseDown
        Get_LineCol(ASFTextBox)
    End Sub

    Private Sub ASFTextBox_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ASFTextBox.MouseMove
        Get_LineCol(ASFTextBox)
    End Sub

    Private Sub ASFTextBox_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ASFTextBox.MouseUp
        Get_LineCol(ASFTextBox)
    End Sub

    Private Sub ASFTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ASFTextBox.TextChanged

    End Sub

    Private Sub ProcessDetTimer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcessDetTimer2.Tick
        Try
            If Process.GetProcessById(shellpid2).HasExited = False Then
                PreviewButton.Enabled = False
            End If
        Catch ex As Exception
            Debug.Print("미리보기 끝 " & ex.Message)
            shellpid2 = 0
            ProcessDetTimer2.Enabled = False
            PreviewButton.Enabled = True
        End Try
    End Sub
End Class