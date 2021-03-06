Imports System.Text.RegularExpressions
Public Class Edit2
    Dim cacheTypeDetails As String
    Dim typeValues As String
    Dim w As Integer

    Dim ContainnerTypeValues As String
    Dim containnerTypeDetails As String

    Dim countyDetails As String
    Dim countyValues As String

    Dim CoOrdinateString As String
    Dim CoOrdinateArray() As Char
    Dim coOrdinateLength As Integer
    Dim lengthDigit As Integer
    Dim ispassed As Boolean

    Dim x As Integer = 0
    Dim existingGeocacheNumber As Boolean
    Dim existingChurchMicro As Boolean

    Private Function isValidGeocacheNumber(ByVal str As String) As Boolean

        Return Regex.IsMatch(str, "^GC[A-Z1-9]+")

    End Function

    Private Function isValidChurchMicroNumber(ByVal str As String) As Boolean

        Return Regex.IsMatch(str, "^CM[1-9]+")

    End Function

    Private Function isValidCoOrdinate1(ByVal str As String) As Boolean

        Return Regex.IsMatch(str, "^[0-9]+")

    End Function

    Private Function isValidCoOrdinate2(ByVal str As String) As Boolean

        Return Regex.IsMatch(str, "^[0-9]+.[1-9]+")

    End Function

    Private Sub NavigateRecords3()
        typeValues = ds3.Tables("tblCacheType").Rows(inc).Item(0)
    End Sub

    Private Sub NavigateRecords4()
        ContainnerTypeValues = ds4.Tables("tblContainnerType").Rows(inc).Item(0)
    End Sub

    Private Sub NavigateRecords5()
        countyValues = ds5.Tables("tblCounty").Rows(inc).Item(0)
    End Sub




    Private Sub NavigateRecords3_2()
        typeValues = ds3.Tables("tblCacheType").Rows(inc).Item(1)
    End Sub

    Private Sub NavigateRecords4_2()
        ContainnerTypeValues = ds4.Tables("tblContainnerType").Rows(inc).Item(1)
    End Sub

    Private Sub NavigateRecords5_2()
        countyValues = ds5.Tables("tblCounty").Rows(inc).Item(1)
    End Sub

    Private Sub Edit2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timClock.Enabled = True
        txtUserNameDisplay.Text = userStore

        If access = "ace1" Then
            txtLevelOfAccessDisplay.Text = "Level of Access: Read only"

            butNewCacheOpen.Enabled = False

            butEditCacheOpen.Enabled = False

            butAdminOpen.Enabled = False

            butDelete.Enabled = False


        ElseIf access = "ace2" Then
            txtLevelOfAccessDisplay.Text = "Level of Access: Read and write"

            butNewCacheOpen.Enabled = True

            butEditCacheOpen.Enabled = False

            butAdminOpen.Enabled = False

            butDelete.Enabled = False


        ElseIf access = "ace3" Then
            txtLevelOfAccessDisplay.Text = "Level of Access: Read, write and edit"

            butNewCacheOpen.Enabled = True

            butEditCacheOpen.Enabled = True

            butAdminOpen.Enabled = False

            butDelete.Enabled = True

        Else
            txtLevelOfAccessDisplay.Text = "Level of Access: Admin"

            butNewCacheOpen.Enabled = True

            butEditCacheOpen.Enabled = True

            butAdminOpen.Enabled = True

            butDelete.Enabled = True

        End If

        txtGeocacheNumber.Text = ds2.Tables("tblGeocache").Rows(ValStore).Item(0)
        txtChurchMicroNumber.Text = ds2.Tables("tblGeocache").Rows(ValStore).Item(1)
        txtCacheTitle.Text = ds2.Tables("tblGeocache").Rows(ValStore).Item(2)

        cacheTypeDetails = ds2.Tables("tblGeocache").Rows(ValStore).Item(3)
        For w = 1 To MaxRows3
            If inc <> MaxRows3 - 1 Then

                inc = inc + 1
                NavigateRecords3()

            Else

                MessageBox.Show("No More Rows")
                Exit For
            End If
            If cacheTypeDetails = typeValues Then
                comCacheType.SelectedItem = ds3.Tables("tblCacheType").Rows(inc).Item(1)

            Else
                Continue For
            End If
        Next
        inc = -1
        w = 1


        containnerTypeDetails = ds2.Tables("tblGeocache").Rows(ValStore).Item(4)
        For w = 1 To MaxRows4
            If inc <> MaxRows4 - 1 Then

                inc = inc + 1
                NavigateRecords4()

            Else

                MessageBox.Show("No More Rows")
                Exit For
            End If
            If containnerTypeDetails = ContainnerTypeValues Then
                comContainerType.SelectedItem = ds4.Tables("tblContainnerType").Rows(inc).Item(1)

            Else
                Continue For
            End If
        Next
        inc = -1
        w = 1

        numTerrainRaiting.Value = ds2.Tables("tblGeocache").Rows(ValStore).Item(5)

        countyDetails = ds2.Tables("tblGeocache").Rows(ValStore).Item(8)
        For w = 1 To MaxRows5
            If inc <> MaxRows5 - 1 Then

                inc = inc + 1
                NavigateRecords5()

            Else

                MessageBox.Show("No More Rows")
                Exit For
            End If
            If countyDetails = countyValues Then

                comCounty.SelectedItem = ds5.Tables("tblCounty").Rows(inc).Item(1)

            Else
                Continue For
            End If
        Next
        inc = -1
        w = 1

        CoOrdinateString = ds2.Tables("tblGeocache").Rows(ValStore).Item(6)
        CoOrdinateArray = CoOrdinateString.ToCharArray
        coOrdinateLength = Len(CoOrdinateString)


        For lengthDigit = 1 To coOrdinateLength - 1
            If ispassed = True Then
                txtNorth2.Text = txtNorth2.Text + CoOrdinateArray(lengthDigit)
            Else

                If CoOrdinateArray(lengthDigit) = "°" Then
                    ispassed = True
                Else
                    txtNorth1.Text = txtNorth1.Text + CoOrdinateArray(lengthDigit)
                End If

            End If

        Next
        lengthDigit = 0
        ispassed = False

        CoOrdinateString = ds2.Tables("tblGeocache").Rows(ValStore).Item(7)
        CoOrdinateArray = CoOrdinateString.ToCharArray
        coOrdinateLength = Len(CoOrdinateString)

        If CoOrdinateArray(0) = "W" Then
            radW.Checked = True
        Else
            radE.Checked = True
        End If


        For lengthDigit = 1 To coOrdinateLength - 1
            If ispassed = True Then
                txtWest2.Text = txtWest2.Text + CoOrdinateArray(lengthDigit)
            Else

                If CoOrdinateArray(lengthDigit) = "°" Then
                    ispassed = True
                Else
                    txtWest1.Text = txtWest1.Text + CoOrdinateArray(lengthDigit)
                End If

            End If

        Next


        txtGeocacheNotes.Text = ds2.Tables("tblGeocache").Rows(ValStore).Item(9)
    End Sub



    Private Sub butSubmit_Click_1(sender As Object, e As EventArgs) Handles butSubmit.Click

        If txtGeocacheNumber.Text = ds2.Tables("tblGeocache").Rows(ValStore).Item(0) Then

            existingGeocacheNumber = False
        Else

            For x = 0 To MaxRows2 - 1
                If txtGeocacheNumber.Text = ds2.Tables("tblGeocache").Rows(x).Item(0) Then
                    existingGeocacheNumber = True
                End If
            Next

        End If
        x = -1



        If txtChurchMicroNumber.Text = ds2.Tables("tblGeocache").Rows(ValStore).Item(1) Then

            existingChurchMicro = False
        Else

            For x = 0 To MaxRows2 - 1
                If txtChurchMicroNumber.Text = ds2.Tables("tblGeocache").Rows(x).Item(1) Then
                    existingChurchMicro = True
                End If
            Next

        End If
        x = -1

        If String.IsNullOrEmpty(txtGeocacheNumber.Text) Then
            MsgBox("No input found for geocache number, please make sure an input is entered.")

        ElseIf String.IsNullOrEmpty(txtChurchMicroNumber.Text) Then
            MsgBox("No input found for church micro number, please make sure an input is entered.")

        ElseIf String.IsNullOrEmpty(txtCacheTitle.Text) Then
            MsgBox("No input found for cache title, please make sure an input is entered.")

        ElseIf String.IsNullOrEmpty(txtChurchMicroNumber.Text) Then
            MsgBox("No input found for church micro number, please make sure an input is entered.")

        ElseIf String.IsNullOrEmpty(comCacheType.Text) Then
            MsgBox("No input found for cache type, please make sure an input is entered.")

        ElseIf String.IsNullOrEmpty(comContainerType.Text) Then
            MsgBox("No input found for container type, please make sure an input is entered.")

        ElseIf String.IsNullOrEmpty(comCounty.Text) Then
            MsgBox("No input found for county, please make sure an input is entered.")

        ElseIf String.IsNullOrEmpty(txtNorth1.Text) Then
            MsgBox("No input found for north co-ordinate, please make sure an input is entered.")

        ElseIf String.IsNullOrEmpty(txtNorth2.Text) Then
            MsgBox("No input found for north co-ordinate, please make sure an input is entered.")

        ElseIf String.IsNullOrEmpty(txtWest1.Text) Then
            MsgBox("No input found for east/west co-ordinate, please make sure an input is entered.")

        ElseIf String.IsNullOrEmpty(txtWest2.Text) Then
            MsgBox("No input found for east/west co-ordinate, please make sure an input is entered.")

        ElseIf radE.Checked = False And radW.Checked = False Then
            MsgBox("No input for if the co-ordinate is west or east")
        Else

            If Len(txtGeocacheNumber.Text) = 7 And isValidGeocacheNumber(txtGeocacheNumber.Text) = True Then

                If existingGeocacheNumber = True Then
                    MsgBox("a cache with that Geocache number already exists please use a diffrent geocache number")
                Else


                    If Len(txtChurchMicroNumber.Text) > 2 And Len(txtChurchMicroNumber.Text) < 8 And isValidChurchMicroNumber(txtChurchMicroNumber.Text) = True Then

                        If existingChurchMicro = False Then

                            If Len(txtCacheTitle.Text) < 257 Then


                                If numTerrainRaiting.Value Mod 0.5 = 0 Then


                                    If isValidCoOrdinate1(txtNorth1.Text) = True And isValidCoOrdinate2(txtNorth2.Text) = True Then


                                        If isValidCoOrdinate1(txtWest1.Text) = True And isValidCoOrdinate2(txtWest2.Text) = True Then



                                            Dim cb As New OleDb.OleDbCommandBuilder(da2)

                                            cb.QuotePrefix = "["
                                            cb.QuoteSuffix = "]"


                                            ds2.Tables("tblGeocache").Rows(ValStore).Item(0) = txtGeocacheNumber.Text
                                            ds2.Tables("tblGeocache").Rows(ValStore).Item(1) = txtChurchMicroNumber.Text
                                            ds2.Tables("tblGeocache").Rows(ValStore).Item(2) = txtCacheTitle.Text


                                            cacheTypeDetails = comCacheType.Text
                                            For w = 1 To MaxRows3
                                                If inc <> MaxRows3 - 1 Then

                                                    inc = inc + 1
                                                    NavigateRecords3_2()

                                                Else

                                                    MessageBox.Show("No More Rows")
                                                    Exit For
                                                End If
                                                If cacheTypeDetails = typeValues Then

                                                    ds2.Tables("tblGeocache").Rows(ValStore).Item(3) = ds3.Tables("tblCacheType").Rows(inc).Item(0)
                                                    Exit For

                                                Else
                                                    Continue For
                                                End If
                                            Next
                                            inc = -1
                                            w = 1

                                            containnerTypeDetails = comContainerType.Text
                                            For w = 1 To MaxRows4
                                                If inc <> MaxRows4 - 1 Then

                                                    inc = inc + 1
                                                    NavigateRecords4_2()

                                                Else

                                                    MessageBox.Show("No More Rows")
                                                    Exit For
                                                End If
                                                If containnerTypeDetails = ContainnerTypeValues Then

                                                    ds2.Tables("tblGeocache").Rows(ValStore).Item(4) = ds4.Tables("tblContainnerType").Rows(inc).Item(0)
                                                    Exit For

                                                Else
                                                    Continue For
                                                End If
                                            Next
                                            inc = -1
                                            w = 1

                                            ds2.Tables("tblGeocache").Rows(ValStore).Item(5) = numTerrainRaiting.Value
                                            ds2.Tables("tblGeocache").Rows(ValStore).Item(6) = "N" & txtNorth1.Text & "°" & txtNorth2.Text

                                            If radW.Checked = True Then
                                                ds2.Tables("tblGeocache").Rows(ValStore).Item(7) = "W" & txtWest1.Text & "°" & txtWest2.Text
                                            Else
                                                ds2.Tables("tblGeocache").Rows(ValStore).Item(7) = "E" & txtWest1.Text & "°" & txtWest2.Text
                                            End If


                                            countyDetails = comCounty.Text
                                            For w = 1 To MaxRows5
                                                If inc <> MaxRows5 - 1 Then

                                                    inc = inc + 1
                                                    NavigateRecords5_2()

                                                Else

                                                    MessageBox.Show("No More Rows")
                                                    Exit For
                                                End If
                                                If countyDetails = countyValues Then

                                                    ds2.Tables("tblGeocache").Rows(ValStore).Item(8) = ds5.Tables("tblCounty").Rows(inc).Item(0)
                                                    Exit For

                                                Else
                                                    Continue For
                                                End If
                                            Next
                                            inc = -1
                                            w = 1

                                            ds2.Tables("tblGeocache").Rows(ValStore).Item(9) = txtGeocacheNotes.Text

                                            ds2.Tables("tblGeocache").Rows(ValStore).Item(12) = numDifficultyRaiting.Value

                                            da2.Update(ds2, "tblGeocache")

                                            MsgBox("updated the geocache")
                                            Edit.Show()
                                            Me.Close()


                                        Else MsgBox("invalid input for the East/West Co-ordinate")
                                        End If


                                    Else MsgBox("invalid input for the North Co-ordinate")
                                    End If


                                Else MsgBox("terrian raiting must eigher be a whole number or end in .5")
                                End If


                            Else MsgBox("The cache name is too long make sure it is less than or equal to 256 charcters long")
                            End If



                        Else
                            MsgBox("a cache with that church micro number already exists please use a diffrent church micro number")
                        End If



                    Else MsgBox("Church micro number formated incorrectly, it must be between 3 and 7 charcters long and in the format CM#####")
                    End If


                End If


            Else MsgBox("Geocache number formated incorrectly, it must be 7 charcters long and in the format GC#####")
            End If


        End If




    End Sub

    Private Sub butCanc_Click(sender As Object, e As EventArgs) Handles butCancel.Click
        Me.Close()
        Edit.Show()
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

    Private Sub butAdminOpen_Click(sender As Object, e As EventArgs) Handles butAdminOpen.Click
        Admin.Show()
        Me.Close()
    End Sub

    Dim geocacheNumberVal As Boolean
    Dim CmVal As Boolean
    Dim titleVal As Boolean
    Dim typeVal As Boolean
    Dim containerVal As Boolean
    Dim difficultVal As Boolean
    Dim terrianVal As Boolean
    Dim countyVal As Boolean
    Dim CoOrdVal As Boolean


    Private Sub butLogOut_Click(sender As Object, e As EventArgs) Handles butLogOut.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub txtGeocacheNumber_TextChanged(sender As Object, e As EventArgs) Handles txtGeocacheNumber.TextChanged
        If Len(txtGeocacheNumber.Text) = 7 And isValidGeocacheNumber(txtGeocacheNumber.Text) = True Then
            picGeocacheNumX.Hide()
            picGeocacheNum.Show()
            geocacheNumberVal = True
        Else
            If geocacheNumberVal = True Then
                picGeocacheNumX.Show()
                picGeocacheNum.Hide()
                geocacheNumberVal = False
            End If
        End If
    End Sub

    Private Sub txtChurchMicroNumber_TextChanged(sender As Object, e As EventArgs) Handles txtChurchMicroNumber.TextChanged
        If Len(txtChurchMicroNumber.Text) > 2 And Len(txtChurchMicroNumber.Text) < 8 And isValidChurchMicroNumber(txtChurchMicroNumber.Text) = True Then
            picCmNumX.Hide()
            picCmNum.Show()
            CmVal = True
        Else
            If CmVal = True Then
                picCmNumX.Show()
                picCmNum.Hide()
                CmVal = False
            End If
        End If
    End Sub

    Private Sub txtCacheTitle_TextChanged(sender As Object, e As EventArgs) Handles txtCacheTitle.TextChanged
        If Len(txtCacheTitle.Text) < 257 Then
            picCacheTitleX.Hide()
            picCacheTitle.Show()
            titleVal = True
        Else
            If titleVal = True Then
                picCacheTitleX.Hide()
                picCacheTitle.Hide()
                titleVal = False
            End If

        End If
    End Sub

    Private Sub comCacheType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comCacheType.SelectedIndexChanged
        If String.IsNullOrEmpty(comCacheType.Text) Then
            If typeVal = True Then
                picCacheTypeX.Show()
                picCacheType.Hide()
                typeVal = False
            End If
        Else
            picCacheTypeX.Hide()
            picCacheType.Show()
            typeVal = True
        End If
    End Sub

    Private Sub comContainerType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comContainerType.SelectedIndexChanged
        If String.IsNullOrEmpty(comContainerType.Text) Then
            If containerVal = True Then
                picContainerTypeX.Show()
                picContainerType.Hide()
                containerVal = False
            End If
        Else
            picContainerTypeX.Hide()
            picContainerType.Show()
            containerVal = True
        End If
    End Sub

    Private Sub numDifficultyRaiting_ValueChanged(sender As Object, e As EventArgs) Handles numDifficultyRaiting.ValueChanged
        If numDifficultyRaiting.Value Mod 0.5 = 0 Then
            picDifficultyRaitingX.Hide()
            picDifficultyRaiting.Show()
            difficultVal = True
        Else
            If difficultVal = True Then
                picDifficultyRaitingX.Show()
                picDifficultyRaiting.Hide()
                difficultVal = False
            End If
        End If
    End Sub

    Private Sub numTerrainRaiting_ValueChanged(sender As Object, e As EventArgs) Handles numTerrainRaiting.ValueChanged
        If numTerrainRaiting.Value Mod 0.5 = 0 Then
            picTerrainRaitingX.Hide()
            picTerrainRaiting.Show()
            terrianVal = True
        Else
            If terrianVal = True Then
                picTerrainRaitingX.Show()
                picTerrainRaiting.Hide()
                terrianVal = False
            End If
        End If
    End Sub

    Private Sub comCounty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comCounty.SelectedIndexChanged
        If String.IsNullOrEmpty(comCounty.Text) Then
            If countyVal = True Then
                picCountyX.Show()
                picCounty.Hide()
                countyVal = False
            End If
        Else
            picCountyX.Hide()
            picCounty.Show()
            countyVal = True
        End If
    End Sub

    Private Sub txtNorth1_TextChanged(sender As Object, e As EventArgs) Handles txtNorth1.TextChanged
        checkCoOrdinate()
    End Sub

    Private Sub txtNorth2_TextChanged(sender As Object, e As EventArgs) Handles txtNorth2.TextChanged
        checkCoOrdinate()
    End Sub

    Private Sub txtWest1_TextChanged(sender As Object, e As EventArgs) Handles txtWest1.TextChanged
        checkCoOrdinate()
    End Sub

    Private Sub txtWest2_TextChanged(sender As Object, e As EventArgs) Handles txtWest2.TextChanged
        checkCoOrdinate()
    End Sub

    Private Sub radE_CheckedChanged(sender As Object, e As EventArgs) Handles radE.CheckedChanged
        checkCoOrdinate()
    End Sub

    Private Sub radW_CheckedChanged(sender As Object, e As EventArgs) Handles radW.CheckedChanged
        checkCoOrdinate()
    End Sub

    Sub checkCoOrdinate()

        If isValidCoOrdinate1(txtNorth1.Text) = True And isValidCoOrdinate2(txtNorth2.Text) = True And isValidCoOrdinate1(txtWest1.Text) = True And isValidCoOrdinate2(txtWest2.Text) = True And (radE.Checked = True Or radW.Checked = True) Then
            picCoOrdinatesX.Hide()
            picCoOrdinates.Show()
            CoOrdVal = True
        Else
            If CoOrdVal = True Then
                picCoOrdinatesX.Show()
                picCoOrdinates.Hide()
                CoOrdVal = False
            End If

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles timClock.Tick
        txtTimer.Text = Format(Now, "HH:mm:ss")
    End Sub

    Private Sub butDelete_Click(sender As Object, e As EventArgs) Handles butDelete.Click
        Dim cb As New OleDb.OleDbCommandBuilder(da2)

        cb.QuotePrefix = "["
        cb.QuoteSuffix = "]"


        ds2.Tables("tblGeocache").Rows(ValStore).Delete()
        MaxRows2 = MaxRows2 - 1

        da2.Update(ds2, "tblGeocache")

        Edit.Show()
        Me.Close()
    End Sub
End Class