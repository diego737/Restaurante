Public Class ModuloForm

    Dim accion_ As String
    Dim MiModulo As New ModuloClass

    Public Property accion() As String
        Get
            Return accion_
        End Get

        Set(ByVal value As String)
            accion_ = value
        End Set
    End Property

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptar.Click

        MiModulo.IdDia = ComboBox1.SelectedIndex + 1
        MiModulo.inicio = ComboBox2.SelectedIndex + 1
        MiModulo.fin = ComboBox3.SelectedIndex + 1

        Select Case accion_
            Case "Alta"
                If ComboBox1.SelectedItem Is Nothing Then Exit Sub

                If ComboBox2.SelectedItem Is Nothing Then Exit Sub

                If ComboBox3.SelectedItem Is Nothing Then Exit Sub

                modulos_list.InsertarModulo(MiModulo)

            Case "Elimina"
                modulos_list.EliminarModulo(MiModulo)

            Case "Modifica"
                modulos_list.ActualizarModulo(MiModulo)
                ModulosGrid.DataGridView1.Refresh()

        End Select

        Me.Close()

    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click

        Me.Close()

    End Sub

    Private Sub ModuloForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        OModulo.IdDia = ComboBox1.SelectedIndex + 1
        OModulo.inicio = ComboBox2.SelectedIndex + 1
        OModulo.fin = ComboBox3.SelectedIndex + 1

        MiModulo = OModulo
    End Sub

End Class