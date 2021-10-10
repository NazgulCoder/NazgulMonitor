Imports System.Threading.Tasks
Imports System.Threading
Imports System.IO
Imports System.Net.Http
Imports System.Timers
Imports Timer = System.Timers.Timer
Imports System.Net
Public Class main
    Dim lockLogs As New Object
    Dim lockWarnings As New Object
    Dim iAutoRun As Integer = 0
    Dim sendTelegramWarnings As Boolean = True
    Dim oneTimer As Timer = New Timer()
    Dim twoTimer As Timer = New Timer()
    Dim threeTimer As Timer = New Timer()
    Public Class GlobalVariables
        Public Shared PingResult As String = "Ping: "
        Public Shared CPUusage As String = "CPU: "
        Public Shared download As String = "Download: "
        Public Shared upload As String = "Upload: "
        Public Shared CPUTemp As String = "CPU: "
        Public Shared GPUTemp As String = "GPU: "
    End Class
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False       'removes all issues with cross thread operations

        buildTimers()

        loadConfig()                                                                'loads configs from config.ini
        checkIfAutorun()

        WinVersionLabel.Text = getWindowsVersion()
        IntIPLabel.Text = "Int IP: " & getInternalIP()
    End Sub
    Private Sub main_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim dlgR As DialogResult

        dlgR = MessageBox.Show("Are you sure you want to close NazgulMonitor?",
            "Attention!", MessageBoxButtons.YesNo)

        If dlgR = DialogResult.Yes Then
            Process.GetCurrentProcess.Kill()
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub buildTimers()
        ServicePointManager.ServerCertificateValidationCallback = AddressOf AcceptAllCertifications

        oneTimer.Interval = 1000
        AddHandler oneTimer.Elapsed, AddressOf oneTimerEvent
        oneTimer.AutoReset = True
        oneTimer.Enabled = True

        twoTimer.Interval = 1000
        AddHandler twoTimer.Elapsed, AddressOf twoTimerEvent
        twoTimer.AutoReset = True

        threeTimer.Interval = 60000
        AddHandler threeTimer.Elapsed, AddressOf threeTimerEvent
        threeTimer.AutoReset = True
        threeTimer.Enabled = True
    End Sub
    Private Sub oneTimerEvent(ByVal source As Object, ByVal e As ElapsedEventArgs)
        'Label1.Text = DateTime.Now.ToString("dd MMM yyyy HH:mm:ss")
        bypassCrossThread(TimeLabel, DateTime.Now.ToString("dd MMM yyyy HH:mm:ss"))

        If AutoRestartCheckBox.Checked = True Then
            SetAutoRun()
        End If
    End Sub
    Private Async Sub twoTimerEvent(ByVal source As Object, ByVal e As ElapsedEventArgs)
        Try
            getCPU()
            bypassCrossThread(CPUUsageLabel, GlobalVariables.CPUusage)
        Catch
            getLog("Failed to get CPU usage")
        End Try

        If NetworkStatsCheckBox.Checked = True Then
            getPing()
            bypassCrossThread(PingLabel, GlobalVariables.PingResult)
        Else
            bypassCrossThread(PingLabel, "Ping: Disabled")
        End If

        Try
            bypassCrossThread(RAMUsageLabel, getRAM)
        Catch
            getLog("Failed to get RAM usage")
        End Try

        If NetworkStatsCheckBox.Checked = True Then
            Try
                getNetwork()
                bypassCrossThread(UploadLabel, GlobalVariables.upload)
                bypassCrossThread(DownloadLabel, GlobalVariables.download)
            Catch
                getLog("Failed to get Network usage")
            End Try
        Else
            bypassCrossThread(UploadLabel, "Upload: Disabled")
            bypassCrossThread(DownloadLabel, "Download: Disabled")
        End If

        If CPUTempCheckBox.Checked = True Then
            Try
                getCPUTemp()
                bypassCrossThread(CPUTempLabel, GlobalVariables.CPUTemp)
            Catch ex As Exception
                getLog("Failed to get CPU Temperature")
                getLog(ex.ToString)
            End Try
        Else
            bypassCrossThread(CPUTempLabel, "CPU: Disabled")
        End If

        If GPUTempCheckBox.Checked = True Then
            Try
                getGPUTemp()
                bypassCrossThread(GPUTempLabel, GlobalVariables.GPUTemp)
            Catch ex As Exception
                getLog("Failed to get GPU Temperature")
                getLog(ex.ToString)
            End Try
        Else
            bypassCrossThread(GPUTempLabel, "GPU: Disabled")
        End If

        Try
            Await sendLogs()
        Catch ex As Exception
            getLog("Can't send logs to webserver")
            getLog(ex.ToString)
        End Try
        WarningLogs() 'temperatures and usages without internet and without csv
        saveLocal()
    End Sub
    Private Async Sub threeTimerEvent(ByVal source As Object, ByVal e As ElapsedEventArgs)
        Try
            ReleaseMemory() 'every 60sec it tries to free some ram
        Catch
            getLog("Error while releasing memory")
        End Try

        'sets again the boolean true for the telegram warnings (once every 60 sec)
        If sendTelegramWarnings = False Then
            sendTelegramWarnings = True
        End If


        'sends every 60 sec the info to the charts csv
        If twoTimer.Enabled = True And WebserverCheckBox.Checked = True Then
            Try
                Using client As HttpClient = New HttpClient
                    Dim uri As New Uri(WebserverTextBox.Text & "api-charts.php?Info=" & (DateTime.Now.ToString("yyyy/MM/dd HH:mm")) & "," & Num(CPUTempLabel.Text) &
                                       "," & Num(GPUTempLabel.Text) & "," & Num(CPUUsageLabel.Text) & "," & Num(RAMUsageLabel.Text) & "," & Num(PingLabel.Text))
                    Using response As HttpResponseMessage = Await client.GetAsync(uri)
                        Using content As HttpContent = response.Content
                            Dim result As String = Await content.ReadAsStringAsync()
                            If result IsNot Nothing Then
                                'Console.WriteLine(result.ToString())
                            End If
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                bypassCrossThread(LogsTextBox, CStr(Invoke(New Func(Of String)(Function() Me.TimeLabel.Text))) &
                                  " - Could not communicate with the webserver for api-charts" & Environment.NewLine &
                                  CStr(Invoke(New Func(Of String)(Function() Me.LogsTextBox.Text))))

                bypassCrossThread(LogsTextBox, CStr(Invoke(New Func(Of String)(Function() Me.TimeLabel.Text))) &
                                  " - " & ex.ToString & Environment.NewLine &
                                  CStr(Invoke(New Func(Of String)(Function() Me.LogsTextBox.Text))))

                'LogsTextBox.Text = TimeLabel.Text & " - Could not communicate with the webserver for api-charts" & Environment.NewLine & LogsTextBox.Text
                'LogsTextBox.Text = TimeLabel.Text & " - " & ex.ToString & Environment.NewLine & LogsTextBox.Text
            End Try
        End If
    End Sub
    Private Sub checkIfAutorun()
        Try
            If Environment.GetCommandLineArgs(1).ToString = "--NazgulMonitorAutorun" Then
                StartButton()

            ElseIf Environment.GetCommandLineArgs(1).ToString = "--NazgulMonitorAutorunMinimized" Then
                Me.WindowState = FormWindowState.Minimized
                StartButton()
            Else
                getLog("Something went wrong while autorun")
            End If
        Catch
            Console.Write("catch for autorun")
        End Try
    End Sub
    Private Sub SetAutoRun()
        If iAutoRun <= (CInt(Invoke(New Func(Of Integer)(Function() Me.AutoRestartMinutesUpDownNumeric.Value))) * 60) Then
            iAutoRun += 1
        Else
            Dim P As Process = New Process
            With P
                .EnableRaisingEvents = True
                .StartInfo.FileName = "NazgulMonitor.exe"

                If TopMostCheckBox.Checked = False Then
                    .StartInfo.Arguments = "--NazgulMonitorAutorunMinimized"
                Else
                    .StartInfo.Arguments = "--NazgulMonitorAutorun"
                End If

            End With
            oneTimer.Enabled = False
            twoTimer.Enabled = False
            threeTimer.Enabled = False
            P.Start()
            Thread.Sleep(2000)
            Process.GetCurrentProcess.Kill()
        End If

    End Sub
    Private Sub saveLocal()
        'part of code to save into CSV file
        If My.Computer.FileSystem.FileExists("logs.csv") = False Then
            Dim fs As FileStream = File.Create("logs.csv")
            fs.Close()
        End If
        If My.Computer.FileSystem.FileExists("warnings.csv") = False Then
            Dim fs As FileStream = File.Create("warnings.csv")
            fs.Close()
        End If


        SyncLock lockLogs
            If LocalCSVCheckBox.Checked = True Then
                Try
                    Using writer As New StreamWriter("logs.csv", True) 'true because i wanna append
                        writer.WriteLine(DateTime.Now.ToString("dd MMM yyyy - HH:mm:ss") & ";" & WinVersionLabel.Text & ";" & IntIPLabel.Text & ";" & PingLabel.Text & ";" & CPUTempLabel.Text & ";" & GPUTempLabel.Text & ";" &
                        CPUUsageLabel.Text & ";" & RAMUsageLabel.Text & ";" & UploadLabel.Text & ";" & DownloadLabel.Text)
                    End Using
                Catch ex As Exception
                    bypassCrossThread(LogsTextBox, CStr(Invoke(New Func(Of String)(Function() Me.TimeLabel.Text))) &
                                  " - Could not write to logs.csv" & ex.ToString & Environment.NewLine &
                                  CStr(Invoke(New Func(Of String)(Function() Me.LogsTextBox.Text))))

                    bypassCrossThread(LogsTextBox, CStr(Invoke(New Func(Of String)(Function() Me.TimeLabel.Text))) &
                                  " - " & ex.ToString & Environment.NewLine &
                                  CStr(Invoke(New Func(Of String)(Function() Me.LogsTextBox.Text))))

                    'LogsTextBox.Text = TimeLabel.Text & " - Could not write to logs.csv" & Environment.NewLine & LogsTextBox.Text
                    'LogsTextBox.Text = TimeLabel.Text & ex.ToString & Environment.NewLine & LogsTextBox.Text
                End Try
            End If
        End SyncLock

    End Sub
    Private Sub WarningLogs()
        Dim CPUTemp As Integer = Num(CPUTempLabel.Text)
        If (CPUTempCheckBox.Checked = True) And (CPUTemp > CInt(Invoke(New Func(Of Integer)(Function() Me.SendLogsTrackbar.Value)))) Then
            getLog("CPU Temperature " & Num(CPUTempLabel.Text) & " Celsius")
        End If

        Dim CPUUsage As Integer = Num(CPUUsageLabel.Text)
        If (CPUUsage > CInt(Invoke(New Func(Of Integer)(Function() Me.SendLogsTrackbar.Value)))) Then
            getLog("CPU Usage " & CPUUsage & "%")
        End If

        Dim RAMUsage As Integer = Num(RAMUsageLabel.Text)
        If (RAMUsage > CInt(Invoke(New Func(Of Integer)(Function() Me.SendLogsTrackbar.Value)))) Then
            getLog("RAM Usage " & RAMUsage & "%")
        End If

        Dim GPUTemp As Integer = Num(GPUTempLabel.Text)
        If (GPUTemp > CInt(Invoke(New Func(Of Integer)(Function() Me.SendLogsTrackbar.Value)))) Then
            getLog("GPU Temperature " & GPUTemp & " Celsius")
        End If
    End Sub
    Private Async Function sendLogs() As Task
        Using client As HttpClient = New HttpClient
            Dim uri As New Uri(WebserverTextBox.Text & "api.php?Info=" & WinVersionLabel.Text & ";" & IntIPLabel.Text & ";" & PingLabel.Text & ";" & CPUTempLabel.Text & ";" & GPUTempLabel.Text & ";" &
                   CPUUsageLabel.Text & ";" & RAMUsageLabel.Text & ";" & UploadLabel.Text & ";" & DownloadLabel.Text & ";" & "Last Update: " & TimeLabel.Text &
                   "&Log=")
            Using response As HttpResponseMessage = Await client.GetAsync(uri)
                Using content As HttpContent = response.Content
                    Dim result As String = Await content.ReadAsStringAsync()
                    If result IsNot Nothing Then
                        'Console.WriteLine(result.ToString())
                    End If
                End Using
            End Using
        End Using


        'Await Task.Delay(5000)
        'wc.Stop()
    End Function
    Private Async Sub getLog(ByVal log As String)
        If CStr(Invoke(New Func(Of String)(Function() Me.LogsTextBox.Text))) = "" Then
            bypassCrossThread(LogsTextBox, CStr(Invoke(New Func(Of String)(Function() Me.TimeLabel.Text))) &
                                  " - " & log)

            'LogsTextBox.Text = TimeLabel.Text & " - " & log
        Else
            bypassCrossThread(LogsTextBox, CStr(Invoke(New Func(Of String)(Function() Me.TimeLabel.Text))) &
                                  " - " & log & Environment.NewLine & CStr(Invoke(New Func(Of String)(Function() Me.LogsTextBox.Text))))

            'LogsTextBox.Text = TimeLabel.Text & " - " & log & Environment.NewLine & LogsTextBox.Text
        End If


        'SAVE INTO WARNINGS.CSV FILE ONLY WARNING LOGS
        SyncLock lockWarnings
            If LocalCSVCheckBox.Checked = True Then
                Try
                    Using writer As New StreamWriter("warnings.csv", True) 'true because i wanna append
                        writer.WriteLine(DateTime.Now.ToString("dd MMM yyyy - HH:mm:ss") & ";" & log)
                    End Using
                    'File.AppendAllText("warnings.csv", Environment.NewLine & DateTime.Now.ToString("dd MMM yyyy - HH:mm:ss") & ";" & log)
                Catch
                    bypassCrossThread(LogsTextBox, CStr(Invoke(New Func(Of String)(Function() Me.TimeLabel.Text))) &
                                  " - Could not write to warnings.csv" & Environment.NewLine & CStr(Invoke(New Func(Of String)(Function() Me.LogsTextBox.Text))))

                    'LogsTextBox.Text = TimeLabel.Text & " - Could not write to warnings.csv" & Environment.NewLine & LogsTextBox.Text
                End Try
            End If
        End SyncLock


        'SEND WARNING LOGS TO WEBSERVER
        If WebserverCheckBox.Checked = True Then
            Try
                Using client As HttpClient = New HttpClient
                    Dim uri As New Uri(WebserverTextBox.Text & "api.php?Info=" & WinVersionLabel.Text & ";" & IntIPLabel.Text & ";" & PingLabel.Text & ";" & CPUTempLabel.Text & ";" & GPUTempLabel.Text & ";" &
                   CPUUsageLabel.Text & ";" & RAMUsageLabel.Text & ";" & UploadLabel.Text & ";" & DownloadLabel.Text & ";" & "Last Update: " & TimeLabel.Text &
                   "&Log=" & TimeLabel.Text & " - " & log)
                    Using response As HttpResponseMessage = Await client.GetAsync(uri)
                        Using content As HttpContent = response.Content
                            Dim result As String = Await content.ReadAsStringAsync()
                            If result IsNot Nothing Then
                                'Console.WriteLine(result.ToString())
                            End If
                        End Using
                    End Using
                End Using

            Catch ex As Exception
                bypassCrossThread(LogsTextBox, CStr(Invoke(New Func(Of String)(Function() Me.TimeLabel.Text))) &
                                  " - Could not communicate with the webserver for api with logs" & Environment.NewLine & CStr(Invoke(New Func(Of String)(Function() Me.LogsTextBox.Text))))

                bypassCrossThread(LogsTextBox, CStr(Invoke(New Func(Of String)(Function() Me.TimeLabel.Text))) &
                                  " - " & ex.ToString & Environment.NewLine & CStr(Invoke(New Func(Of String)(Function() Me.LogsTextBox.Text))))

                'LogsTextBox.Text = TimeLabel.Text & " - Could not communicate with the webserver for api with logs" & Environment.NewLine & LogsTextBox.Text
                'LogsTextBox.Text = TimeLabel.Text & " - " & ex.ToString & Environment.NewLine & LogsTextBox.Text
            End Try
        End If

        If sendTelegramWarnings = True And TelegramAlertCheckBox.Checked = True Then
            Try
                Using client As HttpClient = New HttpClient
                    Dim uri As New Uri(WebserverTextBox.Text & "api-telegram.php?Log=" & log)
                    Using response As HttpResponseMessage = Await client.GetAsync(uri)
                        Using content As HttpContent = response.Content
                            Dim result As String = Await content.ReadAsStringAsync()
                            If result IsNot Nothing Then
                                'Console.WriteLine(result.ToString())
                            End If
                        End Using
                    End Using
                End Using

            Catch ex As Exception
                bypassCrossThread(LogsTextBox, CStr(Invoke(New Func(Of String)(Function() Me.TimeLabel.Text))) &
                                  " - Could not communicate with the Telegram Server" & Environment.NewLine & CStr(Invoke(New Func(Of String)(Function() Me.LogsTextBox.Text))))

                bypassCrossThread(LogsTextBox, CStr(Invoke(New Func(Of String)(Function() Me.TimeLabel.Text))) &
                                  " - " & ex.ToString & Environment.NewLine & CStr(Invoke(New Func(Of String)(Function() Me.LogsTextBox.Text))))

                'LogsTextBox.Text = TimeLabel.Text & " - Could not communicate with the Telegram Server" & Environment.NewLine & LogsTextBox.Text
                'LogsTextBox.Text = TimeLabel.Text & " - " & ex.ToString & Environment.NewLine & LogsTextBox.Text
            End Try
            sendTelegramWarnings = False
        End If

    End Sub
    Private Sub StartButton()
        twoTimer.Interval = RefreshEveryUpDownNumeric.Value * 1000
        twoTimer.Enabled = True

        StartMonitorButton.Enabled = False
        StopButton.Enabled = True
        ResetButton.Enabled = False
        saveConfig() 'saves configs into config.ini
    End Sub
    Private Sub StartMonitorButton_Click(sender As Object, e As EventArgs) Handles StartMonitorButton.Click
        StartButton()
    End Sub

    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click
        twoTimer.Enabled = False
        StartMonitorButton.Enabled = True
        StopButton.Enabled = False
        ResetButton.Enabled = True
    End Sub
    Private Sub SendLogsTrackbar_Scroll(sender As Object, e As EventArgs) Handles SendLogsTrackbar.Scroll
        SendLogsCPUTempLabel.Text = "CPU Temp. " & SendLogsTrackbar.Value & " °C"
        SendLogsGPUTempLabel.Text = "GPU Temp. " & SendLogsTrackbar.Value & " °C"
        SendLogsCPUUsageLabel.Text = "CPU Usage " & SendLogsTrackbar.Value & "%"
        SendLogsRAMUsageLabel.Text = "RAM Usage " & SendLogsTrackbar.Value & "%"
    End Sub

    Private Sub ClearLogsButton_Click(sender As Object, e As EventArgs) Handles ClearLogsButton.Click
        LogsTextBox.Text = ""
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        resetConfig()
        SendLogsCPUTempLabel.Text = "CPU Temp. " & SendLogsTrackbar.Value & " °C"
        SendLogsGPUTempLabel.Text = "GPU Temp. " & SendLogsTrackbar.Value & " °C"
        SendLogsCPUUsageLabel.Text = "CPU Usage " & SendLogsTrackbar.Value & "%"
        SendLogsRAMUsageLabel.Text = "RAM Usage " & SendLogsTrackbar.Value & "%"
    End Sub
    Private Sub resetConfig()
        SendLogsTrackbar.Value = 80
        WebserverTextBox.Text = ""
        CPUTempCheckBox.Checked = True
        NetworkStatsCheckBox.Checked = True
        WebserverCheckBox.Checked = True
        LocalCSVCheckBox.Checked = True
        GPUTempCheckBox.Checked = True
        TopMostCheckBox.Checked = False
        AutoRestartCheckBox.Checked = False
        TelegramAlertCheckBox.Checked = False
        AutoRestartMinutesUpDownNumeric.Value = 1
        RefreshEveryUpDownNumeric.Value = 1
        saveConfig()
    End Sub


    Private Sub TopMostCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles TopMostCheckBox.CheckedChanged
        If TopMostCheckBox.Checked = True Then
            TopMost = True
        Else
            TopMost = False
        End If
    End Sub

    '#Region "old code"
    '    Private Sub saveConfig1()
    '        If My.Computer.FileSystem.FileExists("config.ini") = False Then
    '            Dim fs As FileStream = File.Create("config.ini")
    '            fs.Close()
    '        End If

    '        Dim trackbarvalue As String = SendLogsTrackbar.Value
    '        Dim webserver As String = WebserverTextBox.Text
    '        Dim cputemp As String
    '        Dim network As String
    '        Dim sendlogswebserver As String
    '        Dim savelocal As String
    '        Dim gputemp As String
    '        Dim topmost As String
    '        Dim restart As String
    '        Dim telegram As String
    '        Dim restarttime As String = AutoRestartMinutesUpDownNumeric.Value
    '        Dim refreshdata As String = RefreshEveryUpDownNumeric.Value

    '        If CPUTempCheckBox.Checked = True Then
    '            cputemp = "1"
    '        Else
    '            cputemp = "0"
    '        End If
    '        If NetworkStatsCheckBox.Checked = True Then
    '            network = "1"
    '        Else
    '            network = "0"
    '        End If
    '        If WebserverCheckBox.Checked = True Then
    '            sendlogswebserver = "1"
    '        Else
    '            sendlogswebserver = "0"
    '        End If
    '        If LocalCSVCheckBox.Checked = True Then
    '            savelocal = "1"
    '        Else
    '            savelocal = "0"
    '        End If
    '        If GPUTempCheckBox.Checked = True Then
    '            gputemp = "1"
    '        Else
    '            gputemp = "0"
    '        End If
    '        If TopMostCheckBox.Checked = True Then
    '            topmost = "1"
    '        Else
    '            topmost = "0"
    '        End If
    '        If AutoRestartCheckBox.Checked = True Then
    '            restart = "1"
    '        Else
    '            restart = "0"
    '        End If
    '        If TelegramAlertCheckBox.Checked = True Then
    '            telegram = "1"
    '        Else
    '            telegram = "0"
    '        End If

    '        Try
    '            Using writer As New StreamWriter("config.ini", False)
    '                writer.Write(trackbarvalue & "~" & webserver & "~" & cputemp & "~" & network & "~" & sendlogswebserver & "~" & savelocal &
    '                             "~" & gputemp & "~" & topmost & "~" & restart & "~" & restarttime & "~" & telegram & "~" & refreshdata)
    '            End Using
    '        Catch
    '            LogsTextBox.Text = TimeLabel.Text & " - Could not update config.ini" & Environment.NewLine & LogsTextBox.Text
    '        End Try

    '    End Sub
    '    Private Sub loadConfig1()
    '        If My.Computer.FileSystem.FileExists("config.ini") = False Then
    '            Dim fs As FileStream = File.Create("config.ini")
    '            fs.Close()
    '            resetConfig()
    '        End If


    '        Dim strArr() As String
    '        Dim reader As String = My.Computer.FileSystem.ReadAllText("config.ini")
    '        strArr = reader.Split("~")
    '        SendLogsTrackbar.Value = strArr(0)
    '        WebserverTextBox.Text = strArr(1)
    '        If strArr(2) = "1" Then
    '            CPUTempCheckBox.Checked = True
    '        Else
    '            CPUTempCheckBox.Checked = False
    '        End If
    '        If strArr(3) = "1" Then
    '            NetworkStatsCheckBox.Checked = True
    '        Else
    '            NetworkStatsCheckBox.Checked = False
    '        End If
    '        If strArr(4) = "1" Then
    '            WebserverCheckBox.Checked = True
    '        Else
    '            WebserverCheckBox.Checked = False
    '        End If
    '        If strArr(5) = "1" Then
    '            LocalCSVCheckBox.Checked = True
    '        Else
    '            LocalCSVCheckBox.Checked = False
    '        End If
    '        If strArr(6) = "1" Then
    '            GPUTempCheckBox.Checked = True
    '        Else
    '            GPUTempCheckBox.Checked = False
    '        End If
    '        If strArr(7) = "1" Then
    '            TopMostCheckBox.Checked = True
    '        Else
    '            TopMostCheckBox.Checked = False
    '        End If
    '        If strArr(8) = "1" Then
    '            AutoRestartCheckBox.Checked = True
    '        Else
    '            AutoRestartCheckBox.Checked = False
    '        End If
    '        AutoRestartMinutesUpDownNumeric.Value = strArr(9)
    '        If strArr(10) = "1" Then
    '            TelegramAlertCheckBox.Checked = True
    '        Else
    '            TelegramAlertCheckBox.Checked = False
    '        End If
    '        RefreshEveryUpDownNumeric.Value = strArr(11)


    '        'setting max values for logs
    '        SendLogsCPUTempLabel.Text = "CPU Temp. " & SendLogsTrackbar.Value & " °C"
    '        SendLogsGPUTempLabel.Text = "GPU Temp. " & SendLogsTrackbar.Value & " °C"
    '        SendLogsCPUUsageLabel.Text = "CPU Usage " & SendLogsTrackbar.Value & "%"
    '        SendLogsRAMUsageLabel.Text = "RAM Usage " & SendLogsTrackbar.Value & "%"
    '    End Sub
    '#End Region
End Class
