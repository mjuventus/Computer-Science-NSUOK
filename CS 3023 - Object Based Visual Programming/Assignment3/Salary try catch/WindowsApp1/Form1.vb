Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim decAnnualSalary As Decimal ' Annual salary
        Dim intPayPeriods As Integer ' Number of pay periods
        Dim decSalary As Decimal ' Salary per pay period

        Try
            ' Get the annual salary and number of pay periods.
            decAnnualSalary = CDec(TextBox1.Text)
            intPayPeriods = CInt(TextBox2.Text)

            ' Calculate the salary per pay period.
            decSalary = decAnnualSalary / intPayPeriods

            ' Display the salary per pay period.
            Label4.Text = decSalary.ToString("c")

        Catch
            ' Display an error message.
            MessageBox.Show("Error: Be sure to enter nonzero " &
 "numeric values.")
        End Try
    End Sub
End Class
