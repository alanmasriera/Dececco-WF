﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteResumenBancario
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.DececcoDataSet = New DececcoDataSet
        Me.cop_Resumen_cuenta_ConsultarResumenCuenta2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cop_Resumen_cuenta_ConsultarResumenCuenta2TableAdapter = New DececcoDataSetTableAdapters.cop_Resumen_cuenta_ConsultarResumenCuenta2TableAdapter
        CType(Me.DececcoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cop_Resumen_cuenta_ConsultarResumenCuenta2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DececcoDataSet_cop_Resumen_cuenta_ConsultarResumenCuenta2"
        ReportDataSource1.Value = Me.cop_Resumen_cuenta_ConsultarResumenCuenta2BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Pymen.rptResumenBancario_2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(757, 621)
        Me.ReportViewer1.TabIndex = 0
        '
        'DececcoDataSet
        '
        Me.DececcoDataSet.DataSetName = "DececcoDataSet"
        Me.DececcoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cop_Resumen_cuenta_ConsultarResumenCuenta2BindingSource
        '
        Me.cop_Resumen_cuenta_ConsultarResumenCuenta2BindingSource.DataMember = "cop_Resumen_cuenta_ConsultarResumenCuenta2"
        Me.cop_Resumen_cuenta_ConsultarResumenCuenta2BindingSource.DataSource = Me.DececcoDataSet
        '
        'cop_Resumen_cuenta_ConsultarResumenCuenta2TableAdapter
        '
        Me.cop_Resumen_cuenta_ConsultarResumenCuenta2TableAdapter.ClearBeforeFill = True
        '
        'frmReporteResumenBancario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 621)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmReporteResumenBancario"
        Me.Text = "frmReporteResumenBancario"
        CType(Me.DececcoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cop_Resumen_cuenta_ConsultarResumenCuenta2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents cop_Resumen_cuenta_ConsultarResumenCuenta2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DececcoDataSet As DececcoDataSet
    Friend WithEvents cop_Resumen_cuenta_ConsultarResumenCuenta2TableAdapter As DececcoDataSetTableAdapters.cop_Resumen_cuenta_ConsultarResumenCuenta2TableAdapter
End Class
