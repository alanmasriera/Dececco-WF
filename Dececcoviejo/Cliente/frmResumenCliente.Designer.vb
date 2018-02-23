<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResumenCliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmResumenCliente))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblid_cliente = New System.Windows.Forms.Label()
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.dtpPeriodo = New System.Windows.Forms.DateTimePicker()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.tcGestionCliente = New System.Windows.Forms.TabControl()
        Me.tpPresupuesto = New System.Windows.Forms.TabPage()
        Me.btnBorrar_presupuesto = New System.Windows.Forms.Button()
        Me.btnModificar_presupuesto = New System.Windows.Forms.Button()
        Me.btnAgregarPresupuesto = New System.Windows.Forms.Button()
        Me.txtConsultarPresupuesto = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblid_presupuesto = New System.Windows.Forms.Label()
        Me.dgvPresupuesto = New System.Windows.Forms.DataGridView()
        Me.tpOrdenCompra = New System.Windows.Forms.TabPage()
        Me.btnModificarCompra = New System.Windows.Forms.Button()
        Me.btnAgregarCompra = New System.Windows.Forms.Button()
        Me.txtBuscarCompra = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblid_orden_compra = New System.Windows.Forms.Label()
        Me.dgv_orden_compra = New System.Windows.Forms.DataGridView()
        Me.btnBorrarCompra = New System.Windows.Forms.Button()
        Me.tpFactura = New System.Windows.Forms.TabPage()
        Me.btnItemGlobal = New System.Windows.Forms.Button()
        Me.btnExporta = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblid_pk_Factura = New System.Windows.Forms.Label()
        Me.dgvFactura = New System.Windows.Forms.DataGridView()
        Me.btnAgregar_2 = New System.Windows.Forms.Button()
        Me.btnImrpimirFactura = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.tpRemito = New System.Windows.Forms.TabPage()
        Me.btnModificarRemito = New System.Windows.Forms.Button()
        Me.btnAgregarRemito = New System.Windows.Forms.Button()
        Me.txtBuscarRemito = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblid_remito = New System.Windows.Forms.Label()
        Me.dgv_remito = New System.Windows.Forms.DataGridView()
        Me.btnBorrarRemito = New System.Windows.Forms.Button()
        Me.tpCuentaCorriente = New System.Windows.Forms.TabPage()
        Me.lblid_pk = New System.Windows.Forms.Label()
        Me.btnCierreTodo = New System.Windows.Forms.Button()
        Me.lblFacturacion_mes = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblSaldoAnterior = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblSaldoActual = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtSaldoContable = New System.Windows.Forms.TextBox()
        Me.lblTotalGrilla = New System.Windows.Forms.Label()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.btnGenerarResumen = New System.Windows.Forms.Button()
        Me.btnCierrePeriodo = New System.Windows.Forms.Button()
        Me.btnModificarPeriodo = New System.Windows.Forms.Button()
        Me.btnSaldoActual = New System.Windows.Forms.Button()
        Me.tpPagoCliente = New System.Windows.Forms.TabPage()
        Me.btnAyudaPago = New System.Windows.Forms.Button()
        Me.lblid_pk_PagoCliente = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.lblconsultar = New System.Windows.Forms.Label()
        Me.dgvPagoCliente = New System.Windows.Forms.DataGridView()
        Me.btnBorrarPago = New System.Windows.Forms.Button()
        Me.btnModificarPago = New System.Windows.Forms.Button()
        Me.btnAgregarPago = New System.Windows.Forms.Button()
        Me.tpClientes = New System.Windows.Forms.TabPage()
        Me.lblid_c = New System.Windows.Forms.Label()
        Me.txtBuscarC = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgv_cliente = New System.Windows.Forms.DataGridView()
        Me.btnAyuda = New System.Windows.Forms.Button()
        Me.btnBorrarC = New System.Windows.Forms.Button()
        Me.btnModificarC = New System.Windows.Forms.Button()
        Me.btnAgregarC = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnPago = New System.Windows.Forms.Button()
        Me.btnBuscaCliente = New System.Windows.Forms.Button()
        Me.tcGestionCliente.SuspendLayout()
        Me.tpPresupuesto.SuspendLayout()
        CType(Me.dgvPresupuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpOrdenCompra.SuspendLayout()
        CType(Me.dgv_orden_compra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpFactura.SuspendLayout()
        CType(Me.dgvFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpRemito.SuspendLayout()
        CType(Me.dgv_remito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpCuentaCorriente.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpPagoCliente.SuspendLayout()
        CType(Me.dgvPagoCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpClientes.SuspendLayout()
        CType(Me.dgv_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblid_cliente
        '
        Me.lblid_cliente.AutoSize = True
        Me.lblid_cliente.BackColor = System.Drawing.Color.Red
        Me.lblid_cliente.Location = New System.Drawing.Point(138, 46)
        Me.lblid_cliente.Name = "lblid_cliente"
        Me.lblid_cliente.Size = New System.Drawing.Size(13, 13)
        Me.lblid_cliente.TabIndex = 623
        Me.lblid_cliente.Text = "0"
        Me.lblid_cliente.Visible = False
        '
        'cmbCliente
        '
        Me.cmbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Location = New System.Drawing.Point(116, 42)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(299, 21)
        Me.cmbCliente.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(65, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 15)
        Me.Label1.TabIndex = 622
        Me.Label1.Text = "Cliente"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(541, 45)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(50, 15)
        Me.Label20.TabIndex = 625
        Me.Label20.Text = "Periodo"
        '
        'dtpPeriodo
        '
        Me.dtpPeriodo.CustomFormat = "MMMM - yyyy     -dd"
        Me.dtpPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPeriodo.Location = New System.Drawing.Point(597, 39)
        Me.dtpPeriodo.Name = "dtpPeriodo"
        Me.dtpPeriodo.ShowUpDown = True
        Me.dtpPeriodo.Size = New System.Drawing.Size(162, 26)
        Me.dtpPeriodo.TabIndex = 6
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.Black
        Me.lblTitulo.Location = New System.Drawing.Point(111, 1)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(738, 30)
        Me.lblTitulo.TabIndex = 640
        Me.lblTitulo.Text = "Gestión de Clientes"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tcGestionCliente
        '
        Me.tcGestionCliente.Controls.Add(Me.tpPresupuesto)
        Me.tcGestionCliente.Controls.Add(Me.tpOrdenCompra)
        Me.tcGestionCliente.Controls.Add(Me.tpFactura)
        Me.tcGestionCliente.Controls.Add(Me.tpRemito)
        Me.tcGestionCliente.Controls.Add(Me.tpCuentaCorriente)
        Me.tcGestionCliente.Controls.Add(Me.tpPagoCliente)
        Me.tcGestionCliente.Controls.Add(Me.tpClientes)
        Me.tcGestionCliente.Location = New System.Drawing.Point(12, 76)
        Me.tcGestionCliente.Name = "tcGestionCliente"
        Me.tcGestionCliente.SelectedIndex = 0
        Me.tcGestionCliente.Size = New System.Drawing.Size(992, 541)
        Me.tcGestionCliente.TabIndex = 645
        '
        'tpPresupuesto
        '
        Me.tpPresupuesto.Controls.Add(Me.btnBorrar_presupuesto)
        Me.tpPresupuesto.Controls.Add(Me.btnModificar_presupuesto)
        Me.tpPresupuesto.Controls.Add(Me.btnAgregarPresupuesto)
        Me.tpPresupuesto.Controls.Add(Me.txtConsultarPresupuesto)
        Me.tpPresupuesto.Controls.Add(Me.Label9)
        Me.tpPresupuesto.Controls.Add(Me.lblid_presupuesto)
        Me.tpPresupuesto.Controls.Add(Me.dgvPresupuesto)
        Me.tpPresupuesto.Location = New System.Drawing.Point(4, 22)
        Me.tpPresupuesto.Name = "tpPresupuesto"
        Me.tpPresupuesto.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPresupuesto.Size = New System.Drawing.Size(984, 515)
        Me.tpPresupuesto.TabIndex = 0
        Me.tpPresupuesto.Text = "Presupuesto"
        Me.tpPresupuesto.UseVisualStyleBackColor = True
        '
        'btnBorrar_presupuesto
        '
        Me.btnBorrar_presupuesto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrar_presupuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar_presupuesto.Image = CType(resources.GetObject("btnBorrar_presupuesto.Image"), System.Drawing.Image)
        Me.btnBorrar_presupuesto.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBorrar_presupuesto.Location = New System.Drawing.Point(296, 335)
        Me.btnBorrar_presupuesto.Name = "btnBorrar_presupuesto"
        Me.btnBorrar_presupuesto.Size = New System.Drawing.Size(71, 58)
        Me.btnBorrar_presupuesto.TabIndex = 572
        Me.btnBorrar_presupuesto.Text = "&Borrar"
        Me.btnBorrar_presupuesto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBorrar_presupuesto.UseVisualStyleBackColor = True
        '
        'btnModificar_presupuesto
        '
        Me.btnModificar_presupuesto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar_presupuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar_presupuesto.Image = CType(resources.GetObject("btnModificar_presupuesto.Image"), System.Drawing.Image)
        Me.btnModificar_presupuesto.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModificar_presupuesto.Location = New System.Drawing.Point(164, 335)
        Me.btnModificar_presupuesto.Name = "btnModificar_presupuesto"
        Me.btnModificar_presupuesto.Size = New System.Drawing.Size(71, 58)
        Me.btnModificar_presupuesto.TabIndex = 571
        Me.btnModificar_presupuesto.Text = "&Modificar"
        Me.btnModificar_presupuesto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificar_presupuesto.UseVisualStyleBackColor = True
        '
        'btnAgregarPresupuesto
        '
        Me.btnAgregarPresupuesto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarPresupuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarPresupuesto.Image = CType(resources.GetObject("btnAgregarPresupuesto.Image"), System.Drawing.Image)
        Me.btnAgregarPresupuesto.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAgregarPresupuesto.Location = New System.Drawing.Point(32, 335)
        Me.btnAgregarPresupuesto.Name = "btnAgregarPresupuesto"
        Me.btnAgregarPresupuesto.Size = New System.Drawing.Size(71, 58)
        Me.btnAgregarPresupuesto.TabIndex = 570
        Me.btnAgregarPresupuesto.Text = "&Agregar"
        Me.btnAgregarPresupuesto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregarPresupuesto.UseVisualStyleBackColor = True
        '
        'txtConsultarPresupuesto
        '
        Me.txtConsultarPresupuesto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtConsultarPresupuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConsultarPresupuesto.Location = New System.Drawing.Point(100, 270)
        Me.txtConsultarPresupuesto.Name = "txtConsultarPresupuesto"
        Me.txtConsultarPresupuesto.Size = New System.Drawing.Size(703, 26)
        Me.txtConsultarPresupuesto.TabIndex = 568
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(6, 273)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 20)
        Me.Label9.TabIndex = 569
        Me.Label9.Text = "Consultar"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_presupuesto
        '
        Me.lblid_presupuesto.AutoSize = True
        Me.lblid_presupuesto.BackColor = System.Drawing.Color.Red
        Me.lblid_presupuesto.Location = New System.Drawing.Point(5, 40)
        Me.lblid_presupuesto.Name = "lblid_presupuesto"
        Me.lblid_presupuesto.Size = New System.Drawing.Size(13, 13)
        Me.lblid_presupuesto.TabIndex = 567
        Me.lblid_presupuesto.Text = "0"
        Me.lblid_presupuesto.Visible = False
        '
        'dgvPresupuesto
        '
        Me.dgvPresupuesto.AllowUserToAddRows = False
        Me.dgvPresupuesto.AllowUserToResizeColumns = False
        Me.dgvPresupuesto.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Brown
        Me.dgvPresupuesto.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPresupuesto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvPresupuesto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvPresupuesto.BackgroundColor = System.Drawing.Color.Silver
        Me.dgvPresupuesto.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPresupuesto.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPresupuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Beige
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Brown
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPresupuesto.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvPresupuesto.GridColor = System.Drawing.Color.MediumPurple
        Me.dgvPresupuesto.Location = New System.Drawing.Point(8, 26)
        Me.dgvPresupuesto.Name = "dgvPresupuesto"
        Me.dgvPresupuesto.ReadOnly = True
        Me.dgvPresupuesto.ShowCellErrors = False
        Me.dgvPresupuesto.ShowRowErrors = False
        Me.dgvPresupuesto.Size = New System.Drawing.Size(933, 232)
        Me.dgvPresupuesto.StandardTab = True
        Me.dgvPresupuesto.TabIndex = 566
        '
        'tpOrdenCompra
        '
        Me.tpOrdenCompra.Controls.Add(Me.btnModificarCompra)
        Me.tpOrdenCompra.Controls.Add(Me.btnAgregarCompra)
        Me.tpOrdenCompra.Controls.Add(Me.txtBuscarCompra)
        Me.tpOrdenCompra.Controls.Add(Me.Label6)
        Me.tpOrdenCompra.Controls.Add(Me.lblid_orden_compra)
        Me.tpOrdenCompra.Controls.Add(Me.dgv_orden_compra)
        Me.tpOrdenCompra.Controls.Add(Me.btnBorrarCompra)
        Me.tpOrdenCompra.Location = New System.Drawing.Point(4, 22)
        Me.tpOrdenCompra.Name = "tpOrdenCompra"
        Me.tpOrdenCompra.Padding = New System.Windows.Forms.Padding(3)
        Me.tpOrdenCompra.Size = New System.Drawing.Size(984, 515)
        Me.tpOrdenCompra.TabIndex = 1
        Me.tpOrdenCompra.Text = "Orden Compra"
        Me.tpOrdenCompra.UseVisualStyleBackColor = True
        '
        'btnModificarCompra
        '
        Me.btnModificarCompra.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificarCompra.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarCompra.Image = CType(resources.GetObject("btnModificarCompra.Image"), System.Drawing.Image)
        Me.btnModificarCompra.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModificarCompra.Location = New System.Drawing.Point(459, 384)
        Me.btnModificarCompra.Name = "btnModificarCompra"
        Me.btnModificarCompra.Size = New System.Drawing.Size(86, 91)
        Me.btnModificarCompra.TabIndex = 569
        Me.btnModificarCompra.Text = "&Modificar"
        Me.btnModificarCompra.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificarCompra.UseVisualStyleBackColor = True
        '
        'btnAgregarCompra
        '
        Me.btnAgregarCompra.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarCompra.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarCompra.Image = CType(resources.GetObject("btnAgregarCompra.Image"), System.Drawing.Image)
        Me.btnAgregarCompra.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAgregarCompra.Location = New System.Drawing.Point(327, 384)
        Me.btnAgregarCompra.Name = "btnAgregarCompra"
        Me.btnAgregarCompra.Size = New System.Drawing.Size(86, 91)
        Me.btnAgregarCompra.TabIndex = 568
        Me.btnAgregarCompra.Text = "&Agregar"
        Me.btnAgregarCompra.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregarCompra.UseVisualStyleBackColor = True
        '
        'txtBuscarCompra
        '
        Me.txtBuscarCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscarCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarCompra.Location = New System.Drawing.Point(125, 337)
        Me.txtBuscarCompra.Name = "txtBuscarCompra"
        Me.txtBuscarCompra.Size = New System.Drawing.Size(841, 26)
        Me.txtBuscarCompra.TabIndex = 572
        Me.txtBuscarCompra.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(12, 337)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 26)
        Me.Label6.TabIndex = 574
        Me.Label6.Text = "Consultar"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Visible = False
        '
        'lblid_orden_compra
        '
        Me.lblid_orden_compra.AutoSize = True
        Me.lblid_orden_compra.BackColor = System.Drawing.Color.Red
        Me.lblid_orden_compra.Location = New System.Drawing.Point(9, 26)
        Me.lblid_orden_compra.Name = "lblid_orden_compra"
        Me.lblid_orden_compra.Size = New System.Drawing.Size(13, 13)
        Me.lblid_orden_compra.TabIndex = 573
        Me.lblid_orden_compra.Text = "0"
        Me.lblid_orden_compra.Visible = False
        '
        'dgv_orden_compra
        '
        Me.dgv_orden_compra.AllowUserToAddRows = False
        Me.dgv_orden_compra.AllowUserToResizeColumns = False
        Me.dgv_orden_compra.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Brown
        Me.dgv_orden_compra.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_orden_compra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_orden_compra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_orden_compra.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.dgv_orden_compra.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_orden_compra.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_orden_compra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Beige
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Brown
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_orden_compra.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_orden_compra.GridColor = System.Drawing.Color.MediumPurple
        Me.dgv_orden_compra.Location = New System.Drawing.Point(6, 6)
        Me.dgv_orden_compra.Name = "dgv_orden_compra"
        Me.dgv_orden_compra.ReadOnly = True
        Me.dgv_orden_compra.ShowCellErrors = False
        Me.dgv_orden_compra.ShowRowErrors = False
        Me.dgv_orden_compra.Size = New System.Drawing.Size(960, 315)
        Me.dgv_orden_compra.StandardTab = True
        Me.dgv_orden_compra.TabIndex = 571
        '
        'btnBorrarCompra
        '
        Me.btnBorrarCompra.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrarCompra.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarCompra.Image = CType(resources.GetObject("btnBorrarCompra.Image"), System.Drawing.Image)
        Me.btnBorrarCompra.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBorrarCompra.Location = New System.Drawing.Point(591, 384)
        Me.btnBorrarCompra.Name = "btnBorrarCompra"
        Me.btnBorrarCompra.Size = New System.Drawing.Size(86, 91)
        Me.btnBorrarCompra.TabIndex = 570
        Me.btnBorrarCompra.Text = "&Borrar"
        Me.btnBorrarCompra.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBorrarCompra.UseVisualStyleBackColor = True
        '
        'tpFactura
        '
        Me.tpFactura.Controls.Add(Me.btnItemGlobal)
        Me.tpFactura.Controls.Add(Me.btnExporta)
        Me.tpFactura.Controls.Add(Me.Label2)
        Me.tpFactura.Controls.Add(Me.TextBox1)
        Me.tpFactura.Controls.Add(Me.lblid_pk_Factura)
        Me.tpFactura.Controls.Add(Me.dgvFactura)
        Me.tpFactura.Controls.Add(Me.btnAgregar_2)
        Me.tpFactura.Controls.Add(Me.btnImrpimirFactura)
        Me.tpFactura.Controls.Add(Me.btnBorrar)
        Me.tpFactura.Controls.Add(Me.btnModificar)
        Me.tpFactura.Controls.Add(Me.btnAgregar)
        Me.tpFactura.Location = New System.Drawing.Point(4, 22)
        Me.tpFactura.Name = "tpFactura"
        Me.tpFactura.Size = New System.Drawing.Size(984, 515)
        Me.tpFactura.TabIndex = 2
        Me.tpFactura.Text = "Factura"
        Me.tpFactura.UseVisualStyleBackColor = True
        '
        'btnItemGlobal
        '
        Me.btnItemGlobal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnItemGlobal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItemGlobal.Image = CType(resources.GetObject("btnItemGlobal.Image"), System.Drawing.Image)
        Me.btnItemGlobal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnItemGlobal.Location = New System.Drawing.Point(314, 393)
        Me.btnItemGlobal.Name = "btnItemGlobal"
        Me.btnItemGlobal.Size = New System.Drawing.Size(96, 71)
        Me.btnItemGlobal.TabIndex = 16
        Me.btnItemGlobal.Text = "&Item Global"
        Me.btnItemGlobal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnItemGlobal.UseVisualStyleBackColor = True
        '
        'btnExporta
        '
        Me.btnExporta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExporta.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExporta.Image = CType(resources.GetObject("btnExporta.Image"), System.Drawing.Image)
        Me.btnExporta.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExporta.Location = New System.Drawing.Point(425, 393)
        Me.btnExporta.Name = "btnExporta"
        Me.btnExporta.Size = New System.Drawing.Size(39, 71)
        Me.btnExporta.TabIndex = 15
        Me.btnExporta.Text = "Fac.""&E"""
        Me.btnExporta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExporta.UseVisualStyleBackColor = True
        Me.btnExporta.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(26, 337)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 24)
        Me.Label2.TabIndex = 572
        Me.Label2.Text = "Consultar"
        Me.Label2.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Location = New System.Drawing.Point(125, 341)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(762, 20)
        Me.TextBox1.TabIndex = 569
        Me.TextBox1.Visible = False
        '
        'lblid_pk_Factura
        '
        Me.lblid_pk_Factura.AutoSize = True
        Me.lblid_pk_Factura.BackColor = System.Drawing.Color.Red
        Me.lblid_pk_Factura.Location = New System.Drawing.Point(46, 17)
        Me.lblid_pk_Factura.Name = "lblid_pk_Factura"
        Me.lblid_pk_Factura.Size = New System.Drawing.Size(13, 13)
        Me.lblid_pk_Factura.TabIndex = 571
        Me.lblid_pk_Factura.Text = "0"
        Me.lblid_pk_Factura.Visible = False
        '
        'dgvFactura
        '
        Me.dgvFactura.AllowUserToAddRows = False
        Me.dgvFactura.AllowUserToResizeColumns = False
        Me.dgvFactura.AllowUserToResizeRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Brown
        Me.dgvFactura.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvFactura.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvFactura.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.dgvFactura.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFactura.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Beige
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Brown
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvFactura.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvFactura.GridColor = System.Drawing.Color.MediumPurple
        Me.dgvFactura.Location = New System.Drawing.Point(14, 17)
        Me.dgvFactura.Name = "dgvFactura"
        Me.dgvFactura.ReadOnly = True
        Me.dgvFactura.ShowCellErrors = False
        Me.dgvFactura.ShowRowErrors = False
        Me.dgvFactura.Size = New System.Drawing.Size(912, 304)
        Me.dgvFactura.StandardTab = True
        Me.dgvFactura.TabIndex = 568
        '
        'btnAgregar_2
        '
        Me.btnAgregar_2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar_2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar_2.Image = CType(resources.GetObject("btnAgregar_2.Image"), System.Drawing.Image)
        Me.btnAgregar_2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAgregar_2.Location = New System.Drawing.Point(202, 393)
        Me.btnAgregar_2.Name = "btnAgregar_2"
        Me.btnAgregar_2.Size = New System.Drawing.Size(96, 71)
        Me.btnAgregar_2.TabIndex = 11
        Me.btnAgregar_2.Text = "Fac.&Global"
        Me.btnAgregar_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregar_2.UseVisualStyleBackColor = True
        Me.btnAgregar_2.Visible = False
        '
        'btnImrpimirFactura
        '
        Me.btnImrpimirFactura.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImrpimirFactura.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImrpimirFactura.ForeColor = System.Drawing.Color.Black
        Me.btnImrpimirFactura.Image = CType(resources.GetObject("btnImrpimirFactura.Image"), System.Drawing.Image)
        Me.btnImrpimirFactura.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImrpimirFactura.Location = New System.Drawing.Point(705, 395)
        Me.btnImrpimirFactura.Name = "btnImrpimirFactura"
        Me.btnImrpimirFactura.Size = New System.Drawing.Size(81, 69)
        Me.btnImrpimirFactura.TabIndex = 12
        Me.btnImrpimirFactura.Text = "&Imprimir"
        Me.btnImrpimirFactura.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImrpimirFactura.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar.Image = CType(resources.GetObject("btnBorrar.Image"), System.Drawing.Image)
        Me.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBorrar.Location = New System.Drawing.Point(602, 395)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(86, 71)
        Me.btnBorrar.TabIndex = 10
        Me.btnBorrar.Text = "A&nular"
        Me.btnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModificar.Location = New System.Drawing.Point(489, 393)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(86, 71)
        Me.btnModificar.TabIndex = 9
        Me.btnModificar.Text = "&Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAgregar.Location = New System.Drawing.Point(100, 393)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(96, 71)
        Me.btnAgregar.TabIndex = 8
        Me.btnAgregar.Text = "Fac.&Item"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregar.UseVisualStyleBackColor = True
        Me.btnAgregar.Visible = False
        '
        'tpRemito
        '
        Me.tpRemito.Controls.Add(Me.btnModificarRemito)
        Me.tpRemito.Controls.Add(Me.btnAgregarRemito)
        Me.tpRemito.Controls.Add(Me.txtBuscarRemito)
        Me.tpRemito.Controls.Add(Me.Label7)
        Me.tpRemito.Controls.Add(Me.lblid_remito)
        Me.tpRemito.Controls.Add(Me.dgv_remito)
        Me.tpRemito.Controls.Add(Me.btnBorrarRemito)
        Me.tpRemito.Location = New System.Drawing.Point(4, 22)
        Me.tpRemito.Name = "tpRemito"
        Me.tpRemito.Size = New System.Drawing.Size(984, 515)
        Me.tpRemito.TabIndex = 3
        Me.tpRemito.Text = "Remito"
        Me.tpRemito.UseVisualStyleBackColor = True
        '
        'btnModificarRemito
        '
        Me.btnModificarRemito.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificarRemito.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarRemito.Image = CType(resources.GetObject("btnModificarRemito.Image"), System.Drawing.Image)
        Me.btnModificarRemito.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModificarRemito.Location = New System.Drawing.Point(430, 421)
        Me.btnModificarRemito.Name = "btnModificarRemito"
        Me.btnModificarRemito.Size = New System.Drawing.Size(86, 72)
        Me.btnModificarRemito.TabIndex = 569
        Me.btnModificarRemito.Text = "&Modificar"
        Me.btnModificarRemito.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificarRemito.UseVisualStyleBackColor = True
        '
        'btnAgregarRemito
        '
        Me.btnAgregarRemito.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarRemito.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarRemito.Image = CType(resources.GetObject("btnAgregarRemito.Image"), System.Drawing.Image)
        Me.btnAgregarRemito.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAgregarRemito.Location = New System.Drawing.Point(298, 421)
        Me.btnAgregarRemito.Name = "btnAgregarRemito"
        Me.btnAgregarRemito.Size = New System.Drawing.Size(86, 72)
        Me.btnAgregarRemito.TabIndex = 568
        Me.btnAgregarRemito.Text = "&Agregar"
        Me.btnAgregarRemito.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregarRemito.UseVisualStyleBackColor = True
        '
        'txtBuscarRemito
        '
        Me.txtBuscarRemito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscarRemito.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarRemito.Location = New System.Drawing.Point(115, 375)
        Me.txtBuscarRemito.Name = "txtBuscarRemito"
        Me.txtBuscarRemito.Size = New System.Drawing.Size(847, 26)
        Me.txtBuscarRemito.TabIndex = 572
        Me.txtBuscarRemito.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(8, 375)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 26)
        Me.Label7.TabIndex = 574
        Me.Label7.Text = "Consultar"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.Visible = False
        '
        'lblid_remito
        '
        Me.lblid_remito.AutoSize = True
        Me.lblid_remito.BackColor = System.Drawing.Color.Red
        Me.lblid_remito.Location = New System.Drawing.Point(5, 48)
        Me.lblid_remito.Name = "lblid_remito"
        Me.lblid_remito.Size = New System.Drawing.Size(13, 13)
        Me.lblid_remito.TabIndex = 573
        Me.lblid_remito.Text = "0"
        Me.lblid_remito.Visible = False
        '
        'dgv_remito
        '
        Me.dgv_remito.AllowUserToAddRows = False
        Me.dgv_remito.AllowUserToResizeColumns = False
        Me.dgv_remito.AllowUserToResizeRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Brown
        Me.dgv_remito.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgv_remito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_remito.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_remito.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.dgv_remito.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_remito.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgv_remito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Beige
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Brown
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_remito.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgv_remito.GridColor = System.Drawing.Color.MediumPurple
        Me.dgv_remito.Location = New System.Drawing.Point(8, 3)
        Me.dgv_remito.Name = "dgv_remito"
        Me.dgv_remito.ReadOnly = True
        Me.dgv_remito.ShowCellErrors = False
        Me.dgv_remito.ShowRowErrors = False
        Me.dgv_remito.Size = New System.Drawing.Size(964, 359)
        Me.dgv_remito.StandardTab = True
        Me.dgv_remito.TabIndex = 571
        '
        'btnBorrarRemito
        '
        Me.btnBorrarRemito.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrarRemito.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarRemito.Image = CType(resources.GetObject("btnBorrarRemito.Image"), System.Drawing.Image)
        Me.btnBorrarRemito.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBorrarRemito.Location = New System.Drawing.Point(562, 421)
        Me.btnBorrarRemito.Name = "btnBorrarRemito"
        Me.btnBorrarRemito.Size = New System.Drawing.Size(86, 72)
        Me.btnBorrarRemito.TabIndex = 570
        Me.btnBorrarRemito.Text = "&Borrar"
        Me.btnBorrarRemito.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBorrarRemito.UseVisualStyleBackColor = True
        '
        'tpCuentaCorriente
        '
        Me.tpCuentaCorriente.Controls.Add(Me.lblid_pk)
        Me.tpCuentaCorriente.Controls.Add(Me.btnCierreTodo)
        Me.tpCuentaCorriente.Controls.Add(Me.lblFacturacion_mes)
        Me.tpCuentaCorriente.Controls.Add(Me.Label3)
        Me.tpCuentaCorriente.Controls.Add(Me.Label11)
        Me.tpCuentaCorriente.Controls.Add(Me.lblSaldoAnterior)
        Me.tpCuentaCorriente.Controls.Add(Me.Label13)
        Me.tpCuentaCorriente.Controls.Add(Me.lblSaldoActual)
        Me.tpCuentaCorriente.Controls.Add(Me.Label21)
        Me.tpCuentaCorriente.Controls.Add(Me.txtSaldoContable)
        Me.tpCuentaCorriente.Controls.Add(Me.lblTotalGrilla)
        Me.tpCuentaCorriente.Controls.Add(Me.dgv1)
        Me.tpCuentaCorriente.Controls.Add(Me.btnGenerarResumen)
        Me.tpCuentaCorriente.Controls.Add(Me.btnCierrePeriodo)
        Me.tpCuentaCorriente.Controls.Add(Me.btnModificarPeriodo)
        Me.tpCuentaCorriente.Controls.Add(Me.btnSaldoActual)
        Me.tpCuentaCorriente.Location = New System.Drawing.Point(4, 22)
        Me.tpCuentaCorriente.Name = "tpCuentaCorriente"
        Me.tpCuentaCorriente.Size = New System.Drawing.Size(984, 515)
        Me.tpCuentaCorriente.TabIndex = 4
        Me.tpCuentaCorriente.Text = "Cuenta Corriente"
        Me.tpCuentaCorriente.UseVisualStyleBackColor = True
        '
        'lblid_pk
        '
        Me.lblid_pk.AutoSize = True
        Me.lblid_pk.BackColor = System.Drawing.Color.Red
        Me.lblid_pk.Location = New System.Drawing.Point(55, 113)
        Me.lblid_pk.Name = "lblid_pk"
        Me.lblid_pk.Size = New System.Drawing.Size(13, 13)
        Me.lblid_pk.TabIndex = 650
        Me.lblid_pk.Text = "0"
        Me.lblid_pk.Visible = False
        '
        'btnCierreTodo
        '
        Me.btnCierreTodo.BackColor = System.Drawing.Color.Gainsboro
        Me.btnCierreTodo.Location = New System.Drawing.Point(723, 34)
        Me.btnCierreTodo.Name = "btnCierreTodo"
        Me.btnCierreTodo.Size = New System.Drawing.Size(219, 23)
        Me.btnCierreTodo.TabIndex = 660
        Me.btnCierreTodo.Text = "Cerrar el Periodo para Todos los Clientes"
        Me.btnCierreTodo.UseVisualStyleBackColor = False
        '
        'lblFacturacion_mes
        '
        Me.lblFacturacion_mes.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblFacturacion_mes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFacturacion_mes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblFacturacion_mes.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFacturacion_mes.ForeColor = System.Drawing.Color.Blue
        Me.lblFacturacion_mes.Location = New System.Drawing.Point(722, 320)
        Me.lblFacturacion_mes.Name = "lblFacturacion_mes"
        Me.lblFacturacion_mes.Size = New System.Drawing.Size(220, 29)
        Me.lblFacturacion_mes.TabIndex = 659
        Me.lblFacturacion_mes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.LightBlue
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(722, 301)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(220, 19)
        Me.Label3.TabIndex = 658
        Me.Label3.Text = "Total Vendido"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.LightBlue
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(723, 76)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(220, 19)
        Me.Label11.TabIndex = 651
        Me.Label11.Text = "Saldo del Periodo Anterior"
        '
        'lblSaldoAnterior
        '
        Me.lblSaldoAnterior.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSaldoAnterior.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSaldoAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSaldoAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldoAnterior.ForeColor = System.Drawing.Color.Blue
        Me.lblSaldoAnterior.Location = New System.Drawing.Point(723, 95)
        Me.lblSaldoAnterior.Name = "lblSaldoAnterior"
        Me.lblSaldoAnterior.Size = New System.Drawing.Size(220, 29)
        Me.lblSaldoAnterior.TabIndex = 652
        Me.lblSaldoAnterior.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.LightBlue
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(723, 196)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(220, 19)
        Me.Label13.TabIndex = 653
        Me.Label13.Text = "Saldo Actual"
        '
        'lblSaldoActual
        '
        Me.lblSaldoActual.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSaldoActual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSaldoActual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSaldoActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldoActual.ForeColor = System.Drawing.Color.Blue
        Me.lblSaldoActual.Location = New System.Drawing.Point(723, 215)
        Me.lblSaldoActual.Name = "lblSaldoActual"
        Me.lblSaldoActual.Size = New System.Drawing.Size(220, 29)
        Me.lblSaldoActual.TabIndex = 654
        Me.lblSaldoActual.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.LightBlue
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(722, 445)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(220, 19)
        Me.Label21.TabIndex = 657
        Me.Label21.Text = "Saldo Contable"
        Me.Label21.Visible = False
        '
        'txtSaldoContable
        '
        Me.txtSaldoContable.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSaldoContable.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoContable.ForeColor = System.Drawing.Color.Blue
        Me.txtSaldoContable.Location = New System.Drawing.Point(722, 467)
        Me.txtSaldoContable.Name = "txtSaldoContable"
        Me.txtSaldoContable.ReadOnly = True
        Me.txtSaldoContable.Size = New System.Drawing.Size(220, 31)
        Me.txtSaldoContable.TabIndex = 656
        Me.txtSaldoContable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSaldoContable.Visible = False
        '
        'lblTotalGrilla
        '
        Me.lblTotalGrilla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalGrilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTotalGrilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalGrilla.Location = New System.Drawing.Point(577, 47)
        Me.lblTotalGrilla.Name = "lblTotalGrilla"
        Me.lblTotalGrilla.Size = New System.Drawing.Size(29, 17)
        Me.lblTotalGrilla.TabIndex = 655
        Me.lblTotalGrilla.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTotalGrilla.Visible = False
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToResizeColumns = False
        Me.dgv1.AllowUserToResizeRows = False
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Brown
        Me.dgv1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv1.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.dgv1.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Beige
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Brown
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv1.DefaultCellStyle = DataGridViewCellStyle15
        Me.dgv1.GridColor = System.Drawing.Color.MediumPurple
        Me.dgv1.Location = New System.Drawing.Point(29, 67)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.ShowCellErrors = False
        Me.dgv1.ShowRowErrors = False
        Me.dgv1.Size = New System.Drawing.Size(676, 394)
        Me.dgv1.StandardTab = True
        Me.dgv1.TabIndex = 649
        '
        'btnGenerarResumen
        '
        Me.btnGenerarResumen.BackColor = System.Drawing.SystemColors.Control
        Me.btnGenerarResumen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarResumen.Image = CType(resources.GetObject("btnGenerarResumen.Image"), System.Drawing.Image)
        Me.btnGenerarResumen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenerarResumen.Location = New System.Drawing.Point(723, 133)
        Me.btnGenerarResumen.Name = "btnGenerarResumen"
        Me.btnGenerarResumen.Size = New System.Drawing.Size(220, 30)
        Me.btnGenerarResumen.TabIndex = 645
        Me.btnGenerarResumen.Text = "Generar Resumen     "
        Me.btnGenerarResumen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenerarResumen.UseVisualStyleBackColor = True
        '
        'btnCierrePeriodo
        '
        Me.btnCierrePeriodo.BackColor = System.Drawing.SystemColors.Control
        Me.btnCierrePeriodo.Image = CType(resources.GetObject("btnCierrePeriodo.Image"), System.Drawing.Image)
        Me.btnCierrePeriodo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCierrePeriodo.Location = New System.Drawing.Point(723, 361)
        Me.btnCierrePeriodo.Name = "btnCierrePeriodo"
        Me.btnCierrePeriodo.Size = New System.Drawing.Size(102, 72)
        Me.btnCierrePeriodo.TabIndex = 647
        Me.btnCierrePeriodo.Text = "Cerrar Periodo"
        Me.btnCierrePeriodo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCierrePeriodo.UseVisualStyleBackColor = True
        '
        'btnModificarPeriodo
        '
        Me.btnModificarPeriodo.BackColor = System.Drawing.SystemColors.Control
        Me.btnModificarPeriodo.Image = CType(resources.GetObject("btnModificarPeriodo.Image"), System.Drawing.Image)
        Me.btnModificarPeriodo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModificarPeriodo.Location = New System.Drawing.Point(840, 361)
        Me.btnModificarPeriodo.Name = "btnModificarPeriodo"
        Me.btnModificarPeriodo.Size = New System.Drawing.Size(102, 72)
        Me.btnModificarPeriodo.TabIndex = 648
        Me.btnModificarPeriodo.Text = "Modificar Periodo"
        Me.btnModificarPeriodo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificarPeriodo.UseVisualStyleBackColor = True
        '
        'btnSaldoActual
        '
        Me.btnSaldoActual.BackColor = System.Drawing.SystemColors.Control
        Me.btnSaldoActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaldoActual.Image = CType(resources.GetObject("btnSaldoActual.Image"), System.Drawing.Image)
        Me.btnSaldoActual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSaldoActual.Location = New System.Drawing.Point(723, 254)
        Me.btnSaldoActual.Name = "btnSaldoActual"
        Me.btnSaldoActual.Size = New System.Drawing.Size(220, 27)
        Me.btnSaldoActual.TabIndex = 646
        Me.btnSaldoActual.Text = "Calcular Saldo Actual    "
        Me.btnSaldoActual.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSaldoActual.UseVisualStyleBackColor = True
        '
        'tpPagoCliente
        '
        Me.tpPagoCliente.Controls.Add(Me.btnAyudaPago)
        Me.tpPagoCliente.Controls.Add(Me.lblid_pk_PagoCliente)
        Me.tpPagoCliente.Controls.Add(Me.txtBuscar)
        Me.tpPagoCliente.Controls.Add(Me.lblconsultar)
        Me.tpPagoCliente.Controls.Add(Me.dgvPagoCliente)
        Me.tpPagoCliente.Controls.Add(Me.btnBorrarPago)
        Me.tpPagoCliente.Controls.Add(Me.btnModificarPago)
        Me.tpPagoCliente.Controls.Add(Me.btnAgregarPago)
        Me.tpPagoCliente.Location = New System.Drawing.Point(4, 22)
        Me.tpPagoCliente.Name = "tpPagoCliente"
        Me.tpPagoCliente.Size = New System.Drawing.Size(984, 515)
        Me.tpPagoCliente.TabIndex = 5
        Me.tpPagoCliente.Text = "Pago Cliente"
        Me.tpPagoCliente.UseVisualStyleBackColor = True
        '
        'btnAyudaPago
        '
        Me.btnAyudaPago.BackColor = System.Drawing.Color.Gainsboro
        Me.btnAyudaPago.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAyudaPago.ForeColor = System.Drawing.Color.Black
        Me.btnAyudaPago.Image = CType(resources.GetObject("btnAyudaPago.Image"), System.Drawing.Image)
        Me.btnAyudaPago.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAyudaPago.Location = New System.Drawing.Point(730, 416)
        Me.btnAyudaPago.Name = "btnAyudaPago"
        Me.btnAyudaPago.Size = New System.Drawing.Size(86, 78)
        Me.btnAyudaPago.TabIndex = 11
        Me.btnAyudaPago.Text = "A&yuda"
        Me.btnAyudaPago.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAyudaPago.UseVisualStyleBackColor = True
        '
        'lblid_pk_PagoCliente
        '
        Me.lblid_pk_PagoCliente.AutoSize = True
        Me.lblid_pk_PagoCliente.BackColor = System.Drawing.Color.Red
        Me.lblid_pk_PagoCliente.Location = New System.Drawing.Point(40, 31)
        Me.lblid_pk_PagoCliente.Name = "lblid_pk_PagoCliente"
        Me.lblid_pk_PagoCliente.Size = New System.Drawing.Size(13, 13)
        Me.lblid_pk_PagoCliente.TabIndex = 646
        Me.lblid_pk_PagoCliente.Text = "0"
        Me.lblid_pk_PagoCliente.Visible = False
        '
        'txtBuscar
        '
        Me.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(106, 365)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(873, 26)
        Me.txtBuscar.TabIndex = 569
        Me.txtBuscar.Visible = False
        '
        'lblconsultar
        '
        Me.lblconsultar.AutoSize = True
        Me.lblconsultar.BackColor = System.Drawing.Color.Transparent
        Me.lblconsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblconsultar.ForeColor = System.Drawing.Color.Black
        Me.lblconsultar.Location = New System.Drawing.Point(17, 368)
        Me.lblconsultar.Name = "lblconsultar"
        Me.lblconsultar.Size = New System.Drawing.Size(77, 20)
        Me.lblconsultar.TabIndex = 571
        Me.lblconsultar.Text = "Consultar"
        Me.lblconsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblconsultar.Visible = False
        '
        'dgvPagoCliente
        '
        Me.dgvPagoCliente.AllowUserToAddRows = False
        Me.dgvPagoCliente.AllowUserToResizeColumns = False
        Me.dgvPagoCliente.AllowUserToResizeRows = False
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Brown
        Me.dgvPagoCliente.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        Me.dgvPagoCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvPagoCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvPagoCliente.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.dgvPagoCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPagoCliente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.dgvPagoCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Beige
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Brown
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPagoCliente.DefaultCellStyle = DataGridViewCellStyle18
        Me.dgvPagoCliente.GridColor = System.Drawing.Color.MediumPurple
        Me.dgvPagoCliente.Location = New System.Drawing.Point(21, 18)
        Me.dgvPagoCliente.Name = "dgvPagoCliente"
        Me.dgvPagoCliente.ReadOnly = True
        Me.dgvPagoCliente.ShowCellErrors = False
        Me.dgvPagoCliente.ShowRowErrors = False
        Me.dgvPagoCliente.Size = New System.Drawing.Size(933, 335)
        Me.dgvPagoCliente.StandardTab = True
        Me.dgvPagoCliente.TabIndex = 568
        '
        'btnBorrarPago
        '
        Me.btnBorrarPago.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrarPago.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarPago.Image = CType(resources.GetObject("btnBorrarPago.Image"), System.Drawing.Image)
        Me.btnBorrarPago.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBorrarPago.Location = New System.Drawing.Point(307, 416)
        Me.btnBorrarPago.Name = "btnBorrarPago"
        Me.btnBorrarPago.Size = New System.Drawing.Size(86, 78)
        Me.btnBorrarPago.TabIndex = 10
        Me.btnBorrarPago.Text = "&Borrar"
        Me.btnBorrarPago.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBorrarPago.UseVisualStyleBackColor = True
        '
        'btnModificarPago
        '
        Me.btnModificarPago.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificarPago.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarPago.Image = CType(resources.GetObject("btnModificarPago.Image"), System.Drawing.Image)
        Me.btnModificarPago.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModificarPago.Location = New System.Drawing.Point(175, 416)
        Me.btnModificarPago.Name = "btnModificarPago"
        Me.btnModificarPago.Size = New System.Drawing.Size(86, 78)
        Me.btnModificarPago.TabIndex = 9
        Me.btnModificarPago.Text = "&Modificar"
        Me.btnModificarPago.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificarPago.UseVisualStyleBackColor = True
        '
        'btnAgregarPago
        '
        Me.btnAgregarPago.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarPago.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarPago.Image = CType(resources.GetObject("btnAgregarPago.Image"), System.Drawing.Image)
        Me.btnAgregarPago.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAgregarPago.Location = New System.Drawing.Point(43, 416)
        Me.btnAgregarPago.Name = "btnAgregarPago"
        Me.btnAgregarPago.Size = New System.Drawing.Size(86, 78)
        Me.btnAgregarPago.TabIndex = 8
        Me.btnAgregarPago.Text = "&Agregar"
        Me.btnAgregarPago.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregarPago.UseVisualStyleBackColor = True
        '
        'tpClientes
        '
        Me.tpClientes.Controls.Add(Me.lblid_c)
        Me.tpClientes.Controls.Add(Me.txtBuscarC)
        Me.tpClientes.Controls.Add(Me.Label4)
        Me.tpClientes.Controls.Add(Me.Label5)
        Me.tpClientes.Controls.Add(Me.dgv_cliente)
        Me.tpClientes.Controls.Add(Me.btnAyuda)
        Me.tpClientes.Controls.Add(Me.btnBorrarC)
        Me.tpClientes.Controls.Add(Me.btnModificarC)
        Me.tpClientes.Controls.Add(Me.btnAgregarC)
        Me.tpClientes.Location = New System.Drawing.Point(4, 22)
        Me.tpClientes.Name = "tpClientes"
        Me.tpClientes.Padding = New System.Windows.Forms.Padding(3)
        Me.tpClientes.Size = New System.Drawing.Size(984, 515)
        Me.tpClientes.TabIndex = 6
        Me.tpClientes.Text = "Clientes"
        Me.tpClientes.UseVisualStyleBackColor = True
        '
        'lblid_c
        '
        Me.lblid_c.AutoSize = True
        Me.lblid_c.BackColor = System.Drawing.Color.Red
        Me.lblid_c.Location = New System.Drawing.Point(6, 17)
        Me.lblid_c.Name = "lblid_c"
        Me.lblid_c.Size = New System.Drawing.Size(13, 13)
        Me.lblid_c.TabIndex = 577
        Me.lblid_c.Text = "0"
        Me.lblid_c.Visible = False
        '
        'txtBuscarC
        '
        Me.txtBuscarC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscarC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarC.Location = New System.Drawing.Point(125, 385)
        Me.txtBuscarC.Name = "txtBuscarC"
        Me.txtBuscarC.Size = New System.Drawing.Size(836, 26)
        Me.txtBuscarC.TabIndex = 574
        Me.txtBuscarC.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(12, 385)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 26)
        Me.Label4.TabIndex = 576
        Me.Label4.Text = "Consultar"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(18, -16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 13)
        Me.Label5.TabIndex = 575
        Me.Label5.Text = "0"
        Me.Label5.Visible = False
        '
        'dgv_cliente
        '
        Me.dgv_cliente.AllowUserToAddRows = False
        Me.dgv_cliente.AllowUserToResizeColumns = False
        Me.dgv_cliente.AllowUserToResizeRows = False
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Brown
        Me.dgv_cliente.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle19
        Me.dgv_cliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_cliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_cliente.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.dgv_cliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_cliente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle20
        Me.dgv_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.Beige
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Brown
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_cliente.DefaultCellStyle = DataGridViewCellStyle21
        Me.dgv_cliente.GridColor = System.Drawing.Color.MediumPurple
        Me.dgv_cliente.Location = New System.Drawing.Point(12, 6)
        Me.dgv_cliente.Name = "dgv_cliente"
        Me.dgv_cliente.ReadOnly = True
        Me.dgv_cliente.ShowCellErrors = False
        Me.dgv_cliente.ShowRowErrors = False
        Me.dgv_cliente.Size = New System.Drawing.Size(949, 363)
        Me.dgv_cliente.StandardTab = True
        Me.dgv_cliente.TabIndex = 573
        '
        'btnAyuda
        '
        Me.btnAyuda.BackColor = System.Drawing.Color.Gainsboro
        Me.btnAyuda.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAyuda.ForeColor = System.Drawing.Color.Black
        Me.btnAyuda.Image = CType(resources.GetObject("btnAyuda.Image"), System.Drawing.Image)
        Me.btnAyuda.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAyuda.Location = New System.Drawing.Point(833, 437)
        Me.btnAyuda.Name = "btnAyuda"
        Me.btnAyuda.Size = New System.Drawing.Size(86, 72)
        Me.btnAyuda.TabIndex = 571
        Me.btnAyuda.Text = "A&yuda"
        Me.btnAyuda.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAyuda.UseVisualStyleBackColor = True
        Me.btnAyuda.Visible = False
        '
        'btnBorrarC
        '
        Me.btnBorrarC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrarC.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarC.Image = CType(resources.GetObject("btnBorrarC.Image"), System.Drawing.Image)
        Me.btnBorrarC.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBorrarC.Location = New System.Drawing.Point(621, 427)
        Me.btnBorrarC.Name = "btnBorrarC"
        Me.btnBorrarC.Size = New System.Drawing.Size(86, 72)
        Me.btnBorrarC.TabIndex = 570
        Me.btnBorrarC.Text = "&Borrar"
        Me.btnBorrarC.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBorrarC.UseVisualStyleBackColor = True
        '
        'btnModificarC
        '
        Me.btnModificarC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificarC.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarC.Image = CType(resources.GetObject("btnModificarC.Image"), System.Drawing.Image)
        Me.btnModificarC.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModificarC.Location = New System.Drawing.Point(489, 427)
        Me.btnModificarC.Name = "btnModificarC"
        Me.btnModificarC.Size = New System.Drawing.Size(86, 72)
        Me.btnModificarC.TabIndex = 569
        Me.btnModificarC.Text = "&Modificar"
        Me.btnModificarC.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificarC.UseVisualStyleBackColor = True
        '
        'btnAgregarC
        '
        Me.btnAgregarC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarC.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarC.Image = CType(resources.GetObject("btnAgregarC.Image"), System.Drawing.Image)
        Me.btnAgregarC.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAgregarC.Location = New System.Drawing.Point(357, 427)
        Me.btnAgregarC.Name = "btnAgregarC"
        Me.btnAgregarC.Size = New System.Drawing.Size(86, 72)
        Me.btnAgregarC.TabIndex = 568
        Me.btnAgregarC.Text = "&Agregar"
        Me.btnAgregarC.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregarC.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.Control
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(895, 634)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(103, 88)
        Me.btnSalir.TabIndex = 30
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.Color.Gainsboro
        Me.btnImprimir.Enabled = False
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprimir.Location = New System.Drawing.Point(743, 634)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(103, 88)
        Me.btnImprimir.TabIndex = 641
        Me.btnImprimir.Text = "&Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.BackColor = System.Drawing.SystemColors.Control
        Me.btnConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar.Image = CType(resources.GetObject("btnConsultar.Image"), System.Drawing.Image)
        Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnConsultar.Location = New System.Drawing.Point(518, 634)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(103, 88)
        Me.btnConsultar.TabIndex = 639
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnConsultar.UseVisualStyleBackColor = False
        '
        'btnPago
        '
        Me.btnPago.BackColor = System.Drawing.SystemColors.Control
        Me.btnPago.Enabled = False
        Me.btnPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPago.Image = CType(resources.GetObject("btnPago.Image"), System.Drawing.Image)
        Me.btnPago.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPago.Location = New System.Drawing.Point(370, 623)
        Me.btnPago.Name = "btnPago"
        Me.btnPago.Size = New System.Drawing.Size(103, 99)
        Me.btnPago.TabIndex = 21
        Me.btnPago.Text = "Pago de Clientes"
        Me.btnPago.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPago.UseVisualStyleBackColor = False
        Me.btnPago.Visible = False
        '
        'btnBuscaCliente
        '
        Me.btnBuscaCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscaCliente.Image = CType(resources.GetObject("btnBuscaCliente.Image"), System.Drawing.Image)
        Me.btnBuscaCliente.Location = New System.Drawing.Point(432, 34)
        Me.btnBuscaCliente.Name = "btnBuscaCliente"
        Me.btnBuscaCliente.Size = New System.Drawing.Size(41, 36)
        Me.btnBuscaCliente.TabIndex = 621
        Me.btnBuscaCliente.UseVisualStyleBackColor = True
        Me.btnBuscaCliente.Visible = False
        '
        'frmResumenCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(1016, 753)
        Me.Controls.Add(Me.tcGestionCliente)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.btnPago)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.dtpPeriodo)
        Me.Controls.Add(Me.lblid_cliente)
        Me.Controls.Add(Me.btnBuscaCliente)
        Me.Controls.Add(Me.cmbCliente)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmResumenCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmResumenProveedor"
        Me.tcGestionCliente.ResumeLayout(False)
        Me.tpPresupuesto.ResumeLayout(False)
        Me.tpPresupuesto.PerformLayout()
        CType(Me.dgvPresupuesto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpOrdenCompra.ResumeLayout(False)
        Me.tpOrdenCompra.PerformLayout()
        CType(Me.dgv_orden_compra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpFactura.ResumeLayout(False)
        Me.tpFactura.PerformLayout()
        CType(Me.dgvFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpRemito.ResumeLayout(False)
        Me.tpRemito.PerformLayout()
        CType(Me.dgv_remito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpCuentaCorriente.ResumeLayout(False)
        Me.tpCuentaCorriente.PerformLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpPagoCliente.ResumeLayout(False)
        Me.tpPagoCliente.PerformLayout()
        CType(Me.dgvPagoCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpClientes.ResumeLayout(False)
        Me.tpClientes.PerformLayout()
        CType(Me.dgv_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBuscaCliente As System.Windows.Forms.Button
    Friend WithEvents cmbCliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents dtpPeriodo As System.Windows.Forms.DateTimePicker
    Protected WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnPago As System.Windows.Forms.Button
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Public WithEvents lblid_cliente As System.Windows.Forms.Label
    Protected WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents tcGestionCliente As System.Windows.Forms.TabControl
    Friend WithEvents tpPresupuesto As System.Windows.Forms.TabPage
    Friend WithEvents tpOrdenCompra As System.Windows.Forms.TabPage
    Friend WithEvents tpFactura As System.Windows.Forms.TabPage
    Friend WithEvents tpRemito As System.Windows.Forms.TabPage
    Friend WithEvents tpPagoCliente As System.Windows.Forms.TabPage
    Protected WithEvents dgvPagoCliente As System.Windows.Forms.DataGridView
    Protected WithEvents btnAyudaPago As System.Windows.Forms.Button
    Protected WithEvents btnBorrarPago As System.Windows.Forms.Button
    Protected WithEvents btnModificarPago As System.Windows.Forms.Button
    Protected WithEvents btnAgregarPago As System.Windows.Forms.Button
    Protected WithEvents txtBuscar As System.Windows.Forms.TextBox
    Protected WithEvents lblconsultar As System.Windows.Forms.Label
    Friend WithEvents lblid_pk_PagoCliente As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblid_pk_Factura As System.Windows.Forms.Label
    Friend WithEvents btnItemGlobal As System.Windows.Forms.Button
    Friend WithEvents btnExporta As System.Windows.Forms.Button
    Friend WithEvents btnAgregar_2 As System.Windows.Forms.Button
    Friend WithEvents btnImrpimirFactura As System.Windows.Forms.Button
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents dgvFactura As System.Windows.Forms.DataGridView
    Friend WithEvents tpClientes As System.Windows.Forms.TabPage
    Protected WithEvents btnAyuda As System.Windows.Forms.Button
    Protected WithEvents dgv_cliente As System.Windows.Forms.DataGridView
    Protected WithEvents btnBorrarC As System.Windows.Forms.Button
    Protected WithEvents btnModificarC As System.Windows.Forms.Button
    Protected WithEvents txtBuscarC As System.Windows.Forms.TextBox
    Protected WithEvents btnAgregarC As System.Windows.Forms.Button
    Protected WithEvents Label4 As System.Windows.Forms.Label
    Protected WithEvents Label5 As System.Windows.Forms.Label
    Protected WithEvents lblid_c As System.Windows.Forms.Label
    Protected WithEvents btnModificarCompra As System.Windows.Forms.Button
    Protected WithEvents btnAgregarCompra As System.Windows.Forms.Button
    Protected WithEvents txtBuscarCompra As System.Windows.Forms.TextBox
    Protected WithEvents btnBorrarCompra As System.Windows.Forms.Button
    Protected WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblid_orden_compra As System.Windows.Forms.Label
    Protected WithEvents dgv_orden_compra As System.Windows.Forms.DataGridView
    Protected WithEvents btnModificarRemito As System.Windows.Forms.Button
    Protected WithEvents btnAgregarRemito As System.Windows.Forms.Button
    Protected WithEvents txtBuscarRemito As System.Windows.Forms.TextBox
    Protected WithEvents btnBorrarRemito As System.Windows.Forms.Button
    Protected WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblid_remito As System.Windows.Forms.Label
    Protected WithEvents dgv_remito As System.Windows.Forms.DataGridView
    Protected WithEvents dgvPresupuesto As System.Windows.Forms.DataGridView
    Protected WithEvents txtConsultarPresupuesto As System.Windows.Forms.TextBox
    Protected WithEvents Label9 As System.Windows.Forms.Label
    Protected WithEvents btnBorrar_presupuesto As System.Windows.Forms.Button
    Protected WithEvents btnModificar_presupuesto As System.Windows.Forms.Button
    Protected WithEvents btnAgregarPresupuesto As System.Windows.Forms.Button
    Friend WithEvents lblid_presupuesto As System.Windows.Forms.Label
    Friend WithEvents tpCuentaCorriente As System.Windows.Forms.TabPage
    Protected WithEvents lblid_pk As System.Windows.Forms.Label
    Friend WithEvents btnCierreTodo As System.Windows.Forms.Button
    Friend WithEvents lblFacturacion_mes As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblSaldoAnterior As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblSaldoActual As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtSaldoContable As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalGrilla As System.Windows.Forms.Label
    Protected WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnGenerarResumen As System.Windows.Forms.Button
    Friend WithEvents btnCierrePeriodo As System.Windows.Forms.Button
    Friend WithEvents btnModificarPeriodo As System.Windows.Forms.Button
    Friend WithEvents btnSaldoActual As System.Windows.Forms.Button
End Class
