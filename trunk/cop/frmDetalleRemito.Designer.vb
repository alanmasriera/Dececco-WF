<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleRemito
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
       Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleRemito))
       Me.btnSalir = New System.Windows.Forms.Button
       Me.btnGuardar = New System.Windows.Forms.Button
       Me.GroupBox1 = New System.Windows.Forms.GroupBox
       Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
       Me.lblid_factura = New System.Windows.Forms.Label
       Me.btnBuscafactura = New System.Windows.Forms.Button
       Me.cmbfactura = New System.Windows.Forms.ComboBox
       Me.etiquetaid_factura = New System.Windows.Forms.Label
       Me.dtpfecha_remito = New System.Windows.Forms.DateTimePicker
       Me.etiquetafecha_remito = New System.Windows.Forms.Label
       Me.txtnumero_remito = New System.Windows.Forms.TextBox
       Me.etiquetanumero_remito = New System.Windows.Forms.Label
       Me.lblid_cliente = New System.Windows.Forms.Label
       Me.btnBuscacliente = New System.Windows.Forms.Button
       Me.cmbcliente = New System.Windows.Forms.ComboBox
       Me.etiquetaid_cliente = New System.Windows.Forms.Label
       Me.txtobservacion = New System.Windows.Forms.TextBox
       Me.etiquetaobservacion = New System.Windows.Forms.Label
       Me.lblid_condicion_venta = New System.Windows.Forms.Label
       Me.btnBuscacondicion_venta = New System.Windows.Forms.Button
       Me.cmbcondicion_venta = New System.Windows.Forms.ComboBox
       Me.etiquetaid_condicion_venta = New System.Windows.Forms.Label
       Me.lblid_usuario = New System.Windows.Forms.Label
       Me.btnBuscausuario = New System.Windows.Forms.Button
       Me.cmbusuario = New System.Windows.Forms.ComboBox
       Me.etiquetaid_usuario = New System.Windows.Forms.Label
       Me.SuspendLayout()
       '
       'lblid_factura
       '
       Me.lblid_factura.AutoSize = True
       Me.lblid_factura.BackColor = System.Drawing.Color.Red
       Me.lblid_factura.Location = New System.Drawing.Point(370, 48)
       Me.lblid_factura.Name = "lblid_factura"
       Me.lblid_factura.Size = New System.Drawing.Size(13, 13)
       Me.lblid_factura.TabIndex = 500
       Me.lblid_factura.Text = "0"
       Me.lblid_factura.Visible = False
       '
       'btnBuscafactura
       '
       Me.btnBuscafactura.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscafactura.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscafactura.Location = New System.Drawing.Point(505, 48)
       Me.btnBuscafactura.Name = "btnBuscafactura"
       Me.btnBuscafactura.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscafactura.TabIndex = 60
       Me.btnBuscafactura.UseVisualStyleBackColor = True
       '
       'cmbfactura
       '
       Me.cmbfactura.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbfactura.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbfactura.FormattingEnabled = True
       Me.cmbfactura.Location = New System.Drawing.Point(161, 48)
       Me.cmbfactura.Size = New System.Drawing.Size(329, 21)
       Me.cmbfactura.Name = "cmbfactura"
       Me.cmbfactura.TabIndex = 4
       '
       'etiquietaid_factura
       '
       Me.etiquetaid_factura.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_factura.AutoSize = True
       Me.etiquetaid_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_factura.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_factura.Location = New System.Drawing.Point(28, 48)
       Me.etiquetaid_factura.Name = "etiquetaid_factura"
       Me.etiquetaid_factura.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_factura.TabIndex = 501
       Me.etiquetaid_factura.Text = "Factura"
       Me.etiquetaid_factura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'dtpfecha_remito
       '
       Me.dtpfecha_remito.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
       Me.dtpfecha_remito.Location = New System.Drawing.Point(161, 91)
       Me.dtpfecha_remito.Name = "cmbfecha_remito"
       Me.dtpfecha_remito.Size = New System.Drawing.Size(93, 20)
       Me.dtpfecha_remito.TabIndex = 5
       '
       'etiquietafecha_remito
       '
       Me.etiquetafecha_remito.BackColor = System.Drawing.Color.Transparent
       Me.etiquetafecha_remito.AutoSize = True
       Me.etiquetafecha_remito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetafecha_remito.ForeColor = System.Drawing.Color.Black
       Me.etiquetafecha_remito.Location = New System.Drawing.Point(28, 91)
       Me.etiquetafecha_remito.Name = "etiquetafecha_remito"
       Me.etiquetafecha_remito.Size = New System.Drawing.Size(127, 21)
       Me.etiquetafecha_remito.TabIndex = 502
       Me.etiquetafecha_remito.Text = "Fecha remito"
       Me.etiquetafecha_remito.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtnumero_remito
       '
       Me.txtnumero_remito.BackColor = System.Drawing.Color.White
       Me.txtnumero_remito.Location = New System.Drawing.Point(161, 134)
       Me.txtnumero_remito.Size = New System.Drawing.Size(385, 20)
       Me.txtnumero_remito.MaxLength = 50
       Me.txtnumero_remito.Name = "txtnumero_remito"
       Me.txtnumero_remito.TabIndex = 6
       '
       'etiquietanumero_remito
       '
       Me.etiquetanumero_remito.BackColor = System.Drawing.Color.Transparent
       Me.etiquetanumero_remito.AutoSize = True
       Me.etiquetanumero_remito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetanumero_remito.ForeColor = System.Drawing.Color.Black
       Me.etiquetanumero_remito.Location = New System.Drawing.Point(28, 134)
       Me.etiquetanumero_remito.Name = "etiquetanumero_remito"
       Me.etiquetanumero_remito.Size = New System.Drawing.Size(127, 21)
       Me.etiquetanumero_remito.TabIndex = 503
       Me.etiquetanumero_remito.Text = "Numero remito"
       Me.etiquetanumero_remito.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblid_cliente
       '
       Me.lblid_cliente.AutoSize = True
       Me.lblid_cliente.BackColor = System.Drawing.Color.Red
       Me.lblid_cliente.Location = New System.Drawing.Point(370, 177)
       Me.lblid_cliente.Name = "lblid_cliente"
       Me.lblid_cliente.Size = New System.Drawing.Size(13, 13)
       Me.lblid_cliente.TabIndex = 504
       Me.lblid_cliente.Text = "0"
       Me.lblid_cliente.Visible = False
       '
       'btnBuscacliente
       '
       Me.btnBuscacliente.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscacliente.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscacliente.Location = New System.Drawing.Point(505, 177)
       Me.btnBuscacliente.Name = "btnBuscacliente"
       Me.btnBuscacliente.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscacliente.TabIndex = 61
       Me.btnBuscacliente.UseVisualStyleBackColor = True
       '
       'cmbcliente
       '
       Me.cmbcliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbcliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbcliente.FormattingEnabled = True
       Me.cmbcliente.Location = New System.Drawing.Point(161, 177)
       Me.cmbcliente.Size = New System.Drawing.Size(329, 21)
       Me.cmbcliente.Name = "cmbcliente"
       Me.cmbcliente.TabIndex = 7
       '
       'etiquietaid_cliente
       '
       Me.etiquetaid_cliente.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_cliente.AutoSize = True
       Me.etiquetaid_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_cliente.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_cliente.Location = New System.Drawing.Point(28, 177)
       Me.etiquetaid_cliente.Name = "etiquetaid_cliente"
       Me.etiquetaid_cliente.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_cliente.TabIndex = 505
       Me.etiquetaid_cliente.Text = "Cliente"
       Me.etiquetaid_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtobservacion
       '
       Me.txtobservacion.BackColor = System.Drawing.Color.White
       Me.txtobservacion.Location = New System.Drawing.Point(161, 220)
       Me.txtobservacion.Size = New System.Drawing.Size(385, 20)
       Me.txtobservacion.MaxLength = 5000
       Me.txtobservacion.Name = "txtobservacion"
       Me.txtobservacion.TabIndex = 8
       '
       'etiquietaobservacion
       '
       Me.etiquetaobservacion.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaobservacion.AutoSize = True
       Me.etiquetaobservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaobservacion.ForeColor = System.Drawing.Color.Black
       Me.etiquetaobservacion.Location = New System.Drawing.Point(28, 220)
       Me.etiquetaobservacion.Name = "etiquetaobservacion"
       Me.etiquetaobservacion.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaobservacion.TabIndex = 506
       Me.etiquetaobservacion.Text = "Observacion"
       Me.etiquetaobservacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblid_condicion_venta
       '
       Me.lblid_condicion_venta.AutoSize = True
       Me.lblid_condicion_venta.BackColor = System.Drawing.Color.Red
       Me.lblid_condicion_venta.Location = New System.Drawing.Point(370, 263)
       Me.lblid_condicion_venta.Name = "lblid_condicion_venta"
       Me.lblid_condicion_venta.Size = New System.Drawing.Size(13, 13)
       Me.lblid_condicion_venta.TabIndex = 507
       Me.lblid_condicion_venta.Text = "0"
       Me.lblid_condicion_venta.Visible = False
       '
       'btnBuscacondicion_venta
       '
       Me.btnBuscacondicion_venta.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscacondicion_venta.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscacondicion_venta.Location = New System.Drawing.Point(505, 263)
       Me.btnBuscacondicion_venta.Name = "btnBuscacondicion_venta"
       Me.btnBuscacondicion_venta.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscacondicion_venta.TabIndex = 62
       Me.btnBuscacondicion_venta.UseVisualStyleBackColor = True
       '
       'cmbcondicion_venta
       '
       Me.cmbcondicion_venta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbcondicion_venta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbcondicion_venta.FormattingEnabled = True
       Me.cmbcondicion_venta.Location = New System.Drawing.Point(161, 263)
       Me.cmbcondicion_venta.Size = New System.Drawing.Size(329, 21)
       Me.cmbcondicion_venta.Name = "cmbcondicion_venta"
       Me.cmbcondicion_venta.TabIndex = 9
       '
       'etiquietaid_condicion_venta
       '
       Me.etiquetaid_condicion_venta.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_condicion_venta.AutoSize = True
       Me.etiquetaid_condicion_venta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_condicion_venta.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_condicion_venta.Location = New System.Drawing.Point(28, 263)
       Me.etiquetaid_condicion_venta.Name = "etiquetaid_condicion_venta"
       Me.etiquetaid_condicion_venta.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_condicion_venta.TabIndex = 508
       Me.etiquetaid_condicion_venta.Text = "Condicion venta"
       Me.etiquetaid_condicion_venta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblid_usuario
       '
       Me.lblid_usuario.AutoSize = True
       Me.lblid_usuario.BackColor = System.Drawing.Color.Red
       Me.lblid_usuario.Location = New System.Drawing.Point(370, 306)
       Me.lblid_usuario.Name = "lblid_usuario"
       Me.lblid_usuario.Size = New System.Drawing.Size(13, 13)
       Me.lblid_usuario.TabIndex = 509
       Me.lblid_usuario.Text = "0"
       Me.lblid_usuario.Visible = False
       '
       'btnBuscausuario
       '
       Me.btnBuscausuario.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscausuario.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscausuario.Location = New System.Drawing.Point(505, 306)
       Me.btnBuscausuario.Name = "btnBuscausuario"
       Me.btnBuscausuario.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscausuario.TabIndex = 63
       Me.btnBuscausuario.UseVisualStyleBackColor = True
       '
       'cmbusuario
       '
       Me.cmbusuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbusuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbusuario.FormattingEnabled = True
       Me.cmbusuario.Location = New System.Drawing.Point(161, 306)
       Me.cmbusuario.Size = New System.Drawing.Size(329, 21)
       Me.cmbusuario.Name = "cmbusuario"
       Me.cmbusuario.TabIndex = 10
       '
       'etiquietaid_usuario
       '
       Me.etiquetaid_usuario.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_usuario.AutoSize = True
       Me.etiquetaid_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_usuario.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_usuario.Location = New System.Drawing.Point(28, 306)
       Me.etiquetaid_usuario.Name = "etiquetaid_usuario"
       Me.etiquetaid_usuario.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_usuario.TabIndex = 510
       Me.etiquetaid_usuario.Text = "Usuario"
       Me.etiquetaid_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'btnSalir
       '
       Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
       Me.btnSalir.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.btnSalir.ForeColor = System.Drawing.Color.Black
       Me.btnSalir.Image = CType(Resources.GetObject("btnSalir.Image"), System.Drawing.Image)
       Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
       Me.btnSalir.Location = New System.Drawing.Point(499, 389)
       Me.btnSalir.Name = "btnSalir"
       Me.btnSalir.Size = New System.Drawing.Size(81, 61)
       Me.btnSalir.TabIndex = 51
       Me.btnSalir.Text = "&Salir"
       Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
       Me.btnSalir.UseVisualStyleBackColor = True
       '
       'btnGuardar
       '
       Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnGuardar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.btnGuardar.ForeColor = System.Drawing.Color.Black
       Me.btnGuardar.Image = CType(Resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
       Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
       Me.btnGuardar.Location = New System.Drawing.Point(392,389)
       Me.btnGuardar.Name = "btnGuardar"
       Me.btnGuardar.Size = New System.Drawing.Size(81, 61)
       Me.btnGuardar.TabIndex = 50
       Me.btnGuardar.Text = "&Guardar"
       Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
       Me.btnGuardar.UseVisualStyleBackColor = True
       '
       'GroupBox1
       '
       Me.GroupBox1.Location = New System.Drawing.Point(12, 17)
       Me.GroupBox1.Name = "GroupBox1"
       Me.GroupBox1.Size = New System.Drawing.Size(568, 349)
       Me.GroupBox1.TabIndex = 0
       Me.GroupBox1.TabStop = False
       '
       'frmDetalleRemito
       '
       Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
       Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
       Me.ClientSize = New System.Drawing.Size(600, 469)
       Me.Controls.Add(Me.lblid_factura)
       Me.Controls.Add(Me.btnBuscafactura)
       Me.Controls.Add(Me.cmbfactura)
       Me.Controls.Add(Me.etiquetaid_factura)
       Me.Controls.Add(Me.dtpfecha_remito)
       Me.Controls.Add(Me.etiquetafecha_remito)
       Me.Controls.Add(Me.txtnumero_remito)
       Me.Controls.Add(Me.etiquetanumero_remito)
       Me.Controls.Add(Me.lblid_cliente)
       Me.Controls.Add(Me.btnBuscacliente)
       Me.Controls.Add(Me.cmbcliente)
       Me.Controls.Add(Me.etiquetaid_cliente)
       Me.Controls.Add(Me.txtobservacion)
       Me.Controls.Add(Me.etiquetaobservacion)
       Me.Controls.Add(Me.lblid_condicion_venta)
       Me.Controls.Add(Me.btnBuscacondicion_venta)
       Me.Controls.Add(Me.cmbcondicion_venta)
       Me.Controls.Add(Me.etiquetaid_condicion_venta)
       Me.Controls.Add(Me.lblid_usuario)
       Me.Controls.Add(Me.btnBuscausuario)
       Me.Controls.Add(Me.cmbusuario)
       Me.Controls.Add(Me.etiquetaid_usuario)
       Me.Controls.Add(Me.btnSalir)
       Me.Controls.Add(Me.btnGuardar)
       Me.Controls.Add(Me.GroupBox1)
       Me.Name = "frmDetalleRemito"
       Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
       Me.Text = "frmDetalleRemito" & vgNombreFormulario
       Me.ResumeLayout(False)
       Me.PerformLayout()

   End Sub
   Friend WithEvents lblid_factura As System.Windows.Forms.Label
   Friend WithEvents btnBuscafactura As System.Windows.Forms.Button
   Friend WithEvents cmbfactura As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_factura As System.Windows.Forms.Label
   Protected WithEvents dtpfecha_remito As System.Windows.Forms.DateTimePicker
   Friend WithEvents etiquetafecha_remito As System.Windows.Forms.Label
   Protected WithEvents txtnumero_remito As System.Windows.Forms.TextBox
   Friend WithEvents etiquetanumero_remito As System.Windows.Forms.Label
   Friend WithEvents lblid_cliente As System.Windows.Forms.Label
   Friend WithEvents btnBuscacliente As System.Windows.Forms.Button
   Friend WithEvents cmbcliente As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_cliente As System.Windows.Forms.Label
   Protected WithEvents txtobservacion As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaobservacion As System.Windows.Forms.Label
   Friend WithEvents lblid_condicion_venta As System.Windows.Forms.Label
   Friend WithEvents btnBuscacondicion_venta As System.Windows.Forms.Button
   Friend WithEvents cmbcondicion_venta As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_condicion_venta As System.Windows.Forms.Label
   Friend WithEvents lblid_usuario As System.Windows.Forms.Label
   Friend WithEvents btnBuscausuario As System.Windows.Forms.Button
   Friend WithEvents cmbusuario As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_usuario As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
End Class

