Public Class HorarioForm

    Dim operacion_ As String
    Dim MiHorario As New HorarioClass

    Public Property operacion() As String
        Get
            Return operacion_
        End Get
        Set(ByVal value As String)
            operacion_ = value
        End Set
    End Property

    Dim indice_ As Byte
    Public Property indice() As Byte
        Get
            Return indice_
        End Get
        Set(ByVal value As Byte)
            indice_ = value
        End Set
    End Property

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptar.Click
        MiHorario.IdCarrera = ComboBox1.SelectedIndex + 1
        MiHorario.IdDia = ComboBox2.SelectedIndex + 1
        MiHorario.IdAsignatura = ComboBox3.SelectedIndex + 1
        MiHorario.IdModulo = ComboBox4.SelectedIndex + 1

        Select Case operacion_
            Case "Alta"
                If ComboBox1.SelectedItem Is Nothing Then Exit Sub

                If ComboBox2.SelectedItem Is Nothing Then Exit Sub

                If ComboBox3.SelectedItem Is Nothing Then Exit Sub

                If ComboBox4.SelectedItem Is Nothing Then Exit Sub

                horarios_list.InsertarHorario(MiHorario)

            Case "Elimina"
                If indice_ = 0 Then Exit Sub
                horarios_list.EliminarHorario(indice_)

            Case "Modifica"
                If indice_ = 0 Then Exit Sub
                horarios_list.ActualizarHorario(MiHorario, indice_)
                HorariosGrid.DataGridView1.Refresh()

        End Select

        Me.Close()

    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        Me.Close()
    End Sub

    Private Sub HorarioForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Cargamos los ComboBox.
        ComboBox1.DataSource = carreras_list.TraerCarreras
        Dim dias() As String = {"Lunes", "Martes", "Miércoles", "Jueves", "Viernes"}
        ComboBox2.Items.AddRange(dias)
        ComboBox3.DataSource = asignaturas_list.TraerAsignatura
        ComboBox4.DataSource = modulos_list.TraerModulos

    End Sub
End Class