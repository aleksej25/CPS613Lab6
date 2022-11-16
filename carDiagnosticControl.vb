Imports System.Reflection.Emit
Imports System.Threading

Public Class carDiagnosticControl
    Public ticker As Integer = 0
    Public selectedCamera As String = ""

    Private Sub diagnostic_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.interiorButton.Select()
        Me.selectedCamera = "interior"
    End Sub

    Private Sub BackBox_Click(sender As Object, e As EventArgs) Handles BackBox.Click
        Me.Hide()
        Form1.ECarControls.BringToFront()
        Form1.ECarControls.Show()
    End Sub

    Private Sub gearsBox_Click(sender As Object, e As EventArgs) Handles gearsBox.Click
        Me.ticker = 0
        Me.Timer1.Start()
        Me.gearsBox.Image = My.Resources.ProjectResources.spinningGear
        Me.diagnosticLabel.Text = "Running Diagnostic"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.ticker += 1
        If Me.ticker >= 25 Then
            Me.ticker = 0
            Thread.Sleep(1500)
            Me.Timer2.Start()
            Me.Timer1.Stop()
        End If
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.ticker += 1
        Me.gearsBox.Image = My.Resources.ProjectResources.repairsIcon
        Me.diagnosticLabel.Text = "Diagnostic Complete"
        Me.diagnosticLabel.ForeColor = Color.LimeGreen
        Me.diagnosticReport.Text = "Nothing to Report"
        Me.diagnosticReport.ForeColor = Color.LimeGreen
        Me.diagnosticReport.Show()
        If Me.ticker >= 25 Then
            Me.diagnosticReport.Hide()
            Me.diagnosticLabel.Text = "Run Diagnostic"
            Me.diagnosticLabel.ForeColor = Color.White
            Me.Timer2.Stop()
        End If
    End Sub

    Private Sub cameraBox_Click(sender As Object, e As EventArgs) Handles cameraBox.Click
        If interiorButton.Checked Then
            Form1.CameraViewControl1.PictureBox1.Image = My.Resources.ProjectResources.camInside
        ElseIf exteriorButton.Checked Then
            Form1.CameraViewControl1.PictureBox1.Image = My.Resources.ProjectResources.camOutside
        End If
        Me.Hide()
        Form1.CameraViewControl1.BringToFront()
        Form1.CameraViewControl1.Show()
    End Sub

    Private Sub mapBox_Click(sender As Object, e As EventArgs) Handles mapBox.Click
        Form1.CameraViewControl1.PictureBox1.Image = My.Resources.ProjectResources.carLocation
        Me.Hide()
        Form1.CameraViewControl1.BringToFront()
        Form1.CameraViewControl1.Show()
    End Sub

    Private Sub summonBox_Click(sender As Object, e As EventArgs) Handles summonBox.Click
        Me.summonBox.Image = My.Resources.ProjectResources.returningHome
        Me.summonLabel.Text = "Coming Home"
    End Sub

    Private Sub kickOutBox_Click(sender As Object, e As EventArgs) Handles kickOutBox.Click
        Me.kickOutBox.Image = My.Resources.ProjectResources.kickOutComplete
        Me.kickOutLabel.Text = "Successfully Kicked Out Rider"
        Me.kickOutLabel.Left = (Me.kickOutLabel.Parent.Width \ 2) - (Me.kickOutLabel.Width \ 2)
    End Sub

End Class
