Public Class frmPagoAProveedoresEntreFechas

    Private Sub frrmPagoAProveedoresEntreFechas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DececcoDataSet.cop_Recibo_proveedor_GetAll_4' table. You can move, or remove it, as needed.
        Me.cop_Recibo_proveedor_GetAll_4TableAdapter.Fill(Me.DececcoDataSet.cop_Recibo_proveedor_GetAll_4, parametro_fecha_inicio, parametro_fecha_fin)
        Dim paramList As New List(Of Microsoft.Reporting.WinForms.ReportParameter)

        Dim param_fecha_inicio As New Microsoft.Reporting.WinForms.ReportParameter("parametro_fecha_inicio", parametro_fecha_inicio.ToString())
        Dim param_fecha_fin As New Microsoft.Reporting.WinForms.ReportParameter("parametro_fecha_fin", parametro_fecha_fin.ToString())

        paramList.Add(param_fecha_inicio)
        paramList.Add(param_fecha_fin)

        ReportViewer1.LocalReport.SetParameters(paramList)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class