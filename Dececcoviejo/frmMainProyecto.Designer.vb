<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainProyecto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainProyecto))
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.lblBanderaActividad = New System.Windows.Forms.Label()
        Me.lblBanderaActividad_proyecto = New System.Windows.Forms.Label()
        Me.lblBanderaProyecto = New System.Windows.Forms.Label()
        Me.lblid_actividad_proyecto = New System.Windows.Forms.Label()
        Me.lblid_actividad = New System.Windows.Forms.Label()
        Me.lblid_proyecto = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnGuardarProyecto = New System.Windows.Forms.Button()
        Me.txtnombre_proyecto = New System.Windows.Forms.TextBox()
        Me.btnBorrarProyecto = New System.Windows.Forms.Button()
        Me.btnModificarProyecto = New System.Windows.Forms.Button()
        Me.btnNuevoProyecto = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnGuardarActividad = New System.Windows.Forms.Button()
        Me.txtNombre_actividad = New System.Windows.Forms.TextBox()
        Me.btnBorrarActividad = New System.Windows.Forms.Button()
        Me.btnModificarActividad = New System.Windows.Forms.Button()
        Me.btnNuevoActividad = New System.Windows.Forms.Button()
        Me.chkProyectoInicial = New System.Windows.Forms.CheckBox()
        Me.lblid_proyect_manager = New System.Windows.Forms.Label()
        Me.cmbproyect_manager = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_proyect_manager = New System.Windows.Forms.Label()
        Me.lblid_controlador_1 = New System.Windows.Forms.Label()
        Me.cmbcontrolador_1 = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_controlador_1 = New System.Windows.Forms.Label()
        Me.lblid_controlador_2 = New System.Windows.Forms.Label()
        Me.cmbcontrolador_2 = New System.Windows.Forms.ComboBox()
        Me.etiquetaid_controlador_2 = New System.Windows.Forms.Label()
        Me.txtcantidad_hora = New System.Windows.Forms.TextBox()
        Me.etiquetacantidad_hora = New System.Windows.Forms.Label()
        Me.txtOrden = New System.Windows.Forms.TextBox()
        Me.etiquetaprioridad = New System.Windows.Forms.Label()
        Me.txttotal_hora = New System.Windows.Forms.TextBox()
        Me.etiquetatotal_hora = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView1.ImageIndex = 0
        Me.TreeView1.ImageList = Me.ImageList1
        Me.TreeView1.Location = New System.Drawing.Point(12, 12)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.SelectedImageIndex = 2
        Me.TreeView1.Size = New System.Drawing.Size(511, 706)
        Me.TreeView1.TabIndex = 1
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
        'lblBanderaActividad
        '
        Me.lblBanderaActividad.AutoSize = True
        Me.lblBanderaActividad.BackColor = System.Drawing.Color.Red
        Me.lblBanderaActividad.Location = New System.Drawing.Point(943, 376)
        Me.lblBanderaActividad.Name = "lblBanderaActividad"
        Me.lblBanderaActividad.Size = New System.Drawing.Size(13, 13)
        Me.lblBanderaActividad.TabIndex = 525
        Me.lblBanderaActividad.Text = "0"
        Me.lblBanderaActividad.Visible = False
        '
        'lblBanderaActividad_proyecto
        '
        Me.lblBanderaActividad_proyecto.AutoSize = True
        Me.lblBanderaActividad_proyecto.BackColor = System.Drawing.Color.Red
        Me.lblBanderaActividad_proyecto.Location = New System.Drawing.Point(924, 376)
        Me.lblBanderaActividad_proyecto.Name = "lblBanderaActividad_proyecto"
        Me.lblBanderaActividad_proyecto.Size = New System.Drawing.Size(13, 13)
        Me.lblBanderaActividad_proyecto.TabIndex = 524
        Me.lblBanderaActividad_proyecto.Text = "0"
        Me.lblBanderaActividad_proyecto.Visible = False
        '
        'lblBanderaProyecto
        '
        Me.lblBanderaProyecto.AutoSize = True
        Me.lblBanderaProyecto.BackColor = System.Drawing.Color.Red
        Me.lblBanderaProyecto.Location = New System.Drawing.Point(905, 376)
        Me.lblBanderaProyecto.Name = "lblBanderaProyecto"
        Me.lblBanderaProyecto.Size = New System.Drawing.Size(13, 13)
        Me.lblBanderaProyecto.TabIndex = 523
        Me.lblBanderaProyecto.Text = "0"
        Me.lblBanderaProyecto.Visible = False
        '
        'lblid_actividad_proyecto
        '
        Me.lblid_actividad_proyecto.AutoSize = True
        Me.lblid_actividad_proyecto.BackColor = System.Drawing.Color.Red
        Me.lblid_actividad_proyecto.Location = New System.Drawing.Point(837, 376)
        Me.lblid_actividad_proyecto.Name = "lblid_actividad_proyecto"
        Me.lblid_actividad_proyecto.Size = New System.Drawing.Size(13, 13)
        Me.lblid_actividad_proyecto.TabIndex = 522
        Me.lblid_actividad_proyecto.Text = "0"
        Me.lblid_actividad_proyecto.Visible = False
        '
        'lblid_actividad
        '
        Me.lblid_actividad.AutoSize = True
        Me.lblid_actividad.BackColor = System.Drawing.Color.Red
        Me.lblid_actividad.Location = New System.Drawing.Point(818, 376)
        Me.lblid_actividad.Name = "lblid_actividad"
        Me.lblid_actividad.Size = New System.Drawing.Size(13, 13)
        Me.lblid_actividad.TabIndex = 521
        Me.lblid_actividad.Text = "0"
        Me.lblid_actividad.Visible = False
        '
        'lblid_proyecto
        '
        Me.lblid_proyecto.AutoSize = True
        Me.lblid_proyecto.BackColor = System.Drawing.Color.Red
        Me.lblid_proyecto.Location = New System.Drawing.Point(799, 376)
        Me.lblid_proyecto.Name = "lblid_proyecto"
        Me.lblid_proyecto.Size = New System.Drawing.Size(13, 13)
        Me.lblid_proyecto.TabIndex = 520
        Me.lblid_proyecto.Text = "0"
        Me.lblid_proyecto.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(561, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 546
        Me.Label5.Text = "PROYECTOS"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(642, 16)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(353, 2)
        Me.Panel3.TabIndex = 545
        '
        'btnGuardarProyecto
        '
        Me.btnGuardarProyecto.Location = New System.Drawing.Point(564, 38)
        Me.btnGuardarProyecto.Name = "btnGuardarProyecto"
        Me.btnGuardarProyecto.Size = New System.Drawing.Size(59, 22)
        Me.btnGuardarProyecto.TabIndex = 544
        Me.btnGuardarProyecto.Text = "Guardar"
        Me.btnGuardarProyecto.UseVisualStyleBackColor = True
        '
        'txtnombre_proyecto
        '
        Me.txtnombre_proyecto.BackColor = System.Drawing.Color.White
        Me.txtnombre_proyecto.Location = New System.Drawing.Point(17, 39)
        Me.txtnombre_proyecto.MaxLength = 500
        Me.txtnombre_proyecto.Multiline = True
        Me.txtnombre_proyecto.Name = "txtnombre_proyecto"
        Me.txtnombre_proyecto.Size = New System.Drawing.Size(462, 49)
        Me.txtnombre_proyecto.TabIndex = 543
        '
        'btnBorrarProyecto
        '
        Me.btnBorrarProyecto.Location = New System.Drawing.Point(774, 38)
        Me.btnBorrarProyecto.Name = "btnBorrarProyecto"
        Me.btnBorrarProyecto.Size = New System.Drawing.Size(52, 22)
        Me.btnBorrarProyecto.TabIndex = 542
        Me.btnBorrarProyecto.Text = "Borrar"
        Me.btnBorrarProyecto.UseVisualStyleBackColor = True
        '
        'btnModificarProyecto
        '
        Me.btnModificarProyecto.Location = New System.Drawing.Point(694, 38)
        Me.btnModificarProyecto.Name = "btnModificarProyecto"
        Me.btnModificarProyecto.Size = New System.Drawing.Size(63, 22)
        Me.btnModificarProyecto.TabIndex = 541
        Me.btnModificarProyecto.Text = "Modificar"
        Me.btnModificarProyecto.UseVisualStyleBackColor = True
        '
        'btnNuevoProyecto
        '
        Me.btnNuevoProyecto.Location = New System.Drawing.Point(636, 38)
        Me.btnNuevoProyecto.Name = "btnNuevoProyecto"
        Me.btnNuevoProyecto.Size = New System.Drawing.Size(52, 22)
        Me.btnNuevoProyecto.TabIndex = 540
        Me.btnNuevoProyecto.Text = "Nuevo"
        Me.btnNuevoProyecto.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(564, 388)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 553
        Me.Label1.Text = "ACTIVIDADES"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(645, 392)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(353, 2)
        Me.Panel1.TabIndex = 552
        '
        'btnGuardarActividad
        '
        Me.btnGuardarActividad.Location = New System.Drawing.Point(564, 414)
        Me.btnGuardarActividad.Name = "btnGuardarActividad"
        Me.btnGuardarActividad.Size = New System.Drawing.Size(59, 22)
        Me.btnGuardarActividad.TabIndex = 551
        Me.btnGuardarActividad.Text = "Guardar"
        Me.btnGuardarActividad.UseVisualStyleBackColor = True
        '
        'txtNombre_actividad
        '
        Me.txtNombre_actividad.BackColor = System.Drawing.Color.White
        Me.txtNombre_actividad.Location = New System.Drawing.Point(6, 35)
        Me.txtNombre_actividad.MaxLength = 500
        Me.txtNombre_actividad.Multiline = True
        Me.txtNombre_actividad.Name = "txtNombre_actividad"
        Me.txtNombre_actividad.Size = New System.Drawing.Size(459, 49)
        Me.txtNombre_actividad.TabIndex = 550
        '
        'btnBorrarActividad
        '
        Me.btnBorrarActividad.Location = New System.Drawing.Point(774, 414)
        Me.btnBorrarActividad.Name = "btnBorrarActividad"
        Me.btnBorrarActividad.Size = New System.Drawing.Size(52, 22)
        Me.btnBorrarActividad.TabIndex = 549
        Me.btnBorrarActividad.Text = "Borrar"
        Me.btnBorrarActividad.UseVisualStyleBackColor = True
        '
        'btnModificarActividad
        '
        Me.btnModificarActividad.Location = New System.Drawing.Point(694, 414)
        Me.btnModificarActividad.Name = "btnModificarActividad"
        Me.btnModificarActividad.Size = New System.Drawing.Size(63, 22)
        Me.btnModificarActividad.TabIndex = 548
        Me.btnModificarActividad.Text = "Modificar"
        Me.btnModificarActividad.UseVisualStyleBackColor = True
        '
        'btnNuevoActividad
        '
        Me.btnNuevoActividad.Location = New System.Drawing.Point(636, 414)
        Me.btnNuevoActividad.Name = "btnNuevoActividad"
        Me.btnNuevoActividad.Size = New System.Drawing.Size(52, 22)
        Me.btnNuevoActividad.TabIndex = 547
        Me.btnNuevoActividad.Text = "Nuevo"
        Me.btnNuevoActividad.UseVisualStyleBackColor = True
        '
        'chkProyectoInicial
        '
        Me.chkProyectoInicial.AutoSize = True
        Me.chkProyectoInicial.Location = New System.Drawing.Point(876, 38)
        Me.chkProyectoInicial.Name = "chkProyectoInicial"
        Me.chkProyectoInicial.Size = New System.Drawing.Size(98, 17)
        Me.chkProyectoInicial.TabIndex = 554
        Me.chkProyectoInicial.Text = "Proyecto Inicial"
        Me.chkProyectoInicial.UseVisualStyleBackColor = True
        '
        'lblid_proyect_manager
        '
        Me.lblid_proyect_manager.AutoSize = True
        Me.lblid_proyect_manager.BackColor = System.Drawing.Color.Red
        Me.lblid_proyect_manager.Location = New System.Drawing.Point(360, 97)
        Me.lblid_proyect_manager.Name = "lblid_proyect_manager"
        Me.lblid_proyect_manager.Size = New System.Drawing.Size(13, 13)
        Me.lblid_proyect_manager.TabIndex = 557
        Me.lblid_proyect_manager.Text = "0"
        Me.lblid_proyect_manager.Visible = False
        '
        'cmbproyect_manager
        '
        Me.cmbproyect_manager.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbproyect_manager.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbproyect_manager.FormattingEnabled = True
        Me.cmbproyect_manager.Location = New System.Drawing.Point(151, 97)
        Me.cmbproyect_manager.Name = "cmbproyect_manager"
        Me.cmbproyect_manager.Size = New System.Drawing.Size(329, 21)
        Me.cmbproyect_manager.TabIndex = 555
        Me.cmbproyect_manager.Visible = False
        '
        'etiquetaid_proyect_manager
        '
        Me.etiquetaid_proyect_manager.AutoSize = True
        Me.etiquetaid_proyect_manager.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_proyect_manager.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_proyect_manager.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_proyect_manager.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_proyect_manager.Location = New System.Drawing.Point(18, 97)
        Me.etiquetaid_proyect_manager.Name = "etiquetaid_proyect_manager"
        Me.etiquetaid_proyect_manager.Size = New System.Drawing.Size(106, 17)
        Me.etiquetaid_proyect_manager.TabIndex = 558
        Me.etiquetaid_proyect_manager.Text = "Proyect_manager"
        Me.etiquetaid_proyect_manager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.etiquetaid_proyect_manager.Visible = False
        '
        'lblid_controlador_1
        '
        Me.lblid_controlador_1.AutoSize = True
        Me.lblid_controlador_1.BackColor = System.Drawing.Color.Red
        Me.lblid_controlador_1.Location = New System.Drawing.Point(360, 130)
        Me.lblid_controlador_1.Name = "lblid_controlador_1"
        Me.lblid_controlador_1.Size = New System.Drawing.Size(13, 13)
        Me.lblid_controlador_1.TabIndex = 563
        Me.lblid_controlador_1.Text = "0"
        Me.lblid_controlador_1.Visible = False
        '
        'cmbcontrolador_1
        '
        Me.cmbcontrolador_1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbcontrolador_1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbcontrolador_1.FormattingEnabled = True
        Me.cmbcontrolador_1.Location = New System.Drawing.Point(151, 130)
        Me.cmbcontrolador_1.Name = "cmbcontrolador_1"
        Me.cmbcontrolador_1.Size = New System.Drawing.Size(329, 21)
        Me.cmbcontrolador_1.TabIndex = 559
        Me.cmbcontrolador_1.Visible = False
        '
        'etiquetaid_controlador_1
        '
        Me.etiquetaid_controlador_1.AutoSize = True
        Me.etiquetaid_controlador_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_controlador_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_controlador_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_controlador_1.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_controlador_1.Location = New System.Drawing.Point(18, 130)
        Me.etiquetaid_controlador_1.Name = "etiquetaid_controlador_1"
        Me.etiquetaid_controlador_1.Size = New System.Drawing.Size(87, 17)
        Me.etiquetaid_controlador_1.TabIndex = 564
        Me.etiquetaid_controlador_1.Text = "Controlador_1"
        Me.etiquetaid_controlador_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.etiquetaid_controlador_1.Visible = False
        '
        'lblid_controlador_2
        '
        Me.lblid_controlador_2.AutoSize = True
        Me.lblid_controlador_2.BackColor = System.Drawing.Color.Red
        Me.lblid_controlador_2.Location = New System.Drawing.Point(360, 164)
        Me.lblid_controlador_2.Name = "lblid_controlador_2"
        Me.lblid_controlador_2.Size = New System.Drawing.Size(13, 13)
        Me.lblid_controlador_2.TabIndex = 565
        Me.lblid_controlador_2.Text = "0"
        Me.lblid_controlador_2.Visible = False
        '
        'cmbcontrolador_2
        '
        Me.cmbcontrolador_2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbcontrolador_2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbcontrolador_2.FormattingEnabled = True
        Me.cmbcontrolador_2.Location = New System.Drawing.Point(151, 164)
        Me.cmbcontrolador_2.Name = "cmbcontrolador_2"
        Me.cmbcontrolador_2.Size = New System.Drawing.Size(329, 21)
        Me.cmbcontrolador_2.TabIndex = 560
        Me.cmbcontrolador_2.Visible = False
        '
        'etiquetaid_controlador_2
        '
        Me.etiquetaid_controlador_2.AutoSize = True
        Me.etiquetaid_controlador_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_controlador_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_controlador_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_controlador_2.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_controlador_2.Location = New System.Drawing.Point(18, 164)
        Me.etiquetaid_controlador_2.Name = "etiquetaid_controlador_2"
        Me.etiquetaid_controlador_2.Size = New System.Drawing.Size(87, 17)
        Me.etiquetaid_controlador_2.TabIndex = 566
        Me.etiquetaid_controlador_2.Text = "Controlador_2"
        Me.etiquetaid_controlador_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.etiquetaid_controlador_2.Visible = False
        '
        'txtcantidad_hora
        '
        Me.txtcantidad_hora.BackColor = System.Drawing.Color.White
        Me.txtcantidad_hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantidad_hora.ForeColor = System.Drawing.Color.Blue
        Me.txtcantidad_hora.Location = New System.Drawing.Point(107, 110)
        Me.txtcantidad_hora.MaxLength = 50
        Me.txtcantidad_hora.Name = "txtcantidad_hora"
        Me.txtcantidad_hora.Size = New System.Drawing.Size(93, 31)
        Me.txtcantidad_hora.TabIndex = 570
        Me.txtcantidad_hora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetacantidad_hora
        '
        Me.etiquetacantidad_hora.AutoSize = True
        Me.etiquetacantidad_hora.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetacantidad_hora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetacantidad_hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetacantidad_hora.ForeColor = System.Drawing.Color.Black
        Me.etiquetacantidad_hora.Location = New System.Drawing.Point(10, 110)
        Me.etiquetacantidad_hora.Name = "etiquetacantidad_hora"
        Me.etiquetacantidad_hora.Size = New System.Drawing.Size(90, 17)
        Me.etiquetacantidad_hora.TabIndex = 575
        Me.etiquetacantidad_hora.Text = "Cantidad_hora"
        Me.etiquetacantidad_hora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtOrden
        '
        Me.txtOrden.BackColor = System.Drawing.Color.White
        Me.txtOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrden.ForeColor = System.Drawing.Color.Blue
        Me.txtOrden.Location = New System.Drawing.Point(264, 110)
        Me.txtOrden.MaxLength = 50
        Me.txtOrden.Name = "txtOrden"
        Me.txtOrden.Size = New System.Drawing.Size(93, 31)
        Me.txtOrden.TabIndex = 571
        Me.txtOrden.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetaprioridad
        '
        Me.etiquetaprioridad.AutoSize = True
        Me.etiquetaprioridad.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaprioridad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaprioridad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaprioridad.ForeColor = System.Drawing.Color.Black
        Me.etiquetaprioridad.Location = New System.Drawing.Point(214, 110)
        Me.etiquetaprioridad.Name = "etiquetaprioridad"
        Me.etiquetaprioridad.Size = New System.Drawing.Size(43, 17)
        Me.etiquetaprioridad.TabIndex = 576
        Me.etiquetaprioridad.Text = "Orden"
        Me.etiquetaprioridad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txttotal_hora
        '
        Me.txttotal_hora.BackColor = System.Drawing.Color.White
        Me.txttotal_hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal_hora.ForeColor = System.Drawing.Color.Blue
        Me.txttotal_hora.Location = New System.Drawing.Point(97, 198)
        Me.txttotal_hora.MaxLength = 50
        Me.txttotal_hora.Name = "txttotal_hora"
        Me.txttotal_hora.Size = New System.Drawing.Size(131, 31)
        Me.txttotal_hora.TabIndex = 585
        Me.txttotal_hora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etiquetatotal_hora
        '
        Me.etiquetatotal_hora.AutoSize = True
        Me.etiquetatotal_hora.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetatotal_hora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetatotal_hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetatotal_hora.ForeColor = System.Drawing.Color.Black
        Me.etiquetatotal_hora.Location = New System.Drawing.Point(17, 198)
        Me.etiquetatotal_hora.Name = "etiquetatotal_hora"
        Me.etiquetatotal_hora.Size = New System.Drawing.Size(68, 17)
        Me.etiquetatotal_hora.TabIndex = 590
        Me.etiquetatotal_hora.Text = "Total_hora"
        Me.etiquetatotal_hora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(17, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 17)
        Me.Label2.TabIndex = 591
        Me.Label2.Text = "Nombre"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 17)
        Me.Label3.TabIndex = 592
        Me.Label3.Text = "Nombre"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtOrden)
        Me.GroupBox1.Controls.Add(Me.txtNombre_actividad)
        Me.GroupBox1.Controls.Add(Me.etiquetaprioridad)
        Me.GroupBox1.Controls.Add(Me.etiquetacantidad_hora)
        Me.GroupBox1.Controls.Add(Me.txtcantidad_hora)
        Me.GroupBox1.Location = New System.Drawing.Point(544, 442)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(481, 157)
        Me.GroupBox1.TabIndex = 593
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txttotal_hora)
        Me.GroupBox2.Controls.Add(Me.txtnombre_proyecto)
        Me.GroupBox2.Controls.Add(Me.etiquetatotal_hora)
        Me.GroupBox2.Controls.Add(Me.etiquetaid_proyect_manager)
        Me.GroupBox2.Controls.Add(Me.lblid_controlador_1)
        Me.GroupBox2.Controls.Add(Me.cmbproyect_manager)
        Me.GroupBox2.Controls.Add(Me.cmbcontrolador_1)
        Me.GroupBox2.Controls.Add(Me.lblid_proyect_manager)
        Me.GroupBox2.Controls.Add(Me.etiquetaid_controlador_1)
        Me.GroupBox2.Controls.Add(Me.etiquetaid_controlador_2)
        Me.GroupBox2.Controls.Add(Me.lblid_controlador_2)
        Me.GroupBox2.Controls.Add(Me.cmbcontrolador_2)
        Me.GroupBox2.Location = New System.Drawing.Point(529, 66)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(504, 280)
        Me.GroupBox2.TabIndex = 594
        Me.GroupBox2.TabStop = False
        '
        'frmMainProyecto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1037, 734)
        Me.Controls.Add(Me.chkProyectoInicial)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnGuardarActividad)
        Me.Controls.Add(Me.btnBorrarActividad)
        Me.Controls.Add(Me.btnModificarActividad)
        Me.Controls.Add(Me.btnNuevoActividad)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnGuardarProyecto)
        Me.Controls.Add(Me.btnBorrarProyecto)
        Me.Controls.Add(Me.btnModificarProyecto)
        Me.Controls.Add(Me.btnNuevoProyecto)
        Me.Controls.Add(Me.lblBanderaActividad)
        Me.Controls.Add(Me.lblBanderaActividad_proyecto)
        Me.Controls.Add(Me.lblBanderaProyecto)
        Me.Controls.Add(Me.lblid_actividad_proyecto)
        Me.Controls.Add(Me.lblid_actividad)
        Me.Controls.Add(Me.lblid_proyecto)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmMainProyecto"
        Me.Text = "frmMainProyecto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents lblBanderaActividad As System.Windows.Forms.Label
    Friend WithEvents lblBanderaActividad_proyecto As System.Windows.Forms.Label
    Friend WithEvents lblBanderaProyecto As System.Windows.Forms.Label
    Friend WithEvents lblid_actividad_proyecto As System.Windows.Forms.Label
    Friend WithEvents lblid_actividad As System.Windows.Forms.Label
    Friend WithEvents lblid_proyecto As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnGuardarProyecto As System.Windows.Forms.Button
    Protected WithEvents txtnombre_proyecto As System.Windows.Forms.TextBox
    Friend WithEvents btnBorrarProyecto As System.Windows.Forms.Button
    Friend WithEvents btnModificarProyecto As System.Windows.Forms.Button
    Friend WithEvents btnNuevoProyecto As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnGuardarActividad As System.Windows.Forms.Button
    Protected WithEvents txtNombre_actividad As System.Windows.Forms.TextBox
    Friend WithEvents btnBorrarActividad As System.Windows.Forms.Button
    Friend WithEvents btnModificarActividad As System.Windows.Forms.Button
    Friend WithEvents btnNuevoActividad As System.Windows.Forms.Button
    Friend WithEvents chkProyectoInicial As System.Windows.Forms.CheckBox
    Friend WithEvents lblid_proyect_manager As System.Windows.Forms.Label
    Friend WithEvents cmbproyect_manager As System.Windows.Forms.ComboBox
    Friend WithEvents etiquetaid_proyect_manager As System.Windows.Forms.Label
    Friend WithEvents lblid_controlador_1 As System.Windows.Forms.Label
    Friend WithEvents cmbcontrolador_1 As System.Windows.Forms.ComboBox
    Friend WithEvents etiquetaid_controlador_1 As System.Windows.Forms.Label
    Friend WithEvents lblid_controlador_2 As System.Windows.Forms.Label
    Friend WithEvents cmbcontrolador_2 As System.Windows.Forms.ComboBox
    Friend WithEvents etiquetaid_controlador_2 As System.Windows.Forms.Label
    Protected WithEvents txtcantidad_hora As System.Windows.Forms.TextBox
    Friend WithEvents etiquetacantidad_hora As System.Windows.Forms.Label
    Protected WithEvents txtOrden As System.Windows.Forms.TextBox
    Friend WithEvents etiquetaprioridad As System.Windows.Forms.Label
    Protected WithEvents txttotal_hora As System.Windows.Forms.TextBox
    Friend WithEvents etiquetatotal_hora As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
