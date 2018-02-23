Public Class frmReporte_Saldo_Todos_Proveedores

    Private Sub frmReporte_Saldo_Todos_Proveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DececcoDataSet.cop_Consulta_saldo_proveedor_GetAll_2' table. You can move, or remove it, as needed.
        Me.cop_Consulta_saldo_proveedor_GetAll_2TableAdapter.Fill(Me.DececcoDataSet.cop_Consulta_saldo_proveedor_GetAll_2)
        'TODO: This line of code loads data into the 'PymenDataSet.cop_Consulta_saldo_proveedor_GetAll_2' table. You can move, or remove it, as needed.

        '   Me.cop_Consulta_saldo_proveedor_GetAll_2TableAdapter.Fill(Me.PymenDataSet.cop_Consulta_saldo_proveedor_GetAll_2)
        Me.ReportViewer1.RefreshReport()

    End Sub
End Class