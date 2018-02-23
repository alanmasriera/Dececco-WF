<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetallePago_cliente
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
       Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetallePago_cliente))
       Me.btnSalir = New System.Windows.Forms.Button
       Me.btnGuardar = New System.Windows.Forms.Button
       Me.GroupBox1 = New System.Windows.Forms.GroupBox
       Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
       Me.lblid_cliente = New System.Windows.Forms.Label
       Me.btnBuscacliente = New System.Windows.Forms.Button
       Me.cmbcliente = New System.Windows.Forms.ComboBox
       Me.etiquetaid_cliente = New System.Windows.Forms.Label
       Me.dtpfecha = New System.Windows.Forms.DateTimePicker
       Me.etiquetafecha = New System.Windows.Forms.Label
       Me.txtpago = New System.Windows.Forms.TextBox
       Me.etiquetapago = New System.Windows.Forms.Label
       Me.txtdetalle = New System.Windows.Forms.TextBox
       Me.etiquetadetalle = New System.Windows.Forms.Label
       Me.chkefectivo = New System.Windows.Forms.CheckBox
       Me.etiquetaefectivo = New System.Windows.Forms.Label
       Me.txtnumero_recibo = New System.Windows.Forms.TextBox
       Me.etiquetanumero_recibo = New System.Windows.Forms.Label
       Me.txtretencion_iva = New System.Windows.Forms.TextBox
       Me.etiquetaretencion_iva = New System.Windows.Forms.Label
       Me.txtingreso_bruto = New System.Windows.Forms.TextBox
       Me.etiquetaingreso_bruto = New System.Windows.Forms.Label
       Me.txtimpuesto_ganancia = New System.Windows.Forms.TextBox
       Me.etiquetaimpuesto_ganancia = New System.Windows.Forms.Label
       Me.txtsuss = New System.Windows.Forms.TextBox
       Me.etiquetasuss = New System.Windows.Forms.Label
       Me.txttotal_letra = New System.Windows.Forms.TextBox
       Me.etiquetatotal_letra = New System.Windows.Forms.Label
       Me.txtobservacion = New System.Windows.Forms.TextBox
       Me.etiquetaobservacion = New System.Windows.Forms.Label
       Me.SuspendLayout()
       '
       'lblid_cliente
       '
       Me.lblid_cliente.AutoSize = True
       Me.lblid_cliente.BackColor = System.Drawing.Color.Red
       Me.lblid_cliente.Location = New System.Drawing.Point(370, 48)
       Me.lblid_cliente.Name = "lblid_cliente"
       Me.lblid_cliente.Size = New System.Drawing.Size(13, 13)
       Me.lblid_cliente.TabIndex = 500
       Me.lblid_cliente.Text = "0"
       Me.lblid_cliente.Visible = False
       '
       'btnBuscacliente
       '
       Me.btnBuscacliente.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscacliente.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscacliente.Location = New System.Drawing.Point(505, 48)
       Me.btnBuscacliente.Name = "btnBuscacliente"
       Me.btnBuscacliente.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscacliente.TabIndex = 60
       Me.btnBuscacliente.UseVisualStyleBackColor = True
       '
       'cmbcliente
       '
       Me.cmbcliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbcliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbcliente.FormattingEnabled = True
       Me.cmbcliente.Location = New System.Drawing.Point(161, 48)
       Me.cmbcliente.Size = New System.Drawing.Size(329, 21)
       Me.cmbcliente.Name = "cmbcliente"
       Me.cmbcliente.TabIndex = 4
       '
       'etiquietaid_cliente
       '
       Me.etiquetaid_cliente.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_cliente.AutoSize = True
       Me.etiquetaid_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_cliente.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_cliente.Location = New System.Drawing.Point(28, 48)
       Me.etiquetaid_cliente.Name = "etiquetaid_cliente"
       Me.etiquetaid_cliente.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_cliente.TabIndex = 501
       Me.etiquetaid_cliente.Text = "Cliente"
       Me.etiquetaid_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
       'txtpago
       '
       Me.txtpago.BackColor = System.Drawing.Color.White
       Me.txtpago.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtpago.ForeColor = System.Drawing.Color.Blue
       Me.txtpago.Location = New System.Drawing.Point(161, 134)
       Me.txtpago.MaxLength = 50
       Me.txtpago.Name = "txtpago"
       Me.txtpago.Size = New System.Drawing.Size(222, 31)
       Me.txtpago.TabIndex = 6
       Me.txtpago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietapago
       '
       Me.etiquetapago.BackColor = System.Drawing.Color.Transparent
       Me.etiquetapago.AutoSize = True
       Me.etiquetapago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetapago.ForeColor = System.Drawing.Color.Black
       Me.etiquetapago.Location = New System.Drawing.Point(28, 134)
       Me.etiquetapago.Name = "etiquetapago"
       Me.etiquetapago.Size = New System.Drawing.Size(127, 21)
       Me.etiquetapago.TabIndex = 503
       Me.etiquetapago.Text = "Pago"
       Me.etiquetapago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtdetalle
       '
       Me.txtdetalle.BackColor = System.Drawing.Color.White
       Me.txtdetalle.Location = New System.Drawing.Point(161, 187)
       Me.txtdetalle.Size = New System.Drawing.Size(385, 20)
       Me.txtdetalle.MaxLength = 5000
       Me.txtdetalle.Name = "txtdetalle"
       Me.txtdetalle.TabIndex = 7
       '
       'etiquietadetalle
       '
       Me.etiquetadetalle.BackColor = System.Drawing.Color.Transparent
       Me.etiquetadetalle.AutoSize = True
       Me.etiquetadetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetadetalle.ForeColor = System.Drawing.Color.Black
       Me.etiquetadetalle.Location = New System.Drawing.Point(28, 187)
       Me.etiquetadetalle.Name = "etiquetadetalle"
       Me.etiquetadetalle.Size = New System.Drawing.Size(127, 21)
       Me.etiquetadetalle.TabIndex = 504
       Me.etiquetadetalle.Text = "Detalle"
       Me.etiquetadetalle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'chkefectivo
       '
       Me.chkefectivo.AutoSize = True
       Me.chkefectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.chkefectivo.Location = New System.Drawing.Point(161, 230)
       Me.chkefectivo.Name = "etiquetaefectivo"
       Me.chkefectivo.Size = New System.Drawing.Size(15, 14)
       Me.chkefectivo.TabIndex = 8
       Me.chkefectivo.Text = "efectivo"
       Me.chkefectivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       'etiquietaefectivo
       '
       Me.etiquetaefectivo.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaefectivo.AutoSize = True
       Me.etiquetaefectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaefectivo.ForeColor = System.Drawing.Color.Black
       Me.etiquetaefectivo.Location = New System.Drawing.Point(28, 230)
       Me.etiquetaefectivo.Name = "etiquetaefectivo"
       Me.etiquetaefectivo.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaefectivo.TabIndex = 505
       Me.etiquetaefectivo.Text = "Efectivo"
       Me.etiquetaefectivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtnumero_recibo
       '
       Me.txtnumero_recibo.BackColor = System.Drawing.Color.White
       Me.txtnumero_recibo.Location = New System.Drawing.Point(161, 273)
       Me.txtnumero_recibo.Size = New System.Drawing.Size(385, 20)
       Me.txtnumero_recibo.MaxLength = 50
       Me.txtnumero_recibo.Name = "txtnumero_recibo"
       Me.txtnumero_recibo.TabIndex = 9
       '
       'etiquietanumero_recibo
       '
       Me.etiquetanumero_recibo.BackColor = System.Drawing.Color.Transparent
       Me.etiquetanumero_recibo.AutoSize = True
       Me.etiquetanumero_recibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetanumero_recibo.ForeColor = System.Drawing.Color.Black
       Me.etiquetanumero_recibo.Location = New System.Drawing.Point(28, 273)
       Me.etiquetanumero_recibo.Name = "etiquetanumero_recibo"
       Me.etiquetanumero_recibo.Size = New System.Drawing.Size(127, 21)
       Me.etiquetanumero_recibo.TabIndex = 506
       Me.etiquetanumero_recibo.Text = "Numero recibo"
       Me.etiquetanumero_recibo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtretencion_iva
       '
       Me.txtretencion_iva.BackColor = System.Drawing.Color.White
       Me.txtretencion_iva.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtretencion_iva.ForeColor = System.Drawing.Color.Blue
       Me.txtretencion_iva.Location = New System.Drawing.Point(161, 316)
       Me.txtretencion_iva.MaxLength = 50
       Me.txtretencion_iva.Name = "txtretencion_iva"
       Me.txtretencion_iva.Size = New System.Drawing.Size(222, 31)
       Me.txtretencion_iva.TabIndex = 10
       Me.txtretencion_iva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietaretencion_iva
       '
       Me.etiquetaretencion_iva.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaretencion_iva.AutoSize = True
       Me.etiquetaretencion_iva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaretencion_iva.ForeColor = System.Drawing.Color.Black
       Me.etiquetaretencion_iva.Location = New System.Drawing.Point(28, 316)
       Me.etiquetaretencion_iva.Name = "etiquetaretencion_iva"
       Me.etiquetaretencion_iva.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaretencion_iva.TabIndex = 507
       Me.etiquetaretencion_iva.Text = "Retencion iva"
       Me.etiquetaretencion_iva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtingreso_bruto
       '
       Me.txtingreso_bruto.BackColor = System.Drawing.Color.White
       Me.txtingreso_bruto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtingreso_bruto.ForeColor = System.Drawing.Color.Blue
       Me.txtingreso_bruto.Location = New System.Drawing.Point(161, 369)
       Me.txtingreso_bruto.MaxLength = 50
       Me.txtingreso_bruto.Name = "txtingreso_bruto"
       Me.txtingreso_bruto.Size = New System.Drawing.Size(222, 31)
       Me.txtingreso_bruto.TabIndex = 11
       Me.txtingreso_bruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietaingreso_bruto
       '
       Me.etiquetaingreso_bruto.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaingreso_bruto.AutoSize = True
       Me.etiquetaingreso_bruto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaingreso_bruto.ForeColor = System.Drawing.Color.Black
       Me.etiquetaingreso_bruto.Location = New System.Drawing.Point(28, 369)
       Me.etiquetaingreso_bruto.Name = "etiquetaingreso_bruto"
       Me.etiquetaingreso_bruto.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaingreso_bruto.TabIndex = 508
       Me.etiquetaingreso_bruto.Text = "Ingreso bruto"
       Me.etiquetaingreso_bruto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtimpuesto_ganancia
       '
       Me.txtimpuesto_ganancia.BackColor = System.Drawing.Color.White
       Me.txtimpuesto_ganancia.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtimpuesto_ganancia.ForeColor = System.Drawing.Color.Blue
       Me.txtimpuesto_ganancia.Location = New System.Drawing.Point(161, 422)
       Me.txtimpuesto_ganancia.MaxLength = 50
       Me.txtimpuesto_ganancia.Name = "txtimpuesto_ganancia"
       Me.txtimpuesto_ganancia.Size = New System.Drawing.Size(222, 31)
       Me.txtimpuesto_ganancia.TabIndex = 12
       Me.txtimpuesto_ganancia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietaimpuesto_ganancia
       '
       Me.etiquetaimpuesto_ganancia.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaimpuesto_ganancia.AutoSize = True
       Me.etiquetaimpuesto_ganancia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaimpuesto_ganancia.ForeColor = System.Drawing.Color.Black
       Me.etiquetaimpuesto_ganancia.Location = New System.Drawing.Point(28, 422)
       Me.etiquetaimpuesto_ganancia.Name = "etiquetaimpuesto_ganancia"
       Me.etiquetaimpuesto_ganancia.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaimpuesto_ganancia.TabIndex = 509
       Me.etiquetaimpuesto_ganancia.Text = "Impuesto ganancia"
       Me.etiquetaimpuesto_ganancia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtsuss
       '
       Me.txtsuss.BackColor = System.Drawing.Color.White
       Me.txtsuss.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtsuss.ForeColor = System.Drawing.Color.Blue
       Me.txtsuss.Location = New System.Drawing.Point(161, 475)
       Me.txtsuss.MaxLength = 50
       Me.txtsuss.Name = "txtsuss"
       Me.txtsuss.Size = New System.Drawing.Size(222, 31)
       Me.txtsuss.TabIndex = 13
       Me.txtsuss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietasuss
       '
       Me.etiquetasuss.BackColor = System.Drawing.Color.Transparent
       Me.etiquetasuss.AutoSize = True
       Me.etiquetasuss.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetasuss.ForeColor = System.Drawing.Color.Black
       Me.etiquetasuss.Location = New System.Drawing.Point(28, 475)
       Me.etiquetasuss.Name = "etiquetasuss"
       Me.etiquetasuss.Size = New System.Drawing.Size(127, 21)
       Me.etiquetasuss.TabIndex = 510
       Me.etiquetasuss.Text = "Suss"
       Me.etiquetasuss.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txttotal_letra
       '
       Me.txttotal_letra.BackColor = System.Drawing.Color.White
       Me.txttotal_letra.Location = New System.Drawing.Point(161, 528)
       Me.txttotal_letra.Size = New System.Drawing.Size(385, 20)
       Me.txttotal_letra.MaxLength = 5000
       Me.txttotal_letra.Name = "txttotal_letra"
       Me.txttotal_letra.TabIndex = 14
       '
       'etiquietatotal_letra
       '
       Me.etiquetatotal_letra.BackColor = System.Drawing.Color.Transparent
       Me.etiquetatotal_letra.AutoSize = True
       Me.etiquetatotal_letra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetatotal_letra.ForeColor = System.Drawing.Color.Black
       Me.etiquetatotal_letra.Location = New System.Drawing.Point(28, 528)
       Me.etiquetatotal_letra.Name = "etiquetatotal_letra"
       Me.etiquetatotal_letra.Size = New System.Drawing.Size(127, 21)
       Me.etiquetatotal_letra.TabIndex = 511
       Me.etiquetatotal_letra.Text = "Total letra"
       Me.etiquetatotal_letra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtobservacion
       '
       Me.txtobservacion.BackColor = System.Drawing.Color.White
       Me.txtobservacion.Location = New System.Drawing.Point(656, 48)
       Me.txtobservacion.Size = New System.Drawing.Size(330, 20)
       Me.txtobservacion.MaxLength = 5000
       Me.txtobservacion.Name = "txtobservacion"
       Me.txtobservacion.TabIndex = 15
       '
       'etiquietaobservacion
       '
       Me.etiquetaobservacion.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaobservacion.AutoSize = True
       Me.etiquetaobservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaobservacion.ForeColor = System.Drawing.Color.Black
       Me.etiquetaobservacion.Location = New System.Drawing.Point(583, 48)
       Me.etiquetaobservacion.Name = "etiquetaobservacion"
       Me.etiquetaobservacion.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaobservacion.TabIndex = 512
       Me.etiquetaobservacion.Text = "Observacion"
       Me.etiquetaobservacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
       Me.btnSalir.Location = New System.Drawing.Point(931, 647)
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
       Me.btnGuardar.Location = New System.Drawing.Point(831, 647)
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
       Me.GroupBox1.Size = New System.Drawing.Size(1000, 606)
       Me.GroupBox1.TabIndex = 0
       Me.GroupBox1.TabStop = False
       '
       'frmDetallePago_cliente
       '
       Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
       Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
       Me.ClientSize = New System.Drawing.Size(1024, 768)
       Me.Controls.Add(Me.lblid_cliente)
       Me.Controls.Add(Me.btnBuscacliente)
       Me.Controls.Add(Me.cmbcliente)
       Me.Controls.Add(Me.etiquetaid_cliente)
       Me.Controls.Add(Me.dtpfecha)
       Me.Controls.Add(Me.etiquetafecha)
       Me.Controls.Add(Me.txtpago)
       Me.Controls.Add(Me.etiquetapago)
       Me.Controls.Add(Me.txtdetalle)
       Me.Controls.Add(Me.etiquetadetalle)
       Me.Controls.Add(Me.chkefectivo)
       Me.Controls.Add(Me.etiquetaefectivo)
       Me.Controls.Add(Me.txtnumero_recibo)
       Me.Controls.Add(Me.etiquetanumero_recibo)
       Me.Controls.Add(Me.txtretencion_iva)
       Me.Controls.Add(Me.etiquetaretencion_iva)
       Me.Controls.Add(Me.txtingreso_bruto)
       Me.Controls.Add(Me.etiquetaingreso_bruto)
       Me.Controls.Add(Me.txtimpuesto_ganancia)
       Me.Controls.Add(Me.etiquetaimpuesto_ganancia)
       Me.Controls.Add(Me.txtsuss)
       Me.Controls.Add(Me.etiquetasuss)
       Me.Controls.Add(Me.txttotal_letra)
       Me.Controls.Add(Me.etiquetatotal_letra)
       Me.Controls.Add(Me.txtobservacion)
       Me.Controls.Add(Me.etiquetaobservacion)
       Me.Controls.Add(Me.btnSalir)
       Me.Controls.Add(Me.btnGuardar)
       Me.Controls.Add(Me.GroupBox1)
       Me.Name = "frmDetallePago_cliente"
       Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
       Me.Text = "frmDetallePago_cliente" & vgNombreFormulario
       Me.ResumeLayout(False)
       Me.PerformLayout()

   End Sub
   Friend WithEvents lblid_cliente As System.Windows.Forms.Label
   Friend WithEvents btnBuscacliente As System.Windows.Forms.Button
   Friend WithEvents cmbcliente As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_cliente As System.Windows.Forms.Label
   Protected WithEvents dtpfecha As System.Windows.Forms.DateTimePicker
   Friend WithEvents etiquetafecha As System.Windows.Forms.Label
   Protected WithEvents txtpago As System.Windows.Forms.TextBox
   Friend WithEvents etiquetapago As System.Windows.Forms.Label
   Protected WithEvents txtdetalle As System.Windows.Forms.TextBox
   Friend WithEvents etiquetadetalle As System.Windows.Forms.Label
   Protected WithEvents chkefectivo As System.Windows.Forms.CheckBox
   Friend WithEvents etiquetaefectivo As System.Windows.Forms.Label
   Protected WithEvents txtnumero_recibo As System.Windows.Forms.TextBox
   Friend WithEvents etiquetanumero_recibo As System.Windows.Forms.Label
   Protected WithEvents txtretencion_iva As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaretencion_iva As System.Windows.Forms.Label
   Protected WithEvents txtingreso_bruto As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaingreso_bruto As System.Windows.Forms.Label
   Protected WithEvents txtimpuesto_ganancia As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaimpuesto_ganancia As System.Windows.Forms.Label
   Protected WithEvents txtsuss As System.Windows.Forms.TextBox
   Friend WithEvents etiquetasuss As System.Windows.Forms.Label
   Protected WithEvents txttotal_letra As System.Windows.Forms.TextBox
   Friend WithEvents etiquetatotal_letra As System.Windows.Forms.Label
   Protected WithEvents txtobservacion As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaobservacion As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
End Class

