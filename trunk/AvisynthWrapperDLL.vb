' ****************************************************************************
' 
' Copyright (C) 2005-2009  Doom9 & al
' 
' This program is free software; you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation; either version 2 of the License, or
' (at your option) any later version.
' 
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
' 
' You should have received a copy of the GNU General Public License
' along with this program; if not, write to the Free Software
' Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
' 
' ****************************************************************************

Imports System.Collections
Imports System.Runtime.InteropServices
Imports System.Runtime.Serialization
Imports System.Text

Namespace AvisynthWrapper

    Public Enum AviSynthColorspace As Integer
        Unknown = 0
        YV12 = -1610612728
        RGB24 = +1342177281
        RGB32 = +1342177282
        YUY2 = -1610612740
        I420 = -1610612720
        IYUV = I420
    End Enum

    Public Class AviSynthException

        Inherits ApplicationException

        Public Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
            MyBase.New(info, context)
        End Sub

        Public Sub New(ByVal message As String)
            MyBase.New(message)
        End Sub

        Public Sub New()
            MyBase.New()
        End Sub

        Public Sub New(ByVal message As String, ByVal innerException As Exception)
            MyBase.New(message, innerException)
        End Sub

    End Class

    Public Enum AudioSampleType As Integer
        Unknown = 0
        INT8 = 1
        INT16 = 2
        INT24 = 4
        ' Int24 is a very stupid thing to code, but it's supported by some hardware.
        INT32 = 8
        FLOAT = 16
    End Enum

    Public NotInheritable Class AviSynthScriptEnvironment

        Implements IDisposable

        Public Shared Function GetLastError() As String
            Return Nothing
        End Function

        Public Sub New()
        End Sub

        Public ReadOnly Property Handle() As IntPtr
            Get
                Return New IntPtr(0)
            End Get
        End Property

        Public Function OpenScriptFile(ByVal filePath As String, ByVal forceColorspace As AviSynthColorspace) As AviSynthClip
            Return New AviSynthClip("Import", filePath, forceColorspace, Me)
        End Function

        Public Function ParseScript(ByVal script As String, ByVal forceColorspace As AviSynthColorspace) As AviSynthClip
            Return New AviSynthClip("Eval", script, forceColorspace, Me)
        End Function

        Public Function OpenScriptFile(ByVal filePath As String) As AviSynthClip
            Return OpenScriptFile(filePath, AviSynthColorspace.RGB24)
        End Function

        Public Function ParseScript(ByVal script As String) As AviSynthClip
            Return ParseScript(script, AviSynthColorspace.RGB24)
        End Function

        Private Sub IDisposable_Dispose() Implements IDisposable.Dispose

        End Sub

    End Class

    Public Class AviSynthClip
        Implements IDisposable

#Region "PInvoke related stuff"

        <StructLayout(LayoutKind.Sequential)> _
        Private Structure AVSDLLVideoInfo
            Public width As Integer
            Public height As Integer
            Public raten As Integer
            Public rated As Integer
            Public aspectn As Integer
            Public aspectd As Integer
            Public interlaced_frame As Integer
            Public top_field_first As Integer
            Public num_frames As Integer
            Public pixel_type As AviSynthColorspace
            ' Audio
            Public audio_samples_per_second As Integer
            Public sample_type As AudioSampleType
            Public nchannels As Integer
            Public num_audio_frames As Integer
            Public num_audio_samples As Long
        End Structure

        <DllImport("AvisynthWrapper", ExactSpelling:=True, SetLastError:=False, CharSet:=CharSet.Ansi)> _
        Private Shared Function dimzon_avs_init(ByRef avs As IntPtr, ByVal func As String, ByVal arg As String, ByRef vi As AVSDLLVideoInfo, ByRef originalColorspace As AviSynthColorspace, ByRef originalSampleType As AudioSampleType, _
         ByVal cs As String) As Integer
        End Function
        <DllImport("AvisynthWrapper", ExactSpelling:=True, SetLastError:=False, CharSet:=CharSet.Ansi)> _
        Private Shared Function dimzon_avs_init_2(ByRef avs As IntPtr, ByVal func As String, ByVal arg As String, ByRef vi As AVSDLLVideoInfo, ByRef originalColorspace As AviSynthColorspace, ByRef originalSampleType As AudioSampleType, _
         ByVal cs As String) As Integer
        End Function
        <DllImport("AvisynthWrapper", ExactSpelling:=True, SetLastError:=False, CharSet:=CharSet.Ansi)> _
        Private Shared Function dimzon_avs_destroy(ByRef avs As IntPtr) As Integer
        End Function
        <DllImport("AvisynthWrapper", ExactSpelling:=True, SetLastError:=False, CharSet:=CharSet.Ansi)> _
        Private Shared Function dimzon_avs_getlasterror(ByVal avs As IntPtr, <MarshalAs(UnmanagedType.LPStr)> ByVal sb As StringBuilder, ByVal len As Integer) As Integer
        End Function
        <DllImport("AvisynthWrapper", ExactSpelling:=True, SetLastError:=False, CharSet:=CharSet.Ansi)> _
        Private Shared Function dimzon_avs_getaframe(ByVal avs As IntPtr, ByVal buf As IntPtr, ByVal sampleNo As Long, ByVal sampleCount As Long) As Integer
        End Function
        <DllImport("AvisynthWrapper", ExactSpelling:=True, SetLastError:=False, CharSet:=CharSet.Ansi)> _
        Private Shared Function dimzon_avs_getvframe(ByVal avs As IntPtr, ByVal buf As IntPtr, ByVal stride As Integer, ByVal frm As Integer) As Integer
        End Function
        <DllImport("AvisynthWrapper", ExactSpelling:=True, SetLastError:=False, CharSet:=CharSet.Ansi)> _
        Private Shared Function dimzon_avs_getintvariable(ByVal avs As IntPtr, ByVal name As String, ByRef val As Integer) As Integer
        End Function

