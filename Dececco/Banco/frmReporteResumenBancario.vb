Public Class frmReporteResumenBancario

    Private Sub frmReporteResumenBancario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DececcoDataSet.cop_Resumen_cuenta_ConsultarResumenCuenta2' table. You can move, or remove it, as needed.
        Me.Cop_Resumen_cuenta_ConsultarResumenCuenta2TableAdapter.Fill(Me.DececcoDataSet.cop_Resumen_cuenta_ConsultarResumenCuenta2, parametro_empresa, parametro_banco, parametro_cuenta, parametro_fecha)


        'Dim paramList As New List(Of Microsoft.Reporting.WinForms.ReportParameter)

        ''Dim parametro_proveedor As New Microsoft.Reporting.WinForms.ReportParameter("parametro_proveedor", CType(Me.Owner, frmResumenProveedor).cmbProveedor.Text)
        'Dim periodo As New Microsoft.Reporting.WinForms.ReportParameter("parametro_periodo", parametro_fecha.ToString())

        'paramList.Add(periodo)

        'ReportViewer1.LocalReport.SetParameters(paramList)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class