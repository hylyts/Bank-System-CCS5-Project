Imports IBM.Data.DB2
Public Class MenuFrm

    Public Property Strpass As String

    Private dbCon As Common.DbConnection





    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        frm1.Show()
    End Sub


    Private Sub MenuFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dbCon = New DB2Connection("server=localhost;database=banksys;" + "uid=db2admin;password=password;")
            dbCon.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Me.LblBankAccount.Text = Strpass

        Dim BankAcc As String
        Dim Strread As String
        Dim CmdRead As DB2Command
        Dim ReadData As DB2DataReader

        BankAcc = Strpass

        Strread = "select fname, lname from bankaccount where bankacctnum = '" & BankAcc & "'"
        CmdRead = New DB2Command(Strread, dbCon)
        ReadData = CmdRead.ExecuteReader
        ReadData.Read()

        Me.Lblfname.Text = ReadData.GetString(0)
        Me.Lbllname.Text = ReadData.GetString(1)



    End Sub

    Private Sub Bttncheck_Click(sender As Object, e As EventArgs) Handles Bttncheck.Click

        Dim BankAcc As String
        Dim Strread As String
        Dim CmdRead As DB2Command
        Dim ReadData As DB2DataReader
        Dim balance As Decimal


        BankAcc = Strpass
        Strread = "select money from bankaccount where bankacctnum = '" & BankAcc & "'"
        CmdRead = New DB2Command(Strread, dbCon)
        ReadData = CmdRead.ExecuteReader
        ReadData.Read()

        balance = ReadData.GetDecimal(0)

        MsgBox(balance)



    End Sub

    Private Sub bbtntransfer_Click(sender As Object, e As EventArgs) Handles bbtntransfer.Click


        Dim BankAcc As String
        BankAcc = Strpass

        TransferFrm.Bnkpass = BankAcc
        TransferFrm.Show()
        Me.Hide()


    End Sub

  
    Private Sub bttnBill_Click(sender As Object, e As EventArgs) Handles bttnBill.Click

        Dim BankAcc As String
        BankAcc = Strpass

        BillFrm.Bnkpass = BankAcc
        BillFrm.Show()
        Me.Hide()
    End Sub
End Class