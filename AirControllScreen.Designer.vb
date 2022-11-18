<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AirControllScreen
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
        Me.TtileLabel = New System.Windows.Forms.Label()
        Me.SettingClimateLabel = New System.Windows.Forms.Label()
        Me.UpperTempLabel = New System.Windows.Forms.Label()
        Me.LowerTempLabel = New System.Windows.Forms.Label()
        Me.TemperatureSlider = New System.Windows.Forms.TrackBar()
        Me.OutsideTempLabel = New System.Windows.Forms.Label()
        Me.InsideTempLabel = New System.Windows.Forms.Label()
        Me.FanSpeedBar = New System.Windows.Forms.TrackBar()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BackBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AirControlLabel = New System.Windows.Forms.Label()
        Me.FreshAirBox = New System.Windows.Forms.Button()
        Me.RecirculatingAirBox = New System.Windows.Forms.Button()
        Me.freshAirLabel = New System.Windows.Forms.Label()
        Me.recirAirLabel = New System.Windows.Forms.Label()
        CType(Me.TemperatureSlider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FanSpeedBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TtileLabel
        '
        Me.TtileLabel.AutoSize = True
        Me.TtileLabel.Font = New System.Drawing.Font("Sitka Heading", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TtileLabel.ForeColor = System.Drawing.Color.Transparent
        Me.TtileLabel.Location = New System.Drawing.Point(59, 72)
        Me.TtileLabel.Name = "TtileLabel"
        Me.TtileLabel.Size = New System.Drawing.Size(216, 39)
        Me.TtileLabel.TabIndex = 6
        Me.TtileLabel.Text = "Air Conditioning"
        '
        'SettingClimateLabel
        '
        Me.SettingClimateLabel.AutoSize = True
        Me.SettingClimateLabel.Font = New System.Drawing.Font("Sitka Heading", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SettingClimateLabel.ForeColor = System.Drawing.Color.Transparent
        Me.SettingClimateLabel.Location = New System.Drawing.Point(40, 272)
        Me.SettingClimateLabel.Name = "SettingClimateLabel"
        Me.SettingClimateLabel.Size = New System.Drawing.Size(24, 28)
        Me.SettingClimateLabel.TabIndex = 21
        Me.SettingClimateLabel.Text = "T"
        Me.SettingClimateLabel.Visible = False
        '
        'UpperTempLabel
        '
        Me.UpperTempLabel.AutoSize = True
        Me.UpperTempLabel.Font = New System.Drawing.Font("Sitka Heading", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.UpperTempLabel.ForeColor = System.Drawing.Color.Transparent
        Me.UpperTempLabel.Location = New System.Drawing.Point(244, 238)
        Me.UpperTempLabel.Name = "UpperTempLabel"
        Me.UpperTempLabel.Size = New System.Drawing.Size(44, 28)
        Me.UpperTempLabel.TabIndex = 20
        Me.UpperTempLabel.Text = "28C"
        '
        'LowerTempLabel
        '
        Me.LowerTempLabel.AutoSize = True
        Me.LowerTempLabel.Font = New System.Drawing.Font("Sitka Heading", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LowerTempLabel.ForeColor = System.Drawing.Color.Transparent
        Me.LowerTempLabel.Location = New System.Drawing.Point(41, 238)
        Me.LowerTempLabel.Name = "LowerTempLabel"
        Me.LowerTempLabel.Size = New System.Drawing.Size(42, 28)
        Me.LowerTempLabel.TabIndex = 19
        Me.LowerTempLabel.Text = "16C"
        '
        'TemperatureSlider
        '
        Me.TemperatureSlider.Location = New System.Drawing.Point(47, 205)
        Me.TemperatureSlider.Maximum = 28
        Me.TemperatureSlider.Minimum = 16
        Me.TemperatureSlider.Name = "TemperatureSlider"
        Me.TemperatureSlider.Size = New System.Drawing.Size(230, 45)
        Me.TemperatureSlider.TabIndex = 18
        Me.TemperatureSlider.Value = 20
        '
        'OutsideTempLabel
        '
        Me.OutsideTempLabel.AutoSize = True
        Me.OutsideTempLabel.Font = New System.Drawing.Font("Sitka Heading", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.OutsideTempLabel.ForeColor = System.Drawing.Color.Transparent
        Me.OutsideTempLabel.Location = New System.Drawing.Point(40, 163)
        Me.OutsideTempLabel.Name = "OutsideTempLabel"
        Me.OutsideTempLabel.Size = New System.Drawing.Size(24, 28)
        Me.OutsideTempLabel.TabIndex = 17
        Me.OutsideTempLabel.Text = "T"
        '
        'InsideTempLabel
        '
        Me.InsideTempLabel.AutoSize = True
        Me.InsideTempLabel.Font = New System.Drawing.Font("Sitka Heading", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.InsideTempLabel.ForeColor = System.Drawing.Color.Transparent
        Me.InsideTempLabel.Location = New System.Drawing.Point(40, 125)
        Me.InsideTempLabel.Name = "InsideTempLabel"
        Me.InsideTempLabel.Size = New System.Drawing.Size(24, 28)
        Me.InsideTempLabel.TabIndex = 16
        Me.InsideTempLabel.Text = "T"
        '
        'FanSpeedBar
        '
        Me.FanSpeedBar.Location = New System.Drawing.Point(47, 340)
        Me.FanSpeedBar.Name = "FanSpeedBar"
        Me.FanSpeedBar.Size = New System.Drawing.Size(230, 45)
        Me.FanSpeedBar.TabIndex = 24
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.RentECar.My.Resources.ProjectResources.fanSpeed
        Me.PictureBox2.Location = New System.Drawing.Point(87, 371)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(150, 35)
        Me.PictureBox2.TabIndex = 25
        Me.PictureBox2.TabStop = False
        '
        'BackBox
        '
        Me.BackBox.Image = Global.RentECar.My.Resources.ProjectResources.backArrow
        Me.BackBox.Location = New System.Drawing.Point(35, 31)
        Me.BackBox.Name = "BackBox"
        Me.BackBox.Size = New System.Drawing.Size(40, 40)
        Me.BackBox.TabIndex = 26
        Me.BackBox.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RentECar.My.Resources.ProjectResources.iphone_blank
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(333, 640)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'AirControlLabel
        '
        Me.AirControlLabel.AutoSize = True
        Me.AirControlLabel.Font = New System.Drawing.Font("Sitka Heading", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AirControlLabel.ForeColor = System.Drawing.Color.Transparent
        Me.AirControlLabel.Location = New System.Drawing.Point(47, 410)
        Me.AirControlLabel.Name = "AirControlLabel"
        Me.AirControlLabel.Size = New System.Drawing.Size(24, 28)
        Me.AirControlLabel.TabIndex = 27
        Me.AirControlLabel.Text = "T"
        Me.AirControlLabel.Visible = False
        '
        'FreshAirBox
        '
        Me.FreshAirBox.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.FreshAirBox.Image = Global.RentECar.My.Resources.ProjectResources.freshAirOn
        Me.FreshAirBox.Location = New System.Drawing.Point(47, 467)
        Me.FreshAirBox.Name = "FreshAirBox"
        Me.FreshAirBox.Size = New System.Drawing.Size(100, 90)
        Me.FreshAirBox.TabIndex = 28
        Me.FreshAirBox.UseVisualStyleBackColor = False
        '
        'RecirculatingAirBox
        '
        Me.RecirculatingAirBox.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.RecirculatingAirBox.Image = Global.RentECar.My.Resources.ProjectResources.recirculatAirOff
        Me.RecirculatingAirBox.Location = New System.Drawing.Point(177, 467)
        Me.RecirculatingAirBox.Name = "RecirculatingAirBox"
        Me.RecirculatingAirBox.Size = New System.Drawing.Size(100, 90)
        Me.RecirculatingAirBox.TabIndex = 29
        Me.RecirculatingAirBox.UseVisualStyleBackColor = False
        '
        'freshAirLabel
        '
        Me.freshAirLabel.AutoSize = True
        Me.freshAirLabel.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.freshAirLabel.ForeColor = System.Drawing.Color.Lime
        Me.freshAirLabel.Location = New System.Drawing.Point(45, 560)
        Me.freshAirLabel.Name = "freshAirLabel"
        Me.freshAirLabel.Size = New System.Drawing.Size(102, 23)
        Me.freshAirLabel.TabIndex = 30
        Me.freshAirLabel.Text = "Outside Air"
        '
        'recirAirLabel
        '
        Me.recirAirLabel.AutoSize = True
        Me.recirAirLabel.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.recirAirLabel.ForeColor = System.Drawing.Color.Transparent
        Me.recirAirLabel.Location = New System.Drawing.Point(165, 560)
        Me.recirAirLabel.Name = "recirAirLabel"
        Me.recirAirLabel.Size = New System.Drawing.Size(131, 23)
        Me.recirAirLabel.TabIndex = 31
        Me.recirAirLabel.Text = "Recirculate Air"
        '
        'AirControllScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Controls.Add(Me.recirAirLabel)
        Me.Controls.Add(Me.freshAirLabel)
        Me.Controls.Add(Me.RecirculatingAirBox)
        Me.Controls.Add(Me.FreshAirBox)
        Me.Controls.Add(Me.AirControlLabel)
        Me.Controls.Add(Me.BackBox)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.FanSpeedBar)
        Me.Controls.Add(Me.SettingClimateLabel)
        Me.Controls.Add(Me.UpperTempLabel)
        Me.Controls.Add(Me.LowerTempLabel)
        Me.Controls.Add(Me.TemperatureSlider)
        Me.Controls.Add(Me.OutsideTempLabel)
        Me.Controls.Add(Me.InsideTempLabel)
        Me.Controls.Add(Me.TtileLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "AirControllScreen"
        Me.Size = New System.Drawing.Size(339, 642)
        CType(Me.TemperatureSlider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FanSpeedBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TtileLabel As Label
    Friend WithEvents SettingClimateLabel As Label
    Friend WithEvents UpperTempLabel As Label
    Friend WithEvents LowerTempLabel As Label
    Friend WithEvents TemperatureSlider As TrackBar
    Friend WithEvents OutsideTempLabel As Label
    Friend WithEvents InsideTempLabel As Label
    Friend WithEvents FanSpeedBar As TrackBar
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BackBox As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents AirControlLabel As Label
    Friend WithEvents FreshAirBox As Button
    Friend WithEvents RecirculatingAirBox As Button
    Friend WithEvents freshAirLabel As Label
    Friend WithEvents recirAirLabel As Label
End Class
