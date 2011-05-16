' ---------------------------------------------------------------------------------------
' 
' Copyright (C) 2011 LEE KIWON
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

Imports FFmpegVB.FFmpeg
Imports System.Runtime.InteropServices
Imports System.Threading
Imports System.Drawing.Imaging
Imports System.Reflection

Public Class MainFrm

    Dim _FileName As String
    Dim _Loading As Boolean = False
    Dim pVideoCodecCtx As IntPtr
    Dim pFormatCtx As IntPtr
    Dim fpsi As Integer = 0
    Dim fpssum As Integer = 0
    '메모리정리
    Private Declare Function SetProcessWorkingSetSize Lib "kernel32.dll" ( _
       ByVal process As IntPtr, _
       ByVal minimumWorkingSetSize As Integer, _
       ByVal maximumWorkingSetSize As Integer) As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If _Loading = True Then
            FFClose()
            Exit Sub
        End If

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            _FileName = OpenFileDialog1.FileName
            DecodeImage()
        End If

    End Sub

    Private Sub DecodeImage()

        _Loading = True
        Libavformat.av_register_all()

        If Libavformat.av_open_input_file(pFormatCtx, _FileName, IntPtr.Zero, 0, IntPtr.Zero) < 0 OrElse Libavformat.av_find_stream_info(pFormatCtx) < 0 Then
            TextBox1.Text = "파일 열기 실패(Failed to open file)"
            _Loading = False
            Exit Sub
        End If

        Libavformat.dump_format(pFormatCtx, 0, _FileName, 0)

        Dim FormatCtx As Libavformat.AVFormatContext
        FormatCtx = DirectCast(Marshal.PtrToStructure(pFormatCtx, GetType(Libavformat.AVFormatContext)), Libavformat.AVFormatContext)

        Dim videoStream As Integer = -1
        Dim pVideoCodec As IntPtr
        Dim VideoCodecCtx As Libavcodec.AVCodecContext
        Dim i As Integer = 0

        Try
            For i = 0 To FormatCtx.nb_streams - 1
                Dim _AVStream As Libavformat.AVStream = DirectCast(Marshal.PtrToStructure(FormatCtx.streams(i), GetType(Libavformat.AVStream)), Libavformat.AVStream)
                Dim _AVCodecContext As Libavcodec.AVCodecContext = DirectCast(Marshal.PtrToStructure(_AVStream.codec, GetType(Libavcodec.AVCodecContext)), Libavcodec.AVCodecContext)
                If _AVCodecContext.codec_type = Libavutil.AVMediaType.AVMEDIA_TYPE_VIDEO AndAlso videoStream = -1 Then
                    videoStream = i
                    pVideoCodecCtx = _AVStream.codec
                    VideoCodecCtx = _AVCodecContext
                    pVideoCodec = Libavcodec.avcodec_find_decoder(VideoCodecCtx.codec_id)
                    If pVideoCodec = IntPtr.Zero Then
                        TextBox1.Text = "파일 열기 실패(Failed to open file)"
                        _Loading = False
                        Exit Sub
                    End If
                    Libavcodec.avcodec_open(_AVStream.codec, pVideoCodec)
                End If
            Next
        Catch ex As Exception
            TextBox1.Text = "파일 열기 실패(Failed to open file)"
            _Loading = False
            Exit Sub
        End Try

        If videoStream = -1 Then
            TextBox1.Text = "파일 열기 실패(Failed to open file)"
            _Loading = False
            Exit Sub
        End If

        TextBox1.Text = ""

        Dim _PixelFormat As Libavutil.PixelFormat = Libavutil.PixelFormat.PIX_FMT_RGB24

        Dim pAVFrame, pAVFrameRGB As IntPtr
        pAVFrame = Libavcodec.avcodec_alloc_frame()
        pAVFrameRGB = Libavcodec.avcodec_alloc_frame()

        Dim numBytes As Integer = Libavcodec.avpicture_get_size(_PixelFormat, VideoCodecCtx.width, VideoCodecCtx.height)

        Libavcodec.avpicture_fill(pAVFrameRGB, Marshal.AllocHGlobal(numBytes), _PixelFormat, VideoCodecCtx.width, VideoCodecCtx.height)

        'Dim SwsCtx As IntPtr = Swscale.sws_getContext(VideoCodecCtx.width, VideoCodecCtx.height, VideoCodecCtx.pix_fmt, VideoCodecCtx.width, VideoCodecCtx.height, _
        '                                _PixelFormat, Swscale.SwsFlags.Bicubic, Nothing, Nothing, Nothing)

        Dim pAVPacket As IntPtr = Marshal.AllocHGlobal(52)
        Try
            fpsi = 0
            BackgroundWorker1.RunWorkerAsync()
            While Libavformat.av_read_frame(pFormatCtx, pAVPacket) >= 0
                Dim stramid As Integer = Marshal.ReadInt32(pAVPacket, 24)  ' 24 = offset of streamid
                If stramid = videoStream Then
                    Dim data As IntPtr = Marshal.ReadIntPtr(pAVPacket, 16) '16 = offset of data
                    Dim size As Integer = Marshal.ReadInt32(pAVPacket, 20) '20 = offset of size
                    Dim frameFinished As Integer = 0
                    Libavcodec.avcodec_decode_video(pVideoCodecCtx, pAVFrame, frameFinished, data, size)
                    If frameFinished Then
                        If (System.Threading.Interlocked.Increment(i) >= 5) Then
                            If ViewCheckBox.Checked = True Then
                                'Swscale.sws_scale(SwsCtx, Marshal.ReadIntPtr(pAVFrame, 16), Marshal.ReadInt32(pAVFrame, 20), 0, Height, Marshal.ReadIntPtr(pAVFrameRGB, 16), Marshal.ReadInt32(pAVFrameRGB, 20))
                                'Swscale.sws_freeContext(SwsCtx)
                                Libavcodec.img_convert(pAVFrameRGB, Libavutil.PixelFormat.PIX_FMT_BGR24, pAVFrame, VideoCodecCtx.pix_fmt, VideoCodecCtx.width, VideoCodecCtx.height)
                                SaveFrame(pAVFrameRGB, VideoCodecCtx.width, VideoCodecCtx.height)
                            End If
                            fpsi += 1
                            'Thread.Sleep(1000)
                        End If
                    End If
                End If
                Application.DoEvents()
                Me.Text = fpsi & "(" & fpssum & " fps) GDI+"
            End While
            BackgroundWorker1.CancelAsync()
        Catch ex As Exception
        Finally
            _Loading = False
        End Try
        FFClose()

    End Sub

    Private Sub SaveFrame(ByVal pFrame As IntPtr, ByVal width As Integer, ByVal height As Integer)
        Try
            Dim ptr As IntPtr = Marshal.ReadIntPtr(pFrame)
            Dim BitmapV As New Bitmap(width, height, width * 3, PixelFormat.Format24bppRgb, ptr)
            PictureBox1.Image = BitmapV
        Catch ex As Exception
        End Try
    End Sub

    Private Sub FFClose()

        If _Loading = False Then Exit Sub

        Try
            Libavcodec.avcodec_close(pVideoCodecCtx)
        Catch ex As Exception
        End Try

        Try
            Libavformat.av_close_input_file(pFormatCtx)
        Catch ex As Exception
        End Try

        '메모리 정리
        If (Environment.OSVersion.Platform = PlatformID.Win32NT) Then
            SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1)
        End If

        TextBox1.Text = ""

    End Sub

    Private Sub MainFrm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        FFClose()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If _Loading = True Then
            Button1.Text = "Close"
        Else
            Button1.Text = "Open"
        End If
    End Sub

    Private Sub MainFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        Do Until _Loading = False
            Dim _fpsi As Integer = fpsi
            Thread.Sleep(1000)
            Dim sum_ As Integer = fpsi - _fpsi
            If sum_ > 0 Then               fpssum = sum_
        Loop

    End Sub
End Class
