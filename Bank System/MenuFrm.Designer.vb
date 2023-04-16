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
        Me.Bttncheck = New System.Windows.Forms.Button()
        Me.bbtntransfer = New System.Windows.Forms.Button()
        Me.bttnBill = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.LblBankAccount = New System.Windows.Forms.Label()
        Me.Lblfname = New System.Windows.Forms.Label()
        Me.Lbllname = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bttncheck
        '
        Me.Bttncheck.Location = New System.Drawing.Point(42, 254)
        Me.Bttncheck.Name = "Bttncheck"
        Me.Bttncheck.Size = New System.Drawing.Size(171, 107)
        Me.Bttncheck.TabIndex = 0
        Me.Bttncheck.Text = "Check Balance"
        Me.Bttncheck.UseVisualStyleBackColor = True
        '
        'bbtntransfer
        '
        Me.bbtntransfer.Location = New System.Drawing.Point(297, 254)
        Me.bbtntransfer.Name = "bbtntransfer"
        Me.bbtntransfer.Size = New System.Drawing.Size(171, 107)
        Me.bbtntransfer.TabIndex = 1
        Me.bbtntransfer.Text = "Transfer Money to Another Account"
        Me.bbtntransfer.UseVisualStyleBackColor = True
        '
        'bttnBill
        '
        Me.bttnBill.Location = New System.Drawing.Point(42, 401)
        Me.bttnBill.Name = "bttnBill"
        Me.bttnBill.Size = New System.Drawing.Size(171, 107)
        Me.bttnBill.TabIndex = 2
        Me.bttnBill.Text = "Pay Bills"
        Me.bttnBill.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(297, 401)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(171, 107)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Show Transaction History"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(375, 147)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(93, 32)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Log out"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'LblBankAccount
        '
        Me.LblBankAccount.AutoSize = True
        Me.LblBankAccount.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBankAccount.Location = New System.Drawing.Point(36, 116)
        Me.LblBankAccount.Name = "LblBankAccount"
        Me.LblBankAccount.Size = New System.Drawing.Size(251, 35)
        Me.LblBankAccount.TabIndex = 5
        Me.LblBankAccount.Text = "Placeholder Bank No"
        '
        'Lblfname
        '
        Me.Lblfname.AutoSize = True
        Me.Lblfname.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblfname.Location = New System.Drawing.Point(38, 156)
        Me.Lblfname.Name = "Lblfname"
        Me.Lblfname.Size = New System.Drawing.Size(115, 23)
        Me.Lblfname.TabIndex = 6
        Me.Lblfname.Text = "FIRST NAME"
        '
        'Lbllname
        '
        Me.Lbllname.AutoSize = True
        Me.Lbllname.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbllname.Location = New System.Drawing.Point(38, 189)
        Me.Lbllname.Name = "Lbllname"
        Me.Lbllname.Size = New System.Drawing.Size(109, 23)
        Me.Lbllname.TabIndex = 8
        Me.Lbllname.Text = "LAST NAME"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(42, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 101)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'MenuFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 562)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Lbllname)
        Me.Controls.Add(Me.Lblfname)
        Me.Controls.Add(Me.LblBankAccount)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.bttnBill)
        Me.Controls.Add(Me.bbtntransfer)
        Me.Controls.Add(Me.Bttncheck)
        Me.Name = "MenuFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuFrm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bttncheck As System.Windows.Forms.Button
    Friend WithEvents bbtntransfer As System.Windows.Forms.Button
    Friend WithEvents bttnBill As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents LblBankAccount As System.Windows.Forms.Label
    Friend WithEvents Lblfname As System.Windows.Forms.Label
    Friend WithEvents Lbllname As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
