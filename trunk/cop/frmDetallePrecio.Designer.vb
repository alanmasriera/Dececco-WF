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
       Me.components = New System.ComponentModel.Container
       Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetallePrecio))
       Me.btnSalir = New System.Windows.Forms.Button
       Me.btnGuardar = New System.Windows.Forms.Button
       Me.GroupBox1 = New System.Windows.Forms.GroupBox
       Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
       Me.lblid_producto = New System.Windows.Forms.Label
       Me.btnBuscaproducto = New System.Windows.Forms.Button
       Me.cmbproducto = New System.Windows.Forms.ComboBox
       Me.etiquetaid_producto = New System.Windows.Forms.Label
       Me.lblid_proveedor = New System.Windows.Forms.Label
       Me.btnBuscaproveedor = New System.Windows.Forms.Button
       Me.cmbproveedor = New System.Windows.Forms.ComboBox
       Me.etiquetaid_proveedor = New System.Windows.Forms.Label
       Me.txtprecio = New System.Windows.Forms.TextBox
       Me.etiquetaprecio = New System.Windows.Forms.Label
       Me.txtalicuota = New System.Windows.Forms.TextBox
       Me.etiquetaalicuota = New System.Windows.Forms.Label
       Me.txtiva = New System.Windows.Forms.TextBox
       Me.etiquetaiva = New System.Windows.Forms.Label
       Me.txtimpuesto_interno = New System.Windows.Forms.TextBox
       Me.etiquetaimpuesto_interno = New System.Windows.Forms.Label
       Me.txtpack = New System.Windows.Forms.TextBox
       Me.etiquetapack = New System.Windows.Forms.Label
       Me.txtmargen_ganancia = New System.Windows.Forms.TextBox
       Me.etiquetamargen_ganancia = New System.Windows.Forms.Label
       Me.txtcod_producto_proveedor = New System.Windows.Forms.TextBox
       Me.etiquetacod_producto_proveedor = New System.Windows.Forms.Label
       Me.txtprecio_venta_unitario = New System.Windows.Forms.TextBox
       Me.etiquetaprecio_venta_unitario = New System.Windows.Forms.Label
       Me.txtprecio_venta_mayorista = New System.Windows.Forms.TextBox
       Me.etiquetaprecio_venta_mayorista = New System.Windows.Forms.Label
       Me.txtprecio_venta_publico = New System.Windows.Forms.TextBox
       Me.etiquetaprecio_venta_publico = New System.Windows.Forms.Label
       Me.txtbonificacion1 = New System.Windows.Forms.TextBox
       Me.etiquetabonificacion1 = New System.Windows.Forms.Label
       Me.txtbonificacion2 = New System.Windows.Forms.TextBox
       Me.etiquetabonificacion2 = New System.Windows.Forms.Label
       Me.SuspendLayout()
       '
       'lblid_producto
       '
       Me.lblid_producto.AutoSize = True
       Me.lblid_producto.BackColor = System.Drawing.Color.Red
       Me.lblid_producto.Location = New System.Drawing.Point(370, 48)
       Me.lblid_producto.Name = "lblid_producto"
       Me.lblid_producto.Size = New System.Drawing.Size(13, 13)
       Me.lblid_producto.TabIndex = 500
       Me.lblid_producto.Text = "0"
       Me.lblid_producto.Visible = False
       '
       'btnBuscaproducto
       '
       Me.btnBuscaproducto.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscaproducto.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscaproducto.Location = New System.Drawing.Point(505, 48)
       Me.btnBuscaproducto.Name = "btnBuscaproducto"
       Me.btnBuscaproducto.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscaproducto.TabIndex = 60
       Me.btnBuscaproducto.UseVisualStyleBackColor = True
       '
       'cmbproducto
       '
       Me.cmbproducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbproducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbproducto.FormattingEnabled = True
       Me.cmbproducto.Location = New System.Drawing.Point(161, 48)
       Me.cmbproducto.Size = New System.Drawing.Size(329, 21)
       Me.cmbproducto.Name = "cmbproducto"
       Me.cmbproducto.TabIndex = 4
       '
       'etiquietaid_producto
       '
       Me.etiquetaid_producto.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_producto.AutoSize = True
       Me.etiquetaid_producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_producto.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_producto.Location = New System.Drawing.Point(28, 48)
       Me.etiquetaid_producto.Name = "etiquetaid_producto"
       Me.etiquetaid_producto.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_producto.TabIndex = 501
       Me.etiquetaid_producto.Text = "Producto"
       Me.etiquetaid_producto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblid_proveedor
       '
       Me.lblid_proveedor.AutoSize = True
       Me.lblid_proveedor.BackColor = System.Drawing.Color.Red
       Me.lblid_proveedor.Location = New System.Drawing.Point(370, 91)
       Me.lblid_proveedor.Name = "lblid_proveedor"
       Me.lblid_proveedor.Size = New System.Drawing.Size(13, 13)
       Me.lblid_proveedor.TabIndex = 502
       Me.lblid_proveedor.Text = "0"
       Me.lblid_proveedor.Visible = False
       '
       'btnBuscaproveedor
       '
       Me.btnBuscaproveedor.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscaproveedor.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscaproveedor.Location = New System.Drawing.Point(505, 91)
       Me.btnBuscaproveedor.Name = "btnBuscaproveedor"
       Me.btnBuscaproveedor.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscaproveedor.TabIndex = 61
       Me.btnBuscaproveedor.UseVisualStyleBackColor = True
       '
       'cmbproveedor
       '
       Me.cmbproveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbproveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbproveedor.FormattingEnabled = True
       Me.cmbproveedor.Location = New System.Drawing.Point(161, 91)
       Me.cmbproveedor.Size = New System.Drawing.Size(329, 21)
       Me.cmbproveedor.Name = "cmbproveedor"
       Me.cmbproveedor.TabIndex = 5
       '
       'etiquietaid_proveedor
       '
       Me.etiquetaid_proveedor.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_proveedor.AutoSize = True
       Me.etiquetaid_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_proveedor.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_proveedor.Location = New System.Drawing.Point(28, 91)
       Me.etiquetaid_proveedor.Name = "etiquetaid_proveedor"
       Me.etiquetaid_proveedor.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_proveedor.TabIndex = 503
       Me.etiquetaid_proveedor.Text = "Proveedor"
       Me.etiquetaid_proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtprecio
       '
       Me.txtprecio.BackColor = System.Drawing.Color.White
       Me.txtprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtprecio.ForeColor = System.Drawing.Color.Blue
       Me.txtprecio.Location = New System.Drawing.Point(161, 134)
       Me.txtprecio.MaxLength = 50
       Me.txtprecio.Name = "txtprecio"
       Me.txtprecio.Size = New System.Drawing.Size(222, 31)
       Me.txtprecio.TabIndex = 6
       Me.txtprecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietaprecio
       '
       Me.etiquetaprecio.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaprecio.AutoSize = True
       Me.etiquetaprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaprecio.ForeColor = System.Drawing.Color.Black
       Me.etiquetaprecio.Location = New System.Drawing.Point(28, 134)
       Me.etiquetaprecio.Name = "etiquetaprecio"
       Me.etiquetaprecio.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaprecio.TabIndex = 504
       Me.etiquetaprecio.Text = "Precio"
       Me.etiquetaprecio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtalicuota
       '
       Me.txtalicuota.BackColor = System.Drawing.Color.White
       Me.txtalicuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtalicuota.ForeColor = System.Drawing.Color.Blue
       Me.txtalicuota.Location = New System.Drawing.Point(161, 187)
       Me.txtalicuota.MaxLength = 50
       Me.txtalicuota.Name = "txtalicuota"
       Me.txtalicuota.Size = New System.Drawing.Size(222, 31)
       Me.txtalicuota.TabIndex = 7
       Me.txtalicuota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietaalicuota
       '
       Me.etiquetaalicuota.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaalicuota.AutoSize = True
       Me.etiquetaalicuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaalicuota.ForeColor = System.Drawing.Color.Black
       Me.etiquetaalicuota.Location = New System.Drawing.Point(28, 187)
       Me.etiquetaalicuota.Name = "etiquetaalicuota"
       Me.etiquetaalicuota.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaalicuota.TabIndex = 505
       Me.etiquetaalicuota.Text = "Alicuota"
       Me.etiquetaalicuota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtiva
       '
       Me.txtiva.BackColor = System.Drawing.Color.White
       Me.txtiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtiva.ForeColor = System.Drawing.Color.Blue
       Me.txtiva.Location = New System.Drawing.Point(161, 240)
       Me.txtiva.MaxLength = 50
       Me.txtiva.Name = "txtiva"
       Me.txtiva.Size = New System.Drawing.Size(222, 31)
       Me.txtiva.TabIndex = 8
       Me.txtiva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietaiva
       '
       Me.etiquetaiva.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaiva.AutoSize = True
       Me.etiquetaiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaiva.ForeColor = System.Drawing.Color.Black
       Me.etiquetaiva.Location = New System.Drawing.Point(28, 240)
       Me.etiquetaiva.Name = "etiquetaiva"
       Me.etiquetaiva.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaiva.TabIndex = 506
       Me.etiquetaiva.Text = "Iva"
       Me.etiquetaiva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtimpuesto_interno
       '
       Me.txtimpuesto_interno.BackColor = System.Drawing.Color.White
       Me.txtimpuesto_interno.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtimpuesto_interno.ForeColor = System.Drawing.Color.Blue
       Me.txtimpuesto_interno.Location = New System.Drawing.Point(161, 293)
       Me.txtimpuesto_interno.MaxLength = 50
       Me.txtimpuesto_interno.Name = "txtimpuesto_interno"
       Me.txtimpuesto_interno.Size = New System.Drawing.Size(222, 31)
       Me.txtimpuesto_interno.TabIndex = 9
       Me.txtimpuesto_interno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietaimpuesto_interno
       '
       Me.etiquetaimpuesto_interno.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaimpuesto_interno.AutoSize = True
       Me.etiquetaimpuesto_interno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaimpuesto_interno.ForeColor = System.Drawing.Color.Black
       Me.etiquetaimpuesto_interno.Location = New System.Drawing.Point(28, 293)
       Me.etiquetaimpuesto_interno.Name = "etiquetaimpuesto_interno"
       Me.etiquetaimpuesto_interno.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaimpuesto_interno.TabIndex = 507
       Me.etiquetaimpuesto_interno.Text = "Impuesto interno"
       Me.etiquetaimpuesto_interno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtpack
       '
       Me.txtpack.BackColor = System.Drawing.Color.White
       Me.txtpack.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtpack.ForeColor = System.Drawing.Color.Blue
       Me.txtpack.Location = New System.Drawing.Point(161, 346)
       Me.txtpack.MaxLength = 50
       Me.txtpack.Name = "txtpack"
       Me.txtpack.Size = New System.Drawing.Size(222, 31)
       Me.txtpack.TabIndex = 10
       Me.txtpack.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietapack
       '
       Me.etiquetapack.BackColor = System.Drawing.Color.Transparent
       Me.etiquetapack.AutoSize = True
       Me.etiquetapack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetapack.ForeColor = System.Drawing.Color.Black
       Me.etiquetapack.Location = New System.Drawing.Point(28, 346)
       Me.etiquetapack.Name = "etiquetapack"
       Me.etiquetapack.Size = New System.Drawing.Size(127, 21)
       Me.etiquetapack.TabIndex = 508
       Me.etiquetapack.Text = "Pack"
       Me.etiquetapack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtmargen_ganancia
       '
       Me.txtmargen_ganancia.BackColor = System.Drawing.Color.White
       Me.txtmargen_ganancia.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtmargen_ganancia.ForeColor = System.Drawing.Color.Blue
       Me.txtmargen_ganancia.Location = New System.Drawing.Point(161, 399)
       Me.txtmargen_ganancia.MaxLength = 50
       Me.txtmargen_ganancia.Name = "txtmargen_ganancia"
       Me.txtmargen_ganancia.Size = New System.Drawing.Size(222, 31)
       Me.txtmargen_ganancia.TabIndex = 11
       Me.txtmargen_ganancia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietamargen_ganancia
       '
       Me.etiquetamargen_ganancia.BackColor = System.Drawing.Color.Transparent
       Me.etiquetamargen_ganancia.AutoSize = True
       Me.etiquetamargen_ganancia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetamargen_ganancia.ForeColor = System.Drawing.Color.Black
       Me.etiquetamargen_ganancia.Location = New System.Drawing.Point(28, 399)
       Me.etiquetamargen_ganancia.Name = "etiquetamargen_ganancia"
       Me.etiquetamargen_ganancia.Size = New System.Drawing.Size(127, 21)
       Me.etiquetamargen_ganancia.TabIndex = 509
       Me.etiquetamargen_ganancia.Text = "Margen ganancia"
       Me.etiquetamargen_ganancia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtcod_producto_proveedor
       '
       Me.txtcod_producto_proveedor.BackColor = System.Drawing.Color.White
       Me.txtcod_producto_proveedor.Location = New System.Drawing.Point(161, 452)
       Me.txtcod_producto_proveedor.Size = New System.Drawing.Size(385, 20)
       Me.txtcod_producto_proveedor.MaxLength = 50
       Me.txtcod_producto_proveedor.Name = "txtcod_producto_proveedor"
       Me.txtcod_producto_proveedor.TabIndex = 12
       '
       'etiquietacod_producto_proveedor
       '
       Me.etiquetacod_producto_proveedor.BackColor = System.Drawing.Color.Transparent
       Me.etiquetacod_producto_proveedor.AutoSize = True
       Me.etiquetacod_producto_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetacod_producto_proveedor.ForeColor = System.Drawing.Color.Black
       Me.etiquetacod_producto_proveedor.Location = New System.Drawing.Point(28, 452)
       Me.etiquetacod_producto_proveedor.Name = "etiquetacod_producto_proveedor"
       Me.etiquetacod_producto_proveedor.Size = New System.Drawing.Size(127, 21)
       Me.etiquetacod_producto_proveedor.TabIndex = 510
       Me.etiquetacod_producto_proveedor.Text = "Cod producto proveedor"
       Me.etiquetacod_producto_proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtprecio_venta_unitario
       '
       Me.txtprecio_venta_unitario.BackColor = System.Drawing.Color.White
       Me.txtprecio_venta_unitario.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtprecio_venta_unitario.ForeColor = System.Drawing.Color.Blue
       Me.txtprecio_venta_unitario.Location = New System.Drawing.Point(161, 495)
       Me.txtprecio_venta_unitario.MaxLength = 50
       Me.txtprecio_venta_unitario.Name = "txtprecio_venta_unitario"
       Me.txtprecio_venta_unitario.Size = New System.Drawing.Size(222, 31)
       Me.txtprecio_venta_unitario.TabIndex = 13
       Me.txtprecio_venta_unitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietaprecio_venta_unitario
       '
       Me.etiquetaprecio_venta_unitario.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaprecio_venta_unitario.AutoSize = True
       Me.etiquetaprecio_venta_unitario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaprecio_venta_unitario.ForeColor = System.Drawing.Color.Black
       Me.etiquetaprecio_venta_unitario.Location = New System.Drawing.Point(28, 495)
       Me.etiquetaprecio_venta_unitario.Name = "etiquetaprecio_venta_unitario"
       Me.etiquetaprecio_venta_unitario.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaprecio_venta_unitario.TabIndex = 511
       Me.etiquetaprecio_venta_unitario.Text = "Precio venta unitario"
       Me.etiquetaprecio_venta_unitario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtprecio_venta_mayorista
       '
       Me.txtprecio_venta_mayorista.BackColor = System.Drawing.Color.White
       Me.txtprecio_venta_mayorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtprecio_venta_mayorista.ForeColor = System.Drawing.Color.Blue
       Me.txtprecio_venta_mayorista.Location = New System.Drawing.Point(161, 548)
       Me.txtprecio_venta_mayorista.MaxLength = 50
       Me.txtprecio_venta_mayorista.Name = "txtprecio_venta_mayorista"
       Me.txtprecio_venta_mayorista.Size = New System.Drawing.Size(222, 31)
       Me.txtprecio_venta_mayorista.TabIndex = 14
       Me.txtprecio_venta_mayorista.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietaprecio_venta_mayorista
       '
       Me.etiquetaprecio_venta_mayorista.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaprecio_venta_mayorista.AutoSize = True
       Me.etiquetaprecio_venta_mayorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaprecio_venta_mayorista.ForeColor = System.Drawing.Color.Black
       Me.etiquetaprecio_venta_mayorista.Location = New System.Drawing.Point(28, 548)
       Me.etiquetaprecio_venta_mayorista.Name = "etiquetaprecio_venta_mayorista"
       Me.etiquetaprecio_venta_mayorista.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaprecio_venta_mayorista.TabIndex = 512
       Me.etiquetaprecio_venta_mayorista.Text = "Precio venta mayorista"
       Me.etiquetaprecio_venta_mayorista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtprecio_venta_publico
       '
       Me.txtprecio_venta_publico.BackColor = System.Drawing.Color.White
       Me.txtprecio_venta_publico.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtprecio_venta_publico.ForeColor = System.Drawing.Color.Blue
       Me.txtprecio_venta_publico.Location = New System.Drawing.Point(656, 48)
       Me.txtprecio_venta_publico.MaxLength = 50
       Me.txtprecio_venta_publico.Name = "txtprecio_venta_publico"
       Me.txtprecio_venta_publico.Size = New System.Drawing.Size(222, 31)
       Me.txtprecio_venta_publico.TabIndex = 15
       Me.txtprecio_venta_publico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietaprecio_venta_publico
       '
       Me.etiquetaprecio_venta_publico.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaprecio_venta_publico.AutoSize = True
       Me.etiquetaprecio_venta_publico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaprecio_venta_publico.ForeColor = System.Drawing.Color.Black
       Me.etiquetaprecio_venta_publico.Location = New System.Drawing.Point(583, 48)
       Me.etiquetaprecio_venta_publico.Name = "etiquetaprecio_venta_publico"
       Me.etiquetaprecio_venta_publico.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaprecio_venta_publico.TabIndex = 513
       Me.etiquetaprecio_venta_publico.Text = "Precio venta publico"
       Me.etiquetaprecio_venta_publico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtbonificacion1
       '
       Me.txtbonificacion1.BackColor = System.Drawing.Color.White
       Me.txtbonificacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtbonificacion1.ForeColor = System.Drawing.Color.Blue
       Me.txtbonificacion1.Location = New System.Drawing.Point(656, 101)
       Me.txtbonificacion1.MaxLength = 50
       Me.txtbonificacion1.Name = "txtbonificacion1"
       Me.txtbonificacion1.Size = New System.Drawing.Size(222, 31)
       Me.txtbonificacion1.TabIndex = 16
       Me.txtbonificacion1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietabonificacion1
       '
       Me.etiquetabonificacion1.BackColor = System.Drawing.Color.Transparent
       Me.etiquetabonificacion1.AutoSize = True
       Me.etiquetabonificacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetabonificacion1.ForeColor = System.Drawing.Color.Black
       Me.etiquetabonificacion1.Location = New System.Drawing.Point(583, 101)
       Me.etiquetabonificacion1.Name = "etiquetabonificacion1"
       Me.etiquetabonificacion1.Size = New System.Drawing.Size(127, 21)
       Me.etiquetabonificacion1.TabIndex = 514
       Me.etiquetabonificacion1.Text = "Bonificacion1"
       Me.etiquetabonificacion1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtbonificacion2
       '
       Me.txtbonificacion2.BackColor = System.Drawing.Color.White
       Me.txtbonificacion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtbonificacion2.ForeColor = System.Drawing.Color.Blue
       Me.txtbonificacion2.Location = New System.Drawing.Point(656, 154)
       Me.txtbonificacion2.MaxLength = 50
       Me.txtbonificacion2.Name = "txtbonificacion2"
       Me.txtbonificacion2.Size = New System.Drawing.Size(222, 31)
       Me.txtbonificacion2.TabIndex = 17
       Me.txtbonificacion2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietabonificacion2
       '
       Me.etiquetabonificacion2.BackColor = System.Drawing.Color.Transparent
       Me.etiquetabonificacion2.AutoSize = True
       Me.etiquetabonificacion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetabonificacion2.ForeColor = System.Drawing.Color.Black
       Me.etiquetabonificacion2.Location = New System.Drawing.Point(583, 154)
       Me.etiquetabonificacion2.Name = "etiquetabonificacion2"
       Me.etiquetabonificacion2.Size = New System.Drawing.Size(127, 21)
       Me.etiquetabonificacion2.TabIndex = 515
       Me.etiquetabonificacion2.Text = "Bonificacion2"
       Me.etiquetabonificacion2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
       Me.GroupBox1.Size = New System.Drawing.Size(1000, 606)
       Me.GroupBox1.TabIndex = 0
       Me.GroupBox1.TabStop = False
       '
       'frmDetallePrecio
       '
       Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
       Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
       Me.ClientSize = New System.Drawing.Size(1024, 768)
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
       Me.Controls.Add(Me.txtpack)
       Me.Controls.Add(Me.etiquetapack)
       Me.Controls.Add(Me.txtmargen_ganancia)
       Me.Controls.Add(Me.etiquetamargen_ganancia)
       Me.Controls.Add(Me.txtcod_producto_proveedor)
       Me.Controls.Add(Me.etiquetacod_producto_proveedor)
       Me.Controls.Add(Me.txtprecio_venta_unitario)
       Me.Controls.Add(Me.etiquetaprecio_venta_unitario)
       Me.Controls.Add(Me.txtprecio_venta_mayorista)
       Me.Controls.Add(Me.etiquetaprecio_venta_mayorista)
       Me.Controls.Add(Me.txtprecio_venta_publico)
       Me.Controls.Add(Me.etiquetaprecio_venta_publico)
       Me.Controls.Add(Me.txtbonificacion1)
       Me.Controls.Add(Me.etiquetabonificacion1)
       Me.Controls.Add(Me.txtbonificacion2)
       Me.Controls.Add(Me.etiquetabonificacion2)
       Me.Controls.Add(Me.btnSalir)
       Me.Controls.Add(Me.btnGuardar)
       Me.Controls.Add(Me.GroupBox1)
       Me.Name = "frmDetallePrecio"
       Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
       Me.Text = "frmDetallePrecio" & vgNombreFormulario
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
   Protected WithEvents txtpack As System.Windows.Forms.TextBox
   Friend WithEvents etiquetapack As System.Windows.Forms.Label
   Protected WithEvents txtmargen_ganancia As System.Windows.Forms.TextBox
   Friend WithEvents etiquetamargen_ganancia As System.Windows.Forms.Label
   Protected WithEvents txtcod_producto_proveedor As System.Windows.Forms.TextBox
   Friend WithEvents etiquetacod_producto_proveedor As System.Windows.Forms.Label
   Protected WithEvents txtprecio_venta_unitario As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaprecio_venta_unitario As System.Windows.Forms.Label
   Protected WithEvents txtprecio_venta_mayorista As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaprecio_venta_mayorista As System.Windows.Forms.Label
   Protected WithEvents txtprecio_venta_publico As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaprecio_venta_publico As System.Windows.Forms.Label
   Protected WithEvents txtbonificacion1 As System.Windows.Forms.TextBox
   Friend WithEvents etiquetabonificacion1 As System.Windows.Forms.Label
   Protected WithEvents txtbonificacion2 As System.Windows.Forms.TextBox
   Friend WithEvents etiquetabonificacion2 As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
End Class

