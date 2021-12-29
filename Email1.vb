Imports System.Net.Mail
Imports System.Random

Public Class Email1

    Dim email As String
    Dim charcters() As Char = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "!", "£", "$", "%", "^", "&", "*", "(", ")", "-", "+"}
    Dim codenum As Integer
    Dim numStore As String

    Private Sub NavigateRecords()
        email = ds.Tables("tblUser").Rows(inc).Item(7)
    End Sub

    Private Sub butSubmit_Click(sender As Object, e As EventArgs) Handles butSubmit.Click
        If String.IsNullOrEmpty(txtEmail.Text) Then
            MsgBox("No input found for email, please make sure an input is entered.")
        Else
            For i = 1 To MaxRows
                If inc <> MaxRows - 1 Then

                    inc = inc + 1
                    NavigateRecords()

                Else

                    MessageBox.Show("No More Rows")
                    Exit For
                End If
                If txtEmail.Text = email And Not txtEmail.Text = "" Then
                    Randomize()
                    'code for email gatherd from the internet and adapted for personal use
                    userLocation = inc
                    Dim Smtp_Server As New SmtpClient
                    Dim e_mail As New MailMessage()
                    Smtp_Server.UseDefaultCredentials = False
                    Smtp_Server.Credentials = New Net.NetworkCredential("geoConfirmation@gmail.com", "Geocache1")
                    Smtp_Server.Port = "587"
                    Smtp_Server.EnableSsl = True
                    Smtp_Server.Host = "smtp.gmail.com"

                    For codenum = 0 To 5

                        numStore = CInt(Math.Ceiling(Rnd() * 72))
                        code = code + charcters(numStore)

                    Next

                    e_mail = New MailMessage()
                    e_mail.From = New MailAddress("geoConfirmation@gmail.com")
                    e_mail.To.Add(email)
                    e_mail.Subject = "Password Activation Code"
                    e_mail.IsBodyHtml = False
                    e_mail.Body = "Your activation code is: " & code
                    Smtp_Server.Send(e_mail)

                    txtEmail.Text = ""

                    Email2.Show()
                    Me.Close()

                    Exit For

                End If
            Next
        End If
        inc = -1
    End Sub

    Private Sub butCancel_Click(sender As Object, e As EventArgs) Handles butCancel.Click
        ForgotPassword.Show()
        Me.Close()
    End Sub
End Class