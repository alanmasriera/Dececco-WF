<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleCheque_recibido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleCheque_recibido))
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtnumero_cheque = New System.Windows.Forms.TextBox
        Me.etiquetanumero_cheque = New System.Windows.Forms.Label
        Me.lblid_cliente = New System.Windows.Forms.Label
        Me.btnBuscacliente = New System.Windows.Forms.Button
        Me.cmbcliente = New System.Windows.Forms.ComboBox
        Me.etiquetaid_cliente = New System.Windows.Forms.Label
        Me.lblid_banco = New System.Windows.Forms.Label
        Me.btnBuscabanco = New System.Windows.Forms.Button
        Me.cmbbanco = New System.Windows.Forms.ComboBox
        Me.etiquetaid_banco = New System.Windows.Forms.Label
        Me.txtdetalle = New System.Windows.Forms.TextBox
        Me.etiquetadetalle = New System.Windows.Forms.Label
        Me.dtpfecha_recibido = New System.Windows.Forms.DateTimePicker
        Me.etiquetafecha_recibido = New System.Windows.Forms.Label
        Me.dtpfecha_acreditacion = New System.Windows.Forms.DateTimePicker
        Me.etiquetafecha_acreditacion = New System.Windows.Forms.Label
        Me.txtimporte = New System.Windows.Forms.TextBox
        Me.etiquetaimporte = New System.Windows.Forms.Label
        Me.txtiva = New System.Windows.Forms.TextBox
        Me.etiquetaiva = New System.Windows.Forms.Label
        Me.lblid_provincia = New System.Windows.Forms.Label
        Me.btnBuscaprovincia = New System.Windows.Forms.Button
        Me.cmbprovincia = New System.Windows.Forms.ComboBox
        Me.etiquetaid_provincia = New System.Windows.Forms.Label
        Me.lblid_localidad = New System.Windows.Forms.Label
        Me.btnBuscalocalidad = New System.Windows.Forms.Button
        Me.cmblocalidad = New System.Windows.Forms.ComboBox
        Me.etiquetaid_localidad = New System.Windows.Forms.Label
        Me.lblid_empresa = New System.Windows.Forms.Label
        Me.chkcontrol = New System.Windows.Forms.CheckBox
        Me.etiquetacontrol = New System.Windows.Forms.Label
        Me.lblid_proveedor = New System.Windows.Forms.Label
        Me.btnBuscaproveedor = New System.Windows.Forms.Button
        Me.cmbproveedor = New System.Windows.Forms.ComboBox
        Me.etiquetaid_proveedor = New System.Windows.Forms.Label
        Me.chkanulado = New System.Windows.Forms.CheckBox
        Me.etiquetaanulado = New System.Windows.Forms.Label
        Me.chkpago_tercero = New System.Windows.Forms.CheckBox
        Me.etiquetapago_tercero = New System.Windows.Forms.Label
        Me.txtnumero_recibo = New System.Windows.Forms.TextBox
        Me.etiquetanumero_recibo = New System.Windows.Forms.Label
        Me.chkcobro_efectivo = New System.Windows.Forms.CheckBox
        Me.etiquetacobro_efectivo = New System.Windows.Forms.Label
        Me.chkDeposito_cuenta = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblid_banco_deposito = New System.Windows.Forms.Label
        Me.cmbbanco_deposito = New System.Windows.Forms.ComboBox
        Me.etiquetaid_banco_deposito = New System.Windows.Forms.Label
        Me.lblid_cuenta = New System.Windows.Forms.Label
        Me.cmbcuenta = New System.Windows.Forms.ComboBox
        Me.etiquetaid_cuenta = New System.Windows.Forms.Label
        Me.pnlProveedor = New System.Windows.Forms.Panel
        Me.pnlDeposito = New System.Windows.Forms.Panel
        Me.pnlProveedor.SuspendLayout()
        Me.pnlDeposito.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(493, 653)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(81, 69)
        Me.btnSalir.TabIndex = 51
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
        Me.btnGuardar.Location = New System.Drawing.Point(378, 653)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(78, 69)
        Me.btnGuardar.TabIndex = 50
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(562, 608)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtnumero_cheque
        '
        Me.txtnumero_cheque.BackColor = System.Drawing.Color.White
        Me.txtnumero_cheque.Location = New System.Drawing.Point(161, 24)
        Me.txtnumero_cheque.MaxLength = 50
        Me.txtnumero_cheque.Name = "txtnumero_cheque"
        Me.txtnumero_cheque.Size = New System.Drawing.Size(385, 20)
        Me.txtnumero_cheque.TabIndex = 4
        '
        'etiquetanumero_cheque
        '
        Me.etiquetanumero_cheque.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetanumero_cheque.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetanumero_cheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetanumero_cheque.ForeColor = System.Drawing.Color.Black
        Me.etiquetanumero_cheque.Location = New System.Drawing.Point(28, 24)
        Me.etiquetanumero_cheque.Name = "etiquetanumero_cheque"
        Me.etiquetanumero_cheque.Size = New System.Drawing.Size(127, 21)
        Me.etiquetanumero_cheque.TabIndex = 500
        Me.etiquetanumero_cheque.Text = "Numero_cheque"
        Me.etiquetanumero_cheque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_cliente
        '
        Me.lblid_cliente.AutoSize = True
        Me.lblid_cliente.BackColor = System.Drawing.Color.Red
        Me.lblid_cliente.Location = New System.Drawing.Point(370, 67)
        Me.lblid_cliente.Name = "lblid_cliente"
        Me.lblid_cliente.Size = New System.Drawing.Size(13, 13)
        Me.lblid_cliente.TabIndex = 501
        Me.lblid_cliente.Text = "0"
        Me.lblid_cliente.Visible = False
        '
        'btnBuscacliente
        '
        Me.btnBuscacliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscacliente.Image = CType(resources.GetObject("btnBuscacliente.Image"), System.Drawing.Image)
        Me.btnBuscacliente.Location = New System.Drawing.Point(505, 67)
        Me.btnBuscacliente.Name = "btnBuscacliente"
        Me.btnBuscacliente.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscacliente.TabIndex = 70
        Me.btnBuscacliente.UseVisualStyleBackColor = True
        '
        'cmbcliente
        '
        Me.cmbcliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbcliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbcliente.FormattingEnabled = True
        Me.cmbcliente.Location = New System.Drawing.Point(161, 67)
        Me.cmbcliente.Name = "cmbcliente"
        Me.cmbcliente.Size = New System.Drawing.Size(329, 21)
        Me.cmbcliente.TabIndex = 5
        '
        'etiquetaid_cliente
        '
        Me.etiquetaid_cliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_cliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_cliente.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_cliente.Location = New System.Drawing.Point(28, 67)
        Me.etiquetaid_cliente.Name = "etiquetaid_cliente"
        Me.etiquetaid_cliente.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_cliente.TabIndex = 502
        Me.etiquetaid_cliente.Text = "Cliente"
        Me.etiquetaid_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_banco
        '
        Me.lblid_banco.AutoSize = True
        Me.lblid_banco.BackColor = System.Drawing.Color.Red
        Me.lblid_banco.Location = New System.Drawing.Point(370, 110)
        Me.lblid_banco.Name = "lblid_banco"
        Me.lblid_banco.Size = New System.Drawing.Size(13, 13)
        Me.lblid_banco.TabIndex = 503
        Me.lblid_banco.Text = "0"
        Me.lblid_banco.Visible = False
        '
        'btnBuscabanco
        '
        Me.btnBuscabanco.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscabanco.Image = CType(resources.GetObject("btnBuscabanco.Image"), System.Drawing.Image)
        Me.btnBuscabanco.Location = New System.Drawing.Point(505, 110)
        Me.btnBuscabanco.Name = "btnBuscabanco"
        Me.btnBuscabanco.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscabanco.TabIndex = 71
        Me.btnBuscabanco.UseVisualStyleBackColor = True
        '
        'cmbbanco
        '
        Me.cmbbanco.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbbanco.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbbanco.FormattingEnabled = True
        Me.cmbbanco.Location = New System.Drawing.Point(161, 110)
        Me.cmbbanco.Name = "cmbbanco"
        Me.cmbbanco.Size = New System.Drawing.Size(329, 21)
        Me.cmbbanco.TabIndex = 6
        '
        'etiquetaid_banco
        '
        Me.etiquetaid_banco.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_banco.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_banco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_banco.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_banco.Location = New System.Drawing.Point(28, 110)
        Me.etiquetaid_banco.Name = "etiquetaid_banco"
        Me.etiquetaid_banco.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_banco.TabIndex = 504
        Me.etiquetaid_banco.Text = "Banco"
        Me.etiquetaid_banco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtdetalle
        '
        Me.txtdetalle.BackColor = System.Drawing.Color.White
        Me.txtdetalle.Location = New System.Drawing.Point(161, 153)
        Me.txtdetalle.MaxLength = 50
        Me.txtdetalle.Multiline = True
        Me.txtdetalle.Name = "txtdetalle"
        Me.txtdetalle.Size = New System.Drawing.Size(385, 82)
        Me.txtdetalle.TabIndex = 7
        '
        'etiquetadetalle
        '
        Me.etiquetadetalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetadetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetadetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetadetalle.ForeColor = System.Drawing.Color.Black
        Me.etiquetadetalle.Location = New System.Drawing.Point(28, 153)
        Me.etiquetadetalle.Name = "etiquetadetalle"
        Me.etiquetadetalle.Size = New System.Drawing.Size(127, 21)
        Me.etiquetadetalle.TabIndex = 505
        Me.etiquetadetalle.Text = "Detalle"
        Me.etiquetadetalle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpfecha_recibido
        '
        Me.dtpfecha_recibido.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha_recibido.Location = New System.Drawing.Point(161, 257)
        Me.dtpfecha_recibido.Name = "dtpfecha_recibido"
        Me.dtpfecha_recibido.Size = New System.Drawing.Size(93, 20)
        Me.dtpfecha_recibido.TabIndex = 8
        '
        'etiquetafecha_recibido
        '
        Me.etiquetafecha_recibido.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetafecha_recibido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetafecha_recibido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetafecha_recibido.ForeColor = System.Drawing.Color.Black
        Me.etiquetafecha_recibido.Location = New System.Drawing.Point(28, 257)
        Me.etiquetafecha_recibido.Name = "etiquetafecha_recibido"
        Me.etiquetafecha_recibido.Size = New System.Drawing.Size(127, 21)
        Me.etiquetafecha_recibido.TabIndex = 506
        Me.etiquetafecha_recibido.Text = "Fecha_recibido"
        Me.etiquetafecha_recibido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpfecha_acreditacion
        '
        Me.dtpfecha_acreditacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha_acreditacion.Location = New System.Drawing.Point(169, 300)
        Me.dtpfecha_acreditacion.Name = "dtpfecha_acreditacion"
        Me.dtpfecha_acreditacion.Size = New System.Drawing.Size(93, 20)
        Me.dtpfecha_acreditacion.TabIndex = 9
        '
        'etiquetafecha_acreditacion
        '
        Me.etiquetafecha_acreditacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetafecha_acreditacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetafecha_acreditacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetafecha_acreditacion.ForeColor = System.Drawing.Color.Black
        Me.etiquetafecha_acreditacion.Location = New System.Drawing.Point(28, 300)
        Me.etiquetafecha_acreditacion.Name = "etiquetafecha_acreditacion"
        Me.etiquetafecha_acreditacion.Size = New System.Drawing.Size(135, 21)
        Me.etiquetafecha_acreditacion.TabIndex = 507
        Me.etiquetafecha_acreditacion.Text = "Fecha_acreditacion"
        Me.etiquetafecha_acreditacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtimporte
        '
        Me.txtimporte.BackColor = System.Drawing.Color.White
        Me.txtimporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtimporte.ForeColor = System.Drawing.Color.Blue
        Me.txtimporte.Location = New System.Drawing.Point(161, 348)
        Me.txtimporte.MaxLength = 50
        Me.txtimporte.Name = "txtimporte"
        Me.txtimporte.Size = New System.Drawing.Size(141, 31)
        Me.txtimporte.TabIndex = 10
        Me.txtimporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetaimporte
        '
        Me.etiquetaimporte.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaimporte.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaimporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaimporte.ForeColor = System.Drawing.Color.Black
        Me.etiquetaimporte.Location = New System.Drawing.Point(28, 348)
        Me.etiquetaimporte.Name = "etiquetaimporte"
        Me.etiquetaimporte.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaimporte.TabIndex = 508
        Me.etiquetaimporte.Text = "Importe"
        Me.etiquetaimporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtiva
        '
        Me.txtiva.BackColor = System.Drawing.Color.White
        Me.txtiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtiva.ForeColor = System.Drawing.Color.Blue
        Me.txtiva.Location = New System.Drawing.Point(161, 398)
        Me.txtiva.MaxLength = 50
        Me.txtiva.Name = "txtiva"
        Me.txtiva.Size = New System.Drawing.Size(141, 31)
        Me.txtiva.TabIndex = 11
        Me.txtiva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtiva.Visible = False
        '
        'etiquetaiva
        '
        Me.etiquetaiva.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaiva.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaiva.ForeColor = System.Drawing.Color.Black
        Me.etiquetaiva.Location = New System.Drawing.Point(28, 398)
        Me.etiquetaiva.Name = "etiquetaiva"
        Me.etiquetaiva.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaiva.TabIndex = 509
        Me.etiquetaiva.Text = "Iva"
        Me.etiquetaiva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.etiquetaiva.Visible = False
        '
        'lblid_provincia
        '
        Me.lblid_provincia.AutoSize = True
        Me.lblid_provincia.BackColor = System.Drawing.Color.Red
        Me.lblid_provincia.Location = New System.Drawing.Point(370, 452)
        Me.lblid_provincia.Name = "lblid_provincia"
        Me.lblid_provincia.Size = New System.Drawing.Size(13, 13)
        Me.lblid_provincia.TabIndex = 510
        Me.lblid_provincia.Text = "0"
        Me.lblid_provincia.Visible = False
        '
        'btnBuscaprovincia
        '
        Me.btnBuscaprovincia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscaprovincia.Image = CType(resources.GetObject("btnBuscaprovincia.Image"), System.Drawing.Image)
        Me.btnBuscaprovincia.Location = New System.Drawing.Point(505, 452)
        Me.btnBuscaprovincia.Name = "btnBuscaprovincia"
        Me.btnBuscaprovincia.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscaprovincia.TabIndex = 72
        Me.btnBuscaprovincia.UseVisualStyleBackColor = True
        '
        'cmbprovincia
        '
        Me.cmbprovincia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbprovincia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbprovincia.FormattingEnabled = True
        Me.cmbprovincia.Location = New System.Drawing.Point(161, 452)
        Me.cmbprovincia.Name = "cmbprovincia"
        Me.cmbprovincia.Size = New System.Drawing.Size(329, 21)
        Me.cmbprovincia.TabIndex = 12
        '
        'etiquetaid_provincia
        '
        Me.etiquetaid_provincia.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_provincia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_provincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_provincia.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_provincia.Location = New System.Drawing.Point(28, 452)
        Me.etiquetaid_provincia.Name = "etiquetaid_provincia"
        Me.etiquetaid_provincia.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_provincia.TabIndex = 511
        Me.etiquetaid_provincia.Text = "Provincia"
        Me.etiquetaid_provincia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_localidad
        '
        Me.lblid_localidad.AutoSize = True
        Me.lblid_localidad.BackColor = System.Drawing.Color.Red
        Me.lblid_localidad.Location = New System.Drawing.Point(370, 495)
        Me.lblid_localidad.Name = "lblid_localidad"
        Me.lblid_localidad.Size = New System.Drawing.Size(13, 13)
        Me.lblid_localidad.TabIndex = 512
        Me.lblid_localidad.Text = "0"
        Me.lblid_localidad.Visible = False
        '
        'btnBuscalocalidad
        '
        Me.btnBuscalocalidad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscalocalidad.Image = CType(resources.GetObject("btnBuscalocalidad.Image"), System.Drawing.Image)
        Me.btnBuscalocalidad.Location = New System.Drawing.Point(505, 495)
        Me.btnBuscalocalidad.Name = "btnBuscalocalidad"
        Me.btnBuscalocalidad.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscalocalidad.TabIndex = 73
        Me.btnBuscalocalidad.UseVisualStyleBackColor = True
        '
        'cmblocalidad
        '
        Me.cmblocalidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmblocalidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmblocalidad.FormattingEnabled = True
        Me.cmblocalidad.Location = New System.Drawing.Point(161, 495)
        Me.cmblocalidad.Name = "cmblocalidad"
        Me.cmblocalidad.Size = New System.Drawing.Size(329, 21)
        Me.cmblocalidad.TabIndex = 13
        '
        'etiquetaid_localidad
        '
        Me.etiquetaid_localidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_localidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_localidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_localidad.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_localidad.Location = New System.Drawing.Point(28, 495)
        Me.etiquetaid_localidad.Name = "etiquetaid_localidad"
        Me.etiquetaid_localidad.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_localidad.TabIndex = 513
        Me.etiquetaid_localidad.Text = "Localidad"
        Me.etiquetaid_localidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_empresa
        '
        Me.lblid_empresa.AutoSize = True
        Me.lblid_empresa.BackColor = System.Drawing.Color.Red
        Me.lblid_empresa.Location = New System.Drawing.Point(332, 653)
        Me.lblid_empresa.Name = "lblid_empresa"
        Me.lblid_empresa.Size = New System.Drawing.Size(13, 13)
        Me.lblid_empresa.TabIndex = 514
        Me.lblid_empresa.Text = "0"
        Me.lblid_empresa.Visible = False
        '
        'chkcontrol
        '
        Me.chkcontrol.AutoSize = True
        Me.chkcontrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkcontrol.Location = New System.Drawing.Point(161, 586)
        Me.chkcontrol.Name = "chkcontrol"
        Me.chkcontrol.Size = New System.Drawing.Size(77, 21)
        Me.chkcontrol.TabIndex = 18
        Me.chkcontrol.Text = "control"
        '
        'etiquetacontrol
        '
        Me.etiquetacontrol.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetacontrol.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetacontrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetacontrol.ForeColor = System.Drawing.Color.Black
        Me.etiquetacontrol.Location = New System.Drawing.Point(28, 586)
        Me.etiquetacontrol.Name = "etiquetacontrol"
        Me.etiquetacontrol.Size = New System.Drawing.Size(127, 21)
        Me.etiquetacontrol.TabIndex = 516
        Me.etiquetacontrol.Text = "Control"
        Me.etiquetacontrol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_proveedor
        '
        Me.lblid_proveedor.AutoSize = True
        Me.lblid_proveedor.BackColor = System.Drawing.Color.Red
        Me.lblid_proveedor.Location = New System.Drawing.Point(218, 42)
        Me.lblid_proveedor.Name = "lblid_proveedor"
        Me.lblid_proveedor.Size = New System.Drawing.Size(13, 13)
        Me.lblid_proveedor.TabIndex = 525
        Me.lblid_proveedor.Text = "0"
        Me.lblid_proveedor.Visible = False
        '
        'btnBuscaproveedor
        '
        Me.btnBuscaproveedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscaproveedor.Image = CType(resources.GetObject("btnBuscaproveedor.Image"), System.Drawing.Image)
        Me.btnBuscaproveedor.Location = New System.Drawing.Point(364, 39)
        Me.btnBuscaproveedor.Name = "btnBuscaproveedor"
        Me.btnBuscaproveedor.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscaproveedor.TabIndex = 74
        Me.btnBuscaproveedor.UseVisualStyleBackColor = True
        '
        'cmbproveedor
        '
        Me.cmbproveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbproveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbproveedor.FormattingEnabled = True
        Me.cmbproveedor.Location = New System.Drawing.Point(9, 39)
        Me.cmbproveedor.Name = "cmbproveedor"
        Me.cmbproveedor.Size = New System.Drawing.Size(329, 21)
        Me.cmbproveedor.TabIndex = 22
        '
        'etiquetaid_proveedor
        '
        Me.etiquetaid_proveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_proveedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_proveedor.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_proveedor.Location = New System.Drawing.Point(9, 16)
        Me.etiquetaid_proveedor.Name = "etiquetaid_proveedor"
        Me.etiquetaid_proveedor.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_proveedor.TabIndex = 526
        Me.etiquetaid_proveedor.Text = "Proveedor"
        Me.etiquetaid_proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkanulado
        '
        Me.chkanulado.AutoSize = True
        Me.chkanulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkanulado.Location = New System.Drawing.Point(161, 540)
        Me.chkanulado.Name = "chkanulado"
        Me.chkanulado.Size = New System.Drawing.Size(85, 21)
        Me.chkanulado.TabIndex = 17
        Me.chkanulado.Text = "anulado"
        '
        'etiquetaanulado
        '
        Me.etiquetaanulado.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaanulado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaanulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaanulado.ForeColor = System.Drawing.Color.Black
        Me.etiquetaanulado.Location = New System.Drawing.Point(28, 540)
        Me.etiquetaanulado.Name = "etiquetaanulado"
        Me.etiquetaanulado.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaanulado.TabIndex = 527
        Me.etiquetaanulado.Text = "Anulado"
        Me.etiquetaanulado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkpago_tercero
        '
        Me.chkpago_tercero.AutoSize = True
        Me.chkpago_tercero.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkpago_tercero.Location = New System.Drawing.Point(730, 22)
        Me.chkpago_tercero.Name = "chkpago_tercero"
        Me.chkpago_tercero.Size = New System.Drawing.Size(124, 21)
        Me.chkpago_tercero.TabIndex = 20
        Me.chkpago_tercero.Text = "pago_tercero"
        '
        'etiquetapago_tercero
        '
        Me.etiquetapago_tercero.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetapago_tercero.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetapago_tercero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetapago_tercero.ForeColor = System.Drawing.Color.Black
        Me.etiquetapago_tercero.Location = New System.Drawing.Point(597, 22)
        Me.etiquetapago_tercero.Name = "etiquetapago_tercero"
        Me.etiquetapago_tercero.Size = New System.Drawing.Size(127, 21)
        Me.etiquetapago_tercero.TabIndex = 528
        Me.etiquetapago_tercero.Text = "Pago_tercero"
        Me.etiquetapago_tercero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtnumero_recibo
        '
        Me.txtnumero_recibo.BackColor = System.Drawing.Color.White
        Me.txtnumero_recibo.Location = New System.Drawing.Point(9, 96)
        Me.txtnumero_recibo.MaxLength = 50
        Me.txtnumero_recibo.Name = "txtnumero_recibo"
        Me.txtnumero_recibo.Size = New System.Drawing.Size(385, 20)
        Me.txtnumero_recibo.TabIndex = 23
        '
        'etiquetanumero_recibo
        '
        Me.etiquetanumero_recibo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetanumero_recibo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetanumero_recibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetanumero_recibo.ForeColor = System.Drawing.Color.Black
        Me.etiquetanumero_recibo.Location = New System.Drawing.Point(9, 74)
        Me.etiquetanumero_recibo.Name = "etiquetanumero_recibo"
        Me.etiquetanumero_recibo.Size = New System.Drawing.Size(127, 21)
        Me.etiquetanumero_recibo.TabIndex = 530
        Me.etiquetanumero_recibo.Text = "Numero_recibo"
        Me.etiquetanumero_recibo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkcobro_efectivo
        '
        Me.chkcobro_efectivo.AutoSize = True
        Me.chkcobro_efectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkcobro_efectivo.Location = New System.Drawing.Point(730, 230)
        Me.chkcobro_efectivo.Name = "chkcobro_efectivo"
        Me.chkcobro_efectivo.Size = New System.Drawing.Size(134, 21)
        Me.chkcobro_efectivo.TabIndex = 30
        Me.chkcobro_efectivo.Text = "cobro_efectivo"
        '
        'etiquetacobro_efectivo
        '
        Me.etiquetacobro_efectivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetacobro_efectivo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetacobro_efectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetacobro_efectivo.ForeColor = System.Drawing.Color.Black
        Me.etiquetacobro_efectivo.Location = New System.Drawing.Point(597, 230)
        Me.etiquetacobro_efectivo.Name = "etiquetacobro_efectivo"
        Me.etiquetacobro_efectivo.Size = New System.Drawing.Size(127, 21)
        Me.etiquetacobro_efectivo.TabIndex = 532
        Me.etiquetacobro_efectivo.Text = "Cobro_efectivo"
        Me.etiquetacobro_efectivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkDeposito_cuenta
        '
        Me.chkDeposito_cuenta.AutoSize = True
        Me.chkDeposito_cuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDeposito_cuenta.Location = New System.Drawing.Point(730, 300)
        Me.chkDeposito_cuenta.Name = "chkDeposito_cuenta"
        Me.chkDeposito_cuenta.Size = New System.Drawing.Size(149, 21)
        Me.chkDeposito_cuenta.TabIndex = 40
        Me.chkDeposito_cuenta.Text = "Deposito_cuenta"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(597, 300)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 21)
        Me.Label1.TabIndex = 534
        Me.Label1.Text = "Deposito_cuenta"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_banco_deposito
        '
        Me.lblid_banco_deposito.AutoSize = True
        Me.lblid_banco_deposito.BackColor = System.Drawing.Color.Red
        Me.lblid_banco_deposito.Location = New System.Drawing.Point(219, 35)
        Me.lblid_banco_deposito.Name = "lblid_banco_deposito"
        Me.lblid_banco_deposito.Size = New System.Drawing.Size(13, 13)
        Me.lblid_banco_deposito.TabIndex = 537
        Me.lblid_banco_deposito.Text = "0"
        Me.lblid_banco_deposito.Visible = False
        '
        'cmbbanco_deposito
        '
        Me.cmbbanco_deposito.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbbanco_deposito.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbbanco_deposito.FormattingEnabled = True
        Me.cmbbanco_deposito.Location = New System.Drawing.Point(10, 32)
        Me.cmbbanco_deposito.Name = "cmbbanco_deposito"
        Me.cmbbanco_deposito.Size = New System.Drawing.Size(329, 21)
        Me.cmbbanco_deposito.TabIndex = 42
        '
        'etiquetaid_banco_deposito
        '
        Me.etiquetaid_banco_deposito.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_banco_deposito.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_banco_deposito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_banco_deposito.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_banco_deposito.Location = New System.Drawing.Point(10, 8)
        Me.etiquetaid_banco_deposito.Name = "etiquetaid_banco_deposito"
        Me.etiquetaid_banco_deposito.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_banco_deposito.TabIndex = 538
        Me.etiquetaid_banco_deposito.Text = "Banco_deposito"
        Me.etiquetaid_banco_deposito.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_cuenta
        '
        Me.lblid_cuenta.AutoSize = True
        Me.lblid_cuenta.BackColor = System.Drawing.Color.Red
        Me.lblid_cuenta.Location = New System.Drawing.Point(219, 92)
        Me.lblid_cuenta.Name = "lblid_cuenta"
        Me.lblid_cuenta.Size = New System.Drawing.Size(13, 13)
        Me.lblid_cuenta.TabIndex = 539
        Me.lblid_cuenta.Text = "0"
        Me.lblid_cuenta.Visible = False
        '
        'cmbcuenta
        '
        Me.cmbcuenta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbcuenta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbcuenta.FormattingEnabled = True
        Me.cmbcuenta.Location = New System.Drawing.Point(10, 92)
        Me.cmbcuenta.Name = "cmbcuenta"
        Me.cmbcuenta.Size = New System.Drawing.Size(329, 21)
        Me.cmbcuenta.TabIndex = 43
        '
        'etiquetaid_cuenta
        '
        Me.etiquetaid_cuenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_cuenta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_cuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_cuenta.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_cuenta.Location = New System.Drawing.Point(10, 68)
        Me.etiquetaid_cuenta.Name = "etiquetaid_cuenta"
        Me.etiquetaid_cuenta.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_cuenta.TabIndex = 540
        Me.etiquetaid_cuenta.Text = "Cuenta"
        Me.etiquetaid_cuenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlProveedor
        '
        Me.pnlProveedor.Controls.Add(Me.txtnumero_recibo)
        Me.pnlProveedor.Controls.Add(Me.etiquetanumero_recibo)
        Me.pnlProveedor.Controls.Add(Me.lblid_proveedor)
        Me.pnlProveedor.Controls.Add(Me.btnBuscaproveedor)
        Me.pnlProveedor.Controls.Add(Me.cmbproveedor)
        Me.pnlProveedor.Controls.Add(Me.etiquetaid_proveedor)
        Me.pnlProveedor.Enabled = False
        Me.pnlProveedor.Location = New System.Drawing.Point(588, 49)
        Me.pnlProveedor.Name = "pnlProveedor"
        Me.pnlProveedor.Size = New System.Drawing.Size(414, 142)
        Me.pnlProveedor.TabIndex = 21
        '
        'pnlDeposito
        '
        Me.pnlDeposito.Controls.Add(Me.lblid_banco_deposito)
        Me.pnlDeposito.Controls.Add(Me.cmbbanco_deposito)
        Me.pnlDeposito.Controls.Add(Me.etiquetaid_banco_deposito)
        Me.pnlDeposito.Controls.Add(Me.lblid_cuenta)
        Me.pnlDeposito.Controls.Add(Me.cmbcuenta)
        Me.pnlDeposito.Controls.Add(Me.etiquetaid_cuenta)
        Me.pnlDeposito.Enabled = False
        Me.pnlDeposito.Location = New System.Drawing.Point(587, 336)
        Me.pnlDeposito.Name = "pnlDeposito"
        Me.pnlDeposito.Size = New System.Drawing.Size(414, 126)
        Me.pnlDeposito.TabIndex = 41
        '
        'frmDetalleCheque_recibido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 741)
        Me.Controls.Add(Me.pnlDeposito)
        Me.Controls.Add(Me.pnlProveedor)
        Me.Controls.Add(Me.chkDeposito_cuenta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkcobro_efectivo)
        Me.Controls.Add(Me.etiquetacobro_efectivo)
        Me.Controls.Add(Me.chkpago_tercero)
        Me.Controls.Add(Me.etiquetapago_tercero)
        Me.Controls.Add(Me.chkanulado)
        Me.Controls.Add(Me.etiquetaanulado)
        Me.Controls.Add(Me.txtnumero_cheque)
        Me.Controls.Add(Me.etiquetanumero_cheque)
        Me.Controls.Add(Me.lblid_cliente)
        Me.Controls.Add(Me.btnBuscacliente)
        Me.Controls.Add(Me.cmbcliente)
        Me.Controls.Add(Me.etiquetaid_cliente)
        Me.Controls.Add(Me.lblid_banco)
        Me.Controls.Add(Me.btnBuscabanco)
        Me.Controls.Add(Me.cmbbanco)
        Me.Controls.Add(Me.etiquetaid_banco)
        Me.Controls.Add(Me.txtdetalle)
        Me.Controls.Add(Me.etiquetadetalle)
        Me.Controls.Add(Me.dtpfecha_recibido)
        Me.Controls.Add(Me.etiquetafecha_recibido)
        Me.Controls.Add(Me.dtpfecha_acreditacion)
        Me.Controls.Add(Me.etiquetafecha_acreditacion)
        Me.Controls.Add(Me.txtimporte)
        Me.Controls.Add(Me.etiquetaimporte)
        Me.Controls.Add(Me.txtiva)
        Me.Controls.Add(Me.etiquetaiva)
        Me.Controls.Add(Me.lblid_provincia)
        Me.Controls.Add(Me.btnBuscaprovincia)
        Me.Controls.Add(Me.cmbprovincia)
        Me.Controls.Add(Me.etiquetaid_provincia)
        Me.Controls.Add(Me.lblid_localidad)
        Me.Controls.Add(Me.btnBuscalocalidad)
        Me.Controls.Add(Me.cmblocalidad)
        Me.Controls.Add(Me.etiquetaid_localidad)
        Me.Controls.Add(Me.lblid_empresa)
        Me.Controls.Add(Me.chkcontrol)
        Me.Controls.Add(Me.etiquetacontrol)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDetalleCheque_recibido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetalleCheque_recibido"
        Me.pnlProveedor.ResumeLayout(False)
        Me.pnlProveedor.PerformLayout()
        Me.pnlDeposito.ResumeLayout(False)
        Me.pnlDeposito.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Protected WithEvents txtnumero_cheque As System.Windows.Forms.TextBox
    Friend WithEvents etiquetanumero_cheque As System.Windows.Forms.Label
    Friend WithEvents lblid_cliente As System.Windows.Forms.Label
    Friend WithEvents btnBuscacliente As System.Windows.Forms.Button
    Friend WithEvents cmbcliente As System.Windows.Forms.ComboBox
    Friend WithEvents etiquetaid_cliente As System.Windows.Forms.Label
    Friend WithEvents lblid_banco As System.Windows.Forms.Label
    Friend WithEvents btnBuscabanco As System.Windows.Forms.Button
    Friend WithEvents cmbbanco As System.Windows.Forms.ComboBox
    Friend WithEvents etiquetaid_banco As System.Windows.Forms.Label
    Protected WithEvents txtdetalle As System.Windows.Forms.TextBox
    Friend WithEvents etiquetadetalle As System.Windows.Forms.Label
    Protected WithEvents dtpfecha_recibido As System.Windows.Forms.DateTimePicker
    Friend WithEvents etiquetafecha_recibido As System.Windows.Forms.Label
    Protected WithEvents dtpfecha_acreditacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents etiquetafecha_acreditacion As System.Windows.Forms.Label
    Protected WithEvents txtimporte As System.Windows.Forms.TextBox
    Friend WithEvents etiquetaimporte As System.Windows.Forms.Label
    Protected WithEvents txtiva As System.Windows.Forms.TextBox
    Friend WithEvents etiquetaiva As System.Windows.Forms.Label
    Friend WithEvents lblid_provincia As System.Windows.Forms.Label
    Friend WithEvents btnBuscaprovincia As System.Windows.Forms.Button
    Friend WithEvents cmbprovincia As System.Windows.Forms.ComboBox
    Friend WithEvents etiquetaid_provincia As System.Windows.Forms.Label
    Friend WithEvents lblid_localidad As System.Windows.Forms.Label
    Friend WithEvents btnBuscalocalidad As System.Windows.Forms.Button
    Friend WithEvents cmblocalidad As System.Windows.Forms.ComboBox
    Friend WithEvents etiquetaid_localidad As System.Windows.Forms.Label
    Friend WithEvents lblid_empresa As System.Windows.Forms.Label
    Protected WithEvents chkcontrol As System.Windows.Forms.CheckBox
    Friend WithEvents etiquetacontrol As System.Windows.Forms.Label
    Protected WithEvents btnSalir As System.Windows.Forms.Button
    Protected WithEvents btnGuardar As System.Windows.Forms.Button
    Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
    Friend WithEvents lblid_proveedor As System.Windows.Forms.Label
    Friend WithEvents btnBuscaproveedor As System.Windows.Forms.Button
    Friend WithEvents cmbproveedor As System.Windows.Forms.ComboBox
    Friend WithEvents etiquetaid_proveedor As System.Windows.Forms.Label
    Protected WithEvents chkanulado As System.Windows.Forms.CheckBox
    Friend WithEvents etiquetaanulado As System.Windows.Forms.Label
    Protected WithEvents chkpago_tercero As System.Windows.Forms.CheckBox
    Friend WithEvents etiquetapago_tercero As System.Windows.Forms.Label
    Protected WithEvents txtnumero_recibo As System.Windows.Forms.TextBox
    Friend WithEvents etiquetanumero_recibo As System.Windows.Forms.Label
    Protected WithEvents chkcobro_efectivo As System.Windows.Forms.CheckBox
    Friend WithEvents etiquetacobro_efectivo As System.Windows.Forms.Label
    Protected WithEvents chkDeposito_cuenta As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblid_banco_deposito As System.Windows.Forms.Label
    Friend WithEvents cmbbanco_deposito As System.Windows.Forms.ComboBox
    Friend WithEvents etiquetaid_banco_deposito As System.Windows.Forms.Label
    Friend WithEvents lblid_cuenta As System.Windows.Forms.Label
    Friend WithEvents cmbcuenta As System.Windows.Forms.ComboBox
    Friend WithEvents etiquetaid_cuenta As System.Windows.Forms.Label
    Friend WithEvents pnlProveedor As System.Windows.Forms.Panel
    Friend WithEvents pnlDeposito As System.Windows.Forms.Panel
End Class

