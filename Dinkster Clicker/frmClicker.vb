Imports System.ComponentModel
Imports System.Threading
Public Class frmClicker
Dim MyNumber As Integer = RandomNumber(147)
Dim Seconds As Integer = 0
Dim Minutes As Integer = 0
Dim Hours As Integer = 0
Dim RingsPerSecond As Decimal = My.Settings.NumRPS
Dim RingsNow As Decimal = My.Settings.NumRings
Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
My.Forms.frmCustomOrder.DoAnotherThing(My.Settings.IncreaseShippingRate)
Me.Left = 50
Me.Top = 50
ClickForm(My.Settings.NumRings, lblNumDinksters.Text)
ClickForm(My.Settings.NumRPS, lblDPS.Text)
If My.Settings.GameBeaten = True Then
lblComplete.Text = (My.Settings.NumRings / Decimal.MaxValue).ToString("P7")
btnDink.BackgroundImage = My.Resources.goldendink
Else
lblComplete.Text = (My.Settings.NumRings / 1000000000).ToString("P7")
End If
BgwAddDinks.RunWorkerAsync()
TimeKeeper.RunWorkerAsync()
End Sub
Public Sub AddDink(Optional ByVal Picture = False)
If My.Settings.LimitReached = False Then
Try
If Picture = True Then
If My.Settings.GameBeaten = True Then
My.Settings.NumRings += 5
lblComplete.Text = (My.Settings.NumRings / Decimal.MaxValue).ToString("P7")
Else
My.Settings.NumRings += 1
lblComplete.Text = (My.Settings.NumRings / 1000000000).ToString("P7")
CheckDink()
End If
ClickForm(My.Settings.NumRings, lblNumDinksters.Text)
My.Settings.Save()
Else
My.Settings.NumRings += (My.Settings.NumRPS * My.Settings.RingMultiplier)
ClickForm(My.Settings.NumRings, lblNumDinksters.Text)
ClickForm(My.Settings.NumRPS, lblDPS.Text)
If My.Settings.GameBeaten = True Then
lblComplete.Text = (My.Settings.NumRings / Decimal.MaxValue).ToString("P7")
Else
lblComplete.Text = (My.Settings.NumRings / 1000000000).ToString("P7")
CheckDink()
End If
My.Settings.Save()
End If
Catch ex As Exception
MsgBox("You have reached the maximum ring limit that the universe can take. Why don't you go collect starfruit or something?")
My.Settings.LimitReached = True
My.Settings.Save()
End Try
End If
Return
End Sub
Public Sub CheckDink()
If My.Settings.NumRings > 1000 Then
If My.Settings.DoEachOnce = 1 Then
My.Settings.DoEachOnce += 1
MsgBox("You cannot possibly hang ten with the Dinkster")
Return
End If
If My.Settings.NumRings > 10000 Then
If My.Settings.DoEachOnce = 2 Then
My.Settings.DoEachOnce += 1
MsgBox("The parasol is mightier than the sword, fool")
Return
End If
If My.Settings.NumRings > 100000 Then
If My.Settings.DoEachOnce = 3 Then
My.Settings.DoEachOnce += 1
MsgBox("Your ringing is beginning to be heard..")
Return
End If
If My.Settings.NumRings > 1000000 Then
If My.Settings.DoEachOnce = 4 Then
My.Settings.DoEachOnce += 1
MsgBox("no")
Return
End If
If My.Settings.NumRings > 10000000 Then
If My.Settings.DoEachOnce = 5 Then
My.Settings.DoEachOnce += 1
MsgBox("It is ill-advised to continue. Your lower mandible might snap, and your lacrimal ducts may begin to swell")
Return
End If
If My.Settings.NumRings > 1000000000 Then
If My.Settings.DoEachOnce = 6 Then
My.Settings.DoEachOnce += 1
MsgBox("Sombody Ring The Dinkster?")
My.Computer.Audio.Play(My.Resources.Somebody_ring_the_dinkster, AudioPlayMode.Background)
Try
MessageBox.Show("You have rang the Dinkster. You have been awarded a special prize - The Golden Dinkster. You can continue to play, or restart, but either way you can keep your prize. It is a permanent bonus, and gives 5 Rings when you click. The Percentage Complete box has been reset and now accounts for the theoretical max amount of Rings you can get. Good luck!", "Congratulations - You Have Beaten The Game")
btnDink.BackgroundImage = My.Resources.goldendink
My.Settings.GameBeaten = True
My.Settings.RingMultiplier = 2.5
Catch ex As Exception
MsgBox(ErrorToString())
End Try
Return
End If
End If
End If
End If
End If
End If
End If
End Sub
Private Sub btnDink_MouseClick(sender As Object, e As MouseEventArgs) Handles btnDink.MouseClick
AddDink(True)
Try
If My.Settings.NoSound = False Then
My.Computer.Audio.Play(My.Resources.Somebody_ring_the_dinkster, AudioPlayMode.Background)
End If
Catch ex As Exception
My.Forms.frmMessage.DisplayMessage(ErrorToString())
End Try
Select Case MyNumber
Case 29
My.Forms.frmMessage.DisplayMessage("You dare think you are mighty enough to ring the Dinkster?")
My.Forms.frmMessage.Show()
Case 54
Try
Process.Start("http://i2.kym-cdn.com/photos/images/newsfeed/001/092/248/78b.jpg")
Catch ex As Exception
End Try
End Select
End Sub
Private Sub btnSupplies_Click(sender As Object, e As EventArgs) Handles btnSupplies.Click
frmSupplies.Show()
frmSupplies.Focus()
End Sub
Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
MessageBox.Show("Final Stats:" & ControlChars.NewLine & "Time This Game: " & "H:" & Hours & " M: " & Minutes & " S: " & Seconds & ControlChars.NewLine & "Rings Per Second Increase Since Start: " & (My.Settings.NumRPS - RingsPerSecond).ToString("N0") & ControlChars.NewLine & "Rings Increase Since Start: " & (My.Settings.NumRings - RingsNow).ToString("N0"), "Thanks For Playing!")
If My.Settings.GameBeaten = True Then
Dim result = MessageBox.Show("Would you like to revert to the Normal Dinkster?" & ControlChars.NewLine & "(Your bonus will be erased)", "Revert?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
If result = Windows.Forms.DialogResult.Yes Then
My.Settings.GameBeaten = False
My.Settings.DoEachOnce = 1
btnDink.BackgroundImage = My.Resources.dink
My.Settings.RingMultiplier = 0
Else
btnDink.BackgroundImage = My.Resources.goldendink
My.Settings.RingMultiplier = 5
End If
Else
My.Settings.DoEachOnce = 1
End If
Seconds = 0
Minutes = 0
Hours = 0
RingsPerSecond = 0
RingsNow = 0
My.Settings.LimitReached = False
My.Settings.NumRings = 0
My.Settings.NumRPS = 0
My.Settings.SkimMil1 = 0
My.Settings.SkimMilk1Cost = 256
My.Settings.SkimMilk10 = 0
My.Settings.SkimMilk10Cost = 2560
My.Settings.SkimMilk50 = 0
My.Settings.SkimMilk50Cost = 12800
My.Settings.SkimMilk250 = 0
My.Settings.SkimMilk250Cost = 64000
My.Settings.Cow1 = 0
My.Settings.Cow1Cost = 3840000
My.Settings.Cow5 = 0
My.Settings.Cow5Cost = 19200000
My.Settings.Cow30 = 0
My.Settings.Cow30Cost = 115200000
My.Settings.Cow100 = 0
My.Settings.Cow100Cost = 384000000
My.Settings.IncreaseShippingRate = 1
My.Forms.frmSupplies.FormLoad()
My.Forms.frmCustomOrder.DoAnotherThing(My.Settings.IncreaseShippingRate)
btnDink.Left = 58
btnDink.Top = 94
btnDink.Width = 169
btnDink.Height = 128
lblControlTitle.Text = "Dinkster Clicker"
Label1.Text = "Did Somebody Ring The Dinkster"
My.Settings.Save()
End Sub
Private Sub BgwAddDinks_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BgwAddDinks.DoWork
CheckForIllegalCrossThreadCalls = False
Dim doOnce As Integer = 0
Do While (3 = 3)
MyNumber = RandomNumber(147)
Thread.Sleep(1000)
AddDink()
My.Settings.Reload()
Loop
End Sub
Public Function RandomNumber(ByVal n As Integer) As Integer
Dim r As New Random(System.DateTime.Now.Millisecond)
Return r.Next(1, n)
End Function
Private Sub btnCheats_Click(sender As Object, e As EventArgs) Handles btnCheats.Click
frmCheats.Show()
frmCheats.Focus()
End Sub
Private Sub TimeKeeper_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles TimeKeeper.DoWork
CheckForIllegalCrossThreadCalls = False
Do Until 1 = 3
Seconds += 1
Thread.Sleep(1000)
If Seconds = 60 Then
Minutes += 1
Seconds = 0
End If
If Minutes = 60 Then
Hours += 1
Minutes = 0
End If
Loop
End Sub
Public Sub ClickForm(ByRef Setting1 As Object, ByRef LabelText As String)
Dim Temp As String = Setting1.ToString()
Dim FirstNum As String
Dim SecondNum As String
Dim ThirdNum As String
Dim FourthNum As String
Dim NewNum As String
If Setting1 > 10000000 Then
FirstNum = Temp(0)
SecondNum = Temp(1)
ThirdNum = Temp(2)
NewNum = FirstNum & SecondNum & "." & ThirdNum
LabelText = NewNum & "M"
If Setting1 > 100000000 Then
FirstNum = Temp(0)
SecondNum = Temp(1)
ThirdNum = Temp(2)
FourthNum = Temp(3)
NewNum = FirstNum & SecondNum & ThirdNum & "." & FourthNum
LabelText = NewNum & "M"
If Setting1 > 1000000000 Then
NewNum = FirstNum & "." & SecondNum & ThirdNum
LabelText = NewNum & "B"
If Setting1 > 10000000000 Then
NewNum = FirstNum & SecondNum & "." & ThirdNum
LabelText = NewNum & "B"
If Setting1 > 100000000000 Then
NewNum = FirstNum & SecondNum & ThirdNum & "." & FourthNum
LabelText = NewNum & "B"
If Setting1 > 1000000000000 Then
NewNum = FirstNum & "." & SecondNum & ThirdNum & FourthNum
LabelText = NewNum & "T"
If Setting1 > 10000000000000 Then
LabelText = 10 & "T+"
End If
End If
End If
End If
End If
End If
Else
LabelText = Format(Setting1, "N0")
End If
End Sub
Private Sub btnControlExit_Click(sender As Object, e As EventArgs) Handles btnControlExit.Click
Me.Hide()
My.Forms.frmCheats.Hide()
My.Forms.frmSupplies.Hide()
My.Forms.frmMessage.Hide()
My.Forms.frmCustomOrder.Hide()
MessageBox.Show("Final Stats:" & ControlChars.NewLine & "Time This Session: " & "H:" & Hours & " M: " & Minutes & " S: " & Seconds & ControlChars.NewLine & "Rings Per Second Increase Since Start: " & (My.Settings.NumRPS - RingsPerSecond).ToString("N0") & ControlChars.NewLine & "Rings Increase Since Start: " & (My.Settings.NumRings - RingsNow).ToString("N0"), "Thanks For Playing!")
Application.Exit()
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
Private Sub btnShowValues_Click(sender As Object, e As EventArgs) Handles btnShowValues.Click
My.Forms.frmMessage.DisplayMessage("Total Rings: " & My.Settings.NumRings.ToString("N0") & ControlChars.NewLine & "Total RPS: " & My.Settings.NumRPS.ToString("N0"), "Stats")
frmMessage.Show()
frmMessage.Focus()
End Sub
End Class
