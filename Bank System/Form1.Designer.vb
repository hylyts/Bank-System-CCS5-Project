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
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.bttnlogin = New System.Windows.Forms.Button()
        Me.bttnexit = New System.Windows.Forms.Button()
        Me.bttncreate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(105, 210)
        Me.txtusername.MaxLength = 15
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(277, 20)
        Me.txtusername.TabIndex = 0
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(105, 285)
        Me.txtpassword.MaxLength = 15
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(277, 20)
        Me.txtpassword.TabIndex = 1
        Me.txtpassword.UseSystemPasswordChar = True
        '
        'bttnlogin
        '
        Me.bttnlogin.Location = New System.Drawing.Point(307, 357)
        Me.bttnlogin.Name = "bttnlogin"
        Me.bttnlogin.Size = New System.Drawing.Size(75, 23)
        Me.bttnlogin.TabIndex = 2
        Me.bttnlogin.Text = "Log In"
        Me.bttnlogin.UseVisualStyleBackColor = True
        '
        'bttnexit
        '
        Me.bttnexit.Location = New System.Drawing.Point(200, 415)
        Me.bttnexit.Name = "bttnexit"
        Me.bttnexit.Size = New System.Drawing.Size(75, 23)
        Me.bttnexit.TabIndex = 3
        Me.bttnexit.Text = "Exit Program"
        Me.bttnexit.UseVisualStyleBackColor = True
        '
        'bttncreate
        '
        Me.bttncreate.Location = New System.Drawing.Point(105, 357)
        Me.bttncreate.Name = "bttncreate"
        Me.bttncreate.Size = New System.Drawing.Size(96, 23)
        Me.bttncreate.TabIndex = 4
        Me.bttncreate.Text = "Create Account"
        Me.bttncreate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(102, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(102, 269)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "password"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(150, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(189, 153)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'frm1
        '
        Me.AcceptButton = Me.bttnlogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 507)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bttncreate)
        Me.Controls.Add(Me.bttnexit)
        Me.Controls.Add(Me.bttnlogin)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtusername)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frm1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Legit Bank - Log In"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents bttnlogin As System.Windows.Forms.Button
    Friend WithEvents bttnexit As System.Windows.Forms.Button
    Friend WithEvents bttncreate As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
