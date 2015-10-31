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
        HorarioForm.ShowDialog(Me)

    End Sub

    Private Sub Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modificar.Click
        'Si no hay fila seleccionada salimos.
        If DataGridView1.SelectedRows.Count = 0 Then Exit Sub

        HorarioForm.operacion = "Modifica"
        HorarioForm.indice = CByte(DataGridView1.CurrentRow.Cells(0).Value)

        LlenarForm1()
        HorarioForm.ShowDialog(Me)
    End Sub

    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click
        If DataGridView1.SelectedRows.Count = 0 Then Exit Sub
        HorarioForm.operacion = "Elimina"
        HorarioForm.indice = CByte(DataGridView1.CurrentRow.Cells(0).Value)

        LlenarForm1()
        HorarioForm.ShowDialog(Me)
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        MenuForm.MenuStrip1.Enabled = True
        Me.Close()
    End Sub

    Private Sub HorariosGrid_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MenuForm.MenuStrip1.Enabled = True
    End Sub

    Private Sub HorariosGrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = horarios_list

    End Sub

End Class
