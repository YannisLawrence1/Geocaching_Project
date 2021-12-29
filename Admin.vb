Public Class Admin
    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timClock.Enabled = True
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
    End Sub
    Private Sub butNewAccount_Click(sender As Object, e As EventArgs) Handles butNewAccount.Click
        CreateANewAccount.Show()
        Me.Close()
    End Sub

    Private Sub butChangeAccess_Click(sender As Object, e As EventArgs) Handles butChangeAccess.Click
        adminChanged = "ChangeAccess"
        SelectUser.Show()
        Me.Close()
    End Sub

    Private Sub butRemove_Click(sender As Object, e As EventArgs) Handles butRemove.Click
        adminChanged = "RemoveAccount"
        SelectUser.Show()
        Me.Close()
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
End Class