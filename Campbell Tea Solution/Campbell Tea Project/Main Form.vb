'Project name:                  Campbell Tea Project
'Purpose:                       To determine the total price of total tea boxes ordered.
'Created/modified by:           Kris Arandia on 5/21/2016


Option Infer Off
Option Strict On
Option Explicit On

Public Class MainForm

    Dim salesTax As Double

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub GetSalesTax()
        'asks the user if 5% sales tax is applicable. If yes, apply 5% sales tax, if not, sales tax is 0

        Dim answer As DialogResult
        answer = MessageBox.Show("Is sales tax applicable to your purchase?", "Sales Tax", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If answer = DialogResult.Yes Then
            salesTax = 0.05
        Else
            salesTax = 0.0
        End If
    End Sub

    Private Function GetTotalBox(ByRef teaBoxTotal As Integer) As Integer
        'get and display total boxes

        Dim teaBB As Integer    'breakfast blend
        Dim teaCh As Integer    'chamomile
        Dim teaCG As Integer    'citrus green
        Dim teaEG As Integer    'earl gray
        Dim teaSC As Integer    'spiced chai

        Integer.TryParse(BBTextBox.Text, teaBB)
        Integer.TryParse(ChTextBox.Text, teaCh)
        Integer.TryParse(CGTextBox.Text, teaCG)
        Integer.TryParse(EGTextBox.Text, teaEG)
        Integer.TryParse(SCTextBox.Text, teaSC)

        'calculate and display total tea box
        teaBoxTotal = teaBB + teaCh + teaCG + teaEG + teaSC
        totalBoxesDisplay.Text = teaBoxTotal

        Return teaBoxTotal
    End Function

    Private Function GetTeaPrices(ByRef teaPrice As Double, ByVal numTea As Integer) As Double
        'identify the tea prices based amount ordered
        Dim pricePerUnit As Double
        If numTea > 0 AndAlso numTea <= 5 Then
            pricePerUnit = 6.95
        ElseIf numTea > 5 AndAlso numTea <= 10 Then
            pricePerUnit = 5.95
        Else
            pricePerUnit = 4.95
        End If

        'subtotal for boxes
        teaPrice = pricePerUnit * numTea

        Return teaPrice
    End Function

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        'calculates total price for tea boxes and total price with tax
        Dim totalBoxes As Integer
        Dim subtotal As Double
        Dim totalPrice As Double
        Dim salesTaxAmount As Double

        GetTotalBox(totalBoxes)
        GetTeaPrices(subtotal, totalBoxes)
        GetSalesTax()

        'compute and display sales tax amount
        salesTaxAmount = salesTax * subtotal
        salesTaxDisplay.Text = salesTaxAmount.ToString("C2")

        'compute and get total price
        totalPrice = subtotal + salesTaxAmount
        totalPriceDisplay.Text = totalPrice.ToString("C2")
    End Sub

    Private Sub clrButton_Click(sender As Object, e As EventArgs) Handles clrButton.Click
        'clear boxes
        totalBoxesDisplay.Text = String.Empty
        salesTaxDisplay.Text = String.Empty
        totalPriceDisplay.Text = String.Empty
        BBTextBox.Clear()
        ChTextBox.Clear()
        CGTextBox.Clear()
        EGTextBox.Clear()
        SCTextBox.Clear()
    End Sub


    Private Sub BBTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BBTextBox.KeyPress, ChTextBox.KeyPress, CGTextBox.KeyPress, EGTextBox.KeyPress, SCTextBox.KeyPress
        'allow numeric inputs and backspace only

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If

    End Sub

End Class
