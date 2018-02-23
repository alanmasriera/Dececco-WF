<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerControles
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv_controles = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cmb_controlador_2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_controlador_1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chk_detallado = New System.Windows.Forms.CheckBox()
        Me.chk_preparado = New System.Windows.Forms.CheckBox()
        Me.chk_concepto = New System.Windows.Forms.CheckBox()
        Me.cmb_cliente = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtp_fecha_hasta = New System.Windows.Forms.DateTimePicker()
        Me.dtp_fecha_desde = New System.Windows.Forms.DateTimePicker()
        Me.cmb_control = New System.Windows.Forms.ComboBox()
        Me.cmb_usuarios = New System.Windows.Forms.ComboBox()
        Me.cmb_proyecto = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chk_clientes = New System.Windows.Forms.CheckBox()
        Me.chk_fecha = New System.Windows.Forms.CheckBox()
        Me.chk_etapas = New System.Windows.Forms.CheckBox()
        Me.chk_control = New System.Windows.Forms.CheckBox()
        Me.chk_cadista = New System.Windows.Forms.CheckBox()
        Me.chk_proyecto = New System.Windows.Forms.CheckBox()
        Me.btn_ver_reporte = New System.Windows.Forms.Button()
        Me.Background_pdf = New System.ComponentModel.BackgroundWorker()
        Me.ts_imprimir = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ts_imprimir_checklist = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        CType(Me.dgv_controles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ts_imprimir.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_controles
        '
        Me.dgv_controles.AllowUserToAddRows = False
        Me.dgv_controles.AllowUserToDeleteRows = False
        Me.dgv_controles.AllowUserToResizeRows = False
        Me.dgv_controles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_controles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_controles.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_controles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_controles.Location = New System.Drawing.Point(0, 224)
        Me.dgv_controles.Name = "dgv_controles"
        Me.dgv_controles.ReadOnly = True
        Me.dgv_controles.RowHeadersVisible = False
        Me.dgv_controles.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgv_controles.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.dgv_controles.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv_controles.RowTemplate.ReadOnly = True
        Me.dgv_controles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_controles.ShowCellErrors = False
        Me.dgv_controles.Size = New System.Drawing.Size(1170, 355)
        Me.dgv_controles.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cmb_controlador_2)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.cmb_controlador_1)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.chk_detallado)
        Me.GroupBox4.Controls.Add(Me.chk_preparado)
        Me.GroupBox4.Controls.Add(Me.chk_concepto)
        Me.GroupBox4.Controls.Add(Me.cmb_cliente)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.dtp_fecha_hasta)
        Me.GroupBox4.Controls.Add(Me.dtp_fecha_desde)
        Me.GroupBox4.Controls.Add(Me.cmb_control)
        Me.GroupBox4.Controls.Add(Me.cmb_usuarios)
        Me.GroupBox4.Controls.Add(Me.cmb_proyecto)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(925, 163)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Filtros"
        '
        'cmb_controlador_2
        '
        Me.cmb_controlador_2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_controlador_2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_controlador_2.FormattingEnabled = True
        Me.cmb_controlador_2.Location = New System.Drawing.Point(622, 49)
        Me.cmb_controlador_2.Name = "cmb_controlador_2"
        Me.cmb_controlador_2.Size = New System.Drawing.Size(297, 21)
        Me.cmb_controlador_2.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(540, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Controlador 2: "
        '
        'cmb_controlador_1
        '
        Me.cmb_controlador_1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_controlador_1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_controlador_1.FormattingEnabled = True
        Me.cmb_controlador_1.Location = New System.Drawing.Point(622, 23)
        Me.cmb_controlador_1.Name = "cmb_controlador_1"
        Me.cmb_controlador_1.Size = New System.Drawing.Size(297, 21)
        Me.cmb_controlador_1.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(540, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Controlador 1: "
        '
        'chk_detallado
        '
        Me.chk_detallado.AutoSize = True
        Me.chk_detallado.Checked = True
        Me.chk_detallado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_detallado.Location = New System.Drawing.Point(804, 132)
        Me.chk_detallado.Name = "chk_detallado"
        Me.chk_detallado.Size = New System.Drawing.Size(71, 17)
        Me.chk_detallado.TabIndex = 22
        Me.chk_detallado.Text = "Detallado"
        Me.chk_detallado.UseVisualStyleBackColor = True
        '
        'chk_preparado
        '
        Me.chk_preparado.AutoSize = True
        Me.chk_preparado.Checked = True
        Me.chk_preparado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_preparado.Location = New System.Drawing.Point(680, 132)
        Me.chk_preparado.Name = "chk_preparado"
        Me.chk_preparado.Size = New System.Drawing.Size(83, 17)
        Me.chk_preparado.TabIndex = 21
        Me.chk_preparado.Text = "Preparación"
        Me.chk_preparado.UseVisualStyleBackColor = True
        '
        'chk_concepto
        '
        Me.chk_concepto.AutoSize = True
        Me.chk_concepto.Checked = True
        Me.chk_concepto.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_concepto.Location = New System.Drawing.Point(563, 132)
        Me.chk_concepto.Name = "chk_concepto"
        Me.chk_concepto.Size = New System.Drawing.Size(72, 17)
        Me.chk_concepto.TabIndex = 20
        Me.chk_concepto.Text = "Concepto"
        Me.chk_concepto.UseVisualStyleBackColor = True
        '
        'cmb_cliente
        '
        Me.cmb_cliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_cliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_cliente.FormattingEnabled = True
        Me.cmb_cliente.Location = New System.Drawing.Point(60, 23)
        Me.cmb_cliente.Name = "cmb_cliente"
        Me.cmb_cliente.Size = New System.Drawing.Size(457, 21)
        Me.cmb_cliente.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Cliente: "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(544, 106)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 13)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Fecha hasta: "
        '
        'dtp_fecha_hasta
        '
        Me.dtp_fecha_hasta.Location = New System.Drawing.Point(622, 102)
        Me.dtp_fecha_hasta.Name = "dtp_fecha_hasta"
        Me.dtp_fecha_hasta.Size = New System.Drawing.Size(297, 20)
        Me.dtp_fecha_hasta.TabIndex = 16
        '
        'dtp_fecha_desde
        '
        Me.dtp_fecha_desde.Location = New System.Drawing.Point(622, 76)
        Me.dtp_fecha_desde.Name = "dtp_fecha_desde"
        Me.dtp_fecha_desde.Size = New System.Drawing.Size(297, 20)
        Me.dtp_fecha_desde.TabIndex = 15
        '
        'cmb_control
        '
        Me.cmb_control.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_control.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_control.FormattingEnabled = True
        Me.cmb_control.Location = New System.Drawing.Point(60, 76)
        Me.cmb_control.Name = "cmb_control"
        Me.cmb_control.Size = New System.Drawing.Size(457, 21)
        Me.cmb_control.TabIndex = 14
        '
        'cmb_usuarios
        '
        Me.cmb_usuarios.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_usuarios.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_usuarios.FormattingEnabled = True
        Me.cmb_usuarios.Location = New System.Drawing.Point(60, 103)
        Me.cmb_usuarios.Name = "cmb_usuarios"
        Me.cmb_usuarios.Size = New System.Drawing.Size(457, 21)
        Me.cmb_usuarios.TabIndex = 13
        '
        'cmb_proyecto
        '
        Me.cmb_proyecto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_proyecto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_proyecto.FormattingEnabled = True
        Me.cmb_proyecto.Location = New System.Drawing.Point(60, 49)
        Me.cmb_proyecto.Name = "cmb_proyecto"
        Me.cmb_proyecto.Size = New System.Drawing.Size(457, 21)
        Me.cmb_proyecto.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(573, 82)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Fecha: "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 79)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Control: "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 106)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Cadista: "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(-1, 52)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Proyecto: "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chk_clientes)
        Me.GroupBox2.Controls.Add(Me.chk_fecha)
        Me.GroupBox2.Controls.Add(Me.chk_etapas)
        Me.GroupBox2.Controls.Add(Me.chk_control)
        Me.GroupBox2.Controls.Add(Me.chk_cadista)
        Me.GroupBox2.Controls.Add(Me.chk_proyecto)
        Me.GroupBox2.Location = New System.Drawing.Point(943, 14)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(220, 161)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos a mostrar "
        '
        'chk_clientes
        '
        Me.chk_clientes.AutoSize = True
        Me.chk_clientes.Location = New System.Drawing.Point(144, 74)
        Me.chk_clientes.Name = "chk_clientes"
        Me.chk_clientes.Size = New System.Drawing.Size(63, 17)
        Me.chk_clientes.TabIndex = 11
        Me.chk_clientes.Text = "Clientes"
        Me.chk_clientes.UseVisualStyleBackColor = True
        '
        'chk_fecha
        '
        Me.chk_fecha.AutoSize = True
        Me.chk_fecha.Location = New System.Drawing.Point(144, 51)
        Me.chk_fecha.Name = "chk_fecha"
        Me.chk_fecha.Size = New System.Drawing.Size(56, 17)
        Me.chk_fecha.TabIndex = 9
        Me.chk_fecha.Text = "Fecha"
        Me.chk_fecha.UseVisualStyleBackColor = True
        '
        'chk_etapas
        '
        Me.chk_etapas.AutoSize = True
        Me.chk_etapas.Location = New System.Drawing.Point(144, 97)
        Me.chk_etapas.Name = "chk_etapas"
        Me.chk_etapas.Size = New System.Drawing.Size(59, 17)
        Me.chk_etapas.TabIndex = 10
        Me.chk_etapas.Text = "Etapas"
        Me.chk_etapas.UseVisualStyleBackColor = True
        '
        'chk_control
        '
        Me.chk_control.AutoSize = True
        Me.chk_control.Checked = True
        Me.chk_control.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_control.Location = New System.Drawing.Point(15, 97)
        Me.chk_control.Name = "chk_control"
        Me.chk_control.Size = New System.Drawing.Size(70, 17)
        Me.chk_control.TabIndex = 8
        Me.chk_control.Text = "Controles"
        Me.chk_control.UseVisualStyleBackColor = True
        '
        'chk_cadista
        '
        Me.chk_cadista.AutoSize = True
        Me.chk_cadista.Checked = True
        Me.chk_cadista.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_cadista.Location = New System.Drawing.Point(15, 74)
        Me.chk_cadista.Name = "chk_cadista"
        Me.chk_cadista.Size = New System.Drawing.Size(66, 17)
        Me.chk_cadista.TabIndex = 7
        Me.chk_cadista.Text = "Cadistas"
        Me.chk_cadista.UseVisualStyleBackColor = True
        '
        'chk_proyecto
        '
        Me.chk_proyecto.AutoSize = True
        Me.chk_proyecto.Checked = True
        Me.chk_proyecto.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_proyecto.Location = New System.Drawing.Point(15, 51)
        Me.chk_proyecto.Name = "chk_proyecto"
        Me.chk_proyecto.Size = New System.Drawing.Size(73, 17)
        Me.chk_proyecto.TabIndex = 6
        Me.chk_proyecto.Text = "Proyectos"
        Me.chk_proyecto.UseVisualStyleBackColor = True
        '
        'btn_ver_reporte
        '
        Me.btn_ver_reporte.Location = New System.Drawing.Point(943, 189)
        Me.btn_ver_reporte.Name = "btn_ver_reporte"
        Me.btn_ver_reporte.Size = New System.Drawing.Size(220, 23)
        Me.btn_ver_reporte.TabIndex = 14
        Me.btn_ver_reporte.Text = "Ver controles"
        Me.btn_ver_reporte.UseVisualStyleBackColor = True
        '
        'Background_pdf
        '
        '
        'ts_imprimir
        '
        Me.ts_imprimir.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_imprimir_checklist})
        Me.ts_imprimir.Name = "ts_imprimir"
        Me.ts_imprimir.Size = New System.Drawing.Size(116, 26)
        '
        'ts_imprimir_checklist
        '
        Me.ts_imprimir_checklist.Name = "ts_imprimir_checklist"
        Me.ts_imprimir_checklist.Size = New System.Drawing.Size(115, 22)
        Me.ts_imprimir_checklist.Text = "Ver PDF"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Nombre:"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(71, 191)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(866, 20)
        Me.txt_nombre.TabIndex = 16
        '
        'frmVerControles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1170, 579)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_ver_reporte)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgv_controles)
        Me.MinimumSize = New System.Drawing.Size(1186, 618)
        Me.Name = "frmVerControles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Controles Realizados"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgv_controles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ts_imprimir.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_controles As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents chk_detallado As System.Windows.Forms.CheckBox
    Friend WithEvents chk_preparado As System.Windows.Forms.CheckBox
    Friend WithEvents chk_concepto As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_cliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha_hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fecha_desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmb_control As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_usuarios As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_proyecto As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chk_clientes As System.Windows.Forms.CheckBox
    Friend WithEvents chk_etapas As System.Windows.Forms.CheckBox
    Friend WithEvents chk_fecha As System.Windows.Forms.CheckBox
    Friend WithEvents chk_control As System.Windows.Forms.CheckBox
    Friend WithEvents chk_cadista As System.Windows.Forms.CheckBox
    Friend WithEvents chk_proyecto As System.Windows.Forms.CheckBox
    Friend WithEvents btn_ver_reporte As System.Windows.Forms.Button
    Friend WithEvents Background_pdf As System.ComponentModel.BackgroundWorker
    Friend WithEvents ts_imprimir As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ts_imprimir_checklist As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmb_controlador_2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_controlador_1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
End Class
