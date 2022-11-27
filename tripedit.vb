Public Class tripedit
    Public waitTimer As Integer = 0

    Private Sub continueButton_Click(sender As Object, e As EventArgs) Handles continueButton.Click
        RiderForm.ModifyTripControl1.rideApproved()
        Me.RichTextBox2.Text = "Trip Modification Accepted."
        Me.RichTextBox2.ForeColor = Color.Lime
        Me.Timer1.Start()

    End Sub
    Private Sub rejectButton_Click(sender As Object, e As EventArgs) Handles rejectButton.Click
        Me.RichTextBox2.Text = "Trip Modification Rejected."
        Me.RichTextBox2.ForeColor = Color.Red
        RiderForm.ModifyTripControl1.rideDenied()

        Me.Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.waitTimer += 1
        If Me.waitTimer >= 5 Then
            Me.waitTimer = 0
            Me.Timer1.Stop()
            Me.Hide()
            Me.RichTextBox2.Text = "This trip was automatically approved by the system."
            Me.RichTextBox2.ForeColor = Color.Lime
        End If
    End Sub
End Class
