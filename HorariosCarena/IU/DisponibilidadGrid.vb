Public Class DisponibilidadGrid
    Private Sub llenarForm1()
        DisponibilidadForm.TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        DisponibilidadForm.ComboBox1.SelectedItem = DataGridView1.CurrentRow.Cells(1).Value
        DisponibilidadForm.ComboBox1.SelectedItem = DataGridView1.CurrentRow.Cells(2).Value
        DisponibilidadForm.ComboBox2.SelectedItem = DataGridView1.CurrentRow.Cells(3).Value

    End Sub

    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Agregar.Click

        DisponibilidadForm.operacion = "Alta"

        DisponibilidadForm.Show()
    End Sub


    Private Sub Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar.Click
        DisponibilidadForm.operacion = "Modifica"
        DisponibilidadForm.indice = CByte(DataGridView1.CurrentRow.Index)

        LlenarForm1()

        DisponibilidadForm.Show()
    End Sub


    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click
        DisponibilidadForm.operacion = "Elimina"
        DisponibilidadForm.indice = CByte(DataGridView1.CurrentRow.Index)

        LlenarForm1()

        DisponibilidadForm.Show()
    End Sub


    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        Me.Close()
    End Sub

    Private Sub DisponibilidadGrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        disponibilidades_list.TraerDisponibilidad()
        DataGridView1.DataSource = disponibilidades_list

    End Sub

    Private Sub Actualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar.Click
        disponibilidades_list.TraerDisponibilidad()
    End Sub
End Class