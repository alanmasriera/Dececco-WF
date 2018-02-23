<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmABMActividad
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txt_nombre_actividad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnum_peso = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_buscar_nombre = New System.Windows.Forms.TextBox()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.dgv_actividad = New System.Windows.Forms.DataGridView()
        Me.ts_actividad = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ts_borrar_tipo_actividad = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_seleccionar = New System.Windows.Forms.Button()
        Me.btn_agregaar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.chk_permitir_logueo = New System.Windows.Forms.CheckBox()
        Me.ToolTipNuevo = New System.Windows.Forms.ToolTip(Me.components)
        Me.chk_asignable = New System.Windows.Forms.CheckBox()
        Me.id_actividad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.porcentaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.logueo_habilitado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Asignable = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.txtnum_peso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_actividad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ts_actividad.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_nombre_actividad
        '
        Me.txt_nombre_actividad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_nombre_actividad.Location = New System.Drawing.Point(61, 18)
        Me.txt_nombre_actividad.Name = "txt_nombre_actividad"
        Me.txt_nombre_actividad.Size = New System.Drawing.Size(499, 20)
        Me.txt_nombre_actividad.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Peso:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(124, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "%"
        '
        'txtnum_peso
        '
        Me.txtnum_peso.DecimalPlaces = 2
        Me.txtnum_peso.Location = New System.Drawing.Point(61, 45)
        Me.txtnum_peso.Name = "txtnum_peso"
        Me.txtnum_peso.Size = New System.Drawing.Size(57, 20)
        Me.txtnum_peso.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(553, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "_________________________________________________________________________________" & _
    "__________"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Nombre:"
        '
        'txt_buscar_nombre
        '
        Me.txt_buscar_nombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_buscar_nombre.Location = New System.Drawing.Point(61, 109)
        Me.txt_buscar_nombre.Name = "txt_buscar_nombre"
        Me.txt_buscar_nombre.Size = New System.Drawing.Size(419, 20)
        Me.txt_buscar_nombre.TabIndex = 10
        '
        'btn_buscar
        '
        Me.btn_buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_buscar.Location = New System.Drawing.Point(486, 107)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscar.TabIndex = 12
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'dgv_actividad
        '
        Me.dgv_actividad.AllowUserToAddRows = False
        Me.dgv_actividad.AllowUserToDeleteRows = False
        Me.dgv_actividad.AllowUserToResizeRows = False
        Me.dgv_actividad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_actividad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_actividad.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_actividad, Me.descripcion, Me.porcentaje, Me.logueo_habilitado, Me.Asignable})
        Me.dgv_actividad.ContextMenuStrip = Me.ts_actividad
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_actividad.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_actividad.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_actividad.Location = New System.Drawing.Point(11, 143)
        Me.dgv_actividad.Name = "dgv_actividad"
        Me.dgv_actividad.ReadOnly = True
        Me.dgv_actividad.RowHeadersVisible = False
        Me.dgv_actividad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_actividad.ShowCellErrors = False
        Me.dgv_actividad.ShowRowErrors = False
        Me.dgv_actividad.Size = New System.Drawing.Size(549, 330)
        Me.dgv_actividad.TabIndex = 13
        '
        'ts_actividad
        '
        Me.ts_actividad.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_borrar_tipo_actividad})
        Me.ts_actividad.Name = "ts_actividad"
        Me.ts_actividad.Size = New System.Drawing.Size(107, 26)
        '
        'ts_borrar_tipo_actividad
        '
        Me.ts_borrar_tipo_actividad.Name = "ts_borrar_tipo_actividad"
        Me.ts_borrar_tipo_actividad.Size = New System.Drawing.Size(106, 22)
        Me.ts_borrar_tipo_actividad.Text = "Borrar"
        '
        'btn_seleccionar
        '
        Me.btn_seleccionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_seleccionar.Enabled = False
        Me.btn_seleccionar.Location = New System.Drawing.Point(485, 479)
        Me.btn_seleccionar.Name = "btn_seleccionar"
        Me.btn_seleccionar.Size = New System.Drawing.Size(76, 28)
        Me.btn_seleccionar.TabIndex = 15
        Me.btn_seleccionar.Text = "Seleccionar"
        Me.btn_seleccionar.UseVisualStyleBackColor = True
        '
        'btn_agregaar
        '
        Me.btn_agregaar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_agregaar.Location = New System.Drawing.Point(486, 47)
        Me.btn_agregaar.Name = "btn_agregaar"
        Me.btn_agregaar.Size = New System.Drawing.Size(75, 23)
        Me.btn_agregaar.TabIndex = 17
        Me.btn_agregaar.Text = "Agregar"
        Me.btn_agregaar.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_guardar.BackgroundImage = Global.Dececco.My.Resources.Resources.save1
        Me.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_guardar.Enabled = False
        Me.btn_guardar.Location = New System.Drawing.Point(484, 479)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(76, 53)
        Me.btn_guardar.TabIndex = 18
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_nuevo.BackgroundImage = Global.Dececco.My.Resources.Resources.new1
        Me.btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_nuevo.Location = New System.Drawing.Point(12, 479)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(75, 53)
        Me.btn_nuevo.TabIndex = 16
        Me.ToolTipNuevo.SetToolTip(Me.btn_nuevo, "Nueva")
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'btn_modificar
        '
        Me.btn_modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_modificar.BackgroundImage = Global.Dececco.My.Resources.Resources.editar1
        Me.btn_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_modificar.Location = New System.Drawing.Point(93, 479)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(75, 53)
        Me.btn_modificar.TabIndex = 14
        Me.ToolTipNuevo.SetToolTip(Me.btn_modificar, "Modificar")
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'chk_permitir_logueo
        '
        Me.chk_permitir_logueo.AutoSize = True
        Me.chk_permitir_logueo.Location = New System.Drawing.Point(156, 46)
        Me.chk_permitir_logueo.Name = "chk_permitir_logueo"
        Me.chk_permitir_logueo.Size = New System.Drawing.Size(207, 17)
        Me.chk_permitir_logueo.TabIndex = 19
        Me.chk_permitir_logueo.Text = "Permitir logueo sin asignación de tarea"
        Me.chk_permitir_logueo.UseVisualStyleBackColor = True
        '
        'chk_asignable
        '
        Me.chk_asignable.AutoSize = True
        Me.chk_asignable.Checked = True
        Me.chk_asignable.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_asignable.Location = New System.Drawing.Point(156, 69)
        Me.chk_asignable.Name = "chk_asignable"
        Me.chk_asignable.Size = New System.Drawing.Size(132, 17)
        Me.chk_asignable.TabIndex = 20
        Me.chk_asignable.Text = "Es actividad asignable"
        Me.chk_asignable.UseVisualStyleBackColor = True
        '
        'id_actividad
        '
        Me.id_actividad.HeaderText = "id_actividad"
        Me.id_actividad.Name = "id_actividad"
        Me.id_actividad.ReadOnly = True
        Me.id_actividad.Visible = False
        '
        'descripcion
        '
        Me.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.descripcion.FillWeight = 29.41177!
        Me.descripcion.HeaderText = "Nombre"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        '
        'porcentaje
        '
        Me.porcentaje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.NullValue = Nothing
        Me.porcentaje.DefaultCellStyle = DataGridViewCellStyle1
        Me.porcentaje.FillWeight = 70.58823!
        Me.porcentaje.HeaderText = "Porcentaje"
        Me.porcentaje.Name = "porcentaje"
        Me.porcentaje.ReadOnly = True
        Me.porcentaje.Width = 80
        '
        'logueo_habilitado
        '
        Me.logueo_habilitado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.logueo_habilitado.HeaderText = "Permite logueo"
        Me.logueo_habilitado.Name = "logueo_habilitado"
        Me.logueo_habilitado.ReadOnly = True
        '
        'Asignable
        '
        Me.Asignable.HeaderText = "Asignable"
        Me.Asignable.Name = "Asignable"
        Me.Asignable.ReadOnly = True
        Me.Asignable.Width = 80
        '
        'frmABMActividad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 536)
        Me.Controls.Add(Me.chk_asignable)
        Me.Controls.Add(Me.chk_permitir_logueo)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_agregaar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.btn_seleccionar)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.dgv_actividad)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_buscar_nombre)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtnum_peso)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_nombre_actividad)
        Me.MinimumSize = New System.Drawing.Size(453, 314)
        Me.Name = "frmABMActividad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrar Actividades"
        Me.ToolTipNuevo.SetToolTip(Me, "sdfs")
        CType(Me.txtnum_peso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_actividad,System.ComponentModel.ISupportInitialize).EndInit
        Me.ts_actividad.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents txt_nombre_actividad As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtnum_peso As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_buscar_nombre As System.Windows.Forms.TextBox
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_agregaar As System.Windows.Forms.Button
    Friend WithEvents ts_actividad As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ts_borrar_tipo_actividad As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents dgv_actividad As System.Windows.Forms.DataGridView
    Public WithEvents btn_seleccionar As System.Windows.Forms.Button
    Public WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents chk_permitir_logueo As System.Windows.Forms.CheckBox
    Friend WithEvents ToolTipNuevo As System.Windows.Forms.ToolTip
    Friend WithEvents id_actividad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents porcentaje As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents logueo_habilitado As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Asignable As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents chk_asignable As System.Windows.Forms.CheckBox
End Class
