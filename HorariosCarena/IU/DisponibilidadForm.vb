Public Class DisponibilidadForm
    Dim operacion_ As String
    Dim MiDisponibilidad As New DisponibilidadClass
    Public Property operacion() As String
        Get
            Return operacion_

        End Get
        Set(ByVal value As String)

        End Set
    End Property
    Dim indice_ As Byte
    Public Property indice() As Byte
        Get
            Return indice
        End Get
        Set(ByVal value As Byte)

        End Set
    End Property

    Private Sub aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aceptar.Click

        MiDisponibilidad.IdDocente = ComboBox1.SelectedIndex + 1
        MiDisponibilidad.IdModulo = ComboBox2.SelectedIndex + 1

        Select Case operacion_
            Case "alta"
                'disponibilidad_list.Add(MiDisponibilidad)
                disponibilidades_list.InsertarDisponibilidad(MiDisponibilidad)
            Case "elimina"
                If disponibilidades_list.Count = 0 Then Exit Sub

                'horarios_list.RemoveAt(indice_)
                disponibilidades_list.EliminarDisponibilidad(indice_)
            Case "modifica"
                disponibilidades_list.ActualizarDisponibilidad(MiDisponibilidad, indice_)
                DisponibilidadGrid.DataGridView1.Refresh()
        End Select





        Me.Close()
    End Sub

End Class