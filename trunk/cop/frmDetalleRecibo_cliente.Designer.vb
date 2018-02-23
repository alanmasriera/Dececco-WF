<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleRecibo_cliente
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
       Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleRecibo_cliente))
       Me.btnSalir = New System.Windows.Forms.Button
       Me.btnGuardar = New System.Windows.Forms.Button
       Me.GroupBox1 = New System.Windows.Forms.GroupBox
       Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
       Me.lblid_pago_cliente = New System.Windows.Forms.Label
       Me.btnBuscapago_cliente = New System.Windows.Forms.Button
       Me.cmbpago_cliente = New System.Windows.Forms.ComboBox
       Me.etiquetaid_pago_cliente = New System.Windows.Forms.Label
       Me.lblid_factura = New System.Windows.Forms.Label
       Me.btnBuscafactura = New System.Windows.Forms.Button
       Me.cmbfactura = New System.Windows.Forms.ComboBox
       Me.etiquetaid_factura = New System.Windows.Forms.Label
       Me.txtimporte_pagado = New System.Windows.Forms.TextBox
       Me.etiquetaimporte_pagado = New System.Windows.Forms.Label
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
       'lblid_factura
       '
       Me.lblid_factura.AutoSize = True
       Me.lblid_factura.BackColor = System.Drawing.Color.Red
       Me.lblid_factura.Location = New System.Drawing.Point(370, 91)
       Me.lblid_factura.Name = "lblid_factura"
       Me.lblid_factura.Size = New System.Drawing.Size(13, 13)
       Me.lblid_factura.TabIndex = 502
       Me.lblid_factura.Text = "0"
       Me.lblid_factura.Visible = False
       '
       'btnBuscafactura
       '
       Me.btnBuscafactura.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscafactura.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscafactura.Location = New System.Drawing.Point(505, 91)
       Me.btnBuscafactura.Name = "btnBuscafactura"
       Me.btnBuscafactura.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscafactura.TabIndex = 61
       Me.btnBuscafactura.UseVisualStyleBackColor = True
       '
       'cmbfactura
       '
       Me.cmbfactura.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbfactura.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbfactura.FormattingEnabled = True
       Me.cmbfactura.Location = New System.Drawing.Point(161, 91)
       Me.cmbfactura.Size = New System.Drawing.Size(329, 21)
       Me.cmbfactura.Name = "cmbfactura"
       Me.cmbfactura.TabIndex = 5
       '
       'etiquietaid_factura
       '
       Me.etiquetaid_factura.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_factura.AutoSize = True
       Me.etiquetaid_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_factura.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_factura.Location = New System.Drawing.Point(28, 91)
       Me.etiquetaid_factura.Name = "etiquetaid_factura"
       Me.etiquetaid_factura.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_factura.TabIndex = 503
       Me.etiquetaid_factura.Text = "Factura"
       Me.etiquetaid_factura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtimporte_pagado
       '
       Me.txtimporte_pagado.BackColor = System.Drawing.Color.White
       Me.txtimporte_pagado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtimporte_pagado.ForeColor = System.Drawing.Color.Blue
       Me.txtimporte_pagado.Location = New System.Drawing.Point(161, 134)
       Me.txtimporte_pagado.MaxLength = 50
       Me.txtimporte_pagado.Name = "txtimporte_pagado"
       Me.txtimporte_pagado.Size = New System.Drawing.Size(222, 31)
       Me.txtimporte_pagado.TabIndex = 6
       Me.txtimporte_pagado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietaimporte_pagado
       '
       Me.etiquetaimporte_pagado.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaimporte_pagado.AutoSize = True
       Me.etiquetaimporte_pagado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaimporte_pagado.ForeColor = System.Drawing.Color.Black
       Me.etiquetaimporte_pagado.Location = New System.Drawing.Point(28, 134)
       Me.etiquetaimporte_pagado.Name = "etiquetaimporte_pagado"
       Me.etiquetaimporte_pagado.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaimporte_pagado.TabIndex = 504
       Me.etiquetaimporte_pagado.Text = "Importe pagado"
       Me.etiquetaimporte_pagado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
       Me.btnSalir.Location = New System.Drawing.Point(499, 227)
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
       Me.btnGuardar.Location = New System.Drawing.Point(392,227)
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
       Me.GroupBox1.Size = New System.Drawing.Size(568, 187)
       Me.GroupBox1.TabIndex = 0
       Me.GroupBox1.TabStop = False
       '
       'frmDetalleRecibo_cliente
       '
       Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
       Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
       Me.ClientSize = New System.Drawing.Size(600, 307)
       Me.Controls.Add(Me.lblid_pago_cliente)
       Me.Controls.Add(Me.btnBuscapago_cliente)
       Me.Controls.Add(Me.cmbpago_cliente)
       Me.Controls.Add(Me.etiquetaid_pago_cliente)
       Me.Controls.Add(Me.lblid_factura)
       Me.Controls.Add(Me.btnBuscafactura)
       Me.Controls.Add(Me.cmbfactura)
       Me.Controls.Add(Me.etiquetaid_factura)
       Me.Controls.Add(Me.txtimporte_pagado)
       Me.Controls.Add(Me.etiquetaimporte_pagado)
       Me.Controls.Add(Me.btnSalir)
       Me.Controls.Add(Me.btnGuardar)
       Me.Controls.Add(Me.GroupBox1)
       Me.Name = "frmDetalleRecibo_cliente"
       Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
       Me.Text = "frmDetalleRecibo_cliente" & vgNombreFormulario
       Me.ResumeLayout(False)
       Me.PerformLayout()

   End Sub
   Friend WithEvents lblid_pago_cliente As System.Windows.Forms.Label
   Friend WithEvents btnBuscapago_cliente As System.Windows.Forms.Button
   Friend WithEvents cmbpago_cliente As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_pago_cliente As System.Windows.Forms.Label
   Friend WithEvents lblid_factura As System.Windows.Forms.Label
   Friend WithEvents btnBuscafactura As System.Windows.Forms.Button
   Friend WithEvents cmbfactura As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_factura As System.Windows.Forms.Label
   Protected WithEvents txtimporte_pagado As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaimporte_pagado As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
End Class

