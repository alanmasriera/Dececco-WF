Public Class frmReporteFacturasProveedor

    Private Sub frmReporteFacturasProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DececcoDataSet.cop_factura_proveedor_GetAll_VencidaBD' table. You can move, or remove it, as needed.
        Me.cop_factura_proveedor_GetAll_VencidaBDTableAdapter.Fill(Me.DececcoDataSet.cop_factura_proveedor_GetAll_VencidaBD, parametro_fecha_inicio, parametro_fecha_fin, parametro_Proveedor)

        'Me.lbl_id_proveedor.Text = CType(Me.Owner, frmResumenProveedor).lblid_proveedor.Text
        'Me.lbl_fecha.Text = Format(CType(Me.Owner, frmResumenProveedor).dtpPeriodo.Value, "dd/MM/yyyy hh:mm:ss")


        Dim paramList As New List(Of Microsoft.Reporting.WinForms.ReportParameter)
        Dim param_nombre_proveedor As New Microsoft.Reporting.WinForms.ReportParameter("parametro_nombre_proveedor", parametro_nom_prov.ToString())
        Dim param_fecha_inicio As New Microsoft.Reporting.WinForms.ReportParameter("parametro_fecha_inicio", parametro_fecha_inicio.ToString())
        Dim param_fecha_fin As New Microsoft.Reporting.WinForms.ReportParameter("parametro_fecha_fin", parametro_fecha_fin.ToString())

        paramList.Add(param_nombre_proveedor)
        paramList.Add(param_fecha_inicio)
        paramList.Add(param_fecha_fin)

        ReportViewer1.LocalReport.SetParameters(paramList)

        ' Me.cop_factura_proveedor_GetAll_VencidaBDTableAdapter.Fill(Me.PymenDataSet.cop_factura_proveedor_GetAll_VencidaBD, parametro_fecha_inicio, parametro_fecha_fin, parametro_proveedor)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class