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
        Me.TxtSendacc = New System.Windows.Forms.TextBox()
        Me.MoneyBox = New System.Windows.Forms.NumericUpDown()
        Me.BttnSend = New System.Windows.Forms.Button()
        Me.BttnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.MoneyBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtSendacc
        '
        Me.TxtSendacc.Location = New System.Drawing.Point(50, 111)
        Me.TxtSendacc.Name = "TxtSendacc"
        Me.TxtSendacc.Size = New System.Drawing.Size(259, 20)
        Me.TxtSendacc.TabIndex = 1
        '
        'MoneyBox
        '
        Me.MoneyBox.DecimalPlaces = 2
        Me.MoneyBox.InterceptArrowKeys = False
        Me.MoneyBox.Location = New System.Drawing.Point(50, 207)
        Me.MoneyBox.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.MoneyBox.Name = "MoneyBox"
        Me.MoneyBox.Size = New System.Drawing.Size(259, 20)
        Me.MoneyBox.TabIndex = 2
        Me.MoneyBox.ThousandsSeparator = True
        '
        'BttnSend
        '
        Me.BttnSend.Location = New System.Drawing.Point(79, 286)
        Me.BttnSend.Name = "BttnSend"
        Me.BttnSend.Size = New System.Drawing.Size(75, 23)
        Me.BttnSend.TabIndex = 3
        Me.BttnSend.Text = "Proceed"
        Me.BttnSend.UseVisualStyleBackColor = True
        '
        'BttnExit
        '
        Me.BttnExit.Location = New System.Drawing.Point(196, 286)
        Me.BttnExit.Name = "BttnExit"
        Me.BttnExit.Size = New System.Drawing.Size(75, 23)
        Me.BttnExit.TabIndex = 4
        Me.BttnExit.Text = "Go Back"
        Me.BttnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Enter Bank Account Number to Transfer to"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Enter Amount to Transfer"
        '
        'TransferFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 372)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BttnExit)
        Me.Controls.Add(Me.BttnSend)
        Me.Controls.Add(Me.MoneyBox)
        Me.Controls.Add(Me.TxtSendacc)
        Me.Name = "TransferFrm"
        Me.Text = "TransferFrm"
        CType(Me.MoneyBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtSendacc As System.Windows.Forms.TextBox
    Public WithEvents MoneyBox As System.Windows.Forms.NumericUpDown
    Friend WithEvents BttnSend As System.Windows.Forms.Button
    Friend WithEvents BttnExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
