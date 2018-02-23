<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleEmpresa
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
       Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleEmpresa))
       Me.btnSalir = New System.Windows.Forms.Button
       Me.btnGuardar = New System.Windows.Forms.Button
       Me.GroupBox1 = New System.Windows.Forms.GroupBox
       Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
       Me.txtnombre_empresa = New System.Windows.Forms.TextBox
       Me.etiquetanombre_empresa = New System.Windows.Forms.Label
       Me.txtcontacto = New System.Windows.Forms.TextBox
       Me.etiquetacontacto = New System.Windows.Forms.Label
       Me.txtcuit_empresa = New System.Windows.Forms.TextBox
       Me.etiquetacuit_empresa = New System.Windows.Forms.Label
       Me.txtdireccion = New System.Windows.Forms.TextBox
       Me.etiquetadireccion = New System.Windows.Forms.Label
       Me.txttelefono = New System.Windows.Forms.TextBox
       Me.etiquetatelefono = New System.Windows.Forms.Label
       Me.txtemail = New System.Windows.Forms.TextBox
       Me.etiquetaemail = New System.Windows.Forms.Label
       Me.txtpagina_web = New System.Windows.Forms.TextBox
       Me.etiquetapagina_web = New System.Windows.Forms.Label
       Me.SuspendLayout()
       '
       'txtnombre_empresa
       '
       Me.txtnombre_empresa.BackColor = System.Drawing.Color.White
       Me.txtnombre_empresa.Location = New System.Drawing.Point(161, 48)
       Me.txtnombre_empresa.MaxLength = 50
       Me.txtnombre_empresa.Name = "txtnombre_empresa"
       Me.txtnombre_empresa.Size = New System.Drawing.Size(385, 20)
       Me.txtnombre_empresa.TabIndex = 4
       '
       'etiquietanombre_empresa
       '
        Me.etiquetanombre_empresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetanombre_empresa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetanombre_empresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetanombre_empresa.ForeColor = System.Drawing.Color.Black
        Me.etiquetanombre_empresa.Location = New System.Drawing.Point(28, 48)
        Me.etiquetanombre_empresa.Name = "etiquetanombre_empresa"
        Me.etiquetanombre_empresa.Size = New System.Drawing.Size(127, 21)
        Me.etiquetanombre_empresa.TabIndex = 500
        Me.etiquetanombre_empresa.Text = "Nombre_empresa"
        Me.etiquetanombre_empresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '
        'txtcontacto
        '
        Me.txtcontacto.BackColor = System.Drawing.Color.White
        Me.txtcontacto.Location = New System.Drawing.Point(161, 91)
        Me.txtcontacto.MaxLength = 50
        Me.txtcontacto.Name = "txtcontacto"
        Me.txtcontacto.Size = New System.Drawing.Size(385, 20)
        Me.txtcontacto.TabIndex = 5
        '
        'etiquietacontacto
        '
        Me.etiquetacontacto.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetacontacto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetacontacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetacontacto.ForeColor = System.Drawing.Color.Black
        Me.etiquetacontacto.Location = New System.Drawing.Point(28, 91)
        Me.etiquetacontacto.Name = "etiquetacontacto"
        Me.etiquetacontacto.Size = New System.Drawing.Size(127, 21)
        Me.etiquetacontacto.TabIndex = 501
        Me.etiquetacontacto.Text = "Contacto"
        Me.etiquetacontacto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '
        'txtcuit_empresa
        '
        Me.txtcuit_empresa.BackColor = System.Drawing.Color.White
        Me.txtcuit_empresa.Location = New System.Drawing.Point(161, 134)
        Me.txtcuit_empresa.MaxLength = 50
        Me.txtcuit_empresa.Name = "txtcuit_empresa"
        Me.txtcuit_empresa.Size = New System.Drawing.Size(385, 20)
        Me.txtcuit_empresa.TabIndex = 6
        '
        'etiquietacuit_empresa
        '
        Me.etiquetacuit_empresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetacuit_empresa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetacuit_empresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetacuit_empresa.ForeColor = System.Drawing.Color.Black
        Me.etiquetacuit_empresa.Location = New System.Drawing.Point(28, 134)
        Me.etiquetacuit_empresa.Name = "etiquetacuit_empresa"
        Me.etiquetacuit_empresa.Size = New System.Drawing.Size(127, 21)
        Me.etiquetacuit_empresa.TabIndex = 502
        Me.etiquetacuit_empresa.Text = "Cuit_empresa"
        Me.etiquetacuit_empresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '
        'txtdireccion
        '
        Me.txtdireccion.BackColor = System.Drawing.Color.White
        Me.txtdireccion.Location = New System.Drawing.Point(161, 177)
        Me.txtdireccion.MaxLength = 50
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(385, 20)
        Me.txtdireccion.TabIndex = 7
        '
        'etiquietadireccion
        '
        Me.etiquetadireccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetadireccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetadireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetadireccion.ForeColor = System.Drawing.Color.Black
        Me.etiquetadireccion.Location = New System.Drawing.Point(28, 177)
        Me.etiquetadireccion.Name = "etiquetadireccion"
        Me.etiquetadireccion.Size = New System.Drawing.Size(127, 21)
        Me.etiquetadireccion.TabIndex = 503
        Me.etiquetadireccion.Text = "Direccion"
        Me.etiquetadireccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '
        'txttelefono
        '
        Me.txttelefono.BackColor = System.Drawing.Color.White
        Me.txttelefono.Location = New System.Drawing.Point(161, 220)
        Me.txttelefono.MaxLength = 50
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(385, 20)
        Me.txttelefono.TabIndex = 8
        '
        'etiquietatelefono
        '
        Me.etiquetatelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetatelefono.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetatelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetatelefono.ForeColor = System.Drawing.Color.Black
        Me.etiquetatelefono.Location = New System.Drawing.Point(28, 220)
        Me.etiquetatelefono.Name = "etiquetatelefono"
        Me.etiquetatelefono.Size = New System.Drawing.Size(127, 21)
        Me.etiquetatelefono.TabIndex = 504
        Me.etiquetatelefono.Text = "Telefono"
        Me.etiquetatelefono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '
        'txtemail
        '
        Me.txtemail.BackColor = System.Drawing.Color.White
        Me.txtemail.Location = New System.Drawing.Point(161, 263)
        Me.txtemail.MaxLength = 50
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(385, 20)
        Me.txtemail.TabIndex = 9
        '
        'etiquietaemail
        '
        Me.etiquetaemail.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaemail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaemail.ForeColor = System.Drawing.Color.Black
        Me.etiquetaemail.Location = New System.Drawing.Point(28, 263)
        Me.etiquetaemail.Name = "etiquetaemail"
        Me.etiquetaemail.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaemail.TabIndex = 505
        Me.etiquetaemail.Text = "Email"
        Me.etiquetaemail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '
        'txtpagina_web
        '
        Me.txtpagina_web.BackColor = System.Drawing.Color.White
        Me.txtpagina_web.Location = New System.Drawing.Point(161, 306)
        Me.txtpagina_web.MaxLength = 50
        Me.txtpagina_web.Name = "txtpagina_web"
        Me.txtpagina_web.Size = New System.Drawing.Size(385, 20)
        Me.txtpagina_web.TabIndex = 10
        '
        'etiquietapagina_web
        '
        Me.etiquetapagina_web.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
       Me.etiquetapagina_web.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
       Me.etiquetapagina_web.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetapagina_web.ForeColor = System.Drawing.Color.Black
       Me.etiquetapagina_web.Location = New System.Drawing.Point(28, 306)
       Me.etiquetapagina_web.Name = "etiquetapagina_web"
       Me.etiquetapagina_web.Size = New System.Drawing.Size(127, 21)
       Me.etiquetapagina_web.TabIndex = 506
       Me.etiquetapagina_web.Text = "Pagina_web"
       Me.etiquetapagina_web.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
       Me.btnSalir.Location = New System.Drawing.Point(499, 389)
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
       Me.btnGuardar.Location = New System.Drawing.Point(392,389)
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
       Me.GroupBox1.Size = New System.Drawing.Size(568, 349)
       Me.GroupBox1.TabIndex = 0
       Me.GroupBox1.TabStop = False
       '
       'frmDetalleEmpresa
       '
       Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
       Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
       Me.ClientSize = New System.Drawing.Size(600, 469)
       Me.Controls.Add(Me.txtnombre_empresa)
       Me.Controls.Add(Me.etiquetanombre_empresa)
       Me.Controls.Add(Me.txtcontacto)
       Me.Controls.Add(Me.etiquetacontacto)
       Me.Controls.Add(Me.txtcuit_empresa)
       Me.Controls.Add(Me.etiquetacuit_empresa)
       Me.Controls.Add(Me.txtdireccion)
       Me.Controls.Add(Me.etiquetadireccion)
       Me.Controls.Add(Me.txttelefono)
       Me.Controls.Add(Me.etiquetatelefono)
       Me.Controls.Add(Me.txtemail)
       Me.Controls.Add(Me.etiquetaemail)
       Me.Controls.Add(Me.txtpagina_web)
       Me.Controls.Add(Me.etiquetapagina_web)
       Me.Controls.Add(Me.btnSalir)
       Me.Controls.Add(Me.btnGuardar)
       Me.Controls.Add(Me.GroupBox1)
       Me.Name = "frmDetalleEmpresa"
       Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetalleEmpresa" & vgNombreFormulario
       Me.ResumeLayout(False)
       Me.PerformLayout()

   End Sub
   Protected WithEvents txtnombre_empresa As System.Windows.Forms.TextBox
   Friend WithEvents etiquetanombre_empresa As System.Windows.Forms.Label
   Protected WithEvents txtcontacto As System.Windows.Forms.TextBox
   Friend WithEvents etiquetacontacto As System.Windows.Forms.Label
   Protected WithEvents txtcuit_empresa As System.Windows.Forms.TextBox
   Friend WithEvents etiquetacuit_empresa As System.Windows.Forms.Label
   Protected WithEvents txtdireccion As System.Windows.Forms.TextBox
   Friend WithEvents etiquetadireccion As System.Windows.Forms.Label
   Protected WithEvents txttelefono As System.Windows.Forms.TextBox
   Friend WithEvents etiquetatelefono As System.Windows.Forms.Label
   Protected WithEvents txtemail As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaemail As System.Windows.Forms.Label
   Protected WithEvents txtpagina_web As System.Windows.Forms.TextBox
   Friend WithEvents etiquetapagina_web As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
End Class

