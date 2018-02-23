<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmchequerecibido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmchequerecibido))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cmbcliente = New System.Windows.Forms.ComboBox()
        Me.Cmbbancocheque = New System.Windows.Forms.ComboBox()
        Me.Lblbancocheque = New System.Windows.Forms.Label()
        Me.ToolTipsalir = New System.Windows.Forms.ToolTip(Me.components)
        Me.Lblnrocheque = New System.Windows.Forms.Label()
        Me.Txtnrocheque = New System.Windows.Forms.TextBox()
        Me.Lblfecharecibido = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fecharecibido = New System.Windows.Forms.DateTimePicker()
        Me.fechaacredita = New System.Windows.Forms.DateTimePicker()
        Me.cmblocalidad = New System.Windows.Forms.ComboBox()
        Me.lbllocalidad = New System.Windows.Forms.Label()
        Me.Cmbprovincia = New System.Windows.Forms.ComboBox()
        Me.Lblprovincia = New System.Windows.Forms.Label()
        Me.Lblplaza = New System.Windows.Forms.Label()
        Me.ToolTipcliente = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipguarda = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipbco = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipbcos = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipprovincia = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTiplocalidad = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblid_Cliente = New System.Windows.Forms.Label()
        Me.lblid_BancoCheque = New System.Windows.Forms.Label()
        Me.lblid_Localidad = New System.Windows.Forms.Label()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDetalle = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblid_Provincia = New System.Windows.Forms.Label()
        Me.btnBcaBco = New System.Windows.Forms.Button()
        Me.btnBuscaCliente = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnBuscaLocalidad = New System.Windows.Forms.Button()
        Me.lblVendido = New System.Windows.Forms.Label()
        Me.lblFechaVenta = New System.Windows.Forms.Label()
        Me.dtpFechaVenta = New System.Windows.Forms.DateTimePicker()
        Me.chkVendido = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnBuscaLimite = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEmitido = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.txtLimite = New System.Windows.Forms.TextBox()
        Me.lblid_cuenta = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtiva = New System.Windows.Forms.TextBox()
        Me.etiquetaiva = New System.Windows.Forms.Label()
        Me.chkanulado = New System.Windows.Forms.CheckBox()
        Me.etiquetaanulado = New System.Windows.Forms.Label()
        Me.chkcontrol = New System.Windows.Forms.CheckBox()
        Me.etiquetacontrol = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente Librador           :"
        '
        'Cmbcliente
        '
        Me.Cmbcliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Cmbcliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cmbcliente.FormattingEnabled = True
        Me.Cmbcliente.Location = New System.Drawing.Point(188, 22)
        Me.Cmbcliente.Name = "Cmbcliente"
        Me.Cmbcliente.Size = New System.Drawing.Size(253, 21)
        Me.Cmbcliente.TabIndex = 4
        '
        'Cmbbancocheque
        '
        Me.Cmbbancocheque.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Cmbbancocheque.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cmbbancocheque.FormattingEnabled = True
        Me.Cmbbancocheque.Location = New System.Drawing.Point(188, 59)
        Me.Cmbbancocheque.Name = "Cmbbancocheque"
        Me.Cmbbancocheque.Size = New System.Drawing.Size(253, 21)
        Me.Cmbbancocheque.TabIndex = 5
        '
        'Lblbancocheque
        '
        Me.Lblbancocheque.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lblbancocheque.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lblbancocheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblbancocheque.ForeColor = System.Drawing.Color.Black
        Me.Lblbancocheque.Location = New System.Drawing.Point(12, 58)
        Me.Lblbancocheque.Name = "Lblbancocheque"
        Me.Lblbancocheque.Size = New System.Drawing.Size(160, 21)
        Me.Lblbancocheque.TabIndex = 340
        Me.Lblbancocheque.Text = "Banco del Cheque       :"
        '
        'Lblnrocheque
        '
        Me.Lblnrocheque.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lblnrocheque.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lblnrocheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblnrocheque.ForeColor = System.Drawing.Color.Black
        Me.Lblnrocheque.Location = New System.Drawing.Point(12, 94)
        Me.Lblnrocheque.Name = "Lblnrocheque"
        Me.Lblnrocheque.Size = New System.Drawing.Size(160, 21)
        Me.Lblnrocheque.TabIndex = 343
        Me.Lblnrocheque.Text = "Número del Cheque    :"
        '
        'Txtnrocheque
        '
        Me.Txtnrocheque.Location = New System.Drawing.Point(188, 96)
        Me.Txtnrocheque.Name = "Txtnrocheque"
        Me.Txtnrocheque.Size = New System.Drawing.Size(253, 20)
        Me.Txtnrocheque.TabIndex = 6
        '
        'Lblfecharecibido
        '
        Me.Lblfecharecibido.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lblfecharecibido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lblfecharecibido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblfecharecibido.ForeColor = System.Drawing.Color.Black
        Me.Lblfecharecibido.Location = New System.Drawing.Point(12, 129)
        Me.Lblfecharecibido.Name = "Lblfecharecibido"
        Me.Lblfecharecibido.Size = New System.Drawing.Size(160, 21)
        Me.Lblfecharecibido.TabIndex = 345
        Me.Lblfecharecibido.Text = "Fecha de Recibido      :"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 21)
        Me.Label2.TabIndex = 346
        Me.Label2.Text = "Fecha de Acreditación :"
        '
        'fecharecibido
        '
        Me.fecharecibido.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecharecibido.Location = New System.Drawing.Point(188, 132)
        Me.fecharecibido.Name = "fecharecibido"
        Me.fecharecibido.Size = New System.Drawing.Size(122, 20)
        Me.fecharecibido.TabIndex = 7
        '
        'fechaacredita
        '
        Me.fechaacredita.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaacredita.Location = New System.Drawing.Point(188, 168)
        Me.fechaacredita.Name = "fechaacredita"
        Me.fechaacredita.Size = New System.Drawing.Size(122, 20)
        Me.fechaacredita.TabIndex = 8
        '
        'cmblocalidad
        '
        Me.cmblocalidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmblocalidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmblocalidad.FormattingEnabled = True
        Me.cmblocalidad.Location = New System.Drawing.Point(188, 467)
        Me.cmblocalidad.Name = "cmblocalidad"
        Me.cmblocalidad.Size = New System.Drawing.Size(253, 21)
        Me.cmblocalidad.TabIndex = 26
        '
        'lbllocalidad
        '
        Me.lbllocalidad.AutoSize = True
        Me.lbllocalidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbllocalidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbllocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllocalidad.ForeColor = System.Drawing.Color.Black
        Me.lbllocalidad.Location = New System.Drawing.Point(12, 466)
        Me.lbllocalidad.Name = "lbllocalidad"
        Me.lbllocalidad.Size = New System.Drawing.Size(156, 17)
        Me.lbllocalidad.TabIndex = 361
        Me.lbllocalidad.Text = "Localidad                    :"
        '
        'Cmbprovincia
        '
        Me.Cmbprovincia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Cmbprovincia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cmbprovincia.FormattingEnabled = True
        Me.Cmbprovincia.Location = New System.Drawing.Point(188, 426)
        Me.Cmbprovincia.Name = "Cmbprovincia"
        Me.Cmbprovincia.Size = New System.Drawing.Size(253, 21)
        Me.Cmbprovincia.TabIndex = 25
        '
        'Lblprovincia
        '
        Me.Lblprovincia.AutoSize = True
        Me.Lblprovincia.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lblprovincia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lblprovincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblprovincia.ForeColor = System.Drawing.Color.Black
        Me.Lblprovincia.Location = New System.Drawing.Point(12, 428)
        Me.Lblprovincia.Name = "Lblprovincia"
        Me.Lblprovincia.Size = New System.Drawing.Size(156, 17)
        Me.Lblprovincia.TabIndex = 358
        Me.Lblprovincia.Text = "Provincia                     :"
        '
        'Lblplaza
        '
        Me.Lblplaza.AutoSize = True
        Me.Lblplaza.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lblplaza.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lblplaza.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblplaza.ForeColor = System.Drawing.Color.Black
        Me.Lblplaza.Location = New System.Drawing.Point(12, 400)
        Me.Lblplaza.Name = "Lblplaza"
        Me.Lblplaza.Size = New System.Drawing.Size(130, 17)
        Me.Lblplaza.TabIndex = 357
        Me.Lblplaza.Text = "Plaza del Cheque :"
        '
        'lblid_Cliente
        '
        Me.lblid_Cliente.AutoSize = True
        Me.lblid_Cliente.BackColor = System.Drawing.Color.Red
        Me.lblid_Cliente.ForeColor = System.Drawing.Color.Black
        Me.lblid_Cliente.Location = New System.Drawing.Point(360, 24)
        Me.lblid_Cliente.Name = "lblid_Cliente"
        Me.lblid_Cliente.Size = New System.Drawing.Size(13, 13)
        Me.lblid_Cliente.TabIndex = 371
        Me.lblid_Cliente.Text = "0"
        Me.lblid_Cliente.Visible = False
        '
        'lblid_BancoCheque
        '
        Me.lblid_BancoCheque.AutoSize = True
        Me.lblid_BancoCheque.BackColor = System.Drawing.Color.Red
        Me.lblid_BancoCheque.ForeColor = System.Drawing.Color.Black
        Me.lblid_BancoCheque.Location = New System.Drawing.Point(360, 62)
        Me.lblid_BancoCheque.Name = "lblid_BancoCheque"
        Me.lblid_BancoCheque.Size = New System.Drawing.Size(13, 13)
        Me.lblid_BancoCheque.TabIndex = 372
        Me.lblid_BancoCheque.Text = "0"
        Me.lblid_BancoCheque.Visible = False
        '
        'lblid_Localidad
        '
        Me.lblid_Localidad.AutoSize = True
        Me.lblid_Localidad.BackColor = System.Drawing.Color.Red
        Me.lblid_Localidad.ForeColor = System.Drawing.Color.Black
        Me.lblid_Localidad.Location = New System.Drawing.Point(360, 467)
        Me.lblid_Localidad.Name = "lblid_Localidad"
        Me.lblid_Localidad.Size = New System.Drawing.Size(13, 13)
        Me.lblid_Localidad.TabIndex = 375
        Me.lblid_Localidad.Text = "0"
        Me.lblid_Localidad.Visible = False
        '
        'txtImporte
        '
        Me.txtImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporte.ForeColor = System.Drawing.Color.Blue
        Me.txtImporte.Location = New System.Drawing.Point(188, 204)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(221, 31)
        Me.txtImporte.TabIndex = 9
        Me.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(12, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 21)
        Me.Label4.TabIndex = 376
        Me.Label4.Text = "Importe del Cheque     :"
        '
        'txtDetalle
        '
        Me.txtDetalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDetalle.Location = New System.Drawing.Point(188, 298)
        Me.txtDetalle.MaxLength = 50
        Me.txtDetalle.Multiline = True
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.Size = New System.Drawing.Size(311, 55)
        Me.txtDetalle.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 298)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 21)
        Me.Label5.TabIndex = 380
        Me.Label5.Text = "Detalle del Cheque     :"
        '
        'lblid_Provincia
        '
        Me.lblid_Provincia.AutoSize = True
        Me.lblid_Provincia.BackColor = System.Drawing.Color.Red
        Me.lblid_Provincia.ForeColor = System.Drawing.Color.Black
        Me.lblid_Provincia.Location = New System.Drawing.Point(360, 432)
        Me.lblid_Provincia.Name = "lblid_Provincia"
        Me.lblid_Provincia.Size = New System.Drawing.Size(13, 13)
        Me.lblid_Provincia.TabIndex = 384
        Me.lblid_Provincia.Text = "0"
        Me.lblid_Provincia.Visible = False
        '
        'btnBcaBco
        '
        Me.btnBcaBco.BackColor = System.Drawing.Color.Gainsboro
        Me.btnBcaBco.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnBcaBco.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnBcaBco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBcaBco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBcaBco.Image = CType(resources.GetObject("btnBcaBco.Image"), System.Drawing.Image)
        Me.btnBcaBco.Location = New System.Drawing.Point(459, 58)
        Me.btnBcaBco.Name = "btnBcaBco"
        Me.btnBcaBco.Size = New System.Drawing.Size(40, 32)
        Me.btnBcaBco.TabIndex = 64
        Me.btnBcaBco.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBcaBco.UseVisualStyleBackColor = True
        '
        'btnBuscaCliente
        '
        Me.btnBuscaCliente.BackColor = System.Drawing.Color.Gainsboro
        Me.btnBuscaCliente.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnBuscaCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnBuscaCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBuscaCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscaCliente.Image = CType(resources.GetObject("btnBuscaCliente.Image"), System.Drawing.Image)
        Me.btnBuscaCliente.Location = New System.Drawing.Point(459, 17)
        Me.btnBuscaCliente.Name = "btnBuscaCliente"
        Me.btnBuscaCliente.Size = New System.Drawing.Size(40, 32)
        Me.btnBuscaCliente.TabIndex = 63
        Me.btnBuscaCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBuscaCliente.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(835, 619)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(80, 68)
        Me.btnSalir.TabIndex = 62
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.Gainsboro
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(533, 619)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(80, 68)
        Me.btnGuardar.TabIndex = 61
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnBuscaLocalidad
        '
        Me.btnBuscaLocalidad.BackColor = System.Drawing.Color.Gainsboro
        Me.btnBuscaLocalidad.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnBuscaLocalidad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnBuscaLocalidad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBuscaLocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscaLocalidad.Image = CType(resources.GetObject("btnBuscaLocalidad.Image"), System.Drawing.Image)
        Me.btnBuscaLocalidad.Location = New System.Drawing.Point(459, 469)
        Me.btnBuscaLocalidad.Name = "btnBuscaLocalidad"
        Me.btnBuscaLocalidad.Size = New System.Drawing.Size(40, 32)
        Me.btnBuscaLocalidad.TabIndex = 65
        Me.btnBuscaLocalidad.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBuscaLocalidad.UseVisualStyleBackColor = True
        '
        'lblVendido
        '
        Me.lblVendido.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblVendido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblVendido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVendido.ForeColor = System.Drawing.Color.Black
        Me.lblVendido.Location = New System.Drawing.Point(12, 584)
        Me.lblVendido.Name = "lblVendido"
        Me.lblVendido.Size = New System.Drawing.Size(156, 17)
        Me.lblVendido.TabIndex = 385
        Me.lblVendido.Text = "Vendido                      :"
        '
        'lblFechaVenta
        '
        Me.lblFechaVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblFechaVenta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFechaVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaVenta.ForeColor = System.Drawing.Color.Black
        Me.lblFechaVenta.Location = New System.Drawing.Point(12, 643)
        Me.lblFechaVenta.Name = "lblFechaVenta"
        Me.lblFechaVenta.Size = New System.Drawing.Size(156, 17)
        Me.lblFechaVenta.TabIndex = 386
        Me.lblFechaVenta.Text = "Fecha Venta               :"
        '
        'dtpFechaVenta
        '
        Me.dtpFechaVenta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaVenta.Location = New System.Drawing.Point(188, 640)
        Me.dtpFechaVenta.Name = "dtpFechaVenta"
        Me.dtpFechaVenta.Size = New System.Drawing.Size(122, 20)
        Me.dtpFechaVenta.TabIndex = 36
        '
        'chkVendido
        '
        Me.chkVendido.AutoSize = True
        Me.chkVendido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVendido.ForeColor = System.Drawing.Color.Black
        Me.chkVendido.Location = New System.Drawing.Point(188, 586)
        Me.chkVendido.Name = "chkVendido"
        Me.chkVendido.Size = New System.Drawing.Size(79, 21)
        Me.chkVendido.TabIndex = 35
        Me.chkVendido.Text = "Vendido"
        Me.chkVendido.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 556)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 17)
        Me.Label3.TabIndex = 389
        Me.Label3.Text = "Estado del Cheque :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Info
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(12, 616)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(308, 13)
        Me.Label6.TabIndex = 390
        Me.Label6.Text = "Si el Cheque no Está Vendido Colocar la Fecha de Acreditación"
        '
        'btnBuscaLimite
        '
        Me.btnBuscaLimite.BackColor = System.Drawing.Color.Gainsboro
        Me.btnBuscaLimite.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnBuscaLimite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnBuscaLimite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBuscaLimite.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscaLimite.Image = CType(resources.GetObject("btnBuscaLimite.Image"), System.Drawing.Image)
        Me.btnBuscaLimite.Location = New System.Drawing.Point(875, 23)
        Me.btnBuscaLimite.Name = "btnBuscaLimite"
        Me.btnBuscaLimite.Size = New System.Drawing.Size(40, 32)
        Me.btnBuscaLimite.TabIndex = 66
        Me.btnBuscaLimite.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBuscaLimite.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(533, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 17)
        Me.Label7.TabIndex = 585
        Me.Label7.Text = "Total Vendido"
        '
        'txtEmitido
        '
        Me.txtEmitido.BackColor = System.Drawing.Color.White
        Me.txtEmitido.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmitido.ForeColor = System.Drawing.Color.Blue
        Me.txtEmitido.Location = New System.Drawing.Point(674, 58)
        Me.txtEmitido.Name = "txtEmitido"
        Me.txtEmitido.ReadOnly = True
        Me.txtEmitido.Size = New System.Drawing.Size(191, 31)
        Me.txtEmitido.TabIndex = 584
        Me.txtEmitido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(533, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 17)
        Me.Label8.TabIndex = 583
        Me.Label8.Text = "Límite de Cheque"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(533, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 17)
        Me.Label9.TabIndex = 582
        Me.Label9.Text = "Saldo de Cheque"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(533, 139)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(382, 24)
        Me.ProgressBar1.TabIndex = 581
        '
        'txtSaldo
        '
        Me.txtSaldo.BackColor = System.Drawing.Color.White
        Me.txtSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.ForeColor = System.Drawing.Color.Blue
        Me.txtSaldo.Location = New System.Drawing.Point(674, 96)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.ReadOnly = True
        Me.txtSaldo.Size = New System.Drawing.Size(191, 31)
        Me.txtSaldo.TabIndex = 580
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtLimite
        '
        Me.txtLimite.BackColor = System.Drawing.Color.White
        Me.txtLimite.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLimite.ForeColor = System.Drawing.Color.Blue
        Me.txtLimite.Location = New System.Drawing.Point(674, 23)
        Me.txtLimite.Name = "txtLimite"
        Me.txtLimite.ReadOnly = True
        Me.txtLimite.Size = New System.Drawing.Size(191, 31)
        Me.txtLimite.TabIndex = 579
        Me.txtLimite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblid_cuenta
        '
        Me.lblid_cuenta.AutoSize = True
        Me.lblid_cuenta.BackColor = System.Drawing.Color.Red
        Me.lblid_cuenta.Location = New System.Drawing.Point(396, 139)
        Me.lblid_cuenta.Name = "lblid_cuenta"
        Me.lblid_cuenta.Size = New System.Drawing.Size(13, 13)
        Me.lblid_cuenta.TabIndex = 587
        Me.lblid_cuenta.Text = "0"
        Me.lblid_cuenta.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(518, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(411, 167)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(4, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(508, 362)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(4, 388)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(508, 130)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Location = New System.Drawing.Point(4, 537)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(508, 150)
        Me.GroupBox4.TabIndex = 30
        Me.GroupBox4.TabStop = False
        '
        'txtiva
        '
        Me.txtiva.BackColor = System.Drawing.Color.White
        Me.txtiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtiva.ForeColor = System.Drawing.Color.Blue
        Me.txtiva.Location = New System.Drawing.Point(187, 251)
        Me.txtiva.MaxLength = 50
        Me.txtiva.Name = "txtiva"
        Me.txtiva.Size = New System.Drawing.Size(222, 31)
        Me.txtiva.TabIndex = 10
        Me.txtiva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetaiva
        '
        Me.etiquetaiva.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaiva.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaiva.ForeColor = System.Drawing.Color.Black
        Me.etiquetaiva.Location = New System.Drawing.Point(12, 251)
        Me.etiquetaiva.Name = "etiquetaiva"
        Me.etiquetaiva.Size = New System.Drawing.Size(160, 21)
        Me.etiquetaiva.TabIndex = 589
        Me.etiquetaiva.Text = "Iva"
        Me.etiquetaiva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkanulado
        '
        Me.chkanulado.AutoSize = True
        Me.chkanulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkanulado.ForeColor = System.Drawing.Color.Black
        Me.chkanulado.Location = New System.Drawing.Point(666, 192)
        Me.chkanulado.Name = "chkanulado"
        Me.chkanulado.Size = New System.Drawing.Size(85, 21)
        Me.chkanulado.TabIndex = 590
        Me.chkanulado.Text = "anulado"
        '
        'etiquetaanulado
        '
        Me.etiquetaanulado.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaanulado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaanulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaanulado.ForeColor = System.Drawing.Color.Black
        Me.etiquetaanulado.Location = New System.Drawing.Point(533, 192)
        Me.etiquetaanulado.Name = "etiquetaanulado"
        Me.etiquetaanulado.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaanulado.TabIndex = 591
        Me.etiquetaanulado.Text = "Anulado"
        Me.etiquetaanulado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkcontrol
        '
        Me.chkcontrol.AutoSize = True
        Me.chkcontrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkcontrol.ForeColor = System.Drawing.Color.Black
        Me.chkcontrol.Location = New System.Drawing.Point(666, 234)
        Me.chkcontrol.Name = "chkcontrol"
        Me.chkcontrol.Size = New System.Drawing.Size(77, 21)
        Me.chkcontrol.TabIndex = 592
        Me.chkcontrol.Text = "control"
        '
        'etiquetacontrol
        '
        Me.etiquetacontrol.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetacontrol.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetacontrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetacontrol.ForeColor = System.Drawing.Color.Black
        Me.etiquetacontrol.Location = New System.Drawing.Point(533, 234)
        Me.etiquetacontrol.Name = "etiquetacontrol"
        Me.etiquetacontrol.Size = New System.Drawing.Size(127, 21)
        Me.etiquetacontrol.TabIndex = 593
        Me.etiquetacontrol.Text = "Control"
        Me.etiquetacontrol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Frmchequerecibido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(951, 705)
        Me.Controls.Add(Me.chkcontrol)
        Me.Controls.Add(Me.etiquetacontrol)
        Me.Controls.Add(Me.chkanulado)
        Me.Controls.Add(Me.etiquetaanulado)
        Me.Controls.Add(Me.txtiva)
        Me.Controls.Add(Me.etiquetaiva)
        Me.Controls.Add(Me.btnBuscaLocalidad)
        Me.Controls.Add(Me.lblid_cuenta)
        Me.Controls.Add(Me.btnBuscaLimite)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtEmitido)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.txtSaldo)
        Me.Controls.Add(Me.txtLimite)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chkVendido)
        Me.Controls.Add(Me.dtpFechaVenta)
        Me.Controls.Add(Me.lblFechaVenta)
        Me.Controls.Add(Me.lblVendido)
        Me.Controls.Add(Me.btnBcaBco)
        Me.Controls.Add(Me.btnBuscaCliente)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lblid_Provincia)
        Me.Controls.Add(Me.txtDetalle)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtImporte)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblid_Localidad)
        Me.Controls.Add(Me.lblid_BancoCheque)
        Me.Controls.Add(Me.lblid_Cliente)
        Me.Controls.Add(Me.cmblocalidad)
        Me.Controls.Add(Me.lbllocalidad)
        Me.Controls.Add(Me.Cmbprovincia)
        Me.Controls.Add(Me.Lblprovincia)
        Me.Controls.Add(Me.Lblplaza)
        Me.Controls.Add(Me.fechaacredita)
        Me.Controls.Add(Me.fecharecibido)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Lblfecharecibido)
        Me.Controls.Add(Me.Txtnrocheque)
        Me.Controls.Add(Me.Lblnrocheque)
        Me.Controls.Add(Me.Cmbbancocheque)
        Me.Controls.Add(Me.Lblbancocheque)
        Me.Controls.Add(Me.Cmbcliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.Yellow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frmchequerecibido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cheque Recibidos de Clientes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Cmbcliente As System.Windows.Forms.ComboBox
    Friend WithEvents Cmbbancocheque As System.Windows.Forms.ComboBox
    Friend WithEvents Lblbancocheque As System.Windows.Forms.Label
    Friend WithEvents ToolTipsalir As System.Windows.Forms.ToolTip
    Friend WithEvents Lblnrocheque As System.Windows.Forms.Label
    Friend WithEvents Txtnrocheque As System.Windows.Forms.TextBox
    Friend WithEvents Lblfecharecibido As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fecharecibido As System.Windows.Forms.DateTimePicker
    Friend WithEvents fechaacredita As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmblocalidad As System.Windows.Forms.ComboBox
    Friend WithEvents lbllocalidad As System.Windows.Forms.Label
    Friend WithEvents Cmbprovincia As System.Windows.Forms.ComboBox
    Friend WithEvents Lblprovincia As System.Windows.Forms.Label
    Friend WithEvents Lblplaza As System.Windows.Forms.Label
    Friend WithEvents ToolTipcliente As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTipguarda As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTipbco As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTipbcos As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTipprovincia As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTiplocalidad As System.Windows.Forms.ToolTip
    Friend WithEvents lblid_Cliente As System.Windows.Forms.Label
    Friend WithEvents lblid_BancoCheque As System.Windows.Forms.Label
    Friend WithEvents lblid_Localidad As System.Windows.Forms.Label
    Friend WithEvents txtImporte As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDetalle As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblid_Provincia As System.Windows.Forms.Label
    Friend WithEvents btnBcaBco As System.Windows.Forms.Button
    Friend WithEvents btnBuscaCliente As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnBuscaLocalidad As System.Windows.Forms.Button
    Friend WithEvents lblVendido As System.Windows.Forms.Label
    Friend WithEvents lblFechaVenta As System.Windows.Forms.Label
    Friend WithEvents dtpFechaVenta As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkVendido As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnBuscaLimite As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtEmitido As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents txtSaldo As System.Windows.Forms.TextBox
    Friend WithEvents txtLimite As System.Windows.Forms.TextBox
    Friend WithEvents lblid_cuenta As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Protected WithEvents txtiva As System.Windows.Forms.TextBox
    Friend WithEvents etiquetaiva As System.Windows.Forms.Label
    Protected WithEvents chkanulado As System.Windows.Forms.CheckBox
    Friend WithEvents etiquetaanulado As System.Windows.Forms.Label
    Protected WithEvents chkcontrol As System.Windows.Forms.CheckBox
    Friend WithEvents etiquetacontrol As System.Windows.Forms.Label
End Class
