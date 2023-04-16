Public Class BalFrm

    Public Property Balpass As Decimal

    Private Sub BalFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblBalance.Text = Balpass
    End Sub

    
    Private Sub bttnexit_Click(sender As Object, e As EventArgs) Handles bttnexit.Click
        Me.Close()

    End Sub
End Class