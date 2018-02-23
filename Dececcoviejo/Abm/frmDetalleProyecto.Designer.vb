<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleProyecto
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleProyecto))
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBuscarPiloto = New System.Windows.Forms.Button()
        Me.cmbPiloto = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.etiquetafecha_fin_prevista = New System.Windows.Forms.Label()
        Me.txtpath = New System.Windows.Forms.TextBox()
        Me.chkarchivado = New System.Windows.Forms.CheckBox()
        Me.etiquetanombre_proyecto = New System.Windows.Forms.Label()
        Me.lblid_estado = New System.Windows.Forms.Label()
        Me.lblid_proyect_manager = New System.Windows.Forms.Label()
        Me.lblid_cliente = New System.Windows.Forms.Label()
        Me.btnBuscacliente = New System.Windows.Forms.Button()
        Me.etiquetaorden = New System.Windows.Forms.Label()
        Me.txtobservacion = New System.Windows.Forms.TextBox()
        Me.etiquetaobservacion = New System.Windows.Forms.Label()
        Me.etiquetaid_controlador_2 = New System.Windows.Forms.Label()
        Me.lblid_controlador_1 = New System.Windows.Forms.Label()
        Me.btnBuscaestado = New System.Windows.Forms.Button()
        Me.lblid_controlador_2 = New System.Windows.Forms.Label()
        Me.txtorden = New System.Windows.Forms.TextBox()
        Me.cmbcontrolador_2 = New System.Windows.Forms.ComboBox()
        Me.btnBuscacontrolador_2 = New System.Windows.Forms.Button()
        Me.txttotal_hora = New System.Windows.Forms.TextBox()
        Me.etiquetaid_controlador_1 = New System.Windows.Forms.Label()
        Me.cmbcontrolador_1 = New System.Windows.Forms.ComboBox()
        Me.btnBuscacontrolador_1 = New System.Windows.Forms.Button()
        Me.etiquetaid_estado = New System.Windows.Forms.Label()
        Me.etiquetatotal_hora = New System.Windows.Forms.Label()
        Me.cmbestado = New System.Windows.Forms.ComboBox()
        Me.txtprioridad = New System.Windows.Forms.TextBox()
        Me.etiquetafecha_fin_real = New System.Windows.Forms.Label()
        Me.etiquetaprioridad = New System.Windows.Forms.Label()
        Me.dtpfecha_fin_real = New System.Windows.Forms.DateTimePicker()
        Me.dtpfecha_fin_prevista = New System.Windows.Forms.DateTimePicker()
        Me.etiquetafecha_inicio = New System.Windows.Forms.Label()
        Me.dtpfecha_inicio = New System.Windows.Forms.DateTimePicker()
        Me.etiquetaid_proyect_manager = New System.Windows.Forms.Label()
        Me.cmbproyect_manager = New System.Windows.Forms.ComboBox()
        Me.btnBuscaproyect_manager = New System.Windows.Forms.Button()
        Me.txtnombre_proyecto = New System.Windows.Forms.TextBox()
        Me.etiquetaid_cliente = New System.Windows.Forms.Label()
        Me.cmbcliente = New System.Windows.Forms.ComboBox()
        Me.etiquetapath = New System.Windows.Forms.Label()
        Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.etiquetadescripcion = New System.Windows.Forms.Label()
        Me.lblid_proyecto_padre = New System.Windows.Forms.Label()
        Me.btnBuscaproyecto_padre = New System.Windows.Forms.Button()
        Me.cmbproyecto_padre = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_proyecto_padre = New System.Windows.Forms.Label()
        Me.lblid_proyecto = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
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
        Me.btnSalir.Location = New System.Drawing.Point(928, 515)
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
        Me.btnGuardar.Location = New System.Drawing.Point(820, 515)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(78, 69)
        Me.btnGuardar.TabIndex = 20
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBuscarPiloto)
        Me.GroupBox1.Controls.Add(Me.cmbPiloto)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.etiquetafecha_fin_prevista)
        Me.GroupBox1.Controls.Add(Me.txtdescripcion)
        Me.GroupBox1.Controls.Add(Me.txtpath)
        Me.GroupBox1.Controls.Add(Me.etiquetadescripcion)
        Me.GroupBox1.Controls.Add(Me.chkarchivado)
        Me.GroupBox1.Controls.Add(Me.etiquetanombre_proyecto)
        Me.GroupBox1.Controls.Add(Me.lblid_estado)
        Me.GroupBox1.Controls.Add(Me.lblid_proyect_manager)
        Me.GroupBox1.Controls.Add(Me.lblid_cliente)
        Me.GroupBox1.Controls.Add(Me.btnBuscacliente)
        Me.GroupBox1.Controls.Add(Me.etiquetaorden)
        Me.GroupBox1.Controls.Add(Me.txtobservacion)
        Me.GroupBox1.Controls.Add(Me.etiquetaobservacion)
        Me.GroupBox1.Controls.Add(Me.etiquetaid_controlador_2)
        Me.GroupBox1.Controls.Add(Me.lblid_controlador_1)
        Me.GroupBox1.Controls.Add(Me.btnBuscaestado)
        Me.GroupBox1.Controls.Add(Me.lblid_controlador_2)
        Me.GroupBox1.Controls.Add(Me.txtorden)
        Me.GroupBox1.Controls.Add(Me.cmbcontrolador_2)
        Me.GroupBox1.Controls.Add(Me.btnBuscacontrolador_2)
        Me.GroupBox1.Controls.Add(Me.txttotal_hora)
        Me.GroupBox1.Controls.Add(Me.etiquetaid_controlador_1)
        Me.GroupBox1.Controls.Add(Me.cmbcontrolador_1)
        Me.GroupBox1.Controls.Add(Me.btnBuscacontrolador_1)
        Me.GroupBox1.Controls.Add(Me.etiquetaid_estado)
        Me.GroupBox1.Controls.Add(Me.etiquetatotal_hora)
        Me.GroupBox1.Controls.Add(Me.cmbestado)
        Me.GroupBox1.Controls.Add(Me.txtprioridad)
        Me.GroupBox1.Controls.Add(Me.etiquetafecha_fin_real)
        Me.GroupBox1.Controls.Add(Me.etiquetaprioridad)
        Me.GroupBox1.Controls.Add(Me.dtpfecha_fin_real)
        Me.GroupBox1.Controls.Add(Me.dtpfecha_fin_prevista)
        Me.GroupBox1.Controls.Add(Me.etiquetafecha_inicio)
        Me.GroupBox1.Controls.Add(Me.dtpfecha_inicio)
        Me.GroupBox1.Controls.Add(Me.etiquetaid_proyect_manager)
        Me.GroupBox1.Controls.Add(Me.cmbproyect_manager)
        Me.GroupBox1.Controls.Add(Me.btnBuscaproyect_manager)
        Me.GroupBox1.Controls.Add(Me.txtnombre_proyecto)
        Me.GroupBox1.Controls.Add(Me.etiquetaid_cliente)
        Me.GroupBox1.Controls.Add(Me.cmbcliente)
        Me.GroupBox1.Controls.Add(Me.etiquetapath)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1060, 470)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnBuscarPiloto
        '
        Me.btnBuscarPiloto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscarPiloto.Image = CType(resources.GetObject("btnBuscarPiloto.Image"), System.Drawing.Image)
        Me.btnBuscarPiloto.Location = New System.Drawing.Point(1024, 165)
        Me.btnBuscarPiloto.Name = "btnBuscarPiloto"
        Me.btnBuscarPiloto.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscarPiloto.TabIndex = 524
        Me.btnBuscarPiloto.UseVisualStyleBackColor = True
        '
        'cmbPiloto
        '
        Me.cmbPiloto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbPiloto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPiloto.FormattingEnabled = True
        Me.cmbPiloto.Location = New System.Drawing.Point(689, 166)
        Me.cmbPiloto.Name = "cmbPiloto"
        Me.cmbPiloto.Size = New System.Drawing.Size(329, 21)
        Me.cmbPiloto.TabIndex = 523
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(556, 164)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 21)
        Me.Label1.TabIndex = 525
        Me.Label1.Text = "Piloto de Proyecto:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'etiquetafecha_fin_prevista
        '
        Me.etiquetafecha_fin_prevista.BackColor = System.Drawing.Color.Transparent
        Me.etiquetafecha_fin_prevista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetafecha_fin_prevista.ForeColor = System.Drawing.Color.Black
        Me.etiquetafecha_fin_prevista.Location = New System.Drawing.Point(0, 168)
        Me.etiquetafecha_fin_prevista.Name = "etiquetafecha_fin_prevista"
        Me.etiquetafecha_fin_prevista.Size = New System.Drawing.Size(143, 21)
        Me.etiquetafecha_fin_prevista.TabIndex = 509
        Me.etiquetafecha_fin_prevista.Text = "Fecha Fin Prevista: "
        Me.etiquetafecha_fin_prevista.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtpath
        '
        Me.txtpath.BackColor = System.Drawing.Color.White
        Me.txtpath.Enabled = False
        Me.txtpath.Location = New System.Drawing.Point(675, 251)
        Me.txtpath.MaxLength = 50
        Me.txtpath.Name = "txtpath"
        Me.txtpath.Size = New System.Drawing.Size(379, 20)
        Me.txtpath.TabIndex = 19
        '
        'chkarchivado
        '
        Me.chkarchivado.AutoSize = True
        Me.chkarchivado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkarchivado.Location = New System.Drawing.Point(689, 308)
        Me.chkarchivado.Name = "chkarchivado"
        Me.chkarchivado.Size = New System.Drawing.Size(74, 17)
        Me.chkarchivado.TabIndex = 20
        Me.chkarchivado.Text = "Archivado"
        '
        'etiquetanombre_proyecto
        '
        Me.etiquetanombre_proyecto.BackColor = System.Drawing.Color.Transparent
        Me.etiquetanombre_proyecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetanombre_proyecto.ForeColor = System.Drawing.Color.Black
        Me.etiquetanombre_proyecto.Location = New System.Drawing.Point(16, 47)
        Me.etiquetanombre_proyecto.Name = "etiquetanombre_proyecto"
        Me.etiquetanombre_proyecto.Size = New System.Drawing.Size(127, 21)
        Me.etiquetanombre_proyecto.TabIndex = 501
        Me.etiquetanombre_proyecto.Text = "Nombre: "
        Me.etiquetanombre_proyecto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblid_estado
        '
        Me.lblid_estado.AutoSize = True
        Me.lblid_estado.BackColor = System.Drawing.Color.Red
        Me.lblid_estado.Location = New System.Drawing.Point(447, 296)
        Me.lblid_estado.Name = "lblid_estado"
        Me.lblid_estado.Size = New System.Drawing.Size(13, 13)
        Me.lblid_estado.TabIndex = 512
        Me.lblid_estado.Text = "0"
        Me.lblid_estado.Visible = False
        '
        'lblid_proyect_manager
        '
        Me.lblid_proyect_manager.AutoSize = True
        Me.lblid_proyect_manager.BackColor = System.Drawing.Color.Red
        Me.lblid_proyect_manager.Location = New System.Drawing.Point(465, 105)
        Me.lblid_proyect_manager.Name = "lblid_proyect_manager"
        Me.lblid_proyect_manager.Size = New System.Drawing.Size(13, 13)
        Me.lblid_proyect_manager.TabIndex = 506
        Me.lblid_proyect_manager.Text = "0"
        Me.lblid_proyect_manager.Visible = False
        '
        'lblid_cliente
        '
        Me.lblid_cliente.AutoSize = True
        Me.lblid_cliente.BackColor = System.Drawing.Color.Red
        Me.lblid_cliente.Location = New System.Drawing.Point(465, 78)
        Me.lblid_cliente.Name = "lblid_cliente"
        Me.lblid_cliente.Size = New System.Drawing.Size(13, 13)
        Me.lblid_cliente.TabIndex = 502
        Me.lblid_cliente.Text = "0"
        Me.lblid_cliente.Visible = False
        '
        'btnBuscacliente
        '
        Me.btnBuscacliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscacliente.Image = CType(resources.GetObject("btnBuscacliente.Image"), System.Drawing.Image)
        Me.btnBuscacliente.Location = New System.Drawing.Point(504, 75)
        Me.btnBuscacliente.Name = "btnBuscacliente"
        Me.btnBuscacliente.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscacliente.TabIndex = 30
        Me.btnBuscacliente.UseVisualStyleBackColor = True
        '
        'etiquetaorden
        '
        Me.etiquetaorden.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaorden.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaorden.ForeColor = System.Drawing.Color.Black
        Me.etiquetaorden.Location = New System.Drawing.Point(16, 264)
        Me.etiquetaorden.Name = "etiquetaorden"
        Me.etiquetaorden.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaorden.TabIndex = 511
        Me.etiquetaorden.Text = "Órden"
        Me.etiquetaorden.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtobservacion
        '
        Me.txtobservacion.BackColor = System.Drawing.Color.White
        Me.txtobservacion.Location = New System.Drawing.Point(689, 40)
        Me.txtobservacion.MaxLength = 50
        Me.txtobservacion.Multiline = True
        Me.txtobservacion.Name = "txtobservacion"
        Me.txtobservacion.Size = New System.Drawing.Size(365, 65)
        Me.txtobservacion.TabIndex = 16
        '
        'etiquetaobservacion
        '
        Me.etiquetaobservacion.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaobservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaobservacion.ForeColor = System.Drawing.Color.Black
        Me.etiquetaobservacion.Location = New System.Drawing.Point(556, 38)
        Me.etiquetaobservacion.Name = "etiquetaobservacion"
        Me.etiquetaobservacion.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaobservacion.TabIndex = 516
        Me.etiquetaobservacion.Text = "Observaciones: "
        Me.etiquetaobservacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'etiquetaid_controlador_2
        '
        Me.etiquetaid_controlador_2.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaid_controlador_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_controlador_2.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_controlador_2.Location = New System.Drawing.Point(556, 136)
        Me.etiquetaid_controlador_2.Name = "etiquetaid_controlador_2"
        Me.etiquetaid_controlador_2.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_controlador_2.TabIndex = 520
        Me.etiquetaid_controlador_2.Text = "Controlador 2:"
        Me.etiquetaid_controlador_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblid_controlador_1
        '
        Me.lblid_controlador_1.AutoSize = True
        Me.lblid_controlador_1.BackColor = System.Drawing.Color.Red
        Me.lblid_controlador_1.Location = New System.Drawing.Point(913, 115)
        Me.lblid_controlador_1.Name = "lblid_controlador_1"
        Me.lblid_controlador_1.Size = New System.Drawing.Size(13, 13)
        Me.lblid_controlador_1.TabIndex = 517
        Me.lblid_controlador_1.Text = "0"
        Me.lblid_controlador_1.Visible = False
        '
        'btnBuscaestado
        '
        Me.btnBuscaestado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscaestado.Image = CType(resources.GetObject("btnBuscaestado.Image"), System.Drawing.Image)
        Me.btnBuscaestado.Location = New System.Drawing.Point(504, 292)
        Me.btnBuscaestado.Name = "btnBuscaestado"
        Me.btnBuscaestado.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscaestado.TabIndex = 33
        Me.btnBuscaestado.UseVisualStyleBackColor = True
        '
        'lblid_controlador_2
        '
        Me.lblid_controlador_2.AutoSize = True
        Me.lblid_controlador_2.BackColor = System.Drawing.Color.Red
        Me.lblid_controlador_2.Location = New System.Drawing.Point(913, 142)
        Me.lblid_controlador_2.Name = "lblid_controlador_2"
        Me.lblid_controlador_2.Size = New System.Drawing.Size(13, 13)
        Me.lblid_controlador_2.TabIndex = 519
        Me.lblid_controlador_2.Text = "0"
        Me.lblid_controlador_2.Visible = False
        '
        'txtorden
        '
        Me.txtorden.BackColor = System.Drawing.Color.White
        Me.txtorden.Location = New System.Drawing.Point(149, 266)
        Me.txtorden.MaxLength = 50
        Me.txtorden.Name = "txtorden"
        Me.txtorden.Size = New System.Drawing.Size(385, 20)
        Me.txtorden.TabIndex = 12
        '
        'cmbcontrolador_2
        '
        Me.cmbcontrolador_2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbcontrolador_2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbcontrolador_2.FormattingEnabled = True
        Me.cmbcontrolador_2.Location = New System.Drawing.Point(689, 138)
        Me.cmbcontrolador_2.Name = "cmbcontrolador_2"
        Me.cmbcontrolador_2.Size = New System.Drawing.Size(329, 21)
        Me.cmbcontrolador_2.TabIndex = 18
        '
        'btnBuscacontrolador_2
        '
        Me.btnBuscacontrolador_2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscacontrolador_2.Image = CType(resources.GetObject("btnBuscacontrolador_2.Image"), System.Drawing.Image)
        Me.btnBuscacontrolador_2.Location = New System.Drawing.Point(1024, 138)
        Me.btnBuscacontrolador_2.Name = "btnBuscacontrolador_2"
        Me.btnBuscacontrolador_2.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscacontrolador_2.TabIndex = 35
        Me.btnBuscacontrolador_2.UseVisualStyleBackColor = True
        '
        'txttotal_hora
        '
        Me.txttotal_hora.BackColor = System.Drawing.Color.White
        Me.txttotal_hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal_hora.ForeColor = System.Drawing.Color.Blue
        Me.txttotal_hora.Location = New System.Drawing.Point(149, 356)
        Me.txttotal_hora.MaxLength = 50
        Me.txttotal_hora.Name = "txttotal_hora"
        Me.txttotal_hora.Size = New System.Drawing.Size(222, 31)
        Me.txttotal_hora.TabIndex = 14
        Me.txttotal_hora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetaid_controlador_1
        '
        Me.etiquetaid_controlador_1.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaid_controlador_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_controlador_1.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_controlador_1.Location = New System.Drawing.Point(556, 110)
        Me.etiquetaid_controlador_1.Name = "etiquetaid_controlador_1"
        Me.etiquetaid_controlador_1.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_controlador_1.TabIndex = 518
        Me.etiquetaid_controlador_1.Text = "Controlador 1:"
        Me.etiquetaid_controlador_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbcontrolador_1
        '
        Me.cmbcontrolador_1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbcontrolador_1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbcontrolador_1.FormattingEnabled = True
        Me.cmbcontrolador_1.Location = New System.Drawing.Point(689, 112)
        Me.cmbcontrolador_1.Name = "cmbcontrolador_1"
        Me.cmbcontrolador_1.Size = New System.Drawing.Size(329, 21)
        Me.cmbcontrolador_1.TabIndex = 17
        '
        'btnBuscacontrolador_1
        '
        Me.btnBuscacontrolador_1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscacontrolador_1.Image = CType(resources.GetObject("btnBuscacontrolador_1.Image"), System.Drawing.Image)
        Me.btnBuscacontrolador_1.Location = New System.Drawing.Point(1024, 111)
        Me.btnBuscacontrolador_1.Name = "btnBuscacontrolador_1"
        Me.btnBuscacontrolador_1.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscacontrolador_1.TabIndex = 34
        Me.btnBuscacontrolador_1.UseVisualStyleBackColor = True
        '
        'etiquetaid_estado
        '
        Me.etiquetaid_estado.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaid_estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_estado.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_estado.Location = New System.Drawing.Point(16, 290)
        Me.etiquetaid_estado.Name = "etiquetaid_estado"
        Me.etiquetaid_estado.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_estado.TabIndex = 513
        Me.etiquetaid_estado.Text = "Estado"
        Me.etiquetaid_estado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'etiquetatotal_hora
        '
        Me.etiquetatotal_hora.BackColor = System.Drawing.Color.Transparent
        Me.etiquetatotal_hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetatotal_hora.ForeColor = System.Drawing.Color.Black
        Me.etiquetatotal_hora.Location = New System.Drawing.Point(16, 356)
        Me.etiquetatotal_hora.Name = "etiquetatotal_hora"
        Me.etiquetatotal_hora.Size = New System.Drawing.Size(127, 21)
        Me.etiquetatotal_hora.TabIndex = 514
        Me.etiquetatotal_hora.Text = "Total Horas"
        Me.etiquetatotal_hora.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbestado
        '
        Me.cmbestado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbestado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbestado.FormattingEnabled = True
        Me.cmbestado.Location = New System.Drawing.Point(149, 292)
        Me.cmbestado.Name = "cmbestado"
        Me.cmbestado.Size = New System.Drawing.Size(349, 21)
        Me.cmbestado.TabIndex = 13
        '
        'txtprioridad
        '
        Me.txtprioridad.BackColor = System.Drawing.Color.White
        Me.txtprioridad.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprioridad.ForeColor = System.Drawing.Color.Blue
        Me.txtprioridad.Location = New System.Drawing.Point(149, 409)
        Me.txtprioridad.MaxLength = 50
        Me.txtprioridad.Name = "txtprioridad"
        Me.txtprioridad.Size = New System.Drawing.Size(222, 31)
        Me.txtprioridad.TabIndex = 15
        Me.txtprioridad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetafecha_fin_real
        '
        Me.etiquetafecha_fin_real.BackColor = System.Drawing.Color.Transparent
        Me.etiquetafecha_fin_real.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetafecha_fin_real.ForeColor = System.Drawing.Color.Black
        Me.etiquetafecha_fin_real.Location = New System.Drawing.Point(16, 196)
        Me.etiquetafecha_fin_real.Name = "etiquetafecha_fin_real"
        Me.etiquetafecha_fin_real.Size = New System.Drawing.Size(127, 21)
        Me.etiquetafecha_fin_real.TabIndex = 510
        Me.etiquetafecha_fin_real.Text = "Fecha Fin Real:"
        Me.etiquetafecha_fin_real.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'etiquetaprioridad
        '
        Me.etiquetaprioridad.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaprioridad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaprioridad.ForeColor = System.Drawing.Color.Black
        Me.etiquetaprioridad.Location = New System.Drawing.Point(16, 409)
        Me.etiquetaprioridad.Name = "etiquetaprioridad"
        Me.etiquetaprioridad.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaprioridad.TabIndex = 515
        Me.etiquetaprioridad.Text = "Prioridad"
        Me.etiquetaprioridad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpfecha_fin_real
        '
        Me.dtpfecha_fin_real.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha_fin_real.Location = New System.Drawing.Point(149, 195)
        Me.dtpfecha_fin_real.Name = "dtpfecha_fin_real"
        Me.dtpfecha_fin_real.Size = New System.Drawing.Size(93, 20)
        Me.dtpfecha_fin_real.TabIndex = 11
        '
        'dtpfecha_fin_prevista
        '
        Me.dtpfecha_fin_prevista.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha_fin_prevista.Location = New System.Drawing.Point(149, 169)
        Me.dtpfecha_fin_prevista.Name = "dtpfecha_fin_prevista"
        Me.dtpfecha_fin_prevista.Size = New System.Drawing.Size(93, 20)
        Me.dtpfecha_fin_prevista.TabIndex = 10
        '
        'etiquetafecha_inicio
        '
        Me.etiquetafecha_inicio.BackColor = System.Drawing.Color.Transparent
        Me.etiquetafecha_inicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetafecha_inicio.ForeColor = System.Drawing.Color.Black
        Me.etiquetafecha_inicio.Location = New System.Drawing.Point(16, 142)
        Me.etiquetafecha_inicio.Name = "etiquetafecha_inicio"
        Me.etiquetafecha_inicio.Size = New System.Drawing.Size(127, 21)
        Me.etiquetafecha_inicio.TabIndex = 508
        Me.etiquetafecha_inicio.Text = "Fecha Inicio:"
        Me.etiquetafecha_inicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpfecha_inicio
        '
        Me.dtpfecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha_inicio.Location = New System.Drawing.Point(149, 143)
        Me.dtpfecha_inicio.Name = "dtpfecha_inicio"
        Me.dtpfecha_inicio.Size = New System.Drawing.Size(93, 20)
        Me.dtpfecha_inicio.TabIndex = 9
        '
        'etiquetaid_proyect_manager
        '
        Me.etiquetaid_proyect_manager.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaid_proyect_manager.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_proyect_manager.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_proyect_manager.Location = New System.Drawing.Point(16, 99)
        Me.etiquetaid_proyect_manager.Name = "etiquetaid_proyect_manager"
        Me.etiquetaid_proyect_manager.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_proyect_manager.TabIndex = 507
        Me.etiquetaid_proyect_manager.Text = "Proyect Manager"
        Me.etiquetaid_proyect_manager.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbproyect_manager
        '
        Me.cmbproyect_manager.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbproyect_manager.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbproyect_manager.FormattingEnabled = True
        Me.cmbproyect_manager.Location = New System.Drawing.Point(149, 101)
        Me.cmbproyect_manager.Name = "cmbproyect_manager"
        Me.cmbproyect_manager.Size = New System.Drawing.Size(349, 21)
        Me.cmbproyect_manager.TabIndex = 8
        '
        'btnBuscaproyect_manager
        '
        Me.btnBuscaproyect_manager.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscaproyect_manager.Image = CType(resources.GetObject("btnBuscaproyect_manager.Image"), System.Drawing.Image)
        Me.btnBuscaproyect_manager.Location = New System.Drawing.Point(504, 101)
        Me.btnBuscaproyect_manager.Name = "btnBuscaproyect_manager"
        Me.btnBuscaproyect_manager.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscaproyect_manager.TabIndex = 32
        Me.btnBuscaproyect_manager.UseVisualStyleBackColor = True
        Me.btnBuscaproyect_manager.Visible = False
        '
        'txtnombre_proyecto
        '
        Me.txtnombre_proyecto.BackColor = System.Drawing.Color.White
        Me.txtnombre_proyecto.Location = New System.Drawing.Point(149, 49)
        Me.txtnombre_proyecto.MaxLength = 50
        Me.txtnombre_proyecto.Name = "txtnombre_proyecto"
        Me.txtnombre_proyecto.Size = New System.Drawing.Size(385, 20)
        Me.txtnombre_proyecto.TabIndex = 5
        '
        'etiquetaid_cliente
        '
        Me.etiquetaid_cliente.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaid_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_cliente.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_cliente.Location = New System.Drawing.Point(16, 73)
        Me.etiquetaid_cliente.Name = "etiquetaid_cliente"
        Me.etiquetaid_cliente.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_cliente.TabIndex = 503
        Me.etiquetaid_cliente.Text = "Cliente:"
        Me.etiquetaid_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbcliente
        '
        Me.cmbcliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbcliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbcliente.FormattingEnabled = True
        Me.cmbcliente.Location = New System.Drawing.Point(149, 75)
        Me.cmbcliente.Name = "cmbcliente"
        Me.cmbcliente.Size = New System.Drawing.Size(349, 21)
        Me.cmbcliente.TabIndex = 6
        '
        'etiquetapath
        '
        Me.etiquetapath.BackColor = System.Drawing.Color.Transparent
        Me.etiquetapath.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetapath.ForeColor = System.Drawing.Color.Black
        Me.etiquetapath.Location = New System.Drawing.Point(542, 249)
        Me.etiquetapath.Name = "etiquetapath"
        Me.etiquetapath.Size = New System.Drawing.Size(127, 21)
        Me.etiquetapath.TabIndex = 521
        Me.etiquetapath.Text = "Path"
        Me.etiquetapath.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtdescripcion
        '
        Me.txtdescripcion.BackColor = System.Drawing.Color.White
        Me.txtdescripcion.Location = New System.Drawing.Point(149, 23)
        Me.txtdescripcion.MaxLength = 50
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(385, 20)
        Me.txtdescripcion.TabIndex = 4
        '
        'etiquetadescripcion
        '
        Me.etiquetadescripcion.BackColor = System.Drawing.Color.Transparent
        Me.etiquetadescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetadescripcion.ForeColor = System.Drawing.Color.Black
        Me.etiquetadescripcion.Location = New System.Drawing.Point(19, 23)
        Me.etiquetadescripcion.Name = "etiquetadescripcion"
        Me.etiquetadescripcion.Size = New System.Drawing.Size(124, 21)
        Me.etiquetadescripcion.TabIndex = 500
        Me.etiquetadescripcion.Text = "Descripción"
        Me.etiquetadescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblid_proyecto_padre
        '
        Me.lblid_proyecto_padre.AutoSize = True
        Me.lblid_proyecto_padre.BackColor = System.Drawing.Color.Red
        Me.lblid_proyecto_padre.Location = New System.Drawing.Point(331, 534)
        Me.lblid_proyecto_padre.Name = "lblid_proyecto_padre"
        Me.lblid_proyecto_padre.Size = New System.Drawing.Size(13, 13)
        Me.lblid_proyecto_padre.TabIndex = 504
        Me.lblid_proyecto_padre.Text = "0"
        Me.lblid_proyecto_padre.Visible = False
        '
        'btnBuscaproyecto_padre
        '
        Me.btnBuscaproyecto_padre.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscaproyecto_padre.Image = CType(resources.GetObject("btnBuscaproyecto_padre.Image"), System.Drawing.Image)
        Me.btnBuscaproyecto_padre.Location = New System.Drawing.Point(516, 531)
        Me.btnBuscaproyecto_padre.Name = "btnBuscaproyecto_padre"
        Me.btnBuscaproyecto_padre.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscaproyecto_padre.TabIndex = 31
        Me.btnBuscaproyecto_padre.UseVisualStyleBackColor = True
        Me.btnBuscaproyecto_padre.Visible = False
        '
        'cmbproyecto_padre
        '
        Me.cmbproyecto_padre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbproyecto_padre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbproyecto_padre.FormattingEnabled = True
        Me.cmbproyecto_padre.Location = New System.Drawing.Point(161, 531)
        Me.cmbproyecto_padre.Name = "cmbproyecto_padre"
        Me.cmbproyecto_padre.Size = New System.Drawing.Size(349, 21)
        Me.cmbproyecto_padre.TabIndex = 7
        Me.cmbproyecto_padre.Visible = False
        '
        'etiquetaid_proyecto_padre
        '
        Me.etiquetaid_proyecto_padre.BackColor = System.Drawing.Color.Transparent
        Me.etiquetaid_proyecto_padre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_proyecto_padre.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_proyecto_padre.Location = New System.Drawing.Point(28, 533)
        Me.etiquetaid_proyecto_padre.Name = "etiquetaid_proyecto_padre"
        Me.etiquetaid_proyecto_padre.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_proyecto_padre.TabIndex = 505
        Me.etiquetaid_proyecto_padre.Text = "Proyecto Padre"
        Me.etiquetaid_proyecto_padre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.etiquetaid_proyecto_padre.Visible = False
        '
        'lblid_proyecto
        '
        Me.lblid_proyecto.AutoSize = True
        Me.lblid_proyecto.BackColor = System.Drawing.Color.Red
        Me.lblid_proyecto.Location = New System.Drawing.Point(12, 9)
        Me.lblid_proyecto.Name = "lblid_proyecto"
        Me.lblid_proyecto.Size = New System.Drawing.Size(13, 13)
        Me.lblid_proyecto.TabIndex = 523
        Me.lblid_proyecto.Text = "0"
        Me.lblid_proyecto.Visible = False
        '
        'frmDetalleProyecto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1086, 593)
        Me.Controls.Add(Me.cmbproyecto_padre)
        Me.Controls.Add(Me.etiquetaid_proyecto_padre)
        Me.Controls.Add(Me.lblid_proyecto)
        Me.Controls.Add(Me.btnBuscaproyecto_padre)
        Me.Controls.Add(Me.lblid_proyecto_padre)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDetalleProyecto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proyecto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Protected WithEvents txtdescripcion As System.Windows.Forms.TextBox
   Friend WithEvents etiquetadescripcion As System.Windows.Forms.Label
   Protected WithEvents txtnombre_proyecto As System.Windows.Forms.TextBox
   Friend WithEvents etiquetanombre_proyecto As System.Windows.Forms.Label
   Friend WithEvents lblid_cliente As System.Windows.Forms.Label
   Friend WithEvents btnBuscacliente As System.Windows.Forms.Button
   Friend WithEvents cmbcliente As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_cliente As System.Windows.Forms.Label
   Friend WithEvents lblid_proyecto_padre As System.Windows.Forms.Label
   Friend WithEvents btnBuscaproyecto_padre As System.Windows.Forms.Button
   Friend WithEvents cmbproyecto_padre As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_proyecto_padre As System.Windows.Forms.Label
   Friend WithEvents lblid_proyect_manager As System.Windows.Forms.Label
   Friend WithEvents btnBuscaproyect_manager As System.Windows.Forms.Button
   Friend WithEvents cmbproyect_manager As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_proyect_manager As System.Windows.Forms.Label
   Protected WithEvents dtpfecha_inicio As System.Windows.Forms.DateTimePicker
   Friend WithEvents etiquetafecha_inicio As System.Windows.Forms.Label
   Protected WithEvents dtpfecha_fin_prevista As System.Windows.Forms.DateTimePicker
   Friend WithEvents etiquetafecha_fin_prevista As System.Windows.Forms.Label
   Protected WithEvents dtpfecha_fin_real As System.Windows.Forms.DateTimePicker
   Friend WithEvents etiquetafecha_fin_real As System.Windows.Forms.Label
   Protected WithEvents txtorden As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaorden As System.Windows.Forms.Label
   Friend WithEvents lblid_estado As System.Windows.Forms.Label
   Friend WithEvents btnBuscaestado As System.Windows.Forms.Button
   Friend WithEvents cmbestado As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_estado As System.Windows.Forms.Label
   Protected WithEvents txttotal_hora As System.Windows.Forms.TextBox
   Friend WithEvents etiquetatotal_hora As System.Windows.Forms.Label
   Protected WithEvents txtprioridad As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaprioridad As System.Windows.Forms.Label
   Protected WithEvents txtobservacion As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaobservacion As System.Windows.Forms.Label
   Friend WithEvents lblid_controlador_1 As System.Windows.Forms.Label
   Friend WithEvents btnBuscacontrolador_1 As System.Windows.Forms.Button
   Friend WithEvents cmbcontrolador_1 As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_controlador_1 As System.Windows.Forms.Label
   Friend WithEvents lblid_controlador_2 As System.Windows.Forms.Label
   Friend WithEvents btnBuscacontrolador_2 As System.Windows.Forms.Button
   Friend WithEvents cmbcontrolador_2 As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_controlador_2 As System.Windows.Forms.Label
   Protected WithEvents txtpath As System.Windows.Forms.TextBox
   Friend WithEvents etiquetapath As System.Windows.Forms.Label
   Protected WithEvents chkarchivado As System.Windows.Forms.CheckBox
    Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
    Friend WithEvents lblid_proyecto As System.Windows.Forms.Label
    Friend WithEvents btnBuscarPiloto As System.Windows.Forms.Button
    Friend WithEvents cmbPiloto As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class

