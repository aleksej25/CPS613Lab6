Public Class BookTripScreen

    'Book Trip Screen'

    Private Sub BackBox_Click(sender As Object, e As EventArgs) Handles BackBox.Click
        Me.Hide()
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

        StartTimeBox.Items.Add("11:00AM")
        StartTimeBox.Items.Add("12:00PM")
        StartTimeBox.Items.Add("1:00PM")
        StartTimeBox.Items.Add("2:00PM")
        StartTimeBox.Items.Add("3:00PM")
        StartTimeBox.Items.Add("4:00PM")

        EndTimeBox.Items.Add("11:00AM")
        EndTimeBox.Items.Add("12:00PM")
        EndTimeBox.Items.Add("1:00PM")
        EndTimeBox.Items.Add("2:00PM")
        EndTimeBox.Items.Add("3:00PM")
        EndTimeBox.Items.Add("4:00PM")
        EndTimeBox.Items.Add("5:00PM")

        FromTimeLabel.Hide()
        EndTimeLabel.Hide()
        StartTimeBox.Hide()
        EndTimeBox.Hide()

    End Sub

    Private Sub NowRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles NowRadioButton.CheckedChanged
        FromTimeLabel.Hide()
        EndTimeLabel.Show()
        StartTimeBox.Hide()
        EndTimeBox.Show()
    End Sub

    Private Sub LaterRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles LaterRadioButton.CheckedChanged
        FromTimeLabel.Show()
        EndTimeLabel.Show()
        StartTimeBox.Show()
        EndTimeBox.Show()
    End Sub

    Private Sub BookButton_Click(sender As Object, e As EventArgs) Handles BookButton.Click
        RiderForm.riderBooking.FromLocation = FromLocationBox.Text
        RiderForm.riderBooking.ToLocation = ToLocationBox.Text
        RiderForm.riderBooking.NumberOfPeople = Integer.Parse(PeopleComboBox.Text)
        Form1.CarBooked = True

        If NowRadioButton.Checked = True Then
            RiderForm.riderBooking.FromTime = "10:00AM"
            RiderForm.riderBooking.ToTime = EndTimeBox.Text
            RiderForm.riderBooking.BookingStatus = True
            Form1.CarBooked = True
            RiderForm.RiderMainScreen1.bookCheck()

        End If

        If LaterRadioButton.Checked = True Then
            RiderForm.riderBooking.FromTime = StartTimeBox.Text
            RiderForm.riderBooking.ToTime = EndTimeBox.Text
            RiderForm.riderBooking.BookingStatus = True
            Form1.CarBooked = True
            RiderForm.RiderMainScreen1.bookCheck()
        End If

        RiderForm.CurrentTripControl1.Book()
        Me.Hide()
        RiderForm.CurrentTripControl1.BringToFront()
        RiderForm.CurrentTripControl1.Show()
        Form1.Requestdetails1.tripdetails.Text = "Name: " + RiderForm.riderBooking.RiderName + vbCrLf + "From: " + RiderForm.riderBooking.FromLocation + vbCrLf + "To: " + RiderForm.riderBooking.ToLocation + vbCrLf + "Number of people: " + RiderForm.riderBooking.NumberOfPeople.ToString() + vbCrLf + "Start time: " + RiderForm.riderBooking.FromTime + vbCrLf + "End time: " + RiderForm.riderBooking.ToTime
        RiderForm.CurrentTripControl1.Timer.Start()


        RiderForm.CurrentTripControl1.TitleLabel.Left = (RiderForm.CurrentTripControl1.TitleLabel.Parent.Width \ 2) - (RiderForm.CurrentTripControl1.TitleLabel.Width \ 2) - 3
        RiderForm.CurrentTripControl1.startLabel.Left = (RiderForm.CurrentTripControl1.startLabel.Parent.Width \ 2) - (RiderForm.CurrentTripControl1.startLabel.Width \ 2) - 3
        RiderForm.CurrentTripControl1.StartDestinationLabel.Left = (RiderForm.CurrentTripControl1.StartDestinationLabel.Parent.Width \ 2) - (RiderForm.CurrentTripControl1.StartDestinationLabel.Width \ 2) - 3
        RiderForm.CurrentTripControl1.endLabel.Left = (RiderForm.CurrentTripControl1.endLabel.Parent.Width \ 2) - (RiderForm.CurrentTripControl1.endLabel.Width \ 2) - 3
        RiderForm.CurrentTripControl1.DestinationLabel.Left = (RiderForm.CurrentTripControl1.DestinationLabel.Parent.Width \ 2) - (RiderForm.CurrentTripControl1.DestinationLabel.Width \ 2) - 3
        RiderForm.CurrentTripControl1.ArrivedLabel.Left = (RiderForm.CurrentTripControl1.ArrivedLabel.Parent.Width \ 2) - (RiderForm.CurrentTripControl1.ArrivedLabel.Width \ 2) - 3

        Me.FromLocationBox.Text = ""
        Me.ToLocationBox.Text = ""
        Me.PeopleComboBox.Text = ""
        Me.NowRadioButton.Checked = False
        Me.LaterRadioButton.Checked = False
        Me.StartTimeBox.Text = ""
        Me.EndTimeBox.Text = ""
    End Sub

End Class
