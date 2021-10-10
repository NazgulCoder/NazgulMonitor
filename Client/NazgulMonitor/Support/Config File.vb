Imports System.IO

Module Config_File
    Public Sub saveConfig()
        If My.Computer.FileSystem.FileExists("config.ini") = False Then
            Dim fs As FileStream = File.Create("config.ini")
            fs.Close()
        End If

        Dim trackbarvalue As String = main.SendLogsTrackbar.Value
        Dim webserver As String = main.WebserverTextBox.Text
        Dim cputemp As String
        Dim network As String
        Dim sendlogswebserver As String
        Dim savelocal As String
        Dim gputemp As String
        Dim topmost As String
        Dim restart As String
        Dim telegram As String
        Dim restarttime As String = main.AutoRestartMinutesUpDownNumeric.Value
        Dim refreshdata As String = main.RefreshEveryUpDownNumeric.Value

        If main.CPUTempCheckBox.Checked = True Then
            cputemp = "1"
        Else
            cputemp = "0"
        End If
        If main.NetworkStatsCheckBox.Checked = True Then
            network = "1"
        Else
            network = "0"
        End If
        If main.WebserverCheckBox.Checked = True Then
            sendlogswebserver = "1"
        Else
            sendlogswebserver = "0"
        End If
        If main.LocalCSVCheckBox.Checked = True Then
            savelocal = "1"
        Else
            savelocal = "0"
        End If
        If main.GPUTempCheckBox.Checked = True Then
            gputemp = "1"
        Else
            gputemp = "0"
        End If
        If main.TopMostCheckBox.Checked = True Then
            topmost = "1"
        Else
            topmost = "0"
        End If
        If main.AutoRestartCheckBox.Checked = True Then
            restart = "1"
        Else
            restart = "0"
        End If
        If main.TelegramAlertCheckBox.Checked = True Then
            telegram = "1"
        Else
            telegram = "0"
        End If

        Try
            Using writer As New StreamWriter("config.ini", False)
                writer.Write(trackbarvalue & "~" & webserver & "~" & cputemp & "~" & network & "~" & sendlogswebserver & "~" & savelocal &
                             "~" & gputemp & "~" & topmost & "~" & restart & "~" & restarttime & "~" & telegram & "~" & refreshdata)
            End Using
        Catch
            bypassCrossThread(main.LogsTextBox, main.TimeLabel.Text & " - Could not update config.ini" & Environment.NewLine & main.LogsTextBox.Text)
        End Try

    End Sub
    Public Sub loadConfig()
        If My.Computer.FileSystem.FileExists("config.ini") = False Then
            Dim fs As FileStream = File.Create("config.ini")
            fs.Close()

        End If


        Dim strArr() As String
        Dim reader As String = My.Computer.FileSystem.ReadAllText("config.ini")
        strArr = reader.Split("~")
        main.SendLogsTrackbar.Value = strArr(0)
        main.WebserverTextBox.Text = strArr(1)
        If strArr(2) = "1" Then
            main.CPUTempCheckBox.Checked = True
        Else
            main.CPUTempCheckBox.Checked = False
        End If
        If strArr(3) = "1" Then
            main.NetworkStatsCheckBox.Checked = True
        Else
            main.NetworkStatsCheckBox.Checked = False
        End If
        If strArr(4) = "1" Then
            main.WebserverCheckBox.Checked = True
        Else
            main.WebserverCheckBox.Checked = False
        End If
        If strArr(5) = "1" Then
            main.LocalCSVCheckBox.Checked = True
        Else
            main.LocalCSVCheckBox.Checked = False
        End If
        If strArr(6) = "1" Then
            main.GPUTempCheckBox.Checked = True
        Else
            main.GPUTempCheckBox.Checked = False
        End If
        If strArr(7) = "1" Then
            main.TopMostCheckBox.Checked = True
        Else
            main.TopMostCheckBox.Checked = False
        End If
        If strArr(8) = "1" Then
            main.AutoRestartCheckBox.Checked = True
        Else
            main.AutoRestartCheckBox.Checked = False
        End If
        main.AutoRestartMinutesUpDownNumeric.Value = strArr(9)
        If strArr(10) = "1" Then
            main.TelegramAlertCheckBox.Checked = True
        Else
            main.TelegramAlertCheckBox.Checked = False
        End If
        main.RefreshEveryUpDownNumeric.Value = strArr(11)


        'setting max values for logs
        bypassCrossThread(main.SendLogsCPUTempLabel, "CPU Temp. " & main.SendLogsTrackbar.Value & " °C")
        bypassCrossThread(main.SendLogsGPUTempLabel, "GPU Temp. " & main.SendLogsTrackbar.Value & " °C")
        bypassCrossThread(main.SendLogsCPUUsageLabel, "CPU Usage " & main.SendLogsTrackbar.Value & "%")
        bypassCrossThread(main.SendLogsRAMUsageLabel, "RAM Usage " & main.SendLogsTrackbar.Value & "%")
    End Sub
End Module
