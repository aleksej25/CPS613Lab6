<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClimateControlScreen
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.FrontDefrostLabel = New System.Windows.Forms.Label()
        Me.RearDefrostLabel = New System.Windows.Forms.Label()
        Me.PassBLLabel = New System.Windows.Forms.Label()
        Me.PassBRLabel = New System.Windows.Forms.Label()
        Me.PassFRLabel = New System.Windows.Forms.Label()
        Me.DriverLabel = New System.Windows.Forms.Label()
        Me.BackBox = New System.Windows.Forms.PictureBox()
        Me.ACBox = New System.Windows.Forms.Button()
        Me.FrontDefrost = New System.Windows.Forms.Button()
        Me.rearDefrost = New System.Windows.Forms.Button()
        Me.DriverSeat = New System.Windows.Forms.Button()
        Me.PassengerSeat = New System.Windows.Forms.Button()
        Me.BackLeftPass = New System.Windows.Forms.Button()
        Me.BackRightPass = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RentECar.My.Resources.ProjectResources.iphone_blank
        Me.PictureBox1.Location = New System.Drawing.Point(0, -7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(333, 640)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Sitka Heading", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TitleLabel.ForeColor = System.Drawing.Color.Transparent
        Me.TitleLabel.Location = New System.Drawing.Point(64, 52)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(206, 39)
        Me.TitleLabel.TabIndex = 5
        Me.TitleLabel.Text = "Climate Control"
        '
        'FrontDefrostLabel
        '
        Me.FrontDefrostLabel.AutoSize = True
        Me.FrontDefrostLabel.Font = New System.Drawing.Font("Sitka Small", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FrontDefrostLabel.ForeColor = System.Drawing.Color.Transparent
        Me.FrontDefrostLabel.Location = New System.Drawing.Point(73, 207)
        Me.FrontDefrostLabel.Name = "FrontDefrostLabel"
        Me.FrontDefrostLabel.Size = New System.Drawing.Size(55, 24)
        Me.FrontDefrostLabel.TabIndex = 8
        Me.FrontDefrostLabel.Text = "Front"
        '
        'RearDefrostLabel
        '
        Me.RearDefrostLabel.AutoSize = True
        Me.RearDefrostLabel.Font = New System.Drawing.Font("Sitka Small", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RearDefrostLabel.ForeColor = System.Drawing.Color.Transparent
        Me.RearDefrostLabel.Location = New System.Drawing.Point(213, 207)
        Me.RearDefrostLabel.Name = "RearDefrostLabel"
        Me.RearDefrostLabel.Size = New System.Drawing.Size(47, 24)
        Me.RearDefrostLabel.TabIndex = 9
        Me.RearDefrostLabel.Text = "Rear"
        '
        'PassBLLabel
        '
        Me.PassBLLabel.AutoSize = True
        Me.PassBLLabel.Font = New System.Drawing.Font("Sitka Heading", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PassBLLabel.ForeColor = System.Drawing.Color.Transparent
        Me.PassBLLabel.Location = New System.Drawing.Point(73, 557)
        Me.PassBLLabel.Name = "PassBLLabel"
        Me.PassBLLabel.Size = New System.Drawing.Size(68, 19)
        Me.PassBLLabel.TabIndex = 22
        Me.PassBLLabel.Text = "Passenger"
        '
        'PassBRLabel
        '
        Me.PassBRLabel.AutoSize = True
        Me.PassBRLabel.Font = New System.Drawing.Font("Sitka Heading", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PassBRLabel.ForeColor = System.Drawing.Color.Transparent
        Me.PassBRLabel.Location = New System.Drawing.Point(192, 557)
        Me.PassBRLabel.Name = "PassBRLabel"
        Me.PassBRLabel.Size = New System.Drawing.Size(68, 19)
        Me.PassBRLabel.TabIndex = 23
        Me.PassBRLabel.Text = "Passenger"
        '
        'PassFRLabel
        '
        Me.PassFRLabel.AutoSize = True
        Me.PassFRLabel.Font = New System.Drawing.Font("Sitka Heading", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PassFRLabel.ForeColor = System.Drawing.Color.Transparent
        Me.PassFRLabel.Location = New System.Drawing.Point(192, 441)
        Me.PassFRLabel.Name = "PassFRLabel"
        Me.PassFRLabel.Size = New System.Drawing.Size(68, 19)
        Me.PassFRLabel.TabIndex = 24
        Me.PassFRLabel.Text = "Passenger"
        '
        'DriverLabel
        '
        Me.DriverLabel.AutoSize = True
        Me.DriverLabel.Font = New System.Drawing.Font("Sitka Heading", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DriverLabel.ForeColor = System.Drawing.Color.Transparent
        Me.DriverLabel.Location = New System.Drawing.Point(80, 441)
        Me.DriverLabel.Name = "DriverLabel"
        Me.DriverLabel.Size = New System.Drawing.Size(47, 19)
        Me.DriverLabel.TabIndex = 25
        Me.DriverLabel.Text = "Driver"
        '
        'BackBox
        '
        Me.BackBox.Image = Global.RentECar.My.Resources.ProjectResources.backArrow
        Me.BackBox.Location = New System.Drawing.Point(32, 25)
        Me.BackBox.Name = "BackBox"
        Me.BackBox.Size = New System.Drawing.Size(40, 40)
        Me.BackBox.TabIndex = 27
        Me.BackBox.TabStop = False
        '
        'ACBox
        '
        Me.ACBox.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ACBox.Image = Global.RentECar.My.Resources.ProjectResources.ac_icon
        Me.ACBox.Location = New System.Drawing.Point(104, 94)
        Me.ACBox.Name = "ACBox"
        Me.ACBox.Size = New System.Drawing.Size(125, 110)
        Me.ACBox.TabIndex = 28
        Me.ACBox.UseVisualStyleBackColor = False
        '
        'FrontDefrost
        '
        Me.FrontDefrost.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.FrontDefrost.Image = Global.RentECar.My.Resources.ProjectResources.frontDefrost
        Me.FrontDefrost.Location = New System.Drawing.Point(44, 228)
        Me.FrontDefrost.Name = "FrontDefrost"
        Me.FrontDefrost.Size = New System.Drawing.Size(110, 90)
        Me.FrontDefrost.TabIndex = 29
        Me.FrontDefrost.UseVisualStyleBackColor = False
        '
        'rearDefrost
        '
        Me.rearDefrost.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.rearDefrost.Image = Global.RentECar.My.Resources.ProjectResources.rearDefrost
        Me.rearDefrost.Location = New System.Drawing.Point(180, 228)
        Me.rearDefrost.Name = "rearDefrost"
        Me.rearDefrost.Size = New System.Drawing.Size(115, 105)
        Me.rearDefrost.TabIndex = 30
        Me.rearDefrost.UseVisualStyleBackColor = False
        '
        'DriverSeat
        '
        Me.DriverSeat.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DriverSeat.Image = Global.RentECar.My.Resources.ProjectResources.heatedSeatOff
        Me.DriverSeat.Location = New System.Drawing.Point(57, 352)
        Me.DriverSeat.Name = "DriverSeat"
        Me.DriverSeat.Size = New System.Drawing.Size(90, 90)
        Me.DriverSeat.TabIndex = 31
        Me.DriverSeat.UseVisualStyleBackColor = False
        '
        'PassengerSeat
        '
        Me.PassengerSeat.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PassengerSeat.Image = Global.RentECar.My.Resources.ProjectResources.heatedSeatOff
        Me.PassengerSeat.Location = New System.Drawing.Point(180, 352)
        Me.PassengerSeat.Name = "PassengerSeat"
        Me.PassengerSeat.Size = New System.Drawing.Size(90, 90)
        Me.PassengerSeat.TabIndex = 32
        Me.PassengerSeat.UseVisualStyleBackColor = False
        '
        'BackLeftPass
        '
        Me.BackLeftPass.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackLeftPass.Image = Global.RentECar.My.Resources.ProjectResources.heatedSeatOff
        Me.BackLeftPass.Location = New System.Drawing.Point(57, 464)
        Me.BackLeftPass.Name = "BackLeftPass"
        Me.BackLeftPass.Size = New System.Drawing.Size(90, 90)
        Me.BackLeftPass.TabIndex = 33
        Me.BackLeftPass.UseVisualStyleBackColor = False
        '
        'BackRightPass
        '
        Me.BackRightPass.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackRightPass.Image = Global.RentECar.My.Resources.ProjectResources.heatedSeatOff
        Me.BackRightPass.Location = New System.Drawing.Point(180, 464)
        Me.BackRightPass.Name = "BackRightPass"
        Me.BackRightPass.Size = New System.Drawing.Size(90, 90)
        Me.BackRightPass.TabIndex = 34
        Me.BackRightPass.UseVisualStyleBackColor = False
        '
        'ClimateControlScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Controls.Add(Me.BackRightPass)
        Me.Controls.Add(Me.BackLeftPass)
        Me.Controls.Add(Me.PassengerSeat)
        Me.Controls.Add(Me.DriverSeat)
        Me.Controls.Add(Me.rearDefrost)
        Me.Controls.Add(Me.FrontDefrost)
        Me.Controls.Add(Me.ACBox)
        Me.Controls.Add(Me.BackBox)
        Me.Controls.Add(Me.DriverLabel)
        Me.Controls.Add(Me.PassFRLabel)
        Me.Controls.Add(Me.PassBRLabel)
        Me.Controls.Add(Me.PassBLLabel)
        Me.Controls.Add(Me.RearDefrostLabel)
        Me.Controls.Add(Me.FrontDefrostLabel)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "ClimateControlScreen"
        Me.Size = New System.Drawing.Size(335, 641)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TitleLabel As Label
    Friend WithEvents FrontDefrostLabel As Label
    Friend WithEvents RearDefrostLabel As Label
    Friend WithEvents PassBLLabel As Label
    Friend WithEvents PassBRLabel As Label
    Friend WithEvents PassFRLabel As Label
    Friend WithEvents DriverLabel As Label
    Friend WithEvents BackBox As PictureBox
    Friend WithEvents ACBox As Button
    Friend WithEvents FrontDefrost As Button
    Friend WithEvents rearDefrost As Button
    Friend WithEvents DriverSeat As Button
    Friend WithEvents PassengerSeat As Button
    Friend WithEvents BackLeftPass As Button
    Friend WithEvents BackRightPass As Button
End Class
