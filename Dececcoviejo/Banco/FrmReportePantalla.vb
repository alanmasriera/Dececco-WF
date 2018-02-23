
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.windows

Public Class FrmReportePantalla

    Private Sub FrmReportePantalla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'ingreso de insumos pantalla
        If Banderaprintpantalla = "stock_insumos" Then
            Dim rpt As New ReportDocument

            rpt.Load(pathreporte & "stock_insumos.rpt")
            Dim a As ParameterDiscreteValue
            Dim b As ParameterFieldDefinitions
            Dim c As ParameterFieldDefinition
            Dim d As ParameterValues

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@fecha")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_stock
            d.Add(a)
            c.ApplyCurrentValues(d)

            Me.reportespantalla.ReportSource = rpt

            'transferencia insumos pantalla
        ElseIf Banderaprintpantalla = "Transferencia_insumos" Then
            Dim rpt As New ReportDocument

            rpt.Load(pathreporte & "movimiento_stock.rpt")
            Dim a As ParameterDiscreteValue
            Dim b As ParameterFieldDefinitions
            Dim c As ParameterFieldDefinition
            Dim d As ParameterValues

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@fecha")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_transferencia
            d.Add(a)
            c.ApplyCurrentValues(d)

            Me.reportespantalla.ReportSource = rpt

            'egreso de insumo de terceros
        ElseIf Banderaprintpantalla = "Egreso_insumo" Then
            Dim rpt As New ReportDocument

            rpt.Load(pathreporte & "Egreso_insumo.rpt")
            Dim a As ParameterDiscreteValue
            Dim b As ParameterFieldDefinitions
            Dim c As ParameterFieldDefinition
            Dim d As ParameterValues

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@fecha_desde")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_egreso_insumo
            d.Add(a)
            c.ApplyCurrentValues(d)

            Me.reportespantalla.ReportSource = rpt


            'almacenamiento de cerales pantalla
        ElseIf Banderaprintpantalla = "Stock_Cereales" Then
            Dim rpt As New ReportDocument

            rpt.Load(pathreporte & "Stock_Cereal.rpt")
            Dim a As ParameterDiscreteValue
            Dim b As ParameterFieldDefinitions
            Dim c As ParameterFieldDefinition
            Dim d As ParameterValues

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@fecha")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_stock
            d.Add(a)
            c.ApplyCurrentValues(d)

            Me.reportespantalla.ReportSource = rpt

            'egreso de cereal en camion
        ElseIf Banderaprintpantalla = "Cereal_Camion" Then
            Dim rpt As New ReportDocument

            rpt.Load(pathreporte & "Cereal_Camion.rpt")
            Dim a As ParameterDiscreteValue
            Dim b As ParameterFieldDefinitions
            Dim c As ParameterFieldDefinition
            Dim d As ParameterValues

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@fecha")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_stock
            d.Add(a)
            c.ApplyCurrentValues(d)

            Me.reportespantalla.ReportSource = rpt

            'cosecha y egreso en camion
        ElseIf Banderaprintpantalla = "Cosecha_Camion" Then
            Dim rpt As New ReportDocument

            rpt.Load(pathreporte & "Cosecha_Camion.rpt")
            Dim a As ParameterDiscreteValue
            Dim b As ParameterFieldDefinitions
            Dim c As ParameterFieldDefinition
            Dim d As ParameterValues

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@fecha")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_stock
            d.Add(a)
            c.ApplyCurrentValues(d)

            Me.reportespantalla.ReportSource = rpt

            'ingreso de cereal de 3º
        ElseIf Banderaprintpantalla = "ingreso_cereal" Then
            Dim rpt As New ReportDocument

            rpt.Load(pathreporte & "ingreso_cereal.rpt")
            Dim a As ParameterDiscreteValue
            Dim b As ParameterFieldDefinitions
            Dim c As ParameterFieldDefinition
            Dim d As ParameterValues

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@fecha")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_stock 'es la misma fecha para todos
            d.Add(a)
            c.ApplyCurrentValues(d)

            Me.reportespantalla.ReportSource = rpt

            'rinde
        ElseIf Banderaprintpantalla = "Total_Rinde" Then
            Dim rpt As New ReportDocument

            rpt.Load(pathreporte & "Total_rinde.rpt")
            Dim a As ParameterDiscreteValue
            Dim b As ParameterFieldDefinitions
            Dim c As ParameterFieldDefinition
            Dim d As ParameterValues

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@id_grupo_campana")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_id_campana
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@id_grupo_campana")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_id_grupocampana
            d.Add(a)
            c.ApplyCurrentValues(d)

            Me.reportespantalla.ReportSource = rpt

            'transferencia de cereal
        ElseIf Banderaprintpantalla = "transferencia_cereal" Then
            Dim rpt As New ReportDocument

            rpt.Load(pathreporte & "transferencia_cereal.rpt")
            Dim a As ParameterDiscreteValue
            Dim b As ParameterFieldDefinitions
            Dim c As ParameterFieldDefinition
            Dim d As ParameterValues

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@fecha")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_transferencia
            d.Add(a)
            c.ApplyCurrentValues(d)

            Me.reportespantalla.ReportSource = rpt


        ElseIf Banderaprintpantalla = "cheques_librados_pantalla" Then

            Dim rpt As New ReportDocument

            rpt.Load(pathreporte & "librados_pantalla.rpt")
            Dim a As ParameterDiscreteValue
            Dim b As ParameterFieldDefinitions
            Dim c As ParameterFieldDefinition
            Dim d As ParameterValues

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@Empresa")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_empresa
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@Fecha")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha
            d.Add(a)

            c.ApplyCurrentValues(d)
            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@Banco")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_banco
            d.Add(a)
            c.ApplyCurrentValues(d)

            c.ApplyCurrentValues(d)
            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@Cuenta")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_cuenta
            d.Add(a)
            c.ApplyCurrentValues(d)

            c.ApplyCurrentValues(d)
            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@id_Banco")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_id_banco
            d.Add(a)
            c.ApplyCurrentValues(d)

            c.ApplyCurrentValues(d)
            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@id_Cuenta")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_id_cuenta
            d.Add(a)
            c.ApplyCurrentValues(d)


            Me.reportespantalla.ReportSource = rpt


        ElseIf Banderaprintpantalla = "cheques_recibidos_pantalla" Then

            Dim rpt As New ReportDocument

            rpt.Load(pathreporte & "recibidos_pantalla.rpt")
            Dim a As ParameterDiscreteValue
            Dim b As ParameterFieldDefinitions
            Dim c As ParameterFieldDefinition
            Dim d As ParameterValues

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@Empresa")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_empresa
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@Fecha")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha
            d.Add(a)

            c.ApplyCurrentValues(d)
            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@Banco")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_banco
            d.Add(a)
            c.ApplyCurrentValues(d)

            c.ApplyCurrentValues(d)
            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@Cuenta")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_cuenta
            d.Add(a)
            c.ApplyCurrentValues(d)

            c.ApplyCurrentValues(d)
            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@id_Banco")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_id_banco
            d.Add(a)
            c.ApplyCurrentValues(d)

            c.ApplyCurrentValues(d)
            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@id_Cuenta")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_id_cuenta
            d.Add(a)
            c.ApplyCurrentValues(d)


            Me.reportespantalla.ReportSource = rpt

        ElseIf Banderaprintpantalla = "Transferencias_pantalla" Then

            Dim rpt As New ReportDocument

            rpt.Load(pathreporte & "transferencias_pantalla.rpt")
            Dim a As ParameterDiscreteValue
            Dim b As ParameterFieldDefinitions
            Dim c As ParameterFieldDefinition
            Dim d As ParameterValues

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@Empresa")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_empresa
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@Fecha")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha
            d.Add(a)

            c.ApplyCurrentValues(d)
            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@Banco")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_banco
            d.Add(a)
            c.ApplyCurrentValues(d)

            c.ApplyCurrentValues(d)
            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@Cuenta")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_cuenta
            d.Add(a)
            c.ApplyCurrentValues(d)

            c.ApplyCurrentValues(d)
            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@id_Banco")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_id_banco
            d.Add(a)
            c.ApplyCurrentValues(d)

            c.ApplyCurrentValues(d)
            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@id_Cuenta")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_id_cuenta
            d.Add(a)
            c.ApplyCurrentValues(d)


            Me.reportespantalla.ReportSource = rpt

        ElseIf Banderaprintpantalla = "Depositos_pantalla" Then

            Dim rpt As New ReportDocument

            rpt.Load(pathreporte & "Depositos_pantalla.rpt")
            Dim a As ParameterDiscreteValue
            Dim b As ParameterFieldDefinitions
            Dim c As ParameterFieldDefinition
            Dim d As ParameterValues

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@Empresa")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_empresa
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@Fecha")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha
            d.Add(a)

            c.ApplyCurrentValues(d)
            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@Banco")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_banco
            d.Add(a)
            c.ApplyCurrentValues(d)

            c.ApplyCurrentValues(d)
            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@Cuenta")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_cuenta
            d.Add(a)
            c.ApplyCurrentValues(d)

            c.ApplyCurrentValues(d)
            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@id_Banco")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_id_banco
            d.Add(a)
            c.ApplyCurrentValues(d)

            c.ApplyCurrentValues(d)
            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@id_Cuenta")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_id_cuenta
            d.Add(a)
            c.ApplyCurrentValues(d)


            Me.reportespantalla.ReportSource = rpt

        ElseIf Banderaprintpantalla = "resumen_bancario" Then

            Dim rpt As New ReportDocument

            rpt.Load(pathreporte & "resumen_bancario.rpt")
            Dim a As ParameterDiscreteValue
            Dim b As ParameterFieldDefinitions
            Dim c As ParameterFieldDefinition
            Dim d As ParameterValues

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@banco")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_banco
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@empresa")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_empresa
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@cuenta")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_cuenta
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@fecha")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@id_cuenta")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_nombre_cuenta
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@id_banco")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_nombre_banco
            d.Add(a)
            c.ApplyCurrentValues(d)
            Me.reportespantalla.ReportSource = rpt


        ElseIf Banderaprintpantalla = "resumen_campana" Then

            Dim rpt As New ReportDocument

            rpt.Load(pathreporte & "resumen_pantalla.rpt")
            Dim a As ParameterDiscreteValue
            Dim b As ParameterFieldDefinitions
            Dim c As ParameterFieldDefinition
            Dim d As ParameterValues

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@id_grupo_campana")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_id_grupocampana
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@id_campana")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_sumainsumo
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@id_campana")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_nro_sumalabor
            d.Add(a)
            c.ApplyCurrentValues(d)
            Me.reportespantalla.ReportSource = rpt

            'factura
        ElseIf Banderaprintpantalla = "factura" Then
            Dim rpt As New ReportDocument

            rpt.Load(pathreporte & "factura.rpt")
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


        End If

    End Sub




End Class

