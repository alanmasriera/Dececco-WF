<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleEgreso_efectivo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleEgreso_efectivo))
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker
        Me.etiquetafecha = New System.Windows.Forms.Label
        Me.txtcomprobante = New System.Windows.Forms.TextBox
        Me.etiquetacomprobante = New System.Windows.Forms.Label
        Me.txtimporte = New System.Windows.Forms.TextBox
        Me.etiquetaimporte = New System.Windows.Forms.Label
        Me.txtdetalle = New System.Windows.Forms.TextBox
        Me.etiquetadetalle = New System.Windows.Forms.Label
        Me.lblid_empresa = New System.Windows.Forms.Label
        Me.chkcontrol = New System.Windows.Forms.CheckBox
        Me.etiquetacontrol = New System.Windows.Forms.Label
        Me.chka_rendir = New System.Windows.Forms.CheckBox
        Me.etiquetaa_rendir = New System.Windows.Forms.Label
        Me.lblid_proveedor = New System.Windows.Forms.Label
        Me.btnBuscaproveedor = New System.Windows.Forms.Button
        Me.cmbproveedor = New System.Windows.Forms.ComboBox
        Me.etiquetaid_proveedor = New System.Windows.Forms.Label
        Me.chkarchivado = New System.Windows.Forms.CheckBox
        Me.etiquetaarchivado = New System.Windows.Forms.Label
        Me.lblid_tipo_egreso = New System.Windows.Forms.Label
        Me.btnBuscatipo_egreso = New System.Windows.Forms.Button
        Me.cmbtipo_egreso = New System.Windows.Forms.ComboBox
        Me.etiquetaid_tipo_egreso = New System.Windows.Forms.Label
        Me.txtiva = New System.Windows.Forms.TextBox
        Me.etiquetaiva = New System.Windows.Forms.Label
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
        Me.btnSalir.Location = New System.Drawing.Point(499, 346)
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
        Me.btnGuardar.Location = New System.Drawing.Point(392, 346)
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
        Me.GroupBox1.Size = New System.Drawing.Size(568, 311)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'dtpfecha
        '
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha.Location = New System.Drawing.Point(161, 48)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(93, 20)
        Me.dtpfecha.TabIndex = 4
        '
        'etiquetafecha
        '
        Me.etiquetafecha.AutoSize = True
        Me.etiquetafecha.BackColor = System.Drawing.Color.Transparent
        Me.etiquetafecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetafecha.ForeColor = System.Drawing.Color.Black
        Me.etiquetafecha.Location = New System.Drawing.Point(28, 48)
        Me.etiquetafecha.Name = "etiquetafecha"
        Me.etiquetafecha.Size = New System.Drawing.Size(41, 15)
        Me.etiquetafecha.TabIndex = 500
        Me.etiquetafecha.Text = "Fecha"
        Me.etiquetafecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcomprobante
        '
        Me.txtcomprobante.BackColor = System.Drawing.Color.White
        Me.txtcomprobante.Location = New System.Drawing.Point(161, 91)
        Me.txtcomprobante.MaxLength = 50
        Me.txtcomprobante.Name = "txtcomprobante"
        Me.txtcomprobante.Size = New System.Drawing.Size(385, 20)
        Me.txtcomprobante.TabIndex = 5
        '
        'etiquetacomprobante
        '
        Me.etiquetacomprobante.AutoSize = True
        Me.etiquetacomprobante.BackColor = System.Drawing.Color.Transparent
        Me.etiquetacomprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetacomprobante.ForeColor = System.Drawing.Color.Black
        Me.etiquetacomprobante.Location = New System.Drawing.Point(28, 91)
        Me.etiquetacomprobante.Name = "etiquetacomprobante"
        Me.etiquetacomprobante.Size = New System.Drawing.Size(82, 15)
        Me.etiquetacomprobante.TabIndex = 501
        Me.etiquetacomprobante.Text = "Comprobante"
        Me.etiquetacomprobante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtimporte
        '
        Me.txtimporte.BackColor = System.Drawing.Color.White
        Me.txtimporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtimporte.ForeColor = System.Drawing.Color.Blue
        Me.txtimporte.Location = New System.Drawing.Point(161, 134)
        Me.txtimporte.MaxLength = 50
        Me.txtimporte.Name = "txtimporte"
        Me.txtimporte.Size = New System.Drawing.Size(222, 31)
        Me.txtimporte.TabIndex = 6
        Me.txtimporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetaimporte
        '
        Me.etiquetaimporte.AutoSize = True
        Me.etiquetaimporte.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaimporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaimporte.ForeColor = System.Drawing.Color.Black
        Me.etiquetaimporte.Location = New System.Drawing.Point(28, 134)
        Me.etiquetaimporte.Name = "etiquetaimporte"
        Me.etiquetaimporte.Size = New System.Drawing.Size(49, 15)
        Me.etiquetaimporte.TabIndex = 502
        Me.etiquetaimporte.Text = "Importe"
        Me.etiquetaimporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtdetalle
        '
        Me.txtdetalle.BackColor = System.Drawing.Color.White
        Me.txtdetalle.Location = New System.Drawing.Point(161, 187)
        Me.txtdetalle.MaxLength = 50
        Me.txtdetalle.Name = "txtdetalle"
        Me.txtdetalle.Size = New System.Drawing.Size(385, 20)
        Me.txtdetalle.TabIndex = 8
        '
        'etiquetadetalle
        '
        Me.etiquetadetalle.AutoSize = True
        Me.etiquetadetalle.BackColor = System.Drawing.Color.Transparent
        Me.etiquetadetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetadetalle.ForeColor = System.Drawing.Color.Black
        Me.etiquetadetalle.Location = New System.Drawing.Point(28, 187)
        Me.etiquetadetalle.Name = "etiquetadetalle"
        Me.etiquetadetalle.Size = New System.Drawing.Size(46, 15)
        Me.etiquetadetalle.TabIndex = 504
        Me.etiquetadetalle.Text = "Detalle"
        Me.etiquetadetalle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_empresa
        '
        Me.lblid_empresa.AutoSize = True
        Me.lblid_empresa.BackColor = System.Drawing.Color.Red
        Me.lblid_empresa.Location = New System.Drawing.Point(109, 1)
        Me.lblid_empresa.Name = "lblid_empresa"
        Me.lblid_empresa.Size = New System.Drawing.Size(13, 13)
        Me.lblid_empresa.TabIndex = 505
        Me.lblid_empresa.Text = "0"
        Me.lblid_empresa.Visible = False
        '
        'chkcontrol
        '
        Me.chkcontrol.AutoSize = True
        Me.chkcontrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkcontrol.Location = New System.Drawing.Point(145, 346)
        Me.chkcontrol.Name = "chkcontrol"
        Me.chkcontrol.Size = New System.Drawing.Size(70, 21)
        Me.chkcontrol.TabIndex = 10
        Me.chkcontrol.Text = "control"
        Me.chkcontrol.Visible = False
        '
        'etiquetacontrol
        '
        Me.etiquetacontrol.AutoSize = True
        Me.etiquetacontrol.BackColor = System.Drawing.Color.Transparent
        Me.etiquetacontrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetacontrol.ForeColor = System.Drawing.Color.Black
        Me.etiquetacontrol.Location = New System.Drawing.Point(12, 346)
        Me.etiquetacontrol.Name = "etiquetacontrol"
        Me.etiquetacontrol.Size = New System.Drawing.Size(46, 15)
        Me.etiquetacontrol.TabIndex = 507
        Me.etiquetacontrol.Text = "Control"
        Me.etiquetacontrol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.etiquetacontrol.Visible = False
        '
        'chka_rendir
        '
        Me.chka_rendir.AutoSize = True
        Me.chka_rendir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chka_rendir.Location = New System.Drawing.Point(145, 389)
        Me.chka_rendir.Name = "chka_rendir"
        Me.chka_rendir.Size = New System.Drawing.Size(80, 21)
        Me.chka_rendir.TabIndex = 11
        Me.chka_rendir.Text = "a_rendir"
        Me.chka_rendir.Visible = False
        '
        'etiquetaa_rendir
        '
        Me.etiquetaa_rendir.AutoSize = True
        Me.etiquetaa_rendir.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaa_rendir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaa_rendir.ForeColor = System.Drawing.Color.Black
        Me.etiquetaa_rendir.Location = New System.Drawing.Point(12, 389)
        Me.etiquetaa_rendir.Name = "etiquetaa_rendir"
        Me.etiquetaa_rendir.Size = New System.Drawing.Size(49, 15)
        Me.etiquetaa_rendir.TabIndex = 508
        Me.etiquetaa_rendir.Text = "A rendir"
        Me.etiquetaa_rendir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.etiquetaa_rendir.Visible = False
        '
        'lblid_proveedor
        '
        Me.lblid_proveedor.AutoSize = True
        Me.lblid_proveedor.BackColor = System.Drawing.Color.Red
        Me.lblid_proveedor.Location = New System.Drawing.Point(142, 233)
        Me.lblid_proveedor.Name = "lblid_proveedor"
        Me.lblid_proveedor.Size = New System.Drawing.Size(13, 13)
        Me.lblid_proveedor.TabIndex = 509
        Me.lblid_proveedor.Text = "0"
        Me.lblid_proveedor.Visible = False
        '
        'btnBuscaproveedor
        '
        Me.btnBuscaproveedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscaproveedor.Image = CType(resources.GetObject("btnBuscaproveedor.Image"), System.Drawing.Image)
        Me.btnBuscaproveedor.Location = New System.Drawing.Point(505, 229)
        Me.btnBuscaproveedor.Name = "btnBuscaproveedor"
        Me.btnBuscaproveedor.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscaproveedor.TabIndex = 61
        Me.btnBuscaproveedor.UseVisualStyleBackColor = True
        '
        'cmbproveedor
        '
        Me.cmbproveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbproveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbproveedor.FormattingEnabled = True
        Me.cmbproveedor.Location = New System.Drawing.Point(161, 230)
        Me.cmbproveedor.Name = "cmbproveedor"
        Me.cmbproveedor.Size = New System.Drawing.Size(329, 21)
        Me.cmbproveedor.TabIndex = 12
        '
        'etiquetaid_proveedor
        '
        Me.etiquetaid_proveedor.AutoSize = True
        Me.etiquetaid_proveedor.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaid_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_proveedor.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_proveedor.Location = New System.Drawing.Point(28, 231)
        Me.etiquetaid_proveedor.Name = "etiquetaid_proveedor"
        Me.etiquetaid_proveedor.Size = New System.Drawing.Size(63, 15)
        Me.etiquetaid_proveedor.TabIndex = 510
        Me.etiquetaid_proveedor.Text = "Proveedor"
        Me.etiquetaid_proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkarchivado
        '
        Me.chkarchivado.AutoSize = True
        Me.chkarchivado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkarchivado.Location = New System.Drawing.Point(145, 367)
        Me.chkarchivado.Name = "chkarchivado"
        Me.chkarchivado.Size = New System.Drawing.Size(89, 21)
        Me.chkarchivado.TabIndex = 13
        Me.chkarchivado.Text = "archivado"
        Me.chkarchivado.Visible = False
        '
        'etiquetaarchivado
        '
        Me.etiquetaarchivado.AutoSize = True
        Me.etiquetaarchivado.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaarchivado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaarchivado.ForeColor = System.Drawing.Color.Black
        Me.etiquetaarchivado.Location = New System.Drawing.Point(12, 367)
        Me.etiquetaarchivado.Name = "etiquetaarchivado"
        Me.etiquetaarchivado.Size = New System.Drawing.Size(60, 15)
        Me.etiquetaarchivado.TabIndex = 511
        Me.etiquetaarchivado.Text = "Archivado"
        Me.etiquetaarchivado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.etiquetaarchivado.Visible = False
        '
        'lblid_tipo_egreso
        '
        Me.lblid_tipo_egreso.AutoSize = True
        Me.lblid_tipo_egreso.BackColor = System.Drawing.Color.Red
        Me.lblid_tipo_egreso.Location = New System.Drawing.Point(142, 280)
        Me.lblid_tipo_egreso.Name = "lblid_tipo_egreso"
        Me.lblid_tipo_egreso.Size = New System.Drawing.Size(13, 13)
        Me.lblid_tipo_egreso.TabIndex = 512
        Me.lblid_tipo_egreso.Text = "0"
        Me.lblid_tipo_egreso.Visible = False
        '
        'btnBuscatipo_egreso
        '
        Me.btnBuscatipo_egreso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscatipo_egreso.Image = CType(resources.GetObject("btnBuscatipo_egreso.Image"), System.Drawing.Image)
        Me.btnBuscatipo_egreso.Location = New System.Drawing.Point(505, 276)
        Me.btnBuscatipo_egreso.Name = "btnBuscatipo_egreso"
        Me.btnBuscatipo_egreso.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscatipo_egreso.TabIndex = 62
        Me.btnBuscatipo_egreso.UseVisualStyleBackColor = True
        '
        'cmbtipo_egreso
        '
        Me.cmbtipo_egreso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbtipo_egreso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbtipo_egreso.FormattingEnabled = True
        Me.cmbtipo_egreso.Location = New System.Drawing.Point(161, 276)
        Me.cmbtipo_egreso.Name = "cmbtipo_egreso"
        Me.cmbtipo_egreso.Size = New System.Drawing.Size(329, 21)
        Me.cmbtipo_egreso.TabIndex = 14
        '
        'etiquetaid_tipo_egreso
        '
        Me.etiquetaid_tipo_egreso.AutoSize = True
        Me.etiquetaid_tipo_egreso.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaid_tipo_egreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_tipo_egreso.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_tipo_egreso.Location = New System.Drawing.Point(28, 276)
        Me.etiquetaid_tipo_egreso.Name = "etiquetaid_tipo_egreso"
        Me.etiquetaid_tipo_egreso.Size = New System.Drawing.Size(72, 15)
        Me.etiquetaid_tipo_egreso.TabIndex = 513
        Me.etiquetaid_tipo_egreso.Text = "Tipo egreso"
        Me.etiquetaid_tipo_egreso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtiva
        '
        Me.txtiva.BackColor = System.Drawing.Color.White
        Me.txtiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtiva.ForeColor = System.Drawing.Color.Blue
        Me.txtiva.Location = New System.Drawing.Point(145, 367)
        Me.txtiva.MaxLength = 50
        Me.txtiva.Name = "txtiva"
        Me.txtiva.Size = New System.Drawing.Size(222, 31)
        Me.txtiva.TabIndex = 512
        Me.txtiva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtiva.Visible = False
        '
        'etiquetaiva
        '
        Me.etiquetaiva.AutoSize = True
        Me.etiquetaiva.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaiva.ForeColor = System.Drawing.Color.Black
        Me.etiquetaiva.Location = New System.Drawing.Point(12, 367)
        Me.etiquetaiva.Name = "etiquetaiva"
        Me.etiquetaiva.Size = New System.Drawing.Size(22, 15)
        Me.etiquetaiva.TabIndex = 513
        Me.etiquetaiva.Text = "Iva"
        Me.etiquetaiva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.etiquetaiva.Visible = False
        '
        'frmDetalleEgreso_efectivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 423)
        Me.Controls.Add(Me.etiquetaid_proveedor)
        Me.Controls.Add(Me.txtiva)
        Me.Controls.Add(Me.etiquetaid_tipo_egreso)
        Me.Controls.Add(Me.etiquetaiva)
        Me.Controls.Add(Me.cmbtipo_egreso)
        Me.Controls.Add(Me.lblid_empresa)
        Me.Controls.Add(Me.btnBuscatipo_egreso)
        Me.Controls.Add(Me.dtpfecha)
        Me.Controls.Add(Me.lblid_tipo_egreso)
        Me.Controls.Add(Me.etiquetafecha)
        Me.Controls.Add(Me.cmbproveedor)
        Me.Controls.Add(Me.btnBuscaproveedor)
        Me.Controls.Add(Me.txtcomprobante)
        Me.Controls.Add(Me.lblid_proveedor)
        Me.Controls.Add(Me.etiquetacomprobante)
        Me.Controls.Add(Me.txtimporte)
        Me.Controls.Add(Me.etiquetaimporte)
        Me.Controls.Add(Me.txtdetalle)
        Me.Controls.Add(Me.etiquetadetalle)
        Me.Controls.Add(Me.chkcontrol)
        Me.Controls.Add(Me.etiquetacontrol)
        Me.Controls.Add(Me.chka_rendir)
        Me.Controls.Add(Me.etiquetaa_rendir)
        Me.Controls.Add(Me.chkarchivado)
        Me.Controls.Add(Me.etiquetaarchivado)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDetalleEgreso_efectivo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetalleEgreso_efectivo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Protected WithEvents dtpfecha As System.Windows.Forms.DateTimePicker
   Friend WithEvents etiquetafecha As System.Windows.Forms.Label
   Protected WithEvents txtcomprobante As System.Windows.Forms.TextBox
   Friend WithEvents etiquetacomprobante As System.Windows.Forms.Label
   Protected WithEvents txtimporte As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaimporte As System.Windows.Forms.Label
    Protected WithEvents txtdetalle As System.Windows.Forms.TextBox
   Friend WithEvents etiquetadetalle As System.Windows.Forms.Label
   Friend WithEvents lblid_empresa As System.Windows.Forms.Label
    Protected WithEvents chkcontrol As System.Windows.Forms.CheckBox
   Friend WithEvents etiquetacontrol As System.Windows.Forms.Label
   Protected WithEvents chka_rendir As System.Windows.Forms.CheckBox
   Friend WithEvents etiquetaa_rendir As System.Windows.Forms.Label
   Friend WithEvents lblid_proveedor As System.Windows.Forms.Label
   Friend WithEvents btnBuscaproveedor As System.Windows.Forms.Button
   Friend WithEvents cmbproveedor As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_proveedor As System.Windows.Forms.Label
   Protected WithEvents chkarchivado As System.Windows.Forms.CheckBox
   Friend WithEvents etiquetaarchivado As System.Windows.Forms.Label
   Friend WithEvents lblid_tipo_egreso As System.Windows.Forms.Label
   Friend WithEvents btnBuscatipo_egreso As System.Windows.Forms.Button
   Friend WithEvents cmbtipo_egreso As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_tipo_egreso As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
    Protected WithEvents txtiva As System.Windows.Forms.TextBox
    Friend WithEvents etiquetaiva As System.Windows.Forms.Label
End Class

