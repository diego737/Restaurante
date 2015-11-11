Public Class CarreraForm

    Dim operacion_ As String
    Public Micarrera As New CarreraClass

    ''' <summary>
    ''' Identifica el tipo de operación CRUD que se realiza.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property operacion() As String
        Get
            Return operacion_
        End Get

        Set(ByVal value As String)
            operacion_ = value
        End Set
    End Property

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptar.Click

        Micarrera.id = ComboBox1.SelectedIndex + 1
        Micarrera.carrera = CStr(ComboBox2.SelectedIndex + 1)


        Select Case operacion_
            Case "Alta"
                'Si falta seleccionar algún dato en los combos termina sin cargar.
                If ComboBox1.SelectedIndex = -1 Then Exit Sub


                carreras_list.InsertarCarrera(Micarrera)

            Case "Elimina"
                carreras_list.EliminarCarrera(Micarrera)

            Case "Modifica"
                carreras_list.ActualizarCarrera(Micarrera)
                HorariosGrid.DataGridView1.Refresh()

        End Select

        Me.Close()

    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        Me.Close()
    End Sub

    Private Sub CarreraForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Fuente de datos la coleccion carreras_list.
        ComboBox1.DataSource = carreras_list
        'El miembro a mostrar de la lista es carrera en minúscula porque Diego no las distingue.
        ComboBox1.DisplayMember = "carrera"
        'El miembro de valor es siempre el id.
        ComboBox1.ValueMember = "id"

        'Al cargar el formulario incializo MiCarrera para tener el Id que necesito modificar o eleminar.
        If operacion_ <> "Alta" Then
            Micarrera.id = CInt(TextBox1.Text)
            Micarrera.carrera = CStr(ComboBox2.SelectedIndex + 1)

        End If

    End Sub
End Class