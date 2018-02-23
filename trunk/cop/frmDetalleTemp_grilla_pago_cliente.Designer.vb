<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleTemp_grilla_pago_cliente
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
       Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleTemp_grilla_pago_cliente))
       Me.btnSalir = New System.Windows.Forms.Button
       Me.btnGuardar = New System.Windows.Forms.Button
       Me.GroupBox1 = New System.Windows.Forms.GroupBox
       Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
       Me.lblid_pago_cliente = New System.Windows.Forms.Label
       Me.btnBuscapago_cliente = New System.Windows.Forms.Button
       Me.cmbpago_cliente = New System.Windows.Forms.ComboBox
       Me.etiquetaid_pago_cliente = New System.Windows.Forms.Label
       Me.dtpfecha = New System.Windows.Forms.DateTimePicker
       Me.etiquetafecha = New System.Windows.Forms.Label
       Me.txtapellido = New System.Windows.Forms.TextBox
       Me.etiquetaapellido = New System.Windows.Forms.Label
       Me.txtnombre = New System.Windows.Forms.TextBox
       Me.etiquetanombre = New System.Windows.Forms.Label
       Me.txtpago = New System.Windows.Forms.TextBox
       Me.etiquetapago = New System.Windows.Forms.Label
       Me.txtdetalle = New System.Windows.Forms.TextBox
       Me.etiquetadetalle = New System.Windows.Forms.Label
       Me.txtnumero_recibo = New System.Windows.Forms.TextBox
       Me.etiquetanumero_recibo = New System.Windows.Forms.Label
       Me.txtobservacion = New System.Windows.Forms.TextBox
       Me.etiquetaobservacion = New System.Windows.Forms.Label
       Me.txtnumero_orden_compra = New System.Windows.Forms.TextBox
       Me.etiquetanumero_orden_compra = New System.Windows.Forms.Label
       Me.SuspendLayout()
       '
       'lblid_pago_cliente
       '
       Me.lblid_pago_cliente.AutoSize = True
       Me.lblid_pago_cliente.BackColor = System.Drawing.Color.Red
       Me.lblid_pago_cliente.Location = New System.Drawing.Point(370, 48)
       Me.lblid_pago_cliente.Name = "lblid_pago_cliente"
       Me.lblid_pago_cliente.Size = New System.Drawing.Size(13, 13)
       Me.lblid_pago_cliente.TabIndex = 500
       Me.lblid_pago_cliente.Text = "0"
       Me.lblid_pago_cliente.Visible = False
       '
       'btnBuscapago_cliente
       '
       Me.btnBuscapago_cliente.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscapago_cliente.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscapago_cliente.Location = New System.Drawing.Point(505, 48)
       Me.btnBuscapago_cliente.Name = "btnBuscapago_cliente"
       Me.btnBuscapago_cliente.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscapago_cliente.TabIndex = 60
       Me.btnBuscapago_cliente.UseVisualStyleBackColor = True
       '
       'cmbpago_cliente
       '
       Me.cmbpago_cliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbpago_cliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbpago_cliente.FormattingEnabled = True
       Me.cmbpago_cliente.Location = New System.Drawing.Point(161, 48)
       Me.cmbpago_cliente.Size = New System.Drawing.Size(329, 21)
       Me.cmbpago_cliente.Name = "cmbpago_cliente"
       Me.cmbpago_cliente.TabIndex = 4
       '
       'etiquietaid_pago_cliente
       '
       Me.etiquetaid_pago_cliente.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_pago_cliente.AutoSize = True
       Me.etiquetaid_pago_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_pago_cliente.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_pago_cliente.Location = New System.Drawing.Point(28, 48)
       Me.etiquetaid_pago_cliente.Name = "etiquetaid_pago_cliente"
       Me.etiquetaid_pago_cliente.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_pago_cliente.TabIndex = 501
       Me.etiquetaid_pago_cliente.Text = "Pago cliente"
       Me.etiquetaid_pago_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'dtpfecha
       '
       Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
       Me.dtpfecha.Location = New System.Drawing.Point(161, 91)
       Me.dtpfecha.Name = "cmbfecha"
       Me.dtpfecha.Size = New System.Drawing.Size(93, 20)
       Me.dtpfecha.TabIndex = 5
       '
       'etiquietafecha
       '
       Me.etiquetafecha.BackColor = System.Drawing.Color.Transparent
       Me.etiquetafecha.AutoSize = True
       Me.etiquetafecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetafecha.ForeColor = System.Drawing.Color.Black
       Me.etiquetafecha.Location = New System.Drawing.Point(28, 91)
       Me.etiquetafecha.Name = "etiquetafecha"
       Me.etiquetafecha.Size = New System.Drawing.Size(127, 21)
       Me.etiquetafecha.TabIndex = 502
       Me.etiquetafecha.Text = "Fecha"
       Me.etiquetafecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtapellido
       '
       Me.txtapellido.BackColor = System.Drawing.Color.White
       Me.txtapellido.Location = New System.Drawing.Point(161, 134)
       Me.txtapellido.Size = New System.Drawing.Size(385, 20)
       Me.txtapellido.MaxLength = 50
       Me.txtapellido.Name = "txtapellido"
       Me.txtapellido.TabIndex = 6
       '
       'etiquietaapellido
       '
       Me.etiquetaapellido.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaapellido.AutoSize = True
       Me.etiquetaapellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaapellido.ForeColor = System.Drawing.Color.Black
       Me.etiquetaapellido.Location = New System.Drawing.Point(28, 134)
       Me.etiquetaapellido.Name = "etiquetaapellido"
       Me.etiquetaapellido.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaapellido.TabIndex = 503
       Me.etiquetaapellido.Text = "Apellido"
       Me.etiquetaapellido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtnombre
       '
       Me.txtnombre.BackColor = System.Drawing.Color.White
       Me.txtnombre.Location = New System.Drawing.Point(161, 177)
       Me.txtnombre.Size = New System.Drawing.Size(385, 20)
       Me.txtnombre.MaxLength = 50
       Me.txtnombre.Name = "txtnombre"
       Me.txtnombre.TabIndex = 7
       '
       'etiquietanombre
       '
       Me.etiquetanombre.BackColor = System.Drawing.Color.Transparent
       Me.etiquetanombre.AutoSize = True
       Me.etiquetanombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetanombre.ForeColor = System.Drawing.Color.Black
       Me.etiquetanombre.Location = New System.Drawing.Point(28, 177)
       Me.etiquetanombre.Name = "etiquetanombre"
       Me.etiquetanombre.Size = New System.Drawing.Size(127, 21)
       Me.etiquetanombre.TabIndex = 504
       Me.etiquetanombre.Text = "Nombre"
       Me.etiquetanombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtpago
       '
       Me.txtpago.BackColor = System.Drawing.Color.White
       Me.txtpago.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtpago.ForeColor = System.Drawing.Color.Blue
       Me.txtpago.Location = New System.Drawing.Point(161, 220)
       Me.txtpago.MaxLength = 50
       Me.txtpago.Name = "txtpago"
       Me.txtpago.Size = New System.Drawing.Size(222, 31)
       Me.txtpago.TabIndex = 8
       Me.txtpago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietapago
       '
       Me.etiquetapago.BackColor = System.Drawing.Color.Transparent
       Me.etiquetapago.AutoSize = True
       Me.etiquetapago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetapago.ForeColor = System.Drawing.Color.Black
       Me.etiquetapago.Location = New System.Drawing.Point(28, 220)
       Me.etiquetapago.Name = "etiquetapago"
       Me.etiquetapago.Size = New System.Drawing.Size(127, 21)
       Me.etiquetapago.TabIndex = 505
       Me.etiquetapago.Text = "Pago"
       Me.etiquetapago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtdetalle
       '
       Me.txtdetalle.BackColor = System.Drawing.Color.White
       Me.txtdetalle.Location = New System.Drawing.Point(161, 273)
       Me.txtdetalle.Size = New System.Drawing.Size(385, 20)
       Me.txtdetalle.MaxLength = 5000
       Me.txtdetalle.Name = "txtdetalle"
       Me.txtdetalle.TabIndex = 9
       '
       'etiquietadetalle
       '
       Me.etiquetadetalle.BackColor = System.Drawing.Color.Transparent
       Me.etiquetadetalle.AutoSize = True
       Me.etiquetadetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetadetalle.ForeColor = System.Drawing.Color.Black
       Me.etiquetadetalle.Location = New System.Drawing.Point(28, 273)
       Me.etiquetadetalle.Name = "etiquetadetalle"
       Me.etiquetadetalle.Size = New System.Drawing.Size(127, 21)
       Me.etiquetadetalle.TabIndex = 506
       Me.etiquetadetalle.Text = "Detalle"
       Me.etiquetadetalle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtnumero_recibo
       '
       Me.txtnumero_recibo.BackColor = System.Drawing.Color.White
       Me.txtnumero_recibo.Location = New System.Drawing.Point(161, 316)
       Me.txtnumero_recibo.Size = New System.Drawing.Size(385, 20)
       Me.txtnumero_recibo.MaxLength = 50
       Me.txtnumero_recibo.Name = "txtnumero_recibo"
       Me.txtnumero_recibo.TabIndex = 10
       '
       'etiquietanumero_recibo
       '
       Me.etiquetanumero_recibo.BackColor = System.Drawing.Color.Transparent
       Me.etiquetanumero_recibo.AutoSize = True
       Me.etiquetanumero_recibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetanumero_recibo.ForeColor = System.Drawing.Color.Black
       Me.etiquetanumero_recibo.Location = New System.Drawing.Point(28, 316)
       Me.etiquetanumero_recibo.Name = "etiquetanumero_recibo"
       Me.etiquetanumero_recibo.Size = New System.Drawing.Size(127, 21)
       Me.etiquetanumero_recibo.TabIndex = 507
       Me.etiquetanumero_recibo.Text = "Numero recibo"
       Me.etiquetanumero_recibo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtobservacion
       '
       Me.txtobservacion.BackColor = System.Drawing.Color.White
       Me.txtobservacion.Location = New System.Drawing.Point(161, 359)
       Me.txtobservacion.Size = New System.Drawing.Size(385, 20)
       Me.txtobservacion.MaxLength = 5000
       Me.txtobservacion.Name = "txtobservacion"
       Me.txtobservacion.TabIndex = 11
       '
       'etiquietaobservacion
       '
       Me.etiquetaobservacion.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaobservacion.AutoSize = True
       Me.etiquetaobservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaobservacion.ForeColor = System.Drawing.Color.Black
       Me.etiquetaobservacion.Location = New System.Drawing.Point(28, 359)
       Me.etiquetaobservacion.Name = "etiquetaobservacion"
       Me.etiquetaobservacion.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaobservacion.TabIndex = 508
       Me.etiquetaobservacion.Text = "Observacion"
       Me.etiquetaobservacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtnumero_orden_compra
       '
       Me.txtnumero_orden_compra.BackColor = System.Drawing.Color.White
       Me.txtnumero_orden_compra.Location = New System.Drawing.Point(161, 402)
       Me.txtnumero_orden_compra.Size = New System.Drawing.Size(385, 20)
       Me.txtnumero_orden_compra.MaxLength = 50
       Me.txtnumero_orden_compra.Name = "txtnumero_orden_compra"
       Me.txtnumero_orden_compra.TabIndex = 12
       '
       'etiquietanumero_orden_compra
       '
       Me.etiquetanumero_orden_compra.BackColor = System.Drawing.Color.Transparent
       Me.etiquetanumero_orden_compra.AutoSize = True
       Me.etiquetanumero_orden_compra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetanumero_orden_compra.ForeColor = System.Drawing.Color.Black
       Me.etiquetanumero_orden_compra.Location = New System.Drawing.Point(28, 402)
       Me.etiquetanumero_orden_compra.Name = "etiquetanumero_orden_compra"
       Me.etiquetanumero_orden_compra.Size = New System.Drawing.Size(127, 21)
       Me.etiquetanumero_orden_compra.TabIndex = 509
       Me.etiquetanumero_orden_compra.Text = "Numero orden compra"
       Me.etiquetanumero_orden_compra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
       Me.btnSalir.Location = New System.Drawing.Point(499, 485)
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
       Me.btnGuardar.Location = New System.Drawing.Point(392,485)
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
       Me.GroupBox1.Size = New System.Drawing.Size(568, 445)
       Me.GroupBox1.TabIndex = 0
       Me.GroupBox1.TabStop = False
       '
       'frmDetalleTemp_grilla_pago_cliente
       '
       Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
       Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
       Me.ClientSize = New System.Drawing.Size(600, 565)
       Me.Controls.Add(Me.lblid_pago_cliente)
       Me.Controls.Add(Me.btnBuscapago_cliente)
       Me.Controls.Add(Me.cmbpago_cliente)
       Me.Controls.Add(Me.etiquetaid_pago_cliente)
       Me.Controls.Add(Me.dtpfecha)
       Me.Controls.Add(Me.etiquetafecha)
       Me.Controls.Add(Me.txtapellido)
       Me.Controls.Add(Me.etiquetaapellido)
       Me.Controls.Add(Me.txtnombre)
       Me.Controls.Add(Me.etiquetanombre)
       Me.Controls.Add(Me.txtpago)
       Me.Controls.Add(Me.etiquetapago)
       Me.Controls.Add(Me.txtdetalle)
       Me.Controls.Add(Me.etiquetadetalle)
       Me.Controls.Add(Me.txtnumero_recibo)
       Me.Controls.Add(Me.etiquetanumero_recibo)
       Me.Controls.Add(Me.txtobservacion)
       Me.Controls.Add(Me.etiquetaobservacion)
       Me.Controls.Add(Me.txtnumero_orden_compra)
       Me.Controls.Add(Me.etiquetanumero_orden_compra)
       Me.Controls.Add(Me.btnSalir)
       Me.Controls.Add(Me.btnGuardar)
       Me.Controls.Add(Me.GroupBox1)
       Me.Name = "frmDetalleTemp_grilla_pago_cliente"
       Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
       Me.Text = "frmDetalleTemp_grilla_pago_cliente" & vgNombreFormulario
       Me.ResumeLayout(False)
       Me.PerformLayout()

   End Sub
   Friend WithEvents lblid_pago_cliente As System.Windows.Forms.Label
   Friend WithEvents btnBuscapago_cliente As System.Windows.Forms.Button
   Friend WithEvents cmbpago_cliente As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_pago_cliente As System.Windows.Forms.Label
   Protected WithEvents dtpfecha As System.Windows.Forms.DateTimePicker
   Friend WithEvents etiquetafecha As System.Windows.Forms.Label
   Protected WithEvents txtapellido As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaapellido As System.Windows.Forms.Label
   Protected WithEvents txtnombre As System.Windows.Forms.TextBox
   Friend WithEvents etiquetanombre As System.Windows.Forms.Label
   Protected WithEvents txtpago As System.Windows.Forms.TextBox
   Friend WithEvents etiquetapago As System.Windows.Forms.Label
   Protected WithEvents txtdetalle As System.Windows.Forms.TextBox
   Friend WithEvents etiquetadetalle As System.Windows.Forms.Label
   Protected WithEvents txtnumero_recibo As System.Windows.Forms.TextBox
   Friend WithEvents etiquetanumero_recibo As System.Windows.Forms.Label
   Protected WithEvents txtobservacion As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaobservacion As System.Windows.Forms.Label
   Protected WithEvents txtnumero_orden_compra As System.Windows.Forms.TextBox
   Friend WithEvents etiquetanumero_orden_compra As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
End Class

