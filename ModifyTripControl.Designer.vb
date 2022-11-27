<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifyTripControl
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
        Me.BackBox = New System.Windows.Forms.PictureBox()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.newDestLabel = New System.Windows.Forms.Label()
        Me.ToLocationBox = New System.Windows.Forms.ComboBox()
        Me.ChangeButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.addLegButton = New System.Windows.Forms.RadioButton()
        Me.newDestButton = New System.Windows.Forms.RadioButton()
        Me.costLabel = New System.Windows.Forms.Label()
        Me.etaLabel = New System.Windows.Forms.Label()
        Me.approvalLabel = New System.Windows.Forms.Label()
        Me.loadingBox = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.BackBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.loadingBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackBox
        '
        Me.BackBox.Image = Global.RentECar.My.Resources.ProjectResources.backArrow
        Me.BackBox.Location = New System.Drawing.Point(35, 34)
        Me.BackBox.Name = "BackBox"
        Me.BackBox.Size = New System.Drawing.Size(40, 40)
        Me.BackBox.TabIndex = 13
        Me.BackBox.TabStop = False
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Sitka Text", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TitleLabel.ForeColor = System.Drawing.Color.White
        Me.TitleLabel.Location = New System.Drawing.Point(93, 48)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(153, 35)
        Me.TitleLabel.TabIndex = 14
        Me.TitleLabel.Text = "Modify trip"
        '
        'newDestLabel
        '
        Me.newDestLabel.AutoSize = True
        Me.newDestLabel.Font = New System.Drawing.Font("Sitka Text", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.newDestLabel.ForeColor = System.Drawing.Color.White
        Me.newDestLabel.Location = New System.Drawing.Point(47, 198)
        Me.newDestLabel.Name = "newDestLabel"
        Me.newDestLabel.Size = New System.Drawing.Size(89, 28)
        Me.newDestLabel.TabIndex = 15
        Me.newDestLabel.Text = "Add Leg:"
        Me.newDestLabel.Visible = False
        '
        'ToLocationBox
        '
        Me.ToLocationBox.FormattingEnabled = True
        Me.ToLocationBox.Location = New System.Drawing.Point(175, 205)
        Me.ToLocationBox.Name = "ToLocationBox"
        Me.ToLocationBox.Size = New System.Drawing.Size(121, 23)
        Me.ToLocationBox.TabIndex = 17
        Me.ToLocationBox.Visible = False
        '
        'ChangeButton
        '
        Me.ChangeButton.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ChangeButton.Location = New System.Drawing.Point(111, 511)
        Me.ChangeButton.Name = "ChangeButton"
        Me.ChangeButton.Size = New System.Drawing.Size(122, 66)
        Me.ChangeButton.TabIndex = 19
        Me.ChangeButton.Text = "Confirm Change"
        Me.ChangeButton.UseVisualStyleBackColor = True
        Me.ChangeButton.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RentECar.My.Resources.ProjectResources.iphone_blank
        Me.PictureBox1.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(336, 642)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'addLegButton
        '
        Me.addLegButton.AutoSize = True
        Me.addLegButton.Font = New System.Drawing.Font("Sitka Text", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.addLegButton.ForeColor = System.Drawing.Color.White
        Me.addLegButton.Location = New System.Drawing.Point(47, 142)
        Me.addLegButton.Name = "addLegButton"
        Me.addLegButton.Size = New System.Drawing.Size(114, 32)
        Me.addLegButton.TabIndex = 22
        Me.addLegButton.Text = "Add Stop"
        Me.addLegButton.UseVisualStyleBackColor = True
        '
        'newDestButton
        '
        Me.newDestButton.AutoSize = True
        Me.newDestButton.Font = New System.Drawing.Font("Sitka Text", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.newDestButton.ForeColor = System.Drawing.Color.White
        Me.newDestButton.Location = New System.Drawing.Point(47, 104)
        Me.newDestButton.Name = "newDestButton"
        Me.newDestButton.Size = New System.Drawing.Size(186, 32)
        Me.newDestButton.TabIndex = 21
        Me.newDestButton.Text = "New Destination"
        Me.newDestButton.UseVisualStyleBackColor = True
        '
        'costLabel
        '
        Me.costLabel.AutoSize = True
        Me.costLabel.Font = New System.Drawing.Font("Sitka Text", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.costLabel.ForeColor = System.Drawing.Color.White
        Me.costLabel.Location = New System.Drawing.Point(45, 279)
        Me.costLabel.Name = "costLabel"
        Me.costLabel.Size = New System.Drawing.Size(27, 30)
        Me.costLabel.TabIndex = 27
        Me.costLabel.Text = "T"
        Me.costLabel.Visible = False
        '
        'etaLabel
        '
        Me.etaLabel.AutoSize = True
        Me.etaLabel.Font = New System.Drawing.Font("Sitka Text", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.etaLabel.ForeColor = System.Drawing.Color.White
        Me.etaLabel.Location = New System.Drawing.Point(45, 324)
        Me.etaLabel.Name = "etaLabel"
        Me.etaLabel.Size = New System.Drawing.Size(27, 30)
        Me.etaLabel.TabIndex = 28
        Me.etaLabel.Text = "T"
        Me.etaLabel.Visible = False
        '
        'approvalLabel
        '
        Me.approvalLabel.AutoSize = True
        Me.approvalLabel.Font = New System.Drawing.Font("Sitka Text", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.approvalLabel.ForeColor = System.Drawing.Color.White
        Me.approvalLabel.Location = New System.Drawing.Point(154, 480)
        Me.approvalLabel.Name = "approvalLabel"
        Me.approvalLabel.Size = New System.Drawing.Size(25, 28)
        Me.approvalLabel.TabIndex = 29
        Me.approvalLabel.Text = "T"
        Me.approvalLabel.Visible = False
        '
        'loadingBox
        '
        Me.loadingBox.Image = Global.RentECar.My.Resources.ProjectResources.loading
        Me.loadingBox.Location = New System.Drawing.Point(115, 372)
        Me.loadingBox.Name = "loadingBox"
        Me.loadingBox.Size = New System.Drawing.Size(105, 105)
        Me.loadingBox.TabIndex = 30
        Me.loadingBox.TabStop = False
        Me.loadingBox.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'ModifyTripControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Controls.Add(Me.loadingBox)
        Me.Controls.Add(Me.approvalLabel)
        Me.Controls.Add(Me.etaLabel)
        Me.Controls.Add(Me.costLabel)
        Me.Controls.Add(Me.addLegButton)
        Me.Controls.Add(Me.newDestButton)
        Me.Controls.Add(Me.ChangeButton)
        Me.Controls.Add(Me.ToLocationBox)
        Me.Controls.Add(Me.newDestLabel)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.BackBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "ModifyTripControl"
        Me.Size = New System.Drawing.Size(339, 642)
        CType(Me.BackBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.loadingBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackBox As PictureBox
    Friend WithEvents TitleLabel As Label
    Friend WithEvents newDestLabel As Label
    Friend WithEvents ToLocationBox As ComboBox
    Friend WithEvents ChangeButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents addLegButton As RadioButton
    Friend WithEvents newDestButton As RadioButton
    Friend WithEvents costLabel As Label
    Friend WithEvents etaLabel As Label
    Friend WithEvents approvalLabel As Label
    Friend WithEvents loadingBox As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
