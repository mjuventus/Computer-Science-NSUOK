Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Label1.Text = "click me") Then
            Label1.Text = "Hello World!"
            Button1.Text = "Self-Destruct"
        Else
            Label1.Text = "click me"
            Button1.Text = "Self-Construct"
        End If

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (Label2.Text = "check count") Then
            Label2.Text = "Test!"
        ElseIf (Label2.Text = "Test! Test! Test!") Then
            Label2.Text = "check count"

            Else
            Label2.Text = Label2.Text + " Test!"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label3.Text = Label3.Text + 1

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label3.Text = 0
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (Label4.Text > 0) Then
            Label4.Text = Label4.Text - 1
        Else
            Label4.Text = 0
        End If




    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Label4.Text = 16
    End Sub
End Class
