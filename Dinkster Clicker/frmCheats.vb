Public Class frmCheats
Private Sub btnCheat_Click(sender As Object, e As EventArgs) Handles btnCheat.Click
Cheats()
End Sub
Private Sub txtCheat_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCheat.KeyUp
If e.KeyCode = Keys.Enter Then
e.SuppressKeyPress = True
Try
Cheats()
Catch ex As Exception
End Try
End If
End Sub
Private Sub Cheats()
Dim strCheat As String = txtCheat.Text.ToLower()
Select Case strCheat
Case "ring the dinkster"
My.Settings.NumRings += 100000
My.Forms.frmClicker.AddDink()
EndCheat()
Case "don't ring"
My.Settings.NumRings -= 100000
My.Forms.frmClicker.AddDink()
EndCheat()
Case "do a debug"
My.Settings.NumRings += 1000000000000
My.Settings.NumRPS += 3000000000
My.Forms.frmClicker.AddDink()
EndCheat()
Case "yuge debug"
My.Settings.NumRings += 100000000000000000
My.Settings.NumRPS += 3000000000000000000
My.Forms.frmClicker.AddDink()
EndCheat()
Case "end game debug"
My.Settings.NumRings += (Decimal.MaxValue / 200)
My.Settings.NumRPS += (Decimal.MaxValue / 2000)
My.Forms.frmClicker.AddDink()
EndCheat()
Case "parasol"
My.Settings.NumRPS += 250
My.Forms.frmClicker.AddDink()
EndCheat()
Case "negative parasol"
My.Settings.NumRPS -= 250
My.Forms.frmClicker.AddDink()
EndCheat()
Case "wacky"
My.Forms.frmClicker.btnDink.Size = My.Forms.frmClicker.Size
My.Forms.frmClicker.btnDink.Left = 0
My.Forms.frmClicker.btnDink.Top = 0
EndCheat()
Case "wacky1"
Dim randomValue As New Random
Dim r As Double = randomValue.Next(300)
My.Forms.frmClicker.btnDink.Left = r
r = randomValue.Next(300)
My.Forms.frmClicker.btnDink.Top = r
My.Forms.frmClicker.Refresh()
EndCheat()
Case "no sound"
My.Settings.NoSound = True
EndCheat()
Case "sound"
My.Settings.NoSound = False
EndCheat()
Case "cat"
My.Forms.frmClicker.btnDink.BackgroundImage = My.Resources.cat
My.Forms.frmClicker.Label1.Text = "Click the Prick with the Tick"
My.Forms.frmClicker.lblControlTitle.Text = "Prickster Clicker"
My.Settings.NoSound = True
EndCheat()
Case "no cat"
If My.Settings.GameBeaten = True Then
My.Forms.frmClicker.btnDink.BackgroundImage = My.Resources.goldendink
Else
My.Forms.frmClicker.btnDink.BackgroundImage = My.Resources.dink
End If
My.Forms.frmClicker.Label1.Text = "Did Somebody Ring The Dinkster"
My.Forms.frmClicker.lblControlTitle.Text = "Dinkster Clicker"
EndCheat()
Case "stop ringing"
My.Settings.NumRPS = 0
EndCheat()
Case "fever"
My.Forms.frmClicker.btnDink.BackgroundImage = My.Resources.yellowfeverdink
EndCheat()
Case Else
txtCheat.Text = ""
Label1.Focus()
My.Forms.frmMessage.DisplayMessage("Code Not Recognized")
My.Forms.frmMessage.Show()
End Select
End Sub
Private Sub EndCheat()
txtCheat.Text = ""
My.Forms.frmMessage.DisplayMessage("Cheat Accepted")
My.Forms.frmMessage.Show()
Me.Close()
End Sub
Private Sub frmCheats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
Me.Left = 50
Me.Top = 420
Label1.Focus()
End Sub
Private Sub btnControlExit_Click(sender As Object, e As EventArgs) Handles btnControlExit.Click
Me.Close()
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
Private Sub frmCheats_Shown(sender As Object, e As EventArgs) Handles Me.Shown
Label1.Focus()
End Sub
End Class