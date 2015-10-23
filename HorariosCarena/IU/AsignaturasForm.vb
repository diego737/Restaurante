Public Class AsignaturasForm
    Dim operacion_ As String
    Dim MiAsignatura As New AsignaturaClass
    Dim indice_ As Integer
    Public Property operacion() As String
        Get
            Return operacion_
        End Get
        Set(ByVal value As String)
            operacion_ = value
        End Set
    End Property
    Public Property indice() As Integer
        Get
            Return indice_
        End Get
        Set(ByVal value As Integer)
            indice_ = value
        End Set
    End Property
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox2.Text = "" Then Exit Sub
        If TextBox3.Text = "" Then Exit Sub
        If TextBox4.Text = "" Then Exit Sub
        If TextBox5.Text = "" Then Exit Sub

        MiAsignatura.Modulos = CInt(TextBox2.Text)
        MiAsignatura.IdCarrera = CInt(TextBox3.Text)
        MiAsignatura.Asignados = CInt(TextBox4.Text)
        MiAsignatura.IdDocente = CInt(TextBox5.Text)

        Select Case operacion_
            Case "Agregar"

                'asignaturas_list.Add(MiAsignatura)
                asignaturas_list.InsertarAsignatura(MiAsignatura)

            Case "Eliminar"

                'asignaturas_list.RemoveAt(indice_)
                asignaturas_list.EliminarAsignatura(indice_)
            Case "Modificar"

                asignaturas_list.Item(indice_).Modulos = MiAsignatura.Modulos
                asignaturas_list.Item(indice_).IdCarrera = MiAsignatura.IdCarrera
                asignaturas_list.Item(indice_).Asignados = MiAsignatura.Asignados
                asignaturas_list.Item(indice_).IdDocente = MiAsignatura.IdDocente
                'AsignaturasGrid.DataGridView1.Refresh()
                'asignaturas_list.ActualizarAsignatura(MiAsignatura, indice_)
                'AsignaturasGrid.DataGridView1.Refresh()
        End Select
        Me.Close()
        'Me.Refresh()
        'AsignaturasGrid.DataGridView1.RefreshEdit()
        AsignaturasGrid.DataGridView1.Refresh()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress

        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress

        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress

        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress

        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub
End Class