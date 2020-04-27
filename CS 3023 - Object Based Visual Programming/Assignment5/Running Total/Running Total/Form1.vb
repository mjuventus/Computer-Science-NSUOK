Public Class Form1

    Private Sub btnEnterSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnterSales.Click
        Const intNUM_DAYS As Integer = 5 ' The number of days
        Dim intCount As Integer = 1 ' Loop counter
        Dim decSales As Decimal = 0 ' To hold daily sales
        Dim decTotal As Decimal = 0 ' To hold the total sales
        Dim strInput As String

        Do While intCount <= intNUM_DAYS

            strInput = InputBox("Enter the sales for day " &
                                intCount.ToString())
            If Decimal.TryParse(strInput, decSales) Then
                decTotal += decSales
                intCount += 1
            Else
                MessageBox.Show("Enter a numeric value.")
            End If
        Loop

        lblTotal.Text = decTotal.ToString("c")
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
