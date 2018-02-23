
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.windows

Public Class Frmreporte

    Structure reporte_array
        Dim indice As Integer
        Dim nombre As String
        Dim parametro As Object
    End Structure

    Dim oarray() As reporte_array

    Private Sub Frmreporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        
        If Banderaprint = "resumen_librado" Then

            Dim rpt As New ReportDocument

            rpt.Load(PathReporte & "Ch_Librados_entre_Fecha.rpt")
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
            c = b.Item("parametro_nombre_cuenta")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_nombre_cuenta
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("parametro_nombre_banco")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_nombre_banco
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@fecha1")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_inicio
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@fecha2")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_fin
            d.Add(a)
            c.ApplyCurrentValues(d)
            Me.CrystalReportViewer1.ReportSource = rpt

        ElseIf Banderaprint = "resumen_librado_pago" Then

            Dim rpt As New ReportDocument

            rpt.Load(pathreporte & "ch_librados_por_fecha_pago.rpt")
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

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@fechapago")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_fin
            d.Add(a)
            c.ApplyCurrentValues(d)

            Me.CrystalReportViewer1.ReportSource = rpt


        ElseIf Banderaprint = "resumen_librado_Librado" Then

            Dim rpt As New ReportDocument

            rpt.Load(pathreporte & "ch_librados_por_fecha_librado.rpt")
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

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@fechaLibrado")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_fin
            d.Add(a)
            c.ApplyCurrentValues(d)
            Me.CrystalReportViewer1.ReportSource = rpt


        ElseIf Banderaprint = "resumen_librado_proveedor" Then

            Dim rpt As New ReportDocument

            rpt.Load(pathreporte & "ch_librados_por_Proveedor.rpt")
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

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@Proveedor")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_Proveedor
            d.Add(a)
            c.ApplyCurrentValues(d)
            Me.CrystalReportViewer1.ReportSource = rpt
        ElseIf Banderaprint = "resumen_librado_numero" Then

            Dim rpt As New ReportDocument

            rpt.Load(pathreporte & "Ch_Librados_por_numero.rpt")
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

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@numero")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_nro_cheque
            d.Add(a)
            c.ApplyCurrentValues(d)
            Me.CrystalReportViewer1.ReportSource = rpt

        ElseIf Banderaprint = "Cheques_recibidos_entrefechas" Then

            Dim rpt As New ReportDocument

            rpt.Load(pathreporte & "Ch_recibidos_entre_Fecha.rpt")
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
            a.Value = parametro_cuenta
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@id_banco")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_banco
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@fecha1")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_inicio
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@fecha2")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_fin
            d.Add(a)
            c.ApplyCurrentValues(d)
            Me.CrystalReportViewer1.ReportSource = rpt

        ElseIf Banderaprint = "Cheques_recibidos_fechacobro" Then

            Dim rpt As New ReportDocument

            rpt.Load(pathreporte & "Ch_recibidos_por_Fecha_cobro.rpt")
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
            a.Value = parametro_cuenta
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@id_banco")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_banco
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@fechapago")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_inicio
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@fechafin")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_fin
            d.Add(a)
            c.ApplyCurrentValues(d)
            Me.CrystalReportViewer1.ReportSource = rpt
        ElseIf Banderaprint = "Cheques_recibidos_fecharecibido" Then

            Dim rpt As New ReportDocument

            rpt.Load(pathreporte & "Ch_recibidos_por_Fecha_recibido.rpt")
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
            a.Value = parametro_cuenta
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@id_banco")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_banco
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@fechalibrado")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_inicio
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@fechafin")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_fin
            d.Add(a)
            c.ApplyCurrentValues(d)
            Me.CrystalReportViewer1.ReportSource = rpt
        ElseIf Banderaprint = "Cheques_recibidos_cliente" Then

            Dim rpt As New ReportDocument

            rpt.Load(pathreporte & "ch_recibido_por_cliente.rpt")
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
            a.Value = parametro_cuenta
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@id_banco")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_banco
            d.Add(a)
            c.ApplyCurrentValues(d)


            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@Cliente")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_id_cliente
            d.Add(a)
            c.ApplyCurrentValues(d)
            Me.CrystalReportViewer1.ReportSource = rpt
        ElseIf Banderaprint = "Cheques_recibidos_numero" Then

            Dim rpt As New ReportDocument

            rpt.Load(pathreporte & "ch_recibidos_por_numero.rpt")
            Dim a As ParameterDiscreteValue
            Dim b As ParameterFieldDefinitions
            Dim c As ParameterFieldDefinition
            Dim d As ParameterValues

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@Banco")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_banco
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@Empresa")
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
            a.Value = parametro_cuenta
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@id_banco")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_banco
            d.Add(a)
            c.ApplyCurrentValues(d)


            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@Numero")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_nro_cheque
            d.Add(a)
            c.ApplyCurrentValues(d)
            Me.CrystalReportViewer1.ReportSource = rpt
        ElseIf Banderaprint = "Transferencias_entrefechas" Then

            Dim rpt As New ReportDocument

            rpt.Load(pathreporte & "Transferencias_entre_Fecha.rpt")
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
            a.Value = parametro_cuenta
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@id_banco")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_banco
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@fecha1")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_inicio
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@fecha2")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_fin
            d.Add(a)
            c.ApplyCurrentValues(d)
            Me.CrystalReportViewer1.ReportSource = rpt

        ElseIf Banderaprint = "Transferencias_query" Then

            Dim rpt As New ReportDocument

            rpt.Load(PathReporte & "Transferencias_query.rpt")
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
            c = b.Item("@numero_cuenta")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_numero_cuenta
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@nombre_banco")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_nombre_banco
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@Fecha1")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_inicio
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@Fecha2")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_fin
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@Fechapago")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_pago
            d.Add(a)
            c.ApplyCurrentValues(d)


            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@Numero")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_nro_transferencia
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@bandera_query")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_bandera_query_trasferencias
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@con_fecha")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_con_fecha
            d.Add(a)
            c.ApplyCurrentValues(d)
            

            Me.CrystalReportViewer1.ReportSource = rpt


        ElseIf Banderaprint = "Transferencias_numero" Then

            Dim rpt As New ReportDocument

            rpt.Load(pathreporte & "Transferencias_por_numero.rpt")
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

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@numero")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_nro_transferencia
            d.Add(a)
            c.ApplyCurrentValues(d)
            Me.CrystalReportViewer1.ReportSource = rpt









        ElseIf Banderaprint = "consulta_maestra" Then
            Dim rpt As New ReportDocument

            rpt.Load(pathreporte & "consulta_maestra_cheques.rpt")
            Dim a As ParameterDiscreteValue
            Dim b As ParameterFieldDefinitions
            Dim c As ParameterFieldDefinition
            Dim d As ParameterValues

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@fecha_librado_desde")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_librado_desde
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@fecha_librado_hasta")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_librado_hasta
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@fecha_pago_desde")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_pago_desde
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@fecha_pago_hasta")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_pago_hasta
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@fecha_recibido_desde")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_recibido_desde
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@fecha_recibido_hasta")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_recibido_hasta
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@fecha_acreditacion_desde")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_acreditacion_desde
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@fecha_acreditacion_hasta")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_acreditacion_hasta
            d.Add(a)
            c.ApplyCurrentValues(d)

            Me.CrystalReportViewer1.ReportSource = rpt

  



            'dejado para copiar el codigo de impresion
        ElseIf Banderaprint = "Proyeccion_General" Then
            Dim rpt As New ReportDocument

            rpt.Load(pathreporte & "Proyeccion_1.rpt")
            Dim a As ParameterDiscreteValue
            Dim b As ParameterFieldDefinitions
            Dim c As ParameterFieldDefinition
            Dim d As ParameterValues

            Dim i As Integer
            Dim Limite As Integer = 94
            ReDim oarray(Limite)

            'principal
            oarray(0).nombre = "@id_grupo_campana"
            '    oarray(0).parametro = parametro_id_grupo_campana
            'dolar
            oarray(1).nombre = "@id_grupo_campana_2"
            '   oarray(1).parametro = parametro_id_grupo_campana_2
            'rinde
            oarray(2).nombre = "@id_grupo_campana_3"
            '   oarray(2).parametro = parametro_id_grupo_campana_3

            ' Array.Sort(arr) ' esto ordena el array alfabeticamente  
            For i = 0 To Limite
                b = rpt.DataDefinition.ParameterFields
                c = b.Item(oarray(i).nombre)
                d = c.CurrentValues
                a = New CrystalDecisions.Shared.ParameterDiscreteValue
                a.Value = oarray(i).parametro
                d.Add(a)
                c.ApplyCurrentValues(d)
            Next

            Me.CrystalReportViewer1.ReportSource = rpt


            'para depositos


        ElseIf Banderaprint = "Deposito_query" Then

            Dim rpt As New ReportDocument

            rpt.Load(PathReporte & "Deposito_query.rpt")
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
            c = b.Item("@numero_cuenta")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_numero_cuenta
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@nombre_banco")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_nombre_banco
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@Fecha1")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_inicio
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@Fecha2")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_fin
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@Fechapago")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_pago
            d.Add(a)
            c.ApplyCurrentValues(d)


            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@Numero")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_nro_transferencia
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@bandera_query")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_bandera_query_trasferencias
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@con_fecha")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_con_fecha
            d.Add(a)
            c.ApplyCurrentValues(d)


            Me.CrystalReportViewer1.ReportSource = rpt

        ElseIf Banderaprint = "Creditos_query" Then

            Dim rpt As New ReportDocument

            rpt.Load(PathReporte & "Credito_query.rpt")
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
            c = b.Item("@numero_cuenta")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_numero_cuenta
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@nombre_banco")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_nombre_banco
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@Fecha1")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_inicio
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@Fecha2")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_fin
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@Fechapago")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_pago
            d.Add(a)
            c.ApplyCurrentValues(d)


            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@Numero")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_nro_transferencia
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@bandera_query")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_bandera_query_trasferencias
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@con_fecha")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_con_fecha
            d.Add(a)
            c.ApplyCurrentValues(d)


            Me.CrystalReportViewer1.ReportSource = rpt


        ElseIf Banderaprint = "Debitos_query" Then

            Dim rpt As New ReportDocument

            rpt.Load(PathReporte & "Debitos_query.rpt")
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
            c = b.Item("@numero_cuenta")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_numero_cuenta
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@nombre_banco")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_nombre_banco
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@Fecha1")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_inicio
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@Fecha2")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_fin
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@Fechapago")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_pago
            d.Add(a)
            c.ApplyCurrentValues(d)


            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@Numero")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_nro_transferencia
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@bandera_query")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_bandera_query_trasferencias
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@con_fecha")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_con_fecha
            d.Add(a)
            c.ApplyCurrentValues(d)


            Me.CrystalReportViewer1.ReportSource = rpt

        ElseIf Banderaprint = "Gastos_query" Then

            Dim rpt As New ReportDocument

            rpt.Load(PathReporte & "Gastos_query.rpt")
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
            c = b.Item("@numero_cuenta")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_numero_cuenta
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@nombre_banco")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_nombre_banco
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@Fecha1")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_inicio
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@Fecha2")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_fin
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@Fechapago")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_fecha_pago
            d.Add(a)
            c.ApplyCurrentValues(d)


            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@Numero")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_nro_transferencia
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@bandera_query")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_bandera_query_trasferencias
            d.Add(a)
            c.ApplyCurrentValues(d)

            b = rpt.DataDefinition.ParameterFields
            c = b.Item("@con_fecha")
            d = c.CurrentValues
            a = New CrystalDecisions.Shared.ParameterDiscreteValue
            a.Value = parametro_con_fecha
            d.Add(a)
            c.ApplyCurrentValues(d)


            Me.CrystalReportViewer1.ReportSource = rpt


        End If


    End Sub

    
   
    
  
    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class