<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerProyectosActivos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv_proyectos = New System.Windows.Forms.DataGridView()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.id_proyecto_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_cliente_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_proyecto_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chk_activo_dgv = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.dgv_proyectos,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'dgv_proyectos
        '
        Me.dgv_proyectos.AllowUserToAddRows = false
        Me.dgv_proyectos.AllowUserToDeleteRows = false
        Me.dgv_proyectos.AllowUserToOrderColumns = true
        Me.dgv_proyectos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.dgv_proyectos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_proyectos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_proyectos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_proyecto_dgv, Me.nombre_cliente_dgv, Me.nombre_proyecto_dgv, Me.chk_activo_dgv})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_proyectos.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_proyectos.Location = New System.Drawing.Point(0, 0)
        Me.dgv_proyectos.MultiSelect = false
        Me.dgv_proyectos.Name = "dgv_proyectos"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_proyectos.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_proyectos.RowHeadersVisible = false
        Me.dgv_proyectos.Size = New System.Drawing.Size(561, 433)
        Me.dgv_proyectos.TabIndex = 0
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Location = New System.Drawing.Point(474, 448)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 1
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = true
        '
        'id_proyecto_dgv
        '
        Me.id_proyecto_dgv.HeaderText = "id_proyecto_dgv"
        Me.id_proyecto_dgv.Name = "id_proyecto_dgv"
        Me.id_proyecto_dgv.Visible = false
        '
        'nombre_cliente_dgv
        '
        Me.nombre_cliente_dgv.FillWeight = 40!
        Me.nombre_cliente_dgv.HeaderText = "Cliente"
        Me.nombre_cliente_dgv.Name = "nombre_cliente_dgv"
        '
        'nombre_proyecto_dgv
        '
        Me.nombre_proyecto_dgv.FillWeight = 40!
        Me.nombre_proyecto_dgv.HeaderText = "Nombre proyecto"
        Me.nombre_proyecto_dgv.Name = "nombre_proyecto_dgv"
        '
        'chk_activo_dgv
        '
        Me.chk_activo_dgv.FillWeight = 20!
        Me.chk_activo_dgv.HeaderText = "Activo"
        Me.chk_activo_dgv.Name = "chk_activo_dgv"
        Me.chk_activo_dgv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'frmVerProyectosActivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 480)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.dgv_proyectos)
        Me.Name = "frmVerProyectosActivos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proyectos activos"
        CType(Me.dgv_proyectos,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents dgv_proyectos As DataGridView
    Friend WithEvents btnAceptar As Button
    Friend WithEvents id_proyecto_dgv As DataGridViewTextBoxColumn
    Friend WithEvents nombre_cliente_dgv As DataGridViewTextBoxColumn
    Friend WithEvents nombre_proyecto_dgv As DataGridViewTextBoxColumn
    Friend WithEvents chk_activo_dgv As DataGridViewCheckBoxColumn
End Class
