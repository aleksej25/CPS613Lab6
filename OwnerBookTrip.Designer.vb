﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OwnerBookTrip
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
        Me.BackBox = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FromLabel = New System.Windows.Forms.Label()
        Me.ToLabel = New System.Windows.Forms.Label()
        Me.FromBox = New System.Windows.Forms.ComboBox()
        Me.ToBox = New System.Windows.Forms.ComboBox()
        Me.NowButton = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.StartLabel = New System.Windows.Forms.Label()
        Me.EndLabel = New System.Windows.Forms.Label()
        Me.StartBox = New System.Windows.Forms.ComboBox()
        Me.EndBox = New System.Windows.Forms.ComboBox()
        Me.DriveButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.BackBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackBox
        '
        Me.BackBox.Image = Global.RentECar.My.Resources.ProjectResources.backArrow
        Me.BackBox.Location = New System.Drawing.Point(35, 32)
        Me.BackBox.Name = "BackBox"
        Me.BackBox.Size = New System.Drawing.Size(40, 40)
        Me.BackBox.TabIndex = 11
        Me.BackBox.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Text", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(91, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 35)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Book a Trip"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FromLabel
        '
        Me.FromLabel.AutoSize = True
        Me.FromLabel.Font = New System.Drawing.Font("Sitka Text", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FromLabel.ForeColor = System.Drawing.Color.White
        Me.FromLabel.Location = New System.Drawing.Point(56, 137)
        Me.FromLabel.Name = "FromLabel"
        Me.FromLabel.Size = New System.Drawing.Size(67, 28)
        Me.FromLabel.TabIndex = 13
        Me.FromLabel.Text = "From:"
        '
        'ToLabel
        '
        Me.ToLabel.AutoSize = True
        Me.ToLabel.Font = New System.Drawing.Font("Sitka Text", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ToLabel.ForeColor = System.Drawing.Color.White
        Me.ToLabel.Location = New System.Drawing.Point(56, 203)
        Me.ToLabel.Name = "ToLabel"
        Me.ToLabel.Size = New System.Drawing.Size(41, 28)
        Me.ToLabel.TabIndex = 14
        Me.ToLabel.Text = "To:"
        '
        'FromBox
        '
        Me.FromBox.FormattingEnabled = True
        Me.FromBox.Items.AddRange(New Object() {"Your House", "Supermarket", "Work"})
        Me.FromBox.Location = New System.Drawing.Point(141, 144)
        Me.FromBox.Name = "FromBox"
        Me.FromBox.Size = New System.Drawing.Size(121, 23)
        Me.FromBox.TabIndex = 15
        '
        'ToBox
        '
        Me.ToBox.FormattingEnabled = True
        Me.ToBox.Items.AddRange(New Object() {"Your House", "Supermarket", "Work"})
        Me.ToBox.Location = New System.Drawing.Point(141, 210)
        Me.ToBox.Name = "ToBox"
        Me.ToBox.Size = New System.Drawing.Size(121, 23)
        Me.ToBox.TabIndex = 16
        '
        'NowButton
        '
        Me.NowButton.AutoSize = True
        Me.NowButton.Font = New System.Drawing.Font("Sitka Text", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NowButton.ForeColor = System.Drawing.Color.White
        Me.NowButton.Location = New System.Drawing.Point(56, 281)
        Me.NowButton.Name = "NowButton"
        Me.NowButton.Size = New System.Drawing.Size(72, 32)
        Me.NowButton.TabIndex = 17
        Me.NowButton.TabStop = True
        Me.NowButton.Text = "Now"
        Me.NowButton.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Sitka Text", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RadioButton2.ForeColor = System.Drawing.Color.White
        Me.RadioButton2.Location = New System.Drawing.Point(185, 281)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(77, 32)
        Me.RadioButton2.TabIndex = 18
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Later"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'StartLabel
        '
        Me.StartLabel.AutoSize = True
        Me.StartLabel.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.StartLabel.ForeColor = System.Drawing.Color.White
        Me.StartLabel.Location = New System.Drawing.Point(52, 365)
        Me.StartLabel.Name = "StartLabel"
        Me.StartLabel.Size = New System.Drawing.Size(91, 23)
        Me.StartLabel.TabIndex = 19
        Me.StartLabel.Text = "Start time:"
        Me.StartLabel.Visible = False
        '
        'EndLabel
        '
        Me.EndLabel.AutoSize = True
        Me.EndLabel.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.EndLabel.ForeColor = System.Drawing.Color.White
        Me.EndLabel.Location = New System.Drawing.Point(52, 441)
        Me.EndLabel.Name = "EndLabel"
        Me.EndLabel.Size = New System.Drawing.Size(83, 23)
        Me.EndLabel.TabIndex = 20
        Me.EndLabel.Text = "End time:"
        Me.EndLabel.Visible = False
        '
        'StartBox
        '
        Me.StartBox.FormattingEnabled = True
        Me.StartBox.Location = New System.Drawing.Point(156, 368)
        Me.StartBox.Name = "StartBox"
        Me.StartBox.Size = New System.Drawing.Size(121, 23)
        Me.StartBox.TabIndex = 21
        Me.StartBox.Visible = False
        '
        'EndBox
        '
        Me.EndBox.FormattingEnabled = True
        Me.EndBox.Location = New System.Drawing.Point(156, 444)
        Me.EndBox.Name = "EndBox"
        Me.EndBox.Size = New System.Drawing.Size(121, 23)
        Me.EndBox.TabIndex = 22
        Me.EndBox.Visible = False
        '
        'DriveButton
        '
        Me.DriveButton.Font = New System.Drawing.Font("Sitka Text", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DriveButton.Location = New System.Drawing.Point(118, 516)
        Me.DriveButton.Name = "DriveButton"
        Me.DriveButton.Size = New System.Drawing.Size(88, 50)
        Me.DriveButton.TabIndex = 23
        Me.DriveButton.Text = "Drive"
        Me.DriveButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RentECar.My.Resources.ProjectResources.iphone_blank
        Me.PictureBox1.Location = New System.Drawing.Point(0, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(339, 637)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'OwnerBookTrip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Controls.Add(Me.DriveButton)
        Me.Controls.Add(Me.EndBox)
        Me.Controls.Add(Me.StartBox)
        Me.Controls.Add(Me.EndLabel)
        Me.Controls.Add(Me.StartLabel)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.NowButton)
        Me.Controls.Add(Me.ToBox)
        Me.Controls.Add(Me.FromBox)
        Me.Controls.Add(Me.ToLabel)
        Me.Controls.Add(Me.FromLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BackBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "OwnerBookTrip"
        Me.Size = New System.Drawing.Size(339, 642)
        CType(Me.BackBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackBox As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents FromLabel As Label
    Friend WithEvents ToLabel As Label
    Friend WithEvents FromBox As ComboBox
    Friend WithEvents ToBox As ComboBox
    Friend WithEvents NowButton As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents StartLabel As Label
    Friend WithEvents EndLabel As Label
    Friend WithEvents StartBox As ComboBox
    Friend WithEvents EndBox As ComboBox
    Friend WithEvents DriveButton As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
