﻿Public Class DisponibilidadForm

    Dim operacion_ As String
    Public MiDisponibilidad As New DisponibilidadClass

    ''' <summary>
    ''' 
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

        ComboBox1.DataSource = docentes_list
        'Debe coincidir con la propiedad que guarda el nombre del docente en DocenteClass.
        '¿Seguro se llama Nombre ?
        ComboBox1.DisplayMember = "Nombres"
        ComboBox1.ValueMember = "Id"

        ComboBox2.DataSource = modulos_list
        ComboBox2.DisplayMember = "Dia_Inicio"
        ComboBox2.ValueMember = "Id"

        If operacion_ <> "Alta" Then
            TextBox1.Text = MiDisponibilidad.Id.ToString
            ComboBox1.SelectedItem = MiDisponibilidad.IdDocente
            ComboBox2.SelectedItem = MiDisponibilidad.IdModulo
            'ComboBox3.SelectedItem = MiModulo.Fin

            MiDisponibilidad.Id = CInt(TextBox1.Text)
            MiDisponibilidad.IdDocente = ComboBox1.SelectedIndex + 1
            MiDisponibilidad.IdModulo = ComboBox2.SelectedIndex + 1

        End If
    End Sub

    'Esto solo va en modulos, para que el combo 2 se acualice cuando se selecciona el 1.
    'Aca los combos no tiene relación.
    'Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    '    If ComboBox2.Items.Count > 1 Then
    '        ComboBox2.SelectedIndex = ComboBox1.SelectedIndex
    '    End If
    'End Sub
End Class