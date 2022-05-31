Public Class frmMessage
    Private Sub btnControlExit_Click(sender As Object, e As EventArgs) Handles btnControlExit.Click
        Me.Close()
    End Sub

    Private Sub btnControlMinimize_Click(sender As Object, e As EventArgs) Handles btnControlMinimize.Click
        Me.WindowState = FormWindowState.Minimized
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
End Class