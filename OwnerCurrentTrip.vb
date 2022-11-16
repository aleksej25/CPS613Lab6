Public Class OwnerCurrentTrip

    Public Shared OwnerTrip As Boolean = False
    Dim OwnerCountdown As Integer = 0
    Private Sub ManualDrivingButton_Click(sender As Object, e As EventArgs) Handles ManualDrivingButton.Click
        If ManualDrivingButton.ForeColor = Color.Green Then
            ManualDrivingButton.ForeColor = Color.Black
        Else
            ManualDrivingButton.ForeColor = Color.Green
        End If
    End Sub

    Private Sub OwnerCarControlsBtn_Click(sender As Object, e As EventArgs) Handles OwnerCarControlsBtn.Click
        Me.Hide()
        OwnerTrip = True
        Form1.ECarControls.BringToFront()
        Form1.ECarControls.Show()
    End Sub

    Private Sub OwnerTimer_Tick(sender As Object, e As EventArgs) Handles OwnerTimer.Tick
        OwnerCountdown = OwnerCountdown + 1000
        If OwnerCountdown = 30000 Then
            OwnerArrivedLabel.Show()
            OwnerStopTrip.Text = "Leave Car"
            OwnerTimer.Stop()
            Me.OwnerModifyTripButton.Hide()
            Me.ManualDrivingButton.Hide()
            Me.OwnerStopTrip.Location = New Point(109, 417)
            Me.OwnerCarControlsBtn.Location = New Point(109, 496)
        End If
    End Sub

    Private Sub OwnerStopTrip_Click(sender As Object, e As EventArgs) Handles OwnerStopTrip.Click
        OwnerTimer.Stop()
        Form1.OwnerMainScreen1.isDriving = False
        OwnerCountdown = 0
        OwnerArrivedLabel.Hide()
        Me.Hide()
        Form1.OwnerMainScreen1.BringToFront()
        Form1.OwnerMainScreen1.Show()
        Form1.OwnerMainScreen1.Timer1.Start()
        Form1.OwnerMainScreen1.resetAfterRider()

    End Sub
End Class
