
Public Class frmReporteResumenProveedor

    Private Sub frmReporteResumenProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'PymenNDataSet.cop_Resumen_proveedor_Set' table. You can move, or remove it, as needed.
        'Me.lblid_proveedor.Text = CType(Me.Owner, frmResumenProveedor).lblid_proveedor.Text
        'Me.lbl_fecha.Text = Format(CType(Me.Owner, frmResumenProveedor).dtpPeriodo.Value, "dd/MM/yyyy hh:mm:ss")



        Dim paramList As New List(Of Microsoft.Reporting.WinForms.ReportParameter)

        Dim parametro_proveedor As New Microsoft.Reporting.WinForms.ReportParameter("parametro_proveedor", parametro_nom_prov)
        Dim param_periodo As New Microsoft.Reporting.WinForms.ReportParameter("parametro_periodo", parametro_periodo.ToString)
        Dim parametro_bandera_fac As String = "FAC"
        Dim param_bandera As New Microsoft.Reporting.WinForms.ReportParameter("bandera", parametro_bandera_fac.ToString)
        'Dim param_fecha_fin As New Microsoft.Reporting.WinForms.ReportParameter("parametro_fecha_fin", parametro_fecha_fin.ToString())
        'Dim param_saldo_anterior As New Microsoft.Reporting.WinForms.ReportParameter("parametro_saldo_anterior", parametro_saldo_anterior.ToString)


        paramList.Add(parametro_proveedor)
        paramList.Add(param_periodo)
        paramList.Add(param_bandera)
        'paramList.Add(param_fecha_fin)
        'paramList.Add(param_saldo_anterior)

        ReportViewer1.LocalReport.SetParameters(paramList)
        Me.ReportViewer1.RefreshReport()
        Me.cop_Resumen_proveedor_SetTableAdapter.Fill(Me.PymenDataSet.cop_Resumen_proveedor_Set, parametro_id_proveedor, parametro_periodo) ', parametro_bandera_fac)
        ' Me.cop_Resumen_proveedor_SetTableAdapter.Fill(Me.PymenNDataSet.cop_Resumen_proveedor_Set, CInt(Me.lblid_proveedor.Text), CDate(Me.lbl_fecha.Text))



        'Dim paramList As New List(Of Microsoft.Reporting.WinForms.ReportParameter)

        'Dim parametro_proveedor As New Microsoft.Reporting.WinForms.ReportParameter("parametro_proveedor", parametro_nom_prov)
        'Dim param_fecha_inicio As New Microsoft.Reporting.WinForms.ReportParameter("parametro_fecha_inicio", parametro_fecha_inicio.ToString())
        'Dim param_fecha_fin As New Microsoft.Reporting.WinForms.ReportParameter("parametro_fecha_fin", parametro_fecha_fin.ToString())


        'paramList.Add(parametro_proveedor)
        'paramList.Add(param_fecha_inicio)
        'paramList.Add(param_fecha_fin)

        'ReportViewer1.LocalReport.SetParameters(paramList)

        'Me.cop_factura_proveedor_GetAll_VencidaBDTableAdapter.Fill(Me.PymenDataSet.cop_factura_proveedor_GetAll_VencidaBD, parametro_fecha_inicio, parametro_fecha_fin, parametro_id_proveedor)
    End Sub
End Class