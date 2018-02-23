<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleFactura_recibo
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleFactura_recibo))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtNumero_8 = New System.Windows.Forms.TextBox
        Me.txtNumero_4 = New System.Windows.Forms.TextBox
        Me.txtImporte_factura = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtSaldo_factura = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtImporte_pagado = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.chkEfectivo = New System.Windows.Forms.CheckBox
        Me.txtNumero_cheque = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblid_banco = New System.Windows.Forms.Label
        Me.btnBuscaBanco = New System.Windows.Forms.Button
        Me.cmbBanco = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtPlaza_cheque = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtpFecha_pago = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblid_pk = New System.Windows.Forms.Label
        Me.dgv1 = New System.Windows.Forms.DataGridView
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.btnSalir = New System.Windows.Forms.Button
        Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.lblid_proveedor = New System.Windows.Forms.Label
        Me.cmbProveedor = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblid_factura = New System.Windows.Forms.Label
        Me.lblid_recibo = New System.Windows.Forms.Label
        Me.btnBuscaCheque_librado = New System.Windows.Forms.Button
        Me.txtSaldo_nuevo = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.chkConservarCheque = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnConsulta = New System.Windows.Forms.Button
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(473, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 21)
        Me.Label7.TabIndex = 617
        Me.Label7.Text = "Factura"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNumero_8
        '
        Me.txtNumero_8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero_8.Location = New System.Drawing.Point(700, 101)
        Me.txtNumero_8.MaxLength = 8
        Me.txtNumero_8.Name = "txtNumero_8"
        Me.txtNumero_8.Size = New System.Drawing.Size(135, 20)
        Me.txtNumero_8.TabIndex = 616
        Me.txtNumero_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNumero_4
        '
        Me.txtNumero_4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero_4.Location = New System.Drawing.Point(613, 101)
        Me.txtNumero_4.MaxLength = 4
        Me.txtNumero_4.Name = "txtNumero_4"
        Me.txtNumero_4.Size = New System.Drawing.Size(72, 20)
        Me.txtNumero_4.TabIndex = 615
        Me.txtNumero_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtImporte_factura
        '
        Me.txtImporte_factura.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtImporte_factura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtImporte_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporte_factura.ForeColor = System.Drawing.Color.Blue
        Me.txtImporte_factura.Location = New System.Drawing.Point(612, 147)
        Me.txtImporte_factura.MaxLength = 50
        Me.txtImporte_factura.Name = "txtImporte_factura"
        Me.txtImporte_factura.ReadOnly = True
        Me.txtImporte_factura.Size = New System.Drawing.Size(222, 31)
        Me.txtImporte_factura.TabIndex = 618
        Me.txtImporte_factura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(473, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 21)
        Me.Label6.TabIndex = 619
        Me.Label6.Text = "Importe Factura"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSaldo_factura
        '
        Me.txtSaldo_factura.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSaldo_factura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSaldo_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo_factura.ForeColor = System.Drawing.Color.Blue
        Me.txtSaldo_factura.Location = New System.Drawing.Point(613, 200)
        Me.txtSaldo_factura.MaxLength = 50
        Me.txtSaldo_factura.Name = "txtSaldo_factura"
        Me.txtSaldo_factura.ReadOnly = True
        Me.txtSaldo_factura.Size = New System.Drawing.Size(222, 31)
        Me.txtSaldo_factura.TabIndex = 620
        Me.txtSaldo_factura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(474, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 21)
        Me.Label1.TabIndex = 621
        Me.Label1.Text = "Saldo Factura"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtImporte_pagado
        '
        Me.txtImporte_pagado.BackColor = System.Drawing.Color.White
        Me.txtImporte_pagado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtImporte_pagado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporte_pagado.ForeColor = System.Drawing.Color.Blue
        Me.txtImporte_pagado.Location = New System.Drawing.Point(613, 258)
        Me.txtImporte_pagado.MaxLength = 50
        Me.txtImporte_pagado.Name = "txtImporte_pagado"
        Me.txtImporte_pagado.Size = New System.Drawing.Size(222, 31)
        Me.txtImporte_pagado.TabIndex = 622
        Me.txtImporte_pagado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(474, 258)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 21)
        Me.Label2.TabIndex = 623
        Me.Label2.Text = "Importe Pagado"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(474, 370)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 21)
        Me.Label8.TabIndex = 625
        Me.Label8.Text = "En Efectivo"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkEfectivo
        '
        Me.chkEfectivo.AutoSize = True
        Me.chkEfectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEfectivo.Location = New System.Drawing.Point(623, 370)
        Me.chkEfectivo.Name = "chkEfectivo"
        Me.chkEfectivo.Size = New System.Drawing.Size(15, 14)
        Me.chkEfectivo.TabIndex = 624
        Me.chkEfectivo.UseVisualStyleBackColor = True
        '
        'txtNumero_cheque
        '
        Me.txtNumero_cheque.BackColor = System.Drawing.Color.White
        Me.txtNumero_cheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero_cheque.Location = New System.Drawing.Point(613, 413)
        Me.txtNumero_cheque.MaxLength = 50
        Me.txtNumero_cheque.Name = "txtNumero_cheque"
        Me.txtNumero_cheque.Size = New System.Drawing.Size(299, 20)
        Me.txtNumero_cheque.TabIndex = 626
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(474, 412)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 21)
        Me.Label4.TabIndex = 627
        Me.Label4.Text = "Numero Cheque"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_banco
        '
        Me.lblid_banco.AutoSize = True
        Me.lblid_banco.BackColor = System.Drawing.Color.Red
        Me.lblid_banco.Location = New System.Drawing.Point(797, 464)
        Me.lblid_banco.Name = "lblid_banco"
        Me.lblid_banco.Size = New System.Drawing.Size(13, 13)
        Me.lblid_banco.TabIndex = 631
        Me.lblid_banco.Text = "0"
        Me.lblid_banco.Visible = False
        '
        'btnBuscaBanco
        '
        Me.btnBuscaBanco.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscaBanco.Image = CType(resources.GetObject("btnBuscaBanco.Image"), System.Drawing.Image)
        Me.btnBuscaBanco.Location = New System.Drawing.Point(926, 459)
        Me.btnBuscaBanco.Name = "btnBuscaBanco"
        Me.btnBuscaBanco.Size = New System.Drawing.Size(41, 36)
        Me.btnBuscaBanco.TabIndex = 630
        Me.btnBuscaBanco.UseVisualStyleBackColor = True
        '
        'cmbBanco
        '
        Me.cmbBanco.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbBanco.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbBanco.FormattingEnabled = True
        Me.cmbBanco.Location = New System.Drawing.Point(612, 461)
        Me.cmbBanco.Name = "cmbBanco"
        Me.cmbBanco.Size = New System.Drawing.Size(299, 21)
        Me.cmbBanco.TabIndex = 628
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(472, 459)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 21)
        Me.Label5.TabIndex = 629
        Me.Label5.Text = "Banco"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPlaza_cheque
        '
        Me.txtPlaza_cheque.BackColor = System.Drawing.Color.White
        Me.txtPlaza_cheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlaza_cheque.Location = New System.Drawing.Point(612, 509)
        Me.txtPlaza_cheque.MaxLength = 50
        Me.txtPlaza_cheque.Name = "txtPlaza_cheque"
        Me.txtPlaza_cheque.Size = New System.Drawing.Size(299, 20)
        Me.txtPlaza_cheque.TabIndex = 632
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(473, 508)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 21)
        Me.Label3.TabIndex = 633
        Me.Label3.Text = "Plaza Cheque"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpFecha_pago
        '
        Me.dtpFecha_pago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha_pago.Location = New System.Drawing.Point(612, 555)
        Me.dtpFecha_pago.Name = "dtpFecha_pago"
        Me.dtpFecha_pago.Size = New System.Drawing.Size(93, 20)
        Me.dtpFecha_pago.TabIndex = 634
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(473, 554)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 21)
        Me.Label9.TabIndex = 635
        Me.Label9.Text = "Fecha Pago"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_pk
        '
        Me.lblid_pk.AutoSize = True
        Me.lblid_pk.BackColor = System.Drawing.Color.Red
        Me.lblid_pk.Location = New System.Drawing.Point(37, 112)
        Me.lblid_pk.Name = "lblid_pk"
        Me.lblid_pk.Size = New System.Drawing.Size(13, 13)
        Me.lblid_pk.TabIndex = 637
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
        Me.dgv1.Location = New System.Drawing.Point(31, 101)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.ShowCellErrors = False
        Me.dgv1.ShowRowErrors = False
        Me.dgv1.Size = New System.Drawing.Size(412, 559)
        Me.dgv1.StandardTab = True
        Me.dgv1.TabIndex = 636
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.SystemColors.Info
        Me.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.Green
        Me.txtTotal.Location = New System.Drawing.Point(258, 681)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(185, 31)
        Me.txtTotal.TabIndex = 657
        Me.txtTotal.TabStop = False
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(164, 681)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 21)
        Me.Label10.TabIndex = 658
        Me.Label10.Text = "Total"
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(831, 643)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(81, 69)
        Me.btnSalir.TabIndex = 660
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
        Me.btnGuardar.Location = New System.Drawing.Point(724, 643)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(78, 69)
        Me.btnGuardar.TabIndex = 659
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'lblid_proveedor
        '
        Me.lblid_proveedor.AutoSize = True
        Me.lblid_proveedor.BackColor = System.Drawing.Color.Red
        Me.lblid_proveedor.Location = New System.Drawing.Point(356, 48)
        Me.lblid_proveedor.Name = "lblid_proveedor"
        Me.lblid_proveedor.Size = New System.Drawing.Size(13, 13)
        Me.lblid_proveedor.TabIndex = 663
        Me.lblid_proveedor.Text = "0"
        Me.lblid_proveedor.Visible = False
        '
        'cmbProveedor
        '
        Me.cmbProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbProveedor.Enabled = False
        Me.cmbProveedor.FormattingEnabled = True
        Me.cmbProveedor.Location = New System.Drawing.Point(118, 45)
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.Size = New System.Drawing.Size(325, 21)
        Me.cmbProveedor.TabIndex = 661
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(31, 43)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 21)
        Me.Label11.TabIndex = 662
        Me.Label11.Text = "Proveedor"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_factura
        '
        Me.lblid_factura.AutoSize = True
        Me.lblid_factura.BackColor = System.Drawing.Color.Red
        Me.lblid_factura.Location = New System.Drawing.Point(625, 104)
        Me.lblid_factura.Name = "lblid_factura"
        Me.lblid_factura.Size = New System.Drawing.Size(13, 13)
        Me.lblid_factura.TabIndex = 664
        Me.lblid_factura.Text = "0"
        Me.lblid_factura.Visible = False
        '
        'lblid_recibo
        '
        Me.lblid_recibo.AutoSize = True
        Me.lblid_recibo.BackColor = System.Drawing.Color.Red
        Me.lblid_recibo.Location = New System.Drawing.Point(142, 19)
        Me.lblid_recibo.Name = "lblid_recibo"
        Me.lblid_recibo.Size = New System.Drawing.Size(13, 13)
        Me.lblid_recibo.TabIndex = 665
        Me.lblid_recibo.Text = "0"
        Me.lblid_recibo.Visible = False
        '
        'btnBuscaCheque_librado
        '
        Me.btnBuscaCheque_librado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscaCheque_librado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscaCheque_librado.Image = CType(resources.GetObject("btnBuscaCheque_librado.Image"), System.Drawing.Image)
        Me.btnBuscaCheque_librado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscaCheque_librado.Location = New System.Drawing.Point(739, 555)
        Me.btnBuscaCheque_librado.Name = "btnBuscaCheque_librado"
        Me.btnBuscaCheque_librado.Size = New System.Drawing.Size(173, 69)
        Me.btnBuscaCheque_librado.TabIndex = 669
        Me.btnBuscaCheque_librado.Text = "Registrar Cheque"
        Me.btnBuscaCheque_librado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscaCheque_librado.UseVisualStyleBackColor = True
        Me.btnBuscaCheque_librado.Visible = False
        '
        'txtSaldo_nuevo
        '
        Me.txtSaldo_nuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSaldo_nuevo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSaldo_nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo_nuevo.ForeColor = System.Drawing.Color.Blue
        Me.txtSaldo_nuevo.Location = New System.Drawing.Point(613, 312)
        Me.txtSaldo_nuevo.MaxLength = 50
        Me.txtSaldo_nuevo.Name = "txtSaldo_nuevo"
        Me.txtSaldo_nuevo.ReadOnly = True
        Me.txtSaldo_nuevo.Size = New System.Drawing.Size(222, 31)
        Me.txtSaldo_nuevo.TabIndex = 670
        Me.txtSaldo_nuevo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(474, 312)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(124, 21)
        Me.Label12.TabIndex = 671
        Me.Label12.Text = "Saldo Nuevo"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkConservarCheque
        '
        Me.chkConservarCheque.AutoSize = True
        Me.chkConservarCheque.ForeColor = System.Drawing.Color.Yellow
        Me.chkConservarCheque.Location = New System.Drawing.Point(474, 49)
        Me.chkConservarCheque.Name = "chkConservarCheque"
        Me.chkConservarCheque.Size = New System.Drawing.Size(159, 17)
        Me.chkConservarCheque.TabIndex = 673
        Me.chkConservarCheque.Text = "Conservar datos del cheque"
        Me.chkConservarCheque.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(474, 396)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(490, 8)
        Me.GroupBox1.TabIndex = 674
        Me.GroupBox1.TabStop = False
        '
        'btnConsulta
        '
        Me.btnConsulta.Location = New System.Drawing.Point(31, 682)
        Me.btnConsulta.Name = "btnConsulta"
        Me.btnConsulta.Size = New System.Drawing.Size(108, 30)
        Me.btnConsulta.TabIndex = 675
        Me.btnConsulta.Text = "Consultar saldos"
        Me.btnConsulta.UseVisualStyleBackColor = True
        '
        'frmDetalleFactura_recibo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 734)
        Me.Controls.Add(Me.btnConsulta)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chkConservarCheque)
        Me.Controls.Add(Me.txtSaldo_nuevo)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnBuscaCheque_librado)
        Me.Controls.Add(Me.lblid_recibo)
        Me.Controls.Add(Me.lblid_factura)
        Me.Controls.Add(Me.lblid_proveedor)
        Me.Controls.Add(Me.cmbProveedor)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblid_pk)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.dtpFecha_pago)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtPlaza_cheque)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblid_banco)
        Me.Controls.Add(Me.btnBuscaBanco)
        Me.Controls.Add(Me.cmbBanco)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNumero_cheque)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.chkEfectivo)
        Me.Controls.Add(Me.txtImporte_pagado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSaldo_factura)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtImporte_factura)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtNumero_8)
        Me.Controls.Add(Me.txtNumero_4)
        Me.Name = "frmDetalleFactura_recibo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetalleFactura_recibo"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNumero_8 As System.Windows.Forms.TextBox
    Friend WithEvents txtNumero_4 As System.Windows.Forms.TextBox
    Friend WithEvents txtImporte_factura As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSaldo_factura As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtImporte_pagado As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents chkEfectivo As System.Windows.Forms.CheckBox
    Friend WithEvents txtNumero_cheque As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblid_banco As System.Windows.Forms.Label
    Friend WithEvents btnBuscaBanco As System.Windows.Forms.Button
    Friend WithEvents cmbBanco As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPlaza_cheque As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha_pago As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Protected WithEvents lblid_pk As System.Windows.Forms.Label
    Protected WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents lblid_proveedor As System.Windows.Forms.Label
    Friend WithEvents cmbProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Protected WithEvents lblid_factura As System.Windows.Forms.Label
    Friend WithEvents lblid_recibo As System.Windows.Forms.Label
    Friend WithEvents btnBuscaCheque_librado As System.Windows.Forms.Button
    Friend WithEvents txtSaldo_nuevo As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents chkConservarCheque As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnConsulta As System.Windows.Forms.Button
End Class
