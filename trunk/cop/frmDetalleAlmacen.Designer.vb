<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleAlmacen
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
       Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleAlmacen))
       Me.btnSalir = New System.Windows.Forms.Button
       Me.btnGuardar = New System.Windows.Forms.Button
       Me.GroupBox1 = New System.Windows.Forms.GroupBox
       Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
       Me.txtnombre_almacen = New System.Windows.Forms.TextBox
       Me.etiquetanombre_almacen = New System.Windows.Forms.Label
       Me.chktilde = New System.Windows.Forms.CheckBox
       Me.etiquetatilde = New System.Windows.Forms.Label
       Me.lblid_cliente = New System.Windows.Forms.Label
       Me.btnBuscacliente = New System.Windows.Forms.Button
       Me.cmbcliente = New System.Windows.Forms.ComboBox
       Me.etiquetaid_cliente = New System.Windows.Forms.Label
       Me.SuspendLayout()
       '
       'txtnombre_almacen
       '
       Me.txtnombre_almacen.BackColor = System.Drawing.Color.White
       Me.txtnombre_almacen.Location = New System.Drawing.Point(161, 48)
       Me.txtnombre_almacen.Size = New System.Drawing.Size(385, 20)
       Me.txtnombre_almacen.MaxLength = 50
       Me.txtnombre_almacen.Name = "txtnombre_almacen"
       Me.txtnombre_almacen.TabIndex = 4
       '
       'etiquietanombre_almacen
       '
       Me.etiquetanombre_almacen.BackColor = System.Drawing.Color.Transparent
       Me.etiquetanombre_almacen.AutoSize = True
       Me.etiquetanombre_almacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetanombre_almacen.ForeColor = System.Drawing.Color.Black
       Me.etiquetanombre_almacen.Location = New System.Drawing.Point(28, 48)
       Me.etiquetanombre_almacen.Name = "etiquetanombre_almacen"
       Me.etiquetanombre_almacen.Size = New System.Drawing.Size(127, 21)
       Me.etiquetanombre_almacen.TabIndex = 500
       Me.etiquetanombre_almacen.Text = "Nombre almacen"
       Me.etiquetanombre_almacen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'chktilde
       '
       Me.chktilde.AutoSize = True
       Me.chktilde.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.chktilde.Location = New System.Drawing.Point(161, 91)
       Me.chktilde.Name = "etiquetatilde"
       Me.chktilde.Size = New System.Drawing.Size(15, 14)
       Me.chktilde.TabIndex = 5
       Me.chktilde.Text = "tilde"
       Me.chktilde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       'etiquietatilde
       '
       Me.etiquetatilde.BackColor = System.Drawing.Color.Transparent
       Me.etiquetatilde.AutoSize = True
       Me.etiquetatilde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetatilde.ForeColor = System.Drawing.Color.Black
       Me.etiquetatilde.Location = New System.Drawing.Point(28, 91)
       Me.etiquetatilde.Name = "etiquetatilde"
       Me.etiquetatilde.Size = New System.Drawing.Size(127, 21)
       Me.etiquetatilde.TabIndex = 501
       Me.etiquetatilde.Text = "Tilde"
       Me.etiquetatilde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblid_cliente
       '
       Me.lblid_cliente.AutoSize = True
       Me.lblid_cliente.BackColor = System.Drawing.Color.Red
       Me.lblid_cliente.Location = New System.Drawing.Point(370, 134)
       Me.lblid_cliente.Name = "lblid_cliente"
       Me.lblid_cliente.Size = New System.Drawing.Size(13, 13)
       Me.lblid_cliente.TabIndex = 502
       Me.lblid_cliente.Text = "0"
       Me.lblid_cliente.Visible = False
       '
       'btnBuscacliente
       '
       Me.btnBuscacliente.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscacliente.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscacliente.Location = New System.Drawing.Point(505, 134)
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
       Me.cmbcliente.Location = New System.Drawing.Point(161, 134)
       Me.cmbcliente.Size = New System.Drawing.Size(329, 21)
       Me.cmbcliente.Name = "cmbcliente"
       Me.cmbcliente.TabIndex = 6
       '
       'etiquietaid_cliente
       '
       Me.etiquetaid_cliente.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_cliente.AutoSize = True
       Me.etiquetaid_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_cliente.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_cliente.Location = New System.Drawing.Point(28, 134)
       Me.etiquetaid_cliente.Name = "etiquetaid_cliente"
       Me.etiquetaid_cliente.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_cliente.TabIndex = 503
       Me.etiquetaid_cliente.Text = "Cliente"
       Me.etiquetaid_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
       Me.btnSalir.Location = New System.Drawing.Point(499, 217)
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
       Me.btnGuardar.Location = New System.Drawing.Point(392,217)
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
       Me.GroupBox1.Size = New System.Drawing.Size(568, 177)
       Me.GroupBox1.TabIndex = 0
       Me.GroupBox1.TabStop = False
       '
       'frmDetalleAlmacen
       '
       Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
       Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
       Me.ClientSize = New System.Drawing.Size(600, 297)
       Me.Controls.Add(Me.txtnombre_almacen)
       Me.Controls.Add(Me.etiquetanombre_almacen)
       Me.Controls.Add(Me.chktilde)
       Me.Controls.Add(Me.etiquetatilde)
       Me.Controls.Add(Me.lblid_cliente)
       Me.Controls.Add(Me.btnBuscacliente)
       Me.Controls.Add(Me.cmbcliente)
       Me.Controls.Add(Me.etiquetaid_cliente)
       Me.Controls.Add(Me.btnSalir)
       Me.Controls.Add(Me.btnGuardar)
       Me.Controls.Add(Me.GroupBox1)
       Me.Name = "frmDetalleAlmacen"
       Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
       Me.Text = "frmDetalleAlmacen" & vgNombreFormulario
       Me.ResumeLayout(False)
       Me.PerformLayout()

   End Sub
   Protected WithEvents txtnombre_almacen As System.Windows.Forms.TextBox
   Friend WithEvents etiquetanombre_almacen As System.Windows.Forms.Label
   Protected WithEvents chktilde As System.Windows.Forms.CheckBox
   Friend WithEvents etiquetatilde As System.Windows.Forms.Label
   Friend WithEvents lblid_cliente As System.Windows.Forms.Label
   Friend WithEvents btnBuscacliente As System.Windows.Forms.Button
   Friend WithEvents cmbcliente As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_cliente As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
End Class

