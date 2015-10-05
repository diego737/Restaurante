Public Class ModuloForm

    Dim Accion_ As String
    Dim indicemodulo_ As Integer
    Dim MiModulo As New ModuloClass

    Public Property accion() As String
        Get
            Return Accion_
        End Get
        Set(ByVal value As String)
            Accion_ = value
        End Set
    End Property

    Public Property indicemodulo() As Integer
        Get
            Return indicemodulo_
        End Get
        Set(ByVal value As Integer)
            indicemodulo_ = value
        End Set
    End Property

    
    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptar.Click


        MiModulo.IdDia = ComboBox1.SelectedIndex + 1
        MiModulo.inicio = ComboBox2.SelectedIndex + 1
        MiModulo.fin = ComboBox3.SelectedIndex + 1

        Select Case Accion_
            Case "Alta"
                If ComboBox1.SelectedItem Is Nothing Then Exit Sub

                If ComboBox2.SelectedItem Is Nothing Then Exit Sub

                If ComboBox3.SelectedItem Is Nothing Then Exit Sub

                Modulos_list.Add(MiModulo)

            Case "Elimina"

                If modulos_list.Count = 0 Then Exit Sub

                modulos_list.RemoveAt(indicemodulo_)

            Case "Modifica"
                modulos_list.Item(indicemodulo_).IdDia = MiModulo.IdDia
                modulos_list.Item(indicemodulo_).inicio = MiModulo.inicio
                modulos_list.Item(indicemodulo_).fin = MiModulo.fin

                ModulosGrid.DataGridView1.Refresh()

        End Select

        Me.Close()

    End Sub

    Private Sub Cancelar_Click(ByVal sender As system.Object, ByVal e As System.EventArgs) Handles Cancelar.Click

        Me.Close()

    End Sub
End Class