Public Class AddToList
    Dim position As Integer
    Dim idStore As Integer
    Dim listName As String
    Dim ListId As Integer
    Dim existingEntrie As Integer

    Sub LoadDatabase()
        ds6.Clear()
        con.Open()

        sql6 = "SELECT * From tblList where [userID] = """ & userIdStore & """"
        da6 = New OleDb.OleDbDataAdapter(sql6, con)
        da6.Fill(ds6, "tblList")

        con.Close()

        MaxRows6 = ds6.Tables("tblList").Rows.Count

        ds7.Clear()
        con.Open()

        sql7 = "SELECT * From lnkGeocacheList"
        da7 = New OleDb.OleDbDataAdapter(sql7, con)
        da7.Fill(ds7, "lnkGeocacheList")

        con.Close()

        MaxRows7 = ds7.Tables("lnkGeocacheList").Rows.Count


    End Sub

    Sub Add()
        existingEntrie = False

        Dim cb As New OleDb.OleDbCommandBuilder(da7)
        Dim ds7NewRow As DataRow

        cb.QuotePrefix = "["
        cb.QuoteSuffix = "]"

        ds7NewRow = ds7.Tables("lnkGeocacheList").NewRow()

        For currentSpot = 0 To MaxRows7 - 1
            If ds7.Tables("lnkGeocacheList").Rows(currentSpot).Item(0) > idStore Then
                idStore = ds7.Tables("lnkGeocacheList").Rows(currentSpot).Item(0)
            End If
        Next

        For currentSpot = 0 To MaxRows7 - 1
            If ds6.Tables("tblList").Rows(currentSpot).Item(1) = listName Then
                ListId = ds6.Tables("tblList").Rows(currentSpot).Item(0)
            End If
        Next

        For currentSpot = 0 To MaxRows7 - 1
            If ds7.Tables("lnkGeocacheList").Rows(currentSpot).Item(1) = CacheIDStore And ds7.Tables("lnkGeocacheList").Rows(currentSpot).Item(2) = ListId Then
                existingEntrie = True
            End If
        Next

        If existingEntrie = False Then

            ds7NewRow.Item("lnkID") = idStore + 1
            ds7NewRow.Item("geocacheID") = CacheIDStore
            ds7NewRow.Item("listID") = ListId

            ds7.Tables("lnkGeocacheList").Rows.Add(ds7NewRow)
            da7.Update(ds7, "lnkGeocacheList")

            MsgBox("Added the Geocache to " & ListName)

        Else

            MsgBox("The geocache: " & CacheNameStore & " is already in " & listName)

        End If

        ViewCaches.Show()
        Me.Close()

    End Sub


    Private Sub AddToList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDatabase()
        UpdateList()
    End Sub


    Private Sub but5R_Click(sender As Object, e As EventArgs) Handles but5R.Click
        If position + 9 < MaxRows6 Then
            position = position + 9
        Else
            MsgBox("already at last entrie")
        End If

        UpdateList()
    End Sub

    Private Sub but5L_Click(sender As Object, e As EventArgs) Handles but5L.Click
        If position - 9 >= 0 Then
            position = position - 9
        ElseIf position > 0 Then
            position = 0
        Else
            MsgBox("already at first entrie")

        End If

        UpdateList()
    End Sub


    Sub UpdateList()

        txtList1.Text = ""
        txtList2.Text = ""
        txtList3.Text = ""
        txtList4.Text = ""
        txtList5.Text = ""


        If position < MaxRows6 Then
            txtList1.Text = ds6.Tables("tblList").Rows(position).Item(1)
        End If

        If position + 1 < MaxRows6 Then
            txtList2.Text = ds6.Tables("tblList").Rows(position + 1).Item(1)
        End If

        If position + 2 < MaxRows6 Then
            txtList3.Text = ds6.Tables("tblList").Rows(position + 2).Item(1)
        End If

        If position + 3 < MaxRows6 Then
            txtList4.Text = ds6.Tables("tblList").Rows(position + 3).Item(1)
        End If

        If position + 4 < MaxRows6 Then
            txtList5.Text = ds6.Tables("tblList").Rows(position + 4).Item(1)
        End If


    End Sub


    Private Sub butAddList1_Click(sender As Object, e As EventArgs) Handles butAddList1.Click
        listName = txtList1.Text
        Add()
    End Sub

    Private Sub butAddList2_Click(sender As Object, e As EventArgs) Handles butAddList2.Click
        listName = txtList2.Text
        Add()
    End Sub

    Private Sub butAddList3_Click(sender As Object, e As EventArgs) Handles butAddList3.Click
        listName = txtList3.Text
        Add()
    End Sub

    Private Sub butAddList4_Click(sender As Object, e As EventArgs) Handles butAddList4.Click
        listName = txtList4.Text
        Add()
    End Sub

    Private Sub butAddList5_Click(sender As Object, e As EventArgs) Handles butAddList5.Click
        listName = txtList5.Text
        Add()
    End Sub
End Class