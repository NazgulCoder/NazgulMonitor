Imports System.Diagnostics
Imports System.Net.NetworkInformation
Imports System.Threading.Tasks

Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Net
Imports System.Threading
Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Windows.Forms
Imports System.Net.Http

Public Class Form1
    Dim iAutoRun As Integer = 0
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

        Timer1.Start()                                                              'timer for current time used in the loggin api as well
        loadConfig()                                                                'loads configs from config.ini
        checkIfAutorun()

        Label2.Text = getWindowsVersion()
        Label6.Text = "Int IP: " & getInternalIP()
    End Sub
    Private Sub removeNotifyIcon()
        If Not Me.NotifyIcon1 Is Nothing Then
            Me.NotifyIcon1.Visible = False
            Me.NotifyIcon1.Dispose()
            Me.NotifyIcon1 = Nothing
        End If
    End Sub
    Private Sub checkIfAutorun()
        NotifyIcon1.Text = "NazgulMonitor"
        Try
            If Environment.GetCommandLineArgs(1).ToString = "--NazgulMonitorAutorun" Then
                StartButton()

            ElseIf Environment.GetCommandLineArgs(1).ToString = "--NazgulMonitorAutorunMinimized" Then
                Me.WindowState = FormWindowState.Minimized
                NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
                'NotifyIcon1.BalloonTipText = "Welcome to TutorialsPanel.com!!"
                'NotifyIcon1.BalloonTipTitle = "Welcome Message"
                'NotifyIcon1.ShowBalloonTip(2000)
                StartButton()
            Else
                getLog("Something went wrong while autorun")
            End If
        Catch
            Console.Write("catch for autorun")
        End Try
    End Sub
    Private Sub ThirteenButton1_Click(sender As Object, e As EventArgs) Handles ThirteenButton1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ThirteenButton2_Click(sender As Object, e As EventArgs) Handles ThirteenButton2.Click
        Dim dlgR As DialogResult

        dlgR = MessageBox.Show("Are you sure you want to close NazgulMonitor?",
            "Attention!", MessageBoxButtons.YesNo)

        If dlgR = DialogResult.Yes Then
            removeNotifyIcon()
            Process.GetCurrentProcess.Kill()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = DateTime.Now.ToString("dd MMM yyyy HH:mm:ss")
        If ThirteenCheckBox6.Checked = True Then
            TopMost = True
        Else
            TopMost = False
        End If
    End Sub
    Private Sub SetAutoRun()
        If iAutoRun <= (NumericUpDown1.Value * 60) Then
            iAutoRun += 1
        Else
            Dim P As Process = New Process
            With P
                .EnableRaisingEvents = True
                .StartInfo.FileName = "NazgulMonitor.exe"

                If ThirteenCheckBox6.Checked = False Then
                    .StartInfo.Arguments = "--NazgulMonitorAutorunMinimized"
                Else
                    .StartInfo.Arguments = "--NazgulMonitorAutorun"
                End If

            End With
            P.Start()
            Thread.Sleep(2000)
            removeNotifyIcon()
            Process.GetCurrentProcess.Kill()
        End If

    End Sub

    Private Async Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'InternetConnection() 'this does not require the exception #implemented in getPing()
        If ThirteenCheckBox7.Checked = True Then
            SetAutoRun()
        End If

        Try
            getCPU()
            Label3.Text = GlobalVariables.CPUusage
        Catch
            getLog("Failed to get CPU usage")
        End Try

        If ThirteenCheckBox2.Checked = True Then
            getPing()
            Label4.Text = GlobalVariables.PingResult
        Else
            Label4.Text = "Ping: Disabled"
        End If

        Try
            Label5.Text = getRAM()
        Catch
            getLog("Failed to get RAM usage")
        End Try

        If ThirteenCheckBox2.Checked = True Then
            Try
                getNetwork()
                Label7.Text = GlobalVariables.upload
                Label8.Text = GlobalVariables.download
            Catch
                getLog("Failed to get Network usage")
            End Try
        Else
            Label7.Text = "Upload: Disabled"
            Label8.Text = "Download: Disabled"
        End If

        If ThirteenCheckBox1.Checked = True Then
            Try
                getCPUTemp()
                Label9.Text = GlobalVariables.CPUTemp
            Catch ex As Exception
                getLog("Failed to get CPU Temperature")
                getLog(ex.ToString)
            End Try
        Else
            Label9.Text = "CPU: Disabled"
        End If

        If ThirteenCheckBox5.Checked = True Then
            Try
                getGPUTemp()
                Label14.Text = GlobalVariables.GPUTemp
            Catch ex As Exception
                getLog("Failed to get GPU Temperature")
                getLog(ex.ToString)
            End Try
        Else
            Label14.Text = "GPU: Disabled"
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



        If ThirteenCheckBox4.Checked = True Then
            Try
                Using writer As New StreamWriter("logs.csv", True) 'true because i wanna append
                    writer.WriteLine(DateTime.Now.ToString("dd MMM yyyy - HH:mm:ss") & ";" & Label2.Text & ";" & Label6.Text & ";" & Label4.Text & ";" & Label9.Text & ";" & Label14.Text & ";" &
                Label3.Text & ";" & Label5.Text & ";" & Label7.Text & ";" & Label8.Text)
                End Using
            Catch
                ThirteenTextBox1.Text = Label1.Text & " - Could not write to logs.csv" & Environment.NewLine & ThirteenTextBox1.Text
            End Try
        End If


    End Sub
    Private Sub WarningLogs()
        Dim CPUTemp As Integer = Num(Label9.Text)
        If (ThirteenCheckBox1.Checked = True) And (CPUTemp > TrackBar1.Value) Then
            getLog("CPU Temperature " & CPUTemp & " Celsius")
        End If

        Dim CPUUsage As Integer = Num(Label3.Text)
        If (CPUUsage > TrackBar1.Value) Then
            getLog("CPU Usage " & CPUUsage & "%")
        End If

        Dim RAMUsage As Integer = Num(Label5.Text)
        If (RAMUsage > TrackBar1.Value) Then
            getLog("RAM Usage " & RAMUsage & "%")
        End If

        Dim GPUTemp As Integer = Num(Label14.Text)
        If (GPUTemp > TrackBar1.Value) Then
            getLog("GPU Temperature " & GPUTemp & " Celsius")
        End If
    End Sub
    Private Async Function sendLogs() As Task
        'Dim wc As New WebBrowser
        ''wc.ScriptErrorsSuppressed = True
        ''wc.Visible = False
        'If ThirteenCheckBox3.Checked = True Then
        '    wc.Navigate(ThirteenTextBox2.Text & "api.php?Info=" & Label2.Text & ";" & Label6.Text & ";" & Label4.Text & ";" & Label9.Text & ";" & Label14.Text & ";" &
        '            Label3.Text & ";" & Label5.Text & ";" & Label7.Text & ";" & Label8.Text & ";" & "Last Update: " & Label1.Text &
        '            "&Log=")
        'End If

        Dim uri As New Uri(ThirteenTextBox2.Text & "api.php?Info=" & Label2.Text & ";" & Label6.Text & ";" & Label4.Text & ";" & Label9.Text & ";" & Label14.Text & ";" &
                   Label3.Text & ";" & Label5.Text & ";" & Label7.Text & ";" & Label8.Text & ";" & "Last Update: " & Label1.Text &
                   "&Log=")
        Using client As HttpClient = New HttpClient
            Using response As HttpResponseMessage = Await client.GetAsync(uri)
                Using content As HttpContent = response.Content
                    Dim result As String = Await content.ReadAsStringAsync()
                    If result IsNot Nothing Then
                        Console.WriteLine(result.ToString())
                    End If
                End Using
            End Using
        End Using


        'Await Task.Delay(5000)
        'wc.Stop()
    End Function

    'Private Sub getCPUTemp2()
    '    Dim cp As New Computer()
    '    cp.Open()
    '    cp.HDDEnabled = True
    '    cp.FanControllerEnabled = True
    '    cp.RAMEnabled = True
    '    cp.GPUEnabled = True
    '    cp.MainboardEnabled = True
    '    cp.CPUEnabled = True

    '    Dim Info As String = ""

    '    For i As Integer = 0 To cp.Hardware.Count() - 1
    '        Dim hw = cp.Hardware(i)

    '        Select Case hw.HardwareType
    '            Case HardwareType.Mainboard
    '                TextBox1.AppendText("Motherboard" & vbCrLf)
    '                For k = 0 To hw.SubHardware.Count - 1
    '                    Dim subhardware = hw.SubHardware(k)
    '                    TextBox1.AppendText(subhardware.Name & vbCrLf)
    '                    For j = 0 To subhardware.Sensors.Count - 1
    '                        Dim sensor = subhardware.Sensors(j)
    '                        TextBox1.AppendText(sensor.SensorType & " - " & sensor.Name & " - " & sensor.Value & vbCrLf)
    '                    Next
    '                Next
    '            Case HardwareType.CPU
    '                TextBox1.AppendText("CPU" & vbCrLf)
    '                For j = 0 To hw.Sensors.Count - 1
    '                    Dim sensor = hw.Sensors(j)
    '                    TextBox1.AppendText(sensor.SensorType & " - " & sensor.Name & " - " & sensor.Value & vbCrLf)
    '                Next
    '            Case HardwareType.RAM
    '                TextBox1.AppendText("RAM" & vbCrLf)
    '                For j = 0 To hw.Sensors.Count - 1
    '                    Dim sensor = hw.Sensors(j)
    '                    TextBox1.AppendText(sensor.SensorType & " - " & sensor.Name & " - " & sensor.Value & vbCrLf)
    '                Next
    '        End Select
    '    Next
    'End Sub
    Private Async Sub getLog(ByVal log As String)
        If ThirteenTextBox1.Text = "" Then
            ThirteenTextBox1.Text = Label1.Text & " - " & log
        Else
            ThirteenTextBox1.Text = Label1.Text & " - " & log & Environment.NewLine & ThirteenTextBox1.Text
        End If


        'SAVE INTO WARNINGS.CSV FILE ONLY WARNING LOGS
        If ThirteenCheckBox4.Checked = True Then
            Try
                Using writer As New StreamWriter("warnings.csv", True) 'true because i wanna append
                    writer.WriteLine(DateTime.Now.ToString("dd MMM yyyy - HH:mm:ss") & ";" & log)
                End Using
            Catch
                ThirteenTextBox1.Text = Label1.Text & " - Could not write to warnings.csv" & Environment.NewLine & ThirteenTextBox1.Text
            End Try
        End If


        'SEND WARNING LOGS TO WEBSERVER
        If ThirteenCheckBox3.Checked = True Then
            Try
                Dim uri As New Uri(ThirteenTextBox2.Text & "api.php?Info=" & Label2.Text & ";" & Label6.Text & ";" & Label4.Text & ";" & Label9.Text & ";" & Label14.Text & ";" &
                   Label3.Text & ";" & Label5.Text & ";" & Label7.Text & ";" & Label8.Text & ";" & "Last Update: " & Label1.Text &
                   "&Log=" & Label1.Text & " - " & log)
                Using client As HttpClient = New HttpClient
                    Using response As HttpResponseMessage = Await client.GetAsync(uri)
                        Using content As HttpContent = response.Content
                            Dim result As String = Await content.ReadAsStringAsync()
                            If result IsNot Nothing Then
                                Console.WriteLine(result.ToString())
                            End If
                        End Using
                    End Using
                End Using

            Catch ex As Exception
                ThirteenTextBox1.Text = Label1.Text & " - Could not communicate with the webserver" & Environment.NewLine & ThirteenTextBox1.Text
                ThirteenTextBox1.Text = Label1.Text & " - " & ex.ToString & Environment.NewLine & ThirteenTextBox1.Text
            End Try
        End If

    End Sub
    Private Sub StartButton()
        Timer2.Start()
        ThirteenButton3.Enabled = False
        ThirteenButton4.Enabled = True
        ThirteenButton6.Enabled = False
        saveConfig() 'saves configs into config.ini
    End Sub
    Private Sub ThirteenButton3_Click(sender As Object, e As EventArgs) Handles ThirteenButton3.Click
        StartButton()
    End Sub

    Private Sub ThirteenButton4_Click(sender As Object, e As EventArgs) Handles ThirteenButton4.Click
        Timer2.Stop()
        ThirteenButton3.Enabled = True
        ThirteenButton4.Enabled = False
        ThirteenButton6.Enabled = True
    End Sub
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Label11.Text = "CPU Temp. " & TrackBar1.Value & " °C"
        Label15.Text = "GPU Temp. " & TrackBar1.Value & " °C"
        Label12.Text = "CPU Usage " & TrackBar1.Value & "%"
        Label13.Text = "RAM Usage " & TrackBar1.Value & "%"
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Try
            ReleaseMemory() 'every 60sec it tries to free some ram
        Catch
            getLog("Error while releasing memory")
        End Try
    End Sub

    Private Sub ThirteenButton5_Click(sender As Object, e As EventArgs) Handles ThirteenButton5.Click
        ThirteenTextBox1.Text = ""
    End Sub

    Private Sub ThirteenButton6_Click(sender As Object, e As EventArgs) Handles ThirteenButton6.Click
        resetConfig()
        Label11.Text = "CPU Temp. " & TrackBar1.Value & " °C"
        Label15.Text = "GPU Temp. " & TrackBar1.Value & " °C"
        Label12.Text = "CPU Usage " & TrackBar1.Value & "%"
        Label13.Text = "RAM Usage " & TrackBar1.Value & "%"
    End Sub
    Private Sub resetConfig()
        TrackBar1.Value = 80
        ThirteenTextBox2.Text = ""
        ThirteenCheckBox1.Checked = True
        ThirteenCheckBox2.Checked = True
        ThirteenCheckBox3.Checked = True
        ThirteenCheckBox4.Checked = True
        ThirteenCheckBox5.Checked = True
        ThirteenCheckBox6.Checked = False
        ThirteenCheckBox7.Checked = False
        NumericUpDown1.Value = 1
        saveConfig()
    End Sub

    Private Sub saveConfig()
        If My.Computer.FileSystem.FileExists("config.ini") = False Then
            Dim fs As FileStream = File.Create("config.ini")
            fs.Close()
        End If

        Dim trackbarvalue As String = TrackBar1.Value
        Dim webserver As String = ThirteenTextBox2.Text
        Dim cputemp As String
        Dim network As String
        Dim sendlogswebserver As String
        Dim savelocal As String
        Dim gputemp As String
        Dim topmost As String
        Dim restart As String
        Dim restarttime As String = NumericUpDown1.Value

        If ThirteenCheckBox1.Checked = True Then
            cputemp = "1"
        Else
            cputemp = "0"
        End If
        If ThirteenCheckBox2.Checked = True Then
            network = "1"
        Else
            network = "0"
        End If
        If ThirteenCheckBox3.Checked = True Then
            sendlogswebserver = "1"
        Else
            sendlogswebserver = "0"
        End If
        If ThirteenCheckBox4.Checked = True Then
            savelocal = "1"
        Else
            savelocal = "0"
        End If
        If ThirteenCheckBox5.Checked = True Then
            gputemp = "1"
        Else
            gputemp = "0"
        End If
        If ThirteenCheckBox6.Checked = True Then
            topmost = "1"
        Else
            topmost = "0"
        End If
        If ThirteenCheckBox7.Checked = True Then
            restart = "1"
        Else
            restart = "0"
        End If

        Try
            Using writer As New StreamWriter("config.ini", False)
                writer.Write(trackbarvalue & "~" & webserver & "~" & cputemp & "~" & network & "~" & sendlogswebserver & "~" & savelocal &
                             "~" & gputemp & "~" & topmost & "~" & restart & "~" & restarttime)
            End Using
        Catch
            ThirteenTextBox1.Text = Label1.Text & " - Could not update config.ini" & Environment.NewLine & ThirteenTextBox1.Text
        End Try

    End Sub
    Private Sub loadConfig()
        If My.Computer.FileSystem.FileExists("config.ini") = False Then
            Dim fs As FileStream = File.Create("config.ini")
            fs.Close()
            resetConfig()
        End If


        Dim strArr() As String
        Dim reader As String = My.Computer.FileSystem.ReadAllText("config.ini")
        strArr = reader.Split("~")
        TrackBar1.Value = strArr(0)
        ThirteenTextBox2.Text = strArr(1)
        If strArr(2) = "1" Then
            ThirteenCheckBox1.Checked = True
        Else
            ThirteenCheckBox1.Checked = False
        End If
        If strArr(3) = "1" Then
            ThirteenCheckBox2.Checked = True
        Else
            ThirteenCheckBox2.Checked = False
        End If
        If strArr(4) = "1" Then
            ThirteenCheckBox3.Checked = True
        Else
            ThirteenCheckBox3.Checked = False
        End If
        If strArr(5) = "1" Then
            ThirteenCheckBox4.Checked = True
        Else
            ThirteenCheckBox4.Checked = False
        End If
        If strArr(6) = "1" Then
            ThirteenCheckBox5.Checked = True
        Else
            ThirteenCheckBox5.Checked = False
        End If
        If strArr(7) = "1" Then
            ThirteenCheckBox6.Checked = True
        Else
            ThirteenCheckBox6.Checked = False
        End If
        If strArr(8) = "1" Then
            ThirteenCheckBox7.Checked = True
        Else
            ThirteenCheckBox7.Checked = False
        End If
        NumericUpDown1.Value = strArr(9)


        'setting max values for logs
        Label11.Text = "CPU Temp. " & TrackBar1.Value & " °C"
        Label15.Text = "GPU Temp. " & TrackBar1.Value & " °C"
        Label12.Text = "CPU Usage " & TrackBar1.Value & "%"
        Label13.Text = "RAM Usage " & TrackBar1.Value & "%"
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.WindowState = FormWindowState.Normal
    End Sub
End Class
