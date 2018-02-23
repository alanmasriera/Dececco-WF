<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleMovimiento_hora
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleMovimiento_hora))
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker
        Me.etiquetafecha = New System.Windows.Forms.Label
        Me.lblid_empleado = New System.Windows.Forms.Label
        Me.btnBuscaempleado = New System.Windows.Forms.Button
        Me.cmbempleado = New System.Windows.Forms.ComboBox
        Me.etiquetaid_empleado = New System.Windows.Forms.Label
        Me.lblid_obra = New System.Windows.Forms.Label
        Me.btnBuscaobra = New System.Windows.Forms.Button
        Me.cmbobra = New System.Windows.Forms.ComboBox
        Me.etiquetaid_obra = New System.Windows.Forms.Label
        Me.lblid_dia = New System.Windows.Forms.Label
        Me.btnBuscadia = New System.Windows.Forms.Button
        Me.cmbdia = New System.Windows.Forms.ComboBox
        Me.etiquetaid_dia = New System.Windows.Forms.Label
        Me.dtpentrada = New System.Windows.Forms.DateTimePicker
        Me.etiquetaentrada = New System.Windows.Forms.Label
        Me.dtpsalida = New System.Windows.Forms.DateTimePicker
        Me.etiquetasalida = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtHora2 = New System.Windows.Forms.TextBox
        Me.txtHora1 = New System.Windows.Forms.TextBox
        Me.btnControl = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
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
        Me.btnSalir.Location = New System.Drawing.Point(699, 298)
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
        Me.btnGuardar.Location = New System.Drawing.Point(592, 298)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(78, 69)
        Me.btnGuardar.TabIndex = 20
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(557, 280)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'dtpfecha
        '
        Me.dtpfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha.Location = New System.Drawing.Point(166, 29)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(166, 31)
        Me.dtpfecha.TabIndex = 4
        '
        'etiquetafecha
        '
        Me.etiquetafecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetafecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetafecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetafecha.ForeColor = System.Drawing.Color.Black
        Me.etiquetafecha.Location = New System.Drawing.Point(33, 29)
        Me.etiquetafecha.Name = "etiquetafecha"
        Me.etiquetafecha.Size = New System.Drawing.Size(127, 21)
        Me.etiquetafecha.TabIndex = 500
        Me.etiquetafecha.Text = "Fecha"
        Me.etiquetafecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_empleado
        '
        Me.lblid_empleado.AutoSize = True
        Me.lblid_empleado.BackColor = System.Drawing.Color.Red
        Me.lblid_empleado.Location = New System.Drawing.Point(375, 72)
        Me.lblid_empleado.Name = "lblid_empleado"
        Me.lblid_empleado.Size = New System.Drawing.Size(13, 13)
        Me.lblid_empleado.TabIndex = 501
        Me.lblid_empleado.Text = "0"
        Me.lblid_empleado.Visible = False
        '
        'btnBuscaempleado
        '
        Me.btnBuscaempleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscaempleado.Enabled = False
        Me.btnBuscaempleado.Image = CType(resources.GetObject("btnBuscaempleado.Image"), System.Drawing.Image)
        Me.btnBuscaempleado.Location = New System.Drawing.Point(505, 73)
        Me.btnBuscaempleado.Name = "btnBuscaempleado"
        Me.btnBuscaempleado.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscaempleado.TabIndex = 30
        Me.btnBuscaempleado.UseVisualStyleBackColor = True
        '
        'cmbempleado
        '
        Me.cmbempleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbempleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbempleado.Enabled = False
        Me.cmbempleado.FormattingEnabled = True
        Me.cmbempleado.Location = New System.Drawing.Point(166, 72)
        Me.cmbempleado.Name = "cmbempleado"
        Me.cmbempleado.Size = New System.Drawing.Size(329, 21)
        Me.cmbempleado.TabIndex = 5
        '
        'etiquetaid_empleado
        '
        Me.etiquetaid_empleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_empleado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_empleado.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_empleado.Location = New System.Drawing.Point(33, 72)
        Me.etiquetaid_empleado.Name = "etiquetaid_empleado"
        Me.etiquetaid_empleado.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_empleado.TabIndex = 502
        Me.etiquetaid_empleado.Text = "Empleado"
        Me.etiquetaid_empleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_obra
        '
        Me.lblid_obra.AutoSize = True
        Me.lblid_obra.BackColor = System.Drawing.Color.Red
        Me.lblid_obra.Location = New System.Drawing.Point(375, 115)
        Me.lblid_obra.Name = "lblid_obra"
        Me.lblid_obra.Size = New System.Drawing.Size(13, 13)
        Me.lblid_obra.TabIndex = 503
        Me.lblid_obra.Text = "0"
        Me.lblid_obra.Visible = False
        '
        'btnBuscaobra
        '
        Me.btnBuscaobra.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscaobra.Image = CType(resources.GetObject("btnBuscaobra.Image"), System.Drawing.Image)
        Me.btnBuscaobra.Location = New System.Drawing.Point(505, 116)
        Me.btnBuscaobra.Name = "btnBuscaobra"
        Me.btnBuscaobra.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscaobra.TabIndex = 31
        Me.btnBuscaobra.UseVisualStyleBackColor = True
        '
        'cmbobra
        '
        Me.cmbobra.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbobra.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbobra.FormattingEnabled = True
        Me.cmbobra.Location = New System.Drawing.Point(166, 115)
        Me.cmbobra.Name = "cmbobra"
        Me.cmbobra.Size = New System.Drawing.Size(329, 21)
        Me.cmbobra.TabIndex = 6
        '
        'etiquetaid_obra
        '
        Me.etiquetaid_obra.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_obra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_obra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_obra.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_obra.Location = New System.Drawing.Point(33, 115)
        Me.etiquetaid_obra.Name = "etiquetaid_obra"
        Me.etiquetaid_obra.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_obra.TabIndex = 504
        Me.etiquetaid_obra.Text = "Obra"
        Me.etiquetaid_obra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_dia
        '
        Me.lblid_dia.AutoSize = True
        Me.lblid_dia.BackColor = System.Drawing.Color.Red
        Me.lblid_dia.Location = New System.Drawing.Point(375, 158)
        Me.lblid_dia.Name = "lblid_dia"
        Me.lblid_dia.Size = New System.Drawing.Size(13, 13)
        Me.lblid_dia.TabIndex = 505
        Me.lblid_dia.Text = "0"
        Me.lblid_dia.Visible = False
        '
        'btnBuscadia
        '
        Me.btnBuscadia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscadia.Image = CType(resources.GetObject("btnBuscadia.Image"), System.Drawing.Image)
        Me.btnBuscadia.Location = New System.Drawing.Point(505, 159)
        Me.btnBuscadia.Name = "btnBuscadia"
        Me.btnBuscadia.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscadia.TabIndex = 32
        Me.btnBuscadia.UseVisualStyleBackColor = True
        '
        'cmbdia
        '
        Me.cmbdia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbdia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbdia.FormattingEnabled = True
        Me.cmbdia.Location = New System.Drawing.Point(166, 158)
        Me.cmbdia.Name = "cmbdia"
        Me.cmbdia.Size = New System.Drawing.Size(329, 21)
        Me.cmbdia.TabIndex = 7
        '
        'etiquetaid_dia
        '
        Me.etiquetaid_dia.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_dia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_dia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_dia.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_dia.Location = New System.Drawing.Point(33, 158)
        Me.etiquetaid_dia.Name = "etiquetaid_dia"
        Me.etiquetaid_dia.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_dia.TabIndex = 506
        Me.etiquetaid_dia.Text = "Dia"
        Me.etiquetaid_dia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpentrada
        '
        Me.dtpentrada.CustomFormat = "HH:mm"
        Me.dtpentrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpentrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpentrada.Location = New System.Drawing.Point(166, 236)
        Me.dtpentrada.Name = "dtpentrada"
        Me.dtpentrada.Size = New System.Drawing.Size(102, 31)
        Me.dtpentrada.TabIndex = 12
        '
        'etiquetaentrada
        '
        Me.etiquetaentrada.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaentrada.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaentrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaentrada.ForeColor = System.Drawing.Color.Black
        Me.etiquetaentrada.Location = New System.Drawing.Point(33, 236)
        Me.etiquetaentrada.Name = "etiquetaentrada"
        Me.etiquetaentrada.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaentrada.TabIndex = 507
        Me.etiquetaentrada.Text = "Entrada"
        Me.etiquetaentrada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpsalida
        '
        Me.dtpsalida.CustomFormat = "HH:mm"
        Me.dtpsalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpsalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpsalida.Location = New System.Drawing.Point(438, 236)
        Me.dtpsalida.Name = "dtpsalida"
        Me.dtpsalida.Size = New System.Drawing.Size(102, 31)
        Me.dtpsalida.TabIndex = 13
        '
        'etiquetasalida
        '
        Me.etiquetasalida.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetasalida.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetasalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetasalida.ForeColor = System.Drawing.Color.Black
        Me.etiquetasalida.Location = New System.Drawing.Point(305, 236)
        Me.etiquetasalida.Name = "etiquetasalida"
        Me.etiquetasalida.Size = New System.Drawing.Size(127, 21)
        Me.etiquetasalida.TabIndex = 508
        Me.etiquetasalida.Text = "Salida"
        Me.etiquetasalida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(174, 298)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 21)
        Me.Label1.TabIndex = 522
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(174, 338)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 21)
        Me.Label2.TabIndex = 523
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Visible = False
        '
        'txtHora2
        '
        Me.txtHora2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtHora2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHora2.ForeColor = System.Drawing.Color.Blue
        Me.txtHora2.Location = New System.Drawing.Point(293, 338)
        Me.txtHora2.Name = "txtHora2"
        Me.txtHora2.ReadOnly = True
        Me.txtHora2.Size = New System.Drawing.Size(98, 29)
        Me.txtHora2.TabIndex = 521
        Me.txtHora2.Visible = False
        '
        'txtHora1
        '
        Me.txtHora1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtHora1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHora1.ForeColor = System.Drawing.Color.Blue
        Me.txtHora1.Location = New System.Drawing.Point(293, 298)
        Me.txtHora1.Name = "txtHora1"
        Me.txtHora1.ReadOnly = True
        Me.txtHora1.Size = New System.Drawing.Size(98, 29)
        Me.txtHora1.TabIndex = 520
        Me.txtHora1.Visible = False
        '
        'btnControl
        '
        Me.btnControl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnControl.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnControl.ForeColor = System.Drawing.Color.Black
        Me.btnControl.Image = CType(resources.GetObject("btnControl.Image"), System.Drawing.Image)
        Me.btnControl.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnControl.Location = New System.Drawing.Point(36, 298)
        Me.btnControl.Name = "btnControl"
        Me.btnControl.Size = New System.Drawing.Size(98, 69)
        Me.btnControl.TabIndex = 15
        Me.btnControl.Text = "Controlar"
        Me.btnControl.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnControl.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(166, 197)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 24)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "7:30 a 16:30"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(33, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 21)
        Me.Label3.TabIndex = 525
        Me.Label3.Text = "Atajos"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(305, 197)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 24)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "15:00 a 24:00"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmDetalleMovimiento_hora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 379)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtHora2)
        Me.Controls.Add(Me.txtHora1)
        Me.Controls.Add(Me.btnControl)
        Me.Controls.Add(Me.dtpfecha)
        Me.Controls.Add(Me.etiquetafecha)
        Me.Controls.Add(Me.lblid_empleado)
        Me.Controls.Add(Me.btnBuscaempleado)
        Me.Controls.Add(Me.cmbempleado)
        Me.Controls.Add(Me.etiquetaid_empleado)
        Me.Controls.Add(Me.lblid_obra)
        Me.Controls.Add(Me.btnBuscaobra)
        Me.Controls.Add(Me.cmbobra)
        Me.Controls.Add(Me.etiquetaid_obra)
        Me.Controls.Add(Me.lblid_dia)
        Me.Controls.Add(Me.btnBuscadia)
        Me.Controls.Add(Me.cmbdia)
        Me.Controls.Add(Me.etiquetaid_dia)
        Me.Controls.Add(Me.dtpentrada)
        Me.Controls.Add(Me.etiquetaentrada)
        Me.Controls.Add(Me.dtpsalida)
        Me.Controls.Add(Me.etiquetasalida)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDetalleMovimiento_hora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetalleMovimiento_hora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Protected WithEvents dtpfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents etiquetafecha As System.Windows.Forms.Label
    Friend WithEvents lblid_empleado As System.Windows.Forms.Label
    Friend WithEvents btnBuscaempleado As System.Windows.Forms.Button
    Friend WithEvents cmbempleado As System.Windows.Forms.ComboBox
    Friend WithEvents etiquetaid_empleado As System.Windows.Forms.Label
    Friend WithEvents lblid_obra As System.Windows.Forms.Label
    Friend WithEvents btnBuscaobra As System.Windows.Forms.Button
    Friend WithEvents cmbobra As System.Windows.Forms.ComboBox
    Friend WithEvents etiquetaid_obra As System.Windows.Forms.Label
    Friend WithEvents lblid_dia As System.Windows.Forms.Label
    Friend WithEvents btnBuscadia As System.Windows.Forms.Button
    Friend WithEvents cmbdia As System.Windows.Forms.ComboBox
    Friend WithEvents etiquetaid_dia As System.Windows.Forms.Label
    Protected WithEvents dtpentrada As System.Windows.Forms.DateTimePicker
    Friend WithEvents etiquetaentrada As System.Windows.Forms.Label
    Protected WithEvents dtpsalida As System.Windows.Forms.DateTimePicker
    Friend WithEvents etiquetasalida As System.Windows.Forms.Label
    Protected WithEvents btnSalir As System.Windows.Forms.Button
    Protected WithEvents btnGuardar As System.Windows.Forms.Button
    Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtHora2 As System.Windows.Forms.TextBox
    Friend WithEvents txtHora1 As System.Windows.Forms.TextBox
    Protected WithEvents btnControl As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class

