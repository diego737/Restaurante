Public Class MenuForm
    Private Sub Asignaturas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Asignaturas.Click

        MenuStrip1.Enabled = False

        Dim frmasignaturagrid As New AsignaturasGrid
        frmasignaturagrid.MdiParent = Me
        frmasignaturagrid.Show()

    End Sub

    Private Sub Disponibilidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Disponibilidad.Click

        MenuStrip1.Enabled = False

        Dim frmdisponibilidad As New DisponibilidadGrid
        frmdisponibilidad.MdiParent = Me
        frmdisponibilidad.Show()

    End Sub

    Private Sub Docentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Docentes.Click

        MenuStrip1.Enabled = False

        Dim frmdocentegrid As New DocentesGrid
        frmdocentegrid.MdiParent = Me
        frmdocentegrid.Show()

    End Sub

    Private Sub Carreras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Carreras.Click

        MenuStrip1.Enabled = False

        Dim frmcarreras As New CarrerasGrid
        frmcarreras.MdiParent = Me
        frmcarreras.Show()

    End Sub

    Private Sub Horarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Horarios.Click

        MenuStrip1.Enabled = False

        Dim frmhorarios As New HorariosGrid
        frmhorarios.MdiParent = Me
        frmhorarios.Show()

    End Sub

    Private Sub Modulos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modulos.Click

        MenuStrip1.Enabled = False

        Dim frmmodulos As New ModulosGrid
        frmmodulos.MdiParent = Me
        frmmodulos.Show()

    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        End
    End Sub

End Class