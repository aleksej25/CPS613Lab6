Public Class cameraViewControl
    Private Sub BackBox_Click(sender As Object, e As EventArgs) Handles BackBox.Click
        Me.Hide()
        Form1.CarDiagnosticControl1.Show()
    End Sub

End Class
