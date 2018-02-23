Public Class frmGestionHora


    Private Sub Botones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles btnEmpleado.Click, btnMovimiento_hora.Click, _
    btnObra.Click, btnReporte.Click

        Dim btnTemp As New Button
        btnTemp = CType(sender, Button)

        Select Case btnTemp.Name
            Case "btnEmpleado"
                Dim frmTemp As New frmAbmUsuario
                frmTemp.ShowDialog()

            Case "btnConsulta"
                'Dim frmTemp As New frmAbmEmpleado
                'frmTemp.ShowDialog()
            Case "btnMovimiento_hora"
                Dim frmTemp As New frmAbmMovimiento_hora
                frmTemp.ShowDialog()
                'Case "btnObra"
                '    Dim frmTemp As New frmMainProyecto
                '    frmTemp.ShowDialog()
            Case "btnReporte"
                Dim frmTemp As New frmReporteHora
                frmTemp.ShowDialog()
        End Select
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

End Class