#End Region

        Private _avs As IntPtr
        Private _vi As AVSDLLVideoInfo
        Private _colorSpace As AviSynthColorspace
        Private _sampleType As AudioSampleType

#If dimzon Then

		#Region "syncronization staff"

		Private Class EnvRef
			Public env As IntPtr
			Public refCount As Long
			Public lockObj As Object
			Public threadID As Integer

			Public Sub New(e As IntPtr, threadID As Integer)
				Me.env = e
				refCount = 1
				lockObj = New Object()
				Me.threadID = threadID
			End Sub
		End Class
		Private Shared _threadHash As New Hashtable()

		Private Function createNewEnvRef(threadId As Integer) As EnvRef
			'TODO:
			Return New EnvRef(New IntPtr(0), threadId)
		End Function

		Private Sub destroyEnvRef(r As EnvRef)
			'TODO:
		End Sub

		Private Function addRef() As EnvRef
			Dim threadId As Integer = System.Threading.Thread.CurrentThread.ManagedThreadId
			SyncLock _threadHash.SyncRoot
				Dim r As EnvRef
				If _threadHash.ContainsKey(threadId) Then
					r = DirectCast(_threadHash(threadId), EnvRef)
					SyncLock r.lockObj
						If 0 = r.refCount Then
							r = createNewEnvRef(threadId)
							_threadHash.Remove(threadId)
							_threadHash.Add(threadId, r)
						Else
							r.refCount += 1
						End If
					End SyncLock
				Else
					r = createNewEnvRef(threadId)
					_threadHash.Add(threadId, r)
				End If
				Return r
			End SyncLock
		End Function

		Private Sub Release()
			If _avsEnv Is Nothing Then
				Return
			End If
			SyncLock _avsEnv.lockObj
				_avsEnv.refCount -= 1
				If 0 = _avsEnv.refCount Then
					destroyEnvRef(_avsEnv)
				End If
			End SyncLock
			_avsEnv = Nothing
		End Sub

		Private _avsEnv As EnvRef

		#End Region

#End If

        Public Function getLastError() As String
            Const errlen As Integer = 1024
            Dim sb As New StringBuilder(errlen)
            sb.Length = dimzon_avs_getlasterror(_avs, sb, errlen)
            Return sb.ToString()
        End Function

#Region "Clip Properties"

        Public ReadOnly Property HasVideo() As Boolean
            Get
                Return VideoWidth > 0 AndAlso VideoHeight > 0
            End Get
        End Property

        Public ReadOnly Property VideoWidth() As Integer
            Get
                Return _vi.width
            End Get
        End Property
        Public ReadOnly Property VideoHeight() As Integer
            Get
                Return _vi.height
            End Get
        End Property
        Public ReadOnly Property raten() As Integer
            Get
                Return _vi.raten
            End Get
        End Property

        Public ReadOnly Property rated() As Integer
            Get
                Return _vi.rated
            End Get
        End Property
        Public ReadOnly Property aspectn() As Integer
            Get
                Return _vi.aspectn
            End Get
        End Property
        Public ReadOnly Property aspectd() As Integer
            Get
                Return _vi.aspectd
            End Get
        End Property
        Public ReadOnly Property interlaced_frame() As Integer
            Get
                Return _vi.interlaced_frame
            End Get
        End Property
        Public ReadOnly Property top_field_first() As Integer
            Get
                Return _vi.top_field_first
            End Get
        End Property
        Public ReadOnly Property num_frames() As Integer
            Get
                Return _vi.num_frames
            End Get
        End Property

        ' Audio
        Public ReadOnly Property AudioSampleRate() As Integer
            Get
                Return _vi.audio_samples_per_second
            End Get
        End Property

        Public ReadOnly Property SamplesCount() As Long
            Get
                Return _vi.num_audio_samples
            End Get
        End Property
        Public ReadOnly Property SampleType() As AudioSampleType
            Get
                Return _vi.sample_type
            End Get
        End Property
        Public ReadOnly Property ChannelsCount() As Short
            Get
                Return CShort(_vi.nchannels)
            End Get
        End Property

        Public ReadOnly Property PixelType() As AviSynthColorspace
            Get
                Return _vi.pixel_type
            End Get
        End Property

        Public ReadOnly Property OriginalColorspace() As AviSynthColorspace
            Get
                Return _colorSpace
            End Get
        End Property
        Public ReadOnly Property OriginalSampleType() As AudioSampleType
            Get
                Return _sampleType
            End Get
        End Property

