<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleCheque_librado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleCheque_librado))
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtnumero_cheque = New System.Windows.Forms.TextBox
        Me.etiquetanumero_cheque = New System.Windows.Forms.Label
        Me.lblid_proveedor = New System.Windows.Forms.Label
        Me.btnBuscaProveedor = New System.Windows.Forms.Button
        Me.cmbProveedor = New System.Windows.Forms.ComboBox
        Me.etiquetaid_persona = New System.Windows.Forms.Label
        Me.txtdetalle = New System.Windows.Forms.TextBox
        Me.etiquetadetalle = New System.Windows.Forms.Label
        Me.dtpfecha_librado = New System.Windows.Forms.DateTimePicker
        Me.etiquetafecha_librado = New System.Windows.Forms.Label
        Me.dtpfecha_pago = New System.Windows.Forms.DateTimePicker
        Me.etiquetafecha_pago = New System.Windows.Forms.Label
        Me.txtimporte = New System.Windows.Forms.TextBox
        Me.etiquetaimporte = New System.Windows.Forms.Label
        Me.txtiva = New System.Windows.Forms.TextBox
        Me.etiquetaiva = New System.Windows.Forms.Label
        Me.lblid_empresa = New System.Windows.Forms.Label
        Me.chkcontrol = New System.Windows.Forms.CheckBox
        Me.etiquetacontrol = New System.Windows.Forms.Label
        Me.chkanulado = New System.Windows.Forms.CheckBox
        Me.etiquetaanulado = New System.Windows.Forms.Label
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
        Me.btnSalir.Location = New System.Drawing.Point(499, 538)
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
        Me.btnGuardar.Location = New System.Drawing.Point(392, 538)
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
        Me.GroupBox1.Size = New System.Drawing.Size(568, 485)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtnumero_cheque
        '
        Me.txtnumero_cheque.BackColor = System.Drawing.Color.White
        Me.txtnumero_cheque.Location = New System.Drawing.Point(161, 48)
        Me.txtnumero_cheque.MaxLength = 50
        Me.txtnumero_cheque.Name = "txtnumero_cheque"
        Me.txtnumero_cheque.Size = New System.Drawing.Size(385, 20)
        Me.txtnumero_cheque.TabIndex = 4
        '
        'etiquetanumero_cheque
        '
        Me.etiquetanumero_cheque.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetanumero_cheque.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetanumero_cheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetanumero_cheque.ForeColor = System.Drawing.Color.Black
        Me.etiquetanumero_cheque.Location = New System.Drawing.Point(28, 48)
        Me.etiquetanumero_cheque.Name = "etiquetanumero_cheque"
        Me.etiquetanumero_cheque.Size = New System.Drawing.Size(127, 21)
        Me.etiquetanumero_cheque.TabIndex = 500
        Me.etiquetanumero_cheque.Text = "Numero_cheque"
        Me.etiquetanumero_cheque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_proveedor
        '
        Me.lblid_proveedor.AutoSize = True
        Me.lblid_proveedor.BackColor = System.Drawing.Color.Red
        Me.lblid_proveedor.Location = New System.Drawing.Point(370, 91)
        Me.lblid_proveedor.Name = "lblid_proveedor"
        Me.lblid_proveedor.Size = New System.Drawing.Size(13, 13)
        Me.lblid_proveedor.TabIndex = 501
        Me.lblid_proveedor.Text = "0"
        Me.lblid_proveedor.Visible = False
        '
        'btnBuscaProveedor
        '
        Me.btnBuscaProveedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscaProveedor.Image = CType(resources.GetObject("btnBuscaProveedor.Image"), System.Drawing.Image)
        Me.btnBuscaProveedor.Location = New System.Drawing.Point(505, 91)
        Me.btnBuscaProveedor.Name = "btnBuscaProveedor"
        Me.btnBuscaProveedor.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscaProveedor.TabIndex = 30
        Me.btnBuscaProveedor.UseVisualStyleBackColor = True
        '
        'cmbProveedor
        '
        Me.cmbProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbProveedor.FormattingEnabled = True
        Me.cmbProveedor.Location = New System.Drawing.Point(161, 91)
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.Size = New System.Drawing.Size(329, 21)
        Me.cmbProveedor.TabIndex = 5
        '
        'etiquetaid_persona
        '
        Me.etiquetaid_persona.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_persona.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_persona.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_persona.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_persona.Location = New System.Drawing.Point(28, 91)
        Me.etiquetaid_persona.Name = "etiquetaid_persona"
        Me.etiquetaid_persona.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_persona.TabIndex = 502
        Me.etiquetaid_persona.Text = "Proveedor"
        Me.etiquetaid_persona.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtdetalle
        '
        Me.txtdetalle.BackColor = System.Drawing.Color.White
        Me.txtdetalle.Location = New System.Drawing.Point(161, 134)
        Me.txtdetalle.MaxLength = 50
        Me.txtdetalle.Multiline = True
        Me.txtdetalle.Name = "txtdetalle"
        Me.txtdetalle.Size = New System.Drawing.Size(385, 74)
        Me.txtdetalle.TabIndex = 6
        '
        'etiquetadetalle
        '
        Me.etiquetadetalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetadetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetadetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetadetalle.ForeColor = System.Drawing.Color.Black
        Me.etiquetadetalle.Location = New System.Drawing.Point(28, 134)
        Me.etiquetadetalle.Name = "etiquetadetalle"
        Me.etiquetadetalle.Size = New System.Drawing.Size(127, 21)
        Me.etiquetadetalle.TabIndex = 503
        Me.etiquetadetalle.Text = "Detalle"
        Me.etiquetadetalle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpfecha_librado
        '
        Me.dtpfecha_librado.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha_librado.Location = New System.Drawing.Point(161, 228)
        Me.dtpfecha_librado.Name = "dtpfecha_librado"
        Me.dtpfecha_librado.Size = New System.Drawing.Size(93, 20)
        Me.dtpfecha_librado.TabIndex = 7
        '
        'etiquetafecha_librado
        '
        Me.etiquetafecha_librado.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetafecha_librado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetafecha_librado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetafecha_librado.ForeColor = System.Drawing.Color.Black
        Me.etiquetafecha_librado.Location = New System.Drawing.Point(28, 228)
        Me.etiquetafecha_librado.Name = "etiquetafecha_librado"
        Me.etiquetafecha_librado.Size = New System.Drawing.Size(127, 21)
        Me.etiquetafecha_librado.TabIndex = 504
        Me.etiquetafecha_librado.Text = "Fecha_librado"
        Me.etiquetafecha_librado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpfecha_pago
        '
        Me.dtpfecha_pago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha_pago.Location = New System.Drawing.Point(161, 271)
        Me.dtpfecha_pago.Name = "dtpfecha_pago"
        Me.dtpfecha_pago.Size = New System.Drawing.Size(93, 20)
        Me.dtpfecha_pago.TabIndex = 8
        '
        'etiquetafecha_pago
        '
        Me.etiquetafecha_pago.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetafecha_pago.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetafecha_pago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetafecha_pago.ForeColor = System.Drawing.Color.Black
        Me.etiquetafecha_pago.Location = New System.Drawing.Point(28, 271)
        Me.etiquetafecha_pago.Name = "etiquetafecha_pago"
        Me.etiquetafecha_pago.Size = New System.Drawing.Size(127, 21)
        Me.etiquetafecha_pago.TabIndex = 505
        Me.etiquetafecha_pago.Text = "Fecha_pago"
        Me.etiquetafecha_pago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtimporte
        '
        Me.txtimporte.BackColor = System.Drawing.Color.White
        Me.txtimporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtimporte.ForeColor = System.Drawing.Color.Blue
        Me.txtimporte.Location = New System.Drawing.Point(161, 314)
        Me.txtimporte.MaxLength = 50
        Me.txtimporte.Name = "txtimporte"
        Me.txtimporte.Size = New System.Drawing.Size(222, 31)
        Me.txtimporte.TabIndex = 9
        Me.txtimporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetaimporte
        '
        Me.etiquetaimporte.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaimporte.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaimporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaimporte.ForeColor = System.Drawing.Color.Black
        Me.etiquetaimporte.Location = New System.Drawing.Point(28, 314)
        Me.etiquetaimporte.Name = "etiquetaimporte"
        Me.etiquetaimporte.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaimporte.TabIndex = 506
        Me.etiquetaimporte.Text = "Importe"
        Me.etiquetaimporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtiva
        '
        Me.txtiva.BackColor = System.Drawing.Color.White
        Me.txtiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtiva.ForeColor = System.Drawing.Color.Blue
        Me.txtiva.Location = New System.Drawing.Point(161, 367)
        Me.txtiva.MaxLength = 50
        Me.txtiva.Name = "txtiva"
        Me.txtiva.Size = New System.Drawing.Size(222, 31)
        Me.txtiva.TabIndex = 10
        Me.txtiva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtiva.Visible = False
        '
        'etiquetaiva
        '
        Me.etiquetaiva.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaiva.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaiva.ForeColor = System.Drawing.Color.Black
        Me.etiquetaiva.Location = New System.Drawing.Point(28, 367)
        Me.etiquetaiva.Name = "etiquetaiva"
        Me.etiquetaiva.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaiva.TabIndex = 507
        Me.etiquetaiva.Text = "Iva"
        Me.etiquetaiva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.etiquetaiva.Visible = False
        '
        'lblid_empresa
        '
        Me.lblid_empresa.AutoSize = True
        Me.lblid_empresa.BackColor = System.Drawing.Color.Red
        Me.lblid_empresa.Location = New System.Drawing.Point(340, 538)
        Me.lblid_empresa.Name = "lblid_empresa"
        Me.lblid_empresa.Size = New System.Drawing.Size(13, 13)
        Me.lblid_empresa.TabIndex = 508
        Me.lblid_empresa.Text = "0"
        Me.lblid_empresa.Visible = False
        '
        'chkcontrol
        '
        Me.chkcontrol.AutoSize = True
        Me.chkcontrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkcontrol.Location = New System.Drawing.Point(161, 412)
        Me.chkcontrol.Name = "chkcontrol"
        Me.chkcontrol.Size = New System.Drawing.Size(77, 21)
        Me.chkcontrol.TabIndex = 12
        Me.chkcontrol.Text = "control"
        '
        'etiquetacontrol
        '
        Me.etiquetacontrol.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetacontrol.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetacontrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetacontrol.ForeColor = System.Drawing.Color.Black
        Me.etiquetacontrol.Location = New System.Drawing.Point(28, 412)
        Me.etiquetacontrol.Name = "etiquetacontrol"
        Me.etiquetacontrol.Size = New System.Drawing.Size(127, 21)
        Me.etiquetacontrol.TabIndex = 510
        Me.etiquetacontrol.Text = "Control"
        Me.etiquetacontrol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkanulado
        '
        Me.chkanulado.AutoSize = True
        Me.chkanulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkanulado.Location = New System.Drawing.Point(161, 455)
        Me.chkanulado.Name = "chkanulado"
        Me.chkanulado.Size = New System.Drawing.Size(85, 21)
        Me.chkanulado.TabIndex = 13
        Me.chkanulado.Text = "anulado"
        '
        'etiquetaanulado
        '
        Me.etiquetaanulado.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaanulado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaanulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaanulado.ForeColor = System.Drawing.Color.Black
        Me.etiquetaanulado.Location = New System.Drawing.Point(28, 455)
        Me.etiquetaanulado.Name = "etiquetaanulado"
        Me.etiquetaanulado.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaanulado.TabIndex = 511
        Me.etiquetaanulado.Text = "Anulado"
        Me.etiquetaanulado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmDetalleCheque_librado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 618)
        Me.Controls.Add(Me.txtnumero_cheque)
        Me.Controls.Add(Me.etiquetanumero_cheque)
        Me.Controls.Add(Me.lblid_proveedor)
        Me.Controls.Add(Me.btnBuscaProveedor)
        Me.Controls.Add(Me.cmbProveedor)
        Me.Controls.Add(Me.etiquetaid_persona)
        Me.Controls.Add(Me.txtdetalle)
        Me.Controls.Add(Me.etiquetadetalle)
        Me.Controls.Add(Me.dtpfecha_librado)
        Me.Controls.Add(Me.etiquetafecha_librado)
        Me.Controls.Add(Me.dtpfecha_pago)
        Me.Controls.Add(Me.etiquetafecha_pago)
        Me.Controls.Add(Me.txtimporte)
        Me.Controls.Add(Me.etiquetaimporte)
        Me.Controls.Add(Me.txtiva)
        Me.Controls.Add(Me.etiquetaiva)
        Me.Controls.Add(Me.lblid_empresa)
        Me.Controls.Add(Me.chkcontrol)
        Me.Controls.Add(Me.etiquetacontrol)
        Me.Controls.Add(Me.chkanulado)
        Me.Controls.Add(Me.etiquetaanulado)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDetalleCheque_librado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetalleCheque_librado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Protected WithEvents txtnumero_cheque As System.Windows.Forms.TextBox
    Friend WithEvents etiquetanumero_cheque As System.Windows.Forms.Label
    Friend WithEvents lblid_proveedor As System.Windows.Forms.Label
    Friend WithEvents btnBuscaProveedor As System.Windows.Forms.Button
    Friend WithEvents cmbProveedor As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_persona As System.Windows.Forms.Label
   Protected WithEvents txtdetalle As System.Windows.Forms.TextBox
   Friend WithEvents etiquetadetalle As System.Windows.Forms.Label
   Protected WithEvents dtpfecha_librado As System.Windows.Forms.DateTimePicker
   Friend WithEvents etiquetafecha_librado As System.Windows.Forms.Label
   Protected WithEvents dtpfecha_pago As System.Windows.Forms.DateTimePicker
   Friend WithEvents etiquetafecha_pago As System.Windows.Forms.Label
   Protected WithEvents txtimporte As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaimporte As System.Windows.Forms.Label
   Protected WithEvents txtiva As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaiva As System.Windows.Forms.Label
   Friend WithEvents lblid_empresa As System.Windows.Forms.Label
    Protected WithEvents chkcontrol As System.Windows.Forms.CheckBox
   Friend WithEvents etiquetacontrol As System.Windows.Forms.Label
   Protected WithEvents chkanulado As System.Windows.Forms.CheckBox
   Friend WithEvents etiquetaanulado As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
End Class

