Public Class HorariosGrid

    Private Sub LlenarForm1()
        HorarioForm.TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        HorarioForm.ComboBox1.SelectedItem = DataGridView1.CurrentRow.Cells(1).Value
        HorarioForm.ComboBox1.SelectedItem = DataGridView1.CurrentRow.Cells(2).Value
        HorarioForm.ComboBox2.SelectedItem = DataGridView1.CurrentRow.Cells(3).Value
        HorarioForm.ComboBox3.SelectedItem = DataGridView1.CurrentRow.Cells(4).Value
    End Sub

    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Agregar.Click

        HorarioForm.operacion = "Alta"

        HorarioForm.Show()
    End Sub


    Private Sub Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modificar.Click
        HorarioForm.operacion = "Modifica"
        HorarioForm.indice = CByte(DataGridView1.CurrentRow.Index)

        LlenarForm1()

        HorarioForm.Show()
    End Sub


    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click
        HorarioForm.operacion = "Elimina"
        HorarioForm.indice = CByte(DataGridView1.CurrentRow.Index)

        LlenarForm1()

        HorarioForm.Show()
    End Sub


    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        Me.Close()
    End Sub

    Private Sub HorariosGrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        horarios_list.TraerHorarios()
        DataGridView1.DataSource = horarios_list

    End Sub

    Private Sub Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar.Click
        horarios_list.TraerHorarios()
    End Sub
End Class