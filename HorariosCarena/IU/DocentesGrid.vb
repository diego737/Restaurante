Public Class DocentesGrid

    Private Sub LlenarForm1()
        DocentesForm.TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        DocentesForm.NOMBRE.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        DocentesForm.APELLIDO.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        DocentesForm.CORREO_STR.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString

    End Sub

    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Agregar.Click
        DocentesForm.operacion = "Alta"

        DocentesForm.ShowDialog(Me)

    End Sub

    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click
        If DataGridView1.SelectedRows.Count = 0 Then Exit Sub
        DocentesForm.operacion = "Elimina"
        DocentesForm.indice = CByte(DataGridView1.CurrentRow.Cells(0).Value)

        LlenarForm1()
        DocentesForm.ShowDialog(Me)
    End Sub

    Private Sub Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modificar.Click
        'Si no hay fila seleccionada salimos.
        If DataGridView1.SelectedRows.Count = 0 Then Exit Sub

        DocentesForm.operacion = "Modifica"
        DocentesForm.indice = CByte(DataGridView1.CurrentRow.Cells(0).Value)

        LlenarForm1()
        DocentesForm.ShowDialog(Me)
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        MenuForm.MenuStrip1.Enabled = True
        Me.Close()
    End Sub

    Private Sub DocentesGrid_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MenuForm.MenuStrip1.Enabled = True
    End Sub
    

    Private Sub DocentesGrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = docentes_list
    End Sub


End Class
