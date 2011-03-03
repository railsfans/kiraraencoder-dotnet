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

Imports DirectShowLib
Imports DirectShowLib.DMO
Imports DirectShowLib.DES
Imports MediaFoundation
Imports MediaFoundation.EVR
Imports MediaFoundation.Misc
Imports System.Runtime.InteropServices

Public Class MainFrm

    '다이렉트쇼 / 미디어파운데이션
    Private GraphBuilder As IGraphBuilder
    Private BaseFilter As IBaseFilter
    Private FilterGraph As IFilterGraph
    Private MediaControl As IMediaControl
    Private MediaEventEx As IMediaEventEx
    Private MediaSeeking As IMediaSeeking
    Private MediaPosition As IMediaPosition
    Private VideoWindow As IVideoWindow
    Private BasicVideo As IBasicVideo
    Private BasicVideo2 As IBasicVideo2
    Private BasicAudio As IBasicAudio
    Private VideoFrameStep As IVideoFrameStep

    '다이렉트쇼와 미디어파운데이션의 기능
    Private Shared ReadOnly FilterGraph_Guid As New Guid(&HE436EBB3, &H524F, &H11CE, &H9F, &H53, &H0, &H20, &HAF, &HB, &HA7, &H70)
    Private Const WM_GRAPHNOTIFY As Integer = &H8001
    Private Const WS_CHILD As Integer = &H40000000
    Private Const WS_CLIPCHILDREN As Integer = &H2000000
    Private Const WS_CLIPSIBLINGS As Integer = &H4000000

    'Enhanced Video Renderer
    Private MFVideoDisplayControl As IMFVideoDisplayControl
    'VMR 9 Windowless
    Public VMRWindowlessControl9 As IVMRWindowlessControl9
    Private VMRFilterConfig9 As IVMRFilterConfig9
    'VMR 9 Windowed
    Private VMRAspectRatioControl9 As IVMRAspectRatioControl9
    'VMR 7 Windowless
    Public VMRWindowlessControl As IVMRWindowlessControl
    Private VMRFilterConfig As IVMRFilterConfig
    'Overlay Mixer
    Private MixerPinConfig As IMixerPinConfig

    'IMediaSeeking::SetPositions (이동시 사용되는 기능)
    Dim IMSdwCurrentFlags = AMSeekingSeekingFlags.AbsolutePositioning
    Dim IMSpStop = Nothing
    Dim IMSdwStopFlags = Nothing

    '변수//
    Dim GCP_LONG As Long = 0
    Dim GD_LONG As Long = 0

    Dim FILENAME_Str As String = ""
    Dim FilePathV As String = ""
    Dim FilePathCutV As String = ""

    Dim VOLUME_Int As Integer = 100
    Dim MUTE_Bool As Boolean = False

    '폼 이동 API
    Private Const HTCAPTION As Integer = 2
    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Declare Function ReleaseCapture Lib "user32" () As Long
    Private Declare Function SendMessage Lib "user32" Alias "SendMessageW" ( _
    ByVal hwnd As Integer, _
    ByVal uMgs As Integer, _
    ByVal wParam As Long, _
    ByVal lParam As Long) As Long

    Dim LoadingB As Boolean = False

    Public VideoWidth As Integer = 0
    Public VideoHeight As Integer = 0

    '메모리정리
    Private Declare Function SetProcessWorkingSetSize Lib "kernel32.dll" ( _
       ByVal process As IntPtr, _
       ByVal minimumWorkingSetSize As Integer, _
       ByVal maximumWorkingSetSize As Integer) As Integer

