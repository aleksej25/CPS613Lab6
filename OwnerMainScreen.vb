Public Class OwnerMainScreen
    Public timerStatus As Integer = 0
    Public cameraFailureResolved As Boolean = False
    Public breakInResolved As Boolean = False
    Public colisionResolved As Boolean = False
    Public isDriving As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.CarBooked = True Then
            Form1.riderequestn.Show()
            Form1.riderequestn.BringToFront()
            Form1.CarBooked = False
        End If
        If Booking.TripModified = True Then
            Form1.rideupdated.Show()
            Form1.rideupdated.BringToFront()
            Booking.TripModified = False
        End If
    End Sub
    Private Sub MyCarButton_Click(sender As Object, e As EventArgs) Handles MyCarButton.Click
        Form1.ECarControls.carBox.Enabled = True
        Me.Hide()
        Form1.ECarControls.Show()
    End Sub

    Private Sub ScheduleButton_Click(sender As Object, e As EventArgs) Handles ScheduleButton.Click
        Me.Hide()
        Form1.CalendarControl1.Show()
    End Sub

    Private Sub BookingsButton_Click(sender As Object, e As EventArgs) Handles BookATripButton.Click
        Me.Hide()
        Form1.OwnerBookTrip1.BringToFront()
        Form1.OwnerBookTrip1.Show()
    End Sub

    Private Sub RatingsButton_Click(sender As Object, e As EventArgs) Handles RatingsButton.Click
        Me.Hide()
        Form1.RatingsControl1.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        System.Diagnostics.Debug.WriteLine(Me.timerStatus)
        If Not Me.isDriving Then
            Me.timerStatus += 1
            If Me.timerStatus = 25 And Not Me.cameraFailureResolved Then
                Form1.cameraFailureBox.Show()
                Form1.cameraFailureBox.BringToFront()
                Me.cameraFailureResolved = True
                Me.Timer1.Stop()
                'ElseIf Me.timerStatus = 750 And Not Me.breakInResolved Then
                '    Form1.breakInBox.Show()
                '    Form1.breakInBox.BringToFront()
                '    Me.breakInResolved = True
                'ElseIf Me.timerStatus = 1250 And Not Me.colisionResolved Then
                '    Form1.collisionBox.Show()
                '    Form1.collisionBox.BringToFront()
                '    Me.colisionResolved = True
                '    Me.Timer1.Stop()
            End If
        End If
    End Sub
End Class
