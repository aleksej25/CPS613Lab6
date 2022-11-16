<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OwnerCurrentTrip
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
        Me.components = New System.ComponentModel.Container()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.startLabel = New System.Windows.Forms.Label()
        Me.StartDestLabel = New System.Windows.Forms.Label()
        Me.endLabel = New System.Windows.Forms.Label()
        Me.OwnerDestLabel = New System.Windows.Forms.Label()
        Me.OwnerModifyTripButton = New System.Windows.Forms.Button()
        Me.OwnerCarControlsBtn = New System.Windows.Forms.Button()
        Me.ManualDrivingButton = New System.Windows.Forms.Button()
        Me.OwnerStopTrip = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OwnerArrivedLabel = New System.Windows.Forms.Label()
        Me.OwnerTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Sitka Text", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TitleLabel.ForeColor = System.Drawing.Color.White
        Me.TitleLabel.Location = New System.Drawing.Point(60, 65)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(217, 30)
        Me.TitleLabel.TabIndex = 13
        Me.TitleLabel.Text = "You are on the way!"
        '
        'startLabel
        '
        Me.startLabel.AutoSize = True
        Me.startLabel.Font = New System.Drawing.Font("Sitka Text", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.startLabel.ForeColor = System.Drawing.Color.White
        Me.startLabel.Location = New System.Drawing.Point(73, 126)
        Me.startLabel.Name = "startLabel"
        Me.startLabel.Size = New System.Drawing.Size(188, 29)
        Me.startLabel.TabIndex = 14
        Me.startLabel.Text = "Start destination:"
        '
        'StartDestLabel
        '
        Me.StartDestLabel.AutoSize = True
        Me.StartDestLabel.Font = New System.Drawing.Font("Sitka Text", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.StartDestLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.StartDestLabel.Location = New System.Drawing.Point(94, 169)
        Me.StartDestLabel.Name = "StartDestLabel"
        Me.StartDestLabel.Size = New System.Drawing.Size(141, 29)
        Me.StartDestLabel.TabIndex = 15
        Me.StartDestLabel.Text = "TemplateText"
        '
        'endLabel
        '
        Me.endLabel.AutoSize = True
        Me.endLabel.Font = New System.Drawing.Font("Sitka Text", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.endLabel.ForeColor = System.Drawing.Color.White
        Me.endLabel.Location = New System.Drawing.Point(75, 215)
        Me.endLabel.Name = "endLabel"
        Me.endLabel.Size = New System.Drawing.Size(177, 29)
        Me.endLabel.TabIndex = 16
        Me.endLabel.Text = "End destination:"
        '
        'OwnerDestLabel
        '
        Me.OwnerDestLabel.AutoSize = True
        Me.OwnerDestLabel.Font = New System.Drawing.Font("Sitka Text", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.OwnerDestLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.OwnerDestLabel.Location = New System.Drawing.Point(94, 257)
        Me.OwnerDestLabel.Name = "OwnerDestLabel"
        Me.OwnerDestLabel.Size = New System.Drawing.Size(141, 29)
        Me.OwnerDestLabel.TabIndex = 17
        Me.OwnerDestLabel.Text = "TemplateText"
        '
        'OwnerModifyTripButton
        '
        Me.OwnerModifyTripButton.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.OwnerModifyTripButton.Location = New System.Drawing.Point(46, 417)
        Me.OwnerModifyTripButton.Name = "OwnerModifyTripButton"
        Me.OwnerModifyTripButton.Size = New System.Drawing.Size(105, 60)
        Me.OwnerModifyTripButton.TabIndex = 18
        Me.OwnerModifyTripButton.Text = "Change Route"
        Me.OwnerModifyTripButton.UseVisualStyleBackColor = True
        '
        'OwnerCarControlsBtn
        '
        Me.OwnerCarControlsBtn.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.OwnerCarControlsBtn.Location = New System.Drawing.Point(46, 496)
        Me.OwnerCarControlsBtn.Name = "OwnerCarControlsBtn"
        Me.OwnerCarControlsBtn.Size = New System.Drawing.Size(105, 60)
        Me.OwnerCarControlsBtn.TabIndex = 19
        Me.OwnerCarControlsBtn.Text = "Car Controls"
        Me.OwnerCarControlsBtn.UseVisualStyleBackColor = True
        '
        'ManualDrivingButton
        '
        Me.ManualDrivingButton.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ManualDrivingButton.Location = New System.Drawing.Point(172, 417)
        Me.ManualDrivingButton.Name = "ManualDrivingButton"
        Me.ManualDrivingButton.Size = New System.Drawing.Size(105, 60)
        Me.ManualDrivingButton.TabIndex = 20
        Me.ManualDrivingButton.Text = "Manual Driving"
        Me.ManualDrivingButton.UseVisualStyleBackColor = True
        '
        'OwnerStopTrip
        '
        Me.OwnerStopTrip.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.OwnerStopTrip.Location = New System.Drawing.Point(172, 496)
        Me.OwnerStopTrip.Name = "OwnerStopTrip"
        Me.OwnerStopTrip.Size = New System.Drawing.Size(105, 60)
        Me.OwnerStopTrip.TabIndex = 21
        Me.OwnerStopTrip.Text = "Stop Trip"
        Me.OwnerStopTrip.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RentECar.My.Resources.ProjectResources.iphone_blank
        Me.PictureBox1.Location = New System.Drawing.Point(-3, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(339, 642)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'OwnerArrivedLabel
        '
        Me.OwnerArrivedLabel.AutoSize = True
        Me.OwnerArrivedLabel.Font = New System.Drawing.Font("Sitka Text", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.OwnerArrivedLabel.ForeColor = System.Drawing.Color.LimeGreen
        Me.OwnerArrivedLabel.Location = New System.Drawing.Point(66, 319)
        Me.OwnerArrivedLabel.Name = "OwnerArrivedLabel"
        Me.OwnerArrivedLabel.Size = New System.Drawing.Size(195, 30)
        Me.OwnerArrivedLabel.TabIndex = 23
        Me.OwnerArrivedLabel.Text = "You have arrived!"
        Me.OwnerArrivedLabel.Visible = False
        '
        'OwnerTimer
        '
        Me.OwnerTimer.Interval = 1000
        '
        'OwnerCurrentTrip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Controls.Add(Me.OwnerArrivedLabel)
        Me.Controls.Add(Me.OwnerStopTrip)
        Me.Controls.Add(Me.ManualDrivingButton)
        Me.Controls.Add(Me.OwnerCarControlsBtn)
        Me.Controls.Add(Me.OwnerModifyTripButton)
        Me.Controls.Add(Me.OwnerDestLabel)
        Me.Controls.Add(Me.endLabel)
        Me.Controls.Add(Me.StartDestLabel)
        Me.Controls.Add(Me.startLabel)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "OwnerCurrentTrip"
        Me.Size = New System.Drawing.Size(339, 642)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TitleLabel As Label
    Friend WithEvents startLabel As Label
    Friend WithEvents StartDestLabel As Label
    Friend WithEvents endLabel As Label
    Friend WithEvents OwnerDestLabel As Label
    Friend WithEvents OwnerModifyTripButton As Button
    Friend WithEvents OwnerCarControlsBtn As Button
    Friend WithEvents ManualDrivingButton As Button
    Friend WithEvents OwnerStopTrip As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OwnerArrivedLabel As Label
    Friend WithEvents OwnerTimer As Timer
End Class
