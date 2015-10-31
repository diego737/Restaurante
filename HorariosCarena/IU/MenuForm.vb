Public Class MenuForm
    Private Sub Asignaturas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Asignaturas.Click

        Dim frmasignaturagrid As New AsignaturasGrid
        frmasignaturagrid.MdiParent = Me
        frmasignaturagrid.Show()

    End Sub

    Private Sub Disponibilidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Disponibilidad.Click

        Dim frmdisponibilidad As New DisponibilidadGrid
        frmdisponibilidad.MdiParent = Me
        frmdisponibilidad.Show()

    End Sub

    Private Sub Docentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Docentes.Click

        Dim frmdocentegrid As New DocentesGrid
        frmdocentegrid.MdiParent = Me
        frmdocentegrid.Show()

    End Sub

    Private Sub Carreras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Carreras.Click

        Dim frmcarreras As New CarrerasGrid
        frmcarreras.MdiParent = Me
        frmcarreras.Show()

    End Sub

    Private Sub Horarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Horarios.Click
        MenuStrip1.Enabled = False
        Dim frmhorarios As New HorariosGrid
        frmhorarios.MdiParent = Me
        frmhorarios.Show()
        MenuStrip1.Enabled = True

    End Sub

    Private Sub Modulos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modulos.Click

        MenuStrip1.Enabled = False
        Dim frmmodulos As New ModulosGrid
        frmmodulos.MdiParent = Me
        frmmodulos.Show()
        MenuStrip1.Enabled = True

    End Sub

End Class