<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleAsignacion_iva
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleAsignacion_iva))
        Me.txtDetalle_asignacion_iva = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblid_iva = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblid_empresa = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtSueldo_iva = New System.Windows.Forms.TextBox
        Me.ttSalir = New System.Windows.Forms.ToolTip(Me.components)
        Me.dtpFecha_asignacion_iva = New System.Windows.Forms.DateTimePicker
        Me.ttGuardar = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtDetalle_asignacion_iva
        '
        Me.txtDetalle_asignacion_iva.BackColor = System.Drawing.Color.White
        Me.txtDetalle_asignacion_iva.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDetalle_asignacion_iva.Location = New System.Drawing.Point(163, 149)
        Me.txtDetalle_asignacion_iva.Multiline = True
        Me.txtDetalle_asignacion_iva.Name = "txtDetalle_asignacion_iva"
        Me.txtDetalle_asignacion_iva.Size = New System.Drawing.Size(299, 55)
        Me.txtDetalle_asignacion_iva.TabIndex = 595
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(47, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 21)
        Me.Label1.TabIndex = 602
        Me.Label1.Text = "Detalle"
        '
        'lblid_iva
        '
        Me.lblid_iva.AutoSize = True
        Me.lblid_iva.BackColor = System.Drawing.Color.Red
        Me.lblid_iva.Location = New System.Drawing.Point(433, 53)
        Me.lblid_iva.Name = "lblid_iva"
        Me.lblid_iva.Size = New System.Drawing.Size(13, 13)
        Me.lblid_iva.TabIndex = 601
        Me.lblid_iva.Text = "0"
        Me.lblid_iva.Visible = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(47, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 21)
        Me.Label4.TabIndex = 599
        Me.Label4.Text = "IVA"
        '
        'lblid_empresa
        '
        Me.lblid_empresa.AutoSize = True
        Me.lblid_empresa.BackColor = System.Drawing.Color.Red
        Me.lblid_empresa.Location = New System.Drawing.Point(394, 53)
        Me.lblid_empresa.Name = "lblid_empresa"
        Me.lblid_empresa.Size = New System.Drawing.Size(13, 13)
        Me.lblid_empresa.TabIndex = 598
        Me.lblid_empresa.Text = "0"
        Me.lblid_empresa.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(29, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(485, 210)
        Me.GroupBox1.TabIndex = 592
        Me.GroupBox1.TabStop = False
        '
        'txtSueldo_iva
        '
        Me.txtSueldo_iva.BackColor = System.Drawing.Color.White
        Me.txtSueldo_iva.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSueldo_iva.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSueldo_iva.ForeColor = System.Drawing.Color.Blue
        Me.txtSueldo_iva.Location = New System.Drawing.Point(163, 94)
        Me.txtSueldo_iva.Name = "txtSueldo_iva"
        Me.txtSueldo_iva.Size = New System.Drawing.Size(299, 31)
        Me.txtSueldo_iva.TabIndex = 594
        Me.txtSueldo_iva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtpFecha_asignacion_iva
        '
        Me.dtpFecha_asignacion_iva.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha_asignacion_iva.Location = New System.Drawing.Point(163, 46)
        Me.dtpFecha_asignacion_iva.Name = "dtpFecha_asignacion_iva"
        Me.dtpFecha_asignacion_iva.Size = New System.Drawing.Size(150, 20)
        Me.dtpFecha_asignacion_iva.TabIndex = 593
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(47, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 21)
        Me.Label3.TabIndex = 600
        Me.Label3.Text = "Fecha"
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(426, 271)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(81, 69)
        Me.btnSalir.TabIndex = 597
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
        Me.btnGuardar.Location = New System.Drawing.Point(319, 271)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(78, 69)
        Me.btnGuardar.TabIndex = 596
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'frmDetalleAsignacion_iva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 366)
        Me.Controls.Add(Me.txtDetalle_asignacion_iva)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblid_iva)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblid_empresa)
        Me.Controls.Add(Me.txtSueldo_iva)
        Me.Controls.Add(Me.dtpFecha_asignacion_iva)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDetalleAsignacion_iva"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IVA Compras" & vgNombreFormulario
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDetalle_asignacion_iva As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblid_iva As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblid_empresa As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSueldo_iva As System.Windows.Forms.TextBox
    Friend WithEvents ttSalir As System.Windows.Forms.ToolTip
    Friend WithEvents dtpFecha_asignacion_iva As System.Windows.Forms.DateTimePicker
    Friend WithEvents ttGuardar As System.Windows.Forms.ToolTip
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
End Class
