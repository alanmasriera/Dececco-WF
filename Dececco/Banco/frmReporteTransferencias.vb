Public Class frmReporteTransferencias

    Private Sub frmReporteTransferencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DececcoDataSet.cop_TransferenciaConsultar' table. You can move, or remove it, as needed.
        Me.cop_TransferenciaConsultarTableAdapter.Fill(Me.DececcoDataSet.cop_TransferenciaConsultar, parametro_empresa, parametro_banco, parametro_cuenta, parametro_fecha)
        'TODO: This line of code loads data into the 'DececcoDataSet.cop_CuentaBuscarBanco' table. You can move, or remove it, as needed.
        Me.cop_CuentaBuscarBancoTableAdapter.Fill(Me.DececcoDataSet.cop_CuentaBuscarBanco, parametro_banco, parametro_empresa)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class