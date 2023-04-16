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
        Me.bttnelec = New System.Windows.Forms.Button()
        Me.bttnwater = New System.Windows.Forms.Button()
        Me.bttninsure = New System.Windows.Forms.Button()
        Me.bttnexit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bttnelec
        '
        Me.bttnelec.Location = New System.Drawing.Point(318, 110)
        Me.bttnelec.Name = "bttnelec"
        Me.bttnelec.Size = New System.Drawing.Size(251, 75)
        Me.bttnelec.TabIndex = 0
        Me.bttnelec.Text = "Pay for Electricity Bills"
        Me.bttnelec.UseVisualStyleBackColor = True
        '
        'bttnwater
        '
        Me.bttnwater.Location = New System.Drawing.Point(318, 260)
        Me.bttnwater.Name = "bttnwater"
        Me.bttnwater.Size = New System.Drawing.Size(251, 75)
        Me.bttnwater.TabIndex = 1
        Me.bttnwater.Text = "Pay for Water Bills"
        Me.bttnwater.UseVisualStyleBackColor = True
        '
        'bttninsure
        '
        Me.bttninsure.Location = New System.Drawing.Point(318, 427)
        Me.bttninsure.Name = "bttninsure"
        Me.bttninsure.Size = New System.Drawing.Size(251, 75)
        Me.bttninsure.TabIndex = 2
        Me.bttninsure.Text = "Pay for Insurance"
        Me.bttninsure.UseVisualStyleBackColor = True
        '
        'bttnexit
        '
        Me.bttnexit.Location = New System.Drawing.Point(28, 604)
        Me.bttnexit.Name = "bttnexit"
        Me.bttnexit.Size = New System.Drawing.Size(161, 60)
        Me.bttnexit.TabIndex = 3
        Me.bttnexit.Text = "Go back"
        Me.bttnexit.UseVisualStyleBackColor = True
        '
        'BillFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 686)
        Me.ControlBox = False
        Me.Controls.Add(Me.bttnexit)
        Me.Controls.Add(Me.bttninsure)
        Me.Controls.Add(Me.bttnwater)
        Me.Controls.Add(Me.bttnelec)
        Me.Name = "BillFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BillFrm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bttnelec As System.Windows.Forms.Button
    Friend WithEvents bttnwater As System.Windows.Forms.Button
    Friend WithEvents bttninsure As System.Windows.Forms.Button
    Friend WithEvents bttnexit As System.Windows.Forms.Button
End Class
