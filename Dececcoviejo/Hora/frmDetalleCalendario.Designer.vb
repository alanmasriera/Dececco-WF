<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleCalendario
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
       Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleCalendario))
       Me.btnSalir = New System.Windows.Forms.Button
       Me.btnGuardar = New System.Windows.Forms.Button
       Me.GroupBox1 = New System.Windows.Forms.GroupBox
       Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
       Me.dtpfecha = New System.Windows.Forms.DateTimePicker
       Me.etiquetafecha = New System.Windows.Forms.Label
       Me.lblid_dia = New System.Windows.Forms.Label
       Me.btnBuscadia = New System.Windows.Forms.Button
       Me.cmbdia = New System.Windows.Forms.ComboBox
       Me.etiquetaid_dia = New System.Windows.Forms.Label
       Me.txtanio = New System.Windows.Forms.TextBox
       Me.etiquetaanio = New System.Windows.Forms.Label
       Me.SuspendLayout()
       '
       'dtpfecha
       '
       Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
       Me.dtpfecha.Location = New System.Drawing.Point(161, 48)
       Me.dtpfecha.Name = "cmbfecha"
       Me.dtpfecha.Size = New System.Drawing.Size(93, 20)
       Me.dtpfecha.TabIndex = 4
       '
       'etiquietafecha
       '
       Me.etiquetafecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
       Me.etiquetafecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
       Me.etiquetafecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetafecha.ForeColor = System.Drawing.Color.Black
       Me.etiquetafecha.Location = New System.Drawing.Point(28, 48)
       Me.etiquetafecha.Name = "etiquetafecha"
       Me.etiquetafecha.Size = New System.Drawing.Size(127, 21)
       Me.etiquetafecha.TabIndex = 500
       Me.etiquetafecha.Text = "Fecha"
       Me.etiquetafecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblid_dia
       '
       Me.lblid_dia.AutoSize = True
       Me.lblid_dia.BackColor = System.Drawing.Color.Red
       Me.lblid_dia.Location = New System.Drawing.Point(370, 91)
       Me.lblid_dia.Name = "lblid_dia"
       Me.lblid_dia.Size = New System.Drawing.Size(13, 13)
       Me.lblid_dia.TabIndex = 501
       Me.lblid_dia.Text = "0"
       Me.lblid_dia.Visible = False
       '
       'btnBuscadia
       '
       Me.btnBuscadia.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscadia.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscadia.Location = New System.Drawing.Point(505, 91)
       Me.btnBuscadia.Name = "btnBuscadia"
       Me.btnBuscadia.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscadia.TabIndex = 60
       Me.btnBuscadia.UseVisualStyleBackColor = True
       '
       'cmbdia
       '
       Me.cmbdia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbdia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbdia.FormattingEnabled = True
       Me.cmbdia.Location = New System.Drawing.Point(161, 91)
       Me.cmbdia.Name = "cmbdia"
       Me.cmbdia.Size = New System.Drawing.Size(329, 21)
       Me.cmbdia.TabIndex = 5
       '
       'etiquietaid_dia
       '
       Me.etiquetaid_dia.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
       Me.etiquetaid_dia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
       Me.etiquetaid_dia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_dia.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_dia.Location = New System.Drawing.Point(28, 91)
       Me.etiquetaid_dia.Name = "etiquetaid_dia"
       Me.etiquetaid_dia.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_dia.TabIndex = 502
       Me.etiquetaid_dia.Text = "Dia"
       Me.etiquetaid_dia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtanio
       '
       Me.txtanio.BackColor = System.Drawing.Color.White
       Me.txtanio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtanio.ForeColor = System.Drawing.Color.Blue
       Me.txtanio.Location = New System.Drawing.Point(161, 134)
       Me.txtanio.MaxLength = 50
       Me.txtanio.Name = "txtanio"
       Me.txtanio.Size = New System.Drawing.Size(222, 31)
       Me.txtanio.TabIndex = 6
       Me.txtanio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietaanio
       '
       Me.etiquetaanio.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
       Me.etiquetaanio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
       Me.etiquetaanio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaanio.ForeColor = System.Drawing.Color.Black
       Me.etiquetaanio.Location = New System.Drawing.Point(28, 134)
       Me.etiquetaanio.Name = "etiquetaanio"
       Me.etiquetaanio.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaanio.TabIndex = 503
       Me.etiquetaanio.Text = "Anio"
       Me.etiquetaanio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'btnSalir
       '
       Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
       Me.btnSalir.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.btnSalir.ForeColor = System.Drawing.Color.Black
       Me.btnSalir.Image = CType(Resources.GetObject("btnSalir.Image"), System.Drawing.Image)
       Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
       Me.btnSalir.Location = New System.Drawing.Point(499, 227)
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
       Me.btnGuardar.Image = CType(Resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
       Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
       Me.btnGuardar.Location = New System.Drawing.Point(392,227)
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
       Me.GroupBox1.Size = New System.Drawing.Size(568, 187)
       Me.GroupBox1.TabIndex = 0
       Me.GroupBox1.TabStop = False
       '
       'frmDetalleCalendario
       '
       Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
       Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
       Me.ClientSize = New System.Drawing.Size(600, 307)
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
       Me.Name = "frmDetalleCalendario"
       Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetalleCalendario" & vgNombreFormulario
       Me.ResumeLayout(False)
       Me.PerformLayout()

   End Sub
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

