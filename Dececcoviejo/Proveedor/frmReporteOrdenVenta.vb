Public Class frmReporteOrdenVenta

    Private Sub frmReporteOrdenVenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PymenDataSet.cop_Recibo_proveedor_GetAllReporte' table. You can move, or remove it, as needed.
        Me.cop_Recibo_proveedor_GetAllReporteTableAdapter.Fill(Me.PymenDataSet.cop_Recibo_proveedor_GetAllReporte, CInt(Me.lblid_recibo_proveedor.Text))

        Me.ReportViewer1.RefreshReport()
    End Sub

End Class