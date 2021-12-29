Imports System.IO
Imports System.Text

Public Class Lists
    Dim NameStore() As String

    Dim position As Integer
    Dim nameGiven As String

    Dim ID As String
    Dim CurrentSpot As Integer
    Dim Type As String
    Dim Container As String
    Dim county As String
    Dim user As String

    Dim rowsNeeded As String

    Dim w As Integer

    Dim userDetails As String
    Dim userIDs As String

    Dim cacheTypeDetails As String
    Dim typeIDs As String

    Dim containnerTypeDetails As String
    Dim containnerTypeIDs As String

    Dim countyDetails As String
    Dim countyIDs As String
    Dim ableToExport

    Dim numStore As Integer

    Dim position2 As Integer
    Dim search As Integer


    Private Sub NavigateRecords()
        userIDs = ds.Tables("tblUser").Rows(inc).Item(0)
    End Sub

    '----------------------------------------------------------------------------------------------------------------------------

    Private Sub NavigateRecords3()
        typeIDs = ds3.Tables("tblCacheType").Rows(inc).Item(0)
    End Sub

    '----------------------------------------------------------------------------------------------------------------------------

    Private Sub NavigateRecords4()
        containnerTypeIDs = ds4.Tables("tblContainnerType").Rows(inc).Item(0)
    End Sub

    '----------------------------------------------------------------------------------------------------------------------------

    Private Sub NavigateRecords5()
        countyIDs = ds5.Tables("tblCounty").Rows(inc).Item(0)
    End Sub


    Sub loadList()

        ds6.Clear()
        con.Open()

        sql6 = "SELECT * From tblList where [userID] = """ & userIdStore & """"
        da6 = New OleDb.OleDbDataAdapter(sql6, con)
        da6.Fill(ds6, "tblList")

        con.Close()

        MaxRows6 = ds6.Tables("tblList").Rows.Count

    End Sub




    Sub quickSort()
        Dim ListArray(MaxRows6 - 1, 1) As String
        For CurrentSpot = 0 To MaxRows6 - 1
            ListArray(CurrentSpot, 0) = ds6.Tables("tblList").Rows(CurrentSpot).Item(0)
            ListArray(CurrentSpot, 1) = ds6.Tables("tblList").Rows(CurrentSpot).Item(1)
        Next


    End Sub

    Sub UpdateList()

        txtList1.Text = ""
        txtList2.Text = ""
        txtList3.Text = ""
        txtList4.Text = ""
        txtList5.Text = ""
        txtList6.Text = ""
        txtList7.Text = ""
        txtList8.Text = ""
        txtList9.Text = ""


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

        If position + 5 < MaxRows6 Then
            txtList6.Text = ds6.Tables("tblList").Rows(position + 5).Item(1)
        End If

        If position + 6 < MaxRows6 Then
            txtList7.Text = ds6.Tables("tblList").Rows(position + 6).Item(1)
        End If

        If position + 7 < MaxRows6 Then
            txtList8.Text = ds6.Tables("tblList").Rows(position + 7).Item(1)
        End If

        If position + 8 < MaxRows6 Then
            txtList9.Text = ds6.Tables("tblList").Rows(position + 8).Item(1)
        End If


    End Sub


    Private Sub Lists_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        loadList()
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

    Private Sub butOpen1_Click(sender As Object, e As EventArgs) Handles butOpen1.Click
        ListName = txtList1.Text
        Me.Close()
        Lists2.Show()
    End Sub

    Private Sub butOpen2_Click(sender As Object, e As EventArgs) Handles butOpen2.Click
        ListName = txtList2.Text
        Me.Close()
        Lists2.Show()
    End Sub

    Private Sub butOpen3_Click(sender As Object, e As EventArgs) Handles butOpen3.Click
        ListName = txtList3.Text
        Me.Close()
        Lists2.Show()
    End Sub

    Private Sub butOpen4_Click(sender As Object, e As EventArgs) Handles butOpen4.Click
        ListName = txtList4.Text
        Me.Close()
        Lists2.Show()
    End Sub

    Private Sub butOpen5_Click(sender As Object, e As EventArgs) Handles butOpen5.Click
        ListName = txtList5.Text
        Me.Close()
        Lists2.Show()
    End Sub

    Private Sub butOpen6_Click(sender As Object, e As EventArgs) Handles butOpen6.Click
        ListName = txtList6.Text
        Me.Close()
        Lists2.Show()
    End Sub

    Private Sub butOpen7_Click(sender As Object, e As EventArgs) Handles butOpen7.Click
        ListName = txtList7.Text
        Me.Close()
        Lists2.Show()
    End Sub

    Private Sub butOpen8_Click(sender As Object, e As EventArgs) Handles butOpen8.Click
        ListName = txtList8.Text
        Me.Close()
        Lists2.Show()
    End Sub

    Private Sub butOpen9_Click(sender As Object, e As EventArgs) Handles butOpen9.Click
        ListName = txtList9.Text
        Me.Close()
        Lists2.Show()
    End Sub

    Sub quickSort(start As Integer, finish As Integer)
        Dim lip, hip As Integer
        Dim mipval, temp As String
        '
        lip = start
        Debug.Print("lip = " & NameStore(lip))
        '
        hip = finish
        Debug.Print("hip = " & NameStore(hip))
        '
        mipval = NameStore((lip + hip) \ 2)
        Debug.Print("pivot = " & mipval)
        '
        Do Until lip > hip
            Do While NameStore(lip) < mipval '
                lip = lip + 1 '
                Debug.Print("lip = " & NameStore(lip))
            Loop
            Do While mipval < NameStore(hip) '
                hip = hip - 1 '
                Debug.Print("hip = " & NameStore(hip))
            Loop
            If lip <= hip Then '
                Debug.Print("Swapping " & NameStore(lip) & " with " & NameStore(hip))
                temp = NameStore(lip) '
                NameStore(lip) = NameStore(hip) '
                NameStore(hip) = temp '
                lip = lip + 1 '
                Debug.Print("lip = " & NameStore(lip))
                hip = hip - 1 '
                Try
                    Debug.Print("hip = " & NameStore(hip))
                Catch ex As Exception
                    Debug.Print("hip can't be printed. Index is " & hip)
                End Try
            End If
        Loop '
        If start < hip Then
            Debug.Print("Partitioning the list and quicksorting indexes " & start & " to " & hip)
            quickSort(start, hip) '
        End If
        If lip < finish Then
            Debug.Print("Partitioning the list and quicksorting indexes " & lip & " to " & finish)
            quickSort(lip, finish) '
        End If
    End Sub




    Sub ExportToExcel()
        ReDim NameStore(MaxRows8 - 1)
        For numStore = 0 To MaxRows8 - 1
            NameStore(numStore) = ds8.Tables("tblGeocache2").Rows(numStore).Item(2)
        Next

        quickSort(0, MaxRows8 - 1)

        Dim path As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\" & nameGiven & ".CSV"

        If System.IO.File.Exists(path) = False Then
            System.IO.File.Create(path).Dispose()
        Else
            System.IO.File.WriteAllText(path, "")
        End If

        Dim objWriter As New System.IO.StreamWriter(path, True)
        objWriter.WriteLine("geocache number,church micro number,cache name,cache type,container type,terrain rating,difficulty rating,north Co-ordinate,west Co-ordinate,county,user ")





        For CurrentSpot = 0 To MaxRows8 - 1

            For search = 0 To MaxRows8 - 1
                If NameStore(CurrentSpot) = ds8.Tables("tblGeocache2").Rows(search).Item(2) Then
                    position2 = search
                End If
            Next

            cacheTypeDetails = ds8.Tables("tblGeocache2").Rows(position2).Item(3)
            For w = 1 To MaxRows3
                If inc <> MaxRows3 - 1 Then

                    inc = inc + 1
                    NavigateRecords3()

                Else

                    MessageBox.Show("No More Rows")
                    Exit For
                End If
                If cacheTypeDetails = typeIDs Then

                    Type = ds3.Tables("tblCacheType").Rows(inc).Item(1)

                Else
                    Continue For
                End If
            Next
            inc = -1
            w = 1


            '----------------------------------------------------------------------------------------------------------------------------


            containnerTypeDetails = ds8.Tables("tblGeocache2").Rows(position2).Item(4)
            For w = 1 To MaxRows4
                If inc <> MaxRows4 - 1 Then

                    inc = inc + 1
                    NavigateRecords4()

                Else

                    MessageBox.Show("No More Rows")
                    Exit For
                End If
                If containnerTypeDetails = containnerTypeIDs Then

                    Container = ds4.Tables("tblContainnerType").Rows(inc).Item(1)

                Else
                    Continue For
                End If
            Next
            inc = -1
            w = 1


            '----------------------------------------------------------------------------------------------------------------------------


            countyDetails = ds8.Tables("tblGeocache2").Rows(position2).Item(8)
            For w = 1 To MaxRows5
                If inc <> MaxRows5 - 1 Then

                    inc = inc + 1
                    NavigateRecords5()

                Else

                    MessageBox.Show("No More Rows")
                    Exit For
                End If
                If countyDetails = countyIDs Then

                    county = ds5.Tables("tblCounty").Rows(inc).Item(1)

                Else
                    Continue For
                End If
            Next
            inc = -1
            w = 1


            '----------------------------------------------------------------------------------------------------------------------------


            userDetails = ds8.Tables("tblGeocache2").Rows(position2).Item(10)
            For w = 1 To MaxRows
                If inc <> MaxRows - 1 Then

                    inc = inc + 1
                    NavigateRecords()

                Else

                    MessageBox.Show("No More Rows")
                    Exit For
                End If
                If userDetails = userIDs Then

                    user = ds.Tables("tblUser").Rows(inc).Item(1)

                Else
                    Continue For
                End If
            Next
            inc = -1
            w = 1

            Dim north As String = ds8.Tables("tblGeocache2").Rows(position2).Item(6)
            Dim west As String = ds8.Tables("tblGeocache2").Rows(position2).Item(7)


            objWriter.WriteLine(ds8.Tables("tblGeocache2").Rows(position2).Item(0) & "," & ds8.Tables("tblGeocache2").Rows(position2).Item(1) & "," & ds8.Tables("tblGeocache2").Rows(position2).Item(2) & "," & Type & "," & Container & "," & ds8.Tables("tblGeocache2").Rows(position2).Item(5) & "," & ds8.Tables("tblGeocache2").Rows(position2).Item(11) & "," & north & "," & west & "," & county & "," & user)
        Next


        objWriter.Close()

        MsgBox("Exported File to " & path)

    End Sub

    Sub prepair()
        For position = 0 To MaxRows6 - 1
            If nameGiven = ds6.Tables("tblList").Rows(position).Item(1) Then
                ID = ds6.Tables("tblList").Rows(position).Item(0)
            End If
        Next

        ds7.Clear()
        con.Open()

        sql7 = "SELECT * From lnkGeocacheList Where [listID]  = """ & ID & """"
        da7 = New OleDb.OleDbDataAdapter(sql7, con)
        da7.Fill(ds7, "lnkGeocacheList")

        con.Close()

        MaxRows7 = ds7.Tables("lnkGeocacheList").Rows.Count


        If MaxRows7 - 1 >= 0 Then
            rowsNeeded = "geocacheID = " & ds7.Tables("lnkGeocacheList").Rows(0).Item(1)
            For position = 1 To MaxRows7 - 1
                rowsNeeded = rowsNeeded & " Or geocacheID = " & ds7.Tables("lnkGeocacheList").Rows(position).Item(1)
            Next

            ds8.Clear()
            con.Open()

            sql8 = "SELECT * From tblGeocache Where " & rowsNeeded
            da8 = New OleDb.OleDbDataAdapter(sql8, con)
            da8.Fill(ds8, "tblGeocache2")

            con.Close()

            MaxRows8 = ds8.Tables("tblGeocache2").Rows.Count
            con.Close()

            ableToExport = True

        Else
            ableToExport = False
        End If

    End Sub




    Private Sub butExport1_Click(sender As Object, e As EventArgs) Handles butExport1.Click
        nameGiven = txtList1.Text
        prepair()

        If ableToExport = True Then
            ExportToExcel()
        Else
            MsgBox("Blank lists cannot be exported")
        End If
    End Sub

    Private Sub butExport2_Click(sender As Object, e As EventArgs) Handles butExport2.Click
        nameGiven = txtList2.Text
        prepair()

        If ableToExport = True Then
            ExportToExcel()
        Else
            MsgBox("Blank lists cannot be exported")
        End If
    End Sub

    Private Sub butExport3_Click(sender As Object, e As EventArgs) Handles butExport3.Click
        nameGiven = txtList3.Text
        prepair()

        If ableToExport = True Then
            ExportToExcel()
        Else
            MsgBox("Blank lists cannot be exported")
        End If
    End Sub

    Private Sub butExport4_Click(sender As Object, e As EventArgs) Handles butExport4.Click
        nameGiven = txtList4.Text
        prepair()

        If ableToExport = True Then
            ExportToExcel()
        Else
            MsgBox("Blank lists cannot be exported")
        End If
    End Sub

    Private Sub butExport5_Click(sender As Object, e As EventArgs) Handles butExport5.Click
        nameGiven = txtList5.Text
        prepair()

        If ableToExport = True Then
            ExportToExcel()
        Else
            MsgBox("Blank lists cannot be exported")
        End If
    End Sub

    Private Sub butExport6_Click(sender As Object, e As EventArgs) Handles butExport6.Click
        nameGiven = txtList6.Text
        prepair()

        If ableToExport = True Then
            ExportToExcel()
        Else
            MsgBox("Blank lists cannot be exported")
        End If
    End Sub

    Private Sub butExport7_Click(sender As Object, e As EventArgs) Handles butExport7.Click
        nameGiven = txtList7.Text
        prepair()

        If ableToExport = True Then
            ExportToExcel()
        Else
            MsgBox("Blank lists cannot be exported")
        End If
    End Sub

    Private Sub butExport8_Click(sender As Object, e As EventArgs) Handles butExport8.Click
        nameGiven = txtList8.Text
        prepair()

        If ableToExport = True Then
            ExportToExcel()
        Else
            MsgBox("Blank lists cannot be exported")
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        nameGiven = txtList9.Text
        prepair()

        If ableToExport = True Then
            ExportToExcel()
        Else
            MsgBox("Blank lists cannot be exported")
        End If
    End Sub

    Private Sub butNewCacheOpen_Click(sender As Object, e As EventArgs) Handles butNewCacheOpen.Click
        AddNew.Show()
        Me.Close()
    End Sub

    Private Sub butAddNew_Click(sender As Object, e As EventArgs) Handles butAddNew.Click
        ListCreate.Show()
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


    Private Sub butLogOut_Click(sender As Object, e As EventArgs) Handles butLogOut.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub butAdminOpen_Click(sender As Object, e As EventArgs) Handles butAdminOpen.Click
        Admin.Show()
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles timClock.Tick
        txtTimer.Text = Format(Now, "HH:mm:ss")
    End Sub

End Class