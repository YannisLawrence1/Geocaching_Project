Public Class ListCreate
    Dim idStore As Integer
    Dim currentSpot As Integer
    Private Sub butSubmitCache_Click(sender As Object, e As EventArgs)
        Dim cb As New OleDb.OleDbCommandBuilder(da6)
        Dim ds6NewRow As DataRow

        cb.QuotePrefix = "["
        cb.QuoteSuffix = "]"

        ds6NewRow = ds6.Tables("tblList").NewRow()

        For currentSpot = 0 To MaxRows6 - 1
            If ds6.Tables("tblList").Rows(currentSpot).Item(0) > idStore Then
                idStore = ds6.Tables("tblList").Rows(currentSpot).Item(0)
            End If
        Next

        ds6NewRow.Item("listID") = idStore + 1
        ds6NewRow.Item("listname") = txtListName.Text
        ds6NewRow.Item("userID") = userIdStore

        ds6.Tables("tblList").Rows.Add(ds6NewRow)
        da6.Update(ds6, "tblList")

        MsgBox("New list created")
        Lists.Show()
        Me.Close()

    End Sub
End Class