#Region "함수 모음"

    Public Function Name_BaseFilter_AddFilter(ByVal GraphBuilder As IGraphBuilder, ByVal _Guid As Guid, ByVal Name As String, ByVal BaseFilter As Object) As Object
        Dim hr As Integer = 0

        If GraphBuilder Is Nothing Then
            Throw New ArgumentNullException("GraphBuilder")
        End If

        Try
            Dim _Type As Type = Type.GetTypeFromCLSID(_Guid)
            hr = GraphBuilder.AddFilter(BaseFilter, Name)
            DsError.ThrowExceptionForHR(hr)
        Catch
            If BaseFilter IsNot Nothing Then
                Marshal.ReleaseComObject(BaseFilter)
                BaseFilter = Nothing
            End If
        End Try

        Return BaseFilter
    End Function

    Public Function Name_AddFilter(ByVal GraphBuilder As IGraphBuilder, ByVal _Guid As Guid, ByVal Name As String) As IBaseFilter
        Dim hr As Integer = 0
        Dim BaseFilter As IBaseFilter = Nothing

        If GraphBuilder Is Nothing Then
            Throw New ArgumentNullException("GraphBuilder")
        End If

        Try
            Dim _Type As Type = Type.GetTypeFromCLSID(_Guid)
            BaseFilter = DirectCast(Activator.CreateInstance(_Type), IBaseFilter)

            hr = GraphBuilder.AddFilter(BaseFilter, Name)
            DsError.ThrowExceptionForHR(hr)
        Catch
            If BaseFilter IsNot Nothing Then
                Marshal.ReleaseComObject(BaseFilter)
                BaseFilter = Nothing
            End If
        End Try

        Return BaseFilter
    End Function

    Function GetFilter(ByVal FilterGraph As IFilterGraph) As List(Of IBaseFilter)

        If FilterGraph Is Nothing Then
            Return Nothing
        End If

        Dim FilterArray As New List(Of IBaseFilter)()
        Dim hr As Integer = 0
        Dim EnumFilters As IEnumFilters = Nothing

        For i = 0 To FilterControlToolStripMenuItem.DropDownItems.Count - 1
            If i = 0 Then
            ElseIf i = 1 Then
            Else
                FilterControlToolStripMenuItem.DropDownItems.RemoveAt(2)
            End If
        Next

        hr = FilterGraph.EnumFilters(EnumFilters)
        DsError.ThrowExceptionForHR(hr)

        Dim Fetched As IntPtr = Marshal.AllocCoTaskMem(4)
        Try

            Dim BaseFilter As IBaseFilter() = New IBaseFilter(0) {}
            While EnumFilters.Next(BaseFilter.Length, BaseFilter, Fetched) = 0

                Dim _FilterInfo As FilterInfo = Nothing
                hr = BaseFilter(0).QueryFilterInfo(_FilterInfo)
                DsError.ThrowExceptionForHR(hr)

                '////메뉴에 필터들 추가

                Dim SpecifyPropertyPages As ISpecifyPropertyPages = TryCast(BaseFilter(0), ISpecifyPropertyPages)

                If InStr(1, FilePathV, _FilterInfo.achName) <> 0 Then '소스 파일
                    FilePathCutV = _FilterInfo.achName 'achName이 짤려서 나오므로, FilePathCutV 에 짤린 부분기록..
                    FilterControlToolStripMenuItem.DropDownItems.Add(FILENAME_Str, Nothing, AddressOf ShowProperty)
                Else
                    FilterControlToolStripMenuItem.DropDownItems.Add(_FilterInfo.achName, Nothing, AddressOf ShowProperty)
                End If

                If SpecifyPropertyPages Is Nothing Then
                    FilterControlToolStripMenuItem.DropDownItems(FilterControlToolStripMenuItem.DropDownItems.Count - 1).Enabled = False
                End If

                '////

                If _FilterInfo.pGraph IsNot Nothing Then
                    Marshal.ReleaseComObject(_FilterInfo.pGraph)
                    Marshal.ReleaseComObject(BaseFilter(0))
                End If

            End While

        Finally

            Marshal.FreeCoTaskMem(Fetched)
            Marshal.ReleaseComObject(EnumFilters)

        End Try

        Return FilterArray

    End Function

    Private Sub ShowProperty(ByVal Sender As Object, ByVal e As EventArgs)

        If FilterGraph Is Nothing Then
            Exit Sub
        End If

        '/////////////

        Dim SelectedMenuName As String
        SelectedMenuName = Sender.ToString

        If SelectedMenuName = FILENAME_Str Then
            SelectedMenuName = FilePathCutV
        End If

        '/////////////

        Dim FilterArray As New List(Of IBaseFilter)()
        Dim hr As Integer = 0
        Dim EnumFilters As IEnumFilters = Nothing

        hr = FilterGraph.EnumFilters(EnumFilters)
        DsError.ThrowExceptionForHR(hr)

        Dim Fetched As IntPtr = Marshal.AllocCoTaskMem(4)
        Try

            Dim BaseFilter As IBaseFilter() = New IBaseFilter(0) {}
            While EnumFilters.Next(BaseFilter.Length, BaseFilter, Fetched) = 0

                Dim _FilterInfo As FilterInfo = Nothing
                hr = BaseFilter(0).QueryFilterInfo(_FilterInfo)
                DsError.ThrowExceptionForHR(hr)

                If _FilterInfo.achName = SelectedMenuName Then
                    Dim _PropertyPageForm As New PropertyPageFrm(SelectedMenuName, BaseFilter(0))
                    _PropertyPageForm.ShowDialog(Me)
                    _PropertyPageForm.Dispose()
                    _PropertyPageForm = Nothing
                End If

                If _FilterInfo.pGraph IsNot Nothing Then
                    Marshal.ReleaseComObject(_FilterInfo.pGraph)
                    Marshal.ReleaseComObject(BaseFilter(0))
                End If

            End While

        Finally

            Marshal.FreeCoTaskMem(Fetched)
            Marshal.ReleaseComObject(EnumFilters)

        End Try

    End Sub

    Private Sub StartEnhancedVideoRenderer(ByVal FilterGraph As IFilterGraph)

        If FilterGraph Is Nothing Then
            Exit Sub
        End If

        Dim EVRFilter As Object = Nothing
        Dim FilterArray As New List(Of IBaseFilter)()
        Dim hr As Integer = 0
        Dim EnumFilters As IEnumFilters = Nothing

        hr = FilterGraph.EnumFilters(EnumFilters)
        DsError.ThrowExceptionForHR(hr)

        Dim Fetched As IntPtr = Marshal.AllocCoTaskMem(4)
        Try

            Dim BaseFilter As IBaseFilter() = New IBaseFilter(0) {}
            While EnumFilters.Next(BaseFilter.Length, BaseFilter, Fetched) = 0

                EVRFilter = BaseFilter(0)
                Marshal.ReleaseComObject(BaseFilter(0))

            End While

        Finally

            Marshal.FreeCoTaskMem(Fetched)
            Marshal.ReleaseComObject(EnumFilters)

        End Try

        '///////////////

        Dim MFGetService As IMFGetService = TryCast(EVRFilter, IMFGetService)
        If MFGetService IsNot Nothing Then

            Try
                Dim _Object As Object = Nothing
                MFGetService.GetService(MediaFoundation.MFServices.MR_VIDEO_RENDER_SERVICE, GetType(IMFVideoDisplayControl).GUID, _Object)
                MFVideoDisplayControl = TryCast(_Object, IMFVideoDisplayControl)

                If MFVideoDisplayControl IsNot Nothing Then
                    MFVideoDisplayControl.SetVideoWindow(DMVideoWindow.Handle)
                    MFVideoDisplayControl.SetAspectRatioMode(MFVideoAspectRatioMode.None)

                    Dim _MRECT As New Misc.RECT
                    Dim _MFVNRECT As New MFVideoNormalizedRect()

                    _MFVNRECT.left = 0
                    _MFVNRECT.right = 1
                    _MFVNRECT.top = 0
                    _MFVNRECT.bottom = 1
                    _MRECT.left = 0
                    _MRECT.top = 0
                    _MRECT.right = DMVideoWindow.Width
                    _MRECT.bottom = DMVideoWindow.Height

                    MFVideoDisplayControl.SetVideoPosition(_MFVNRECT, _MRECT)
                End If
            Catch ex As Exception
            End Try
        End If

    End Sub

    Public Function MFilter(ByVal _Guid As Guid, ByVal Name As String) As IBaseFilter

        On Error Resume Next

        Dim _Object As Object = Nothing
        Dim __Guid As Guid = GetType(IBaseFilter).GUID
        For Each device As DsDevice In DsDevice.GetDevicesOfCat(_Guid)
            If device.Name.CompareTo(Name) = 0 Then
                device.Mon.BindToObject(Nothing, Nothing, __Guid, _Object)
                Exit For
            End If
        Next

        Return DirectCast(_Object, IBaseFilter)

    End Function

