Public Class Form3
    Public Shared econrate As Decimal = 0.75
    Public Shared standrate As Decimal = 1.0
    Public Shared luxrate As Decimal = 1.75
    Public Shared subtcost As Decimal
    Public Shared costLessUC As Decimal
    Public Shared tcost As Decimal
    Public Shared vat As Decimal

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles undercoat.CheckedChanged
        If undercoat.CheckState = CheckState.Checked Then
            'store original paint cost
            costLessUC = subtcost
            'add the undercoat cost
            subtcost = subtcost + (Form2.area * 0.5)
            CostCalc.Text = FormatCurrency(subtcost)

        Else

            'reassigns the orgional value 
            subtcost = costLessUC
            CostCalc.Text = FormatCurrency(subtcost)
        End If

    End Sub


    Private Sub luxbutton_Click(sender As Object, e As EventArgs) Handles luxbutton.Click
        subtcost = Form2.area * luxrate
        CostCalc.Text = FormatCurrency(subtcost)

    End Sub

    Private Sub standardbutton_Click(sender As Object, e As EventArgs) Handles standardbutton.Click
        subtcost = Form2.area * standrate
        CostCalc.Text = FormatCurrency(subtcost)

    End Sub

    Private Sub econbutton_Click(sender As Object, e As EventArgs) Handles econbutton.Click
        subtcost = Form2.area * econrate
        CostCalc.Text = FormatCurrency(subtcost)

    End Sub

    Private Sub billbutton_Click(sender As Object, e As EventArgs) Handles billbutton.Click
        vat = subtcost * 0.2
        tcost = subtcost + vat
        ' MsgBox("the quote for today is " & Format(costc, "currency"))
        MsgBox("The subtotal is " & FormatCurrency(subtcost) & vbCr &
               "The VAT is " & FormatCurrency(vat) & vbCr &
               "The Total is " & FormatCurrency(tcost) & vbCr &
               "Today's Date is " & Format(Date.Now(), "dd MMM yyyy"))
    End Sub

End Class