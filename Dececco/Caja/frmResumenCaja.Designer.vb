<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResumenCaja
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle36 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle37 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle38 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle39 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle40 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle41 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle42 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle43 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle44 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle45 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmResumenCaja))
        Me.lblResumen = New System.Windows.Forms.Label
        Me.lblidGasto = New System.Windows.Forms.Label
        Me.lblidTransferenciaBancaria = New System.Windows.Forms.Label
        Me.lblidDepositoEfectivo = New System.Windows.Forms.Label
        Me.lblidCredito = New System.Windows.Forms.Label
        Me.lblidCuenta = New System.Windows.Forms.Label
        Me.lblidBanco = New System.Windows.Forms.Label
        Me.lblidChequeLibrado = New System.Windows.Forms.Label
        Me.lblidChequeRecibido = New System.Windows.Forms.Label
        Me.lblidDebito = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbEmpresa = New System.Windows.Forms.ComboBox
        Me.dtpPeriodo = New System.Windows.Forms.DateTimePicker
        Me.lblidEmpresa = New System.Windows.Forms.Label
        Me.lblempresa = New System.Windows.Forms.Label
        Me.TCCaja = New System.Windows.Forms.TabControl
        Me.cheque_recibido = New System.Windows.Forms.TabPage
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.dgvChequeCobro = New System.Windows.Forms.DataGridView
        Me.Label3 = New System.Windows.Forms.Label
        Me.dgvChequeRecibido = New System.Windows.Forms.DataGridView
        Me.Ingreso = New System.Windows.Forms.TabPage
        Me.Label7 = New System.Windows.Forms.Label
        Me.dgvIngreso = New System.Windows.Forms.DataGridView
        Me.Egreso = New System.Windows.Forms.TabPage
        Me.Label8 = New System.Windows.Forms.Label
        Me.DataGridView5 = New System.Windows.Forms.DataGridView
        Me.Resumen = New System.Windows.Forms.TabPage
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtSaldoContable = New System.Windows.Forms.TextBox
        Me.lblTotalGrilla = New System.Windows.Forms.Label
        Me.btnSaldoActual = New System.Windows.Forms.Button
        Me.btnModificarPeriodo = New System.Windows.Forms.Button
        Me.btnCierrePeriodo = New System.Windows.Forms.Button
        Me.lblSaldoActual = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.lblSaldoAnterior = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.DataGridView8 = New System.Windows.Forms.DataGridView
        Me.btnGenerarResumen = New System.Windows.Forms.Button
        Me.tpConsulta = New System.Windows.Forms.TabPage
        Me.btnConsulta_3 = New System.Windows.Forms.Button
        Me.btnConsulta_2 = New System.Windows.Forms.Button
        Me.btnConsulta_1 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Btnimprime = New System.Windows.Forms.Button
        Me.btnBorrar = New System.Windows.Forms.Button
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.btnModificar = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.ttSaldoActual = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnBuscaEmpresa = New System.Windows.Forms.Button
        Me.dtpFin = New System.Windows.Forms.DateTimePicker
        Me.Label12 = New System.Windows.Forms.Label
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.TCCaja.SuspendLayout()
        Me.cheque_recibido.SuspendLayout()
        CType(Me.dgvChequeCobro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvChequeRecibido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Ingreso.SuspendLayout()
        CType(Me.dgvIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Egreso.SuspendLayout()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Resumen.SuspendLayout()
        CType(Me.DataGridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpConsulta.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblResumen
        '
        Me.lblResumen.AutoSize = True
        Me.lblResumen.BackColor = System.Drawing.Color.Red
        Me.lblResumen.Location = New System.Drawing.Point(376, 713)
        Me.lblResumen.Name = "lblResumen"
        Me.lblResumen.Size = New System.Drawing.Size(13, 13)
        Me.lblResumen.TabIndex = 418
        Me.lblResumen.Text = "0"
        Me.lblResumen.Visible = False
        '
        'lblidGasto
        '
        Me.lblidGasto.AutoSize = True
        Me.lblidGasto.BackColor = System.Drawing.Color.Red
        Me.lblidGasto.Location = New System.Drawing.Point(325, 713)
        Me.lblidGasto.Name = "lblidGasto"
        Me.lblidGasto.Size = New System.Drawing.Size(13, 13)
        Me.lblidGasto.TabIndex = 417
        Me.lblidGasto.Text = "0"
        Me.lblidGasto.Visible = False
        '
        'lblidTransferenciaBancaria
        '
        Me.lblidTransferenciaBancaria.AutoSize = True
        Me.lblidTransferenciaBancaria.BackColor = System.Drawing.Color.Red
        Me.lblidTransferenciaBancaria.Location = New System.Drawing.Point(70, 713)
        Me.lblidTransferenciaBancaria.Name = "lblidTransferenciaBancaria"
        Me.lblidTransferenciaBancaria.Size = New System.Drawing.Size(13, 13)
        Me.lblidTransferenciaBancaria.TabIndex = 416
        Me.lblidTransferenciaBancaria.Text = "0"
        Me.lblidTransferenciaBancaria.Visible = False
        '
        'lblidDepositoEfectivo
        '
        Me.lblidDepositoEfectivo.AutoSize = True
        Me.lblidDepositoEfectivo.BackColor = System.Drawing.Color.Red
        Me.lblidDepositoEfectivo.Location = New System.Drawing.Point(274, 713)
        Me.lblidDepositoEfectivo.Name = "lblidDepositoEfectivo"
        Me.lblidDepositoEfectivo.Size = New System.Drawing.Size(13, 13)
        Me.lblidDepositoEfectivo.TabIndex = 415
        Me.lblidDepositoEfectivo.Text = "0"
        Me.lblidDepositoEfectivo.Visible = False
        '
        'lblidCredito
        '
        Me.lblidCredito.AutoSize = True
        Me.lblidCredito.BackColor = System.Drawing.Color.Red
        Me.lblidCredito.Location = New System.Drawing.Point(172, 713)
        Me.lblidCredito.Name = "lblidCredito"
        Me.lblidCredito.Size = New System.Drawing.Size(13, 13)
        Me.lblidCredito.TabIndex = 414
        Me.lblidCredito.Text = "0"
        Me.lblidCredito.Visible = False
        '
        'lblidCuenta
        '
        Me.lblidCuenta.AutoSize = True
        Me.lblidCuenta.BackColor = System.Drawing.Color.Red
        Me.lblidCuenta.ForeColor = System.Drawing.Color.Black
        Me.lblidCuenta.Location = New System.Drawing.Point(514, 47)
        Me.lblidCuenta.Name = "lblidCuenta"
        Me.lblidCuenta.Size = New System.Drawing.Size(13, 13)
        Me.lblidCuenta.TabIndex = 423
        Me.lblidCuenta.Text = "1"
        Me.lblidCuenta.Visible = False
        '
        'lblidBanco
        '
        Me.lblidBanco.AutoSize = True
        Me.lblidBanco.BackColor = System.Drawing.Color.Red
        Me.lblidBanco.ForeColor = System.Drawing.Color.Black
        Me.lblidBanco.Location = New System.Drawing.Point(495, 47)
        Me.lblidBanco.Name = "lblidBanco"
        Me.lblidBanco.Size = New System.Drawing.Size(13, 13)
        Me.lblidBanco.TabIndex = 422
        Me.lblidBanco.Text = "1"
        Me.lblidBanco.Visible = False
        '
        'lblidChequeLibrado
        '
        Me.lblidChequeLibrado.AutoSize = True
        Me.lblidChequeLibrado.BackColor = System.Drawing.Color.Red
        Me.lblidChequeLibrado.Location = New System.Drawing.Point(121, 713)
        Me.lblidChequeLibrado.Name = "lblidChequeLibrado"
        Me.lblidChequeLibrado.Size = New System.Drawing.Size(13, 13)
        Me.lblidChequeLibrado.TabIndex = 412
        Me.lblidChequeLibrado.Text = "0"
        Me.lblidChequeLibrado.Visible = False
        '
        'lblidChequeRecibido
        '
        Me.lblidChequeRecibido.AutoSize = True
        Me.lblidChequeRecibido.BackColor = System.Drawing.Color.Red
        Me.lblidChequeRecibido.Location = New System.Drawing.Point(19, 713)
        Me.lblidChequeRecibido.Name = "lblidChequeRecibido"
        Me.lblidChequeRecibido.Size = New System.Drawing.Size(13, 13)
        Me.lblidChequeRecibido.TabIndex = 411
        Me.lblidChequeRecibido.Text = "0"
        Me.lblidChequeRecibido.Visible = False
        '
        'lblidDebito
        '
        Me.lblidDebito.AutoSize = True
        Me.lblidDebito.BackColor = System.Drawing.Color.Red
        Me.lblidDebito.Location = New System.Drawing.Point(223, 713)
        Me.lblidDebito.Name = "lblidDebito"
        Me.lblidDebito.Size = New System.Drawing.Size(13, 13)
        Me.lblidDebito.TabIndex = 413
        Me.lblidDebito.Text = "0"
        Me.lblidDebito.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(646, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 21)
        Me.Label2.TabIndex = 410
        Me.Label2.Text = "Periodo :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmbEmpresa
        '
        Me.cmbEmpresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbEmpresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbEmpresa.Enabled = False
        Me.cmbEmpresa.FormattingEnabled = True
        Me.cmbEmpresa.Location = New System.Drawing.Point(114, 46)
        Me.cmbEmpresa.Name = "cmbEmpresa"
        Me.cmbEmpresa.Size = New System.Drawing.Size(276, 21)
        Me.cmbEmpresa.TabIndex = 400
        '
        'dtpPeriodo
        '
        Me.dtpPeriodo.CustomFormat = "MMMM - yyyy     -dd"
        Me.dtpPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPeriodo.Location = New System.Drawing.Point(723, 45)
        Me.dtpPeriodo.Name = "dtpPeriodo"
        Me.dtpPeriodo.ShowUpDown = True
        Me.dtpPeriodo.Size = New System.Drawing.Size(166, 23)
        Me.dtpPeriodo.TabIndex = 403
        '
        'lblidEmpresa
        '
        Me.lblidEmpresa.AutoSize = True
        Me.lblidEmpresa.BackColor = System.Drawing.Color.Red
        Me.lblidEmpresa.Location = New System.Drawing.Point(476, 47)
        Me.lblidEmpresa.Name = "lblidEmpresa"
        Me.lblidEmpresa.Size = New System.Drawing.Size(13, 13)
        Me.lblidEmpresa.TabIndex = 409
        Me.lblidEmpresa.Text = "0"
        Me.lblidEmpresa.Visible = False
        '
        'lblempresa
        '
        Me.lblempresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblempresa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblempresa.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblempresa.Location = New System.Drawing.Point(22, 43)
        Me.lblempresa.Name = "lblempresa"
        Me.lblempresa.Size = New System.Drawing.Size(79, 21)
        Me.lblempresa.TabIndex = 408
        Me.lblempresa.Text = "Empresa :"
        Me.lblempresa.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TCCaja
        '
        Me.TCCaja.Controls.Add(Me.cheque_recibido)
        Me.TCCaja.Controls.Add(Me.Ingreso)
        Me.TCCaja.Controls.Add(Me.Egreso)
        Me.TCCaja.Controls.Add(Me.Resumen)
        Me.TCCaja.Controls.Add(Me.tpConsulta)
        Me.TCCaja.Enabled = False
        Me.TCCaja.Location = New System.Drawing.Point(17, 144)
        Me.TCCaja.Name = "TCCaja"
        Me.TCCaja.SelectedIndex = 0
        Me.TCCaja.Size = New System.Drawing.Size(876, 529)
        Me.TCCaja.TabIndex = 404
        '
        'cheque_recibido
        '
        Me.cheque_recibido.BackColor = System.Drawing.Color.CadetBlue
        Me.cheque_recibido.Controls.Add(Me.Label20)
        Me.cheque_recibido.Controls.Add(Me.Label19)
        Me.cheque_recibido.Controls.Add(Me.dgvChequeCobro)
        Me.cheque_recibido.Controls.Add(Me.Label3)
        Me.cheque_recibido.Controls.Add(Me.dgvChequeRecibido)
        Me.cheque_recibido.Location = New System.Drawing.Point(4, 22)
        Me.cheque_recibido.Name = "cheque_recibido"
        Me.cheque_recibido.Padding = New System.Windows.Forms.Padding(3)
        Me.cheque_recibido.Size = New System.Drawing.Size(868, 503)
        Me.cheque_recibido.TabIndex = 0
        Me.cheque_recibido.Text = "Cheques Recibidos"
        Me.cheque_recibido.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Turquoise
        Me.Label20.Location = New System.Drawing.Point(9, 277)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(97, 13)
        Me.Label20.TabIndex = 18
        Me.Label20.Text = "Fecha de Recibido"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Turquoise
        Me.Label19.Location = New System.Drawing.Point(9, 33)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(83, 13)
        Me.Label19.TabIndex = 17
        Me.Label19.Text = "Fecha de Cobro"
        '
        'dgvChequeCobro
        '
        Me.dgvChequeCobro.AllowUserToAddRows = False
        Me.dgvChequeCobro.AllowUserToResizeColumns = False
        Me.dgvChequeCobro.AllowUserToResizeRows = False
        DataGridViewCellStyle31.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle31.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow
        DataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.Brown
        Me.dgvChequeCobro.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle31
        Me.dgvChequeCobro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvChequeCobro.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvChequeCobro.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.dgvChequeCobro.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle32.BackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvChequeCobro.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle32
        Me.dgvChequeCobro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle33.BackColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle33.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.Beige
        DataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.Brown
        DataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvChequeCobro.DefaultCellStyle = DataGridViewCellStyle33
        Me.dgvChequeCobro.GridColor = System.Drawing.Color.MediumPurple
        Me.dgvChequeCobro.Location = New System.Drawing.Point(9, 293)
        Me.dgvChequeCobro.Name = "dgvChequeCobro"
        Me.dgvChequeCobro.ReadOnly = True
        Me.dgvChequeCobro.ShowCellErrors = False
        Me.dgvChequeCobro.ShowRowErrors = False
        Me.dgvChequeCobro.Size = New System.Drawing.Size(853, 202)
        Me.dgvChequeCobro.StandardTab = True
        Me.dgvChequeCobro.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Turquoise
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(304, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(242, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "CHEQUES RECIBIDOS"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvChequeRecibido
        '
        Me.dgvChequeRecibido.AllowUserToAddRows = False
        Me.dgvChequeRecibido.AllowUserToResizeColumns = False
        Me.dgvChequeRecibido.AllowUserToResizeRows = False
        DataGridViewCellStyle34.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle34.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow
        DataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.Brown
        Me.dgvChequeRecibido.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle34
        Me.dgvChequeRecibido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvChequeRecibido.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvChequeRecibido.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.dgvChequeRecibido.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle35.BackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvChequeRecibido.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle35
        Me.dgvChequeRecibido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle36.BackColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle36.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.Beige
        DataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.Brown
        DataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvChequeRecibido.DefaultCellStyle = DataGridViewCellStyle36
        Me.dgvChequeRecibido.GridColor = System.Drawing.Color.MediumPurple
        Me.dgvChequeRecibido.Location = New System.Drawing.Point(9, 50)
        Me.dgvChequeRecibido.Name = "dgvChequeRecibido"
        Me.dgvChequeRecibido.ReadOnly = True
        Me.dgvChequeRecibido.ShowCellErrors = False
        Me.dgvChequeRecibido.ShowRowErrors = False
        Me.dgvChequeRecibido.Size = New System.Drawing.Size(853, 215)
        Me.dgvChequeRecibido.StandardTab = True
        Me.dgvChequeRecibido.TabIndex = 15
        '
        'Ingreso
        '
        Me.Ingreso.BackColor = System.Drawing.Color.CadetBlue
        Me.Ingreso.Controls.Add(Me.Label7)
        Me.Ingreso.Controls.Add(Me.dgvIngreso)
        Me.Ingreso.Location = New System.Drawing.Point(4, 22)
        Me.Ingreso.Name = "Ingreso"
        Me.Ingreso.Size = New System.Drawing.Size(868, 503)
        Me.Ingreso.TabIndex = 7
        Me.Ingreso.Text = "Ingresos de Efectivo"
        Me.Ingreso.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Turquoise
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(304, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(242, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "INGRESOS DE EFECTIVO"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvIngreso
        '
        Me.dgvIngreso.AllowUserToAddRows = False
        Me.dgvIngreso.AllowUserToResizeColumns = False
        Me.dgvIngreso.AllowUserToResizeRows = False
        DataGridViewCellStyle37.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle37.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle37.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow
        DataGridViewCellStyle37.SelectionForeColor = System.Drawing.Color.Brown
        Me.dgvIngreso.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle37
        Me.dgvIngreso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvIngreso.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvIngreso.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.dgvIngreso.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle38.BackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle38.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle38.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvIngreso.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle38
        Me.dgvIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle39.BackColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle39.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle39.SelectionBackColor = System.Drawing.Color.Beige
        DataGridViewCellStyle39.SelectionForeColor = System.Drawing.Color.Brown
        DataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvIngreso.DefaultCellStyle = DataGridViewCellStyle39
        Me.dgvIngreso.GridColor = System.Drawing.Color.MediumPurple
        Me.dgvIngreso.Location = New System.Drawing.Point(9, 50)
        Me.dgvIngreso.Name = "dgvIngreso"
        Me.dgvIngreso.ReadOnly = True
        Me.dgvIngreso.ShowCellErrors = False
        Me.dgvIngreso.ShowRowErrors = False
        Me.dgvIngreso.Size = New System.Drawing.Size(853, 450)
        Me.dgvIngreso.StandardTab = True
        Me.dgvIngreso.TabIndex = 18
        '
        'Egreso
        '
        Me.Egreso.BackColor = System.Drawing.Color.Brown
        Me.Egreso.Controls.Add(Me.Label8)
        Me.Egreso.Controls.Add(Me.DataGridView5)
        Me.Egreso.Location = New System.Drawing.Point(4, 22)
        Me.Egreso.Name = "Egreso"
        Me.Egreso.Size = New System.Drawing.Size(868, 503)
        Me.Egreso.TabIndex = 6
        Me.Egreso.Text = "Egresos de Efectivo"
        Me.Egreso.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Turquoise
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(304, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(242, 20)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "EGRESOS DE EFECTIVO"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView5
        '
        Me.DataGridView5.AllowUserToAddRows = False
        Me.DataGridView5.AllowUserToResizeColumns = False
        Me.DataGridView5.AllowUserToResizeRows = False
        DataGridViewCellStyle40.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle40.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle40.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow
        DataGridViewCellStyle40.SelectionForeColor = System.Drawing.Color.Brown
        Me.DataGridView5.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle40
        Me.DataGridView5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView5.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView5.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.DataGridView5.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle41.BackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle41.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle41.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle41.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView5.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle41
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle42.BackColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle42.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle42.SelectionBackColor = System.Drawing.Color.Beige
        DataGridViewCellStyle42.SelectionForeColor = System.Drawing.Color.Brown
        DataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView5.DefaultCellStyle = DataGridViewCellStyle42
        Me.DataGridView5.GridColor = System.Drawing.Color.MediumPurple
        Me.DataGridView5.Location = New System.Drawing.Point(9, 50)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.ReadOnly = True
        Me.DataGridView5.ShowCellErrors = False
        Me.DataGridView5.ShowRowErrors = False
        Me.DataGridView5.Size = New System.Drawing.Size(853, 450)
        Me.DataGridView5.StandardTab = True
        Me.DataGridView5.TabIndex = 19
        '
        'Resumen
        '
        Me.Resumen.BackColor = System.Drawing.Color.LightGray
        Me.Resumen.Controls.Add(Me.Label21)
        Me.Resumen.Controls.Add(Me.txtSaldoContable)
        Me.Resumen.Controls.Add(Me.lblTotalGrilla)
        Me.Resumen.Controls.Add(Me.btnSaldoActual)
        Me.Resumen.Controls.Add(Me.btnModificarPeriodo)
        Me.Resumen.Controls.Add(Me.btnCierrePeriodo)
        Me.Resumen.Controls.Add(Me.lblSaldoActual)
        Me.Resumen.Controls.Add(Me.Label13)
        Me.Resumen.Controls.Add(Me.lblSaldoAnterior)
        Me.Resumen.Controls.Add(Me.Label11)
        Me.Resumen.Controls.Add(Me.Label10)
        Me.Resumen.Controls.Add(Me.DataGridView8)
        Me.Resumen.Controls.Add(Me.btnGenerarResumen)
        Me.Resumen.Location = New System.Drawing.Point(4, 22)
        Me.Resumen.Name = "Resumen"
        Me.Resumen.Size = New System.Drawing.Size(868, 503)
        Me.Resumen.TabIndex = 4
        Me.Resumen.Text = "Resumen Mensual"
        Me.Resumen.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(737, 375)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(79, 13)
        Me.Label21.TabIndex = 26
        Me.Label21.Text = "Saldo Contable"
        '
        'txtSaldoContable
        '
        Me.txtSaldoContable.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSaldoContable.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoContable.Location = New System.Drawing.Point(699, 402)
        Me.txtSaldoContable.Name = "txtSaldoContable"
        Me.txtSaldoContable.ReadOnly = True
        Me.txtSaldoContable.Size = New System.Drawing.Size(154, 24)
        Me.txtSaldoContable.TabIndex = 25
        Me.txtSaldoContable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTotalGrilla
        '
        Me.lblTotalGrilla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalGrilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTotalGrilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalGrilla.Location = New System.Drawing.Point(680, 289)
        Me.lblTotalGrilla.Name = "lblTotalGrilla"
        Me.lblTotalGrilla.Size = New System.Drawing.Size(29, 17)
        Me.lblTotalGrilla.TabIndex = 23
        Me.lblTotalGrilla.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTotalGrilla.Visible = False
        '
        'btnSaldoActual
        '
        Me.btnSaldoActual.BackColor = System.Drawing.SystemColors.Control
        Me.btnSaldoActual.Location = New System.Drawing.Point(728, 274)
        Me.btnSaldoActual.Name = "btnSaldoActual"
        Me.btnSaldoActual.Size = New System.Drawing.Size(103, 41)
        Me.btnSaldoActual.TabIndex = 22
        Me.btnSaldoActual.Text = "Calcular Saldo Actual"
        Me.ttSaldoActual.SetToolTip(Me.btnSaldoActual, "Calcula el saldo actual hasta la fecha de hoy")
        Me.btnSaldoActual.UseVisualStyleBackColor = False
        '
        'btnModificarPeriodo
        '
        Me.btnModificarPeriodo.BackColor = System.Drawing.SystemColors.Control
        Me.btnModificarPeriodo.Location = New System.Drawing.Point(784, 443)
        Me.btnModificarPeriodo.Name = "btnModificarPeriodo"
        Me.btnModificarPeriodo.Size = New System.Drawing.Size(69, 52)
        Me.btnModificarPeriodo.TabIndex = 24
        Me.btnModificarPeriodo.Text = "Modificar Periodo"
        Me.ttSaldoActual.SetToolTip(Me.btnModificarPeriodo, "Modifica el periodo")
        Me.btnModificarPeriodo.UseVisualStyleBackColor = False
        '
        'btnCierrePeriodo
        '
        Me.btnCierrePeriodo.BackColor = System.Drawing.SystemColors.Control
        Me.btnCierrePeriodo.Location = New System.Drawing.Point(699, 443)
        Me.btnCierrePeriodo.Name = "btnCierrePeriodo"
        Me.btnCierrePeriodo.Size = New System.Drawing.Size(69, 52)
        Me.btnCierrePeriodo.TabIndex = 23
        Me.btnCierrePeriodo.Text = "Cerrar Periodo"
        Me.ttSaldoActual.SetToolTip(Me.btnCierrePeriodo, "Cierra el periodo")
        Me.btnCierrePeriodo.UseVisualStyleBackColor = False
        '
        'lblSaldoActual
        '
        Me.lblSaldoActual.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSaldoActual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSaldoActual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSaldoActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldoActual.Location = New System.Drawing.Point(699, 230)
        Me.lblSaldoActual.Name = "lblSaldoActual"
        Me.lblSaldoActual.Size = New System.Drawing.Size(154, 29)
        Me.lblSaldoActual.TabIndex = 16
        Me.lblSaldoActual.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(737, 200)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 13)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Saldo Actual"
        '
        'lblSaldoAnterior
        '
        Me.lblSaldoAnterior.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSaldoAnterior.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSaldoAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSaldoAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldoAnterior.Location = New System.Drawing.Point(699, 86)
        Me.lblSaldoAnterior.Name = "lblSaldoAnterior"
        Me.lblSaldoAnterior.Size = New System.Drawing.Size(154, 29)
        Me.lblSaldoAnterior.TabIndex = 14
        Me.lblSaldoAnterior.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(714, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(129, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Saldo del Periodo Anterior"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Turquoise
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(219, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(242, 20)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "RESUMEN"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView8
        '
        Me.DataGridView8.AllowUserToAddRows = False
        Me.DataGridView8.AllowUserToDeleteRows = False
        Me.DataGridView8.AllowUserToResizeColumns = False
        Me.DataGridView8.AllowUserToResizeRows = False
        DataGridViewCellStyle43.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle43.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle43.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow
        DataGridViewCellStyle43.SelectionForeColor = System.Drawing.Color.Brown
        Me.DataGridView8.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle43
        Me.DataGridView8.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView8.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView8.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.DataGridView8.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle44.BackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle44.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle44.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle44.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView8.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle44
        Me.DataGridView8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle45.BackColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle45.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle45.SelectionBackColor = System.Drawing.Color.Beige
        DataGridViewCellStyle45.SelectionForeColor = System.Drawing.Color.Brown
        DataGridViewCellStyle45.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView8.DefaultCellStyle = DataGridViewCellStyle45
        Me.DataGridView8.GridColor = System.Drawing.Color.MediumPurple
        Me.DataGridView8.Location = New System.Drawing.Point(9, 50)
        Me.DataGridView8.Name = "DataGridView8"
        Me.DataGridView8.ReadOnly = True
        Me.DataGridView8.ShowCellErrors = False
        Me.DataGridView8.ShowRowErrors = False
        Me.DataGridView8.Size = New System.Drawing.Size(647, 445)
        Me.DataGridView8.StandardTab = True
        Me.DataGridView8.TabIndex = 18
        '
        'btnGenerarResumen
        '
        Me.btnGenerarResumen.BackColor = System.Drawing.SystemColors.Control
        Me.btnGenerarResumen.Location = New System.Drawing.Point(728, 133)
        Me.btnGenerarResumen.Name = "btnGenerarResumen"
        Me.btnGenerarResumen.Size = New System.Drawing.Size(103, 41)
        Me.btnGenerarResumen.TabIndex = 21
        Me.btnGenerarResumen.Text = "Generar Resumen"
        Me.ttSaldoActual.SetToolTip(Me.btnGenerarResumen, "Genera el resumen del periodo")
        Me.btnGenerarResumen.UseVisualStyleBackColor = False
        '
        'tpConsulta
        '
        Me.tpConsulta.Controls.Add(Me.dtpFin)
        Me.tpConsulta.Controls.Add(Me.Label12)
        Me.tpConsulta.Controls.Add(Me.dtpInicio)
        Me.tpConsulta.Controls.Add(Me.Label1)
        Me.tpConsulta.Controls.Add(Me.btnConsulta_3)
        Me.tpConsulta.Controls.Add(Me.btnConsulta_2)
        Me.tpConsulta.Controls.Add(Me.btnConsulta_1)
        Me.tpConsulta.Location = New System.Drawing.Point(4, 22)
        Me.tpConsulta.Name = "tpConsulta"
        Me.tpConsulta.Size = New System.Drawing.Size(868, 503)
        Me.tpConsulta.TabIndex = 8
        Me.tpConsulta.Text = "Consultas"
        Me.tpConsulta.UseVisualStyleBackColor = True
        '
        'btnConsulta_3
        '
        Me.btnConsulta_3.Location = New System.Drawing.Point(93, 177)
        Me.btnConsulta_3.Name = "btnConsulta_3"
        Me.btnConsulta_3.Size = New System.Drawing.Size(153, 23)
        Me.btnConsulta_3.TabIndex = 2
        Me.btnConsulta_3.Text = "Egresos por tipo de egreso"
        Me.btnConsulta_3.UseVisualStyleBackColor = True
        '
        'btnConsulta_2
        '
        Me.btnConsulta_2.Location = New System.Drawing.Point(93, 130)
        Me.btnConsulta_2.Name = "btnConsulta_2"
        Me.btnConsulta_2.Size = New System.Drawing.Size(153, 23)
        Me.btnConsulta_2.TabIndex = 1
        Me.btnConsulta_2.Text = "Ingresos entre fechas"
        Me.btnConsulta_2.UseVisualStyleBackColor = True
        '
        'btnConsulta_1
        '
        Me.btnConsulta_1.Location = New System.Drawing.Point(93, 85)
        Me.btnConsulta_1.Name = "btnConsulta_1"
        Me.btnConsulta_1.Size = New System.Drawing.Size(153, 23)
        Me.btnConsulta_1.TabIndex = 0
        Me.btnConsulta_1.Text = "Egresos entre fechas"
        Me.btnConsulta_1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Btnimprime)
        Me.GroupBox1.Controls.Add(Me.btnBorrar)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.btnModificar)
        Me.GroupBox1.Controls.Add(Me.btnSalir)
        Me.GroupBox1.Location = New System.Drawing.Point(899, 163)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(100, 510)
        Me.GroupBox1.TabIndex = 419
        Me.GroupBox1.TabStop = False
        '
        'Btnimprime
        '
        Me.Btnimprime.BackColor = System.Drawing.Color.Gainsboro
        Me.Btnimprime.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnimprime.Image = CType(resources.GetObject("Btnimprime.Image"), System.Drawing.Image)
        Me.Btnimprime.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btnimprime.Location = New System.Drawing.Point(12, 292)
        Me.Btnimprime.Name = "Btnimprime"
        Me.Btnimprime.Size = New System.Drawing.Size(82, 75)
        Me.Btnimprime.TabIndex = 10
        Me.Btnimprime.Text = "&Imprimir"
        Me.Btnimprime.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btnimprime.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.Color.Gainsboro
        Me.btnBorrar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar.Image = CType(resources.GetObject("btnBorrar.Image"), System.Drawing.Image)
        Me.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBorrar.Location = New System.Drawing.Point(12, 88)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(82, 68)
        Me.btnBorrar.TabIndex = 7
        Me.btnBorrar.Text = "&Borrar"
        Me.btnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.Gainsboro
        Me.btnAgregar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAgregar.Location = New System.Drawing.Point(12, 16)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(82, 68)
        Me.btnAgregar.TabIndex = 6
        Me.btnAgregar.Text = "&Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.Gainsboro
        Me.btnModificar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModificar.Location = New System.Drawing.Point(12, 160)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(82, 68)
        Me.btnModificar.TabIndex = 8
        Me.btnModificar.Text = "&Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(12, 430)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(82, 68)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnBuscaEmpresa
        '
        Me.btnBuscaEmpresa.BackColor = System.Drawing.Color.Gainsboro
        Me.btnBuscaEmpresa.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnBuscaEmpresa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnBuscaEmpresa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBuscaEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscaEmpresa.Image = CType(resources.GetObject("btnBuscaEmpresa.Image"), System.Drawing.Image)
        Me.btnBuscaEmpresa.Location = New System.Drawing.Point(414, 35)
        Me.btnBuscaEmpresa.Name = "btnBuscaEmpresa"
        Me.btnBuscaEmpresa.Size = New System.Drawing.Size(40, 32)
        Me.btnBuscaEmpresa.TabIndex = 405
        Me.btnBuscaEmpresa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBuscaEmpresa.UseVisualStyleBackColor = False
        '
        'dtpFin
        '
        Me.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFin.Location = New System.Drawing.Point(294, 28)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(102, 20)
        Me.dtpFin.TabIndex = 652
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(219, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 13)
        Me.Label12.TabIndex = 653
        Me.Label12.Text = "Fecha de Fin"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpInicio
        '
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicio.Location = New System.Drawing.Point(103, 28)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(110, 20)
        Me.dtpInicio.TabIndex = 650
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(17, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 651
        Me.Label1.Text = "Fecha de Inicio"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmResumenCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1016, 734)
        Me.Controls.Add(Me.lblResumen)
        Me.Controls.Add(Me.lblidGasto)
        Me.Controls.Add(Me.lblidTransferenciaBancaria)
        Me.Controls.Add(Me.lblidDepositoEfectivo)
        Me.Controls.Add(Me.lblidCredito)
        Me.Controls.Add(Me.lblidCuenta)
        Me.Controls.Add(Me.lblidBanco)
        Me.Controls.Add(Me.btnBuscaEmpresa)
        Me.Controls.Add(Me.lblidChequeLibrado)
        Me.Controls.Add(Me.lblidChequeRecibido)
        Me.Controls.Add(Me.lblidDebito)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbEmpresa)
        Me.Controls.Add(Me.dtpPeriodo)
        Me.Controls.Add(Me.lblidEmpresa)
        Me.Controls.Add(Me.lblempresa)
        Me.Controls.Add(Me.TCCaja)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmResumenCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmResumenCaja"
        Me.TCCaja.ResumeLayout(False)
        Me.cheque_recibido.ResumeLayout(False)
        Me.cheque_recibido.PerformLayout()
        CType(Me.dgvChequeCobro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvChequeRecibido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Ingreso.ResumeLayout(False)
        CType(Me.dgvIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Egreso.ResumeLayout(False)
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Resumen.ResumeLayout(False)
        Me.Resumen.PerformLayout()
        CType(Me.DataGridView8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpConsulta.ResumeLayout(False)
        Me.tpConsulta.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblResumen As System.Windows.Forms.Label
    Friend WithEvents lblidGasto As System.Windows.Forms.Label
    Friend WithEvents lblidTransferenciaBancaria As System.Windows.Forms.Label
    Friend WithEvents lblidDepositoEfectivo As System.Windows.Forms.Label
    Friend WithEvents lblidCredito As System.Windows.Forms.Label
    Friend WithEvents lblidCuenta As System.Windows.Forms.Label
    Friend WithEvents lblidBanco As System.Windows.Forms.Label
    Friend WithEvents btnBuscaEmpresa As System.Windows.Forms.Button
    Friend WithEvents lblidChequeLibrado As System.Windows.Forms.Label
    Friend WithEvents Btnimprime As System.Windows.Forms.Button
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents lblidChequeRecibido As System.Windows.Forms.Label
    Friend WithEvents lblidDebito As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbEmpresa As System.Windows.Forms.ComboBox
    Friend WithEvents dtpPeriodo As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblidEmpresa As System.Windows.Forms.Label
    Friend WithEvents lblempresa As System.Windows.Forms.Label
    Friend WithEvents TCCaja As System.Windows.Forms.TabControl
    Friend WithEvents cheque_recibido As System.Windows.Forms.TabPage
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents dgvChequeCobro As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgvChequeRecibido As System.Windows.Forms.DataGridView
    Friend WithEvents Ingreso As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dgvIngreso As System.Windows.Forms.DataGridView
    Friend WithEvents Egreso As System.Windows.Forms.TabPage
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DataGridView5 As System.Windows.Forms.DataGridView
    Friend WithEvents Resumen As System.Windows.Forms.TabPage
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtSaldoContable As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalGrilla As System.Windows.Forms.Label
    Friend WithEvents btnSaldoActual As System.Windows.Forms.Button
    Friend WithEvents ttSaldoActual As System.Windows.Forms.ToolTip
    Friend WithEvents btnModificarPeriodo As System.Windows.Forms.Button
    Friend WithEvents btnCierrePeriodo As System.Windows.Forms.Button
    Friend WithEvents lblSaldoActual As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblSaldoAnterior As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DataGridView8 As System.Windows.Forms.DataGridView
    Friend WithEvents btnGenerarResumen As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tpConsulta As System.Windows.Forms.TabPage
    Friend WithEvents btnConsulta_3 As System.Windows.Forms.Button
    Friend WithEvents btnConsulta_2 As System.Windows.Forms.Button
    Friend WithEvents btnConsulta_1 As System.Windows.Forms.Button
    Protected WithEvents dtpFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Protected WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
