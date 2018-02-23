<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleModificacion_arbol
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
       Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleModificacion_arbol))
       Me.btnSalir = New System.Windows.Forms.Button
       Me.btnGuardar = New System.Windows.Forms.Button
       Me.GroupBox1 = New System.Windows.Forms.GroupBox
       Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
       Me.txtnombre_modificacion_arbol = New System.Windows.Forms.TextBox
       Me.etiquetanombre_modificacion_arbol = New System.Windows.Forms.Label
       Me.lblid_usuario = New System.Windows.Forms.Label
       Me.btnBuscausuario = New System.Windows.Forms.Button
       Me.cmbusuario = New System.Windows.Forms.ComboBox
       Me.etiquetaid_usuario = New System.Windows.Forms.Label
       Me.chkrealizado = New System.Windows.Forms.CheckBox
       Me.etiquetarealizado = New System.Windows.Forms.Label
       Me.lblid_actividad = New System.Windows.Forms.Label
       Me.btnBuscaactividad = New System.Windows.Forms.Button
       Me.cmbactividad = New System.Windows.Forms.ComboBox
       Me.etiquetaid_actividad = New System.Windows.Forms.Label
       Me.lblid_proyecto = New System.Windows.Forms.Label
       Me.btnBuscaproyecto = New System.Windows.Forms.Button
       Me.cmbproyecto = New System.Windows.Forms.ComboBox
       Me.etiquetaid_proyecto = New System.Windows.Forms.Label
       Me.lblid_actividad_proyecto = New System.Windows.Forms.Label
       Me.btnBuscaactividad_proyecto = New System.Windows.Forms.Button
       Me.cmbactividad_proyecto = New System.Windows.Forms.ComboBox
       Me.etiquetaid_actividad_proyecto = New System.Windows.Forms.Label
       Me.txttipo_nodo = New System.Windows.Forms.TextBox
       Me.etiquetatipo_nodo = New System.Windows.Forms.Label
       Me.txtnodo = New System.Windows.Forms.TextBox
       Me.etiquetanodo = New System.Windows.Forms.Label
       Me.txtnodo_padre = New System.Windows.Forms.TextBox
       Me.etiquetanodo_padre = New System.Windows.Forms.Label
       Me.txtnombre = New System.Windows.Forms.TextBox
       Me.etiquetanombre = New System.Windows.Forms.Label
       Me.lblid_usuario_modificador = New System.Windows.Forms.Label
       Me.btnBuscausuario_modificador = New System.Windows.Forms.Button
       Me.cmbusuario_modificador = New System.Windows.Forms.ComboBox
       Me.etiquetaid_usuario_modificador = New System.Windows.Forms.Label
       Me.SuspendLayout()
       '
       'txtnombre_modificacion_arbol
       '
       Me.txtnombre_modificacion_arbol.BackColor = System.Drawing.Color.White
       Me.txtnombre_modificacion_arbol.Location = New System.Drawing.Point(161, 48)
       Me.txtnombre_modificacion_arbol.Size = New System.Drawing.Size(385, 20)
       Me.txtnombre_modificacion_arbol.MaxLength = 500
       Me.txtnombre_modificacion_arbol.Name = "txtnombre_modificacion_arbol"
       Me.txtnombre_modificacion_arbol.TabIndex = 4
       '
       'etiquietanombre_modificacion_arbol
       '
       Me.etiquetanombre_modificacion_arbol.BackColor = System.Drawing.Color.Transparent
       Me.etiquetanombre_modificacion_arbol.AutoSize = True
       Me.etiquetanombre_modificacion_arbol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetanombre_modificacion_arbol.ForeColor = System.Drawing.Color.Black
       Me.etiquetanombre_modificacion_arbol.Location = New System.Drawing.Point(28, 48)
       Me.etiquetanombre_modificacion_arbol.Name = "etiquetanombre_modificacion_arbol"
       Me.etiquetanombre_modificacion_arbol.Size = New System.Drawing.Size(127, 21)
       Me.etiquetanombre_modificacion_arbol.TabIndex = 500
       Me.etiquetanombre_modificacion_arbol.Text = "Nombre modificacion arbol"
       Me.etiquetanombre_modificacion_arbol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblid_usuario
       '
       Me.lblid_usuario.AutoSize = True
       Me.lblid_usuario.BackColor = System.Drawing.Color.Red
       Me.lblid_usuario.Location = New System.Drawing.Point(370, 91)
       Me.lblid_usuario.Name = "lblid_usuario"
       Me.lblid_usuario.Size = New System.Drawing.Size(13, 13)
       Me.lblid_usuario.TabIndex = 501
       Me.lblid_usuario.Text = "0"
       Me.lblid_usuario.Visible = False
       '
       'btnBuscausuario
       '
       Me.btnBuscausuario.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscausuario.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscausuario.Location = New System.Drawing.Point(505, 91)
       Me.btnBuscausuario.Name = "btnBuscausuario"
       Me.btnBuscausuario.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscausuario.TabIndex = 60
       Me.btnBuscausuario.UseVisualStyleBackColor = True
       '
       'cmbusuario
       '
       Me.cmbusuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbusuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbusuario.FormattingEnabled = True
       Me.cmbusuario.Location = New System.Drawing.Point(161, 91)
       Me.cmbusuario.Size = New System.Drawing.Size(329, 21)
       Me.cmbusuario.Name = "cmbusuario"
       Me.cmbusuario.TabIndex = 5
       '
       'etiquietaid_usuario
       '
       Me.etiquetaid_usuario.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_usuario.AutoSize = True
       Me.etiquetaid_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_usuario.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_usuario.Location = New System.Drawing.Point(28, 91)
       Me.etiquetaid_usuario.Name = "etiquetaid_usuario"
       Me.etiquetaid_usuario.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_usuario.TabIndex = 502
       Me.etiquetaid_usuario.Text = "Usuario"
       Me.etiquetaid_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'chkrealizado
       '
       Me.chkrealizado.AutoSize = True
       Me.chkrealizado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.chkrealizado.Location = New System.Drawing.Point(161, 134)
       Me.chkrealizado.Name = "etiquetarealizado"
       Me.chkrealizado.Size = New System.Drawing.Size(15, 14)
       Me.chkrealizado.TabIndex = 6
       Me.chkrealizado.Text = "realizado"
       Me.chkrealizado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       'etiquietarealizado
       '
       Me.etiquetarealizado.BackColor = System.Drawing.Color.Transparent
       Me.etiquetarealizado.AutoSize = True
       Me.etiquetarealizado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetarealizado.ForeColor = System.Drawing.Color.Black
       Me.etiquetarealizado.Location = New System.Drawing.Point(28, 134)
       Me.etiquetarealizado.Name = "etiquetarealizado"
       Me.etiquetarealizado.Size = New System.Drawing.Size(127, 21)
       Me.etiquetarealizado.TabIndex = 503
       Me.etiquetarealizado.Text = "Realizado"
       Me.etiquetarealizado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblid_actividad
       '
       Me.lblid_actividad.AutoSize = True
       Me.lblid_actividad.BackColor = System.Drawing.Color.Red
       Me.lblid_actividad.Location = New System.Drawing.Point(370, 177)
       Me.lblid_actividad.Name = "lblid_actividad"
       Me.lblid_actividad.Size = New System.Drawing.Size(13, 13)
       Me.lblid_actividad.TabIndex = 504
       Me.lblid_actividad.Text = "0"
       Me.lblid_actividad.Visible = False
       '
       'btnBuscaactividad
       '
       Me.btnBuscaactividad.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscaactividad.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscaactividad.Location = New System.Drawing.Point(505, 177)
       Me.btnBuscaactividad.Name = "btnBuscaactividad"
       Me.btnBuscaactividad.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscaactividad.TabIndex = 61
       Me.btnBuscaactividad.UseVisualStyleBackColor = True
       '
       'cmbactividad
       '
       Me.cmbactividad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbactividad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbactividad.FormattingEnabled = True
       Me.cmbactividad.Location = New System.Drawing.Point(161, 177)
       Me.cmbactividad.Size = New System.Drawing.Size(329, 21)
       Me.cmbactividad.Name = "cmbactividad"
       Me.cmbactividad.TabIndex = 7
       '
       'etiquietaid_actividad
       '
       Me.etiquetaid_actividad.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_actividad.AutoSize = True
       Me.etiquetaid_actividad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_actividad.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_actividad.Location = New System.Drawing.Point(28, 177)
       Me.etiquetaid_actividad.Name = "etiquetaid_actividad"
       Me.etiquetaid_actividad.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_actividad.TabIndex = 505
       Me.etiquetaid_actividad.Text = "Actividad"
       Me.etiquetaid_actividad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblid_proyecto
       '
       Me.lblid_proyecto.AutoSize = True
       Me.lblid_proyecto.BackColor = System.Drawing.Color.Red
       Me.lblid_proyecto.Location = New System.Drawing.Point(370, 220)
       Me.lblid_proyecto.Name = "lblid_proyecto"
       Me.lblid_proyecto.Size = New System.Drawing.Size(13, 13)
       Me.lblid_proyecto.TabIndex = 506
       Me.lblid_proyecto.Text = "0"
       Me.lblid_proyecto.Visible = False
       '
       'btnBuscaproyecto
       '
       Me.btnBuscaproyecto.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscaproyecto.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscaproyecto.Location = New System.Drawing.Point(505, 220)
       Me.btnBuscaproyecto.Name = "btnBuscaproyecto"
       Me.btnBuscaproyecto.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscaproyecto.TabIndex = 62
       Me.btnBuscaproyecto.UseVisualStyleBackColor = True
       '
       'cmbproyecto
       '
       Me.cmbproyecto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbproyecto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbproyecto.FormattingEnabled = True
       Me.cmbproyecto.Location = New System.Drawing.Point(161, 220)
       Me.cmbproyecto.Size = New System.Drawing.Size(329, 21)
       Me.cmbproyecto.Name = "cmbproyecto"
       Me.cmbproyecto.TabIndex = 8
       '
       'etiquietaid_proyecto
       '
       Me.etiquetaid_proyecto.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_proyecto.AutoSize = True
       Me.etiquetaid_proyecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_proyecto.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_proyecto.Location = New System.Drawing.Point(28, 220)
       Me.etiquetaid_proyecto.Name = "etiquetaid_proyecto"
       Me.etiquetaid_proyecto.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_proyecto.TabIndex = 507
       Me.etiquetaid_proyecto.Text = "Proyecto"
       Me.etiquetaid_proyecto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblid_actividad_proyecto
       '
       Me.lblid_actividad_proyecto.AutoSize = True
       Me.lblid_actividad_proyecto.BackColor = System.Drawing.Color.Red
       Me.lblid_actividad_proyecto.Location = New System.Drawing.Point(370, 263)
       Me.lblid_actividad_proyecto.Name = "lblid_actividad_proyecto"
       Me.lblid_actividad_proyecto.Size = New System.Drawing.Size(13, 13)
       Me.lblid_actividad_proyecto.TabIndex = 508
       Me.lblid_actividad_proyecto.Text = "0"
       Me.lblid_actividad_proyecto.Visible = False
       '
       'btnBuscaactividad_proyecto
       '
       Me.btnBuscaactividad_proyecto.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscaactividad_proyecto.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscaactividad_proyecto.Location = New System.Drawing.Point(505, 263)
       Me.btnBuscaactividad_proyecto.Name = "btnBuscaactividad_proyecto"
       Me.btnBuscaactividad_proyecto.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscaactividad_proyecto.TabIndex = 63
       Me.btnBuscaactividad_proyecto.UseVisualStyleBackColor = True
       '
       'cmbactividad_proyecto
       '
       Me.cmbactividad_proyecto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbactividad_proyecto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbactividad_proyecto.FormattingEnabled = True
       Me.cmbactividad_proyecto.Location = New System.Drawing.Point(161, 263)
       Me.cmbactividad_proyecto.Size = New System.Drawing.Size(329, 21)
       Me.cmbactividad_proyecto.Name = "cmbactividad_proyecto"
       Me.cmbactividad_proyecto.TabIndex = 9
       '
       'etiquietaid_actividad_proyecto
       '
       Me.etiquetaid_actividad_proyecto.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_actividad_proyecto.AutoSize = True
       Me.etiquetaid_actividad_proyecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_actividad_proyecto.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_actividad_proyecto.Location = New System.Drawing.Point(28, 263)
       Me.etiquetaid_actividad_proyecto.Name = "etiquetaid_actividad_proyecto"
       Me.etiquetaid_actividad_proyecto.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_actividad_proyecto.TabIndex = 509
       Me.etiquetaid_actividad_proyecto.Text = "Actividad proyecto"
       Me.etiquetaid_actividad_proyecto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txttipo_nodo
       '
       Me.txttipo_nodo.BackColor = System.Drawing.Color.White
       Me.txttipo_nodo.Location = New System.Drawing.Point(161, 306)
       Me.txttipo_nodo.Size = New System.Drawing.Size(385, 20)
       Me.txttipo_nodo.MaxLength = 1
       Me.txttipo_nodo.Name = "txttipo_nodo"
       Me.txttipo_nodo.TabIndex = 10
       '
       'etiquietatipo_nodo
       '
       Me.etiquetatipo_nodo.BackColor = System.Drawing.Color.Transparent
       Me.etiquetatipo_nodo.AutoSize = True
       Me.etiquetatipo_nodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetatipo_nodo.ForeColor = System.Drawing.Color.Black
       Me.etiquetatipo_nodo.Location = New System.Drawing.Point(28, 306)
       Me.etiquetatipo_nodo.Name = "etiquetatipo_nodo"
       Me.etiquetatipo_nodo.Size = New System.Drawing.Size(127, 21)
       Me.etiquetatipo_nodo.TabIndex = 510
       Me.etiquetatipo_nodo.Text = "Tipo nodo"
       Me.etiquetatipo_nodo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtnodo
       '
       Me.txtnodo.BackColor = System.Drawing.Color.White
       Me.txtnodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtnodo.ForeColor = System.Drawing.Color.Blue
       Me.txtnodo.Location = New System.Drawing.Point(161, 349)
       Me.txtnodo.MaxLength = 50
       Me.txtnodo.Name = "txtnodo"
       Me.txtnodo.Size = New System.Drawing.Size(222, 31)
       Me.txtnodo.TabIndex = 11
       Me.txtnodo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietanodo
       '
       Me.etiquetanodo.BackColor = System.Drawing.Color.Transparent
       Me.etiquetanodo.AutoSize = True
       Me.etiquetanodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetanodo.ForeColor = System.Drawing.Color.Black
       Me.etiquetanodo.Location = New System.Drawing.Point(28, 349)
       Me.etiquetanodo.Name = "etiquetanodo"
       Me.etiquetanodo.Size = New System.Drawing.Size(127, 21)
       Me.etiquetanodo.TabIndex = 511
       Me.etiquetanodo.Text = "Nodo"
       Me.etiquetanodo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtnodo_padre
       '
       Me.txtnodo_padre.BackColor = System.Drawing.Color.White
       Me.txtnodo_padre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtnodo_padre.ForeColor = System.Drawing.Color.Blue
       Me.txtnodo_padre.Location = New System.Drawing.Point(161, 402)
       Me.txtnodo_padre.MaxLength = 50
       Me.txtnodo_padre.Name = "txtnodo_padre"
       Me.txtnodo_padre.Size = New System.Drawing.Size(222, 31)
       Me.txtnodo_padre.TabIndex = 12
       Me.txtnodo_padre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietanodo_padre
       '
       Me.etiquetanodo_padre.BackColor = System.Drawing.Color.Transparent
       Me.etiquetanodo_padre.AutoSize = True
       Me.etiquetanodo_padre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetanodo_padre.ForeColor = System.Drawing.Color.Black
       Me.etiquetanodo_padre.Location = New System.Drawing.Point(28, 402)
       Me.etiquetanodo_padre.Name = "etiquetanodo_padre"
       Me.etiquetanodo_padre.Size = New System.Drawing.Size(127, 21)
       Me.etiquetanodo_padre.TabIndex = 512
       Me.etiquetanodo_padre.Text = "Nodo padre"
       Me.etiquetanodo_padre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtnombre
       '
       Me.txtnombre.BackColor = System.Drawing.Color.White
       Me.txtnombre.Location = New System.Drawing.Point(161, 455)
       Me.txtnombre.Size = New System.Drawing.Size(385, 20)
       Me.txtnombre.MaxLength = 50
       Me.txtnombre.Name = "txtnombre"
       Me.txtnombre.TabIndex = 13
       '
       'etiquietanombre
       '
       Me.etiquetanombre.BackColor = System.Drawing.Color.Transparent
       Me.etiquetanombre.AutoSize = True
       Me.etiquetanombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetanombre.ForeColor = System.Drawing.Color.Black
       Me.etiquetanombre.Location = New System.Drawing.Point(28, 455)
       Me.etiquetanombre.Name = "etiquetanombre"
       Me.etiquetanombre.Size = New System.Drawing.Size(127, 21)
       Me.etiquetanombre.TabIndex = 513
       Me.etiquetanombre.Text = "Nombre"
       Me.etiquetanombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblid_usuario_modificador
       '
       Me.lblid_usuario_modificador.AutoSize = True
       Me.lblid_usuario_modificador.BackColor = System.Drawing.Color.Red
       Me.lblid_usuario_modificador.Location = New System.Drawing.Point(370, 498)
       Me.lblid_usuario_modificador.Name = "lblid_usuario_modificador"
       Me.lblid_usuario_modificador.Size = New System.Drawing.Size(13, 13)
       Me.lblid_usuario_modificador.TabIndex = 514
       Me.lblid_usuario_modificador.Text = "0"
       Me.lblid_usuario_modificador.Visible = False
       '
       'btnBuscausuario_modificador
       '
       Me.btnBuscausuario_modificador.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscausuario_modificador.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscausuario_modificador.Location = New System.Drawing.Point(505, 498)
       Me.btnBuscausuario_modificador.Name = "btnBuscausuario_modificador"
       Me.btnBuscausuario_modificador.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscausuario_modificador.TabIndex = 64
       Me.btnBuscausuario_modificador.UseVisualStyleBackColor = True
       '
       'cmbusuario_modificador
       '
       Me.cmbusuario_modificador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbusuario_modificador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbusuario_modificador.FormattingEnabled = True
       Me.cmbusuario_modificador.Location = New System.Drawing.Point(161, 498)
       Me.cmbusuario_modificador.Size = New System.Drawing.Size(329, 21)
       Me.cmbusuario_modificador.Name = "cmbusuario_modificador"
       Me.cmbusuario_modificador.TabIndex = 14
       '
       'etiquietaid_usuario_modificador
       '
       Me.etiquetaid_usuario_modificador.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_usuario_modificador.AutoSize = True
       Me.etiquetaid_usuario_modificador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_usuario_modificador.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_usuario_modificador.Location = New System.Drawing.Point(28, 498)
       Me.etiquetaid_usuario_modificador.Name = "etiquetaid_usuario_modificador"
       Me.etiquetaid_usuario_modificador.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_usuario_modificador.TabIndex = 515
       Me.etiquetaid_usuario_modificador.Text = "Usuario modificador"
       Me.etiquetaid_usuario_modificador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
       Me.btnSalir.Location = New System.Drawing.Point(499, 581)
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
       Me.btnGuardar.Location = New System.Drawing.Point(392,581)
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
       Me.GroupBox1.Size = New System.Drawing.Size(568, 541)
       Me.GroupBox1.TabIndex = 0
       Me.GroupBox1.TabStop = False
       '
       'frmDetalleModificacion_arbol
       '
       Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
       Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
       Me.ClientSize = New System.Drawing.Size(600, 661)
       Me.Controls.Add(Me.txtnombre_modificacion_arbol)
       Me.Controls.Add(Me.etiquetanombre_modificacion_arbol)
       Me.Controls.Add(Me.lblid_usuario)
       Me.Controls.Add(Me.btnBuscausuario)
       Me.Controls.Add(Me.cmbusuario)
       Me.Controls.Add(Me.etiquetaid_usuario)
       Me.Controls.Add(Me.chkrealizado)
       Me.Controls.Add(Me.etiquetarealizado)
       Me.Controls.Add(Me.lblid_actividad)
       Me.Controls.Add(Me.btnBuscaactividad)
       Me.Controls.Add(Me.cmbactividad)
       Me.Controls.Add(Me.etiquetaid_actividad)
       Me.Controls.Add(Me.lblid_proyecto)
       Me.Controls.Add(Me.btnBuscaproyecto)
       Me.Controls.Add(Me.cmbproyecto)
       Me.Controls.Add(Me.etiquetaid_proyecto)
       Me.Controls.Add(Me.lblid_actividad_proyecto)
       Me.Controls.Add(Me.btnBuscaactividad_proyecto)
       Me.Controls.Add(Me.cmbactividad_proyecto)
       Me.Controls.Add(Me.etiquetaid_actividad_proyecto)
       Me.Controls.Add(Me.txttipo_nodo)
       Me.Controls.Add(Me.etiquetatipo_nodo)
       Me.Controls.Add(Me.txtnodo)
       Me.Controls.Add(Me.etiquetanodo)
       Me.Controls.Add(Me.txtnodo_padre)
       Me.Controls.Add(Me.etiquetanodo_padre)
       Me.Controls.Add(Me.txtnombre)
       Me.Controls.Add(Me.etiquetanombre)
       Me.Controls.Add(Me.lblid_usuario_modificador)
       Me.Controls.Add(Me.btnBuscausuario_modificador)
       Me.Controls.Add(Me.cmbusuario_modificador)
       Me.Controls.Add(Me.etiquetaid_usuario_modificador)
       Me.Controls.Add(Me.btnSalir)
       Me.Controls.Add(Me.btnGuardar)
       Me.Controls.Add(Me.GroupBox1)
       Me.Name = "frmDetalleModificacion_arbol"
       Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
       Me.Text = "frmDetalleModificacion_arbol" & vgNombreFormulario
       Me.ResumeLayout(False)
       Me.PerformLayout()

   End Sub
   Protected WithEvents txtnombre_modificacion_arbol As System.Windows.Forms.TextBox
   Friend WithEvents etiquetanombre_modificacion_arbol As System.Windows.Forms.Label
   Friend WithEvents lblid_usuario As System.Windows.Forms.Label
   Friend WithEvents btnBuscausuario As System.Windows.Forms.Button
   Friend WithEvents cmbusuario As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_usuario As System.Windows.Forms.Label
   Protected WithEvents chkrealizado As System.Windows.Forms.CheckBox
   Friend WithEvents etiquetarealizado As System.Windows.Forms.Label
   Friend WithEvents lblid_actividad As System.Windows.Forms.Label
   Friend WithEvents btnBuscaactividad As System.Windows.Forms.Button
   Friend WithEvents cmbactividad As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_actividad As System.Windows.Forms.Label
   Friend WithEvents lblid_proyecto As System.Windows.Forms.Label
   Friend WithEvents btnBuscaproyecto As System.Windows.Forms.Button
   Friend WithEvents cmbproyecto As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_proyecto As System.Windows.Forms.Label
   Friend WithEvents lblid_actividad_proyecto As System.Windows.Forms.Label
   Friend WithEvents btnBuscaactividad_proyecto As System.Windows.Forms.Button
   Friend WithEvents cmbactividad_proyecto As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_actividad_proyecto As System.Windows.Forms.Label
   Protected WithEvents txttipo_nodo As System.Windows.Forms.TextBox
   Friend WithEvents etiquetatipo_nodo As System.Windows.Forms.Label
   Protected WithEvents txtnodo As System.Windows.Forms.TextBox
   Friend WithEvents etiquetanodo As System.Windows.Forms.Label
   Protected WithEvents txtnodo_padre As System.Windows.Forms.TextBox
   Friend WithEvents etiquetanodo_padre As System.Windows.Forms.Label
   Protected WithEvents txtnombre As System.Windows.Forms.TextBox
   Friend WithEvents etiquetanombre As System.Windows.Forms.Label
   Friend WithEvents lblid_usuario_modificador As System.Windows.Forms.Label
   Friend WithEvents btnBuscausuario_modificador As System.Windows.Forms.Button
   Friend WithEvents cmbusuario_modificador As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_usuario_modificador As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
End Class

