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

        Me.Lblfname.Text = ReadData.GetString(0).ToUpper
        Me.Lbllname.Text = ReadData.GetString(1).ToUpper



    End Sub

    Private Sub Bttncheck_Click(sender As Object, e As EventArgs) Handles Bttncheck.Click

        Dim BankAcc As String
        Dim Strread As String
        Dim CmdRead As DB2Command
        Dim ReadData As DB2DataReader
        Dim balance As Decimal


        BankAcc = Strpass
        Strread = "select amount from bankaccount where bankacctnum = '" & BankAcc & "'"
        CmdRead = New DB2Command(Strread, dbCon)
        ReadData = CmdRead.ExecuteReader
        ReadData.Read()

        balance = ReadData.GetDecimal(0)

        BalFrm.Balpass = balance
        BalFrm.Show()

        'Dim InsertStr As String
        'Dim CmdInsert As DB2Command
        'Dim transnum As Integer
        'Dim stringtransnum As String
        'Dim transread As String
        'Dim transtype As String
        'Dim checkdate As String

        'Randomize()

        'checkdate = String.Format("{0:dd-MM-yyyy}", DateTime.Now)
        'transtype = "Check.Bal"
        'transnum = CInt(Math.Floor((99999999 - 10000000 + 1) * Rnd())) + 10000000
        'stringtransnum = CStr(transnum)

        'transread = " select transactnum from transactions where transactnum = '" & transnum & "'"
        'CmdRead = New DB2Command(transread, dbCon)
        'ReadData = CmdRead.ExecuteReader
        'ReadData.Read()

        'If ReadData.HasRows Then
        'transread = ReadData.GetString(0)

        'While transread = stringtransnum
        'transnum = CInt(Math.Floor((99999999 - 1 + 1) * Rnd())) + 1
        'stringtransnum = CStr(transnum)
        'End While
        'InsertStr = "insert into transactions(transacttype,transactnum,transactdate,money,bankacctnum) values('" & transtype & "','" & stringtransnum & "','" & checkdate & "','" & balance & "','" & BankAcc & "')"
        'CmdInsert = New DB2Command(InsertStr, dbCon)
        'CmdInsert.ExecuteNonQuery()
        'Else
        'InsertStr = "insert into transactions(transacttype,transactnum,transactdate,money,bankacctnum) values('" & transtype & "','" & stringtransnum & "','" & checkdate & "','" & balance & "','" & BankAcc & "')"
        'CmdInsert = New DB2Command(InsertStr, dbCon)
        'CmdInsert.ExecuteNonQuery()

        'End If
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


    Private Sub bttntrans_Click(sender As Object, e As EventArgs) Handles bttntrans.Click
        Dim BankAcc As String
        BankAcc = Strpass
        TransactFrm.Bnkpass = BankAcc
        TransactFrm.Show()
        Me.Hide()
    End Sub

  

End Class
