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

Imports KiraraEncoder.AvisynthWrapper
Imports System.IO
Imports System.Xml

Public Class AviSynthEditorFrm

    Dim OKBTNCLK As Boolean = False
    Dim ListenButtonSTR As String = ""

    'wait
    Public waitbool As Boolean = False
    Dim shellpid As Integer
    Dim shellpidexename As String
    Dim shellpidstarttime As String

    Private Sub ImgSButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImgSButton.Click

        If MainFrm.SPreB = True Then Exit Sub

        Try
            ImagePPFrm.ShowDialog(Me)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub AudSButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AudSButton.Click

        If MainFrm.SPreB = True Then Exit Sub

        Try
            AudioPPFrm.ShowDialog(Me)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub SubSButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubSButton.Click

        If MainFrm.SPreB = True Then Exit Sub

        Try
            SubtitleFrm.ShowDialog(Me)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub PreviewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreviewButton.Click

        If MainFrm.SPreB = True Then Exit Sub

        TabControl1.Focus()

        '선택된 아이템이 없으면 종료
        If MainFrm.EncListListView.SelectedItems.Count = 0 Then
            MsgBox(LangCls.MainSelectListA)
            Exit Sub
        End If

        '인덱스 -1 에러방지
        If MainFrm.SelIndex = -1 Then Exit Sub

        PreviewButton.Enabled = False

        Try
            AviSynthPP.AviSynthPreprocess(MainFrm.SelIndex, True, Nothing, False, False)
        Catch ex As Exception
            MsgBox(ex.Message)
            PreviewButton.Enabled = True
            Exit Sub
        End Try

        If AviSynthPP.INDEX_ProcessStopChk = True Then
            AviSynthPP.INDEX_ProcessStopChk = False
            PreviewButton.Enabled = True
        Else
            If MainFrm.SEEKMODEM1B = True Then
                PreviewButton.Enabled = True
                If ListenButton.Enabled = True Then
                    ListenButton_Click(Nothing, Nothing)
                End If
            Else
                VideoWindowFrm.Close()
                VideoWindowFrm.Show(Me)
            End If
        End If

    End Sub

    Private Sub RefButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefButton.Click

        If MainFrm.SPreB = True Then Exit Sub

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
                If Process.GetProcessById(shellpid).ProcessName = shellpidexename Then '잘못된 프로그램 종료 방지를 위해 프로세스 이름 비교
                    If InStr(Process.GetProcessById(shellpid).StartTime, shellpidstarttime, CompareMethod.Text) = 1 Then '잘못된 프로그램 종료 방지를 위해 프로세스 시작 시간 비교
                        If Process.GetProcessById(shellpid).HasExited = False Then
                            Process.GetProcessById(shellpid).CloseMainWindow()
                            shellpid = 0
                        End If
                    End If
                End If
            Catch ex As Exception
                Debug.Print("프로세스 실행중이지 않음!")
                shellpid = 0
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
                    If XTRSTR <> "" Then DirectShowSourceTextBox.Text = XTRSTR Else DirectShowSourceTextBox.Text = Def_DirectShowSourceTextBox.Text
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
            SR.Close()
        End Try

    End Sub

    Private Sub AviSynthEditorFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        OKBTNCLK = False

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
                If XTR.Name = "AviSynthEditorFrmEtcSButton" Then etcSButton.Text = XTR.ReadString
                If XTR.Name = "AviSynthEditorFrmPreviewButton" Then PreviewButton.Text = XTR.ReadString
                If XTR.Name = "AviSynthEditorFrmRefButton" Then RefButton.Text = XTR.ReadString
                If XTR.Name = "AviSynthEditorFrmListenButton" Then
                    ListenButtonSTR = XTR.ReadString
                    ListenButton.Text = ListenButtonSTR
                End If
                If XTR.Name = "AviSynthEditorInitializationQ" Then LangCls.AviSynthEditorInitializationQ = XTR.ReadString

            Loop
        Catch ex As Exception
            MsgBox("LANG_LOAD_ERROR :" & ex.Message)
        Finally
            XTR.Close()
            SR.Close()
        End Try
