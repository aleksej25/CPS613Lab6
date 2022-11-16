Public Class RiderForm
    Public Shared riderBooking As New Booking

    Private Sub formClosing(sender As Object, e As EventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

End Class