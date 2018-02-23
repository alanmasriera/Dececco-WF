<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class frmLogin
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
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.OK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.lblid_actividad_proyecto = New System.Windows.Forms.Label()
        Me.lblid_actividad = New System.Windows.Forms.Label()
        Me.lblid_proyecto = New System.Windows.Forms.Label()
        Me.lblid_cuerpo_movimiento_hora = New System.Windows.Forms.Label()
        Me.lblNodo = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblid_cuerpo_movimiento_voz = New System.Windows.Forms.Label()
        Me.chkProyectoInicial = New System.Windows.Forms.CheckBox()
        Me.btnGuardarActividad = New System.Windows.Forms.Button()
        Me.btnBorrarActividad = New System.Windows.Forms.Button()
        Me.btnModificarActividad = New System.Windows.Forms.Button()
        Me.btnNuevoActividad = New System.Windows.Forms.Button()
        Me.btnGuardarProyecto = New System.Windows.Forms.Button()
        Me.btnBorrarProyecto = New System.Windows.Forms.Button()
        Me.btnModificarProyecto = New System.Windows.Forms.Button()
        Me.btnNuevoProyecto = New System.Windows.Forms.Button()
        Me.gbActividad = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtOrden = New System.Windows.Forms.TextBox()
        Me.txtNombre_actividad = New System.Windows.Forms.TextBox()
        Me.etiquetaprioridad = New System.Windows.Forms.Label()
        Me.etiquetacantidad_hora = New System.Windows.Forms.Label()
        Me.txtcantidad_hora = New System.Windows.Forms.TextBox()
        Me.gbProyecto = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txttotal_hora = New System.Windows.Forms.TextBox()
        Me.txtnombre_proyecto = New System.Windows.Forms.TextBox()
        Me.etiquetatotal_hora = New System.Windows.Forms.Label()
        Me.etiquetaid_proyect_manager = New System.Windows.Forms.Label()
        Me.lblid_controlador_1 = New System.Windows.Forms.Label()
        Me.cmbproyect_manager = New System.Windows.Forms.ComboBox()
        Me.cmbcontrolador_1 = New System.Windows.Forms.ComboBox()
        Me.lblid_proyect_manager = New System.Windows.Forms.Label()
        Me.etiquetaid_controlador_1 = New System.Windows.Forms.Label()
        Me.etiquetaid_controlador_2 = New System.Windows.Forms.Label()
        Me.lblid_controlador_2 = New System.Windows.Forms.Label()
        Me.cmbcontrolador_2 = New System.Windows.Forms.ComboBox()
        Me.lblBanderaActividad = New System.Windows.Forms.Label()
        Me.lblBanderaActividad_proyecto = New System.Windows.Forms.Label()
        Me.lblBanderaProyecto = New System.Windows.Forms.Label()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.AdministrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AgregarProyectoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrarProyectoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarProyectoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarActividadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrarActividadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarActividadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblVariableProyecto = New System.Windows.Forms.Label()
        Me.gbActividad.SuspendLayout()
        Me.gbProyecto.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(528, 26)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(94, 23)
        Me.OK.TabIndex = 4
        Me.OK.Text = "&Login"
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(637, 26)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(94, 23)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "&Salir"
        '
        'TreeView1
        '
        Me.TreeView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TreeView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView1.ImageIndex = 0
        Me.TreeView1.ImageList = Me.ImageList1
        Me.TreeView1.Location = New System.Drawing.Point(12, 36)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.SelectedImageIndex = 2
        Me.TreeView1.Size = New System.Drawing.Size(498, 686)
        Me.TreeView1.TabIndex = 17
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "IconFolder.png")
        Me.ImageList1.Images.SetKeyName(1, "mini_file.png")
        Me.ImageList1.Images.SetKeyName(2, "bullet-check.png")
        Me.ImageList1.Images.SetKeyName(3, "ActividadCheck.png")
        '
        'lblid_actividad_proyecto
        '
        Me.lblid_actividad_proyecto.AutoSize = True
        Me.lblid_actividad_proyecto.BackColor = System.Drawing.Color.Red
        Me.lblid_actividad_proyecto.Location = New System.Drawing.Point(917, 12)
        Me.lblid_actividad_proyecto.Name = "lblid_actividad_proyecto"
        Me.lblid_actividad_proyecto.Size = New System.Drawing.Size(13, 13)
        Me.lblid_actividad_proyecto.TabIndex = 528
        Me.lblid_actividad_proyecto.Text = "0"
        Me.lblid_actividad_proyecto.Visible = False
        '
        'lblid_actividad
        '
        Me.lblid_actividad.AutoSize = True
        Me.lblid_actividad.BackColor = System.Drawing.Color.Red
        Me.lblid_actividad.Location = New System.Drawing.Point(898, 12)
        Me.lblid_actividad.Name = "lblid_actividad"
        Me.lblid_actividad.Size = New System.Drawing.Size(13, 13)
        Me.lblid_actividad.TabIndex = 527
        Me.lblid_actividad.Text = "0"
        Me.lblid_actividad.Visible = False
        '
        'lblid_proyecto
        '
        Me.lblid_proyecto.AutoSize = True
        Me.lblid_proyecto.BackColor = System.Drawing.Color.Red
        Me.lblid_proyecto.Location = New System.Drawing.Point(879, 12)
        Me.lblid_proyecto.Name = "lblid_proyecto"
        Me.lblid_proyecto.Size = New System.Drawing.Size(13, 13)
        Me.lblid_proyecto.TabIndex = 526
        Me.lblid_proyecto.Text = "0"
        Me.lblid_proyecto.Visible = False
        '
        'lblid_cuerpo_movimiento_hora
        '
        Me.lblid_cuerpo_movimiento_hora.AutoSize = True
        Me.lblid_cuerpo_movimiento_hora.BackColor = System.Drawing.Color.Red
        Me.lblid_cuerpo_movimiento_hora.Location = New System.Drawing.Point(955, 12)
        Me.lblid_cuerpo_movimiento_hora.Name = "lblid_cuerpo_movimiento_hora"
        Me.lblid_cuerpo_movimiento_hora.Size = New System.Drawing.Size(13, 13)
        Me.lblid_cuerpo_movimiento_hora.TabIndex = 531
        Me.lblid_cuerpo_movimiento_hora.Text = "0"
        Me.lblid_cuerpo_movimiento_hora.Visible = False
        '
        'lblNodo
        '
        Me.lblNodo.AutoSize = True
        Me.lblNodo.BackColor = System.Drawing.Color.Red
        Me.lblNodo.Location = New System.Drawing.Point(936, 12)
        Me.lblNodo.Name = "lblNodo"
        Me.lblNodo.Size = New System.Drawing.Size(13, 13)
        Me.lblNodo.TabIndex = 532
        Me.lblNodo.Text = "0"
        Me.lblNodo.Visible = False
        '
        'txtEstado
        '
        Me.txtEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado.Location = New System.Drawing.Point(573, 52)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(174, 20)
        Me.txtEstado.TabIndex = 534
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(525, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 533
        Me.Label2.Text = "Estado"
        '
        'lblid_cuerpo_movimiento_voz
        '
        Me.lblid_cuerpo_movimiento_voz.AutoSize = True
        Me.lblid_cuerpo_movimiento_voz.BackColor = System.Drawing.Color.Red
        Me.lblid_cuerpo_movimiento_voz.Location = New System.Drawing.Point(609, 55)
        Me.lblid_cuerpo_movimiento_voz.Name = "lblid_cuerpo_movimiento_voz"
        Me.lblid_cuerpo_movimiento_voz.Size = New System.Drawing.Size(13, 13)
        Me.lblid_cuerpo_movimiento_voz.TabIndex = 535
        Me.lblid_cuerpo_movimiento_voz.Text = "0"
        Me.lblid_cuerpo_movimiento_voz.Visible = False
        '
        'chkProyectoInicial
        '
        Me.chkProyectoInicial.AutoSize = True
        Me.chkProyectoInicial.Location = New System.Drawing.Point(333, 35)
        Me.chkProyectoInicial.Name = "chkProyectoInicial"
        Me.chkProyectoInicial.Size = New System.Drawing.Size(98, 17)
        Me.chkProyectoInicial.TabIndex = 607
        Me.chkProyectoInicial.Text = "Proyecto Inicial"
        Me.chkProyectoInicial.UseVisualStyleBackColor = True
        '
        'btnGuardarActividad
        '
        Me.btnGuardarActividad.Location = New System.Drawing.Point(10, 19)
        Me.btnGuardarActividad.Name = "btnGuardarActividad"
        Me.btnGuardarActividad.Size = New System.Drawing.Size(59, 22)
        Me.btnGuardarActividad.TabIndex = 604
        Me.btnGuardarActividad.Text = "Guardar"
        Me.btnGuardarActividad.UseVisualStyleBackColor = True
        '
        'btnBorrarActividad
        '
        Me.btnBorrarActividad.Location = New System.Drawing.Point(220, 19)
        Me.btnBorrarActividad.Name = "btnBorrarActividad"
        Me.btnBorrarActividad.Size = New System.Drawing.Size(52, 22)
        Me.btnBorrarActividad.TabIndex = 603
        Me.btnBorrarActividad.Text = "Borrar"
        Me.btnBorrarActividad.UseVisualStyleBackColor = True
        '
        'btnModificarActividad
        '
        Me.btnModificarActividad.Location = New System.Drawing.Point(140, 19)
        Me.btnModificarActividad.Name = "btnModificarActividad"
        Me.btnModificarActividad.Size = New System.Drawing.Size(63, 22)
        Me.btnModificarActividad.TabIndex = 602
        Me.btnModificarActividad.Text = "Modificar"
        Me.btnModificarActividad.UseVisualStyleBackColor = True
        '
        'btnNuevoActividad
        '
        Me.btnNuevoActividad.Location = New System.Drawing.Point(82, 19)
        Me.btnNuevoActividad.Name = "btnNuevoActividad"
        Me.btnNuevoActividad.Size = New System.Drawing.Size(52, 22)
        Me.btnNuevoActividad.TabIndex = 601
        Me.btnNuevoActividad.Text = "Nuevo"
        Me.btnNuevoActividad.UseVisualStyleBackColor = True
        '
        'btnGuardarProyecto
        '
        Me.btnGuardarProyecto.Location = New System.Drawing.Point(10, 30)
        Me.btnGuardarProyecto.Name = "btnGuardarProyecto"
        Me.btnGuardarProyecto.Size = New System.Drawing.Size(59, 22)
        Me.btnGuardarProyecto.TabIndex = 598
        Me.btnGuardarProyecto.Text = "Guardar"
        Me.btnGuardarProyecto.UseVisualStyleBackColor = True
        '
        'btnBorrarProyecto
        '
        Me.btnBorrarProyecto.Location = New System.Drawing.Point(220, 30)
        Me.btnBorrarProyecto.Name = "btnBorrarProyecto"
        Me.btnBorrarProyecto.Size = New System.Drawing.Size(52, 22)
        Me.btnBorrarProyecto.TabIndex = 597
        Me.btnBorrarProyecto.Text = "Borrar"
        Me.btnBorrarProyecto.UseVisualStyleBackColor = True
        '
        'btnModificarProyecto
        '
        Me.btnModificarProyecto.Location = New System.Drawing.Point(140, 30)
        Me.btnModificarProyecto.Name = "btnModificarProyecto"
        Me.btnModificarProyecto.Size = New System.Drawing.Size(63, 22)
        Me.btnModificarProyecto.TabIndex = 596
        Me.btnModificarProyecto.Text = "Modificar"
        Me.btnModificarProyecto.UseVisualStyleBackColor = True
        '
        'btnNuevoProyecto
        '
        Me.btnNuevoProyecto.Location = New System.Drawing.Point(82, 30)
        Me.btnNuevoProyecto.Name = "btnNuevoProyecto"
        Me.btnNuevoProyecto.Size = New System.Drawing.Size(52, 22)
        Me.btnNuevoProyecto.TabIndex = 595
        Me.btnNuevoProyecto.Text = "Nuevo"
        Me.btnNuevoProyecto.UseVisualStyleBackColor = True
        '
        'gbActividad
        '
        Me.gbActividad.Controls.Add(Me.Label3)
        Me.gbActividad.Controls.Add(Me.btnGuardarActividad)
        Me.gbActividad.Controls.Add(Me.btnBorrarActividad)
        Me.gbActividad.Controls.Add(Me.txtOrden)
        Me.gbActividad.Controls.Add(Me.btnModificarActividad)
        Me.gbActividad.Controls.Add(Me.txtNombre_actividad)
        Me.gbActividad.Controls.Add(Me.btnNuevoActividad)
        Me.gbActividad.Controls.Add(Me.etiquetaprioridad)
        Me.gbActividad.Controls.Add(Me.etiquetacantidad_hora)
        Me.gbActividad.Controls.Add(Me.txtcantidad_hora)
        Me.gbActividad.Location = New System.Drawing.Point(518, 530)
        Me.gbActividad.Name = "gbActividad"
        Me.gbActividad.Size = New System.Drawing.Size(496, 192)
        Me.gbActividad.TabIndex = 608
        Me.gbActividad.TabStop = False
        Me.gbActividad.Text = "ACTIVIDADES"
        Me.gbActividad.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(10, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 17)
        Me.Label3.TabIndex = 592
        Me.Label3.Text = "Nombre"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Visible = False
        '
        'txtOrden
        '
        Me.txtOrden.BackColor = System.Drawing.Color.White
        Me.txtOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrden.ForeColor = System.Drawing.Color.Blue
        Me.txtOrden.Location = New System.Drawing.Point(264, 149)
        Me.txtOrden.MaxLength = 50
        Me.txtOrden.Name = "txtOrden"
        Me.txtOrden.Size = New System.Drawing.Size(93, 31)
        Me.txtOrden.TabIndex = 571
        Me.txtOrden.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNombre_actividad
        '
        Me.txtNombre_actividad.BackColor = System.Drawing.Color.White
        Me.txtNombre_actividad.Location = New System.Drawing.Point(10, 88)
        Me.txtNombre_actividad.MaxLength = 500
        Me.txtNombre_actividad.Multiline = True
        Me.txtNombre_actividad.Name = "txtNombre_actividad"
        Me.txtNombre_actividad.Size = New System.Drawing.Size(459, 49)
        Me.txtNombre_actividad.TabIndex = 550
        '
        'etiquetaprioridad
        '
        Me.etiquetaprioridad.AutoSize = True
        Me.etiquetaprioridad.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaprioridad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaprioridad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaprioridad.ForeColor = System.Drawing.Color.Black
        Me.etiquetaprioridad.Location = New System.Drawing.Point(214, 149)
        Me.etiquetaprioridad.Name = "etiquetaprioridad"
        Me.etiquetaprioridad.Size = New System.Drawing.Size(43, 17)
        Me.etiquetaprioridad.TabIndex = 576
        Me.etiquetaprioridad.Text = "Orden"
        Me.etiquetaprioridad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'etiquetacantidad_hora
        '
        Me.etiquetacantidad_hora.AutoSize = True
        Me.etiquetacantidad_hora.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetacantidad_hora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetacantidad_hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetacantidad_hora.ForeColor = System.Drawing.Color.Black
        Me.etiquetacantidad_hora.Location = New System.Drawing.Point(10, 149)
        Me.etiquetacantidad_hora.Name = "etiquetacantidad_hora"
        Me.etiquetacantidad_hora.Size = New System.Drawing.Size(90, 17)
        Me.etiquetacantidad_hora.TabIndex = 575
        Me.etiquetacantidad_hora.Text = "Cantidad_hora"
        Me.etiquetacantidad_hora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcantidad_hora
        '
        Me.txtcantidad_hora.BackColor = System.Drawing.Color.White
        Me.txtcantidad_hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantidad_hora.ForeColor = System.Drawing.Color.Blue
        Me.txtcantidad_hora.Location = New System.Drawing.Point(107, 149)
        Me.txtcantidad_hora.MaxLength = 50
        Me.txtcantidad_hora.Name = "txtcantidad_hora"
        Me.txtcantidad_hora.Size = New System.Drawing.Size(93, 31)
        Me.txtcantidad_hora.TabIndex = 570
        Me.txtcantidad_hora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'gbProyecto
        '
        Me.gbProyecto.Controls.Add(Me.Label4)
        Me.gbProyecto.Controls.Add(Me.btnGuardarProyecto)
        Me.gbProyecto.Controls.Add(Me.btnBorrarProyecto)
        Me.gbProyecto.Controls.Add(Me.txttotal_hora)
        Me.gbProyecto.Controls.Add(Me.btnModificarProyecto)
        Me.gbProyecto.Controls.Add(Me.chkProyectoInicial)
        Me.gbProyecto.Controls.Add(Me.txtnombre_proyecto)
        Me.gbProyecto.Controls.Add(Me.btnNuevoProyecto)
        Me.gbProyecto.Controls.Add(Me.etiquetatotal_hora)
        Me.gbProyecto.Controls.Add(Me.etiquetaid_proyect_manager)
        Me.gbProyecto.Controls.Add(Me.lblid_controlador_1)
        Me.gbProyecto.Controls.Add(Me.cmbproyect_manager)
        Me.gbProyecto.Controls.Add(Me.cmbcontrolador_1)
        Me.gbProyecto.Controls.Add(Me.lblid_proyect_manager)
        Me.gbProyecto.Controls.Add(Me.etiquetaid_controlador_1)
        Me.gbProyecto.Controls.Add(Me.etiquetaid_controlador_2)
        Me.gbProyecto.Controls.Add(Me.lblid_controlador_2)
        Me.gbProyecto.Controls.Add(Me.cmbcontrolador_2)
        Me.gbProyecto.Location = New System.Drawing.Point(518, 223)
        Me.gbProyecto.Name = "gbProyecto"
        Me.gbProyecto.Size = New System.Drawing.Size(496, 298)
        Me.gbProyecto.TabIndex = 609
        Me.gbProyecto.TabStop = False
        Me.gbProyecto.Text = "PROYECTOS"
        Me.gbProyecto.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(11, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 17)
        Me.Label4.TabIndex = 591
        Me.Label4.Text = "Nombre"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Visible = False
        '
        'txttotal_hora
        '
        Me.txttotal_hora.BackColor = System.Drawing.Color.White
        Me.txttotal_hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal_hora.ForeColor = System.Drawing.Color.Blue
        Me.txttotal_hora.Location = New System.Drawing.Point(91, 249)
        Me.txttotal_hora.MaxLength = 50
        Me.txttotal_hora.Name = "txttotal_hora"
        Me.txttotal_hora.Size = New System.Drawing.Size(131, 31)
        Me.txttotal_hora.TabIndex = 585
        Me.txttotal_hora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtnombre_proyecto
        '
        Me.txtnombre_proyecto.BackColor = System.Drawing.Color.White
        Me.txtnombre_proyecto.Location = New System.Drawing.Point(11, 90)
        Me.txtnombre_proyecto.MaxLength = 500
        Me.txtnombre_proyecto.Multiline = True
        Me.txtnombre_proyecto.Name = "txtnombre_proyecto"
        Me.txtnombre_proyecto.Size = New System.Drawing.Size(462, 49)
        Me.txtnombre_proyecto.TabIndex = 543
        '
        'etiquetatotal_hora
        '
        Me.etiquetatotal_hora.AutoSize = True
        Me.etiquetatotal_hora.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetatotal_hora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetatotal_hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetatotal_hora.ForeColor = System.Drawing.Color.Black
        Me.etiquetatotal_hora.Location = New System.Drawing.Point(11, 249)
        Me.etiquetatotal_hora.Name = "etiquetatotal_hora"
        Me.etiquetatotal_hora.Size = New System.Drawing.Size(68, 17)
        Me.etiquetatotal_hora.TabIndex = 590
        Me.etiquetatotal_hora.Text = "Total_hora"
        Me.etiquetatotal_hora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'etiquetaid_proyect_manager
        '
        Me.etiquetaid_proyect_manager.AutoSize = True
        Me.etiquetaid_proyect_manager.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_proyect_manager.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_proyect_manager.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_proyect_manager.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_proyect_manager.Location = New System.Drawing.Point(12, 148)
        Me.etiquetaid_proyect_manager.Name = "etiquetaid_proyect_manager"
        Me.etiquetaid_proyect_manager.Size = New System.Drawing.Size(106, 17)
        Me.etiquetaid_proyect_manager.TabIndex = 558
        Me.etiquetaid_proyect_manager.Text = "Proyect_manager"
        Me.etiquetaid_proyect_manager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_controlador_1
        '
        Me.lblid_controlador_1.AutoSize = True
        Me.lblid_controlador_1.BackColor = System.Drawing.Color.Red
        Me.lblid_controlador_1.Location = New System.Drawing.Point(354, 181)
        Me.lblid_controlador_1.Name = "lblid_controlador_1"
        Me.lblid_controlador_1.Size = New System.Drawing.Size(13, 13)
        Me.lblid_controlador_1.TabIndex = 563
        Me.lblid_controlador_1.Text = "0"
        Me.lblid_controlador_1.Visible = False
        '
        'cmbproyect_manager
        '
        Me.cmbproyect_manager.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbproyect_manager.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbproyect_manager.FormattingEnabled = True
        Me.cmbproyect_manager.Location = New System.Drawing.Point(145, 148)
        Me.cmbproyect_manager.Name = "cmbproyect_manager"
        Me.cmbproyect_manager.Size = New System.Drawing.Size(329, 21)
        Me.cmbproyect_manager.TabIndex = 555
        '
        'cmbcontrolador_1
        '
        Me.cmbcontrolador_1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbcontrolador_1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbcontrolador_1.FormattingEnabled = True
        Me.cmbcontrolador_1.Location = New System.Drawing.Point(145, 181)
        Me.cmbcontrolador_1.Name = "cmbcontrolador_1"
        Me.cmbcontrolador_1.Size = New System.Drawing.Size(329, 21)
        Me.cmbcontrolador_1.TabIndex = 559
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
        'etiquetaid_controlador_1
        '
        Me.etiquetaid_controlador_1.AutoSize = True
        Me.etiquetaid_controlador_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_controlador_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_controlador_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_controlador_1.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_controlador_1.Location = New System.Drawing.Point(12, 181)
        Me.etiquetaid_controlador_1.Name = "etiquetaid_controlador_1"
        Me.etiquetaid_controlador_1.Size = New System.Drawing.Size(87, 17)
        Me.etiquetaid_controlador_1.TabIndex = 564
        Me.etiquetaid_controlador_1.Text = "Controlador_1"
        Me.etiquetaid_controlador_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'etiquetaid_controlador_2
        '
        Me.etiquetaid_controlador_2.AutoSize = True
        Me.etiquetaid_controlador_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.etiquetaid_controlador_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etiquetaid_controlador_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiquetaid_controlador_2.ForeColor = System.Drawing.Color.Black
        Me.etiquetaid_controlador_2.Location = New System.Drawing.Point(12, 215)
        Me.etiquetaid_controlador_2.Name = "etiquetaid_controlador_2"
        Me.etiquetaid_controlador_2.Size = New System.Drawing.Size(87, 17)
        Me.etiquetaid_controlador_2.TabIndex = 566
        Me.etiquetaid_controlador_2.Text = "Controlador_2"
        Me.etiquetaid_controlador_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_controlador_2
        '
        Me.lblid_controlador_2.AutoSize = True
        Me.lblid_controlador_2.BackColor = System.Drawing.Color.Red
        Me.lblid_controlador_2.Location = New System.Drawing.Point(354, 215)
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
        Me.cmbcontrolador_2.Location = New System.Drawing.Point(145, 215)
        Me.cmbcontrolador_2.Name = "cmbcontrolador_2"
        Me.cmbcontrolador_2.Size = New System.Drawing.Size(329, 21)
        Me.cmbcontrolador_2.TabIndex = 560
        '
        'lblBanderaActividad
        '
        Me.lblBanderaActividad.AutoSize = True
        Me.lblBanderaActividad.BackColor = System.Drawing.Color.Red
        Me.lblBanderaActividad.Location = New System.Drawing.Point(917, 36)
        Me.lblBanderaActividad.Name = "lblBanderaActividad"
        Me.lblBanderaActividad.Size = New System.Drawing.Size(13, 13)
        Me.lblBanderaActividad.TabIndex = 612
        Me.lblBanderaActividad.Text = "0"
        Me.lblBanderaActividad.Visible = False
        '
        'lblBanderaActividad_proyecto
        '
        Me.lblBanderaActividad_proyecto.AutoSize = True
        Me.lblBanderaActividad_proyecto.BackColor = System.Drawing.Color.Red
        Me.lblBanderaActividad_proyecto.Location = New System.Drawing.Point(898, 36)
        Me.lblBanderaActividad_proyecto.Name = "lblBanderaActividad_proyecto"
        Me.lblBanderaActividad_proyecto.Size = New System.Drawing.Size(13, 13)
        Me.lblBanderaActividad_proyecto.TabIndex = 611
        Me.lblBanderaActividad_proyecto.Text = "0"
        Me.lblBanderaActividad_proyecto.Visible = False
        '
        'lblBanderaProyecto
        '
        Me.lblBanderaProyecto.AutoSize = True
        Me.lblBanderaProyecto.BackColor = System.Drawing.Color.Red
        Me.lblBanderaProyecto.Location = New System.Drawing.Point(879, 36)
        Me.lblBanderaProyecto.Name = "lblBanderaProyecto"
        Me.lblBanderaProyecto.Size = New System.Drawing.Size(13, 13)
        Me.lblBanderaProyecto.TabIndex = 610
        Me.lblBanderaProyecto.Text = "0"
        Me.lblBanderaProyecto.Visible = False
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToResizeColumns = False
        Me.dgv1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Brown
        Me.dgv1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv1.BackgroundColor = System.Drawing.Color.Silver
        Me.dgv1.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Beige
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Brown
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv1.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv1.GridColor = System.Drawing.Color.MediumPurple
        Me.dgv1.Location = New System.Drawing.Point(516, 78)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.RowHeadersVisible = False
        Me.dgv1.ShowCellErrors = False
        Me.dgv1.ShowRowErrors = False
        Me.dgv1.Size = New System.Drawing.Size(498, 139)
        Me.dgv1.StandardTab = True
        Me.dgv1.TabIndex = 599
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1018, 25)
        Me.ToolStrip1.TabIndex = 613
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministrarToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(82, 22)
        Me.ToolStripDropDownButton1.Text = "Proyecto"
        '
        'AdministrarToolStripMenuItem
        '
        Me.AdministrarToolStripMenuItem.Name = "AdministrarToolStripMenuItem"
        Me.AdministrarToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.AdministrarToolStripMenuItem.Text = "Administrar"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarProyectoToolStripMenuItem, Me.BorrarProyectoToolStripMenuItem, Me.ModificarProyectoToolStripMenuItem, Me.AgregarActividadToolStripMenuItem, Me.BorrarActividadToolStripMenuItem, Me.ModificarActividadToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(176, 136)
        '
        'AgregarProyectoToolStripMenuItem
        '
        Me.AgregarProyectoToolStripMenuItem.Name = "AgregarProyectoToolStripMenuItem"
        Me.AgregarProyectoToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.AgregarProyectoToolStripMenuItem.Text = "Agregar Proyecto"
        '
        'BorrarProyectoToolStripMenuItem
        '
        Me.BorrarProyectoToolStripMenuItem.Name = "BorrarProyectoToolStripMenuItem"
        Me.BorrarProyectoToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.BorrarProyectoToolStripMenuItem.Text = "Borrar Proyecto"
        '
        'ModificarProyectoToolStripMenuItem
        '
        Me.ModificarProyectoToolStripMenuItem.Name = "ModificarProyectoToolStripMenuItem"
        Me.ModificarProyectoToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.ModificarProyectoToolStripMenuItem.Text = "Modificar Proyecto"
        '
        'AgregarActividadToolStripMenuItem
        '
        Me.AgregarActividadToolStripMenuItem.Name = "AgregarActividadToolStripMenuItem"
        Me.AgregarActividadToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.AgregarActividadToolStripMenuItem.Text = "Agregar Actividad"
        '
        'BorrarActividadToolStripMenuItem
        '
        Me.BorrarActividadToolStripMenuItem.Name = "BorrarActividadToolStripMenuItem"
        Me.BorrarActividadToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.BorrarActividadToolStripMenuItem.Text = "Borrar Actividad"
        '
        'ModificarActividadToolStripMenuItem
        '
        Me.ModificarActividadToolStripMenuItem.Name = "ModificarActividadToolStripMenuItem"
        Me.ModificarActividadToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.ModificarActividadToolStripMenuItem.Text = "Modificar Actividad"
        '
        'lblVariableProyecto
        '
        Me.lblVariableProyecto.AutoSize = True
        Me.lblVariableProyecto.BackColor = System.Drawing.Color.Red
        Me.lblVariableProyecto.Location = New System.Drawing.Point(482, 55)
        Me.lblVariableProyecto.Name = "lblVariableProyecto"
        Me.lblVariableProyecto.Size = New System.Drawing.Size(13, 13)
        Me.lblVariableProyecto.TabIndex = 615
        Me.lblVariableProyecto.Text = "0"
        Me.lblVariableProyecto.Visible = False
        '
        'frmLogin
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(1018, 736)
        Me.Controls.Add(Me.lblVariableProyecto)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.lblBanderaActividad)
        Me.Controls.Add(Me.lblBanderaActividad_proyecto)
        Me.Controls.Add(Me.lblBanderaProyecto)
        Me.Controls.Add(Me.gbActividad)
        Me.Controls.Add(Me.gbProyecto)
        Me.Controls.Add(Me.lblid_cuerpo_movimiento_voz)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblNodo)
        Me.Controls.Add(Me.lblid_cuerpo_movimiento_hora)
        Me.Controls.Add(Me.lblid_actividad_proyecto)
        Me.Controls.Add(Me.lblid_actividad)
        Me.Controls.Add(Me.lblid_proyecto)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmLogin"
        Me.gbActividad.ResumeLayout(False)
        Me.gbActividad.PerformLayout()
        Me.gbProyecto.ResumeLayout(False)
        Me.gbProyecto.PerformLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents lblid_actividad_proyecto As System.Windows.Forms.Label
    Friend WithEvents lblid_actividad As System.Windows.Forms.Label
    Friend WithEvents lblid_proyecto As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents lblid_cuerpo_movimiento_hora As System.Windows.Forms.Label
    Friend WithEvents lblNodo As System.Windows.Forms.Label
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblid_cuerpo_movimiento_voz As System.Windows.Forms.Label
    Friend WithEvents chkProyectoInicial As System.Windows.Forms.CheckBox
    Friend WithEvents btnGuardarActividad As System.Windows.Forms.Button
    Friend WithEvents btnBorrarActividad As System.Windows.Forms.Button
    Friend WithEvents btnModificarActividad As System.Windows.Forms.Button
    Friend WithEvents btnNuevoActividad As System.Windows.Forms.Button
    Friend WithEvents btnGuardarProyecto As System.Windows.Forms.Button
    Friend WithEvents btnBorrarProyecto As System.Windows.Forms.Button
    Friend WithEvents btnModificarProyecto As System.Windows.Forms.Button
    Friend WithEvents btnNuevoProyecto As System.Windows.Forms.Button
    Friend WithEvents gbActividad As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Protected WithEvents txtOrden As System.Windows.Forms.TextBox
    Protected WithEvents txtNombre_actividad As System.Windows.Forms.TextBox
    Friend WithEvents etiquetaprioridad As System.Windows.Forms.Label
    Friend WithEvents etiquetacantidad_hora As System.Windows.Forms.Label
    Protected WithEvents txtcantidad_hora As System.Windows.Forms.TextBox
    Friend WithEvents gbProyecto As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Protected WithEvents txttotal_hora As System.Windows.Forms.TextBox
    Protected WithEvents txtnombre_proyecto As System.Windows.Forms.TextBox
    Friend WithEvents etiquetatotal_hora As System.Windows.Forms.Label
    Friend WithEvents etiquetaid_proyect_manager As System.Windows.Forms.Label
    Friend WithEvents lblid_controlador_1 As System.Windows.Forms.Label
    Friend WithEvents cmbproyect_manager As System.Windows.Forms.ComboBox
    Friend WithEvents cmbcontrolador_1 As System.Windows.Forms.ComboBox
    Friend WithEvents lblid_proyect_manager As System.Windows.Forms.Label
    Friend WithEvents etiquetaid_controlador_1 As System.Windows.Forms.Label
    Friend WithEvents etiquetaid_controlador_2 As System.Windows.Forms.Label
    Friend WithEvents lblid_controlador_2 As System.Windows.Forms.Label
    Friend WithEvents cmbcontrolador_2 As System.Windows.Forms.ComboBox
    Friend WithEvents lblBanderaActividad As System.Windows.Forms.Label
    Friend WithEvents lblBanderaActividad_proyecto As System.Windows.Forms.Label
    Friend WithEvents lblBanderaProyecto As System.Windows.Forms.Label
    Protected WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents AdministrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AgregarProyectoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BorrarProyectoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarProyectoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarActividadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BorrarActividadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarActividadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblVariableProyecto As System.Windows.Forms.Label

End Class
