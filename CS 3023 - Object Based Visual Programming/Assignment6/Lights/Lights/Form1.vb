Public Class Form1
    Sub TurnLightOn()
        picLightOn.Visible = True
        ' Hide the "Light Off" image.
        picLightOff.Visible = False
        ' Change the label text.
        lblLightState.Text = "ON"
    End Sub

    Sub TurnLightOff()
        ' Display the "Light Off" image.
        picLightOff.Visible = True

        ' Hide the "Light On" image.
        picLightOn.Visible = False

        ' Change the label text.
        lblLightState.Text = "OFF"
    End Sub ' Display the "Light On" image.

    Private Sub btnSwitchLight_Click(sender As Object, e As EventArgs) Handles btnSwitchLight.Click
        ' Reverse the state of the light.
        If picLightOn.Visible = True Then
            TurnLightOff()
        Else
            TurnLightOn()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
