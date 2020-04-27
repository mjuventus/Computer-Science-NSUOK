Public Class Form1
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged


    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strInput As String ' Holds selected month and year
        If ListBox1.SelectedIndex = -1 Then
            ' No month is selected
            MessageBox.Show("Select a month.")
        ElseIf ListBox2.SelectedIndex = -1 Then
            ' No year is selected
            MessageBox.Show("Select a year.")

        Else
            ' Get the selected month and year
            strInput = ListBox1.SelectedItem.ToString() &
                " " & ListBox2.SelectedItem.ToString()
            MessageBox.Show(strInput)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Reset the list boxes.
        ListBox1.SelectedIndex = -1
        ListBox2.SelectedIndex = -1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items().Remove(3)
    End Sub
End Class
