Public Class Email2
    Private Sub butSubmit_Click(sender As Object, e As EventArgs) Handles butSubmit.Click
        If txtCode.Text = code Then
            ForgotPassword3.Show()
            code = ""
            Me.Close()
        End If
    End Sub
End Class