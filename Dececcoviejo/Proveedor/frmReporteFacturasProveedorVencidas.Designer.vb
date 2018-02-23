<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteFacturasProveedorVencidas
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
        Me.cop_factura_proveedor_GetAll_VencidaBD_AllBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PymenDataSet = New Pymen.PymenDataSet
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.cop_factura_proveedor_GetAll_VencidaBD_AllTableAdapter = New Pymen.PymenDataSetTableAdapters.cop_factura_proveedor_GetAll_VencidaBD_AllTableAdapter
        CType(Me.cop_factura_proveedor_GetAll_VencidaBD_AllBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PymenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cop_factura_proveedor_GetAll_VencidaBD_AllBindingSource
        '
        Me.cop_factura_proveedor_GetAll_VencidaBD_AllBindingSource.DataMember = "cop_factura_proveedor_GetAll_VencidaBD_All"
        Me.cop_factura_proveedor_GetAll_VencidaBD_AllBindingSource.DataSource = Me.PymenDataSet
        '
        'PymenDataSet
        '
        Me.PymenDataSet.DataSetName = "PymenDataSet"
        Me.PymenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "PymenDataSet_cop_factura_proveedor_GetAll_VencidaBD_All"
        ReportDataSource1.Value = Me.cop_factura_proveedor_GetAll_VencidaBD_AllBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Pymen.rptFacturas_proveedor_vencidas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(693, 506)
        Me.ReportViewer1.TabIndex = 0
        '
        'cop_factura_proveedor_GetAll_VencidaBD_AllTableAdapter
        '
        Me.cop_factura_proveedor_GetAll_VencidaBD_AllTableAdapter.ClearBeforeFill = True
        '
        'frmReporteFacturasProveedorVencidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 506)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmReporteFacturasProveedorVencidas"
        Me.Text = "frmReporteFacturasProveedorVencidas"
        CType(Me.cop_factura_proveedor_GetAll_VencidaBD_AllBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PymenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents cop_factura_proveedor_GetAll_VencidaBD_AllBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PymenDataSet As Pymen.PymenDataSet
    Friend WithEvents cop_factura_proveedor_GetAll_VencidaBD_AllTableAdapter As Pymen.PymenDataSetTableAdapters.cop_factura_proveedor_GetAll_VencidaBD_AllTableAdapter
End Class
