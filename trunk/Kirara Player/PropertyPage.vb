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

Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Collections.Generic
Imports DirectShowLib

Public Class PropertyPage

    Inherits Panel
    Implements PPS

    Private DownPanel As Panel
    Private DownPanelRight As Panel

    Private APPLYBTN As Button
    Private OKBTN As Button
    Private CLOSEBTN As Button

    Private ErrorLabel As Label

    Private TabControl1 As TabControl
    Private TabPageSize As New Size(370, 20)
    Private BaseFilter As IBaseFilter

    Private PageIPP As New List(Of PP)()
    Private ListIP As New List(Of IntPtr)()

    <ComImport()> _
    <Guid("B196B28D-BAB4-101A-B69C-00AA00341D07")> _
    <InterfaceType(ComInterfaceType.InterfaceIsIUnknown)> _
    Public Interface PP
        Sub SetPageSite(ByVal site As PPS)
        Sub Activate(ByVal wndParent As IntPtr, ByRef rect As Rectangle, ByVal modal As Boolean)
        Sub Deactivate()
        Sub GetPageInfo(ByRef info As PPI)
        Sub SetObjects(ByVal count As Integer, <MarshalAs(UnmanagedType.LPArray, ArraySubType:=UnmanagedType.IUnknown, SizeParamIndex:=0)> ByVal objs As [Object]())
        Sub Show(ByVal cmdShow As Integer)
        Sub Move(ByRef rect As Rectangle)
        <PreserveSig()> _
        Function IsPageDirty() As Integer
        Sub Apply()
        Sub Help(<MarshalAs(UnmanagedType.LPWStr)> ByRef helpDir As [String])
        <PreserveSig()> _
        Function TranslateAccelerator(ByRef msg As Message) As Integer
    End Interface

    <ComImport()> _
    <Guid("B196B28C-BAB4-101A-B69C-00AA00341D07")> _
    <InterfaceType(ComInterfaceType.InterfaceIsIUnknown)> _
    Public Interface PPS
        Sub OnStatusChange(ByVal dwFlags As Integer)
        Sub GetLocaleID(ByRef LocaleID As Integer)
        Sub GetPageContainer(<MarshalAs(UnmanagedType.IUnknown)> ByRef objs As [Object])
        <PreserveSig()> _
        Function TranslateAccelerator(ByRef msg As Message) As Integer
    End Interface

    <ComVisible(False)> _
    Public Structure PPI
        Public cb As Integer
        Public szTitle As IntPtr
        Public size As Size
        Public szDocString As IntPtr
        Public szHelpFile As IntPtr
        Public dwHelpContext As Integer
    End Structure

    Public Sub New(ByVal _Name As String, ByVal _BaseFilter As IBaseFilter)
        BaseFilter = _BaseFilter

        TabControl1 = New TabControl()
        TabControl1.Left = 10
        TabControl1.Top = 10
        TabControl1.Width = TabControl1.Width - 20
        TabControl1.Height = TabControl1.Height - 10 - 40
        TabControl1.Anchor = AnchorStyles.Left Or AnchorStyles.Top Or AnchorStyles.Right Or AnchorStyles.Bottom
        Controls.Add(TabControl1)

        DownPanel = New Panel()
        DownPanel.Dock = DockStyle.Bottom
        DownPanel.Height = 40
        Controls.Add(DownPanel)

        DownPanelRight = New Panel()
        DownPanelRight.Width = 300
        DownPanelRight.Dock = DockStyle.Right
        DownPanel.Controls.Add(DownPanelRight)

        APPLYBTN = New Button()
        APPLYBTN.Text = "Apply"
        APPLYBTN.Width = 85
        APPLYBTN.Height = 24
        APPLYBTN.Top = 8
        APPLYBTN.Left = DownPanelRight.Width - APPLYBTN.Width - 10
        APPLYBTN.Enabled = False
        AddHandler APPLYBTN.Click, AddressOf APPLYBTN_Click
        DownPanelRight.Controls.Add(APPLYBTN)

        CLOSEBTN = New Button()
        CLOSEBTN.Text = "Cancel"
        CLOSEBTN.Width = 85
        CLOSEBTN.Height = 24
        CLOSEBTN.Top = 8
        CLOSEBTN.Left = DownPanelRight.Width - APPLYBTN.Width - CLOSEBTN.Width - 15
        AddHandler CLOSEBTN.Click, AddressOf CLOSEBTN_Click
        DownPanelRight.Controls.Add(CLOSEBTN)

        OKBTN = New Button()
        OKBTN.Text = "OK"
        OKBTN.Width = 85
        OKBTN.Height = 24
        OKBTN.Top = 8
        OKBTN.Left = DownPanelRight.Width - APPLYBTN.Width - CLOSEBTN.Width - OKBTN.Width - 20
        AddHandler OKBTN.Click, AddressOf OKBTN_Click
        DownPanelRight.Controls.Add(OKBTN)

        ErrorLabel = New Label



        '///////////////////////////////////////////////////////////////




        Dim hr As Integer = 0
        Dim SpecifyPropertyPages As ISpecifyPropertyPages = TryCast(_BaseFilter, ISpecifyPropertyPages)
        If SpecifyPropertyPages IsNot Nothing Then

            TabPageSize.Width = 0
            TabPageSize.Height = 0

            Dim _DsCAUUID As DsCAUUID
            hr = SpecifyPropertyPages.GetPages(_DsCAUUID)

            If hr <> 0 OrElse _DsCAUUID.cElems = 0 Then
                GoTo skip
            End If

            Dim _PPageGuid As Guid() = _DsCAUUID.ToGuidArray()

            For i As Integer = 0 To _PPageGuid.Length - 1
                Try
                    Dim _Type As Type = Type.GetTypeFromCLSID(_PPageGuid(i))
                    Dim _Object As Object = Activator.CreateInstance(_Type)

                    Dim _PP As PP = TryCast(_Object, PP)
                    Dim _PPI As New PPI()
                    _PP.GetPageInfo(_PPI)

                    If _Name = "MPEG Layer-3 Decoder" Then

                        TabPageSize.Width = Math.Max(TabPageSize.Width, 340)
                        TabPageSize.Height = Math.Max(TabPageSize.Height, 180)

                    ElseIf _Name = "Haali Video Renderer" Then

                        TabPageSize.Width = Math.Max(TabPageSize.Width, _PPI.size.Width + 5)
                        TabPageSize.Height = Math.Max(TabPageSize.Height, _PPI.size.Height + 5)

                    Else

                        TabPageSize.Width = Math.Max(TabPageSize.Width, _PPI.size.Width)
                        TabPageSize.Height = Math.Max(TabPageSize.Height, _PPI.size.Height)

                    End If

                    ListIP.Add(Marshal.GetIUnknownForObject(_Object))

                    Dim BaseFilterObject As Object() = {_BaseFilter}
                    _PP.SetObjects(1, BaseFilterObject)
                    _PP.SetPageSite(Me)

                    Dim _Rectangle As New Rectangle(0, 0, TabPageSize.Width, TabPageSize.Height)
                    Dim _TabPage As New TabPage(Replace(Marshal.PtrToStringAuto(_PPI.szTitle), "&", ""))
                    TabControl1.Controls.Add(_TabPage)
                    PageIPP.Add(_PP)
                    _PP.Activate(_TabPage.Handle, _Rectangle, False)

                    Dim _GetWindow As IntPtr = GetWindow(_TabPage.Handle, 5)
                    If _GetWindow <> IntPtr.Zero Then
                        ShowWindow(_GetWindow, 5)
                    End If
                Catch
                End Try
            Next
        Else
