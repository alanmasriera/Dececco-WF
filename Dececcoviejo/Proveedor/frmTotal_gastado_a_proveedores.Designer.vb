<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTotal_gastado_a_proveedores
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
        Me.cop_Recibo_proveedor_GetAll_4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PymenDataSet = New Pymen.PymenDataSet
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.cop_Recibo_proveedor_GetAll_4TableAdapter = New Pymen.PymenDataSetTableAdapters.cop_Recibo_proveedor_GetAll_4TableAdapter
        CType(Me.cop_Recibo_proveedor_GetAll_4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PymenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cop_Recibo_proveedor_GetAll_4BindingSource
        '
        Me.cop_Recibo_proveedor_GetAll_4BindingSource.DataMember = "cop_Recibo_proveedor_GetAll_4"
        Me.cop_Recibo_proveedor_GetAll_4BindingSource.DataSource = Me.PymenDataSet
        '
        'PymenDataSet
        '
        Me.PymenDataSet.DataSetName = "PymenDataSet"
        Me.PymenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "PymenDataSet_cop_Recibo_proveedor_GetAll_4"
        ReportDataSource1.Value = Me.cop_Recibo_proveedor_GetAll_4BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Pymen.rptReciboProveedor1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(685, 532)
        Me.ReportViewer1.TabIndex = 0
        '
        'cop_Recibo_proveedor_GetAll_4TableAdapter
        '
        Me.cop_Recibo_proveedor_GetAll_4TableAdapter.ClearBeforeFill = True
        '
        'frmTotal_gastado_a_proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 532)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmTotal_gastado_a_proveedores"
        Me.Text = "frmTotal_gastado_a_proveedores"
        CType(Me.cop_Recibo_proveedor_GetAll_4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PymenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents cop_Recibo_proveedor_GetAll_4BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PymenDataSet As Pymen.PymenDataSet
    Friend WithEvents cop_Recibo_proveedor_GetAll_4TableAdapter As Pymen.PymenDataSetTableAdapters.cop_Recibo_proveedor_GetAll_4TableAdapter
End Class
