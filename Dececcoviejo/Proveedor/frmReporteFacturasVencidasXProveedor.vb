Public Class frmReporteFacturasVencidasXProveedor

    Private Sub frmReporteFacturasVencidasXProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DececcoDataSet.cop_factura_proveedor_GetAll_VencidaBD' table. You can move, or remove it, as needed.
        'Me.cop_factura_proveedor_GetAll_VencidaBDTableAdapter.Fill(Me.DececcoDataSet.cop_factura_proveedor_GetAll_VencidaBD)
        'TODO: This line of code loads data into the 'PymenDataSet.cop_factura_proveedor_GetAll_VencidaBD_All' table. You can move, or remove it, as needed.
        'Me.cop_factura_proveedor_GetAll_VencidaBD_AllTableAdapter.Fill(Me.DececcoDataSet.cop_factura_proveedor_GetAll_VencidaBD_All, parametro_fecha_inicio, parametro_fecha_fin)



        Dim paramList As New List(Of Microsoft.Reporting.WinForms.ReportParameter)

        Dim param_fecha_inicio As New Microsoft.Reporting.WinForms.ReportParameter("parametro_fecha_inicio", parametro_fecha_inicio.ToString())
        Dim param_fecha_fin As New Microsoft.Reporting.WinForms.ReportParameter("parametro_fecha_fin", parametro_fecha_fin.ToString())

        paramList.Add(param_fecha_inicio)
        paramList.Add(param_fecha_fin)

        ReportViewer1.LocalReport.SetParameters(paramList)
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer2.RefreshReport()
    End Sub
End Class