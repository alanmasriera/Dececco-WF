Public Class frmGestionFactura

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFactura.Click
        Dim frmTemp As New frmAbmFactura
        frmTemp.ShowDialog()
    End Sub

End Class