<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPropiedadesActividad
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtHorasConsumidas = New System.Windows.Forms.TextBox()
        Me.btn_Aceptar = New System.Windows.Forms.Button()
        Me.grpBox_horas = New System.Windows.Forms.GroupBox()
        Me.dgv_horas_actividad = New System.Windows.Forms.DataGridView()
        Me.grpBox_horas.SuspendLayout()
        CType(Me.dgv_horas_actividad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 270)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 13)
        Me.Label7.TabIndex = 663
        Me.Label7.Text = "Total de Horas Consumidas: "
        '
        'txtHorasConsumidas
        '
        Me.txtHorasConsumidas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHorasConsumidas.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtHorasConsumidas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHorasConsumidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHorasConsumidas.Location = New System.Drawing.Point(167, 267)
        Me.txtHorasConsumidas.Name = "txtHorasConsumidas"
        Me.txtHorasConsumidas.Size = New System.Drawing.Size(100, 21)
        Me.txtHorasConsumidas.TabIndex = 662
        Me.txtHorasConsumidas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Aceptar.Location = New System.Drawing.Point(273, 316)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(75, 31)
        Me.btn_Aceptar.TabIndex = 661
        Me.btn_Aceptar.Text = "Aceptar"
        Me.btn_Aceptar.UseVisualStyleBackColor = True
        '
        'grpBox_horas
        '
        Me.grpBox_horas.AutoSize = True
        Me.grpBox_horas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.grpBox_horas.Controls.Add(Me.dgv_horas_actividad)
        Me.grpBox_horas.Location = New System.Drawing.Point(18, 11)
        Me.grpBox_horas.Name = "grpBox_horas"
        Me.grpBox_horas.Size = New System.Drawing.Size(336, 240)
        Me.grpBox_horas.TabIndex = 660
        Me.grpBox_horas.TabStop = False
        Me.grpBox_horas.Text = "Horas"
        '
        'dgv_horas_actividad
        '
        Me.dgv_horas_actividad.AllowUserToAddRows = False
        Me.dgv_horas_actividad.AllowUserToDeleteRows = False
        Me.dgv_horas_actividad.AllowUserToResizeRows = False
        Me.dgv_horas_actividad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_horas_actividad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_horas_actividad.ColumnHeadersVisible = False
        Me.dgv_horas_actividad.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_horas_actividad.Location = New System.Drawing.Point(6, 19)
        Me.dgv_horas_actividad.Name = "dgv_horas_actividad"
        Me.dgv_horas_actividad.ReadOnly = True
        Me.dgv_horas_actividad.RowHeadersVisible = False
        Me.dgv_horas_actividad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_horas_actividad.ShowCellErrors = False
        Me.dgv_horas_actividad.ShowRowErrors = False
        Me.dgv_horas_actividad.Size = New System.Drawing.Size(324, 202)
        Me.dgv_horas_actividad.TabIndex = 0
        '
        'frmPropiedadesActividad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(377, 359)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtHorasConsumidas)
        Me.Controls.Add(Me.btn_Aceptar)
        Me.Controls.Add(Me.grpBox_horas)
        Me.Name = "frmPropiedadesActividad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Propiedades de la Actividad"
        Me.grpBox_horas.ResumeLayout(False)
        CType(Me.dgv_horas_actividad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtHorasConsumidas As System.Windows.Forms.TextBox
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents grpBox_horas As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_horas_actividad As System.Windows.Forms.DataGridView
End Class
