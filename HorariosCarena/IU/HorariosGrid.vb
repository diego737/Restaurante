Public Class HorariosGrid

    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Agregar.Click

        HorarioForm.operacion = "Alta"
        HorarioForm.Show()

    End Sub

    Private Sub Modificar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Modificar.Click


        If horarios_list.Count = 0 Then Exit Sub

        HorarioForm.operacion = "Modifica"

        llenarform1()

        HorarioForm.Show()

    End Sub

    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click
        If modulos_list.Count = 0 Then Exit Sub

        HorarioForm.operacion = "Elimina"

        llenarform1()

        HorarioForm.Show()

    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        MenuForm.MenuStrip1.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub llenarform1()
        HorarioForm.TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        HorarioForm.ComboBox1.SelectedItem = DataGridView1.CurrentRow.Cells(1).Value.ToString
        HorarioForm.ComboBox2.SelectedItem = DataGridView1.CurrentRow.Cells(2).Value.ToString
        HorarioForm.ComboBox3.SelectedItem = DataGridView1.CurrentRow.Cells(3).ToString

    End Sub

    Private Sub HorariosGrid_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MenuForm.MenuStrip1.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub HorariosGrid_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        DataGridView1.DataSource = horarios_list

    End Sub

End Class
