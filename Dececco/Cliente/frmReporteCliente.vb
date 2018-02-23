Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.windows


Public Class frmReporteCliente

    'Structure reporte_array
    'Dim indice As Integer
    'Dim nombre As String
    'Dim parametro As Object
    'End Structure
    ' Dim oarray() As reporte_array

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

        If Banderaprint = "imprime_resumen_cliente" Then

            Dim rpt As New ReportDocument

            rpt.Load(PathReporte & "Resumen_cliente_mes.rpt")
            Dim a As ParameterDiscreteValue
            Dim b As ParameterFieldDefinitions
            Dim c As ParameterFieldDefinition
            Dim d As ParameterValues

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@id_cliente")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_cliente_prn
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
            c = b.Item("@nombre_cliente")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_nom_cliente
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@parametro_periodo_resumen")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_periodo
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@parametro_saldo_anterior")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_sdo_ant
            d.Add(a)
            c.ApplyCurrentValues(d)


            Me.CrystalReportViewer1.ReportSource = rpt


        End If





    End Sub


    Private Sub Frmreporte_1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class