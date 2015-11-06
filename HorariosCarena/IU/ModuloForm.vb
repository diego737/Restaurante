Public Class ModuloForm

    Dim operacion_ As String
    Dim MiModulo As New ModuloClass

    Public Property operacion() As String
        Get
            Return operacion_
        End Get

        Set(ByVal value As String)
            operacion_ = value
        End Set
    End Property

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptar.Click

        MiModulo.IdDia = ComboBox1.SelectedIndex + 1
        MiModulo.Inicio = ComboBox2.SelectedItem.ToString
        MiModulo.Fin = ComboBox3.SelectedItem.ToString

        Select Case operacion_
            Case "Alta"
                If ComboBox1.SelectedIndex = -1 Then Exit Sub

                If ComboBox2.SelectedIndex = -1 Then Exit Sub

                If ComboBox3.SelectedIndex = -1 Then Exit Sub

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

        'Cargamos los ComboBox.
        'Dim desde() As String = {"17:05", "17:45", "18:25", "19:10", "19:50", "20:35", "21:15", "21:55"}
        'Dim hasta() As String = {"17:45", "18:25", "19:05", "19:50", "20:35", "21:15", "21:55", "22:35"}

        'ComboBox1.DataSource = modulos_list.dias
        'ComboBox2.DataSource = desde
        'ComboBox3.DataSource = hasta

        If operacion_ <> "Alta" Then
            MiModulo.Id = CInt(TextBox1.Text)
            MiModulo.IdDia = ComboBox1.SelectedIndex + 1
            MiModulo.Inicio = ComboBox2.SelectedText
            MiModulo.Fin = ComboBox3.SelectedText
        End If

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox3.Items.Count > 1 Then
            ComboBox3.SelectedIndex = ComboBox2.SelectedIndex
        End If
    End Sub

End Class