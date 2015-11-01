Public Class CarreraForm
    Dim operacion_ As String
    Dim MiCarrera As New CarreraClass
    Dim indice_ As Integer

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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        MiCarrera.carrera = CStr(TextBox2.Text)
        MiCarrera.curso = ComboBox1.SelectedIndex + 1

        Select Case operacion_
            Case "Agregar"


                carreras_list.add(MiCarrera)

            Case "Eliminar"


                carreras_list.RemoveAt(indice_)

            Case "Modificar"


                carreras_list.Item(indice_).carrera = MiCarrera.carrera
                carreras_list.Item(indice_).curso = MiCarrera.curso


        End Select
        Me.Close()

        CarrerasGrid.DataGridView1.Refresh()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        carreras_list.TraerCarreras()


    End Sub

    
End Class