#End Region

    Private Sub PreviewFrm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        '설정
        My.Settings.VOLUME_Int = VOLUME_Int
        My.Settings.MUTE_Bool = MUTE_Bool
        My.Settings.DefaultRendererToolStripMenuItem = DefaultRendererToolStripMenuItem.Checked
        My.Settings.OverlayMixerToolStripMenuItem = OverlayMixerToolStripMenuItem.Checked
        My.Settings.VideoMixingRenderer7WindowlessToolStripMenuItem = VideoMixingRenderer7WindowlessToolStripMenuItem.Checked
        My.Settings.VideoMixingRenderer9WindowedToolStripMenuItem = VideoMixingRenderer9WindowedToolStripMenuItem.Checked
        My.Settings.VideoMixingRenderer9WindowlessToolStripMenuItem = VideoMixingRenderer9WindowlessToolStripMenuItem.Checked
        My.Settings.EnhancedVideoRendererToolStripMenuItem = EnhancedVideoRendererToolStripMenuItem.Checked
        My.Settings.HaaliVideoRendererToolStripMenuItem = HaaliVideoRendererToolStripMenuItem.Checked
        My.Settings.madVRToolStripMenuItem = madVRToolStripMenuItem.Checked
        My.Settings.Save()

        '닫기
        CLOSE_DSHOW()

    End Sub

    Private Sub Backward10Sub()

        Try
            If MediaSeeking IsNot Nothing Then
                If GCP_LONG <= 100000000 Then
                    MediaSeeking.SetPositions(0, IMSdwCurrentFlags, IMSpStop, IMSdwStopFlags)
                Else
                    MediaSeeking.SetPositions(GCP_LONG - 100000000, IMSdwCurrentFlags, IMSpStop, IMSdwStopFlags)
                End If
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub Forward10Sub()

        Try
            If MediaSeeking IsNot Nothing Then
                MediaSeeking.SetPositions(GCP_LONG + 100000000, IMSdwCurrentFlags, IMSpStop, IMSdwStopFlags)
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub Backward60Sub()

        Try
            If MediaSeeking IsNot Nothing Then
                If GCP_LONG <= 600000000 Then
                    MediaSeeking.SetPositions(0, IMSdwCurrentFlags, IMSpStop, IMSdwStopFlags)
                Else
                    MediaSeeking.SetPositions(GCP_LONG - 600000000, IMSdwCurrentFlags, IMSpStop, IMSdwStopFlags)
                End If
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub Forward60Sub()

        Try
            If MediaSeeking IsNot Nothing Then
                MediaSeeking.SetPositions(GCP_LONG + 600000000, IMSdwCurrentFlags, IMSpStop, IMSdwStopFlags)
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub Backward300Sub()

        Try
            If MediaSeeking IsNot Nothing Then
                If GCP_LONG <= 3000000000 Then
                    MediaSeeking.SetPositions(0, IMSdwCurrentFlags, IMSpStop, IMSdwStopFlags)
                Else
                    MediaSeeking.SetPositions(GCP_LONG - 3000000000, IMSdwCurrentFlags, IMSpStop, IMSdwStopFlags)
                End If
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub Forward300Sub()

        Try
            If MediaSeeking IsNot Nothing Then
                MediaSeeking.SetPositions(GCP_LONG + 3000000000, IMSdwCurrentFlags, IMSpStop, IMSdwStopFlags)
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub FrameStepSub()

        Try
            If VideoFrameStep IsNot Nothing Then
                VideoFrameStep.Step(1, Nothing)
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub PreviewFrm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If LoadingB = True Then
            e.Cancel = True
            Exit Sub
        Else
            e.Cancel = False
        End If

    End Sub

    Private Sub PreviewFrm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If e.Control = False And e.Shift = False And e.KeyCode = 37 Then    'Left        10 Backward
            Backward10Sub()
        End If

        If e.Control = False And e.Shift = False And e.KeyCode = 39 Then    'Right       10 Forward
            Forward10Sub()
        End If

        If e.Control = True And e.Shift = False And e.KeyCode = 37 Then    'Ctrl+Left        60 Backward
            Backward60Sub()
        End If

        If e.Control = True And e.Shift = False And e.KeyCode = 39 Then    'Ctrl+Right       60 Forward
            Forward60Sub()
        End If

        If e.Control = False And e.Shift = True And e.KeyCode = 37 Then    'Shift+Left        300 Backward
            Backward300Sub()
        End If

        If e.Control = False And e.Shift = True And e.KeyCode = 39 Then    'Shift+Right       300 Forward
            Forward300Sub()
        End If

        If e.KeyCode = 190 Then                                       '.          FrameStep
            FrameStepSub()
        End If

        If e.Control = False And e.KeyCode = 32 Then            'Space          Play/Pause
            PlayPauseSub()
        End If

        If e.KeyCode = 38 Then         'Up      Volume Up
            VolumeUpSub()
        End If

        If e.KeyCode = 40 Then         'Down    Volume Down
            VolumeDownSub()
        End If

        If e.KeyCode = 77 Then                                       'M          Mute
            If MUTE_Bool = True Then
                MuteSub(False)
            Else
                MuteSub(True)
            End If
        End If

        If e.KeyCode = 219 Then                                       '[          Slow Speed
            SlowSpeedSub()
        End If

        If e.KeyCode = 221 Then                                       ']          Fast Speed
            FastSpeedSub()
        End If

        If e.KeyCode = 81 Then                                       'q          Quit
            Close()
        End If

    End Sub

    Private Sub SlowSpeedSub()

        Dim rate As Double

        Try
            If MediaSeeking IsNot Nothing Then
                MediaSeeking.GetRate(rate)
                MediaSeeking.SetRate(rate - 0.1)
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub FastSpeedSub()

        Dim rate As Double

        Try
            If MediaSeeking IsNot Nothing Then
                MediaSeeking.GetRate(rate)
                MediaSeeking.SetRate(rate + 0.1)
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub VolumeDownSub()

        Try
            If BasicAudio IsNot Nothing Then
                VOLUME_Int = VOLUME_Int - 5
                If VOLUME_Int < 0 Then
                    VOLUME_Int = 0
                End If
                If VOLUME_Int > 100 Then
                    VOLUME_Int = 100
                End If
                Dim vol As Double
                Dim volT As Integer
                vol = VOLUME_Int / 100
                vol *= 1 - Math.Pow(10.0, -5.0)
                vol += Math.Pow(10.0, -5.0)
                vol = 20 * Math.Log10(vol)
                volT = (100 * vol)
                BasicAudio.put_Volume(volT)
                MuteSub(False) '음소거해제
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub VolumeUpSub()

        Try
            If BasicAudio IsNot Nothing Then
                VOLUME_Int = VOLUME_Int + 5
                If VOLUME_Int < 0 Then
                    VOLUME_Int = 0
                End If
                If VOLUME_Int > 100 Then
                    VOLUME_Int = 100
                End If
                Dim vol As Double
                Dim volT As Integer
                vol = VOLUME_Int / 100
                vol *= 1 - Math.Pow(10.0, -5.0)
                vol += Math.Pow(10.0, -5.0)
                vol = 20 * Math.Log10(vol)
                volT = (100 * vol)
                BasicAudio.put_Volume(volT)
                MuteSub(False) '음소거해제
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub MuteSub(ByVal MuteB As Boolean)

        Try
            If BasicAudio IsNot Nothing Then
                If MuteB = False Then
                    MUTE_Bool = False
                    Dim vol As Double
                    Dim volT As Integer
                    vol = VOLUME_Int / 100
                    vol *= 1 - Math.Pow(10.0, -5.0)
                    vol += Math.Pow(10.0, -5.0)
                    vol = 20 * Math.Log10(vol)
                    volT = (100 * vol)
                    BasicAudio.put_Volume(volT)
                ElseIf MuteB = True Then
                    MUTE_Bool = True
                    BasicAudio.put_Volume(-10000)
                End If
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub PlayPauseSub()
        On Error Resume Next

        '재생상태 // 2 = PLAY, 1 = PAUSE, 0 = STOP
        Dim pvla As Integer
        MediaControl.GetState(Nothing, pvla)

        '열려있고 정지중에 현재시간과 전체시간이 같으면 0초 지점으로
        If pvla = 0 Then
            If GD_LONG <> "" Then
                If GD_LONG <> 0 Then
                    If GCP_LONG = GD_LONG Then
                        MediaSeeking.SetPositions(0, IMSdwCurrentFlags, IMSpStop, IMSdwStopFlags)
                    End If
                End If
            End If
        End If

        If pvla = 2 Then
            MediaControl.Pause()
        Else
            MediaControl.Run()
        End If

    End Sub

    Private Sub PreviewFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '설정
        VOLUME_Int = My.Settings.VOLUME_Int
        MUTE_Bool = My.Settings.MUTE_Bool
        DefaultRendererToolStripMenuItem.Checked = My.Settings.DefaultRendererToolStripMenuItem
        OverlayMixerToolStripMenuItem.Checked = My.Settings.OverlayMixerToolStripMenuItem
        VideoMixingRenderer7WindowlessToolStripMenuItem.Checked = My.Settings.VideoMixingRenderer7WindowlessToolStripMenuItem
        VideoMixingRenderer9WindowedToolStripMenuItem.Checked = My.Settings.VideoMixingRenderer9WindowedToolStripMenuItem
        VideoMixingRenderer9WindowlessToolStripMenuItem.Checked = My.Settings.VideoMixingRenderer9WindowlessToolStripMenuItem
        EnhancedVideoRendererToolStripMenuItem.Checked = My.Settings.EnhancedVideoRendererToolStripMenuItem
        HaaliVideoRendererToolStripMenuItem.Checked = My.Settings.HaaliVideoRendererToolStripMenuItem
        madVRToolStripMenuItem.Checked = My.Settings.madVRToolStripMenuItem

        '어플리케이션 설정
        If Environ("PROCESSOR_ARCHITECTURE") = "AMD64" Then
            Me.Text = "Kirara Player v" & _
            My.Application.Info.Version.Major & "." & _
            My.Application.Info.Version.Minor & "." & _
            My.Application.Info.Version.Revision & " x64"
        Else
            Me.Text = "Kirara Player v" & _
            My.Application.Info.Version.Major & "." & _
            My.Application.Info.Version.Minor & "." & _
            My.Application.Info.Version.Revision
        End If

        Me.Show()

        '//명령 ( 맨 마지막 부분에만 삽입 ㅇㅅㅇ )
        Dim CommandV As String = ""
        If Command() <> "" Then
            CommandV = Command()
            CommandV = Replace(CommandV, Chr(34) & " ", "")
            CommandV = Replace(CommandV, Chr(34), "")
        Else
            OpenFileDialog1.FileName = ""
            OpenFileDialog1.Filter = "Supported Files|*.avs;*.3g2;*.3gp;*.asf;*.avi;*.flv;*.k3g;*.m2t;*.m2ts;*.mkv;*.mov;*.mpg;*.mpeg;*.mp4;*.mts;*.rm;*.skm;*.wmv;*.tp;*.trp;*.ts;*.tta;*.m2ts;*.m2v;*.mpv;*.pva;*.rmvb;*.vob;*.vro;*.aac;*.ac3;*.dts;*.flac;*.m4a;*.mp2;*.mp3;*.mp4;*.ogg;*.ra;*.ram;*.wav;*.webm;*.wma;*.wv;|" & _
                                     "Video Files|*.avs;*.3g2;*.3gp;*.asf;*.avi;*.flv;*.k3g;*.m2t;*.m2ts;*.mkv;*.mov;*.mpg;*.mpeg;*.mp4;*.mts;*.rm;*.skm;*.wmv;*.tp;*.trp;*.ts;*.m2ts;*.m2v;*.mpv;*.pva;*.rmvb;*.vob;*.vro;*.webm;|" & _
                                     "Audio Files|*.avs;*.aac;*.ac3;*.dts;*.flac;*.m4a;*.mp2;*.mp3;*.mp4;*.ogg;*.ra;*.ram;*.tta;*.wav;*.wma;*.wv;|" & _
                                     "All Files(*.*)|*.*"
            OpenFileDialog1.ShowDialog(Me)
            If OpenFileDialog1.FileName = "" Then
                Exit Sub
            End If
            CommandV = OpenFileDialog1.FileName
        End If

        Me.Text = "Loading..."

        FILENAME_Str = My.Computer.FileSystem.GetFileInfo(CommandV).Name
        FilePathV = CommandV

        OPEN_DSHOW(FilePathV)
        Try
            If MediaControl IsNot Nothing Then
                MediaControl.Run()
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub OPEN_DSHOW(ByVal CommandV As String)

        LoadingB = True

        Dim hr As Integer
        Dim Com_Type As Type = Nothing
        Dim Com_Object As Object = Nothing

        Try

            Com_Type = Type.GetTypeFromCLSID(FilterGraph_Guid)
            Com_Object = Activator.CreateInstance(Com_Type)
            GraphBuilder = TryCast(Com_Object, IGraphBuilder)
            Com_Object = Nothing

            '오디오인지 체크.. 오디오면은 렌더러랑 자막 부분 스킵
            If LCase(Strings.Right(FilePathV, 4)) = ".aac" OrElse LCase(Strings.Right(FilePathV, 4)) = ".ac3" OrElse LCase(Strings.Right(FilePathV, 4)) = ".dts" _
            Or LCase(Strings.Right(FilePathV, 5)) = ".flac" OrElse LCase(Strings.Right(FilePathV, 4)) = ".m4a" OrElse LCase(Strings.Right(FilePathV, 4)) = ".mid" _
            Or LCase(Strings.Right(FilePathV, 5)) = ".midi" OrElse LCase(Strings.Right(FilePathV, 4)) = ".mp2" OrElse LCase(Strings.Right(FilePathV, 4)) = ".mp3" _
            Or LCase(Strings.Right(FilePathV, 4)) = ".ogg" OrElse LCase(Strings.Right(FilePathV, 3)) = ".ra" OrElse LCase(Strings.Right(FilePathV, 4)) = ".ram" _
            Or LCase(Strings.Right(FilePathV, 4)) = ".wav" OrElse LCase(Strings.Right(FilePathV, 4)) = ".wma" OrElse LCase(Strings.Right(FilePathV, 3)) = ".wv" Then
                GoTo 오디오만
            End If

            If OverlayMixerToolStripMenuItem.Checked = True Then '//Overlay Mixer//

                BaseFilter = DirectCast(New OverlayMixer(), IBaseFilter)
                Dim AFFClsidOM As New Guid("CD8743A1-3736-11D0-9E69-00C04FD7C15B")
                Dim OM_Pin As IPin = DsFindPin.ByDirection(BaseFilter, PinDirection.Input, Nothing)
                MixerPinConfig = DirectCast(OM_Pin, IMixerPinConfig)
                MixerPinConfig.SetAspectRatioMode(AspectRatioMode.Stretched)
                Name_BaseFilter_AddFilter(GraphBuilder, AFFClsidOM, "Overlay Mixer", BaseFilter)

            ElseIf VideoMixingRenderer7WindowlessToolStripMenuItem.Checked = True Then '//Video Mixing Renderer 7 Windowless//

                BaseFilter = DirectCast(New VideoMixingRenderer(), IBaseFilter)
                VMRFilterConfig = DirectCast(BaseFilter, IVMRFilterConfig)
                hr = VMRFilterConfig.SetNumberOfStreams(1)
                DsError.ThrowExceptionForHR(hr)
                hr = VMRFilterConfig.SetRenderingMode(VMRMode.Windowless)
                DsError.ThrowExceptionForHR(hr)
                VMRWindowlessControl = DirectCast(BaseFilter, IVMRWindowlessControl)
                hr = VMRWindowlessControl.SetVideoClippingWindow(DMVideoWindow.Handle)
                DsError.ThrowExceptionForHR(hr)
                hr = VMRWindowlessControl.SetAspectRatioMode(VMRAspectRatioMode.None)
                DsError.ThrowExceptionForHR(hr)
                hr = VMRWindowlessControl.SetVideoPosition(Nothing, DMVideoWindow.ClientRectangle)
                DsError.ThrowExceptionForHR(hr)
                Dim AFFClsidVMR7Windowless As New Guid("B87BEB7B-8D29-423F-AE4D-6582C10175AC")
                Name_BaseFilter_AddFilter(GraphBuilder, AFFClsidVMR7Windowless, "Video Mixing Renderer 7 (Windowless)", BaseFilter)

            ElseIf VideoMixingRenderer9WindowedToolStripMenuItem.Checked = True Then '//Video Mixing Renderer 9 Windowed//

                BaseFilter = DirectCast(New VideoMixingRenderer9(), IBaseFilter)
                VMRFilterConfig9 = DirectCast(BaseFilter, IVMRFilterConfig9)
                hr = VMRFilterConfig9.SetNumberOfStreams(1)
                DsError.ThrowExceptionForHR(hr)
                hr = VMRFilterConfig9.SetRenderingMode(VMR9Mode.Windowed)
                DsError.ThrowExceptionForHR(hr)
                VMRAspectRatioControl9 = DirectCast(BaseFilter, IVMRAspectRatioControl9)
                hr = VMRAspectRatioControl9.SetAspectRatioMode(VMR9AspectRatioMode.None)
                DsError.ThrowExceptionForHR(hr)
                Dim AFFClsidVMR9Windowed As New Guid("51B4ABF3-748F-4E3B-A276-C828330E926A")
                Name_BaseFilter_AddFilter(GraphBuilder, AFFClsidVMR9Windowed, "Video Mixing Renderer 9 (Windowed)", BaseFilter)

            ElseIf VideoMixingRenderer9WindowlessToolStripMenuItem.Checked = True Then '//Video Mixing Renderer 9 Windowless//

                BaseFilter = DirectCast(New VideoMixingRenderer9(), IBaseFilter)
                VMRFilterConfig9 = DirectCast(BaseFilter, IVMRFilterConfig9)
                hr = VMRFilterConfig9.SetNumberOfStreams(1)
                DsError.ThrowExceptionForHR(hr)
                hr = VMRFilterConfig9.SetRenderingMode(VMR9Mode.Windowless)
                DsError.ThrowExceptionForHR(hr)
                VMRWindowlessControl9 = DirectCast(BaseFilter, IVMRWindowlessControl9)
                hr = VMRWindowlessControl9.SetVideoClippingWindow(DMVideoWindow.Handle)
                DsError.ThrowExceptionForHR(hr)
                hr = VMRWindowlessControl9.SetAspectRatioMode(VMR9AspectRatioMode.None)
                DsError.ThrowExceptionForHR(hr)
                hr = VMRWindowlessControl9.SetVideoPosition(Nothing, DMVideoWindow.ClientRectangle)
                DsError.ThrowExceptionForHR(hr)
                Dim AFFClsidVMR9Windowless As New Guid("51B4ABF3-748F-4E3B-A276-C828330E926A")
                Name_BaseFilter_AddFilter(GraphBuilder, AFFClsidVMR9Windowless, "Video Mixing Renderer 9 (Windowless)", BaseFilter)

            ElseIf EnhancedVideoRendererToolStripMenuItem.Checked = True Then '//Enhanced Video Renderer//

                Dim AFFClsidEVR As New Guid("FA10746C-9B63-4B6C-BC49-FC300EA5F256")
                Name_AddFilter(GraphBuilder, AFFClsidEVR, "Enhanced Video Renderer")
                StartEnhancedVideoRenderer(GraphBuilder)

            ElseIf HaaliVideoRendererToolStripMenuItem.Checked = True Then '//Haali Video Renderer//

                Dim AFFClsidHVR As New Guid("760A8F35-97E7-479D-AAF5-DA9EFF95D751")
                Name_AddFilter(GraphBuilder, AFFClsidHVR, "Haali Video Renderer")

            ElseIf madVRToolStripMenuItem.Checked = True Then '//madVR//

                Dim AFFClsidHVR As New Guid("E1A8B82A-32CE-4B0D-BE0D-AA68C772E423")
                Name_AddFilter(GraphBuilder, AFFClsidHVR, "madVR")

            End If

