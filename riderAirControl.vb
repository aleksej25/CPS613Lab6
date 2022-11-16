Public Class riderAirControl
    Public Generator As System.Random = New System.Random()
    Public tempValue As Integer
    Public freshAirOn As Boolean = True
    Public recurAirOn As Boolean = False

    Private Sub AirControllScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.tempValue = Generator.Next(16, 28)
        Me.InsideTempLabel.Text = "Cabin Temperature is: " + tempValue.ToString + "C"
        Me.OutsideTempLabel.Text = "Outside Temperature is: " + (tempValue + 3).ToString + "C"
    End Sub
    Private Sub TemperatureSlider_Scroll(sender As Object, e As EventArgs) Handles TemperatureSlider.Scroll
        Me.SettingClimateLabel.Text = "Setting the temperature to: " + TemperatureSlider.Value.ToString() + "C"
        If TemperatureSlider.Value.ToString() < Me.tempValue Then
            Me.SettingClimateLabel.ForeColor = Color.Blue
        Else
            Me.SettingClimateLabel.ForeColor = Color.Red
        End If
        Me.SettingClimateLabel.Left = (Me.SettingClimateLabel.Parent.Width \ 2) - (Me.SettingClimateLabel.Width \ 2) - 3

        Me.SettingClimateLabel.Show()
    End Sub

    Private Sub FreshAirBox_Click(sender As Object, e As EventArgs) Handles FreshAirBox.Click, RecirculatingAirBox.Click
        Select Case sender.Name
            Case "FreshAirBox"
                Me.FreshAirBox.Image = My.Resources.ProjectResources.freshAirOn
                Me.RecirculatingAirBox.Image = My.Resources.ProjectResources.recirculatAirOff
            Case "RecirculatingAirBox"
                Me.FreshAirBox.Image = My.Resources.ProjectResources.freshAirOff
                Me.RecirculatingAirBox.Image = My.Resources.ProjectResources.recirculatAirOn
        End Select
    End Sub

    Private Sub BackBox_Click(sender As Object, e As EventArgs) Handles BackBox.Click
        Me.Hide()
        RiderForm.RiderClimateControl1.BringToFront()
        RiderForm.RiderClimateControl1.Show()
    End Sub

    Private Sub FanSpeedBar_Scroll(sender As Object, e As EventArgs) Handles FanSpeedBar.Scroll
        Me.AirControlLabel.Text = "Fan Speed is: " + FanSpeedBar.Value.ToString
        Me.AirControlLabel.Show()
    End Sub
End Class
