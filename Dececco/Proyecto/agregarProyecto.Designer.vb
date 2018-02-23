<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AgregarProyecto
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox17 = New System.Windows.Forms.GroupBox()
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_horas_proyecto = New System.Windows.Forms.NumericUpDown()
        Me.etiquetafecha_fin_prevista = New System.Windows.Forms.Label()
        Me.txt_descripcion_proyecto = New System.Windows.Forms.TextBox()
        Me.etiquetadescripcion = New System.Windows.Forms.Label()
        Me.etiquetanombre_proyecto = New System.Windows.Forms.Label()
        Me.dtp_fecha_fin_estimada_proyecto = New System.Windows.Forms.DateTimePicker()
        Me.etiquetafecha_inicio = New System.Windows.Forms.Label()
        Me.dtp_fecha_inicio_estimada_proyecto = New System.Windows.Forms.DateTimePicker()
        Me.txt_nombre_proyecto = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox18 = New System.Windows.Forms.GroupBox()
        Me.dgv_miembros_proyecto = New System.Windows.Forms.DataGridView()
        Me.id_usuario_proyecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_usuario_proyecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chk_seleccionado_usuario_proyecto = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btn_guardar_proyecto = New System.Windows.Forms.Button()
        Me.GroupBox20 = New System.Windows.Forms.GroupBox()
        Me.cmb_controlador_2 = New System.Windows.Forms.ComboBox()
        Me.cmb_piloto_proyecto = New System.Windows.Forms.ComboBox()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.cmb_controlador_1 = New System.Windows.Forms.ComboBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.cmb_pm_proyecto = New System.Windows.Forms.ComboBox()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.cmbCalendario = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox17.SuspendLayout
        CType(Me.txt_horas_proyecto,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox18.SuspendLayout
        CType(Me.dgv_miembros_proyecto,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox20.SuspendLayout
        Me.SuspendLayout
        '
        'GroupBox17
        '
        Me.GroupBox17.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.GroupBox17.Controls.Add(Me.cmbCliente)
        Me.GroupBox17.Controls.Add(Me.Label1)
        Me.GroupBox17.Controls.Add(Me.txt_horas_proyecto)
        Me.GroupBox17.Controls.Add(Me.etiquetafecha_fin_prevista)
        Me.GroupBox17.Controls.Add(Me.txt_descripcion_proyecto)
        Me.GroupBox17.Controls.Add(Me.etiquetadescripcion)
        Me.GroupBox17.Controls.Add(Me.etiquetanombre_proyecto)
        Me.GroupBox17.Controls.Add(Me.dtp_fecha_fin_estimada_proyecto)
        Me.GroupBox17.Controls.Add(Me.etiquetafecha_inicio)
        Me.GroupBox17.Controls.Add(Me.dtp_fecha_inicio_estimada_proyecto)
        Me.GroupBox17.Controls.Add(Me.txt_nombre_proyecto)
        Me.GroupBox17.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(443, 231)
        Me.GroupBox17.TabIndex = 0
        Me.GroupBox17.TabStop = false
        Me.GroupBox17.Text = "Propiedades del Proyecto"
        '
        'cmbCliente
        '
        Me.cmbCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cmbCliente.FormattingEnabled = true
        Me.cmbCliente.Location = New System.Drawing.Point(6, 24)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(431, 21)
        Me.cmbCliente.TabIndex = 767
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(-10, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 21)
        Me.Label1.TabIndex = 766
        Me.Label1.Text = "Horas:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Visible = false
        '
        'txt_horas_proyecto
        '
        Me.txt_horas_proyecto.Enabled = false
        Me.txt_horas_proyecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txt_horas_proyecto.ForeColor = System.Drawing.Color.Blue
        Me.txt_horas_proyecto.Location = New System.Drawing.Point(85, 193)
        Me.txt_horas_proyecto.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.txt_horas_proyecto.Name = "txt_horas_proyecto"
        Me.txt_horas_proyecto.Size = New System.Drawing.Size(90, 20)
        Me.txt_horas_proyecto.TabIndex = 5
        Me.txt_horas_proyecto.Visible = false
        '
        'etiquetafecha_fin_prevista
        '
        Me.etiquetafecha_fin_prevista.BackColor = System.Drawing.Color.Transparent
        Me.etiquetafecha_fin_prevista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.etiquetafecha_fin_prevista.ForeColor = System.Drawing.Color.Black
        Me.etiquetafecha_fin_prevista.Location = New System.Drawing.Point(192, 162)
        Me.etiquetafecha_fin_prevista.Name = "etiquetafecha_fin_prevista"
        Me.etiquetafecha_fin_prevista.Size = New System.Drawing.Size(60, 21)
        Me.etiquetafecha_fin_prevista.TabIndex = 543
        Me.etiquetafecha_fin_prevista.Text = "Fecha Fin:"
        Me.etiquetafecha_fin_prevista.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_descripcion_proyecto
        '
        Me.txt_descripcion_proyecto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txt_descripcion_proyecto.BackColor = System.Drawing.Color.White
        Me.txt_descripcion_proyecto.Location = New System.Drawing.Point(9, 119)
        Me.txt_descripcion_proyecto.MaxLength = 50
        Me.txt_descripcion_proyecto.Multiline = true
        Me.txt_descripcion_proyecto.Name = "txt_descripcion_proyecto"
        Me.txt_descripcion_proyecto.Size = New System.Drawing.Size(431, 37)
        Me.txt_descripcion_proyecto.TabIndex = 2
        '
        'etiquetadescripcion
        '
        Me.etiquetadescripcion.BackColor = System.Drawing.Color.Transparent
        Me.etiquetadescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.etiquetadescripcion.ForeColor = System.Drawing.Color.Black
        Me.etiquetadescripcion.Location = New System.Drawing.Point(6, 95)
        Me.etiquetadescripcion.Name = "etiquetadescripcion"
        Me.etiquetadescripcion.Size = New System.Drawing.Size(71, 21)
        Me.etiquetadescripcion.TabIndex = 536
        Me.etiquetadescripcion.Text = "Descripción:"
        Me.etiquetadescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'etiquetanombre_proyecto
        '
        Me.etiquetanombre_proyecto.BackColor = System.Drawing.Color.Transparent
        Me.etiquetanombre_proyecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.etiquetanombre_proyecto.ForeColor = System.Drawing.Color.Black
        Me.etiquetanombre_proyecto.Location = New System.Drawing.Point(6, 48)
        Me.etiquetanombre_proyecto.Name = "etiquetanombre_proyecto"
        Me.etiquetanombre_proyecto.Size = New System.Drawing.Size(49, 21)
        Me.etiquetanombre_proyecto.TabIndex = 537
        Me.etiquetanombre_proyecto.Text = "Nombre:"
        Me.etiquetanombre_proyecto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtp_fecha_fin_estimada_proyecto
        '
        Me.dtp_fecha_fin_estimada_proyecto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_fin_estimada_proyecto.Location = New System.Drawing.Point(258, 163)
        Me.dtp_fecha_fin_estimada_proyecto.Name = "dtp_fecha_fin_estimada_proyecto"
        Me.dtp_fecha_fin_estimada_proyecto.Size = New System.Drawing.Size(85, 20)
        Me.dtp_fecha_fin_estimada_proyecto.TabIndex = 4
        '
        'etiquetafecha_inicio
        '
        Me.etiquetafecha_inicio.BackColor = System.Drawing.Color.Transparent
        Me.etiquetafecha_inicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.etiquetafecha_inicio.ForeColor = System.Drawing.Color.Black
        Me.etiquetafecha_inicio.Location = New System.Drawing.Point(11, 161)
        Me.etiquetafecha_inicio.Name = "etiquetafecha_inicio"
        Me.etiquetafecha_inicio.Size = New System.Drawing.Size(68, 21)
        Me.etiquetafecha_inicio.TabIndex = 542
        Me.etiquetafecha_inicio.Text = "Fecha Inicio:"
        Me.etiquetafecha_inicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtp_fecha_inicio_estimada_proyecto
        '
        Me.dtp_fecha_inicio_estimada_proyecto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_inicio_estimada_proyecto.Location = New System.Drawing.Point(85, 162)
        Me.dtp_fecha_inicio_estimada_proyecto.Name = "dtp_fecha_inicio_estimada_proyecto"
        Me.dtp_fecha_inicio_estimada_proyecto.Size = New System.Drawing.Size(90, 20)
        Me.dtp_fecha_inicio_estimada_proyecto.TabIndex = 3
        '
        'txt_nombre_proyecto
        '
        Me.txt_nombre_proyecto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txt_nombre_proyecto.BackColor = System.Drawing.Color.White
        Me.txt_nombre_proyecto.Location = New System.Drawing.Point(6, 72)
        Me.txt_nombre_proyecto.MaxLength = 50
        Me.txt_nombre_proyecto.Name = "txt_nombre_proyecto"
        Me.txt_nombre_proyecto.Size = New System.Drawing.Size(431, 20)
        Me.txt_nombre_proyecto.TabIndex = 1
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(12, 640)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(83, 25)
        Me.btnCancelar.TabIndex = 15
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = true
        '
        'GroupBox18
        '
        Me.GroupBox18.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.GroupBox18.Controls.Add(Me.dgv_miembros_proyecto)
        Me.GroupBox18.Location = New System.Drawing.Point(12, 378)
        Me.GroupBox18.Name = "GroupBox18"
        Me.GroupBox18.Size = New System.Drawing.Size(443, 193)
        Me.GroupBox18.TabIndex = 11
        Me.GroupBox18.TabStop = false
        Me.GroupBox18.Text = "Miembros"
        '
        'dgv_miembros_proyecto
        '
        Me.dgv_miembros_proyecto.AllowUserToAddRows = false
        Me.dgv_miembros_proyecto.AllowUserToResizeRows = false
        Me.dgv_miembros_proyecto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.dgv_miembros_proyecto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_miembros_proyecto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_miembros_proyecto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_usuario_proyecto, Me.id_usuario, Me.nombre_usuario_proyecto, Me.chk_seleccionado_usuario_proyecto})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_miembros_proyecto.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_miembros_proyecto.Location = New System.Drawing.Point(6, 19)
        Me.dgv_miembros_proyecto.Name = "dgv_miembros_proyecto"
        Me.dgv_miembros_proyecto.RowHeadersVisible = false
        Me.dgv_miembros_proyecto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_miembros_proyecto.Size = New System.Drawing.Size(431, 168)
        Me.dgv_miembros_proyecto.TabIndex = 12
        '
        'id_usuario_proyecto
        '
        Me.id_usuario_proyecto.HeaderText = "id_usuario_proyecto"
        Me.id_usuario_proyecto.Name = "id_usuario_proyecto"
        Me.id_usuario_proyecto.Visible = false
        '
        'id_usuario
        '
        Me.id_usuario.HeaderText = "id_usuario"
        Me.id_usuario.Name = "id_usuario"
        Me.id_usuario.Visible = false
        '
        'nombre_usuario_proyecto
        '
        Me.nombre_usuario_proyecto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nombre_usuario_proyecto.FillWeight = 160.4892!
        Me.nombre_usuario_proyecto.HeaderText = "Nombre"
        Me.nombre_usuario_proyecto.Name = "nombre_usuario_proyecto"
        '
        'chk_seleccionado_usuario_proyecto
        '
        Me.chk_seleccionado_usuario_proyecto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.chk_seleccionado_usuario_proyecto.HeaderText = "Seleccionar"
        Me.chk_seleccionado_usuario_proyecto.Name = "chk_seleccionado_usuario_proyecto"
        Me.chk_seleccionado_usuario_proyecto.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.chk_seleccionado_usuario_proyecto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.chk_seleccionado_usuario_proyecto.Width = 80
        '
        'btn_guardar_proyecto
        '
        Me.btn_guardar_proyecto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btn_guardar_proyecto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_guardar_proyecto.Location = New System.Drawing.Point(372, 640)
        Me.btn_guardar_proyecto.Name = "btn_guardar_proyecto"
        Me.btn_guardar_proyecto.Size = New System.Drawing.Size(83, 25)
        Me.btn_guardar_proyecto.TabIndex = 14
        Me.btn_guardar_proyecto.Text = "Aceptar"
        Me.btn_guardar_proyecto.UseVisualStyleBackColor = true
        '
        'GroupBox20
        '
        Me.GroupBox20.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.GroupBox20.Controls.Add(Me.cmb_controlador_2)
        Me.GroupBox20.Controls.Add(Me.cmb_piloto_proyecto)
        Me.GroupBox20.Controls.Add(Me.Label56)
        Me.GroupBox20.Controls.Add(Me.cmb_controlador_1)
        Me.GroupBox20.Controls.Add(Me.Label57)
        Me.GroupBox20.Controls.Add(Me.Label58)
        Me.GroupBox20.Controls.Add(Me.cmb_pm_proyecto)
        Me.GroupBox20.Controls.Add(Me.Label59)
        Me.GroupBox20.Location = New System.Drawing.Point(12, 249)
        Me.GroupBox20.Name = "GroupBox20"
        Me.GroupBox20.Size = New System.Drawing.Size(443, 123)
        Me.GroupBox20.TabIndex = 6
        Me.GroupBox20.TabStop = false
        Me.GroupBox20.Text = "Encargados del Proyecto:"
        '
        'cmb_controlador_2
        '
        Me.cmb_controlador_2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cmb_controlador_2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_controlador_2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_controlador_2.FormattingEnabled = true
        Me.cmb_controlador_2.Location = New System.Drawing.Point(225, 91)
        Me.cmb_controlador_2.Name = "cmb_controlador_2"
        Me.cmb_controlador_2.Size = New System.Drawing.Size(212, 21)
        Me.cmb_controlador_2.TabIndex = 10
        '
        'cmb_piloto_proyecto
        '
        Me.cmb_piloto_proyecto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_piloto_proyecto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_piloto_proyecto.FormattingEnabled = true
        Me.cmb_piloto_proyecto.Location = New System.Drawing.Point(12, 42)
        Me.cmb_piloto_proyecto.Name = "cmb_piloto_proyecto"
        Me.cmb_piloto_proyecto.Size = New System.Drawing.Size(207, 21)
        Me.cmb_piloto_proyecto.TabIndex = 7
        '
        'Label56
        '
        Me.Label56.AutoSize = true
        Me.Label56.Location = New System.Drawing.Point(225, 75)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(73, 13)
        Me.Label56.TabIndex = 778
        Me.Label56.Text = "Controlador 2:"
        '
        'cmb_controlador_1
        '
        Me.cmb_controlador_1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_controlador_1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_controlador_1.FormattingEnabled = true
        Me.cmb_controlador_1.Location = New System.Drawing.Point(12, 91)
        Me.cmb_controlador_1.Name = "cmb_controlador_1"
        Me.cmb_controlador_1.Size = New System.Drawing.Size(207, 21)
        Me.cmb_controlador_1.TabIndex = 9
        '
        'Label57
        '
        Me.Label57.AutoSize = true
        Me.Label57.Location = New System.Drawing.Point(222, 26)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(96, 13)
        Me.Label57.TabIndex = 7
        Me.Label57.Text = "Piloto de Proyecto:"
        '
        'Label58
        '
        Me.Label58.AutoSize = true
        Me.Label58.Location = New System.Drawing.Point(9, 75)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(73, 13)
        Me.Label58.TabIndex = 776
        Me.Label58.Text = "Controlador 1:"
        '
        'cmb_pm_proyecto
        '
        Me.cmb_pm_proyecto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cmb_pm_proyecto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_pm_proyecto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_pm_proyecto.FormattingEnabled = true
        Me.cmb_pm_proyecto.Location = New System.Drawing.Point(225, 42)
        Me.cmb_pm_proyecto.Name = "cmb_pm_proyecto"
        Me.cmb_pm_proyecto.Size = New System.Drawing.Size(212, 21)
        Me.cmb_pm_proyecto.TabIndex = 8
        '
        'Label59
        '
        Me.Label59.AutoSize = true
        Me.Label59.Location = New System.Drawing.Point(9, 26)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(88, 13)
        Me.Label59.TabIndex = 5
        Me.Label59.Text = "Project Manager:"
        '
        'cmbCalendario
        '
        Me.cmbCalendario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCalendario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCalendario.FormattingEnabled = true
        Me.cmbCalendario.Location = New System.Drawing.Point(111, 593)
        Me.cmbCalendario.Name = "cmbCalendario"
        Me.cmbCalendario.Size = New System.Drawing.Size(338, 21)
        Me.cmbCalendario.TabIndex = 777
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(18, 596)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 778
        Me.Label2.Text = "Calendario Base:"
        '
        'AgregarProyecto
        '
        Me.AcceptButton = Me.btn_guardar_proyecto
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(463, 675)
        Me.Controls.Add(Me.cmbCalendario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btn_guardar_proyecto)
        Me.Controls.Add(Me.GroupBox17)
        Me.Controls.Add(Me.GroupBox18)
        Me.Controls.Add(Me.GroupBox20)
        Me.Name = "AgregarProyecto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Proyecto"
        Me.GroupBox17.ResumeLayout(false)
        Me.GroupBox17.PerformLayout
        CType(Me.txt_horas_proyecto,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox18.ResumeLayout(false)
        CType(Me.dgv_miembros_proyecto,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox20.ResumeLayout(false)
        Me.GroupBox20.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents GroupBox17 As GroupBox
    Friend WithEvents GroupBox18 As GroupBox
    Friend WithEvents dgv_miembros_proyecto As DataGridView
    Friend WithEvents id_usuario_proyecto As DataGridViewTextBoxColumn
    Friend WithEvents id_usuario As DataGridViewTextBoxColumn
    Friend WithEvents nombre_usuario_proyecto As DataGridViewTextBoxColumn
    Friend WithEvents chk_seleccionado_usuario_proyecto As DataGridViewCheckBoxColumn
    Public WithEvents btn_guardar_proyecto As Button
    Friend WithEvents GroupBox20 As GroupBox
    Friend WithEvents cmb_controlador_2 As ComboBox
    Friend WithEvents cmb_piloto_proyecto As ComboBox
    Friend WithEvents Label56 As Label
    Friend WithEvents cmb_controlador_1 As ComboBox
    Friend WithEvents Label57 As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents cmb_pm_proyecto As ComboBox
    Friend WithEvents Label59 As Label
    Protected WithEvents txt_descripcion_proyecto As TextBox
    Friend WithEvents etiquetadescripcion As Label
    Friend WithEvents etiquetanombre_proyecto As Label
    Protected WithEvents txt_nombre_proyecto As TextBox
    Public WithEvents btnCancelar As Button
    Friend WithEvents etiquetafecha_fin_prevista As Label
    Protected WithEvents dtp_fecha_fin_estimada_proyecto As DateTimePicker
    Friend WithEvents etiquetafecha_inicio As Label
    Protected WithEvents dtp_fecha_inicio_estimada_proyecto As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_horas_proyecto As NumericUpDown
    Friend WithEvents cmbCliente As ComboBox
    Friend WithEvents cmbCalendario As ComboBox
    Friend WithEvents Label2 As Label
End Class
