<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleFactura_proveedor
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
       Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleFactura_proveedor))
       Me.btnSalir = New System.Windows.Forms.Button
       Me.btnGuardar = New System.Windows.Forms.Button
       Me.GroupBox1 = New System.Windows.Forms.GroupBox
       Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
       Me.txtnumero_factura = New System.Windows.Forms.TextBox
       Me.etiquetanumero_factura = New System.Windows.Forms.Label
       Me.lblid_empresa = New System.Windows.Forms.Label
       Me.btnBuscaempresa = New System.Windows.Forms.Button
       Me.cmbempresa = New System.Windows.Forms.ComboBox
       Me.etiquetaid_empresa = New System.Windows.Forms.Label
       Me.lblid_tipo_comprobante = New System.Windows.Forms.Label
       Me.btnBuscatipo_comprobante = New System.Windows.Forms.Button
       Me.cmbtipo_comprobante = New System.Windows.Forms.ComboBox
       Me.etiquetaid_tipo_comprobante = New System.Windows.Forms.Label
       Me.dtpfecha = New System.Windows.Forms.DateTimePicker
       Me.etiquetafecha = New System.Windows.Forms.Label
       Me.dtpfecha_factura = New System.Windows.Forms.DateTimePicker
       Me.etiquetafecha_factura = New System.Windows.Forms.Label
       Me.dtpfecha_vencimiento = New System.Windows.Forms.DateTimePicker
       Me.etiquetafecha_vencimiento = New System.Windows.Forms.Label
       Me.lblid_proveedor = New System.Windows.Forms.Label
       Me.btnBuscaproveedor = New System.Windows.Forms.Button
       Me.cmbproveedor = New System.Windows.Forms.ComboBox
       Me.etiquetaid_proveedor = New System.Windows.Forms.Label
       Me.txtobservacion = New System.Windows.Forms.TextBox
       Me.etiquetaobservacion = New System.Windows.Forms.Label
       Me.txtsaldo = New System.Windows.Forms.TextBox
       Me.etiquetasaldo = New System.Windows.Forms.Label
       Me.txtestado = New System.Windows.Forms.TextBox
       Me.etiquetaestado = New System.Windows.Forms.Label
       Me.txtalicuota_iva = New System.Windows.Forms.TextBox
       Me.etiquetaalicuota_iva = New System.Windows.Forms.Label
       Me.txtiva_21 = New System.Windows.Forms.TextBox
       Me.etiquetaiva_21 = New System.Windows.Forms.Label
       Me.txtiva_10_5 = New System.Windows.Forms.TextBox
       Me.etiquetaiva_10_5 = New System.Windows.Forms.Label
       Me.txtimporte_21 = New System.Windows.Forms.TextBox
       Me.etiquetaimporte_21 = New System.Windows.Forms.Label
       Me.txtimporte_10_5 = New System.Windows.Forms.TextBox
       Me.etiquetaimporte_10_5 = New System.Windows.Forms.Label
       Me.txtretencion_iva = New System.Windows.Forms.TextBox
       Me.etiquetaretencion_iva = New System.Windows.Forms.Label
       Me.txtpercepcion_iva = New System.Windows.Forms.TextBox
       Me.etiquetapercepcion_iva = New System.Windows.Forms.Label
       Me.txtretencion_ingreso_bruto = New System.Windows.Forms.TextBox
       Me.etiquetaretencion_ingreso_bruto = New System.Windows.Forms.Label
       Me.txtpercepcion_ingreso_bruto = New System.Windows.Forms.TextBox
       Me.etiquetapercepcion_ingreso_bruto = New System.Windows.Forms.Label
       Me.txtretencion_ganancia = New System.Windows.Forms.TextBox
       Me.etiquetaretencion_ganancia = New System.Windows.Forms.Label
       Me.txtimpuesto_interno = New System.Windows.Forms.TextBox
       Me.etiquetaimpuesto_interno = New System.Windows.Forms.Label
       Me.txtotro = New System.Windows.Forms.TextBox
       Me.etiquetaotro = New System.Windows.Forms.Label
       Me.txttotal_21 = New System.Windows.Forms.TextBox
       Me.etiquetatotal_21 = New System.Windows.Forms.Label
       Me.txttotal_10_5 = New System.Windows.Forms.TextBox
       Me.etiquetatotal_10_5 = New System.Windows.Forms.Label
       Me.txttotal_sin = New System.Windows.Forms.TextBox
       Me.etiquetatotal_sin = New System.Windows.Forms.Label
       Me.txttotal_factura = New System.Windows.Forms.TextBox
       Me.etiquetatotal_factura = New System.Windows.Forms.Label
       Me.lblid_almacen = New System.Windows.Forms.Label
       Me.btnBuscaalmacen = New System.Windows.Forms.Button
       Me.cmbalmacen = New System.Windows.Forms.ComboBox
       Me.etiquetaid_almacen = New System.Windows.Forms.Label
       Me.lblid_cuenta_contable = New System.Windows.Forms.Label
       Me.btnBuscacuenta_contable = New System.Windows.Forms.Button
       Me.cmbcuenta_contable = New System.Windows.Forms.ComboBox
       Me.etiquetaid_cuenta_contable = New System.Windows.Forms.Label
       Me.lblid_usuario = New System.Windows.Forms.Label
       Me.btnBuscausuario = New System.Windows.Forms.Button
       Me.cmbusuario = New System.Windows.Forms.ComboBox
       Me.etiquetaid_usuario = New System.Windows.Forms.Label
       Me.chktilde = New System.Windows.Forms.CheckBox
       Me.etiquetatilde = New System.Windows.Forms.Label
       Me.txtreferencia = New System.Windows.Forms.TextBox
       Me.etiquetareferencia = New System.Windows.Forms.Label
       Me.txtsaldo_factura = New System.Windows.Forms.TextBox
       Me.etiquetasaldo_factura = New System.Windows.Forms.Label
       Me.chkpagada = New System.Windows.Forms.CheckBox
       Me.etiquetapagada = New System.Windows.Forms.Label
       Me.lblnumero_certificado = New System.Windows.Forms.Label
       Me.btnBuscaero_certificado = New System.Windows.Forms.Button
       Me.cmbero_certificado = New System.Windows.Forms.ComboBox
       Me.etiquetanumero_certificado = New System.Windows.Forms.Label
       Me.chkpago_a_cuenta = New System.Windows.Forms.CheckBox
       Me.etiquetapago_a_cuenta = New System.Windows.Forms.Label
       Me.chksin_pago = New System.Windows.Forms.CheckBox
       Me.etiquetasin_pago = New System.Windows.Forms.Label
       Me.SuspendLayout()
       '
       'txtnumero_factura
       '
       Me.txtnumero_factura.BackColor = System.Drawing.Color.White
       Me.txtnumero_factura.Location = New System.Drawing.Point(161, 48)
       Me.txtnumero_factura.Size = New System.Drawing.Size(385, 20)
       Me.txtnumero_factura.MaxLength = 12
       Me.txtnumero_factura.Name = "txtnumero_factura"
       Me.txtnumero_factura.TabIndex = 4
       '
       'etiquietanumero_factura
       '
       Me.etiquetanumero_factura.BackColor = System.Drawing.Color.Transparent
       Me.etiquetanumero_factura.AutoSize = True
       Me.etiquetanumero_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetanumero_factura.ForeColor = System.Drawing.Color.Black
       Me.etiquetanumero_factura.Location = New System.Drawing.Point(28, 48)
       Me.etiquetanumero_factura.Name = "etiquetanumero_factura"
       Me.etiquetanumero_factura.Size = New System.Drawing.Size(127, 21)
       Me.etiquetanumero_factura.TabIndex = 500
       Me.etiquetanumero_factura.Text = "Numero factura"
       Me.etiquetanumero_factura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblid_empresa
       '
       Me.lblid_empresa.AutoSize = True
       Me.lblid_empresa.BackColor = System.Drawing.Color.Red
       Me.lblid_empresa.Location = New System.Drawing.Point(370, 91)
       Me.lblid_empresa.Name = "lblid_empresa"
       Me.lblid_empresa.Size = New System.Drawing.Size(13, 13)
       Me.lblid_empresa.TabIndex = 501
       Me.lblid_empresa.Text = "0"
       Me.lblid_empresa.Visible = False
       '
       'btnBuscaempresa
       '
       Me.btnBuscaempresa.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscaempresa.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscaempresa.Location = New System.Drawing.Point(505, 91)
       Me.btnBuscaempresa.Name = "btnBuscaempresa"
       Me.btnBuscaempresa.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscaempresa.TabIndex = 60
       Me.btnBuscaempresa.UseVisualStyleBackColor = True
       '
       'cmbempresa
       '
       Me.cmbempresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbempresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbempresa.FormattingEnabled = True
       Me.cmbempresa.Location = New System.Drawing.Point(161, 91)
       Me.cmbempresa.Size = New System.Drawing.Size(329, 21)
       Me.cmbempresa.Name = "cmbempresa"
       Me.cmbempresa.TabIndex = 5
       '
       'etiquietaid_empresa
       '
       Me.etiquetaid_empresa.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_empresa.AutoSize = True
       Me.etiquetaid_empresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_empresa.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_empresa.Location = New System.Drawing.Point(28, 91)
       Me.etiquetaid_empresa.Name = "etiquetaid_empresa"
       Me.etiquetaid_empresa.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_empresa.TabIndex = 502
       Me.etiquetaid_empresa.Text = "Empresa"
       Me.etiquetaid_empresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblid_tipo_comprobante
       '
       Me.lblid_tipo_comprobante.AutoSize = True
       Me.lblid_tipo_comprobante.BackColor = System.Drawing.Color.Red
       Me.lblid_tipo_comprobante.Location = New System.Drawing.Point(370, 134)
       Me.lblid_tipo_comprobante.Name = "lblid_tipo_comprobante"
       Me.lblid_tipo_comprobante.Size = New System.Drawing.Size(13, 13)
       Me.lblid_tipo_comprobante.TabIndex = 503
       Me.lblid_tipo_comprobante.Text = "0"
       Me.lblid_tipo_comprobante.Visible = False
       '
       'btnBuscatipo_comprobante
       '
       Me.btnBuscatipo_comprobante.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscatipo_comprobante.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscatipo_comprobante.Location = New System.Drawing.Point(505, 134)
       Me.btnBuscatipo_comprobante.Name = "btnBuscatipo_comprobante"
       Me.btnBuscatipo_comprobante.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscatipo_comprobante.TabIndex = 61
       Me.btnBuscatipo_comprobante.UseVisualStyleBackColor = True
       '
       'cmbtipo_comprobante
       '
       Me.cmbtipo_comprobante.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbtipo_comprobante.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbtipo_comprobante.FormattingEnabled = True
       Me.cmbtipo_comprobante.Location = New System.Drawing.Point(161, 134)
       Me.cmbtipo_comprobante.Size = New System.Drawing.Size(329, 21)
       Me.cmbtipo_comprobante.Name = "cmbtipo_comprobante"
       Me.cmbtipo_comprobante.TabIndex = 6
       '
       'etiquietaid_tipo_comprobante
       '
       Me.etiquetaid_tipo_comprobante.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_tipo_comprobante.AutoSize = True
       Me.etiquetaid_tipo_comprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_tipo_comprobante.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_tipo_comprobante.Location = New System.Drawing.Point(28, 134)
       Me.etiquetaid_tipo_comprobante.Name = "etiquetaid_tipo_comprobante"
       Me.etiquetaid_tipo_comprobante.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_tipo_comprobante.TabIndex = 504
       Me.etiquetaid_tipo_comprobante.Text = "Tipo comprobante"
       Me.etiquetaid_tipo_comprobante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'dtpfecha
       '
       Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
       Me.dtpfecha.Location = New System.Drawing.Point(161, 177)
       Me.dtpfecha.Name = "cmbfecha"
       Me.dtpfecha.Size = New System.Drawing.Size(93, 20)
       Me.dtpfecha.TabIndex = 7
       '
       'etiquietafecha
       '
       Me.etiquetafecha.BackColor = System.Drawing.Color.Transparent
       Me.etiquetafecha.AutoSize = True
       Me.etiquetafecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetafecha.ForeColor = System.Drawing.Color.Black
       Me.etiquetafecha.Location = New System.Drawing.Point(28, 177)
       Me.etiquetafecha.Name = "etiquetafecha"
       Me.etiquetafecha.Size = New System.Drawing.Size(127, 21)
       Me.etiquetafecha.TabIndex = 505
       Me.etiquetafecha.Text = "Fecha"
       Me.etiquetafecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'dtpfecha_factura
       '
       Me.dtpfecha_factura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
       Me.dtpfecha_factura.Location = New System.Drawing.Point(161, 220)
       Me.dtpfecha_factura.Name = "cmbfecha_factura"
       Me.dtpfecha_factura.Size = New System.Drawing.Size(93, 20)
       Me.dtpfecha_factura.TabIndex = 8
       '
       'etiquietafecha_factura
       '
       Me.etiquetafecha_factura.BackColor = System.Drawing.Color.Transparent
       Me.etiquetafecha_factura.AutoSize = True
       Me.etiquetafecha_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetafecha_factura.ForeColor = System.Drawing.Color.Black
       Me.etiquetafecha_factura.Location = New System.Drawing.Point(28, 220)
       Me.etiquetafecha_factura.Name = "etiquetafecha_factura"
       Me.etiquetafecha_factura.Size = New System.Drawing.Size(127, 21)
       Me.etiquetafecha_factura.TabIndex = 506
       Me.etiquetafecha_factura.Text = "Fecha factura"
       Me.etiquetafecha_factura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'dtpfecha_vencimiento
       '
       Me.dtpfecha_vencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
       Me.dtpfecha_vencimiento.Location = New System.Drawing.Point(161, 263)
       Me.dtpfecha_vencimiento.Name = "cmbfecha_vencimiento"
       Me.dtpfecha_vencimiento.Size = New System.Drawing.Size(93, 20)
       Me.dtpfecha_vencimiento.TabIndex = 9
       '
       'etiquietafecha_vencimiento
       '
       Me.etiquetafecha_vencimiento.BackColor = System.Drawing.Color.Transparent
       Me.etiquetafecha_vencimiento.AutoSize = True
       Me.etiquetafecha_vencimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetafecha_vencimiento.ForeColor = System.Drawing.Color.Black
       Me.etiquetafecha_vencimiento.Location = New System.Drawing.Point(28, 263)
       Me.etiquetafecha_vencimiento.Name = "etiquetafecha_vencimiento"
       Me.etiquetafecha_vencimiento.Size = New System.Drawing.Size(127, 21)
       Me.etiquetafecha_vencimiento.TabIndex = 507
       Me.etiquetafecha_vencimiento.Text = "Fecha vencimiento"
       Me.etiquetafecha_vencimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblid_proveedor
       '
       Me.lblid_proveedor.AutoSize = True
       Me.lblid_proveedor.BackColor = System.Drawing.Color.Red
       Me.lblid_proveedor.Location = New System.Drawing.Point(370, 306)
       Me.lblid_proveedor.Name = "lblid_proveedor"
       Me.lblid_proveedor.Size = New System.Drawing.Size(13, 13)
       Me.lblid_proveedor.TabIndex = 508
       Me.lblid_proveedor.Text = "0"
       Me.lblid_proveedor.Visible = False
       '
       'btnBuscaproveedor
       '
       Me.btnBuscaproveedor.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscaproveedor.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscaproveedor.Location = New System.Drawing.Point(505, 306)
       Me.btnBuscaproveedor.Name = "btnBuscaproveedor"
       Me.btnBuscaproveedor.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscaproveedor.TabIndex = 62
       Me.btnBuscaproveedor.UseVisualStyleBackColor = True
       '
       'cmbproveedor
       '
       Me.cmbproveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbproveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbproveedor.FormattingEnabled = True
       Me.cmbproveedor.Location = New System.Drawing.Point(161, 306)
       Me.cmbproveedor.Size = New System.Drawing.Size(329, 21)
       Me.cmbproveedor.Name = "cmbproveedor"
       Me.cmbproveedor.TabIndex = 10
       '
       'etiquietaid_proveedor
       '
       Me.etiquetaid_proveedor.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_proveedor.AutoSize = True
       Me.etiquetaid_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_proveedor.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_proveedor.Location = New System.Drawing.Point(28, 306)
       Me.etiquetaid_proveedor.Name = "etiquetaid_proveedor"
       Me.etiquetaid_proveedor.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_proveedor.TabIndex = 509
       Me.etiquetaid_proveedor.Text = "Proveedor"
       Me.etiquetaid_proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtobservacion
       '
       Me.txtobservacion.BackColor = System.Drawing.Color.White
       Me.txtobservacion.Location = New System.Drawing.Point(161, 349)
       Me.txtobservacion.Size = New System.Drawing.Size(385, 20)
       Me.txtobservacion.MaxLength = 500
       Me.txtobservacion.Name = "txtobservacion"
       Me.txtobservacion.TabIndex = 11
       '
       'etiquietaobservacion
       '
       Me.etiquetaobservacion.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaobservacion.AutoSize = True
       Me.etiquetaobservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaobservacion.ForeColor = System.Drawing.Color.Black
       Me.etiquetaobservacion.Location = New System.Drawing.Point(28, 349)
       Me.etiquetaobservacion.Name = "etiquetaobservacion"
       Me.etiquetaobservacion.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaobservacion.TabIndex = 510
       Me.etiquetaobservacion.Text = "Observacion"
       Me.etiquetaobservacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtsaldo
       '
       Me.txtsaldo.BackColor = System.Drawing.Color.White
       Me.txtsaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtsaldo.ForeColor = System.Drawing.Color.Blue
       Me.txtsaldo.Location = New System.Drawing.Point(161, 392)
       Me.txtsaldo.MaxLength = 50
       Me.txtsaldo.Name = "txtsaldo"
       Me.txtsaldo.Size = New System.Drawing.Size(222, 31)
       Me.txtsaldo.TabIndex = 12
       Me.txtsaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietasaldo
       '
       Me.etiquetasaldo.BackColor = System.Drawing.Color.Transparent
       Me.etiquetasaldo.AutoSize = True
       Me.etiquetasaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetasaldo.ForeColor = System.Drawing.Color.Black
       Me.etiquetasaldo.Location = New System.Drawing.Point(28, 392)
       Me.etiquetasaldo.Name = "etiquetasaldo"
       Me.etiquetasaldo.Size = New System.Drawing.Size(127, 21)
       Me.etiquetasaldo.TabIndex = 511
       Me.etiquetasaldo.Text = "Saldo"
       Me.etiquetasaldo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtestado
       '
       Me.txtestado.BackColor = System.Drawing.Color.White
       Me.txtestado.Location = New System.Drawing.Point(161, 445)
       Me.txtestado.Size = New System.Drawing.Size(385, 20)
       Me.txtestado.MaxLength = 1
       Me.txtestado.Name = "txtestado"
       Me.txtestado.TabIndex = 13
       '
       'etiquietaestado
       '
       Me.etiquetaestado.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaestado.AutoSize = True
       Me.etiquetaestado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaestado.ForeColor = System.Drawing.Color.Black
       Me.etiquetaestado.Location = New System.Drawing.Point(28, 445)
       Me.etiquetaestado.Name = "etiquetaestado"
       Me.etiquetaestado.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaestado.TabIndex = 512
       Me.etiquetaestado.Text = "Estado"
       Me.etiquetaestado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtalicuota_iva
       '
       Me.txtalicuota_iva.BackColor = System.Drawing.Color.White
       Me.txtalicuota_iva.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtalicuota_iva.ForeColor = System.Drawing.Color.Blue
       Me.txtalicuota_iva.Location = New System.Drawing.Point(161, 488)
       Me.txtalicuota_iva.MaxLength = 50
       Me.txtalicuota_iva.Name = "txtalicuota_iva"
       Me.txtalicuota_iva.Size = New System.Drawing.Size(222, 31)
       Me.txtalicuota_iva.TabIndex = 14
       Me.txtalicuota_iva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietaalicuota_iva
       '
       Me.etiquetaalicuota_iva.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaalicuota_iva.AutoSize = True
       Me.etiquetaalicuota_iva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaalicuota_iva.ForeColor = System.Drawing.Color.Black
       Me.etiquetaalicuota_iva.Location = New System.Drawing.Point(28, 488)
       Me.etiquetaalicuota_iva.Name = "etiquetaalicuota_iva"
       Me.etiquetaalicuota_iva.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaalicuota_iva.TabIndex = 513
       Me.etiquetaalicuota_iva.Text = "Alicuota iva"
       Me.etiquetaalicuota_iva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtiva_21
       '
       Me.txtiva_21.BackColor = System.Drawing.Color.White
       Me.txtiva_21.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtiva_21.ForeColor = System.Drawing.Color.Blue
       Me.txtiva_21.Location = New System.Drawing.Point(161, 541)
       Me.txtiva_21.MaxLength = 50
       Me.txtiva_21.Name = "txtiva_21"
       Me.txtiva_21.Size = New System.Drawing.Size(222, 31)
       Me.txtiva_21.TabIndex = 15
       Me.txtiva_21.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietaiva_21
       '
       Me.etiquetaiva_21.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaiva_21.AutoSize = True
       Me.etiquetaiva_21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaiva_21.ForeColor = System.Drawing.Color.Black
       Me.etiquetaiva_21.Location = New System.Drawing.Point(28, 541)
       Me.etiquetaiva_21.Name = "etiquetaiva_21"
       Me.etiquetaiva_21.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaiva_21.TabIndex = 514
       Me.etiquetaiva_21.Text = "Iva 21"
       Me.etiquetaiva_21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtiva_10_5
       '
       Me.txtiva_10_5.BackColor = System.Drawing.Color.White
       Me.txtiva_10_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtiva_10_5.ForeColor = System.Drawing.Color.Blue
       Me.txtiva_10_5.Location = New System.Drawing.Point(656, 48)
       Me.txtiva_10_5.MaxLength = 50
       Me.txtiva_10_5.Name = "txtiva_10_5"
       Me.txtiva_10_5.Size = New System.Drawing.Size(222, 31)
       Me.txtiva_10_5.TabIndex = 16
       Me.txtiva_10_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietaiva_10_5
       '
       Me.etiquetaiva_10_5.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaiva_10_5.AutoSize = True
       Me.etiquetaiva_10_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaiva_10_5.ForeColor = System.Drawing.Color.Black
       Me.etiquetaiva_10_5.Location = New System.Drawing.Point(583, 48)
       Me.etiquetaiva_10_5.Name = "etiquetaiva_10_5"
       Me.etiquetaiva_10_5.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaiva_10_5.TabIndex = 515
       Me.etiquetaiva_10_5.Text = "Iva 10 5"
       Me.etiquetaiva_10_5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtimporte_21
       '
       Me.txtimporte_21.BackColor = System.Drawing.Color.White
       Me.txtimporte_21.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtimporte_21.ForeColor = System.Drawing.Color.Blue
       Me.txtimporte_21.Location = New System.Drawing.Point(656, 101)
       Me.txtimporte_21.MaxLength = 50
       Me.txtimporte_21.Name = "txtimporte_21"
       Me.txtimporte_21.Size = New System.Drawing.Size(222, 31)
       Me.txtimporte_21.TabIndex = 17
       Me.txtimporte_21.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietaimporte_21
       '
       Me.etiquetaimporte_21.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaimporte_21.AutoSize = True
       Me.etiquetaimporte_21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaimporte_21.ForeColor = System.Drawing.Color.Black
       Me.etiquetaimporte_21.Location = New System.Drawing.Point(583, 101)
       Me.etiquetaimporte_21.Name = "etiquetaimporte_21"
       Me.etiquetaimporte_21.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaimporte_21.TabIndex = 516
       Me.etiquetaimporte_21.Text = "Importe 21"
       Me.etiquetaimporte_21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtimporte_10_5
       '
       Me.txtimporte_10_5.BackColor = System.Drawing.Color.White
       Me.txtimporte_10_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtimporte_10_5.ForeColor = System.Drawing.Color.Blue
       Me.txtimporte_10_5.Location = New System.Drawing.Point(656, 154)
       Me.txtimporte_10_5.MaxLength = 50
       Me.txtimporte_10_5.Name = "txtimporte_10_5"
       Me.txtimporte_10_5.Size = New System.Drawing.Size(222, 31)
       Me.txtimporte_10_5.TabIndex = 18
       Me.txtimporte_10_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietaimporte_10_5
       '
       Me.etiquetaimporte_10_5.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaimporte_10_5.AutoSize = True
       Me.etiquetaimporte_10_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaimporte_10_5.ForeColor = System.Drawing.Color.Black
       Me.etiquetaimporte_10_5.Location = New System.Drawing.Point(583, 154)
       Me.etiquetaimporte_10_5.Name = "etiquetaimporte_10_5"
       Me.etiquetaimporte_10_5.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaimporte_10_5.TabIndex = 517
       Me.etiquetaimporte_10_5.Text = "Importe 10 5"
       Me.etiquetaimporte_10_5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtretencion_iva
       '
       Me.txtretencion_iva.BackColor = System.Drawing.Color.White
       Me.txtretencion_iva.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtretencion_iva.ForeColor = System.Drawing.Color.Blue
       Me.txtretencion_iva.Location = New System.Drawing.Point(656, 207)
       Me.txtretencion_iva.MaxLength = 50
       Me.txtretencion_iva.Name = "txtretencion_iva"
       Me.txtretencion_iva.Size = New System.Drawing.Size(222, 31)
       Me.txtretencion_iva.TabIndex = 19
       Me.txtretencion_iva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietaretencion_iva
       '
       Me.etiquetaretencion_iva.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaretencion_iva.AutoSize = True
       Me.etiquetaretencion_iva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaretencion_iva.ForeColor = System.Drawing.Color.Black
       Me.etiquetaretencion_iva.Location = New System.Drawing.Point(583, 207)
       Me.etiquetaretencion_iva.Name = "etiquetaretencion_iva"
       Me.etiquetaretencion_iva.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaretencion_iva.TabIndex = 518
       Me.etiquetaretencion_iva.Text = "Retencion iva"
       Me.etiquetaretencion_iva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtpercepcion_iva
       '
       Me.txtpercepcion_iva.BackColor = System.Drawing.Color.White
       Me.txtpercepcion_iva.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtpercepcion_iva.ForeColor = System.Drawing.Color.Blue
       Me.txtpercepcion_iva.Location = New System.Drawing.Point(656, 260)
       Me.txtpercepcion_iva.MaxLength = 50
       Me.txtpercepcion_iva.Name = "txtpercepcion_iva"
       Me.txtpercepcion_iva.Size = New System.Drawing.Size(222, 31)
       Me.txtpercepcion_iva.TabIndex = 20
       Me.txtpercepcion_iva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietapercepcion_iva
       '
       Me.etiquetapercepcion_iva.BackColor = System.Drawing.Color.Transparent
       Me.etiquetapercepcion_iva.AutoSize = True
       Me.etiquetapercepcion_iva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetapercepcion_iva.ForeColor = System.Drawing.Color.Black
       Me.etiquetapercepcion_iva.Location = New System.Drawing.Point(583, 260)
       Me.etiquetapercepcion_iva.Name = "etiquetapercepcion_iva"
       Me.etiquetapercepcion_iva.Size = New System.Drawing.Size(127, 21)
       Me.etiquetapercepcion_iva.TabIndex = 519
       Me.etiquetapercepcion_iva.Text = "Percepcion iva"
       Me.etiquetapercepcion_iva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtretencion_ingreso_bruto
       '
       Me.txtretencion_ingreso_bruto.BackColor = System.Drawing.Color.White
       Me.txtretencion_ingreso_bruto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtretencion_ingreso_bruto.ForeColor = System.Drawing.Color.Blue
       Me.txtretencion_ingreso_bruto.Location = New System.Drawing.Point(656, 313)
       Me.txtretencion_ingreso_bruto.MaxLength = 50
       Me.txtretencion_ingreso_bruto.Name = "txtretencion_ingreso_bruto"
       Me.txtretencion_ingreso_bruto.Size = New System.Drawing.Size(222, 31)
       Me.txtretencion_ingreso_bruto.TabIndex = 21
       Me.txtretencion_ingreso_bruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietaretencion_ingreso_bruto
       '
       Me.etiquetaretencion_ingreso_bruto.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaretencion_ingreso_bruto.AutoSize = True
       Me.etiquetaretencion_ingreso_bruto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaretencion_ingreso_bruto.ForeColor = System.Drawing.Color.Black
       Me.etiquetaretencion_ingreso_bruto.Location = New System.Drawing.Point(583, 313)
       Me.etiquetaretencion_ingreso_bruto.Name = "etiquetaretencion_ingreso_bruto"
       Me.etiquetaretencion_ingreso_bruto.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaretencion_ingreso_bruto.TabIndex = 520
       Me.etiquetaretencion_ingreso_bruto.Text = "Retencion ingreso bruto"
       Me.etiquetaretencion_ingreso_bruto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtpercepcion_ingreso_bruto
       '
       Me.txtpercepcion_ingreso_bruto.BackColor = System.Drawing.Color.White
       Me.txtpercepcion_ingreso_bruto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtpercepcion_ingreso_bruto.ForeColor = System.Drawing.Color.Blue
       Me.txtpercepcion_ingreso_bruto.Location = New System.Drawing.Point(656, 366)
       Me.txtpercepcion_ingreso_bruto.MaxLength = 50
       Me.txtpercepcion_ingreso_bruto.Name = "txtpercepcion_ingreso_bruto"
       Me.txtpercepcion_ingreso_bruto.Size = New System.Drawing.Size(222, 31)
       Me.txtpercepcion_ingreso_bruto.TabIndex = 22
       Me.txtpercepcion_ingreso_bruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietapercepcion_ingreso_bruto
       '
       Me.etiquetapercepcion_ingreso_bruto.BackColor = System.Drawing.Color.Transparent
       Me.etiquetapercepcion_ingreso_bruto.AutoSize = True
       Me.etiquetapercepcion_ingreso_bruto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetapercepcion_ingreso_bruto.ForeColor = System.Drawing.Color.Black
       Me.etiquetapercepcion_ingreso_bruto.Location = New System.Drawing.Point(583, 366)
       Me.etiquetapercepcion_ingreso_bruto.Name = "etiquetapercepcion_ingreso_bruto"
       Me.etiquetapercepcion_ingreso_bruto.Size = New System.Drawing.Size(127, 21)
       Me.etiquetapercepcion_ingreso_bruto.TabIndex = 521
       Me.etiquetapercepcion_ingreso_bruto.Text = "Percepcion ingreso bruto"
       Me.etiquetapercepcion_ingreso_bruto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtretencion_ganancia
       '
       Me.txtretencion_ganancia.BackColor = System.Drawing.Color.White
       Me.txtretencion_ganancia.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtretencion_ganancia.ForeColor = System.Drawing.Color.Blue
       Me.txtretencion_ganancia.Location = New System.Drawing.Point(656, 419)
       Me.txtretencion_ganancia.MaxLength = 50
       Me.txtretencion_ganancia.Name = "txtretencion_ganancia"
       Me.txtretencion_ganancia.Size = New System.Drawing.Size(222, 31)
       Me.txtretencion_ganancia.TabIndex = 23
       Me.txtretencion_ganancia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietaretencion_ganancia
       '
       Me.etiquetaretencion_ganancia.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaretencion_ganancia.AutoSize = True
       Me.etiquetaretencion_ganancia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaretencion_ganancia.ForeColor = System.Drawing.Color.Black
       Me.etiquetaretencion_ganancia.Location = New System.Drawing.Point(583, 419)
       Me.etiquetaretencion_ganancia.Name = "etiquetaretencion_ganancia"
       Me.etiquetaretencion_ganancia.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaretencion_ganancia.TabIndex = 522
       Me.etiquetaretencion_ganancia.Text = "Retencion ganancia"
       Me.etiquetaretencion_ganancia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtimpuesto_interno
       '
       Me.txtimpuesto_interno.BackColor = System.Drawing.Color.White
       Me.txtimpuesto_interno.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtimpuesto_interno.ForeColor = System.Drawing.Color.Blue
       Me.txtimpuesto_interno.Location = New System.Drawing.Point(656, 472)
       Me.txtimpuesto_interno.MaxLength = 50
       Me.txtimpuesto_interno.Name = "txtimpuesto_interno"
       Me.txtimpuesto_interno.Size = New System.Drawing.Size(222, 31)
       Me.txtimpuesto_interno.TabIndex = 24
       Me.txtimpuesto_interno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietaimpuesto_interno
       '
       Me.etiquetaimpuesto_interno.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaimpuesto_interno.AutoSize = True
       Me.etiquetaimpuesto_interno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaimpuesto_interno.ForeColor = System.Drawing.Color.Black
       Me.etiquetaimpuesto_interno.Location = New System.Drawing.Point(583, 472)
       Me.etiquetaimpuesto_interno.Name = "etiquetaimpuesto_interno"
       Me.etiquetaimpuesto_interno.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaimpuesto_interno.TabIndex = 523
       Me.etiquetaimpuesto_interno.Text = "Impuesto interno"
       Me.etiquetaimpuesto_interno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtotro
       '
       Me.txtotro.BackColor = System.Drawing.Color.White
       Me.txtotro.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtotro.ForeColor = System.Drawing.Color.Blue
       Me.txtotro.Location = New System.Drawing.Point(656, 525)
       Me.txtotro.MaxLength = 50
       Me.txtotro.Name = "txtotro"
       Me.txtotro.Size = New System.Drawing.Size(222, 31)
       Me.txtotro.TabIndex = 25
       Me.txtotro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietaotro
       '
       Me.etiquetaotro.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaotro.AutoSize = True
       Me.etiquetaotro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaotro.ForeColor = System.Drawing.Color.Black
       Me.etiquetaotro.Location = New System.Drawing.Point(583, 525)
       Me.etiquetaotro.Name = "etiquetaotro"
       Me.etiquetaotro.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaotro.TabIndex = 524
       Me.etiquetaotro.Text = "Otro"
       Me.etiquetaotro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txttotal_21
       '
       Me.txttotal_21.BackColor = System.Drawing.Color.White
       Me.txttotal_21.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txttotal_21.ForeColor = System.Drawing.Color.Blue
       Me.txttotal_21.Location = New System.Drawing.Point(1100, 48)
       Me.txttotal_21.MaxLength = 50
       Me.txttotal_21.Name = "txttotal_21"
       Me.txttotal_21.Size = New System.Drawing.Size(222, 31)
       Me.txttotal_21.TabIndex = 26
       Me.txttotal_21.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietatotal_21
       '
       Me.etiquetatotal_21.BackColor = System.Drawing.Color.Transparent
       Me.etiquetatotal_21.AutoSize = True
       Me.etiquetatotal_21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetatotal_21.ForeColor = System.Drawing.Color.Black
       Me.etiquetatotal_21.Location = New System.Drawing.Point(1000, 48)
       Me.etiquetatotal_21.Name = "etiquetatotal_21"
       Me.etiquetatotal_21.Size = New System.Drawing.Size(127, 21)
       Me.etiquetatotal_21.TabIndex = 525
       Me.etiquetatotal_21.Text = "Total 21"
       Me.etiquetatotal_21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txttotal_10_5
       '
       Me.txttotal_10_5.BackColor = System.Drawing.Color.White
       Me.txttotal_10_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txttotal_10_5.ForeColor = System.Drawing.Color.Blue
       Me.txttotal_10_5.Location = New System.Drawing.Point(1100, 101)
       Me.txttotal_10_5.MaxLength = 50
       Me.txttotal_10_5.Name = "txttotal_10_5"
       Me.txttotal_10_5.Size = New System.Drawing.Size(222, 31)
       Me.txttotal_10_5.TabIndex = 27
       Me.txttotal_10_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietatotal_10_5
       '
       Me.etiquetatotal_10_5.BackColor = System.Drawing.Color.Transparent
       Me.etiquetatotal_10_5.AutoSize = True
       Me.etiquetatotal_10_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetatotal_10_5.ForeColor = System.Drawing.Color.Black
       Me.etiquetatotal_10_5.Location = New System.Drawing.Point(1000, 101)
       Me.etiquetatotal_10_5.Name = "etiquetatotal_10_5"
       Me.etiquetatotal_10_5.Size = New System.Drawing.Size(127, 21)
       Me.etiquetatotal_10_5.TabIndex = 526
       Me.etiquetatotal_10_5.Text = "Total 10 5"
       Me.etiquetatotal_10_5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txttotal_sin
       '
       Me.txttotal_sin.BackColor = System.Drawing.Color.White
       Me.txttotal_sin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txttotal_sin.ForeColor = System.Drawing.Color.Blue
       Me.txttotal_sin.Location = New System.Drawing.Point(1100, 154)
       Me.txttotal_sin.MaxLength = 50
       Me.txttotal_sin.Name = "txttotal_sin"
       Me.txttotal_sin.Size = New System.Drawing.Size(222, 31)
       Me.txttotal_sin.TabIndex = 28
       Me.txttotal_sin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietatotal_sin
       '
       Me.etiquetatotal_sin.BackColor = System.Drawing.Color.Transparent
       Me.etiquetatotal_sin.AutoSize = True
       Me.etiquetatotal_sin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetatotal_sin.ForeColor = System.Drawing.Color.Black
       Me.etiquetatotal_sin.Location = New System.Drawing.Point(1000, 154)
       Me.etiquetatotal_sin.Name = "etiquetatotal_sin"
       Me.etiquetatotal_sin.Size = New System.Drawing.Size(127, 21)
       Me.etiquetatotal_sin.TabIndex = 527
       Me.etiquetatotal_sin.Text = "Total sin"
       Me.etiquetatotal_sin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txttotal_factura
       '
       Me.txttotal_factura.BackColor = System.Drawing.Color.White
       Me.txttotal_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txttotal_factura.ForeColor = System.Drawing.Color.Blue
       Me.txttotal_factura.Location = New System.Drawing.Point(1100, 207)
       Me.txttotal_factura.MaxLength = 50
       Me.txttotal_factura.Name = "txttotal_factura"
       Me.txttotal_factura.Size = New System.Drawing.Size(222, 31)
       Me.txttotal_factura.TabIndex = 29
       Me.txttotal_factura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietatotal_factura
       '
       Me.etiquetatotal_factura.BackColor = System.Drawing.Color.Transparent
       Me.etiquetatotal_factura.AutoSize = True
       Me.etiquetatotal_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetatotal_factura.ForeColor = System.Drawing.Color.Black
       Me.etiquetatotal_factura.Location = New System.Drawing.Point(1000, 207)
       Me.etiquetatotal_factura.Name = "etiquetatotal_factura"
       Me.etiquetatotal_factura.Size = New System.Drawing.Size(127, 21)
       Me.etiquetatotal_factura.TabIndex = 528
       Me.etiquetatotal_factura.Text = "Total factura"
       Me.etiquetatotal_factura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblid_almacen
       '
       Me.lblid_almacen.AutoSize = True
       Me.lblid_almacen.BackColor = System.Drawing.Color.Red
       Me.lblid_almacen.Location = New System.Drawing.Point(1300, 260)
       Me.lblid_almacen.Name = "lblid_almacen"
       Me.lblid_almacen.Size = New System.Drawing.Size(13, 13)
       Me.lblid_almacen.TabIndex = 529
       Me.lblid_almacen.Text = "0"
       Me.lblid_almacen.Visible = False
       '
       'btnBuscaalmacen
       '
       Me.btnBuscaalmacen.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscaalmacen.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscaalmacen.Location = New System.Drawing.Point(1400, 260)
       Me.btnBuscaalmacen.Name = "btnBuscaalmacen"
       Me.btnBuscaalmacen.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscaalmacen.TabIndex = 63
       Me.btnBuscaalmacen.UseVisualStyleBackColor = True
       '
       'cmbalmacen
       '
       Me.cmbalmacen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbalmacen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbalmacen.FormattingEnabled = True
       Me.cmbalmacen.Location = New System.Drawing.Point(1100, 260)
       Me.cmbalmacen.Size = New System.Drawing.Size(286, 21)
       Me.cmbalmacen.Name = "cmbalmacen"
       Me.cmbalmacen.TabIndex = 30
       '
       'etiquietaid_almacen
       '
       Me.etiquetaid_almacen.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_almacen.AutoSize = True
       Me.etiquetaid_almacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_almacen.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_almacen.Location = New System.Drawing.Point(1000, 260)
       Me.etiquetaid_almacen.Name = "etiquetaid_almacen"
       Me.etiquetaid_almacen.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_almacen.TabIndex = 530
       Me.etiquetaid_almacen.Text = "Almacen"
       Me.etiquetaid_almacen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblid_cuenta_contable
       '
       Me.lblid_cuenta_contable.AutoSize = True
       Me.lblid_cuenta_contable.BackColor = System.Drawing.Color.Red
       Me.lblid_cuenta_contable.Location = New System.Drawing.Point(1300, 303)
       Me.lblid_cuenta_contable.Name = "lblid_cuenta_contable"
       Me.lblid_cuenta_contable.Size = New System.Drawing.Size(13, 13)
       Me.lblid_cuenta_contable.TabIndex = 531
       Me.lblid_cuenta_contable.Text = "0"
       Me.lblid_cuenta_contable.Visible = False
       '
       'btnBuscacuenta_contable
       '
       Me.btnBuscacuenta_contable.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscacuenta_contable.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscacuenta_contable.Location = New System.Drawing.Point(1400, 303)
       Me.btnBuscacuenta_contable.Name = "btnBuscacuenta_contable"
       Me.btnBuscacuenta_contable.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscacuenta_contable.TabIndex = 64
       Me.btnBuscacuenta_contable.UseVisualStyleBackColor = True
       '
       'cmbcuenta_contable
       '
       Me.cmbcuenta_contable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbcuenta_contable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbcuenta_contable.FormattingEnabled = True
       Me.cmbcuenta_contable.Location = New System.Drawing.Point(1100, 303)
       Me.cmbcuenta_contable.Size = New System.Drawing.Size(286, 21)
       Me.cmbcuenta_contable.Name = "cmbcuenta_contable"
       Me.cmbcuenta_contable.TabIndex = 31
       '
       'etiquietaid_cuenta_contable
       '
       Me.etiquetaid_cuenta_contable.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_cuenta_contable.AutoSize = True
       Me.etiquetaid_cuenta_contable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_cuenta_contable.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_cuenta_contable.Location = New System.Drawing.Point(1000, 303)
       Me.etiquetaid_cuenta_contable.Name = "etiquetaid_cuenta_contable"
       Me.etiquetaid_cuenta_contable.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_cuenta_contable.TabIndex = 532
       Me.etiquetaid_cuenta_contable.Text = "Cuenta contable"
       Me.etiquetaid_cuenta_contable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblid_usuario
       '
       Me.lblid_usuario.AutoSize = True
       Me.lblid_usuario.BackColor = System.Drawing.Color.Red
       Me.lblid_usuario.Location = New System.Drawing.Point(1300, 346)
       Me.lblid_usuario.Name = "lblid_usuario"
       Me.lblid_usuario.Size = New System.Drawing.Size(13, 13)
       Me.lblid_usuario.TabIndex = 533
       Me.lblid_usuario.Text = "0"
       Me.lblid_usuario.Visible = False
       '
       'btnBuscausuario
       '
       Me.btnBuscausuario.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscausuario.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscausuario.Location = New System.Drawing.Point(1400, 346)
       Me.btnBuscausuario.Name = "btnBuscausuario"
       Me.btnBuscausuario.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscausuario.TabIndex = 65
       Me.btnBuscausuario.UseVisualStyleBackColor = True
       '
       'cmbusuario
       '
       Me.cmbusuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbusuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbusuario.FormattingEnabled = True
       Me.cmbusuario.Location = New System.Drawing.Point(1100, 346)
       Me.cmbusuario.Size = New System.Drawing.Size(286, 21)
       Me.cmbusuario.Name = "cmbusuario"
       Me.cmbusuario.TabIndex = 32
       '
       'etiquietaid_usuario
       '
       Me.etiquetaid_usuario.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_usuario.AutoSize = True
       Me.etiquetaid_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_usuario.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_usuario.Location = New System.Drawing.Point(1000, 346)
       Me.etiquetaid_usuario.Name = "etiquetaid_usuario"
       Me.etiquetaid_usuario.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_usuario.TabIndex = 534
       Me.etiquetaid_usuario.Text = "Usuario"
       Me.etiquetaid_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'chktilde
       '
       Me.chktilde.AutoSize = True
       Me.chktilde.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.chktilde.Location = New System.Drawing.Point(1000, 389)
       Me.chktilde.Name = "etiquetatilde"
       Me.chktilde.Size = New System.Drawing.Size(15, 14)
       Me.chktilde.TabIndex = 33
       Me.chktilde.Text = "tilde"
       Me.chktilde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       'etiquietatilde
       '
       Me.etiquetatilde.BackColor = System.Drawing.Color.Transparent
       Me.etiquetatilde.AutoSize = True
       Me.etiquetatilde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetatilde.ForeColor = System.Drawing.Color.Black
       Me.etiquetatilde.Location = New System.Drawing.Point(1000, 389)
       Me.etiquetatilde.Name = "etiquetatilde"
       Me.etiquetatilde.Size = New System.Drawing.Size(127, 21)
       Me.etiquetatilde.TabIndex = 535
       Me.etiquetatilde.Text = "Tilde"
       Me.etiquetatilde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtreferencia
       '
       Me.txtreferencia.BackColor = System.Drawing.Color.White
       Me.txtreferencia.Location = New System.Drawing.Point(1100, 432)
       Me.txtreferencia.Size = New System.Drawing.Size(330, 20)
       Me.txtreferencia.MaxLength = 50
       Me.txtreferencia.Name = "txtreferencia"
       Me.txtreferencia.TabIndex = 34
       '
       'etiquietareferencia
       '
       Me.etiquetareferencia.BackColor = System.Drawing.Color.Transparent
       Me.etiquetareferencia.AutoSize = True
       Me.etiquetareferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetareferencia.ForeColor = System.Drawing.Color.Black
       Me.etiquetareferencia.Location = New System.Drawing.Point(1000, 432)
       Me.etiquetareferencia.Name = "etiquetareferencia"
       Me.etiquetareferencia.Size = New System.Drawing.Size(127, 21)
       Me.etiquetareferencia.TabIndex = 536
       Me.etiquetareferencia.Text = "Referencia"
       Me.etiquetareferencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtsaldo_factura
       '
       Me.txtsaldo_factura.BackColor = System.Drawing.Color.White
       Me.txtsaldo_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtsaldo_factura.ForeColor = System.Drawing.Color.Blue
       Me.txtsaldo_factura.Location = New System.Drawing.Point(1100, 475)
       Me.txtsaldo_factura.MaxLength = 50
       Me.txtsaldo_factura.Name = "txtsaldo_factura"
       Me.txtsaldo_factura.Size = New System.Drawing.Size(222, 31)
       Me.txtsaldo_factura.TabIndex = 35
       Me.txtsaldo_factura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietasaldo_factura
       '
       Me.etiquetasaldo_factura.BackColor = System.Drawing.Color.Transparent
       Me.etiquetasaldo_factura.AutoSize = True
       Me.etiquetasaldo_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetasaldo_factura.ForeColor = System.Drawing.Color.Black
       Me.etiquetasaldo_factura.Location = New System.Drawing.Point(1000, 475)
       Me.etiquetasaldo_factura.Name = "etiquetasaldo_factura"
       Me.etiquetasaldo_factura.Size = New System.Drawing.Size(127, 21)
       Me.etiquetasaldo_factura.TabIndex = 537
       Me.etiquetasaldo_factura.Text = "Saldo factura"
       Me.etiquetasaldo_factura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'chkpagada
       '
       Me.chkpagada.AutoSize = True
       Me.chkpagada.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.chkpagada.Location = New System.Drawing.Point(1000, 528)
       Me.chkpagada.Name = "etiquetapagada"
       Me.chkpagada.Size = New System.Drawing.Size(15, 14)
       Me.chkpagada.TabIndex = 36
       Me.chkpagada.Text = "pagada"
       Me.chkpagada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       'etiquietapagada
       '
       Me.etiquetapagada.BackColor = System.Drawing.Color.Transparent
       Me.etiquetapagada.AutoSize = True
       Me.etiquetapagada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetapagada.ForeColor = System.Drawing.Color.Black
       Me.etiquetapagada.Location = New System.Drawing.Point(1000, 528)
       Me.etiquetapagada.Name = "etiquetapagada"
       Me.etiquetapagada.Size = New System.Drawing.Size(127, 21)
       Me.etiquetapagada.TabIndex = 538
       Me.etiquetapagada.Text = "Pagada"
       Me.etiquetapagada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblnumero_certificado
       '
       Me.lblnumero_certificado.AutoSize = True
       Me.lblnumero_certificado.BackColor = System.Drawing.Color.Red
       Me.lblnumero_certificado.Location = New System.Drawing.Point(1300, 571)
       Me.lblnumero_certificado.Name = "lblnumero_certificado"
       Me.lblnumero_certificado.Size = New System.Drawing.Size(13, 13)
       Me.lblnumero_certificado.TabIndex = 539
       Me.lblnumero_certificado.Text = "0"
       Me.lblnumero_certificado.Visible = False
       '
       'btnBuscaero_certificado
       '
       Me.btnBuscaero_certificado.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscaero_certificado.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscaero_certificado.Location = New System.Drawing.Point(1400, 571)
       Me.btnBuscaero_certificado.Name = "btnBuscaero_certificado"
       Me.btnBuscaero_certificado.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscaero_certificado.TabIndex = 66
       Me.btnBuscaero_certificado.UseVisualStyleBackColor = True
       '
       'cmbero_certificado
       '
       Me.cmbero_certificado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbero_certificado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbero_certificado.FormattingEnabled = True
       Me.cmbero_certificado.Location = New System.Drawing.Point(1100, 571)
       Me.cmbero_certificado.Size = New System.Drawing.Size(286, 21)
       Me.cmbero_certificado.Name = "cmbero_certificado"
       Me.cmbero_certificado.TabIndex = 37
       '
       'etiquietanumero_certificado
       '
       Me.etiquetanumero_certificado.BackColor = System.Drawing.Color.Transparent
       Me.etiquetanumero_certificado.AutoSize = True
       Me.etiquetanumero_certificado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetanumero_certificado.ForeColor = System.Drawing.Color.Black
       Me.etiquetanumero_certificado.Location = New System.Drawing.Point(1000, 571)
       Me.etiquetanumero_certificado.Name = "etiquetanumero_certificado"
       Me.etiquetanumero_certificado.Size = New System.Drawing.Size(127, 21)
       Me.etiquetanumero_certificado.TabIndex = 540
       Me.etiquetanumero_certificado.Text = "Ero certificado"
       Me.etiquetanumero_certificado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'chkpago_a_cuenta
       '
       Me.chkpago_a_cuenta.AutoSize = True
       Me.chkpago_a_cuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.chkpago_a_cuenta.Location = New System.Drawing.Point(1000, 614)
       Me.chkpago_a_cuenta.Name = "etiquetapago_a_cuenta"
       Me.chkpago_a_cuenta.Size = New System.Drawing.Size(15, 14)
       Me.chkpago_a_cuenta.TabIndex = 38
       Me.chkpago_a_cuenta.Text = "pago_a_cuenta"
       Me.chkpago_a_cuenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       'etiquietapago_a_cuenta
       '
       Me.etiquetapago_a_cuenta.BackColor = System.Drawing.Color.Transparent
       Me.etiquetapago_a_cuenta.AutoSize = True
       Me.etiquetapago_a_cuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetapago_a_cuenta.ForeColor = System.Drawing.Color.Black
       Me.etiquetapago_a_cuenta.Location = New System.Drawing.Point(1000, 614)
       Me.etiquetapago_a_cuenta.Name = "etiquetapago_a_cuenta"
       Me.etiquetapago_a_cuenta.Size = New System.Drawing.Size(127, 21)
       Me.etiquetapago_a_cuenta.TabIndex = 541
       Me.etiquetapago_a_cuenta.Text = "Pago a cuenta"
       Me.etiquetapago_a_cuenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'chksin_pago
       '
       Me.chksin_pago.AutoSize = True
       Me.chksin_pago.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.chksin_pago.Location = New System.Drawing.Point(1000, 657)
       Me.chksin_pago.Name = "etiquetasin_pago"
       Me.chksin_pago.Size = New System.Drawing.Size(15, 14)
       Me.chksin_pago.TabIndex = 39
       Me.chksin_pago.Text = "sin_pago"
       Me.chksin_pago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       'etiquietasin_pago
       '
       Me.etiquetasin_pago.BackColor = System.Drawing.Color.Transparent
       Me.etiquetasin_pago.AutoSize = True
       Me.etiquetasin_pago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetasin_pago.ForeColor = System.Drawing.Color.Black
       Me.etiquetasin_pago.Location = New System.Drawing.Point(1000, 657)
       Me.etiquetasin_pago.Name = "etiquetasin_pago"
       Me.etiquetasin_pago.Size = New System.Drawing.Size(127, 21)
       Me.etiquetasin_pago.TabIndex = 542
       Me.etiquetasin_pago.Text = "Sin pago"
       Me.etiquetasin_pago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'btnSalir
       '
       Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
       Me.btnSalir.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.btnSalir.ForeColor = System.Drawing.Color.Black
       Me.btnSalir.Image = CType(Resources.GetObject("btnSalir.Image"), System.Drawing.Image)
       Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
       Me.btnSalir.Location = New System.Drawing.Point(931, 647)
       Me.btnSalir.Name = "btnSalir"
       Me.btnSalir.Size = New System.Drawing.Size(81, 61)
       Me.btnSalir.TabIndex = 51
       Me.btnSalir.Text = "&Salir"
       Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
       Me.btnSalir.UseVisualStyleBackColor = True
       '
       'btnGuardar
       '
       Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnGuardar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.btnGuardar.ForeColor = System.Drawing.Color.Black
       Me.btnGuardar.Image = CType(Resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
       Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
       Me.btnGuardar.Location = New System.Drawing.Point(831, 647)
       Me.btnGuardar.Name = "btnGuardar"
       Me.btnGuardar.Size = New System.Drawing.Size(81, 61)
       Me.btnGuardar.TabIndex = 50
       Me.btnGuardar.Text = "&Guardar"
       Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
       Me.btnGuardar.UseVisualStyleBackColor = True
       '
       'GroupBox1
       '
       Me.GroupBox1.Location = New System.Drawing.Point(12, 17)
       Me.GroupBox1.Name = "GroupBox1"
       Me.GroupBox1.Size = New System.Drawing.Size(1420, 606)
       Me.GroupBox1.TabIndex = 0
       Me.GroupBox1.TabStop = False
       '
       'frmDetalleFactura_proveedor
       '
       Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
       Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
       Me.ClientSize = New System.Drawing.Size(1500, 768)
       Me.Controls.Add(Me.txtnumero_factura)
       Me.Controls.Add(Me.etiquetanumero_factura)
       Me.Controls.Add(Me.lblid_empresa)
       Me.Controls.Add(Me.btnBuscaempresa)
       Me.Controls.Add(Me.cmbempresa)
       Me.Controls.Add(Me.etiquetaid_empresa)
       Me.Controls.Add(Me.lblid_tipo_comprobante)
       Me.Controls.Add(Me.btnBuscatipo_comprobante)
       Me.Controls.Add(Me.cmbtipo_comprobante)
       Me.Controls.Add(Me.etiquetaid_tipo_comprobante)
       Me.Controls.Add(Me.dtpfecha)
       Me.Controls.Add(Me.etiquetafecha)
       Me.Controls.Add(Me.dtpfecha_factura)
       Me.Controls.Add(Me.etiquetafecha_factura)
       Me.Controls.Add(Me.dtpfecha_vencimiento)
       Me.Controls.Add(Me.etiquetafecha_vencimiento)
       Me.Controls.Add(Me.lblid_proveedor)
       Me.Controls.Add(Me.btnBuscaproveedor)
       Me.Controls.Add(Me.cmbproveedor)
       Me.Controls.Add(Me.etiquetaid_proveedor)
       Me.Controls.Add(Me.txtobservacion)
       Me.Controls.Add(Me.etiquetaobservacion)
       Me.Controls.Add(Me.txtsaldo)
       Me.Controls.Add(Me.etiquetasaldo)
       Me.Controls.Add(Me.txtestado)
       Me.Controls.Add(Me.etiquetaestado)
       Me.Controls.Add(Me.txtalicuota_iva)
       Me.Controls.Add(Me.etiquetaalicuota_iva)
       Me.Controls.Add(Me.txtiva_21)
       Me.Controls.Add(Me.etiquetaiva_21)
       Me.Controls.Add(Me.txtiva_10_5)
       Me.Controls.Add(Me.etiquetaiva_10_5)
       Me.Controls.Add(Me.txtimporte_21)
       Me.Controls.Add(Me.etiquetaimporte_21)
       Me.Controls.Add(Me.txtimporte_10_5)
       Me.Controls.Add(Me.etiquetaimporte_10_5)
       Me.Controls.Add(Me.txtretencion_iva)
       Me.Controls.Add(Me.etiquetaretencion_iva)
       Me.Controls.Add(Me.txtpercepcion_iva)
       Me.Controls.Add(Me.etiquetapercepcion_iva)
       Me.Controls.Add(Me.txtretencion_ingreso_bruto)
       Me.Controls.Add(Me.etiquetaretencion_ingreso_bruto)
       Me.Controls.Add(Me.txtpercepcion_ingreso_bruto)
       Me.Controls.Add(Me.etiquetapercepcion_ingreso_bruto)
       Me.Controls.Add(Me.txtretencion_ganancia)
       Me.Controls.Add(Me.etiquetaretencion_ganancia)
       Me.Controls.Add(Me.txtimpuesto_interno)
       Me.Controls.Add(Me.etiquetaimpuesto_interno)
       Me.Controls.Add(Me.txtotro)
       Me.Controls.Add(Me.etiquetaotro)
       Me.Controls.Add(Me.txttotal_21)
       Me.Controls.Add(Me.etiquetatotal_21)
       Me.Controls.Add(Me.txttotal_10_5)
       Me.Controls.Add(Me.etiquetatotal_10_5)
       Me.Controls.Add(Me.txttotal_sin)
       Me.Controls.Add(Me.etiquetatotal_sin)
       Me.Controls.Add(Me.txttotal_factura)
       Me.Controls.Add(Me.etiquetatotal_factura)
       Me.Controls.Add(Me.lblid_almacen)
       Me.Controls.Add(Me.btnBuscaalmacen)
       Me.Controls.Add(Me.cmbalmacen)
       Me.Controls.Add(Me.etiquetaid_almacen)
       Me.Controls.Add(Me.lblid_cuenta_contable)
       Me.Controls.Add(Me.btnBuscacuenta_contable)
       Me.Controls.Add(Me.cmbcuenta_contable)
       Me.Controls.Add(Me.etiquetaid_cuenta_contable)
       Me.Controls.Add(Me.lblid_usuario)
       Me.Controls.Add(Me.btnBuscausuario)
       Me.Controls.Add(Me.cmbusuario)
       Me.Controls.Add(Me.etiquetaid_usuario)
       Me.Controls.Add(Me.chktilde)
       Me.Controls.Add(Me.etiquetatilde)
       Me.Controls.Add(Me.txtreferencia)
       Me.Controls.Add(Me.etiquetareferencia)
       Me.Controls.Add(Me.txtsaldo_factura)
       Me.Controls.Add(Me.etiquetasaldo_factura)
       Me.Controls.Add(Me.chkpagada)
       Me.Controls.Add(Me.etiquetapagada)
       Me.Controls.Add(Me.lblnumero_certificado)
       Me.Controls.Add(Me.btnBuscaero_certificado)
       Me.Controls.Add(Me.cmbero_certificado)
       Me.Controls.Add(Me.etiquetanumero_certificado)
       Me.Controls.Add(Me.chkpago_a_cuenta)
       Me.Controls.Add(Me.etiquetapago_a_cuenta)
       Me.Controls.Add(Me.chksin_pago)
       Me.Controls.Add(Me.etiquetasin_pago)
       Me.Controls.Add(Me.btnSalir)
       Me.Controls.Add(Me.btnGuardar)
       Me.Controls.Add(Me.GroupBox1)
       Me.Name = "frmDetalleFactura_proveedor"
       Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
       Me.Text = "frmDetalleFactura_proveedor" & vgNombreFormulario
       Me.ResumeLayout(False)
       Me.PerformLayout()

   End Sub
   Protected WithEvents txtnumero_factura As System.Windows.Forms.TextBox
   Friend WithEvents etiquetanumero_factura As System.Windows.Forms.Label
   Friend WithEvents lblid_empresa As System.Windows.Forms.Label
   Friend WithEvents btnBuscaempresa As System.Windows.Forms.Button
   Friend WithEvents cmbempresa As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_empresa As System.Windows.Forms.Label
   Friend WithEvents lblid_tipo_comprobante As System.Windows.Forms.Label
   Friend WithEvents btnBuscatipo_comprobante As System.Windows.Forms.Button
   Friend WithEvents cmbtipo_comprobante As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_tipo_comprobante As System.Windows.Forms.Label
   Protected WithEvents dtpfecha As System.Windows.Forms.DateTimePicker
   Friend WithEvents etiquetafecha As System.Windows.Forms.Label
   Protected WithEvents dtpfecha_factura As System.Windows.Forms.DateTimePicker
   Friend WithEvents etiquetafecha_factura As System.Windows.Forms.Label
   Protected WithEvents dtpfecha_vencimiento As System.Windows.Forms.DateTimePicker
   Friend WithEvents etiquetafecha_vencimiento As System.Windows.Forms.Label
   Friend WithEvents lblid_proveedor As System.Windows.Forms.Label
   Friend WithEvents btnBuscaproveedor As System.Windows.Forms.Button
   Friend WithEvents cmbproveedor As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_proveedor As System.Windows.Forms.Label
   Protected WithEvents txtobservacion As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaobservacion As System.Windows.Forms.Label
   Protected WithEvents txtsaldo As System.Windows.Forms.TextBox
   Friend WithEvents etiquetasaldo As System.Windows.Forms.Label
   Protected WithEvents txtestado As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaestado As System.Windows.Forms.Label
   Protected WithEvents txtalicuota_iva As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaalicuota_iva As System.Windows.Forms.Label
   Protected WithEvents txtiva_21 As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaiva_21 As System.Windows.Forms.Label
   Protected WithEvents txtiva_10_5 As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaiva_10_5 As System.Windows.Forms.Label
   Protected WithEvents txtimporte_21 As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaimporte_21 As System.Windows.Forms.Label
   Protected WithEvents txtimporte_10_5 As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaimporte_10_5 As System.Windows.Forms.Label
   Protected WithEvents txtretencion_iva As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaretencion_iva As System.Windows.Forms.Label
   Protected WithEvents txtpercepcion_iva As System.Windows.Forms.TextBox
   Friend WithEvents etiquetapercepcion_iva As System.Windows.Forms.Label
   Protected WithEvents txtretencion_ingreso_bruto As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaretencion_ingreso_bruto As System.Windows.Forms.Label
   Protected WithEvents txtpercepcion_ingreso_bruto As System.Windows.Forms.TextBox
   Friend WithEvents etiquetapercepcion_ingreso_bruto As System.Windows.Forms.Label
   Protected WithEvents txtretencion_ganancia As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaretencion_ganancia As System.Windows.Forms.Label
   Protected WithEvents txtimpuesto_interno As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaimpuesto_interno As System.Windows.Forms.Label
   Protected WithEvents txtotro As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaotro As System.Windows.Forms.Label
   Protected WithEvents txttotal_21 As System.Windows.Forms.TextBox
   Friend WithEvents etiquetatotal_21 As System.Windows.Forms.Label
   Protected WithEvents txttotal_10_5 As System.Windows.Forms.TextBox
   Friend WithEvents etiquetatotal_10_5 As System.Windows.Forms.Label
   Protected WithEvents txttotal_sin As System.Windows.Forms.TextBox
   Friend WithEvents etiquetatotal_sin As System.Windows.Forms.Label
   Protected WithEvents txttotal_factura As System.Windows.Forms.TextBox
   Friend WithEvents etiquetatotal_factura As System.Windows.Forms.Label
   Friend WithEvents lblid_almacen As System.Windows.Forms.Label
   Friend WithEvents btnBuscaalmacen As System.Windows.Forms.Button
   Friend WithEvents cmbalmacen As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_almacen As System.Windows.Forms.Label
   Friend WithEvents lblid_cuenta_contable As System.Windows.Forms.Label
   Friend WithEvents btnBuscacuenta_contable As System.Windows.Forms.Button
   Friend WithEvents cmbcuenta_contable As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_cuenta_contable As System.Windows.Forms.Label
   Friend WithEvents lblid_usuario As System.Windows.Forms.Label
   Friend WithEvents btnBuscausuario As System.Windows.Forms.Button
   Friend WithEvents cmbusuario As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_usuario As System.Windows.Forms.Label
   Protected WithEvents chktilde As System.Windows.Forms.CheckBox
   Friend WithEvents etiquetatilde As System.Windows.Forms.Label
   Protected WithEvents txtreferencia As System.Windows.Forms.TextBox
   Friend WithEvents etiquetareferencia As System.Windows.Forms.Label
   Protected WithEvents txtsaldo_factura As System.Windows.Forms.TextBox
   Friend WithEvents etiquetasaldo_factura As System.Windows.Forms.Label
   Protected WithEvents chkpagada As System.Windows.Forms.CheckBox
   Friend WithEvents etiquetapagada As System.Windows.Forms.Label
   Friend WithEvents lblnumero_certificado As System.Windows.Forms.Label
   Friend WithEvents btnBuscaero_certificado As System.Windows.Forms.Button
   Friend WithEvents cmbero_certificado As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetanumero_certificado As System.Windows.Forms.Label
   Protected WithEvents chkpago_a_cuenta As System.Windows.Forms.CheckBox
   Friend WithEvents etiquetapago_a_cuenta As System.Windows.Forms.Label
   Protected WithEvents chksin_pago As System.Windows.Forms.CheckBox
   Friend WithEvents etiquetasin_pago As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
End Class

