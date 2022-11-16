Public Class riderCarStatusControl
    Private Sub BackBox_Click(sender As Object, e As EventArgs) Handles BackBox.Click
        Me.Hide()
        RiderForm.RidereCarControl1.BringToFront()
        RiderForm.RidereCarControl1.Show()
    End Sub

    Private Sub cameraBox_Click(sender As Object, e As EventArgs) Handles cameraBox.Click
        If interiorButton.Checked Then
            RiderForm.RiderCameraViewControl1.PictureBox1.Image = My.Resources.ProjectResources.camInside
        ElseIf exteriorButton.Checked Then
            RiderForm.RiderCameraViewControl1.PictureBox1.Image = My.Resources.ProjectResources.camOutside
        End If
        Me.Hide()
        RiderForm.RiderCameraViewControl1.BringToFront()
        RiderForm.RiderCameraViewControl1.Show()
    End Sub

    Private Sub mapBox_Click(sender As Object, e As EventArgs) Handles mapBox.Click
        RiderForm.RiderCameraViewControl1.PictureBox1.Image = My.Resources.ProjectResources.carLocation
        Me.Hide()
        RiderForm.RiderCameraViewControl1.BringToFront()
        RiderForm.RiderCameraViewControl1.Show()
    End Sub
End Class
