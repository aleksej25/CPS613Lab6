﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class schedulerControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.activityTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.locationTextBox = New System.Windows.Forms.TextBox()
        Me.sundayButton = New System.Windows.Forms.RadioButton()
        Me.mondayButton = New System.Windows.Forms.RadioButton()
        Me.tuesdayButton = New System.Windows.Forms.RadioButton()
        Me.wednesdayButton = New System.Windows.Forms.RadioButton()
        Me.thursdayButton = New System.Windows.Forms.RadioButton()
        Me.fridayButton = New System.Windows.Forms.RadioButton()
        Me.saturdayButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton11 = New System.Windows.Forms.RadioButton()
        Me.RadioButton12 = New System.Windows.Forms.RadioButton()
        Me.RadioButton10 = New System.Windows.Forms.RadioButton()
        Me.RadioButton14 = New System.Windows.Forms.RadioButton()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Me.RadioButton15 = New System.Windows.Forms.RadioButton()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.RadioButton13 = New System.Windows.Forms.RadioButton()
        Me.RadioButton16 = New System.Windows.Forms.RadioButton()
        Me.RadioButton17 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.backButton = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.backButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'activityTextBox
        '
        Me.activityTextBox.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.activityTextBox.Location = New System.Drawing.Point(112, 99)
        Me.activityTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.activityTextBox.Name = "activityTextBox"
        Me.activityTextBox.PlaceholderText = "Activity"
        Me.activityTextBox.Size = New System.Drawing.Size(110, 24)
        Me.activityTextBox.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Sitka Small", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(115, 514)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 38)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Add "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'locationTextBox
        '
        Me.locationTextBox.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.locationTextBox.Location = New System.Drawing.Point(112, 126)
        Me.locationTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.locationTextBox.Name = "locationTextBox"
        Me.locationTextBox.PlaceholderText = "Location"
        Me.locationTextBox.Size = New System.Drawing.Size(110, 24)
        Me.locationTextBox.TabIndex = 15
        Me.locationTextBox.Tag = ""
        '
        'sundayButton
        '
        Me.sundayButton.AutoSize = True
        Me.sundayButton.Location = New System.Drawing.Point(5, 24)
        Me.sundayButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.sundayButton.Name = "sundayButton"
        Me.sundayButton.Size = New System.Drawing.Size(84, 27)
        Me.sundayButton.TabIndex = 0
        Me.sundayButton.TabStop = True
        Me.sundayButton.Text = "Sunday"
        Me.sundayButton.UseVisualStyleBackColor = True
        '
        'mondayButton
        '
        Me.mondayButton.AutoSize = True
        Me.mondayButton.Location = New System.Drawing.Point(5, 47)
        Me.mondayButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.mondayButton.Name = "mondayButton"
        Me.mondayButton.Size = New System.Drawing.Size(89, 27)
        Me.mondayButton.TabIndex = 1
        Me.mondayButton.TabStop = True
        Me.mondayButton.Text = "Monday"
        Me.mondayButton.UseVisualStyleBackColor = True
        '
        'tuesdayButton
        '
        Me.tuesdayButton.AutoSize = True
        Me.tuesdayButton.Location = New System.Drawing.Point(5, 70)
        Me.tuesdayButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tuesdayButton.Name = "tuesdayButton"
        Me.tuesdayButton.Size = New System.Drawing.Size(92, 27)
        Me.tuesdayButton.TabIndex = 2
        Me.tuesdayButton.TabStop = True
        Me.tuesdayButton.Text = "Tuesday"
        Me.tuesdayButton.UseVisualStyleBackColor = True
        '
        'wednesdayButton
        '
        Me.wednesdayButton.AutoSize = True
        Me.wednesdayButton.Location = New System.Drawing.Point(4, 94)
        Me.wednesdayButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.wednesdayButton.Name = "wednesdayButton"
        Me.wednesdayButton.Size = New System.Drawing.Size(115, 27)
        Me.wednesdayButton.TabIndex = 3
        Me.wednesdayButton.TabStop = True
        Me.wednesdayButton.Text = "Wednesday"
        Me.wednesdayButton.UseVisualStyleBackColor = True
        '
        'thursdayButton
        '
        Me.thursdayButton.AutoSize = True
        Me.thursdayButton.Location = New System.Drawing.Point(4, 114)
        Me.thursdayButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.thursdayButton.Name = "thursdayButton"
        Me.thursdayButton.Size = New System.Drawing.Size(100, 27)
        Me.thursdayButton.TabIndex = 4
        Me.thursdayButton.TabStop = True
        Me.thursdayButton.Text = "Thursday"
        Me.thursdayButton.UseVisualStyleBackColor = True
        '
        'fridayButton
        '
        Me.fridayButton.AutoSize = True
        Me.fridayButton.Location = New System.Drawing.Point(5, 136)
        Me.fridayButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.fridayButton.Name = "fridayButton"
        Me.fridayButton.Size = New System.Drawing.Size(81, 27)
        Me.fridayButton.TabIndex = 5
        Me.fridayButton.TabStop = True
        Me.fridayButton.Text = "Friday "
        Me.fridayButton.UseVisualStyleBackColor = True
        '
        'saturdayButton
        '
        Me.saturdayButton.AutoSize = True
        Me.saturdayButton.Location = New System.Drawing.Point(5, 158)
        Me.saturdayButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.saturdayButton.Name = "saturdayButton"
        Me.saturdayButton.Size = New System.Drawing.Size(96, 27)
        Me.saturdayButton.TabIndex = 6
        Me.saturdayButton.TabStop = True
        Me.saturdayButton.Text = "Saturday"
        Me.saturdayButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox1.Controls.Add(Me.sundayButton)
        Me.GroupBox1.Controls.Add(Me.mondayButton)
        Me.GroupBox1.Controls.Add(Me.tuesdayButton)
        Me.GroupBox1.Controls.Add(Me.wednesdayButton)
        Me.GroupBox1.Controls.Add(Me.thursdayButton)
        Me.GroupBox1.Controls.Add(Me.fridayButton)
        Me.GroupBox1.Controls.Add(Me.saturdayButton)
        Me.GroupBox1.Font = New System.Drawing.Font("Sitka Small", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(35, 189)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(126, 202)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Day"
        '
        'RadioButton11
        '
        Me.RadioButton11.AutoSize = True
        Me.RadioButton11.Location = New System.Drawing.Point(13, 86)
        Me.RadioButton11.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButton11.Name = "RadioButton11"
        Me.RadioButton11.Size = New System.Drawing.Size(72, 27)
        Me.RadioButton11.TabIndex = 19
        Me.RadioButton11.TabStop = True
        Me.RadioButton11.Text = "11 am"
        Me.RadioButton11.UseVisualStyleBackColor = True
        '
        'RadioButton12
        '
        Me.RadioButton12.AutoSize = True
        Me.RadioButton12.Location = New System.Drawing.Point(13, 108)
        Me.RadioButton12.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButton12.Name = "RadioButton12"
        Me.RadioButton12.Size = New System.Drawing.Size(73, 27)
        Me.RadioButton12.TabIndex = 20
        Me.RadioButton12.TabStop = True
        Me.RadioButton12.Text = "12 pm"
        Me.RadioButton12.UseVisualStyleBackColor = True
        '
        'RadioButton10
        '
        Me.RadioButton10.AutoSize = True
        Me.RadioButton10.Location = New System.Drawing.Point(10, 63)
        Me.RadioButton10.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(74, 27)
        Me.RadioButton10.TabIndex = 18
        Me.RadioButton10.TabStop = True
        Me.RadioButton10.Text = "10 am"
        Me.RadioButton10.UseVisualStyleBackColor = True
        '
        'RadioButton14
        '
        Me.RadioButton14.AutoSize = True
        Me.RadioButton14.Location = New System.Drawing.Point(13, 150)
        Me.RadioButton14.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButton14.Name = "RadioButton14"
        Me.RadioButton14.Size = New System.Drawing.Size(65, 27)
        Me.RadioButton14.TabIndex = 22
        Me.RadioButton14.TabStop = True
        Me.RadioButton14.Text = "2 pm"
        Me.RadioButton14.UseVisualStyleBackColor = True
        '
        'RadioButton9
        '
        Me.RadioButton9.AutoSize = True
        Me.RadioButton9.Location = New System.Drawing.Point(13, 40)
        Me.RadioButton9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(66, 27)
        Me.RadioButton9.TabIndex = 17
        Me.RadioButton9.TabStop = True
        Me.RadioButton9.Text = "9 am"
        Me.RadioButton9.UseVisualStyleBackColor = True
        '
        'RadioButton15
        '
        Me.RadioButton15.AutoSize = True
        Me.RadioButton15.Location = New System.Drawing.Point(13, 170)
        Me.RadioButton15.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButton15.Name = "RadioButton15"
        Me.RadioButton15.Size = New System.Drawing.Size(65, 27)
        Me.RadioButton15.TabIndex = 23
        Me.RadioButton15.TabStop = True
        Me.RadioButton15.Text = "3 pm"
        Me.RadioButton15.UseVisualStyleBackColor = True
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.Location = New System.Drawing.Point(13, 20)
        Me.RadioButton8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(66, 27)
        Me.RadioButton8.TabIndex = 16
        Me.RadioButton8.TabStop = True
        Me.RadioButton8.Text = "8 am"
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'RadioButton13
        '
        Me.RadioButton13.AutoSize = True
        Me.RadioButton13.Location = New System.Drawing.Point(13, 130)
        Me.RadioButton13.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButton13.Name = "RadioButton13"
        Me.RadioButton13.Size = New System.Drawing.Size(64, 27)
        Me.RadioButton13.TabIndex = 21
        Me.RadioButton13.TabStop = True
        Me.RadioButton13.Text = "1 pm"
        Me.RadioButton13.UseVisualStyleBackColor = True
        '
        'RadioButton16
        '
        Me.RadioButton16.AutoSize = True
        Me.RadioButton16.Location = New System.Drawing.Point(13, 192)
        Me.RadioButton16.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButton16.Name = "RadioButton16"
        Me.RadioButton16.Size = New System.Drawing.Size(66, 27)
        Me.RadioButton16.TabIndex = 24
        Me.RadioButton16.TabStop = True
        Me.RadioButton16.Text = "4 pm"
        Me.RadioButton16.UseVisualStyleBackColor = True
        '
        'RadioButton17
        '
        Me.RadioButton17.AutoSize = True
        Me.RadioButton17.Location = New System.Drawing.Point(12, 214)
        Me.RadioButton17.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButton17.Name = "RadioButton17"
        Me.RadioButton17.Size = New System.Drawing.Size(65, 27)
        Me.RadioButton17.TabIndex = 25
        Me.RadioButton17.TabStop = True
        Me.RadioButton17.Text = "5 pm"
        Me.RadioButton17.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox2.Controls.Add(Me.RadioButton17)
        Me.GroupBox2.Controls.Add(Me.RadioButton16)
        Me.GroupBox2.Controls.Add(Me.RadioButton13)
        Me.GroupBox2.Controls.Add(Me.RadioButton8)
        Me.GroupBox2.Controls.Add(Me.RadioButton15)
        Me.GroupBox2.Controls.Add(Me.RadioButton9)
        Me.GroupBox2.Controls.Add(Me.RadioButton14)
        Me.GroupBox2.Controls.Add(Me.RadioButton10)
        Me.GroupBox2.Controls.Add(Me.RadioButton12)
        Me.GroupBox2.Controls.Add(Me.RadioButton11)
        Me.GroupBox2.Font = New System.Drawing.Font("Sitka Small", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Location = New System.Drawing.Point(167, 189)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(122, 251)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Time"
        '
        'backButton
        '
        Me.backButton.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.backButton.Image = Global.RentECar.My.Resources.ProjectResources.backArrow
        Me.backButton.Location = New System.Drawing.Point(35, 26)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(47, 41)
        Me.backButton.TabIndex = 26
        Me.backButton.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PictureBox1.Image = Global.RentECar.My.Resources.ProjectResources.iphone_blank
        Me.PictureBox1.Location = New System.Drawing.Point(1, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(327, 641)
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'schedulerControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.locationTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.activityTextBox)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "schedulerControl"
        Me.Size = New System.Drawing.Size(329, 636)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.backButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents activityTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents locationTextBox As TextBox
    Friend WithEvents sundayButton As RadioButton
    Friend WithEvents mondayButton As RadioButton
    Friend WithEvents tuesdayButton As RadioButton
    Friend WithEvents wednesdayButton As RadioButton
    Friend WithEvents thursdayButton As RadioButton
    Friend WithEvents fridayButton As RadioButton
    Friend WithEvents saturdayButton As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton11 As RadioButton
    Friend WithEvents RadioButton12 As RadioButton
    Friend WithEvents RadioButton10 As RadioButton
    Friend WithEvents RadioButton14 As RadioButton
    Friend WithEvents RadioButton9 As RadioButton
    Friend WithEvents RadioButton15 As RadioButton
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents RadioButton13 As RadioButton
    Friend WithEvents RadioButton16 As RadioButton
    Friend WithEvents RadioButton17 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents backButton As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
