Public Class frmBuscarFactura

    Private Sub frmBuscarFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'set las globales a cero
        id_factura_global = 0
        numero_factura_global = ""

        ''' Me.lblid_proveedor.Text = CType(Me.Owner, frmDetalleFactura).lblid_proveedor.Text
        Me.RefrescarGrilla()
    End Sub

    Public Sub RefrescarGrilla()
        Dim odt As DataTable

        odt = oFactura_proveedor.GetAll_Recibo(CInt(Me.lblid_proveedor.Text))
        Me.dgv1.DataSource = odt
        Me.dgv1.Columns(0).Visible = False
        Me.dgv1.Columns("SALDO").DefaultCellStyle.Format = "c"
        Me.dgv1.Columns("SALDO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgv1.Columns("IMPORTE").DefaultCellStyle.Format = "c"
        Me.dgv1.Columns("IMPORTE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        Dim decTotal As Decimal = 0
        For Each row As DataRow In odt.Rows
            decTotal = decTotal + CDec(row.Item("saldo"))
        Next
        Me.txtTotal.Text = FormatCurrency(decTotal)
    End Sub

    Private Sub dgv1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellDoubleClick
        Try
            If dgv1.Columns(e.ColumnIndex).Index = 1 Then

                id_factura_global = CInt(Me.lblid_pk.Text)
                numero_factura_global = Me.dgv1.Item(1, Me.dgv1.CurrentRow.Index).Value.ToString

                Me.Close()
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgv1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv1.CurrentCellChanged
        Try
            Me.lblid_pk.Text = CStr(Me.dgv1.Item(0, Me.dgv1.CurrentRow.Index).Value)
        Catch ex As Exception
        End Try
    End Sub


    Private Sub dgv1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellContentClick

    End Sub
End Class