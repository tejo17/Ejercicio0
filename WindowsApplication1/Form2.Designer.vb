<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.logName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.inputCodigo = New System.Windows.Forms.TextBox()
        Me.inputNombre = New System.Windows.Forms.TextBox()
        Me.inputApellido = New System.Windows.Forms.TextBox()
        Me.inputTelefono = New System.Windows.Forms.TextBox()
        Me.inputEmail = New System.Windows.Forms.TextBox()
        Me.inputCurso = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(149, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario:"
        '
        'logName
        '
        Me.logName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.logName.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.logName.HideSelection = False
        Me.logName.Location = New System.Drawing.Point(194, 22)
        Me.logName.Name = "logName"
        Me.logName.ReadOnly = True
        Me.logName.Size = New System.Drawing.Size(76, 13)
        Me.logName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 263)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Curso"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 223)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Apellidos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Nombre"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Código Alumno"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(43, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Telefono"
        '
        'inputCodigo
        '
        Me.inputCodigo.Location = New System.Drawing.Point(116, 60)
        Me.inputCodigo.Name = "inputCodigo"
        Me.inputCodigo.Size = New System.Drawing.Size(114, 20)
        Me.inputCodigo.TabIndex = 1
        '
        'inputNombre
        '
        Me.inputNombre.Location = New System.Drawing.Point(116, 103)
        Me.inputNombre.Name = "inputNombre"
        Me.inputNombre.Size = New System.Drawing.Size(114, 20)
        Me.inputNombre.TabIndex = 2
        '
        'inputApellido
        '
        Me.inputApellido.Location = New System.Drawing.Point(116, 141)
        Me.inputApellido.Name = "inputApellido"
        Me.inputApellido.Size = New System.Drawing.Size(114, 20)
        Me.inputApellido.TabIndex = 3
        '
        'inputTelefono
        '
        Me.inputTelefono.Location = New System.Drawing.Point(116, 182)
        Me.inputTelefono.Name = "inputTelefono"
        Me.inputTelefono.Size = New System.Drawing.Size(114, 20)
        Me.inputTelefono.TabIndex = 4
        '
        'inputEmail
        '
        Me.inputEmail.Location = New System.Drawing.Point(116, 220)
        Me.inputEmail.Name = "inputEmail"
        Me.inputEmail.Size = New System.Drawing.Size(114, 20)
        Me.inputEmail.TabIndex = 5
        '
        'inputCurso
        '
        Me.inputCurso.Location = New System.Drawing.Point(116, 260)
        Me.inputCurso.Name = "inputCurso"
        Me.inputCurso.Size = New System.Drawing.Size(114, 20)
        Me.inputCurso.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(166, 323)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Alta"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(50, 323)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Busqueda"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(273, 371)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.inputCurso)
        Me.Controls.Add(Me.inputEmail)
        Me.Controls.Add(Me.inputTelefono)
        Me.Controls.Add(Me.inputApellido)
        Me.Controls.Add(Me.inputNombre)
        Me.Controls.Add(Me.inputCodigo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.logName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Registro de Alumnos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents logName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents inputCodigo As TextBox
    Friend WithEvents inputNombre As TextBox
    Friend WithEvents inputApellido As TextBox
    Friend WithEvents inputTelefono As TextBox
    Friend WithEvents inputEmail As TextBox
    Friend WithEvents inputCurso As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
