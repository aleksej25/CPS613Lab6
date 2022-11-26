Public Class ModifyTripControl
    Public Generator As System.Random = New System.Random()
    Public extraCost As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ToLocationBox.Items.Add("123 Queen St")
        ToLocationBox.Items.Add("Greek Restaurant")
        ToLocationBox.Items.Add("123 King St")

    End Sub
    Private Sub BackBox_Click(sender As Object, e As EventArgs) Handles BackBox.Click
        Me.Hide()
        RiderForm.CurrentTripControl1.BringToFront()
        RiderForm.CurrentTripControl1.Show()
    End Sub

    Private Sub ChangeButton_Click(sender As Object, e As EventArgs) Handles ChangeButton.Click
        If Me.addLegButton.Checked Then
            RiderForm.riderBooking.TripModified = True
            RiderForm.riderBooking.OldDestination = RiderForm.riderBooking.ToLocation
            RiderForm.riderBooking.NewDestination = Me.ToLocationBox.Text
            RiderForm.CurrentTripControl1.ModifiedDestLabel.Text = RiderForm.riderBooking.NewDestination
            RiderForm.CurrentTripControl1.ContinueTripButton.Show()
            RiderForm.CurrentTripControl1.NextDestIndicator.Show()
            RiderForm.CurrentTripControl1.ModifiedDestLabel.Show()
        End If
        If newDestButton.Checked Then
            RiderForm.CurrentTripControl1.DestinationLabel.Text = Me.ToLocationBox.Text
            RiderForm.CurrentTripControl1.DestinationLabel.Left = (RiderForm.CurrentTripControl1.DestinationLabel.Parent.Width \ 2) - (RiderForm.CurrentTripControl1.DestinationLabel.Width \ 2) - 3
            RiderForm.CurrentTripControl1.countDown = 0
        End If
        Form1.rideupdated.Show()
        Form1.rideupdated.BringToFront()
        Me.Hide()
        Me.ChangeButton.Hide()
        Me.costLabel.Hide()
        RiderForm.CurrentTripControl1.BringToFront()
        RiderForm.CurrentTripControl1.Show()
        Form1.Tripedit1.tripdetails.Text = "New destination: " + RiderForm.riderBooking.NewDestination
    End Sub

    Private Sub addLegButton_CheckedChanged(sender As Object, e As EventArgs) Handles addLegButton.CheckedChanged
        Me.newDestLabel.Show()
        Me.ToLocationBox.Show()
        Me.ToLocationBox.Location = New Point(162, 251)
        Me.newDestLabel.Text = "Add Leg: "
    End Sub

    Private Sub ToLocationBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ToLocationBox.SelectedIndexChanged
        Me.extraCost = Generator.Next(13, 40)
        Me.costLabel.Text = "Added Cost: $" + Me.extraCost.ToString
        Me.costLabel.Show()
        Me.ChangeButton.Show()
    End Sub

    Private Sub newDestButton_CheckedChanged(sender As Object, e As EventArgs) Handles newDestButton.CheckedChanged
        Me.newDestLabel.Text = "New Destination: "
        Me.ToLocationBox.Location = New Point(174, 271)
        Me.newDestLabel.Show()
        Me.ToLocationBox.Show()
    End Sub
End Class
