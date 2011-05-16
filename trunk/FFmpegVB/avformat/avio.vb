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

Namespace FFmpeg

    Partial Public Class Libavformat

        Public Delegate Function Read_PacketCallback(ByRef opaque As IntPtr, ByRef buf As IntPtr, ByVal buf_size As Integer) As Integer

        Public Delegate Function WritePacketCallback(ByRef opaque As IntPtr, ByRef buf As IntPtr, ByVal buf_size As Integer) As Integer

        Public Delegate Function SeekCallback(ByRef opaque As IntPtr, ByVal offset As Int64, ByVal whence As Integer) As Int64

        Public Delegate Function UpdateChecksumCallback(ByVal checksum As UInt32, ByVal buf As IntPtr, ByVal size As UInt32) As UInt32

        Public Delegate Function Read_PauseCallback(ByRef opaque As IntPtr, ByVal pause As Integer) As Integer

        Public Delegate Function Read_SeekCallback(ByRef opaque As IntPtr, ByVal stream_index As Integer, ByVal timestamp As Int64, ByVal flags As Integer) As Int64

        <StructLayout(LayoutKind.Sequential)> _
        Public Structure AVIOContext

            Public buffer As IntPtr        '/**< Start of the buffer. */

            <MarshalAs(UnmanagedType.I4)> _
            Public buffer_size As Integer  '/**< Maximum buffer size */
            Public buf_ptr As IntPtr       '/**< Current position in the buffer */
            Public buf_end As IntPtr       '/**< End of the data, may be less than
            'buffer+buffer_size if the read function returned
            'less data than requested, e.g. for streams where
            'no more data has been received yet. */
            Public opaque As IntPtr        '/**< A private pointer, passed to the read/write/seek/...
            'functions. */

            <MarshalAs(UnmanagedType.FunctionPtr)> _
            Public read_packet As Read_PacketCallback

            <MarshalAs(UnmanagedType.FunctionPtr)> _
            Public write_packet As WritePacketCallback

            <MarshalAs(UnmanagedType.FunctionPtr)> _
            Public seek As SeekCallback

            <MarshalAs(UnmanagedType.I8)> _
            Public pos As Int64            '/**< position in the file of the current buffer */

            <MarshalAs(UnmanagedType.I4)> _
            Public must_flush As Integer   '/**< true if the next seek should flush */

            <MarshalAs(UnmanagedType.I4)> _
            Public eof_reached As Integer  '/**< true if eof reached */

            <MarshalAs(UnmanagedType.I4)> _
            Public write_flag As Integer   '/**< true if open for writing */

            '#If FF_API_OLD_AVIO Then
            <MarshalAs(UnmanagedType.I4)> _
            Public is_streamed As Integer
            '#End If

            <MarshalAs(UnmanagedType.I4)> _
            Public max_packet_size As Integer

            <MarshalAs(UnmanagedType.U4)> _
            Public checksum As UInteger

            Public checksum_ptr As IntPtr

            <MarshalAs(UnmanagedType.FunctionPtr)> _
            Public update_checksum As UpdateChecksumCallback

            <MarshalAs(UnmanagedType.I4)> _
            Public [error] As Integer  '/**< contains the error code or 0 if no error happened */
            '/**
            '* Pause or resume playback for network streaming protocols - e.g. MMS.
            '*/
            '<MarshalAs(UnmanagedType.FunctionPtr)> _
            'Public read_pause As Read_PauseCallback

            '/**
            '* Seek to a given timestamp in stream with the specified stream_index.
            '* Needed for some network streaming protocols which don't support seeking
            '* to byte position.
            '*/
            '<MarshalAs(UnmanagedType.FunctionPtr)> _
            'Public read_seek As Read_SeekCallback

            '/**
            '* A combination of AVIO_SEEKABLE_ flags or 0 when the stream is not seekable.
            '*/
            '<MarshalAs(UnmanagedType.I4)> _
            'Public seekable As Integer   '/**< true if open for writing */

        End Structure

    End Class

End Namespace