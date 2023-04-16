Imports IBM.Data.DB2
Public Class frm1

    Private dbCon As Common.DbConnection


    Private Sub bbtnlogin_Click(sender As Object, e As EventArgs) Handles bttnlogin.Click
        Try
            Dim Uname As String
            Dim Pass As String
            Dim Strread As String
            Dim Cmdread As DB2Command
            Dim Readdata As DB2DataReader

            Dim tableuname As String
            Dim tablepass As String
            Dim tablebankacc As String





            Uname = Me.txtusername.Text
            Pass = Me.txtpassword.Text

            Strread = "select username,password,bankacctnum from onlineaccount where username = '" & Uname & "'"
           

                Cmdread = New DB2Command(Strread, dbCon)
                Readdata = Cmdread.ExecuteReader
                Readdata.Read()

                tableuname = Readdata.GetString(0)
                tablepass = Readdata.GetString(1)
            tablebankacc = Readdata.GetString(2)

                If Pass <> tablepass Then
                    MsgBox("Password does not match username")
                    Me.txtpassword.Clear()
                    Me.txtpassword.Focus()

                ElseIf Pass = tablepass Then
                    MsgBox("username and password matches")
                Me.txtusername.Clear()
                Me.txtpassword.Clear()

                MenuFrm.Strpass = tablebankacc
                MenuFrm.Show()
                Me.Hide()


                End If

        Catch ex As Exception
            MsgBox("Username does not exist in the database")
            Me.txtusername.Clear()
            Me.txtpassword.Clear()
            Me.txtusername.Focus()
        End Try


    End Sub

    Private Sub bttnexit_Click(sender As Object, e As EventArgs) Handles bttnexit.Click
        dbCon.Close()
        Me.Close()

    End Sub

    Private Sub bttncreate_Click(sender As Object, e As EventArgs) Handles bttncreate.Click
        Dim createacc = CreateAccForm
        createacc.Show()


    End Sub

    Private Sub frm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dbCon = New DB2Connection("server=localhost;database=banksys;" + "uid=db2admin;password=password;")
        dbCon.Open()
        If dbCon.State = ConnectionState.Open Then
            MsgBox("connection established")
        Else
            MsgBox("No connection")
        End If

    End Sub

End Class
