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
        midocente.apellidos = textbox2.text
        midocente.Nombres = TextBox3.Text
        midocente.correo = TextBox4.Text

        Select Case operacion_
            Case "alta"
                docentes_list.Add(midocente)
            Case "elimina"
                docentes_list.RemoveAt(indice_)
            Case "modifica"
                docentes_list.Item(indice).nombre = midocente.nombre
                docentes_list.Item(indice_).correo = midocente.correo
                docenteGrid.DataGridView1.Refresh()



        End Select
        Me.Close()

End Class