<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleCalSemanal
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
        Me.lstDias = New System.Windows.Forms.ListBox()
        Me.dgv_detalle_calendario = New System.Windows.Forms.DataGridView()
        Me.hora_inicio_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hora_fin_dgv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.rdTomarDeBase = New System.Windows.Forms.RadioButton()
        Me.rdNoLaborable = New System.Windows.Forms.RadioButton()
        Me.rdPeriodoEspecifico = New System.Windows.Forms.RadioButton()
        CType(Me.dgv_detalle_calendario,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'lstDias
        '
        Me.lstDias.FormattingEnabled = true
        Me.lstDias.Items.AddRange(New Object() {"Domingo", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado"})
        Me.lstDias.Location = New System.Drawing.Point(12, 63)
        Me.lstDias.Name = "lstDias"
        Me.lstDias.Size = New System.Drawing.Size(107, 147)
        Me.lstDias.TabIndex = 0
        '
        'dgv_detalle_calendario
        '
        Me.dgv_detalle_calendario.AllowUserToAddRows = false
        Me.dgv_detalle_calendario.AllowUserToDeleteRows = false
        Me.dgv_detalle_calendario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_detalle_calendario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detalle_calendario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.hora_inicio_dgv, Me.hora_fin_dgv})
        Me.dgv_detalle_calendario.Location = New System.Drawing.Point(142, 143)
        Me.dgv_detalle_calendario.Name = "dgv_detalle_calendario"
        Me.dgv_detalle_calendario.RowHeadersVisible = false
        Me.dgv_detalle_calendario.Size = New System.Drawing.Size(287, 137)
        Me.dgv_detalle_calendario.TabIndex = 1
        '
        'hora_inicio_dgv
        '
        Me.hora_inicio_dgv.HeaderText = "Comienzo"
        Me.hora_inicio_dgv.Name = "hora_inicio_dgv"
        '
        'hora_fin_dgv
        '
        Me.hora_fin_dgv.HeaderText = "Fin"
        Me.hora_fin_dgv.Name = "hora_fin_dgv"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Seleccione los horarios por cada día"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(264, 298)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 10
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = true
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(354, 298)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 9
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = true
        '
        'rdTomarDeBase
        '
        Me.rdTomarDeBase.AutoSize = true
        Me.rdTomarDeBase.Location = New System.Drawing.Point(142, 63)
        Me.rdTomarDeBase.Name = "rdTomarDeBase"
        Me.rdTomarDeBase.Size = New System.Drawing.Size(278, 17)
        Me.rdTomarDeBase.TabIndex = 11
        Me.rdTomarDeBase.TabStop = true
        Me.rdTomarDeBase.Text = "Utilizar los períodos predeterminados para esta fecha."
        Me.rdTomarDeBase.UseVisualStyleBackColor = true
        '
        'rdNoLaborable
        '
        Me.rdNoLaborable.AutoSize = true
        Me.rdNoLaborable.Location = New System.Drawing.Point(142, 86)
        Me.rdNoLaborable.Name = "rdNoLaborable"
        Me.rdNoLaborable.Size = New System.Drawing.Size(232, 17)
        Me.rdNoLaborable.TabIndex = 12
        Me.rdNoLaborable.TabStop = true
        Me.rdNoLaborable.Text = "Establecer días como período no laborable."
        Me.rdNoLaborable.UseVisualStyleBackColor = true
        '
        'rdPeriodoEspecifico
        '
        Me.rdPeriodoEspecifico.AutoSize = true
        Me.rdPeriodoEspecifico.Location = New System.Drawing.Point(142, 109)
        Me.rdPeriodoEspecifico.Name = "rdPeriodoEspecifico"
        Me.rdPeriodoEspecifico.Size = New System.Drawing.Size(287, 17)
        Me.rdPeriodoEspecifico.TabIndex = 13
        Me.rdPeriodoEspecifico.TabStop = true
        Me.rdPeriodoEspecifico.Text = "Establecer días en los períodos laborables específicos."
        Me.rdPeriodoEspecifico.UseVisualStyleBackColor = true
        '
        'frmDetalleCalSemanal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 334)
        Me.Controls.Add(Me.rdPeriodoEspecifico)
        Me.Controls.Add(Me.rdNoLaborable)
        Me.Controls.Add(Me.rdTomarDeBase)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_detalle_calendario)
        Me.Controls.Add(Me.lstDias)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = false
        Me.Name = "frmDetalleCalSemanal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Detalle semanal"
        CType(Me.dgv_detalle_calendario,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents lstDias As ListBox
    Friend WithEvents dgv_detalle_calendario As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents hora_inicio_dgv As DataGridViewTextBoxColumn
    Friend WithEvents hora_fin_dgv As DataGridViewTextBoxColumn
    Friend WithEvents rdTomarDeBase As RadioButton
    Friend WithEvents rdNoLaborable As RadioButton
    Friend WithEvents rdPeriodoEspecifico As RadioButton
End Class
