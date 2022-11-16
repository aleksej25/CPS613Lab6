Public Class ECarControls
    Public trunkOpen As Boolean = False
    Private Sub MediaControlBox_Click(sender As Object, e As EventArgs) Handles carMediaButton.Click
        Me.Hide()
        Form1.MediaControls1.BringToFront()
        Form1.MediaControls1.Show()
    End Sub

    Private Sub ClimateControlBox_Click(sender As Object, e As EventArgs) Handles climateControlButton.Click
        Me.Hide()
        Form1.ClimateControlScreen1.BringToFront()
        Form1.ClimateControlScreen1.Show()
    End Sub

    Private Sub BackBox_Click(sender As Object, e As EventArgs) Handles BackBox.Click
        If Form1.OwnerCurrentTrip1.OwnerTrip = True Then
            Me.Hide()
            Form1.OwnerCurrentTrip1.BringToFront()
            Form1.OwnerCurrentTrip1.Show()
        Else
            Me.Hide()
            Form1.OwnerMainScreen1.BringToFront()
            Form1.OwnerMainScreen1.Show()
        End If
    End Sub

    Private Sub trunkBox_Click(sender As Object, e As EventArgs) Handles trunkButton.Click
        If Not Me.trunkOpen Then
            Me.trunkOpen = True
            Me.trunkButton.Image = My.Resources.ProjectResources.closeTrunk
            Me.trunkOCLabel.Text = "Trunk Open"
        Else
            Me.trunkOpen = False
            Me.trunkButton.Image = My.Resources.ProjectResources.openTrunk
            Me.trunkOCLabel.Text = "Trunk Closed"
        End If
    End Sub

    Private Sub carBox_Click(sender As Object, e As EventArgs) Handles carBox.Click
        Me.Hide()
        Form1.CarDiagnosticControl1.BringToFront()
        Form1.CarDiagnosticControl1.Show()
    End Sub

    Private Sub windowButton_Click(sender As Object, e As EventArgs) Handles windowButton.Click
        Me.Hide()
        Form1.WindowControl1.BringToFront()
        Form1.WindowControl1.Show()
    End Sub


End Class
