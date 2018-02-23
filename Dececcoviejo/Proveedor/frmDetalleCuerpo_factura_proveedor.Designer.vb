<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleCuerpo_factura_proveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleCuerpo_factura_proveedor))
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblid_factura_proveedor = New System.Windows.Forms.Label()
        Me.lblid_producto = New System.Windows.Forms.Label()
        Me.btnBuscaproducto = New System.Windows.Forms.Button()
        Me.cmbproducto = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_producto = New System.Windows.Forms.Label()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.etiquetacantidad = New System.Windows.Forms.Label()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.etiquetaprecio = New System.Windows.Forms.Label()
        Me.txtalicuota = New System.Windows.Forms.TextBox()
        Me.etiquetaalicuota = New System.Windows.Forms.Label()
        Me.txtiva = New System.Windows.Forms.TextBox()
        Me.etiquetaiva = New System.Windows.Forms.Label()
        Me.chktilde = New System.Windows.Forms.CheckBox()
        Me.etiquetatilde = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbnCodigo = New System.Windows.Forms.RadioButton()
        Me.rbnCombo = New System.Windows.Forms.RadioButton()
        Me.lblid_proveedor = New System.Windows.Forms.Label()
        Me.btnBuscaPrecio = New System.Windows.Forms.Button()
        Me.txtimpuesto_interno = New System.Windows.Forms.TextBox()
        Me.etiquetaimpuesto_interno = New System.Windows.Forms.Label()
        Me.txtpack = New System.Windows.Forms.TextBox()
        Me.etiquetapack = New System.Windows.Forms.Label()
        Me.txtImpuestoInternoTotal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.btnSalir.Location = New System.Drawing.Point(832, 473)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(81, 69)
        Me.btnSalir.TabIndex = 21
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
        Me.btnGuardar.Location = New System.Drawing.Point(161, 473)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(78, 69)
        Me.btnGuardar.TabIndex = 20
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(12, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(918, 417)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lblid_factura_proveedor
        '
        Me.lblid_factura_proveedor.AutoSize = True
        Me.lblid_factura_proveedor.BackColor = System.Drawing.Color.Red
        Me.lblid_factura_proveedor.Location = New System.Drawing.Point(12, 9)
        Me.lblid_factura_proveedor.Name = "lblid_factura_proveedor"
        Me.lblid_factura_proveedor.Size = New System.Drawing.Size(13, 13)
        Me.lblid_factura_proveedor.TabIndex = 500
        Me.lblid_factura_proveedor.Text = "0"
        Me.lblid_factura_proveedor.Visible = False
        '
        'lblid_producto
        '
        Me.lblid_producto.AutoSize = True
        Me.lblid_producto.BackColor = System.Drawing.Color.Red
        Me.lblid_producto.Location = New System.Drawing.Point(370, 91)
        Me.lblid_producto.Name = "lblid_producto"
        Me.lblid_producto.Size = New System.Drawing.Size(13, 13)
        Me.lblid_producto.TabIndex = 502
        Me.lblid_producto.Text = "0"
        Me.lblid_producto.Visible = False
        '
        'btnBuscaproducto
        '
        Me.btnBuscaproducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscaproducto.Image = CType(resources.GetObject("btnBuscaproducto.Image"), System.Drawing.Image)
        Me.btnBuscaproducto.Location = New System.Drawing.Point(872, 92)
        Me.btnBuscaproducto.Name = "btnBuscaproducto"
        Me.btnBuscaproducto.Size = New System.Drawing.Size(41, 21)
        Me.btnBuscaproducto.TabIndex = 41
        Me.btnBuscaproducto.UseVisualStyleBackColor = True
        '
        'cmbproducto
        '
        Me.cmbproducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbproducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbproducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbproducto.FormattingEnabled = True
        Me.cmbproducto.Location = New System.Drawing.Point(161, 91)
        Me.cmbproducto.Name = "cmbproducto"
        Me.cmbproducto.Size = New System.Drawing.Size(705, 32)
        Me.cmbproducto.TabIndex = 6
        '
        'etiquetaid_producto
        '
        Me.etiquetaid_producto.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_producto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_producto.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_producto.Location = New System.Drawing.Point(28, 91)
        Me.etiquetaid_producto.Name = "etiquetaid_producto"
        Me.etiquetaid_producto.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_producto.TabIndex = 503
        Me.etiquetaid_producto.Text = "Producto"
        Me.etiquetaid_producto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcantidad
        '
        Me.txtcantidad.BackColor = System.Drawing.Color.White
        Me.txtcantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantidad.ForeColor = System.Drawing.Color.Blue
        Me.txtcantidad.Location = New System.Drawing.Point(161, 134)
        Me.txtcantidad.MaxLength = 50
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(222, 31)
        Me.txtcantidad.TabIndex = 7
        Me.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetacantidad
        '
        Me.etiquetacantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetacantidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetacantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetacantidad.ForeColor = System.Drawing.Color.Black
        Me.etiquetacantidad.Location = New System.Drawing.Point(28, 134)
        Me.etiquetacantidad.Name = "etiquetacantidad"
        Me.etiquetacantidad.Size = New System.Drawing.Size(127, 21)
        Me.etiquetacantidad.TabIndex = 504
        Me.etiquetacantidad.Text = "Cantidad"
        Me.etiquetacantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtprecio
        '
        Me.txtprecio.BackColor = System.Drawing.Color.White
        Me.txtprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprecio.ForeColor = System.Drawing.Color.Blue
        Me.txtprecio.Location = New System.Drawing.Point(161, 187)
        Me.txtprecio.MaxLength = 50
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(222, 31)
        Me.txtprecio.TabIndex = 8
        Me.txtprecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetaprecio
        '
        Me.etiquetaprecio.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaprecio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaprecio.ForeColor = System.Drawing.Color.Black
        Me.etiquetaprecio.Location = New System.Drawing.Point(28, 187)
        Me.etiquetaprecio.Name = "etiquetaprecio"
        Me.etiquetaprecio.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaprecio.TabIndex = 505
        Me.etiquetaprecio.Text = "Precio"
        Me.etiquetaprecio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtalicuota
        '
        Me.txtalicuota.BackColor = System.Drawing.Color.White
        Me.txtalicuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtalicuota.ForeColor = System.Drawing.Color.Blue
        Me.txtalicuota.Location = New System.Drawing.Point(161, 240)
        Me.txtalicuota.MaxLength = 50
        Me.txtalicuota.Name = "txtalicuota"
        Me.txtalicuota.Size = New System.Drawing.Size(222, 31)
        Me.txtalicuota.TabIndex = 9
        Me.txtalicuota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetaalicuota
        '
        Me.etiquetaalicuota.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaalicuota.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaalicuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaalicuota.ForeColor = System.Drawing.Color.Black
        Me.etiquetaalicuota.Location = New System.Drawing.Point(28, 240)
        Me.etiquetaalicuota.Name = "etiquetaalicuota"
        Me.etiquetaalicuota.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaalicuota.TabIndex = 506
        Me.etiquetaalicuota.Text = "Alicuota"
        Me.etiquetaalicuota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtiva
        '
        Me.txtiva.BackColor = System.Drawing.Color.White
        Me.txtiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtiva.ForeColor = System.Drawing.Color.Blue
        Me.txtiva.Location = New System.Drawing.Point(161, 293)
        Me.txtiva.MaxLength = 50
        Me.txtiva.Name = "txtiva"
        Me.txtiva.Size = New System.Drawing.Size(222, 31)
        Me.txtiva.TabIndex = 10
        Me.txtiva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetaiva
        '
        Me.etiquetaiva.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaiva.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaiva.ForeColor = System.Drawing.Color.Black
        Me.etiquetaiva.Location = New System.Drawing.Point(28, 293)
        Me.etiquetaiva.Name = "etiquetaiva"
        Me.etiquetaiva.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaiva.TabIndex = 507
        Me.etiquetaiva.Text = "Iva"
        Me.etiquetaiva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chktilde
        '
        Me.chktilde.AutoSize = True
        Me.chktilde.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chktilde.Location = New System.Drawing.Point(506, 508)
        Me.chktilde.Name = "chktilde"
        Me.chktilde.Size = New System.Drawing.Size(58, 21)
        Me.chktilde.TabIndex = 15
        Me.chktilde.Text = "tilde"
        Me.chktilde.Visible = False
        '
        'etiquetatilde
        '
        Me.etiquetatilde.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetatilde.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetatilde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetatilde.ForeColor = System.Drawing.Color.Black
        Me.etiquetatilde.Location = New System.Drawing.Point(373, 508)
        Me.etiquetatilde.Name = "etiquetatilde"
        Me.etiquetatilde.Size = New System.Drawing.Size(127, 21)
        Me.etiquetatilde.TabIndex = 508
        Me.etiquetatilde.Text = "Tilde"
        Me.etiquetatilde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.etiquetatilde.Visible = False
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(161, 50)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(705, 29)
        Me.txtCodigo.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(28, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 21)
        Me.Label1.TabIndex = 510
        Me.Label1.Text = "Codigo Proveedor"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rbnCodigo
        '
        Me.rbnCodigo.AutoSize = True
        Me.rbnCodigo.Checked = True
        Me.rbnCodigo.Location = New System.Drawing.Point(161, 5)
        Me.rbnCodigo.Name = "rbnCodigo"
        Me.rbnCodigo.Size = New System.Drawing.Size(129, 17)
        Me.rbnCodigo.TabIndex = 511
        Me.rbnCodigo.TabStop = True
        Me.rbnCodigo.Text = "Hacer foco en Codigo"
        Me.rbnCodigo.UseVisualStyleBackColor = True
        '
        'rbnCombo
        '
        Me.rbnCombo.AutoSize = True
        Me.rbnCombo.Location = New System.Drawing.Point(308, 5)
        Me.rbnCombo.Name = "rbnCombo"
        Me.rbnCombo.Size = New System.Drawing.Size(128, 17)
        Me.rbnCombo.TabIndex = 512
        Me.rbnCombo.Text = "Hacer foco en combo"
        Me.rbnCombo.UseVisualStyleBackColor = True
        '
        'lblid_proveedor
        '
        Me.lblid_proveedor.AutoSize = True
        Me.lblid_proveedor.BackColor = System.Drawing.Color.Red
        Me.lblid_proveedor.Location = New System.Drawing.Point(41, 9)
        Me.lblid_proveedor.Name = "lblid_proveedor"
        Me.lblid_proveedor.Size = New System.Drawing.Size(13, 13)
        Me.lblid_proveedor.TabIndex = 513
        Me.lblid_proveedor.Text = "0"
        Me.lblid_proveedor.Visible = False
        '
        'btnBuscaPrecio
        '
        Me.btnBuscaPrecio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscaPrecio.Image = CType(resources.GetObject("btnBuscaPrecio.Image"), System.Drawing.Image)
        Me.btnBuscaPrecio.Location = New System.Drawing.Point(872, 50)
        Me.btnBuscaPrecio.Name = "btnBuscaPrecio"
        Me.btnBuscaPrecio.Size = New System.Drawing.Size(41, 21)
        Me.btnBuscaPrecio.TabIndex = 40
        Me.btnBuscaPrecio.UseVisualStyleBackColor = True
        '
        'txtimpuesto_interno
        '
        Me.txtimpuesto_interno.BackColor = System.Drawing.Color.White
        Me.txtimpuesto_interno.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtimpuesto_interno.ForeColor = System.Drawing.Color.Blue
        Me.txtimpuesto_interno.Location = New System.Drawing.Point(537, 346)
        Me.txtimpuesto_interno.MaxLength = 50
        Me.txtimpuesto_interno.Name = "txtimpuesto_interno"
        Me.txtimpuesto_interno.Size = New System.Drawing.Size(222, 31)
        Me.txtimpuesto_interno.TabIndex = 12
        Me.txtimpuesto_interno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetaimpuesto_interno
        '
        Me.etiquetaimpuesto_interno.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaimpuesto_interno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaimpuesto_interno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaimpuesto_interno.ForeColor = System.Drawing.Color.Black
        Me.etiquetaimpuesto_interno.Location = New System.Drawing.Point(28, 346)
        Me.etiquetaimpuesto_interno.Name = "etiquetaimpuesto_interno"
        Me.etiquetaimpuesto_interno.Size = New System.Drawing.Size(127, 31)
        Me.etiquetaimpuesto_interno.TabIndex = 515
        Me.etiquetaimpuesto_interno.Text = "Impuesto Interno Total"
        Me.etiquetaimpuesto_interno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtpack
        '
        Me.txtpack.BackColor = System.Drawing.Color.White
        Me.txtpack.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpack.ForeColor = System.Drawing.Color.Blue
        Me.txtpack.Location = New System.Drawing.Point(161, 400)
        Me.txtpack.MaxLength = 50
        Me.txtpack.Name = "txtpack"
        Me.txtpack.Size = New System.Drawing.Size(222, 31)
        Me.txtpack.TabIndex = 13
        Me.txtpack.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetapack
        '
        Me.etiquetapack.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetapack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetapack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetapack.ForeColor = System.Drawing.Color.Black
        Me.etiquetapack.Location = New System.Drawing.Point(28, 400)
        Me.etiquetapack.Name = "etiquetapack"
        Me.etiquetapack.Size = New System.Drawing.Size(127, 21)
        Me.etiquetapack.TabIndex = 517
        Me.etiquetapack.Text = "Pack"
        Me.etiquetapack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtImpuestoInternoTotal
        '
        Me.txtImpuestoInternoTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtImpuestoInternoTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpuestoInternoTotal.ForeColor = System.Drawing.Color.Blue
        Me.txtImpuestoInternoTotal.Location = New System.Drawing.Point(161, 346)
        Me.txtImpuestoInternoTotal.MaxLength = 50
        Me.txtImpuestoInternoTotal.Name = "txtImpuestoInternoTotal"
        Me.txtImpuestoInternoTotal.Size = New System.Drawing.Size(222, 31)
        Me.txtImpuestoInternoTotal.TabIndex = 11
        Me.txtImpuestoInternoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(404, 346)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 21)
        Me.Label2.TabIndex = 519
        Me.Label2.Text = "Impuesto Interno"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmDetalleCuerpo_factura_proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(942, 554)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtImpuestoInternoTotal)
        Me.Controls.Add(Me.txtpack)
        Me.Controls.Add(Me.etiquetapack)
        Me.Controls.Add(Me.txtimpuesto_interno)
        Me.Controls.Add(Me.etiquetaimpuesto_interno)
        Me.Controls.Add(Me.btnBuscaPrecio)
        Me.Controls.Add(Me.lblid_proveedor)
        Me.Controls.Add(Me.rbnCombo)
        Me.Controls.Add(Me.rbnCodigo)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblid_factura_proveedor)
        Me.Controls.Add(Me.lblid_producto)
        Me.Controls.Add(Me.btnBuscaproducto)
        Me.Controls.Add(Me.cmbproducto)
        Me.Controls.Add(Me.etiquetaid_producto)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.etiquetacantidad)
        Me.Controls.Add(Me.txtprecio)
        Me.Controls.Add(Me.etiquetaprecio)
        Me.Controls.Add(Me.txtalicuota)
        Me.Controls.Add(Me.etiquetaalicuota)
        Me.Controls.Add(Me.txtiva)
        Me.Controls.Add(Me.etiquetaiva)
        Me.Controls.Add(Me.chktilde)
        Me.Controls.Add(Me.etiquetatilde)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDetalleCuerpo_factura_proveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetalleCuerpo_factura_proveedor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblid_factura_proveedor As System.Windows.Forms.Label
    Friend WithEvents lblid_producto As System.Windows.Forms.Label
    Friend WithEvents btnBuscaproducto As System.Windows.Forms.Button
    Friend WithEvents cmbproducto As System.Windows.Forms.ComboBox
    Friend WithEvents etiquetaid_producto As System.Windows.Forms.Label
    Protected WithEvents txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents etiquetacantidad As System.Windows.Forms.Label
    Protected WithEvents txtprecio As System.Windows.Forms.TextBox
    Friend WithEvents etiquetaprecio As System.Windows.Forms.Label
    Protected WithEvents txtalicuota As System.Windows.Forms.TextBox
    Friend WithEvents etiquetaalicuota As System.Windows.Forms.Label
    Protected WithEvents txtiva As System.Windows.Forms.TextBox
    Friend WithEvents etiquetaiva As System.Windows.Forms.Label
    Protected WithEvents chktilde As System.Windows.Forms.CheckBox
    Friend WithEvents etiquetatilde As System.Windows.Forms.Label
    Protected WithEvents btnSalir As System.Windows.Forms.Button
    Protected WithEvents btnGuardar As System.Windows.Forms.Button
    Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rbnCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents rbnCombo As System.Windows.Forms.RadioButton
    Friend WithEvents lblid_proveedor As System.Windows.Forms.Label
    Friend WithEvents btnBuscaPrecio As System.Windows.Forms.Button
    Protected WithEvents txtimpuesto_interno As System.Windows.Forms.TextBox
    Friend WithEvents etiquetaimpuesto_interno As System.Windows.Forms.Label
    Protected WithEvents txtpack As System.Windows.Forms.TextBox
    Friend WithEvents etiquetapack As System.Windows.Forms.Label
    Protected WithEvents txtImpuestoInternoTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class

