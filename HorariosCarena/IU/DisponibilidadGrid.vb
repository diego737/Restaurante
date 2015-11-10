Public Class DisponibilidadGrid
    
    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Agregar.Click

        DisponibilidadForm.operacion = "Alta"
        DisponibilidadForm.Show()

    End Sub

    Private Sub Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modificar.Click
        If disponibilidades_list.Count = 0 Then Exit Sub

        DisponibilidadForm.operacion = "Modificar"

        llenarForm1()

        DisponibilidadForm.Show()

    End Sub

    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click
        If disponibilidades_list.Count = 0 Then Exit Sub

        DisponibilidadForm.operacion = "Eliminar"

        llenarForm1()

        DisponibilidadForm.Show()

    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        MenuForm.MenuStrip1.Enabled = True
        Me.Dispose()
    End Sub
    Private Sub llenarForm1()
        DisponibilidadForm.TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        DisponibilidadForm.ComboBox1.SelectedItem = DataGridView1.CurrentRow.Cells(1).Value
        DisponibilidadForm.ComboBox1.SelectedItem = DataGridView1.CurrentRow.Cells(2).Value
        DisponibilidadForm.ComboBox2.SelectedItem = DataGridView1.CurrentRow.Cells(3).Value

    End Sub

    Private Sub DisponibilidadGrid_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MenuForm.MenuStrip1.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub DisponibilidadGrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DataGridView1.DataSource = disponibilidades_list

    End Sub

End Class