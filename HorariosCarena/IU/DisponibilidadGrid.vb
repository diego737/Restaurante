Public Class DisponibilidadGrid

    Private Sub agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles agregar.Click
        DisponibilidadForm.operacion = "alta"
        DisponibilidadForm.Show()

    End Sub



    Private Sub Modif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modif.Click
        DisponibilidadForm.operacion = "Modificar"
        DisponibilidadForm.indice = CByte(DataGridView1.CurrentRow.Index)
        llenarForm()
        DisponibilidadForm.Show()

    End Sub

    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eliminar.Click
        DisponibilidadForm.operacion = "Elimnina"
        DisponibilidadForm.indice = CByte(DataGridView1.CurrentRow.Index)
        llenarForm()
        DisponibilidadForm.Show()

    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salir.Click
        Me.Close()

    End Sub

    Private Sub llenarForm()
        DisponibilidadForm.TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        DisponibilidadForm.TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        DisponibilidadForm.TextBox2.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        DisponibilidadForm.TextBox2.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        DisponibilidadForm.TextBox2.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString


    End Sub

    Private Sub docenteGrid_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        DataGridView1.DataSource = docentes_list

    End Sub

End Class