Imports IBM.Data.DB2
Public Class TransferFrm

    Public Property Bnkpass As String

    Private dbCon As Common.DbConnection



    Private Sub TransferFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dbCon = New DB2Connection("server=localhost;database=banksys;" + "uid=db2admin;password=password;")
            dbCon.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        MoneyBox.Maximum = 999999.99

        MoneyBox.Controls.RemoveAt(0)

        Me.Linkexit.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.lblerror.Text = ""
        Me.lblsuccess.Text = ""

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

            If SendAcc = "0001-1111" Then
                Me.lblerror.Text = ""
                Me.lblsuccess.Text = ""
                Me.lblerror.Text = "Bank Account is not Valid."

                Me.TxtSendacc.Clear()
                Me.MoneyBox.Value = 0
                Me.TxtSendacc.Focus()
            ElseIf SendAcc = "0001-2222" Then
                Me.lblerror.Text = ""
                Me.lblsuccess.Text = ""
                Me.lblerror.Text = "Bank Account is not Valid."

                Me.TxtSendacc.Clear()
                Me.MoneyBox.Value = 0
                Me.TxtSendacc.Focus()
            ElseIf SendAcc = "0001-3333" Then
                Me.lblerror.Text = ""
                Me.lblsuccess.Text = ""
                Me.lblerror.Text = "Bank Account is not Valid."

                Me.TxtSendacc.Clear()
                Me.MoneyBox.Value = 0
                Me.TxtSendacc.Focus()
            Else

                mainread = "select amount from bankaccount where bankacctnum = '" & MainAcc & "'"
                CmdRead = New DB2Command(mainread, dbCon)
                ReadData = CmdRead.ExecuteReader
                ReadData.Read()

                mainbal = ReadData.GetDecimal(0)


                sentread = "select amount from bankaccount where bankacctnum = '" & SendAcc & "'"
                CmdRead = New DB2Command(sentread, dbCon)
                ReadData = CmdRead.ExecuteReader
                ReadData.Read()

                sentbal = ReadData.GetDecimal(0)

                If mainbal < Moneysend Then
                    Me.lblerror.Text = ""
                    Me.lblsuccess.Text = ""
                    Me.lblerror.Text = "Money exceeds your account balance."
                    Me.MoneyBox.Value = 0
                    Me.MoneyBox.Focus()

                ElseIf Moneysend < 250 Then
                    Me.lblerror.Text = ""
                    Me.lblsuccess.Text = ""
                    Me.lblerror.Text = "Minimum Amount must be 250.00."
                    Me.MoneyBox.Value = 0
                    Me.MoneyBox.Focus()

                Else
                    mainbal = mainbal - Moneysend
                    sentbal = sentbal + Moneysend

                    Mainupdate = "update bankaccount set amount = '" & mainbal & "' where  bankacctnum = '" & MainAcc & "'"
                    cmdupdate = New DB2Command(Mainupdate, dbCon)
                    cmdupdate.ExecuteNonQuery()

                    Sentupdate = "update bankaccount set amount = '" & sentbal & "' where  bankacctnum = '" & SendAcc & "'"
                    cmdupdate = New DB2Command(Sentupdate, dbCon)
                    cmdupdate.ExecuteNonQuery()

                    Dim InsertStr As String
                    Dim CmdInsert As DB2Command
                    Dim transnum As Integer
                    Dim stringtransnum As String
                    Dim transread As String
                    Dim transtype As String
                    Dim checkdate As String

                    Randomize()

                    checkdate = String.Format("{0:dd-MM-yyyy}", DateTime.Now)
                    transtype = "Money.Transfer"
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
                        InsertStr = "insert into transactions(transactnum,transacttype,transactdate,balanceduringtrans,amountused,bankacctnum) values('" & stringtransnum & "','" & transtype & "','" & checkdate & "','" & mainbal & "','" & Moneysend & "','" & MainAcc & "')"
                        CmdInsert = New DB2Command(InsertStr, dbCon)
                        CmdInsert.ExecuteNonQuery()
                    Else
                        InsertStr = "insert into transactions(transactnum,transacttype,transactdate,balanceduringtrans,amountused,bankacctnum) values('" & stringtransnum & "','" & transtype & "','" & checkdate & "','" & mainbal & "','" & Moneysend & "','" & MainAcc & "')"
                        CmdInsert = New DB2Command(InsertStr, dbCon)
                        CmdInsert.ExecuteNonQuery()

                    End If


                    Me.lblsuccess.Text = "Money was successfully transferred"
                    Me.TxtSendacc.Clear()
                    Me.MoneyBox.Value = 0
                    Me.TxtSendacc.Focus()

                End If

            End If

        Catch ex As Exception

            Me.lblerror.Text = ""
            Me.lblsuccess.Text = ""
            Me.lblerror.Text = "Bank Account not found."

            Me.TxtSendacc.Clear()
            Me.MoneyBox.Value = 0
            Me.TxtSendacc.Focus()

        End Try
    End Sub

   
    Private Sub Txtsample_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSendacc.KeyPress



    End Sub

    Private Sub MoneyBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MoneyBox.KeyPress

   

    End Sub


    Private Sub Linkexit_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Linkexit.LinkClicked
        Me.Close()
        MenuFrm.Show()
    End Sub
End Class