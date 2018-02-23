<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleTipo_empleado
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
       Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleTipo_empleado))
       Me.btnSalir = New System.Windows.Forms.Button
       Me.btnGuardar = New System.Windows.Forms.Button
       Me.GroupBox1 = New System.Windows.Forms.GroupBox
       Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
       Me.txtnombre_tipo_empleado = New System.Windows.Forms.TextBox
       Me.etiquetanombre_tipo_empleado = New System.Windows.Forms.Label
       Me.txtdescripcion = New System.Windows.Forms.TextBox
       Me.etiquetadescripcion = New System.Windows.Forms.Label
       Me.txtporcentaje = New System.Windows.Forms.TextBox
       Me.etiquetaporcentaje = New System.Windows.Forms.Label
       Me.SuspendLayout()
       '
       'txtnombre_tipo_empleado
       '
       Me.txtnombre_tipo_empleado.BackColor = System.Drawing.Color.White
       Me.txtnombre_tipo_empleado.Location = New System.Drawing.Point(161, 48)
       Me.txtnombre_tipo_empleado.MaxLength = 50
       Me.txtnombre_tipo_empleado.Name = "txtnombre_tipo_empleado"
       Me.txtnombre_tipo_empleado.Size = New System.Drawing.Size(385, 20)
       Me.txtnombre_tipo_empleado.TabIndex = 4
       '
       'etiquietanombre_tipo_empleado
       '
       Me.etiquetanombre_tipo_empleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
       Me.etiquetanombre_tipo_empleado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
       Me.etiquetanombre_tipo_empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetanombre_tipo_empleado.ForeColor = System.Drawing.Color.Black
       Me.etiquetanombre_tipo_empleado.Location = New System.Drawing.Point(28, 48)
       Me.etiquetanombre_tipo_empleado.Name = "etiquetanombre_tipo_empleado"
       Me.etiquetanombre_tipo_empleado.Size = New System.Drawing.Size(127, 21)
       Me.etiquetanombre_tipo_empleado.TabIndex = 500
       Me.etiquetanombre_tipo_empleado.Text = "Nombre_tipo_empleado"
       Me.etiquetanombre_tipo_empleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtdescripcion
       '
       Me.txtdescripcion.BackColor = System.Drawing.Color.White
       Me.txtdescripcion.Location = New System.Drawing.Point(161, 91)
       Me.txtdescripcion.MaxLength = 50
       Me.txtdescripcion.Name = "txtdescripcion"
       Me.txtdescripcion.Size = New System.Drawing.Size(385, 20)
       Me.txtdescripcion.TabIndex = 5
       '
       'etiquietadescripcion
       '
       Me.etiquetadescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
       Me.etiquetadescripcion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
       Me.etiquetadescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetadescripcion.ForeColor = System.Drawing.Color.Black
       Me.etiquetadescripcion.Location = New System.Drawing.Point(28, 91)
       Me.etiquetadescripcion.Name = "etiquetadescripcion"
       Me.etiquetadescripcion.Size = New System.Drawing.Size(127, 21)
       Me.etiquetadescripcion.TabIndex = 501
       Me.etiquetadescripcion.Text = "Descripcion"
       Me.etiquetadescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtporcentaje
       '
       Me.txtporcentaje.BackColor = System.Drawing.Color.White
       Me.txtporcentaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtporcentaje.ForeColor = System.Drawing.Color.Blue
       Me.txtporcentaje.Location = New System.Drawing.Point(161, 134)
       Me.txtporcentaje.MaxLength = 50
       Me.txtporcentaje.Name = "txtporcentaje"
       Me.txtporcentaje.Size = New System.Drawing.Size(222, 31)
       Me.txtporcentaje.TabIndex = 6
       Me.txtporcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietaporcentaje
       '
       Me.etiquetaporcentaje.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
       Me.etiquetaporcentaje.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
       Me.etiquetaporcentaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaporcentaje.ForeColor = System.Drawing.Color.Black
       Me.etiquetaporcentaje.Location = New System.Drawing.Point(28, 134)
       Me.etiquetaporcentaje.Name = "etiquetaporcentaje"
       Me.etiquetaporcentaje.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaporcentaje.TabIndex = 502
       Me.etiquetaporcentaje.Text = "Porcentaje"
       Me.etiquetaporcentaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
       Me.btnGuardar.Image = CType(Resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
       Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
       Me.btnGuardar.Location = New System.Drawing.Point(392,227)
       Me.btnGuardar.Name = "btnGuardar"
       Me.btnGuardar.Size = New System.Drawing.Size(78, 69)
       Me.btnGuardar.TabIndex = 20
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
       'frmDetalleTipo_empleado
       '
       Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
       Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
       Me.ClientSize = New System.Drawing.Size(600, 307)
       Me.Controls.Add(Me.txtnombre_tipo_empleado)
       Me.Controls.Add(Me.etiquetanombre_tipo_empleado)
       Me.Controls.Add(Me.txtdescripcion)
       Me.Controls.Add(Me.etiquetadescripcion)
       Me.Controls.Add(Me.txtporcentaje)
       Me.Controls.Add(Me.etiquetaporcentaje)
       Me.Controls.Add(Me.btnSalir)
       Me.Controls.Add(Me.btnGuardar)
       Me.Controls.Add(Me.GroupBox1)
       Me.Name = "frmDetalleTipo_empleado"
       Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
       Me.Text = "frmDetalleTipo_empleado"
       Me.ResumeLayout(False)
       Me.PerformLayout()

   End Sub
   Protected WithEvents txtnombre_tipo_empleado As System.Windows.Forms.TextBox
   Friend WithEvents etiquetanombre_tipo_empleado As System.Windows.Forms.Label
   Protected WithEvents txtdescripcion As System.Windows.Forms.TextBox
   Friend WithEvents etiquetadescripcion As System.Windows.Forms.Label
   Protected WithEvents txtporcentaje As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaporcentaje As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
End Class

