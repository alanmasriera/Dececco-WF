<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteOrdenVenta
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
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.cop_Recibo_proveedor_GetAllReporteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PymenDataSet = New Pymen.PymenDataSet
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.lblid_recibo_proveedor = New System.Windows.Forms.Label
        Me.cop_Recibo_proveedor_GetAllReporteTableAdapter = New Pymen.PymenDataSetTableAdapters.cop_Recibo_proveedor_GetAllReporteTableAdapter
        CType(Me.cop_Recibo_proveedor_GetAllReporteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PymenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cop_Recibo_proveedor_GetAllReporteBindingSource
        '
        Me.cop_Recibo_proveedor_GetAllReporteBindingSource.DataMember = "cop_Recibo_proveedor_GetAllReporte"
        Me.cop_Recibo_proveedor_GetAllReporteBindingSource.DataSource = Me.PymenDataSet
        '
        'PymenDataSet
        '
        Me.PymenDataSet.DataSetName = "PymenDataSet"
        Me.PymenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource3.Name = "PymenDataSet_cop_Recibo_proveedor_GetAllReporte"
        ReportDataSource3.Value = Me.cop_Recibo_proveedor_GetAllReporteBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Pymen.rptReciboProveedor.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(764, 555)
        Me.ReportViewer1.TabIndex = 0
        '
        'lblid_recibo_proveedor
        '
        Me.lblid_recibo_proveedor.AutoSize = True
        Me.lblid_recibo_proveedor.BackColor = System.Drawing.Color.Red
        Me.lblid_recibo_proveedor.Location = New System.Drawing.Point(392, 86)
        Me.lblid_recibo_proveedor.Name = "lblid_recibo_proveedor"
        Me.lblid_recibo_proveedor.Size = New System.Drawing.Size(13, 13)
        Me.lblid_recibo_proveedor.TabIndex = 566
        Me.lblid_recibo_proveedor.Text = "0"
        Me.lblid_recibo_proveedor.Visible = False
        '
        'cop_Recibo_proveedor_GetAllReporteTableAdapter
        '
        Me.cop_Recibo_proveedor_GetAllReporteTableAdapter.ClearBeforeFill = True
        '
        'frmReporteOrdenVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 555)
        Me.Controls.Add(Me.lblid_recibo_proveedor)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmReporteOrdenVenta"
        Me.Text = "frmReporteOrdenVenta"
        CType(Me.cop_Recibo_proveedor_GetAllReporteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PymenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents lblid_recibo_proveedor As System.Windows.Forms.Label
    Friend WithEvents cop_Recibo_proveedor_GetAllReporteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PymenDataSet As Pymen.PymenDataSet
    Friend WithEvents cop_Recibo_proveedor_GetAllReporteTableAdapter As Pymen.PymenDataSetTableAdapters.cop_Recibo_proveedor_GetAllReporteTableAdapter
End Class
