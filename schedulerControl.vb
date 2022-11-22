Imports System.Linq.Expressions
Imports System.Windows.Forms.LinkLabel

Public Class schedulerControl

    ' Dim saturday_label = New Label() {Form1.CalendarControl1.Label3, Form1.CalendarControl1.Label25, Form1.CalendarControl1.Label32, Form1.CalendarControl1.Label39, Form1.CalendarControl1.Label46, Form1.CalendarControl1.Label53, Form1.CalendarControl1.Label60, Form1.CalendarControl1.Label67, Form1.CalendarControl1.Label74, Form1.CalendarControl1.Label81}
    '  Dim sunday = New Label() {Form1.CalendarControl1.Label2, Form1.CalendarControl1.Label24, Form1.CalendarControl1.Label31, Form1.CalendarControl1.Label38, Form1.CalendarControl1.Label45, Form1.CalendarControl1.Label52, Form1.CalendarControl1.Label59, Form1.CalendarControl1.Label66, Form1.CalendarControl1.Label73, Form1.CalendarControl1.Label80}
    ' Dim monday = New Label() {Form1.CalendarControl1.Label4, Form1.CalendarControl1.Label23, Form1.CalendarControl1.Label30, Form1.CalendarControl1.Label37, Form1.CalendarControl1.Label44, Form1.CalendarControl1.Label51, Form1.CalendarControl1.Label58, Form1.CalendarControl1.Label65, Form1.CalendarControl1.Label72, Form1.CalendarControl1.Label79}
    'Dim tuesday = New Label() {Form1.CalendarControl1.Label5, Form1.CalendarControl1.Label22, Form1.CalendarControl1.Label29, Form1.CalendarControl1.Label36, Form1.CalendarControl1.Label43, Form1.CalendarControl1.Label50, Form1.CalendarControl1.Label57, Form1.CalendarControl1.Label64, Form1.CalendarControl1.Label71, Form1.CalendarControl1.Label78}
    'Dim wednesday = New Label() {Form1.CalendarControl1.Label6, Form1.CalendarControl1.Label21, Form1.CalendarControl1.Label28, Form1.CalendarControl1.Label35, Form1.CalendarControl1.Label42, Form1.CalendarControl1.Label49, Form1.CalendarControl1.Label56, Form1.CalendarControl1.Label63, Form1.CalendarControl1.Label70, Form1.CalendarControl1.Label77}
    'Dim thursday = New Label() {Form1.CalendarControl1.Label7, Form1.CalendarControl1.Label20, Form1.CalendarControl1.Label27, Form1.CalendarControl1.Label34, Form1.CalendarControl1.Label41, Form1.CalendarControl1.Label48, Form1.CalendarControl1.Label55, Form1.CalendarControl1.Label62, Form1.CalendarControl1.Label69, Form1.CalendarControl1.Label76}
    'Dim friday = New Label() {Form1.CalendarControl1.Label18, Form1.CalendarControl1.Label19, Form1.CalendarControl1.Label26, Form1.CalendarControl1.Label33, Form1.CalendarControl1.Label40, Form1.CalendarControl1.Label47, Form1.CalendarControl1.Label54, Form1.CalendarControl1.Label61, Form1.CalendarControl1.Label68, Form1.CalendarControl1.Label75}



    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Hide()
        Form1.CalendarControl1.Show()
    End Sub

    Function validData() As Boolean
        If activityTextBox.Text = "" Then
            MessageBox.Show("Invalid Activity Input", "Information", MessageBoxButtons.OKCancel)
            Return False
        End If
        If locationTextBox.Text = "" Then
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
                    time_int = CStr(time_string)
                End If

            Next

            Dim difference As Integer = time_int + hours_int - 1

            If (difference > 10) Then
                difference = 10
            End If
            If saturdayButton.Checked = True Then

                    For current_time As Integer = time_int - 1 To difference - 1

                        Form1.CalendarControl1.saturday(current_time).BackColor = Color.Blue



                    Next


                End If

                If sundayButton.Checked = True Then

                    For current_time As Integer = time_int - 1 To difference - 1

                        Form1.CalendarControl1.sunday(current_time).BackColor = Color.Blue



                    Next


                End If

                If mondayButton.Checked = True Then

                    For current_time As Integer = time_int - 1 To difference - 1

                        Form1.CalendarControl1.monday(current_time).BackColor = Color.Blue



                    Next


                End If

                If tuesdayButton.Checked = True Then

                    For current_time As Integer = time_int - 1 To difference - 1

                        Form1.CalendarControl1.tuesday(current_time).BackColor = Color.Blue



                    Next


                End If

                If wednesdayButton.Checked = True Then

                    For current_time As Integer = time_int - 1 To difference - 1

                        Form1.CalendarControl1.wednesday(current_time).BackColor = Color.Blue



                    Next


                End If

                If thursdayButton.Checked = True Then

                    For current_time As Integer = time_int - 1 To difference - 1

                        Form1.CalendarControl1.thursday(current_time).BackColor = Color.Blue



                    Next


                End If

                If fridayButton.Checked = True Then

                    For current_time As Integer = time_int - 1 To difference - 1

                        Form1.CalendarControl1.friday(current_time).BackColor = Color.Blue



                    Next


                End If

                Me.activityTextBox.Text = ""
                Me.locationTextBox.Text = ""
                Me.Hide()
                Form1.CalendarControl1.Show()
            End If


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
