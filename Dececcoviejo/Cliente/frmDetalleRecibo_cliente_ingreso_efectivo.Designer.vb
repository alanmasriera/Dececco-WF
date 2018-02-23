<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleRecibo_cliente_ingreso_efectivo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleRecibo_cliente_ingreso_efectivo))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.etiquetacontrol = New System.Windows.Forms.Label
        Me.chkcontrol = New System.Windows.Forms.CheckBox
        Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblid_pago_cliente = New System.Windows.Forms.Label
        Me.lblid_ingreso_efectivo = New System.Windows.Forms.Label
        Me.cmbingreso_efectivo = New System.Windows.Forms.ComboBox
        Me.etiquetaid_ingreso_efectivo = New System.Windows.Forms.Label
        Me.txtimporte_pagado = New System.Windows.Forms.TextBox
        Me.etiquetaimporte_pagado = New System.Windows.Forms.Label
        Me.btnBuscaingreso_efectivo = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.txtSaldo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtGastado = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblid_cliente = New System.Windows.Forms.Label
        Me.lbl_viejo = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.etiquetacontrol)
        Me.GroupBox1.Controls.Add(Me.chkcontrol)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(568, 255)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'etiquetacontrol
        '
        Me.etiquetacontrol.AutoSize = True
        Me.etiquetacontrol.BackColor = System.Drawing.Color.Transparent
        Me.etiquetacontrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetacontrol.ForeColor = System.Drawing.Color.Black
        Me.etiquetacontrol.Location = New System.Drawing.Point(19, 211)
        Me.etiquetacontrol.Name = "etiquetacontrol"
        Me.etiquetacontrol.Size = New System.Drawing.Size(46, 15)
        Me.etiquetacontrol.TabIndex = 516
        Me.etiquetacontrol.Text = "Control"
        Me.etiquetacontrol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkcontrol
        '
        Me.chkcontrol.AutoSize = True
        Me.chkcontrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkcontrol.Location = New System.Drawing.Point(147, 210)
        Me.chkcontrol.Name = "chkcontrol"
        Me.chkcontrol.Size = New System.Drawing.Size(70, 21)
        Me.chkcontrol.TabIndex = 515
        Me.chkcontrol.Text = "control"
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
        'lblid_ingreso_efectivo
        '
        Me.lblid_ingreso_efectivo.AutoSize = True
        Me.lblid_ingreso_efectivo.BackColor = System.Drawing.Color.Red
        Me.lblid_ingreso_efectivo.Location = New System.Drawing.Point(370, 91)
        Me.lblid_ingreso_efectivo.Name = "lblid_ingreso_efectivo"
        Me.lblid_ingreso_efectivo.Size = New System.Drawing.Size(13, 13)
        Me.lblid_ingreso_efectivo.TabIndex = 502
        Me.lblid_ingreso_efectivo.Text = "0"
        Me.lblid_ingreso_efectivo.Visible = False
        '
        'cmbingreso_efectivo
        '
        Me.cmbingreso_efectivo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbingreso_efectivo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbingreso_efectivo.FormattingEnabled = True
        Me.cmbingreso_efectivo.Location = New System.Drawing.Point(161, 91)
        Me.cmbingreso_efectivo.Name = "cmbingreso_efectivo"
        Me.cmbingreso_efectivo.Size = New System.Drawing.Size(329, 21)
        Me.cmbingreso_efectivo.TabIndex = 5
        '
        'etiquetaid_ingreso_efectivo
        '
        Me.etiquetaid_ingreso_efectivo.AutoSize = True
        Me.etiquetaid_ingreso_efectivo.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaid_ingreso_efectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_ingreso_efectivo.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_ingreso_efectivo.Location = New System.Drawing.Point(28, 91)
        Me.etiquetaid_ingreso_efectivo.Name = "etiquetaid_ingreso_efectivo"
        Me.etiquetaid_ingreso_efectivo.Size = New System.Drawing.Size(92, 15)
        Me.etiquetaid_ingreso_efectivo.TabIndex = 503
        Me.etiquetaid_ingreso_efectivo.Text = "Ingreso efectivo"
        Me.etiquetaid_ingreso_efectivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtimporte_pagado
        '
        Me.txtimporte_pagado.BackColor = System.Drawing.Color.White
        Me.txtimporte_pagado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtimporte_pagado.ForeColor = System.Drawing.Color.Blue
        Me.txtimporte_pagado.Location = New System.Drawing.Point(159, 220)
        Me.txtimporte_pagado.MaxLength = 50
        Me.txtimporte_pagado.Name = "txtimporte_pagado"
        Me.txtimporte_pagado.Size = New System.Drawing.Size(222, 31)
        Me.txtimporte_pagado.TabIndex = 6
        Me.txtimporte_pagado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetaimporte_pagado
        '
        Me.etiquetaimporte_pagado.AutoSize = True
        Me.etiquetaimporte_pagado.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaimporte_pagado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaimporte_pagado.ForeColor = System.Drawing.Color.Black
        Me.etiquetaimporte_pagado.Location = New System.Drawing.Point(26, 220)
        Me.etiquetaimporte_pagado.Name = "etiquetaimporte_pagado"
        Me.etiquetaimporte_pagado.Size = New System.Drawing.Size(94, 15)
        Me.etiquetaimporte_pagado.TabIndex = 504
        Me.etiquetaimporte_pagado.Text = "Importe pagado"
        Me.etiquetaimporte_pagado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnBuscaingreso_efectivo
        '
        Me.btnBuscaingreso_efectivo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscaingreso_efectivo.Image = CType(resources.GetObject("btnBuscaingreso_efectivo.Image"), System.Drawing.Image)
        Me.btnBuscaingreso_efectivo.Location = New System.Drawing.Point(505, 91)
        Me.btnBuscaingreso_efectivo.Name = "btnBuscaingreso_efectivo"
        Me.btnBuscaingreso_efectivo.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscaingreso_efectivo.TabIndex = 61
        Me.btnBuscaingreso_efectivo.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(499, 325)
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
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(392, 325)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(81, 61)
        Me.btnGuardar.TabIndex = 50
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtSaldo
        '
        Me.txtSaldo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.ForeColor = System.Drawing.Color.Blue
        Me.txtSaldo.Location = New System.Drawing.Point(159, 174)
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
        Me.Label2.Location = New System.Drawing.Point(28, 174)
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
        Me.txtGastado.Location = New System.Drawing.Point(159, 131)
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
        Me.Label1.Location = New System.Drawing.Point(28, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 15)
        Me.Label1.TabIndex = 518
        Me.Label1.Text = "Gastado"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_cliente
        '
        Me.lblid_cliente.AutoSize = True
        Me.lblid_cliente.BackColor = System.Drawing.Color.Red
        Me.lblid_cliente.Location = New System.Drawing.Point(322, 48)
        Me.lblid_cliente.Name = "lblid_cliente"
        Me.lblid_cliente.Size = New System.Drawing.Size(13, 13)
        Me.lblid_cliente.TabIndex = 521
        Me.lblid_cliente.Text = "0"
        Me.lblid_cliente.Visible = False
        '
        'lbl_viejo
        '
        Me.lbl_viejo.AutoSize = True
        Me.lbl_viejo.BackColor = System.Drawing.Color.Red
        Me.lbl_viejo.Location = New System.Drawing.Point(417, 48)
        Me.lbl_viejo.Name = "lbl_viejo"
        Me.lbl_viejo.Size = New System.Drawing.Size(13, 13)
        Me.lbl_viejo.TabIndex = 522
        Me.lbl_viejo.Text = "0"
        Me.lbl_viejo.Visible = False
        '
        'frmDetalleRecibo_cliente_ingreso_efectivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 398)
        Me.Controls.Add(Me.lbl_viejo)
        Me.Controls.Add(Me.lblid_cliente)
        Me.Controls.Add(Me.txtSaldo)
        Me.Controls.Add(Me.lblid_pago_cliente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblid_ingreso_efectivo)
        Me.Controls.Add(Me.txtGastado)
        Me.Controls.Add(Me.btnBuscaingreso_efectivo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbingreso_efectivo)
        Me.Controls.Add(Me.etiquetaid_ingreso_efectivo)
        Me.Controls.Add(Me.txtimporte_pagado)
        Me.Controls.Add(Me.etiquetaimporte_pagado)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDetalleRecibo_cliente_ingreso_efectivo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetalleRecibo_cliente_ingreso_efectivo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Friend WithEvents lblid_pago_cliente As System.Windows.Forms.Label
    Friend WithEvents lblid_ingreso_efectivo As System.Windows.Forms.Label
   Friend WithEvents btnBuscaingreso_efectivo As System.Windows.Forms.Button
   Friend WithEvents cmbingreso_efectivo As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_ingreso_efectivo As System.Windows.Forms.Label
   Protected WithEvents txtimporte_pagado As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaimporte_pagado As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
    Friend WithEvents etiquetacontrol As System.Windows.Forms.Label
    Protected WithEvents chkcontrol As System.Windows.Forms.CheckBox
    Protected WithEvents txtSaldo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Protected WithEvents txtGastado As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblid_cliente As System.Windows.Forms.Label
    Friend WithEvents lbl_viejo As System.Windows.Forms.Label
End Class

