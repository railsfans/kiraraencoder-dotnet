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

Imports System.Security
Imports System.Runtime.InteropServices
Imports FFmpegVB.FFmpeg.Libavutil

Namespace FFmpeg

    Partial Public Class Libavcodec

        Public Const AVCODEC_DLL_NAME As String = "avcodec-51.dll"

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function audio_resample_init(ByVal output_channels As Integer, ByVal input_channels As Integer, ByVal output_rate As Integer, ByVal input_rate As Integer) As IntPtr
        End Function

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function audio_resample(ByVal pResampleContext As IntPtr, ByVal output As IntPtr, ByVal intput As IntPtr, ByVal nb_samples As Integer) As Integer
        End Function

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Sub audio_resample_close(ByVal pResampleContext As IntPtr)
        End Sub

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function av_resample_init(ByVal out_rate As Integer, ByVal in_rate As Integer, ByVal filter_length As Integer, ByVal log2_phase_count As Integer, ByVal linear As Integer, ByVal cutoff As Double) As IntPtr
        End Function

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function av_resample(ByVal pAVResampleContext As IntPtr, ByVal dst As IntPtr, ByVal src As IntPtr, ByVal consumed As IntPtr, ByVal src_size As Integer, ByVal udpate_ctx As Integer) As Integer
        End Function

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Sub av_resample_compensate(ByVal pAVResampleContext As IntPtr, ByVal sample_delta As Integer, ByVal compensation_distance As Integer)
        End Sub

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Sub av_resample_close(ByVal pAVResampleContext As IntPtr)
        End Sub

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function img_resample_init(ByVal output_width As Integer, ByVal output_height As Integer, ByVal input_width As Integer, ByVal input_height As Integer) As IntPtr
        End Function

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function img_resample_full_init(ByVal owidth As Integer, ByVal oheight As Integer, ByVal iwidth As Integer, ByVal iheight As Integer, ByVal topBand As Integer, ByVal bottomBand As Integer, _
         ByVal leftBand As Integer, ByVal rightBand As Integer, ByVal padtop As Integer, ByVal padbottom As Integer, ByVal padleft As Integer, ByVal padright As Integer) As IntPtr
        End Function

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Sub img_resample(ByVal pImgReSampleContext As IntPtr, ByVal p_output_AVPicture As IntPtr, ByVal p_input_AVPicture As IntPtr)
        End Sub

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Sub ImgReSampleContext(ByVal pImgReSampleContext As IntPtr)
        End Sub

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function avpicture_alloc(ByVal AVPicture As IntPtr, ByVal pix_fmt As Integer, ByVal width As Integer, ByVal height As Integer) As Integer
        End Function

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Sub avpicture_free(ByVal pAVPicture As IntPtr)
        End Sub

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function avpicture_fill(ByVal pAVPicture As IntPtr, ByVal ptr As IntPtr, ByVal pix_fmt As Integer, ByVal width As Integer, ByVal height As Integer) As Integer
        End Function

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function avpicture_layout(ByVal p_src_AVPicture As IntPtr, ByVal pix_fmt As Integer, ByVal width As Integer, ByVal height As Integer, ByVal dest As IntPtr, ByVal dest_size As Integer) As Integer
        End Function

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function avpicture_get_size(ByVal pix_fmt As Integer, ByVal width As Integer, ByVal height As Integer) As Integer
        End Function

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Sub avcodec_get_chroma_sub_sample(ByVal pix_fmt As Integer, ByVal h_shift As IntPtr, ByVal v_shift As IntPtr)
        End Sub

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function avcodec_get_pix_fmt_name(ByVal pix_fmt As Integer) As [String]
        End Function

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Sub avcodec_set_dimensions(ByVal pAVCodecContext As IntPtr, ByVal width As Integer, ByVal height As Integer)
        End Sub

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function avcodec_get_pix_fmt(<MarshalAs(UnmanagedType.LPStr)> ByVal name As [String]) As PixelFormat
        End Function

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function avcodec_pix_fmt_to_codec_tag(ByVal p As PixelFormat) As UInteger
        End Function

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function avcodec_get_pix_fmt_loss(ByVal dst_pix_fmt As Integer, ByVal src_pix_fmt As Integer, ByVal has_alpha As Integer) As Integer
        End Function

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function avcodec_find_best_pix_fmt(ByVal pix_fmt_mask As Integer, ByVal src_pix_fmt As Integer, ByVal has_alpha As Integer, ByVal loss_ptr As IntPtr) As Integer
        End Function

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function img_get_alpha_info(ByVal pAVPicture As IntPtr, ByVal pix_fmt As Integer, ByVal width As Integer, ByVal height As Integer) As Integer
        End Function

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function img_convert(ByVal p_dst_AVPicture As IntPtr, ByVal dst_pix_fmt As Integer, ByVal p_src_AVPicture As IntPtr, ByVal pix_fmt As Integer, ByVal width As Integer, ByVal height As Integer) As Integer
        End Function

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function avpicture_deinterlace(ByVal p_dst_AVPicture As IntPtr, ByVal p_src_AVPicture As IntPtr, ByVal pix_fmt As Integer, ByVal width As Integer, ByVal height As Integer) As Integer
        End Function

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function avcodec_version() As UInteger
        End Function

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function avcodec_build() As UInteger
        End Function

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function avcodec_init() As UInteger
        End Function

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Sub register_avcodec(ByVal pAVCodec As IntPtr)
        End Sub

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function avcodec_find_encoder(ByVal id As CodecID) As IntPtr
        End Function

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function avcodec_find_encoder_by_name(<MarshalAs(UnmanagedType.LPStr)> ByVal mame As [String]) As IntPtr
        End Function

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function avcodec_find_decoder(ByVal id As CodecID) As IntPtr
        End Function

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function avcodec_find_decoder_by_name(<MarshalAs(UnmanagedType.LPStr)> ByVal mame As [String]) As IntPtr
        End Function

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Sub avcodec_string(<MarshalAs(UnmanagedType.LPStr)> ByVal mam As [String], ByVal buf_size As Integer, ByVal pAVCodeContext As IntPtr, ByVal encode As Integer)
        End Sub

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Sub avcodec_get_context_defaults(ByVal pAVCodecContext As IntPtr)
        End Sub

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function avcodec_alloc_context() As IntPtr
        End Function

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Sub avcodec_get_frame_defaults(ByVal pAVFrame As IntPtr)
        End Sub

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function avcodec_alloc_frame() As IntPtr
        End Function

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function avcodec_default_get_buffer(ByVal pAVCodecContext As IntPtr, ByVal pAVFrame As IntPtr) As Integer
        End Function

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Sub avcodec_default_release_buffer(ByVal pAVCodecContext As IntPtr, ByVal pAVFrame As IntPtr)
        End Sub

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Sub avcodec_default_reget_buffer(ByVal pAVCodecContext As IntPtr, ByVal pAVFrame As IntPtr)
        End Sub

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Sub avcodec_align_dimensions(ByVal pAVCodecContext As IntPtr, ByRef width As Integer, ByRef height As Integer)
        End Sub

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function avcodec_check_dimensions(ByVal av_log_ctx As IntPtr, ByRef width As UInteger, ByRef height As UInteger) As Integer
        End Function

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function avcodec_default_get_format(ByVal pAVCodecContext As IntPtr, ByRef fmt As PixelFormat) As PixelFormat
        End Function

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function avcodec_thread_init(ByVal pAVCodecContext As IntPtr, ByVal thread_count As Integer) As Integer
        End Function

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Sub avcodec_thread_free(ByVal pAVCodecContext As IntPtr)
        End Sub

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function avcodec_thread_execute(ByVal pAVCodecContext As IntPtr, <MarshalAs(UnmanagedType.FunctionPtr)> ByVal func As FuncCallback, <MarshalAs(UnmanagedType.LPArray)> ByVal arg As IntPtr(), ByRef ret As Integer, ByVal count As Integer) As Integer
        End Function

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function avcodec_default_execute(ByVal pAVCodecContext As IntPtr, <MarshalAs(UnmanagedType.FunctionPtr)> ByVal func As FuncCallback, <MarshalAs(UnmanagedType.LPArray)> ByVal arg As IntPtr(), ByRef ret As Integer, ByVal count As Integer) As Integer
        End Function

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function avcodec_open(ByVal pAVCodecContext As IntPtr, ByVal pAVCodec As IntPtr) As Integer
        End Function

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function avcodec_decode_audio(ByVal pAVCodecContext As IntPtr, ByVal samples As IntPtr, ByRef frame_size_ptr As Integer, ByVal buf As IntPtr, ByVal buf_size As Integer) As Integer
        End Function

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function avcodec_decode_video(ByVal pAVCodecContext As IntPtr, ByVal pAVFrame As IntPtr, ByRef got_picture_ptr As Integer, ByVal buf As IntPtr, ByVal buf_size As Integer) As Integer
        End Function

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function avcodec_decode_subtitle(ByVal pAVCodecContext As IntPtr, ByVal pAVSubtitle As IntPtr, ByRef got_sub_ptr As Integer, ByVal buf As IntPtr, ByVal buf_size As Integer) As Integer
        End Function

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function avcodec_parse_frame(ByVal pAVCodecContext As IntPtr, <MarshalAs(UnmanagedType.LPArray)> ByVal pdata As IntPtr(), ByVal data_size_ptr As IntPtr, ByVal buf As IntPtr, ByVal buf_size As Integer) As Integer
        End Function

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function avcodec_encode_audio(ByVal pAVCodecContext As IntPtr, ByVal buf As IntPtr, ByVal buf_size As Integer, ByVal samples As IntPtr) As Integer
        End Function

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function avcodec_encode_video(ByVal pAVCodecContext As IntPtr, ByVal buf As IntPtr, ByVal buf_size As Integer, ByVal pAVFrame As IntPtr) As Integer
        End Function

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function avcodec_encode_subtitle(ByVal pAVCodecContext As IntPtr, ByVal buf As IntPtr, ByVal buf_size As Integer, ByVal pAVSubtitle As IntPtr) As Integer
        End Function

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function avcodec_close(ByVal pAVCodecContext As IntPtr) As Integer
        End Function

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Sub avcodec_register_all()
        End Sub

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Sub avcodec_flush_buffers(ByVal pAVCodecContext As IntPtr)
        End Sub

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Sub avcodec_default_free_buffers(ByVal pAVCodecContext As IntPtr)
        End Sub

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function av_get_pict_type_char(ByVal pict_type As Integer) As Byte
        End Function

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function av_get_bits_per_sample(ByVal codec_id As CodecID) As Integer
        End Function

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Sub av_register_codec_parser(ByVal pAVcodecParser As IntPtr)
        End Sub

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function av_parser_init(ByVal codec_id As Integer) As IntPtr
        End Function

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function av_parser_parse(ByVal pAVCodecParserContext As IntPtr, ByVal pAVCodecContext As IntPtr, <MarshalAs(UnmanagedType.LPArray)> ByVal poutbuf As IntPtr(), ByRef poutbuf_size As Integer, ByVal buf As IntPtr, ByVal buf_size As Integer, _
         ByVal pts As Int64, ByVal dts As Int64) As Integer
        End Function

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function av_parser_change(ByVal pAVCodecParserContext As IntPtr, ByVal pAVCodecContext As IntPtr, <MarshalAs(UnmanagedType.LPArray)> ByVal poutbuf As IntPtr(), ByRef poutbuf_size As Integer, ByVal buf As IntPtr, ByVal buf_size As Integer, _
         ByVal keyframe As Integer) As Integer
        End Function

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Sub av_parser_close(ByVal pAVCodecParserContext As IntPtr)
        End Sub

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Sub av_register_bitstream_filter(ByVal pAVBitStreamFilter As IntPtr)
        End Sub

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function av_bitstream_filter_init(<MarshalAs(UnmanagedType.LPStr)> ByVal name As [String]) As IntPtr
        End Function

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function av_bitstream_filter_filter(ByVal pAVBitStreamFilterContext As IntPtr, ByVal pAVCodecContext As IntPtr, <MarshalAs(UnmanagedType.LPStr)> ByVal args As [String], <MarshalAs(UnmanagedType.LPArray)> ByVal poutbuf As IntPtr(), ByRef poutbuf_size As Integer, ByVal buf As IntPtr, _
         ByVal buf_size As Integer, ByVal keyframe As Integer) As Integer
        End Function

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Sub av_bitstream_filter_close(ByVal pAVBitStreamFilterContext As IntPtr)
        End Sub

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Sub av_mallocz(ByVal size As UInteger)
        End Sub

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function av_strdup(<MarshalAs(UnmanagedType.LPStr)> ByVal s As [String]) As IntPtr
        End Function

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Sub av_freep(ByVal ptr As IntPtr)
        End Sub

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Sub av_fast_realloc(ByVal ptr As IntPtr, ByRef size As UInteger, ByRef min_size As UInteger)
        End Sub

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Sub av_free_static()
        End Sub

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Sub av_mallocz_static(ByVal size As UInteger)
        End Sub

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Sub av_realloc_static(ByVal ptr As IntPtr, ByVal size As UInteger)
        End Sub

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Sub img_copy(ByVal pAVPicture As IntPtr, ByVal p_src_AVPicture As IntPtr, ByVal pix_fmt As Integer, ByVal width As Integer, ByVal height As Integer)
        End Sub

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function img_crop(ByVal p_dst_pAVPicture As IntPtr, ByVal p_src_pAVPicture As IntPtr, ByVal pix_fmt As Integer, ByVal top_band As Integer, ByVal left_band As Integer) As Integer
        End Function

        <DllImport(AVCODEC_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function img_pad(ByVal p_dst_pAVPicture As IntPtr, ByVal p_src_pAVPicture As IntPtr, ByVal height As Integer, ByVal width As Integer, ByVal pix_fmt As Integer, ByVal padtop As Integer, _
        ByVal padbottom As Integer, ByVal padleft As Integer, ByVal padright As Integer, ByRef color As Integer) As Integer
        End Function

        ' *********************************************************************************
        ' Constants
        ' *********************************************************************************

        ' 1 second of 48khz 32bit audio in bytes
        Public Const AVCODEC_MAX_AUDIO_FRAME_SIZE As Integer = 192000

        '*
        '      * Required number of additionally allocated bytes at the end of the input bitstream for decoding.
        '      * this is mainly needed because some optimized bitstream readers read
        '      * 32 or 64 bit at once and could read over the end<br>
        '      * Note, if the first 23 bits of the additional bytes are not 0 then damaged
        '      * MPEG bitstreams could cause overread and segfault
        '      

        Public Const FF_INPUT_BUFFER_PADDING_SIZE As Integer = 8

        '*
        '         * minimum encoding buffer size.
        '         * used to avoid some checks during header writing
        '         

        Public Const FF_MIN_BUFFER_SIZE As Integer = 16384

        Public Const FF_MAX_B_FRAMES As Integer = 16

        ' encoding support
        '           these flags can be passed in AVCodecContext.flags before initing
        '           Note: not everything is supported yet.
        '        


        Public Const CODEC_FLAG_QSCALE As Integer = &H2
        ' use fixed qscale
        Public Const CODEC_FLAG_4MV As Integer = &H4
        ' 4 MV per MB allowed / Advanced prediction for H263
        Public Const CODEC_FLAG_QPEL As Integer = &H10
        ' use qpel MC
        Public Const CODEC_FLAG_GMC As Integer = &H20
        ' use GMC
        Public Const CODEC_FLAG_MV0 As Integer = &H40
        ' always try a MB with MV=<0,0>
        Public Const CODEC_FLAG_PART As Integer = &H80
        ' use data partitioning
        ' parent program gurantees that the input for b-frame containing streams is not written to
        '           for at least s->max_b_frames+1 frames, if this is not set than the input will be copied 
        Public Const CODEC_FLAG_INPUT_PRESERVED As Integer = &H100
        Public Const CODEC_FLAG_PASS1 As Integer = &H200
        ' use internal 2pass ratecontrol in first  pass mode
        Public Const CODEC_FLAG_PASS2 As Integer = &H400
        ' use internal 2pass ratecontrol in second pass mode
        Public Const CODEC_FLAG_EXTERN_HUFF As Integer = &H1000
        ' use external huffman table (for mjpeg)
        Public Const CODEC_FLAG_GRAY As Integer = &H2000
        ' only decode/encode grayscale
        Public Const CODEC_FLAG_EMU_EDGE As Integer = &H4000
        ' don't draw edges
        Public Const CODEC_FLAG_PSNR As Integer = &H8000
        ' error[?] variables will be set during encoding
        Public Const CODEC_FLAG_TRUNCATED As Integer = &H10000
        '* input bitstream might be truncated at a random location instead
        '                                            of only at frame boundaries 
        Public Const CODEC_FLAG_NORMALIZE_AQP As Integer = &H20000
        ' normalize adaptive quantization
        Public Const CODEC_FLAG_INTERLACED_DCT As Integer = &H40000
        ' use interlaced dct
        Public Const CODEC_FLAG_LOW_DELAY As Integer = &H80000
        ' force low delay
        Public Const CODEC_FLAG_ALT_SCAN As Integer = &H100000
        ' use alternate scan
        Public Const CODEC_FLAG_TRELLIS_QUANT As Integer = &H200000
        ' use trellis quantization
        Public Const CODEC_FLAG_GLOBAL_HEADER As Integer = &H400000
        ' place global headers in extradata instead of every keyframe
        Public Const CODEC_FLAG_BITEXACT As Integer = &H800000
        ' use only bitexact stuff (except (i)dct)
        ' Fx : Flag for h263+ extra options 
        Public Const CODEC_FLAG_H263P_AIC As Integer = &H1000000
        ' H263 Advanced intra coding / MPEG4 AC prediction (remove this)
        Public Const CODEC_FLAG_AC_PRED As Integer = &H1000000
        ' H263 Advanced intra coding / MPEG4 AC prediction
        Public Const CODEC_FLAG_H263P_UMV As Integer = &H2000000
        ' Unlimited motion vector
        Public Const CODEC_FLAG_CBP_RD As Integer = &H4000000
        ' use rate distortion optimization for cbp
        Public Const CODEC_FLAG_QP_RD As Integer = &H8000000
        ' use rate distortion optimization for qp selectioon
        Public Const CODEC_FLAG_H263P_AIV As Integer = &H8
        ' H263 Alternative inter vlc
        Public Const CODEC_FLAG_OBMC As Integer = &H1
        ' OBMC
        Public Const CODEC_FLAG_LOOP_FILTER As Integer = &H800
        ' loop filter
        Public Const CODEC_FLAG_H263P_SLICE_STRUCT As Integer = &H10000000
        Public Const CODEC_FLAG_INTERLACED_ME As Integer = &H20000000
        ' interlaced motion estimation
        Public Const CODEC_FLAG_SVCD_SCAN_OFFSET As Integer = &H40000000
        ' will reserve space for SVCD scan offset user data
        Public Const CODEC_FLAG_CLOSED_GOP As UInteger = CUInt(&H80000000UI)
        Public Const CODEC_FLAG2_FAST As Integer = &H1
        ' allow non spec compliant speedup tricks
        Public Const CODEC_FLAG2_STRICT_GOP As Integer = &H2
        ' strictly enforce GOP size
        Public Const CODEC_FLAG2_NO_OUTPUT As Integer = &H4
        ' skip bitstream encoding
        Public Const CODEC_FLAG2_LOCAL_HEADER As Integer = &H8
        ' place global headers at every keyframe instead of in extradata
        Public Const CODEC_FLAG2_BPYRAMID As Integer = &H10
        ' H.264 allow b-frames to be used as references
        Public Const CODEC_FLAG2_WPRED As Integer = &H20
        ' H.264 weighted biprediction for b-frames
        Public Const CODEC_FLAG2_MIXED_REFS As Integer = &H40
        ' H.264 multiple references per partition
        Public Const CODEC_FLAG2_8X8DCT As Integer = &H80
        ' H.264 high profile 8x8 transform
        Public Const CODEC_FLAG2_FASTPSKIP As Integer = &H100
        ' H.264 fast pskip
        Public Const CODEC_FLAG2_AUD As Integer = &H200
        ' H.264 access unit delimiters
        Public Const CODEC_FLAG2_BRDO As Integer = &H400
        ' b-frame rate-distortion optimization
        Public Const CODEC_FLAG2_INTRA_VLC As Integer = &H800
        ' use MPEG-2 intra VLC table
        Public Const CODEC_FLAG2_MEMC_ONLY As Integer = &H1000
        ' only do ME/MC (I frames -> ref, P frame -> ME+MC)
        ' Unsupported options :
        '         * Syntax Arithmetic coding (SAC)
        '         * Reference Picture Selection
        '         * Independant Segment Decoding 

        ' /Fx 

        ' codec capabilities 

        Public Const CODEC_CAP_DRAW_HORIZ_BAND As Integer = &H1
        ' decoder can use draw_horiz_band callback
        '*
        '         * Codec uses get_buffer() for allocating buffers.
        '         * direct rendering method 1
        '         

        Public Const CODEC_CAP_DR1 As Integer = &H2

        ' if 'parse_only' field is true, then avcodec_parse_frame() can be
        '            used 

        Public Const CODEC_CAP_PARSE_ONLY As Integer = &H4
        Public Const CODEC_CAP_TRUNCATED As Integer = &H8

        ' codec can export data for HW decoding (XvMC) 

        Public Const CODEC_CAP_HWACCEL As Integer = &H10

        '*
        '         * codec has a non zero delay and needs to be feeded with NULL at the end to get the delayed data.
        '         * if this is not set, the codec is guranteed to never be feeded with NULL data
        '         

        Public Const CODEC_CAP_DELAY As Integer = &H20

        '*
        '         * Codec can be fed a final frame with a smaller size.
        '         * This can be used to prevent truncation of the last audio samples.
        '        

        Public Const CODEC_CAP_SMALL_LAST_FRAME As Integer = &H40

        'the following defines may change, don't expect compatibility if you use them
        Public Const MB_TYPE_INTRA4x4 As Integer = &H1
        Public Const MB_TYPE_INTRA16x16 As Integer = &H2
        'FIXME h264 specific
        Public Const MB_TYPE_INTRA_PCM As Integer = &H4
        'FIXME h264 specific
        Public Const MB_TYPE_16x16 As Integer = &H8
        Public Const MB_TYPE_16x8 As Integer = &H10
        Public Const MB_TYPE_8x16 As Integer = &H20
        Public Const MB_TYPE_8x8 As Integer = &H40
        Public Const MB_TYPE_INTERLACED As Integer = &H80
        Public Const MB_TYPE_DIRECT2 As Integer = &H100
        'FIXME
        Public Const MB_TYPE_ACPRED As Integer = &H200
        Public Const MB_TYPE_GMC As Integer = &H400
        Public Const MB_TYPE_SKIP As Integer = &H800
        Public Const MB_TYPE_P0L0 As Integer = &H1000
        Public Const MB_TYPE_P1L0 As Integer = &H2000
        Public Const MB_TYPE_P0L1 As Integer = &H4000
        Public Const MB_TYPE_P1L1 As Integer = &H8000
        Public Const MB_TYPE_L0 As Integer = (MB_TYPE_P0L0 Or MB_TYPE_P1L0)
        Public Const MB_TYPE_L1 As Integer = (MB_TYPE_P0L1 Or MB_TYPE_P1L1)
        Public Const MB_TYPE_L0L1 As Integer = (MB_TYPE_L0 Or MB_TYPE_L1)
        Public Const MB_TYPE_QUANT As Integer = &H10000
        Public Const MB_TYPE_CBP As Integer = &H20000
        'Note bits 24-31 are reserved for codec specific use (h264 ref0, mpeg1 0mv, ...)

        Public Const FF_QSCALE_TYPE_MPEG1 As Integer = 0
        Public Const FF_QSCALE_TYPE_MPEG2 As Integer = 1
        Public Const FF_QSCALE_TYPE_H264 As Integer = 2

        Public Const FF_BUFFER_TYPE_INTERNAL As Integer = 1
        Public Const FF_BUFFER_TYPE_USER As Integer = 2
        ' Direct rendering buffers (image is (de)allocated by user)
        Public Const FF_BUFFER_TYPE_SHARED As Integer = 4
        ' buffer from somewhere else, don't dealloc image (data/base), all other tables are not shared
        Public Const FF_BUFFER_TYPE_COPY As Integer = 8
        ' just a (modified) copy of some other buffer, don't dealloc anything
        Public Const FF_I_TYPE As Integer = 1
        ' Intra
        Public Const FF_P_TYPE As Integer = 2
        ' Predicted
        Public Const FF_B_TYPE As Integer = 3
        ' Bi-dir predicted
        Public Const FF_S_TYPE As Integer = 4
        ' S(GMC)-VOP MPEG4
        Public Const FF_SI_TYPE As Integer = 5
        Public Const FF_SP_TYPE As Integer = 6

        Public Const FF_BUFFER_HINTS_VALID As Integer = &H1
        ' Buffer hints value is meaningful (if 0 ignore)
        Public Const FF_BUFFER_HINTS_READABLE As Integer = &H2
        ' Codec will read from buffer
        Public Const FF_BUFFER_HINTS_PRESERVE As Integer = &H4
        ' User must not alter buffer content
        Public Const FF_BUFFER_HINTS_REUSABLE As Integer = &H8
        ' Codec will reuse the buffer (update)
        Public Const DEFAULT_FRAME_RATE_BASE As Integer = 1001000

        Public Const FF_ASPECT_EXTENDED As Integer = 15

        Public Const FF_RC_STRATEGY_XVID As Integer = 1

        Public Const FF_BUG_AUTODETECT As Integer = 1
        ' autodetection
        Public Const FF_BUG_OLD_MSMPEG4 As Integer = 2
        Public Const FF_BUG_XVID_ILACE As Integer = 4
        Public Const FF_BUG_UMP4 As Integer = 8
        Public Const FF_BUG_NO_PADDING As Integer = 16
        Public Const FF_BUG_AMV As Integer = 32
        Public Const FF_BUG_AC_VLC As Integer = 0
        ' will be removed, libavcodec can now handle these non compliant files by default
        Public Const FF_BUG_QPEL_CHROMA As Integer = 64
        Public Const FF_BUG_STD_QPEL As Integer = 128
        Public Const FF_BUG_QPEL_CHROMA2 As Integer = 256
        Public Const FF_BUG_DIRECT_BLOCKSIZE As Integer = 512
        Public Const FF_BUG_EDGE As Integer = 1024
        Public Const FF_BUG_HPEL_CHROMA As Integer = 2048
        Public Const FF_BUG_DC_CLIP As Integer = 4096
        Public Const FF_BUG_MS As Integer = 8192
        ' workaround various bugs in microsofts broken decoders
        ' public const int FF_BUG_FAKE_SCALABILITY =16; //autodetection should work 100%
        Public Const FF_COMPLIANCE_VERY_STRICT As Integer = 2
        ' strictly conform to a older more strict version of the spec or reference software
        Public Const FF_COMPLIANCE_STRICT As Integer = 1
        ' strictly conform to all the things in the spec no matter what consequences
        Public Const FF_COMPLIANCE_NORMAL As Integer = 0
        Public Const FF_COMPLIANCE_INOFFICIAL As Integer = -1
        ' allow inofficial extensions
        Public Const FF_COMPLIANCE_EXPERIMENTAL As Integer = -2
        ' allow non standarized experimental things
        Public Const FF_ER_CAREFUL As Integer = 1
        Public Const FF_ER_COMPLIANT As Integer = 2
        Public Const FF_ER_AGGRESSIVE As Integer = 3
        Public Const FF_ER_VERY_AGGRESSIVE As Integer = 4

        Public Const FF_DCT_AUTO As Integer = 0
        Public Const FF_DCT_FASTINT As Integer = 1
        Public Const FF_DCT_INT As Integer = 2
        Public Const FF_DCT_MMX As Integer = 3
        Public Const FF_DCT_MLIB As Integer = 4
        Public Const FF_DCT_ALTIVEC As Integer = 5
        Public Const FF_DCT_FAAN As Integer = 6

        Public Const FF_IDCT_AUTO As Integer = 0
        Public Const FF_IDCT_INT As Integer = 1
        Public Const FF_IDCT_SIMPLE As Integer = 2
        Public Const FF_IDCT_SIMPLEMMX As Integer = 3
        Public Const FF_IDCT_LIBMPEG2MMX As Integer = 4
        Public Const FF_IDCT_PS2 As Integer = 5
        Public Const FF_IDCT_MLIB As Integer = 6
        Public Const FF_IDCT_ARM As Integer = 7
        Public Const FF_IDCT_ALTIVEC As Integer = 8
        Public Const FF_IDCT_SH4 As Integer = 9
        Public Const FF_IDCT_SIMPLEARM As Integer = 10
        Public Const FF_IDCT_H264 As Integer = 11
        Public Const FF_IDCT_VP3 As Integer = 12
        Public Const FF_IDCT_IPP As Integer = 13
        Public Const FF_IDCT_XVIDMMX As Integer = 14
        Public Const FF_IDCT_CAVS As Integer = 15

        Public Const FF_EC_GUESS_MVS As Integer = 1
        Public Const FF_EC_DEBLOCK As Integer = 2

        Public Const FF_MM_FORCE As UInteger = &H80000000UI
        ' force usage of selected flags (OR) 
        '    /* lower 16 bits - CPU features */

        Public Const FF_MM_MMX As Integer = &H1
        ' standard MMX 
        Public Const FF_MM_3DNOW As Integer = &H4
        ' AMD 3DNOW 
        Public Const FF_MM_MMXEXT As Integer = &H2
        ' SSE integer functions or AMD MMX ext 
        Public Const FF_MM_SSE As Integer = &H8
        ' SSE functions 
        Public Const FF_MM_SSE2 As Integer = &H10
        ' PIV SSE2 functions 
        Public Const FF_MM_3DNOWEXT As Integer = &H20
        ' AMD 3DNowExt 

        Public Const FF_MM_IWMMXT As Integer = &H100
        ' XScale IWMMXT 

        Public Const FF_PRED_LEFT As Integer = 0
        Public Const FF_PRED_PLANE As Integer = 1
        Public Const FF_PRED_MEDIAN As Integer = 2

        Public Const FF_DEBUG_PICT_INFO As Integer = 1
        Public Const FF_DEBUG_RC As Integer = 2
        Public Const FF_DEBUG_BITSTREAM As Integer = 4
        Public Const FF_DEBUG_MB_TYPE As Integer = 8
        Public Const FF_DEBUG_QP As Integer = 16
        Public Const FF_DEBUG_MV As Integer = 32
        Public Const FF_DEBUG_DCT_COEFF As Integer = &H40
        Public Const FF_DEBUG_SKIP As Integer = &H80
        Public Const FF_DEBUG_STARTCODE As Integer = &H100
        Public Const FF_DEBUG_PTS As Integer = &H200
        Public Const FF_DEBUG_ER As Integer = &H400
        Public Const FF_DEBUG_MMCO As Integer = &H800
        Public Const FF_DEBUG_BUGS As Integer = &H1000
        Public Const FF_DEBUG_VIS_QP As Integer = &H2000
        Public Const FF_DEBUG_VIS_MB_TYPE As Integer = &H4000

        Public Const FF_DEBUG_VIS_MV_P_FOR As Integer = &H1
        'visualize forward predicted MVs of P frames
        Public Const FF_DEBUG_VIS_MV_B_FOR As Integer = &H2
        'visualize forward predicted MVs of B frames
        Public Const FF_DEBUG_VIS_MV_B_BACK As Integer = &H4
        'visualize backward predicted MVs of B frames
        Public Const FF_CMP_SAD As Integer = 0
        Public Const FF_CMP_SSE As Integer = 1
        Public Const FF_CMP_SATD As Integer = 2
        Public Const FF_CMP_DCT As Integer = 3
        Public Const FF_CMP_PSNR As Integer = 4
        Public Const FF_CMP_BIT As Integer = 5
        Public Const FF_CMP_RD As Integer = 6
        Public Const FF_CMP_ZERO As Integer = 7
        Public Const FF_CMP_VSAD As Integer = 8
        Public Const FF_CMP_VSSE As Integer = 9
        Public Const FF_CMP_NSSE As Integer = 10
        Public Const FF_CMP_W53 As Integer = 11
        Public Const FF_CMP_W97 As Integer = 12
        Public Const FF_CMP_DCTMAX As Integer = 13
        Public Const FF_CMP_DCT264 As Integer = 14
        Public Const FF_CMP_CHROMA As Integer = 256

        Public Const FF_DTG_AFD_SAME As Integer = 8
        Public Const FF_DTG_AFD_4_3 As Integer = 9
        Public Const FF_DTG_AFD_16_9 As Integer = 10
        Public Const FF_DTG_AFD_14_9 As Integer = 11
        Public Const FF_DTG_AFD_4_3_SP_14_9 As Integer = 13
        Public Const FF_DTG_AFD_16_9_SP_14_9 As Integer = 14
        Public Const FF_DTG_AFD_SP_4_3 As Integer = 15

        Public Const FF_DEFAULT_QUANT_BIAS As Integer = 999999

        Public Const FF_LAMBDA_SHIFT As Integer = 7
        Public Const FF_LAMBDA_SCALE As Integer = (1 << FF_LAMBDA_SHIFT)
        Public Const FF_QP2LAMBDA As Integer = 118
        ' factor to convert from H.263 QP to lambda
        Public Const FF_LAMBDA_MAX As Integer = (256 * 128 - 1)

        Public Const FF_CODER_TYPE_VLC As Integer = 0
        Public Const FF_CODER_TYPE_AC As Integer = 1

        Public Const SLICE_FLAG_CODED_ORDER As Integer = &H1
        ' draw_horiz_band() is called in coded order instead of display
        Public Const SLICE_FLAG_ALLOW_FIELD As Integer = &H2
        ' allow draw_horiz_band() with field slices (MPEG2 field pics)
        Public Const SLICE_FLAG_ALLOW_PLANE As Integer = &H4
        ' allow draw_horiz_band() with 1 component at a time (SVQ1)

        Public Const FF_MB_DECISION_SIMPLE As Integer = 0
        ' uses mb_cmp
        Public Const FF_MB_DECISION_BITS As Integer = 1
        ' chooses the one which needs the fewest bits
        Public Const FF_MB_DECISION_RD As Integer = 2
        ' rate distoration
        Public Const FF_AA_AUTO As Integer = 0
        Public Const FF_AA_FASTINT As Integer = 1
        'not implemented yet
        Public Const FF_AA_INT As Integer = 2
        Public Const FF_AA_FLOAT As Integer = 3

        Public Const FF_PROFILE_UNKNOWN As Integer = -99

        Public Const FF_LEVEL_UNKNOWN As Integer = -99

        Public Const X264_PART_I4X4 As Integer = &H1
        ' Analyse i4x4 
        Public Const X264_PART_I8X8 As Integer = &H2
        ' Analyse i8x8 (requires 8x8 transform) 
        Public Const X264_PART_P8X8 As Integer = &H10
        ' Analyse p16x8, p8x16 and p8x8 
        Public Const X264_PART_P4X4 As Integer = &H20
        ' Analyse p8x4, p4x8, p4x4 
        Public Const X264_PART_B8X8 As Integer = &H100
        ' Analyse b16x8, b8x16 and b8x8 

        Public Const FF_COMPRESSION_DEFAULT As Integer = -1

        Public Const AVPALETTE_SIZE As Integer = 1024
        Public Const AVPALETTE_COUNT As Integer = 256

        Public Const FF_LOSS_RESOLUTION As Integer = &H1
        ' loss due to resolution change 
        Public Const FF_LOSS_DEPTH As Integer = &H2
        ' loss due to color depth change 
        Public Const FF_LOSS_COLORSPACE As Integer = &H4
        ' loss due to color space conversion 
        Public Const FF_LOSS_ALPHA As Integer = &H8
        ' loss of alpha bits 
        Public Const FF_LOSS_COLORQUANT As Integer = &H10
        ' loss due to color quantization 
        Public Const FF_LOSS_CHROMA As Integer = &H20
        ' loss of chroma (e.g. rgb to gray conversion) 

        Public Const FF_ALPHA_TRANSP As Integer = &H1
        ' image has some totally transparent pixels 
        Public Const FF_ALPHA_SEMI_TRANSP As Integer = &H2
        ' image has some transparent pixels 
        Public Const AV_PARSER_PTS_NB As Integer = 4

        Public Const PARSER_FLAG_COMPLETE_FRAMES As Integer = &H1

        ' *********************************************************************************
        ' Enums
        ' *********************************************************************************

        Public Enum CodecID
            CODEC_ID_NONE

            '/* video codecs */
            CODEC_ID_MPEG1VIDEO
            CODEC_ID_MPEG2VIDEO '///< preferred ID for MPEG-1/2 video decoding
            CODEC_ID_MPEG2VIDEO_XVMC
            CODEC_ID_H261
            CODEC_ID_H263
            CODEC_ID_RV10
            CODEC_ID_RV20
            CODEC_ID_MJPEG
            CODEC_ID_MJPEGB
            CODEC_ID_LJPEG
            CODEC_ID_SP5X
            CODEC_ID_JPEGLS
            CODEC_ID_MPEG4
            CODEC_ID_RAWVIDEO
            CODEC_ID_MSMPEG4V1
            CODEC_ID_MSMPEG4V2
            CODEC_ID_MSMPEG4V3
            CODEC_ID_WMV1
            CODEC_ID_WMV2
            CODEC_ID_H263P
            CODEC_ID_H263I
            CODEC_ID_FLV1
            CODEC_ID_SVQ1
            CODEC_ID_SVQ3
            CODEC_ID_DVVIDEO
            CODEC_ID_HUFFYUV
            CODEC_ID_CYUV
            CODEC_ID_H264
            CODEC_ID_INDEO3
            CODEC_ID_VP3
            CODEC_ID_THEORA
            CODEC_ID_ASV1
            CODEC_ID_ASV2
            CODEC_ID_FFV1
            CODEC_ID_4XM
            CODEC_ID_VCR1
            CODEC_ID_CLJR
            CODEC_ID_MDEC
            CODEC_ID_ROQ
            CODEC_ID_INTERPLAY_VIDEO
            CODEC_ID_XAN_WC3
            CODEC_ID_XAN_WC4
            CODEC_ID_RPZA
            CODEC_ID_CINEPAK
            CODEC_ID_WS_VQA
            CODEC_ID_MSRLE
            CODEC_ID_MSVIDEO1
            CODEC_ID_IDCIN
            CODEC_ID_8BPS
            CODEC_ID_SMC
            CODEC_ID_FLIC
            CODEC_ID_TRUEMOTION1
            CODEC_ID_VMDVIDEO
            CODEC_ID_MSZH
            CODEC_ID_ZLIB
            CODEC_ID_QTRLE
            CODEC_ID_SNOW
            CODEC_ID_TSCC
            CODEC_ID_ULTI
            CODEC_ID_QDRAW
            CODEC_ID_VIXL
            CODEC_ID_QPEG
            CODEC_ID_PNG
            CODEC_ID_PPM
            CODEC_ID_PBM
            CODEC_ID_PGM
            CODEC_ID_PGMYUV
            CODEC_ID_PAM
            CODEC_ID_FFVHUFF
            CODEC_ID_RV30
            CODEC_ID_RV40
            CODEC_ID_VC1
            CODEC_ID_WMV3
            CODEC_ID_LOCO
            CODEC_ID_WNV1
            CODEC_ID_AASC
            CODEC_ID_INDEO2
            CODEC_ID_FRAPS
            CODEC_ID_TRUEMOTION2
            CODEC_ID_BMP
            CODEC_ID_CSCD
            CODEC_ID_MMVIDEO
            CODEC_ID_ZMBV
            CODEC_ID_AVS
            CODEC_ID_SMACKVIDEO
            CODEC_ID_NUV
            CODEC_ID_KMVC
            CODEC_ID_FLASHSV
            CODEC_ID_CAVS
            CODEC_ID_JPEG2000
            CODEC_ID_VMNC
            CODEC_ID_VP5
            CODEC_ID_VP6
            CODEC_ID_VP6F
            CODEC_ID_TARGA
            CODEC_ID_DSICINVIDEO
            CODEC_ID_TIERTEXSEQVIDEO
            CODEC_ID_TIFF
            CODEC_ID_GIF
            CODEC_ID_FFH264
            CODEC_ID_DXA
            CODEC_ID_DNXHD
            CODEC_ID_THP
            CODEC_ID_SGI
            CODEC_ID_C93
            CODEC_ID_BETHSOFTVID
            CODEC_ID_PTX
            CODEC_ID_TXD
            CODEC_ID_VP6A
            CODEC_ID_AMV
            CODEC_ID_VB
            CODEC_ID_PCX
            CODEC_ID_SUNRAST
            CODEC_ID_INDEO4
            CODEC_ID_INDEO5
            CODEC_ID_MIMIC
            CODEC_ID_RL2
            CODEC_ID_8SVX_EXP
            CODEC_ID_8SVX_FIB
            CODEC_ID_ESCAPE124
            CODEC_ID_DIRAC
            CODEC_ID_BFI
            CODEC_ID_CMV
            CODEC_ID_MOTIONPIXELS
            CODEC_ID_TGV
            CODEC_ID_TGQ
            CODEC_ID_TQI
            CODEC_ID_AURA
            CODEC_ID_AURA2
            CODEC_ID_V210X
            CODEC_ID_TMV
            CODEC_ID_V210
            CODEC_ID_DPX
            CODEC_ID_MAD
            CODEC_ID_FRWU
            CODEC_ID_FLASHSV2
            CODEC_ID_CDGRAPHICS
            CODEC_ID_R210
            CODEC_ID_ANM
            CODEC_ID_BINKVIDEO
            CODEC_ID_IFF_ILBM
            CODEC_ID_IFF_BYTERUN1
            CODEC_ID_KGV1
            CODEC_ID_YOP
            CODEC_ID_VP8
            CODEC_ID_PICTOR
            CODEC_ID_ANSI
            CODEC_ID_A64_MULTI
            CODEC_ID_A64_MULTI5
            CODEC_ID_R10K
            CODEC_ID_MXPEG
            CODEC_ID_LAGARITH
            CODEC_ID_PRORES
            CODEC_ID_JV
            CODEC_ID_DFA

            '/* various PCM "codecs" */
            CODEC_ID_PCM_S16LE = &H10000
            CODEC_ID_PCM_S16BE
            CODEC_ID_PCM_U16LE
            CODEC_ID_PCM_U16BE
            CODEC_ID_PCM_S8
            CODEC_ID_PCM_U8
            CODEC_ID_PCM_MULAW
            CODEC_ID_PCM_ALAW
            CODEC_ID_PCM_S32LE
            CODEC_ID_PCM_S32BE
            CODEC_ID_PCM_U32LE
            CODEC_ID_PCM_U32BE
            CODEC_ID_PCM_S24LE
            CODEC_ID_PCM_S24BE
            CODEC_ID_PCM_U24LE
            CODEC_ID_PCM_U24BE
            CODEC_ID_PCM_S24DAUD
            CODEC_ID_PCM_ZORK
            CODEC_ID_PCM_S16LE_PLANAR
            CODEC_ID_PCM_DVD
            CODEC_ID_PCM_F32BE
            CODEC_ID_PCM_F32LE
            CODEC_ID_PCM_F64BE
            CODEC_ID_PCM_F64LE
            CODEC_ID_PCM_BLURAY
            CODEC_ID_PCM_LXF
            CODEC_ID_S302M

            '/* various ADPCM codecs */
            CODEC_ID_ADPCM_IMA_QT = &H11000
            CODEC_ID_ADPCM_IMA_WAV
            CODEC_ID_ADPCM_IMA_DK3
            CODEC_ID_ADPCM_IMA_DK4
            CODEC_ID_ADPCM_IMA_WS
            CODEC_ID_ADPCM_IMA_SMJPEG
            CODEC_ID_ADPCM_MS
            CODEC_ID_ADPCM_4XM
            CODEC_ID_ADPCM_XA
            CODEC_ID_ADPCM_ADX
            CODEC_ID_ADPCM_EA
            CODEC_ID_ADPCM_G726
            CODEC_ID_ADPCM_CT
            CODEC_ID_ADPCM_SWF
            CODEC_ID_ADPCM_YAMAHA
            CODEC_ID_ADPCM_SBPRO_4
            CODEC_ID_ADPCM_SBPRO_3
            CODEC_ID_ADPCM_SBPRO_2
            CODEC_ID_ADPCM_THP
            CODEC_ID_ADPCM_IMA_AMV
            CODEC_ID_ADPCM_EA_R1
            CODEC_ID_ADPCM_EA_R3
            CODEC_ID_ADPCM_EA_R2
            CODEC_ID_ADPCM_IMA_EA_SEAD
            CODEC_ID_ADPCM_IMA_EA_EACS
            CODEC_ID_ADPCM_EA_XAS
            CODEC_ID_ADPCM_EA_MAXIS_XA
            CODEC_ID_ADPCM_IMA_ISS
            CODEC_ID_ADPCM_G722

            '/* AMR */
            CODEC_ID_AMR_NB = &H12000
            CODEC_ID_AMR_WB

            '/* RealAudio codecs*/
            CODEC_ID_RA_144 = &H13000
            CODEC_ID_RA_288

            '/* various DPCM codecs */
            CODEC_ID_ROQ_DPCM = &H14000
            CODEC_ID_INTERPLAY_DPCM
            CODEC_ID_XAN_DPCM
            CODEC_ID_SOL_DPCM

            '/* audio codecs */
            CODEC_ID_MP2 = &H15000
            CODEC_ID_MP3 '///< preferred ID for decoding MPEG audio layer 1 2 or 3
            CODEC_ID_AAC
            CODEC_ID_AC3
            CODEC_ID_DTS
            CODEC_ID_VORBIS
            CODEC_ID_DVAUDIO
            CODEC_ID_WMAV1
            CODEC_ID_WMAV2
            CODEC_ID_MACE3
            CODEC_ID_MACE6
            CODEC_ID_VMDAUDIO
            CODEC_ID_SONIC
            CODEC_ID_SONIC_LS
            CODEC_ID_FLAC
            CODEC_ID_MP3ADU
            CODEC_ID_MP3ON4
            CODEC_ID_SHORTEN
            CODEC_ID_ALAC
            CODEC_ID_WESTWOOD_SND1
            CODEC_ID_GSM '///< as in Berlin toast format
            CODEC_ID_QDM2
            CODEC_ID_COOK
            CODEC_ID_TRUESPEECH
            CODEC_ID_TTA
            CODEC_ID_SMACKAUDIO
            CODEC_ID_QCELP
            CODEC_ID_WAVPACK
            CODEC_ID_DSICINAUDIO
            CODEC_ID_IMC
            CODEC_ID_MUSEPACK7
            CODEC_ID_MLP
            CODEC_ID_GSM_MS '/* as found in WAV */
            CODEC_ID_ATRAC3
            CODEC_ID_VOXWARE
            CODEC_ID_APE
            CODEC_ID_NELLYMOSER
            CODEC_ID_MUSEPACK8
            CODEC_ID_SPEEX
            CODEC_ID_WMAVOICE
            CODEC_ID_WMAPRO
            CODEC_ID_WMALOSSLESS
            CODEC_ID_ATRAC3P
            CODEC_ID_EAC3
            CODEC_ID_SIPR
            CODEC_ID_MP1
            CODEC_ID_TWINVQ
            CODEC_ID_TRUEHD
            CODEC_ID_MP4ALS
            CODEC_ID_ATRAC1
            CODEC_ID_BINKAUDIO_RDFT
            CODEC_ID_BINKAUDIO_DCT
            CODEC_ID_AAC_LATM
            CODEC_ID_QDMC
            CODEC_ID_CELT

            '/* subtitle codecs */
            CODEC_ID_DVD_SUBTITLE = &H17000
            CODEC_ID_DVB_SUBTITLE
            CODEC_ID_TEXT  '///< raw UTF-8 text
            CODEC_ID_XSUB
            CODEC_ID_SSA
            CODEC_ID_MOV_TEXT
            CODEC_ID_HDMV_PGS_SUBTITLE
            CODEC_ID_DVB_TELETEXT
            CODEC_ID_SRT
            CODEC_ID_MICRODVD

            '/* other specific kind of codecs (generally used for attachments) */
            CODEC_ID_TTF = &H18000

            CODEC_ID_PROBE = &H19000 '///< codec_id is not known (like CODEC_ID_NONE) but lavf should attempt to identify it

            CODEC_ID_MPEG2TS = &H20000 '/**< _FAKE_ codec to indicate a raw MPEG-2 TS
            '* stream (only used by libavformat) */
            CODEC_ID_FFMETADATA = &H21000   '///< Dummy codec for streams containing only metadata information.
        End Enum

        Public Enum Motion_Est_ID
            ME_ZERO = 1 '    ///< no search, that is use 0,0 vector whenever one is needed
            ME_FULL '
            ME_LOG '
            ME_PHODS '
            ME_EPZS '        ///< enhanced predictive zonal search
            ME_X1 '          ///< reserved for experiments
            ME_HEX '         ///< hexagon based search
            ME_UMH '         ///< uneven multi-hexagon search
            ME_ITER '        ///< iterative search
            ME_TESA '        ///< transformed exhaustive search algorithm
        End Enum

        Public Enum AVDiscard
            '/* We leave some space between them for extensions (drop some
            ' * keyframes for intra-only or drop just some bidir frames). */
            AVDISCARD_NONE = -16 ' ///< discard nothing
            AVDISCARD_DEFAULT = 0 ' ///< discard useless packets like 0 size packets in avi
            AVDISCARD_NONREF = 8 ' ///< discard all non reference
            AVDISCARD_BIDIR = 16 ' ///< discard all bidirectional frames
            AVDISCARD_NONKEY = 32 ' ///< discard all frames except keyframes
            AVDISCARD_ALL = 48 ' ///< discard all
        End Enum


        ' *********************************************************************************
        ' Structs
        ' *********************************************************************************

        <StructLayout(LayoutKind.Sequential)> _
        Public Structure RcOverride
            <MarshalAs(UnmanagedType.I4)> _
            Public start_frame As Integer

            <MarshalAs(UnmanagedType.I4)> _
            Public end_frame As Integer

            <MarshalAs(UnmanagedType.I4)> _
            Public qscale As Integer

            <MarshalAs(UnmanagedType.R4)> _
            Public quality_factor As Single
        End Structure

        Public Structure AVPanScan
            '*
            '             * id.
            '             * - encoding: set by user.
            '             * - decoding: set by lavc
            '             

            Public id As Integer
            '*
            '             * width and height in 1/16 pel
            '             * - encoding: set by user.
            '             * - decoding: set by lavc
            '             

            Public width As Integer
            Public height As Integer
            '*
            '             * position of the top left corner in 1/16 pel for up to 3 fields/frames.
            '             * - encoding: set by user.
            '             * - decoding: set by lavc
            '             

            ' [3][2] = 3 x 2 = 6
            <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> _
            Public position As Short()
        End Structure

        Public Delegate Sub DrawhorizBandCallback(ByVal pAVCodecContext As IntPtr, ByVal pAVFrame As IntPtr, <MarshalAs(UnmanagedType.LPArray, SizeConst:=4)> ByVal offset As Integer(), ByVal y As Integer, ByVal type As Integer, ByVal height As Integer)

        Public Delegate Sub RtpCallback(ByVal pAVCodecContext As IntPtr, ByVal pdata As IntPtr, ByVal size As Integer, ByVal mb_nb As Integer)

        Public Delegate Function GetBufferCallback(ByVal pAVCodecContext As IntPtr, ByVal pAVFrame As IntPtr) As Integer

        Public Delegate Sub ReleaseBufferCallback(ByVal pAVCodecContext As IntPtr, ByVal pAVFrame As IntPtr)

        Public Delegate Function GetFormatCallback(ByVal pAVCodecContext As IntPtr, ByVal pPixelFormat As IntPtr) As PixelFormat

        Public Delegate Function RegetBufferCallback(ByVal pAVCodecContext As IntPtr, ByVal pAVFrame As IntPtr) As Integer

        Public Delegate Function FuncCallback(ByVal pAVCodecContext As IntPtr, ByVal parg As IntPtr) As Integer

        Public Delegate Function ExecuteCallback(ByVal pAVCodecContext As IntPtr, <MarshalAs(UnmanagedType.FunctionPtr)> ByVal func As FuncCallback, <MarshalAs(UnmanagedType.LPArray)> ByVal arg2 As IntPtr(), ByRef ret As Integer, ByVal count As Integer) As Integer

        Public Structure AVCodecContext
            '*
            '             * Info on struct for av_log
            '             * - set by avcodec_alloc_context
            '             

            Public av_class As IntPtr
            '  AVClass *av_class;
            '*
            '             * the average bitrate.
            '             * - encoding: set by user. unused for constant quantizer encoding
            '             * - decoding: set by lavc. 0 or some bitrate if this info is available in the stream
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public bit_rate As Integer

            '*
            '             * number of bits the bitstream is allowed to diverge from the reference.
            '             *           the reference can be CBR (for CBR pass1) or VBR (for pass2)
            '             * - encoding: set by user. unused for constant quantizer encoding
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public bit_rate_tolerance As Integer

            '*
            '             * CODEC_FLAG_*.
            '             * - encoding: set by user.
            '             * - decoding: set by user.
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public flags As Integer

            '*
            '             * some codecs needs additionnal format info. It is stored here
            '             * - encoding: set by user.
            '             * - decoding: set by lavc. (FIXME is this ok?)
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public sub_id As Integer

            '*
            '             * motion estimation algorithm used for video coding.
            '             * 1 (zero), 2 (full), 3 (log), 4 (phods), 5 (epzs), 6 (x1), 7 (hex),
            '             * 8 (umh), 9 (iter) [7, 8 are x264 specific, 9 is snow specific]
            '             * - encoding: MUST be set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public me_method As Integer

            '*
            '             * some codecs need / can use extra-data like huffman tables.
            '             * mjpeg: huffman tables
            '             * rv10: additional flags
            '             * mpeg4: global headers (they can be in the bitstream or here)
            '             * the allocated memory should be FF_INPUT_BUFFER_PADDING_SIZE bytes larger
            '             * then extradata_size to avoid prolems if its read with the bitstream reader
            '             * the bytewise contents of extradata must not depend on the architecture or cpu endianness
            '             * - encoding: set/allocated/freed by lavc.
            '             * - decoding: set/allocated/freed by user.
            '             

            Public extradata As IntPtr
            ' void* extradata;
            <MarshalAs(UnmanagedType.I4)> _
            Public extradata_size As Integer

            '*
            '             * this is the fundamental unit of time (in seconds) in terms
            '             * of which frame timestamps are represented. for fixed-fps content,
            '             * timebase should be 1/framerate and timestamp increments should be
            '             * identically 1.
            '             * - encoding: MUST be set by user
            '             * - decoding: set by lavc.
            '             

            Public time_base As AVRational

            ' video only 

            '*
            '             * picture width / height.
            '             * - encoding: MUST be set by user.
            '             * - decoding: set by lavc.
            '             * Note, for compatibility its possible to set this instead of
            '             * coded_width/height before decoding
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public width As Integer

            <MarshalAs(UnmanagedType.I4)> _
            Public height As Integer

            '*
            '             * the number of pictures in a group of pitures, or 0 for intra_only.
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public gop_size As Integer

            '*
            '             * pixel format, see PIX_FMT_xxx.
            '             * - encoding: set by user.
            '             * - decoding: set by lavc.
            '             

            Public pix_fmt As PixelFormat

            '*
            '             * Frame rate emulation. If not zero lower layer (i.e. format handler)
            '             * has to read frames at native frame rate.
            '             * - encoding: set by user.
            '             * - decoding: unused.
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public rate_emu As Integer

            '*
            '             * if non NULL, 'draw_horiz_band' is called by the libavcodec
            '             * decoder to draw an horizontal band. It improve cache usage. Not
            '             * all codecs can do that. You must check the codec capabilities
            '             * before
            '             * - encoding: unused
            '             * - decoding: set by user.
            '             * @param height the height of the slice
            '             * @param y the y position of the slice
            '             * @param type 1->top field, 2->bottom field, 3->frame
            '             * @param offset offset into the AVFrame.data from which the slice should be read
            '             

            <MarshalAs(UnmanagedType.FunctionPtr)> _
            Public draw_horiz_band As DrawhorizBandCallback

            ' audio only 

            <MarshalAs(UnmanagedType.I4)> _
            Public sample_rate As Integer
            ' samples per sec
            <MarshalAs(UnmanagedType.I4)> _
            Public channels As Integer

            '*
            '             * audio sample format.
            '             * - encoding: set by user.
            '             * - decoding: set by lavc.
            '             

            Public sample_fmt As AVSampleFormat
            ' sample format, currenly unused
            ' the following data should not be initialized 

            '*
            '             * samples per packet. initialized when calling 'init'
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public frame_size As Integer

            <MarshalAs(UnmanagedType.I4)> _
            Public frame_number As Integer
            ' audio or video frame number
            <MarshalAs(UnmanagedType.I4)> _
            Public real_pict_num As Integer
            ' returns the real picture number of previous encoded frame
            '*
            '             * number of frames the decoded output will be delayed relative to
            '             * the encoded input.
            '             * - encoding: set by lavc.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public delay As Integer

            ' - encoding parameters 

            <MarshalAs(UnmanagedType.R4)> _
            Public qcompress As Single
            ' amount of qscale change between easy & hard scenes (0.0-1.0)
            <MarshalAs(UnmanagedType.R4)> _
            Public qblur As Single
            ' amount of qscale smoothing over time (0.0-1.0)
            '*
            '             * minimum quantizer.
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public qmin As Integer

            '*
            '             * maximum quantizer.
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public qmax As Integer

            '*
            '             * maximum quantizer difference etween frames.
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public max_qdiff As Integer

            '*
            '             * maximum number of b frames between non b frames.
            '             * note: the output will be delayed by max_b_frames+1 relative to the input
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public max_b_frames As Integer

            '*
            '             * qscale factor between ip and b frames.
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.R4)> _
            Public b_quant_factor As Single

            '* obsolete FIXME remove 

            <MarshalAs(UnmanagedType.I4)> _
            Public rc_strategy As Integer

            <MarshalAs(UnmanagedType.I4)> _
            Public b_frame_strategy As Integer

            '*
            '             * hurry up amount.
            '             * deprecated in favor of skip_idct and skip_frame
            '             * - encoding: unused
            '             * - decoding: set by user. 1-> skip b frames, 2-> skip idct/dequant too, 5-> skip everything except header
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public hurry_up As Integer

            Public codec As IntPtr
            ' AVCodec
            Public priv_data As IntPtr

            ' unused, FIXME remove

            <MarshalAs(UnmanagedType.I4)> _
            Public rtp_mode As Integer

            ' The size of the RTP payload: the coder will  

            ' do it's best to deliver a chunk with size    

            ' below rtp_payload_size, the chunk will start 

            ' with a start code on some codecs like H.263  

            ' This doesn't take account of any particular  

            ' headers inside the transmited RTP payload    

            <MarshalAs(UnmanagedType.I4)> _
            Public rtp_payload_size As Integer

            ' The RTP callback: This function is called   

            ' every time the encoder has a packet to send 

            ' Depends on the encoder if the data starts   

            ' with a Start Code (it should) H.263 does.   

            ' mb_nb contains the number of macroblocks    

            ' encoded in the RTP payload                  

            <MarshalAs(UnmanagedType.FunctionPtr)> _
            Public rtp_callback As RtpCallback

            ' statistics, used for 2-pass encoding 

            <MarshalAs(UnmanagedType.I4)> _
            Public mv_bits As Integer

            <MarshalAs(UnmanagedType.I4)> _
            Public header_bits As Integer

            <MarshalAs(UnmanagedType.I4)> _
            Public i_tex_bits As Integer

            <MarshalAs(UnmanagedType.I4)> _
            Public p_tex_bits As Integer

            <MarshalAs(UnmanagedType.I4)> _
            Public i_count As Integer

            <MarshalAs(UnmanagedType.I4)> _
            Public p_count As Integer

            <MarshalAs(UnmanagedType.I4)> _
            Public skip_count As Integer

            <MarshalAs(UnmanagedType.I4)> _
            Public misc_bits As Integer

            '*
            '             * number of bits used for the previously encoded frame.
            '             * - encoding: set by lavc
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public frame_bits As Integer

            '*
            '             * private data of the user, can be used to carry app specific stuff.
            '             * - encoding: set by user
            '             * - decoding: set by user
            '             

            Public opaque As IntPtr

            <MarshalAs(UnmanagedType.ByValArray, SizeConst:=32)> _
            Public codec_name As Byte()

            Public codec_type As AVMediaType
            ' see CODEC_TYPE_xxx 

            Public codec_id As CodecID
            ' see CODEC_ID_xxx 

            '*
            '             * fourcc (LSB first, so "ABCD" -> ('D'<<24) + ('C'<<16) + ('B'<<8) + 'A').
            '             * this is used to workaround some encoder bugs
            '             * - encoding: set by user, if not then the default based on codec_id will be used
            '             * - decoding: set by user, will be converted to upper case by lavc during init
            '             

            <MarshalAs(UnmanagedType.U4)> _
            Public codec_tag As UInteger

            '*
            '             * workaround bugs in encoders which sometimes cannot be detected automatically.
            '             * - encoding: set by user
            '             * - decoding: set by user
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public workaround_bugs As Integer

            '*
            '             * luma single coeff elimination threshold.
            '             * - encoding: set by user
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public luma_elim_threshold As Integer

            '*
            '             * chroma single coeff elimination threshold.
            '             * - encoding: set by user
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public chroma_elim_threshold As Integer

            '*
            '             * strictly follow the std (MPEG4, ...).
            '             * - encoding: set by user
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public strict_std_compliance As Integer

            '*
            '             * qscale offset between ip and b frames.
            '             * if > 0 then the last p frame quantizer will be used (q= lastp_q*factor+offset)
            '             * if < 0 then normal ratecontrol will be done (q= -normal_q*factor+offset)
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.R4)> _
            Public b_quant_offset As Single

            '*
            '             * error resilience higher values will detect more errors but may missdetect
            '             * some more or less valid parts as errors.
            '             * - encoding: unused
            '             * - decoding: set by user
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public error_resilience As Integer

            '*
            '              * called at the beginning of each frame to get a buffer for it.
            '              * if pic.reference is set then the frame will be read later by lavc
            '              * avcodec_align_dimensions() should be used to find the required width and
            '              * height, as they normally need to be rounded up to the next multiple of 16
            '              * - encoding: unused
            '              * - decoding: set by lavc, user can override
            '              

            <MarshalAs(UnmanagedType.FunctionPtr)> _
            Public get_buffer As GetBufferCallback

            '*
            '             * called to release buffers which where allocated with get_buffer.
            '             * a released buffer can be reused in get_buffer()
            '             * pic.data[*] must be set to NULL
            '             * - encoding: unused
            '             * - decoding: set by lavc, user can override
            '             

            <MarshalAs(UnmanagedType.FunctionPtr)> _
            Public release_buffer As ReleaseBufferCallback

            '*
            '             * if 1 the stream has a 1 frame delay during decoding.
            '             * - encoding: set by lavc
            '             * - decoding: set by lavc
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public has_b_frames As Integer

            '*
            '             * number of bytes per packet if constant and known or 0
            '             * used by some WAV based audio codecs
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public block_align As Integer

            ' - decoding only: if true, only parsing is done
            '                       (function avcodec_parse_frame()). The frame
            '                       data is returned. Only MPEG codecs support this now. 

            <MarshalAs(UnmanagedType.I4)> _
            Public parse_only As Integer

            '*
            '             * 0-> h263 quant 1-> mpeg quant.
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public mpeg_quant As Integer

            '*
            '             * pass1 encoding statistics output buffer.
            '             * - encoding: set by lavc
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.LPStr)> _
            Public stats_out As [String]
            ' char* stats_out
            '*
            '             * pass2 encoding statistics input buffer.
            '             * concatenated stuff from stats_out of pass1 should be placed here
            '             * - encoding: allocated/set/freed by user
            '             * - decoding: unused
            '             

            Public stats_in As [String]
            ' char *stats_in

            '*
            '             * ratecontrol qmin qmax limiting method.
            '             * 0-> clipping, 1-> use a nice continous function to limit qscale wthin qmin/qmax
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.R4)> _
            Public rc_qsquish As Single

            <MarshalAs(UnmanagedType.R4)> _
            Private rc_qmod_amp As Single

            <MarshalAs(UnmanagedType.I4)> _
            Public rc_qmod_freq As Integer

            '*
            '             * ratecontrol override, see RcOverride.
            '             * - encoding: allocated/set/freed by user.
            '             * - decoding: unused
            '             

            Public rc_override As IntPtr
            ' RcOverride* rc_override;
            <MarshalAs(UnmanagedType.I4)> _
            Public rc_override_count As Integer

            '*
            '             * rate control equation.
            '             * - encoding: set by user
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.LPStr)> _
            Public rc_eq As [String]
            ' char* rc_eq;
            '*
            '             * maximum bitrate.
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public rc_max_rate As Integer

            '*
            '             * minimum bitrate.
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public rc_min_rate As Integer

            '*
            '             * decoder bitstream buffer size.
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public rc_buffer_size As Integer

            <MarshalAs(UnmanagedType.R4)> _
            Public rc_buffer_aggressivity As Single

            '*
            '             * qscale factor between p and i frames.
            '             * if > 0 then the last p frame quantizer will be used (q= lastp_q*factor+offset)
            '             * if < 0 then normal ratecontrol will be done (q= -normal_q*factor+offset)
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.R4)> _
            Public i_quant_factor As Single

            '*
            '             * qscale offset between p and i frames.
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.R4)> _
            Public i_quant_offset As Single

            '*
            '             * initial complexity for pass1 ratecontrol.
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.R4)> _
            Public rc_initial_cplx As Single

            '*
            '             * dct algorithm, see FF_DCT_* below.
            '             * - encoding: set by user
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public dct_algo As Integer

            '*
            '             * luminance masking (0-> disabled).
            '             * - encoding: set by user
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.R4)> _
            Public lumi_masking As Single

            '*
            '             * temporary complexity masking (0-> disabled).
            '             * - encoding: set by user
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.R4)> _
            Public temporal_cplx_masking As Single

            '*
            '             * spatial complexity masking (0-> disabled).
            '             * - encoding: set by user
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.R4)> _
            Public spatial_cplx_masking As Single

            '*
            '             * p block masking (0-> disabled).
            '             * - encoding: set by user
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.R4)> _
            Public p_masking As Single

            '*
            '             * darkness masking (0-> disabled).
            '             * - encoding: set by user
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.R4)> _
            Public dark_masking As Single

            ' for binary compatibility 

            <MarshalAs(UnmanagedType.I4)> _
            Public unused As Integer

            '*
            '             * idct algorithm, see FF_IDCT_* below.
            '             * - encoding: set by user
            '             * - decoding: set by user
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public idct_algo As Integer

            '*
            '             * slice count.
            '             * - encoding: set by lavc
            '             * - decoding: set by user (or 0)
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public slice_count As Integer

            '*
            '             * slice offsets in the frame in bytes.
            '             * - encoding: set/allocated by lavc
            '             * - decoding: set/allocated by user (or NULL)
            '             

            Public slice_offset As IntPtr
            ' int *slice_offset
            '*
            '             * error concealment flags.
            '             * - encoding: unused
            '             * - decoding: set by user
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public error_concealment As Integer

            '*
            '             * dsp_mask could be add used to disable unwanted CPU features
            '             * CPU features (i.e. MMX, SSE. ...)
            '             *
            '             * with FORCE flag you may instead enable given CPU features
            '             * (Dangerous: usable in case of misdetection, improper usage however will
            '             * result into program crash)
            '             

            <MarshalAs(UnmanagedType.U4)> _
            Public dsp_mask As UInteger

            '*
            '             * bits per sample/pixel from the demuxer (needed for huffyuv).
            '             * - encoding: set by lavc
            '             * - decoding: set by user
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public bits_per_sample As Integer

            '*
            '             * prediction method (needed for huffyuv).
            '             * - encoding: set by user
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public prediction_method As Integer

            '*
            '             * sample aspect ratio (0 if unknown).
            '             * numerator and denominator must be relative prime and smaller then 256 for some video standards
            '             * - encoding: set by user.
            '             * - decoding: set by lavc.
            '             

            Public sample_aspect_ratio As AVRational

            '*
            '             * the picture in the bitstream.
            '             * - encoding: set by lavc
            '             * - decoding: set by lavc
            '             

            Public coded_frame As IntPtr
            ' AVFrame* coded_frame;
            '*
            '             * debug.
            '             * - encoding: set by user.
            '             * - decoding: set by user.
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public debug As Integer

            '*
            '             * debug.
            '             * - encoding: set by user.
            '             * - decoding: set by user.
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public debug_mv As Integer

            '*
            '             * error.
            '             * - encoding: set by lavc if flags&CODEC_FLAG_PSNR
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> _
            Public [error] As Int64()

            '*
            '             * minimum MB quantizer.
            '             * - encoding: unused
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public mb_qmin As Integer

            '*
            '             * maximum MB quantizer.
            '             * - encoding: unused
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public mb_qmax As Integer

            '*
            '             * motion estimation compare function.
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public me_cmp As Integer


            '*
            '             * subpixel motion estimation compare function.
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public me_sub_cmp As Integer

            '*
            '             * macroblock compare function (not supported yet).
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public mb_cmp As Integer

            '*
            '             * interlaced dct compare function
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public ildct_cmp As Integer

            '*
            '             * ME diamond size & shape.
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public dia_size As Integer

            '*
            '             * amount of previous MV predictors (2a+1 x 2a+1 square).
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public last_predictor_count As Integer

            '*
            '             * pre pass for motion estimation.
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public pre_me As Integer

            '*
            '             * motion estimation pre pass compare function.
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public me_pre_cmp As Integer

            '*
            '             * ME pre pass diamond size & shape.
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public pre_dia_size As Integer

            '*
            '             * subpel ME quality.
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public me_subpel_quality As Integer

            '*
            '             * callback to negotiate the pixelFormat.
            '             * @param fmt is the list of formats which are supported by the codec,
            '             * its terminated by -1 as 0 is a valid format, the formats are ordered by quality
            '             * the first is allways the native one
            '             * @return the choosen format
            '             * - encoding: unused
            '             * - decoding: set by user, if not set then the native format will always be choosen
            '             

            <MarshalAs(UnmanagedType.FunctionPtr)> _
            Public get_format As GetFormatCallback

            '*
            '             * DTG active format information (additionnal aspect ratio
            '             * information only used in DVB MPEG2 transport streams). 0 if
            '             * not set.
            '             *
            '             * - encoding: unused.
            '             * - decoding: set by decoder
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public dtg_active_format As Integer

            '*
            '             * Maximum motion estimation search range in subpel units.
            '             * if 0 then no limit
            '             *
            '             * - encoding: set by user.
            '             * - decoding: unused.
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public me_range As Integer

            '*
            '             * intra quantizer bias.
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public intra_quant_bias As Integer

            '*
            '             * inter quantizer bias.
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public inter_quant_bias As Integer

            '*
            '             * color table ID.
            '             * - encoding: unused.
            '             * - decoding: which clrtable should be used for 8bit RGB images
            '             *             table have to be stored somewhere FIXME
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public color_table_id As Integer

            '*
            '             * internal_buffer count.
            '             * Don't touch, used by lavc default_get_buffer()
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public internal_buffer_count As Integer

            '*
            '             * internal_buffers.
            '             * Don't touch, used by lavc default_get_buffer()
            '             

            Public internal_buffer As IntPtr
            ' void* internal_buffer;
            '*
            '             * global quality for codecs which cannot change it per frame.
            '             * this should be proportional to MPEG1/2/4 qscale.
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public global_quality As Integer

            '*
            '             * coder type
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public coder_type As Integer

            '*
            '             * context model
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public context_model As Integer

            '*
            '              * slice flags
            '              * - encoding: unused
            '              * - decoding: set by user.
            '              

            <MarshalAs(UnmanagedType.I4)> _
            Public slice_flags As Integer

            '*
            '             * XVideo Motion Acceleration
            '             * - encoding: forbidden
            '             * - decoding: set by decoder
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public xvmc_acceleration As Integer

            '*
            '             * macroblock decision mode
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public mb_decision As Integer

            '*
            '             * custom intra quantization matrix
            '             * - encoding: set by user, can be NULL
            '             * - decoding: set by lavc
            '             

            Public intra_matrix As IntPtr
            ' uint16_t* intra_matrix;
            '*
            '             * custom inter quantization matrix
            '             * - encoding: set by user, can be NULL
            '             * - decoding: set by lavc
            '             

            Public inter_matrix As IntPtr
            ' uint16_t* inter_matrix;
            '*
            '             * fourcc from the AVI stream header (LSB first, so "ABCD" -> ('D'<<24) + ('C'<<16) + ('B'<<8) + 'A').
            '             * this is used to workaround some encoder bugs
            '             * - encoding: unused
            '             * - decoding: set by user, will be converted to upper case by lavc during init
            '             

            <MarshalAs(UnmanagedType.U4)> _
            Public stream_codec_tag As UInteger

            '*
            '             * scene change detection threshold.
            '             * 0 is default, larger means fewer detected scene changes
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public scenechange_threshold As Integer

            '*
            '             * minimum lagrange multipler
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public lmin As Integer

            '*
            '             * maximum lagrange multipler
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public lmax As Integer

            '*
            '             * Palette control structure
            '             * - encoding: ??? (no palette-enabled encoder yet)
            '             * - decoding: set by user.
            '             

            Public palctrl As IntPtr
            ' AVPaletteControl *palctrl;
            '*
            '             * noise reduction strength
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public noise_reduction As Integer

            '*
            '             * called at the beginning of a frame to get cr buffer for it.
            '             * buffer type (size, hints) must be the same. lavc won't check it.
            '             * lavc will pass previous buffer in pic, function should return
            '             * same buffer or new buffer with old frame "painted" into it.
            '             * if pic.data[0] == NULL must behave like get_buffer().
            '             * - encoding: unused
            '             * - decoding: set by lavc, user can override
            '             

            <MarshalAs(UnmanagedType.FunctionPtr)> _
            Public reget_buffer As RegetBufferCallback

            '*
            '             * number of bits which should be loaded into the rc buffer before decoding starts
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public rc_initial_buffer_occupancy As Integer

            '*
            '             *
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public inter_threshold As Integer

            '*
            '             * CODEC_FLAG2_*.
            '             * - encoding: set by user.
            '             * - decoding: set by user.
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public flags2 As Integer

            '*
            '             * simulates errors in the bitstream to test error concealment.
            '             * - encoding: set by user.
            '             * - decoding: unused.
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public error_rate As Integer

            '*
            '             * MP3 antialias algorithm, see FF_AA_* below.
            '             * - encoding: unused
            '             * - decoding: set by user
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public antialias_algo As Integer

            '*
            '             * Quantizer noise shaping.
            '             * - encoding: set by user
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public quantizer_noise_shaping As Integer

            '*
            '             * Thread count.
            '             * is used to decide how many independant tasks should be passed to execute()
            '             * - encoding: set by user
            '             * - decoding: set by user
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public thread_count As Integer

            '*
            '             * the codec may call this to execute several independant things. it will return only after
            '             * finishing all tasks, the user may replace this with some multithreaded implementation, the
            '             * default implementation will execute the parts serially
            '             * @param count the number of things to execute
            '             * - encoding: set by lavc, user can override
            '             * - decoding: set by lavc, user can override
            '             

            <MarshalAs(UnmanagedType.FunctionPtr)> _
            Public execute As ExecuteCallback

            '*
            '             * Thread opaque.
            '             * can be used by execute() to store some per AVCodecContext stuff.
            '             * - encoding: set by execute()
            '             * - decoding: set by execute()
            '             

            Public thread_opaque As IntPtr
            ' void* thread_opaque;
            '*
            '             * Motion estimation threshold. under which no motion estimation is
            '             * performed, but instead the user specified motion vectors are used
            '             *
            '             * - encoding: set by user
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public me_threshold As Integer

            '*
            '             * Macroblock threshold. under which the user specified macroblock types will be used
            '             * - encoding: set by user
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public mb_threshold As Integer

            '*
            '             * precision of the intra dc coefficient - 8.
            '             * - encoding: set by user
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public intra_dc_precision As Integer

            '*
            '             * noise vs. sse weight for the nsse comparsion function.
            '             * - encoding: set by user
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public nsse_weight As Integer

            '*
            '             * number of macroblock rows at the top which are skipped.
            '             * - encoding: unused
            '             * - decoding: set by user
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public skip_top As Integer

            '*
            '             * number of macroblock rows at the bottom which are skipped.
            '             * - encoding: unused
            '             * - decoding: set by user
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public skip_bottom As Integer

            '*
            '             * profile
            '             * - encoding: set by user
            '             * - decoding: set by lavc
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public profile As Integer

            '*
            '             * level
            '             * - encoding: set by user
            '             * - decoding: set by lavc
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public level As Integer

            '*
            '             * low resolution decoding. 1-> 1/2 size, 2->1/4 size
            '             * - encoding: unused
            '             * - decoding: set by user
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public lowres As Integer

            '*
            '             * bitsream width / height. may be different from width/height if lowres
            '             * or other things are used
            '             * - encoding: unused
            '             * - decoding: set by user before init if known, codec should override / dynamically change if needed
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public coded_width As Integer, coded_height As Integer

            '*
            '             * frame skip threshold
            '             * - encoding: set by user
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public frame_skip_threshold As Integer

            '*
            '             * frame skip factor
            '             * - encoding: set by user
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public frame_skip_factor As Integer


            '*
            '             * frame skip exponent
            '             * - encoding: set by user
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public frame_skip_exp As Integer

            '*
            '             * frame skip comparission function
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public frame_skip_cmp As Integer

            '*
            '             * border processing masking. raises the quantizer for mbs on the borders
            '             * of the picture.
            '             * - encoding: set by user
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.R4)> _
            Public border_masking As Single

            '*
            '             * minimum MB lagrange multipler.
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public mb_lmin As Integer

            '*
            '             * maximum MB lagrange multipler.
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public mb_lmax As Integer

            '*
            '             *
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public me_penalty_compensation As Integer

            '*
            '             *
            '             * - encoding: unused
            '             * - decoding: set by user.
            '             

            Private skip_loop_filter As AVDiscard

            '*
            '             *
            '             * - encoding: unused
            '             * - decoding: set by user.
            '             

            Private skip_frame As AVDiscard

            '*
            '             *
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public bidir_refine As Integer

            '*
            '             *
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public brd_scale As Integer

            '*
            '             * constant rate factor - quality-based VBR - values ~correspond to qps
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public crf As Integer


            '*
            '             * constant quantization parameter rate control method
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public cqp As Integer

            '*
            '             * minimum gop size
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public keyint_min As Integer

            '*
            '             * number of reference frames
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public refs As Integer

            '*
            '             * chroma qp offset from luma
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public chromaoffset As Integer

            '*
            '             * influences how often b-frames are used
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public bframebias As Integer

            '*
            '             * trellis RD quantization
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public trellis As Integer

            '*
            '             * reduce fluctuations in qp (before curve compression)
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.R4)> _
            Public complexityblur As Single

            '*
            '             * in-loop deblocking filter alphac0 parameter
            '             * alpha is in the range -6...6
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public deblockalpha As Integer

            '*
            '             * in-loop deblocking filter beta parameter
            '             * beta is in the range -6...6
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public deblockbeta As Integer

            '*
            '             * macroblock subpartition sizes to consider - p8x8, p4x4, b8x8, i8x8, i4x4
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public partitions As Integer

            '*
            '             * direct mv prediction mode - 0 (none), 1 (spatial), 2 (temporal)
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public directpred As Integer

            '*
            '             * audio cutoff bandwidth (0 means "automatic") . Currently used only by FAAC
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public cutoff As Integer

            '*
            '             * multiplied by qscale for each frame and added to scene_change_score
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public scenechange_factor As Integer

            '*
            '             *
            '             * note: value depends upon the compare functin used for fullpel ME
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public mv0_threshold As Integer

            '*
            '             * adjusts sensitivity of b_frame_strategy 1
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public b_sensitivity As Integer

            '*
            '             * - encoding: set by user.
            '             * - decoding: unused
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public compression_level As Integer

            '*
            '             * sets whether to use LPC mode - used by FLAC encoder
            '             * - encoding: set by user.
            '             * - decoding: unused.
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public use_lpc As Integer

            '*
            '             * LPC coefficient precision - used by FLAC encoder
            '             * - encoding: set by user.
            '             * - decoding: unused.
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public lpc_coeff_precision As Integer

            '*
            '             * - encoding: set by user.
            '             * - decoding: unused.
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public min_prediction_order As Integer

            '*
            '             * - encoding: set by user.
            '             * - decoding: unused.
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public max_prediction_order As Integer

            '*
            '             * search method for selecting prediction order
            '             * - encoding: set by user.
            '             * - decoding: unused.
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public prediction_order_method As Integer

            '*
            '             * - encoding: set by user.
            '             * - decoding: unused.
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public min_partition_order As Integer

            '*
            '             * - encoding: set by user.
            '             * - decoding: unused.
            '             

            <MarshalAs(UnmanagedType.I4)> _
            Public max_partition_order As Integer
        End Structure

        Public Delegate Function InitCallback(ByVal pAVCodecContext As IntPtr) As Integer

        Public Delegate Function EncodeCallback(ByVal pAVCodecContext As IntPtr, ByVal buf As IntPtr, ByVal buf_size As Integer, ByVal data As IntPtr) As Integer

        Public Delegate Function CloseCallback(ByVal pAVCodecContext As IntPtr) As Integer

        Public Delegate Function DecodeCallback(ByVal pAVCodecContext As IntPtr, ByVal outdata As IntPtr, ByRef outdata_size As Integer, ByVal buf As IntPtr, ByVal buf_size As Integer) As Integer

        Public Delegate Function FlushCallback(ByVal pAVCodecContext As IntPtr) As Integer

        <StructLayout(LayoutKind.Sequential)> _
        Public Structure AVCodec
            <MarshalAs(UnmanagedType.LPStr)> _
            Public name As [String]

            Public type As AVMediaType

            Public id As CodecID

            <MarshalAs(UnmanagedType.I4)> _
            Public priv_data_size As Integer

            <MarshalAs(UnmanagedType.FunctionPtr)> _
            Public init As InitCallback

            <MarshalAs(UnmanagedType.FunctionPtr)> _
            Public encode As EncodeCallback

            <MarshalAs(UnmanagedType.FunctionPtr)> _
            Public close As CloseCallback

            <MarshalAs(UnmanagedType.FunctionPtr)> _
            Public decode As DecodeCallback

            <MarshalAs(UnmanagedType.I4)> _
            Public capabilities As Integer

            '#if LIBAVCODEC_VERSION_INT < ((50<<16)+(0<<8)+0)
            '    void *dummy; // FIXME remove next time we break binary compatibility
            '#endif
            Public [next] As IntPtr
            ' AVCodec *next
            <MarshalAs(UnmanagedType.FunctionPtr)> _
            Public flush As FlushCallback

            ' array of supported framerates, or NULL if any, array is terminated by {0,0}
            Public supported_framerates As IntPtr

            ' array of supported pixel formats, or NULL if unknown, array is terminanted by -1
            Public pix_fmts As IntPtr
            ' enum PixelFormat *pix_fmts
        End Structure

        <StructLayout(LayoutKind.Sequential)> _
        Public Structure AVPicture
            <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> _
            Public data As IntPtr()
            ' uint8_t *data[4]
            <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> _
            Public linesize As Integer()
        End Structure

        <StructLayout(LayoutKind.Sequential)> _
        Public Structure AVPaletteControl
            ' demuxer sets this to 1 to indicate the palette has changed;
            '             * decoder resets to 0 

            <MarshalAs(UnmanagedType.I4)> _
            Public palette_changed As Integer

            ' 4-byte ARGB palette entries, stored in native byte order; note that
            '             * the individual palette components should be on a 8-bit scale; if
            '             * the palette data comes from a IBM VGA native format, the component
            '             * data is probably 6 bits in size and needs to be scaled 

            <MarshalAs(UnmanagedType.ByValArray, SizeConst:=AVPALETTE_COUNT)> _
            Public palette As UInteger()
        End Structure

        <StructLayout(LayoutKind.Sequential)> _
        Public Structure AVSubtitleRect
            <MarshalAs(UnmanagedType.U2)> _
            Public x As UShort

            <MarshalAs(UnmanagedType.U2)> _
            Public y As UShort

            <MarshalAs(UnmanagedType.U2)> _
            Public w As UShort

            <MarshalAs(UnmanagedType.U2)> _
            Public h As UShort

            <MarshalAs(UnmanagedType.U2)> _
            Public nb_colors As UShort

            <MarshalAs(UnmanagedType.I4)> _
            Public linesize As Integer

            Public bitmap As IntPtr
            ' uint8_t *bitmap;
        End Structure

        <StructLayout(LayoutKind.Sequential)> _
        Public Structure AVSubtitle
            <MarshalAs(UnmanagedType.U2)> _
            Public format As UShort
            ' 0 = graphics 

            <MarshalAs(UnmanagedType.U4)> _
            Public start_display_time As UInteger
            ' relative to packet pts, in ms 

            <MarshalAs(UnmanagedType.U4)> _
            Public end_display_time As UInteger
            ' relative to packet pts, in ms 

            <MarshalAs(UnmanagedType.U4)> _
            Public num_rects As UInteger

            Public rects As IntPtr
            ' AVSubtitleRect *rects;
        End Structure

        <StructLayout(LayoutKind.Sequential)> _
        Public Structure AVCodecParserContext
            Public priv_data As IntPtr

            Public parser As IntPtr
            ' AVCodecParser *parser
            <MarshalAs(UnmanagedType.I8)> _
            Public frame_offset As Int64
            ' offset of the current frame 
            <MarshalAs(UnmanagedType.I8)> _
            Public cur_offset As Int64
            ' current offset incremented by each av_parser_parse()
            <MarshalAs(UnmanagedType.I8)> _
            Public last_frame_offset As Int64
            ' offset of the last frame
            ' video info 

            <MarshalAs(UnmanagedType.I4)> _
            Public pict_type As Integer
            ' XXX: put it back in AVCodecContext 

            <MarshalAs(UnmanagedType.I4)> _
            Public repeat_pict As Integer
            ' XXX: put it back in AVCodecContext 

            <MarshalAs(UnmanagedType.I8)> _
            Public pts As Int64
            ' pts of the current frame 

            <MarshalAs(UnmanagedType.I8)> _
            Public dts As Int64
            ' dts of the current frame 

            ' private data 

            <MarshalAs(UnmanagedType.I8)> _
            Public last_pts As Int64

            <MarshalAs(UnmanagedType.I8)> _
            Public last_dts As Int64

            <MarshalAs(UnmanagedType.I4)> _
            Public fetch_timestamp As Integer

            <MarshalAs(UnmanagedType.I4)> _
            Public cur_frame_start_index As Integer

            <MarshalAs(UnmanagedType.ByValArray, SizeConst:=AV_PARSER_PTS_NB)> _
            Public cur_frame_offset As Int64()

            <MarshalAs(UnmanagedType.ByValArray, SizeConst:=AV_PARSER_PTS_NB)> _
            Public cur_frame_pts As Int64()

            <MarshalAs(UnmanagedType.ByValArray, SizeConst:=AV_PARSER_PTS_NB)> _
            Public cur_frame_dts As Int64()

            <MarshalAs(UnmanagedType.I4)> _
            Public flags As Integer
        End Structure

        Public Delegate Function ParaerInitCallback(ByVal pAVCodecParserContext As IntPtr) As Integer

        Public Delegate Function ParserParseCallback(ByVal pAVCodecParserContext As IntPtr, ByVal pAVCodecContext As IntPtr, <MarshalAs(UnmanagedType.LPArray)> ByVal poutbuf As IntPtr(), ByRef poutbuf_size As Integer, ByVal buf As IntPtr, ByVal buf_size As Integer) As Integer

        Public Delegate Sub ParserCloseCallback(ByVal pAVcodecParserContext As IntPtr)

        Public Delegate Function SplitCallback(ByVal pAVCodecContext As IntPtr, ByVal buf As IntPtr, ByVal buf_size As Integer) As Integer

        <StructLayout(LayoutKind.Sequential)> _
        Public Structure AVCodecParser
            <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> _
            Public codec_ids As Integer()
            ' several codec IDs are permitted 

            <MarshalAs(UnmanagedType.I4)> _
            Public priv_data_size As Integer

            <MarshalAs(UnmanagedType.FunctionPtr)> _
            Public parser_init As ParaerInitCallback

            <MarshalAs(UnmanagedType.FunctionPtr)> _
            Public parser_parse As ParserParseCallback

            <MarshalAs(UnmanagedType.FunctionPtr)> _
            Public parser_close As ParserCloseCallback

            <MarshalAs(UnmanagedType.FunctionPtr)> _
            Public split As SplitCallback

            Public [next] As IntPtr
        End Structure

        <StructLayout(LayoutKind.Sequential)> _
        Public Structure AVBitStreamFilterContext
            Public priv_data As IntPtr
            Public filter As IntPtr
            ' AVBitStreamFilter *filter
            Public parser As IntPtr
            ' AVCodecParserContext *parser
            Public [next] As IntPtr
            ' AVBitStreamFilterContext *next
        End Structure

        Public Delegate Function FilterCallback(ByVal pAVBitStreamFilterContext As IntPtr, ByVal pAVCodecContext As IntPtr, <MarshalAs(UnmanagedType.LPStr)> ByVal args As [String], <MarshalAs(UnmanagedType.LPArray)> ByVal poutbuf As IntPtr(), ByRef poutbuf_size As Integer, ByVal buf As IntPtr, _
         ByVal buf_size As Integer, ByVal keyframe As Integer) As Integer

        <StructLayout(LayoutKind.Sequential)> _
        Public Structure AVBitStreamFilter
            <MarshalAs(UnmanagedType.LPStr)> _
            Private name As [String]

            <MarshalAs(UnmanagedType.I4)> _
            Private priv_data_size As Integer

            <MarshalAs(UnmanagedType.FunctionPtr)> _
            Private filter As FilterCallback

            Private [next] As IntPtr
            ' AVBitStreamFilter *next
        End Structure

    End Class

End Namespace