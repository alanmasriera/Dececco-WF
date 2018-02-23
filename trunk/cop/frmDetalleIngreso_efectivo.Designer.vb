<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleIngreso_efectivo
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
       Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleIngreso_efectivo))
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
       Me.txtiva = New System.Windows.Forms.TextBox
       Me.etiquetaiva = New System.Windows.Forms.Label
       Me.txtdetalle = New System.Windows.Forms.TextBox
       Me.etiquetadetalle = New System.Windows.Forms.Label
       Me.lblid_empresa = New System.Windows.Forms.Label
       Me.btnBuscaempresa = New System.Windows.Forms.Button
       Me.cmbempresa = New System.Windows.Forms.ComboBox
       Me.etiquetaid_empresa = New System.Windows.Forms.Label
       Me.chkcontrol = New System.Windows.Forms.CheckBox
       Me.etiquetacontrol = New System.Windows.Forms.Label
       Me.lblid_cliente = New System.Windows.Forms.Label
       Me.btnBuscacliente = New System.Windows.Forms.Button
       Me.cmbcliente = New System.Windows.Forms.ComboBox
       Me.etiquetaid_cliente = New System.Windows.Forms.Label
       Me.chkarchivado = New System.Windows.Forms.CheckBox
       Me.etiquetaarchivado = New System.Windows.Forms.Label
       Me.SuspendLayout()
       '
       'dtpfecha
       '
       Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
       Me.dtpfecha.Location = New System.Drawing.Point(161, 48)
       Me.dtpfecha.Name = "cmbfecha"
       Me.dtpfecha.Size = New System.Drawing.Size(93, 20)
       Me.dtpfecha.TabIndex = 4
       '
       'etiquietafecha
       '
       Me.etiquetafecha.BackColor = System.Drawing.Color.Transparent
       Me.etiquetafecha.AutoSize = True
       Me.etiquetafecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetafecha.ForeColor = System.Drawing.Color.Black
       Me.etiquetafecha.Location = New System.Drawing.Point(28, 48)
       Me.etiquetafecha.Name = "etiquetafecha"
       Me.etiquetafecha.Size = New System.Drawing.Size(127, 21)
       Me.etiquetafecha.TabIndex = 500
       Me.etiquetafecha.Text = "Fecha"
       Me.etiquetafecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtcomprobante
       '
       Me.txtcomprobante.BackColor = System.Drawing.Color.White
       Me.txtcomprobante.Location = New System.Drawing.Point(161, 91)
       Me.txtcomprobante.Size = New System.Drawing.Size(385, 20)
       Me.txtcomprobante.MaxLength = 50
       Me.txtcomprobante.Name = "txtcomprobante"
       Me.txtcomprobante.TabIndex = 5
       '
       'etiquietacomprobante
       '
       Me.etiquetacomprobante.BackColor = System.Drawing.Color.Transparent
       Me.etiquetacomprobante.AutoSize = True
       Me.etiquetacomprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetacomprobante.ForeColor = System.Drawing.Color.Black
       Me.etiquetacomprobante.Location = New System.Drawing.Point(28, 91)
       Me.etiquetacomprobante.Name = "etiquetacomprobante"
       Me.etiquetacomprobante.Size = New System.Drawing.Size(127, 21)
       Me.etiquetacomprobante.TabIndex = 501
       Me.etiquetacomprobante.Text = "Comprobante"
       Me.etiquetacomprobante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
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
       'etiquietaimporte
       '
       Me.etiquetaimporte.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaimporte.AutoSize = True
       Me.etiquetaimporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaimporte.ForeColor = System.Drawing.Color.Black
       Me.etiquetaimporte.Location = New System.Drawing.Point(28, 134)
       Me.etiquetaimporte.Name = "etiquetaimporte"
       Me.etiquetaimporte.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaimporte.TabIndex = 502
       Me.etiquetaimporte.Text = "Importe"
       Me.etiquetaimporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtiva
       '
       Me.txtiva.BackColor = System.Drawing.Color.White
       Me.txtiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtiva.ForeColor = System.Drawing.Color.Blue
       Me.txtiva.Location = New System.Drawing.Point(161, 187)
       Me.txtiva.MaxLength = 50
       Me.txtiva.Name = "txtiva"
       Me.txtiva.Size = New System.Drawing.Size(222, 31)
       Me.txtiva.TabIndex = 7
       Me.txtiva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietaiva
       '
       Me.etiquetaiva.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaiva.AutoSize = True
       Me.etiquetaiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaiva.ForeColor = System.Drawing.Color.Black
       Me.etiquetaiva.Location = New System.Drawing.Point(28, 187)
       Me.etiquetaiva.Name = "etiquetaiva"
       Me.etiquetaiva.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaiva.TabIndex = 503
       Me.etiquetaiva.Text = "Iva"
       Me.etiquetaiva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtdetalle
       '
       Me.txtdetalle.BackColor = System.Drawing.Color.White
       Me.txtdetalle.Location = New System.Drawing.Point(161, 240)
       Me.txtdetalle.Size = New System.Drawing.Size(385, 20)
       Me.txtdetalle.MaxLength = 50
       Me.txtdetalle.Name = "txtdetalle"
       Me.txtdetalle.TabIndex = 8
       '
       'etiquietadetalle
       '
       Me.etiquetadetalle.BackColor = System.Drawing.Color.Transparent
       Me.etiquetadetalle.AutoSize = True
       Me.etiquetadetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetadetalle.ForeColor = System.Drawing.Color.Black
       Me.etiquetadetalle.Location = New System.Drawing.Point(28, 240)
       Me.etiquetadetalle.Name = "etiquetadetalle"
       Me.etiquetadetalle.Size = New System.Drawing.Size(127, 21)
       Me.etiquetadetalle.TabIndex = 504
       Me.etiquetadetalle.Text = "Detalle"
       Me.etiquetadetalle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblid_empresa
       '
       Me.lblid_empresa.AutoSize = True
       Me.lblid_empresa.BackColor = System.Drawing.Color.Red
       Me.lblid_empresa.Location = New System.Drawing.Point(370, 283)
       Me.lblid_empresa.Name = "lblid_empresa"
       Me.lblid_empresa.Size = New System.Drawing.Size(13, 13)
       Me.lblid_empresa.TabIndex = 505
       Me.lblid_empresa.Text = "0"
       Me.lblid_empresa.Visible = False
       '
       'btnBuscaempresa
       '
       Me.btnBuscaempresa.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscaempresa.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscaempresa.Location = New System.Drawing.Point(505, 283)
       Me.btnBuscaempresa.Name = "btnBuscaempresa"
       Me.btnBuscaempresa.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscaempresa.TabIndex = 60
       Me.btnBuscaempresa.UseVisualStyleBackColor = True
       '
       'cmbempresa
       '
       Me.cmbempresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbempresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbempresa.FormattingEnabled = True
       Me.cmbempresa.Location = New System.Drawing.Point(161, 283)
       Me.cmbempresa.Size = New System.Drawing.Size(329, 21)
       Me.cmbempresa.Name = "cmbempresa"
       Me.cmbempresa.TabIndex = 9
       '
       'etiquietaid_empresa
       '
       Me.etiquetaid_empresa.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_empresa.AutoSize = True
       Me.etiquetaid_empresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_empresa.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_empresa.Location = New System.Drawing.Point(28, 283)
       Me.etiquetaid_empresa.Name = "etiquetaid_empresa"
       Me.etiquetaid_empresa.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_empresa.TabIndex = 506
       Me.etiquetaid_empresa.Text = "Empresa"
       Me.etiquetaid_empresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'chkcontrol
       '
       Me.chkcontrol.AutoSize = True
       Me.chkcontrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.chkcontrol.Location = New System.Drawing.Point(161, 326)
       Me.chkcontrol.Name = "etiquetacontrol"
       Me.chkcontrol.Size = New System.Drawing.Size(15, 14)
       Me.chkcontrol.TabIndex = 10
       Me.chkcontrol.Text = "control"
       Me.chkcontrol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       'etiquietacontrol
       '
       Me.etiquetacontrol.BackColor = System.Drawing.Color.Transparent
       Me.etiquetacontrol.AutoSize = True
       Me.etiquetacontrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetacontrol.ForeColor = System.Drawing.Color.Black
       Me.etiquetacontrol.Location = New System.Drawing.Point(28, 326)
       Me.etiquetacontrol.Name = "etiquetacontrol"
       Me.etiquetacontrol.Size = New System.Drawing.Size(127, 21)
       Me.etiquetacontrol.TabIndex = 507
       Me.etiquetacontrol.Text = "Control"
       Me.etiquetacontrol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblid_cliente
       '
       Me.lblid_cliente.AutoSize = True
       Me.lblid_cliente.BackColor = System.Drawing.Color.Red
       Me.lblid_cliente.Location = New System.Drawing.Point(370, 369)
       Me.lblid_cliente.Name = "lblid_cliente"
       Me.lblid_cliente.Size = New System.Drawing.Size(13, 13)
       Me.lblid_cliente.TabIndex = 508
       Me.lblid_cliente.Text = "0"
       Me.lblid_cliente.Visible = False
       '
       'btnBuscacliente
       '
       Me.btnBuscacliente.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscacliente.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscacliente.Location = New System.Drawing.Point(505, 369)
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
       Me.cmbcliente.Location = New System.Drawing.Point(161, 369)
       Me.cmbcliente.Size = New System.Drawing.Size(329, 21)
       Me.cmbcliente.Name = "cmbcliente"
       Me.cmbcliente.TabIndex = 11
       '
       'etiquietaid_cliente
       '
       Me.etiquetaid_cliente.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_cliente.AutoSize = True
       Me.etiquetaid_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_cliente.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_cliente.Location = New System.Drawing.Point(28, 369)
       Me.etiquetaid_cliente.Name = "etiquetaid_cliente"
       Me.etiquetaid_cliente.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_cliente.TabIndex = 509
       Me.etiquetaid_cliente.Text = "Cliente"
       Me.etiquetaid_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'chkarchivado
       '
       Me.chkarchivado.AutoSize = True
       Me.chkarchivado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.chkarchivado.Location = New System.Drawing.Point(161, 412)
       Me.chkarchivado.Name = "etiquetaarchivado"
       Me.chkarchivado.Size = New System.Drawing.Size(15, 14)
       Me.chkarchivado.TabIndex = 12
       Me.chkarchivado.Text = "archivado"
       Me.chkarchivado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       'etiquietaarchivado
       '
       Me.etiquetaarchivado.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaarchivado.AutoSize = True
       Me.etiquetaarchivado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaarchivado.ForeColor = System.Drawing.Color.Black
       Me.etiquetaarchivado.Location = New System.Drawing.Point(28, 412)
       Me.etiquetaarchivado.Name = "etiquetaarchivado"
       Me.etiquetaarchivado.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaarchivado.TabIndex = 510
       Me.etiquetaarchivado.Text = "Archivado"
       Me.etiquetaarchivado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
       Me.btnSalir.Location = New System.Drawing.Point(499, 495)
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
       Me.btnGuardar.Location = New System.Drawing.Point(392,495)
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
       Me.GroupBox1.Size = New System.Drawing.Size(568, 455)
       Me.GroupBox1.TabIndex = 0
       Me.GroupBox1.TabStop = False
       '
       'frmDetalleIngreso_efectivo
       '
       Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
       Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
       Me.ClientSize = New System.Drawing.Size(600, 575)
       Me.Controls.Add(Me.dtpfecha)
       Me.Controls.Add(Me.etiquetafecha)
       Me.Controls.Add(Me.txtcomprobante)
       Me.Controls.Add(Me.etiquetacomprobante)
       Me.Controls.Add(Me.txtimporte)
       Me.Controls.Add(Me.etiquetaimporte)
       Me.Controls.Add(Me.txtiva)
       Me.Controls.Add(Me.etiquetaiva)
       Me.Controls.Add(Me.txtdetalle)
       Me.Controls.Add(Me.etiquetadetalle)
       Me.Controls.Add(Me.lblid_empresa)
       Me.Controls.Add(Me.btnBuscaempresa)
       Me.Controls.Add(Me.cmbempresa)
       Me.Controls.Add(Me.etiquetaid_empresa)
       Me.Controls.Add(Me.chkcontrol)
       Me.Controls.Add(Me.etiquetacontrol)
       Me.Controls.Add(Me.lblid_cliente)
       Me.Controls.Add(Me.btnBuscacliente)
       Me.Controls.Add(Me.cmbcliente)
       Me.Controls.Add(Me.etiquetaid_cliente)
       Me.Controls.Add(Me.chkarchivado)
       Me.Controls.Add(Me.etiquetaarchivado)
       Me.Controls.Add(Me.btnSalir)
       Me.Controls.Add(Me.btnGuardar)
       Me.Controls.Add(Me.GroupBox1)
       Me.Name = "frmDetalleIngreso_efectivo"
       Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
       Me.Text = "frmDetalleIngreso_efectivo" & vgNombreFormulario
       Me.ResumeLayout(False)
       Me.PerformLayout()

   End Sub
   Protected WithEvents dtpfecha As System.Windows.Forms.DateTimePicker
   Friend WithEvents etiquetafecha As System.Windows.Forms.Label
   Protected WithEvents txtcomprobante As System.Windows.Forms.TextBox
   Friend WithEvents etiquetacomprobante As System.Windows.Forms.Label
   Protected WithEvents txtimporte As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaimporte As System.Windows.Forms.Label
   Protected WithEvents txtiva As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaiva As System.Windows.Forms.Label
   Protected WithEvents txtdetalle As System.Windows.Forms.TextBox
   Friend WithEvents etiquetadetalle As System.Windows.Forms.Label
   Friend WithEvents lblid_empresa As System.Windows.Forms.Label
   Friend WithEvents btnBuscaempresa As System.Windows.Forms.Button
   Friend WithEvents cmbempresa As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_empresa As System.Windows.Forms.Label
   Protected WithEvents chkcontrol As System.Windows.Forms.CheckBox
   Friend WithEvents etiquetacontrol As System.Windows.Forms.Label
   Friend WithEvents lblid_cliente As System.Windows.Forms.Label
   Friend WithEvents btnBuscacliente As System.Windows.Forms.Button
   Friend WithEvents cmbcliente As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_cliente As System.Windows.Forms.Label
   Protected WithEvents chkarchivado As System.Windows.Forms.CheckBox
   Friend WithEvents etiquetaarchivado As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
End Class

