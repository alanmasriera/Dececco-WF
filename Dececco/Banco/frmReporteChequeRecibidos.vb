Public Class frmReporteChequeRecibidos

    Private Sub frmReporteChequeRecibidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim paramList As New List(Of Microsoft.Reporting.WinForms.ReportParameter)


        Dim parametro_nomEmpresa As New Microsoft.Reporting.WinForms.ReportParameter("parametro_nomEmpresa", parametro_nom_banco)
        Dim parametro_numCuenta As New Microsoft.Reporting.WinForms.ReportParameter("parametro_numCuenta", parametro_num_cuenta)


        paramList.Add(parametro_nomEmpresa)
        paramList.Add(parametro_numCuenta)
        'TODO: This line of code loads data into the 'DececcoDataSet.cop_ChequeRecibidoConsultar' table. You can move, or remove it, as needed.
        Me.cop_ChequeRecibidoConsultarTableAdapter.Fill(Me.DececcoDataSet.cop_ChequeRecibidoConsultar, parametro_empresa, parametro_banco, parametro_cuenta, parametro_fecha)
        'TODO: This line of code loads data into the 'DececcoDataSet.cop_CuentaBuscarBanco' table. You can move, or remove it, as needed.
        ' Me.cop_CuentaBuscarBancoTableAdapter.Fill(Me.DececcoDataSet.cop_CuentaBuscarBanco, parametro_banco, parametro_empresa)
        ReportViewer1.LocalReport.SetParameters(paramList)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class