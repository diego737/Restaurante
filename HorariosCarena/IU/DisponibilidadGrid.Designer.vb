<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DisponibilidadGrid
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DisponibilidadGrid))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.agregar = New System.Windows.Forms.ToolStripButton
        Me.modificar = New System.Windows.Forms.ToolStripButton
        Me.eliminar = New System.Windows.Forms.ToolStripButton
        Me.salir = New System.Windows.Forms.ToolStripButton
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(507, 262)
        Me.DataGridView1.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.agregar, Me.modificar, Me.eliminar, Me.salir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(507, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'agregar
        '
        Me.agregar.Image = CType(resources.GetObject("agregar.Image"), System.Drawing.Image)
        Me.agregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.agregar.Name = "agregar"
        Me.agregar.Size = New System.Drawing.Size(67, 22)
        Me.agregar.Text = "agregar"
        '
        'modificar
        '
        Me.modificar.Image = CType(resources.GetObject("modificar.Image"), System.Drawing.Image)
        Me.modificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.modificar.Name = "modificar"
        Me.modificar.Size = New System.Drawing.Size(78, 22)
        Me.modificar.Text = "modificar"
        '
        'eliminar
        '
        Me.eliminar.Image = CType(resources.GetObject("eliminar.Image"), System.Drawing.Image)
        Me.eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(70, 22)
        Me.eliminar.Text = "eliminar"
        '
        'salir
        '
        Me.salir.Image = CType(resources.GetObject("salir.Image"), System.Drawing.Image)
        Me.salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.salir.Name = "salir"
        Me.salir.Size = New System.Drawing.Size(48, 22)
        Me.salir.Text = "salir"
        '
        'DisponibilidadGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 262)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "DisponibilidadGrid"
        Me.Text = "DisponibilidadGrid"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents agregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents modificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents salir As System.Windows.Forms.ToolStripButton
End Class
