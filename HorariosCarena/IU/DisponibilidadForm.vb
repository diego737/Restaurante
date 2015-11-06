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
            Case "Alta"
                If ComboBox1.SelectedItem Is Nothing Then Exit Sub

                If ComboBox2.SelectedItem Is Nothing Then Exit Sub



                disponibilidades_list.InsertarDisponibilidad(MiDisponibilidad)

            Case "Elimina"

                disponibilidades_list.EliminarDisponibilidad(MiDisponibilidad)

            Case "Modifica"

                disponibilidades_list.ActualizarDisponibilidad(MiDisponibilidad)
                DisponibilidadGrid.DataGridView1.Refresh()

        End Select

        Me.Close()

    End Sub

    Private Sub cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelar.Click
        Me.Close()
    End Sub

    Private Sub DisponibilidadForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.DataSource = docentes_list.TraerDocentes
        ComboBox2.DataSource = modulos_list.TraerModulos


    End Sub
End Class