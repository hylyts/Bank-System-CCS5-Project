<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuFrm))
        Me.Bttncheck = New System.Windows.Forms.Button()
        Me.bbtntransfer = New System.Windows.Forms.Button()
        Me.bttnBill = New System.Windows.Forms.Button()
        Me.bttntrans = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.LblBankAccount = New System.Windows.Forms.Label()
        Me.Lblfname = New System.Windows.Forms.Label()
        Me.Lbllname = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bttncheck
        '
        Me.Bttncheck.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.Bttncheck.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.Bttncheck.FlatAppearance.BorderSize = 2
        Me.Bttncheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bttncheck.Font = New System.Drawing.Font("Bahnschrift", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bttncheck.ForeColor = System.Drawing.Color.White
        Me.Bttncheck.Location = New System.Drawing.Point(39, 337)
        Me.Bttncheck.Name = "Bttncheck"
        Me.Bttncheck.Size = New System.Drawing.Size(190, 114)
        Me.Bttncheck.TabIndex = 0
        Me.Bttncheck.Text = "CHECK BALANCE"
        Me.Bttncheck.UseVisualStyleBackColor = False
        '
        'bbtntransfer
        '
        Me.bbtntransfer.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.bbtntransfer.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.bbtntransfer.FlatAppearance.BorderSize = 2
        Me.bbtntransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bbtntransfer.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bbtntransfer.ForeColor = System.Drawing.Color.White
        Me.bbtntransfer.Location = New System.Drawing.Point(314, 337)
        Me.bbtntransfer.Name = "bbtntransfer"
        Me.bbtntransfer.Size = New System.Drawing.Size(202, 114)
        Me.bbtntransfer.TabIndex = 1
        Me.bbtntransfer.Text = "TRANSFER MONEY TO ANOTHER ACCOUNT"
        Me.bbtntransfer.UseVisualStyleBackColor = False
        '
        'bttnBill
        '
        Me.bttnBill.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.bttnBill.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.bttnBill.FlatAppearance.BorderSize = 2
        Me.bttnBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnBill.Font = New System.Drawing.Font("Bahnschrift", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnBill.ForeColor = System.Drawing.Color.White
        Me.bttnBill.Location = New System.Drawing.Point(39, 484)
        Me.bttnBill.Name = "bttnBill"
        Me.bttnBill.Size = New System.Drawing.Size(190, 114)
        Me.bttnBill.TabIndex = 2
        Me.bttnBill.Text = "PAY BILLS"
        Me.bttnBill.UseVisualStyleBackColor = False
        '
        'bttntrans
        '
        Me.bttntrans.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.bttntrans.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.bttntrans.FlatAppearance.BorderSize = 2
        Me.bttntrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttntrans.Font = New System.Drawing.Font("Bahnschrift", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttntrans.ForeColor = System.Drawing.Color.White
        Me.bttntrans.Location = New System.Drawing.Point(314, 484)
        Me.bttntrans.Name = "bttntrans"
        Me.bttntrans.Size = New System.Drawing.Size(202, 114)
        Me.bttntrans.TabIndex = 3
        Me.bttntrans.Text = "SHOW TRANSACTION HISTORY"
        Me.bttntrans.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button5.Location = New System.Drawing.Point(424, 27)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(136, 43)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "LOG OUT"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'LblBankAccount
        '
        Me.LblBankAccount.AutoSize = True
        Me.LblBankAccount.Font = New System.Drawing.Font("Bahnschrift", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBankAccount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.LblBankAccount.Location = New System.Drawing.Point(16, 104)
        Me.LblBankAccount.Name = "LblBankAccount"
        Me.LblBankAccount.Size = New System.Drawing.Size(250, 58)
        Me.LblBankAccount.TabIndex = 5
        Me.LblBankAccount.Text = "0000-0000"
        '
        'Lblfname
        '
        Me.Lblfname.AutoSize = True
        Me.Lblfname.Font = New System.Drawing.Font("Bahnschrift", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblfname.Location = New System.Drawing.Point(18, 189)
        Me.Lblfname.Name = "Lblfname"
        Me.Lblfname.Size = New System.Drawing.Size(164, 33)
        Me.Lblfname.TabIndex = 6
        Me.Lblfname.Text = "FIRST NAME"
        '
        'Lbllname
        '
        Me.Lbllname.AutoSize = True
        Me.Lbllname.Font = New System.Drawing.Font("Bahnschrift", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbllname.Location = New System.Drawing.Point(18, 246)
        Me.Lbllname.Name = "Lbllname"
        Me.Lbllname.Size = New System.Drawing.Size(156, 33)
        Me.Lbllname.TabIndex = 8
        Me.Lbllname.Text = "LAST NAME"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Lbllname)
        Me.Panel1.Controls.Add(Me.Lblfname)
        Me.Panel1.Controls.Add(Me.LblBankAccount)
        Me.Panel1.Controls.Add(Me.ShapeContainer1)
        Me.Panel1.Location = New System.Drawing.Point(-4, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(697, 291)
        Me.Panel1.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 14)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "BANK ACCOUNT No."
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Location = New System.Drawing.Point(0, -10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(587, 80)
        Me.Panel2.TabIndex = 13
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(-58, -14)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(272, 125)
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 232)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 14)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "LAST NAME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 14)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "FIRST NAME"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(353, 95)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(190, 182)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(697, 291)
        Me.ShapeContainer1.TabIndex = 12
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.LineShape1.BorderWidth = 4
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -2
        Me.LineShape1.X2 = 1191
        Me.LineShape1.Y1 = 80
        Me.LineShape1.Y2 = 78
        '
        'MenuFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(555, 633)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.bttntrans)
        Me.Controls.Add(Me.bttnBill)
        Me.Controls.Add(Me.bbtntransfer)
        Me.Controls.Add(Me.Bttncheck)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MenuFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BPN - Home"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Bttncheck As System.Windows.Forms.Button
    Friend WithEvents bbtntransfer As System.Windows.Forms.Button
    Friend WithEvents bttnBill As System.Windows.Forms.Button
    Friend WithEvents bttntrans As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents LblBankAccount As System.Windows.Forms.Label
    Friend WithEvents Lblfname As System.Windows.Forms.Label
    Friend WithEvents Lbllname As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
