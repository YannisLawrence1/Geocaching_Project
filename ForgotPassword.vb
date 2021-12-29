Public Class ForgotPassword
    Private Sub butinfo_Click(sender As Object, e As EventArgs) Handles butinfo.Click
        forgotPasword1.Show()
        Me.Close()
    End Sub

    Private Sub butEmail_Click(sender As Object, e As EventArgs) Handles butEmail.Click
        Email1.Show()
        Me.Close()
    End Sub

    Private Sub butCancel_Click(sender As Object, e As EventArgs) Handles butCancel.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class