Public Class CarrerasForm

    Dim operacion_ As String
    Dim MiCarrera As New CarreraClass

    Dim nom() As String
    Dim x As Integer

    Public Property operacion() As String
        Get
            Return operacion_
        End Get
        Set(ByVal value As String)
            operacion_ = value
        End Set
    End Property

    Dim indice_ As Byte
    Public Property indice() As Byte
        Get
            Return indice_
        End Get
        Set(ByVal value As Byte)
            indice_ = value
        End Set
    End Property

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Alta.Click
        Dim carreras_list As New CarrerasCollection

        MiCarrera.Carrera = TextBox2.Text
        MiCarrera.Curso = ComboBox1.SelectedIndex + 1

        Select Case operacion_
            Case "Alta"
                carreras_list.Add(MiCarrera)
            Case "Elimina"
                carreras_list.RemoveAt(indice_)
            Case "Modifica"
                carreras_list.Item(indice_).carrera = MiCarrera.Carrera
                carreras_list.Item(indice_).curso = MiCarrera.Curso

                CarrerasGrid.DataGridView1.Refresh()
        End Select

        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Alta.Click
        Me.Close()
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress

        If Char.IsControl(e.KeyChar) Or Char.IsLetter(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub TextBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.LostFocus
        If TextBox2.Text = "" Then
            Exit Sub
        End If

        nom = TextBox2.Text.Split(" ")
        TextBox2.Text = ""
        For n = 0 To nom.Length - 1
            nom(x) = nom(x).Substring(0, 1).ToUpper() + nom(x).Substring(1).ToLower
        Next
        TextBox2.Text = String.Join(" ", nom)
    End Sub

    'Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    '0 End Sub
End Class
