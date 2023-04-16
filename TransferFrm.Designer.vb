<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransferFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransferFrm))
        Me.TxtSendacc = New System.Windows.Forms.TextBox()
        Me.MoneyBox = New System.Windows.Forms.NumericUpDown()
        Me.BttnSend = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Linkexit = New System.Windows.Forms.LinkLabel()
        Me.lblerror = New System.Windows.Forms.Label()
        Me.lblsuccess = New System.Windows.Forms.Label()
        CType(Me.MoneyBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtSendacc
        '
        Me.TxtSendacc.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.TxtSendacc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtSendacc.Font = New System.Drawing.Font("Bahnschrift", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSendacc.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TxtSendacc.Location = New System.Drawing.Point(28, 129)
        Me.TxtSendacc.Name = "TxtSendacc"
        Me.TxtSendacc.Size = New System.Drawing.Size(368, 43)
        Me.TxtSendacc.TabIndex = 1
        '
        'MoneyBox
        '
        Me.MoneyBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.MoneyBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MoneyBox.DecimalPlaces = 2
        Me.MoneyBox.Font = New System.Drawing.Font("Bahnschrift", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MoneyBox.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.MoneyBox.InterceptArrowKeys = False
        Me.MoneyBox.Location = New System.Drawing.Point(24, 237)
        Me.MoneyBox.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.MoneyBox.Name = "MoneyBox"
        Me.MoneyBox.Size = New System.Drawing.Size(591, 46)
        Me.MoneyBox.TabIndex = 2
        Me.MoneyBox.ThousandsSeparator = True
        '
        'BttnSend
        '
        Me.BttnSend.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.BttnSend.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.BttnSend.FlatAppearance.BorderSize = 2
        Me.BttnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BttnSend.Font = New System.Drawing.Font("Bahnschrift", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttnSend.ForeColor = System.Drawing.Color.White
        Me.BttnSend.Location = New System.Drawing.Point(289, 388)
        Me.BttnSend.Name = "BttnSend"
        Me.BttnSend.Size = New System.Drawing.Size(143, 47)
        Me.BttnSend.TabIndex = 3
        Me.BttnSend.Text = "SUBMIT"
        Me.BttnSend.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label1.Location = New System.Drawing.Point(24, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(372, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Enter Bank Account Number to Transfer to."
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 26
        Me.LineShape1.X2 = 404
        Me.LineShape1.Y1 = 180
        Me.LineShape1.Y2 = 180
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(462, 458)
        Me.ShapeContainer1.TabIndex = 7
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.LineShape2.BorderWidth = 2
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 24
        Me.LineShape2.X2 = 402
        Me.LineShape2.Y1 = 291
        Me.LineShape2.Y2 = 291
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label3.Location = New System.Drawing.Point(20, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(227, 23)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Enter Amount to Transfer."
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(-12, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(597, 88)
        Me.Panel2.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(-74, -25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(319, 136)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Linkexit
        '
        Me.Linkexit.ActiveLinkColor = System.Drawing.Color.White
        Me.Linkexit.AutoSize = True
        Me.Linkexit.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Linkexit.LinkColor = System.Drawing.Color.DeepSkyBlue
        Me.Linkexit.Location = New System.Drawing.Point(23, 410)
        Me.Linkexit.Name = "Linkexit"
        Me.Linkexit.Size = New System.Drawing.Size(89, 25)
        Me.Linkexit.TabIndex = 11
        Me.Linkexit.TabStop = True
        Me.Linkexit.Text = "Go Back"
        '
        'lblerror
        '
        Me.lblerror.AutoSize = True
        Me.lblerror.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblerror.ForeColor = System.Drawing.Color.Salmon
        Me.lblerror.Location = New System.Drawing.Point(24, 316)
        Me.lblerror.Name = "lblerror"
        Me.lblerror.Size = New System.Drawing.Size(61, 25)
        Me.lblerror.TabIndex = 12
        Me.lblerror.Text = "Temp"
        '
        'lblsuccess
        '
        Me.lblsuccess.AutoSize = True
        Me.lblsuccess.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsuccess.ForeColor = System.Drawing.Color.Cyan
        Me.lblsuccess.Location = New System.Drawing.Point(24, 316)
        Me.lblsuccess.Name = "lblsuccess"
        Me.lblsuccess.Size = New System.Drawing.Size(61, 25)
        Me.lblsuccess.TabIndex = 13
        Me.lblsuccess.Text = "Temp"
        '
        'TransferFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(462, 458)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblsuccess)
        Me.Controls.Add(Me.lblerror)
        Me.Controls.Add(Me.Linkexit)
        Me.Controls.Add(Me.BttnSend)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MoneyBox)
        Me.Controls.Add(Me.TxtSendacc)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TransferFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BPN - Transfer Money"
        CType(Me.MoneyBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtSendacc As System.Windows.Forms.TextBox
    Public WithEvents MoneyBox As System.Windows.Forms.NumericUpDown
    Friend WithEvents BttnSend As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Linkexit As System.Windows.Forms.LinkLabel
    Friend WithEvents lblerror As System.Windows.Forms.Label
    Friend WithEvents lblsuccess As System.Windows.Forms.Label
End Class
