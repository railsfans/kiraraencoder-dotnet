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

Imports System.Runtime.InteropServices
Imports Microsoft.Win32.SafeHandles

Public Class WinAPI

    Public Const HTCAPTION As Integer = 2
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const WM_KEYDOWN = &H100
    Public Const WM_CLOSE = &H10
    Public Declare Auto Function GetShortPathName Lib "kernel32.dll" (ByVal strLongPath As String, ByVal objStringBuilder As System.Text.StringBuilder, ByVal intBufferSize As Integer) As Integer
    Public Declare Auto Function GetLongPathName Lib "kernel32.dll" (ByVal strShortPath As String, ByVal objStringBuilder As System.Text.StringBuilder, ByVal intBufferSize As Integer) As Integer
    Public Declare Function ReleaseCapture Lib "user32" () As Long
    Public Declare Function SendMessage Lib "user32" Alias "SendMessageW" (ByVal hwnd As Integer, ByVal uMgs As Integer, ByVal wParam As Long, ByVal lParam As Long) As Long
    Public Declare Function IsHungAppWindow Lib "user32.dll" (ByVal hWnd As Long) As Boolean
    Public Declare Function GetWindowThreadProcessId Lib "user32.dll" (ByVal hwnd As Long, ByVal lpdwProcessId As Long) As Long

#Region "프론트엔드 코어"

    '=================================
    '코드 출처: http://www.vbforums.com/showthread.php?t=618110

    Public Const STARTF_USESTDHANDLES As UInteger = &H100
    Public Const CREATE_NEW_CONSOLE As UInteger = &H10
    Public Const STARTF_USESHOWWINDOW As UInteger = 1
    Public Const NORMAL_PRIORITY_PROCESS As UInteger = &H20
    Public Const WAIT_TIMEOUT As UInteger = &H102
    Public Const DUPLICATE_SAME_ACCESS As UInteger = 2
    Public Const WAIT_FAILED As UInteger = 4294967295

    <StructLayout(LayoutKind.Sequential)> _
    Public Class SECURITY_ATTRIBUTES
        Public nLength As Integer
        Public lpSecurityDescriptor As New SafeFileHandle(IntPtr.Zero, False)
        Public bInheritHandle As Boolean
    End Class

    <StructLayout(LayoutKind.Sequential)> _
    Public Class STARTUPINFO
        Public cb As Integer
        Public lpReserved As IntPtr = IntPtr.Zero
        Public lpDesktop As IntPtr = IntPtr.Zero
        Public lpTitle As IntPtr = IntPtr.Zero
        Public dwX As Integer
        Public dwY As Integer
        Public dwXSize As Integer
        Public dwYSize As Integer
        Public dwXCountChars As Integer
        Public dwYCountChars As Integer
        Public dwFillAttribute As Integer
        Public dwFlags As Integer
        Public wShowWindow As Short
        Public cbReserved2 As Short
        Public lpReserved2 As IntPtr = IntPtr.Zero
        Public hStdInput As SafeFileHandle = New SafeFileHandle(IntPtr.Zero, False)
        Public hStdOutput As SafeFileHandle = New SafeFileHandle(IntPtr.Zero, False)
        Public hStdError As SafeFileHandle = New SafeFileHandle(IntPtr.Zero, False)
    End Class

    <StructLayoutAttribute(LayoutKind.Sequential)> _
    Public Structure PROCESS_INFORMATION
        Public hProcess As System.IntPtr
        Public hThread As System.IntPtr
        Public dwProcessId As UInteger
        Public dwThreadId As UInteger
    End Structure

    <DllImport("kernel32.dll", EntryPoint:="CreatePipe", SetLastError:=True)> _
    Public Shared Function CreatePipe(<Out()> ByRef hReadPipe As SafeFileHandle, <Out()> ByRef hWritePipe As SafeFileHandle, _
                                      ByVal lpPipeAttributes As SECURITY_ATTRIBUTES, ByVal nSize As Integer) As Boolean
    End Function

    <DllImport("kernel32.dll", EntryPoint:="CreateProcess", SetLastError:=True)> _
    Public Shared Function CreateProcess(<MarshalAs(UnmanagedType.LPTStr)> ByVal lpApplicationName As String, ByVal lpCommandLine As String, _
                                         ByVal lpProcessAttributes As SECURITY_ATTRIBUTES, ByVal lpThreadAttributes As SECURITY_ATTRIBUTES, ByVal bInheritHandles As Boolean, _
                                         ByVal dwCreationFlags As Integer, ByVal lpEnvironment As IntPtr, <MarshalAs(UnmanagedType.LPTStr)> ByVal lpCurrentDirectory As String, _
                                         ByVal lpStartupInfo As STARTUPINFO, ByRef lpProcessInformation As PROCESS_INFORMATION) As Boolean
    End Function

    <DllImportAttribute("kernel32.dll", EntryPoint:="PeekNamedPipe", SetLastError:=True)> _
    Public Shared Function PeekNamedPipe(<InAttribute()> ByVal hNamedPipe As SafeFileHandle, ByRef lpBuffer As Byte(), ByVal nBufferSize As UInteger, _
                                         <Out()> ByRef lpBytesRead As UInteger, <Out()> ByRef lpTotalBytesAvail As UInteger, _
                                         <Out()> ByRef lpBytesLeftThisMessage As UInteger) As <MarshalAsAttribute(UnmanagedType.Bool)> Boolean
    End Function

    <DllImportAttribute("kernel32.dll", EntryPoint:="ReadFile", SetLastError:=True)> _
    Public Shared Function ReadFile(<InAttribute()> ByVal hFile As SafeFileHandle, ByVal lpBuffer As Byte(), ByVal nNumberOfBytesToRead As UInteger, _
                                   <Out()> ByRef lpNumberOfBytesRead As UInteger, ByVal lpOverlapped As UInteger) As <MarshalAsAttribute(UnmanagedType.Bool)> Boolean
    End Function

    <DllImportAttribute("kernel32.dll", EntryPoint:="WriteFile", SetLastError:=True)> _
    Public Shared Function WriteFile(<InAttribute()> ByVal hFile As SafeFileHandle, <InAttribute()> ByVal lpBuffer As Byte(), ByVal nNumberOfBytesToWrite As UInteger, _
                                     <Out()> ByRef lpNumberOfBytesWritten As UInteger, ByVal lpOverlapped As UInteger) As <MarshalAsAttribute(UnmanagedType.Bool)> Boolean
    End Function

    <DllImportAttribute("kernel32.dll", EntryPoint:="CloseHandle", SetLastError:=True)> _
    Public Shared Function CloseHandle(<InAttribute()> ByVal hObject As IntPtr) As <MarshalAsAttribute(UnmanagedType.Bool)> Boolean
    End Function

    <DllImportAttribute("kernel32.dll", EntryPoint:="CloseHandle")> _
    Public Shared Function CloseHandle(<InAttribute()> ByVal hObject As SafeFileHandle) As <MarshalAsAttribute(UnmanagedType.Bool)> Boolean
    End Function

    <DllImport("kernel32.dll", EntryPoint:="DuplicateHandle", CharSet:=CharSet.Auto, SetLastError:=True)> _
    Public Shared Function DuplicateHandle(ByVal hSourceProcessHandle As HandleRef, ByVal hSourceHandle As SafeHandle, ByVal hTargetProcess As HandleRef, _
                                           <Out()> ByRef targetHandle As SafeFileHandle, ByVal dwDesiredAccess As Integer, _
                                           ByVal bInheritHandle As Boolean, ByVal dwOptions As Integer) As Boolean
    End Function

    <DllImport("kernel32.dll", EntryPoint:="WaitForMultipleObjects", SetLastError:=True)> _
    Public Shared Function WaitForMultipleObjects(ByVal nCount As UInteger, ByVal WaitForHandles As IntPtr(), _
                                                  ByVal bWaitAll As Boolean, ByVal dwMilliseconds As UInteger) As UInteger
    End Function

    '=================================

