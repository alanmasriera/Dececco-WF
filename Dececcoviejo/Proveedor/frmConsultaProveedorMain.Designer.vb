<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaProveedorMain
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaProveedorMain))
        Me.lblid_proveedor = New System.Windows.Forms.Label()
        Me.cmbProveedor = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFecha_desde = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFecha_hasta = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn10 = New System.Windows.Forms.Button()
        Me.lblSaldoAnterior = New System.Windows.Forms.Label()
        Me.lblSaldoActual = New System.Windows.Forms.Label()
        Me.lblTotalGrilla = New System.Windows.Forms.Label()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblid_proveedor
        '
        Me.lblid_proveedor.AutoSize = True
        Me.lblid_proveedor.BackColor = System.Drawing.Color.Red
        Me.lblid_proveedor.Location = New System.Drawing.Point(129, 17)
        Me.lblid_proveedor.Name = "lblid_proveedor"
        Me.lblid_proveedor.Size = New System.Drawing.Size(13, 13)
        Me.lblid_proveedor.TabIndex = 1025
        Me.lblid_proveedor.Text = "0"
        Me.lblid_proveedor.Visible = False
        '
        'cmbProveedor
        '
        Me.cmbProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbProveedor.FormattingEnabled = True
        Me.cmbProveedor.Location = New System.Drawing.Point(113, 14)
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.Size = New System.Drawing.Size(281, 21)
        Me.cmbProveedor.TabIndex = 1022
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(44, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 15)
        Me.Label1.TabIndex = 1024
        Me.Label1.Text = "Proveedor"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpFecha_desde
        '
        Me.dtpFecha_desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha_desde.Location = New System.Drawing.Point(491, 16)
        Me.dtpFecha_desde.Name = "dtpFecha_desde"
        Me.dtpFecha_desde.Size = New System.Drawing.Size(116, 20)
        Me.dtpFecha_desde.TabIndex = 1026
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(405, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 15)
        Me.Label3.TabIndex = 1027
        Me.Label3.Text = "Fecha Desde"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpFecha_hasta
        '
        Me.dtpFecha_hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha_hasta.Location = New System.Drawing.Point(698, 17)
        Me.dtpFecha_hasta.Name = "dtpFecha_hasta"
        Me.dtpFecha_hasta.Size = New System.Drawing.Size(116, 20)
        Me.dtpFecha_hasta.TabIndex = 1028
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(616, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 15)
        Me.Label2.TabIndex = 1029
        Me.Label2.Text = "Fecha Hasta"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn3
        '
        Me.btn3.Enabled = False
        Me.btn3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn3.Location = New System.Drawing.Point(382, 149)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(157, 57)
        Me.btn3.TabIndex = 1014
        Me.btn3.Text = "Facturas y Pagos Entre Fechas de Todos los Proveedores"
        Me.btn3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn3.UseVisualStyleBackColor = True
        Me.btn3.Visible = False
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(732, 147)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(86, 71)
        Me.btnSalir.TabIndex = 1011
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Image = CType(resources.GetObject("btn8.Image"), System.Drawing.Image)
        Me.btn8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn8.Location = New System.Drawing.Point(241, 71)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(135, 57)
        Me.btn8.TabIndex = 1033
        Me.btn8.Text = "Facturas Vencidas Entre Fechas por Proveedor"
        Me.btn8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Image = CType(resources.GetObject("btn2.Image"), System.Drawing.Image)
        Me.btn2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn2.Location = New System.Drawing.Point(654, 161)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(38, 57)
        Me.btn2.TabIndex = 1013
        Me.btn2.Text = " Vencidas Entre Fechas por Proveedor"
        Me.btn2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn2.UseVisualStyleBackColor = True
        Me.btn2.Visible = False
        '
        'btn4
        '
        Me.btn4.Image = CType(resources.GetObject("btn4.Image"), System.Drawing.Image)
        Me.btn4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn4.Location = New System.Drawing.Point(381, 71)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(157, 57)
        Me.btn4.TabIndex = 1015
        Me.btn4.Text = "Facturas Vencidas Entre Fechas de Todos los Proveedores"
        Me.btn4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Image = CType(resources.GetObject("btn7.Image"), System.Drawing.Image)
        Me.btn7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn7.Location = New System.Drawing.Point(682, 71)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(135, 57)
        Me.btn7.TabIndex = 1018
        Me.btn7.Text = "Facturas Entre Fechas de Todos los Proveedores"
        Me.btn7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Image = CType(resources.GetObject("btn6.Image"), System.Drawing.Image)
        Me.btn6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn6.Location = New System.Drawing.Point(241, 147)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(137, 57)
        Me.btn6.TabIndex = 1017
        Me.btn6.Text = "Pagos Entre Fechas de Todos los Proveedores"
        Me.btn6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Image = CType(resources.GetObject("btn1.Image"), System.Drawing.Image)
        Me.btn1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn1.Location = New System.Drawing.Point(98, 71)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(137, 57)
        Me.btn1.TabIndex = 1012
        Me.btn1.Text = "Saldo de todos los proveedores"
        Me.btn1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn10
        '
        Me.btn10.Image = CType(resources.GetObject("btn10.Image"), System.Drawing.Image)
        Me.btn10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn10.Location = New System.Drawing.Point(544, 71)
        Me.btn10.Name = "btn10"
        Me.btn10.Size = New System.Drawing.Size(135, 57)
        Me.btn10.TabIndex = 1034
        Me.btn10.Text = "Facturas Entre Fechas por Proveedores"
        Me.btn10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn10.UseVisualStyleBackColor = True
        '
        'lblSaldoAnterior
        '
        Me.lblSaldoAnterior.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSaldoAnterior.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSaldoAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSaldoAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldoAnterior.ForeColor = System.Drawing.Color.Blue
        Me.lblSaldoAnterior.Location = New System.Drawing.Point(710, 155)
        Me.lblSaldoAnterior.Name = "lblSaldoAnterior"
        Me.lblSaldoAnterior.Size = New System.Drawing.Size(10, 29)
        Me.lblSaldoAnterior.TabIndex = 1030
        Me.lblSaldoAnterior.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblSaldoAnterior.Visible = False
        '
        'lblSaldoActual
        '
        Me.lblSaldoActual.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSaldoActual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSaldoActual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSaldoActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldoActual.ForeColor = System.Drawing.Color.Blue
        Me.lblSaldoActual.Location = New System.Drawing.Point(710, 184)
        Me.lblSaldoActual.Name = "lblSaldoActual"
        Me.lblSaldoActual.Size = New System.Drawing.Size(10, 29)
        Me.lblSaldoActual.TabIndex = 1031
        Me.lblSaldoActual.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblSaldoActual.Visible = False
        '
        'lblTotalGrilla
        '
        Me.lblTotalGrilla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalGrilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTotalGrilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalGrilla.Location = New System.Drawing.Point(701, 160)
        Me.lblTotalGrilla.Name = "lblTotalGrilla"
        Me.lblTotalGrilla.Size = New System.Drawing.Size(10, 17)
        Me.lblTotalGrilla.TabIndex = 1032
        Me.lblTotalGrilla.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTotalGrilla.Visible = False
        '
        'btn5
        '
        Me.btn5.Image = CType(resources.GetObject("btn5.Image"), System.Drawing.Image)
        Me.btn5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn5.Location = New System.Drawing.Point(98, 147)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(137, 57)
        Me.btn5.TabIndex = 1035
        Me.btn5.Text = "Pagos Entre Fechas por " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Proveedores" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btn5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn5.UseVisualStyleBackColor = True
        '
        'frmConsultaProveedorMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(839, 263)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn10)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.lblTotalGrilla)
        Me.Controls.Add(Me.lblSaldoActual)
        Me.Controls.Add(Me.lblSaldoAnterior)
        Me.Controls.Add(Me.dtpFecha_hasta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpFecha_desde)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblid_proveedor)
        Me.Controls.Add(Me.cmbProveedor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btnSalir)
        Me.Name = "frmConsultaProveedorMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultas de Proveedores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btn4 As System.Windows.Forms.Button
    Friend WithEvents btn7 As System.Windows.Forms.Button
    Friend WithEvents btn6 As System.Windows.Forms.Button
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Public WithEvents lblid_proveedor As System.Windows.Forms.Label
    Friend WithEvents cmbProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha_desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha_hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn8 As System.Windows.Forms.Button
    Friend WithEvents btn10 As System.Windows.Forms.Button
    Friend WithEvents lblSaldoAnterior As System.Windows.Forms.Label
    Friend WithEvents lblSaldoActual As System.Windows.Forms.Label
    Friend WithEvents lblTotalGrilla As System.Windows.Forms.Label
    Friend WithEvents btn5 As System.Windows.Forms.Button
End Class
