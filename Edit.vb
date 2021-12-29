Public Class Edit
    Dim x As Integer
    Private Sub Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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


    Private Sub butNewCacheOpen_Click(sender As Object, e As EventArgs) Handles butNewCacheOpen.Click
        AddNew.Show()
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

    Private Sub butAdminOpen_Click(sender As Object, e As EventArgs) Handles butAdminOpen.Click
        Admin.Show()
        Me.Close()
    End Sub

    Dim found As Boolean

    Private Sub butSubmitCache_Click(sender As Object, e As EventArgs) Handles butSubmitCache.Click
        found = False

        If radGeocacheNumber.Checked = True Then
            For x = 0 To MaxRows2 - 1
                If txtSearch.Text = ds2.Tables("tblGeocache").Rows(x).Item(0) Then
                    ValStore = x
                    Edit2.Show()
                    Me.Close()
                    found = True

                End If
            Next
            x = -1

            If found = False Then
                MsgBox("Geocache number not found please try a diffrent geocache number")
            End If



        ElseIf radChurchMicro.Checked = True Then
            For x = 0 To MaxRows2 - 1
                If txtSearch.Text = ds2.Tables("tblGeocache").Rows(x).Item(1) Then
                    ValStore = x
                    Edit2.Show()
                    Me.Close()
                    found = True

                End If
            Next
            x = -1

            If found = False Then
                MsgBox("Church micro number not found please try a diffrent church micro number")
            End If


        Else
                MsgBox("please select if you want to search by Geocache number or Church micro number")

        End If
    End Sub

    Private Sub WebControl1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles timClock.Tick
        txtTimer.Text = Format(Now, "HH:mm:ss")
    End Sub
End Class