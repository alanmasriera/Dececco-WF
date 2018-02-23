<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleFacturaExporta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleFacturaExporta))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.txtcomprobante = New System.Windows.Forms.TextBox
        Me.ttImprimir = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.rbnCuenta_corriente = New System.Windows.Forms.RadioButton
        Me.txtCuenta = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.rbnND = New System.Windows.Forms.RadioButton
        Me.rbnNC = New System.Windows.Forms.RadioButton
        Me.rbnFactura = New System.Windows.Forms.RadioButton
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtTotal_letra = New System.Windows.Forms.TextBox
        Me.txtCondicion_pago = New System.Windows.Forms.TextBox
        Me.btnBorrar = New System.Windows.Forms.Button
        Me.txtSubtotal = New System.Windows.Forms.TextBox
        Me.rbnContado = New System.Windows.Forms.RadioButton
        Me.btnModificar = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblid_cliente = New System.Windows.Forms.Label
        Me.btnBuscaCliente = New System.Windows.Forms.Button
        Me.cmbCliente = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbnTarjeta = New System.Windows.Forms.RadioButton
        Me.rbnCheque = New System.Windows.Forms.RadioButton
        Me.txtIva = New System.Windows.Forms.TextBox
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.dgv1 = New System.Windows.Forms.DataGridView
        Me.Label6 = New System.Windows.Forms.Label
        Me.ttAgregar = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label8 = New System.Windows.Forms.Label
        Me.dtpFecha_factura = New System.Windows.Forms.DateTimePicker
        Me.ttBorrar = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttSalir = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttCliente = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttGuardar = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttModificar = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtTpte = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtEmbarque = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtDesembarque = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtDestino = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtPeso_bruto = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtPeso_neto = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtCajas = New System.Windows.Forms.TextBox
        Me.txtOrigen = New System.Windows.Forms.TextBox
        Me.txtZona = New System.Windows.Forms.TextBox
        Me.txtNro_orden = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtcomprobante
        '
        Me.txtcomprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcomprobante.Location = New System.Drawing.Point(782, 35)
        Me.txtcomprobante.Name = "txtcomprobante"
        Me.txtcomprobante.Size = New System.Drawing.Size(209, 22)
        Me.txtcomprobante.TabIndex = 737
        Me.txtcomprobante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(488, 111)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 21)
        Me.Label12.TabIndex = 736
        Me.Label12.Text = "Zona:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(478, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 13)
        Me.Label10.TabIndex = 734
        Me.Label10.Text = "Nº Orden:"
        '
        'rbnCuenta_corriente
        '
        Me.rbnCuenta_corriente.AutoSize = True
        Me.rbnCuenta_corriente.ForeColor = System.Drawing.Color.Black
        Me.rbnCuenta_corriente.Location = New System.Drawing.Point(118, 14)
        Me.rbnCuenta_corriente.Name = "rbnCuenta_corriente"
        Me.rbnCuenta_corriente.Size = New System.Drawing.Size(104, 17)
        Me.rbnCuenta_corriente.TabIndex = 17
        Me.rbnCuenta_corriente.Text = "Cuenta Corriente"
        Me.rbnCuenta_corriente.UseVisualStyleBackColor = True
        '
        'txtCuenta
        '
        Me.txtCuenta.AcceptsReturn = True
        Me.txtCuenta.AcceptsTab = True
        Me.txtCuenta.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuenta.Location = New System.Drawing.Point(538, 142)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(209, 21)
        Me.txtCuenta.TabIndex = 7
        Me.txtCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(488, 150)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 735
        Me.Label11.Text = "Cuenta:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(10, 86)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 13)
        Me.Label9.TabIndex = 733
        Me.Label9.Text = "Tipo"
        '
        'rbnND
        '
        Me.rbnND.AutoSize = True
        Me.rbnND.ForeColor = System.Drawing.Color.Black
        Me.rbnND.Location = New System.Drawing.Point(315, 86)
        Me.rbnND.Name = "rbnND"
        Me.rbnND.Size = New System.Drawing.Size(97, 17)
        Me.rbnND.TabIndex = 703
        Me.rbnND.Text = "Nota de Débito"
        Me.rbnND.UseVisualStyleBackColor = True
        '
        'rbnNC
        '
        Me.rbnNC.AutoSize = True
        Me.rbnNC.ForeColor = System.Drawing.Color.Black
        Me.rbnNC.Location = New System.Drawing.Point(187, 86)
        Me.rbnNC.Name = "rbnNC"
        Me.rbnNC.Size = New System.Drawing.Size(99, 17)
        Me.rbnNC.TabIndex = 702
        Me.rbnNC.Text = "Nota de Crédito"
        Me.rbnNC.UseVisualStyleBackColor = True
        '
        'rbnFactura
        '
        Me.rbnFactura.AutoSize = True
        Me.rbnFactura.Checked = True
        Me.rbnFactura.ForeColor = System.Drawing.Color.Black
        Me.rbnFactura.Location = New System.Drawing.Point(97, 86)
        Me.rbnFactura.Name = "rbnFactura"
        Me.rbnFactura.Size = New System.Drawing.Size(61, 17)
        Me.rbnFactura.TabIndex = 701
        Me.rbnFactura.TabStop = True
        Me.rbnFactura.Text = "Factura"
        Me.rbnFactura.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(12, 558)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 21)
        Me.Label13.TabIndex = 732
        Me.Label13.Text = "Son Euros:"
        '
        'txtTotal_letra
        '
        Me.txtTotal_letra.BackColor = System.Drawing.SystemColors.Info
        Me.txtTotal_letra.Location = New System.Drawing.Point(104, 560)
        Me.txtTotal_letra.Name = "txtTotal_letra"
        Me.txtTotal_letra.ReadOnly = True
        Me.txtTotal_letra.Size = New System.Drawing.Size(755, 20)
        Me.txtTotal_letra.TabIndex = 731
        Me.txtTotal_letra.TabStop = False
        '
        'txtCondicion_pago
        '
        Me.txtCondicion_pago.AcceptsReturn = True
        Me.txtCondicion_pago.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCondicion_pago.Location = New System.Drawing.Point(6, 33)
        Me.txtCondicion_pago.Name = "txtCondicion_pago"
        Me.txtCondicion_pago.Size = New System.Drawing.Size(407, 21)
        Me.txtCondicion_pago.TabIndex = 10
        '
        'btnBorrar
        '
        Me.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar.Image = CType(resources.GetObject("btnBorrar.Image"), System.Drawing.Image)
        Me.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBorrar.Location = New System.Drawing.Point(889, 470)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(86, 71)
        Me.btnBorrar.TabIndex = 711
        Me.btnBorrar.Text = "&Borrar"
        Me.btnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'txtSubtotal
        '
        Me.txtSubtotal.BackColor = System.Drawing.SystemColors.Info
        Me.txtSubtotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubtotal.ForeColor = System.Drawing.Color.Green
        Me.txtSubtotal.Location = New System.Drawing.Point(674, 596)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.ReadOnly = True
        Me.txtSubtotal.Size = New System.Drawing.Size(185, 31)
        Me.txtSubtotal.TabIndex = 729
        Me.txtSubtotal.TabStop = False
        Me.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'rbnContado
        '
        Me.rbnContado.AutoSize = True
        Me.rbnContado.Checked = True
        Me.rbnContado.ForeColor = System.Drawing.Color.Black
        Me.rbnContado.Location = New System.Drawing.Point(21, 14)
        Me.rbnContado.Name = "rbnContado"
        Me.rbnContado.Size = New System.Drawing.Size(65, 17)
        Me.rbnContado.TabIndex = 16
        Me.rbnContado.TabStop = True
        Me.rbnContado.Text = "Contado"
        Me.rbnContado.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModificar.Location = New System.Drawing.Point(890, 368)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(86, 71)
        Me.btnModificar.TabIndex = 710
        Me.btnModificar.Text = "&Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(580, 596)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 21)
        Me.Label5.TabIndex = 730
        Me.Label5.Text = "SubTotal"
        '
        'txtTipo
        '
        Me.txtTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipo.Location = New System.Drawing.Point(54, 7)
        Me.txtTipo.MaxLength = 4
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(72, 20)
        Me.txtTipo.TabIndex = 700
        Me.txtTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTipo.Visible = False
        '
        'lblid_factura
        '
        Me.lblid_factura.AutoSize = True
        Me.lblid_factura.BackColor = System.Drawing.Color.Red
        Me.lblid_factura.ForeColor = System.Drawing.Color.Yellow
        Me.lblid_factura.Location = New System.Drawing.Point(6, 64)
        Me.lblid_factura.Name = "lblid_factura"
        Me.lblid_factura.Size = New System.Drawing.Size(13, 13)
        Me.lblid_factura.TabIndex = 722
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
        Me.btnImprimir.Location = New System.Drawing.Point(250, 633)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(81, 69)
        Me.btnImprimir.TabIndex = 713
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
        Me.btnNuevo.Location = New System.Drawing.Point(37, 633)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(78, 69)
        Me.btnNuevo.TabIndex = 714
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
        Me.btnSalir.Location = New System.Drawing.Point(387, 633)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(81, 69)
        Me.btnSalir.TabIndex = 715
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
        Me.btnGuardar.Location = New System.Drawing.Point(166, 633)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(78, 69)
        Me.btnGuardar.TabIndex = 712
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'lblid_pk
        '
        Me.lblid_pk.AutoSize = True
        Me.lblid_pk.BackColor = System.Drawing.Color.Red
        Me.lblid_pk.ForeColor = System.Drawing.Color.Yellow
        Me.lblid_pk.Location = New System.Drawing.Point(38, 64)
        Me.lblid_pk.Name = "lblid_pk"
        Me.lblid_pk.Size = New System.Drawing.Size(13, 13)
        Me.lblid_pk.TabIndex = 721
        Me.lblid_pk.Text = "0"
        Me.lblid_pk.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(732, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 720
        Me.Label2.Text = "Número"
        '
        'txtNumero_factura_2
        '
        Me.txtNumero_factura_2.AcceptsReturn = True
        Me.txtNumero_factura_2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero_factura_2.Location = New System.Drawing.Point(860, 7)
        Me.txtNumero_factura_2.MaxLength = 8
        Me.txtNumero_factura_2.Name = "txtNumero_factura_2"
        Me.txtNumero_factura_2.Size = New System.Drawing.Size(135, 20)
        Me.txtNumero_factura_2.TabIndex = 4
        Me.txtNumero_factura_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNumero_factura_1
        '
        Me.txtNumero_factura_1.AcceptsReturn = True
        Me.txtNumero_factura_1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero_factura_1.Location = New System.Drawing.Point(782, 7)
        Me.txtNumero_factura_1.MaxLength = 4
        Me.txtNumero_factura_1.Name = "txtNumero_factura_1"
        Me.txtNumero_factura_1.Size = New System.Drawing.Size(72, 20)
        Me.txtNumero_factura_1.TabIndex = 3
        Me.txtNumero_factura_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(495, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 719
        Me.Label3.Text = "Fecha"
        '
        'lblid_cliente
        '
        Me.lblid_cliente.AutoSize = True
        Me.lblid_cliente.BackColor = System.Drawing.Color.Red
        Me.lblid_cliente.Location = New System.Drawing.Point(290, 47)
        Me.lblid_cliente.Name = "lblid_cliente"
        Me.lblid_cliente.Size = New System.Drawing.Size(13, 13)
        Me.lblid_cliente.TabIndex = 718
        Me.lblid_cliente.Text = "0"
        Me.lblid_cliente.Visible = False
        '
        'btnBuscaCliente
        '
        Me.btnBuscaCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscaCliente.Image = CType(resources.GetObject("btnBuscaCliente.Image"), System.Drawing.Image)
        Me.btnBuscaCliente.Location = New System.Drawing.Point(359, 35)
        Me.btnBuscaCliente.Name = "btnBuscaCliente"
        Me.btnBuscaCliente.Size = New System.Drawing.Size(41, 36)
        Me.btnBuscaCliente.TabIndex = 717
        Me.btnBuscaCliente.UseVisualStyleBackColor = True
        '
        'cmbCliente
        '
        Me.cmbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Location = New System.Drawing.Point(54, 43)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(299, 21)
        Me.cmbCliente.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 21)
        Me.Label1.TabIndex = 716
        Me.Label1.Text = "Cliente"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbnTarjeta)
        Me.GroupBox1.Controls.Add(Me.rbnCheque)
        Me.GroupBox1.Controls.Add(Me.txtCondicion_pago)
        Me.GroupBox1.Controls.Add(Me.rbnCuenta_corriente)
        Me.GroupBox1.Controls.Add(Me.rbnContado)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(10, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(419, 60)
        Me.GroupBox1.TabIndex = 705
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Condición de Venta"
        '
        'rbnTarjeta
        '
        Me.rbnTarjeta.AutoSize = True
        Me.rbnTarjeta.ForeColor = System.Drawing.Color.Black
        Me.rbnTarjeta.Location = New System.Drawing.Point(253, 14)
        Me.rbnTarjeta.Name = "rbnTarjeta"
        Me.rbnTarjeta.Size = New System.Drawing.Size(58, 17)
        Me.rbnTarjeta.TabIndex = 21
        Me.rbnTarjeta.Text = "Tarjeta"
        Me.rbnTarjeta.UseVisualStyleBackColor = True
        '
        'rbnCheque
        '
        Me.rbnCheque.AutoSize = True
        Me.rbnCheque.ForeColor = System.Drawing.Color.Black
        Me.rbnCheque.Location = New System.Drawing.Point(340, 14)
        Me.rbnCheque.Name = "rbnCheque"
        Me.rbnCheque.Size = New System.Drawing.Size(62, 17)
        Me.rbnCheque.TabIndex = 20
        Me.rbnCheque.Text = "Cheque"
        Me.rbnCheque.UseVisualStyleBackColor = True
        '
        'txtIva
        '
        Me.txtIva.BackColor = System.Drawing.SystemColors.Info
        Me.txtIva.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIva.ForeColor = System.Drawing.Color.Green
        Me.txtIva.Location = New System.Drawing.Point(674, 633)
        Me.txtIva.Name = "txtIva"
        Me.txtIva.ReadOnly = True
        Me.txtIva.Size = New System.Drawing.Size(185, 31)
        Me.txtIva.TabIndex = 727
        Me.txtIva.TabStop = False
        Me.txtIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnAgregar
        '
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAgregar.Location = New System.Drawing.Point(889, 264)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(86, 71)
        Me.btnAgregar.TabIndex = 17
        Me.btnAgregar.Text = "&Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(580, 633)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 21)
        Me.Label4.TabIndex = 728
        Me.Label4.Text = "Iva"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.SystemColors.Info
        Me.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.Green
        Me.txtTotal.Location = New System.Drawing.Point(674, 671)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(185, 31)
        Me.txtTotal.TabIndex = 725
        Me.txtTotal.TabStop = False
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(580, 671)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 21)
        Me.Label7.TabIndex = 726
        Me.Label7.Text = "Total"
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Brown
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv1.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.dgv1.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Beige
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Brown
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv1.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv1.GridColor = System.Drawing.Color.MediumPurple
        Me.dgv1.Location = New System.Drawing.Point(12, 254)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.ShowCellErrors = False
        Me.dgv1.ShowRowErrors = False
        Me.dgv1.Size = New System.Drawing.Size(847, 287)
        Me.dgv1.StandardTab = True
        Me.dgv1.TabIndex = 709
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(20, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 724
        Me.Label6.Text = "Tipo"
        Me.Label6.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(816, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 723
        Me.Label8.Text = "Origen"
        '
        'dtpFecha_factura
        '
        Me.dtpFecha_factura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha_factura.Location = New System.Drawing.Point(538, 9)
        Me.dtpFecha_factura.Name = "dtpFecha_factura"
        Me.dtpFecha_factura.Size = New System.Drawing.Size(100, 20)
        Me.dtpFecha_factura.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(791, 114)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 13)
        Me.Label14.TabIndex = 739
        Me.Label14.Text = "Vía Transp:"
        '
        'txtTpte
        '
        Me.txtTpte.AcceptsReturn = True
        Me.txtTpte.Location = New System.Drawing.Point(860, 107)
        Me.txtTpte.MaxLength = 100
        Me.txtTpte.Name = "txtTpte"
        Me.txtTpte.Size = New System.Drawing.Size(144, 20)
        Me.txtTpte.TabIndex = 9
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(10, 179)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 21)
        Me.Label15.TabIndex = 741
        Me.Label15.Text = "Pto. Embarque:"
        '
        'txtEmbarque
        '
        Me.txtEmbarque.AcceptsReturn = True
        Me.txtEmbarque.Location = New System.Drawing.Point(110, 179)
        Me.txtEmbarque.MaxLength = 100
        Me.txtEmbarque.Name = "txtEmbarque"
        Me.txtEmbarque.Size = New System.Drawing.Size(176, 20)
        Me.txtEmbarque.TabIndex = 11
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(370, 186)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(98, 13)
        Me.Label16.TabIndex = 743
        Me.Label16.Text = "Pto. Desembarque:"
        '
        'txtDesembarque
        '
        Me.txtDesembarque.AcceptsReturn = True
        Me.txtDesembarque.Location = New System.Drawing.Point(474, 179)
        Me.txtDesembarque.MaxLength = 100
        Me.txtDesembarque.Name = "txtDesembarque"
        Me.txtDesembarque.Size = New System.Drawing.Size(176, 20)
        Me.txtDesembarque.TabIndex = 12
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.Control
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(698, 187)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 13)
        Me.Label17.TabIndex = 745
        Me.Label17.Text = "Destino :"
        '
        'txtDestino
        '
        Me.txtDestino.AcceptsReturn = True
        Me.txtDestino.Location = New System.Drawing.Point(753, 179)
        Me.txtDestino.MaxLength = 100
        Me.txtDestino.Name = "txtDestino"
        Me.txtDestino.Size = New System.Drawing.Size(251, 20)
        Me.txtDestino.TabIndex = 13
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.SystemColors.Control
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(682, 220)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(65, 13)
        Me.Label18.TabIndex = 751
        Me.Label18.Text = "Peso Bruto :"
        '
        'txtPeso_bruto
        '
        Me.txtPeso_bruto.AcceptsReturn = True
        Me.txtPeso_bruto.Location = New System.Drawing.Point(753, 217)
        Me.txtPeso_bruto.MaxLength = 100
        Me.txtPeso_bruto.Name = "txtPeso_bruto"
        Me.txtPeso_bruto.Size = New System.Drawing.Size(93, 20)
        Me.txtPeso_bruto.TabIndex = 16
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.SystemColors.Control
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(498, 224)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(60, 13)
        Me.Label19.TabIndex = 749
        Me.Label19.Text = "Peso Neto:"
        '
        'txtPeso_neto
        '
        Me.txtPeso_neto.AcceptsReturn = True
        Me.txtPeso_neto.Location = New System.Drawing.Point(564, 217)
        Me.txtPeso_neto.MaxLength = 100
        Me.txtPeso_neto.Name = "txtPeso_neto"
        Me.txtPeso_neto.Size = New System.Drawing.Size(86, 20)
        Me.txtPeso_neto.TabIndex = 15
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.SystemColors.Control
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(10, 217)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(109, 13)
        Me.Label20.TabIndex = 747
        Me.Label20.Text = "Cant. y Tpo. de Cajas"
        '
        'txtCajas
        '
        Me.txtCajas.AcceptsReturn = True
        Me.txtCajas.Location = New System.Drawing.Point(130, 217)
        Me.txtCajas.MaxLength = 100
        Me.txtCajas.Name = "txtCajas"
        Me.txtCajas.Size = New System.Drawing.Size(293, 20)
        Me.txtCajas.TabIndex = 14
        '
        'txtOrigen
        '
        Me.txtOrigen.AcceptsReturn = True
        Me.txtOrigen.Location = New System.Drawing.Point(860, 78)
        Me.txtOrigen.MaxLength = 100
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.Size = New System.Drawing.Size(144, 20)
        Me.txtOrigen.TabIndex = 8
        '
        'txtZona
        '
        Me.txtZona.AcceptsReturn = True
        Me.txtZona.AcceptsTab = True
        Me.txtZona.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZona.Location = New System.Drawing.Point(538, 107)
        Me.txtZona.Name = "txtZona"
        Me.txtZona.Size = New System.Drawing.Size(209, 21)
        Me.txtZona.TabIndex = 6
        '
        'txtNro_orden
        '
        Me.txtNro_orden.AcceptsReturn = True
        Me.txtNro_orden.AcceptsTab = True
        Me.txtNro_orden.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNro_orden.Location = New System.Drawing.Point(538, 74)
        Me.txtNro_orden.Name = "txtNro_orden"
        Me.txtNro_orden.Size = New System.Drawing.Size(209, 21)
        Me.txtNro_orden.TabIndex = 752
        '
        'frmDetalleFacturaExporta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1016, 734)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtNro_orden)
        Me.Controls.Add(Me.txtOrigen)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtPeso_bruto)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtPeso_neto)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtCajas)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtDestino)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtDesembarque)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtEmbarque)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtTpte)
        Me.Controls.Add(Me.txtcomprobante)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtZona)
        Me.Controls.Add(Me.txtCuenta)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.rbnND)
        Me.Controls.Add(Me.rbnNC)
        Me.Controls.Add(Me.rbnFactura)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtTotal_letra)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.Label5)
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
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblid_cliente)
        Me.Controls.Add(Me.btnBuscaCliente)
        Me.Controls.Add(Me.cmbCliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtIva)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtpFecha_factura)
        Me.Name = "frmDetalleFacturaExporta"
        Me.Text = "Factura ""E"""
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtcomprobante As System.Windows.Forms.TextBox
    Friend WithEvents ttImprimir As System.Windows.Forms.ToolTip
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents rbnCuenta_corriente As System.Windows.Forms.RadioButton
    Friend WithEvents txtCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents rbnND As System.Windows.Forms.RadioButton
    Friend WithEvents rbnNC As System.Windows.Forms.RadioButton
    Friend WithEvents rbnFactura As System.Windows.Forms.RadioButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtTotal_letra As System.Windows.Forms.TextBox
    Friend WithEvents txtCondicion_pago As System.Windows.Forms.TextBox
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents txtSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents rbnContado As System.Windows.Forms.RadioButton
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblid_cliente As System.Windows.Forms.Label
    Friend WithEvents btnBuscaCliente As System.Windows.Forms.Button
    Friend WithEvents cmbCliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtIva As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ttAgregar As System.Windows.Forms.ToolTip
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha_factura As System.Windows.Forms.DateTimePicker
    Friend WithEvents ttBorrar As System.Windows.Forms.ToolTip
    Friend WithEvents ttSalir As System.Windows.Forms.ToolTip
    Friend WithEvents ttCliente As System.Windows.Forms.ToolTip
    Friend WithEvents ttGuardar As System.Windows.Forms.ToolTip
    Friend WithEvents ttModificar As System.Windows.Forms.ToolTip
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtTpte As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtEmbarque As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtDesembarque As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtDestino As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtPeso_bruto As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtPeso_neto As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtCajas As System.Windows.Forms.TextBox
    Friend WithEvents txtOrigen As System.Windows.Forms.TextBox
    Friend WithEvents txtZona As System.Windows.Forms.TextBox
    Friend WithEvents txtNro_orden As System.Windows.Forms.TextBox
    Friend WithEvents rbnTarjeta As System.Windows.Forms.RadioButton
    Friend WithEvents rbnCheque As System.Windows.Forms.RadioButton
End Class
