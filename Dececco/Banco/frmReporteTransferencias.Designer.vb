<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteTransferencias
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.cop_TransferenciaConsultarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DececcoDataSet = New DececcoDataSet
        Me.cop_CuentaBuscarBancoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.cop_TransferenciaConsultarTableAdapter = New DececcoDataSetTableAdapters.cop_TransferenciaConsultarTableAdapter
        Me.cop_CuentaBuscarBancoTableAdapter = New DececcoDataSetTableAdapters.cop_CuentaBuscarBancoTableAdapter
        CType(Me.cop_TransferenciaConsultarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DececcoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cop_CuentaBuscarBancoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cop_TransferenciaConsultarBindingSource
        '
        Me.cop_TransferenciaConsultarBindingSource.DataMember = "cop_TransferenciaConsultar"
        Me.cop_TransferenciaConsultarBindingSource.DataSource = Me.DececcoDataSet
        '
        'DececcoDataSet
        '
        Me.DececcoDataSet.DataSetName = "DececcoDataSet"
        Me.DececcoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cop_CuentaBuscarBancoBindingSource
        '
        Me.cop_CuentaBuscarBancoBindingSource.DataMember = "cop_CuentaBuscarBanco"
        Me.cop_CuentaBuscarBancoBindingSource.DataSource = Me.DececcoDataSet
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DececcoDataSet_cop_TransferenciaConsultar"
        ReportDataSource1.Value = Me.cop_TransferenciaConsultarBindingSource
        ReportDataSource2.Name = "DececcoDataSet_cop_CuentaBuscarBanco"
        ReportDataSource2.Value = Me.cop_CuentaBuscarBancoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Pymen.rptTransferencias.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(730, 576)
        Me.ReportViewer1.TabIndex = 0
        '
        'cop_TransferenciaConsultarTableAdapter
        '
        Me.cop_TransferenciaConsultarTableAdapter.ClearBeforeFill = True
        '
        'cop_CuentaBuscarBancoTableAdapter
        '
        Me.cop_CuentaBuscarBancoTableAdapter.ClearBeforeFill = True
        '
        'frmReporteTransferencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 576)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmReporteTransferencias"
        Me.Text = "frmReporteTransferencias"
        CType(Me.cop_TransferenciaConsultarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DececcoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cop_CuentaBuscarBancoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents cop_TransferenciaConsultarBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DececcoDataSet As DececcoDataSet
    Friend WithEvents cop_CuentaBuscarBancoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cop_TransferenciaConsultarTableAdapter As DececcoDataSetTableAdapters.cop_TransferenciaConsultarTableAdapter
    Friend WithEvents cop_CuentaBuscarBancoTableAdapter As DececcoDataSetTableAdapters.cop_CuentaBuscarBancoTableAdapter
End Class
