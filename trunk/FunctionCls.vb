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

Public Class FunctionCls

    '----------------------------------------------------------------------------
    ' 함수이름: ColorToHEX
    ' 제 작 일: 2010 08 23
    ' 설    명: ABGR 형식으로 변환하는 프로그램
    ' 제 작 자: 이기원
    '-----------------------------------------------------------------------------
    Public Shared Function ColorToHEX(ByVal PanelName As String, ByVal AlphaV As Integer)
        Dim AV As String = "FF", RV As String = "FF", GV As String = "FF", BV As String = "FF"
        If Len(Hex(AlphaV)) = 1 Then AV = "0" & Hex(AlphaV) Else AV = Hex(AlphaV)
        If Len(Hex(Color.FromArgb(PanelName).R.ToString)) = 1 Then RV = "0" & Hex(Color.FromArgb(PanelName).R.ToString) Else RV = Hex(Color.FromArgb(PanelName).R.ToString)
        If Len(Hex(Color.FromArgb(PanelName).G.ToString)) = 1 Then GV = "0" & Hex(Color.FromArgb(PanelName).G.ToString) Else GV = Hex(Color.FromArgb(PanelName).G.ToString)
        If Len(Hex(Color.FromArgb(PanelName).B.ToString)) = 1 Then BV = "0" & Hex(Color.FromArgb(PanelName).B.ToString) Else BV = Hex(Color.FromArgb(PanelName).B.ToString)
        ColorToHEX = "&H" & AV & BV & GV & RV
    End Function

    '----------------------------------------------------------------------------
    ' 함수이름: UTFCHKFN
    ' 제 작 일: 2010 08 24
    ' 설    명: UTF형식을 알아보는 프로그램
    ' 제 작 자: 이기원
    '-----------------------------------------------------------------------------
    Public Shared Function UTFCHKFN(ByVal PATHV As String) As String

        '변수초기화
        Dim BTemp As String = ""

        '파일이 있는지 확인
        If My.Computer.FileSystem.FileExists(PATHV) = False Then
            UTFCHKFN = "NotFound"
            Exit Function
        End If

        '파일을 읽어온다 바이너리 형태로 4자까지.
        Dim BinaryReader As New BinaryReader(New FileStream(PATHV, FileMode.Open))
        For I As Short = 0 To 3
            Try
                BTemp = BTemp & (BinaryReader.ReadByte & " ")
            Catch ex As Exception
            End Try
        Next
        BinaryReader.Close()

        '분석시작!
        Try
            If Split(BTemp, " ")(0) = 254 And Split(BTemp, " ")(1) = 255 Then
                UTFCHKFN = "UTF-16BE"
            ElseIf Split(BTemp, " ")(0) = 255 And Split(BTemp, " ")(1) = 254 Then
                UTFCHKFN = "UTF-16LE"
            ElseIf Split(BTemp, " ")(0) = 247 And Split(BTemp, " ")(1) = 100 And Split(BTemp, " ")(2) = 76 Then
                UTFCHKFN = "UTF-1"
            ElseIf Split(BTemp, " ")(0) = 239 And Split(BTemp, " ")(1) = 187 And Split(BTemp, " ")(2) = 191 Then
                UTFCHKFN = "UTF-8"
            ElseIf Split(BTemp, " ")(0) = 0 And Split(BTemp, " ")(1) = 0 And Split(BTemp, " ")(2) = 254 And Split(BTemp, " ")(3) = 255 Then
                UTFCHKFN = "UTF-32BE"
            ElseIf Split(BTemp, " ")(0) = 255 And Split(BTemp, " ")(1) = 254 And Split(BTemp, " ")(2) = 0 And Split(BTemp, " ")(3) = 0 Then
                UTFCHKFN = "UTF-32LE"
            Else
                UTFCHKFN = ""
            End If
        Catch ex As Exception
            UTFCHKFN = ""
        End Try

    End Function

    '----------------------------------------------------------------------------
    ' 함수이름: InputCheck_NUMBER
    ' 제 작 일: 2010 09 08
    ' 설    명: 숫자 or 소수점 or 부호만 입력 받기
    ' 제 작 자: 이기원
    '-----------------------------------------------------------------------------
    Public Shared Function InputCheck_NUMBER(ByVal e As System.Windows.Forms.KeyPressEventArgs, ByVal floatopts As Boolean, ByVal signopts As Boolean) As Boolean

        If floatopts = True And signopts = True Then
            If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "-" AndAlso e.KeyChar <> ControlChars.Back Then Return True Else Return False
        ElseIf floatopts = True And signopts = False Then
            If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then Return True Else Return False
        ElseIf floatopts = False And signopts = True Then
            If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "-" AndAlso e.KeyChar <> ControlChars.Back Then Return True Else Return False
        ElseIf floatopts = False And signopts = False Then
            If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then Return True Else Return False
        Else
            Return False
        End If

    End Function

    '----------------------------------------------------------------------------
    ' 함수이름: Input_nint_zero
    ' 제 작 일: 2010 09 08
    ' 설    명: 구간설정전용 x -> 0x 으로
    ' 제 작 자: 이기원
    '-----------------------------------------------------------------------------
    Public Shared Function Input_nint_zero(ByVal intv As String) As String

        If Val(intv) < 10 AndAlso Val(Left(intv, 1)) <> 0 Then
            intv = 0 & intv
        End If
        If Val(intv) = 0 Then
            intv = "00"
        End If

        Return intv

    End Function


    '----------------------------------------------------------------------------
    ' 함수이름: LangSel
    ' 제 작 일: 2010 09 09
    ' 설    명: 언어선택 관련
    ' 제 작 자: 이기원
    '-----------------------------------------------------------------------------
    Public Shared Function LangSel() As String

        Dim LangXMLFV As String = ""
        For i2 = 0 To MainFrm.LangToolStripMenuItem.DropDownItems.Count - 1
            If CType(MainFrm.LangToolStripMenuItem.DropDownItems(i2), ToolStripMenuItem).Checked = True Then
                LangXMLFV = MainFrm.LangToolStripMenuItem.DropDownItems(i2).Text
            End If
        Next

        '자동선택으로 되어있을경우..
        If LangXMLFV = "Auto-select" Then

            'LCID로 LCID_GET_LANG을 이용해 언어파일 선택.
            Dim LCID_GET_LANGV As String = LCID_GET_LANG(Globalization.CultureInfo.CurrentUICulture.LCID)
            If LCID_GET_LANGV <> "" Then

                If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\lang\" & LCID_GET_LANGV & ".xml") = True Then
                    LangXMLFV = LCID_GET_LANGV & ".xml"
                End If

            End If

        End If

        Return LangXMLFV

    End Function


    '----------------------------------------------------------------------------
    ' 함수이름: LCID_GET_LANG
    ' 제 작 일: 2010 09 09
    ' 설    명: LCID로 언어영문이름 구하기
    ' 제 작 자: 이기원
    '-----------------------------------------------------------------------------
    Public Shared Function LCID_GET_LANG(ByVal LCID As Integer) As String

        'LCID 참고: http://office.microsoft.com/en-us/infopath-help/locale-identification-numbers-for-language-specific-files-HP005259023.aspx
        Select Case (LCID)

            Case 1078 : Return "Afrikaans"
            Case 1052 : Return "Albanian"
            Case 1118 : Return "Amharic"
            Case 1025 : Return "Arabic"
            Case 1067 : Return "Armenian "
            Case 1101 : Return "Assamese "
            Case 2092 : Return "Azeri" ' (Cyrillic)"
            Case 1068 : Return "Azeri" ' (Latin)"
            Case 1069 : Return "Basque"
            Case 1059 : Return "Belarusian"
            Case 1093 : Return "Bengali"
            Case 1026 : Return "Bulgarian"
            Case 1027 : Return "Catalan"
            Case 1116 : Return "Cherokee"
            Case 2052 : Return "Chinese (Simplified)"
            Case 1028 : Return "Chinese (Traditional)"
            Case 1050 : Return "Croatian"
            Case 1029 : Return "Czech"
            Case 1030 : Return "Danish"
            Case 1125 : Return "Dhivehi"
            Case 1043 : Return "Dutch"
            Case 1126 : Return "Edo"
            Case 3081 : Return "English" ' (Australian)"
            Case 4105 : Return "English" ' (Canadian)"
            Case 2057 : Return "English" ' (U.K.)"
            Case 1033 : Return "English" ' (U.S.)"
            Case 1061 : Return "Estonian"
            Case 1080 : Return "Farsi"
            Case 1124 : Return "Filipino"
            Case 1035 : Return "Finnish"
            Case 1036 : Return "French"
            Case 3084 : Return "French" ' (Canadian)"
            Case 1122 : Return "Frisian"
            Case 1127 : Return "Fulfulde"
            Case 1110 : Return "Galician"
            Case 1079 : Return "Georgian"
            Case 1031 : Return "German"
            Case 3079 : Return "German" ' (Austrian)"
            Case 2055 : Return "German" ' (Swiss)"
            Case 1032 : Return "Greek"
            Case 1095 : Return "Gujarati"
            Case 1128 : Return "Hausa"
            Case 1141 : Return "Hawaiian"
            Case 1037 : Return "Hebrew"
            Case 1081 : Return "Hindi"
            Case 1038 : Return "Hungarian"
            Case 1129 : Return "Ibibio"
            Case 1039 : Return "Icelandic"
            Case 1136 : Return "Igbo"
            Case 1057 : Return "Indonesian"
            Case 1117 : Return "Inuktitut"
            Case 1040 : Return "Italian"
            Case 1041 : Return "Japanese"
            Case 1099 : Return "Kannada"
            Case 1137 : Return "Kanuri"
            Case 2144 : Return "Kashmiri"
            Case 1120 : Return "Kashmiri" ' (Arabic)"
            Case 1087 : Return "Kazakh"
            Case 1088 : Return "Kyrgyz"
            Case 1111 : Return "Konkani"
            Case 1042 : Return "Korean"
            Case 1142 : Return "Latin"
            Case 1062 : Return "Latvian"
            Case 1063 : Return "Lithuanian"
            Case 1071 : Return "FYRO Macedonian"
            Case 1086 : Return "Malay"
            Case 1100 : Return "Malayalam"
            Case 1082 : Return "Maltese"
            Case 1112 : Return "Manipuri"
            Case 1102 : Return "Marathi"
            Case 1104 : Return "Mongolian"
            Case 1121 : Return "Nepali"
            Case 1044 : Return "Norwegian Bokmal"
            Case 2068 : Return "Norwegian Nynorsk"
            Case 1096 : Return "Oriya"
            Case 1138 : Return "Oromo"
            Case 1123 : Return "Pashto"
            Case 1045 : Return "Polish"
            Case 1046 : Return "Portuguese" ' (Brazil)"
            Case 2070 : Return "Portuguese" ' (Portugal)"
            Case 1094 : Return "Punjabi"
            Case 1048 : Return "Romanian"
            Case 1049 : Return "Russian"
            Case 1103 : Return "Sanskrit"
            Case 3098 : Return "Serbian" ' (Cyrillic)"
            Case 2074 : Return "Serbian" ' (Latin)"
            Case 1113 : Return "Sindhi"
            Case 1115 : Return "Sinhalese"
            Case 1051 : Return "Slovak"
            Case 1060 : Return "Slovenian"
            Case 1143 : Return "Somali"
            Case 3082 : Return "Spanish"
            Case 1089 : Return "Swahili"
            Case 1053 : Return "Swedish"
            Case 1114 : Return "Syriac"
            Case 1064 : Return "Tajik"
            Case 1119 : Return "Tamazight" ' (Berber/Arabic)"
            Case 2143 : Return "Tamazight" ' (Latin)"
            Case 1097 : Return "Tamil"
            Case 1092 : Return "Tatar"
            Case 1098 : Return "Telugu"
            Case 1054 : Return "Thai"
            Case 1139 : Return "Tigrigna" ' (Ethiopia)"
            Case 2163 : Return "Tigrigna" ' (Eritrea)"
            Case 1055 : Return "Turkish"
            Case 1090 : Return "Turkmen"
            Case 1058 : Return "Ukrainian"
            Case 1056 : Return "Urdu"
            Case 2115 : Return "Uzbek" ' (Cyrillic)"
            Case 1091 : Return "Uzbek" ' (Latin)"
            Case 1066 : Return "Vietnamese"
            Case 1144 : Return "Yi"
            Case 1085 : Return "Yiddish"
            Case 1130 : Return "Yoruba"
            Case Else : Return ""

        End Select

    End Function

    '----------------------------------------------------------------------------
    ' 함수이름: TIME_TO_HMSMSTIME
    ' 제 작 일: 2008년 / 함수화: 2010 09 26
    ' 설    명: hh:mm:ss:ms 로 변환
    ' 제 작 자: 이기원
    '-----------------------------------------------------------------------------
    Public Shared Function TIME_TO_HMSMSTIME(ByVal TimeV As Double, ByVal PointB As Boolean) As String

        Dim Minute As Single
        Dim Hour As Single
        Dim hmsValue As String = ""

        If TimeV < 0 Then
            If PointB = False Then
                Return "00:00:00"
            Else
                Return "00:00:00.00"
            End If
        End If

        If TimeV < 60 Then
            If TimeV < 0 Then
                hmsValue = "00:" & "00:" & "00.00"
            ElseIf Format(TimeV, "0.00") < 10 Then
                hmsValue = "00:" & "00:" & "0" & Format(TimeV, "0.00")
            Else
                hmsValue = "00:" & "00:" & Format(TimeV, "0.00")
            End If
        End If

        If TimeV > 59 Then
            Minute = TimeV / 60
            If Int(TimeV - "60" * Split(Minute, ".")(0)) < 10 Then
                If Split(Minute, ".")(0) < 10 Then
                    hmsValue = "00:" & "0" & Split(Minute, ".")(0) & ":" & "0" & Format(TimeV - "60" * Split(Minute, ".")(0), "0.00")
                Else
                    hmsValue = "00:" & Split(Minute, ".")(0) & ":" & "0" & Format(TimeV - "60" * Split(Minute, ".")(0), "0.00")
                End If
            Else
                If Split(Minute, ".")(0) < 10 Then
                    hmsValue = "00:" & "0" & Split(Minute, ".")(0) & ":" & Format(TimeV - "60" * Split(Minute, ".")(0), "0.00")
                Else
                    hmsValue = "00:" & Split(Minute, ".")(0) & ":" & Format(TimeV - "60" * Split(Minute, ".")(0), "0.00")
                End If
            End If
        End If

        If Split(Minute, ".")(0) > 59 Then
            Hour = Split(Minute, ".")(0) / 60
            If Split(Hour, ".")(0) < 10 Then
                If Int(Minute - "60" * Split(Hour, ".")(0)) < 10 Then
                    If Int(TimeV - "60" * Split(Minute, ".")(0)) < 10 Then
                        hmsValue = "0" & Split(Hour, ".")(0) & ":" & "0" & Int(Minute - "60" * Split(Hour, ".")(0)) & ":" & "0" & Format(TimeV - "60" * Split(Minute, ".")(0), "0.00")
                    Else
                        hmsValue = "0" & Split(Hour, ".")(0) & ":" & "0" & Int(Minute - "60" * Split(Hour, ".")(0)) & ":" & Format(TimeV - "60" * Split(Minute, ".")(0), "0.00")
                    End If
                Else
                    If Int(TimeV - "60" * Split(Minute, ".")(0)) < 10 Then
                        hmsValue = "0" & Split(Hour, ".")(0) & ":" & Int(Minute - "60" * Split(Hour, ".")(0)) & ":" & "0" & Format(TimeV - "60" * Split(Minute, ".")(0), "0.00")
                    Else
                        hmsValue = "0" & Split(Hour, ".")(0) & ":" & Int(Minute - "60" * Split(Hour, ".")(0)) & ":" & Format(TimeV - "60" * Split(Minute, ".")(0), "0.00")
                    End If
                End If

            Else

                If Int(Minute - "60" * Split(Hour, ".")(0)) < 10 Then
                    If Int(TimeV - "60" * Split(Minute, ".")(0)) < 10 Then
                        hmsValue = Split(Hour, ".")(0) & ":" & "0" & Int(Minute - "60" * Split(Hour, ".")(0)) & ":" & "0" & Format(TimeV - "60" * Split(Minute, ".")(0), "0.00")
                    Else
                        hmsValue = Split(Hour, ".")(0) & ":" & "0" & Int(Minute - "60" * Split(Hour, ".")(0)) & ":" & Format(TimeV - "60" * Split(Minute, ".")(0), "0.00")
                    End If
                Else
                    If Int(TimeV - "60" * Split(Minute, ".")(0)) < 10 Then
                        hmsValue = Split(Hour, ".")(0) & ":" & Int(Minute - "60" * Split(Hour, ".")(0)) & ":" & "0" & Format(TimeV - "60" * Split(Minute, ".")(0), "0.00")
                    Else
                        hmsValue = Split(Hour, ".")(0) & ":" & Int(Minute - "60" * Split(Hour, ".")(0)) & ":" & Format(TimeV - "60" * Split(Minute, ".")(0), "0.00")
                    End If
                End If

            End If

        End If

        If PointB = False Then
            Return Split(hmsValue, ".")(0)
        Else
            Return hmsValue
        End If


    End Function

End Class

