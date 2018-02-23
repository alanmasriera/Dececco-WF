<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainControl
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainControl))
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.ctx_menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ts_agregar_control = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_modificar_control = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_borrar_control = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsOrdenarTiposDeVoz = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsOrdenCreacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsNombre = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_agregar_tv = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_modificar_tv = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_borrar_tv = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_porcentaje_tipo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ts_ordenar_voz = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_nombrevoz = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_creacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_agregar_voz = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_modificar_voz = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_borrar_voz = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_porcentaje = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_modificar_codigo_voz = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.txtnombre_control = New System.Windows.Forms.TextBox()
        Me.btnAbrir = New System.Windows.Forms.Button()
        Me.txtnombre_voz = New System.Windows.Forms.TextBox()
        Me.txticono = New System.Windows.Forms.TextBox()
        Me.lblid_control = New System.Windows.Forms.Label()
        Me.lblid_tipo_voz = New System.Windows.Forms.Label()
        Me.lblid_voz = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.etiquetanombre_voz = New System.Windows.Forms.Label()
        Me.etiquetaicono = New System.Windows.Forms.Label()
        Me.etiquetacodigo = New System.Windows.Forms.Label()
        Me.lblBanderaVoz = New System.Windows.Forms.Label()
        Me.lblBanderaTipo_voz = New System.Windows.Forms.Label()
        Me.lblBanderaControl = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtnombre_tipo_voz = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodigoTipo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtCodigo_2 = New System.Windows.Forms.TextBox()
        Me.lblY = New System.Windows.Forms.Label()
        Me.lblX = New System.Windows.Forms.Label()
        Me.ctx_menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.AllowDrop = True
        Me.TreeView1.ContextMenuStrip = Me.ctx_menu
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView1.ImageIndex = 0
        Me.TreeView1.ImageList = Me.ImageList1
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.SelectedImageIndex = 2
        Me.TreeView1.Size = New System.Drawing.Size(873, 730)
        Me.TreeView1.TabIndex = 0
        '
        'ctx_menu
        '
        Me.ctx_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_agregar_control, Me.ts_modificar_control, Me.ts_borrar_control, Me.ToolStripSeparator1, Me.tsOrdenarTiposDeVoz, Me.ts_agregar_tv, Me.ts_modificar_tv, Me.ts_borrar_tv, Me.ts_porcentaje_tipo, Me.ToolStripSeparator2, Me.ts_ordenar_voz, Me.ts_agregar_voz, Me.ts_modificar_voz, Me.ts_borrar_voz, Me.ts_porcentaje, Me.ts_modificar_codigo_voz})
        Me.ctx_menu.Name = "ctx_menu"
        Me.ctx_menu.Size = New System.Drawing.Size(244, 324)
        Me.ctx_menu.Text = "Administracion"
        '
        'ts_agregar_control
        '
        Me.ts_agregar_control.Name = "ts_agregar_control"
        Me.ts_agregar_control.Size = New System.Drawing.Size(243, 22)
        Me.ts_agregar_control.Text = "Agregar Nuevo Control"
        '
        'ts_modificar_control
        '
        Me.ts_modificar_control.Name = "ts_modificar_control"
        Me.ts_modificar_control.Size = New System.Drawing.Size(243, 22)
        Me.ts_modificar_control.Text = "Modificar Control"
        '
        'ts_borrar_control
        '
        Me.ts_borrar_control.Name = "ts_borrar_control"
        Me.ts_borrar_control.Size = New System.Drawing.Size(243, 22)
        Me.ts_borrar_control.Text = "Borrar Control"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(240, 6)
        '
        'tsOrdenarTiposDeVoz
        '
        Me.tsOrdenarTiposDeVoz.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsOrdenCreacion, Me.tsNombre})
        Me.tsOrdenarTiposDeVoz.Name = "tsOrdenarTiposDeVoz"
        Me.tsOrdenarTiposDeVoz.Size = New System.Drawing.Size(243, 22)
        Me.tsOrdenarTiposDeVoz.Text = "Ordenar Tipos de Voz"
        '
        'tsOrdenCreacion
        '
        Me.tsOrdenCreacion.Name = "tsOrdenCreacion"
        Me.tsOrdenCreacion.Size = New System.Drawing.Size(121, 22)
        Me.tsOrdenCreacion.Text = "Creacion"
        '
        'tsNombre
        '
        Me.tsNombre.Name = "tsNombre"
        Me.tsNombre.Size = New System.Drawing.Size(121, 22)
        Me.tsNombre.Text = "Nombre"
        '
        'ts_agregar_tv
        '
        Me.ts_agregar_tv.Name = "ts_agregar_tv"
        Me.ts_agregar_tv.Size = New System.Drawing.Size(243, 22)
        Me.ts_agregar_tv.Text = "Agregar Nuevo Tipo de Voz"
        '
        'ts_modificar_tv
        '
        Me.ts_modificar_tv.Name = "ts_modificar_tv"
        Me.ts_modificar_tv.Size = New System.Drawing.Size(243, 22)
        Me.ts_modificar_tv.Text = "Modificar Tipo de voz"
        '
        'ts_borrar_tv
        '
        Me.ts_borrar_tv.Name = "ts_borrar_tv"
        Me.ts_borrar_tv.Size = New System.Drawing.Size(243, 22)
        Me.ts_borrar_tv.Text = "Borrar Tipo de Voz"
        '
        'ts_porcentaje_tipo
        '
        Me.ts_porcentaje_tipo.Name = "ts_porcentaje_tipo"
        Me.ts_porcentaje_tipo.Size = New System.Drawing.Size(243, 22)
        Me.ts_porcentaje_tipo.Text = "Cambiar porcentaje de Tipo Voz"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(240, 6)
        '
        'ts_ordenar_voz
        '
        Me.ts_ordenar_voz.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_nombrevoz, Me.ts_creacion})
        Me.ts_ordenar_voz.Name = "ts_ordenar_voz"
        Me.ts_ordenar_voz.Size = New System.Drawing.Size(243, 22)
        Me.ts_ordenar_voz.Text = "Ordenar Voces"
        '
        'ts_nombrevoz
        '
        Me.ts_nombrevoz.Name = "ts_nombrevoz"
        Me.ts_nombrevoz.Size = New System.Drawing.Size(121, 22)
        Me.ts_nombrevoz.Text = "Nombre"
        '
        'ts_creacion
        '
        Me.ts_creacion.Name = "ts_creacion"
        Me.ts_creacion.Size = New System.Drawing.Size(121, 22)
        Me.ts_creacion.Text = "Creación"
        '
        'ts_agregar_voz
        '
        Me.ts_agregar_voz.Name = "ts_agregar_voz"
        Me.ts_agregar_voz.Size = New System.Drawing.Size(243, 22)
        Me.ts_agregar_voz.Text = "Agregar Nueva Voz"
        '
        'ts_modificar_voz
        '
        Me.ts_modificar_voz.Name = "ts_modificar_voz"
        Me.ts_modificar_voz.Size = New System.Drawing.Size(243, 22)
        Me.ts_modificar_voz.Text = "Modificar Voz"
        '
        'ts_borrar_voz
        '
        Me.ts_borrar_voz.Name = "ts_borrar_voz"
        Me.ts_borrar_voz.Size = New System.Drawing.Size(243, 22)
        Me.ts_borrar_voz.Text = "Borrar Voz"
        '
        'ts_porcentaje
        '
        Me.ts_porcentaje.Name = "ts_porcentaje"
        Me.ts_porcentaje.Size = New System.Drawing.Size(243, 22)
        Me.ts_porcentaje.Text = "Cambiar porcentaje"
        '
        'ts_modificar_codigo_voz
        '
        Me.ts_modificar_codigo_voz.Name = "ts_modificar_codigo_voz"
        Me.ts_modificar_codigo_voz.Size = New System.Drawing.Size(243, 22)
        Me.ts_modificar_codigo_voz.Text = "Cambiar Codigo de Voz"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "IconFolder.png")
        Me.ImageList1.Images.SetKeyName(1, "mini_file.png")
        Me.ImageList1.Images.SetKeyName(2, "bullet-check.png")
        Me.ImageList1.Images.SetKeyName(3, "icon_folder.png")
        '
        'txtnombre_control
        '
        Me.txtnombre_control.BackColor = System.Drawing.Color.White
        Me.txtnombre_control.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnombre_control.Location = New System.Drawing.Point(418, 40)
        Me.txtnombre_control.MaxLength = 500
        Me.txtnombre_control.Multiline = True
        Me.txtnombre_control.Name = "txtnombre_control"
        Me.txtnombre_control.Size = New System.Drawing.Size(432, 49)
        Me.txtnombre_control.TabIndex = 5
        Me.txtnombre_control.Visible = False
        '
        'btnAbrir
        '
        Me.btnAbrir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAbrir.Image = CType(resources.GetObject("btnAbrir.Image"), System.Drawing.Image)
        Me.btnAbrir.Location = New System.Drawing.Point(834, 337)
        Me.btnAbrir.Name = "btnAbrir"
        Me.btnAbrir.Size = New System.Drawing.Size(30, 21)
        Me.btnAbrir.TabIndex = 505
        Me.btnAbrir.UseVisualStyleBackColor = True
        Me.btnAbrir.Visible = False
        '
        'txtnombre_voz
        '
        Me.txtnombre_voz.BackColor = System.Drawing.Color.White
        Me.txtnombre_voz.Location = New System.Drawing.Point(433, 297)
        Me.txtnombre_voz.MaxLength = 500
        Me.txtnombre_voz.Name = "txtnombre_voz"
        Me.txtnombre_voz.Size = New System.Drawing.Size(435, 20)
        Me.txtnombre_voz.TabIndex = 503
        Me.txtnombre_voz.Visible = False
        '
        'txticono
        '
        Me.txticono.BackColor = System.Drawing.Color.White
        Me.txticono.Location = New System.Drawing.Point(433, 337)
        Me.txticono.MaxLength = 500
        Me.txticono.Name = "txticono"
        Me.txticono.Size = New System.Drawing.Size(389, 20)
        Me.txticono.TabIndex = 504
        Me.txticono.Visible = False
        '
        'lblid_control
        '
        Me.lblid_control.AutoSize = True
        Me.lblid_control.BackColor = System.Drawing.Color.Red
        Me.lblid_control.Location = New System.Drawing.Point(662, 456)
        Me.lblid_control.Name = "lblid_control"
        Me.lblid_control.Size = New System.Drawing.Size(13, 13)
        Me.lblid_control.TabIndex = 506
        Me.lblid_control.Text = "0"
        Me.lblid_control.Visible = False
        '
        'lblid_tipo_voz
        '
        Me.lblid_tipo_voz.AutoSize = True
        Me.lblid_tipo_voz.BackColor = System.Drawing.Color.Red
        Me.lblid_tipo_voz.Location = New System.Drawing.Point(681, 456)
        Me.lblid_tipo_voz.Name = "lblid_tipo_voz"
        Me.lblid_tipo_voz.Size = New System.Drawing.Size(13, 13)
        Me.lblid_tipo_voz.TabIndex = 507
        Me.lblid_tipo_voz.Text = "0"
        Me.lblid_tipo_voz.Visible = False
        '
        'lblid_voz
        '
        Me.lblid_voz.AutoSize = True
        Me.lblid_voz.BackColor = System.Drawing.Color.Red
        Me.lblid_voz.Location = New System.Drawing.Point(700, 456)
        Me.lblid_voz.Name = "lblid_voz"
        Me.lblid_voz.Size = New System.Drawing.Size(13, 13)
        Me.lblid_voz.TabIndex = 508
        Me.lblid_voz.Text = "0"
        Me.lblid_voz.Visible = False
        '
        'txtcodigo
        '
        Me.txtcodigo.BackColor = System.Drawing.Color.White
        Me.txtcodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodigo.Location = New System.Drawing.Point(433, 376)
        Me.txtcodigo.MaxLength = 50
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(31, 20)
        Me.txtcodigo.TabIndex = 509
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtcodigo.Visible = False
        '
        'etiquetanombre_voz
        '
        Me.etiquetanombre_voz.AutoSize = True
        Me.etiquetanombre_voz.BackColor = System.Drawing.Color.Gainsboro
        Me.etiquetanombre_voz.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetanombre_voz.ForeColor = System.Drawing.Color.Black
        Me.etiquetanombre_voz.Location = New System.Drawing.Point(430, 281)
        Me.etiquetanombre_voz.Name = "etiquetanombre_voz"
        Me.etiquetanombre_voz.Size = New System.Drawing.Size(67, 13)
        Me.etiquetanombre_voz.TabIndex = 510
        Me.etiquetanombre_voz.Text = "Nombre_voz"
        Me.etiquetanombre_voz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.etiquetanombre_voz.Visible = False
        '
        'etiquetaicono
        '
        Me.etiquetaicono.AutoSize = True
        Me.etiquetaicono.BackColor = System.Drawing.Color.Gainsboro
        Me.etiquetaicono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaicono.ForeColor = System.Drawing.Color.Black
        Me.etiquetaicono.Location = New System.Drawing.Point(430, 321)
        Me.etiquetaicono.Name = "etiquetaicono"
        Me.etiquetaicono.Size = New System.Drawing.Size(34, 13)
        Me.etiquetaicono.TabIndex = 511
        Me.etiquetaicono.Text = "Icono"
        Me.etiquetaicono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.etiquetaicono.Visible = False
        '
        'etiquetacodigo
        '
        Me.etiquetacodigo.AutoSize = True
        Me.etiquetacodigo.BackColor = System.Drawing.Color.Gainsboro
        Me.etiquetacodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetacodigo.ForeColor = System.Drawing.Color.Black
        Me.etiquetacodigo.Location = New System.Drawing.Point(430, 360)
        Me.etiquetacodigo.Name = "etiquetacodigo"
        Me.etiquetacodigo.Size = New System.Drawing.Size(40, 13)
        Me.etiquetacodigo.TabIndex = 512
        Me.etiquetacodigo.Text = "Codigo"
        Me.etiquetacodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.etiquetacodigo.Visible = False
        '
        'lblBanderaVoz
        '
        Me.lblBanderaVoz.AutoSize = True
        Me.lblBanderaVoz.BackColor = System.Drawing.Color.Red
        Me.lblBanderaVoz.Location = New System.Drawing.Point(806, 456)
        Me.lblBanderaVoz.Name = "lblBanderaVoz"
        Me.lblBanderaVoz.Size = New System.Drawing.Size(13, 13)
        Me.lblBanderaVoz.TabIndex = 519
        Me.lblBanderaVoz.Text = "0"
        Me.lblBanderaVoz.Visible = False
        '
        'lblBanderaTipo_voz
        '
        Me.lblBanderaTipo_voz.AutoSize = True
        Me.lblBanderaTipo_voz.BackColor = System.Drawing.Color.Red
        Me.lblBanderaTipo_voz.Location = New System.Drawing.Point(787, 456)
        Me.lblBanderaTipo_voz.Name = "lblBanderaTipo_voz"
        Me.lblBanderaTipo_voz.Size = New System.Drawing.Size(13, 13)
        Me.lblBanderaTipo_voz.TabIndex = 518
        Me.lblBanderaTipo_voz.Text = "0"
        Me.lblBanderaTipo_voz.Visible = False
        '
        'lblBanderaControl
        '
        Me.lblBanderaControl.AutoSize = True
        Me.lblBanderaControl.BackColor = System.Drawing.Color.Red
        Me.lblBanderaControl.Location = New System.Drawing.Point(768, 456)
        Me.lblBanderaControl.Name = "lblBanderaControl"
        Me.lblBanderaControl.Size = New System.Drawing.Size(13, 13)
        Me.lblBanderaControl.TabIndex = 517
        Me.lblBanderaControl.Text = "0"
        Me.lblBanderaControl.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtnombre_tipo_voz
        '
        Me.txtnombre_tipo_voz.BackColor = System.Drawing.Color.White
        Me.txtnombre_tipo_voz.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnombre_tipo_voz.Location = New System.Drawing.Point(421, 141)
        Me.txtnombre_tipo_voz.MaxLength = 50
        Me.txtnombre_tipo_voz.Multiline = True
        Me.txtnombre_tipo_voz.Name = "txtnombre_tipo_voz"
        Me.txtnombre_tipo_voz.Size = New System.Drawing.Size(432, 41)
        Me.txtnombre_tipo_voz.TabIndex = 523
        Me.txtnombre_tipo_voz.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Gainsboro
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(565, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 526
        Me.Label3.Text = "Codigo"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Visible = False
        '
        'txtCodigoTipo
        '
        Me.txtCodigoTipo.BackColor = System.Drawing.Color.White
        Me.txtCodigoTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoTipo.Location = New System.Drawing.Point(568, 201)
        Me.txtCodigoTipo.MaxLength = 50
        Me.txtCodigoTipo.Name = "txtCodigoTipo"
        Me.txtCodigoTipo.Size = New System.Drawing.Size(55, 20)
        Me.txtCodigoTipo.TabIndex = 525
        Me.txtCodigoTipo.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Gainsboro
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(418, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 529
        Me.Label4.Text = "Nombre_tipo_voz"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(498, 111)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(353, 2)
        Me.Panel1.TabIndex = 534
        Me.Panel1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(418, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 535
        Me.Label1.Text = "TIPO DE VOZ"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(430, 261)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 537
        Me.Label2.Text = "VOCES"
        Me.Label2.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(488, 261)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(387, 2)
        Me.Panel2.TabIndex = 536
        Me.Panel2.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(400, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 539
        Me.Label5.Text = "CONTROLES"
        Me.Label5.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(488, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(353, 2)
        Me.Panel3.TabIndex = 538
        Me.Panel3.Visible = False
        '
        'txtCodigo_2
        '
        Me.txtCodigo_2.BackColor = System.Drawing.Color.White
        Me.txtCodigo_2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo_2.Location = New System.Drawing.Point(435, 402)
        Me.txtCodigo_2.MaxLength = 50
        Me.txtCodigo_2.Name = "txtCodigo_2"
        Me.txtCodigo_2.Size = New System.Drawing.Size(32, 20)
        Me.txtCodigo_2.TabIndex = 540
        Me.txtCodigo_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCodigo_2.Visible = False
        '
        'lblY
        '
        Me.lblY.AutoSize = True
        Me.lblY.BackColor = System.Drawing.Color.Red
        Me.lblY.ForeColor = System.Drawing.Color.Black
        Me.lblY.Location = New System.Drawing.Point(114, 230)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(13, 13)
        Me.lblY.TabIndex = 542
        Me.lblY.Text = "0"
        Me.lblY.Visible = False
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.BackColor = System.Drawing.Color.Red
        Me.lblX.ForeColor = System.Drawing.Color.Black
        Me.lblX.Location = New System.Drawing.Point(114, 253)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(13, 13)
        Me.lblX.TabIndex = 543
        Me.lblX.Text = "0"
        Me.lblX.Visible = False
        '
        'frmMainControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(873, 730)
        Me.Controls.Add(Me.lblX)
        Me.Controls.Add(Me.lblY)
        Me.Controls.Add(Me.txtCodigo_2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblBanderaVoz)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCodigoTipo)
        Me.Controls.Add(Me.txtnombre_tipo_voz)
        Me.Controls.Add(Me.lblBanderaTipo_voz)
        Me.Controls.Add(Me.lblBanderaControl)
        Me.Controls.Add(Me.etiquetanombre_voz)
        Me.Controls.Add(Me.lblid_voz)
        Me.Controls.Add(Me.lblid_tipo_voz)
        Me.Controls.Add(Me.etiquetaicono)
        Me.Controls.Add(Me.etiquetacodigo)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.lblid_control)
        Me.Controls.Add(Me.txtnombre_control)
        Me.Controls.Add(Me.btnAbrir)
        Me.Controls.Add(Me.txtnombre_voz)
        Me.Controls.Add(Me.txticono)
        Me.Name = "frmMainControl"
        Me.Text = "Administrar Controles"
        Me.ctx_menu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Protected WithEvents txtnombre_control As System.Windows.Forms.TextBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btnAbrir As System.Windows.Forms.Button
    Protected WithEvents txtnombre_voz As System.Windows.Forms.TextBox
    Protected WithEvents txticono As System.Windows.Forms.TextBox
    Friend WithEvents lblid_control As System.Windows.Forms.Label
    Friend WithEvents lblid_tipo_voz As System.Windows.Forms.Label
    Friend WithEvents lblid_voz As System.Windows.Forms.Label
    Friend WithEvents etiquetanombre_voz As System.Windows.Forms.Label
    Friend WithEvents etiquetaicono As System.Windows.Forms.Label
    Friend WithEvents etiquetacodigo As System.Windows.Forms.Label
    Friend WithEvents lblBanderaVoz As System.Windows.Forms.Label
    Friend WithEvents lblBanderaTipo_voz As System.Windows.Forms.Label
    Friend WithEvents lblBanderaControl As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Protected WithEvents txtnombre_tipo_voz As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblY As System.Windows.Forms.Label
    Friend WithEvents lblX As System.Windows.Forms.Label
    Friend WithEvents ctx_menu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ts_agregar_control As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_modificar_control As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_borrar_control As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ts_agregar_tv As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_modificar_tv As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_borrar_tv As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ts_agregar_voz As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_modificar_voz As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_borrar_voz As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_porcentaje As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoTipo As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo_2 As System.Windows.Forms.TextBox
    Friend WithEvents ts_modificar_codigo_voz As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_porcentaje_tipo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsOrdenarTiposDeVoz As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsOrdenCreacion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsNombre As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_ordenar_voz As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_nombrevoz As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_creacion As System.Windows.Forms.ToolStripMenuItem
End Class
