<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class frmLoginInicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoginInicio))
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmsProyecto = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ts_login_actividad = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsSeparator_login = New System.Windows.Forms.ToolStripSeparator()
        Me.smOrdenar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsOrdenarFechaCreacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsNombre = New System.Windows.Forms.ToolStripMenuItem()
        Me.smOrdenarArbol = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsOrdenarXNombre = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsRefrescarProyecto = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsAgregarControl = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsBorrarCtrl = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsSeparator_Administrar = New System.Windows.Forms.ToolStripSeparator()
        Me.tsAdministrarProyecto = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.txtEstadoControl = New System.Windows.Forms.TextBox()
        Me.lblid_pk = New System.Windows.Forms.Label()
        Me.lblid_pk_actividad = New System.Windows.Forms.Label()
        Me.lblid_pk_proyecto = New System.Windows.Forms.Label()
        Me.cmsLogueo = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ts_loguearNuevamente = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmsTarea = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsActualizarTareaPendiente = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarcarTareaComoRealizadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerTodasLasTareasPendientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsTareasXUsuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsHoraDevolver = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsModificarHoraDevolver = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsBorrarHoraDevolver = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctm_factura = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsAgregarFactura = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Logueo = New System.Windows.Forms.Timer(Me.components)
        Me.lblid_control = New System.Windows.Forms.Label()
        Me.lblid_movimiento_voz = New System.Windows.Forms.Label()
        Me.chkP = New System.Windows.Forms.CheckBox()
        Me.chk1 = New System.Windows.Forms.CheckBox()
        Me.chk2 = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.tabCompletados = New System.Windows.Forms.TabPage()
        Me.dgvControlesCompletados = New System.Windows.Forms.DataGridView()
        Me.id_actividad_dgv_completado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_proyecto_dgv_completado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_actividad_proyecto_dgv_completado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_control_dgv_completado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_movimiento_voz_dgv_completado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.control_prod_dgv_completado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.control_1_dgv_completado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.corr_1_completado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.pedido_segundo_control_dgv_completado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.control_prod_2_dgv_completado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.control_2_dgv_completado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.corr_2_completado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.nombre_actividad_dgv_completado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_subproyecto_dgv_completado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_control_dgv_completado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_proyecto_dgv_completado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_usuario_1_dgv_completado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_usuario_2_dgv_completado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_usuario_3_dgv_completado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_usuario_4_dgv_completado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_usuario_5_dgv_completado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_usuario_6_dgv_completado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_asignada_dgv_completado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_inicio_dgv_completado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_completado_dgv_completado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.completado_dgv_completado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Cadista_1_completado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Controlador_1_completado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Correccion_1_completado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cadista_2_completado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Controlador_2_completado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Correccion_2_completado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabEnEspera = New System.Windows.Forms.TabPage()
        Me.dgvControlEspera = New System.Windows.Forms.DataGridView()
        Me.id_actividad_dgv_espera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_proyecto_dgv_espera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_actividad_proyecto_dgv_espera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_control_dgv_espera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_movimiento_voz_dgv_espera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.completado_dgv_espera = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.control_prod_dgv_espera = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.control_1_dgv_espera = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.corr_1_espera = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.pedido_segundo_control_dgv_espera = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.control_prod_2_dgv_espera = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.control_2_dgv_espera = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.corr_2_espera = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.nombre_actividad_dgv_espera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_subproyecto_dgv_espera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_control_dgv_espera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_proyecto_dgv_espera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_usuario_1_dgv_espera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_usuario_2_dgv_espera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_usuario_3_dgv_espera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_usuario_4_dgv_espera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_usuario_5_dgv_espera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_usuario_6_dgv_espera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_asignada_dgv_espera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_inicio_dgv_espera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_completado_dgv_espera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cadista_1_Espera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Controlador_1_Espera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Correccion_1_espera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cadista_2_espera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Controlador_2_espera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Correccion_2_espera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabMisControles = New System.Windows.Forms.TabPage()
        Me.dgvControl = New System.Windows.Forms.DataGridView()
        Me.tabControles = New System.Windows.Forms.TabControl()
        Me.Background_pdf = New System.ComponentModel.BackgroundWorker()
        Me.TimerLogueo = New System.Windows.Forms.Timer(Me.components)
        Me.cms_anotaciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ts_anotaciones_copiar = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox16 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lbl_proveedor = New System.Windows.Forms.Label()
        Me.lbl_control = New System.Windows.Forms.Label()
        Me.TextBox27 = New System.Windows.Forms.TextBox()
        Me.lbl_correccion = New System.Windows.Forms.Label()
        Me.TextBox26 = New System.Windows.Forms.TextBox()
        Me.lbl_produccion = New System.Windows.Forms.Label()
        Me.TextBox25 = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tab_controles = New System.Windows.Forms.TabPage()
        Me.SplitContainer5 = New System.Windows.Forms.SplitContainer()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.grp_estado_control = New System.Windows.Forms.GroupBox()
        Me.chk_correccion_2_control = New System.Windows.Forms.CheckBox()
        Me.chk_control_2_control = New System.Windows.Forms.CheckBox()
        Me.chk_produccion_2_control = New System.Windows.Forms.CheckBox()
        Me.chk_correccion_1_control = New System.Windows.Forms.CheckBox()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.chk_control_1_control = New System.Windows.Forms.CheckBox()
        Me.chk_produccion_control = New System.Windows.Forms.CheckBox()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.txt_correccion_2_control = New System.Windows.Forms.TextBox()
        Me.txt_control_2_control = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txt_produccion_2_control = New System.Windows.Forms.TextBox()
        Me.txt_correccion_1_control = New System.Windows.Forms.TextBox()
        Me.txt_control_1_control = New System.Windows.Forms.TextBox()
        Me.txt_produccion_control = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.chk_completado_control = New System.Windows.Forms.CheckBox()
        Me.grp_propiedades_control = New System.Windows.Forms.GroupBox()
        Me.txt_actividad_control = New System.Windows.Forms.TextBox()
        Me.txt_subproyecto_control = New System.Windows.Forms.TextBox()
        Me.txt_proyecto_control = New System.Windows.Forms.TextBox()
        Me.txt_cliente_control = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.grp_fechas_control = New System.Windows.Forms.GroupBox()
        Me.txt_fecha_completado_control = New System.Windows.Forms.TextBox()
        Me.txt_fecha_inicio_control = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txt_control_control = New System.Windows.Forms.TextBox()
        Me.btnInforme = New System.Windows.Forms.Button()
        Me.btnRealizarControl = New System.Windows.Forms.Button()
        Me.btnRefrescarControl = New System.Windows.Forms.Button()
        Me.id_actividad_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_proyecto_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_actividad_proyecto_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_control_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_movimiento_voz_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.completado_dgv = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.control_prod_dgv = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.control_1_dgv = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.corr_1_pendiente = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.pedido_segundo_control_dgv = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.control_prod_2_dgv = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.control_2_dgv = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.corr_2_pendiente = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.nombre_proyecto_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_subproyecto_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_actividad_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_control_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_usuario_1_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_usuario_2_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_usuario_3_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_usuario_4_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_usuario_5_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_usuario_6_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_asignada_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_inicio_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_completado_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cadista_1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Controlador_1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Correccion_1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cadista_2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Controlador_2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Correccion_2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmsProyecto.SuspendLayout()
        Me.cmsLogueo.SuspendLayout()
        Me.cmsTarea.SuspendLayout()
        Me.cmsHoraDevolver.SuspendLayout()
        Me.ctm_factura.SuspendLayout()
        Me.tabCompletados.SuspendLayout()
        CType(Me.dgvControlesCompletados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabEnEspera.SuspendLayout()
        CType(Me.dgvControlEspera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMisControles.SuspendLayout()
        CType(Me.dgvControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabControles.SuspendLayout()
        Me.cms_anotaciones.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox16.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tab_controles.SuspendLayout()
        CType(Me.SplitContainer5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer5.Panel1.SuspendLayout()
        Me.SplitContainer5.Panel2.SuspendLayout()
        Me.SplitContainer5.SuspendLayout()
        Me.grp_estado_control.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.grp_propiedades_control.SuspendLayout()
        Me.grp_fechas_control.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmsProyecto
        '
        Me.cmsProyecto.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_login_actividad, Me.tsSeparator_login, Me.smOrdenar, Me.smOrdenarArbol, Me.tsSeparator4, Me.tsRefrescarProyecto, Me.tsSeparator6, Me.tsAgregarControl, Me.tsBorrarCtrl, Me.tsSeparator_Administrar, Me.tsAdministrarProyecto})
        Me.cmsProyecto.Name = "ContextMenuStrip1"
        Me.cmsProyecto.Size = New System.Drawing.Size(187, 182)
        '
        'ts_login_actividad
        '
        Me.ts_login_actividad.Name = "ts_login_actividad"
        Me.ts_login_actividad.Size = New System.Drawing.Size(186, 22)
        Me.ts_login_actividad.Text = "Login"
        '
        'tsSeparator_login
        '
        Me.tsSeparator_login.Name = "tsSeparator_login"
        Me.tsSeparator_login.Size = New System.Drawing.Size(183, 6)
        Me.tsSeparator_login.Visible = False
        '
        'smOrdenar
        '
        Me.smOrdenar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsOrdenarFechaCreacion, Me.tsNombre})
        Me.smOrdenar.Name = "smOrdenar"
        Me.smOrdenar.Size = New System.Drawing.Size(186, 22)
        Me.smOrdenar.Text = "Ordenar Proyecto"
        '
        'tsOrdenarFechaCreacion
        '
        Me.tsOrdenarFechaCreacion.Name = "tsOrdenarFechaCreacion"
        Me.tsOrdenarFechaCreacion.Size = New System.Drawing.Size(171, 22)
        Me.tsOrdenarFechaCreacion.Text = "Fecha de Creacion"
        '
        'tsNombre
        '
        Me.tsNombre.Name = "tsNombre"
        Me.tsNombre.Size = New System.Drawing.Size(171, 22)
        Me.tsNombre.Text = "Nombre"
        '
        'smOrdenarArbol
        '
        Me.smOrdenarArbol.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsOrdenarXNombre})
        Me.smOrdenarArbol.Name = "smOrdenarArbol"
        Me.smOrdenarArbol.Size = New System.Drawing.Size(186, 22)
        Me.smOrdenarArbol.Text = "Ordenar Proyectos"
        '
        'tsOrdenarXNombre
        '
        Me.tsOrdenarXNombre.Name = "tsOrdenarXNombre"
        Me.tsOrdenarXNombre.Size = New System.Drawing.Size(121, 22)
        Me.tsOrdenarXNombre.Text = " Nombre"
        '
        'tsSeparator4
        '
        Me.tsSeparator4.Name = "tsSeparator4"
        Me.tsSeparator4.Size = New System.Drawing.Size(183, 6)
        '
        'tsRefrescarProyecto
        '
        Me.tsRefrescarProyecto.Name = "tsRefrescarProyecto"
        Me.tsRefrescarProyecto.Size = New System.Drawing.Size(186, 22)
        Me.tsRefrescarProyecto.Text = "Actualizar Proyecto"
        '
        'tsSeparator6
        '
        Me.tsSeparator6.Name = "tsSeparator6"
        Me.tsSeparator6.Size = New System.Drawing.Size(183, 6)
        '
        'tsAgregarControl
        '
        Me.tsAgregarControl.Name = "tsAgregarControl"
        Me.tsAgregarControl.Size = New System.Drawing.Size(186, 22)
        Me.tsAgregarControl.Text = "Agregar Control"
        '
        'tsBorrarCtrl
        '
        Me.tsBorrarCtrl.Name = "tsBorrarCtrl"
        Me.tsBorrarCtrl.Size = New System.Drawing.Size(186, 22)
        Me.tsBorrarCtrl.Text = "Borrar Control"
        '
        'tsSeparator_Administrar
        '
        Me.tsSeparator_Administrar.Name = "tsSeparator_Administrar"
        Me.tsSeparator_Administrar.Size = New System.Drawing.Size(183, 6)
        '
        'tsAdministrarProyecto
        '
        Me.tsAdministrarProyecto.Name = "tsAdministrarProyecto"
        Me.tsAdministrarProyecto.Size = New System.Drawing.Size(186, 22)
        Me.tsAdministrarProyecto.Text = "Administrar Proyecto"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Proyecto16.png")
        Me.ImageList1.Images.SetKeyName(1, "Actividad16.png")
        Me.ImageList1.Images.SetKeyName(2, "bullet-check.png")
        Me.ImageList1.Images.SetKeyName(3, "ActividadCheck.png")
        Me.ImageList1.Images.SetKeyName(4, "iva.png")
        Me.ImageList1.Images.SetKeyName(5, "ProyectoSeleccionado16.png")
        Me.ImageList1.Images.SetKeyName(6, "ActividadControlOK16.png")
        Me.ImageList1.Images.SetKeyName(7, "ActividadControlOK16_2.png")
        Me.ImageList1.Images.SetKeyName(8, "ActividadControlPedido16_2.png")
        Me.ImageList1.Images.SetKeyName(9, "ActividadNaranja16.png")
        '
        'txtEstadoControl
        '
        Me.txtEstadoControl.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEstadoControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstadoControl.Location = New System.Drawing.Point(76, 21)
        Me.txtEstadoControl.Name = "txtEstadoControl"
        Me.txtEstadoControl.Size = New System.Drawing.Size(30, 13)
        Me.txtEstadoControl.TabIndex = 534
        Me.txtEstadoControl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblid_pk
        '
        Me.lblid_pk.AutoSize = True
        Me.lblid_pk.BackColor = System.Drawing.Color.Red
        Me.lblid_pk.Location = New System.Drawing.Point(209, 53)
        Me.lblid_pk.Name = "lblid_pk"
        Me.lblid_pk.Size = New System.Drawing.Size(13, 13)
        Me.lblid_pk.TabIndex = 622
        Me.lblid_pk.Text = "0"
        Me.lblid_pk.Visible = False
        '
        'lblid_pk_actividad
        '
        Me.lblid_pk_actividad.AutoSize = True
        Me.lblid_pk_actividad.BackColor = System.Drawing.Color.Red
        Me.lblid_pk_actividad.Location = New System.Drawing.Point(613, 61)
        Me.lblid_pk_actividad.Name = "lblid_pk_actividad"
        Me.lblid_pk_actividad.Size = New System.Drawing.Size(13, 13)
        Me.lblid_pk_actividad.TabIndex = 623
        Me.lblid_pk_actividad.Text = "0"
        Me.lblid_pk_actividad.Visible = False
        '
        'lblid_pk_proyecto
        '
        Me.lblid_pk_proyecto.AutoSize = True
        Me.lblid_pk_proyecto.BackColor = System.Drawing.Color.Red
        Me.lblid_pk_proyecto.Location = New System.Drawing.Point(667, 61)
        Me.lblid_pk_proyecto.Name = "lblid_pk_proyecto"
        Me.lblid_pk_proyecto.Size = New System.Drawing.Size(13, 13)
        Me.lblid_pk_proyecto.TabIndex = 624
        Me.lblid_pk_proyecto.Text = "0"
        Me.lblid_pk_proyecto.Visible = False
        '
        'cmsLogueo
        '
        Me.cmsLogueo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_loguearNuevamente})
        Me.cmsLogueo.Name = "cmsLogueo"
        Me.cmsLogueo.Size = New System.Drawing.Size(187, 26)
        '
        'ts_loguearNuevamente
        '
        Me.ts_loguearNuevamente.Name = "ts_loguearNuevamente"
        Me.ts_loguearNuevamente.Size = New System.Drawing.Size(186, 22)
        Me.ts_loguearNuevamente.Text = "Loguear nuevamente"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1800
        '
        'cmsTarea
        '
        Me.cmsTarea.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsActualizarTareaPendiente, Me.MarcarTareaComoRealizadaToolStripMenuItem, Me.VerTodasLasTareasPendientesToolStripMenuItem, Me.tsTareasXUsuario})
        Me.cmsTarea.Name = "cmsTarea"
        Me.cmsTarea.Size = New System.Drawing.Size(242, 92)
        '
        'tsActualizarTareaPendiente
        '
        Me.tsActualizarTareaPendiente.Name = "tsActualizarTareaPendiente"
        Me.tsActualizarTareaPendiente.Size = New System.Drawing.Size(241, 22)
        Me.tsActualizarTareaPendiente.Text = "Actualizar Tareas Pendientes"
        '
        'MarcarTareaComoRealizadaToolStripMenuItem
        '
        Me.MarcarTareaComoRealizadaToolStripMenuItem.Name = "MarcarTareaComoRealizadaToolStripMenuItem"
        Me.MarcarTareaComoRealizadaToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.MarcarTareaComoRealizadaToolStripMenuItem.Text = "Marcar Tarea como Realizada"
        '
        'VerTodasLasTareasPendientesToolStripMenuItem
        '
        Me.VerTodasLasTareasPendientesToolStripMenuItem.Name = "VerTodasLasTareasPendientesToolStripMenuItem"
        Me.VerTodasLasTareasPendientesToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.VerTodasLasTareasPendientesToolStripMenuItem.Text = "Ver Todas las Tareas Pendientes"
        '
        'tsTareasXUsuario
        '
        Me.tsTareasXUsuario.Name = "tsTareasXUsuario"
        Me.tsTareasXUsuario.Size = New System.Drawing.Size(241, 22)
        Me.tsTareasXUsuario.Text = "Ver Tareas por Usuario"
        '
        'cmsHoraDevolver
        '
        Me.cmsHoraDevolver.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsModificarHoraDevolver, Me.tsBorrarHoraDevolver})
        Me.cmsHoraDevolver.Name = "cmsHoraDevolver"
        Me.cmsHoraDevolver.Size = New System.Drawing.Size(213, 48)
        '
        'tsModificarHoraDevolver
        '
        Me.tsModificarHoraDevolver.Name = "tsModificarHoraDevolver"
        Me.tsModificarHoraDevolver.Size = New System.Drawing.Size(212, 22)
        Me.tsModificarHoraDevolver.Text = "Modificar Hora a Devolver"
        '
        'tsBorrarHoraDevolver
        '
        Me.tsBorrarHoraDevolver.Name = "tsBorrarHoraDevolver"
        Me.tsBorrarHoraDevolver.Size = New System.Drawing.Size(212, 22)
        Me.tsBorrarHoraDevolver.Text = "Borrar Hora a Devolver"
        '
        'ctm_factura
        '
        Me.ctm_factura.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsAgregarFactura})
        Me.ctm_factura.Name = "ctm_factura"
        Me.ctm_factura.Size = New System.Drawing.Size(159, 26)
        '
        'tsAgregarFactura
        '
        Me.tsAgregarFactura.Name = "tsAgregarFactura"
        Me.tsAgregarFactura.Size = New System.Drawing.Size(158, 22)
        Me.tsAgregarFactura.Text = "Agregar Factura"
        '
        'Timer2
        '
        Me.Timer2.Interval = 10000
        '
        'Timer_Logueo
        '
        Me.Timer_Logueo.Interval = 10000
        '
        'lblid_control
        '
        Me.lblid_control.AutoSize = True
        Me.lblid_control.BackColor = System.Drawing.Color.Red
        Me.lblid_control.Location = New System.Drawing.Point(760, 47)
        Me.lblid_control.Name = "lblid_control"
        Me.lblid_control.Size = New System.Drawing.Size(13, 13)
        Me.lblid_control.TabIndex = 646
        Me.lblid_control.Text = "0"
        Me.lblid_control.Visible = False
        '
        'lblid_movimiento_voz
        '
        Me.lblid_movimiento_voz.AutoSize = True
        Me.lblid_movimiento_voz.BackColor = System.Drawing.Color.Red
        Me.lblid_movimiento_voz.Location = New System.Drawing.Point(238, 53)
        Me.lblid_movimiento_voz.Name = "lblid_movimiento_voz"
        Me.lblid_movimiento_voz.Size = New System.Drawing.Size(13, 13)
        Me.lblid_movimiento_voz.TabIndex = 648
        Me.lblid_movimiento_voz.Text = "0"
        Me.lblid_movimiento_voz.Visible = False
        '
        'chkP
        '
        Me.chkP.AutoSize = True
        Me.chkP.Location = New System.Drawing.Point(7, 182)
        Me.chkP.Name = "chkP"
        Me.chkP.Size = New System.Drawing.Size(33, 17)
        Me.chkP.TabIndex = 653
        Me.chkP.Text = "P"
        Me.chkP.UseVisualStyleBackColor = True
        Me.chkP.Visible = False
        '
        'chk1
        '
        Me.chk1.AutoSize = True
        Me.chk1.Location = New System.Drawing.Point(46, 182)
        Me.chk1.Name = "chk1"
        Me.chk1.Size = New System.Drawing.Size(32, 17)
        Me.chk1.TabIndex = 654
        Me.chk1.Text = "1"
        Me.chk1.UseVisualStyleBackColor = True
        Me.chk1.Visible = False
        '
        'chk2
        '
        Me.chk2.AutoSize = True
        Me.chk2.Location = New System.Drawing.Point(84, 182)
        Me.chk2.Name = "chk2"
        Me.chk2.Size = New System.Drawing.Size(32, 17)
        Me.chk2.TabIndex = 655
        Me.chk2.Text = "2"
        Me.chk2.UseVisualStyleBackColor = True
        Me.chk2.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(209, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 13)
        Me.Label9.TabIndex = 622
        Me.Label9.Text = "0"
        Me.Label9.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(613, 61)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(13, 13)
        Me.Label10.TabIndex = 623
        Me.Label10.Text = "0"
        Me.Label10.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(667, 61)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(13, 13)
        Me.Label11.TabIndex = 624
        Me.Label11.Text = "0"
        Me.Label11.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(760, 47)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(13, 13)
        Me.Label12.TabIndex = 646
        Me.Label12.Text = "0"
        Me.Label12.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(238, 53)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(13, 13)
        Me.Label13.TabIndex = 648
        Me.Label13.Text = "0"
        Me.Label13.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(7, 182)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(33, 17)
        Me.CheckBox1.TabIndex = 653
        Me.CheckBox1.Text = "P"
        Me.CheckBox1.UseVisualStyleBackColor = True
        Me.CheckBox1.Visible = False
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(46, 182)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(32, 17)
        Me.CheckBox2.TabIndex = 654
        Me.CheckBox2.Text = "1"
        Me.CheckBox2.UseVisualStyleBackColor = True
        Me.CheckBox2.Visible = False
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(84, 182)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(32, 17)
        Me.CheckBox3.TabIndex = 655
        Me.CheckBox3.Text = "2"
        Me.CheckBox3.UseVisualStyleBackColor = True
        Me.CheckBox3.Visible = False
        '
        'tabCompletados
        '
        Me.tabCompletados.Controls.Add(Me.dgvControlesCompletados)
        Me.tabCompletados.Location = New System.Drawing.Point(4, 22)
        Me.tabCompletados.Name = "tabCompletados"
        Me.tabCompletados.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCompletados.Size = New System.Drawing.Size(1614, 261)
        Me.tabCompletados.TabIndex = 2
        Me.tabCompletados.Text = "Completados"
        Me.tabCompletados.UseVisualStyleBackColor = True
        '
        'dgvControlesCompletados
        '
        Me.dgvControlesCompletados.AllowUserToAddRows = False
        Me.dgvControlesCompletados.AllowUserToDeleteRows = False
        Me.dgvControlesCompletados.AllowUserToResizeRows = False
        Me.dgvControlesCompletados.BackgroundColor = System.Drawing.Color.Silver
        Me.dgvControlesCompletados.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvControlesCompletados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvControlesCompletados.ColumnHeadersHeight = 30
        Me.dgvControlesCompletados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_actividad_dgv_completado, Me.id_proyecto_dgv_completado, Me.id_actividad_proyecto_dgv_completado, Me.id_control_dgv_completado, Me.id_movimiento_voz_dgv_completado, Me.control_prod_dgv_completado, Me.control_1_dgv_completado, Me.corr_1_completado, Me.pedido_segundo_control_dgv_completado, Me.control_prod_2_dgv_completado, Me.control_2_dgv_completado, Me.corr_2_completado, Me.nombre_actividad_dgv_completado, Me.nombre_subproyecto_dgv_completado, Me.nombre_control_dgv_completado, Me.nombre_proyecto_dgv_completado, Me.id_usuario_1_dgv_completado, Me.id_usuario_2_dgv_completado, Me.id_usuario_3_dgv_completado, Me.id_usuario_4_dgv_completado, Me.id_usuario_5_dgv_completado, Me.id_usuario_6_dgv_completado, Me.fecha_asignada_dgv_completado, Me.fecha_inicio_dgv_completado, Me.fecha_completado_dgv_completado, Me.completado_dgv_completado, Me.Cadista_1_completado, Me.Controlador_1_completado, Me.Correccion_1_completado, Me.Cadista_2_completado, Me.Controlador_2_completado, Me.Correccion_2_completado})
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Chocolate
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvControlesCompletados.DefaultCellStyle = DataGridViewCellStyle15
        Me.dgvControlesCompletados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvControlesCompletados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvControlesCompletados.GridColor = System.Drawing.Color.MidnightBlue
        Me.dgvControlesCompletados.Location = New System.Drawing.Point(3, 3)
        Me.dgvControlesCompletados.Name = "dgvControlesCompletados"
        Me.dgvControlesCompletados.ReadOnly = True
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvControlesCompletados.RowHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.dgvControlesCompletados.RowHeadersVisible = False
        Me.dgvControlesCompletados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvControlesCompletados.ShowCellErrors = False
        Me.dgvControlesCompletados.ShowRowErrors = False
        Me.dgvControlesCompletados.Size = New System.Drawing.Size(1608, 255)
        Me.dgvControlesCompletados.StandardTab = True
        Me.dgvControlesCompletados.TabIndex = 601
        '
        'id_actividad_dgv_completado
        '
        Me.id_actividad_dgv_completado.HeaderText = "id_actividad_dgv"
        Me.id_actividad_dgv_completado.Name = "id_actividad_dgv_completado"
        Me.id_actividad_dgv_completado.ReadOnly = True
        Me.id_actividad_dgv_completado.Visible = False
        '
        'id_proyecto_dgv_completado
        '
        Me.id_proyecto_dgv_completado.HeaderText = "id_proyecto_dgv"
        Me.id_proyecto_dgv_completado.Name = "id_proyecto_dgv_completado"
        Me.id_proyecto_dgv_completado.ReadOnly = True
        Me.id_proyecto_dgv_completado.Visible = False
        '
        'id_actividad_proyecto_dgv_completado
        '
        Me.id_actividad_proyecto_dgv_completado.HeaderText = "id_actividad_proyecto_dgv"
        Me.id_actividad_proyecto_dgv_completado.Name = "id_actividad_proyecto_dgv_completado"
        Me.id_actividad_proyecto_dgv_completado.ReadOnly = True
        Me.id_actividad_proyecto_dgv_completado.Visible = False
        '
        'id_control_dgv_completado
        '
        Me.id_control_dgv_completado.HeaderText = "id_control_dgv"
        Me.id_control_dgv_completado.Name = "id_control_dgv_completado"
        Me.id_control_dgv_completado.ReadOnly = True
        Me.id_control_dgv_completado.Visible = False
        '
        'id_movimiento_voz_dgv_completado
        '
        Me.id_movimiento_voz_dgv_completado.HeaderText = "id_movimiento_voz_dgv"
        Me.id_movimiento_voz_dgv_completado.Name = "id_movimiento_voz_dgv_completado"
        Me.id_movimiento_voz_dgv_completado.ReadOnly = True
        Me.id_movimiento_voz_dgv_completado.Visible = False
        '
        'control_prod_dgv_completado
        '
        Me.control_prod_dgv_completado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.control_prod_dgv_completado.HeaderText = "P1"
        Me.control_prod_dgv_completado.Name = "control_prod_dgv_completado"
        Me.control_prod_dgv_completado.ReadOnly = True
        Me.control_prod_dgv_completado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.control_prod_dgv_completado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.control_prod_dgv_completado.Visible = False
        Me.control_prod_dgv_completado.Width = 30
        '
        'control_1_dgv_completado
        '
        Me.control_1_dgv_completado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.control_1_dgv_completado.HeaderText = "Ctrl 1"
        Me.control_1_dgv_completado.Name = "control_1_dgv_completado"
        Me.control_1_dgv_completado.ReadOnly = True
        Me.control_1_dgv_completado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.control_1_dgv_completado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.control_1_dgv_completado.Visible = False
        Me.control_1_dgv_completado.Width = 50
        '
        'corr_1_completado
        '
        Me.corr_1_completado.HeaderText = "Corr 1"
        Me.corr_1_completado.Name = "corr_1_completado"
        Me.corr_1_completado.ReadOnly = True
        Me.corr_1_completado.Visible = False
        Me.corr_1_completado.Width = 50
        '
        'pedido_segundo_control_dgv_completado
        '
        Me.pedido_segundo_control_dgv_completado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.pedido_segundo_control_dgv_completado.HeaderText = "P2C"
        Me.pedido_segundo_control_dgv_completado.Name = "pedido_segundo_control_dgv_completado"
        Me.pedido_segundo_control_dgv_completado.ReadOnly = True
        Me.pedido_segundo_control_dgv_completado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.pedido_segundo_control_dgv_completado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.pedido_segundo_control_dgv_completado.Visible = False
        Me.pedido_segundo_control_dgv_completado.Width = 30
        '
        'control_prod_2_dgv_completado
        '
        Me.control_prod_2_dgv_completado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.control_prod_2_dgv_completado.HeaderText = "P2"
        Me.control_prod_2_dgv_completado.Name = "control_prod_2_dgv_completado"
        Me.control_prod_2_dgv_completado.ReadOnly = True
        Me.control_prod_2_dgv_completado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.control_prod_2_dgv_completado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.control_prod_2_dgv_completado.Visible = False
        Me.control_prod_2_dgv_completado.Width = 30
        '
        'control_2_dgv_completado
        '
        Me.control_2_dgv_completado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.control_2_dgv_completado.HeaderText = "Ctrl 2"
        Me.control_2_dgv_completado.Name = "control_2_dgv_completado"
        Me.control_2_dgv_completado.ReadOnly = True
        Me.control_2_dgv_completado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.control_2_dgv_completado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.control_2_dgv_completado.Visible = False
        Me.control_2_dgv_completado.Width = 50
        '
        'corr_2_completado
        '
        Me.corr_2_completado.HeaderText = "Corr 2"
        Me.corr_2_completado.Name = "corr_2_completado"
        Me.corr_2_completado.ReadOnly = True
        Me.corr_2_completado.Visible = False
        Me.corr_2_completado.Width = 50
        '
        'nombre_actividad_dgv_completado
        '
        Me.nombre_actividad_dgv_completado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.nombre_actividad_dgv_completado.HeaderText = "Actividad"
        Me.nombre_actividad_dgv_completado.Name = "nombre_actividad_dgv_completado"
        Me.nombre_actividad_dgv_completado.ReadOnly = True
        Me.nombre_actividad_dgv_completado.Width = 150
        '
        'nombre_subproyecto_dgv_completado
        '
        Me.nombre_subproyecto_dgv_completado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.nombre_subproyecto_dgv_completado.HeaderText = "Path"
        Me.nombre_subproyecto_dgv_completado.Name = "nombre_subproyecto_dgv_completado"
        Me.nombre_subproyecto_dgv_completado.ReadOnly = True
        Me.nombre_subproyecto_dgv_completado.Width = 250
        '
        'nombre_control_dgv_completado
        '
        Me.nombre_control_dgv_completado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.nombre_control_dgv_completado.HeaderText = "Control"
        Me.nombre_control_dgv_completado.Name = "nombre_control_dgv_completado"
        Me.nombre_control_dgv_completado.ReadOnly = True
        Me.nombre_control_dgv_completado.Width = 300
        '
        'nombre_proyecto_dgv_completado
        '
        Me.nombre_proyecto_dgv_completado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.nombre_proyecto_dgv_completado.HeaderText = "Proyecto"
        Me.nombre_proyecto_dgv_completado.Name = "nombre_proyecto_dgv_completado"
        Me.nombre_proyecto_dgv_completado.ReadOnly = True
        Me.nombre_proyecto_dgv_completado.Width = 200
        '
        'id_usuario_1_dgv_completado
        '
        Me.id_usuario_1_dgv_completado.HeaderText = "Producción 1"
        Me.id_usuario_1_dgv_completado.Name = "id_usuario_1_dgv_completado"
        Me.id_usuario_1_dgv_completado.ReadOnly = True
        Me.id_usuario_1_dgv_completado.Visible = False
        '
        'id_usuario_2_dgv_completado
        '
        Me.id_usuario_2_dgv_completado.HeaderText = "Controlador 1"
        Me.id_usuario_2_dgv_completado.Name = "id_usuario_2_dgv_completado"
        Me.id_usuario_2_dgv_completado.ReadOnly = True
        Me.id_usuario_2_dgv_completado.Visible = False
        '
        'id_usuario_3_dgv_completado
        '
        Me.id_usuario_3_dgv_completado.HeaderText = "Corrección 1"
        Me.id_usuario_3_dgv_completado.Name = "id_usuario_3_dgv_completado"
        Me.id_usuario_3_dgv_completado.ReadOnly = True
        Me.id_usuario_3_dgv_completado.Visible = False
        '
        'id_usuario_4_dgv_completado
        '
        Me.id_usuario_4_dgv_completado.HeaderText = "Producción 2"
        Me.id_usuario_4_dgv_completado.Name = "id_usuario_4_dgv_completado"
        Me.id_usuario_4_dgv_completado.ReadOnly = True
        Me.id_usuario_4_dgv_completado.Visible = False
        '
        'id_usuario_5_dgv_completado
        '
        Me.id_usuario_5_dgv_completado.HeaderText = "Controlador 2"
        Me.id_usuario_5_dgv_completado.Name = "id_usuario_5_dgv_completado"
        Me.id_usuario_5_dgv_completado.ReadOnly = True
        Me.id_usuario_5_dgv_completado.Visible = False
        '
        'id_usuario_6_dgv_completado
        '
        Me.id_usuario_6_dgv_completado.HeaderText = "Corrección 2"
        Me.id_usuario_6_dgv_completado.Name = "id_usuario_6_dgv_completado"
        Me.id_usuario_6_dgv_completado.ReadOnly = True
        Me.id_usuario_6_dgv_completado.Visible = False
        '
        'fecha_asignada_dgv_completado
        '
        Me.fecha_asignada_dgv_completado.HeaderText = "Fecha Asignada"
        Me.fecha_asignada_dgv_completado.Name = "fecha_asignada_dgv_completado"
        Me.fecha_asignada_dgv_completado.ReadOnly = True
        Me.fecha_asignada_dgv_completado.Visible = False
        '
        'fecha_inicio_dgv_completado
        '
        DataGridViewCellStyle14.Format = "d"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.fecha_inicio_dgv_completado.DefaultCellStyle = DataGridViewCellStyle14
        Me.fecha_inicio_dgv_completado.HeaderText = "Fecha Inicio"
        Me.fecha_inicio_dgv_completado.Name = "fecha_inicio_dgv_completado"
        Me.fecha_inicio_dgv_completado.ReadOnly = True
        Me.fecha_inicio_dgv_completado.Visible = False
        Me.fecha_inicio_dgv_completado.Width = 70
        '
        'fecha_completado_dgv_completado
        '
        Me.fecha_completado_dgv_completado.HeaderText = "Fecha Completado"
        Me.fecha_completado_dgv_completado.Name = "fecha_completado_dgv_completado"
        Me.fecha_completado_dgv_completado.ReadOnly = True
        Me.fecha_completado_dgv_completado.Visible = False
        Me.fecha_completado_dgv_completado.Width = 70
        '
        'completado_dgv_completado
        '
        Me.completado_dgv_completado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.completado_dgv_completado.HeaderText = "Completado"
        Me.completado_dgv_completado.Name = "completado_dgv_completado"
        Me.completado_dgv_completado.ReadOnly = True
        Me.completado_dgv_completado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.completado_dgv_completado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.completado_dgv_completado.Visible = False
        Me.completado_dgv_completado.Width = 65
        '
        'Cadista_1_completado
        '
        Me.Cadista_1_completado.HeaderText = "Cadista 1"
        Me.Cadista_1_completado.Name = "Cadista_1_completado"
        Me.Cadista_1_completado.ReadOnly = True
        Me.Cadista_1_completado.Visible = False
        '
        'Controlador_1_completado
        '
        Me.Controlador_1_completado.HeaderText = "Controlador 1"
        Me.Controlador_1_completado.Name = "Controlador_1_completado"
        Me.Controlador_1_completado.ReadOnly = True
        Me.Controlador_1_completado.Visible = False
        '
        'Correccion_1_completado
        '
        Me.Correccion_1_completado.HeaderText = "Corrección 1"
        Me.Correccion_1_completado.Name = "Correccion_1_completado"
        Me.Correccion_1_completado.ReadOnly = True
        Me.Correccion_1_completado.Visible = False
        '
        'Cadista_2_completado
        '
        Me.Cadista_2_completado.HeaderText = "Cadista 2"
        Me.Cadista_2_completado.Name = "Cadista_2_completado"
        Me.Cadista_2_completado.ReadOnly = True
        Me.Cadista_2_completado.Visible = False
        '
        'Controlador_2_completado
        '
        Me.Controlador_2_completado.HeaderText = "Controlador 2"
        Me.Controlador_2_completado.Name = "Controlador_2_completado"
        Me.Controlador_2_completado.ReadOnly = True
        Me.Controlador_2_completado.Visible = False
        '
        'Correccion_2_completado
        '
        Me.Correccion_2_completado.HeaderText = "Corrección 2"
        Me.Correccion_2_completado.Name = "Correccion_2_completado"
        Me.Correccion_2_completado.ReadOnly = True
        Me.Correccion_2_completado.Visible = False
        '
        'tabEnEspera
        '
        Me.tabEnEspera.Controls.Add(Me.dgvControlEspera)
        Me.tabEnEspera.Location = New System.Drawing.Point(4, 22)
        Me.tabEnEspera.Name = "tabEnEspera"
        Me.tabEnEspera.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEnEspera.Size = New System.Drawing.Size(1614, 261)
        Me.tabEnEspera.TabIndex = 1
        Me.tabEnEspera.Text = "En espera"
        Me.tabEnEspera.UseVisualStyleBackColor = True
        '
        'dgvControlEspera
        '
        Me.dgvControlEspera.AllowUserToAddRows = False
        Me.dgvControlEspera.AllowUserToDeleteRows = False
        Me.dgvControlEspera.AllowUserToResizeRows = False
        Me.dgvControlEspera.BackgroundColor = System.Drawing.Color.Silver
        Me.dgvControlEspera.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvControlEspera.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.dgvControlEspera.ColumnHeadersHeight = 30
        Me.dgvControlEspera.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_actividad_dgv_espera, Me.id_proyecto_dgv_espera, Me.id_actividad_proyecto_dgv_espera, Me.id_control_dgv_espera, Me.id_movimiento_voz_dgv_espera, Me.completado_dgv_espera, Me.control_prod_dgv_espera, Me.control_1_dgv_espera, Me.corr_1_espera, Me.pedido_segundo_control_dgv_espera, Me.control_prod_2_dgv_espera, Me.control_2_dgv_espera, Me.corr_2_espera, Me.nombre_actividad_dgv_espera, Me.nombre_subproyecto_dgv_espera, Me.nombre_control_dgv_espera, Me.nombre_proyecto_dgv_espera, Me.id_usuario_1_dgv_espera, Me.id_usuario_2_dgv_espera, Me.id_usuario_3_dgv_espera, Me.id_usuario_4_dgv_espera, Me.id_usuario_5_dgv_espera, Me.id_usuario_6_dgv_espera, Me.fecha_asignada_dgv_espera, Me.fecha_inicio_dgv_espera, Me.fecha_completado_dgv_espera, Me.Cadista_1_Espera, Me.Controlador_1_Espera, Me.Correccion_1_espera, Me.Cadista_2_espera, Me.Controlador_2_espera, Me.Correccion_2_espera})
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Chocolate
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvControlEspera.DefaultCellStyle = DataGridViewCellStyle19
        Me.dgvControlEspera.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvControlEspera.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvControlEspera.GridColor = System.Drawing.Color.MediumBlue
        Me.dgvControlEspera.Location = New System.Drawing.Point(3, 3)
        Me.dgvControlEspera.Name = "dgvControlEspera"
        Me.dgvControlEspera.ReadOnly = True
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvControlEspera.RowHeadersDefaultCellStyle = DataGridViewCellStyle20
        Me.dgvControlEspera.RowHeadersVisible = False
        Me.dgvControlEspera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvControlEspera.ShowCellErrors = False
        Me.dgvControlEspera.ShowRowErrors = False
        Me.dgvControlEspera.Size = New System.Drawing.Size(1608, 255)
        Me.dgvControlEspera.StandardTab = True
        Me.dgvControlEspera.TabIndex = 600
        '
        'id_actividad_dgv_espera
        '
        Me.id_actividad_dgv_espera.HeaderText = "id_actividad_dgv"
        Me.id_actividad_dgv_espera.Name = "id_actividad_dgv_espera"
        Me.id_actividad_dgv_espera.ReadOnly = True
        Me.id_actividad_dgv_espera.Visible = False
        '
        'id_proyecto_dgv_espera
        '
        Me.id_proyecto_dgv_espera.HeaderText = "id_proyecto_dgv"
        Me.id_proyecto_dgv_espera.Name = "id_proyecto_dgv_espera"
        Me.id_proyecto_dgv_espera.ReadOnly = True
        Me.id_proyecto_dgv_espera.Visible = False
        '
        'id_actividad_proyecto_dgv_espera
        '
        Me.id_actividad_proyecto_dgv_espera.HeaderText = "id_actividad_proyecto_dgv"
        Me.id_actividad_proyecto_dgv_espera.Name = "id_actividad_proyecto_dgv_espera"
        Me.id_actividad_proyecto_dgv_espera.ReadOnly = True
        Me.id_actividad_proyecto_dgv_espera.Visible = False
        '
        'id_control_dgv_espera
        '
        Me.id_control_dgv_espera.HeaderText = "id_control_dgv"
        Me.id_control_dgv_espera.Name = "id_control_dgv_espera"
        Me.id_control_dgv_espera.ReadOnly = True
        Me.id_control_dgv_espera.Visible = False
        '
        'id_movimiento_voz_dgv_espera
        '
        Me.id_movimiento_voz_dgv_espera.HeaderText = "id_movimiento_voz_dgv"
        Me.id_movimiento_voz_dgv_espera.Name = "id_movimiento_voz_dgv_espera"
        Me.id_movimiento_voz_dgv_espera.ReadOnly = True
        Me.id_movimiento_voz_dgv_espera.Visible = False
        '
        'completado_dgv_espera
        '
        Me.completado_dgv_espera.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.completado_dgv_espera.HeaderText = "Completado"
        Me.completado_dgv_espera.Name = "completado_dgv_espera"
        Me.completado_dgv_espera.ReadOnly = True
        Me.completado_dgv_espera.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.completado_dgv_espera.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.completado_dgv_espera.Visible = False
        Me.completado_dgv_espera.Width = 50
        '
        'control_prod_dgv_espera
        '
        Me.control_prod_dgv_espera.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.control_prod_dgv_espera.HeaderText = "P1"
        Me.control_prod_dgv_espera.Name = "control_prod_dgv_espera"
        Me.control_prod_dgv_espera.ReadOnly = True
        Me.control_prod_dgv_espera.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.control_prod_dgv_espera.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.control_prod_dgv_espera.Visible = False
        Me.control_prod_dgv_espera.Width = 30
        '
        'control_1_dgv_espera
        '
        Me.control_1_dgv_espera.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.control_1_dgv_espera.HeaderText = "Ctrl 1"
        Me.control_1_dgv_espera.Name = "control_1_dgv_espera"
        Me.control_1_dgv_espera.ReadOnly = True
        Me.control_1_dgv_espera.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.control_1_dgv_espera.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.control_1_dgv_espera.Visible = False
        Me.control_1_dgv_espera.Width = 50
        '
        'corr_1_espera
        '
        Me.corr_1_espera.HeaderText = "Corr 1"
        Me.corr_1_espera.Name = "corr_1_espera"
        Me.corr_1_espera.ReadOnly = True
        Me.corr_1_espera.Visible = False
        Me.corr_1_espera.Width = 50
        '
        'pedido_segundo_control_dgv_espera
        '
        Me.pedido_segundo_control_dgv_espera.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.pedido_segundo_control_dgv_espera.HeaderText = "P2C"
        Me.pedido_segundo_control_dgv_espera.Name = "pedido_segundo_control_dgv_espera"
        Me.pedido_segundo_control_dgv_espera.ReadOnly = True
        Me.pedido_segundo_control_dgv_espera.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.pedido_segundo_control_dgv_espera.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.pedido_segundo_control_dgv_espera.Visible = False
        Me.pedido_segundo_control_dgv_espera.Width = 30
        '
        'control_prod_2_dgv_espera
        '
        Me.control_prod_2_dgv_espera.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.control_prod_2_dgv_espera.HeaderText = "P2"
        Me.control_prod_2_dgv_espera.Name = "control_prod_2_dgv_espera"
        Me.control_prod_2_dgv_espera.ReadOnly = True
        Me.control_prod_2_dgv_espera.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.control_prod_2_dgv_espera.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.control_prod_2_dgv_espera.Visible = False
        Me.control_prod_2_dgv_espera.Width = 30
        '
        'control_2_dgv_espera
        '
        Me.control_2_dgv_espera.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.control_2_dgv_espera.HeaderText = "Ctrl 2"
        Me.control_2_dgv_espera.Name = "control_2_dgv_espera"
        Me.control_2_dgv_espera.ReadOnly = True
        Me.control_2_dgv_espera.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.control_2_dgv_espera.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.control_2_dgv_espera.Visible = False
        Me.control_2_dgv_espera.Width = 50
        '
        'corr_2_espera
        '
        Me.corr_2_espera.HeaderText = "Corr 2"
        Me.corr_2_espera.Name = "corr_2_espera"
        Me.corr_2_espera.ReadOnly = True
        Me.corr_2_espera.Visible = False
        Me.corr_2_espera.Width = 50
        '
        'nombre_actividad_dgv_espera
        '
        Me.nombre_actividad_dgv_espera.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.nombre_actividad_dgv_espera.HeaderText = "Actividad"
        Me.nombre_actividad_dgv_espera.Name = "nombre_actividad_dgv_espera"
        Me.nombre_actividad_dgv_espera.ReadOnly = True
        Me.nombre_actividad_dgv_espera.Width = 150
        '
        'nombre_subproyecto_dgv_espera
        '
        Me.nombre_subproyecto_dgv_espera.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.nombre_subproyecto_dgv_espera.HeaderText = "Path"
        Me.nombre_subproyecto_dgv_espera.Name = "nombre_subproyecto_dgv_espera"
        Me.nombre_subproyecto_dgv_espera.ReadOnly = True
        Me.nombre_subproyecto_dgv_espera.Width = 300
        '
        'nombre_control_dgv_espera
        '
        Me.nombre_control_dgv_espera.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.nombre_control_dgv_espera.HeaderText = "Control"
        Me.nombre_control_dgv_espera.Name = "nombre_control_dgv_espera"
        Me.nombre_control_dgv_espera.ReadOnly = True
        Me.nombre_control_dgv_espera.Width = 300
        '
        'nombre_proyecto_dgv_espera
        '
        Me.nombre_proyecto_dgv_espera.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.nombre_proyecto_dgv_espera.HeaderText = "Proyecto"
        Me.nombre_proyecto_dgv_espera.Name = "nombre_proyecto_dgv_espera"
        Me.nombre_proyecto_dgv_espera.ReadOnly = True
        Me.nombre_proyecto_dgv_espera.Width = 200
        '
        'id_usuario_1_dgv_espera
        '
        Me.id_usuario_1_dgv_espera.HeaderText = "Producción 1"
        Me.id_usuario_1_dgv_espera.Name = "id_usuario_1_dgv_espera"
        Me.id_usuario_1_dgv_espera.ReadOnly = True
        Me.id_usuario_1_dgv_espera.Visible = False
        '
        'id_usuario_2_dgv_espera
        '
        Me.id_usuario_2_dgv_espera.HeaderText = "Controlador 1"
        Me.id_usuario_2_dgv_espera.Name = "id_usuario_2_dgv_espera"
        Me.id_usuario_2_dgv_espera.ReadOnly = True
        Me.id_usuario_2_dgv_espera.Visible = False
        '
        'id_usuario_3_dgv_espera
        '
        Me.id_usuario_3_dgv_espera.HeaderText = "Corrección 1"
        Me.id_usuario_3_dgv_espera.Name = "id_usuario_3_dgv_espera"
        Me.id_usuario_3_dgv_espera.ReadOnly = True
        Me.id_usuario_3_dgv_espera.Visible = False
        '
        'id_usuario_4_dgv_espera
        '
        Me.id_usuario_4_dgv_espera.HeaderText = "Producción 2"
        Me.id_usuario_4_dgv_espera.Name = "id_usuario_4_dgv_espera"
        Me.id_usuario_4_dgv_espera.ReadOnly = True
        Me.id_usuario_4_dgv_espera.Visible = False
        '
        'id_usuario_5_dgv_espera
        '
        Me.id_usuario_5_dgv_espera.HeaderText = "Controlador 2"
        Me.id_usuario_5_dgv_espera.Name = "id_usuario_5_dgv_espera"
        Me.id_usuario_5_dgv_espera.ReadOnly = True
        Me.id_usuario_5_dgv_espera.Visible = False
        '
        'id_usuario_6_dgv_espera
        '
        Me.id_usuario_6_dgv_espera.HeaderText = "Corrección 2"
        Me.id_usuario_6_dgv_espera.Name = "id_usuario_6_dgv_espera"
        Me.id_usuario_6_dgv_espera.ReadOnly = True
        Me.id_usuario_6_dgv_espera.Visible = False
        '
        'fecha_asignada_dgv_espera
        '
        Me.fecha_asignada_dgv_espera.HeaderText = "Fecha Asignada"
        Me.fecha_asignada_dgv_espera.Name = "fecha_asignada_dgv_espera"
        Me.fecha_asignada_dgv_espera.ReadOnly = True
        Me.fecha_asignada_dgv_espera.Visible = False
        '
        'fecha_inicio_dgv_espera
        '
        Me.fecha_inicio_dgv_espera.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle18.Format = "d"
        DataGridViewCellStyle18.NullValue = Nothing
        Me.fecha_inicio_dgv_espera.DefaultCellStyle = DataGridViewCellStyle18
        Me.fecha_inicio_dgv_espera.HeaderText = "Fecha Inicio"
        Me.fecha_inicio_dgv_espera.Name = "fecha_inicio_dgv_espera"
        Me.fecha_inicio_dgv_espera.ReadOnly = True
        Me.fecha_inicio_dgv_espera.Visible = False
        Me.fecha_inicio_dgv_espera.Width = 98
        '
        'fecha_completado_dgv_espera
        '
        Me.fecha_completado_dgv_espera.HeaderText = "Fecha Completado"
        Me.fecha_completado_dgv_espera.Name = "fecha_completado_dgv_espera"
        Me.fecha_completado_dgv_espera.ReadOnly = True
        Me.fecha_completado_dgv_espera.Visible = False
        '
        'Cadista_1_Espera
        '
        Me.Cadista_1_Espera.HeaderText = "Cadista 1"
        Me.Cadista_1_Espera.Name = "Cadista_1_Espera"
        Me.Cadista_1_Espera.ReadOnly = True
        Me.Cadista_1_Espera.Visible = False
        '
        'Controlador_1_Espera
        '
        Me.Controlador_1_Espera.HeaderText = "Controlador 1"
        Me.Controlador_1_Espera.Name = "Controlador_1_Espera"
        Me.Controlador_1_Espera.ReadOnly = True
        Me.Controlador_1_Espera.Visible = False
        '
        'Correccion_1_espera
        '
        Me.Correccion_1_espera.HeaderText = "Corrección 1"
        Me.Correccion_1_espera.Name = "Correccion_1_espera"
        Me.Correccion_1_espera.ReadOnly = True
        Me.Correccion_1_espera.Visible = False
        '
        'Cadista_2_espera
        '
        Me.Cadista_2_espera.HeaderText = "Cadista 2"
        Me.Cadista_2_espera.Name = "Cadista_2_espera"
        Me.Cadista_2_espera.ReadOnly = True
        Me.Cadista_2_espera.Visible = False
        '
        'Controlador_2_espera
        '
        Me.Controlador_2_espera.HeaderText = "Controlador 2"
        Me.Controlador_2_espera.Name = "Controlador_2_espera"
        Me.Controlador_2_espera.ReadOnly = True
        Me.Controlador_2_espera.Visible = False
        '
        'Correccion_2_espera
        '
        Me.Correccion_2_espera.HeaderText = "Corrección 2"
        Me.Correccion_2_espera.Name = "Correccion_2_espera"
        Me.Correccion_2_espera.ReadOnly = True
        Me.Correccion_2_espera.Visible = False
        '
        'tabMisControles
        '
        Me.tabMisControles.Controls.Add(Me.dgvControl)
        Me.tabMisControles.Controls.Add(Me.Label11)
        Me.tabMisControles.Controls.Add(Me.lblid_pk)
        Me.tabMisControles.Controls.Add(Me.Label9)
        Me.tabMisControles.Controls.Add(Me.lblid_pk_actividad)
        Me.tabMisControles.Controls.Add(Me.lblid_pk_proyecto)
        Me.tabMisControles.Controls.Add(Me.Label13)
        Me.tabMisControles.Controls.Add(Me.Label10)
        Me.tabMisControles.Controls.Add(Me.lblid_movimiento_voz)
        Me.tabMisControles.Controls.Add(Me.lblid_control)
        Me.tabMisControles.Controls.Add(Me.Label12)
        Me.tabMisControles.Location = New System.Drawing.Point(4, 22)
        Me.tabMisControles.Name = "tabMisControles"
        Me.tabMisControles.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMisControles.Size = New System.Drawing.Size(1246, 261)
        Me.tabMisControles.TabIndex = 0
        Me.tabMisControles.Text = "Controles pendientes"
        Me.tabMisControles.UseVisualStyleBackColor = True
        '
        'dgvControl
        '
        Me.dgvControl.AllowUserToAddRows = False
        Me.dgvControl.AllowUserToDeleteRows = False
        Me.dgvControl.AllowUserToResizeRows = False
        Me.dgvControl.BackgroundColor = System.Drawing.Color.Silver
        Me.dgvControl.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvControl.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle21
        Me.dgvControl.ColumnHeadersHeight = 30
        Me.dgvControl.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_actividad_dgv, Me.id_proyecto_dgv, Me.id_actividad_proyecto_dgv, Me.id_control_dgv, Me.id_movimiento_voz_dgv, Me.completado_dgv, Me.control_prod_dgv, Me.control_1_dgv, Me.corr_1_pendiente, Me.pedido_segundo_control_dgv, Me.control_prod_2_dgv, Me.control_2_dgv, Me.corr_2_pendiente, Me.nombre_proyecto_dgv, Me.nombre_subproyecto_dgv, Me.nombre_actividad_dgv, Me.nombre_control_dgv, Me.id_usuario_1_dgv, Me.id_usuario_2_dgv, Me.id_usuario_3_dgv, Me.id_usuario_4_dgv, Me.id_usuario_5_dgv, Me.id_usuario_6_dgv, Me.fecha_asignada_dgv, Me.fecha_inicio_dgv, Me.fecha_completado_dgv, Me.Cadista_1, Me.Controlador_1, Me.Correccion_1, Me.Cadista_2, Me.Controlador_2, Me.Correccion_2})
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle23.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.Chocolate
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvControl.DefaultCellStyle = DataGridViewCellStyle23
        Me.dgvControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvControl.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvControl.GridColor = System.Drawing.Color.MidnightBlue
        Me.dgvControl.Location = New System.Drawing.Point(3, 3)
        Me.dgvControl.Name = "dgvControl"
        Me.dgvControl.ReadOnly = True
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvControl.RowHeadersDefaultCellStyle = DataGridViewCellStyle24
        Me.dgvControl.RowHeadersVisible = False
        Me.dgvControl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvControl.ShowCellErrors = False
        Me.dgvControl.ShowRowErrors = False
        Me.dgvControl.Size = New System.Drawing.Size(1240, 255)
        Me.dgvControl.StandardTab = True
        Me.dgvControl.TabIndex = 599
        '
        'tabControles
        '
        Me.tabControles.AccessibleName = ""
        Me.tabControles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabControles.Controls.Add(Me.tabMisControles)
        Me.tabControles.Controls.Add(Me.tabEnEspera)
        Me.tabControles.Controls.Add(Me.tabCompletados)
        Me.tabControles.Location = New System.Drawing.Point(0, 23)
        Me.tabControles.Name = "tabControles"
        Me.tabControles.SelectedIndex = 0
        Me.tabControles.Size = New System.Drawing.Size(1254, 287)
        Me.tabControles.TabIndex = 660
        '
        'Background_pdf
        '
        '
        'TimerLogueo
        '
        Me.TimerLogueo.Interval = 1000
        '
        'cms_anotaciones
        '
        Me.cms_anotaciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_anotaciones_copiar})
        Me.cms_anotaciones.Name = "cms_anotaciones"
        Me.cms_anotaciones.Size = New System.Drawing.Size(110, 26)
        '
        'ts_anotaciones_copiar
        '
        Me.ts_anotaciones_copiar.Name = "ts_anotaciones_copiar"
        Me.ts_anotaciones_copiar.Size = New System.Drawing.Size(109, 22)
        Me.ts_anotaciones_copiar.Text = "Copiar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox16)
        Me.GroupBox1.Controls.Add(Me.tabControles)
        Me.GroupBox1.Controls.Add(Me.CheckBox3)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.chk2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.chk1)
        Me.GroupBox1.Controls.Add(Me.chkP)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1254, 377)
        Me.GroupBox1.TabIndex = 750
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Controles realizados"
        '
        'GroupBox16
        '
        Me.GroupBox16.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox16.Controls.Add(Me.TextBox1)
        Me.GroupBox16.Controls.Add(Me.lbl_proveedor)
        Me.GroupBox16.Controls.Add(Me.lbl_control)
        Me.GroupBox16.Controls.Add(Me.TextBox27)
        Me.GroupBox16.Controls.Add(Me.lbl_correccion)
        Me.GroupBox16.Controls.Add(Me.TextBox26)
        Me.GroupBox16.Controls.Add(Me.lbl_produccion)
        Me.GroupBox16.Controls.Add(Me.TextBox25)
        Me.GroupBox16.Location = New System.Drawing.Point(3, 318)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(1612, 53)
        Me.GroupBox16.TabIndex = 661
        Me.GroupBox16.TabStop = False
        Me.GroupBox16.Text = "Leyenda"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.Gray
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox1.Location = New System.Drawing.Point(413, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(24, 20)
        Me.TextBox1.TabIndex = 7
        Me.TextBox1.TabStop = False
        '
        'lbl_proveedor
        '
        Me.lbl_proveedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_proveedor.AutoSize = True
        Me.lbl_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_proveedor.Location = New System.Drawing.Point(443, 26)
        Me.lbl_proveedor.Name = "lbl_proveedor"
        Me.lbl_proveedor.Size = New System.Drawing.Size(65, 13)
        Me.lbl_proveedor.TabIndex = 6
        Me.lbl_proveedor.Text = "Proveedor"
        '
        'lbl_control
        '
        Me.lbl_control.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_control.AutoSize = True
        Me.lbl_control.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_control.Location = New System.Drawing.Point(176, 26)
        Me.lbl_control.Name = "lbl_control"
        Me.lbl_control.Size = New System.Drawing.Size(47, 13)
        Me.lbl_control.TabIndex = 5
        Me.lbl_control.Text = "Control"
        '
        'TextBox27
        '
        Me.TextBox27.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox27.BackColor = System.Drawing.Color.RosyBrown
        Me.TextBox27.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox27.Location = New System.Drawing.Point(267, 19)
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.ReadOnly = True
        Me.TextBox27.Size = New System.Drawing.Size(24, 20)
        Me.TextBox27.TabIndex = 4
        Me.TextBox27.TabStop = False
        '
        'lbl_correccion
        '
        Me.lbl_correccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_correccion.AutoSize = True
        Me.lbl_correccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_correccion.Location = New System.Drawing.Point(297, 26)
        Me.lbl_correccion.Name = "lbl_correccion"
        Me.lbl_correccion.Size = New System.Drawing.Size(68, 13)
        Me.lbl_correccion.TabIndex = 3
        Me.lbl_correccion.Text = "Corrección"
        '
        'TextBox26
        '
        Me.TextBox26.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox26.BackColor = System.Drawing.Color.LightBlue
        Me.TextBox26.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox26.Location = New System.Drawing.Point(146, 19)
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.ReadOnly = True
        Me.TextBox26.Size = New System.Drawing.Size(24, 20)
        Me.TextBox26.TabIndex = 2
        Me.TextBox26.TabStop = False
        '
        'lbl_produccion
        '
        Me.lbl_produccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_produccion.AutoSize = True
        Me.lbl_produccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_produccion.Location = New System.Drawing.Point(36, 26)
        Me.lbl_produccion.Name = "lbl_produccion"
        Me.lbl_produccion.Size = New System.Drawing.Size(71, 13)
        Me.lbl_produccion.TabIndex = 1
        Me.lbl_produccion.Text = "Producción"
        '
        'TextBox25
        '
        Me.TextBox25.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox25.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox25.Location = New System.Drawing.Point(6, 19)
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.ReadOnly = True
        Me.TextBox25.Size = New System.Drawing.Size(24, 20)
        Me.TextBox25.TabIndex = 0
        Me.TextBox25.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tab_controles)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1268, 741)
        Me.TabControl1.TabIndex = 751
        '
        'tab_controles
        '
        Me.tab_controles.Controls.Add(Me.SplitContainer5)
        Me.tab_controles.Controls.Add(Me.txtEstadoControl)
        Me.tab_controles.Controls.Add(Me.btnRefrescarControl)
        Me.tab_controles.Location = New System.Drawing.Point(4, 22)
        Me.tab_controles.Name = "tab_controles"
        Me.tab_controles.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_controles.Size = New System.Drawing.Size(1260, 715)
        Me.tab_controles.TabIndex = 0
        Me.tab_controles.Text = "Controles"
        Me.tab_controles.UseVisualStyleBackColor = True
        '
        'SplitContainer5
        '
        Me.SplitContainer5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer5.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer5.Name = "SplitContainer5"
        Me.SplitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer5.Panel1
        '
        Me.SplitContainer5.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer5.Panel2
        '
        Me.SplitContainer5.Panel2.Controls.Add(Me.Label30)
        Me.SplitContainer5.Panel2.Controls.Add(Me.grp_estado_control)
        Me.SplitContainer5.Panel2.Controls.Add(Me.btnInforme)
        Me.SplitContainer5.Panel2.Controls.Add(Me.btnRealizarControl)
        Me.SplitContainer5.Panel2.Controls.Add(Me.chk_completado_control)
        Me.SplitContainer5.Panel2.Controls.Add(Me.grp_propiedades_control)
        Me.SplitContainer5.Panel2.Controls.Add(Me.grp_fechas_control)
        Me.SplitContainer5.Panel2.Controls.Add(Me.txt_control_control)
        Me.SplitContainer5.Size = New System.Drawing.Size(1254, 709)
        Me.SplitContainer5.SplitterDistance = 377
        Me.SplitContainer5.TabIndex = 764
        '
        'Label30
        '
        Me.Label30.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label30.AutoSize = True
        Me.Label30.Enabled = False
        Me.Label30.Location = New System.Drawing.Point(7, 17)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(43, 13)
        Me.Label30.TabIndex = 799
        Me.Label30.Text = "Control:"
        '
        'grp_estado_control
        '
        Me.grp_estado_control.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_estado_control.Controls.Add(Me.chk_correccion_2_control)
        Me.grp_estado_control.Controls.Add(Me.chk_control_2_control)
        Me.grp_estado_control.Controls.Add(Me.chk_produccion_2_control)
        Me.grp_estado_control.Controls.Add(Me.chk_correccion_1_control)
        Me.grp_estado_control.Controls.Add(Me.GroupBox14)
        Me.grp_estado_control.Controls.Add(Me.chk_control_1_control)
        Me.grp_estado_control.Controls.Add(Me.chk_produccion_control)
        Me.grp_estado_control.Controls.Add(Me.GroupBox13)
        Me.grp_estado_control.Controls.Add(Me.txt_correccion_2_control)
        Me.grp_estado_control.Controls.Add(Me.txt_control_2_control)
        Me.grp_estado_control.Controls.Add(Me.Label28)
        Me.grp_estado_control.Controls.Add(Me.Label29)
        Me.grp_estado_control.Controls.Add(Me.txt_produccion_2_control)
        Me.grp_estado_control.Controls.Add(Me.txt_correccion_1_control)
        Me.grp_estado_control.Controls.Add(Me.txt_control_1_control)
        Me.grp_estado_control.Controls.Add(Me.txt_produccion_control)
        Me.grp_estado_control.Controls.Add(Me.Label24)
        Me.grp_estado_control.Controls.Add(Me.Label25)
        Me.grp_estado_control.Controls.Add(Me.Label26)
        Me.grp_estado_control.Controls.Add(Me.Label27)
        Me.grp_estado_control.Enabled = False
        Me.grp_estado_control.Location = New System.Drawing.Point(361, 43)
        Me.grp_estado_control.Name = "grp_estado_control"
        Me.grp_estado_control.Size = New System.Drawing.Size(890, 203)
        Me.grp_estado_control.TabIndex = 798
        Me.grp_estado_control.TabStop = False
        Me.grp_estado_control.Text = "Estado"
        '
        'chk_correccion_2_control
        '
        Me.chk_correccion_2_control.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chk_correccion_2_control.AutoCheck = False
        Me.chk_correccion_2_control.AutoSize = True
        Me.chk_correccion_2_control.Location = New System.Drawing.Point(1077, 169)
        Me.chk_correccion_2_control.Name = "chk_correccion_2_control"
        Me.chk_correccion_2_control.Size = New System.Drawing.Size(15, 14)
        Me.chk_correccion_2_control.TabIndex = 799
        Me.chk_correccion_2_control.UseVisualStyleBackColor = True
        '
        'chk_control_2_control
        '
        Me.chk_control_2_control.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chk_control_2_control.AutoCheck = False
        Me.chk_control_2_control.AutoSize = True
        Me.chk_control_2_control.Location = New System.Drawing.Point(1077, 143)
        Me.chk_control_2_control.Name = "chk_control_2_control"
        Me.chk_control_2_control.Size = New System.Drawing.Size(15, 14)
        Me.chk_control_2_control.TabIndex = 16
        Me.chk_control_2_control.UseVisualStyleBackColor = True
        '
        'chk_produccion_2_control
        '
        Me.chk_produccion_2_control.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chk_produccion_2_control.AutoCheck = False
        Me.chk_produccion_2_control.AutoSize = True
        Me.chk_produccion_2_control.Location = New System.Drawing.Point(1077, 117)
        Me.chk_produccion_2_control.Name = "chk_produccion_2_control"
        Me.chk_produccion_2_control.Size = New System.Drawing.Size(15, 14)
        Me.chk_produccion_2_control.TabIndex = 15
        Me.chk_produccion_2_control.UseVisualStyleBackColor = True
        '
        'chk_correccion_1_control
        '
        Me.chk_correccion_1_control.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chk_correccion_1_control.AutoCheck = False
        Me.chk_correccion_1_control.AutoSize = True
        Me.chk_correccion_1_control.Location = New System.Drawing.Point(1077, 91)
        Me.chk_correccion_1_control.Name = "chk_correccion_1_control"
        Me.chk_correccion_1_control.Size = New System.Drawing.Size(15, 14)
        Me.chk_correccion_1_control.TabIndex = 14
        Me.chk_correccion_1_control.UseVisualStyleBackColor = True
        '
        'GroupBox14
        '
        Me.GroupBox14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox14.Controls.Add(Me.TextBox15)
        Me.GroupBox14.Controls.Add(Me.TextBox16)
        Me.GroupBox14.Controls.Add(Me.TextBox17)
        Me.GroupBox14.Controls.Add(Me.TextBox18)
        Me.GroupBox14.Controls.Add(Me.Label52)
        Me.GroupBox14.Controls.Add(Me.Label53)
        Me.GroupBox14.Controls.Add(Me.Label54)
        Me.GroupBox14.Controls.Add(Me.Label55)
        Me.GroupBox14.Enabled = False
        Me.GroupBox14.Location = New System.Drawing.Point(-351, 0)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(345, 128)
        Me.GroupBox14.TabIndex = 797
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "Propiedades"
        '
        'TextBox15
        '
        Me.TextBox15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox15.Location = New System.Drawing.Point(90, 96)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.ReadOnly = True
        Me.TextBox15.Size = New System.Drawing.Size(246, 20)
        Me.TextBox15.TabIndex = 7
        '
        'TextBox16
        '
        Me.TextBox16.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox16.Location = New System.Drawing.Point(90, 70)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.ReadOnly = True
        Me.TextBox16.Size = New System.Drawing.Size(246, 20)
        Me.TextBox16.TabIndex = 6
        '
        'TextBox17
        '
        Me.TextBox17.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox17.Location = New System.Drawing.Point(88, 44)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.ReadOnly = True
        Me.TextBox17.Size = New System.Drawing.Size(246, 20)
        Me.TextBox17.TabIndex = 5
        '
        'TextBox18
        '
        Me.TextBox18.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox18.Location = New System.Drawing.Point(88, 18)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.ReadOnly = True
        Me.TextBox18.Size = New System.Drawing.Size(246, 20)
        Me.TextBox18.TabIndex = 4
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(30, 99)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(54, 13)
        Me.Label52.TabIndex = 3
        Me.Label52.Text = "Actividad:"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(14, 73)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(70, 13)
        Me.Label53.TabIndex = 2
        Me.Label53.Text = "Subproyecto:"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(30, 47)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(52, 13)
        Me.Label54.TabIndex = 1
        Me.Label54.Text = "Proyecto:"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(40, 21)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(42, 13)
        Me.Label55.TabIndex = 0
        Me.Label55.Text = "Cliente:"
        '
        'chk_control_1_control
        '
        Me.chk_control_1_control.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chk_control_1_control.AutoCheck = False
        Me.chk_control_1_control.AutoSize = True
        Me.chk_control_1_control.Location = New System.Drawing.Point(1076, 65)
        Me.chk_control_1_control.Name = "chk_control_1_control"
        Me.chk_control_1_control.Size = New System.Drawing.Size(15, 14)
        Me.chk_control_1_control.TabIndex = 13
        Me.chk_control_1_control.UseVisualStyleBackColor = True
        '
        'chk_produccion_control
        '
        Me.chk_produccion_control.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chk_produccion_control.AutoCheck = False
        Me.chk_produccion_control.AutoSize = True
        Me.chk_produccion_control.Location = New System.Drawing.Point(1077, 39)
        Me.chk_produccion_control.Name = "chk_produccion_control"
        Me.chk_produccion_control.Size = New System.Drawing.Size(15, 14)
        Me.chk_produccion_control.TabIndex = 12
        Me.chk_produccion_control.UseVisualStyleBackColor = True
        '
        'GroupBox13
        '
        Me.GroupBox13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox13.Controls.Add(Me.TextBox13)
        Me.GroupBox13.Controls.Add(Me.TextBox14)
        Me.GroupBox13.Controls.Add(Me.Label50)
        Me.GroupBox13.Controls.Add(Me.Label51)
        Me.GroupBox13.Enabled = False
        Me.GroupBox13.Location = New System.Drawing.Point(-354, 134)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(345, 69)
        Me.GroupBox13.TabIndex = 801
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Fechas"
        '
        'TextBox13
        '
        Me.TextBox13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox13.Location = New System.Drawing.Point(134, 37)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.ReadOnly = True
        Me.TextBox13.Size = New System.Drawing.Size(200, 20)
        Me.TextBox13.TabIndex = 5
        '
        'TextBox14
        '
        Me.TextBox14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox14.Location = New System.Drawing.Point(134, 11)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.ReadOnly = True
        Me.TextBox14.Size = New System.Drawing.Size(200, 20)
        Me.TextBox14.TabIndex = 4
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(30, 40)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(98, 13)
        Me.Label50.TabIndex = 1
        Me.Label50.Text = "Fecha completado:"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(60, 14)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(68, 13)
        Me.Label51.TabIndex = 0
        Me.Label51.Text = "Fecha Inicio:"
        '
        'txt_correccion_2_control
        '
        Me.txt_correccion_2_control.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_correccion_2_control.Location = New System.Drawing.Point(88, 166)
        Me.txt_correccion_2_control.Name = "txt_correccion_2_control"
        Me.txt_correccion_2_control.ReadOnly = True
        Me.txt_correccion_2_control.Size = New System.Drawing.Size(796, 20)
        Me.txt_correccion_2_control.TabIndex = 11
        '
        'txt_control_2_control
        '
        Me.txt_control_2_control.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_control_2_control.Location = New System.Drawing.Point(88, 140)
        Me.txt_control_2_control.Name = "txt_control_2_control"
        Me.txt_control_2_control.ReadOnly = True
        Me.txt_control_2_control.Size = New System.Drawing.Size(796, 20)
        Me.txt_control_2_control.TabIndex = 10
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(1, 169)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(81, 13)
        Me.Label28.TabIndex = 9
        Me.Label28.Text = "2da corrección:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(19, 143)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(63, 13)
        Me.Label29.TabIndex = 8
        Me.Label29.Text = "2do control:"
        '
        'txt_produccion_2_control
        '
        Me.txt_produccion_2_control.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_produccion_2_control.Location = New System.Drawing.Point(88, 114)
        Me.txt_produccion_2_control.Name = "txt_produccion_2_control"
        Me.txt_produccion_2_control.ReadOnly = True
        Me.txt_produccion_2_control.Size = New System.Drawing.Size(796, 20)
        Me.txt_produccion_2_control.TabIndex = 7
        '
        'txt_correccion_1_control
        '
        Me.txt_correccion_1_control.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_correccion_1_control.Location = New System.Drawing.Point(88, 88)
        Me.txt_correccion_1_control.Name = "txt_correccion_1_control"
        Me.txt_correccion_1_control.ReadOnly = True
        Me.txt_correccion_1_control.Size = New System.Drawing.Size(796, 20)
        Me.txt_correccion_1_control.TabIndex = 6
        '
        'txt_control_1_control
        '
        Me.txt_control_1_control.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_control_1_control.Location = New System.Drawing.Point(88, 62)
        Me.txt_control_1_control.Name = "txt_control_1_control"
        Me.txt_control_1_control.ReadOnly = True
        Me.txt_control_1_control.Size = New System.Drawing.Size(796, 20)
        Me.txt_control_1_control.TabIndex = 5
        '
        'txt_produccion_control
        '
        Me.txt_produccion_control.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_produccion_control.Location = New System.Drawing.Point(88, 36)
        Me.txt_produccion_control.Name = "txt_produccion_control"
        Me.txt_produccion_control.ReadOnly = True
        Me.txt_produccion_control.Size = New System.Drawing.Size(796, 20)
        Me.txt_produccion_control.TabIndex = 4
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(9, 117)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(73, 13)
        Me.Label24.TabIndex = 3
        Me.Label24.Text = "2 Producción:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(4, 91)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(78, 13)
        Me.Label25.TabIndex = 2
        Me.Label25.Text = "1ra corrección:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(22, 65)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(60, 13)
        Me.Label26.TabIndex = 1
        Me.Label26.Text = "1er control:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(18, 39)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(64, 13)
        Me.Label27.TabIndex = 0
        Me.Label27.Text = "Producción:"
        '
        'chk_completado_control
        '
        Me.chk_completado_control.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chk_completado_control.AutoCheck = False
        Me.chk_completado_control.AutoSize = True
        Me.chk_completado_control.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_completado_control.Location = New System.Drawing.Point(22, 279)
        Me.chk_completado_control.Name = "chk_completado_control"
        Me.chk_completado_control.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chk_completado_control.Size = New System.Drawing.Size(111, 20)
        Me.chk_completado_control.TabIndex = 802
        Me.chk_completado_control.Text = "Completado"
        Me.chk_completado_control.UseVisualStyleBackColor = True
        '
        'grp_propiedades_control
        '
        Me.grp_propiedades_control.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grp_propiedades_control.Controls.Add(Me.txt_actividad_control)
        Me.grp_propiedades_control.Controls.Add(Me.txt_subproyecto_control)
        Me.grp_propiedades_control.Controls.Add(Me.txt_proyecto_control)
        Me.grp_propiedades_control.Controls.Add(Me.txt_cliente_control)
        Me.grp_propiedades_control.Controls.Add(Me.Label2)
        Me.grp_propiedades_control.Controls.Add(Me.Label21)
        Me.grp_propiedades_control.Controls.Add(Me.Label22)
        Me.grp_propiedades_control.Controls.Add(Me.Label23)
        Me.grp_propiedades_control.Enabled = False
        Me.grp_propiedades_control.Location = New System.Drawing.Point(10, 43)
        Me.grp_propiedades_control.Name = "grp_propiedades_control"
        Me.grp_propiedades_control.Size = New System.Drawing.Size(345, 128)
        Me.grp_propiedades_control.TabIndex = 797
        Me.grp_propiedades_control.TabStop = False
        Me.grp_propiedades_control.Text = "Propiedades"
        '
        'txt_actividad_control
        '
        Me.txt_actividad_control.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_actividad_control.Location = New System.Drawing.Point(90, 96)
        Me.txt_actividad_control.Name = "txt_actividad_control"
        Me.txt_actividad_control.ReadOnly = True
        Me.txt_actividad_control.Size = New System.Drawing.Size(246, 20)
        Me.txt_actividad_control.TabIndex = 7
        '
        'txt_subproyecto_control
        '
        Me.txt_subproyecto_control.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_subproyecto_control.Location = New System.Drawing.Point(90, 70)
        Me.txt_subproyecto_control.Name = "txt_subproyecto_control"
        Me.txt_subproyecto_control.ReadOnly = True
        Me.txt_subproyecto_control.Size = New System.Drawing.Size(246, 20)
        Me.txt_subproyecto_control.TabIndex = 6
        '
        'txt_proyecto_control
        '
        Me.txt_proyecto_control.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_proyecto_control.Location = New System.Drawing.Point(88, 44)
        Me.txt_proyecto_control.Name = "txt_proyecto_control"
        Me.txt_proyecto_control.ReadOnly = True
        Me.txt_proyecto_control.Size = New System.Drawing.Size(246, 20)
        Me.txt_proyecto_control.TabIndex = 5
        '
        'txt_cliente_control
        '
        Me.txt_cliente_control.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_cliente_control.Location = New System.Drawing.Point(88, 18)
        Me.txt_cliente_control.Name = "txt_cliente_control"
        Me.txt_cliente_control.ReadOnly = True
        Me.txt_cliente_control.Size = New System.Drawing.Size(246, 20)
        Me.txt_cliente_control.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Actividad:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(14, 73)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(70, 13)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "Subproyecto:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(30, 47)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(52, 13)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "Proyecto:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(40, 21)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(42, 13)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "Cliente:"
        '
        'grp_fechas_control
        '
        Me.grp_fechas_control.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grp_fechas_control.Controls.Add(Me.txt_fecha_completado_control)
        Me.grp_fechas_control.Controls.Add(Me.txt_fecha_inicio_control)
        Me.grp_fechas_control.Controls.Add(Me.Label33)
        Me.grp_fechas_control.Controls.Add(Me.Label34)
        Me.grp_fechas_control.Enabled = False
        Me.grp_fechas_control.Location = New System.Drawing.Point(7, 177)
        Me.grp_fechas_control.Name = "grp_fechas_control"
        Me.grp_fechas_control.Size = New System.Drawing.Size(345, 69)
        Me.grp_fechas_control.TabIndex = 801
        Me.grp_fechas_control.TabStop = False
        Me.grp_fechas_control.Text = "Fechas"
        '
        'txt_fecha_completado_control
        '
        Me.txt_fecha_completado_control.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_fecha_completado_control.Location = New System.Drawing.Point(134, 37)
        Me.txt_fecha_completado_control.Name = "txt_fecha_completado_control"
        Me.txt_fecha_completado_control.ReadOnly = True
        Me.txt_fecha_completado_control.Size = New System.Drawing.Size(200, 20)
        Me.txt_fecha_completado_control.TabIndex = 5
        '
        'txt_fecha_inicio_control
        '
        Me.txt_fecha_inicio_control.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_fecha_inicio_control.Location = New System.Drawing.Point(134, 11)
        Me.txt_fecha_inicio_control.Name = "txt_fecha_inicio_control"
        Me.txt_fecha_inicio_control.ReadOnly = True
        Me.txt_fecha_inicio_control.Size = New System.Drawing.Size(200, 20)
        Me.txt_fecha_inicio_control.TabIndex = 4
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(30, 40)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(98, 13)
        Me.Label33.TabIndex = 1
        Me.Label33.Text = "Fecha completado:"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(60, 14)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(68, 13)
        Me.Label34.TabIndex = 0
        Me.Label34.Text = "Fecha Inicio:"
        '
        'txt_control_control
        '
        Me.txt_control_control.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_control_control.Enabled = False
        Me.txt_control_control.Location = New System.Drawing.Point(56, 14)
        Me.txt_control_control.Name = "txt_control_control"
        Me.txt_control_control.ReadOnly = True
        Me.txt_control_control.Size = New System.Drawing.Size(1189, 20)
        Me.txt_control_control.TabIndex = 800
        '
        'btnInforme
        '
        Me.btnInforme.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInforme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInforme.Enabled = False
        Me.btnInforme.Image = Global.DescarProveedores.My.Resources.Resources.adobe_pdf
        Me.btnInforme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInforme.Location = New System.Drawing.Point(989, 259)
        Me.btnInforme.Name = "btnInforme"
        Me.btnInforme.Size = New System.Drawing.Size(127, 58)
        Me.btnInforme.TabIndex = 1
        Me.btnInforme.Text = "Ver checklist"
        Me.btnInforme.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnInforme.UseVisualStyleBackColor = True
        '
        'btnRealizarControl
        '
        Me.btnRealizarControl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRealizarControl.Enabled = False
        Me.btnRealizarControl.Image = Global.DescarProveedores.My.Resources.Resources.checklist_1_1
        Me.btnRealizarControl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRealizarControl.Location = New System.Drawing.Point(1122, 259)
        Me.btnRealizarControl.Name = "btnRealizarControl"
        Me.btnRealizarControl.Size = New System.Drawing.Size(127, 58)
        Me.btnRealizarControl.TabIndex = 621
        Me.btnRealizarControl.Text = "Realizar control"
        Me.btnRealizarControl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnRefrescarControl
        '
        Me.btnRefrescarControl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefrescarControl.Image = CType(resources.GetObject("btnRefrescarControl.Image"), System.Drawing.Image)
        Me.btnRefrescarControl.Location = New System.Drawing.Point(1896, 11)
        Me.btnRefrescarControl.Name = "btnRefrescarControl"
        Me.btnRefrescarControl.Size = New System.Drawing.Size(33, 33)
        Me.btnRefrescarControl.TabIndex = 649
        Me.btnRefrescarControl.UseVisualStyleBackColor = True
        '
        'id_actividad_dgv
        '
        Me.id_actividad_dgv.HeaderText = "id_actividad_dgv"
        Me.id_actividad_dgv.Name = "id_actividad_dgv"
        Me.id_actividad_dgv.ReadOnly = True
        Me.id_actividad_dgv.Visible = False
        '
        'id_proyecto_dgv
        '
        Me.id_proyecto_dgv.HeaderText = "id_proyecto_dgv"
        Me.id_proyecto_dgv.Name = "id_proyecto_dgv"
        Me.id_proyecto_dgv.ReadOnly = True
        Me.id_proyecto_dgv.Visible = False
        '
        'id_actividad_proyecto_dgv
        '
        Me.id_actividad_proyecto_dgv.HeaderText = "id_actividad_proyecto_dgv"
        Me.id_actividad_proyecto_dgv.Name = "id_actividad_proyecto_dgv"
        Me.id_actividad_proyecto_dgv.ReadOnly = True
        Me.id_actividad_proyecto_dgv.Visible = False
        '
        'id_control_dgv
        '
        Me.id_control_dgv.HeaderText = "id_control_dgv"
        Me.id_control_dgv.Name = "id_control_dgv"
        Me.id_control_dgv.ReadOnly = True
        Me.id_control_dgv.Visible = False
        '
        'id_movimiento_voz_dgv
        '
        Me.id_movimiento_voz_dgv.HeaderText = "id_movimiento_voz_dgv"
        Me.id_movimiento_voz_dgv.Name = "id_movimiento_voz_dgv"
        Me.id_movimiento_voz_dgv.ReadOnly = True
        Me.id_movimiento_voz_dgv.Visible = False
        '
        'completado_dgv
        '
        Me.completado_dgv.HeaderText = "Completado"
        Me.completado_dgv.Name = "completado_dgv"
        Me.completado_dgv.ReadOnly = True
        Me.completado_dgv.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.completado_dgv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.completado_dgv.Visible = False
        '
        'control_prod_dgv
        '
        Me.control_prod_dgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.control_prod_dgv.HeaderText = "P1"
        Me.control_prod_dgv.Name = "control_prod_dgv"
        Me.control_prod_dgv.ReadOnly = True
        Me.control_prod_dgv.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.control_prod_dgv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.control_prod_dgv.Visible = False
        Me.control_prod_dgv.Width = 30
        '
        'control_1_dgv
        '
        Me.control_1_dgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.control_1_dgv.HeaderText = "Ctrl 1"
        Me.control_1_dgv.Name = "control_1_dgv"
        Me.control_1_dgv.ReadOnly = True
        Me.control_1_dgv.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.control_1_dgv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.control_1_dgv.Visible = False
        Me.control_1_dgv.Width = 50
        '
        'corr_1_pendiente
        '
        Me.corr_1_pendiente.HeaderText = "Corr 1"
        Me.corr_1_pendiente.Name = "corr_1_pendiente"
        Me.corr_1_pendiente.ReadOnly = True
        Me.corr_1_pendiente.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.corr_1_pendiente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.corr_1_pendiente.Visible = False
        Me.corr_1_pendiente.Width = 50
        '
        'pedido_segundo_control_dgv
        '
        Me.pedido_segundo_control_dgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.pedido_segundo_control_dgv.HeaderText = "P2C"
        Me.pedido_segundo_control_dgv.Name = "pedido_segundo_control_dgv"
        Me.pedido_segundo_control_dgv.ReadOnly = True
        Me.pedido_segundo_control_dgv.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.pedido_segundo_control_dgv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.pedido_segundo_control_dgv.Visible = False
        Me.pedido_segundo_control_dgv.Width = 30
        '
        'control_prod_2_dgv
        '
        Me.control_prod_2_dgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.control_prod_2_dgv.HeaderText = "P2"
        Me.control_prod_2_dgv.Name = "control_prod_2_dgv"
        Me.control_prod_2_dgv.ReadOnly = True
        Me.control_prod_2_dgv.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.control_prod_2_dgv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.control_prod_2_dgv.Visible = False
        Me.control_prod_2_dgv.Width = 30
        '
        'control_2_dgv
        '
        Me.control_2_dgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.control_2_dgv.HeaderText = "Ctrl 2"
        Me.control_2_dgv.Name = "control_2_dgv"
        Me.control_2_dgv.ReadOnly = True
        Me.control_2_dgv.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.control_2_dgv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.control_2_dgv.Visible = False
        Me.control_2_dgv.Width = 50
        '
        'corr_2_pendiente
        '
        Me.corr_2_pendiente.HeaderText = "Corr 2"
        Me.corr_2_pendiente.Name = "corr_2_pendiente"
        Me.corr_2_pendiente.ReadOnly = True
        Me.corr_2_pendiente.Visible = False
        Me.corr_2_pendiente.Width = 50
        '
        'nombre_proyecto_dgv
        '
        Me.nombre_proyecto_dgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.nombre_proyecto_dgv.HeaderText = "Proyecto"
        Me.nombre_proyecto_dgv.Name = "nombre_proyecto_dgv"
        Me.nombre_proyecto_dgv.ReadOnly = True
        Me.nombre_proyecto_dgv.Width = 300
        '
        'nombre_subproyecto_dgv
        '
        Me.nombre_subproyecto_dgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.nombre_subproyecto_dgv.HeaderText = "Path"
        Me.nombre_subproyecto_dgv.Name = "nombre_subproyecto_dgv"
        Me.nombre_subproyecto_dgv.ReadOnly = True
        Me.nombre_subproyecto_dgv.Width = 650
        '
        'nombre_actividad_dgv
        '
        Me.nombre_actividad_dgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.nombre_actividad_dgv.HeaderText = "Actividad"
        Me.nombre_actividad_dgv.Name = "nombre_actividad_dgv"
        Me.nombre_actividad_dgv.ReadOnly = True
        Me.nombre_actividad_dgv.Width = 200
        '
        'nombre_control_dgv
        '
        Me.nombre_control_dgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.nombre_control_dgv.HeaderText = "Control"
        Me.nombre_control_dgv.Name = "nombre_control_dgv"
        Me.nombre_control_dgv.ReadOnly = True
        Me.nombre_control_dgv.Visible = False
        Me.nombre_control_dgv.Width = 500
        '
        'id_usuario_1_dgv
        '
        Me.id_usuario_1_dgv.HeaderText = "Producción 1"
        Me.id_usuario_1_dgv.Name = "id_usuario_1_dgv"
        Me.id_usuario_1_dgv.ReadOnly = True
        Me.id_usuario_1_dgv.Visible = False
        '
        'id_usuario_2_dgv
        '
        Me.id_usuario_2_dgv.HeaderText = "Controlador 1"
        Me.id_usuario_2_dgv.Name = "id_usuario_2_dgv"
        Me.id_usuario_2_dgv.ReadOnly = True
        Me.id_usuario_2_dgv.Visible = False
        '
        'id_usuario_3_dgv
        '
        Me.id_usuario_3_dgv.HeaderText = "Corrección 1"
        Me.id_usuario_3_dgv.Name = "id_usuario_3_dgv"
        Me.id_usuario_3_dgv.ReadOnly = True
        Me.id_usuario_3_dgv.Visible = False
        '
        'id_usuario_4_dgv
        '
        Me.id_usuario_4_dgv.HeaderText = "Producción 2"
        Me.id_usuario_4_dgv.Name = "id_usuario_4_dgv"
        Me.id_usuario_4_dgv.ReadOnly = True
        Me.id_usuario_4_dgv.Visible = False
        '
        'id_usuario_5_dgv
        '
        Me.id_usuario_5_dgv.HeaderText = "Controlador 2"
        Me.id_usuario_5_dgv.Name = "id_usuario_5_dgv"
        Me.id_usuario_5_dgv.ReadOnly = True
        Me.id_usuario_5_dgv.Visible = False
        '
        'id_usuario_6_dgv
        '
        Me.id_usuario_6_dgv.HeaderText = "Corrección 2"
        Me.id_usuario_6_dgv.Name = "id_usuario_6_dgv"
        Me.id_usuario_6_dgv.ReadOnly = True
        Me.id_usuario_6_dgv.Visible = False
        '
        'fecha_asignada_dgv
        '
        Me.fecha_asignada_dgv.HeaderText = "Fecha Asignada"
        Me.fecha_asignada_dgv.Name = "fecha_asignada_dgv"
        Me.fecha_asignada_dgv.ReadOnly = True
        Me.fecha_asignada_dgv.Visible = False
        '
        'fecha_inicio_dgv
        '
        Me.fecha_inicio_dgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle22.Format = "d"
        DataGridViewCellStyle22.NullValue = Nothing
        Me.fecha_inicio_dgv.DefaultCellStyle = DataGridViewCellStyle22
        Me.fecha_inicio_dgv.HeaderText = "Fecha Inicio"
        Me.fecha_inicio_dgv.Name = "fecha_inicio_dgv"
        Me.fecha_inicio_dgv.ReadOnly = True
        Me.fecha_inicio_dgv.Width = 70
        '
        'fecha_completado_dgv
        '
        Me.fecha_completado_dgv.HeaderText = "Fecha Completado"
        Me.fecha_completado_dgv.Name = "fecha_completado_dgv"
        Me.fecha_completado_dgv.ReadOnly = True
        Me.fecha_completado_dgv.Visible = False
        '
        'Cadista_1
        '
        Me.Cadista_1.HeaderText = "Cadista 1"
        Me.Cadista_1.Name = "Cadista_1"
        Me.Cadista_1.ReadOnly = True
        Me.Cadista_1.Visible = False
        '
        'Controlador_1
        '
        Me.Controlador_1.HeaderText = "Controlador 1"
        Me.Controlador_1.Name = "Controlador_1"
        Me.Controlador_1.ReadOnly = True
        Me.Controlador_1.Visible = False
        '
        'Correccion_1
        '
        Me.Correccion_1.HeaderText = "Corrección 1"
        Me.Correccion_1.Name = "Correccion_1"
        Me.Correccion_1.ReadOnly = True
        Me.Correccion_1.Visible = False
        '
        'Cadista_2
        '
        Me.Cadista_2.HeaderText = "Cadista 2"
        Me.Cadista_2.Name = "Cadista_2"
        Me.Cadista_2.ReadOnly = True
        Me.Cadista_2.Visible = False
        '
        'Controlador_2
        '
        Me.Controlador_2.HeaderText = "Controlador 2"
        Me.Controlador_2.Name = "Controlador_2"
        Me.Controlador_2.ReadOnly = True
        Me.Controlador_2.Visible = False
        '
        'Correccion_2
        '
        Me.Correccion_2.HeaderText = "Corrección 2"
        Me.Correccion_2.Name = "Correccion_2"
        Me.Correccion_2.ReadOnly = True
        Me.Correccion_2.Visible = False
        '
        'frmLoginInicio
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1268, 741)
        Me.Controls.Add(Me.TabControl1)
        Me.KeyPreview = True
        Me.Name = "frmLoginInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proveedores Descar"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.cmsProyecto.ResumeLayout(false)
        Me.cmsLogueo.ResumeLayout(false)
        Me.cmsTarea.ResumeLayout(false)
        Me.cmsHoraDevolver.ResumeLayout(false)
        Me.ctm_factura.ResumeLayout(false)
        Me.tabCompletados.ResumeLayout(false)
        CType(Me.dgvControlesCompletados,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabEnEspera.ResumeLayout(false)
        CType(Me.dgvControlEspera,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabMisControles.ResumeLayout(false)
        Me.tabMisControles.PerformLayout
        CType(Me.dgvControl,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabControles.ResumeLayout(false)
        Me.cms_anotaciones.ResumeLayout(false)
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.GroupBox16.ResumeLayout(false)
        Me.GroupBox16.PerformLayout
        Me.TabControl1.ResumeLayout(false)
        Me.tab_controles.ResumeLayout(false)
        Me.tab_controles.PerformLayout
        Me.SplitContainer5.Panel1.ResumeLayout(false)
        Me.SplitContainer5.Panel2.ResumeLayout(false)
        Me.SplitContainer5.Panel2.PerformLayout
        CType(Me.SplitContainer5,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer5.ResumeLayout(false)
        Me.grp_estado_control.ResumeLayout(false)
        Me.grp_estado_control.PerformLayout
        Me.GroupBox14.ResumeLayout(false)
        Me.GroupBox14.PerformLayout
        Me.GroupBox13.ResumeLayout(false)
        Me.GroupBox13.PerformLayout
        Me.grp_propiedades_control.ResumeLayout(false)
        Me.grp_propiedades_control.PerformLayout
        Me.grp_fechas_control.ResumeLayout(false)
        Me.grp_fechas_control.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents txtEstadoControl As System.Windows.Forms.TextBox
    Friend WithEvents cmsProyecto As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsAgregarControl As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnRealizarControl As System.Windows.Forms.Button
    Friend WithEvents lblid_pk As System.Windows.Forms.Label
    Friend WithEvents lblid_pk_actividad As System.Windows.Forms.Label
    Friend WithEvents lblid_pk_proyecto As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ctm_factura As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsAgregarFactura As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents cmsHoraDevolver As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsModificarHoraDevolver As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsBorrarHoraDevolver As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsTarea As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsActualizarTareaPendiente As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MarcarTareaComoRealizadaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer_Logueo As System.Windows.Forms.Timer
    Friend WithEvents VerTodasLasTareasPendientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsTareasXUsuario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblid_control As System.Windows.Forms.Label
    Friend WithEvents lblid_movimiento_voz As System.Windows.Forms.Label
    Friend WithEvents btnRefrescarControl As System.Windows.Forms.Button
    Friend WithEvents chkP As System.Windows.Forms.CheckBox
    Friend WithEvents chk1 As System.Windows.Forms.CheckBox
    Friend WithEvents chk2 As System.Windows.Forms.CheckBox
    Friend WithEvents smOrdenar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsOrdenarFechaCreacion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsNombre As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsRefrescarProyecto As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smOrdenarArbol As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsOrdenarXNombre As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsBorrarCtrl As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents tabCompletados As System.Windows.Forms.TabPage
    Friend WithEvents tabEnEspera As System.Windows.Forms.TabPage
    Friend WithEvents tabMisControles As System.Windows.Forms.TabPage
    Protected WithEvents dgvControl As System.Windows.Forms.DataGridView
    Friend WithEvents tabControles As System.Windows.Forms.TabControl
    Friend WithEvents btnInforme As System.Windows.Forms.Button
    Friend WithEvents Background_pdf As System.ComponentModel.BackgroundWorker
    Friend WithEvents TimerLogueo As System.Windows.Forms.Timer
    Friend WithEvents cmsLogueo As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ts_loguearNuevamente As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsAdministrarProyecto As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsSeparator_Administrar As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ts_login_actividad As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsSeparator_login As System.Windows.Forms.ToolStripSeparator
    Protected WithEvents dgvControlEspera As System.Windows.Forms.DataGridView
    Protected WithEvents dgvControlesCompletados As System.Windows.Forms.DataGridView
    Friend WithEvents cms_anotaciones As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ts_anotaciones_copiar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tab_controles As System.Windows.Forms.TabPage
    Friend WithEvents grp_propiedades_control As System.Windows.Forms.GroupBox
    Friend WithEvents txt_actividad_control As System.Windows.Forms.TextBox
    Friend WithEvents txt_subproyecto_control As System.Windows.Forms.TextBox
    Friend WithEvents txt_proyecto_control As System.Windows.Forms.TextBox
    Friend WithEvents txt_cliente_control As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents grp_fechas_control As System.Windows.Forms.GroupBox
    Friend WithEvents txt_fecha_completado_control As System.Windows.Forms.TextBox
    Friend WithEvents txt_fecha_inicio_control As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txt_control_control As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents grp_estado_control As System.Windows.Forms.GroupBox
    Friend WithEvents chk_correccion_2_control As System.Windows.Forms.CheckBox
    Friend WithEvents chk_control_2_control As System.Windows.Forms.CheckBox
    Friend WithEvents chk_produccion_2_control As System.Windows.Forms.CheckBox
    Friend WithEvents chk_correccion_1_control As System.Windows.Forms.CheckBox
    Friend WithEvents chk_control_1_control As System.Windows.Forms.CheckBox
    Friend WithEvents chk_produccion_control As System.Windows.Forms.CheckBox
    Friend WithEvents txt_correccion_2_control As System.Windows.Forms.TextBox
    Friend WithEvents txt_control_2_control As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txt_produccion_2_control As System.Windows.Forms.TextBox
    Friend WithEvents txt_correccion_1_control As System.Windows.Forms.TextBox
    Friend WithEvents txt_control_1_control As System.Windows.Forms.TextBox
    Friend WithEvents txt_produccion_control As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents chk_completado_control As System.Windows.Forms.CheckBox
    Friend WithEvents id_actividad_dgv_completado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_proyecto_dgv_completado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_actividad_proyecto_dgv_completado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_control_dgv_completado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_movimiento_voz_dgv_completado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents control_prod_dgv_completado As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents control_1_dgv_completado As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents corr_1_completado As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents pedido_segundo_control_dgv_completado As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents control_prod_2_dgv_completado As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents control_2_dgv_completado As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents corr_2_completado As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents nombre_actividad_dgv_completado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_subproyecto_dgv_completado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_control_dgv_completado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_proyecto_dgv_completado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_usuario_1_dgv_completado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_usuario_2_dgv_completado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_usuario_3_dgv_completado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_usuario_4_dgv_completado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_usuario_5_dgv_completado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_usuario_6_dgv_completado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_asignada_dgv_completado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_inicio_dgv_completado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_completado_dgv_completado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents completado_dgv_completado As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Cadista_1_completado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Controlador_1_completado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Correccion_1_completado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cadista_2_completado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Controlador_2_completado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Correccion_2_completado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_actividad_dgv_espera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_proyecto_dgv_espera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_actividad_proyecto_dgv_espera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_control_dgv_espera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_movimiento_voz_dgv_espera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents completado_dgv_espera As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents control_prod_dgv_espera As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents control_1_dgv_espera As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents corr_1_espera As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents pedido_segundo_control_dgv_espera As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents control_prod_2_dgv_espera As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents control_2_dgv_espera As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents corr_2_espera As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents nombre_actividad_dgv_espera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_subproyecto_dgv_espera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_control_dgv_espera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_proyecto_dgv_espera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_usuario_1_dgv_espera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_usuario_2_dgv_espera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_usuario_3_dgv_espera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_usuario_4_dgv_espera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_usuario_5_dgv_espera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_usuario_6_dgv_espera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_asignada_dgv_espera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_inicio_dgv_espera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_completado_dgv_espera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cadista_1_Espera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Controlador_1_Espera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Correccion_1_espera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cadista_2_espera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Controlador_2_espera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Correccion_2_espera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SplitContainer5 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox16 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_control As System.Windows.Forms.Label
    Friend WithEvents TextBox27 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_correccion As System.Windows.Forms.Label
    Friend WithEvents TextBox26 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_produccion As System.Windows.Forms.Label
    Friend WithEvents TextBox25 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_proveedor As System.Windows.Forms.Label
    Friend WithEvents id_actividad_dgv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_proyecto_dgv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_actividad_proyecto_dgv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_control_dgv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_movimiento_voz_dgv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents completado_dgv As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents control_prod_dgv As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents control_1_dgv As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents corr_1_pendiente As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents pedido_segundo_control_dgv As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents control_prod_2_dgv As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents control_2_dgv As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents corr_2_pendiente As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents nombre_proyecto_dgv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_subproyecto_dgv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_actividad_dgv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_control_dgv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_usuario_1_dgv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_usuario_2_dgv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_usuario_3_dgv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_usuario_4_dgv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_usuario_5_dgv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_usuario_6_dgv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_asignada_dgv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_inicio_dgv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_completado_dgv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cadista_1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Controlador_1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Correccion_1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cadista_2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Controlador_2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Correccion_2 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
