<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarTipoSubproyecto
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.group_propiedades = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.txt_descripcion_tipo_subproyecto = New System.Windows.Forms.TextBox()
        Me.txt_nombre_tipo_subproyecto = New System.Windows.Forms.TextBox()
        Me.btn_abajo_actividad = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_agregar_actividad = New System.Windows.Forms.Button()
        Me.btn_arriba_actividad = New System.Windows.Forms.Button()
        Me.dgv_tipos_actividad = New System.Windows.Forms.DataGridView()
        Me.id_actividad_tipo_subproyecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_tipo_actividad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ts_actividad_tipo_subproyecto = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ts_borrar_actividad_tipo_subproyecto = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmb_actividades = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_tipos_subproyecto = New System.Windows.Forms.DataGridView()
        Me.id_tipo_subproyecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_tipo_subproyecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ts_tipo_subproyecto = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ts_borrar_tipo_subproyecto = New System.Windows.Forms.ToolStripMenuItem()
        Me.txt_buscar_nombre_tipo_subroyecto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_buscar_tipo_subproyecto = New System.Windows.Forms.Button()
        Me.dgv_horas_subproyecto = New System.Windows.Forms.DataGridView()
        Me.id_hora_tipo_subproyecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_hora_tipo_subproyecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.horas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ts_horas_tipo_subproyecto = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ts_borrar_hora = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_nombre_hora_tipo_subproyecto = New System.Windows.Forms.TextBox()
        Me.txt_num_horas = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_agregar_horas = New System.Windows.Forms.Button()
        Me.group_horas = New System.Windows.Forms.GroupBox()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.group_propiedades.SuspendLayout()
        CType(Me.dgv_tipos_actividad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ts_actividad_tipo_subproyecto.SuspendLayout()
        CType(Me.dgv_tipos_subproyecto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ts_tipo_subproyecto.SuspendLayout()
        CType(Me.dgv_horas_subproyecto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ts_horas_tipo_subproyecto.SuspendLayout()
        CType(Me.txt_num_horas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.group_horas.SuspendLayout()
        Me.SuspendLayout()
        '
        'group_propiedades
        '
        Me.group_propiedades.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.group_propiedades.Controls.Add(Me.Label3)
        Me.group_propiedades.Controls.Add(Me.Button1)
        Me.group_propiedades.Controls.Add(Me.btn_guardar)
        Me.group_propiedades.Controls.Add(Me.txt_descripcion_tipo_subproyecto)
        Me.group_propiedades.Controls.Add(Me.txt_nombre_tipo_subproyecto)
        Me.group_propiedades.Controls.Add(Me.btn_abajo_actividad)
        Me.group_propiedades.Controls.Add(Me.Label2)
        Me.group_propiedades.Controls.Add(Me.btn_agregar_actividad)
        Me.group_propiedades.Controls.Add(Me.btn_arriba_actividad)
        Me.group_propiedades.Controls.Add(Me.dgv_tipos_actividad)
        Me.group_propiedades.Controls.Add(Me.cmb_actividades)
        Me.group_propiedades.Controls.Add(Me.Label1)
        Me.group_propiedades.Enabled = False
        Me.group_propiedades.Location = New System.Drawing.Point(432, 12)
        Me.group_propiedades.Name = "group_propiedades"
        Me.group_propiedades.Size = New System.Drawing.Size(416, 413)
        Me.group_propiedades.TabIndex = 1
        Me.group_propiedades.TabStop = False
        Me.group_propiedades.Text = "Propiedades"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Descripción:"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(308, 162)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = ".Windows.Forms.."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_guardar.BackgroundImage = Global.Dececco.My.Resources.Resources.save
        Me.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_guardar.Location = New System.Drawing.Point(363, 107)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(50, 44)
        Me.btn_guardar.TabIndex = 26
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'txt_descripcion_tipo_subproyecto
        '
        Me.txt_descripcion_tipo_subproyecto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_descripcion_tipo_subproyecto.Location = New System.Drawing.Point(19, 69)
        Me.txt_descripcion_tipo_subproyecto.Multiline = True
        Me.txt_descripcion_tipo_subproyecto.Name = "txt_descripcion_tipo_subproyecto"
        Me.txt_descripcion_tipo_subproyecto.Size = New System.Drawing.Size(338, 82)
        Me.txt_descripcion_tipo_subproyecto.TabIndex = 4
        '
        'txt_nombre_tipo_subproyecto
        '
        Me.txt_nombre_tipo_subproyecto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_nombre_tipo_subproyecto.Location = New System.Drawing.Point(69, 26)
        Me.txt_nombre_tipo_subproyecto.Name = "txt_nombre_tipo_subproyecto"
        Me.txt_nombre_tipo_subproyecto.Size = New System.Drawing.Size(316, 20)
        Me.txt_nombre_tipo_subproyecto.TabIndex = 1
        '
        'btn_abajo_actividad
        '
        Me.btn_abajo_actividad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_abajo_actividad.BackgroundImage = Global.Dececco.My.Resources.Resources.arrow_down
        Me.btn_abajo_actividad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_abajo_actividad.Location = New System.Drawing.Point(374, 272)
        Me.btn_abajo_actividad.Name = "btn_abajo_actividad"
        Me.btn_abajo_actividad.Size = New System.Drawing.Size(36, 55)
        Me.btn_abajo_actividad.TabIndex = 12
        Me.btn_abajo_actividad.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre:"
        '
        'btn_agregar_actividad
        '
        Me.btn_agregar_actividad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_agregar_actividad.Location = New System.Drawing.Point(338, 162)
        Me.btn_agregar_actividad.Name = "btn_agregar_actividad"
        Me.btn_agregar_actividad.Size = New System.Drawing.Size(75, 23)
        Me.btn_agregar_actividad.TabIndex = 9
        Me.btn_agregar_actividad.Text = "Agregar"
        Me.btn_agregar_actividad.UseVisualStyleBackColor = True
        '
        'btn_arriba_actividad
        '
        Me.btn_arriba_actividad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_arriba_actividad.BackgroundImage = Global.Dececco.My.Resources.Resources.arrow_up
        Me.btn_arriba_actividad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_arriba_actividad.Location = New System.Drawing.Point(374, 200)
        Me.btn_arriba_actividad.Name = "btn_arriba_actividad"
        Me.btn_arriba_actividad.Size = New System.Drawing.Size(36, 55)
        Me.btn_arriba_actividad.TabIndex = 11
        Me.btn_arriba_actividad.UseVisualStyleBackColor = True
        '
        'dgv_tipos_actividad
        '
        Me.dgv_tipos_actividad.AllowUserToAddRows = False
        Me.dgv_tipos_actividad.AllowUserToDeleteRows = False
        Me.dgv_tipos_actividad.AllowUserToResizeRows = False
        Me.dgv_tipos_actividad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_tipos_actividad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_tipos_actividad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_tipos_actividad.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_actividad_tipo_subproyecto, Me.id_tipo_actividad, Me.descripcion})
        Me.dgv_tipos_actividad.ContextMenuStrip = Me.ts_actividad_tipo_subproyecto
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_tipos_actividad.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_tipos_actividad.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_tipos_actividad.Location = New System.Drawing.Point(19, 200)
        Me.dgv_tipos_actividad.Name = "dgv_tipos_actividad"
        Me.dgv_tipos_actividad.RowHeadersVisible = False
        Me.dgv_tipos_actividad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_tipos_actividad.Size = New System.Drawing.Size(349, 196)
        Me.dgv_tipos_actividad.TabIndex = 10
        '
        'id_actividad_tipo_subproyecto
        '
        Me.id_actividad_tipo_subproyecto.HeaderText = "id_actividad_tipo_subproyecto"
        Me.id_actividad_tipo_subproyecto.Name = "id_actividad_tipo_subproyecto"
        Me.id_actividad_tipo_subproyecto.Visible = False
        '
        'id_tipo_actividad
        '
        Me.id_tipo_actividad.HeaderText = "id_tipo_actividad"
        Me.id_tipo_actividad.Name = "id_tipo_actividad"
        Me.id_tipo_actividad.Visible = False
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "Nombre"
        Me.descripcion.Name = "descripcion"
        '
        'ts_actividad_tipo_subproyecto
        '
        Me.ts_actividad_tipo_subproyecto.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_borrar_actividad_tipo_subproyecto})
        Me.ts_actividad_tipo_subproyecto.Name = "ts_actividad_tipo_subproyecto"
        Me.ts_actividad_tipo_subproyecto.Size = New System.Drawing.Size(107, 26)
        '
        'ts_borrar_actividad_tipo_subproyecto
        '
        Me.ts_borrar_actividad_tipo_subproyecto.Name = "ts_borrar_actividad_tipo_subproyecto"
        Me.ts_borrar_actividad_tipo_subproyecto.Size = New System.Drawing.Size(106, 22)
        Me.ts_borrar_actividad_tipo_subproyecto.Text = "Borrar"
        '
        'cmb_actividades
        '
        Me.cmb_actividades.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_actividades.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_actividades.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_actividades.FormattingEnabled = True
        Me.cmb_actividades.Location = New System.Drawing.Point(76, 164)
        Me.cmb_actividades.Name = "cmb_actividades"
        Me.cmb_actividades.Size = New System.Drawing.Size(226, 21)
        Me.cmb_actividades.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Actividad:"
        '
        'dgv_tipos_subproyecto
        '
        Me.dgv_tipos_subproyecto.AllowUserToAddRows = False
        Me.dgv_tipos_subproyecto.AllowUserToDeleteRows = False
        Me.dgv_tipos_subproyecto.AllowUserToResizeRows = False
        Me.dgv_tipos_subproyecto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgv_tipos_subproyecto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_tipos_subproyecto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_tipos_subproyecto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_tipo_subproyecto, Me.nombre_tipo_subproyecto})
        Me.dgv_tipos_subproyecto.ContextMenuStrip = Me.ts_tipo_subproyecto
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_tipos_subproyecto.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_tipos_subproyecto.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_tipos_subproyecto.Location = New System.Drawing.Point(12, 64)
        Me.dgv_tipos_subproyecto.Name = "dgv_tipos_subproyecto"
        Me.dgv_tipos_subproyecto.RowHeadersVisible = False
        Me.dgv_tipos_subproyecto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_tipos_subproyecto.Size = New System.Drawing.Size(404, 559)
        Me.dgv_tipos_subproyecto.TabIndex = 4
        '
        'id_tipo_subproyecto
        '
        Me.id_tipo_subproyecto.HeaderText = "id_tipo_subproyecto"
        Me.id_tipo_subproyecto.Name = "id_tipo_subproyecto"
        Me.id_tipo_subproyecto.Visible = False
        '
        'nombre_tipo_subproyecto
        '
        Me.nombre_tipo_subproyecto.HeaderText = "Nombre"
        Me.nombre_tipo_subproyecto.Name = "nombre_tipo_subproyecto"
        '
        'ts_tipo_subproyecto
        '
        Me.ts_tipo_subproyecto.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_borrar_tipo_subproyecto})
        Me.ts_tipo_subproyecto.Name = "ts_tipo_subproyecto"
        Me.ts_tipo_subproyecto.Size = New System.Drawing.Size(107, 26)
        '
        'ts_borrar_tipo_subproyecto
        '
        Me.ts_borrar_tipo_subproyecto.Name = "ts_borrar_tipo_subproyecto"
        Me.ts_borrar_tipo_subproyecto.Size = New System.Drawing.Size(106, 22)
        Me.ts_borrar_tipo_subproyecto.Text = "Borrar"
        '
        'txt_buscar_nombre_tipo_subroyecto
        '
        Me.txt_buscar_nombre_tipo_subroyecto.Location = New System.Drawing.Point(67, 31)
        Me.txt_buscar_nombre_tipo_subroyecto.Name = "txt_buscar_nombre_tipo_subroyecto"
        Me.txt_buscar_nombre_tipo_subroyecto.Size = New System.Drawing.Size(268, 20)
        Me.txt_buscar_nombre_tipo_subroyecto.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Nombre:"
        '
        'btn_buscar_tipo_subproyecto
        '
        Me.btn_buscar_tipo_subproyecto.Location = New System.Drawing.Point(341, 28)
        Me.btn_buscar_tipo_subproyecto.Name = "btn_buscar_tipo_subproyecto"
        Me.btn_buscar_tipo_subproyecto.Size = New System.Drawing.Size(75, 24)
        Me.btn_buscar_tipo_subproyecto.TabIndex = 7
        Me.btn_buscar_tipo_subproyecto.Text = "Buscar"
        Me.btn_buscar_tipo_subproyecto.UseVisualStyleBackColor = True
        '
        'dgv_horas_subproyecto
        '
        Me.dgv_horas_subproyecto.AllowUserToAddRows = False
        Me.dgv_horas_subproyecto.AllowUserToDeleteRows = False
        Me.dgv_horas_subproyecto.AllowUserToResizeRows = False
        Me.dgv_horas_subproyecto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_horas_subproyecto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_horas_subproyecto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_horas_subproyecto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_hora_tipo_subproyecto, Me.nombre_hora_tipo_subproyecto, Me.horas})
        Me.dgv_horas_subproyecto.ContextMenuStrip = Me.ts_horas_tipo_subproyecto
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_horas_subproyecto.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_horas_subproyecto.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_horas_subproyecto.Location = New System.Drawing.Point(10, 89)
        Me.dgv_horas_subproyecto.Name = "dgv_horas_subproyecto"
        Me.dgv_horas_subproyecto.RowHeadersVisible = False
        Me.dgv_horas_subproyecto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_horas_subproyecto.Size = New System.Drawing.Size(389, 166)
        Me.dgv_horas_subproyecto.TabIndex = 18
        '
        'id_hora_tipo_subproyecto
        '
        Me.id_hora_tipo_subproyecto.HeaderText = "id_hora_tipo_subproyecto"
        Me.id_hora_tipo_subproyecto.Name = "id_hora_tipo_subproyecto"
        Me.id_hora_tipo_subproyecto.Visible = False
        '
        'nombre_hora_tipo_subproyecto
        '
        Me.nombre_hora_tipo_subproyecto.HeaderText = "Nombre"
        Me.nombre_hora_tipo_subproyecto.Name = "nombre_hora_tipo_subproyecto"
        '
        'horas
        '
        Me.horas.HeaderText = "Horas"
        Me.horas.Name = "horas"
        '
        'ts_horas_tipo_subproyecto
        '
        Me.ts_horas_tipo_subproyecto.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_borrar_hora})
        Me.ts_horas_tipo_subproyecto.Name = "ts_horas_tipo_subproyecto"
        Me.ts_horas_tipo_subproyecto.Size = New System.Drawing.Size(107, 26)
        '
        'ts_borrar_hora
        '
        Me.ts_borrar_hora.Name = "ts_borrar_hora"
        Me.ts_borrar_hora.Size = New System.Drawing.Size(106, 22)
        Me.ts_borrar_hora.Text = "Borrar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Nombre:"
        '
        'txt_nombre_hora_tipo_subproyecto
        '
        Me.txt_nombre_hora_tipo_subproyecto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_nombre_hora_tipo_subproyecto.Location = New System.Drawing.Point(75, 24)
        Me.txt_nombre_hora_tipo_subproyecto.Name = "txt_nombre_hora_tipo_subproyecto"
        Me.txt_nombre_hora_tipo_subproyecto.Size = New System.Drawing.Size(329, 20)
        Me.txt_nombre_hora_tipo_subproyecto.TabIndex = 19
        '
        'txt_num_horas
        '
        Me.txt_num_horas.Location = New System.Drawing.Point(75, 50)
        Me.txt_num_horas.Name = "txt_num_horas"
        Me.txt_num_horas.Size = New System.Drawing.Size(62, 20)
        Me.txt_num_horas.TabIndex = 20
        Me.txt_num_horas.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Horas:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(143, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "hs."
        '
        'btn_agregar_horas
        '
        Me.btn_agregar_horas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_agregar_horas.Location = New System.Drawing.Point(329, 50)
        Me.btn_agregar_horas.Name = "btn_agregar_horas"
        Me.btn_agregar_horas.Size = New System.Drawing.Size(75, 23)
        Me.btn_agregar_horas.TabIndex = 23
        Me.btn_agregar_horas.Text = "Agregar"
        Me.btn_agregar_horas.UseVisualStyleBackColor = True
        '
        'group_horas
        '
        Me.group_horas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.group_horas.Controls.Add(Me.btn_agregar_horas)
        Me.group_horas.Controls.Add(Me.Label7)
        Me.group_horas.Controls.Add(Me.Label6)
        Me.group_horas.Controls.Add(Me.txt_num_horas)
        Me.group_horas.Controls.Add(Me.txt_nombre_hora_tipo_subproyecto)
        Me.group_horas.Controls.Add(Me.dgv_horas_subproyecto)
        Me.group_horas.Controls.Add(Me.Label5)
        Me.group_horas.Enabled = False
        Me.group_horas.Location = New System.Drawing.Point(432, 431)
        Me.group_horas.Name = "group_horas"
        Me.group_horas.Size = New System.Drawing.Size(413, 257)
        Me.group_horas.TabIndex = 24
        Me.group_horas.TabStop = False
        Me.group_horas.Text = "Horas"
        '
        'btn_modificar
        '
        Me.btn_modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_modificar.BackgroundImage = Global.Dececco.My.Resources.Resources.editar
        Me.btn_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_modificar.Location = New System.Drawing.Point(12, 629)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(62, 57)
        Me.btn_modificar.TabIndex = 27
        Me.btn_modificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_nuevo.BackgroundImage = Global.Dececco.My.Resources._new
        Me.btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_nuevo.Location = New System.Drawing.Point(341, 629)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(75, 57)
        Me.btn_nuevo.TabIndex = 25
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'frmAgregarTipoSubproyecto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 700)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.group_horas)
        Me.Controls.Add(Me.btn_buscar_tipo_subproyecto)
        Me.Controls.Add(Me.txt_buscar_nombre_tipo_subroyecto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgv_tipos_subproyecto)
        Me.Controls.Add(Me.group_propiedades)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(873, 739)
        Me.Name = "frmAgregarTipoSubproyecto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrar tipos de Subproyecto"
        Me.group_propiedades.ResumeLayout(False)
        Me.group_propiedades.PerformLayout()
        CType(Me.dgv_tipos_actividad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ts_actividad_tipo_subproyecto.ResumeLayout(False)
        CType(Me.dgv_tipos_subproyecto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ts_tipo_subproyecto.ResumeLayout(False)
        CType(Me.dgv_horas_subproyecto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ts_horas_tipo_subproyecto.ResumeLayout(False)
        CType(Me.txt_num_horas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.group_horas.ResumeLayout(False)
        Me.group_horas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents group_propiedades As System.Windows.Forms.GroupBox
    Friend WithEvents txt_nombre_tipo_subproyecto As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_descripcion_tipo_subproyecto As System.Windows.Forms.TextBox
    Friend WithEvents btn_abajo_actividad As System.Windows.Forms.Button
    Friend WithEvents btn_agregar_actividad As System.Windows.Forms.Button
    Friend WithEvents btn_arriba_actividad As System.Windows.Forms.Button
    Friend WithEvents dgv_tipos_actividad As System.Windows.Forms.DataGridView
    Friend WithEvents cmb_actividades As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgv_tipos_subproyecto As System.Windows.Forms.DataGridView
    Friend WithEvents id_tipo_subproyecto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_tipo_subproyecto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_buscar_nombre_tipo_subroyecto As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_buscar_tipo_subproyecto As System.Windows.Forms.Button
    Friend WithEvents dgv_horas_subproyecto As System.Windows.Forms.DataGridView
    Friend WithEvents ts_horas_tipo_subproyecto As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ts_borrar_hora As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre_hora_tipo_subproyecto As System.Windows.Forms.TextBox
    Friend WithEvents txt_num_horas As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_agregar_horas As System.Windows.Forms.Button
    Friend WithEvents group_horas As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents ts_tipo_subproyecto As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ts_borrar_tipo_subproyecto As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_actividad_tipo_subproyecto As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ts_borrar_actividad_tipo_subproyecto As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents id_actividad_tipo_subproyecto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_tipo_actividad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_hora_tipo_subproyecto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_hora_tipo_subproyecto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents horas As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
