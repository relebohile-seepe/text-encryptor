Public Class Form1

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        GunaProgressBar1.Increment(10)

        If GunaProgressBar1.Value = 100 Then
            Me.Hide()
            Form2.Show()
        End If
    End Sub
End Class
