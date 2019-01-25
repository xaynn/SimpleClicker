Public Class SLogin
    Dim Wclient As New System.Net.WebClient


    Private Sub HuraButton1_Click(sender As Object, e As EventArgs) Handles HuraButton1.Click



        If (HuraTextBox1.Text = My.Settings.Login And HuraTextBox2.Text = My.Settings.Hasło) Then
            MsgBox("Logged in!")
            Me.Hide()
            SMenu.Show()

        Else
            MsgBox("Invalid login or password, click OK to open channel on youtube for pass and login.")
            Process.Start("chrome.exe", "https://www.youtube.com/channel/UCE_rq1SS6RpLiyIZDZiJhVQ")
        End If




    End Sub

    Private Sub HuraForm1_Click(sender As Object, e As EventArgs) Handles HuraForm1.Click

    End Sub

    Private Sub HuraTextBox1_Click(sender As Object, e As EventArgs) Handles HuraTextBox1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
