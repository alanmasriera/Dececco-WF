<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleFactura_recibo_proveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleFactura_recibo_proveedor))
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblid_proveedor = New System.Windows.Forms.Label
        Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblid_factura_proveedor = New System.Windows.Forms.Label
        Me.btnBuscafactura_proveedor = New System.Windows.Forms.Button
        Me.cmbfactura_proveedor = New System.Windows.Forms.ComboBox
        Me.etiquetaid_factura_proveedor = New System.Windows.Forms.Label
        Me.lblid_recibo_proveedor = New System.Windows.Forms.Label
        Me.txtimporte_pagado = New System.Windows.Forms.TextBox
        Me.etiquetaimporte_pagado = New System.Windows.Forms.Label
        Me.chkefectivo = New System.Windows.Forms.CheckBox
        Me.etiquetaefectivo = New System.Windows.Forms.Label
        Me.txtGastado = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSaldo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
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
        Me.btnSalir.Location = New System.Drawing.Point(499, 270)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(81, 69)
        Me.btnSalir.TabIndex = 51
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
        Me.btnGuardar.Location = New System.Drawing.Point(392, 270)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(78, 69)
        Me.btnGuardar.TabIndex = 50
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(12, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(568, 247)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lblid_proveedor
        '
        Me.lblid_proveedor.AutoSize = True
        Me.lblid_proveedor.BackColor = System.Drawing.Color.Red
        Me.lblid_proveedor.Location = New System.Drawing.Point(389, 1)
        Me.lblid_proveedor.Name = "lblid_proveedor"
        Me.lblid_proveedor.Size = New System.Drawing.Size(13, 13)
        Me.lblid_proveedor.TabIndex = 506
        Me.lblid_proveedor.Text = "0"
        Me.lblid_proveedor.Visible = False
        '
        'lblid_factura_proveedor
        '
        Me.lblid_factura_proveedor.AutoSize = True
        Me.lblid_factura_proveedor.BackColor = System.Drawing.Color.Red
        Me.lblid_factura_proveedor.Location = New System.Drawing.Point(370, 48)
        Me.lblid_factura_proveedor.Name = "lblid_factura_proveedor"
        Me.lblid_factura_proveedor.Size = New System.Drawing.Size(13, 13)
        Me.lblid_factura_proveedor.TabIndex = 500
        Me.lblid_factura_proveedor.Text = "0"
        Me.lblid_factura_proveedor.Visible = False
        '
        'btnBuscafactura_proveedor
        '
        Me.btnBuscafactura_proveedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscafactura_proveedor.Image = CType(resources.GetObject("btnBuscafactura_proveedor.Image"), System.Drawing.Image)
        Me.btnBuscafactura_proveedor.Location = New System.Drawing.Point(505, 48)
        Me.btnBuscafactura_proveedor.Name = "btnBuscafactura_proveedor"
        Me.btnBuscafactura_proveedor.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscafactura_proveedor.TabIndex = 60
        Me.btnBuscafactura_proveedor.UseVisualStyleBackColor = True
        '
        'cmbfactura_proveedor
        '
        Me.cmbfactura_proveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbfactura_proveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbfactura_proveedor.FormattingEnabled = True
        Me.cmbfactura_proveedor.Location = New System.Drawing.Point(161, 48)
        Me.cmbfactura_proveedor.Name = "cmbfactura_proveedor"
        Me.cmbfactura_proveedor.Size = New System.Drawing.Size(329, 21)
        Me.cmbfactura_proveedor.TabIndex = 4
        '
        'etiquetaid_factura_proveedor
        '
        Me.etiquetaid_factura_proveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_factura_proveedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_factura_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_factura_proveedor.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_factura_proveedor.Location = New System.Drawing.Point(18, 48)
        Me.etiquetaid_factura_proveedor.Name = "etiquetaid_factura_proveedor"
        Me.etiquetaid_factura_proveedor.Size = New System.Drawing.Size(137, 21)
        Me.etiquetaid_factura_proveedor.TabIndex = 501
        Me.etiquetaid_factura_proveedor.Text = "Factura_proveedor"
        Me.etiquetaid_factura_proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_recibo_proveedor
        '
        Me.lblid_recibo_proveedor.AutoSize = True
        Me.lblid_recibo_proveedor.BackColor = System.Drawing.Color.Red
        Me.lblid_recibo_proveedor.Location = New System.Drawing.Point(370, 1)
        Me.lblid_recibo_proveedor.Name = "lblid_recibo_proveedor"
        Me.lblid_recibo_proveedor.Size = New System.Drawing.Size(13, 13)
        Me.lblid_recibo_proveedor.TabIndex = 502
        Me.lblid_recibo_proveedor.Text = "0"
        Me.lblid_recibo_proveedor.Visible = False
        '
        'txtimporte_pagado
        '
        Me.txtimporte_pagado.BackColor = System.Drawing.Color.White
        Me.txtimporte_pagado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtimporte_pagado.ForeColor = System.Drawing.Color.Blue
        Me.txtimporte_pagado.Location = New System.Drawing.Point(161, 166)
        Me.txtimporte_pagado.MaxLength = 50
        Me.txtimporte_pagado.Name = "txtimporte_pagado"
        Me.txtimporte_pagado.Size = New System.Drawing.Size(222, 31)
        Me.txtimporte_pagado.TabIndex = 6
        Me.txtimporte_pagado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetaimporte_pagado
        '
        Me.etiquetaimporte_pagado.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaimporte_pagado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaimporte_pagado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaimporte_pagado.ForeColor = System.Drawing.Color.Black
        Me.etiquetaimporte_pagado.Location = New System.Drawing.Point(18, 166)
        Me.etiquetaimporte_pagado.Name = "etiquetaimporte_pagado"
        Me.etiquetaimporte_pagado.Size = New System.Drawing.Size(137, 21)
        Me.etiquetaimporte_pagado.TabIndex = 504
        Me.etiquetaimporte_pagado.Text = "Importe_pagado"
        Me.etiquetaimporte_pagado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkefectivo
        '
        Me.chkefectivo.AutoSize = True
        Me.chkefectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkefectivo.Location = New System.Drawing.Point(161, 221)
        Me.chkefectivo.Name = "chkefectivo"
        Me.chkefectivo.Size = New System.Drawing.Size(84, 21)
        Me.chkefectivo.TabIndex = 7
        Me.chkefectivo.Text = "efectivo"
        '
        'etiquetaefectivo
        '
        Me.etiquetaefectivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaefectivo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaefectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaefectivo.ForeColor = System.Drawing.Color.Black
        Me.etiquetaefectivo.Location = New System.Drawing.Point(18, 221)
        Me.etiquetaefectivo.Name = "etiquetaefectivo"
        Me.etiquetaefectivo.Size = New System.Drawing.Size(137, 21)
        Me.etiquetaefectivo.TabIndex = 505
        Me.etiquetaefectivo.Text = "Efectivo"
        Me.etiquetaefectivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtGastado
        '
        Me.txtGastado.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtGastado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGastado.ForeColor = System.Drawing.Color.Blue
        Me.txtGastado.Location = New System.Drawing.Point(161, 81)
        Me.txtGastado.MaxLength = 50
        Me.txtGastado.Name = "txtGastado"
        Me.txtGastado.ReadOnly = True
        Me.txtGastado.Size = New System.Drawing.Size(222, 31)
        Me.txtGastado.TabIndex = 507
        Me.txtGastado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(18, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 21)
        Me.Label1.TabIndex = 508
        Me.Label1.Text = "Gastado"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSaldo
        '
        Me.txtSaldo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.ForeColor = System.Drawing.Color.Blue
        Me.txtSaldo.Location = New System.Drawing.Point(161, 123)
        Me.txtSaldo.MaxLength = 50
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.ReadOnly = True
        Me.txtSaldo.Size = New System.Drawing.Size(222, 31)
        Me.txtSaldo.TabIndex = 509
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(18, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 21)
        Me.Label2.TabIndex = 510
        Me.Label2.Text = "Saldo"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmDetalleFactura_recibo_proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 350)
        Me.Controls.Add(Me.txtSaldo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtGastado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblid_proveedor)
        Me.Controls.Add(Me.lblid_factura_proveedor)
        Me.Controls.Add(Me.btnBuscafactura_proveedor)
        Me.Controls.Add(Me.cmbfactura_proveedor)
        Me.Controls.Add(Me.etiquetaid_factura_proveedor)
        Me.Controls.Add(Me.lblid_recibo_proveedor)
        Me.Controls.Add(Me.txtimporte_pagado)
        Me.Controls.Add(Me.etiquetaimporte_pagado)
        Me.Controls.Add(Me.chkefectivo)
        Me.Controls.Add(Me.etiquetaefectivo)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDetalleFactura_recibo_proveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetalleFactura_recibo_proveedor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblid_factura_proveedor As System.Windows.Forms.Label
    Friend WithEvents btnBuscafactura_proveedor As System.Windows.Forms.Button
    Friend WithEvents cmbfactura_proveedor As System.Windows.Forms.ComboBox
    Friend WithEvents etiquetaid_factura_proveedor As System.Windows.Forms.Label
    Friend WithEvents lblid_recibo_proveedor As System.Windows.Forms.Label
    Protected WithEvents txtimporte_pagado As System.Windows.Forms.TextBox
    Friend WithEvents etiquetaimporte_pagado As System.Windows.Forms.Label
    Protected WithEvents chkefectivo As System.Windows.Forms.CheckBox
    Friend WithEvents etiquetaefectivo As System.Windows.Forms.Label
    Protected WithEvents btnSalir As System.Windows.Forms.Button
    Protected WithEvents btnGuardar As System.Windows.Forms.Button
    Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
    Friend WithEvents lblid_proveedor As System.Windows.Forms.Label
    Protected WithEvents txtGastado As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Protected WithEvents txtSaldo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class

