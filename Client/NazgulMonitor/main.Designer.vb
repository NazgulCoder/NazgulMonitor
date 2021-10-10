<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.WinVersionLabel = New System.Windows.Forms.Label()
        Me.IntIPLabel = New System.Windows.Forms.Label()
        Me.PingLabel = New System.Windows.Forms.Label()
        Me.CPUTempLabel = New System.Windows.Forms.Label()
        Me.GPUTempLabel = New System.Windows.Forms.Label()
        Me.CPUUsageLabel = New System.Windows.Forms.Label()
        Me.RAMUsageLabel = New System.Windows.Forms.Label()
        Me.UploadLabel = New System.Windows.Forms.Label()
        Me.DownloadLabel = New System.Windows.Forms.Label()
        Me.CPUTempCheckBox = New System.Windows.Forms.CheckBox()
        Me.GPUTempCheckBox = New System.Windows.Forms.CheckBox()
        Me.NetworkStatsCheckBox = New System.Windows.Forms.CheckBox()
        Me.WebserverCheckBox = New System.Windows.Forms.CheckBox()
        Me.LocalCSVCheckBox = New System.Windows.Forms.CheckBox()
        Me.TelegramAlertCheckBox = New System.Windows.Forms.CheckBox()
        Me.WebserverTextBox = New System.Windows.Forms.TextBox()
        Me.SeparatorImage = New System.Windows.Forms.PictureBox()
        Me.SendLogsLabel = New System.Windows.Forms.Label()
        Me.SendLogsTrackbar = New System.Windows.Forms.TrackBar()
        Me.SendLogsCPUTempLabel = New System.Windows.Forms.Label()
        Me.SendLogsCPUUsageLabel = New System.Windows.Forms.Label()
        Me.SendLogsGPUTempLabel = New System.Windows.Forms.Label()
        Me.SendLogsRAMUsageLabel = New System.Windows.Forms.Label()
        Me.StopButton = New System.Windows.Forms.Button()
        Me.StartMonitorButton = New System.Windows.Forms.Button()
        Me.ClearLogsButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.TopMostCheckBox = New System.Windows.Forms.CheckBox()
        Me.LogsTextBox = New System.Windows.Forms.TextBox()
        Me.AutoRestartCheckBox = New System.Windows.Forms.CheckBox()
        Me.RefreshEveryUpDownNumeric = New System.Windows.Forms.NumericUpDown()
        Me.AutoRestartMinutesUpDownNumeric = New System.Windows.Forms.NumericUpDown()
        Me.afterMinutesLabel = New System.Windows.Forms.Label()
        Me.secondsLabel = New System.Windows.Forms.Label()
        Me.refreshLabel = New System.Windows.Forms.Label()
        CType(Me.SeparatorImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SendLogsTrackbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RefreshEveryUpDownNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutoRestartMinutesUpDownNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WinVersionLabel
        '
        Me.WinVersionLabel.AutoSize = True
        Me.WinVersionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WinVersionLabel.Location = New System.Drawing.Point(12, 9)
        Me.WinVersionLabel.Name = "WinVersionLabel"
        Me.WinVersionLabel.Size = New System.Drawing.Size(112, 16)
        Me.WinVersionLabel.TabIndex = 0
        Me.WinVersionLabel.Text = "Windows Version"
        '
        'IntIPLabel
        '
        Me.IntIPLabel.AutoSize = True
        Me.IntIPLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IntIPLabel.Location = New System.Drawing.Point(12, 25)
        Me.IntIPLabel.Name = "IntIPLabel"
        Me.IntIPLabel.Size = New System.Drawing.Size(66, 16)
        Me.IntIPLabel.TabIndex = 1
        Me.IntIPLabel.Text = "Internal IP"
        '
        'PingLabel
        '
        Me.PingLabel.AutoSize = True
        Me.PingLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PingLabel.Location = New System.Drawing.Point(12, 41)
        Me.PingLabel.Name = "PingLabel"
        Me.PingLabel.Size = New System.Drawing.Size(38, 16)
        Me.PingLabel.TabIndex = 2
        Me.PingLabel.Text = "Ping:"
        '
        'CPUTempLabel
        '
        Me.CPUTempLabel.AutoSize = True
        Me.CPUTempLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CPUTempLabel.Location = New System.Drawing.Point(12, 57)
        Me.CPUTempLabel.Name = "CPUTempLabel"
        Me.CPUTempLabel.Size = New System.Drawing.Size(39, 16)
        Me.CPUTempLabel.TabIndex = 3
        Me.CPUTempLabel.Text = "CPU:"
        '
        'GPUTempLabel
        '
        Me.GPUTempLabel.AutoSize = True
        Me.GPUTempLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GPUTempLabel.Location = New System.Drawing.Point(12, 73)
        Me.GPUTempLabel.Name = "GPUTempLabel"
        Me.GPUTempLabel.Size = New System.Drawing.Size(43, 16)
        Me.GPUTempLabel.TabIndex = 4
        Me.GPUTempLabel.Text = "GPU: "
        '
        'CPUUsageLabel
        '
        Me.CPUUsageLabel.AutoSize = True
        Me.CPUUsageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CPUUsageLabel.Location = New System.Drawing.Point(12, 89)
        Me.CPUUsageLabel.Name = "CPUUsageLabel"
        Me.CPUUsageLabel.Size = New System.Drawing.Size(39, 16)
        Me.CPUUsageLabel.TabIndex = 5
        Me.CPUUsageLabel.Text = "CPU:"
        '
        'RAMUsageLabel
        '
        Me.RAMUsageLabel.AutoSize = True
        Me.RAMUsageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RAMUsageLabel.Location = New System.Drawing.Point(12, 105)
        Me.RAMUsageLabel.Name = "RAMUsageLabel"
        Me.RAMUsageLabel.Size = New System.Drawing.Size(41, 16)
        Me.RAMUsageLabel.TabIndex = 6
        Me.RAMUsageLabel.Text = "RAM:"
        '
        'UploadLabel
        '
        Me.UploadLabel.AutoSize = True
        Me.UploadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UploadLabel.Location = New System.Drawing.Point(12, 121)
        Me.UploadLabel.Name = "UploadLabel"
        Me.UploadLabel.Size = New System.Drawing.Size(56, 16)
        Me.UploadLabel.TabIndex = 7
        Me.UploadLabel.Text = "Upload:"
        '
        'DownloadLabel
        '
        Me.DownloadLabel.AutoSize = True
        Me.DownloadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DownloadLabel.Location = New System.Drawing.Point(12, 137)
        Me.DownloadLabel.Name = "DownloadLabel"
        Me.DownloadLabel.Size = New System.Drawing.Size(72, 16)
        Me.DownloadLabel.TabIndex = 8
        Me.DownloadLabel.Text = "Download:"
        '
        'CPUTempCheckBox
        '
        Me.CPUTempCheckBox.AutoSize = True
        Me.CPUTempCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CPUTempCheckBox.Location = New System.Drawing.Point(243, 8)
        Me.CPUTempCheckBox.Name = "CPUTempCheckBox"
        Me.CPUTempCheckBox.Size = New System.Drawing.Size(136, 20)
        Me.CPUTempCheckBox.TabIndex = 9
        Me.CPUTempCheckBox.Text = "CPU Temperature"
        Me.CPUTempCheckBox.UseVisualStyleBackColor = True
        '
        'GPUTempCheckBox
        '
        Me.GPUTempCheckBox.AutoSize = True
        Me.GPUTempCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GPUTempCheckBox.Location = New System.Drawing.Point(243, 25)
        Me.GPUTempCheckBox.Name = "GPUTempCheckBox"
        Me.GPUTempCheckBox.Size = New System.Drawing.Size(137, 20)
        Me.GPUTempCheckBox.TabIndex = 10
        Me.GPUTempCheckBox.Text = "GPU Temperature"
        Me.GPUTempCheckBox.UseVisualStyleBackColor = True
        '
        'NetworkStatsCheckBox
        '
        Me.NetworkStatsCheckBox.AutoSize = True
        Me.NetworkStatsCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NetworkStatsCheckBox.Location = New System.Drawing.Point(243, 42)
        Me.NetworkStatsCheckBox.Name = "NetworkStatsCheckBox"
        Me.NetworkStatsCheckBox.Size = New System.Drawing.Size(132, 20)
        Me.NetworkStatsCheckBox.TabIndex = 11
        Me.NetworkStatsCheckBox.Text = "Network Statistics"
        Me.NetworkStatsCheckBox.UseVisualStyleBackColor = True
        '
        'WebserverCheckBox
        '
        Me.WebserverCheckBox.AutoSize = True
        Me.WebserverCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WebserverCheckBox.Location = New System.Drawing.Point(243, 59)
        Me.WebserverCheckBox.Name = "WebserverCheckBox"
        Me.WebserverCheckBox.Size = New System.Drawing.Size(176, 20)
        Me.WebserverCheckBox.TabIndex = 12
        Me.WebserverCheckBox.Text = "Send Logs to Webserver"
        Me.WebserverCheckBox.UseVisualStyleBackColor = True
        '
        'LocalCSVCheckBox
        '
        Me.LocalCSVCheckBox.AutoSize = True
        Me.LocalCSVCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocalCSVCheckBox.Location = New System.Drawing.Point(243, 76)
        Me.LocalCSVCheckBox.Name = "LocalCSVCheckBox"
        Me.LocalCSVCheckBox.Size = New System.Drawing.Size(139, 20)
        Me.LocalCSVCheckBox.TabIndex = 13
        Me.LocalCSVCheckBox.Text = "Save Logs to .CSV" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.LocalCSVCheckBox.UseVisualStyleBackColor = True
        '
        'TelegramAlertCheckBox
        '
        Me.TelegramAlertCheckBox.AutoSize = True
        Me.TelegramAlertCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelegramAlertCheckBox.Location = New System.Drawing.Point(243, 93)
        Me.TelegramAlertCheckBox.Name = "TelegramAlertCheckBox"
        Me.TelegramAlertCheckBox.Size = New System.Drawing.Size(151, 20)
        Me.TelegramAlertCheckBox.TabIndex = 14
        Me.TelegramAlertCheckBox.Text = "Send Telegram Alert"
        Me.TelegramAlertCheckBox.UseVisualStyleBackColor = True
        '
        'WebserverTextBox
        '
        Me.WebserverTextBox.Location = New System.Drawing.Point(243, 114)
        Me.WebserverTextBox.Name = "WebserverTextBox"
        Me.WebserverTextBox.Size = New System.Drawing.Size(176, 20)
        Me.WebserverTextBox.TabIndex = 15
        '
        'SeparatorImage
        '
        Me.SeparatorImage.BackColor = System.Drawing.Color.Transparent
        Me.SeparatorImage.Image = CType(resources.GetObject("SeparatorImage.Image"), System.Drawing.Image)
        Me.SeparatorImage.Location = New System.Drawing.Point(-72, 156)
        Me.SeparatorImage.Name = "SeparatorImage"
        Me.SeparatorImage.Size = New System.Drawing.Size(570, 15)
        Me.SeparatorImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SeparatorImage.TabIndex = 16
        Me.SeparatorImage.TabStop = False
        '
        'SendLogsLabel
        '
        Me.SendLogsLabel.AutoSize = True
        Me.SendLogsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SendLogsLabel.Location = New System.Drawing.Point(12, 174)
        Me.SendLogsLabel.Name = "SendLogsLabel"
        Me.SendLogsLabel.Size = New System.Drawing.Size(106, 16)
        Me.SendLogsLabel.TabIndex = 17
        Me.SendLogsLabel.Text = "Send logs when:"
        '
        'SendLogsTrackbar
        '
        Me.SendLogsTrackbar.Location = New System.Drawing.Point(12, 209)
        Me.SendLogsTrackbar.Maximum = 100
        Me.SendLogsTrackbar.Minimum = 25
        Me.SendLogsTrackbar.Name = "SendLogsTrackbar"
        Me.SendLogsTrackbar.Size = New System.Drawing.Size(407, 45)
        Me.SendLogsTrackbar.SmallChange = 10
        Me.SendLogsTrackbar.TabIndex = 21
        Me.SendLogsTrackbar.TickFrequency = 3
        Me.SendLogsTrackbar.Value = 80
        '
        'SendLogsCPUTempLabel
        '
        Me.SendLogsCPUTempLabel.AutoSize = True
        Me.SendLogsCPUTempLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SendLogsCPUTempLabel.Location = New System.Drawing.Point(124, 174)
        Me.SendLogsCPUTempLabel.Name = "SendLogsCPUTempLabel"
        Me.SendLogsCPUTempLabel.Size = New System.Drawing.Size(117, 16)
        Me.SendLogsCPUTempLabel.TabIndex = 22
        Me.SendLogsCPUTempLabel.Text = "CPU Temperature"
        '
        'SendLogsCPUUsageLabel
        '
        Me.SendLogsCPUUsageLabel.AutoSize = True
        Me.SendLogsCPUUsageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SendLogsCPUUsageLabel.Location = New System.Drawing.Point(124, 190)
        Me.SendLogsCPUUsageLabel.Name = "SendLogsCPUUsageLabel"
        Me.SendLogsCPUUsageLabel.Size = New System.Drawing.Size(80, 16)
        Me.SendLogsCPUUsageLabel.TabIndex = 23
        Me.SendLogsCPUUsageLabel.Text = "CPU Usage"
        '
        'SendLogsGPUTempLabel
        '
        Me.SendLogsGPUTempLabel.AutoSize = True
        Me.SendLogsGPUTempLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SendLogsGPUTempLabel.Location = New System.Drawing.Point(277, 174)
        Me.SendLogsGPUTempLabel.Name = "SendLogsGPUTempLabel"
        Me.SendLogsGPUTempLabel.Size = New System.Drawing.Size(118, 16)
        Me.SendLogsGPUTempLabel.TabIndex = 24
        Me.SendLogsGPUTempLabel.Text = "GPU Temperature"
        '
        'SendLogsRAMUsageLabel
        '
        Me.SendLogsRAMUsageLabel.AutoSize = True
        Me.SendLogsRAMUsageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SendLogsRAMUsageLabel.Location = New System.Drawing.Point(277, 190)
        Me.SendLogsRAMUsageLabel.Name = "SendLogsRAMUsageLabel"
        Me.SendLogsRAMUsageLabel.Size = New System.Drawing.Size(82, 16)
        Me.SendLogsRAMUsageLabel.TabIndex = 25
        Me.SendLogsRAMUsageLabel.Text = "RAM Usage"
        '
        'StopButton
        '
        Me.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StopButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopButton.Location = New System.Drawing.Point(105, 246)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(84, 28)
        Me.StopButton.TabIndex = 27
        Me.StopButton.Text = "Stop"
        Me.StopButton.UseVisualStyleBackColor = True
        '
        'StartMonitorButton
        '
        Me.StartMonitorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StartMonitorButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartMonitorButton.Location = New System.Drawing.Point(15, 246)
        Me.StartMonitorButton.Name = "StartMonitorButton"
        Me.StartMonitorButton.Size = New System.Drawing.Size(84, 28)
        Me.StartMonitorButton.TabIndex = 28
        Me.StartMonitorButton.Text = "Start"
        Me.StartMonitorButton.UseVisualStyleBackColor = True
        '
        'ClearLogsButton
        '
        Me.ClearLogsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearLogsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearLogsButton.Location = New System.Drawing.Point(15, 280)
        Me.ClearLogsButton.Name = "ClearLogsButton"
        Me.ClearLogsButton.Size = New System.Drawing.Size(84, 28)
        Me.ClearLogsButton.TabIndex = 29
        Me.ClearLogsButton.Text = "Clear Logs"
        Me.ClearLogsButton.UseVisualStyleBackColor = True
        '
        'ResetButton
        '
        Me.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResetButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetButton.Location = New System.Drawing.Point(105, 280)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(84, 28)
        Me.ResetButton.TabIndex = 30
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLabel.Location = New System.Drawing.Point(12, 485)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(39, 16)
        Me.TimeLabel.TabIndex = 31
        Me.TimeLabel.Text = "Time"
        '
        'TopMostCheckBox
        '
        Me.TopMostCheckBox.AutoSize = True
        Me.TopMostCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TopMostCheckBox.Location = New System.Drawing.Point(281, 484)
        Me.TopMostCheckBox.Name = "TopMostCheckBox"
        Me.TopMostCheckBox.Size = New System.Drawing.Size(138, 20)
        Me.TopMostCheckBox.TabIndex = 32
        Me.TopMostCheckBox.Text = "Keep me TopMost"
        Me.TopMostCheckBox.UseVisualStyleBackColor = True
        '
        'LogsTextBox
        '
        Me.LogsTextBox.Location = New System.Drawing.Point(15, 314)
        Me.LogsTextBox.Multiline = True
        Me.LogsTextBox.Name = "LogsTextBox"
        Me.LogsTextBox.ReadOnly = True
        Me.LogsTextBox.Size = New System.Drawing.Size(404, 168)
        Me.LogsTextBox.TabIndex = 33
        '
        'AutoRestartCheckBox
        '
        Me.AutoRestartCheckBox.AutoSize = True
        Me.AutoRestartCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutoRestartCheckBox.Location = New System.Drawing.Point(195, 256)
        Me.AutoRestartCheckBox.Name = "AutoRestartCheckBox"
        Me.AutoRestartCheckBox.Size = New System.Drawing.Size(77, 20)
        Me.AutoRestartCheckBox.TabIndex = 34
        Me.AutoRestartCheckBox.Text = "Restart?"
        Me.AutoRestartCheckBox.UseVisualStyleBackColor = True
        '
        'RefreshEveryUpDownNumeric
        '
        Me.RefreshEveryUpDownNumeric.Location = New System.Drawing.Point(293, 286)
        Me.RefreshEveryUpDownNumeric.Maximum = New Decimal(New Integer() {3600, 0, 0, 0})
        Me.RefreshEveryUpDownNumeric.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.RefreshEveryUpDownNumeric.Name = "RefreshEveryUpDownNumeric"
        Me.RefreshEveryUpDownNumeric.Size = New System.Drawing.Size(47, 20)
        Me.RefreshEveryUpDownNumeric.TabIndex = 39
        Me.RefreshEveryUpDownNumeric.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'AutoRestartMinutesUpDownNumeric
        '
        Me.AutoRestartMinutesUpDownNumeric.Location = New System.Drawing.Point(281, 256)
        Me.AutoRestartMinutesUpDownNumeric.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.AutoRestartMinutesUpDownNumeric.Name = "AutoRestartMinutesUpDownNumeric"
        Me.AutoRestartMinutesUpDownNumeric.Size = New System.Drawing.Size(47, 20)
        Me.AutoRestartMinutesUpDownNumeric.TabIndex = 38
        Me.AutoRestartMinutesUpDownNumeric.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'afterMinutesLabel
        '
        Me.afterMinutesLabel.AutoSize = True
        Me.afterMinutesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.afterMinutesLabel.Location = New System.Drawing.Point(334, 257)
        Me.afterMinutesLabel.Name = "afterMinutesLabel"
        Me.afterMinutesLabel.Size = New System.Drawing.Size(83, 16)
        Me.afterMinutesLabel.TabIndex = 40
        Me.afterMinutesLabel.Text = "after minutes"
        '
        'secondsLabel
        '
        Me.secondsLabel.AutoSize = True
        Me.secondsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.secondsLabel.Location = New System.Drawing.Point(346, 286)
        Me.secondsLabel.Name = "secondsLabel"
        Me.secondsLabel.Size = New System.Drawing.Size(60, 16)
        Me.secondsLabel.TabIndex = 42
        Me.secondsLabel.Text = "seconds"
        '
        'refreshLabel
        '
        Me.refreshLabel.AutoSize = True
        Me.refreshLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refreshLabel.Location = New System.Drawing.Point(195, 286)
        Me.refreshLabel.Name = "refreshLabel"
        Me.refreshLabel.Size = New System.Drawing.Size(92, 16)
        Me.refreshLabel.TabIndex = 43
        Me.refreshLabel.Text = "Refresh every"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 510)
        Me.Controls.Add(Me.refreshLabel)
        Me.Controls.Add(Me.secondsLabel)
        Me.Controls.Add(Me.afterMinutesLabel)
        Me.Controls.Add(Me.RefreshEveryUpDownNumeric)
        Me.Controls.Add(Me.AutoRestartMinutesUpDownNumeric)
        Me.Controls.Add(Me.AutoRestartCheckBox)
        Me.Controls.Add(Me.LogsTextBox)
        Me.Controls.Add(Me.TopMostCheckBox)
        Me.Controls.Add(Me.TimeLabel)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.ClearLogsButton)
        Me.Controls.Add(Me.StartMonitorButton)
        Me.Controls.Add(Me.StopButton)
        Me.Controls.Add(Me.SendLogsRAMUsageLabel)
        Me.Controls.Add(Me.SendLogsGPUTempLabel)
        Me.Controls.Add(Me.SendLogsCPUUsageLabel)
        Me.Controls.Add(Me.SendLogsCPUTempLabel)
        Me.Controls.Add(Me.SendLogsTrackbar)
        Me.Controls.Add(Me.SendLogsLabel)
        Me.Controls.Add(Me.SeparatorImage)
        Me.Controls.Add(Me.WebserverTextBox)
        Me.Controls.Add(Me.TelegramAlertCheckBox)
        Me.Controls.Add(Me.LocalCSVCheckBox)
        Me.Controls.Add(Me.WebserverCheckBox)
        Me.Controls.Add(Me.NetworkStatsCheckBox)
        Me.Controls.Add(Me.GPUTempCheckBox)
        Me.Controls.Add(Me.CPUTempCheckBox)
        Me.Controls.Add(Me.DownloadLabel)
        Me.Controls.Add(Me.UploadLabel)
        Me.Controls.Add(Me.RAMUsageLabel)
        Me.Controls.Add(Me.CPUUsageLabel)
        Me.Controls.Add(Me.GPUTempLabel)
        Me.Controls.Add(Me.CPUTempLabel)
        Me.Controls.Add(Me.PingLabel)
        Me.Controls.Add(Me.IntIPLabel)
        Me.Controls.Add(Me.WinVersionLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "main"
        Me.Text = "NazgulMonitor"
        CType(Me.SeparatorImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SendLogsTrackbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RefreshEveryUpDownNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutoRestartMinutesUpDownNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WinVersionLabel As Label
    Friend WithEvents IntIPLabel As Label
    Friend WithEvents PingLabel As Label
    Friend WithEvents CPUTempLabel As Label
    Friend WithEvents GPUTempLabel As Label
    Friend WithEvents CPUUsageLabel As Label
    Friend WithEvents RAMUsageLabel As Label
    Friend WithEvents UploadLabel As Label
    Friend WithEvents DownloadLabel As Label
    Friend WithEvents CPUTempCheckBox As CheckBox
    Friend WithEvents GPUTempCheckBox As CheckBox
    Friend WithEvents NetworkStatsCheckBox As CheckBox
    Friend WithEvents WebserverCheckBox As CheckBox
    Friend WithEvents LocalCSVCheckBox As CheckBox
    Friend WithEvents TelegramAlertCheckBox As CheckBox
    Friend WithEvents WebserverTextBox As TextBox
    Friend WithEvents SeparatorImage As PictureBox
    Friend WithEvents SendLogsLabel As Label
    Friend WithEvents SendLogsTrackbar As TrackBar
    Friend WithEvents SendLogsCPUTempLabel As Label
    Friend WithEvents SendLogsCPUUsageLabel As Label
    Friend WithEvents SendLogsGPUTempLabel As Label
    Friend WithEvents SendLogsRAMUsageLabel As Label
    Friend WithEvents StopButton As Button
    Friend WithEvents StartMonitorButton As Button
    Friend WithEvents ClearLogsButton As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents TimeLabel As Label
    Friend WithEvents TopMostCheckBox As CheckBox
    Friend WithEvents LogsTextBox As TextBox
    Friend WithEvents AutoRestartCheckBox As CheckBox
    Friend WithEvents RefreshEveryUpDownNumeric As NumericUpDown
    Friend WithEvents AutoRestartMinutesUpDownNumeric As NumericUpDown
    Friend WithEvents afterMinutesLabel As Label
    Friend WithEvents secondsLabel As Label
    Friend WithEvents refreshLabel As Label
End Class
