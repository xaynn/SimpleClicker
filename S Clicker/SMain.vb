Public Class SMain
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal key As Integer) As Integer
    Private Declare Function apimouse_event Lib "user32.dll" Alias "mouse_event" (ByVal dwFlags As Int32, ByVal dX As Int32, ByVal dY As Int32, ByVal cButtons As Int32, ByVal dwExtraInfo As Int32) As Boolean
    Private Declare Function apiGetMessageExtraInfo Lib "user32" Alias "GetMessageExtraInfo" () As Int32
    Public Declare Function eAPISMessage Lib "user32.dll" Alias "SendMessageA" (ByVal hWnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As String) As Integer
    Private Declare Sub keybd_event Lib "user32.dll" (ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As Integer, ByVal dwExtraInfo As Integer)
    Public Declare Function MapVirtualKey Lib "user32" Alias "MapVirtualKeyA" (ByVal wCode As Integer, ByVal wMapType As Integer) As Integer
    Private Declare Function GetActiveWindow Lib "user32" () As Long
    Private Declare Function GetForegroundWindow Lib "user32" Alias "GetForegroundWindow" () As IntPtr
    Public Declare Auto Function GetWindowText Lib "user32" (ByVal hWnd As System.IntPtr, ByVal lpString As System.Text.StringBuilder, ByVal cch As Integer) As Integer
    Dim shouldRClick As Boolean
    Dim rnd As New Random
    Dim p() As Process
    Dim shouldClick As Boolean = False
    Public Const MOUSEEVENTF_LEFTDOWN = &H2
    Public Const MOUSEEVENTF_LEFTUP = &H4
    Public Const MOUSEEVENTF_MIDDLEDOWN = &H20
    Public Const MOUSEEVENTF_MIDDLEUP = &H40
    Public Const MOUSEEVENTF_RIGHTDOWN = &H8
    Public Const MOUSEEVENTF_RIGHTUP = &H10
    Public Const MOUSEEVENTF_MOVE = &H1
    Dim klik As Integer
    Private Sub HuraCheckBox1_CheckedChanged(sender As Object) Handles HuraCheckBox1.CheckedChanged
        If HuraCheckBox1.Checked = True Then
            ProcesJavaMC()
        End If
    End Sub
    Private Sub ProcesJavaMC()
        p = Process.GetProcessesByName("javaw") ' Javaw Process. default minecraft process,  if you like cheatbreaker, write just CheatBreaker.
        If p.Count > 0 Then
            ' Process is running
        Else
            MsgBox("Aplication doesnt exist. If it is CheatBreaker or else, change in code name of searching process.", MsgBoxStyle.Critical)
            HuraCheckBox1.Checked = False
        End If
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Label3.Text = TrackBar1.Value
        If TrackBar1.Value > TrackBar2.Value Then
            TrackBar2.Value = TrackBar1.Value
            Label5.Text = TrackBar1.Value
        End If
    End Sub

    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles TrackBar2.Scroll
        Label5.Text = TrackBar2.Value
        If TrackBar1.Value > TrackBar2.Value Then
            TrackBar2.Value = TrackBar1.Value
            Label5.Text = TrackBar1.Value
        End If
    End Sub

    Sub Delay(ByVal dblSecs As Double)

        Const OneSec As Double = 1.0# / (1440.0# * 60.0#)
        Dim dblWaitTil As Date
        Now.AddSeconds(OneSec)
        dblWaitTil = Now.AddSeconds(OneSec).AddSeconds(dblSecs)
        Do Until Now > dblWaitTil
            Application.DoEvents()
        Loop

    End Sub

    Private Sub HideButton_Tick(sender As Object, e As EventArgs) Handles HideButton.Tick
        Dim bind1 As Integer = 0
        bind1 = bind1 + 1
        Dim dictionary As New Dictionary(Of String, Keys)
        dictionary.Add("A", Keys.A)
        dictionary.Add("B", Keys.B)
        dictionary.Add("C", Keys.C)
        dictionary.Add("D", Keys.D)
        dictionary.Add("E", Keys.E)
        dictionary.Add("F", Keys.F)
        dictionary.Add("G", Keys.G)
        dictionary.Add("H", Keys.H)
        dictionary.Add("I", Keys.I)
        dictionary.Add("J", Keys.J)
        dictionary.Add("K", Keys.K)
        dictionary.Add("L", Keys.L)
        dictionary.Add("M", Keys.M)
        dictionary.Add("N", Keys.N)
        dictionary.Add("O", Keys.O)
        dictionary.Add("P", Keys.P)
        dictionary.Add("Q", Keys.Q)
        dictionary.Add("R", Keys.R)
        dictionary.Add("S", Keys.S)
        dictionary.Add("T", Keys.T)
        dictionary.Add("U", Keys.U)
        dictionary.Add("V", Keys.V)
        dictionary.Add("W", Keys.W)
        dictionary.Add("X", Keys.X)
        dictionary.Add("Y", Keys.Y)
        dictionary.Add("Z", Keys.Z)
        dictionary.Add("a", Keys.A)
        dictionary.Add("b", Keys.B)
        dictionary.Add("c", Keys.C)
        dictionary.Add("d", Keys.D)
        dictionary.Add("e", Keys.E)
        dictionary.Add("f", Keys.F)
        dictionary.Add("g", Keys.G)
        dictionary.Add("h", Keys.H)
        dictionary.Add("i", Keys.I)
        dictionary.Add("j", Keys.J)
        dictionary.Add("k", Keys.K)
        dictionary.Add("l", Keys.L)
        dictionary.Add("m", Keys.M)
        dictionary.Add("n", Keys.N)
        dictionary.Add("o", Keys.O)
        dictionary.Add("p", Keys.P)
        dictionary.Add("q", Keys.Q)
        dictionary.Add("r", Keys.R)
        dictionary.Add("s", Keys.S)
        dictionary.Add("t", Keys.T)
        dictionary.Add("u", Keys.U)
        dictionary.Add("v", Keys.V)
        dictionary.Add("w", Keys.W)
        dictionary.Add("x", Keys.X)
        dictionary.Add("y", Keys.Y)
        dictionary.Add("z", Keys.Z)
        dictionary.Add("R-SHIFT", Keys.RShiftKey)

        Dim bind As String = HuraComboBox1.Text

        If GetAsyncKeyState(Keys.LControlKey) And GetAsyncKeyState(dictionary(HuraComboBox1.Text)) Then
            Delay(0.075)
            Me.Hide()
        End If

        If GetAsyncKeyState(Keys.LControlKey) And GetAsyncKeyState(dictionary(HuraComboBox1.Text)) Then
            Delay(0.075)
            Me.Show()
        End If
    End Sub

    Private Sub Bind_Tick(sender As Object, e As EventArgs) Handles Bind.Tick
        Dim bind1 As Integer = 0
        bind1 = bind1 + 1
        Dim dictionary As New Dictionary(Of String, Keys)
        dictionary.Add("A", Keys.A)
        dictionary.Add("B", Keys.B)
        dictionary.Add("C", Keys.C)
        dictionary.Add("D", Keys.D)
        dictionary.Add("E", Keys.E)
        dictionary.Add("F", Keys.F)
        dictionary.Add("G", Keys.G)
        dictionary.Add("H", Keys.H)
        dictionary.Add("I", Keys.I)
        dictionary.Add("J", Keys.J)
        dictionary.Add("K", Keys.K)
        dictionary.Add("L", Keys.L)
        dictionary.Add("M", Keys.M)
        dictionary.Add("N", Keys.N)
        dictionary.Add("O", Keys.O)
        dictionary.Add("P", Keys.P)
        dictionary.Add("Q", Keys.Q)
        dictionary.Add("R", Keys.R)
        dictionary.Add("S", Keys.S)
        dictionary.Add("T", Keys.T)
        dictionary.Add("U", Keys.U)
        dictionary.Add("V", Keys.V)
        dictionary.Add("W", Keys.W)
        dictionary.Add("X", Keys.X)
        dictionary.Add("Y", Keys.Y)
        dictionary.Add("Z", Keys.Z)
        dictionary.Add("a", Keys.A)
        dictionary.Add("b", Keys.B)
        dictionary.Add("c", Keys.C)
        dictionary.Add("d", Keys.D)
        dictionary.Add("e", Keys.E)
        dictionary.Add("f", Keys.F)
        dictionary.Add("g", Keys.G)
        dictionary.Add("h", Keys.H)
        dictionary.Add("i", Keys.I)
        dictionary.Add("j", Keys.J)
        dictionary.Add("k", Keys.K)
        dictionary.Add("l", Keys.L)
        dictionary.Add("m", Keys.M)
        dictionary.Add("n", Keys.N)
        dictionary.Add("o", Keys.O)
        dictionary.Add("p", Keys.P)
        dictionary.Add("q", Keys.Q)
        dictionary.Add("r", Keys.R)
        dictionary.Add("s", Keys.S)
        dictionary.Add("t", Keys.T)
        dictionary.Add("u", Keys.U)
        dictionary.Add("v", Keys.V)
        dictionary.Add("w", Keys.W)
        dictionary.Add("x", Keys.X)
        dictionary.Add("y", Keys.Y)
        dictionary.Add("z", Keys.Z)
        dictionary.Add("R-SHIFT", Keys.RShiftKey)
        dictionary.Add("", Nothing)

        Dim bind As String = HuraTextBox1.Text

        If GetAsyncKeyState(dictionary(bind)) Then
            If AutoClicker.Enabled = True Then
                AutoClicker.Stop()
            Else
                AutoClicker.Start()
            End If

            If GetAsyncKeyState(dictionary(HuraTextBox2.Text)) Then
                If WTap.Enabled = True Then
                    WTap.Stop()
                Else
                    WTap.Start()
                End If
            End If
        End If
    End Sub

    Private Sub HuraButton2_Click(sender As Object, e As EventArgs) Handles HuraButton2.Click
        HideButton.Start()
        MsgBox("Bound hide key to " + HuraComboBox1.SelectedItem)
    End Sub

    Sub Clicking()
        Dim ignoreNextRelease As Boolean = False
        Randomize()
        If AutoClicker.Enabled Then
            apimouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, MOUSEEVENTF_LEFTDOWN, apiGetMessageExtraInfo)
            Threading.Thread.Sleep(rnd.Next(50, 70))
            ignoreNextRelease = True
            apimouse_event(MOUSEEVENTF_LEFTUP, 0, 0, MOUSEEVENTF_LEFTDOWN, apiGetMessageExtraInfo)
            Threading.Thread.Sleep(rnd.Next(50, 70))
        End If
    End Sub
    Private Sub AutoClicker_Tick(sender As Object, e As EventArgs) Handles AutoClicker.Tick
        Randomize(1)

        Dim rnd As New Random
        Dim minval As Integer
        Dim maxval As Integer

        minval = 1000 / (TrackBar1.Value + TrackBar2.Value * 0.2)
        maxval = 1000 / (TrackBar2.Value + TrackBar2.Value * 0.3)

        AutoClicker.Interval = rnd.Next(maxval, minval)
        Dim acThread As New System.Threading.Thread(AddressOf Clicking)

        If MouseButtons = MouseButtons.Left Then
            apimouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
            apimouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
        End If
    End Sub

    Private Sub WTap_Tick(sender As Object, e As EventArgs) Handles WTap.Tick
        WTap.Interval = rnd.Next(TrackBar3.Value, TrackBar4.Value)

        If GetAsyncKeyState(Keys.W) And AutoClicker.Enabled = True And Me.shouldClick = True = True Then
            InputHelper.SetKeyState(Keys.W, True)
            Delay(0.025)
            InputHelper.SetKeyState(Keys.W, False)
        End If
    End Sub

    Private Sub HuraButton4_Click(sender As Object, e As EventArgs) Handles HuraButton4.Click
        Bind.Start()
        MsgBox("Bound to " + HuraTextBox2.Text)
    End Sub

    Private Sub HuraButton5_Click(sender As Object, e As EventArgs) Handles HuraButton5.Click
        klik = klik + 1
        If klik = 1 Then
            WTap.Start()
            HuraButton5.Text = "Stop"
        Else
            klik = 0
            WTap.Stop()
            HuraButton5.Text = "Start"
        End If
    End Sub

    Private Sub HuraButton6_Click(sender As Object, e As EventArgs) Handles HuraButton6.Click
        klik = klik + 1
        If klik = 1 Then
            AutoClicker.Start()
            HuraButton6.Text = "Stop"
        Else
            klik = 0
            HuraButton6.Text = "Start"
            AutoClicker.Stop()
        End If
    End Sub ' SELF DESTRUCT ---------------------------------------------------------------------------------------------
    Private Sub Melt3(ByVal Timeout As Integer)
        Dim processStartInfo As System.Diagnostics.ProcessStartInfo = New System.Diagnostics.ProcessStartInfo("cmd.exe") With
            {
                .Arguments = String.Concat(New String() {"/C ping 1.1.1.1 -n 1 -w ", Timeout.ToString(), " > Nul & Del """, Application.ExecutablePath, """"}),
                .CreateNoWindow = True,
                .ErrorDialog = False,
                .WindowStyle = ProcessWindowStyle.Normal
            }
        Process.Start(processStartInfo)
    End Sub

    Private Sub HuraButton1_Click(sender As Object, e As EventArgs) Handles HuraButton1.Click
        HuraButton1.Text = Nothing
        HuraButton2.Text = Nothing
        HuraButton3.Text = Nothing
        HuraButton4.Text = Nothing
        HuraButton5.Text = Nothing
        HuraButton6.Text = Nothing
        HuraCheckBox1.Text = Nothing
        HuraComboBox1.Text = Nothing
        HuraTextBox1.Text = Nothing
        HuraTextBox2.Text = Nothing
        HuraTabControl1.ResetText()
        TrackBar1.ResetText()
        TrackBar2.ResetText()
        TrackBar3.ResetText()
        TrackBar4.ResetText()
        Label1.Text = Nothing
        Label2.Text = Nothing
        Label3.Text = Nothing
        Label4.Text = Nothing
        Label5.Text = Nothing
        Label6.Text = Nothing
        Label7.Text = Nothing
        Label8.Text = Nothing
        Label9.Text = Nothing
        Label10.Text = Nothing
        Label11.Text = Nothing
        Label12.Text = Nothing
        Me.Text = Nothing

        HuraButton1.Dispose()
        HuraButton2.Dispose()
        HuraButton3.Dispose()
        HuraButton4.Dispose()
        HuraButton5.Dispose()
        HuraButton6.Dispose()
        HuraCheckBox1.Dispose()
        HuraComboBox1.Dispose()
        HuraTextBox1.Dispose()
        HuraTextBox2.Dispose()
        HuraTabControl1.Dispose()
        TrackBar1.Dispose()
        TrackBar2.Dispose()
        TrackBar3.Dispose()
        TrackBar4.Dispose()
        Label1.Dispose()
        Label2.Dispose()
        Label3.Dispose()
        Label4.Dispose()
        Label5.Dispose()
        Label6.Dispose()
        Label7.Dispose()
        Label8.Dispose()
        Label9.Dispose()
        Label10.Dispose()
        Label11.Dispose()
        Me.Dispose()
        Me.Opacity = 0
        Melt3(1)
        Application.ExitThread()
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub HuraButton3_Click(sender As Object, e As EventArgs) Handles HuraButton3.Click
        Bind.Start()
        MsgBox("Bound to " + HuraTextBox1.Text)
    End Sub
    Private Sub TrackBar3_Scroll(sender As Object, e As EventArgs) Handles TrackBar3.Scroll
        Label8.Text = TrackBar3.Value
    End Sub
    Private Sub TrackBar4_Scroll(sender As Object, e As EventArgs) Handles TrackBar4.Scroll
        Label9.Text = TrackBar4.Value
    End Sub

    Private Sub HuraForm1_Click(sender As Object, e As EventArgs) Handles HuraForm1.Click

    End Sub

    Private Sub SelfDestructTAB_Click(sender As Object, e As EventArgs) Handles SelfDestructTAB.Click

    End Sub

    Private Sub HuraAlertBox1_Click(sender As Object, e As EventArgs) Handles HuraAlertBox1.Click

    End Sub

    Private Sub HuraAlertBox2_Click(sender As Object, e As EventArgs)

    End Sub
End Class