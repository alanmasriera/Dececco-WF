<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleMoneda
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
       Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleMoneda))
       Me.btnSalir = New System.Windows.Forms.Button
       Me.btnGuardar = New System.Windows.Forms.Button
       Me.GroupBox1 = New System.Windows.Forms.GroupBox
       Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
       Me.txtsimbolo = New System.Windows.Forms.TextBox
       Me.etiquetasimbolo = New System.Windows.Forms.Label
       Me.txtnombre_moneda = New System.Windows.Forms.TextBox
       Me.etiquetanombre_moneda = New System.Windows.Forms.Label
       Me.txtabreviatura = New System.Windows.Forms.TextBox
       Me.etiquetaabreviatura = New System.Windows.Forms.Label
       Me.SuspendLayout()
       '
       'txtsimbolo
       '
       Me.txtsimbolo.BackColor = System.Drawing.Color.White
       Me.txtsimbolo.Location = New System.Drawing.Point(161, 48)
       Me.txtsimbolo.Size = New System.Drawing.Size(385, 20)
       Me.txtsimbolo.MaxLength = 5
       Me.txtsimbolo.Name = "txtsimbolo"
       Me.txtsimbolo.TabIndex = 4
       '
       'etiquietasimbolo
       '
       Me.etiquetasimbolo.BackColor = System.Drawing.Color.Transparent
       Me.etiquetasimbolo.AutoSize = True
       Me.etiquetasimbolo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetasimbolo.ForeColor = System.Drawing.Color.Black
       Me.etiquetasimbolo.Location = New System.Drawing.Point(28, 48)
       Me.etiquetasimbolo.Name = "etiquetasimbolo"
       Me.etiquetasimbolo.Size = New System.Drawing.Size(127, 21)
       Me.etiquetasimbolo.TabIndex = 500
       Me.etiquetasimbolo.Text = "Simbolo"
       Me.etiquetasimbolo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtnombre_moneda
       '
       Me.txtnombre_moneda.BackColor = System.Drawing.Color.White
       Me.txtnombre_moneda.Location = New System.Drawing.Point(161, 91)
       Me.txtnombre_moneda.Size = New System.Drawing.Size(385, 20)
       Me.txtnombre_moneda.MaxLength = 50
       Me.txtnombre_moneda.Name = "txtnombre_moneda"
       Me.txtnombre_moneda.TabIndex = 5
       '
       'etiquietanombre_moneda
       '
       Me.etiquetanombre_moneda.BackColor = System.Drawing.Color.Transparent
       Me.etiquetanombre_moneda.AutoSize = True
       Me.etiquetanombre_moneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetanombre_moneda.ForeColor = System.Drawing.Color.Black
       Me.etiquetanombre_moneda.Location = New System.Drawing.Point(28, 91)
       Me.etiquetanombre_moneda.Name = "etiquetanombre_moneda"
       Me.etiquetanombre_moneda.Size = New System.Drawing.Size(127, 21)
       Me.etiquetanombre_moneda.TabIndex = 501
       Me.etiquetanombre_moneda.Text = "Nombre moneda"
       Me.etiquetanombre_moneda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtabreviatura
       '
       Me.txtabreviatura.BackColor = System.Drawing.Color.White
       Me.txtabreviatura.Location = New System.Drawing.Point(161, 134)
       Me.txtabreviatura.Size = New System.Drawing.Size(385, 20)
       Me.txtabreviatura.MaxLength = 50
       Me.txtabreviatura.Name = "txtabreviatura"
       Me.txtabreviatura.TabIndex = 6
       '
       'etiquietaabreviatura
       '
       Me.etiquetaabreviatura.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaabreviatura.AutoSize = True
       Me.etiquetaabreviatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaabreviatura.ForeColor = System.Drawing.Color.Black
       Me.etiquetaabreviatura.Location = New System.Drawing.Point(28, 134)
       Me.etiquetaabreviatura.Name = "etiquetaabreviatura"
       Me.etiquetaabreviatura.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaabreviatura.TabIndex = 502
       Me.etiquetaabreviatura.Text = "Abreviatura"
       Me.etiquetaabreviatura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
       Me.btnSalir.Location = New System.Drawing.Point(499, 217)
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
       Me.btnGuardar.Location = New System.Drawing.Point(392,217)
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
       Me.GroupBox1.Size = New System.Drawing.Size(568, 177)
       Me.GroupBox1.TabIndex = 0
       Me.GroupBox1.TabStop = False
       '
       'frmDetalleMoneda
       '
       Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
       Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
       Me.ClientSize = New System.Drawing.Size(600, 297)
       Me.Controls.Add(Me.txtsimbolo)
       Me.Controls.Add(Me.etiquetasimbolo)
       Me.Controls.Add(Me.txtnombre_moneda)
       Me.Controls.Add(Me.etiquetanombre_moneda)
       Me.Controls.Add(Me.txtabreviatura)
       Me.Controls.Add(Me.etiquetaabreviatura)
       Me.Controls.Add(Me.btnSalir)
       Me.Controls.Add(Me.btnGuardar)
       Me.Controls.Add(Me.GroupBox1)
       Me.Name = "frmDetalleMoneda"
       Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
       Me.Text = "frmDetalleMoneda" & vgNombreFormulario
       Me.ResumeLayout(False)
       Me.PerformLayout()

   End Sub
   Protected WithEvents txtsimbolo As System.Windows.Forms.TextBox
   Friend WithEvents etiquetasimbolo As System.Windows.Forms.Label
   Protected WithEvents txtnombre_moneda As System.Windows.Forms.TextBox
   Friend WithEvents etiquetanombre_moneda As System.Windows.Forms.Label
   Protected WithEvents txtabreviatura As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaabreviatura As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
End Class

