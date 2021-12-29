Public Class ForgotPassword2

    Private Sub ForgotPassword2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        que1.Hide()
        que2.Hide()
        que3.Hide()
        Label5.Hide()


        If ds.Tables("tblUser").Rows(inc).Item(5) = "1" Then
            que1.Show()
        ElseIf ds.Tables("tblUser").Rows(inc).Item(5) = "2" Then
            que2.Show()
        ElseIf ds.Tables("tblUser").Rows(inc).Item(5) = "3" Then
            que3.Show()
        End If


    End Sub

    Private Sub butSubmit_Click(sender As Object, e As EventArgs) Handles butSubmit.Click
        If String.IsNullOrEmpty(txtQuestion.Text) Then
            MsgBox("No input found for question answer, please make sure an input is entered.")
        Else
            If txtQuestion.Text = ds.Tables("tblUser").Rows(userLocation).Item(6) Then
                txtQuestion.Text = ""
                Me.Close()
                ForgotPassword3.Show()
            Else
                Label5.Show()
            End If
        End If

    End Sub


End Class