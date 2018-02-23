<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleRemito
   Inherits System.Windows.Forms.Form

   'Form reemplaza a Dispose para limpiar la lista de componentes.
   <System.Diagnostics.DebuggerNonUserCode()> _
   Protected Overrides Sub Dispose(ByVal disposing As Boolean)
       If disposing AndAlso components IsNot Nothing Then
           components.Dispose()
       End If
       MyBase.Dispose(disposing)
   End Sub

   'Requerido por el Diseñador de Windows Forms
   Private components As System.ComponentModel.IContainer

   'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
   'Se puede modificar usando el Diseñador de Windows Forms.
   'No lo modifique con el editor de código.
   <System.Diagnostics.DebuggerStepThrough()> _
   Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleRemito))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.lblid_Remito = New System.Windows.Forms.Label()
        Me.lblid_pk = New System.Windows.Forms.Label()
        Me.lblid_factura = New System.Windows.Forms.Label()
        Me.btnBuscafactura = New System.Windows.Forms.Button()
        Me.cmbfactura = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_factura = New System.Windows.Forms.Label()
        Me.dtpfecha_remito = New System.Windows.Forms.DateTimePicker()
        Me.etiquetafecha_remito = New System.Windows.Forms.Label()
        Me.txtnumero_remito = New System.Windows.Forms.TextBox()
        Me.etiquetanumero_remito = New System.Windows.Forms.Label()
        Me.lblid_cliente = New System.Windows.Forms.Label()
        Me.cmbcliente = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_cliente = New System.Windows.Forms.Label()
        Me.etiquetacondicion_venta = New System.Windows.Forms.Label()
        Me.txtobservacion = New System.Windows.Forms.TextBox()
        Me.etiquetaobservacion = New System.Windows.Forms.Label()
        Me.lblid_usuario = New System.Windows.Forms.Label()
        Me.cmbCondVta = New System.Windows.Forms.ComboBox()
        Me.lblId_Condicion_vta = New System.Windows.Forms.Label()
        Me.btnBusca_condicion_venta = New System.Windows.Forms.Button()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(28, 577)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 49)
        Me.btnSalir.TabIndex = 61
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(28, 512)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 49)
        Me.btnGuardar.TabIndex = 60
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAgregar.Location = New System.Drawing.Point(28, 296)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 49)
        Me.btnAgregar.TabIndex = 50
        Me.btnAgregar.Text = "&Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModificar.Location = New System.Drawing.Point(28, 366)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 49)
        Me.btnModificar.TabIndex = 51
        Me.btnModificar.Text = "&Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar.Image = CType(resources.GetObject("btnBorrar.Image"), System.Drawing.Image)
        Me.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBorrar.Location = New System.Drawing.Point(28, 437)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 49)
        Me.btnBorrar.TabIndex = 52
        Me.btnBorrar.Text = "&Borrar"
        Me.btnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToResizeColumns = False
        Me.dgv1.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Brown
        Me.dgv1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv1.BackgroundColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Beige
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Brown
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv1.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgv1.GridColor = System.Drawing.Color.MediumPurple
        Me.dgv1.Location = New System.Drawing.Point(135, 296)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.ShowCellErrors = False
        Me.dgv1.ShowRowErrors = False
        Me.dgv1.Size = New System.Drawing.Size(845, 330)
        Me.dgv1.StandardTab = True
        Me.dgv1.TabIndex = 500
        '
        'lblid_Remito
        '
        Me.lblid_Remito.AutoSize = True
        Me.lblid_Remito.BackColor = System.Drawing.Color.Red
        Me.lblid_Remito.Location = New System.Drawing.Point(276, -7)
        Me.lblid_Remito.Name = "lblid_Remito"
        Me.lblid_Remito.Size = New System.Drawing.Size(13, 13)
        Me.lblid_Remito.TabIndex = 565
        Me.lblid_Remito.Text = "0"
        Me.lblid_Remito.Visible = False
        '
        'lblid_pk
        '
        Me.lblid_pk.AutoSize = True
        Me.lblid_pk.BackColor = System.Drawing.Color.Red
        Me.lblid_pk.Location = New System.Drawing.Point(158, 309)
        Me.lblid_pk.Name = "lblid_pk"
        Me.lblid_pk.Size = New System.Drawing.Size(13, 13)
        Me.lblid_pk.TabIndex = 565
        Me.lblid_pk.Text = "0"
        Me.lblid_pk.Visible = False
        '
        'lblid_factura
        '
        Me.lblid_factura.AutoSize = True
        Me.lblid_factura.BackColor = System.Drawing.Color.Red
        Me.lblid_factura.Location = New System.Drawing.Point(370, 59)
        Me.lblid_factura.Name = "lblid_factura"
        Me.lblid_factura.Size = New System.Drawing.Size(13, 13)
        Me.lblid_factura.TabIndex = 500
        Me.lblid_factura.Text = "0"
        Me.lblid_factura.Visible = False
        '
        'btnBuscafactura
        '
        Me.btnBuscafactura.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscafactura.Image = CType(resources.GetObject("btnBuscafactura.Image"), System.Drawing.Image)
        Me.btnBuscafactura.Location = New System.Drawing.Point(506, 59)
        Me.btnBuscafactura.Name = "btnBuscafactura"
        Me.btnBuscafactura.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscafactura.TabIndex = 30
        Me.btnBuscafactura.UseVisualStyleBackColor = True
        '
        'cmbfactura
        '
        Me.cmbfactura.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbfactura.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbfactura.FormattingEnabled = True
        Me.cmbfactura.Location = New System.Drawing.Point(161, 59)
        Me.cmbfactura.Name = "cmbfactura"
        Me.cmbfactura.Size = New System.Drawing.Size(329, 21)
        Me.cmbfactura.TabIndex = 4
        '
        'etiquetaid_factura
        '
        Me.etiquetaid_factura.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_factura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_factura.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_factura.Location = New System.Drawing.Point(28, 59)
        Me.etiquetaid_factura.Name = "etiquetaid_factura"
        Me.etiquetaid_factura.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_factura.TabIndex = 501
        Me.etiquetaid_factura.Text = "Factura"
        Me.etiquetaid_factura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpfecha_remito
        '
        Me.dtpfecha_remito.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha_remito.Location = New System.Drawing.Point(161, 93)
        Me.dtpfecha_remito.Name = "dtpfecha_remito"
        Me.dtpfecha_remito.Size = New System.Drawing.Size(93, 20)
        Me.dtpfecha_remito.TabIndex = 5
        '
        'etiquetafecha_remito
        '
        Me.etiquetafecha_remito.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetafecha_remito.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetafecha_remito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetafecha_remito.ForeColor = System.Drawing.Color.Black
        Me.etiquetafecha_remito.Location = New System.Drawing.Point(28, 93)
        Me.etiquetafecha_remito.Name = "etiquetafecha_remito"
        Me.etiquetafecha_remito.Size = New System.Drawing.Size(127, 21)
        Me.etiquetafecha_remito.TabIndex = 502
        Me.etiquetafecha_remito.Text = "Fecha_remito"
        Me.etiquetafecha_remito.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtnumero_remito
        '
        Me.txtnumero_remito.BackColor = System.Drawing.Color.White
        Me.txtnumero_remito.Location = New System.Drawing.Point(161, 130)
        Me.txtnumero_remito.MaxLength = 50
        Me.txtnumero_remito.Name = "txtnumero_remito"
        Me.txtnumero_remito.Size = New System.Drawing.Size(385, 20)
        Me.txtnumero_remito.TabIndex = 6
        '
        'etiquetanumero_remito
        '
        Me.etiquetanumero_remito.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetanumero_remito.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetanumero_remito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetanumero_remito.ForeColor = System.Drawing.Color.Black
        Me.etiquetanumero_remito.Location = New System.Drawing.Point(28, 130)
        Me.etiquetanumero_remito.Name = "etiquetanumero_remito"
        Me.etiquetanumero_remito.Size = New System.Drawing.Size(127, 21)
        Me.etiquetanumero_remito.TabIndex = 503
        Me.etiquetanumero_remito.Text = "Numero_remito"
        Me.etiquetanumero_remito.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_cliente
        '
        Me.lblid_cliente.AutoSize = True
        Me.lblid_cliente.BackColor = System.Drawing.Color.Red
        Me.lblid_cliente.Location = New System.Drawing.Point(370, 27)
        Me.lblid_cliente.Name = "lblid_cliente"
        Me.lblid_cliente.Size = New System.Drawing.Size(13, 13)
        Me.lblid_cliente.TabIndex = 504
        Me.lblid_cliente.Text = "0"
        Me.lblid_cliente.Visible = False
        '
        'cmbcliente
        '
        Me.cmbcliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbcliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbcliente.Enabled = False
        Me.cmbcliente.FormattingEnabled = True
        Me.cmbcliente.Location = New System.Drawing.Point(161, 27)
        Me.cmbcliente.Name = "cmbcliente"
        Me.cmbcliente.Size = New System.Drawing.Size(329, 21)
        Me.cmbcliente.TabIndex = 7
        '
        'etiquetaid_cliente
        '
        Me.etiquetaid_cliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_cliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_cliente.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_cliente.Location = New System.Drawing.Point(28, 27)
        Me.etiquetaid_cliente.Name = "etiquetaid_cliente"
        Me.etiquetaid_cliente.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_cliente.TabIndex = 505
        Me.etiquetaid_cliente.Text = "Cliente"
        Me.etiquetaid_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'etiquetacondicion_venta
        '
        Me.etiquetacondicion_venta.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetacondicion_venta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetacondicion_venta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetacondicion_venta.ForeColor = System.Drawing.Color.Black
        Me.etiquetacondicion_venta.Location = New System.Drawing.Point(28, 166)
        Me.etiquetacondicion_venta.Name = "etiquetacondicion_venta"
        Me.etiquetacondicion_venta.Size = New System.Drawing.Size(127, 21)
        Me.etiquetacondicion_venta.TabIndex = 506
        Me.etiquetacondicion_venta.Text = "Condicion_venta"
        Me.etiquetacondicion_venta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtobservacion
        '
        Me.txtobservacion.BackColor = System.Drawing.Color.White
        Me.txtobservacion.Location = New System.Drawing.Point(161, 205)
        Me.txtobservacion.MaxLength = 50
        Me.txtobservacion.Name = "txtobservacion"
        Me.txtobservacion.Size = New System.Drawing.Size(385, 20)
        Me.txtobservacion.TabIndex = 8
        '
        'etiquetaobservacion
        '
        Me.etiquetaobservacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaobservacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaobservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaobservacion.ForeColor = System.Drawing.Color.Black
        Me.etiquetaobservacion.Location = New System.Drawing.Point(28, 205)
        Me.etiquetaobservacion.Name = "etiquetaobservacion"
        Me.etiquetaobservacion.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaobservacion.TabIndex = 507
        Me.etiquetaobservacion.Text = "Observacion"
        Me.etiquetaobservacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_usuario
        '
        Me.lblid_usuario.AutoSize = True
        Me.lblid_usuario.BackColor = System.Drawing.Color.Red
        Me.lblid_usuario.Location = New System.Drawing.Point(389, 240)
        Me.lblid_usuario.Name = "lblid_usuario"
        Me.lblid_usuario.Size = New System.Drawing.Size(13, 13)
        Me.lblid_usuario.TabIndex = 508
        Me.lblid_usuario.Text = "0"
        Me.lblid_usuario.Visible = False
        '
        'cmbCondVta
        '
        Me.cmbCondVta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCondVta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCondVta.FormattingEnabled = True
        Me.cmbCondVta.Location = New System.Drawing.Point(161, 168)
        Me.cmbCondVta.Name = "cmbCondVta"
        Me.cmbCondVta.Size = New System.Drawing.Size(329, 21)
        Me.cmbCondVta.TabIndex = 566
        '
        'lblId_Condicion_vta
        '
        Me.lblId_Condicion_vta.AutoSize = True
        Me.lblId_Condicion_vta.BackColor = System.Drawing.Color.Red
        Me.lblId_Condicion_vta.Location = New System.Drawing.Point(407, 171)
        Me.lblId_Condicion_vta.Name = "lblId_Condicion_vta"
        Me.lblId_Condicion_vta.Size = New System.Drawing.Size(13, 13)
        Me.lblId_Condicion_vta.TabIndex = 567
        Me.lblId_Condicion_vta.Text = "0"
        Me.lblId_Condicion_vta.Visible = False
        '
        'btnBusca_condicion_venta
        '
        Me.btnBusca_condicion_venta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBusca_condicion_venta.Image = CType(resources.GetObject("btnBusca_condicion_venta.Image"), System.Drawing.Image)
        Me.btnBusca_condicion_venta.Location = New System.Drawing.Point(506, 167)
        Me.btnBusca_condicion_venta.Name = "btnBusca_condicion_venta"
        Me.btnBusca_condicion_venta.Size = New System.Drawing.Size(30, 21)
        Me.btnBusca_condicion_venta.TabIndex = 568
        Me.btnBusca_condicion_venta.UseVisualStyleBackColor = True
        '
        'frmDetalleRemito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 741)
        Me.Controls.Add(Me.btnBusca_condicion_venta)
        Me.Controls.Add(Me.lblId_Condicion_vta)
        Me.Controls.Add(Me.cmbCondVta)
        Me.Controls.Add(Me.lblid_factura)
        Me.Controls.Add(Me.btnBuscafactura)
        Me.Controls.Add(Me.cmbfactura)
        Me.Controls.Add(Me.etiquetaid_factura)
        Me.Controls.Add(Me.dtpfecha_remito)
        Me.Controls.Add(Me.etiquetafecha_remito)
        Me.Controls.Add(Me.txtnumero_remito)
        Me.Controls.Add(Me.etiquetanumero_remito)
        Me.Controls.Add(Me.lblid_cliente)
        Me.Controls.Add(Me.cmbcliente)
        Me.Controls.Add(Me.etiquetaid_cliente)
        Me.Controls.Add(Me.etiquetacondicion_venta)
        Me.Controls.Add(Me.txtobservacion)
        Me.Controls.Add(Me.etiquetaobservacion)
        Me.Controls.Add(Me.lblid_usuario)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.lblid_pk)
        Me.Controls.Add(Me.lblid_Remito)
        Me.Name = "frmDetalleRemito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetalleRemito"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblid_factura As System.Windows.Forms.Label
    Friend WithEvents btnBuscafactura As System.Windows.Forms.Button
    Friend WithEvents cmbfactura As System.Windows.Forms.ComboBox
    Friend WithEvents etiquetaid_factura As System.Windows.Forms.Label
    Protected WithEvents dtpfecha_remito As System.Windows.Forms.DateTimePicker
    Friend WithEvents etiquetafecha_remito As System.Windows.Forms.Label
    Protected WithEvents txtnumero_remito As System.Windows.Forms.TextBox
    Friend WithEvents etiquetanumero_remito As System.Windows.Forms.Label
    Friend WithEvents lblid_cliente As System.Windows.Forms.Label
    Friend WithEvents cmbcliente As System.Windows.Forms.ComboBox
    Friend WithEvents etiquetaid_cliente As System.Windows.Forms.Label
    Friend WithEvents etiquetacondicion_venta As System.Windows.Forms.Label
    Protected WithEvents txtobservacion As System.Windows.Forms.TextBox
    Friend WithEvents etiquetaobservacion As System.Windows.Forms.Label
    Friend WithEvents lblid_usuario As System.Windows.Forms.Label
    Protected WithEvents btnSalir As System.Windows.Forms.Button
    Protected WithEvents btnGuardar As System.Windows.Forms.Button
    Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
    Protected WithEvents btnBorrar As System.Windows.Forms.Button
    Protected WithEvents btnModificar As System.Windows.Forms.Button
    Protected WithEvents btnAgregar As System.Windows.Forms.Button
    Protected WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblid_pk As System.Windows.Forms.Label
    Friend WithEvents lblid_Remito As System.Windows.Forms.Label
    Friend WithEvents cmbCondVta As System.Windows.Forms.ComboBox
    Friend WithEvents lblId_Condicion_vta As System.Windows.Forms.Label
    Friend WithEvents btnBusca_condicion_venta As System.Windows.Forms.Button
End Class

