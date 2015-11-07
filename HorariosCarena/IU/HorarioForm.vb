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

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptar.Click

        MiHorario.IdCarrera = ComboBox1.SelectedIndex + 1
        MiHorario.IdDia = ComboBox2.SelectedIndex + 1
        MiHorario.IdAsignatura = ComboBox3.SelectedIndex + 1
        MiHorario.IdModulo = ComboBox4.SelectedIndex + 1

        Select Case operacion_
            Case "Alta"
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

        ComboBox1.DataSource = carreras_list
        ComboBox1.DisplayMember = "carrera"
        ComboBox1.ValueMember = "id"

        Dim dias() As String = {"Lunes", "Martes", "Miércoles", "Jueves", "Viernes"}
        ComboBox2.DataSource = dias

        ComboBox3.DataSource = asignaturas_list
        ComboBox4.DisplayMember = "Inicio"
        ComboBox4.ValueMember = "Id"

        ComboBox4.DataSource = modulos_list
        ComboBox4.DisplayMember = "Inicio"
        ComboBox4.ValueMember = "Id"

        If operacion_ <> "Alta" Then
            MiHorario.IdCarrera = CInt(TextBox1.Text)
            MiHorario.IdDia = ComboBox1.SelectedIndex + 1
            MiHorario.IdAsignatura = ComboBox2.SelectedIndex + 1
            MiHorario.IdModulo = ComboBox3.SelectedIndex + 1
        End If
    End Sub
End Class