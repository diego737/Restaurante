<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.DocentesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AsignaturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DisponibilidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModulosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HorariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CarreraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DocentesToolStripMenuItem, Me.AsignaturasToolStripMenuItem, Me.DisponibilidadToolStripMenuItem, Me.ModulosToolStripMenuItem, Me.HorariosToolStripMenuItem, Me.CarreraToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(53, 20)
        Me.ToolStripMenuItem1.Text = "Tablas"
        '
        'DocentesToolStripMenuItem
        '
        Me.DocentesToolStripMenuItem.Name = "DocentesToolStripMenuItem"
        Me.DocentesToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.DocentesToolStripMenuItem.Text = "Docentes"
        '
        'AsignaturasToolStripMenuItem
        '
        Me.AsignaturasToolStripMenuItem.Name = "AsignaturasToolStripMenuItem"
        Me.AsignaturasToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.AsignaturasToolStripMenuItem.Text = "Asignaturas"
        '
        'DisponibilidadToolStripMenuItem
        '
        Me.DisponibilidadToolStripMenuItem.Name = "DisponibilidadToolStripMenuItem"
        Me.DisponibilidadToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.DisponibilidadToolStripMenuItem.Text = "Disponibilidad"
        '
        'ModulosToolStripMenuItem
        '
        Me.ModulosToolStripMenuItem.Name = "ModulosToolStripMenuItem"
        Me.ModulosToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ModulosToolStripMenuItem.Text = "Modulos"
        '
        'HorariosToolStripMenuItem
        '
        Me.HorariosToolStripMenuItem.Name = "HorariosToolStripMenuItem"
        Me.HorariosToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.HorariosToolStripMenuItem.Text = "Horarios"
        '
        'CarreraToolStripMenuItem
        '
        Me.CarreraToolStripMenuItem.Name = "CarreraToolStripMenuItem"
        Me.CarreraToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.CarreraToolStripMenuItem.Text = "Carrera"
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DocentesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AsignaturasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisponibilidadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModulosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HorariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CarreraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
