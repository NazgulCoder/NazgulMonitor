Module Connection_Fixer
    Public Function AcceptAllCertifications(ByVal sender As Object, ByVal certification As System.Security.Cryptography.X509Certificates.X509Certificate, ByVal chain As System.Security.Cryptography.X509Certificates.X509Chain, ByVal sslPolicyErrors As System.Net.Security.SslPolicyErrors) As Boolean
        Return True
    End Function
    Public Sub bypassCrossThread(ByVal control As Control, ByVal txt As String)
        If control.InvokeRequired Then
            control.BeginInvoke(New Action(Of Control, String)(AddressOf bypassCrossThread), control, txt)
        Else
            control.Text = txt
        End If
    End Sub
End Module
