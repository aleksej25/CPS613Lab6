Imports System.Threading

Public Class windowControl
    Private Sub windowUp_Click(sender As Object, e As EventArgs) Handles driveUp.Click, passFUp.Click, passBRUp.Click, passBLUp.Click
        Select Case sender.Name
            Case "driveUp"
                If Me.driverTrackBar.Value + 1 <= 10 Then
                    Me.driverTrackBar.Value += 1
                End If
            Case "passFUp"
                If Me.passFTrackBar.Value + 1 <= 10 Then
                    Me.passFTrackBar.Value += 1
                End If
            Case "passBRUp"
                If Me.passBRTrackBar.Value + 1 <= 10 Then
                    Me.passBRTrackBar.Value += 1
                End If
            Case "passBLUp"
                If Me.passBLTrackBar.Value + 1 <= 10 Then
                    Me.passBLTrackBar.Value += 1
                End If
        End Select
    End Sub

    Private Sub windowDown_Click(sender As Object, e As EventArgs) Handles driverDown.Click, passFDown.Click, passBRDown.Click, passBLDown.Click
        Select Case sender.Name
            Case "driverDown"
                If Me.driverTrackBar.Value - 1 >= 0 Then
                    Me.driverTrackBar.Value -= 1
                End If
            Case "passFDown"
                If Me.passFTrackBar.Value - 1 >= 0 Then
                    Me.passFTrackBar.Value -= 1
                End If
            Case "passBRDown"
                If Me.passBRTrackBar.Value - 1 >= 0 Then
                    Me.passBRTrackBar.Value -= 1
                End If
            Case "passBLDown"
                If Me.passBLTrackBar.Value - 1 >= 0 Then
                    Me.passBLTrackBar.Value -= 1
                End If
        End Select
    End Sub
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Long) As Integer
    Private Sub Form_MouseDown(sender As Object, e As EventArgs) Handles driverDown.MouseDown, passFDown.MouseDown, passBRDown.MouseDown, passBLDown.MouseDown
        Do While GetAsyncKeyState(1)
            Select Case sender.Name
                Case "driverDown"
                    If Me.driverTrackBar.Value - 1 >= 0 Then
                        Me.driverTrackBar.Value -= 1
                    End If
                Case "passFDown"
                    If Me.passFTrackBar.Value - 1 >= 0 Then
                        Me.passFTrackBar.Value -= 1
                    End If
                Case "passBRDown"
                    If Me.passBRTrackBar.Value - 1 >= 0 Then
                        Me.passBRTrackBar.Value -= 1
                    End If
                Case "passBLDown"
                    If Me.passBLTrackBar.Value - 1 >= 0 Then
                        Me.passBLTrackBar.Value -= 1
                    End If
            End Select
            Thread.Sleep(250)
        Loop
    End Sub

    Private Sub Form_MouseUp(sender As Object, e As EventArgs) Handles driveUp.MouseDown, passFUp.MouseDown, passBRUp.MouseDown, passBLUp.MouseDown
        Do While GetAsyncKeyState(1)
            Select Case sender.Name
                Case "driveUp"
                    If Me.driverTrackBar.Value + 1 <= 10 Then
                        Me.driverTrackBar.Value += 1
                    End If
                Case "passFUp"
                    If Me.passFTrackBar.Value + 1 <= 10 Then
                        Me.passFTrackBar.Value += 1
                    End If
                Case "passBRUp"
                    If Me.passBRTrackBar.Value + 1 <= 10 Then
                        Me.passBRTrackBar.Value += 1
                    End If
                Case "passBLUp"
                    If Me.passBLTrackBar.Value + 1 <= 10 Then
                        Me.passBLTrackBar.Value += 1
                    End If
            End Select
            Thread.Sleep(250)
        Loop
    End Sub

    Private Sub BackBox_Click(sender As Object, e As EventArgs) Handles BackBox.Click
        Me.Hide()
        Form1.ECarControls.BringToFront()
        Form1.ECarControls.Show()
    End Sub
End Class
