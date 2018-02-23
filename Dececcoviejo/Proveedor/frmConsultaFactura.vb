Public Class frmConsultaFactura



    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmConsultaFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Me.dgv1.DataSource = odtConsultaGeneral
        Me.dgv1.Columns(0).Visible = False
        'Me.dgv1.Columns("IMPORTE").DefaultCellStyle.Format = "c"
        'Me.dgv1.Columns("IMPORTE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

    End Sub


End Class