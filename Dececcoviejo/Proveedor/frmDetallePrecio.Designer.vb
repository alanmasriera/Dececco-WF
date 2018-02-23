<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetallePrecio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetallePrecio))
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblid_producto = New System.Windows.Forms.Label()
        Me.btnBuscaproducto = New System.Windows.Forms.Button()
        Me.cmbproducto = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_producto = New System.Windows.Forms.Label()
        Me.lblid_proveedor = New System.Windows.Forms.Label()
        Me.btnBuscaproveedor = New System.Windows.Forms.Button()
        Me.cmbproveedor = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_proveedor = New System.Windows.Forms.Label()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.etiquetaprecio = New System.Windows.Forms.Label()
        Me.txtalicuota = New System.Windows.Forms.TextBox()
        Me.etiquetaalicuota = New System.Windows.Forms.Label()
        Me.txtiva = New System.Windows.Forms.TextBox()
        Me.etiquetaiva = New System.Windows.Forms.Label()
        Me.txtimpuesto_interno = New System.Windows.Forms.TextBox()
        Me.etiquetaimpuesto_interno = New System.Windows.Forms.Label()
        Me.txtmargen_ganancia = New System.Windows.Forms.TextBox()
        Me.etiquetamargen_ganancia = New System.Windows.Forms.Label()
        Me.txtcod_producto_proveedor = New System.Windows.Forms.TextBox()
        Me.etiquetacod_producto_proveedor = New System.Windows.Forms.Label()
        Me.txtPack = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPrecio_venta_unitario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrecio_venta_mayorista = New System.Windows.Forms.TextBox()
        Me.txtPrecio_venta_publico = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBonificacion1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBonificacion2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPrecio_con_iva = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
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
        Me.btnSalir.Location = New System.Drawing.Point(705, 588)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(81, 69)
        Me.btnSalir.TabIndex = 41
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
        Me.btnGuardar.Location = New System.Drawing.Point(598, 588)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(78, 69)
        Me.btnGuardar.TabIndex = 40
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(821, 556)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lblid_producto
        '
        Me.lblid_producto.AutoSize = True
        Me.lblid_producto.BackColor = System.Drawing.Color.Red
        Me.lblid_producto.Location = New System.Drawing.Point(352, 68)
        Me.lblid_producto.Name = "lblid_producto"
        Me.lblid_producto.Size = New System.Drawing.Size(13, 13)
        Me.lblid_producto.TabIndex = 500
        Me.lblid_producto.Text = "0"
        Me.lblid_producto.Visible = False
        '
        'btnBuscaproducto
        '
        Me.btnBuscaproducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscaproducto.Image = CType(resources.GetObject("btnBuscaproducto.Image"), System.Drawing.Image)
        Me.btnBuscaproducto.Location = New System.Drawing.Point(770, 68)
        Me.btnBuscaproducto.Name = "btnBuscaproducto"
        Me.btnBuscaproducto.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscaproducto.TabIndex = 30
        Me.btnBuscaproducto.UseVisualStyleBackColor = True
        '
        'cmbproducto
        '
        Me.cmbproducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbproducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbproducto.FormattingEnabled = True
        Me.cmbproducto.Location = New System.Drawing.Point(143, 68)
        Me.cmbproducto.Name = "cmbproducto"
        Me.cmbproducto.Size = New System.Drawing.Size(618, 21)
        Me.cmbproducto.TabIndex = 3
        '
        'etiquetaid_producto
        '
        Me.etiquetaid_producto.AutoSize = True
        Me.etiquetaid_producto.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaid_producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_producto.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_producto.Location = New System.Drawing.Point(81, 68)
        Me.etiquetaid_producto.Name = "etiquetaid_producto"
        Me.etiquetaid_producto.Size = New System.Drawing.Size(56, 15)
        Me.etiquetaid_producto.TabIndex = 501
        Me.etiquetaid_producto.Text = "Producto"
        Me.etiquetaid_producto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_proveedor
        '
        Me.lblid_proveedor.AutoSize = True
        Me.lblid_proveedor.BackColor = System.Drawing.Color.Red
        Me.lblid_proveedor.Location = New System.Drawing.Point(352, 111)
        Me.lblid_proveedor.Name = "lblid_proveedor"
        Me.lblid_proveedor.Size = New System.Drawing.Size(13, 13)
        Me.lblid_proveedor.TabIndex = 502
        Me.lblid_proveedor.Text = "0"
        Me.lblid_proveedor.Visible = False
        '
        'btnBuscaproveedor
        '
        Me.btnBuscaproveedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscaproveedor.Image = CType(resources.GetObject("btnBuscaproveedor.Image"), System.Drawing.Image)
        Me.btnBuscaproveedor.Location = New System.Drawing.Point(770, 110)
        Me.btnBuscaproveedor.Name = "btnBuscaproveedor"
        Me.btnBuscaproveedor.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscaproveedor.TabIndex = 31
        Me.btnBuscaproveedor.UseVisualStyleBackColor = True
        '
        'cmbproveedor
        '
        Me.cmbproveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbproveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbproveedor.FormattingEnabled = True
        Me.cmbproveedor.Location = New System.Drawing.Point(143, 111)
        Me.cmbproveedor.Name = "cmbproveedor"
        Me.cmbproveedor.Size = New System.Drawing.Size(618, 21)
        Me.cmbproveedor.TabIndex = 4
        '
        'etiquetaid_proveedor
        '
        Me.etiquetaid_proveedor.AutoSize = True
        Me.etiquetaid_proveedor.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaid_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_proveedor.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_proveedor.Location = New System.Drawing.Point(74, 111)
        Me.etiquetaid_proveedor.Name = "etiquetaid_proveedor"
        Me.etiquetaid_proveedor.Size = New System.Drawing.Size(63, 15)
        Me.etiquetaid_proveedor.TabIndex = 503
        Me.etiquetaid_proveedor.Text = "Proveedor"
        Me.etiquetaid_proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtprecio
        '
        Me.txtprecio.BackColor = System.Drawing.Color.White
        Me.txtprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprecio.ForeColor = System.Drawing.Color.Black
        Me.txtprecio.Location = New System.Drawing.Point(143, 191)
        Me.txtprecio.MaxLength = 50
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(222, 22)
        Me.txtprecio.TabIndex = 6
        Me.txtprecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetaprecio
        '
        Me.etiquetaprecio.AutoSize = True
        Me.etiquetaprecio.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaprecio.ForeColor = System.Drawing.Color.Black
        Me.etiquetaprecio.Location = New System.Drawing.Point(60, 194)
        Me.etiquetaprecio.Name = "etiquetaprecio"
        Me.etiquetaprecio.Size = New System.Drawing.Size(76, 15)
        Me.etiquetaprecio.TabIndex = 504
        Me.etiquetaprecio.Text = "Precio Costo"
        Me.etiquetaprecio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtalicuota
        '
        Me.txtalicuota.BackColor = System.Drawing.Color.White
        Me.txtalicuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtalicuota.ForeColor = System.Drawing.Color.Black
        Me.txtalicuota.Location = New System.Drawing.Point(143, 319)
        Me.txtalicuota.MaxLength = 50
        Me.txtalicuota.Name = "txtalicuota"
        Me.txtalicuota.Size = New System.Drawing.Size(222, 22)
        Me.txtalicuota.TabIndex = 9
        Me.txtalicuota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetaalicuota
        '
        Me.etiquetaalicuota.AutoSize = True
        Me.etiquetaalicuota.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaalicuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaalicuota.ForeColor = System.Drawing.Color.Black
        Me.etiquetaalicuota.Location = New System.Drawing.Point(73, 319)
        Me.etiquetaalicuota.Name = "etiquetaalicuota"
        Me.etiquetaalicuota.Size = New System.Drawing.Size(64, 15)
        Me.etiquetaalicuota.TabIndex = 505
        Me.etiquetaalicuota.Text = "Alicuota %"
        Me.etiquetaalicuota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtiva
        '
        Me.txtiva.BackColor = System.Drawing.Color.White
        Me.txtiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtiva.ForeColor = System.Drawing.Color.Black
        Me.txtiva.Location = New System.Drawing.Point(143, 362)
        Me.txtiva.MaxLength = 50
        Me.txtiva.Name = "txtiva"
        Me.txtiva.Size = New System.Drawing.Size(222, 22)
        Me.txtiva.TabIndex = 10
        Me.txtiva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetaiva
        '
        Me.etiquetaiva.AutoSize = True
        Me.etiquetaiva.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaiva.ForeColor = System.Drawing.Color.Black
        Me.etiquetaiva.Location = New System.Drawing.Point(115, 362)
        Me.etiquetaiva.Name = "etiquetaiva"
        Me.etiquetaiva.Size = New System.Drawing.Size(22, 15)
        Me.etiquetaiva.TabIndex = 506
        Me.etiquetaiva.Text = "Iva"
        Me.etiquetaiva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtimpuesto_interno
        '
        Me.txtimpuesto_interno.BackColor = System.Drawing.Color.White
        Me.txtimpuesto_interno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtimpuesto_interno.ForeColor = System.Drawing.Color.Black
        Me.txtimpuesto_interno.Location = New System.Drawing.Point(539, 148)
        Me.txtimpuesto_interno.MaxLength = 50
        Me.txtimpuesto_interno.Name = "txtimpuesto_interno"
        Me.txtimpuesto_interno.Size = New System.Drawing.Size(222, 22)
        Me.txtimpuesto_interno.TabIndex = 20
        Me.txtimpuesto_interno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetaimpuesto_interno
        '
        Me.etiquetaimpuesto_interno.AutoSize = True
        Me.etiquetaimpuesto_interno.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaimpuesto_interno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaimpuesto_interno.ForeColor = System.Drawing.Color.Black
        Me.etiquetaimpuesto_interno.Location = New System.Drawing.Point(430, 148)
        Me.etiquetaimpuesto_interno.Name = "etiquetaimpuesto_interno"
        Me.etiquetaimpuesto_interno.Size = New System.Drawing.Size(103, 15)
        Me.etiquetaimpuesto_interno.TabIndex = 507
        Me.etiquetaimpuesto_interno.Text = "Impuesto_interno"
        Me.etiquetaimpuesto_interno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtmargen_ganancia
        '
        Me.txtmargen_ganancia.BackColor = System.Drawing.Color.White
        Me.txtmargen_ganancia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmargen_ganancia.ForeColor = System.Drawing.Color.Black
        Me.txtmargen_ganancia.Location = New System.Drawing.Point(143, 440)
        Me.txtmargen_ganancia.MaxLength = 50
        Me.txtmargen_ganancia.Name = "txtmargen_ganancia"
        Me.txtmargen_ganancia.Size = New System.Drawing.Size(222, 22)
        Me.txtmargen_ganancia.TabIndex = 11
        Me.txtmargen_ganancia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetamargen_ganancia
        '
        Me.etiquetamargen_ganancia.AutoSize = True
        Me.etiquetamargen_ganancia.BackColor = System.Drawing.Color.Transparent
        Me.etiquetamargen_ganancia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetamargen_ganancia.ForeColor = System.Drawing.Color.Black
        Me.etiquetamargen_ganancia.Location = New System.Drawing.Point(15, 440)
        Me.etiquetamargen_ganancia.Name = "etiquetamargen_ganancia"
        Me.etiquetamargen_ganancia.Size = New System.Drawing.Size(122, 15)
        Me.etiquetamargen_ganancia.TabIndex = 508
        Me.etiquetamargen_ganancia.Text = "Margen_ganancia %"
        Me.etiquetamargen_ganancia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcod_producto_proveedor
        '
        Me.txtcod_producto_proveedor.BackColor = System.Drawing.Color.White
        Me.txtcod_producto_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcod_producto_proveedor.Location = New System.Drawing.Point(143, 531)
        Me.txtcod_producto_proveedor.MaxLength = 50
        Me.txtcod_producto_proveedor.Name = "txtcod_producto_proveedor"
        Me.txtcod_producto_proveedor.Size = New System.Drawing.Size(453, 29)
        Me.txtcod_producto_proveedor.TabIndex = 23
        '
        'etiquetacod_producto_proveedor
        '
        Me.etiquetacod_producto_proveedor.BackColor = System.Drawing.Color.Transparent
        Me.etiquetacod_producto_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetacod_producto_proveedor.ForeColor = System.Drawing.Color.Black
        Me.etiquetacod_producto_proveedor.Location = New System.Drawing.Point(18, 527)
        Me.etiquetacod_producto_proveedor.Name = "etiquetacod_producto_proveedor"
        Me.etiquetacod_producto_proveedor.Size = New System.Drawing.Size(119, 41)
        Me.etiquetacod_producto_proveedor.TabIndex = 509
        Me.etiquetacod_producto_proveedor.Text = "Codigo del producto del proveedor"
        Me.etiquetacod_producto_proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPack
        '
        Me.txtPack.BackColor = System.Drawing.Color.White
        Me.txtPack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPack.ForeColor = System.Drawing.Color.Black
        Me.txtPack.Location = New System.Drawing.Point(143, 148)
        Me.txtPack.MaxLength = 50
        Me.txtPack.Name = "txtPack"
        Me.txtPack.Size = New System.Drawing.Size(222, 22)
        Me.txtPack.TabIndex = 5
        Me.txtPack.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(103, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 15)
        Me.Label1.TabIndex = 511
        Me.Label1.Text = "Pack"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPrecio_venta_unitario
        '
        Me.txtPrecio_venta_unitario.BackColor = System.Drawing.Color.White
        Me.txtPrecio_venta_unitario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio_venta_unitario.ForeColor = System.Drawing.Color.Black
        Me.txtPrecio_venta_unitario.Location = New System.Drawing.Point(143, 486)
        Me.txtPrecio_venta_unitario.MaxLength = 50
        Me.txtPrecio_venta_unitario.Name = "txtPrecio_venta_unitario"
        Me.txtPrecio_venta_unitario.Size = New System.Drawing.Size(222, 22)
        Me.txtPrecio_venta_unitario.TabIndex = 12
        Me.txtPrecio_venta_unitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(63, 486)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 15)
        Me.Label2.TabIndex = 513
        Me.Label2.Text = "Precio venta"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(143, 28)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(618, 31)
        Me.txtCodigo.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(91, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 15)
        Me.Label3.TabIndex = 590
        Me.Label3.Text = "Codigo"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPrecio_venta_mayorista
        '
        Me.txtPrecio_venta_mayorista.BackColor = System.Drawing.Color.White
        Me.txtPrecio_venta_mayorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio_venta_mayorista.ForeColor = System.Drawing.Color.Black
        Me.txtPrecio_venta_mayorista.Location = New System.Drawing.Point(539, 188)
        Me.txtPrecio_venta_mayorista.MaxLength = 50
        Me.txtPrecio_venta_mayorista.Name = "txtPrecio_venta_mayorista"
        Me.txtPrecio_venta_mayorista.Size = New System.Drawing.Size(222, 22)
        Me.txtPrecio_venta_mayorista.TabIndex = 21
        Me.txtPrecio_venta_mayorista.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPrecio_venta_publico
        '
        Me.txtPrecio_venta_publico.BackColor = System.Drawing.Color.White
        Me.txtPrecio_venta_publico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio_venta_publico.ForeColor = System.Drawing.Color.Black
        Me.txtPrecio_venta_publico.Location = New System.Drawing.Point(539, 231)
        Me.txtPrecio_venta_publico.MaxLength = 50
        Me.txtPrecio_venta_publico.Name = "txtPrecio_venta_publico"
        Me.txtPrecio_venta_publico.Size = New System.Drawing.Size(222, 22)
        Me.txtPrecio_venta_publico.TabIndex = 22
        Me.txtPrecio_venta_publico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(448, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 15)
        Me.Label5.TabIndex = 594
        Me.Label5.Text = "Precio publico"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(435, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 15)
        Me.Label6.TabIndex = 595
        Me.Label6.Text = "Precio mayorista"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBonificacion1
        '
        Me.txtBonificacion1.BackColor = System.Drawing.Color.White
        Me.txtBonificacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBonificacion1.ForeColor = System.Drawing.Color.Black
        Me.txtBonificacion1.Location = New System.Drawing.Point(143, 231)
        Me.txtBonificacion1.MaxLength = 50
        Me.txtBonificacion1.Name = "txtBonificacion1"
        Me.txtBonificacion1.Size = New System.Drawing.Size(222, 22)
        Me.txtBonificacion1.TabIndex = 7
        Me.txtBonificacion1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(39, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 15)
        Me.Label4.TabIndex = 597
        Me.Label4.Text = "Bonificación 1 %"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBonificacion2
        '
        Me.txtBonificacion2.BackColor = System.Drawing.Color.White
        Me.txtBonificacion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBonificacion2.ForeColor = System.Drawing.Color.Black
        Me.txtBonificacion2.Location = New System.Drawing.Point(143, 274)
        Me.txtBonificacion2.MaxLength = 50
        Me.txtBonificacion2.Name = "txtBonificacion2"
        Me.txtBonificacion2.Size = New System.Drawing.Size(222, 22)
        Me.txtBonificacion2.TabIndex = 8
        Me.txtBonificacion2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(39, 274)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 15)
        Me.Label7.TabIndex = 599
        Me.Label7.Text = "Bonificación 2 %"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPrecio_con_iva
        '
        Me.txtPrecio_con_iva.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPrecio_con_iva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio_con_iva.ForeColor = System.Drawing.Color.Black
        Me.txtPrecio_con_iva.Location = New System.Drawing.Point(143, 404)
        Me.txtPrecio_con_iva.MaxLength = 50
        Me.txtPrecio_con_iva.Name = "txtPrecio_con_iva"
        Me.txtPrecio_con_iva.ReadOnly = True
        Me.txtPrecio_con_iva.Size = New System.Drawing.Size(222, 22)
        Me.txtPrecio_con_iva.TabIndex = 600
        Me.txtPrecio_con_iva.TabStop = False
        Me.txtPrecio_con_iva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(54, 407)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 15)
        Me.Label8.TabIndex = 601
        Me.Label8.Text = "Precio con iva"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmDetallePrecio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 678)
        Me.Controls.Add(Me.txtPrecio_con_iva)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtBonificacion2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtBonificacion1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPrecio_venta_publico)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPrecio_venta_mayorista)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPrecio_venta_unitario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPack)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblid_producto)
        Me.Controls.Add(Me.btnBuscaproducto)
        Me.Controls.Add(Me.cmbproducto)
        Me.Controls.Add(Me.etiquetaid_producto)
        Me.Controls.Add(Me.lblid_proveedor)
        Me.Controls.Add(Me.btnBuscaproveedor)
        Me.Controls.Add(Me.cmbproveedor)
        Me.Controls.Add(Me.etiquetaid_proveedor)
        Me.Controls.Add(Me.txtprecio)
        Me.Controls.Add(Me.etiquetaprecio)
        Me.Controls.Add(Me.txtalicuota)
        Me.Controls.Add(Me.etiquetaalicuota)
        Me.Controls.Add(Me.txtiva)
        Me.Controls.Add(Me.etiquetaiva)
        Me.Controls.Add(Me.txtimpuesto_interno)
        Me.Controls.Add(Me.etiquetaimpuesto_interno)
        Me.Controls.Add(Me.txtmargen_ganancia)
        Me.Controls.Add(Me.etiquetamargen_ganancia)
        Me.Controls.Add(Me.txtcod_producto_proveedor)
        Me.Controls.Add(Me.etiquetacod_producto_proveedor)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDetallePrecio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetallePrecio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblid_producto As System.Windows.Forms.Label
    Friend WithEvents btnBuscaproducto As System.Windows.Forms.Button
    Friend WithEvents cmbproducto As System.Windows.Forms.ComboBox
    Friend WithEvents etiquetaid_producto As System.Windows.Forms.Label
    Friend WithEvents lblid_proveedor As System.Windows.Forms.Label
    Friend WithEvents btnBuscaproveedor As System.Windows.Forms.Button
    Friend WithEvents cmbproveedor As System.Windows.Forms.ComboBox
    Friend WithEvents etiquetaid_proveedor As System.Windows.Forms.Label
    Protected WithEvents txtprecio As System.Windows.Forms.TextBox
    Friend WithEvents etiquetaprecio As System.Windows.Forms.Label
    Protected WithEvents txtalicuota As System.Windows.Forms.TextBox
    Friend WithEvents etiquetaalicuota As System.Windows.Forms.Label
    Protected WithEvents txtiva As System.Windows.Forms.TextBox
    Friend WithEvents etiquetaiva As System.Windows.Forms.Label
    Protected WithEvents txtimpuesto_interno As System.Windows.Forms.TextBox
    Friend WithEvents etiquetaimpuesto_interno As System.Windows.Forms.Label
    Protected WithEvents txtmargen_ganancia As System.Windows.Forms.TextBox
    Friend WithEvents etiquetamargen_ganancia As System.Windows.Forms.Label
    Protected WithEvents txtcod_producto_proveedor As System.Windows.Forms.TextBox
    Friend WithEvents etiquetacod_producto_proveedor As System.Windows.Forms.Label
    Protected WithEvents btnSalir As System.Windows.Forms.Button
    Protected WithEvents btnGuardar As System.Windows.Forms.Button
    Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
    Protected WithEvents txtPack As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Protected WithEvents txtPrecio_venta_unitario As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Protected WithEvents txtPrecio_venta_mayorista As System.Windows.Forms.TextBox
    Protected WithEvents txtPrecio_venta_publico As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Protected WithEvents txtBonificacion1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Protected WithEvents txtBonificacion2 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Protected WithEvents txtPrecio_con_iva As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class

