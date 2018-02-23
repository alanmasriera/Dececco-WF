Public Class frmReporteEgresoFechas

    Private Sub frmReporteEgresoFechas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DececcoDataSet1.cop_Egreso_efectivo_GetAllEntreFecha' table. You can move, or remove it, as needed.
        Me.cop_Egreso_efectivo_GetAllEntreFechaTableAdapter.Fill(Me.DececcoDataSet1.cop_Egreso_efectivo_GetAllEntreFecha, parametro_fecha_inicio, parametro_fecha_fin)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class