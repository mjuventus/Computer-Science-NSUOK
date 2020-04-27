Public Class Form1
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dblScore1 As Double
        Dim dblScore2 As Double
        Dim dblScore3 As Double
        Dim dblAverage As Double
        ' Constants
        Const NUM_SCORES As Integer = 3
        Const dblHIGH_SCORE As Double = 95.0
        Try
            ' Assign the TextBox scores to the variables.
            dblScore1 = CDbl(TextBox1.Text)
            dblScore2 = CDbl(TextBox2.Text)
            dblScore3 = CDbl(TextBox3.Text)
            ' Calculate the average score.

            dblAverage = (dblScore1 + dblScore2 + dblScore3) / NUM_SCORES
            ' Display the average, rounded to 2 decimal places.
            Label5.Text = dblAverage.ToString("n2")


            If dblAverage < 60 Then
                Label8.Text = "F"
            ElseIf dblAverage < 70 Then
                Label8.Text = "D"
            ElseIf dblAverage < 80 Then
                Label8.Text = "C"
            ElseIf dblAverage < 90 Then
                Label8.Text = "B"
            ElseIf dblAverage <= 100 Then
                Label8.Text = "A"
            End If



            ' If the score is high, compliment the student.

            If dblAverage > dblHIGH_SCORE Then
                Label6.Text = "Congratulations! Great Job!"
            Else
                Label6.Text = "Keep trying!"
            End If
 Catch
            ' Display an error message.
            Label6.Text = "Scores must be numeric."
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        Label5.Text = ""
        Label6.Text = ""
        Label8.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class







