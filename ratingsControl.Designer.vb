<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ratingsControl
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
        Me.BackBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.myRatingsButton = New System.Windows.Forms.Button()
        Me.rateRidersButton = New System.Windows.Forms.Button()
        Me.ratingsStars = New System.Windows.Forms.PictureBox()
        Me.diagnosticLabel = New System.Windows.Forms.Label()
        CType(Me.BackBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ratingsStars, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackBox
        '
        Me.BackBox.Image = Global.RentECar.My.Resources.ProjectResources.backArrow
        Me.BackBox.Location = New System.Drawing.Point(36, 32)
        Me.BackBox.Name = "BackBox"
        Me.BackBox.Size = New System.Drawing.Size(40, 40)
        Me.BackBox.TabIndex = 11
        Me.BackBox.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RentECar.My.Resources.ProjectResources.iphone_blank
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(333, 640)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'myRatingsButton
        '
        Me.myRatingsButton.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.myRatingsButton.Location = New System.Drawing.Point(95, 347)
        Me.myRatingsButton.Name = "myRatingsButton"
        Me.myRatingsButton.Size = New System.Drawing.Size(139, 47)
        Me.myRatingsButton.TabIndex = 12
        Me.myRatingsButton.Text = "My Ratings"
        Me.myRatingsButton.UseVisualStyleBackColor = True
        '
        'rateRidersButton
        '
        Me.rateRidersButton.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.rateRidersButton.Location = New System.Drawing.Point(95, 409)
        Me.rateRidersButton.Name = "rateRidersButton"
        Me.rateRidersButton.Size = New System.Drawing.Size(139, 47)
        Me.rateRidersButton.TabIndex = 13
        Me.rateRidersButton.Text = "Rate Riders"
        Me.rateRidersButton.UseVisualStyleBackColor = True
        '
        'ratingsStars
        '
        Me.ratingsStars.Image = Global.RentECar.My.Resources.ProjectResources.fiveStarRatings
        Me.ratingsStars.Location = New System.Drawing.Point(31, 172)
        Me.ratingsStars.Name = "ratingsStars"
        Me.ratingsStars.Size = New System.Drawing.Size(270, 70)
        Me.ratingsStars.TabIndex = 14
        Me.ratingsStars.TabStop = False
        '
        'diagnosticLabel
        '
        Me.diagnosticLabel.AutoSize = True
        Me.diagnosticLabel.Font = New System.Drawing.Font("Sitka Text", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.diagnosticLabel.ForeColor = System.Drawing.Color.Transparent
        Me.diagnosticLabel.Location = New System.Drawing.Point(57, 141)
        Me.diagnosticLabel.Name = "diagnosticLabel"
        Me.diagnosticLabel.Size = New System.Drawing.Size(229, 28)
        Me.diagnosticLabel.TabIndex = 15
        Me.diagnosticLabel.Text = "Your Current Rating is:"
        '
        'ratingsControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Controls.Add(Me.diagnosticLabel)
        Me.Controls.Add(Me.ratingsStars)
        Me.Controls.Add(Me.rateRidersButton)
        Me.Controls.Add(Me.myRatingsButton)
        Me.Controls.Add(Me.BackBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "ratingsControl"
        Me.Size = New System.Drawing.Size(336, 642)
        CType(Me.BackBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ratingsStars, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackBox As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents myRatingsButton As Button
    Friend WithEvents rateRidersButton As Button
    Friend WithEvents ratingsStars As PictureBox
    Friend WithEvents diagnosticLabel As Label
End Class
