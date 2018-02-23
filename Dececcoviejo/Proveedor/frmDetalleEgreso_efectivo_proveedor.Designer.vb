<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleEgreso_efectivo_proveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleEgreso_efectivo_proveedor))
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblid_recibo_proveedor = New System.Windows.Forms.Label
        Me.lblid_egreso_efectivo = New System.Windows.Forms.Label
        Me.btnBuscaegreso_efectivo = New System.Windows.Forms.Button
        Me.cmbegreso_efectivo = New System.Windows.Forms.ComboBox
        Me.etiquetaid_egreso_efectivo = New System.Windows.Forms.Label
        Me.txtimporte_pagado = New System.Windows.Forms.TextBox
        Me.etiquetaimporte_pagado = New System.Windows.Forms.Label
        Me.chkcontrol = New System.Windows.Forms.CheckBox
        Me.etiquetacontrol = New System.Windows.Forms.Label
        Me.txtSaldo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtGastado = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblid_proveedor = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(499, 270)
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
        Me.btnGuardar.Location = New System.Drawing.Point(392, 270)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(81, 61)
        Me.btnGuardar.TabIndex = 50
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(954, 218)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lblid_recibo_proveedor
        '
        Me.lblid_recibo_proveedor.AutoSize = True
        Me.lblid_recibo_proveedor.BackColor = System.Drawing.Color.Red
        Me.lblid_recibo_proveedor.Location = New System.Drawing.Point(32, 270)
        Me.lblid_recibo_proveedor.Name = "lblid_recibo_proveedor"
        Me.lblid_recibo_proveedor.Size = New System.Drawing.Size(13, 13)
        Me.lblid_recibo_proveedor.TabIndex = 500
        Me.lblid_recibo_proveedor.Text = "0"
        Me.lblid_recibo_proveedor.Visible = False
        '
        'lblid_egreso_efectivo
        '
        Me.lblid_egreso_efectivo.AutoSize = True
        Me.lblid_egreso_efectivo.BackColor = System.Drawing.Color.Red
        Me.lblid_egreso_efectivo.Location = New System.Drawing.Point(374, 31)
        Me.lblid_egreso_efectivo.Name = "lblid_egreso_efectivo"
        Me.lblid_egreso_efectivo.Size = New System.Drawing.Size(13, 13)
        Me.lblid_egreso_efectivo.TabIndex = 502
        Me.lblid_egreso_efectivo.Text = "0"
        Me.lblid_egreso_efectivo.Visible = False
        '
        'btnBuscaegreso_efectivo
        '
        Me.btnBuscaegreso_efectivo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscaegreso_efectivo.Image = CType(resources.GetObject("btnBuscaegreso_efectivo.Image"), System.Drawing.Image)
        Me.btnBuscaegreso_efectivo.Location = New System.Drawing.Point(890, 31)
        Me.btnBuscaegreso_efectivo.Name = "btnBuscaegreso_efectivo"
        Me.btnBuscaegreso_efectivo.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscaegreso_efectivo.TabIndex = 61
        Me.btnBuscaegreso_efectivo.UseVisualStyleBackColor = True
        '
        'cmbegreso_efectivo
        '
        Me.cmbegreso_efectivo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbegreso_efectivo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbegreso_efectivo.FormattingEnabled = True
        Me.cmbegreso_efectivo.Location = New System.Drawing.Point(128, 31)
        Me.cmbegreso_efectivo.Name = "cmbegreso_efectivo"
        Me.cmbegreso_efectivo.Size = New System.Drawing.Size(738, 21)
        Me.cmbegreso_efectivo.TabIndex = 5
        '
        'etiquetaid_egreso_efectivo
        '
        Me.etiquetaid_egreso_efectivo.AutoSize = True
        Me.etiquetaid_egreso_efectivo.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaid_egreso_efectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_egreso_efectivo.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_egreso_efectivo.Location = New System.Drawing.Point(32, 29)
        Me.etiquetaid_egreso_efectivo.Name = "etiquetaid_egreso_efectivo"
        Me.etiquetaid_egreso_efectivo.Size = New System.Drawing.Size(90, 15)
        Me.etiquetaid_egreso_efectivo.TabIndex = 503
        Me.etiquetaid_egreso_efectivo.Text = "Egreso efectivo"
        Me.etiquetaid_egreso_efectivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtimporte_pagado
        '
        Me.txtimporte_pagado.BackColor = System.Drawing.Color.White
        Me.txtimporte_pagado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtimporte_pagado.ForeColor = System.Drawing.Color.Blue
        Me.txtimporte_pagado.Location = New System.Drawing.Point(128, 150)
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
        Me.etiquetaimporte_pagado.Location = New System.Drawing.Point(28, 150)
        Me.etiquetaimporte_pagado.Name = "etiquetaimporte_pagado"
        Me.etiquetaimporte_pagado.Size = New System.Drawing.Size(94, 15)
        Me.etiquetaimporte_pagado.TabIndex = 504
        Me.etiquetaimporte_pagado.Text = "Importe pagado"
        Me.etiquetaimporte_pagado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkcontrol
        '
        Me.chkcontrol.AutoSize = True
        Me.chkcontrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkcontrol.Location = New System.Drawing.Point(128, 199)
        Me.chkcontrol.Name = "chkcontrol"
        Me.chkcontrol.Size = New System.Drawing.Size(70, 21)
        Me.chkcontrol.TabIndex = 7
        Me.chkcontrol.Text = "control"
        '
        'etiquetacontrol
        '
        Me.etiquetacontrol.AutoSize = True
        Me.etiquetacontrol.BackColor = System.Drawing.Color.Transparent
        Me.etiquetacontrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetacontrol.ForeColor = System.Drawing.Color.Black
        Me.etiquetacontrol.Location = New System.Drawing.Point(76, 200)
        Me.etiquetacontrol.Name = "etiquetacontrol"
        Me.etiquetacontrol.Size = New System.Drawing.Size(46, 15)
        Me.etiquetacontrol.TabIndex = 505
        Me.etiquetacontrol.Text = "Control"
        Me.etiquetacontrol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSaldo
        '
        Me.txtSaldo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.ForeColor = System.Drawing.Color.Blue
        Me.txtSaldo.Location = New System.Drawing.Point(128, 107)
        Me.txtSaldo.MaxLength = 50
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.ReadOnly = True
        Me.txtSaldo.Size = New System.Drawing.Size(222, 31)
        Me.txtSaldo.TabIndex = 513
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(83, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 514
        Me.Label2.Text = "Saldo"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtGastado
        '
        Me.txtGastado.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtGastado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGastado.ForeColor = System.Drawing.Color.Blue
        Me.txtGastado.Location = New System.Drawing.Point(128, 64)
        Me.txtGastado.MaxLength = 50
        Me.txtGastado.Name = "txtGastado"
        Me.txtGastado.ReadOnly = True
        Me.txtGastado.Size = New System.Drawing.Size(222, 31)
        Me.txtGastado.TabIndex = 511
        Me.txtGastado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(69, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 15)
        Me.Label1.TabIndex = 512
        Me.Label1.Text = "Gastado"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_proveedor
        '
        Me.lblid_proveedor.AutoSize = True
        Me.lblid_proveedor.BackColor = System.Drawing.Color.Red
        Me.lblid_proveedor.Location = New System.Drawing.Point(12, 270)
        Me.lblid_proveedor.Name = "lblid_proveedor"
        Me.lblid_proveedor.Size = New System.Drawing.Size(13, 13)
        Me.lblid_proveedor.TabIndex = 515
        Me.lblid_proveedor.Text = "0"
        Me.lblid_proveedor.Visible = False
        '
        'frmDetalleEgreso_efectivo_proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(997, 350)
        Me.Controls.Add(Me.lblid_proveedor)
        Me.Controls.Add(Me.txtSaldo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtGastado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblid_recibo_proveedor)
        Me.Controls.Add(Me.lblid_egreso_efectivo)
        Me.Controls.Add(Me.btnBuscaegreso_efectivo)
        Me.Controls.Add(Me.cmbegreso_efectivo)
        Me.Controls.Add(Me.etiquetaid_egreso_efectivo)
        Me.Controls.Add(Me.txtimporte_pagado)
        Me.Controls.Add(Me.etiquetaimporte_pagado)
        Me.Controls.Add(Me.chkcontrol)
        Me.Controls.Add(Me.etiquetacontrol)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDetalleEgreso_efectivo_proveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetalleEgreso_efectivo_proveedor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblid_recibo_proveedor As System.Windows.Forms.Label
    Friend WithEvents lblid_egreso_efectivo As System.Windows.Forms.Label
    Friend WithEvents btnBuscaegreso_efectivo As System.Windows.Forms.Button
    Friend WithEvents cmbegreso_efectivo As System.Windows.Forms.ComboBox
    Friend WithEvents etiquetaid_egreso_efectivo As System.Windows.Forms.Label
    Protected WithEvents txtimporte_pagado As System.Windows.Forms.TextBox
    Friend WithEvents etiquetaimporte_pagado As System.Windows.Forms.Label
    Protected WithEvents chkcontrol As System.Windows.Forms.CheckBox
    Friend WithEvents etiquetacontrol As System.Windows.Forms.Label
    Protected WithEvents btnSalir As System.Windows.Forms.Button
    Protected WithEvents btnGuardar As System.Windows.Forms.Button
    Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
    Protected WithEvents txtSaldo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Protected WithEvents txtGastado As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblid_proveedor As System.Windows.Forms.Label
End Class

