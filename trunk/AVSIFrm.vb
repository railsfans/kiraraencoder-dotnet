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

Public Class AVSIFrm

    Dim AVSOK As Boolean = False

    Private Sub AVSIFrm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        MainFrm.OldVerCheckBoxAVSIFrmV = OldVerCheckBox.Checked
        MainFrm.AVSOFFCheckBoxAVSIFrmV = AVSOFFCheckBox.Checked

    End Sub

    Private Sub AVSIFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        OldVerCheckBox.Checked = MainFrm.OldVerCheckBoxAVSIFrmV
        AVSOFFCheckBox.Checked = MainFrm.AVSOFFCheckBoxAVSIFrmV

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
                    AVSIPanel.Font = New Font(FNXP, FS)
                Else
                    AVSIPanel.Font = New Font(FN, FS)
                End If

                If XTR.Name = "OKBTN" Then OKBTN.Text = XTR.ReadString

                If XTR.Name = "AVSIInfoLabelNot" Then LangCls.AVSIInfoLabelNot = XTR.ReadString
                If XTR.Name = "AVSIInfoLabelOld" Then LangCls.AVSIInfoLabelOld = XTR.ReadString
                If XTR.Name = "AVSIInfoLabelOK" Then LangCls.AVSIInfoLabelOK = XTR.ReadString
                If XTR.Name = "AVSIProductVersion" Then LangCls.AVSIProductVersion = XTR.ReadString
                If XTR.Name = "AVSIFileVersion" Then LangCls.AVSIFileVersion = XTR.ReadString
                If XTR.Name = "AVSIFrm" Then Me.Text = XTR.ReadString
                If XTR.Name = "AVSIFrmIGroupBox" Then IGroupBox.Text = XTR.ReadString
                If XTR.Name = "AVSIFrmOldVerCheckBox" Then OldVerCheckBox.Text = XTR.ReadString
                If XTR.Name = "AVSIFrmRefBTN" Then RefBTN.Text = XTR.ReadString
                If XTR.Name = "AVSIFrmInstallButton" Then
                    InstallButton.Text = XTR.ReadString
                    HYuvCInstallButton.Text = InstallButton.Text
                End If
                If XTR.Name = "AVSIFrmAVSOFFCheckBox" Then AVSOFFCheckBox.Text = XTR.ReadString
                If XTR.Name = "AVSIFrmAVSOFFLabel" Then AVSOFFLabel.Text = XTR.ReadString
                If XTR.Name = "AVSIFrmHYuvCLabel" Then HYuvCLabel.Text = XTR.ReadString

            Loop
        Catch ex As Exception
            MsgBox("LANG_LOAD_ERROR :" & ex.Message)
        Finally
            XTR.Close()
            SR.Close()
        End Try
LANG_SKIP:
        '=========================================

        '제품버전, 파일버전 초기화
        ProductVersionLabel.Text = LangCls.AVSIProductVersion & ": -"
        FileVersionLabel.Text = LangCls.AVSIFileVersion & ": -"

        '버전 체크
        RefBTN_Click(Nothing, Nothing)

    End Sub



    Private Sub OKBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKBTN.Click
        '버전 체크
        RefBTN_Click(Nothing, Nothing)
        If AVSOK = False OrElse AVSOFFCheckBox.Checked = True Then
            MainFrm.AVSPanel.Enabled = False
            MainFrm.AVSCheckBox.Checked = False
        Else
            MainFrm.AVSPanel.Enabled = True
        End If
        Close()
    End Sub

    Private Sub RefBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefBTN.Click

        '////////////////////////////
        'AviSynth 검사//
        If My.Computer.FileSystem.FileExists(MainFrm.PubAVSPATHStr) = False Then
            InfoLabel.Text = LangCls.AVSIInfoLabelNot
            InfoLabel.ForeColor = Color.Red
            AVSOK = False
            Exit Sub
        Else
            '버전정보가 없을경우 그냥스킵 (lib)
            Dim FV As String = Diagnostics.FileVersionInfo.GetVersionInfo(MainFrm.PubAVSPATHStr).FileVersion
            Dim PV As String = Diagnostics.FileVersionInfo.GetVersionInfo(MainFrm.PubAVSPATHStr).ProductVersion
            If FV = "" OrElse PV = "" Then
                InfoLabel.Text = LangCls.AVSIInfoLabelOK
                InfoLabel.ForeColor = Color.Green
                AVSOK = True
                Exit Sub
            End If
            '----------------------------------- P1
            Dim AVSFV As String = ""
            Try
                AVSFV = Diagnostics.FileVersionInfo.GetVersionInfo(MainFrm.PubAVSPATHStr).FileVersion
                AVSFV = Replace(AVSFV, ",", ".")
                AVSFV = Replace(AVSFV, " ", "")
            Catch ex As Exception
                AVSFV = ""
            End Try
            If AVSFV = "" Then
                InfoLabel.Text = LangCls.AVSIInfoLabelNot
                InfoLabel.ForeColor = Color.Red
                AVSOK = False
                Exit Sub
            End If
            '----------------------------------- P2
            Dim AVSPV As String = ""
            Try
                AVSPV = Diagnostics.FileVersionInfo.GetVersionInfo(MainFrm.PubAVSPATHStr).ProductVersion
                AVSPV = Replace(AVSPV, ",", ".")
                AVSPV = Replace(AVSPV, " ", "")
            Catch ex As Exception
                AVSPV = ""
            End Try
            ProductVersionLabel.Text = LangCls.AVSIProductVersion & ": " & AVSPV
            FileVersionLabel.Text = LangCls.AVSIFileVersion & ": " & AVSFV
            If AVSFV < "2.5.8.5" Then '버전 검사
                InfoLabel.Text = LangCls.AVSIInfoLabelOld
                InfoLabel.ForeColor = Color.OrangeRed
                AVSOK = True
            Else
                InfoLabel.Text = LangCls.AVSIInfoLabelOK
                InfoLabel.ForeColor = Color.Green
                AVSOK = True
            End If
        End If
        '////////////////////////////

    End Sub

    Private Sub InstallButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InstallButton.Click
        Try
            Shell("explorer.exe /n, " & FunctionCls.AppInfoDirectoryPath & "\avisynth\Avisynth_258.exe", AppWinStyle.NormalFocus)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub OldVerCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OldVerCheckBox.CheckedChanged

    End Sub

    Private Sub AVSOFFCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AVSOFFCheckBox.CheckedChanged

    End Sub

    Private Sub HYuvCInstallButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HYuvCInstallButton.Click
        Try
            Shell("explorer.exe /n, " & FunctionCls.AppInfoDirectoryPath & "\yuvcodecs-1.3.exe", AppWinStyle.NormalFocus)
        Catch ex As Exception
        End Try
    End Sub
End Class