<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleRemito_factura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleRemito_factura))
        Me.lblid_cliente = New System.Windows.Forms.Label
        Me.btnBuscaCliente = New System.Windows.Forms.Button
        Me.cmbCliente = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtNumero_8 = New System.Windows.Forms.TextBox
        Me.txtNumero_4 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNumero_82 = New System.Windows.Forms.TextBox
        Me.txtNumero_42 = New System.Windows.Forms.TextBox
        Me.lblid_remito = New System.Windows.Forms.Label
        Me.lblid_factura = New System.Windows.Forms.Label
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.chkControl = New System.Windows.Forms.CheckBox
        Me.btnSalir = New System.Windows.Forms.Button
        Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.btnBuscaRemito = New System.Windows.Forms.Button
        Me.btnBuscaFactura = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtRemito_aux = New System.Windows.Forms.TextBox
        Me.txtFactura_aux = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'lblid_cliente
        '
        Me.lblid_cliente.AutoSize = True
        Me.lblid_cliente.BackColor = System.Drawing.Color.Red
        Me.lblid_cliente.Location = New System.Drawing.Point(384, 39)
        Me.lblid_cliente.Name = "lblid_cliente"
        Me.lblid_cliente.Size = New System.Drawing.Size(13, 13)
        Me.lblid_cliente.TabIndex = 565
        Me.lblid_cliente.Text = "0"
        Me.lblid_cliente.Visible = False
        '
        'btnBuscaCliente
        '
        Me.btnBuscaCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscaCliente.Image = CType(resources.GetObject("btnBuscaCliente.Image"), System.Drawing.Image)
        Me.btnBuscaCliente.Location = New System.Drawing.Point(515, 34)
        Me.btnBuscaCliente.Name = "btnBuscaCliente"
        Me.btnBuscaCliente.Size = New System.Drawing.Size(41, 36)
        Me.btnBuscaCliente.TabIndex = 30
        Me.btnBuscaCliente.UseVisualStyleBackColor = True
        '
        'cmbCliente
        '
        Me.cmbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Location = New System.Drawing.Point(199, 36)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(299, 21)
        Me.cmbCliente.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(59, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 21)
        Me.Label1.TabIndex = 563
        Me.Label1.Text = "Cliente"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(59, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 21)
        Me.Label7.TabIndex = 617
        Me.Label7.Text = "Factura"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNumero_8
        '
        Me.txtNumero_8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero_8.Location = New System.Drawing.Point(286, 81)
        Me.txtNumero_8.MaxLength = 8
        Me.txtNumero_8.Name = "txtNumero_8"
        Me.txtNumero_8.Size = New System.Drawing.Size(135, 20)
        Me.txtNumero_8.TabIndex = 7
        Me.txtNumero_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNumero_4
        '
        Me.txtNumero_4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero_4.Location = New System.Drawing.Point(199, 81)
        Me.txtNumero_4.MaxLength = 4
        Me.txtNumero_4.Name = "txtNumero_4"
        Me.txtNumero_4.Size = New System.Drawing.Size(72, 20)
        Me.txtNumero_4.TabIndex = 6
        Me.txtNumero_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(59, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 21)
        Me.Label2.TabIndex = 620
        Me.Label2.Text = "Recibo"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNumero_82
        '
        Me.txtNumero_82.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero_82.Location = New System.Drawing.Point(286, 122)
        Me.txtNumero_82.MaxLength = 8
        Me.txtNumero_82.Name = "txtNumero_82"
        Me.txtNumero_82.Size = New System.Drawing.Size(135, 20)
        Me.txtNumero_82.TabIndex = 9
        Me.txtNumero_82.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNumero_42
        '
        Me.txtNumero_42.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero_42.Location = New System.Drawing.Point(199, 122)
        Me.txtNumero_42.MaxLength = 4
        Me.txtNumero_42.Name = "txtNumero_42"
        Me.txtNumero_42.Size = New System.Drawing.Size(72, 20)
        Me.txtNumero_42.TabIndex = 8
        Me.txtNumero_42.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblid_remito
        '
        Me.lblid_remito.AutoSize = True
        Me.lblid_remito.BackColor = System.Drawing.Color.Red
        Me.lblid_remito.Location = New System.Drawing.Point(427, 84)
        Me.lblid_remito.Name = "lblid_remito"
        Me.lblid_remito.Size = New System.Drawing.Size(13, 13)
        Me.lblid_remito.TabIndex = 621
        Me.lblid_remito.Text = "0"
        Me.lblid_remito.Visible = False
        '
        'lblid_factura
        '
        Me.lblid_factura.AutoSize = True
        Me.lblid_factura.BackColor = System.Drawing.Color.Red
        Me.lblid_factura.Location = New System.Drawing.Point(427, 125)
        Me.lblid_factura.Name = "lblid_factura"
        Me.lblid_factura.Size = New System.Drawing.Size(13, 13)
        Me.lblid_factura.TabIndex = 622
        Me.lblid_factura.Text = "0"
        Me.lblid_factura.Visible = False
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(59, 211)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(552, 184)
        Me.CheckedListBox1.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(59, 166)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 21)
        Me.Label8.TabIndex = 625
        Me.Label8.Text = "Control"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkControl
        '
        Me.chkControl.AutoSize = True
        Me.chkControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkControl.Location = New System.Drawing.Point(198, 168)
        Me.chkControl.Name = "chkControl"
        Me.chkControl.Size = New System.Drawing.Size(15, 14)
        Me.chkControl.TabIndex = 10
        Me.chkControl.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(545, 451)
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
        Me.btnGuardar.Location = New System.Drawing.Point(438, 451)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(78, 69)
        Me.btnGuardar.TabIndex = 20
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnBuscaRemito
        '
        Me.btnBuscaRemito.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscaRemito.Image = CType(resources.GetObject("btnBuscaRemito.Image"), System.Drawing.Image)
        Me.btnBuscaRemito.Location = New System.Drawing.Point(457, 72)
        Me.btnBuscaRemito.Name = "btnBuscaRemito"
        Me.btnBuscaRemito.Size = New System.Drawing.Size(41, 36)
        Me.btnBuscaRemito.TabIndex = 31
        Me.btnBuscaRemito.UseVisualStyleBackColor = True
        '
        'btnBuscaFactura
        '
        Me.btnBuscaFactura.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscaFactura.Image = CType(resources.GetObject("btnBuscaFactura.Image"), System.Drawing.Image)
        Me.btnBuscaFactura.Location = New System.Drawing.Point(457, 115)
        Me.btnBuscaFactura.Name = "btnBuscaFactura"
        Me.btnBuscaFactura.Size = New System.Drawing.Size(41, 36)
        Me.btnBuscaFactura.TabIndex = 32
        Me.btnBuscaFactura.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(31, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(595, 408)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtRemito_aux
        '
        Me.txtRemito_aux.Location = New System.Drawing.Point(59, 451)
        Me.txtRemito_aux.Name = "txtRemito_aux"
        Me.txtRemito_aux.Size = New System.Drawing.Size(168, 20)
        Me.txtRemito_aux.TabIndex = 626
        Me.txtRemito_aux.Visible = False
        '
        'txtFactura_aux
        '
        Me.txtFactura_aux.Location = New System.Drawing.Point(59, 477)
        Me.txtFactura_aux.Name = "txtFactura_aux"
        Me.txtFactura_aux.Size = New System.Drawing.Size(168, 20)
        Me.txtFactura_aux.TabIndex = 627
        Me.txtFactura_aux.Visible = False
        '
        'frmDetalleRemito_factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(658, 532)
        Me.Controls.Add(Me.txtFactura_aux)
        Me.Controls.Add(Me.txtRemito_aux)
        Me.Controls.Add(Me.btnBuscaFactura)
        Me.Controls.Add(Me.btnBuscaRemito)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.chkControl)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.lblid_factura)
        Me.Controls.Add(Me.lblid_remito)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNumero_82)
        Me.Controls.Add(Me.txtNumero_42)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtNumero_8)
        Me.Controls.Add(Me.txtNumero_4)
        Me.Controls.Add(Me.lblid_cliente)
        Me.Controls.Add(Me.btnBuscaCliente)
        Me.Controls.Add(Me.cmbCliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDetalleRemito_factura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetalleRemito_factura"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblid_cliente As System.Windows.Forms.Label
    Friend WithEvents btnBuscaCliente As System.Windows.Forms.Button
    Friend WithEvents cmbCliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNumero_8 As System.Windows.Forms.TextBox
    Friend WithEvents txtNumero_4 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNumero_82 As System.Windows.Forms.TextBox
    Friend WithEvents txtNumero_42 As System.Windows.Forms.TextBox
    Friend WithEvents lblid_remito As System.Windows.Forms.Label
    Friend WithEvents lblid_factura As System.Windows.Forms.Label
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents chkControl As System.Windows.Forms.CheckBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnBuscaRemito As System.Windows.Forms.Button
    Friend WithEvents btnBuscaFactura As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRemito_aux As System.Windows.Forms.TextBox
    Friend WithEvents txtFactura_aux As System.Windows.Forms.TextBox
End Class
