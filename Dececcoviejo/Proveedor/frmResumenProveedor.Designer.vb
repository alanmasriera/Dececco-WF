<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResumenProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmResumenProveedor))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblid_proveedor = New System.Windows.Forms.Label()
        Me.btnBuscaProveedor = New System.Windows.Forms.Button()
        Me.cmbProveedor = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.dtpPeriodo = New System.Windows.Forms.DateTimePicker()
        Me.lblid_pk = New System.Windows.Forms.Label()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtSaldoContable = New System.Windows.Forms.TextBox()
        Me.lblTotalGrilla = New System.Windows.Forms.Label()
        Me.btnSaldoActual = New System.Windows.Forms.Button()
        Me.btnModificarPeriodo = New System.Windows.Forms.Button()
        Me.btnCierrePeriodo = New System.Windows.Forms.Button()
        Me.lblSaldoActual = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblSaldoAnterior = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnGenerarResumen = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnPago = New System.Windows.Forms.Button()
        Me.btnFactura = New System.Windows.Forms.Button()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.lblFacturacion_mes = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCierreTodo = New System.Windows.Forms.Button()
        Me.bntAbrirPeriodos = New System.Windows.Forms.Button()
        Me.lblEstado_libro = New System.Windows.Forms.Label()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblid_proveedor
        '
        Me.lblid_proveedor.AutoSize = True
        Me.lblid_proveedor.BackColor = System.Drawing.Color.Red
        Me.lblid_proveedor.Location = New System.Drawing.Point(138, 66)
        Me.lblid_proveedor.Name = "lblid_proveedor"
        Me.lblid_proveedor.Size = New System.Drawing.Size(13, 13)
        Me.lblid_proveedor.TabIndex = 623
        Me.lblid_proveedor.Text = "0"
        Me.lblid_proveedor.Visible = False
        '
        'btnBuscaProveedor
        '
        Me.btnBuscaProveedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscaProveedor.Image = CType(resources.GetObject("btnBuscaProveedor.Image"), System.Drawing.Image)
        Me.btnBuscaProveedor.Location = New System.Drawing.Point(432, 54)
        Me.btnBuscaProveedor.Name = "btnBuscaProveedor"
        Me.btnBuscaProveedor.Size = New System.Drawing.Size(41, 36)
        Me.btnBuscaProveedor.TabIndex = 621
        Me.btnBuscaProveedor.UseVisualStyleBackColor = True
        '
        'cmbProveedor
        '
        Me.cmbProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbProveedor.FormattingEnabled = True
        Me.cmbProveedor.Location = New System.Drawing.Point(116, 62)
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.Size = New System.Drawing.Size(299, 21)
        Me.cmbProveedor.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(24, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 21)
        Me.Label1.TabIndex = 622
        Me.Label1.Text = "Proveedor"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(522, 62)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(67, 21)
        Me.Label20.TabIndex = 625
        Me.Label20.Text = "Periodo"
        '
        'dtpPeriodo
        '
        Me.dtpPeriodo.CustomFormat = "MMMM - yyyy"
        Me.dtpPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPeriodo.Location = New System.Drawing.Point(597, 59)
        Me.dtpPeriodo.Name = "dtpPeriodo"
        Me.dtpPeriodo.ShowUpDown = True
        Me.dtpPeriodo.Size = New System.Drawing.Size(162, 26)
        Me.dtpPeriodo.TabIndex = 6
        '
        'lblid_pk
        '
        Me.lblid_pk.AutoSize = True
        Me.lblid_pk.BackColor = System.Drawing.Color.Red
        Me.lblid_pk.Location = New System.Drawing.Point(36, 111)
        Me.lblid_pk.Name = "lblid_pk"
        Me.lblid_pk.Size = New System.Drawing.Size(13, 13)
        Me.lblid_pk.TabIndex = 627
        Me.lblid_pk.Text = "0"
        Me.lblid_pk.Visible = False
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
        Me.dgv1.BackgroundColor = System.Drawing.Color.PeachPuff
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
        Me.dgv1.Location = New System.Drawing.Point(21, 101)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.ShowCellErrors = False
        Me.dgv1.ShowRowErrors = False
        Me.dgv1.Size = New System.Drawing.Size(738, 493)
        Me.dgv1.StandardTab = True
        Me.dgv1.TabIndex = 626
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.LightBlue
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(522, 533)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(220, 19)
        Me.Label21.TabIndex = 638
        Me.Label21.Text = "Saldo Contable"
        Me.Label21.Visible = False
        '
        'txtSaldoContable
        '
        Me.txtSaldoContable.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSaldoContable.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoContable.ForeColor = System.Drawing.Color.Blue
        Me.txtSaldoContable.Location = New System.Drawing.Point(522, 552)
        Me.txtSaldoContable.Name = "txtSaldoContable"
        Me.txtSaldoContable.ReadOnly = True
        Me.txtSaldoContable.Size = New System.Drawing.Size(220, 31)
        Me.txtSaldoContable.TabIndex = 637
        Me.txtSaldoContable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSaldoContable.Visible = False
        '
        'lblTotalGrilla
        '
        Me.lblTotalGrilla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalGrilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTotalGrilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalGrilla.Location = New System.Drawing.Point(781, 235)
        Me.lblTotalGrilla.Name = "lblTotalGrilla"
        Me.lblTotalGrilla.Size = New System.Drawing.Size(29, 17)
        Me.lblTotalGrilla.TabIndex = 634
        Me.lblTotalGrilla.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTotalGrilla.Visible = False
        '
        'btnSaldoActual
        '
        Me.btnSaldoActual.BackColor = System.Drawing.SystemColors.Control
        Me.btnSaldoActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaldoActual.Image = CType(resources.GetObject("btnSaldoActual.Image"), System.Drawing.Image)
        Me.btnSaldoActual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSaldoActual.Location = New System.Drawing.Point(781, 323)
        Me.btnSaldoActual.Name = "btnSaldoActual"
        Me.btnSaldoActual.Size = New System.Drawing.Size(220, 70)
        Me.btnSaldoActual.TabIndex = 11
        Me.btnSaldoActual.Text = "Calcular Saldo Actual    "
        Me.btnSaldoActual.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSaldoActual.UseVisualStyleBackColor = True
        '
        'btnModificarPeriodo
        '
        Me.btnModificarPeriodo.BackColor = System.Drawing.SystemColors.Control
        Me.btnModificarPeriodo.Image = CType(resources.GetObject("btnModificarPeriodo.Image"), System.Drawing.Image)
        Me.btnModificarPeriodo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModificarPeriodo.Location = New System.Drawing.Point(899, 502)
        Me.btnModificarPeriodo.Name = "btnModificarPeriodo"
        Me.btnModificarPeriodo.Size = New System.Drawing.Size(102, 92)
        Me.btnModificarPeriodo.TabIndex = 13
        Me.btnModificarPeriodo.Text = "Modificar Periodo"
        Me.btnModificarPeriodo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificarPeriodo.UseVisualStyleBackColor = True
        '
        'btnCierrePeriodo
        '
        Me.btnCierrePeriodo.BackColor = System.Drawing.SystemColors.Control
        Me.btnCierrePeriodo.Image = CType(resources.GetObject("btnCierrePeriodo.Image"), System.Drawing.Image)
        Me.btnCierrePeriodo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCierrePeriodo.Location = New System.Drawing.Point(781, 502)
        Me.btnCierrePeriodo.Name = "btnCierrePeriodo"
        Me.btnCierrePeriodo.Size = New System.Drawing.Size(102, 92)
        Me.btnCierrePeriodo.TabIndex = 12
        Me.btnCierrePeriodo.Text = "Cerrar Periodo"
        Me.btnCierrePeriodo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCierrePeriodo.UseVisualStyleBackColor = True
        '
        'lblSaldoActual
        '
        Me.lblSaldoActual.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSaldoActual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSaldoActual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSaldoActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldoActual.ForeColor = System.Drawing.Color.Blue
        Me.lblSaldoActual.Location = New System.Drawing.Point(781, 284)
        Me.lblSaldoActual.Name = "lblSaldoActual"
        Me.lblSaldoActual.Size = New System.Drawing.Size(220, 29)
        Me.lblSaldoActual.TabIndex = 631
        Me.lblSaldoActual.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.LightBlue
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(781, 265)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(220, 19)
        Me.Label13.TabIndex = 630
        Me.Label13.Text = "Saldo Actual"
        '
        'lblSaldoAnterior
        '
        Me.lblSaldoAnterior.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSaldoAnterior.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSaldoAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSaldoAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldoAnterior.ForeColor = System.Drawing.Color.Blue
        Me.lblSaldoAnterior.Location = New System.Drawing.Point(781, 120)
        Me.lblSaldoAnterior.Name = "lblSaldoAnterior"
        Me.lblSaldoAnterior.Size = New System.Drawing.Size(220, 29)
        Me.lblSaldoAnterior.TabIndex = 629
        Me.lblSaldoAnterior.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.LightBlue
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(781, 101)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(220, 19)
        Me.Label11.TabIndex = 628
        Me.Label11.Text = "Saldo del Periodo Anterior"
        '
        'btnGenerarResumen
        '
        Me.btnGenerarResumen.BackColor = System.Drawing.SystemColors.Control
        Me.btnGenerarResumen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarResumen.Image = CType(resources.GetObject("btnGenerarResumen.Image"), System.Drawing.Image)
        Me.btnGenerarResumen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenerarResumen.Location = New System.Drawing.Point(781, 158)
        Me.btnGenerarResumen.Name = "btnGenerarResumen"
        Me.btnGenerarResumen.Size = New System.Drawing.Size(220, 73)
        Me.btnGenerarResumen.TabIndex = 10
        Me.btnGenerarResumen.Text = "Generar Resumen     "
        Me.btnGenerarResumen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenerarResumen.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(915, 643)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(86, 71)
        Me.btnSalir.TabIndex = 30
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnPago
        '
        Me.btnPago.Enabled = False
        Me.btnPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPago.Image = CType(resources.GetObject("btnPago.Image"), System.Drawing.Image)
        Me.btnPago.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPago.Location = New System.Drawing.Point(164, 616)
        Me.btnPago.Name = "btnPago"
        Me.btnPago.Size = New System.Drawing.Size(103, 99)
        Me.btnPago.TabIndex = 21
        Me.btnPago.Text = "Pago a Proveedores"
        Me.btnPago.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPago.UseVisualStyleBackColor = True
        '
        'btnFactura
        '
        Me.btnFactura.Enabled = False
        Me.btnFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFactura.Image = CType(resources.GetObject("btnFactura.Image"), System.Drawing.Image)
        Me.btnFactura.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnFactura.Location = New System.Drawing.Point(19, 616)
        Me.btnFactura.Name = "btnFactura"
        Me.btnFactura.Size = New System.Drawing.Size(103, 99)
        Me.btnFactura.TabIndex = 20
        Me.btnFactura.Text = "Ingreso de Facturas"
        Me.btnFactura.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFactura.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar.Image = CType(resources.GetObject("btnConsultar.Image"), System.Drawing.Image)
        Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnConsultar.Location = New System.Drawing.Point(352, 615)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(103, 99)
        Me.btnConsultar.TabIndex = 639
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTitulo.Font = New System.Drawing.Font("Times New Roman", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.Red
        Me.lblTitulo.Location = New System.Drawing.Point(21, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(394, 30)
        Me.lblTitulo.TabIndex = 640
        Me.lblTitulo.Text = "Gestión de Proveedores"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.Color.Gainsboro
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprimir.Location = New System.Drawing.Point(666, 616)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(93, 97)
        Me.btnImprimir.TabIndex = 641
        Me.btnImprimir.Text = "&Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'lblFacturacion_mes
        '
        Me.lblFacturacion_mes.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblFacturacion_mes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFacturacion_mes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblFacturacion_mes.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFacturacion_mes.ForeColor = System.Drawing.Color.Blue
        Me.lblFacturacion_mes.Location = New System.Drawing.Point(781, 454)
        Me.lblFacturacion_mes.Name = "lblFacturacion_mes"
        Me.lblFacturacion_mes.Size = New System.Drawing.Size(220, 29)
        Me.lblFacturacion_mes.TabIndex = 643
        Me.lblFacturacion_mes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblFacturacion_mes.Visible = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.LightBlue
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(781, 435)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(220, 19)
        Me.Label3.TabIndex = 642
        Me.Label3.Text = "Total Comprado"
        Me.Label3.Visible = False
        '
        'btnCierreTodo
        '
        Me.btnCierreTodo.BackColor = System.Drawing.Color.Gainsboro
        Me.btnCierreTodo.Location = New System.Drawing.Point(785, 59)
        Me.btnCierreTodo.Name = "btnCierreTodo"
        Me.btnCierreTodo.Size = New System.Drawing.Size(219, 23)
        Me.btnCierreTodo.TabIndex = 645
        Me.btnCierreTodo.Text = "Cerrar el Periodo para Todos los Prov."
        Me.btnCierreTodo.UseVisualStyleBackColor = False
        '
        'bntAbrirPeriodos
        '
        Me.bntAbrirPeriodos.BackColor = System.Drawing.Color.Gainsboro
        Me.bntAbrirPeriodos.Location = New System.Drawing.Point(785, 16)
        Me.bntAbrirPeriodos.Name = "bntAbrirPeriodos"
        Me.bntAbrirPeriodos.Size = New System.Drawing.Size(219, 23)
        Me.bntAbrirPeriodos.TabIndex = 646
        Me.bntAbrirPeriodos.Text = "Abrir el Período para Todos los Prov."
        Me.bntAbrirPeriodos.UseVisualStyleBackColor = False
        '
        'lblEstado_libro
        '
        Me.lblEstado_libro.BackColor = System.Drawing.Color.Lime
        Me.lblEstado_libro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado_libro.Location = New System.Drawing.Point(609, 19)
        Me.lblEstado_libro.Name = "lblEstado_libro"
        Me.lblEstado_libro.Size = New System.Drawing.Size(150, 20)
        Me.lblEstado_libro.TabIndex = 647
        Me.lblEstado_libro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmResumenProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(1016, 734)
        Me.Controls.Add(Me.lblEstado_libro)
        Me.Controls.Add(Me.bntAbrirPeriodos)
        Me.Controls.Add(Me.btnCierreTodo)
        Me.Controls.Add(Me.lblFacturacion_mes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.btnPago)
        Me.Controls.Add(Me.btnFactura)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtSaldoContable)
        Me.Controls.Add(Me.lblTotalGrilla)
        Me.Controls.Add(Me.btnSaldoActual)
        Me.Controls.Add(Me.btnModificarPeriodo)
        Me.Controls.Add(Me.btnCierrePeriodo)
        Me.Controls.Add(Me.lblSaldoActual)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblSaldoAnterior)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnGenerarResumen)
        Me.Controls.Add(Me.lblid_pk)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.dtpPeriodo)
        Me.Controls.Add(Me.lblid_proveedor)
        Me.Controls.Add(Me.btnBuscaProveedor)
        Me.Controls.Add(Me.cmbProveedor)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmResumenProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmResumenProveedor"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBuscaProveedor As System.Windows.Forms.Button
    Friend WithEvents cmbProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents dtpPeriodo As System.Windows.Forms.DateTimePicker
    Protected WithEvents lblid_pk As System.Windows.Forms.Label
    Protected WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtSaldoContable As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalGrilla As System.Windows.Forms.Label
    Friend WithEvents btnSaldoActual As System.Windows.Forms.Button
    Friend WithEvents btnModificarPeriodo As System.Windows.Forms.Button
    Friend WithEvents btnCierrePeriodo As System.Windows.Forms.Button
    Friend WithEvents lblSaldoActual As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblSaldoAnterior As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnGenerarResumen As System.Windows.Forms.Button
    Protected WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnPago As System.Windows.Forms.Button
    Friend WithEvents btnFactura As System.Windows.Forms.Button
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Public WithEvents lblid_proveedor As System.Windows.Forms.Label
    Protected WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents lblFacturacion_mes As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCierreTodo As System.Windows.Forms.Button
    Friend WithEvents bntAbrirPeriodos As System.Windows.Forms.Button
    Friend WithEvents lblEstado_libro As System.Windows.Forms.Label
End Class
