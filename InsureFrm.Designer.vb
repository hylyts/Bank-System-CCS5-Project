<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InsureFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InsureFrm))
        Me.bttn1month = New System.Windows.Forms.Button()
        Me.bttnQyear = New System.Windows.Forms.Button()
        Me.bttnYear = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.lblsuccess = New System.Windows.Forms.Label()
        Me.bttnexit = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bttn1month
        '
        Me.bttn1month.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.bttn1month.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.bttn1month.FlatAppearance.BorderSize = 2
        Me.bttn1month.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttn1month.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttn1month.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.bttn1month.Location = New System.Drawing.Point(111, 385)
        Me.bttn1month.Name = "bttn1month"
        Me.bttn1month.Size = New System.Drawing.Size(168, 57)
        Me.bttn1month.TabIndex = 0
        Me.bttn1month.Text = "Pay for 1 Month"
        Me.bttn1month.UseVisualStyleBackColor = False
        '
        'bttnQyear
        '
        Me.bttnQyear.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.bttnQyear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.bttnQyear.FlatAppearance.BorderSize = 2
        Me.bttnQyear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnQyear.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnQyear.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.bttnQyear.Location = New System.Drawing.Point(111, 460)
        Me.bttnQyear.Name = "bttnQyear"
        Me.bttnQyear.Size = New System.Drawing.Size(168, 57)
        Me.bttnQyear.TabIndex = 1
        Me.bttnQyear.Text = "Pay for Quarter Year"
        Me.bttnQyear.UseVisualStyleBackColor = False
        '
        'bttnYear
        '
        Me.bttnYear.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.bttnYear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.bttnYear.FlatAppearance.BorderSize = 2
        Me.bttnYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnYear.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnYear.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.bttnYear.Location = New System.Drawing.Point(111, 541)
        Me.bttnYear.Name = "bttnYear"
        Me.bttnYear.Size = New System.Drawing.Size(168, 57)
        Me.bttnYear.TabIndex = 2
        Me.bttnYear.Text = "Pay for Whole Year"
        Me.bttnYear.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(438, 50)
        Me.Panel1.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(-22, -12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(142, 76)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Location = New System.Drawing.Point(1, 56)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(395, 110)
        Me.Panel2.TabIndex = 7
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(-34, -79)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(460, 279)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(108, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 50)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Your Monthly Bill" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for Insurance:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label2.Location = New System.Drawing.Point(145, 241)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 58)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "300"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 58
        Me.LineShape1.X2 = 337
        Me.LineShape1.Y1 = 301
        Me.LineShape1.Y2 = 301
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(395, 680)
        Me.ShapeContainer1.TabIndex = 10
        Me.ShapeContainer1.TabStop = False
        '
        'lblsuccess
        '
        Me.lblsuccess.AutoSize = True
        Me.lblsuccess.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsuccess.ForeColor = System.Drawing.Color.Cyan
        Me.lblsuccess.Location = New System.Drawing.Point(104, 310)
        Me.lblsuccess.Name = "lblsuccess"
        Me.lblsuccess.Size = New System.Drawing.Size(175, 23)
        Me.lblsuccess.TabIndex = 11
        Me.lblsuccess.Text = "Successfully Payed"
        Me.lblsuccess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bttnexit
        '
        Me.bttnexit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bttnexit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bttnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnexit.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnexit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.bttnexit.Location = New System.Drawing.Point(-9, 635)
        Me.bttnexit.Name = "bttnexit"
        Me.bttnexit.Size = New System.Drawing.Size(111, 33)
        Me.bttnexit.TabIndex = 12
        Me.bttnexit.Text = "Go Back"
        Me.bttnexit.UseVisualStyleBackColor = False
        '
        'InsureFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(395, 680)
        Me.ControlBox = False
        Me.Controls.Add(Me.bttnexit)
        Me.Controls.Add(Me.lblsuccess)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.bttnYear)
        Me.Controls.Add(Me.bttnQyear)
        Me.Controls.Add(Me.bttn1month)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "InsureFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BPN - Insurance Bill"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bttn1month As System.Windows.Forms.Button
    Friend WithEvents bttnQyear As System.Windows.Forms.Button
    Friend WithEvents bttnYear As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents lblsuccess As System.Windows.Forms.Label
    Friend WithEvents bttnexit As System.Windows.Forms.Button
End Class
