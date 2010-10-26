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

Imports DirectShowLib

Public Class PropertyPageFrm

    Private _PropertyPage As PropertyPage

    Public Sub New(ByVal caption As String, ByVal filter As IBaseFilter)

        InitializeComponent()

        _PropertyPage = New PropertyPage(caption, filter)
        _PropertyPage.Dock = DockStyle.Fill


        Dim NewWidth As Integer = _PropertyPage._TabPageSize.Width + 8 + 20
        Dim NewHeight As Integer = _PropertyPage._TabPageSize.Height + 25 + 50
        Me.ClientSize = New Size(NewWidth, NewHeight)
        Me.Controls.Add(_PropertyPage)
        Me.Text = caption

        _PropertyPage._OKBTN.DialogResult = DialogResult.OK
        _PropertyPage._CLOSEBTN.DialogResult = DialogResult.Cancel

    End Sub

    Private Sub PropertyPageForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class