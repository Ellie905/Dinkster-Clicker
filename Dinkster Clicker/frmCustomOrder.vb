Imports System.ComponentModel
Imports System.Text.RegularExpressions
Public Class frmCustomOrder
Dim RingTemp As Decimal
Dim RPSTemp As Decimal
Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
If My.Settings.NumRings < RingTemp Then
My.Forms.frmMessage.DisplayMessage("You have not rang the Dinkster enough to buy this mighty package")
My.Forms.frmMessage.Show()
My.Forms.frmMessage.Focus()
Return
Else
If radSkimMilk.Checked Then
If comAmount.Text < 1000 Then
comAmount.Text = "1,000"
My.Forms.frmMessage.DisplayMessage("High Noon Shipping Co. does not ship to bums. High Noon only ships quality goods to quality customers")
My.Forms.frmMessage.Show()
My.Forms.frmMessage.Focus()
Return
End If
ElseIf radCows.Checked Then
If comAmount.Text < 250 Then
comAmount.Text = "250"
My.Forms.frmMessage.DisplayMessage("High Noon Shipping Co. does not ship to bums. High Noon only ships quality goods to quality customers")
My.Forms.frmMessage.Show()
My.Forms.frmMessage.Focus()
Return
End If
End If
If (My.Settings.NumRPS + RPSTemp) > Decimal.MaxValue Then
My.Forms.frmMessage.DisplayMessage("This ring will deafen the Dinkster. You cannot have that many.")
My.Forms.frmMessage.Show()
My.Forms.frmMessage.Focus()
Return
End If
If RingTemp = 0 Or RPSTemp = 0 Then
My.Forms.frmMessage.DisplayMessage("Why, you haven't picked out anything to order! You can't order nothing.")
My.Forms.frmMessage.Show()
My.Forms.frmMessage.Focus()
Return
End If
My.Settings.NumRings -= RingTemp
My.Settings.NumRPS += RPSTemp
My.Forms.frmClicker.AddDink()
GetTotal()
DoAnotherThing(My.Settings.IncreaseShippingRate)
Me.Refresh()
End If
End Sub
Dim Handled As Boolean = False
Private Sub comAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles comAmount.KeyPress
If (e.KeyChar <= "0" And e.KeyChar >= "9") And e.KeyChar <> ControlChars.Back Then
e.Handled = True
Handled = True
End If
End Sub
Private Sub comAmount_TextChanged(sender As Object, e As EventArgs) Handles comAmount.TextChanged
If comAmount.Text = "" Then
comAmount.Text = "0"
End If
Dim Temp As String = comAmount.Text.Replace(",", "")
If Handled = True Then
If Temp >= Decimal.MaxValue Then
comAmount.Text = Decimal.MaxValue - 1
Handled = False
End If
If comAmount.Text < 0 Then
comAmount.Text = "0"
End If
Else
comAmount.Text = Regex.Replace(comAmount.Text, "[a|b|c|d|e|f|g|h|i|j|k|l|m|n|o|p|q|r|s|t|u|v|w|x|y|z|;|/|=|\|-|'|.|`|~|!|@|#|$|%|^|&|*|(|)|{|}|]{1}", String.Empty)
comAmount.Text = comAmount.Text.Replace("-", "")
comAmount.Text = comAmount.Text.Replace("+", "")
comAmount.Text = comAmount.Text.Replace("/", "")
comAmount.Text = comAmount.Text.Replace("\", "")
comAmount.Text = comAmount.Text.Replace("[", "")
comAmount.Text = comAmount.Text.Replace("]", "")
comAmount.Text = comAmount.Text.Replace("|", "")
End If
GetTotal()
End Sub
Private Sub radCows_CheckedChanged(sender As Object, e As EventArgs) Handles radCows.CheckedChanged
GetTotal()
End Sub
Private Sub radSkimMilk_CheckedChanged(sender As Object, e As EventArgs) Handles radSkimMilk.CheckedChanged
GetTotal()
End Sub
Private Sub comAmount_SelectedValueChanged(sender As Object, e As EventArgs) Handles comAmount.SelectedValueChanged
GetTotal()
End Sub
Private Sub GetTotal()
Try
Dim ShippingRate As Double = My.Settings.IncreaseShippingRate
Dim strRing As String = ""
Dim strRPS As String = ""
RingTemp = comAmount.Text.Replace(",", "")
If radSkimMilk.Checked Then
RingTemp *= 256
RPSTemp = (RingTemp / 256) * 2
ElseIf radCows.Checked Then
RingTemp *= (15000 * 256)
RPSTemp = (RingTemp / 256)
End If
RingTemp *= ShippingRate
lblTotalRPS.Text = "Total RPS: " & UpdateNums(RPSTemp, strRPS)
lblTotalCost.Text = "Total Cost: " & UpdateNums(RingTemp, strRing)
Me.Refresh()
Catch ex As Exception
End Try
End Sub
Public Sub DoAnotherThing(ByRef Setting As Object)
Dim randomNumber As New Random
Dim r As Double = randomNumber.Next(60) - 2
If r < 0 Then r = 1
Dim Temp = Setting
r = 1 & "." & 0 & 1 & r
Temp *= r
Setting = Temp
End Sub
Public Function UpdateNums(ByRef Input As Decimal, ByRef Output As String)
Dim Temp As String = Input
Dim FirstNum As String
Dim SecondNum As String
Dim ThirdNum As String
Dim FourthNum As String
Dim NewNum As String
If Input > 10000000 Then
FirstNum = Temp(0)
SecondNum = Temp(1)
ThirdNum = Temp(2)
NewNum = FirstNum & SecondNum & "." & ThirdNum
Output = NewNum & "M"
If Input > 100000000 Then
FirstNum = Temp(0)
SecondNum = Temp(1)
ThirdNum = Temp(2)
FourthNum = Temp(3)
NewNum = FirstNum & SecondNum & ThirdNum & "." & FourthNum
Output = NewNum & "M"
If Input > 1000000000 Then
NewNum = FirstNum & "." & SecondNum & ThirdNum
Output = NewNum & "B"
If Input > 10000000000 Then
NewNum = FirstNum & SecondNum & "." & ThirdNum
Output = NewNum & "B"
If Input > 100000000000 Then
NewNum = FirstNum & SecondNum & ThirdNum & "." & FourthNum
Output = NewNum & "B"
If Input > 1000000000000 Then
NewNum = FirstNum & "." & SecondNum & ThirdNum & FourthNum
Output = NewNum & "T"
If Input > 10000000000000 Then
Output = 10 & "T+"
End If
End If
End If
End If
End If
End If
Else
Output = Format(Input, "N0") 'All of these are used to update Setting on the form
End If
Return Output
End Function
Private Sub frmCustomOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
GetTotal()
Me.Left = 339
Me.Top = 291
End Sub
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
Public Sub frmCustomOrder_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
If My.Settings.MessageOpen = True Then
frmMessage.Show()
frmMessage.Focus()
My.Settings.MessageOpen = False
Return
End If
frmMessage.Close()
End Sub
End Class