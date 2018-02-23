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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleProducto))
        Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtnombre_producto = New System.Windows.Forms.TextBox()
        Me.etiquetanombre_producto = New System.Windows.Forms.Label()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.etiquetadescripcion = New System.Windows.Forms.Label()
        Me.txtabreviatura = New System.Windows.Forms.TextBox()
        Me.etiquetaabreviatura = New System.Windows.Forms.Label()
        Me.txtubicacion = New System.Windows.Forms.TextBox()
        Me.etiquetaubicacion = New System.Windows.Forms.Label()
        Me.txtPack = New System.Windows.Forms.TextBox()
        Me.etiquetastock = New System.Windows.Forms.Label()
        Me.txtstock_ideal = New System.Windows.Forms.TextBox()
        Me.etiquetastock_ideal = New System.Windows.Forms.Label()
        Me.txtstock_minimo = New System.Windows.Forms.TextBox()
        Me.etiquetastock_minimo = New System.Windows.Forms.Label()
        Me.txtcantidad_compra = New System.Windows.Forms.TextBox()
        Me.etiquetacantidad_compra = New System.Windows.Forms.Label()
        Me.txtcantidad_ingreso = New System.Windows.Forms.TextBox()
        Me.etiquetacantidad_ingreso = New System.Windows.Forms.Label()
        Me.lblid_subtipo_producto = New System.Windows.Forms.Label()
        Me.cmbsubtipo_producto = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_subtipo_producto = New System.Windows.Forms.Label()
        Me.lblid_marca = New System.Windows.Forms.Label()
        Me.cmbmarca = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_marca = New System.Windows.Forms.Label()
        Me.lblid_unidad = New System.Windows.Forms.Label()
        Me.cmbunidad = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_unidad = New System.Windows.Forms.Label()
        Me.chktilde = New System.Windows.Forms.CheckBox()
        Me.etiquetatilde = New System.Windows.Forms.Label()
        Me.btnGenerarCodigo = New System.Windows.Forms.Button()
        Me.lblid_proveedor = New System.Windows.Forms.Label()
        Me.cmbproveedor = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_proveedor = New System.Windows.Forms.Label()
        Me.txtPrecio_venta_unitario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcod_producto_proveedor = New System.Windows.Forms.TextBox()
        Me.etiquetacod_producto_proveedor = New System.Windows.Forms.Label()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.etiquetaprecio = New System.Windows.Forms.Label()
        Me.txtmargen_ganancia = New System.Windows.Forms.TextBox()
        Me.etiquetamargen_ganancia = New System.Windows.Forms.Label()
        Me.lblid_almacen = New System.Windows.Forms.Label()
        Me.cmbalmacen = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_almacen = New System.Windows.Forms.Label()
        Me.txtstock = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtPrecio_con_iva = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBonificacion2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBonificacion1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtalicuota = New System.Windows.Forms.TextBox()
        Me.etiquetaalicuota = New System.Windows.Forms.Label()
        Me.txtiva = New System.Windows.Forms.TextBox()
        Me.etiquetaiva = New System.Windows.Forms.Label()
        Me.btnBuscaalmacen = New System.Windows.Forms.Button()
        Me.btnBuscaproveedor = New System.Windows.Forms.Button()
        Me.txtTipo_venta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnControlar_duplicado = New System.Windows.Forms.Button()
        Me.txtCodigo_producto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBuscaunidad = New System.Windows.Forms.Button()
        Me.btnBuscasubtipo_producto = New System.Windows.Forms.Button()
        Me.btnBuscamarca = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtnombre_producto
        '
        Me.txtnombre_producto.BackColor = System.Drawing.Color.White
        Me.txtnombre_producto.Location = New System.Drawing.Point(161, 48)
        Me.txtnombre_producto.MaxLength = 50
        Me.txtnombre_producto.Name = "txtnombre_producto"
        Me.txtnombre_producto.Size = New System.Drawing.Size(385, 20)
        Me.txtnombre_producto.TabIndex = 4
        '
        'etiquetanombre_producto
        '
        Me.etiquetanombre_producto.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetanombre_producto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetanombre_producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetanombre_producto.ForeColor = System.Drawing.Color.Black
        Me.etiquetanombre_producto.Location = New System.Drawing.Point(28, 48)
        Me.etiquetanombre_producto.Name = "etiquetanombre_producto"
        Me.etiquetanombre_producto.Size = New System.Drawing.Size(127, 21)
        Me.etiquetanombre_producto.TabIndex = 500
        Me.etiquetanombre_producto.Text = "Codigo"
        Me.etiquetanombre_producto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtdescripcion
        '
        Me.txtdescripcion.BackColor = System.Drawing.Color.White
        Me.txtdescripcion.Location = New System.Drawing.Point(161, 91)
        Me.txtdescripcion.MaxLength = 500
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(788, 20)
        Me.txtdescripcion.TabIndex = 5
        '
        'etiquetadescripcion
        '
        Me.etiquetadescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetadescripcion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetadescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetadescripcion.ForeColor = System.Drawing.Color.Black
        Me.etiquetadescripcion.Location = New System.Drawing.Point(28, 91)
        Me.etiquetadescripcion.Name = "etiquetadescripcion"
        Me.etiquetadescripcion.Size = New System.Drawing.Size(127, 21)
        Me.etiquetadescripcion.TabIndex = 501
        Me.etiquetadescripcion.Text = "Descripcion"
        Me.etiquetadescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtabreviatura
        '
        Me.txtabreviatura.BackColor = System.Drawing.Color.White
        Me.txtabreviatura.Location = New System.Drawing.Point(161, 134)
        Me.txtabreviatura.MaxLength = 20
        Me.txtabreviatura.Name = "txtabreviatura"
        Me.txtabreviatura.Size = New System.Drawing.Size(385, 20)
        Me.txtabreviatura.TabIndex = 6
        Me.txtabreviatura.Visible = False
        '
        'etiquetaabreviatura
        '
        Me.etiquetaabreviatura.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaabreviatura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaabreviatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaabreviatura.ForeColor = System.Drawing.Color.Black
        Me.etiquetaabreviatura.Location = New System.Drawing.Point(28, 134)
        Me.etiquetaabreviatura.Name = "etiquetaabreviatura"
        Me.etiquetaabreviatura.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaabreviatura.TabIndex = 502
        Me.etiquetaabreviatura.Text = "Abreviatura (20)"
        Me.etiquetaabreviatura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.etiquetaabreviatura.Visible = False
        '
        'txtubicacion
        '
        Me.txtubicacion.BackColor = System.Drawing.Color.White
        Me.txtubicacion.Location = New System.Drawing.Point(161, 177)
        Me.txtubicacion.MaxLength = 50
        Me.txtubicacion.Name = "txtubicacion"
        Me.txtubicacion.Size = New System.Drawing.Size(385, 20)
        Me.txtubicacion.TabIndex = 7
        Me.txtubicacion.Visible = False
        '
        'etiquetaubicacion
        '
        Me.etiquetaubicacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaubicacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaubicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaubicacion.ForeColor = System.Drawing.Color.Black
        Me.etiquetaubicacion.Location = New System.Drawing.Point(28, 177)
        Me.etiquetaubicacion.Name = "etiquetaubicacion"
        Me.etiquetaubicacion.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaubicacion.TabIndex = 503
        Me.etiquetaubicacion.Text = "Ubicacion"
        Me.etiquetaubicacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.etiquetaubicacion.Visible = False
        '
        'txtPack
        '
        Me.txtPack.BackColor = System.Drawing.Color.White
        Me.txtPack.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPack.ForeColor = System.Drawing.Color.Blue
        Me.txtPack.Location = New System.Drawing.Point(161, 220)
        Me.txtPack.MaxLength = 50
        Me.txtPack.Name = "txtPack"
        Me.txtPack.Size = New System.Drawing.Size(222, 31)
        Me.txtPack.TabIndex = 8
        Me.txtPack.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetastock
        '
        Me.etiquetastock.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetastock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetastock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetastock.ForeColor = System.Drawing.Color.Black
        Me.etiquetastock.Location = New System.Drawing.Point(28, 220)
        Me.etiquetastock.Name = "etiquetastock"
        Me.etiquetastock.Size = New System.Drawing.Size(127, 21)
        Me.etiquetastock.TabIndex = 504
        Me.etiquetastock.Text = "Pack Divisorio"
        Me.etiquetastock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'etiquetastock_ideal
        '
        Me.etiquetastock_ideal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetastock_ideal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetastock_ideal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetastock_ideal.ForeColor = System.Drawing.Color.Black
        Me.etiquetastock_ideal.Location = New System.Drawing.Point(28, 273)
        Me.etiquetastock_ideal.Name = "etiquetastock_ideal"
        Me.etiquetastock_ideal.Size = New System.Drawing.Size(127, 21)
        Me.etiquetastock_ideal.TabIndex = 505
        Me.etiquetastock_ideal.Text = "Stock_ideal"
        Me.etiquetastock_ideal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'etiquetastock_minimo
        '
        Me.etiquetastock_minimo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetastock_minimo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetastock_minimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetastock_minimo.ForeColor = System.Drawing.Color.Black
        Me.etiquetastock_minimo.Location = New System.Drawing.Point(28, 326)
        Me.etiquetastock_minimo.Name = "etiquetastock_minimo"
        Me.etiquetastock_minimo.Size = New System.Drawing.Size(127, 21)
        Me.etiquetastock_minimo.TabIndex = 506
        Me.etiquetastock_minimo.Text = "Stock_minimo"
        Me.etiquetastock_minimo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.txtcantidad_compra.Visible = False
        '
        'etiquetacantidad_compra
        '
        Me.etiquetacantidad_compra.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetacantidad_compra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetacantidad_compra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetacantidad_compra.ForeColor = System.Drawing.Color.Black
        Me.etiquetacantidad_compra.Location = New System.Drawing.Point(28, 379)
        Me.etiquetacantidad_compra.Name = "etiquetacantidad_compra"
        Me.etiquetacantidad_compra.Size = New System.Drawing.Size(127, 21)
        Me.etiquetacantidad_compra.TabIndex = 507
        Me.etiquetacantidad_compra.Text = "Cantidad_compra"
        Me.etiquetacantidad_compra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.etiquetacantidad_compra.Visible = False
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
        Me.txtcantidad_ingreso.Visible = False
        '
        'etiquetacantidad_ingreso
        '
        Me.etiquetacantidad_ingreso.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetacantidad_ingreso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetacantidad_ingreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetacantidad_ingreso.ForeColor = System.Drawing.Color.Black
        Me.etiquetacantidad_ingreso.Location = New System.Drawing.Point(28, 432)
        Me.etiquetacantidad_ingreso.Name = "etiquetacantidad_ingreso"
        Me.etiquetacantidad_ingreso.Size = New System.Drawing.Size(127, 21)
        Me.etiquetacantidad_ingreso.TabIndex = 508
        Me.etiquetacantidad_ingreso.Text = "Cantidad_ingreso"
        Me.etiquetacantidad_ingreso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.etiquetacantidad_ingreso.Visible = False
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
        'cmbsubtipo_producto
        '
        Me.cmbsubtipo_producto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbsubtipo_producto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbsubtipo_producto.FormattingEnabled = True
        Me.cmbsubtipo_producto.Location = New System.Drawing.Point(161, 485)
        Me.cmbsubtipo_producto.Name = "cmbsubtipo_producto"
        Me.cmbsubtipo_producto.Size = New System.Drawing.Size(329, 21)
        Me.cmbsubtipo_producto.TabIndex = 13
        '
        'etiquetaid_subtipo_producto
        '
        Me.etiquetaid_subtipo_producto.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_subtipo_producto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_subtipo_producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_subtipo_producto.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_subtipo_producto.Location = New System.Drawing.Point(28, 485)
        Me.etiquetaid_subtipo_producto.Name = "etiquetaid_subtipo_producto"
        Me.etiquetaid_subtipo_producto.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_subtipo_producto.TabIndex = 510
        Me.etiquetaid_subtipo_producto.Text = "Subtipo"
        Me.etiquetaid_subtipo_producto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'cmbmarca
        '
        Me.cmbmarca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbmarca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbmarca.FormattingEnabled = True
        Me.cmbmarca.Location = New System.Drawing.Point(161, 528)
        Me.cmbmarca.Name = "cmbmarca"
        Me.cmbmarca.Size = New System.Drawing.Size(329, 21)
        Me.cmbmarca.TabIndex = 14
        '
        'etiquetaid_marca
        '
        Me.etiquetaid_marca.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_marca.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_marca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_marca.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_marca.Location = New System.Drawing.Point(28, 528)
        Me.etiquetaid_marca.Name = "etiquetaid_marca"
        Me.etiquetaid_marca.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_marca.TabIndex = 512
        Me.etiquetaid_marca.Text = "Marca"
        Me.etiquetaid_marca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_unidad
        '
        Me.lblid_unidad.AutoSize = True
        Me.lblid_unidad.BackColor = System.Drawing.Color.Red
        Me.lblid_unidad.Location = New System.Drawing.Point(172, 568)
        Me.lblid_unidad.Name = "lblid_unidad"
        Me.lblid_unidad.Size = New System.Drawing.Size(13, 13)
        Me.lblid_unidad.TabIndex = 513
        Me.lblid_unidad.Text = "0"
        Me.lblid_unidad.Visible = False
        '
        'cmbunidad
        '
        Me.cmbunidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbunidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbunidad.FormattingEnabled = True
        Me.cmbunidad.Location = New System.Drawing.Point(161, 568)
        Me.cmbunidad.Name = "cmbunidad"
        Me.cmbunidad.Size = New System.Drawing.Size(183, 21)
        Me.cmbunidad.TabIndex = 15
        '
        'etiquetaid_unidad
        '
        Me.etiquetaid_unidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_unidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_unidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_unidad.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_unidad.Location = New System.Drawing.Point(28, 568)
        Me.etiquetaid_unidad.Name = "etiquetaid_unidad"
        Me.etiquetaid_unidad.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_unidad.TabIndex = 514
        Me.etiquetaid_unidad.Text = "Unidad"
        Me.etiquetaid_unidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chktilde
        '
        Me.chktilde.AutoSize = True
        Me.chktilde.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chktilde.Location = New System.Drawing.Point(161, 653)
        Me.chktilde.Name = "chktilde"
        Me.chktilde.Size = New System.Drawing.Size(15, 14)
        Me.chktilde.TabIndex = 17
        '
        'etiquetatilde
        '
        Me.etiquetatilde.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetatilde.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetatilde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetatilde.ForeColor = System.Drawing.Color.Black
        Me.etiquetatilde.Location = New System.Drawing.Point(28, 653)
        Me.etiquetatilde.Name = "etiquetatilde"
        Me.etiquetatilde.Size = New System.Drawing.Size(127, 21)
        Me.etiquetatilde.TabIndex = 515
        Me.etiquetatilde.Text = "Deshabilitado"
        Me.etiquetatilde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnGenerarCodigo
        '
        Me.btnGenerarCodigo.Location = New System.Drawing.Point(575, 47)
        Me.btnGenerarCodigo.Name = "btnGenerarCodigo"
        Me.btnGenerarCodigo.Size = New System.Drawing.Size(123, 24)
        Me.btnGenerarCodigo.TabIndex = 516
        Me.btnGenerarCodigo.Text = "GenerarCodigo"
        Me.btnGenerarCodigo.UseVisualStyleBackColor = True
        '
        'lblid_proveedor
        '
        Me.lblid_proveedor.AutoSize = True
        Me.lblid_proveedor.BackColor = System.Drawing.Color.Red
        Me.lblid_proveedor.Location = New System.Drawing.Point(199, 114)
        Me.lblid_proveedor.Name = "lblid_proveedor"
        Me.lblid_proveedor.Size = New System.Drawing.Size(13, 13)
        Me.lblid_proveedor.TabIndex = 519
        Me.lblid_proveedor.Text = "0"
        Me.lblid_proveedor.Visible = False
        '
        'cmbproveedor
        '
        Me.cmbproveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbproveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbproveedor.FormattingEnabled = True
        Me.cmbproveedor.Location = New System.Drawing.Point(96, 109)
        Me.cmbproveedor.Name = "cmbproveedor"
        Me.cmbproveedor.Size = New System.Drawing.Size(295, 21)
        Me.cmbproveedor.TabIndex = 22
        '
        'etiquetaid_proveedor
        '
        Me.etiquetaid_proveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_proveedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_proveedor.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_proveedor.Location = New System.Drawing.Point(8, 110)
        Me.etiquetaid_proveedor.Name = "etiquetaid_proveedor"
        Me.etiquetaid_proveedor.Size = New System.Drawing.Size(81, 21)
        Me.etiquetaid_proveedor.TabIndex = 520
        Me.etiquetaid_proveedor.Text = "Proveedor"
        Me.etiquetaid_proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPrecio_venta_unitario
        '
        Me.txtPrecio_venta_unitario.BackColor = System.Drawing.Color.White
        Me.txtPrecio_venta_unitario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio_venta_unitario.ForeColor = System.Drawing.Color.Blue
        Me.txtPrecio_venta_unitario.Location = New System.Drawing.Point(148, 551)
        Me.txtPrecio_venta_unitario.MaxLength = 50
        Me.txtPrecio_venta_unitario.Name = "txtPrecio_venta_unitario"
        Me.txtPrecio_venta_unitario.Size = New System.Drawing.Size(222, 29)
        Me.txtPrecio_venta_unitario.TabIndex = 31
        Me.txtPrecio_venta_unitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPrecio_venta_unitario.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 551)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 21)
        Me.Label2.TabIndex = 524
        Me.Label2.Text = "Precio venta"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Visible = False
        '
        'txtcod_producto_proveedor
        '
        Me.txtcod_producto_proveedor.BackColor = System.Drawing.Color.White
        Me.txtcod_producto_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcod_producto_proveedor.Location = New System.Drawing.Point(8, 184)
        Me.txtcod_producto_proveedor.MaxLength = 50
        Me.txtcod_producto_proveedor.Name = "txtcod_producto_proveedor"
        Me.txtcod_producto_proveedor.Size = New System.Drawing.Size(376, 29)
        Me.txtcod_producto_proveedor.TabIndex = 23
        '
        'etiquetacod_producto_proveedor
        '
        Me.etiquetacod_producto_proveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetacod_producto_proveedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetacod_producto_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetacod_producto_proveedor.ForeColor = System.Drawing.Color.Black
        Me.etiquetacod_producto_proveedor.Location = New System.Drawing.Point(8, 160)
        Me.etiquetacod_producto_proveedor.Name = "etiquetacod_producto_proveedor"
        Me.etiquetacod_producto_proveedor.Size = New System.Drawing.Size(237, 21)
        Me.etiquetacod_producto_proveedor.TabIndex = 523
        Me.etiquetacod_producto_proveedor.Text = "Codigo del producto del proveedor"
        Me.etiquetacod_producto_proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtprecio
        '
        Me.txtprecio.BackColor = System.Drawing.Color.White
        Me.txtprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprecio.ForeColor = System.Drawing.Color.Blue
        Me.txtprecio.Location = New System.Drawing.Point(148, 234)
        Me.txtprecio.MaxLength = 50
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(222, 29)
        Me.txtprecio.TabIndex = 25
        Me.txtprecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetaprecio
        '
        Me.etiquetaprecio.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaprecio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaprecio.ForeColor = System.Drawing.Color.Black
        Me.etiquetaprecio.Location = New System.Drawing.Point(8, 234)
        Me.etiquetaprecio.Name = "etiquetaprecio"
        Me.etiquetaprecio.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaprecio.TabIndex = 528
        Me.etiquetaprecio.Text = "Precio de costo"
        Me.etiquetaprecio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtmargen_ganancia
        '
        Me.txtmargen_ganancia.BackColor = System.Drawing.Color.White
        Me.txtmargen_ganancia.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmargen_ganancia.ForeColor = System.Drawing.Color.Blue
        Me.txtmargen_ganancia.Location = New System.Drawing.Point(155, 500)
        Me.txtmargen_ganancia.MaxLength = 50
        Me.txtmargen_ganancia.Name = "txtmargen_ganancia"
        Me.txtmargen_ganancia.Size = New System.Drawing.Size(215, 29)
        Me.txtmargen_ganancia.TabIndex = 30
        Me.txtmargen_ganancia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtmargen_ganancia.Visible = False
        '
        'etiquetamargen_ganancia
        '
        Me.etiquetamargen_ganancia.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetamargen_ganancia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetamargen_ganancia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetamargen_ganancia.ForeColor = System.Drawing.Color.Black
        Me.etiquetamargen_ganancia.Location = New System.Drawing.Point(8, 500)
        Me.etiquetamargen_ganancia.Name = "etiquetamargen_ganancia"
        Me.etiquetamargen_ganancia.Size = New System.Drawing.Size(141, 21)
        Me.etiquetamargen_ganancia.TabIndex = 529
        Me.etiquetamargen_ganancia.Text = "Margen_ganancia %"
        Me.etiquetamargen_ganancia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.etiquetamargen_ganancia.Visible = False
        '
        'lblid_almacen
        '
        Me.lblid_almacen.AutoSize = True
        Me.lblid_almacen.BackColor = System.Drawing.Color.Red
        Me.lblid_almacen.Location = New System.Drawing.Point(271, 11)
        Me.lblid_almacen.Name = "lblid_almacen"
        Me.lblid_almacen.Size = New System.Drawing.Size(13, 13)
        Me.lblid_almacen.TabIndex = 534
        Me.lblid_almacen.Text = "0"
        Me.lblid_almacen.Visible = False
        '
        'cmbalmacen
        '
        Me.cmbalmacen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbalmacen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbalmacen.FormattingEnabled = True
        Me.cmbalmacen.Location = New System.Drawing.Point(96, 11)
        Me.cmbalmacen.Name = "cmbalmacen"
        Me.cmbalmacen.Size = New System.Drawing.Size(295, 21)
        Me.cmbalmacen.TabIndex = 20
        Me.cmbalmacen.Visible = False
        '
        'etiquetaid_almacen
        '
        Me.etiquetaid_almacen.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_almacen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_almacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_almacen.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_almacen.Location = New System.Drawing.Point(8, 11)
        Me.etiquetaid_almacen.Name = "etiquetaid_almacen"
        Me.etiquetaid_almacen.Size = New System.Drawing.Size(81, 21)
        Me.etiquetaid_almacen.TabIndex = 535
        Me.etiquetaid_almacen.Text = "Almacen"
        Me.etiquetaid_almacen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.etiquetaid_almacen.Visible = False
        '
        'txtstock
        '
        Me.txtstock.BackColor = System.Drawing.Color.White
        Me.txtstock.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstock.ForeColor = System.Drawing.Color.Blue
        Me.txtstock.Location = New System.Drawing.Point(96, 55)
        Me.txtstock.MaxLength = 50
        Me.txtstock.Name = "txtstock"
        Me.txtstock.Size = New System.Drawing.Size(188, 31)
        Me.txtstock.TabIndex = 21
        Me.txtstock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtstock.Visible = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(8, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 21)
        Me.Label3.TabIndex = 536
        Me.Label3.Text = "Stock"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtPrecio_con_iva)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtBonificacion2)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtBonificacion1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtalicuota)
        Me.Panel1.Controls.Add(Me.etiquetaalicuota)
        Me.Panel1.Controls.Add(Me.txtiva)
        Me.Panel1.Controls.Add(Me.etiquetaiva)
        Me.Panel1.Controls.Add(Me.etiquetacod_producto_proveedor)
        Me.Panel1.Controls.Add(Me.lblid_almacen)
        Me.Panel1.Controls.Add(Me.btnBuscaalmacen)
        Me.Panel1.Controls.Add(Me.cmbalmacen)
        Me.Panel1.Controls.Add(Me.etiquetaid_almacen)
        Me.Panel1.Controls.Add(Me.txtstock)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtprecio)
        Me.Panel1.Controls.Add(Me.etiquetaprecio)
        Me.Panel1.Controls.Add(Me.txtmargen_ganancia)
        Me.Panel1.Controls.Add(Me.etiquetamargen_ganancia)
        Me.Panel1.Controls.Add(Me.txtPrecio_venta_unitario)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtcod_producto_proveedor)
        Me.Panel1.Controls.Add(Me.lblid_proveedor)
        Me.Panel1.Controls.Add(Me.btnBuscaproveedor)
        Me.Panel1.Controls.Add(Me.cmbproveedor)
        Me.Panel1.Controls.Add(Me.etiquetaid_proveedor)
        Me.Panel1.Location = New System.Drawing.Point(566, 123)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(438, 599)
        Me.Panel1.TabIndex = 537
        '
        'txtPrecio_con_iva
        '
        Me.txtPrecio_con_iva.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPrecio_con_iva.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio_con_iva.ForeColor = System.Drawing.Color.Black
        Me.txtPrecio_con_iva.Location = New System.Drawing.Point(148, 455)
        Me.txtPrecio_con_iva.MaxLength = 50
        Me.txtPrecio_con_iva.Name = "txtPrecio_con_iva"
        Me.txtPrecio_con_iva.ReadOnly = True
        Me.txtPrecio_con_iva.Size = New System.Drawing.Size(222, 29)
        Me.txtPrecio_con_iva.TabIndex = 608
        Me.txtPrecio_con_iva.TabStop = False
        Me.txtPrecio_con_iva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(8, 455)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 21)
        Me.Label6.TabIndex = 609
        Me.Label6.Text = "Precio con iva"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBonificacion2
        '
        Me.txtBonificacion2.BackColor = System.Drawing.Color.White
        Me.txtBonificacion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBonificacion2.ForeColor = System.Drawing.Color.Black
        Me.txtBonificacion2.Location = New System.Drawing.Point(148, 332)
        Me.txtBonificacion2.MaxLength = 50
        Me.txtBonificacion2.Name = "txtBonificacion2"
        Me.txtBonificacion2.Size = New System.Drawing.Size(222, 29)
        Me.txtBonificacion2.TabIndex = 27
        Me.txtBonificacion2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(8, 332)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 21)
        Me.Label7.TabIndex = 607
        Me.Label7.Text = "Bonificación 2 %"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBonificacion1
        '
        Me.txtBonificacion1.BackColor = System.Drawing.Color.White
        Me.txtBonificacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBonificacion1.ForeColor = System.Drawing.Color.Black
        Me.txtBonificacion1.Location = New System.Drawing.Point(148, 289)
        Me.txtBonificacion1.MaxLength = 50
        Me.txtBonificacion1.Name = "txtBonificacion1"
        Me.txtBonificacion1.Size = New System.Drawing.Size(222, 29)
        Me.txtBonificacion1.TabIndex = 26
        Me.txtBonificacion1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(8, 289)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 21)
        Me.Label5.TabIndex = 606
        Me.Label5.Text = "Bonificación 1 %"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtalicuota
        '
        Me.txtalicuota.BackColor = System.Drawing.Color.White
        Me.txtalicuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtalicuota.ForeColor = System.Drawing.Color.Black
        Me.txtalicuota.Location = New System.Drawing.Point(148, 377)
        Me.txtalicuota.MaxLength = 50
        Me.txtalicuota.Name = "txtalicuota"
        Me.txtalicuota.Size = New System.Drawing.Size(222, 29)
        Me.txtalicuota.TabIndex = 28
        Me.txtalicuota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetaalicuota
        '
        Me.etiquetaalicuota.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaalicuota.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaalicuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaalicuota.ForeColor = System.Drawing.Color.Black
        Me.etiquetaalicuota.Location = New System.Drawing.Point(8, 377)
        Me.etiquetaalicuota.Name = "etiquetaalicuota"
        Me.etiquetaalicuota.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaalicuota.TabIndex = 604
        Me.etiquetaalicuota.Text = "Alicuota %"
        Me.etiquetaalicuota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtiva
        '
        Me.txtiva.BackColor = System.Drawing.Color.White
        Me.txtiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtiva.ForeColor = System.Drawing.Color.Black
        Me.txtiva.Location = New System.Drawing.Point(148, 420)
        Me.txtiva.MaxLength = 50
        Me.txtiva.Name = "txtiva"
        Me.txtiva.Size = New System.Drawing.Size(222, 29)
        Me.txtiva.TabIndex = 29
        Me.txtiva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetaiva
        '
        Me.etiquetaiva.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaiva.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaiva.ForeColor = System.Drawing.Color.Black
        Me.etiquetaiva.Location = New System.Drawing.Point(8, 420)
        Me.etiquetaiva.Name = "etiquetaiva"
        Me.etiquetaiva.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaiva.TabIndex = 605
        Me.etiquetaiva.Text = "Iva"
        Me.etiquetaiva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnBuscaalmacen
        '
        Me.btnBuscaalmacen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscaalmacen.Image = CType(resources.GetObject("btnBuscaalmacen.Image"), System.Drawing.Image)
        Me.btnBuscaalmacen.Location = New System.Drawing.Point(406, 11)
        Me.btnBuscaalmacen.Name = "btnBuscaalmacen"
        Me.btnBuscaalmacen.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscaalmacen.TabIndex = 43
        Me.btnBuscaalmacen.UseVisualStyleBackColor = True
        Me.btnBuscaalmacen.Visible = False
        '
        'btnBuscaproveedor
        '
        Me.btnBuscaproveedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscaproveedor.Image = CType(resources.GetObject("btnBuscaproveedor.Image"), System.Drawing.Image)
        Me.btnBuscaproveedor.Location = New System.Drawing.Point(406, 110)
        Me.btnBuscaproveedor.Name = "btnBuscaproveedor"
        Me.btnBuscaproveedor.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscaproveedor.TabIndex = 44
        Me.btnBuscaproveedor.UseVisualStyleBackColor = True
        '
        'txtTipo_venta
        '
        Me.txtTipo_venta.BackColor = System.Drawing.Color.White
        Me.txtTipo_venta.Location = New System.Drawing.Point(329, 614)
        Me.txtTipo_venta.MaxLength = 1
        Me.txtTipo_venta.Name = "txtTipo_venta"
        Me.txtTipo_venta.Size = New System.Drawing.Size(57, 20)
        Me.txtTipo_venta.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(28, 612)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(286, 21)
        Me.Label1.TabIndex = 539
        Me.Label1.Text = "Tipo de Venta (P: pesable - U: unidad)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnControlar_duplicado
        '
        Me.btnControlar_duplicado.Location = New System.Drawing.Point(807, 11)
        Me.btnControlar_duplicado.Name = "btnControlar_duplicado"
        Me.btnControlar_duplicado.Size = New System.Drawing.Size(123, 24)
        Me.btnControlar_duplicado.TabIndex = 3
        Me.btnControlar_duplicado.Text = "Controlar Duplicado"
        Me.btnControlar_duplicado.UseVisualStyleBackColor = True
        '
        'txtCodigo_producto
        '
        Me.txtCodigo_producto.BackColor = System.Drawing.Color.White
        Me.txtCodigo_producto.Location = New System.Drawing.Point(393, 12)
        Me.txtCodigo_producto.MaxLength = 50
        Me.txtCodigo_producto.Name = "txtCodigo_producto"
        Me.txtCodigo_producto.Size = New System.Drawing.Size(385, 20)
        Me.txtCodigo_producto.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(28, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(359, 21)
        Me.Label4.TabIndex = 541
        Me.Label4.Text = "Controlar el codigo para ver  si el producto ya existe"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnBuscaunidad
        '
        Me.btnBuscaunidad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscaunidad.Image = CType(resources.GetObject("btnBuscaunidad.Image"), System.Drawing.Image)
        Me.btnBuscaunidad.Location = New System.Drawing.Point(356, 569)
        Me.btnBuscaunidad.Name = "btnBuscaunidad"
        Me.btnBuscaunidad.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscaunidad.TabIndex = 42
        Me.btnBuscaunidad.UseVisualStyleBackColor = True
        '
        'btnBuscasubtipo_producto
        '
        Me.btnBuscasubtipo_producto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscasubtipo_producto.Image = CType(resources.GetObject("btnBuscasubtipo_producto.Image"), System.Drawing.Image)
        Me.btnBuscasubtipo_producto.Location = New System.Drawing.Point(505, 485)
        Me.btnBuscasubtipo_producto.Name = "btnBuscasubtipo_producto"
        Me.btnBuscasubtipo_producto.Size = New System.Drawing.Size(41, 21)
        Me.btnBuscasubtipo_producto.TabIndex = 40
        Me.btnBuscasubtipo_producto.UseVisualStyleBackColor = True
        '
        'btnBuscamarca
        '
        Me.btnBuscamarca.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscamarca.Image = CType(resources.GetObject("btnBuscamarca.Image"), System.Drawing.Image)
        Me.btnBuscamarca.Location = New System.Drawing.Point(505, 528)
        Me.btnBuscamarca.Name = "btnBuscamarca"
        Me.btnBuscamarca.Size = New System.Drawing.Size(41, 21)
        Me.btnBuscamarca.TabIndex = 41
        Me.btnBuscamarca.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(465, 653)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(81, 69)
        Me.btnSalir.TabIndex = 61
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
        Me.btnGuardar.Location = New System.Drawing.Point(365, 653)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(78, 69)
        Me.btnGuardar.TabIndex = 60
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'frmDetalleProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 734)
        Me.Controls.Add(Me.btnControlar_duplicado)
        Me.Controls.Add(Me.txtCodigo_producto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTipo_venta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnGenerarCodigo)
        Me.Controls.Add(Me.etiquetatilde)
        Me.Controls.Add(Me.txtnombre_producto)
        Me.Controls.Add(Me.chktilde)
        Me.Controls.Add(Me.etiquetanombre_producto)
        Me.Controls.Add(Me.etiquetaid_unidad)
        Me.Controls.Add(Me.txtdescripcion)
        Me.Controls.Add(Me.btnBuscaunidad)
        Me.Controls.Add(Me.etiquetadescripcion)
        Me.Controls.Add(Me.lblid_unidad)
        Me.Controls.Add(Me.txtabreviatura)
        Me.Controls.Add(Me.etiquetaabreviatura)
        Me.Controls.Add(Me.txtubicacion)
        Me.Controls.Add(Me.etiquetaubicacion)
        Me.Controls.Add(Me.txtPack)
        Me.Controls.Add(Me.etiquetastock)
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
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.cmbunidad)
        Me.Name = "frmDetalleProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetalleProducto"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
    Protected WithEvents txtPack As System.Windows.Forms.TextBox
    Friend WithEvents etiquetastock As System.Windows.Forms.Label
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
    Protected WithEvents btnSalir As System.Windows.Forms.Button
    Protected WithEvents btnGuardar As System.Windows.Forms.Button
    Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
    Friend WithEvents btnGenerarCodigo As System.Windows.Forms.Button
    Friend WithEvents lblid_proveedor As System.Windows.Forms.Label
    Friend WithEvents btnBuscaproveedor As System.Windows.Forms.Button
    Friend WithEvents cmbproveedor As System.Windows.Forms.ComboBox
    Friend WithEvents etiquetaid_proveedor As System.Windows.Forms.Label
    Protected WithEvents txtPrecio_venta_unitario As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Protected WithEvents txtcod_producto_proveedor As System.Windows.Forms.TextBox
    Friend WithEvents etiquetacod_producto_proveedor As System.Windows.Forms.Label
    Protected WithEvents txtprecio As System.Windows.Forms.TextBox
    Friend WithEvents etiquetaprecio As System.Windows.Forms.Label
    Protected WithEvents txtmargen_ganancia As System.Windows.Forms.TextBox
    Friend WithEvents etiquetamargen_ganancia As System.Windows.Forms.Label
    Friend WithEvents lblid_almacen As System.Windows.Forms.Label
    Friend WithEvents btnBuscaalmacen As System.Windows.Forms.Button
    Friend WithEvents cmbalmacen As System.Windows.Forms.ComboBox
    Friend WithEvents etiquetaid_almacen As System.Windows.Forms.Label
    Protected WithEvents txtstock As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Protected WithEvents txtTipo_venta As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnControlar_duplicado As System.Windows.Forms.Button
    Protected WithEvents txtCodigo_producto As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Protected WithEvents txtBonificacion2 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Protected WithEvents txtBonificacion1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Protected WithEvents txtalicuota As System.Windows.Forms.TextBox
    Friend WithEvents etiquetaalicuota As System.Windows.Forms.Label
    Protected WithEvents txtiva As System.Windows.Forms.TextBox
    Friend WithEvents etiquetaiva As System.Windows.Forms.Label
    Protected WithEvents txtPrecio_con_iva As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class

