Imports IBM.Data.DB2
Public Class TransactFrm

    Public Property Bnkpass As String

    Private dbCon As Common.DbConnection

    Private Sub TransactFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dbCon = New DB2Connection("server=localhost;database=banksys;" + "uid=db2admin;password=password;")
            dbCon.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try



        Dim BankAcc As String
        Dim Strread As String
        Dim CmdRead As DB2Command
        Dim ReadData As DB2DataReader
        Dim row As String()
        Dim DTmoney As String
        Dim DBilltype As String


        BankAcc = Bnkpass


        
        Strread = " select * from transactions where bankacctnum = '" & BankAcc & "'"
        CmdRead = New DB2Command(Strread, dbCon)
        ReadData = CmdRead.ExecuteReader
       


        DataGridView1.ColumnCount = 7
        With DataGridView1
            .Columns(0).Name = "Reference Number"
            .Columns(1).Name = "Transaction Type"
            .Columns(2).Name = "Transaction Date"
            .Columns(3).Name = "Bank Account Number"
            .Columns(4).Name = "Past Balance"
            .Columns(5).Name = "Transaction Money"
            .Columns(6).Name = "Bill Type"
        End With

        While ReadData.Read
            Try
                DTmoney = ReadData.GetDecimal(4).ToString

            Catch ex As Exception
                DTmoney = "-"
            End Try

            Try
                DBilltype = ReadData.GetString(6)

            Catch ex As Exception
                DBilltype = "-"
            End Try
            row = New String() {ReadData.GetString(1), ReadData.GetString(0), ReadData.GetString(2), ReadData.GetString(5), ReadData.GetDecimal(3), DTmoney, DBilltype}
            DataGridView1.Rows.Add(row)
        End While


    End Sub

    Private Sub bttnexit_Click(sender As Object, e As EventArgs) Handles bttnexit.Click
        Me.Close()
        MenuFrm.Show()
    End Sub
End Class