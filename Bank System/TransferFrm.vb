Imports IBM.Data.DB2
Public Class TransferFrm

    Public Property Bnkpass As String

    Private dbCon As Common.DbConnection



    Private Sub BttnExit_Click(sender As Object, e As EventArgs) Handles BttnExit.Click
        Me.Close()
        MenuFrm.Show()
    End Sub

    Private Sub TransferFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dbCon = New DB2Connection("server=localhost;database=banksys;" + "uid=db2admin;password=password;")
            dbCon.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        MoneyBox.Minimum = 250
        MoneyBox.Maximum = 999999.99

        MoneyBox.Controls.RemoveAt(0)

        
    End Sub

    Private Sub BttnSend_Click(sender As Object, e As EventArgs) Handles BttnSend.Click
        Try

        
        Dim MainAcc As String
        Dim SendAcc As String
        Dim mainread As String
        Dim sentread As String
        Dim Mainupdate As String
        Dim Sentupdate As String
        Dim CmdRead As DB2Command
        Dim cmdupdate As DB2Command
        Dim ReadData As DB2DataReader

        Dim Moneysend As Decimal
        Dim mainbal As Decimal
        Dim sentbal As Decimal

        SendAcc = Me.TxtSendacc.Text
        MainAcc = Bnkpass
        Moneysend = Me.MoneyBox.Value

        mainread = "select money from bankaccount where bankacctnum = '" & MainAcc & "'"
        CmdRead = New DB2Command(mainread, dbCon)
        ReadData = CmdRead.ExecuteReader
        ReadData.Read()

        mainbal = ReadData.GetDecimal(0)

        sentread = "select money from bankaccount where bankacctnum = '" & SendAcc & "'"
        CmdRead = New DB2Command(sentread, dbCon)
        ReadData = CmdRead.ExecuteReader
        ReadData.Read()

        sentbal = ReadData.GetDecimal(0)

        mainbal = mainbal - Moneysend
        sentbal = sentbal + Moneysend

        Mainupdate = "update bankaccount set money = '" & mainbal & "' where  bankacctnum = '" & MainAcc & "'"
        cmdupdate = New DB2Command(Mainupdate, dbCon)
        cmdupdate.ExecuteNonQuery()

        Sentupdate = "update bankaccount set money = '" & sentbal & "' where  bankacctnum = '" & SendAcc & "'"
        cmdupdate = New DB2Command(Sentupdate, dbCon)
        cmdupdate.ExecuteNonQuery()

            MsgBox("Transaction Completed")
        Catch ex As Exception

        End Try
    End Sub

   
    Private Sub Txtsample_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSendacc.KeyPress



    End Sub

    Private Sub MoneyBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MoneyBox.KeyPress

   

    End Sub
End Class