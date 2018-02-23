<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporte_Saldo_Todos_Proveedores
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.cop_Consulta_saldo_proveedor_GetAll_2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DececcoDataSet = New Dececco.DececcoDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.cop_Consulta_saldo_proveedor_GetAll_2TableAdapter = New Dececco.DececcoDataSetTableAdapters.cop_Consulta_saldo_proveedor_GetAll_2TableAdapter()
        CType(Me.cop_Consulta_saldo_proveedor_GetAll_2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DececcoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cop_Consulta_saldo_proveedor_GetAll_2BindingSource
        '
        Me.cop_Consulta_saldo_proveedor_GetAll_2BindingSource.DataMember = "cop_Consulta_saldo_proveedor_GetAll_2"
        Me.cop_Consulta_saldo_proveedor_GetAll_2BindingSource.DataSource = Me.DececcoDataSet
        '
        'DececcoDataSet
        '
        Me.DececcoDataSet.DataSetName = "DececcoDataSet"
        Me.DececcoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.cop_Consulta_saldo_proveedor_GetAll_2BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Dececco.rptSaldo_todos_proveedores.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(717, 557)
        Me.ReportViewer1.TabIndex = 0
        '
        'cop_Consulta_saldo_proveedor_GetAll_2TableAdapter
        '
        Me.cop_Consulta_saldo_proveedor_GetAll_2TableAdapter.ClearBeforeFill = True
        '
        'frmReporte_Saldo_Todos_Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 557)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmReporte_Saldo_Todos_Proveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReporte_Saldo_Todos_Proveedores"
        CType(Me.cop_Consulta_saldo_proveedor_GetAll_2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DececcoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents cop_Consulta_saldo_proveedor_GetAll_2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DececcoDataSet As Dececco.DececcoDataSet
    Friend WithEvents cop_Consulta_saldo_proveedor_GetAll_2TableAdapter As Dececco.DececcoDataSetTableAdapters.cop_Consulta_saldo_proveedor_GetAll_2TableAdapter
    'Friend WithEvents cop_Consulta_saldo_proveedor_GetAll_2BindingSource As System.Windows.Forms.BindingSource
    ' Friend WithEvents PymenDataSet As Pymen.PymenDataSet
    ' Friend WithEvents cop_Consulta_saldo_proveedor_GetAll_2TableAdapter As Pymen.PymenDataSetTableAdapters.cop_Consulta_saldo_proveedor_GetAll_2TableAdapter
End Class
