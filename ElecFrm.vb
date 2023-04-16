Imports IBM.Data.DB2

Public Class ElecFrm

    Public Property Bnkpass As String
    Public Property Bill As Decimal

    Private dbCon As Common.DbConnection

    Private Sub bttnexit_Click(sender As Object, e As EventArgs) Handles bttnexit.Click
        Me.Hide()
        BillFrm.Show()

    End Sub

    Private Sub ElecFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dbCon = New DB2Connection("server=localhost;database=banksys;" + "uid=db2admin;password=password;")
            dbCon.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Dim elecbill As Decimal

        Randomize()

        elecbill = CInt(Math.Floor((1500 - 1000 + 1) * Rnd())) + 1000

        Me.Label2.Text = elecbill + 0.0

        Bill = elecbill + 0.0

        Me.lblsuccess.Text = ""
    End Sub

    Private Sub bttnpay_Click(sender As Object, e As EventArgs) Handles bttnpay.Click

        Dim MainAcc As String
        Dim payread As String
        Dim CmdRead As DB2Command
        Dim ReadData As DB2DataReader
        Dim balance As Decimal
        Dim balupdate As String
        Dim ElecAcc As String
        Dim ElecBill As Decimal
        Dim elecread As String
        Dim elecupdate As String


        MainAcc = Bnkpass

        payread = "select amount from bankaccount where bankacctnum = '" & MainAcc & "'"
        CmdRead = New DB2Command(payread, dbCon)
        ReadData = CmdRead.ExecuteReader
        ReadData.Read()

        balance = ReadData.GetDecimal(0)

        balance = balance - Bill

        balupdate = "update bankaccount set amount = '" & balance & "' where  bankacctnum = '" & MainAcc & "'"
        CmdRead = New DB2Command(balupdate, dbCon)
        CmdRead.ExecuteNonQuery()

        elecread = "select billacctnum from billers where billname = 'Moreco II' "
        CmdRead = New DB2Command(elecread, dbCon)
        ReadData = CmdRead.ExecuteReader
        ReadData.Read()

        ElecAcc = ReadData.GetString(0)

        elecread = "select amount from bankaccount where bankacctnum = '" & ElecAcc & "'"
        CmdRead = New DB2Command(elecread, dbCon)
        ReadData = CmdRead.ExecuteReader
        ReadData.Read()

        ElecBill = ReadData.GetDecimal(0)

        ElecBill = ElecBill + Bill

        elecupdate = "update bankaccount set amount = '" & ElecBill & "' where bankacctnum = '" & ElecAcc & "' "
        CmdRead = New DB2Command(elecupdate, dbCon)
        CmdRead.ExecuteNonQuery()

        Me.lblsuccess.Text = "Bill Successfully Payed"

        bttnpay.Enabled = False

        Dim InsertStr As String
        Dim CmdInsert As DB2Command
        Dim transnum As Integer
        Dim stringtransnum As String
        Dim transread As String
        Dim transtype As String
        Dim billtype As String
        Dim checkdate As String

        Randomize()

        checkdate = String.Format("{0:dd-MM-yyyy}", DateTime.Now)
        transtype = "Bill.Payment"
        billtype = "Moreco II"
        transnum = CInt(Math.Floor((99999999 - 10000000 + 1) * Rnd())) + 10000000
        stringtransnum = CStr(transnum)

        transread = " select transactnum from transactions where transactnum = '" & transnum & "'"
        CmdRead = New DB2Command(transread, dbCon)
        ReadData = CmdRead.ExecuteReader
        ReadData.Read()

        If ReadData.HasRows Then
            transread = ReadData.GetString(0)

            While transread = stringtransnum
                transnum = CInt(Math.Floor((99999999 - 1 + 1) * Rnd())) + 1
                stringtransnum = CStr(transnum)
            End While
            InsertStr = "insert into transactions values('" & stringtransnum & "','" & transtype & "','" & checkdate & "','" & balance & "','" & Bill & "','" & MainAcc & "','" & billtype & "')"
            CmdInsert = New DB2Command(InsertStr, dbCon)
            CmdInsert.ExecuteNonQuery()
        Else
            InsertStr = "insert into transactions values('" & stringtransnum & "','" & transtype & "','" & checkdate & "','" & balance & "','" & Bill & "','" & MainAcc & "','" & billtype & "')"
            CmdInsert = New DB2Command(InsertStr, dbCon)
            CmdInsert.ExecuteNonQuery()

        End If


    End Sub

 
End Class