LANG_SKIP:
        '=========================================

        StatusLabel.Text = ""
        PreviewButton.Enabled = True
        RefButton.Enabled = False
        ListenButton.Enabled = True

        AVS_XML_LOAD(My.Application.Info.DirectoryPath & "\avs_settings.xml")

    End Sub

    Private Sub ListenButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListenButton.Click

        If MainFrm.SPreB = True Then Exit Sub

        If shellpid <> 0 Then
            Try
                If Process.GetProcessById(shellpid).ProcessName = shellpidexename Then '잘못된 프로그램 종료 방지를 위해 프로세스 이름 비교
                    If InStr(Process.GetProcessById(shellpid).StartTime, shellpidstarttime, CompareMethod.Text) = 1 Then '잘못된 프로그램 종료 방지를 위해 프로세스 시작 시간 비교
                        If Process.GetProcessById(shellpid).HasExited = False Then
                            Process.GetProcessById(shellpid).CloseMainWindow()
                            shellpid = 0
                        End If
                    End If
                End If
            Catch ex As Exception
                Debug.Print("프로세스 실행중이지 않음!")
                shellpid = 0
            End Try
        End If

        TabControl1.Focus()

        '선택된 아이템이 없으면 종료
        If MainFrm.EncListListView.SelectedItems.Count = 0 Then
            MsgBox(LangCls.MainSelectListA)
            Exit Sub
        End If

        '인덱스 -1 에러방지
        If MainFrm.SelIndex = -1 Then Exit Sub

        Try
            ListenButton.Enabled = False
            Dim _AviSynthScriptEnvironment As New AvisynthWrapper.AviSynthScriptEnvironment()
            Dim _AviSynthClip As AvisynthWrapper.AviSynthClip

            AviSynthPP.AviSynthPreprocess(MainFrm.SelIndex, True, Nothing, False, False)
            If AviSynthPP.INDEX_ProcessStopChk = True Then
                AviSynthPP.INDEX_ProcessStopChk = False
                ListenButton.Enabled = True
            Else
                _AviSynthClip = _AviSynthScriptEnvironment.OpenScriptFile(My.Application.Info.DirectoryPath & "\temp\AviSynthScript(" & MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(13).Text & ").avs")
                _AviSynthClip.IDisposable_Dispose()
                Dim MSGB As String = ""

                If MainFrm.SEEKMODEM1B = True Then
                    ListenButton.Text = "Playback"
                    MSGB = My.Application.Info.DirectoryPath & "\tools\mplayer\mplayer-" & MainFrm.MPLAYEREXESTR & ".exe " & Chr(34) & My.Application.Info.DirectoryPath & "\temp\AviSynthScript(" & MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(13).Text & ").avs" & Chr(34) & _
                    " -identify -noquiet -nofontconfig -vo direct3d"
                Else
                    ListenButton.Text = ListenButtonSTR
                    If MainFrm.DECSTR = "DSHOW" Then
                        MSGB = My.Application.Info.DirectoryPath & "\kiraraplayer.exe " & Chr(34) & My.Application.Info.DirectoryPath & "\temp\AviSynthScript(" & MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(13).Text & ").avs" & Chr(34)
                    Else
                        MSGB = My.Application.Info.DirectoryPath & "\tools\mplayer\mplayer-" & MainFrm.MPLAYEREXESTR & ".exe " & Chr(34) & My.Application.Info.DirectoryPath & "\temp\AviSynthScript(" & MainFrm.EncListListView.Items(MainFrm.SelIndex).SubItems(13).Text & ").avs" & Chr(34) & _
                                      " -identify -noquiet -nofontconfig -novideo"
                    End If

                End If

                shellpid = Shell(MSGB, AppWinStyle.NormalFocus)
                shellpidexename = Process.GetProcessById(shellpid).ProcessName
                shellpidstarttime = Process.GetProcessById(shellpid).StartTime
                ProcessDetTimer.Enabled = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ListenButton.Enabled = True

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
        'Try
        '    If Process.GetProcessById(shellpid).HasExited = False Then
        '        ListenButton.Enabled = False
        '    End If
        'Catch ex As Exception
        '    Debug.Print("재생 끝 " & ex.Message)
        '    shellpid = 0
        '    ProcessDetTimer.Enabled = False
        '    ListenButton.Enabled = True
        'End Try
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
        If MainFrm.SPreB = True Then Exit Sub
        MainFrm.PresetContextMenuStrip.Show(Control.MousePosition)
    End Sub

    Private Sub InitializationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InitializationToolStripMenuItem.Click

        Dim MSGV = MessageBox.Show(TabControl1.SelectedTab.Text & vbNewLine & LangCls.AviSynthEditorInitializationQ, Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If MSGV = Windows.Forms.DialogResult.Yes Then
            If TabControl1.SelectedTab.Text = "FFmpegSource" Then
                FFmpegSourceTextBox.Text = Def_FFmpegSourceTextBox.Text
            ElseIf TabControl1.SelectedTab.Text = "DirectShowSource" Then
                DirectShowSourceTextBox.Text = Def_DirectShowSourceTextBox.Text
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
        If MainFrm.SPreB = True Then Exit Sub
        OKBTNCLK = True
        MainFrm.AVS_XML_SAVE(My.Application.Info.DirectoryPath & "\avs_settings.xml")
        Close()
    End Sub

    Private Sub CancelBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBTN.Click
        If MainFrm.SPreB = True Then Exit Sub
        Close()
    End Sub

    Private Sub ASFTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DirectShowSourceTextBox.KeyDown
        Get_LineCol(DirectShowSourceTextBox)
    End Sub

    Private Sub ASFTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DirectShowSourceTextBox.KeyPress
        Get_LineCol(DirectShowSourceTextBox)
    End Sub

    Private Sub ASFTextBox_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DirectShowSourceTextBox.KeyUp
        Get_LineCol(DirectShowSourceTextBox)
    End Sub

    Private Sub ASFTextBox_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DirectShowSourceTextBox.MouseDown
        Get_LineCol(DirectShowSourceTextBox)
    End Sub

    Private Sub ASFTextBox_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DirectShowSourceTextBox.MouseMove
        Get_LineCol(DirectShowSourceTextBox)
    End Sub

    Private Sub ASFTextBox_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DirectShowSourceTextBox.MouseUp
        Get_LineCol(DirectShowSourceTextBox)
    End Sub

    Private Sub ETCButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EtcSButton.Click

        If MainFrm.SPreB = True Then Exit Sub

        Try
            ETCPPFrm.ShowDialog(Me)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub AllMovieFilesFFmpegSourceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllMovieFilesFFmpegSourceToolStripMenuItem.Click
        AllMovieFilesFFmpegSourceToolStripMenuItem.Checked = True
        AllMovieFilesDirectShowSourceToolStripMenuItem.Checked = False
    End Sub

    Private Sub AllMovieFilesDirectShowSourceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllMovieFilesDirectShowSourceToolStripMenuItem.Click
        AllMovieFilesFFmpegSourceToolStripMenuItem.Checked = False
        AllMovieFilesDirectShowSourceToolStripMenuItem.Checked = True
    End Sub

    Private Sub MPEGTSMPEGFilesFFmpegSourceToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MPEGTSMPEGFilesFFmpegSourceToolStripMenuItem1.Click
        MPEGTSMPEGFilesFFmpegSourceToolStripMenuItem1.Checked = True
        MPEGTSMPEGFilesMPEG2SourceToolStripMenuItem.Checked = False
        MPEGTSMPEGFilesDirectShowSourceToolStripMenuItem.Checked = False
    End Sub

    Private Sub MPEGTSMPEGFilesMPEG2SourceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MPEGTSMPEGFilesMPEG2SourceToolStripMenuItem.Click
        MPEGTSMPEGFilesFFmpegSourceToolStripMenuItem1.Checked = False
        MPEGTSMPEGFilesMPEG2SourceToolStripMenuItem.Checked = True
        MPEGTSMPEGFilesDirectShowSourceToolStripMenuItem.Checked = False
    End Sub

    Private Sub InitializationDSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InitializationDSToolStripMenuItem.Click
        AllMovieFilesFFmpegSourceToolStripMenuItem.Checked = True
        AllMovieFilesDirectShowSourceToolStripMenuItem.Checked = False
        MPEGTSMPEGFilesFFmpegSourceToolStripMenuItem1.Checked = False
        MPEGTSMPEGFilesMPEG2SourceToolStripMenuItem.Checked = True
        ASFFilesFFmpegSourceToolStripMenuItem2.Checked = False
        ASFFilesDirectShowSourceToolStripMenuItem1.Checked = True
        M2TSFilesFFmpegSourceToolStripMenuItem6.Checked = True
        AllAudioFilesFFmpegSourceToolStripMenuItem3.Checked = False
        AllAudioFilesBassAudioToolStripMenuItem.Checked = True
        AC3DTSFilesFFmpegSourceToolStripMenuItem4.Checked = False
        AC3DTSFilesNicAudioToolStripMenuItem.Checked = True
        RMAMRFilesFFmpegSourceToolStripMenuItem5.Checked = True
        MPEGTSMPEGFilesDirectShowSourceToolStripMenuItem.Checked = False
        M2TSFilesDirectShowSourceToolStripMenuItem1.Checked = False
        AllAudioFilesDirectShowSourceToolStripMenuItem.Checked = False
        AC3DTSFilesDirectShowSourceToolStripMenuItem1.Checked = False
        RMAMRFilesDirectShowSourceToolStripMenuItem2.Checked = False
    End Sub

    Private Sub ASFFilesFFmpegSourceToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ASFFilesFFmpegSourceToolStripMenuItem2.Click
        ASFFilesFFmpegSourceToolStripMenuItem2.Checked = True
        ASFFilesDirectShowSourceToolStripMenuItem1.Checked = False
    End Sub

    Private Sub ASFFilesDirectShowSourceToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ASFFilesDirectShowSourceToolStripMenuItem1.Click
        ASFFilesFFmpegSourceToolStripMenuItem2.Checked = False
        ASFFilesDirectShowSourceToolStripMenuItem1.Checked = True
    End Sub

    Private Sub M2TSFilesFFmpegSourceToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M2TSFilesFFmpegSourceToolStripMenuItem6.Click
        M2TSFilesFFmpegSourceToolStripMenuItem6.Checked = True
        M2TSFilesDirectShowSourceToolStripMenuItem1.Checked = False
    End Sub

    Private Sub AllAudioFilesFFmpegSourceToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllAudioFilesFFmpegSourceToolStripMenuItem3.Click
        AllAudioFilesFFmpegSourceToolStripMenuItem3.Checked = True
        AllAudioFilesBassAudioToolStripMenuItem.Checked = False
        AllAudioFilesDirectShowSourceToolStripMenuItem.Checked = False
    End Sub

    Private Sub AllAudioFilesBassAudioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllAudioFilesBassAudioToolStripMenuItem.Click
        AllAudioFilesFFmpegSourceToolStripMenuItem3.Checked = False
        AllAudioFilesBassAudioToolStripMenuItem.Checked = True
        AllAudioFilesDirectShowSourceToolStripMenuItem.Checked = False
    End Sub

    Private Sub AC3DTSFilesFFmpegSourceToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AC3DTSFilesFFmpegSourceToolStripMenuItem4.Click
        AC3DTSFilesFFmpegSourceToolStripMenuItem4.Checked = True
        AC3DTSFilesNicAudioToolStripMenuItem.Checked = False
        AC3DTSFilesDirectShowSourceToolStripMenuItem1.Checked = False
    End Sub

    Private Sub AC3DTSFilesNicAudioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AC3DTSFilesNicAudioToolStripMenuItem.Click
        AC3DTSFilesFFmpegSourceToolStripMenuItem4.Checked = False
        AC3DTSFilesNicAudioToolStripMenuItem.Checked = True
        AC3DTSFilesDirectShowSourceToolStripMenuItem1.Checked = False
    End Sub

    Private Sub RMAMRFilesFFmpegSourceToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RMAMRFilesFFmpegSourceToolStripMenuItem5.Click
        RMAMRFilesFFmpegSourceToolStripMenuItem5.Checked = True
        RMAMRFilesDirectShowSourceToolStripMenuItem2.Checked = False
    End Sub

    Private Sub MPEGTSMPEGFilesDirectShowSourceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MPEGTSMPEGFilesDirectShowSourceToolStripMenuItem.Click
        MPEGTSMPEGFilesFFmpegSourceToolStripMenuItem1.Checked = False
        MPEGTSMPEGFilesMPEG2SourceToolStripMenuItem.Checked = False
        MPEGTSMPEGFilesDirectShowSourceToolStripMenuItem.Checked = True
    End Sub

    Private Sub M2TSFilesDirectShowSourceToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M2TSFilesDirectShowSourceToolStripMenuItem1.Click
        M2TSFilesFFmpegSourceToolStripMenuItem6.Checked = False
        M2TSFilesDirectShowSourceToolStripMenuItem1.Checked = True
    End Sub

    Private Sub AllAudioFilesDirectShowSourceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllAudioFilesDirectShowSourceToolStripMenuItem.Click
        AllAudioFilesFFmpegSourceToolStripMenuItem3.Checked = False
        AllAudioFilesBassAudioToolStripMenuItem.Checked = False
        AllAudioFilesDirectShowSourceToolStripMenuItem.Checked = True
    End Sub

    Private Sub AC3DTSFilesDirectShowSourceToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AC3DTSFilesDirectShowSourceToolStripMenuItem1.Click
        AC3DTSFilesFFmpegSourceToolStripMenuItem4.Checked = False
        AC3DTSFilesNicAudioToolStripMenuItem.Checked = False
        AC3DTSFilesDirectShowSourceToolStripMenuItem1.Checked = True
    End Sub

    Private Sub RMAMRFilesDirectShowSourceToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RMAMRFilesDirectShowSourceToolStripMenuItem2.Click
        RMAMRFilesFFmpegSourceToolStripMenuItem5.Checked = False
        RMAMRFilesDirectShowSourceToolStripMenuItem2.Checked = True
    End Sub

    Private Sub AllICToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllICToolStripMenuItem.Click
        AllMovieFilesFFmpegSourceToolStripMenuItem.Checked = True
        AllMovieFilesDirectShowSourceToolStripMenuItem.Checked = False
        MPEGTSMPEGFilesFFmpegSourceToolStripMenuItem1.Checked = True
        MPEGTSMPEGFilesMPEG2SourceToolStripMenuItem.Checked = False
        ASFFilesFFmpegSourceToolStripMenuItem2.Checked = True
        ASFFilesDirectShowSourceToolStripMenuItem1.Checked = False
        M2TSFilesFFmpegSourceToolStripMenuItem6.Checked = True
        AllAudioFilesFFmpegSourceToolStripMenuItem3.Checked = True
        AllAudioFilesBassAudioToolStripMenuItem.Checked = False
        AC3DTSFilesFFmpegSourceToolStripMenuItem4.Checked = True
        AC3DTSFilesNicAudioToolStripMenuItem.Checked = False
        RMAMRFilesFFmpegSourceToolStripMenuItem5.Checked = True
        MPEGTSMPEGFilesDirectShowSourceToolStripMenuItem.Checked = False
        M2TSFilesDirectShowSourceToolStripMenuItem1.Checked = False
        AllAudioFilesDirectShowSourceToolStripMenuItem.Checked = False
        AC3DTSFilesDirectShowSourceToolStripMenuItem1.Checked = False
        RMAMRFilesDirectShowSourceToolStripMenuItem2.Checked = False
    End Sub

    Private Sub AllOCToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllOCToolStripMenuItem.Click
        AllMovieFilesFFmpegSourceToolStripMenuItem.Checked = False
        AllMovieFilesDirectShowSourceToolStripMenuItem.Checked = True
        MPEGTSMPEGFilesFFmpegSourceToolStripMenuItem1.Checked = False
        MPEGTSMPEGFilesMPEG2SourceToolStripMenuItem.Checked = False
        ASFFilesFFmpegSourceToolStripMenuItem2.Checked = False
        ASFFilesDirectShowSourceToolStripMenuItem1.Checked = True
        M2TSFilesFFmpegSourceToolStripMenuItem6.Checked = False
        AllAudioFilesFFmpegSourceToolStripMenuItem3.Checked = False
        AllAudioFilesBassAudioToolStripMenuItem.Checked = False
        AC3DTSFilesFFmpegSourceToolStripMenuItem4.Checked = False
        AC3DTSFilesNicAudioToolStripMenuItem.Checked = False
        RMAMRFilesFFmpegSourceToolStripMenuItem5.Checked = False
        MPEGTSMPEGFilesDirectShowSourceToolStripMenuItem.Checked = True
        M2TSFilesDirectShowSourceToolStripMenuItem1.Checked = True
        AllAudioFilesDirectShowSourceToolStripMenuItem.Checked = True
        AC3DTSFilesDirectShowSourceToolStripMenuItem1.Checked = True
        RMAMRFilesDirectShowSourceToolStripMenuItem2.Checked = True
    End Sub

    Private Sub SetDecToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetDecToolStripMenuItem.Click
        If MainFrm.SPreB = True Then Exit Sub

        '윈도우 2000 일경우 MPEGTSMPEGFilesMPEG2SourceToolStripMenuItem 설정제한
        If Environment.OSVersion.Version.Major = 5 AndAlso Environment.OSVersion.Version.Minor = 0 Then
            MPEGTSMPEGFilesMPEG2SourceToolStripMenuItem.Enabled = False
            If MPEGTSMPEGFilesMPEG2SourceToolStripMenuItem.Checked = True Then
                MPEGTSMPEGFilesMPEG2SourceToolStripMenuItem.Checked = False
                MPEGTSMPEGFilesFFmpegSourceToolStripMenuItem1.Checked = True
            End If
        End If

        With Me

            If .AllMovieFilesFFmpegSourceToolStripMenuItem.Checked = True AndAlso _
                .MPEGTSMPEGFilesMPEG2SourceToolStripMenuItem.Checked = True AndAlso _
                .ASFFilesDirectShowSourceToolStripMenuItem1.Checked = True AndAlso _
                .M2TSFilesFFmpegSourceToolStripMenuItem6.Checked = True AndAlso _
                .AllAudioFilesBassAudioToolStripMenuItem.Checked = True AndAlso _
                .AC3DTSFilesNicAudioToolStripMenuItem.Checked = True AndAlso _
                .RMAMRFilesFFmpegSourceToolStripMenuItem5.Checked = True Then
                .InitializationDSToolStripMenuItem.Checked = True
                .AllICToolStripMenuItem.Checked = False
                .AllOCToolStripMenuItem.Checked = False
            ElseIf .AllMovieFilesFFmpegSourceToolStripMenuItem.Checked = True AndAlso _
                .MPEGTSMPEGFilesFFmpegSourceToolStripMenuItem1.Checked = True AndAlso _
                .ASFFilesFFmpegSourceToolStripMenuItem2.Checked = True AndAlso _
                .M2TSFilesFFmpegSourceToolStripMenuItem6.Checked = True AndAlso _
                .AllAudioFilesFFmpegSourceToolStripMenuItem3.Checked = True AndAlso _
                .AC3DTSFilesFFmpegSourceToolStripMenuItem4.Checked = True AndAlso _
                .RMAMRFilesFFmpegSourceToolStripMenuItem5.Checked = True Then
                .InitializationDSToolStripMenuItem.Checked = False
                .AllICToolStripMenuItem.Checked = True
                .AllOCToolStripMenuItem.Checked = False
            ElseIf .AllMovieFilesDirectShowSourceToolStripMenuItem.Checked = True AndAlso _
                .ASFFilesDirectShowSourceToolStripMenuItem1.Checked = True AndAlso _
                .MPEGTSMPEGFilesDirectShowSourceToolStripMenuItem.Checked = True AndAlso _
                .M2TSFilesDirectShowSourceToolStripMenuItem1.Checked = True AndAlso _
                .AllAudioFilesDirectShowSourceToolStripMenuItem.Checked = True AndAlso _
                .AC3DTSFilesDirectShowSourceToolStripMenuItem1.Checked = True AndAlso _
                .RMAMRFilesDirectShowSourceToolStripMenuItem2.Checked = True Then
                .InitializationDSToolStripMenuItem.Checked = False
                .AllICToolStripMenuItem.Checked = False
                .AllOCToolStripMenuItem.Checked = True
            Else
                .InitializationDSToolStripMenuItem.Checked = False
                .AllICToolStripMenuItem.Checked = False
                .AllOCToolStripMenuItem.Checked = False
            End If

        End With

        DecContextMenuStrip.Show(Control.MousePosition)
    End Sub

End Class