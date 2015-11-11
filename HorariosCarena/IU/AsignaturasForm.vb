Public Class AsignaturasForm
    Dim operacion_ As String
    Public MiAsignatura As New AsignaturaClass
    'Dim indice_ As Integer

    ''' <summary>
    ''' Identifica el tipo de operación CRUD que se realiza.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public Property operacion() As String
        Get
            Return operacion_
        End Get
        Set(ByVal value As String)
            operacion_ = value
        End Set
    End Property

    'Public Property indice() As Integer
    '    Get
    '        Return indice_
    '    End Get
    '    Set(ByVal value As Integer)
    '        indice_ = value
    '    End Set
    'End Property

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'If TextBox2.Text = "" Then Exit Sub
        'If TextBox3.Text = "" Then Exit Sub
        'If TextBox4.Text = "" Then Exit Sub
        'If TextBox5.Text = "" Then Exit Sub

        MiAsignatura.Asignados = CInt(TextBox2.Text)
        MiAsignatura.IdCarrera = CInt(TextBox3.Text)
        MiAsignatura.IdDocente = CInt(TextBox4.Text)
        MiAsignatura.Modulos = CInt(TextBox5.Text)

        Select Case operacion_
            Case "Agregar"
                If TextBox1.Text Is Nothing Then Exit Sub

                If TextBox2.Text Is Nothing Then Exit Sub

                If TextBox3.Text Is Nothing Then Exit Sub

                If TextBox4.Text Is Nothing Then Exit Sub

                If TextBox5.Text Is Nothing Then Exit Sub

                'asignaturas_list.Add(MiAsignatura)
                asignaturas_list.InsertarAsignatura(MiAsignatura)

            Case "Eliminar"

                asignaturas_list.EliminarAsignatura(MiAsignatura)

            Case "Modificar"

                asignaturas_list.ActualizarAsignatura(MiAsignatura)
                AsignaturasGrid.DataGridView1.Refresh()
        End Select

        Me.Close()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress

        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress

        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress

        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress

        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub AsignaturasForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If operacion_ <> "Alta" Then
            'Esto está mal, lo que se inicializa son los controles no el objeto asignaturas.
            MiAsignatura.Id = CInt(TextBox1.Text)
            MiAsignatura.Asignados = CInt(TextBox2.SelectedText)
            MiAsignatura.IdCarrera = CInt(TextBox3.SelectedText)
            MiAsignatura.IdDocente = CInt(TextBox4.SelectedText)
            MiAsignatura.Modulos = CInt(TextBox5.SelectedText)

        End If

    End Sub
End Class