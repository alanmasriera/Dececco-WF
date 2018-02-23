<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmchequelibrado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmchequelibrado))
        Me.dtpFecha_pago = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecha_librado = New System.Windows.Forms.DateTimePicker()
        Me.Lblpago = New System.Windows.Forms.Label()
        Me.Lblfechalibrado = New System.Windows.Forms.Label()
        Me.txtNumero_cheque = New System.Windows.Forms.TextBox()
        Me.Lblnrocheque = New System.Windows.Forms.Label()
        Me.Cmbproveedor = New System.Windows.Forms.ComboBox()
        Me.Lblproveedor = New System.Windows.Forms.Label()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblidProveedor = New System.Windows.Forms.Label()
        Me.txtDetalle = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolTipsalir = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipguarda = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipcliente = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipbco = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnBuscaProveedor = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnBuscaChequera = New System.Windows.Forms.Button()
        Me.lblidChequera = New System.Windows.Forms.Label()
        Me.cmbChequera = New System.Windows.Forms.ComboBox()
        Me.lblChequera = New System.Windows.Forms.Label()
        Me.ttChequera = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblid_cuenta = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkTipo_cheque = New System.Windows.Forms.CheckBox()
        Me.txtiva = New System.Windows.Forms.TextBox()
        Me.etiquetaiva = New System.Windows.Forms.Label()
        Me.chkanulado = New System.Windows.Forms.CheckBox()
        Me.etiquetaanulado = New System.Windows.Forms.Label()
        Me.txtInicio = New System.Windows.Forms.TextBox()
        Me.lblInicio = New System.Windows.Forms.Label()
        Me.txtFin = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpFecha_pago
        '
        Me.dtpFecha_pago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha_pago.Location = New System.Drawing.Point(186, 252)
        Me.dtpFecha_pago.Name = "dtpFecha_pago"
        Me.dtpFecha_pago.Size = New System.Drawing.Size(138, 20)
        Me.dtpFecha_pago.TabIndex = 11
        '
        'dtpFecha_librado
        '
        Me.dtpFecha_librado.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha_librado.Location = New System.Drawing.Point(186, 215)
        Me.dtpFecha_librado.Name = "dtpFecha_librado"
        Me.dtpFecha_librado.Size = New System.Drawing.Size(138, 20)
        Me.dtpFecha_librado.TabIndex = 10
        '
        'Lblpago
        '
        Me.Lblpago.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lblpago.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lblpago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblpago.ForeColor = System.Drawing.Color.Black
        Me.Lblpago.Location = New System.Drawing.Point(25, 254)
        Me.Lblpago.Name = "Lblpago"
        Me.Lblpago.Size = New System.Drawing.Size(153, 17)
        Me.Lblpago.TabIndex = 364
        Me.Lblpago.Text = "Fecha de Pago           :"
        '
        'Lblfechalibrado
        '
        Me.Lblfechalibrado.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lblfechalibrado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lblfechalibrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblfechalibrado.ForeColor = System.Drawing.Color.Black
        Me.Lblfechalibrado.Location = New System.Drawing.Point(25, 216)
        Me.Lblfechalibrado.Name = "Lblfechalibrado"
        Me.Lblfechalibrado.Size = New System.Drawing.Size(153, 17)
        Me.Lblfechalibrado.TabIndex = 363
        Me.Lblfechalibrado.Text = "Fecha de Librado       :"
        '
        'txtNumero_cheque
        '
        Me.txtNumero_cheque.Location = New System.Drawing.Point(186, 178)
        Me.txtNumero_cheque.Name = "txtNumero_cheque"
        Me.txtNumero_cheque.Size = New System.Drawing.Size(260, 20)
        Me.txtNumero_cheque.TabIndex = 9
        Me.txtNumero_cheque.TabStop = False
        Me.txtNumero_cheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Lblnrocheque
        '
        Me.Lblnrocheque.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lblnrocheque.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lblnrocheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblnrocheque.ForeColor = System.Drawing.Color.Black
        Me.Lblnrocheque.Location = New System.Drawing.Point(25, 178)
        Me.Lblnrocheque.Name = "Lblnrocheque"
        Me.Lblnrocheque.Size = New System.Drawing.Size(153, 17)
        Me.Lblnrocheque.TabIndex = 361
        Me.Lblnrocheque.Text = "Número del Cheque   :"
        '
        'Cmbproveedor
        '
        Me.Cmbproveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Cmbproveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cmbproveedor.FormattingEnabled = True
        Me.Cmbproveedor.Location = New System.Drawing.Point(186, 76)
        Me.Cmbproveedor.Name = "Cmbproveedor"
        Me.Cmbproveedor.Size = New System.Drawing.Size(260, 21)
        Me.Cmbproveedor.TabIndex = 6
        '
        'Lblproveedor
        '
        Me.Lblproveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lblproveedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lblproveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblproveedor.ForeColor = System.Drawing.Color.Black
        Me.Lblproveedor.Location = New System.Drawing.Point(25, 76)
        Me.Lblproveedor.Name = "Lblproveedor"
        Me.Lblproveedor.Size = New System.Drawing.Size(153, 17)
        Me.Lblproveedor.TabIndex = 355
        Me.Lblproveedor.Text = "Proveedor                  :"
        '
        'txtImporte
        '
        Me.txtImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporte.ForeColor = System.Drawing.Color.Blue
        Me.txtImporte.Location = New System.Drawing.Point(184, 292)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(220, 31)
        Me.txtImporte.TabIndex = 12
        Me.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(25, 292)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 17)
        Me.Label1.TabIndex = 370
        Me.Label1.Text = "Importe del Cheque   :"
        '
        'lblidProveedor
        '
        Me.lblidProveedor.AutoSize = True
        Me.lblidProveedor.BackColor = System.Drawing.Color.Red
        Me.lblidProveedor.Location = New System.Drawing.Point(341, 79)
        Me.lblidProveedor.Name = "lblidProveedor"
        Me.lblidProveedor.Size = New System.Drawing.Size(13, 13)
        Me.lblidProveedor.TabIndex = 374
        Me.lblidProveedor.Text = "0"
        Me.lblidProveedor.Visible = False
        '
        'txtDetalle
        '
        Me.txtDetalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDetalle.Location = New System.Drawing.Point(186, 338)
        Me.txtDetalle.MaxLength = 50
        Me.txtDetalle.Multiline = True
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.Size = New System.Drawing.Size(260, 84)
        Me.txtDetalle.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(25, 338)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 17)
        Me.Label2.TabIndex = 376
        Me.Label2.Text = "Detalle del Cheque   :"
        '
        'btnBuscaProveedor
        '
        Me.btnBuscaProveedor.BackColor = System.Drawing.Color.Gainsboro
        Me.btnBuscaProveedor.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnBuscaProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnBuscaProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBuscaProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscaProveedor.Image = CType(resources.GetObject("btnBuscaProveedor.Image"), System.Drawing.Image)
        Me.btnBuscaProveedor.Location = New System.Drawing.Point(451, 67)
        Me.btnBuscaProveedor.Name = "btnBuscaProveedor"
        Me.btnBuscaProveedor.Size = New System.Drawing.Size(40, 32)
        Me.btnBuscaProveedor.TabIndex = 33
        Me.btnBuscaProveedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBuscaProveedor.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(451, 549)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(79, 70)
        Me.btnSalir.TabIndex = 31
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.Gainsboro
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(345, 549)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(79, 70)
        Me.btnGuardar.TabIndex = 30
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnBuscaChequera
        '
        Me.btnBuscaChequera.BackColor = System.Drawing.Color.Gainsboro
        Me.btnBuscaChequera.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnBuscaChequera.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnBuscaChequera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBuscaChequera.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscaChequera.Image = CType(resources.GetObject("btnBuscaChequera.Image"), System.Drawing.Image)
        Me.btnBuscaChequera.Location = New System.Drawing.Point(451, 29)
        Me.btnBuscaChequera.Name = "btnBuscaChequera"
        Me.btnBuscaChequera.Size = New System.Drawing.Size(40, 32)
        Me.btnBuscaChequera.TabIndex = 32
        Me.btnBuscaChequera.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBuscaChequera.UseVisualStyleBackColor = True
        '
        'lblidChequera
        '
        Me.lblidChequera.AutoSize = True
        Me.lblidChequera.BackColor = System.Drawing.Color.Red
        Me.lblidChequera.Location = New System.Drawing.Point(298, 41)
        Me.lblidChequera.Name = "lblidChequera"
        Me.lblidChequera.Size = New System.Drawing.Size(13, 13)
        Me.lblidChequera.TabIndex = 380
        Me.lblidChequera.Text = "0"
        Me.lblidChequera.Visible = False
        '
        'cmbChequera
        '
        Me.cmbChequera.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbChequera.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbChequera.FormattingEnabled = True
        Me.cmbChequera.Location = New System.Drawing.Point(186, 38)
        Me.cmbChequera.Name = "cmbChequera"
        Me.cmbChequera.Size = New System.Drawing.Size(182, 21)
        Me.cmbChequera.TabIndex = 5
        '
        'lblChequera
        '
        Me.lblChequera.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblChequera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblChequera.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChequera.ForeColor = System.Drawing.Color.Black
        Me.lblChequera.Location = New System.Drawing.Point(25, 38)
        Me.lblChequera.Name = "lblChequera"
        Me.lblChequera.Size = New System.Drawing.Size(153, 17)
        Me.lblChequera.TabIndex = 379
        Me.lblChequera.Text = "Chequera                   :"
        '
        'lblid_cuenta
        '
        Me.lblid_cuenta.AutoSize = True
        Me.lblid_cuenta.BackColor = System.Drawing.Color.Red
        Me.lblid_cuenta.Location = New System.Drawing.Point(399, 16)
        Me.lblid_cuenta.Name = "lblid_cuenta"
        Me.lblid_cuenta.Size = New System.Drawing.Size(13, 13)
        Me.lblid_cuenta.TabIndex = 570
        Me.lblid_cuenta.Text = "0"
        Me.lblid_cuenta.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkTipo_cheque)
        Me.GroupBox1.Controls.Add(Me.lblid_cuenta)
        Me.GroupBox1.Controls.Add(Me.btnBuscaChequera)
        Me.GroupBox1.Controls.Add(Me.btnBuscaProveedor)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(518, 524)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'chkTipo_cheque
        '
        Me.chkTipo_cheque.AutoSize = True
        Me.chkTipo_cheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTipo_cheque.Location = New System.Drawing.Point(451, 127)
        Me.chkTipo_cheque.Name = "chkTipo_cheque"
        Me.chkTipo_cheque.Size = New System.Drawing.Size(15, 14)
        Me.chkTipo_cheque.TabIndex = 571
        Me.chkTipo_cheque.Visible = False
        '
        'txtiva
        '
        Me.txtiva.BackColor = System.Drawing.Color.White
        Me.txtiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtiva.ForeColor = System.Drawing.Color.Blue
        Me.txtiva.Location = New System.Drawing.Point(184, 441)
        Me.txtiva.MaxLength = 50
        Me.txtiva.Name = "txtiva"
        Me.txtiva.Size = New System.Drawing.Size(222, 31)
        Me.txtiva.TabIndex = 14
        Me.txtiva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetaiva
        '
        Me.etiquetaiva.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaiva.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaiva.ForeColor = System.Drawing.Color.Black
        Me.etiquetaiva.Location = New System.Drawing.Point(25, 441)
        Me.etiquetaiva.Name = "etiquetaiva"
        Me.etiquetaiva.Size = New System.Drawing.Size(153, 21)
        Me.etiquetaiva.TabIndex = 582
        Me.etiquetaiva.Text = "Iva"
        Me.etiquetaiva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkanulado
        '
        Me.chkanulado.AutoSize = True
        Me.chkanulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkanulado.Location = New System.Drawing.Point(184, 488)
        Me.chkanulado.Name = "chkanulado"
        Me.chkanulado.Size = New System.Drawing.Size(85, 21)
        Me.chkanulado.TabIndex = 15
        Me.chkanulado.Text = "anulado"
        '
        'etiquetaanulado
        '
        Me.etiquetaanulado.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaanulado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaanulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaanulado.ForeColor = System.Drawing.Color.Black
        Me.etiquetaanulado.Location = New System.Drawing.Point(25, 488)
        Me.etiquetaanulado.Name = "etiquetaanulado"
        Me.etiquetaanulado.Size = New System.Drawing.Size(153, 21)
        Me.etiquetaanulado.TabIndex = 583
        Me.etiquetaanulado.Text = "Anulado"
        Me.etiquetaanulado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtInicio
        '
        Me.txtInicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtInicio.Location = New System.Drawing.Point(186, 119)
        Me.txtInicio.Name = "txtInicio"
        Me.txtInicio.ReadOnly = True
        Me.txtInicio.Size = New System.Drawing.Size(260, 20)
        Me.txtInicio.TabIndex = 7
        Me.txtInicio.TabStop = False
        Me.txtInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblInicio
        '
        Me.lblInicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblInicio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInicio.ForeColor = System.Drawing.Color.Black
        Me.lblInicio.Location = New System.Drawing.Point(25, 119)
        Me.lblInicio.Name = "lblInicio"
        Me.lblInicio.Size = New System.Drawing.Size(153, 17)
        Me.lblInicio.TabIndex = 585
        Me.lblInicio.Text = "Inicio                          :"
        '
        'txtFin
        '
        Me.txtFin.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFin.Location = New System.Drawing.Point(186, 145)
        Me.txtFin.Name = "txtFin"
        Me.txtFin.ReadOnly = True
        Me.txtFin.Size = New System.Drawing.Size(260, 20)
        Me.txtFin.TabIndex = 8
        Me.txtFin.TabStop = False
        Me.txtFin.Text = "   "
        Me.txtFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(25, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 17)
        Me.Label4.TabIndex = 587
        Me.Label4.Text = "Fin                              :"
        '
        'Frmchequelibrado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(542, 631)
        Me.Controls.Add(Me.txtFin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtInicio)
        Me.Controls.Add(Me.lblInicio)
        Me.Controls.Add(Me.txtiva)
        Me.Controls.Add(Me.chkanulado)
        Me.Controls.Add(Me.etiquetaiva)
        Me.Controls.Add(Me.etiquetaanulado)
        Me.Controls.Add(Me.txtImporte)
        Me.Controls.Add(Me.lblidChequera)
        Me.Controls.Add(Me.cmbChequera)
        Me.Controls.Add(Me.lblChequera)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtDetalle)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblidProveedor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpFecha_pago)
        Me.Controls.Add(Me.dtpFecha_librado)
        Me.Controls.Add(Me.Lblpago)
        Me.Controls.Add(Me.Lblfechalibrado)
        Me.Controls.Add(Me.txtNumero_cheque)
        Me.Controls.Add(Me.Lblnrocheque)
        Me.Controls.Add(Me.Cmbproveedor)
        Me.Controls.Add(Me.Lblproveedor)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frmchequelibrado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cheques Librados a Proveedores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpFecha_pago As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecha_librado As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lblpago As System.Windows.Forms.Label
    Friend WithEvents Lblfechalibrado As System.Windows.Forms.Label
    Friend WithEvents txtNumero_cheque As System.Windows.Forms.TextBox
    Friend WithEvents Lblnrocheque As System.Windows.Forms.Label
    Friend WithEvents Cmbproveedor As System.Windows.Forms.ComboBox
    Friend WithEvents Lblproveedor As System.Windows.Forms.Label
    Friend WithEvents txtImporte As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblidProveedor As System.Windows.Forms.Label
    Friend WithEvents txtDetalle As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolTipsalir As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTipguarda As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTipcliente As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTipbco As System.Windows.Forms.ToolTip
    Friend WithEvents btnBuscaProveedor As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnBuscaChequera As System.Windows.Forms.Button
    Friend WithEvents lblidChequera As System.Windows.Forms.Label
    Friend WithEvents cmbChequera As System.Windows.Forms.ComboBox
    Friend WithEvents lblChequera As System.Windows.Forms.Label
    Friend WithEvents ttChequera As System.Windows.Forms.ToolTip
    Friend WithEvents lblid_cuenta As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Protected WithEvents txtiva As System.Windows.Forms.TextBox
    Friend WithEvents etiquetaiva As System.Windows.Forms.Label
    Protected WithEvents chkanulado As System.Windows.Forms.CheckBox
    Friend WithEvents etiquetaanulado As System.Windows.Forms.Label
    Friend WithEvents txtInicio As System.Windows.Forms.TextBox
    Friend WithEvents lblInicio As System.Windows.Forms.Label
    Friend WithEvents txtFin As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Protected WithEvents chkTipo_cheque As System.Windows.Forms.CheckBox
End Class
