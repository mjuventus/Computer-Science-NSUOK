Public Class MainForm
    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub

    Private Sub mnuPackageScuba_Click(sender As Object, e As EventArgs) Handles mnuPackageScuba.Click
        Dim frmScuba As New ScubaForm
        frmScuba.ShowDialog()
    End Sub

    Private Sub mnuPackageSkyDiving_Click(sender As Object, e As EventArgs) Handles mnuPackageSkyDiving.Click
        Dim frmScuba As New SkyDiveForm
        frmScuba.ShowDialog()
    End Sub

    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        MessageBox.Show("High Adventure Travel Price Quote System Version 1.0")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class