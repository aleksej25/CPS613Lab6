Public Class RiderMainScreen
    'Rider Main Screen'
    Public Sub bookCheck()
        If RiderForm.riderBooking.BookingStatus = True Then
            StatusLabel.Text = "On trip"
            StatusLabel.ForeColor = Color.Green
            CurrentTripButton.Enabled = True
            CurrentTripButton.Show()
            BookTripButton.Enabled = False
        End If
    End Sub

    Public Sub tripStopped()
        StatusLabel.Text = "Not on trip"
        StatusLabel.ForeColor = Color.Red
        CurrentTripButton.Enabled = False
        CurrentTripButton.Hide()
        BookTripButton.Enabled = True
        RiderForm.riderBooking.Reset()
    End Sub

    Private Sub BookTripButton_Click(sender As Object, e As EventArgs) Handles BookTripButton.Click
        Me.Hide()
        RiderForm.BookTripScreen1.BringToFront()
        RiderForm.BookTripScreen1.Show()
    End Sub

    Private Sub RiderRatingsButton_Click(sender As Object, e As EventArgs) Handles RiderRatingsButton.Click
        Me.Hide()
        RiderForm.RiderRatingsControl1.BringToFront()
        RiderForm.RiderRatingsControl1.Show()
    End Sub

    Private Sub CurrentTripButton_Click(sender As Object, e As EventArgs) Handles CurrentTripButton.Click
        Me.Hide()
        RiderForm.CurrentTripControl1.BringToFront()
        RiderForm.CurrentTripControl1.Show()
    End Sub

End Class
