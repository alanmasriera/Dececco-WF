<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleEmpleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleEmpleado))
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtlegajo = New System.Windows.Forms.TextBox
        Me.etiquetalegajo = New System.Windows.Forms.Label
        Me.txtapellido = New System.Windows.Forms.TextBox
        Me.etiquetaapellido = New System.Windows.Forms.Label
        Me.txtnombre = New System.Windows.Forms.TextBox
        Me.etiquetanombre = New System.Windows.Forms.Label
        Me.txtcuil = New System.Windows.Forms.TextBox
        Me.etiquetacuil = New System.Windows.Forms.Label
        Me.dtpnacimiento = New System.Windows.Forms.DateTimePicker
        Me.etiquetanacimiento = New System.Windows.Forms.Label
        Me.txtdomicilio = New System.Windows.Forms.TextBox
        Me.etiquetadomicilio = New System.Windows.Forms.Label
        Me.txtlocalidad = New System.Windows.Forms.TextBox
        Me.etiquetalocalidad = New System.Windows.Forms.Label
        Me.txtcp = New System.Windows.Forms.TextBox
        Me.etiquetacp = New System.Windows.Forms.Label
        Me.txtprovincia = New System.Windows.Forms.TextBox
        Me.etiquetaprovincia = New System.Windows.Forms.Label
        Me.txtnacionalidad = New System.Windows.Forms.TextBox
        Me.etiquetanacionalidad = New System.Windows.Forms.Label
        Me.txtestado_civil = New System.Windows.Forms.TextBox
        Me.etiquetaestado_civil = New System.Windows.Forms.Label
        Me.txttelefono = New System.Windows.Forms.TextBox
        Me.etiquetatelefono = New System.Windows.Forms.Label
        Me.dtpcasamiento = New System.Windows.Forms.DateTimePicker
        Me.etiquetacasamiento = New System.Windows.Forms.Label
        Me.txtlugar_nacimiento = New System.Windows.Forms.TextBox
        Me.etiquetalugar_nacimiento = New System.Windows.Forms.Label
        Me.txtapellido_conyugue = New System.Windows.Forms.TextBox
        Me.etiquetaapellido_conyugue = New System.Windows.Forms.Label
        Me.txtnombre_conyugue = New System.Windows.Forms.TextBox
        Me.etiquetanombre_conyugue = New System.Windows.Forms.Label
        Me.txtapellido_casado = New System.Windows.Forms.TextBox
        Me.etiquetaapellido_casado = New System.Windows.Forms.Label
        Me.txtdni_conyugue = New System.Windows.Forms.TextBox
        Me.etiquetadni_conyugue = New System.Windows.Forms.Label
        Me.txtapellido_beneficiario = New System.Windows.Forms.TextBox
        Me.etiquetaapellido_beneficiario = New System.Windows.Forms.Label
        Me.txtnombre_beneficiario = New System.Windows.Forms.TextBox
        Me.etiquetanombre_beneficiario = New System.Windows.Forms.Label
        Me.txtdni_beneficiario = New System.Windows.Forms.TextBox
        Me.etiquetadni_beneficiario = New System.Windows.Forms.Label
        Me.dtpingreso = New System.Windows.Forms.DateTimePicker
        Me.etiquetaingreso = New System.Windows.Forms.Label
        Me.dtpreviza = New System.Windows.Forms.DateTimePicker
        Me.etiquetareviza = New System.Windows.Forms.Label
        Me.chkdesabilitado = New System.Windows.Forms.CheckBox
        Me.etiquetadesabilitado = New System.Windows.Forms.Label
        Me.lblid_tipo_empleado = New System.Windows.Forms.Label
        Me.btnBuscatipo_empleado = New System.Windows.Forms.Button
        Me.cmbtipo_empleado = New System.Windows.Forms.ComboBox
        Me.etiquetaid_tipo_empleado = New System.Windows.Forms.Label
        Me.txtsexo = New System.Windows.Forms.TextBox
        Me.etiquetasexo = New System.Windows.Forms.Label
        Me.txtpais = New System.Windows.Forms.TextBox
        Me.etiquetapais = New System.Windows.Forms.Label
        Me.txtdni = New System.Windows.Forms.TextBox
        Me.etiquetadni = New System.Windows.Forms.Label
        Me.txttipo_dni = New System.Windows.Forms.TextBox
        Me.etiquetatipo_dni = New System.Windows.Forms.Label
        Me.dtpegreso = New System.Windows.Forms.DateTimePicker
        Me.etiquetaegreso = New System.Windows.Forms.Label
        Me.txtmodalidad_trabajo = New System.Windows.Forms.TextBox
        Me.etiquetamodalidad_trabajo = New System.Windows.Forms.Label
        Me.lblid_obra_social = New System.Windows.Forms.Label
        Me.btnBuscaobra_social = New System.Windows.Forms.Button
        Me.cmbobra_social = New System.Windows.Forms.ComboBox
        Me.etiquetaid_obra_social = New System.Windows.Forms.Label
        Me.txttarea = New System.Windows.Forms.TextBox
        Me.etiquetatarea = New System.Windows.Forms.Label
        Me.txtvalor_hora = New System.Windows.Forms.TextBox
        Me.etiquetavalor_hora = New System.Windows.Forms.Label
        Me.chkcoordinador = New System.Windows.Forms.CheckBox
        Me.etiquetacoordinador = New System.Windows.Forms.Label
        Me.txthijo = New System.Windows.Forms.TextBox
        Me.etiquetahijo = New System.Windows.Forms.Label
        Me.txtvalor_hijo = New System.Windows.Forms.TextBox
        Me.etiquetavalor_hijo = New System.Windows.Forms.Label
        Me.txtsalario_mvm = New System.Windows.Forms.TextBox
        Me.etiquetasalario_mvm = New System.Windows.Forms.Label
        Me.txtadicional_obra_social = New System.Windows.Forms.TextBox
        Me.etiquetaadicional_obra_social = New System.Windows.Forms.Label
        Me.txthijo_discapacitado = New System.Windows.Forms.TextBox
        Me.etiquetahijo_discapacitado = New System.Windows.Forms.Label
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
        Me.btnSalir.Location = New System.Drawing.Point(906, 944)
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
        Me.btnGuardar.Location = New System.Drawing.Point(802, 944)
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
        Me.GroupBox1.Size = New System.Drawing.Size(983, 911)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtlegajo
        '
        Me.txtlegajo.BackColor = System.Drawing.Color.White
        Me.txtlegajo.Location = New System.Drawing.Point(161, 48)
        Me.txtlegajo.MaxLength = 50
        Me.txtlegajo.Name = "txtlegajo"
        Me.txtlegajo.Size = New System.Drawing.Size(311, 20)
        Me.txtlegajo.TabIndex = 4
        '
        'etiquetalegajo
        '
        Me.etiquetalegajo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetalegajo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetalegajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetalegajo.ForeColor = System.Drawing.Color.Black
        Me.etiquetalegajo.Location = New System.Drawing.Point(28, 48)
        Me.etiquetalegajo.Name = "etiquetalegajo"
        Me.etiquetalegajo.Size = New System.Drawing.Size(127, 21)
        Me.etiquetalegajo.TabIndex = 500
        Me.etiquetalegajo.Text = "Legajo"
        Me.etiquetalegajo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtapellido
        '
        Me.txtapellido.BackColor = System.Drawing.Color.White
        Me.txtapellido.Location = New System.Drawing.Point(161, 91)
        Me.txtapellido.MaxLength = 50
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(311, 20)
        Me.txtapellido.TabIndex = 5
        '
        'etiquetaapellido
        '
        Me.etiquetaapellido.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaapellido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaapellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaapellido.ForeColor = System.Drawing.Color.Black
        Me.etiquetaapellido.Location = New System.Drawing.Point(28, 91)
        Me.etiquetaapellido.Name = "etiquetaapellido"
        Me.etiquetaapellido.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaapellido.TabIndex = 501
        Me.etiquetaapellido.Text = "Apellido"
        Me.etiquetaapellido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtnombre
        '
        Me.txtnombre.BackColor = System.Drawing.Color.White
        Me.txtnombre.Location = New System.Drawing.Point(161, 134)
        Me.txtnombre.MaxLength = 50
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(311, 20)
        Me.txtnombre.TabIndex = 6
        '
        'etiquetanombre
        '
        Me.etiquetanombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetanombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetanombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetanombre.ForeColor = System.Drawing.Color.Black
        Me.etiquetanombre.Location = New System.Drawing.Point(28, 134)
        Me.etiquetanombre.Name = "etiquetanombre"
        Me.etiquetanombre.Size = New System.Drawing.Size(127, 21)
        Me.etiquetanombre.TabIndex = 502
        Me.etiquetanombre.Text = "Nombre"
        Me.etiquetanombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcuil
        '
        Me.txtcuil.BackColor = System.Drawing.Color.White
        Me.txtcuil.Location = New System.Drawing.Point(161, 177)
        Me.txtcuil.MaxLength = 50
        Me.txtcuil.Name = "txtcuil"
        Me.txtcuil.Size = New System.Drawing.Size(311, 20)
        Me.txtcuil.TabIndex = 7
        '
        'etiquetacuil
        '
        Me.etiquetacuil.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetacuil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetacuil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetacuil.ForeColor = System.Drawing.Color.Black
        Me.etiquetacuil.Location = New System.Drawing.Point(28, 177)
        Me.etiquetacuil.Name = "etiquetacuil"
        Me.etiquetacuil.Size = New System.Drawing.Size(127, 21)
        Me.etiquetacuil.TabIndex = 503
        Me.etiquetacuil.Text = "Cuil"
        Me.etiquetacuil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpnacimiento
        '
        Me.dtpnacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpnacimiento.Location = New System.Drawing.Point(161, 220)
        Me.dtpnacimiento.Name = "dtpnacimiento"
        Me.dtpnacimiento.Size = New System.Drawing.Size(93, 20)
        Me.dtpnacimiento.TabIndex = 8
        '
        'etiquetanacimiento
        '
        Me.etiquetanacimiento.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetanacimiento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetanacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetanacimiento.ForeColor = System.Drawing.Color.Black
        Me.etiquetanacimiento.Location = New System.Drawing.Point(28, 220)
        Me.etiquetanacimiento.Name = "etiquetanacimiento"
        Me.etiquetanacimiento.Size = New System.Drawing.Size(127, 21)
        Me.etiquetanacimiento.TabIndex = 504
        Me.etiquetanacimiento.Text = "Nacimiento"
        Me.etiquetanacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtdomicilio
        '
        Me.txtdomicilio.BackColor = System.Drawing.Color.White
        Me.txtdomicilio.Location = New System.Drawing.Point(161, 263)
        Me.txtdomicilio.MaxLength = 50
        Me.txtdomicilio.Name = "txtdomicilio"
        Me.txtdomicilio.Size = New System.Drawing.Size(311, 20)
        Me.txtdomicilio.TabIndex = 9
        '
        'etiquetadomicilio
        '
        Me.etiquetadomicilio.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetadomicilio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetadomicilio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetadomicilio.ForeColor = System.Drawing.Color.Black
        Me.etiquetadomicilio.Location = New System.Drawing.Point(28, 263)
        Me.etiquetadomicilio.Name = "etiquetadomicilio"
        Me.etiquetadomicilio.Size = New System.Drawing.Size(127, 21)
        Me.etiquetadomicilio.TabIndex = 505
        Me.etiquetadomicilio.Text = "Domicilio"
        Me.etiquetadomicilio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtlocalidad
        '
        Me.txtlocalidad.BackColor = System.Drawing.Color.White
        Me.txtlocalidad.Location = New System.Drawing.Point(161, 306)
        Me.txtlocalidad.MaxLength = 50
        Me.txtlocalidad.Name = "txtlocalidad"
        Me.txtlocalidad.Size = New System.Drawing.Size(311, 20)
        Me.txtlocalidad.TabIndex = 10
        '
        'etiquetalocalidad
        '
        Me.etiquetalocalidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetalocalidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetalocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetalocalidad.ForeColor = System.Drawing.Color.Black
        Me.etiquetalocalidad.Location = New System.Drawing.Point(28, 306)
        Me.etiquetalocalidad.Name = "etiquetalocalidad"
        Me.etiquetalocalidad.Size = New System.Drawing.Size(127, 21)
        Me.etiquetalocalidad.TabIndex = 506
        Me.etiquetalocalidad.Text = "Localidad"
        Me.etiquetalocalidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcp
        '
        Me.txtcp.BackColor = System.Drawing.Color.White
        Me.txtcp.Location = New System.Drawing.Point(161, 349)
        Me.txtcp.MaxLength = 50
        Me.txtcp.Name = "txtcp"
        Me.txtcp.Size = New System.Drawing.Size(311, 20)
        Me.txtcp.TabIndex = 11
        '
        'etiquetacp
        '
        Me.etiquetacp.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetacp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetacp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetacp.ForeColor = System.Drawing.Color.Black
        Me.etiquetacp.Location = New System.Drawing.Point(28, 349)
        Me.etiquetacp.Name = "etiquetacp"
        Me.etiquetacp.Size = New System.Drawing.Size(127, 21)
        Me.etiquetacp.TabIndex = 507
        Me.etiquetacp.Text = "Cp"
        Me.etiquetacp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtprovincia
        '
        Me.txtprovincia.BackColor = System.Drawing.Color.White
        Me.txtprovincia.Location = New System.Drawing.Point(161, 392)
        Me.txtprovincia.MaxLength = 50
        Me.txtprovincia.Name = "txtprovincia"
        Me.txtprovincia.Size = New System.Drawing.Size(311, 20)
        Me.txtprovincia.TabIndex = 12
        '
        'etiquetaprovincia
        '
        Me.etiquetaprovincia.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaprovincia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaprovincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaprovincia.ForeColor = System.Drawing.Color.Black
        Me.etiquetaprovincia.Location = New System.Drawing.Point(28, 392)
        Me.etiquetaprovincia.Name = "etiquetaprovincia"
        Me.etiquetaprovincia.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaprovincia.TabIndex = 508
        Me.etiquetaprovincia.Text = "Provincia"
        Me.etiquetaprovincia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtnacionalidad
        '
        Me.txtnacionalidad.BackColor = System.Drawing.Color.White
        Me.txtnacionalidad.Location = New System.Drawing.Point(161, 435)
        Me.txtnacionalidad.MaxLength = 50
        Me.txtnacionalidad.Name = "txtnacionalidad"
        Me.txtnacionalidad.Size = New System.Drawing.Size(311, 20)
        Me.txtnacionalidad.TabIndex = 13
        '
        'etiquetanacionalidad
        '
        Me.etiquetanacionalidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetanacionalidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetanacionalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetanacionalidad.ForeColor = System.Drawing.Color.Black
        Me.etiquetanacionalidad.Location = New System.Drawing.Point(28, 435)
        Me.etiquetanacionalidad.Name = "etiquetanacionalidad"
        Me.etiquetanacionalidad.Size = New System.Drawing.Size(127, 21)
        Me.etiquetanacionalidad.TabIndex = 509
        Me.etiquetanacionalidad.Text = "Nacionalidad"
        Me.etiquetanacionalidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtestado_civil
        '
        Me.txtestado_civil.BackColor = System.Drawing.Color.White
        Me.txtestado_civil.Location = New System.Drawing.Point(161, 478)
        Me.txtestado_civil.MaxLength = 50
        Me.txtestado_civil.Name = "txtestado_civil"
        Me.txtestado_civil.Size = New System.Drawing.Size(311, 20)
        Me.txtestado_civil.TabIndex = 14
        '
        'etiquetaestado_civil
        '
        Me.etiquetaestado_civil.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaestado_civil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaestado_civil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaestado_civil.ForeColor = System.Drawing.Color.Black
        Me.etiquetaestado_civil.Location = New System.Drawing.Point(28, 478)
        Me.etiquetaestado_civil.Name = "etiquetaestado_civil"
        Me.etiquetaestado_civil.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaestado_civil.TabIndex = 510
        Me.etiquetaestado_civil.Text = "Estado_civil"
        Me.etiquetaestado_civil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txttelefono
        '
        Me.txttelefono.BackColor = System.Drawing.Color.White
        Me.txttelefono.Location = New System.Drawing.Point(161, 521)
        Me.txttelefono.MaxLength = 50
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(311, 20)
        Me.txttelefono.TabIndex = 15
        '
        'etiquetatelefono
        '
        Me.etiquetatelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetatelefono.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetatelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetatelefono.ForeColor = System.Drawing.Color.Black
        Me.etiquetatelefono.Location = New System.Drawing.Point(28, 521)
        Me.etiquetatelefono.Name = "etiquetatelefono"
        Me.etiquetatelefono.Size = New System.Drawing.Size(127, 21)
        Me.etiquetatelefono.TabIndex = 511
        Me.etiquetatelefono.Text = "Telefono"
        Me.etiquetatelefono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpcasamiento
        '
        Me.dtpcasamiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpcasamiento.Location = New System.Drawing.Point(161, 564)
        Me.dtpcasamiento.Name = "dtpcasamiento"
        Me.dtpcasamiento.Size = New System.Drawing.Size(93, 20)
        Me.dtpcasamiento.TabIndex = 16
        '
        'etiquetacasamiento
        '
        Me.etiquetacasamiento.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetacasamiento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetacasamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetacasamiento.ForeColor = System.Drawing.Color.Black
        Me.etiquetacasamiento.Location = New System.Drawing.Point(28, 564)
        Me.etiquetacasamiento.Name = "etiquetacasamiento"
        Me.etiquetacasamiento.Size = New System.Drawing.Size(127, 21)
        Me.etiquetacasamiento.TabIndex = 512
        Me.etiquetacasamiento.Text = "Casamiento"
        Me.etiquetacasamiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtlugar_nacimiento
        '
        Me.txtlugar_nacimiento.BackColor = System.Drawing.Color.White
        Me.txtlugar_nacimiento.Location = New System.Drawing.Point(161, 599)
        Me.txtlugar_nacimiento.MaxLength = 50
        Me.txtlugar_nacimiento.Name = "txtlugar_nacimiento"
        Me.txtlugar_nacimiento.Size = New System.Drawing.Size(311, 20)
        Me.txtlugar_nacimiento.TabIndex = 17
        '
        'etiquetalugar_nacimiento
        '
        Me.etiquetalugar_nacimiento.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetalugar_nacimiento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetalugar_nacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetalugar_nacimiento.ForeColor = System.Drawing.Color.Black
        Me.etiquetalugar_nacimiento.Location = New System.Drawing.Point(28, 599)
        Me.etiquetalugar_nacimiento.Name = "etiquetalugar_nacimiento"
        Me.etiquetalugar_nacimiento.Size = New System.Drawing.Size(127, 21)
        Me.etiquetalugar_nacimiento.TabIndex = 513
        Me.etiquetalugar_nacimiento.Text = "Lugar_nacimiento"
        Me.etiquetalugar_nacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtapellido_conyugue
        '
        Me.txtapellido_conyugue.BackColor = System.Drawing.Color.White
        Me.txtapellido_conyugue.Location = New System.Drawing.Point(161, 642)
        Me.txtapellido_conyugue.MaxLength = 50
        Me.txtapellido_conyugue.Name = "txtapellido_conyugue"
        Me.txtapellido_conyugue.Size = New System.Drawing.Size(311, 20)
        Me.txtapellido_conyugue.TabIndex = 18
        '
        'etiquetaapellido_conyugue
        '
        Me.etiquetaapellido_conyugue.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaapellido_conyugue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaapellido_conyugue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaapellido_conyugue.ForeColor = System.Drawing.Color.Black
        Me.etiquetaapellido_conyugue.Location = New System.Drawing.Point(28, 642)
        Me.etiquetaapellido_conyugue.Name = "etiquetaapellido_conyugue"
        Me.etiquetaapellido_conyugue.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaapellido_conyugue.TabIndex = 514
        Me.etiquetaapellido_conyugue.Text = "Apellido_conyugue"
        Me.etiquetaapellido_conyugue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtnombre_conyugue
        '
        Me.txtnombre_conyugue.BackColor = System.Drawing.Color.White
        Me.txtnombre_conyugue.Location = New System.Drawing.Point(161, 685)
        Me.txtnombre_conyugue.MaxLength = 50
        Me.txtnombre_conyugue.Name = "txtnombre_conyugue"
        Me.txtnombre_conyugue.Size = New System.Drawing.Size(311, 20)
        Me.txtnombre_conyugue.TabIndex = 19
        '
        'etiquetanombre_conyugue
        '
        Me.etiquetanombre_conyugue.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetanombre_conyugue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetanombre_conyugue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetanombre_conyugue.ForeColor = System.Drawing.Color.Black
        Me.etiquetanombre_conyugue.Location = New System.Drawing.Point(28, 685)
        Me.etiquetanombre_conyugue.Name = "etiquetanombre_conyugue"
        Me.etiquetanombre_conyugue.Size = New System.Drawing.Size(127, 21)
        Me.etiquetanombre_conyugue.TabIndex = 515
        Me.etiquetanombre_conyugue.Text = "Nombre_conyugue"
        Me.etiquetanombre_conyugue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtapellido_casado
        '
        Me.txtapellido_casado.BackColor = System.Drawing.Color.White
        Me.txtapellido_casado.Location = New System.Drawing.Point(161, 721)
        Me.txtapellido_casado.MaxLength = 50
        Me.txtapellido_casado.Name = "txtapellido_casado"
        Me.txtapellido_casado.Size = New System.Drawing.Size(311, 20)
        Me.txtapellido_casado.TabIndex = 20
        '
        'etiquetaapellido_casado
        '
        Me.etiquetaapellido_casado.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaapellido_casado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaapellido_casado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaapellido_casado.ForeColor = System.Drawing.Color.Black
        Me.etiquetaapellido_casado.Location = New System.Drawing.Point(28, 721)
        Me.etiquetaapellido_casado.Name = "etiquetaapellido_casado"
        Me.etiquetaapellido_casado.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaapellido_casado.TabIndex = 516
        Me.etiquetaapellido_casado.Text = "Apellido_casado"
        Me.etiquetaapellido_casado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtdni_conyugue
        '
        Me.txtdni_conyugue.BackColor = System.Drawing.Color.White
        Me.txtdni_conyugue.Location = New System.Drawing.Point(161, 764)
        Me.txtdni_conyugue.MaxLength = 50
        Me.txtdni_conyugue.Name = "txtdni_conyugue"
        Me.txtdni_conyugue.Size = New System.Drawing.Size(311, 20)
        Me.txtdni_conyugue.TabIndex = 21
        '
        'etiquetadni_conyugue
        '
        Me.etiquetadni_conyugue.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetadni_conyugue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetadni_conyugue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetadni_conyugue.ForeColor = System.Drawing.Color.Black
        Me.etiquetadni_conyugue.Location = New System.Drawing.Point(28, 764)
        Me.etiquetadni_conyugue.Name = "etiquetadni_conyugue"
        Me.etiquetadni_conyugue.Size = New System.Drawing.Size(127, 21)
        Me.etiquetadni_conyugue.TabIndex = 517
        Me.etiquetadni_conyugue.Text = "Dni_conyugue"
        Me.etiquetadni_conyugue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtapellido_beneficiario
        '
        Me.txtapellido_beneficiario.BackColor = System.Drawing.Color.White
        Me.txtapellido_beneficiario.Location = New System.Drawing.Point(161, 807)
        Me.txtapellido_beneficiario.MaxLength = 50
        Me.txtapellido_beneficiario.Name = "txtapellido_beneficiario"
        Me.txtapellido_beneficiario.Size = New System.Drawing.Size(311, 20)
        Me.txtapellido_beneficiario.TabIndex = 22
        '
        'etiquetaapellido_beneficiario
        '
        Me.etiquetaapellido_beneficiario.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaapellido_beneficiario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaapellido_beneficiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaapellido_beneficiario.ForeColor = System.Drawing.Color.Black
        Me.etiquetaapellido_beneficiario.Location = New System.Drawing.Point(28, 807)
        Me.etiquetaapellido_beneficiario.Name = "etiquetaapellido_beneficiario"
        Me.etiquetaapellido_beneficiario.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaapellido_beneficiario.TabIndex = 518
        Me.etiquetaapellido_beneficiario.Text = "Apellido_beneficiario"
        Me.etiquetaapellido_beneficiario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtnombre_beneficiario
        '
        Me.txtnombre_beneficiario.BackColor = System.Drawing.Color.White
        Me.txtnombre_beneficiario.Location = New System.Drawing.Point(161, 850)
        Me.txtnombre_beneficiario.MaxLength = 50
        Me.txtnombre_beneficiario.Name = "txtnombre_beneficiario"
        Me.txtnombre_beneficiario.Size = New System.Drawing.Size(311, 20)
        Me.txtnombre_beneficiario.TabIndex = 23
        '
        'etiquetanombre_beneficiario
        '
        Me.etiquetanombre_beneficiario.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetanombre_beneficiario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetanombre_beneficiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetanombre_beneficiario.ForeColor = System.Drawing.Color.Black
        Me.etiquetanombre_beneficiario.Location = New System.Drawing.Point(28, 850)
        Me.etiquetanombre_beneficiario.Name = "etiquetanombre_beneficiario"
        Me.etiquetanombre_beneficiario.Size = New System.Drawing.Size(127, 21)
        Me.etiquetanombre_beneficiario.TabIndex = 519
        Me.etiquetanombre_beneficiario.Text = "Nombre_beneficiario"
        Me.etiquetanombre_beneficiario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtdni_beneficiario
        '
        Me.txtdni_beneficiario.BackColor = System.Drawing.Color.White
        Me.txtdni_beneficiario.Location = New System.Drawing.Point(161, 893)
        Me.txtdni_beneficiario.MaxLength = 50
        Me.txtdni_beneficiario.Name = "txtdni_beneficiario"
        Me.txtdni_beneficiario.Size = New System.Drawing.Size(311, 20)
        Me.txtdni_beneficiario.TabIndex = 24
        '
        'etiquetadni_beneficiario
        '
        Me.etiquetadni_beneficiario.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetadni_beneficiario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetadni_beneficiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetadni_beneficiario.ForeColor = System.Drawing.Color.Black
        Me.etiquetadni_beneficiario.Location = New System.Drawing.Point(28, 893)
        Me.etiquetadni_beneficiario.Name = "etiquetadni_beneficiario"
        Me.etiquetadni_beneficiario.Size = New System.Drawing.Size(127, 21)
        Me.etiquetadni_beneficiario.TabIndex = 520
        Me.etiquetadni_beneficiario.Text = "Dni_beneficiario"
        Me.etiquetadni_beneficiario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpingreso
        '
        Me.dtpingreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpingreso.Location = New System.Drawing.Point(635, 47)
        Me.dtpingreso.Name = "dtpingreso"
        Me.dtpingreso.Size = New System.Drawing.Size(93, 20)
        Me.dtpingreso.TabIndex = 25
        '
        'etiquetaingreso
        '
        Me.etiquetaingreso.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaingreso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaingreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaingreso.ForeColor = System.Drawing.Color.Black
        Me.etiquetaingreso.Location = New System.Drawing.Point(489, 48)
        Me.etiquetaingreso.Name = "etiquetaingreso"
        Me.etiquetaingreso.Size = New System.Drawing.Size(140, 21)
        Me.etiquetaingreso.TabIndex = 521
        Me.etiquetaingreso.Text = "Ingreso"
        Me.etiquetaingreso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpreviza
        '
        Me.dtpreviza.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpreviza.Location = New System.Drawing.Point(635, 90)
        Me.dtpreviza.Name = "dtpreviza"
        Me.dtpreviza.Size = New System.Drawing.Size(93, 20)
        Me.dtpreviza.TabIndex = 26
        '
        'etiquetareviza
        '
        Me.etiquetareviza.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetareviza.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetareviza.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetareviza.ForeColor = System.Drawing.Color.Black
        Me.etiquetareviza.Location = New System.Drawing.Point(489, 91)
        Me.etiquetareviza.Name = "etiquetareviza"
        Me.etiquetareviza.Size = New System.Drawing.Size(140, 21)
        Me.etiquetareviza.TabIndex = 522
        Me.etiquetareviza.Text = "Reviza"
        Me.etiquetareviza.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkdesabilitado
        '
        Me.chkdesabilitado.AutoSize = True
        Me.chkdesabilitado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkdesabilitado.Location = New System.Drawing.Point(635, 892)
        Me.chkdesabilitado.Name = "chkdesabilitado"
        Me.chkdesabilitado.Size = New System.Drawing.Size(115, 21)
        Me.chkdesabilitado.TabIndex = 27
        Me.chkdesabilitado.Text = "desabilitado"
        '
        'etiquetadesabilitado
        '
        Me.etiquetadesabilitado.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetadesabilitado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetadesabilitado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetadesabilitado.ForeColor = System.Drawing.Color.Black
        Me.etiquetadesabilitado.Location = New System.Drawing.Point(489, 892)
        Me.etiquetadesabilitado.Name = "etiquetadesabilitado"
        Me.etiquetadesabilitado.Size = New System.Drawing.Size(140, 21)
        Me.etiquetadesabilitado.TabIndex = 523
        Me.etiquetadesabilitado.Text = "Desabilitado"
        Me.etiquetadesabilitado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_tipo_empleado
        '
        Me.lblid_tipo_empleado.AutoSize = True
        Me.lblid_tipo_empleado.BackColor = System.Drawing.Color.Red
        Me.lblid_tipo_empleado.Location = New System.Drawing.Point(854, 133)
        Me.lblid_tipo_empleado.Name = "lblid_tipo_empleado"
        Me.lblid_tipo_empleado.Size = New System.Drawing.Size(13, 13)
        Me.lblid_tipo_empleado.TabIndex = 524
        Me.lblid_tipo_empleado.Text = "0"
        Me.lblid_tipo_empleado.Visible = False
        '
        'btnBuscatipo_empleado
        '
        Me.btnBuscatipo_empleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscatipo_empleado.Image = CType(resources.GetObject("btnBuscatipo_empleado.Image"), System.Drawing.Image)
        Me.btnBuscatipo_empleado.Location = New System.Drawing.Point(941, 134)
        Me.btnBuscatipo_empleado.Name = "btnBuscatipo_empleado"
        Me.btnBuscatipo_empleado.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscatipo_empleado.TabIndex = 30
        Me.btnBuscatipo_empleado.UseVisualStyleBackColor = True
        '
        'cmbtipo_empleado
        '
        Me.cmbtipo_empleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbtipo_empleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbtipo_empleado.FormattingEnabled = True
        Me.cmbtipo_empleado.Location = New System.Drawing.Point(635, 133)
        Me.cmbtipo_empleado.Name = "cmbtipo_empleado"
        Me.cmbtipo_empleado.Size = New System.Drawing.Size(291, 21)
        Me.cmbtipo_empleado.TabIndex = 28
        '
        'etiquetaid_tipo_empleado
        '
        Me.etiquetaid_tipo_empleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_tipo_empleado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_tipo_empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_tipo_empleado.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_tipo_empleado.Location = New System.Drawing.Point(489, 134)
        Me.etiquetaid_tipo_empleado.Name = "etiquetaid_tipo_empleado"
        Me.etiquetaid_tipo_empleado.Size = New System.Drawing.Size(140, 21)
        Me.etiquetaid_tipo_empleado.TabIndex = 525
        Me.etiquetaid_tipo_empleado.Text = "Tipo_empleado"
        Me.etiquetaid_tipo_empleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtsexo
        '
        Me.txtsexo.BackColor = System.Drawing.Color.White
        Me.txtsexo.Location = New System.Drawing.Point(635, 178)
        Me.txtsexo.MaxLength = 1
        Me.txtsexo.Name = "txtsexo"
        Me.txtsexo.Size = New System.Drawing.Size(39, 20)
        Me.txtsexo.TabIndex = 29
        '
        'etiquetasexo
        '
        Me.etiquetasexo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetasexo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetasexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetasexo.ForeColor = System.Drawing.Color.Black
        Me.etiquetasexo.Location = New System.Drawing.Point(489, 178)
        Me.etiquetasexo.Name = "etiquetasexo"
        Me.etiquetasexo.Size = New System.Drawing.Size(140, 21)
        Me.etiquetasexo.TabIndex = 526
        Me.etiquetasexo.Text = "Sexo"
        Me.etiquetasexo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtpais
        '
        Me.txtpais.BackColor = System.Drawing.Color.White
        Me.txtpais.Location = New System.Drawing.Point(635, 221)
        Me.txtpais.MaxLength = 1
        Me.txtpais.Name = "txtpais"
        Me.txtpais.Size = New System.Drawing.Size(39, 20)
        Me.txtpais.TabIndex = 30
        '
        'etiquetapais
        '
        Me.etiquetapais.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetapais.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetapais.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetapais.ForeColor = System.Drawing.Color.Black
        Me.etiquetapais.Location = New System.Drawing.Point(489, 221)
        Me.etiquetapais.Name = "etiquetapais"
        Me.etiquetapais.Size = New System.Drawing.Size(140, 21)
        Me.etiquetapais.TabIndex = 527
        Me.etiquetapais.Text = "Pais"
        Me.etiquetapais.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtdni
        '
        Me.txtdni.BackColor = System.Drawing.Color.White
        Me.txtdni.Location = New System.Drawing.Point(635, 264)
        Me.txtdni.MaxLength = 50
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(336, 20)
        Me.txtdni.TabIndex = 31
        '
        'etiquetadni
        '
        Me.etiquetadni.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetadni.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetadni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetadni.ForeColor = System.Drawing.Color.Black
        Me.etiquetadni.Location = New System.Drawing.Point(489, 264)
        Me.etiquetadni.Name = "etiquetadni"
        Me.etiquetadni.Size = New System.Drawing.Size(140, 21)
        Me.etiquetadni.TabIndex = 528
        Me.etiquetadni.Text = "Dni"
        Me.etiquetadni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txttipo_dni
        '
        Me.txttipo_dni.BackColor = System.Drawing.Color.White
        Me.txttipo_dni.Location = New System.Drawing.Point(635, 307)
        Me.txttipo_dni.MaxLength = 50
        Me.txttipo_dni.Name = "txttipo_dni"
        Me.txttipo_dni.Size = New System.Drawing.Size(336, 20)
        Me.txttipo_dni.TabIndex = 32
        '
        'etiquetatipo_dni
        '
        Me.etiquetatipo_dni.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetatipo_dni.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetatipo_dni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetatipo_dni.ForeColor = System.Drawing.Color.Black
        Me.etiquetatipo_dni.Location = New System.Drawing.Point(489, 307)
        Me.etiquetatipo_dni.Name = "etiquetatipo_dni"
        Me.etiquetatipo_dni.Size = New System.Drawing.Size(140, 21)
        Me.etiquetatipo_dni.TabIndex = 529
        Me.etiquetatipo_dni.Text = "Tipo_dni"
        Me.etiquetatipo_dni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpegreso
        '
        Me.dtpegreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpegreso.Location = New System.Drawing.Point(635, 350)
        Me.dtpegreso.Name = "dtpegreso"
        Me.dtpegreso.Size = New System.Drawing.Size(93, 20)
        Me.dtpegreso.TabIndex = 33
        '
        'etiquetaegreso
        '
        Me.etiquetaegreso.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaegreso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaegreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaegreso.ForeColor = System.Drawing.Color.Black
        Me.etiquetaegreso.Location = New System.Drawing.Point(489, 350)
        Me.etiquetaegreso.Name = "etiquetaegreso"
        Me.etiquetaegreso.Size = New System.Drawing.Size(140, 21)
        Me.etiquetaegreso.TabIndex = 530
        Me.etiquetaegreso.Text = "Egreso"
        Me.etiquetaegreso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtmodalidad_trabajo
        '
        Me.txtmodalidad_trabajo.BackColor = System.Drawing.Color.White
        Me.txtmodalidad_trabajo.Location = New System.Drawing.Point(635, 392)
        Me.txtmodalidad_trabajo.MaxLength = 50
        Me.txtmodalidad_trabajo.Name = "txtmodalidad_trabajo"
        Me.txtmodalidad_trabajo.Size = New System.Drawing.Size(336, 20)
        Me.txtmodalidad_trabajo.TabIndex = 34
        '
        'etiquetamodalidad_trabajo
        '
        Me.etiquetamodalidad_trabajo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetamodalidad_trabajo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetamodalidad_trabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetamodalidad_trabajo.ForeColor = System.Drawing.Color.Black
        Me.etiquetamodalidad_trabajo.Location = New System.Drawing.Point(489, 392)
        Me.etiquetamodalidad_trabajo.Name = "etiquetamodalidad_trabajo"
        Me.etiquetamodalidad_trabajo.Size = New System.Drawing.Size(140, 21)
        Me.etiquetamodalidad_trabajo.TabIndex = 531
        Me.etiquetamodalidad_trabajo.Text = "Modalidad_trabajo"
        Me.etiquetamodalidad_trabajo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_obra_social
        '
        Me.lblid_obra_social.AutoSize = True
        Me.lblid_obra_social.BackColor = System.Drawing.Color.Red
        Me.lblid_obra_social.Location = New System.Drawing.Point(854, 439)
        Me.lblid_obra_social.Name = "lblid_obra_social"
        Me.lblid_obra_social.Size = New System.Drawing.Size(13, 13)
        Me.lblid_obra_social.TabIndex = 532
        Me.lblid_obra_social.Text = "0"
        Me.lblid_obra_social.Visible = False
        '
        'btnBuscaobra_social
        '
        Me.btnBuscaobra_social.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscaobra_social.Image = CType(resources.GetObject("btnBuscaobra_social.Image"), System.Drawing.Image)
        Me.btnBuscaobra_social.Location = New System.Drawing.Point(941, 433)
        Me.btnBuscaobra_social.Name = "btnBuscaobra_social"
        Me.btnBuscaobra_social.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscaobra_social.TabIndex = 31
        Me.btnBuscaobra_social.UseVisualStyleBackColor = True
        '
        'cmbobra_social
        '
        Me.cmbobra_social.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbobra_social.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbobra_social.FormattingEnabled = True
        Me.cmbobra_social.Location = New System.Drawing.Point(635, 434)
        Me.cmbobra_social.Name = "cmbobra_social"
        Me.cmbobra_social.Size = New System.Drawing.Size(291, 21)
        Me.cmbobra_social.TabIndex = 35
        '
        'etiquetaid_obra_social
        '
        Me.etiquetaid_obra_social.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_obra_social.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_obra_social.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_obra_social.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_obra_social.Location = New System.Drawing.Point(489, 434)
        Me.etiquetaid_obra_social.Name = "etiquetaid_obra_social"
        Me.etiquetaid_obra_social.Size = New System.Drawing.Size(140, 21)
        Me.etiquetaid_obra_social.TabIndex = 533
        Me.etiquetaid_obra_social.Text = "Obra_social"
        Me.etiquetaid_obra_social.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txttarea
        '
        Me.txttarea.BackColor = System.Drawing.Color.White
        Me.txttarea.Location = New System.Drawing.Point(635, 477)
        Me.txttarea.MaxLength = 50
        Me.txttarea.Name = "txttarea"
        Me.txttarea.Size = New System.Drawing.Size(336, 20)
        Me.txttarea.TabIndex = 36
        '
        'etiquetatarea
        '
        Me.etiquetatarea.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetatarea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetatarea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetatarea.ForeColor = System.Drawing.Color.Black
        Me.etiquetatarea.Location = New System.Drawing.Point(489, 477)
        Me.etiquetatarea.Name = "etiquetatarea"
        Me.etiquetatarea.Size = New System.Drawing.Size(140, 21)
        Me.etiquetatarea.TabIndex = 534
        Me.etiquetatarea.Text = "Tarea"
        Me.etiquetatarea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtvalor_hora
        '
        Me.txtvalor_hora.BackColor = System.Drawing.Color.White
        Me.txtvalor_hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvalor_hora.ForeColor = System.Drawing.Color.Blue
        Me.txtvalor_hora.Location = New System.Drawing.Point(635, 520)
        Me.txtvalor_hora.MaxLength = 50
        Me.txtvalor_hora.Name = "txtvalor_hora"
        Me.txtvalor_hora.Size = New System.Drawing.Size(222, 31)
        Me.txtvalor_hora.TabIndex = 37
        Me.txtvalor_hora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetavalor_hora
        '
        Me.etiquetavalor_hora.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetavalor_hora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetavalor_hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetavalor_hora.ForeColor = System.Drawing.Color.Black
        Me.etiquetavalor_hora.Location = New System.Drawing.Point(489, 520)
        Me.etiquetavalor_hora.Name = "etiquetavalor_hora"
        Me.etiquetavalor_hora.Size = New System.Drawing.Size(140, 21)
        Me.etiquetavalor_hora.TabIndex = 535
        Me.etiquetavalor_hora.Text = "Valor_hora"
        Me.etiquetavalor_hora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkcoordinador
        '
        Me.chkcoordinador.AutoSize = True
        Me.chkcoordinador.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkcoordinador.Location = New System.Drawing.Point(635, 575)
        Me.chkcoordinador.Name = "chkcoordinador"
        Me.chkcoordinador.Size = New System.Drawing.Size(114, 21)
        Me.chkcoordinador.TabIndex = 38
        Me.chkcoordinador.Text = "coordinador"
        '
        'etiquetacoordinador
        '
        Me.etiquetacoordinador.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetacoordinador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetacoordinador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetacoordinador.ForeColor = System.Drawing.Color.Black
        Me.etiquetacoordinador.Location = New System.Drawing.Point(489, 575)
        Me.etiquetacoordinador.Name = "etiquetacoordinador"
        Me.etiquetacoordinador.Size = New System.Drawing.Size(140, 21)
        Me.etiquetacoordinador.TabIndex = 536
        Me.etiquetacoordinador.Text = "Coordinador"
        Me.etiquetacoordinador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txthijo
        '
        Me.txthijo.BackColor = System.Drawing.Color.White
        Me.txthijo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthijo.ForeColor = System.Drawing.Color.Blue
        Me.txthijo.Location = New System.Drawing.Point(635, 619)
        Me.txthijo.MaxLength = 50
        Me.txthijo.Name = "txthijo"
        Me.txthijo.Size = New System.Drawing.Size(222, 31)
        Me.txthijo.TabIndex = 39
        Me.txthijo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetahijo
        '
        Me.etiquetahijo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetahijo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetahijo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetahijo.ForeColor = System.Drawing.Color.Black
        Me.etiquetahijo.Location = New System.Drawing.Point(489, 619)
        Me.etiquetahijo.Name = "etiquetahijo"
        Me.etiquetahijo.Size = New System.Drawing.Size(140, 21)
        Me.etiquetahijo.TabIndex = 537
        Me.etiquetahijo.Text = "Hijo"
        Me.etiquetahijo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtvalor_hijo
        '
        Me.txtvalor_hijo.BackColor = System.Drawing.Color.White
        Me.txtvalor_hijo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvalor_hijo.ForeColor = System.Drawing.Color.Blue
        Me.txtvalor_hijo.Location = New System.Drawing.Point(635, 677)
        Me.txtvalor_hijo.MaxLength = 50
        Me.txtvalor_hijo.Name = "txtvalor_hijo"
        Me.txtvalor_hijo.Size = New System.Drawing.Size(222, 31)
        Me.txtvalor_hijo.TabIndex = 40
        Me.txtvalor_hijo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetavalor_hijo
        '
        Me.etiquetavalor_hijo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetavalor_hijo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetavalor_hijo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetavalor_hijo.ForeColor = System.Drawing.Color.Black
        Me.etiquetavalor_hijo.Location = New System.Drawing.Point(489, 677)
        Me.etiquetavalor_hijo.Name = "etiquetavalor_hijo"
        Me.etiquetavalor_hijo.Size = New System.Drawing.Size(140, 21)
        Me.etiquetavalor_hijo.TabIndex = 538
        Me.etiquetavalor_hijo.Text = "Valor_hijo"
        Me.etiquetavalor_hijo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtsalario_mvm
        '
        Me.txtsalario_mvm.BackColor = System.Drawing.Color.White
        Me.txtsalario_mvm.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsalario_mvm.ForeColor = System.Drawing.Color.Blue
        Me.txtsalario_mvm.Location = New System.Drawing.Point(635, 734)
        Me.txtsalario_mvm.MaxLength = 50
        Me.txtsalario_mvm.Name = "txtsalario_mvm"
        Me.txtsalario_mvm.Size = New System.Drawing.Size(222, 31)
        Me.txtsalario_mvm.TabIndex = 41
        Me.txtsalario_mvm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetasalario_mvm
        '
        Me.etiquetasalario_mvm.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetasalario_mvm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetasalario_mvm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetasalario_mvm.ForeColor = System.Drawing.Color.Black
        Me.etiquetasalario_mvm.Location = New System.Drawing.Point(489, 734)
        Me.etiquetasalario_mvm.Name = "etiquetasalario_mvm"
        Me.etiquetasalario_mvm.Size = New System.Drawing.Size(140, 21)
        Me.etiquetasalario_mvm.TabIndex = 539
        Me.etiquetasalario_mvm.Text = "Salario_mvm"
        Me.etiquetasalario_mvm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtadicional_obra_social
        '
        Me.txtadicional_obra_social.BackColor = System.Drawing.Color.White
        Me.txtadicional_obra_social.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtadicional_obra_social.ForeColor = System.Drawing.Color.Blue
        Me.txtadicional_obra_social.Location = New System.Drawing.Point(635, 791)
        Me.txtadicional_obra_social.MaxLength = 50
        Me.txtadicional_obra_social.Name = "txtadicional_obra_social"
        Me.txtadicional_obra_social.Size = New System.Drawing.Size(222, 31)
        Me.txtadicional_obra_social.TabIndex = 42
        Me.txtadicional_obra_social.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetaadicional_obra_social
        '
        Me.etiquetaadicional_obra_social.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaadicional_obra_social.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaadicional_obra_social.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaadicional_obra_social.ForeColor = System.Drawing.Color.Black
        Me.etiquetaadicional_obra_social.Location = New System.Drawing.Point(489, 791)
        Me.etiquetaadicional_obra_social.Name = "etiquetaadicional_obra_social"
        Me.etiquetaadicional_obra_social.Size = New System.Drawing.Size(140, 21)
        Me.etiquetaadicional_obra_social.TabIndex = 540
        Me.etiquetaadicional_obra_social.Text = "Adicional_obra_social"
        Me.etiquetaadicional_obra_social.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txthijo_discapacitado
        '
        Me.txthijo_discapacitado.BackColor = System.Drawing.Color.White
        Me.txthijo_discapacitado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthijo_discapacitado.ForeColor = System.Drawing.Color.Blue
        Me.txthijo_discapacitado.Location = New System.Drawing.Point(635, 849)
        Me.txthijo_discapacitado.MaxLength = 50
        Me.txthijo_discapacitado.Name = "txthijo_discapacitado"
        Me.txthijo_discapacitado.Size = New System.Drawing.Size(222, 31)
        Me.txthijo_discapacitado.TabIndex = 43
        Me.txthijo_discapacitado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetahijo_discapacitado
        '
        Me.etiquetahijo_discapacitado.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetahijo_discapacitado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetahijo_discapacitado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetahijo_discapacitado.ForeColor = System.Drawing.Color.Black
        Me.etiquetahijo_discapacitado.Location = New System.Drawing.Point(489, 849)
        Me.etiquetahijo_discapacitado.Name = "etiquetahijo_discapacitado"
        Me.etiquetahijo_discapacitado.Size = New System.Drawing.Size(140, 21)
        Me.etiquetahijo_discapacitado.TabIndex = 541
        Me.etiquetahijo_discapacitado.Text = "Hijo_discapacitado"
        Me.etiquetahijo_discapacitado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmDetalleEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1024, 746)
        Me.Controls.Add(Me.txtlegajo)
        Me.Controls.Add(Me.etiquetalegajo)
        Me.Controls.Add(Me.txtapellido)
        Me.Controls.Add(Me.etiquetaapellido)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.etiquetanombre)
        Me.Controls.Add(Me.txtcuil)
        Me.Controls.Add(Me.etiquetacuil)
        Me.Controls.Add(Me.dtpnacimiento)
        Me.Controls.Add(Me.etiquetanacimiento)
        Me.Controls.Add(Me.txtdomicilio)
        Me.Controls.Add(Me.etiquetadomicilio)
        Me.Controls.Add(Me.txtlocalidad)
        Me.Controls.Add(Me.etiquetalocalidad)
        Me.Controls.Add(Me.txtcp)
        Me.Controls.Add(Me.etiquetacp)
        Me.Controls.Add(Me.txtprovincia)
        Me.Controls.Add(Me.etiquetaprovincia)
        Me.Controls.Add(Me.txtnacionalidad)
        Me.Controls.Add(Me.etiquetanacionalidad)
        Me.Controls.Add(Me.txtestado_civil)
        Me.Controls.Add(Me.etiquetaestado_civil)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.etiquetatelefono)
        Me.Controls.Add(Me.dtpcasamiento)
        Me.Controls.Add(Me.etiquetacasamiento)
        Me.Controls.Add(Me.txtlugar_nacimiento)
        Me.Controls.Add(Me.etiquetalugar_nacimiento)
        Me.Controls.Add(Me.txtapellido_conyugue)
        Me.Controls.Add(Me.etiquetaapellido_conyugue)
        Me.Controls.Add(Me.txtnombre_conyugue)
        Me.Controls.Add(Me.etiquetanombre_conyugue)
        Me.Controls.Add(Me.txtapellido_casado)
        Me.Controls.Add(Me.etiquetaapellido_casado)
        Me.Controls.Add(Me.txtdni_conyugue)
        Me.Controls.Add(Me.etiquetadni_conyugue)
        Me.Controls.Add(Me.txtapellido_beneficiario)
        Me.Controls.Add(Me.etiquetaapellido_beneficiario)
        Me.Controls.Add(Me.txtnombre_beneficiario)
        Me.Controls.Add(Me.etiquetanombre_beneficiario)
        Me.Controls.Add(Me.txtdni_beneficiario)
        Me.Controls.Add(Me.etiquetadni_beneficiario)
        Me.Controls.Add(Me.dtpingreso)
        Me.Controls.Add(Me.etiquetaingreso)
        Me.Controls.Add(Me.dtpreviza)
        Me.Controls.Add(Me.etiquetareviza)
        Me.Controls.Add(Me.chkdesabilitado)
        Me.Controls.Add(Me.etiquetadesabilitado)
        Me.Controls.Add(Me.lblid_tipo_empleado)
        Me.Controls.Add(Me.btnBuscatipo_empleado)
        Me.Controls.Add(Me.cmbtipo_empleado)
        Me.Controls.Add(Me.etiquetaid_tipo_empleado)
        Me.Controls.Add(Me.txtsexo)
        Me.Controls.Add(Me.etiquetasexo)
        Me.Controls.Add(Me.txtpais)
        Me.Controls.Add(Me.etiquetapais)
        Me.Controls.Add(Me.txtdni)
        Me.Controls.Add(Me.etiquetadni)
        Me.Controls.Add(Me.txttipo_dni)
        Me.Controls.Add(Me.etiquetatipo_dni)
        Me.Controls.Add(Me.dtpegreso)
        Me.Controls.Add(Me.etiquetaegreso)
        Me.Controls.Add(Me.txtmodalidad_trabajo)
        Me.Controls.Add(Me.etiquetamodalidad_trabajo)
        Me.Controls.Add(Me.lblid_obra_social)
        Me.Controls.Add(Me.btnBuscaobra_social)
        Me.Controls.Add(Me.cmbobra_social)
        Me.Controls.Add(Me.etiquetaid_obra_social)
        Me.Controls.Add(Me.txttarea)
        Me.Controls.Add(Me.etiquetatarea)
        Me.Controls.Add(Me.txtvalor_hora)
        Me.Controls.Add(Me.etiquetavalor_hora)
        Me.Controls.Add(Me.chkcoordinador)
        Me.Controls.Add(Me.etiquetacoordinador)
        Me.Controls.Add(Me.txthijo)
        Me.Controls.Add(Me.etiquetahijo)
        Me.Controls.Add(Me.txtvalor_hijo)
        Me.Controls.Add(Me.etiquetavalor_hijo)
        Me.Controls.Add(Me.txtsalario_mvm)
        Me.Controls.Add(Me.etiquetasalario_mvm)
        Me.Controls.Add(Me.txtadicional_obra_social)
        Me.Controls.Add(Me.etiquetaadicional_obra_social)
        Me.Controls.Add(Me.txthijo_discapacitado)
        Me.Controls.Add(Me.etiquetahijo_discapacitado)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDetalleEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetalleEmpleado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Protected WithEvents txtlegajo As System.Windows.Forms.TextBox
   Friend WithEvents etiquetalegajo As System.Windows.Forms.Label
   Protected WithEvents txtapellido As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaapellido As System.Windows.Forms.Label
   Protected WithEvents txtnombre As System.Windows.Forms.TextBox
   Friend WithEvents etiquetanombre As System.Windows.Forms.Label
   Protected WithEvents txtcuil As System.Windows.Forms.TextBox
   Friend WithEvents etiquetacuil As System.Windows.Forms.Label
   Protected WithEvents dtpnacimiento As System.Windows.Forms.DateTimePicker
   Friend WithEvents etiquetanacimiento As System.Windows.Forms.Label
   Protected WithEvents txtdomicilio As System.Windows.Forms.TextBox
   Friend WithEvents etiquetadomicilio As System.Windows.Forms.Label
   Protected WithEvents txtlocalidad As System.Windows.Forms.TextBox
   Friend WithEvents etiquetalocalidad As System.Windows.Forms.Label
   Protected WithEvents txtcp As System.Windows.Forms.TextBox
   Friend WithEvents etiquetacp As System.Windows.Forms.Label
   Protected WithEvents txtprovincia As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaprovincia As System.Windows.Forms.Label
   Protected WithEvents txtnacionalidad As System.Windows.Forms.TextBox
   Friend WithEvents etiquetanacionalidad As System.Windows.Forms.Label
   Protected WithEvents txtestado_civil As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaestado_civil As System.Windows.Forms.Label
   Protected WithEvents txttelefono As System.Windows.Forms.TextBox
   Friend WithEvents etiquetatelefono As System.Windows.Forms.Label
   Protected WithEvents dtpcasamiento As System.Windows.Forms.DateTimePicker
   Friend WithEvents etiquetacasamiento As System.Windows.Forms.Label
   Protected WithEvents txtlugar_nacimiento As System.Windows.Forms.TextBox
   Friend WithEvents etiquetalugar_nacimiento As System.Windows.Forms.Label
   Protected WithEvents txtapellido_conyugue As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaapellido_conyugue As System.Windows.Forms.Label
   Protected WithEvents txtnombre_conyugue As System.Windows.Forms.TextBox
   Friend WithEvents etiquetanombre_conyugue As System.Windows.Forms.Label
   Protected WithEvents txtapellido_casado As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaapellido_casado As System.Windows.Forms.Label
   Protected WithEvents txtdni_conyugue As System.Windows.Forms.TextBox
   Friend WithEvents etiquetadni_conyugue As System.Windows.Forms.Label
   Protected WithEvents txtapellido_beneficiario As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaapellido_beneficiario As System.Windows.Forms.Label
   Protected WithEvents txtnombre_beneficiario As System.Windows.Forms.TextBox
   Friend WithEvents etiquetanombre_beneficiario As System.Windows.Forms.Label
   Protected WithEvents txtdni_beneficiario As System.Windows.Forms.TextBox
   Friend WithEvents etiquetadni_beneficiario As System.Windows.Forms.Label
   Protected WithEvents dtpingreso As System.Windows.Forms.DateTimePicker
   Friend WithEvents etiquetaingreso As System.Windows.Forms.Label
   Protected WithEvents dtpreviza As System.Windows.Forms.DateTimePicker
   Friend WithEvents etiquetareviza As System.Windows.Forms.Label
   Protected WithEvents chkdesabilitado As System.Windows.Forms.CheckBox
   Friend WithEvents etiquetadesabilitado As System.Windows.Forms.Label
   Friend WithEvents lblid_tipo_empleado As System.Windows.Forms.Label
   Friend WithEvents btnBuscatipo_empleado As System.Windows.Forms.Button
   Friend WithEvents cmbtipo_empleado As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_tipo_empleado As System.Windows.Forms.Label
   Protected WithEvents txtsexo As System.Windows.Forms.TextBox
   Friend WithEvents etiquetasexo As System.Windows.Forms.Label
   Protected WithEvents txtpais As System.Windows.Forms.TextBox
   Friend WithEvents etiquetapais As System.Windows.Forms.Label
   Protected WithEvents txtdni As System.Windows.Forms.TextBox
   Friend WithEvents etiquetadni As System.Windows.Forms.Label
   Protected WithEvents txttipo_dni As System.Windows.Forms.TextBox
   Friend WithEvents etiquetatipo_dni As System.Windows.Forms.Label
   Protected WithEvents dtpegreso As System.Windows.Forms.DateTimePicker
   Friend WithEvents etiquetaegreso As System.Windows.Forms.Label
   Protected WithEvents txtmodalidad_trabajo As System.Windows.Forms.TextBox
   Friend WithEvents etiquetamodalidad_trabajo As System.Windows.Forms.Label
   Friend WithEvents lblid_obra_social As System.Windows.Forms.Label
   Friend WithEvents btnBuscaobra_social As System.Windows.Forms.Button
   Friend WithEvents cmbobra_social As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_obra_social As System.Windows.Forms.Label
   Protected WithEvents txttarea As System.Windows.Forms.TextBox
   Friend WithEvents etiquetatarea As System.Windows.Forms.Label
   Protected WithEvents txtvalor_hora As System.Windows.Forms.TextBox
   Friend WithEvents etiquetavalor_hora As System.Windows.Forms.Label
   Protected WithEvents chkcoordinador As System.Windows.Forms.CheckBox
   Friend WithEvents etiquetacoordinador As System.Windows.Forms.Label
   Protected WithEvents txthijo As System.Windows.Forms.TextBox
   Friend WithEvents etiquetahijo As System.Windows.Forms.Label
   Protected WithEvents txtvalor_hijo As System.Windows.Forms.TextBox
   Friend WithEvents etiquetavalor_hijo As System.Windows.Forms.Label
   Protected WithEvents txtsalario_mvm As System.Windows.Forms.TextBox
   Friend WithEvents etiquetasalario_mvm As System.Windows.Forms.Label
   Protected WithEvents txtadicional_obra_social As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaadicional_obra_social As System.Windows.Forms.Label
   Protected WithEvents txthijo_discapacitado As System.Windows.Forms.TextBox
   Friend WithEvents etiquetahijo_discapacitado As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
End Class

