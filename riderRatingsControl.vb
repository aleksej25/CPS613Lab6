Public Class riderRatingsControl

    Dim ImageHolder As Image = My.Resources.ProjectResources.clipart676962

    Public Shared Function ResizeImage(ByVal InputImage As Image) As Image
        Return New Bitmap(InputImage, New Size(268, 70))
    End Function

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ImageHolder = ResizeImage(ImageHolder)
        RatingBox.Image = ImageHolder
    End Sub

    Private Sub BackBox_Click(sender As Object, e As EventArgs) Handles BackBox.Click
        Me.Hide()
        RiderForm.RiderMainScreen1.BringToFront()
        RiderForm.RiderMainScreen1.Show()
    End Sub

    Private Sub LastCarButton_Click(sender As Object, e As EventArgs) Handles LastCarButton.Click
        ScoreLabel.Show()
        ScoreBox.Show()
        RateButton.Show()
    End Sub

    Private Sub RateButton_Click(sender As Object, e As EventArgs) Handles RateButton.Click
        ThanksLabel.Show()
    End Sub
End Class
