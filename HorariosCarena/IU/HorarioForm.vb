Public Class HorarioForm

    Dim operacion_ As String
    Public MiHorario As New HorarioClass

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

        MiHorario.IdCarrera = ComboBox1.SelectedIndex + 1
        MiHorario.IdDia = ComboBox2.SelectedIndex + 1
        MiHorario.IdAsignatura = ComboBox3.SelectedIndex + 1
        MiHorario.IdModulo = ComboBox4.SelectedIndex + 1

        Select Case operacion_
            Case "Alta"
                'Si falta seleccionar algún dato en los combos termina sin cargar.
                If ComboBox1.SelectedIndex = -1 Then Exit Sub

                If ComboBox2.SelectedIndex = -1 Then Exit Sub

                If ComboBox3.SelectedIndex = -1 Then Exit Sub

                If ComboBox4.SelectedIndex = -1 Then Exit Sub

                horarios_list.InsertarHorario(MiHorario)

            Case "Elimina"
                horarios_list.EliminarHorario(MiHorario)

            Case "Modifica"
                horarios_list.ActualizarHorario(MiHorario)
                HorariosGrid.DataGridView1.Refresh()

        End Select

        Me.Close()

    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        Me.Close()
    End Sub

    Private Sub HorarioForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Fuente de datos la coleccion carreras_list.
        ComboBox1.DataSource = carreras_list
        'El miembro a mostrar de la lista es carrera en minúscula porque Diego no las distingue.
        ComboBox1.DisplayMember = "carrera"
        'El miembro de valor es siempre el id.
        ComboBox1.ValueMember = "id"

        'Fuente de datos es la propiedad dias de la colección modulos_list
        ComboBox2.DataSource = modulos_list.dias

        'Fuente de datos asignaturas_list
        ComboBox3.DataSource = asignaturas_list
        'Miembro para mostrar Inicio
        ComboBox4.DisplayMember = "Inicio"
        'Miembro de valor Id.
        ComboBox4.ValueMember = "Id"

        'Fuente de datos modulos_list.
        ComboBox4.DataSource = modulos_list
        'Miembro para mostrar Inicio.
        ComboBox4.DisplayMember = "Inicio"
        'Miembro de valor Id.
        ComboBox4.ValueMember = "Id"

        'Al cargar el formulario incializo MiHorario para tener el Id que necesito modificar o eleminar.
        If operacion_ <> "Alta" Then
            MiHorario.IdCarrera = CInt(TextBox1.Text)
            MiHorario.IdDia = ComboBox1.SelectedIndex + 1
            MiHorario.IdAsignatura = ComboBox2.SelectedIndex + 1
            MiHorario.IdModulo = ComboBox3.SelectedIndex + 1
        End If

    End Sub



    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        'Cuando se selecciona un ítem en el combo2 automáticamete seleccionamos en el combo 3.
        If ComboBox3.Items.Count > 1 Then
            ComboBox3.SelectedIndex = ComboBox2.SelectedIndex
        End If
    End Sub
End Class