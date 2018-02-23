<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrioridadProyectos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvSubproyectos = New System.Windows.Forms.DataGridView()
        Me.btn_abajo_proyecto = New System.Windows.Forms.Button()
        Me.btn_arriba_proyecto = New System.Windows.Forms.Button()
        Me.btn_guardar_subproyecto = New System.Windows.Forms.Button()
        Me.id_proyecto_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_subproyecto_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_proyecto_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_subproyecto_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.path_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_inicio_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_fin_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvSubproyectos,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'dgvSubproyectos
        '
        Me.dgvSubproyectos.AllowUserToAddRows = false
        Me.dgvSubproyectos.AllowUserToDeleteRows = false
        Me.dgvSubproyectos.AllowUserToResizeRows = false
        Me.dgvSubproyectos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.dgvSubproyectos.BackgroundColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSubproyectos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSubproyectos.ColumnHeadersHeight = 30
        Me.dgvSubproyectos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_proyecto_dgv, Me.id_subproyecto_dgv, Me.nombre_proyecto_dgv, Me.nombre_subproyecto_dgv, Me.path_dgv, Me.fecha_inicio_dgv, Me.fecha_fin_dgv})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Chocolate
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSubproyectos.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvSubproyectos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvSubproyectos.GridColor = System.Drawing.Color.MidnightBlue
        Me.dgvSubproyectos.Location = New System.Drawing.Point(12, 12)
        Me.dgvSubproyectos.Name = "dgvSubproyectos"
        Me.dgvSubproyectos.ReadOnly = true
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSubproyectos.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvSubproyectos.RowHeadersVisible = false
        Me.dgvSubproyectos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSubproyectos.ShowCellErrors = false
        Me.dgvSubproyectos.ShowRowErrors = false
        Me.dgvSubproyectos.Size = New System.Drawing.Size(664, 470)
        Me.dgvSubproyectos.StandardTab = true
        Me.dgvSubproyectos.TabIndex = 600
        '
        'btn_abajo_proyecto
        '
        Me.btn_abajo_proyecto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btn_abajo_proyecto.BackgroundImage = Global.Dececco.My.Resources.Resources.arrow_down
        Me.btn_abajo_proyecto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_abajo_proyecto.Location = New System.Drawing.Point(682, 111)
        Me.btn_abajo_proyecto.Name = "btn_abajo_proyecto"
        Me.btn_abajo_proyecto.Size = New System.Drawing.Size(26, 62)
        Me.btn_abajo_proyecto.TabIndex = 775
        Me.btn_abajo_proyecto.UseVisualStyleBackColor = true
        '
        'btn_arriba_proyecto
        '
        Me.btn_arriba_proyecto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btn_arriba_proyecto.BackgroundImage = Global.Dececco.My.Resources.Resources.arrow_up
        Me.btn_arriba_proyecto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_arriba_proyecto.Location = New System.Drawing.Point(682, 43)
        Me.btn_arriba_proyecto.Name = "btn_arriba_proyecto"
        Me.btn_arriba_proyecto.Size = New System.Drawing.Size(26, 62)
        Me.btn_arriba_proyecto.TabIndex = 774
        Me.btn_arriba_proyecto.UseVisualStyleBackColor = true
        '
        'btn_guardar_subproyecto
        '
        Me.btn_guardar_subproyecto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btn_guardar_subproyecto.BackgroundImage = Global.Dececco.My.Resources.Resources.save1
        Me.btn_guardar_subproyecto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_guardar_subproyecto.Location = New System.Drawing.Point(682, 429)
        Me.btn_guardar_subproyecto.Name = "btn_guardar_subproyecto"
        Me.btn_guardar_subproyecto.Size = New System.Drawing.Size(76, 53)
        Me.btn_guardar_subproyecto.TabIndex = 776
        Me.btn_guardar_subproyecto.UseVisualStyleBackColor = true
        '
        'id_proyecto_dgv
        '
        Me.id_proyecto_dgv.HeaderText = "id_proyecto_dgv"
        Me.id_proyecto_dgv.Name = "id_proyecto_dgv"
        Me.id_proyecto_dgv.ReadOnly = true
        Me.id_proyecto_dgv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.id_proyecto_dgv.Visible = false
        '
        'id_subproyecto_dgv
        '
        Me.id_subproyecto_dgv.HeaderText = "id_subproyecto_dgv"
        Me.id_subproyecto_dgv.Name = "id_subproyecto_dgv"
        Me.id_subproyecto_dgv.ReadOnly = true
        Me.id_subproyecto_dgv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.id_subproyecto_dgv.Visible = false
        '
        'nombre_proyecto_dgv
        '
        Me.nombre_proyecto_dgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.nombre_proyecto_dgv.HeaderText = "Proyecto"
        Me.nombre_proyecto_dgv.Name = "nombre_proyecto_dgv"
        Me.nombre_proyecto_dgv.ReadOnly = true
        Me.nombre_proyecto_dgv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.nombre_proyecto_dgv.Width = 150
        '
        'nombre_subproyecto_dgv
        '
        Me.nombre_subproyecto_dgv.HeaderText = "Dispositivo"
        Me.nombre_subproyecto_dgv.Name = "nombre_subproyecto_dgv"
        Me.nombre_subproyecto_dgv.ReadOnly = true
        Me.nombre_subproyecto_dgv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.nombre_subproyecto_dgv.Width = 150
        '
        'path_dgv
        '
        Me.path_dgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.path_dgv.HeaderText = "Path"
        Me.path_dgv.Name = "path_dgv"
        Me.path_dgv.ReadOnly = true
        Me.path_dgv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.path_dgv.Width = 300
        '
        'fecha_inicio_dgv
        '
        Me.fecha_inicio_dgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle2.Format = "G"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.fecha_inicio_dgv.DefaultCellStyle = DataGridViewCellStyle2
        Me.fecha_inicio_dgv.HeaderText = "Fecha Inicio"
        Me.fecha_inicio_dgv.Name = "fecha_inicio_dgv"
        Me.fecha_inicio_dgv.ReadOnly = true
        Me.fecha_inicio_dgv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'fecha_fin_dgv
        '
        DataGridViewCellStyle3.Format = "G"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.fecha_fin_dgv.DefaultCellStyle = DataGridViewCellStyle3
        Me.fecha_fin_dgv.HeaderText = "Fecha Fin"
        Me.fecha_fin_dgv.Name = "fecha_fin_dgv"
        Me.fecha_fin_dgv.ReadOnly = true
        Me.fecha_fin_dgv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'frmPrioridadProyectos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 494)
        Me.Controls.Add(Me.btn_guardar_subproyecto)
        Me.Controls.Add(Me.btn_abajo_proyecto)
        Me.Controls.Add(Me.btn_arriba_proyecto)
        Me.Controls.Add(Me.dgvSubproyectos)
        Me.Name = "frmPrioridadProyectos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prioridad de proyectos"
        CType(Me.dgvSubproyectos,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Protected WithEvents dgvSubproyectos As DataGridView
    Friend WithEvents btn_abajo_proyecto As Button
    Friend WithEvents btn_arriba_proyecto As Button
    Public WithEvents btn_guardar_subproyecto As Button
    Friend WithEvents id_proyecto_dgv As DataGridViewTextBoxColumn
    Friend WithEvents id_subproyecto_dgv As DataGridViewTextBoxColumn
    Friend WithEvents nombre_proyecto_dgv As DataGridViewTextBoxColumn
    Friend WithEvents nombre_subproyecto_dgv As DataGridViewTextBoxColumn
    Friend WithEvents path_dgv As DataGridViewTextBoxColumn
    Friend WithEvents fecha_inicio_dgv As DataGridViewTextBoxColumn
    Friend WithEvents fecha_fin_dgv As DataGridViewTextBoxColumn
End Class
