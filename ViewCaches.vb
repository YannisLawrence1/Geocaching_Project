'geoConfirmation@gmail.com
'Geocache1
Public Class ViewCaches

    Dim i As Integer = 0
    Dim w As Integer = 1
    Dim x As Integer

    Dim userDetails As String
    Dim userIDs As String

    Dim cacheTypeDetails As String
    Dim typeIDs As String

    Dim containnerTypeDetails As String
    Dim containnerTypeIDs As String

    Dim countyDetails As String
    Dim countyIDs As String

    Dim found As Boolean = False

    Protected storedGeocacheNumber As String



    Private Sub ViewCaches_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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




        inc = -1
        geocacheUpdate()

    End Sub

    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    ' ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    '----------------------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------------

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
    '----------------------------------------------------------------------------------------------------------------------------

    Private Sub edit_load()
        For x = 0 To MaxRows2 - 1
            If storedGeocacheNumber = ds2.Tables("tblGeocache").Rows(x).Item(0) Then
                ValStore = x
                Edit2.Show()
                Me.Close()

            End If
        Next
        x = -1
    End Sub


    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    ' ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



    Private Sub butLEnd_Click(sender As Object, e As EventArgs) Handles butLEnd.Click
        If i > 0 Then
            i = 0
            geocacheUpdate()

        Else
            MsgBox("Already at first entrie")
        End If
    End Sub

    '----------------------------------------------------------------------------------------------------------------------------

    Private Sub but50L_Click_1(sender As Object, e As EventArgs) Handles but50L.Click
        If i > 49 Then
            i = i - 49
            geocacheUpdate()

        ElseIf i > 0 Then
            i = 0
            geocacheUpdate()
        Else
            MsgBox("Already at first entrie")
        End If
    End Sub

    '----------------------------------------------------------------------------------------------------------------------------

    Private Sub but5L_Click(sender As Object, e As EventArgs) Handles but5L.Click
        If i > 4 Then
            i = i - 5
            geocacheUpdate()

        ElseIf i > 0 Then
            i = 0
            geocacheUpdate()
        Else
            MsgBox("Already at first entrie")
        End If
    End Sub

    '----------------------------------------------------------------------------------------------------------------------------

    Private Sub but5R_Click(sender As Object, e As EventArgs) Handles but5R.Click
        If i < MaxRows2 - 9 Then
            i = i + 5
            geocacheUpdate()

        ElseIf i + 4 < MaxRows2 - 1 Then
            i = MaxRows2 - 5
            geocacheUpdate()
        Else
            MsgBox("Already at last entrie")
        End If
    End Sub

    '----------------------------------------------------------------------------------------------------------------------------

    Private Sub but50R_Click(sender As Object, e As EventArgs) Handles but50R.Click
        If i < MaxRows2 - 49 Then
            i = i + 50
            geocacheUpdate()

        ElseIf i + 4 < MaxRows2 - 1 Then
            i = MaxRows2 - 5
            geocacheUpdate()
        Else
            MsgBox("Already at last entrie")
        End If
    End Sub

    '----------------------------------------------------------------------------------------------------------------------------

    Private Sub butREnd_Click(sender As Object, e As EventArgs) Handles butREnd.Click
        If i + 4 < MaxRows2 - 1 Then
            i = MaxRows2 - 5
            geocacheUpdate()

        Else
            MsgBox("Already at last entrie")
        End If
    End Sub


    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    ' ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    Private Sub butNewCacheOpen_Click(sender As Object, e As EventArgs) Handles butNewCacheOpen.Click
        AddNew.Show()
        Me.Close()
    End Sub


    Private Sub butEditCacheOpen_Click(sender As Object, e As EventArgs) Handles butEditCacheOpen.Click
        Edit.Show()
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



    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    ' ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



    Private Sub butSearch_Click(sender As Object, e As EventArgs) Handles butSearch.Click
        If radGeocacheNumber.Checked = True Then
            For x = 0 To MaxRows2 - 1
                If txtSearch.Text = ds2.Tables("tblGeocache").Rows(x).Item(0) Then
                    i = x
                    geocacheUpdate()
                    found = True
                    Exit For
                End If
            Next
            x = -1

        ElseIf radChurchMicro.Checked = True Then
            For x = 0 To MaxRows2 - 1
                If txtSearch.Text = ds2.Tables("tblGeocache").Rows(x).Item(1) Then
                    i = x
                    geocacheUpdate()
                    found = True
                    Exit For
                End If
            Next
            x = -1

        ElseIf radCacheName.Checked = True Then
            For x = 0 To MaxRows2 - 1
                If txtSearch.Text = ds2.Tables("tblGeocache").Rows(x).Item(2) Then
                    i = x
                    geocacheUpdate()
                    found = True
                    Exit For
                End If
            Next
            x = -1


        End If

        If found = False Then
            MsgBox("No item with that data found in the database. Please try again")
        Else
            found = False
        End If


    End Sub

    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    ' ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    Sub geocacheUpdate()

        txtPosition.Text = (i + 5 & "/" & MaxRows2)



        If MaxRows2 > i Then
            txtGeocacheNumber1.Text = ds2.Tables("tblGeocache").Rows(i).Item(0)

            txtChurchMicroNumber1.Text = ds2.Tables("tblGeocache").Rows(i).Item(1)

            txtCacheTitle1.Text = ds2.Tables("tblGeocache").Rows(i).Item(2)

            '----------------------------------------------------------------------------------------------------------------------------
            cacheTypeDetails = ds2.Tables("tblGeocache").Rows(i).Item(3)
            For w = 1 To MaxRows3
                If inc <> MaxRows3 - 1 Then

                    inc = inc + 1
                    NavigateRecords3()

                Else

                    MessageBox.Show("No More Rows")
                    Exit For
                End If
                If cacheTypeDetails = typeIDs Then

                    txtCacheType1.Text = ds3.Tables("tblCacheType").Rows(inc).Item(1)
                    Exit For

                Else
                    Continue For
                End If
            Next
            inc = -1
            w = 1
            '----------------------------------------------------------------------------------------------------------------------------
            containnerTypeDetails = ds2.Tables("tblGeocache").Rows(i).Item(4)
            For w = 1 To MaxRows4
                If inc <> MaxRows4 - 1 Then

                    inc = inc + 1
                    NavigateRecords4()

                Else

                    MessageBox.Show("No More Rows")
                    Exit For
                End If
                If containnerTypeDetails = containnerTypeIDs Then

                    txtContainerType1.Text = ds4.Tables("tblContainnerType").Rows(inc).Item(1)
                    Exit For

                Else
                    Continue For
                End If
            Next
            inc = -1
            w = 1
            '----------------------------------------------------------------------------------------------------------------------------
            txtTerrainRaiting1.Text = ds2.Tables("tblGeocache").Rows(i).Item(5) & " / " & ds2.Tables("tblGeocache").Rows(i).Item(12)

            txtNorth1.Text = ds2.Tables("tblGeocache").Rows(i).Item(6)

            txtWest1.Text = ds2.Tables("tblGeocache").Rows(i).Item(7)
            '----------------------------------------------------------------------------------------------------------------------------
            countyDetails = ds2.Tables("tblGeocache").Rows(i).Item(8)
            For w = 1 To MaxRows5
                If inc <> MaxRows5 - 1 Then

                    inc = inc + 1
                    NavigateRecords5()

                Else

                    MessageBox.Show("No More Rows")
                    Exit For
                End If
                If countyDetails = countyIDs Then

                    txtCounty1.Text = ds5.Tables("tblCounty").Rows(inc).Item(1)
                    Exit For

                Else
                    Continue For
                End If
            Next
            inc = -1
            w = 1
            '----------------------------------------------------------------------------------------------------------------------------
            userDetails = ds2.Tables("tblGeocache").Rows(i).Item(10)
            For w = 1 To MaxRows
                If inc <> MaxRows - 1 Then

                    inc = inc + 1
                    NavigateRecords()

                Else

                    MessageBox.Show("No More Rows")
                    Exit For
                End If
                If userDetails = userIDs Then

                    txtAdded1.Text = ds.Tables("tblUser").Rows(inc).Item(1)
                    Exit For

                Else
                    Continue For
                End If
            Next
            inc = -1
            w = 1
            '----------------------------------------------------------------------------------------------------------------------------




            If MaxRows2 > i + 1 Then

                txtGeocacheNumber2.Text = ds2.Tables("tblGeocache").Rows(i + 1).Item(0)

                txtChurchMicroNumber2.Text = ds2.Tables("tblGeocache").Rows(i + 1).Item(1)

                txtCacheTitle2.Text = ds2.Tables("tblGeocache").Rows(i + 1).Item(2)

                '----------------------------------------------------------------------------------------------------------------------------
                cacheTypeDetails = ds2.Tables("tblGeocache").Rows(i + 1).Item(3)
                For w = 1 To MaxRows3
                    If inc <> MaxRows3 - 1 Then

                        inc = inc + 1
                        NavigateRecords3()

                    Else

                        MessageBox.Show("No More Rows")
                        Exit For
                    End If
                    If cacheTypeDetails = typeIDs Then

                        txtCacheType2.Text = ds3.Tables("tblCacheType").Rows(inc).Item(1)
                        Exit For

                    Else
                        Continue For
                    End If
                Next
                inc = -1
                w = 1
                '----------------------------------------------------------------------------------------------------------------------------
                containnerTypeDetails = ds2.Tables("tblGeocache").Rows(i + 1).Item(4)
                For w = 1 To MaxRows4
                    If inc <> MaxRows4 - 1 Then

                        inc = inc + 1
                        NavigateRecords4()

                    Else

                        MessageBox.Show("No More Rows")
                        Exit For
                    End If
                    If containnerTypeDetails = containnerTypeIDs Then

                        txtContainerType2.Text = ds4.Tables("tblContainnerType").Rows(inc).Item(1)
                        Exit For

                    Else
                        Continue For
                    End If
                Next
                inc = -1
                w = 1
                '----------------------------------------------------------------------------------------------------------------------------
                txtTerrainRaiting2.Text = ds2.Tables("tblGeocache").Rows(i + 1).Item(5) & " / " & ds2.Tables("tblGeocache").Rows(i + 1).Item(12)

                txtNorth2.Text = ds2.Tables("tblGeocache").Rows(i + 1).Item(6)

                txtWest2.Text = ds2.Tables("tblGeocache").Rows(i + 1).Item(7)
                '----------------------------------------------------------------------------------------------------------------------------
                countyDetails = ds2.Tables("tblGeocache").Rows(i + 1).Item(8)
                For w = 1 To MaxRows5
                    If inc <> MaxRows5 - 1 Then

                        inc = inc + 1
                        NavigateRecords5()

                    Else

                        MessageBox.Show("No More Rows")
                        Exit For
                    End If
                    If countyDetails = countyIDs Then

                        txtCounty2.Text = ds5.Tables("tblCounty").Rows(inc).Item(1)
                        Exit For

                    Else
                        Continue For
                    End If
                Next
                inc = -1
                w = 1
                '----------------------------------------------------------------------------------------------------------------------------
                userDetails = ds2.Tables("tblGeocache").Rows(i + 1).Item(10)
                For w = 1 To MaxRows
                    If inc <> MaxRows - 1 Then

                        inc = inc + 1
                        NavigateRecords()

                    Else

                        MessageBox.Show("No More Rows")
                        Exit For
                    End If
                    If userDetails = userIDs Then

                        txtAdded2.Text = ds.Tables("tblUser").Rows(inc).Item(1)
                        Exit For

                    Else
                        Continue For
                    End If
                Next
                inc = -1
                w = 1
                '----------------------------------------------------------------------------------------------------------------------------



                '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                ' ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



                If MaxRows2 > i + 2 Then

                    txtGeocacheNumber3.Text = ds2.Tables("tblGeocache").Rows(i + 2).Item(0)

                    txtChurchMicroNumber3.Text = ds2.Tables("tblGeocache").Rows(i + 2).Item(1)

                    txtCacheTitle3.Text = ds2.Tables("tblGeocache").Rows(i + 2).Item(2)

                    '----------------------------------------------------------------------------------------------------------------------------
                    cacheTypeDetails = ds2.Tables("tblGeocache").Rows(i + 2).Item(3)
                    For w = 1 To MaxRows3
                        If inc <> MaxRows3 - 1 Then

                            inc = inc + 1
                            NavigateRecords3()

                        Else

                            MessageBox.Show("No More Rows")
                            Exit For
                        End If
                        If cacheTypeDetails = typeIDs Then

                            txtCacheType3.Text = ds3.Tables("tblCacheType").Rows(inc).Item(1)
                            Exit For

                        Else
                            Continue For
                        End If
                    Next
                    inc = -1
                    w = 1
                    '----------------------------------------------------------------------------------------------------------------------------
                    containnerTypeDetails = ds2.Tables("tblGeocache").Rows(i + 2).Item(4)
                    For w = 1 To MaxRows4
                        If inc <> MaxRows4 - 1 Then

                            inc = inc + 1
                            NavigateRecords4()

                        Else

                            MessageBox.Show("No More Rows")
                            Exit For
                        End If
                        If containnerTypeDetails = containnerTypeIDs Then

                            txtContainerType3.Text = ds4.Tables("tblContainnerType").Rows(inc).Item(1)
                            Exit For

                        Else
                            Continue For
                        End If
                    Next
                    inc = -1
                    w = 1
                    '----------------------------------------------------------------------------------------------------------------------------
                    txtTerrainRaiting3.Text = ds2.Tables("tblGeocache").Rows(i + 2).Item(5) & " / " & ds2.Tables("tblGeocache").Rows(i + 2).Item(12)

                    txtNorth3.Text = ds2.Tables("tblGeocache").Rows(i + 2).Item(6)

                    txtWest3.Text = ds2.Tables("tblGeocache").Rows(i + 2).Item(7)
                    '----------------------------------------------------------------------------------------------------------------------------
                    countyDetails = ds2.Tables("tblGeocache").Rows(i + 2).Item(8)
                    For w = 1 To MaxRows5
                        If inc <> MaxRows5 - 1 Then

                            inc = inc + 1
                            NavigateRecords5()

                        Else

                            MessageBox.Show("No More Rows")
                            Exit For
                        End If
                        If countyDetails = countyIDs Then

                            txtCounty3.Text = ds5.Tables("tblCounty").Rows(inc).Item(1)
                            Exit For

                        Else
                            Continue For
                        End If
                    Next
                    inc = -1
                    w = 1
                    '----------------------------------------------------------------------------------------------------------------------------
                    userDetails = ds2.Tables("tblGeocache").Rows(i + 2).Item(10)
                    For w = 1 To MaxRows
                        If inc <> MaxRows - 1 Then

                            inc = inc + 1
                            NavigateRecords()

                        Else

                            MessageBox.Show("No More Rows")
                            Exit For
                        End If
                        If userDetails = userIDs Then

                            txtAdded3.Text = ds.Tables("tblUser").Rows(inc).Item(1)
                            Exit For

                        Else
                            Continue For
                        End If
                    Next
                    inc = -1
                    w = 1
                    '----------------------------------------------------------------------------------------------------------------------------


                    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    ' ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



                    If MaxRows2 > i + 3 Then

                        txtGeocacheNumber4.Text = ds2.Tables("tblGeocache").Rows(i + 3).Item(0)

                        txtChurchMicroNumber4.Text = ds2.Tables("tblGeocache").Rows(i + 3).Item(1)

                        txtCacheTitle4.Text = ds2.Tables("tblGeocache").Rows(i + 3).Item(2)

                        '----------------------------------------------------------------------------------------------------------------------------
                        cacheTypeDetails = ds2.Tables("tblGeocache").Rows(i + 3).Item(3)
                        For w = 1 To MaxRows3
                            If inc <> MaxRows3 - 1 Then

                                inc = inc + 1
                                NavigateRecords3()

                            Else

                                MessageBox.Show("No More Rows")
                                Exit For
                            End If
                            If cacheTypeDetails = typeIDs Then

                                txtCacheType4.Text = ds3.Tables("tblCacheType").Rows(inc).Item(1)
                                Exit For

                            Else
                                Continue For
                            End If
                        Next
                        inc = -1
                        w = 1
                        '----------------------------------------------------------------------------------------------------------------------------
                        containnerTypeDetails = ds2.Tables("tblGeocache").Rows(i + 3).Item(4)
                        For w = 1 To MaxRows4
                            If inc <> MaxRows4 - 1 Then

                                inc = inc + 1
                                NavigateRecords4()

                            Else

                                MessageBox.Show("No More Rows")
                                Exit For
                            End If
                            If containnerTypeDetails = containnerTypeIDs Then

                                txtContainerType4.Text = ds4.Tables("tblContainnerType").Rows(inc).Item(1)
                                Exit For

                            Else
                                Continue For
                            End If
                        Next
                        inc = -1
                        w = 1
                        '----------------------------------------------------------------------------------------------------------------------------
                        txtTerrainRaiting4.Text = ds2.Tables("tblGeocache").Rows(i + 3).Item(5) & " / " & ds2.Tables("tblGeocache").Rows(i + 3).Item(12)

                        txtNorth4.Text = ds2.Tables("tblGeocache").Rows(i + 3).Item(6)

                        txtWest4.Text = ds2.Tables("tblGeocache").Rows(i + 3).Item(7)
                        '----------------------------------------------------------------------------------------------------------------------------
                        countyDetails = ds2.Tables("tblGeocache").Rows(i + 3).Item(8)
                        For w = 1 To MaxRows5
                            If inc <> MaxRows5 - 1 Then

                                inc = inc + 1
                                NavigateRecords5()

                            Else

                                MessageBox.Show("No More Rows")
                                Exit For
                            End If
                            If countyDetails = countyIDs Then

                                txtCounty4.Text = ds5.Tables("tblCounty").Rows(inc).Item(1)
                                Exit For

                            Else
                                Continue For
                            End If
                        Next
                        inc = -1
                        w = 1
                        '----------------------------------------------------------------------------------------------------------------------------
                        userDetails = ds2.Tables("tblGeocache").Rows(i + 3).Item(10)
                        For w = 1 To MaxRows
                            If inc <> MaxRows - 1 Then

                                inc = inc + 1
                                NavigateRecords()

                            Else

                                MessageBox.Show("No More Rows")
                                Exit For
                            End If
                            If userDetails = userIDs Then

                                txtAdded4.Text = ds.Tables("tblUser").Rows(inc).Item(1)
                                Exit For

                            Else
                                Continue For
                            End If
                        Next
                        inc = -1
                        w = 1
                        '----------------------------------------------------------------------------------------------------------------------------


                        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        ' ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




                        If MaxRows2 > i + 4 Then

                            txtGeocacheNumber5.Text = ds2.Tables("tblGeocache").Rows(i + 4).Item(0)

                            txtChurchMicroNumber5.Text = ds2.Tables("tblGeocache").Rows(i + 4).Item(1)

                            txtCacheTitle5.Text = ds2.Tables("tblGeocache").Rows(i + 4).Item(2)

                            '----------------------------------------------------------------------------------------------------------------------------
                            cacheTypeDetails = ds2.Tables("tblGeocache").Rows(i + 4).Item(3)
                            For w = 1 To MaxRows3
                                If inc <> MaxRows3 - 1 Then

                                    inc = inc + 1
                                    NavigateRecords3()

                                Else

                                    MessageBox.Show("No More Rows")
                                    Exit For
                                End If
                                If cacheTypeDetails = typeIDs Then

                                    txtCacheType5.Text = ds3.Tables("tblCacheType").Rows(inc).Item(1)
                                    Exit For

                                Else
                                    Continue For
                                End If
                            Next
                            inc = -1
                            w = 1
                            '----------------------------------------------------------------------------------------------------------------------------
                            containnerTypeDetails = ds2.Tables("tblGeocache").Rows(i + 4).Item(4)
                            For w = 1 To MaxRows4
                                If inc <> MaxRows4 - 1 Then

                                    inc = inc + 1
                                    NavigateRecords4()

                                Else

                                    MessageBox.Show("No More Rows")
                                    Exit For
                                End If
                                If containnerTypeDetails = containnerTypeIDs Then

                                    txtContainerType5.Text = ds4.Tables("tblContainnerType").Rows(inc).Item(1)
                                    Exit For

                                Else
                                    Continue For
                                End If
                            Next
                            inc = -1
                            w = 1
                            '----------------------------------------------------------------------------------------------------------------------------
                            txtTerrainRaiting5.Text = ds2.Tables("tblGeocache").Rows(i + 4).Item(5) & " / " & ds2.Tables("tblGeocache").Rows(i + 4).Item(12)

                            txtNorth5.Text = ds2.Tables("tblGeocache").Rows(i + 4).Item(6)

                            txtWest5.Text = ds2.Tables("tblGeocache").Rows(i + 4).Item(7)
                            '----------------------------------------------------------------------------------------------------------------------------
                            countyDetails = ds2.Tables("tblGeocache").Rows(i + 4).Item(8)
                            For w = 1 To MaxRows5
                                If inc <> MaxRows5 - 1 Then

                                    inc = inc + 1
                                    NavigateRecords5()

                                Else

                                    MessageBox.Show("No More Rows")
                                    Exit For
                                End If
                                If countyDetails = countyIDs Then

                                    txtCounty5.Text = ds5.Tables("tblCounty").Rows(inc).Item(1)
                                    Exit For

                                Else
                                    Continue For
                                End If
                            Next
                            inc = -1
                            w = 1
                            '----------------------------------------------------------------------------------------------------------------------------
                            userDetails = ds2.Tables("tblGeocache").Rows(i + 4).Item(10)
                            For w = 1 To MaxRows
                                If inc <> MaxRows - 1 Then

                                    inc = inc + 1
                                    NavigateRecords()

                                Else

                                    MessageBox.Show("No More Rows")
                                    Exit For
                                End If
                                If userDetails = userIDs Then

                                    txtAdded5.Text = ds.Tables("tblUser").Rows(inc).Item(1)
                                    Exit For

                                Else
                                    Continue For
                                End If
                            Next
                            inc = -1
                            w = 1
                            '----------------------------------------------------------------------------------------------------------------------------


                        Else
                            txtAdded5.Text = ("")
                            txtCacheTitle5.Text = ("")
                            txtCacheType5.Text = ("")
                            txtChurchMicroNumber5.Text = ("")
                            txtContainerType5.Text = ("")
                            txtCounty5.Text = ("")
                            txtGeocacheNumber5.Text = ("")
                            txtNorth5.Text = ("")
                            txtTerrainRaiting5.Text = ("")
                            txtWest5.Text = ("")

                            txtPosition.Text = (i + 4 & "/" & MaxRows2)

                            '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            ' ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



                        End If

                    Else

                        txtAdded4.Text = ("")
                        txtCacheTitle4.Text = ("")
                        txtCacheType4.Text = ("")
                        txtChurchMicroNumber4.Text = ("")
                        txtContainerType4.Text = ("")
                        txtCounty4.Text = ("")
                        txtGeocacheNumber4.Text = ("")
                        txtNorth4.Text = ("")
                        txtTerrainRaiting4.Text = ("")
                        txtWest4.Text = ("")
                        '----------------------------------------------------------------------------------------------------------------------------
                        txtAdded5.Text = ("")
                        txtCacheTitle5.Text = ("")
                        txtCacheType5.Text = ("")
                        txtChurchMicroNumber5.Text = ("")
                        txtContainerType5.Text = ("")
                        txtCounty5.Text = ("")
                        txtGeocacheNumber5.Text = ("")
                        txtNorth5.Text = ("")
                        txtTerrainRaiting5.Text = ("")
                        txtWest5.Text = ("")
                        '----------------------------------------------------------------------------------------------------------------------------
                        txtPosition.Text = (i + 3 & "/" & MaxRows2)


                    End If

                Else

                    txtAdded3.Text = ("")
                    txtCacheTitle3.Text = ("")
                    txtCacheType3.Text = ("")
                    txtChurchMicroNumber3.Text = ("")
                    txtContainerType3.Text = ("")
                    txtCounty3.Text = ("")
                    txtGeocacheNumber3.Text = ("")
                    txtNorth3.Text = ("")
                    txtTerrainRaiting3.Text = ("")
                    txtWest3.Text = ("")
                    '----------------------------------------------------------------------------------------------------------------------------
                    txtAdded4.Text = ("")
                    txtCacheTitle4.Text = ("")
                    txtCacheType4.Text = ("")
                    txtChurchMicroNumber4.Text = ("")
                    txtContainerType4.Text = ("")
                    txtCounty4.Text = ("")
                    txtGeocacheNumber4.Text = ("")
                    txtNorth4.Text = ("")
                    txtTerrainRaiting4.Text = ("")
                    txtWest4.Text = ("")
                    '----------------------------------------------------------------------------------------------------------------------------
                    txtAdded5.Text = ("")
                    txtCacheTitle5.Text = ("")
                    txtCacheType5.Text = ("")
                    txtChurchMicroNumber5.Text = ("")
                    txtContainerType5.Text = ("")
                    txtCounty5.Text = ("")
                    txtGeocacheNumber5.Text = ("")
                    txtNorth5.Text = ("")
                    txtTerrainRaiting5.Text = ("")
                    txtWest5.Text = ("")
                    '----------------------------------------------------------------------------------------------------------------------------
                    txtPosition.Text = (i + 2 & "/" & MaxRows2)



                End If


            Else
                txtAdded2.Text = ("")
                txtCacheTitle2.Text = ("")
                txtCacheType2.Text = ("")
                txtChurchMicroNumber2.Text = ("")
                txtContainerType2.Text = ("")
                txtCounty2.Text = ("")
                txtGeocacheNumber2.Text = ("")
                txtNorth2.Text = ("")
                txtTerrainRaiting2.Text = ("")
                txtWest2.Text = ("")
                '----------------------------------------------------------------------------------------------------------------------------
                txtAdded3.Text = ("")
                txtCacheTitle3.Text = ("")
                txtCacheType3.Text = ("")
                txtChurchMicroNumber3.Text = ("")
                txtContainerType3.Text = ("")
                txtCounty3.Text = ("")
                txtGeocacheNumber3.Text = ("")
                txtNorth3.Text = ("")
                txtTerrainRaiting3.Text = ("")
                txtWest3.Text = ("")
                '----------------------------------------------------------------------------------------------------------------------------
                txtAdded4.Text = ("")
                txtCacheTitle4.Text = ("")
                txtCacheType4.Text = ("")
                txtChurchMicroNumber4.Text = ("")
                txtContainerType4.Text = ("")
                txtCounty4.Text = ("")
                txtGeocacheNumber4.Text = ("")
                txtNorth4.Text = ("")
                txtTerrainRaiting4.Text = ("")
                txtWest4.Text = ("")
                '----------------------------------------------------------------------------------------------------------------------------
                txtAdded5.Text = ("")
                txtCacheTitle5.Text = ("")
                txtCacheType5.Text = ("")
                txtChurchMicroNumber5.Text = ("")
                txtContainerType5.Text = ("")
                txtCounty5.Text = ("")
                txtGeocacheNumber5.Text = ("")
                txtNorth5.Text = ("")
                txtTerrainRaiting5.Text = ("")
                txtWest5.Text = ("")
                '----------------------------------------------------------------------------------------------------------------------------
                txtPosition.Text = (i + 1 & "/" & MaxRows2)




            End If


        Else
            txtAdded1.Text = ("")
            txtCacheTitle1.Text = ("")
            txtCacheType1.Text = ("")
            txtChurchMicroNumber1.Text = ("")
            txtContainerType1.Text = ("")
            txtCounty1.Text = ("")
            txtGeocacheNumber1.Text = ("")
            txtNorth1.Text = ("")
            txtTerrainRaiting1.Text = ("")
            txtWest1.Text = ("")
            '----------------------------------------------------------------------------------------------------------------------------

        End If

    End Sub

    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    ' ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    'AIzaSyBNV_s_sX31QZ33SpTq2Zyw2UpjzTZ3HSA api key plz dont steal
    'DD = d + (min/60)
    '53.3781° N, 1.4360° W
    Dim Store As String


    Dim Hours As Integer
    Dim Mins As Decimal

    Dim northArray() As Char
    Dim westArray() As Char

    Dim foundMin As Boolean

    Dim positionCheck As Integer

    Dim north As Decimal
    Dim west As Decimal

    Dim isNegative As Boolean
    Dim lengthN As Integer
    Dim lengthW As Integer
    Dim title As String

    Dim northCo As String
    Dim westCo As String
    Dim gcNumber As String
    Dim cmNumber As String
    Dim type As String
    Dim geoPosition As Integer

    Private Sub northCheck()
        For positionCheck = 1 To lengthN - 1
            If foundMin = True Then

                Store = Store + northArray(positionCheck)

            Else
                If northArray(positionCheck) = "°" Then
                    Hours = Store
                    foundMin = True
                    Store = ""
                Else
                    Store = Store + northArray(positionCheck)

                End If
            End If

        Next

        Mins = Store
        north = Hours + (Mins / 60)

        positionCheck = 0
        foundMin = False
        Store = ""

    End Sub

    Private Sub WestCheck()
        If westArray(0) = "W" Then
            isNegative = True
        End If

        For positionCheck = 1 To lengthW - 1
            If foundMin = True Then

                Store = Store + westArray(positionCheck)

            Else
                If westArray(positionCheck) = "°" Then
                    Hours = Store
                    foundMin = True
                    Store = ""
                Else
                    Store = Store + westArray(positionCheck)

                End If
            End If

        Next

        Mins = Store
        If isNegative = True Then
            west = -(Hours + (Mins / 60))
        Else
            west = Hours + (Mins / 60)
        End If

        positionCheck = 0
        foundMin = False
        Store = ""

    End Sub

    Private Sub generateMap()
        'ensure the file exists
        My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\runMap.htm", My.Resources.runMap, False)
        Dim htmPath As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\runMap.htm"
        'clear the file
        System.IO.File.WriteAllText(htmPath, "")
        'open in append mode so that data can be written to it
        FileOpen(1, htmPath, OpenMode.Append)

        'write this html to the file
        PrintLine(1, "<!DOCTYPE html>")
        PrintLine(1, "<html>")
        PrintLine(1, "<head>")
        PrintLine(1, "<style>")
        'Set the size of the div element that contains the map
        PrintLine(1, "#map {")
        PrintLine(1, "height: 650px;") ' The height is 650 pixels
        PrintLine(1, "width: 1156px;") 'The width is the width of the web page 
        PrintLine(1, "}")
        PrintLine(1, "</style>")
        PrintLine(1, "</head>")

        PrintLine(1, "<body>")
        PrintLine(1, "<h3>Geocache: " & title & "</h3>")
        '<!--The div element for the map -->
        PrintLine(1, "<div id=""map""></div>")
        PrintLine(1, "<script>")
        'Initialize and add the map
        PrintLine(1, "function initMap() {")
        'The location of Uluru
        PrintLine(1, "var Geocache = {lat: " & north & ", lng: " & west & "};")
        'The map, centered at the location
        PrintLine(1, "var map = new google.maps.Map(")
        PrintLine(1, "document.getElementById('map'), {zoom: 10, center: Geocache});")
        'The marker, positioned at the location

        PrintLine(1, "var infowindow = new google.maps.InfoWindow({")
        PrintLine(1, "content: ""<span>Name: " & title & "<br>GC number: " & gcNumber & "<br>CM number: " & cmNumber & "<br>Cache type: " & type & "<br>Location: " & northCo & " , " & westCo & "</span>""")
        PrintLine(1, "});")

        PrintLine(1, "var marker = new google.maps.Marker({")
        PrintLine(1, "position: Geocache,")
        PrintLine(1, "map: map,")
        PrintLine(1, "});")

        PrintLine(1, "google.maps.event.addListener(marker, 'click', function() {")
        PrintLine(1, "infowindow.open(map,marker);")
        PrintLine(1, "});")
        PrintLine(1, "}")

        PrintLine(1, "</script>")
        '<!--Load the API from the specified URL
        'The async attribute allows the browser to render the page while the API loads
        ' The key parameter will contain your own API key (which Is Not needed for this tutorial)
        ' The callback parameter executes the initMap() function
        PrintLine(1, "<script async defer")
        PrintLine(1, "src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyBNV_s_sX31QZ33SpTq2Zyw2UpjzTZ3HSA&callback=initMap"">")
        PrintLine(1, "</script>")
        PrintLine(1, "</body>")
        PrintLine(1, "</html>")
        PrintLine(1, "")


        'close the file
        FileClose(1)

        'run the html created in the embedded resource
        Process.Start(htmPath)
    End Sub



    Private Sub butViewOnMap_Click(sender As Object, e As EventArgs) Handles butViewOnMap.Click
        If txtNorth1.Text = "" Then

        Else
            northArray = (txtNorth1.Text).ToCharArray
            lengthN = Len(txtNorth1.Text)
            lengthW = Len(txtWest1.Text)
            westArray = (txtWest1.Text).ToCharArray
            title = txtCacheTitle1.Text

            northCo = txtNorth1.Text
            westCo = txtWest1.Text
            gcNumber = txtGeocacheNumber1.Text
            cmNumber = txtChurchMicroNumber1.Text
            type = txtCacheType1.Text

            northCheck()
            WestCheck()
            generateMap()
        End If

    End Sub

    Private Sub butViewOnMap2_Click(sender As Object, e As EventArgs) Handles butViewOnMap2.Click
        If txtNorth2.Text = "" Then

        Else
            northArray = (txtNorth2.Text).ToCharArray
            lengthN = Len(txtNorth2.Text)
            lengthW = Len(txtWest2.Text)
            westArray = (txtWest2.Text).ToCharArray
            title = txtCacheTitle2.Text

            northCo = txtNorth2.Text
            westCo = txtWest2.Text
            gcNumber = txtGeocacheNumber2.Text
            cmNumber = txtChurchMicroNumber2.Text
            type = txtCacheType2.Text

            northCheck()
            WestCheck()
            generateMap()
        End If


    End Sub

    Private Sub butViewOnMap3_Click(sender As Object, e As EventArgs) Handles butViewOnMap3.Click
        If txtNorth3.Text = "" Then

        Else
            northArray = (txtNorth3.Text).ToCharArray
            lengthN = Len(txtNorth3.Text)
            lengthW = Len(txtWest3.Text)
            westArray = (txtWest3.Text).ToCharArray
            title = txtCacheTitle3.Text

            northCo = txtNorth3.Text
            westCo = txtWest3.Text
            gcNumber = txtGeocacheNumber3.Text
            cmNumber = txtChurchMicroNumber3.Text
            type = txtCacheType3.Text

            northCheck()
            WestCheck()
            generateMap()
        End If


    End Sub

    Private Sub butViewOnMap4_Click(sender As Object, e As EventArgs) Handles butViewOnMap4.Click
        If txtNorth4.Text = "" Then


        Else
            northArray = (txtNorth4.Text).ToCharArray
            lengthN = Len(txtNorth4.Text)
            lengthW = Len(txtWest4.Text)
            westArray = (txtWest4.Text).ToCharArray
            title = txtCacheTitle4.Text

            northCo = txtNorth4.Text
            westCo = txtWest4.Text
            gcNumber = txtGeocacheNumber4.Text
            cmNumber = txtChurchMicroNumber4.Text
            type = txtCacheType4.Text

            northCheck()
            WestCheck()
            generateMap()
        End If

    End Sub

    Private Sub butViewOnMap5_Click(sender As Object, e As EventArgs) Handles butViewOnMap5.Click
        If txtNorth5.Text = "" Then

        Else
            northArray = (txtNorth5.Text).ToCharArray
            lengthN = Len(txtNorth5.Text)
            lengthW = Len(txtWest5.Text)
            westArray = (txtWest5.Text).ToCharArray
            title = txtCacheTitle5.Text

            northCo = txtNorth5.Text
            westCo = txtWest5.Text
            gcNumber = txtGeocacheNumber5.Text
            cmNumber = txtChurchMicroNumber5.Text
            type = txtCacheType5.Text

            northCheck()
            WestCheck()
            generateMap()
        End If

    End Sub


    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    ' ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    Private Sub butEdit1_Click(sender As Object, e As EventArgs) Handles butEdit1.Click

        storedGeocacheNumber = txtGeocacheNumber1.Text
        edit_load()

    End Sub

    Private Sub butEdit2_Click(sender As Object, e As EventArgs) Handles butEdit2.Click

        storedGeocacheNumber = txtGeocacheNumber2.Text
        edit_load()

    End Sub

    Private Sub butEdit3_Click(sender As Object, e As EventArgs) Handles butEdit3.Click

        storedGeocacheNumber = txtGeocacheNumber3.Text
        edit_load()

    End Sub

    Private Sub butEdit4_Click(sender As Object, e As EventArgs) Handles butEdit4.Click

        storedGeocacheNumber = txtGeocacheNumber4.Text
        edit_load()

    End Sub

    Private Sub butEdit5_Click(sender As Object, e As EventArgs) Handles butEdit5.Click

        storedGeocacheNumber = txtGeocacheNumber5.Text
        edit_load()

    End Sub

    Dim nStore As String
    Dim wStore As String
    Dim name As String
    Dim typeStore As String
    Dim type_ As String

    Private Sub butAllMap_Click(sender As Object, e As EventArgs) Handles butAllMap.Click
        'ensure the file exists
        My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\runMap.htm", My.Resources.runMap, False)
        Dim htmPath As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\runMap.htm"
        'clear the file
        System.IO.File.WriteAllText(htmPath, "")
        'open in append mode so that data can be written to it
        FileOpen(1, htmPath, OpenMode.Append)


        PrintLine(1, "<!DOCTYPE html>")
        PrintLine(1, "<html>")
        PrintLine(1, "<head>")
        PrintLine(1, "<meta http-equiv=""content-type"" content=""text/html; charset=UTF-8"" />")
        PrintLine(1, "<title>All Geocaches</title>")
        PrintLine(1, "</head>")
        PrintLine(1, "<body>")

        '<!--Load the API from the specified URL
        ' The key parameter will contain your own API key (which Is Not needed for this tutorial)
        ' The callback parameter executes the initMap() function
        PrintLine(1, "<script")
        PrintLine(1, "src='https://maps.googleapis.com/maps/api/js?key=AIzaSyBNV_s_sX31QZ33SpTq2Zyw2UpjzTZ3HSA&callback=initMap'")
        PrintLine(1, "type='text/javascript'></script>")

        PrintLine(1, "<div id=""map"" style=""width: 1156px; height: 650px;""></div>")

        PrintLine(1, "<script type=""text/javascript"">")
        PrintLine(1, "var locations = [")

        For geoPosition = 0 To MaxRows2 - 1
            northArray = (ds2.Tables("tblGeocache").Rows(geoPosition).Item(6)).ToCharArray
            lengthN = Len(ds2.Tables("tblGeocache").Rows(geoPosition).Item(6))
            lengthW = Len(ds2.Tables("tblGeocache").Rows(geoPosition).Item(7))
            westArray = (ds2.Tables("tblGeocache").Rows(geoPosition).Item(7)).ToCharArray

            nStore = ds2.Tables("tblGeocache").Rows(geoPosition).Item(6)
            wStore = ds2.Tables("tblGeocache").Rows(geoPosition).Item(7)

            name = ds2.Tables("tblGeocache").Rows(geoPosition).Item(2)

            nStore = Replace(nStore, "°", "&#176;")
            wStore = Replace(wStore, "°", "&#176;")

            name = Replace(name, "…", "&#8230;")

            typeStore = ds2.Tables("tblGeocache").Rows(geoPosition).Item(3)

            For w = 1 To MaxRows3
                If inc <> MaxRows3 - 1 Then

                    inc = inc + 1
                    NavigateRecords3()

                Else

                    MessageBox.Show("No More Rows")
                    Exit For
                End If
                If typeIDs = typeStore Then

                    type_ = ds3.Tables("tblCacheType").Rows(inc).Item(1)

                Else
                    Continue For
                End If
            Next
            inc = -1
            w = 1



            northCheck()
            WestCheck()
            If geoPosition < MaxRows2 - 1 Then
                PrintLine(1, "['<span>Name: " & name & "<br>GC number: " & ds2.Tables("tblGeocache").Rows(geoPosition).Item(0) & "<br>CM number: " & ds2.Tables("tblGeocache").Rows(geoPosition).Item(1) & "<br>Cache type: " & type_ & "<br>Location: " & nStore & " , " & wStore & "', " & north & ", " & west & ", " & geoPosition + 1 & "],")
            Else
                PrintLine(1, "['<span>Name: " & name & "<br>GC number: " & ds2.Tables("tblGeocache").Rows(geoPosition).Item(0) & "<br>CM number: " & ds2.Tables("tblGeocache").Rows(geoPosition).Item(1) & "<br>Cache type: " & type_ & "<br>Location: " & nStore & " , " & wStore & "', " & north & ", " & west & ", " & geoPosition + 1 & "]")
            End If
        Next
        PrintLine(1, "];")

        PrintLine(1, "var map = new google.maps.Map(document.getElementById('map'), {")
        PrintLine(1, "zoom: 6,")
        PrintLine(1, "center: new google.maps.LatLng(53.3781, -1.4360, 151.25)")
        PrintLine(1, "});")

        PrintLine(1, "var infowindow = new google.maps.InfoWindow();")

        PrintLine(1, "var marker, i;")

        PrintLine(1, "for (i = 0; i < locations.length; i++) { ")
        PrintLine(1, "marker = new google.maps.Marker({")
        PrintLine(1, "position: new google.maps.LatLng(locations[i][1], locations[i][2]),")
        PrintLine(1, "map: map")
        PrintLine(1, "});")

        PrintLine(1, "google.maps.event.addListener(marker, 'click', (function(marker, i) {")
        PrintLine(1, "return function() {")
        PrintLine(1, "infowindow.setContent(locations[i][0]);")
        PrintLine(1, "infowindow.open(map, marker);")
        PrintLine(1, "}")
        PrintLine(1, "})(marker, i));")
        PrintLine(1, "}")
        PrintLine(1, "</script>")
        PrintLine(1, "</body>")



        PrintLine(1, "</body>")
        PrintLine(1, "</html>")
        PrintLine(1, "")


        'close the file
        FileClose(1)

        'run the html created in the embedded resource
        Process.Start(htmPath)
    End Sub

    Private Sub butNotes1_Click(sender As Object, e As EventArgs) Handles butNotes1.Click
        MsgBox(ds2.Tables("tblGeocache").Rows(i).Item(9))
    End Sub



    Private Sub butNotes2_Click(sender As Object, e As EventArgs) Handles butNotes2.Click
        If String.IsNullOrEmpty(txtGeocacheNumber2.Text) Then

        Else
            MsgBox(ds2.Tables("tblGeocache").Rows(i + 1).Item(9))
        End If
    End Sub



    Private Sub butNotes3_Click(sender As Object, e As EventArgs) Handles butNotes3.Click
        If String.IsNullOrEmpty(txtGeocacheNumber3.Text) Then

        Else
            MsgBox(ds2.Tables("tblGeocache").Rows(i + 2).Item(9))
        End If
    End Sub



    Private Sub butNotes4_Click(sender As Object, e As EventArgs) Handles butNotes4.Click
        If String.IsNullOrEmpty(txtGeocacheNumber4.Text) Then

        Else
            MsgBox(ds2.Tables("tblGeocache").Rows(i + 3).Item(9))
        End If
    End Sub



    Private Sub butView5_Click(sender As Object, e As EventArgs) Handles butView5.Click
        If String.IsNullOrEmpty(txtGeocacheNumber5.Text) Then

        Else
            MsgBox(ds2.Tables("tblGeocache").Rows(i + 4).Item(9))
        End If
    End Sub

    Private Sub butAddToList_Click(sender As Object, e As EventArgs) Handles butAddToList.Click
        CacheIDStore = ds2.Tables("tblGeocache").Rows(i).Item(11)
        CacheNameStore = ds2.Tables("tblGeocache").Rows(i).Item(2)
        AddToList.Show()
        Me.Close()
    End Sub

    Private Sub butAddToList2_Click(sender As Object, e As EventArgs) Handles butAddToList2.Click
        CacheIDStore = ds2.Tables("tblGeocache").Rows(i + 1).Item(11)
        CacheNameStore = ds2.Tables("tblGeocache").Rows(i + 1).Item(2)
        AddToList.Show()
        Me.Close()
    End Sub

    Private Sub butAddToList3_Click(sender As Object, e As EventArgs) Handles butAddToList3.Click
        CacheIDStore = ds2.Tables("tblGeocache").Rows(i + 2).Item(11)
        CacheNameStore = ds2.Tables("tblGeocache").Rows(i + 2).Item(2)
        AddToList.Show()
        Me.Close()
    End Sub

    Private Sub butAddToList4_Click(sender As Object, e As EventArgs) Handles butAddToList4.Click
        CacheIDStore = ds2.Tables("tblGeocache").Rows(i + 3).Item(11)
        CacheNameStore = ds2.Tables("tblGeocache").Rows(i + 3).Item(2)
        AddToList.Show()
        Me.Close()
    End Sub

    Private Sub butAddToList5_Click(sender As Object, e As EventArgs) Handles butAddToList5.Click
        CacheIDStore = ds2.Tables("tblGeocache").Rows(i + 4).Item(11)
        CacheNameStore = ds2.Tables("tblGeocache").Rows(i + 4).Item(2)
        AddToList.Show()
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles timClock.Tick
        txtTimer.Text = Format(Now, "HH:mm:ss")
    End Sub
End Class
