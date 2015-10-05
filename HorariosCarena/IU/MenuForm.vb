Public Class MenuForm
    Private Sub DocentesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DocentesToolStripMenuItem.Click
        Dim frmdocentegrid As New DocentesGrid
        frmdocentegrid.MdiParent = Me
        frmdocentegrid.Show()
    End Sub

    Private Sub AsignaturasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsignaturasToolStripMenuItem.Click
        Dim frmasignaturagrid As New AsignaturasGrid
        frmasignaturagrid.MdiParent = Me
        frmasignaturagrid.Show()
    End Sub

    Private Sub DisponibilidadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisponibilidadToolStripMenuItem.Click
        Dim frmdisponibilidad As New DisponibilidadGrid
        frmdisponibilidad.MdiParent = Me
        frmdisponibilidad.Show()
    End Sub

    Private Sub ModulosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModulosToolStripMenuItem.Click
        Dim frmmodulos As New ModulosGrid
        frmmodulos.MdiParent = Me
        frmmodulos.Show()
    End Sub

    Private Sub HorariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HorariosToolStripMenuItem.Click
        'Dim frmhorarios As New HorariosGrid
        'frmhorarios.MdiParent = Me
        'frmhorarios.show()
    End Sub

    Private Sub CarreraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CarreraToolStripMenuItem.Click
        'Dim frmcarreras As New CarrerasGrid
        'frmcarreras.MdiParent = Me
        'frmcarreras.show()
    End Sub
End Class