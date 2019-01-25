Public Class index





    Private Sub index_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Threading.Thread.Sleep(30000)
        SLogin.Show()

    End Sub

    Private Sub HuraForm1_Click(sender As Object, e As EventArgs) Handles HuraForm1.Click

    End Sub

    Private Sub HuraButton3_Click(sender As Object, e As EventArgs) Handles HuraButton3.Click
        SLogin.Show()
    End Sub
End Class