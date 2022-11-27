Public Class OwnerMainScreen
    Public timerStatus As Integer = 0
    Public kickOutTimer As Integer = 0
    Public cameraFailureResolved As Boolean = False
    Public breakInResolved As Boolean = False
    Public colisionResolved As Boolean = False
    Public isDriving As Boolean = False

    Public Function resetAfterRider()

        'Reseting Air Control Screen'
        Form1.AirControllScreen1.SettingClimateLabel.Hide()
        Form1.AirControllScreen1.AirControlLabel.Hide()
        Form1.AirControllScreen1.FanSpeedBar.Value = 0
        Form1.AirControllScreen1.FreshAirBox.PerformClick()

        'Owner Climate Control Screen'
        If Form1.ClimateControlScreen1.driverSeatOn Then
            Form1.ClimateControlScreen1.DriverSeat.Image = My.Resources.ProjectResources.heatedSeatOff
            Form1.ClimateControlScreen1.driverSeatOn = False
            Form1.ClimateControlScreen1.DriverLabel.ForeColor = Color.White
        End If
        If Form1.ClimateControlScreen1.passengerSeatOn Then
            Form1.ClimateControlScreen1.PassengerSeat.Image = My.Resources.ProjectResources.heatedSeatOff
            Form1.ClimateControlScreen1.passengerSeatOn = False
            Form1.ClimateControlScreen1.PassFRLabel.ForeColor = Color.White
        End If
        If Form1.ClimateControlScreen1.passengerLeftSeatOn Then
            Form1.ClimateControlScreen1.BackLeftPass.Image = My.Resources.ProjectResources.heatedSeatOff
            Form1.ClimateControlScreen1.passengerLeftSeatOn = False
            Form1.ClimateControlScreen1.PassBLLabel.ForeColor = Color.White
        End If
        If Form1.ClimateControlScreen1.passengerRightSeatOn Then
            Form1.ClimateControlScreen1.BackRightPass.Image = My.Resources.ProjectResources.heatedSeatOff
            Form1.ClimateControlScreen1.passengerRightSeatOn = False
            Form1.ClimateControlScreen1.PassBRLabel.ForeColor = Color.White
        End If
        If Form1.ClimateControlScreen1.frontOn Then
            Form1.ClimateControlScreen1.FrontDefrost.Image = My.Resources.ProjectResources.frontDefrost
            Form1.ClimateControlScreen1.frontOn = False
            Form1.ClimateControlScreen1.FrontDefrostLabel.ForeColor = Color.White
        End If
        If Form1.ClimateControlScreen1.rearOn Then
            Form1.ClimateControlScreen1.rearDefrost.Image = My.Resources.ProjectResources.rearDefrost
            Form1.ClimateControlScreen1.rearOn = False
            Form1.ClimateControlScreen1.RearDefrostLabel.ForeColor = Color.White
        End If


        'Trunk Open'
        If Form1.ECarControls.trunkOpen Then
            Form1.ECarControls.trunkOpen = False
            Form1.ECarControls.trunkButton.Image = My.Resources.ProjectResources.openTrunk
            Form1.ECarControls.trunkOCLabel.Text = "Trunk Closed"
        End If

        'Windows'
        Form1.WindowControl1.driverTrackBar.Value = 10
        Form1.WindowControl1.passFTrackBar.Value = 10
        Form1.WindowControl1.passBRTrackBar.Value = 10
        Form1.WindowControl1.passBLTrackBar.Value = 10

        'Media Controls'
        If Form1.MediaControls1.bluetoothOn Then
            Form1.MediaControls1.bluetoothOn = False
            Form1.MediaControls1.bluetoothBox.Image = My.Resources.ProjectResources.bluetoothOff
        End If
        If Form1.MediaControls1.radioOn Then
            Form1.MediaControls1.RadioStationLabel.Hide()
            Form1.MediaControls1.plusBox.Hide()
            Form1.MediaControls1.radioPlayingBox.Hide()
            Form1.MediaControls1.minusBox.Hide()
            Form1.MediaControls1.RadioBox.Image = My.Resources.ProjectResources.radio
            Form1.MediaControls1.radioOn = False
            Form1.MediaControls1.RadioBox.Left = 121
        End If

        Form1.MediaControls1.TrackBar1.Value = 0
        Form1.MediaControls1.audioLevelLabel.Hide()
        Form1.MediaControls1.AudioBox.Image = My.Resources.ProjectResources.audioMute
    End Function

    Private Sub MyCarButton_Click(sender As Object, e As EventArgs) Handles MyCarButton.Click
        Form1.ECarControls.carBox.Enabled = True
        Me.Hide()
        Form1.ECarControls.BringToFront()
        Form1.ECarControls.Show()
    End Sub

    Private Sub ScheduleButton_Click(sender As Object, e As EventArgs) Handles ScheduleButton.Click
        Me.Hide()
        Form1.CalendarControl1.BringToFront()
        Form1.CalendarControl1.Show()
    End Sub

    Private Sub BookingsButton_Click(sender As Object, e As EventArgs) Handles BookATripButton.Click
        Me.Hide()
        Form1.OwnerBookTrip1.BringToFront()
        Form1.OwnerBookTrip1.Show()
    End Sub

    Private Sub RatingsButton_Click(sender As Object, e As EventArgs) Handles RatingsButton.Click
        Me.Hide()
        Form1.RatingsControl1.BringToFront()
        Form1.RatingsControl1.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not Me.isDriving Then
            Me.timerStatus += 1
            If Me.timerStatus = 25 And Not Me.cameraFailureResolved Then
                Form1.cameraFailureBox.Show()
                Form1.cameraFailureBox.BringToFront()
                Me.cameraFailureResolved = True
            ElseIf Me.timerStatus = 85 And Not Me.breakInResolved Then
                Form1.breakInBox.Show()
                Form1.breakInBox.BringToFront()
                Me.breakInResolved = True
            ElseIf Me.timerStatus = 155 And Not Me.colisionResolved Then
                Form1.collisionBox.Show()
                Form1.collisionBox.BringToFront()
                Me.colisionResolved = True
                Me.Timer1.Stop()
            End If
        End If
    End Sub

    Private Sub kickOutButton_Click(sender As Object, e As EventArgs) Handles kickOutButton.Click
        RiderForm.CurrentTripControl1.StopTripButton.PerformClick()
        RiderForm.kickedOutBox.BringToFront()
        RiderForm.kickedOutBox.Show()
        Me.Timer2.Start()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.kickOutTimer += 1
        If Me.kickOutTimer >= 6 Then
            RiderForm.kickedOutBox.SendToBack()
            RiderForm.kickedOutBox.Hide()
            RiderForm.rejectedBox.SendToBack()
            RiderForm.rejectedBox.Hide()
            Me.kickOutTimer = 0
            Me.Timer2.Stop()
        End If
    End Sub


End Class
