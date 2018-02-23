<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleCuerpo_orden_compra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleCuerpo_orden_compra))
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblid_item = New System.Windows.Forms.Label
        Me.btnBuscaitem = New System.Windows.Forms.Button
        Me.cmbitem = New System.Windows.Forms.ComboBox
        Me.etiquetaid_item = New System.Windows.Forms.Label
        Me.txtcantidad = New System.Windows.Forms.TextBox
        Me.etiquetacantidad = New System.Windows.Forms.Label
        Me.txtprecio_unitario = New System.Windows.Forms.TextBox
        Me.etiquetaprecio_unitario = New System.Windows.Forms.Label
        Me.lblid_usuario = New System.Windows.Forms.Label
        Me.lblid_orden_compra = New System.Windows.Forms.Label
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
        Me.btnSalir.Location = New System.Drawing.Point(499, 323)
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
        Me.btnGuardar.Location = New System.Drawing.Point(392, 323)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(78, 69)
        Me.btnGuardar.TabIndex = 20
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblid_usuario)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(568, 283)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lblid_item
        '
        Me.lblid_item.AutoSize = True
        Me.lblid_item.BackColor = System.Drawing.Color.Red
        Me.lblid_item.Location = New System.Drawing.Point(370, 91)
        Me.lblid_item.Name = "lblid_item"
        Me.lblid_item.Size = New System.Drawing.Size(13, 13)
        Me.lblid_item.TabIndex = 502
        Me.lblid_item.Text = "0"
        Me.lblid_item.Visible = False
        '
        'btnBuscaitem
        '
        Me.btnBuscaitem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscaitem.Image = CType(resources.GetObject("btnBuscaitem.Image"), System.Drawing.Image)
        Me.btnBuscaitem.Location = New System.Drawing.Point(505, 91)
        Me.btnBuscaitem.Name = "btnBuscaitem"
        Me.btnBuscaitem.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscaitem.TabIndex = 31
        Me.btnBuscaitem.UseVisualStyleBackColor = True
        '
        'cmbitem
        '
        Me.cmbitem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbitem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbitem.FormattingEnabled = True
        Me.cmbitem.Location = New System.Drawing.Point(161, 91)
        Me.cmbitem.Name = "cmbitem"
        Me.cmbitem.Size = New System.Drawing.Size(329, 21)
        Me.cmbitem.TabIndex = 5
        '
        'etiquetaid_item
        '
        Me.etiquetaid_item.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_item.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_item.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_item.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_item.Location = New System.Drawing.Point(28, 91)
        Me.etiquetaid_item.Name = "etiquetaid_item"
        Me.etiquetaid_item.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_item.TabIndex = 503
        Me.etiquetaid_item.Text = "Item"
        Me.etiquetaid_item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcantidad
        '
        Me.txtcantidad.BackColor = System.Drawing.Color.White
        Me.txtcantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantidad.ForeColor = System.Drawing.Color.Blue
        Me.txtcantidad.Location = New System.Drawing.Point(161, 134)
        Me.txtcantidad.MaxLength = 50
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(222, 31)
        Me.txtcantidad.TabIndex = 6
        Me.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetacantidad
        '
        Me.etiquetacantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetacantidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetacantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetacantidad.ForeColor = System.Drawing.Color.Black
        Me.etiquetacantidad.Location = New System.Drawing.Point(28, 134)
        Me.etiquetacantidad.Name = "etiquetacantidad"
        Me.etiquetacantidad.Size = New System.Drawing.Size(127, 21)
        Me.etiquetacantidad.TabIndex = 504
        Me.etiquetacantidad.Text = "Cantidad"
        Me.etiquetacantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtprecio_unitario
        '
        Me.txtprecio_unitario.BackColor = System.Drawing.Color.White
        Me.txtprecio_unitario.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprecio_unitario.ForeColor = System.Drawing.Color.Blue
        Me.txtprecio_unitario.Location = New System.Drawing.Point(161, 187)
        Me.txtprecio_unitario.MaxLength = 50
        Me.txtprecio_unitario.Name = "txtprecio_unitario"
        Me.txtprecio_unitario.Size = New System.Drawing.Size(222, 31)
        Me.txtprecio_unitario.TabIndex = 7
        Me.txtprecio_unitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetaprecio_unitario
        '
        Me.etiquetaprecio_unitario.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaprecio_unitario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaprecio_unitario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaprecio_unitario.ForeColor = System.Drawing.Color.Black
        Me.etiquetaprecio_unitario.Location = New System.Drawing.Point(28, 187)
        Me.etiquetaprecio_unitario.Name = "etiquetaprecio_unitario"
        Me.etiquetaprecio_unitario.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaprecio_unitario.TabIndex = 505
        Me.etiquetaprecio_unitario.Text = "Precio_unitario"
        Me.etiquetaprecio_unitario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_usuario
        '
        Me.lblid_usuario.AutoSize = True
        Me.lblid_usuario.BackColor = System.Drawing.Color.Red
        Me.lblid_usuario.Location = New System.Drawing.Point(377, 207)
        Me.lblid_usuario.Name = "lblid_usuario"
        Me.lblid_usuario.Size = New System.Drawing.Size(13, 13)
        Me.lblid_usuario.TabIndex = 506
        Me.lblid_usuario.Text = "0"
        Me.lblid_usuario.Visible = False
        '
        'lblid_orden_compra
        '
        Me.lblid_orden_compra.AutoSize = True
        Me.lblid_orden_compra.BackColor = System.Drawing.Color.Red
        Me.lblid_orden_compra.Location = New System.Drawing.Point(370, 9)
        Me.lblid_orden_compra.Name = "lblid_orden_compra"
        Me.lblid_orden_compra.Size = New System.Drawing.Size(13, 13)
        Me.lblid_orden_compra.TabIndex = 500
        Me.lblid_orden_compra.Text = "0"
        Me.lblid_orden_compra.Visible = False
        '
        'frmDetalleCuerpo_orden_compra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 403)
        Me.Controls.Add(Me.lblid_orden_compra)
        Me.Controls.Add(Me.lblid_item)
        Me.Controls.Add(Me.btnBuscaitem)
        Me.Controls.Add(Me.cmbitem)
        Me.Controls.Add(Me.etiquetaid_item)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.etiquetacantidad)
        Me.Controls.Add(Me.txtprecio_unitario)
        Me.Controls.Add(Me.etiquetaprecio_unitario)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDetalleCuerpo_orden_compra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetalleCuerpo_orden_compra"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblid_item As System.Windows.Forms.Label
   Friend WithEvents btnBuscaitem As System.Windows.Forms.Button
   Friend WithEvents cmbitem As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_item As System.Windows.Forms.Label
   Protected WithEvents txtcantidad As System.Windows.Forms.TextBox
   Friend WithEvents etiquetacantidad As System.Windows.Forms.Label
   Protected WithEvents txtprecio_unitario As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaprecio_unitario As System.Windows.Forms.Label
   Friend WithEvents lblid_usuario As System.Windows.Forms.Label
    Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
    Friend WithEvents lblid_orden_compra As System.Windows.Forms.Label
End Class

