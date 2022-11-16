Public Class riderECarControl
    Public trunkOpen As Boolean = False
    Private Sub BackBox_Click(sender As Object, e As EventArgs) Handles BackBox.Click
        Me.Hide()
        RiderForm.CurrentTripControl1.BringToFront()
        RiderForm.CurrentTripControl1.Show()
    End Sub

    Private Sub windowButton_Click(sender As Object, e As EventArgs) Handles windowButton.Click
        Me.Hide()
        RiderForm.RiderWindowControl1.BringToFront()
        RiderForm.RiderWindowControl1.Show()
    End Sub

    Private Sub trunkButton_Click(sender As Object, e As EventArgs) Handles trunkButton.Click
        If Not Me.trunkOpen Then
            Me.trunkOpen = True
            Me.trunkButton.Image = My.Resources.ProjectResources.closeTrunk
            Me.trunkOCLabel.Text = "Trunk Open"

            Form1.ECarControls.trunkButton.Image = My.Resources.ProjectResources.closeTrunk
            Form1.ECarControls.trunkOCLabel.Text = "Trunk Open"
        Else
            Me.trunkOpen = False
            Me.trunkButton.Image = My.Resources.ProjectResources.openTrunk
            Me.trunkOCLabel.Text = "Trunk Closed"

            Form1.ECarControls.trunkButton.Image = My.Resources.ProjectResources.openTrunk
            Form1.ECarControls.trunkOCLabel.Text = "Trunk Closed"
        End If
    End Sub

    Private Sub carMediaButton_Click(sender As Object, e As EventArgs) Handles carMediaButton.Click
        Me.Hide()
        RiderForm.RiderMediaControls1.BringToFront()
        RiderForm.RiderMediaControls1.Show()
    End Sub

    Private Sub climateControlButton_Click(sender As Object, e As EventArgs) Handles climateControlButton.Click
        Me.Hide()
        RiderForm.RiderClimateControl1.BringToFront()
        RiderForm.RiderClimateControl1.Show()
    End Sub

    Private Sub carBox_Click(sender As Object, e As EventArgs) Handles carBox.Click
        Me.Hide()
        RiderForm.RiderCarStatusControl1.BringToFront()
        RiderForm.RiderCarStatusControl1.Show()
    End Sub
End Class
