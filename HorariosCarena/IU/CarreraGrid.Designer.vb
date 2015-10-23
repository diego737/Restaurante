<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarreraGrid
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.BajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CarreraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CursoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CarreraCollectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AltaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CancelarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.CarreraCollectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.CarreraDataGridViewTextBoxColumn, Me.CursoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CarreraCollectionBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(25, 90)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(344, 226)
        Me.DataGridView1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaToolStripMenuItem, Me.BajaToolStripMenuItem, Me.ModificarToolStripMenuItem, Me.CancelarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(404, 63)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BajaToolStripMenuItem
        '
        Me.BajaToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BajaToolStripMenuItem.Name = "BajaToolStripMenuItem"
        Me.BajaToolStripMenuItem.Size = New System.Drawing.Size(12, 20)
        Me.BajaToolStripMenuItem.Text = "Baja"
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CarreraDataGridViewTextBoxColumn
        '
        Me.CarreraDataGridViewTextBoxColumn.DataPropertyName = "carrera"
        Me.CarreraDataGridViewTextBoxColumn.HeaderText = "carrera"
        Me.CarreraDataGridViewTextBoxColumn.Name = "CarreraDataGridViewTextBoxColumn"
        '
        'CursoDataGridViewTextBoxColumn
        '
        Me.CursoDataGridViewTextBoxColumn.DataPropertyName = "curso"
        Me.CursoDataGridViewTextBoxColumn.HeaderText = "curso"
        Me.CursoDataGridViewTextBoxColumn.Name = "CursoDataGridViewTextBoxColumn"
        '
        'CarreraCollectionBindingSource
        '
        Me.CarreraCollectionBindingSource.DataSource = GetType(WindowsApplication1.CarrerasCollection)
        '
        'AltaToolStripMenuItem
        '
        'Me.AltaToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources._025
        Me.AltaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AltaToolStripMenuItem.Name = "AltaToolStripMenuItem"
        Me.AltaToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.AltaToolStripMenuItem.Text = "Alta"
        '
        'ModificarToolStripMenuItem
        '
        'Me.ModificarToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources._597
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'CancelarToolStripMenuItem
        '
        'Me.CancelarToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources._327
        Me.CancelarToolStripMenuItem.Name = "CancelarToolStripMenuItem"
        Me.CancelarToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.CancelarToolStripMenuItem.Text = "Cancelar"
        '
        'SalirToolStripMenuItem
        '
        'Me.SalirToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources._667
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(52, 59)
        Me.SalirToolStripMenuItem.Text = "Salir"
        Me.SalirToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'CarreraGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 350)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "CarreraGrid"
        Me.Text = "CarreraGrid"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.CarreraCollectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CarreraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CursoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CarreraCollectionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AltaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
