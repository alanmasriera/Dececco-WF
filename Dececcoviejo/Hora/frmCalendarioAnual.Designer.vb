<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalendarioAnual
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.calendario_control = New System.Windows.Forms.MonthCalendar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chk_dia_laboral = New System.Windows.Forms.CheckBox()
        Me.chk_feriado = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtp_hora_fin = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtp_hora_inicio = New System.Windows.Forms.DateTimePicker()
        Me.txt_nombre_dia = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_dia_seleccionado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.cmb_miembros_calendario = New System.Windows.Forms.ComboBox()
        Me.btn_agregar_miembro_calendario = New System.Windows.Forms.Button()
        Me.dgv_miembros_subproyecto = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btn_guardar_personal = New System.Windows.Forms.Button()
        Me.cmb_miembro_personal = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_motivo_personal = New System.Windows.Forms.TextBox()
        Me.txt_apellido_usuario = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_nombre_usuario = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chk_trabaja_personal = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtp_hora_hasta_personal = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtp_hora_desde_personal = New System.Windows.Forms.DateTimePicker()
        Me.id_usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv_miembros_subproyecto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'calendario_control
        '
        Me.calendario_control.Location = New System.Drawing.Point(18, 27)
        Me.calendario_control.MaxSelectionCount = 1
        Me.calendario_control.Name = "calendario_control"
        Me.calendario_control.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chk_dia_laboral)
        Me.GroupBox1.Controls.Add(Me.chk_feriado)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtp_hora_fin)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtp_hora_inicio)
        Me.GroupBox1.Controls.Add(Me.txt_nombre_dia)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_dia_seleccionado)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 229)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(245, 280)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Propiedades"
        '
        'chk_dia_laboral
        '
        Me.chk_dia_laboral.AutoSize = True
        Me.chk_dia_laboral.Location = New System.Drawing.Point(28, 196)
        Me.chk_dia_laboral.Name = "chk_dia_laboral"
        Me.chk_dia_laboral.Size = New System.Drawing.Size(78, 17)
        Me.chk_dia_laboral.TabIndex = 9
        Me.chk_dia_laboral.Text = "Día laboral"
        Me.chk_dia_laboral.UseVisualStyleBackColor = True
        '
        'chk_feriado
        '
        Me.chk_feriado.AutoSize = True
        Me.chk_feriado.Location = New System.Drawing.Point(28, 173)
        Me.chk_feriado.Name = "chk_feriado"
        Me.chk_feriado.Size = New System.Drawing.Size(61, 17)
        Me.chk_feriado.TabIndex = 8
        Me.chk_feriado.Text = "Feriado"
        Me.chk_feriado.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Hasta:"
        '
        'dtp_hora_fin
        '
        Me.dtp_hora_fin.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp_hora_fin.Location = New System.Drawing.Point(50, 125)
        Me.dtp_hora_fin.Name = "dtp_hora_fin"
        Me.dtp_hora_fin.Size = New System.Drawing.Size(109, 20)
        Me.dtp_hora_fin.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Desde:"
        '
        'dtp_hora_inicio
        '
        Me.dtp_hora_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp_hora_inicio.Location = New System.Drawing.Point(50, 99)
        Me.dtp_hora_inicio.Name = "dtp_hora_inicio"
        Me.dtp_hora_inicio.Size = New System.Drawing.Size(109, 20)
        Me.dtp_hora_inicio.TabIndex = 4
        '
        'txt_nombre_dia
        '
        Me.txt_nombre_dia.Location = New System.Drawing.Point(59, 64)
        Me.txt_nombre_dia.Name = "txt_nombre_dia"
        Me.txt_nombre_dia.ReadOnly = True
        Me.txt_nombre_dia.Size = New System.Drawing.Size(157, 20)
        Me.txt_nombre_dia.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre:"
        '
        'txt_dia_seleccionado
        '
        Me.txt_dia_seleccionado.Location = New System.Drawing.Point(59, 34)
        Me.txt_dia_seleccionado.Name = "txt_dia_seleccionado"
        Me.txt_dia_seleccionado.ReadOnly = True
        Me.txt_dia_seleccionado.Size = New System.Drawing.Size(157, 20)
        Me.txt_dia_seleccionado.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Día:"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(297, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(287, 497)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cmb_miembros_calendario)
        Me.TabPage1.Controls.Add(Me.btn_agregar_miembro_calendario)
        Me.TabPage1.Controls.Add(Me.dgv_miembros_subproyecto)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(279, 471)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Miembros"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'cmb_miembros_calendario
        '
        Me.cmb_miembros_calendario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_miembros_calendario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_miembros_calendario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_miembros_calendario.FormattingEnabled = True
        Me.cmb_miembros_calendario.Location = New System.Drawing.Point(6, 17)
        Me.cmb_miembros_calendario.Name = "cmb_miembros_calendario"
        Me.cmb_miembros_calendario.Size = New System.Drawing.Size(189, 21)
        Me.cmb_miembros_calendario.TabIndex = 771
        '
        'btn_agregar_miembro_calendario
        '
        Me.btn_agregar_miembro_calendario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_agregar_miembro_calendario.Location = New System.Drawing.Point(201, 16)
        Me.btn_agregar_miembro_calendario.Name = "btn_agregar_miembro_calendario"
        Me.btn_agregar_miembro_calendario.Size = New System.Drawing.Size(72, 23)
        Me.btn_agregar_miembro_calendario.TabIndex = 770
        Me.btn_agregar_miembro_calendario.Text = "Agregar"
        Me.btn_agregar_miembro_calendario.UseVisualStyleBackColor = True
        '
        'dgv_miembros_subproyecto
        '
        Me.dgv_miembros_subproyecto.AllowUserToAddRows = False
        Me.dgv_miembros_subproyecto.AllowUserToResizeRows = False
        Me.dgv_miembros_subproyecto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_miembros_subproyecto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_miembros_subproyecto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_miembros_subproyecto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_usuario, Me.nombre_usuario})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_miembros_subproyecto.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_miembros_subproyecto.Location = New System.Drawing.Point(6, 45)
        Me.dgv_miembros_subproyecto.Name = "dgv_miembros_subproyecto"
        Me.dgv_miembros_subproyecto.RowHeadersVisible = False
        Me.dgv_miembros_subproyecto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_miembros_subproyecto.Size = New System.Drawing.Size(267, 420)
        Me.dgv_miembros_subproyecto.TabIndex = 769
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btn_guardar_personal)
        Me.TabPage2.Controls.Add(Me.cmb_miembro_personal)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.txt_motivo_personal)
        Me.TabPage2.Controls.Add(Me.txt_apellido_usuario)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.txt_nombre_usuario)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.chk_trabaja_personal)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.dtp_hora_hasta_personal)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.dtp_hora_desde_personal)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(279, 471)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Personal"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btn_guardar_personal
        '
        Me.btn_guardar_personal.Location = New System.Drawing.Point(198, 442)
        Me.btn_guardar_personal.Name = "btn_guardar_personal"
        Me.btn_guardar_personal.Size = New System.Drawing.Size(75, 23)
        Me.btn_guardar_personal.TabIndex = 774
        Me.btn_guardar_personal.Text = "Guardar"
        Me.btn_guardar_personal.UseVisualStyleBackColor = True
        '
        'cmb_miembro_personal
        '
        Me.cmb_miembro_personal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_miembro_personal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_miembro_personal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_miembro_personal.FormattingEnabled = True
        Me.cmb_miembro_personal.Location = New System.Drawing.Point(9, 20)
        Me.cmb_miembro_personal.Name = "cmb_miembro_personal"
        Me.cmb_miembro_personal.Size = New System.Drawing.Size(264, 21)
        Me.cmb_miembro_personal.TabIndex = 773
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 236)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Motivo:"
        '
        'txt_motivo_personal
        '
        Me.txt_motivo_personal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_motivo_personal.Location = New System.Drawing.Point(6, 257)
        Me.txt_motivo_personal.Multiline = True
        Me.txt_motivo_personal.Name = "txt_motivo_personal"
        Me.txt_motivo_personal.Size = New System.Drawing.Size(267, 179)
        Me.txt_motivo_personal.TabIndex = 17
        '
        'txt_apellido_usuario
        '
        Me.txt_apellido_usuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_apellido_usuario.Location = New System.Drawing.Point(62, 86)
        Me.txt_apellido_usuario.Name = "txt_apellido_usuario"
        Me.txt_apellido_usuario.ReadOnly = True
        Me.txt_apellido_usuario.Size = New System.Drawing.Size(157, 20)
        Me.txt_apellido_usuario.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Apellido:"
        '
        'txt_nombre_usuario
        '
        Me.txt_nombre_usuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_nombre_usuario.Location = New System.Drawing.Point(62, 56)
        Me.txt_nombre_usuario.Name = "txt_nombre_usuario"
        Me.txt_nombre_usuario.ReadOnly = True
        Me.txt_nombre_usuario.Size = New System.Drawing.Size(157, 20)
        Me.txt_nombre_usuario.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Nombre:"
        '
        'chk_trabaja_personal
        '
        Me.chk_trabaja_personal.AutoSize = True
        Me.chk_trabaja_personal.Location = New System.Drawing.Point(62, 204)
        Me.chk_trabaja_personal.Name = "chk_trabaja_personal"
        Me.chk_trabaja_personal.Size = New System.Drawing.Size(62, 17)
        Me.chk_trabaja_personal.TabIndex = 12
        Me.chk_trabaja_personal.Text = "Trabaja"
        Me.chk_trabaja_personal.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Hasta:"
        '
        'dtp_hora_hasta_personal
        '
        Me.dtp_hora_hasta_personal.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp_hora_hasta_personal.Location = New System.Drawing.Point(62, 156)
        Me.dtp_hora_hasta_personal.Name = "dtp_hora_hasta_personal"
        Me.dtp_hora_hasta_personal.Size = New System.Drawing.Size(109, 20)
        Me.dtp_hora_hasta_personal.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Desde:"
        '
        'dtp_hora_desde_personal
        '
        Me.dtp_hora_desde_personal.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp_hora_desde_personal.Location = New System.Drawing.Point(62, 130)
        Me.dtp_hora_desde_personal.Name = "dtp_hora_desde_personal"
        Me.dtp_hora_desde_personal.Size = New System.Drawing.Size(109, 20)
        Me.dtp_hora_desde_personal.TabIndex = 8
        '
        'id_usuario
        '
        Me.id_usuario.HeaderText = "id_usuario"
        Me.id_usuario.Name = "id_usuario"
        Me.id_usuario.Visible = False
        '
        'nombre_usuario
        '
        Me.nombre_usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nombre_usuario.FillWeight = 160.4892!
        Me.nombre_usuario.HeaderText = "Nombre"
        Me.nombre_usuario.Name = "nombre_usuario"
        '
        'frmCalendarioAnual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 521)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.calendario_control)
        Me.Name = "frmCalendarioAnual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calendario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgv_miembros_subproyecto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents calendario_control As System.Windows.Forms.MonthCalendar
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chk_dia_laboral As System.Windows.Forms.CheckBox
    Friend WithEvents chk_feriado As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtp_hora_fin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtp_hora_inicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_nombre_dia As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_dia_seleccionado As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_motivo_personal As System.Windows.Forms.TextBox
    Friend WithEvents txt_apellido_usuario As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre_usuario As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents chk_trabaja_personal As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtp_hora_hasta_personal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtp_hora_desde_personal As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmb_miembros_calendario As System.Windows.Forms.ComboBox
    Friend WithEvents btn_agregar_miembro_calendario As System.Windows.Forms.Button
    Friend WithEvents dgv_miembros_subproyecto As System.Windows.Forms.DataGridView
    Friend WithEvents btn_guardar_personal As System.Windows.Forms.Button
    Friend WithEvents cmb_miembro_personal As System.Windows.Forms.ComboBox
    Friend WithEvents id_usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_usuario As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
