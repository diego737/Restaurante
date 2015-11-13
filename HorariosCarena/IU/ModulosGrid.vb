Public Class ModulosGrid

    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Agregar.Click

        ModuloForm.operacion = "Alta"
        ModuloForm.Show()

    End Sub

    Private Sub Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar.Click
        If modulos_list.Count = 0 Then Exit Sub

        ModuloForm.operacion = "Modifica"

        llenarform1()

        ModuloForm.Show()

    End Sub

    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click
        If modulos_list.Count = 0 Then Exit Sub

        ModuloForm.operacion = "Elimina"

        llenarform1()

        ModuloForm.Show()

    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        MenuForm.MenuStrip1.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub llenarform1()
        ModuloForm.MiModulo.Id = CInt(DataGridView1.CurrentRow.Cells(0).Value)
        ModuloForm.MiModulo.Dia = DataGridView1.CurrentRow.Cells(1).Value.ToString
        ModuloForm.MiModulo.Inicio = DataGridView1.CurrentRow.Cells(2).Value.ToString
        ModuloForm.MiModulo.Fin = DataGridView1.CurrentRow.Cells(3).Value.ToString
    End Sub

    Private Sub ModulosGrid_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MenuForm.MenuStrip1.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub ModulosGrid_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        DataGridView1.DataSource = modulos_list

    End Sub

   
End Class