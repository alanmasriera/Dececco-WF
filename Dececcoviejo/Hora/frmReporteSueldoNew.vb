Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.windows

Public Class frmReporteSueldoNew

    'Structure reporte_array
    'Dim indice As Integer
    'Dim nombre As String
    'Dim parametro As Object
    'End Structure
    ' Dim oarray() As reporte_array

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

        If Banderaprint = "imprimir_control_hora" Then
            Dim rpt As New ReportDocument

            rpt.Load(PathReporte & "imprimir_control_hora.rpt")
            Dim a As ParameterDiscreteValue
            Dim b As ParameterFieldDefinitions
            Dim c As ParameterFieldDefinition
            Dim d As ParameterValues

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@liquidacion")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = 1
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@ultimoHojaAnterior")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = 1
            d.Add(a)
            c.ApplyCurrentValues(d)

            Me.CrystalReportViewer1.ReportSource = rpt


            'ElseIf Banderaprint = "imprimir_recibo" Then

            '    'Dim odtTemp As New DataTable
            '    'odtTemp = oTotal_sueldo.GetReporte(parametro_id_empleado, parametro_fecha_inicio, parametro_fecha_fin)

            '    'If odtTemp.Rows.Count <= 0 Then
            '    '    Exit Sub
            '    'End If

            '    Dim margins As PageMargins
            '    Dim rpt As New ReportDocument

            '    rpt.Load(PathReporte & "Report1.rpt")
            '    Dim a As ParameterDiscreteValue
            '    Dim b As ParameterFieldDefinitions
            '    Dim c As ParameterFieldDefinition
            '    Dim d As ParameterValues

            '    b = rpt.DataDefinition.ParameterFields
            '    c = b.Item("@id_empleado")
            '    d = c.CurrentValues
            '    a = New CrystalDecisions.Shared.ParameterDiscreteValue
            '    a.Value = parametro_id_empleado
            '    d.Add(a)
            '    c.ApplyCurrentValues(d)


            '    Dim strPeriodo As String = ""
            '    Dim strLetra As String = ""
            '    Dim decTotal As Decimal = 0
            '    Dim decTotalHaber As Decimal = 0
            '    Dim decTotalDeduccion As Decimal = 0
            '    Dim decTotalAdicional As Decimal = 0


            '    'With odtTemp.Rows(0)
            '    '    strPeriodo = CStr(.Item("periodo"))
            '    '    strLetra = CStr(.Item("letra_sueldo"))
            '    '    decTotal = CDec(.Item("total_cobrar"))
            '    '    decTotalHaber = CDec(.Item("total_haber"))
            '    '    decTotalDeduccion = CDec(.Item("total_deduccion"))
            '    '    decTotalAdicional = CDec(.Item("total_adicional"))
            '    'End With

            '    b = rpt.DataDefinition.ParameterFields
            '    c = b.Item("@periodo")
            '    d = c.CurrentValues
            '    a = New CrystalDecisions.Shared.ParameterDiscreteValue
            '    a.Value = strPeriodo
            '    d.Add(a)
            '    c.ApplyCurrentValues(d)

            '    b = rpt.DataDefinition.ParameterFields
            '    c = b.Item("@letra")
            '    d = c.CurrentValues
            '    a = New CrystalDecisions.Shared.ParameterDiscreteValue
            '    a.Value = strLetra
            '    d.Add(a)
            '    c.ApplyCurrentValues(d)

            '    'Me.CrystalReportViewer1.ReportSource = rpt

            '    'margins = rpt.PrintOptions.PageMargins
            '    'margins.bottomMargin = 350
            '    'margins.leftMargin = 350
            '    'margins.rightMargin = 350
            '    'margins.topMargin = 350
            '    'rpt.PrintOptions.ApplyPageMargins(margins)

            '    b = rpt.DataDefinition.ParameterFields
            '    c = b.Item("@total_haber")
            '    d = c.CurrentValues
            '    a = New CrystalDecisions.Shared.ParameterDiscreteValue
            '    a.Value = decTotalHaber
            '    d.Add(a)
            '    c.ApplyCurrentValues(d)

            '    b = rpt.DataDefinition.ParameterFields
            '    c = b.Item("@total_deduccion")
            '    d = c.CurrentValues
            '    a = New CrystalDecisions.Shared.ParameterDiscreteValue
            '    a.Value = decTotalDeduccion
            '    d.Add(a)
            '    c.ApplyCurrentValues(d)

            '    b = rpt.DataDefinition.ParameterFields
            '    c = b.Item("@total_adicional")
            '    d = c.CurrentValues
            '    a = New CrystalDecisions.Shared.ParameterDiscreteValue
            '    a.Value = decTotalAdicional
            '    d.Add(a)
            '    c.ApplyCurrentValues(d)

            '    b = rpt.DataDefinition.ParameterFields
            '    c = b.Item("@ultimo_deposito")
            '    d = c.CurrentValues
            '    a = New CrystalDecisions.Shared.ParameterDiscreteValue
            '    a.Value = 1
            '    d.Add(a)
            '    c.ApplyCurrentValues(d)

            '    b = rpt.DataDefinition.ParameterFields
            '    c = b.Item("@detalle")
            '    d = c.CurrentValues
            '    a = New CrystalDecisions.Shared.ParameterDiscreteValue
            '    a.Value = 1
            '    d.Add(a)
            '    c.ApplyCurrentValues(d)

            '    b = rpt.DataDefinition.ParameterFields
            '    c = b.Item("@periodo_nuevo")
            '    d = c.CurrentValues
            '    a = New CrystalDecisions.Shared.ParameterDiscreteValue
            '    a.Value = 1
            '    d.Add(a)
            '    c.ApplyCurrentValues(d)

            '    b = rpt.DataDefinition.ParameterFields
            '    c = b.Item("@opcion")
            '    d = c.CurrentValues
            '    a = New CrystalDecisions.Shared.ParameterDiscreteValue
            '    a.Value = 1
            '    d.Add(a)
            '    c.ApplyCurrentValues(d)

            '    b = rpt.DataDefinition.ParameterFields
            '    c = b.Item("@fecha_pago")
            '    d = c.CurrentValues
            '    a = New CrystalDecisions.Shared.ParameterDiscreteValue
            '    a.Value = 1
            '    d.Add(a)
            '    c.ApplyCurrentValues(d)

            '    Me.CrystalReportViewer1.ReportSource = rpt


            'ElseIf Banderaprint = "imprimir_control_hora" Then
            '    Dim margins As PageMargins
            '    Dim rpt As New ReportDocument

            '    rpt.Load(PathReporte & "HoraTrabajada.rpt")
            '    'Dim a As ParameterDiscreteValue
            '    'Dim b As ParameterFieldDefinitions
            '    'Dim c As ParameterFieldDefinition
            '    'Dim d As ParameterValues

            '    'b = rpt.DataDefinition.ParameterFields
            '    'c = b.Item("@fecha_inicio")
            '    'd = c.CurrentValues
            '    'a = New CrystalDecisions.Shared.ParameterDiscreteValue
            '    'a.Value = parametro_opcion_recibo
            '    'd.Add(a)
            '    'c.ApplyCurrentValues(d)

            '    'b = rpt.DataDefinition.ParameterFields
            '    'c = b.Item("@fecha_fin")
            '    'd = c.CurrentValues
            '    'a = New CrystalDecisions.Shared.ParameterDiscreteValue
            '    'a.Value = parametro_fecha_pago
            '    'd.Add(a)
            '    'c.ApplyCurrentValues(d)

            '    Me.CrystalReportViewer1.ReportSource = rpt
        End If

    End Sub


End Class