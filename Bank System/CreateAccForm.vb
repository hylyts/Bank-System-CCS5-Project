Imports IBM.Data.DB2
Public Class CreateAccForm
    Private dbCon As Common.DbConnection

    Private Sub CreateAccForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dbCon = New DB2Connection("server=localhost;database=banksys;" + "uid=db2admin;password=password;")
            dbCon.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BTexit_Click(sender As Object, e As EventArgs) Handles BTexit.Click
        Me.Close()
    End Sub

    Private Sub BTcreateacc_Click(sender As Object, e As EventArgs) Handles BTcreateacc.Click
        Try
            Dim BankAcc As String
            Dim Uname As String
            Dim Pass As String
            Dim Cpass As String
            Dim InsertStr As String
            Dim Strread As String
            Dim CmdInsert As DB2Command
            Dim CmdRead As DB2Command
            Dim ReadData As DB2DataReader
            Dim bankcomp As String

            BankAcc = Me.TxtBankAcc.Text
            Uname = Me.TxtUser.Text
            Pass = Me.TxtPass.Text
            Cpass = Me.TxtCpass.Text


            If Pass <> Cpass Then
                MsgBox("Password confirmation does not match")

            Else
                Strread = "select bankacctnum from bankaccount where bankacctnum = '" & BankAcc & "'"
                CmdRead = New DB2Command(Strread, dbCon)
                ReadData = CmdRead.ExecuteReader
                ReadData.Read()

                bankcomp = ReadData.GetString(0)

                InsertStr = "insert into onlineaccount values('" & BankAcc & "','" & Uname & "','" & Pass & "')"
                CmdInsert = New DB2Command(InsertStr, dbCon)
                CmdInsert.ExecuteNonQuery()

                MsgBox("Online Account has Succesfully Created")
                Me.Hide()

                Call ClearEntry()

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub ClearEntry()
        Me.TxtBankAcc.Clear()
        Me.TxtUser.Clear()
        Me.TxtPass.Clear()
        Me.TxtCpass.Clear()

        Me.TxtBankAcc.Focus()
    End Sub

End Class