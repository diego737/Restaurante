Public Class CarrerasGrid
    Dim carreras_list As CarrerasCollection


    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        Me.Close()

    End Sub

    Private Sub llenarform1()
        CarreraForm.TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        CarreraForm.TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        CarreraForm.ComboBox1.SelectedIndex = CInt(DataGridView1.CurrentRow.Cells(2).Value.ToString) - 1
    End Sub

    Private Sub CarrerasGrid_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MenuForm.MenuStrip1.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub CarrerasGrid_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        DataGridView1.DataSource = carreras_list
    End Sub

    Private Sub Agregar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Agregar.Click
        CarreraForm.operacion = "Alta"
        CarreraForm.Show()
    End Sub

    Private Sub Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modificar.Click
        CarreraForm.operacion = "Modificar"
        llenarform1()
        CarreraForm.Show()
    End Sub

    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click
        If carreras_list.Count = 0 Then Exit Sub

        CarreraForm.operacion = "Elimina"

        llenarform1()

        CarreraForm.Show()
    End Sub
End Class

