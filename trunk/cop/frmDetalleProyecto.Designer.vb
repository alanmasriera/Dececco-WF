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
       Me.components = New System.ComponentModel.Container
       Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleProyecto))
       Me.btnSalir = New System.Windows.Forms.Button
       Me.btnGuardar = New System.Windows.Forms.Button
       Me.GroupBox1 = New System.Windows.Forms.GroupBox
       Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
       Me.txtdescripcion = New System.Windows.Forms.TextBox
       Me.etiquetadescripcion = New System.Windows.Forms.Label
       Me.txtnombre_proyecto = New System.Windows.Forms.TextBox
       Me.etiquetanombre_proyecto = New System.Windows.Forms.Label
       Me.lblid_cliente = New System.Windows.Forms.Label
       Me.btnBuscacliente = New System.Windows.Forms.Button
       Me.cmbcliente = New System.Windows.Forms.ComboBox
       Me.etiquetaid_cliente = New System.Windows.Forms.Label
       Me.lblid_proyecto_padre = New System.Windows.Forms.Label
       Me.btnBuscaproyecto_padre = New System.Windows.Forms.Button
       Me.cmbproyecto_padre = New System.Windows.Forms.ComboBox
       Me.etiquetaid_proyecto_padre = New System.Windows.Forms.Label
       Me.lblid_proyect_manager = New System.Windows.Forms.Label
       Me.btnBuscaproyect_manager = New System.Windows.Forms.Button
       Me.cmbproyect_manager = New System.Windows.Forms.ComboBox
       Me.etiquetaid_proyect_manager = New System.Windows.Forms.Label
       Me.dtpfecha_inicio = New System.Windows.Forms.DateTimePicker
       Me.etiquetafecha_inicio = New System.Windows.Forms.Label
       Me.dtpfecha_fin_prevista = New System.Windows.Forms.DateTimePicker
       Me.etiquetafecha_fin_prevista = New System.Windows.Forms.Label
       Me.dtpfecha_fin_real = New System.Windows.Forms.DateTimePicker
       Me.etiquetafecha_fin_real = New System.Windows.Forms.Label
       Me.txtorden = New System.Windows.Forms.TextBox
       Me.etiquetaorden = New System.Windows.Forms.Label
       Me.lblid_estado = New System.Windows.Forms.Label
       Me.btnBuscaestado = New System.Windows.Forms.Button
       Me.cmbestado = New System.Windows.Forms.ComboBox
       Me.etiquetaid_estado = New System.Windows.Forms.Label
       Me.txttotal_hora = New System.Windows.Forms.TextBox
       Me.etiquetatotal_hora = New System.Windows.Forms.Label
       Me.txtprioridad = New System.Windows.Forms.TextBox
       Me.etiquetaprioridad = New System.Windows.Forms.Label
       Me.txtobservacion = New System.Windows.Forms.TextBox
       Me.etiquetaobservacion = New System.Windows.Forms.Label
       Me.lblid_controlador_1 = New System.Windows.Forms.Label
       Me.btnBuscacontrolador_1 = New System.Windows.Forms.Button
       Me.cmbcontrolador_1 = New System.Windows.Forms.ComboBox
       Me.etiquetaid_controlador_1 = New System.Windows.Forms.Label
       Me.lblid_controlador_2 = New System.Windows.Forms.Label
       Me.btnBuscacontrolador_2 = New System.Windows.Forms.Button
       Me.cmbcontrolador_2 = New System.Windows.Forms.ComboBox
       Me.etiquetaid_controlador_2 = New System.Windows.Forms.Label
       Me.txtpath = New System.Windows.Forms.TextBox
       Me.etiquetapath = New System.Windows.Forms.Label
       Me.chkarchivado = New System.Windows.Forms.CheckBox
       Me.etiquetaarchivado = New System.Windows.Forms.Label
       Me.lblindice = New System.Windows.Forms.Label
       Me.btnBuscaice = New System.Windows.Forms.Button
       Me.cmbice = New System.Windows.Forms.ComboBox
       Me.etiquetaindice = New System.Windows.Forms.Label
       Me.lblnro = New System.Windows.Forms.Label
       Me.btnBusca = New System.Windows.Forms.Button
       Me.cmb = New System.Windows.Forms.ComboBox
       Me.etiquetanro = New System.Windows.Forms.Label
       Me.SuspendLayout()
       '
       'txtdescripcion
       '
       Me.txtdescripcion.BackColor = System.Drawing.Color.White
       Me.txtdescripcion.Location = New System.Drawing.Point(161, 48)
       Me.txtdescripcion.Size = New System.Drawing.Size(385, 20)
       Me.txtdescripcion.MaxLength = 500
       Me.txtdescripcion.Name = "txtdescripcion"
       Me.txtdescripcion.TabIndex = 4
       '
       'etiquietadescripcion
       '
       Me.etiquetadescripcion.BackColor = System.Drawing.Color.Transparent
       Me.etiquetadescripcion.AutoSize = True
       Me.etiquetadescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetadescripcion.ForeColor = System.Drawing.Color.Black
       Me.etiquetadescripcion.Location = New System.Drawing.Point(28, 48)
       Me.etiquetadescripcion.Name = "etiquetadescripcion"
       Me.etiquetadescripcion.Size = New System.Drawing.Size(127, 21)
       Me.etiquetadescripcion.TabIndex = 500
       Me.etiquetadescripcion.Text = "Descripcion"
       Me.etiquetadescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtnombre_proyecto
       '
       Me.txtnombre_proyecto.BackColor = System.Drawing.Color.White
       Me.txtnombre_proyecto.Location = New System.Drawing.Point(161, 91)
       Me.txtnombre_proyecto.Size = New System.Drawing.Size(385, 20)
       Me.txtnombre_proyecto.MaxLength = 500
       Me.txtnombre_proyecto.Name = "txtnombre_proyecto"
       Me.txtnombre_proyecto.TabIndex = 5
       '
       'etiquietanombre_proyecto
       '
       Me.etiquetanombre_proyecto.BackColor = System.Drawing.Color.Transparent
       Me.etiquetanombre_proyecto.AutoSize = True
       Me.etiquetanombre_proyecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetanombre_proyecto.ForeColor = System.Drawing.Color.Black
       Me.etiquetanombre_proyecto.Location = New System.Drawing.Point(28, 91)
       Me.etiquetanombre_proyecto.Name = "etiquetanombre_proyecto"
       Me.etiquetanombre_proyecto.Size = New System.Drawing.Size(127, 21)
       Me.etiquetanombre_proyecto.TabIndex = 501
       Me.etiquetanombre_proyecto.Text = "Nombre proyecto"
       Me.etiquetanombre_proyecto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblid_cliente
       '
       Me.lblid_cliente.AutoSize = True
       Me.lblid_cliente.BackColor = System.Drawing.Color.Red
       Me.lblid_cliente.Location = New System.Drawing.Point(370, 134)
       Me.lblid_cliente.Name = "lblid_cliente"
       Me.lblid_cliente.Size = New System.Drawing.Size(13, 13)
       Me.lblid_cliente.TabIndex = 502
       Me.lblid_cliente.Text = "0"
       Me.lblid_cliente.Visible = False
       '
       'btnBuscacliente
       '
       Me.btnBuscacliente.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscacliente.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscacliente.Location = New System.Drawing.Point(505, 134)
       Me.btnBuscacliente.Name = "btnBuscacliente"
       Me.btnBuscacliente.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscacliente.TabIndex = 60
       Me.btnBuscacliente.UseVisualStyleBackColor = True
       '
       'cmbcliente
       '
       Me.cmbcliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbcliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbcliente.FormattingEnabled = True
       Me.cmbcliente.Location = New System.Drawing.Point(161, 134)
       Me.cmbcliente.Size = New System.Drawing.Size(329, 21)
       Me.cmbcliente.Name = "cmbcliente"
       Me.cmbcliente.TabIndex = 6
       '
       'etiquietaid_cliente
       '
       Me.etiquetaid_cliente.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_cliente.AutoSize = True
       Me.etiquetaid_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_cliente.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_cliente.Location = New System.Drawing.Point(28, 134)
       Me.etiquetaid_cliente.Name = "etiquetaid_cliente"
       Me.etiquetaid_cliente.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_cliente.TabIndex = 503
       Me.etiquetaid_cliente.Text = "Cliente"
       Me.etiquetaid_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblid_proyecto_padre
       '
       Me.lblid_proyecto_padre.AutoSize = True
       Me.lblid_proyecto_padre.BackColor = System.Drawing.Color.Red
       Me.lblid_proyecto_padre.Location = New System.Drawing.Point(370, 177)
       Me.lblid_proyecto_padre.Name = "lblid_proyecto_padre"
       Me.lblid_proyecto_padre.Size = New System.Drawing.Size(13, 13)
       Me.lblid_proyecto_padre.TabIndex = 504
       Me.lblid_proyecto_padre.Text = "0"
       Me.lblid_proyecto_padre.Visible = False
       '
       'btnBuscaproyecto_padre
       '
       Me.btnBuscaproyecto_padre.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscaproyecto_padre.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscaproyecto_padre.Location = New System.Drawing.Point(505, 177)
       Me.btnBuscaproyecto_padre.Name = "btnBuscaproyecto_padre"
       Me.btnBuscaproyecto_padre.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscaproyecto_padre.TabIndex = 61
       Me.btnBuscaproyecto_padre.UseVisualStyleBackColor = True
       '
       'cmbproyecto_padre
       '
       Me.cmbproyecto_padre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbproyecto_padre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbproyecto_padre.FormattingEnabled = True
       Me.cmbproyecto_padre.Location = New System.Drawing.Point(161, 177)
       Me.cmbproyecto_padre.Size = New System.Drawing.Size(329, 21)
       Me.cmbproyecto_padre.Name = "cmbproyecto_padre"
       Me.cmbproyecto_padre.TabIndex = 7
       '
       'etiquietaid_proyecto_padre
       '
       Me.etiquetaid_proyecto_padre.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_proyecto_padre.AutoSize = True
       Me.etiquetaid_proyecto_padre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_proyecto_padre.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_proyecto_padre.Location = New System.Drawing.Point(28, 177)
       Me.etiquetaid_proyecto_padre.Name = "etiquetaid_proyecto_padre"
       Me.etiquetaid_proyecto_padre.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_proyecto_padre.TabIndex = 505
       Me.etiquetaid_proyecto_padre.Text = "Proyecto padre"
       Me.etiquetaid_proyecto_padre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblid_proyect_manager
       '
       Me.lblid_proyect_manager.AutoSize = True
       Me.lblid_proyect_manager.BackColor = System.Drawing.Color.Red
       Me.lblid_proyect_manager.Location = New System.Drawing.Point(370, 220)
       Me.lblid_proyect_manager.Name = "lblid_proyect_manager"
       Me.lblid_proyect_manager.Size = New System.Drawing.Size(13, 13)
       Me.lblid_proyect_manager.TabIndex = 506
       Me.lblid_proyect_manager.Text = "0"
       Me.lblid_proyect_manager.Visible = False
       '
       'btnBuscaproyect_manager
       '
       Me.btnBuscaproyect_manager.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscaproyect_manager.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscaproyect_manager.Location = New System.Drawing.Point(505, 220)
       Me.btnBuscaproyect_manager.Name = "btnBuscaproyect_manager"
       Me.btnBuscaproyect_manager.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscaproyect_manager.TabIndex = 62
       Me.btnBuscaproyect_manager.UseVisualStyleBackColor = True
       '
       'cmbproyect_manager
       '
       Me.cmbproyect_manager.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbproyect_manager.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbproyect_manager.FormattingEnabled = True
       Me.cmbproyect_manager.Location = New System.Drawing.Point(161, 220)
       Me.cmbproyect_manager.Size = New System.Drawing.Size(329, 21)
       Me.cmbproyect_manager.Name = "cmbproyect_manager"
       Me.cmbproyect_manager.TabIndex = 8
       '
       'etiquietaid_proyect_manager
       '
       Me.etiquetaid_proyect_manager.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_proyect_manager.AutoSize = True
       Me.etiquetaid_proyect_manager.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_proyect_manager.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_proyect_manager.Location = New System.Drawing.Point(28, 220)
       Me.etiquetaid_proyect_manager.Name = "etiquetaid_proyect_manager"
       Me.etiquetaid_proyect_manager.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_proyect_manager.TabIndex = 507
       Me.etiquetaid_proyect_manager.Text = "Proyect manager"
       Me.etiquetaid_proyect_manager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'dtpfecha_inicio
       '
       Me.dtpfecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
       Me.dtpfecha_inicio.Location = New System.Drawing.Point(161, 263)
       Me.dtpfecha_inicio.Name = "cmbfecha_inicio"
       Me.dtpfecha_inicio.Size = New System.Drawing.Size(93, 20)
       Me.dtpfecha_inicio.TabIndex = 9
       '
       'etiquietafecha_inicio
       '
       Me.etiquetafecha_inicio.BackColor = System.Drawing.Color.Transparent
       Me.etiquetafecha_inicio.AutoSize = True
       Me.etiquetafecha_inicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetafecha_inicio.ForeColor = System.Drawing.Color.Black
       Me.etiquetafecha_inicio.Location = New System.Drawing.Point(28, 263)
       Me.etiquetafecha_inicio.Name = "etiquetafecha_inicio"
       Me.etiquetafecha_inicio.Size = New System.Drawing.Size(127, 21)
       Me.etiquetafecha_inicio.TabIndex = 508
       Me.etiquetafecha_inicio.Text = "Fecha inicio"
       Me.etiquetafecha_inicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'dtpfecha_fin_prevista
       '
       Me.dtpfecha_fin_prevista.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
       Me.dtpfecha_fin_prevista.Location = New System.Drawing.Point(161, 306)
       Me.dtpfecha_fin_prevista.Name = "cmbfecha_fin_prevista"
       Me.dtpfecha_fin_prevista.Size = New System.Drawing.Size(93, 20)
       Me.dtpfecha_fin_prevista.TabIndex = 10
       '
       'etiquietafecha_fin_prevista
       '
       Me.etiquetafecha_fin_prevista.BackColor = System.Drawing.Color.Transparent
       Me.etiquetafecha_fin_prevista.AutoSize = True
       Me.etiquetafecha_fin_prevista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetafecha_fin_prevista.ForeColor = System.Drawing.Color.Black
       Me.etiquetafecha_fin_prevista.Location = New System.Drawing.Point(28, 306)
       Me.etiquetafecha_fin_prevista.Name = "etiquetafecha_fin_prevista"
       Me.etiquetafecha_fin_prevista.Size = New System.Drawing.Size(127, 21)
       Me.etiquetafecha_fin_prevista.TabIndex = 509
       Me.etiquetafecha_fin_prevista.Text = "Fecha fin prevista"
       Me.etiquetafecha_fin_prevista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'dtpfecha_fin_real
       '
       Me.dtpfecha_fin_real.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
       Me.dtpfecha_fin_real.Location = New System.Drawing.Point(161, 349)
       Me.dtpfecha_fin_real.Name = "cmbfecha_fin_real"
       Me.dtpfecha_fin_real.Size = New System.Drawing.Size(93, 20)
       Me.dtpfecha_fin_real.TabIndex = 11
       '
       'etiquietafecha_fin_real
       '
       Me.etiquetafecha_fin_real.BackColor = System.Drawing.Color.Transparent
       Me.etiquetafecha_fin_real.AutoSize = True
       Me.etiquetafecha_fin_real.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetafecha_fin_real.ForeColor = System.Drawing.Color.Black
       Me.etiquetafecha_fin_real.Location = New System.Drawing.Point(28, 349)
       Me.etiquetafecha_fin_real.Name = "etiquetafecha_fin_real"
       Me.etiquetafecha_fin_real.Size = New System.Drawing.Size(127, 21)
       Me.etiquetafecha_fin_real.TabIndex = 510
       Me.etiquetafecha_fin_real.Text = "Fecha fin real"
       Me.etiquetafecha_fin_real.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtorden
       '
       Me.txtorden.BackColor = System.Drawing.Color.White
       Me.txtorden.Location = New System.Drawing.Point(161, 392)
       Me.txtorden.Size = New System.Drawing.Size(385, 20)
       Me.txtorden.MaxLength = 50
       Me.txtorden.Name = "txtorden"
       Me.txtorden.TabIndex = 12
       '
       'etiquietaorden
       '
       Me.etiquetaorden.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaorden.AutoSize = True
       Me.etiquetaorden.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaorden.ForeColor = System.Drawing.Color.Black
       Me.etiquetaorden.Location = New System.Drawing.Point(28, 392)
       Me.etiquetaorden.Name = "etiquetaorden"
       Me.etiquetaorden.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaorden.TabIndex = 511
       Me.etiquetaorden.Text = "Orden"
       Me.etiquetaorden.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblid_estado
       '
       Me.lblid_estado.AutoSize = True
       Me.lblid_estado.BackColor = System.Drawing.Color.Red
       Me.lblid_estado.Location = New System.Drawing.Point(370, 435)
       Me.lblid_estado.Name = "lblid_estado"
       Me.lblid_estado.Size = New System.Drawing.Size(13, 13)
       Me.lblid_estado.TabIndex = 512
       Me.lblid_estado.Text = "0"
       Me.lblid_estado.Visible = False
       '
       'btnBuscaestado
       '
       Me.btnBuscaestado.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscaestado.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscaestado.Location = New System.Drawing.Point(505, 435)
       Me.btnBuscaestado.Name = "btnBuscaestado"
       Me.btnBuscaestado.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscaestado.TabIndex = 63
       Me.btnBuscaestado.UseVisualStyleBackColor = True
       '
       'cmbestado
       '
       Me.cmbestado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbestado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbestado.FormattingEnabled = True
       Me.cmbestado.Location = New System.Drawing.Point(161, 435)
       Me.cmbestado.Size = New System.Drawing.Size(329, 21)
       Me.cmbestado.Name = "cmbestado"
       Me.cmbestado.TabIndex = 13
       '
       'etiquietaid_estado
       '
       Me.etiquetaid_estado.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_estado.AutoSize = True
       Me.etiquetaid_estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_estado.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_estado.Location = New System.Drawing.Point(28, 435)
       Me.etiquetaid_estado.Name = "etiquetaid_estado"
       Me.etiquetaid_estado.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_estado.TabIndex = 513
       Me.etiquetaid_estado.Text = "Estado"
       Me.etiquetaid_estado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txttotal_hora
       '
       Me.txttotal_hora.BackColor = System.Drawing.Color.White
       Me.txttotal_hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txttotal_hora.ForeColor = System.Drawing.Color.Blue
       Me.txttotal_hora.Location = New System.Drawing.Point(161, 478)
       Me.txttotal_hora.MaxLength = 50
       Me.txttotal_hora.Name = "txttotal_hora"
       Me.txttotal_hora.Size = New System.Drawing.Size(222, 31)
       Me.txttotal_hora.TabIndex = 14
       Me.txttotal_hora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietatotal_hora
       '
       Me.etiquetatotal_hora.BackColor = System.Drawing.Color.Transparent
       Me.etiquetatotal_hora.AutoSize = True
       Me.etiquetatotal_hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetatotal_hora.ForeColor = System.Drawing.Color.Black
       Me.etiquetatotal_hora.Location = New System.Drawing.Point(28, 478)
       Me.etiquetatotal_hora.Name = "etiquetatotal_hora"
       Me.etiquetatotal_hora.Size = New System.Drawing.Size(127, 21)
       Me.etiquetatotal_hora.TabIndex = 514
       Me.etiquetatotal_hora.Text = "Total hora"
       Me.etiquetatotal_hora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtprioridad
       '
       Me.txtprioridad.BackColor = System.Drawing.Color.White
       Me.txtprioridad.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtprioridad.ForeColor = System.Drawing.Color.Blue
       Me.txtprioridad.Location = New System.Drawing.Point(161, 531)
       Me.txtprioridad.MaxLength = 50
       Me.txtprioridad.Name = "txtprioridad"
       Me.txtprioridad.Size = New System.Drawing.Size(222, 31)
       Me.txtprioridad.TabIndex = 15
       Me.txtprioridad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietaprioridad
       '
       Me.etiquetaprioridad.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaprioridad.AutoSize = True
       Me.etiquetaprioridad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaprioridad.ForeColor = System.Drawing.Color.Black
       Me.etiquetaprioridad.Location = New System.Drawing.Point(28, 531)
       Me.etiquetaprioridad.Name = "etiquetaprioridad"
       Me.etiquetaprioridad.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaprioridad.TabIndex = 515
       Me.etiquetaprioridad.Text = "Prioridad"
       Me.etiquetaprioridad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtobservacion
       '
       Me.txtobservacion.BackColor = System.Drawing.Color.White
       Me.txtobservacion.Location = New System.Drawing.Point(656, 48)
       Me.txtobservacion.Size = New System.Drawing.Size(330, 20)
       Me.txtobservacion.MaxLength = 500
       Me.txtobservacion.Name = "txtobservacion"
       Me.txtobservacion.TabIndex = 16
       '
       'etiquietaobservacion
       '
       Me.etiquetaobservacion.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaobservacion.AutoSize = True
       Me.etiquetaobservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaobservacion.ForeColor = System.Drawing.Color.Black
       Me.etiquetaobservacion.Location = New System.Drawing.Point(583, 48)
       Me.etiquetaobservacion.Name = "etiquetaobservacion"
       Me.etiquetaobservacion.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaobservacion.TabIndex = 516
       Me.etiquetaobservacion.Text = "Observacion"
       Me.etiquetaobservacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblid_controlador_1
       '
       Me.lblid_controlador_1.AutoSize = True
       Me.lblid_controlador_1.BackColor = System.Drawing.Color.Red
       Me.lblid_controlador_1.Location = New System.Drawing.Point(800, 91)
       Me.lblid_controlador_1.Name = "lblid_controlador_1"
       Me.lblid_controlador_1.Size = New System.Drawing.Size(13, 13)
       Me.lblid_controlador_1.TabIndex = 517
       Me.lblid_controlador_1.Text = "0"
       Me.lblid_controlador_1.Visible = False
       '
       'btnBuscacontrolador_1
       '
       Me.btnBuscacontrolador_1.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscacontrolador_1.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscacontrolador_1.Location = New System.Drawing.Point(964, 91)
       Me.btnBuscacontrolador_1.Name = "btnBuscacontrolador_1"
       Me.btnBuscacontrolador_1.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscacontrolador_1.TabIndex = 64
       Me.btnBuscacontrolador_1.UseVisualStyleBackColor = True
       '
       'cmbcontrolador_1
       '
       Me.cmbcontrolador_1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbcontrolador_1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbcontrolador_1.FormattingEnabled = True
       Me.cmbcontrolador_1.Location = New System.Drawing.Point(656, 91)
       Me.cmbcontrolador_1.Size = New System.Drawing.Size(286, 21)
       Me.cmbcontrolador_1.Name = "cmbcontrolador_1"
       Me.cmbcontrolador_1.TabIndex = 17
       '
       'etiquietaid_controlador_1
       '
       Me.etiquetaid_controlador_1.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_controlador_1.AutoSize = True
       Me.etiquetaid_controlador_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_controlador_1.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_controlador_1.Location = New System.Drawing.Point(583, 91)
       Me.etiquetaid_controlador_1.Name = "etiquetaid_controlador_1"
       Me.etiquetaid_controlador_1.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_controlador_1.TabIndex = 518
       Me.etiquetaid_controlador_1.Text = "Controlador 1"
       Me.etiquetaid_controlador_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblid_controlador_2
       '
       Me.lblid_controlador_2.AutoSize = True
       Me.lblid_controlador_2.BackColor = System.Drawing.Color.Red
       Me.lblid_controlador_2.Location = New System.Drawing.Point(800, 134)
       Me.lblid_controlador_2.Name = "lblid_controlador_2"
       Me.lblid_controlador_2.Size = New System.Drawing.Size(13, 13)
       Me.lblid_controlador_2.TabIndex = 519
       Me.lblid_controlador_2.Text = "0"
       Me.lblid_controlador_2.Visible = False
       '
       'btnBuscacontrolador_2
       '
       Me.btnBuscacontrolador_2.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscacontrolador_2.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscacontrolador_2.Location = New System.Drawing.Point(964, 134)
       Me.btnBuscacontrolador_2.Name = "btnBuscacontrolador_2"
       Me.btnBuscacontrolador_2.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscacontrolador_2.TabIndex = 65
       Me.btnBuscacontrolador_2.UseVisualStyleBackColor = True
       '
       'cmbcontrolador_2
       '
       Me.cmbcontrolador_2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbcontrolador_2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbcontrolador_2.FormattingEnabled = True
       Me.cmbcontrolador_2.Location = New System.Drawing.Point(656, 134)
       Me.cmbcontrolador_2.Size = New System.Drawing.Size(286, 21)
       Me.cmbcontrolador_2.Name = "cmbcontrolador_2"
       Me.cmbcontrolador_2.TabIndex = 18
       '
       'etiquietaid_controlador_2
       '
       Me.etiquetaid_controlador_2.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_controlador_2.AutoSize = True
       Me.etiquetaid_controlador_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_controlador_2.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_controlador_2.Location = New System.Drawing.Point(583, 134)
       Me.etiquetaid_controlador_2.Name = "etiquetaid_controlador_2"
       Me.etiquetaid_controlador_2.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_controlador_2.TabIndex = 520
       Me.etiquetaid_controlador_2.Text = "Controlador 2"
       Me.etiquetaid_controlador_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtpath
       '
       Me.txtpath.BackColor = System.Drawing.Color.White
       Me.txtpath.Location = New System.Drawing.Point(656, 177)
       Me.txtpath.Size = New System.Drawing.Size(330, 20)
       Me.txtpath.MaxLength = 5000
       Me.txtpath.Name = "txtpath"
       Me.txtpath.TabIndex = 19
       '
       'etiquietapath
       '
       Me.etiquetapath.BackColor = System.Drawing.Color.Transparent
       Me.etiquetapath.AutoSize = True
       Me.etiquetapath.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetapath.ForeColor = System.Drawing.Color.Black
       Me.etiquetapath.Location = New System.Drawing.Point(583, 177)
       Me.etiquetapath.Name = "etiquetapath"
       Me.etiquetapath.Size = New System.Drawing.Size(127, 21)
       Me.etiquetapath.TabIndex = 521
       Me.etiquetapath.Text = "Path"
       Me.etiquetapath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'chkarchivado
       '
       Me.chkarchivado.AutoSize = True
       Me.chkarchivado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.chkarchivado.Location = New System.Drawing.Point(656, 220)
       Me.chkarchivado.Name = "etiquetaarchivado"
       Me.chkarchivado.Size = New System.Drawing.Size(15, 14)
       Me.chkarchivado.TabIndex = 20
       Me.chkarchivado.Text = "archivado"
       Me.chkarchivado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       'etiquietaarchivado
       '
       Me.etiquetaarchivado.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaarchivado.AutoSize = True
       Me.etiquetaarchivado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaarchivado.ForeColor = System.Drawing.Color.Black
       Me.etiquetaarchivado.Location = New System.Drawing.Point(583, 220)
       Me.etiquetaarchivado.Name = "etiquetaarchivado"
       Me.etiquetaarchivado.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaarchivado.TabIndex = 522
       Me.etiquetaarchivado.Text = "Archivado"
       Me.etiquetaarchivado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblindice
       '
       Me.lblindice.AutoSize = True
       Me.lblindice.BackColor = System.Drawing.Color.Red
       Me.lblindice.Location = New System.Drawing.Point(800, 263)
       Me.lblindice.Name = "lblindice"
       Me.lblindice.Size = New System.Drawing.Size(13, 13)
       Me.lblindice.TabIndex = 523
       Me.lblindice.Text = "0"
       Me.lblindice.Visible = False
       '
       'btnBuscaice
       '
       Me.btnBuscaice.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscaice.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscaice.Location = New System.Drawing.Point(964, 263)
       Me.btnBuscaice.Name = "btnBuscaice"
       Me.btnBuscaice.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscaice.TabIndex = 66
       Me.btnBuscaice.UseVisualStyleBackColor = True
       '
       'cmbice
       '
       Me.cmbice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbice.FormattingEnabled = True
       Me.cmbice.Location = New System.Drawing.Point(656, 263)
       Me.cmbice.Size = New System.Drawing.Size(286, 21)
       Me.cmbice.Name = "cmbice"
       Me.cmbice.TabIndex = 21
       '
       'etiquietaindice
       '
       Me.etiquetaindice.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaindice.AutoSize = True
       Me.etiquetaindice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaindice.ForeColor = System.Drawing.Color.Black
       Me.etiquetaindice.Location = New System.Drawing.Point(583, 263)
       Me.etiquetaindice.Name = "etiquetaindice"
       Me.etiquetaindice.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaindice.TabIndex = 524
       Me.etiquetaindice.Text = "Ice"
       Me.etiquetaindice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblnro
       '
       Me.lblnro.AutoSize = True
       Me.lblnro.BackColor = System.Drawing.Color.Red
       Me.lblnro.Location = New System.Drawing.Point(800, 306)
       Me.lblnro.Name = "lblnro"
       Me.lblnro.Size = New System.Drawing.Size(13, 13)
       Me.lblnro.TabIndex = 525
       Me.lblnro.Text = "0"
       Me.lblnro.Visible = False
       '
       'btnBusca
       '
       Me.btnBusca.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBusca.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBusca.Location = New System.Drawing.Point(964, 306)
       Me.btnBusca.Name = "btnBusca"
       Me.btnBusca.Size = New System.Drawing.Size(30, 21)
       Me.btnBusca.TabIndex = 67
       Me.btnBusca.UseVisualStyleBackColor = True
       '
       'cmb
       '
       Me.cmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmb.FormattingEnabled = True
       Me.cmb.Location = New System.Drawing.Point(656, 306)
       Me.cmb.Size = New System.Drawing.Size(286, 21)
       Me.cmb.Name = "cmb"
       Me.cmb.TabIndex = 22
       '
       'etiquietanro
       '
       Me.etiquetanro.BackColor = System.Drawing.Color.Transparent
       Me.etiquetanro.AutoSize = True
       Me.etiquetanro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetanro.ForeColor = System.Drawing.Color.Black
       Me.etiquetanro.Location = New System.Drawing.Point(583, 306)
       Me.etiquetanro.Name = "etiquetanro"
       Me.etiquetanro.Size = New System.Drawing.Size(127, 21)
       Me.etiquetanro.TabIndex = 526
       Me.etiquetanro.Text = ""
       Me.etiquetanro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
       Me.btnSalir.Location = New System.Drawing.Point(931, 647)
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
       Me.btnGuardar.Location = New System.Drawing.Point(831, 647)
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
       Me.GroupBox1.Size = New System.Drawing.Size(1000, 606)
       Me.GroupBox1.TabIndex = 0
       Me.GroupBox1.TabStop = False
       '
       'frmDetalleProyecto
       '
       Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
       Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
       Me.ClientSize = New System.Drawing.Size(1024, 768)
       Me.Controls.Add(Me.txtdescripcion)
       Me.Controls.Add(Me.etiquetadescripcion)
       Me.Controls.Add(Me.txtnombre_proyecto)
       Me.Controls.Add(Me.etiquetanombre_proyecto)
       Me.Controls.Add(Me.lblid_cliente)
       Me.Controls.Add(Me.btnBuscacliente)
       Me.Controls.Add(Me.cmbcliente)
       Me.Controls.Add(Me.etiquetaid_cliente)
       Me.Controls.Add(Me.lblid_proyecto_padre)
       Me.Controls.Add(Me.btnBuscaproyecto_padre)
       Me.Controls.Add(Me.cmbproyecto_padre)
       Me.Controls.Add(Me.etiquetaid_proyecto_padre)
       Me.Controls.Add(Me.lblid_proyect_manager)
       Me.Controls.Add(Me.btnBuscaproyect_manager)
       Me.Controls.Add(Me.cmbproyect_manager)
       Me.Controls.Add(Me.etiquetaid_proyect_manager)
       Me.Controls.Add(Me.dtpfecha_inicio)
       Me.Controls.Add(Me.etiquetafecha_inicio)
       Me.Controls.Add(Me.dtpfecha_fin_prevista)
       Me.Controls.Add(Me.etiquetafecha_fin_prevista)
       Me.Controls.Add(Me.dtpfecha_fin_real)
       Me.Controls.Add(Me.etiquetafecha_fin_real)
       Me.Controls.Add(Me.txtorden)
       Me.Controls.Add(Me.etiquetaorden)
       Me.Controls.Add(Me.lblid_estado)
       Me.Controls.Add(Me.btnBuscaestado)
       Me.Controls.Add(Me.cmbestado)
       Me.Controls.Add(Me.etiquetaid_estado)
       Me.Controls.Add(Me.txttotal_hora)
       Me.Controls.Add(Me.etiquetatotal_hora)
       Me.Controls.Add(Me.txtprioridad)
       Me.Controls.Add(Me.etiquetaprioridad)
       Me.Controls.Add(Me.txtobservacion)
       Me.Controls.Add(Me.etiquetaobservacion)
       Me.Controls.Add(Me.lblid_controlador_1)
       Me.Controls.Add(Me.btnBuscacontrolador_1)
       Me.Controls.Add(Me.cmbcontrolador_1)
       Me.Controls.Add(Me.etiquetaid_controlador_1)
       Me.Controls.Add(Me.lblid_controlador_2)
       Me.Controls.Add(Me.btnBuscacontrolador_2)
       Me.Controls.Add(Me.cmbcontrolador_2)
       Me.Controls.Add(Me.etiquetaid_controlador_2)
       Me.Controls.Add(Me.txtpath)
       Me.Controls.Add(Me.etiquetapath)
       Me.Controls.Add(Me.chkarchivado)
       Me.Controls.Add(Me.etiquetaarchivado)
       Me.Controls.Add(Me.lblindice)
       Me.Controls.Add(Me.btnBuscaice)
       Me.Controls.Add(Me.cmbice)
       Me.Controls.Add(Me.etiquetaindice)
       Me.Controls.Add(Me.lblnro)
       Me.Controls.Add(Me.btnBusca)
       Me.Controls.Add(Me.cmb)
       Me.Controls.Add(Me.etiquetanro)
       Me.Controls.Add(Me.btnSalir)
       Me.Controls.Add(Me.btnGuardar)
       Me.Controls.Add(Me.GroupBox1)
       Me.Name = "frmDetalleProyecto"
       Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
       Me.Text = "frmDetalleProyecto" & vgNombreFormulario
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
   Friend WithEvents etiquetaarchivado As System.Windows.Forms.Label
   Friend WithEvents lblindice As System.Windows.Forms.Label
   Friend WithEvents btnBuscaice As System.Windows.Forms.Button
   Friend WithEvents cmbice As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaindice As System.Windows.Forms.Label
   Friend WithEvents lblnro As System.Windows.Forms.Label
   Friend WithEvents btnBusca As System.Windows.Forms.Button
   Friend WithEvents cmb As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetanro As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
End Class

