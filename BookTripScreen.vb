Public Class BookTripScreen
    Public Generator As System.Random = New System.Random()
    Public tripCost As Integer
    'Book Trip Screen'

    Private Sub BackBox_Click(sender As Object, e As EventArgs) Handles BackBox.Click
        Me.Hide()
        RiderForm.RiderMainScreen1.BringToFront()
        RiderForm.RiderMainScreen1.Show()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        FromLocationBox.Items.Add("Your current location.")
        FromLocationBox.Items.Add("Yonge Dundas Square")
        FromLocationBox.Items.Add("TMU")

        ToLocationBox.Items.Add("123 Queen Street")
        ToLocationBox.Items.Add("123 Yonge Street")
        ToLocationBox.Items.Add("123 King Street")

        PeopleComboBox.Items.Add(1)
        PeopleComboBox.Items.Add(2)
        PeopleComboBox.Items.Add(3)
        PeopleComboBox.Items.Add(4)

        futureTimeBox.Items.Add("11:00AM")
        futureTimeBox.Items.Add("12:00PM")
        futureTimeBox.Items.Add("1:00PM")
        futureTimeBox.Items.Add("2:00PM")
        futureTimeBox.Items.Add("3:00PM")
        futureTimeBox.Items.Add("4:00PM")

        futureTimeLabel.Hide()
        futureTimeBox.Hide()
    End Sub

    Private Sub NowRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles NowRadioButton.CheckedChanged
        Me.tripCost = Generator.Next(13, 40)
        futureTimeLabel.Hide()
        futureTimeBox.Hide()
        Me.costLabel.Text = "Cost: $" + Me.tripCost.ToString
        Me.costLabel.Show()
    End Sub

    Private Sub LaterRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles LaterRadioButton.CheckedChanged
        Me.tripCost = Generator.Next(13, 40)
        futureTimeLabel.Show()
        futureTimeBox.Show()
        Me.costLabel.Text = "Cost: $" + Me.tripCost.ToString
        Me.costLabel.Show()
    End Sub

    Private Sub BookButton_Click(sender As Object, e As EventArgs) Handles BookButton.Click
        RiderForm.riderBooking.FromLocation = FromLocationBox.Text
        RiderForm.riderBooking.ToLocation = ToLocationBox.Text
        RiderForm.riderBooking.NumberOfPeople = Integer.Parse(PeopleComboBox.Text)
        Form1.CarBooked = True
        Form1.riderequestn.Show()
        Form1.riderequestn.BringToFront()

        If NowRadioButton.Checked = True Then
            RiderForm.riderBooking.FromTime = "10:00AM"
            RiderForm.riderBooking.BookingStatus = True
            Form1.CarBooked = True
            RiderForm.RiderMainScreen1.bookCheck()

        End If

        If LaterRadioButton.Checked = True Then
            RiderForm.riderBooking.FromTime = futureTimeBox.Text
            RiderForm.riderBooking.BookingStatus = True
            Form1.CarBooked = True
            RiderForm.RiderMainScreen1.bookCheck()
        End If

        RiderForm.CurrentTripControl1.Book()

        RiderForm.RiderMainScreen1.resetAfterRide()
        Form1.OwnerMainScreen1.resetAfterRider()

        Form1.OwnerMainScreen1.kickOutButton.Show()

        If RiderForm.riderBooking.FromLocation <> "Your current location." Then
            Form1.Requestdetails1.tripdetails.Text = "From: " + RiderForm.riderBooking.FromLocation + vbCrLf + "To: " + RiderForm.riderBooking.ToLocation + vbCrLf + "Number of people: " + RiderForm.riderBooking.NumberOfPeople.ToString() + vbCrLf + "Start time: " + RiderForm.riderBooking.FromTime
            RiderForm.CurrentTripControl1.Timer.Start()
        Else
            Form1.Requestdetails1.tripdetails.Text = "From: Riders Location" + vbCrLf + "To: " + RiderForm.riderBooking.ToLocation + vbCrLf + "Number of people: " + RiderForm.riderBooking.NumberOfPeople.ToString() + vbCrLf + "Start time: " + RiderForm.riderBooking.FromTime
            RiderForm.CurrentTripControl1.Timer.Start()
        End If



        RiderForm.CurrentTripControl1.TitleLabel.Left = (RiderForm.CurrentTripControl1.TitleLabel.Parent.Width \ 2) - (RiderForm.CurrentTripControl1.TitleLabel.Width \ 2) - 3
        RiderForm.CurrentTripControl1.startLabel.Left = (RiderForm.CurrentTripControl1.startLabel.Parent.Width \ 2) - (RiderForm.CurrentTripControl1.startLabel.Width \ 2) - 3
        RiderForm.CurrentTripControl1.StartDestinationLabel.Left = (RiderForm.CurrentTripControl1.StartDestinationLabel.Parent.Width \ 2) - (RiderForm.CurrentTripControl1.StartDestinationLabel.Width \ 2) - 3
        RiderForm.CurrentTripControl1.endLabel.Left = (RiderForm.CurrentTripControl1.endLabel.Parent.Width \ 2) - (RiderForm.CurrentTripControl1.endLabel.Width \ 2) - 3
        RiderForm.CurrentTripControl1.DestinationLabel.Left = (RiderForm.CurrentTripControl1.DestinationLabel.Parent.Width \ 2) - (RiderForm.CurrentTripControl1.DestinationLabel.Width \ 2) - 3
        RiderForm.CurrentTripControl1.ArrivedLabel.Left = (RiderForm.CurrentTripControl1.ArrivedLabel.Parent.Width \ 2) - (RiderForm.CurrentTripControl1.ArrivedLabel.Width \ 2) - 3

        RiderForm.CurrentTripControl1.ModifyTripButton.Location = New Point(55, 446)
        RiderForm.CurrentTripControl1.ContactOwnerButton.Location = New Point(186, 446)
        RiderForm.CurrentTripControl1.ContinueTripButton.Location = New Point(123, 376)
        RiderForm.CurrentTripControl1.CarControlButton.Location = New Point(55, 522)
        RiderForm.CurrentTripControl1.StopTripButton.Location = New Point(186, 522)

        RiderForm.CurrentTripControl1.etaLabel.Text = "ETA: " + (30 - RiderForm.CurrentTripControl1.countDown).ToString + "Minutes"
        RiderForm.CurrentTripControl1.etaLabel.Left = (RiderForm.CurrentTripControl1.etaLabel.Parent.Width \ 2) - (RiderForm.CurrentTripControl1.etaLabel.Width \ 2) - 3
        RiderForm.CurrentTripControl1.etaLabel.Show()

        Form1.OwnerMainScreen1.inUseLabel.Text = "Your Car is Currently" + vbCrLf + "In Use!"
        Form1.OwnerMainScreen1.inUseLabel.Left = (Form1.OwnerMainScreen1.inUseLabel.Parent.Width \ 2) - (Form1.OwnerMainScreen1.inUseLabel.Width \ 2) - 3
        Form1.OwnerMainScreen1.inUseLabel.Show()
        Form1.OwnerMainScreen1.BookATripButton.Enabled = False


        Me.FromLocationBox.Text = ""
        Me.ToLocationBox.Text = ""
        Me.PeopleComboBox.Text = ""
        Me.NowRadioButton.Checked = False
        Me.LaterRadioButton.Checked = False
        Me.futureTimeBox.Text = ""
        Me.futureTimeBox.Hide()

        RiderForm.CurrentTripControl1.ContinueTripButton.Show()
        RiderForm.CurrentTripControl1.ContinueTripButton.Enabled = False
        RiderForm.CurrentTripControl1.ModifyTripButton.Show()
        RiderForm.CurrentTripControl1.ContactOwnerButton.Show()
        RiderForm.CurrentTripControl1.CarControlButton.Show()
        RiderForm.CurrentTripControl1.StopTripButton.Show()

        Me.costLabel.Hide()

        Me.Hide()
        RiderForm.CurrentTripControl1.BringToFront()
        RiderForm.CurrentTripControl1.Show()
    End Sub

End Class
