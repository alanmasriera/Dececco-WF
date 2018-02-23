<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleTemp_actividad_proyecto
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
       Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleTemp_actividad_proyecto))
       Me.btnSalir = New System.Windows.Forms.Button
       Me.btnGuardar = New System.Windows.Forms.Button
       Me.GroupBox1 = New System.Windows.Forms.GroupBox
       Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
       Me.lblid_actividad = New System.Windows.Forms.Label
       Me.btnBuscaactividad = New System.Windows.Forms.Button
       Me.cmbactividad = New System.Windows.Forms.ComboBox
       Me.etiquetaid_actividad = New System.Windows.Forms.Label
       Me.lblid_proyecto = New System.Windows.Forms.Label
       Me.btnBuscaproyecto = New System.Windows.Forms.Button
       Me.cmbproyecto = New System.Windows.Forms.ComboBox
       Me.etiquetaid_proyecto = New System.Windows.Forms.Label
       Me.lblid_actividad_proyecto = New System.Windows.Forms.Label
       Me.btnBuscaactividad_proyecto = New System.Windows.Forms.Button
       Me.cmbactividad_proyecto = New System.Windows.Forms.ComboBox
       Me.etiquetaid_actividad_proyecto = New System.Windows.Forms.Label
       Me.lblid_usuario = New System.Windows.Forms.Label
       Me.btnBuscausuario = New System.Windows.Forms.Button
       Me.cmbusuario = New System.Windows.Forms.ComboBox
       Me.etiquetaid_usuario = New System.Windows.Forms.Label
       Me.SuspendLayout()
       '
       'lblid_actividad
       '
       Me.lblid_actividad.AutoSize = True
       Me.lblid_actividad.BackColor = System.Drawing.Color.Red
       Me.lblid_actividad.Location = New System.Drawing.Point(370, 48)
       Me.lblid_actividad.Name = "lblid_actividad"
       Me.lblid_actividad.Size = New System.Drawing.Size(13, 13)
       Me.lblid_actividad.TabIndex = 500
       Me.lblid_actividad.Text = "0"
       Me.lblid_actividad.Visible = False
       '
       'btnBuscaactividad
       '
       Me.btnBuscaactividad.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscaactividad.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscaactividad.Location = New System.Drawing.Point(505, 48)
       Me.btnBuscaactividad.Name = "btnBuscaactividad"
       Me.btnBuscaactividad.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscaactividad.TabIndex = 60
       Me.btnBuscaactividad.UseVisualStyleBackColor = True
       '
       'cmbactividad
       '
       Me.cmbactividad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbactividad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbactividad.FormattingEnabled = True
       Me.cmbactividad.Location = New System.Drawing.Point(161, 48)
       Me.cmbactividad.Size = New System.Drawing.Size(329, 21)
       Me.cmbactividad.Name = "cmbactividad"
       Me.cmbactividad.TabIndex = 4
       '
       'etiquietaid_actividad
       '
       Me.etiquetaid_actividad.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_actividad.AutoSize = True
       Me.etiquetaid_actividad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_actividad.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_actividad.Location = New System.Drawing.Point(28, 48)
       Me.etiquetaid_actividad.Name = "etiquetaid_actividad"
       Me.etiquetaid_actividad.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_actividad.TabIndex = 501
       Me.etiquetaid_actividad.Text = "Actividad"
       Me.etiquetaid_actividad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblid_proyecto
       '
       Me.lblid_proyecto.AutoSize = True
       Me.lblid_proyecto.BackColor = System.Drawing.Color.Red
       Me.lblid_proyecto.Location = New System.Drawing.Point(370, 91)
       Me.lblid_proyecto.Name = "lblid_proyecto"
       Me.lblid_proyecto.Size = New System.Drawing.Size(13, 13)
       Me.lblid_proyecto.TabIndex = 502
       Me.lblid_proyecto.Text = "0"
       Me.lblid_proyecto.Visible = False
       '
       'btnBuscaproyecto
       '
       Me.btnBuscaproyecto.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscaproyecto.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscaproyecto.Location = New System.Drawing.Point(505, 91)
       Me.btnBuscaproyecto.Name = "btnBuscaproyecto"
       Me.btnBuscaproyecto.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscaproyecto.TabIndex = 61
       Me.btnBuscaproyecto.UseVisualStyleBackColor = True
       '
       'cmbproyecto
       '
       Me.cmbproyecto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbproyecto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbproyecto.FormattingEnabled = True
       Me.cmbproyecto.Location = New System.Drawing.Point(161, 91)
       Me.cmbproyecto.Size = New System.Drawing.Size(329, 21)
       Me.cmbproyecto.Name = "cmbproyecto"
       Me.cmbproyecto.TabIndex = 5
       '
       'etiquietaid_proyecto
       '
       Me.etiquetaid_proyecto.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_proyecto.AutoSize = True
       Me.etiquetaid_proyecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_proyecto.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_proyecto.Location = New System.Drawing.Point(28, 91)
       Me.etiquetaid_proyecto.Name = "etiquetaid_proyecto"
       Me.etiquetaid_proyecto.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_proyecto.TabIndex = 503
       Me.etiquetaid_proyecto.Text = "Proyecto"
       Me.etiquetaid_proyecto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblid_actividad_proyecto
       '
       Me.lblid_actividad_proyecto.AutoSize = True
       Me.lblid_actividad_proyecto.BackColor = System.Drawing.Color.Red
       Me.lblid_actividad_proyecto.Location = New System.Drawing.Point(370, 134)
       Me.lblid_actividad_proyecto.Name = "lblid_actividad_proyecto"
       Me.lblid_actividad_proyecto.Size = New System.Drawing.Size(13, 13)
       Me.lblid_actividad_proyecto.TabIndex = 504
       Me.lblid_actividad_proyecto.Text = "0"
       Me.lblid_actividad_proyecto.Visible = False
       '
       'btnBuscaactividad_proyecto
       '
       Me.btnBuscaactividad_proyecto.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscaactividad_proyecto.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscaactividad_proyecto.Location = New System.Drawing.Point(505, 134)
       Me.btnBuscaactividad_proyecto.Name = "btnBuscaactividad_proyecto"
       Me.btnBuscaactividad_proyecto.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscaactividad_proyecto.TabIndex = 62
       Me.btnBuscaactividad_proyecto.UseVisualStyleBackColor = True
       '
       'cmbactividad_proyecto
       '
       Me.cmbactividad_proyecto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbactividad_proyecto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbactividad_proyecto.FormattingEnabled = True
       Me.cmbactividad_proyecto.Location = New System.Drawing.Point(161, 134)
       Me.cmbactividad_proyecto.Size = New System.Drawing.Size(329, 21)
       Me.cmbactividad_proyecto.Name = "cmbactividad_proyecto"
       Me.cmbactividad_proyecto.TabIndex = 6
       '
       'etiquietaid_actividad_proyecto
       '
       Me.etiquetaid_actividad_proyecto.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_actividad_proyecto.AutoSize = True
       Me.etiquetaid_actividad_proyecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_actividad_proyecto.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_actividad_proyecto.Location = New System.Drawing.Point(28, 134)
       Me.etiquetaid_actividad_proyecto.Name = "etiquetaid_actividad_proyecto"
       Me.etiquetaid_actividad_proyecto.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_actividad_proyecto.TabIndex = 505
       Me.etiquetaid_actividad_proyecto.Text = "Actividad proyecto"
       Me.etiquetaid_actividad_proyecto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblid_usuario
       '
       Me.lblid_usuario.AutoSize = True
       Me.lblid_usuario.BackColor = System.Drawing.Color.Red
       Me.lblid_usuario.Location = New System.Drawing.Point(370, 177)
       Me.lblid_usuario.Name = "lblid_usuario"
       Me.lblid_usuario.Size = New System.Drawing.Size(13, 13)
       Me.lblid_usuario.TabIndex = 506
       Me.lblid_usuario.Text = "0"
       Me.lblid_usuario.Visible = False
       '
       'btnBuscausuario
       '
       Me.btnBuscausuario.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscausuario.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscausuario.Location = New System.Drawing.Point(505, 177)
       Me.btnBuscausuario.Name = "btnBuscausuario"
       Me.btnBuscausuario.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscausuario.TabIndex = 63
       Me.btnBuscausuario.UseVisualStyleBackColor = True
       '
       'cmbusuario
       '
       Me.cmbusuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbusuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbusuario.FormattingEnabled = True
       Me.cmbusuario.Location = New System.Drawing.Point(161, 177)
       Me.cmbusuario.Size = New System.Drawing.Size(329, 21)
       Me.cmbusuario.Name = "cmbusuario"
       Me.cmbusuario.TabIndex = 7
       '
       'etiquietaid_usuario
       '
       Me.etiquetaid_usuario.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_usuario.AutoSize = True
       Me.etiquetaid_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_usuario.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_usuario.Location = New System.Drawing.Point(28, 177)
       Me.etiquetaid_usuario.Name = "etiquetaid_usuario"
       Me.etiquetaid_usuario.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_usuario.TabIndex = 507
       Me.etiquetaid_usuario.Text = "Usuario"
       Me.etiquetaid_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'btnSalir
       '
       Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
       Me.btnSalir.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.btnSalir.ForeColor = System.Drawing.Color.Black
       Me.btnSalir.Image = CType(Resources.GetObject("btnSalir.Image"), System.Drawing.Image)
       Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
       Me.btnSalir.Location = New System.Drawing.Point(499, 260)
       Me.btnSalir.Name = "btnSalir"
       Me.btnSalir.Size = New System.Drawing.Size(81, 61)
       Me.btnSalir.TabIndex = 51
       Me.btnSalir.Text = "&Salir"
       Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
       Me.btnSalir.UseVisualStyleBackColor = True
       '
       'btnGuardar
       '
       Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnGuardar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.btnGuardar.ForeColor = System.Drawing.Color.Black
       Me.btnGuardar.Image = CType(Resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
       Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
       Me.btnGuardar.Location = New System.Drawing.Point(392,260)
       Me.btnGuardar.Name = "btnGuardar"
       Me.btnGuardar.Size = New System.Drawing.Size(81, 61)
       Me.btnGuardar.TabIndex = 50
       Me.btnGuardar.Text = "&Guardar"
       Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
       Me.btnGuardar.UseVisualStyleBackColor = True
       '
       'GroupBox1
       '
       Me.GroupBox1.Location = New System.Drawing.Point(12, 17)
       Me.GroupBox1.Name = "GroupBox1"
       Me.GroupBox1.Size = New System.Drawing.Size(568, 220)
       Me.GroupBox1.TabIndex = 0
       Me.GroupBox1.TabStop = False
       '
       'frmDetalleTemp_actividad_proyecto
       '
       Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
       Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
       Me.ClientSize = New System.Drawing.Size(600, 340)
       Me.Controls.Add(Me.lblid_actividad)
       Me.Controls.Add(Me.btnBuscaactividad)
       Me.Controls.Add(Me.cmbactividad)
       Me.Controls.Add(Me.etiquetaid_actividad)
       Me.Controls.Add(Me.lblid_proyecto)
       Me.Controls.Add(Me.btnBuscaproyecto)
       Me.Controls.Add(Me.cmbproyecto)
       Me.Controls.Add(Me.etiquetaid_proyecto)
       Me.Controls.Add(Me.lblid_actividad_proyecto)
       Me.Controls.Add(Me.btnBuscaactividad_proyecto)
       Me.Controls.Add(Me.cmbactividad_proyecto)
       Me.Controls.Add(Me.etiquetaid_actividad_proyecto)
       Me.Controls.Add(Me.lblid_usuario)
       Me.Controls.Add(Me.btnBuscausuario)
       Me.Controls.Add(Me.cmbusuario)
       Me.Controls.Add(Me.etiquetaid_usuario)
       Me.Controls.Add(Me.btnSalir)
       Me.Controls.Add(Me.btnGuardar)
       Me.Controls.Add(Me.GroupBox1)
       Me.Name = "frmDetalleTemp_actividad_proyecto"
       Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
       Me.Text = "frmDetalleTemp_actividad_proyecto" & vgNombreFormulario
       Me.ResumeLayout(False)
       Me.PerformLayout()

   End Sub
   Friend WithEvents lblid_actividad As System.Windows.Forms.Label
   Friend WithEvents btnBuscaactividad As System.Windows.Forms.Button
   Friend WithEvents cmbactividad As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_actividad As System.Windows.Forms.Label
   Friend WithEvents lblid_proyecto As System.Windows.Forms.Label
   Friend WithEvents btnBuscaproyecto As System.Windows.Forms.Button
   Friend WithEvents cmbproyecto As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_proyecto As System.Windows.Forms.Label
   Friend WithEvents lblid_actividad_proyecto As System.Windows.Forms.Label
   Friend WithEvents btnBuscaactividad_proyecto As System.Windows.Forms.Button
   Friend WithEvents cmbactividad_proyecto As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_actividad_proyecto As System.Windows.Forms.Label
   Friend WithEvents lblid_usuario As System.Windows.Forms.Label
   Friend WithEvents btnBuscausuario As System.Windows.Forms.Button
   Friend WithEvents cmbusuario As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_usuario As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
End Class

