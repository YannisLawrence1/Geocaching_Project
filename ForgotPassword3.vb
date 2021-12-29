Public Class ForgotPassword3


    Dim Cletter As New System.Text.RegularExpressions.Regex("[A-Z]")
    Dim letter As New System.Text.RegularExpressions.Regex("[a-z]")
    Dim num As New System.Text.RegularExpressions.Regex("[0-9]")

    Dim lengthVal As Boolean
    Dim capitalVal As Boolean
    Dim lowerVal As Boolean
    Dim numberVal As Boolean


    Private Sub butSubmit_Click(sender As Object, e As EventArgs) Handles butSubmit.Click

        If txtNewPassword.Text = txtNewPassword2.Text Then

            If Len(txtNewPassword.Text) > 5 Then

                If Cletter.Matches(txtNewPassword.Text).Count > 0 Then

                    If letter.Matches(txtNewPassword.Text).Count > 0 Then

                        If num.Matches(txtNewPassword.Text).Count > 0 Then

                            MsgBox("new password accepted")

                            Dim cb As New OleDb.OleDbCommandBuilder(da)
                            cb.QuotePrefix = "["
                            cb.QuoteSuffix = "]"
                            ds.Tables("tblUser").Rows(userLocation).Item(4) = txtNewPassword.Text
                            da.Update(ds, "tblUser")

                            txtNewPassword.Text = ""
                            txtNewPassword2.Text = ""

                            Me.Close()
                            Form1.Show()

                        Else
                            MsgBox("password dosnt contain a number")
                        End If

                    Else
                        MsgBox("password dosnt contain a lower case letter")

                    End If

                Else
                    MsgBox("password dosnt contain a capital letter")

                End If

            Else
                MsgBox("password too short")

            End If

        Else
            MsgBox("password don't match")

        End If


    End Sub

    Private Sub butHelp_Click(sender As Object, e As EventArgs)
        MsgBox("Password must: 
Be 6 charcters or longer
Contain a capital letter
Contain a lower case letter
Contain a number")
    End Sub

    Private Sub txtNewPassword_TextChanged(sender As Object, e As EventArgs) Handles txtNewPassword.TextChanged

        If Len(txtNewPassword.Text) > 5 Then
            pic6LetterX.Hide()
            pic6Letter.Show()
            lengthVal = True
        Else
            If lengthVal = True Then
                pic6LetterX.Show()
                pic6Letter.Hide()
                lengthVal = False
            End If
        End If


        If Cletter.Matches(txtNewPassword.Text).Count > 0 Then
            picCapitalX.Hide()
            picCapital.Show()
            capitalVal = True
        Else
            If capitalVal = True Then
                picCapitalX.Show()
                picCapital.Hide()
                capitalVal = False
            End If
        End If

        If letter.Matches(txtNewPassword.Text).Count > 0 Then
            picLowerX.Hide()
            picLower.Show()
            lowerVal = True
        Else
            If lowerVal = True Then
                picLowerX.Show()
                picLower.Hide()
                lowerVal = False
            End If
        End If

        If num.Matches(txtNewPassword.Text).Count > 0 Then
            picNumberX.Hide()
            picNumber.Show()
            numberVal = True
        Else
            If numberVal = True Then
                picNumberX.Show()
                picNumber.Hide()
                numberVal = False
            End If
        End If

    End Sub
End Class