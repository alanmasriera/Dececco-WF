Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.windows


Public Class frmReporte_1

    'Structure reporte_array
    'Dim indice As Integer
    'Dim nombre As String
    'Dim parametro As Object
    'End Structure
    ' Dim oarray() As reporte_array

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        If vgBanderaprint = "imprime_resumen_empleado" Then
            Dim rpt As New ReportDocument

            rpt.Load(PathReporte & "Movimiento_Empleados_por_Mes.rpt")
            Dim a As ParameterDiscreteValue
            Dim b As ParameterFieldDefinitions
            Dim c As ParameterFieldDefinition
            Dim d As ParameterValues

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@id_empresa")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_id_empresa
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@id_empleado")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_id_empleado
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@fecha")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_old
            d.Add(a)
            c.ApplyCurrentValues(d)

            'b = rpt.DataDefinition.ParameterFields
            'c = b.Item("parametro_perido_resumen")
            'd = c.CurrentValues
            'a = New CrystalDecisions.Shared.ParameterDiscreteValue
            'a.Value = parametro_perido_resumen
            'd.Add(a)
            'c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("parametro_empleado")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_empleado_prn
            d.Add(a)
            c.ApplyCurrentValues(d)
            Me.CrystalReportViewer1.ReportSource = rpt
        ElseIf vgBanderaprint = "imprime_asignacion_empleado" Then

            Dim rpt As New ReportDocument

            rpt.Load(PathReporte & "Asignacion_Empleados.rpt")
            Dim a As ParameterDiscreteValue
            Dim b As ParameterFieldDefinitions
            Dim c As ParameterFieldDefinition
            Dim d As ParameterValues

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@id_empresa")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_id_empresa
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@id_empleado")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_id_empleado
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@fecha_asignacion_empleado")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_old
            d.Add(a)
            c.ApplyCurrentValues(d)

            'b = rpt.DataDefinition.ParameterFields
            'c = b.Item("parametro_perido_resumen")
            'd = c.CurrentValues
            'a = New CrystalDecisions.Shared.ParameterDiscreteValue
            'a.Value = parametro_perido_resumen
            'd.Add(a)
            'c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("parametro_empleado")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_empleado_prn
            d.Add(a)
            c.ApplyCurrentValues(d)
            Me.CrystalReportViewer1.ReportSource = rpt

        ElseIf vgBanderaprint = "imprime_movimiento_empleado" Then

            Dim rpt As New ReportDocument

            rpt.Load(PathReporte & "Labores_realizadas_por_mes.rpt")
            Dim a As ParameterDiscreteValue
            Dim b As ParameterFieldDefinitions
            Dim c As ParameterFieldDefinition
            Dim d As ParameterValues

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@id_empleado")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_id_empleado
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@fecha")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_old
            d.Add(a)
            c.ApplyCurrentValues(d)


            b = rpt.DataDefinition.ParameterFields
            c = b.Item("parametro_empleado")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_empleado
            d.Add(a)
            c.ApplyCurrentValues(d)

            Me.CrystalReportViewer1.ReportSource = rpt

        ElseIf vgBanderaprint = "imprime_pagos_empleado" Then

            Dim rpt As New ReportDocument

            rpt.Load(PathReporte & "pagos_Empleado.rpt")
            Dim a As ParameterDiscreteValue
            Dim b As ParameterFieldDefinitions
            Dim c As ParameterFieldDefinition
            Dim d As ParameterValues

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@id_empresa")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_id_empresa
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@id_empleado")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_id_empleado
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@fecha_pago_empleado")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_old
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("parametro_empleado")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_empleado
            d.Add(a)
            c.ApplyCurrentValues(d)
            Me.CrystalReportViewer1.ReportSource = rpt
        ElseIf vgBanderaprint = "imprime_facturas_Prov" Then

            Dim rpt As New ReportDocument

            rpt.Load(PathReporte & "Facturas_entre_Fechas_Prov.rpt")
            Dim a As ParameterDiscreteValue
            Dim b As ParameterFieldDefinitions
            Dim c As ParameterFieldDefinition
            Dim d As ParameterValues

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@fecha_inicio")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_inicio
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@fecha_fin")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_fin
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@id_proveedor")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_proveedor_prn
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("parametro_proveedor")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_nom_prov
            d.Add(a)
            c.ApplyCurrentValues(d)



            Me.CrystalReportViewer1.ReportSource = rpt

        ElseIf vgBanderaprint = "imprime_facturas_vencidas" Then

            Dim rpt As New ReportDocument

            rpt.Load(PathReporte & "Facturas_vencidas_entre_Fechas.rpt")
            Dim a As ParameterDiscreteValue
            Dim b As ParameterFieldDefinitions
            Dim c As ParameterFieldDefinition
            Dim d As ParameterValues

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@fecha_inicio")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_inicio
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@fecha_fin")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_fin
            d.Add(a)
            c.ApplyCurrentValues(d)

            Me.CrystalReportViewer1.ReportSource = rpt

        ElseIf vgBanderaprint = "imprime_resumen_prov" Then

            frmReporteResumenProveedor.Show()

            Dim rpt As New ReportDocument

            rpt.Load(PathReporte & "Movimiento_proveedor_por_mes.rpt")
            Dim a As ParameterDiscreteValue
            Dim b As ParameterFieldDefinitions
            Dim c As ParameterFieldDefinition
            Dim d As ParameterValues

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@id_proveedor")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_proveedor_prn
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@fecha")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_inicio
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("parametro_Proveedor")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_nom_prov
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("parametro_periodo_resumen")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_periodo
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("parametro_saldo_anterior")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_sdo_ant
            d.Add(a)
            c.ApplyCurrentValues(d)


            Me.CrystalReportViewer1.ReportSource = rpt


        ElseIf vgBanderaprint = "imprime_saldo_proveedores" Then

            Dim rpt As New ReportDocument

            rpt.Load(PathReporte & "Saldo_proveedores.rpt")
            Dim a As ParameterDiscreteValue
            Dim b As ParameterFieldDefinitions
            Dim c As ParameterFieldDefinition
            Dim d As ParameterValues

            Me.CrystalReportViewer1.ReportSource = rpt

        ElseIf vgBanderaprint = "imprime_total_gastado_entre_fecha" Then

            Dim rpt As New ReportDocument

            rpt.Load(PathReporte & "Total_compra_entre_fecha.rpt")
            Dim a As ParameterDiscreteValue
            Dim b As ParameterFieldDefinitions
            Dim c As ParameterFieldDefinition
            Dim d As ParameterValues

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@fecha_inicio")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_inicio
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@fecha_fin")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_fin
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@total")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_total
            d.Add(a)
            c.ApplyCurrentValues(d)

            Me.CrystalReportViewer1.ReportSource = rpt

        ElseIf vgBanderaprint = "Resumen de Facturas de Clientes" Then

            Dim FrmImprime As New frmReporteFacturasClientes
            parametro_fecha_fin = CType(Me.Owner, frmConsultaClienteMain).dtpFecha_hasta.Value.Date
            parametro_fecha_inicio = CType(Me.Owner, frmConsultaClienteMain).dtpFecha_desde.Value.Date
            parametro_id_cliente = CInt(CType(Me.Owner, frmConsultaClienteMain).lblid_cliente.Text)
            parametro_nom_cliente = oCliente.GetOne(parametro_id_cliente).Rows(0).Item("nombre cliente").ToString()
            FrmImprime.ShowDialog()

        End If





    End Sub


    Private Sub Frmreporte_1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class