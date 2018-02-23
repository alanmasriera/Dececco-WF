<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleCuerpo_facturaexporta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleCuerpo_facturaexporta))
        Me.txtNro_Item = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblid_factura = New System.Windows.Forms.Label
        Me.rbnIvaNo10 = New System.Windows.Forms.RadioButton
        Me.rbnIva10 = New System.Windows.Forms.RadioButton
        Me.rbnIvaNo21 = New System.Windows.Forms.RadioButton
        Me.rbnIva21 = New System.Windows.Forms.RadioButton
        Me.txtPrecio_item = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCantidad_item = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblid_item = New System.Windows.Forms.Label
        Me.btnBuscaItem = New System.Windows.Forms.Button
        Me.cmbItem = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ttGuardar = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttSalir = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttItem = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'txtNro_Item
        '
        Me.txtNro_Item.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNro_Item.Location = New System.Drawing.Point(106, 72)
        Me.txtNro_Item.Name = "txtNro_Item"
        Me.txtNro_Item.Size = New System.Drawing.Size(92, 26)
        Me.txtNro_Item.TabIndex = 614
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(19, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 21)
        Me.Label2.TabIndex = 631
        Me.Label2.Text = "Item"
        '
        'lblid_factura
        '
        Me.lblid_factura.AutoSize = True
        Me.lblid_factura.BackColor = System.Drawing.Color.Red
        Me.lblid_factura.Location = New System.Drawing.Point(436, 56)
        Me.lblid_factura.Name = "lblid_factura"
        Me.lblid_factura.Size = New System.Drawing.Size(13, 13)
        Me.lblid_factura.TabIndex = 629
        Me.lblid_factura.Text = "0"
        Me.lblid_factura.Visible = False
        '
        'rbnIvaNo10
        '
        Me.rbnIvaNo10.AutoSize = True
        Me.rbnIvaNo10.Location = New System.Drawing.Point(367, 246)
        Me.rbnIvaNo10.Name = "rbnIvaNo10"
        Me.rbnIvaNo10.Size = New System.Drawing.Size(131, 17)
        Me.rbnIvaNo10.TabIndex = 628
        Me.rbnIvaNo10.Text = "Precio SIN IVA 10,5 %"
        Me.rbnIvaNo10.UseVisualStyleBackColor = True
        Me.rbnIvaNo10.Visible = False
        '
        'rbnIva10
        '
        Me.rbnIva10.AutoSize = True
        Me.rbnIva10.Location = New System.Drawing.Point(367, 223)
        Me.rbnIva10.Name = "rbnIva10"
        Me.rbnIva10.Size = New System.Drawing.Size(136, 17)
        Me.rbnIva10.TabIndex = 627
        Me.rbnIva10.Text = "Precio CON IVA 10,5 %"
        Me.rbnIva10.UseVisualStyleBackColor = True
        Me.rbnIva10.Visible = False
        '
        'rbnIvaNo21
        '
        Me.rbnIvaNo21.AutoSize = True
        Me.rbnIvaNo21.Checked = True
        Me.rbnIvaNo21.Location = New System.Drawing.Point(367, 186)
        Me.rbnIvaNo21.Name = "rbnIvaNo21"
        Me.rbnIvaNo21.Size = New System.Drawing.Size(122, 17)
        Me.rbnIvaNo21.TabIndex = 622
        Me.rbnIvaNo21.TabStop = True
        Me.rbnIvaNo21.Text = "Precio SIN IVA 21 %"
        Me.rbnIvaNo21.UseVisualStyleBackColor = True
        Me.rbnIvaNo21.Visible = False
        '
        'rbnIva21
        '
        Me.rbnIva21.AutoSize = True
        Me.rbnIva21.Location = New System.Drawing.Point(367, 163)
        Me.rbnIva21.Name = "rbnIva21"
        Me.rbnIva21.Size = New System.Drawing.Size(127, 17)
        Me.rbnIva21.TabIndex = 621
        Me.rbnIva21.Text = "Precio CON IVA 21 %"
        Me.rbnIva21.UseVisualStyleBackColor = True
        Me.rbnIva21.Visible = False
        '
        'txtPrecio_item
        '
        Me.txtPrecio_item.BackColor = System.Drawing.Color.White
        Me.txtPrecio_item.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrecio_item.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio_item.ForeColor = System.Drawing.Color.Blue
        Me.txtPrecio_item.Location = New System.Drawing.Point(106, 223)
        Me.txtPrecio_item.Name = "txtPrecio_item"
        Me.txtPrecio_item.Size = New System.Drawing.Size(185, 40)
        Me.txtPrecio_item.TabIndex = 617
        Me.txtPrecio_item.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(19, 222)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 21)
        Me.Label6.TabIndex = 626
        Me.Label6.Text = "Precio"
        '
        'txtCantidad_item
        '
        Me.txtCantidad_item.BackColor = System.Drawing.Color.White
        Me.txtCantidad_item.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCantidad_item.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad_item.ForeColor = System.Drawing.Color.Blue
        Me.txtCantidad_item.Location = New System.Drawing.Point(106, 163)
        Me.txtCantidad_item.Name = "txtCantidad_item"
        Me.txtCantidad_item.Size = New System.Drawing.Size(185, 40)
        Me.txtCantidad_item.TabIndex = 616
        Me.txtCantidad_item.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(19, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 21)
        Me.Label5.TabIndex = 625
        Me.Label5.Text = "Cantidad"
        '
        'lblid_item
        '
        Me.lblid_item.AutoSize = True
        Me.lblid_item.BackColor = System.Drawing.Color.Red
        Me.lblid_item.Location = New System.Drawing.Point(330, 119)
        Me.lblid_item.Name = "lblid_item"
        Me.lblid_item.Size = New System.Drawing.Size(13, 13)
        Me.lblid_item.TabIndex = 624
        Me.lblid_item.Text = "0"
        Me.lblid_item.Visible = False
        '
        'btnBuscaItem
        '
        Me.btnBuscaItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscaItem.Image = CType(resources.GetObject("btnBuscaItem.Image"), System.Drawing.Image)
        Me.btnBuscaItem.Location = New System.Drawing.Point(483, 114)
        Me.btnBuscaItem.Name = "btnBuscaItem"
        Me.btnBuscaItem.Size = New System.Drawing.Size(41, 36)
        Me.btnBuscaItem.TabIndex = 620
        Me.btnBuscaItem.UseVisualStyleBackColor = True
        '
        'cmbItem
        '
        Me.cmbItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbItem.FormattingEnabled = True
        Me.cmbItem.Location = New System.Drawing.Point(106, 116)
        Me.cmbItem.Name = "cmbItem"
        Me.cmbItem.Size = New System.Drawing.Size(356, 21)
        Me.cmbItem.TabIndex = 615
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(19, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 21)
        Me.Label1.TabIndex = 623
        Me.Label1.Text = "Detalle"
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(443, 296)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(81, 69)
        Me.btnSalir.TabIndex = 619
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
        Me.btnGuardar.Location = New System.Drawing.Point(333, 296)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(78, 69)
        Me.btnGuardar.TabIndex = 618
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(12, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(529, 254)
        Me.GroupBox1.TabIndex = 630
        Me.GroupBox1.TabStop = False
        '
        'frmDetalleCuerpo_facturaexporta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 377)
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
        Me.Controls.Add(Me.lblid_item)
        Me.Controls.Add(Me.btnBuscaItem)
        Me.Controls.Add(Me.cmbItem)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDetalleCuerpo_facturaexporta"
        Me.Text = "frmDetalleCuerpo_facturaexporta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNro_Item As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblid_factura As System.Windows.Forms.Label
    Friend WithEvents rbnIvaNo10 As System.Windows.Forms.RadioButton
    Friend WithEvents rbnIva10 As System.Windows.Forms.RadioButton
    Friend WithEvents rbnIvaNo21 As System.Windows.Forms.RadioButton
    Friend WithEvents rbnIva21 As System.Windows.Forms.RadioButton
    Friend WithEvents txtPrecio_item As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCantidad_item As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblid_item As System.Windows.Forms.Label
    Friend WithEvents btnBuscaItem As System.Windows.Forms.Button
    Friend WithEvents cmbItem As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ttGuardar As System.Windows.Forms.ToolTip
    Friend WithEvents ttSalir As System.Windows.Forms.ToolTip
    Friend WithEvents ttItem As System.Windows.Forms.ToolTip
End Class
