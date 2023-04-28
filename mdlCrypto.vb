Imports System.Security.Cryptography
Imports System.Text

Module mdlCrypto
    Public Function GetHash(ByVal input As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            ' Convert the input string to a byte array
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(input)

            ' Compute the hash value of the input byte array
            Dim hashBytes As Byte() = sha256.ComputeHash(bytes)

            ' Convert the hash byte array to a string
            Dim hashString As New StringBuilder()

            For i As Integer = 0 To hashBytes.Length - 1
                hashString.Append(hashBytes(i).ToString("X2"))
            Next

            Return hashString.ToString()
        End Using
    End Function
End Module
