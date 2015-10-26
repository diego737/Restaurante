Public Class CarreraForm
    Dim operacion_ As String
    Dim MiCarrera As New CarreraClass
    Dim indice_ As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox2.Text = "" Then Exit Sub


        Select Case operacion_
            Case "Agregar"

                'asignaturas_list.Add(MiAsignatura)
                carreras_list.Add(MiCarrera)

            Case "Eliminar"

                'asignaturas_list.RemoveAt(indice_)
                asignaturas_list.EliminarAsignatura(indice_)
            Case "Modificar"


                carreras_list.Item(indice_).carrera = MiCarrera.carrera
                carreras_list.Item(indice_).curso = MiCarrera.curso

                'AsignaturasGrid.DataGridView1.Refresh()
                'asignaturas_list.ActualizarAsignatura(MiAsignatura, indice_)
                'AsignaturasGrid.DataGridView1.Refresh()
        End Select
        Me.Close()
        'Me.Refresh()
        'AsignaturasGrid.DataGridView1.RefreshEdit()
        CarrerasGrid.DataGridView1.Refresh()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then

            e.Handled = False
        Else
            e.Handled = True

        End If

    End Sub
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


End Class