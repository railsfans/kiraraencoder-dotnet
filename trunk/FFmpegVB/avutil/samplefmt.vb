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

        Public Enum AVSampleFormat
            AV_SAMPLE_FMT_NONE = -1
            AV_SAMPLE_FMT_U8 '          ///< unsigned 8 bits
            AV_SAMPLE_FMT_S16 '         ///< signed 16 bits
            AV_SAMPLE_FMT_S32 '         ///< signed 32 bits
            AV_SAMPLE_FMT_FLT '         ///< float
            AV_SAMPLE_FMT_DBL '         ///< double
            AV_SAMPLE_FMT_NB '          ///< Number of sample formats. DO NOT USE if linking dynamically
        End Enum

    End Class

End Namespace