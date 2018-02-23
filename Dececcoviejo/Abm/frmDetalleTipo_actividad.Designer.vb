<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleTipo_actividad
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
       Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleTipo_actividad))
       Me.btnSalir = New System.Windows.Forms.Button
       Me.btnGuardar = New System.Windows.Forms.Button
       Me.GroupBox1 = New System.Windows.Forms.GroupBox
       Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
       Me.txtdescripcion = New System.Windows.Forms.TextBox
       Me.etiquetadescripcion = New System.Windows.Forms.Label
       Me.txtcriticidad = New System.Windows.Forms.TextBox
       Me.etiquetacriticidad = New System.Windows.Forms.Label
       Me.SuspendLayout()
       '
       'txtdescripcion
       '
       Me.txtdescripcion.BackColor = System.Drawing.Color.White
       Me.txtdescripcion.Location = New System.Drawing.Point(161, 48)
       Me.txtdescripcion.MaxLength = 50
       Me.txtdescripcion.Name = "txtdescripcion"
       Me.txtdescripcion.Size = New System.Drawing.Size(385, 20)
       Me.txtdescripcion.TabIndex = 4
       '
       'etiquietadescripcion
       '
       Me.etiquetadescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
       Me.etiquetadescripcion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
       Me.etiquetadescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetadescripcion.ForeColor = System.Drawing.Color.Black
       Me.etiquetadescripcion.Location = New System.Drawing.Point(28, 48)
       Me.etiquetadescripcion.Name = "etiquetadescripcion"
       Me.etiquetadescripcion.Size = New System.Drawing.Size(127, 21)
       Me.etiquetadescripcion.TabIndex = 500
       Me.etiquetadescripcion.Text = "Descripcion"
       Me.etiquetadescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtcriticidad
       '
       Me.txtcriticidad.BackColor = System.Drawing.Color.White
       Me.txtcriticidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtcriticidad.ForeColor = System.Drawing.Color.Blue
       Me.txtcriticidad.Location = New System.Drawing.Point(161, 91)
       Me.txtcriticidad.MaxLength = 50
       Me.txtcriticidad.Name = "txtcriticidad"
       Me.txtcriticidad.Size = New System.Drawing.Size(222, 31)
       Me.txtcriticidad.TabIndex = 5
       Me.txtcriticidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietacriticidad
       '
       Me.etiquetacriticidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
       Me.etiquetacriticidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
       Me.etiquetacriticidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetacriticidad.ForeColor = System.Drawing.Color.Black
       Me.etiquetacriticidad.Location = New System.Drawing.Point(28, 91)
       Me.etiquetacriticidad.Name = "etiquetacriticidad"
       Me.etiquetacriticidad.Size = New System.Drawing.Size(127, 21)
       Me.etiquetacriticidad.TabIndex = 501
       Me.etiquetacriticidad.Text = "Criticidad"
       Me.etiquetacriticidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
       Me.btnSalir.Location = New System.Drawing.Point(499, 184)
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
       Me.btnGuardar.Location = New System.Drawing.Point(392,184)
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
       Me.GroupBox1.Size = New System.Drawing.Size(568, 144)
       Me.GroupBox1.TabIndex = 0
       Me.GroupBox1.TabStop = False
       '
       'frmDetalleTipo_actividad
       '
       Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
       Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
       Me.ClientSize = New System.Drawing.Size(600, 264)
       Me.Controls.Add(Me.txtdescripcion)
       Me.Controls.Add(Me.etiquetadescripcion)
       Me.Controls.Add(Me.txtcriticidad)
       Me.Controls.Add(Me.etiquetacriticidad)
       Me.Controls.Add(Me.btnSalir)
       Me.Controls.Add(Me.btnGuardar)
       Me.Controls.Add(Me.GroupBox1)
       Me.Name = "frmDetalleTipo_actividad"
       Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
       Me.Text = "frmDetalleTipo_actividad"
       Me.ResumeLayout(False)
       Me.PerformLayout()

   End Sub
   Protected WithEvents txtdescripcion As System.Windows.Forms.TextBox
   Friend WithEvents etiquetadescripcion As System.Windows.Forms.Label
   Protected WithEvents txtcriticidad As System.Windows.Forms.TextBox
   Friend WithEvents etiquetacriticidad As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
End Class

