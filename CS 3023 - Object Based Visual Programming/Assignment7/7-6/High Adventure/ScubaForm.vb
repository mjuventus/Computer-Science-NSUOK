Public Class ScubaForm
    Private Sub btnCalcTotal_Click(sender As Object, e As EventArgs) Handles btnCalcTotal.Click
        ' Constant for the price per person for this package
        Const decSCUBA_PRICE_PER_PERSON As Decimal = 3000D

        ' Local variables
        Dim intNumberPeople As Integer ' Number of people
        Dim decDiscount As Decimal ' Amount of discount
        Dim decTotal As Decimal ' Total cost
        Try
            intNumberPeople = CInt(txtNumberPeople.Text)
            decTotal = intNumberPeople * decSCUBA_PRICE_PER_PERSON
            If intNumberPeople >= g_intMINIMUM_FOR_DISCOUNT Then
                decDiscount = CalcDiscount(decTotal)

                decTotal = decTotal - decDiscount
            Else
                decDiscount = 0D
            End If
            lblDiscount.Text = decDiscount.ToString("c")
            lblTotal.Text = decTotal.ToString("c")
        Catch ex As Exception
            MessageBox.Show("Enter a valid integer for number of people.")
        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' Clear the text box and the display labels.
        txtNumberPeople.Clear()
        lblDiscount.Text = String.Empty
        lblTotal.Text = String.Empty
        txtNumberPeople.Focus()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
