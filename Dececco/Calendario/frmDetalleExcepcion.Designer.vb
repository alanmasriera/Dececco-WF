<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleExcepcion
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.rdNoLaborable = New System.Windows.Forms.RadioButton()
        Me.rdLaborable = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.numTerminarVeces = New System.Windows.Forms.NumericUpDown()
        Me.dtFin = New System.Windows.Forms.DateTimePicker()
        Me.rdTerminarFecha = New System.Windows.Forms.RadioButton()
        Me.rdTerminarVeces = New System.Windows.Forms.RadioButton()
        Me.dtInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rdAnual = New System.Windows.Forms.RadioButton()
        Me.rdUnicaVez = New System.Windows.Forms.RadioButton()
        Me.rdDiario = New System.Windows.Forms.RadioButton()
        Me.rdMensual = New System.Windows.Forms.RadioButton()
        Me.rdSemanal = New System.Windows.Forms.RadioButton()
        Me.PanelGeneral = New System.Windows.Forms.Panel()
        Me.PanelSemanal = New System.Windows.Forms.Panel()
        Me.chkMiercoles = New System.Windows.Forms.CheckBox()
        Me.chkSabado = New System.Windows.Forms.CheckBox()
        Me.chkMartes = New System.Windows.Forms.CheckBox()
        Me.chkViernes = New System.Windows.Forms.CheckBox()
        Me.chkLunes = New System.Windows.Forms.CheckBox()
        Me.chkJueves = New System.Windows.Forms.CheckBox()
        Me.chkDomingo = New System.Windows.Forms.CheckBox()
        Me.PanelMensual = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.numDiaMes = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PanelAnual = New System.Windows.Forms.Panel()
        Me.dtAnual = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PanelUnicaVez = New System.Windows.Forms.Panel()
        Me.PanelDiario = New System.Windows.Forms.Panel()
        Me.numCantDias = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgv_detalle_periodo = New System.Windows.Forms.DataGridView()
        Me.hora_inicio_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hora_fin_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2.SuspendLayout
        CType(Me.numTerminarVeces,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TableLayoutPanel1.SuspendLayout
        Me.Panel1.SuspendLayout
        Me.PanelGeneral.SuspendLayout
        Me.PanelSemanal.SuspendLayout
        Me.PanelMensual.SuspendLayout
        CType(Me.numDiaMes,System.ComponentModel.ISupportInitialize).BeginInit
        Me.PanelAnual.SuspendLayout
        Me.PanelDiario.SuspendLayout
        CType(Me.numCantDias,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.dgv_detalle_periodo,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'rdNoLaborable
        '
        Me.rdNoLaborable.AutoSize = true
        Me.rdNoLaborable.Location = New System.Drawing.Point(28, 23)
        Me.rdNoLaborable.Name = "rdNoLaborable"
        Me.rdNoLaborable.Size = New System.Drawing.Size(85, 17)
        Me.rdNoLaborable.TabIndex = 0
        Me.rdNoLaborable.TabStop = true
        Me.rdNoLaborable.Text = "No laborable"
        Me.rdNoLaborable.UseVisualStyleBackColor = true
        '
        'rdLaborable
        '
        Me.rdLaborable.AutoSize = true
        Me.rdLaborable.Location = New System.Drawing.Point(28, 46)
        Me.rdLaborable.Name = "rdLaborable"
        Me.rdLaborable.Size = New System.Drawing.Size(119, 17)
        Me.rdLaborable.TabIndex = 1
        Me.rdLaborable.TabStop = true
        Me.rdLaborable.Text = "Períodos laborables"
        Me.rdLaborable.UseVisualStyleBackColor = true
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.numTerminarVeces)
        Me.GroupBox2.Controls.Add(Me.dtFin)
        Me.GroupBox2.Controls.Add(Me.rdTerminarFecha)
        Me.GroupBox2.Controls.Add(Me.rdTerminarVeces)
        Me.GroupBox2.Controls.Add(Me.dtInicio)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 417)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(484, 104)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = false
        Me.GroupBox2.Text = "Intervalo de repetición"
        '
        'numTerminarVeces
        '
        Me.numTerminarVeces.Location = New System.Drawing.Point(356, 28)
        Me.numTerminarVeces.Name = "numTerminarVeces"
        Me.numTerminarVeces.Size = New System.Drawing.Size(64, 20)
        Me.numTerminarVeces.TabIndex = 6
        '
        'dtFin
        '
        Me.dtFin.CustomFormat = "dd/MM/yyyy"
        Me.dtFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFin.Location = New System.Drawing.Point(309, 59)
        Me.dtFin.Name = "dtFin"
        Me.dtFin.Size = New System.Drawing.Size(111, 20)
        Me.dtFin.TabIndex = 5
        '
        'rdTerminarFecha
        '
        Me.rdTerminarFecha.AutoSize = true
        Me.rdTerminarFecha.Checked = true
        Me.rdTerminarFecha.Location = New System.Drawing.Point(223, 62)
        Me.rdTerminarFecha.Name = "rdTerminarFecha"
        Me.rdTerminarFecha.Size = New System.Drawing.Size(80, 17)
        Me.rdTerminarFecha.TabIndex = 4
        Me.rdTerminarFecha.TabStop = true
        Me.rdTerminarFecha.Text = "Terminar el:"
        Me.rdTerminarFecha.UseVisualStyleBackColor = true
        '
        'rdTerminarVeces
        '
        Me.rdTerminarVeces.AutoSize = true
        Me.rdTerminarVeces.Location = New System.Drawing.Point(223, 30)
        Me.rdTerminarVeces.Name = "rdTerminarVeces"
        Me.rdTerminarVeces.Size = New System.Drawing.Size(127, 17)
        Me.rdTerminarVeces.TabIndex = 3
        Me.rdTerminarVeces.Text = "Terminar después de:"
        Me.rdTerminarVeces.UseVisualStyleBackColor = true
        '
        'dtInicio
        '
        Me.dtInicio.CustomFormat = "dd/MM/yyyy"
        Me.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtInicio.Location = New System.Drawing.Point(71, 28)
        Me.dtInicio.Name = "dtInicio"
        Me.dtInicio.Size = New System.Drawing.Size(111, 20)
        Me.dtInicio.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(430, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "veces"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(9, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cominezo:"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(343, 539)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 10
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = true
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(433, 539)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 9
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = true
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.80451!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.19549!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PanelGeneral, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 246)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 148!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 148!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 148!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 148!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(496, 148)
        Me.TableLayoutPanel1.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rdAnual)
        Me.Panel1.Controls.Add(Me.rdUnicaVez)
        Me.Panel1.Controls.Add(Me.rdDiario)
        Me.Panel1.Controls.Add(Me.rdMensual)
        Me.Panel1.Controls.Add(Me.rdSemanal)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(102, 142)
        Me.Panel1.TabIndex = 0
        '
        'rdAnual
        '
        Me.rdAnual.AutoSize = true
        Me.rdAnual.Location = New System.Drawing.Point(15, 107)
        Me.rdAnual.Name = "rdAnual"
        Me.rdAnual.Size = New System.Drawing.Size(52, 17)
        Me.rdAnual.TabIndex = 8
        Me.rdAnual.Text = "Anual"
        Me.rdAnual.UseVisualStyleBackColor = true
        '
        'rdUnicaVez
        '
        Me.rdUnicaVez.AutoSize = true
        Me.rdUnicaVez.Location = New System.Drawing.Point(15, 15)
        Me.rdUnicaVez.Name = "rdUnicaVez"
        Me.rdUnicaVez.Size = New System.Drawing.Size(73, 17)
        Me.rdUnicaVez.TabIndex = 4
        Me.rdUnicaVez.Text = "Única vez"
        Me.rdUnicaVez.UseVisualStyleBackColor = true
        '
        'rdDiario
        '
        Me.rdDiario.AutoSize = true
        Me.rdDiario.Location = New System.Drawing.Point(15, 38)
        Me.rdDiario.Name = "rdDiario"
        Me.rdDiario.Size = New System.Drawing.Size(52, 17)
        Me.rdDiario.TabIndex = 5
        Me.rdDiario.Text = "Diario"
        Me.rdDiario.UseVisualStyleBackColor = true
        '
        'rdMensual
        '
        Me.rdMensual.AutoSize = true
        Me.rdMensual.Location = New System.Drawing.Point(15, 84)
        Me.rdMensual.Name = "rdMensual"
        Me.rdMensual.Size = New System.Drawing.Size(65, 17)
        Me.rdMensual.TabIndex = 7
        Me.rdMensual.Text = "Mensual"
        Me.rdMensual.UseVisualStyleBackColor = true
        '
        'rdSemanal
        '
        Me.rdSemanal.AutoSize = true
        Me.rdSemanal.Location = New System.Drawing.Point(15, 61)
        Me.rdSemanal.Name = "rdSemanal"
        Me.rdSemanal.Size = New System.Drawing.Size(66, 17)
        Me.rdSemanal.TabIndex = 6
        Me.rdSemanal.Text = "Semanal"
        Me.rdSemanal.UseVisualStyleBackColor = true
        '
        'PanelGeneral
        '
        Me.PanelGeneral.Controls.Add(Me.PanelMensual)
        Me.PanelGeneral.Controls.Add(Me.PanelAnual)
        Me.PanelGeneral.Controls.Add(Me.PanelUnicaVez)
        Me.PanelGeneral.Controls.Add(Me.PanelDiario)
        Me.PanelGeneral.Controls.Add(Me.PanelSemanal)
        Me.PanelGeneral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelGeneral.Location = New System.Drawing.Point(111, 3)
        Me.PanelGeneral.Name = "PanelGeneral"
        Me.PanelGeneral.Size = New System.Drawing.Size(382, 142)
        Me.PanelGeneral.TabIndex = 0
        '
        'PanelSemanal
        '
        Me.PanelSemanal.Controls.Add(Me.chkMiercoles)
        Me.PanelSemanal.Controls.Add(Me.chkSabado)
        Me.PanelSemanal.Controls.Add(Me.chkMartes)
        Me.PanelSemanal.Controls.Add(Me.chkViernes)
        Me.PanelSemanal.Controls.Add(Me.chkLunes)
        Me.PanelSemanal.Controls.Add(Me.chkJueves)
        Me.PanelSemanal.Controls.Add(Me.chkDomingo)
        Me.PanelSemanal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelSemanal.Location = New System.Drawing.Point(0, 0)
        Me.PanelSemanal.Name = "PanelSemanal"
        Me.PanelSemanal.Size = New System.Drawing.Size(382, 142)
        Me.PanelSemanal.TabIndex = 1
        '
        'chkMiercoles
        '
        Me.chkMiercoles.AutoSize = true
        Me.chkMiercoles.Location = New System.Drawing.Point(257, 29)
        Me.chkMiercoles.Name = "chkMiercoles"
        Me.chkMiercoles.Size = New System.Drawing.Size(71, 17)
        Me.chkMiercoles.TabIndex = 7
        Me.chkMiercoles.Text = "Miércoles"
        Me.chkMiercoles.UseVisualStyleBackColor = true
        '
        'chkSabado
        '
        Me.chkSabado.AutoSize = true
        Me.chkSabado.Location = New System.Drawing.Point(183, 63)
        Me.chkSabado.Name = "chkSabado"
        Me.chkSabado.Size = New System.Drawing.Size(63, 17)
        Me.chkSabado.TabIndex = 6
        Me.chkSabado.Text = "Sábado"
        Me.chkSabado.UseVisualStyleBackColor = true
        '
        'chkMartes
        '
        Me.chkMartes.AutoSize = true
        Me.chkMartes.Location = New System.Drawing.Point(183, 30)
        Me.chkMartes.Name = "chkMartes"
        Me.chkMartes.Size = New System.Drawing.Size(58, 17)
        Me.chkMartes.TabIndex = 5
        Me.chkMartes.Text = "Martes"
        Me.chkMartes.UseVisualStyleBackColor = true
        '
        'chkViernes
        '
        Me.chkViernes.AutoSize = true
        Me.chkViernes.Location = New System.Drawing.Point(98, 63)
        Me.chkViernes.Name = "chkViernes"
        Me.chkViernes.Size = New System.Drawing.Size(61, 17)
        Me.chkViernes.TabIndex = 4
        Me.chkViernes.Text = "Viernes"
        Me.chkViernes.UseVisualStyleBackColor = true
        '
        'chkLunes
        '
        Me.chkLunes.AutoSize = true
        Me.chkLunes.Location = New System.Drawing.Point(98, 30)
        Me.chkLunes.Name = "chkLunes"
        Me.chkLunes.Size = New System.Drawing.Size(55, 17)
        Me.chkLunes.TabIndex = 3
        Me.chkLunes.Text = "Lunes"
        Me.chkLunes.UseVisualStyleBackColor = true
        '
        'chkJueves
        '
        Me.chkJueves.AutoSize = true
        Me.chkJueves.Location = New System.Drawing.Point(15, 62)
        Me.chkJueves.Name = "chkJueves"
        Me.chkJueves.Size = New System.Drawing.Size(60, 17)
        Me.chkJueves.TabIndex = 2
        Me.chkJueves.Text = "Jueves"
        Me.chkJueves.UseVisualStyleBackColor = true
        '
        'chkDomingo
        '
        Me.chkDomingo.AutoSize = true
        Me.chkDomingo.Location = New System.Drawing.Point(15, 29)
        Me.chkDomingo.Name = "chkDomingo"
        Me.chkDomingo.Size = New System.Drawing.Size(68, 17)
        Me.chkDomingo.TabIndex = 1
        Me.chkDomingo.Text = "Domingo"
        Me.chkDomingo.UseVisualStyleBackColor = true
        '
        'PanelMensual
        '
        Me.PanelMensual.Controls.Add(Me.Label7)
        Me.PanelMensual.Controls.Add(Me.numDiaMes)
        Me.PanelMensual.Controls.Add(Me.Label6)
        Me.PanelMensual.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMensual.Location = New System.Drawing.Point(0, 0)
        Me.PanelMensual.Name = "PanelMensual"
        Me.PanelMensual.Size = New System.Drawing.Size(382, 142)
        Me.PanelMensual.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Location = New System.Drawing.Point(140, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "de cada mes"
        '
        'numDiaMes
        '
        Me.numDiaMes.Location = New System.Drawing.Point(63, 29)
        Me.numDiaMes.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.numDiaMes.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numDiaMes.Name = "numDiaMes"
        Me.numDiaMes.Size = New System.Drawing.Size(71, 20)
        Me.numDiaMes.TabIndex = 10
        Me.numDiaMes.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Location = New System.Drawing.Point(32, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Día"
        '
        'PanelAnual
        '
        Me.PanelAnual.Controls.Add(Me.dtAnual)
        Me.PanelAnual.Controls.Add(Me.Label8)
        Me.PanelAnual.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelAnual.Location = New System.Drawing.Point(0, 0)
        Me.PanelAnual.Name = "PanelAnual"
        Me.PanelAnual.Size = New System.Drawing.Size(382, 142)
        Me.PanelAnual.TabIndex = 11
        '
        'dtAnual
        '
        Me.dtAnual.CustomFormat = "d MMMM"
        Me.dtAnual.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtAnual.Location = New System.Drawing.Point(57, 26)
        Me.dtAnual.Name = "dtAnual"
        Me.dtAnual.Size = New System.Drawing.Size(151, 20)
        Me.dtAnual.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Location = New System.Drawing.Point(32, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "El "
        '
        'PanelUnicaVez
        '
        Me.PanelUnicaVez.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelUnicaVez.Location = New System.Drawing.Point(0, 0)
        Me.PanelUnicaVez.Name = "PanelUnicaVez"
        Me.PanelUnicaVez.Size = New System.Drawing.Size(382, 142)
        Me.PanelUnicaVez.TabIndex = 8
        '
        'PanelDiario
        '
        Me.PanelDiario.Controls.Add(Me.numCantDias)
        Me.PanelDiario.Controls.Add(Me.Label4)
        Me.PanelDiario.Controls.Add(Me.Label3)
        Me.PanelDiario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDiario.Location = New System.Drawing.Point(0, 0)
        Me.PanelDiario.Name = "PanelDiario"
        Me.PanelDiario.Size = New System.Drawing.Size(382, 142)
        Me.PanelDiario.TabIndex = 9
        '
        'numCantDias
        '
        Me.numCantDias.Location = New System.Drawing.Point(50, 15)
        Me.numCantDias.Maximum = New Decimal(New Integer() {9000, 0, 0, 0})
        Me.numCantDias.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numCantDias.Name = "numCantDias"
        Me.numCantDias.Size = New System.Drawing.Size(52, 20)
        Me.numCantDias.TabIndex = 2
        Me.numCantDias.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(108, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "días"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(12, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Cada"
        '
        'dgv_detalle_periodo
        '
        Me.dgv_detalle_periodo.AllowUserToAddRows = false
        Me.dgv_detalle_periodo.AllowUserToDeleteRows = false
        Me.dgv_detalle_periodo.AllowUserToResizeColumns = false
        Me.dgv_detalle_periodo.AllowUserToResizeRows = false
        Me.dgv_detalle_periodo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_detalle_periodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detalle_periodo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.hora_inicio_dgv, Me.hora_fin_dgv})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte), true)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.NullValue = Nothing
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_detalle_periodo.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_detalle_periodo.Location = New System.Drawing.Point(36, 82)
        Me.dgv_detalle_periodo.Name = "dgv_detalle_periodo"
        Me.dgv_detalle_periodo.RowHeadersVisible = false
        Me.dgv_detalle_periodo.Size = New System.Drawing.Size(205, 137)
        Me.dgv_detalle_periodo.TabIndex = 12
        '
        'hora_inicio_dgv
        '
        DataGridViewCellStyle1.Format = "T"
        DataGridViewCellStyle1.NullValue = """"""
        Me.hora_inicio_dgv.DefaultCellStyle = DataGridViewCellStyle1
        Me.hora_inicio_dgv.HeaderText = "Comienzo"
        Me.hora_inicio_dgv.Name = "hora_inicio_dgv"
        '
        'hora_fin_dgv
        '
        DataGridViewCellStyle2.Format = "T"
        DataGridViewCellStyle2.NullValue = """"""
        Me.hora_fin_dgv.DefaultCellStyle = DataGridViewCellStyle2
        Me.hora_fin_dgv.HeaderText = "Fin"
        Me.hora_fin_dgv.Name = "hora_fin_dgv"
        '
        'frmDetalleExcepcion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 571)
        Me.Controls.Add(Me.dgv_detalle_periodo)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.rdLaborable)
        Me.Controls.Add(Me.rdNoLaborable)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = false
        Me.Name = "frmDetalleExcepcion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Detalle de excepción"
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox2.PerformLayout
        CType(Me.numTerminarVeces,System.ComponentModel.ISupportInitialize).EndInit
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.PanelGeneral.ResumeLayout(false)
        Me.PanelSemanal.ResumeLayout(false)
        Me.PanelSemanal.PerformLayout
        Me.PanelMensual.ResumeLayout(false)
        Me.PanelMensual.PerformLayout
        CType(Me.numDiaMes,System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelAnual.ResumeLayout(false)
        Me.PanelAnual.PerformLayout
        Me.PanelDiario.ResumeLayout(false)
        Me.PanelDiario.PerformLayout
        CType(Me.numCantDias,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.dgv_detalle_periodo,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents rdNoLaborable As RadioButton
    Friend WithEvents rdLaborable As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents numTerminarVeces As NumericUpDown
    Friend WithEvents dtFin As DateTimePicker
    Friend WithEvents rdTerminarFecha As RadioButton
    Friend WithEvents rdTerminarVeces As RadioButton
    Friend WithEvents dtInicio As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rdAnual As RadioButton
    Friend WithEvents rdUnicaVez As RadioButton
    Friend WithEvents rdDiario As RadioButton
    Friend WithEvents rdMensual As RadioButton
    Friend WithEvents rdSemanal As RadioButton
    Friend WithEvents PanelGeneral As Panel
    Friend WithEvents PanelDiario As Panel
    Friend WithEvents PanelSemanal As Panel
    Friend WithEvents chkMiercoles As CheckBox
    Friend WithEvents chkSabado As CheckBox
    Friend WithEvents chkMartes As CheckBox
    Friend WithEvents chkViernes As CheckBox
    Friend WithEvents chkLunes As CheckBox
    Friend WithEvents chkJueves As CheckBox
    Friend WithEvents chkDomingo As CheckBox
    Friend WithEvents PanelMensual As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents numDiaMes As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents PanelAnual As Panel
    Friend WithEvents dtAnual As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents PanelUnicaVez As Panel
    Friend WithEvents dgv_detalle_periodo As DataGridView
    Friend WithEvents numCantDias As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents hora_inicio_dgv As DataGridViewTextBoxColumn
    Friend WithEvents hora_fin_dgv As DataGridViewTextBoxColumn
End Class
