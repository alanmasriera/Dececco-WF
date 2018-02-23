<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleProveedor
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
       Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleProveedor))
       Me.btnSalir = New System.Windows.Forms.Button
       Me.btnGuardar = New System.Windows.Forms.Button
       Me.GroupBox1 = New System.Windows.Forms.GroupBox
       Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
       Me.txtnombre_proveedor = New System.Windows.Forms.TextBox
       Me.etiquetanombre_proveedor = New System.Windows.Forms.Label
       Me.txtcontacto = New System.Windows.Forms.TextBox
       Me.etiquetacontacto = New System.Windows.Forms.Label
       Me.txtcuit = New System.Windows.Forms.TextBox
       Me.etiquetacuit = New System.Windows.Forms.Label
       Me.txtingreso_bruto = New System.Windows.Forms.TextBox
       Me.etiquetaingreso_bruto = New System.Windows.Forms.Label
       Me.txtdireccion = New System.Windows.Forms.TextBox
       Me.etiquetadireccion = New System.Windows.Forms.Label
       Me.txtlocalidad = New System.Windows.Forms.TextBox
       Me.etiquetalocalidad = New System.Windows.Forms.Label
       Me.txtprovincia = New System.Windows.Forms.TextBox
       Me.etiquetaprovincia = New System.Windows.Forms.Label
       Me.txttelefono = New System.Windows.Forms.TextBox
       Me.etiquetatelefono = New System.Windows.Forms.Label
       Me.txtemail = New System.Windows.Forms.TextBox
       Me.etiquetaemail = New System.Windows.Forms.Label
       Me.txtweb = New System.Windows.Forms.TextBox
       Me.etiquetaweb = New System.Windows.Forms.Label
       Me.lblid_condicion_iva = New System.Windows.Forms.Label
       Me.btnBuscacondicion_iva = New System.Windows.Forms.Button
       Me.cmbcondicion_iva = New System.Windows.Forms.ComboBox
       Me.etiquetaid_condicion_iva = New System.Windows.Forms.Label
       Me.lblid_tipo_proveedor = New System.Windows.Forms.Label
       Me.btnBuscatipo_proveedor = New System.Windows.Forms.Button
       Me.cmbtipo_proveedor = New System.Windows.Forms.ComboBox
       Me.etiquetaid_tipo_proveedor = New System.Windows.Forms.Label
       Me.SuspendLayout()
       '
       'txtnombre_proveedor
       '
       Me.txtnombre_proveedor.BackColor = System.Drawing.Color.White
       Me.txtnombre_proveedor.Location = New System.Drawing.Point(161, 48)
       Me.txtnombre_proveedor.Size = New System.Drawing.Size(385, 20)
       Me.txtnombre_proveedor.MaxLength = 50
       Me.txtnombre_proveedor.Name = "txtnombre_proveedor"
       Me.txtnombre_proveedor.TabIndex = 4
       '
       'etiquietanombre_proveedor
       '
       Me.etiquetanombre_proveedor.BackColor = System.Drawing.Color.Transparent
       Me.etiquetanombre_proveedor.AutoSize = True
       Me.etiquetanombre_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetanombre_proveedor.ForeColor = System.Drawing.Color.Black
       Me.etiquetanombre_proveedor.Location = New System.Drawing.Point(28, 48)
       Me.etiquetanombre_proveedor.Name = "etiquetanombre_proveedor"
       Me.etiquetanombre_proveedor.Size = New System.Drawing.Size(127, 21)
       Me.etiquetanombre_proveedor.TabIndex = 500
       Me.etiquetanombre_proveedor.Text = "Nombre proveedor"
       Me.etiquetanombre_proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtcontacto
       '
       Me.txtcontacto.BackColor = System.Drawing.Color.White
       Me.txtcontacto.Location = New System.Drawing.Point(161, 91)
       Me.txtcontacto.Size = New System.Drawing.Size(385, 20)
       Me.txtcontacto.MaxLength = 50
       Me.txtcontacto.Name = "txtcontacto"
       Me.txtcontacto.TabIndex = 5
       '
       'etiquietacontacto
       '
       Me.etiquetacontacto.BackColor = System.Drawing.Color.Transparent
       Me.etiquetacontacto.AutoSize = True
       Me.etiquetacontacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetacontacto.ForeColor = System.Drawing.Color.Black
       Me.etiquetacontacto.Location = New System.Drawing.Point(28, 91)
       Me.etiquetacontacto.Name = "etiquetacontacto"
       Me.etiquetacontacto.Size = New System.Drawing.Size(127, 21)
       Me.etiquetacontacto.TabIndex = 501
       Me.etiquetacontacto.Text = "Contacto"
       Me.etiquetacontacto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtcuit
       '
       Me.txtcuit.BackColor = System.Drawing.Color.White
       Me.txtcuit.Location = New System.Drawing.Point(161, 134)
       Me.txtcuit.Size = New System.Drawing.Size(385, 20)
       Me.txtcuit.MaxLength = 50
       Me.txtcuit.Name = "txtcuit"
       Me.txtcuit.TabIndex = 6
       '
       'etiquietacuit
       '
       Me.etiquetacuit.BackColor = System.Drawing.Color.Transparent
       Me.etiquetacuit.AutoSize = True
       Me.etiquetacuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetacuit.ForeColor = System.Drawing.Color.Black
       Me.etiquetacuit.Location = New System.Drawing.Point(28, 134)
       Me.etiquetacuit.Name = "etiquetacuit"
       Me.etiquetacuit.Size = New System.Drawing.Size(127, 21)
       Me.etiquetacuit.TabIndex = 502
       Me.etiquetacuit.Text = "Cuit"
       Me.etiquetacuit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtingreso_bruto
       '
       Me.txtingreso_bruto.BackColor = System.Drawing.Color.White
       Me.txtingreso_bruto.Location = New System.Drawing.Point(161, 177)
       Me.txtingreso_bruto.Size = New System.Drawing.Size(385, 20)
       Me.txtingreso_bruto.MaxLength = 50
       Me.txtingreso_bruto.Name = "txtingreso_bruto"
       Me.txtingreso_bruto.TabIndex = 7
       '
       'etiquietaingreso_bruto
       '
       Me.etiquetaingreso_bruto.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaingreso_bruto.AutoSize = True
       Me.etiquetaingreso_bruto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaingreso_bruto.ForeColor = System.Drawing.Color.Black
       Me.etiquetaingreso_bruto.Location = New System.Drawing.Point(28, 177)
       Me.etiquetaingreso_bruto.Name = "etiquetaingreso_bruto"
       Me.etiquetaingreso_bruto.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaingreso_bruto.TabIndex = 503
       Me.etiquetaingreso_bruto.Text = "Ingreso bruto"
       Me.etiquetaingreso_bruto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtdireccion
       '
       Me.txtdireccion.BackColor = System.Drawing.Color.White
       Me.txtdireccion.Location = New System.Drawing.Point(161, 220)
       Me.txtdireccion.Size = New System.Drawing.Size(385, 20)
       Me.txtdireccion.MaxLength = 100
       Me.txtdireccion.Name = "txtdireccion"
       Me.txtdireccion.TabIndex = 8
       '
       'etiquietadireccion
       '
       Me.etiquetadireccion.BackColor = System.Drawing.Color.Transparent
       Me.etiquetadireccion.AutoSize = True
       Me.etiquetadireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetadireccion.ForeColor = System.Drawing.Color.Black
       Me.etiquetadireccion.Location = New System.Drawing.Point(28, 220)
       Me.etiquetadireccion.Name = "etiquetadireccion"
       Me.etiquetadireccion.Size = New System.Drawing.Size(127, 21)
       Me.etiquetadireccion.TabIndex = 504
       Me.etiquetadireccion.Text = "Direccion"
       Me.etiquetadireccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtlocalidad
       '
       Me.txtlocalidad.BackColor = System.Drawing.Color.White
       Me.txtlocalidad.Location = New System.Drawing.Point(161, 263)
       Me.txtlocalidad.Size = New System.Drawing.Size(385, 20)
       Me.txtlocalidad.MaxLength = 50
       Me.txtlocalidad.Name = "txtlocalidad"
       Me.txtlocalidad.TabIndex = 9
       '
       'etiquietalocalidad
       '
       Me.etiquetalocalidad.BackColor = System.Drawing.Color.Transparent
       Me.etiquetalocalidad.AutoSize = True
       Me.etiquetalocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetalocalidad.ForeColor = System.Drawing.Color.Black
       Me.etiquetalocalidad.Location = New System.Drawing.Point(28, 263)
       Me.etiquetalocalidad.Name = "etiquetalocalidad"
       Me.etiquetalocalidad.Size = New System.Drawing.Size(127, 21)
       Me.etiquetalocalidad.TabIndex = 505
       Me.etiquetalocalidad.Text = "Localidad"
       Me.etiquetalocalidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtprovincia
       '
       Me.txtprovincia.BackColor = System.Drawing.Color.White
       Me.txtprovincia.Location = New System.Drawing.Point(161, 306)
       Me.txtprovincia.Size = New System.Drawing.Size(385, 20)
       Me.txtprovincia.MaxLength = 50
       Me.txtprovincia.Name = "txtprovincia"
       Me.txtprovincia.TabIndex = 10
       '
       'etiquietaprovincia
       '
       Me.etiquetaprovincia.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaprovincia.AutoSize = True
       Me.etiquetaprovincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaprovincia.ForeColor = System.Drawing.Color.Black
       Me.etiquetaprovincia.Location = New System.Drawing.Point(28, 306)
       Me.etiquetaprovincia.Name = "etiquetaprovincia"
       Me.etiquetaprovincia.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaprovincia.TabIndex = 506
       Me.etiquetaprovincia.Text = "Provincia"
       Me.etiquetaprovincia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txttelefono
       '
       Me.txttelefono.BackColor = System.Drawing.Color.White
       Me.txttelefono.Location = New System.Drawing.Point(161, 349)
       Me.txttelefono.Size = New System.Drawing.Size(385, 20)
       Me.txttelefono.MaxLength = 50
       Me.txttelefono.Name = "txttelefono"
       Me.txttelefono.TabIndex = 11
       '
       'etiquietatelefono
       '
       Me.etiquetatelefono.BackColor = System.Drawing.Color.Transparent
       Me.etiquetatelefono.AutoSize = True
       Me.etiquetatelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetatelefono.ForeColor = System.Drawing.Color.Black
       Me.etiquetatelefono.Location = New System.Drawing.Point(28, 349)
       Me.etiquetatelefono.Name = "etiquetatelefono"
       Me.etiquetatelefono.Size = New System.Drawing.Size(127, 21)
       Me.etiquetatelefono.TabIndex = 507
       Me.etiquetatelefono.Text = "Telefono"
       Me.etiquetatelefono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtemail
       '
       Me.txtemail.BackColor = System.Drawing.Color.White
       Me.txtemail.Location = New System.Drawing.Point(161, 392)
       Me.txtemail.Size = New System.Drawing.Size(385, 20)
       Me.txtemail.MaxLength = 50
       Me.txtemail.Name = "txtemail"
       Me.txtemail.TabIndex = 12
       '
       'etiquietaemail
       '
       Me.etiquetaemail.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaemail.AutoSize = True
       Me.etiquetaemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaemail.ForeColor = System.Drawing.Color.Black
       Me.etiquetaemail.Location = New System.Drawing.Point(28, 392)
       Me.etiquetaemail.Name = "etiquetaemail"
       Me.etiquetaemail.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaemail.TabIndex = 508
       Me.etiquetaemail.Text = "Email"
       Me.etiquetaemail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtweb
       '
       Me.txtweb.BackColor = System.Drawing.Color.White
       Me.txtweb.Location = New System.Drawing.Point(161, 435)
       Me.txtweb.Size = New System.Drawing.Size(385, 20)
       Me.txtweb.MaxLength = 50
       Me.txtweb.Name = "txtweb"
       Me.txtweb.TabIndex = 13
       '
       'etiquietaweb
       '
       Me.etiquetaweb.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaweb.AutoSize = True
       Me.etiquetaweb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaweb.ForeColor = System.Drawing.Color.Black
       Me.etiquetaweb.Location = New System.Drawing.Point(28, 435)
       Me.etiquetaweb.Name = "etiquetaweb"
       Me.etiquetaweb.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaweb.TabIndex = 509
       Me.etiquetaweb.Text = "Web"
       Me.etiquetaweb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblid_condicion_iva
       '
       Me.lblid_condicion_iva.AutoSize = True
       Me.lblid_condicion_iva.BackColor = System.Drawing.Color.Red
       Me.lblid_condicion_iva.Location = New System.Drawing.Point(370, 478)
       Me.lblid_condicion_iva.Name = "lblid_condicion_iva"
       Me.lblid_condicion_iva.Size = New System.Drawing.Size(13, 13)
       Me.lblid_condicion_iva.TabIndex = 510
       Me.lblid_condicion_iva.Text = "0"
       Me.lblid_condicion_iva.Visible = False
       '
       'btnBuscacondicion_iva
       '
       Me.btnBuscacondicion_iva.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscacondicion_iva.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscacondicion_iva.Location = New System.Drawing.Point(505, 478)
       Me.btnBuscacondicion_iva.Name = "btnBuscacondicion_iva"
       Me.btnBuscacondicion_iva.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscacondicion_iva.TabIndex = 60
       Me.btnBuscacondicion_iva.UseVisualStyleBackColor = True
       '
       'cmbcondicion_iva
       '
       Me.cmbcondicion_iva.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbcondicion_iva.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbcondicion_iva.FormattingEnabled = True
       Me.cmbcondicion_iva.Location = New System.Drawing.Point(161, 478)
       Me.cmbcondicion_iva.Size = New System.Drawing.Size(329, 21)
       Me.cmbcondicion_iva.Name = "cmbcondicion_iva"
       Me.cmbcondicion_iva.TabIndex = 14
       '
       'etiquietaid_condicion_iva
       '
       Me.etiquetaid_condicion_iva.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_condicion_iva.AutoSize = True
       Me.etiquetaid_condicion_iva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_condicion_iva.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_condicion_iva.Location = New System.Drawing.Point(28, 478)
       Me.etiquetaid_condicion_iva.Name = "etiquetaid_condicion_iva"
       Me.etiquetaid_condicion_iva.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_condicion_iva.TabIndex = 511
       Me.etiquetaid_condicion_iva.Text = "Condicion iva"
       Me.etiquetaid_condicion_iva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblid_tipo_proveedor
       '
       Me.lblid_tipo_proveedor.AutoSize = True
       Me.lblid_tipo_proveedor.BackColor = System.Drawing.Color.Red
       Me.lblid_tipo_proveedor.Location = New System.Drawing.Point(370, 521)
       Me.lblid_tipo_proveedor.Name = "lblid_tipo_proveedor"
       Me.lblid_tipo_proveedor.Size = New System.Drawing.Size(13, 13)
       Me.lblid_tipo_proveedor.TabIndex = 512
       Me.lblid_tipo_proveedor.Text = "0"
       Me.lblid_tipo_proveedor.Visible = False
       '
       'btnBuscatipo_proveedor
       '
       Me.btnBuscatipo_proveedor.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscatipo_proveedor.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscatipo_proveedor.Location = New System.Drawing.Point(505, 521)
       Me.btnBuscatipo_proveedor.Name = "btnBuscatipo_proveedor"
       Me.btnBuscatipo_proveedor.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscatipo_proveedor.TabIndex = 61
       Me.btnBuscatipo_proveedor.UseVisualStyleBackColor = True
       '
       'cmbtipo_proveedor
       '
       Me.cmbtipo_proveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbtipo_proveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbtipo_proveedor.FormattingEnabled = True
       Me.cmbtipo_proveedor.Location = New System.Drawing.Point(161, 521)
       Me.cmbtipo_proveedor.Size = New System.Drawing.Size(329, 21)
       Me.cmbtipo_proveedor.Name = "cmbtipo_proveedor"
       Me.cmbtipo_proveedor.TabIndex = 15
       '
       'etiquietaid_tipo_proveedor
       '
       Me.etiquetaid_tipo_proveedor.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_tipo_proveedor.AutoSize = True
       Me.etiquetaid_tipo_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_tipo_proveedor.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_tipo_proveedor.Location = New System.Drawing.Point(28, 521)
       Me.etiquetaid_tipo_proveedor.Name = "etiquetaid_tipo_proveedor"
       Me.etiquetaid_tipo_proveedor.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_tipo_proveedor.TabIndex = 513
       Me.etiquetaid_tipo_proveedor.Text = "Tipo proveedor"
       Me.etiquetaid_tipo_proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
       Me.btnSalir.Location = New System.Drawing.Point(499, 604)
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
       Me.btnGuardar.Location = New System.Drawing.Point(392,604)
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
       Me.GroupBox1.Size = New System.Drawing.Size(568, 564)
       Me.GroupBox1.TabIndex = 0
       Me.GroupBox1.TabStop = False
       '
       'frmDetalleProveedor
       '
       Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
       Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
       Me.ClientSize = New System.Drawing.Size(600, 684)
       Me.Controls.Add(Me.txtnombre_proveedor)
       Me.Controls.Add(Me.etiquetanombre_proveedor)
       Me.Controls.Add(Me.txtcontacto)
       Me.Controls.Add(Me.etiquetacontacto)
       Me.Controls.Add(Me.txtcuit)
       Me.Controls.Add(Me.etiquetacuit)
       Me.Controls.Add(Me.txtingreso_bruto)
       Me.Controls.Add(Me.etiquetaingreso_bruto)
       Me.Controls.Add(Me.txtdireccion)
       Me.Controls.Add(Me.etiquetadireccion)
       Me.Controls.Add(Me.txtlocalidad)
       Me.Controls.Add(Me.etiquetalocalidad)
       Me.Controls.Add(Me.txtprovincia)
       Me.Controls.Add(Me.etiquetaprovincia)
       Me.Controls.Add(Me.txttelefono)
       Me.Controls.Add(Me.etiquetatelefono)
       Me.Controls.Add(Me.txtemail)
       Me.Controls.Add(Me.etiquetaemail)
       Me.Controls.Add(Me.txtweb)
       Me.Controls.Add(Me.etiquetaweb)
       Me.Controls.Add(Me.lblid_condicion_iva)
       Me.Controls.Add(Me.btnBuscacondicion_iva)
       Me.Controls.Add(Me.cmbcondicion_iva)
       Me.Controls.Add(Me.etiquetaid_condicion_iva)
       Me.Controls.Add(Me.lblid_tipo_proveedor)
       Me.Controls.Add(Me.btnBuscatipo_proveedor)
       Me.Controls.Add(Me.cmbtipo_proveedor)
       Me.Controls.Add(Me.etiquetaid_tipo_proveedor)
       Me.Controls.Add(Me.btnSalir)
       Me.Controls.Add(Me.btnGuardar)
       Me.Controls.Add(Me.GroupBox1)
       Me.Name = "frmDetalleProveedor"
       Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
       Me.Text = "frmDetalleProveedor" & vgNombreFormulario
       Me.ResumeLayout(False)
       Me.PerformLayout()

   End Sub
   Protected WithEvents txtnombre_proveedor As System.Windows.Forms.TextBox
   Friend WithEvents etiquetanombre_proveedor As System.Windows.Forms.Label
   Protected WithEvents txtcontacto As System.Windows.Forms.TextBox
   Friend WithEvents etiquetacontacto As System.Windows.Forms.Label
   Protected WithEvents txtcuit As System.Windows.Forms.TextBox
   Friend WithEvents etiquetacuit As System.Windows.Forms.Label
   Protected WithEvents txtingreso_bruto As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaingreso_bruto As System.Windows.Forms.Label
   Protected WithEvents txtdireccion As System.Windows.Forms.TextBox
   Friend WithEvents etiquetadireccion As System.Windows.Forms.Label
   Protected WithEvents txtlocalidad As System.Windows.Forms.TextBox
   Friend WithEvents etiquetalocalidad As System.Windows.Forms.Label
   Protected WithEvents txtprovincia As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaprovincia As System.Windows.Forms.Label
   Protected WithEvents txttelefono As System.Windows.Forms.TextBox
   Friend WithEvents etiquetatelefono As System.Windows.Forms.Label
   Protected WithEvents txtemail As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaemail As System.Windows.Forms.Label
   Protected WithEvents txtweb As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaweb As System.Windows.Forms.Label
   Friend WithEvents lblid_condicion_iva As System.Windows.Forms.Label
   Friend WithEvents btnBuscacondicion_iva As System.Windows.Forms.Button
   Friend WithEvents cmbcondicion_iva As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_condicion_iva As System.Windows.Forms.Label
   Friend WithEvents lblid_tipo_proveedor As System.Windows.Forms.Label
   Friend WithEvents btnBuscatipo_proveedor As System.Windows.Forms.Button
   Friend WithEvents cmbtipo_proveedor As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_tipo_proveedor As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
End Class

