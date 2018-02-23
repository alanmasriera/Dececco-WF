<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleActividad
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleActividad))
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtnombre_actividad = New System.Windows.Forms.TextBox()
        Me.etiquetanombre_actividad = New System.Windows.Forms.Label()
        Me.txttiempo_standart = New System.Windows.Forms.TextBox()
        Me.etiquetatiempo_standart = New System.Windows.Forms.Label()
        Me.txtcosto_standart = New System.Windows.Forms.TextBox()
        Me.etiquetacosto_standart = New System.Windows.Forms.Label()
        Me.lblid_tipo_actividad = New System.Windows.Forms.Label()
        Me.btnBuscatipo_actividad = New System.Windows.Forms.Button()
        Me.cmbtipo_actividad = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_tipo_actividad = New System.Windows.Forms.Label()
        Me.lblid_usuario = New System.Windows.Forms.Label()
        Me.btnBuscausuario = New System.Windows.Forms.Button()
        Me.cmbusuario = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_usuario = New System.Windows.Forms.Label()
        Me.lblid_actividad_proyecto = New System.Windows.Forms.Label()
        Me.txtmotivo = New System.Windows.Forms.TextBox()
        Me.etiquetamotivo = New System.Windows.Forms.Label()
        Me.lblid_detalle_recurso = New System.Windows.Forms.Label()
        Me.lblid_controlador_1 = New System.Windows.Forms.Label()
        Me.cmbcontrolador_1 = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_controlador_1 = New System.Windows.Forms.Label()
        Me.lblid_controlador_2 = New System.Windows.Forms.Label()
        Me.cmbcontrolador_2 = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_controlador_2 = New System.Windows.Forms.Label()
        Me.lblid_movimiento_voz = New System.Windows.Forms.Label()
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
        Me.btnSalir.Location = New System.Drawing.Point(499, 548)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(81, 69)
        Me.btnSalir.TabIndex = 21
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        Me.btnSalir.Visible = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(392, 548)
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
        Me.GroupBox1.Size = New System.Drawing.Size(568, 506)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtnombre_actividad
        '
        Me.txtnombre_actividad.BackColor = System.Drawing.Color.White
        Me.txtnombre_actividad.Location = New System.Drawing.Point(161, 48)
        Me.txtnombre_actividad.MaxLength = 100
        Me.txtnombre_actividad.Name = "txtnombre_actividad"
        Me.txtnombre_actividad.Size = New System.Drawing.Size(385, 20)
        Me.txtnombre_actividad.TabIndex = 4
        '
        'etiquetanombre_actividad
        '
        Me.etiquetanombre_actividad.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetanombre_actividad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetanombre_actividad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetanombre_actividad.ForeColor = System.Drawing.Color.Black
        Me.etiquetanombre_actividad.Location = New System.Drawing.Point(28, 48)
        Me.etiquetanombre_actividad.Name = "etiquetanombre_actividad"
        Me.etiquetanombre_actividad.Size = New System.Drawing.Size(127, 21)
        Me.etiquetanombre_actividad.TabIndex = 500
        Me.etiquetanombre_actividad.Text = "Nombre_actividad"
        Me.etiquetanombre_actividad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txttiempo_standart
        '
        Me.txttiempo_standart.BackColor = System.Drawing.Color.White
        Me.txttiempo_standart.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttiempo_standart.ForeColor = System.Drawing.Color.Blue
        Me.txttiempo_standart.Location = New System.Drawing.Point(161, 91)
        Me.txttiempo_standart.MaxLength = 50
        Me.txttiempo_standart.Name = "txttiempo_standart"
        Me.txttiempo_standart.Size = New System.Drawing.Size(222, 31)
        Me.txttiempo_standart.TabIndex = 5
        Me.txttiempo_standart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetatiempo_standart
        '
        Me.etiquetatiempo_standart.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetatiempo_standart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetatiempo_standart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetatiempo_standart.ForeColor = System.Drawing.Color.Black
        Me.etiquetatiempo_standart.Location = New System.Drawing.Point(28, 91)
        Me.etiquetatiempo_standart.Name = "etiquetatiempo_standart"
        Me.etiquetatiempo_standart.Size = New System.Drawing.Size(127, 21)
        Me.etiquetatiempo_standart.TabIndex = 501
        Me.etiquetatiempo_standart.Text = "Tiempo_standart"
        Me.etiquetatiempo_standart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcosto_standart
        '
        Me.txtcosto_standart.BackColor = System.Drawing.Color.White
        Me.txtcosto_standart.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcosto_standart.ForeColor = System.Drawing.Color.Blue
        Me.txtcosto_standart.Location = New System.Drawing.Point(155, 548)
        Me.txtcosto_standart.MaxLength = 50
        Me.txtcosto_standart.Name = "txtcosto_standart"
        Me.txtcosto_standart.Size = New System.Drawing.Size(222, 31)
        Me.txtcosto_standart.TabIndex = 6
        Me.txtcosto_standart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtcosto_standart.Visible = False
        '
        'etiquetacosto_standart
        '
        Me.etiquetacosto_standart.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetacosto_standart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetacosto_standart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetacosto_standart.ForeColor = System.Drawing.Color.Black
        Me.etiquetacosto_standart.Location = New System.Drawing.Point(22, 548)
        Me.etiquetacosto_standart.Name = "etiquetacosto_standart"
        Me.etiquetacosto_standart.Size = New System.Drawing.Size(127, 21)
        Me.etiquetacosto_standart.TabIndex = 502
        Me.etiquetacosto_standart.Text = "Costo_standart"
        Me.etiquetacosto_standart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.etiquetacosto_standart.Visible = False
        '
        'lblid_tipo_actividad
        '
        Me.lblid_tipo_actividad.AutoSize = True
        Me.lblid_tipo_actividad.BackColor = System.Drawing.Color.Red
        Me.lblid_tipo_actividad.Location = New System.Drawing.Point(370, 144)
        Me.lblid_tipo_actividad.Name = "lblid_tipo_actividad"
        Me.lblid_tipo_actividad.Size = New System.Drawing.Size(13, 13)
        Me.lblid_tipo_actividad.TabIndex = 503
        Me.lblid_tipo_actividad.Text = "0"
        Me.lblid_tipo_actividad.Visible = False
        '
        'btnBuscatipo_actividad
        '
        Me.btnBuscatipo_actividad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscatipo_actividad.Image = CType(resources.GetObject("btnBuscatipo_actividad.Image"), System.Drawing.Image)
        Me.btnBuscatipo_actividad.Location = New System.Drawing.Point(505, 144)
        Me.btnBuscatipo_actividad.Name = "btnBuscatipo_actividad"
        Me.btnBuscatipo_actividad.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscatipo_actividad.TabIndex = 30
        Me.btnBuscatipo_actividad.UseVisualStyleBackColor = True
        '
        'cmbtipo_actividad
        '
        Me.cmbtipo_actividad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbtipo_actividad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbtipo_actividad.FormattingEnabled = True
        Me.cmbtipo_actividad.Location = New System.Drawing.Point(161, 144)
        Me.cmbtipo_actividad.Name = "cmbtipo_actividad"
        Me.cmbtipo_actividad.Size = New System.Drawing.Size(329, 21)
        Me.cmbtipo_actividad.TabIndex = 7
        '
        'etiquetaid_tipo_actividad
        '
        Me.etiquetaid_tipo_actividad.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_tipo_actividad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_tipo_actividad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_tipo_actividad.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_tipo_actividad.Location = New System.Drawing.Point(28, 144)
        Me.etiquetaid_tipo_actividad.Name = "etiquetaid_tipo_actividad"
        Me.etiquetaid_tipo_actividad.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_tipo_actividad.TabIndex = 504
        Me.etiquetaid_tipo_actividad.Text = "Tipo_actividad"
        Me.etiquetaid_tipo_actividad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_usuario
        '
        Me.lblid_usuario.AutoSize = True
        Me.lblid_usuario.BackColor = System.Drawing.Color.Red
        Me.lblid_usuario.Location = New System.Drawing.Point(370, 188)
        Me.lblid_usuario.Name = "lblid_usuario"
        Me.lblid_usuario.Size = New System.Drawing.Size(13, 13)
        Me.lblid_usuario.TabIndex = 507
        Me.lblid_usuario.Text = "0"
        Me.lblid_usuario.Visible = False
        '
        'btnBuscausuario
        '
        Me.btnBuscausuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscausuario.Image = CType(resources.GetObject("btnBuscausuario.Image"), System.Drawing.Image)
        Me.btnBuscausuario.Location = New System.Drawing.Point(505, 188)
        Me.btnBuscausuario.Name = "btnBuscausuario"
        Me.btnBuscausuario.Size = New System.Drawing.Size(30, 21)
        Me.btnBuscausuario.TabIndex = 506
        Me.btnBuscausuario.UseVisualStyleBackColor = True
        Me.btnBuscausuario.Visible = False
        '
        'cmbusuario
        '
        Me.cmbusuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbusuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbusuario.FormattingEnabled = True
        Me.cmbusuario.Location = New System.Drawing.Point(161, 188)
        Me.cmbusuario.Name = "cmbusuario"
        Me.cmbusuario.Size = New System.Drawing.Size(329, 21)
        Me.cmbusuario.TabIndex = 8
        '
        'etiquetaid_usuario
        '
        Me.etiquetaid_usuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_usuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_usuario.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_usuario.Location = New System.Drawing.Point(28, 188)
        Me.etiquetaid_usuario.Name = "etiquetaid_usuario"
        Me.etiquetaid_usuario.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_usuario.TabIndex = 508
        Me.etiquetaid_usuario.Text = "Cadista"
        Me.etiquetaid_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_actividad_proyecto
        '
        Me.lblid_actividad_proyecto.AutoSize = True
        Me.lblid_actividad_proyecto.BackColor = System.Drawing.Color.Red
        Me.lblid_actividad_proyecto.Location = New System.Drawing.Point(586, 48)
        Me.lblid_actividad_proyecto.Name = "lblid_actividad_proyecto"
        Me.lblid_actividad_proyecto.Size = New System.Drawing.Size(13, 13)
        Me.lblid_actividad_proyecto.TabIndex = 509
        Me.lblid_actividad_proyecto.Text = "0"
        Me.lblid_actividad_proyecto.Visible = False
        '
        'txtmotivo
        '
        Me.txtmotivo.BackColor = System.Drawing.Color.White
        Me.txtmotivo.Location = New System.Drawing.Point(161, 227)
        Me.txtmotivo.MaxLength = 500
        Me.txtmotivo.Multiline = True
        Me.txtmotivo.Name = "txtmotivo"
        Me.txtmotivo.Size = New System.Drawing.Size(385, 154)
        Me.txtmotivo.TabIndex = 9
        '
        'etiquetamotivo
        '
        Me.etiquetamotivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetamotivo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetamotivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetamotivo.ForeColor = System.Drawing.Color.Black
        Me.etiquetamotivo.Location = New System.Drawing.Point(28, 227)
        Me.etiquetamotivo.Name = "etiquetamotivo"
        Me.etiquetamotivo.Size = New System.Drawing.Size(127, 21)
        Me.etiquetamotivo.TabIndex = 511
        Me.etiquetamotivo.Text = "Detalle"
        Me.etiquetamotivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_detalle_recurso
        '
        Me.lblid_detalle_recurso.AutoSize = True
        Me.lblid_detalle_recurso.BackColor = System.Drawing.Color.Red
        Me.lblid_detalle_recurso.Location = New System.Drawing.Point(586, 91)
        Me.lblid_detalle_recurso.Name = "lblid_detalle_recurso"
        Me.lblid_detalle_recurso.Size = New System.Drawing.Size(13, 13)
        Me.lblid_detalle_recurso.TabIndex = 512
        Me.lblid_detalle_recurso.Text = "0"
        Me.lblid_detalle_recurso.Visible = False
        '
        'lblid_controlador_1
        '
        Me.lblid_controlador_1.AutoSize = True
        Me.lblid_controlador_1.BackColor = System.Drawing.Color.Red
        Me.lblid_controlador_1.Location = New System.Drawing.Point(370, 437)
        Me.lblid_controlador_1.Name = "lblid_controlador_1"
        Me.lblid_controlador_1.Size = New System.Drawing.Size(13, 13)
        Me.lblid_controlador_1.TabIndex = 523
        Me.lblid_controlador_1.Text = "0"
        Me.lblid_controlador_1.Visible = False
        '
        'cmbcontrolador_1
        '
        Me.cmbcontrolador_1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbcontrolador_1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbcontrolador_1.FormattingEnabled = True
        Me.cmbcontrolador_1.Location = New System.Drawing.Point(161, 437)
        Me.cmbcontrolador_1.Name = "cmbcontrolador_1"
        Me.cmbcontrolador_1.Size = New System.Drawing.Size(329, 21)
        Me.cmbcontrolador_1.TabIndex = 521
        '
        'etiquetaid_controlador_1
        '
        Me.etiquetaid_controlador_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_controlador_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_controlador_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_controlador_1.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_controlador_1.Location = New System.Drawing.Point(28, 435)
        Me.etiquetaid_controlador_1.Name = "etiquetaid_controlador_1"
        Me.etiquetaid_controlador_1.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_controlador_1.TabIndex = 524
        Me.etiquetaid_controlador_1.Text = "Controlador_1"
        Me.etiquetaid_controlador_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_controlador_2
        '
        Me.lblid_controlador_2.AutoSize = True
        Me.lblid_controlador_2.BackColor = System.Drawing.Color.Red
        Me.lblid_controlador_2.Location = New System.Drawing.Point(370, 476)
        Me.lblid_controlador_2.Name = "lblid_controlador_2"
        Me.lblid_controlador_2.Size = New System.Drawing.Size(13, 13)
        Me.lblid_controlador_2.TabIndex = 525
        Me.lblid_controlador_2.Text = "0"
        Me.lblid_controlador_2.Visible = False
        '
        'cmbcontrolador_2
        '
        Me.cmbcontrolador_2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbcontrolador_2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbcontrolador_2.FormattingEnabled = True
        Me.cmbcontrolador_2.Location = New System.Drawing.Point(161, 476)
        Me.cmbcontrolador_2.Name = "cmbcontrolador_2"
        Me.cmbcontrolador_2.Size = New System.Drawing.Size(329, 21)
        Me.cmbcontrolador_2.TabIndex = 522
        '
        'etiquetaid_controlador_2
        '
        Me.etiquetaid_controlador_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_controlador_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_controlador_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_controlador_2.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_controlador_2.Location = New System.Drawing.Point(28, 476)
        Me.etiquetaid_controlador_2.Name = "etiquetaid_controlador_2"
        Me.etiquetaid_controlador_2.Size = New System.Drawing.Size(127, 21)
        Me.etiquetaid_controlador_2.TabIndex = 526
        Me.etiquetaid_controlador_2.Text = "Controlador_2"
        Me.etiquetaid_controlador_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_movimiento_voz
        '
        Me.lblid_movimiento_voz.AutoSize = True
        Me.lblid_movimiento_voz.BackColor = System.Drawing.Color.Red
        Me.lblid_movimiento_voz.Location = New System.Drawing.Point(586, 125)
        Me.lblid_movimiento_voz.Name = "lblid_movimiento_voz"
        Me.lblid_movimiento_voz.Size = New System.Drawing.Size(13, 13)
        Me.lblid_movimiento_voz.TabIndex = 527
        Me.lblid_movimiento_voz.Text = "0"
        Me.lblid_movimiento_voz.Visible = False
        '
        'frmDetalleActividad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 629)
        Me.Controls.Add(Me.lblid_movimiento_voz)
        Me.Controls.Add(Me.lblid_controlador_1)
        Me.Controls.Add(Me.lblid_detalle_recurso)
        Me.Controls.Add(Me.etiquetaid_controlador_1)
        Me.Controls.Add(Me.cmbcontrolador_1)
        Me.Controls.Add(Me.txtmotivo)
        Me.Controls.Add(Me.etiquetaid_controlador_2)
        Me.Controls.Add(Me.etiquetamotivo)
        Me.Controls.Add(Me.lblid_actividad_proyecto)
        Me.Controls.Add(Me.lblid_controlador_2)
        Me.Controls.Add(Me.lblid_usuario)
        Me.Controls.Add(Me.btnBuscausuario)
        Me.Controls.Add(Me.cmbusuario)
        Me.Controls.Add(Me.etiquetaid_usuario)
        Me.Controls.Add(Me.txtnombre_actividad)
        Me.Controls.Add(Me.etiquetanombre_actividad)
        Me.Controls.Add(Me.txttiempo_standart)
        Me.Controls.Add(Me.etiquetatiempo_standart)
        Me.Controls.Add(Me.txtcosto_standart)
        Me.Controls.Add(Me.etiquetacosto_standart)
        Me.Controls.Add(Me.lblid_tipo_actividad)
        Me.Controls.Add(Me.btnBuscatipo_actividad)
        Me.Controls.Add(Me.cmbtipo_actividad)
        Me.Controls.Add(Me.etiquetaid_tipo_actividad)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.cmbcontrolador_2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDetalleActividad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetalleActividad"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Protected WithEvents txtnombre_actividad As System.Windows.Forms.TextBox
    Friend WithEvents etiquetanombre_actividad As System.Windows.Forms.Label
    Protected WithEvents txttiempo_standart As System.Windows.Forms.TextBox
    Friend WithEvents etiquetatiempo_standart As System.Windows.Forms.Label
    Protected WithEvents txtcosto_standart As System.Windows.Forms.TextBox
    Friend WithEvents etiquetacosto_standart As System.Windows.Forms.Label
    Friend WithEvents lblid_tipo_actividad As System.Windows.Forms.Label
    Friend WithEvents btnBuscatipo_actividad As System.Windows.Forms.Button
    Friend WithEvents cmbtipo_actividad As System.Windows.Forms.ComboBox
    Friend WithEvents etiquetaid_tipo_actividad As System.Windows.Forms.Label
    Protected WithEvents btnSalir As System.Windows.Forms.Button
    Protected WithEvents btnGuardar As System.Windows.Forms.Button
    Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
    Friend WithEvents lblid_usuario As System.Windows.Forms.Label
    Friend WithEvents btnBuscausuario As System.Windows.Forms.Button
    Friend WithEvents cmbusuario As System.Windows.Forms.ComboBox
    Friend WithEvents etiquetaid_usuario As System.Windows.Forms.Label
    Friend WithEvents lblid_actividad_proyecto As System.Windows.Forms.Label
    Protected WithEvents txtmotivo As System.Windows.Forms.TextBox
    Friend WithEvents etiquetamotivo As System.Windows.Forms.Label
    Friend WithEvents lblid_detalle_recurso As System.Windows.Forms.Label
    Friend WithEvents lblid_controlador_1 As System.Windows.Forms.Label
    Friend WithEvents cmbcontrolador_1 As System.Windows.Forms.ComboBox
    Friend WithEvents etiquetaid_controlador_1 As System.Windows.Forms.Label
    Friend WithEvents lblid_controlador_2 As System.Windows.Forms.Label
    Friend WithEvents cmbcontrolador_2 As System.Windows.Forms.ComboBox
    Friend WithEvents etiquetaid_controlador_2 As System.Windows.Forms.Label
    Friend WithEvents lblid_movimiento_voz As System.Windows.Forms.Label
End Class

