Public Class CurrentTripControl
    'Current Trip Control'

    Dim countDown As Integer = 0
    Public Sub Book()
        StartDestinationLabel.Text = RiderForm.riderBooking.FromLocation
        DestinationLabel.Text = RiderForm.riderBooking.ToLocation

    End Sub
    Private Sub BackBox_Click(sender As Object, e As EventArgs) Handles BackBox.Click
        Me.Hide()
        RiderForm.RiderMainScreen1.BringToFront()
        RiderForm.RiderMainScreen1.Show()
    End Sub

    Private Sub CarControlButton_Click(sender As Object, e As EventArgs) Handles CarControlButton.Click
        Me.Hide()
        RiderForm.RidereCarControl1.BringToFront()
        RiderForm.RidereCarControl1.Show()
    End Sub

    Private Sub StopTripButton_Click(sender As Object, e As EventArgs) Handles StopTripButton.Click
        RiderForm.RiderMainScreen1.tripStopped()
        Me.Hide()
        RiderForm.RiderMainScreen1.BringToFront()
        RiderForm.RiderMainScreen1.Show()
        RiderForm.riderBooking.Reset()
        RiderForm.RiderMainScreen1.resetAfterRide()
        Form1.OwnerMainScreen1.resetAfterRider()
        Me.ArrivedLabel.Hide()
        Form1.OwnerMainScreen1.inUseLabel.Hide()
        Form1.OwnerMainScreen1.BookATripButton.Enabled = True
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick

        countDown = countDown + 1000

        If countDown = 30000 Then

            RiderForm.riderBooking.RideEnded = True

            If RiderForm.riderBooking.RideEnded = True Then
                StopTripButton.Text = "Leave Car"

            End If
            ArrivedLabel.Show()
            ContinueTripButton.Enabled = True
            Timer.Stop()
        End If
    End Sub

    Private Sub TimerReset()
        countDown = 0
        RiderForm.riderBooking.RideEnded = False
        Timer.Start()
    End Sub
    Private Sub ModifyTripButton_Click(sender As Object, e As EventArgs) Handles ModifyTripButton.Click
        Me.Hide()
        RiderForm.ModifyTripControl1.BringToFront()
        RiderForm.ModifyTripControl1.Show()
    End Sub

    Private Sub ContinueTripButton_Click(sender As Object, e As EventArgs) Handles ContinueTripButton.Click
        StartDestinationLabel.Text = RiderForm.riderBooking.OldDestination
        DestinationLabel.Text = RiderForm.riderBooking.NewDestination
        RiderForm.riderBooking.RideEnded = False
        ArrivedLabel.Hide()
        ContinueTripButton.Hide()
        ContinueTripButton.Enabled = False
        StopTripButton.Text = "Stop Trip"
        RiderForm.CurrentTripControl1.NextDestIndicator.Hide()
        RiderForm.CurrentTripControl1.ModifiedDestLabel.Hide()
        Me.TimerReset()
        RiderForm.CurrentTripControl1.TitleLabel.Left = (RiderForm.CurrentTripControl1.TitleLabel.Parent.Width \ 2) - (RiderForm.CurrentTripControl1.TitleLabel.Width \ 2) - 3
        RiderForm.CurrentTripControl1.startLabel.Left = (RiderForm.CurrentTripControl1.startLabel.Parent.Width \ 2) - (RiderForm.CurrentTripControl1.startLabel.Width \ 2) - 3
        RiderForm.CurrentTripControl1.StartDestinationLabel.Left = (RiderForm.CurrentTripControl1.StartDestinationLabel.Parent.Width \ 2) - (RiderForm.CurrentTripControl1.StartDestinationLabel.Width \ 2) - 3
        RiderForm.CurrentTripControl1.endLabel.Left = (RiderForm.CurrentTripControl1.endLabel.Parent.Width \ 2) - (RiderForm.CurrentTripControl1.endLabel.Width \ 2) - 3
        RiderForm.CurrentTripControl1.DestinationLabel.Left = (RiderForm.CurrentTripControl1.DestinationLabel.Parent.Width \ 2) - (RiderForm.CurrentTripControl1.DestinationLabel.Width \ 2) - 3
        RiderForm.CurrentTripControl1.ArrivedLabel.Left = (RiderForm.CurrentTripControl1.ArrivedLabel.Parent.Width \ 2) - (RiderForm.CurrentTripControl1.ArrivedLabel.Width \ 2) - 3
    End Sub
End Class
