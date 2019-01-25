<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SMain
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SMain))
        Me.AutoClicker = New System.Windows.Forms.Timer(Me.components)
        Me.WTap = New System.Windows.Forms.Timer(Me.components)
        Me.HideButton = New System.Windows.Forms.Timer(Me.components)
        Me.Bind = New System.Windows.Forms.Timer(Me.components)
        Me.HuraForm1 = New S_Clicker.HuraForm()
        Me.HuraControlBox1 = New S_Clicker.HuraControlBox()
        Me.HuraTabControl1 = New S_Clicker.HuraTabControl()
        Me.ClickerTAB = New System.Windows.Forms.TabPage()
        Me.HuraButton6 = New S_Clicker.HuraButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.HuraButton3 = New S_Clicker.HuraButton()
        Me.HuraTextBox1 = New S_Clicker.HuraTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TrackBar2 = New System.Windows.Forms.TrackBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.WTapTAB = New System.Windows.Forms.TabPage()
        Me.HuraButton5 = New S_Clicker.HuraButton()
        Me.HuraButton4 = New S_Clicker.HuraButton()
        Me.HuraTextBox2 = New S_Clicker.HuraTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TrackBar4 = New System.Windows.Forms.TrackBar()
        Me.TrackBar3 = New System.Windows.Forms.TrackBar()
        Me.SettingTAB = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.HuraButton2 = New S_Clicker.HuraButton()
        Me.HuraCheckBox1 = New S_Clicker.HuraCheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HuraComboBox1 = New S_Clicker.HuraComboBox()
        Me.HuraAlertBox1 = New S_Clicker.HuraAlertBox()
        Me.SelfDestructTAB = New System.Windows.Forms.TabPage()
        Me.HuraButton1 = New S_Clicker.HuraButton()
        Me.HuraForm1.SuspendLayout()
        Me.HuraTabControl1.SuspendLayout()
        Me.ClickerTAB.SuspendLayout()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WTapTAB.SuspendLayout()
        CType(Me.TrackBar4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SettingTAB.SuspendLayout()
        Me.SelfDestructTAB.SuspendLayout()
        Me.SuspendLayout()
        '
        'AutoClicker
        '
        '
        'WTap
        '
        '
        'HideButton
        '
        '
        'Bind
        '
        '
        'HuraForm1
        '
        Me.HuraForm1.AccentColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraForm1.ColorScheme = S_Clicker.HuraForm.ColorSchemes.Dark
        Me.HuraForm1.Controls.Add(Me.HuraControlBox1)
        Me.HuraForm1.Controls.Add(Me.HuraTabControl1)
        Me.HuraForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HuraForm1.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.HuraForm1.ForeColor = System.Drawing.Color.Gray
        Me.HuraForm1.Location = New System.Drawing.Point(0, 0)
        Me.HuraForm1.Name = "HuraForm1"
        Me.HuraForm1.Size = New System.Drawing.Size(581, 289)
        Me.HuraForm1.TabIndex = 0
        Me.HuraForm1.Text = "CCleaner"
        '
        'HuraControlBox1
        '
        Me.HuraControlBox1.AccentColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HuraControlBox1.BackColor = System.Drawing.Color.White
        Me.HuraControlBox1.ColorScheme = S_Clicker.HuraControlBox.ColorSchemes.Dark
        Me.HuraControlBox1.ForeColor = System.Drawing.Color.White
        Me.HuraControlBox1.Location = New System.Drawing.Point(478, 3)
        Me.HuraControlBox1.Name = "HuraControlBox1"
        Me.HuraControlBox1.Size = New System.Drawing.Size(100, 25)
        Me.HuraControlBox1.TabIndex = 1
        Me.HuraControlBox1.Text = "HuraControlBox1"
        '
        'HuraTabControl1
        '
        Me.HuraTabControl1.Controls.Add(Me.ClickerTAB)
        Me.HuraTabControl1.Controls.Add(Me.WTapTAB)
        Me.HuraTabControl1.Controls.Add(Me.SettingTAB)
        Me.HuraTabControl1.Controls.Add(Me.SelfDestructTAB)
        Me.HuraTabControl1.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.HuraTabControl1.ItemSize = New System.Drawing.Size(0, 30)
        Me.HuraTabControl1.Location = New System.Drawing.Point(3, 29)
        Me.HuraTabControl1.Name = "HuraTabControl1"
        Me.HuraTabControl1.SelectedIndex = 0
        Me.HuraTabControl1.Size = New System.Drawing.Size(575, 257)
        Me.HuraTabControl1.TabIndex = 0
        '
        'ClickerTAB
        '
        Me.ClickerTAB.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClickerTAB.Controls.Add(Me.HuraButton6)
        Me.ClickerTAB.Controls.Add(Me.Label11)
        Me.ClickerTAB.Controls.Add(Me.Label10)
        Me.ClickerTAB.Controls.Add(Me.HuraButton3)
        Me.ClickerTAB.Controls.Add(Me.HuraTextBox1)
        Me.ClickerTAB.Controls.Add(Me.Label5)
        Me.ClickerTAB.Controls.Add(Me.Label4)
        Me.ClickerTAB.Controls.Add(Me.TrackBar2)
        Me.ClickerTAB.Controls.Add(Me.Label3)
        Me.ClickerTAB.Controls.Add(Me.Label2)
        Me.ClickerTAB.Controls.Add(Me.TrackBar1)
        Me.ClickerTAB.Location = New System.Drawing.Point(4, 34)
        Me.ClickerTAB.Name = "ClickerTAB"
        Me.ClickerTAB.Padding = New System.Windows.Forms.Padding(3)
        Me.ClickerTAB.Size = New System.Drawing.Size(567, 219)
        Me.ClickerTAB.TabIndex = 0
        Me.ClickerTAB.Text = "Clicker"
        '
        'HuraButton6
        '
        Me.HuraButton6.BackColor = System.Drawing.Color.Transparent
        Me.HuraButton6.BaseColour = System.Drawing.Color.White
        Me.HuraButton6.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.HuraButton6.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.HuraButton6.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton6.Location = New System.Drawing.Point(258, 184)
        Me.HuraButton6.Name = "HuraButton6"
        Me.HuraButton6.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.HuraButton6.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton6.Size = New System.Drawing.Size(138, 31)
        Me.HuraButton6.TabIndex = 10
        Me.HuraButton6.Text = "Start"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(251, 44)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 17)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Max CPS"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(255, 5)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 17)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Min CPS"
        '
        'HuraButton3
        '
        Me.HuraButton3.BackColor = System.Drawing.Color.Transparent
        Me.HuraButton3.BaseColour = System.Drawing.Color.White
        Me.HuraButton3.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.HuraButton3.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.HuraButton3.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton3.Location = New System.Drawing.Point(402, 184)
        Me.HuraButton3.Name = "HuraButton3"
        Me.HuraButton3.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.HuraButton3.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton3.Size = New System.Drawing.Size(159, 30)
        Me.HuraButton3.TabIndex = 7
        Me.HuraButton3.Text = "Bind"
        '
        'HuraTextBox1
        '
        Me.HuraTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.HuraTextBox1.BackgroundColour = System.Drawing.Color.White
        Me.HuraTextBox1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.HuraTextBox1.Location = New System.Drawing.Point(402, 150)
        Me.HuraTextBox1.MaxLength = 3
        Me.HuraTextBox1.Multiline = False
        Me.HuraTextBox1.Name = "HuraTextBox1"
        Me.HuraTextBox1.ReadOnly = False
        Me.HuraTextBox1.Size = New System.Drawing.Size(159, 29)
        Me.HuraTextBox1.Style = S_Clicker.HuraTextBox.Styles.Normal
        Me.HuraTextBox1.TabIndex = 6
        Me.HuraTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.HuraTextBox1.TextColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.HuraTextBox1.UseSystemPasswordChar = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(107, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 199)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Max Value CPS:"
        '
        'TrackBar2
        '
        Me.TrackBar2.Location = New System.Drawing.Point(7, 62)
        Me.TrackBar2.Maximum = 22
        Me.TrackBar2.Minimum = 1
        Me.TrackBar2.Name = "TrackBar2"
        Me.TrackBar2.Size = New System.Drawing.Size(555, 45)
        Me.TrackBar2.TabIndex = 3
        Me.TrackBar2.TickStyle = System.Windows.Forms.TickStyle.None
        Me.TrackBar2.Value = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(107, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Min Value CPS:"
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(6, 21)
        Me.TrackBar1.Maximum = 22
        Me.TrackBar1.Minimum = 1
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(555, 45)
        Me.TrackBar1.TabIndex = 0
        Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.None
        Me.TrackBar1.Value = 1
        '
        'WTapTAB
        '
        Me.WTapTAB.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.WTapTAB.Controls.Add(Me.HuraButton5)
        Me.WTapTAB.Controls.Add(Me.HuraButton4)
        Me.WTapTAB.Controls.Add(Me.HuraTextBox2)
        Me.WTapTAB.Controls.Add(Me.Label9)
        Me.WTapTAB.Controls.Add(Me.Label8)
        Me.WTapTAB.Controls.Add(Me.Label7)
        Me.WTapTAB.Controls.Add(Me.Label6)
        Me.WTapTAB.Controls.Add(Me.TrackBar4)
        Me.WTapTAB.Controls.Add(Me.TrackBar3)
        Me.WTapTAB.Location = New System.Drawing.Point(4, 34)
        Me.WTapTAB.Name = "WTapTAB"
        Me.WTapTAB.Size = New System.Drawing.Size(567, 219)
        Me.WTapTAB.TabIndex = 3
        Me.WTapTAB.Text = "W-Tap"
        '
        'HuraButton5
        '
        Me.HuraButton5.BackColor = System.Drawing.Color.Transparent
        Me.HuraButton5.BaseColour = System.Drawing.Color.White
        Me.HuraButton5.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.HuraButton5.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.HuraButton5.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton5.Location = New System.Drawing.Point(6, 173)
        Me.HuraButton5.Name = "HuraButton5"
        Me.HuraButton5.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.HuraButton5.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton5.Size = New System.Drawing.Size(132, 41)
        Me.HuraButton5.TabIndex = 6
        Me.HuraButton5.Text = "Start"
        '
        'HuraButton4
        '
        Me.HuraButton4.BackColor = System.Drawing.Color.Transparent
        Me.HuraButton4.BaseColour = System.Drawing.Color.White
        Me.HuraButton4.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.HuraButton4.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.HuraButton4.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton4.Location = New System.Drawing.Point(402, 184)
        Me.HuraButton4.Name = "HuraButton4"
        Me.HuraButton4.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.HuraButton4.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton4.Size = New System.Drawing.Size(159, 30)
        Me.HuraButton4.TabIndex = 5
        Me.HuraButton4.Text = "Bind"
        '
        'HuraTextBox2
        '
        Me.HuraTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.HuraTextBox2.BackgroundColour = System.Drawing.Color.White
        Me.HuraTextBox2.BorderColour = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.HuraTextBox2.Location = New System.Drawing.Point(402, 150)
        Me.HuraTextBox2.MaxLength = 3
        Me.HuraTextBox2.Multiline = False
        Me.HuraTextBox2.Name = "HuraTextBox2"
        Me.HuraTextBox2.ReadOnly = False
        Me.HuraTextBox2.Size = New System.Drawing.Size(159, 29)
        Me.HuraTextBox2.Style = S_Clicker.HuraTextBox.Styles.Normal
        Me.HuraTextBox2.TabIndex = 4
        Me.HuraTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.HuraTextBox2.TextColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.HuraTextBox2.UseSystemPasswordChar = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(367, 50)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 17)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(361, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(15, 17)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(208, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(153, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Maksymalne Opóźnienie:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(213, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 17)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Minimalne Opóźnienie:"
        '
        'TrackBar4
        '
        Me.TrackBar4.Location = New System.Drawing.Point(0, 74)
        Me.TrackBar4.Maximum = 500
        Me.TrackBar4.Minimum = 1
        Me.TrackBar4.Name = "TrackBar4"
        Me.TrackBar4.Size = New System.Drawing.Size(557, 45)
        Me.TrackBar4.TabIndex = 0
        Me.TrackBar4.TickStyle = System.Windows.Forms.TickStyle.None
        Me.TrackBar4.Value = 1
        '
        'TrackBar3
        '
        Me.TrackBar3.Location = New System.Drawing.Point(5, 23)
        Me.TrackBar3.Maximum = 500
        Me.TrackBar3.Minimum = 1
        Me.TrackBar3.Name = "TrackBar3"
        Me.TrackBar3.Size = New System.Drawing.Size(557, 45)
        Me.TrackBar3.TabIndex = 0
        Me.TrackBar3.TickStyle = System.Windows.Forms.TickStyle.None
        Me.TrackBar3.Value = 1
        '
        'SettingTAB
        '
        Me.SettingTAB.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SettingTAB.Controls.Add(Me.Label12)
        Me.SettingTAB.Controls.Add(Me.HuraButton2)
        Me.SettingTAB.Controls.Add(Me.HuraCheckBox1)
        Me.SettingTAB.Controls.Add(Me.Label1)
        Me.SettingTAB.Controls.Add(Me.HuraComboBox1)
        Me.SettingTAB.Controls.Add(Me.HuraAlertBox1)
        Me.SettingTAB.Location = New System.Drawing.Point(4, 34)
        Me.SettingTAB.Name = "SettingTAB"
        Me.SettingTAB.Padding = New System.Windows.Forms.Padding(3)
        Me.SettingTAB.Size = New System.Drawing.Size(567, 219)
        Me.SettingTAB.TabIndex = 1
        Me.SettingTAB.Text = "Settings"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 11.5!)
        Me.Label12.Location = New System.Drawing.Point(347, 70)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(145, 21)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Zmiana Koloru GUI:"
        '
        'HuraButton2
        '
        Me.HuraButton2.BackColor = System.Drawing.Color.Transparent
        Me.HuraButton2.BaseColour = System.Drawing.Color.White
        Me.HuraButton2.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.HuraButton2.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.HuraButton2.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton2.Location = New System.Drawing.Point(10, 60)
        Me.HuraButton2.Name = "HuraButton2"
        Me.HuraButton2.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.HuraButton2.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton2.Size = New System.Drawing.Size(182, 31)
        Me.HuraButton2.TabIndex = 4
        Me.HuraButton2.Text = "Bind"
        '
        'HuraCheckBox1
        '
        Me.HuraCheckBox1.BaseColour = System.Drawing.Color.White
        Me.HuraCheckBox1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.HuraCheckBox1.Checked = False
        Me.HuraCheckBox1.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.HuraCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HuraCheckBox1.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.HuraCheckBox1.Location = New System.Drawing.Point(10, 191)
        Me.HuraCheckBox1.Name = "HuraCheckBox1"
        Me.HuraCheckBox1.Size = New System.Drawing.Size(111, 22)
        Me.HuraCheckBox1.TabIndex = 3
        Me.HuraCheckBox1.Text = "Only in MC"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Label1.Location = New System.Drawing.Point(6, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Przycisk ukrycia:"
        '
        'HuraComboBox1
        '
        Me.HuraComboBox1.AccentColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.HuraComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraComboBox1.ColorScheme = S_Clicker.HuraComboBox.ColorSchemes.Dark
        Me.HuraComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.HuraComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.HuraComboBox1.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.HuraComboBox1.ForeColor = System.Drawing.Color.White
        Me.HuraComboBox1.FormattingEnabled = True
        Me.HuraComboBox1.Items.AddRange(New Object() {"U", "I", "O", "P", "G", "H", "J", "K", "L", "Z", "X", "C", "V", "B", "N", "M"})
        Me.HuraComboBox1.Location = New System.Drawing.Point(10, 28)
        Me.HuraComboBox1.Name = "HuraComboBox1"
        Me.HuraComboBox1.Size = New System.Drawing.Size(182, 25)
        Me.HuraComboBox1.TabIndex = 1
        '
        'HuraAlertBox1
        '
        Me.HuraAlertBox1.AlertStyle = S_Clicker.HuraAlertBox.Style.Informations
        Me.HuraAlertBox1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.HuraAlertBox1.Location = New System.Drawing.Point(288, 6)
        Me.HuraAlertBox1.Name = "HuraAlertBox1"
        Me.HuraAlertBox1.Size = New System.Drawing.Size(273, 40)
        Me.HuraAlertBox1.TabIndex = 0
        Me.HuraAlertBox1.Text = "You have the newest version of clicker!"
        '
        'SelfDestructTAB
        '
        Me.SelfDestructTAB.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SelfDestructTAB.Controls.Add(Me.HuraButton1)
        Me.SelfDestructTAB.Location = New System.Drawing.Point(4, 34)
        Me.SelfDestructTAB.Name = "SelfDestructTAB"
        Me.SelfDestructTAB.Size = New System.Drawing.Size(567, 219)
        Me.SelfDestructTAB.TabIndex = 2
        Me.SelfDestructTAB.Text = "Self-Destruct"
        '
        'HuraButton1
        '
        Me.HuraButton1.BackColor = System.Drawing.Color.Transparent
        Me.HuraButton1.BaseColour = System.Drawing.Color.White
        Me.HuraButton1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.HuraButton1.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.HuraButton1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton1.Location = New System.Drawing.Point(191, 79)
        Me.HuraButton1.Name = "HuraButton1"
        Me.HuraButton1.PressedColour = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.HuraButton1.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HuraButton1.Size = New System.Drawing.Size(185, 52)
        Me.HuraButton1.TabIndex = 0
        Me.HuraButton1.Text = "Destruct"
        '
        'SMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 289)
        Me.Controls.Add(Me.HuraForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(581, 289)
        Me.Name = "SMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.HuraForm1.ResumeLayout(False)
        Me.HuraTabControl1.ResumeLayout(False)
        Me.ClickerTAB.ResumeLayout(False)
        Me.ClickerTAB.PerformLayout()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WTapTAB.ResumeLayout(False)
        Me.WTapTAB.PerformLayout()
        CType(Me.TrackBar4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SettingTAB.ResumeLayout(False)
        Me.SettingTAB.PerformLayout()
        Me.SelfDestructTAB.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HuraForm1 As HuraForm
    Friend WithEvents HuraTabControl1 As HuraTabControl
    Friend WithEvents ClickerTAB As TabPage
    Friend WithEvents WTapTAB As TabPage
    Friend WithEvents SettingTAB As TabPage
    Friend WithEvents SelfDestructTAB As TabPage
    Friend WithEvents HuraButton1 As HuraButton
    Friend WithEvents HuraControlBox1 As HuraControlBox
    Friend WithEvents Label1 As Label
    Friend WithEvents HuraComboBox1 As HuraComboBox
    Friend WithEvents HuraAlertBox1 As HuraAlertBox
    Friend WithEvents HuraCheckBox1 As HuraCheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents HuraButton2 As HuraButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TrackBar2 As TrackBar
    Friend WithEvents HuraButton3 As HuraButton
    Friend WithEvents HuraTextBox1 As HuraTextBox
    Friend WithEvents TrackBar3 As TrackBar
    Friend WithEvents HuraButton5 As HuraButton
    Friend WithEvents HuraButton4 As HuraButton
    Friend WithEvents HuraTextBox2 As HuraTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TrackBar4 As TrackBar
    Friend WithEvents AutoClicker As Timer
    Friend WithEvents WTap As Timer
    Friend WithEvents HideButton As Timer
    Friend WithEvents Bind As Timer
    Friend WithEvents HuraButton6 As HuraButton
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
End Class
