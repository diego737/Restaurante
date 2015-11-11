Public Class CarrerasGrid

    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Agregar.Click

        CarreraForm.operacion = "Alta"
        CarreraForm.Show()

    End Sub

    Private Sub Modificar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Modificar.Click


        If carreras_list.Count = 0 Then Exit Sub

        CarreraForm.operacion = "Modifica"

        llenarform1()

        CarreraForm.Show()

    End Sub

    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click
        If carreras_list.Count = 0 Then Exit Sub

        CarreraForm.operacion = "Elimina"

        llenarform1()

        CarreraForm.Show()

    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        MenuForm.MenuStrip1.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub llenarform1()
        CarreraForm.TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        CarreraForm.ComboBox1.SelectedItem = DataGridView1.CurrentRow.Cells(1).Value.ToString
        
    End Sub

    Private Sub HorariosGrid_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MenuForm.MenuStrip1.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub HorariosGrid_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        DataGridView1.DataSource = horarios_list

    End Sub

End Class
