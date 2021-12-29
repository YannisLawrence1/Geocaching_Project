Public Class Form1
    Dim usern As String
    Dim passw As String
    Dim login As Boolean = False


    Sub loadUser()
        dbProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
        TheDatabase = "/Geocaching_Database.mdb"
        MyDocumentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        FullDatabasePath = MyDocumentsFolder & TheDatabase
        dbSource = "Data Source = " & FullDatabasePath
        con.ConnectionString = dbProvider & dbSource

        con.Open()

        sql = "SELECT * From tblUser"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "tblUser")

        con.Close()

        MaxRows = ds.Tables("tblUser").Rows.Count

    End Sub


    Private Sub NavigateRecords()
        usern = ds.Tables("tblUser").Rows(inc).Item(3)
        passw = ds.Tables("tblUser").Rows(inc).Item(4)
    End Sub

    Private Sub butLogIn_Click(sender As Object, e As EventArgs) Handles butLogIn.Click
        If String.IsNullOrEmpty(txtUserName.Text) Then
            MsgBox("No input found for username, please make sure an input is entered.", MessageBoxIcon.Exclamation)
        ElseIf String.IsNullOrEmpty(txtPassword.Text) Then
            MsgBox("No input found for password, please make sure an input is entered.", MessageBoxIcon.Exclamation)
        Else
            For i = 1 To MaxRows
                If inc <> MaxRows - 1 Then

                    inc = inc + 1
                    NavigateRecords()

                Else

                    MessageBox.Show("No More Rows")
                    Exit For
                End If
                If txtUserName.Text = usern Then
                    If txtPassword.Text = passw Then

                        userIdStore = ds.Tables("tblUser").Rows(inc).Item(0)
                        userStore = ds.Tables("tblUser").Rows(inc).Item(3)
                        access = ds.Tables("tblUser").Rows(inc).Item(8)

                        txtUserName.Text = ""
                        txtPassword.Text = ""

                        If passw = "Password1" Then
                            userLocation = inc
                            SelectSecurityQuestionvb.Show()
                            Me.Hide()
                            Exit For
                        Else
                            WelcomeMenu.Show()
                            Me.Hide()
                            login = True
                            Exit For
                        End If


                    Else
                        Continue For
                    End If
                Else
                    Label5.Show()
                    Continue For
                End If
            Next
            inc = -1
        End If

        If login = True Then
            Label5.Hide()
            login = False
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadUser()
        inc = -1
        Label5.Hide()
    End Sub

    Private Sub butForgotPassword_Click(sender As Object, e As EventArgs) Handles butForgotPassword.Click
        ForgotPassword.Show()
        Me.Hide()
        txtUserName.Text = ""
        txtPassword.Text = ""
    End Sub
End Class