#End Region

        Public Function GetIntVariable(ByVal variableName As String, ByVal defaultValue As Integer) As Integer
            Dim v As Integer = 0
            Dim res As Integer = 0
            res = dimzon_avs_getintvariable(Me._avs, variableName, v)
            If res < 0 Then
                Throw New AviSynthException(getLastError())
            End If
            Return If((0 = res), v, defaultValue)
        End Function

        Public Sub ReadAudio(ByVal addr As IntPtr, ByVal offset As Long, ByVal count As Integer)
            If 0 <> dimzon_avs_getaframe(_avs, addr, offset, count) Then
                Throw New AviSynthException(getLastError())
            End If

        End Sub

        Public Sub ReadAudio(ByVal buffer As Byte, ByVal offset As Long, ByVal count As Integer)
            Dim h As GCHandle = GCHandle.Alloc(buffer, GCHandleType.Pinned)
            Try
                ReadAudio(h.AddrOfPinnedObject(), offset, count)
            Finally
                h.Free()
            End Try
        End Sub

        Public Sub ReadFrame(ByVal addr As IntPtr, ByVal stride As Integer, ByVal frame As Integer)
            If 0 <> dimzon_avs_getvframe(_avs, addr, stride, frame) Then
                Ref()
            End If

        End Sub

        Public Sub ReadFrame2(ByVal addr As IntPtr, ByVal stride As Integer, ByVal frame As Integer)
            If 0 <> dimzon_avs_getvframe(_avs, addr, stride, frame) Then
                Throw New AviSynthException(getLastError())
            End If

        End Sub

        Public Sub Ref()
            Try
                AviSynthEditorFrm.waitbool = True
                VideoWindowFrm.TR = True
                VideoWindowFrm.Ref_SUB()
                VideoWindowFrm.TR = False
                AviSynthEditorFrm.waitbool = False
            Catch ex As Exception
                Throw New AviSynthException(getLastError())
            End Try
        End Sub

        Public Sub New(ByVal func As String, ByVal arg As String, ByVal forceColorspace As AviSynthColorspace, ByVal env As AviSynthScriptEnvironment)

            _vi = New AVSDLLVideoInfo()
            _avs = New IntPtr(0)
            _colorSpace = AviSynthColorspace.Unknown
            _sampleType = AudioSampleType.Unknown
            If 0 <> dimzon_avs_init_2(_avs, func, arg, _vi, _colorSpace, _sampleType, _
             forceColorspace.ToString()) Then
                Dim err As String = getLastError()
                cleanup(False)
                Throw New AviSynthException(err)
            End If
        End Sub

        Private Sub cleanup(ByVal disposing As Boolean)
            dimzon_avs_destroy(_avs)
            _avs = New IntPtr(0)
            If disposing Then
                GC.SuppressFinalize(Me)
            End If
        End Sub

        Protected Overrides Sub Finalize()
            Try
                cleanup(False)
            Finally
                MyBase.Finalize()
            End Try
        End Sub

        Public Sub IDisposable_Dispose() Implements IDisposable.Dispose
            cleanup(True)
        End Sub

        Public ReadOnly Property BitsPerSample() As Short
            Get
                Return CShort(BytesPerSample * 8)
            End Get
        End Property

        Public ReadOnly Property BytesPerSample() As Short
            Get
                Select Case SampleType
                    Case AudioSampleType.INT8
                        Return 1
                    Case AudioSampleType.INT16
                        Return 2
                    Case AudioSampleType.INT24
                        Return 3
                    Case AudioSampleType.INT32
                        Return 4
                    Case AudioSampleType.FLOAT
                        Return 4
                    Case Else
                        Throw New ArgumentException(SampleType.ToString())
                End Select
            End Get
        End Property

        Public ReadOnly Property AvgBytesPerSec() As Integer
            Get
                Return AudioSampleRate * ChannelsCount * BytesPerSample
            End Get
        End Property

        Public ReadOnly Property AudioSizeInBytes() As Long
            Get
                Return SamplesCount * ChannelsCount * BytesPerSample
            End Get
        End Property

    End Class

End Namespace