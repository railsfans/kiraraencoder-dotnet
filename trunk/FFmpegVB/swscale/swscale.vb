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
Imports FFmpegVB.FFmpeg.Libavutil
Imports System.Security

Namespace FFmpeg

    Partial Public Class Swscale

        Public Const SWSCALE_DLL_NAME As String = "swscale-0.dll"

        <DllImport(SWSCALE_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Sub sws_freeContext(ByVal SwsContext As IntPtr)
        End Sub

        <DllImport(SWSCALE_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function sws_getContext(ByVal srcW As Integer, ByVal srcH As Integer, ByVal srcFormat As PixelFormat, ByVal dstW As Integer, ByVal dstH As Integer, ByVal dstFormat As PixelFormat, _
        ByVal flags As SwsFlags, ByVal srcFilter As SwsFilter, ByVal dstFilter As SwsFilter, ByVal param As Double) As IntPtr
        End Function

        <DllImport(SWSCALE_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function sws_scale(ByVal context As IntPtr, ByVal psrc As IntPtr, ByVal srcStride As Integer, _
                                         ByVal srcSliceY As Integer, ByVal srcSliceH As Integer, ByVal dst As IntPtr, ByVal dstStride As Integer) As Integer
        End Function

        <DllImport(SWSCALE_DLL_NAME), SuppressUnmanagedCodeSecurity(), Obsolete()> _
        Public Shared Function sws_scale_ordered(ByVal context As IntPtr, ByVal src As Integer, ByVal srcStride As Integer, ByVal srcSliceY As Integer, ByVal srcSliceH As Integer, ByVal dst As Integer, _
        ByVal dstStride As Integer) As Integer
        End Function

        <DllImport(SWSCALE_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function sws_setColorspaceDetails(ByVal c As IntPtr, ByVal inv_table As Integer, ByVal srcRange As Integer, ByVal table As Integer, ByVal dstRange As Integer, ByVal brightness As Integer, _
        ByVal contrast As Integer, ByVal saturation As Integer) As Integer
        End Function

        <DllImport(SWSCALE_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function sws_getColorspaceDetails(ByVal c As IntPtr, ByVal inv_table As Integer, ByVal srcRange As Integer, ByVal table As Integer, ByVal dstRange As Integer, ByVal brightness As Integer, _
        ByVal contrast As Integer, ByVal saturation As Integer) As Integer
        End Function

        <DllImport(SWSCALE_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function sws_getGaussianVec(ByVal variance As Double, ByVal quality As Double) As SwsVector
        End Function

        <DllImport(SWSCALE_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function sws_getConstVec(ByVal c As Double, ByVal length As Integer) As SwsVector
        End Function

        <DllImport(SWSCALE_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function sws_getIdentityVec() As SwsVector
        End Function

        <DllImport(SWSCALE_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Sub sws_scaleVec(ByVal a As SwsVector, ByVal scalar As Double)
        End Sub

        <DllImport(SWSCALE_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Sub sws_normalizeVec(ByVal a As SwsVector, ByVal height As Double)
        End Sub

        <DllImport(SWSCALE_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Sub sws_convVec(ByVal a As SwsVector, ByVal b As SwsVector)
        End Sub

        <DllImport(SWSCALE_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Sub sws_addVec(ByVal a As SwsVector, ByVal b As SwsVector)
        End Sub

        <DllImport(SWSCALE_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Sub sws_subVec(ByVal a As SwsVector, ByVal b As SwsVector)
        End Sub

        <DllImport(SWSCALE_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Sub sws_shiftVec(ByVal a As SwsVector, ByVal shift As Integer)
        End Sub

        <DllImport(SWSCALE_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function sws_cloneVec(ByVal a As SwsVector) As SwsVector
        End Function

        <DllImport(SWSCALE_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Sub sws_printVec(ByVal a As SwsVector)
        End Sub

        <DllImport(SWSCALE_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Sub sws_freeVec(ByVal a As SwsVector)
        End Sub

        <DllImport(SWSCALE_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function sws_getDefaultFilter(ByVal lumaGBlur As Single, ByVal chromaGBlur As Single, ByVal lumaSarpen As Single, ByVal chromaSharpen As Single, ByVal chromaHShift As Single, ByVal chromaVShift As Single, _
        ByVal verbose As Integer) As SwsFilter
        End Function

        <DllImport(SWSCALE_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Sub sws_freeFilter(ByVal filter As SwsFilter)
        End Sub

        <DllImport(SWSCALE_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function sws_getCachedContext(ByVal context As IntPtr, ByVal srcW As Integer, ByVal srcH As Integer, ByVal srcFormat As PixelFormat, ByVal dstW As Integer, ByVal dstH As Integer, _
        ByVal dstFormat As Integer, ByVal flags As SwsFlags, ByVal srcFilter As SwsFilter, ByVal dstFilter As SwsFilter, ByVal param As Double) As IntPtr
        End Function

        Public Const SWS_FAST_BILINEAR As Integer = 1
        Public Const SWS_BILINEAR As Integer = 2
        Public Const SWS_BICUBIC As Integer = 4
        Public Const SWS_X As Integer = 8
        Public Const SWS_POINT As Integer = &H10
        Public Const SWS_AREA As Integer = &H20
        Public Const SWS_BICUBLIN As Integer = &H40
        Public Const SWS_GAUSS As Integer = &H80
        Public Const SWS_SINC As Integer = &H100
        Public Const SWS_LANCZOS As Integer = &H200
        Public Const SWS_SPLINE As Integer = &H400

        Public Const SWS_SRC_V_CHR_DROP_MASK As Integer = &H30000
        Public Const SWS_SRC_V_CHR_DROP_SHIFT As Integer = 16

        Public Const SWS_PARAM_DEFAULT As Integer = 123456

        Public Const SWS_PRINT_INFO As Integer = &H1000

        'the following 3 flags are not completely implemented
        'internal chrominace subsampling info

        Public Const SWS_FULL_CHR_H_INT As Integer = &H2000
        '
        ''' <summary>
        ''' Input subsampling info
        ''' </summary>
        Public Const SWS_FULL_CHR_H_INP As Integer = &H4000

        Public Const SWS_DIRECT_BGR As Integer = &H8000

        Public Const SWS_ACCURATE_RND As Integer = &H40000

        Public Const SWS_CPU_CAPS_MMX As UInteger = &H80000000UI
        Public Const SWS_CPU_CAPS_MMX2 As Integer = &H20000000
        Public Const SWS_CPU_CAPS_3DNOW As Integer = &H40000000
        Public Const SWS_CPU_CAPS_ALTIVEC As Integer = &H10000000
        Public Const SWS_CPU_CAPS_BFIN As Integer = &H1000000

        Public Const SWS_MAX_REDUCE_CUTOFF As Double = 0.002

        Public Const MAX_FILTER_SIZE As Integer = 256

        Public Const SWS_CS_ITU709 As Integer = 1
        Public Const SWS_CS_FCC As Integer = 4
        Public Const SWS_CS_ITU601 As Integer = 5
        Public Const SWS_CS_ITU624 As Integer = 5
        Public Const SWS_CS_SMPTE170M As Integer = 5
        Public Const SWS_CS_SMPTE240M As Integer = 7
        Public Const SWS_CS_DEFAULT As Integer = 5

        <StructLayout(LayoutKind.Sequential)> _
        Public Structure SwsFilter
            Public lumH As SwsVector
            Public lumV As SwsVector
            Public chrH As SwsVector
            Public chrV As SwsVector
        End Structure

        <StructLayout(LayoutKind.Sequential)> _
        Public Structure SwsVector
            Public coeff As Double
            Public length As Integer
        End Structure

        <Flags()> _
        Public Enum SwsFlags
            FastBilinear = SWS_FAST_BILINEAR
            Bilinear = SWS_BILINEAR
            Bicubic = SWS_BICUBIC
            X = SWS_X
            Point = SWS_POINT
            Area = SWS_AREA
            Bicublin = SWS_BICUBLIN
            Gauss = SWS_GAUSS
            Sinc = SWS_SINC
            Lanczos = SWS_LANCZOS
            Spline = SWS_SPLINE
            SrcVChrDropMask = SWS_SRC_V_CHR_DROP_MASK
            SrcVChrDropShift = SWS_SRC_V_CHR_DROP_SHIFT
            ParamDefault = SWS_PARAM_DEFAULT
            PrintInfo = SWS_PRINT_INFO
            FullChrHInt = SWS_FULL_CHR_H_INT
            'internal chrominace subsampling info
            FullChrHInp = SWS_FULL_CHR_H_INP
            'input subsampling info
            DirectBGR = SWS_DIRECT_BGR
            AccurateRnd = SWS_ACCURATE_RND
        End Enum

    End Class

End Namespace
