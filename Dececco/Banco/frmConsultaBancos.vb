Public Class frmConsultaBancos

    Private Sub frmConsultaBancos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DataGridView9.DataSource = odtConsultaBancos
        Dim Total As Decimal
        Try
            For Each row As DataRow In odtConsultaBancos.Rows
                Total = CDec(row.Item("importe")) + Total
            Next
            Me.txtTotalConsulta.Text = FormatCurrency(Total)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Me.Btnimprime.Enabled = True

        'control de acceso y de permisos
        Dim odtUser As New DataTable
        odtUser = oUsuario.GetPermiso(vgNombreUsuario, Me.Name)
        'If odtUser.Rows.Count = 0 OrElse CDbl(odtUser.Rows(0).Item("habilitado")) = 0 Then
        '    Me.Btnimprime.Enabled = False
        'End If

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        odtConsultaBancos.Clear()
        Me.Close()
    End Sub

    Private Sub Btnimprime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnimprime.Click
        'Dim frmimpresiontemporal As New Frmreporte
        'Dim odt As New DataTable
        'frmimpresiontemporal.ShowDialog()

    End Sub

End Class