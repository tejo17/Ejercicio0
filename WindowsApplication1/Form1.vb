Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If inputUser.Text() = user And inputPass.Text() = pass Then
            Me.Hide()
            Form2.Show()
        Else
            MessageBox.Show("El nombre o la contraseña son invalidos")
            inputUser.SelectAll()
            inputPass.SelectAll()
            inputUser.Focus()
        End If
    End Sub
End Class
