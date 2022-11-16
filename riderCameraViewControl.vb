Public Class riderCameraViewControl
    Private Sub BackBox_Click(sender As Object, e As EventArgs) Handles BackBox.Click
        Me.Hide()
        RiderForm.RiderCarStatusControl1.BringToFront()
        RiderForm.RiderCarStatusControl1.Show()
    End Sub
End Class
