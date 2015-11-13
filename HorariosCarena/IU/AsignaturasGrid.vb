Public Class AsignaturasGrid

    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Agregar.Click

        AsignaturasForm.operacion = "Agregar"
        AsignaturasForm.Show()

    End Sub

    Private Sub Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modificar.Click
        If asignaturas_list.Count = 0 Then Exit Sub

        AsignaturasForm.operacion = "Modificar"

        llenarForm()

        AsignaturasForm.Show()

    End Sub

    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click
        If asignaturas_list.Count = 0 Then Exit Sub

        AsignaturasForm.operacion = "Eliminar"

        llenarForm()

        AsignaturasForm.Show()

    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        MenuForm.MenuStrip1.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub llenarForm()

        AsignaturasForm.MiAsignatura.Id = CInt(DataGridView1.CurrentRow.Cells(0).Value)
        AsignaturasForm.MiAsignatura.Asignados = CInt(DataGridView1.CurrentRow.Cells(1).Value.ToString)
        AsignaturasForm.MiAsignatura.IdCarrera = CInt(DataGridView1.CurrentRow.Cells(2).Value.ToString)
        AsignaturasForm.MiAsignatura.IdDocente = CInt(DataGridView1.CurrentRow.Cells(3).Value.ToString)
        AsignaturasForm.MiAsignatura.Modulos = CInt(DataGridView1.CurrentRow.Cells(4).Value.ToString)
        AsignaturasForm.MiAsignatura.Curso = CInt(DataGridView1.CurrentRow.Cells(5).Value.ToString)
        AsignaturasForm.MiAsignatura.Descripcion = CStr(DataGridView1.CurrentRow.Cells(6).Value.ToString)

        'Revisen que esto ha cambiado.
        '    AsignaturasForm.TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        '    AsignaturasForm.TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        '    AsignaturasForm.TextBox3.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        '    AsignaturasForm.TextBox4.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        '    AsignaturasForm.TextBox5.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
    End Sub

    Private Sub AsignaturasGrid_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        MenuForm.MenuStrip1.Enabled = True
        Me.Dispose()

    End Sub

    Private Sub AsignaturasGrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DataGridView1.DataSource = asignaturas_list

    End Sub

End Class