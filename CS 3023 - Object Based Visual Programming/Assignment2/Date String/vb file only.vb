Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextDate.KeyDown, TextDay.KeyDown, TextMonth.KeyDown, TextYear.KeyDown

        If e.KeyCode = Keys.Enter Then

            'do something here...
            btnShowData.PerformClick()
            e.SuppressKeyPress = True
        ElseIf e.KeyCode = Keys.Escape Then


            'do something here...
            btnExit.PerformClick()
            e.SuppressKeyPress = True
        End If

    End Sub




    Private Sub btnShowData_Click(sender As Object, e As EventArgs) Handles btnShowData.Click
        ' Concatenate the input and build the date string.
        LblDateString.Text = TextDay.Text & ", " &
        TextMonth.Text & " " &
        TextDate.Text & ", " &
        TextYear.Text
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        TextDay.Clear()
        TextMonth.Clear()
        TextDate.Clear()
        TextYear.Clear()
        LblDateString.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub TextDay_TextChanged(sender As Object, e As EventArgs) Handles TextDay.TextChanged

    End Sub

    Private Sub TextMonth_TextChanged(sender As Object, e As EventArgs) Handles TextMonth.TextChanged

    End Sub

    Private Sub TextDate_TextChanged(sender As Object, e As EventArgs) Handles TextDate.TextChanged

    End Sub

    Private Sub TextYear_TextChanged(sender As Object, e As EventArgs) Handles TextYear.TextChanged

    End Sub
End Class
