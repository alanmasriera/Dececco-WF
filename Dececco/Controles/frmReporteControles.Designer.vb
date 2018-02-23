<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteControles
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chk_clientes = New System.Windows.Forms.CheckBox()
        Me.chk_voz = New System.Windows.Forms.CheckBox()
        Me.chk_fecha = New System.Windows.Forms.CheckBox()
        Me.chk_control = New System.Windows.Forms.CheckBox()
        Me.chk_cadista = New System.Windows.Forms.CheckBox()
        Me.chk_proyecto = New System.Windows.Forms.CheckBox()
        Me.btn_obtener_reporte = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rb_actividad = New System.Windows.Forms.RadioButton()
        Me.rb_clientes = New System.Windows.Forms.RadioButton()
        Me.rb_voces = New System.Windows.Forms.RadioButton()
        Me.rb_proyectos = New System.Windows.Forms.RadioButton()
        Me.rb_controles = New System.Windows.Forms.RadioButton()
        Me.rb_cadistas = New System.Windows.Forms.RadioButton()
        Me.rb_empresa = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_cliente = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtp_fecha_hasta = New System.Windows.Forms.DateTimePicker()
        Me.dtp_fecha_desde = New System.Windows.Forms.DateTimePicker()
        Me.cmb_control = New System.Windows.Forms.ComboBox()
        Me.cmb_usuarios = New System.Windows.Forms.ComboBox()
        Me.cmb_proyecto = New System.Windows.Forms.ComboBox()
        Me.txt_voz = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.grp_fechas = New System.Windows.Forms.GroupBox()
        Me.chk_mes = New System.Windows.Forms.CheckBox()
        Me.chk_anio = New System.Windows.Forms.CheckBox()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.reporteControles___Voz1 = New Dececco.reporteControles___Voz()
        Me.reporteControles___Voz2 = New Dececco.reporteControles___Voz()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.grp_fechas.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chk_clientes)
        Me.GroupBox2.Controls.Add(Me.chk_voz)
        Me.GroupBox2.Controls.Add(Me.chk_fecha)
        Me.GroupBox2.Controls.Add(Me.chk_control)
        Me.GroupBox2.Controls.Add(Me.chk_cadista)
        Me.GroupBox2.Controls.Add(Me.chk_proyecto)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 445)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(163, 183)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos a mostrar "
        '
        'chk_clientes
        '
        Me.chk_clientes.AutoSize = True
        Me.chk_clientes.Location = New System.Drawing.Point(17, 155)
        Me.chk_clientes.Name = "chk_clientes"
        Me.chk_clientes.Size = New System.Drawing.Size(63, 17)
        Me.chk_clientes.TabIndex = 11
        Me.chk_clientes.Text = "Clientes"
        Me.chk_clientes.UseVisualStyleBackColor = True
        '
        'chk_voz
        '
        Me.chk_voz.AutoSize = True
        Me.chk_voz.Location = New System.Drawing.Point(17, 132)
        Me.chk_voz.Name = "chk_voz"
        Me.chk_voz.Size = New System.Drawing.Size(56, 17)
        Me.chk_voz.TabIndex = 10
        Me.chk_voz.Text = "Voces"
        Me.chk_voz.UseVisualStyleBackColor = True
        '
        'chk_fecha
        '
        Me.chk_fecha.AutoSize = True
        Me.chk_fecha.Location = New System.Drawing.Point(17, 109)
        Me.chk_fecha.Name = "chk_fecha"
        Me.chk_fecha.Size = New System.Drawing.Size(56, 17)
        Me.chk_fecha.TabIndex = 9
        Me.chk_fecha.Text = "Fecha"
        Me.chk_fecha.UseVisualStyleBackColor = True
        '
        'chk_control
        '
        Me.chk_control.AutoSize = True
        Me.chk_control.Location = New System.Drawing.Point(17, 86)
        Me.chk_control.Name = "chk_control"
        Me.chk_control.Size = New System.Drawing.Size(70, 17)
        Me.chk_control.TabIndex = 8
        Me.chk_control.Text = "Controles"
        Me.chk_control.UseVisualStyleBackColor = True
        '
        'chk_cadista
        '
        Me.chk_cadista.AutoSize = True
        Me.chk_cadista.Location = New System.Drawing.Point(17, 63)
        Me.chk_cadista.Name = "chk_cadista"
        Me.chk_cadista.Size = New System.Drawing.Size(66, 17)
        Me.chk_cadista.TabIndex = 7
        Me.chk_cadista.Text = "Cadistas"
        Me.chk_cadista.UseVisualStyleBackColor = True
        '
        'chk_proyecto
        '
        Me.chk_proyecto.AutoSize = True
        Me.chk_proyecto.Location = New System.Drawing.Point(17, 40)
        Me.chk_proyecto.Name = "chk_proyecto"
        Me.chk_proyecto.Size = New System.Drawing.Size(73, 17)
        Me.chk_proyecto.TabIndex = 6
        Me.chk_proyecto.Text = "Proyectos"
        Me.chk_proyecto.UseVisualStyleBackColor = True
        '
        'btn_obtener_reporte
        '
        Me.btn_obtener_reporte.Location = New System.Drawing.Point(18, 634)
        Me.btn_obtener_reporte.Name = "btn_obtener_reporte"
        Me.btn_obtener_reporte.Size = New System.Drawing.Size(160, 47)
        Me.btn_obtener_reporte.TabIndex = 9
        Me.btn_obtener_reporte.Text = "Ver Reporte"
        Me.btn_obtener_reporte.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rb_actividad)
        Me.GroupBox3.Controls.Add(Me.rb_clientes)
        Me.GroupBox3.Controls.Add(Me.rb_voces)
        Me.GroupBox3.Controls.Add(Me.rb_proyectos)
        Me.GroupBox3.Controls.Add(Me.rb_controles)
        Me.GroupBox3.Controls.Add(Me.rb_cadistas)
        Me.GroupBox3.Controls.Add(Me.rb_empresa)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 21)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(545, 95)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tipo de reporte"
        '
        'rb_actividad
        '
        Me.rb_actividad.AutoSize = True
        Me.rb_actividad.Location = New System.Drawing.Point(280, 36)
        Me.rb_actividad.Name = "rb_actividad"
        Me.rb_actividad.Size = New System.Drawing.Size(69, 17)
        Me.rb_actividad.TabIndex = 6
        Me.rb_actividad.Text = "Actividad"
        Me.rb_actividad.UseVisualStyleBackColor = True
        '
        'rb_clientes
        '
        Me.rb_clientes.AutoSize = True
        Me.rb_clientes.Location = New System.Drawing.Point(200, 59)
        Me.rb_clientes.Name = "rb_clientes"
        Me.rb_clientes.Size = New System.Drawing.Size(62, 17)
        Me.rb_clientes.TabIndex = 5
        Me.rb_clientes.Text = "Clientes"
        Me.rb_clientes.UseVisualStyleBackColor = True
        '
        'rb_voces
        '
        Me.rb_voces.AutoSize = True
        Me.rb_voces.Location = New System.Drawing.Point(200, 36)
        Me.rb_voces.Name = "rb_voces"
        Me.rb_voces.Size = New System.Drawing.Size(55, 17)
        Me.rb_voces.TabIndex = 4
        Me.rb_voces.Text = "Voces"
        Me.rb_voces.UseVisualStyleBackColor = True
        '
        'rb_proyectos
        '
        Me.rb_proyectos.AutoSize = True
        Me.rb_proyectos.Location = New System.Drawing.Point(100, 59)
        Me.rb_proyectos.Name = "rb_proyectos"
        Me.rb_proyectos.Size = New System.Drawing.Size(72, 17)
        Me.rb_proyectos.TabIndex = 3
        Me.rb_proyectos.Text = "Proyectos"
        Me.rb_proyectos.UseVisualStyleBackColor = True
        '
        'rb_controles
        '
        Me.rb_controles.AutoSize = True
        Me.rb_controles.Location = New System.Drawing.Point(100, 36)
        Me.rb_controles.Name = "rb_controles"
        Me.rb_controles.Size = New System.Drawing.Size(69, 17)
        Me.rb_controles.TabIndex = 2
        Me.rb_controles.Text = "Controles"
        Me.rb_controles.UseVisualStyleBackColor = True
        '
        'rb_cadistas
        '
        Me.rb_cadistas.AutoSize = True
        Me.rb_cadistas.Location = New System.Drawing.Point(17, 59)
        Me.rb_cadistas.Name = "rb_cadistas"
        Me.rb_cadistas.Size = New System.Drawing.Size(65, 17)
        Me.rb_cadistas.TabIndex = 1
        Me.rb_cadistas.Text = "Cadistas"
        Me.rb_cadistas.UseVisualStyleBackColor = True
        '
        'rb_empresa
        '
        Me.rb_empresa.AutoSize = True
        Me.rb_empresa.Checked = True
        Me.rb_empresa.Location = New System.Drawing.Point(16, 36)
        Me.rb_empresa.Name = "rb_empresa"
        Me.rb_empresa.Size = New System.Drawing.Size(66, 17)
        Me.rb_empresa.TabIndex = 0
        Me.rb_empresa.TabStop = True
        Me.rb_empresa.Text = "Empresa"
        Me.rb_empresa.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.cmb_cliente)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.dtp_fecha_hasta)
        Me.GroupBox4.Controls.Add(Me.dtp_fecha_desde)
        Me.GroupBox4.Controls.Add(Me.cmb_control)
        Me.GroupBox4.Controls.Add(Me.cmb_usuarios)
        Me.GroupBox4.Controls.Add(Me.cmb_proyecto)
        Me.GroupBox4.Controls.Add(Me.txt_voz)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 122)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(545, 317)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Filtros"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 241)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Voz:"
        '
        'cmb_cliente
        '
        Me.cmb_cliente.FormattingEnabled = True
        Me.cmb_cliente.Location = New System.Drawing.Point(88, 23)
        Me.cmb_cliente.Name = "cmb_cliente"
        Me.cmb_cliente.Size = New System.Drawing.Size(451, 21)
        Me.cmb_cliente.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(37, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Cliente: "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(10, 163)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 13)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Fecha hasta: "
        '
        'dtp_fecha_hasta
        '
        Me.dtp_fecha_hasta.Location = New System.Drawing.Point(88, 157)
        Me.dtp_fecha_hasta.Name = "dtp_fecha_hasta"
        Me.dtp_fecha_hasta.Size = New System.Drawing.Size(451, 20)
        Me.dtp_fecha_hasta.TabIndex = 16
        '
        'dtp_fecha_desde
        '
        Me.dtp_fecha_desde.Location = New System.Drawing.Point(88, 131)
        Me.dtp_fecha_desde.Name = "dtp_fecha_desde"
        Me.dtp_fecha_desde.Size = New System.Drawing.Size(451, 20)
        Me.dtp_fecha_desde.TabIndex = 15
        '
        'cmb_control
        '
        Me.cmb_control.FormattingEnabled = True
        Me.cmb_control.Location = New System.Drawing.Point(88, 88)
        Me.cmb_control.Name = "cmb_control"
        Me.cmb_control.Size = New System.Drawing.Size(451, 21)
        Me.cmb_control.TabIndex = 14
        '
        'cmb_usuarios
        '
        Me.cmb_usuarios.FormattingEnabled = True
        Me.cmb_usuarios.Location = New System.Drawing.Point(88, 197)
        Me.cmb_usuarios.Name = "cmb_usuarios"
        Me.cmb_usuarios.Size = New System.Drawing.Size(451, 21)
        Me.cmb_usuarios.TabIndex = 13
        '
        'cmb_proyecto
        '
        Me.cmb_proyecto.FormattingEnabled = True
        Me.cmb_proyecto.Location = New System.Drawing.Point(88, 61)
        Me.cmb_proyecto.Name = "cmb_proyecto"
        Me.cmb_proyecto.Size = New System.Drawing.Size(451, 21)
        Me.cmb_proyecto.TabIndex = 12
        '
        'txt_voz
        '
        Me.txt_voz.Location = New System.Drawing.Point(88, 238)
        Me.txt_voz.Multiline = True
        Me.txt_voz.Name = "txt_voz"
        Me.txt_voz.Size = New System.Drawing.Size(451, 61)
        Me.txt_voz.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(34, 137)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Fecha: "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(36, 91)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Control: "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(34, 200)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Cadista: "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(27, 64)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Proyecto: "
        '
        'grp_fechas
        '
        Me.grp_fechas.Controls.Add(Me.chk_mes)
        Me.grp_fechas.Controls.Add(Me.chk_anio)
        Me.grp_fechas.Location = New System.Drawing.Point(253, 445)
        Me.grp_fechas.Name = "grp_fechas"
        Me.grp_fechas.Size = New System.Drawing.Size(163, 103)
        Me.grp_fechas.TabIndex = 12
        Me.grp_fechas.TabStop = False
        Me.grp_fechas.Text = "Datos a mostrar "
        '
        'chk_mes
        '
        Me.chk_mes.AutoSize = True
        Me.chk_mes.Checked = True
        Me.chk_mes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_mes.Location = New System.Drawing.Point(17, 63)
        Me.chk_mes.Name = "chk_mes"
        Me.chk_mes.Size = New System.Drawing.Size(46, 17)
        Me.chk_mes.TabIndex = 7
        Me.chk_mes.Text = "Mes"
        Me.chk_mes.UseVisualStyleBackColor = True
        '
        'chk_anio
        '
        Me.chk_anio.AutoSize = True
        Me.chk_anio.Checked = True
        Me.chk_anio.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_anio.Location = New System.Drawing.Point(17, 40)
        Me.chk_anio.Name = "chk_anio"
        Me.chk_anio.Size = New System.Drawing.Size(45, 17)
        Me.chk_anio.TabIndex = 6
        Me.chk_anio.Text = "Año"
        Me.chk_anio.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.AutoScroll = True
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.DisplayStatusBar = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(563, 22)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.reporteControles___Voz2
        Me.CrystalReportViewer1.ShowCopyButton = False
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowLogo = False
        Me.CrystalReportViewer1.ShowParameterPanelButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(693, 775)
        Me.CrystalReportViewer1.TabIndex = 8
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmReporteControles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1268, 808)
        Me.Controls.Add(Me.grp_fechas)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btn_obtener_reporte)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmReporteControles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Controles"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.grp_fechas.ResumeLayout(False)
        Me.grp_fechas.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chk_voz As System.Windows.Forms.CheckBox
    Friend WithEvents chk_fecha As System.Windows.Forms.CheckBox
    Friend WithEvents chk_control As System.Windows.Forms.CheckBox
    Friend WithEvents chk_cadista As System.Windows.Forms.CheckBox
    Friend WithEvents chk_proyecto As System.Windows.Forms.CheckBox
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents reporteControles1 As Dececco.reporteControles___Cadistas
    Friend WithEvents btn_obtener_reporte As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_voces As System.Windows.Forms.RadioButton
    Friend WithEvents rb_proyectos As System.Windows.Forms.RadioButton
    Friend WithEvents rb_controles As System.Windows.Forms.RadioButton
    Friend WithEvents rb_cadistas As System.Windows.Forms.RadioButton
    Friend WithEvents rb_empresa As System.Windows.Forms.RadioButton
    Friend WithEvents rb_clientes As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmb_proyecto As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha_hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fecha_desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmb_control As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_usuarios As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_cliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_voz As System.Windows.Forms.TextBox
    Friend WithEvents chk_clientes As System.Windows.Forms.CheckBox
    Friend WithEvents rb_actividad As System.Windows.Forms.RadioButton
    Friend WithEvents grp_fechas As System.Windows.Forms.GroupBox
    Friend WithEvents chk_mes As System.Windows.Forms.CheckBox
    Friend WithEvents chk_anio As System.Windows.Forms.CheckBox
    Friend WithEvents reporteControles___Voz1 As Dececco.reporteControles___Voz
    Friend WithEvents reporteControles___Voz2 As Dececco.reporteControles___Voz
    'ALANFriend WithEvents CrystalReport21 As Dececco.CrystalReport2
End Class
