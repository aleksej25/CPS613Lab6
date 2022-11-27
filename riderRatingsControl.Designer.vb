<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class riderRatingsControl
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RatingBox = New System.Windows.Forms.PictureBox()
        Me.LastCarButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ScoreLabel = New System.Windows.Forms.Label()
        Me.ScoreBox = New System.Windows.Forms.ComboBox()
        Me.RateButton = New System.Windows.Forms.Button()
        Me.ThanksLabel = New System.Windows.Forms.Label()
        Me.myRatingsButton = New System.Windows.Forms.Button()
        CType(Me.BackBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RatingBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackBox
        '
        Me.BackBox.Image = Global.RentECar.My.Resources.ProjectResources.backArrow
        Me.BackBox.Location = New System.Drawing.Point(35, 36)
        Me.BackBox.Name = "BackBox"
        Me.BackBox.Size = New System.Drawing.Size(40, 40)
        Me.BackBox.TabIndex = 11
        Me.BackBox.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Text", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(35, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 35)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Your current rating is:"
        '
        'RatingBox
        '
        Me.RatingBox.Image = Global.RentECar.My.Resources.ProjectResources.clipart676962
        Me.RatingBox.Location = New System.Drawing.Point(35, 198)
        Me.RatingBox.Name = "RatingBox"
        Me.RatingBox.Size = New System.Drawing.Size(268, 70)
        Me.RatingBox.TabIndex = 13
        Me.RatingBox.TabStop = False
        '
        'LastCarButton
        '
        Me.LastCarButton.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LastCarButton.Location = New System.Drawing.Point(97, 405)
        Me.LastCarButton.Name = "LastCarButton"
        Me.LastCarButton.Size = New System.Drawing.Size(139, 47)
        Me.LastCarButton.TabIndex = 15
        Me.LastCarButton.Text = "Rate Last Car"
        Me.LastCarButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RentECar.My.Resources.ProjectResources.iphone_blank
        Me.PictureBox1.Location = New System.Drawing.Point(0, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(339, 639)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'ScoreLabel
        '
        Me.ScoreLabel.AutoSize = True
        Me.ScoreLabel.Font = New System.Drawing.Font("Sitka Text", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ScoreLabel.ForeColor = System.Drawing.Color.White
        Me.ScoreLabel.Location = New System.Drawing.Point(35, 493)
        Me.ScoreLabel.Name = "ScoreLabel"
        Me.ScoreLabel.Size = New System.Drawing.Size(69, 28)
        Me.ScoreLabel.TabIndex = 17
        Me.ScoreLabel.Text = "Score:"
        Me.ScoreLabel.Visible = False
        '
        'ScoreBox
        '
        Me.ScoreBox.FormattingEnabled = True
        Me.ScoreBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.ScoreBox.Location = New System.Drawing.Point(121, 500)
        Me.ScoreBox.Name = "ScoreBox"
        Me.ScoreBox.Size = New System.Drawing.Size(68, 23)
        Me.ScoreBox.TabIndex = 18
        Me.ScoreBox.Visible = False
        '
        'RateButton
        '
        Me.RateButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RateButton.Location = New System.Drawing.Point(215, 493)
        Me.RateButton.Name = "RateButton"
        Me.RateButton.Size = New System.Drawing.Size(79, 33)
        Me.RateButton.TabIndex = 19
        Me.RateButton.Text = "Rate"
        Me.RateButton.UseVisualStyleBackColor = True
        Me.RateButton.Visible = False
        '
        'ThanksLabel
        '
        Me.ThanksLabel.AutoSize = True
        Me.ThanksLabel.Font = New System.Drawing.Font("Sitka Text", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ThanksLabel.ForeColor = System.Drawing.Color.White
        Me.ThanksLabel.Location = New System.Drawing.Point(75, 544)
        Me.ThanksLabel.Name = "ThanksLabel"
        Me.ThanksLabel.Size = New System.Drawing.Size(175, 28)
        Me.ThanksLabel.TabIndex = 20
        Me.ThanksLabel.Text = "Thanks for rating!"
        Me.ThanksLabel.Visible = False
        '
        'myRatingsButton
        '
        Me.myRatingsButton.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.myRatingsButton.Location = New System.Drawing.Point(97, 343)
        Me.myRatingsButton.Name = "myRatingsButton"
        Me.myRatingsButton.Size = New System.Drawing.Size(139, 47)
        Me.myRatingsButton.TabIndex = 21
        Me.myRatingsButton.Text = "My Ratings"
        Me.myRatingsButton.UseVisualStyleBackColor = True
        '
        'riderRatingsControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Controls.Add(Me.myRatingsButton)
        Me.Controls.Add(Me.ThanksLabel)
        Me.Controls.Add(Me.RateButton)
        Me.Controls.Add(Me.ScoreBox)
        Me.Controls.Add(Me.ScoreLabel)
        Me.Controls.Add(Me.LastCarButton)
        Me.Controls.Add(Me.RatingBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BackBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "riderRatingsControl"
        Me.Size = New System.Drawing.Size(339, 642)
        CType(Me.BackBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RatingBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackBox As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RatingBox As PictureBox
    Friend WithEvents LastCarButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ScoreLabel As Label
    Friend WithEvents ScoreBox As ComboBox
    Friend WithEvents RateButton As Button
    Friend WithEvents ThanksLabel As Label
    Friend WithEvents myRatingsButton As Button
End Class
