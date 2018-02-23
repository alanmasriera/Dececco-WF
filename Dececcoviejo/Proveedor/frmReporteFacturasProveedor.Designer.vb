<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteFacturasProveedor
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
        Me.cop_factura_proveedor_GetAll_VencidaBDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DececcoDataSet = New Dececco.DececcoDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.lbl_id_proveedor = New System.Windows.Forms.Label()
        Me.cop_factura_proveedor_GetAll_VencidaBDTableAdapter = New Dececco.DececcoDataSetTableAdapters.cop_factura_proveedor_GetAll_VencidaBDTableAdapter()
        CType(Me.cop_factura_proveedor_GetAll_VencidaBDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DececcoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cop_factura_proveedor_GetAll_VencidaBDBindingSource
        '
        Me.cop_factura_proveedor_GetAll_VencidaBDBindingSource.DataMember = "cop_factura_proveedor_GetAll_VencidaBD"
        Me.cop_factura_proveedor_GetAll_VencidaBDBindingSource.DataSource = Me.DececcoDataSet
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
        ReportDataSource1.Value = Me.cop_factura_proveedor_GetAll_VencidaBDBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Dececco.rptFacturas_proveedor.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1016, 741)
        Me.ReportViewer1.TabIndex = 0
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.BackColor = System.Drawing.Color.Red
        Me.lbl_fecha.Location = New System.Drawing.Point(437, 285)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(13, 13)
        Me.lbl_fecha.TabIndex = 514
        Me.lbl_fecha.Text = "0"
        Me.lbl_fecha.Visible = False
        '
        'lbl_id_proveedor
        '
        Me.lbl_id_proveedor.AutoSize = True
        Me.lbl_id_proveedor.BackColor = System.Drawing.Color.Red
        Me.lbl_id_proveedor.Location = New System.Drawing.Point(482, 285)
        Me.lbl_id_proveedor.Name = "lbl_id_proveedor"
        Me.lbl_id_proveedor.Size = New System.Drawing.Size(13, 13)
        Me.lbl_id_proveedor.TabIndex = 515
        Me.lbl_id_proveedor.Text = "0"
        Me.lbl_id_proveedor.Visible = False
        '
        'cop_factura_proveedor_GetAll_VencidaBDTableAdapter
        '
        Me.cop_factura_proveedor_GetAll_VencidaBDTableAdapter.ClearBeforeFill = True
        '
        'frmReporteFacturasProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 741)
        Me.Controls.Add(Me.lbl_id_proveedor)
        Me.Controls.Add(Me.lbl_fecha)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmReporteFacturasProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReporteFacturasProveedor"
        CType(Me.cop_factura_proveedor_GetAll_VencidaBDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DececcoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents lbl_fecha As System.Windows.Forms.Label
    Friend WithEvents lblid_proveedor As System.Windows.Forms.Label
    Friend WithEvents lbl_id_proveedor As System.Windows.Forms.Label
    Friend WithEvents cop_factura_proveedor_GetAll_VencidaBDBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DececcoDataSet As Dececco.DececcoDataSet
    Friend WithEvents cop_factura_proveedor_GetAll_VencidaBDTableAdapter As Dececco.DececcoDataSetTableAdapters.cop_factura_proveedor_GetAll_VencidaBDTableAdapter
    'Friend WithEvents cop_factura_proveedor_GetAll_VencidaBDBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents PymenDataSet As Pymen.PymenDataSet
    'Friend WithEvents cop_factura_proveedor_GetAll_VencidaBDTableAdapter As Pymen.PymenDataSetTableAdapters.cop_factura_proveedor_GetAll_VencidaBDTableAdapter
End Class
