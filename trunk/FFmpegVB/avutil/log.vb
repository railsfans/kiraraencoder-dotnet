' ---------------------------------------------------------------------------------------
' 
' FFmpegVB (Wrapper library) // GPLv2
'
' 1st. Author(C#, GPL) jackaroomaster
' http://sourceforge.net/projects/sharpffmpeg/
'
' 2nd. Reference(C#, LGPL) Justin Cherniak
' http://code.google.com/p/ffmpeg-sharp/
'
' 3rd. Modify(VB.NET, GPL) LEE KIWON
' http://code.google.com/p/kiraraencoder-dotnet/
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
Imports System.Security

Namespace FFmpeg

    Partial Public Class Libavutil

        <DllImport(AVUTIL_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function av_log_get_level() As Integer
        End Function

        <DllImport(AVUTIL_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Sub av_log_set_level(ByVal level As Integer)
        End Sub

        '/* av_log API */

        Public Const AV_LOG_QUIET As Integer = -8


        '/**
        ' * Something went really wrong and we will crash now.
        ' */
        Public Const AV_LOG_PANIC As Integer = 0

        '/**
        ' * Something went wrong and recovery is not possible.
        ' * For example, no header was found for a format which depends
        ' * on headers or an illegal combination of parameters is used.
        ' */
        Public Const AV_LOG_FATAL As Integer = 8

        '/**
        ' * Something went wrong and cannot losslessly be recovered.
        ' * However, not all future data is affected.
        ' */
        Public Const AV_LOG_ERROR As Integer = 16

        '/**
        ' * Something somehow does not look correct. This may or may not
        ' * lead to problems. An example would be the use of '-vstrict -2'.
        ' */
        Public Const AV_LOG_WARNING As Integer = 24

        Public Const AV_LOG_INFO As Integer = 32
        Public Const AV_LOG_VERBOSE As Integer = 40

        '/**
        ' * Stuff which is only useful for libav* developers.
        ' */
        Public Const AV_LOG_DEBUG As Integer = 48

    End Class

End Namespace
