Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraLayout


Namespace WindowsApplication3
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub OnLayoutControlShowContextMenu(ByVal sender As Object, ByVal e As DevExpress.XtraLayout.LayoutMenuEventArgs) Handles layoutControl1.ShowContextMenu
			If layoutControl1.CustomizationForm IsNot Nothing AndAlso layoutControl1.CustomizationForm.Visible AndAlso e.HitInfo.Item IsNot Nothing Then
				Dim layoutItem As LayoutControlItem = TryCast(e.HitInfo.Item, LayoutControlItem)
				If layoutItem Is Nothing Then
					Return
				End If
				If layoutItem.Image Is Nothing Then
                    e.Menu.Items.Add(CreateCustomMenuItem("&Add Image", AddressOf OnAddImage, layoutItem, Global.Resources.Dock))
                Else
					e.Menu.Items.Add(CreateCustomMenuItem("&Remove Image", AddressOf OnRemoveImage, layoutItem, Nothing))
				End If
			End If
		End Sub

		Private Function CreateCustomMenuItem(ByVal caption As String, ByVal handler As EventHandler, ByVal layoutItem As LayoutControlItem, ByVal img As Image) As DXMenuItem
			Dim item As New DXMenuItem(caption, handler, img)
			item.Tag = layoutItem
			Return item
		End Function

		Private imageSize As New Size(20, 20)

		Private Sub OnAddImage(ByVal sender As Object, ByVal e As EventArgs)
			Dim item As DXMenuItem = TryCast(sender, DXMenuItem)
			If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				Try
					Dim img As Image = Image.FromFile(openFileDialog1.FileName)
					Dim layoutItem As LayoutControlItem = TryCast(item.Tag, LayoutControlItem)
					Dim bmp As New Bitmap(img, imageSize)
					layoutItem.Tag = layoutItem.TextVisible
					If (Not layoutItem.TextVisible) Then
						layoutItem.TextVisible = True
						layoutItem.TextAlignMode = TextAlignModeItem.CustomSize
						layoutItem.TextSize = imageSize
					End If
					layoutItem.Image = bmp
				Catch
				End Try
			End If
		End Sub

		Private Sub OnRemoveImage(ByVal sender As Object, ByVal e As EventArgs)
			Dim item As DXMenuItem = TryCast(sender, DXMenuItem)
			Dim layoutItem As LayoutControlItem = TryCast(item.Tag, LayoutControlItem)
			If layoutItem.Tag IsNot Nothing AndAlso TypeOf layoutItem.Tag Is Boolean Then
				layoutItem.TextVisible = CBool(layoutItem.Tag)
			End If
			layoutItem.Image = Nothing
		End Sub
	End Class
End Namespace
