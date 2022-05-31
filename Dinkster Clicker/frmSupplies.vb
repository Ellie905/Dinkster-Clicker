Public Class frmSupplies
Private Sub btnSkimMilk1_Click(sender As Object, e As EventArgs) Handles btnSkimMilk1.Click
UpdateForm(My.Settings.SkimMil1, 2, My.Settings.SkimMilk1Cost, lblSkimMilk1Cost.Text, btnSkimMilk1)
End Sub
Private Sub btnSkimMilk1_KeyUp(sender As Object, e As KeyEventArgs) Handles btnSkimMilk1.KeyUp
If e.KeyCode = Keys.Enter Then
UpdateForm(My.Settings.SkimMil1, 2, My.Settings.SkimMilk1Cost, lblSkimMilk1Cost.Text, btnSkimMilk1)
End If
End Sub
Private Sub btnSkimMilk10_Click(sender As Object, e As EventArgs) Handles btnSkimMilk10.Click
UpdateForm(My.Settings.SkimMilk10, 20, My.Settings.SkimMilk10Cost, lblSkimMilk10Cost.Text, btnSkimMilk10)
End Sub
Private Sub btnSkimMilk10_KeyUp(sender As Object, e As KeyEventArgs) Handles btnSkimMilk10.KeyUp
If e.KeyCode = Keys.Enter Then
UpdateForm(My.Settings.SkimMilk10, 20, My.Settings.SkimMilk10Cost, lblSkimMilk10Cost.Text, btnSkimMilk10)
End If
End Sub
Private Sub btnSkimMilk50_Click(sender As Object, e As EventArgs) Handles btnSkimMilk50.Click
UpdateForm(My.Settings.SkimMilk50, 100, My.Settings.SkimMilk50Cost, lblSkimMilk50Cost.Text, btnSkimMilk50)
End Sub
Private Sub btnSkimMilk50_KeyUp(sender As Object, e As KeyEventArgs) Handles btnSkimMilk50.KeyUp
If e.KeyCode = Keys.Enter Then
UpdateForm(My.Settings.SkimMilk50, 100, My.Settings.SkimMilk50Cost, lblSkimMilk50Cost.Text, btnSkimMilk50)
End If
End Sub
Private Sub btnSkimMilk250_Click(sender As Object, e As EventArgs) Handles btnSkimMilk250.Click
UpdateForm(My.Settings.SkimMilk250, 500, My.Settings.SkimMilk250Cost, lblSkimMilk250Cost.Text, btnSkimMilk250)
End Sub
Private Sub btnSkimMilk250_KeyUp(sender As Object, e As KeyEventArgs) Handles btnSkimMilk250.KeyUp
If e.KeyCode = Keys.Enter Then
UpdateForm(My.Settings.SkimMilk250, 500, My.Settings.SkimMilk250Cost, lblSkimMilk250Cost.Text, btnSkimMilk250)
End If
End Sub
Private Sub btnCow1_Click(sender As Object, e As EventArgs) Handles btnCow1.Click
UpdateForm(My.Settings.Cow1, 15000, My.Settings.Cow1Cost, lblCow1Cost.Text, btnCow1)
End Sub
Private Sub btnCow1_KeyUp(sender As Object, e As KeyEventArgs) Handles btnCow1.KeyUp
If e.KeyCode = Keys.Enter Then
UpdateForm(My.Settings.Cow1, 15000, My.Settings.Cow1Cost, lblCow1Cost.Text, btnCow1)
End If
End Sub
Private Sub btnCow5_Click(sender As Object, e As EventArgs) Handles btnCow5.Click
UpdateForm(My.Settings.Cow5, 75000, My.Settings.Cow5Cost, lblCow5Cost.Text, btnCow5)
End Sub
Private Sub btnCow5_KeyUp(sender As Object, e As KeyEventArgs) Handles btnCow5.KeyUp
If e.KeyCode = Keys.Enter Then
UpdateForm(My.Settings.Cow5, 75000, My.Settings.Cow5Cost, lblCow5Cost.Text, btnCow5)
End If
End Sub
Private Sub btnCow30_Click(sender As Object, e As EventArgs) Handles btnCow30.Click
UpdateForm(My.Settings.Cow30, 450000, My.Settings.Cow30Cost, lblCow30Cost.Text, btnCow30)
End Sub
Private Sub btnCow30_KeyUp(sender As Object, e As KeyEventArgs) Handles btnCow30.KeyUp
If e.KeyCode = Keys.Enter Then
UpdateForm(My.Settings.Cow30, 450000, My.Settings.Cow30Cost, lblCow30Cost.Text, btnCow30)
End If
End Sub
Private Sub btnCow100_Click(sender As Object, e As EventArgs) Handles btnCow100.Click
UpdateForm(My.Settings.Cow100, 1500000, My.Settings.Cow100Cost, lblCow100Cost.Text, btnCow100)
End Sub
Private Sub btnCow100_KeyUp(sender As Object, e As KeyEventArgs) Handles btnCow100.KeyUp
If e.KeyCode = Keys.Enter Then
UpdateForm(My.Settings.Cow100, 1500000, My.Settings.Cow100Cost, lblCow100Cost.Text, btnCow100)
End If
End Sub
Private Sub btnCustomOrder_Click(sender As Object, e As EventArgs) Handles btnCustomOrder.Click
frmCustomOrder.Show()
frmCustomOrder.Focus()
If frmMessage.ShowInTaskbar Then
frmMessage.Hide()
My.Settings.MessageOpen = False
End If
End Sub
Private Sub UpdateForm(ByRef Setting1 As Object, ByRef RPSIncrease As Integer, ByRef Setting1Cost As Object, ByRef LabelText As String, ByRef Button As Button)
If My.Settings.NumRings < Setting1Cost Then
My.Forms.frmMessage.DisplayMessage("You have not rang the Dinkster enough to buy this mighty package")
My.Forms.frmMessage.Show()
My.Forms.frmMessage.Focus()
Return
Else
My.Settings.NumRPS += RPSIncrease
Setting1 += 1
DoTheThing(My.Settings.NumRings, Setting1Cost)
DoAnotherThing(Setting1Cost)
Dim Temp As String = Setting1Cost.ToString()
Dim FirstNum As String
Dim SecondNum As String
Dim ThirdNum As String
Dim FourthNum As String
Dim NewNum As String
If Setting1Cost > 10000000 Then
FirstNum = Temp(0)
SecondNum = Temp(1)
ThirdNum = Temp(2)
NewNum = FirstNum & SecondNum & "." & ThirdNum
LabelText = "Cost: " & NewNum & "M"
If Setting1Cost > 100000000 Then
FourthNum = Temp(3)
NewNum = FirstNum & SecondNum & ThirdNum & "." & FourthNum
LabelText = "Cost: " & NewNum & "M"
If Setting1Cost > 1000000000 Then
NewNum = FirstNum & "." & SecondNum & ThirdNum
LabelText = "Cost: " & NewNum & "B"
If Setting1Cost > 10000000000 Then
NewNum = FirstNum & SecondNum & "." & ThirdNum
LabelText = "Cost: " & NewNum & "B"
If Setting1Cost > 100000000000 Then
NewNum = FirstNum & SecondNum & ThirdNum & "." & FourthNum
LabelText = "Cost: " & NewNum & "B"
If Setting1Cost > 1000000000000 Then
NewNum = FirstNum & "." & SecondNum & ThirdNum & FourthNum
LabelText = "Cost: " & NewNum & "T"
If Setting1Cost > 10000000000000 Then
LabelText = "Cost: " & 10 & "T+"
End If
End If
End If
End If
End If
End If
Else
LabelText = "Cost: " & Format(Setting1Cost, "N0")
End If
Button.Text = "Buy! | Number: " & Setting1
My.Forms.frmClicker.AddDink()
End If
End Sub
Private Sub LoadForm(ByRef Setting1Cost As Object, ByRef LabelText As String)
Dim Temp As String = Setting1Cost.ToString()
Dim FirstNum As String = Temp.First()
Dim SecondNum As String = Temp(1)
Dim ThirdNum As String = Temp(2)
Dim FourthNum As String
Dim NewNum As String
If Setting1Cost > 10000000 Then
NewNum = FirstNum & SecondNum & "." & ThirdNum
LabelText = "Cost: " & NewNum & "M"
If Setting1Cost > 100000000 Then
FourthNum = Temp(3)
NewNum = FirstNum & SecondNum & ThirdNum & "." & FourthNum
LabelText = "Cost: " & NewNum & "M"
If Setting1Cost > 1000000000 Then
NewNum = FirstNum & "." & SecondNum & ThirdNum
LabelText = "Cost: " & NewNum & "B"
If Setting1Cost > 10000000000 Then
NewNum = FirstNum & SecondNum & "." & ThirdNum
LabelText = "Cost: " & NewNum & "B"
If Setting1Cost > 100000000000 Then
NewNum = FirstNum & SecondNum & ThirdNum & "." & FourthNum
LabelText = "Cost: " & NewNum & "B"
If Setting1Cost > 1000000000000 Then
NewNum = FirstNum & "." & SecondNum & ThirdNum & FourthNum
LabelText = "Cost: " & NewNum & "T"
If Setting1Cost > 10000000000000 Then
LabelText = "Cost: " & 10 & "T+"
End If
End If
End If
End If
End If
End If
Else
LabelText = "Cost: " & Format(Setting1Cost, "N0")
End If
End Sub
Private Sub DoTheThing(ByRef Setting As Object, ByRef Number As Decimal)
Dim Temp = Setting
Temp -= Number
Setting = Temp
Return
End Sub
Private Sub DoAnotherThing(ByRef Setting As Object)
Dim randomNumber As New Random
Dim r As Double = randomNumber.Next(30) - 2
If r < 0 Then r = 1
Dim Temp = Setting
r = 1 & "." & 0 & r
Temp *= r
Setting = Temp
End Sub
Public Sub FormLoad()
btnSkimMilk1.Text = "Buy! | Number: " & My.Settings.SkimMil1
LoadForm(My.Settings.SkimMilk1Cost, lblSkimMilk1Cost.Text)
btnSkimMilk10.Text = "Buy! | Number: " & My.Settings.SkimMilk10
LoadForm(My.Settings.SkimMilk10Cost, lblSkimMilk10Cost.Text)
btnSkimMilk50.Text = "Buy! | Number: " & My.Settings.SkimMilk50
LoadForm(My.Settings.SkimMilk50Cost, lblSkimMilk50Cost.Text)
btnSkimMilk250.Text = "Buy! | Number: " & My.Settings.SkimMilk250
LoadForm(My.Settings.SkimMilk250Cost, lblSkimMilk250Cost.Text)
btnCow1.Text = "Buy! | Number: " & My.Settings.Cow1
LoadForm(My.Settings.Cow1Cost, lblCow1Cost.Text)
btnCow5.Text = "Buy! | Number: " & My.Settings.Cow5
LoadForm(My.Settings.Cow5Cost, lblCow5Cost.Text)
btnCow30.Text = "Buy! | Number: " & My.Settings.Cow30
LoadForm(My.Settings.Cow30Cost, lblCow30Cost.Text)
btnCow100.Text = "Buy! | Number: " & My.Settings.Cow100
LoadForm(My.Settings.Cow100Cost, lblCow100Cost.Text)
End Sub
Private Sub frmSupplies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
Me.Left = 339
Me.Top = 50
FormLoad()
End Sub
Private Sub btnControlExit_Click(sender As Object, e As EventArgs) Handles btnControlExit.Click
Me.Close()
End Sub
Private Sub btnControlMinimize_Click(sender As Object, e As EventArgs) Handles btnControlMinimize.Click
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
End Class