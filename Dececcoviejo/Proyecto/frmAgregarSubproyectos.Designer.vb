<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarSubproyectos
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvSubproyectos = New System.Windows.Forms.DataGridView()
        Me.id_hijo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.actividades = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.controles = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.cant_hijos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_hijos = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.personalizar_hijos = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.actividades_modificadas = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dgvControles = New System.Windows.Forms.DataGridView()
        Me.id_actividad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.actividad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.control = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.cmb_tipo_subproyecto = New System.Windows.Forms.ComboBox()
        Me.btn_agregarActividad = New System.Windows.Forms.Button()
        Me.txt_cantidadH = New System.Windows.Forms.NumericUpDown()
        Me.cmb_tipo_hijos = New System.Windows.Forms.ComboBox()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.dgvActividades = New System.Windows.Forms.DataGridView()
        Me.id_tipo_actividad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_actividad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Peso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_fin_actividad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt = New System.Windows.Forms.TextBox()
        Me.btn_agregarSubproyecto = New System.Windows.Forms.Button()
        Me.btn_pegar = New System.Windows.Forms.Button()
        Me.CBActividades = New System.Windows.Forms.ComboBox()
        Me.fila = New System.Windows.Forms.TextBox()
        CType(Me.dgvSubproyectos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvControles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cantidadH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvActividades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvSubproyectos
        '
        Me.dgvSubproyectos.AllowUserToAddRows = False
        Me.dgvSubproyectos.AllowUserToDeleteRows = False
        Me.dgvSubproyectos.AllowUserToResizeRows = False
        Me.dgvSubproyectos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSubproyectos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSubproyectos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.dgvSubproyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSubproyectos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_hijo, Me.nombre, Me.tipo, Me.actividades, Me.controles, Me.cant_hijos, Me.tipo_hijos, Me.personalizar_hijos, Me.actividades_modificadas})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSubproyectos.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSubproyectos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvSubproyectos.Location = New System.Drawing.Point(23, 77)
        Me.dgvSubproyectos.Name = "dgvSubproyectos"
        Me.dgvSubproyectos.RowHeadersVisible = False
        Me.dgvSubproyectos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSubproyectos.Size = New System.Drawing.Size(718, 376)
        Me.dgvSubproyectos.TabIndex = 5
        '
        'id_hijo
        '
        DataGridViewCellStyle1.NullValue = Nothing
        Me.id_hijo.DefaultCellStyle = DataGridViewCellStyle1
        Me.id_hijo.HeaderText = "id_hijo"
        Me.id_hijo.Name = "id_hijo"
        Me.id_hijo.Visible = False
        '
        'nombre
        '
        Me.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.nombre.FillWeight = 85.0!
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.Width = 220
        '
        'tipo
        '
        Me.tipo.HeaderText = "Tipo"
        Me.tipo.Name = "tipo"
        '
        'actividades
        '
        Me.actividades.HeaderText = "Actividades"
        Me.actividades.Name = "actividades"
        Me.actividades.Visible = False
        '
        'controles
        '
        Me.controles.HeaderText = "Controles"
        Me.controles.Name = "controles"
        Me.controles.Visible = False
        '
        'cant_hijos
        '
        Me.cant_hijos.HeaderText = "Cantidad de hijos"
        Me.cant_hijos.Name = "cant_hijos"
        '
        'tipo_hijos
        '
        Me.tipo_hijos.HeaderText = "Tipo de los hijos"
        Me.tipo_hijos.Name = "tipo_hijos"
        '
        'personalizar_hijos
        '
        Me.personalizar_hijos.HeaderText = "Personalizar hijos"
        Me.personalizar_hijos.Name = "personalizar_hijos"
        '
        'actividades_modificadas
        '
        Me.actividades_modificadas.HeaderText = "actividades modificadas"
        Me.actividades_modificadas.Name = "actividades_modificadas"
        Me.actividades_modificadas.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.actividades_modificadas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.actividades_modificadas.Visible = False
        '
        'dgvControles
        '
        Me.dgvControles.AllowUserToAddRows = False
        Me.dgvControles.AllowUserToDeleteRows = False
        Me.dgvControles.AllowUserToResizeRows = False
        Me.dgvControles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvControles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvControles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvControles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_actividad, Me.actividad, Me.control})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvControles.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvControles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvControles.Location = New System.Drawing.Point(428, 459)
        Me.dgvControles.Name = "dgvControles"
        Me.dgvControles.RowHeadersVisible = False
        Me.dgvControles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvControles.Size = New System.Drawing.Size(329, 173)
        Me.dgvControles.TabIndex = 6
        '
        'id_actividad
        '
        Me.id_actividad.HeaderText = "id"
        Me.id_actividad.Name = "id_actividad"
        Me.id_actividad.Visible = False
        '
        'actividad
        '
        Me.actividad.HeaderText = "Actividad"
        Me.actividad.Name = "actividad"
        '
        'control
        '
        Me.control.HeaderText = "Control"
        Me.control.Name = "control"
        '
        'txt_nombre
        '
        Me.txt_nombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_nombre.Location = New System.Drawing.Point(23, 51)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(149, 20)
        Me.txt_nombre.TabIndex = 8
        '
        'cmb_tipo_subproyecto
        '
        Me.cmb_tipo_subproyecto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_tipo_subproyecto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_tipo_subproyecto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_tipo_subproyecto.FormattingEnabled = True
        Me.cmb_tipo_subproyecto.Location = New System.Drawing.Point(248, 51)
        Me.cmb_tipo_subproyecto.Name = "cmb_tipo_subproyecto"
        Me.cmb_tipo_subproyecto.Size = New System.Drawing.Size(133, 21)
        Me.cmb_tipo_subproyecto.TabIndex = 9
        '
        'btn_agregarActividad
        '
        Me.btn_agregarActividad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_agregarActividad.Location = New System.Drawing.Point(226, 647)
        Me.btn_agregarActividad.Name = "btn_agregarActividad"
        Me.btn_agregarActividad.Size = New System.Drawing.Size(221, 23)
        Me.btn_agregarActividad.TabIndex = 10
        Me.btn_agregarActividad.Text = "Agregar"
        Me.btn_agregarActividad.UseVisualStyleBackColor = True
        '
        'txt_cantidadH
        '
        Me.txt_cantidadH.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cantidadH.Location = New System.Drawing.Point(457, 52)
        Me.txt_cantidadH.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.txt_cantidadH.Name = "txt_cantidadH"
        Me.txt_cantidadH.Size = New System.Drawing.Size(208, 22)
        Me.txt_cantidadH.TabIndex = 11
        Me.txt_cantidadH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmb_tipo_hijos
        '
        Me.cmb_tipo_hijos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_tipo_hijos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_tipo_hijos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_tipo_hijos.FormattingEnabled = True
        Me.cmb_tipo_hijos.Location = New System.Drawing.Point(671, 52)
        Me.cmb_tipo_hijos.Name = "cmb_tipo_hijos"
        Me.cmb_tipo_hijos.Size = New System.Drawing.Size(132, 21)
        Me.cmb_tipo_hijos.TabIndex = 12
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_aceptar.Location = New System.Drawing.Point(924, 638)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_aceptar.TabIndex = 13
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'dgvActividades
        '
        Me.dgvActividades.AllowUserToAddRows = False
        Me.dgvActividades.AllowUserToDeleteRows = False
        Me.dgvActividades.AllowUserToResizeRows = False
        Me.dgvActividades.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvActividades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvActividades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_tipo_actividad, Me.nombre_actividad, Me.Peso, Me.fecha_fin_actividad})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvActividades.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvActividades.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvActividades.Location = New System.Drawing.Point(23, 459)
        Me.dgvActividades.Name = "dgvActividades"
        Me.dgvActividades.RowHeadersVisible = False
        Me.dgvActividades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvActividades.Size = New System.Drawing.Size(287, 182)
        Me.dgvActividades.TabIndex = 14
        '
        'id_tipo_actividad
        '
        DataGridViewCellStyle4.NullValue = Nothing
        Me.id_tipo_actividad.DefaultCellStyle = DataGridViewCellStyle4
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
        DataGridViewCellStyle5.Format = "N4"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Peso.DefaultCellStyle = DataGridViewCellStyle5
        Me.Peso.FillWeight = 15.0!
        Me.Peso.HeaderText = "Peso"
        Me.Peso.Name = "Peso"
        Me.Peso.Width = 50
        '
        'fecha_fin_actividad
        '
        Me.fecha_fin_actividad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Format = "d"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.fecha_fin_actividad.DefaultCellStyle = DataGridViewCellStyle6
        Me.fecha_fin_actividad.HeaderText = "Fecha Fin"
        Me.fecha_fin_actividad.Name = "fecha_fin_actividad"
        '
        'txt
        '
        Me.txt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt.Location = New System.Drawing.Point(897, 31)
        Me.txt.Multiline = True
        Me.txt.Name = "txt"
        Me.txt.ReadOnly = True
        Me.txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt.Size = New System.Drawing.Size(462, 601)
        Me.txt.TabIndex = 804
        '
        'btn_agregarSubproyecto
        '
        Me.btn_agregarSubproyecto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_agregarSubproyecto.Location = New System.Drawing.Point(696, 10)
        Me.btn_agregarSubproyecto.Name = "btn_agregarSubproyecto"
        Me.btn_agregarSubproyecto.Size = New System.Drawing.Size(146, 23)
        Me.btn_agregarSubproyecto.TabIndex = 805
        Me.btn_agregarSubproyecto.Text = "Agregar"
        Me.btn_agregarSubproyecto.UseVisualStyleBackColor = True
        '
        'btn_pegar
        '
        Me.btn_pegar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_pegar.Location = New System.Drawing.Point(-47, 22)
        Me.btn_pegar.Name = "btn_pegar"
        Me.btn_pegar.Size = New System.Drawing.Size(219, 23)
        Me.btn_pegar.TabIndex = 806
        Me.btn_pegar.Text = "Pegar"
        Me.btn_pegar.UseVisualStyleBackColor = True
        '
        'CBActividades
        '
        Me.CBActividades.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBActividades.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CBActividades.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBActividades.FormattingEnabled = True
        Me.CBActividades.Location = New System.Drawing.Point(23, 647)
        Me.CBActividades.Name = "CBActividades"
        Me.CBActividades.Size = New System.Drawing.Size(187, 21)
        Me.CBActividades.TabIndex = 807
        '
        'fila
        '
        Me.fila.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fila.BackColor = System.Drawing.Color.Red
        Me.fila.Location = New System.Drawing.Point(710, 10)
        Me.fila.Name = "fila"
        Me.fila.Size = New System.Drawing.Size(0, 20)
        Me.fila.TabIndex = 808
        '
        'frmAgregarSubproyectos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 692)
        Me.Controls.Add(Me.fila)
        Me.Controls.Add(Me.CBActividades)
        Me.Controls.Add(Me.btn_pegar)
        Me.Controls.Add(Me.btn_agregarSubproyecto)
        Me.Controls.Add(Me.txt)
        Me.Controls.Add(Me.dgvActividades)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.cmb_tipo_hijos)
        Me.Controls.Add(Me.txt_cantidadH)
        Me.Controls.Add(Me.btn_agregarActividad)
        Me.Controls.Add(Me.cmb_tipo_subproyecto)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.dgvControles)
        Me.Controls.Add(Me.dgvSubproyectos)
        Me.Name = "frmAgregarSubproyectos"
        Me.Text = "frmAgregarSubproyectos"
        CType(Me.dgvSubproyectos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvControles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cantidadH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvActividades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvSubproyectos As System.Windows.Forms.DataGridView
    Friend WithEvents dgvControles As System.Windows.Forms.DataGridView
    Friend WithEvents id_actividad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents actividad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents control As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents cmb_tipo_subproyecto As System.Windows.Forms.ComboBox
    Friend WithEvents btn_agregarActividad As System.Windows.Forms.Button
    Friend WithEvents txt_cantidadH As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmb_tipo_hijos As System.Windows.Forms.ComboBox
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents dgvActividades As System.Windows.Forms.DataGridView
    Friend WithEvents txt As System.Windows.Forms.TextBox
    Friend WithEvents id_tipo_actividad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_actividad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Peso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_fin_actividad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_agregarSubproyecto As System.Windows.Forms.Button
    Friend WithEvents id_hijo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents actividades As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents controles As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents cant_hijos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo_hijos As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents personalizar_hijos As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents actividades_modificadas As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents btn_pegar As System.Windows.Forms.Button
    Friend WithEvents CBActividades As System.Windows.Forms.ComboBox
    Friend WithEvents fila As System.Windows.Forms.TextBox
End Class
