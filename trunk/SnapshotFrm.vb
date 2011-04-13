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

Imports Microsoft.Win32.SafeHandles
Imports System.Runtime.InteropServices

Public Class SnapshotFrm

    '프론트엔드 코어
    Private OutputHandle_SF As SafeFileHandle = Nothing
    Private InputHandle_SF As SafeFileHandle = Nothing
    Public ProcessHandle_SF As IntPtr = Nothing
    Private ThreadSignal_SF As New Threading.ManualResetEvent(False)
    Public ProcessID_SF As UInteger

    '프로세스 우선 순위
    Enum PriorityClass
        REALTIME_PRIORITY_CLASS = &H100
        HIGH_PRIORITY_CLASS = &H80
        ABOVE_NORMAL_PRIORITY_CLASS = 32768
        NORMAL_PRIORITY_CLASS = &H20
        BELOW_NORMAL_PRIORITY_CLASS = 16384
        IDLE_PRIORITY_CLASS = &H40
    End Enum

    '종료여부
    Public ImagePPExitB As Boolean = True
    Public ImagePP As Image = Nothing

#Region "프론트엔드 코어"

    '=================================
    '코드 출처: http://www.vbforums.com/showthread.php?t=618110
    '위의 URL에 있는 핵심 소스를 사용하여 제작되었습니다.

    Private Sub WriteToOutputBox(ByVal MsgV As String)
        If OutputBox_SF.InvokeRequired Then
            Try
                Invoke(New Action(Of String)(AddressOf WriteToOutputBox), MsgV)
            Catch ex As Exception
            End Try
        End If
    End Sub

    'Public Sub MsgSend(ByVal msg As String)

    '    If Not InputHandle_GI Is Nothing AndAlso Not InputHandle_GI.IsClosed Then
    '        Dim MessageBytes() As Byte = System.Text.Encoding.GetEncoding(0).GetBytes(msg & vbCrLf & vbCr)
    '        Dim BytesWritten As UInteger = 0
    '        WinAPI.WriteFile(InputHandle_GI, MessageBytes, CUInt(MessageBytes.Length - 1), BytesWritten, 0)
    '    End If

    'End Sub

    Private Sub OutputInfo()

        Do
            Threading.Thread.Sleep(10)

            Do
                Threading.Thread.Sleep(10)

                Dim Buffer(0) As Byte
                Dim BytesRead As UInteger = 0
                Dim BytesAvailable As UInteger = 0

                Dim PNP As Boolean
                If Not OutputHandle_SF Is Nothing Then
                    PNP = WinAPI.PeekNamedPipe(OutputHandle_SF, Nothing, 0, 0, BytesAvailable, 0)
                End If

                If PNP = True Then
                    If BytesAvailable > 0 Then
                        ReDim Buffer(CInt(BytesAvailable))
                        If WinAPI.ReadFile(OutputHandle_SF, Buffer, CUInt(Buffer.Length), BytesRead, 0) Then
                            WriteToOutputBox(System.Text.Encoding.GetEncoding(0).GetString(Buffer))
                        Else
                            Exit Do
                        End If
                    Else
                        Exit Do
                    End If
                Else
                    Exit Do
                End If


                Application.DoEvents()
            Loop

            Dim WaitOnHandles(1) As IntPtr
            WaitOnHandles(0) = ProcessHandle_SF
            WaitOnHandles(1) = ThreadSignal_SF.SafeWaitHandle.DangerousGetHandle
            If WinAPI.WaitForMultipleObjects(2, WaitOnHandles, False, 0) = 0 Then
                EndOfProcess()
                Exit Do
            End If

            Application.DoEvents()

        Loop

    End Sub

    Private Sub EndOfProcess()

        If OutputBox_SF.InvokeRequired Then
            Invoke(New MethodInvoker(AddressOf EndOfProcess))
        Else
            DestroyHandles()

            '이미지 표시
            If My.Computer.FileSystem.FileExists(EncodingFrm.SnapshotImgFilePathV) = True Then
                Try
                    Dim IFS As New IO.FileStream(EncodingFrm.SnapshotImgFilePathV, IO.FileMode.Open)
                    ImagePP = Image.FromStream(IFS)
                    IFS.Close()
                Catch ex As Exception
                End Try
            End If

            ImagePPExitB = True
        End If

    End Sub

    Public Sub DestroyHandles()

        If ProcessHandle_SF <> IntPtr.Zero Then
            WinAPI.CloseHandle(ProcessHandle_SF)
        End If

        If Not InputHandle_SF Is Nothing AndAlso Not InputHandle_SF.IsClosed Then
            InputHandle_SF.Close()
        End If

        If Not OutputHandle_SF Is Nothing AndAlso Not OutputHandle_SF.IsClosed Then
            OutputHandle_SF.Close()
        End If

    End Sub

    '=================================

