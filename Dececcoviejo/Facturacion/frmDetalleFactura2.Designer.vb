<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleFactura2
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleFactura2))
        Me.ttBorrar = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttSalir = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttModificar = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttAgregar = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label6 = New System.Windows.Forms.Label
        Me.ttCliente = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtIva_factura = New System.Windows.Forms.TextBox
        Me.ttGuardar = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtTipo = New System.Windows.Forms.TextBox
        Me.lblid_factura = New System.Windows.Forms.Label
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.btnNuevo = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.lblid_pk = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNumero_factura_2 = New System.Windows.Forms.TextBox
        Me.txtNumero_factura_1 = New System.Windows.Forms.TextBox
        Me.dtpFecha_factura = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblid_cliente = New System.Windows.Forms.Label
        Me.btnBuscaCliente = New System.Windows.Forms.Button
        Me.cmbCliente = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtImporte = New System.Windows.Forms.TextBox
        Me.txtPrecio_item = New System.Windows.Forms.TextBox
        Me.txtDescripcion_item = New System.Windows.Forms.TextBox
        Me.txtCantidad_item = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtSubtotal = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtIva = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.ttImprimir = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtTotal_letra = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.rbnND = New System.Windows.Forms.RadioButton
        Me.rbnNC = New System.Windows.Forms.RadioButton
        Me.rbnFactura = New System.Windows.Forms.RadioButton
        Me.txtImpuesto = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.rbnResponsable_no_inscripto = New System.Windows.Forms.RadioButton
        Me.rbnResponsable_inscripto = New System.Windows.Forms.RadioButton
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtNumero_remito_2 = New System.Windows.Forms.TextBox
        Me.txtNumero_remito_1 = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.rbnCheque = New System.Windows.Forms.RadioButton
        Me.rbnTarjeta = New System.Windows.Forms.RadioButton
        Me.rbnCuenta_corriente = New System.Windows.Forms.RadioButton
        Me.rbnContado = New System.Windows.Forms.RadioButton
        Me.txtCondicion_pago = New System.Windows.Forms.TextBox
        Me.txtReferencia = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtcomprobante = New System.Windows.Forms.TextBox
        Me.txtNro_Item = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.rbnRetencion = New System.Windows.Forms.RadioButton
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtRetencion = New System.Windows.Forms.TextBox
        Me.txt_certificado = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.dtpFechaVen = New System.Windows.Forms.DateTimePicker
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.lblid_moneda = New System.Windows.Forms.Label
        Me.cmbMoneda = New System.Windows.Forms.ComboBox
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(294, 1)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 647
        Me.Label6.Text = "Tipo"
        Me.Label6.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(539, 82)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 646
        Me.Label8.Text = "Alicuota"
        '
        'txtIva_factura
        '
        Me.txtIva_factura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIva_factura.Location = New System.Drawing.Point(590, 79)
        Me.txtIva_factura.MaxLength = 4
        Me.txtIva_factura.Name = "txtIva_factura"
        Me.txtIva_factura.Size = New System.Drawing.Size(72, 20)
        Me.txtIva_factura.TabIndex = 12
        Me.txtIva_factura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTipo
        '
        Me.txtTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipo.Location = New System.Drawing.Point(328, 1)
        Me.txtTipo.MaxLength = 4
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(72, 20)
        Me.txtTipo.TabIndex = 9
        Me.txtTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTipo.Visible = False
        '
        'lblid_factura
        '
        Me.lblid_factura.AutoSize = True
        Me.lblid_factura.BackColor = System.Drawing.Color.Red
        Me.lblid_factura.ForeColor = System.Drawing.Color.Yellow
        Me.lblid_factura.Location = New System.Drawing.Point(25, 48)
        Me.lblid_factura.Name = "lblid_factura"
        Me.lblid_factura.Size = New System.Drawing.Size(13, 13)
        Me.lblid_factura.TabIndex = 645
        Me.lblid_factura.Text = "0"
        Me.lblid_factura.Visible = False
        '
        'btnImprimir
        '
        Me.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImprimir.Enabled = False
        Me.btnImprimir.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.ForeColor = System.Drawing.Color.Black
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprimir.Location = New System.Drawing.Point(242, 598)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(81, 69)
        Me.btnImprimir.TabIndex = 31
        Me.btnImprimir.Text = "&Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.Enabled = False
        Me.btnNuevo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.Black
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(29, 598)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(78, 69)
        Me.btnNuevo.TabIndex = 32
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(888, 598)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(81, 69)
        Me.btnSalir.TabIndex = 33
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(158, 598)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(78, 69)
        Me.btnGuardar.TabIndex = 30
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'lblid_pk
        '
        Me.lblid_pk.AutoSize = True
        Me.lblid_pk.BackColor = System.Drawing.Color.Red
        Me.lblid_pk.ForeColor = System.Drawing.Color.Yellow
        Me.lblid_pk.Location = New System.Drawing.Point(64, 48)
        Me.lblid_pk.Name = "lblid_pk"
        Me.lblid_pk.Size = New System.Drawing.Size(13, 13)
        Me.lblid_pk.TabIndex = 638
        Me.lblid_pk.Text = "0"
        Me.lblid_pk.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(704, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 637
        Me.Label2.Text = "Número"
        '
        'txtNumero_factura_2
        '
        Me.txtNumero_factura_2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero_factura_2.Location = New System.Drawing.Point(832, 9)
        Me.txtNumero_factura_2.MaxLength = 8
        Me.txtNumero_factura_2.Name = "txtNumero_factura_2"
        Me.txtNumero_factura_2.Size = New System.Drawing.Size(135, 20)
        Me.txtNumero_factura_2.TabIndex = 8
        Me.txtNumero_factura_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNumero_factura_1
        '
        Me.txtNumero_factura_1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero_factura_1.Location = New System.Drawing.Point(754, 9)
        Me.txtNumero_factura_1.MaxLength = 4
        Me.txtNumero_factura_1.Name = "txtNumero_factura_1"
        Me.txtNumero_factura_1.Size = New System.Drawing.Size(72, 20)
        Me.txtNumero_factura_1.TabIndex = 7
        Me.txtNumero_factura_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtpFecha_factura
        '
        Me.dtpFecha_factura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha_factura.Location = New System.Drawing.Point(590, 28)
        Me.dtpFecha_factura.Name = "dtpFecha_factura"
        Me.dtpFecha_factura.Size = New System.Drawing.Size(100, 20)
        Me.dtpFecha_factura.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(496, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 636
        Me.Label3.Text = "Fecha de factura"
        '
        'lblid_cliente
        '
        Me.lblid_cliente.AutoSize = True
        Me.lblid_cliente.BackColor = System.Drawing.Color.Red
        Me.lblid_cliente.Location = New System.Drawing.Point(310, 31)
        Me.lblid_cliente.Name = "lblid_cliente"
        Me.lblid_cliente.Size = New System.Drawing.Size(13, 13)
        Me.lblid_cliente.TabIndex = 635
        Me.lblid_cliente.Text = "0"
        Me.lblid_cliente.Visible = False
        '
        'btnBuscaCliente
        '
        Me.btnBuscaCliente.Cursor = System.Windows.Forms.Cursors.Hand
        ' Me.btnBuscaCliente.Image = Global.Pymen.My.Resources.Resources.Buscar16
        Me.btnBuscaCliente.Location = New System.Drawing.Point(406, 27)
        Me.btnBuscaCliente.Name = "btnBuscaCliente"
        Me.btnBuscaCliente.Size = New System.Drawing.Size(26, 21)
        Me.btnBuscaCliente.TabIndex = 40
        Me.btnBuscaCliente.UseVisualStyleBackColor = True
        '
        'cmbCliente
        '
        Me.cmbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Location = New System.Drawing.Point(101, 27)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(299, 21)
        Me.cmbCliente.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(56, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 633
        Me.Label1.Text = "Cliente"
        '
        'txtImporte
        '
        Me.txtImporte.BackColor = System.Drawing.SystemColors.Info
        Me.txtImporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporte.Location = New System.Drawing.Point(847, 230)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.ReadOnly = True
        Me.txtImporte.Size = New System.Drawing.Size(121, 26)
        Me.txtImporte.TabIndex = 14
        Me.txtImporte.TabStop = False
        Me.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPrecio_item
        '
        Me.txtPrecio_item.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrecio_item.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio_item.Location = New System.Drawing.Point(689, 230)
        Me.txtPrecio_item.Name = "txtPrecio_item"
        Me.txtPrecio_item.Size = New System.Drawing.Size(121, 26)
        Me.txtPrecio_item.TabIndex = 28
        Me.txtPrecio_item.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDescripcion_item
        '
        Me.txtDescripcion_item.Location = New System.Drawing.Point(183, 230)
        Me.txtDescripcion_item.Multiline = True
        Me.txtDescripcion_item.Name = "txtDescripcion_item"
        Me.txtDescripcion_item.Size = New System.Drawing.Size(472, 273)
        Me.txtDescripcion_item.TabIndex = 27
        '
        'txtCantidad_item
        '
        Me.txtCantidad_item.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCantidad_item.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad_item.Location = New System.Drawing.Point(85, 225)
        Me.txtCantidad_item.Name = "txtCantidad_item"
        Me.txtCantidad_item.Size = New System.Drawing.Size(82, 20)
        Me.txtCantidad_item.TabIndex = 26
        Me.txtCantidad_item.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(846, 201)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 13)
        Me.Label12.TabIndex = 669
        Me.Label12.Text = "Importe"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(689, 201)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 13)
        Me.Label11.TabIndex = 668
        Me.Label11.Text = "Precio Unitario"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(183, 201)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(472, 21)
        Me.Label10.TabIndex = 667
        Me.Label10.Text = "Descripción"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(85, 205)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 666
        Me.Label9.Text = "Cantidad"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.BackColor = System.Drawing.SystemColors.Info
        Me.txtSubtotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubtotal.ForeColor = System.Drawing.Color.Green
        Me.txtSubtotal.Location = New System.Drawing.Point(784, 448)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.ReadOnly = True
        Me.txtSubtotal.Size = New System.Drawing.Size(185, 31)
        Me.txtSubtotal.TabIndex = 664
        Me.txtSubtotal.TabStop = False
        Me.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(720, 461)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 665
        Me.Label5.Text = "SubTotal"
        '
        'txtIva
        '
        Me.txtIva.BackColor = System.Drawing.SystemColors.Info
        Me.txtIva.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIva.ForeColor = System.Drawing.Color.Green
        Me.txtIva.Location = New System.Drawing.Point(784, 485)
        Me.txtIva.Name = "txtIva"
        Me.txtIva.ReadOnly = True
        Me.txtIva.Size = New System.Drawing.Size(185, 31)
        Me.txtIva.TabIndex = 662
        Me.txtIva.TabStop = False
        Me.txtIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(748, 497)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 13)
        Me.Label4.TabIndex = 663
        Me.Label4.Text = "Iva"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.SystemColors.Info
        Me.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.Green
        Me.txtTotal.Location = New System.Drawing.Point(784, 523)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(185, 31)
        Me.txtTotal.TabIndex = 660
        Me.txtTotal.TabStop = False
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(741, 533)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 661
        Me.Label7.Text = "Total"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(30, 187)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(939, 10)
        Me.GroupBox1.TabIndex = 670
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(29, 561)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(939, 10)
        Me.GroupBox2.TabIndex = 671
        Me.GroupBox2.TabStop = False
        '
        'txtTotal_letra
        '
        Me.txtTotal_letra.BackColor = System.Drawing.SystemColors.Info
        Me.txtTotal_letra.Location = New System.Drawing.Point(183, 535)
        Me.txtTotal_letra.Name = "txtTotal_letra"
        Me.txtTotal_letra.ReadOnly = True
        Me.txtTotal_letra.Size = New System.Drawing.Size(472, 20)
        Me.txtTotal_letra.TabIndex = 672
        Me.txtTotal_letra.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(111, 538)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 13)
        Me.Label13.TabIndex = 673
        Me.Label13.Text = "Son Pesos:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(64, 72)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 13)
        Me.Label14.TabIndex = 683
        Me.Label14.Text = "Tipo"
        '
        'rbnND
        '
        Me.rbnND.AutoSize = True
        Me.rbnND.ForeColor = System.Drawing.Color.Black
        Me.rbnND.Location = New System.Drawing.Point(269, 70)
        Me.rbnND.Name = "rbnND"
        Me.rbnND.Size = New System.Drawing.Size(97, 17)
        Me.rbnND.TabIndex = 11
        Me.rbnND.Text = "Nota de Débito"
        Me.rbnND.UseVisualStyleBackColor = True
        '
        'rbnNC
        '
        Me.rbnNC.AutoSize = True
        Me.rbnNC.ForeColor = System.Drawing.Color.Black
        Me.rbnNC.Location = New System.Drawing.Point(173, 70)
        Me.rbnNC.Name = "rbnNC"
        Me.rbnNC.Size = New System.Drawing.Size(99, 17)
        Me.rbnNC.TabIndex = 10
        Me.rbnNC.Text = "Nota de Crédito"
        Me.rbnNC.UseVisualStyleBackColor = True
        '
        'rbnFactura
        '
        Me.rbnFactura.AutoSize = True
        Me.rbnFactura.Checked = True
        Me.rbnFactura.ForeColor = System.Drawing.Color.Black
        Me.rbnFactura.Location = New System.Drawing.Point(106, 70)
        Me.rbnFactura.Name = "rbnFactura"
        Me.rbnFactura.Size = New System.Drawing.Size(61, 17)
        Me.rbnFactura.TabIndex = 9
        Me.rbnFactura.TabStop = True
        Me.rbnFactura.Text = "Factura"
        Me.rbnFactura.UseVisualStyleBackColor = True
        '
        'txtImpuesto
        '
        Me.txtImpuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpuesto.Location = New System.Drawing.Point(768, 98)
        Me.txtImpuesto.Name = "txtImpuesto"
        Me.txtImpuesto.Size = New System.Drawing.Size(199, 21)
        Me.txtImpuesto.TabIndex = 21
        Me.txtImpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbnResponsable_no_inscripto)
        Me.GroupBox3.Controls.Add(Me.rbnResponsable_inscripto)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(465, 137)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(210, 37)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Situación Iva"
        '
        'rbnResponsable_no_inscripto
        '
        Me.rbnResponsable_no_inscripto.AutoSize = True
        Me.rbnResponsable_no_inscripto.ForeColor = System.Drawing.Color.Black
        Me.rbnResponsable_no_inscripto.Location = New System.Drawing.Point(107, 14)
        Me.rbnResponsable_no_inscripto.Name = "rbnResponsable_no_inscripto"
        Me.rbnResponsable_no_inscripto.Size = New System.Drawing.Size(94, 17)
        Me.rbnResponsable_no_inscripto.TabIndex = 20
        Me.rbnResponsable_no_inscripto.Text = "Resp. no Insc."
        Me.rbnResponsable_no_inscripto.UseVisualStyleBackColor = True
        '
        'rbnResponsable_inscripto
        '
        Me.rbnResponsable_inscripto.AutoSize = True
        Me.rbnResponsable_inscripto.Checked = True
        Me.rbnResponsable_inscripto.ForeColor = System.Drawing.Color.Black
        Me.rbnResponsable_inscripto.Location = New System.Drawing.Point(17, 14)
        Me.rbnResponsable_inscripto.Name = "rbnResponsable_inscripto"
        Me.rbnResponsable_inscripto.Size = New System.Drawing.Size(76, 17)
        Me.rbnResponsable_inscripto.TabIndex = 19
        Me.rbnResponsable_inscripto.TabStop = True
        Me.rbnResponsable_inscripto.Text = "Resp. Insc"
        Me.rbnResponsable_inscripto.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(704, 72)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 13)
        Me.Label16.TabIndex = 695
        Me.Label16.Text = "Remito"
        '
        'txtNumero_remito_2
        '
        Me.txtNumero_remito_2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero_remito_2.Location = New System.Drawing.Point(832, 69)
        Me.txtNumero_remito_2.MaxLength = 8
        Me.txtNumero_remito_2.Name = "txtNumero_remito_2"
        Me.txtNumero_remito_2.Size = New System.Drawing.Size(135, 20)
        Me.txtNumero_remito_2.TabIndex = 14
        Me.txtNumero_remito_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNumero_remito_1
        '
        Me.txtNumero_remito_1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero_remito_1.Location = New System.Drawing.Point(754, 69)
        Me.txtNumero_remito_1.MaxLength = 4
        Me.txtNumero_remito_1.Name = "txtNumero_remito_1"
        Me.txtNumero_remito_1.Size = New System.Drawing.Size(72, 20)
        Me.txtNumero_remito_1.TabIndex = 13
        Me.txtNumero_remito_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rbnCheque)
        Me.GroupBox4.Controls.Add(Me.rbnTarjeta)
        Me.GroupBox4.Controls.Add(Me.rbnCuenta_corriente)
        Me.GroupBox4.Controls.Add(Me.rbnContado)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(29, 123)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(429, 60)
        Me.GroupBox4.TabIndex = 15
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Condición de Venta"
        '
        'rbnCheque
        '
        Me.rbnCheque.AutoSize = True
        Me.rbnCheque.ForeColor = System.Drawing.Color.Black
        Me.rbnCheque.Location = New System.Drawing.Point(334, 15)
        Me.rbnCheque.Name = "rbnCheque"
        Me.rbnCheque.Size = New System.Drawing.Size(62, 17)
        Me.rbnCheque.TabIndex = 19
        Me.rbnCheque.Text = "Cheque"
        Me.rbnCheque.UseVisualStyleBackColor = True
        '
        'rbnTarjeta
        '
        Me.rbnTarjeta.AutoSize = True
        Me.rbnTarjeta.ForeColor = System.Drawing.Color.Black
        Me.rbnTarjeta.Location = New System.Drawing.Point(246, 15)
        Me.rbnTarjeta.Name = "rbnTarjeta"
        Me.rbnTarjeta.Size = New System.Drawing.Size(58, 17)
        Me.rbnTarjeta.TabIndex = 18
        Me.rbnTarjeta.Text = "Tarjeta"
        Me.rbnTarjeta.UseVisualStyleBackColor = True
        '
        'rbnCuenta_corriente
        '
        Me.rbnCuenta_corriente.AutoSize = True
        Me.rbnCuenta_corriente.ForeColor = System.Drawing.Color.Black
        Me.rbnCuenta_corriente.Location = New System.Drawing.Point(114, 14)
        Me.rbnCuenta_corriente.Name = "rbnCuenta_corriente"
        Me.rbnCuenta_corriente.Size = New System.Drawing.Size(104, 17)
        Me.rbnCuenta_corriente.TabIndex = 17
        Me.rbnCuenta_corriente.Text = "Cuenta Corriente"
        Me.rbnCuenta_corriente.UseVisualStyleBackColor = True
        '
        'rbnContado
        '
        Me.rbnContado.AutoSize = True
        Me.rbnContado.Checked = True
        Me.rbnContado.ForeColor = System.Drawing.Color.Black
        Me.rbnContado.Location = New System.Drawing.Point(21, 13)
        Me.rbnContado.Name = "rbnContado"
        Me.rbnContado.Size = New System.Drawing.Size(65, 17)
        Me.rbnContado.TabIndex = 16
        Me.rbnContado.TabStop = True
        Me.rbnContado.Text = "Contado"
        Me.rbnContado.UseVisualStyleBackColor = True
        '
        'txtCondicion_pago
        '
        Me.txtCondicion_pago.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCondicion_pago.Location = New System.Drawing.Point(36, 157)
        Me.txtCondicion_pago.Name = "txtCondicion_pago"
        Me.txtCondicion_pago.Size = New System.Drawing.Size(407, 21)
        Me.txtCondicion_pago.TabIndex = 18
        '
        'txtReferencia
        '
        Me.txtReferencia.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferencia.Location = New System.Drawing.Point(768, 99)
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(200, 21)
        Me.txtReferencia.TabIndex = 697
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.Control
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(700, 106)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(62, 13)
        Me.Label17.TabIndex = 698
        Me.Label17.Text = "Referencia:"
        '
        'txtcomprobante
        '
        Me.txtcomprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcomprobante.Location = New System.Drawing.Point(754, 39)
        Me.txtcomprobante.Name = "txtcomprobante"
        Me.txtcomprobante.Size = New System.Drawing.Size(209, 22)
        Me.txtcomprobante.TabIndex = 699
        Me.txtcomprobante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNro_Item
        '
        Me.txtNro_Item.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNro_Item.Location = New System.Drawing.Point(4, 225)
        Me.txtNro_Item.Name = "txtNro_Item"
        Me.txtNro_Item.Size = New System.Drawing.Size(75, 20)
        Me.txtNro_Item.TabIndex = 25
        Me.txtNro_Item.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.SystemColors.Control
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(4, 201)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(27, 13)
        Me.Label18.TabIndex = 701
        Me.Label18.Text = "Item"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rbnRetencion
        '
        Me.rbnRetencion.AutoSize = True
        Me.rbnRetencion.ForeColor = System.Drawing.Color.Black
        Me.rbnRetencion.Location = New System.Drawing.Point(368, 70)
        Me.rbnRetencion.Name = "rbnRetencion"
        Me.rbnRetencion.Size = New System.Drawing.Size(74, 17)
        Me.rbnRetencion.TabIndex = 702
        Me.rbnRetencion.Text = "Retencion"
        Me.rbnRetencion.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.SystemColors.Control
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(28, 99)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(98, 13)
        Me.Label19.TabIndex = 704
        Me.Label19.Text = "Valor de Retencion"
        '
        'txtRetencion
        '
        Me.txtRetencion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRetencion.Location = New System.Drawing.Point(132, 96)
        Me.txtRetencion.MaxLength = 50
        Me.txtRetencion.Name = "txtRetencion"
        Me.txtRetencion.Size = New System.Drawing.Size(101, 20)
        Me.txtRetencion.TabIndex = 703
        Me.txtRetencion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_certificado
        '
        Me.txt_certificado.Location = New System.Drawing.Point(590, 105)
        Me.txt_certificado.Name = "txt_certificado"
        Me.txt_certificado.Size = New System.Drawing.Size(76, 20)
        Me.txt_certificado.TabIndex = 708
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(507, 112)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 13)
        Me.Label15.TabIndex = 707
        Me.Label15.Text = "Nro Certificado"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(474, 58)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(113, 13)
        Me.Label20.TabIndex = 705
        Me.Label20.Text = "Fecha de Vencimiento"
        '
        'dtpFechaVen
        '
        Me.dtpFechaVen.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaVen.Location = New System.Drawing.Point(590, 54)
        Me.dtpFechaVen.Name = "dtpFechaVen"
        Me.dtpFechaVen.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaVen.TabIndex = 709
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(590, 1)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(100, 20)
        Me.dtpFecha.TabIndex = 710
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.SystemColors.Control
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(464, 5)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(120, 13)
        Me.Label21.TabIndex = 711
        Me.Label21.Text = "Fecha Movimiento (IVA)"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(698, 147)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(46, 13)
        Me.Label22.TabIndex = 713
        Me.Label22.Text = "Moneda"
        '
        'lblid_moneda
        '
        Me.lblid_moneda.AutoSize = True
        Me.lblid_moneda.BackColor = System.Drawing.Color.Red
        Me.lblid_moneda.Location = New System.Drawing.Point(831, 149)
        Me.lblid_moneda.Name = "lblid_moneda"
        Me.lblid_moneda.Size = New System.Drawing.Size(13, 13)
        Me.lblid_moneda.TabIndex = 716
        Me.lblid_moneda.Text = "0"
        Me.lblid_moneda.Visible = False
        '
        'cmbMoneda
        '
        Me.cmbMoneda.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbMoneda.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbMoneda.FormattingEnabled = True
        Me.cmbMoneda.Location = New System.Drawing.Point(754, 145)
        Me.cmbMoneda.Name = "cmbMoneda"
        Me.cmbMoneda.Size = New System.Drawing.Size(184, 21)
        Me.cmbMoneda.TabIndex = 714
        '
        'frmDetalleFactura2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 686)
        Me.Controls.Add(Me.txtCondicion_pago)
        Me.Controls.Add(Me.lblid_moneda)
        Me.Controls.Add(Me.cmbMoneda)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.dtpFechaVen)
        Me.Controls.Add(Me.txt_certificado)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtRetencion)
        Me.Controls.Add(Me.rbnRetencion)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtNro_Item)
        Me.Controls.Add(Me.txtcomprobante)
        Me.Controls.Add(Me.txtReferencia)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtImpuesto)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtNumero_remito_2)
        Me.Controls.Add(Me.txtNumero_remito_1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.rbnND)
        Me.Controls.Add(Me.rbnNC)
        Me.Controls.Add(Me.rbnFactura)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtTotal_letra)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtImporte)
        Me.Controls.Add(Me.txtPrecio_item)
        Me.Controls.Add(Me.txtDescripcion_item)
        Me.Controls.Add(Me.txtCantidad_item)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtIva)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtIva_factura)
        Me.Controls.Add(Me.txtTipo)
        Me.Controls.Add(Me.lblid_factura)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lblid_pk)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNumero_factura_2)
        Me.Controls.Add(Me.txtNumero_factura_1)
        Me.Controls.Add(Me.dtpFecha_factura)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblid_cliente)
        Me.Controls.Add(Me.btnBuscaCliente)
        Me.Controls.Add(Me.cmbCliente)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDetalleFactura2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Factura Global"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ttBorrar As System.Windows.Forms.ToolTip
    Friend WithEvents ttSalir As System.Windows.Forms.ToolTip
    Friend WithEvents ttModificar As System.Windows.Forms.ToolTip
    Friend WithEvents ttAgregar As System.Windows.Forms.ToolTip
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ttCliente As System.Windows.Forms.ToolTip
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtIva_factura As System.Windows.Forms.TextBox
    Friend WithEvents ttGuardar As System.Windows.Forms.ToolTip
    Friend WithEvents txtTipo As System.Windows.Forms.TextBox
    Friend WithEvents lblid_factura As System.Windows.Forms.Label
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents lblid_pk As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNumero_factura_2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNumero_factura_1 As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha_factura As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblid_cliente As System.Windows.Forms.Label
    Friend WithEvents btnBuscaCliente As System.Windows.Forms.Button
    Friend WithEvents cmbCliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtImporte As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecio_item As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion_item As System.Windows.Forms.TextBox
    Friend WithEvents txtCantidad_item As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtIva As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ttImprimir As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTotal_letra As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents rbnND As System.Windows.Forms.RadioButton
    Friend WithEvents rbnNC As System.Windows.Forms.RadioButton
    Friend WithEvents rbnFactura As System.Windows.Forms.RadioButton
    Friend WithEvents txtImpuesto As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rbnResponsable_no_inscripto As System.Windows.Forms.RadioButton
    Friend WithEvents rbnResponsable_inscripto As System.Windows.Forms.RadioButton
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtNumero_remito_2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNumero_remito_1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rbnCuenta_corriente As System.Windows.Forms.RadioButton
    Friend WithEvents rbnContado As System.Windows.Forms.RadioButton
    Friend WithEvents txtCondicion_pago As System.Windows.Forms.TextBox
    Friend WithEvents txtReferencia As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtcomprobante As System.Windows.Forms.TextBox
    Friend WithEvents txtNro_Item As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents rbnRetencion As System.Windows.Forms.RadioButton
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtRetencion As System.Windows.Forms.TextBox
    Friend WithEvents txt_certificado As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaVen As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents lblid_moneda As System.Windows.Forms.Label
    Friend WithEvents cmbMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents rbnCheque As System.Windows.Forms.RadioButton
    Friend WithEvents rbnTarjeta As System.Windows.Forms.RadioButton
End Class
