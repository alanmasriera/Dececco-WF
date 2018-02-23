<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteResumenProveedor
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
        Me.components = New System.ComponentModel.Container
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.cop_Resumen_proveedor_SetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PymenDataSet = New Pymen.PymenDataSet
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.lblid_proveedor = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbl_fecha = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cop_Resumen_proveedor_SetTableAdapter = New Pymen.PymenDataSetTableAdapters.cop_Resumen_proveedor_SetTableAdapter
        CType(Me.cop_Resumen_proveedor_SetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PymenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cop_Resumen_proveedor_SetBindingSource
        '
        Me.cop_Resumen_proveedor_SetBindingSource.DataMember = "cop_Resumen_proveedor_Set"
        Me.cop_Resumen_proveedor_SetBindingSource.DataSource = Me.PymenDataSet
        '
        'PymenDataSet
        '
        Me.PymenDataSet.DataSetName = "PymenDataSet"
        Me.PymenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "PymenDataSet_cop_Resumen_proveedor_Set"
        ReportDataSource1.Value = Me.cop_Resumen_proveedor_SetBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Pymen.rptResumenProveedor.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(745, 545)
        Me.ReportViewer1.TabIndex = 0
        '
        'lblid_proveedor
        '
        Me.lblid_proveedor.AutoSize = True
        Me.lblid_proveedor.BackColor = System.Drawing.Color.Red
        Me.lblid_proveedor.Location = New System.Drawing.Point(174, 148)
        Me.lblid_proveedor.Name = "lblid_proveedor"
        Me.lblid_proveedor.Size = New System.Drawing.Size(13, 13)
        Me.lblid_proveedor.TabIndex = 510
        Me.lblid_proveedor.Text = "0"
        Me.lblid_proveedor.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(260, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 511
        Me.Label1.Text = "0"
        Me.Label1.Visible = False
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.BackColor = System.Drawing.Color.Red
        Me.lbl_fecha.Location = New System.Drawing.Point(215, 148)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(13, 13)
        Me.lbl_fecha.TabIndex = 512
        Me.lbl_fecha.Text = "0"
        Me.lbl_fecha.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(310, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 513
        Me.Label3.Text = "0"
        Me.Label3.Visible = False
        '
        'cop_Resumen_proveedor_SetTableAdapter
        '
        Me.cop_Resumen_proveedor_SetTableAdapter.ClearBeforeFill = True
        '
        'frmReporteResumenProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 545)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_fecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblid_proveedor)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmReporteResumenProveedor"
        Me.Text = "frmReporteResumenProveedor"
        CType(Me.cop_Resumen_proveedor_SetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PymenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents lblid_proveedor As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_fecha As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cop_Resumen_proveedor_SetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PymenDataSet As Pymen.PymenDataSet
    Friend WithEvents cop_Resumen_proveedor_SetTableAdapter As Pymen.PymenDataSetTableAdapters.cop_Resumen_proveedor_SetTableAdapter
End Class
