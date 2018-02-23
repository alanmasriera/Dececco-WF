Public Class frmReporteChequeLibrados

    Private Sub frmReporteChequeLibrados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim paramList As New List(Of Microsoft.Reporting.WinForms.ReportParameter)

        'Dim parametro_fecha_desde As New Microsoft.Reporting.WinForms.ReportParameter("parametro_fecha_desde", DateTime.Now.Date.ToString())
        'Dim a As Date = DateTime.Now.Date
        'Dim parametro_fecha_hasta As New Microsoft.Reporting.WinForms.ReportParameter("parametro_fecha_hasta", DateTime.Now.Date.ToString())



        'paramList.Add(parametro_fecha_desde)
        'paramList.Add(parametro_fecha_hasta)


        'ReportViewer1.LocalReport.SetParameters(paramList)
        'TODO: This line of code loads data into the 'DececcoDataSet.cop_ChequeLibrado_GetReporte' table. You can move, or remove it, as needed.
        Me.cop_ChequeLibrado_GetReporteTableAdapter.Fill(Me.DececcoDataSet.cop_ChequeLibrado_GetReporte, parametro_empresa, parametro_banco, parametro_cuenta, parametro_fecha)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class