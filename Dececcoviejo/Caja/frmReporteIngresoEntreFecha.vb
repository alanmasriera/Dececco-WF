Public Class frmReporteIngresoEntreFecha

    Private Sub frmReporteIngresoEntreFecha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DececcoDataSet1.cop_Ingreso_efectivo_GetAllEntreFecha' table. You can move, or remove it, as needed.

        Dim paramList As New List(Of Microsoft.Reporting.WinForms.ReportParameter)

        Dim param_fecha_inicio As New Microsoft.Reporting.WinForms.ReportParameter("parametro_fecha_inicio", parametro_fecha_inicio.ToString())
        Dim param_fecha_fin As New Microsoft.Reporting.WinForms.ReportParameter("parametro_fecha_fin", parametro_fecha_fin.ToString())

        paramList.Add(param_fecha_inicio)
        paramList.Add(param_fecha_fin)

        ReportViewer1.LocalReport.SetParameters(paramList)


        Me.cop_Ingreso_efectivo_GetAllEntreFechaTableAdapter.Fill(Me.DececcoDataSet1.cop_Ingreso_efectivo_GetAllEntreFecha, parametro_fecha_inicio, parametro_fecha_fin)

        Me.ReportViewer1.RefreshReport()
    End Sub

End Class