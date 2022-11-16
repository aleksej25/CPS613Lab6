<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RiderMainScreen
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RiderMainTitleLabel = New System.Windows.Forms.Label()
        Me.BookTripButton = New System.Windows.Forms.Button()
        Me.RiderRatingsButton = New System.Windows.Forms.Button()
        Me.CurrentStatusLabel = New System.Windows.Forms.Label()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.ViewHistoryButton = New System.Windows.Forms.Button()
        Me.CurrentTripButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RentECar.My.Resources.ProjectResources.iphone_blank
        Me.PictureBox1.Location = New System.Drawing.Point(0, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(333, 640)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'RiderMainTitleLabel
        '
        Me.RiderMainTitleLabel.AutoSize = True
        Me.RiderMainTitleLabel.Font = New System.Drawing.Font("Sitka Text", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RiderMainTitleLabel.ForeColor = System.Drawing.Color.White
        Me.RiderMainTitleLabel.Location = New System.Drawing.Point(62, 64)
        Me.RiderMainTitleLabel.Name = "RiderMainTitleLabel"
        Me.RiderMainTitleLabel.Size = New System.Drawing.Size(203, 35)
        Me.RiderMainTitleLabel.TabIndex = 10
        Me.RiderMainTitleLabel.Text = "Welcome Rider!"
        '
        'BookTripButton
        '
        Me.BookTripButton.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BookTripButton.Location = New System.Drawing.Point(101, 358)
        Me.BookTripButton.Name = "BookTripButton"
        Me.BookTripButton.Size = New System.Drawing.Size(134, 42)
        Me.BookTripButton.TabIndex = 11
        Me.BookTripButton.Text = "Book a trip"
        Me.BookTripButton.UseVisualStyleBackColor = True
        '
        'RiderRatingsButton
        '
        Me.RiderRatingsButton.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RiderRatingsButton.Location = New System.Drawing.Point(101, 471)
        Me.RiderRatingsButton.Name = "RiderRatingsButton"
        Me.RiderRatingsButton.Size = New System.Drawing.Size(134, 42)
        Me.RiderRatingsButton.TabIndex = 14
        Me.RiderRatingsButton.Text = "Ratings"
        Me.RiderRatingsButton.UseVisualStyleBackColor = True
        '
        'CurrentStatusLabel
        '
        Me.CurrentStatusLabel.AutoSize = True
        Me.CurrentStatusLabel.Font = New System.Drawing.Font("Sitka Text", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CurrentStatusLabel.ForeColor = System.Drawing.Color.White
        Me.CurrentStatusLabel.Location = New System.Drawing.Point(32, 123)
        Me.CurrentStatusLabel.Name = "CurrentStatusLabel"
        Me.CurrentStatusLabel.Size = New System.Drawing.Size(155, 28)
        Me.CurrentStatusLabel.TabIndex = 15
        Me.CurrentStatusLabel.Text = "Current status:"
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.Font = New System.Drawing.Font("Sitka Text", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.StatusLabel.ForeColor = System.Drawing.Color.Red
        Me.StatusLabel.Location = New System.Drawing.Point(181, 124)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(115, 28)
        Me.StatusLabel.TabIndex = 16
        Me.StatusLabel.Text = "Not on trip"
        '
        'ViewHistoryButton
        '
        Me.ViewHistoryButton.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ViewHistoryButton.Location = New System.Drawing.Point(101, 414)
        Me.ViewHistoryButton.Name = "ViewHistoryButton"
        Me.ViewHistoryButton.Size = New System.Drawing.Size(134, 42)
        Me.ViewHistoryButton.TabIndex = 17
        Me.ViewHistoryButton.Text = "History"
        Me.ViewHistoryButton.UseVisualStyleBackColor = True
        '
        'CurrentTripButton
        '
        Me.CurrentTripButton.Enabled = False
        Me.CurrentTripButton.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CurrentTripButton.Location = New System.Drawing.Point(101, 300)
        Me.CurrentTripButton.Name = "CurrentTripButton"
        Me.CurrentTripButton.Size = New System.Drawing.Size(134, 42)
        Me.CurrentTripButton.TabIndex = 19
        Me.CurrentTripButton.Text = "Current trip"
        Me.CurrentTripButton.UseVisualStyleBackColor = True
        Me.CurrentTripButton.Visible = False
        '
        'RiderMainScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Controls.Add(Me.CurrentTripButton)
        Me.Controls.Add(Me.ViewHistoryButton)
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.CurrentStatusLabel)
        Me.Controls.Add(Me.RiderRatingsButton)
        Me.Controls.Add(Me.BookTripButton)
        Me.Controls.Add(Me.RiderMainTitleLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "RiderMainScreen"
        Me.Size = New System.Drawing.Size(338, 642)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RiderMainTitleLabel As Label
    Friend WithEvents BookTripButton As Button
    Friend WithEvents RiderRatingsButton As Button
    Friend WithEvents CurrentStatusLabel As Label
    Friend WithEvents StatusLabel As Label
    Friend WithEvents ViewHistoryButton As Button
    Friend WithEvents CurrentTripButton As Button
End Class
