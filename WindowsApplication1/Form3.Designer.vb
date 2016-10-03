<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.campoBusqueda = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.busCod = New System.Windows.Forms.TextBox()
        Me.busApe = New System.Windows.Forms.TextBox()
        Me.busNom = New System.Windows.Forms.TextBox()
        Me.busTel = New System.Windows.Forms.TextBox()
        Me.busEma = New System.Windows.Forms.TextBox()
        Me.busCur = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Apellido:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Telefono:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Email:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 278)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Curso:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(42, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Nombre"
        '
        'campoBusqueda
        '
        Me.campoBusqueda.Location = New System.Drawing.Point(92, 51)
        Me.campoBusqueda.Name = "campoBusqueda"
        Me.campoBusqueda.Size = New System.Drawing.Size(135, 20)
        Me.campoBusqueda.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(241, 49)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(123, 327)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Volver"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'busCod
        '
        Me.busCod.Location = New System.Drawing.Point(95, 97)
        Me.busCod.Name = "busCod"
        Me.busCod.Size = New System.Drawing.Size(173, 20)
        Me.busCod.TabIndex = 3
        '
        'busApe
        '
        Me.busApe.Location = New System.Drawing.Point(95, 169)
        Me.busApe.Name = "busApe"
        Me.busApe.Size = New System.Drawing.Size(173, 20)
        Me.busApe.TabIndex = 3
        '
        'busNom
        '
        Me.busNom.Location = New System.Drawing.Point(95, 133)
        Me.busNom.Name = "busNom"
        Me.busNom.Size = New System.Drawing.Size(173, 20)
        Me.busNom.TabIndex = 3
        '
        'busTel
        '
        Me.busTel.Location = New System.Drawing.Point(95, 204)
        Me.busTel.Name = "busTel"
        Me.busTel.Size = New System.Drawing.Size(173, 20)
        Me.busTel.TabIndex = 3
        '
        'busEma
        '
        Me.busEma.Location = New System.Drawing.Point(95, 240)
        Me.busEma.Name = "busEma"
        Me.busEma.Size = New System.Drawing.Size(173, 20)
        Me.busEma.TabIndex = 3
        '
        'busCur
        '
        Me.busCur.Location = New System.Drawing.Point(95, 275)
        Me.busCur.Name = "busCur"
        Me.busCur.Size = New System.Drawing.Size(173, 20)
        Me.busCur.TabIndex = 3
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 380)
        Me.Controls.Add(Me.busCur)
        Me.Controls.Add(Me.busEma)
        Me.Controls.Add(Me.busTel)
        Me.Controls.Add(Me.busNom)
        Me.Controls.Add(Me.busApe)
        Me.Controls.Add(Me.busCod)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.campoBusqueda)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Busqueda de Alumnos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents campoBusqueda As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents busCod As TextBox
    Friend WithEvents busApe As TextBox
    Friend WithEvents busNom As TextBox
    Friend WithEvents busTel As TextBox
    Friend WithEvents busEma As TextBox
    Friend WithEvents busCur As TextBox
End Class
