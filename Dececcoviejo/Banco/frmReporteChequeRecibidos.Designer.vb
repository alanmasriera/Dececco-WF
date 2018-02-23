<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteChequeRecibidos
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
        Me.cop_CuentaBuscarBancoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DececcoDataSet = New Dececco.DececcoDataSet()
        Me.cop_ChequeRecibidoConsultarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cop_ChequeRecibidoConsultarTableAdapter = New Dececco.DececcoDataSetTableAdapters.cop_ChequeRecibidoConsultarTableAdapter()
        CType(Me.cop_CuentaBuscarBancoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DececcoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cop_ChequeRecibidoConsultarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.cop_ChequeRecibidoConsultarBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Dececco.rptRecibidos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(689, 593)
        Me.ReportViewer1.TabIndex = 0
        '
        'DececcoDataSet
        '
        Me.DececcoDataSet.DataSetName = "DececcoDataSet"
        Me.DececcoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cop_ChequeRecibidoConsultarBindingSource
        '
        Me.cop_ChequeRecibidoConsultarBindingSource.DataMember = "cop_ChequeRecibidoConsultar"
        Me.cop_ChequeRecibidoConsultarBindingSource.DataSource = Me.DececcoDataSet
        '
        'cop_ChequeRecibidoConsultarTableAdapter
        '
        Me.cop_ChequeRecibidoConsultarTableAdapter.ClearBeforeFill = True
        '
        'frmReporteChequeRecibidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 593)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmReporteChequeRecibidos"
        Me.Text = "frmReporteChequeRecibidos"
        CType(Me.cop_CuentaBuscarBancoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DececcoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cop_ChequeRecibidoConsultarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents cop_CuentaBuscarBancoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cop_ChequeRecibidoConsultarBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DececcoDataSet As Dececco.DececcoDataSet
    Friend WithEvents cop_ChequeRecibidoConsultarTableAdapter As Dececco.DececcoDataSetTableAdapters.cop_ChequeRecibidoConsultarTableAdapter
End Class
