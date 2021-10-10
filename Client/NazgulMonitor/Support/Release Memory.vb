Module Release_Memory
    Public Sub ReleaseMemory()
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.SuppressFinalize(main)
        If Environment.OSVersion.Platform = PlatformID.Win32NT Then
            SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().Handle, -1, -1)
        End If
    End Sub
    Private Declare Function SetProcessWorkingSetSize Lib "kernel32.dll" (ByVal hProcess As IntPtr, ByVal dwMinimumWorkingSetSize As Int32, ByVal dwMaximumWorkingSetSize As Int32) As Int32
End Module
