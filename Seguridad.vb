Imports System.Security.Cryptography
Module Seguridad
    'generacion de salt
    Public Function CrearSalt() As String
        Dim saltBytes() As Byte = RandomNumberGenerator.GetBytes(16)
        Return Convert.ToBase64String(saltBytes)
    End Function
    'creacion de hash
    Public Function CrearHash(clave As String, saltTexto As String) As String
        Dim saltBytes() As Byte = Convert.FromBase64String(saltTexto)
        Dim resultado() As Byte = Rfc2898DeriveBytes.Pbkdf2(clave, saltBytes, 1000, HashAlgorithmName.SHA256, 32)

        Return Convert.ToBase64String(resultado)
    End Function

End Module