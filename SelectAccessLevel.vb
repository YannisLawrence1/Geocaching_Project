Public Class SelectAccessLevel
    Dim position As Integer
    Dim accessID As String
    Private Sub SelectAccessLevel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtLevelOfAccessDisplay.Text = "Select access level for " & userNameStore
    End Sub

    Private Sub butSubmit_Click(sender As Object, e As EventArgs) Handles butSubmit.Click
        For position = 0 To MaxRows - 1
            If userNameStore = ds.Tables("tblUser").Rows(inc).Item(3) Then

                If comAccessLevel.Text = "read only" Then
                    accessID = "ace1"
                    updateAccess()

                ElseIf comAccessLevel.Text = "read And write" Then
                    accessID = "ace2"
                    updateAccess()

                ElseIf comAccessLevel.Text = "read, write and remove" Then
                    accessID = "ace3"
                    updateAccess()

                ElseIf comAccessLevel.Text = "admin" Then
                    accessID = "ace4"
                    updateAccess()

                Else
                    MsgBox("Please Select an access level for the user", "error", MessageBoxIcon.Exclamation)
                End If
            End If
        Next
    End Sub

    Public Sub updateAccess()
        Dim cb As New OleDb.OleDbCommandBuilder(da)

        cb.QuotePrefix = "["
        cb.QuoteSuffix = "]"


        ds.Tables("tblUser").Rows(inc).Item(8) = accessID

        da.Update(ds, "tblUser")

        MsgBox("Updated access level for " & userNameStore)
        Admin.Show()
        Me.Close()
    End Sub

End Class