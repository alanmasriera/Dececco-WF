Public Class FrmConsultaSaldos

    Private Sub FrmConsultaSaldos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'control de acceso y de permisos
        Dim odtUser As New DataTable
        odtUser = oUsuario.GetPermiso(vgNombreUsuario, Me.Name)
        If odtUser.Rows.Count = 0 OrElse CDbl(odtUser.Rows(0).Item("habilitado")) = 0 Then
            Me.btnConsultar.Enabled = False
            Me.Btnimprime.Enabled = False
        End If

    End Sub


    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click

    End Sub


End Class