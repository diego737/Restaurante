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
        Me.Tablas = New System.Windows.Forms.ToolStripMenuItem
        Me.Asignaturas = New System.Windows.Forms.ToolStripMenuItem
        Me.Carreras = New System.Windows.Forms.ToolStripMenuItem
        Me.Disponibilidad = New System.Windows.Forms.ToolStripMenuItem
        Me.Docentes = New System.Windows.Forms.ToolStripMenuItem
        Me.Horarios = New System.Windows.Forms.ToolStripMenuItem
        Me.Modulos = New System.Windows.Forms.ToolStripMenuItem
        Me.Procesos = New System.Windows.Forms.ToolStripMenuItem
        Me.Salir = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.AsignaturasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.CarrerasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DisponibilidadToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.DocentesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.HorarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MódulosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProcesosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.DocentesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AsignaturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DisponibilidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModulosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HorariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CarreraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Silver
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tablas, Me.Procesos, Me.Salir})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 50)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(809, 56)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Tablas
        '
        Me.Tablas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Asignaturas, Me.Carreras, Me.Disponibilidad, Me.Docentes, Me.Horarios, Me.Modulos})
        Me.Tablas.Image = Global.WindowsApplication1.My.Resources.Resources.Tablas
        Me.Tablas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Tablas.Name = "Tablas"
        Me.Tablas.Size = New System.Drawing.Size(101, 52)
        Me.Tablas.Text = "Tablas"
        '
        'Asignaturas
        '
        Me.Asignaturas.Image = Global.WindowsApplication1.My.Resources.Resources.Asignatura48
        Me.Asignaturas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Asignaturas.Name = "Asignaturas"
        Me.Asignaturas.Size = New System.Drawing.Size(182, 54)
        Me.Asignaturas.Text = "Asignaturas"
        '
        'Carreras
        '
        Me.Carreras.Image = Global.WindowsApplication1.My.Resources.Resources.Carrera48
        Me.Carreras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Carreras.Name = "Carreras"
        Me.Carreras.Size = New System.Drawing.Size(182, 54)
        Me.Carreras.Text = "Carreras"
        '
        'Disponibilidad
        '
        Me.Disponibilidad.Image = Global.WindowsApplication1.My.Resources.Resources.Disponibilidad48
        Me.Disponibilidad.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Disponibilidad.Name = "Disponibilidad"
        Me.Disponibilidad.Size = New System.Drawing.Size(182, 54)
        Me.Disponibilidad.Text = "Disponibilidad"
        '
        'Docentes
        '
        Me.Docentes.Image = Global.WindowsApplication1.My.Resources.Resources.Docente48a
        Me.Docentes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Docentes.Name = "Docentes"
        Me.Docentes.Size = New System.Drawing.Size(182, 54)
        Me.Docentes.Text = "Docentes"
        '
        'Horarios
        '
        Me.Horarios.Image = Global.WindowsApplication1.My.Resources.Resources.Horarios48
        Me.Horarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Horarios.Name = "Horarios"
        Me.Horarios.Size = New System.Drawing.Size(182, 54)
        Me.Horarios.Text = "Horarios"
        '
        'Modulos
        '
        Me.Modulos.Image = Global.WindowsApplication1.My.Resources.Resources.Modulo48
        Me.Modulos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Modulos.Name = "Modulos"
        Me.Modulos.Size = New System.Drawing.Size(182, 54)
        Me.Modulos.Text = "Módulos"
        '
        'Procesos
        '
        Me.Procesos.Image = Global.WindowsApplication1.My.Resources.Resources.Procesos
        Me.Procesos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Procesos.Name = "Procesos"
        Me.Procesos.Size = New System.Drawing.Size(114, 52)
        Me.Procesos.Text = "Procesos"
        '
        'Salir
        '
        Me.Salir.Image = Global.WindowsApplication1.My.Resources.Resources.Salir48b
        Me.Salir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(89, 52)
        Me.Salir.Text = "Salir"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(101, 52)
        Me.ToolStripMenuItem2.Text = "Tablas"
        '
        'AsignaturasToolStripMenuItem1
        '
        Me.AsignaturasToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AsignaturasToolStripMenuItem1.Name = "AsignaturasToolStripMenuItem1"
        Me.AsignaturasToolStripMenuItem1.Size = New System.Drawing.Size(200, 70)
        Me.AsignaturasToolStripMenuItem1.Text = "Asignaturas"
        '
        'CarrerasToolStripMenuItem
        '
        Me.CarrerasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CarrerasToolStripMenuItem.Name = "CarrerasToolStripMenuItem"
        Me.CarrerasToolStripMenuItem.Size = New System.Drawing.Size(200, 70)
        Me.CarrerasToolStripMenuItem.Text = "Carreras"
        '
        'DisponibilidadToolStripMenuItem1
        '
        Me.DisponibilidadToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DisponibilidadToolStripMenuItem1.Name = "DisponibilidadToolStripMenuItem1"
        Me.DisponibilidadToolStripMenuItem1.Size = New System.Drawing.Size(200, 70)
        Me.DisponibilidadToolStripMenuItem1.Text = "Disponibilidad"
        '
        'DocentesToolStripMenuItem1
        '
        Me.DocentesToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DocentesToolStripMenuItem1.Name = "DocentesToolStripMenuItem1"
        Me.DocentesToolStripMenuItem1.Size = New System.Drawing.Size(200, 70)
        Me.DocentesToolStripMenuItem1.Text = "Docentes"
        '
        'HorarioToolStripMenuItem
        '
        Me.HorarioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.HorarioToolStripMenuItem.Name = "HorarioToolStripMenuItem"
        Me.HorarioToolStripMenuItem.Size = New System.Drawing.Size(200, 70)
        Me.HorarioToolStripMenuItem.Text = "Horario"
        '
        'MódulosToolStripMenuItem
        '
        Me.MódulosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MódulosToolStripMenuItem.Name = "MódulosToolStripMenuItem"
        Me.MódulosToolStripMenuItem.Size = New System.Drawing.Size(200, 70)
        Me.MódulosToolStripMenuItem.Text = "Módulos"
        '
        'ProcesosToolStripMenuItem
        '
        Me.ProcesosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ProcesosToolStripMenuItem.Name = "ProcesosToolStripMenuItem"
        Me.ProcesosToolStripMenuItem.Size = New System.Drawing.Size(114, 52)
        Me.ProcesosToolStripMenuItem.Text = "Procesos"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(89, 52)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(53, 20)
        Me.ToolStripMenuItem1.Text = "Tablas"
        '
        'DocentesToolStripMenuItem
        '
        Me.DocentesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DocentesToolStripMenuItem.Name = "DocentesToolStripMenuItem"
        Me.DocentesToolStripMenuItem.Size = New System.Drawing.Size(232, 102)
        Me.DocentesToolStripMenuItem.Text = "Docentes"
        '
        'AsignaturasToolStripMenuItem
        '
        Me.AsignaturasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AsignaturasToolStripMenuItem.Name = "AsignaturasToolStripMenuItem"
        Me.AsignaturasToolStripMenuItem.Size = New System.Drawing.Size(232, 102)
        Me.AsignaturasToolStripMenuItem.Text = "Asignaturas"
        '
        'DisponibilidadToolStripMenuItem
        '
        Me.DisponibilidadToolStripMenuItem.Name = "DisponibilidadToolStripMenuItem"
        Me.DisponibilidadToolStripMenuItem.Size = New System.Drawing.Size(232, 102)
        Me.DisponibilidadToolStripMenuItem.Text = "Disponibilidad"
        '
        'ModulosToolStripMenuItem
        '
        Me.ModulosToolStripMenuItem.Name = "ModulosToolStripMenuItem"
        Me.ModulosToolStripMenuItem.Size = New System.Drawing.Size(232, 102)
        Me.ModulosToolStripMenuItem.Text = "Modulos"
        '
        'HorariosToolStripMenuItem
        '
        Me.HorariosToolStripMenuItem.Name = "HorariosToolStripMenuItem"
        Me.HorariosToolStripMenuItem.Size = New System.Drawing.Size(232, 102)
        Me.HorariosToolStripMenuItem.Text = "Horarios"
        '
        'CarreraToolStripMenuItem
        '
        Me.CarreraToolStripMenuItem.Name = "CarreraToolStripMenuItem"
        Me.CarreraToolStripMenuItem.Size = New System.Drawing.Size(232, 102)
        Me.CarreraToolStripMenuItem.Text = "Carrera"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(809, 50)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(224, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(356, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Generador horarios de clase"
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(809, 565)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuForm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AsignaturasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CarrerasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisponibilidadToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DocentesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HorarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MódulosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProcesosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tablas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Procesos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Salir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Asignaturas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Carreras As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Disponibilidad As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Docentes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Horarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Modulos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
