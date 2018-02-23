<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleFactura3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleFactura3))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dtpFecha_factura = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblid_cliente = New System.Windows.Forms.Label()
        Me.btnBuscaCliente = New System.Windows.Forms.Button()
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumero_factura_2 = New System.Windows.Forms.TextBox()
        Me.txtNumero_factura_1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblid_pk = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.lblid_factura = New System.Windows.Forms.Label()
        Me.ttAgregar = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttModificar = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttBorrar = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttSalir = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttCliente = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttGuardar = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtIva_factura = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtIva = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.ttImprimir = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTotal_letra = New System.Windows.Forms.TextBox()
        Me.rbnFactura = New System.Windows.Forms.RadioButton()
        Me.rbnNC = New System.Windows.Forms.RadioButton()
        Me.rbnND = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNumero_remito_2 = New System.Windows.Forms.TextBox()
        Me.txtNumero_remito_1 = New System.Windows.Forms.TextBox()
        Me.rbnCuenta_corriente = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCondicion_pago = New System.Windows.Forms.TextBox()
        Me.rbnContado = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbnResponsable_no_inscripto = New System.Windows.Forms.RadioButton()
        Me.rbnResponsable_inscripto = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtImpuesto = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtReferencia = New System.Windows.Forms.TextBox()
        Me.txtcomprobante = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtOrden_compra = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpFecha_factura
        '
        Me.dtpFecha_factura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha_factura.Location = New System.Drawing.Point(558, 34)
        Me.dtpFecha_factura.Name = "dtpFecha_factura"
        Me.dtpFecha_factura.Size = New System.Drawing.Size(100, 20)
        Me.dtpFecha_factura.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(466, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 21)
        Me.Label3.TabIndex = 580
        Me.Label3.Text = "Fecha Factura"
        '
        'lblid_cliente
        '
        Me.lblid_cliente.AutoSize = True
        Me.lblid_cliente.BackColor = System.Drawing.Color.Red
        Me.lblid_cliente.Location = New System.Drawing.Point(310, 38)
        Me.lblid_cliente.Name = "lblid_cliente"
        Me.lblid_cliente.Size = New System.Drawing.Size(13, 13)
        Me.lblid_cliente.TabIndex = 578
        Me.lblid_cliente.Text = "0"
        Me.lblid_cliente.Visible = False
        '
        'btnBuscaCliente
        '
        Me.btnBuscaCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscaCliente.Image = CType(resources.GetObject("btnBuscaCliente.Image"), System.Drawing.Image)
        Me.btnBuscaCliente.Location = New System.Drawing.Point(419, 26)
        Me.btnBuscaCliente.Name = "btnBuscaCliente"
        Me.btnBuscaCliente.Size = New System.Drawing.Size(41, 36)
        Me.btnBuscaCliente.TabIndex = 577
        Me.btnBuscaCliente.UseVisualStyleBackColor = True
        '
        'cmbCliente
        '
        Me.cmbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Location = New System.Drawing.Point(101, 34)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(299, 21)
        Me.cmbCliente.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(29, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 21)
        Me.Label1.TabIndex = 576
        Me.Label1.Text = "Cliente"
        '
        'txtNumero_factura_2
        '
        Me.txtNumero_factura_2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero_factura_2.Location = New System.Drawing.Point(832, 9)
        Me.txtNumero_factura_2.MaxLength = 8
        Me.txtNumero_factura_2.Name = "txtNumero_factura_2"
        Me.txtNumero_factura_2.Size = New System.Drawing.Size(135, 20)
        Me.txtNumero_factura_2.TabIndex = 4
        Me.txtNumero_factura_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNumero_factura_1
        '
        Me.txtNumero_factura_1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero_factura_1.Location = New System.Drawing.Point(754, 9)
        Me.txtNumero_factura_1.MaxLength = 4
        Me.txtNumero_factura_1.Name = "txtNumero_factura_1"
        Me.txtNumero_factura_1.Size = New System.Drawing.Size(72, 20)
        Me.txtNumero_factura_1.TabIndex = 3
        Me.txtNumero_factura_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(677, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 21)
        Me.Label2.TabIndex = 583
        Me.Label2.Text = "Número"
        '
        'lblid_pk
        '
        Me.lblid_pk.AutoSize = True
        Me.lblid_pk.BackColor = System.Drawing.Color.Red
        Me.lblid_pk.ForeColor = System.Drawing.Color.Yellow
        Me.lblid_pk.Location = New System.Drawing.Point(58, 55)
        Me.lblid_pk.Name = "lblid_pk"
        Me.lblid_pk.Size = New System.Drawing.Size(13, 13)
        Me.lblid_pk.TabIndex = 585
        Me.lblid_pk.Text = "0"
        Me.lblid_pk.Visible = False
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(379, 605)
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
        Me.btnGuardar.Location = New System.Drawing.Point(158, 605)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(78, 69)
        Me.btnGuardar.TabIndex = 30
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImprimir.Enabled = False
        Me.btnImprimir.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.ForeColor = System.Drawing.Color.Black
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprimir.Location = New System.Drawing.Point(242, 605)
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
        Me.btnNuevo.Location = New System.Drawing.Point(29, 605)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(78, 69)
        Me.btnNuevo.TabIndex = 32
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'lblid_factura
        '
        Me.lblid_factura.AutoSize = True
        Me.lblid_factura.BackColor = System.Drawing.Color.Red
        Me.lblid_factura.ForeColor = System.Drawing.Color.Yellow
        Me.lblid_factura.Location = New System.Drawing.Point(26, 55)
        Me.lblid_factura.Name = "lblid_factura"
        Me.lblid_factura.Size = New System.Drawing.Size(13, 13)
        Me.lblid_factura.TabIndex = 612
        Me.lblid_factura.Text = "0"
        Me.lblid_factura.Visible = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(481, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 21)
        Me.Label8.TabIndex = 616
        Me.Label8.Text = "Alicuota"
        '
        'txtIva_factura
        '
        Me.txtIva_factura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIva_factura.Location = New System.Drawing.Point(558, 77)
        Me.txtIva_factura.MaxLength = 4
        Me.txtIva_factura.Name = "txtIva_factura"
        Me.txtIva_factura.Size = New System.Drawing.Size(72, 20)
        Me.txtIva_factura.TabIndex = 12
        Me.txtIva_factura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(294, -3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 21)
        Me.Label6.TabIndex = 618
        Me.Label6.Text = "Tipo"
        Me.Label6.Visible = False
        '
        'txtTipo
        '
        Me.txtTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipo.Location = New System.Drawing.Point(371, -3)
        Me.txtTipo.MaxLength = 4
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(72, 20)
        Me.txtTipo.TabIndex = 9
        Me.txtTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTipo.Visible = False
        '
        'btnBorrar
        '
        Me.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar.Image = CType(resources.GetObject("btnBorrar.Image"), System.Drawing.Image)
        Me.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBorrar.Location = New System.Drawing.Point(882, 442)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(86, 71)
        Me.btnBorrar.TabIndex = 27
        Me.btnBorrar.Text = "&Borrar"
        Me.btnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModificar.Location = New System.Drawing.Point(882, 303)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(86, 71)
        Me.btnModificar.TabIndex = 26
        Me.btnModificar.Text = "&Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'txtSubtotal
        '
        Me.txtSubtotal.BackColor = System.Drawing.SystemColors.Info
        Me.txtSubtotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubtotal.ForeColor = System.Drawing.Color.Green
        Me.txtSubtotal.Location = New System.Drawing.Point(666, 568)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.ReadOnly = True
        Me.txtSubtotal.Size = New System.Drawing.Size(185, 31)
        Me.txtSubtotal.TabIndex = 653
        Me.txtSubtotal.TabStop = False
        Me.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(572, 568)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 21)
        Me.Label5.TabIndex = 654
        Me.Label5.Text = "SubTotal"
        '
        'txtIva
        '
        Me.txtIva.BackColor = System.Drawing.SystemColors.Info
        Me.txtIva.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIva.ForeColor = System.Drawing.Color.Green
        Me.txtIva.Location = New System.Drawing.Point(666, 605)
        Me.txtIva.Name = "txtIva"
        Me.txtIva.ReadOnly = True
        Me.txtIva.Size = New System.Drawing.Size(185, 31)
        Me.txtIva.TabIndex = 651
        Me.txtIva.TabStop = False
        Me.txtIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnAgregar
        '
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAgregar.Location = New System.Drawing.Point(882, 175)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(86, 71)
        Me.btnAgregar.TabIndex = 25
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
        Me.Label4.Location = New System.Drawing.Point(572, 605)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 21)
        Me.Label4.TabIndex = 652
        Me.Label4.Text = "Iva"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.SystemColors.Info
        Me.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.Green
        Me.txtTotal.Location = New System.Drawing.Point(666, 643)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(185, 31)
        Me.txtTotal.TabIndex = 649
        Me.txtTotal.TabStop = False
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(572, 643)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 21)
        Me.Label7.TabIndex = 650
        Me.Label7.Text = "Total"
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Brown
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv1.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.dgv1.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv1.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgv1.GridColor = System.Drawing.Color.MediumPurple
        Me.dgv1.Location = New System.Drawing.Point(30, 175)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.ShowCellErrors = False
        Me.dgv1.ShowRowErrors = False
        Me.dgv1.Size = New System.Drawing.Size(821, 338)
        Me.dgv1.StandardTab = True
        Me.dgv1.TabIndex = 25
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(29, 530)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 21)
        Me.Label13.TabIndex = 675
        Me.Label13.Text = "Son Pesos:"
        '
        'txtTotal_letra
        '
        Me.txtTotal_letra.BackColor = System.Drawing.SystemColors.Info
        Me.txtTotal_letra.Location = New System.Drawing.Point(135, 532)
        Me.txtTotal_letra.Name = "txtTotal_letra"
        Me.txtTotal_letra.ReadOnly = True
        Me.txtTotal_letra.Size = New System.Drawing.Size(716, 20)
        Me.txtTotal_letra.TabIndex = 674
        Me.txtTotal_letra.TabStop = False
        '
        'rbnFactura
        '
        Me.rbnFactura.AutoSize = True
        Me.rbnFactura.Checked = True
        Me.rbnFactura.ForeColor = System.Drawing.Color.Black
        Me.rbnFactura.Location = New System.Drawing.Point(117, 77)
        Me.rbnFactura.Name = "rbnFactura"
        Me.rbnFactura.Size = New System.Drawing.Size(61, 17)
        Me.rbnFactura.TabIndex = 9
        Me.rbnFactura.TabStop = True
        Me.rbnFactura.Text = "Factura"
        Me.rbnFactura.UseVisualStyleBackColor = True
        '
        'rbnNC
        '
        Me.rbnNC.AutoSize = True
        Me.rbnNC.ForeColor = System.Drawing.Color.Black
        Me.rbnNC.Location = New System.Drawing.Point(207, 77)
        Me.rbnNC.Name = "rbnNC"
        Me.rbnNC.Size = New System.Drawing.Size(99, 17)
        Me.rbnNC.TabIndex = 10
        Me.rbnNC.Text = "Nota de Crédito"
        Me.rbnNC.UseVisualStyleBackColor = True
        '
        'rbnND
        '
        Me.rbnND.AutoSize = True
        Me.rbnND.ForeColor = System.Drawing.Color.Black
        Me.rbnND.Location = New System.Drawing.Point(335, 77)
        Me.rbnND.Name = "rbnND"
        Me.rbnND.Size = New System.Drawing.Size(97, 17)
        Me.rbnND.TabIndex = 11
        Me.rbnND.Text = "Nota de Débito"
        Me.rbnND.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(30, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 21)
        Me.Label9.TabIndex = 679
        Me.Label9.Text = "Tipo"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(677, 61)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 21)
        Me.Label10.TabIndex = 682
        Me.Label10.Text = "Remito"
        '
        'txtNumero_remito_2
        '
        Me.txtNumero_remito_2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero_remito_2.Location = New System.Drawing.Point(832, 61)
        Me.txtNumero_remito_2.MaxLength = 8
        Me.txtNumero_remito_2.Name = "txtNumero_remito_2"
        Me.txtNumero_remito_2.Size = New System.Drawing.Size(135, 20)
        Me.txtNumero_remito_2.TabIndex = 6
        Me.txtNumero_remito_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNumero_remito_1
        '
        Me.txtNumero_remito_1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero_remito_1.Location = New System.Drawing.Point(754, 61)
        Me.txtNumero_remito_1.MaxLength = 4
        Me.txtNumero_remito_1.Name = "txtNumero_remito_1"
        Me.txtNumero_remito_1.Size = New System.Drawing.Size(72, 20)
        Me.txtNumero_remito_1.TabIndex = 5
        Me.txtNumero_remito_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rbnCuenta_corriente
        '
        Me.rbnCuenta_corriente.AutoSize = True
        Me.rbnCuenta_corriente.ForeColor = System.Drawing.Color.Yellow
        Me.rbnCuenta_corriente.Location = New System.Drawing.Point(137, 14)
        Me.rbnCuenta_corriente.Name = "rbnCuenta_corriente"
        Me.rbnCuenta_corriente.Size = New System.Drawing.Size(104, 17)
        Me.rbnCuenta_corriente.TabIndex = 17
        Me.rbnCuenta_corriente.Text = "Cuenta Corriente"
        Me.rbnCuenta_corriente.UseVisualStyleBackColor = True
        Me.rbnCuenta_corriente.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCondicion_pago)
        Me.GroupBox1.Controls.Add(Me.rbnCuenta_corriente)
        Me.GroupBox1.Controls.Add(Me.rbnContado)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(30, 101)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(419, 56)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Condición de Venta"
        '
        'txtCondicion_pago
        '
        Me.txtCondicion_pago.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCondicion_pago.Location = New System.Drawing.Point(6, 21)
        Me.txtCondicion_pago.Name = "txtCondicion_pago"
        Me.txtCondicion_pago.Size = New System.Drawing.Size(407, 21)
        Me.txtCondicion_pago.TabIndex = 7
        '
        'rbnContado
        '
        Me.rbnContado.AutoSize = True
        Me.rbnContado.Checked = True
        Me.rbnContado.ForeColor = System.Drawing.Color.Yellow
        Me.rbnContado.Location = New System.Drawing.Point(21, 14)
        Me.rbnContado.Name = "rbnContado"
        Me.rbnContado.Size = New System.Drawing.Size(65, 17)
        Me.rbnContado.TabIndex = 16
        Me.rbnContado.TabStop = True
        Me.rbnContado.Text = "Contado"
        Me.rbnContado.UseVisualStyleBackColor = True
        Me.rbnContado.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbnResponsable_no_inscripto)
        Me.GroupBox2.Controls.Add(Me.rbnResponsable_inscripto)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(455, 105)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(216, 51)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Situación Iva"
        '
        'rbnResponsable_no_inscripto
        '
        Me.rbnResponsable_no_inscripto.AutoSize = True
        Me.rbnResponsable_no_inscripto.ForeColor = System.Drawing.Color.Black
        Me.rbnResponsable_no_inscripto.Location = New System.Drawing.Point(124, 20)
        Me.rbnResponsable_no_inscripto.Name = "rbnResponsable_no_inscripto"
        Me.rbnResponsable_no_inscripto.Size = New System.Drawing.Size(88, 17)
        Me.rbnResponsable_no_inscripto.TabIndex = 20
        Me.rbnResponsable_no_inscripto.Text = "Resp no Insc"
        Me.rbnResponsable_no_inscripto.UseVisualStyleBackColor = True
        '
        'rbnResponsable_inscripto
        '
        Me.rbnResponsable_inscripto.AutoSize = True
        Me.rbnResponsable_inscripto.Checked = True
        Me.rbnResponsable_inscripto.ForeColor = System.Drawing.Color.Black
        Me.rbnResponsable_inscripto.Location = New System.Drawing.Point(21, 20)
        Me.rbnResponsable_inscripto.Name = "rbnResponsable_inscripto"
        Me.rbnResponsable_inscripto.Size = New System.Drawing.Size(76, 17)
        Me.rbnResponsable_inscripto.TabIndex = 19
        Me.rbnResponsable_inscripto.TabStop = True
        Me.rbnResponsable_inscripto.Text = "Resp. Insc"
        Me.rbnResponsable_inscripto.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(677, 100)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 21)
        Me.Label11.TabIndex = 689
        Me.Label11.Text = "Impuesto"
        Me.Label11.Visible = False
        '
        'txtImpuesto
        '
        Me.txtImpuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpuesto.Location = New System.Drawing.Point(768, 100)
        Me.txtImpuesto.Name = "txtImpuesto"
        Me.txtImpuesto.Size = New System.Drawing.Size(199, 26)
        Me.txtImpuesto.TabIndex = 21
        Me.txtImpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtImpuesto.Visible = False
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(676, 101)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 21)
        Me.Label12.TabIndex = 691
        Me.Label12.Text = "Referencia:"
        '
        'txtReferencia
        '
        Me.txtReferencia.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferencia.Location = New System.Drawing.Point(767, 101)
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(200, 21)
        Me.txtReferencia.TabIndex = 8
        '
        'txtcomprobante
        '
        Me.txtcomprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcomprobante.Location = New System.Drawing.Point(754, 33)
        Me.txtcomprobante.Name = "txtcomprobante"
        Me.txtcomprobante.Size = New System.Drawing.Size(209, 22)
        Me.txtcomprobante.TabIndex = 692
        Me.txtcomprobante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(558, 7)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(100, 20)
        Me.dtpFecha.TabIndex = 693
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(466, 7)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(86, 21)
        Me.Label14.TabIndex = 694
        Me.Label14.Text = "Fecha"
        '
        'txtOrden_compra
        '
        Me.txtOrden_compra.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrden_compra.Location = New System.Drawing.Point(817, 135)
        Me.txtOrden_compra.Name = "txtOrden_compra"
        Me.txtOrden_compra.Size = New System.Drawing.Size(151, 21)
        Me.txtOrden_compra.TabIndex = 697
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(677, 135)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(134, 21)
        Me.Label15.TabIndex = 698
        Me.Label15.Text = "Orden de Compra"
        '
        'frmDetalleFactura3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 686)
        Me.Controls.Add(Me.txtOrden_compra)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtReferencia)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtcomprobante)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtImpuesto)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtNumero_remito_2)
        Me.Controls.Add(Me.txtNumero_remito_1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.rbnND)
        Me.Controls.Add(Me.rbnNC)
        Me.Controls.Add(Me.rbnFactura)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtTotal_letra)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtIva)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTipo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtIva_factura)
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
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDetalleFactura3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Factura Item"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpFecha_factura As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblid_cliente As System.Windows.Forms.Label
    Friend WithEvents btnBuscaCliente As System.Windows.Forms.Button
    Friend WithEvents cmbCliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNumero_factura_2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNumero_factura_1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblid_pk As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents lblid_factura As System.Windows.Forms.Label
    Friend WithEvents ttAgregar As System.Windows.Forms.ToolTip
    Friend WithEvents ttModificar As System.Windows.Forms.ToolTip
    Friend WithEvents ttBorrar As System.Windows.Forms.ToolTip
    Friend WithEvents ttSalir As System.Windows.Forms.ToolTip
    Friend WithEvents ttCliente As System.Windows.Forms.ToolTip
    Friend WithEvents ttGuardar As System.Windows.Forms.ToolTip
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtIva_factura As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTipo As System.Windows.Forms.TextBox
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents txtSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtIva As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents ttImprimir As System.Windows.Forms.ToolTip
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtTotal_letra As System.Windows.Forms.TextBox
    Friend WithEvents rbnFactura As System.Windows.Forms.RadioButton
    Friend WithEvents rbnNC As System.Windows.Forms.RadioButton
    Friend WithEvents rbnND As System.Windows.Forms.RadioButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtNumero_remito_2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNumero_remito_1 As System.Windows.Forms.TextBox
    Friend WithEvents rbnCuenta_corriente As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbnResponsable_no_inscripto As System.Windows.Forms.RadioButton
    Friend WithEvents rbnResponsable_inscripto As System.Windows.Forms.RadioButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtImpuesto As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents rbnContado As System.Windows.Forms.RadioButton
    Friend WithEvents txtCondicion_pago As System.Windows.Forms.TextBox
    Friend WithEvents txtReferencia As System.Windows.Forms.TextBox
    Friend WithEvents txtcomprobante As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtOrden_compra As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
