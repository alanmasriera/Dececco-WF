<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class agregarSubproyectoWizard
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
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_cantidad = New System.Windows.Forms.NumericUpDown()
        Me.chk_genera_ot = New System.Windows.Forms.CheckBox()
        Me.cmb_tipo_subproyecto = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_horas_disponibles = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgv_subproyectos = New System.Windows.Forms.DataGridView()
        Me.id_subproyecto_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_subproyecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_hora_tipo_subproyecto = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Horas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnBorrarControlActividad = New System.Windows.Forms.Button()
        Me.cmb_control = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgv_controles_subproyecto = New System.Windows.Forms.DataGridView()
        Me.id_tipo_actividad_control_subproyecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_actividad_control_subproyecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_control_subproyecto = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.btn_agregar_control_subproyecto = New System.Windows.Forms.Button()
        Me.cmb_actividad_control_subproyecto = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_siguiente = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_anterior = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chk_forzar_fecha_fin_actividad = New System.Windows.Forms.CheckBox()
        Me.dtp_fecha_fin_actividad = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_suma_pesos_subproyecto = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.dgv_actividades_subproyecto = New System.Windows.Forms.DataGridView()
        Me.id_tipo_actividad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_actividad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Peso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_fin_actividad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_agregar_actividad_subproyecto = New System.Windows.Forms.Button()
        Me.cmb_actividad_subproyecto = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ts_actividad_subproyecto = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ts_borrar_actividad_subproyecto = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PanelRow0 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout
        CType(Me.txt_cantidad,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel2.SuspendLayout
        CType(Me.dgv_subproyectos,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel4.SuspendLayout
        Me.GroupBox2.SuspendLayout
        CType(Me.dgv_controles_subproyecto,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel3.SuspendLayout
        Me.GroupBox1.SuspendLayout
        CType(Me.dgv_actividades_subproyecto,System.ComponentModel.ISupportInitialize).BeginInit
        Me.ts_actividad_subproyecto.SuspendLayout
        Me.TableLayoutPanel1.SuspendLayout
        Me.Panel5.SuspendLayout
        Me.PanelRow0.SuspendLayout
        Me.SuspendLayout
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txt_nombre)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txt_cantidad)
        Me.Panel1.Controls.Add(Me.chk_genera_ot)
        Me.Panel1.Controls.Add(Me.cmb_tipo_subproyecto)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(801, 528)
        Me.Panel1.TabIndex = 0
        '
        'txt_nombre
        '
        Me.txt_nombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txt_nombre.Location = New System.Drawing.Point(71, 55)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(603, 20)
        Me.txt_nombre.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(17, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(56, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Cantidad:"
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txt_cantidad.Location = New System.Drawing.Point(114, 94)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(62, 22)
        Me.txt_cantidad.TabIndex = 12
        Me.txt_cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_cantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'chk_genera_ot
        '
        Me.chk_genera_ot.AutoSize = true
        Me.chk_genera_ot.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chk_genera_ot.Location = New System.Drawing.Point(206, 99)
        Me.chk_genera_ot.Name = "chk_genera_ot"
        Me.chk_genera_ot.Size = New System.Drawing.Size(96, 17)
        Me.chk_genera_ot.TabIndex = 11
        Me.chk_genera_ot.Text = "Genera O.T."
        Me.chk_genera_ot.UseVisualStyleBackColor = true
        '
        'cmb_tipo_subproyecto
        '
        Me.cmb_tipo_subproyecto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cmb_tipo_subproyecto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_tipo_subproyecto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_tipo_subproyecto.FormattingEnabled = true
        Me.cmb_tipo_subproyecto.Location = New System.Drawing.Point(71, 20)
        Me.cmb_tipo_subproyecto.Name = "cmb_tipo_subproyecto"
        Me.cmb_tipo_subproyecto.Size = New System.Drawing.Size(603, 21)
        Me.cmb_tipo_subproyecto.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(34, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Tipo:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lbl_horas_disponibles)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.dgv_subproyectos)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(801, 528)
        Me.Panel2.TabIndex = 4
        '
        'lbl_horas_disponibles
        '
        Me.lbl_horas_disponibles.AutoSize = true
        Me.lbl_horas_disponibles.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_horas_disponibles.Location = New System.Drawing.Point(155, 18)
        Me.lbl_horas_disponibles.Name = "lbl_horas_disponibles"
        Me.lbl_horas_disponibles.Size = New System.Drawing.Size(55, 16)
        Me.lbl_horas_disponibles.TabIndex = 7
        Me.lbl_horas_disponibles.Text = "Label6"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(16, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Total de horas disponibles:"
        '
        'dgv_subproyectos
        '
        Me.dgv_subproyectos.AllowUserToAddRows = false
        Me.dgv_subproyectos.AllowUserToDeleteRows = false
        Me.dgv_subproyectos.AllowUserToResizeRows = false
        Me.dgv_subproyectos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.dgv_subproyectos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader
        Me.dgv_subproyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_subproyectos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_subproyecto_dgv, Me.nombre_subproyecto, Me.id_hora_tipo_subproyecto, Me.Horas})
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_subproyectos.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgv_subproyectos.Location = New System.Drawing.Point(11, 49)
        Me.dgv_subproyectos.Name = "dgv_subproyectos"
        Me.dgv_subproyectos.RowHeadersVisible = false
        Me.dgv_subproyectos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgv_subproyectos.Size = New System.Drawing.Size(787, 473)
        Me.dgv_subproyectos.TabIndex = 5
        '
        'id_subproyecto_dgv
        '
        DataGridViewCellStyle10.NullValue = Nothing
        Me.id_subproyecto_dgv.DefaultCellStyle = DataGridViewCellStyle10
        Me.id_subproyecto_dgv.HeaderText = "id_subproyecto_dgv"
        Me.id_subproyecto_dgv.Name = "id_subproyecto_dgv"
        Me.id_subproyecto_dgv.Visible = false
        Me.id_subproyecto_dgv.Width = 5
        '
        'nombre_subproyecto
        '
        Me.nombre_subproyecto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nombre_subproyecto.FillWeight = 40!
        Me.nombre_subproyecto.HeaderText = "Nombre"
        Me.nombre_subproyecto.Name = "nombre_subproyecto"
        '
        'id_hora_tipo_subproyecto
        '
        Me.id_hora_tipo_subproyecto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.id_hora_tipo_subproyecto.FillWeight = 40!
        Me.id_hora_tipo_subproyecto.HeaderText = "Tipo"
        Me.id_hora_tipo_subproyecto.Name = "id_hora_tipo_subproyecto"
        '
        'Horas
        '
        Me.Horas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle11.Format = "N4"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.Horas.DefaultCellStyle = DataGridViewCellStyle11
        Me.Horas.FillWeight = 20!
        Me.Horas.HeaderText = "Horas"
        Me.Horas.Name = "Horas"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.GroupBox2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(801, 528)
        Me.Panel4.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.btnBorrarControlActividad)
        Me.GroupBox2.Controls.Add(Me.cmb_control)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.dgv_controles_subproyecto)
        Me.GroupBox2.Controls.Add(Me.btn_agregar_control_subproyecto)
        Me.GroupBox2.Controls.Add(Me.cmb_actividad_control_subproyecto)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(19, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(759, 504)
        Me.GroupBox2.TabIndex = 754
        Me.GroupBox2.TabStop = false
        Me.GroupBox2.Text = "Controles predeterminados"
        '
        'btnBorrarControlActividad
        '
        Me.btnBorrarControlActividad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnBorrarControlActividad.BackgroundImage = Global.Dececco.My.Resources.Resources.delete
        Me.btnBorrarControlActividad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBorrarControlActividad.Location = New System.Drawing.Point(682, 437)
        Me.btnBorrarControlActividad.Name = "btnBorrarControlActividad"
        Me.btnBorrarControlActividad.Size = New System.Drawing.Size(60, 57)
        Me.btnBorrarControlActividad.TabIndex = 772
        Me.btnBorrarControlActividad.UseVisualStyleBackColor = true
        '
        'cmb_control
        '
        Me.cmb_control.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cmb_control.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_control.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_control.FormattingEnabled = true
        Me.cmb_control.Location = New System.Drawing.Point(71, 54)
        Me.cmb_control.Name = "cmb_control"
        Me.cmb_control.Size = New System.Drawing.Size(599, 21)
        Me.cmb_control.TabIndex = 771
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Location = New System.Drawing.Point(22, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 770
        Me.Label8.Text = "Control:"
        '
        'dgv_controles_subproyecto
        '
        Me.dgv_controles_subproyecto.AllowUserToAddRows = false
        Me.dgv_controles_subproyecto.AllowUserToDeleteRows = false
        Me.dgv_controles_subproyecto.AllowUserToResizeRows = false
        Me.dgv_controles_subproyecto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.dgv_controles_subproyecto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_controles_subproyecto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_controles_subproyecto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_tipo_actividad_control_subproyecto, Me.nombre_actividad_control_subproyecto, Me.nombre_control_subproyecto})
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_controles_subproyecto.DefaultCellStyle = DataGridViewCellStyle14
        Me.dgv_controles_subproyecto.Location = New System.Drawing.Point(6, 86)
        Me.dgv_controles_subproyecto.Name = "dgv_controles_subproyecto"
        Me.dgv_controles_subproyecto.RowHeadersVisible = false
        Me.dgv_controles_subproyecto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_controles_subproyecto.Size = New System.Drawing.Size(664, 408)
        Me.dgv_controles_subproyecto.TabIndex = 4
        '
        'id_tipo_actividad_control_subproyecto
        '
        DataGridViewCellStyle13.NullValue = Nothing
        Me.id_tipo_actividad_control_subproyecto.DefaultCellStyle = DataGridViewCellStyle13
        Me.id_tipo_actividad_control_subproyecto.HeaderText = "id_tipo_actividad"
        Me.id_tipo_actividad_control_subproyecto.Name = "id_tipo_actividad_control_subproyecto"
        Me.id_tipo_actividad_control_subproyecto.Visible = false
        '
        'nombre_actividad_control_subproyecto
        '
        Me.nombre_actividad_control_subproyecto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nombre_actividad_control_subproyecto.FillWeight = 30!
        Me.nombre_actividad_control_subproyecto.HeaderText = "Nombre"
        Me.nombre_actividad_control_subproyecto.Name = "nombre_actividad_control_subproyecto"
        '
        'nombre_control_subproyecto
        '
        Me.nombre_control_subproyecto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nombre_control_subproyecto.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.nombre_control_subproyecto.FillWeight = 70!
        Me.nombre_control_subproyecto.HeaderText = "Control"
        Me.nombre_control_subproyecto.Name = "nombre_control_subproyecto"
        Me.nombre_control_subproyecto.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.nombre_control_subproyecto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'btn_agregar_control_subproyecto
        '
        Me.btn_agregar_control_subproyecto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btn_agregar_control_subproyecto.Location = New System.Drawing.Point(676, 52)
        Me.btn_agregar_control_subproyecto.Name = "btn_agregar_control_subproyecto"
        Me.btn_agregar_control_subproyecto.Size = New System.Drawing.Size(75, 23)
        Me.btn_agregar_control_subproyecto.TabIndex = 3
        Me.btn_agregar_control_subproyecto.Text = "Agregar"
        Me.btn_agregar_control_subproyecto.UseVisualStyleBackColor = true
        '
        'cmb_actividad_control_subproyecto
        '
        Me.cmb_actividad_control_subproyecto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cmb_actividad_control_subproyecto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_actividad_control_subproyecto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_actividad_control_subproyecto.FormattingEnabled = true
        Me.cmb_actividad_control_subproyecto.Location = New System.Drawing.Point(71, 27)
        Me.cmb_actividad_control_subproyecto.Name = "cmb_actividad_control_subproyecto"
        Me.cmb_actividad_control_subproyecto.Size = New System.Drawing.Size(680, 21)
        Me.cmb_actividad_control_subproyecto.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.Location = New System.Drawing.Point(11, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Actividad:"
        '
        'btn_siguiente
        '
        Me.btn_siguiente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btn_siguiente.Location = New System.Drawing.Point(711, 18)
        Me.btn_siguiente.Name = "btn_siguiente"
        Me.btn_siguiente.Size = New System.Drawing.Size(75, 23)
        Me.btn_siguiente.TabIndex = 1
        Me.btn_siguiente.Text = "Siguiente"
        Me.btn_siguiente.UseVisualStyleBackColor = true
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.btn_cancelar.Location = New System.Drawing.Point(9, 16)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 2
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = true
        '
        'btn_anterior
        '
        Me.btn_anterior.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btn_anterior.Location = New System.Drawing.Point(614, 18)
        Me.btn_anterior.Name = "btn_anterior"
        Me.btn_anterior.Size = New System.Drawing.Size(75, 23)
        Me.btn_anterior.TabIndex = 3
        Me.btn_anterior.Text = "Anterior"
        Me.btn_anterior.UseVisualStyleBackColor = true
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(801, 528)
        Me.Panel3.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chk_forzar_fecha_fin_actividad)
        Me.GroupBox1.Controls.Add(Me.dtp_fecha_fin_actividad)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lbl_suma_pesos_subproyecto)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.dgv_actividades_subproyecto)
        Me.GroupBox1.Controls.Add(Me.btn_agregar_actividad_subproyecto)
        Me.GroupBox1.Controls.Add(Me.cmb_actividad_subproyecto)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(801, 528)
        Me.GroupBox1.TabIndex = 753
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Actividades"
        '
        'chk_forzar_fecha_fin_actividad
        '
        Me.chk_forzar_fecha_fin_actividad.AutoSize = true
        Me.chk_forzar_fecha_fin_actividad.Location = New System.Drawing.Point(176, 56)
        Me.chk_forzar_fecha_fin_actividad.Name = "chk_forzar_fecha_fin_actividad"
        Me.chk_forzar_fecha_fin_actividad.Size = New System.Drawing.Size(55, 17)
        Me.chk_forzar_fecha_fin_actividad.TabIndex = 772
        Me.chk_forzar_fecha_fin_actividad.Text = "Forzar"
        Me.chk_forzar_fecha_fin_actividad.UseVisualStyleBackColor = true
        '
        'dtp_fecha_fin_actividad
        '
        Me.dtp_fecha_fin_actividad.Enabled = false
        Me.dtp_fecha_fin_actividad.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_fin_actividad.Location = New System.Drawing.Point(71, 54)
        Me.dtp_fecha_fin_actividad.Name = "dtp_fecha_fin_actividad"
        Me.dtp_fecha_fin_actividad.Size = New System.Drawing.Size(99, 20)
        Me.dtp_fecha_fin_actividad.TabIndex = 771
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Location = New System.Drawing.Point(8, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 770
        Me.Label6.Text = "Fecha Fin:"
        '
        'lbl_suma_pesos_subproyecto
        '
        Me.lbl_suma_pesos_subproyecto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lbl_suma_pesos_subproyecto.AutoSize = true
        Me.lbl_suma_pesos_subproyecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbl_suma_pesos_subproyecto.Location = New System.Drawing.Point(739, 506)
        Me.lbl_suma_pesos_subproyecto.Name = "lbl_suma_pesos_subproyecto"
        Me.lbl_suma_pesos_subproyecto.Size = New System.Drawing.Size(16, 16)
        Me.lbl_suma_pesos_subproyecto.TabIndex = 769
        Me.lbl_suma_pesos_subproyecto.Text = "0"
        Me.lbl_suma_pesos_subproyecto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label26
        '
        Me.Label26.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label26.AutoSize = true
        Me.Label26.Location = New System.Drawing.Point(698, 508)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(37, 13)
        Me.Label26.TabIndex = 768
        Me.Label26.Text = "Suma:"
        '
        'dgv_actividades_subproyecto
        '
        Me.dgv_actividades_subproyecto.AllowUserToAddRows = false
        Me.dgv_actividades_subproyecto.AllowUserToDeleteRows = false
        Me.dgv_actividades_subproyecto.AllowUserToResizeRows = false
        Me.dgv_actividades_subproyecto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.dgv_actividades_subproyecto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_actividades_subproyecto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_actividades_subproyecto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_tipo_actividad, Me.nombre_actividad, Me.Peso, Me.fecha_fin_actividad})
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_actividades_subproyecto.DefaultCellStyle = DataGridViewCellStyle18
        Me.dgv_actividades_subproyecto.Location = New System.Drawing.Point(6, 85)
        Me.dgv_actividades_subproyecto.Name = "dgv_actividades_subproyecto"
        Me.dgv_actividades_subproyecto.RowHeadersVisible = false
        Me.dgv_actividades_subproyecto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_actividades_subproyecto.Size = New System.Drawing.Size(787, 414)
        Me.dgv_actividades_subproyecto.TabIndex = 4
        '
        'id_tipo_actividad
        '
        DataGridViewCellStyle15.NullValue = Nothing
        Me.id_tipo_actividad.DefaultCellStyle = DataGridViewCellStyle15
        Me.id_tipo_actividad.HeaderText = "id_tipo_actividad"
        Me.id_tipo_actividad.Name = "id_tipo_actividad"
        Me.id_tipo_actividad.Visible = false
        '
        'nombre_actividad
        '
        Me.nombre_actividad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.nombre_actividad.FillWeight = 85!
        Me.nombre_actividad.HeaderText = "Nombre"
        Me.nombre_actividad.Name = "nombre_actividad"
        Me.nombre_actividad.Width = 220
        '
        'Peso
        '
        Me.Peso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle16.Format = "N4"
        DataGridViewCellStyle16.NullValue = Nothing
        Me.Peso.DefaultCellStyle = DataGridViewCellStyle16
        Me.Peso.FillWeight = 15!
        Me.Peso.HeaderText = "Peso"
        Me.Peso.Name = "Peso"
        Me.Peso.Width = 50
        '
        'fecha_fin_actividad
        '
        Me.fecha_fin_actividad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle17.Format = "d"
        DataGridViewCellStyle17.NullValue = Nothing
        Me.fecha_fin_actividad.DefaultCellStyle = DataGridViewCellStyle17
        Me.fecha_fin_actividad.HeaderText = "Fecha Fin"
        Me.fecha_fin_actividad.Name = "fecha_fin_actividad"
        '
        'btn_agregar_actividad_subproyecto
        '
        Me.btn_agregar_actividad_subproyecto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btn_agregar_actividad_subproyecto.Location = New System.Drawing.Point(718, 52)
        Me.btn_agregar_actividad_subproyecto.Name = "btn_agregar_actividad_subproyecto"
        Me.btn_agregar_actividad_subproyecto.Size = New System.Drawing.Size(75, 23)
        Me.btn_agregar_actividad_subproyecto.TabIndex = 3
        Me.btn_agregar_actividad_subproyecto.Text = "Agregar"
        Me.btn_agregar_actividad_subproyecto.UseVisualStyleBackColor = true
        '
        'cmb_actividad_subproyecto
        '
        Me.cmb_actividad_subproyecto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cmb_actividad_subproyecto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_actividad_subproyecto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_actividad_subproyecto.FormattingEnabled = true
        Me.cmb_actividad_subproyecto.Location = New System.Drawing.Point(71, 27)
        Me.cmb_actividad_subproyecto.Name = "cmb_actividad_subproyecto"
        Me.cmb_actividad_subproyecto.Size = New System.Drawing.Size(722, 21)
        Me.cmb_actividad_subproyecto.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Location = New System.Drawing.Point(11, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Actividad:"
        '
        'ts_actividad_subproyecto
        '
        Me.ts_actividad_subproyecto.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_borrar_actividad_subproyecto})
        Me.ts_actividad_subproyecto.Name = "ts_actividad_subproyecto"
        Me.ts_actividad_subproyecto.Size = New System.Drawing.Size(107, 26)
        '
        'ts_borrar_actividad_subproyecto
        '
        Me.ts_borrar_actividad_subproyecto.Name = "ts_borrar_actividad_subproyecto"
        Me.ts_borrar_actividad_subproyecto.Size = New System.Drawing.Size(106, 22)
        Me.ts_borrar_actividad_subproyecto.Text = "Borrar"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel5, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PanelRow0, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.22765!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.77236!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(807, 599)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btn_cancelar)
        Me.Panel5.Controls.Add(Me.btn_anterior)
        Me.Panel5.Controls.Add(Me.btn_siguiente)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(3, 537)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(801, 59)
        Me.Panel5.TabIndex = 0
        '
        'PanelRow0
        '
        Me.PanelRow0.Controls.Add(Me.Panel4)
        Me.PanelRow0.Controls.Add(Me.Panel2)
        Me.PanelRow0.Controls.Add(Me.Panel3)
        Me.PanelRow0.Controls.Add(Me.Panel1)
        Me.PanelRow0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelRow0.Location = New System.Drawing.Point(3, 3)
        Me.PanelRow0.Name = "PanelRow0"
        Me.PanelRow0.Size = New System.Drawing.Size(801, 528)
        Me.PanelRow0.TabIndex = 1
        '
        'agregarSubproyectoWizard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 599)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "agregarSubproyectoWizard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Subproyecto"
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        CType(Me.txt_cantidad,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel2.ResumeLayout(false)
        Me.Panel2.PerformLayout
        CType(Me.dgv_subproyectos,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel4.ResumeLayout(false)
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox2.PerformLayout
        CType(Me.dgv_controles_subproyecto,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel3.ResumeLayout(false)
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        CType(Me.dgv_actividades_subproyecto,System.ComponentModel.ISupportInitialize).EndInit
        Me.ts_actividad_subproyecto.ResumeLayout(false)
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.Panel5.ResumeLayout(false)
        Me.PanelRow0.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_siguiente As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_anterior As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_cantidad As NumericUpDown
    Friend WithEvents chk_genera_ot As CheckBox
    Friend WithEvents cmb_tipo_subproyecto As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv_subproyectos As DataGridView
    Friend WithEvents lbl_horas_disponibles As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chk_forzar_fecha_fin_actividad As CheckBox
    Friend WithEvents dtp_fecha_fin_actividad As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_suma_pesos_subproyecto As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents dgv_actividades_subproyecto As DataGridView
    Friend WithEvents btn_agregar_actividad_subproyecto As Button
    Friend WithEvents cmb_actividad_subproyecto As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmb_control As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dgv_controles_subproyecto As DataGridView
    Friend WithEvents btn_agregar_control_subproyecto As Button
    Friend WithEvents cmb_actividad_control_subproyecto As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ts_actividad_subproyecto As ContextMenuStrip
    Friend WithEvents ts_borrar_actividad_subproyecto As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PanelRow0 As Panel
    Friend WithEvents id_tipo_actividad_control_subproyecto As DataGridViewTextBoxColumn
    Friend WithEvents nombre_actividad_control_subproyecto As DataGridViewTextBoxColumn
    Friend WithEvents nombre_control_subproyecto As DataGridViewComboBoxColumn
    Friend WithEvents id_subproyecto_dgv As DataGridViewTextBoxColumn
    Friend WithEvents nombre_subproyecto As DataGridViewTextBoxColumn
    Friend WithEvents id_hora_tipo_subproyecto As DataGridViewComboBoxColumn
    Friend WithEvents Horas As DataGridViewTextBoxColumn
    Friend WithEvents id_tipo_actividad As DataGridViewTextBoxColumn
    Friend WithEvents nombre_actividad As DataGridViewTextBoxColumn
    Friend WithEvents Peso As DataGridViewTextBoxColumn
    Friend WithEvents fecha_fin_actividad As DataGridViewTextBoxColumn
    Friend WithEvents btnBorrarControlActividad As Button
End Class
