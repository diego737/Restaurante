Public Class CarrerasGrid
    Dim carreras_list As CarrerasCollection

    Private Sub Alta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Alta.Click

        carreras_list = New CarrerasCollection()
        DataGridView1.DataSource = carreras_list
        CarreraForm.operacion = "Alta"
        CarreraForm.Show()
    End Sub

    Private Sub Baja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Baja.Click
        CarreraForm.operacion = "Elimina"
        CarreraForm.indice = DataGridView1.CurrentRow.Index
        llenarform1()
        CarreraForm.Show()
    End Sub

    Private Sub Modifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modifica.Click
        CarreraForm.operacion = "Modifica"
        CarreraForm.indice = DataGridView1.CurrentRow.Index
        llenarform1()
        CarreraForm.Show()
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        Me.Close()
    End Sub

    Private Sub llenarform1()
        CarreraForm.TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        CarreraForm.TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        CarreraForm.ComboBox1.SelectedIndex = CInt(DataGridView1.CurrentRow.Cells(2).Value.ToString) - 1
    End Sub

    Private Sub CarrerasGrid_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        DataGridView1.DataSource = carreras_list
    End Sub



End Class

