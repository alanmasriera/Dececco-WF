<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleCliente))
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtnombre_cliente = New System.Windows.Forms.TextBox()
        Me.etiquetanombre_cliente = New System.Windows.Forms.Label()
        Me.txtapellido_cliente = New System.Windows.Forms.TextBox()
        Me.etiquetaapellido_cliente = New System.Windows.Forms.Label()
        Me.txtrazon_social = New System.Windows.Forms.TextBox()
        Me.etiquetarazon_social = New System.Windows.Forms.Label()
        Me.txtnombre_fantasia = New System.Windows.Forms.TextBox()
        Me.etiquetanombre_fantasia = New System.Windows.Forms.Label()
        Me.txtcontacto = New System.Windows.Forms.TextBox()
        Me.etiquetacontacto = New System.Windows.Forms.Label()
        Me.txtdni_cliente = New System.Windows.Forms.TextBox()
        Me.etiquetadni_cliente = New System.Windows.Forms.Label()
        Me.lblid_tipo_dni = New System.Windows.Forms.Label()
        Me.btnBuscatipo_dni = New System.Windows.Forms.Button()
        Me.cmbtipo_dni = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_tipo_dni = New System.Windows.Forms.Label()
        Me.lblid_calle = New System.Windows.Forms.Label()
        Me.btnBuscacalle = New System.Windows.Forms.Button()
        Me.cmbcalle = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_calle = New System.Windows.Forms.Label()
        Me.txtdireccion_cliente = New System.Windows.Forms.TextBox()
        Me.etiquetadireccion_cliente = New System.Windows.Forms.Label()
        Me.lblid_localidad = New System.Windows.Forms.Label()
        Me.btnBuscalocalidad = New System.Windows.Forms.Button()
        Me.cmblocalidad = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_localidad = New System.Windows.Forms.Label()
        Me.lblid_provincia = New System.Windows.Forms.Label()
        Me.btnBuscaprovincia = New System.Windows.Forms.Button()
        Me.cmbprovincia = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_provincia = New System.Windows.Forms.Label()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.etiquetatelefono = New System.Windows.Forms.Label()
        Me.txtmail = New System.Windows.Forms.TextBox()
        Me.etiquetamail = New System.Windows.Forms.Label()
        Me.txtweb = New System.Windows.Forms.TextBox()
        Me.etiquetaweb = New System.Windows.Forms.Label()
        Me.lblid_condicion_iva = New System.Windows.Forms.Label()
        Me.btnBuscacondicion_iva = New System.Windows.Forms.Button()
        Me.cmbcondicion_iva = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_condicion_iva = New System.Windows.Forms.Label()
        Me.txtingreso_bruto = New System.Windows.Forms.TextBox()
        Me.etiquetaingreso_bruto = New System.Windows.Forms.Label()
        Me.txtlugar_pago = New System.Windows.Forms.TextBox()
        Me.etiquetalugar_pago = New System.Windows.Forms.Label()
        Me.chkpercepcion_iva = New System.Windows.Forms.CheckBox()
        Me.etiquetapercepcion_iva = New System.Windows.Forms.Label()
        Me.chkpercepcion_ingreso_bruto = New System.Windows.Forms.CheckBox()
        Me.etiquetapercepcion_ingreso_bruto = New System.Windows.Forms.Label()
        Me.chkretencion_iva = New System.Windows.Forms.CheckBox()
        Me.etiquetaretencion_iva = New System.Windows.Forms.Label()
        Me.chkretencion_ingreso_bruto = New System.Windows.Forms.CheckBox()
        Me.etiquetaretencion_ingreso_bruto = New System.Windows.Forms.Label()
        Me.txtnumero_proveedor = New System.Windows.Forms.TextBox()
        Me.etiquetanumero_proveedor = New System.Windows.Forms.Label()
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
        Me.btnSalir.Location = New System.Drawing.Point(912, 640)
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
        Me.btnGuardar.Location = New System.Drawing.Point(801, 640)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(78, 69)
        Me.btnGuardar.TabIndex = 60
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(12, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(981, 586)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtnombre_cliente
        '
        Me.txtnombre_cliente.BackColor = System.Drawing.Color.White
        Me.txtnombre_cliente.Location = New System.Drawing.Point(161, 48)
        Me.txtnombre_cliente.MaxLength = 50
        Me.txtnombre_cliente.Name = "txtnombre_cliente"
        Me.txtnombre_cliente.Size = New System.Drawing.Size(385, 20)
        Me.txtnombre_cliente.TabIndex = 4
        '
        'etiquetanombre_cliente
        '
        Me.etiquetanombre_cliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetanombre_cliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetanombre_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetanombre_cliente.ForeColor = System.Drawing.Color.Black
        Me.etiquetanombre_cliente.Location = New System.Drawing.Point(28, 48)
        Me.etiquetanombre_cliente.Name = "etiquetanombre_cliente"
        Me.etiquetanombre_cliente.Size = New System.Drawing.Size(127, 21)
        Me.etiquetanombre_cliente.TabIndex = 500
        Me.etiquetanombre_cliente.Text = "Nombre_cliente"
        Me.etiquetanombre_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtapellido_cliente
        '
        Me.txtapellido_cliente.BackColor = System.Drawing.Color.White
        Me.txtapellido_cliente.Location = New System.Drawing.Point(161, 91)
        Me.txtapellido_cliente.MaxLength = 50
        Me.txtapellido_cliente.Name = "txtapellido_cliente"
        Me.txtapellido_cliente.Size = New System.Drawing.Size(385, 20)
        Me.txtapellido_cliente.TabIndex = 5
        '
        'etiquetaapellido_cliente
        '
        Me.etiquetaapellido_cliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaapellido_cliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaapellido_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaapellido_cliente.ForeColor = System.Drawing.Color.Black
        Me.etiquetaapellido_cliente.Location = New System.Drawing.Point(28, 91)
        Me.etiquetaapellido_cliente.Name = "etiquetaapellido_cliente"
        Me.etiquetaapellido_cliente.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaapellido_cliente.TabIndex = 501
        Me.etiquetaapellido_cliente.Text = "Apellido_cliente"
        Me.etiquetaapellido_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtrazon_social
        '
        Me.txtrazon_social.BackColor = System.Drawing.Color.White
        Me.txtrazon_social.Location = New System.Drawing.Point(161, 134)
        Me.txtrazon_social.MaxLength = 50
        Me.txtrazon_social.Name = "txtrazon_social"
        Me.txtrazon_social.Size = New System.Drawing.Size(385, 20)
        Me.txtrazon_social.TabIndex = 6
        '
        'etiquetarazon_social
        '
        Me.etiquetarazon_social.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetarazon_social.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetarazon_social.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetarazon_social.ForeColor = System.Drawing.Color.Black
        Me.etiquetarazon_social.Location = New System.Drawing.Point(28, 134)
        Me.etiquetarazon_social.Name = "etiquetarazon_social"
        Me.etiquetarazon_social.Size = New System.Drawing.Size(127, 21)
        Me.etiquetarazon_social.TabIndex = 502
        Me.etiquetarazon_social.Text = "Razon_social"
        Me.etiquetarazon_social.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtnombre_fantasia
        '
        Me.txtnombre_fantasia.BackColor = System.Drawing.Color.White
        Me.txtnombre_fantasia.Location = New System.Drawing.Point(161, 177)
        Me.txtnombre_fantasia.MaxLength = 50
        Me.txtnombre_fantasia.Name = "txtnombre_fantasia"
        Me.txtnombre_fantasia.Size = New System.Drawing.Size(385, 20)
        Me.txtnombre_fantasia.TabIndex = 7
        '
        'etiquetanombre_fantasia
        '
        Me.etiquetanombre_fantasia.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetanombre_fantasia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetanombre_fantasia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetanombre_fantasia.ForeColor = System.Drawing.Color.Black
        Me.etiquetanombre_fantasia.Location = New System.Drawing.Point(28, 177)
        Me.etiquetanombre_fantasia.Name = "etiquetanombre_fantasia"
        Me.etiquetanombre_fantasia.Size = New System.Drawing.Size(127, 21)
        Me.etiquetanombre_fantasia.TabIndex = 503
        Me.etiquetanombre_fantasia.Text = "Nombre_fantasia"
        Me.etiquetanombre_fantasia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcontacto
        '
        Me.txtcontacto.BackColor = System.Drawing.Color.White
        Me.txtcontacto.Location = New System.Drawing.Point(161, 220)
        Me.txtcontacto.MaxLength = 50
        Me.txtcontacto.Name = "txtcontacto"
        Me.txtcontacto.Size = New System.Drawing.Size(385, 20)
        Me.txtcontacto.TabIndex = 8
        '
        'etiquetacontacto
        '
        Me.etiquetacontacto.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetacontacto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetacontacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetacontacto.ForeColor = System.Drawing.Color.Black
        Me.etiquetacontacto.Location = New System.Drawing.Point(28, 220)
        Me.etiquetacontacto.Name = "etiquetacontacto"
        Me.etiquetacontacto.Size = New System.Drawing.Size(127, 21)
        Me.etiquetacontacto.TabIndex = 504
        Me.etiquetacontacto.Text = "Contacto"
        Me.etiquetacontacto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtdni_cliente
        '
        Me.txtdni_cliente.BackColor = System.Drawing.Color.White
        Me.txtdni_cliente.Location = New System.Drawing.Point(161, 263)
        Me.txtdni_cliente.MaxLength = 50
        Me.txtdni_cliente.Name = "txtdni_cliente"
        Me.txtdni_cliente.Size = New System.Drawing.Size(385, 20)
        Me.txtdni_cliente.TabIndex = 9
        '
        'etiquetadni_cliente
        '
        Me.etiquetadni_cliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetadni_cliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetadni_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetadni_cliente.ForeColor = System.Drawing.Color.Black
        Me.etiquetadni_cliente.Location = New System.Drawing.Point(28, 263)
        Me.etiquetadni_cliente.Name = "etiquetadni_cliente"
        Me.etiquetadni_cliente.Size = New System.Drawing.Size(127, 21)
        Me.etiquetadni_cliente.TabIndex = 505
        Me.etiquetadni_cliente.Text = "Dni_cliente"
        Me.etiquetadni_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_tipo_dni
        '
        Me.lblid_tipo_dni.AutoSize = True
        Me.lblid_tipo_dni.BackColor = System.Drawing.Color.Red
        Me.lblid_tipo_dni.Location = New System.Drawing.Point(370, 306)
        Me.lblid_tipo_dni.Name = "lblid_tipo_dni"
        Me.lblid_tipo_dni.Size = New System.Drawing.Size(13, 13)
        Me.lblid_tipo_dni.TabIndex = 506
        Me.lblid_tipo_dni.Text = "0"
        Me.lblid_tipo_dni.Visible = False
        '
        'btnBuscatipo_dni
        '
        Me.btnBuscatipo_dni.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscatipo_dni.Image = CType(resources.GetObject("btnBuscatipo_dni.Image"), System.Drawing.Image)
        Me.btnBuscatipo_dni.Location = New System.Drawing.Point(505, 306)
        Me.btnBuscatipo_dni.Name = "btnBuscatipo_dni"
        Me.btnBuscatipo_dni.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscatipo_dni.TabIndex = 30
        Me.btnBuscatipo_dni.UseVisualStyleBackColor = True
        '
        'cmbtipo_dni
        '
        Me.cmbtipo_dni.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbtipo_dni.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbtipo_dni.FormattingEnabled = True
        Me.cmbtipo_dni.Location = New System.Drawing.Point(161, 306)
        Me.cmbtipo_dni.Name = "cmbtipo_dni"
        Me.cmbtipo_dni.Size = New System.Drawing.Size(329, 21)
        Me.cmbtipo_dni.TabIndex = 10
        '
        'etiquetaid_tipo_dni
        '
        Me.etiquetaid_tipo_dni.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_tipo_dni.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_tipo_dni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_tipo_dni.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_tipo_dni.Location = New System.Drawing.Point(28, 306)
        Me.etiquetaid_tipo_dni.Name = "etiquetaid_tipo_dni"
        Me.etiquetaid_tipo_dni.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_tipo_dni.TabIndex = 507
        Me.etiquetaid_tipo_dni.Text = "Tipo_dni"
        Me.etiquetaid_tipo_dni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_calle
        '
        Me.lblid_calle.AutoSize = True
        Me.lblid_calle.BackColor = System.Drawing.Color.Red
        Me.lblid_calle.Location = New System.Drawing.Point(370, 349)
        Me.lblid_calle.Name = "lblid_calle"
        Me.lblid_calle.Size = New System.Drawing.Size(13, 13)
        Me.lblid_calle.TabIndex = 508
        Me.lblid_calle.Text = "0"
        Me.lblid_calle.Visible = False
        '
        'btnBuscacalle
        '
        Me.btnBuscacalle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscacalle.Image = CType(resources.GetObject("btnBuscacalle.Image"), System.Drawing.Image)
        Me.btnBuscacalle.Location = New System.Drawing.Point(505, 349)
        Me.btnBuscacalle.Name = "btnBuscacalle"
        Me.btnBuscacalle.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscacalle.TabIndex = 31
        Me.btnBuscacalle.UseVisualStyleBackColor = True
        '
        'cmbcalle
        '
        Me.cmbcalle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbcalle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbcalle.FormattingEnabled = True
        Me.cmbcalle.Location = New System.Drawing.Point(161, 349)
        Me.cmbcalle.Name = "cmbcalle"
        Me.cmbcalle.Size = New System.Drawing.Size(329, 21)
        Me.cmbcalle.TabIndex = 11
        '
        'etiquetaid_calle
        '
        Me.etiquetaid_calle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_calle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_calle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_calle.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_calle.Location = New System.Drawing.Point(28, 349)
        Me.etiquetaid_calle.Name = "etiquetaid_calle"
        Me.etiquetaid_calle.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_calle.TabIndex = 509
        Me.etiquetaid_calle.Text = "Calle"
        Me.etiquetaid_calle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtdireccion_cliente
        '
        Me.txtdireccion_cliente.BackColor = System.Drawing.Color.White
        Me.txtdireccion_cliente.Location = New System.Drawing.Point(161, 392)
        Me.txtdireccion_cliente.MaxLength = 50
        Me.txtdireccion_cliente.Name = "txtdireccion_cliente"
        Me.txtdireccion_cliente.Size = New System.Drawing.Size(385, 20)
        Me.txtdireccion_cliente.TabIndex = 12
        '
        'etiquetadireccion_cliente
        '
        Me.etiquetadireccion_cliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetadireccion_cliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetadireccion_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetadireccion_cliente.ForeColor = System.Drawing.Color.Black
        Me.etiquetadireccion_cliente.Location = New System.Drawing.Point(28, 392)
        Me.etiquetadireccion_cliente.Name = "etiquetadireccion_cliente"
        Me.etiquetadireccion_cliente.Size = New System.Drawing.Size(127, 21)
        Me.etiquetadireccion_cliente.TabIndex = 510
        Me.etiquetadireccion_cliente.Text = "Direccion_cliente"
        Me.etiquetadireccion_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_localidad
        '
        Me.lblid_localidad.AutoSize = True
        Me.lblid_localidad.BackColor = System.Drawing.Color.Red
        Me.lblid_localidad.Location = New System.Drawing.Point(370, 435)
        Me.lblid_localidad.Name = "lblid_localidad"
        Me.lblid_localidad.Size = New System.Drawing.Size(13, 13)
        Me.lblid_localidad.TabIndex = 511
        Me.lblid_localidad.Text = "0"
        Me.lblid_localidad.Visible = False
        '
        'btnBuscalocalidad
        '
        Me.btnBuscalocalidad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscalocalidad.Image = CType(resources.GetObject("btnBuscalocalidad.Image"), System.Drawing.Image)
        Me.btnBuscalocalidad.Location = New System.Drawing.Point(505, 435)
        Me.btnBuscalocalidad.Name = "btnBuscalocalidad"
        Me.btnBuscalocalidad.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscalocalidad.TabIndex = 32
        Me.btnBuscalocalidad.UseVisualStyleBackColor = True
        '
        'cmblocalidad
        '
        Me.cmblocalidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmblocalidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmblocalidad.FormattingEnabled = True
        Me.cmblocalidad.Location = New System.Drawing.Point(161, 435)
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
        Me.etiquetaid_localidad.Location = New System.Drawing.Point(28, 435)
        Me.etiquetaid_localidad.Name = "etiquetaid_localidad"
        Me.etiquetaid_localidad.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_localidad.TabIndex = 512
        Me.etiquetaid_localidad.Text = "Localidad"
        Me.etiquetaid_localidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_provincia
        '
        Me.lblid_provincia.AutoSize = True
        Me.lblid_provincia.BackColor = System.Drawing.Color.Red
        Me.lblid_provincia.Location = New System.Drawing.Point(370, 478)
        Me.lblid_provincia.Name = "lblid_provincia"
        Me.lblid_provincia.Size = New System.Drawing.Size(13, 13)
        Me.lblid_provincia.TabIndex = 513
        Me.lblid_provincia.Text = "0"
        Me.lblid_provincia.Visible = False
        '
        'btnBuscaprovincia
        '
        Me.btnBuscaprovincia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscaprovincia.Image = CType(resources.GetObject("btnBuscaprovincia.Image"), System.Drawing.Image)
        Me.btnBuscaprovincia.Location = New System.Drawing.Point(505, 478)
        Me.btnBuscaprovincia.Name = "btnBuscaprovincia"
        Me.btnBuscaprovincia.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscaprovincia.TabIndex = 33
        Me.btnBuscaprovincia.UseVisualStyleBackColor = True
        '
        'cmbprovincia
        '
        Me.cmbprovincia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbprovincia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbprovincia.FormattingEnabled = True
        Me.cmbprovincia.Location = New System.Drawing.Point(161, 478)
        Me.cmbprovincia.Name = "cmbprovincia"
        Me.cmbprovincia.Size = New System.Drawing.Size(329, 21)
        Me.cmbprovincia.TabIndex = 14
        '
        'etiquetaid_provincia
        '
        Me.etiquetaid_provincia.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_provincia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_provincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_provincia.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_provincia.Location = New System.Drawing.Point(28, 478)
        Me.etiquetaid_provincia.Name = "etiquetaid_provincia"
        Me.etiquetaid_provincia.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_provincia.TabIndex = 514
        Me.etiquetaid_provincia.Text = "Provincia"
        Me.etiquetaid_provincia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txttelefono
        '
        Me.txttelefono.BackColor = System.Drawing.Color.White
        Me.txttelefono.Location = New System.Drawing.Point(161, 521)
        Me.txttelefono.MaxLength = 50
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(385, 20)
        Me.txttelefono.TabIndex = 15
        '
        'etiquetatelefono
        '
        Me.etiquetatelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetatelefono.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetatelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetatelefono.ForeColor = System.Drawing.Color.Black
        Me.etiquetatelefono.Location = New System.Drawing.Point(28, 521)
        Me.etiquetatelefono.Name = "etiquetatelefono"
        Me.etiquetatelefono.Size = New System.Drawing.Size(127, 21)
        Me.etiquetatelefono.TabIndex = 515
        Me.etiquetatelefono.Text = "Telefono"
        Me.etiquetatelefono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtmail
        '
        Me.txtmail.BackColor = System.Drawing.Color.White
        Me.txtmail.Location = New System.Drawing.Point(161, 564)
        Me.txtmail.MaxLength = 50
        Me.txtmail.Name = "txtmail"
        Me.txtmail.Size = New System.Drawing.Size(385, 20)
        Me.txtmail.TabIndex = 16
        '
        'etiquetamail
        '
        Me.etiquetamail.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetamail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetamail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetamail.ForeColor = System.Drawing.Color.Black
        Me.etiquetamail.Location = New System.Drawing.Point(28, 564)
        Me.etiquetamail.Name = "etiquetamail"
        Me.etiquetamail.Size = New System.Drawing.Size(127, 21)
        Me.etiquetamail.TabIndex = 516
        Me.etiquetamail.Text = "Mail"
        Me.etiquetamail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtweb
        '
        Me.txtweb.BackColor = System.Drawing.Color.White
        Me.txtweb.Location = New System.Drawing.Point(716, 48)
        Me.txtweb.MaxLength = 50
        Me.txtweb.Name = "txtweb"
        Me.txtweb.Size = New System.Drawing.Size(253, 20)
        Me.txtweb.TabIndex = 17
        '
        'etiquetaweb
        '
        Me.etiquetaweb.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaweb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaweb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaweb.ForeColor = System.Drawing.Color.Black
        Me.etiquetaweb.Location = New System.Drawing.Point(583, 48)
        Me.etiquetaweb.Name = "etiquetaweb"
        Me.etiquetaweb.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaweb.TabIndex = 517
        Me.etiquetaweb.Text = "Web"
        Me.etiquetaweb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_condicion_iva
        '
        Me.lblid_condicion_iva.AutoSize = True
        Me.lblid_condicion_iva.BackColor = System.Drawing.Color.Red
        Me.lblid_condicion_iva.Location = New System.Drawing.Point(840, 94)
        Me.lblid_condicion_iva.Name = "lblid_condicion_iva"
        Me.lblid_condicion_iva.Size = New System.Drawing.Size(13, 13)
        Me.lblid_condicion_iva.TabIndex = 518
        Me.lblid_condicion_iva.Text = "0"
        Me.lblid_condicion_iva.Visible = False
        '
        'btnBuscacondicion_iva
        '
        Me.btnBuscacondicion_iva.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscacondicion_iva.Image = CType(resources.GetObject("btnBuscacondicion_iva.Image"), System.Drawing.Image)
        Me.btnBuscacondicion_iva.Location = New System.Drawing.Point(939, 86)
        Me.btnBuscacondicion_iva.Name = "btnBuscacondicion_iva"
        Me.btnBuscacondicion_iva.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscacondicion_iva.TabIndex = 34
        Me.btnBuscacondicion_iva.UseVisualStyleBackColor = True
        '
        'cmbcondicion_iva
        '
        Me.cmbcondicion_iva.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbcondicion_iva.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbcondicion_iva.FormattingEnabled = True
        Me.cmbcondicion_iva.Location = New System.Drawing.Point(716, 88)
        Me.cmbcondicion_iva.Name = "cmbcondicion_iva"
        Me.cmbcondicion_iva.Size = New System.Drawing.Size(217, 21)
        Me.cmbcondicion_iva.TabIndex = 18
        '
        'etiquetaid_condicion_iva
        '
        Me.etiquetaid_condicion_iva.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_condicion_iva.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_condicion_iva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_condicion_iva.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_condicion_iva.Location = New System.Drawing.Point(583, 91)
        Me.etiquetaid_condicion_iva.Name = "etiquetaid_condicion_iva"
        Me.etiquetaid_condicion_iva.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_condicion_iva.TabIndex = 519
        Me.etiquetaid_condicion_iva.Text = "Condicion_iva"
        Me.etiquetaid_condicion_iva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtingreso_bruto
        '
        Me.txtingreso_bruto.BackColor = System.Drawing.Color.White
        Me.txtingreso_bruto.Location = New System.Drawing.Point(716, 134)
        Me.txtingreso_bruto.MaxLength = 50
        Me.txtingreso_bruto.Name = "txtingreso_bruto"
        Me.txtingreso_bruto.Size = New System.Drawing.Size(253, 20)
        Me.txtingreso_bruto.TabIndex = 19
        '
        'etiquetaingreso_bruto
        '
        Me.etiquetaingreso_bruto.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaingreso_bruto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaingreso_bruto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaingreso_bruto.ForeColor = System.Drawing.Color.Black
        Me.etiquetaingreso_bruto.Location = New System.Drawing.Point(583, 134)
        Me.etiquetaingreso_bruto.Name = "etiquetaingreso_bruto"
        Me.etiquetaingreso_bruto.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaingreso_bruto.TabIndex = 520
        Me.etiquetaingreso_bruto.Text = "Ingreso_bruto"
        Me.etiquetaingreso_bruto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtlugar_pago
        '
        Me.txtlugar_pago.BackColor = System.Drawing.Color.White
        Me.txtlugar_pago.Location = New System.Drawing.Point(716, 177)
        Me.txtlugar_pago.MaxLength = 50
        Me.txtlugar_pago.Name = "txtlugar_pago"
        Me.txtlugar_pago.Size = New System.Drawing.Size(253, 20)
        Me.txtlugar_pago.TabIndex = 20
        '
        'etiquetalugar_pago
        '
        Me.etiquetalugar_pago.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetalugar_pago.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetalugar_pago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetalugar_pago.ForeColor = System.Drawing.Color.Black
        Me.etiquetalugar_pago.Location = New System.Drawing.Point(583, 177)
        Me.etiquetalugar_pago.Name = "etiquetalugar_pago"
        Me.etiquetalugar_pago.Size = New System.Drawing.Size(127, 21)
        Me.etiquetalugar_pago.TabIndex = 521
        Me.etiquetalugar_pago.Text = "Lugar_pago"
        Me.etiquetalugar_pago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkpercepcion_iva
        '
        Me.chkpercepcion_iva.AutoSize = True
        Me.chkpercepcion_iva.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkpercepcion_iva.Location = New System.Drawing.Point(716, 220)
        Me.chkpercepcion_iva.Name = "chkpercepcion_iva"
        Me.chkpercepcion_iva.Size = New System.Drawing.Size(137, 21)
        Me.chkpercepcion_iva.TabIndex = 21
        Me.chkpercepcion_iva.Text = "percepcion_iva"
        '
        'etiquetapercepcion_iva
        '
        Me.etiquetapercepcion_iva.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetapercepcion_iva.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetapercepcion_iva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetapercepcion_iva.ForeColor = System.Drawing.Color.Black
        Me.etiquetapercepcion_iva.Location = New System.Drawing.Point(583, 220)
        Me.etiquetapercepcion_iva.Name = "etiquetapercepcion_iva"
        Me.etiquetapercepcion_iva.Size = New System.Drawing.Size(127, 21)
        Me.etiquetapercepcion_iva.TabIndex = 522
        Me.etiquetapercepcion_iva.Text = "Percepcion_iva"
        Me.etiquetapercepcion_iva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkpercepcion_ingreso_bruto
        '
        Me.chkpercepcion_ingreso_bruto.AutoSize = True
        Me.chkpercepcion_ingreso_bruto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkpercepcion_ingreso_bruto.Location = New System.Drawing.Point(716, 263)
        Me.chkpercepcion_ingreso_bruto.Name = "chkpercepcion_ingreso_bruto"
        Me.chkpercepcion_ingreso_bruto.Size = New System.Drawing.Size(217, 21)
        Me.chkpercepcion_ingreso_bruto.TabIndex = 22
        Me.chkpercepcion_ingreso_bruto.Text = "percepcion_ingreso_bruto"
        '
        'etiquetapercepcion_ingreso_bruto
        '
        Me.etiquetapercepcion_ingreso_bruto.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetapercepcion_ingreso_bruto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetapercepcion_ingreso_bruto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetapercepcion_ingreso_bruto.ForeColor = System.Drawing.Color.Black
        Me.etiquetapercepcion_ingreso_bruto.Location = New System.Drawing.Point(583, 263)
        Me.etiquetapercepcion_ingreso_bruto.Name = "etiquetapercepcion_ingreso_bruto"
        Me.etiquetapercepcion_ingreso_bruto.Size = New System.Drawing.Size(127, 21)
        Me.etiquetapercepcion_ingreso_bruto.TabIndex = 523
        Me.etiquetapercepcion_ingreso_bruto.Text = "Percepcion_ingreso_bruto"
        Me.etiquetapercepcion_ingreso_bruto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkretencion_iva
        '
        Me.chkretencion_iva.AutoSize = True
        Me.chkretencion_iva.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkretencion_iva.Location = New System.Drawing.Point(716, 306)
        Me.chkretencion_iva.Name = "chkretencion_iva"
        Me.chkretencion_iva.Size = New System.Drawing.Size(125, 21)
        Me.chkretencion_iva.TabIndex = 23
        Me.chkretencion_iva.Text = "retencion_iva"
        '
        'etiquetaretencion_iva
        '
        Me.etiquetaretencion_iva.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaretencion_iva.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaretencion_iva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaretencion_iva.ForeColor = System.Drawing.Color.Black
        Me.etiquetaretencion_iva.Location = New System.Drawing.Point(583, 306)
        Me.etiquetaretencion_iva.Name = "etiquetaretencion_iva"
        Me.etiquetaretencion_iva.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaretencion_iva.TabIndex = 524
        Me.etiquetaretencion_iva.Text = "Retencion_iva"
        Me.etiquetaretencion_iva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkretencion_ingreso_bruto
        '
        Me.chkretencion_ingreso_bruto.AutoSize = True
        Me.chkretencion_ingreso_bruto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkretencion_ingreso_bruto.Location = New System.Drawing.Point(716, 349)
        Me.chkretencion_ingreso_bruto.Name = "chkretencion_ingreso_bruto"
        Me.chkretencion_ingreso_bruto.Size = New System.Drawing.Size(205, 21)
        Me.chkretencion_ingreso_bruto.TabIndex = 24
        Me.chkretencion_ingreso_bruto.Text = "retencion_ingreso_bruto"
        '
        'etiquetaretencion_ingreso_bruto
        '
        Me.etiquetaretencion_ingreso_bruto.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaretencion_ingreso_bruto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaretencion_ingreso_bruto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaretencion_ingreso_bruto.ForeColor = System.Drawing.Color.Black
        Me.etiquetaretencion_ingreso_bruto.Location = New System.Drawing.Point(583, 349)
        Me.etiquetaretencion_ingreso_bruto.Name = "etiquetaretencion_ingreso_bruto"
        Me.etiquetaretencion_ingreso_bruto.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaretencion_ingreso_bruto.TabIndex = 525
        Me.etiquetaretencion_ingreso_bruto.Text = "Retencion_ingreso_bruto"
        Me.etiquetaretencion_ingreso_bruto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtnumero_proveedor
        '
        Me.txtnumero_proveedor.BackColor = System.Drawing.Color.White
        Me.txtnumero_proveedor.Location = New System.Drawing.Point(716, 392)
        Me.txtnumero_proveedor.MaxLength = 50
        Me.txtnumero_proveedor.Name = "txtnumero_proveedor"
        Me.txtnumero_proveedor.Size = New System.Drawing.Size(253, 20)
        Me.txtnumero_proveedor.TabIndex = 25
        '
        'etiquetanumero_proveedor
        '
        Me.etiquetanumero_proveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetanumero_proveedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetanumero_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetanumero_proveedor.ForeColor = System.Drawing.Color.Black
        Me.etiquetanumero_proveedor.Location = New System.Drawing.Point(583, 392)
        Me.etiquetanumero_proveedor.Name = "etiquetanumero_proveedor"
        Me.etiquetanumero_proveedor.Size = New System.Drawing.Size(127, 21)
        Me.etiquetanumero_proveedor.TabIndex = 526
        Me.etiquetanumero_proveedor.Text = "Numero_proveedor"
        Me.etiquetanumero_proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmDetalleCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 741)
        Me.Controls.Add(Me.txtnombre_cliente)
        Me.Controls.Add(Me.etiquetanombre_cliente)
        Me.Controls.Add(Me.txtapellido_cliente)
        Me.Controls.Add(Me.etiquetaapellido_cliente)
        Me.Controls.Add(Me.txtrazon_social)
        Me.Controls.Add(Me.etiquetarazon_social)
        Me.Controls.Add(Me.txtnombre_fantasia)
        Me.Controls.Add(Me.etiquetanombre_fantasia)
        Me.Controls.Add(Me.txtcontacto)
        Me.Controls.Add(Me.etiquetacontacto)
        Me.Controls.Add(Me.txtdni_cliente)
        Me.Controls.Add(Me.etiquetadni_cliente)
        Me.Controls.Add(Me.lblid_tipo_dni)
        Me.Controls.Add(Me.btnBuscatipo_dni)
        Me.Controls.Add(Me.cmbtipo_dni)
        Me.Controls.Add(Me.etiquetaid_tipo_dni)
        Me.Controls.Add(Me.lblid_calle)
        Me.Controls.Add(Me.btnBuscacalle)
        Me.Controls.Add(Me.cmbcalle)
        Me.Controls.Add(Me.etiquetaid_calle)
        Me.Controls.Add(Me.txtdireccion_cliente)
        Me.Controls.Add(Me.etiquetadireccion_cliente)
        Me.Controls.Add(Me.lblid_localidad)
        Me.Controls.Add(Me.btnBuscalocalidad)
        Me.Controls.Add(Me.cmblocalidad)
        Me.Controls.Add(Me.etiquetaid_localidad)
        Me.Controls.Add(Me.lblid_provincia)
        Me.Controls.Add(Me.btnBuscaprovincia)
        Me.Controls.Add(Me.cmbprovincia)
        Me.Controls.Add(Me.etiquetaid_provincia)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.etiquetatelefono)
        Me.Controls.Add(Me.txtmail)
        Me.Controls.Add(Me.etiquetamail)
        Me.Controls.Add(Me.txtweb)
        Me.Controls.Add(Me.etiquetaweb)
        Me.Controls.Add(Me.lblid_condicion_iva)
        Me.Controls.Add(Me.btnBuscacondicion_iva)
        Me.Controls.Add(Me.cmbcondicion_iva)
        Me.Controls.Add(Me.etiquetaid_condicion_iva)
        Me.Controls.Add(Me.txtingreso_bruto)
        Me.Controls.Add(Me.etiquetaingreso_bruto)
        Me.Controls.Add(Me.txtlugar_pago)
        Me.Controls.Add(Me.etiquetalugar_pago)
        Me.Controls.Add(Me.chkpercepcion_iva)
        Me.Controls.Add(Me.etiquetapercepcion_iva)
        Me.Controls.Add(Me.chkpercepcion_ingreso_bruto)
        Me.Controls.Add(Me.etiquetapercepcion_ingreso_bruto)
        Me.Controls.Add(Me.chkretencion_iva)
        Me.Controls.Add(Me.etiquetaretencion_iva)
        Me.Controls.Add(Me.chkretencion_ingreso_bruto)
        Me.Controls.Add(Me.etiquetaretencion_ingreso_bruto)
        Me.Controls.Add(Me.txtnumero_proveedor)
        Me.Controls.Add(Me.etiquetanumero_proveedor)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDetalleCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetalleCliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Protected WithEvents txtnombre_cliente As System.Windows.Forms.TextBox
   Friend WithEvents etiquetanombre_cliente As System.Windows.Forms.Label
   Protected WithEvents txtapellido_cliente As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaapellido_cliente As System.Windows.Forms.Label
   Protected WithEvents txtrazon_social As System.Windows.Forms.TextBox
   Friend WithEvents etiquetarazon_social As System.Windows.Forms.Label
   Protected WithEvents txtnombre_fantasia As System.Windows.Forms.TextBox
   Friend WithEvents etiquetanombre_fantasia As System.Windows.Forms.Label
   Protected WithEvents txtcontacto As System.Windows.Forms.TextBox
   Friend WithEvents etiquetacontacto As System.Windows.Forms.Label
   Protected WithEvents txtdni_cliente As System.Windows.Forms.TextBox
   Friend WithEvents etiquetadni_cliente As System.Windows.Forms.Label
   Friend WithEvents lblid_tipo_dni As System.Windows.Forms.Label
   Friend WithEvents btnBuscatipo_dni As System.Windows.Forms.Button
   Friend WithEvents cmbtipo_dni As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_tipo_dni As System.Windows.Forms.Label
   Friend WithEvents lblid_calle As System.Windows.Forms.Label
   Friend WithEvents btnBuscacalle As System.Windows.Forms.Button
   Friend WithEvents cmbcalle As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_calle As System.Windows.Forms.Label
   Protected WithEvents txtdireccion_cliente As System.Windows.Forms.TextBox
   Friend WithEvents etiquetadireccion_cliente As System.Windows.Forms.Label
   Friend WithEvents lblid_localidad As System.Windows.Forms.Label
   Friend WithEvents btnBuscalocalidad As System.Windows.Forms.Button
   Friend WithEvents cmblocalidad As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_localidad As System.Windows.Forms.Label
   Friend WithEvents lblid_provincia As System.Windows.Forms.Label
   Friend WithEvents btnBuscaprovincia As System.Windows.Forms.Button
   Friend WithEvents cmbprovincia As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_provincia As System.Windows.Forms.Label
   Protected WithEvents txttelefono As System.Windows.Forms.TextBox
   Friend WithEvents etiquetatelefono As System.Windows.Forms.Label
   Protected WithEvents txtmail As System.Windows.Forms.TextBox
   Friend WithEvents etiquetamail As System.Windows.Forms.Label
   Protected WithEvents txtweb As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaweb As System.Windows.Forms.Label
   Friend WithEvents lblid_condicion_iva As System.Windows.Forms.Label
   Friend WithEvents btnBuscacondicion_iva As System.Windows.Forms.Button
   Friend WithEvents cmbcondicion_iva As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_condicion_iva As System.Windows.Forms.Label
   Protected WithEvents txtingreso_bruto As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaingreso_bruto As System.Windows.Forms.Label
   Protected WithEvents txtlugar_pago As System.Windows.Forms.TextBox
   Friend WithEvents etiquetalugar_pago As System.Windows.Forms.Label
   Protected WithEvents chkpercepcion_iva As System.Windows.Forms.CheckBox
   Friend WithEvents etiquetapercepcion_iva As System.Windows.Forms.Label
   Protected WithEvents chkpercepcion_ingreso_bruto As System.Windows.Forms.CheckBox
   Friend WithEvents etiquetapercepcion_ingreso_bruto As System.Windows.Forms.Label
   Protected WithEvents chkretencion_iva As System.Windows.Forms.CheckBox
   Friend WithEvents etiquetaretencion_iva As System.Windows.Forms.Label
   Protected WithEvents chkretencion_ingreso_bruto As System.Windows.Forms.CheckBox
   Friend WithEvents etiquetaretencion_ingreso_bruto As System.Windows.Forms.Label
   Protected WithEvents txtnumero_proveedor As System.Windows.Forms.TextBox
   Friend WithEvents etiquetanumero_proveedor As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
End Class

