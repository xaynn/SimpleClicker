Public Class Wczytywanie
    Public Class Start

        <STAThread>
        Private Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New SLogin())
        End Sub
    End Class

End Class
