Public Class frmReporteHora

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
        Dim odt As New DataTable
        odt = oMovimiento_hora.SetResumen(Me.dtpInicio.Value.Date, Me.dtpFin.Value.Date, Me.chkExtra.Checked)

        Me.dgv1.DataSource = odt
        Me.dgv1.Columns(0).Visible = False

        MessageBox.Show("Se ha Generado el Informe")
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnReporte_Click(sender As System.Object, e As System.EventArgs) Handles btnReporte.Click
        'Dim frmTemp As New frmReporteSueldoNew

        'Banderaprint = "imprimir_control_hora"
        'parametro_fecha_inicio = Me.dtpInicio.Value.Date
        'parametro_fecha_fin = Me.dtpFin.Value.Date

        'Me.AddOwnedForm(frmTemp)
        'frmTemp.ShowDialog()
    End Sub

    Private Sub frmReporteHora_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class