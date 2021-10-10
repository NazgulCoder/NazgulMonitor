Imports System.Threading.Tasks
Imports OpenHardwareMonitor.Hardware

Module PerformanceCounters
#Region "ALL Variables"
    'RAM
    Dim RamUsage As String
    'PING
    Dim Result As Net.NetworkInformation.PingReply
    Dim SendPing As New Net.NetworkInformation.Ping
    Dim ResponseTime As Long
    'CPU
    Dim backupcpu As String
    Dim cpuUsage As PerformanceCounter = New PerformanceCounter("Processor", "% Processor Time", "_Total")
    'NETWORK
    Dim backupNetwork As String
    Dim strArrNetwork() As String

    Public cp As New Computer()

    'Dim networkInterfaces As New System.Diagnostics.PerformanceCounterCategory("Network Interface")
    'Dim nics As String() = networkInterfaces.GetInstanceNames()
    'Dim bytesSent(nics.Length - 1) As System.Diagnostics.PerformanceCounter
    'Dim bytesReceived(nics.Length - 1) As System.Diagnostics.PerformanceCounter
    'OpenHardwareMonitor
    'Dim cp As New Computer()

#End Region

    Public Function getWindowsVersion() As String
        Dim WindowsVersion As String = My.Computer.Info.OSFullName              'get windows version
        WindowsVersion = WindowsVersion.Replace("Microsoft ", "")               'removes Microsoft from FULL OS NAME
        Return WindowsVersion
    End Function
    Public Function getInternalIP() As String
        Dim _IP As String = Nothing
        Dim _IPHostEntry As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName())
        For Each _IPAddress As System.Net.IPAddress In _IPHostEntry.AddressList
            If _IPAddress.AddressFamily.ToString() = "InterNetwork" Then
                _IP = _IPAddress.ToString()
            End If
        Next _IPAddress
        Return _IP
    End Function
    Public Function getRAM() As String
        RamUsage = (100 - (My.Computer.Info.AvailablePhysicalMemory / My.Computer.Info.TotalPhysicalMemory * 100)).ToString("f")
        Return "RAM: " & Int(RamUsage) & "% used"
    End Function

    Public Async Sub getPing()
        'Dim thread As New Thread(
        'Sub()

        Try
            Result = SendPing.Send("www.google.com")
            ResponseTime = Result.RoundtripTime
            If Result.Status = Net.NetworkInformation.IPStatus.Success Then
                main.GlobalVariables.PingResult = "Ping: " & ResponseTime.ToString & "ms"
            Else
                main.GlobalVariables.PingResult = "Ping: Failed to Ping"
            End If
        Catch
            main.GlobalVariables.PingResult = "Ping thread went in error"
        End Try
        'End Sub)
        'thread.Start()
        Await Task.Delay(1000)
    End Sub

    Public Async Sub getCPU()
        'cpuUsage = New PerformanceCounter("Processor", "% Processor Time", "_Total")
        backupcpu = "CPU: " & Int(cpuUsage.NextValue()) & "% used"
        Await Task.Delay(1000)
        'System.Threading.Thread.Sleep(1000)
        backupcpu = "CPU: " & Int(cpuUsage.NextValue()) & "% used"


        If backupcpu.Contains("0%") Then
        Else
            main.GlobalVariables.CPUusage = backupcpu 'cpuusage is somehow too fast for the logs
        End If
    End Sub

    Public Async Sub getNetwork()
        Dim networkInterfaces As New System.Diagnostics.PerformanceCounterCategory("Network Interface")
        Dim nics As String() = networkInterfaces.GetInstanceNames()
        Dim bytesSent(nics.Length - 1) As System.Diagnostics.PerformanceCounter
        Dim bytesReceived(nics.Length - 1) As System.Diagnostics.PerformanceCounter
        Try 'idk why but program was crashing when switching network or having very very laggy connection

            'Dim i As Integer
            For i = 0 To nics.Length - 1
                bytesSent(i) = New System.Diagnostics.PerformanceCounter("Network Interface", "Bytes Sent/sec", nics(i), True)
                bytesReceived(i) = New System.Diagnostics.PerformanceCounter("Network Interface", "Bytes received/sec", nics(i), True)
            Next

            For i = 0 To nics.Length - 1
                backupNetwork = (String.Format("{1};{2}", i, bytesSent(i).NextValue, bytesReceived(i).NextValue))
                Await Task.Delay(1000)
                backupNetwork = (String.Format("{1};{2}", i, bytesSent(i).NextValue, bytesReceived(i).NextValue))

                If backupNetwork.Contains("0;") Or backupNetwork.Contains(";0") Then
                Else
                    strArrNetwork = backupNetwork.Split(";")
                    main.GlobalVariables.upload = "Upload: " & BytesConverter(CLng(strArrNetwork(0)))
                    main.GlobalVariables.download = "Download: " & BytesConverter(CLng(strArrNetwork(1)))
                End If
                'Label7.Text = (String.Format("{1} Bytes/s sent, {2} Bytes/s received", i, bytesSent(i).NextValue, bytesReceived(i).NextValue))
                'Await Task.Delay(1000)
                'Label7.Text = (String.Format("{1} Bytes/s sent, {2} Bytes/s received", i, bytesSent(i).NextValue, bytesReceived(i).NextValue))
            Next
        Catch
            Console.WriteLine("Error while retrieving Network Stats")
        End Try
    End Sub
    Public Sub getGPUTemp()
        'GPU TEMP
        'Dim cp As New Computer()
        If cp.GPUEnabled = False Then
            cp.GPUEnabled = True
            cp.Open()
        End If
        'cp.Open()

        'For i As Integer = 0 To cp.Hardware.Length - 1
        '    Dim hw = cp.Hardware(i)

        '    Select Case hw.HardwareType

        '        Case HardwareType.GpuAti
        '            For j = 0 To hw.Sensors.Length - 1
        '                Dim sensor = hw.Sensors(j)
        '                If cp.Hardware(i).Sensors(j).SensorType = SensorType.Temperature Then
        '                    Form1.GlobalVariables.GPUTemp = "GPU: " & sensor.Value & " Celsius"
        '                    Exit Sub
        '                End If
        '            Next

        '        Case HardwareType.GpuNvidia
        '            For j = 0 To hw.Sensors.Length - 1
        '                Dim sensor = hw.Sensors(j)
        '                If cp.Hardware(i).Sensors(j).SensorType = SensorType.Temperature Then
        '                    Form1.GlobalVariables.GPUTemp = "GPU: " & sensor.Value & " Celsius"
        '                    Exit Sub
        '                End If
        '            Next
        '    End Select
        'Next

        Dim gpus = cp.Hardware.Where(Function(hw) hw.HardwareType = HardwareType.GpuNvidia Or hw.HardwareType = HardwareType.GpuAti).ToArray()
        For Each gpu In gpus
            Dim sensors = gpu.Sensors.Where(Function(s) s.SensorType = SensorType.Temperature).ToArray()
            For Each sensor In sensors
                main.GlobalVariables.GPUTemp = "GPU: " & sensor.Value & " Celsius"
            Next
        Next

        'cp.Close()
        cp.Reset()

    End Sub
    Public Sub getCPUTemp()
        'CPU TEMP
        'Dim cp As New Computer()
        If cp.CPUEnabled = False Then
            cp.CPUEnabled = True
            cp.Open()
        End If
        'cp.Open()


        'For i As Integer = 0 To cp.Hardware.Length - 1
        '    Dim hw = cp.Hardware(i)

        '    Select Case hw.HardwareType

        '        Case HardwareType.CPU
        '            For j = 0 To hw.Sensors.Length - 1
        '                Dim sensor = hw.Sensors(j)
        '                If cp.Hardware(i).Sensors(j).SensorType = SensorType.Temperature Then
        '                    Form1.GlobalVariables.CPUTemp = "CPU: " & sensor.Value & " Celsius"
        '                End If
        '            Next
        '    End Select
        'Next

        Dim cpus = cp.Hardware.Where(Function(hw) hw.HardwareType = HardwareType.CPU).ToArray()
        For Each cpu In cpus
            Dim sensors = cpu.Sensors.Where(Function(s) s.SensorType = SensorType.Temperature).ToArray()
            For Each sensor In sensors
                main.GlobalVariables.CPUTemp = "CPU: " & sensor.Value & " Celsius"
            Next
        Next
        'cp.Close()
        cp.Reset()
    End Sub
End Module
