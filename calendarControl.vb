Public Class calendarControl

    Public Shared saturday = New Label() {Form1.CalendarControl1.Label3, Form1.CalendarControl1.Label25, Form1.CalendarControl1.Label32, Form1.CalendarControl1.Label39, Form1.CalendarControl1.Label46, Form1.CalendarControl1.Label53, Form1.CalendarControl1.Label60, Form1.CalendarControl1.Label67, Form1.CalendarControl1.Label74, Form1.CalendarControl1.Label81}
    Public Shared sunday = New Label() {Form1.CalendarControl1.Label2, Form1.CalendarControl1.Label24, Form1.CalendarControl1.Label31, Form1.CalendarControl1.Label38, Form1.CalendarControl1.Label45, Form1.CalendarControl1.Label52, Form1.CalendarControl1.Label59, Form1.CalendarControl1.Label66, Form1.CalendarControl1.Label73, Form1.CalendarControl1.Label80}
    Public Shared monday = New Label() {Form1.CalendarControl1.Label4, Form1.CalendarControl1.Label23, Form1.CalendarControl1.Label30, Form1.CalendarControl1.Label37, Form1.CalendarControl1.Label44, Form1.CalendarControl1.Label51, Form1.CalendarControl1.Label58, Form1.CalendarControl1.Label65, Form1.CalendarControl1.Label72, Form1.CalendarControl1.Label79}
    Public Shared tuesday = New Label() {Form1.CalendarControl1.Label5, Form1.CalendarControl1.Label22, Form1.CalendarControl1.Label29, Form1.CalendarControl1.Label36, Form1.CalendarControl1.Label43, Form1.CalendarControl1.Label50, Form1.CalendarControl1.Label57, Form1.CalendarControl1.Label64, Form1.CalendarControl1.Label71, Form1.CalendarControl1.Label78}
    Public Shared wednesday = New Label() {Form1.CalendarControl1.Label6, Form1.CalendarControl1.Label21, Form1.CalendarControl1.Label28, Form1.CalendarControl1.Label35, Form1.CalendarControl1.Label42, Form1.CalendarControl1.Label49, Form1.CalendarControl1.Label56, Form1.CalendarControl1.Label63, Form1.CalendarControl1.Label70, Form1.CalendarControl1.Label77}
    Public Shared thursday = New Label() {Form1.CalendarControl1.Label7, Form1.CalendarControl1.Label20, Form1.CalendarControl1.Label27, Form1.CalendarControl1.Label34, Form1.CalendarControl1.Label41, Form1.CalendarControl1.Label48, Form1.CalendarControl1.Label55, Form1.CalendarControl1.Label62, Form1.CalendarControl1.Label69, Form1.CalendarControl1.Label76}
    Public Shared friday = New Label() {Form1.CalendarControl1.Label18, Form1.CalendarControl1.Label19, Form1.CalendarControl1.Label26, Form1.CalendarControl1.Label33, Form1.CalendarControl1.Label40, Form1.CalendarControl1.Label47, Form1.CalendarControl1.Label54, Form1.CalendarControl1.Label61, Form1.CalendarControl1.Label68, Form1.CalendarControl1.Label75}


    Dim negativeClicked As Boolean = False
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Hide()
        Form1.OwnerMainScreen1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.SchedulerControl1.BringToFront()
        Form1.SchedulerControl1.Show()
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

        If negativeClicked = True Then
            Label3.Text = ""
            Label3.BackColor = Color.White
            Exit Sub
        End If



        If Label3.Text = "" Or Label3.Text = " " Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        Else
            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If

    End Sub



    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        If negativeClicked = True Then
            Label7.Text = ""
            Label7.BackColor = Color.White
            Exit Sub
        End If

        If Label7.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label7.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label57_Click(sender As Object, e As EventArgs)
        If Label57.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label57.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Label57.Text
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label50_Click(sender As Object, e As EventArgs)
        If Label50.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label50.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Label50.Text
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label43_Click(sender As Object, e As EventArgs)
        If Label43.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label43.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Label43.Text
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label36_Click(sender As Object, e As EventArgs)
        If Label36.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label36.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Label36.Text
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label29_Click(sender As Object, e As EventArgs)
        If Label29.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label29.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Label29.Text
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs)
        If Label22.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label22.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Label22.Text
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label75_Click(sender As Object, e As EventArgs) Handles Label75.Click

        If negativeClicked = True Then
            Label75.Text = ""
            Label75.BackColor = Color.White
            Exit Sub
        End If



        If Label75.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label75.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label76_Click(sender As Object, e As EventArgs) Handles Label76.Click

        If negativeClicked = True Then
            Label76.Text = ""
            Label76.BackColor = Color.White
            Exit Sub
        End If


        If Label76.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label76.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label77_Click(sender As Object, e As EventArgs) Handles Label77.Click

        If negativeClicked = True Then
            Label77.Text = ""
            Label77.BackColor = Color.White
            Exit Sub
        End If


        If Label77.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label77.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label78_Click(sender As Object, e As EventArgs) Handles Label78.Click

        If negativeClicked = True Then
            Label78.Text = ""
            Label78.BackColor = Color.White
            Exit Sub
        End If


        If Label78.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label78.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label79_Click(sender As Object, e As EventArgs) Handles Label79.Click

        If negativeClicked = True Then
            Label79.Text = ""
            Label79.BackColor = Color.White
            Exit Sub
        End If


        If Label79.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label79.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label81_Click(sender As Object, e As EventArgs) Handles Label81.Click

        If negativeClicked = True Then
            Label81.Text = ""
            Label81.BackColor = Color.White
            Exit Sub
        End If


        If Label81.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label81.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Label81.Text
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label80_Click(sender As Object, e As EventArgs) Handles Label80.Click

        If negativeClicked = True Then
            Label80.Text = ""
            Label80.BackColor = Color.White
            Exit Sub
        End If


        If Label80.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label80.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label74_Click(sender As Object, e As EventArgs) Handles Label74.Click

        If negativeClicked = True Then
            Label74.Text = ""
            Label74.BackColor = Color.White
            Exit Sub
        End If

        If Label74.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label74.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label72_Click(sender As Object, e As EventArgs) Handles Label72.Click

        If negativeClicked = True Then
            Label72.Text = ""
            Label72.BackColor = Color.White
            Exit Sub
        End If


        If Label72.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label72.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label69_Click(sender As Object, e As EventArgs) Handles Label69.Click

        If negativeClicked = True Then
            Label69.Text = ""
            Label69.BackColor = Color.White
            Exit Sub
        End If

        If Label69.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label69.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label62_Click(sender As Object, e As EventArgs) Handles Label62.Click

        If negativeClicked = True Then
            Label62.Text = ""
            Label62.BackColor = Color.White
            Exit Sub
        End If

        If Label62.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label62.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label63_Click(sender As Object, e As EventArgs) Handles Label63.Click

        If negativeClicked = True Then
            Label63.Text = ""
            Label63.BackColor = Color.White
            Exit Sub
        End If


        If Label63.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label63.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label64_Click(sender As Object, e As EventArgs) Handles Label64.Click

        If negativeClicked = True Then
            Label64.Text = ""
            Label64.BackColor = Color.White
            Exit Sub
        End If

        If Label64.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label64.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label66_Click(sender As Object, e As EventArgs) Handles Label66.Click

        If negativeClicked = True Then
            Label66.Text = ""
            Label66.BackColor = Color.White
            Exit Sub
        End If

        If Label66.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label66.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label67_Click(sender As Object, e As EventArgs) Handles Label67.Click

        If negativeClicked = True Then
            Label67.Text = ""
            Label67.BackColor = Color.White
            Exit Sub
        End If

        If Label67.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label67.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label65_Click(sender As Object, e As EventArgs) Handles Label65.Click

        If negativeClicked = True Then
            Label65.Text = ""
            Label65.BackColor = Color.White
            Exit Sub
        End If

        If Label65.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label65.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label71_Click(sender As Object, e As EventArgs) Handles Label71.Click

        If negativeClicked = True Then
            Label71.Text = ""
            Label71.BackColor = Color.White
            Exit Sub
        End If

        If Label71.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label71.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label70_Click(sender As Object, e As EventArgs) Handles Label70.Click

        If negativeClicked = True Then
            Label70.Text = ""
            Label70.BackColor = Color.White
            Exit Sub
        End If

        If Label70.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label70.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label40_Click(sender As Object, e As EventArgs) Handles Label40.Click

        If negativeClicked = True Then
            Label40.Text = ""
            Label40.BackColor = Color.White
            Exit Sub
        End If

        If Label40.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label40.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label41_Click(sender As Object, e As EventArgs) Handles Label41.Click

        If negativeClicked = True Then
            Label41.Text = ""
            Label41.BackColor = Color.White
            Exit Sub
        End If

        If Label41.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label41.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label43_Click_1(sender As Object, e As EventArgs) Handles Label43.Click

        If negativeClicked = True Then
            Label43.Text = ""
            Label43.BackColor = Color.White
            Exit Sub
        End If

        If Label43.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label43.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label42_Click(sender As Object, e As EventArgs) Handles Label42.Click

        If negativeClicked = True Then
            Label42.Text = ""
            Label42.BackColor = Color.White
            Exit Sub
        End If

        If Label42.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label42.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Label2.Click

        If negativeClicked = True Then
            Label2.Text = ""
            Label2.BackColor = Color.White
            Exit Sub
        End If

        If Label2.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label2.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        If negativeClicked = True Then
            Label4.Text = ""
            Label4.BackColor = Color.White
            Exit Sub
        End If


        If Label4.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label4.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

        If negativeClicked = True Then
            Label5.Text = ""
            Label5.BackColor = Color.White
            Exit Sub
        End If

        If Label5.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label5.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

        If negativeClicked = True Then
            Label6.Text = ""
            Label6.BackColor = Color.White
            Exit Sub
        End If

        If Label6.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label6.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click

        If negativeClicked = True Then
            Label18.Text = ""
            Label18.BackColor = Color.White
            Exit Sub
        End If

        If Label18.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label18.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label25_Click(sender As Object, e As EventArgs) Handles Label25.Click


        If negativeClicked = True Then
            Label25.Text = ""
            Label25.BackColor = Color.White
            Exit Sub
        End If


        If Label25.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label25.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click

        If negativeClicked = True Then
            Label24.Text = ""
            Label24.BackColor = Color.White
            Exit Sub
        End If

        If Label24.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label24.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click

        If negativeClicked = True Then
            Label23.Text = ""
            Label23.BackColor = Color.White
            Exit Sub
        End If

        If Label23.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label23.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label22_Click_1(sender As Object, e As EventArgs) Handles Label22.Click

        If negativeClicked = True Then
            Label22.Text = ""
            Label22.BackColor = Color.White
            Exit Sub
        End If

        If Label22.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label22.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click

        If negativeClicked = True Then
            Label21.Text = ""
            Label21.BackColor = Color.White
            Exit Sub
        End If

        If Label21.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label21.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click

        If negativeClicked = True Then
            Label20.Text = ""
            Label20.BackColor = Color.White
            Exit Sub
        End If


        If Label20.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label20.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click

        If negativeClicked = True Then
            Label19.Text = ""
            Label19.BackColor = Color.White
            Exit Sub
        End If

        If Label19.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label19.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label32_Click(sender As Object, e As EventArgs) Handles Label32.Click

        If negativeClicked = True Then
            Label32.Text = ""
            Label32.BackColor = Color.White
            Exit Sub
        End If

        If Label32.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label32.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label31_Click(sender As Object, e As EventArgs) Handles Label31.Click

        If negativeClicked = True Then
            Label31.Text = ""
            Label31.BackColor = Color.White
            Exit Sub
        End If

        If Label31.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label31.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label30_Click(sender As Object, e As EventArgs) Handles Label30.Click

        If negativeClicked = True Then
            Label30.Text = ""
            Label30.BackColor = Color.White
            Exit Sub
        End If

        If Label30.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label30.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label29_Click_1(sender As Object, e As EventArgs) Handles Label29.Click

        If negativeClicked = True Then
            Label29.Text = ""
            Label29.BackColor = Color.White
            Exit Sub
        End If

        If Label29.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label29.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label28_Click(sender As Object, e As EventArgs) Handles Label28.Click

        If negativeClicked = True Then
            Label28.Text = ""
            Label28.BackColor = Color.White
            Exit Sub
        End If

        If Label28.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label28.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label27_Click(sender As Object, e As EventArgs) Handles Label27.Click

        If negativeClicked = True Then
            Label27.Text = ""
            Label27.BackColor = Color.White
            Exit Sub
        End If

        If Label27.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label27.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs) Handles Label26.Click

        If negativeClicked = True Then
            Label26.Text = ""
            Label26.BackColor = Color.White
            Exit Sub
        End If

        If Label26.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label26.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label39_Click(sender As Object, e As EventArgs) Handles Label39.Click

        If negativeClicked = True Then
            Label39.Text = ""
            Label39.BackColor = Color.White
            Exit Sub
        End If

        If Label39.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label39.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label38_Click(sender As Object, e As EventArgs) Handles Label38.Click

        If negativeClicked = True Then
            Label38.Text = ""
            Label38.BackColor = Color.White
            Exit Sub
        End If

        If Label38.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label38.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label37_Click(sender As Object, e As EventArgs) Handles Label37.Click

        If negativeClicked = True Then
            Label37.Text = ""
            Label37.BackColor = Color.White
            Exit Sub
        End If

        If Label37.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label37.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label36_Click_1(sender As Object, e As EventArgs) Handles Label36.Click

        If negativeClicked = True Then
            Label36.Text = ""
            Label36.BackColor = Color.White
            Exit Sub
        End If

        If Label36.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label36.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label35_Click(sender As Object, e As EventArgs) Handles Label35.Click


        If negativeClicked = True Then
            Label35.Text = ""
            Label35.BackColor = Color.White
            Exit Sub
        End If

        If Label35.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label35.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label34_Click(sender As Object, e As EventArgs) Handles Label34.Click

        If negativeClicked = True Then
            Label34.Text = ""
            Label34.BackColor = Color.White
            Exit Sub
        End If

        If Label34.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label34.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label33_Click(sender As Object, e As EventArgs) Handles Label33.Click

        If negativeClicked = True Then
            Label33.Text = ""
            Label33.BackColor = Color.White
            Exit Sub
        End If

        If Label33.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label33.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label46_Click(sender As Object, e As EventArgs) Handles Label46.Click

        If negativeClicked = True Then
            Label46.Text = ""
            Label46.BackColor = Color.White
            Exit Sub
        End If

        If Label46.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label46.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label45_Click(sender As Object, e As EventArgs) Handles Label45.Click

        If negativeClicked = True Then
            Label45.Text = ""
            Label45.BackColor = Color.White
            Exit Sub
        End If

        If Label45.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label45.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label44_Click(sender As Object, e As EventArgs) Handles Label44.Click

        If negativeClicked = True Then
            Label44.Text = ""
            Label44.BackColor = Color.White
            Exit Sub
        End If

        If Label44.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label44.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label53_Click(sender As Object, e As EventArgs) Handles Label53.Click

        If negativeClicked = True Then
            Label53.Text = ""
            Label53.BackColor = Color.White
            Exit Sub
        End If

        If Label53.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label53.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label52_Click(sender As Object, e As EventArgs) Handles Label52.Click

        If negativeClicked = True Then
            Label52.Text = ""
            Label52.BackColor = Color.White
            Exit Sub
        End If

        If Label52.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label52.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label51_Click(sender As Object, e As EventArgs) Handles Label51.Click

        If negativeClicked = True Then
            Label51.Text = ""
            Label51.BackColor = Color.White
            Exit Sub
        End If

        If Label51.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label51.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label50_Click_1(sender As Object, e As EventArgs) Handles Label50.Click

        If negativeClicked = True Then
            Label50.Text = ""
            Label50.BackColor = Color.White
            Exit Sub
        End If

        If Label50.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label50.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label49_Click(sender As Object, e As EventArgs) Handles Label49.Click

        If negativeClicked = True Then
            Label49.Text = ""
            Label49.BackColor = Color.White
            Exit Sub
        End If

        If Label49.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label49.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label48_Click(sender As Object, e As EventArgs) Handles Label48.Click

        If negativeClicked = True Then
            Label48.Text = ""
            Label48.BackColor = Color.White
            Exit Sub
        End If

        If Label48.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label48.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label47_Click(sender As Object, e As EventArgs) Handles Label47.Click

        If negativeClicked = True Then
            Label47.Text = ""
            Label47.BackColor = Color.White
            Exit Sub
        End If

        If Label47.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label47.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label60_Click(sender As Object, e As EventArgs) Handles Label60.Click

        If negativeClicked = True Then
            Label60.Text = ""
            Label60.BackColor = Color.White
            Exit Sub
        End If

        If Label60.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label60.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label59_Click(sender As Object, e As EventArgs) Handles Label59.Click

        If negativeClicked = True Then
            Label59.Text = ""
            Label59.BackColor = Color.White
            Exit Sub
        End If

        If Label59.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label59.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label58_Click(sender As Object, e As EventArgs) Handles Label58.Click

        If negativeClicked = True Then
            Label58.Text = ""
            Label58.BackColor = Color.White
            Exit Sub
        End If

        If Label58.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label58.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label57_Click_1(sender As Object, e As EventArgs) Handles Label57.Click

        If negativeClicked = True Then
            Label57.Text = ""
            Label57.BackColor = Color.White
            Exit Sub
        End If

        If Label57.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label57.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label56_Click(sender As Object, e As EventArgs) Handles Label56.Click

        If negativeClicked = True Then
            Label56.Text = ""
            Label56.BackColor = Color.White
            Exit Sub
        End If

        If Label56.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label56.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label55_Click(sender As Object, e As EventArgs) Handles Label55.Click

        If negativeClicked = True Then
            Label55.Text = ""
            Label55.BackColor = Color.White
            Exit Sub
        End If

        If Label55.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label55.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label54_Click(sender As Object, e As EventArgs) Handles Label54.Click

        If negativeClicked = True Then
            Label54.Text = ""
            Label54.BackColor = Color.White
            Exit Sub
        End If

        If Label54.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label54.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Label73_Click(sender As Object, e As EventArgs) Handles Label73.Click

        If negativeClicked = True Then
            Label73.Text = ""
            Label73.BackColor = Color.White
            Exit Sub
        End If

        If Label73.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label73.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim counter As Integer = 0

        For Each label As Control In Me.Controls

            If label.BackColor = Color.Blue Then
                counter = counter + 1
            End If


        Next

        If counter = 0 And negativeClicked = False Then
            MessageBox.Show("Not possible", "Information", MessageBoxButtons.OKCancel)
            Exit Sub
        End If

        If counter = 0 And negativeClicked = True Then

            Button1.Show()

        End If

        If negativeClicked = False Then
            negativeClicked = True
            Button1.Hide()
        ElseIf negativeClicked = True Then
            negativeClicked = False
            Button1.Show()
        End If

    End Sub

    Private Sub Label61_Click(sender As Object, e As EventArgs) Handles Label61.Click
        If negativeClicked = True Then
            Label61.Text = ""
            Label61.BackColor = Color.White
            Exit Sub
        End If

        If Label61.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label61.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)

        End If

    End Sub

    Private Sub Label68_Click(sender As Object, e As EventArgs) Handles Label68.Click

        If negativeClicked = True Then
            Label68.Text = ""
            Label68.BackColor = Color.White
            Exit Sub
        End If

        If Label68.Text = "" Then

            MessageBox.Show("Nothing scheduled ", "Information", MessageBoxButtons.OKCancel)


        ElseIf Label68.Text <> "" Then

            Dim String2 As String()
            Dim String1 As String
            Dim line1 As String
            Dim line2 As String

            String1 = Form1.SchedulerControl1.ActivityText + " " + Form1.SchedulerControl1.RadiusText
            String2 = String1.Split(" ")

            line1 = String2(0)

            line2 = String2(1)

            MessageBox.Show("Activity: " & line1 & vbCrLf & "Radius: " & line2, "Information", MessageBoxButtons.OKCancel)
        End If

    End Sub
End Class
