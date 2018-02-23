<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetallePresupuesto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetallePresupuesto))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.lblid_Presupuesto = New System.Windows.Forms.Label()
        Me.lblid_pk = New System.Windows.Forms.Label()
        Me.txtnumero = New System.Windows.Forms.TextBox()
        Me.etiquetanumero = New System.Windows.Forms.Label()
        Me.txtnumero_presupuesto = New System.Windows.Forms.TextBox()
        Me.etiquetanumero_presupuesto = New System.Windows.Forms.Label()
        Me.dtpfecha_presupuesto = New System.Windows.Forms.DateTimePicker()
        Me.etiquetafecha_presupuesto = New System.Windows.Forms.Label()
        Me.txtnumero_revision = New System.Windows.Forms.TextBox()
        Me.etiquetanumero_revision = New System.Windows.Forms.Label()
        Me.lblid_cliente = New System.Windows.Forms.Label()
        Me.cmbcliente = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_cliente = New System.Windows.Forms.Label()
        Me.dtpplazo_entrega = New System.Windows.Forms.DateTimePicker()
        Me.etiquetaplazo_entrega = New System.Windows.Forms.Label()
        Me.txtimporte_total = New System.Windows.Forms.TextBox()
        Me.etiquetaimporte_total = New System.Windows.Forms.Label()
        Me.lblid_tipo_moneda = New System.Windows.Forms.Label()
        Me.btnBuscatipo_moneda = New System.Windows.Forms.Button()
        Me.cmbtipo_moneda = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_tipo_moneda = New System.Windows.Forms.Label()
        Me.lblid_forma_pago = New System.Windows.Forms.Label()
        Me.btnBuscaforma_pago = New System.Windows.Forms.Button()
        Me.cmbforma_pago = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_forma_pago = New System.Windows.Forms.Label()
        Me.lblid_medio_entrega = New System.Windows.Forms.Label()
        Me.btnBuscamedio_entrega = New System.Windows.Forms.Button()
        Me.cmbmedio_entrega = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_medio_entrega = New System.Windows.Forms.Label()
        Me.lblid_preparo = New System.Windows.Forms.Label()
        Me.btnBuscapreparo = New System.Windows.Forms.Button()
        Me.cmbpreparo = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_preparo = New System.Windows.Forms.Label()
        Me.lblid_responsable_calidad = New System.Windows.Forms.Label()
        Me.btnBuscaresponsable_calidad = New System.Windows.Forms.Button()
        Me.cmbresponsable_calidad = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_responsable_calidad = New System.Windows.Forms.Label()
        Me.lblid_aprobo = New System.Windows.Forms.Label()
        Me.btnBuscaaprobo = New System.Windows.Forms.Button()
        Me.cmbaprobo = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_aprobo = New System.Windows.Forms.Label()
        Me.lblid_direccion_general = New System.Windows.Forms.Label()
        Me.btnBuscadireccion_general = New System.Windows.Forms.Button()
        Me.cmbdireccion_general = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_direccion_general = New System.Windows.Forms.Label()
        Me.dtpfecha_emision = New System.Windows.Forms.DateTimePicker()
        Me.etiquetafecha_emision = New System.Windows.Forms.Label()
        Me.dtpfecha_revision = New System.Windows.Forms.DateTimePicker()
        Me.etiquetafecha_revision = New System.Windows.Forms.Label()
        Me.lblid_firma = New System.Windows.Forms.Label()
        Me.btnBuscafirma = New System.Windows.Forms.Button()
        Me.cmbfirma = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_firma = New System.Windows.Forms.Label()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(28, 577)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 49)
        Me.btnSalir.TabIndex = 61
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(28, 512)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 49)
        Me.btnGuardar.TabIndex = 60
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAgregar.Location = New System.Drawing.Point(28, 296)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 49)
        Me.btnAgregar.TabIndex = 50
        Me.btnAgregar.Text = "&Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModificar.Location = New System.Drawing.Point(28, 366)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 49)
        Me.btnModificar.TabIndex = 51
        Me.btnModificar.Text = "&Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar.Image = CType(resources.GetObject("btnBorrar.Image"), System.Drawing.Image)
        Me.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBorrar.Location = New System.Drawing.Point(28, 437)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 49)
        Me.btnBorrar.TabIndex = 52
        Me.btnBorrar.Text = "&Borrar"
        Me.btnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBorrar.UseVisualStyleBackColor = True
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
        Me.dgv1.BackgroundColor = System.Drawing.Color.SkyBlue
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
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Beige
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Brown
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv1.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv1.GridColor = System.Drawing.Color.MediumPurple
        Me.dgv1.Location = New System.Drawing.Point(135, 296)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.ShowCellErrors = False
        Me.dgv1.ShowRowErrors = False
        Me.dgv1.Size = New System.Drawing.Size(845, 330)
        Me.dgv1.StandardTab = True
        Me.dgv1.TabIndex = 500
        '
        'lblid_Presupuesto
        '
        Me.lblid_Presupuesto.AutoSize = True
        Me.lblid_Presupuesto.BackColor = System.Drawing.Color.Red
        Me.lblid_Presupuesto.Location = New System.Drawing.Point(182, 5)
        Me.lblid_Presupuesto.Name = "lblid_Presupuesto"
        Me.lblid_Presupuesto.Size = New System.Drawing.Size(13, 13)
        Me.lblid_Presupuesto.TabIndex = 565
        Me.lblid_Presupuesto.Text = "0"
        Me.lblid_Presupuesto.Visible = False
        '
        'lblid_pk
        '
        Me.lblid_pk.AutoSize = True
        Me.lblid_pk.BackColor = System.Drawing.Color.Red
        Me.lblid_pk.Location = New System.Drawing.Point(158, 309)
        Me.lblid_pk.Name = "lblid_pk"
        Me.lblid_pk.Size = New System.Drawing.Size(13, 13)
        Me.lblid_pk.TabIndex = 565
        Me.lblid_pk.Text = "0"
        Me.lblid_pk.Visible = False
        '
        'txtnumero
        '
        Me.txtnumero.BackColor = System.Drawing.Color.White
        Me.txtnumero.Location = New System.Drawing.Point(161, 49)
        Me.txtnumero.MaxLength = 50
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(385, 20)
        Me.txtnumero.TabIndex = 4
        '
        'etiquetanumero
        '
        Me.etiquetanumero.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetanumero.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetanumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetanumero.ForeColor = System.Drawing.Color.Black
        Me.etiquetanumero.Location = New System.Drawing.Point(28, 49)
        Me.etiquetanumero.Name = "etiquetanumero"
        Me.etiquetanumero.Size = New System.Drawing.Size(127, 21)
        Me.etiquetanumero.TabIndex = 500
        Me.etiquetanumero.Text = "Numero"
        Me.etiquetanumero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtnumero_presupuesto
        '
        Me.txtnumero_presupuesto.BackColor = System.Drawing.Color.White
        Me.txtnumero_presupuesto.Location = New System.Drawing.Point(161, 79)
        Me.txtnumero_presupuesto.MaxLength = 50
        Me.txtnumero_presupuesto.Name = "txtnumero_presupuesto"
        Me.txtnumero_presupuesto.Size = New System.Drawing.Size(385, 20)
        Me.txtnumero_presupuesto.TabIndex = 5
        '
        'etiquetanumero_presupuesto
        '
        Me.etiquetanumero_presupuesto.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetanumero_presupuesto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetanumero_presupuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetanumero_presupuesto.ForeColor = System.Drawing.Color.Black
        Me.etiquetanumero_presupuesto.Location = New System.Drawing.Point(28, 79)
        Me.etiquetanumero_presupuesto.Name = "etiquetanumero_presupuesto"
        Me.etiquetanumero_presupuesto.Size = New System.Drawing.Size(127, 21)
        Me.etiquetanumero_presupuesto.TabIndex = 501
        Me.etiquetanumero_presupuesto.Text = "Numero_presupuesto"
        Me.etiquetanumero_presupuesto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpfecha_presupuesto
        '
        Me.dtpfecha_presupuesto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha_presupuesto.Location = New System.Drawing.Point(161, 109)
        Me.dtpfecha_presupuesto.Name = "dtpfecha_presupuesto"
        Me.dtpfecha_presupuesto.Size = New System.Drawing.Size(93, 20)
        Me.dtpfecha_presupuesto.TabIndex = 6
        '
        'etiquetafecha_presupuesto
        '
        Me.etiquetafecha_presupuesto.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetafecha_presupuesto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetafecha_presupuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetafecha_presupuesto.ForeColor = System.Drawing.Color.Black
        Me.etiquetafecha_presupuesto.Location = New System.Drawing.Point(28, 109)
        Me.etiquetafecha_presupuesto.Name = "etiquetafecha_presupuesto"
        Me.etiquetafecha_presupuesto.Size = New System.Drawing.Size(127, 21)
        Me.etiquetafecha_presupuesto.TabIndex = 502
        Me.etiquetafecha_presupuesto.Text = "Fecha_presupuesto"
        Me.etiquetafecha_presupuesto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtnumero_revision
        '
        Me.txtnumero_revision.BackColor = System.Drawing.Color.White
        Me.txtnumero_revision.Location = New System.Drawing.Point(161, 139)
        Me.txtnumero_revision.MaxLength = 50
        Me.txtnumero_revision.Name = "txtnumero_revision"
        Me.txtnumero_revision.Size = New System.Drawing.Size(385, 20)
        Me.txtnumero_revision.TabIndex = 7
        '
        'etiquetanumero_revision
        '
        Me.etiquetanumero_revision.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetanumero_revision.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetanumero_revision.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetanumero_revision.ForeColor = System.Drawing.Color.Black
        Me.etiquetanumero_revision.Location = New System.Drawing.Point(28, 139)
        Me.etiquetanumero_revision.Name = "etiquetanumero_revision"
        Me.etiquetanumero_revision.Size = New System.Drawing.Size(127, 21)
        Me.etiquetanumero_revision.TabIndex = 503
        Me.etiquetanumero_revision.Text = "Numero_revision"
        Me.etiquetanumero_revision.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_cliente
        '
        Me.lblid_cliente.AutoSize = True
        Me.lblid_cliente.BackColor = System.Drawing.Color.Red
        Me.lblid_cliente.Location = New System.Drawing.Point(370, 19)
        Me.lblid_cliente.Name = "lblid_cliente"
        Me.lblid_cliente.Size = New System.Drawing.Size(13, 13)
        Me.lblid_cliente.TabIndex = 504
        Me.lblid_cliente.Text = "0"
        Me.lblid_cliente.Visible = False
        '
        'cmbcliente
        '
        Me.cmbcliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbcliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbcliente.Enabled = False
        Me.cmbcliente.FormattingEnabled = True
        Me.cmbcliente.Location = New System.Drawing.Point(161, 19)
        Me.cmbcliente.Name = "cmbcliente"
        Me.cmbcliente.Size = New System.Drawing.Size(385, 21)
        Me.cmbcliente.TabIndex = 8
        '
        'etiquetaid_cliente
        '
        Me.etiquetaid_cliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_cliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_cliente.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_cliente.Location = New System.Drawing.Point(28, 19)
        Me.etiquetaid_cliente.Name = "etiquetaid_cliente"
        Me.etiquetaid_cliente.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_cliente.TabIndex = 505
        Me.etiquetaid_cliente.Text = "Cliente"
        Me.etiquetaid_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpplazo_entrega
        '
        Me.dtpplazo_entrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpplazo_entrega.Location = New System.Drawing.Point(161, 169)
        Me.dtpplazo_entrega.Name = "dtpplazo_entrega"
        Me.dtpplazo_entrega.Size = New System.Drawing.Size(93, 20)
        Me.dtpplazo_entrega.TabIndex = 9
        '
        'etiquetaplazo_entrega
        '
        Me.etiquetaplazo_entrega.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaplazo_entrega.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaplazo_entrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaplazo_entrega.ForeColor = System.Drawing.Color.Black
        Me.etiquetaplazo_entrega.Location = New System.Drawing.Point(28, 169)
        Me.etiquetaplazo_entrega.Name = "etiquetaplazo_entrega"
        Me.etiquetaplazo_entrega.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaplazo_entrega.TabIndex = 506
        Me.etiquetaplazo_entrega.Text = "Plazo_entrega"
        Me.etiquetaplazo_entrega.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtimporte_total
        '
        Me.txtimporte_total.BackColor = System.Drawing.Color.White
        Me.txtimporte_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtimporte_total.ForeColor = System.Drawing.Color.Blue
        Me.txtimporte_total.Location = New System.Drawing.Point(161, 199)
        Me.txtimporte_total.MaxLength = 50
        Me.txtimporte_total.Name = "txtimporte_total"
        Me.txtimporte_total.Size = New System.Drawing.Size(222, 31)
        Me.txtimporte_total.TabIndex = 10
        Me.txtimporte_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetaimporte_total
        '
        Me.etiquetaimporte_total.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaimporte_total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaimporte_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaimporte_total.ForeColor = System.Drawing.Color.Black
        Me.etiquetaimporte_total.Location = New System.Drawing.Point(28, 199)
        Me.etiquetaimporte_total.Name = "etiquetaimporte_total"
        Me.etiquetaimporte_total.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaimporte_total.TabIndex = 507
        Me.etiquetaimporte_total.Text = "Importe_total"
        Me.etiquetaimporte_total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_tipo_moneda
        '
        Me.lblid_tipo_moneda.AutoSize = True
        Me.lblid_tipo_moneda.BackColor = System.Drawing.Color.Red
        Me.lblid_tipo_moneda.Location = New System.Drawing.Point(370, 239)
        Me.lblid_tipo_moneda.Name = "lblid_tipo_moneda"
        Me.lblid_tipo_moneda.Size = New System.Drawing.Size(13, 13)
        Me.lblid_tipo_moneda.TabIndex = 508
        Me.lblid_tipo_moneda.Text = "0"
        Me.lblid_tipo_moneda.Visible = False
        '
        'btnBuscatipo_moneda
        '
        Me.btnBuscatipo_moneda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscatipo_moneda.Image = CType(resources.GetObject("btnBuscatipo_moneda.Image"), System.Drawing.Image)
        Me.btnBuscatipo_moneda.Location = New System.Drawing.Point(505, 239)
        Me.btnBuscatipo_moneda.Name = "btnBuscatipo_moneda"
        Me.btnBuscatipo_moneda.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscatipo_moneda.TabIndex = 31
        Me.btnBuscatipo_moneda.UseVisualStyleBackColor = True
        '
        'cmbtipo_moneda
        '
        Me.cmbtipo_moneda.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbtipo_moneda.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbtipo_moneda.FormattingEnabled = True
        Me.cmbtipo_moneda.Location = New System.Drawing.Point(161, 239)
        Me.cmbtipo_moneda.Name = "cmbtipo_moneda"
        Me.cmbtipo_moneda.Size = New System.Drawing.Size(329, 21)
        Me.cmbtipo_moneda.TabIndex = 11
        '
        'etiquetaid_tipo_moneda
        '
        Me.etiquetaid_tipo_moneda.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_tipo_moneda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_tipo_moneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_tipo_moneda.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_tipo_moneda.Location = New System.Drawing.Point(28, 239)
        Me.etiquetaid_tipo_moneda.Name = "etiquetaid_tipo_moneda"
        Me.etiquetaid_tipo_moneda.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_tipo_moneda.TabIndex = 509
        Me.etiquetaid_tipo_moneda.Text = "Tipo_moneda"
        Me.etiquetaid_tipo_moneda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_forma_pago
        '
        Me.lblid_forma_pago.AutoSize = True
        Me.lblid_forma_pago.BackColor = System.Drawing.Color.Red
        Me.lblid_forma_pago.Location = New System.Drawing.Point(851, 19)
        Me.lblid_forma_pago.Name = "lblid_forma_pago"
        Me.lblid_forma_pago.Size = New System.Drawing.Size(13, 13)
        Me.lblid_forma_pago.TabIndex = 510
        Me.lblid_forma_pago.Text = "0"
        Me.lblid_forma_pago.Visible = False
        '
        'btnBuscaforma_pago
        '
        Me.btnBuscaforma_pago.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscaforma_pago.Image = CType(resources.GetObject("btnBuscaforma_pago.Image"), System.Drawing.Image)
        Me.btnBuscaforma_pago.Location = New System.Drawing.Point(986, 19)
        Me.btnBuscaforma_pago.Name = "btnBuscaforma_pago"
        Me.btnBuscaforma_pago.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscaforma_pago.TabIndex = 32
        Me.btnBuscaforma_pago.UseVisualStyleBackColor = True
        '
        'cmbforma_pago
        '
        Me.cmbforma_pago.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbforma_pago.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbforma_pago.FormattingEnabled = True
        Me.cmbforma_pago.Location = New System.Drawing.Point(716, 19)
        Me.cmbforma_pago.Name = "cmbforma_pago"
        Me.cmbforma_pago.Size = New System.Drawing.Size(255, 21)
        Me.cmbforma_pago.TabIndex = 12
        '
        'etiquetaid_forma_pago
        '
        Me.etiquetaid_forma_pago.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_forma_pago.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_forma_pago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_forma_pago.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_forma_pago.Location = New System.Drawing.Point(583, 19)
        Me.etiquetaid_forma_pago.Name = "etiquetaid_forma_pago"
        Me.etiquetaid_forma_pago.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_forma_pago.TabIndex = 511
        Me.etiquetaid_forma_pago.Text = "Forma_pago"
        Me.etiquetaid_forma_pago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_medio_entrega
        '
        Me.lblid_medio_entrega.AutoSize = True
        Me.lblid_medio_entrega.BackColor = System.Drawing.Color.Red
        Me.lblid_medio_entrega.Location = New System.Drawing.Point(851, 49)
        Me.lblid_medio_entrega.Name = "lblid_medio_entrega"
        Me.lblid_medio_entrega.Size = New System.Drawing.Size(13, 13)
        Me.lblid_medio_entrega.TabIndex = 512
        Me.lblid_medio_entrega.Text = "0"
        Me.lblid_medio_entrega.Visible = False
        '
        'btnBuscamedio_entrega
        '
        Me.btnBuscamedio_entrega.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscamedio_entrega.Image = CType(resources.GetObject("btnBuscamedio_entrega.Image"), System.Drawing.Image)
        Me.btnBuscamedio_entrega.Location = New System.Drawing.Point(986, 49)
        Me.btnBuscamedio_entrega.Name = "btnBuscamedio_entrega"
        Me.btnBuscamedio_entrega.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscamedio_entrega.TabIndex = 33
        Me.btnBuscamedio_entrega.UseVisualStyleBackColor = True
        '
        'cmbmedio_entrega
        '
        Me.cmbmedio_entrega.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbmedio_entrega.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbmedio_entrega.FormattingEnabled = True
        Me.cmbmedio_entrega.Location = New System.Drawing.Point(716, 49)
        Me.cmbmedio_entrega.Name = "cmbmedio_entrega"
        Me.cmbmedio_entrega.Size = New System.Drawing.Size(255, 21)
        Me.cmbmedio_entrega.TabIndex = 13
        '
        'etiquetaid_medio_entrega
        '
        Me.etiquetaid_medio_entrega.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_medio_entrega.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_medio_entrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_medio_entrega.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_medio_entrega.Location = New System.Drawing.Point(583, 49)
        Me.etiquetaid_medio_entrega.Name = "etiquetaid_medio_entrega"
        Me.etiquetaid_medio_entrega.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_medio_entrega.TabIndex = 513
        Me.etiquetaid_medio_entrega.Text = "Medio_entrega"
        Me.etiquetaid_medio_entrega.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_preparo
        '
        Me.lblid_preparo.AutoSize = True
        Me.lblid_preparo.BackColor = System.Drawing.Color.Red
        Me.lblid_preparo.Location = New System.Drawing.Point(851, 79)
        Me.lblid_preparo.Name = "lblid_preparo"
        Me.lblid_preparo.Size = New System.Drawing.Size(13, 13)
        Me.lblid_preparo.TabIndex = 514
        Me.lblid_preparo.Text = "0"
        Me.lblid_preparo.Visible = False
        '
        'btnBuscapreparo
        '
        Me.btnBuscapreparo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscapreparo.Image = CType(resources.GetObject("btnBuscapreparo.Image"), System.Drawing.Image)
        Me.btnBuscapreparo.Location = New System.Drawing.Point(986, 79)
        Me.btnBuscapreparo.Name = "btnBuscapreparo"
        Me.btnBuscapreparo.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscapreparo.TabIndex = 34
        Me.btnBuscapreparo.UseVisualStyleBackColor = True
        '
        'cmbpreparo
        '
        Me.cmbpreparo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbpreparo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbpreparo.FormattingEnabled = True
        Me.cmbpreparo.Location = New System.Drawing.Point(716, 79)
        Me.cmbpreparo.Name = "cmbpreparo"
        Me.cmbpreparo.Size = New System.Drawing.Size(255, 21)
        Me.cmbpreparo.TabIndex = 14
        '
        'etiquetaid_preparo
        '
        Me.etiquetaid_preparo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_preparo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_preparo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_preparo.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_preparo.Location = New System.Drawing.Point(583, 79)
        Me.etiquetaid_preparo.Name = "etiquetaid_preparo"
        Me.etiquetaid_preparo.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_preparo.TabIndex = 515
        Me.etiquetaid_preparo.Text = "Preparo"
        Me.etiquetaid_preparo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_responsable_calidad
        '
        Me.lblid_responsable_calidad.AutoSize = True
        Me.lblid_responsable_calidad.BackColor = System.Drawing.Color.Red
        Me.lblid_responsable_calidad.Location = New System.Drawing.Point(863, 109)
        Me.lblid_responsable_calidad.Name = "lblid_responsable_calidad"
        Me.lblid_responsable_calidad.Size = New System.Drawing.Size(13, 13)
        Me.lblid_responsable_calidad.TabIndex = 516
        Me.lblid_responsable_calidad.Text = "0"
        Me.lblid_responsable_calidad.Visible = False
        '
        'btnBuscaresponsable_calidad
        '
        Me.btnBuscaresponsable_calidad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscaresponsable_calidad.Image = CType(resources.GetObject("btnBuscaresponsable_calidad.Image"), System.Drawing.Image)
        Me.btnBuscaresponsable_calidad.Location = New System.Drawing.Point(986, 109)
        Me.btnBuscaresponsable_calidad.Name = "btnBuscaresponsable_calidad"
        Me.btnBuscaresponsable_calidad.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscaresponsable_calidad.TabIndex = 35
        Me.btnBuscaresponsable_calidad.UseVisualStyleBackColor = True
        '
        'cmbresponsable_calidad
        '
        Me.cmbresponsable_calidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbresponsable_calidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbresponsable_calidad.FormattingEnabled = True
        Me.cmbresponsable_calidad.Location = New System.Drawing.Point(716, 109)
        Me.cmbresponsable_calidad.Name = "cmbresponsable_calidad"
        Me.cmbresponsable_calidad.Size = New System.Drawing.Size(255, 21)
        Me.cmbresponsable_calidad.TabIndex = 15
        '
        'etiquetaid_responsable_calidad
        '
        Me.etiquetaid_responsable_calidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_responsable_calidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_responsable_calidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_responsable_calidad.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_responsable_calidad.Location = New System.Drawing.Point(583, 109)
        Me.etiquetaid_responsable_calidad.Name = "etiquetaid_responsable_calidad"
        Me.etiquetaid_responsable_calidad.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_responsable_calidad.TabIndex = 517
        Me.etiquetaid_responsable_calidad.Text = "Responsable_calidad"
        Me.etiquetaid_responsable_calidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_aprobo
        '
        Me.lblid_aprobo.AutoSize = True
        Me.lblid_aprobo.BackColor = System.Drawing.Color.Red
        Me.lblid_aprobo.Location = New System.Drawing.Point(925, 138)
        Me.lblid_aprobo.Name = "lblid_aprobo"
        Me.lblid_aprobo.Size = New System.Drawing.Size(13, 13)
        Me.lblid_aprobo.TabIndex = 518
        Me.lblid_aprobo.Text = "0"
        Me.lblid_aprobo.Visible = False
        '
        'btnBuscaaprobo
        '
        Me.btnBuscaaprobo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscaaprobo.Image = CType(resources.GetObject("btnBuscaaprobo.Image"), System.Drawing.Image)
        Me.btnBuscaaprobo.Location = New System.Drawing.Point(1060, 48)
        Me.btnBuscaaprobo.Name = "btnBuscaaprobo"
        Me.btnBuscaaprobo.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscaaprobo.TabIndex = 36
        Me.btnBuscaaprobo.UseVisualStyleBackColor = True
        '
        'cmbaprobo
        '
        Me.cmbaprobo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbaprobo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbaprobo.FormattingEnabled = True
        Me.cmbaprobo.Location = New System.Drawing.Point(716, 139)
        Me.cmbaprobo.Name = "cmbaprobo"
        Me.cmbaprobo.Size = New System.Drawing.Size(296, 21)
        Me.cmbaprobo.TabIndex = 16
        '
        'etiquetaid_aprobo
        '
        Me.etiquetaid_aprobo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_aprobo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_aprobo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_aprobo.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_aprobo.Location = New System.Drawing.Point(583, 139)
        Me.etiquetaid_aprobo.Name = "etiquetaid_aprobo"
        Me.etiquetaid_aprobo.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_aprobo.TabIndex = 519
        Me.etiquetaid_aprobo.Text = "Aprobo"
        Me.etiquetaid_aprobo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_direccion_general
        '
        Me.lblid_direccion_general.AutoSize = True
        Me.lblid_direccion_general.BackColor = System.Drawing.Color.Red
        Me.lblid_direccion_general.Location = New System.Drawing.Point(925, 168)
        Me.lblid_direccion_general.Name = "lblid_direccion_general"
        Me.lblid_direccion_general.Size = New System.Drawing.Size(13, 13)
        Me.lblid_direccion_general.TabIndex = 520
        Me.lblid_direccion_general.Text = "0"
        Me.lblid_direccion_general.Visible = False
        '
        'btnBuscadireccion_general
        '
        Me.btnBuscadireccion_general.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscadireccion_general.Image = CType(resources.GetObject("btnBuscadireccion_general.Image"), System.Drawing.Image)
        Me.btnBuscadireccion_general.Location = New System.Drawing.Point(1060, 91)
        Me.btnBuscadireccion_general.Name = "btnBuscadireccion_general"
        Me.btnBuscadireccion_general.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscadireccion_general.TabIndex = 37
        Me.btnBuscadireccion_general.UseVisualStyleBackColor = True
        '
        'cmbdireccion_general
        '
        Me.cmbdireccion_general.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbdireccion_general.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbdireccion_general.FormattingEnabled = True
        Me.cmbdireccion_general.Location = New System.Drawing.Point(716, 169)
        Me.cmbdireccion_general.Name = "cmbdireccion_general"
        Me.cmbdireccion_general.Size = New System.Drawing.Size(296, 21)
        Me.cmbdireccion_general.TabIndex = 17
        '
        'etiquetaid_direccion_general
        '
        Me.etiquetaid_direccion_general.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_direccion_general.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_direccion_general.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_direccion_general.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_direccion_general.Location = New System.Drawing.Point(583, 169)
        Me.etiquetaid_direccion_general.Name = "etiquetaid_direccion_general"
        Me.etiquetaid_direccion_general.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_direccion_general.TabIndex = 521
        Me.etiquetaid_direccion_general.Text = "Direccion_general"
        Me.etiquetaid_direccion_general.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpfecha_emision
        '
        Me.dtpfecha_emision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha_emision.Location = New System.Drawing.Point(716, 199)
        Me.dtpfecha_emision.Name = "dtpfecha_emision"
        Me.dtpfecha_emision.Size = New System.Drawing.Size(93, 20)
        Me.dtpfecha_emision.TabIndex = 18
        '
        'etiquetafecha_emision
        '
        Me.etiquetafecha_emision.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetafecha_emision.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetafecha_emision.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetafecha_emision.ForeColor = System.Drawing.Color.Black
        Me.etiquetafecha_emision.Location = New System.Drawing.Point(583, 199)
        Me.etiquetafecha_emision.Name = "etiquetafecha_emision"
        Me.etiquetafecha_emision.Size = New System.Drawing.Size(127, 21)
        Me.etiquetafecha_emision.TabIndex = 522
        Me.etiquetafecha_emision.Text = "Fecha_emision"
        Me.etiquetafecha_emision.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpfecha_revision
        '
        Me.dtpfecha_revision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha_revision.Location = New System.Drawing.Point(716, 229)
        Me.dtpfecha_revision.Name = "dtpfecha_revision"
        Me.dtpfecha_revision.Size = New System.Drawing.Size(93, 20)
        Me.dtpfecha_revision.TabIndex = 19
        '
        'etiquetafecha_revision
        '
        Me.etiquetafecha_revision.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetafecha_revision.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetafecha_revision.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetafecha_revision.ForeColor = System.Drawing.Color.Black
        Me.etiquetafecha_revision.Location = New System.Drawing.Point(583, 229)
        Me.etiquetafecha_revision.Name = "etiquetafecha_revision"
        Me.etiquetafecha_revision.Size = New System.Drawing.Size(127, 21)
        Me.etiquetafecha_revision.TabIndex = 523
        Me.etiquetafecha_revision.Text = "Fecha_revision"
        Me.etiquetafecha_revision.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_firma
        '
        Me.lblid_firma.AutoSize = True
        Me.lblid_firma.BackColor = System.Drawing.Color.Red
        Me.lblid_firma.Location = New System.Drawing.Point(925, 258)
        Me.lblid_firma.Name = "lblid_firma"
        Me.lblid_firma.Size = New System.Drawing.Size(13, 13)
        Me.lblid_firma.TabIndex = 524
        Me.lblid_firma.Text = "0"
        Me.lblid_firma.Visible = False
        '
        'btnBuscafirma
        '
        Me.btnBuscafirma.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscafirma.Image = CType(resources.GetObject("btnBuscafirma.Image"), System.Drawing.Image)
        Me.btnBuscafirma.Location = New System.Drawing.Point(1060, 220)
        Me.btnBuscafirma.Name = "btnBuscafirma"
        Me.btnBuscafirma.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscafirma.TabIndex = 38
        Me.btnBuscafirma.UseVisualStyleBackColor = True
        '
        'cmbfirma
        '
        Me.cmbfirma.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbfirma.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbfirma.FormattingEnabled = True
        Me.cmbfirma.Location = New System.Drawing.Point(716, 259)
        Me.cmbfirma.Name = "cmbfirma"
        Me.cmbfirma.Size = New System.Drawing.Size(298, 21)
        Me.cmbfirma.TabIndex = 20
        '
        'etiquetaid_firma
        '
        Me.etiquetaid_firma.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_firma.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_firma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_firma.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_firma.Location = New System.Drawing.Point(583, 259)
        Me.etiquetaid_firma.Name = "etiquetaid_firma"
        Me.etiquetaid_firma.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_firma.TabIndex = 525
        Me.etiquetaid_firma.Text = "Firma"
        Me.etiquetaid_firma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmDetallePresupuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 753)
        Me.Controls.Add(Me.txtnumero)
        Me.Controls.Add(Me.etiquetanumero)
        Me.Controls.Add(Me.txtnumero_presupuesto)
        Me.Controls.Add(Me.etiquetanumero_presupuesto)
        Me.Controls.Add(Me.dtpfecha_presupuesto)
        Me.Controls.Add(Me.etiquetafecha_presupuesto)
        Me.Controls.Add(Me.txtnumero_revision)
        Me.Controls.Add(Me.etiquetanumero_revision)
        Me.Controls.Add(Me.lblid_cliente)
        Me.Controls.Add(Me.cmbcliente)
        Me.Controls.Add(Me.etiquetaid_cliente)
        Me.Controls.Add(Me.dtpplazo_entrega)
        Me.Controls.Add(Me.etiquetaplazo_entrega)
        Me.Controls.Add(Me.txtimporte_total)
        Me.Controls.Add(Me.etiquetaimporte_total)
        Me.Controls.Add(Me.lblid_tipo_moneda)
        Me.Controls.Add(Me.btnBuscatipo_moneda)
        Me.Controls.Add(Me.cmbtipo_moneda)
        Me.Controls.Add(Me.etiquetaid_tipo_moneda)
        Me.Controls.Add(Me.lblid_forma_pago)
        Me.Controls.Add(Me.btnBuscaforma_pago)
        Me.Controls.Add(Me.cmbforma_pago)
        Me.Controls.Add(Me.etiquetaid_forma_pago)
        Me.Controls.Add(Me.lblid_medio_entrega)
        Me.Controls.Add(Me.btnBuscamedio_entrega)
        Me.Controls.Add(Me.cmbmedio_entrega)
        Me.Controls.Add(Me.etiquetaid_medio_entrega)
        Me.Controls.Add(Me.lblid_preparo)
        Me.Controls.Add(Me.btnBuscapreparo)
        Me.Controls.Add(Me.cmbpreparo)
        Me.Controls.Add(Me.etiquetaid_preparo)
        Me.Controls.Add(Me.lblid_responsable_calidad)
        Me.Controls.Add(Me.btnBuscaresponsable_calidad)
        Me.Controls.Add(Me.cmbresponsable_calidad)
        Me.Controls.Add(Me.etiquetaid_responsable_calidad)
        Me.Controls.Add(Me.lblid_aprobo)
        Me.Controls.Add(Me.btnBuscaaprobo)
        Me.Controls.Add(Me.cmbaprobo)
        Me.Controls.Add(Me.etiquetaid_aprobo)
        Me.Controls.Add(Me.lblid_direccion_general)
        Me.Controls.Add(Me.btnBuscadireccion_general)
        Me.Controls.Add(Me.cmbdireccion_general)
        Me.Controls.Add(Me.etiquetaid_direccion_general)
        Me.Controls.Add(Me.dtpfecha_emision)
        Me.Controls.Add(Me.etiquetafecha_emision)
        Me.Controls.Add(Me.dtpfecha_revision)
        Me.Controls.Add(Me.etiquetafecha_revision)
        Me.Controls.Add(Me.lblid_firma)
        Me.Controls.Add(Me.btnBuscafirma)
        Me.Controls.Add(Me.cmbfirma)
        Me.Controls.Add(Me.etiquetaid_firma)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.lblid_pk)
        Me.Controls.Add(Me.lblid_Presupuesto)
        Me.Name = "frmDetallePresupuesto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetallePresupuesto"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Protected WithEvents txtnumero As System.Windows.Forms.TextBox
   Friend WithEvents etiquetanumero As System.Windows.Forms.Label
   Protected WithEvents txtnumero_presupuesto As System.Windows.Forms.TextBox
   Friend WithEvents etiquetanumero_presupuesto As System.Windows.Forms.Label
   Protected WithEvents dtpfecha_presupuesto As System.Windows.Forms.DateTimePicker
   Friend WithEvents etiquetafecha_presupuesto As System.Windows.Forms.Label
   Protected WithEvents txtnumero_revision As System.Windows.Forms.TextBox
   Friend WithEvents etiquetanumero_revision As System.Windows.Forms.Label
   Friend WithEvents lblid_cliente As System.Windows.Forms.Label
    Friend WithEvents cmbcliente As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_cliente As System.Windows.Forms.Label
   Protected WithEvents dtpplazo_entrega As System.Windows.Forms.DateTimePicker
   Friend WithEvents etiquetaplazo_entrega As System.Windows.Forms.Label
   Protected WithEvents txtimporte_total As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaimporte_total As System.Windows.Forms.Label
   Friend WithEvents lblid_tipo_moneda As System.Windows.Forms.Label
   Friend WithEvents btnBuscatipo_moneda As System.Windows.Forms.Button
   Friend WithEvents cmbtipo_moneda As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_tipo_moneda As System.Windows.Forms.Label
   Friend WithEvents lblid_forma_pago As System.Windows.Forms.Label
   Friend WithEvents btnBuscaforma_pago As System.Windows.Forms.Button
   Friend WithEvents cmbforma_pago As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_forma_pago As System.Windows.Forms.Label
   Friend WithEvents lblid_medio_entrega As System.Windows.Forms.Label
   Friend WithEvents btnBuscamedio_entrega As System.Windows.Forms.Button
   Friend WithEvents cmbmedio_entrega As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_medio_entrega As System.Windows.Forms.Label
   Friend WithEvents lblid_preparo As System.Windows.Forms.Label
   Friend WithEvents btnBuscapreparo As System.Windows.Forms.Button
   Friend WithEvents cmbpreparo As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_preparo As System.Windows.Forms.Label
   Friend WithEvents lblid_responsable_calidad As System.Windows.Forms.Label
   Friend WithEvents btnBuscaresponsable_calidad As System.Windows.Forms.Button
   Friend WithEvents cmbresponsable_calidad As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_responsable_calidad As System.Windows.Forms.Label
   Friend WithEvents lblid_aprobo As System.Windows.Forms.Label
   Friend WithEvents btnBuscaaprobo As System.Windows.Forms.Button
   Friend WithEvents cmbaprobo As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_aprobo As System.Windows.Forms.Label
   Friend WithEvents lblid_direccion_general As System.Windows.Forms.Label
   Friend WithEvents btnBuscadireccion_general As System.Windows.Forms.Button
   Friend WithEvents cmbdireccion_general As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_direccion_general As System.Windows.Forms.Label
   Protected WithEvents dtpfecha_emision As System.Windows.Forms.DateTimePicker
   Friend WithEvents etiquetafecha_emision As System.Windows.Forms.Label
   Protected WithEvents dtpfecha_revision As System.Windows.Forms.DateTimePicker
   Friend WithEvents etiquetafecha_revision As System.Windows.Forms.Label
   Friend WithEvents lblid_firma As System.Windows.Forms.Label
   Friend WithEvents btnBuscafirma As System.Windows.Forms.Button
   Friend WithEvents cmbfirma As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_firma As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
    Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
   Protected WithEvents btnBorrar As System.Windows.Forms.Button
   Protected WithEvents btnModificar As System.Windows.Forms.Button
   Protected WithEvents btnAgregar As System.Windows.Forms.Button
   Protected WithEvents dgv1 As System.Windows.Forms.DataGridView
   Friend WithEvents lblid_pk As System.Windows.Forms.Label
   Friend WithEvents lblid_Presupuesto As System.Windows.Forms.Label
End Class

