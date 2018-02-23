<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalendario
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbCalendarios = New System.Windows.Forms.ComboBox()
        Me.btnCrearCalendario = New System.Windows.Forms.Button()
        Me.calendarioMeses = New System.Windows.Forms.MonthCalendar()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabExcepciones = New System.Windows.Forms.TabPage()
        Me.dgvExcepciones = New System.Windows.Forms.DataGridView()
        Me.id_excepcion_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_excepcion_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_desde_excepcion_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_fin_excepcion_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabSemanasLaborales = New System.Windows.Forms.TabPage()
        Me.dgv_semanas_laborales = New System.Windows.Forms.DataGridView()
        Me.id_detalle_calendario_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_detalle_calendario_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_comienzo_detalle_calendario_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_fin_detalle_calendario_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDetalles = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.cmbCalendarioBase = New System.Windows.Forms.ComboBox()
        Me.lblCalBase = New System.Windows.Forms.Label()
        Me.btnAgregarDetalle = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout
        Me.tabExcepciones.SuspendLayout
        CType(Me.dgvExcepciones,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabSemanasLaborales.SuspendLayout
        CType(Me.dgv_semanas_laborales,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(25, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Calendario:"
        '
        'cmbCalendarios
        '
        Me.cmbCalendarios.FormattingEnabled = true
        Me.cmbCalendarios.Location = New System.Drawing.Point(91, 16)
        Me.cmbCalendarios.Name = "cmbCalendarios"
        Me.cmbCalendarios.Size = New System.Drawing.Size(225, 21)
        Me.cmbCalendarios.TabIndex = 1
        '
        'btnCrearCalendario
        '
        Me.btnCrearCalendario.Location = New System.Drawing.Point(396, 14)
        Me.btnCrearCalendario.Name = "btnCrearCalendario"
        Me.btnCrearCalendario.Size = New System.Drawing.Size(103, 23)
        Me.btnCrearCalendario.TabIndex = 2
        Me.btnCrearCalendario.Text = "Crear calendario"
        Me.btnCrearCalendario.UseVisualStyleBackColor = true
        '
        'calendarioMeses
        '
        Me.calendarioMeses.Location = New System.Drawing.Point(28, 76)
        Me.calendarioMeses.Name = "calendarioMeses"
        Me.calendarioMeses.TabIndex = 3
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabExcepciones)
        Me.TabControl1.Controls.Add(Me.tabSemanasLaborales)
        Me.TabControl1.Location = New System.Drawing.Point(28, 266)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(400, 189)
        Me.TabControl1.TabIndex = 4
        '
        'tabExcepciones
        '
        Me.tabExcepciones.Controls.Add(Me.dgvExcepciones)
        Me.tabExcepciones.Location = New System.Drawing.Point(4, 22)
        Me.tabExcepciones.Name = "tabExcepciones"
        Me.tabExcepciones.Padding = New System.Windows.Forms.Padding(3)
        Me.tabExcepciones.Size = New System.Drawing.Size(392, 163)
        Me.tabExcepciones.TabIndex = 0
        Me.tabExcepciones.Text = "Excepciones"
        Me.tabExcepciones.UseVisualStyleBackColor = true
        '
        'dgvExcepciones
        '
        Me.dgvExcepciones.AllowUserToAddRows = false
        Me.dgvExcepciones.AllowUserToDeleteRows = false
        Me.dgvExcepciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvExcepciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExcepciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_excepcion_dgv, Me.nombre_excepcion_dgv, Me.fecha_desde_excepcion_dgv, Me.fecha_fin_excepcion_dgv})
        Me.dgvExcepciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvExcepciones.Location = New System.Drawing.Point(3, 3)
        Me.dgvExcepciones.Name = "dgvExcepciones"
        Me.dgvExcepciones.RowHeadersVisible = false
        Me.dgvExcepciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvExcepciones.Size = New System.Drawing.Size(386, 157)
        Me.dgvExcepciones.TabIndex = 0
        '
        'id_excepcion_dgv
        '
        Me.id_excepcion_dgv.HeaderText = "id_excepcion_dgv"
        Me.id_excepcion_dgv.Name = "id_excepcion_dgv"
        Me.id_excepcion_dgv.Visible = false
        '
        'nombre_excepcion_dgv
        '
        Me.nombre_excepcion_dgv.FillWeight = 60!
        Me.nombre_excepcion_dgv.HeaderText = "Nombre"
        Me.nombre_excepcion_dgv.Name = "nombre_excepcion_dgv"
        '
        'fecha_desde_excepcion_dgv
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.fecha_desde_excepcion_dgv.DefaultCellStyle = DataGridViewCellStyle1
        Me.fecha_desde_excepcion_dgv.FillWeight = 20!
        Me.fecha_desde_excepcion_dgv.HeaderText = "Cominezo"
        Me.fecha_desde_excepcion_dgv.Name = "fecha_desde_excepcion_dgv"
        '
        'fecha_fin_excepcion_dgv
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.fecha_fin_excepcion_dgv.DefaultCellStyle = DataGridViewCellStyle2
        Me.fecha_fin_excepcion_dgv.FillWeight = 20!
        Me.fecha_fin_excepcion_dgv.HeaderText = "Fin"
        Me.fecha_fin_excepcion_dgv.Name = "fecha_fin_excepcion_dgv"
        '
        'tabSemanasLaborales
        '
        Me.tabSemanasLaborales.Controls.Add(Me.dgv_semanas_laborales)
        Me.tabSemanasLaborales.Location = New System.Drawing.Point(4, 22)
        Me.tabSemanasLaborales.Name = "tabSemanasLaborales"
        Me.tabSemanasLaborales.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSemanasLaborales.Size = New System.Drawing.Size(392, 163)
        Me.tabSemanasLaborales.TabIndex = 1
        Me.tabSemanasLaborales.Text = "Semanas laborales"
        Me.tabSemanasLaborales.UseVisualStyleBackColor = true
        '
        'dgv_semanas_laborales
        '
        Me.dgv_semanas_laborales.AllowUserToAddRows = false
        Me.dgv_semanas_laborales.AllowUserToDeleteRows = false
        Me.dgv_semanas_laborales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_semanas_laborales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_semanas_laborales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_detalle_calendario_dgv, Me.nombre_detalle_calendario_dgv, Me.fecha_comienzo_detalle_calendario_dgv, Me.fecha_fin_detalle_calendario_dgv})
        Me.dgv_semanas_laborales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_semanas_laborales.Location = New System.Drawing.Point(3, 3)
        Me.dgv_semanas_laborales.Name = "dgv_semanas_laborales"
        Me.dgv_semanas_laborales.RowHeadersVisible = false
        Me.dgv_semanas_laborales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_semanas_laborales.Size = New System.Drawing.Size(386, 157)
        Me.dgv_semanas_laborales.TabIndex = 1
        '
        'id_detalle_calendario_dgv
        '
        Me.id_detalle_calendario_dgv.HeaderText = "id_detalle_calendario_dgv"
        Me.id_detalle_calendario_dgv.Name = "id_detalle_calendario_dgv"
        Me.id_detalle_calendario_dgv.Visible = false
        '
        'nombre_detalle_calendario_dgv
        '
        Me.nombre_detalle_calendario_dgv.FillWeight = 60!
        Me.nombre_detalle_calendario_dgv.HeaderText = "Nombre"
        Me.nombre_detalle_calendario_dgv.Name = "nombre_detalle_calendario_dgv"
        '
        'fecha_comienzo_detalle_calendario_dgv
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.fecha_comienzo_detalle_calendario_dgv.DefaultCellStyle = DataGridViewCellStyle3
        Me.fecha_comienzo_detalle_calendario_dgv.FillWeight = 20!
        Me.fecha_comienzo_detalle_calendario_dgv.HeaderText = "Cominezo"
        Me.fecha_comienzo_detalle_calendario_dgv.Name = "fecha_comienzo_detalle_calendario_dgv"
        '
        'fecha_fin_detalle_calendario_dgv
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.fecha_fin_detalle_calendario_dgv.DefaultCellStyle = DataGridViewCellStyle4
        Me.fecha_fin_detalle_calendario_dgv.FillWeight = 20!
        Me.fecha_fin_detalle_calendario_dgv.HeaderText = "Fin"
        Me.fecha_fin_detalle_calendario_dgv.Name = "fecha_fin_detalle_calendario_dgv"
        '
        'btnDetalles
        '
        Me.btnDetalles.Location = New System.Drawing.Point(443, 386)
        Me.btnDetalles.Name = "btnDetalles"
        Me.btnDetalles.Size = New System.Drawing.Size(75, 23)
        Me.btnDetalles.TabIndex = 5
        Me.btnDetalles.Text = "Detalles"
        Me.btnDetalles.UseVisualStyleBackColor = true
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(443, 425)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 6
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = true
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(454, 481)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 7
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = true
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(364, 481)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = true
        '
        'cmbCalendarioBase
        '
        Me.cmbCalendarioBase.FormattingEnabled = true
        Me.cmbCalendarioBase.Location = New System.Drawing.Point(117, 43)
        Me.cmbCalendarioBase.Name = "cmbCalendarioBase"
        Me.cmbCalendarioBase.Size = New System.Drawing.Size(199, 21)
        Me.cmbCalendarioBase.TabIndex = 10
        '
        'lblCalBase
        '
        Me.lblCalBase.AutoSize = true
        Me.lblCalBase.Location = New System.Drawing.Point(25, 46)
        Me.lblCalBase.Name = "lblCalBase"
        Me.lblCalBase.Size = New System.Drawing.Size(86, 13)
        Me.lblCalBase.TabIndex = 9
        Me.lblCalBase.Text = "Calendario base:"
        '
        'btnAgregarDetalle
        '
        Me.btnAgregarDetalle.Location = New System.Drawing.Point(443, 313)
        Me.btnAgregarDetalle.Name = "btnAgregarDetalle"
        Me.btnAgregarDetalle.Size = New System.Drawing.Size(39, 23)
        Me.btnAgregarDetalle.TabIndex = 11
        Me.btnAgregarDetalle.Text = "+"
        Me.btnAgregarDetalle.UseVisualStyleBackColor = true
        '
        'frmCalendario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 516)
        Me.Controls.Add(Me.btnAgregarDetalle)
        Me.Controls.Add(Me.cmbCalendarioBase)
        Me.Controls.Add(Me.lblCalBase)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnDetalles)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.calendarioMeses)
        Me.Controls.Add(Me.btnCrearCalendario)
        Me.Controls.Add(Me.cmbCalendarios)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = false
        Me.Name = "frmCalendario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calendario"
        Me.TabControl1.ResumeLayout(false)
        Me.tabExcepciones.ResumeLayout(false)
        CType(Me.dgvExcepciones,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabSemanasLaborales.ResumeLayout(false)
        CType(Me.dgv_semanas_laborales,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmbCalendarios As ComboBox
    Friend WithEvents btnCrearCalendario As Button
    Friend WithEvents calendarioMeses As MonthCalendar
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabExcepciones As TabPage
    Friend WithEvents dgvExcepciones As DataGridView
    Friend WithEvents tabSemanasLaborales As TabPage
    Friend WithEvents btnDetalles As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents cmbCalendarioBase As ComboBox
    Friend WithEvents lblCalBase As Label
    Friend WithEvents dgv_semanas_laborales As DataGridView
    Friend WithEvents btnAgregarDetalle As Button
    Friend WithEvents id_excepcion_dgv As DataGridViewTextBoxColumn
    Friend WithEvents nombre_excepcion_dgv As DataGridViewTextBoxColumn
    Friend WithEvents fecha_desde_excepcion_dgv As DataGridViewTextBoxColumn
    Friend WithEvents fecha_fin_excepcion_dgv As DataGridViewTextBoxColumn
    Friend WithEvents id_detalle_calendario_dgv As DataGridViewTextBoxColumn
    Friend WithEvents nombre_detalle_calendario_dgv As DataGridViewTextBoxColumn
    Friend WithEvents fecha_comienzo_detalle_calendario_dgv As DataGridViewTextBoxColumn
    Friend WithEvents fecha_fin_detalle_calendario_dgv As DataGridViewTextBoxColumn
End Class
