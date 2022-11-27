Public Class requestdetails
    Public waitTimer As Integer = 0
    Private Sub rejectButton_Click(sender As Object, e As EventArgs) Handles rejectButton.Click
        RiderForm.CurrentTripControl1.StopTripButton.PerformClick()
        RiderForm.rejectedBox.BringToFront()
        RiderForm.rejectedBox.Show()
        Form1.OwnerMainScreen1.Timer2.Start()
        Me.RichTextBox2.Text = "Trip Rejected."
        Me.RichTextBox2.ForeColor = Color.Red
        Me.Timer1.Start()
        Me.continueButton.Enabled = False
    End Sub

    Private Sub continueButton_Click(sender As Object, e As EventArgs) Handles continueButton.Click
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.waitTimer += 1
        If Me.waitTimer >= 3 Then
            Me.waitTimer = 0
            Me.Timer1.Stop()
            Me.Hide()
            Me.RichTextBox2.Text = "This trip was automatically approved by the system."
            Me.RichTextBox2.ForeColor = Color.Lime
            Me.continueButton.Enabled = True
        End If
    End Sub
End Class
