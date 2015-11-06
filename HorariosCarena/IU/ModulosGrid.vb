Public Class ModulosGrid

    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Agregar.Click

        ModuloForm.accion = "Alta"
        ModuloForm.Show()

    End Sub

    Private Sub Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar.Click
        If modulos_list.Count = 0 Then Exit Sub

        ModuloForm.accion = "Modifica"

        llenarform1()

        ModuloForm.Show()

    End Sub

    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click
        If modulos_list.Count = 0 Then Exit Sub

        ModuloForm.accion = "Elimina"

        llenarform1()

        ModuloForm.Show()

    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        MenuForm.MenuStrip1.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub llenarform1()
        ModuloForm.TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        ModuloForm.ComboBox1.SelectedItem = DataGridView1.CurrentRow.Cells(1).Value.ToString
        ModuloForm.ComboBox2.SelectedItem = DataGridView1.CurrentRow.Cells(2).Value.ToString
        ModuloForm.ComboBox3.SelectedItem = DataGridView1.CurrentRow.Cells(3).ToString

    End Sub

    Private Sub ModulosGrid_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MenuForm.MenuStrip1.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub ModulosGrid_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        DataGridView1.DataSource = modulos_list

    End Sub

End Class