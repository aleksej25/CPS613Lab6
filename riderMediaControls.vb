Public Class riderMediaControls

    Public bluetoothOn As Boolean = False
    Public tempVar As Integer = 0
    Public radioOn As Boolean = False
    Public radioLabelMessage As String = "Now playing "
    Public radioStation As Double = 107.1
    Public mouseIsDown As Boolean = False
    Public volumeAmount As Integer = 0

    Private Sub mediaControls_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.audioLevelLabel.Text = "Volume Level: " + Me.volumeAmount.ToString
    End Sub
    Private Sub BackBox_Click(sender As Object, e As EventArgs) Handles BackBox.Click
        Me.Hide()
        RiderForm.RidereCarControl1.BringToFront()
        RiderForm.RidereCarControl1.Show()
    End Sub

    Private Sub bluetoothBox_Click(sender As Object, e As EventArgs) Handles bluetoothBox.Click
        If Not Me.bluetoothOn Then
            Me.ConnectingLabel.Text = "Establishing Bluetooth Connection..."
            Me.ConnectingLabel.Left = (Me.ConnectingLabel.Parent.Width \ 2) - (Me.ConnectingLabel.Width \ 2) - 3
            Me.ConnectionProgressBar.Value = 0
            Me.Timer1.Start()

            Form1.MediaControls1.bluetoothBox.PerformClick()
        Else
            Me.bluetoothBox.Image = My.Resources.ProjectResources.bluetoothOff
            Me.bluetoothOn = False
            Me.ConnectingLabel.Text = "Disconnected!"
            Me.ConnectingLabel.ForeColor = Color.Lime
            Me.ConnectingLabel.Left = (Me.ConnectingLabel.Parent.Width \ 2) - (Me.ConnectingLabel.Width \ 2) - 3
            Me.ConnectingLabel.Show()
            Me.Timer2.Start()

            Form1.MediaControls1.bluetoothBox.PerformClick()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.ConnectingLabel.Show()
        Me.ConnectionProgressBar.Show()
        Me.ConnectionProgressBar.Increment(10)
        If Me.ConnectionProgressBar.Value = 60 Then
            Me.ConnectingLabel.Text = "Connection Established!"
            Me.ConnectingLabel.Left = (Me.ConnectingLabel.Parent.Width \ 2) - (Me.ConnectingLabel.Width \ 2) - 3
            Me.ConnectingLabel.ForeColor = Color.Lime
            Me.bluetoothBox.Image = My.Resources.ProjectResources.bluetoothOn
            Me.bluetoothOn = True
            Me.Timer2.Start()
            Me.Timer1.Stop()
        End If
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.tempVar += 1
        If Me.tempVar = 14 Then
            Me.tempVar = 0
            Me.ConnectingLabel.Hide()
            Me.ConnectionProgressBar.Hide()
            Me.Timer2.Stop()
        End If
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Me.audioLevelLabel.Show()
        If Me.TrackBar1.Value = 0 Then
            Me.AudioBox.Image = My.Resources.ProjectResources.audioMute
            Me.audioLevelLabel.Text = "Volume Level: " + Me.TrackBar1.Value.ToString()

            Form1.MediaControls1.AudioBox.Image = My.Resources.ProjectResources.audioMute
            Form1.MediaControls1.audioLevelLabel.Text = "Volume Level: " + Me.TrackBar1.Value.ToString()
        ElseIf Me.TrackBar1.Value >= 1 And Me.TrackBar1.Value <= 3 Then
            Me.AudioBox.Image = My.Resources.ProjectResources.audio1
            Me.audioLevelLabel.Text = "Volume Level: " + Me.TrackBar1.Value.ToString()

            Form1.MediaControls1.AudioBox.Image = My.Resources.ProjectResources.audio1
            Form1.MediaControls1.audioLevelLabel.Text = "Volume Level: " + Me.TrackBar1.Value.ToString()
        ElseIf Me.TrackBar1.Value > 3 And Me.TrackBar1.Value <= 6 Then
            Me.AudioBox.Image = My.Resources.ProjectResources.audio2
            Me.audioLevelLabel.Text = "Volume Level: " + Me.TrackBar1.Value.ToString()

            Form1.MediaControls1.AudioBox.Image = My.Resources.ProjectResources.audio2
            Form1.MediaControls1.audioLevelLabel.Text = "Volume Level: " + Me.TrackBar1.Value.ToString()
        ElseIf Me.TrackBar1.Value > 6 And Me.TrackBar1.Value <= 10 Then
            Me.AudioBox.Image = My.Resources.ProjectResources.audio3
            Me.audioLevelLabel.Text = "Volume Level: " + Me.TrackBar1.Value.ToString()

            Form1.MediaControls1.AudioBox.Image = My.Resources.ProjectResources.audio3
            Form1.MediaControls1.audioLevelLabel.Text = "Volume Level: " + Me.TrackBar1.Value.ToString()
        End If
        Form1.MediaControls1.TrackBar1.Value = Me.TrackBar1.Value
        Form1.MediaControls1.audioLevelLabel.Show()
    End Sub

    Private Sub RadioBox_Click(sender As Object, e As EventArgs) Handles RadioBox.Click
        If Not Me.radioOn Then
            Me.RadioBox.Image = My.Resources.ProjectResources.radioOn
            Me.radioPlayingBox.Show()
            Me.radioOn = True
            Me.RadioBox.Left = 35
            Me.RadioStationLabel.Text = Me.radioLabelMessage + Math.Round(Me.radioStation, 2).ToString
            Me.RadioStationLabel.Location = New Point(135, 475)
            Me.RadioStationLabel.Show()
            Me.plusBox.Show()
            Me.minusBox.Show()
            Form1.MediaControls1.RadioBox.PerformClick()
        Else
            Me.RadioStationLabel.Hide()
            Me.plusBox.Hide()
            Me.radioPlayingBox.Hide()
            Me.minusBox.Hide()
            Me.RadioBox.Image = My.Resources.ProjectResources.radio
            Me.radioOn = False
            Me.RadioBox.Left = 121
            Form1.MediaControls1.RadioBox.PerformClick()
        End If
    End Sub

    Private Sub plusBox_Click(sender As Object, e As EventArgs) Handles plusBox.Click
        If Me.radioStation + 0.2 <= 110 Then
            Me.radioStation += 0.2
            Me.RadioStationLabel.Text = Me.radioLabelMessage + Math.Round(Me.radioStation, 2).ToString
        End If
    End Sub

    Private Sub minusBox_Click(sender As Object, e As EventArgs) Handles minusBox.Click
        If Me.radioStation - 0.2 >= 90 Then
            Me.radioStation -= 0.2
            Me.RadioStationLabel.Text = Me.radioLabelMessage + Math.Round(Me.radioStation, 2).ToString
        End If
    End Sub
End Class
