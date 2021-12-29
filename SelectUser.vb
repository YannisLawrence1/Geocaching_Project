Public Class SelectUser
    Dim position As Integer
    Dim userName As String
    Dim SpotNeeded As Integer

    Private Sub but5R_Click(sender As Object, e As EventArgs) Handles but5R.Click
        If position + 9 < MaxRows Then
            position = position + 9
        Else
            MsgBox("already at last entrie")
        End If

        UpdateUser()
    End Sub

    Private Sub but5L_Click(sender As Object, e As EventArgs) Handles but5L.Click
        If position - 9 >= 0 Then
            position = position - 9
        ElseIf position > 0 Then
            position = 0
        Else
            MsgBox("already at first entrie")

        End If


        UpdateUser()
    End Sub

    Sub loadUser()
        timClock.Enabled = True

        ds9.Clear()

        con.Open()

        sql9 = "SELECT * From tblUser Where  Not Password = """" "
        da9 = New OleDb.OleDbDataAdapter(sql9, con)
        da9.Fill(ds9, "tblUser_")

        con.Close()

        MaxRows = ds9.Tables("tblUser_").Rows.Count
    End Sub


    Sub UpdateUser()

        txtUserName1.Text = ""
        txtUserName2.Text = ""
        txtUserName3.Text = ""
        txtUserName4.Text = ""
        txtUserName5.Text = ""
        txtUserName6.Text = ""
        txtUserName7.Text = ""
        txtUserName8.Text = ""
        txtUserName9.Text = ""

        txtFirstName1.Text = ""
        txtFirstName2.Text = ""
        txtFirstName3.Text = ""
        txtFirstName4.Text = ""
        txtFirstName5.Text = ""
        txtFirstName6.Text = ""
        txtFirstName7.Text = ""
        txtFirstName8.Text = ""
        txtFirstName9.Text = ""

        txtLastName1.Text = ""
        txtLastName2.Text = ""
        txtLastName3.Text = ""
        txtLastName4.Text = ""
        txtLastName5.Text = ""
        txtLastName6.Text = ""
        txtLastName7.Text = ""
        txtLastName8.Text = ""
        txtLastName9.Text = ""


        If position < MaxRows Then
            txtUserName1.Text = ds9.Tables("tblUser_").Rows(position).Item(3)
            txtFirstName1.Text = ds9.Tables("tblUser_").Rows(position).Item(1)
            txtLastName1.Text = ds9.Tables("tblUser_").Rows(position).Item(2)
        End If

        If position + 1 < MaxRows Then
            txtUserName2.Text = ds9.Tables("tblUser_").Rows(position + 1).Item(3)
            txtFirstName2.Text = ds9.Tables("tblUser_").Rows(position + 1).Item(1)
            txtLastName2.Text = ds9.Tables("tblUser_").Rows(position + 1).Item(2)
        End If

        If position + 2 < MaxRows Then
            txtUserName3.Text = ds9.Tables("tblUser_").Rows(position + 2).Item(3)
            txtFirstName3.Text = ds9.Tables("tblUser_").Rows(position + 2).Item(1)
            txtLastName3.Text = ds9.Tables("tblUser_").Rows(position + 2).Item(2)
        End If

        If position + 3 < MaxRows Then
            txtUserName4.Text = ds9.Tables("tblUser_").Rows(position + 3).Item(3)
            txtFirstName4.Text = ds9.Tables("tblUser_").Rows(position + 3).Item(1)
            txtLastName4.Text = ds9.Tables("tblUser_").Rows(position + 3).Item(2)
        End If

        If position + 4 < MaxRows Then
            txtUserName5.Text = ds9.Tables("tblUser_").Rows(position + 4).Item(3)
            txtFirstName5.Text = ds9.Tables("tblUser_").Rows(position + 4).Item(1)
            txtLastName5.Text = ds9.Tables("tblUser_").Rows(position + 4).Item(2)
        End If

        If position + 5 < MaxRows Then
            txtUserName6.Text = ds9.Tables("tblUser_").Rows(position + 5).Item(3)
            txtFirstName6.Text = ds9.Tables("tblUser_").Rows(position + 5).Item(1)
            txtLastName6.Text = ds9.Tables("tblUser_").Rows(position + 5).Item(2)
        End If

        If position + 6 < MaxRows Then
            txtUserName7.Text = ds9.Tables("tblUser_").Rows(position + 6).Item(3)
            txtFirstName7.Text = ds9.Tables("tblUser_").Rows(position + 6).Item(1)
            txtLastName7.Text = ds9.Tables("tblUser_").Rows(position + 6).Item(2)
        End If

        If position + 7 < MaxRows Then
            txtUserName8.Text = ds9.Tables("tblUser_").Rows(position + 7).Item(3)
            txtFirstName8.Text = ds9.Tables("tblUser_").Rows(position + 7).Item(1)
            txtLastName8.Text = ds9.Tables("tblUser_").Rows(position + 7).Item(2)
        End If

        If position + 8 < MaxRows Then
            txtUserName9.Text = ds9.Tables("tblUser_").Rows(position + 8).Item(3)
            txtFirstName9.Text = ds9.Tables("tblUser_").Rows(position + 8).Item(1)
            txtLastName9.Text = ds9.Tables("tblUser_").Rows(position + 8).Item(2)
        End If


    End Sub


    Private Sub SelectUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUserNameDisplay.Text = userStore
        If access = "ace1" Then
            txtLevelOfAccessDisplay.Text = "Level of Access: Read only"

            butNewCacheOpen.Enabled = False

            butEditCacheOpen.Enabled = False

            butAdminOpen.Enabled = False


        ElseIf access = "ace2" Then
            txtLevelOfAccessDisplay.Text = "Level of Access: Read and write"

            butNewCacheOpen.Enabled = True

            butEditCacheOpen.Enabled = False

            butAdminOpen.Enabled = False


        ElseIf access = "ace3" Then
            txtLevelOfAccessDisplay.Text = "Level of Access: Read, write and edit"

            butNewCacheOpen.Enabled = True

            butEditCacheOpen.Enabled = True

            butAdminOpen.Enabled = False

        Else
            txtLevelOfAccessDisplay.Text = "Level of Access: Admin"

            butNewCacheOpen.Enabled = True

            butEditCacheOpen.Enabled = True

            butAdminOpen.Enabled = True

        End If

        If adminChanged = "ChangeAccess" Then

            butSelectUser1.Text = "Change access"
            butSelectUser2.Text = "Change access"
            butSelectUser3.Text = "Change access"
            butSelectUser4.Text = "Change access"
            butSelectUser5.Text = "Change access"
            butSelectUser6.Text = "Change access"
            butSelectUser7.Text = "Change access"
            butSelectUser8.Text = "Change access"
            butSelectUser9.Text = "Change access"


        ElseIf adminChanged = "RemoveAccount" Then

            butSelectUser1.Text = "Delete User"
            butSelectUser2.Text = "Delete User"
            butSelectUser3.Text = "Delete User"
            butSelectUser4.Text = "Delete User"
            butSelectUser5.Text = "Delete User"
            butSelectUser6.Text = "Delete User"
            butSelectUser7.Text = "Delete User"
            butSelectUser8.Text = "Delete User"
            butSelectUser9.Text = "Delete User"


        End If

        loadUser()

        UpdateUser()
    End Sub

    Sub RemoveUser()
        If userName = txtUserNameDisplay.Text Then
            MsgBox("Cannot delete yourself!", MessageBoxIcon.Exclamation)
        Else

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the user, " & userName & "?", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Dim cb As New OleDb.OleDbCommandBuilder(da)

                cb.QuotePrefix = "["
                cb.QuoteSuffix = "]"
                ds9.Tables("tblUser_").Rows(SpotNeeded).Item(4) = ""
                ds9.Tables("tblUser_").Rows(SpotNeeded).Item(7) = ""
                da.Update(ds9, "tblUser_")
                loadUser()
            Else

            End If

        End If

    End Sub

    Private Sub butSelectUser1_Click(sender As Object, e As EventArgs) Handles butSelectUser1.Click

        If txtFirstName1.Text = "" Then

        Else
            If adminChanged = "ChangeAccess" Then
                userNameStore = txtUserName1.Text
                SelectAccessLevel.Show()
                Me.Close()

            Else
                userName = txtUserName1.Text
                SpotNeeded = position

                RemoveUser()
            End If
        End If

        UpdateUser()
    End Sub

    Private Sub butSelectUser2_Click(sender As Object, e As EventArgs) Handles butSelectUser2.Click
        If txtFirstName2.Text = "" Then

        Else
            If adminChanged = "ChangeAccess" Then


            Else
                userName = txtUserName2.Text
                SpotNeeded = position + 1

                RemoveUser()
            End If
        End If

        UpdateUser()
    End Sub

    Private Sub butSelectUser3_Click(sender As Object, e As EventArgs) Handles butSelectUser3.Click
        If txtFirstName3.Text = "" Then

        Else
            If adminChanged = "ChangeAccess" Then


            Else
                userName = txtUserName3.Text
                SpotNeeded = position + 2

                RemoveUser()
            End If
        End If

        UpdateUser()
    End Sub

    Private Sub butSelectUser4_Click(sender As Object, e As EventArgs) Handles butSelectUser4.Click
        If txtFirstName4.Text = "" Then

        Else
            If adminChanged = "ChangeAccess" Then


            Else
                userName = txtUserName4.Text
                SpotNeeded = position + 3

                RemoveUser()
            End If
        End If

        UpdateUser()
    End Sub

    Private Sub butSelectUser5_Click(sender As Object, e As EventArgs) Handles butSelectUser5.Click
        If txtFirstName5.Text = "" Then

        Else
            If adminChanged = "ChangeAccess" Then


            Else
                userName = txtUserName5.Text
                SpotNeeded = position + 4

                RemoveUser()
            End If
        End If

        UpdateUser()
    End Sub

    Private Sub butSelectUser6_Click(sender As Object, e As EventArgs) Handles butSelectUser6.Click
        If txtFirstName6.Text = "" Then

        Else
            If adminChanged = "ChangeAccess" Then


            Else
                userName = txtUserName6.Text
                SpotNeeded = position + 5

                RemoveUser()
            End If
        End If

        UpdateUser()
    End Sub

    Private Sub butSelectUser7_Click(sender As Object, e As EventArgs) Handles butSelectUser7.Click
        If txtFirstName7.Text = "" Then

        Else
            If adminChanged = "ChangeAccess" Then


            Else
                userName = txtUserName7.Text
                SpotNeeded = position + 6

                RemoveUser()
            End If
        End If

        UpdateUser()
    End Sub

    Private Sub butSelectUser8_Click(sender As Object, e As EventArgs) Handles butSelectUser8.Click
        If txtFirstName8.Text = "" Then

        Else
            If adminChanged = "ChangeAccess" Then


            Else
                userName = txtUserName8.Text
                SpotNeeded = position + 7

                RemoveUser()
            End If
        End If

        UpdateUser()
    End Sub

    Private Sub butSelectUser9_Click(sender As Object, e As EventArgs) Handles butSelectUser9.Click
        If txtFirstName9.Text = "" Then

        Else
            If adminChanged = "ChangeAccess" Then


            Else
                userName = txtUserName9.Text
                SpotNeeded = position + 8

                RemoveUser()
            End If
        End If

        UpdateUser()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles timClock.Tick
        txtTimer.Text = Format(Now, "HH:mm:ss")
    End Sub

    Private Sub butNewCacheOpen_Click(sender As Object, e As EventArgs) Handles butNewCacheOpen.Click
        AddNew.Show()
        Me.Close()
    End Sub

    Private Sub butEditCacheOpen_Click(sender As Object, e As EventArgs) Handles butEditCacheOpen.Click
        Edit.Show()
        Me.Close()
    End Sub

    Private Sub butViewCacheOpen_Click(sender As Object, e As EventArgs) Handles butViewCacheOpen.Click
        ViewCaches.Show()
        Me.Close()
    End Sub

    Private Sub butListsOpen_Click(sender As Object, e As EventArgs) Handles butListsOpen.Click
        Lists.Show()
        Me.Close()
    End Sub

    Private Sub butLogOut_Click(sender As Object, e As EventArgs) Handles butLogOut.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub butCancel_Click(sender As Object, e As EventArgs) Handles butCancel.Click
        Admin.Show()
        Me.Close()
    End Sub
End Class