#End Region

    Public Sub SFSTR(ByVal IN_PATHV As String, ByVal SSV As String, ByVal WIDTHV As Integer, ByVal HEIGHTV As Integer)

        '저장 디렉토리 설정
        Dim OUTDIRSTR As String = ""
        Try
            OUTDIRSTR = WinAPI.GetShortPathName(Replace(Split(FunctionCls.AppInfoDirectoryPath & "\temp", ":")(1), "\", "/"))
        Catch ex As Exception
            ImagePPExitB = True
            Exit Sub
        End Try

        Dim MSGB As String = ""
        MSGB = FunctionCls.AppInfoDirectoryPath & "\tools\mplayer\mplayer-" & MainFrm.MPLAYEREXESTR & ".exe " & Chr(34) & IN_PATHV & Chr(34) & _
        " -ss " & SSV & " -frames 1 -idx -vf scale=" & WIDTHV & ":" & HEIGHTV & " -priority idle -nosound -vo jpeg:quality=100:outdir=" & OUTDIRSTR

        EncodingFrm.DebugLabel.Text = "Duration " & SSV

        Dim TempOutputHandle As SafeFileHandle = Nothing
        Dim TempInputHandle As SafeFileHandle = Nothing

        Dim StartupInfo As New WinAPI.STARTUPINFO
        StartupInfo.cb = Marshal.SizeOf(StartupInfo)
        StartupInfo.dwFlags = WinAPI.STARTF_USESTDHANDLES Or WinAPI.STARTF_USESHOWWINDOW

        Dim SecurityAttributes As New WinAPI.SECURITY_ATTRIBUTES
        SecurityAttributes.nLength = Marshal.SizeOf(SecurityAttributes)
        SecurityAttributes.bInheritHandle = True
        WinAPI.CreatePipe(TempOutputHandle, StartupInfo.hStdOutput, SecurityAttributes, 0)
        WinAPI.CreatePipe(StartupInfo.hStdInput, TempInputHandle, SecurityAttributes, 0)
        WinAPI.DuplicateHandle(New HandleRef(Me, Process.GetCurrentProcess.Handle), StartupInfo.hStdOutput, _
                               New HandleRef(Me, Process.GetCurrentProcess.Handle), StartupInfo.hStdError, 0, True, WinAPI.DUPLICATE_SAME_ACCESS)
        WinAPI.DuplicateHandle(New HandleRef(Me, Process.GetCurrentProcess.Handle), TempInputHandle, _
                               New HandleRef(Me, Process.GetCurrentProcess.Handle), InputHandle_SF, 0, False, WinAPI.DUPLICATE_SAME_ACCESS)
        WinAPI.DuplicateHandle(New HandleRef(Me, Process.GetCurrentProcess.Handle), TempOutputHandle, _
                               New HandleRef(Me, Process.GetCurrentProcess.Handle), OutputHandle_SF, 0, False, WinAPI.DUPLICATE_SAME_ACCESS)

        TempOutputHandle.Close()
        TempInputHandle.Close()
        TempOutputHandle.Dispose()
        TempInputHandle.Dispose()

        Dim ProcessInformation As New WinAPI.PROCESS_INFORMATION
        WinAPI.CreateProcess(Nothing, MSGB, SecurityAttributes, SecurityAttributes, True, PriorityClass.NORMAL_PRIORITY_CLASS, IntPtr.Zero, Nothing, StartupInfo, ProcessInformation)

        If ProcessInformation.dwProcessId <> 0 AndAlso ProcessInformation.hProcess <> IntPtr.Zero Then
            ProcessHandle_SF = ProcessInformation.hProcess
            ProcessID_SF = ProcessInformation.dwProcessId
            EncodingFrm.DebugLabel.Text &= vbNewLine & "PID " & ProcessID_SF & ", Start"
            Dim ThreadSTR As New Threading.Thread(AddressOf OutputInfo)
            ThreadSTR.IsBackground = True
            ThreadSTR.Start()
        End If

    End Sub

End Class