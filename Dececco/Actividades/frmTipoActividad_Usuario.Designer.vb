<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTipoActividad_Usuario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv_tipo_actividad = New System.Windows.Forms.DataGridView()
        Me.dgv_usuarios = New System.Windows.Forms.DataGridView()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.id_tipo_actividad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_actividad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.habilitado_actividad = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.calificacion_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.habilitado_usuario = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.calificacion_usuario_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_tipo_actividad,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.dgv_usuarios,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainer1.Panel1.SuspendLayout
        Me.SplitContainer1.Panel2.SuspendLayout
        Me.SplitContainer1.SuspendLayout
        Me.SuspendLayout
        '
        'dgv_tipo_actividad
        '
        Me.dgv_tipo_actividad.AllowUserToAddRows = false
        Me.dgv_tipo_actividad.AllowUserToDeleteRows = false
        Me.dgv_tipo_actividad.AllowUserToResizeRows = false
        Me.dgv_tipo_actividad.BackgroundColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_tipo_actividad.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_tipo_actividad.ColumnHeadersHeight = 30
        Me.dgv_tipo_actividad.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_tipo_actividad, Me.nombre_actividad, Me.habilitado_actividad, Me.calificacion_dgv})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_tipo_actividad.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_tipo_actividad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_tipo_actividad.GridColor = System.Drawing.Color.MidnightBlue
        Me.dgv_tipo_actividad.Location = New System.Drawing.Point(0, 0)
        Me.dgv_tipo_actividad.Name = "dgv_tipo_actividad"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_tipo_actividad.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_tipo_actividad.RowHeadersVisible = false
        Me.dgv_tipo_actividad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgv_tipo_actividad.ShowCellErrors = false
        Me.dgv_tipo_actividad.ShowRowErrors = false
        Me.dgv_tipo_actividad.Size = New System.Drawing.Size(431, 537)
        Me.dgv_tipo_actividad.StandardTab = true
        Me.dgv_tipo_actividad.TabIndex = 793
        '
        'dgv_usuarios
        '
        Me.dgv_usuarios.AllowUserToAddRows = false
        Me.dgv_usuarios.AllowUserToDeleteRows = false
        Me.dgv_usuarios.AllowUserToResizeRows = false
        Me.dgv_usuarios.BackgroundColor = System.Drawing.Color.Silver
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_usuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_usuarios.ColumnHeadersHeight = 30
        Me.dgv_usuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_usuario, Me.nombre_usuario, Me.habilitado_usuario, Me.calificacion_usuario_dgv})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_usuarios.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgv_usuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_usuarios.GridColor = System.Drawing.Color.MidnightBlue
        Me.dgv_usuarios.Location = New System.Drawing.Point(0, 0)
        Me.dgv_usuarios.Name = "dgv_usuarios"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_usuarios.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgv_usuarios.RowHeadersVisible = false
        Me.dgv_usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgv_usuarios.ShowCellErrors = false
        Me.dgv_usuarios.ShowRowErrors = false
        Me.dgv_usuarios.Size = New System.Drawing.Size(463, 537)
        Me.dgv_usuarios.StandardTab = true
        Me.dgv_usuarios.TabIndex = 792
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
        'id_tipo_actividad
        '
        Me.id_tipo_actividad.HeaderText = "id_tipo_actividad"
        Me.id_tipo_actividad.Name = "id_tipo_actividad"
        Me.id_tipo_actividad.Visible = false
        Me.id_tipo_actividad.Width = 198
        '
        'nombre_actividad
        '
        Me.nombre_actividad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nombre_actividad.FillWeight = 120!
        Me.nombre_actividad.HeaderText = "Actividad"
        Me.nombre_actividad.Name = "nombre_actividad"
        Me.nombre_actividad.ReadOnly = true
        '
        'habilitado_actividad
        '
        Me.habilitado_actividad.FillWeight = 40!
        Me.habilitado_actividad.HeaderText = "Habilitado"
        Me.habilitado_actividad.MinimumWidth = 40
        Me.habilitado_actividad.Name = "habilitado_actividad"
        Me.habilitado_actividad.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.habilitado_actividad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.habilitado_actividad.Visible = false
        '
        'calificacion_dgv
        '
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = "0"
        Me.calificacion_dgv.DefaultCellStyle = DataGridViewCellStyle2
        Me.calificacion_dgv.FillWeight = 40!
        Me.calificacion_dgv.HeaderText = "Calificacion"
        Me.calificacion_dgv.MinimumWidth = 40
        Me.calificacion_dgv.Name = "calificacion_dgv"
        '
        'id_usuario
        '
        Me.id_usuario.HeaderText = "id_usuario"
        Me.id_usuario.Name = "id_usuario"
        Me.id_usuario.Visible = false
        Me.id_usuario.Width = 198
        '
        'nombre_usuario
        '
        Me.nombre_usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nombre_usuario.FillWeight = 120!
        Me.nombre_usuario.HeaderText = "Usuario"
        Me.nombre_usuario.Name = "nombre_usuario"
        '
        'habilitado_usuario
        '
        Me.habilitado_usuario.FillWeight = 40!
        Me.habilitado_usuario.HeaderText = "Habilitado"
        Me.habilitado_usuario.Name = "habilitado_usuario"
        Me.habilitado_usuario.Visible = false
        '
        'calificacion_usuario_dgv
        '
        DataGridViewCellStyle6.Format = "N0"
        DataGridViewCellStyle6.NullValue = "0"
        Me.calificacion_usuario_dgv.DefaultCellStyle = DataGridViewCellStyle6
        Me.calificacion_usuario_dgv.FillWeight = 40!
        Me.calificacion_usuario_dgv.HeaderText = "Calificación"
        Me.calificacion_usuario_dgv.Name = "calificacion_usuario_dgv"
        Me.calificacion_usuario_dgv.Visible = false
        '
        'frmTipoActividad_Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 537)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmTipoActividad_Usuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actividad por usuario"
        CType(Me.dgv_tipo_actividad,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.dgv_usuarios,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.Panel1.ResumeLayout(false)
        Me.SplitContainer1.Panel2.ResumeLayout(false)
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Protected WithEvents dgv_tipo_actividad As System.Windows.Forms.DataGridView
    Protected WithEvents dgv_usuarios As System.Windows.Forms.DataGridView
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents id_tipo_actividad As DataGridViewTextBoxColumn
    Friend WithEvents nombre_actividad As DataGridViewTextBoxColumn
    Friend WithEvents habilitado_actividad As DataGridViewCheckBoxColumn
    Friend WithEvents calificacion_dgv As DataGridViewTextBoxColumn
    Friend WithEvents id_usuario As DataGridViewTextBoxColumn
    Friend WithEvents nombre_usuario As DataGridViewTextBoxColumn
    Friend WithEvents habilitado_usuario As DataGridViewCheckBoxColumn
    Friend WithEvents calificacion_usuario_dgv As DataGridViewTextBoxColumn
End Class
