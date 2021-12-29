' ToTitleCase.
Imports System.Text.RegularExpressions
Imports System.Net.Mail
Public Class CreateANewAccount
    Dim idStore As Integer
    Dim ExistingUsername As Boolean
    Dim ExistingEmail As Boolean

    Private Function isValidName(ByVal str As String) As Boolean

        Return Regex.IsMatch(str, "^[A-Z a-z]+$")

    End Function

    Private Function isValidEmail(ByVal str As String) As Boolean

        Return Regex.IsMatch(str, "^[0-9A-Za-z\w.]+@[A-Z a-z 0-9 \w.]+\.[A-Z a-z]+$")

    End Function

    Private Sub txtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged
        If Len(txtFirstName.Text) > 1 And Len(txtFirstName.Text) < 20 And isValidName(txtFirstName.Text) = True Then
            picFirstName.Show()
            picFirstNameX.Hide()
        Else
            picFirstName.Hide()
            picFirstNameX.Show()
        End If
    End Sub

    Private Sub txtLastName_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.TextChanged
        If Len(txtLastName.Text) < 20 And isValidName(txtLastName.Text) = True Then
            picLastName.Show()
            picLastNameX.Hide()
        Else
            picLastName.Hide()
            picLastNameX.Show()
        End If
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        If Len(txtUsername.Text) > 4 And Len(txtUsername.Text) < 20 Then
            picUsername.Show()
            picUsernameX.Hide()
        Else
            picUsername.Hide()
            picUsernameX.Show()
        End If
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        If Len(txtEmail.Text) < 257 And isValidEmail(txtEmail.Text) = True Then
            picEmail.Show()
            picEmailX.Hide()
        Else
            picEmail.Hide()
            picEmailX.Show()
        End If
    End Sub

    Private Sub comAccessLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comAccessLevel.SelectedIndexChanged
        If comAccessLevel.Text = "" Then
            picLevelOfAccess.Hide()
            picLevelOfAccessX.Show()
        Else
            picLevelOfAccess.Show()
            picLevelOfAccessX.Hide()
        End If
    End Sub

    Private Sub butSubmit_Click(sender As Object, e As EventArgs) Handles butSubmit.Click
        ExistingEmail = False
        ExistingUsername = False

        For i = 0 To MaxRows - 1
            If txtUsername.Text = ds.Tables("tblUser").Rows(i).Item(3) Then
                ExistingUsername = True
            End If

            If txtEmail.Text = ds.Tables("tblUser").Rows(i).Item(7) Then
                ExistingEmail = True
            End If
        Next

        If Len(txtFirstName.Text) > 1 And Len(txtFirstName.Text) < 20 Then

            If isValidName(txtFirstName.Text) = True Then

                If Len(txtLastName.Text) > 0 And Len(txtLastName.Text) < 20 Then

                    If isValidName(txtLastName.Text) = True Then

                        If Len(txtUsername.Text) > 4 And Len(txtUsername.Text) < 20 Then

                            If ExistingUsername = False Then

                                If Len(txtEmail.Text) < 257 Then

                                    If isValidEmail(txtEmail.Text) = True Then

                                        If comAccessLevel.Text = "" Then
                                            MsgBox("Please select an access level for the user", MessageBoxIcon.Exclamation)
                                        Else
                                            Dim cb As New OleDb.OleDbCommandBuilder(da)
                                            Dim dsNewRow As DataRow

                                            cb.QuotePrefix = "["
                                            cb.QuoteSuffix = "]"

                                            dsNewRow = ds.Tables("tblUser").NewRow()

                                            For i = 0 To MaxRows - 1
                                                If ds.Tables("tblUser").Rows(i).Item(0) > idStore Then
                                                    idStore = ds.Tables("tblUser").Rows(i).Item(0)
                                                End If
                                            Next


                                            dsNewRow.Item("userID") = idStore + 1
                                            dsNewRow.Item("firstName") = txtFirstName.Text
                                            dsNewRow.Item("lastName") = txtLastName.Text
                                            dsNewRow.Item("userName") = txtUsername.Text
                                            dsNewRow.Item("password") = "Password1"
                                            dsNewRow.Item("questionID") = "1"
                                            dsNewRow.Item("questionAnswer") = "Needs Response"
                                            dsNewRow.Item("email") = txtEmail.Text

                                            If comAccessLevel.Text = "read only" Then
                                                dsNewRow.Item("accessID") = "ace1"
                                            ElseIf comAccessLevel.Text = "read And Write" Then
                                                dsNewRow.Item("accessID") = "ace2"
                                            ElseIf comAccessLevel.Text = "read, Write= And remove" Then
                                                dsNewRow.Item("accessID") = "ace3"
                                            ElseIf comAccessLevel.Text = "Admin" Then
                                                dsNewRow.Item("accessID") = "ace4"
                                            End If


                                            ds.Tables("tblUser").Rows.Add(dsNewRow)
                                            da.Update(ds, "tblUser")

                                            Dim Smtp_Server As New SmtpClient
                                            Dim e_mail As New MailMessage()
                                            Smtp_Server.UseDefaultCredentials = False
                                            Smtp_Server.Credentials = New Net.NetworkCredential("geoConfirmation@gmail.com", "Geocache1")
                                            Smtp_Server.Port = "587"
                                            Smtp_Server.EnableSsl = True
                                            Smtp_Server.Host = "smtp.gmail.com"


                                            e_mail = New MailMessage()
                                            e_mail.From = New MailAddress("geoConfirmation@gmail.com")
                                            e_mail.To.Add(txtEmail.Text)
                                            e_mail.Subject = "Your Geocaching system account"
                                            e_mail.IsBodyHtml = False
                                            e_mail.Body = "Welecome to the geocaching system. 
Your username is: " & txtUsername.Text & "
Your password is: Password1"
                                            Smtp_Server.Send(e_mail)



                                            MsgBox("New user successfully created with the username: " & txtUsername.Text & " and the password: Password1, an email containing this information has been sent the the email address of the user.")

                                            Admin.Show()
                                            Me.Close()

                                        End If

                                    Else
                                        MsgBox("Invalid format for an email", MessageBoxIcon.Exclamation)
                                    End If

                                Else
                                    MsgBox("Email must be 256 charcters or shorter", MessageBoxIcon.Exclamation)
                                End If

                            Else
                                MsgBox("There is already an existing User with that username please select another username", MessageBoxIcon.Exclamation)
                            End If


                        Else
                            MsgBox("Username must be between 5 and 19 charcters inclusive", MessageBoxIcon.Exclamation)
                        End If

                    Else
                        MsgBox("Last name must only contain letters", MessageBoxIcon.Exclamation)
                    End If

                Else
                    MsgBox("Last name must be shorter than 20 charcters", MessageBoxIcon.Exclamation)
                End If

            Else
                MsgBox("First name must only contian letters", MessageBoxIcon.Exclamation)
            End If

        Else
            MsgBox("First name must be between 2 and 19 charcters inclusive", MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub butCancel_Click(sender As Object, e As EventArgs) Handles butCancel.Click
        Admin.Show()
        Me.Close()
    End Sub

End Class