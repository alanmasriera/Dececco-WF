<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTipoActividad_Usuario
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv_tipo_actividad = New System.Windows.Forms.DataGridView()
        Me.id_tipo_actividad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_actividad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.habilitado_actividad = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dgv_usuarios = New System.Windows.Forms.DataGridView()
        Me.id_usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.habilitado_usuario = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        CType(Me.dgv_tipo_actividad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_usuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_tipo_actividad
        '
        Me.dgv_tipo_actividad.AllowUserToAddRows = False
        Me.dgv_tipo_actividad.AllowUserToDeleteRows = False
        Me.dgv_tipo_actividad.AllowUserToResizeRows = False
        Me.dgv_tipo_actividad.BackgroundColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_tipo_actividad.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_tipo_actividad.ColumnHeadersHeight = 30
        Me.dgv_tipo_actividad.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_tipo_actividad, Me.nombre_actividad, Me.habilitado_actividad})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_tipo_actividad.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_tipo_actividad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_tipo_actividad.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_tipo_actividad.GridColor = System.Drawing.Color.MidnightBlue
        Me.dgv_tipo_actividad.Location = New System.Drawing.Point(0, 0)
        Me.dgv_tipo_actividad.Name = "dgv_tipo_actividad"
        Me.dgv_tipo_actividad.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_tipo_actividad.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_tipo_actividad.RowHeadersVisible = False
        Me.dgv_tipo_actividad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_tipo_actividad.ShowCellErrors = False
        Me.dgv_tipo_actividad.ShowRowErrors = False
        Me.dgv_tipo_actividad.Size = New System.Drawing.Size(431, 537)
        Me.dgv_tipo_actividad.StandardTab = True
        Me.dgv_tipo_actividad.TabIndex = 793
        '
        'id_tipo_actividad
        '
        Me.id_tipo_actividad.HeaderText = "id_tipo_actividad"
        Me.id_tipo_actividad.Name = "id_tipo_actividad"
        Me.id_tipo_actividad.ReadOnly = True
        Me.id_tipo_actividad.Visible = False
        Me.id_tipo_actividad.Width = 198
        '
        'nombre_actividad
        '
        Me.nombre_actividad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nombre_actividad.HeaderText = "Actividad"
        Me.nombre_actividad.Name = "nombre_actividad"
        Me.nombre_actividad.ReadOnly = True
        '
        'habilitado_actividad
        '
        Me.habilitado_actividad.HeaderText = "Habilitado"
        Me.habilitado_actividad.Name = "habilitado_actividad"
        Me.habilitado_actividad.ReadOnly = True
        Me.habilitado_actividad.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.habilitado_actividad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.habilitado_actividad.Visible = False
        Me.habilitado_actividad.Width = 50
        '
        'dgv_usuarios
        '
        Me.dgv_usuarios.AllowUserToAddRows = False
        Me.dgv_usuarios.AllowUserToDeleteRows = False
        Me.dgv_usuarios.AllowUserToResizeRows = False
        Me.dgv_usuarios.BackgroundColor = System.Drawing.Color.Silver
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_usuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_usuarios.ColumnHeadersHeight = 30
        Me.dgv_usuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_usuario, Me.nombre_usuario, Me.habilitado_usuario})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_usuarios.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_usuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_usuarios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_usuarios.GridColor = System.Drawing.Color.MidnightBlue
        Me.dgv_usuarios.Location = New System.Drawing.Point(0, 0)
        Me.dgv_usuarios.Name = "dgv_usuarios"
        Me.dgv_usuarios.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_usuarios.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_usuarios.RowHeadersVisible = False
        Me.dgv_usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_usuarios.ShowCellErrors = False
        Me.dgv_usuarios.ShowRowErrors = False
        Me.dgv_usuarios.Size = New System.Drawing.Size(463, 537)
        Me.dgv_usuarios.StandardTab = True
        Me.dgv_usuarios.TabIndex = 792
        '
        'id_usuario
        '
        Me.id_usuario.HeaderText = "id_usuario"
        Me.id_usuario.Name = "id_usuario"
        Me.id_usuario.ReadOnly = True
        Me.id_usuario.Visible = False
        Me.id_usuario.Width = 198
        '
        'nombre_usuario
        '
        Me.nombre_usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nombre_usuario.HeaderText = "Usuario"
        Me.nombre_usuario.Name = "nombre_usuario"
        Me.nombre_usuario.ReadOnly = True
        '
        'habilitado_usuario
        '
        Me.habilitado_usuario.HeaderText = "Habilitado"
        Me.habilitado_usuario.Name = "habilitado_usuario"
        Me.habilitado_usuario.ReadOnly = True
        Me.habilitado_usuario.Visible = False
        Me.habilitado_usuario.Width = 50
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgv_usuarios)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgv_tipo_actividad)
        Me.SplitContainer1.Size = New System.Drawing.Size(898, 537)
        Me.SplitContainer1.SplitterDistance = 463
        Me.SplitContainer1.TabIndex = 794
        '
        'frmTipoActividad_Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 537)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmTipoActividad_Usuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actividad por usuario"
        CType(Me.dgv_tipo_actividad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_usuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Protected WithEvents dgv_tipo_actividad As System.Windows.Forms.DataGridView
    Protected WithEvents dgv_usuarios As System.Windows.Forms.DataGridView
    Friend WithEvents id_tipo_actividad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_actividad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents habilitado_actividad As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents id_usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents habilitado_usuario As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
End Class
