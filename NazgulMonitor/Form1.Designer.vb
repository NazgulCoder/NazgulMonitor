<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ThirteenForm1 = New NazgulMonitor.ThirteenForm()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.ThirteenCheckBox8 = New NazgulMonitor.ThirteenCheckBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.ThirteenCheckBox7 = New NazgulMonitor.ThirteenCheckBox()
        Me.ThirteenButton6 = New NazgulMonitor.ThirteenButton()
        Me.ThirteenCheckBox6 = New NazgulMonitor.ThirteenCheckBox()
        Me.ThirteenButton5 = New NazgulMonitor.ThirteenButton()
        Me.ThirteenCheckBox5 = New NazgulMonitor.ThirteenCheckBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ThirteenTextBox2 = New NazgulMonitor.ThirteenTextBox()
        Me.ThirteenCheckBox4 = New NazgulMonitor.ThirteenCheckBox()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ThirteenCheckBox3 = New NazgulMonitor.ThirteenCheckBox()
        Me.ThirteenCheckBox2 = New NazgulMonitor.ThirteenCheckBox()
        Me.ThirteenTextBox1 = New NazgulMonitor.ThirteenTextBox()
        Me.ThirteenButton4 = New NazgulMonitor.ThirteenButton()
        Me.ThirteenButton3 = New NazgulMonitor.ThirteenButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ThirteenCheckBox1 = New NazgulMonitor.ThirteenCheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ThirteenButton2 = New NazgulMonitor.ThirteenButton()
        Me.ThirteenButton1 = New NazgulMonitor.ThirteenButton()
        Me.ThirteenForm1.SuspendLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Timer3
        '
        Me.Timer3.Interval = 60000
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'ThirteenForm1
        '
        Me.ThirteenForm1.AccentColor = System.Drawing.Color.DodgerBlue
        Me.ThirteenForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ThirteenForm1.ColorScheme = NazgulMonitor.ThirteenForm.ColorSchemes.Dark
        Me.ThirteenForm1.Controls.Add(Me.Label18)
        Me.ThirteenForm1.Controls.Add(Me.Label17)
        Me.ThirteenForm1.Controls.Add(Me.NumericUpDown2)
        Me.ThirteenForm1.Controls.Add(Me.ThirteenCheckBox8)
        Me.ThirteenForm1.Controls.Add(Me.Label16)
        Me.ThirteenForm1.Controls.Add(Me.NumericUpDown1)
        Me.ThirteenForm1.Controls.Add(Me.ThirteenCheckBox7)
        Me.ThirteenForm1.Controls.Add(Me.ThirteenButton6)
        Me.ThirteenForm1.Controls.Add(Me.ThirteenCheckBox6)
        Me.ThirteenForm1.Controls.Add(Me.ThirteenButton5)
        Me.ThirteenForm1.Controls.Add(Me.ThirteenCheckBox5)
        Me.ThirteenForm1.Controls.Add(Me.Label15)
        Me.ThirteenForm1.Controls.Add(Me.Label14)
        Me.ThirteenForm1.Controls.Add(Me.Label13)
        Me.ThirteenForm1.Controls.Add(Me.Label12)
        Me.ThirteenForm1.Controls.Add(Me.Label11)
        Me.ThirteenForm1.Controls.Add(Me.Label10)
        Me.ThirteenForm1.Controls.Add(Me.ThirteenTextBox2)
        Me.ThirteenForm1.Controls.Add(Me.ThirteenCheckBox4)
        Me.ThirteenForm1.Controls.Add(Me.TrackBar1)
        Me.ThirteenForm1.Controls.Add(Me.Label6)
        Me.ThirteenForm1.Controls.Add(Me.ThirteenCheckBox3)
        Me.ThirteenForm1.Controls.Add(Me.ThirteenCheckBox2)
        Me.ThirteenForm1.Controls.Add(Me.ThirteenTextBox1)
        Me.ThirteenForm1.Controls.Add(Me.ThirteenButton4)
        Me.ThirteenForm1.Controls.Add(Me.ThirteenButton3)
        Me.ThirteenForm1.Controls.Add(Me.PictureBox1)
        Me.ThirteenForm1.Controls.Add(Me.ThirteenCheckBox1)
        Me.ThirteenForm1.Controls.Add(Me.Label9)
        Me.ThirteenForm1.Controls.Add(Me.Label8)
        Me.ThirteenForm1.Controls.Add(Me.Label7)
        Me.ThirteenForm1.Controls.Add(Me.Label5)
        Me.ThirteenForm1.Controls.Add(Me.Label4)
        Me.ThirteenForm1.Controls.Add(Me.Label3)
        Me.ThirteenForm1.Controls.Add(Me.Label2)
        Me.ThirteenForm1.Controls.Add(Me.Label1)
        Me.ThirteenForm1.Controls.Add(Me.ThirteenButton2)
        Me.ThirteenForm1.Controls.Add(Me.ThirteenButton1)
        Me.ThirteenForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ThirteenForm1.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.ThirteenForm1.ForeColor = System.Drawing.Color.White
        Me.ThirteenForm1.Location = New System.Drawing.Point(0, 0)
        Me.ThirteenForm1.Name = "ThirteenForm1"
        Me.ThirteenForm1.Size = New System.Drawing.Size(414, 545)
        Me.ThirteenForm1.TabIndex = 0
        Me.ThirteenForm1.Text = "NazgulMonitor"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Location = New System.Drawing.Point(175, 342)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(84, 17)
        Me.Label18.TabIndex = 39
        Me.Label18.Text = "Refresh every"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Location = New System.Drawing.Point(327, 342)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(52, 17)
        Me.Label17.TabIndex = 38
        Me.Label17.Text = "seconds"
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(265, 334)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {3600, 0, 0, 0})
        Me.NumericUpDown2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(56, 25)
        Me.NumericUpDown2.TabIndex = 37
        Me.NumericUpDown2.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ThirteenCheckBox8
        '
        Me.ThirteenCheckBox8.BackColor = System.Drawing.Color.Transparent
        Me.ThirteenCheckBox8.Checked = True
        Me.ThirteenCheckBox8.ColorScheme = NazgulMonitor.ThirteenCheckBox.ColorSchemes.Dark
        Me.ThirteenCheckBox8.ForeColor = System.Drawing.Color.White
        Me.ThirteenCheckBox8.Location = New System.Drawing.Point(241, 150)
        Me.ThirteenCheckBox8.Name = "ThirteenCheckBox8"
        Me.ThirteenCheckBox8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ThirteenCheckBox8.Size = New System.Drawing.Size(136, 17)
        Me.ThirteenCheckBox8.TabIndex = 36
        Me.ThirteenCheckBox8.Text = "Send Telegram Alerts"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(327, 312)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(82, 17)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "after minutes"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(265, 304)
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(56, 25)
        Me.NumericUpDown1.TabIndex = 34
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ThirteenCheckBox7
        '
        Me.ThirteenCheckBox7.BackColor = System.Drawing.Color.Transparent
        Me.ThirteenCheckBox7.Checked = False
        Me.ThirteenCheckBox7.ColorScheme = NazgulMonitor.ThirteenCheckBox.ColorSchemes.Dark
        Me.ThirteenCheckBox7.ForeColor = System.Drawing.Color.White
        Me.ThirteenCheckBox7.Location = New System.Drawing.Point(165, 309)
        Me.ThirteenCheckBox7.Name = "ThirteenCheckBox7"
        Me.ThirteenCheckBox7.Size = New System.Drawing.Size(93, 17)
        Me.ThirteenCheckBox7.TabIndex = 33
        Me.ThirteenCheckBox7.Text = "AutoRestart?"
        '
        'ThirteenButton6
        '
        Me.ThirteenButton6.AccentColor = System.Drawing.Color.DodgerBlue
        Me.ThirteenButton6.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ThirteenButton6.ColorScheme = NazgulMonitor.ThirteenButton.ColorSchemes.Dark
        Me.ThirteenButton6.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.ThirteenButton6.ForeColor = System.Drawing.Color.White
        Me.ThirteenButton6.Location = New System.Drawing.Point(84, 335)
        Me.ThirteenButton6.Name = "ThirteenButton6"
        Me.ThirteenButton6.Size = New System.Drawing.Size(75, 23)
        Me.ThirteenButton6.TabIndex = 32
        Me.ThirteenButton6.Text = "Reset"
        Me.ThirteenButton6.UseVisualStyleBackColor = False
        '
        'ThirteenCheckBox6
        '
        Me.ThirteenCheckBox6.BackColor = System.Drawing.Color.Transparent
        Me.ThirteenCheckBox6.Checked = False
        Me.ThirteenCheckBox6.ColorScheme = NazgulMonitor.ThirteenCheckBox.ColorSchemes.Dark
        Me.ThirteenCheckBox6.ForeColor = System.Drawing.Color.White
        Me.ThirteenCheckBox6.Location = New System.Drawing.Point(278, 520)
        Me.ThirteenCheckBox6.Name = "ThirteenCheckBox6"
        Me.ThirteenCheckBox6.Size = New System.Drawing.Size(119, 17)
        Me.ThirteenCheckBox6.TabIndex = 31
        Me.ThirteenCheckBox6.Text = "Keep me TopMost"
        '
        'ThirteenButton5
        '
        Me.ThirteenButton5.AccentColor = System.Drawing.Color.DodgerBlue
        Me.ThirteenButton5.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ThirteenButton5.ColorScheme = NazgulMonitor.ThirteenButton.ColorSchemes.Dark
        Me.ThirteenButton5.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.ThirteenButton5.ForeColor = System.Drawing.Color.White
        Me.ThirteenButton5.Location = New System.Drawing.Point(3, 335)
        Me.ThirteenButton5.Name = "ThirteenButton5"
        Me.ThirteenButton5.Size = New System.Drawing.Size(75, 23)
        Me.ThirteenButton5.TabIndex = 30
        Me.ThirteenButton5.Text = "Clear Logs"
        Me.ThirteenButton5.UseVisualStyleBackColor = False
        '
        'ThirteenCheckBox5
        '
        Me.ThirteenCheckBox5.BackColor = System.Drawing.Color.Transparent
        Me.ThirteenCheckBox5.Checked = True
        Me.ThirteenCheckBox5.ColorScheme = NazgulMonitor.ThirteenCheckBox.ColorSchemes.Dark
        Me.ThirteenCheckBox5.ForeColor = System.Drawing.Color.White
        Me.ThirteenCheckBox5.Location = New System.Drawing.Point(241, 58)
        Me.ThirteenCheckBox5.Name = "ThirteenCheckBox5"
        Me.ThirteenCheckBox5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ThirteenCheckBox5.Size = New System.Drawing.Size(119, 17)
        Me.ThirteenCheckBox5.TabIndex = 29
        Me.ThirteenCheckBox5.Text = "GPU Temperature"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(265, 243)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(108, 17)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "GPU Temperature"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(3, 103)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(36, 17)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "GPU:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(265, 226)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 17)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "RAM Usage"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(108, 243)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 17)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "CPU Usage"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(108, 226)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 17)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "CPU Temperature"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 226)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 17)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Send logs when:"
        '
        'ThirteenTextBox2
        '
        Me.ThirteenTextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ThirteenTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ThirteenTextBox2.ColorScheme = NazgulMonitor.ThirteenTextBox.ColorSchemes.Dark
        Me.ThirteenTextBox2.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.ThirteenTextBox2.ForeColor = System.Drawing.Color.White
        Me.ThirteenTextBox2.Location = New System.Drawing.Point(241, 173)
        Me.ThirteenTextBox2.Name = "ThirteenTextBox2"
        Me.ThirteenTextBox2.Size = New System.Drawing.Size(170, 25)
        Me.ThirteenTextBox2.TabIndex = 22
        '
        'ThirteenCheckBox4
        '
        Me.ThirteenCheckBox4.BackColor = System.Drawing.Color.Transparent
        Me.ThirteenCheckBox4.Checked = True
        Me.ThirteenCheckBox4.ColorScheme = NazgulMonitor.ThirteenCheckBox.ColorSchemes.Dark
        Me.ThirteenCheckBox4.ForeColor = System.Drawing.Color.White
        Me.ThirteenCheckBox4.Location = New System.Drawing.Point(241, 127)
        Me.ThirteenCheckBox4.Name = "ThirteenCheckBox4"
        Me.ThirteenCheckBox4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ThirteenCheckBox4.Size = New System.Drawing.Size(122, 17)
        Me.ThirteenCheckBox4.TabIndex = 21
        Me.ThirteenCheckBox4.Text = "Save Logs to .CSV"
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(165, 274)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Minimum = 25
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(246, 45)
        Me.TrackBar1.SmallChange = 10
        Me.TrackBar1.TabIndex = 20
        Me.TrackBar1.TickFrequency = 5
        Me.TrackBar1.Value = 80
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 17)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Internal IP"
        '
        'ThirteenCheckBox3
        '
        Me.ThirteenCheckBox3.BackColor = System.Drawing.Color.Transparent
        Me.ThirteenCheckBox3.Checked = True
        Me.ThirteenCheckBox3.ColorScheme = NazgulMonitor.ThirteenCheckBox.ColorSchemes.Dark
        Me.ThirteenCheckBox3.ForeColor = System.Drawing.Color.White
        Me.ThirteenCheckBox3.Location = New System.Drawing.Point(241, 104)
        Me.ThirteenCheckBox3.Name = "ThirteenCheckBox3"
        Me.ThirteenCheckBox3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ThirteenCheckBox3.Size = New System.Drawing.Size(151, 17)
        Me.ThirteenCheckBox3.TabIndex = 18
        Me.ThirteenCheckBox3.Text = "Send Logs to Webserver"
        '
        'ThirteenCheckBox2
        '
        Me.ThirteenCheckBox2.BackColor = System.Drawing.Color.Transparent
        Me.ThirteenCheckBox2.Checked = True
        Me.ThirteenCheckBox2.ColorScheme = NazgulMonitor.ThirteenCheckBox.ColorSchemes.Dark
        Me.ThirteenCheckBox2.ForeColor = System.Drawing.Color.White
        Me.ThirteenCheckBox2.Location = New System.Drawing.Point(241, 81)
        Me.ThirteenCheckBox2.Name = "ThirteenCheckBox2"
        Me.ThirteenCheckBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ThirteenCheckBox2.Size = New System.Drawing.Size(97, 17)
        Me.ThirteenCheckBox2.TabIndex = 17
        Me.ThirteenCheckBox2.Text = "Network Stats"
        '
        'ThirteenTextBox1
        '
        Me.ThirteenTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ThirteenTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ThirteenTextBox1.ColorScheme = NazgulMonitor.ThirteenTextBox.ColorSchemes.Dark
        Me.ThirteenTextBox1.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.ThirteenTextBox1.ForeColor = System.Drawing.Color.White
        Me.ThirteenTextBox1.Location = New System.Drawing.Point(3, 365)
        Me.ThirteenTextBox1.Multiline = True
        Me.ThirteenTextBox1.Name = "ThirteenTextBox1"
        Me.ThirteenTextBox1.ReadOnly = True
        Me.ThirteenTextBox1.Size = New System.Drawing.Size(408, 149)
        Me.ThirteenTextBox1.TabIndex = 16
        '
        'ThirteenButton4
        '
        Me.ThirteenButton4.AccentColor = System.Drawing.Color.DodgerBlue
        Me.ThirteenButton4.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ThirteenButton4.ColorScheme = NazgulMonitor.ThirteenButton.ColorSchemes.Dark
        Me.ThirteenButton4.Enabled = False
        Me.ThirteenButton4.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.ThirteenButton4.ForeColor = System.Drawing.Color.White
        Me.ThirteenButton4.Location = New System.Drawing.Point(84, 306)
        Me.ThirteenButton4.Name = "ThirteenButton4"
        Me.ThirteenButton4.Size = New System.Drawing.Size(75, 23)
        Me.ThirteenButton4.TabIndex = 15
        Me.ThirteenButton4.Text = "Stop"
        Me.ThirteenButton4.UseVisualStyleBackColor = False
        '
        'ThirteenButton3
        '
        Me.ThirteenButton3.AccentColor = System.Drawing.Color.DodgerBlue
        Me.ThirteenButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ThirteenButton3.ColorScheme = NazgulMonitor.ThirteenButton.ColorSchemes.Dark
        Me.ThirteenButton3.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.ThirteenButton3.ForeColor = System.Drawing.Color.White
        Me.ThirteenButton3.Location = New System.Drawing.Point(3, 306)
        Me.ThirteenButton3.Name = "ThirteenButton3"
        Me.ThirteenButton3.Size = New System.Drawing.Size(75, 23)
        Me.ThirteenButton3.TabIndex = 14
        Me.ThirteenButton3.Text = "Start"
        Me.ThirteenButton3.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-79, 208)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(570, 15)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'ThirteenCheckBox1
        '
        Me.ThirteenCheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.ThirteenCheckBox1.Checked = True
        Me.ThirteenCheckBox1.ColorScheme = NazgulMonitor.ThirteenCheckBox.ColorSchemes.Dark
        Me.ThirteenCheckBox1.ForeColor = System.Drawing.Color.White
        Me.ThirteenCheckBox1.Location = New System.Drawing.Point(241, 35)
        Me.ThirteenCheckBox1.Name = "ThirteenCheckBox1"
        Me.ThirteenCheckBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ThirteenCheckBox1.Size = New System.Drawing.Size(118, 17)
        Me.ThirteenCheckBox1.TabIndex = 12
        Me.ThirteenCheckBox1.Text = "CPU Temperature"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 86)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 17)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "CPU: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 171)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 17)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Download: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 154)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 17)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Upload: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "RAM:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Ping: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "CPU: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Windows Version"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(3, 520)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Time"
        '
        'ThirteenButton2
        '
        Me.ThirteenButton2.AccentColor = System.Drawing.Color.DodgerBlue
        Me.ThirteenButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ThirteenButton2.ColorScheme = NazgulMonitor.ThirteenButton.ColorSchemes.Dark
        Me.ThirteenButton2.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.ThirteenButton2.ForeColor = System.Drawing.Color.White
        Me.ThirteenButton2.Location = New System.Drawing.Point(391, 3)
        Me.ThirteenButton2.Name = "ThirteenButton2"
        Me.ThirteenButton2.Size = New System.Drawing.Size(20, 23)
        Me.ThirteenButton2.TabIndex = 1
        Me.ThirteenButton2.Text = "X"
        Me.ThirteenButton2.UseVisualStyleBackColor = False
        '
        'ThirteenButton1
        '
        Me.ThirteenButton1.AccentColor = System.Drawing.Color.DodgerBlue
        Me.ThirteenButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ThirteenButton1.ColorScheme = NazgulMonitor.ThirteenButton.ColorSchemes.Dark
        Me.ThirteenButton1.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.ThirteenButton1.ForeColor = System.Drawing.Color.White
        Me.ThirteenButton1.Location = New System.Drawing.Point(365, 3)
        Me.ThirteenButton1.Name = "ThirteenButton1"
        Me.ThirteenButton1.Size = New System.Drawing.Size(20, 23)
        Me.ThirteenButton1.TabIndex = 0
        Me.ThirteenButton1.Text = "_"
        Me.ThirteenButton1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 545)
        Me.Controls.Add(Me.ThirteenForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "NazgulMonitor"
        Me.ThirteenForm1.ResumeLayout(False)
        Me.ThirteenForm1.PerformLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ThirteenForm1 As ThirteenForm
    Friend WithEvents ThirteenButton2 As ThirteenButton
    Friend WithEvents ThirteenButton1 As ThirteenButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ThirteenButton4 As ThirteenButton
    Friend WithEvents ThirteenButton3 As ThirteenButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ThirteenCheckBox1 As ThirteenCheckBox
    Friend WithEvents ThirteenTextBox1 As ThirteenTextBox
    Friend WithEvents ThirteenCheckBox2 As ThirteenCheckBox
    Friend WithEvents ThirteenCheckBox3 As ThirteenCheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents ThirteenTextBox2 As ThirteenTextBox
    Friend WithEvents ThirteenCheckBox4 As ThirteenCheckBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Timer3 As Timer
    Friend WithEvents ThirteenCheckBox5 As ThirteenCheckBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents ThirteenButton5 As ThirteenButton
    Friend WithEvents ThirteenCheckBox6 As ThirteenCheckBox
    Friend WithEvents ThirteenButton6 As ThirteenButton
    Friend WithEvents Label16 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents ThirteenCheckBox7 As ThirteenCheckBox
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ThirteenCheckBox8 As ThirteenCheckBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents NumericUpDown2 As NumericUpDown
End Class
