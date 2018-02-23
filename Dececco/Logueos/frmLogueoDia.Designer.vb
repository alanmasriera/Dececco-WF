<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogueoDia
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogueoDia))
        Me.dgv_logueo_dia = New System.Windows.Forms.DataGridView()
        Me.id_movimiento_hora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_cuerpo_movimiento_hora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hora_entrada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hora_salida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tiempo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.proyecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subproyecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.actividad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_logueo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ts_horas = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ts_modificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmb_usuarios = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtp_fecha_hasta = New System.Windows.Forms.DateTimePicker()
        Me.dtp_fecha_desde = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_total_horas = New System.Windows.Forms.Label()
        Me.cmb_proyecto = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_cliente = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgv_logueo_dia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ts_horas.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_logueo_dia
        '
        Me.dgv_logueo_dia.AllowUserToAddRows = False
        Me.dgv_logueo_dia.AllowUserToDeleteRows = False
        Me.dgv_logueo_dia.AllowUserToResizeRows = False
        Me.dgv_logueo_dia.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_logueo_dia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_logueo_dia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_movimiento_hora, Me.id_cuerpo_movimiento_hora, Me.nombre_usuario, Me.fecha, Me.hora_entrada, Me.hora_salida, Me.tiempo, Me.cliente, Me.proyecto, Me.subproyecto, Me.actividad, Me.tipo_logueo})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_logueo_dia.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_logueo_dia.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_logueo_dia.Location = New System.Drawing.Point(7, 74)
        Me.dgv_logueo_dia.Name = "dgv_logueo_dia"
        Me.dgv_logueo_dia.RowHeadersVisible = False
        Me.dgv_logueo_dia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_logueo_dia.ShowCellErrors = False
        Me.dgv_logueo_dia.Size = New System.Drawing.Size(1112, 428)
        Me.dgv_logueo_dia.TabIndex = 0
        '
        'id_movimiento_hora
        '
        Me.id_movimiento_hora.HeaderText = "id_movimiento_hora"
        Me.id_movimiento_hora.Name = "id_movimiento_hora"
        Me.id_movimiento_hora.Visible = False
        '
        'id_cuerpo_movimiento_hora
        '
        Me.id_cuerpo_movimiento_hora.HeaderText = "id_cuerpo_movimiento_hora"
        Me.id_cuerpo_movimiento_hora.Name = "id_cuerpo_movimiento_hora"
        Me.id_cuerpo_movimiento_hora.Visible = False
        '
        'nombre_usuario
        '
        Me.nombre_usuario.HeaderText = "Nombre"
        Me.nombre_usuario.Name = "nombre_usuario"
        Me.nombre_usuario.Width = 130
        '
        'fecha
        '
        DataGridViewCellStyle1.Format = "dd/MM/yyyy"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.fecha.DefaultCellStyle = DataGridViewCellStyle1
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.Width = 80
        '
        'hora_entrada
        '
        Me.hora_entrada.HeaderText = "Hora Entrada"
        Me.hora_entrada.Name = "hora_entrada"
        Me.hora_entrada.Width = 70
        '
        'hora_salida
        '
        Me.hora_salida.HeaderText = "Hora Salida"
        Me.hora_salida.Name = "hora_salida"
        Me.hora_salida.Width = 70
        '
        'tiempo
        '
        Me.tiempo.HeaderText = "Tiempo"
        Me.tiempo.Name = "tiempo"
        Me.tiempo.Width = 70
        '
        'cliente
        '
        Me.cliente.HeaderText = "Cliente"
        Me.cliente.Name = "cliente"
        Me.cliente.Width = 200
        '
        'proyecto
        '
        Me.proyecto.HeaderText = "Proyecto"
        Me.proyecto.Name = "proyecto"
        Me.proyecto.Width = 200
        '
        'subproyecto
        '
        Me.subproyecto.HeaderText = "Subproyecto"
        Me.subproyecto.Name = "subproyecto"
        Me.subproyecto.Width = 300
        '
        'actividad
        '
        Me.actividad.HeaderText = "Actividad"
        Me.actividad.Name = "actividad"
        '
        'tipo_logueo
        '
        Me.tipo_logueo.HeaderText = "Tipo"
        Me.tipo_logueo.Name = "tipo_logueo"
        '
        'ts_horas
        '
        Me.ts_horas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_modificar})
        Me.ts_horas.Name = "ts_horas"
        Me.ts_horas.Size = New System.Drawing.Size(126, 26)
        '
        'ts_modificar
        '
        Me.ts_modificar.Name = "ts_modificar"
        Me.ts_modificar.Size = New System.Drawing.Size(125, 22)
        Me.ts_modificar.Text = "Modificar"
        '
        'cmb_usuarios
        '
        Me.cmb_usuarios.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_usuarios.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_usuarios.FormattingEnabled = True
        Me.cmb_usuarios.Location = New System.Drawing.Point(7, 38)
        Me.cmb_usuarios.Name = "cmb_usuarios"
        Me.cmb_usuarios.Size = New System.Drawing.Size(252, 21)
        Me.cmb_usuarios.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(288, 42)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 13)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Hasta: "
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtp_fecha_hasta
        '
        Me.dtp_fecha_hasta.Location = New System.Drawing.Point(332, 39)
        Me.dtp_fecha_hasta.Name = "dtp_fecha_hasta"
        Me.dtp_fecha_hasta.Size = New System.Drawing.Size(297, 20)
        Me.dtp_fecha_hasta.TabIndex = 20
        '
        'dtp_fecha_desde
        '
        Me.dtp_fecha_desde.Location = New System.Drawing.Point(332, 8)
        Me.dtp_fecha_desde.Name = "dtp_fecha_desde"
        Me.dtp_fecha_desde.Size = New System.Drawing.Size(297, 20)
        Me.dtp_fecha_desde.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(288, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Desde: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Usuario: "
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(809, 513)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Total de horas:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_total_horas
        '
        Me.lbl_total_horas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_total_horas.AutoSize = True
        Me.lbl_total_horas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total_horas.Location = New System.Drawing.Point(893, 513)
        Me.lbl_total_horas.Name = "lbl_total_horas"
        Me.lbl_total_horas.Size = New System.Drawing.Size(45, 13)
        Me.lbl_total_horas.TabIndex = 24
        Me.lbl_total_horas.Text = "Label3"
        Me.lbl_total_horas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmb_proyecto
        '
        Me.cmb_proyecto.FormattingEnabled = True
        Me.cmb_proyecto.Location = New System.Drawing.Point(713, 38)
        Me.cmb_proyecto.Name = "cmb_proyecto"
        Me.cmb_proyecto.Size = New System.Drawing.Size(252, 21)
        Me.cmb_proyecto.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(652, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Proyecto: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(652, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Cliente: "
        '
        'cmb_cliente
        '
        Me.cmb_cliente.FormattingEnabled = True
        Me.cmb_cliente.Location = New System.Drawing.Point(713, 11)
        Me.cmb_cliente.Name = "cmb_cliente"
        Me.cmb_cliente.Size = New System.Drawing.Size(252, 21)
        Me.cmb_cliente.TabIndex = 28
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(7, 513)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 26)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Administrar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmLogueoDia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1125, 547)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmb_cliente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmb_proyecto)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl_total_horas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.dtp_fecha_hasta)
        Me.Controls.Add(Me.dtp_fecha_desde)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmb_usuarios)
        Me.Controls.Add(Me.dgv_logueo_dia)
        Me.MinimumSize = New System.Drawing.Size(988, 440)
        Me.Name = "frmLogueoDia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Logueos"
        CType(Me.dgv_logueo_dia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ts_horas.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_logueo_dia As System.Windows.Forms.DataGridView
    Friend WithEvents cmb_usuarios As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha_hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fecha_desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_total_horas As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ts_horas As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ts_modificar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmb_proyecto As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_cliente As System.Windows.Forms.ComboBox
    Friend WithEvents id_movimiento_hora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_cuerpo_movimiento_hora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hora_entrada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hora_salida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tiempo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents proyecto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subproyecto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents actividad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo_logueo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
