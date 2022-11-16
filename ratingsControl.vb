Public Class ratingsControl
    Private Sub BackBox_Click(sender As Object, e As EventArgs) Handles BackBox.Click
        Me.Hide()
        Form1.OwnerMainScreen1.BringToFront()
        Form1.OwnerMainScreen1.Show()
    End Sub
End Class
