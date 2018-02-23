
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.windows

Public Class frmReporteIva

    Structure reporte_array
        Dim indice As Integer
        Dim nombre As String
        Dim parametro As Object
    End Structure

    Dim oarray() As reporte_array

    Private Sub frmReporteIva_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Banderaprint = "LibroIvaCompra" Then

            Dim rpt As New ReportDocument

            rpt.Load(PathReporte & "LibroIvaCompra.rpt")
            Dim a As ParameterDiscreteValue
            Dim b As ParameterFieldDefinitions
            Dim c As ParameterFieldDefinition
            Dim d As ParameterValues

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@fecha")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@inicio")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_inicio
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@fin")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_fin
            d.Add(a)
            c.ApplyCurrentValues(d)

            Me.CrystalReportViewer1.ReportSource = rpt

        ElseIf Banderaprint = "LibroIvaVenta" Then

            Dim rpt As New ReportDocument

            rpt.Load(PathReporte & "LibroIvaVenta.rpt")
            Dim a As ParameterDiscreteValue
            Dim b As ParameterFieldDefinitions
            Dim c As ParameterFieldDefinition
            Dim d As ParameterValues

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@fecha")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@inicio")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_inicio
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@fin")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_fin
            d.Add(a)
            c.ApplyCurrentValues(d)

            Me.CrystalReportViewer1.ReportSource = rpt

        End If


    End Sub




End Class