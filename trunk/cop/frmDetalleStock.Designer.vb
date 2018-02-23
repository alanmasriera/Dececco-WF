<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleStock
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
       Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleStock))
       Me.btnSalir = New System.Windows.Forms.Button
       Me.btnGuardar = New System.Windows.Forms.Button
       Me.GroupBox1 = New System.Windows.Forms.GroupBox
       Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
       Me.lblid_producto = New System.Windows.Forms.Label
       Me.btnBuscaproducto = New System.Windows.Forms.Button
       Me.cmbproducto = New System.Windows.Forms.ComboBox
       Me.etiquetaid_producto = New System.Windows.Forms.Label
       Me.lblid_almacen = New System.Windows.Forms.Label
       Me.btnBuscaalmacen = New System.Windows.Forms.Button
       Me.cmbalmacen = New System.Windows.Forms.ComboBox
       Me.etiquetaid_almacen = New System.Windows.Forms.Label
       Me.txtstock = New System.Windows.Forms.TextBox
       Me.etiquetastock = New System.Windows.Forms.Label
       Me.chkactualizado = New System.Windows.Forms.CheckBox
       Me.etiquetaactualizado = New System.Windows.Forms.Label
       Me.txtstock_oferta = New System.Windows.Forms.TextBox
       Me.etiquetastock_oferta = New System.Windows.Forms.Label
       Me.SuspendLayout()
       '
       'lblid_producto
       '
       Me.lblid_producto.AutoSize = True
       Me.lblid_producto.BackColor = System.Drawing.Color.Red
       Me.lblid_producto.Location = New System.Drawing.Point(370, 48)
       Me.lblid_producto.Name = "lblid_producto"
       Me.lblid_producto.Size = New System.Drawing.Size(13, 13)
       Me.lblid_producto.TabIndex = 500
       Me.lblid_producto.Text = "0"
       Me.lblid_producto.Visible = False
       '
       'btnBuscaproducto
       '
       Me.btnBuscaproducto.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscaproducto.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscaproducto.Location = New System.Drawing.Point(505, 48)
       Me.btnBuscaproducto.Name = "btnBuscaproducto"
       Me.btnBuscaproducto.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscaproducto.TabIndex = 60
       Me.btnBuscaproducto.UseVisualStyleBackColor = True
       '
       'cmbproducto
       '
       Me.cmbproducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbproducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbproducto.FormattingEnabled = True
       Me.cmbproducto.Location = New System.Drawing.Point(161, 48)
       Me.cmbproducto.Size = New System.Drawing.Size(329, 21)
       Me.cmbproducto.Name = "cmbproducto"
       Me.cmbproducto.TabIndex = 4
       '
       'etiquietaid_producto
       '
       Me.etiquetaid_producto.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_producto.AutoSize = True
       Me.etiquetaid_producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_producto.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_producto.Location = New System.Drawing.Point(28, 48)
       Me.etiquetaid_producto.Name = "etiquetaid_producto"
       Me.etiquetaid_producto.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_producto.TabIndex = 501
       Me.etiquetaid_producto.Text = "Producto"
       Me.etiquetaid_producto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblid_almacen
       '
       Me.lblid_almacen.AutoSize = True
       Me.lblid_almacen.BackColor = System.Drawing.Color.Red
       Me.lblid_almacen.Location = New System.Drawing.Point(370, 91)
       Me.lblid_almacen.Name = "lblid_almacen"
       Me.lblid_almacen.Size = New System.Drawing.Size(13, 13)
       Me.lblid_almacen.TabIndex = 502
       Me.lblid_almacen.Text = "0"
       Me.lblid_almacen.Visible = False
       '
       'btnBuscaalmacen
       '
       Me.btnBuscaalmacen.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscaalmacen.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscaalmacen.Location = New System.Drawing.Point(505, 91)
       Me.btnBuscaalmacen.Name = "btnBuscaalmacen"
       Me.btnBuscaalmacen.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscaalmacen.TabIndex = 61
       Me.btnBuscaalmacen.UseVisualStyleBackColor = True
       '
       'cmbalmacen
       '
       Me.cmbalmacen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbalmacen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbalmacen.FormattingEnabled = True
       Me.cmbalmacen.Location = New System.Drawing.Point(161, 91)
       Me.cmbalmacen.Size = New System.Drawing.Size(329, 21)
       Me.cmbalmacen.Name = "cmbalmacen"
       Me.cmbalmacen.TabIndex = 5
       '
       'etiquietaid_almacen
       '
       Me.etiquetaid_almacen.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_almacen.AutoSize = True
       Me.etiquetaid_almacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_almacen.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_almacen.Location = New System.Drawing.Point(28, 91)
       Me.etiquetaid_almacen.Name = "etiquetaid_almacen"
       Me.etiquetaid_almacen.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_almacen.TabIndex = 503
       Me.etiquetaid_almacen.Text = "Almacen"
       Me.etiquetaid_almacen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtstock
       '
       Me.txtstock.BackColor = System.Drawing.Color.White
       Me.txtstock.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtstock.ForeColor = System.Drawing.Color.Blue
       Me.txtstock.Location = New System.Drawing.Point(161, 134)
       Me.txtstock.MaxLength = 50
       Me.txtstock.Name = "txtstock"
       Me.txtstock.Size = New System.Drawing.Size(222, 31)
       Me.txtstock.TabIndex = 6
       Me.txtstock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietastock
       '
       Me.etiquetastock.BackColor = System.Drawing.Color.Transparent
       Me.etiquetastock.AutoSize = True
       Me.etiquetastock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetastock.ForeColor = System.Drawing.Color.Black
       Me.etiquetastock.Location = New System.Drawing.Point(28, 134)
       Me.etiquetastock.Name = "etiquetastock"
       Me.etiquetastock.Size = New System.Drawing.Size(127, 21)
       Me.etiquetastock.TabIndex = 504
       Me.etiquetastock.Text = "Stock"
       Me.etiquetastock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'chkactualizado
       '
       Me.chkactualizado.AutoSize = True
       Me.chkactualizado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.chkactualizado.Location = New System.Drawing.Point(161, 187)
       Me.chkactualizado.Name = "etiquetaactualizado"
       Me.chkactualizado.Size = New System.Drawing.Size(15, 14)
       Me.chkactualizado.TabIndex = 7
       Me.chkactualizado.Text = "actualizado"
       Me.chkactualizado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       'etiquietaactualizado
       '
       Me.etiquetaactualizado.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaactualizado.AutoSize = True
       Me.etiquetaactualizado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaactualizado.ForeColor = System.Drawing.Color.Black
       Me.etiquetaactualizado.Location = New System.Drawing.Point(28, 187)
       Me.etiquetaactualizado.Name = "etiquetaactualizado"
       Me.etiquetaactualizado.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaactualizado.TabIndex = 505
       Me.etiquetaactualizado.Text = "Actualizado"
       Me.etiquetaactualizado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtstock_oferta
       '
       Me.txtstock_oferta.BackColor = System.Drawing.Color.White
       Me.txtstock_oferta.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtstock_oferta.ForeColor = System.Drawing.Color.Blue
       Me.txtstock_oferta.Location = New System.Drawing.Point(161, 230)
       Me.txtstock_oferta.MaxLength = 50
       Me.txtstock_oferta.Name = "txtstock_oferta"
       Me.txtstock_oferta.Size = New System.Drawing.Size(222, 31)
       Me.txtstock_oferta.TabIndex = 8
       Me.txtstock_oferta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietastock_oferta
       '
       Me.etiquetastock_oferta.BackColor = System.Drawing.Color.Transparent
       Me.etiquetastock_oferta.AutoSize = True
       Me.etiquetastock_oferta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetastock_oferta.ForeColor = System.Drawing.Color.Black
       Me.etiquetastock_oferta.Location = New System.Drawing.Point(28, 230)
       Me.etiquetastock_oferta.Name = "etiquetastock_oferta"
       Me.etiquetastock_oferta.Size = New System.Drawing.Size(127, 21)
       Me.etiquetastock_oferta.TabIndex = 506
       Me.etiquetastock_oferta.Text = "Stock oferta"
       Me.etiquetastock_oferta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
       Me.btnSalir.Location = New System.Drawing.Point(499, 323)
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
       Me.btnGuardar.Location = New System.Drawing.Point(392,323)
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
       Me.GroupBox1.Size = New System.Drawing.Size(568, 283)
       Me.GroupBox1.TabIndex = 0
       Me.GroupBox1.TabStop = False
       '
       'frmDetalleStock
       '
       Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
       Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
       Me.ClientSize = New System.Drawing.Size(600, 403)
       Me.Controls.Add(Me.lblid_producto)
       Me.Controls.Add(Me.btnBuscaproducto)
       Me.Controls.Add(Me.cmbproducto)
       Me.Controls.Add(Me.etiquetaid_producto)
       Me.Controls.Add(Me.lblid_almacen)
       Me.Controls.Add(Me.btnBuscaalmacen)
       Me.Controls.Add(Me.cmbalmacen)
       Me.Controls.Add(Me.etiquetaid_almacen)
       Me.Controls.Add(Me.txtstock)
       Me.Controls.Add(Me.etiquetastock)
       Me.Controls.Add(Me.chkactualizado)
       Me.Controls.Add(Me.etiquetaactualizado)
       Me.Controls.Add(Me.txtstock_oferta)
       Me.Controls.Add(Me.etiquetastock_oferta)
       Me.Controls.Add(Me.btnSalir)
       Me.Controls.Add(Me.btnGuardar)
       Me.Controls.Add(Me.GroupBox1)
       Me.Name = "frmDetalleStock"
       Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
       Me.Text = "frmDetalleStock" & vgNombreFormulario
       Me.ResumeLayout(False)
       Me.PerformLayout()

   End Sub
   Friend WithEvents lblid_producto As System.Windows.Forms.Label
   Friend WithEvents btnBuscaproducto As System.Windows.Forms.Button
   Friend WithEvents cmbproducto As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_producto As System.Windows.Forms.Label
   Friend WithEvents lblid_almacen As System.Windows.Forms.Label
   Friend WithEvents btnBuscaalmacen As System.Windows.Forms.Button
   Friend WithEvents cmbalmacen As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_almacen As System.Windows.Forms.Label
   Protected WithEvents txtstock As System.Windows.Forms.TextBox
   Friend WithEvents etiquetastock As System.Windows.Forms.Label
   Protected WithEvents chkactualizado As System.Windows.Forms.CheckBox
   Friend WithEvents etiquetaactualizado As System.Windows.Forms.Label
   Protected WithEvents txtstock_oferta As System.Windows.Forms.TextBox
   Friend WithEvents etiquetastock_oferta As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
End Class

