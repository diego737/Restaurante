Public Class AsignaturasGrid
    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Agregar.Click
        AsignaturasForm.operacion = "Agregar"
        AsignaturasForm.Show()
    End Sub

    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click
        If asignaturas_list.Count = 0 Then Exit Sub
        AsignaturasForm.operacion = "Eliminar"
        AsignaturasForm.indice = CInt(DataGridView1.CurrentRow.Index)
        llenarForm()
        AsignaturasForm.Show()
    End Sub

    Private Sub Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modificar.Click
        If asignaturas_list.Count = 0 Then Exit Sub
        AsignaturasForm.operacion = "Modificar"
        AsignaturasForm.indice = CInt(DataGridView1.CurrentRow.Index)
        llenarForm()
        AsignaturasForm.Show()
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        Me.Close()
    End Sub
    Private Sub llenarForm()
        AsignaturasForm.TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        AsignaturasForm.TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        AsignaturasForm.TextBox3.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        AsignaturasForm.TextBox4.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        AsignaturasForm.TextBox5.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
    End Sub
    Private Sub AsignaturasGrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = asignaturas_list
    End Sub
End Class