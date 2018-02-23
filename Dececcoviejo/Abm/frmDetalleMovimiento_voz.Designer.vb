<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleMovimiento_voz
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
       Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleMovimiento_voz))
       Me.btnSalir = New System.Windows.Forms.Button
       Me.btnGuardar = New System.Windows.Forms.Button
       Me.GroupBox1 = New System.Windows.Forms.GroupBox
       Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
       Me.lblid_control = New System.Windows.Forms.Label
       Me.btnBuscacontrol = New System.Windows.Forms.Button
       Me.cmbcontrol = New System.Windows.Forms.ComboBox
       Me.etiquetaid_control = New System.Windows.Forms.Label
       Me.dtpfecha = New System.Windows.Forms.DateTimePicker
       Me.etiquetafecha = New System.Windows.Forms.Label
       Me.txtot = New System.Windows.Forms.TextBox
       Me.etiquetaot = New System.Windows.Forms.Label
       Me.lblid_actividad_proyecto = New System.Windows.Forms.Label
       Me.btnBuscaactividad_proyecto = New System.Windows.Forms.Button
       Me.cmbactividad_proyecto = New System.Windows.Forms.ComboBox
       Me.etiquetaid_actividad_proyecto = New System.Windows.Forms.Label
       Me.lblid_cadista = New System.Windows.Forms.Label
       Me.btnBuscacadista = New System.Windows.Forms.Button
       Me.cmbcadista = New System.Windows.Forms.ComboBox
       Me.etiquetaid_cadista = New System.Windows.Forms.Label
       Me.lblid_proyect_manager = New System.Windows.Forms.Label
       Me.btnBuscaproyect_manager = New System.Windows.Forms.Button
       Me.cmbproyect_manager = New System.Windows.Forms.ComboBox
       Me.etiquetaid_proyect_manager = New System.Windows.Forms.Label
       Me.lblid_controlador_1 = New System.Windows.Forms.Label
       Me.btnBuscacontrolador_1 = New System.Windows.Forms.Button
       Me.cmbcontrolador_1 = New System.Windows.Forms.ComboBox
       Me.etiquetaid_controlador_1 = New System.Windows.Forms.Label
       Me.lblid_controlador_2 = New System.Windows.Forms.Label
       Me.btnBuscacontrolador_2 = New System.Windows.Forms.Button
       Me.cmbcontrolador_2 = New System.Windows.Forms.ComboBox
       Me.etiquetaid_controlador_2 = New System.Windows.Forms.Label
       Me.chkcompletado = New System.Windows.Forms.CheckBox
       Me.etiquetacompletado = New System.Windows.Forms.Label
       Me.lblid_usuario_anterior = New System.Windows.Forms.Label
       Me.btnBuscausuario_anterior = New System.Windows.Forms.Button
       Me.cmbusuario_anterior = New System.Windows.Forms.ComboBox
       Me.etiquetaid_usuario_anterior = New System.Windows.Forms.Label
       Me.SuspendLayout()
       '
       'lblid_control
       '
       Me.lblid_control.AutoSize = True
       Me.lblid_control.BackColor = System.Drawing.Color.Red
       Me.lblid_control.Location = New System.Drawing.Point(370, 48)
       Me.lblid_control.Name = "lblid_control"
       Me.lblid_control.Size = New System.Drawing.Size(13, 13)
       Me.lblid_control.TabIndex = 500
       Me.lblid_control.Text = "0"
       Me.lblid_control.Visible = False
       '
       'btnBuscacontrol
       '
       Me.btnBuscacontrol.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscacontrol.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscacontrol.Location = New System.Drawing.Point(505, 48)
       Me.btnBuscacontrol.Name = "btnBuscacontrol"
       Me.btnBuscacontrol.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscacontrol.TabIndex = 60
       Me.btnBuscacontrol.UseVisualStyleBackColor = True
       '
       'cmbcontrol
       '
       Me.cmbcontrol.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbcontrol.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbcontrol.FormattingEnabled = True
       Me.cmbcontrol.Location = New System.Drawing.Point(161, 48)
       Me.cmbcontrol.Size = New System.Drawing.Size(329, 21)
       Me.cmbcontrol.Name = "cmbcontrol"
       Me.cmbcontrol.TabIndex = 4
       '
       'etiquietaid_control
       '
       Me.etiquetaid_control.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_control.AutoSize = True
       Me.etiquetaid_control.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_control.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_control.Location = New System.Drawing.Point(28, 48)
       Me.etiquetaid_control.Name = "etiquetaid_control"
       Me.etiquetaid_control.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_control.TabIndex = 501
       Me.etiquetaid_control.Text = "Control"
       Me.etiquetaid_control.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'dtpfecha
       '
       Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
       Me.dtpfecha.Location = New System.Drawing.Point(161, 91)
       Me.dtpfecha.Name = "cmbfecha"
       Me.dtpfecha.Size = New System.Drawing.Size(93, 20)
       Me.dtpfecha.TabIndex = 5
       '
       'etiquietafecha
       '
       Me.etiquetafecha.BackColor = System.Drawing.Color.Transparent
       Me.etiquetafecha.AutoSize = True
       Me.etiquetafecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetafecha.ForeColor = System.Drawing.Color.Black
       Me.etiquetafecha.Location = New System.Drawing.Point(28, 91)
       Me.etiquetafecha.Name = "etiquetafecha"
       Me.etiquetafecha.Size = New System.Drawing.Size(127, 21)
       Me.etiquetafecha.TabIndex = 502
       Me.etiquetafecha.Text = "Fecha"
       Me.etiquetafecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtot
       '
       Me.txtot.BackColor = System.Drawing.Color.White
       Me.txtot.Location = New System.Drawing.Point(161, 134)
       Me.txtot.Size = New System.Drawing.Size(385, 20)
       Me.txtot.MaxLength = 50
       Me.txtot.Name = "txtot"
       Me.txtot.TabIndex = 6
       '
       'etiquietaot
       '
       Me.etiquetaot.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaot.AutoSize = True
       Me.etiquetaot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaot.ForeColor = System.Drawing.Color.Black
       Me.etiquetaot.Location = New System.Drawing.Point(28, 134)
       Me.etiquetaot.Name = "etiquetaot"
       Me.etiquetaot.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaot.TabIndex = 503
       Me.etiquetaot.Text = "Ot"
       Me.etiquetaot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblid_actividad_proyecto
       '
       Me.lblid_actividad_proyecto.AutoSize = True
       Me.lblid_actividad_proyecto.BackColor = System.Drawing.Color.Red
       Me.lblid_actividad_proyecto.Location = New System.Drawing.Point(370, 177)
       Me.lblid_actividad_proyecto.Name = "lblid_actividad_proyecto"
       Me.lblid_actividad_proyecto.Size = New System.Drawing.Size(13, 13)
       Me.lblid_actividad_proyecto.TabIndex = 504
       Me.lblid_actividad_proyecto.Text = "0"
       Me.lblid_actividad_proyecto.Visible = False
       '
       'btnBuscaactividad_proyecto
       '
       Me.btnBuscaactividad_proyecto.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscaactividad_proyecto.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscaactividad_proyecto.Location = New System.Drawing.Point(505, 177)
       Me.btnBuscaactividad_proyecto.Name = "btnBuscaactividad_proyecto"
       Me.btnBuscaactividad_proyecto.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscaactividad_proyecto.TabIndex = 61
       Me.btnBuscaactividad_proyecto.UseVisualStyleBackColor = True
       '
       'cmbactividad_proyecto
       '
       Me.cmbactividad_proyecto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbactividad_proyecto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbactividad_proyecto.FormattingEnabled = True
       Me.cmbactividad_proyecto.Location = New System.Drawing.Point(161, 177)
       Me.cmbactividad_proyecto.Size = New System.Drawing.Size(329, 21)
       Me.cmbactividad_proyecto.Name = "cmbactividad_proyecto"
       Me.cmbactividad_proyecto.TabIndex = 7
       '
       'etiquietaid_actividad_proyecto
       '
       Me.etiquetaid_actividad_proyecto.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_actividad_proyecto.AutoSize = True
       Me.etiquetaid_actividad_proyecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_actividad_proyecto.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_actividad_proyecto.Location = New System.Drawing.Point(28, 177)
       Me.etiquetaid_actividad_proyecto.Name = "etiquetaid_actividad_proyecto"
       Me.etiquetaid_actividad_proyecto.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_actividad_proyecto.TabIndex = 505
       Me.etiquetaid_actividad_proyecto.Text = "Actividad proyecto"
       Me.etiquetaid_actividad_proyecto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblid_cadista
       '
       Me.lblid_cadista.AutoSize = True
       Me.lblid_cadista.BackColor = System.Drawing.Color.Red
       Me.lblid_cadista.Location = New System.Drawing.Point(370, 220)
       Me.lblid_cadista.Name = "lblid_cadista"
       Me.lblid_cadista.Size = New System.Drawing.Size(13, 13)
       Me.lblid_cadista.TabIndex = 506
       Me.lblid_cadista.Text = "0"
       Me.lblid_cadista.Visible = False
       '
       'btnBuscacadista
       '
       Me.btnBuscacadista.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscacadista.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscacadista.Location = New System.Drawing.Point(505, 220)
       Me.btnBuscacadista.Name = "btnBuscacadista"
       Me.btnBuscacadista.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscacadista.TabIndex = 62
       Me.btnBuscacadista.UseVisualStyleBackColor = True
       '
       'cmbcadista
       '
       Me.cmbcadista.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbcadista.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbcadista.FormattingEnabled = True
       Me.cmbcadista.Location = New System.Drawing.Point(161, 220)
       Me.cmbcadista.Size = New System.Drawing.Size(329, 21)
       Me.cmbcadista.Name = "cmbcadista"
       Me.cmbcadista.TabIndex = 8
       '
       'etiquietaid_cadista
       '
       Me.etiquetaid_cadista.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_cadista.AutoSize = True
       Me.etiquetaid_cadista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_cadista.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_cadista.Location = New System.Drawing.Point(28, 220)
       Me.etiquetaid_cadista.Name = "etiquetaid_cadista"
       Me.etiquetaid_cadista.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_cadista.TabIndex = 507
       Me.etiquetaid_cadista.Text = "Cadista"
       Me.etiquetaid_cadista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblid_proyect_manager
       '
       Me.lblid_proyect_manager.AutoSize = True
       Me.lblid_proyect_manager.BackColor = System.Drawing.Color.Red
       Me.lblid_proyect_manager.Location = New System.Drawing.Point(370, 263)
       Me.lblid_proyect_manager.Name = "lblid_proyect_manager"
       Me.lblid_proyect_manager.Size = New System.Drawing.Size(13, 13)
       Me.lblid_proyect_manager.TabIndex = 508
       Me.lblid_proyect_manager.Text = "0"
       Me.lblid_proyect_manager.Visible = False
       '
       'btnBuscaproyect_manager
       '
       Me.btnBuscaproyect_manager.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscaproyect_manager.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscaproyect_manager.Location = New System.Drawing.Point(505, 263)
       Me.btnBuscaproyect_manager.Name = "btnBuscaproyect_manager"
       Me.btnBuscaproyect_manager.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscaproyect_manager.TabIndex = 63
       Me.btnBuscaproyect_manager.UseVisualStyleBackColor = True
       '
       'cmbproyect_manager
       '
       Me.cmbproyect_manager.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbproyect_manager.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbproyect_manager.FormattingEnabled = True
       Me.cmbproyect_manager.Location = New System.Drawing.Point(161, 263)
       Me.cmbproyect_manager.Size = New System.Drawing.Size(329, 21)
       Me.cmbproyect_manager.Name = "cmbproyect_manager"
       Me.cmbproyect_manager.TabIndex = 9
       '
       'etiquietaid_proyect_manager
       '
       Me.etiquetaid_proyect_manager.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_proyect_manager.AutoSize = True
       Me.etiquetaid_proyect_manager.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_proyect_manager.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_proyect_manager.Location = New System.Drawing.Point(28, 263)
       Me.etiquetaid_proyect_manager.Name = "etiquetaid_proyect_manager"
       Me.etiquetaid_proyect_manager.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_proyect_manager.TabIndex = 509
       Me.etiquetaid_proyect_manager.Text = "Proyect manager"
       Me.etiquetaid_proyect_manager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblid_controlador_1
       '
       Me.lblid_controlador_1.AutoSize = True
       Me.lblid_controlador_1.BackColor = System.Drawing.Color.Red
       Me.lblid_controlador_1.Location = New System.Drawing.Point(370, 306)
       Me.lblid_controlador_1.Name = "lblid_controlador_1"
       Me.lblid_controlador_1.Size = New System.Drawing.Size(13, 13)
       Me.lblid_controlador_1.TabIndex = 510
       Me.lblid_controlador_1.Text = "0"
       Me.lblid_controlador_1.Visible = False
       '
       'btnBuscacontrolador_1
       '
       Me.btnBuscacontrolador_1.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscacontrolador_1.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscacontrolador_1.Location = New System.Drawing.Point(505, 306)
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
       Me.cmbcontrolador_1.Location = New System.Drawing.Point(161, 306)
       Me.cmbcontrolador_1.Size = New System.Drawing.Size(329, 21)
       Me.cmbcontrolador_1.Name = "cmbcontrolador_1"
       Me.cmbcontrolador_1.TabIndex = 10
       '
       'etiquietaid_controlador_1
       '
       Me.etiquetaid_controlador_1.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_controlador_1.AutoSize = True
       Me.etiquetaid_controlador_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_controlador_1.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_controlador_1.Location = New System.Drawing.Point(28, 306)
       Me.etiquetaid_controlador_1.Name = "etiquetaid_controlador_1"
       Me.etiquetaid_controlador_1.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_controlador_1.TabIndex = 511
       Me.etiquetaid_controlador_1.Text = "Controlador 1"
       Me.etiquetaid_controlador_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblid_controlador_2
       '
       Me.lblid_controlador_2.AutoSize = True
       Me.lblid_controlador_2.BackColor = System.Drawing.Color.Red
       Me.lblid_controlador_2.Location = New System.Drawing.Point(370, 349)
       Me.lblid_controlador_2.Name = "lblid_controlador_2"
       Me.lblid_controlador_2.Size = New System.Drawing.Size(13, 13)
       Me.lblid_controlador_2.TabIndex = 512
       Me.lblid_controlador_2.Text = "0"
       Me.lblid_controlador_2.Visible = False
       '
       'btnBuscacontrolador_2
       '
       Me.btnBuscacontrolador_2.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscacontrolador_2.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscacontrolador_2.Location = New System.Drawing.Point(505, 349)
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
       Me.cmbcontrolador_2.Location = New System.Drawing.Point(161, 349)
       Me.cmbcontrolador_2.Size = New System.Drawing.Size(329, 21)
       Me.cmbcontrolador_2.Name = "cmbcontrolador_2"
       Me.cmbcontrolador_2.TabIndex = 11
       '
       'etiquietaid_controlador_2
       '
       Me.etiquetaid_controlador_2.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_controlador_2.AutoSize = True
       Me.etiquetaid_controlador_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_controlador_2.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_controlador_2.Location = New System.Drawing.Point(28, 349)
       Me.etiquetaid_controlador_2.Name = "etiquetaid_controlador_2"
       Me.etiquetaid_controlador_2.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_controlador_2.TabIndex = 513
       Me.etiquetaid_controlador_2.Text = "Controlador 2"
       Me.etiquetaid_controlador_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'chkcompletado
       '
       Me.chkcompletado.AutoSize = True
       Me.chkcompletado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.chkcompletado.Location = New System.Drawing.Point(161, 392)
       Me.chkcompletado.Name = "etiquetacompletado"
       Me.chkcompletado.Size = New System.Drawing.Size(15, 14)
       Me.chkcompletado.TabIndex = 12
       Me.chkcompletado.Text = "completado"
       Me.chkcompletado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       'etiquietacompletado
       '
       Me.etiquetacompletado.BackColor = System.Drawing.Color.Transparent
       Me.etiquetacompletado.AutoSize = True
       Me.etiquetacompletado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetacompletado.ForeColor = System.Drawing.Color.Black
       Me.etiquetacompletado.Location = New System.Drawing.Point(28, 392)
       Me.etiquetacompletado.Name = "etiquetacompletado"
       Me.etiquetacompletado.Size = New System.Drawing.Size(127, 21)
       Me.etiquetacompletado.TabIndex = 514
       Me.etiquetacompletado.Text = "Completado"
       Me.etiquetacompletado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblid_usuario_anterior
       '
       Me.lblid_usuario_anterior.AutoSize = True
       Me.lblid_usuario_anterior.BackColor = System.Drawing.Color.Red
       Me.lblid_usuario_anterior.Location = New System.Drawing.Point(370, 435)
       Me.lblid_usuario_anterior.Name = "lblid_usuario_anterior"
       Me.lblid_usuario_anterior.Size = New System.Drawing.Size(13, 13)
       Me.lblid_usuario_anterior.TabIndex = 515
       Me.lblid_usuario_anterior.Text = "0"
       Me.lblid_usuario_anterior.Visible = False
       '
       'btnBuscausuario_anterior
       '
       Me.btnBuscausuario_anterior.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscausuario_anterior.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscausuario_anterior.Location = New System.Drawing.Point(505, 435)
       Me.btnBuscausuario_anterior.Name = "btnBuscausuario_anterior"
       Me.btnBuscausuario_anterior.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscausuario_anterior.TabIndex = 66
       Me.btnBuscausuario_anterior.UseVisualStyleBackColor = True
       '
       'cmbusuario_anterior
       '
       Me.cmbusuario_anterior.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbusuario_anterior.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbusuario_anterior.FormattingEnabled = True
       Me.cmbusuario_anterior.Location = New System.Drawing.Point(161, 435)
       Me.cmbusuario_anterior.Size = New System.Drawing.Size(329, 21)
       Me.cmbusuario_anterior.Name = "cmbusuario_anterior"
       Me.cmbusuario_anterior.TabIndex = 13
       '
       'etiquietaid_usuario_anterior
       '
       Me.etiquetaid_usuario_anterior.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_usuario_anterior.AutoSize = True
       Me.etiquetaid_usuario_anterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_usuario_anterior.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_usuario_anterior.Location = New System.Drawing.Point(28, 435)
       Me.etiquetaid_usuario_anterior.Name = "etiquetaid_usuario_anterior"
       Me.etiquetaid_usuario_anterior.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_usuario_anterior.TabIndex = 516
       Me.etiquetaid_usuario_anterior.Text = "Usuario anterior"
       Me.etiquetaid_usuario_anterior.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
       Me.btnSalir.Location = New System.Drawing.Point(499, 518)
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
       Me.btnGuardar.Location = New System.Drawing.Point(392,518)
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
       Me.GroupBox1.Size = New System.Drawing.Size(568, 478)
       Me.GroupBox1.TabIndex = 0
       Me.GroupBox1.TabStop = False
       '
       'frmDetalleMovimiento_voz
       '
       Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
       Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
       Me.ClientSize = New System.Drawing.Size(600, 598)
       Me.Controls.Add(Me.lblid_control)
       Me.Controls.Add(Me.btnBuscacontrol)
       Me.Controls.Add(Me.cmbcontrol)
       Me.Controls.Add(Me.etiquetaid_control)
       Me.Controls.Add(Me.dtpfecha)
       Me.Controls.Add(Me.etiquetafecha)
       Me.Controls.Add(Me.txtot)
       Me.Controls.Add(Me.etiquetaot)
       Me.Controls.Add(Me.lblid_actividad_proyecto)
       Me.Controls.Add(Me.btnBuscaactividad_proyecto)
       Me.Controls.Add(Me.cmbactividad_proyecto)
       Me.Controls.Add(Me.etiquetaid_actividad_proyecto)
       Me.Controls.Add(Me.lblid_cadista)
       Me.Controls.Add(Me.btnBuscacadista)
       Me.Controls.Add(Me.cmbcadista)
       Me.Controls.Add(Me.etiquetaid_cadista)
       Me.Controls.Add(Me.lblid_proyect_manager)
       Me.Controls.Add(Me.btnBuscaproyect_manager)
       Me.Controls.Add(Me.cmbproyect_manager)
       Me.Controls.Add(Me.etiquetaid_proyect_manager)
       Me.Controls.Add(Me.lblid_controlador_1)
       Me.Controls.Add(Me.btnBuscacontrolador_1)
       Me.Controls.Add(Me.cmbcontrolador_1)
       Me.Controls.Add(Me.etiquetaid_controlador_1)
       Me.Controls.Add(Me.lblid_controlador_2)
       Me.Controls.Add(Me.btnBuscacontrolador_2)
       Me.Controls.Add(Me.cmbcontrolador_2)
       Me.Controls.Add(Me.etiquetaid_controlador_2)
       Me.Controls.Add(Me.chkcompletado)
       Me.Controls.Add(Me.etiquetacompletado)
       Me.Controls.Add(Me.lblid_usuario_anterior)
       Me.Controls.Add(Me.btnBuscausuario_anterior)
       Me.Controls.Add(Me.cmbusuario_anterior)
       Me.Controls.Add(Me.etiquetaid_usuario_anterior)
       Me.Controls.Add(Me.btnSalir)
       Me.Controls.Add(Me.btnGuardar)
       Me.Controls.Add(Me.GroupBox1)
       Me.Name = "frmDetalleMovimiento_voz"
       Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
       Me.Text = "frmDetalleMovimiento_voz" & vgNombreFormulario
       Me.ResumeLayout(False)
       Me.PerformLayout()

   End Sub
   Friend WithEvents lblid_control As System.Windows.Forms.Label
   Friend WithEvents btnBuscacontrol As System.Windows.Forms.Button
   Friend WithEvents cmbcontrol As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_control As System.Windows.Forms.Label
   Protected WithEvents dtpfecha As System.Windows.Forms.DateTimePicker
   Friend WithEvents etiquetafecha As System.Windows.Forms.Label
   Protected WithEvents txtot As System.Windows.Forms.TextBox
   Friend WithEvents etiquetaot As System.Windows.Forms.Label
   Friend WithEvents lblid_actividad_proyecto As System.Windows.Forms.Label
   Friend WithEvents btnBuscaactividad_proyecto As System.Windows.Forms.Button
   Friend WithEvents cmbactividad_proyecto As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_actividad_proyecto As System.Windows.Forms.Label
   Friend WithEvents lblid_cadista As System.Windows.Forms.Label
   Friend WithEvents btnBuscacadista As System.Windows.Forms.Button
   Friend WithEvents cmbcadista As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_cadista As System.Windows.Forms.Label
   Friend WithEvents lblid_proyect_manager As System.Windows.Forms.Label
   Friend WithEvents btnBuscaproyect_manager As System.Windows.Forms.Button
   Friend WithEvents cmbproyect_manager As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_proyect_manager As System.Windows.Forms.Label
   Friend WithEvents lblid_controlador_1 As System.Windows.Forms.Label
   Friend WithEvents btnBuscacontrolador_1 As System.Windows.Forms.Button
   Friend WithEvents cmbcontrolador_1 As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_controlador_1 As System.Windows.Forms.Label
   Friend WithEvents lblid_controlador_2 As System.Windows.Forms.Label
   Friend WithEvents btnBuscacontrolador_2 As System.Windows.Forms.Button
   Friend WithEvents cmbcontrolador_2 As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_controlador_2 As System.Windows.Forms.Label
   Protected WithEvents chkcompletado As System.Windows.Forms.CheckBox
   Friend WithEvents etiquetacompletado As System.Windows.Forms.Label
   Friend WithEvents lblid_usuario_anterior As System.Windows.Forms.Label
   Friend WithEvents btnBuscausuario_anterior As System.Windows.Forms.Button
   Friend WithEvents cmbusuario_anterior As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_usuario_anterior As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
End Class

