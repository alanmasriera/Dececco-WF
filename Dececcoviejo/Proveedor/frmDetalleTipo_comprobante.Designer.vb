<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleTipo_comprobante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleTipo_comprobante))
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtnombre_tipo_comprobante = New System.Windows.Forms.TextBox
        Me.etiquetanombre_tipo_comprobante = New System.Windows.Forms.Label
        Me.txtdetalle = New System.Windows.Forms.TextBox
        Me.etiquetadetalle = New System.Windows.Forms.Label
        Me.chktilde = New System.Windows.Forms.CheckBox
        Me.etiquetatilde = New System.Windows.Forms.Label
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
        Me.btnSalir.Location = New System.Drawing.Point(499, 217)
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
        Me.btnGuardar.Location = New System.Drawing.Point(392, 217)
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
        Me.GroupBox1.Size = New System.Drawing.Size(568, 177)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtnombre_tipo_comprobante
        '
        Me.txtnombre_tipo_comprobante.BackColor = System.Drawing.Color.White
        Me.txtnombre_tipo_comprobante.Location = New System.Drawing.Point(161, 48)
        Me.txtnombre_tipo_comprobante.MaxLength = 50
        Me.txtnombre_tipo_comprobante.Name = "txtnombre_tipo_comprobante"
        Me.txtnombre_tipo_comprobante.Size = New System.Drawing.Size(385, 20)
        Me.txtnombre_tipo_comprobante.TabIndex = 4
        '
        'etiquetanombre_tipo_comprobante
        '
        Me.etiquetanombre_tipo_comprobante.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetanombre_tipo_comprobante.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetanombre_tipo_comprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetanombre_tipo_comprobante.ForeColor = System.Drawing.Color.Black
        Me.etiquetanombre_tipo_comprobante.Location = New System.Drawing.Point(28, 48)
        Me.etiquetanombre_tipo_comprobante.Name = "etiquetanombre_tipo_comprobante"
        Me.etiquetanombre_tipo_comprobante.Size = New System.Drawing.Size(127, 21)
        Me.etiquetanombre_tipo_comprobante.TabIndex = 500
        Me.etiquetanombre_tipo_comprobante.Text = "nombre"
        Me.etiquetanombre_tipo_comprobante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtdetalle
        '
        Me.txtdetalle.BackColor = System.Drawing.Color.White
        Me.txtdetalle.Location = New System.Drawing.Point(161, 91)
        Me.txtdetalle.MaxLength = 50
        Me.txtdetalle.Name = "txtdetalle"
        Me.txtdetalle.Size = New System.Drawing.Size(385, 20)
        Me.txtdetalle.TabIndex = 5
        '
        'etiquetadetalle
        '
        Me.etiquetadetalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetadetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetadetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetadetalle.ForeColor = System.Drawing.Color.Black
        Me.etiquetadetalle.Location = New System.Drawing.Point(28, 91)
        Me.etiquetadetalle.Name = "etiquetadetalle"
        Me.etiquetadetalle.Size = New System.Drawing.Size(127, 21)
        Me.etiquetadetalle.TabIndex = 501
        Me.etiquetadetalle.Text = "detalle"
        Me.etiquetadetalle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chktilde
        '
        Me.chktilde.AutoSize = True
        Me.chktilde.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chktilde.Location = New System.Drawing.Point(161, 134)
        Me.chktilde.Name = "chktilde"
        Me.chktilde.Size = New System.Drawing.Size(15, 14)
        Me.chktilde.TabIndex = 6
        '
        'etiquetatilde
        '
        Me.etiquetatilde.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetatilde.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetatilde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetatilde.ForeColor = System.Drawing.Color.Black
        Me.etiquetatilde.Location = New System.Drawing.Point(28, 134)
        Me.etiquetatilde.Name = "etiquetatilde"
        Me.etiquetatilde.Size = New System.Drawing.Size(127, 21)
        Me.etiquetatilde.TabIndex = 502
        Me.etiquetatilde.Text = "Deshabilitado"
        Me.etiquetatilde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmDetalleTipo_comprobante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 297)
        Me.Controls.Add(Me.txtnombre_tipo_comprobante)
        Me.Controls.Add(Me.etiquetanombre_tipo_comprobante)
        Me.Controls.Add(Me.txtdetalle)
        Me.Controls.Add(Me.etiquetadetalle)
        Me.Controls.Add(Me.chktilde)
        Me.Controls.Add(Me.etiquetatilde)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDetalleTipo_comprobante"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetalleTipo_comprobante" & vgNombreFormulario
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Protected WithEvents txtnombre_tipo_comprobante As System.Windows.Forms.TextBox
   Friend WithEvents etiquetanombre_tipo_comprobante As System.Windows.Forms.Label
   Protected WithEvents txtdetalle As System.Windows.Forms.TextBox
   Friend WithEvents etiquetadetalle As System.Windows.Forms.Label
   Protected WithEvents chktilde As System.Windows.Forms.CheckBox
   Friend WithEvents etiquetatilde As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
End Class

