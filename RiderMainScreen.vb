Public Class RiderMainScreen
    'Rider Main Screen'

    Public Function resetAfterRide()
        'Reseting Air Control Screen'
        RiderForm.RiderAirControl1.SettingClimateLabel.Hide()
        RiderForm.RiderAirControl1.AirControlLabel.Hide()
        RiderForm.RiderAirControl1.FanSpeedBar.Value = 0

        'Rider Climate Control Screen'
        If RiderForm.RiderClimateControl1.driverSeatOn Then
            RiderForm.RiderClimateControl1.DriverSeat.Image = My.Resources.ProjectResources.heatedSeatOff
            RiderForm.RiderClimateControl1.driverSeatOn = False
            RiderForm.RiderClimateControl1.DriverLabel.ForeColor = Color.White
        End If
        If RiderForm.RiderClimateControl1.passengerSeatOn Then
            RiderForm.RiderClimateControl1.PassengerSeat.Image = My.Resources.ProjectResources.heatedSeatOff
            RiderForm.RiderClimateControl1.passengerSeatOn = False
            RiderForm.RiderClimateControl1.PassFRLabel.ForeColor = Color.White
        End If
        If RiderForm.RiderClimateControl1.passengerLeftSeatOn Then
            RiderForm.RiderClimateControl1.BackLeftPass.Image = My.Resources.ProjectResources.heatedSeatOff
            RiderForm.RiderClimateControl1.passengerLeftSeatOn = False
            RiderForm.RiderClimateControl1.PassBLLabel.ForeColor = Color.White
        End If
        If RiderForm.RiderClimateControl1.passengerRightSeatOn Then
            RiderForm.RiderClimateControl1.BackRightPass.Image = My.Resources.ProjectResources.heatedSeatOff
            RiderForm.RiderClimateControl1.passengerRightSeatOn = False
            RiderForm.RiderClimateControl1.PassBRLabel.ForeColor = Color.White
        End If
        If RiderForm.RiderClimateControl1.frontOn Then
            RiderForm.RiderClimateControl1.FrontDefrost.Image = My.Resources.ProjectResources.frontDefrost
            RiderForm.RiderClimateControl1.frontOn = False
            RiderForm.RiderClimateControl1.FrontDefrostLabel.ForeColor = Color.White
        End If
        If RiderForm.RiderClimateControl1.rearOn Then
            RiderForm.RiderClimateControl1.rearDefrost.Image = My.Resources.ProjectResources.rearDefrost
            RiderForm.RiderClimateControl1.rearOn = False
            RiderForm.RiderClimateControl1.RearDefrostLabel.ForeColor = Color.White
        End If

        'Trunk Open'
        If RiderForm.RidereCarControl1.trunkOpen Then
            RiderForm.RidereCarControl1.trunkOpen = False
            RiderForm.RidereCarControl1.trunkButton.Image = My.Resources.ProjectResources.openTrunk
            RiderForm.RidereCarControl1.trunkOCLabel.Text = "Trunk Closed"
        End If

        'Windows'
        RiderForm.RiderWindowControl1.driverTrackBar.Value = 10
        RiderForm.RiderWindowControl1.passFTrackBar.Value = 10
        RiderForm.RiderWindowControl1.passBRTrackBar.Value = 10
        RiderForm.RiderWindowControl1.passBLTrackBar.Value = 10

        'Media Controls'
        If RiderForm.RiderMediaControls1.bluetoothOn Then
            RiderForm.RiderMediaControls1.bluetoothOn = False
            RiderForm.RiderMediaControls1.bluetoothBox.Image = My.Resources.ProjectResources.bluetoothOff
        End If
        If RiderForm.RiderMediaControls1.radioOn Then
            RiderForm.RiderMediaControls1.RadioStationLabel.Hide()
            RiderForm.RiderMediaControls1.plusBox.Hide()
            RiderForm.RiderMediaControls1.radioPlayingBox.Hide()
            RiderForm.RiderMediaControls1.minusBox.Hide()
            RiderForm.RiderMediaControls1.RadioBox.Image = My.Resources.ProjectResources.radio
            RiderForm.RiderMediaControls1.radioOn = False
            RiderForm.RiderMediaControls1.RadioBox.Left = 121
        End If

        RiderForm.RiderMediaControls1.TrackBar1.Value = 0
        RiderForm.RiderMediaControls1.audioLevelLabel.Hide()
        RiderForm.RiderMediaControls1.AudioBox.Image = My.Resources.ProjectResources.audioMute
    End Function

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