skip:
            TabPageSize.Width = 370
            TabPageSize.Height = 20
            TabControl1.Visible = False
            APPLYBTN.Visible = False
            CLOSEBTN.Visible = False
            OKBTN.Left = DownPanelRight.Width - OKBTN.Width - 10
            If ErrorLabel.Text = "" Then
                ErrorLabel.Text = "-"
            End If
            ErrorLabel.Width = TabPageSize.Width
            ErrorLabel.Height = 100
            ErrorLabel.Left = 15
            ErrorLabel.Top = 15
            Controls.Add(ErrorLabel)
        End If
    End Sub

    Public ReadOnly Property _OKBTN() As Button
        Get
            Return OKBTN
        End Get
    End Property

    Public ReadOnly Property _CLOSEBTN() As Button
        Get
            Return CLOSEBTN
        End Get
    End Property

    Public ReadOnly Property _TabPageSize() As Size
        Get
            Return TabPageSize
        End Get
    End Property

    Public ReadOnly Property _TabControl1() As TabControl
        Get
            Return TabControl1
        End Get
    End Property

    <DllImport("user32.dll", SetLastError:=True)> _
    Private Shared Function GetWindow(ByVal hWnd As IntPtr, ByVal uCmd As UInteger) As IntPtr
    End Function

    <DllImport("user32.dll")> _
    Private Shared Function ShowWindow(ByVal hWnd As IntPtr, ByVal nCmdShow As Integer) As Boolean
    End Function

    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        MyBase.Dispose(disposing)
        ClosePropertyPage()
    End Sub

    Private Sub APPLYBTN_Click(ByVal sender As Object, ByVal e As EventArgs)
        For Each _PP As PP In PageIPP
            _PP.Apply()
        Next
        APPLYBTN.Enabled = False
    End Sub

    Private Sub OKBTN_Click(ByVal sender As Object, ByVal e As EventArgs)
        For Each _PP As PP In PageIPP
            _PP.Apply()
        Next
        Me.Parent.Dispose()
    End Sub

    Private Sub CLOSEBTN_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Parent.Dispose()
    End Sub

    Public Sub ClosePropertyPage()
        If PageIPP IsNot Nothing Then
            For Each pp As PP In PageIPP
                Try
                    pp.Deactivate()
                    pp.SetObjects(0, Nothing)
                    pp.SetPageSite(Nothing)
                Catch ex As Exception

                Finally
                    Dim refc As Integer = Marshal.ReleaseComObject(pp)
                End Try
            Next

            For Each ptr As IntPtr In ListIP
                Dim refc As Integer = Marshal.Release(ptr)
            Next
            ListIP.Clear()
            PageIPP = Nothing
        End If
    End Sub

    Public Sub GLID(ByRef _Integer As Integer) Implements PPS.GetLocaleID
        _Integer = 0
    End Sub

    Public Sub GPC(ByRef _Object As Object) Implements PPS.GetPageContainer
        _Object = Nothing
    End Sub

    Public Sub OSC(ByVal _Integer As Integer) Implements PPS.OnStatusChange
        APPLYBTN.Enabled = True
    End Sub

    Public Function TA(ByRef msg As System.Windows.Forms.Message) As Integer Implements PPS.TranslateAccelerator
        Return 0
    End Function

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        Me.ResumeLayout(False)

    End Sub
End Class

