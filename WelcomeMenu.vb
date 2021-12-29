Public Class WelcomeMenu



    Private Sub WelcomeMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If access = "ace1" Then
            txtLevelOfAccessDisplay.Text = "Level of Access: Read only"

            butAddNew.Enabled = False
            picAddNew.Enabled = False

            butEdit.Enabled = False
            picEdit.Enabled = False

            butAdmin.Enabled = False
            picAdmin.Enabled = False


        ElseIf access = "ace2" Then
            txtLevelOfAccessDisplay.Text = "Level of Access: Read and write"

            butAddNew.Enabled = True
            picAddNew.Enabled = True

            butEdit.Enabled = False
            picEdit.Enabled = False

            butAdmin.Enabled = False
            picAdmin.Enabled = False


        ElseIf access = "ace3" Then
            txtLevelOfAccessDisplay.Text = "Level of Access: Read, write and edit"

            butAddNew.Enabled = True
            picAddNew.Enabled = True

            butEdit.Enabled = True
            picEdit.Enabled = True

            butAdmin.Enabled = False
            picAdmin.Enabled = False

        Else
            txtLevelOfAccessDisplay.Text = "Level of Access: Admin"

            butAddNew.Enabled = True
            picAddNew.Enabled = True

            butEdit.Enabled = True
            picEdit.Enabled = True

            butAdmin.Enabled = True
            picAdmin.Enabled = True

        End If

        loadGeocache()
        loadCacheType()
        loadContainerType()
        loadCounty()

        txtWelcome.Text = "Welcome, " & userStore
    End Sub

    Private Sub butAddNew_Click(sender As Object, e As EventArgs) Handles butAddNew.Click
        AddNew.Show()
        Me.Close()
    End Sub

    Private Sub picAddNew_Click(sender As Object, e As EventArgs) Handles picAddNew.Click
        AddNew.Show()
        Me.Close()
    End Sub

    Private Sub butEdit_Click(sender As Object, e As EventArgs) Handles butEdit.Click
        Edit.Show()
        Me.Close()
    End Sub

    Private Sub picEdit_Click(sender As Object, e As EventArgs) Handles picEdit.Click
        Edit.Show()
        Me.Close()
    End Sub

    Private Sub butView_Click(sender As Object, e As EventArgs) Handles butView.Click
        ViewCaches.Show()
        Me.Close()
    End Sub

    Private Sub picView_Click(sender As Object, e As EventArgs) Handles picView.Click
        ViewCaches.Show()
        Me.Close()
    End Sub

    Private Sub butList_Click(sender As Object, e As EventArgs) Handles butList.Click
        Lists.Show()
        Me.Close()
    End Sub

    Private Sub picList_Click(sender As Object, e As EventArgs) Handles picList.Click
        Lists.Show()
        Me.Close()
    End Sub


    Private Sub butExports_Click(sender As Object, e As EventArgs) Handles butExports.Click
        Lists.Show()
        Me.Close()
    End Sub

    Private Sub picExports_Click(sender As Object, e As EventArgs) Handles picExports.Click
        Lists.Show()
        Me.Close()
    End Sub

    Private Sub butAdmin_Click(sender As Object, e As EventArgs) Handles butAdmin.Click
        Admin.Show()
        Me.Close()
    End Sub

    Private Sub picAdmin_Click(sender As Object, e As EventArgs) Handles picAdmin.Click
        Admin.Show()
        Me.Close()
    End Sub

    Private Sub butLogOut_Click(sender As Object, e As EventArgs) Handles butLogOut.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub picLogOut_Click(sender As Object, e As EventArgs) Handles picLogOut.Click
        Form1.Show()
        Me.Close()
    End Sub


    Sub loadGeocache()
        ds2.Clear()
        con.Open()

        sql2 = "SELECT * From tblGeocache"
        da2 = New OleDb.OleDbDataAdapter(sql2, con)
        da2.Fill(ds2, "tblGeocache")

        con.Close()

        MaxRows2 = ds2.Tables("tblGeocache").Rows.Count
    End Sub
    '----------------------------------------------------------------------------------------------------------------------------
    Sub loadCacheType()
        ds3.Clear()
        con.Open()

        sql3 = "SELECT * From tblCacheType"
        da3 = New OleDb.OleDbDataAdapter(sql3, con)
        da3.Fill(ds3, "tblCacheType")

        con.Close()

        MaxRows3 = ds3.Tables("tblCacheType").Rows.Count
    End Sub
    '----------------------------------------------------------------------------------------------------------------------------
    Sub loadContainerType()
        ds4.Clear()
        con.Open()

        sql4 = "SELECT * From tblContainnerType"
        da4 = New OleDb.OleDbDataAdapter(sql4, con)
        da4.Fill(ds4, "tblContainnerType")

        con.Close()

        MaxRows4 = ds4.Tables("tblContainnerType").Rows.Count
    End Sub
    '----------------------------------------------------------------------------------------------------------------------------
    Sub loadCounty()
        ds5.Clear()
        con.Open()

        sql5 = "SELECT * From tblCounty"
        da5 = New OleDb.OleDbDataAdapter(sql5, con)
        da5.Fill(ds5, "tblCounty")

        con.Close()

        MaxRows5 = ds5.Tables("tblCounty").Rows.Count
    End Sub


End Class