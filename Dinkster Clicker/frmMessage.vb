Imports System.ComponentModel
Public Class frmMessage
Private Sub btnControlExit_Click(sender As Object, e As EventArgs) Handles btnControlExit.Click
Me.Close()
End Sub
Private Sub btnControlMinimize_Click(sender As Object, e As EventArgs)
Me.Hide()
End Sub
Dim mouseLocation As Point
Dim isMouseDown As Boolean = False
Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
isMouseDown = True
mouseLocation = e.Location
End Sub
Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
If isMouseDown = True Then
Me.Location += e.Location - mouseLocation
End If
End Sub
Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
isMouseDown = False
End Sub
Private Sub lblControlTitle_MouseDown(sender As Object, e As MouseEventArgs) Handles lblControlTitle.MouseDown
isMouseDown = True
mouseLocation = e.Location
End Sub
Private Sub lblControlTitle_MouseMove(sender As Object, e As MouseEventArgs) Handles lblControlTitle.MouseMove
If isMouseDown = True Then
Me.Location += e.Location - mouseLocation
End If
End Sub
Private Sub lblControlTitle_MouseUp(sender As Object, e As MouseEventArgs) Handles lblControlTitle.MouseUp
isMouseDown = False
End Sub
Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
Me.Hide()
lblText.Text = ""
lblControlTitle.Text = ""
End Sub
Public Sub DisplayMessage(ByRef message As String, Optional ByRef title As String = "")
lblText.Text = message
lblControlTitle.Text = title
End Sub
Private Sub frmMessage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
Me.Left = 339
Me.Top = 291
My.Settings.MessageOpen = True
End Sub
Private Sub frmMessage_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
My.Settings.MessageOpen = False
End Sub
End Class