Imports System.Linq.Expressions
Imports System.Windows.Forms.LinkLabel

Public Class schedulerControl

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Hide()
        Form1.CalendarControl1.BringToFront()
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
            If sundayButton.Checked = True Then


                If RadioButton8.Checked = True Then
                    Form1.CalendarControl1.Label2.BackColor = Color.Blue
                    Form1.CalendarControl1.Label2.Text = activityTextBox.Text


                End If

                If RadioButton9.Checked = True Then
                    Form1.CalendarControl1.Label24.BackColor = Color.Blue
                    Form1.CalendarControl1.Label24.Text = activityTextBox.Text


                End If

                If RadioButton10.Checked = True Then
                    Form1.CalendarControl1.Label31.BackColor = Color.Blue
                    Form1.CalendarControl1.Label31.Text = activityTextBox.Text


                End If

                If RadioButton11.Checked = True Then
                    Form1.CalendarControl1.Label38.BackColor = Color.Blue
                    Form1.CalendarControl1.Label38.Text = activityTextBox.Text


                End If

                If RadioButton12.Checked = True Then
                    Form1.CalendarControl1.Label45.BackColor = Color.Blue
                    Form1.CalendarControl1.Label45.Text = activityTextBox.Text


                End If

                If RadioButton13.Checked = True Then
                    Form1.CalendarControl1.Label52.BackColor = Color.Blue
                    Form1.CalendarControl1.Label52.Text = activityTextBox.Text


                End If

                If RadioButton14.Checked = True Then
                    Form1.CalendarControl1.Label59.BackColor = Color.Blue
                    Form1.CalendarControl1.Label59.Text = activityTextBox.Text


                End If

                If RadioButton15.Checked = True Then
                    Form1.CalendarControl1.Label66.BackColor = Color.Blue
                    Form1.CalendarControl1.Label66.Text = activityTextBox.Text


                End If

                If RadioButton16.Checked = True Then
                    Form1.CalendarControl1.Label73.BackColor = Color.Blue
                    Form1.CalendarControl1.Label73.Text = activityTextBox.Text


                End If

                If RadioButton17.Checked = True Then
                    Form1.CalendarControl1.Label80.BackColor = Color.Blue
                    Form1.CalendarControl1.Label80.Text = activityTextBox.Text


                End If

            End If

            If mondayButton.Checked = True Then


                If RadioButton8.Checked = True Then
                    Form1.CalendarControl1.Label4.BackColor = Color.Blue
                    Form1.CalendarControl1.Label4.Text = activityTextBox.Text


                End If

                If RadioButton9.Checked = True Then
                    Form1.CalendarControl1.Label23.BackColor = Color.Blue
                    Form1.CalendarControl1.Label23.Text = activityTextBox.Text


                End If

                If RadioButton10.Checked = True Then
                    Form1.CalendarControl1.Label30.BackColor = Color.Blue
                    Form1.CalendarControl1.Label30.Text = activityTextBox.Text


                End If

                If RadioButton11.Checked = True Then
                    Form1.CalendarControl1.Label37.BackColor = Color.Blue
                    Form1.CalendarControl1.Label37.Text = activityTextBox.Text


                End If

                If RadioButton12.Checked = True Then
                    Form1.CalendarControl1.Label44.BackColor = Color.Blue
                    Form1.CalendarControl1.Label44.Text = activityTextBox.Text


                End If

                If RadioButton13.Checked = True Then
                    Form1.CalendarControl1.Label51.BackColor = Color.Blue
                    Form1.CalendarControl1.Label51.Text = activityTextBox.Text


                End If

                If RadioButton14.Checked = True Then
                    Form1.CalendarControl1.Label58.BackColor = Color.Blue
                    Form1.CalendarControl1.Label58.Text = activityTextBox.Text


                End If

                If RadioButton15.Checked = True Then
                    Form1.CalendarControl1.Label65.BackColor = Color.Blue
                    Form1.CalendarControl1.Label65.Text = activityTextBox.Text


                End If

                If RadioButton16.Checked = True Then
                    Form1.CalendarControl1.Label72.BackColor = Color.Blue
                    Form1.CalendarControl1.Label72.Text = activityTextBox.Text


                End If

                If RadioButton17.Checked = True Then
                    Form1.CalendarControl1.Label79.BackColor = Color.Blue
                    Form1.CalendarControl1.Label79.Text = activityTextBox.Text


                End If

            End If

            If tuesdayButton.Checked = True Then


                If RadioButton8.Checked = True Then
                    Form1.CalendarControl1.Label5.BackColor = Color.Blue
                    Form1.CalendarControl1.Label5.Text = activityTextBox.Text


                End If

                If RadioButton9.Checked = True Then
                    Form1.CalendarControl1.Label22.BackColor = Color.Blue
                    Form1.CalendarControl1.Label22.Text = activityTextBox.Text


                End If

                If RadioButton10.Checked = True Then
                    Form1.CalendarControl1.Label29.BackColor = Color.Blue
                    Form1.CalendarControl1.Label29.Text = activityTextBox.Text


                End If

                If RadioButton11.Checked = True Then
                    Form1.CalendarControl1.Label36.BackColor = Color.Blue
                    Form1.CalendarControl1.Label36.Text = activityTextBox.Text


                End If

                If RadioButton12.Checked = True Then
                    Form1.CalendarControl1.Label43.BackColor = Color.Blue
                    Form1.CalendarControl1.Label43.Text = activityTextBox.Text


                End If

                If RadioButton13.Checked = True Then
                    Form1.CalendarControl1.Label50.BackColor = Color.Blue
                    Form1.CalendarControl1.Label50.Text = activityTextBox.Text


                End If

                If RadioButton14.Checked = True Then
                    Form1.CalendarControl1.Label57.BackColor = Color.Blue
                    Form1.CalendarControl1.Label57.Text = activityTextBox.Text


                End If

                If RadioButton15.Checked = True Then
                    Form1.CalendarControl1.Label64.BackColor = Color.Blue
                    Form1.CalendarControl1.Label64.Text = activityTextBox.Text


                End If

                If RadioButton16.Checked = True Then
                    Form1.CalendarControl1.Label71.BackColor = Color.Blue
                    Form1.CalendarControl1.Label71.Text = activityTextBox.Text


                End If

                If RadioButton17.Checked = True Then
                    Form1.CalendarControl1.Label78.BackColor = Color.Blue
                    Form1.CalendarControl1.Label78.Text = activityTextBox.Text


                End If

            End If

            If wednesdayButton.Checked = True Then


                If RadioButton8.Checked = True Then
                    Form1.CalendarControl1.Label6.BackColor = Color.Blue
                    Form1.CalendarControl1.Label6.Text = activityTextBox.Text


                End If

                If RadioButton9.Checked = True Then
                    Form1.CalendarControl1.Label21.BackColor = Color.Blue
                    Form1.CalendarControl1.Label21.Text = activityTextBox.Text


                End If

                If RadioButton10.Checked = True Then
                    Form1.CalendarControl1.Label28.BackColor = Color.Blue
                    Form1.CalendarControl1.Label28.Text = activityTextBox.Text


                End If

                If RadioButton11.Checked = True Then
                    Form1.CalendarControl1.Label35.BackColor = Color.Blue
                    Form1.CalendarControl1.Label35.Text = activityTextBox.Text


                End If

                If RadioButton12.Checked = True Then
                    Form1.CalendarControl1.Label42.BackColor = Color.Blue
                    Form1.CalendarControl1.Label42.Text = activityTextBox.Text


                End If

                If RadioButton13.Checked = True Then
                    Form1.CalendarControl1.Label49.BackColor = Color.Blue
                    Form1.CalendarControl1.Label49.Text = activityTextBox.Text


                End If

                If RadioButton14.Checked = True Then
                    Form1.CalendarControl1.Label56.BackColor = Color.Blue
                    Form1.CalendarControl1.Label56.Text = activityTextBox.Text


                End If

                If RadioButton15.Checked = True Then
                    Form1.CalendarControl1.Label63.BackColor = Color.Blue
                    Form1.CalendarControl1.Label63.Text = activityTextBox.Text


                End If

                If RadioButton16.Checked = True Then
                    Form1.CalendarControl1.Label70.BackColor = Color.Blue
                    Form1.CalendarControl1.Label70.Text = activityTextBox.Text


                End If

                If RadioButton17.Checked = True Then
                    Form1.CalendarControl1.Label77.BackColor = Color.Blue
                    Form1.CalendarControl1.Label77.Text = activityTextBox.Text


                End If

            End If

            If thursdayButton.Checked = True Then


                If RadioButton8.Checked = True Then
                    Form1.CalendarControl1.Label7.BackColor = Color.Blue
                    Form1.CalendarControl1.Label7.Text = activityTextBox.Text


                End If

                If RadioButton9.Checked = True Then
                    Form1.CalendarControl1.Label20.BackColor = Color.Blue
                    Form1.CalendarControl1.Label20.Text = activityTextBox.Text


                End If

                If RadioButton10.Checked = True Then
                    Form1.CalendarControl1.Label27.BackColor = Color.Blue
                    Form1.CalendarControl1.Label27.Text = activityTextBox.Text


                End If

                If RadioButton11.Checked = True Then
                    Form1.CalendarControl1.Label34.BackColor = Color.Blue
                    Form1.CalendarControl1.Label34.Text = activityTextBox.Text


                End If

                If RadioButton12.Checked = True Then
                    Form1.CalendarControl1.Label41.BackColor = Color.Blue
                    Form1.CalendarControl1.Label41.Text = activityTextBox.Text


                End If

                If RadioButton13.Checked = True Then
                    Form1.CalendarControl1.Label48.BackColor = Color.Blue
                    Form1.CalendarControl1.Label48.Text = activityTextBox.Text


                End If

                If RadioButton14.Checked = True Then
                    Form1.CalendarControl1.Label55.BackColor = Color.Blue
                    Form1.CalendarControl1.Label55.Text = activityTextBox.Text


                End If

                If RadioButton15.Checked = True Then
                    Form1.CalendarControl1.Label62.BackColor = Color.Blue
                    Form1.CalendarControl1.Label62.Text = activityTextBox.Text


                End If

                If RadioButton16.Checked = True Then
                    Form1.CalendarControl1.Label69.BackColor = Color.Blue
                    Form1.CalendarControl1.Label69.Text = activityTextBox.Text


                End If

                If RadioButton17.Checked = True Then
                    Form1.CalendarControl1.Label76.BackColor = Color.Blue
                    Form1.CalendarControl1.Label76.Text = activityTextBox.Text


                End If

            End If

            If fridayButton.Checked = True Then


                If RadioButton8.Checked = True Then
                    Form1.CalendarControl1.Label18.BackColor = Color.Blue
                    Form1.CalendarControl1.Label18.Text = activityTextBox.Text


                End If

                If RadioButton9.Checked = True Then
                    Form1.CalendarControl1.Label19.BackColor = Color.Blue
                    Form1.CalendarControl1.Label19.Text = activityTextBox.Text


                End If

                If RadioButton10.Checked = True Then
                    Form1.CalendarControl1.Label26.BackColor = Color.Blue
                    Form1.CalendarControl1.Label26.Text = activityTextBox.Text


                End If

                If RadioButton11.Checked = True Then
                    Form1.CalendarControl1.Label33.BackColor = Color.Blue
                    Form1.CalendarControl1.Label33.Text = activityTextBox.Text


                End If

                If RadioButton12.Checked = True Then
                    Form1.CalendarControl1.Label40.BackColor = Color.Blue
                    Form1.CalendarControl1.Label40.Text = activityTextBox.Text


                End If

                If RadioButton13.Checked = True Then
                    Form1.CalendarControl1.Label47.BackColor = Color.Blue
                    Form1.CalendarControl1.Label47.Text = activityTextBox.Text


                End If

                If RadioButton14.Checked = True Then
                    Form1.CalendarControl1.Label54.BackColor = Color.Blue
                    Form1.CalendarControl1.Label54.Text = activityTextBox.Text


                End If

                If RadioButton15.Checked = True Then
                    Form1.CalendarControl1.Label61.BackColor = Color.Blue
                    Form1.CalendarControl1.Label61.Text = activityTextBox.Text


                End If

                If RadioButton16.Checked = True Then
                    Form1.CalendarControl1.Label68.BackColor = Color.Blue
                    Form1.CalendarControl1.Label68.Text = activityTextBox.Text


                End If

                If RadioButton17.Checked = True Then
                    Form1.CalendarControl1.Label75.BackColor = Color.Blue
                    Form1.CalendarControl1.Label75.Text = activityTextBox.Text


                End If

            End If


            If saturdayButton.Checked = True Then


                If RadioButton8.Checked = True Then
                    Form1.CalendarControl1.Label3.BackColor = Color.Blue
                    Form1.CalendarControl1.Label3.Text = activityTextBox.Text


                End If

                If RadioButton9.Checked = True Then
                    Form1.CalendarControl1.Label25.BackColor = Color.Blue
                    Form1.CalendarControl1.Label25.Text = activityTextBox.Text


                End If

                If RadioButton10.Checked = True Then
                    Form1.CalendarControl1.Label32.BackColor = Color.Blue
                    Form1.CalendarControl1.Label32.Text = activityTextBox.Text


                End If

                If RadioButton11.Checked = True Then
                    Form1.CalendarControl1.Label39.BackColor = Color.Blue
                    Form1.CalendarControl1.Label39.Text = activityTextBox.Text


                End If

                If RadioButton12.Checked = True Then
                    Form1.CalendarControl1.Label46.BackColor = Color.Blue
                    Form1.CalendarControl1.Label46.Text = activityTextBox.Text


                End If

                If RadioButton13.Checked = True Then
                    Form1.CalendarControl1.Label53.BackColor = Color.Blue
                    Form1.CalendarControl1.Label53.Text = activityTextBox.Text


                End If

                If RadioButton14.Checked = True Then
                    Form1.CalendarControl1.Label60.BackColor = Color.Blue
                    Form1.CalendarControl1.Label60.Text = activityTextBox.Text


                End If

                If RadioButton15.Checked = True Then
                    Form1.CalendarControl1.Label67.BackColor = Color.Blue
                    Form1.CalendarControl1.Label67.Text = activityTextBox.Text


                End If

                If RadioButton16.Checked = True Then
                    Form1.CalendarControl1.Label74.BackColor = Color.Blue
                    Form1.CalendarControl1.Label74.Text = activityTextBox.Text


                End If

                If RadioButton17.Checked = True Then
                    Form1.CalendarControl1.Label81.BackColor = Color.Blue
                    Form1.CalendarControl1.Label81.Text = activityTextBox.Text


                End If

            End If
            Me.activityTextBox.Text = ""
            Me.locationTextBox.Text = ""
            Me.Hide()
            Form1.CalendarControl1.BringToFront()
            Form1.CalendarControl1.Show()
        End If
    End Sub
End Class
