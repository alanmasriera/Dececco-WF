Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.windows


Public Class frmReporteCaja

    'Structure reporte_array
    'Dim indice As Integer
    'Dim nombre As String
    'Dim parametro As Object
    'End Structure
    ' Dim oarray() As reporte_array

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        Select Case vgBanderaprint
            Case "imprime_resumen_caja"
                Dim rpt As New ReportDocument

                rpt.Load(PathReporte & "Resumen_caja_mes.rpt")
                Dim a As ParameterDiscreteValue
                Dim b As ParameterFieldDefinitions
                Dim c As ParameterFieldDefinition
                Dim d As ParameterValues

                b = rpt.DataDefinition.ParameterFields
                c = b.Item("@id_banco")
                d = c.CurrentValues
                a = New CrystalDecisions.Shared.ParameterDiscreteValue
                a.Value = parametro_banco
                d.Add(a)
                c.ApplyCurrentValues(d)

                b = rpt.DataDefinition.ParameterFields
                c = b.Item("@id_empresa")
                d = c.CurrentValues
                a = New CrystalDecisions.Shared.ParameterDiscreteValue
                a.Value = parametro_empresa
                d.Add(a)
                c.ApplyCurrentValues(d)

                b = rpt.DataDefinition.ParameterFields
                c = b.Item("@id_cuenta")
                d = c.CurrentValues
                a = New CrystalDecisions.Shared.ParameterDiscreteValue
                a.Value = parametro_cuenta
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

            Case "imprime_resumen_cajaN"
                Dim rpt As New ReportDocument

                rpt.Load(PathReporte & "Resumen_caja_mesN.rpt")
                Dim a As ParameterDiscreteValue
                Dim b As ParameterFieldDefinitions
                Dim c As ParameterFieldDefinition
                Dim d As ParameterValues

                b = rpt.DataDefinition.ParameterFields
                c = b.Item("@id_banco")
                d = c.CurrentValues
                a = New CrystalDecisions.Shared.ParameterDiscreteValue
                a.Value = parametro_banco
                d.Add(a)
                c.ApplyCurrentValues(d)

                b = rpt.DataDefinition.ParameterFields
                c = b.Item("@id_empresa")
                d = c.CurrentValues
                a = New CrystalDecisions.Shared.ParameterDiscreteValue
                a.Value = parametro_empresa
                d.Add(a)
                c.ApplyCurrentValues(d)

                b = rpt.DataDefinition.ParameterFields
                c = b.Item("@id_cuenta")
                d = c.CurrentValues
                a = New CrystalDecisions.Shared.ParameterDiscreteValue
                a.Value = parametro_cuenta
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

        End Select


        If vgBanderaprint = "imprime_resumen_caja" Then




        End If





    End Sub


    Private Sub Frmreporte_1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class