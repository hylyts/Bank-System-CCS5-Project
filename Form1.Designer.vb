<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm1))
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.bttnlogin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LinkCreate = New System.Windows.Forms.LinkLabel()
        Me.bttnexit = New System.Windows.Forms.Button()
        Me.lblerror = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtusername
        '
        Me.txtusername.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtusername.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtusername.Location = New System.Drawing.Point(105, 254)
        Me.txtusername.MaxLength = 15
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(277, 23)
        Me.txtusername.TabIndex = 0
        Me.txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtpassword
        '
        Me.txtpassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpassword.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtpassword.Location = New System.Drawing.Point(105, 353)
        Me.txtpassword.MaxLength = 15
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(277, 23)
        Me.txtpassword.TabIndex = 1
        Me.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtpassword.UseSystemPasswordChar = True
        '
        'bttnlogin
        '
        Me.bttnlogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.bttnlogin.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.bttnlogin.FlatAppearance.BorderSize = 2
        Me.bttnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnlogin.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnlogin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.bttnlogin.Location = New System.Drawing.Point(103, 496)
        Me.bttnlogin.Name = "bttnlogin"
        Me.bttnlogin.Size = New System.Drawing.Size(280, 39)
        Me.bttnlogin.TabIndex = 2
        Me.bttnlogin.Text = "LOGIN"
        Me.bttnlogin.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(194, 204)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "USERNAME"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(194, 299)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "PASSWORD"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(-146, -102)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(774, 415)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, -8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(517, 199)
        Me.Panel1.TabIndex = 8
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(484, 605)
        Me.ShapeContainer1.TabIndex = 9
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.LineShape2.BorderWidth = 2
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 103
        Me.LineShape2.X2 = 382
        Me.LineShape2.Y1 = 384
        Me.LineShape2.Y2 = 384
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 103
        Me.LineShape1.X2 = 382
        Me.LineShape1.Y1 = 285
        Me.LineShape1.Y2 = 285
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(102, 391)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 18)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "No online account?"
        '
        'LinkCreate
        '
        Me.LinkCreate.ActiveLinkColor = System.Drawing.Color.White
        Me.LinkCreate.AutoSize = True
        Me.LinkCreate.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkCreate.LinkColor = System.Drawing.Color.DeepSkyBlue
        Me.LinkCreate.Location = New System.Drawing.Point(229, 390)
        Me.LinkCreate.Name = "LinkCreate"
        Me.LinkCreate.Size = New System.Drawing.Size(70, 19)
        Me.LinkCreate.TabIndex = 11
        Me.LinkCreate.TabStop = True
        Me.LinkCreate.Text = "Register"
        '
        'bttnexit
        '
        Me.bttnexit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bttnexit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bttnexit.FlatAppearance.BorderSize = 2
        Me.bttnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnexit.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnexit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bttnexit.Location = New System.Drawing.Point(103, 541)
        Me.bttnexit.Name = "bttnexit"
        Me.bttnexit.Size = New System.Drawing.Size(280, 39)
        Me.bttnexit.TabIndex = 12
        Me.bttnexit.Text = "EXIT"
        Me.bttnexit.UseVisualStyleBackColor = False
        '
        'lblerror
        '
        Me.lblerror.AutoSize = True
        Me.lblerror.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblerror.ForeColor = System.Drawing.Color.Salmon
        Me.lblerror.Location = New System.Drawing.Point(101, 433)
        Me.lblerror.Name = "lblerror"
        Me.lblerror.Size = New System.Drawing.Size(42, 18)
        Me.lblerror.TabIndex = 13
        Me.lblerror.Text = "temp"
        Me.lblerror.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm1
        '
        Me.AcceptButton = Me.bttnlogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(484, 605)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblerror)
        Me.Controls.Add(Me.bttnexit)
        Me.Controls.Add(Me.LinkCreate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bttnlogin)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BPN - Log in"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents bttnlogin As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LinkCreate As System.Windows.Forms.LinkLabel
    Friend WithEvents bttnexit As System.Windows.Forms.Button
    Friend WithEvents lblerror As System.Windows.Forms.Label

End Class
