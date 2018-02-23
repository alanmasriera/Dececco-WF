<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResumenPeriodico
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv_clientes = New System.Windows.Forms.DataGridView()
        Me.id_cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cliente_seleccionado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dgv_usuarios = New System.Windows.Forms.DataGridView()
        Me.id_usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usuario_seleccionado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtp_fecha_hasta = New System.Windows.Forms.DateTimePicker()
        Me.dtp_fecha_desde = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_total_horas = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_calcular = New System.Windows.Forms.Button()
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_usuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_clientes
        '
        Me.dgv_clientes.AllowUserToAddRows = False
        Me.dgv_clientes.AllowUserToResizeRows = False
        Me.dgv_clientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_cliente, Me.cliente, Me.cliente_seleccionado})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_clientes.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_clientes.Location = New System.Drawing.Point(16, 113)
        Me.dgv_clientes.Name = "dgv_clientes"
        Me.dgv_clientes.RowHeadersVisible = False
        Me.dgv_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_clientes.Size = New System.Drawing.Size(468, 587)
        Me.dgv_clientes.TabIndex = 770
        '
        'id_cliente
        '
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.id_cliente.DefaultCellStyle = DataGridViewCellStyle1
        Me.id_cliente.HeaderText = "id_clienete"
        Me.id_cliente.Name = "id_cliente"
        Me.id_cliente.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.id_cliente.Visible = False
        '
        'cliente
        '
        Me.cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cliente.FillWeight = 160.4892!
        Me.cliente.HeaderText = "Cliente"
        Me.cliente.Name = "cliente"
        Me.cliente.ReadOnly = True
        '
        'cliente_seleccionado
        '
        Me.cliente_seleccionado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.cliente_seleccionado.HeaderText = "Seleccionar"
        Me.cliente_seleccionado.Name = "cliente_seleccionado"
        Me.cliente_seleccionado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cliente_seleccionado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cliente_seleccionado.Width = 80
        '
        'dgv_usuarios
        '
        Me.dgv_usuarios.AllowUserToAddRows = False
        Me.dgv_usuarios.AllowUserToResizeRows = False
        Me.dgv_usuarios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_usuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_usuario, Me.usuario, Me.usuario_seleccionado})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_usuarios.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_usuarios.Location = New System.Drawing.Point(532, 113)
        Me.dgv_usuarios.Name = "dgv_usuarios"
        Me.dgv_usuarios.RowHeadersVisible = False
        Me.dgv_usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_usuarios.Size = New System.Drawing.Size(468, 587)
        Me.dgv_usuarios.TabIndex = 771
        '
        'id_usuario
        '
        Me.id_usuario.HeaderText = "id_usuario"
        Me.id_usuario.Name = "id_usuario"
        Me.id_usuario.Visible = False
        '
        'usuario
        '
        Me.usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.usuario.FillWeight = 160.4892!
        Me.usuario.HeaderText = "Usuario"
        Me.usuario.Name = "usuario"
        '
        'usuario_seleccionado
        '
        Me.usuario_seleccionado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.usuario_seleccionado.HeaderText = "Seleccionar"
        Me.usuario_seleccionado.Name = "usuario_seleccionado"
        Me.usuario_seleccionado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.usuario_seleccionado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.usuario_seleccionado.Width = 80
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(330, 58)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 13)
        Me.Label13.TabIndex = 775
        Me.Label13.Text = "Hasta: "
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtp_fecha_hasta
        '
        Me.dtp_fecha_hasta.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dtp_fecha_hasta.Location = New System.Drawing.Point(374, 55)
        Me.dtp_fecha_hasta.Name = "dtp_fecha_hasta"
        Me.dtp_fecha_hasta.Size = New System.Drawing.Size(297, 20)
        Me.dtp_fecha_hasta.TabIndex = 774
        '
        'dtp_fecha_desde
        '
        Me.dtp_fecha_desde.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dtp_fecha_desde.Location = New System.Drawing.Point(374, 24)
        Me.dtp_fecha_desde.Name = "dtp_fecha_desde"
        Me.dtp_fecha_desde.Size = New System.Drawing.Size(297, 20)
        Me.dtp_fecha_desde.TabIndex = 773
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(330, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 772
        Me.Label9.Text = "Desde: "
        '
        'lbl_total_horas
        '
        Me.lbl_total_horas.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lbl_total_horas.AutoSize = True
        Me.lbl_total_horas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total_horas.Location = New System.Drawing.Point(613, 724)
        Me.lbl_total_horas.Name = "lbl_total_horas"
        Me.lbl_total_horas.Size = New System.Drawing.Size(14, 13)
        Me.lbl_total_horas.TabIndex = 777
        Me.lbl_total_horas.Text = "0"
        Me.lbl_total_horas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(529, 724)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 776
        Me.Label2.Text = "Total de horas:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_calcular
        '
        Me.btn_calcular.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_calcular.Location = New System.Drawing.Point(374, 719)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(110, 23)
        Me.btn_calcular.TabIndex = 779
        Me.btn_calcular.Text = "calcular"
        Me.btn_calcular.UseVisualStyleBackColor = True
        '
        'frmResumenPeriodico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1021, 764)
        Me.Controls.Add(Me.btn_calcular)
        Me.Controls.Add(Me.lbl_total_horas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.dtp_fecha_hasta)
        Me.Controls.Add(Me.dtp_fecha_desde)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dgv_usuarios)
        Me.Controls.Add(Me.dgv_clientes)
        Me.Name = "frmResumenPeriodico"
        Me.Text = "Resumen periodico por cliente/usuario"
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_usuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_clientes As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_usuarios As System.Windows.Forms.DataGridView
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha_hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fecha_desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents id_usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents usuario_seleccionado As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents lbl_total_horas As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents id_cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cliente_seleccionado As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents btn_calcular As System.Windows.Forms.Button
End Class
