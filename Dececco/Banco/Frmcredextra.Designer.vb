<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmcredextra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmcredextra))
        Me.Lbldetalle = New System.Windows.Forms.Label()
        Me.Lblimporte = New System.Windows.Forms.Label()
        Me.txtBoleta = New System.Windows.Forms.TextBox()
        Me.Lblboletacred = New System.Windows.Forms.Label()
        Me.dpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Lblfechacredito = New System.Windows.Forms.Label()
        Me.txtDetalle = New System.Windows.Forms.TextBox()
        Me.Txtimporte = New System.Windows.Forms.TextBox()
        Me.ToolTipsalir = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipguarda = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipbco = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipbcos = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtiva = New System.Windows.Forms.TextBox()
        Me.etiquetaiva = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Lbldetalle
        '
        Me.Lbldetalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lbldetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbldetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbldetalle.Location = New System.Drawing.Point(30, 237)
        Me.Lbldetalle.Name = "Lbldetalle"
        Me.Lbldetalle.Size = New System.Drawing.Size(123, 21)
        Me.Lbldetalle.TabIndex = 66
        Me.Lbldetalle.Text = "Detalle del  Crédito"
        Me.Lbldetalle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lblimporte
        '
        Me.Lblimporte.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lblimporte.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lblimporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblimporte.Location = New System.Drawing.Point(30, 136)
        Me.Lblimporte.Name = "Lblimporte"
        Me.Lblimporte.Size = New System.Drawing.Size(123, 21)
        Me.Lblimporte.TabIndex = 64
        Me.Lblimporte.Text = "Importe Acreditado"
        Me.Lblimporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBoleta
        '
        Me.txtBoleta.Location = New System.Drawing.Point(168, 91)
        Me.txtBoleta.Name = "txtBoleta"
        Me.txtBoleta.Size = New System.Drawing.Size(212, 20)
        Me.txtBoleta.TabIndex = 6
        '
        'Lblboletacred
        '
        Me.Lblboletacred.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lblboletacred.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lblboletacred.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblboletacred.Location = New System.Drawing.Point(30, 91)
        Me.Lblboletacred.Name = "Lblboletacred"
        Me.Lblboletacred.Size = New System.Drawing.Size(123, 21)
        Me.Lblboletacred.TabIndex = 62
        Me.Lblboletacred.Text = "Comprob. Número"
        Me.Lblboletacred.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dpFecha
        '
        Me.dpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpFecha.Location = New System.Drawing.Point(168, 48)
        Me.dpFecha.Name = "dpFecha"
        Me.dpFecha.Size = New System.Drawing.Size(137, 20)
        Me.dpFecha.TabIndex = 5
        '
        'Lblfechacredito
        '
        Me.Lblfechacredito.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lblfechacredito.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lblfechacredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblfechacredito.Location = New System.Drawing.Point(30, 48)
        Me.Lblfechacredito.Name = "Lblfechacredito"
        Me.Lblfechacredito.Size = New System.Drawing.Size(123, 21)
        Me.Lblfechacredito.TabIndex = 60
        Me.Lblfechacredito.Text = "Fecha del Crédito"
        Me.Lblfechacredito.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDetalle
        '
        Me.txtDetalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDetalle.Location = New System.Drawing.Point(168, 237)
        Me.txtDetalle.Multiline = True
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.Size = New System.Drawing.Size(308, 87)
        Me.txtDetalle.TabIndex = 9
        '
        'Txtimporte
        '
        Me.Txtimporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtimporte.ForeColor = System.Drawing.Color.Blue
        Me.Txtimporte.Location = New System.Drawing.Point(168, 136)
        Me.Txtimporte.Name = "Txtimporte"
        Me.Txtimporte.Size = New System.Drawing.Size(212, 31)
        Me.Txtimporte.TabIndex = 7
        Me.Txtimporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(427, 377)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(82, 71)
        Me.btnSalir.TabIndex = 21
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.Gainsboro
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(316, 377)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(82, 71)
        Me.btnGuardar.TabIndex = 20
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(497, 338)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtiva
        '
        Me.txtiva.BackColor = System.Drawing.Color.White
        Me.txtiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtiva.ForeColor = System.Drawing.Color.Blue
        Me.txtiva.Location = New System.Drawing.Point(168, 187)
        Me.txtiva.MaxLength = 50
        Me.txtiva.Name = "txtiva"
        Me.txtiva.Size = New System.Drawing.Size(212, 31)
        Me.txtiva.TabIndex = 8
        Me.txtiva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetaiva
        '
        Me.etiquetaiva.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaiva.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaiva.ForeColor = System.Drawing.Color.Black
        Me.etiquetaiva.Location = New System.Drawing.Point(30, 187)
        Me.etiquetaiva.Name = "etiquetaiva"
        Me.etiquetaiva.Size = New System.Drawing.Size(123, 21)
        Me.etiquetaiva.TabIndex = 591
        Me.etiquetaiva.Text = "Iva"
        Me.etiquetaiva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Frmcredextra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(521, 472)
        Me.Controls.Add(Me.txtiva)
        Me.Controls.Add(Me.etiquetaiva)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtDetalle)
        Me.Controls.Add(Me.Txtimporte)
        Me.Controls.Add(Me.Lbldetalle)
        Me.Controls.Add(Me.Lblimporte)
        Me.Controls.Add(Me.txtBoleta)
        Me.Controls.Add(Me.Lblboletacred)
        Me.Controls.Add(Me.dpFecha)
        Me.Controls.Add(Me.Lblfechacredito)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frmcredextra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Créditos Extraordinarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbldetalle As System.Windows.Forms.Label
    Friend WithEvents Lblimporte As System.Windows.Forms.Label
    Friend WithEvents txtBoleta As System.Windows.Forms.TextBox
    Friend WithEvents Lblboletacred As System.Windows.Forms.Label
    Friend WithEvents dpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lblfechacredito As System.Windows.Forms.Label
    Friend WithEvents txtDetalle As System.Windows.Forms.TextBox
    Friend WithEvents Txtimporte As System.Windows.Forms.TextBox
    Friend WithEvents ToolTipsalir As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTipguarda As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTipbco As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTipbcos As System.Windows.Forms.ToolTip
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Protected WithEvents txtiva As System.Windows.Forms.TextBox
    Friend WithEvents etiquetaiva As System.Windows.Forms.Label
End Class
