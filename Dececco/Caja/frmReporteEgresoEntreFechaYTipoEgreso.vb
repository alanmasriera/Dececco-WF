Public Class frmReporteEgresoEntreFechaYTipoEgreso

    Private Sub frmReporteEgresoEntreFechaYTipoEgreso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DececcoDataSet1.cop_Egreso_efectivo_GetAllEntreFecha' table. You can move, or remove it, as needed.
        Dim paramList As New List(Of Microsoft.Reporting.WinForms.ReportParameter)

        Dim param_fecha_inicio As New Microsoft.Reporting.WinForms.ReportParameter("parametro_fecha_inicio", parametro_fecha_inicio.ToString())
        Dim param_fecha_fin As New Microsoft.Reporting.WinForms.ReportParameter("parametro_fecha_fin", parametro_fecha_fin.ToString())

        paramList.Add(param_fecha_inicio)
        paramList.Add(param_fecha_fin)

        ReportViewer1.LocalReport.SetParameters(paramList)



        Me.cop_Egreso_efectivo_GetAllEntreFechaTableAdapter.Fill(Me.DececcoDataSet1.cop_Egreso_efectivo_GetAllEntreFecha, parametro_fecha_inicio, parametro_fecha_fin)
        'TODO: This line of code loads data into the 'PymenDataSet.cop_Egreso_efectivo_GetAllEntreFecha' table. You can move, or remove it, as needed.
        '    Me.cop_Egreso_efectivo_GetAllEntreFechaTableAdapter.Fill(Me.PymenDataSet.cop_Egreso_efectivo_GetAllEntreFecha, parametro_fecha_inicio, parametro_fecha_fin)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class