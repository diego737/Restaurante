Public Class HorariosGrid

    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Agregar.Click
        'Evento que responde al click del boton agregar.

        'Se asigna el valor "Alta" a la propiedad operación.
        HorarioForm.operacion = "Alta"

        'Muestra el formulario HorarioForm.
        HorarioForm.Show()

    End Sub

    Private Sub Modificar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Modificar.Click
        'Evento que responde al click del botón modificar.

        'Si la lista tiene cero elementos no hay nada pra modificar.
        If horarios_list.Count = 0 Then Exit Sub

        'Se asigna el valor "Modifica" a la propiedad operación.
        HorarioForm.operacion = "Modifica"

        'Ejecuta el método llenarform1
        llenarform1()

        'Muestra el formulario HorarioForm.
        HorarioForm.Show()

    End Sub

    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click
        'Evento que responde al click del botón eliminar.

        'Si la lista tiene cero elementos no hay nada pra eliminar.
        If modulos_list.Count = 0 Then Exit Sub

        'Se asigna el valor "Elimina" a la propiedad operación.
        HorarioForm.operacion = "Elimina"

        'Ejecuta el método llenarform1
        llenarform1()

        'Muestra el formulario HorarioForm.
        HorarioForm.Show()

    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        'Evento que responde al botón salir.

        'Activa el menu nuevamente al cerrar la grilla.
        MenuForm.MenuStrip1.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub llenarform1()
        'Carga los controles de HorariosForm con el elemento seleccionado en la grilla.
        HorarioForm.TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        HorarioForm.ComboBox1.SelectedItem = DataGridView1.CurrentRow.Cells(1).Value.ToString
        HorarioForm.ComboBox2.SelectedItem = DataGridView1.CurrentRow.Cells(2).Value.ToString
        HorarioForm.ComboBox3.SelectedItem = DataGridView1.CurrentRow.Cells(3).ToString

    End Sub

    Private Sub HorariosGrid_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Al cerrar la grilla se activa el menu en MenuForm.
        MenuForm.MenuStrip1.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub HorariosGrid_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Estable la propiedad Datasource del DataGrid como horarios_list.
        'De esta manera la grilla queda enlazada a horarios_list.
        DataGridView1.DataSource = horarios_list

    End Sub

End Class
