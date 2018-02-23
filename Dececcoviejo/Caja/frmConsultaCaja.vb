Public Class frmConsultaCaja

    Private Sub frmConsultaCaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lblTitulo.Text = strTituloConsultaGeneral
        Me.lblDetalle.Text = strDetalleConsultaGeneral

        RefrescarGrilla()
    End Sub

    Public Sub RefrescarGrilla()
        Dim odt As DataTable

        odt = odtConsultaGeneral
        Me.dgv1.DataSource = odt
        Me.dgv1.Columns(0).Visible = False

        Dim decTotal As Decimal = 0

        Try
            For Each row As DataRow In odt.Rows
                decTotal = decTotal + CDec(row("stock"))
            Next
        Catch ex As Exception
        End Try

        Me.txtTotal_factura.Text = FormatNumber(decTotal)
    End Sub

    Private Sub dgv1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv1.CurrentCellChanged
        Try
            Me.lblid_pk.Text = CStr(Me.dgv1.Item(0, Me.dgv1.CurrentRow.Index).Value)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgv1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellClick
        'Try
        '    'pongo el id para hacer el cambio
        '    Me.lblid_pk.Text = CStr(Me.dgv1.Item("id_empleado", Me.dgv1.CurrentRow.Index).Value)

        '    If dgv1.Columns(e.ColumnIndex).Name = "En_actividad" Then
        '        'oEmpleado.UpdateTilde(CInt(Me.lblid_pk.Text))
        '        Me.RefrescarGrilla()
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Select Case vgBanderaprint
            Case "imprime_saldo_proveedores"
        End Select



        'Dim frmTemp As New frmReporteCaja
        'frmTemp.ShowDialog()
    End Sub
End Class