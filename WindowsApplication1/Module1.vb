Module Module1
    Public Structure Alumno
        Dim codAlum As Integer
        Dim nomAlum As String
        Dim apellAlum As String
        Dim telfAlum As Double
        Dim emailAlum As String
        Dim cursoAlum As String
    End Structure
    Public alumnoNuevo As Alumno
    Public arrayAlumno(0) As Alumno

    Friend user As String = "Abel"
    Friend pass As String = "1234"
End Module
