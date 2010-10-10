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

Public Class LangCls

    '언어
    'MainFrm
    Public Shared MainWaitStr As String = "대기"
    Public Shared MainDoneStr As String = "완료"
    Public Shared MainErrorStr As String = "오류"
    Public Shared MainStopStr As String = "중지"
    Public Shared MainSkipStr As String = "통과"
    Public Shared MainEncodingStr As String = "인코딩 중"
    '-------------------------------------------------------
    Public Shared MainVideoStr As String = "비디오"
    Public Shared MainAudioStr As String = "오디오"
    Public Shared MainUACV As String = "관리자"
    Public Shared MainSupportedFilesStr As String = "지원하는 파일"
    Public Shared MainVideoFilesStr As String = "비디오 파일"
    Public Shared MainAudioFilesStr As String = "오디오 파일"
    Public Shared MainAllFilesStr As String = "모든 파일"
    Public Shared MainNotCalAVByteC As String = "예상용량을 알 수 없음"
    Public Shared MainExAVByteC As String = "예상용량"
    Public Shared MainOriginAspect As String = "비율을 변경하지 않음"
    Public Shared MainNoKeepAspect As String = "비율을 유지하지 않음"
    Public Shared MainAspectLetterBox As String = "레터박스 붙이기"
    Public Shared MainAspectCrop As String = "잘라내기"
    Public Shared MainOutputAspect As String = "DAR(출력 비율)"
    Public Shared MainOriginalAspect As String = "SAR(원본 비율)"
    Public Shared MainOriginalSamplerate As String = "원본 샘플레이트"
    Public Shared MainchoriginComboBox As String = "원본 그대로 출력"
    Public Shared Mainch10Str As String = "1/0/0 - 1.0 채널"
    Public Shared Mainch20Str As String = "2/0/0 - 2.0 채널"
    Public Shared Mainch51Str As String = "3/0/2+LFE - 5.1 채널"
    Public Shared MaindolbysStr As String = "돌비 서라운드/프로로직"
    Public Shared MaindolbypStr As String = "돌비 프로로직 II"
    Public Shared MainNSABitrateStr As String = "비트레이트 설정 불가"
    Public Shared MainNAmplifyStr As String = "소리증폭 안 함"
    Public Shared MainAmplifyStr As String = "소리증폭"
    Public Shared MainUserStr As String = "사용자 정의"
    Public Shared MainSelectListA As String = "목록을 선택해주세요."
    Public Shared MainAddStr As String = "추가"
    Public Shared MainRefreshStr As String = "새로 고침"
    Public Shared MainOpenPresetFolderStr As String = "프리셋 폴더 열기"
    Public Shared MainSInitializationStr As String = "설정 초기화"
    Public Shared MainSetEncAVSStr As String = "인코딩 설정, AviSynth 설정(avs_settings.xml 스크립트파일 제외)"
    Public Shared MainInitializationQ As String = "초기화 하시겠습니까?"
    Public Shared MainFileNotFound As String = "파일이 없습니다."
    Public Shared MainDirectoryNotFound As String = "저장 폴더가 존재하지 않습니다."
    Public Shared MainFileSame As String = "원본파일과 출력될 파일의 위치 및 파일명이 같습니다."

    'EncodingFrm
    Public Shared EncodingFrmV As String = "인코딩"
    Public Shared EncodingPriorityLow As String = "낮음"
    Public Shared EncodingPriorityBelowNormal As String = "낮은 우선 순위"
    Public Shared EncodingPriorityNormal As String = "보통"
    Public Shared EncodingPriorityAboveNormal As String = "높은 우선 순위"
    Public Shared EncodingPriorityHigh As String = "높음"
    Public Shared EncodingPriorityRealtime As String = "실시간"
    Public Shared EncodingSuspend As String = "일시 정지"
    Public Shared EncodingResume As String = "재시작"
    Public Shared EncodingCreatingD2V As String = "D2V 생성중"
    Public Shared EncodingCreatingFFINDEX As String = "FFINDEX 생성중"
    Public Shared EncodingAVEncoding As String = "오디오/비디오 인코딩 중"
    Public Shared EncodingAEncoding As String = "오디오만 인코딩 중"
    Public Shared EncodingVEncoding As String = "비디오만 인코딩 중"
    Public Shared EncodingNeroAACEncoding As String = "Nero AAC 인코딩 중"
    Public Shared EncodingAVMux As String = "오디오와 비디오를 합치는 중"
    Public Shared EncodingStopButtonQ As String = "인코딩을 중지하시겠습니까?"
    Public Shared EncodingForceStopButtonQ As String = "인코딩을 강제중지하시겠습니까?"

    'StreamFrm
    Public Shared StreamERRSChkEChk As String = "시작시간이 종료시간보다 큽니다."

    'EncSetFrm
    Public Shared EncSetCBRVideoModeComboBox As String = "비트레이트를 기준으로 인코딩"
    Public Shared EncSetVBRVideoModeComboBox As String = "퀀타이저를 기준으로 인코딩"
    Public Shared EncSetCQPVideoModeComboBox As String = "퀀타이저를 기준으로 인코딩"
    Public Shared EncSetCRFVideoModeComboBox As String = "퀄리티를 기준으로 인코딩"
    Public Shared EncSetCBR2VideoModeComboBox As String = "비트레이트를 기준으로 두 번 인코딩"
    Public Shared EncSetUserInputComboBox As String = "(사용자 입력)"
    Public Shared EncSetNoKeepAspectComboBox As String = "비율을 유지하지 않음"
    Public Shared EncSetLetterBoxAspectComboBox As String = "아래 비율에 맞게 레터박스 붙이기"
    Public Shared EncSetCropAspectComboBox As String = "아래 비율에 맞게 잘라내기"
    Public Shared EncSetOutputAspectComboBox2 As String = "DAR(출력 비율)"
    Public Shared EncSetOriginalAspectComboBox2 As String = "SAR(원본 비율)"
    Public Shared EncSet43AspectComboBox2 As String = "4 : 3 (TV)"
    Public Shared EncSet169AspectComboBox2 As String = "16 : 9 (HDTV)"
    Public Shared EncSet1851AspectComboBox2 As String = "1.85 :1  (Wide TV)"
    Public Shared EncSet2351AspectComboBox2 As String = "2.35 : 1 (시네마스코프)"
    Public Shared EncSetchoriginComboBox As String = "원본 그대로 출력"
    Public Shared EncSetch10ComboBox As String = "1/0/0 - 1.0 채널"
    Public Shared EncSetch20ComboBox As String = "2/0/0 - 2.0 채널"
    Public Shared EncSetch51ComboBox As String = "3/0/2+LFE - 5.1 채널"
    Public Shared EncSetNeroAACBP As String = "비트레이트 설정은 아래 Nero AAC에서 합니다."
    Public Shared EncSetFLACBP As String = "FLAC코덱은 비트레이트를 지정할 수 없습니다."
    Public Shared EncSetPCMBP As String = "PCM코덱은 비트레이트를 지정할 수 없습니다."
    Public Shared EncSetCharERR As String = "앞 부분 이름 / 확장자에는 \, /, :, *, ?, <, >, | 입력할 수 없습니다."

    'AudioPPFrm
    Public Shared AudioPPchoriginComboBox As String = "원본 그대로 출력"
    Public Shared AudioPPch10ComboBox As String = "1/0/0 - 1.0 채널"
    Public Shared AudioPPch20ComboBox As String = "2/0/0 - 2.0 채널"
    Public Shared AudioPPch51ComboBox As String = "3/0/2+LFE - 5.1 채널"
    Public Shared AudioPPdolbysComboBox As String = "돌비 서라운드/프로로직"
    Public Shared AudioPPdolbypComboBox As String = "돌비 프로로직 II"

    'ImagePPFrm
    Public Shared ImagePPUserInputComboBox As String = "(사용자 입력)"
    Public Shared ImagePPBlurStr As String = "(부드러운)"
    Public Shared ImagePPSharpStr As String = "(선명한)"
    Public Shared ImagePPMiddleStr As String = "(중립의)"
    Public Shared ImagePPNoKeepAviSynthAspectComboBox As String = "비율을 유지하지 않음"
    Public Shared ImagePPLetterBoxAviSynthAspectComboBox As String = "아래 비율에 맞게 레터박스 붙이기"
    Public Shared ImagePPCropAviSynthAspectComboBox As String = "아래 비율에 맞게 잘라내기"
    Public Shared ImagePPOutputAviSynthAspectComboBox2 As String = "DAR(출력 비율)"
    Public Shared ImagePPOriginalAviSynthAspectComboBox2 As String = "SAR(원본 비율)"
    Public Shared ImagePP43AviSynthAspectComboBox2 As String = "4 : 3 (TV)"
    Public Shared ImagePP169AviSynthAspectComboBox2 As String = "16 : 9 (HDTV)"
    Public Shared ImagePP1851AviSynthAspectComboBox2 As String = "1.85 :1  (Wide TV)"
    Public Shared ImagePP2351AviSynthAspectComboBox2 As String = "2.35 : 1 (시네마스코프)"

    'VideoWindowFrm
    Public Shared VideoWindowFrmV As String = "미리보기"

    'AviSynthEditorFrm
    Public Shared AviSynthEditorInitializationQ As String = "초기화 하시겠습니까?"

    'Index
    Public Shared AVSIndexingV As String = "인덱스 작성중"

    'AddPresetFrm
    Public Shared AddPresetCharERR As String = "프리셋 이름에는 \, /, :, *, ?, <, >, | 입력할 수 없습니다."
    Public Shared AddPresetEmptyERR As String = "이름을 입력해주세요."

    'AVSIFrm
    Public Shared AVSIInfoLabelNot As String = "설치가 되어있지 않습니다."
    Public Shared AVSIInfoLabelOld As String = "구버전 입니다."
    Public Shared AVSIInfoLabelOK As String = "설치 확인 되었습니다."
    Public Shared AVSIProductVersion As String = "제품 버전"
    Public Shared AVSIFileVersion As String = "파일 버전"

End Class