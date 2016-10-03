Public Class Form2
    Private numeroAleatorio As New Random()
    Private codAlumn As Integer = numeroAleatorio.Next
    Private nomAlumn As String
    Private apellAlum As String
    Private telfAlum As Double
    Private emailAlum As String
    Private cursoAlum As String

    Dim checkCodigo, checkNombre, checkApellido, checkTelefono, checkEmail, checkCurso

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        logName.Text() = Module1.user

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form3.Show()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If inputCodigo.Text Is "" Or IsNumeric(inputCodigo.Text) = False Then
            MessageBox.Show("El código de alumno no es numérico o está vacío", "Error")
            checkCodigo = False
            inputCodigo.Text() = ""
            inputCodigo.Focus()
        Else
            checkCodigo = True
        End If

        If inputNombre.Text Is "" Or IsNumeric(inputNombre.Text) = True Then
            MessageBox.Show("El nombre no admite números o está vacío", "Error")
            checkNombre = False
            inputNombre.Text() = ""
            inputNombre.Focus()
        Else
            checkNombre = True
        End If

        If inputApellido.Text Is "" Or IsNumeric(inputApellido.Text) = True Then
            MessageBox.Show("El apellido no admite números o está vacío", "Error")
            checkApellido = False
            inputApellido.Text() = ""
            inputApellido.Focus()
        Else
            checkApellido = True
        End If

        If inputTelefono.Text Is "" Or IsNumeric(inputTelefono.Text) = False Then
            MessageBox.Show("El teléfono no es numérico o está vacío", "Error")
            checkTelefono = False
            inputTelefono.Text() = ""
            inputTelefono.Focus()
        Else
            checkTelefono = True
        End If

        If inputEmail.Text Is "" Then
            MessageBox.Show("Debes introducir un email", "Error")
            checkEmail = False
            inputEmail.Text() = ""
            inputEmail.Focus()
        Else
            checkEmail = True
        End If

        If inputCurso.Text Is "" Then
            MessageBox.Show("Debes introducir un curso", "Error")
            checkCurso = False
            inputCurso.Text() = ""
            inputCurso.Focus()
        Else
            checkCurso = True
        End If

        If checkCodigo = True And checkNombre = True And checkApellido = True And checkTelefono = True And checkEmail = True And checkCurso = True Then


            alumnoNuevo.codAlum = inputCodigo.Text
            alumnoNuevo.nomAlum = inputNombre.Text
            alumnoNuevo.apellAlum = inputApellido.Text
            alumnoNuevo.telfAlum = inputTelefono.Text
            alumnoNuevo.emailAlum = inputEmail.Text
            alumnoNuevo.cursoAlum = inputCurso.Text
            MessageBox.Show("Código de alumno:" & alumnoNuevo.codAlum & vbCrLf & "Nombre de Alumno: " & alumnoNuevo.nomAlum & vbCrLf & "Apellido del Alumno: " & alumnoNuevo.apellAlum & vbCrLf & "Telefono del alumno: " & alumnoNuevo.telfAlum & vbCrLf & "Email del alumno: " & alumnoNuevo.emailAlum & vbCrLf & "Curso del alumno: " & alumnoNuevo.cursoAlum, "Usuario Registrado")

            arrayAlumno(arrayAlumno.Length - 1) = alumnoNuevo

            inputCodigo.Text() = ""
            inputNombre.Text() = ""
            inputApellido.Text() = ""
            inputTelefono.Text() = ""
            inputEmail.Text() = ""
            inputCurso.Text() = ""

            For Each elemento As Alumno In arrayAlumno
                Console.WriteLine(elemento.nomAlum)
            Next

            ReDim Preserve arrayAlumno(arrayAlumno.Length)
        End If

    End Sub
End Class