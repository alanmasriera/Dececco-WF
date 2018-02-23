<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleObra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleObra))
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtnombre_obra = New System.Windows.Forms.TextBox
        Me.etiquetanombre_obra = New System.Windows.Forms.Label
        Me.txtdetalle_obra = New System.Windows.Forms.TextBox
        Me.etiquetadetalle_obra = New System.Windows.Forms.Label
        Me.chkextra = New System.Windows.Forms.CheckBox
        Me.etiquetaextra = New System.Windows.Forms.Label
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
        'txtnombre_obra
        '
        Me.txtnombre_obra.BackColor = System.Drawing.Color.White
        Me.txtnombre_obra.Location = New System.Drawing.Point(161, 48)
        Me.txtnombre_obra.MaxLength = 50
        Me.txtnombre_obra.Name = "txtnombre_obra"
        Me.txtnombre_obra.Size = New System.Drawing.Size(385, 20)
        Me.txtnombre_obra.TabIndex = 4
        '
        'etiquetanombre_obra
        '
        Me.etiquetanombre_obra.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetanombre_obra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetanombre_obra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetanombre_obra.ForeColor = System.Drawing.Color.Black
        Me.etiquetanombre_obra.Location = New System.Drawing.Point(28, 48)
        Me.etiquetanombre_obra.Name = "etiquetanombre_obra"
        Me.etiquetanombre_obra.Size = New System.Drawing.Size(127, 21)
        Me.etiquetanombre_obra.TabIndex = 500
        Me.etiquetanombre_obra.Text = "Nombre_obra"
        Me.etiquetanombre_obra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtdetalle_obra
        '
        Me.txtdetalle_obra.BackColor = System.Drawing.Color.White
        Me.txtdetalle_obra.Location = New System.Drawing.Point(161, 91)
        Me.txtdetalle_obra.MaxLength = 50
        Me.txtdetalle_obra.Name = "txtdetalle_obra"
        Me.txtdetalle_obra.Size = New System.Drawing.Size(385, 20)
        Me.txtdetalle_obra.TabIndex = 5
        '
        'etiquetadetalle_obra
        '
        Me.etiquetadetalle_obra.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetadetalle_obra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetadetalle_obra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetadetalle_obra.ForeColor = System.Drawing.Color.Black
        Me.etiquetadetalle_obra.Location = New System.Drawing.Point(28, 91)
        Me.etiquetadetalle_obra.Name = "etiquetadetalle_obra"
        Me.etiquetadetalle_obra.Size = New System.Drawing.Size(127, 21)
        Me.etiquetadetalle_obra.TabIndex = 501
        Me.etiquetadetalle_obra.Text = "Detalle_obra"
        Me.etiquetadetalle_obra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkextra
        '
        Me.chkextra.AutoSize = True
        Me.chkextra.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkextra.Location = New System.Drawing.Point(161, 134)
        Me.chkextra.Name = "chkextra"
        Me.chkextra.Size = New System.Drawing.Size(63, 21)
        Me.chkextra.TabIndex = 6
        Me.chkextra.Text = "extra"
        '
        'etiquetaextra
        '
        Me.etiquetaextra.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaextra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaextra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaextra.ForeColor = System.Drawing.Color.Black
        Me.etiquetaextra.Location = New System.Drawing.Point(28, 134)
        Me.etiquetaextra.Name = "etiquetaextra"
        Me.etiquetaextra.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaextra.TabIndex = 502
        Me.etiquetaextra.Text = "Extra"
        Me.etiquetaextra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmDetalleObra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 297)
        Me.Controls.Add(Me.txtnombre_obra)
        Me.Controls.Add(Me.etiquetanombre_obra)
        Me.Controls.Add(Me.txtdetalle_obra)
        Me.Controls.Add(Me.etiquetadetalle_obra)
        Me.Controls.Add(Me.chkextra)
        Me.Controls.Add(Me.etiquetaextra)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDetalleObra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetalleObra"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Protected WithEvents txtnombre_obra As System.Windows.Forms.TextBox
   Friend WithEvents etiquetanombre_obra As System.Windows.Forms.Label
   Protected WithEvents txtdetalle_obra As System.Windows.Forms.TextBox
   Friend WithEvents etiquetadetalle_obra As System.Windows.Forms.Label
   Protected WithEvents chkextra As System.Windows.Forms.CheckBox
   Friend WithEvents etiquetaextra As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
End Class

