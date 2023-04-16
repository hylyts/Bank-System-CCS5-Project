<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BillFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BillFrm))
        Me.bttnelec = New System.Windows.Forms.Button()
        Me.bttnwater = New System.Windows.Forms.Button()
        Me.bttninsure = New System.Windows.Forms.Button()
        Me.bttnexit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bttnelec
        '
        Me.bttnelec.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.bttnelec.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.bttnelec.FlatAppearance.BorderSize = 2
        Me.bttnelec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnelec.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnelec.ForeColor = System.Drawing.Color.White
        Me.bttnelec.Location = New System.Drawing.Point(339, 139)
        Me.bttnelec.Name = "bttnelec"
        Me.bttnelec.Size = New System.Drawing.Size(251, 75)
        Me.bttnelec.TabIndex = 0
        Me.bttnelec.Text = "Pay for Electricity Bills"
        Me.bttnelec.UseVisualStyleBackColor = False
        '
        'bttnwater
        '
        Me.bttnwater.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.bttnwater.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.bttnwater.FlatAppearance.BorderSize = 2
        Me.bttnwater.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnwater.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnwater.ForeColor = System.Drawing.Color.White
        Me.bttnwater.Location = New System.Drawing.Point(339, 288)
        Me.bttnwater.Name = "bttnwater"
        Me.bttnwater.Size = New System.Drawing.Size(251, 75)
        Me.bttnwater.TabIndex = 1
        Me.bttnwater.Text = "Pay for Water Bills"
        Me.bttnwater.UseVisualStyleBackColor = False
        '
        'bttninsure
        '
        Me.bttninsure.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.bttninsure.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.bttninsure.FlatAppearance.BorderSize = 2
        Me.bttninsure.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttninsure.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttninsure.ForeColor = System.Drawing.Color.White
        Me.bttninsure.Location = New System.Drawing.Point(339, 430)
        Me.bttninsure.Name = "bttninsure"
        Me.bttninsure.Size = New System.Drawing.Size(251, 75)
        Me.bttninsure.TabIndex = 2
        Me.bttninsure.Text = "Pay for Insurance"
        Me.bttninsure.UseVisualStyleBackColor = False
        '
        'bttnexit
        '
        Me.bttnexit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bttnexit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bttnexit.FlatAppearance.BorderSize = 2
        Me.bttnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnexit.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnexit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bttnexit.Location = New System.Drawing.Point(3, 16)
        Me.bttnexit.Name = "bttnexit"
        Me.bttnexit.Size = New System.Drawing.Size(129, 47)
        Me.bttnexit.TabIndex = 3
        Me.bttnexit.Text = "Go back"
        Me.bttnexit.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Location = New System.Drawing.Point(-3, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(301, 565)
        Me.Panel1.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Location = New System.Drawing.Point(31, 275)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(246, 100)
        Me.Panel4.TabIndex = 11
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(25, -10)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(192, 128)
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.Controls.Add(Me.PictureBox4)
        Me.Panel5.Location = New System.Drawing.Point(31, 420)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(246, 100)
        Me.Panel5.TabIndex = 11
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox4.Location = New System.Drawing.Point(-85, -59)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(418, 224)
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Location = New System.Drawing.Point(31, 123)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(246, 100)
        Me.Panel3.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(-129, -75)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(506, 263)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(92, 443)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.PictureBox5)
        Me.Panel2.Controls.Add(Me.bttnexit)
        Me.Panel2.Location = New System.Drawing.Point(-3, 572)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(648, 82)
        Me.Panel2.TabIndex = 5
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox5.Location = New System.Drawing.Point(421, -26)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(253, 126)
        Me.PictureBox5.TabIndex = 4
        Me.PictureBox5.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.LineShape1.BorderWidth = 4
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -275
        Me.LineShape1.X2 = 918
        Me.LineShape1.Y1 = 544
        Me.LineShape1.Y2 = 542
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer2.Size = New System.Drawing.Size(626, 655)
        Me.ShapeContainer2.TabIndex = 6
        Me.ShapeContainer2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label1.Location = New System.Drawing.Point(338, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 29)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Select A Billing to Pay."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BillFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(626, 655)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.bttninsure)
        Me.Controls.Add(Me.bttnwater)
        Me.Controls.Add(Me.bttnelec)
        Me.Controls.Add(Me.ShapeContainer2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BillFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BPN - Bill Type"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bttnelec As System.Windows.Forms.Button
    Friend WithEvents bttnwater As System.Windows.Forms.Button
    Friend WithEvents bttninsure As System.Windows.Forms.Button
    Friend WithEvents bttnexit As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
