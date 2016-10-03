Public Class Form3
    Dim nombre As String

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buscod.Text() = ""
        busnom.Text() = ""
        busape.Text() = ""
        busTel.Text() = ""
        busEma.Text() = ""
        busCur.Text() = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nombre = campoBusqueda.Text()
        For Each elemento As Alumno In arrayAlumno
            If campoBusqueda.Text() = "" Then
                MessageBox.Show("Debes introducir un nombre")
            Else
                If elemento.nomAlum = nombre Then
                    busCod.Text() = elemento.codAlum
                    busNom.Text() = elemento.nomAlum
                    busApe.Text() = elemento.apellAlum
                    busTel.Text() = elemento.telfAlum
                    busEma.Text() = elemento.emailAlum
                    busCur.Text() = elemento.cursoAlum
                Else
                    MessageBox.Show("No existe ningun alumno con ese nombre")

                End If


            End If
        Next
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub

End Class