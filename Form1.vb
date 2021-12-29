Public Class Form1

    Public inc As Integer
    Dim con As New OleDb.OleDbConnection

    Dim dbProvider As String
    Dim dbSource As String
    Dim MyDocumentsFolder As String
    Dim TheDatabase As String
    Dim FullDatabasePath As String

    Dim usern As String
    Dim passw As String

    Dim MaxRows As Integer
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql As String


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
        da.Fill(ds, "Geocaching_Database")


        con.Close()

        MaxRows = ds.Tables("Geocaching_Database").Rows.Count
    End Sub


    Private Sub NavigateRecords()
        usern = ds.Tables("Geocaching_Database").Rows(inc).Item(3)
        passw = ds.Tables("Geocaching_Database").Rows(inc).Item(4)
    End Sub

    Private Sub butLogIn_Click(sender As Object, e As EventArgs) Handles butLogIn.Click
        If String.IsNullOrEmpty(txtUserName.Text) Then
            MsgBox("No input found for username, please make sure an input is entered.")
        ElseIf String.IsNullOrEmpty(txtPassword.Text) Then
            MsgBox("No input found for password, please make sure an input is entered.")
        End If

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

                    Me.Hide()
                    Edit.Show()


                Else
                    Continue For
                End If
            Else
                Label5.Visible = True
                Continue For
            End If
        Next
        inc = -1
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadUser()
        inc = -1
    End Sub

    Private Sub butForgotPassword_Click(sender As Object, e As EventArgs) Handles butForgotPassword.Click
        forgotPasword1.Show()
        Me.Hide()
    End Sub
End Class
