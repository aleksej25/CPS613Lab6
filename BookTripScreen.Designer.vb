<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookTripScreen
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
        Me.BackBox = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FromLocationBox = New System.Windows.Forms.ComboBox()
        Me.ToLocationBox = New System.Windows.Forms.ComboBox()
        Me.PeopleComboBox = New System.Windows.Forms.ComboBox()
        Me.NowRadioButton = New System.Windows.Forms.RadioButton()
        Me.LaterRadioButton = New System.Windows.Forms.RadioButton()
        Me.futureTimeLabel = New System.Windows.Forms.Label()
        Me.futureTimeBox = New System.Windows.Forms.ComboBox()
        Me.BookButton = New System.Windows.Forms.Button()
        Me.CaptionLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RentECar.My.Resources.ProjectResources.iphone_blank
        Me.PictureBox1.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(340, 639)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BackBox
        '
        Me.BackBox.Image = Global.RentECar.My.Resources.ProjectResources.backArrow
        Me.BackBox.Location = New System.Drawing.Point(39, 36)
        Me.BackBox.Name = "BackBox"
        Me.BackBox.Size = New System.Drawing.Size(40, 40)
        Me.BackBox.TabIndex = 10
        Me.BackBox.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Text", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(91, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 35)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Book a Trip"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sitka Text", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(50, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 28)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "From:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sitka Text", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(50, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 28)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "To:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(50, 251)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 23)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Number of people:"
        '
        'FromLocationBox
        '
        Me.FromLocationBox.FormattingEnabled = True
        Me.FromLocationBox.Location = New System.Drawing.Point(171, 164)
        Me.FromLocationBox.Name = "FromLocationBox"
        Me.FromLocationBox.Size = New System.Drawing.Size(121, 23)
        Me.FromLocationBox.TabIndex = 15
        '
        'ToLocationBox
        '
        Me.ToLocationBox.FormattingEnabled = True
        Me.ToLocationBox.Location = New System.Drawing.Point(171, 205)
        Me.ToLocationBox.Name = "ToLocationBox"
        Me.ToLocationBox.Size = New System.Drawing.Size(121, 23)
        Me.ToLocationBox.TabIndex = 16
        '
        'PeopleComboBox
        '
        Me.PeopleComboBox.FormattingEnabled = True
        Me.PeopleComboBox.Location = New System.Drawing.Point(232, 254)
        Me.PeopleComboBox.Name = "PeopleComboBox"
        Me.PeopleComboBox.Size = New System.Drawing.Size(60, 23)
        Me.PeopleComboBox.TabIndex = 17
        '
        'NowRadioButton
        '
        Me.NowRadioButton.AutoSize = True
        Me.NowRadioButton.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NowRadioButton.ForeColor = System.Drawing.Color.White
        Me.NowRadioButton.Location = New System.Drawing.Point(55, 311)
        Me.NowRadioButton.Name = "NowRadioButton"
        Me.NowRadioButton.Size = New System.Drawing.Size(62, 27)
        Me.NowRadioButton.TabIndex = 18
        Me.NowRadioButton.TabStop = True
        Me.NowRadioButton.Text = "Now"
        Me.NowRadioButton.UseVisualStyleBackColor = True
        '
        'LaterRadioButton
        '
        Me.LaterRadioButton.AutoSize = True
        Me.LaterRadioButton.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LaterRadioButton.ForeColor = System.Drawing.Color.White
        Me.LaterRadioButton.Location = New System.Drawing.Point(225, 311)
        Me.LaterRadioButton.Name = "LaterRadioButton"
        Me.LaterRadioButton.Size = New System.Drawing.Size(67, 27)
        Me.LaterRadioButton.TabIndex = 19
        Me.LaterRadioButton.TabStop = True
        Me.LaterRadioButton.Text = "Later"
        Me.LaterRadioButton.UseVisualStyleBackColor = True
        '
        'futureTimeLabel
        '
        Me.futureTimeLabel.AutoSize = True
        Me.futureTimeLabel.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.futureTimeLabel.ForeColor = System.Drawing.Color.White
        Me.futureTimeLabel.Location = New System.Drawing.Point(39, 380)
        Me.futureTimeLabel.Name = "futureTimeLabel"
        Me.futureTimeLabel.Size = New System.Drawing.Size(170, 23)
        Me.futureTimeLabel.TabIndex = 20
        Me.futureTimeLabel.Text = "Future Pick Up Time:"
        '
        'futureTimeBox
        '
        Me.futureTimeBox.FormattingEnabled = True
        Me.futureTimeBox.Location = New System.Drawing.Point(181, 406)
        Me.futureTimeBox.Name = "futureTimeBox"
        Me.futureTimeBox.Size = New System.Drawing.Size(121, 23)
        Me.futureTimeBox.TabIndex = 22
        '
        'BookButton
        '
        Me.BookButton.Font = New System.Drawing.Font("Sitka Text", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BookButton.Location = New System.Drawing.Point(117, 508)
        Me.BookButton.Name = "BookButton"
        Me.BookButton.Size = New System.Drawing.Size(98, 50)
        Me.BookButton.TabIndex = 24
        Me.BookButton.Text = "Book"
        Me.BookButton.UseVisualStyleBackColor = True
        '
        'CaptionLabel
        '
        Me.CaptionLabel.AutoSize = True
        Me.CaptionLabel.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CaptionLabel.ForeColor = System.Drawing.Color.White
        Me.CaptionLabel.Location = New System.Drawing.Point(55, 121)
        Me.CaptionLabel.Name = "CaptionLabel"
        Me.CaptionLabel.Size = New System.Drawing.Size(224, 23)
        Me.CaptionLabel.TabIndex = 25
        Me.CaptionLabel.Text = "Today is Thursday, 10:00AM"
        '
        'BookTripScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Controls.Add(Me.CaptionLabel)
        Me.Controls.Add(Me.BookButton)
        Me.Controls.Add(Me.futureTimeBox)
        Me.Controls.Add(Me.futureTimeLabel)
        Me.Controls.Add(Me.LaterRadioButton)
        Me.Controls.Add(Me.NowRadioButton)
        Me.Controls.Add(Me.PeopleComboBox)
        Me.Controls.Add(Me.ToLocationBox)
        Me.Controls.Add(Me.FromLocationBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BackBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "BookTripScreen"
        Me.Size = New System.Drawing.Size(339, 642)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BackBox As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents FromLocationBox As ComboBox
    Friend WithEvents ToLocationBox As ComboBox
    Friend WithEvents PeopleComboBox As ComboBox
    Friend WithEvents NowRadioButton As RadioButton
    Friend WithEvents LaterRadioButton As RadioButton
    Friend WithEvents futureTimeLabel As Label
    Friend WithEvents futureTimeBox As ComboBox
    Friend WithEvents BookButton As Button
    Friend WithEvents CaptionLabel As Label
End Class
