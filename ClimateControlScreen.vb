Public Class ClimateControlScreen
    Public frontOn As Boolean = False
    Public rearOn As Boolean = False
    Public driverSeatOn As Boolean = False
    Public passengerSeatOn As Boolean = False
    Public passengerLeftSeatOn As Boolean = False
    Public passengerRightSeatOn As Boolean = False
    Private Sub ClimateControlScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TitleLabel.Left = (Me.TitleLabel.Parent.Width \ 2) - (Me.TitleLabel.Width \ 2)
    End Sub
    Private Sub FrontDefrost_Click(sender As Object, e As EventArgs) Handles FrontDefrost.Click
        If Not frontOn Then
            Me.FrontDefrost.Image = My.Resources.ProjectResources.frontDefrostOn
            Me.FrontDefrostLabel.ForeColor = Color.Red
            Me.frontOn = True
        Else
            Me.FrontDefrost.Image = My.Resources.ProjectResources.frontDefrost
            Me.FrontDefrostLabel.ForeColor = Color.White
            Me.frontOn = False
        End If
    End Sub

    Private Sub rearDefrost_Click(sender As Object, e As EventArgs) Handles rearDefrost.Click
        If Not rearOn Then
            Me.rearDefrost.Image = My.Resources.ProjectResources.rearDefrostOn
            Me.RearDefrostLabel.ForeColor = Color.Red
            Me.rearOn = True
        Else
            Me.rearDefrost.Image = My.Resources.ProjectResources.rearDefrost
            Me.RearDefrostLabel.ForeColor = Color.White
            Me.rearOn = False
        End If
    End Sub

    Private Sub DriverSeat_Click(sender As Object, e As EventArgs) Handles DriverSeat.Click, PassengerSeat.Click, BackLeftPass.Click, BackRightPass.Click
        Select Case sender.Name
            Case "DriverSeat"
                If Not Me.driverSeatOn Then
                    Me.DriverSeat.Image = My.Resources.ProjectResources.heatedSeatOn
                    Me.driverSeatOn = True
                    Me.DriverLabel.ForeColor = Color.Red
                Else
                    Me.DriverSeat.Image = My.Resources.ProjectResources.heatedSeatOff
                    Me.driverSeatOn = False
                    Me.DriverLabel.ForeColor = Color.White
                End If
            Case "PassengerSeat"
                If Not Me.passengerSeatOn Then
                    Me.PassengerSeat.Image = My.Resources.ProjectResources.heatedSeatOn
                    Me.passengerSeatOn = True
                    Me.PassFRLabel.ForeColor = Color.Red
                Else
                    Me.PassengerSeat.Image = My.Resources.ProjectResources.heatedSeatOff
                    Me.passengerSeatOn = False
                    Me.PassFRLabel.ForeColor = Color.White
                End If
            Case "BackLeftPass"
                If Not Me.passengerLeftSeatOn Then
                    Me.BackLeftPass.Image = My.Resources.ProjectResources.heatedSeatOn
                    Me.passengerLeftSeatOn = True
                    Me.PassBLLabel.ForeColor = Color.Red
                Else
                    Me.BackLeftPass.Image = My.Resources.ProjectResources.heatedSeatOff
                    Me.passengerLeftSeatOn = False
                    Me.PassBLLabel.ForeColor = Color.White
                End If
            Case "BackRightPass"
                If Not Me.passengerRightSeatOn Then
                    Me.BackRightPass.Image = My.Resources.ProjectResources.heatedSeatOn
                    Me.passengerRightSeatOn = True
                    Me.PassBRLabel.ForeColor = Color.Red
                Else
                    Me.BackRightPass.Image = My.Resources.ProjectResources.heatedSeatOff
                    Me.passengerRightSeatOn = False
                    Me.PassBRLabel.ForeColor = Color.White
                End If
        End Select
    End Sub

    Private Sub ACBox_Click(sender As Object, e As EventArgs) Handles ACBox.Click
        Me.Hide()
        Form1.AirControllScreen1.BringToFront()
        Form1.AirControllScreen1.Show()
    End Sub

    Private Sub BackBox_Click(sender As Object, e As EventArgs) Handles BackBox.Click
        Me.Hide()
        Form1.ECarControls.BringToFront()
        Form1.ECarControls.Show()
    End Sub

End Class
