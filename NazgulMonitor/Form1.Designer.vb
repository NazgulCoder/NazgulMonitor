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
        Me.MinimizeButton = New NazgulMonitor.ThirteenButton()
        Me.CloseButton = New NazgulMonitor.ThirteenButton()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.WinVersionLabel = New System.Windows.Forms.Label()
        Me.CPUUsageLabel = New System.Windows.Forms.Label()
        Me.PingLabel = New System.Windows.Forms.Label()
        Me.RAMUsageLabel = New System.Windows.Forms.Label()
        Me.UploadLabel = New System.Windows.Forms.Label()
        Me.DownloadLabel = New System.Windows.Forms.Label()
        Me.CPUTempLabel = New System.Windows.Forms.Label()
        Me.CPUTempCheckBox = New NazgulMonitor.ThirteenCheckBox()
        Me.SeparatorImage = New System.Windows.Forms.PictureBox()
        Me.StartMonitorButton = New NazgulMonitor.ThirteenButton()
        Me.StopButton = New NazgulMonitor.ThirteenButton()
        Me.LogsTextBox = New NazgulMonitor.ThirteenTextBox()
        Me.NetworkStatsCheckBox = New NazgulMonitor.ThirteenCheckBox()
        Me.WebserverCheckBox = New NazgulMonitor.ThirteenCheckBox()
        Me.IntIPLabel = New System.Windows.Forms.Label()
        Me.SendLogsTrackbar = New System.Windows.Forms.TrackBar()
        Me.LocalCSVCheckBox = New NazgulMonitor.ThirteenCheckBox()
        Me.WebserverTextBox = New NazgulMonitor.ThirteenTextBox()
        Me.SendLogsLabel = New System.Windows.Forms.Label()
        Me.SendLogsCPUTempLabel = New System.Windows.Forms.Label()
        Me.SendLogsCPUUsageLabel = New System.Windows.Forms.Label()
        Me.SendLogsRAMUsageLabel = New System.Windows.Forms.Label()
        Me.GPUTempLabel = New System.Windows.Forms.Label()
        Me.SendLogsGPUTempLabel = New System.Windows.Forms.Label()
        Me.GPUTempCheckBox = New NazgulMonitor.ThirteenCheckBox()
        Me.ClearLogsButton = New NazgulMonitor.ThirteenButton()
        Me.TopMostCheckBox = New NazgulMonitor.ThirteenCheckBox()
        Me.ResetButton = New NazgulMonitor.ThirteenButton()
        Me.AutoRestartCheckBox = New NazgulMonitor.ThirteenCheckBox()
        Me.AutoRestartMinutesUpDownNumeric = New System.Windows.Forms.NumericUpDown()
        Me.afterMinutesLabel = New System.Windows.Forms.Label()
        Me.TelegramAlertCheckBox = New NazgulMonitor.ThirteenCheckBox()
        Me.RefreshEveryUpDownNumeric = New System.Windows.Forms.NumericUpDown()
        Me.secondsLabel = New System.Windows.Forms.Label()
        Me.refreshLabel = New System.Windows.Forms.Label()
        Me.ThirteenForm1 = New NazgulMonitor.ThirteenForm()
        CType(Me.SeparatorImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SendLogsTrackbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutoRestartMinutesUpDownNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RefreshEveryUpDownNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ThirteenForm1.SuspendLayout()
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
        'MinimizeButton
        '
        Me.MinimizeButton.AccentColor = System.Drawing.Color.DodgerBlue
        Me.MinimizeButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.MinimizeButton.ColorScheme = NazgulMonitor.ThirteenButton.ColorSchemes.Dark
        Me.MinimizeButton.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.MinimizeButton.ForeColor = System.Drawing.Color.White
        Me.MinimizeButton.Location = New System.Drawing.Point(365, 3)
        Me.MinimizeButton.Name = "MinimizeButton"
        Me.MinimizeButton.Size = New System.Drawing.Size(20, 23)
        Me.MinimizeButton.TabIndex = 0
        Me.MinimizeButton.Text = "_"
        Me.MinimizeButton.UseVisualStyleBackColor = False
        '
        'CloseButton
        '
        Me.CloseButton.AccentColor = System.Drawing.Color.DodgerBlue
        Me.CloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.CloseButton.ColorScheme = NazgulMonitor.ThirteenButton.ColorSchemes.Dark
        Me.CloseButton.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.CloseButton.ForeColor = System.Drawing.Color.White
        Me.CloseButton.Location = New System.Drawing.Point(391, 3)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(20, 23)
        Me.CloseButton.TabIndex = 1
        Me.CloseButton.Text = "X"
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.BackColor = System.Drawing.Color.Transparent
        Me.TimeLabel.Location = New System.Drawing.Point(3, 520)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(36, 17)
        Me.TimeLabel.TabIndex = 2
        Me.TimeLabel.Text = "Time"
        '
        'WinVersionLabel
        '
        Me.WinVersionLabel.AutoSize = True
        Me.WinVersionLabel.Location = New System.Drawing.Point(3, 35)
        Me.WinVersionLabel.Name = "WinVersionLabel"
        Me.WinVersionLabel.Size = New System.Drawing.Size(102, 17)
        Me.WinVersionLabel.TabIndex = 3
        Me.WinVersionLabel.Text = "Windows Version"
        '
        'CPUUsageLabel
        '
        Me.CPUUsageLabel.AutoSize = True
        Me.CPUUsageLabel.Location = New System.Drawing.Point(3, 120)
        Me.CPUUsageLabel.Name = "CPUUsageLabel"
        Me.CPUUsageLabel.Size = New System.Drawing.Size(39, 17)
        Me.CPUUsageLabel.TabIndex = 4
        Me.CPUUsageLabel.Text = "CPU: "
        '
        'PingLabel
        '
        Me.PingLabel.AutoSize = True
        Me.PingLabel.Location = New System.Drawing.Point(3, 69)
        Me.PingLabel.Name = "PingLabel"
        Me.PingLabel.Size = New System.Drawing.Size(39, 17)
        Me.PingLabel.TabIndex = 5
        Me.PingLabel.Text = "Ping: "
        '
        'RAMUsageLabel
        '
        Me.RAMUsageLabel.AutoSize = True
        Me.RAMUsageLabel.Location = New System.Drawing.Point(3, 137)
        Me.RAMUsageLabel.Name = "RAMUsageLabel"
        Me.RAMUsageLabel.Size = New System.Drawing.Size(37, 17)
        Me.RAMUsageLabel.TabIndex = 6
        Me.RAMUsageLabel.Text = "RAM:"
        '
        'UploadLabel
        '
        Me.UploadLabel.AutoSize = True
        Me.UploadLabel.Location = New System.Drawing.Point(3, 154)
        Me.UploadLabel.Name = "UploadLabel"
        Me.UploadLabel.Size = New System.Drawing.Size(55, 17)
        Me.UploadLabel.TabIndex = 9
        Me.UploadLabel.Text = "Upload: "
        '
        'DownloadLabel
        '
        Me.DownloadLabel.AutoSize = True
        Me.DownloadLabel.Location = New System.Drawing.Point(3, 171)
        Me.DownloadLabel.Name = "DownloadLabel"
        Me.DownloadLabel.Size = New System.Drawing.Size(71, 17)
        Me.DownloadLabel.TabIndex = 10
        Me.DownloadLabel.Text = "Download: "
        '
        'CPUTempLabel
        '
        Me.CPUTempLabel.AutoSize = True
        Me.CPUTempLabel.Location = New System.Drawing.Point(3, 86)
        Me.CPUTempLabel.Name = "CPUTempLabel"
        Me.CPUTempLabel.Size = New System.Drawing.Size(39, 17)
        Me.CPUTempLabel.TabIndex = 11
        Me.CPUTempLabel.Text = "CPU: "
        '
        'CPUTempCheckBox
        '
        Me.CPUTempCheckBox.BackColor = System.Drawing.Color.Transparent
        Me.CPUTempCheckBox.Checked = True
        Me.CPUTempCheckBox.ColorScheme = NazgulMonitor.ThirteenCheckBox.ColorSchemes.Dark
        Me.CPUTempCheckBox.ForeColor = System.Drawing.Color.White
        Me.CPUTempCheckBox.Location = New System.Drawing.Point(241, 35)
        Me.CPUTempCheckBox.Name = "CPUTempCheckBox"
        Me.CPUTempCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CPUTempCheckBox.Size = New System.Drawing.Size(130, 17)
        Me.CPUTempCheckBox.TabIndex = 12
        Me.CPUTempCheckBox.Text = "CPU Temperature"
        '
        'SeparatorImage
        '
        Me.SeparatorImage.BackColor = System.Drawing.Color.Transparent
        Me.SeparatorImage.Image = CType(resources.GetObject("SeparatorImage.Image"), System.Drawing.Image)
        Me.SeparatorImage.Location = New System.Drawing.Point(-79, 208)
        Me.SeparatorImage.Name = "SeparatorImage"
        Me.SeparatorImage.Size = New System.Drawing.Size(570, 15)
        Me.SeparatorImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SeparatorImage.TabIndex = 13
        Me.SeparatorImage.TabStop = False
        '
        'StartMonitorButton
        '
        Me.StartMonitorButton.AccentColor = System.Drawing.Color.DodgerBlue
        Me.StartMonitorButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.StartMonitorButton.ColorScheme = NazgulMonitor.ThirteenButton.ColorSchemes.Dark
        Me.StartMonitorButton.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.StartMonitorButton.ForeColor = System.Drawing.Color.White
        Me.StartMonitorButton.Location = New System.Drawing.Point(3, 306)
        Me.StartMonitorButton.Name = "StartMonitorButton"
        Me.StartMonitorButton.Size = New System.Drawing.Size(75, 23)
        Me.StartMonitorButton.TabIndex = 14
        Me.StartMonitorButton.Text = "Start"
        Me.StartMonitorButton.UseVisualStyleBackColor = False
        '
        'StopButton
        '
        Me.StopButton.AccentColor = System.Drawing.Color.DodgerBlue
        Me.StopButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.StopButton.ColorScheme = NazgulMonitor.ThirteenButton.ColorSchemes.Dark
        Me.StopButton.Enabled = False
        Me.StopButton.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.StopButton.ForeColor = System.Drawing.Color.White
        Me.StopButton.Location = New System.Drawing.Point(84, 306)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(75, 23)
        Me.StopButton.TabIndex = 15
        Me.StopButton.Text = "Stop"
        Me.StopButton.UseVisualStyleBackColor = False
        '
        'LogsTextBox
        '
        Me.LogsTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LogsTextBox.ColorScheme = NazgulMonitor.ThirteenTextBox.ColorSchemes.Dark
        Me.LogsTextBox.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.LogsTextBox.ForeColor = System.Drawing.Color.White
        Me.LogsTextBox.Location = New System.Drawing.Point(3, 365)
        Me.LogsTextBox.Multiline = True
        Me.LogsTextBox.Name = "LogsTextBox"
        Me.LogsTextBox.ReadOnly = True
        Me.LogsTextBox.Size = New System.Drawing.Size(408, 149)
        Me.LogsTextBox.TabIndex = 16
        '
        'NetworkStatsCheckBox
        '
        Me.NetworkStatsCheckBox.BackColor = System.Drawing.Color.Transparent
        Me.NetworkStatsCheckBox.Checked = True
        Me.NetworkStatsCheckBox.ColorScheme = NazgulMonitor.ThirteenCheckBox.ColorSchemes.Dark
        Me.NetworkStatsCheckBox.ForeColor = System.Drawing.Color.White
        Me.NetworkStatsCheckBox.Location = New System.Drawing.Point(241, 81)
        Me.NetworkStatsCheckBox.Name = "NetworkStatsCheckBox"
        Me.NetworkStatsCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.NetworkStatsCheckBox.Size = New System.Drawing.Size(107, 17)
        Me.NetworkStatsCheckBox.TabIndex = 17
        Me.NetworkStatsCheckBox.Text = "Network Stats"
        '
        'WebserverCheckBox
        '
        Me.WebserverCheckBox.BackColor = System.Drawing.Color.Transparent
        Me.WebserverCheckBox.Checked = True
        Me.WebserverCheckBox.ColorScheme = NazgulMonitor.ThirteenCheckBox.ColorSchemes.Dark
        Me.WebserverCheckBox.ForeColor = System.Drawing.Color.White
        Me.WebserverCheckBox.Location = New System.Drawing.Point(241, 104)
        Me.WebserverCheckBox.Name = "WebserverCheckBox"
        Me.WebserverCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WebserverCheckBox.Size = New System.Drawing.Size(167, 17)
        Me.WebserverCheckBox.TabIndex = 18
        Me.WebserverCheckBox.Text = "Send Logs to Webserver"
        '
        'IntIPLabel
        '
        Me.IntIPLabel.AutoSize = True
        Me.IntIPLabel.Location = New System.Drawing.Point(3, 52)
        Me.IntIPLabel.Name = "IntIPLabel"
        Me.IntIPLabel.Size = New System.Drawing.Size(64, 17)
        Me.IntIPLabel.TabIndex = 19
        Me.IntIPLabel.Text = "Internal IP"
        '
        'SendLogsTrackbar
        '
        Me.SendLogsTrackbar.Location = New System.Drawing.Point(165, 274)
        Me.SendLogsTrackbar.Maximum = 100
        Me.SendLogsTrackbar.Minimum = 25
        Me.SendLogsTrackbar.Name = "SendLogsTrackbar"
        Me.SendLogsTrackbar.Size = New System.Drawing.Size(246, 45)
        Me.SendLogsTrackbar.SmallChange = 10
        Me.SendLogsTrackbar.TabIndex = 20
        Me.SendLogsTrackbar.TickFrequency = 5
        Me.SendLogsTrackbar.Value = 80
        '
        'LocalCSVCheckBox
        '
        Me.LocalCSVCheckBox.BackColor = System.Drawing.Color.Transparent
        Me.LocalCSVCheckBox.Checked = True
        Me.LocalCSVCheckBox.ColorScheme = NazgulMonitor.ThirteenCheckBox.ColorSchemes.Dark
        Me.LocalCSVCheckBox.ForeColor = System.Drawing.Color.White
        Me.LocalCSVCheckBox.Location = New System.Drawing.Point(241, 127)
        Me.LocalCSVCheckBox.Name = "LocalCSVCheckBox"
        Me.LocalCSVCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LocalCSVCheckBox.Size = New System.Drawing.Size(130, 17)
        Me.LocalCSVCheckBox.TabIndex = 21
        Me.LocalCSVCheckBox.Text = "Save Logs to .CSV"
        '
        'WebserverTextBox
        '
        Me.WebserverTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.WebserverTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.WebserverTextBox.ColorScheme = NazgulMonitor.ThirteenTextBox.ColorSchemes.Dark
        Me.WebserverTextBox.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.WebserverTextBox.ForeColor = System.Drawing.Color.White
        Me.WebserverTextBox.Location = New System.Drawing.Point(241, 173)
        Me.WebserverTextBox.Name = "WebserverTextBox"
        Me.WebserverTextBox.Size = New System.Drawing.Size(170, 25)
        Me.WebserverTextBox.TabIndex = 22
        '
        'SendLogsLabel
        '
        Me.SendLogsLabel.AutoSize = True
        Me.SendLogsLabel.Location = New System.Drawing.Point(3, 226)
        Me.SendLogsLabel.Name = "SendLogsLabel"
        Me.SendLogsLabel.Size = New System.Drawing.Size(99, 17)
        Me.SendLogsLabel.TabIndex = 23
        Me.SendLogsLabel.Text = "Send logs when:"
        '
        'SendLogsCPUTempLabel
        '
        Me.SendLogsCPUTempLabel.AutoSize = True
        Me.SendLogsCPUTempLabel.Location = New System.Drawing.Point(108, 226)
        Me.SendLogsCPUTempLabel.Name = "SendLogsCPUTempLabel"
        Me.SendLogsCPUTempLabel.Size = New System.Drawing.Size(107, 17)
        Me.SendLogsCPUTempLabel.TabIndex = 24
        Me.SendLogsCPUTempLabel.Text = "CPU Temperature"
        '
        'SendLogsCPUUsageLabel
        '
        Me.SendLogsCPUUsageLabel.AutoSize = True
        Me.SendLogsCPUUsageLabel.Location = New System.Drawing.Point(108, 243)
        Me.SendLogsCPUUsageLabel.Name = "SendLogsCPUUsageLabel"
        Me.SendLogsCPUUsageLabel.Size = New System.Drawing.Size(71, 17)
        Me.SendLogsCPUUsageLabel.TabIndex = 25
        Me.SendLogsCPUUsageLabel.Text = "CPU Usage"
        '
        'SendLogsRAMUsageLabel
        '
        Me.SendLogsRAMUsageLabel.AutoSize = True
        Me.SendLogsRAMUsageLabel.Location = New System.Drawing.Point(265, 226)
        Me.SendLogsRAMUsageLabel.Name = "SendLogsRAMUsageLabel"
        Me.SendLogsRAMUsageLabel.Size = New System.Drawing.Size(73, 17)
        Me.SendLogsRAMUsageLabel.TabIndex = 26
        Me.SendLogsRAMUsageLabel.Text = "RAM Usage"
        '
        'GPUTempLabel
        '
        Me.GPUTempLabel.AutoSize = True
        Me.GPUTempLabel.Location = New System.Drawing.Point(3, 103)
        Me.GPUTempLabel.Name = "GPUTempLabel"
        Me.GPUTempLabel.Size = New System.Drawing.Size(36, 17)
        Me.GPUTempLabel.TabIndex = 27
        Me.GPUTempLabel.Text = "GPU:"
        '
        'SendLogsGPUTempLabel
        '
        Me.SendLogsGPUTempLabel.AutoSize = True
        Me.SendLogsGPUTempLabel.Location = New System.Drawing.Point(265, 243)
        Me.SendLogsGPUTempLabel.Name = "SendLogsGPUTempLabel"
        Me.SendLogsGPUTempLabel.Size = New System.Drawing.Size(108, 17)
        Me.SendLogsGPUTempLabel.TabIndex = 28
        Me.SendLogsGPUTempLabel.Text = "GPU Temperature"
        '
        'GPUTempCheckBox
        '
        Me.GPUTempCheckBox.BackColor = System.Drawing.Color.Transparent
        Me.GPUTempCheckBox.Checked = True
        Me.GPUTempCheckBox.ColorScheme = NazgulMonitor.ThirteenCheckBox.ColorSchemes.Dark
        Me.GPUTempCheckBox.ForeColor = System.Drawing.Color.White
        Me.GPUTempCheckBox.Location = New System.Drawing.Point(241, 58)
        Me.GPUTempCheckBox.Name = "GPUTempCheckBox"
        Me.GPUTempCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GPUTempCheckBox.Size = New System.Drawing.Size(130, 17)
        Me.GPUTempCheckBox.TabIndex = 29
        Me.GPUTempCheckBox.Text = "GPU Temperature"
        '
        'ClearLogsButton
        '
        Me.ClearLogsButton.AccentColor = System.Drawing.Color.DodgerBlue
        Me.ClearLogsButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClearLogsButton.ColorScheme = NazgulMonitor.ThirteenButton.ColorSchemes.Dark
        Me.ClearLogsButton.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.ClearLogsButton.ForeColor = System.Drawing.Color.White
        Me.ClearLogsButton.Location = New System.Drawing.Point(3, 335)
        Me.ClearLogsButton.Name = "ClearLogsButton"
        Me.ClearLogsButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearLogsButton.TabIndex = 30
        Me.ClearLogsButton.Text = "Clear Logs"
        Me.ClearLogsButton.UseVisualStyleBackColor = False
        '
        'TopMostCheckBox
        '
        Me.TopMostCheckBox.BackColor = System.Drawing.Color.Transparent
        Me.TopMostCheckBox.Checked = False
        Me.TopMostCheckBox.ColorScheme = NazgulMonitor.ThirteenCheckBox.ColorSchemes.Dark
        Me.TopMostCheckBox.ForeColor = System.Drawing.Color.White
        Me.TopMostCheckBox.Location = New System.Drawing.Point(278, 520)
        Me.TopMostCheckBox.Name = "TopMostCheckBox"
        Me.TopMostCheckBox.Size = New System.Drawing.Size(133, 17)
        Me.TopMostCheckBox.TabIndex = 31
        Me.TopMostCheckBox.Text = "Keep me TopMost"
        '
        'ResetButton
        '
        Me.ResetButton.AccentColor = System.Drawing.Color.DodgerBlue
        Me.ResetButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ResetButton.ColorScheme = NazgulMonitor.ThirteenButton.ColorSchemes.Dark
        Me.ResetButton.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.ResetButton.ForeColor = System.Drawing.Color.White
        Me.ResetButton.Location = New System.Drawing.Point(84, 335)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(75, 23)
        Me.ResetButton.TabIndex = 32
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = False
        '
        'AutoRestartCheckBox
        '
        Me.AutoRestartCheckBox.BackColor = System.Drawing.Color.Transparent
        Me.AutoRestartCheckBox.Checked = False
        Me.AutoRestartCheckBox.ColorScheme = NazgulMonitor.ThirteenCheckBox.ColorSchemes.Dark
        Me.AutoRestartCheckBox.ForeColor = System.Drawing.Color.White
        Me.AutoRestartCheckBox.Location = New System.Drawing.Point(165, 309)
        Me.AutoRestartCheckBox.Name = "AutoRestartCheckBox"
        Me.AutoRestartCheckBox.Size = New System.Drawing.Size(101, 17)
        Me.AutoRestartCheckBox.TabIndex = 33
        Me.AutoRestartCheckBox.Text = "AutoRestart?"
        '
        'AutoRestartMinutesUpDownNumeric
        '
        Me.AutoRestartMinutesUpDownNumeric.Location = New System.Drawing.Point(265, 304)
        Me.AutoRestartMinutesUpDownNumeric.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.AutoRestartMinutesUpDownNumeric.Name = "AutoRestartMinutesUpDownNumeric"
        Me.AutoRestartMinutesUpDownNumeric.Size = New System.Drawing.Size(56, 25)
        Me.AutoRestartMinutesUpDownNumeric.TabIndex = 34
        Me.AutoRestartMinutesUpDownNumeric.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'afterMinutesLabel
        '
        Me.afterMinutesLabel.AutoSize = True
        Me.afterMinutesLabel.BackColor = System.Drawing.Color.Transparent
        Me.afterMinutesLabel.Location = New System.Drawing.Point(327, 312)
        Me.afterMinutesLabel.Name = "afterMinutesLabel"
        Me.afterMinutesLabel.Size = New System.Drawing.Size(82, 17)
        Me.afterMinutesLabel.TabIndex = 35
        Me.afterMinutesLabel.Text = "after minutes"
        '
        'TelegramAlertCheckBox
        '
        Me.TelegramAlertCheckBox.BackColor = System.Drawing.Color.Transparent
        Me.TelegramAlertCheckBox.Checked = True
        Me.TelegramAlertCheckBox.ColorScheme = NazgulMonitor.ThirteenCheckBox.ColorSchemes.Dark
        Me.TelegramAlertCheckBox.ForeColor = System.Drawing.Color.White
        Me.TelegramAlertCheckBox.Location = New System.Drawing.Point(241, 150)
        Me.TelegramAlertCheckBox.Name = "TelegramAlertCheckBox"
        Me.TelegramAlertCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TelegramAlertCheckBox.Size = New System.Drawing.Size(150, 17)
        Me.TelegramAlertCheckBox.TabIndex = 36
        Me.TelegramAlertCheckBox.Text = "Send Telegram Alerts"
        '
        'RefreshEveryUpDownNumeric
        '
        Me.RefreshEveryUpDownNumeric.Location = New System.Drawing.Point(265, 334)
        Me.RefreshEveryUpDownNumeric.Maximum = New Decimal(New Integer() {3600, 0, 0, 0})
        Me.RefreshEveryUpDownNumeric.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.RefreshEveryUpDownNumeric.Name = "RefreshEveryUpDownNumeric"
        Me.RefreshEveryUpDownNumeric.Size = New System.Drawing.Size(56, 25)
        Me.RefreshEveryUpDownNumeric.TabIndex = 37
        Me.RefreshEveryUpDownNumeric.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'secondsLabel
        '
        Me.secondsLabel.AutoSize = True
        Me.secondsLabel.BackColor = System.Drawing.Color.Transparent
        Me.secondsLabel.Location = New System.Drawing.Point(327, 342)
        Me.secondsLabel.Name = "secondsLabel"
        Me.secondsLabel.Size = New System.Drawing.Size(52, 17)
        Me.secondsLabel.TabIndex = 38
        Me.secondsLabel.Text = "seconds"
        '
        'refreshLabel
        '
        Me.refreshLabel.AutoSize = True
        Me.refreshLabel.BackColor = System.Drawing.Color.Transparent
        Me.refreshLabel.Location = New System.Drawing.Point(175, 342)
        Me.refreshLabel.Name = "refreshLabel"
        Me.refreshLabel.Size = New System.Drawing.Size(84, 17)
        Me.refreshLabel.TabIndex = 39
        Me.refreshLabel.Text = "Refresh every"
        '
        'ThirteenForm1
        '
        Me.ThirteenForm1.AccentColor = System.Drawing.Color.DodgerBlue
        Me.ThirteenForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ThirteenForm1.ColorScheme = NazgulMonitor.ThirteenForm.ColorSchemes.Dark
        Me.ThirteenForm1.Controls.Add(Me.refreshLabel)
        Me.ThirteenForm1.Controls.Add(Me.secondsLabel)
        Me.ThirteenForm1.Controls.Add(Me.RefreshEveryUpDownNumeric)
        Me.ThirteenForm1.Controls.Add(Me.TelegramAlertCheckBox)
        Me.ThirteenForm1.Controls.Add(Me.afterMinutesLabel)
        Me.ThirteenForm1.Controls.Add(Me.AutoRestartMinutesUpDownNumeric)
        Me.ThirteenForm1.Controls.Add(Me.AutoRestartCheckBox)
        Me.ThirteenForm1.Controls.Add(Me.ResetButton)
        Me.ThirteenForm1.Controls.Add(Me.TopMostCheckBox)
        Me.ThirteenForm1.Controls.Add(Me.ClearLogsButton)
        Me.ThirteenForm1.Controls.Add(Me.GPUTempCheckBox)
        Me.ThirteenForm1.Controls.Add(Me.SendLogsGPUTempLabel)
        Me.ThirteenForm1.Controls.Add(Me.GPUTempLabel)
        Me.ThirteenForm1.Controls.Add(Me.SendLogsRAMUsageLabel)
        Me.ThirteenForm1.Controls.Add(Me.SendLogsCPUUsageLabel)
        Me.ThirteenForm1.Controls.Add(Me.SendLogsCPUTempLabel)
        Me.ThirteenForm1.Controls.Add(Me.SendLogsLabel)
        Me.ThirteenForm1.Controls.Add(Me.WebserverTextBox)
        Me.ThirteenForm1.Controls.Add(Me.LocalCSVCheckBox)
        Me.ThirteenForm1.Controls.Add(Me.SendLogsTrackbar)
        Me.ThirteenForm1.Controls.Add(Me.IntIPLabel)
        Me.ThirteenForm1.Controls.Add(Me.WebserverCheckBox)
        Me.ThirteenForm1.Controls.Add(Me.NetworkStatsCheckBox)
        Me.ThirteenForm1.Controls.Add(Me.LogsTextBox)
        Me.ThirteenForm1.Controls.Add(Me.StopButton)
        Me.ThirteenForm1.Controls.Add(Me.StartMonitorButton)
        Me.ThirteenForm1.Controls.Add(Me.SeparatorImage)
        Me.ThirteenForm1.Controls.Add(Me.CPUTempCheckBox)
        Me.ThirteenForm1.Controls.Add(Me.CPUTempLabel)
        Me.ThirteenForm1.Controls.Add(Me.DownloadLabel)
        Me.ThirteenForm1.Controls.Add(Me.UploadLabel)
        Me.ThirteenForm1.Controls.Add(Me.RAMUsageLabel)
        Me.ThirteenForm1.Controls.Add(Me.PingLabel)
        Me.ThirteenForm1.Controls.Add(Me.CPUUsageLabel)
        Me.ThirteenForm1.Controls.Add(Me.WinVersionLabel)
        Me.ThirteenForm1.Controls.Add(Me.TimeLabel)
        Me.ThirteenForm1.Controls.Add(Me.CloseButton)
        Me.ThirteenForm1.Controls.Add(Me.MinimizeButton)
        Me.ThirteenForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ThirteenForm1.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.ThirteenForm1.ForeColor = System.Drawing.Color.White
        Me.ThirteenForm1.Location = New System.Drawing.Point(0, 0)
        Me.ThirteenForm1.Name = "ThirteenForm1"
        Me.ThirteenForm1.Size = New System.Drawing.Size(414, 545)
        Me.ThirteenForm1.TabIndex = 0
        Me.ThirteenForm1.Text = "NazgulMonitor"
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
        CType(Me.SeparatorImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SendLogsTrackbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutoRestartMinutesUpDownNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RefreshEveryUpDownNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ThirteenForm1.ResumeLayout(False)
        Me.ThirteenForm1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents MinimizeButton As ThirteenButton
    Friend WithEvents CloseButton As ThirteenButton
    Friend WithEvents TimeLabel As Label
    Friend WithEvents WinVersionLabel As Label
    Friend WithEvents CPUUsageLabel As Label
    Friend WithEvents PingLabel As Label
    Friend WithEvents RAMUsageLabel As Label
    Friend WithEvents UploadLabel As Label
    Friend WithEvents DownloadLabel As Label
    Friend WithEvents CPUTempLabel As Label
    Friend WithEvents CPUTempCheckBox As ThirteenCheckBox
    Friend WithEvents SeparatorImage As PictureBox
    Friend WithEvents StartMonitorButton As ThirteenButton
    Friend WithEvents StopButton As ThirteenButton
    Friend WithEvents LogsTextBox As ThirteenTextBox
    Friend WithEvents NetworkStatsCheckBox As ThirteenCheckBox
    Friend WithEvents WebserverCheckBox As ThirteenCheckBox
    Friend WithEvents IntIPLabel As Label
    Friend WithEvents SendLogsTrackbar As TrackBar
    Friend WithEvents LocalCSVCheckBox As ThirteenCheckBox
    Friend WithEvents WebserverTextBox As ThirteenTextBox
    Friend WithEvents SendLogsLabel As Label
    Friend WithEvents SendLogsCPUTempLabel As Label
    Friend WithEvents SendLogsCPUUsageLabel As Label
    Friend WithEvents SendLogsRAMUsageLabel As Label
    Friend WithEvents GPUTempLabel As Label
    Friend WithEvents SendLogsGPUTempLabel As Label
    Friend WithEvents GPUTempCheckBox As ThirteenCheckBox
    Friend WithEvents ClearLogsButton As ThirteenButton
    Friend WithEvents TopMostCheckBox As ThirteenCheckBox
    Friend WithEvents ResetButton As ThirteenButton
    Friend WithEvents AutoRestartCheckBox As ThirteenCheckBox
    Friend WithEvents AutoRestartMinutesUpDownNumeric As NumericUpDown
    Friend WithEvents afterMinutesLabel As Label
    Friend WithEvents TelegramAlertCheckBox As ThirteenCheckBox
    Friend WithEvents RefreshEveryUpDownNumeric As NumericUpDown
    Friend WithEvents secondsLabel As Label
    Friend WithEvents refreshLabel As Label
    Friend WithEvents ThirteenForm1 As ThirteenForm
End Class
