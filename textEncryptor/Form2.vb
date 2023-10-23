Imports System.Security.Cryptography
Imports System.Text
Public Class Form2


    Private Sub btnEncrypt_Click(sender As Object, e As EventArgs) Handles btnEncrypt.Click

        Dim password As String = txtInput.Text
        Dim salt As String = GenerateSalt()
        Dim hashedPassword As String = HashPassword(password, salt)


        lblOutput.Text = hashedPassword
    End Sub

    Private Function GenerateSalt() As String
        'Generate a random salt using current timestamp
        Dim timestamp As Long = DateTime.Now.Ticks
        Return timestamp.ToString()
    End Function

    Private Function HashPassword(password As String, salt As String) As String
        'combine the password and salt
        Dim combineString As String = password + salt

        'Perform the SHA-256 encryption
        Dim sha256 As New SHA256Managed()
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(combineString)
        Dim hashedBytes As Byte() = sha256.ComputeHash(bytes)
        Dim hashedPassword As String = BitConverter.ToString(hashedBytes).Replace("-", " ").ToLower()

        Return hashedPassword



    End Function

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        txtInput.Clear()
        lblOutput.Clear()
        txtInput.Focus()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Close()
    End Sub
End Class
