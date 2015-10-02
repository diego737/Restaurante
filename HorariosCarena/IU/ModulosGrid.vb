﻿Public Class ModulosGrid

    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Agregar.Click

        ModuloForm.accion = "Alta"
        ModuloForm.Show()

    End Sub

    Private Sub Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar.Click
        ModuloForm.accion = "Modifica"
        ModuloForm.accion = CStr(DataGridView1.CurrentRow.Index)

        llenarform1()

        ModuloForm.Show()

    End Sub

    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click
        If Modulo_list.Count = 0 Then Exit Sub

        ModuloForm.accion = "Elimina"
        ModuloForm.indicemodulo = CStr(DataGridView1.CurrentRow.Index)

        llenarform1()

        ModuloForm.Show()

    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click

        Me.Close()
    End Sub

    Private Sub llenarform1()
        ModuloForm.TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        ModuloForm.ComboBox1.SelectedItem = CInt(DataGridView1.CurrentRow.Cells(1).Value) - 1
        ModuloForm.ComboBox2.SelectedItem = CInt(DataGridView1.CurrentRow.Cells(2).Value) - 1
        ModuloForm.ComboBox3.SelectedItem = CInt(DataGridView1.CurrentRow.Cells(3).Value) - 1

    End Sub


    Private Sub ModulosGrid_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        DataGridView1.DataSource = Modulo_list

    End Sub
End Class