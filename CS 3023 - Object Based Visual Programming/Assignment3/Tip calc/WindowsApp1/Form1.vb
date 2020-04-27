Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dblBill As Double = 0.0
        Dim dblTip As Double = 0.0

        dblBill = CDbl(TextBox1.Text)

        dblTip = dblBill * 0.15

        Label2.Text = CStr(dblTip)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dblBill As Double = 0.0
        Dim dblTip As Double = 0.0

        dblBill = CDbl(TextBox1.Text)

        dblTip = dblBill * 0.2

        Label2.Text = CStr(dblTip)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim dblBill As Double = 0.0
        Dim dblTip As Double = 0.0

        dblBill = CDbl(TextBox1.Text)

        dblTip = dblBill * 0.25

        Label2.Text = CStr(dblTip)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class
