<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleLogueo
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleLogueo))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtp_fecha_hasta = New System.Windows.Forms.DateTimePicker()
        Me.dtp_fecha_desde = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmb_usuarios = New System.Windows.Forms.ComboBox()
        Me.tv_subproyectos = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_proyecto_seleccionado = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_actividad_seleccionada = New System.Windows.Forms.TextBox()
        Me.dgv_movimiento_hora = New System.Windows.Forms.DataGridView()
        Me.id_movimiento_hora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_cuerpoMovimientoHora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_actividad_proyecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Entrada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Salida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proyecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subproyecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Actividad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.no_trabajado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cms_horas = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ts_agregar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_modificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_borrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmb_cliente = New System.Windows.Forms.ComboBox()
        Me.ToolTipNuevo = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnQuitarLogueo = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_movimiento_hora, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_horas.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(400, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Usuario: "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(19, 97)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 13)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Hasta: "
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtp_fecha_hasta
        '
        Me.dtp_fecha_hasta.CustomFormat = "HH:mm:ss"
        Me.dtp_fecha_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_fecha_hasta.Location = New System.Drawing.Point(63, 94)
        Me.dtp_fecha_hasta.Name = "dtp_fecha_hasta"
        Me.dtp_fecha_hasta.Size = New System.Drawing.Size(163, 20)
        Me.dtp_fecha_hasta.TabIndex = 26
        '
        'dtp_fecha_desde
        '
        Me.dtp_fecha_desde.CustomFormat = "HH:mm:ss"
        Me.dtp_fecha_desde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_fecha_desde.Location = New System.Drawing.Point(63, 63)
        Me.dtp_fecha_desde.Name = "dtp_fecha_desde"
        Me.dtp_fecha_desde.ShowUpDown = True
        Me.dtp_fecha_desde.Size = New System.Drawing.Size(163, 20)
        Me.dtp_fecha_desde.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 67)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Desde: "
        '
        'cmb_usuarios
        '
        Me.cmb_usuarios.FormattingEnabled = True
        Me.cmb_usuarios.Location = New System.Drawing.Point(455, 44)
        Me.cmb_usuarios.Name = "cmb_usuarios"
        Me.cmb_usuarios.Size = New System.Drawing.Size(184, 21)
        Me.cmb_usuarios.TabIndex = 23
        '
        'tv_subproyectos
        '
        Me.tv_subproyectos.AllowDrop = True
        Me.tv_subproyectos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tv_subproyectos.BackColor = System.Drawing.Color.Gainsboro
        Me.tv_subproyectos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tv_subproyectos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tv_subproyectos.ImageIndex = 0
        Me.tv_subproyectos.ImageList = Me.ImageList1
        Me.tv_subproyectos.Location = New System.Drawing.Point(12, 43)
        Me.tv_subproyectos.MinimumSize = New System.Drawing.Size(374, 448)
        Me.tv_subproyectos.Name = "tv_subproyectos"
        Me.tv_subproyectos.SelectedImageIndex = 0
        Me.tv_subproyectos.Size = New System.Drawing.Size(374, 448)
        Me.tv_subproyectos.TabIndex = 29
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Proyecto16.png")
        Me.ImageList1.Images.SetKeyName(1, "Actividad16.png")
        Me.ImageList1.Images.SetKeyName(2, "bullet-check.png")
        Me.ImageList1.Images.SetKeyName(3, "ActividadCheck.png")
        Me.ImageList1.Images.SetKeyName(4, "iva.png")
        Me.ImageList1.Images.SetKeyName(5, "ProyectoSeleccionado16.png")
        Me.ImageList1.Images.SetKeyName(6, "ActividadControlOK16.png")
        Me.ImageList1.Images.SetKeyName(7, "ActividadControlOK16_2.png")
        Me.ImageList1.Images.SetKeyName(8, "ActividadControlPedido16_2.png")
        Me.ImageList1.Images.SetKeyName(9, "ActividadNaranja16.png")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Cliente:"
        '
        'dtp_fecha
        '
        Me.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha.Location = New System.Drawing.Point(60, 32)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(163, 20)
        Me.dtp_fecha.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Fecha:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtp_fecha_hasta)
        Me.GroupBox1.Controls.Add(Me.dtp_fecha)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtp_fecha_desde)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Location = New System.Drawing.Point(403, 107)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 131)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fecha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(400, 292)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 13)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Proyecto seleccionado:"
        '
        'txt_proyecto_seleccionado
        '
        Me.txt_proyecto_seleccionado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_proyecto_seleccionado.Location = New System.Drawing.Point(403, 308)
        Me.txt_proyecto_seleccionado.Name = "txt_proyecto_seleccionado"
        Me.txt_proyecto_seleccionado.ReadOnly = True
        Me.txt_proyecto_seleccionado.Size = New System.Drawing.Size(240, 95)
        Me.txt_proyecto_seleccionado.TabIndex = 41
        Me.txt_proyecto_seleccionado.Text = ""
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(400, 412)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Actividad: "
        '
        'txt_actividad_seleccionada
        '
        Me.txt_actividad_seleccionada.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_actividad_seleccionada.Location = New System.Drawing.Point(455, 409)
        Me.txt_actividad_seleccionada.Name = "txt_actividad_seleccionada"
        Me.txt_actividad_seleccionada.ReadOnly = True
        Me.txt_actividad_seleccionada.Size = New System.Drawing.Size(184, 20)
        Me.txt_actividad_seleccionada.TabIndex = 43
        '
        'dgv_movimiento_hora
        '
        Me.dgv_movimiento_hora.AllowUserToAddRows = False
        Me.dgv_movimiento_hora.AllowUserToDeleteRows = False
        Me.dgv_movimiento_hora.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_movimiento_hora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgv_movimiento_hora.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgv_movimiento_hora.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_movimiento_hora, Me.id_cuerpoMovimientoHora, Me.id_actividad_proyecto, Me.Entrada, Me.Salida, Me.Proyecto, Me.Subproyecto, Me.Actividad, Me.no_trabajado})
        Me.dgv_movimiento_hora.ContextMenuStrip = Me.cms_horas
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_movimiento_hora.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_movimiento_hora.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgv_movimiento_hora.Location = New System.Drawing.Point(658, 43)
        Me.dgv_movimiento_hora.Name = "dgv_movimiento_hora"
        Me.dgv_movimiento_hora.RowHeadersVisible = False
        Me.dgv_movimiento_hora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_movimiento_hora.ShowCellErrors = False
        Me.dgv_movimiento_hora.Size = New System.Drawing.Size(444, 245)
        Me.dgv_movimiento_hora.TabIndex = 44
        '
        'id_movimiento_hora
        '
        Me.id_movimiento_hora.HeaderText = "id_movimiento_hora"
        Me.id_movimiento_hora.Name = "id_movimiento_hora"
        Me.id_movimiento_hora.Visible = False
        Me.id_movimiento_hora.Width = 126
        '
        'id_cuerpoMovimientoHora
        '
        Me.id_cuerpoMovimientoHora.HeaderText = "id_cuerpoMovimientoHora"
        Me.id_cuerpoMovimientoHora.Name = "id_cuerpoMovimientoHora"
        Me.id_cuerpoMovimientoHora.Visible = False
        Me.id_cuerpoMovimientoHora.Width = 156
        '
        'id_actividad_proyecto
        '
        Me.id_actividad_proyecto.HeaderText = "id_actividad_proyecto"
        Me.id_actividad_proyecto.Name = "id_actividad_proyecto"
        Me.id_actividad_proyecto.Visible = False
        Me.id_actividad_proyecto.Width = 136
        '
        'Entrada
        '
        DataGridViewCellStyle1.Format = "HH:mm:ss"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Entrada.DefaultCellStyle = DataGridViewCellStyle1
        Me.Entrada.HeaderText = "Entrada"
        Me.Entrada.Name = "Entrada"
        Me.Entrada.Width = 69
        '
        'Salida
        '
        DataGridViewCellStyle2.Format = "HH:mm:ss"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Salida.DefaultCellStyle = DataGridViewCellStyle2
        Me.Salida.HeaderText = "Salida"
        Me.Salida.Name = "Salida"
        Me.Salida.Width = 61
        '
        'Proyecto
        '
        Me.Proyecto.HeaderText = "Proyecto"
        Me.Proyecto.Name = "Proyecto"
        Me.Proyecto.Width = 74
        '
        'Subproyecto
        '
        Me.Subproyecto.HeaderText = "Subproyecto"
        Me.Subproyecto.Name = "Subproyecto"
        Me.Subproyecto.Width = 92
        '
        'Actividad
        '
        Me.Actividad.HeaderText = "Actividad"
        Me.Actividad.Name = "Actividad"
        Me.Actividad.Width = 76
        '
        'no_trabajado
        '
        Me.no_trabajado.HeaderText = "No trabajado"
        Me.no_trabajado.Name = "no_trabajado"
        Me.no_trabajado.ReadOnly = True
        Me.no_trabajado.Width = 74
        '
        'cms_horas
        '
        Me.cms_horas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_agregar, Me.ts_modificar, Me.ts_borrar})
        Me.cms_horas.Name = "cms_horas"
        Me.cms_horas.Size = New System.Drawing.Size(126, 70)
        '
        'ts_agregar
        '
        Me.ts_agregar.Name = "ts_agregar"
        Me.ts_agregar.Size = New System.Drawing.Size(125, 22)
        Me.ts_agregar.Text = "Agregar"
        '
        'ts_modificar
        '
        Me.ts_modificar.Name = "ts_modificar"
        Me.ts_modificar.Size = New System.Drawing.Size(125, 22)
        Me.ts_modificar.Text = "Modificar"
        '
        'ts_borrar
        '
        Me.ts_borrar.Name = "ts_borrar"
        Me.ts_borrar.Size = New System.Drawing.Size(125, 22)
        Me.ts_borrar.Text = "Borrar"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(1027, 294)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmb_cliente
        '
        Me.cmb_cliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_cliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_cliente.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.cmb_cliente.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_cliente.FormattingEnabled = True
        Me.cmb_cliente.Location = New System.Drawing.Point(60, 11)
        Me.cmb_cliente.Name = "cmb_cliente"
        Me.cmb_cliente.Size = New System.Drawing.Size(326, 23)
        Me.cmb_cliente.TabIndex = 741
        '
        'btnQuitarLogueo
        '
        Me.btnQuitarLogueo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuitarLogueo.BackgroundImage = Global.Dececco.My.Resources.Resources.Button_Delete_icon
        Me.btnQuitarLogueo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnQuitarLogueo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnQuitarLogueo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarLogueo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnQuitarLogueo.Location = New System.Drawing.Point(1108, 117)
        Me.btnQuitarLogueo.Name = "btnQuitarLogueo"
        Me.btnQuitarLogueo.Size = New System.Drawing.Size(42, 46)
        Me.btnQuitarLogueo.TabIndex = 743
        Me.btnQuitarLogueo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTipNuevo.SetToolTip(Me.btnQuitarLogueo, "Quitar Logueo")
        Me.btnQuitarLogueo.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.BackgroundImage = Global.Dececco.My.Resources.Resources.Button_Add_icon
        Me.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAgregar.Location = New System.Drawing.Point(1108, 65)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(42, 46)
        Me.btnAgregar.TabIndex = 742
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTipNuevo.SetToolTip(Me.btnAgregar, "Agregar Logueo")
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(775, 420)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(86, 71)
        Me.btnNuevo.TabIndex = 46
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancelar.Location = New System.Drawing.Point(981, 420)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(72, 71)
        Me.btnCancelar.TabIndex = 37
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAceptar.Location = New System.Drawing.Point(1072, 420)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(72, 71)
        Me.btnAceptar.TabIndex = 35
        Me.btnAceptar.Text = "Guardar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'frmDetalleLogueo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1156, 503)
        Me.Controls.Add(Me.btnQuitarLogueo)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.cmb_cliente)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgv_movimiento_hora)
        Me.Controls.Add(Me.txt_actividad_seleccionada)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_proyecto_seleccionado)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tv_subproyectos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_usuarios)
        Me.MinimumSize = New System.Drawing.Size(670, 542)
        Me.Name = "frmDetalleLogueo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrar logueos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_movimiento_hora, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_horas.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha_hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fecha_desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmb_usuarios As System.Windows.Forms.ComboBox
    Friend WithEvents tv_subproyectos As System.Windows.Forms.TreeView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Protected WithEvents btnAceptar As System.Windows.Forms.Button
    Protected WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_proyecto_seleccionado As System.Windows.Forms.RichTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_actividad_seleccionada As System.Windows.Forms.TextBox
    Friend WithEvents dgv_movimiento_hora As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cms_horas As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ts_agregar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_modificar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_borrar As System.Windows.Forms.ToolStripMenuItem
    Protected WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents cmb_cliente As System.Windows.Forms.ComboBox
    Friend WithEvents id_movimiento_hora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_cuerpoMovimientoHora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_actividad_proyecto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Entrada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Salida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Proyecto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Subproyecto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Actividad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents no_trabajado As System.Windows.Forms.DataGridViewCheckBoxColumn
    Protected WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents ToolTipNuevo As System.Windows.Forms.ToolTip
    Protected WithEvents btnQuitarLogueo As System.Windows.Forms.Button
End Class
