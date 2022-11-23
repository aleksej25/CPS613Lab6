Imports System.Linq.Expressions
Imports System.Windows.Forms.LinkLabel

Public Class schedulerControl

    Public Shared ActivityText As String
    Public Shared RadiusText As String
    Private Function returnHour(ByVal time As String) As Integer

        Dim number As Integer

        If time = "08:00" Then
            number = 1
        End If
        If time = "09:00" Then
            number = 2
        End If
        If time = "10:00" Then
            number = 3
        End If
        If time = "11:00" Then
            number = 4
        End If
        If time = "12:00" Then
            number = 5
        End If
        If time = "13:00" Then
            number = 6
        End If
        If time = "14:00" Then
            number = 7
        End If
        If time = "15:00" Then
            number = 8
        End If
        If time = "16:00" Then
            number = 9
        End If
        If time = "17:00" Then
            number = 10
        End If

        Return number

    End Function

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Hide()
        Form1.CalendarControl1.Show()
    End Sub

    Function validData() As Boolean
        If ActivityBox.Text = "" Then
            MessageBox.Show("Invalid Activity Input", "Information", MessageBoxButtons.OKCancel)
            Return False
        End If
        If RadiusBox.Text = "" Then
            MessageBox.Show("Invalid Location Input", "Information", MessageBoxButtons.OKCancel)
            Return False
        End If
        Return True
    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.validData Then

            Dim hours_string As String = ""
            Dim hours_int As Integer = 0
            Dim time_string As String = ""
            Dim time_int As Integer = 0
            For Each radio_buttons As RadioButton In Me.GroupBox2.Controls

                If radio_buttons.Checked = True Then

                    hours_string = radio_buttons.Text

                End If

            Next

            If hours_string <> "" Then

                hours_int = CStr(hours_string)

            End If

            For Each radio_buttons2 As RadioButton In Me.GroupBox3.Controls

                If radio_buttons2.Checked = True Then

                    time_string = radio_buttons2.Text
                    time_int = Me.returnHour(time_string)

                End If

            Next

            Dim difference As Integer = time_int + hours_int - 1

            If (difference > 10) Then
                difference = 10
            End If
            If saturdayButton.Checked = True Then

                For current_time As Integer = time_int - 1 To difference - 1

                    If ActivityBox.Text = "Ridesharing" Then
                        Form1.CalendarControl1.saturday(current_time).BackColor = Color.PaleGreen
                        Form1.CalendarControl1.saturday(current_time).Text = "R"
                    ElseIf ActivityBox.Text = "Charge" Then
                        Form1.CalendarControl1.saturday(current_time).BackColor = Color.LightBlue
                        Form1.CalendarControl1.saturday(current_time).Text = "C"
                    ElseIf ActivityBox.Text = "Maintenence" Then
                        Form1.CalendarControl1.saturday(current_time).BackColor = Color.LightYellow
                        Form1.CalendarControl1.saturday(current_time).Text = "M"
                    End If

                Next
            End If

            If sundayButton.Checked = True Then

                For current_time As Integer = time_int - 1 To difference - 1

                    If ActivityBox.Text = "Ridesharing" Then
                        Form1.CalendarControl1.sunday(current_time).BackColor = Color.PaleGreen
                        Form1.CalendarControl1.sunday(current_time).Text = "R"
                    ElseIf ActivityBox.Text = "Charge" Then
                        Form1.CalendarControl1.sunday(current_time).BackColor = Color.LightBlue
                        Form1.CalendarControl1.sunday(current_time).Text = "C"
                    ElseIf ActivityBox.Text = "Maintenence" Then
                        Form1.CalendarControl1.sunday(current_time).BackColor = Color.LightYellow
                        Form1.CalendarControl1.sunday(current_time).Text = "M"
                    End If

                Next

            End If

            If mondayButton.Checked = True Then

                For current_time As Integer = time_int - 1 To difference - 1

                    If ActivityBox.Text = "Ridesharing" Then
                        Form1.CalendarControl1.monday(current_time).BackColor = Color.PaleGreen
                        Form1.CalendarControl1.monday(current_time).Text = "R"
                    ElseIf ActivityBox.Text = "Charge" Then
                        Form1.CalendarControl1.monday(current_time).BackColor = Color.LightBlue
                        Form1.CalendarControl1.monday(current_time).Text = "C"
                    ElseIf ActivityBox.Text = "Maintenence" Then
                        Form1.CalendarControl1.monday(current_time).BackColor = Color.LightYellow
                        Form1.CalendarControl1.monday(current_time).Text = "M"
                    End If

                Next

            End If

            If tuesdayButton.Checked = True Then

                For current_time As Integer = time_int - 1 To difference - 1

                    If ActivityBox.Text = "Ridesharing" Then
                        Form1.CalendarControl1.tuesday(current_time).BackColor = Color.PaleGreen
                        Form1.CalendarControl1.tuesday(current_time).Text = "R"
                    ElseIf ActivityBox.Text = "Charge" Then
                        Form1.CalendarControl1.tuesday(current_time).BackColor = Color.LightBlue
                        Form1.CalendarControl1.tuesday(current_time).Text = "C"
                    ElseIf ActivityBox.Text = "Maintenence" Then
                        Form1.CalendarControl1.tuesday(current_time).BackColor = Color.LightYellow
                        Form1.CalendarControl1.tuesday(current_time).Text = "M"
                    End If

                Next

            End If

            If wednesdayButton.Checked = True Then

                For current_time As Integer = time_int - 1 To difference - 1

                    If ActivityBox.Text = "Ridesharing" Then
                        Form1.CalendarControl1.wednesday(current_time).BackColor = Color.PaleGreen
                        Form1.CalendarControl1.wednesday(current_time).Text = "R"
                    ElseIf ActivityBox.Text = "Charge" Then
                        Form1.CalendarControl1.wednesday(current_time).BackColor = Color.LightBlue
                        Form1.CalendarControl1.wednesday(current_time).Text = "C"
                    ElseIf ActivityBox.Text = "Maintenence" Then
                        Form1.CalendarControl1.wednesday(current_time).BackColor = Color.LightYellow
                        Form1.CalendarControl1.wednesday(current_time).Text = "M"
                    End If

                Next

            End If

            If thursdayButton.Checked = True Then

                For current_time As Integer = time_int - 1 To difference - 1

                    If ActivityBox.Text = "Ridesharing" Then
                        Form1.CalendarControl1.thursday(current_time).BackColor = Color.PaleGreen
                        Form1.CalendarControl1.thursday(current_time).Text = "R"
                    ElseIf ActivityBox.Text = "Charge" Then
                        Form1.CalendarControl1.thursday(current_time).BackColor = Color.LightBlue
                        Form1.CalendarControl1.thursday(current_time).Text = "C"
                    ElseIf ActivityBox.Text = "Maintenence" Then
                        Form1.CalendarControl1.thursday(current_time).BackColor = Color.LightYellow
                        Form1.CalendarControl1.thursday(current_time).Text = "M"
                    End If

                Next

            End If

            If fridayButton.Checked = True Then

                For current_time As Integer = time_int - 1 To difference - 1

                    If ActivityBox.Text = "Ridesharing" Then
                        Form1.CalendarControl1.friday(current_time).BackColor = Color.PaleGreen
                        Form1.CalendarControl1.friday(current_time).Text = "R"
                    ElseIf ActivityBox.Text = "Charge" Then
                        Form1.CalendarControl1.friday(current_time).BackColor = Color.LightBlue
                        Form1.CalendarControl1.friday(current_time).Text = "C"
                    ElseIf ActivityBox.Text = "Maintenence" Then
                        Form1.CalendarControl1.friday(current_time).BackColor = Color.LightYellow
                        Form1.CalendarControl1.friday(current_time).Text = "M"
                    End If

                Next

            End If

            ActivityText = ActivityBox.Text
            RadiusText = RadiusBox.Text
            Me.ActivityBox.Text = ""
            Me.RadiusBox.Text = ""
            Me.Hide()
            Form1.CalendarControl1.Show()
        End If


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
