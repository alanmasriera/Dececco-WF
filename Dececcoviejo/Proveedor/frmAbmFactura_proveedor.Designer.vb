<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbmFactura_proveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbmFactura_proveedor))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnAyuda = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.lblid_pk = New System.Windows.Forms.Label()
        Me.lblid_pk2 = New System.Windows.Forms.Label()
        Me.dgv2 = New System.Windows.Forms.DataGridView()
        Me.dtpPeriodo = New System.Windows.Forms.DateTimePicker()
        Me.etiquetaid_tipo_comprobante = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBuscaProveedor = New System.Windows.Forms.Button()
        Me.lblid_proveedor = New System.Windows.Forms.Label()
        Me.cmbProveedor = New System.Windows.Forms.ComboBox()
        Me.rbnSin = New System.Windows.Forms.RadioButton()
        Me.rbnCon = New System.Windows.Forms.RadioButton()
        Me.rbnTodo = New System.Windows.Forms.RadioButton()
        Me.btnBorrarND = New System.Windows.Forms.Button()
        Me.btnModificarND = New System.Windows.Forms.Button()
        Me.btnAgregarND = New System.Windows.Forms.Button()
        Me.txtTotalFactura = New System.Windows.Forms.TextBox()
        Me.etiquetaprecio = New System.Windows.Forms.Label()
        Me.txtTotalND = New System.Windows.Forms.TextBox()
        Me.etiquetaalicuota = New System.Windows.Forms.Label()
        Me.txtTotalAbonar = New System.Windows.Forms.TextBox()
        Me.etiquetaiva = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBuscaEmpresa = New System.Windows.Forms.Button()
        Me.lblid_empresa = New System.Windows.Forms.Label()
        Me.cmbEmpresa = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblid_almacen = New System.Windows.Forms.Label()
        Me.cmbAlmacen = New System.Windows.Forms.ComboBox()
        Me.lblEstado_libro = New System.Windows.Forms.Label()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAyuda
        '
        Me.btnAyuda.BackColor = System.Drawing.Color.Gainsboro
        Me.btnAyuda.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAyuda.ForeColor = System.Drawing.Color.Black
        Me.btnAyuda.Image = CType(resources.GetObject("btnAyuda.Image"), System.Drawing.Image)
        Me.btnAyuda.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAyuda.Location = New System.Drawing.Point(853, 685)
        Me.btnAyuda.Name = "btnAyuda"
        Me.btnAyuda.Size = New System.Drawing.Size(49, 24)
        Me.btnAyuda.TabIndex = 11
        Me.btnAyuda.Text = "A&yuda"
        Me.btnAyuda.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAyuda.UseVisualStyleBackColor = True
        Me.btnAyuda.Visible = False
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(928, 685)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(73, 24)
        Me.btnSalir.TabIndex = 12
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar.Image = CType(resources.GetObject("btnBorrar.Image"), System.Drawing.Image)
        Me.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBorrar.Location = New System.Drawing.Point(283, 678)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(99, 28)
        Me.btnBorrar.TabIndex = 10
        Me.btnBorrar.Text = "&Borrar"
        Me.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(151, 678)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(99, 28)
        Me.btnModificar.TabIndex = 9
        Me.btnModificar.Text = "&Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(19, 678)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(99, 28)
        Me.btnAgregar.TabIndex = 8
        Me.btnAgregar.Text = "&Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTitulo.Font = New System.Drawing.Font("Times New Roman", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.Red
        Me.lblTitulo.Location = New System.Drawing.Point(662, 40)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(311, 30)
        Me.lblTitulo.TabIndex = 566
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToResizeColumns = False
        Me.dgv1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Brown
        Me.dgv1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv1.BackgroundColor = System.Drawing.Color.Silver
        Me.dgv1.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Beige
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Brown
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv1.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv1.GridColor = System.Drawing.Color.MediumPurple
        Me.dgv1.Location = New System.Drawing.Point(15, 149)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.ShowCellErrors = False
        Me.dgv1.ShowRowErrors = False
        Me.dgv1.Size = New System.Drawing.Size(986, 523)
        Me.dgv1.StandardTab = True
        Me.dgv1.TabIndex = 562
        '
        'lblid_pk
        '
        Me.lblid_pk.AutoSize = True
        Me.lblid_pk.BackColor = System.Drawing.Color.Red
        Me.lblid_pk.Location = New System.Drawing.Point(21, 165)
        Me.lblid_pk.Name = "lblid_pk"
        Me.lblid_pk.Size = New System.Drawing.Size(13, 13)
        Me.lblid_pk.TabIndex = 565
        Me.lblid_pk.Text = "0"
        Me.lblid_pk.Visible = False
        '
        'lblid_pk2
        '
        Me.lblid_pk2.AutoSize = True
        Me.lblid_pk2.BackColor = System.Drawing.Color.Red
        Me.lblid_pk2.Location = New System.Drawing.Point(21, 437)
        Me.lblid_pk2.Name = "lblid_pk2"
        Me.lblid_pk2.Size = New System.Drawing.Size(13, 13)
        Me.lblid_pk2.TabIndex = 569
        Me.lblid_pk2.Text = "0"
        Me.lblid_pk2.Visible = False
        '
        'dgv2
        '
        Me.dgv2.AllowUserToAddRows = False
        Me.dgv2.AllowUserToResizeColumns = False
        Me.dgv2.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Brown
        Me.dgv2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv2.BackgroundColor = System.Drawing.Color.Silver
        Me.dgv2.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Beige
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Brown
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv2.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgv2.GridColor = System.Drawing.Color.MediumPurple
        Me.dgv2.Location = New System.Drawing.Point(15, 424)
        Me.dgv2.Name = "dgv2"
        Me.dgv2.ReadOnly = True
        Me.dgv2.ShowCellErrors = False
        Me.dgv2.ShowRowErrors = False
        Me.dgv2.Size = New System.Drawing.Size(986, 192)
        Me.dgv2.StandardTab = True
        Me.dgv2.TabIndex = 568
        '
        'dtpPeriodo
        '
        Me.dtpPeriodo.CustomFormat = "MMMM - yyyy     -dd"
        Me.dtpPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPeriodo.Location = New System.Drawing.Point(90, 81)
        Me.dtpPeriodo.Name = "dtpPeriodo"
        Me.dtpPeriodo.ShowUpDown = True
        Me.dtpPeriodo.Size = New System.Drawing.Size(140, 22)
        Me.dtpPeriodo.TabIndex = 604
        '
        'etiquetaid_tipo_comprobante
        '
        Me.etiquetaid_tipo_comprobante.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_tipo_comprobante.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_tipo_comprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_tipo_comprobante.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_tipo_comprobante.Location = New System.Drawing.Point(12, 48)
        Me.etiquetaid_tipo_comprobante.Name = "etiquetaid_tipo_comprobante"
        Me.etiquetaid_tipo_comprobante.Size = New System.Drawing.Size(72, 21)
        Me.etiquetaid_tipo_comprobante.TabIndex = 765
        Me.etiquetaid_tipo_comprobante.Text = "Proveedor"
        Me.etiquetaid_tipo_comprobante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 21)
        Me.Label1.TabIndex = 766
        Me.Label1.Text = "Periodo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnBuscaProveedor
        '
        Me.btnBuscaProveedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscaProveedor.Image = CType(resources.GetObject("btnBuscaProveedor.Image"), System.Drawing.Image)
        Me.btnBuscaProveedor.Location = New System.Drawing.Point(591, 48)
        Me.btnBuscaProveedor.Name = "btnBuscaProveedor"
        Me.btnBuscaProveedor.Size = New System.Drawing.Size(27, 21)
        Me.btnBuscaProveedor.TabIndex = 769
        Me.btnBuscaProveedor.UseVisualStyleBackColor = True
        '
        'lblid_proveedor
        '
        Me.lblid_proveedor.AutoSize = True
        Me.lblid_proveedor.BackColor = System.Drawing.Color.Red
        Me.lblid_proveedor.Location = New System.Drawing.Point(110, 51)
        Me.lblid_proveedor.Name = "lblid_proveedor"
        Me.lblid_proveedor.Size = New System.Drawing.Size(13, 13)
        Me.lblid_proveedor.TabIndex = 768
        Me.lblid_proveedor.Text = "0"
        Me.lblid_proveedor.Visible = False
        '
        'cmbProveedor
        '
        Me.cmbProveedor.FormattingEnabled = True
        Me.cmbProveedor.Location = New System.Drawing.Point(90, 48)
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.Size = New System.Drawing.Size(490, 21)
        Me.cmbProveedor.TabIndex = 767
        '
        'rbnSin
        '
        Me.rbnSin.AutoSize = True
        Me.rbnSin.Checked = True
        Me.rbnSin.Location = New System.Drawing.Point(262, 86)
        Me.rbnSin.Name = "rbnSin"
        Me.rbnSin.Size = New System.Drawing.Size(62, 17)
        Me.rbnSin.TabIndex = 770
        Me.rbnSin.TabStop = True
        Me.rbnSin.Text = "Sin tilde"
        Me.rbnSin.UseVisualStyleBackColor = True
        '
        'rbnCon
        '
        Me.rbnCon.AutoSize = True
        Me.rbnCon.Location = New System.Drawing.Point(349, 86)
        Me.rbnCon.Name = "rbnCon"
        Me.rbnCon.Size = New System.Drawing.Size(66, 17)
        Me.rbnCon.TabIndex = 771
        Me.rbnCon.Text = "Con tilde"
        Me.rbnCon.UseVisualStyleBackColor = True
        '
        'rbnTodo
        '
        Me.rbnTodo.AutoSize = True
        Me.rbnTodo.Location = New System.Drawing.Point(432, 86)
        Me.rbnTodo.Name = "rbnTodo"
        Me.rbnTodo.Size = New System.Drawing.Size(55, 17)
        Me.rbnTodo.TabIndex = 772
        Me.rbnTodo.Text = "Todas"
        Me.rbnTodo.UseVisualStyleBackColor = True
        '
        'btnBorrarND
        '
        Me.btnBorrarND.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrarND.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarND.Image = CType(resources.GetObject("btnBorrarND.Image"), System.Drawing.Image)
        Me.btnBorrarND.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBorrarND.Location = New System.Drawing.Point(283, 632)
        Me.btnBorrarND.Name = "btnBorrarND"
        Me.btnBorrarND.Size = New System.Drawing.Size(99, 28)
        Me.btnBorrarND.TabIndex = 775
        Me.btnBorrarND.Text = "&Borrar"
        Me.btnBorrarND.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBorrarND.UseVisualStyleBackColor = True
        '
        'btnModificarND
        '
        Me.btnModificarND.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificarND.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarND.Image = CType(resources.GetObject("btnModificarND.Image"), System.Drawing.Image)
        Me.btnModificarND.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificarND.Location = New System.Drawing.Point(151, 632)
        Me.btnModificarND.Name = "btnModificarND"
        Me.btnModificarND.Size = New System.Drawing.Size(99, 28)
        Me.btnModificarND.TabIndex = 774
        Me.btnModificarND.Text = "&Modificar"
        Me.btnModificarND.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificarND.UseVisualStyleBackColor = True
        '
        'btnAgregarND
        '
        Me.btnAgregarND.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarND.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarND.Image = CType(resources.GetObject("btnAgregarND.Image"), System.Drawing.Image)
        Me.btnAgregarND.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregarND.Location = New System.Drawing.Point(19, 632)
        Me.btnAgregarND.Name = "btnAgregarND"
        Me.btnAgregarND.Size = New System.Drawing.Size(99, 28)
        Me.btnAgregarND.TabIndex = 773
        Me.btnAgregarND.Text = "&Agregar"
        Me.btnAgregarND.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregarND.UseVisualStyleBackColor = True
        '
        'txtTotalFactura
        '
        Me.txtTotalFactura.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotalFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalFactura.ForeColor = System.Drawing.Color.Blue
        Me.txtTotalFactura.Location = New System.Drawing.Point(576, 678)
        Me.txtTotalFactura.MaxLength = 50
        Me.txtTotalFactura.Name = "txtTotalFactura"
        Me.txtTotalFactura.ReadOnly = True
        Me.txtTotalFactura.Size = New System.Drawing.Size(222, 31)
        Me.txtTotalFactura.TabIndex = 776
        Me.txtTotalFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetaprecio
        '
        Me.etiquetaprecio.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaprecio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaprecio.ForeColor = System.Drawing.Color.Black
        Me.etiquetaprecio.Location = New System.Drawing.Point(409, 681)
        Me.etiquetaprecio.Name = "etiquetaprecio"
        Me.etiquetaprecio.Size = New System.Drawing.Size(161, 21)
        Me.etiquetaprecio.TabIndex = 779
        Me.etiquetaprecio.Text = "Total Factura"
        Me.etiquetaprecio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTotalND
        '
        Me.txtTotalND.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotalND.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalND.ForeColor = System.Drawing.Color.Blue
        Me.txtTotalND.Location = New System.Drawing.Point(576, 632)
        Me.txtTotalND.MaxLength = 50
        Me.txtTotalND.Name = "txtTotalND"
        Me.txtTotalND.ReadOnly = True
        Me.txtTotalND.Size = New System.Drawing.Size(222, 31)
        Me.txtTotalND.TabIndex = 777
        Me.txtTotalND.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetaalicuota
        '
        Me.etiquetaalicuota.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaalicuota.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaalicuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaalicuota.ForeColor = System.Drawing.Color.Black
        Me.etiquetaalicuota.Location = New System.Drawing.Point(409, 635)
        Me.etiquetaalicuota.Name = "etiquetaalicuota"
        Me.etiquetaalicuota.Size = New System.Drawing.Size(161, 21)
        Me.etiquetaalicuota.TabIndex = 780
        Me.etiquetaalicuota.Text = "Total Nota Devolucion"
        Me.etiquetaalicuota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTotalAbonar
        '
        Me.txtTotalAbonar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotalAbonar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAbonar.ForeColor = System.Drawing.Color.Blue
        Me.txtTotalAbonar.Location = New System.Drawing.Point(576, 565)
        Me.txtTotalAbonar.MaxLength = 50
        Me.txtTotalAbonar.Name = "txtTotalAbonar"
        Me.txtTotalAbonar.ReadOnly = True
        Me.txtTotalAbonar.Size = New System.Drawing.Size(222, 31)
        Me.txtTotalAbonar.TabIndex = 778
        Me.txtTotalAbonar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetaiva
        '
        Me.etiquetaiva.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaiva.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaiva.ForeColor = System.Drawing.Color.Black
        Me.etiquetaiva.Location = New System.Drawing.Point(409, 572)
        Me.etiquetaiva.Name = "etiquetaiva"
        Me.etiquetaiva.Size = New System.Drawing.Size(161, 21)
        Me.etiquetaiva.TabIndex = 781
        Me.etiquetaiva.Text = "Total Abonar"
        Me.etiquetaiva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(12, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 21)
        Me.Label4.TabIndex = 785
        Me.Label4.Text = "Empresa"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Visible = False
        '
        'btnBuscaEmpresa
        '
        Me.btnBuscaEmpresa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscaEmpresa.Enabled = False
        Me.btnBuscaEmpresa.Image = CType(resources.GetObject("btnBuscaEmpresa.Image"), System.Drawing.Image)
        Me.btnBuscaEmpresa.Location = New System.Drawing.Point(591, 14)
        Me.btnBuscaEmpresa.Name = "btnBuscaEmpresa"
        Me.btnBuscaEmpresa.Size = New System.Drawing.Size(27, 21)
        Me.btnBuscaEmpresa.TabIndex = 784
        Me.btnBuscaEmpresa.UseVisualStyleBackColor = True
        Me.btnBuscaEmpresa.Visible = False
        '
        'lblid_empresa
        '
        Me.lblid_empresa.AutoSize = True
        Me.lblid_empresa.BackColor = System.Drawing.Color.Red
        Me.lblid_empresa.Location = New System.Drawing.Point(110, 17)
        Me.lblid_empresa.Name = "lblid_empresa"
        Me.lblid_empresa.Size = New System.Drawing.Size(13, 13)
        Me.lblid_empresa.TabIndex = 783
        Me.lblid_empresa.Text = "0"
        Me.lblid_empresa.Visible = False
        '
        'cmbEmpresa
        '
        Me.cmbEmpresa.Enabled = False
        Me.cmbEmpresa.FormattingEnabled = True
        Me.cmbEmpresa.Location = New System.Drawing.Point(90, 14)
        Me.cmbEmpresa.Name = "cmbEmpresa"
        Me.cmbEmpresa.Size = New System.Drawing.Size(490, 21)
        Me.cmbEmpresa.TabIndex = 782
        Me.cmbEmpresa.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(15, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 21)
        Me.Label2.TabIndex = 786
        Me.Label2.Text = "Factura"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.PowderBlue
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(15, 400)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 21)
        Me.Label3.TabIndex = 787
        Me.Label3.Text = "Nota de Devolucion"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Azure
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(532, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 15)
        Me.Label9.TabIndex = 790
        Me.Label9.Text = "Almacen-Deposito"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label9.Visible = False
        '
        'lblid_almacen
        '
        Me.lblid_almacen.AutoSize = True
        Me.lblid_almacen.BackColor = System.Drawing.Color.Red
        Me.lblid_almacen.Location = New System.Drawing.Point(682, 84)
        Me.lblid_almacen.Name = "lblid_almacen"
        Me.lblid_almacen.Size = New System.Drawing.Size(13, 13)
        Me.lblid_almacen.TabIndex = 789
        Me.lblid_almacen.Text = "0"
        Me.lblid_almacen.Visible = False
        '
        'cmbAlmacen
        '
        Me.cmbAlmacen.FormattingEnabled = True
        Me.cmbAlmacen.Location = New System.Drawing.Point(662, 81)
        Me.cmbAlmacen.Name = "cmbAlmacen"
        Me.cmbAlmacen.Size = New System.Drawing.Size(342, 21)
        Me.cmbAlmacen.TabIndex = 788
        Me.cmbAlmacen.Visible = False
        '
        'lblEstado_libro
        '
        Me.lblEstado_libro.BackColor = System.Drawing.Color.Lime
        Me.lblEstado_libro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado_libro.Location = New System.Drawing.Point(207, 125)
        Me.lblEstado_libro.Name = "lblEstado_libro"
        Me.lblEstado_libro.Size = New System.Drawing.Size(150, 20)
        Me.lblEstado_libro.TabIndex = 791
        Me.lblEstado_libro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmAbmFactura_proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1016, 734)
        Me.Controls.Add(Me.lblEstado_libro)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblid_almacen)
        Me.Controls.Add(Me.cmbAlmacen)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnBuscaEmpresa)
        Me.Controls.Add(Me.lblid_empresa)
        Me.Controls.Add(Me.cmbEmpresa)
        Me.Controls.Add(Me.txtTotalFactura)
        Me.Controls.Add(Me.etiquetaprecio)
        Me.Controls.Add(Me.txtTotalND)
        Me.Controls.Add(Me.etiquetaalicuota)
        Me.Controls.Add(Me.txtTotalAbonar)
        Me.Controls.Add(Me.etiquetaiva)
        Me.Controls.Add(Me.btnBorrarND)
        Me.Controls.Add(Me.btnModificarND)
        Me.Controls.Add(Me.btnAgregarND)
        Me.Controls.Add(Me.btnAyuda)
        Me.Controls.Add(Me.rbnTodo)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.rbnCon)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.rbnSin)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnBuscaProveedor)
        Me.Controls.Add(Me.lblid_proveedor)
        Me.Controls.Add(Me.cmbProveedor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.etiquetaid_tipo_comprobante)
        Me.Controls.Add(Me.dtpPeriodo)
        Me.Controls.Add(Me.lblid_pk2)
        Me.Controls.Add(Me.dgv2)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.lblid_pk)
        Me.Name = "frmAbmFactura_proveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAbmFactura_proveedor"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Protected WithEvents btnAyuda As System.Windows.Forms.Button
    Protected WithEvents btnSalir As System.Windows.Forms.Button
    Protected WithEvents btnBorrar As System.Windows.Forms.Button
    Protected WithEvents btnModificar As System.Windows.Forms.Button
    Protected WithEvents btnAgregar As System.Windows.Forms.Button
    Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
    Protected WithEvents lblTitulo As System.Windows.Forms.Label
    Protected WithEvents dgv1 As System.Windows.Forms.DataGridView
    Public WithEvents lblid_pk As System.Windows.Forms.Label
    Public WithEvents lblid_pk2 As System.Windows.Forms.Label
    Protected WithEvents dgv2 As System.Windows.Forms.DataGridView
    Friend WithEvents dtpPeriodo As System.Windows.Forms.DateTimePicker
    Friend WithEvents etiquetaid_tipo_comprobante As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBuscaProveedor As System.Windows.Forms.Button
    Friend WithEvents cmbProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents rbnSin As System.Windows.Forms.RadioButton
    Friend WithEvents rbnCon As System.Windows.Forms.RadioButton
    Friend WithEvents rbnTodo As System.Windows.Forms.RadioButton
    Protected WithEvents btnBorrarND As System.Windows.Forms.Button
    Protected WithEvents btnModificarND As System.Windows.Forms.Button
    Protected WithEvents btnAgregarND As System.Windows.Forms.Button
    Protected WithEvents txtTotalFactura As System.Windows.Forms.TextBox
    Friend WithEvents etiquetaprecio As System.Windows.Forms.Label
    Protected WithEvents txtTotalND As System.Windows.Forms.TextBox
    Friend WithEvents etiquetaalicuota As System.Windows.Forms.Label
    Protected WithEvents txtTotalAbonar As System.Windows.Forms.TextBox
    Friend WithEvents etiquetaiva As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnBuscaEmpresa As System.Windows.Forms.Button
    Friend WithEvents cmbEmpresa As System.Windows.Forms.ComboBox
    Public WithEvents lblid_proveedor As System.Windows.Forms.Label
    Public WithEvents lblid_empresa As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblid_almacen As System.Windows.Forms.Label
    Friend WithEvents cmbAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents lblEstado_libro As System.Windows.Forms.Label
End Class

