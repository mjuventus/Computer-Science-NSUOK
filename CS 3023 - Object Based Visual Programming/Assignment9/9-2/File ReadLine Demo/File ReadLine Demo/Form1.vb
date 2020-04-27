Imports System.IO

Public Class Form1

    Private Sub btnRead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRead.Click
        ' Constant for the number of friends
        Const intNUM_FRIENDS As Integer = 3

        ' Local variables
        Dim friendFile As StreamReader  ' Object variable
        Dim strFilename As String       ' File name
        Dim strFriend As String         ' Name of a friend
        Dim strPhone As String          ' To hold a phone number
        Dim intCount As Integer         ' Loop counter

        ' Get the file name from the user.
        strFilename = InputBox("Enter the filename.")

		Try
			' Open the file.
			friendFile = File.OpenText(strFilename)

			' Read the data.
			For intCount = 1 To intNUM_FRIENDS
				' Read a name and phone number from the file.
				strFriend = friendFile.ReadLine()
				strPhone = friendFile.ReadLine()

				' Display the data in the list box.
				lstFriends.Items.Add("Friend Number " & intCount.ToString())
				lstFriends.Items.Add("Name: " & strFriend)
				lstFriends.Items.Add("Phone: " & strPhone)
				lstFriends.Items.Add("") ' Add a blank line

				' Alternate display, using Tabs
				'lstFriends.Items.Add("Friend Number " & vbTab & intCount.ToString())
				'lstFriends.Items.Add("Name: " & vbTab & vbTab & strFriend)
				'lstFriends.Items.Add("Phone: " & vbTab & vbTab & strPhone)
				'lstFriends.Items.Add("") ' Add a blank line

			Next intCount


			' Close the file.
			friendFile.Close()
		Catch
			MessageBox.Show("That file cannot be opened.")
		End Try
    End Sub

    Private Sub btnlear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear the list box.
        lstFriends.Items.Clear()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
