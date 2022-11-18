Public Class OwnerBookTrip
    Private Sub BackBox_Click(sender As Object, e As EventArgs) Handles BackBox.Click
        Me.Hide()
        Form1.OwnerMainScreen1.BringToFront()
        Form1.OwnerMainScreen1.Show()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles laterButton.CheckedChanged
        EndLabel.Show()
        EndBox.Show()
    End Sub

    Private Sub NowButton_CheckedChanged(sender As Object, e As EventArgs) Handles NowButton.CheckedChanged
        EndLabel.Hide()
        EndBox.Hide()
    End Sub

    Private Sub DriveButton_Click(sender As Object, e As EventArgs) Handles DriveButton.Click
        Form1.OwnerCurrentTrip1.StartDestLabel.Text = FromBox.Text
        Form1.OwnerCurrentTrip1.OwnerDestLabel.Text = ToBox.Text
        Form1.OwnerCurrentTrip1.OwnerTimer.Start()

        Form1.OwnerMainScreen1.isDriving = True


        Form1.OwnerCurrentTrip1.TitleLabel.Left = (Form1.OwnerCurrentTrip1.TitleLabel.Parent.Width \ 2) - (Form1.OwnerCurrentTrip1.TitleLabel.Width \ 2) - 3
        Form1.OwnerCurrentTrip1.startLabel.Left = (Form1.OwnerCurrentTrip1.startLabel.Parent.Width \ 2) - (Form1.OwnerCurrentTrip1.startLabel.Width \ 2) - 3
        Form1.OwnerCurrentTrip1.StartDestLabel.Left = (Form1.OwnerCurrentTrip1.StartDestLabel.Parent.Width \ 2) - (Form1.OwnerCurrentTrip1.StartDestLabel.Width \ 2) - 3
        Form1.OwnerCurrentTrip1.endLabel.Left = (Form1.OwnerCurrentTrip1.endLabel.Parent.Width \ 2) - (Form1.OwnerCurrentTrip1.endLabel.Width \ 2) - 3
        Form1.OwnerCurrentTrip1.OwnerDestLabel.Left = (Form1.OwnerCurrentTrip1.OwnerDestLabel.Parent.Width \ 2) - (Form1.OwnerCurrentTrip1.OwnerDestLabel.Width \ 2) - 3
        Form1.OwnerCurrentTrip1.OwnerArrivedLabel.Left = (Form1.OwnerCurrentTrip1.OwnerArrivedLabel.Parent.Width \ 2) - (Form1.OwnerCurrentTrip1.OwnerArrivedLabel.Width \ 2) - 3

        Form1.OwnerCurrentTrip1.OwnerModifyTripButton.Location = New Point(46, 417)
        Form1.OwnerCurrentTrip1.ManualDrivingButton.Location = New Point(172, 417)
        Form1.OwnerCurrentTrip1.OwnerCarControlsBtn.Location = New Point(46, 496)
        Form1.OwnerCurrentTrip1.OwnerStopTrip.Location = New Point(172, 496)


        Form1.OwnerCurrentTrip1.OwnerModifyTripButton.Show()
        Form1.OwnerCurrentTrip1.ManualDrivingButton.Show()
        Form1.OwnerCurrentTrip1.OwnerCarControlsBtn.Show()
        Form1.OwnerCurrentTrip1.OwnerStopTrip.Show()

        Me.FromBox.Text = ""
        Me.ToBox.Text = ""
        Me.NowButton.Checked = False
        Me.laterButton.Checked = False
        Me.EndBox.Text = ""
        Me.EndLabel.Hide()

        Me.Hide()
        Form1.OwnerCurrentTrip1.BringToFront()
        Form1.OwnerCurrentTrip1.Show()
    End Sub
End Class
