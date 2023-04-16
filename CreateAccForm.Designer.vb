<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateAccForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateAccForm))
        Me.TxtBankAcc = New System.Windows.Forms.TextBox()
        Me.TxtUser = New System.Windows.Forms.TextBox()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.BankAccNum = New System.Windows.Forms.Label()
        Me.TxtCpass = New System.Windows.Forms.TextBox()
        Me.BTcreateacc = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LinkBack = New System.Windows.Forms.LinkLabel()
        Me.lblerror = New System.Windows.Forms.Label()
        Me.lblsuccess = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtBankAcc
        '
        Me.TxtBankAcc.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.TxtBankAcc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtBankAcc.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBankAcc.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.TxtBankAcc.Location = New System.Drawing.Point(39, 191)
        Me.TxtBankAcc.MaxLength = 10
        Me.TxtBankAcc.Name = "TxtBankAcc"
        Me.TxtBankAcc.Size = New System.Drawing.Size(252, 20)
        Me.TxtBankAcc.TabIndex = 0
        '
        'TxtUser
        '
        Me.TxtUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.TxtUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtUser.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUser.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.TxtUser.Location = New System.Drawing.Point(40, 261)
        Me.TxtUser.MaxLength = 15
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Size = New System.Drawing.Size(252, 20)
        Me.TxtUser.TabIndex = 1
        '
        'TxtPass
        '
        Me.TxtPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.TxtPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPass.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPass.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.TxtPass.Location = New System.Drawing.Point(40, 327)
        Me.TxtPass.MaxLength = 15
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.Size = New System.Drawing.Size(252, 20)
        Me.TxtPass.TabIndex = 2
        Me.TxtPass.UseSystemPasswordChar = True
        '
        'BankAccNum
        '
        Me.BankAccNum.AutoSize = True
        Me.BankAccNum.BackColor = System.Drawing.Color.Transparent
        Me.BankAccNum.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BankAccNum.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.BankAccNum.Location = New System.Drawing.Point(36, 166)
        Me.BankAccNum.Name = "BankAccNum"
        Me.BankAccNum.Size = New System.Drawing.Size(135, 16)
        Me.BankAccNum.TabIndex = 3
        Me.BankAccNum.Text = "Bank Account Number"
        '
        'TxtCpass
        '
        Me.TxtCpass.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.TxtCpass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCpass.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCpass.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.TxtCpass.Location = New System.Drawing.Point(40, 393)
        Me.TxtCpass.MaxLength = 15
        Me.TxtCpass.Name = "TxtCpass"
        Me.TxtCpass.Size = New System.Drawing.Size(252, 20)
        Me.TxtCpass.TabIndex = 6
        Me.TxtCpass.UseSystemPasswordChar = True
        '
        'BTcreateacc
        '
        Me.BTcreateacc.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.BTcreateacc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTcreateacc.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTcreateacc.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.BTcreateacc.Location = New System.Drawing.Point(228, 465)
        Me.BTcreateacc.Name = "BTcreateacc"
        Me.BTcreateacc.Size = New System.Drawing.Size(142, 46)
        Me.BTcreateacc.TabIndex = 8
        Me.BTcreateacc.Text = "Register Account"
        Me.BTcreateacc.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(384, 136)
        Me.Panel1.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(-12, -58)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(396, 243)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(36, 235)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(36, 302)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(36, 368)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Confirm Password"
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 39
        Me.LineShape1.X2 = 318
        Me.LineShape1.Y1 = 213
        Me.LineShape1.Y2 = 213
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(382, 537)
        Me.ShapeContainer1.TabIndex = 14
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.LineShape4.BorderWidth = 2
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 39
        Me.LineShape4.X2 = 318
        Me.LineShape4.Y1 = 415
        Me.LineShape4.Y2 = 415
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.LineShape3.BorderWidth = 2
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 39
        Me.LineShape3.X2 = 318
        Me.LineShape3.Y1 = 350
        Me.LineShape3.Y2 = 350
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.LineShape2.BorderWidth = 2
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 39
        Me.LineShape2.X2 = 318
        Me.LineShape2.Y1 = 283
        Me.LineShape2.Y2 = 283
        '
        'LinkBack
        '
        Me.LinkBack.ActiveLinkColor = System.Drawing.Color.White
        Me.LinkBack.AutoSize = True
        Me.LinkBack.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkBack.LinkColor = System.Drawing.Color.DodgerBlue
        Me.LinkBack.Location = New System.Drawing.Point(12, 488)
        Me.LinkBack.Name = "LinkBack"
        Me.LinkBack.Size = New System.Drawing.Size(78, 23)
        Me.LinkBack.TabIndex = 15
        Me.LinkBack.TabStop = True
        Me.LinkBack.Text = "Go Back"
        '
        'lblerror
        '
        Me.lblerror.AutoSize = True
        Me.lblerror.BackColor = System.Drawing.Color.Transparent
        Me.lblerror.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblerror.ForeColor = System.Drawing.Color.Salmon
        Me.lblerror.Location = New System.Drawing.Point(36, 426)
        Me.lblerror.Name = "lblerror"
        Me.lblerror.Size = New System.Drawing.Size(46, 19)
        Me.lblerror.TabIndex = 16
        Me.lblerror.Text = "temp"
        '
        'lblsuccess
        '
        Me.lblsuccess.AutoSize = True
        Me.lblsuccess.BackColor = System.Drawing.Color.Transparent
        Me.lblsuccess.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsuccess.ForeColor = System.Drawing.Color.Cyan
        Me.lblsuccess.Location = New System.Drawing.Point(36, 426)
        Me.lblsuccess.Name = "lblsuccess"
        Me.lblsuccess.Size = New System.Drawing.Size(46, 19)
        Me.lblsuccess.TabIndex = 17
        Me.lblsuccess.Text = "temp"
        '
        'CreateAccForm
        '
        Me.AcceptButton = Me.BTcreateacc
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(382, 537)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblsuccess)
        Me.Controls.Add(Me.lblerror)
        Me.Controls.Add(Me.LinkBack)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BTcreateacc)
        Me.Controls.Add(Me.TxtCpass)
        Me.Controls.Add(Me.BankAccNum)
        Me.Controls.Add(Me.TxtPass)
        Me.Controls.Add(Me.TxtUser)
        Me.Controls.Add(Me.TxtBankAcc)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CreateAccForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BPN - Register"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtBankAcc As System.Windows.Forms.TextBox
    Friend WithEvents TxtUser As System.Windows.Forms.TextBox
    Friend WithEvents TxtPass As System.Windows.Forms.TextBox
    Friend WithEvents BankAccNum As System.Windows.Forms.Label
    Friend WithEvents TxtCpass As System.Windows.Forms.TextBox
    Friend WithEvents BTcreateacc As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LinkBack As System.Windows.Forms.LinkLabel
    Friend WithEvents lblerror As System.Windows.Forms.Label
    Friend WithEvents lblsuccess As System.Windows.Forms.Label
End Class
