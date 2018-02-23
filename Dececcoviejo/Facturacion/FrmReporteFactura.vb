
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.windows

Public Class FrmReporteFactura

    Private Sub FrmReporteFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'ingreso de insumos pantalla
        If Banderaprintpantalla = "factura" Then

            'ElseIf Banderaprintpantalla = "factura" Then
            Dim rpt As New ReportDocument

            If vgNombrePermiso = "console" Then
                rpt.Load(PathReporte & "factura_console.rpt")
            ElseIf vgNombrePermiso = "pymem" Then
                rpt.Load(PathReporte & "factura.rpt")
            Else
                rpt.Load(PathReporte & "factura.rpt")
            End If

            Dim a As ParameterDiscreteValue
            Dim b As ParameterFieldDefinitions
            Dim c As ParameterFieldDefinition
            Dim d As ParameterValues

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@id_factura")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fac
            d.Add(a)
            c.ApplyCurrentValues(d)

            Me.reportespantalla.ReportSource = rpt

        ElseIf Banderaprintpantalla = "factura_dolar" Then

            'ElseIf Banderaprintpantalla = "factura" Then
            Dim rpt As New ReportDocument


            rpt.Load(PathReporte & "factura_dolar.rpt")


            Dim a As ParameterDiscreteValue
            Dim b As ParameterFieldDefinitions
            Dim c As ParameterFieldDefinition
            Dim d As ParameterValues

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@id_factura")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fac
            d.Add(a)
            c.ApplyCurrentValues(d)

            Me.reportespantalla.ReportSource = rpt

        ElseIf Banderaprintpantalla = "facturaN" Then

            'ElseIf Banderaprintpantalla = "factura" Then
            Dim rpt As New ReportDocument

            rpt.Load(PathReporte & "Factura_consoleN.rpt")
            Dim a As ParameterDiscreteValue
            Dim b As ParameterFieldDefinitions
            Dim c As ParameterFieldDefinition
            Dim d As ParameterValues

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@id_factura")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fac
            d.Add(a)
            c.ApplyCurrentValues(d)

            Me.reportespantalla.ReportSource = rpt



        ElseIf Banderaprintpantalla = "factura_exporta" Then

            'ElseIf Banderaprintpantalla = "factura" Then
            Dim rpt As New ReportDocument

            rpt.Load(PathReporte & "Factura_Exporta.rpt")
            Dim a As ParameterDiscreteValue
            Dim b As ParameterFieldDefinitions
            Dim c As ParameterFieldDefinition
            Dim d As ParameterValues

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@id_factura")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fac
            d.Add(a)
            c.ApplyCurrentValues(d)

            Me.reportespantalla.ReportSource = rpt

            'impresion de remito
        ElseIf Banderaprintpantalla = "remito" Then
            Dim rpt As New ReportDocument

            rpt.Load(PathReporte & "remito2.rpt")
            Dim a As ParameterDiscreteValue
            Dim b As ParameterFieldDefinitions
            Dim c As ParameterFieldDefinition
            Dim d As ParameterValues

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@id_remito")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fac
            d.Add(a)
            c.ApplyCurrentValues(d)

            Me.reportespantalla.ReportSource = rpt


            'impresion de orden de compra
        ElseIf Banderaprintpantalla = "orden compra" Then
            Dim rpt As New ReportDocument

            rpt.Load(PathReporte & "orden_compra.rpt")
            Dim a As ParameterDiscreteValue
            Dim b As ParameterFieldDefinitions
            Dim c As ParameterFieldDefinition
            Dim d As ParameterValues

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@id_orden_compra")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fac
            d.Add(a)
            c.ApplyCurrentValues(d)

            Me.reportespantalla.ReportSource = rpt
            'impresion del recibo
        ElseIf Banderaprintpantalla = "recibo" Then
            Dim rpt As New ReportDocument

            rpt.Load(PathReporte & "recibo.rpt")
            Dim a As ParameterDiscreteValue
            Dim b As ParameterFieldDefinitions
            Dim c As ParameterFieldDefinition
            Dim d As ParameterValues

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@id_pago_cliente")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fac
            d.Add(a)
            c.ApplyCurrentValues(d)

            Me.reportespantalla.ReportSource = rpt

            'impresion de remito
        ElseIf Banderaprintpantalla = "remitoN" Then
            Dim rpt As New ReportDocument

            rpt.Load(PathReporte & "remitoN.rpt")
            Dim a As ParameterDiscreteValue
            Dim b As ParameterFieldDefinitions
            Dim c As ParameterFieldDefinition
            Dim d As ParameterValues

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@id_remitoN")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fac
            d.Add(a)
            c.ApplyCurrentValues(d)

            Me.reportespantalla.ReportSource = rpt


            'impresion de orden de compra
        ElseIf Banderaprintpantalla = "orden compraN" Then
            Dim rpt As New ReportDocument

            rpt.Load(PathReporte & "orden_compraN.rpt")
            Dim a As ParameterDiscreteValue
            Dim b As ParameterFieldDefinitions
            Dim c As ParameterFieldDefinition
            Dim d As ParameterValues

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@id_orden_compraN")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fac
            d.Add(a)
            c.ApplyCurrentValues(d)

            Me.reportespantalla.ReportSource = rpt
            'impresion del recibo
        ElseIf Banderaprintpantalla = "reciboN" Then
            Dim rpt As New ReportDocument

            rpt.Load(PathReporte & "reciboN.rpt")
            Dim a As ParameterDiscreteValue
            Dim b As ParameterFieldDefinitions
            Dim c As ParameterFieldDefinition
            Dim d As ParameterValues

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@id_pago_clienteN")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fac
            d.Add(a)
            c.ApplyCurrentValues(d)

            Me.reportespantalla.ReportSource = rpt


        End If

    End Sub




    Private Sub reportespantalla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reportespantalla.Load

    End Sub
End Class

