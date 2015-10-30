<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DocentesGrid
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DocentesGrid))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ApellidosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CorreoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DocentesCollectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuDocente = New System.Windows.Forms.ToolStrip
        Me.Agregar = New System.Windows.Forms.ToolStripButton
        Me.Eliminar = New System.Windows.Forms.ToolStripButton
        Me.Modificar = New System.Windows.Forms.ToolStripButton
        Me.Salir = New System.Windows.Forms.ToolStripButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocentesCollectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuDocente.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NombresDataGridViewTextBoxColumn, Me.ApellidosDataGridViewTextBoxColumn, Me.CorreoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DocentesCollectionBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(3, 122)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(578, 251)
        Me.DataGridView1.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombresDataGridViewTextBoxColumn
        '
        Me.NombresDataGridViewTextBoxColumn.DataPropertyName = "Nombres"
        Me.NombresDataGridViewTextBoxColumn.HeaderText = "Nombres"
        Me.NombresDataGridViewTextBoxColumn.Name = "NombresDataGridViewTextBoxColumn"
        Me.NombresDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ApellidosDataGridViewTextBoxColumn
        '
        Me.ApellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.Name = "ApellidosDataGridViewTextBoxColumn"
        Me.ApellidosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CorreoDataGridViewTextBoxColumn
        '
        Me.CorreoDataGridViewTextBoxColumn.DataPropertyName = "Correo"
        Me.CorreoDataGridViewTextBoxColumn.HeaderText = "Correo"
        Me.CorreoDataGridViewTextBoxColumn.Name = "CorreoDataGridViewTextBoxColumn"
        Me.CorreoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DocentesCollectionBindingSource
        '
        Me.DocentesCollectionBindingSource.DataSource = GetType(WindowsApplication1.DocentesCollection)
        '
        'MenuDocente
        '
        Me.MenuDocente.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.MenuDocente.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Agregar, Me.Modificar, Me.Eliminar, Me.Salir})
        Me.MenuDocente.Location = New System.Drawing.Point(0, 54)
        Me.MenuDocente.Name = "MenuDocente"
        Me.MenuDocente.Size = New System.Drawing.Size(578, 55)
        Me.MenuDocente.TabIndex = 1
        Me.MenuDocente.Text = "ToolStrip1"
        '
        'Agregar
        '
        Me.Agregar.Image = Global.WindowsApplication1.My.Resources.Resources.Agregar48
        Me.Agregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Size = New System.Drawing.Size(101, 52)
        Me.Agregar.Text = "Agregar"
        '
        'Eliminar
        '
        Me.Eliminar.Image = Global.WindowsApplication1.My.Resources.Resources.Borrar48b
        Me.Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(102, 52)
        Me.Eliminar.Text = "Eliminar"
        '
        'Modificar
        '
        Me.Modificar.Image = Global.WindowsApplication1.My.Resources.Resources.Editar48
        Me.Modificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Size = New System.Drawing.Size(110, 52)
        Me.Modificar.Text = "Modificar"
        '
        'Salir
        '
        Me.Salir.Image = Global.WindowsApplication1.My.Resources.Resources.Salir48
        Me.Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(81, 52)
        Me.Salir.Text = "Salir"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(524, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 42)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(578, 54)
        Me.Panel1.TabIndex = 3
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.Docente48a
        Me.PictureBox2.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 31)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Docentes"
        '
        'DocentesGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 368)
        Me.Controls.Add(Me.MenuDocente)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "DocentesGrid"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DocentesGrid"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocentesCollectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuDocente.ResumeLayout(False)
        Me.MenuDocente.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombresDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApellidosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CorreoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DocentesCollectionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MenuDocente As System.Windows.Forms.ToolStrip
    Friend WithEvents Agregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Modificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
