<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetallePago_iva
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetallePago_iva))
        Me.Label5 = New System.Windows.Forms.Label
        Me.dtpFecha_pago_cheque_iva = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.dtpFecha_emision_cheque_iva = New System.Windows.Forms.DateTimePicker
        Me.chkEfectivo_iva = New System.Windows.Forms.CheckBox
        Me.txtDetalle_cheque_iva = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtNumero_recibo_pago_iva2 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtNumero_cheque_iva = New System.Windows.Forms.TextBox
        Me.lblid_empresa = New System.Windows.Forms.Label
        Me.ttGuardar = New System.Windows.Forms.ToolTip(Me.components)
        Me.dtpFecha_pago_iva = New System.Windows.Forms.DateTimePicker
        Me.txtNumero_recibo_pago_iva = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtPago_iva = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.gbxCheque = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblid_iva = New System.Windows.Forms.Label
        Me.ttSalir = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.txtDetalle_pago = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.gbxCheque.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(26, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 21)
        Me.Label5.TabIndex = 588
        Me.Label5.Text = "Pago"
        '
        'dtpFecha_pago_cheque_iva
        '
        Me.dtpFecha_pago_cheque_iva.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha_pago_cheque_iva.Location = New System.Drawing.Point(165, 96)
        Me.dtpFecha_pago_cheque_iva.Name = "dtpFecha_pago_cheque_iva"
        Me.dtpFecha_pago_cheque_iva.Size = New System.Drawing.Size(99, 20)
        Me.dtpFecha_pago_cheque_iva.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(26, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 21)
        Me.Label2.TabIndex = 586
        Me.Label2.Text = "Emisión"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(57, 249)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 21)
        Me.Label8.TabIndex = 607
        Me.Label8.Text = "Forma de Pago"
        Me.Label8.Visible = False
        '
        'dtpFecha_emision_cheque_iva
        '
        Me.dtpFecha_emision_cheque_iva.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha_emision_cheque_iva.Location = New System.Drawing.Point(165, 61)
        Me.dtpFecha_emision_cheque_iva.Name = "dtpFecha_emision_cheque_iva"
        Me.dtpFecha_emision_cheque_iva.Size = New System.Drawing.Size(99, 20)
        Me.dtpFecha_emision_cheque_iva.TabIndex = 22
        '
        'chkEfectivo_iva
        '
        Me.chkEfectivo_iva.AutoSize = True
        Me.chkEfectivo_iva.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEfectivo_iva.Location = New System.Drawing.Point(196, 249)
        Me.chkEfectivo_iva.Name = "chkEfectivo_iva"
        Me.chkEfectivo_iva.Size = New System.Drawing.Size(77, 21)
        Me.chkEfectivo_iva.TabIndex = 10
        Me.chkEfectivo_iva.Text = "Efectivo"
        Me.chkEfectivo_iva.UseVisualStyleBackColor = True
        Me.chkEfectivo_iva.Visible = False
        '
        'txtDetalle_cheque_iva
        '
        Me.txtDetalle_cheque_iva.BackColor = System.Drawing.Color.White
        Me.txtDetalle_cheque_iva.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDetalle_cheque_iva.Location = New System.Drawing.Point(165, 131)
        Me.txtDetalle_cheque_iva.MaxLength = 50
        Me.txtDetalle_cheque_iva.Multiline = True
        Me.txtDetalle_cheque_iva.Name = "txtDetalle_cheque_iva"
        Me.txtDetalle_cheque_iva.Size = New System.Drawing.Size(299, 58)
        Me.txtDetalle_cheque_iva.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(26, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 21)
        Me.Label7.TabIndex = 593
        Me.Label7.Text = "Detalle"
        '
        'txtNumero_recibo_pago_iva2
        '
        Me.txtNumero_recibo_pago_iva2.BackColor = System.Drawing.Color.White
        Me.txtNumero_recibo_pago_iva2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero_recibo_pago_iva2.Location = New System.Drawing.Point(305, 136)
        Me.txtNumero_recibo_pago_iva2.MaxLength = 8
        Me.txtNumero_recibo_pago_iva2.Name = "txtNumero_recibo_pago_iva2"
        Me.txtNumero_recibo_pago_iva2.Size = New System.Drawing.Size(190, 20)
        Me.txtNumero_recibo_pago_iva2.TabIndex = 8
        Me.txtNumero_recibo_pago_iva2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtNumero_recibo_pago_iva2.Visible = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(26, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 21)
        Me.Label6.TabIndex = 591
        Me.Label6.Text = "Nº Cheque"
        '
        'txtNumero_cheque_iva
        '
        Me.txtNumero_cheque_iva.BackColor = System.Drawing.Color.White
        Me.txtNumero_cheque_iva.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero_cheque_iva.Location = New System.Drawing.Point(165, 26)
        Me.txtNumero_cheque_iva.Name = "txtNumero_cheque_iva"
        Me.txtNumero_cheque_iva.Size = New System.Drawing.Size(299, 20)
        Me.txtNumero_cheque_iva.TabIndex = 21
        '
        'lblid_empresa
        '
        Me.lblid_empresa.AutoSize = True
        Me.lblid_empresa.BackColor = System.Drawing.Color.Red
        Me.lblid_empresa.Location = New System.Drawing.Point(436, 53)
        Me.lblid_empresa.Name = "lblid_empresa"
        Me.lblid_empresa.Size = New System.Drawing.Size(13, 13)
        Me.lblid_empresa.TabIndex = 596
        Me.lblid_empresa.Text = "0"
        Me.lblid_empresa.Visible = False
        '
        'dtpFecha_pago_iva
        '
        Me.dtpFecha_pago_iva.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha_pago_iva.Location = New System.Drawing.Point(196, 46)
        Me.dtpFecha_pago_iva.Name = "dtpFecha_pago_iva"
        Me.dtpFecha_pago_iva.Size = New System.Drawing.Size(99, 20)
        Me.dtpFecha_pago_iva.TabIndex = 5
        '
        'txtNumero_recibo_pago_iva
        '
        Me.txtNumero_recibo_pago_iva.BackColor = System.Drawing.Color.White
        Me.txtNumero_recibo_pago_iva.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero_recibo_pago_iva.Location = New System.Drawing.Point(196, 136)
        Me.txtNumero_recibo_pago_iva.MaxLength = 4
        Me.txtNumero_recibo_pago_iva.Name = "txtNumero_recibo_pago_iva"
        Me.txtNumero_recibo_pago_iva.Size = New System.Drawing.Size(87, 20)
        Me.txtNumero_recibo_pago_iva.TabIndex = 7
        Me.txtNumero_recibo_pago_iva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtNumero_recibo_pago_iva.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(57, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 21)
        Me.Label1.TabIndex = 606
        Me.Label1.Text = "Recibo"
        Me.Label1.Visible = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(57, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 21)
        Me.Label3.TabIndex = 605
        Me.Label3.Text = "Fecha"
        '
        'txtPago_iva
        '
        Me.txtPago_iva.BackColor = System.Drawing.Color.White
        Me.txtPago_iva.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPago_iva.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPago_iva.ForeColor = System.Drawing.Color.Blue
        Me.txtPago_iva.Location = New System.Drawing.Point(196, 81)
        Me.txtPago_iva.Name = "txtPago_iva"
        Me.txtPago_iva.Size = New System.Drawing.Size(299, 40)
        Me.txtPago_iva.TabIndex = 6
        Me.txtPago_iva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(57, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 21)
        Me.Label4.TabIndex = 604
        Me.Label4.Text = "IVA"
        '
        'gbxCheque
        '
        Me.gbxCheque.Controls.Add(Me.Label6)
        Me.gbxCheque.Controls.Add(Me.dtpFecha_pago_cheque_iva)
        Me.gbxCheque.Controls.Add(Me.Label5)
        Me.gbxCheque.Controls.Add(Me.txtNumero_cheque_iva)
        Me.gbxCheque.Controls.Add(Me.dtpFecha_emision_cheque_iva)
        Me.gbxCheque.Controls.Add(Me.Label7)
        Me.gbxCheque.Controls.Add(Me.txtDetalle_cheque_iva)
        Me.gbxCheque.Controls.Add(Me.Label2)
        Me.gbxCheque.Location = New System.Drawing.Point(31, 300)
        Me.gbxCheque.Name = "gbxCheque"
        Me.gbxCheque.Size = New System.Drawing.Size(480, 207)
        Me.gbxCheque.TabIndex = 20
        Me.gbxCheque.TabStop = False
        Me.gbxCheque.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(31, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(480, 230)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lblid_iva
        '
        Me.lblid_iva.AutoSize = True
        Me.lblid_iva.BackColor = System.Drawing.Color.Red
        Me.lblid_iva.Location = New System.Drawing.Point(459, 53)
        Me.lblid_iva.Name = "lblid_iva"
        Me.lblid_iva.Size = New System.Drawing.Size(13, 13)
        Me.lblid_iva.TabIndex = 610
        Me.lblid_iva.Text = "0"
        Me.lblid_iva.Visible = False
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(430, 252)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(81, 69)
        Me.btnSalir.TabIndex = 31
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
        Me.btnGuardar.Location = New System.Drawing.Point(334, 252)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(78, 69)
        Me.btnGuardar.TabIndex = 30
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtDetalle_pago
        '
        Me.txtDetalle_pago.BackColor = System.Drawing.Color.White
        Me.txtDetalle_pago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDetalle_pago.Location = New System.Drawing.Point(196, 174)
        Me.txtDetalle_pago.MaxLength = 50
        Me.txtDetalle_pago.Multiline = True
        Me.txtDetalle_pago.Name = "txtDetalle_pago"
        Me.txtDetalle_pago.Size = New System.Drawing.Size(299, 58)
        Me.txtDetalle_pago.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(57, 173)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 21)
        Me.Label9.TabIndex = 612
        Me.Label9.Text = "Detalle"
        '
        'frmDetallePago_iva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 358)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtDetalle_pago)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblid_iva)
        Me.Controls.Add(Me.lblid_empresa)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.chkEfectivo_iva)
        Me.Controls.Add(Me.txtNumero_recibo_pago_iva2)
        Me.Controls.Add(Me.dtpFecha_pago_iva)
        Me.Controls.Add(Me.txtNumero_recibo_pago_iva)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPago_iva)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbxCheque)
        Me.Name = "frmDetallePago_iva"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IVA Ventas" & vgNombreFormulario
        Me.gbxCheque.ResumeLayout(False)
        Me.gbxCheque.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha_pago_cheque_iva As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha_emision_cheque_iva As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkEfectivo_iva As System.Windows.Forms.CheckBox
    Friend WithEvents txtDetalle_cheque_iva As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNumero_recibo_pago_iva2 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNumero_cheque_iva As System.Windows.Forms.TextBox
    Friend WithEvents lblid_empresa As System.Windows.Forms.Label
    Friend WithEvents ttGuardar As System.Windows.Forms.ToolTip
    Friend WithEvents dtpFecha_pago_iva As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNumero_recibo_pago_iva As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPago_iva As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gbxCheque As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ttSalir As System.Windows.Forms.ToolTip
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents lblid_iva As System.Windows.Forms.Label
    Friend WithEvents txtDetalle_pago As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