오디오만:

            '기본 오디오 렌더러 추가
            Dim AFFClsidDDD As New Guid("79376820-07D0-11CF-A24D-0020AFD79767")
            Name_AddFilter(GraphBuilder, AFFClsidDDD, "Default DirectSound Device")

            '그래프 빌더 생성 GraphBuilder.RenderFile(CommandV, Nothing)
            GraphBuilder.AddSourceFilter(CommandV, Nothing, BaseFilter)

            GraphBuilder.Render(DsFindPin.ByDirection(BaseFilter, PinDirection.Output, 0))
            GraphBuilder.Render(DsFindPin.ByDirection(BaseFilter, PinDirection.Output, 1))

            FilterGraph = DirectCast(GraphBuilder, IFilterGraph)
            GetFilter(FilterGraph)

            MediaControl = DirectCast(GraphBuilder, IMediaControl)
            MediaEventEx = DirectCast(GraphBuilder, IMediaEventEx)
            MediaSeeking = DirectCast(GraphBuilder, IMediaSeeking)
            MediaPosition = DirectCast(GraphBuilder, IMediaPosition)
            VideoWindow = DirectCast(GraphBuilder, IVideoWindow)
            BasicVideo = DirectCast(GraphBuilder, IBasicVideo)
            BasicVideo2 = DirectCast(GraphBuilder, IBasicVideo2)
            BasicAudio = DirectCast(GraphBuilder, IBasicAudio)
            VideoFrameStep = DirectCast(MediaControl, IVideoFrameStep)

            '
            If BasicVideo IsNot Nothing Then
                BasicVideo.GetVideoSize(VideoWidth, VideoHeight) 'Video Renderer, Overlay Mixer, VMR9 Windowed, Haali Video Renderer, madVR
            End If

            If VideoWidth = 0 And VideoHeight = 0 Then

                If VMRWindowlessControl IsNot Nothing Then 'VMR 7 Windowless
                    VMRWindowlessControl.GetNativeVideoSize(VideoWidth, VideoHeight, Nothing, Nothing)
                End If

                If VMRWindowlessControl9 IsNot Nothing Then 'VMR 9 Windowless
                    VMRWindowlessControl9.GetNativeVideoSize(VideoWidth, VideoHeight, Nothing, Nothing)
                End If

                If MFVideoDisplayControl IsNot Nothing Then 'EVR
                    Dim eg As New Misc.SIZE
                    MFVideoDisplayControl.GetNativeVideoSize(eg, Nothing)
                    VideoWidth = eg.cx
                    VideoHeight = eg.cy
                End If

            End If

            Dim xp, yp As Integer
            xp = Me.Width - Me.ClientRectangle.Width
            yp = Me.Height - Me.ClientRectangle.Height

            '기본사이즈 설정
            If VideoWidth = 0 And VideoHeight = 0 Then
                Me.Width = 640 + xp
                Me.Height = 360 + yp
            Else
                Me.Width = VideoWidth + xp
                Me.Height = VideoHeight + yp
            End If

            MediaEventEx.SetNotifyWindow(DMVideoWindow.Handle, WM_GRAPHNOTIFY, IntPtr.Zero)

            VideoWindow.put_Owner(DMVideoWindow.Handle)
            VideoWindow.put_MessageDrain(DMVideoWindow.Handle)
            VideoWindow.put_WindowStyle(WS_CHILD Or WS_CLIPSIBLINGS)
            VideoWindow.SetWindowPosition(0, 0, DMVideoWindow.Width, DMVideoWindow.Height)

            '
            If MUTE_Bool = False Then
                Dim vol As Double
                Dim volT As Integer
                vol = VOLUME_Int / 100
                vol *= 1 - Math.Pow(10.0, -5.0)
                vol += Math.Pow(10.0, -5.0)
                vol = 20 * Math.Log10(vol)
                volT = (100 * vol)
                BasicAudio.put_Volume(volT)
            ElseIf MUTE_Bool = True Then
                BasicAudio.put_Volume(-10000)
            End If
            BasicAudio.put_Balance(0)

            Timer1.Enabled = True

        Catch ex As Exception
            MsgBox(ex.Message)
            CLOSE_DSHOW()
            Exit Sub
        Finally
            If Com_Object IsNot Nothing Then
                Marshal.ReleaseComObject(Com_Object)
            End If
            Com_Object = Nothing
            LoadingB = False
        End Try

    End Sub

    Private Sub CLOSE_DSHOW()

        '바로 닫기
        If FilePathV = "" Then
            Exit Sub
        End If


        VideoWidth = 0
        VideoHeight = 0
        FILENAME_Str = ""
        FilePathV = ""
        FilePathCutV = ""

        FilterControlToolStripMenuItem.DropDownItems.Clear()

        Timer1.Enabled = False

        '정지
        Try
            If MediaControl IsNot Nothing Then
                MediaControl.Stop()
            End If
        Catch ex As Exception
        End Try

        '============================================================

        Try
            If MediaControl IsNot Nothing Then
                MediaControl.StopWhenReady()
            End If
        Catch ex As Exception
        End Try

        Try
            If MediaEventEx IsNot Nothing Then
                MediaEventEx.SetNotifyWindow(IntPtr.Zero, WM_GRAPHNOTIFY, IntPtr.Zero)
            End If
        Catch ex As Exception
        End Try

        Try
            If VideoWindow IsNot Nothing Then
                VideoWindow.put_Visible(0)
            End If
        Catch ex As Exception
        End Try

        '============================================================

        Try
            If GraphBuilder IsNot Nothing Then
                Marshal.ReleaseComObject(GraphBuilder)
                GraphBuilder = Nothing
            End If
        Catch ex As Exception
        End Try

        Try
            If BaseFilter IsNot Nothing Then
                Marshal.ReleaseComObject(BaseFilter)
                BaseFilter = Nothing
            End If
        Catch ex As Exception
        End Try

        '//

        Try
            If MFVideoDisplayControl IsNot Nothing Then
                Marshal.ReleaseComObject(MFVideoDisplayControl)
                MFVideoDisplayControl = Nothing
            End If
        Catch ex As Exception
        End Try

        Try
            If VMRWindowlessControl9 IsNot Nothing Then
                Marshal.ReleaseComObject(VMRWindowlessControl9)
                VMRWindowlessControl9 = Nothing
            End If
        Catch ex As Exception
        End Try

        Try
            If VMRFilterConfig9 IsNot Nothing Then
                Marshal.ReleaseComObject(VMRFilterConfig9)
                VMRFilterConfig9 = Nothing
            End If
        Catch ex As Exception
        End Try

        Try
            If VMRAspectRatioControl9 IsNot Nothing Then
                Marshal.ReleaseComObject(VMRAspectRatioControl9)
                VMRAspectRatioControl9 = Nothing
            End If
        Catch ex As Exception
        End Try

        Try
            If VMRWindowlessControl IsNot Nothing Then
                Marshal.ReleaseComObject(VMRWindowlessControl)
                VMRWindowlessControl = Nothing
            End If
        Catch ex As Exception
        End Try

        Try
            If VMRFilterConfig IsNot Nothing Then
                Marshal.ReleaseComObject(VMRFilterConfig)
                VMRFilterConfig = Nothing
            End If
        Catch ex As Exception
        End Try

        Try
            If MixerPinConfig IsNot Nothing Then
                Marshal.ReleaseComObject(MixerPinConfig)
                MixerPinConfig = Nothing
            End If
        Catch ex As Exception
        End Try

        '//

        Try
            If FilterGraph IsNot Nothing Then
                Marshal.ReleaseComObject(FilterGraph)
                FilterGraph = Nothing
            End If
        Catch ex As Exception
        End Try

        Try
            If MediaControl IsNot Nothing Then
                Marshal.ReleaseComObject(MediaControl)
                MediaControl = Nothing
            End If
        Catch ex As Exception
        End Try

        Try
            If MediaEventEx IsNot Nothing Then
                Marshal.ReleaseComObject(MediaEventEx)
                MediaEventEx = Nothing
            End If
        Catch ex As Exception
        End Try

        Try
            If MediaSeeking IsNot Nothing Then
                Marshal.ReleaseComObject(MediaSeeking)
                MediaSeeking = Nothing
            End If
        Catch ex As Exception
        End Try

        Try
            If MediaPosition IsNot Nothing Then
                Marshal.ReleaseComObject(MediaPosition)
                MediaPosition = Nothing
            End If
        Catch ex As Exception
        End Try

        Try
            If VideoWindow IsNot Nothing Then
                Marshal.ReleaseComObject(VideoWindow)
                VideoWindow = Nothing
            End If
        Catch ex As Exception
        End Try

        Try
            If BasicVideo IsNot Nothing Then
                Marshal.ReleaseComObject(BasicVideo)
                BasicVideo = Nothing
            End If
        Catch ex As Exception
        End Try

        Try
            If BasicVideo2 IsNot Nothing Then
                Marshal.ReleaseComObject(BasicVideo2)
                BasicVideo2 = Nothing
            End If
        Catch ex As Exception
        End Try

        Try
            If BasicAudio IsNot Nothing Then
                Marshal.ReleaseComObject(BasicAudio)
                BasicAudio = Nothing
            End If
        Catch ex As Exception
        End Try

        Try
            If VideoFrameStep IsNot Nothing Then
                Marshal.ReleaseComObject(VideoFrameStep)
                VideoFrameStep = Nothing
            End If
        Catch ex As Exception
        End Try

        GC.Collect()

        '메모리 정리
        If (Environment.OSVersion.Platform = PlatformID.Win32NT) Then
            SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1)
        End If

        '어플리케이션 설정
        If Environ("PROCESSOR_ARCHITECTURE") = "AMD64" Then
            Me.Text = "Kirara Player v" & _
            My.Application.Info.Version.Major & "." & _
            My.Application.Info.Version.Minor & "." & _
            My.Application.Info.Version.Revision & " x64"
        Else
            Me.Text = "Kirara Player v" & _
            My.Application.Info.Version.Major & "." & _
            My.Application.Info.Version.Minor & "." & _
            My.Application.Info.Version.Revision
        End If

    End Sub
    Private Sub PreviewFrm_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseWheel
        If e.Delta < 0 Then
            Me.VolumeDownSub()
        ElseIf e.Delta > 0 Then
            Me.VolumeUpSub()
        End If
    End Sub

    Private Sub PreviewFrm_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        If VideoWindow Is Nothing Then
            Exit Sub
        End If

        Try
            If HaaliVideoRendererToolStripMenuItem.Checked = True Then '리사이즈: Haali Video Renderer
                BasicVideo2.SetDestinationPosition(0, 0, DMVideoWindow.Width, DMVideoWindow.Height)
                VideoWindow.SetWindowPosition(0, 0, DMVideoWindow.Width, DMVideoWindow.Height)
            ElseIf madVRToolStripMenuItem.Checked = True Then '리사이즈: madVR
                BasicVideo2.SetDestinationPosition(0, 0, DMVideoWindow.Width, DMVideoWindow.Height)
                VideoWindow.SetWindowPosition(0, 0, DMVideoWindow.Width, DMVideoWindow.Height)
            ElseIf MFVideoDisplayControl IsNot Nothing Then '라시아즈: EVR
                Dim _MRECT As New Misc.RECT()
                Dim _MFVNRECT As New MFVideoNormalizedRect()
                _MFVNRECT.left = 0
                _MFVNRECT.right = 1
                _MFVNRECT.top = 0
                _MFVNRECT.bottom = 1
                _MRECT.left = 0
                _MRECT.top = 0
                _MRECT.right = DMVideoWindow.Width
                _MRECT.bottom = DMVideoWindow.Height
                MFVideoDisplayControl.SetVideoPosition(_MFVNRECT, _MRECT)
            ElseIf VMRWindowlessControl9 IsNot Nothing Then '리사이즈: VMR9 Windowless
                VMRWindowlessControl9.SetVideoPosition(Nothing, DsRect.FromRectangle(DMVideoWindow.ClientRectangle))
            ElseIf VMRWindowlessControl IsNot Nothing Then '리사이즈: VMR7 Windowless
                VMRWindowlessControl.SetVideoPosition(Nothing, DsRect.FromRectangle(DMVideoWindow.ClientRectangle))
            Else '리사이즈 그외
                VideoWindow.SetWindowPosition(0, 0, DMVideoWindow.Width, DMVideoWindow.Height)
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Dim MuteStr As String
        If MUTE_Bool = True Then
            MuteStr = " - MUTE"
        Else
            MuteStr = ""
        End If

        Dim rate As Double
        Dim ratestr As String = ""
        Try
            MediaSeeking.GetRate(rate)
            If rate = 1 Then
                ratestr = ""
            Else
                ratestr = " " & rate & "x"
            End If
            MediaSeeking.GetCurrentPosition(GCP_LONG)
            MediaSeeking.GetDuration(GD_LONG)
        Catch ex As Exception
        End Try
        Me.Text = FILENAME_Str & " - " & TIME_TO_HMSMSTIME(GCP_LONG / 10000000, True) & " / " & TIME_TO_HMSMSTIME(GD_LONG / 10000000, True) & "(" & Format(GCP_LONG / GD_LONG, "0.0%") & ") [ Vol : " & VOLUME_Int & " ]" & MuteStr & ratestr

    End Sub

    '----------------------------------------------------------------------------
    ' 함수이름: TIME_TO_HMSMSTIME
    ' 제 작 일: 2008년 / 함수화: 2010 09 26
    ' 설    명: hh:mm:ss:ms 로 변환
    ' 제 작 자: 이기원
    '-----------------------------------------------------------------------------
    Public Shared Function TIME_TO_HMSMSTIME(ByVal TimeV As Double, ByVal PointB As Boolean) As String

        Dim Minute As Single
        Dim Hour As Single
        Dim hmsValue As String = ""

        If TimeV < 0 Then
            If PointB = False Then
                Return "00:00:00"
            Else
                Return "00:00:00.00"
            End If
        End If

        If TimeV < 60 Then
            If TimeV < 0 Then
                hmsValue = "00:" & "00:" & "00.00"
            ElseIf Format(TimeV, "0.00") < 10 Then
                hmsValue = "00:" & "00:" & "0" & Format(TimeV, "0.00")
            Else
                hmsValue = "00:" & "00:" & Format(TimeV, "0.00")
            End If
        End If

        If TimeV > 59 Then
            Minute = TimeV / 60
            If Int(TimeV - "60" * Split(Minute, ".")(0)) < 10 Then
                If Split(Minute, ".")(0) < 10 Then
                    hmsValue = "00:" & "0" & Split(Minute, ".")(0) & ":" & "0" & Format(TimeV - "60" * Split(Minute, ".")(0), "0.00")
                Else
                    hmsValue = "00:" & Split(Minute, ".")(0) & ":" & "0" & Format(TimeV - "60" * Split(Minute, ".")(0), "0.00")
                End If
            Else
                If Split(Minute, ".")(0) < 10 Then
                    hmsValue = "00:" & "0" & Split(Minute, ".")(0) & ":" & Format(TimeV - "60" * Split(Minute, ".")(0), "0.00")
                Else
                    hmsValue = "00:" & Split(Minute, ".")(0) & ":" & Format(TimeV - "60" * Split(Minute, ".")(0), "0.00")
                End If
            End If
        End If

        If Split(Minute, ".")(0) > 59 Then
            Hour = Split(Minute, ".")(0) / 60
            If Split(Hour, ".")(0) < 10 Then
                If Int(Minute - "60" * Split(Hour, ".")(0)) < 10 Then
                    If Int(TimeV - "60" * Split(Minute, ".")(0)) < 10 Then
                        hmsValue = "0" & Split(Hour, ".")(0) & ":" & "0" & Int(Minute - "60" * Split(Hour, ".")(0)) & ":" & "0" & Format(TimeV - "60" * Split(Minute, ".")(0), "0.00")
                    Else
                        hmsValue = "0" & Split(Hour, ".")(0) & ":" & "0" & Int(Minute - "60" * Split(Hour, ".")(0)) & ":" & Format(TimeV - "60" * Split(Minute, ".")(0), "0.00")
                    End If
                Else
                    If Int(TimeV - "60" * Split(Minute, ".")(0)) < 10 Then
                        hmsValue = "0" & Split(Hour, ".")(0) & ":" & Int(Minute - "60" * Split(Hour, ".")(0)) & ":" & "0" & Format(TimeV - "60" * Split(Minute, ".")(0), "0.00")
                    Else
                        hmsValue = "0" & Split(Hour, ".")(0) & ":" & Int(Minute - "60" * Split(Hour, ".")(0)) & ":" & Format(TimeV - "60" * Split(Minute, ".")(0), "0.00")
                    End If
                End If

            Else

                If Int(Minute - "60" * Split(Hour, ".")(0)) < 10 Then
                    If Int(TimeV - "60" * Split(Minute, ".")(0)) < 10 Then
                        hmsValue = Split(Hour, ".")(0) & ":" & "0" & Int(Minute - "60" * Split(Hour, ".")(0)) & ":" & "0" & Format(TimeV - "60" * Split(Minute, ".")(0), "0.00")
                    Else
                        hmsValue = Split(Hour, ".")(0) & ":" & "0" & Int(Minute - "60" * Split(Hour, ".")(0)) & ":" & Format(TimeV - "60" * Split(Minute, ".")(0), "0.00")
                    End If
                Else
                    If Int(TimeV - "60" * Split(Minute, ".")(0)) < 10 Then
                        hmsValue = Split(Hour, ".")(0) & ":" & Int(Minute - "60" * Split(Hour, ".")(0)) & ":" & "0" & Format(TimeV - "60" * Split(Minute, ".")(0), "0.00")
                    Else
                        hmsValue = Split(Hour, ".")(0) & ":" & Int(Minute - "60" * Split(Hour, ".")(0)) & ":" & Format(TimeV - "60" * Split(Minute, ".")(0), "0.00")
                    End If
                End If

            End If

        End If

        If PointB = False Then
            Return Split(hmsValue, ".")(0)
        Else
            Return hmsValue
        End If


    End Function

    Private Sub MovePanel_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MovePanel.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click

        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "Supported Files|*.avs;*.3g2;*.3gp;*.asf;*.avi;*.flv;*.k3g;*.m2t;*.m2ts;*.mkv;*.mov;*.mpg;*.mpeg;*.mp4;*.mts;*.rm;*.skm;*.wmv;*.tp;*.trp;*.ts;*.tta;*.m2ts;*.m2v;*.mpv;*.pva;*.rmvb;*.vob;*.vro;*.aac;*.ac3;*.dts;*.flac;*.m4a;*.mp2;*.mp3;*.mp4;*.ogg;*.ra;*.ram;*.wav;*.webm;*.wma;*.wv;|" & _
                                 "Video Files|*.avs;*.3g2;*.3gp;*.asf;*.avi;*.flv;*.k3g;*.m2t;*.m2ts;*.mkv;*.mov;*.mpg;*.mpeg;*.mp4;*.mts;*.rm;*.skm;*.wmv;*.tp;*.trp;*.ts;*.m2ts;*.m2v;*.mpv;*.pva;*.rmvb;*.vob;*.vro;*.webm;|" & _
                                 "Audio Files|*.avs;*.aac;*.ac3;*.dts;*.flac;*.m4a;*.mp2;*.mp3;*.mp4;*.ogg;*.ra;*.ram;*.tta;*.wav;*.wma;*.wv;|" & _
                                 "All Files(*.*)|*.*"
        OpenFileDialog1.ShowDialog(Me)
        If OpenFileDialog1.FileName = "" Then
            Exit Sub
        End If

        Me.Text = "Loading..."

        CLOSE_DSHOW()

        Me.Text = "Loading..."

        FILENAME_Str = My.Computer.FileSystem.GetFileInfo(OpenFileDialog1.FileName).Name
        FilePathV = OpenFileDialog1.FileName

        OPEN_DSHOW(FilePathV)
        Try
            If MediaControl IsNot Nothing Then
                MediaControl.Run()
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutFrm.ShowDialog(Me)
    End Sub

    Private Sub OverlayMixerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OverlayMixerToolStripMenuItem.Click
        DefaultRendererToolStripMenuItem.Checked = False
        OverlayMixerToolStripMenuItem.Checked = True
        VideoMixingRenderer9WindowedToolStripMenuItem.Checked = False
        VideoMixingRenderer7WindowlessToolStripMenuItem.Checked = False
        VideoMixingRenderer9WindowlessToolStripMenuItem.Checked = False
        EnhancedVideoRendererToolStripMenuItem.Checked = False
        HaaliVideoRendererToolStripMenuItem.Checked = False
        madVRToolStripMenuItem.Checked = False

        DMRefresh()
    End Sub

    Private Sub VideoRendererToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefaultRendererToolStripMenuItem.Click
        DefaultRendererToolStripMenuItem.Checked = True
        OverlayMixerToolStripMenuItem.Checked = False
        VideoMixingRenderer9WindowedToolStripMenuItem.Checked = False
        VideoMixingRenderer7WindowlessToolStripMenuItem.Checked = False
        VideoMixingRenderer9WindowlessToolStripMenuItem.Checked = False
        EnhancedVideoRendererToolStripMenuItem.Checked = False
        HaaliVideoRendererToolStripMenuItem.Checked = False
        madVRToolStripMenuItem.Checked = False

        DMRefresh()
    End Sub

    Private Sub VideoMixingRenderer9WindowedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VideoMixingRenderer9WindowedToolStripMenuItem.Click
        DefaultRendererToolStripMenuItem.Checked = False
        OverlayMixerToolStripMenuItem.Checked = False
        VideoMixingRenderer9WindowedToolStripMenuItem.Checked = True
        VideoMixingRenderer7WindowlessToolStripMenuItem.Checked = False
        VideoMixingRenderer9WindowlessToolStripMenuItem.Checked = False
        EnhancedVideoRendererToolStripMenuItem.Checked = False
        HaaliVideoRendererToolStripMenuItem.Checked = False
        madVRToolStripMenuItem.Checked = False

        DMRefresh()
    End Sub

    Private Sub VideoMixingRenderer7WindowlessToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VideoMixingRenderer7WindowlessToolStripMenuItem.Click
        DefaultRendererToolStripMenuItem.Checked = False
        OverlayMixerToolStripMenuItem.Checked = False
        VideoMixingRenderer9WindowedToolStripMenuItem.Checked = False
        VideoMixingRenderer7WindowlessToolStripMenuItem.Checked = True
        VideoMixingRenderer9WindowlessToolStripMenuItem.Checked = False
        EnhancedVideoRendererToolStripMenuItem.Checked = False
        HaaliVideoRendererToolStripMenuItem.Checked = False
        madVRToolStripMenuItem.Checked = False

        DMRefresh()
    End Sub

    Private Sub VideoMixingRenderer9WindowlessToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VideoMixingRenderer9WindowlessToolStripMenuItem.Click
        DefaultRendererToolStripMenuItem.Checked = False
        OverlayMixerToolStripMenuItem.Checked = False
        VideoMixingRenderer9WindowedToolStripMenuItem.Checked = False
        VideoMixingRenderer7WindowlessToolStripMenuItem.Checked = False
        VideoMixingRenderer9WindowlessToolStripMenuItem.Checked = True
        EnhancedVideoRendererToolStripMenuItem.Checked = False
        HaaliVideoRendererToolStripMenuItem.Checked = False
        madVRToolStripMenuItem.Checked = False

        DMRefresh()
    End Sub

    Private Sub EnhancedVideoRendererToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnhancedVideoRendererToolStripMenuItem.Click
        DefaultRendererToolStripMenuItem.Checked = False
        OverlayMixerToolStripMenuItem.Checked = False
        VideoMixingRenderer9WindowedToolStripMenuItem.Checked = False
        VideoMixingRenderer7WindowlessToolStripMenuItem.Checked = False
        VideoMixingRenderer9WindowlessToolStripMenuItem.Checked = False
        EnhancedVideoRendererToolStripMenuItem.Checked = True
        HaaliVideoRendererToolStripMenuItem.Checked = False
        madVRToolStripMenuItem.Checked = False

        DMRefresh()
    End Sub

    Private Sub HaaliVideoRendererToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HaaliVideoRendererToolStripMenuItem.Click
        DefaultRendererToolStripMenuItem.Checked = False
        OverlayMixerToolStripMenuItem.Checked = False
        VideoMixingRenderer9WindowedToolStripMenuItem.Checked = False
        VideoMixingRenderer7WindowlessToolStripMenuItem.Checked = False
        VideoMixingRenderer9WindowlessToolStripMenuItem.Checked = False
        EnhancedVideoRendererToolStripMenuItem.Checked = False
        HaaliVideoRendererToolStripMenuItem.Checked = True
        madVRToolStripMenuItem.Checked = False

        DMRefresh()
    End Sub

    Private Sub madVRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles madVRToolStripMenuItem.Click
        DefaultRendererToolStripMenuItem.Checked = False
        OverlayMixerToolStripMenuItem.Checked = False
        VideoMixingRenderer9WindowedToolStripMenuItem.Checked = False
        VideoMixingRenderer7WindowlessToolStripMenuItem.Checked = False
        VideoMixingRenderer9WindowlessToolStripMenuItem.Checked = False
        EnhancedVideoRendererToolStripMenuItem.Checked = False
        HaaliVideoRendererToolStripMenuItem.Checked = False
        madVRToolStripMenuItem.Checked = True

        DMRefresh()
    End Sub

    Private Sub DMRefresh()

        '바로 닫기
        If FilePathV = "" Then
            Exit Sub
        End If

        Me.Text = "Loading..."

        Dim FPVS As String = FilePathV
        Dim TempGCP_LONG As String = GCP_LONG

        CLOSE_DSHOW()

        Me.Text = "Loading..."

        FILENAME_Str = My.Computer.FileSystem.GetFileInfo(FPVS).Name
        FilePathV = FPVS

        OPEN_DSHOW(FilePathV)
        Try
            If MediaSeeking IsNot Nothing Then
                MediaSeeking.SetPositions(TempGCP_LONG, IMSdwCurrentFlags, IMSpStop, IMSdwStopFlags)
            End If
        Catch ex As Exception
        End Try

        Try
            If MediaControl IsNot Nothing Then
                MediaControl.Run()
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub DMVideoWindow_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles DMVideoWindow.Paint
        Try
            If MFVideoDisplayControl IsNot Nothing Then
                MFVideoDisplayControl.RepaintVideo()
            ElseIf VMRWindowlessControl9 IsNot Nothing Then
                VMRWindowlessControl9.RepaintVideo(DMVideoWindow.Handle, e.Graphics.GetHdc)
            ElseIf VMRWindowlessControl IsNot Nothing Then
                VMRWindowlessControl.RepaintVideo(DMVideoWindow.Handle, e.Graphics.GetHdc)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub CloseToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        CLOSE_DSHOW()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        DMRefresh()
    End Sub

End Class
