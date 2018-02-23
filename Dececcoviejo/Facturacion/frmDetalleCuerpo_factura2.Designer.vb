<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleCuerpo_factura2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleCuerpo_factura2))
        Me.ttGuardar = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttSalir = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtPrecio_item = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCantidad_item = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rbnIva21 = New System.Windows.Forms.RadioButton()
        Me.rbnIvaNo21 = New System.Windows.Forms.RadioButton()
        Me.rbnIva10 = New System.Windows.Forms.RadioButton()
        Me.rbnIvaNo10 = New System.Windows.Forms.RadioButton()
        Me.lblid_factura = New System.Windows.Forms.Label()
        Me.ttItem = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNro_Item = New System.Windows.Forms.TextBox()
        Me.txtDescripcion_item = New System.Windows.Forms.TextBox()
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
        Me.btnSalir.Location = New System.Drawing.Point(440, 371)
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
        Me.btnGuardar.Location = New System.Drawing.Point(330, 371)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(78, 69)
        Me.btnGuardar.TabIndex = 20
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtPrecio_item
        '
        Me.txtPrecio_item.BackColor = System.Drawing.Color.White
        Me.txtPrecio_item.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrecio_item.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio_item.ForeColor = System.Drawing.Color.Blue
        Me.txtPrecio_item.Location = New System.Drawing.Point(110, 273)
        Me.txtPrecio_item.Name = "txtPrecio_item"
        Me.txtPrecio_item.Size = New System.Drawing.Size(185, 40)
        Me.txtPrecio_item.TabIndex = 8
        Me.txtPrecio_item.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(57, 272)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 16)
        Me.Label6.TabIndex = 602
        Me.Label6.Text = "Precio"
        '
        'txtCantidad_item
        '
        Me.txtCantidad_item.BackColor = System.Drawing.Color.White
        Me.txtCantidad_item.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCantidad_item.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad_item.ForeColor = System.Drawing.Color.Blue
        Me.txtCantidad_item.Location = New System.Drawing.Point(110, 213)
        Me.txtCantidad_item.Name = "txtCantidad_item"
        Me.txtCantidad_item.Size = New System.Drawing.Size(185, 40)
        Me.txtCantidad_item.TabIndex = 7
        Me.txtCantidad_item.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(42, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 16)
        Me.Label5.TabIndex = 601
        Me.Label5.Text = "Cantidad"
        '
        'rbnIva21
        '
        Me.rbnIva21.AutoSize = True
        Me.rbnIva21.Location = New System.Drawing.Point(368, 213)
        Me.rbnIva21.Name = "rbnIva21"
        Me.rbnIva21.Size = New System.Drawing.Size(127, 17)
        Me.rbnIva21.TabIndex = 23
        Me.rbnIva21.Text = "Precio CON IVA 21 %"
        Me.rbnIva21.UseVisualStyleBackColor = True
        Me.rbnIva21.Visible = False
        '
        'rbnIvaNo21
        '
        Me.rbnIvaNo21.AutoSize = True
        Me.rbnIvaNo21.Checked = True
        Me.rbnIvaNo21.Location = New System.Drawing.Point(368, 236)
        Me.rbnIvaNo21.Name = "rbnIvaNo21"
        Me.rbnIvaNo21.Size = New System.Drawing.Size(122, 17)
        Me.rbnIvaNo21.TabIndex = 24
        Me.rbnIvaNo21.TabStop = True
        Me.rbnIvaNo21.Text = "Precio SIN IVA 21 %"
        Me.rbnIvaNo21.UseVisualStyleBackColor = True
        Me.rbnIvaNo21.Visible = False
        '
        'rbnIva10
        '
        Me.rbnIva10.AutoSize = True
        Me.rbnIva10.Location = New System.Drawing.Point(368, 273)
        Me.rbnIva10.Name = "rbnIva10"
        Me.rbnIva10.Size = New System.Drawing.Size(136, 17)
        Me.rbnIva10.TabIndex = 607
        Me.rbnIva10.Text = "Precio CON IVA 10,5 %"
        Me.rbnIva10.UseVisualStyleBackColor = True
        Me.rbnIva10.Visible = False
        '
        'rbnIvaNo10
        '
        Me.rbnIvaNo10.AutoSize = True
        Me.rbnIvaNo10.Location = New System.Drawing.Point(368, 296)
        Me.rbnIvaNo10.Name = "rbnIvaNo10"
        Me.rbnIvaNo10.Size = New System.Drawing.Size(131, 17)
        Me.rbnIvaNo10.TabIndex = 608
        Me.rbnIvaNo10.Text = "Precio SIN IVA 10,5 %"
        Me.rbnIvaNo10.UseVisualStyleBackColor = True
        Me.rbnIvaNo10.Visible = False
        '
        'lblid_factura
        '
        Me.lblid_factura.AutoSize = True
        Me.lblid_factura.BackColor = System.Drawing.Color.Red
        Me.lblid_factura.Location = New System.Drawing.Point(440, 32)
        Me.lblid_factura.Name = "lblid_factura"
        Me.lblid_factura.Size = New System.Drawing.Size(13, 13)
        Me.lblid_factura.TabIndex = 611
        Me.lblid_factura.Text = "0"
        Me.lblid_factura.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(529, 336)
        Me.GroupBox1.TabIndex = 612
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(53, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 16)
        Me.Label1.TabIndex = 576
        Me.Label1.Text = "Detalle"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(71, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 16)
        Me.Label2.TabIndex = 613
        Me.Label2.Text = "Item"
        '
        'txtNro_Item
        '
        Me.txtNro_Item.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNro_Item.Location = New System.Drawing.Point(110, 48)
        Me.txtNro_Item.Name = "txtNro_Item"
        Me.txtNro_Item.Size = New System.Drawing.Size(92, 26)
        Me.txtNro_Item.TabIndex = 5
        '
        'txtDescripcion_item
        '
        Me.txtDescripcion_item.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion_item.Location = New System.Drawing.Point(110, 90)
        Me.txtDescripcion_item.Multiline = True
        Me.txtDescripcion_item.Name = "txtDescripcion_item"
        Me.txtDescripcion_item.Size = New System.Drawing.Size(371, 103)
        Me.txtDescripcion_item.TabIndex = 28
        '
        'frmDetalleCuerpo_factura2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 471)
        Me.Controls.Add(Me.txtDescripcion_item)
        Me.Controls.Add(Me.txtNro_Item)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblid_factura)
        Me.Controls.Add(Me.rbnIvaNo10)
        Me.Controls.Add(Me.rbnIva10)
        Me.Controls.Add(Me.rbnIvaNo21)
        Me.Controls.Add(Me.rbnIva21)
        Me.Controls.Add(Me.txtPrecio_item)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCantidad_item)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDetalleCuerpo_factura2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos de la Factura"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ttGuardar As System.Windows.Forms.ToolTip
    Friend WithEvents ttSalir As System.Windows.Forms.ToolTip
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents txtPrecio_item As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCantidad_item As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rbnIva21 As System.Windows.Forms.RadioButton
    Friend WithEvents rbnIvaNo21 As System.Windows.Forms.RadioButton
    Friend WithEvents rbnIva10 As System.Windows.Forms.RadioButton
    Friend WithEvents rbnIvaNo10 As System.Windows.Forms.RadioButton
    Friend WithEvents lblid_factura As System.Windows.Forms.Label
    Friend WithEvents ttItem As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNro_Item As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion_item As System.Windows.Forms.TextBox
End Class
