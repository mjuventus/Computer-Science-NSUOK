Public Class Form1

    Const dblMONTHS_YEAR As Double = 12 ' Months per year
    Const dblNEW_RATE As Double = 0.05 ' Interest rate, new cars
    Const dblUSED_RATE As Double = 0.08 ' Interest rate, used cars
    ' Class-level variable to hold the annual interest rate
    Dim dblAnnualRate As Double = dblNEW_RATE








    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btcCalculate_Click(sender As Object, e As EventArgs) Handles btcCalculate.Click
        Dim dblVehicleCost As Double ' Vehicle cost
        Dim dblDownPayment As Double ' Down payment
        Dim intMonths As Integer ' Number of months for the loan

        Dim dblLoan As Double ' Amount of the loan
        Dim dblMonthlyPayment As Double ' Monthly payment
        Dim dblInterest As Double ' Interest paid for the period
        Dim dblPrincipal As Double ' Principal paid for the period
        Dim intCount As Integer ' Counter for the loop
        Dim strOut As String ' Used to hold a line of output
        Dim blnInputOk As Boolean = True

        If Not Double.TryParse(TxtCost.Text, dblVehicleCost) Then
            lblMessage.Text = "Vehicle cost must be a number"
            blnInputOk = False
        End If
        If Not Double.TryParse(TxtDownPayment.Text, dblDownPayment) Then
            lblMessage.Text = "Down Payment must be a number"
            blnInputOk = False
        End If

        If Not Integer.TryParse(TxtMonths.Text, intMonths) Then
            lblMessage.Text = "Months must be an integer"

            blnInputOk = False

        End If
        If blnInputOk = True Then
            dblLoan = dblVehicleCost - dblDownPayment
            dblMonthlyPayment = Pmt(dblAnnualRate / dblMONTHS_YEAR,
            intMonths, -dblLoan)
            lstOutput.Items.Clear()
            lblMessage.Text = String.Empty


            For intCount = 1 To intMonths
                ' Calculate the interest for this period.
                dblInterest = IPmt(dblAnnualRate / dblMONTHS_YEAR,
 intCount, intMonths, -dblLoan)

                ' Calculate the principal for this period.
                dblPrincipal = PPmt(dblAnnualRate / dblMONTHS_YEAR,
 intCount, intMonths, -dblLoan)

                ' Start building the output string with the month.
                strOut = "Month " & intCount.ToString("d2")

                ' Add the payment amount to the output string
                strOut &= ": payment = " & dblMonthlyPayment.ToString("n2")

                ' Add the interest amount to the output string.
                strOut &= ", interest = " & dblInterest.ToString("n2")

                ' Add the principal for the period.
                strOut &= ", principal = " & dblPrincipal.ToString("n2")

                ' Add the output string to the list box
                lstOutput.Items.Add(strOut)
            Next
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Reset the interest rate.
        dblAnnualRate = dblNEW_RATE
        ' Clear the text boxes
        TxtCost.Clear()
        TxtDownPayment.Clear()
        TxtMonths.Clear()
        ' Clear the list box.
        lstOutput.Items.Clear()
        ' Set default interest rate for new car loans.
        lblAnnualRate.Text = dblNEW_RATE.ToString("p")
        RadNew.Checked = True
        ' Clear any error messages.
        lblMessage.Text = String.Empty
        ' Reset the focus to txtCost.
        TxtCost.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()

    End Sub

    Private Sub RadNew_CheckedChanged(sender As Object, e As EventArgs) Handles RadNew.CheckedChanged
        ' If the New radio button is checked, then
        ' the user has selected a new car loan.
        If RadNew.Checked = True Then
            dblAnnualRate = dblNEW_RATE
            lblAnnualRate.Text = dblNEW_RATE.ToString("p")
            lstOutput.Items.Clear()
        End If
    End Sub

    Private Sub RadUsed_CheckedChanged(sender As Object, e As EventArgs) Handles RadUsed.CheckedChanged
        ' If the Used radio button is checked, then
        ' the user has selected a used car loan.
        If RadUsed.Checked = True Then
            dblAnnualRate = dblUSED_RATE
            lblAnnualRate.Text = dblUSED_RATE.ToString("p")
            lstOutput.Items.Clear()
        End If
    End Sub
End Class
