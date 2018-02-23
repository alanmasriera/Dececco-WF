Public Class frmReporteFacProveedoresEntreFechas

    Private Sub frmReporteFacProveedoresEntreFechas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim paramList As New List(Of Microsoft.Reporting.WinForms.ReportParameter)
        'TODO: This line of code loads data into the 'DececcoDataSet.cop_factura_proveedor_GetAll_VencidaBD_All' table. You can move, or remove it, as needed.
        Me.cop_factura_proveedor_GetAll_VencidaBD_AllTableAdapter.Fill(Me.DececcoDataSet.cop_factura_proveedor_GetAll_VencidaBD_All, parametro_fecha_inicio, parametro_fecha_fin)

        Dim param_fecha_inicio As New Microsoft.Reporting.WinForms.ReportParameter("parametro_fecha_inicio", parametro_fecha_inicio.ToString())
        Dim param_fecha_fin As New Microsoft.Reporting.WinForms.ReportParameter("parametro_fecha_fin", parametro_fecha_fin.ToString())


        'paramList.Add(parametro_proveedor)
        paramList.Add(param_fecha_inicio)
        paramList.Add(param_fecha_fin)

        ReportViewer1.LocalReport.SetParameters(paramList)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class