Public Class ModifyTripControl

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ToLocationBox.Items.Add("123 Queen St")
        ToLocationBox.Items.Add("Greek Restaurant")
        ToLocationBox.Items.Add("123 King St")

        EndTimeBox.Items.Add("11:00AM")
        EndTimeBox.Items.Add("12:00PM")
        EndTimeBox.Items.Add("1:00PM")
        EndTimeBox.Items.Add("2:00PM")
        EndTimeBox.Items.Add("3:00PM")
        EndTimeBox.Items.Add("4:00PM")
        EndTimeBox.Items.Add("5:00PM")

    End Sub
    Private Sub BackBox_Click(sender As Object, e As EventArgs) Handles BackBox.Click
        Me.Hide()
        RiderForm.CurrentTripControl1.BringToFront()
        RiderForm.CurrentTripControl1.Show()
    End Sub

    Private Sub ChangeButton_Click(sender As Object, e As EventArgs) Handles ChangeButton.Click
        RiderForm.riderBooking.TripModified = True
        RiderForm.riderBooking.OldDestination = RiderForm.riderBooking.ToLocation
        RiderForm.riderBooking.NewDestination = Me.ToLocationBox.Text
        RiderForm.CurrentTripControl1.ModifiedDestLabel.Text = RiderForm.riderBooking.NewDestination
        RiderForm.CurrentTripControl1.ContinueTripButton.Show()
        RiderForm.CurrentTripControl1.NextDestIndicator.Show()
        RiderForm.CurrentTripControl1.ModifiedDestLabel.Show()
        Me.Hide()
        RiderForm.CurrentTripControl1.BringToFront()
        RiderForm.CurrentTripControl1.Show()
        Form1.Tripedit1.tripdetails.Text = "New destination: " + RiderForm.riderBooking.NewDestination + vbCrLf + "New end time: " + Me.EndTimeBox.Text
    End Sub
End Class
