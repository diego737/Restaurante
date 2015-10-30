<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HorariosGrid
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.Agregar_ = New System.Windows.Forms.ToolStripButton
        Me.Editar = New System.Windows.Forms.ToolStripButton
        Me.Eliminar_ = New System.Windows.Forms.ToolStripButton
        Me.Salir_ = New System.Windows.Forms.ToolStripButton
        Me.Agregar = New System.Windows.Forms.ToolStripButton
        Me.Modificar = New System.Windows.Forms.ToolStripButton
        Me.Eliminar = New System.Windows.Forms.ToolStripButton
        Me.Actualizar = New System.Windows.Forms.ToolStripButton
        Me.Salir = New System.Windows.Forms.ToolStripButton
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdDiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdCarreraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdAsignaturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdModuloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HorariosCollectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.HorariosCollectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Agregar_, Me.Editar, Me.Eliminar_, Me.Salir_})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 57)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(578, 55)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Agregar_
        '
        Me.Agregar_.Image = Global.WindowsApplication1.My.Resources.Resources.Agregar48
        Me.Agregar_.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Agregar_.Name = "Agregar_"
        Me.Agregar_.Size = New System.Drawing.Size(101, 52)
        Me.Agregar_.Text = "Agregar"
        '
        'Editar
        '
        Me.Editar.Image = Global.WindowsApplication1.My.Resources.Resources.Editar48
        Me.Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Editar.Name = "Editar"
        Me.Editar.Size = New System.Drawing.Size(110, 52)
        Me.Editar.Text = "Modificar"
        '
        'Eliminar_
        '
        Me.Eliminar_.Image = Global.WindowsApplication1.My.Resources.Resources.Borrar48b
        Me.Eliminar_.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Eliminar_.Name = "Eliminar_"
        Me.Eliminar_.Size = New System.Drawing.Size(102, 52)
        Me.Eliminar_.Text = "Eliminar"
        '
        'Salir_
        '
        Me.Salir_.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Salir_.Image = Global.WindowsApplication1.My.Resources.Resources.Salir48
        Me.Salir_.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Salir_.Name = "Salir_"
        Me.Salir_.Size = New System.Drawing.Size(81, 52)
        Me.Salir_.Text = "Salir"
        '
        'Agregar
        '
        Me.Agregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Agregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Size = New System.Drawing.Size(53, 22)
        Me.Agregar.Text = "Agregar"
        '
        'Modificar
        '
        Me.Modificar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Modificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Size = New System.Drawing.Size(62, 22)
        Me.Modificar.Text = "Modificar"
        '
        'Eliminar
        '
        Me.Eliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(54, 22)
        Me.Eliminar.Text = "Eliminar"
        '
        'Actualizar
        '
        Me.Actualizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Actualizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Actualizar.Name = "Actualizar"
        Me.Actualizar.Size = New System.Drawing.Size(63, 22)
        Me.Actualizar.Text = "Actualizar"
        '
        'Salir
        '
        Me.Salir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(33, 22)
        Me.Salir.Text = "Salir"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.IdDiaDataGridViewTextBoxColumn, Me.IdCarreraDataGridViewTextBoxColumn, Me.IdAsignaturaDataGridViewTextBoxColumn, Me.IdModuloDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.HorariosCollectionBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView1.Location = New System.Drawing.Point(0, 112)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(578, 251)
        Me.DataGridView1.TabIndex = 1
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.WindowsApplication1.My.Resources.Resources.Agregar48
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(101, 52)
        Me.ToolStripButton1.Text = "Agregar"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.WindowsApplication1.My.Resources.Resources.Agregar48
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(101, 52)
        Me.ToolStripButton2.Text = "Agregar"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.Horarios48
        Me.PictureBox2.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Horarios"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = Global.WindowsApplication1.My.Resources.Resources.Editar48
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(52, 52)
        Me.ToolStripButton3.Text = "Modificar"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(578, 57)
        Me.Panel1.TabIndex = 5
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdDiaDataGridViewTextBoxColumn
        '
        Me.IdDiaDataGridViewTextBoxColumn.DataPropertyName = "IdDia"
        Me.IdDiaDataGridViewTextBoxColumn.HeaderText = "IdDia"
        Me.IdDiaDataGridViewTextBoxColumn.Name = "IdDiaDataGridViewTextBoxColumn"
        Me.IdDiaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdCarreraDataGridViewTextBoxColumn
        '
        Me.IdCarreraDataGridViewTextBoxColumn.DataPropertyName = "IdCarrera"
        Me.IdCarreraDataGridViewTextBoxColumn.HeaderText = "IdCarrera"
        Me.IdCarreraDataGridViewTextBoxColumn.Name = "IdCarreraDataGridViewTextBoxColumn"
        Me.IdCarreraDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdAsignaturaDataGridViewTextBoxColumn
        '
        Me.IdAsignaturaDataGridViewTextBoxColumn.DataPropertyName = "IdAsignatura"
        Me.IdAsignaturaDataGridViewTextBoxColumn.HeaderText = "IdAsignatura"
        Me.IdAsignaturaDataGridViewTextBoxColumn.Name = "IdAsignaturaDataGridViewTextBoxColumn"
        Me.IdAsignaturaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdModuloDataGridViewTextBoxColumn
        '
        Me.IdModuloDataGridViewTextBoxColumn.DataPropertyName = "IdModulo"
        Me.IdModuloDataGridViewTextBoxColumn.HeaderText = "IdModulo"
        Me.IdModuloDataGridViewTextBoxColumn.Name = "IdModuloDataGridViewTextBoxColumn"
        Me.IdModuloDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HorariosCollectionBindingSource
        '
        Me.HorariosCollectionBindingSource.DataSource = GetType(WindowsApplication1.HorariosCollection)
        '
        'HorariosGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 368)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "HorariosGrid"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "HorariosGrid"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.HorariosCollectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Agregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Modificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDiaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdCarreraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdAsignaturaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdModuloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HorariosCollectionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Actualizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Agregar_ As System.Windows.Forms.ToolStripButton
    Friend WithEvents Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Eliminar_ As System.Windows.Forms.ToolStripButton
    Friend WithEvents Salir_ As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
