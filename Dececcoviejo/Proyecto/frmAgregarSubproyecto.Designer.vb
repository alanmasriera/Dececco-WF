<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarSubproyecto
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_tipo_subproyecto = New System.Windows.Forms.ComboBox()
        Me.chk_genera_ot = New System.Windows.Forms.CheckBox()
        Me.txt_cantidad = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chk_forzar_fecha_fin_actividad = New System.Windows.Forms.CheckBox()
        Me.dtp_fecha_fin_actividad = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_suma_pesos_subproyecto = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.dgv_actividades_subproyecto = New System.Windows.Forms.DataGridView()
        Me.id_tipo_actividad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_actividad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Peso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_fin_actividad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_agregar_actividad_subproyecto = New System.Windows.Forms.Button()
        Me.cmb_actividad_subproyecto = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ts_actividad_subproyecto = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ts_borrar_actividad_subproyecto = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmb_control = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgv_controles_subproyecto = New System.Windows.Forms.DataGridView()
        Me.id_tipo_actividad_control_subproyecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_actividad_control_subproyecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_control_subproyecto = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.btn_agregar_control_subproyecto = New System.Windows.Forms.Button()
        Me.cmb_actividad_control_subproyecto = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.txt_cantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_actividades_subproyecto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ts_actividad_subproyecto.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_controles_subproyecto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo:"
        '
        'cmb_tipo_subproyecto
        '
        Me.cmb_tipo_subproyecto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_tipo_subproyecto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_tipo_subproyecto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_tipo_subproyecto.FormattingEnabled = True
        Me.cmb_tipo_subproyecto.Location = New System.Drawing.Point(66, 12)
        Me.cmb_tipo_subproyecto.Name = "cmb_tipo_subproyecto"
        Me.cmb_tipo_subproyecto.Size = New System.Drawing.Size(693, 21)
        Me.cmb_tipo_subproyecto.TabIndex = 1
        '
        'chk_genera_ot
        '
        Me.chk_genera_ot.AutoSize = True
        Me.chk_genera_ot.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_genera_ot.Location = New System.Drawing.Point(158, 85)
        Me.chk_genera_ot.Name = "chk_genera_ot"
        Me.chk_genera_ot.Size = New System.Drawing.Size(96, 17)
        Me.chk_genera_ot.TabIndex = 2
        Me.chk_genera_ot.Text = "Genera O.T."
        Me.chk_genera_ot.UseVisualStyleBackColor = True
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cantidad.Location = New System.Drawing.Point(66, 82)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(76, 22)
        Me.txt_cantidad.TabIndex = 3
        Me.txt_cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_cantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Cantidad:"
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_aceptar.Location = New System.Drawing.Point(684, 454)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_aceptar.TabIndex = 5
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nombre:"
        '
        'txt_nombre
        '
        Me.txt_nombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_nombre.Location = New System.Drawing.Point(66, 47)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(636, 20)
        Me.txt_nombre.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(708, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "+ número"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.chk_forzar_fecha_fin_actividad)
        Me.GroupBox1.Controls.Add(Me.dtp_fecha_fin_actividad)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lbl_suma_pesos_subproyecto)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.dgv_actividades_subproyecto)
        Me.GroupBox1.Controls.Add(Me.btn_agregar_actividad_subproyecto)
        Me.GroupBox1.Controls.Add(Me.cmb_actividad_subproyecto)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 133)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(388, 315)
        Me.GroupBox1.TabIndex = 752
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Actividades"
        '
        'chk_forzar_fecha_fin_actividad
        '
        Me.chk_forzar_fecha_fin_actividad.AutoSize = True
        Me.chk_forzar_fecha_fin_actividad.Location = New System.Drawing.Point(176, 56)
        Me.chk_forzar_fecha_fin_actividad.Name = "chk_forzar_fecha_fin_actividad"
        Me.chk_forzar_fecha_fin_actividad.Size = New System.Drawing.Size(55, 17)
        Me.chk_forzar_fecha_fin_actividad.TabIndex = 772
        Me.chk_forzar_fecha_fin_actividad.Text = "Forzar"
        Me.chk_forzar_fecha_fin_actividad.UseVisualStyleBackColor = True
        '
        'dtp_fecha_fin_actividad
        '
        Me.dtp_fecha_fin_actividad.Enabled = False
        Me.dtp_fecha_fin_actividad.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_fin_actividad.Location = New System.Drawing.Point(71, 54)
        Me.dtp_fecha_fin_actividad.Name = "dtp_fecha_fin_actividad"
        Me.dtp_fecha_fin_actividad.Size = New System.Drawing.Size(99, 20)
        Me.dtp_fecha_fin_actividad.TabIndex = 771
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 770
        Me.Label5.Text = "Fecha Fin:"
        '
        'lbl_suma_pesos_subproyecto
        '
        Me.lbl_suma_pesos_subproyecto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_suma_pesos_subproyecto.AutoSize = True
        Me.lbl_suma_pesos_subproyecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_suma_pesos_subproyecto.Location = New System.Drawing.Point(328, 289)
        Me.lbl_suma_pesos_subproyecto.Name = "lbl_suma_pesos_subproyecto"
        Me.lbl_suma_pesos_subproyecto.Size = New System.Drawing.Size(16, 16)
        Me.lbl_suma_pesos_subproyecto.TabIndex = 769
        Me.lbl_suma_pesos_subproyecto.Text = "0"
        Me.lbl_suma_pesos_subproyecto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label26
        '
        Me.Label26.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(287, 291)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(37, 13)
        Me.Label26.TabIndex = 768
        Me.Label26.Text = "Suma:"
        '
        'dgv_actividades_subproyecto
        '
        Me.dgv_actividades_subproyecto.AllowUserToAddRows = False
        Me.dgv_actividades_subproyecto.AllowUserToDeleteRows = False
        Me.dgv_actividades_subproyecto.AllowUserToResizeRows = False
        Me.dgv_actividades_subproyecto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_actividades_subproyecto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_actividades_subproyecto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_actividades_subproyecto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_tipo_actividad, Me.nombre_actividad, Me.Peso, Me.fecha_fin_actividad})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_actividades_subproyecto.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_actividades_subproyecto.Location = New System.Drawing.Point(6, 85)
        Me.dgv_actividades_subproyecto.Name = "dgv_actividades_subproyecto"
        Me.dgv_actividades_subproyecto.RowHeadersVisible = False
        Me.dgv_actividades_subproyecto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_actividades_subproyecto.Size = New System.Drawing.Size(374, 201)
        Me.dgv_actividades_subproyecto.TabIndex = 4
        '
        'id_tipo_actividad
        '
        DataGridViewCellStyle1.NullValue = Nothing
        Me.id_tipo_actividad.DefaultCellStyle = DataGridViewCellStyle1
        Me.id_tipo_actividad.HeaderText = "id_tipo_actividad"
        Me.id_tipo_actividad.Name = "id_tipo_actividad"
        Me.id_tipo_actividad.Visible = False
        '
        'nombre_actividad
        '
        Me.nombre_actividad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.nombre_actividad.FillWeight = 85.0!
        Me.nombre_actividad.HeaderText = "Nombre"
        Me.nombre_actividad.Name = "nombre_actividad"
        Me.nombre_actividad.Width = 220
        '
        'Peso
        '
        Me.Peso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle2.Format = "N4"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Peso.DefaultCellStyle = DataGridViewCellStyle2
        Me.Peso.FillWeight = 15.0!
        Me.Peso.HeaderText = "Peso"
        Me.Peso.Name = "Peso"
        Me.Peso.Width = 50
        '
        'fecha_fin_actividad
        '
        Me.fecha_fin_actividad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.fecha_fin_actividad.DefaultCellStyle = DataGridViewCellStyle3
        Me.fecha_fin_actividad.HeaderText = "Fecha Fin"
        Me.fecha_fin_actividad.Name = "fecha_fin_actividad"
        '
        'btn_agregar_actividad_subproyecto
        '
        Me.btn_agregar_actividad_subproyecto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_agregar_actividad_subproyecto.Location = New System.Drawing.Point(305, 52)
        Me.btn_agregar_actividad_subproyecto.Name = "btn_agregar_actividad_subproyecto"
        Me.btn_agregar_actividad_subproyecto.Size = New System.Drawing.Size(75, 23)
        Me.btn_agregar_actividad_subproyecto.TabIndex = 3
        Me.btn_agregar_actividad_subproyecto.Text = "Agregar"
        Me.btn_agregar_actividad_subproyecto.UseVisualStyleBackColor = True
        '
        'cmb_actividad_subproyecto
        '
        Me.cmb_actividad_subproyecto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_actividad_subproyecto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_actividad_subproyecto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_actividad_subproyecto.FormattingEnabled = True
        Me.cmb_actividad_subproyecto.Location = New System.Drawing.Point(71, 27)
        Me.cmb_actividad_subproyecto.Name = "cmb_actividad_subproyecto"
        Me.cmb_actividad_subproyecto.Size = New System.Drawing.Size(309, 21)
        Me.cmb_actividad_subproyecto.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Actividad:"
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
        'cmb_control
        '
        Me.cmb_control.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_control.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_control.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_control.FormattingEnabled = True
        Me.cmb_control.Location = New System.Drawing.Point(71, 54)
        Me.cmb_control.Name = "cmb_control"
        Me.cmb_control.Size = New System.Drawing.Size(198, 21)
        Me.cmb_control.TabIndex = 771
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.cmb_control)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.dgv_controles_subproyecto)
        Me.GroupBox2.Controls.Add(Me.btn_agregar_control_subproyecto)
        Me.GroupBox2.Controls.Add(Me.cmb_actividad_control_subproyecto)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(409, 104)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(358, 344)
        Me.GroupBox2.TabIndex = 753
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Controles predeterminados"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 770
        Me.Label7.Text = "Control:"
        '
        'dgv_controles_subproyecto
        '
        Me.dgv_controles_subproyecto.AllowUserToAddRows = False
        Me.dgv_controles_subproyecto.AllowUserToDeleteRows = False
        Me.dgv_controles_subproyecto.AllowUserToResizeRows = False
        Me.dgv_controles_subproyecto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_controles_subproyecto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_controles_subproyecto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_controles_subproyecto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_tipo_actividad_control_subproyecto, Me.nombre_actividad_control_subproyecto, Me.nombre_control_subproyecto})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_controles_subproyecto.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_controles_subproyecto.Location = New System.Drawing.Point(6, 86)
        Me.dgv_controles_subproyecto.Name = "dgv_controles_subproyecto"
        Me.dgv_controles_subproyecto.RowHeadersVisible = False
        Me.dgv_controles_subproyecto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_controles_subproyecto.Size = New System.Drawing.Size(344, 229)
        Me.dgv_controles_subproyecto.TabIndex = 4
        '
        'id_tipo_actividad_control_subproyecto
        '
        DataGridViewCellStyle5.NullValue = Nothing
        Me.id_tipo_actividad_control_subproyecto.DefaultCellStyle = DataGridViewCellStyle5
        Me.id_tipo_actividad_control_subproyecto.HeaderText = "id_tipo_actividad"
        Me.id_tipo_actividad_control_subproyecto.Name = "id_tipo_actividad_control_subproyecto"
        Me.id_tipo_actividad_control_subproyecto.Visible = False
        '
        'nombre_actividad_control_subproyecto
        '
        Me.nombre_actividad_control_subproyecto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.nombre_actividad_control_subproyecto.FillWeight = 85.0!
        Me.nombre_actividad_control_subproyecto.HeaderText = "Nombre"
        Me.nombre_actividad_control_subproyecto.Name = "nombre_actividad_control_subproyecto"
        Me.nombre_actividad_control_subproyecto.Width = 150
        '
        'nombre_control_subproyecto
        '
        Me.nombre_control_subproyecto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.nombre_control_subproyecto.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.nombre_control_subproyecto.HeaderText = "Control"
        Me.nombre_control_subproyecto.Name = "nombre_control_subproyecto"
        Me.nombre_control_subproyecto.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.nombre_control_subproyecto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.nombre_control_subproyecto.Width = 340
        '
        'btn_agregar_control_subproyecto
        '
        Me.btn_agregar_control_subproyecto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_agregar_control_subproyecto.Location = New System.Drawing.Point(275, 52)
        Me.btn_agregar_control_subproyecto.Name = "btn_agregar_control_subproyecto"
        Me.btn_agregar_control_subproyecto.Size = New System.Drawing.Size(75, 23)
        Me.btn_agregar_control_subproyecto.TabIndex = 3
        Me.btn_agregar_control_subproyecto.Text = "Agregar"
        Me.btn_agregar_control_subproyecto.UseVisualStyleBackColor = True
        '
        'cmb_actividad_control_subproyecto
        '
        Me.cmb_actividad_control_subproyecto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_actividad_control_subproyecto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_actividad_control_subproyecto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_actividad_control_subproyecto.FormattingEnabled = True
        Me.cmb_actividad_control_subproyecto.Location = New System.Drawing.Point(71, 27)
        Me.cmb_actividad_control_subproyecto.Name = "cmb_actividad_control_subproyecto"
        Me.cmb_actividad_control_subproyecto.Size = New System.Drawing.Size(279, 21)
        Me.cmb_actividad_control_subproyecto.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Actividad:"
        '
        'frmAgregarSubproyecto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 489)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_cantidad)
        Me.Controls.Add(Me.chk_genera_ot)
        Me.Controls.Add(Me.cmb_tipo_subproyecto)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAgregarSubproyecto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Agregar Subproyecto"
        CType(Me.txt_cantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_actividades_subproyecto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ts_actividad_subproyecto.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv_controles_subproyecto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_tipo_subproyecto As System.Windows.Forms.ComboBox
    Friend WithEvents chk_genera_ot As System.Windows.Forms.CheckBox
    Friend WithEvents txt_cantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_actividades_subproyecto As System.Windows.Forms.DataGridView
    Friend WithEvents btn_agregar_actividad_subproyecto As System.Windows.Forms.Button
    Friend WithEvents cmb_actividad_subproyecto As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbl_suma_pesos_subproyecto As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents ts_actividad_subproyecto As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ts_borrar_actividad_subproyecto As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmb_control As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dgv_controles_subproyecto As System.Windows.Forms.DataGridView
    Friend WithEvents btn_agregar_control_subproyecto As System.Windows.Forms.Button
    Friend WithEvents cmb_actividad_control_subproyecto As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents id_tipo_actividad_control_subproyecto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_actividad_control_subproyecto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_control_subproyecto As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents chk_forzar_fecha_fin_actividad As System.Windows.Forms.CheckBox
    Friend WithEvents dtp_fecha_fin_actividad As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents id_tipo_actividad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_actividad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Peso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_fin_actividad As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