#End Region

#Region "Dos 8.3 형식으로 변환"

    '=================================
    '코드 출처: http://social.msdn.microsoft.com/forums/en-US/winforms/thread/722c0979-222e-4e08-82d5-c2e5ecd35da9

    Public Enum DirectoryPathLength
        WindowsXP = 256
    End Enum
    Public Shared Function GetShortPathName(ByVal strPath As String, Optional ByVal enumDirectoryPathLength As DirectoryPathLength = DirectoryPathLength.WindowsXP) As String
        Dim strStringBuilder As New System.Text.StringBuilder(enumDirectoryPathLength)
        Dim intNewStringLength As Integer
        intNewStringLength = GetShortPathName(strPath, strStringBuilder, enumDirectoryPathLength)
        Return strStringBuilder.ToString
    End Function
    Public Shared Function GetLongPathName(ByVal strPath As String, Optional ByVal enumDirectoryPathLength As DirectoryPathLength = DirectoryPathLength.WindowsXP) As String
        Dim strStringBuilder As New System.Text.StringBuilder(enumDirectoryPathLength)
        Dim intNewStringLength As Integer
        intNewStringLength = GetLongPathName(strPath, strStringBuilder, enumDirectoryPathLength)
        Return strStringBuilder.ToString
    End Function

    '=================================

#End Region

    <DllImport("kernel32.dll", SetLastError:=True)> _
    Public Shared Function TerminateProcess(ByVal hProcess As IntPtr, ByVal uExitCode As UInteger) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    <System.Runtime.InteropServices.DllImportAttribute("user32.dll", EntryPoint:="PostMessageW")> _
    Public Shared Function PostMessageW(ByVal hWnd As System.IntPtr, ByVal Msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Integer
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Public Shared Function FindWindowW(ByVal lpClassName As String, ByVal lpWindowName As String) As Integer
    End Function

End Class