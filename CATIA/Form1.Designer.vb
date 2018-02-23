<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.dgv_logueo = New System.Windows.Forms.DataGridView()
        Me.hora_inicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hora_fin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.parte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_logueo,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'dgv_logueo
        '
        Me.dgv_logueo.AllowUserToAddRows = false
        Me.dgv_logueo.AllowUserToDeleteRows = false
        Me.dgv_logueo.AllowUserToOrderColumns = true
        Me.dgv_logueo.AllowUserToResizeColumns = false
        Me.dgv_logueo.AllowUserToResizeRows = false
        Me.dgv_logueo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_logueo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_logueo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.hora_inicio, Me.hora_fin, Me.parte})
        Me.dgv_logueo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_logueo.Location = New System.Drawing.Point(0, 0)
        Me.dgv_logueo.Name = "dgv_logueo"
        Me.dgv_logueo.RowHeadersVisible = false
        Me.dgv_logueo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_logueo.Size = New System.Drawing.Size(577, 392)
        Me.dgv_logueo.TabIndex = 0
        '
        'hora_inicio
        '
        Me.hora_inicio.HeaderText = "Hora Inicio"
        Me.hora_inicio.Name = "hora_inicio"
        '
        'hora_fin
        '
        Me.hora_fin.HeaderText = "Hora Fin"
        Me.hora_fin.Name = "hora_fin"
        '
        'parte
        '
        Me.parte.HeaderText = "Parte"
        Me.parte.Name = "parte"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 392)
        Me.Controls.Add(Me.dgv_logueo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgv_logueo,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents dgv_logueo As System.Windows.Forms.DataGridView
    Friend WithEvents hora_inicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hora_fin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents parte As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
