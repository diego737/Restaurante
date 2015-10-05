Public Class DisponibilidadForm
    Dim operacion_ As String
    Dim midocente As New DocenteClass
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
        midocente.Apellidos = TextBox1.Text
        midocente.Nombres = TextBox2.Text
        midocente.Correo = TextBox3.Text

        Select Case operacion_
            Case "alta"
                docentes_list.Add(midocente)
            Case "elimina"
                docentes_list.RemoveAt(indice_)
            Case "modifica"
                docentes_list.Item(indice_).Nombres = midocente.Nombres
                docentes_list.Item(indice_).correo = midocente.correo
                DocentesGrid.DataGridView1.Refresh()



        End Select

        Me.Close()
    End Sub

End Class