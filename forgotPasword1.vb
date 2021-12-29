Public Class forgotPasword1
    Dim first As String
    Dim last As String
    Dim usern As String
    Dim email As String


    Private Sub NavigateRecords()
        first = ds.Tables("tblUser").Rows(inc).Item(1)
        last = ds.Tables("tblUser").Rows(inc).Item(2)
        usern = ds.Tables("tblUser").Rows(inc).Item(3)
        email = ds.Tables("tblUser").Rows(inc).Item(7)
    End Sub

    Private Sub forgotPasword1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inc = -1
        Label7.Hide()
    End Sub

    Private Sub butSubmit_Click(sender As Object, e As EventArgs) Handles butSubmit.Click
        If String.IsNullOrEmpty(txtFirstName.Text) Then
            MsgBox("No input found for firstname, please make sure an input is entered.")
        ElseIf String.IsNullOrEmpty(txtLastName.Text) Then
            MsgBox("No input found for last name, please make sure an input is entered.")
        ElseIf String.IsNullOrEmpty(txtUserName.Text) Then
            MsgBox("No input found for username, please make sure an input is entered.")
        ElseIf String.IsNullOrEmpty(txtEmail.Text) Then
            MsgBox("No input found for Email, please make sure an input is entered.")
        Else
            For i = 1 To MaxRows
                If inc <> MaxRows - 1 Then

                    inc = inc + 1
                    NavigateRecords()

                Else

                    MessageBox.Show("No More Rows")
                    Exit For
                End If

                If txtFirstName.Text = first Then

                    If txtLastName.Text = last Then

                        If txtUserName.Text = usern Then

                            If txtEmail.Text = email Then

                                txtFirstName.Text = ""
                                txtLastName.Text = ""
                                txtUserName.Text = ""
                                txtEmail.Text = ""

                                ForgotPassword2.Show()
                                Me.Close()
                                userLocation = inc



                            Else
                                Label7.Show()
                                Continue For
                            End If

                        Else
                            Label7.Show()
                            Continue For
                        End If

                    Else
                        Label7.Show()
                        Continue For
                    End If
                Else
                    Label7.Show()
                    Continue For
                End If

            Next
            inc = -1


        End If

    End Sub



    Private Sub butCancel_Click(sender As Object, e As EventArgs) Handles butCancel.Click
        ForgotPassword.Show()
        Me.Close()
    End Sub
End Class