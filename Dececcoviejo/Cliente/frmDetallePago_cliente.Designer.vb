<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetallePago_cliente
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetallePago_cliente))
        Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblid_cliente = New System.Windows.Forms.Label
        Me.cmbcliente = New System.Windows.Forms.ComboBox
        Me.etiquetaid_cliente = New System.Windows.Forms.Label
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker
        Me.etiquetafecha = New System.Windows.Forms.Label
        Me.txtpago = New System.Windows.Forms.TextBox
        Me.etiquetapago = New System.Windows.Forms.Label
        Me.txtdetalle = New System.Windows.Forms.TextBox
        Me.etiquetadetalle = New System.Windows.Forms.Label
        Me.chkefectivo = New System.Windows.Forms.CheckBox
        Me.etiquetaefectivo = New System.Windows.Forms.Label
        Me.etiquetanumero_recibo = New System.Windows.Forms.Label
        Me.txtretencion_iva = New System.Windows.Forms.TextBox
        Me.etiquetaretencion_iva = New System.Windows.Forms.Label
        Me.txtingreso_bruto = New System.Windows.Forms.TextBox
        Me.etiquetaingreso_bruto = New System.Windows.Forms.Label
        Me.txtimpuesto_ganancia = New System.Windows.Forms.TextBox
        Me.etiquetaimpuesto_ganancia = New System.Windows.Forms.Label
        Me.txtsuss = New System.Windows.Forms.TextBox
        Me.etiquetasuss = New System.Windows.Forms.Label
        Me.lblid_pk_2 = New System.Windows.Forms.Label
        Me.dgv2 = New System.Windows.Forms.DataGridView
        Me.lblid_pk = New System.Windows.Forms.Label
        Me.dgv1 = New System.Windows.Forms.DataGridView
        Me.lblid_pago_cliente = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtTotalFactura = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtTotalCheque = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtNumero_8 = New System.Windows.Forms.TextBox
        Me.txtNumero_4 = New System.Windows.Forms.TextBox
        Me.lblid_factura = New System.Windows.Forms.Label
        Me.lblid_cheque_recibido = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtRetenciones_cheques = New System.Windows.Forms.TextBox
        Me.lblid_cheque_recibido_2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblid_pk_3 = New System.Windows.Forms.Label
        Me.dgv3 = New System.Windows.Forms.DataGridView
        Me.txtObservacion = New System.Windows.Forms.TextBox
        Me.etiquetaObservacion = New System.Windows.Forms.Label
        Me.lblid_ingreso_efectivo = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblid_pk_4 = New System.Windows.Forms.Label
        Me.dgv4 = New System.Windows.Forms.DataGridView
        Me.btnAgregar_ingreso_efectivo = New System.Windows.Forms.Button
        Me.btnModificar_ingreso_efectivo = New System.Windows.Forms.Button
        Me.btnBorrar_ingreso_efectivo = New System.Windows.Forms.Button
        Me.btnAgregar_3 = New System.Windows.Forms.Button
        Me.btnModificar_3 = New System.Windows.Forms.Button
        Me.btnBorrar_3 = New System.Windows.Forms.Button
        Me.btnAgregar_2 = New System.Windows.Forms.Button
        Me.btnModificar_2 = New System.Windows.Forms.Button
        Me.btnBorrar_2 = New System.Windows.Forms.Button
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.btnModificar = New System.Windows.Forms.Button
        Me.btnBorrar = New System.Windows.Forms.Button
        Me.btnBuscacliente = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblid_cliente
        '
        Me.lblid_cliente.AutoSize = True
        Me.lblid_cliente.BackColor = System.Drawing.Color.Red
        Me.lblid_cliente.Location = New System.Drawing.Point(318, 28)
        Me.lblid_cliente.Name = "lblid_cliente"
        Me.lblid_cliente.Size = New System.Drawing.Size(13, 13)
        Me.lblid_cliente.TabIndex = 500
        Me.lblid_cliente.Text = "0"
        Me.lblid_cliente.Visible = False
        '
        'cmbcliente
        '
        Me.cmbcliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbcliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbcliente.Enabled = False
        Me.cmbcliente.FormattingEnabled = True
        Me.cmbcliente.Location = New System.Drawing.Point(109, 28)
        Me.cmbcliente.Name = "cmbcliente"
        Me.cmbcliente.Size = New System.Drawing.Size(329, 21)
        Me.cmbcliente.TabIndex = 4
        '
        'etiquetaid_cliente
        '
        Me.etiquetaid_cliente.AutoSize = True
        Me.etiquetaid_cliente.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaid_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_cliente.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_cliente.Location = New System.Drawing.Point(58, 30)
        Me.etiquetaid_cliente.Name = "etiquetaid_cliente"
        Me.etiquetaid_cliente.Size = New System.Drawing.Size(45, 15)
        Me.etiquetaid_cliente.TabIndex = 501
        Me.etiquetaid_cliente.Text = "Cliente"
        Me.etiquetaid_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpfecha
        '
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha.Location = New System.Drawing.Point(109, 63)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(93, 20)
        Me.dtpfecha.TabIndex = 5
        '
        'etiquetafecha
        '
        Me.etiquetafecha.AutoSize = True
        Me.etiquetafecha.BackColor = System.Drawing.Color.Transparent
        Me.etiquetafecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetafecha.ForeColor = System.Drawing.Color.Black
        Me.etiquetafecha.Location = New System.Drawing.Point(62, 65)
        Me.etiquetafecha.Name = "etiquetafecha"
        Me.etiquetafecha.Size = New System.Drawing.Size(41, 15)
        Me.etiquetafecha.TabIndex = 502
        Me.etiquetafecha.Text = "Fecha"
        Me.etiquetafecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtpago
        '
        Me.txtpago.BackColor = System.Drawing.Color.White
        Me.txtpago.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpago.ForeColor = System.Drawing.Color.Blue
        Me.txtpago.Location = New System.Drawing.Point(109, 95)
        Me.txtpago.MaxLength = 50
        Me.txtpago.Name = "txtpago"
        Me.txtpago.Size = New System.Drawing.Size(222, 31)
        Me.txtpago.TabIndex = 6
        Me.txtpago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetapago
        '
        Me.etiquetapago.AutoSize = True
        Me.etiquetapago.BackColor = System.Drawing.Color.Transparent
        Me.etiquetapago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetapago.ForeColor = System.Drawing.Color.Black
        Me.etiquetapago.Location = New System.Drawing.Point(67, 97)
        Me.etiquetapago.Name = "etiquetapago"
        Me.etiquetapago.Size = New System.Drawing.Size(36, 15)
        Me.etiquetapago.TabIndex = 503
        Me.etiquetapago.Text = "Pago"
        Me.etiquetapago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtdetalle
        '
        Me.txtdetalle.BackColor = System.Drawing.Color.White
        Me.txtdetalle.Location = New System.Drawing.Point(109, 137)
        Me.txtdetalle.MaxLength = 50
        Me.txtdetalle.Name = "txtdetalle"
        Me.txtdetalle.Size = New System.Drawing.Size(385, 20)
        Me.txtdetalle.TabIndex = 7
        '
        'etiquetadetalle
        '
        Me.etiquetadetalle.AutoSize = True
        Me.etiquetadetalle.BackColor = System.Drawing.Color.Transparent
        Me.etiquetadetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetadetalle.ForeColor = System.Drawing.Color.Black
        Me.etiquetadetalle.Location = New System.Drawing.Point(57, 139)
        Me.etiquetadetalle.Name = "etiquetadetalle"
        Me.etiquetadetalle.Size = New System.Drawing.Size(46, 15)
        Me.etiquetadetalle.TabIndex = 504
        Me.etiquetadetalle.Text = "Detalle"
        Me.etiquetadetalle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkefectivo
        '
        Me.chkefectivo.AutoSize = True
        Me.chkefectivo.Checked = True
        Me.chkefectivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkefectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkefectivo.Location = New System.Drawing.Point(725, 8)
        Me.chkefectivo.Name = "chkefectivo"
        Me.chkefectivo.Size = New System.Drawing.Size(84, 21)
        Me.chkefectivo.TabIndex = 8
        Me.chkefectivo.Text = "efectivo"
        Me.chkefectivo.Visible = False
        '
        'etiquetaefectivo
        '
        Me.etiquetaefectivo.AutoSize = True
        Me.etiquetaefectivo.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaefectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaefectivo.ForeColor = System.Drawing.Color.Black
        Me.etiquetaefectivo.Location = New System.Drawing.Point(670, 9)
        Me.etiquetaefectivo.Name = "etiquetaefectivo"
        Me.etiquetaefectivo.Size = New System.Drawing.Size(49, 15)
        Me.etiquetaefectivo.TabIndex = 505
        Me.etiquetaefectivo.Text = "Efectivo"
        Me.etiquetaefectivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.etiquetaefectivo.Visible = False
        '
        'etiquetanumero_recibo
        '
        Me.etiquetanumero_recibo.AutoSize = True
        Me.etiquetanumero_recibo.BackColor = System.Drawing.Color.Transparent
        Me.etiquetanumero_recibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetanumero_recibo.ForeColor = System.Drawing.Color.Black
        Me.etiquetanumero_recibo.Location = New System.Drawing.Point(10, 173)
        Me.etiquetanumero_recibo.Name = "etiquetanumero_recibo"
        Me.etiquetanumero_recibo.Size = New System.Drawing.Size(93, 15)
        Me.etiquetanumero_recibo.TabIndex = 506
        Me.etiquetanumero_recibo.Text = "Numero_recibo"
        Me.etiquetanumero_recibo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtretencion_iva
        '
        Me.txtretencion_iva.BackColor = System.Drawing.Color.White
        Me.txtretencion_iva.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtretencion_iva.ForeColor = System.Drawing.Color.Blue
        Me.txtretencion_iva.Location = New System.Drawing.Point(725, 30)
        Me.txtretencion_iva.MaxLength = 50
        Me.txtretencion_iva.Name = "txtretencion_iva"
        Me.txtretencion_iva.Size = New System.Drawing.Size(222, 31)
        Me.txtretencion_iva.TabIndex = 11
        Me.txtretencion_iva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetaretencion_iva
        '
        Me.etiquetaretencion_iva.AutoSize = True
        Me.etiquetaretencion_iva.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaretencion_iva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaretencion_iva.ForeColor = System.Drawing.Color.Black
        Me.etiquetaretencion_iva.Location = New System.Drawing.Point(634, 40)
        Me.etiquetaretencion_iva.Name = "etiquetaretencion_iva"
        Me.etiquetaretencion_iva.Size = New System.Drawing.Size(85, 15)
        Me.etiquetaretencion_iva.TabIndex = 507
        Me.etiquetaretencion_iva.Text = "Retencion_iva"
        Me.etiquetaretencion_iva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtingreso_bruto
        '
        Me.txtingreso_bruto.BackColor = System.Drawing.Color.White
        Me.txtingreso_bruto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtingreso_bruto.ForeColor = System.Drawing.Color.Blue
        Me.txtingreso_bruto.Location = New System.Drawing.Point(725, 72)
        Me.txtingreso_bruto.MaxLength = 50
        Me.txtingreso_bruto.Name = "txtingreso_bruto"
        Me.txtingreso_bruto.Size = New System.Drawing.Size(222, 31)
        Me.txtingreso_bruto.TabIndex = 12
        Me.txtingreso_bruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetaingreso_bruto
        '
        Me.etiquetaingreso_bruto.AutoSize = True
        Me.etiquetaingreso_bruto.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaingreso_bruto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaingreso_bruto.ForeColor = System.Drawing.Color.Black
        Me.etiquetaingreso_bruto.Location = New System.Drawing.Point(636, 82)
        Me.etiquetaingreso_bruto.Name = "etiquetaingreso_bruto"
        Me.etiquetaingreso_bruto.Size = New System.Drawing.Size(83, 15)
        Me.etiquetaingreso_bruto.TabIndex = 508
        Me.etiquetaingreso_bruto.Text = "Ingreso_bruto"
        Me.etiquetaingreso_bruto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtimpuesto_ganancia
        '
        Me.txtimpuesto_ganancia.BackColor = System.Drawing.Color.White
        Me.txtimpuesto_ganancia.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtimpuesto_ganancia.ForeColor = System.Drawing.Color.Blue
        Me.txtimpuesto_ganancia.Location = New System.Drawing.Point(725, 116)
        Me.txtimpuesto_ganancia.MaxLength = 50
        Me.txtimpuesto_ganancia.Name = "txtimpuesto_ganancia"
        Me.txtimpuesto_ganancia.Size = New System.Drawing.Size(222, 31)
        Me.txtimpuesto_ganancia.TabIndex = 13
        Me.txtimpuesto_ganancia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetaimpuesto_ganancia
        '
        Me.etiquetaimpuesto_ganancia.AutoSize = True
        Me.etiquetaimpuesto_ganancia.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaimpuesto_ganancia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaimpuesto_ganancia.ForeColor = System.Drawing.Color.Black
        Me.etiquetaimpuesto_ganancia.Location = New System.Drawing.Point(603, 126)
        Me.etiquetaimpuesto_ganancia.Name = "etiquetaimpuesto_ganancia"
        Me.etiquetaimpuesto_ganancia.Size = New System.Drawing.Size(116, 15)
        Me.etiquetaimpuesto_ganancia.TabIndex = 509
        Me.etiquetaimpuesto_ganancia.Text = "Impuesto_ganancia"
        Me.etiquetaimpuesto_ganancia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtsuss
        '
        Me.txtsuss.BackColor = System.Drawing.Color.White
        Me.txtsuss.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsuss.ForeColor = System.Drawing.Color.Blue
        Me.txtsuss.Location = New System.Drawing.Point(725, 162)
        Me.txtsuss.MaxLength = 50
        Me.txtsuss.Name = "txtsuss"
        Me.txtsuss.Size = New System.Drawing.Size(222, 31)
        Me.txtsuss.TabIndex = 14
        Me.txtsuss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetasuss
        '
        Me.etiquetasuss.AutoSize = True
        Me.etiquetasuss.BackColor = System.Drawing.Color.Transparent
        Me.etiquetasuss.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetasuss.ForeColor = System.Drawing.Color.Black
        Me.etiquetasuss.Location = New System.Drawing.Point(685, 172)
        Me.etiquetasuss.Name = "etiquetasuss"
        Me.etiquetasuss.Size = New System.Drawing.Size(34, 15)
        Me.etiquetasuss.TabIndex = 510
        Me.etiquetasuss.Text = "Suss"
        Me.etiquetasuss.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_pk_2
        '
        Me.lblid_pk_2.AutoSize = True
        Me.lblid_pk_2.BackColor = System.Drawing.Color.Red
        Me.lblid_pk_2.Location = New System.Drawing.Point(158, 540)
        Me.lblid_pk_2.Name = "lblid_pk_2"
        Me.lblid_pk_2.Size = New System.Drawing.Size(13, 13)
        Me.lblid_pk_2.TabIndex = 580
        Me.lblid_pk_2.Text = "0"
        Me.lblid_pk_2.Visible = False
        '
        'dgv2
        '
        Me.dgv2.AllowUserToAddRows = False
        Me.dgv2.AllowUserToResizeColumns = False
        Me.dgv2.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Brown
        Me.dgv2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv2.BackgroundColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Beige
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Brown
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv2.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv2.GridColor = System.Drawing.Color.MediumPurple
        Me.dgv2.Location = New System.Drawing.Point(135, 501)
        Me.dgv2.Name = "dgv2"
        Me.dgv2.ReadOnly = True
        Me.dgv2.ShowCellErrors = False
        Me.dgv2.ShowRowErrors = False
        Me.dgv2.Size = New System.Drawing.Size(334, 190)
        Me.dgv2.StandardTab = True
        Me.dgv2.TabIndex = 579
        '
        'lblid_pk
        '
        Me.lblid_pk.AutoSize = True
        Me.lblid_pk.BackColor = System.Drawing.Color.Red
        Me.lblid_pk.Location = New System.Drawing.Point(158, 280)
        Me.lblid_pk.Name = "lblid_pk"
        Me.lblid_pk.Size = New System.Drawing.Size(13, 13)
        Me.lblid_pk.TabIndex = 575
        Me.lblid_pk.Text = "0"
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
        Me.dgv1.BackgroundColor = System.Drawing.Color.Gray
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
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Beige
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Brown
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv1.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgv1.GridColor = System.Drawing.Color.MediumPurple
        Me.dgv1.Location = New System.Drawing.Point(135, 241)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.ShowCellErrors = False
        Me.dgv1.ShowRowErrors = False
        Me.dgv1.Size = New System.Drawing.Size(334, 190)
        Me.dgv1.StandardTab = True
        Me.dgv1.TabIndex = 574
        '
        'lblid_pago_cliente
        '
        Me.lblid_pago_cliente.AutoSize = True
        Me.lblid_pago_cliente.BackColor = System.Drawing.Color.Red
        Me.lblid_pago_cliente.Location = New System.Drawing.Point(28, 28)
        Me.lblid_pago_cliente.Name = "lblid_pago_cliente"
        Me.lblid_pago_cliente.Size = New System.Drawing.Size(13, 13)
        Me.lblid_pago_cliente.TabIndex = 581
        Me.lblid_pago_cliente.Text = "0"
        Me.lblid_pago_cliente.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(132, 225)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 582
        Me.Label1.Text = "FACTURAS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(623, 485)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 13)
        Me.Label2.TabIndex = 583
        Me.Label2.Text = "CHEQUES RECIBIDOS BANCO"
        '
        'txtTotalFactura
        '
        Me.txtTotalFactura.BackColor = System.Drawing.Color.White
        Me.txtTotalFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalFactura.ForeColor = System.Drawing.Color.Blue
        Me.txtTotalFactura.Location = New System.Drawing.Point(222, 439)
        Me.txtTotalFactura.MaxLength = 50
        Me.txtTotalFactura.Name = "txtTotalFactura"
        Me.txtTotalFactura.Size = New System.Drawing.Size(247, 31)
        Me.txtTotalFactura.TabIndex = 584
        Me.txtTotalFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(132, 449)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 15)
        Me.Label3.TabIndex = 585
        Me.Label3.Text = "Total Facturas"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTotalCheque
        '
        Me.txtTotalCheque.BackColor = System.Drawing.Color.White
        Me.txtTotalCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCheque.ForeColor = System.Drawing.Color.Blue
        Me.txtTotalCheque.Location = New System.Drawing.Point(222, 697)
        Me.txtTotalCheque.MaxLength = 50
        Me.txtTotalCheque.Name = "txtTotalCheque"
        Me.txtTotalCheque.Size = New System.Drawing.Size(247, 31)
        Me.txtTotalCheque.TabIndex = 702
        Me.txtTotalCheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(131, 701)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 15)
        Me.Label4.TabIndex = 587
        Me.Label4.Text = "Total Cheques"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNumero_8
        '
        Me.txtNumero_8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero_8.Location = New System.Drawing.Point(196, 171)
        Me.txtNumero_8.MaxLength = 8
        Me.txtNumero_8.Name = "txtNumero_8"
        Me.txtNumero_8.Size = New System.Drawing.Size(135, 20)
        Me.txtNumero_8.TabIndex = 9
        Me.txtNumero_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNumero_4
        '
        Me.txtNumero_4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero_4.Location = New System.Drawing.Point(109, 171)
        Me.txtNumero_4.MaxLength = 4
        Me.txtNumero_4.Name = "txtNumero_4"
        Me.txtNumero_4.Size = New System.Drawing.Size(72, 20)
        Me.txtNumero_4.TabIndex = 8
        Me.txtNumero_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblid_factura
        '
        Me.lblid_factura.AutoSize = True
        Me.lblid_factura.BackColor = System.Drawing.Color.Red
        Me.lblid_factura.Location = New System.Drawing.Point(183, 280)
        Me.lblid_factura.Name = "lblid_factura"
        Me.lblid_factura.Size = New System.Drawing.Size(13, 13)
        Me.lblid_factura.TabIndex = 616
        Me.lblid_factura.Text = "0"
        '
        'lblid_cheque_recibido
        '
        Me.lblid_cheque_recibido.AutoSize = True
        Me.lblid_cheque_recibido.BackColor = System.Drawing.Color.Red
        Me.lblid_cheque_recibido.Location = New System.Drawing.Point(183, 540)
        Me.lblid_cheque_recibido.Name = "lblid_cheque_recibido"
        Me.lblid_cheque_recibido.Size = New System.Drawing.Size(13, 13)
        Me.lblid_cheque_recibido.TabIndex = 617
        Me.lblid_cheque_recibido.Text = "0"
        Me.lblid_cheque_recibido.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(522, 454)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 15)
        Me.Label5.TabIndex = 618
        Me.Label5.Text = "Cheques + Retenciones :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtRetenciones_cheques
        '
        Me.txtRetenciones_cheques.BackColor = System.Drawing.Color.White
        Me.txtRetenciones_cheques.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRetenciones_cheques.ForeColor = System.Drawing.Color.Blue
        Me.txtRetenciones_cheques.Location = New System.Drawing.Point(672, 444)
        Me.txtRetenciones_cheques.MaxLength = 50
        Me.txtRetenciones_cheques.Name = "txtRetenciones_cheques"
        Me.txtRetenciones_cheques.Size = New System.Drawing.Size(222, 31)
        Me.txtRetenciones_cheques.TabIndex = 701
        Me.txtRetenciones_cheques.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblid_cheque_recibido_2
        '
        Me.lblid_cheque_recibido_2.AutoSize = True
        Me.lblid_cheque_recibido_2.BackColor = System.Drawing.Color.Red
        Me.lblid_cheque_recibido_2.Location = New System.Drawing.Point(699, 540)
        Me.lblid_cheque_recibido_2.Name = "lblid_cheque_recibido_2"
        Me.lblid_cheque_recibido_2.Size = New System.Drawing.Size(13, 13)
        Me.lblid_cheque_recibido_2.TabIndex = 633
        Me.lblid_cheque_recibido_2.Text = "0"
        Me.lblid_cheque_recibido_2.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(132, 485)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 13)
        Me.Label6.TabIndex = 629
        Me.Label6.Text = "CHEQUE RECIBIDO CAJA"
        '
        'lblid_pk_3
        '
        Me.lblid_pk_3.AutoSize = True
        Me.lblid_pk_3.BackColor = System.Drawing.Color.Red
        Me.lblid_pk_3.Location = New System.Drawing.Point(657, 540)
        Me.lblid_pk_3.Name = "lblid_pk_3"
        Me.lblid_pk_3.Size = New System.Drawing.Size(13, 13)
        Me.lblid_pk_3.TabIndex = 628
        Me.lblid_pk_3.Text = "0"
        Me.lblid_pk_3.Visible = False
        '
        'dgv3
        '
        Me.dgv3.AllowUserToAddRows = False
        Me.dgv3.AllowUserToResizeColumns = False
        Me.dgv3.AllowUserToResizeRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Brown
        Me.dgv3.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgv3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv3.BackgroundColor = System.Drawing.Color.Gray
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv3.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Beige
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Brown
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv3.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgv3.GridColor = System.Drawing.Color.MediumPurple
        Me.dgv3.Location = New System.Drawing.Point(591, 501)
        Me.dgv3.Name = "dgv3"
        Me.dgv3.ReadOnly = True
        Me.dgv3.ShowCellErrors = False
        Me.dgv3.ShowRowErrors = False
        Me.dgv3.Size = New System.Drawing.Size(302, 190)
        Me.dgv3.StandardTab = True
        Me.dgv3.TabIndex = 627
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(109, 197)
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(871, 20)
        Me.txtObservacion.TabIndex = 10
        '
        'etiquetaObservacion
        '
        Me.etiquetaObservacion.AutoSize = True
        Me.etiquetaObservacion.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaObservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaObservacion.ForeColor = System.Drawing.Color.Black
        Me.etiquetaObservacion.Location = New System.Drawing.Point(28, 200)
        Me.etiquetaObservacion.Name = "etiquetaObservacion"
        Me.etiquetaObservacion.Size = New System.Drawing.Size(75, 15)
        Me.etiquetaObservacion.TabIndex = 636
        Me.etiquetaObservacion.Text = "Observacion"
        Me.etiquetaObservacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_ingreso_efectivo
        '
        Me.lblid_ingreso_efectivo.AutoSize = True
        Me.lblid_ingreso_efectivo.BackColor = System.Drawing.Color.Red
        Me.lblid_ingreso_efectivo.Location = New System.Drawing.Point(704, 295)
        Me.lblid_ingreso_efectivo.Name = "lblid_ingreso_efectivo"
        Me.lblid_ingreso_efectivo.Size = New System.Drawing.Size(13, 13)
        Me.lblid_ingreso_efectivo.TabIndex = 709
        Me.lblid_ingreso_efectivo.Text = "0"
        Me.lblid_ingreso_efectivo.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(588, 225)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 13)
        Me.Label8.TabIndex = 705
        Me.Label8.Text = "INGRESOS EN EFECTIVO"
        '
        'lblid_pk_4
        '
        Me.lblid_pk_4.AutoSize = True
        Me.lblid_pk_4.BackColor = System.Drawing.Color.Red
        Me.lblid_pk_4.Location = New System.Drawing.Point(662, 295)
        Me.lblid_pk_4.Name = "lblid_pk_4"
        Me.lblid_pk_4.Size = New System.Drawing.Size(13, 13)
        Me.lblid_pk_4.TabIndex = 704
        Me.lblid_pk_4.Text = "0"
        Me.lblid_pk_4.Visible = False
        '
        'dgv4
        '
        Me.dgv4.AllowUserToAddRows = False
        Me.dgv4.AllowUserToResizeColumns = False
        Me.dgv4.AllowUserToResizeRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Brown
        Me.dgv4.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgv4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv4.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv4.BackgroundColor = System.Drawing.Color.Gray
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv4.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgv4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Beige
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Brown
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv4.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgv4.GridColor = System.Drawing.Color.MediumPurple
        Me.dgv4.Location = New System.Drawing.Point(591, 242)
        Me.dgv4.Name = "dgv4"
        Me.dgv4.ReadOnly = True
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv4.RowHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgv4.ShowCellErrors = False
        Me.dgv4.ShowRowErrors = False
        Me.dgv4.Size = New System.Drawing.Size(305, 190)
        Me.dgv4.StandardTab = True
        Me.dgv4.TabIndex = 703
        '
        'btnAgregar_ingreso_efectivo
        '
        Me.btnAgregar_ingreso_efectivo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar_ingreso_efectivo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar_ingreso_efectivo.Image = CType(resources.GetObject("btnAgregar_ingreso_efectivo.Image"), System.Drawing.Image)
        Me.btnAgregar_ingreso_efectivo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAgregar_ingreso_efectivo.Location = New System.Drawing.Point(498, 242)
        Me.btnAgregar_ingreso_efectivo.Name = "btnAgregar_ingreso_efectivo"
        Me.btnAgregar_ingreso_efectivo.Size = New System.Drawing.Size(75, 49)
        Me.btnAgregar_ingreso_efectivo.TabIndex = 710
        Me.btnAgregar_ingreso_efectivo.Text = "&Agregar"
        Me.btnAgregar_ingreso_efectivo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregar_ingreso_efectivo.UseVisualStyleBackColor = True
        '
        'btnModificar_ingreso_efectivo
        '
        Me.btnModificar_ingreso_efectivo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar_ingreso_efectivo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar_ingreso_efectivo.Image = CType(resources.GetObject("btnModificar_ingreso_efectivo.Image"), System.Drawing.Image)
        Me.btnModificar_ingreso_efectivo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModificar_ingreso_efectivo.Location = New System.Drawing.Point(498, 311)
        Me.btnModificar_ingreso_efectivo.Name = "btnModificar_ingreso_efectivo"
        Me.btnModificar_ingreso_efectivo.Size = New System.Drawing.Size(75, 49)
        Me.btnModificar_ingreso_efectivo.TabIndex = 711
        Me.btnModificar_ingreso_efectivo.Text = "&Modificar"
        Me.btnModificar_ingreso_efectivo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificar_ingreso_efectivo.UseVisualStyleBackColor = True
        '
        'btnBorrar_ingreso_efectivo
        '
        Me.btnBorrar_ingreso_efectivo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrar_ingreso_efectivo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar_ingreso_efectivo.Image = CType(resources.GetObject("btnBorrar_ingreso_efectivo.Image"), System.Drawing.Image)
        Me.btnBorrar_ingreso_efectivo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBorrar_ingreso_efectivo.Location = New System.Drawing.Point(498, 382)
        Me.btnBorrar_ingreso_efectivo.Name = "btnBorrar_ingreso_efectivo"
        Me.btnBorrar_ingreso_efectivo.Size = New System.Drawing.Size(75, 49)
        Me.btnBorrar_ingreso_efectivo.TabIndex = 712
        Me.btnBorrar_ingreso_efectivo.Text = "&Borrar"
        Me.btnBorrar_ingreso_efectivo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBorrar_ingreso_efectivo.UseVisualStyleBackColor = True
        '
        'btnAgregar_3
        '
        Me.btnAgregar_3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar_3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar_3.Image = CType(resources.GetObject("btnAgregar_3.Image"), System.Drawing.Image)
        Me.btnAgregar_3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAgregar_3.Location = New System.Drawing.Point(498, 502)
        Me.btnAgregar_3.Name = "btnAgregar_3"
        Me.btnAgregar_3.Size = New System.Drawing.Size(75, 49)
        Me.btnAgregar_3.TabIndex = 60
        Me.btnAgregar_3.Text = "&Agregar"
        Me.btnAgregar_3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregar_3.UseVisualStyleBackColor = True
        '
        'btnModificar_3
        '
        Me.btnModificar_3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar_3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar_3.Image = CType(resources.GetObject("btnModificar_3.Image"), System.Drawing.Image)
        Me.btnModificar_3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModificar_3.Location = New System.Drawing.Point(498, 571)
        Me.btnModificar_3.Name = "btnModificar_3"
        Me.btnModificar_3.Size = New System.Drawing.Size(75, 49)
        Me.btnModificar_3.TabIndex = 61
        Me.btnModificar_3.Text = "&Modificar"
        Me.btnModificar_3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificar_3.UseVisualStyleBackColor = True
        '
        'btnBorrar_3
        '
        Me.btnBorrar_3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrar_3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar_3.Image = CType(resources.GetObject("btnBorrar_3.Image"), System.Drawing.Image)
        Me.btnBorrar_3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBorrar_3.Location = New System.Drawing.Point(498, 642)
        Me.btnBorrar_3.Name = "btnBorrar_3"
        Me.btnBorrar_3.Size = New System.Drawing.Size(75, 49)
        Me.btnBorrar_3.TabIndex = 62
        Me.btnBorrar_3.Text = "&Borrar"
        Me.btnBorrar_3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBorrar_3.UseVisualStyleBackColor = True
        '
        'btnAgregar_2
        '
        Me.btnAgregar_2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar_2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar_2.Image = CType(resources.GetObject("btnAgregar_2.Image"), System.Drawing.Image)
        Me.btnAgregar_2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAgregar_2.Location = New System.Drawing.Point(28, 501)
        Me.btnAgregar_2.Name = "btnAgregar_2"
        Me.btnAgregar_2.Size = New System.Drawing.Size(75, 49)
        Me.btnAgregar_2.TabIndex = 50
        Me.btnAgregar_2.Text = "&Agregar"
        Me.btnAgregar_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregar_2.UseVisualStyleBackColor = True
        '
        'btnModificar_2
        '
        Me.btnModificar_2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar_2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar_2.Image = CType(resources.GetObject("btnModificar_2.Image"), System.Drawing.Image)
        Me.btnModificar_2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModificar_2.Location = New System.Drawing.Point(28, 571)
        Me.btnModificar_2.Name = "btnModificar_2"
        Me.btnModificar_2.Size = New System.Drawing.Size(75, 49)
        Me.btnModificar_2.TabIndex = 51
        Me.btnModificar_2.Text = "&Modificar"
        Me.btnModificar_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificar_2.UseVisualStyleBackColor = True
        '
        'btnBorrar_2
        '
        Me.btnBorrar_2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrar_2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar_2.Image = CType(resources.GetObject("btnBorrar_2.Image"), System.Drawing.Image)
        Me.btnBorrar_2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBorrar_2.Location = New System.Drawing.Point(28, 642)
        Me.btnBorrar_2.Name = "btnBorrar_2"
        Me.btnBorrar_2.Size = New System.Drawing.Size(75, 49)
        Me.btnBorrar_2.TabIndex = 52
        Me.btnBorrar_2.Text = "&Borrar"
        Me.btnBorrar_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBorrar_2.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAgregar.Location = New System.Drawing.Point(28, 241)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 49)
        Me.btnAgregar.TabIndex = 40
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
        Me.btnModificar.Location = New System.Drawing.Point(28, 311)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 49)
        Me.btnModificar.TabIndex = 41
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
        Me.btnBorrar.Location = New System.Drawing.Point(28, 382)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 49)
        Me.btnBorrar.TabIndex = 42
        Me.btnBorrar.Text = "&Borrar"
        Me.btnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnBuscacliente
        '
        Me.btnBuscacliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscacliente.Enabled = False
        Me.btnBuscacliente.Image = CType(resources.GetObject("btnBuscacliente.Image"), System.Drawing.Image)
        Me.btnBuscacliente.Location = New System.Drawing.Point(453, 28)
        Me.btnBuscacliente.Name = "btnBuscacliente"
        Me.btnBuscacliente.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscacliente.TabIndex = 30
        Me.btnBuscacliente.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(921, 484)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(78, 69)
        Me.btnSalir.TabIndex = 62
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
        Me.btnGuardar.Location = New System.Drawing.Point(921, 409)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(78, 69)
        Me.btnGuardar.TabIndex = 61
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'frmDetallePago_cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 741)
        Me.Controls.Add(Me.btnAgregar_ingreso_efectivo)
        Me.Controls.Add(Me.btnModificar_ingreso_efectivo)
        Me.Controls.Add(Me.btnBorrar_ingreso_efectivo)
        Me.Controls.Add(Me.lblid_ingreso_efectivo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblid_pk_4)
        Me.Controls.Add(Me.dgv4)
        Me.Controls.Add(Me.etiquetaObservacion)
        Me.Controls.Add(Me.txtObservacion)
        Me.Controls.Add(Me.lblid_cheque_recibido_2)
        Me.Controls.Add(Me.btnAgregar_3)
        Me.Controls.Add(Me.btnModificar_3)
        Me.Controls.Add(Me.btnBorrar_3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblid_pk_3)
        Me.Controls.Add(Me.dgv3)
        Me.Controls.Add(Me.txtRetenciones_cheques)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblid_cheque_recibido)
        Me.Controls.Add(Me.lblid_factura)
        Me.Controls.Add(Me.txtNumero_8)
        Me.Controls.Add(Me.txtNumero_4)
        Me.Controls.Add(Me.txtTotalCheque)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTotalFactura)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblid_pago_cliente)
        Me.Controls.Add(Me.btnAgregar_2)
        Me.Controls.Add(Me.btnModificar_2)
        Me.Controls.Add(Me.btnBorrar_2)
        Me.Controls.Add(Me.lblid_pk_2)
        Me.Controls.Add(Me.dgv2)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.lblid_pk)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.lblid_cliente)
        Me.Controls.Add(Me.btnBuscacliente)
        Me.Controls.Add(Me.cmbcliente)
        Me.Controls.Add(Me.etiquetaid_cliente)
        Me.Controls.Add(Me.dtpfecha)
        Me.Controls.Add(Me.etiquetafecha)
        Me.Controls.Add(Me.txtpago)
        Me.Controls.Add(Me.etiquetapago)
        Me.Controls.Add(Me.txtdetalle)
        Me.Controls.Add(Me.etiquetadetalle)
        Me.Controls.Add(Me.chkefectivo)
        Me.Controls.Add(Me.etiquetaefectivo)
        Me.Controls.Add(Me.etiquetanumero_recibo)
        Me.Controls.Add(Me.txtretencion_iva)
        Me.Controls.Add(Me.etiquetaretencion_iva)
        Me.Controls.Add(Me.txtingreso_bruto)
        Me.Controls.Add(Me.etiquetaingreso_bruto)
        Me.Controls.Add(Me.txtimpuesto_ganancia)
        Me.Controls.Add(Me.etiquetaimpuesto_ganancia)
        Me.Controls.Add(Me.txtsuss)
        Me.Controls.Add(Me.etiquetasuss)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Name = "frmDetallePago_cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetallePago_cliente"
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblid_cliente As System.Windows.Forms.Label
    Friend WithEvents btnBuscacliente As System.Windows.Forms.Button
    Friend WithEvents cmbcliente As System.Windows.Forms.ComboBox
    Friend WithEvents etiquetaid_cliente As System.Windows.Forms.Label
    Protected WithEvents dtpfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents etiquetafecha As System.Windows.Forms.Label
    Protected WithEvents txtpago As System.Windows.Forms.TextBox
    Friend WithEvents etiquetapago As System.Windows.Forms.Label
    Protected WithEvents txtdetalle As System.Windows.Forms.TextBox
    Friend WithEvents etiquetadetalle As System.Windows.Forms.Label
    Protected WithEvents chkefectivo As System.Windows.Forms.CheckBox
    Friend WithEvents etiquetaefectivo As System.Windows.Forms.Label
    Friend WithEvents etiquetanumero_recibo As System.Windows.Forms.Label
    Protected WithEvents txtretencion_iva As System.Windows.Forms.TextBox
    Friend WithEvents etiquetaretencion_iva As System.Windows.Forms.Label
    Protected WithEvents txtingreso_bruto As System.Windows.Forms.TextBox
    Friend WithEvents etiquetaingreso_bruto As System.Windows.Forms.Label
    Protected WithEvents txtimpuesto_ganancia As System.Windows.Forms.TextBox
    Friend WithEvents etiquetaimpuesto_ganancia As System.Windows.Forms.Label
    Protected WithEvents txtsuss As System.Windows.Forms.TextBox
    Friend WithEvents etiquetasuss As System.Windows.Forms.Label
    Protected WithEvents btnSalir As System.Windows.Forms.Button
    Protected WithEvents btnGuardar As System.Windows.Forms.Button
    Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
    Protected WithEvents btnAgregar_2 As System.Windows.Forms.Button
    Protected WithEvents btnModificar_2 As System.Windows.Forms.Button
    Protected WithEvents btnBorrar_2 As System.Windows.Forms.Button
    Friend WithEvents lblid_pk_2 As System.Windows.Forms.Label
    Protected WithEvents dgv2 As System.Windows.Forms.DataGridView
    Protected WithEvents btnAgregar As System.Windows.Forms.Button
    Protected WithEvents btnModificar As System.Windows.Forms.Button
    Protected WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents lblid_pk As System.Windows.Forms.Label
    Protected WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblid_pago_cliente As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Protected WithEvents txtTotalFactura As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Protected WithEvents txtTotalCheque As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNumero_8 As System.Windows.Forms.TextBox
    Friend WithEvents txtNumero_4 As System.Windows.Forms.TextBox
    Friend WithEvents lblid_factura As System.Windows.Forms.Label
    Friend WithEvents lblid_cheque_recibido As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Protected WithEvents txtRetenciones_cheques As System.Windows.Forms.TextBox
    Friend WithEvents lblid_cheque_recibido_2 As System.Windows.Forms.Label
    Protected WithEvents btnAgregar_3 As System.Windows.Forms.Button
    Protected WithEvents btnModificar_3 As System.Windows.Forms.Button
    Protected WithEvents btnBorrar_3 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblid_pk_3 As System.Windows.Forms.Label
    Protected WithEvents dgv3 As System.Windows.Forms.DataGridView
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents etiquetaObservacion As System.Windows.Forms.Label
    Friend WithEvents lblid_ingreso_efectivo As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblid_pk_4 As System.Windows.Forms.Label
    Protected WithEvents dgv4 As System.Windows.Forms.DataGridView
    Protected WithEvents btnAgregar_ingreso_efectivo As System.Windows.Forms.Button
    Protected WithEvents btnModificar_ingreso_efectivo As System.Windows.Forms.Button
    Protected WithEvents btnBorrar_ingreso_efectivo As System.Windows.Forms.Button
End Class

