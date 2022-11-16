<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CurrentTripControl
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
        Me.components = New System.ComponentModel.Container()
        Me.BackBox = New System.Windows.Forms.PictureBox()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.startLabel = New System.Windows.Forms.Label()
        Me.StartDestinationLabel = New System.Windows.Forms.Label()
        Me.endLabel = New System.Windows.Forms.Label()
        Me.DestinationLabel = New System.Windows.Forms.Label()
        Me.ModifyTripButton = New System.Windows.Forms.Button()
        Me.CarControlButton = New System.Windows.Forms.Button()
        Me.StopTripButton = New System.Windows.Forms.Button()
        Me.ContactOwnerButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ArrivedLabel = New System.Windows.Forms.Label()
        Me.NextDestIndicator = New System.Windows.Forms.Label()
        Me.ModifiedDestLabel = New System.Windows.Forms.Label()
        Me.ContinueTripButton = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.BackBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackBox
        '
        Me.BackBox.Image = Global.RentECar.My.Resources.ProjectResources.backArrow
        Me.BackBox.Location = New System.Drawing.Point(34, 29)
        Me.BackBox.Name = "BackBox"
        Me.BackBox.Size = New System.Drawing.Size(40, 40)
        Me.BackBox.TabIndex = 12
        Me.BackBox.TabStop = False
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Sitka Text", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TitleLabel.ForeColor = System.Drawing.Color.White
        Me.TitleLabel.Location = New System.Drawing.Point(55, 64)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(231, 30)
        Me.TitleLabel.TabIndex = 13
        Me.TitleLabel.Text = "You are on your way!"
        '
        'startLabel
        '
        Me.startLabel.AutoSize = True
        Me.startLabel.Font = New System.Drawing.Font("Sitka Text", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.startLabel.ForeColor = System.Drawing.Color.White
        Me.startLabel.Location = New System.Drawing.Point(71, 97)
        Me.startLabel.Name = "startLabel"
        Me.startLabel.Size = New System.Drawing.Size(188, 29)
        Me.startLabel.TabIndex = 14
        Me.startLabel.Text = "Start destination:"
        '
        'StartDestinationLabel
        '
        Me.StartDestinationLabel.AutoSize = True
        Me.StartDestinationLabel.Font = New System.Drawing.Font("Sitka Text", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.StartDestinationLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.StartDestinationLabel.Location = New System.Drawing.Point(95, 137)
        Me.StartDestinationLabel.Name = "StartDestinationLabel"
        Me.StartDestinationLabel.Size = New System.Drawing.Size(141, 29)
        Me.StartDestinationLabel.TabIndex = 15
        Me.StartDestinationLabel.Text = "TemplateText"
        '
        'endLabel
        '
        Me.endLabel.AutoSize = True
        Me.endLabel.Font = New System.Drawing.Font("Sitka Text", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.endLabel.ForeColor = System.Drawing.Color.White
        Me.endLabel.Location = New System.Drawing.Point(71, 178)
        Me.endLabel.Name = "endLabel"
        Me.endLabel.Size = New System.Drawing.Size(112, 29)
        Me.endLabel.TabIndex = 16
        Me.endLabel.Text = "Riding to:"
        '
        'DestinationLabel
        '
        Me.DestinationLabel.AutoSize = True
        Me.DestinationLabel.Font = New System.Drawing.Font("Sitka Text", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DestinationLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DestinationLabel.Location = New System.Drawing.Point(104, 216)
        Me.DestinationLabel.Name = "DestinationLabel"
        Me.DestinationLabel.Size = New System.Drawing.Size(141, 29)
        Me.DestinationLabel.TabIndex = 17
        Me.DestinationLabel.Text = "TemplateText"
        '
        'ModifyTripButton
        '
        Me.ModifyTripButton.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ModifyTripButton.Location = New System.Drawing.Point(71, 446)
        Me.ModifyTripButton.Name = "ModifyTripButton"
        Me.ModifyTripButton.Size = New System.Drawing.Size(90, 60)
        Me.ModifyTripButton.TabIndex = 18
        Me.ModifyTripButton.Text = "Modify Trip"
        Me.ModifyTripButton.UseVisualStyleBackColor = True
        '
        'CarControlButton
        '
        Me.CarControlButton.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CarControlButton.Location = New System.Drawing.Point(71, 522)
        Me.CarControlButton.Name = "CarControlButton"
        Me.CarControlButton.Size = New System.Drawing.Size(90, 60)
        Me.CarControlButton.TabIndex = 19
        Me.CarControlButton.Text = "Car Controls"
        Me.CarControlButton.UseVisualStyleBackColor = True
        '
        'StopTripButton
        '
        Me.StopTripButton.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.StopTripButton.Location = New System.Drawing.Point(186, 522)
        Me.StopTripButton.Name = "StopTripButton"
        Me.StopTripButton.Size = New System.Drawing.Size(90, 60)
        Me.StopTripButton.TabIndex = 20
        Me.StopTripButton.Text = "Stop Trip"
        Me.StopTripButton.UseVisualStyleBackColor = True
        '
        'ContactOwnerButton
        '
        Me.ContactOwnerButton.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ContactOwnerButton.Location = New System.Drawing.Point(186, 446)
        Me.ContactOwnerButton.Name = "ContactOwnerButton"
        Me.ContactOwnerButton.Size = New System.Drawing.Size(90, 60)
        Me.ContactOwnerButton.TabIndex = 21
        Me.ContactOwnerButton.Text = "Contact Owner"
        Me.ContactOwnerButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RentECar.My.Resources.ProjectResources.iphone_blank
        Me.PictureBox1.Location = New System.Drawing.Point(0, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(339, 642)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'ArrivedLabel
        '
        Me.ArrivedLabel.AutoSize = True
        Me.ArrivedLabel.Font = New System.Drawing.Font("Sitka Text", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ArrivedLabel.ForeColor = System.Drawing.Color.LimeGreen
        Me.ArrivedLabel.Location = New System.Drawing.Point(71, 261)
        Me.ArrivedLabel.Name = "ArrivedLabel"
        Me.ArrivedLabel.Size = New System.Drawing.Size(195, 30)
        Me.ArrivedLabel.TabIndex = 23
        Me.ArrivedLabel.Text = "You have arrived!"
        Me.ArrivedLabel.Visible = False
        '
        'NextDestIndicator
        '
        Me.NextDestIndicator.AutoSize = True
        Me.NextDestIndicator.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.NextDestIndicator.ForeColor = System.Drawing.Color.White
        Me.NextDestIndicator.Location = New System.Drawing.Point(32, 320)
        Me.NextDestIndicator.Name = "NextDestIndicator"
        Me.NextDestIndicator.Size = New System.Drawing.Size(149, 23)
        Me.NextDestIndicator.TabIndex = 24
        Me.NextDestIndicator.Text = "Next destination:"
        Me.NextDestIndicator.Visible = False
        '
        'ModifiedDestLabel
        '
        Me.ModifiedDestLabel.AutoSize = True
        Me.ModifiedDestLabel.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ModifiedDestLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ModifiedDestLabel.Location = New System.Drawing.Point(186, 320)
        Me.ModifiedDestLabel.Name = "ModifiedDestLabel"
        Me.ModifiedDestLabel.Size = New System.Drawing.Size(110, 23)
        Me.ModifiedDestLabel.TabIndex = 25
        Me.ModifiedDestLabel.Text = "TemplateText"
        Me.ModifiedDestLabel.Visible = False
        '
        'ContinueTripButton
        '
        Me.ContinueTripButton.Enabled = False
        Me.ContinueTripButton.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ContinueTripButton.Location = New System.Drawing.Point(131, 380)
        Me.ContinueTripButton.Name = "ContinueTripButton"
        Me.ContinueTripButton.Size = New System.Drawing.Size(90, 60)
        Me.ContinueTripButton.TabIndex = 26
        Me.ContinueTripButton.Text = "Continue Trip"
        Me.ContinueTripButton.UseVisualStyleBackColor = True
        Me.ContinueTripButton.Visible = False
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'CurrentTripControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Controls.Add(Me.BackBox)
        Me.Controls.Add(Me.ContinueTripButton)
        Me.Controls.Add(Me.ModifiedDestLabel)
        Me.Controls.Add(Me.NextDestIndicator)
        Me.Controls.Add(Me.ArrivedLabel)
        Me.Controls.Add(Me.ContactOwnerButton)
        Me.Controls.Add(Me.StopTripButton)
        Me.Controls.Add(Me.CarControlButton)
        Me.Controls.Add(Me.ModifyTripButton)
        Me.Controls.Add(Me.DestinationLabel)
        Me.Controls.Add(Me.endLabel)
        Me.Controls.Add(Me.StartDestinationLabel)
        Me.Controls.Add(Me.startLabel)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "CurrentTripControl"
        Me.Size = New System.Drawing.Size(339, 642)
        CType(Me.BackBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackBox As PictureBox
    Friend WithEvents TitleLabel As Label
    Friend WithEvents startLabel As Label
    Friend WithEvents StartDestinationLabel As Label
    Friend WithEvents endLabel As Label
    Friend WithEvents DestinationLabel As Label
    Friend WithEvents ModifyTripButton As Button
    Friend WithEvents CarControlButton As Button
    Friend WithEvents StopTripButton As Button
    Friend WithEvents ContactOwnerButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ArrivedLabel As Label
    Friend WithEvents NextDestIndicator As Label
    Friend WithEvents ModifiedDestLabel As Label
    Friend WithEvents ContinueTripButton As Button
    Friend WithEvents Timer As Timer
End Class
