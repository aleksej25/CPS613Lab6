<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class riderCarStatusControl
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
        Me.mapBox = New System.Windows.Forms.Button()
        Me.cameraBox = New System.Windows.Forms.Button()
        Me.exteriorButton = New System.Windows.Forms.RadioButton()
        Me.interiorButton = New System.Windows.Forms.RadioButton()
        Me.BackBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.BackBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mapBox
        '
        Me.mapBox.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.mapBox.Image = Global.RentECar.My.Resources.ProjectResources.mapIcon
        Me.mapBox.Location = New System.Drawing.Point(109, 357)
        Me.mapBox.Name = "mapBox"
        Me.mapBox.Size = New System.Drawing.Size(115, 115)
        Me.mapBox.TabIndex = 30
        Me.mapBox.UseVisualStyleBackColor = False
        '
        'cameraBox
        '
        Me.cameraBox.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.cameraBox.Image = Global.RentECar.My.Resources.ProjectResources.cameraIcon
        Me.cameraBox.Location = New System.Drawing.Point(109, 162)
        Me.cameraBox.Name = "cameraBox"
        Me.cameraBox.Size = New System.Drawing.Size(115, 115)
        Me.cameraBox.TabIndex = 29
        Me.cameraBox.UseVisualStyleBackColor = False
        '
        'exteriorButton
        '
        Me.exteriorButton.AutoSize = True
        Me.exteriorButton.Font = New System.Drawing.Font("Sitka Heading", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.exteriorButton.ForeColor = System.Drawing.Color.Transparent
        Me.exteriorButton.Location = New System.Drawing.Point(126, 303)
        Me.exteriorButton.Name = "exteriorButton"
        Me.exteriorButton.Size = New System.Drawing.Size(84, 25)
        Me.exteriorButton.TabIndex = 28
        Me.exteriorButton.TabStop = True
        Me.exteriorButton.Text = "Exterior"
        Me.exteriorButton.UseVisualStyleBackColor = True
        '
        'interiorButton
        '
        Me.interiorButton.AutoSize = True
        Me.interiorButton.Font = New System.Drawing.Font("Sitka Heading", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.interiorButton.ForeColor = System.Drawing.Color.Transparent
        Me.interiorButton.Location = New System.Drawing.Point(126, 283)
        Me.interiorButton.Name = "interiorButton"
        Me.interiorButton.Size = New System.Drawing.Size(81, 25)
        Me.interiorButton.TabIndex = 27
        Me.interiorButton.TabStop = True
        Me.interiorButton.Text = "Interior"
        Me.interiorButton.UseVisualStyleBackColor = True
        '
        'BackBox
        '
        Me.BackBox.Image = Global.RentECar.My.Resources.ProjectResources.backArrow
        Me.BackBox.Location = New System.Drawing.Point(36, 32)
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
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Text", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(95, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 30)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Car Controls"
        '
        'riderCarStatusControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mapBox)
        Me.Controls.Add(Me.cameraBox)
        Me.Controls.Add(Me.exteriorButton)
        Me.Controls.Add(Me.interiorButton)
        Me.Controls.Add(Me.BackBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "riderCarStatusControl"
        Me.Size = New System.Drawing.Size(338, 642)
        CType(Me.BackBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mapBox As Button
    Friend WithEvents cameraBox As Button
    Friend WithEvents exteriorButton As RadioButton
    Friend WithEvents interiorButton As RadioButton
    Friend WithEvents BackBox As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
