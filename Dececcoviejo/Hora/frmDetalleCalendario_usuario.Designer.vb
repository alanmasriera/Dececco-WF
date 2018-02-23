<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleCalendario_usuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleCalendario_usuario))
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblid_usuario = New System.Windows.Forms.Label()
        Me.btnBuscausuario = New System.Windows.Forms.Button()
        Me.cmbusuario = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_usuario = New System.Windows.Forms.Label()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.etiquetafecha = New System.Windows.Forms.Label()
        Me.lblid_dia = New System.Windows.Forms.Label()
        Me.btnBuscadia = New System.Windows.Forms.Button()
        Me.cmbdia = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_dia = New System.Windows.Forms.Label()
        Me.txtanio = New System.Windows.Forms.TextBox()
        Me.etiquetaanio = New System.Windows.Forms.Label()
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
        Me.btnSalir.Location = New System.Drawing.Point(499, 270)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(81, 69)
        Me.btnSalir.TabIndex = 51
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
        Me.btnGuardar.Location = New System.Drawing.Point(392, 270)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(78, 69)
        Me.btnGuardar.TabIndex = 50
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(12, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(568, 230)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lblid_usuario
        '
        Me.lblid_usuario.AutoSize = True
        Me.lblid_usuario.BackColor = System.Drawing.Color.Red
        Me.lblid_usuario.Location = New System.Drawing.Point(370, 48)
        Me.lblid_usuario.Name = "lblid_usuario"
        Me.lblid_usuario.Size = New System.Drawing.Size(13, 13)
        Me.lblid_usuario.TabIndex = 500
        Me.lblid_usuario.Text = "0"
        Me.lblid_usuario.Visible = False
        '
        'btnBuscausuario
        '
        Me.btnBuscausuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscausuario.Image = CType(resources.GetObject("btnBuscausuario.Image"), System.Drawing.Image)
        Me.btnBuscausuario.Location = New System.Drawing.Point(505, 48)
        Me.btnBuscausuario.Name = "btnBuscausuario"
        Me.btnBuscausuario.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscausuario.TabIndex = 60
        Me.btnBuscausuario.UseVisualStyleBackColor = True
        '
        'cmbusuario
        '
        Me.cmbusuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbusuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbusuario.FormattingEnabled = True
        Me.cmbusuario.Location = New System.Drawing.Point(161, 48)
        Me.cmbusuario.Name = "cmbusuario"
        Me.cmbusuario.Size = New System.Drawing.Size(329, 21)
        Me.cmbusuario.TabIndex = 4
        '
        'etiquetaid_usuario
        '
        Me.etiquetaid_usuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_usuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_usuario.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_usuario.Location = New System.Drawing.Point(28, 48)
        Me.etiquetaid_usuario.Name = "etiquetaid_usuario"
        Me.etiquetaid_usuario.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_usuario.TabIndex = 501
        Me.etiquetaid_usuario.Text = "Usuario"
        Me.etiquetaid_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpfecha
        '
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha.Location = New System.Drawing.Point(161, 91)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(93, 20)
        Me.dtpfecha.TabIndex = 5
        '
        'etiquetafecha
        '
        Me.etiquetafecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetafecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetafecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetafecha.ForeColor = System.Drawing.Color.Black
        Me.etiquetafecha.Location = New System.Drawing.Point(28, 91)
        Me.etiquetafecha.Name = "etiquetafecha"
        Me.etiquetafecha.Size = New System.Drawing.Size(127, 21)
        Me.etiquetafecha.TabIndex = 502
        Me.etiquetafecha.Text = "Fecha"
        Me.etiquetafecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_dia
        '
        Me.lblid_dia.AutoSize = True
        Me.lblid_dia.BackColor = System.Drawing.Color.Red
        Me.lblid_dia.Location = New System.Drawing.Point(370, 134)
        Me.lblid_dia.Name = "lblid_dia"
        Me.lblid_dia.Size = New System.Drawing.Size(13, 13)
        Me.lblid_dia.TabIndex = 503
        Me.lblid_dia.Text = "0"
        Me.lblid_dia.Visible = False
        '
        'btnBuscadia
        '
        Me.btnBuscadia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscadia.Image = CType(resources.GetObject("btnBuscadia.Image"), System.Drawing.Image)
        Me.btnBuscadia.Location = New System.Drawing.Point(505, 134)
        Me.btnBuscadia.Name = "btnBuscadia"
        Me.btnBuscadia.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscadia.TabIndex = 61
        Me.btnBuscadia.UseVisualStyleBackColor = True
        '
        'cmbdia
        '
        Me.cmbdia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbdia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbdia.FormattingEnabled = True
        Me.cmbdia.Location = New System.Drawing.Point(161, 134)
        Me.cmbdia.Name = "cmbdia"
        Me.cmbdia.Size = New System.Drawing.Size(329, 21)
        Me.cmbdia.TabIndex = 6
        '
        'etiquetaid_dia
        '
        Me.etiquetaid_dia.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_dia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_dia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_dia.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_dia.Location = New System.Drawing.Point(28, 134)
        Me.etiquetaid_dia.Name = "etiquetaid_dia"
        Me.etiquetaid_dia.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_dia.TabIndex = 504
        Me.etiquetaid_dia.Text = "Dia"
        Me.etiquetaid_dia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtanio
        '
        Me.txtanio.BackColor = System.Drawing.Color.White
        Me.txtanio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtanio.ForeColor = System.Drawing.Color.Blue
        Me.txtanio.Location = New System.Drawing.Point(161, 177)
        Me.txtanio.MaxLength = 50
        Me.txtanio.Name = "txtanio"
        Me.txtanio.Size = New System.Drawing.Size(222, 31)
        Me.txtanio.TabIndex = 7
        Me.txtanio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetaanio
        '
        Me.etiquetaanio.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaanio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaanio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaanio.ForeColor = System.Drawing.Color.Black
        Me.etiquetaanio.Location = New System.Drawing.Point(28, 177)
        Me.etiquetaanio.Name = "etiquetaanio"
        Me.etiquetaanio.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaanio.TabIndex = 505
        Me.etiquetaanio.Text = "Anio"
        Me.etiquetaanio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmDetalleCalendario_usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 350)
        Me.Controls.Add(Me.lblid_usuario)
        Me.Controls.Add(Me.btnBuscausuario)
        Me.Controls.Add(Me.cmbusuario)
        Me.Controls.Add(Me.etiquetaid_usuario)
        Me.Controls.Add(Me.dtpfecha)
        Me.Controls.Add(Me.etiquetafecha)
        Me.Controls.Add(Me.lblid_dia)
        Me.Controls.Add(Me.btnBuscadia)
        Me.Controls.Add(Me.cmbdia)
        Me.Controls.Add(Me.etiquetaid_dia)
        Me.Controls.Add(Me.txtanio)
        Me.Controls.Add(Me.etiquetaanio)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDetalleCalendario_usuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetalleCalendario_usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Friend WithEvents lblid_usuario As System.Windows.Forms.Label
   Friend WithEvents btnBuscausuario As System.Windows.Forms.Button
   Friend WithEvents cmbusuario As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_usuario As System.Windows.Forms.Label
   Protected WithEvents dtpfecha As System.Windows.Forms.DateTimePicker
   Friend WithEvents etiquetafecha As System.Windows.Forms.Label
   Friend WithEvents lblid_dia As System.Windows.Forms.Label
   Friend WithEvents btnBuscadia As System.Windows.Forms.Button
   Friend WithEvents cmbdia As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_dia As System.Windows.Forms.Label
   Protected WithEvents txtanio As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaanio As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
End Class

