Imports System.Text.RegularExpressions

Module Converters
    Public Function BytesConverter(ByVal bytes As Long) As String
        Dim KB As Long = 1024
        Dim MB As Long = KB * KB
        Dim GB As Long = KB * KB * KB
        Dim TB As Long = KB * KB * KB * KB
        Dim returnVal As String = "0 Bytes"

        Select Case bytes
            Case Is <= KB
                returnVal = bytes & " Bytes"
            Case Is > TB
                returnVal = (bytes / KB / KB / KB / KB).ToString("0.00") & " TB"
            Case Is > GB
                returnVal = (bytes / KB / KB / KB).ToString("0.00") & " GB"
            Case Is > MB
                returnVal = (bytes / KB / KB).ToString("0.00") & " MB"
            Case Is > KB
                returnVal = (bytes / KB).ToString("0.00") & " KB"
        End Select

        Return returnVal.ToString
    End Function
    Public Function Num(ByVal value As String) As Integer
        Try
            Dim number As Integer = (Integer.Parse(Regex.Replace(value, "[^\d]", "")))
            Return number
        Catch
            Return 1 'in case is not able to parse the only integers it will return 1 to avoid useless logs or errors
        End Try
    End Function
End Module
