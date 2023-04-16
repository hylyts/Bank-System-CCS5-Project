Imports IBM.Data.DB2

Public Class BillFrm


    Public Property Bnkpass As String

    Private dbCon As Common.DbConnection


    Private Sub BillFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dbCon = New DB2Connection("server=localhost;database=banksys;" + "uid=db2admin;password=password;")
            dbCon.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub bttnexit_Click(sender As Object, e As EventArgs) Handles bttnexit.Click
        MenuFrm.Show()
        Me.Close()

    End Sub

    Private Sub bttnelec_Click(sender As Object, e As EventArgs) Handles bttnelec.Click

        Dim BankAcc As String
        BankAcc = Bnkpass
        ElecFrm.Bnkpass = BankAcc
        ElecFrm.Show()
        Me.Hide()

    End Sub

    Private Sub bttnwater_Click(sender As Object, e As EventArgs) Handles bttnwater.Click

        Dim BankAcc As String
        BankAcc = Bnkpass
        WaterFrm.Bnkpass = BankAcc
        WaterFrm.Show()
        Me.Hide()

    End Sub

    Private Sub bttninsure_Click(sender As Object, e As EventArgs) Handles bttninsure.Click
        Dim BankAcc As String
        BankAcc = Bnkpass
        InsureFrm.Bnkpass = BankAcc
        InsureFrm.Show()
        Me.Hide()
    End Sub

End Class