<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleEstado
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleEstado))
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtnombre_estado = New System.Windows.Forms.TextBox
        Me.etiquetanombre_estado = New System.Windows.Forms.Label
        Me.txtavance = New System.Windows.Forms.TextBox
        Me.etiquetaavance = New System.Windows.Forms.Label
        Me.txtcolor = New System.Windows.Forms.TextBox
        Me.etiquetacolor = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtnombre_estado
        '
        Me.txtnombre_estado.BackColor = System.Drawing.Color.White
        Me.txtnombre_estado.Location = New System.Drawing.Point(161, 48)
        Me.txtnombre_estado.MaxLength = 50
        Me.txtnombre_estado.Name = "txtnombre_estado"
        Me.txtnombre_estado.Size = New System.Drawing.Size(385, 20)
        Me.txtnombre_estado.TabIndex = 4
        '
        'etiquietanombre_estado
        '
        Me.etiquetanombre_estado.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetanombre_estado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetanombre_estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetanombre_estado.ForeColor = System.Drawing.Color.Black
        Me.etiquetanombre_estado.Location = New System.Drawing.Point(28, 48)
        Me.etiquetanombre_estado.Name = "etiquetanombre_estado"
        Me.etiquetanombre_estado.Size = New System.Drawing.Size(127, 21)
        Me.etiquetanombre_estado.TabIndex = 500
        Me.etiquetanombre_estado.Text = "Nombre_estado"
        Me.etiquetanombre_estado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '
        'txtavance
        '
        Me.txtavance.BackColor = System.Drawing.Color.White
        Me.txtavance.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtavance.ForeColor = System.Drawing.Color.Blue
        Me.txtavance.Location = New System.Drawing.Point(161, 91)
        Me.txtavance.MaxLength = 50
        Me.txtavance.Name = "txtavance"
        Me.txtavance.Size = New System.Drawing.Size(222, 31)
        Me.txtavance.TabIndex = 5
        Me.txtavance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquietaavance
        '
        Me.etiquetaavance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaavance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaavance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaavance.ForeColor = System.Drawing.Color.Black
        Me.etiquetaavance.Location = New System.Drawing.Point(28, 91)
        Me.etiquetaavance.Name = "etiquetaavance"
        Me.etiquetaavance.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaavance.TabIndex = 501
        Me.etiquetaavance.Text = "Avance"
        Me.etiquetaavance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '
        'txtcolor
        '
        Me.txtcolor.BackColor = System.Drawing.Color.White
        Me.txtcolor.Location = New System.Drawing.Point(161, 144)
        Me.txtcolor.MaxLength = 50
        Me.txtcolor.Name = "txtcolor"
        Me.txtcolor.Size = New System.Drawing.Size(385, 20)
        Me.txtcolor.TabIndex = 6
        '
        'etiquietacolor
        '
        Me.etiquetacolor.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetacolor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetacolor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetacolor.ForeColor = System.Drawing.Color.Black
        Me.etiquetacolor.Location = New System.Drawing.Point(28, 144)
        Me.etiquetacolor.Name = "etiquetacolor"
        Me.etiquetacolor.Size = New System.Drawing.Size(127, 21)
        Me.etiquetacolor.TabIndex = 502
        Me.etiquetacolor.Text = "Color"
        Me.etiquetacolor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
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
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(392, 227)
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
        'frmDetalleEstado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 307)
        Me.Controls.Add(Me.txtnombre_estado)
        Me.Controls.Add(Me.etiquetanombre_estado)
        Me.Controls.Add(Me.txtavance)
        Me.Controls.Add(Me.etiquetaavance)
        Me.Controls.Add(Me.txtcolor)
        Me.Controls.Add(Me.etiquetacolor)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDetalleEstado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetalleEstado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Protected WithEvents txtnombre_estado As System.Windows.Forms.TextBox
    Friend WithEvents etiquetanombre_estado As System.Windows.Forms.Label
    Protected WithEvents txtavance As System.Windows.Forms.TextBox
    Friend WithEvents etiquetaavance As System.Windows.Forms.Label
    Protected WithEvents txtcolor As System.Windows.Forms.TextBox
    Friend WithEvents etiquetacolor As System.Windows.Forms.Label
    Protected WithEvents btnSalir As System.Windows.Forms.Button
    Protected WithEvents btnGuardar As System.Windows.Forms.Button
    Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
End Class

