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
        Me.TxtBankAcc = New System.Windows.Forms.TextBox()
        Me.TxtUser = New System.Windows.Forms.TextBox()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.BankAccNum = New System.Windows.Forms.Label()
        Me.username = New System.Windows.Forms.Label()
        Me.pass = New System.Windows.Forms.Label()
        Me.cpass = New System.Windows.Forms.Label()
        Me.TxtCpass = New System.Windows.Forms.TextBox()
        Me.BTexit = New System.Windows.Forms.Button()
        Me.BTcreateacc = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtBankAcc
        '
        Me.TxtBankAcc.Location = New System.Drawing.Point(106, 50)
        Me.TxtBankAcc.MaxLength = 10
        Me.TxtBankAcc.Name = "TxtBankAcc"
        Me.TxtBankAcc.Size = New System.Drawing.Size(167, 20)
        Me.TxtBankAcc.TabIndex = 0
        '
        'TxtUser
        '
        Me.TxtUser.Location = New System.Drawing.Point(106, 119)
        Me.TxtUser.MaxLength = 15
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Size = New System.Drawing.Size(167, 20)
        Me.TxtUser.TabIndex = 1
        '
        'TxtPass
        '
        Me.TxtPass.Location = New System.Drawing.Point(106, 191)
        Me.TxtPass.MaxLength = 15
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.Size = New System.Drawing.Size(167, 20)
        Me.TxtPass.TabIndex = 2
        Me.TxtPass.UseSystemPasswordChar = True
        '
        'BankAccNum
        '
        Me.BankAccNum.AutoSize = True
        Me.BankAccNum.Location = New System.Drawing.Point(103, 34)
        Me.BankAccNum.Name = "BankAccNum"
        Me.BankAccNum.Size = New System.Drawing.Size(115, 13)
        Me.BankAccNum.TabIndex = 3
        Me.BankAccNum.Text = "Bank Account Number"
        '
        'username
        '
        Me.username.AutoSize = True
        Me.username.Location = New System.Drawing.Point(103, 103)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(55, 13)
        Me.username.TabIndex = 4
        Me.username.Text = "Username"
        '
        'pass
        '
        Me.pass.AutoSize = True
        Me.pass.Location = New System.Drawing.Point(103, 170)
        Me.pass.Name = "pass"
        Me.pass.Size = New System.Drawing.Size(53, 13)
        Me.pass.TabIndex = 5
        Me.pass.Text = "Password"
        '
        'cpass
        '
        Me.cpass.AutoSize = True
        Me.cpass.Location = New System.Drawing.Point(103, 236)
        Me.cpass.Name = "cpass"
        Me.cpass.Size = New System.Drawing.Size(91, 13)
        Me.cpass.TabIndex = 7
        Me.cpass.Text = "Confirm Password"
        '
        'TxtCpass
        '
        Me.TxtCpass.Location = New System.Drawing.Point(106, 252)
        Me.TxtCpass.MaxLength = 15
        Me.TxtCpass.Name = "TxtCpass"
        Me.TxtCpass.Size = New System.Drawing.Size(167, 20)
        Me.TxtCpass.TabIndex = 6
        Me.TxtCpass.UseSystemPasswordChar = True
        '
        'BTexit
        '
        Me.BTexit.Location = New System.Drawing.Point(12, 337)
        Me.BTexit.Name = "BTexit"
        Me.BTexit.Size = New System.Drawing.Size(103, 69)
        Me.BTexit.TabIndex = 9
        Me.BTexit.Text = "Exit"
        Me.BTexit.UseVisualStyleBackColor = True
        '
        'BTcreateacc
        '
        Me.BTcreateacc.Location = New System.Drawing.Point(275, 337)
        Me.BTcreateacc.Name = "BTcreateacc"
        Me.BTcreateacc.Size = New System.Drawing.Size(95, 69)
        Me.BTcreateacc.TabIndex = 8
        Me.BTcreateacc.Text = "Register Account"
        Me.BTcreateacc.UseVisualStyleBackColor = True
        '
        'CreateAccForm
        '
        Me.AcceptButton = Me.BTcreateacc
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 418)
        Me.ControlBox = False
        Me.Controls.Add(Me.BTexit)
        Me.Controls.Add(Me.BTcreateacc)
        Me.Controls.Add(Me.cpass)
        Me.Controls.Add(Me.TxtCpass)
        Me.Controls.Add(Me.pass)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.BankAccNum)
        Me.Controls.Add(Me.TxtPass)
        Me.Controls.Add(Me.TxtUser)
        Me.Controls.Add(Me.TxtBankAcc)
        Me.Name = "CreateAccForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CreateAccForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtBankAcc As System.Windows.Forms.TextBox
    Friend WithEvents TxtUser As System.Windows.Forms.TextBox
    Friend WithEvents TxtPass As System.Windows.Forms.TextBox
    Friend WithEvents BankAccNum As System.Windows.Forms.Label
    Friend WithEvents username As System.Windows.Forms.Label
    Friend WithEvents pass As System.Windows.Forms.Label
    Friend WithEvents cpass As System.Windows.Forms.Label
    Friend WithEvents TxtCpass As System.Windows.Forms.TextBox
    Friend WithEvents BTexit As System.Windows.Forms.Button
    Friend WithEvents BTcreateacc As System.Windows.Forms.Button
End Class
