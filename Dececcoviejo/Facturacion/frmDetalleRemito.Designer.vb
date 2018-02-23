<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleRemito
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleRemito))
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtNumero_8 = New System.Windows.Forms.TextBox
        Me.txtNumero_4 = New System.Windows.Forms.TextBox
        Me.dtpFecha_remito = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblid_cliente = New System.Windows.Forms.Label
        Me.btnBuscaCliente = New System.Windows.Forms.Button
        Me.cmbCliente = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.chkControl = New System.Windows.Forms.CheckBox
        Me.btnSalir = New System.Windows.Forms.Button
        Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtTotal_remito = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(48, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 21)
        Me.Label7.TabIndex = 617
        Me.Label7.Text = "Número"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNumero_8
        '
        Me.txtNumero_8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero_8.Location = New System.Drawing.Point(275, 90)
        Me.txtNumero_8.MaxLength = 8
        Me.txtNumero_8.Name = "txtNumero_8"
        Me.txtNumero_8.Size = New System.Drawing.Size(135, 20)
        Me.txtNumero_8.TabIndex = 7
        Me.txtNumero_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNumero_4
        '
        Me.txtNumero_4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero_4.Location = New System.Drawing.Point(188, 90)
        Me.txtNumero_4.MaxLength = 4
        Me.txtNumero_4.Name = "txtNumero_4"
        Me.txtNumero_4.Size = New System.Drawing.Size(72, 20)
        Me.txtNumero_4.TabIndex = 6
        Me.txtNumero_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtpFecha_remito
        '
        Me.dtpFecha_remito.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha_remito.Location = New System.Drawing.Point(187, 136)
        Me.dtpFecha_remito.Name = "dtpFecha_remito"
        Me.dtpFecha_remito.Size = New System.Drawing.Size(116, 20)
        Me.dtpFecha_remito.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(48, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 21)
        Me.Label3.TabIndex = 619
        Me.Label3.Text = "Fecha"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_cliente
        '
        Me.lblid_cliente.AutoSize = True
        Me.lblid_cliente.BackColor = System.Drawing.Color.Red
        Me.lblid_cliente.Location = New System.Drawing.Point(373, 49)
        Me.lblid_cliente.Name = "lblid_cliente"
        Me.lblid_cliente.Size = New System.Drawing.Size(13, 13)
        Me.lblid_cliente.TabIndex = 623
        Me.lblid_cliente.Text = "0"
        Me.lblid_cliente.Visible = False
        '
        'btnBuscaCliente
        '
        Me.btnBuscaCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscaCliente.Image = CType(resources.GetObject("btnBuscaCliente.Image"), System.Drawing.Image)
        Me.btnBuscaCliente.Location = New System.Drawing.Point(502, 44)
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
        Me.cmbCliente.Location = New System.Drawing.Point(188, 46)
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
        Me.Label1.Location = New System.Drawing.Point(48, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 21)
        Me.Label1.TabIndex = 621
        Me.Label1.Text = "Cliente"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(48, 179)
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
        Me.chkControl.Location = New System.Drawing.Point(187, 181)
        Me.chkControl.Name = "chkControl"
        Me.chkControl.Size = New System.Drawing.Size(15, 14)
        Me.chkControl.TabIndex = 9
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
        Me.btnSalir.Location = New System.Drawing.Point(483, 299)
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
        Me.btnGuardar.Location = New System.Drawing.Point(376, 299)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(78, 69)
        Me.btnGuardar.TabIndex = 20
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(23, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(541, 254)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtTotal_remito
        '
        Me.txtTotal_remito.BackColor = System.Drawing.Color.White
        Me.txtTotal_remito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotal_remito.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal_remito.ForeColor = System.Drawing.Color.Blue
        Me.txtTotal_remito.Location = New System.Drawing.Point(187, 219)
        Me.txtTotal_remito.MaxLength = 50
        Me.txtTotal_remito.Name = "txtTotal_remito"
        Me.txtTotal_remito.Size = New System.Drawing.Size(222, 31)
        Me.txtTotal_remito.TabIndex = 10
        Me.txtTotal_remito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(48, 219)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 21)
        Me.Label6.TabIndex = 627
        Me.Label6.Text = "Total"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmDetalleRemito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 390)
        Me.Controls.Add(Me.txtTotal_remito)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.chkControl)
        Me.Controls.Add(Me.lblid_cliente)
        Me.Controls.Add(Me.btnBuscaCliente)
        Me.Controls.Add(Me.cmbCliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpFecha_remito)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtNumero_8)
        Me.Controls.Add(Me.txtNumero_4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDetalleRemito"
        Me.Text = "frmDetalleRemito"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNumero_8 As System.Windows.Forms.TextBox
    Friend WithEvents txtNumero_4 As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha_remito As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblid_cliente As System.Windows.Forms.Label
    Friend WithEvents btnBuscaCliente As System.Windows.Forms.Button
    Friend WithEvents cmbCliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents chkControl As System.Windows.Forms.CheckBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTotal_remito As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
