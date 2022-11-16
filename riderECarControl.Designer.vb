<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class riderECarControl
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.climateControlButton = New System.Windows.Forms.Button()
        Me.carMediaButton = New System.Windows.Forms.Button()
        Me.trunkButton = New System.Windows.Forms.Button()
        Me.carBox = New System.Windows.Forms.Button()
        Me.windowButton = New System.Windows.Forms.Button()
        Me.statusLabel = New System.Windows.Forms.Label()
        Me.trunkOCLabel = New System.Windows.Forms.Label()
        Me.BackBox = New System.Windows.Forms.PictureBox()
        Me.TtileLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.BackBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(163, 553)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 23)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Climate Controls"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(51, 553)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 23)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Car Media "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(97, 390)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 23)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Window Controls"
        '
        'climateControlButton
        '
        Me.climateControlButton.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.climateControlButton.Image = Global.RentECar.My.Resources.ProjectResources.tempIcon
        Me.climateControlButton.Location = New System.Drawing.Point(168, 430)
        Me.climateControlButton.Name = "climateControlButton"
        Me.climateControlButton.Size = New System.Drawing.Size(120, 120)
        Me.climateControlButton.TabIndex = 55
        Me.climateControlButton.UseVisualStyleBackColor = False
        '
        'carMediaButton
        '
        Me.carMediaButton.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.carMediaButton.Image = Global.RentECar.My.Resources.ProjectResources.carMultiMedia
        Me.carMediaButton.Location = New System.Drawing.Point(35, 430)
        Me.carMediaButton.Name = "carMediaButton"
        Me.carMediaButton.Size = New System.Drawing.Size(120, 120)
        Me.carMediaButton.TabIndex = 54
        Me.carMediaButton.UseVisualStyleBackColor = False
        '
        'trunkButton
        '
        Me.trunkButton.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.trunkButton.Image = Global.RentECar.My.Resources.ProjectResources.openTrunk
        Me.trunkButton.Location = New System.Drawing.Point(35, 124)
        Me.trunkButton.Name = "trunkButton"
        Me.trunkButton.Size = New System.Drawing.Size(120, 120)
        Me.trunkButton.TabIndex = 53
        Me.trunkButton.UseVisualStyleBackColor = False
        '
        'carBox
        '
        Me.carBox.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.carBox.Image = Global.RentECar.My.Resources.ProjectResources.carDiagnostic
        Me.carBox.Location = New System.Drawing.Point(168, 124)
        Me.carBox.Name = "carBox"
        Me.carBox.Size = New System.Drawing.Size(120, 120)
        Me.carBox.TabIndex = 52
        Me.carBox.UseVisualStyleBackColor = False
        '
        'windowButton
        '
        Me.windowButton.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.windowButton.Image = Global.RentECar.My.Resources.ProjectResources.windowIcon
        Me.windowButton.Location = New System.Drawing.Point(107, 277)
        Me.windowButton.Name = "windowButton"
        Me.windowButton.Size = New System.Drawing.Size(110, 110)
        Me.windowButton.TabIndex = 51
        Me.windowButton.UseVisualStyleBackColor = False
        '
        'statusLabel
        '
        Me.statusLabel.AutoSize = True
        Me.statusLabel.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.statusLabel.ForeColor = System.Drawing.Color.Transparent
        Me.statusLabel.Location = New System.Drawing.Point(203, 242)
        Me.statusLabel.Name = "statusLabel"
        Me.statusLabel.Size = New System.Drawing.Size(55, 23)
        Me.statusLabel.TabIndex = 50
        Me.statusLabel.Text = "Status"
        '
        'trunkOCLabel
        '
        Me.trunkOCLabel.AutoSize = True
        Me.trunkOCLabel.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.trunkOCLabel.ForeColor = System.Drawing.Color.Transparent
        Me.trunkOCLabel.Location = New System.Drawing.Point(45, 242)
        Me.trunkOCLabel.Name = "trunkOCLabel"
        Me.trunkOCLabel.Size = New System.Drawing.Size(104, 23)
        Me.trunkOCLabel.TabIndex = 49
        Me.trunkOCLabel.Text = "Trunk Closed"
        '
        'BackBox
        '
        Me.BackBox.Image = Global.RentECar.My.Resources.ProjectResources.backArrow
        Me.BackBox.Location = New System.Drawing.Point(35, 28)
        Me.BackBox.Name = "BackBox"
        Me.BackBox.Size = New System.Drawing.Size(40, 40)
        Me.BackBox.TabIndex = 48
        Me.BackBox.TabStop = False
        '
        'TtileLabel
        '
        Me.TtileLabel.AutoSize = True
        Me.TtileLabel.Font = New System.Drawing.Font("Sitka Heading", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TtileLabel.ForeColor = System.Drawing.Color.Transparent
        Me.TtileLabel.Location = New System.Drawing.Point(74, 55)
        Me.TtileLabel.Name = "TtileLabel"
        Me.TtileLabel.Size = New System.Drawing.Size(184, 39)
        Me.TtileLabel.TabIndex = 47
        Me.TtileLabel.Text = "ECar Controls"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RentECar.My.Resources.ProjectResources.iphone_blank
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(333, 640)
        Me.PictureBox1.TabIndex = 46
        Me.PictureBox1.TabStop = False
        '
        'riderECarControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.climateControlButton)
        Me.Controls.Add(Me.carMediaButton)
        Me.Controls.Add(Me.trunkButton)
        Me.Controls.Add(Me.carBox)
        Me.Controls.Add(Me.windowButton)
        Me.Controls.Add(Me.statusLabel)
        Me.Controls.Add(Me.trunkOCLabel)
        Me.Controls.Add(Me.BackBox)
        Me.Controls.Add(Me.TtileLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "riderECarControl"
        Me.Size = New System.Drawing.Size(338, 643)
        CType(Me.BackBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents climateControlButton As Button
    Friend WithEvents carMediaButton As Button
    Friend WithEvents trunkButton As Button
    Friend WithEvents carBox As Button
    Friend WithEvents windowButton As Button
    Friend WithEvents statusLabel As Label
    Friend WithEvents trunkOCLabel As Label
    Friend WithEvents BackBox As PictureBox
    Friend WithEvents TtileLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
