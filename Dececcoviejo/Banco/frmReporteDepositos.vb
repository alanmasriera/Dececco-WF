Public Class frmReporteDepositos

    Private Sub frmReporteDepositos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DececcoDataSet.cop_DepositoConsultarEfectivo' table. You can move, or remove it, as needed.
        Me.cop_DepositoConsultarEfectivoTableAdapter.Fill(Me.DececcoDataSet.cop_DepositoConsultarEfectivo, CInt(parametro_empresa), parametro_banco, parametro_cuenta, parametro_fecha)

       
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class