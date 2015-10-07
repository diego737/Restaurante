Public Class DocentesGrid
    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Agregar.Click
        DocentesForm.operacion = "Agregar"
        DocentesForm.Show()
    End Sub

    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click
        If docentes_list.Count = 0 Then Exit Sub
        DocentesForm.operacion = "Eliminar"
        DocentesForm.indice = CInt(DataGridView1.CurrentRow.Index)
        llenarForm()
        DocentesForm.Show()
    End Sub

    Private Sub Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modificar.Click
        If docentes_list.Count = 0 Then Exit Sub
        DocentesForm.operacion = "Modificar"
        DocentesForm.indice = CInt(DataGridView1.CurrentRow.Index)
        llenarForm()
        DocentesForm.Show()
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        Me.Close()
    End Sub
    Private Sub llenarForm()
        DocentesForm.TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        DocentesForm.NOMBRE.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        DocentesForm.APELLIDO.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        DocentesForm.CORREO_STR.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
    End Sub

    Private Sub DocentesGrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = docentes_list
    End Sub
End Class