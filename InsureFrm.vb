Imports IBM.Data.DB2
Public Class InsureFrm
    Public Property Bnkpass As String

    Private dbCon As Common.DbConnection

    Private Sub InsureFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dbCon = New DB2Connection("server=localhost;database=banksys;" + "uid=db2admin;password=password;")
            dbCon.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Me.lblsuccess.Text = ""
    End Sub

  

    
    Private Sub bttn1month_Click(sender As Object, e As EventArgs) Handles bttn1month.Click
        Dim MainAcc As String
        Dim payread As String
        Dim CmdRead As DB2Command
        Dim ReadData As DB2DataReader
        Dim balance As Decimal
        Dim balupdate As String
        Dim insread As String
        Dim insupdate As String
        Dim InsAcc As String
        Dim InsBill As Decimal




        MainAcc = Bnkpass

        payread = "select amount from bankaccount where bankacctnum = '" & MainAcc & "'"
        CmdRead = New DB2Command(payread, dbCon)
        ReadData = CmdRead.ExecuteReader
        ReadData.Read()

        balance = ReadData.GetDecimal(0)

        balance = balance - 300

        balupdate = "update bankaccount set amount = '" & balance & "' where  bankacctnum = '" & MainAcc & "'"
        CmdRead = New DB2Command(balupdate, dbCon)
        CmdRead.ExecuteNonQuery()

        insread = "select billacctnum from billers where billname = 'BillHelth' "
        CmdRead = New DB2Command(insread, dbCon)
        ReadData = CmdRead.ExecuteReader
        ReadData.Read()

        InsAcc = ReadData.GetString(0)

        insread = "select amount from bankaccount where bankacctnum = '" & InsAcc & "'"
        CmdRead = New DB2Command(insread, dbCon)
        ReadData = CmdRead.ExecuteReader
        ReadData.Read()

        InsBill = ReadData.GetDecimal(0)

        InsBill = InsBill + 300

        insupdate = "update bankaccount set amount = '" & InsBill & "' where bankacctnum = '" & InsAcc & "' "
        CmdRead = New DB2Command(insupdate, dbCon)
        CmdRead.ExecuteNonQuery()

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
        billtype = "BillHelth"
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
            InsertStr = "insert into transactions values('" & stringtransnum & "','" & transtype & "','" & checkdate & "','" & balance & "',300,'" & MainAcc & "','" & billtype & "')"
            CmdInsert = New DB2Command(InsertStr, dbCon)
            CmdInsert.ExecuteNonQuery()
        Else
            InsertStr = "insert into transactions values('" & stringtransnum & "','" & transtype & "','" & checkdate & "','" & balance & "',300,'" & MainAcc & "','" & billtype & "')"
            CmdInsert = New DB2Command(InsertStr, dbCon)
            CmdInsert.ExecuteNonQuery()

        End If
        Me.lblsuccess.Text = "Successfully Payed" + Environment.NewLine + " 1 Month Bill"
    End Sub

    Private Sub bttnQyear_Click(sender As Object, e As EventArgs) Handles bttnQyear.Click
        Dim MainAcc As String
        Dim payread As String
        Dim CmdRead As DB2Command
        Dim ReadData As DB2DataReader
        Dim balance As Decimal
        Dim balupdate As String
        Dim insread As String
        Dim insupdate As String
        Dim InsAcc As String
        Dim InsBill As Decimal


        MainAcc = Bnkpass

        payread = "select amount from bankaccount where bankacctnum = '" & MainAcc & "'"
        CmdRead = New DB2Command(payread, dbCon)
        ReadData = CmdRead.ExecuteReader
        ReadData.Read()

        balance = ReadData.GetDecimal(0)

        balance = balance - 900

        balupdate = "update bankaccount set amount = '" & balance & "' where  bankacctnum = '" & MainAcc & "'"
        CmdRead = New DB2Command(balupdate, dbCon)
        CmdRead.ExecuteNonQuery()

        insread = "select billacctnum from billers where billname = 'BillHelth' "
        CmdRead = New DB2Command(insread, dbCon)
        ReadData = CmdRead.ExecuteReader
        ReadData.Read()

        InsAcc = ReadData.GetString(0)

        insread = "select amount from bankaccount where bankacctnum = '" & InsAcc & "'"
        CmdRead = New DB2Command(insread, dbCon)
        ReadData = CmdRead.ExecuteReader
        ReadData.Read()

        InsBill = ReadData.GetDecimal(0)

        InsBill = InsBill + 900

        insupdate = "update bankaccount set amount = '" & InsBill & "' where bankacctnum = '" & InsAcc & "' "
        CmdRead = New DB2Command(insupdate, dbCon)
        CmdRead.ExecuteNonQuery()


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
        billtype = "BillHelth"
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
            InsertStr = "insert into transactions values('" & stringtransnum & "','" & transtype & "','" & checkdate & "','" & balance & "',900,'" & MainAcc & "','" & billtype & "')"
            CmdInsert = New DB2Command(InsertStr, dbCon)
            CmdInsert.ExecuteNonQuery()
        Else
            InsertStr = "insert into transactions values('" & stringtransnum & "','" & transtype & "','" & checkdate & "','" & balance & "',900,'" & MainAcc & "','" & billtype & "')"
            CmdInsert = New DB2Command(InsertStr, dbCon)
            CmdInsert.ExecuteNonQuery()

        End If

        Me.lblsuccess.Text = "Successfully Payed" + Environment.NewLine + " Quarter Year Bill"
    End Sub

    Private Sub bttnYear_Click(sender As Object, e As EventArgs) Handles bttnYear.Click
        Dim MainAcc As String
        Dim payread As String
        Dim CmdRead As DB2Command
        Dim ReadData As DB2DataReader
        Dim balance As Decimal
        Dim balupdate As String
        Dim insread As String
        Dim insupdate As String
        Dim InsAcc As String
        Dim InsBill As Decimal


        MainAcc = Bnkpass

        payread = "select amount from bankaccount where bankacctnum = '" & MainAcc & "'"
        CmdRead = New DB2Command(payread, dbCon)
        ReadData = CmdRead.ExecuteReader
        ReadData.Read()

        balance = ReadData.GetDecimal(0)

        balance = balance - 3600

        balupdate = "update bankaccount set amount = '" & balance & "' where  bankacctnum = '" & MainAcc & "'"
        CmdRead = New DB2Command(balupdate, dbCon)
        CmdRead.ExecuteNonQuery()

        insread = "select billacctnum from billers where billname = 'BillHelth' "
        CmdRead = New DB2Command(insread, dbCon)
        ReadData = CmdRead.ExecuteReader
        ReadData.Read()

        InsAcc = ReadData.GetString(0)

        insread = "select amount from bankaccount where bankacctnum = '" & InsAcc & "'"
        CmdRead = New DB2Command(insread, dbCon)
        ReadData = CmdRead.ExecuteReader
        ReadData.Read()

        InsBill = ReadData.GetDecimal(0)

        InsBill = InsBill + 3600

        insupdate = "update bankaccount set amount = '" & InsBill & "' where bankacctnum = '" & InsAcc & "' "
        CmdRead = New DB2Command(insupdate, dbCon)
        CmdRead.ExecuteNonQuery()

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
        billtype = "BillHelth"
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
            InsertStr = "insert into transactions values('" & stringtransnum & "','" & transtype & "','" & checkdate & "','" & balance & "',3600,'" & MainAcc & "','" & billtype & "')"
            CmdInsert = New DB2Command(InsertStr, dbCon)
            CmdInsert.ExecuteNonQuery()
        Else
            InsertStr = "insert into transactions values('" & stringtransnum & "','" & transtype & "','" & checkdate & "','" & balance & "',3600,'" & MainAcc & "','" & billtype & "')"
            CmdInsert = New DB2Command(InsertStr, dbCon)
            CmdInsert.ExecuteNonQuery()

        End If
        Me.lblsuccess.Text = "Successfully Payed" + Environment.NewLine + " 1 Year Bill"
    End Sub

    Private Sub bttnexit_Click_1(sender As Object, e As EventArgs) Handles bttnexit.Click
        Me.Hide()
        BillFrm.Show()
        Me.lblsuccess.Text = ""
    End Sub
End Class
