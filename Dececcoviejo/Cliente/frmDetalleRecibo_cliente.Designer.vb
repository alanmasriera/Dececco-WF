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
        Me.lblid_factura = New System.Windows.Forms.Label
        Me.btnBuscafactura = New System.Windows.Forms.Button
        Me.cmbfactura = New System.Windows.Forms.ComboBox
        Me.chkcontrol = New System.Windows.Forms.CheckBox
        Me.lblid_cliente = New System.Windows.Forms.Label
        Me.lbl_viejo = New System.Windows.Forms.Label
        Me.txtSaldo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtGastado = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtimporte_pagado = New System.Windows.Forms.TextBox
        Me.etiquetaimporte_pagado = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
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
        Me.btnSalir.Location = New System.Drawing.Point(499, 263)
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
        Me.btnGuardar.Location = New System.Drawing.Point(392, 263)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(78, 69)
        Me.btnGuardar.TabIndex = 20
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtSaldo)
        Me.GroupBox1.Controls.Add(Me.txtGastado)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.etiquetaimporte_pagado)
        Me.GroupBox1.Controls.Add(Me.chkcontrol)
        Me.GroupBox1.Controls.Add(Me.txtimporte_pagado)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(568, 221)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lblid_pago_cliente
        '
        Me.lblid_pago_cliente.AutoSize = True
        Me.lblid_pago_cliente.BackColor = System.Drawing.Color.Red
        Me.lblid_pago_cliente.Location = New System.Drawing.Point(349, 1)
        Me.lblid_pago_cliente.Name = "lblid_pago_cliente"
        Me.lblid_pago_cliente.Size = New System.Drawing.Size(13, 13)
        Me.lblid_pago_cliente.TabIndex = 500
        Me.lblid_pago_cliente.Text = "0"
        Me.lblid_pago_cliente.Visible = False
        '
        'lblid_factura
        '
        Me.lblid_factura.AutoSize = True
        Me.lblid_factura.BackColor = System.Drawing.Color.Red
        Me.lblid_factura.Location = New System.Drawing.Point(370, 53)
        Me.lblid_factura.Name = "lblid_factura"
        Me.lblid_factura.Size = New System.Drawing.Size(13, 13)
        Me.lblid_factura.TabIndex = 502
        Me.lblid_factura.Text = "0"
        Me.lblid_factura.Visible = False
        '
        'btnBuscafactura
        '
        Me.btnBuscafactura.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscafactura.Image = CType(resources.GetObject("btnBuscafactura.Image"), System.Drawing.Image)
        Me.btnBuscafactura.Location = New System.Drawing.Point(505, 53)
        Me.btnBuscafactura.Name = "btnBuscafactura"
        Me.btnBuscafactura.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscafactura.TabIndex = 31
        Me.btnBuscafactura.UseVisualStyleBackColor = True
        '
        'cmbfactura
        '
        Me.cmbfactura.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbfactura.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbfactura.FormattingEnabled = True
        Me.cmbfactura.Location = New System.Drawing.Point(161, 53)
        Me.cmbfactura.Name = "cmbfactura"
        Me.cmbfactura.Size = New System.Drawing.Size(329, 21)
        Me.cmbfactura.TabIndex = 5
        '
        'chkcontrol
        '
        Me.chkcontrol.AutoSize = True
        Me.chkcontrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkcontrol.Location = New System.Drawing.Point(149, 183)
        Me.chkcontrol.Name = "chkcontrol"
        Me.chkcontrol.Size = New System.Drawing.Size(77, 21)
        Me.chkcontrol.TabIndex = 6
        Me.chkcontrol.Text = "control"
        '
        'lblid_cliente
        '
        Me.lblid_cliente.AutoSize = True
        Me.lblid_cliente.BackColor = System.Drawing.Color.Red
        Me.lblid_cliente.Location = New System.Drawing.Point(370, 1)
        Me.lblid_cliente.Name = "lblid_cliente"
        Me.lblid_cliente.Size = New System.Drawing.Size(13, 13)
        Me.lblid_cliente.TabIndex = 505
        Me.lblid_cliente.Text = "0"
        Me.lblid_cliente.Visible = False
        '
        'lbl_viejo
        '
        Me.lbl_viejo.AutoSize = True
        Me.lbl_viejo.BackColor = System.Drawing.Color.Red
        Me.lbl_viejo.Location = New System.Drawing.Point(400, 1)
        Me.lbl_viejo.Name = "lbl_viejo"
        Me.lbl_viejo.Size = New System.Drawing.Size(13, 13)
        Me.lbl_viejo.TabIndex = 506
        Me.lbl_viejo.Text = "0"
        Me.lbl_viejo.Visible = False
        '
        'txtSaldo
        '
        Me.txtSaldo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.ForeColor = System.Drawing.Color.Blue
        Me.txtSaldo.Location = New System.Drawing.Point(149, 103)
        Me.txtSaldo.MaxLength = 50
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.ReadOnly = True
        Me.txtSaldo.Size = New System.Drawing.Size(222, 31)
        Me.txtSaldo.TabIndex = 519
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(104, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 520
        Me.Label2.Text = "Saldo"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtGastado
        '
        Me.txtGastado.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtGastado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGastado.ForeColor = System.Drawing.Color.Blue
        Me.txtGastado.Location = New System.Drawing.Point(149, 60)
        Me.txtGastado.MaxLength = 50
        Me.txtGastado.Name = "txtGastado"
        Me.txtGastado.ReadOnly = True
        Me.txtGastado.Size = New System.Drawing.Size(222, 31)
        Me.txtGastado.TabIndex = 517
        Me.txtGastado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(90, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 15)
        Me.Label1.TabIndex = 518
        Me.Label1.Text = "Gastado"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtimporte_pagado
        '
        Me.txtimporte_pagado.BackColor = System.Drawing.Color.White
        Me.txtimporte_pagado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtimporte_pagado.ForeColor = System.Drawing.Color.Blue
        Me.txtimporte_pagado.Location = New System.Drawing.Point(149, 146)
        Me.txtimporte_pagado.MaxLength = 50
        Me.txtimporte_pagado.Name = "txtimporte_pagado"
        Me.txtimporte_pagado.Size = New System.Drawing.Size(222, 31)
        Me.txtimporte_pagado.TabIndex = 515
        Me.txtimporte_pagado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetaimporte_pagado
        '
        Me.etiquetaimporte_pagado.AutoSize = True
        Me.etiquetaimporte_pagado.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaimporte_pagado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaimporte_pagado.ForeColor = System.Drawing.Color.Black
        Me.etiquetaimporte_pagado.Location = New System.Drawing.Point(49, 146)
        Me.etiquetaimporte_pagado.Name = "etiquetaimporte_pagado"
        Me.etiquetaimporte_pagado.Size = New System.Drawing.Size(94, 15)
        Me.etiquetaimporte_pagado.TabIndex = 516
        Me.etiquetaimporte_pagado.Text = "Importe pagado"
        Me.etiquetaimporte_pagado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(95, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 15)
        Me.Label3.TabIndex = 521
        Me.Label3.Text = "Factura"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(97, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 15)
        Me.Label4.TabIndex = 522
        Me.Label4.Text = "Control"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmDetalleRecibo_cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 347)
        Me.Controls.Add(Me.lbl_viejo)
        Me.Controls.Add(Me.lblid_cliente)
        Me.Controls.Add(Me.lblid_pago_cliente)
        Me.Controls.Add(Me.lblid_factura)
        Me.Controls.Add(Me.btnBuscafactura)
        Me.Controls.Add(Me.cmbfactura)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDetalleRecibo_cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetalleRecibo_cliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Friend WithEvents lblid_pago_cliente As System.Windows.Forms.Label
    Friend WithEvents lblid_factura As System.Windows.Forms.Label
   Friend WithEvents btnBuscafactura As System.Windows.Forms.Button
   Friend WithEvents cmbfactura As System.Windows.Forms.ComboBox
    Protected WithEvents chkcontrol As System.Windows.Forms.CheckBox
    Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
    Friend WithEvents lblid_cliente As System.Windows.Forms.Label
    Friend WithEvents lbl_viejo As System.Windows.Forms.Label
    Protected WithEvents txtSaldo As System.Windows.Forms.TextBox
    Protected WithEvents txtGastado As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents etiquetaimporte_pagado As System.Windows.Forms.Label
    Protected WithEvents txtimporte_pagado As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class

