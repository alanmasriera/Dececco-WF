Public Class frmReporteCaja_3

    Private Sub frmReporteCaja_3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DececcoDataSet.cop_Resumen_cuenta_caja_ConsultarResumenCuenta2' table. You can move, or remove it, as needed.
        Me.cop_Resumen_cuenta_caja_ConsultarResumenCuenta2TableAdapter.Fill(Me.DececcoDataSet.cop_Resumen_cuenta_caja_ConsultarResumenCuenta2, parametro_banco, parametro_cuenta, parametro_empresa, parametro_fecha_inicio)
        'TODO: This line of code loads data into the 'PymenDataSet.cop_Resumen_cuenta_caja_ConsultarResumenCuenta2' table. You can move, or remove it, as needed.
        '        Me.cop_Resumen_cuenta_caja_ConsultarResumenCuenta2TableAdapter.Fill(Me.PymenDataSet.cop_Resumen_cuenta_caja_ConsultarResumenCuenta2, parametro_banco, parametro_cuenta, parametro_empresa, parametro_fecha_inicio)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class