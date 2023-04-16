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

        Me.lblerror.Text = ""
        Me.lblsuccess.Text = ""
        Me.LinkBack.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline

    End Sub



    Private Sub BTcreateacc_Click(sender As Object, e As EventArgs) Handles BTcreateacc.Click
        Try
            Dim BankAcc As String
            Dim Uname As String
            Dim Pass As String
            Dim Cpass As String
            Dim InsertStr As String
            Dim Strread As String
            Dim Compread As String
            Dim CmdInsert As DB2Command
            Dim CmdRead As DB2Command
            Dim ReadData As DB2DataReader
            Dim CompData As DB2DataReader
            Dim bankcomp As String

            BankAcc = Me.TxtBankAcc.Text
            Uname = Me.TxtUser.Text
            Pass = Me.TxtPass.Text
            Cpass = Me.TxtCpass.Text

            If BankAcc = vbNullString Or Uname = vbNullString Or Pass = vbNullString Then
                Me.lblerror.Text = ""
                Me.lblsuccess.Text = ""
                Me.lblerror.Text = "Please enter all fields."
            Else

                If Pass <> Cpass Then
                    Me.lblerror.Text = ""
                    Me.lblsuccess.Text = ""
                    Me.lblerror.Text = "Passwords do not match."
                    Call ClearEntry()
                Else
                    Strread = "select bankacctnum from bankaccount where bankacctnum = '" & BankAcc & "'"
                    CmdRead = New DB2Command(Strread, dbCon)
                    ReadData = CmdRead.ExecuteReader
                    ReadData.Read()
                    bankcomp = ReadData.GetString(0)

                    Compread = "select username from user where username = '" & Uname & "'"
                    CmdRead = New DB2Command(Compread, dbCon)
                    CompData = CmdRead.ExecuteReader
                    CompData.Read()

                    If CompData.HasRows Then
                        Me.lblerror.Text = ""
                        Me.lblsuccess.Text = ""
                        Me.lblerror.Text = "Username is already Taken."
                        Me.TxtBankAcc.Clear()
                        Me.TxtUser.Clear()
                        Me.TxtPass.Clear()
                        Me.TxtCpass.Clear()

                        Me.TxtBankAcc.Focus()

                    Else

                        Compread = "select bankacctnum from user where bankacctnum = '" & bankcomp & "'"
                        CmdRead = New DB2Command(Compread, dbCon)
                        CompData = CmdRead.ExecuteReader
                        CompData.Read()

                        If CompData.HasRows Then
                            Me.lblerror.Text = "Bank Account Already Has an Online Account."
                            Me.TxtBankAcc.Clear()
                            Me.TxtUser.Clear()
                            Me.TxtPass.Clear()
                            Me.TxtCpass.Clear()

                            Me.TxtBankAcc.Focus()


                        Else

                            InsertStr = "insert into user values('" & BankAcc & "','" & Uname & "','" & Pass & "')"
                            CmdInsert = New DB2Command(InsertStr, dbCon)
                            CmdInsert.ExecuteNonQuery()

                            Me.lblerror.Text = ""
                            Me.lblsuccess.Text = ""
                            Me.lblsuccess.Text = "Online Account has Succesfully Created"

                            Call ClearEntry()

                        End If
                    End If

                End If
            End If

        Catch ex As Exception
            Me.lblerror.Text = ""
            Me.lblsuccess.Text = ""
            Me.lblerror.Text = "Bank Account is not found in the Database."
        End Try
    End Sub
    Private Sub ClearEntry()
        Me.TxtBankAcc.Clear()
        Me.TxtUser.Clear()
        Me.TxtPass.Clear()
        Me.TxtCpass.Clear()

        Me.TxtBankAcc.Focus()
    End Sub

    Private Sub TxtCpass_Enter(sender As Object, e As EventArgs) Handles TxtCpass.Enter

    End Sub

    Private Sub LinkBack_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkBack.LinkClicked
        Me.Close()
        frm1.Show()

    End Sub
End Class