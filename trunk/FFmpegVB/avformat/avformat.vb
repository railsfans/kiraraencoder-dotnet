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
Imports FFmpegVB.FFmpeg.Libavcodec
Imports FFmpegVB.FFmpeg.Libavutil
Imports System.Reflection

Namespace FFmpeg

    Partial Public Class Libavformat

        Public Const AVFORMAT_DLL_NAME As String = "avformat-50.dll"

        '/* packet functions */

        '/**
        ' * Allocate and read the payload of a packet and initialize its
        ' * fields with default values.
        ' *
        ' * @param pkt packet
        ' * @param size desired payload size
        ' * @return >0 (read size) if OK, AVERROR_xxx otherwise
        ' */
        <DllImport(AVFORMAT_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function av_get_packet(ByVal pAVIOContext As IntPtr, ByVal pAVPacket As IntPtr, ByVal size As Integer) As Integer
        End Function

        '/**
        '* Read data and append it to the current content of the AVPacket.
        '* If pkt->size is 0 this is identical to av_get_packet.
        '* Note that this uses av_grow_packet and thus involves a realloc
        '* which is inefficient. Thus this function should only be used
        '* when there is no reasonable way to know (an upper bound of)
        '* the final size.
        '*
        '* @param pkt packet
        '* @param size amount of data to read
        '* @return >0 (read size) if OK, AVERROR_xxx otherwise, previous data
        '*         will not be lost even if an error occurs.
        '*/
        <DllImport(AVFORMAT_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function av_append_packet(ByVal pAVIOContext As IntPtr, ByVal pAVPacket As IntPtr, ByVal size As Integer) As Integer
        End Function

        '/* XXX: Use automatic init with either ELF sections or C file parser */
        '/* modules. */

        '/* utils.c */
        <DllImport(AVFORMAT_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Sub av_register_input_format(ByVal pAVInputFormat As IntPtr)
        End Sub

        <DllImport(AVFORMAT_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Sub av_register_output_format(ByVal pAVOutputFormat As IntPtr)
        End Sub

        ' /**
        ' * Return the output format in the list of registered output formats
        ' * which best matches the provided parameters, or return NULL if
        ' * there is no match.
        ' *
        ' * @param short_name if non-NULL checks if short_name matches with the
        ' * names of the registered formats
        ' * @param filename if non-NULL checks if filename terminates with the
        ' * extensions of the registered formats
        ' * @param mime_type if non-NULL checks if mime_type matches with the
        ' * MIME type of the registered formats
        ' */
        <DllImport(AVFORMAT_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function guess_stream_format(<MarshalAs(UnmanagedType.LPTStr)> ByVal short_name As [String], <MarshalAs(UnmanagedType.LPTStr)> ByVal filename As [String], <MarshalAs(UnmanagedType.LPTStr)> ByVal mime_type As [String]) As IntPtr
        End Function

        '/**
        '* Guess the codec ID based upon muxer and filename.
        '*/
        <DllImport(AVFORMAT_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function av_guess_codec(ByVal pAVOutoutFormat As IntPtr, <MarshalAs(UnmanagedType.LPTStr)> ByVal short_name As [String], <MarshalAs(UnmanagedType.LPTStr)> ByVal filename As [String], <MarshalAs(UnmanagedType.LPTStr)> ByVal mime_type As [String], ByVal type As AVMediaType) As CodecID
        End Function

        '/**
        '* Send a nice hexadecimal dump of a buffer to the specified file stream.
        '*
        '* @param f The file stream pointer where the dump should be sent to.
        '* @param buf buffer
        '* @param size buffer size
        '*
        '* @see av_hex_dump_log, av_pkt_dump2, av_pkt_dump_log2
        '*/
        <DllImport(AVFORMAT_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Sub av_hex_dump(ByVal pFile As IntPtr, ByVal buf As IntPtr, ByVal size As Integer)
        End Sub

        '/**
        ' * Send a nice dump of a packet to the specified file stream.
        ' *
        ' * @param f The file stream pointer where the dump should be sent to.
        ' * @param pkt packet to dump
        ' * @param dump_payload True if the payload must be displayed, too.
        ' * @param st AVStream that the packet belongs to
        ' */
        <DllImport(AVFORMAT_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Sub av_pkt_dump2(ByVal pFile As IntPtr, ByVal pAVPacket As IntPtr, ByVal dump_payload As Integer, ByVal pAVStream As IntPtr)
        End Sub

        '/**
        '* Initialize libavformat and register all the muxers, demuxers and
        '* protocols. If you do not call this function, then you can select
        '* exactly which formats you want to support.
        '*
        '* @see av_register_input_format()
        '* @see av_register_output_format()
        '* @see av_register_protocol()
        '*/
        <DllImport(AVFORMAT_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Sub av_register_all()
        End Sub

        '/* media file input */

        '/**
        ' * Find AVInputFormat based on the short name of the input format.
        ' */
        <DllImport(AVFORMAT_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function av_find_input_format(<MarshalAs(UnmanagedType.LPTStr)> ByVal short_name As [String]) As IntPtr
        End Function

        '/**
        '* Guess the file format.
        '*
        '* @param is_opened Whether the file is already opened; determines whether
        '*                  demuxers with or without AVFMT_NOFILE are probed.
        '*/
        <DllImport(AVFORMAT_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function av_probe_input_format(ByVal pAVProbeData As IntPtr, ByVal is_opened As Integer) As IntPtr
        End Function

        '/**
        '* Open a media file as input. The codecs are not opened. Only the file
        '* header (if present) is read.
        '*
        '* @param ic_ptr The opened media file handle is put here.
        '* @param filename filename to open
        '* @param fmt If non-NULL, force the file format to use.
        '* @param buf_size optional buffer size (zero if default is OK)
        '* @param ap Additional parameters needed when opening the file
        '*           (NULL if default).
        '* @return 0 if OK, AVERROR_xxx otherwise
        '*/
        <DllImport(AVFORMAT_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function av_open_input_file(<Out()> ByRef pFormatContext As IntPtr, <MarshalAs(UnmanagedType.LPStr)> ByVal filename As [String], ByVal pAVInputFormat As IntPtr, ByVal buf_size As Integer, ByVal pAVFormatParameters As IntPtr) As Integer
        End Function

        '/**
        '* Read packets of a media file to get stream information. This
        '* is useful for file formats with no headers such as MPEG. This
        '* function also computes the real framerate in case of MPEG-2 repeat
        '* frame mode.
        '* The logical file position is not changed by this function;
        '* examined packets may be buffered for later processing.
        '*
        '* @param ic media file handle
        '* @return >=0 if OK, AVERROR_xxx on error
        '* @todo Let the user decide somehow what information is needed so that
        '*       we do not waste time getting stuff the user does not need.
        '*/
        <DllImport(AVFORMAT_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function av_find_stream_info(ByVal pAVFormatContext As IntPtr) As Integer
        End Function

        '/**
        '* Read a transport packet from a media file.
        '*
        '* This function is obsolete and should never be used.
        '* Use av_read_frame() instead.
        '*
        '* @param s media file handle
        '* @param pkt is filled
        '* @return 0 if OK, AVERROR_xxx on error
        '*/
        <DllImport(AVFORMAT_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function av_read_packet(ByVal pAVFormatContext As IntPtr, ByVal pAVPacket As IntPtr) As Integer
        End Function

        '/**
        '* Return the next frame of a stream.
        '* This function returns what is stored in the file, and does not validate
        '* that what is there are valid frames for the decoder. It will split what is
        '* stored in the file into frames and return one for each call. It will not
        '* omit invalid data between valid frames so as to give the decoder the maximum
        '* information possible for decoding.
        '*
        '* The returned packet is valid
        '* until the next av_read_frame() or until av_close_input_file() and
        '* must be freed with av_free_packet. For video, the packet contains
        '* exactly one frame. For audio, it contains an integer number of
        '* frames if each frame has a known fixed size (e.g. PCM or ADPCM
        '* data). If the audio frames have a variable size (e.g. MPEG audio),
        '* then it contains one frame.
        '*
        '* pkt->pts, pkt->dts and pkt->duration are always set to correct
        '* values in AVStream.time_base units (and guessed if the format cannot
        '* provide them). pkt->pts can be AV_NOPTS_VALUE if the video format
        '* has B-frames, so it is better to rely on pkt->dts if you do not
        '* decompress the payload.
        '*
        '* @return 0 if OK, < 0 on error or end of file
        '*/
        <DllImport(AVFORMAT_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function av_read_frame(ByVal pAVFormatContext As IntPtr, ByVal pAVPacket As IntPtr) As Integer
        End Function

        '/**
        '* Seek to the keyframe at timestamp.
        '* 'timestamp' in 'stream_index'.
        '* @param stream_index If stream_index is (-1), a default
        '* stream is selected, and timestamp is automatically converted
        '* from AV_TIME_BASE units to the stream specific time_base.
        '* @param timestamp Timestamp in AVStream.time_base units
        '*        or, if no stream is specified, in AV_TIME_BASE units.
        '* @param flags flags which select direction and seeking mode
        '* @return >= 0 on success
        '*/
        <DllImport(AVFORMAT_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function av_seek_frame(ByVal pAVFormatContext As IntPtr, ByVal stream_index As Integer, ByVal timestamp As Int64, ByVal flags As Integer) As Integer
        End Function

        '/**
        '* Start playing a network-based stream (e.g. RTSP stream) at the
        '* current position.
        '*/
        <DllImport(AVFORMAT_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function av_read_play(ByVal pAVFormatContext As IntPtr) As Integer
        End Function

        '/**
        '* Pause a network-based stream (e.g. RTSP stream).
        '*
        '* Use av_read_play() to resume it.
        '*/
        <DllImport(AVFORMAT_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function av_read_pause(ByVal pAVFormatContext As IntPtr) As Integer
        End Function

        '/**
        ' * Free a AVFormatContext allocated by av_open_input_stream.
        ' * @param s context to free
        ' */
        <DllImport(AVFORMAT_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Sub av_close_input_file(ByVal pAVFormatContext As IntPtr)
        End Sub

        '/**
        '* Add a new stream to a media file.
        '*
        '* Can only be called in the read_header() function. If the flag
        '* AVFMTCTX_NOHEADER is in the format context, then new streams
        '* can be added in read_packet too.
        '*
        '* @param s media file handle
        '* @param id file-format-dependent stream ID
        '*/
        <DllImport(AVFORMAT_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function av_new_stream(ByVal pAVFormatContext As IntPtr, ByVal id As Integer) As IntPtr
        End Function

        '/**
        '* Set the pts for a given stream. If the new values would be invalid
        '* (<= 0), it leaves the AVStream unchanged.
        '*
        '* @param s stream
        '* @param pts_wrap_bits number of bits effectively used by the pts
        '*        (used for wrap control, 33 is the value for MPEG)
        '* @param pts_num numerator to convert to seconds (MPEG: 1)
        '* @param pts_den denominator to convert to seconds (MPEG: 90000)
        '*/
        <DllImport(AVFORMAT_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Sub av_set_pts_info(ByVal pAVStream As IntPtr, ByVal pts_wrap_bits As Integer, ByVal pts_num As Integer, ByVal pts_den As Integer)
        End Sub

        Public Const AVSEEK_FLAG_BACKWARD As Integer = 1 '///< seek backward
        Public Const AVSEEK_FLAG_BYTE As Integer = 2 '///< seeking based on position in bytes
        Public Const AVSEEK_FLAG_ANY As Integer = 4 '///< seek to any frame, even non-keyframes
        Public Const AVSEEK_FLAG_FRAME As Integer = 8 '///< seeking based on frame number

        <DllImport(AVFORMAT_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function av_find_default_stream_index(ByVal pAVFormatContext As IntPtr) As Integer
        End Function

        '/**
        '* Get the index for a specific timestamp.
        '* @param flags if AVSEEK_FLAG_BACKWARD then the returned index will correspond
        '*                 to the timestamp which is <= the requested one, if backward
        '*                 is 0, then it will be >=
        '*              if AVSEEK_FLAG_ANY seek to any frame, only keyframes otherwise
        '* @return < 0 if no such timestamp could be found
        '*/
        <DllImport(AVFORMAT_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function av_index_search_timestamp(ByVal pAVStream As IntPtr, ByVal timestamp As Int64, ByVal flags As Integer) As Integer
        End Function

        '/**
        '* Add an index entry into a sorted list. Update the entry if the list
        '* already contains it.
        '*
        '* @param timestamp timestamp in the time base of the given stream
        '*/
        <DllImport(AVFORMAT_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function av_add_index_entry(ByVal pAVStream As IntPtr, ByVal pos As Int64, ByVal timestamp As Int64, ByVal size As Integer, ByVal distance As Integer, ByVal flags As Integer) As Integer
        End Function

        '/**
        '* Perform a binary search using av_index_search_timestamp() and
        '* AVInputFormat.read_timestamp().
        '* This is not supposed to be called directly by a user application,
        '* but by demuxers.
        '* @param target_ts target timestamp in the time base of the given stream
        '* @param stream_index stream number
        '*/
        <DllImport(AVFORMAT_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function av_seek_frame_binary(ByVal pAVFormatContext As IntPtr, ByVal stream_index As Integer, ByVal target_ts As Int64, ByVal flags As Integer) As Integer
        End Function

        '/**
        '* Update cur_dts of all streams based on the given timestamp and AVStream.
        '*
        '* Stream ref_st unchanged, others set cur_dts in their native time base.
        '* Only needed for timestamp wrapping or if (dts not set and pts!=dts).
        '* @param timestamp new dts expressed in time_base of param ref_st
        '* @param ref_st reference stream giving time_base of param timestamp
        '*/
        <DllImport(AVFORMAT_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Sub av_update_cur_dts(ByVal pAVFormatContext As IntPtr, ByVal pAVStream As IntPtr, ByVal timestamp As Int64)
        End Sub

        '/**
        '* media file output
        '*/
        <DllImport(AVFORMAT_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function av_set_parameters(ByVal pAVFormatContext As IntPtr, ByVal pAVFormatParameters As IntPtr) As Integer
        End Function

        '/**
        '* Allocate the stream private data and write the stream header to an
        '* output media file.
        '* @note: this sets stream time-bases, if possible to stream->codec->time_base
        '* but for some formats it might also be some other time base
        '*
        '* @param s media file handle
        '* @return 0 if OK, AVERROR_xxx on error
        '*/
        <DllImport(AVFORMAT_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function av_write_header(ByVal pAVFormatContext As IntPtr) As Integer
        End Function

        '/**
        '* Write a packet to an output media file.
        '*
        '* The packet shall contain one audio or video frame.
        '* The packet must be correctly interleaved according to the container
        '* specification, if not then av_interleaved_write_frame must be used.
        '*
        '* @param s media file handle
        '* @param pkt The packet, which contains the stream_index, buf/buf_size,
        '             dts/pts, ...
        '* @return < 0 on error, = 0 if OK, 1 if end of stream wanted
        '*/
        <DllImport(AVFORMAT_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function av_write_frame(ByVal pAVFormatContext As IntPtr, ByVal pAVPacket As IntPtr) As Integer
        End Function

        '/**
        '* Write a packet to an output media file ensuring correct interleaving.
        '*
        '* The packet must contain one audio or video frame.
        '* If the packets are already correctly interleaved, the application should
        '* call av_write_frame() instead as it is slightly faster. It is also important
        '* to keep in mind that completely non-interleaved input will need huge amounts
        '* of memory to interleave with this, so it is preferable to interleave at the
        '* demuxer level.
        '*
        '* @param s media file handle
        '* @param pkt The packet, which contains the stream_index, buf/buf_size,
        '             dts/pts, ...
        '* @return < 0 on error, = 0 if OK, 1 if end of stream wanted
        '*/
        <DllImport(AVFORMAT_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function av_interleaved_write_frame(ByVal pAVFormatContext As IntPtr, ByVal pAVPacket As IntPtr) As Integer
        End Function

        '/**
        '* Interleave a packet per dts in an output media file.
        '*
        '* Packets with pkt->destruct == av_destruct_packet will be freed inside this
        '* function, so they cannot be used after it. Note that calling av_free_packet()
        '* on them is still safe.
        '*
        '* @param s media file handle
        '* @param out the interleaved packet will be output here
        '* @param pkt the input packet
        '* @param flush 1 if no further packets are available as input and all
        '*              remaining packets should be output
        '* @return 1 if a packet was output, 0 if no packet could be output,
        '*         < 0 if an error occurred
        '*/
        <DllImport(AVFORMAT_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function av_interleave_packet_per_dts(ByVal pAVFormatContext As IntPtr, ByRef p_out_AVPacket As IntPtr, ByVal pAVPacket As IntPtr, ByVal flush As Integer) As Integer
        End Function

        '/**
        '* Write the stream trailer to an output media file and free the
        '* file private data.
        '*
        '* May only be called after a successful call to av_write_header.
        '*
        '* @param s media file handle
        '* @return 0 if OK, AVERROR_xxx on error
        '*/
        <DllImport(AVFORMAT_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function av_write_trailer(ByVal pAVFormatContext As IntPtr) As Integer
        End Function

        '#If FF_API_DUMP_FORMAT Then
        <DllImport(AVFORMAT_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
         Public Shared Sub dump_format(ByVal pAVFormatContext As IntPtr, ByVal index As Integer, <MarshalAs(UnmanagedType.LPTStr)> ByVal url As [String], ByVal is_output As Integer)
        End Sub
        '#End If

#If FF_API_PARSE_DATE Then
        '/**
        ' * Parse datestr and return a corresponding number of microseconds.
        ' *
        ' * @param datestr String representing a date or a duration.
        ' * See av_parse_time() for the syntax of the provided string.
        ' * @deprecated in favor of av_parse_time()
        ' */
        <DllImport(AVFORMAT_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function parse_date(<MarshalAs(UnmanagedType.LPTStr)> ByVal datestr As [String], ByVal duration As Integer) As Int64
        End Function
#End If

        '/**
        '* Get the current time in microseconds.
        '*/
        <DllImport(AVFORMAT_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function av_gettime() As Int64
        End Function

#If FF_API_FIND_INFO_TAG Then
        '/**
        '* @deprecated use av_find_info_tag in libavutil instead.
        '*/
        <DllImport(AVFORMAT_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function find_info_tag(<MarshalAs(UnmanagedType.LPTStr)> ByVal arg As [String], ByVal arg_size As Integer, <MarshalAs(UnmanagedType.LPTStr)> ByVal tag1 As [String], <MarshalAs(UnmanagedType.LPTStr)> ByVal info As [String]) As Integer
        End Function
#End If

        '/**
        '* Return in 'buf' the path with '%d' replaced by a number.
        '*
        '* Also handles the '%0nd' format where 'n' is the total number
        '* of digits and '%%'.
        '*
        '* @param buf destination buffer
        '* @param buf_size destination buffer size
        '* @param path numbered sequence string
        '* @param number frame number
        '* @return 0 if OK, -1 on format error
        '*/
        <DllImport(AVFORMAT_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function av_get_frame_filename(ByVal buf As IntPtr, ByVal buf_size As Integer, <MarshalAs(UnmanagedType.LPTStr)> ByVal path As [String], ByVal number As Integer) As Integer
        End Function

        '/**
        '* Check whether filename actually is a numbered sequence generator.
        '*
        '* @param filename possible numbered sequence string
        '* @return 1 if a valid numbered sequence string, 0 otherwise
        '*/
        <DllImport(AVFORMAT_DLL_NAME), SuppressUnmanagedCodeSecurity()> _
        Public Shared Function av_filename_number_test(<MarshalAs(UnmanagedType.LPTStr)> ByVal filename As [String]) As Integer
        End Function

        ' *********************************************************************************
        ' Constants
        ' *********************************************************************************

        Public Const AV_TIME_BASE As Integer = 1000000

        ' no file should be opened
        Public Const AVFMT_NOFILE As UInteger = &H1

        ' needs '%d' in filename
        Public Const AVFMT_NEEDNUMBER As UInteger = &H2

        ' show format stream IDs numbers
        Public Const AVFMT_SHOW_IDS As UInteger = &H8

        ' format wants AVPicture structure for raw picture data 
        Public Const AVFMT_RAWPICTURE As UInteger = &H20

        ' format wants global header
        Public Const AVFMT_GLOBALHEADER As UInteger = &H40

        ' format doesnt need / has any timestamps
        Public Const AVFMT_NOTIMESTAMPS As UInteger = &H80

        ' AVImageFormat.flags field constants
        Public Const AVIMAGE_INTERLEAVED As UInteger = &H1

        Public Const AVPROBE_SCORE_MAX As Integer = 100

        Public Const PKT_FLAG_KEY As Integer = &H1

        Public Const AVINDEX_KEYFRAME As Integer = &H1

        Public Const MAX_REORDER_DELAY As Integer = 4


        Public Const AVERROR_UNKNOWN As Integer = -1
        Public Const AVERROR_IO As Integer = -2
        Public Const AVERROR_NUMEXPECTED As Integer = -3
        Public Const AVERROR_INVALIDDATA As Integer = -4
        Public Const AVERROR_NOMEM As Integer = -5
        Public Const AVERROR_NOFMT As Integer = -6
        Public Const AVERROR_NOTSUPP As Integer = -7

        ' *********************************************************************************
        ' Constants
        ' *********************************************************************************


        Public Delegate Sub DestructCallback(ByVal pAVPacket As IntPtr)

        <StructLayout(LayoutKind.Sequential)> _
        Public Structure AVPacket
            <MarshalAs(UnmanagedType.I8)> _
            Public pts As Int64
            ' presentation time stamp in time_base units
            <MarshalAs(UnmanagedType.I8)> _
            Public dts As Int64
            ' decompression time stamp in time_base units
            Public data As IntPtr

            <MarshalAs(UnmanagedType.I4)> _
            Public size As Integer

            <MarshalAs(UnmanagedType.I4)> _
            Public stream_index As Integer

            <MarshalAs(UnmanagedType.I4)> _
            Public flags As Integer

            <MarshalAs(UnmanagedType.I4)> _
            Public duration As Integer

            <MarshalAs(UnmanagedType.FunctionPtr)> _
            Public destruct As DestructCallback

            Public priv As IntPtr

            <MarshalAs(UnmanagedType.I8)> _
            Public pos As Int64
        End Structure

        <StructLayout(LayoutKind.Sequential)> _
        Public Structure AVFrac
            <MarshalAs(UnmanagedType.I8)> _
            Private val As Int64
            <MarshalAs(UnmanagedType.I8)> _
            Private num As Int64
            <MarshalAs(UnmanagedType.I8)> _
            Private den As Int64
        End Structure

        <StructLayout(LayoutKind.Sequential)> _
        Public Structure AVProbeData
            <MarshalAs(UnmanagedType.LPStr)> _
            Private filename As [String]
            Private buf As IntPtr
            Private buf_size As Integer
        End Structure

        <StructLayout(LayoutKind.Sequential)> _
        Public Structure AVFormatParameters
            Private time_base As AVRational
            Private sample_rate As Integer
            Private channels As Integer
            Private width As Integer
            Private height As Integer
            Private pix_fmt As PixelFormat
            Private image_format As IntPtr
            ' AVImageFormat
            Private channel As Integer
            <MarshalAs(UnmanagedType.LPStr)> _
            Private device As [String]
            <MarshalAs(UnmanagedType.LPStr)> _
            Private standard As [String]
            Private mpeg2ts_raw As Integer
            Private mpeg2ts_compute_pcr As Integer
            Private initial_pause As Integer
            Private prealloced_context As Integer
            Private video_codec_id As CodecID
            Private audio_codec_id As CodecID
        End Structure

        Public Delegate Function WriteHeader(ByVal pAVFormatContext As IntPtr) As Integer
        Public Delegate Function WritePacket(ByVal pAVFormatContext As IntPtr, ByVal pAVPacket As IntPtr) As Integer
        Public Delegate Function WriteTrailer(ByVal pAVFormatContext As IntPtr) As Integer
        Public Delegate Function SetParametersCallback(ByVal pAVFormatContext As IntPtr, ByVal avFormatParameters As IntPtr) As Integer
        Public Delegate Function InterleavePacketCallback(ByVal pAVFormatContext As IntPtr, ByVal pOutAVPacket As IntPtr, ByVal pInAVPacket As IntPtr, ByVal flush As Integer) As Integer

        <StructLayout(LayoutKind.Sequential)> _
        Public Structure AVOutputFormat
            <MarshalAs(UnmanagedType.LPStr)> _
            Private name As [String]

            <MarshalAs(UnmanagedType.LPStr)> _
            Private long_name As [String]

            <MarshalAs(UnmanagedType.LPStr)> _
            Private mime_type As [String]

            <MarshalAs(UnmanagedType.LPStr)> _
            Private extensions As [String]

            Private priv_data_size As Integer

            Private audio_codec As CodecID

            Private video_codec As CodecID

            <MarshalAs(UnmanagedType.FunctionPtr)> _
            Private write_header As WriteHeader

            <MarshalAs(UnmanagedType.FunctionPtr)> _
            Private write_packet As WritePacket

            <MarshalAs(UnmanagedType.FunctionPtr)> _
            Private write_trailer As WriteTrailer

            Private flags As Integer

            <MarshalAs(UnmanagedType.FunctionPtr)> _
            Private set_parameters As SetParametersCallback

            <MarshalAs(UnmanagedType.FunctionPtr)> _
            Private interleave_packet As InterleavePacketCallback

            '/**
            '* list of supported codec_id-codec_tag pairs, ordered by "better choice first"
            '* the arrays are all CODEC_ID_NONE terminated
            '*/
            'Private codec_tag As AVCodecTag [나중에]

            Private subtitle_codec As CodecID

            Private nextAVOutputFormat As IntPtr
        End Structure

        Public Delegate Function ReadProbeCallback(ByVal pAVProbeData As IntPtr) As Integer
        Public Delegate Function ReadHeaderCallback(ByVal pAVFormatContext As IntPtr, ByVal pAVFormatParameters As IntPtr) As Integer
        Public Delegate Function ReadPacketCallback(ByVal pAVFormatContext As IntPtr, ByVal pAVPacket As IntPtr) As Integer
        Public Delegate Function ReadCloseCallback(ByVal pAVFormatContext As IntPtr) As Integer
        Public Delegate Function ReadSeekCallback(ByVal pAVFormatContext As IntPtr, ByVal stream_index As Integer, ByVal timestamp As Int64, ByVal flags As Integer) As Integer

        'int64_t (*read_timestamp)(struct AVFormatContext *s, int stream_index,
        'int64_t *pos, int64_t pos_limit);
        Public Delegate Function ReadTimestampCallback(ByVal pAVFormatContext As IntPtr, ByVal stream_index As Integer, ByVal pos As IntPtr, ByVal pos_limit As Int64) As Integer
        Public Delegate Function ReadPlayCallback(ByVal pAVFormatContext As IntPtr) As Integer
        Public Delegate Function ReadPauseCallback(ByVal pAVFormatContext As IntPtr) As Integer

        <StructLayout(LayoutKind.Sequential)> _
        Public Structure AVInputFormat
            <MarshalAs(UnmanagedType.LPStr)> _
            Private name As [String]

            <MarshalAs(UnmanagedType.LPStr)> _
            Private long_name As [String]

            Private priv_data_size As Integer

            <MarshalAs(UnmanagedType.FunctionPtr)> _
            Private read_probe As ReadProbeCallback

            <MarshalAs(UnmanagedType.FunctionPtr)> _
            Private read_header As ReadHeaderCallback

            <MarshalAs(UnmanagedType.FunctionPtr)> _
            Private read_packet As ReadPacketCallback

            <MarshalAs(UnmanagedType.FunctionPtr)> _
            Private read_close As ReadCloseCallback

            <MarshalAs(UnmanagedType.FunctionPtr)> _
            Private read_seek As ReadSeekCallback

            <MarshalAs(UnmanagedType.FunctionPtr)> _
            Private read_timestamp As ReadTimestampCallback

            ' can use flags: AVFMT_NOFILE, AVFMT_NEEDNUMBER
            Private flags As Integer

            <MarshalAs(UnmanagedType.LPStr)> _
            Private extensions As [String]

            Private value As Integer

            <MarshalAs(UnmanagedType.FunctionPtr)> _
            Private read_play As ReadPlayCallback

            <MarshalAs(UnmanagedType.FunctionPtr)> _
            Private read_pause As ReadPauseCallback

            Private nextAVInputFormat As IntPtr
        End Structure

        Public Enum AVStreamParseType
            AVSTREAM_PARSE_NONE '
            AVSTREAM_PARSE_FULL '       /**< full parsing and repack */
            AVSTREAM_PARSE_HEADERS '    /**< Only parse headers, do not repack. */
            AVSTREAM_PARSE_TIMESTAMPS ' /**< full parsing and interpolation of timestamps for frames not starting on a packet boundary */
            AVSTREAM_PARSE_FULL_ONCE '  /**< full parsing and repack of the first frame only, only implemented for H.264 currently */
        End Enum

        <StructLayout(LayoutKind.Sequential)> _
        Public Structure AVIndexEntry
            Private pos As Int64
            Private timestamp As Int64
            Private flags As Integer
            Private size As Integer
            Private min_distance As Integer
        End Structure

        Public Const AV_DISPOSITION_DEFAULT As UInteger = &H1
        Public Const AV_DISPOSITION_DUB As UInteger = &H2
        Public Const AV_DISPOSITION_ORIGINAL As UInteger = &H4
        Public Const AV_DISPOSITION_COMMENT As UInteger = &H8
        Public Const AV_DISPOSITION_LYRICS As UInteger = &H10
        Public Const AV_DISPOSITION_KARAOKE As UInteger = &H20

        '/**
        '* Stream structure.
        '* New fields can be added to the end with minor version bumps.
        '* Removal, reordering and changes to existing fields require a major
        '* version bump.
        '* sizeof(AVStream) must not be used outside libav*.
        '*/
        <StructLayout(LayoutKind.Sequential)> _
        Public Structure AVStream
            <MarshalAs(UnmanagedType.I4)> _
            Public index As Integer
            ' stream index in AVFormatContext
            <MarshalAs(UnmanagedType.I4)> _
            Public id As Integer
            ' format specific stream id
            Public codec As IntPtr
            ' AVCodecContext
            '*
            '             * real base frame rate of the stream.
            '             * for example if the timebase is 1/90000 and all frames have either
            '             * approximately 3600 or 1800 timer ticks then r_frame_rate will be 50/1
            '             

            Public r_frame_rate As AVRational

            Public priv_data As IntPtr

            <MarshalAs(UnmanagedType.I8)> _
            Public codec_info_duration As Int64
            ' internal data used in av_find_stream_info()
            <MarshalAs(UnmanagedType.I4)> _
            Public codec_info_nb_frames As Integer

            Public pts As AVFrac
            ' encoding: PTS generation when outputing stream 
            '*
            '             * this is the fundamental unit of time (in seconds) in terms
            '             * of which frame timestamps are represented. for fixed-fps content,
            '             * timebase should be 1/framerate and timestamp increments should be
            '             * identically 1.
            '             

            Public time_base As AVRational

            <MarshalAs(UnmanagedType.I4)> _
            Public pts_wrap_bits As Integer
            ' number of bits in pts (used for wrapping control) 
            <MarshalAs(UnmanagedType.I4)> _
            Public stream_copy As Integer
            ' if TRUE, just copy stream 
            Public discard As AVDiscard
            ' selects which packets can be discarded at will and dont need to be demuxed
            <MarshalAs(UnmanagedType.R4)> _
            Public quality As Single

            <MarshalAs(UnmanagedType.I8)> _
            Public start_time As Int64

            ' decoding: duration of the stream, in AV_TIME_BASE fractional seconds. 
            <MarshalAs(UnmanagedType.I8)> _
            Public duration As Int64

            <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> _
            Public language As Byte()
            ' ISO 639 3-letter language code (empty string if undefined)
            <MarshalAs(UnmanagedType.I4)> _
            Public need_parsing As Integer

            Public pAVCodecParserContext As IntPtr

            <MarshalAs(UnmanagedType.I8)> _
            Public cur_dts As Int64

            <MarshalAs(UnmanagedType.I4)> _
            Public last_IP_duration As Integer

            <MarshalAs(UnmanagedType.I8)> _
            Public last_IP_pts As Int64

            Public pAVIndexEntry As IntPtr
            ' only used if the format does not support seeking natively
            <MarshalAs(UnmanagedType.I4)> _
            Public nb_index_entries As Integer

            <MarshalAs(UnmanagedType.I4)> _
            Public index_entries_allocated_size As Integer

            <MarshalAs(UnmanagedType.I8)> _
            Public nb_frames As Int64
            ' number of frames in this stream if known or 0

            Public Const MAX_REORDER_DELAY As Integer = 4

            <MarshalAs(UnmanagedType.ByValArray, SizeConst:=(MAX_REORDER_DELAY + 1))> _
            Public pts_buffer As Int64()
            ' pts_buffer[MAX_REORDER_DELAY+1]

            'Public filename As [String] '/**< source filename of the stream */

            '<MarshalAs(UnmanagedType.I4)> _
            'Public disposition As Integer '/**< AV_DISPOSITION_* bitfield */
        End Structure

        Public Const AV_PROGRAM_RUNNING As Integer = 1

        '/**
        ' * New fields can be added to the end with minor version bumps.
        ' * Removal, reordering and changes to existing fields require a major
        ' * version bump.
        ' * sizeof(AVProgram) must not be used outside libav*.
        ' */
        <StructLayout(LayoutKind.Sequential)> _
        Public Structure AVProgram

            <MarshalAs(UnmanagedType.I4)> _
            Public id As Integer

            <MarshalAs(UnmanagedType.I4)> _
            Public flags As Integer

            Public discard As AVDiscard

            <MarshalAs(UnmanagedType.U4)> _
            Public stream_index As UInteger

            <MarshalAs(UnmanagedType.U4)> _
            Public nb_stream_indexes As UInteger

            'Public metadata As AVMetadata [나중에]

        End Structure

        Public Const AVFMTCTX_NOHEADER As UInteger = &H1

        <StructLayout(LayoutKind.Sequential)> _
        Public Structure AVChapter

            <MarshalAs(UnmanagedType.I4)> _
            Public id As Integer

            Public time_base As AVRational

            <MarshalAs(UnmanagedType.I8)> _
            Public start As Int64

            <MarshalAs(UnmanagedType.I8)> _
            Public [end] As Int64

            'Public metadata As AVMetadata [나중에]

        End Structure
        Public Const MAX_STREAMS As Integer = 20

        '/**
        '* format I/O context.
        '* New fields can be added to the end with minor version bumps.
        '* Removal, reordering and changes to existing fields require a major
        '* version bump.
        '* sizeof(AVFormatContext) must not be used outside libav*.
        '*/
        <StructLayout(LayoutKind.Sequential)> _
        Public Structure AVFormatContext
            Public pAVClass As IntPtr '/**< Set by avformat_alloc_context. */
            '/* Can only be iformat or oformat, not both at the same time. */
            Public pAVInputFormat As IntPtr
            Public pAVOutputFormat As IntPtr
            Public priv_data As IntPtr

            Public pb As AVIOContext

            <MarshalAs(UnmanagedType.U4)> _
            Public nb_streams As UInteger

            <MarshalAs(UnmanagedType.ByValArray, SizeConst:=MAX_STREAMS)> _
            Public streams As IntPtr()

            <MarshalAs(UnmanagedType.ByValArray, SizeConst:=1024)> _
            Public filename As Byte() '/**< input or output filename */

            '/* stream info */
            <MarshalAs(UnmanagedType.I8)> _
            Public timestamp As Int64

            <MarshalAs(UnmanagedType.I4)> _
            Public ctx_flags As Integer '/**< Format-specific flags, see AVFMTCTX_xx */
            '/* private data for pts handling (do not modify directly). */
            '/**
            ' * This buffer is only needed when packets were already buffered but
            ' * not decoded, for example to get the codec parameters in MPEG
            ' * streams.
            '*/
            Public packet_buffer As IntPtr

            '/**
            '* Decoding: position of the first frame of the component, in
            '* AV_TIME_BASE fractional seconds. NEVER set this value directly:
            '* It is deduced from the AVStream values.
            '*/
            <MarshalAs(UnmanagedType.I8)> _
            Public start_time As Int64

            '/**
            '* Decoding: duration of the stream, in AV_TIME_BASE fractional
            '* seconds. Only set this value if you know none of the individual stream
            '* durations and also dont set any of them. This is deduced from the
            '* AVStream values if not set.
            '*/
            <MarshalAs(UnmanagedType.I8)> _
            Public duration As Int64

            '/**
            ' * decoding: total file size, 0 if unknown
            ' */
            <MarshalAs(UnmanagedType.I8)> _
            Public file_size As Int64

            '/**
            '* Decoding: total stream bitrate in bit/s, 0 if not
            '* available. Never set it directly if the file_size and the
            '* duration are known as FFmpeg can compute it automatically.
            '*/
            <MarshalAs(UnmanagedType.I4)> _
            Public bit_rate As Integer

            '/* av_read_frame() support */
            Public cur_st As IntPtr

            '/* av_seek_frame() support */
            <MarshalAs(UnmanagedType.I8)> _
            Public data_offset As Int64 '/**< offset of the first packet */

            <MarshalAs(UnmanagedType.I4)> _
            Public mux_rate As Integer

            <MarshalAs(UnmanagedType.U4)> _
            Public packet_size As UInteger

            <MarshalAs(UnmanagedType.I4)> _
            Public preload As Integer

            <MarshalAs(UnmanagedType.I4)> _
            Public max_delay As Integer

            Public Const AVFMT_NOOUTPUTLOOP As Integer = -1
            Public Const AVFMT_INFINITEOUTPUTLOOP As Integer = 0
            '/**
            '* number of times to loop output in formats that support it
            '*/
            <MarshalAs(UnmanagedType.I4)> _
            Public loop_output As Integer

            <MarshalAs(UnmanagedType.I4)> _
            Public flags As Integer
            Public Const AVFMT_FLAG_GENPTS As UInteger = &H1 '///< Generate missing pts even if it requires parsing future frames.
            Public Const AVFMT_FLAG_IGNIDX As UInteger = &H2 '///< Ignore index.
            Public Const AVFMT_FLAG_NONBLOCK As UInteger = &H4 '///< Do not block when reading packets from input.
            Public Const AVFMT_FLAG_IGNDTS As UInteger = &H8 '///< Ignore DTS on frames that contain both DTS & PTS
            Public Const AVFMT_FLAG_NOFILLIN As UInteger = &H10 '///< Do not infer any values from other values, just return what is stored in the container
            Public Const AVFMT_FLAG_NOPARSE As UInteger = &H20 '///< Do not use AVParsers, you also must set AVFMT_FLAG_NOFILLIN as the fillin code works on frames and no parsing -> no frames. Also seeking to frames can not work if parsing to find frame boundaries has been disabled
            Public Const AVFMT_FLAG_RTP_HINT As UInteger = &H40 '///< Add RTP hinting to the output file
            Public Const AVFMT_FLAG_SORT_DTS As UInteger = &H10000 '///< try to interleave outputted packets by dts (using this flag can slow demuxing down)
            Public Const AVFMT_FLAG_PRIV_OPT As UInteger = &H20000 '///< Enable use of private options by delaying codec open (this could be made default once all code is converted)

            <MarshalAs(UnmanagedType.I4)> _
            Public loop_input As Integer

            '/**
            '* decoding: size of data to probe; encoding: unused.
            '*/
            <MarshalAs(UnmanagedType.U4)> _
            Public probesize As UInteger

            '/**
            '* Maximum time (in AV_TIME_BASE units) during which the input should
            '* be analyzed in av_find_stream_info().
            '*/
            <MarshalAs(UnmanagedType.I4)> _
            Public max_analyze_duration As Integer

            Public key As IntPtr

            <MarshalAs(UnmanagedType.I4)> _
            Public keylen As Integer

            <MarshalAs(UnmanagedType.U4)> _
            Public nb_programs As UInteger

            Public programs As IntPtr

            '/**
            ' * Forced video codec_id.
            ' * Demuxing: Set by user.
            ' */
            Public video_codec_id As CodecID

            '/**
            ' * Forced audio codec_id.
            ' * Demuxing: Set by user.
            ' */
            Public audio_codec_id As CodecID

            '/**
            '* Forced subtitle codec_id.
            '* Demuxing: Set by user.
            '*/
            Public subtitle_codec_id As CodecID

            '/**
            '  * Maximum amount of memory in bytes to use for the index of each stream.
            '  * If the index exceeds this size, entries will be discarded as
            '  * needed to maintain a smaller size. This can lead to slower or less
            '  * accurate seeking (depends on demuxer).
            '  * Demuxers for which a full in-memory index is mandatory will ignore
            '  * this.
            '  * muxing  : unused
            '  * demuxing: set by user
            '  */
            <MarshalAs(UnmanagedType.U4)> _
            Public max_index_size As UInteger

            '/**
            '* Maximum amount of memory in bytes to use for buffering frames
            '* obtained from realtime capture devices.
            '*/
            <MarshalAs(UnmanagedType.U4)> _
            Public max_picture_buffer As UInteger

            <MarshalAs(UnmanagedType.U4)> _
            Public nb_chapters As UInteger

            <MarshalAs(UnmanagedType.ByValArray, SizeConst:=MAX_STREAMS)> _
            Public chapters As IntPtr()

            '/**
            '* Flags to enable debugging.
            '*/
            <MarshalAs(UnmanagedType.I4)> _
            Public debug As Integer

            Public Const FF_FDEBUG_TS As UInteger = &H1

            '/**
            '* Raw packets from the demuxer, prior to parsing and decoding.
            '* This buffer is used for buffering packets until the codec can
            '* be identified, as parsing cannot be done without knowing the
            '* codec.
            '*/

            Public metadata As IntPtr

            '/**
            '* Remaining size available for raw_packet_buffer, in bytes.
            '* NOT PART OF PUBLIC API
            '*/
            Public Const RAW_PACKET_BUFFER_SIZE As UInteger = 2500000

            <MarshalAs(UnmanagedType.I4)> _
            Public raw_packet_buffer_remaining_size As Integer

            '/**
            ' * Start time of the stream in real world time, in microseconds
            ' * since the unix epoch (00:00 1st January 1970). That is, pts=0
            ' * in the stream was captured at this real world time.
            ' * - encoding: Set by user.
            ' * - decoding: Unused.
            ' */
            <MarshalAs(UnmanagedType.I8)> _
            Public start_time_realtime As Int64
        End Structure

        <StructLayout(LayoutKind.Sequential)> _
        Public Structure AVPacketList
            Public pkt As AVPacket
            Public [next] As IntPtr
            ' AVPacketList
        End Structure

        <StructLayout(LayoutKind.Sequential)> _
        Public Structure AVImageInfo
            Public pix_fmt As PixelFormat
            ' requested pixel format
            <MarshalAs(UnmanagedType.I4)> _
            Public width As Integer
            ' requested width
            <MarshalAs(UnmanagedType.I4)> _
            Public height As Integer
            ' requested height 
            <MarshalAs(UnmanagedType.I4)> _
            Public interleaved As Integer
            ' image is interleaved (e.g. interleaved GIF) 
            Public pict As AVPicture
            ' returned allocated image           
        End Structure

    End Class

End Namespace