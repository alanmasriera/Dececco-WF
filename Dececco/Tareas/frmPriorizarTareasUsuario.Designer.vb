<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPriorizarTareasUsuario
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvListaTareas = New System.Windows.Forms.DataGridView()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbUsuarios = New System.Windows.Forms.ComboBox()
        Me.btn_guardar_subproyecto = New System.Windows.Forms.Button()
        Me.id_detalle_recurso_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_usuario_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_actividad_proyecto_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usuario_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_proyecto_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subproyecto_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.actividad_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_inicio_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_fin_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.forzada_dgv = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.dgvListaTareas,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'dgvListaTareas
        '
        Me.dgvListaTareas.AllowUserToAddRows = false
        Me.dgvListaTareas.AllowUserToDeleteRows = false
        Me.dgvListaTareas.AllowUserToResizeRows = false
        Me.dgvListaTareas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.dgvListaTareas.BackgroundColor = System.Drawing.Color.Silver
        Me.dgvListaTareas.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaTareas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListaTareas.ColumnHeadersHeight = 30
        Me.dgvListaTareas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_detalle_recurso_dgv, Me.id_usuario_dgv, Me.id_actividad_proyecto_dgv, Me.usuario_dgv, Me.nombre_proyecto_dgv, Me.subproyecto_dgv, Me.actividad_dgv, Me.fecha_inicio_dgv, Me.fecha_fin_dgv, Me.forzada_dgv})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Chocolate
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListaTareas.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvListaTareas.GridColor = System.Drawing.Color.MidnightBlue
        Me.dgvListaTareas.Location = New System.Drawing.Point(12, 74)
        Me.dgvListaTareas.Name = "dgvListaTareas"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaTareas.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvListaTareas.RowHeadersVisible = false
        Me.dgvListaTareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListaTareas.ShowCellErrors = false
        Me.dgvListaTareas.ShowRowErrors = false
        Me.dgvListaTareas.Size = New System.Drawing.Size(912, 334)
        Me.dgvListaTareas.StandardTab = true
        Me.dgvListaTareas.TabIndex = 600
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnBuscar.Location = New System.Drawing.Point(340, 35)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(62, 22)
        Me.btnBuscar.TabIndex = 601
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = true
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(21, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 602
        Me.Label1.Text = "Usuario: "
        '
        'cmbUsuarios
        '
        Me.cmbUsuarios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cmbUsuarios.FormattingEnabled = true
        Me.cmbUsuarios.Location = New System.Drawing.Point(76, 35)
        Me.cmbUsuarios.Name = "cmbUsuarios"
        Me.cmbUsuarios.Size = New System.Drawing.Size(258, 21)
        Me.cmbUsuarios.TabIndex = 603
        '
        'btn_guardar_subproyecto
        '
        Me.btn_guardar_subproyecto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btn_guardar_subproyecto.BackgroundImage = Global.Dececco.My.Resources.Resources.save1
        Me.btn_guardar_subproyecto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_guardar_subproyecto.Location = New System.Drawing.Point(861, 418)
        Me.btn_guardar_subproyecto.Name = "btn_guardar_subproyecto"
        Me.btn_guardar_subproyecto.Size = New System.Drawing.Size(62, 45)
        Me.btn_guardar_subproyecto.TabIndex = 769
        Me.btn_guardar_subproyecto.UseVisualStyleBackColor = true
        '
        'id_detalle_recurso_dgv
        '
        Me.id_detalle_recurso_dgv.HeaderText = "id_detalle_recurso_dgv"
        Me.id_detalle_recurso_dgv.Name = "id_detalle_recurso_dgv"
        Me.id_detalle_recurso_dgv.Visible = false
        '
        'id_usuario_dgv
        '
        Me.id_usuario_dgv.HeaderText = "id_usuario_dgv"
        Me.id_usuario_dgv.Name = "id_usuario_dgv"
        Me.id_usuario_dgv.Visible = false
        '
        'id_actividad_proyecto_dgv
        '
        Me.id_actividad_proyecto_dgv.HeaderText = "id_actividad_proyecto_dgv"
        Me.id_actividad_proyecto_dgv.Name = "id_actividad_proyecto_dgv"
        Me.id_actividad_proyecto_dgv.Visible = false
        '
        'usuario_dgv
        '
        Me.usuario_dgv.HeaderText = "Usuario"
        Me.usuario_dgv.Name = "usuario_dgv"
        Me.usuario_dgv.ReadOnly = true
        '
        'nombre_proyecto_dgv
        '
        Me.nombre_proyecto_dgv.HeaderText = "Proyecto"
        Me.nombre_proyecto_dgv.Name = "nombre_proyecto_dgv"
        Me.nombre_proyecto_dgv.ReadOnly = true
        '
        'subproyecto_dgv
        '
        Me.subproyecto_dgv.HeaderText = "Subproyecto"
        Me.subproyecto_dgv.Name = "subproyecto_dgv"
        Me.subproyecto_dgv.ReadOnly = true
        Me.subproyecto_dgv.Width = 250
        '
        'actividad_dgv
        '
        Me.actividad_dgv.HeaderText = "Actividad"
        Me.actividad_dgv.Name = "actividad_dgv"
        Me.actividad_dgv.ReadOnly = true
        '
        'fecha_inicio_dgv
        '
        Me.fecha_inicio_dgv.HeaderText = "Inicio"
        Me.fecha_inicio_dgv.Name = "fecha_inicio_dgv"
        Me.fecha_inicio_dgv.Width = 120
        '
        'fecha_fin_dgv
        '
        Me.fecha_fin_dgv.HeaderText = "Fin"
        Me.fecha_fin_dgv.Name = "fecha_fin_dgv"
        Me.fecha_fin_dgv.ReadOnly = true
        Me.fecha_fin_dgv.Width = 120
        '
        'forzada_dgv
        '
        Me.forzada_dgv.HeaderText = "Forzar"
        Me.forzada_dgv.Name = "forzada_dgv"
        Me.forzada_dgv.Width = 50
        '
        'frmPriorizarTareasUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 471)
        Me.Controls.Add(Me.btn_guardar_subproyecto)
        Me.Controls.Add(Me.cmbUsuarios)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.dgvListaTareas)
        Me.Name = "frmPriorizarTareasUsuario"
        Me.Text = "Priorizar tareas de Usuario"
        CType(Me.dgvListaTareas,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Protected WithEvents dgvListaTareas As DataGridView
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbUsuarios As ComboBox
    Public WithEvents btn_guardar_subproyecto As Button
    Friend WithEvents id_detalle_recurso_dgv As DataGridViewTextBoxColumn
    Friend WithEvents id_usuario_dgv As DataGridViewTextBoxColumn
    Friend WithEvents id_actividad_proyecto_dgv As DataGridViewTextBoxColumn
    Friend WithEvents usuario_dgv As DataGridViewTextBoxColumn
    Friend WithEvents nombre_proyecto_dgv As DataGridViewTextBoxColumn
    Friend WithEvents subproyecto_dgv As DataGridViewTextBoxColumn
    Friend WithEvents actividad_dgv As DataGridViewTextBoxColumn
    Friend WithEvents fecha_inicio_dgv As DataGridViewTextBoxColumn
    Friend WithEvents fecha_fin_dgv As DataGridViewTextBoxColumn
    Friend WithEvents forzada_dgv As DataGridViewCheckBoxColumn
End Class
