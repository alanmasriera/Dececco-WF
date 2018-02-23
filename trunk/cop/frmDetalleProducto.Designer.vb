<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleProducto
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
       Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleProducto))
       Me.btnSalir = New System.Windows.Forms.Button
       Me.btnGuardar = New System.Windows.Forms.Button
       Me.GroupBox1 = New System.Windows.Forms.GroupBox
       Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
       Me.txtnombre_producto = New System.Windows.Forms.TextBox
       Me.etiquetanombre_producto = New System.Windows.Forms.Label
       Me.txtdescripcion = New System.Windows.Forms.TextBox
       Me.etiquetadescripcion = New System.Windows.Forms.Label
       Me.txtabreviatura = New System.Windows.Forms.TextBox
       Me.etiquetaabreviatura = New System.Windows.Forms.Label
       Me.txtubicacion = New System.Windows.Forms.TextBox
       Me.etiquetaubicacion = New System.Windows.Forms.Label
       Me.txtpack = New System.Windows.Forms.TextBox
       Me.etiquetapack = New System.Windows.Forms.Label
       Me.txtstock_ideal = New System.Windows.Forms.TextBox
       Me.etiquetastock_ideal = New System.Windows.Forms.Label
       Me.txtstock_minimo = New System.Windows.Forms.TextBox
       Me.etiquetastock_minimo = New System.Windows.Forms.Label
       Me.txtcantidad_compra = New System.Windows.Forms.TextBox
       Me.etiquetacantidad_compra = New System.Windows.Forms.Label
       Me.txtcantidad_ingreso = New System.Windows.Forms.TextBox
       Me.etiquetacantidad_ingreso = New System.Windows.Forms.Label
       Me.lblid_subtipo_producto = New System.Windows.Forms.Label
       Me.btnBuscasubtipo_producto = New System.Windows.Forms.Button
       Me.cmbsubtipo_producto = New System.Windows.Forms.ComboBox
       Me.etiquetaid_subtipo_producto = New System.Windows.Forms.Label
       Me.lblid_marca = New System.Windows.Forms.Label
       Me.btnBuscamarca = New System.Windows.Forms.Button
       Me.cmbmarca = New System.Windows.Forms.ComboBox
       Me.etiquetaid_marca = New System.Windows.Forms.Label
       Me.lblid_unidad = New System.Windows.Forms.Label
       Me.btnBuscaunidad = New System.Windows.Forms.Button
       Me.cmbunidad = New System.Windows.Forms.ComboBox
       Me.etiquetaid_unidad = New System.Windows.Forms.Label
       Me.chktilde = New System.Windows.Forms.CheckBox
       Me.etiquetatilde = New System.Windows.Forms.Label
       Me.txttipo_venta = New System.Windows.Forms.TextBox
       Me.etiquetatipo_venta = New System.Windows.Forms.Label
       Me.SuspendLayout()
       '
       'txtnombre_producto
       '
       Me.txtnombre_producto.BackColor = System.Drawing.Color.White
       Me.txtnombre_producto.Location = New System.Drawing.Point(161, 48)
       Me.txtnombre_producto.Size = New System.Drawing.Size(385, 20)
       Me.txtnombre_producto.MaxLength = 50
       Me.txtnombre_producto.Name = "txtnombre_producto"
       Me.txtnombre_producto.TabIndex = 4
       '
       'etiquietanombre_producto
       '
       Me.etiquetanombre_producto.BackColor = System.Drawing.Color.Transparent
       Me.etiquetanombre_producto.AutoSize = True
       Me.etiquetanombre_producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetanombre_producto.ForeColor = System.Drawing.Color.Black
       Me.etiquetanombre_producto.Location = New System.Drawing.Point(28, 48)
       Me.etiquetanombre_producto.Name = "etiquetanombre_producto"
       Me.etiquetanombre_producto.Size = New System.Drawing.Size(127, 21)
       Me.etiquetanombre_producto.TabIndex = 500
       Me.etiquetanombre_producto.Text = "Nombre producto"
       Me.etiquetanombre_producto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtdescripcion
       '
       Me.txtdescripcion.BackColor = System.Drawing.Color.White
       Me.txtdescripcion.Location = New System.Drawing.Point(161, 91)
       Me.txtdescripcion.Size = New System.Drawing.Size(385, 20)
       Me.txtdescripcion.MaxLength = 500
       Me.txtdescripcion.Name = "txtdescripcion"
       Me.txtdescripcion.TabIndex = 5
       '
       'etiquietadescripcion
       '
       Me.etiquetadescripcion.BackColor = System.Drawing.Color.Transparent
       Me.etiquetadescripcion.AutoSize = True
       Me.etiquetadescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetadescripcion.ForeColor = System.Drawing.Color.Black
       Me.etiquetadescripcion.Location = New System.Drawing.Point(28, 91)
       Me.etiquetadescripcion.Name = "etiquetadescripcion"
       Me.etiquetadescripcion.Size = New System.Drawing.Size(127, 21)
       Me.etiquetadescripcion.TabIndex = 501
       Me.etiquetadescripcion.Text = "Descripcion"
       Me.etiquetadescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtabreviatura
       '
       Me.txtabreviatura.BackColor = System.Drawing.Color.White
       Me.txtabreviatura.Location = New System.Drawing.Point(161, 134)
       Me.txtabreviatura.Size = New System.Drawing.Size(385, 20)
       Me.txtabreviatura.MaxLength = 50
       Me.txtabreviatura.Name = "txtabreviatura"
       Me.txtabreviatura.TabIndex = 6
       '
       'etiquietaabreviatura
       '
       Me.etiquetaabreviatura.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaabreviatura.AutoSize = True
       Me.etiquetaabreviatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaabreviatura.ForeColor = System.Drawing.Color.Black
       Me.etiquetaabreviatura.Location = New System.Drawing.Point(28, 134)
       Me.etiquetaabreviatura.Name = "etiquetaabreviatura"
       Me.etiquetaabreviatura.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaabreviatura.TabIndex = 502
       Me.etiquetaabreviatura.Text = "Abreviatura"
       Me.etiquetaabreviatura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtubicacion
       '
       Me.txtubicacion.BackColor = System.Drawing.Color.White
       Me.txtubicacion.Location = New System.Drawing.Point(161, 177)
       Me.txtubicacion.Size = New System.Drawing.Size(385, 20)
       Me.txtubicacion.MaxLength = 50
       Me.txtubicacion.Name = "txtubicacion"
       Me.txtubicacion.TabIndex = 7
       '
       'etiquietaubicacion
       '
       Me.etiquetaubicacion.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaubicacion.AutoSize = True
       Me.etiquetaubicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaubicacion.ForeColor = System.Drawing.Color.Black
       Me.etiquetaubicacion.Location = New System.Drawing.Point(28, 177)
       Me.etiquetaubicacion.Name = "etiquetaubicacion"
       Me.etiquetaubicacion.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaubicacion.TabIndex = 503
       Me.etiquetaubicacion.Text = "Ubicacion"
       Me.etiquetaubicacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtpack
       '
       Me.txtpack.BackColor = System.Drawing.Color.White
       Me.txtpack.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtpack.ForeColor = System.Drawing.Color.Blue
       Me.txtpack.Location = New System.Drawing.Point(161, 220)
       Me.txtpack.MaxLength = 50
       Me.txtpack.Name = "txtpack"
       Me.txtpack.Size = New System.Drawing.Size(222, 31)
       Me.txtpack.TabIndex = 8
       Me.txtpack.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietapack
       '
       Me.etiquetapack.BackColor = System.Drawing.Color.Transparent
       Me.etiquetapack.AutoSize = True
       Me.etiquetapack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetapack.ForeColor = System.Drawing.Color.Black
       Me.etiquetapack.Location = New System.Drawing.Point(28, 220)
       Me.etiquetapack.Name = "etiquetapack"
       Me.etiquetapack.Size = New System.Drawing.Size(127, 21)
       Me.etiquetapack.TabIndex = 504
       Me.etiquetapack.Text = "Pack"
       Me.etiquetapack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtstock_ideal
       '
       Me.txtstock_ideal.BackColor = System.Drawing.Color.White
       Me.txtstock_ideal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtstock_ideal.ForeColor = System.Drawing.Color.Blue
       Me.txtstock_ideal.Location = New System.Drawing.Point(161, 273)
       Me.txtstock_ideal.MaxLength = 50
       Me.txtstock_ideal.Name = "txtstock_ideal"
       Me.txtstock_ideal.Size = New System.Drawing.Size(222, 31)
       Me.txtstock_ideal.TabIndex = 9
       Me.txtstock_ideal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietastock_ideal
       '
       Me.etiquetastock_ideal.BackColor = System.Drawing.Color.Transparent
       Me.etiquetastock_ideal.AutoSize = True
       Me.etiquetastock_ideal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetastock_ideal.ForeColor = System.Drawing.Color.Black
       Me.etiquetastock_ideal.Location = New System.Drawing.Point(28, 273)
       Me.etiquetastock_ideal.Name = "etiquetastock_ideal"
       Me.etiquetastock_ideal.Size = New System.Drawing.Size(127, 21)
       Me.etiquetastock_ideal.TabIndex = 505
       Me.etiquetastock_ideal.Text = "Stock ideal"
       Me.etiquetastock_ideal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtstock_minimo
       '
       Me.txtstock_minimo.BackColor = System.Drawing.Color.White
       Me.txtstock_minimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtstock_minimo.ForeColor = System.Drawing.Color.Blue
       Me.txtstock_minimo.Location = New System.Drawing.Point(161, 326)
       Me.txtstock_minimo.MaxLength = 50
       Me.txtstock_minimo.Name = "txtstock_minimo"
       Me.txtstock_minimo.Size = New System.Drawing.Size(222, 31)
       Me.txtstock_minimo.TabIndex = 10
       Me.txtstock_minimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietastock_minimo
       '
       Me.etiquetastock_minimo.BackColor = System.Drawing.Color.Transparent
       Me.etiquetastock_minimo.AutoSize = True
       Me.etiquetastock_minimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetastock_minimo.ForeColor = System.Drawing.Color.Black
       Me.etiquetastock_minimo.Location = New System.Drawing.Point(28, 326)
       Me.etiquetastock_minimo.Name = "etiquetastock_minimo"
       Me.etiquetastock_minimo.Size = New System.Drawing.Size(127, 21)
       Me.etiquetastock_minimo.TabIndex = 506
       Me.etiquetastock_minimo.Text = "Stock minimo"
       Me.etiquetastock_minimo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtcantidad_compra
       '
       Me.txtcantidad_compra.BackColor = System.Drawing.Color.White
       Me.txtcantidad_compra.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtcantidad_compra.ForeColor = System.Drawing.Color.Blue
       Me.txtcantidad_compra.Location = New System.Drawing.Point(161, 379)
       Me.txtcantidad_compra.MaxLength = 50
       Me.txtcantidad_compra.Name = "txtcantidad_compra"
       Me.txtcantidad_compra.Size = New System.Drawing.Size(222, 31)
       Me.txtcantidad_compra.TabIndex = 11
       Me.txtcantidad_compra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietacantidad_compra
       '
       Me.etiquetacantidad_compra.BackColor = System.Drawing.Color.Transparent
       Me.etiquetacantidad_compra.AutoSize = True
       Me.etiquetacantidad_compra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetacantidad_compra.ForeColor = System.Drawing.Color.Black
       Me.etiquetacantidad_compra.Location = New System.Drawing.Point(28, 379)
       Me.etiquetacantidad_compra.Name = "etiquetacantidad_compra"
       Me.etiquetacantidad_compra.Size = New System.Drawing.Size(127, 21)
       Me.etiquetacantidad_compra.TabIndex = 507
       Me.etiquetacantidad_compra.Text = "Cantidad compra"
       Me.etiquetacantidad_compra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtcantidad_ingreso
       '
       Me.txtcantidad_ingreso.BackColor = System.Drawing.Color.White
       Me.txtcantidad_ingreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtcantidad_ingreso.ForeColor = System.Drawing.Color.Blue
       Me.txtcantidad_ingreso.Location = New System.Drawing.Point(161, 432)
       Me.txtcantidad_ingreso.MaxLength = 50
       Me.txtcantidad_ingreso.Name = "txtcantidad_ingreso"
       Me.txtcantidad_ingreso.Size = New System.Drawing.Size(222, 31)
       Me.txtcantidad_ingreso.TabIndex = 12
       Me.txtcantidad_ingreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietacantidad_ingreso
       '
       Me.etiquetacantidad_ingreso.BackColor = System.Drawing.Color.Transparent
       Me.etiquetacantidad_ingreso.AutoSize = True
       Me.etiquetacantidad_ingreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetacantidad_ingreso.ForeColor = System.Drawing.Color.Black
       Me.etiquetacantidad_ingreso.Location = New System.Drawing.Point(28, 432)
       Me.etiquetacantidad_ingreso.Name = "etiquetacantidad_ingreso"
       Me.etiquetacantidad_ingreso.Size = New System.Drawing.Size(127, 21)
       Me.etiquetacantidad_ingreso.TabIndex = 508
       Me.etiquetacantidad_ingreso.Text = "Cantidad ingreso"
       Me.etiquetacantidad_ingreso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblid_subtipo_producto
       '
       Me.lblid_subtipo_producto.AutoSize = True
       Me.lblid_subtipo_producto.BackColor = System.Drawing.Color.Red
       Me.lblid_subtipo_producto.Location = New System.Drawing.Point(370, 485)
       Me.lblid_subtipo_producto.Name = "lblid_subtipo_producto"
       Me.lblid_subtipo_producto.Size = New System.Drawing.Size(13, 13)
       Me.lblid_subtipo_producto.TabIndex = 509
       Me.lblid_subtipo_producto.Text = "0"
       Me.lblid_subtipo_producto.Visible = False
       '
       'btnBuscasubtipo_producto
       '
       Me.btnBuscasubtipo_producto.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscasubtipo_producto.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscasubtipo_producto.Location = New System.Drawing.Point(505, 485)
       Me.btnBuscasubtipo_producto.Name = "btnBuscasubtipo_producto"
       Me.btnBuscasubtipo_producto.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscasubtipo_producto.TabIndex = 60
       Me.btnBuscasubtipo_producto.UseVisualStyleBackColor = True
       '
       'cmbsubtipo_producto
       '
       Me.cmbsubtipo_producto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbsubtipo_producto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbsubtipo_producto.FormattingEnabled = True
       Me.cmbsubtipo_producto.Location = New System.Drawing.Point(161, 485)
       Me.cmbsubtipo_producto.Size = New System.Drawing.Size(329, 21)
       Me.cmbsubtipo_producto.Name = "cmbsubtipo_producto"
       Me.cmbsubtipo_producto.TabIndex = 13
       '
       'etiquietaid_subtipo_producto
       '
       Me.etiquetaid_subtipo_producto.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_subtipo_producto.AutoSize = True
       Me.etiquetaid_subtipo_producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_subtipo_producto.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_subtipo_producto.Location = New System.Drawing.Point(28, 485)
       Me.etiquetaid_subtipo_producto.Name = "etiquetaid_subtipo_producto"
       Me.etiquetaid_subtipo_producto.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_subtipo_producto.TabIndex = 510
       Me.etiquetaid_subtipo_producto.Text = "Subtipo producto"
       Me.etiquetaid_subtipo_producto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblid_marca
       '
       Me.lblid_marca.AutoSize = True
       Me.lblid_marca.BackColor = System.Drawing.Color.Red
       Me.lblid_marca.Location = New System.Drawing.Point(370, 528)
       Me.lblid_marca.Name = "lblid_marca"
       Me.lblid_marca.Size = New System.Drawing.Size(13, 13)
       Me.lblid_marca.TabIndex = 511
       Me.lblid_marca.Text = "0"
       Me.lblid_marca.Visible = False
       '
       'btnBuscamarca
       '
       Me.btnBuscamarca.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscamarca.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscamarca.Location = New System.Drawing.Point(505, 528)
       Me.btnBuscamarca.Name = "btnBuscamarca"
       Me.btnBuscamarca.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscamarca.TabIndex = 61
       Me.btnBuscamarca.UseVisualStyleBackColor = True
       '
       'cmbmarca
       '
       Me.cmbmarca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbmarca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbmarca.FormattingEnabled = True
       Me.cmbmarca.Location = New System.Drawing.Point(161, 528)
       Me.cmbmarca.Size = New System.Drawing.Size(329, 21)
       Me.cmbmarca.Name = "cmbmarca"
       Me.cmbmarca.TabIndex = 14
       '
       'etiquietaid_marca
       '
       Me.etiquetaid_marca.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_marca.AutoSize = True
       Me.etiquetaid_marca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_marca.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_marca.Location = New System.Drawing.Point(28, 528)
       Me.etiquetaid_marca.Name = "etiquetaid_marca"
       Me.etiquetaid_marca.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_marca.TabIndex = 512
       Me.etiquetaid_marca.Text = "Marca"
       Me.etiquetaid_marca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblid_unidad
       '
       Me.lblid_unidad.AutoSize = True
       Me.lblid_unidad.BackColor = System.Drawing.Color.Red
       Me.lblid_unidad.Location = New System.Drawing.Point(800, 48)
       Me.lblid_unidad.Name = "lblid_unidad"
       Me.lblid_unidad.Size = New System.Drawing.Size(13, 13)
       Me.lblid_unidad.TabIndex = 513
       Me.lblid_unidad.Text = "0"
       Me.lblid_unidad.Visible = False
       '
       'btnBuscaunidad
       '
       Me.btnBuscaunidad.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscaunidad.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscaunidad.Location = New System.Drawing.Point(964, 48)
       Me.btnBuscaunidad.Name = "btnBuscaunidad"
       Me.btnBuscaunidad.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscaunidad.TabIndex = 62
       Me.btnBuscaunidad.UseVisualStyleBackColor = True
       '
       'cmbunidad
       '
       Me.cmbunidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbunidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbunidad.FormattingEnabled = True
       Me.cmbunidad.Location = New System.Drawing.Point(656, 48)
       Me.cmbunidad.Size = New System.Drawing.Size(286, 21)
       Me.cmbunidad.Name = "cmbunidad"
       Me.cmbunidad.TabIndex = 15
       '
       'etiquietaid_unidad
       '
       Me.etiquetaid_unidad.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_unidad.AutoSize = True
       Me.etiquetaid_unidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_unidad.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_unidad.Location = New System.Drawing.Point(583, 48)
       Me.etiquetaid_unidad.Name = "etiquetaid_unidad"
       Me.etiquetaid_unidad.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_unidad.TabIndex = 514
       Me.etiquetaid_unidad.Text = "Unidad"
       Me.etiquetaid_unidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'chktilde
       '
       Me.chktilde.AutoSize = True
       Me.chktilde.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.chktilde.Location = New System.Drawing.Point(656, 91)
       Me.chktilde.Name = "etiquetatilde"
       Me.chktilde.Size = New System.Drawing.Size(15, 14)
       Me.chktilde.TabIndex = 16
       Me.chktilde.Text = "tilde"
       Me.chktilde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       'etiquietatilde
       '
       Me.etiquetatilde.BackColor = System.Drawing.Color.Transparent
       Me.etiquetatilde.AutoSize = True
       Me.etiquetatilde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetatilde.ForeColor = System.Drawing.Color.Black
       Me.etiquetatilde.Location = New System.Drawing.Point(583, 91)
       Me.etiquetatilde.Name = "etiquetatilde"
       Me.etiquetatilde.Size = New System.Drawing.Size(127, 21)
       Me.etiquetatilde.TabIndex = 515
       Me.etiquetatilde.Text = "Tilde"
       Me.etiquetatilde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txttipo_venta
       '
       Me.txttipo_venta.BackColor = System.Drawing.Color.White
       Me.txttipo_venta.Location = New System.Drawing.Point(656, 134)
       Me.txttipo_venta.Size = New System.Drawing.Size(330, 20)
       Me.txttipo_venta.MaxLength = 1
       Me.txttipo_venta.Name = "txttipo_venta"
       Me.txttipo_venta.TabIndex = 17
       '
       'etiquietatipo_venta
       '
       Me.etiquetatipo_venta.BackColor = System.Drawing.Color.Transparent
       Me.etiquetatipo_venta.AutoSize = True
       Me.etiquetatipo_venta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetatipo_venta.ForeColor = System.Drawing.Color.Black
       Me.etiquetatipo_venta.Location = New System.Drawing.Point(583, 134)
       Me.etiquetatipo_venta.Name = "etiquetatipo_venta"
       Me.etiquetatipo_venta.Size = New System.Drawing.Size(127, 21)
       Me.etiquetatipo_venta.TabIndex = 516
       Me.etiquetatipo_venta.Text = "Tipo venta"
       Me.etiquetatipo_venta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
       'frmDetalleProducto
       '
       Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
       Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
       Me.ClientSize = New System.Drawing.Size(1024, 768)
       Me.Controls.Add(Me.txtnombre_producto)
       Me.Controls.Add(Me.etiquetanombre_producto)
       Me.Controls.Add(Me.txtdescripcion)
       Me.Controls.Add(Me.etiquetadescripcion)
       Me.Controls.Add(Me.txtabreviatura)
       Me.Controls.Add(Me.etiquetaabreviatura)
       Me.Controls.Add(Me.txtubicacion)
       Me.Controls.Add(Me.etiquetaubicacion)
       Me.Controls.Add(Me.txtpack)
       Me.Controls.Add(Me.etiquetapack)
       Me.Controls.Add(Me.txtstock_ideal)
       Me.Controls.Add(Me.etiquetastock_ideal)
       Me.Controls.Add(Me.txtstock_minimo)
       Me.Controls.Add(Me.etiquetastock_minimo)
       Me.Controls.Add(Me.txtcantidad_compra)
       Me.Controls.Add(Me.etiquetacantidad_compra)
       Me.Controls.Add(Me.txtcantidad_ingreso)
       Me.Controls.Add(Me.etiquetacantidad_ingreso)
       Me.Controls.Add(Me.lblid_subtipo_producto)
       Me.Controls.Add(Me.btnBuscasubtipo_producto)
       Me.Controls.Add(Me.cmbsubtipo_producto)
       Me.Controls.Add(Me.etiquetaid_subtipo_producto)
       Me.Controls.Add(Me.lblid_marca)
       Me.Controls.Add(Me.btnBuscamarca)
       Me.Controls.Add(Me.cmbmarca)
       Me.Controls.Add(Me.etiquetaid_marca)
       Me.Controls.Add(Me.lblid_unidad)
       Me.Controls.Add(Me.btnBuscaunidad)
       Me.Controls.Add(Me.cmbunidad)
       Me.Controls.Add(Me.etiquetaid_unidad)
       Me.Controls.Add(Me.chktilde)
       Me.Controls.Add(Me.etiquetatilde)
       Me.Controls.Add(Me.txttipo_venta)
       Me.Controls.Add(Me.etiquetatipo_venta)
       Me.Controls.Add(Me.btnSalir)
       Me.Controls.Add(Me.btnGuardar)
       Me.Controls.Add(Me.GroupBox1)
       Me.Name = "frmDetalleProducto"
       Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
       Me.Text = "frmDetalleProducto" & vgNombreFormulario
       Me.ResumeLayout(False)
       Me.PerformLayout()

   End Sub
   Protected WithEvents txtnombre_producto As System.Windows.Forms.TextBox
   Friend WithEvents etiquetanombre_producto As System.Windows.Forms.Label
   Protected WithEvents txtdescripcion As System.Windows.Forms.TextBox
   Friend WithEvents etiquetadescripcion As System.Windows.Forms.Label
   Protected WithEvents txtabreviatura As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaabreviatura As System.Windows.Forms.Label
   Protected WithEvents txtubicacion As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaubicacion As System.Windows.Forms.Label
   Protected WithEvents txtpack As System.Windows.Forms.TextBox
   Friend WithEvents etiquetapack As System.Windows.Forms.Label
   Protected WithEvents txtstock_ideal As System.Windows.Forms.TextBox
   Friend WithEvents etiquetastock_ideal As System.Windows.Forms.Label
   Protected WithEvents txtstock_minimo As System.Windows.Forms.TextBox
   Friend WithEvents etiquetastock_minimo As System.Windows.Forms.Label
   Protected WithEvents txtcantidad_compra As System.Windows.Forms.TextBox
   Friend WithEvents etiquetacantidad_compra As System.Windows.Forms.Label
   Protected WithEvents txtcantidad_ingreso As System.Windows.Forms.TextBox
   Friend WithEvents etiquetacantidad_ingreso As System.Windows.Forms.Label
   Friend WithEvents lblid_subtipo_producto As System.Windows.Forms.Label
   Friend WithEvents btnBuscasubtipo_producto As System.Windows.Forms.Button
   Friend WithEvents cmbsubtipo_producto As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_subtipo_producto As System.Windows.Forms.Label
   Friend WithEvents lblid_marca As System.Windows.Forms.Label
   Friend WithEvents btnBuscamarca As System.Windows.Forms.Button
   Friend WithEvents cmbmarca As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_marca As System.Windows.Forms.Label
   Friend WithEvents lblid_unidad As System.Windows.Forms.Label
   Friend WithEvents btnBuscaunidad As System.Windows.Forms.Button
   Friend WithEvents cmbunidad As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_unidad As System.Windows.Forms.Label
   Protected WithEvents chktilde As System.Windows.Forms.CheckBox
   Friend WithEvents etiquetatilde As System.Windows.Forms.Label
   Protected WithEvents txttipo_venta As System.Windows.Forms.TextBox
   Friend WithEvents etiquetatipo_venta As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
End Class

