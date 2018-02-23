<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmtransfbancaria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmtransfbancaria))
        Me.txtDetalle = New System.Windows.Forms.TextBox()
        Me.Lbldetalle = New System.Windows.Forms.Label()
        Me.Txtimporte = New System.Windows.Forms.TextBox()
        Me.Lblimporte = New System.Windows.Forms.Label()
        Me.Txtboletatransf = New System.Windows.Forms.TextBox()
        Me.Lblboletatransf = New System.Windows.Forms.Label()
        Me.dpTransferencia = New System.Windows.Forms.DateTimePicker()
        Me.Lblfechatransf = New System.Windows.Forms.Label()
        Me.cmbBanco = New System.Windows.Forms.ComboBox()
        Me.Lblbcoorigen = New System.Windows.Forms.Label()
        Me.ToolTipbcos = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipbco = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipsalir = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipguarda = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblid_BancoCheque = New System.Windows.Forms.Label()
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip4 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnBuscaBanco = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtiva = New System.Windows.Forms.TextBox()
        Me.etiquetaiva = New System.Windows.Forms.Label()
        Me.btnBuscaCliente = New System.Windows.Forms.Button()
        Me.lblid_Cliente = New System.Windows.Forms.Label()
        Me.Cmbcliente = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtDetalle
        '
        Me.txtDetalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDetalle.Location = New System.Drawing.Point(191, 300)
        Me.txtDetalle.MaxLength = 50
        Me.txtDetalle.Multiline = True
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.Size = New System.Drawing.Size(275, 87)
        Me.txtDetalle.TabIndex = 11
        '
        'Lbldetalle
        '
        Me.Lbldetalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lbldetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbldetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbldetalle.Location = New System.Drawing.Point(29, 300)
        Me.Lbldetalle.Name = "Lbldetalle"
        Me.Lbldetalle.Size = New System.Drawing.Size(144, 20)
        Me.Lbldetalle.TabIndex = 28
        Me.Lbldetalle.Text = "Detalle de Depósito"
        Me.Lbldetalle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Txtimporte
        '
        Me.Txtimporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtimporte.ForeColor = System.Drawing.Color.Blue
        Me.Txtimporte.Location = New System.Drawing.Point(191, 200)
        Me.Txtimporte.Name = "Txtimporte"
        Me.Txtimporte.Size = New System.Drawing.Size(222, 31)
        Me.Txtimporte.TabIndex = 9
        Me.Txtimporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Lblimporte
        '
        Me.Lblimporte.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lblimporte.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lblimporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblimporte.Location = New System.Drawing.Point(29, 204)
        Me.Lblimporte.Name = "Lblimporte"
        Me.Lblimporte.Size = New System.Drawing.Size(144, 20)
        Me.Lblimporte.TabIndex = 26
        Me.Lblimporte.Text = "Importe Depositado"
        Me.Lblimporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Txtboletatransf
        '
        Me.Txtboletatransf.Location = New System.Drawing.Point(191, 73)
        Me.Txtboletatransf.Name = "Txtboletatransf"
        Me.Txtboletatransf.Size = New System.Drawing.Size(222, 20)
        Me.Txtboletatransf.TabIndex = 6
        '
        'Lblboletatransf
        '
        Me.Lblboletatransf.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lblboletatransf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lblboletatransf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblboletatransf.Location = New System.Drawing.Point(29, 76)
        Me.Lblboletatransf.Name = "Lblboletatransf"
        Me.Lblboletatransf.Size = New System.Drawing.Size(144, 20)
        Me.Lblboletatransf.TabIndex = 24
        Me.Lblboletatransf.Text = "Boleta Número"
        Me.Lblboletatransf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dpTransferencia
        '
        Me.dpTransferencia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpTransferencia.Location = New System.Drawing.Point(191, 31)
        Me.dpTransferencia.Name = "dpTransferencia"
        Me.dpTransferencia.Size = New System.Drawing.Size(108, 20)
        Me.dpTransferencia.TabIndex = 5
        '
        'Lblfechatransf
        '
        Me.Lblfechatransf.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lblfechatransf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lblfechatransf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblfechatransf.Location = New System.Drawing.Point(29, 31)
        Me.Lblfechatransf.Name = "Lblfechatransf"
        Me.Lblfechatransf.Size = New System.Drawing.Size(144, 20)
        Me.Lblfechatransf.TabIndex = 22
        Me.Lblfechatransf.Text = "Fecha de Transferencia"
        Me.Lblfechatransf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbBanco
        '
        Me.cmbBanco.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbBanco.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbBanco.FormattingEnabled = True
        Me.cmbBanco.Location = New System.Drawing.Point(191, 117)
        Me.cmbBanco.Name = "cmbBanco"
        Me.cmbBanco.Size = New System.Drawing.Size(275, 21)
        Me.cmbBanco.TabIndex = 7
        '
        'Lblbcoorigen
        '
        Me.Lblbcoorigen.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lblbcoorigen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lblbcoorigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblbcoorigen.Location = New System.Drawing.Point(29, 121)
        Me.Lblbcoorigen.Name = "Lblbcoorigen"
        Me.Lblbcoorigen.Size = New System.Drawing.Size(144, 20)
        Me.Lblbcoorigen.TabIndex = 34
        Me.Lblbcoorigen.Text = "Banco de Origen"
        Me.Lblbcoorigen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_BancoCheque
        '
        Me.lblid_BancoCheque.AutoSize = True
        Me.lblid_BancoCheque.BackColor = System.Drawing.Color.Red
        Me.lblid_BancoCheque.ForeColor = System.Drawing.Color.Black
        Me.lblid_BancoCheque.Location = New System.Drawing.Point(371, 118)
        Me.lblid_BancoCheque.Name = "lblid_BancoCheque"
        Me.lblid_BancoCheque.Size = New System.Drawing.Size(13, 13)
        Me.lblid_BancoCheque.TabIndex = 384
        Me.lblid_BancoCheque.Text = "0"
        Me.lblid_BancoCheque.Visible = False
        '
        'btnBuscaBanco
        '
        Me.btnBuscaBanco.BackColor = System.Drawing.Color.Gainsboro
        Me.btnBuscaBanco.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnBuscaBanco.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnBuscaBanco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBuscaBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscaBanco.Image = CType(resources.GetObject("btnBuscaBanco.Image"), System.Drawing.Image)
        Me.btnBuscaBanco.Location = New System.Drawing.Point(484, 117)
        Me.btnBuscaBanco.Name = "btnBuscaBanco"
        Me.btnBuscaBanco.Size = New System.Drawing.Size(40, 32)
        Me.btnBuscaBanco.TabIndex = 30
        Me.btnBuscaBanco.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBuscaBanco.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(469, 430)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(79, 66)
        Me.btnSalir.TabIndex = 21
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.Gainsboro
        Me.btnGuardar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(374, 430)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(77, 66)
        Me.btnGuardar.TabIndex = 20
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(12, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(536, 401)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtiva
        '
        Me.txtiva.BackColor = System.Drawing.Color.White
        Me.txtiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtiva.ForeColor = System.Drawing.Color.Blue
        Me.txtiva.Location = New System.Drawing.Point(191, 248)
        Me.txtiva.MaxLength = 50
        Me.txtiva.Name = "txtiva"
        Me.txtiva.Size = New System.Drawing.Size(222, 31)
        Me.txtiva.TabIndex = 10
        Me.txtiva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetaiva
        '
        Me.etiquetaiva.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaiva.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaiva.ForeColor = System.Drawing.Color.Black
        Me.etiquetaiva.Location = New System.Drawing.Point(29, 248)
        Me.etiquetaiva.Name = "etiquetaiva"
        Me.etiquetaiva.Size = New System.Drawing.Size(147, 21)
        Me.etiquetaiva.TabIndex = 591
        Me.etiquetaiva.Text = "Iva"
        Me.etiquetaiva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnBuscaCliente
        '
        Me.btnBuscaCliente.BackColor = System.Drawing.Color.Gainsboro
        Me.btnBuscaCliente.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnBuscaCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnBuscaCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBuscaCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscaCliente.Image = CType(resources.GetObject("btnBuscaCliente.Image"), System.Drawing.Image)
        Me.btnBuscaCliente.Location = New System.Drawing.Point(484, 161)
        Me.btnBuscaCliente.Name = "btnBuscaCliente"
        Me.btnBuscaCliente.Size = New System.Drawing.Size(40, 32)
        Me.btnBuscaCliente.TabIndex = 31
        Me.btnBuscaCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBuscaCliente.UseVisualStyleBackColor = True
        '
        'lblid_Cliente
        '
        Me.lblid_Cliente.AutoSize = True
        Me.lblid_Cliente.BackColor = System.Drawing.Color.Red
        Me.lblid_Cliente.ForeColor = System.Drawing.Color.Black
        Me.lblid_Cliente.Location = New System.Drawing.Point(363, 161)
        Me.lblid_Cliente.Name = "lblid_Cliente"
        Me.lblid_Cliente.Size = New System.Drawing.Size(13, 13)
        Me.lblid_Cliente.TabIndex = 595
        Me.lblid_Cliente.Text = "0"
        Me.lblid_Cliente.Visible = False
        '
        'Cmbcliente
        '
        Me.Cmbcliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Cmbcliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cmbcliente.FormattingEnabled = True
        Me.Cmbcliente.Location = New System.Drawing.Point(191, 159)
        Me.Cmbcliente.Name = "Cmbcliente"
        Me.Cmbcliente.Size = New System.Drawing.Size(275, 21)
        Me.Cmbcliente.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(29, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 21)
        Me.Label1.TabIndex = 592
        Me.Label1.Text = "Cliente"
        '
        'Frmtransfbancaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(570, 529)
        Me.Controls.Add(Me.btnBuscaCliente)
        Me.Controls.Add(Me.lblid_Cliente)
        Me.Controls.Add(Me.Cmbcliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtiva)
        Me.Controls.Add(Me.etiquetaiva)
        Me.Controls.Add(Me.btnBuscaBanco)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lblid_BancoCheque)
        Me.Controls.Add(Me.cmbBanco)
        Me.Controls.Add(Me.Lblbcoorigen)
        Me.Controls.Add(Me.txtDetalle)
        Me.Controls.Add(Me.Lbldetalle)
        Me.Controls.Add(Me.Txtimporte)
        Me.Controls.Add(Me.Lblimporte)
        Me.Controls.Add(Me.Txtboletatransf)
        Me.Controls.Add(Me.Lblboletatransf)
        Me.Controls.Add(Me.dpTransferencia)
        Me.Controls.Add(Me.Lblfechatransf)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frmtransfbancaria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transferencias Bancarias"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDetalle As System.Windows.Forms.TextBox
    Friend WithEvents Lbldetalle As System.Windows.Forms.Label
    Friend WithEvents Txtimporte As System.Windows.Forms.TextBox
    Friend WithEvents Lblimporte As System.Windows.Forms.Label
    Friend WithEvents Txtboletatransf As System.Windows.Forms.TextBox
    Friend WithEvents Lblboletatransf As System.Windows.Forms.Label
    Friend WithEvents dpTransferencia As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lblfechatransf As System.Windows.Forms.Label
    Friend WithEvents cmbBanco As System.Windows.Forms.ComboBox
    Friend WithEvents Lblbcoorigen As System.Windows.Forms.Label
    Friend WithEvents ToolTipbcos As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTipbco As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTipsalir As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTipguarda As System.Windows.Forms.ToolTip
    Friend WithEvents lblid_BancoCheque As System.Windows.Forms.Label
    Friend WithEvents ToolTip3 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip4 As System.Windows.Forms.ToolTip
    Friend WithEvents btnBuscaBanco As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Protected WithEvents txtiva As System.Windows.Forms.TextBox
    Friend WithEvents etiquetaiva As System.Windows.Forms.Label
    Friend WithEvents btnBuscaCliente As System.Windows.Forms.Button
    Friend WithEvents lblid_Cliente As System.Windows.Forms.Label
    Friend WithEvents Cmbcliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
