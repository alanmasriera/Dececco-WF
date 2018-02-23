<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmABMEstadoProyecto
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_guardar_estado = New System.Windows.Forms.Button()
        Me.btn_agregar_estado = New System.Windows.Forms.Button()
        Me.btn_nuevo_estado = New System.Windows.Forms.Button()
        Me.btn_seleccionar = New System.Windows.Forms.Button()
        Me.btn_modificar_estado = New System.Windows.Forms.Button()
        Me.dgv_estados = New System.Windows.Forms.DataGridView()
        Me.id_estado_subproyecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.porcentaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_buscar_estado = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_buscar_nombre = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtnum_porcentaje = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nombre_estado = New System.Windows.Forms.TextBox()
        Me.ts_estado = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ts_borrar_estado = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTipNuevo = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.dgv_estados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtnum_porcentaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ts_estado.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_guardar_estado
        '
        Me.btn_guardar_estado.BackgroundImage = Global.Dececco.My.Resources.Resources.save1
        Me.btn_guardar_estado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_guardar_estado.Enabled = False
        Me.btn_guardar_estado.Location = New System.Drawing.Point(489, 473)
        Me.btn_guardar_estado.Name = "btn_guardar_estado"
        Me.btn_guardar_estado.Size = New System.Drawing.Size(76, 53)
        Me.btn_guardar_estado.TabIndex = 33
        Me.btn_guardar_estado.UseVisualStyleBackColor = True
        '
        'btn_agregar_estado
        '
        Me.btn_agregar_estado.Location = New System.Drawing.Point(491, 41)
        Me.btn_agregar_estado.Name = "btn_agregar_estado"
        Me.btn_agregar_estado.Size = New System.Drawing.Size(75, 23)
        Me.btn_agregar_estado.TabIndex = 32
        Me.btn_agregar_estado.Text = "Agregar"
        Me.btn_agregar_estado.UseVisualStyleBackColor = True
        '
        'btn_nuevo_estado
        '
        Me.btn_nuevo_estado.BackgroundImage = Global.Dececco.My.Resources.Resources.new1
        Me.btn_nuevo_estado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_nuevo_estado.Location = New System.Drawing.Point(17, 473)
        Me.btn_nuevo_estado.Name = "btn_nuevo_estado"
        Me.btn_nuevo_estado.Size = New System.Drawing.Size(75, 53)
        Me.btn_nuevo_estado.TabIndex = 31
        Me.ToolTipNuevo.SetToolTip(Me.btn_nuevo_estado, "Nuevo")
        Me.btn_nuevo_estado.UseVisualStyleBackColor = True
        '
        'btn_seleccionar
        '
        Me.btn_seleccionar.Enabled = False
        Me.btn_seleccionar.Location = New System.Drawing.Point(490, 473)
        Me.btn_seleccionar.Name = "btn_seleccionar"
        Me.btn_seleccionar.Size = New System.Drawing.Size(76, 28)
        Me.btn_seleccionar.TabIndex = 30
        Me.btn_seleccionar.Text = "Seleccionar"
        Me.btn_seleccionar.UseVisualStyleBackColor = True
        '
        'btn_modificar_estado
        '
        Me.btn_modificar_estado.BackgroundImage = Global.Dececco.My.Resources.Resources.editar1
        Me.btn_modificar_estado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_modificar_estado.Location = New System.Drawing.Point(98, 473)
        Me.btn_modificar_estado.Name = "btn_modificar_estado"
        Me.btn_modificar_estado.Size = New System.Drawing.Size(75, 53)
        Me.btn_modificar_estado.TabIndex = 29
        Me.ToolTipNuevo.SetToolTip(Me.btn_modificar_estado, "Modificar")
        Me.btn_modificar_estado.UseVisualStyleBackColor = True
        '
        'dgv_estados
        '
        Me.dgv_estados.AllowUserToAddRows = False
        Me.dgv_estados.AllowUserToDeleteRows = False
        Me.dgv_estados.AllowUserToResizeRows = False
        Me.dgv_estados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_estados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_estado_subproyecto, Me.nombre, Me.porcentaje})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_estados.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_estados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_estados.Location = New System.Drawing.Point(16, 134)
        Me.dgv_estados.Name = "dgv_estados"
        Me.dgv_estados.ReadOnly = True
        Me.dgv_estados.RowHeadersVisible = False
        Me.dgv_estados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_estados.ShowCellErrors = False
        Me.dgv_estados.ShowRowErrors = False
        Me.dgv_estados.Size = New System.Drawing.Size(549, 333)
        Me.dgv_estados.TabIndex = 28
        '
        'id_estado_subproyecto
        '
        Me.id_estado_subproyecto.HeaderText = "id_estado_subproyecto"
        Me.id_estado_subproyecto.Name = "id_estado_subproyecto"
        Me.id_estado_subproyecto.ReadOnly = True
        Me.id_estado_subproyecto.Visible = False
        '
        'nombre
        '
        Me.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nombre.FillWeight = 85.0!
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        '
        'porcentaje
        '
        Me.porcentaje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.NullValue = Nothing
        Me.porcentaje.DefaultCellStyle = DataGridViewCellStyle3
        Me.porcentaje.FillWeight = 15.0!
        Me.porcentaje.HeaderText = "Porcentaje"
        Me.porcentaje.Name = "porcentaje"
        Me.porcentaje.ReadOnly = True
        '
        'btn_buscar_estado
        '
        Me.btn_buscar_estado.Location = New System.Drawing.Point(490, 93)
        Me.btn_buscar_estado.Name = "btn_buscar_estado"
        Me.btn_buscar_estado.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscar_estado.TabIndex = 27
        Me.btn_buscar_estado.Text = "Buscar"
        Me.btn_buscar_estado.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 98)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Nombre:"
        '
        'txt_buscar_nombre
        '
        Me.txt_buscar_nombre.Location = New System.Drawing.Point(65, 95)
        Me.txt_buscar_nombre.Name = "txt_buscar_nombre"
        Me.txt_buscar_nombre.Size = New System.Drawing.Size(419, 20)
        Me.txt_buscar_nombre.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(553, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "_________________________________________________________________________________" & _
    "__________"
        '
        'txtnum_porcentaje
        '
        Me.txtnum_porcentaje.DecimalPlaces = 2
        Me.txtnum_porcentaje.Location = New System.Drawing.Point(81, 38)
        Me.txtnum_porcentaje.Name = "txtnum_porcentaje"
        Me.txtnum_porcentaje.Size = New System.Drawing.Size(57, 20)
        Me.txtnum_porcentaje.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(144, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "%"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Porcentaje:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Nombre:"
        '
        'txt_nombre_estado
        '
        Me.txt_nombre_estado.Location = New System.Drawing.Point(81, 12)
        Me.txt_nombre_estado.Name = "txt_nombre_estado"
        Me.txt_nombre_estado.Size = New System.Drawing.Size(484, 20)
        Me.txt_nombre_estado.TabIndex = 19
        '
        'ts_estado
        '
        Me.ts_estado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_borrar_estado})
        Me.ts_estado.Name = "ts_actividad"
        Me.ts_estado.Size = New System.Drawing.Size(107, 26)
        '
        'ts_borrar_estado
        '
        Me.ts_borrar_estado.Name = "ts_borrar_estado"
        Me.ts_borrar_estado.Size = New System.Drawing.Size(106, 22)
        Me.ts_borrar_estado.Text = "Borrar"
        '
        'frmABMEstadoProyecto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 537)
        Me.Controls.Add(Me.btn_guardar_estado)
        Me.Controls.Add(Me.btn_agregar_estado)
        Me.Controls.Add(Me.btn_nuevo_estado)
        Me.Controls.Add(Me.btn_seleccionar)
        Me.Controls.Add(Me.btn_modificar_estado)
        Me.Controls.Add(Me.dgv_estados)
        Me.Controls.Add(Me.btn_buscar_estado)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_buscar_nombre)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtnum_porcentaje)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_nombre_estado)
        Me.Name = "frmABMEstadoProyecto"
        Me.Text = "Estados de proyecto"
        CType(Me.dgv_estados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtnum_porcentaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ts_estado.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents btn_guardar_estado As System.Windows.Forms.Button
    Friend WithEvents btn_agregar_estado As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo_estado As System.Windows.Forms.Button
    Public WithEvents btn_seleccionar As System.Windows.Forms.Button
    Friend WithEvents btn_modificar_estado As System.Windows.Forms.Button
    Public WithEvents dgv_estados As System.Windows.Forms.DataGridView
    Friend WithEvents btn_buscar_estado As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_buscar_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtnum_porcentaje As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre_estado As System.Windows.Forms.TextBox
    Friend WithEvents ts_estado As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ts_borrar_estado As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents id_estado_subproyecto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents porcentaje As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolTipNuevo As System.Windows.Forms.ToolTip
End Class
