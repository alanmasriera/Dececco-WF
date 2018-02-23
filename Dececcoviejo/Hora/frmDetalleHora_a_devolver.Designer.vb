<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleHora_a_devolver
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleHora_a_devolver))
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblid_usuario = New System.Windows.Forms.Label()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.etiquetafecha = New System.Windows.Forms.Label()
        Me.txthora = New System.Windows.Forms.TextBox()
        Me.etiquetahora = New System.Windows.Forms.Label()
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
        Me.btnSalir.Location = New System.Drawing.Point(499, 177)
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
        Me.btnGuardar.Location = New System.Drawing.Point(392, 177)
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
        Me.GroupBox1.Size = New System.Drawing.Size(568, 131)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lblid_usuario
        '
        Me.lblid_usuario.AutoSize = True
        Me.lblid_usuario.BackColor = System.Drawing.Color.Red
        Me.lblid_usuario.Location = New System.Drawing.Point(370, 1)
        Me.lblid_usuario.Name = "lblid_usuario"
        Me.lblid_usuario.Size = New System.Drawing.Size(13, 13)
        Me.lblid_usuario.TabIndex = 500
        Me.lblid_usuario.Text = "0"
        Me.lblid_usuario.Visible = False
        '
        'dtpfecha
        '
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha.Location = New System.Drawing.Point(160, 46)
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
        Me.etiquetafecha.Location = New System.Drawing.Point(27, 46)
        Me.etiquetafecha.Name = "etiquetafecha"
        Me.etiquetafecha.Size = New System.Drawing.Size(127, 21)
        Me.etiquetafecha.TabIndex = 502
        Me.etiquetafecha.Text = "Fecha"
        Me.etiquetafecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txthora
        '
        Me.txthora.BackColor = System.Drawing.Color.White
        Me.txthora.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthora.ForeColor = System.Drawing.Color.Blue
        Me.txthora.Location = New System.Drawing.Point(160, 89)
        Me.txthora.MaxLength = 50
        Me.txthora.Name = "txthora"
        Me.txthora.Size = New System.Drawing.Size(222, 31)
        Me.txthora.TabIndex = 6
        Me.txthora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetahora
        '
        Me.etiquetahora.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetahora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetahora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetahora.ForeColor = System.Drawing.Color.Black
        Me.etiquetahora.Location = New System.Drawing.Point(27, 89)
        Me.etiquetahora.Name = "etiquetahora"
        Me.etiquetahora.Size = New System.Drawing.Size(127, 21)
        Me.etiquetahora.TabIndex = 503
        Me.etiquetahora.Text = "Hora"
        Me.etiquetahora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmDetalleHora_a_devolver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 260)
        Me.Controls.Add(Me.lblid_usuario)
        Me.Controls.Add(Me.dtpfecha)
        Me.Controls.Add(Me.etiquetafecha)
        Me.Controls.Add(Me.txthora)
        Me.Controls.Add(Me.etiquetahora)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDetalleHora_a_devolver"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetalleHora_a_devolver"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Friend WithEvents lblid_usuario As System.Windows.Forms.Label
    Protected WithEvents dtpfecha As System.Windows.Forms.DateTimePicker
   Friend WithEvents etiquetafecha As System.Windows.Forms.Label
   Protected WithEvents txthora As System.Windows.Forms.TextBox
   Friend WithEvents etiquetahora As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
End Class

