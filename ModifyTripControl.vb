Public Class ModifyTripControl
    Public Generator As System.Random = New System.Random()
    Public extraCost As Integer
    Public newEta As Integer = 0
    Public timerStatus As Integer = 0


    Public Function rideApproved()
        If Me.addLegButton.Checked Then
            RiderForm.riderBooking.TripModified = True
            RiderForm.riderBooking.OldDestination = RiderForm.riderBooking.ToLocation
            RiderForm.riderBooking.NewDestination = Me.ToLocationBox.Text
            RiderForm.CurrentTripControl1.ModifiedDestLabel.Text = RiderForm.riderBooking.NewDestination
            RiderForm.CurrentTripControl1.ContinueTripButton.Show()
            RiderForm.CurrentTripControl1.NextDestIndicator.Show()
            RiderForm.CurrentTripControl1.ModifiedDestLabel.Show()
            RiderForm.CurrentTripControl1.countDown = Me.newEta
        End If
        If newDestButton.Checked Then
            RiderForm.CurrentTripControl1.DestinationLabel.Text = Me.ToLocationBox.Text
            RiderForm.CurrentTripControl1.DestinationLabel.Left = (RiderForm.CurrentTripControl1.DestinationLabel.Parent.Width \ 2) - (RiderForm.CurrentTripControl1.DestinationLabel.Width \ 2) - 3
            RiderForm.CurrentTripControl1.countDown = Me.newEta
        End If

        Me.loadingBox.Hide()
        Me.approvalLabel.Text = "Approved!"
        Me.approvalLabel.ForeColor = Color.Lime
        Me.approvalLabel.Left = (Me.approvalLabel.Parent.Width \ 2) - (Me.approvalLabel.Width \ 2) - 3
        Me.ChangeButton.Enabled = False
        Me.Timer1.Start()
    End Function

    Public Function rideDenied()
        Me.loadingBox.Hide()
        Me.approvalLabel.Text = "Request Rejected."
        Me.approvalLabel.ForeColor = Color.Red
        Me.approvalLabel.Left = (Me.approvalLabel.Parent.Width \ 2) - (Me.approvalLabel.Width \ 2) - 3

        Me.Timer1.Start()
    End Function

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
        RiderForm.CurrentTripControl1.Timer.Start()

    End Sub

    Private Sub ChangeButton_Click(sender As Object, e As EventArgs) Handles ChangeButton.Click
        Me.loadingBox.Show()
        Me.approvalLabel.Text = "Awaiting Owner Approval."
        Me.approvalLabel.Left = (Me.approvalLabel.Parent.Width \ 2) - (Me.approvalLabel.Width \ 2) - 3
        Me.approvalLabel.ForeColor = Color.White
        Me.approvalLabel.Show()

        If Me.addLegButton.Checked Then
            Form1.Tripedit1.tripdetails.Text = "Add Stop: " + Me.ToLocationBox.Text
        End If
        If newDestButton.Checked Then
            Form1.Tripedit1.tripdetails.Text = "New destination: " + Me.ToLocationBox.Text
        End If
        Form1.Tripedit1.RichTextBox2.Text = "Awaiting Your Approval."
        Form1.Tripedit1.Show()
        Form1.Tripedit1.BringToFront()
    End Sub

    Private Sub addLegButton_CheckedChanged(sender As Object, e As EventArgs) Handles addLegButton.CheckedChanged

        Me.newDestLabel.Show()
        Me.ToLocationBox.Show()
        Me.ToLocationBox.Location = New Point(164, 205)
        Me.newDestLabel.Text = "Add Stop: "
    End Sub

    Private Sub ToLocationBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ToLocationBox.SelectedIndexChanged

        Me.extraCost = Generator.Next(13, 40)
        Me.costLabel.Text = "Added Cost: $" + Me.extraCost.ToString
        Me.costLabel.Show()
        Me.ChangeButton.Show()
        Me.newEta = Generator.Next(0, 15)
        Me.etaLabel.Text = "New ETA: " + (30 - RiderForm.CurrentTripControl1.countDown).ToString + " Minutes"
        Me.etaLabel.Show()
    End Sub

    Private Sub newDestButton_CheckedChanged(sender As Object, e As EventArgs) Handles newDestButton.CheckedChanged

        Me.newDestLabel.Text = "New Destination: "
        Me.ToLocationBox.Location = New Point(177, 234)

        Me.newDestLabel.Show()
        Me.ToLocationBox.Show()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.timerStatus += 1
        If Me.timerStatus >= 5 Then
            Me.Hide()
            Me.ChangeButton.Hide()
            Me.costLabel.Hide()
            Me.etaLabel.Hide()
            Me.approvalLabel.Hide()
            RiderForm.CurrentTripControl1.Timer.Start()

            Me.ChangeButton.Enabled = True
            RiderForm.CurrentTripControl1.BringToFront()
            RiderForm.CurrentTripControl1.Show()
            Me.Timer1.Stop()
        End If
    End Sub
End Class
