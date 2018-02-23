Public Class frmGestionCompra

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFactura.Click
        Dim frmTemp As New frmAbmFactura_proveedor
        frmTemp.ShowDialog()
    End Sub


    'Private Sub btn_Orden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Orden.Click
    '    Dim frmTemp As New frmAbmOrden_compra
    '    frmTemp.ShowDialog()
    'End Sub

    Private Sub frmGestionCompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class