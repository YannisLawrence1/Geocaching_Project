Public Class SelectSecurityQuestionvb
    Private Sub butLogIn_Click(sender As Object, e As EventArgs) Handles butLogIn.Click
        If comQuestion.Text = "" Then
            MsgBox("Select a security question for your account.", MessageBoxIcon.Exclamation)
        Else

            If Len(txtAnswer.Text) > 2 And Len(txtAnswer.Text) < 101 Then

                Dim cb As New OleDb.OleDbCommandBuilder(da)
                cb.QuotePrefix = "["
                cb.QuoteSuffix = "]"

                If comQuestion.Text = "What primary school did you attend?" Then
                    ds.Tables("tblUser").Rows(userLocation).Item(5) = 1
                ElseIf comQuestion.Text = "What was the name of your fist pet?" Then
                    ds.Tables("tblUser").Rows(userLocation).Item(5) = 2
                ElseIf comQuestion.Text = "What was your mothers maiden name?" Then
                    ds.Tables("tblUser").Rows(userLocation).Item(5) = 3
                Else

                End If

                ds.Tables("tblUser").Rows(userLocation).Item(6) = txtAnswer.Text
                da.Update(ds, "tblUser")

                ForgotPassword3.Show()
                Me.Close()

            Else

                MsgBox("The answer to the question must be between 3 and 100 inclusive charcters long", MessageBoxIcon.Exclamation)

            End If

        End If

    End Sub
End Class