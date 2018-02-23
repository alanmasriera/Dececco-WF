<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPropiedadesProyecto
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_nombre_proyecto = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_cliente = New System.Windows.Forms.Label()
        Me.grpBox_horas = New System.Windows.Forms.GroupBox()
        Me.dgv_horas_proyecto = New System.Windows.Forms.DataGridView()
        Me.grpBox_Principales = New System.Windows.Forms.GroupBox()
        Me.lbl_descripcion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grpBox_Responsables = New System.Windows.Forms.GroupBox()
        Me.lbl_piloto_proyecto = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_proyect_manager = New System.Windows.Forms.Label()
        Me.grpBox_Fechas = New System.Windows.Forms.GroupBox()
        Me.lbl_fecha_fin_real = New System.Windows.Forms.Label()
        Me.lbl_fecha_prevista_fin = New System.Windows.Forms.Label()
        Me.lbl_fecha_inicio = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.grpBox_Unidades = New System.Windows.Forms.GroupBox()
        Me.dgv_unidades_proyecto = New System.Windows.Forms.DataGridView()
        Me.id_subproyecto_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_subproyecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_Aceptar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtHorasConsumidas = New System.Windows.Forms.TextBox()
        Me.tab_propiedades = New System.Windows.Forms.TabControl()
        Me.tabPage_horas = New System.Windows.Forms.TabPage()
        Me.chk_mostrar_todas_horas = New System.Windows.Forms.CheckBox()
        Me.tabPage_avances = New System.Windows.Forms.TabPage()
        Me.dgv_avance_proyecto = New System.Windows.Forms.DataGridView()
        Me.idSubproyecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Concepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.resp_concepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Preparacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.resp_preparacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Detallado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.resp_detallado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpBox_horas.SuspendLayout()
        CType(Me.dgv_horas_proyecto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBox_Principales.SuspendLayout()
        Me.grpBox_Responsables.SuspendLayout()
        Me.grpBox_Fechas.SuspendLayout()
        Me.grpBox_Unidades.SuspendLayout()
        CType(Me.dgv_unidades_proyecto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_propiedades.SuspendLayout()
        Me.tabPage_horas.SuspendLayout()
        Me.tabPage_avances.SuspendLayout()
        CType(Me.dgv_avance_proyecto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre: "
        '
        'lbl_nombre_proyecto
        '
        Me.lbl_nombre_proyecto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_nombre_proyecto.AutoSize = True
        Me.lbl_nombre_proyecto.Location = New System.Drawing.Point(94, 27)
        Me.lbl_nombre_proyecto.Name = "lbl_nombre_proyecto"
        Me.lbl_nombre_proyecto.Size = New System.Drawing.Size(39, 13)
        Me.lbl_nombre_proyecto.TabIndex = 1
        Me.lbl_nombre_proyecto.Text = "Label2"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cliente: "
        '
        'lbl_cliente
        '
        Me.lbl_cliente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_cliente.AutoSize = True
        Me.lbl_cliente.Location = New System.Drawing.Point(94, 50)
        Me.lbl_cliente.Name = "lbl_cliente"
        Me.lbl_cliente.Size = New System.Drawing.Size(39, 13)
        Me.lbl_cliente.TabIndex = 3
        Me.lbl_cliente.Text = "Label2"
        '
        'grpBox_horas
        '
        Me.grpBox_horas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpBox_horas.Controls.Add(Me.dgv_horas_proyecto)
        Me.grpBox_horas.Location = New System.Drawing.Point(496, 11)
        Me.grpBox_horas.Name = "grpBox_horas"
        Me.grpBox_horas.Size = New System.Drawing.Size(403, 227)
        Me.grpBox_horas.TabIndex = 4
        Me.grpBox_horas.TabStop = False
        Me.grpBox_horas.Text = "Horas"
        '
        'dgv_horas_proyecto
        '
        Me.dgv_horas_proyecto.AllowUserToAddRows = False
        Me.dgv_horas_proyecto.AllowUserToDeleteRows = False
        Me.dgv_horas_proyecto.AllowUserToResizeRows = False
        Me.dgv_horas_proyecto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_horas_proyecto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_horas_proyecto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_horas_proyecto.ColumnHeadersVisible = False
        Me.dgv_horas_proyecto.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_horas_proyecto.Location = New System.Drawing.Point(6, 19)
        Me.dgv_horas_proyecto.Name = "dgv_horas_proyecto"
        Me.dgv_horas_proyecto.ReadOnly = True
        Me.dgv_horas_proyecto.RowHeadersVisible = False
        Me.dgv_horas_proyecto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_horas_proyecto.ShowCellErrors = False
        Me.dgv_horas_proyecto.ShowRowErrors = False
        Me.dgv_horas_proyecto.Size = New System.Drawing.Size(391, 202)
        Me.dgv_horas_proyecto.TabIndex = 0
        '
        'grpBox_Principales
        '
        Me.grpBox_Principales.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.grpBox_Principales.Controls.Add(Me.lbl_descripcion)
        Me.grpBox_Principales.Controls.Add(Me.Label6)
        Me.grpBox_Principales.Controls.Add(Me.lbl_cliente)
        Me.grpBox_Principales.Controls.Add(Me.Label2)
        Me.grpBox_Principales.Controls.Add(Me.lbl_nombre_proyecto)
        Me.grpBox_Principales.Controls.Add(Me.Label1)
        Me.grpBox_Principales.Location = New System.Drawing.Point(10, 12)
        Me.grpBox_Principales.Name = "grpBox_Principales"
        Me.grpBox_Principales.Size = New System.Drawing.Size(449, 219)
        Me.grpBox_Principales.TabIndex = 5
        Me.grpBox_Principales.TabStop = False
        Me.grpBox_Principales.Text = "Datos principales"
        '
        'lbl_descripcion
        '
        Me.lbl_descripcion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_descripcion.Location = New System.Drawing.Point(95, 70)
        Me.lbl_descripcion.Multiline = True
        Me.lbl_descripcion.Name = "lbl_descripcion"
        Me.lbl_descripcion.ReadOnly = True
        Me.lbl_descripcion.Size = New System.Drawing.Size(351, 145)
        Me.lbl_descripcion.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Descripción: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Proyect Manager: "
        '
        'grpBox_Responsables
        '
        Me.grpBox_Responsables.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpBox_Responsables.Controls.Add(Me.lbl_piloto_proyecto)
        Me.grpBox_Responsables.Controls.Add(Me.Label9)
        Me.grpBox_Responsables.Controls.Add(Me.lbl_proyect_manager)
        Me.grpBox_Responsables.Controls.Add(Me.Label4)
        Me.grpBox_Responsables.Location = New System.Drawing.Point(465, 12)
        Me.grpBox_Responsables.Name = "grpBox_Responsables"
        Me.grpBox_Responsables.Size = New System.Drawing.Size(459, 124)
        Me.grpBox_Responsables.TabIndex = 9
        Me.grpBox_Responsables.TabStop = False
        Me.grpBox_Responsables.Text = "Responsables"
        '
        'lbl_piloto_proyecto
        '
        Me.lbl_piloto_proyecto.AutoSize = True
        Me.lbl_piloto_proyecto.Location = New System.Drawing.Point(134, 50)
        Me.lbl_piloto_proyecto.Name = "lbl_piloto_proyecto"
        Me.lbl_piloto_proyecto.Size = New System.Drawing.Size(67, 13)
        Me.lbl_piloto_proyecto.TabIndex = 14
        Me.lbl_piloto_proyecto.Text = "No asignado"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 50)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Piloto del Proyecto: "
        '
        'lbl_proyect_manager
        '
        Me.lbl_proyect_manager.AutoSize = True
        Me.lbl_proyect_manager.Location = New System.Drawing.Point(134, 27)
        Me.lbl_proyect_manager.Name = "lbl_proyect_manager"
        Me.lbl_proyect_manager.Size = New System.Drawing.Size(67, 13)
        Me.lbl_proyect_manager.TabIndex = 10
        Me.lbl_proyect_manager.Text = "No asignado"
        '
        'grpBox_Fechas
        '
        Me.grpBox_Fechas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpBox_Fechas.Controls.Add(Me.lbl_fecha_fin_real)
        Me.grpBox_Fechas.Controls.Add(Me.lbl_fecha_prevista_fin)
        Me.grpBox_Fechas.Controls.Add(Me.lbl_fecha_inicio)
        Me.grpBox_Fechas.Controls.Add(Me.Label10)
        Me.grpBox_Fechas.Controls.Add(Me.Label11)
        Me.grpBox_Fechas.Controls.Add(Me.Label12)
        Me.grpBox_Fechas.Location = New System.Drawing.Point(465, 142)
        Me.grpBox_Fechas.Name = "grpBox_Fechas"
        Me.grpBox_Fechas.Size = New System.Drawing.Size(459, 85)
        Me.grpBox_Fechas.TabIndex = 10
        Me.grpBox_Fechas.TabStop = False
        Me.grpBox_Fechas.Text = "Fechas"
        '
        'lbl_fecha_fin_real
        '
        Me.lbl_fecha_fin_real.AutoSize = True
        Me.lbl_fecha_fin_real.Location = New System.Drawing.Point(191, 66)
        Me.lbl_fecha_fin_real.Name = "lbl_fecha_fin_real"
        Me.lbl_fecha_fin_real.Size = New System.Drawing.Size(39, 13)
        Me.lbl_fecha_fin_real.TabIndex = 12
        Me.lbl_fecha_fin_real.Text = "Label2"
        '
        'lbl_fecha_prevista_fin
        '
        Me.lbl_fecha_prevista_fin.AutoSize = True
        Me.lbl_fecha_prevista_fin.Location = New System.Drawing.Point(191, 43)
        Me.lbl_fecha_prevista_fin.Name = "lbl_fecha_prevista_fin"
        Me.lbl_fecha_prevista_fin.Size = New System.Drawing.Size(39, 13)
        Me.lbl_fecha_prevista_fin.TabIndex = 11
        Me.lbl_fecha_prevista_fin.Text = "Label2"
        '
        'lbl_fecha_inicio
        '
        Me.lbl_fecha_inicio.AutoSize = True
        Me.lbl_fecha_inicio.Location = New System.Drawing.Point(191, 20)
        Me.lbl_fecha_inicio.Name = "lbl_fecha_inicio"
        Me.lbl_fecha_inicio.Size = New System.Drawing.Size(39, 13)
        Me.lbl_fecha_inicio.TabIndex = 10
        Me.lbl_fecha_inicio.Text = "Label2"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(29, 66)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(157, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Fecha real de finalización:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(5, 43)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(181, 13)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Fecha prevista de finalización:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(87, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 13)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Fecha de Inicio:"
        '
        'grpBox_Unidades
        '
        Me.grpBox_Unidades.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpBox_Unidades.Controls.Add(Me.dgv_unidades_proyecto)
        Me.grpBox_Unidades.Location = New System.Drawing.Point(8, 11)
        Me.grpBox_Unidades.Name = "grpBox_Unidades"
        Me.grpBox_Unidades.Size = New System.Drawing.Size(482, 227)
        Me.grpBox_Unidades.TabIndex = 11
        Me.grpBox_Unidades.TabStop = False
        Me.grpBox_Unidades.Text = "Contenido"
        '
        'dgv_unidades_proyecto
        '
        Me.dgv_unidades_proyecto.AllowUserToAddRows = False
        Me.dgv_unidades_proyecto.AllowUserToDeleteRows = False
        Me.dgv_unidades_proyecto.AllowUserToResizeRows = False
        Me.dgv_unidades_proyecto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_unidades_proyecto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_unidades_proyecto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_unidades_proyecto.ColumnHeadersVisible = False
        Me.dgv_unidades_proyecto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_subproyecto_dgv, Me.nombre_subproyecto})
        Me.dgv_unidades_proyecto.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_unidades_proyecto.Location = New System.Drawing.Point(6, 19)
        Me.dgv_unidades_proyecto.Name = "dgv_unidades_proyecto"
        Me.dgv_unidades_proyecto.ReadOnly = True
        Me.dgv_unidades_proyecto.RowHeadersVisible = False
        Me.dgv_unidades_proyecto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_unidades_proyecto.ShowCellErrors = False
        Me.dgv_unidades_proyecto.ShowRowErrors = False
        Me.dgv_unidades_proyecto.Size = New System.Drawing.Size(470, 202)
        Me.dgv_unidades_proyecto.TabIndex = 1
        '
        'id_subproyecto_dgv
        '
        Me.id_subproyecto_dgv.HeaderText = "id_subproyecto_dgv"
        Me.id_subproyecto_dgv.Name = "id_subproyecto_dgv"
        Me.id_subproyecto_dgv.ReadOnly = True
        Me.id_subproyecto_dgv.Visible = False
        '
        'nombre_subproyecto
        '
        Me.nombre_subproyecto.HeaderText = "Nombre"
        Me.nombre_subproyecto.Name = "nombre_subproyecto"
        Me.nombre_subproyecto.ReadOnly = True
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Aceptar.Location = New System.Drawing.Point(849, 542)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(75, 31)
        Me.btn_Aceptar.TabIndex = 12
        Me.btn_Aceptar.Text = "Aceptar"
        Me.btn_Aceptar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(436, 243)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 13)
        Me.Label7.TabIndex = 652
        Me.Label7.Text = "Total de Horas Consumidas: "
        '
        'txtHorasConsumidas
        '
        Me.txtHorasConsumidas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHorasConsumidas.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtHorasConsumidas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHorasConsumidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHorasConsumidas.Location = New System.Drawing.Point(582, 240)
        Me.txtHorasConsumidas.Name = "txtHorasConsumidas"
        Me.txtHorasConsumidas.Size = New System.Drawing.Size(100, 21)
        Me.txtHorasConsumidas.TabIndex = 651
        Me.txtHorasConsumidas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tab_propiedades
        '
        Me.tab_propiedades.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tab_propiedades.Controls.Add(Me.tabPage_horas)
        Me.tab_propiedades.Controls.Add(Me.tabPage_avances)
        Me.tab_propiedades.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_propiedades.Location = New System.Drawing.Point(10, 237)
        Me.tab_propiedades.Name = "tab_propiedades"
        Me.tab_propiedades.SelectedIndex = 0
        Me.tab_propiedades.Size = New System.Drawing.Size(914, 297)
        Me.tab_propiedades.TabIndex = 654
        '
        'tabPage_horas
        '
        Me.tabPage_horas.Controls.Add(Me.chk_mostrar_todas_horas)
        Me.tabPage_horas.Controls.Add(Me.grpBox_Unidades)
        Me.tabPage_horas.Controls.Add(Me.Label7)
        Me.tabPage_horas.Controls.Add(Me.grpBox_horas)
        Me.tabPage_horas.Controls.Add(Me.txtHorasConsumidas)
        Me.tabPage_horas.Location = New System.Drawing.Point(4, 22)
        Me.tabPage_horas.Name = "tabPage_horas"
        Me.tabPage_horas.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage_horas.Size = New System.Drawing.Size(906, 271)
        Me.tabPage_horas.TabIndex = 0
        Me.tabPage_horas.Text = "Horas"
        Me.tabPage_horas.UseVisualStyleBackColor = True
        '
        'chk_mostrar_todas_horas
        '
        Me.chk_mostrar_todas_horas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chk_mostrar_todas_horas.AutoSize = True
        Me.chk_mostrar_todas_horas.Location = New System.Drawing.Point(702, 242)
        Me.chk_mostrar_todas_horas.Name = "chk_mostrar_todas_horas"
        Me.chk_mostrar_todas_horas.Size = New System.Drawing.Size(184, 17)
        Me.chk_mostrar_todas_horas.TabIndex = 653
        Me.chk_mostrar_todas_horas.Text = "Mostrar horas de todo el proyecto"
        Me.chk_mostrar_todas_horas.UseVisualStyleBackColor = True
        '
        'tabPage_avances
        '
        Me.tabPage_avances.Controls.Add(Me.dgv_avance_proyecto)
        Me.tabPage_avances.Location = New System.Drawing.Point(4, 22)
        Me.tabPage_avances.Name = "tabPage_avances"
        Me.tabPage_avances.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage_avances.Size = New System.Drawing.Size(906, 271)
        Me.tabPage_avances.TabIndex = 1
        Me.tabPage_avances.Text = "Avances"
        Me.tabPage_avances.UseVisualStyleBackColor = True
        '
        'dgv_avance_proyecto
        '
        Me.dgv_avance_proyecto.AllowUserToAddRows = False
        Me.dgv_avance_proyecto.AllowUserToDeleteRows = False
        Me.dgv_avance_proyecto.AllowUserToResizeRows = False
        Me.dgv_avance_proyecto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_avance_proyecto.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_avance_proyecto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_avance_proyecto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idSubproyecto, Me.Unidad, Me.Concepto, Me.resp_concepto, Me.Preparacion, Me.resp_preparacion, Me.Detallado, Me.resp_detallado})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_avance_proyecto.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgv_avance_proyecto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_avance_proyecto.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_avance_proyecto.Location = New System.Drawing.Point(3, 3)
        Me.dgv_avance_proyecto.Name = "dgv_avance_proyecto"
        Me.dgv_avance_proyecto.RowHeadersVisible = False
        Me.dgv_avance_proyecto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_avance_proyecto.Size = New System.Drawing.Size(900, 265)
        Me.dgv_avance_proyecto.TabIndex = 1
        '
        'idSubproyecto
        '
        Me.idSubproyecto.HeaderText = "idProyecto"
        Me.idSubproyecto.Name = "idSubproyecto"
        Me.idSubproyecto.Visible = False
        Me.idSubproyecto.Width = 63
        '
        'Unidad
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Unidad.DefaultCellStyle = DataGridViewCellStyle2
        Me.Unidad.HeaderText = "Unidad"
        Me.Unidad.Name = "Unidad"
        Me.Unidad.Width = 66
        '
        'Concepto
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Concepto.DefaultCellStyle = DataGridViewCellStyle3
        Me.Concepto.HeaderText = "Concepto"
        Me.Concepto.Name = "Concepto"
        Me.Concepto.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Concepto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Concepto.Width = 59
        '
        'resp_concepto
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resp_concepto.DefaultCellStyle = DataGridViewCellStyle4
        Me.resp_concepto.HeaderText = "Responsable"
        Me.resp_concepto.Name = "resp_concepto"
        Me.resp_concepto.Width = 94
        '
        'Preparacion
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Preparacion.DefaultCellStyle = DataGridViewCellStyle5
        Me.Preparacion.HeaderText = "Preparación"
        Me.Preparacion.Name = "Preparacion"
        Me.Preparacion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Preparacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Preparacion.Width = 70
        '
        'resp_preparacion
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resp_preparacion.DefaultCellStyle = DataGridViewCellStyle6
        Me.resp_preparacion.HeaderText = "Responsable"
        Me.resp_preparacion.Name = "resp_preparacion"
        Me.resp_preparacion.Width = 94
        '
        'Detallado
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Detallado.DefaultCellStyle = DataGridViewCellStyle7
        Me.Detallado.HeaderText = "Detallado"
        Me.Detallado.Name = "Detallado"
        Me.Detallado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Detallado.Width = 77
        '
        'resp_detallado
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resp_detallado.DefaultCellStyle = DataGridViewCellStyle8
        Me.resp_detallado.HeaderText = "Responsable"
        Me.resp_detallado.Name = "resp_detallado"
        Me.resp_detallado.Width = 94
        '
        'frmPropiedadesProyecto
        '
        Me.AcceptButton = Me.btn_Aceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 577)
        Me.Controls.Add(Me.tab_propiedades)
        Me.Controls.Add(Me.btn_Aceptar)
        Me.Controls.Add(Me.grpBox_Fechas)
        Me.Controls.Add(Me.grpBox_Responsables)
        Me.Controls.Add(Me.grpBox_Principales)
        Me.MinimumSize = New System.Drawing.Size(949, 616)
        Me.Name = "frmPropiedadesProyecto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Propiedades del proyecto"
        Me.grpBox_horas.ResumeLayout(False)
        CType(Me.dgv_horas_proyecto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBox_Principales.ResumeLayout(False)
        Me.grpBox_Principales.PerformLayout()
        Me.grpBox_Responsables.ResumeLayout(False)
        Me.grpBox_Responsables.PerformLayout()
        Me.grpBox_Fechas.ResumeLayout(False)
        Me.grpBox_Fechas.PerformLayout()
        Me.grpBox_Unidades.ResumeLayout(False)
        CType(Me.dgv_unidades_proyecto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_propiedades.ResumeLayout(False)
        Me.tabPage_horas.ResumeLayout(False)
        Me.tabPage_horas.PerformLayout()
        Me.tabPage_avances.ResumeLayout(False)
        CType(Me.dgv_avance_proyecto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre_proyecto As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_cliente As System.Windows.Forms.Label
    Friend WithEvents grpBox_horas As System.Windows.Forms.GroupBox
    Friend WithEvents grpBox_Principales As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_horas_proyecto As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents grpBox_Responsables As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_proyect_manager As System.Windows.Forms.Label
    Friend WithEvents grpBox_Fechas As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_fecha_fin_real As System.Windows.Forms.Label
    Friend WithEvents lbl_fecha_prevista_fin As System.Windows.Forms.Label
    Friend WithEvents lbl_fecha_inicio As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents grpBox_Unidades As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_unidades_proyecto As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtHorasConsumidas As System.Windows.Forms.TextBox
    Friend WithEvents tab_propiedades As System.Windows.Forms.TabControl
    Friend WithEvents tabPage_horas As System.Windows.Forms.TabPage
    Friend WithEvents tabPage_avances As System.Windows.Forms.TabPage
    Friend WithEvents dgv_avance_proyecto As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_piloto_proyecto As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents chk_mostrar_todas_horas As System.Windows.Forms.CheckBox
    Friend WithEvents id_subproyecto_dgv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_subproyecto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idSubproyecto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Unidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Concepto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents resp_concepto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Preparacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents resp_preparacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Detallado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents resp_detallado As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
