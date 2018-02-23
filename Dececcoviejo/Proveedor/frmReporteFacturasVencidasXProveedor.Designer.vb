<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteFacturasVencidasXProveedor
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
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DececcoDataSet = New Dececco.DececcoDataSet()
        CType(Me.DececcoDataSet,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "Dececco.Report3.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(560, 329)
        Me.ReportViewer2.TabIndex = 0
        '
        'DececcoDataSet
        '
        Me.DececcoDataSet.DataSetName = "DececcoDataSet"
        Me.DececcoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmReporteFacturasVencidasXProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 329)
        Me.Controls.Add(Me.ReportViewer2)
        Me.Name = "frmReporteFacturasVencidasXProveedor"
        Me.Text = "frmReporteFacturasVencidasXProveedor"
        CType(Me.DececcoDataSet,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents cop_factura_proveedor_GetAll_VencidaBD_AllBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DececcoDataSet As Dececco.DececcoDataSet
    'Friend WithEvents PymenDataSet As Pymen.PymenDataSet
    ' Friend WithEvents cop_factura_proveedor_GetAll_VencidaBD_AllTableAdapter As Pymen.PymenDataSetTableAdapters.cop_factura_proveedor_GetAll_VencidaBD_AllTableAdapter
End Class
