<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleBanco
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleBanco))
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtnombre_banco = New System.Windows.Forms.TextBox
        Me.etiquetanombre_banco = New System.Windows.Forms.Label
        Me.txtcuit_banco = New System.Windows.Forms.TextBox
        Me.etiquetacuit_banco = New System.Windows.Forms.Label
        Me.txtdireccion = New System.Windows.Forms.TextBox
        Me.etiquetadireccion = New System.Windows.Forms.Label
        Me.txttelefono = New System.Windows.Forms.TextBox
        Me.etiquetatelefono = New System.Windows.Forms.Label
        Me.txtemail = New System.Windows.Forms.TextBox
        Me.etiquetaemail = New System.Windows.Forms.Label
        Me.txtpagina_web = New System.Windows.Forms.TextBox
        Me.etiquetapagina_web = New System.Windows.Forms.Label
        Me.txtnombre_fantasia = New System.Windows.Forms.TextBox
        Me.etiquetanombre_fantasia = New System.Windows.Forms.Label
        Me.lblid_calle = New System.Windows.Forms.Label
        Me.btnBuscacalle = New System.Windows.Forms.Button
        Me.cmbcalle = New System.Windows.Forms.ComboBox
        Me.etiquetaid_calle = New System.Windows.Forms.Label
        Me.txtnumero = New System.Windows.Forms.TextBox
        Me.etiquetanumero = New System.Windows.Forms.Label
        Me.lblid_localidad = New System.Windows.Forms.Label
        Me.btnBuscalocalidad = New System.Windows.Forms.Button
        Me.cmblocalidad = New System.Windows.Forms.ComboBox
        Me.etiquetaid_localidad = New System.Windows.Forms.Label
        Me.lblid_provincia = New System.Windows.Forms.Label
        Me.btnBuscaprovincia = New System.Windows.Forms.Button
        Me.cmbprovincia = New System.Windows.Forms.ComboBox
        Me.etiquetaid_provincia = New System.Windows.Forms.Label
        Me.txtiva = New System.Windows.Forms.TextBox
        Me.etiquetaiva = New System.Windows.Forms.Label
        Me.txtingreso_bruto = New System.Windows.Forms.TextBox
        Me.etiquetaingreso_bruto = New System.Windows.Forms.Label
        Me.txtcontacto = New System.Windows.Forms.TextBox
        Me.etiquetacontacto = New System.Windows.Forms.Label
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
        Me.btnSalir.Location = New System.Drawing.Point(465, 661)
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
        Me.btnGuardar.Location = New System.Drawing.Point(355, 661)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(78, 69)
        Me.btnGuardar.TabIndex = 20
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(12, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(561, 622)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtnombre_banco
        '
        Me.txtnombre_banco.BackColor = System.Drawing.Color.White
        Me.txtnombre_banco.Location = New System.Drawing.Point(161, 48)
        Me.txtnombre_banco.MaxLength = 50
        Me.txtnombre_banco.Name = "txtnombre_banco"
        Me.txtnombre_banco.Size = New System.Drawing.Size(385, 20)
        Me.txtnombre_banco.TabIndex = 4
        '
        'etiquetanombre_banco
        '
        Me.etiquetanombre_banco.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetanombre_banco.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetanombre_banco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetanombre_banco.ForeColor = System.Drawing.Color.Black
        Me.etiquetanombre_banco.Location = New System.Drawing.Point(28, 48)
        Me.etiquetanombre_banco.Name = "etiquetanombre_banco"
        Me.etiquetanombre_banco.Size = New System.Drawing.Size(127, 21)
        Me.etiquetanombre_banco.TabIndex = 500
        Me.etiquetanombre_banco.Text = "Nombre_banco"
        Me.etiquetanombre_banco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcuit_banco
        '
        Me.txtcuit_banco.BackColor = System.Drawing.Color.White
        Me.txtcuit_banco.Location = New System.Drawing.Point(161, 91)
        Me.txtcuit_banco.MaxLength = 50
        Me.txtcuit_banco.Name = "txtcuit_banco"
        Me.txtcuit_banco.Size = New System.Drawing.Size(385, 20)
        Me.txtcuit_banco.TabIndex = 5
        '
        'etiquetacuit_banco
        '
        Me.etiquetacuit_banco.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetacuit_banco.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetacuit_banco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetacuit_banco.ForeColor = System.Drawing.Color.Black
        Me.etiquetacuit_banco.Location = New System.Drawing.Point(28, 91)
        Me.etiquetacuit_banco.Name = "etiquetacuit_banco"
        Me.etiquetacuit_banco.Size = New System.Drawing.Size(127, 21)
        Me.etiquetacuit_banco.TabIndex = 501
        Me.etiquetacuit_banco.Text = "Cuit_banco"
        Me.etiquetacuit_banco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtdireccion
        '
        Me.txtdireccion.BackColor = System.Drawing.Color.White
        Me.txtdireccion.Location = New System.Drawing.Point(161, 134)
        Me.txtdireccion.MaxLength = 50
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(385, 20)
        Me.txtdireccion.TabIndex = 6
        '
        'etiquetadireccion
        '
        Me.etiquetadireccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetadireccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetadireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetadireccion.ForeColor = System.Drawing.Color.Black
        Me.etiquetadireccion.Location = New System.Drawing.Point(28, 134)
        Me.etiquetadireccion.Name = "etiquetadireccion"
        Me.etiquetadireccion.Size = New System.Drawing.Size(127, 21)
        Me.etiquetadireccion.TabIndex = 502
        Me.etiquetadireccion.Text = "Direccion"
        Me.etiquetadireccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txttelefono
        '
        Me.txttelefono.BackColor = System.Drawing.Color.White
        Me.txttelefono.Location = New System.Drawing.Point(161, 177)
        Me.txttelefono.MaxLength = 50
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(385, 20)
        Me.txttelefono.TabIndex = 7
        '
        'etiquetatelefono
        '
        Me.etiquetatelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetatelefono.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetatelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetatelefono.ForeColor = System.Drawing.Color.Black
        Me.etiquetatelefono.Location = New System.Drawing.Point(28, 177)
        Me.etiquetatelefono.Name = "etiquetatelefono"
        Me.etiquetatelefono.Size = New System.Drawing.Size(127, 21)
        Me.etiquetatelefono.TabIndex = 503
        Me.etiquetatelefono.Text = "Telefono"
        Me.etiquetatelefono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtemail
        '
        Me.txtemail.BackColor = System.Drawing.Color.White
        Me.txtemail.Location = New System.Drawing.Point(161, 220)
        Me.txtemail.MaxLength = 50
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(385, 20)
        Me.txtemail.TabIndex = 8
        '
        'etiquetaemail
        '
        Me.etiquetaemail.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaemail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaemail.ForeColor = System.Drawing.Color.Black
        Me.etiquetaemail.Location = New System.Drawing.Point(28, 220)
        Me.etiquetaemail.Name = "etiquetaemail"
        Me.etiquetaemail.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaemail.TabIndex = 504
        Me.etiquetaemail.Text = "Email"
        Me.etiquetaemail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtpagina_web
        '
        Me.txtpagina_web.BackColor = System.Drawing.Color.White
        Me.txtpagina_web.Location = New System.Drawing.Point(161, 263)
        Me.txtpagina_web.MaxLength = 50
        Me.txtpagina_web.Name = "txtpagina_web"
        Me.txtpagina_web.Size = New System.Drawing.Size(385, 20)
        Me.txtpagina_web.TabIndex = 9
        '
        'etiquetapagina_web
        '
        Me.etiquetapagina_web.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetapagina_web.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetapagina_web.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetapagina_web.ForeColor = System.Drawing.Color.Black
        Me.etiquetapagina_web.Location = New System.Drawing.Point(28, 263)
        Me.etiquetapagina_web.Name = "etiquetapagina_web"
        Me.etiquetapagina_web.Size = New System.Drawing.Size(127, 21)
        Me.etiquetapagina_web.TabIndex = 505
        Me.etiquetapagina_web.Text = "Pagina_web"
        Me.etiquetapagina_web.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtnombre_fantasia
        '
        Me.txtnombre_fantasia.BackColor = System.Drawing.Color.White
        Me.txtnombre_fantasia.Location = New System.Drawing.Point(161, 306)
        Me.txtnombre_fantasia.MaxLength = 50
        Me.txtnombre_fantasia.Name = "txtnombre_fantasia"
        Me.txtnombre_fantasia.Size = New System.Drawing.Size(385, 20)
        Me.txtnombre_fantasia.TabIndex = 10
        '
        'etiquetanombre_fantasia
        '
        Me.etiquetanombre_fantasia.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetanombre_fantasia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetanombre_fantasia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetanombre_fantasia.ForeColor = System.Drawing.Color.Black
        Me.etiquetanombre_fantasia.Location = New System.Drawing.Point(28, 306)
        Me.etiquetanombre_fantasia.Name = "etiquetanombre_fantasia"
        Me.etiquetanombre_fantasia.Size = New System.Drawing.Size(127, 21)
        Me.etiquetanombre_fantasia.TabIndex = 506
        Me.etiquetanombre_fantasia.Text = "Nombre_fantasia"
        Me.etiquetanombre_fantasia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_calle
        '
        Me.lblid_calle.AutoSize = True
        Me.lblid_calle.BackColor = System.Drawing.Color.Red
        Me.lblid_calle.Location = New System.Drawing.Point(370, 349)
        Me.lblid_calle.Name = "lblid_calle"
        Me.lblid_calle.Size = New System.Drawing.Size(13, 13)
        Me.lblid_calle.TabIndex = 507
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
        Me.btnBuscacalle.TabIndex = 30
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
        Me.etiquetaid_calle.TabIndex = 508
        Me.etiquetaid_calle.Text = "Calle"
        Me.etiquetaid_calle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtnumero
        '
        Me.txtnumero.BackColor = System.Drawing.Color.White
        Me.txtnumero.Location = New System.Drawing.Point(161, 392)
        Me.txtnumero.MaxLength = 50
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(385, 20)
        Me.txtnumero.TabIndex = 12
        '
        'etiquetanumero
        '
        Me.etiquetanumero.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetanumero.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetanumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetanumero.ForeColor = System.Drawing.Color.Black
        Me.etiquetanumero.Location = New System.Drawing.Point(28, 392)
        Me.etiquetanumero.Name = "etiquetanumero"
        Me.etiquetanumero.Size = New System.Drawing.Size(127, 21)
        Me.etiquetanumero.TabIndex = 509
        Me.etiquetanumero.Text = "Numero"
        Me.etiquetanumero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_localidad
        '
        Me.lblid_localidad.AutoSize = True
        Me.lblid_localidad.BackColor = System.Drawing.Color.Red
        Me.lblid_localidad.Location = New System.Drawing.Point(370, 435)
        Me.lblid_localidad.Name = "lblid_localidad"
        Me.lblid_localidad.Size = New System.Drawing.Size(13, 13)
        Me.lblid_localidad.TabIndex = 510
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
        Me.btnBuscalocalidad.TabIndex = 31
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
        Me.etiquetaid_localidad.TabIndex = 511
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
        Me.lblid_provincia.TabIndex = 512
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
        Me.btnBuscaprovincia.TabIndex = 32
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
        Me.etiquetaid_provincia.TabIndex = 513
        Me.etiquetaid_provincia.Text = "Provincia"
        Me.etiquetaid_provincia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtiva
        '
        Me.txtiva.BackColor = System.Drawing.Color.White
        Me.txtiva.Location = New System.Drawing.Point(161, 521)
        Me.txtiva.MaxLength = 50
        Me.txtiva.Name = "txtiva"
        Me.txtiva.Size = New System.Drawing.Size(385, 20)
        Me.txtiva.TabIndex = 15
        '
        'etiquetaiva
        '
        Me.etiquetaiva.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaiva.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaiva.ForeColor = System.Drawing.Color.Black
        Me.etiquetaiva.Location = New System.Drawing.Point(28, 521)
        Me.etiquetaiva.Name = "etiquetaiva"
        Me.etiquetaiva.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaiva.TabIndex = 514
        Me.etiquetaiva.Text = "Iva"
        Me.etiquetaiva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtingreso_bruto
        '
        Me.txtingreso_bruto.BackColor = System.Drawing.Color.White
        Me.txtingreso_bruto.Location = New System.Drawing.Point(161, 564)
        Me.txtingreso_bruto.MaxLength = 50
        Me.txtingreso_bruto.Name = "txtingreso_bruto"
        Me.txtingreso_bruto.Size = New System.Drawing.Size(385, 20)
        Me.txtingreso_bruto.TabIndex = 16
        '
        'etiquetaingreso_bruto
        '
        Me.etiquetaingreso_bruto.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaingreso_bruto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaingreso_bruto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaingreso_bruto.ForeColor = System.Drawing.Color.Black
        Me.etiquetaingreso_bruto.Location = New System.Drawing.Point(28, 564)
        Me.etiquetaingreso_bruto.Name = "etiquetaingreso_bruto"
        Me.etiquetaingreso_bruto.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaingreso_bruto.TabIndex = 515
        Me.etiquetaingreso_bruto.Text = "Ingreso_bruto"
        Me.etiquetaingreso_bruto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcontacto
        '
        Me.txtcontacto.BackColor = System.Drawing.Color.White
        Me.txtcontacto.Location = New System.Drawing.Point(161, 604)
        Me.txtcontacto.MaxLength = 50
        Me.txtcontacto.Name = "txtcontacto"
        Me.txtcontacto.Size = New System.Drawing.Size(385, 20)
        Me.txtcontacto.TabIndex = 17
        '
        'etiquetacontacto
        '
        Me.etiquetacontacto.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetacontacto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetacontacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetacontacto.ForeColor = System.Drawing.Color.Black
        Me.etiquetacontacto.Location = New System.Drawing.Point(28, 604)
        Me.etiquetacontacto.Name = "etiquetacontacto"
        Me.etiquetacontacto.Size = New System.Drawing.Size(127, 21)
        Me.etiquetacontacto.TabIndex = 516
        Me.etiquetacontacto.Text = "Contacto"
        Me.etiquetacontacto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmDetalleBanco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 768)
        Me.Controls.Add(Me.txtnombre_banco)
        Me.Controls.Add(Me.etiquetanombre_banco)
        Me.Controls.Add(Me.txtcuit_banco)
        Me.Controls.Add(Me.etiquetacuit_banco)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.etiquetadireccion)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.etiquetatelefono)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.etiquetaemail)
        Me.Controls.Add(Me.txtpagina_web)
        Me.Controls.Add(Me.etiquetapagina_web)
        Me.Controls.Add(Me.txtnombre_fantasia)
        Me.Controls.Add(Me.etiquetanombre_fantasia)
        Me.Controls.Add(Me.lblid_calle)
        Me.Controls.Add(Me.btnBuscacalle)
        Me.Controls.Add(Me.cmbcalle)
        Me.Controls.Add(Me.etiquetaid_calle)
        Me.Controls.Add(Me.txtnumero)
        Me.Controls.Add(Me.etiquetanumero)
        Me.Controls.Add(Me.lblid_localidad)
        Me.Controls.Add(Me.btnBuscalocalidad)
        Me.Controls.Add(Me.cmblocalidad)
        Me.Controls.Add(Me.etiquetaid_localidad)
        Me.Controls.Add(Me.lblid_provincia)
        Me.Controls.Add(Me.btnBuscaprovincia)
        Me.Controls.Add(Me.cmbprovincia)
        Me.Controls.Add(Me.etiquetaid_provincia)
        Me.Controls.Add(Me.txtiva)
        Me.Controls.Add(Me.etiquetaiva)
        Me.Controls.Add(Me.txtingreso_bruto)
        Me.Controls.Add(Me.etiquetaingreso_bruto)
        Me.Controls.Add(Me.txtcontacto)
        Me.Controls.Add(Me.etiquetacontacto)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDetalleBanco"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetalleBanco" & vgNombreFormulario
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Protected WithEvents txtnombre_banco As System.Windows.Forms.TextBox
   Friend WithEvents etiquetanombre_banco As System.Windows.Forms.Label
   Protected WithEvents txtcuit_banco As System.Windows.Forms.TextBox
   Friend WithEvents etiquetacuit_banco As System.Windows.Forms.Label
   Protected WithEvents txtdireccion As System.Windows.Forms.TextBox
   Friend WithEvents etiquetadireccion As System.Windows.Forms.Label
   Protected WithEvents txttelefono As System.Windows.Forms.TextBox
   Friend WithEvents etiquetatelefono As System.Windows.Forms.Label
   Protected WithEvents txtemail As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaemail As System.Windows.Forms.Label
   Protected WithEvents txtpagina_web As System.Windows.Forms.TextBox
   Friend WithEvents etiquetapagina_web As System.Windows.Forms.Label
   Protected WithEvents txtnombre_fantasia As System.Windows.Forms.TextBox
   Friend WithEvents etiquetanombre_fantasia As System.Windows.Forms.Label
   Friend WithEvents lblid_calle As System.Windows.Forms.Label
   Friend WithEvents btnBuscacalle As System.Windows.Forms.Button
   Friend WithEvents cmbcalle As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_calle As System.Windows.Forms.Label
   Protected WithEvents txtnumero As System.Windows.Forms.TextBox
   Friend WithEvents etiquetanumero As System.Windows.Forms.Label
   Friend WithEvents lblid_localidad As System.Windows.Forms.Label
   Friend WithEvents btnBuscalocalidad As System.Windows.Forms.Button
   Friend WithEvents cmblocalidad As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_localidad As System.Windows.Forms.Label
   Friend WithEvents lblid_provincia As System.Windows.Forms.Label
   Friend WithEvents btnBuscaprovincia As System.Windows.Forms.Button
   Friend WithEvents cmbprovincia As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_provincia As System.Windows.Forms.Label
   Protected WithEvents txtiva As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaiva As System.Windows.Forms.Label
   Protected WithEvents txtingreso_bruto As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaingreso_bruto As System.Windows.Forms.Label
   Protected WithEvents txtcontacto As System.Windows.Forms.TextBox
   Friend WithEvents etiquetacontacto As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
End Class

