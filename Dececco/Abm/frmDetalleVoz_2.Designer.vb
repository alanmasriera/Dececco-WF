<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleVoz_2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleVoz_2))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtrango = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chk_pond_manual = New System.Windows.Forms.CheckBox()
        Me.txtnombre_voz = New System.Windows.Forms.TextBox()
        Me.etiquetanombre_voz = New System.Windows.Forms.Label()
        Me.txticono = New System.Windows.Forms.TextBox()
        Me.etiquetaicono = New System.Windows.Forms.Label()
        Me.txtponderacion = New System.Windows.Forms.TextBox()
        Me.etiquetaponderacion = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtrango)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.chk_pond_manual)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(613, 312)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'txtrango
        '
        Me.txtrango.BackColor = System.Drawing.Color.White
        Me.txtrango.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrango.ForeColor = System.Drawing.Color.Blue
        Me.txtrango.Location = New System.Drawing.Point(191, 242)
        Me.txtrango.MaxLength = 50
        Me.txtrango.Name = "txtrango"
        Me.txtrango.Size = New System.Drawing.Size(46, 31)
        Me.txtrango.TabIndex = 513
        Me.txtrango.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(47, 249)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 24)
        Me.Label1.TabIndex = 513
        Me.Label1.Text = "Ponderacion"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chk_pond_manual
        '
        Me.chk_pond_manual.AutoSize = True
        Me.chk_pond_manual.Location = New System.Drawing.Point(434, 176)
        Me.chk_pond_manual.Name = "chk_pond_manual"
        Me.chk_pond_manual.Size = New System.Drawing.Size(123, 17)
        Me.chk_pond_manual.TabIndex = 0
        Me.chk_pond_manual.Text = "Ponderación manual"
        Me.chk_pond_manual.UseVisualStyleBackColor = True
        '
        'txtnombre_voz
        '
        Me.txtnombre_voz.BackColor = System.Drawing.Color.White
        Me.txtnombre_voz.Location = New System.Drawing.Point(216, 29)
        Me.txtnombre_voz.MaxLength = 500
        Me.txtnombre_voz.Multiline = True
        Me.txtnombre_voz.Name = "txtnombre_voz"
        Me.txtnombre_voz.Size = New System.Drawing.Size(385, 93)
        Me.txtnombre_voz.TabIndex = 505
        '
        'etiquetanombre_voz
        '
        Me.etiquetanombre_voz.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetanombre_voz.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetanombre_voz.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetanombre_voz.ForeColor = System.Drawing.Color.Black
        Me.etiquetanombre_voz.Location = New System.Drawing.Point(72, 28)
        Me.etiquetanombre_voz.Name = "etiquetanombre_voz"
        Me.etiquetanombre_voz.Size = New System.Drawing.Size(127, 21)
        Me.etiquetanombre_voz.TabIndex = 510
        Me.etiquetanombre_voz.Text = "Nombre_voz"
        Me.etiquetanombre_voz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txticono
        '
        Me.txticono.BackColor = System.Drawing.Color.White
        Me.txticono.Location = New System.Drawing.Point(216, 141)
        Me.txticono.MaxLength = 50
        Me.txticono.Name = "txticono"
        Me.txticono.Size = New System.Drawing.Size(385, 20)
        Me.txticono.TabIndex = 506
        '
        'etiquetaicono
        '
        Me.etiquetaicono.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaicono.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaicono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaicono.ForeColor = System.Drawing.Color.Black
        Me.etiquetaicono.Location = New System.Drawing.Point(72, 141)
        Me.etiquetaicono.Name = "etiquetaicono"
        Me.etiquetaicono.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaicono.TabIndex = 511
        Me.etiquetaicono.Text = "Icono"
        Me.etiquetaicono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtponderacion
        '
        Me.txtponderacion.BackColor = System.Drawing.Color.White
        Me.txtponderacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtponderacion.ForeColor = System.Drawing.Color.Blue
        Me.txtponderacion.Location = New System.Drawing.Point(216, 185)
        Me.txtponderacion.MaxLength = 50
        Me.txtponderacion.Name = "txtponderacion"
        Me.txtponderacion.Size = New System.Drawing.Size(222, 31)
        Me.txtponderacion.TabIndex = 507
        Me.txtponderacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetaponderacion
        '
        Me.etiquetaponderacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaponderacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaponderacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaponderacion.ForeColor = System.Drawing.Color.Black
        Me.etiquetaponderacion.Location = New System.Drawing.Point(72, 185)
        Me.etiquetaponderacion.Name = "etiquetaponderacion"
        Me.etiquetaponderacion.Size = New System.Drawing.Size(127, 41)
        Me.etiquetaponderacion.TabIndex = 512
        Me.etiquetaponderacion.Text = "Ponderacion porcentual"
        Me.etiquetaponderacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(557, 346)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(81, 69)
        Me.btnSalir.TabIndex = 509
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
        Me.btnGuardar.Location = New System.Drawing.Point(459, 346)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(78, 69)
        Me.btnGuardar.TabIndex = 508
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'frmDetalleVoz_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(953, 427)
        Me.Controls.Add(Me.txticono)
        Me.Controls.Add(Me.etiquetaicono)
        Me.Controls.Add(Me.txtnombre_voz)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.etiquetaponderacion)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.etiquetanombre_voz)
        Me.Controls.Add(Me.txtponderacion)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDetalleVoz_2"
        Me.Text = "frmDetalleVoz_2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Protected WithEvents txtnombre_voz As System.Windows.Forms.TextBox
    Friend WithEvents etiquetanombre_voz As System.Windows.Forms.Label
    Protected WithEvents txticono As System.Windows.Forms.TextBox
    Friend WithEvents etiquetaicono As System.Windows.Forms.Label
    Protected WithEvents txtponderacion As System.Windows.Forms.TextBox
    Friend WithEvents etiquetaponderacion As System.Windows.Forms.Label
    Protected WithEvents btnSalir As System.Windows.Forms.Button
    Protected WithEvents btnGuardar As System.Windows.Forms.Button
    Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
    Friend WithEvents chk_pond_manual As System.Windows.Forms.CheckBox
    Protected WithEvents txtrango As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
