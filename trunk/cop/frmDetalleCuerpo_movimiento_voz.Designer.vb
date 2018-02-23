<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleCuerpo_movimiento_voz
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
       Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleCuerpo_movimiento_voz))
       Me.btnSalir = New System.Windows.Forms.Button
       Me.btnGuardar = New System.Windows.Forms.Button
       Me.GroupBox1 = New System.Windows.Forms.GroupBox
       Me.ttGeneral = New System.Windows.Forms.ToolTip(Me.components)
       Me.lblid_voz = New System.Windows.Forms.Label
       Me.btnBuscavoz = New System.Windows.Forms.Button
       Me.cmbvoz = New System.Windows.Forms.ComboBox
       Me.etiquetaid_voz = New System.Windows.Forms.Label
       Me.chknc1 = New System.Windows.Forms.CheckBox
       Me.etiquetanc1 = New System.Windows.Forms.Label
       Me.chkok1 = New System.Windows.Forms.CheckBox
       Me.etiquetaok1 = New System.Windows.Forms.Label
       Me.chkcorresponde1 = New System.Windows.Forms.CheckBox
       Me.etiquetacorresponde1 = New System.Windows.Forms.Label
       Me.chkconforme1 = New System.Windows.Forms.CheckBox
       Me.etiquetaconforme1 = New System.Windows.Forms.Label
       Me.chkno_conforme1 = New System.Windows.Forms.CheckBox
       Me.etiquetano_conforme1 = New System.Windows.Forms.Label
       Me.txttipo1 = New System.Windows.Forms.TextBox
       Me.etiquetatipo1 = New System.Windows.Forms.Label
       Me.txtdetalle1 = New System.Windows.Forms.TextBox
       Me.etiquetadetalle1 = New System.Windows.Forms.Label
       Me.chkcorreccion1 = New System.Windows.Forms.CheckBox
       Me.etiquetacorreccion1 = New System.Windows.Forms.Label
       Me.lblid_movimiento_voz = New System.Windows.Forms.Label
       Me.btnBuscamovimiento_voz = New System.Windows.Forms.Button
       Me.cmbmovimiento_voz = New System.Windows.Forms.ComboBox
       Me.etiquetaid_movimiento_voz = New System.Windows.Forms.Label
       Me.lblid_usuario = New System.Windows.Forms.Label
       Me.btnBuscausuario = New System.Windows.Forms.Button
       Me.cmbusuario = New System.Windows.Forms.ComboBox
       Me.etiquetaid_usuario = New System.Windows.Forms.Label
       Me.chkcorresponde2 = New System.Windows.Forms.CheckBox
       Me.etiquetacorresponde2 = New System.Windows.Forms.Label
       Me.chkconforme2 = New System.Windows.Forms.CheckBox
       Me.etiquetaconforme2 = New System.Windows.Forms.Label
       Me.chkno_conforme2 = New System.Windows.Forms.CheckBox
       Me.etiquetano_conforme2 = New System.Windows.Forms.Label
       Me.txttipo2 = New System.Windows.Forms.TextBox
       Me.etiquetatipo2 = New System.Windows.Forms.Label
       Me.txtdetalle2 = New System.Windows.Forms.TextBox
       Me.etiquetadetalle2 = New System.Windows.Forms.Label
       Me.chkcorreccion2 = New System.Windows.Forms.CheckBox
       Me.etiquetacorreccion2 = New System.Windows.Forms.Label
       Me.txtrandom = New System.Windows.Forms.TextBox
       Me.etiquetarandom = New System.Windows.Forms.Label
       Me.chkcompletado = New System.Windows.Forms.CheckBox
       Me.etiquetacompletado = New System.Windows.Forms.Label
       Me.chkcompletado_pm = New System.Windows.Forms.CheckBox
       Me.etiquetacompletado_pm = New System.Windows.Forms.Label
       Me.chkcontrol1 = New System.Windows.Forms.CheckBox
       Me.etiquetacontrol1 = New System.Windows.Forms.Label
       Me.chkcontrol2 = New System.Windows.Forms.CheckBox
       Me.etiquetacontrol2 = New System.Windows.Forms.Label
       Me.chkcontrol3 = New System.Windows.Forms.CheckBox
       Me.etiquetacontrol3 = New System.Windows.Forms.Label
       Me.chkpedido_segundo_control = New System.Windows.Forms.CheckBox
       Me.etiquetapedido_segundo_control = New System.Windows.Forms.Label
       Me.txtnumero_revision = New System.Windows.Forms.TextBox
       Me.etiquetanumero_revision = New System.Windows.Forms.Label
       Me.chkcorresponde = New System.Windows.Forms.CheckBox
       Me.etiquetacorresponde = New System.Windows.Forms.Label
       Me.SuspendLayout()
       '
       'lblid_voz
       '
       Me.lblid_voz.AutoSize = True
       Me.lblid_voz.BackColor = System.Drawing.Color.Red
       Me.lblid_voz.Location = New System.Drawing.Point(370, 48)
       Me.lblid_voz.Name = "lblid_voz"
       Me.lblid_voz.Size = New System.Drawing.Size(13, 13)
       Me.lblid_voz.TabIndex = 500
       Me.lblid_voz.Text = "0"
       Me.lblid_voz.Visible = False
       '
       'btnBuscavoz
       '
       Me.btnBuscavoz.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscavoz.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscavoz.Location = New System.Drawing.Point(505, 48)
       Me.btnBuscavoz.Name = "btnBuscavoz"
       Me.btnBuscavoz.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscavoz.TabIndex = 60
       Me.btnBuscavoz.UseVisualStyleBackColor = True
       '
       'cmbvoz
       '
       Me.cmbvoz.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbvoz.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbvoz.FormattingEnabled = True
       Me.cmbvoz.Location = New System.Drawing.Point(161, 48)
       Me.cmbvoz.Size = New System.Drawing.Size(329, 21)
       Me.cmbvoz.Name = "cmbvoz"
       Me.cmbvoz.TabIndex = 4
       '
       'etiquietaid_voz
       '
       Me.etiquetaid_voz.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_voz.AutoSize = True
       Me.etiquetaid_voz.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_voz.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_voz.Location = New System.Drawing.Point(28, 48)
       Me.etiquetaid_voz.Name = "etiquetaid_voz"
       Me.etiquetaid_voz.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_voz.TabIndex = 501
       Me.etiquetaid_voz.Text = "Voz"
       Me.etiquetaid_voz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'chknc1
       '
       Me.chknc1.AutoSize = True
       Me.chknc1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.chknc1.Location = New System.Drawing.Point(161, 91)
       Me.chknc1.Name = "etiquetanc1"
       Me.chknc1.Size = New System.Drawing.Size(15, 14)
       Me.chknc1.TabIndex = 5
       Me.chknc1.Text = "nc1"
       Me.chknc1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       'etiquietanc1
       '
       Me.etiquetanc1.BackColor = System.Drawing.Color.Transparent
       Me.etiquetanc1.AutoSize = True
       Me.etiquetanc1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetanc1.ForeColor = System.Drawing.Color.Black
       Me.etiquetanc1.Location = New System.Drawing.Point(28, 91)
       Me.etiquetanc1.Name = "etiquetanc1"
       Me.etiquetanc1.Size = New System.Drawing.Size(127, 21)
       Me.etiquetanc1.TabIndex = 502
       Me.etiquetanc1.Text = "Nc1"
       Me.etiquetanc1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'chkok1
       '
       Me.chkok1.AutoSize = True
       Me.chkok1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.chkok1.Location = New System.Drawing.Point(161, 134)
       Me.chkok1.Name = "etiquetaok1"
       Me.chkok1.Size = New System.Drawing.Size(15, 14)
       Me.chkok1.TabIndex = 6
       Me.chkok1.Text = "ok1"
       Me.chkok1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       'etiquietaok1
       '
       Me.etiquetaok1.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaok1.AutoSize = True
       Me.etiquetaok1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaok1.ForeColor = System.Drawing.Color.Black
       Me.etiquetaok1.Location = New System.Drawing.Point(28, 134)
       Me.etiquetaok1.Name = "etiquetaok1"
       Me.etiquetaok1.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaok1.TabIndex = 503
       Me.etiquetaok1.Text = "Ok1"
       Me.etiquetaok1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'chkcorresponde1
       '
       Me.chkcorresponde1.AutoSize = True
       Me.chkcorresponde1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.chkcorresponde1.Location = New System.Drawing.Point(161, 177)
       Me.chkcorresponde1.Name = "etiquetacorresponde1"
       Me.chkcorresponde1.Size = New System.Drawing.Size(15, 14)
       Me.chkcorresponde1.TabIndex = 7
       Me.chkcorresponde1.Text = "corresponde1"
       Me.chkcorresponde1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       'etiquietacorresponde1
       '
       Me.etiquetacorresponde1.BackColor = System.Drawing.Color.Transparent
       Me.etiquetacorresponde1.AutoSize = True
       Me.etiquetacorresponde1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetacorresponde1.ForeColor = System.Drawing.Color.Black
       Me.etiquetacorresponde1.Location = New System.Drawing.Point(28, 177)
       Me.etiquetacorresponde1.Name = "etiquetacorresponde1"
       Me.etiquetacorresponde1.Size = New System.Drawing.Size(127, 21)
       Me.etiquetacorresponde1.TabIndex = 504
       Me.etiquetacorresponde1.Text = "Corresponde1"
       Me.etiquetacorresponde1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'chkconforme1
       '
       Me.chkconforme1.AutoSize = True
       Me.chkconforme1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.chkconforme1.Location = New System.Drawing.Point(161, 220)
       Me.chkconforme1.Name = "etiquetaconforme1"
       Me.chkconforme1.Size = New System.Drawing.Size(15, 14)
       Me.chkconforme1.TabIndex = 8
       Me.chkconforme1.Text = "conforme1"
       Me.chkconforme1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       'etiquietaconforme1
       '
       Me.etiquetaconforme1.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaconforme1.AutoSize = True
       Me.etiquetaconforme1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaconforme1.ForeColor = System.Drawing.Color.Black
       Me.etiquetaconforme1.Location = New System.Drawing.Point(28, 220)
       Me.etiquetaconforme1.Name = "etiquetaconforme1"
       Me.etiquetaconforme1.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaconforme1.TabIndex = 505
       Me.etiquetaconforme1.Text = "Conforme1"
       Me.etiquetaconforme1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'chkno_conforme1
       '
       Me.chkno_conforme1.AutoSize = True
       Me.chkno_conforme1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.chkno_conforme1.Location = New System.Drawing.Point(161, 263)
       Me.chkno_conforme1.Name = "etiquetano_conforme1"
       Me.chkno_conforme1.Size = New System.Drawing.Size(15, 14)
       Me.chkno_conforme1.TabIndex = 9
       Me.chkno_conforme1.Text = "no_conforme1"
       Me.chkno_conforme1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       'etiquietano_conforme1
       '
       Me.etiquetano_conforme1.BackColor = System.Drawing.Color.Transparent
       Me.etiquetano_conforme1.AutoSize = True
       Me.etiquetano_conforme1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetano_conforme1.ForeColor = System.Drawing.Color.Black
       Me.etiquetano_conforme1.Location = New System.Drawing.Point(28, 263)
       Me.etiquetano_conforme1.Name = "etiquetano_conforme1"
       Me.etiquetano_conforme1.Size = New System.Drawing.Size(127, 21)
       Me.etiquetano_conforme1.TabIndex = 506
       Me.etiquetano_conforme1.Text = "No conforme1"
       Me.etiquetano_conforme1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txttipo1
       '
       Me.txttipo1.BackColor = System.Drawing.Color.White
       Me.txttipo1.Location = New System.Drawing.Point(161, 306)
       Me.txttipo1.Size = New System.Drawing.Size(385, 20)
       Me.txttipo1.MaxLength = 50
       Me.txttipo1.Name = "txttipo1"
       Me.txttipo1.TabIndex = 10
       '
       'etiquietatipo1
       '
       Me.etiquetatipo1.BackColor = System.Drawing.Color.Transparent
       Me.etiquetatipo1.AutoSize = True
       Me.etiquetatipo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetatipo1.ForeColor = System.Drawing.Color.Black
       Me.etiquetatipo1.Location = New System.Drawing.Point(28, 306)
       Me.etiquetatipo1.Name = "etiquetatipo1"
       Me.etiquetatipo1.Size = New System.Drawing.Size(127, 21)
       Me.etiquetatipo1.TabIndex = 507
       Me.etiquetatipo1.Text = "Tipo1"
       Me.etiquetatipo1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtdetalle1
       '
       Me.txtdetalle1.BackColor = System.Drawing.Color.White
       Me.txtdetalle1.Location = New System.Drawing.Point(161, 349)
       Me.txtdetalle1.Size = New System.Drawing.Size(385, 20)
       Me.txtdetalle1.MaxLength = 5000
       Me.txtdetalle1.Name = "txtdetalle1"
       Me.txtdetalle1.TabIndex = 11
       '
       'etiquietadetalle1
       '
       Me.etiquetadetalle1.BackColor = System.Drawing.Color.Transparent
       Me.etiquetadetalle1.AutoSize = True
       Me.etiquetadetalle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetadetalle1.ForeColor = System.Drawing.Color.Black
       Me.etiquetadetalle1.Location = New System.Drawing.Point(28, 349)
       Me.etiquetadetalle1.Name = "etiquetadetalle1"
       Me.etiquetadetalle1.Size = New System.Drawing.Size(127, 21)
       Me.etiquetadetalle1.TabIndex = 508
       Me.etiquetadetalle1.Text = "Detalle1"
       Me.etiquetadetalle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'chkcorreccion1
       '
       Me.chkcorreccion1.AutoSize = True
       Me.chkcorreccion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.chkcorreccion1.Location = New System.Drawing.Point(161, 392)
       Me.chkcorreccion1.Name = "etiquetacorreccion1"
       Me.chkcorreccion1.Size = New System.Drawing.Size(15, 14)
       Me.chkcorreccion1.TabIndex = 12
       Me.chkcorreccion1.Text = "correccion1"
       Me.chkcorreccion1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       'etiquietacorreccion1
       '
       Me.etiquetacorreccion1.BackColor = System.Drawing.Color.Transparent
       Me.etiquetacorreccion1.AutoSize = True
       Me.etiquetacorreccion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetacorreccion1.ForeColor = System.Drawing.Color.Black
       Me.etiquetacorreccion1.Location = New System.Drawing.Point(28, 392)
       Me.etiquetacorreccion1.Name = "etiquetacorreccion1"
       Me.etiquetacorreccion1.Size = New System.Drawing.Size(127, 21)
       Me.etiquetacorreccion1.TabIndex = 509
       Me.etiquetacorreccion1.Text = "Correccion1"
       Me.etiquetacorreccion1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblid_movimiento_voz
       '
       Me.lblid_movimiento_voz.AutoSize = True
       Me.lblid_movimiento_voz.BackColor = System.Drawing.Color.Red
       Me.lblid_movimiento_voz.Location = New System.Drawing.Point(370, 435)
       Me.lblid_movimiento_voz.Name = "lblid_movimiento_voz"
       Me.lblid_movimiento_voz.Size = New System.Drawing.Size(13, 13)
       Me.lblid_movimiento_voz.TabIndex = 510
       Me.lblid_movimiento_voz.Text = "0"
       Me.lblid_movimiento_voz.Visible = False
       '
       'btnBuscamovimiento_voz
       '
       Me.btnBuscamovimiento_voz.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscamovimiento_voz.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscamovimiento_voz.Location = New System.Drawing.Point(505, 435)
       Me.btnBuscamovimiento_voz.Name = "btnBuscamovimiento_voz"
       Me.btnBuscamovimiento_voz.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscamovimiento_voz.TabIndex = 61
       Me.btnBuscamovimiento_voz.UseVisualStyleBackColor = True
       '
       'cmbmovimiento_voz
       '
       Me.cmbmovimiento_voz.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbmovimiento_voz.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbmovimiento_voz.FormattingEnabled = True
       Me.cmbmovimiento_voz.Location = New System.Drawing.Point(161, 435)
       Me.cmbmovimiento_voz.Size = New System.Drawing.Size(329, 21)
       Me.cmbmovimiento_voz.Name = "cmbmovimiento_voz"
       Me.cmbmovimiento_voz.TabIndex = 13
       '
       'etiquietaid_movimiento_voz
       '
       Me.etiquetaid_movimiento_voz.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_movimiento_voz.AutoSize = True
       Me.etiquetaid_movimiento_voz.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_movimiento_voz.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_movimiento_voz.Location = New System.Drawing.Point(28, 435)
       Me.etiquetaid_movimiento_voz.Name = "etiquetaid_movimiento_voz"
       Me.etiquetaid_movimiento_voz.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_movimiento_voz.TabIndex = 511
       Me.etiquetaid_movimiento_voz.Text = "Movimiento voz"
       Me.etiquetaid_movimiento_voz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'lblid_usuario
       '
       Me.lblid_usuario.AutoSize = True
       Me.lblid_usuario.BackColor = System.Drawing.Color.Red
       Me.lblid_usuario.Location = New System.Drawing.Point(370, 478)
       Me.lblid_usuario.Name = "lblid_usuario"
       Me.lblid_usuario.Size = New System.Drawing.Size(13, 13)
       Me.lblid_usuario.TabIndex = 512
       Me.lblid_usuario.Text = "0"
       Me.lblid_usuario.Visible = False
       '
       'btnBuscausuario
       '
       Me.btnBuscausuario.Cursor = System.Windows.Forms.Cursors.Hand
       Me.btnBuscausuario.Image = CType(Resources.GetObject("btnBuscarChico.Image"), System.Drawing.Image)
       Me.btnBuscausuario.Location = New System.Drawing.Point(505, 478)
       Me.btnBuscausuario.Name = "btnBuscausuario"
       Me.btnBuscausuario.Size = New System.Drawing.Size(30, 21)
       Me.btnBuscausuario.TabIndex = 62
       Me.btnBuscausuario.UseVisualStyleBackColor = True
       '
       'cmbusuario
       '
       Me.cmbusuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
       Me.cmbusuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
       Me.cmbusuario.FormattingEnabled = True
       Me.cmbusuario.Location = New System.Drawing.Point(161, 478)
       Me.cmbusuario.Size = New System.Drawing.Size(329, 21)
       Me.cmbusuario.Name = "cmbusuario"
       Me.cmbusuario.TabIndex = 14
       '
       'etiquietaid_usuario
       '
       Me.etiquetaid_usuario.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaid_usuario.AutoSize = True
       Me.etiquetaid_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaid_usuario.ForeColor = System.Drawing.Color.Black
       Me.etiquetaid_usuario.Location = New System.Drawing.Point(28, 478)
       Me.etiquetaid_usuario.Name = "etiquetaid_usuario"
       Me.etiquetaid_usuario.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaid_usuario.TabIndex = 513
       Me.etiquetaid_usuario.Text = "Usuario"
       Me.etiquetaid_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'chkcorresponde2
       '
       Me.chkcorresponde2.AutoSize = True
       Me.chkcorresponde2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.chkcorresponde2.Location = New System.Drawing.Point(161, 521)
       Me.chkcorresponde2.Name = "etiquetacorresponde2"
       Me.chkcorresponde2.Size = New System.Drawing.Size(15, 14)
       Me.chkcorresponde2.TabIndex = 15
       Me.chkcorresponde2.Text = "corresponde2"
       Me.chkcorresponde2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       'etiquietacorresponde2
       '
       Me.etiquetacorresponde2.BackColor = System.Drawing.Color.Transparent
       Me.etiquetacorresponde2.AutoSize = True
       Me.etiquetacorresponde2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetacorresponde2.ForeColor = System.Drawing.Color.Black
       Me.etiquetacorresponde2.Location = New System.Drawing.Point(28, 521)
       Me.etiquetacorresponde2.Name = "etiquetacorresponde2"
       Me.etiquetacorresponde2.Size = New System.Drawing.Size(127, 21)
       Me.etiquetacorresponde2.TabIndex = 514
       Me.etiquetacorresponde2.Text = "Corresponde2"
       Me.etiquetacorresponde2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'chkconforme2
       '
       Me.chkconforme2.AutoSize = True
       Me.chkconforme2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.chkconforme2.Location = New System.Drawing.Point(161, 564)
       Me.chkconforme2.Name = "etiquetaconforme2"
       Me.chkconforme2.Size = New System.Drawing.Size(15, 14)
       Me.chkconforme2.TabIndex = 16
       Me.chkconforme2.Text = "conforme2"
       Me.chkconforme2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       'etiquietaconforme2
       '
       Me.etiquetaconforme2.BackColor = System.Drawing.Color.Transparent
       Me.etiquetaconforme2.AutoSize = True
       Me.etiquetaconforme2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetaconforme2.ForeColor = System.Drawing.Color.Black
       Me.etiquetaconforme2.Location = New System.Drawing.Point(28, 564)
       Me.etiquetaconforme2.Name = "etiquetaconforme2"
       Me.etiquetaconforme2.Size = New System.Drawing.Size(127, 21)
       Me.etiquetaconforme2.TabIndex = 515
       Me.etiquetaconforme2.Text = "Conforme2"
       Me.etiquetaconforme2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'chkno_conforme2
       '
       Me.chkno_conforme2.AutoSize = True
       Me.chkno_conforme2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.chkno_conforme2.Location = New System.Drawing.Point(656, 48)
       Me.chkno_conforme2.Name = "etiquetano_conforme2"
       Me.chkno_conforme2.Size = New System.Drawing.Size(15, 14)
       Me.chkno_conforme2.TabIndex = 17
       Me.chkno_conforme2.Text = "no_conforme2"
       Me.chkno_conforme2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       'etiquietano_conforme2
       '
       Me.etiquetano_conforme2.BackColor = System.Drawing.Color.Transparent
       Me.etiquetano_conforme2.AutoSize = True
       Me.etiquetano_conforme2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetano_conforme2.ForeColor = System.Drawing.Color.Black
       Me.etiquetano_conforme2.Location = New System.Drawing.Point(583, 48)
       Me.etiquetano_conforme2.Name = "etiquetano_conforme2"
       Me.etiquetano_conforme2.Size = New System.Drawing.Size(127, 21)
       Me.etiquetano_conforme2.TabIndex = 516
       Me.etiquetano_conforme2.Text = "No conforme2"
       Me.etiquetano_conforme2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txttipo2
       '
       Me.txttipo2.BackColor = System.Drawing.Color.White
       Me.txttipo2.Location = New System.Drawing.Point(656, 91)
       Me.txttipo2.Size = New System.Drawing.Size(330, 20)
       Me.txttipo2.MaxLength = 50
       Me.txttipo2.Name = "txttipo2"
       Me.txttipo2.TabIndex = 18
       '
       'etiquietatipo2
       '
       Me.etiquetatipo2.BackColor = System.Drawing.Color.Transparent
       Me.etiquetatipo2.AutoSize = True
       Me.etiquetatipo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetatipo2.ForeColor = System.Drawing.Color.Black
       Me.etiquetatipo2.Location = New System.Drawing.Point(583, 91)
       Me.etiquetatipo2.Name = "etiquetatipo2"
       Me.etiquetatipo2.Size = New System.Drawing.Size(127, 21)
       Me.etiquetatipo2.TabIndex = 517
       Me.etiquetatipo2.Text = "Tipo2"
       Me.etiquetatipo2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtdetalle2
       '
       Me.txtdetalle2.BackColor = System.Drawing.Color.White
       Me.txtdetalle2.Location = New System.Drawing.Point(656, 134)
       Me.txtdetalle2.Size = New System.Drawing.Size(330, 20)
       Me.txtdetalle2.MaxLength = 5000
       Me.txtdetalle2.Name = "txtdetalle2"
       Me.txtdetalle2.TabIndex = 19
       '
       'etiquietadetalle2
       '
       Me.etiquetadetalle2.BackColor = System.Drawing.Color.Transparent
       Me.etiquetadetalle2.AutoSize = True
       Me.etiquetadetalle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetadetalle2.ForeColor = System.Drawing.Color.Black
       Me.etiquetadetalle2.Location = New System.Drawing.Point(583, 134)
       Me.etiquetadetalle2.Name = "etiquetadetalle2"
       Me.etiquetadetalle2.Size = New System.Drawing.Size(127, 21)
       Me.etiquetadetalle2.TabIndex = 518
       Me.etiquetadetalle2.Text = "Detalle2"
       Me.etiquetadetalle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'chkcorreccion2
       '
       Me.chkcorreccion2.AutoSize = True
       Me.chkcorreccion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.chkcorreccion2.Location = New System.Drawing.Point(656, 177)
       Me.chkcorreccion2.Name = "etiquetacorreccion2"
       Me.chkcorreccion2.Size = New System.Drawing.Size(15, 14)
       Me.chkcorreccion2.TabIndex = 20
       Me.chkcorreccion2.Text = "correccion2"
       Me.chkcorreccion2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       'etiquietacorreccion2
       '
       Me.etiquetacorreccion2.BackColor = System.Drawing.Color.Transparent
       Me.etiquetacorreccion2.AutoSize = True
       Me.etiquetacorreccion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetacorreccion2.ForeColor = System.Drawing.Color.Black
       Me.etiquetacorreccion2.Location = New System.Drawing.Point(583, 177)
       Me.etiquetacorreccion2.Name = "etiquetacorreccion2"
       Me.etiquetacorreccion2.Size = New System.Drawing.Size(127, 21)
       Me.etiquetacorreccion2.TabIndex = 519
       Me.etiquetacorreccion2.Text = "Correccion2"
       Me.etiquetacorreccion2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtrandom
       '
       Me.txtrandom.BackColor = System.Drawing.Color.White
       Me.txtrandom.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtrandom.ForeColor = System.Drawing.Color.Blue
       Me.txtrandom.Location = New System.Drawing.Point(656, 220)
       Me.txtrandom.MaxLength = 50
       Me.txtrandom.Name = "txtrandom"
       Me.txtrandom.Size = New System.Drawing.Size(222, 31)
       Me.txtrandom.TabIndex = 21
       Me.txtrandom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietarandom
       '
       Me.etiquetarandom.BackColor = System.Drawing.Color.Transparent
       Me.etiquetarandom.AutoSize = True
       Me.etiquetarandom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetarandom.ForeColor = System.Drawing.Color.Black
       Me.etiquetarandom.Location = New System.Drawing.Point(583, 220)
       Me.etiquetarandom.Name = "etiquetarandom"
       Me.etiquetarandom.Size = New System.Drawing.Size(127, 21)
       Me.etiquetarandom.TabIndex = 520
       Me.etiquetarandom.Text = "Random"
       Me.etiquetarandom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'chkcompletado
       '
       Me.chkcompletado.AutoSize = True
       Me.chkcompletado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.chkcompletado.Location = New System.Drawing.Point(656, 273)
       Me.chkcompletado.Name = "etiquetacompletado"
       Me.chkcompletado.Size = New System.Drawing.Size(15, 14)
       Me.chkcompletado.TabIndex = 22
       Me.chkcompletado.Text = "completado"
       Me.chkcompletado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       'etiquietacompletado
       '
       Me.etiquetacompletado.BackColor = System.Drawing.Color.Transparent
       Me.etiquetacompletado.AutoSize = True
       Me.etiquetacompletado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetacompletado.ForeColor = System.Drawing.Color.Black
       Me.etiquetacompletado.Location = New System.Drawing.Point(583, 273)
       Me.etiquetacompletado.Name = "etiquetacompletado"
       Me.etiquetacompletado.Size = New System.Drawing.Size(127, 21)
       Me.etiquetacompletado.TabIndex = 521
       Me.etiquetacompletado.Text = "Completado"
       Me.etiquetacompletado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'chkcompletado_pm
       '
       Me.chkcompletado_pm.AutoSize = True
       Me.chkcompletado_pm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.chkcompletado_pm.Location = New System.Drawing.Point(656, 316)
       Me.chkcompletado_pm.Name = "etiquetacompletado_pm"
       Me.chkcompletado_pm.Size = New System.Drawing.Size(15, 14)
       Me.chkcompletado_pm.TabIndex = 23
       Me.chkcompletado_pm.Text = "completado_pm"
       Me.chkcompletado_pm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       'etiquietacompletado_pm
       '
       Me.etiquetacompletado_pm.BackColor = System.Drawing.Color.Transparent
       Me.etiquetacompletado_pm.AutoSize = True
       Me.etiquetacompletado_pm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetacompletado_pm.ForeColor = System.Drawing.Color.Black
       Me.etiquetacompletado_pm.Location = New System.Drawing.Point(583, 316)
       Me.etiquetacompletado_pm.Name = "etiquetacompletado_pm"
       Me.etiquetacompletado_pm.Size = New System.Drawing.Size(127, 21)
       Me.etiquetacompletado_pm.TabIndex = 522
       Me.etiquetacompletado_pm.Text = "Completado pm"
       Me.etiquetacompletado_pm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'chkcontrol1
       '
       Me.chkcontrol1.AutoSize = True
       Me.chkcontrol1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.chkcontrol1.Location = New System.Drawing.Point(656, 359)
       Me.chkcontrol1.Name = "etiquetacontrol1"
       Me.chkcontrol1.Size = New System.Drawing.Size(15, 14)
       Me.chkcontrol1.TabIndex = 24
       Me.chkcontrol1.Text = "control1"
       Me.chkcontrol1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       'etiquietacontrol1
       '
       Me.etiquetacontrol1.BackColor = System.Drawing.Color.Transparent
       Me.etiquetacontrol1.AutoSize = True
       Me.etiquetacontrol1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetacontrol1.ForeColor = System.Drawing.Color.Black
       Me.etiquetacontrol1.Location = New System.Drawing.Point(583, 359)
       Me.etiquetacontrol1.Name = "etiquetacontrol1"
       Me.etiquetacontrol1.Size = New System.Drawing.Size(127, 21)
       Me.etiquetacontrol1.TabIndex = 523
       Me.etiquetacontrol1.Text = "Control1"
       Me.etiquetacontrol1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'chkcontrol2
       '
       Me.chkcontrol2.AutoSize = True
       Me.chkcontrol2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.chkcontrol2.Location = New System.Drawing.Point(656, 402)
       Me.chkcontrol2.Name = "etiquetacontrol2"
       Me.chkcontrol2.Size = New System.Drawing.Size(15, 14)
       Me.chkcontrol2.TabIndex = 25
       Me.chkcontrol2.Text = "control2"
       Me.chkcontrol2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       'etiquietacontrol2
       '
       Me.etiquetacontrol2.BackColor = System.Drawing.Color.Transparent
       Me.etiquetacontrol2.AutoSize = True
       Me.etiquetacontrol2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetacontrol2.ForeColor = System.Drawing.Color.Black
       Me.etiquetacontrol2.Location = New System.Drawing.Point(583, 402)
       Me.etiquetacontrol2.Name = "etiquetacontrol2"
       Me.etiquetacontrol2.Size = New System.Drawing.Size(127, 21)
       Me.etiquetacontrol2.TabIndex = 524
       Me.etiquetacontrol2.Text = "Control2"
       Me.etiquetacontrol2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'chkcontrol3
       '
       Me.chkcontrol3.AutoSize = True
       Me.chkcontrol3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.chkcontrol3.Location = New System.Drawing.Point(656, 445)
       Me.chkcontrol3.Name = "etiquetacontrol3"
       Me.chkcontrol3.Size = New System.Drawing.Size(15, 14)
       Me.chkcontrol3.TabIndex = 26
       Me.chkcontrol3.Text = "control3"
       Me.chkcontrol3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       'etiquietacontrol3
       '
       Me.etiquetacontrol3.BackColor = System.Drawing.Color.Transparent
       Me.etiquetacontrol3.AutoSize = True
       Me.etiquetacontrol3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetacontrol3.ForeColor = System.Drawing.Color.Black
       Me.etiquetacontrol3.Location = New System.Drawing.Point(583, 445)
       Me.etiquetacontrol3.Name = "etiquetacontrol3"
       Me.etiquetacontrol3.Size = New System.Drawing.Size(127, 21)
       Me.etiquetacontrol3.TabIndex = 525
       Me.etiquetacontrol3.Text = "Control3"
       Me.etiquetacontrol3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'chkpedido_segundo_control
       '
       Me.chkpedido_segundo_control.AutoSize = True
       Me.chkpedido_segundo_control.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.chkpedido_segundo_control.Location = New System.Drawing.Point(656, 488)
       Me.chkpedido_segundo_control.Name = "etiquetapedido_segundo_control"
       Me.chkpedido_segundo_control.Size = New System.Drawing.Size(15, 14)
       Me.chkpedido_segundo_control.TabIndex = 27
       Me.chkpedido_segundo_control.Text = "pedido_segundo_control"
       Me.chkpedido_segundo_control.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       'etiquietapedido_segundo_control
       '
       Me.etiquetapedido_segundo_control.BackColor = System.Drawing.Color.Transparent
       Me.etiquetapedido_segundo_control.AutoSize = True
       Me.etiquetapedido_segundo_control.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetapedido_segundo_control.ForeColor = System.Drawing.Color.Black
       Me.etiquetapedido_segundo_control.Location = New System.Drawing.Point(583, 488)
       Me.etiquetapedido_segundo_control.Name = "etiquetapedido_segundo_control"
       Me.etiquetapedido_segundo_control.Size = New System.Drawing.Size(127, 21)
       Me.etiquetapedido_segundo_control.TabIndex = 526
       Me.etiquetapedido_segundo_control.Text = "Pedido segundo control"
       Me.etiquetapedido_segundo_control.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'txtnumero_revision
       '
       Me.txtnumero_revision.BackColor = System.Drawing.Color.White
       Me.txtnumero_revision.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.txtnumero_revision.ForeColor = System.Drawing.Color.Blue
       Me.txtnumero_revision.Location = New System.Drawing.Point(656, 531)
       Me.txtnumero_revision.MaxLength = 50
       Me.txtnumero_revision.Name = "txtnumero_revision"
       Me.txtnumero_revision.Size = New System.Drawing.Size(222, 31)
       Me.txtnumero_revision.TabIndex = 28
       Me.txtnumero_revision.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
       '
       'etiquietanumero_revision
       '
       Me.etiquetanumero_revision.BackColor = System.Drawing.Color.Transparent
       Me.etiquetanumero_revision.AutoSize = True
       Me.etiquetanumero_revision.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetanumero_revision.ForeColor = System.Drawing.Color.Black
       Me.etiquetanumero_revision.Location = New System.Drawing.Point(583, 531)
       Me.etiquetanumero_revision.Name = "etiquetanumero_revision"
       Me.etiquetanumero_revision.Size = New System.Drawing.Size(127, 21)
       Me.etiquetanumero_revision.TabIndex = 527
       Me.etiquetanumero_revision.Text = "Numero revision"
       Me.etiquetanumero_revision.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       '
       'chkcorresponde
       '
       Me.chkcorresponde.AutoSize = True
       Me.chkcorresponde.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.chkcorresponde.Location = New System.Drawing.Point(1000, 48)
       Me.chkcorresponde.Name = "etiquetacorresponde"
       Me.chkcorresponde.Size = New System.Drawing.Size(15, 14)
       Me.chkcorresponde.TabIndex = 29
       Me.chkcorresponde.Text = "corresponde"
       Me.chkcorresponde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
       '
       'etiquietacorresponde
       '
       Me.etiquetacorresponde.BackColor = System.Drawing.Color.Transparent
       Me.etiquetacorresponde.AutoSize = True
       Me.etiquetacorresponde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
       Me.etiquetacorresponde.ForeColor = System.Drawing.Color.Black
       Me.etiquetacorresponde.Location = New System.Drawing.Point(1000, 48)
       Me.etiquetacorresponde.Name = "etiquetacorresponde"
       Me.etiquetacorresponde.Size = New System.Drawing.Size(127, 21)
       Me.etiquetacorresponde.TabIndex = 528
       Me.etiquetacorresponde.Text = "Corresponde"
       Me.etiquetacorresponde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
       Me.GroupBox1.Size = New System.Drawing.Size(1420, 606)
       Me.GroupBox1.TabIndex = 0
       Me.GroupBox1.TabStop = False
       '
       'frmDetalleCuerpo_movimiento_voz
       '
       Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
       Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
       Me.ClientSize = New System.Drawing.Size(1500, 768)
       Me.Controls.Add(Me.lblid_voz)
       Me.Controls.Add(Me.btnBuscavoz)
       Me.Controls.Add(Me.cmbvoz)
       Me.Controls.Add(Me.etiquetaid_voz)
       Me.Controls.Add(Me.chknc1)
       Me.Controls.Add(Me.etiquetanc1)
       Me.Controls.Add(Me.chkok1)
       Me.Controls.Add(Me.etiquetaok1)
       Me.Controls.Add(Me.chkcorresponde1)
       Me.Controls.Add(Me.etiquetacorresponde1)
       Me.Controls.Add(Me.chkconforme1)
       Me.Controls.Add(Me.etiquetaconforme1)
       Me.Controls.Add(Me.chkno_conforme1)
       Me.Controls.Add(Me.etiquetano_conforme1)
       Me.Controls.Add(Me.txttipo1)
       Me.Controls.Add(Me.etiquetatipo1)
       Me.Controls.Add(Me.txtdetalle1)
       Me.Controls.Add(Me.etiquetadetalle1)
       Me.Controls.Add(Me.chkcorreccion1)
       Me.Controls.Add(Me.etiquetacorreccion1)
       Me.Controls.Add(Me.lblid_movimiento_voz)
       Me.Controls.Add(Me.btnBuscamovimiento_voz)
       Me.Controls.Add(Me.cmbmovimiento_voz)
       Me.Controls.Add(Me.etiquetaid_movimiento_voz)
       Me.Controls.Add(Me.lblid_usuario)
       Me.Controls.Add(Me.btnBuscausuario)
       Me.Controls.Add(Me.cmbusuario)
       Me.Controls.Add(Me.etiquetaid_usuario)
       Me.Controls.Add(Me.chkcorresponde2)
       Me.Controls.Add(Me.etiquetacorresponde2)
       Me.Controls.Add(Me.chkconforme2)
       Me.Controls.Add(Me.etiquetaconforme2)
       Me.Controls.Add(Me.chkno_conforme2)
       Me.Controls.Add(Me.etiquetano_conforme2)
       Me.Controls.Add(Me.txttipo2)
       Me.Controls.Add(Me.etiquetatipo2)
       Me.Controls.Add(Me.txtdetalle2)
       Me.Controls.Add(Me.etiquetadetalle2)
       Me.Controls.Add(Me.chkcorreccion2)
       Me.Controls.Add(Me.etiquetacorreccion2)
       Me.Controls.Add(Me.txtrandom)
       Me.Controls.Add(Me.etiquetarandom)
       Me.Controls.Add(Me.chkcompletado)
       Me.Controls.Add(Me.etiquetacompletado)
       Me.Controls.Add(Me.chkcompletado_pm)
       Me.Controls.Add(Me.etiquetacompletado_pm)
       Me.Controls.Add(Me.chkcontrol1)
       Me.Controls.Add(Me.etiquetacontrol1)
       Me.Controls.Add(Me.chkcontrol2)
       Me.Controls.Add(Me.etiquetacontrol2)
       Me.Controls.Add(Me.chkcontrol3)
       Me.Controls.Add(Me.etiquetacontrol3)
       Me.Controls.Add(Me.chkpedido_segundo_control)
       Me.Controls.Add(Me.etiquetapedido_segundo_control)
       Me.Controls.Add(Me.txtnumero_revision)
       Me.Controls.Add(Me.etiquetanumero_revision)
       Me.Controls.Add(Me.chkcorresponde)
       Me.Controls.Add(Me.etiquetacorresponde)
       Me.Controls.Add(Me.btnSalir)
       Me.Controls.Add(Me.btnGuardar)
       Me.Controls.Add(Me.GroupBox1)
       Me.Name = "frmDetalleCuerpo_movimiento_voz"
       Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
       Me.Text = "frmDetalleCuerpo_movimiento_voz" & vgNombreFormulario
       Me.ResumeLayout(False)
       Me.PerformLayout()

   End Sub
   Friend WithEvents lblid_voz As System.Windows.Forms.Label
   Friend WithEvents btnBuscavoz As System.Windows.Forms.Button
   Friend WithEvents cmbvoz As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_voz As System.Windows.Forms.Label
   Protected WithEvents chknc1 As System.Windows.Forms.CheckBox
   Friend WithEvents etiquetanc1 As System.Windows.Forms.Label
   Protected WithEvents chkok1 As System.Windows.Forms.CheckBox
   Friend WithEvents etiquetaok1 As System.Windows.Forms.Label
   Protected WithEvents chkcorresponde1 As System.Windows.Forms.CheckBox
   Friend WithEvents etiquetacorresponde1 As System.Windows.Forms.Label
   Protected WithEvents chkconforme1 As System.Windows.Forms.CheckBox
   Friend WithEvents etiquetaconforme1 As System.Windows.Forms.Label
   Protected WithEvents chkno_conforme1 As System.Windows.Forms.CheckBox
   Friend WithEvents etiquetano_conforme1 As System.Windows.Forms.Label
   Protected WithEvents txttipo1 As System.Windows.Forms.TextBox
   Friend WithEvents etiquetatipo1 As System.Windows.Forms.Label
   Protected WithEvents txtdetalle1 As System.Windows.Forms.TextBox
   Friend WithEvents etiquetadetalle1 As System.Windows.Forms.Label
   Protected WithEvents chkcorreccion1 As System.Windows.Forms.CheckBox
   Friend WithEvents etiquetacorreccion1 As System.Windows.Forms.Label
   Friend WithEvents lblid_movimiento_voz As System.Windows.Forms.Label
   Friend WithEvents btnBuscamovimiento_voz As System.Windows.Forms.Button
   Friend WithEvents cmbmovimiento_voz As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_movimiento_voz As System.Windows.Forms.Label
   Friend WithEvents lblid_usuario As System.Windows.Forms.Label
   Friend WithEvents btnBuscausuario As System.Windows.Forms.Button
   Friend WithEvents cmbusuario As System.Windows.Forms.ComboBox
   Friend WithEvents etiquetaid_usuario As System.Windows.Forms.Label
   Protected WithEvents chkcorresponde2 As System.Windows.Forms.CheckBox
   Friend WithEvents etiquetacorresponde2 As System.Windows.Forms.Label
   Protected WithEvents chkconforme2 As System.Windows.Forms.CheckBox
   Friend WithEvents etiquetaconforme2 As System.Windows.Forms.Label
   Protected WithEvents chkno_conforme2 As System.Windows.Forms.CheckBox
   Friend WithEvents etiquetano_conforme2 As System.Windows.Forms.Label
   Protected WithEvents txttipo2 As System.Windows.Forms.TextBox
   Friend WithEvents etiquetatipo2 As System.Windows.Forms.Label
   Protected WithEvents txtdetalle2 As System.Windows.Forms.TextBox
   Friend WithEvents etiquetadetalle2 As System.Windows.Forms.Label
   Protected WithEvents chkcorreccion2 As System.Windows.Forms.CheckBox
   Friend WithEvents etiquetacorreccion2 As System.Windows.Forms.Label
   Protected WithEvents txtrandom As System.Windows.Forms.TextBox
   Friend WithEvents etiquetarandom As System.Windows.Forms.Label
   Protected WithEvents chkcompletado As System.Windows.Forms.CheckBox
   Friend WithEvents etiquetacompletado As System.Windows.Forms.Label
   Protected WithEvents chkcompletado_pm As System.Windows.Forms.CheckBox
   Friend WithEvents etiquetacompletado_pm As System.Windows.Forms.Label
   Protected WithEvents chkcontrol1 As System.Windows.Forms.CheckBox
   Friend WithEvents etiquetacontrol1 As System.Windows.Forms.Label
   Protected WithEvents chkcontrol2 As System.Windows.Forms.CheckBox
   Friend WithEvents etiquetacontrol2 As System.Windows.Forms.Label
   Protected WithEvents chkcontrol3 As System.Windows.Forms.CheckBox
   Friend WithEvents etiquetacontrol3 As System.Windows.Forms.Label
   Protected WithEvents chkpedido_segundo_control As System.Windows.Forms.CheckBox
   Friend WithEvents etiquetapedido_segundo_control As System.Windows.Forms.Label
   Protected WithEvents txtnumero_revision As System.Windows.Forms.TextBox
   Friend WithEvents etiquetanumero_revision As System.Windows.Forms.Label
   Protected WithEvents chkcorresponde As System.Windows.Forms.CheckBox
   Friend WithEvents etiquetacorresponde As System.Windows.Forms.Label
   Protected WithEvents btnSalir As System.Windows.Forms.Button
   Protected WithEvents btnGuardar As System.Windows.Forms.Button
   Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Protected WithEvents ttGeneral As System.Windows.Forms.ToolTip
End Class

