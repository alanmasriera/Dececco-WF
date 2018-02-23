Public Class frmConsultaCaja1

    Private Sub frmConsultaStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lblTitulo.Text = strTituloConsultaGeneral
        Me.lblDetalle.Text = strDetalleConsultaGeneral

        RefrescarGrilla()

        Me.ContextMenuStrip1.Enabled = False
        If Banderaprint = "SaldoCuentaCliente" Then
            Me.ContextMenuStrip1.Enabled = True
        End If
    End Sub

    Public Sub RefrescarGrilla()
        Dim odt As DataTable

        odt = odtConsultaGeneral
        Me.dgv1.DataSource = odt
        Me.dgv1.Columns(0).Visible = False
        ' Me.dgv1.Columns(3).Visible = False
        'Me.dgv1.Columns(4).Visible = False
        Dim decTotal As Decimal = 0
        Dim decIVA As Decimal = 0

        Try
            For Each row As DataRow In odt.Rows
                decTotal = decTotal + CDec(row("Saldo"))
            Next

        Catch ex As Exception
        End Try
        Try
            For Each row As DataRow In odt.Rows
                decTotal = decTotal + CDec(row("Stock"))
            Next

        Catch ex As Exception
        End Try
        Try
            For Each row As DataRow In odt.Rows
                decTotal = decTotal + CDec(row("total"))
            Next
        Catch ex As Exception
        End Try

        'agregado para ZETA
        Try
            For Each row As DataRow In odt.Rows
                decTotal = decTotal + CDec(row("Monto_vendido_documento_fiscal"))
            Next
        Catch ex As Exception
        End Try
        ''''''''''''''

        Try
            For Each row As DataRow In odt.Rows
                decIVA = decIVA + CDec(row("monto_iva"))
            Next
        Catch ex As Exception
        End Try

        Try
            For Each row As DataRow In odt.Rows
                decIVA = decIVA + CDec(row("monto_iva_documento_fiscal"))
            Next
        Catch ex As Exception
        End Try

        If Banderaprint = "CompraEntreFecha" Then
            For Each row As DataRow In odt.Rows
                decTotal = decTotal + CDec(row("total_factura"))
                decIVA = decIVA + CDec(row("iva_10_5")) + CDec(row("iva_21"))
            Next
        End If


        Me.txtTotal_factura.Text = FormatNumber(decTotal)
        Me.txtMontoIva.Text = FormatCurrency(decIVA)

        parametro_total = CDec(Me.txtTotal_factura.Text)
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

    'Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
    '    Dim frmTemp As New frmReporteStock
    '    frmTemp.ShowDialog()
    'End Sub

    'Private Sub AgregarPagoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarPagoToolStripMenuItem.Click
    '    Dim frmTemp As New frmFormaPagoContadoNew
    '    Me.AddOwnedForm(frmTemp)
    '    frmTemp.ShowDialog()

    'End Sub

    'Private Sub AgregarVentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarVentaToolStripMenuItem.Click
    '    Dim frmTemp As New frmFormaPagoCuenta2
    '    Me.AddOwnedForm(frmTemp)
    '    frmTemp.ShowDialog()

    'End Sub


    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim frmTemp As New frmReporteControlStock
        frmTemp.ShowDialog()
    End Sub
End Class