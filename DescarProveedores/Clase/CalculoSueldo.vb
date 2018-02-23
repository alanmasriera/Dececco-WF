Public Class CalculoSueldo

    Dim decLiquidacion As String
    Dim decRemuneracionBasica As Decimal
    Dim decFechaLiquidacion As DateTime


    'propiedades
    Private _Liquidacion As String
    Public Property Liquidacion() As String
        Get
            _Liquidacion = decLiquidacion
            Return _Liquidacion
        End Get
        Set(ByVal Value As String)
            decLiquidacion = Value
        End Set
    End Property

    Private _RemuneracionBasica As Decimal
    Public Property RemuneracionBasica() As Decimal
        Get
            _RemuneracionBasica = decRemuneracionBasica
            Return _RemuneracionBasica
        End Get
        Set(ByVal Value As Decimal)
            decRemuneracionBasica = Value
        End Set
    End Property

    Private _FechaLiquidacion As DateTime
    Public Property FechaLiquidacion() As DateTime
        Get
            _FechaLiquidacion = decFechaLiquidacion
            Return _FechaLiquidacion
        End Get
        Set(ByVal Value As DateTime)
            decFechaLiquidacion = Value
        End Set
    End Property



    Function CalcularHoraAutomatico(ByVal id_empleado As Integer, ByVal inicio As DateTime, ByVal fin As DateTime, ByVal extra As Boolean) As ClaseHora
        Dim odt As New DataTable
        Dim odtControl As New DataTable
        Dim odtDetalle As New DataTable

        'para calculo de minutos
        Dim decTotal As Decimal = 0
        Dim decMinuto As Decimal = 0
        Dim dtInicio As DateTime
        Dim dtFin As DateTime
        Dim decParcial As Decimal = 0

        'variables
        Dim decHoraNormal As Decimal = 0
        Dim decHora50 As Decimal = 0
        Dim decHora100 As Decimal = 0
        Dim decHoraNocturna As Decimal = 0
        Dim decHoraEnfermedad As Decimal = 0
        Dim decHoraAccidente As Decimal = 0
        Dim decHoraFeriado As Decimal = 0
        Dim decHoraFeriadoTrabajado As Decimal = 0
        Dim decHoraNoTrabajada As Decimal = 0
        Dim decHoraViaje As Decimal = 0
        Dim decHoraViaje50 As Decimal = 0
        Dim decHoraViaje100 As Decimal = 0

        Dim IDMov As Integer = 0

        odtControl = oMovimiento_hora.GetAllControl(id_empleado, inicio, fin)

        For Each row As DataRow In odtControl.Rows
            IDMov = CInt(row("id_movimiento_hora"))
            odtDetalle = oCuerpo_movimiento_hora.GetAllMovimientoControl(IDMov, extra)

            decMinuto = 0
            decTotal = 0
            For Each rowCuerpo As DataRow In odtDetalle.Rows
                dtInicio = CDate(rowCuerpo("entrada"))
                dtFin = CDate(rowCuerpo("salida"))
                'calcula la cantidad de horas trabajadas
                decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtFin)
                decTotal = decTotal + CDec(FormatNumber(decMinuto / 60, 1))
            Next

            If odtDetalle.Rows.Count > 0 Then



                Select Case row("id_dia").ToString
                    'lunes a jueves
                    Case "1"
                        If decTotal > 9 Then
                            decHoraNormal = decHoraNormal + 9
                            decHora50 = decHora50 + decTotal - 9
                        Else
                            decHoraNormal = decHoraNormal + decTotal
                        End If
                        'viernes
                    Case "2"
                        If decTotal > 8 Then
                            decHoraNormal = decHoraNormal + 8
                            decHora50 = decHora50 + decTotal - 8
                        Else
                            decHoraNormal = decHoraNormal + decTotal
                        End If
                        'nocturna
                    Case "3"
                        decMinuto = 0
                        decTotal = 0
                        Dim i As Integer = 0
                        Dim decHoraInicio As Decimal = 0
                        Dim decHoraFin As Decimal = 0
                        Dim decDiferencia As Decimal = 0
                        Dim decHNoct As Decimal = 0
                        Dim decHNorm As Decimal = 0

                        For Each rowCuerpo As DataRow In odtDetalle.Rows
                            If i = 0 Then
                                dtInicio = CDate(rowCuerpo("entrada"))
                            Else
                                dtFin = CDate(rowCuerpo("salida"))
                            End If

                            i = i + 1
                        Next

                        Dim dtAuxI As DateTime = New DateTime(dtInicio.Year, dtInicio.Month, dtInicio.Day, 21, 0, 0)
                        Dim dtAuxF As DateTime = New DateTime(dtFin.Year, dtFin.Month, dtFin.Day, 6, 0, 0)

                        decHoraInicio = CDec(dtInicio.Hour + (dtInicio.Minute / 60))
                        decHoraFin = CDec(dtFin.Hour + (dtFin.Minute / 60))
                        decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtFin)
                        decTotal = decTotal + CDec(FormatNumber(decMinuto / 60, 1))

                        If decHoraInicio <= 21 And decHoraFin >= 6 Then
                            decHoraNocturna = decHoraNocturna + 9
                            decHora50 = decHora50 + decTotal - 9
                        ElseIf decHoraInicio < 21 And decHoraFin < 6 Then
                            If decTotal > 9 Then
                                decMinuto = DateDiff(DateInterval.Minute, dtAuxI, dtFin)
                                decHNoct = CDec(FormatNumber(decMinuto / 60, 1))

                                decHoraNocturna = decHoraNocturna + decHNoct
                                decHNorm = 9 - decHNoct
                                decHoraNormal = decHoraNormal + decHNorm
                                decHora50 = decHora50 + decTotal - 9
                            Else
                                decMinuto = DateDiff(DateInterval.Minute, dtAuxI, dtFin)
                                decHNoct = CDec(FormatNumber(decMinuto / 60, 1))

                                decHoraNocturna = decHoraNocturna + decHNoct
                                decHNorm = decTotal - decHNoct
                                decHoraNormal = decHoraNormal + decHNorm
                            End If
                        ElseIf decHoraInicio > 21 And decHoraFin >= 6 Then
                            If decTotal > 9 Then
                                decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtAuxF)
                                decHNoct = CDec(FormatNumber(decMinuto / 60, 1))

                                decHoraNocturna = decHoraNocturna + decHNoct
                                decHNorm = 9 - decHNoct
                                decHoraNormal = decHoraNormal + decHNorm
                                decHora50 = decHora50 + decTotal - 9
                            Else
                                decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtAuxF)
                                decHNoct = CDec(FormatNumber(decMinuto / 60, 1))

                                decHoraNocturna = decHoraNocturna + decHNoct
                                decHNorm = decTotal - decHNoct
                                decHoraNormal = decHoraNormal + decHNorm
                            End If
                        ElseIf decHoraInicio > 21 And decHoraFin < 6 Then
                            decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtAuxF)
                            decHNoct = CDec(FormatNumber(decMinuto / 60, 1))

                            decHoraNocturna = decHoraNocturna + decHNoct
                        End If



                        'sabados
                    Case "4"
                        decMinuto = 0
                        decTotal = 0
                        For Each rowCuerpo As DataRow In odtDetalle.Rows
                            dtInicio = CDate(rowCuerpo("entrada"))
                            dtFin = CDate(rowCuerpo("salida"))

                            Dim dtAuxI As DateTime = New DateTime(dtInicio.Year, dtInicio.Month, dtInicio.Day, 13, 0, 0)

                            If dtInicio < dtAuxI And dtFin < dtAuxI Then
                                'horas 50
                                decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtFin)
                                decHora50 = decHora50 + CDec(FormatNumber(decMinuto / 60, 1))
                            ElseIf dtInicio < dtAuxI And dtFin > dtAuxI Then
                                'horas 50
                                decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtAuxI)
                                decHora50 = decHora50 + CDec(FormatNumber(decMinuto / 60, 1))
                                'horas 100
                                decMinuto = DateDiff(DateInterval.Minute, dtAuxI, dtFin)
                                decHora100 = decHora100 + CDec(FormatNumber(decMinuto / 60, 1))
                            ElseIf dtInicio > dtAuxI And dtFin > dtAuxI Then
                                'horas 100
                                decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtFin)
                                decHora100 = decHora100 + CDec(FormatNumber(decMinuto / 60, 1))
                            End If
                        Next
                        'viejo
                        'If decTotal > CDec(5.5) Then
                        '    decHora50 = decHora50 + CDec(5.5)
                        '    decHora100 = decHora100 + decTotal - CDec(5.5)
                        'Else
                        '    decHora50 = decHora50 + decTotal
                        'End If

                        'domingos
                    Case "5"
                        decHora100 = decHora100 + decTotal
                        'enfermedad
                    Case "6"
                        decHoraEnfermedad = decHoraEnfermedad + 8
                        'accidente
                    Case "7"
                        decHoraAccidente = decHoraAccidente + 8
                        'viaje lunes a jueves
                    Case "8"
                        If decTotal > 9 Then
                            decHoraViaje = decHoraViaje + 9
                            decHoraViaje50 = decHoraViaje50 + decTotal - 9
                        Else
                            decHoraViaje = decHoraViaje + decTotal
                        End If
                        'feriado
                    Case "10"
                        decHoraFeriado = decHoraFeriado + 8
                        'especial
                    Case "11"
                        decHoraNoTrabajada = decHoraNoTrabajada + 8
                        'viaje viernes
                    Case "12"
                        If decTotal > 8 Then
                            decHoraViaje = decHoraViaje + 8
                            decHoraViaje50 = decHoraViaje50 + decTotal - 8
                        Else
                            decHoraViaje = decHoraViaje + decTotal
                        End If
                        'viaje sabado
                    Case "13"
                        If decTotal > CDec(5.5) Then
                            decHoraViaje50 = decHoraViaje50 + CDec(5.5)
                            decHoraViaje100 = decHoraViaje100 + decTotal - CDec(5.5)
                        Else
                            decHoraViaje50 = decHoraViaje50 + decTotal
                        End If
                        'viaje domingo
                    Case "14"
                        decHoraViaje100 = decHoraViaje100 + decTotal
                        'feriado trabajado
                    Case "15"
                        If decTotal > 8 Then
                            decHoraNormal = decHoraNormal + 8
                            decHora100 = decHora100 + decTotal - 8
                        Else
                            decHoraNormal = decHoraNormal + decTotal
                        End If
                        decHoraFeriado = decHoraFeriado + 8
                End Select

            End If

        Next

        Dim oClaseHoraTemp As New ClaseHora

        With oClaseHoraTemp
            .HoraNormal = decHoraNormal
            .Hora50 = decHora50
            .Hora100 = decHora100
            .HoraNocturna = decHoraNocturna
            .HoraEnfermedad = decHoraEnfermedad
            .HoraAccidente = decHoraAccidente
            .HoraFeriado = decHoraFeriado
            .HoraNoTrabajada = decHoraNoTrabajada
            .HoraViaje = decHoraViaje
            .HoraViaje50 = decHoraViaje50
            .HoraViaje100 = decHoraViaje100
        End With

        Return oClaseHoraTemp
    End Function



    Function CalcularHoraManual(ByVal id_empleado As Integer, ByVal inicio As DateTime, ByVal fin As DateTime) As ClaseHora
        Dim odt As New DataTable
        Dim odtControl As New DataTable
        Dim odtDetalle As New DataTable

        'para calculo de minutos
        Dim decTotal As Decimal = 0
        Dim decMinuto As Decimal = 0
        'Dim dtInicio As DateTime
        'Dim dtFin As DateTime

        'variables
        Dim decHoraNormal As Decimal = 0
        Dim decHora50 As Decimal = 0
        Dim decHora100 As Decimal = 0
        Dim decHoraNocturna As Decimal = 0
        Dim decHoraEnfermedad As Decimal = 0
        Dim decHoraAccidente As Decimal = 0
        Dim decHoraFeriado As Decimal = 0
        Dim decHoraNoTrabajada As Decimal = 0
        Dim decHoraViaje As Decimal = 0
        Dim decHoraViaje50 As Decimal = 0
        Dim decHoraViaje100 As Decimal = 0
        Dim decHoraAdministrativo As Decimal = 0

        Dim IDMov As Integer = 0

        odtControl = oMovimiento_manual.GetAllControl(id_empleado, Inicio, fin)

        For Each row As DataRow In odtControl.Rows
            Select Case CInt(row("codigo"))
                Case 1
                    decHoraNormal = CDec(row("cantidad"))
                Case 2
                    decHora50 = CDec(row("cantidad"))
                Case 3
                    decHora100 = CDec(row("cantidad"))
                Case 4
                    decHoraViaje = CDec(row("cantidad"))
                Case 5
                    decHoraViaje50 = CDec(row("cantidad"))
                Case 6
                    decHoraNocturna = CDec(row("cantidad"))
                Case 7
                    decHoraEnfermedad = CDec(row("cantidad"))
                Case 8
                    decHoraAccidente = CDec(row("cantidad"))
                Case 9
                    decHoraFeriado = CDec(row("cantidad"))
                Case 11
                    decHoraNoTrabajada = CDec(row("cantidad"))
                Case 12
                    decHoraAdministrativo = CDec(row("cantidad"))
                Case 22
                    decHoraViaje100 = CDec(row("cantidad"))
            End Select
        Next

        Dim oClaseManual As New ClaseHora

        With oClaseManual
            .HoraNormal = decHoraNormal
            .Hora50 = decHora50
            .Hora100 = decHora100
            .HoraNocturna = decHoraNocturna
            .HoraEnfermedad = decHoraEnfermedad
            .HoraAccidente = decHoraAccidente
            .HoraFeriado = decHoraFeriado
            .HoraNoTrabajada = decHoraNoTrabajada
            .HoraViaje = decHoraViaje
            .HoraViaje50 = decHoraViaje50
            .HoraViaje100 = decHoraViaje100
            .HoraAdministrativo = decHoraAdministrativo
        End With

        Return oClaseManual
    End Function



    Sub Quincena_1(ByVal legajo_desde As Integer, ByVal legajo_hasta As Integer, ByVal fecha_inicio As DateTime, ByVal fecha_fin As DateTime)
        Dim odtEmp As New DataTable
        Dim odtSer As New DataTable
        Dim odtRen As New DataTable

        odtEmp = oEmpleado.GetEntreLegajo(legajo_desde, legajo_hasta)
        odtSer = oSereno.ConsultarTodo
        odtRen = oRenglon.ConsultarTodo
        oRecibo_sueldo_temporal.Cargar()
        oRecibo_sueldo_temporal.Truncate()


        'variables de importes sereno
        Dim decSueldoSereno As Decimal = 0
        Dim decContribucionExtraordinaria As Decimal = 0
        Dim decAporteSolidario As Decimal = 0
        Dim decAyudaEscolar As Decimal = 0
        Dim decValorDiscapacitado As Decimal = 0
        Dim decHoraAdministrativo As Decimal = 0
        Dim decValorEmbargo As Decimal = 0

        'variables de importes empleado
        Dim decValorHora As Decimal = 0
        Dim blCoordinador As Boolean = False
        Dim decHijo As Decimal = 0
        Dim decValorHijo As Decimal = 0
        Dim decSMVM As Decimal = 0
        Dim decAdicionalObraSocial As Decimal = 0
        Dim decHijoDiscapacitado As Decimal = 0
        Dim idEmp As Integer = 0
        Dim idTipoEmpleado As Integer = 0
        Dim decEspecialidad As Decimal = 0
        Dim dtFechaIngreso As DateTime

        'variables de dias tarde
        Dim decDiaTarde As Decimal = 0

        'variables totales
        Dim decTotalHaber As Decimal = 0
        Dim decTotalDeduccion As Decimal = 0
        Dim decTotalAdicional As Decimal = 0
        Dim decTotalNetoCobrar As Decimal = 0
        Dim decHaberEspecialidad As Decimal = 0
        Dim decTotalHaberSumatoria As Decimal = 0

        'set los valores fijos de sueldo
        With odtSer.Rows(0)
            decSueldoSereno = CDec(.Item("sueldo_sereno"))
            decContribucionExtraordinaria = CDec(.Item("contribucion_extraordinaria"))
            decAporteSolidario = CDec(.Item("aporte_solidario"))
            decAyudaEscolar = CDec(.Item("ayuda_escolar"))
            decValorDiscapacitado = CDec(.Item("valor_discapacitado"))
            decHoraAdministrativo = CDec(.Item("hora_administrativo"))
            decValorEmbargo = CDec(.Item("valor_embargo"))
        End With


        'Dim fecha_inicio As DateTime
        'Dim fecha_fin As DateTime

        ''seteo la fecha para la quincena 1
        'fecha_inicio = CDate("01-" & periodo.Month & "-" & periodo.Year)
        'fecha_fin = CDate("15-" & periodo.Month & "-" & periodo.Year)


        'recorro los empleados seleccionados
        For Each rowEmp As DataRow In odtEmp.Rows

            decTotalHaber = 0
            decTotalDeduccion = 0
            decTotalAdicional = 0
            decTotalNetoCobrar = 0
            decHaberEspecialidad = 0
            decTotalHaberSumatoria = 0


            'set los valores del empleado
            idEmp = CInt(rowEmp("id_empleado"))
            idTipoEmpleado = CInt(rowEmp("id_tipo_empleado"))
            decValorHora = CDec(rowEmp("valor_hora"))
            blCoordinador = CBool(rowEmp("coordinador"))
            decHijo = CDec(rowEmp("hijo"))
            decValorHijo = CDec(rowEmp("valor_hijo"))
            decSMVM = CDec(rowEmp("salario_mvm"))
            decAdicionalObraSocial = CDec(rowEmp("adicional_obra_social"))
            decHijoDiscapacitado = CDec(rowEmp("hijo_discapacitado"))
            dtFechaIngreso = CDate(rowEmp("ingreso"))


            'calcular horas cargadas automaticas
            Dim oCalculo As New ClaseHora

            'traigo los datos de las horas automaticas
            oCalculo = Me.CalcularHoraAutomatico(idEmp, fecha_inicio, fecha_fin, False)

            '**************************
            '      HABERES
            '**************************

            'ingreso las horas normales
            If oCalculo.HoraNormal <> 0 Then
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 1
                    .nombre_renglon = "Horas Normales"
                    .cantidad = oCalculo.HoraNormal
                    .haber = (oCalculo.HoraNormal + oCalculo.HoraViaje + oCalculo.HoraNocturna) * decValorHora
                    'calculo del total de haberes
                    decTotalHaber = decTotalHaber + .haber
                    .Guardar()
                End With
            End If

            'ingreso las horas al 50
            If oCalculo.Hora50 <> 0 Then
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 2
                    .nombre_renglon = "Horas al 50%"
                    .cantidad = oCalculo.Hora50
                    .haber = (oCalculo.Hora50 + oCalculo.HoraViaje50) * decValorHora * CDec(1.5)
                    'calculo del total de haberes
                    decTotalHaber = decTotalHaber + .haber
                    .Guardar()
                End With
            End If

            'ingreso las horas al 100
            If oCalculo.Hora100 <> 0 Then
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 3
                    .nombre_renglon = "Horas al 100%"
                    .cantidad = oCalculo.Hora100
                    .haber = (oCalculo.Hora100 + oCalculo.HoraViaje100) * decValorHora * CDec(2)
                    'calculo del total de haberes
                    decTotalHaber = decTotalHaber + .haber
                    .Guardar()
                End With
            End If

            'ingreso las horas viaje
            If oCalculo.HoraViaje <> 0 Then
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 4
                    .nombre_renglon = "30% Sobre Horas Normales"
                    .cantidad = oCalculo.HoraViaje
                    .haber = oCalculo.HoraViaje * decValorHora * CDec(0.3)
                    'calculo del total de haberes
                    decTotalHaber = decTotalHaber + .haber
                    .Guardar()
                End With
            End If

            'ingreso las horas viaje al 50
            If oCalculo.HoraViaje50 <> 0 Then
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 5
                    .nombre_renglon = "30% Sobre Horas al 50%"
                    .cantidad = oCalculo.HoraViaje50
                    .haber = oCalculo.HoraViaje50 * decValorHora * CDec(0.3) * CDec(1.5)
                    'calculo del total de haberes
                    decTotalHaber = decTotalHaber + .haber
                    .Guardar()
                End With
            End If

            'ingreso las horas nocturnas
            If oCalculo.HoraNocturna <> 0 Then
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 6
                    .nombre_renglon = "Horas Nocturnas"
                    .cantidad = oCalculo.HoraNocturna
                    .haber = oCalculo.HoraNocturna * decValorHora * CDec(0.1334)
                    'calculo del total de haberes
                    decTotalHaber = decTotalHaber + .haber
                    .Guardar()
                End With
            End If

            'ingreso las horas por enfermedad
            If oCalculo.HoraEnfermedad <> 0 Then
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 7
                    .nombre_renglon = "Horas por Enfermedad"
                    .cantidad = oCalculo.HoraEnfermedad
                    .haber = oCalculo.HoraEnfermedad * decValorHora
                    'calculo del total de haberes
                    decTotalHaber = decTotalHaber + .haber
                    .Guardar()
                End With
            End If

            'ingreso las horas por accidente
            If oCalculo.HoraAccidente <> 0 Then
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 8
                    .nombre_renglon = "Horas por Accidente"
                    .cantidad = oCalculo.HoraAccidente
                    .haber = oCalculo.HoraAccidente * decValorHora
                    'calculo del total de haberes
                    decTotalHaber = decTotalHaber + .haber
                    .Guardar()
                End With
            End If

            'ingreso las horas por feriado
            If oCalculo.HoraFeriado <> 0 Then
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 9
                    .nombre_renglon = "Horas por Feriado"
                    .cantidad = oCalculo.HoraFeriado
                    .haber = oCalculo.HoraFeriado * decValorHora
                    'calculo del total de haberes
                    decTotalHaber = decTotalHaber + .haber
                    .Guardar()
                End With
            End If



            'ingreso las horas por enfermedad
            If oCalculo.HoraNoTrabajada <> 0 Then
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 11
                    .nombre_renglon = "Horas no Trabajadas"
                    .cantidad = oCalculo.HoraNoTrabajada
                    .haber = oCalculo.HoraNoTrabajada * decValorHora
                    'calculo del total de haberes
                    decTotalHaber = decTotalHaber + .haber
                    .Guardar()
                End With
            End If

            'ingreso las horas viaje al 100
            If oCalculo.HoraViaje100 <> 0 Then
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 22
                    .nombre_renglon = "30% Sobre Horas al 100%"
                    .cantidad = oCalculo.HoraViaje100
                    .haber = oCalculo.HoraViaje100 * decValorHora * CDec(0.3) * CDec(2)
                    'calculo del total de haberes
                    decTotalHaber = decTotalHaber + .haber
                    .Guardar()
                End With
            End If


            '******************************
            '   HORAS MANUALES
            '******************************

            Dim odtManual As New DataTable
            odtManual = oMovimiento_manual.GetAllControl(idEmp, fecha_inicio, fecha_fin)
            Dim intCodigoRenglon As Integer = 0
            Dim decCantidad As Decimal = 0
            Dim oCalculoManual As New ClaseHora

            'traigo los datos de las horas automaticas
            oCalculoManual = Me.CalcularHoraManual(idEmp, fecha_inicio, fecha_fin)

            For Each rowManual As DataRow In odtManual.Rows
                intCodigoRenglon = CInt(rowManual("codigo"))
                decCantidad = CDec(rowManual("cantidad"))

                With oRecibo_sueldo_temporal
                    'si la cantidad es 0 no lo guardo
                    If decCantidad <> 0 Then
                        Select Case intCodigoRenglon

                            'ingreso las horas normales
                            Case 1
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 1
                                .nombre_renglon = "Horas Normales"
                                .cantidad = oCalculoManual.HoraNormal
                                .haber = (oCalculoManual.HoraNormal + oCalculoManual.HoraViaje + oCalculoManual.HoraNocturna) * decValorHora
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()

                                'ingreso las horas al 50
                            Case 2

                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 2
                                .nombre_renglon = "Horas al 50%"
                                .cantidad = oCalculoManual.Hora50
                                .haber = (oCalculoManual.Hora50 + oCalculoManual.HoraViaje50) * decValorHora * CDec(1.5)
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()

                                'ingreso las horas al 100
                            Case 3
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 3
                                .nombre_renglon = "Horas al 100%"
                                .cantidad = oCalculoManual.Hora100
                                .haber = (oCalculoManual.Hora100 + oCalculoManual.HoraViaje100) * decValorHora * CDec(2)
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()


                                'ingreso las horas viaje
                            Case 4
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 4
                                .nombre_renglon = "30% Sobre Horas Normales"
                                .cantidad = oCalculoManual.HoraViaje
                                .haber = oCalculoManual.HoraViaje * decValorHora * CDec(0.3)
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()


                                'ingreso las horas viaje al 50
                            Case 5
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 5
                                .nombre_renglon = "30% Sobre Horas al 50%"
                                .cantidad = oCalculoManual.HoraViaje50
                                .haber = oCalculoManual.HoraViaje50 * decValorHora * CDec(0.3) * CDec(1.5)
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()


                                'ingreso las horas nocturnas
                            Case 6
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 6
                                .nombre_renglon = "Horas Nocturnas"
                                .cantidad = oCalculoManual.HoraNocturna
                                .haber = oCalculoManual.HoraNocturna * decValorHora * CDec(0.1334)
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()


                                'ingreso las horas por enfermedad
                            Case 7
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 7
                                .nombre_renglon = "Horas por Enfermedad"
                                .cantidad = oCalculoManual.HoraEnfermedad
                                .haber = oCalculoManual.HoraEnfermedad * decValorHora
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()


                                'ingreso las horas por accidente
                            Case 8
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 8
                                .nombre_renglon = "Horas por Accidente"
                                .cantidad = oCalculoManual.HoraAccidente
                                .haber = oCalculoManual.HoraAccidente * decValorHora
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()


                                'ingreso las horas por feriado
                            Case 9
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 9
                                .nombre_renglon = "Horas por Feriado"
                                .cantidad = oCalculoManual.HoraFeriado
                                .haber = oCalculoManual.HoraFeriado * decValorHora
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()


                                'ingreso las horas por enfermedad
                            Case 11
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 11
                                .nombre_renglon = "Horas no Trabajadas"
                                .cantidad = oCalculoManual.HoraNoTrabajada
                                .haber = oCalculoManual.HoraNoTrabajada * decValorHora
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber


                                'ingreso las horas viaje al 100
                            Case 22
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 22
                                .nombre_renglon = "30% Sobre Horas al 100%"
                                .cantidad = oCalculoManual.HoraViaje100
                                .haber = oCalculoManual.HoraViaje100 * decValorHora * CDec(0.3) * CDec(2)
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()
                        End Select
                    End If
                End With
            Next

            Dim decCantidadHoraTodoNormal As Decimal = 0

            With oCalculo
                decCantidadHoraTodoNormal = CDec(.HoraNormal + (1.5 * .Hora50) + (2 * .Hora100))
            End With

            With oCalculoManual
                decCantidadHoraTodoNormal = decCantidadHoraTodoNormal + CDec(.HoraNormal + (1.5 * .Hora50) + (2 * .Hora100))
            End With

            'si hay haberes continuar sino saltar
            If decTotalHaber > 0 Then

                '******************************************
                '   PRESENTISMO - ANTIGUEDAD - ESPECIALIDAD
                '******************************************

                'ingreso las horas presentismo
                Dim odtTarde As New DataTable
                odtTarde = oDia_tarde.GetAllControl(idEmp, fecha_inicio, fecha_fin)
                decDiaTarde = CDec(odtTarde.Rows(0).Item("cantidad_dia_tarde"))

                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 25
                    .nombre_renglon = "Presentismo"
                    '.cantidad = oCalculo.HoraViaje100
                    .haber = decTotalHaber * (CDec(0.2) - (decDiaTarde * CDec(0.02)))
                    decTotalHaberSumatoria = decTotalHaber + .haber
                    .Guardar()
                End With

                'ingreso de la especialidad
                Dim odtEsp As New DataTable
                odtEsp = oTipo_Empleado.GetOne(idTipoEmpleado)
                decEspecialidad = CDec(odtEsp.Rows(0).Item("porcentaje"))

                If decEspecialidad <= 0 Then
                Else
                    With oRecibo_sueldo_temporal
                        .Insertar()
                        .id_empleado = idEmp
                        .codigo = 26
                        .nombre_renglon = "Especialidad"
                        '.cantidad = oCalculo.HoraViaje100
                        .haber = decTotalHaber * decEspecialidad / 100
                        decHaberEspecialidad = .haber
                        decTotalHaberSumatoria = decTotalHaberSumatoria + .haber
                        .Guardar()
                    End With
                End If

                'ingreso de la antigüedad
                Dim intAntiguedad As Integer = 0
                Dim decAntiguedad As Decimal = 0
                'intAntiguedad = CInt(DateDiff(DateInterval.Year, dtFechaIngreso, fecha_fin))
                decAntiguedad = DateDiff(DateInterval.DayOfYear, dtFechaIngreso, fecha_fin) / CDec(365)
                intAntiguedad = CInt(System.Math.Truncate(decAntiguedad))

                If intAntiguedad > 0 Then
                    With oRecibo_sueldo_temporal
                        .Insertar()
                        .id_empleado = idEmp
                        .codigo = 27
                        .nombre_renglon = "Antigüedad"
                        .cantidad = intAntiguedad
                        .haber = CDec(intAntiguedad / 100 * (decTotalHaber + decHaberEspecialidad))
                        decTotalHaberSumatoria = decTotalHaberSumatoria + .haber
                        .Guardar()
                    End With
                End If




                '**************************
                '      DEDUCCIONES
                '**************************

                'ingreso de la jubilacion
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 2000
                    .nombre_renglon = "Jubilación  11 %"
                    '.cantidad = 0
                    .deduccion = Math.Round(decTotalHaberSumatoria * CDec(0.11), 2)
                    decTotalDeduccion = decTotalDeduccion + .deduccion
                    .Guardar()
                End With

                'ingreso del INSSJP
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 2001
                    .nombre_renglon = "I.N.S.S.J.P  3%"
                    '.cantidad = 0
                    .deduccion = Math.Round(decTotalHaberSumatoria * CDec(0.03), 2)
                    decTotalDeduccion = decTotalDeduccion + .deduccion
                    .Guardar()
                End With

                'ingreso de la obra social
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 2002
                    .nombre_renglon = "Obra Social  2,25%"
                    '.cantidad = 0
                    .deduccion = Math.Round(decTotalHaberSumatoria * CDec(0.0225), 2)
                    decTotalDeduccion = decTotalDeduccion + .deduccion
                    .Guardar()
                End With

                'ingreso del ISSPIC
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 2003
                    .nombre_renglon = "I.S.S.P.I.C.  0,45%"
                    '.cantidad = 0
                    .deduccion = Math.Round(decTotalHaberSumatoria * CDec(0.0045), 2)
                    decTotalDeduccion = decTotalDeduccion + .deduccion
                    .Guardar()
                End With

                'ingreso del ANSSAL
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 2004
                    .nombre_renglon = "ANSSAL  0,30%"
                    '.cantidad = 0
                    .deduccion = Math.Round(decTotalHaberSumatoria * CDec(0.003), 2)
                    decTotalDeduccion = decTotalDeduccion + .deduccion
                    .Guardar()
                End With


                '****************************
                '   HORAS MANUALES RESTO
                '****************************

                Dim odtManualResto As New DataTable
                odtManual = oMovimiento_manual.GetAllControl(idEmp, fecha_inicio, fecha_fin)

                For Each rowManual As DataRow In odtManual.Rows
                    intCodigoRenglon = CInt(rowManual("codigo"))
                    decCantidad = CDec(rowManual("cantidad"))

                    With oRecibo_sueldo_temporal

                        Select Case intCodigoRenglon
                            Case 2007
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 2007
                                .nombre_renglon = "U.O.C.R.A. - Seguros"
                                '.cantidad = 0
                                .deduccion = decSueldoSereno * CDec(0.02)
                                decTotalDeduccion = decTotalDeduccion + .deduccion
                                .Guardar()

                            Case 2016
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 2016
                                .nombre_renglon = "Servicios A.M.M.A."
                                '.cantidad = 0
                                .deduccion = CDec(30)
                                decTotalDeduccion = decTotalDeduccion + .deduccion
                                .Guardar()

                            Case 2005
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 2005
                                .nombre_renglon = "U.O.C.R.A. - C.Sindical  2,5%"
                                '.cantidad = 0
                                .deduccion = decTotalHaberSumatoria * CDec(0.025)
                                decTotalDeduccion = decTotalDeduccion + .deduccion
                                .Guardar()

                            Case 2008
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 2008
                                .nombre_renglon = "Obra Social Administ. 3%"
                                '.cantidad = 0
                                .deduccion = decTotalHaberSumatoria * CDec(0.03)
                                decTotalDeduccion = decTotalDeduccion + .deduccion
                                .Guardar()

                            Case 2009
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 2009
                                .nombre_renglon = "Adicional Obra Social 1,50%"
                                '.cantidad = 0
                                .deduccion = decTotalHaberSumatoria * CDec(0.015)
                                decTotalDeduccion = decTotalDeduccion + .deduccion
                                .Guardar()

                                'Case 2013
                                '    .Insertar()
                                '    .id_empleado = idEmp
                                '    .codigo = 2013
                                '    .nombre_renglon = "Contrib. Extraord. U.O.C.RA."
                                '    '.cantidad = 0
                                '    .deduccion = decSueldoSereno
                                '    decTotalDeduccion = decTotalDeduccion + .deduccion
                                '    .Guardar()
                                'Case 2015
                                '    .Insertar()
                                '    .id_empleado = idEmp
                                '    .codigo = 2015
                                '    .nombre_renglon = "Aporte Solidario UOCRA"
                                '    '.cantidad = 0
                                '    .deduccion = decSueldoSereno
                                '    decTotalDeduccion = decTotalDeduccion + .deduccion
                                '    .Guardar()

                            Case 2017
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 2017
                                .nombre_renglon = "Retención por Embargo Judicial"
                                '.cantidad = 0
                                .deduccion = decCantidadHoraTodoNormal * (decValorHora - decValorEmbargo) * CDec(0.1)
                                decTotalDeduccion = decTotalDeduccion + .deduccion
                                .Guardar()

                            Case 2019
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 2019
                                .nombre_renglon = "Asig. no Rem Res. 2032/10"
                                .cantidad = 1
                                .deduccion = CDec(300) * CDec(0.0225)
                                decTotalDeduccion = decTotalDeduccion + .deduccion
                                .Guardar()

                            Case 2019
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 2019
                                .nombre_renglon = "Res. 2032/10 - Obra Social"
                                .cantidad = 1
                                .deduccion = CDec(300) * CDec(0.0225)
                                decTotalDeduccion = decTotalDeduccion + .deduccion
                                .Guardar()

                            Case 3018
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 3018
                                .nombre_renglon = "Asig. no Rem. Res. 2032/10"
                                .cantidad = 1
                                .adicional = CDec(300)
                                decTotalAdicional = decTotalAdicional + .adicional
                                .Guardar()

                        End Select

                    End With
                Next




                '**************************
                '      ADICIONALES
                '**************************


                decTotalNetoCobrar = decTotalHaberSumatoria - decTotalDeduccion + decTotalAdicional
                Dim intParteDecimal As Decimal = 0
                ' Dim intParteEntera As Integer = 0
                ' intParteEntera = CInt(decTotalNetoCobrar - Math.Floor(decTotalNetoCobrar))
                intParteDecimal = 1 - decTotalNetoCobrar + Math.Floor(decTotalNetoCobrar)

                If intParteDecimal > CDec(0.5) Then
                    intParteDecimal = intParteDecimal - CDec(0.5)
                End If

                'redondeo
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 10000
                    .nombre_renglon = "Redondeo"
                    '.cantidad = 0
                    .adicional = intParteDecimal
                    decTotalAdicional = decTotalAdicional + .adicional
                    decTotalNetoCobrar = decTotalNetoCobrar + .adicional
                    .Guardar()
                End With



                '**********************
                '   GUARDAR VALORES
                '**********************
                Dim strTotalLetra As String = ""
                strTotalLetra = Numalet.ToCardinal(decTotalNetoCobrar)

                'si existe lo borro
                oTotal_sueldo.DeleteExistenteAguinaldo(idEmp, fecha_inicio, fecha_fin, "Q")

                Me.RemuneracionBasica = decValorHora

                With oTotal_sueldo
                    .Cargar()
                    .Insertar()
                    .total_haber = decTotalHaberSumatoria
                    .total_deduccion = decTotalDeduccion
                    .total_adicional = decTotalAdicional
                    .total_cobrar = .total_haber - .total_deduccion + .total_adicional
                    .fecha = fecha_inicio
                    .id_empleado = idEmp
                    .letra_sueldo = strTotalLetra.ToUpper
                    .periodo = "1ª Quincena de " & fecha_inicio.Month & "/" & fecha_inicio.Year
                    .tipo_sueldo = "Q"
                    .Guardar()
                End With
            End If

            oRecibo_sueldo.DeleteLiquidacion("Q", idEmp, fecha_inicio.Date, fecha_fin.Date)

            Me.GuardarReciboSueldo(oRecibo_sueldo_temporal.ConsultarTodo, decTotalHaberSumatoria, decTotalDeduccion, decTotalAdicional, fecha_inicio.Date, "Q")
            oRecibo_sueldo_temporal.Truncate()
        Next
    End Sub


    Sub Quincena_2(ByVal legajo_desde As Integer, ByVal legajo_hasta As Integer, ByVal fecha_inicio As DateTime, ByVal fecha_fin As DateTime)
        Dim odtEmp As New DataTable
        Dim odtSer As New DataTable
        Dim odtRen As New DataTable

        odtEmp = oEmpleado.GetEntreLegajo(legajo_desde, legajo_hasta)
        odtSer = oSereno.ConsultarTodo
        odtRen = oRenglon.ConsultarTodo
        oRecibo_sueldo_temporal.Cargar()
        oRecibo_sueldo_temporal.Truncate()


        'variables de importes sereno
        Dim decSueldoSereno As Decimal = 0
        Dim decContribucionExtraordinaria As Decimal = 0
        Dim decAporteSolidario As Decimal = 0
        Dim decAyudaEscolar As Decimal = 0
        Dim decValorDiscapacitado As Decimal = 0
        Dim decHoraAdministrativo As Decimal = 0
        Dim decValorEmbargo As Decimal = 0

        'variables de importes empleado
        Dim decValorHora As Decimal = 0
        Dim blCoordinador As Boolean = False
        Dim decHijo As Decimal = 0
        Dim decValorHijo As Decimal = 0
        Dim decSMVM As Decimal = 0
        Dim decAdicionalObraSocial As Decimal = 0
        Dim decHijoDiscapacitado As Decimal = 0
        Dim idEmp As Integer = 0
        Dim idTipoEmpleado As Integer = 0
        Dim decEspecialidad As Decimal = 0
        Dim dtFechaIngreso As DateTime

        'variables de dias tarde
        Dim decDiaTarde As Decimal = 0

        'variables totales
        Dim decTotalHaber As Decimal = 0
        Dim decTotalDeduccion As Decimal = 0
        Dim decTotalAdicional As Decimal = 0
        Dim decTotalNetoCobrar As Decimal = 0
        Dim decHaberEspecialidad As Decimal = 0
        Dim decTotalHaberSumatoria As Decimal = 0

        'set los valores fijos de sueldo
        With odtSer.Rows(0)
            decSueldoSereno = CDec(.Item("sueldo_sereno"))
            decContribucionExtraordinaria = CDec(.Item("contribucion_extraordinaria"))
            decAporteSolidario = CDec(.Item("aporte_solidario"))
            decAyudaEscolar = CDec(.Item("ayuda_escolar"))
            decValorDiscapacitado = CDec(.Item("valor_discapacitado"))
            decHoraAdministrativo = CDec(.Item("hora_administrativo"))
            decValorEmbargo = CDec(.Item("valor_embargo"))
        End With


        'Dim fecha_inicio As DateTime
        'Dim fecha_fin As DateTime

        ''seteo la fecha para la quincena 1
        'fecha_inicio = CDate("01-" & periodo.Month & "-" & periodo.Year)
        'fecha_fin = CDate("15-" & periodo.Month & "-" & periodo.Year)


        'recorro los empleados seleccionados
        For Each rowEmp As DataRow In odtEmp.Rows

            decTotalHaber = 0
            decTotalDeduccion = 0
            decTotalAdicional = 0
            decTotalNetoCobrar = 0
            decHaberEspecialidad = 0
            decTotalHaberSumatoria = 0


            'set los valores del empleado
            idEmp = CInt(rowEmp("id_empleado"))
            idTipoEmpleado = CInt(rowEmp("id_tipo_empleado"))
            decValorHora = CDec(rowEmp("valor_hora"))
            blCoordinador = CBool(rowEmp("coordinador"))
            decHijo = CDec(rowEmp("hijo"))
            decValorHijo = CDec(rowEmp("valor_hijo"))
            decSMVM = CDec(rowEmp("salario_mvm"))
            decAdicionalObraSocial = CDec(rowEmp("adicional_obra_social"))
            decHijoDiscapacitado = CDec(rowEmp("hijo_discapacitado"))
            dtFechaIngreso = CDate(rowEmp("ingreso"))


            'calcular horas cargadas automaticas
            Dim oCalculo As New ClaseHora

            'traigo los datos de las horas automaticas
            oCalculo = Me.CalcularHoraAutomatico(idEmp, fecha_inicio, fecha_fin, False)

            '**************************
            '      HABERES
            '**************************

            'ingreso las horas normales
            If oCalculo.HoraNormal <> 0 Then
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 1
                    .nombre_renglon = "Horas Normales"
                    .cantidad = oCalculo.HoraNormal
                    .haber = (oCalculo.HoraNormal + oCalculo.HoraViaje + oCalculo.HoraNocturna) * decValorHora
                    'calculo del total de haberes
                    decTotalHaber = decTotalHaber + .haber
                    .Guardar()
                End With
            End If

            'ingreso las horas al 50
            If oCalculo.Hora50 <> 0 Then
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 2
                    .nombre_renglon = "Horas al 50%"
                    .cantidad = oCalculo.Hora50
                    .haber = (oCalculo.Hora50 + oCalculo.HoraViaje50) * decValorHora * CDec(1.5)
                    'calculo del total de haberes
                    decTotalHaber = decTotalHaber + .haber
                    .Guardar()
                End With
            End If

            'ingreso las horas al 100
            If oCalculo.Hora100 <> 0 Then
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 3
                    .nombre_renglon = "Horas al 100%"
                    .cantidad = oCalculo.Hora100
                    .haber = (oCalculo.Hora100 + oCalculo.HoraViaje100) * decValorHora * CDec(2)
                    'calculo del total de haberes
                    decTotalHaber = decTotalHaber + .haber
                    .Guardar()
                End With
            End If

            'ingreso las horas viaje
            If oCalculo.HoraViaje <> 0 Then
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 4
                    .nombre_renglon = "30% Sobre Horas Normales"
                    .cantidad = oCalculo.HoraViaje
                    .haber = oCalculo.HoraViaje * decValorHora * CDec(0.3)
                    'calculo del total de haberes
                    decTotalHaber = decTotalHaber + .haber
                    .Guardar()
                End With
            End If

            'ingreso las horas viaje al 50
            If oCalculo.HoraViaje50 <> 0 Then
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 5
                    .nombre_renglon = "30% Sobre Horas al 50%"
                    .cantidad = oCalculo.HoraViaje50
                    .haber = oCalculo.HoraViaje50 * decValorHora * CDec(0.3) * CDec(1.5)
                    'calculo del total de haberes
                    decTotalHaber = decTotalHaber + .haber
                    .Guardar()
                End With
            End If

            'ingreso las horas nocturnas
            If oCalculo.HoraNocturna <> 0 Then
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 6
                    .nombre_renglon = "Horas Nocturnas"
                    .cantidad = oCalculo.HoraNocturna
                    .haber = oCalculo.HoraNocturna * decValorHora * CDec(0.1334)
                    'calculo del total de haberes
                    decTotalHaber = decTotalHaber + .haber
                    .Guardar()
                End With
            End If

            'ingreso las horas por enfermedad
            If oCalculo.HoraEnfermedad <> 0 Then
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 7
                    .nombre_renglon = "Horas por Enfermedad"
                    .cantidad = oCalculo.HoraEnfermedad
                    .haber = oCalculo.HoraEnfermedad * decValorHora
                    'calculo del total de haberes
                    decTotalHaber = decTotalHaber + .haber
                    .Guardar()
                End With
            End If

            'ingreso las horas por accidente
            If oCalculo.HoraAccidente <> 0 Then
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 8
                    .nombre_renglon = "Horas por Accidente"
                    .cantidad = oCalculo.HoraAccidente
                    .haber = oCalculo.HoraAccidente * decValorHora
                    'calculo del total de haberes
                    decTotalHaber = decTotalHaber + .haber
                    .Guardar()
                End With
            End If

            'ingreso las horas por feriado
            If oCalculo.HoraFeriado <> 0 Then
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 9
                    .nombre_renglon = "Horas por Feriado"
                    .cantidad = oCalculo.HoraFeriado
                    .haber = oCalculo.HoraFeriado * decValorHora
                    'calculo del total de haberes
                    decTotalHaber = decTotalHaber + .haber
                    .Guardar()
                End With
            End If



            'ingreso las horas por enfermedad
            If oCalculo.HoraNoTrabajada <> 0 Then
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 11
                    .nombre_renglon = "Horas no Trabajadas"
                    .cantidad = oCalculo.HoraNoTrabajada
                    .haber = oCalculo.HoraNoTrabajada * decValorHora
                    'calculo del total de haberes
                    decTotalHaber = decTotalHaber + .haber
                    .Guardar()
                End With
            End If

            'ingreso las horas viaje al 100
            If oCalculo.HoraViaje100 <> 0 Then
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 22
                    .nombre_renglon = "30% Sobre Horas al 100%"
                    .cantidad = oCalculo.HoraViaje100
                    .haber = oCalculo.HoraViaje100 * decValorHora * CDec(0.3) * CDec(2)
                    'calculo del total de haberes
                    decTotalHaber = decTotalHaber + .haber
                    .Guardar()
                End With
            End If


            '******************************
            '   HORAS MANUALES
            '******************************

            Dim odtManual As New DataTable
            odtManual = oMovimiento_manual.GetAllControl(idEmp, fecha_inicio, fecha_fin)
            Dim intCodigoRenglon As Integer = 0
            Dim decCantidad As Decimal = 0
            Dim oCalculoManual As New ClaseHora

            'traigo los datos de las horas automaticas
            oCalculoManual = Me.CalcularHoraManual(idEmp, fecha_inicio, fecha_fin)

            For Each rowManual As DataRow In odtManual.Rows
                intCodigoRenglon = CInt(rowManual("codigo"))
                decCantidad = CDec(rowManual("cantidad"))

                With oRecibo_sueldo_temporal
                    'si la cantidad es 0 no lo guardo
                    If decCantidad <> 0 Then
                        Select Case intCodigoRenglon

                            'ingreso las horas normales
                            Case 1
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 1
                                .nombre_renglon = "Horas Normales"
                                .cantidad = oCalculoManual.HoraNormal
                                .haber = (oCalculoManual.HoraNormal + oCalculoManual.HoraViaje + oCalculoManual.HoraNocturna) * decValorHora
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()

                                'ingreso las horas al 50
                            Case 2

                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 2
                                .nombre_renglon = "Horas al 50%"
                                .cantidad = oCalculoManual.Hora50
                                .haber = (oCalculoManual.Hora50 + oCalculoManual.HoraViaje50) * decValorHora * CDec(1.5)
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()

                                'ingreso las horas al 100
                            Case 3
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 3
                                .nombre_renglon = "Horas al 100%"
                                .cantidad = oCalculoManual.Hora100
                                .haber = (oCalculoManual.Hora100 + oCalculoManual.HoraViaje100) * decValorHora * CDec(2)
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()


                                'ingreso las horas viaje
                            Case 4
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 4
                                .nombre_renglon = "30% Sobre Horas Normales"
                                .cantidad = oCalculoManual.HoraViaje
                                .haber = oCalculoManual.HoraViaje * decValorHora * CDec(0.3)
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()


                                'ingreso las horas viaje al 50
                            Case 5
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 5
                                .nombre_renglon = "30% Sobre Horas al 50%"
                                .cantidad = oCalculoManual.HoraViaje50
                                .haber = oCalculoManual.HoraViaje50 * decValorHora * CDec(0.3) * CDec(1.5)
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()


                                'ingreso las horas nocturnas
                            Case 6
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 6
                                .nombre_renglon = "Horas Nocturnas"
                                .cantidad = oCalculoManual.HoraNocturna
                                .haber = oCalculoManual.HoraNocturna * decValorHora * CDec(0.1334)
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()


                                'ingreso las horas por enfermedad
                            Case 7
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 7
                                .nombre_renglon = "Horas por Enfermedad"
                                .cantidad = oCalculoManual.HoraEnfermedad
                                .haber = oCalculoManual.HoraEnfermedad * decValorHora
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()


                                'ingreso las horas por accidente
                            Case 8
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 8
                                .nombre_renglon = "Horas por Accidente"
                                .cantidad = oCalculoManual.HoraAccidente
                                .haber = oCalculoManual.HoraAccidente * decValorHora
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()


                                'ingreso las horas por feriado
                            Case 9
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 9
                                .nombre_renglon = "Horas por Feriado"
                                .cantidad = oCalculoManual.HoraFeriado
                                .haber = oCalculoManual.HoraFeriado * decValorHora
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()


                                'ingreso las horas por enfermedad
                            Case 11
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 11
                                .nombre_renglon = "Horas no Trabajadas"
                                .cantidad = oCalculoManual.HoraNoTrabajada
                                .haber = oCalculoManual.HoraNoTrabajada * decValorHora
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber


                                'ingreso las horas viaje al 100
                            Case 22
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 22
                                .nombre_renglon = "30% Sobre Horas al 100%"
                                .cantidad = oCalculoManual.HoraViaje100
                                .haber = oCalculoManual.HoraViaje100 * decValorHora * CDec(0.3) * CDec(2)
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()
                        End Select
                    End If
                End With
            Next

            Dim decCantidadHoraTodoNormal As Decimal = 0

            With oCalculo
                decCantidadHoraTodoNormal = CDec(.HoraNormal + (1.5 * .Hora50) + (2 * .Hora100))
            End With

            With oCalculoManual
                decCantidadHoraTodoNormal = decCantidadHoraTodoNormal + CDec(.HoraNormal + (1.5 * .Hora50) + (2 * .Hora100))
            End With

            'si hay haberes continuar sino saltar
            If decTotalHaber > 0 Then

                '******************************************
                '   PRESENTISMO - ANTIGUEDAD - ESPECIALIDAD
                '******************************************

                'ingreso las horas presentismo
                Dim odtTarde As New DataTable
                odtTarde = oDia_tarde.GetAllControl(idEmp, fecha_inicio, fecha_fin)
                decDiaTarde = CDec(odtTarde.Rows(0).Item("cantidad_dia_tarde"))

                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 25
                    .nombre_renglon = "Presentismo"
                    '.cantidad = oCalculo.HoraViaje100
                    .haber = decTotalHaber * (CDec(0.2) - (decDiaTarde * CDec(0.02)))
                    decTotalHaberSumatoria = decTotalHaber + .haber
                    .Guardar()
                End With

                'ingreso de la especialidad
                Dim odtEsp As New DataTable
                odtEsp = oTipo_Empleado.GetOne(idTipoEmpleado)
                decEspecialidad = CDec(odtEsp.Rows(0).Item("porcentaje"))

                If decEspecialidad <= 0 Then
                Else
                    With oRecibo_sueldo_temporal
                        .Insertar()
                        .id_empleado = idEmp
                        .codigo = 26
                        .nombre_renglon = "Especialidad"
                        '.cantidad = oCalculo.HoraViaje100
                        .haber = decTotalHaber * decEspecialidad / 100
                        decHaberEspecialidad = .haber
                        decTotalHaberSumatoria = decTotalHaberSumatoria + .haber
                        .Guardar()
                    End With
                End If


                'ingreso de la antigüedad
                Dim intAntiguedad As Integer = 0
                Dim decAntiguedad As Decimal = 0
                'intAntiguedad = CInt(DateDiff(DateInterval.Year, dtFechaIngreso, fecha_fin))
                decAntiguedad = DateDiff(DateInterval.DayOfYear, dtFechaIngreso, fecha_fin) / CDec(365)
                intAntiguedad = CInt(System.Math.Truncate(decAntiguedad))

                If intAntiguedad > 0 Then
                    With oRecibo_sueldo_temporal
                        .Insertar()
                        .id_empleado = idEmp
                        .codigo = 27
                        .nombre_renglon = "Antigüedad"
                        .cantidad = intAntiguedad
                        .haber = CDec(intAntiguedad / 100 * (decTotalHaber + decHaberEspecialidad))
                        decTotalHaberSumatoria = decTotalHaberSumatoria + .haber
                        .Guardar()
                    End With
                End If




                '**************************
                '      DEDUCCIONES
                '**************************

                'ingreso de la jubilacion
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 2000
                    .nombre_renglon = "Jubilación  11 %"
                    '.cantidad = 0
                    .deduccion = Math.Round(decTotalHaberSumatoria * CDec(0.11), 2)
                    decTotalDeduccion = decTotalDeduccion + .deduccion
                    .Guardar()
                End With

                'ingreso del INSSJP
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 2001
                    .nombre_renglon = "I.N.S.S.J.P  3%"
                    '.cantidad = 0
                    .deduccion = Math.Round(decTotalHaberSumatoria * CDec(0.03), 2)
                    decTotalDeduccion = decTotalDeduccion + .deduccion
                    .Guardar()
                End With

                'ingreso de la obra social
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 2002
                    .nombre_renglon = "Obra Social  2,25%"
                    '.cantidad = 0
                    .deduccion = Math.Round(decTotalHaberSumatoria * CDec(0.0225), 2)
                    decTotalDeduccion = decTotalDeduccion + .deduccion
                    .Guardar()
                End With

                'ingreso del ISSPIC
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 2003
                    .nombre_renglon = "I.S.S.P.I.C.  0,45%"
                    '.cantidad = 0
                    .deduccion = Math.Round(decTotalHaberSumatoria * CDec(0.0045), 2)
                    decTotalDeduccion = decTotalDeduccion + .deduccion
                    .Guardar()
                End With

                'ingreso del ANSSAL
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 2004
                    .nombre_renglon = "ANSSAL  0,30%"
                    '.cantidad = 0
                    .deduccion = Math.Round(decTotalHaberSumatoria * CDec(0.003), 2)
                    decTotalDeduccion = decTotalDeduccion + .deduccion
                    .Guardar()
                End With

                'ingreso uocra seguros
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 2007
                    .nombre_renglon = "U.O.C.R.A. - Seguros"
                    '.cantidad = 0
                    .deduccion = Math.Round(decSueldoSereno * CDec(0.02), 2)
                    decTotalDeduccion = decTotalDeduccion + .deduccion
                    .Guardar()
                End With


                '****************************
                '   HORAS MANUALES RESTO
                '****************************

                Dim odtManualResto As New DataTable
                odtManual = oMovimiento_manual.GetAllControl(idEmp, fecha_inicio, fecha_fin)

                For Each rowManual As DataRow In odtManual.Rows
                    intCodigoRenglon = CInt(rowManual("codigo"))
                    decCantidad = CDec(rowManual("cantidad"))

                    With oRecibo_sueldo_temporal

                        Select Case intCodigoRenglon
                            Case 2007
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 2007
                                .nombre_renglon = "U.O.C.R.A. - Seguros"
                                '.cantidad = 0
                                .deduccion = decSueldoSereno * CDec(0.02)
                                decTotalDeduccion = decTotalDeduccion + .deduccion
                                .Guardar()

                            Case 2016
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 2016
                                .nombre_renglon = "Servicios A.M.M.A."
                                '.cantidad = 0
                                .deduccion = CDec(30)
                                decTotalDeduccion = decTotalDeduccion + .deduccion
                                .Guardar()

                            Case 2005
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 2005
                                .nombre_renglon = "U.O.C.R.A. - C.Sindical  2,5%"
                                '.cantidad = 0
                                .deduccion = decTotalHaberSumatoria * CDec(0.025)
                                decTotalDeduccion = decTotalDeduccion + .deduccion
                                .Guardar()

                            Case 2008
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 2008
                                .nombre_renglon = "Obra Social Administ. 3%"
                                '.cantidad = 0
                                .deduccion = decTotalHaberSumatoria * CDec(0.03)
                                decTotalDeduccion = decTotalDeduccion + .deduccion
                                .Guardar()

                            Case 2009
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 2009
                                .nombre_renglon = "Adicional Obra Social 1,50%"
                                '.cantidad = 0
                                .deduccion = decTotalHaberSumatoria * CDec(0.015)
                                decTotalDeduccion = decTotalDeduccion + .deduccion
                                .Guardar()

                                'Case 2013
                                '    .Insertar()
                                '    .id_empleado = idEmp
                                '    .codigo = 2013
                                '    .nombre_renglon = "Contrib. Extraord. U.O.C.RA."
                                '    '.cantidad = 0
                                '    .deduccion = decSueldoSereno
                                '    decTotalDeduccion = decTotalDeduccion + .deduccion
                                '    .Guardar()
                                'Case 2015
                                '    .Insertar()
                                '    .id_empleado = idEmp
                                '    .codigo = 2015
                                '    .nombre_renglon = "Aporte Solidario UOCRA"
                                '    '.cantidad = 0
                                '    .deduccion = decSueldoSereno
                                '    decTotalDeduccion = decTotalDeduccion + .deduccion
                                '    .Guardar()

                            Case 2017
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 2017
                                .nombre_renglon = "Retención por Embargo Judicial"
                                '.cantidad = 0
                                .deduccion = decCantidadHoraTodoNormal * (decValorHora - decValorEmbargo) * CDec(0.1)
                                decTotalDeduccion = decTotalDeduccion + .deduccion
                                .Guardar()

                            Case 2019
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 2019
                                .nombre_renglon = "Res. 2032/10 - Obra Social"
                                .cantidad = 1
                                .deduccion = CDec(300) * CDec(0.0225)
                                decTotalDeduccion = decTotalDeduccion + .deduccion
                                .Guardar()

                            Case 3018
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 3018
                                .nombre_renglon = "Asig. no Rem. Res. 2032/10"
                                .cantidad = 1
                                .adicional = CDec(300)
                                decTotalAdicional = decTotalAdicional + .adicional
                                .Guardar()

                        End Select

                    End With
                Next




                '**************************
                '      ADICIONALES
                '**************************


                decTotalNetoCobrar = decTotalHaberSumatoria - decTotalDeduccion + decTotalAdicional
                Dim intParteDecimal As Decimal = 0
                ' Dim intParteEntera As Integer = 0
                ' intParteEntera = CInt(decTotalNetoCobrar - Math.Floor(decTotalNetoCobrar))
                intParteDecimal = 1 - decTotalNetoCobrar + Math.Floor(decTotalNetoCobrar)

                If intParteDecimal > CDec(0.5) Then
                    intParteDecimal = intParteDecimal - CDec(0.5)
                End If

                'redondeo
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 10000
                    .nombre_renglon = "Redondeo"
                    '.cantidad = 0
                    .adicional = intParteDecimal
                    decTotalAdicional = decTotalAdicional + .adicional
                    decTotalNetoCobrar = decTotalNetoCobrar + .adicional
                    .Guardar()
                End With



                '**********************
                '   GUARDAR VALORES
                '**********************
                Dim strTotalLetra As String = ""
                strTotalLetra = Numalet.ToCardinal(decTotalNetoCobrar)

                'si existe lo borro
                oTotal_sueldo.DeleteExistenteAguinaldo(idEmp, fecha_inicio, fecha_fin, "R")

                Me.RemuneracionBasica = decValorHora

                With oTotal_sueldo
                    .Cargar()
                    .Insertar()
                    .total_haber = decTotalHaberSumatoria
                    .total_deduccion = decTotalDeduccion
                    .total_adicional = decTotalAdicional
                    .total_cobrar = .total_haber - .total_deduccion + .total_adicional
                    .fecha = fecha_inicio
                    .id_empleado = idEmp
                    .letra_sueldo = strTotalLetra.ToUpper
                    .periodo = "2ª Quincena de " & fecha_inicio.Month & "/" & fecha_inicio.Year
                    .tipo_sueldo = "R"
                    .Guardar()
                End With
            End If

            oRecibo_sueldo.DeleteLiquidacion("R", idEmp, fecha_inicio.Date, fecha_fin.Date)

            Me.GuardarReciboSueldo(oRecibo_sueldo_temporal.ConsultarTodo, decTotalHaberSumatoria, decTotalDeduccion, decTotalAdicional, fecha_inicio.Date, "R")
            oRecibo_sueldo_temporal.Truncate()
        Next
    End Sub


    Sub VacacionEmpleado(ByVal legajo_desde As Integer, ByVal legajo_hasta As Integer, ByVal fecha_inicio As DateTime, ByVal fecha_fin As DateTime)
        Dim odtEmp As New DataTable
        Dim odtSer As New DataTable
        Dim odtRen As New DataTable

        odtEmp = oEmpleado.GetEntreLegajo(legajo_desde, legajo_hasta)
        odtSer = oSereno.ConsultarTodo
        odtRen = oRenglon.ConsultarTodo
        oRecibo_sueldo_temporal.Cargar()
        oRecibo_sueldo_temporal.Truncate()


        'variables de importes sereno
        Dim decSueldoSereno As Decimal = 0
        Dim decContribucionExtraordinaria As Decimal = 0
        Dim decAporteSolidario As Decimal = 0
        Dim decAyudaEscolar As Decimal = 0
        Dim decValorDiscapacitado As Decimal = 0
        Dim decHoraAdministrativo As Decimal = 0
        Dim decValorEmbargo As Decimal = 0

        'variables de importes empleado
        Dim decValorHora As Decimal = 0
        Dim blCoordinador As Boolean = False
        Dim decHijo As Decimal = 0
        Dim decValorHijo As Decimal = 0
        Dim decSMVM As Decimal = 0
        Dim decAdicionalObraSocial As Decimal = 0
        Dim decHijoDiscapacitado As Decimal = 0
        Dim idEmp As Integer = 0
        Dim idTipoEmpleado As Integer = 0
        Dim decEspecialidad As Decimal = 0
        Dim dtFechaIngreso As DateTime

        'variables de dias tarde
        Dim decDiaTarde As Decimal = 0

        'variables totales
        Dim decTotalHaber As Decimal = 0
        Dim decTotalDeduccion As Decimal = 0
        Dim decTotalAdicional As Decimal = 0
        Dim decTotalNetoCobrar As Decimal = 0
        Dim decHaberEspecialidad As Decimal = 0
        Dim decTotalHaberSumatoria As Decimal = 0

        'set los valores fijos de sueldo
        With odtSer.Rows(0)
            decSueldoSereno = CDec(.Item("sueldo_sereno"))
            decContribucionExtraordinaria = CDec(.Item("contribucion_extraordinaria"))
            decAporteSolidario = CDec(.Item("aporte_solidario"))
            decAyudaEscolar = CDec(.Item("ayuda_escolar"))
            decValorDiscapacitado = CDec(.Item("valor_discapacitado"))
            decHoraAdministrativo = CDec(.Item("hora_administrativo"))
            decValorEmbargo = CDec(.Item("valor_embargo"))
        End With


        'Dim fecha_inicio As DateTime
        'Dim fecha_fin As DateTime

        ''seteo la fecha para la quincena 1
        'fecha_inicio = CDate("01-" & periodo.Month & "-" & periodo.Year)
        'fecha_fin = CDate("15-" & periodo.Month & "-" & periodo.Year)


        'recorro los empleados seleccionados
        For Each rowEmp As DataRow In odtEmp.Rows

            decTotalHaber = 0
            decTotalDeduccion = 0
            decTotalAdicional = 0
            decTotalNetoCobrar = 0
            decHaberEspecialidad = 0
            decTotalHaberSumatoria = 0


            'set los valores del empleado
            idEmp = CInt(rowEmp("id_empleado"))
            idTipoEmpleado = CInt(rowEmp("id_tipo_empleado"))
            decValorHora = CDec(rowEmp("valor_hora"))
            blCoordinador = CBool(rowEmp("coordinador"))
            decHijo = CDec(rowEmp("hijo"))
            decValorHijo = CDec(rowEmp("valor_hijo"))
            decSMVM = CDec(rowEmp("salario_mvm"))
            decAdicionalObraSocial = CDec(rowEmp("adicional_obra_social"))
            decHijoDiscapacitado = CDec(rowEmp("hijo_discapacitado"))
            dtFechaIngreso = CDate(rowEmp("ingreso"))


            'calcular horas cargadas automaticas
            Dim oCalculo As New ClaseHora

            'traigo los datos de las horas automaticas
            oCalculo = Me.CalcularHoraAutomatico(idEmp, fecha_inicio, fecha_fin, False)

            '**************************
            '      HABERES
            '**************************
            Dim intCodigoRenglon As Integer = 0
            Dim decCantidad As Decimal = 0
            Dim odtManual As New DataTable
            odtManual = oMovimiento_manual.GetAllControl(idEmp, fecha_inicio, fecha_fin)

            For Each rowManual As DataRow In odtManual.Rows
                intCodigoRenglon = CInt(rowManual("codigo"))
                decCantidad = CDec(rowManual("cantidad"))

                With oRecibo_sueldo_temporal

                        Select intCodigoRenglon
                        Case 13
                            With oRecibo_sueldo_temporal
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 13
                                .nombre_renglon = "Hora - Licencia Anual"
                                .cantidad = decCantidad
                                .haber = decCantidad * decValorHora
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()
                            End With
                    End Select
                End With
            Next

            'ingreso las horas normales
            If oCalculo.HoraNormal <> 0 Then
            
            End If

            ''ingreso las horas al 50
            'If oCalculo.Hora50 <> 0 Then
            '    With oRecibo_sueldo_temporal
            '        .Insertar()
            '        .id_empleado = idEmp
            '        .codigo = 2
            '        .nombre_renglon = "Horas al 50%"
            '        .cantidad = oCalculo.Hora50
            '        .haber = (oCalculo.Hora50 + oCalculo.HoraViaje50) * decValorHora * CDec(1.5)
            '        'calculo del total de haberes
            '        decTotalHaber = decTotalHaber + .haber
            '        .Guardar()
            '    End With
            'End If

            ''ingreso las horas al 100
            'If oCalculo.Hora100 <> 0 Then
            '    With oRecibo_sueldo_temporal
            '        .Insertar()
            '        .id_empleado = idEmp
            '        .codigo = 3
            '        .nombre_renglon = "Horas al 100%"
            '        .cantidad = oCalculo.Hora100
            '        .haber = (oCalculo.Hora100 + oCalculo.HoraViaje100) * decValorHora * CDec(2)
            '        'calculo del total de haberes
            '        decTotalHaber = decTotalHaber + .haber
            '        .Guardar()
            '    End With
            'End If

            ''ingreso las horas viaje
            'If oCalculo.HoraViaje <> 0 Then
            '    With oRecibo_sueldo_temporal
            '        .Insertar()
            '        .id_empleado = idEmp
            '        .codigo = 4
            '        .nombre_renglon = "30% Sobre Horas Normales"
            '        .cantidad = oCalculo.HoraViaje
            '        .haber = oCalculo.HoraViaje * decValorHora * CDec(0.3)
            '        'calculo del total de haberes
            '        decTotalHaber = decTotalHaber + .haber
            '        .Guardar()
            '    End With
            'End If

            ''ingreso las horas viaje al 50
            'If oCalculo.HoraViaje50 <> 0 Then
            '    With oRecibo_sueldo_temporal
            '        .Insertar()
            '        .id_empleado = idEmp
            '        .codigo = 5
            '        .nombre_renglon = "30% Sobre Horas al 50%"
            '        .cantidad = oCalculo.HoraViaje50
            '        .haber = oCalculo.HoraViaje50 * decValorHora * CDec(0.3) * CDec(1.5)
            '        'calculo del total de haberes
            '        decTotalHaber = decTotalHaber + .haber
            '        .Guardar()
            '    End With
            'End If

            ''ingreso las horas nocturnas
            'If oCalculo.HoraNocturna <> 0 Then
            '    With oRecibo_sueldo_temporal
            '        .Insertar()
            '        .id_empleado = idEmp
            '        .codigo = 6
            '        .nombre_renglon = "Horas Nocturnas"
            '        .cantidad = oCalculo.HoraNocturna
            '        .haber = oCalculo.HoraNocturna * decValorHora * CDec(0.1334)
            '        'calculo del total de haberes
            '        decTotalHaber = decTotalHaber + .haber
            '        .Guardar()
            '    End With
            'End If

            ''ingreso las horas por enfermedad
            'If oCalculo.HoraEnfermedad <> 0 Then
            '    With oRecibo_sueldo_temporal
            '        .Insertar()
            '        .id_empleado = idEmp
            '        .codigo = 7
            '        .nombre_renglon = "Horas por Enfermedad"
            '        .cantidad = oCalculo.HoraEnfermedad
            '        .haber = oCalculo.HoraEnfermedad * decValorHora
            '        'calculo del total de haberes
            '        decTotalHaber = decTotalHaber + .haber
            '        .Guardar()
            '    End With
            'End If

            ''ingreso las horas por accidente
            'If oCalculo.HoraAccidente <> 0 Then
            '    With oRecibo_sueldo_temporal
            '        .Insertar()
            '        .id_empleado = idEmp
            '        .codigo = 8
            '        .nombre_renglon = "Horas por Accidente"
            '        .cantidad = oCalculo.HoraAccidente
            '        .haber = oCalculo.HoraAccidente * decValorHora
            '        'calculo del total de haberes
            '        decTotalHaber = decTotalHaber + .haber
            '        .Guardar()
            '    End With
            'End If

            ''ingreso las horas por feriado
            'If oCalculo.HoraFeriado <> 0 Then
            '    With oRecibo_sueldo_temporal
            '        .Insertar()
            '        .id_empleado = idEmp
            '        .codigo = 9
            '        .nombre_renglon = "Horas por Feriado"
            '        .cantidad = oCalculo.HoraFeriado
            '        .haber = oCalculo.HoraFeriado * decValorHora
            '        'calculo del total de haberes
            '        decTotalHaber = decTotalHaber + .haber
            '        .Guardar()
            '    End With
            'End If



            ''ingreso las horas por enfermedad
            'If oCalculo.HoraNoTrabajada <> 0 Then
            '    With oRecibo_sueldo_temporal
            '        .Insertar()
            '        .id_empleado = idEmp
            '        .codigo = 11
            '        .nombre_renglon = "Horas no Trabajadas"
            '        .cantidad = oCalculo.HoraNoTrabajada
            '        .haber = oCalculo.HoraNoTrabajada * decValorHora
            '        'calculo del total de haberes
            '        decTotalHaber = decTotalHaber + .haber
            '        .Guardar()
            '    End With
            'End If

            ''ingreso las horas viaje al 100
            'If oCalculo.HoraViaje100 <> 0 Then
            '    With oRecibo_sueldo_temporal
            '        .Insertar()
            '        .id_empleado = idEmp
            '        .codigo = 22
            '        .nombre_renglon = "30% Sobre Horas al 100%"
            '        .cantidad = oCalculo.HoraViaje100
            '        .haber = oCalculo.HoraViaje100 * decValorHora * CDec(0.3) * CDec(2)
            '        'calculo del total de haberes
            '        decTotalHaber = decTotalHaber + .haber
            '        .Guardar()
            '    End With
            'End If


            '******************************
            '   HORAS MANUALES
            '******************************


            odtManual = oMovimiento_manual.GetAllControl(idEmp, fecha_inicio, fecha_fin)
           
            Dim oCalculoManual As New ClaseHora

            'traigo los datos de las horas automaticas
            oCalculoManual = Me.CalcularHoraManual(idEmp, fecha_inicio, fecha_fin)

            'For Each rowManual As DataRow In odtManual.Rows
            '    intCodigoRenglon = CInt(rowManual("codigo"))
            '    decCantidad = CDec(rowManual("cantidad"))

            '    With oRecibo_sueldo_temporal
            '        'si la cantidad es 0 no lo guardo
            '        If decCantidad <> 0 Then
            '            Select Case intCodigoRenglon

            '                'ingreso las horas normales
            '                Case 1
            '                    .Insertar()
            '                    .id_empleado = idEmp
            '                    .codigo = 1
            '                    .nombre_renglon = "Horas Normales"
            '                    .cantidad = oCalculoManual.HoraNormal
            '                    .haber = (oCalculoManual.HoraNormal + oCalculoManual.HoraViaje + oCalculoManual.HoraNocturna) * decValorHora
            '                    'calculo del total de haberes
            '                    decTotalHaber = decTotalHaber + .haber
            '                    .Guardar()

            '                    'ingreso las horas al 50
            '                Case 2

            '                    .Insertar()
            '                    .id_empleado = idEmp
            '                    .codigo = 2
            '                    .nombre_renglon = "Horas al 50%"
            '                    .cantidad = oCalculoManual.Hora50
            '                    .haber = (oCalculoManual.Hora50 + oCalculoManual.HoraViaje50) * decValorHora * CDec(1.5)
            '                    'calculo del total de haberes
            '                    decTotalHaber = decTotalHaber + .haber
            '                    .Guardar()

            '                    'ingreso las horas al 100
            '                Case 3
            '                    .Insertar()
            '                    .id_empleado = idEmp
            '                    .codigo = 3
            '                    .nombre_renglon = "Horas al 100%"
            '                    .cantidad = oCalculoManual.Hora100
            '                    .haber = (oCalculoManual.Hora100 + oCalculoManual.HoraViaje100) * decValorHora * CDec(2)
            '                    'calculo del total de haberes
            '                    decTotalHaber = decTotalHaber + .haber
            '                    .Guardar()


            '                    'ingreso las horas viaje
            '                Case 4
            '                    .Insertar()
            '                    .id_empleado = idEmp
            '                    .codigo = 4
            '                    .nombre_renglon = "30% Sobre Horas Normales"
            '                    .cantidad = oCalculoManual.HoraViaje
            '                    .haber = oCalculoManual.HoraViaje * decValorHora * CDec(0.3)
            '                    'calculo del total de haberes
            '                    decTotalHaber = decTotalHaber + .haber
            '                    .Guardar()


            '                    'ingreso las horas viaje al 50
            '                Case 5
            '                    .Insertar()
            '                    .id_empleado = idEmp
            '                    .codigo = 5
            '                    .nombre_renglon = "30% Sobre Horas al 50%"
            '                    .cantidad = oCalculoManual.HoraViaje50
            '                    .haber = oCalculoManual.HoraViaje50 * decValorHora * CDec(0.3) * CDec(1.5)
            '                    'calculo del total de haberes
            '                    decTotalHaber = decTotalHaber + .haber
            '                    .Guardar()


            '                    'ingreso las horas nocturnas
            '                Case 6
            '                    .Insertar()
            '                    .id_empleado = idEmp
            '                    .codigo = 6
            '                    .nombre_renglon = "Horas Nocturnas"
            '                    .cantidad = oCalculoManual.HoraNocturna
            '                    .haber = oCalculoManual.HoraNocturna * decValorHora * CDec(0.1334)
            '                    'calculo del total de haberes
            '                    decTotalHaber = decTotalHaber + .haber
            '                    .Guardar()


            '                    'ingreso las horas por enfermedad
            '                Case 7
            '                    .Insertar()
            '                    .id_empleado = idEmp
            '                    .codigo = 7
            '                    .nombre_renglon = "Horas por Enfermedad"
            '                    .cantidad = oCalculoManual.HoraEnfermedad
            '                    .haber = oCalculoManual.HoraEnfermedad * decValorHora
            '                    'calculo del total de haberes
            '                    decTotalHaber = decTotalHaber + .haber
            '                    .Guardar()


            '                    'ingreso las horas por accidente
            '                Case 8
            '                    .Insertar()
            '                    .id_empleado = idEmp
            '                    .codigo = 8
            '                    .nombre_renglon = "Horas por Accidente"
            '                    .cantidad = oCalculoManual.HoraAccidente
            '                    .haber = oCalculoManual.HoraAccidente * decValorHora
            '                    'calculo del total de haberes
            '                    decTotalHaber = decTotalHaber + .haber
            '                    .Guardar()


            '                    'ingreso las horas por feriado
            '                Case 9
            '                    .Insertar()
            '                    .id_empleado = idEmp
            '                    .codigo = 9
            '                    .nombre_renglon = "Horas por Feriado"
            '                    .cantidad = oCalculoManual.HoraFeriado
            '                    .haber = oCalculoManual.HoraFeriado * decValorHora
            '                    'calculo del total de haberes
            '                    decTotalHaber = decTotalHaber + .haber
            '                    .Guardar()


            '                    'ingreso las horas por enfermedad
            '                Case 11
            '                    .Insertar()
            '                    .id_empleado = idEmp
            '                    .codigo = 11
            '                    .nombre_renglon = "Horas no Trabajadas"
            '                    .cantidad = oCalculoManual.HoraNoTrabajada
            '                    .haber = oCalculoManual.HoraNoTrabajada * decValorHora
            '                    'calculo del total de haberes
            '                    decTotalHaber = decTotalHaber + .haber


            '                    'ingreso las horas viaje al 100
            '                Case 22
            '                    .Insertar()
            '                    .id_empleado = idEmp
            '                    .codigo = 22
            '                    .nombre_renglon = "30% Sobre Horas al 100%"
            '                    .cantidad = oCalculoManual.HoraViaje100
            '                    .haber = oCalculoManual.HoraViaje100 * decValorHora * CDec(0.3) * CDec(2)
            '                    'calculo del total de haberes
            '                    decTotalHaber = decTotalHaber + .haber
            '                    .Guardar()
            '            End Select
            '        End If
            '    End With
            'Next


            'si hay haberes continuar sino saltar
            If decTotalHaber > 0 Then

                '******************************************
                '   PRESENTISMO - ANTIGUEDAD - ESPECIALIDAD
                '******************************************

                'ingreso las horas presentismo
                Dim odtTarde As New DataTable
                odtTarde = oDia_tarde.GetAllControl(idEmp, fecha_inicio, fecha_fin)
                decDiaTarde = CDec(odtTarde.Rows(0).Item("cantidad_dia_tarde"))

                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 25
                    .nombre_renglon = "Presentismo"
                    '.cantidad = oCalculo.HoraViaje100
                    .haber = decTotalHaber * (CDec(0.2) - (decDiaTarde * CDec(0.02)))
                    decTotalHaberSumatoria = decTotalHaber + .haber
                    .Guardar()
                End With

                'ingreso de la especialidad
                Dim odtEsp As New DataTable
                odtEsp = oTipo_Empleado.GetOne(idTipoEmpleado)
                decEspecialidad = CDec(odtEsp.Rows(0).Item("porcentaje"))

                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 26
                    .nombre_renglon = "Especialidad"
                    '.cantidad = oCalculo.HoraViaje100
                    .haber = decTotalHaber * decEspecialidad / 100
                    decHaberEspecialidad = .haber
                    decTotalHaberSumatoria = decTotalHaberSumatoria + .haber
                    .Guardar()
                End With

                'ingreso de la antigüedad
                Dim intAntiguedad As Integer = 0
                Dim decAntiguedad As Decimal = 0
                'intAntiguedad = CInt(DateDiff(DateInterval.Year, dtFechaIngreso, fecha_fin))
                decAntiguedad = DateDiff(DateInterval.DayOfYear, dtFechaIngreso, fecha_fin) / CDec(365)
                intAntiguedad = CInt(System.Math.Truncate(decAntiguedad))

                If intAntiguedad > 0 Then
                    With oRecibo_sueldo_temporal
                        .Insertar()
                        .id_empleado = idEmp
                        .codigo = 27
                        .nombre_renglon = "Antigüedad"
                        .cantidad = intAntiguedad
                        .haber = CDec(intAntiguedad / 100 * (decTotalHaber + decHaberEspecialidad))
                        decTotalHaberSumatoria = decTotalHaberSumatoria + .haber
                        .Guardar()
                    End With
                End If




                '**************************
                '      DEDUCCIONES
                '**************************

                'ingreso de la jubilacion
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 2000
                    .nombre_renglon = "Jubilación  11 %"
                    '.cantidad = 0
                    .deduccion = decTotalHaberSumatoria * CDec(0.11)
                    decTotalDeduccion = decTotalDeduccion + .deduccion
                    .Guardar()
                End With

                'ingreso del INSSJP
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 2001
                    .nombre_renglon = "I.N.S.S.J.P  3%"
                    '.cantidad = 0
                    .deduccion = decTotalHaberSumatoria * CDec(0.03)
                    decTotalDeduccion = decTotalDeduccion + .deduccion
                    .Guardar()
                End With

                'ingreso de la obra social
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 2002
                    .nombre_renglon = "Obra Social  2,25%"
                    '.cantidad = 0
                    .deduccion = decTotalHaberSumatoria * CDec(0.0225)
                    decTotalDeduccion = decTotalDeduccion + .deduccion
                    .Guardar()
                End With

                'ingreso del ISSPIC
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 2003
                    .nombre_renglon = "I.S.S.P.I.C.  0,45%"
                    '.cantidad = 0
                    .deduccion = decTotalHaberSumatoria * CDec(0.0045)
                    decTotalDeduccion = decTotalDeduccion + .deduccion
                    .Guardar()
                End With

                'ingreso del ANSSAL
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 2004
                    .nombre_renglon = "ANSSAL  0,30%"
                    '.cantidad = 0
                    .deduccion = decTotalHaberSumatoria * CDec(0.003)
                    decTotalDeduccion = decTotalDeduccion + .deduccion
                    .Guardar()
                End With




                '****************************
                '   HORAS MANUALES RESTO
                '****************************

                Dim odtManualResto As New DataTable
                odtManual = oMovimiento_manual.GetAllControl(idEmp, fecha_inicio, fecha_fin)

                For Each rowManual As DataRow In odtManual.Rows
                    intCodigoRenglon = CInt(rowManual("codigo"))
                    decCantidad = CDec(rowManual("cantidad"))

                    With oRecibo_sueldo_temporal

                        Select Case intCodigoRenglon
                            Case 2007
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 2007
                                .nombre_renglon = "U.O.C.R.A. - Seguros"
                                '.cantidad = 0
                                .deduccion = decSueldoSereno * CDec(0.02)
                                decTotalDeduccion = decTotalDeduccion + .deduccion
                                .Guardar()

                            Case 2016
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 2016
                                .nombre_renglon = "Servicios A.M.M.A."
                                '.cantidad = 0
                                .deduccion = CDec(30)
                                decTotalDeduccion = decTotalDeduccion + .deduccion
                                .Guardar()

                            Case 2005
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 2005
                                .nombre_renglon = "U.O.C.R.A. - C.Sindical  2,5%"
                                '.cantidad = 0
                                .deduccion = decTotalHaberSumatoria * CDec(0.025)
                                decTotalDeduccion = decTotalDeduccion + .deduccion
                                .Guardar()

                            Case 2008
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 2008
                                .nombre_renglon = "Obra Social Administ. 3%"
                                '.cantidad = 0
                                .deduccion = decTotalHaberSumatoria * CDec(0.03)
                                decTotalDeduccion = decTotalDeduccion + .deduccion
                                .Guardar()

                            Case 2009
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 2009
                                .nombre_renglon = "Adicional Obra Social 1,50%"
                                '.cantidad = 0
                                .deduccion = decTotalHaberSumatoria * CDec(0.015)
                                decTotalDeduccion = decTotalDeduccion + .deduccion
                                .Guardar()

                                'Case 2013
                                '    .Insertar()
                                '    .id_empleado = idEmp
                                '    .codigo = 2013
                                '    .nombre_renglon = "Contrib. Extraord. U.O.C.RA."
                                '    '.cantidad = 0
                                '    .deduccion = decSueldoSereno
                                '    decTotalDeduccion = decTotalDeduccion + .deduccion
                                '    .Guardar()
                                'Case 2015
                                '    .Insertar()
                                '    .id_empleado = idEmp
                                '    .codigo = 2015
                                '    .nombre_renglon = "Aporte Solidario UOCRA"
                                '    '.cantidad = 0
                                '    .deduccion = decSueldoSereno
                                '    decTotalDeduccion = decTotalDeduccion + .deduccion
                                '    .Guardar()

                            Case 2017
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 2015
                                .nombre_renglon = "Retención por Embargo Judicial"
                                '.cantidad = 0
                                .deduccion = decCantidad * (decValorHora - decValorEmbargo) * CDec(0.1)
                                decTotalDeduccion = decTotalDeduccion + .deduccion
                                .Guardar()

                            Case 2019
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 2019
                                .nombre_renglon = "Res. 2032/10 - Obra Social"
                                .cantidad = 1
                                .deduccion = CDec(300) * CDec(0.0225)
                                decTotalDeduccion = decTotalDeduccion + .deduccion
                                .Guardar()

                            Case 3018
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 3018
                                .nombre_renglon = "Asig. no Rem. Res. 2032/10"
                                .cantidad = 1
                                .adicional = CDec(300)
                                decTotalAdicional = decTotalAdicional + .adicional
                                .Guardar()

                        End Select

                    End With
                Next




                '**************************
                '      ADICIONALES
                '**************************


                decTotalNetoCobrar = decTotalHaberSumatoria - decTotalDeduccion + decTotalAdicional
                Dim intParteDecimal As Decimal = 0
                ' Dim intParteEntera As Integer = 0
                ' intParteEntera = CInt(decTotalNetoCobrar - Math.Floor(decTotalNetoCobrar))
                intParteDecimal = 1 - decTotalNetoCobrar + Math.Floor(decTotalNetoCobrar)

                If intParteDecimal > CDec(0.5) Then
                    intParteDecimal = intParteDecimal - CDec(0.5)
                End If

                'redondeo
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 10000
                    .nombre_renglon = "Redondeo"
                    '.cantidad = 0
                    .adicional = intParteDecimal
                    decTotalAdicional = decTotalAdicional + .adicional
                    decTotalNetoCobrar = decTotalNetoCobrar + .adicional
                    .Guardar()
                End With



                '**********************
                '   GUARDAR VALORES
                '**********************
                Dim strTotalLetra As String = ""
                strTotalLetra = Numalet.ToCardinal(decTotalNetoCobrar)

                'si existe lo borro
                oTotal_sueldo.DeleteExistenteAguinaldo(idEmp, fecha_inicio, fecha_fin, "V")

                With oTotal_sueldo
                    .Cargar()
                    .Insertar()
                    .total_haber = decTotalHaberSumatoria
                    .total_deduccion = decTotalDeduccion
                    .total_adicional = decTotalAdicional
                    .total_cobrar = .total_haber - .total_deduccion + .total_adicional
                    .fecha = fecha_inicio
                    .id_empleado = idEmp
                    .letra_sueldo = strTotalLetra.ToUpper
                    .periodo = "Licencia Anual/" & fecha_inicio.Year
                    .tipo_sueldo = "V"
                    .Guardar()
                End With
            End If

            oRecibo_sueldo.DeleteLiquidacion("V", idEmp, fecha_inicio.Date, fecha_fin.Date)

            Me.GuardarReciboSueldo(oRecibo_sueldo_temporal.ConsultarTodo, decTotalHaberSumatoria, decTotalDeduccion, decTotalAdicional, fecha_inicio.Date, "V")
            oRecibo_sueldo_temporal.Truncate()
        Next
    End Sub


    Sub SueldoAdministrativo(ByVal legajo_desde As Integer, ByVal legajo_hasta As Integer, ByVal fecha_inicio As DateTime, ByVal fecha_fin As DateTime)
        Dim odtEmp As New DataTable
        Dim odtSer As New DataTable
        Dim odtRen As New DataTable

        odtEmp = oEmpleado.GetEntreLegajo(legajo_desde, legajo_hasta)
        odtSer = oSereno.ConsultarTodo
        odtRen = oRenglon.ConsultarTodo
        oRecibo_sueldo_temporal.Cargar()
        oRecibo_sueldo_temporal.Truncate()


        'variables de importes sereno
        Dim decSueldoSereno As Decimal = 0
        Dim decContribucionExtraordinaria As Decimal = 0
        Dim decAporteSolidario As Decimal = 0
        Dim decAyudaEscolar As Decimal = 0
        Dim decValorDiscapacitado As Decimal = 0
        Dim decHoraAdministrativo As Decimal = 0
        Dim decValorEmbargo As Decimal = 0

        'variables de importes empleado
        Dim decValorHora As Decimal = 0
        Dim blCoordinador As Boolean = False
        Dim decHijo As Decimal = 0
        Dim decValorHijo As Decimal = 0
        Dim decSMVM As Decimal = 0
        Dim decAdicionalObraSocial As Decimal = 0
        Dim decHijoDiscapacitado As Decimal = 0
        Dim idEmp As Integer = 0
        Dim idTipoEmpleado As Integer = 0
        Dim decEspecialidad As Decimal = 0
        Dim dtFechaIngreso As DateTime

        'variables de dias tarde
        Dim decDiaTarde As Decimal = 0

        'variables totales
        Dim decTotalHaber As Decimal = 0
        Dim decTotalDeduccion As Decimal = 0
        Dim decTotalAdicional As Decimal = 0
        Dim decTotalNetoCobrar As Decimal = 0
        Dim decHaberEspecialidad As Decimal = 0
        Dim decTotalHaberSumatoria As Decimal = 0

        'set los valores fijos de sueldo
        With odtSer.Rows(0)
            decSueldoSereno = CDec(.Item("sueldo_sereno"))
            decContribucionExtraordinaria = CDec(.Item("contribucion_extraordinaria"))
            decAporteSolidario = CDec(.Item("aporte_solidario"))
            decAyudaEscolar = CDec(.Item("ayuda_escolar"))
            decValorDiscapacitado = CDec(.Item("valor_discapacitado"))
            decHoraAdministrativo = CDec(.Item("hora_administrativo"))
            decValorEmbargo = CDec(.Item("valor_embargo"))
        End With


        'Dim fecha_inicio As DateTime
        'Dim fecha_fin As DateTime

        ''seteo la fecha para la quincena 1
        'fecha_inicio = CDate("01-" & periodo.Month & "-" & periodo.Year)
        'fecha_fin = CDate("15-" & periodo.Month & "-" & periodo.Year)


        'recorro los empleados seleccionados
        For Each rowEmp As DataRow In odtEmp.Rows

            decTotalHaber = 0
            decTotalDeduccion = 0
            decTotalAdicional = 0
            decTotalNetoCobrar = 0
            decHaberEspecialidad = 0
            decTotalHaberSumatoria = 0


            'set los valores del empleado
            idEmp = CInt(rowEmp("id_empleado"))
            idTipoEmpleado = CInt(rowEmp("id_tipo_empleado"))
            decValorHora = CDec(rowEmp("valor_hora"))
            blCoordinador = CBool(rowEmp("coordinador"))
            decHijo = CDec(rowEmp("hijo"))
            decValorHijo = CDec(rowEmp("valor_hijo"))
            decSMVM = CDec(rowEmp("salario_mvm"))
            decAdicionalObraSocial = CDec(rowEmp("adicional_obra_social"))
            decHijoDiscapacitado = CDec(rowEmp("hijo_discapacitado"))
            dtFechaIngreso = CDate(rowEmp("ingreso"))


            'calcular horas cargadas automaticas
            Dim oCalculo As New ClaseHora

            'traigo los datos de las horas automaticas
            oCalculo = Me.CalcularHoraAutomatico(idEmp, fecha_inicio, fecha_fin, False)

            '**************************
            '      HABERES
            '**************************

            ''ingreso las horas normales

            'With oRecibo_sueldo_temporal
            '    .Insertar()
            '    .id_empleado = idEmp
            '    .codigo = 12
            '    .nombre_renglon = "Horas Administrativos"
            '    .cantidad = 1
            '    .haber = decValorHora
            '    'calculo del total de haberes
            '    decTotalHaber = decTotalHaber + .haber
            '    .Guardar()
            'End With



            '******************************
            '   HORAS MANUALES
            '******************************

            Dim odtManual As New DataTable
            odtManual = oMovimiento_manual.GetAllControl(idEmp, fecha_inicio, fecha_fin)
            Dim intCodigoRenglon As Integer = 0
            Dim decCantidad As Decimal = 0
            Dim oCalculoManual As New ClaseHora

            'traigo los datos de las horas automaticas
            oCalculoManual = Me.CalcularHoraManual(idEmp, fecha_inicio, fecha_fin)

            For Each rowManual As DataRow In odtManual.Rows
                intCodigoRenglon = CInt(rowManual("codigo"))
                decCantidad = CDec(rowManual("cantidad"))

                With oRecibo_sueldo_temporal
                    'si la cantidad es 0 no lo guardo
                    If decCantidad <> 0 Then
                        Select Case intCodigoRenglon

                            'ingreso las horas normales
                            Case 12
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 12
                                .nombre_renglon = "Horas Administrativos"
                                .cantidad = oCalculoManual.HoraAdministrativo
                                .haber = (oCalculoManual.HoraAdministrativo) * decValorHora
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()

                                'ingreso las horas normales
                            Case 1
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 1
                                .nombre_renglon = "Horas Normales"
                                .cantidad = oCalculoManual.HoraNormal
                                .haber = (oCalculoManual.HoraNormal + oCalculoManual.HoraViaje + oCalculoManual.HoraNocturna) * decValorHora
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()

                                'ingreso las horas al 50
                            Case 2

                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 2
                                .nombre_renglon = "Horas al 50%"
                                .cantidad = oCalculoManual.Hora50
                                .haber = (oCalculoManual.Hora50 + oCalculoManual.HoraViaje50) * decValorHora * CDec(1.5)
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()

                                'ingreso las horas al 100
                            Case 3
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 3
                                .nombre_renglon = "Horas al 100%"
                                .cantidad = oCalculoManual.Hora100
                                .haber = (oCalculoManual.Hora100 + oCalculoManual.HoraViaje100) * decValorHora * CDec(2)
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()


                                'ingreso las horas viaje
                            Case 4
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 4
                                .nombre_renglon = "30% Sobre Horas Normales"
                                .cantidad = oCalculoManual.HoraViaje
                                .haber = oCalculoManual.HoraViaje * decValorHora * CDec(0.3)
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()


                                'ingreso las horas viaje al 50
                            Case 5
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 5
                                .nombre_renglon = "30% Sobre Horas al 50%"
                                .cantidad = oCalculoManual.HoraViaje50
                                .haber = oCalculoManual.HoraViaje50 * decValorHora * CDec(0.3) * CDec(1.5)
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()


                                'ingreso las horas nocturnas
                            Case 6
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 6
                                .nombre_renglon = "Horas Nocturnas"
                                .cantidad = oCalculoManual.HoraNocturna
                                .haber = oCalculoManual.HoraNocturna * decValorHora * CDec(0.1334)
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()


                                'ingreso las horas por enfermedad
                            Case 7
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 7
                                .nombre_renglon = "Horas por Enfermedad"
                                .cantidad = oCalculoManual.HoraEnfermedad
                                .haber = oCalculoManual.HoraEnfermedad * decValorHora
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()


                                'ingreso las horas por accidente
                            Case 8
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 8
                                .nombre_renglon = "Horas por Accidente"
                                .cantidad = oCalculoManual.HoraAccidente
                                .haber = oCalculoManual.HoraAccidente * decValorHora
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()


                                'ingreso las horas por feriado
                            Case 9
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 9
                                .nombre_renglon = "Horas por Feriado"
                                .cantidad = oCalculoManual.HoraFeriado
                                .haber = oCalculoManual.HoraFeriado * decValorHora
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()


                                'ingreso las horas por enfermedad
                            Case 11
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 11
                                .nombre_renglon = "Horas no Trabajadas"
                                .cantidad = oCalculoManual.HoraNoTrabajada
                                .haber = oCalculoManual.HoraNoTrabajada * decValorHora
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber


                                'ingreso las horas viaje al 100
                            Case 22
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 22
                                .nombre_renglon = "30% Sobre Horas al 100%"
                                .cantidad = oCalculoManual.HoraViaje100
                                .haber = oCalculoManual.HoraViaje100 * decValorHora * CDec(0.3) * CDec(2)
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()
                        End Select
                    End If
                End With
            Next


            'si hay haberes continuar sino saltar
            If decTotalHaber > 0 Then

                '******************************************
                '   PRESENTISMO - ANTIGUEDAD - ESPECIALIDAD
                '******************************************

                'ingreso las horas presentismo
                Dim odtTarde As New DataTable
                odtTarde = oDia_tarde.GetAllControl(idEmp, fecha_inicio, fecha_fin)
                decDiaTarde = CDec(odtTarde.Rows(0).Item("cantidad_dia_tarde"))

                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 25
                    .nombre_renglon = "Presentismo"
                    '.cantidad = oCalculo.HoraViaje100
                    .haber = decTotalHaber * (CDec(0.0833) - (decDiaTarde * CDec(0.00833)))
                    decTotalHaberSumatoria = decTotalHaber + .haber
                    .Guardar()
                End With

                ''ingreso de la especialidad
                'Dim odtEsp As New DataTable
                'odtEsp = oTipo_Empleado.GetOne(idTipoEmpleado)
                'decEspecialidad = CDec(odtEsp.Rows(0).Item("porcentaje"))

                'With oRecibo_sueldo_temporal
                '    .Insertar()
                '    .id_empleado = idEmp
                '    .codigo = 26
                '    .nombre_renglon = "Especialidad"
                '    '.cantidad = oCalculo.HoraViaje100
                '    .haber = decTotalHaber * decEspecialidad / 100
                '    decHaberEspecialidad = .haber
                '    decTotalHaberSumatoria = decTotalHaberSumatoria + .haber
                '    .Guardar()
                'End With

                ''ingreso de la antigüedad
                'Dim intAntiguedad As Integer = 0
                'intAntiguedad = CInt(DateDiff(DateInterval.Year, dtFechaIngreso, fecha_fin))

                'If intAntiguedad > 0 Then
                '    With oRecibo_sueldo_temporal
                '        .Insertar()
                '        .id_empleado = idEmp
                '        .codigo = 27
                '        .nombre_renglon = "Antigüedad"
                '        .cantidad = intAntiguedad
                '        .haber = CDec(intAntiguedad / 100 * (decTotalHaber + decHaberEspecialidad))
                '        decTotalHaberSumatoria = decTotalHaberSumatoria + .haber
                '        .Guardar()
                '    End With
                'End If




                '**************************
                '      DEDUCCIONES
                '**************************

                'ingreso de la jubilacion
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 2000
                    .nombre_renglon = "Jubilación  11 %"
                    '.cantidad = 0
                    .deduccion = Math.Round(decTotalHaberSumatoria * CDec(0.11), 2)
                    decTotalDeduccion = decTotalDeduccion + .deduccion
                    .Guardar()
                End With

                'ingreso del INSSJP
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 2001
                    .nombre_renglon = "I.N.S.S.J.P  3%"
                    '.cantidad = 0
                    .deduccion = Math.Round(decTotalHaberSumatoria * CDec(0.03), 2)
                    decTotalDeduccion = decTotalDeduccion + .deduccion
                    .Guardar()
                End With

                ''ingreso de la obra social
                'With oRecibo_sueldo_temporal
                '    .Insertar()
                '    .id_empleado = idEmp
                '    .codigo = 2002
                '    .nombre_renglon = "Obra Social  2,25%"
                '    '.cantidad = 0
                '    .deduccion = decTotalHaberSumatoria * CDec(0.0225)
                '    decTotalDeduccion = decTotalDeduccion + .deduccion
                '    .Guardar()
                'End With

                ''ingreso del ISSPIC
                'With oRecibo_sueldo_temporal
                '    .Insertar()
                '    .id_empleado = idEmp
                '    .codigo = 2003
                '    .nombre_renglon = "I.S.S.P.I.C.  0,45%"
                '    '.cantidad = 0
                '    .deduccion = decTotalHaberSumatoria * CDec(0.0045)
                '    decTotalDeduccion = decTotalDeduccion + .deduccion
                '    .Guardar()
                'End With

                'ingreso del ANSSAL
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 2004
                    .nombre_renglon = "ANSSAL  0,30%"
                    '.cantidad = 0
                    .deduccion = Math.Round(decTotalHaberSumatoria * CDec(0.003), 2)
                    decTotalDeduccion = decTotalDeduccion + .deduccion
                    .Guardar()
                End With

                'ingreso del ANSSAL
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 2008
                    .nombre_renglon = "Obra Social Administ. 3% "
                    '.cantidad = 0
                    .deduccion = Math.Round(decTotalHaberSumatoria * CDec(0.03), 2)
                    decTotalDeduccion = decTotalDeduccion + .deduccion
                    .Guardar()
                End With


                '****************************
                '   HORAS MANUALES RESTO
                '****************************

                Dim odtManualResto As New DataTable
                odtManual = oMovimiento_manual.GetAllControl(idEmp, fecha_inicio, fecha_fin)

                For Each rowManual As DataRow In odtManual.Rows
                    intCodigoRenglon = CInt(rowManual("codigo"))
                    decCantidad = CDec(rowManual("cantidad"))

                    With oRecibo_sueldo_temporal

                        Select Case intCodigoRenglon
                            Case 2007
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 2007
                                .nombre_renglon = "U.O.C.R.A. - Seguros"
                                '.cantidad = 0
                                .deduccion = decSueldoSereno * CDec(0.02)
                                decTotalDeduccion = decTotalDeduccion + .deduccion
                                .Guardar()

                            Case 2016
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 2016
                                .nombre_renglon = "Servicios A.M.M.A."
                                '.cantidad = 0
                                .deduccion = CDec(30)
                                decTotalDeduccion = decTotalDeduccion + .deduccion
                                .Guardar()

                            Case 2005
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 2005
                                .nombre_renglon = "U.O.C.R.A. - C.Sindical  2,5%"
                                '.cantidad = 0
                                .deduccion = decTotalHaberSumatoria * CDec(0.025)
                                decTotalDeduccion = decTotalDeduccion + .deduccion
                                .Guardar()

                            Case 2008
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 2008
                                .nombre_renglon = "Obra Social Administ. 3%"
                                '.cantidad = 0
                                .deduccion = decTotalHaberSumatoria * CDec(0.03)
                                decTotalDeduccion = decTotalDeduccion + .deduccion
                                .Guardar()

                            Case 2009
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 2009
                                .nombre_renglon = "Adicional Obra Social 1,50%"
                                '.cantidad = 0
                                .deduccion = decTotalHaberSumatoria * CDec(0.015)
                                decTotalDeduccion = decTotalDeduccion + .deduccion
                                .Guardar()

                                'Case 2013
                                '    .Insertar()
                                '    .id_empleado = idEmp
                                '    .codigo = 2013
                                '    .nombre_renglon = "Contrib. Extraord. U.O.C.RA."
                                '    '.cantidad = 0
                                '    .deduccion = decSueldoSereno
                                '    decTotalDeduccion = decTotalDeduccion + .deduccion
                                '    .Guardar()
                                'Case 2015
                                '    .Insertar()
                                '    .id_empleado = idEmp
                                '    .codigo = 2015
                                '    .nombre_renglon = "Aporte Solidario UOCRA"
                                '    '.cantidad = 0
                                '    .deduccion = decSueldoSereno
                                '    decTotalDeduccion = decTotalDeduccion + .deduccion
                                '    .Guardar()

                            Case 2017
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 2015
                                .nombre_renglon = "Retención por Embargo Judicial"
                                '.cantidad = 0
                                .deduccion = decCantidad * (decValorHora - decValorEmbargo) * CDec(0.1)
                                decTotalDeduccion = decTotalDeduccion + .deduccion
                                .Guardar()
                        End Select

                    End With
                Next




                '**************************
                '      ADICIONALES
                '**************************


                decTotalNetoCobrar = decTotalHaberSumatoria - decTotalDeduccion + decTotalAdicional
                Dim intParteDecimal As Decimal = 0
                ' Dim intParteEntera As Integer = 0
                ' intParteEntera = CInt(decTotalNetoCobrar - Math.Floor(decTotalNetoCobrar))
                intParteDecimal = 1 - decTotalNetoCobrar + Math.Floor(decTotalNetoCobrar)

                If intParteDecimal > CDec(0.5) Then
                    intParteDecimal = intParteDecimal - CDec(0.5)
                End If

                'redondeo
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 10000
                    .nombre_renglon = "Redondeo"
                    '.cantidad = 0
                    .adicional = intParteDecimal
                    decTotalAdicional = decTotalAdicional + .adicional
                    decTotalNetoCobrar = decTotalNetoCobrar + .adicional
                    .Guardar()
                End With



                '**********************
                '   GUARDAR VALORES
                '**********************
                Dim strTotalLetra As String = ""
                strTotalLetra = Numalet.ToCardinal(decTotalNetoCobrar)

                'si existe lo borro
                oTotal_sueldo.DeleteExistenteAguinaldo(idEmp, fecha_inicio, fecha_fin, "S")

                With oTotal_sueldo
                    .Cargar()
                    .Insertar()
                    .total_haber = decTotalHaberSumatoria
                    .total_deduccion = decTotalDeduccion
                    .total_adicional = decTotalAdicional
                    .total_cobrar = .total_haber - .total_deduccion + .total_adicional
                    .fecha = fecha_inicio
                    .id_empleado = idEmp
                    .letra_sueldo = strTotalLetra.ToUpper
                    .periodo = " " & fecha_inicio.Month & "/" & fecha_inicio.Year
                    .tipo_sueldo = "S"
                    .Guardar()
                End With
            End If

            oRecibo_sueldo.DeleteLiquidacion("S", idEmp, fecha_inicio.Date, fecha_fin.Date)

            Me.GuardarReciboSueldo(oRecibo_sueldo_temporal.ConsultarTodo, decTotalHaberSumatoria, decTotalDeduccion, decTotalAdicional, fecha_inicio.Date, "S")
            oRecibo_sueldo_temporal.Truncate()
        Next
    End Sub


    Sub SueldoJefe(ByVal legajo_desde As Integer, ByVal legajo_hasta As Integer, ByVal fecha_inicio As DateTime, ByVal fecha_fin As DateTime)
        Dim odtEmp As New DataTable
        Dim odtSer As New DataTable
        Dim odtRen As New DataTable

        odtEmp = oEmpleado.GetEntreLegajo(legajo_desde, legajo_hasta)
        odtSer = oSereno.ConsultarTodo
        odtRen = oRenglon.ConsultarTodo
        oRecibo_sueldo_temporal.Cargar()
        oRecibo_sueldo_temporal.Truncate()


        'variables de importes sereno
        Dim decSueldoSereno As Decimal = 0
        Dim decContribucionExtraordinaria As Decimal = 0
        Dim decAporteSolidario As Decimal = 0
        Dim decAyudaEscolar As Decimal = 0
        Dim decValorDiscapacitado As Decimal = 0
        Dim decHoraAdministrativo As Decimal = 0
        Dim decValorEmbargo As Decimal = 0

        'variables de importes empleado
        Dim decValorHora As Decimal = 0
        Dim blCoordinador As Boolean = False
        Dim decHijo As Decimal = 0
        Dim decValorHijo As Decimal = 0
        Dim decSMVM As Decimal = 0
        Dim decAdicionalObraSocial As Decimal = 0
        Dim decHijoDiscapacitado As Decimal = 0
        Dim idEmp As Integer = 0
        Dim idTipoEmpleado As Integer = 0
        Dim decEspecialidad As Decimal = 0
        Dim dtFechaIngreso As DateTime

        'variables de dias tarde
        Dim decDiaTarde As Decimal = 0

        'variables totales
        Dim decTotalHaber As Decimal = 0
        Dim decTotalDeduccion As Decimal = 0
        Dim decTotalAdicional As Decimal = 0
        Dim decTotalNetoCobrar As Decimal = 0
        Dim decHaberEspecialidad As Decimal = 0
        Dim decTotalHaberSumatoria As Decimal = 0

        'set los valores fijos de sueldo
        With odtSer.Rows(0)
            decSueldoSereno = CDec(.Item("sueldo_sereno"))
            decContribucionExtraordinaria = CDec(.Item("contribucion_extraordinaria"))
            decAporteSolidario = CDec(.Item("aporte_solidario"))
            decAyudaEscolar = CDec(.Item("ayuda_escolar"))
            decValorDiscapacitado = CDec(.Item("valor_discapacitado"))
            decHoraAdministrativo = CDec(.Item("hora_administrativo"))
            decValorEmbargo = CDec(.Item("valor_embargo"))
        End With


        'Dim fecha_inicio As DateTime
        'Dim fecha_fin As DateTime

        ''seteo la fecha para la quincena 1
        'fecha_inicio = CDate("01-" & periodo.Month & "-" & periodo.Year)
        'fecha_fin = CDate("15-" & periodo.Month & "-" & periodo.Year)


        'recorro los empleados seleccionados
        For Each rowEmp As DataRow In odtEmp.Rows

            decTotalHaber = 0
            decTotalDeduccion = 0
            decTotalAdicional = 0
            decTotalNetoCobrar = 0
            decHaberEspecialidad = 0
            decTotalHaberSumatoria = 0


            'set los valores del empleado
            idEmp = CInt(rowEmp("id_empleado"))
            idTipoEmpleado = CInt(rowEmp("id_tipo_empleado"))
            decValorHora = CDec(rowEmp("valor_hora"))
            blCoordinador = CBool(rowEmp("coordinador"))
            decHijo = CDec(rowEmp("hijo"))
            decValorHijo = CDec(rowEmp("valor_hijo"))
            decSMVM = CDec(rowEmp("salario_mvm"))
            decAdicionalObraSocial = CDec(rowEmp("adicional_obra_social"))
            decHijoDiscapacitado = CDec(rowEmp("hijo_discapacitado"))
            dtFechaIngreso = CDate(rowEmp("ingreso"))


            'calcular horas cargadas automaticas
            Dim oCalculo As New ClaseHora

            'traigo los datos de las horas automaticas
            oCalculo = Me.CalcularHoraAutomatico(idEmp, fecha_inicio, fecha_fin, False)

            '**************************
            '      HABERES
            '**************************

            ''ingreso las horas normales

            'With oRecibo_sueldo_temporal
            '    .Insertar()
            '    .id_empleado = idEmp
            '    .codigo = 1
            '    .nombre_renglon = "Horas Normales"
            '    .cantidad = 1
            '    .haber = decValorHora
            '    'calculo del total de haberes
            '    decTotalHaber = decTotalHaber + .haber
            '    .Guardar()
            'End With



            '******************************
            '   HORAS MANUALES
            '******************************

            Dim odtManual As New DataTable
            odtManual = oMovimiento_manual.GetAllControl(idEmp, fecha_inicio, fecha_fin)
            Dim intCodigoRenglon As Integer = 0
            Dim decCantidad As Decimal = 0
            Dim oCalculoManual As New ClaseHora

            'traigo los datos de las horas automaticas
            oCalculoManual = Me.CalcularHoraManual(idEmp, fecha_inicio, fecha_fin)

            For Each rowManual As DataRow In odtManual.Rows
                intCodigoRenglon = CInt(rowManual("codigo"))
                decCantidad = CDec(rowManual("cantidad"))

                With oRecibo_sueldo_temporal
                    'si la cantidad es 0 no lo guardo
                    If decCantidad <> 0 Then
                        Select Case intCodigoRenglon

                            'ingreso las horas normales
                            Case 1
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 1
                                .nombre_renglon = "Horas Normales"
                                .cantidad = oCalculoManual.HoraNormal
                                .haber = (oCalculoManual.HoraNormal) * decValorHora
                                '.haber = (oCalculoManual.HoraNormal + oCalculoManual.HoraViaje + oCalculoManual.HoraNocturna) * decValorHora
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()

                                'ingreso las horas al 50
                            Case 2

                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 2
                                .nombre_renglon = "Horas al 50%"
                                .cantidad = oCalculoManual.Hora50
                                .haber = (oCalculoManual.Hora50 + oCalculoManual.HoraViaje50) * decValorHora * CDec(1.5)
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()

                                'ingreso las horas al 100
                            Case 3
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 3
                                .nombre_renglon = "Horas al 100%"
                                .cantidad = oCalculoManual.Hora100
                                .haber = (oCalculoManual.Hora100 + oCalculoManual.HoraViaje100) * decValorHora * CDec(2)
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()


                                'ingreso las horas viaje
                            Case 4
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 4
                                .nombre_renglon = "30% Sobre Horas Normales"
                                .cantidad = oCalculoManual.HoraViaje
                                .haber = oCalculoManual.HoraViaje * decValorHora * CDec(0.3)
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()


                                'ingreso las horas viaje al 50
                            Case 5
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 5
                                .nombre_renglon = "30% Sobre Horas al 50%"
                                .cantidad = oCalculoManual.HoraViaje50
                                .haber = oCalculoManual.HoraViaje50 * decValorHora * CDec(0.3) * CDec(1.5)
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()


                                'ingreso las horas nocturnas
                            Case 6
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 6
                                .nombre_renglon = "Horas Nocturnas"
                                .cantidad = oCalculoManual.HoraNocturna
                                .haber = oCalculoManual.HoraNocturna * decValorHora * CDec(0.1334)
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()


                                'ingreso las horas por enfermedad
                            Case 7
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 7
                                .nombre_renglon = "Horas por Enfermedad"
                                .cantidad = oCalculoManual.HoraEnfermedad
                                .haber = oCalculoManual.HoraEnfermedad * decValorHora
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()


                                'ingreso las horas por accidente
                            Case 8
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 8
                                .nombre_renglon = "Horas por Accidente"
                                .cantidad = oCalculoManual.HoraAccidente
                                .haber = oCalculoManual.HoraAccidente * decValorHora
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()


                                'ingreso las horas por feriado
                            Case 9
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 9
                                .nombre_renglon = "Horas por Feriado"
                                .cantidad = oCalculoManual.HoraFeriado
                                .haber = oCalculoManual.HoraFeriado * decValorHora
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()


                                'ingreso las horas por enfermedad
                            Case 11
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 11
                                .nombre_renglon = "Horas no Trabajadas"
                                .cantidad = oCalculoManual.HoraNoTrabajada
                                .haber = oCalculoManual.HoraNoTrabajada * decValorHora
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber


                                'ingreso las horas viaje al 100
                            Case 22
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 22
                                .nombre_renglon = "30% Sobre Horas al 100%"
                                .cantidad = oCalculoManual.HoraViaje100
                                .haber = oCalculoManual.HoraViaje100 * decValorHora * CDec(0.3) * CDec(2)
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()
                        End Select
                    End If
                End With
            Next


            'si hay haberes continuar sino saltar
            If decTotalHaber > 0 Then

                '******************************************
                '   PRESENTISMO - ANTIGUEDAD - ESPECIALIDAD
                '******************************************

                ''ingreso las horas presentismo
                'Dim odtTarde As New DataTable
                'odtTarde = oDia_tarde.GetAllControl(idEmp, fecha_inicio, fecha_fin)
                'decDiaTarde = CDec(odtTarde.Rows(0).Item("cantidad_dia_tarde"))

                'With oRecibo_sueldo_temporal
                '    .Insertar()
                '    .id_empleado = idEmp
                '    .codigo = 25
                '    .nombre_renglon = "Presentismo"
                '    '.cantidad = oCalculo.HoraViaje100
                '    .haber = decTotalHaber * (CDec(0.0833) - (decDiaTarde * CDec(0.00833)))
                '    decTotalHaberSumatoria = decTotalHaber + .haber
                '    .Guardar()
                'End With

                ''ingreso de la especialidad
                'Dim odtEsp As New DataTable
                'odtEsp = oTipo_Empleado.GetOne(idTipoEmpleado)
                'decEspecialidad = CDec(odtEsp.Rows(0).Item("porcentaje"))

                'With oRecibo_sueldo_temporal
                '    .Insertar()
                '    .id_empleado = idEmp
                '    .codigo = 26
                '    .nombre_renglon = "Especialidad"
                '    '.cantidad = oCalculo.HoraViaje100
                '    .haber = decTotalHaber * decEspecialidad / 100
                '    decHaberEspecialidad = .haber
                '    decTotalHaberSumatoria = decTotalHaberSumatoria + .haber
                '    .Guardar()
                'End With

                ''ingreso de la antigüedad
                'Dim intAntiguedad As Integer = 0
                'intAntiguedad = CInt(DateDiff(DateInterval.Year, dtFechaIngreso, fecha_fin))

                'If intAntiguedad > 0 Then
                '    With oRecibo_sueldo_temporal
                '        .Insertar()
                '        .id_empleado = idEmp
                '        .codigo = 27
                '        .nombre_renglon = "Antigüedad"
                '        .cantidad = intAntiguedad
                '        .haber = CDec(intAntiguedad / 100 * (decTotalHaber + decHaberEspecialidad))
                '        decTotalHaberSumatoria = decTotalHaberSumatoria + .haber
                '        .Guardar()
                '    End With
                'End If

                decTotalHaberSumatoria = decTotalHaber


                '**************************
                '      DEDUCCIONES
                '**************************

                ''ingreso de la jubilacion
                'With oRecibo_sueldo_temporal
                '    .Insertar()
                '    .id_empleado = idEmp
                '    .codigo = 2000
                '    .nombre_renglon = "Jubilación  11 %"
                '    '.cantidad = 0
                '    .deduccion = decTotalHaberSumatoria * CDec(0.11)
                '    decTotalDeduccion = decTotalDeduccion + .deduccion
                '    .Guardar()
                'End With

                ''ingreso del INSSJP
                'With oRecibo_sueldo_temporal
                '    .Insertar()
                '    .id_empleado = idEmp
                '    .codigo = 2001
                '    .nombre_renglon = "I.N.S.S.J.P  3%"
                '    '.cantidad = 0
                '    .deduccion = decTotalHaberSumatoria * CDec(0.03)
                '    decTotalDeduccion = decTotalDeduccion + .deduccion
                '    .Guardar()
                'End With

                ' ''ingreso de la obra social
                ''With oRecibo_sueldo_temporal
                ''    .Insertar()
                ''    .id_empleado = idEmp
                ''    .codigo = 2002
                ''    .nombre_renglon = "Obra Social  2,25%"
                ''    '.cantidad = 0
                ''    .deduccion = decTotalHaberSumatoria * CDec(0.0225)
                ''    decTotalDeduccion = decTotalDeduccion + .deduccion
                ''    .Guardar()
                ''End With

                ' ''ingreso del ISSPIC
                ''With oRecibo_sueldo_temporal
                ''    .Insertar()
                ''    .id_empleado = idEmp
                ''    .codigo = 2003
                ''    .nombre_renglon = "I.S.S.P.I.C.  0,45%"
                ''    '.cantidad = 0
                ''    .deduccion = decTotalHaberSumatoria * CDec(0.0045)
                ''    decTotalDeduccion = decTotalDeduccion + .deduccion
                ''    .Guardar()
                ''End With

                ''ingreso del ANSSAL
                'With oRecibo_sueldo_temporal
                '    .Insertar()
                '    .id_empleado = idEmp
                '    .codigo = 2004
                '    .nombre_renglon = "ANSSAL  0,30%"
                '    '.cantidad = 0
                '    .deduccion = decTotalHaberSumatoria * CDec(0.003)
                '    decTotalDeduccion = decTotalDeduccion + .deduccion
                '    .Guardar()
                'End With

                ''ingreso del ANSSAL
                'With oRecibo_sueldo_temporal
                '    .Insertar()
                '    .id_empleado = idEmp
                '    .codigo = 2008
                '    .nombre_renglon = "Obra Social Administ. 3% "
                '    '.cantidad = 0
                '    .deduccion = decTotalHaberSumatoria * CDec(0.03)
                '    decTotalDeduccion = decTotalDeduccion + .deduccion
                '    .Guardar()
                'End With


                '****************************
                '   HORAS MANUALES RESTO
                '****************************

                Dim odtManualResto As New DataTable
                odtManual = oMovimiento_manual.GetAllControl(idEmp, fecha_inicio, fecha_fin)

                For Each rowManual As DataRow In odtManual.Rows
                    intCodigoRenglon = CInt(rowManual("codigo"))
                    decCantidad = CDec(rowManual("cantidad"))

                    With oRecibo_sueldo_temporal

                        Select Case intCodigoRenglon
                            Case 2007
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 2007
                                .nombre_renglon = "U.O.C.R.A. - Seguros"
                                '.cantidad = 0
                                .deduccion = decSueldoSereno * CDec(0.02)
                                decTotalDeduccion = decTotalDeduccion + .deduccion
                                .Guardar()

                            Case 2016
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 2016
                                .nombre_renglon = "Servicios A.M.M.A."
                                '.cantidad = 0
                                .deduccion = CDec(30)
                                decTotalDeduccion = decTotalDeduccion + .deduccion
                                .Guardar()

                            Case 2005
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 2005
                                .nombre_renglon = "U.O.C.R.A. - C.Sindical  2,5%"
                                '.cantidad = 0
                                .deduccion = decTotalHaberSumatoria * CDec(0.025)
                                decTotalDeduccion = decTotalDeduccion + .deduccion
                                .Guardar()

                            Case 2008
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 2008
                                .nombre_renglon = "Obra Social Administ. 3%"
                                '.cantidad = 0
                                .deduccion = decTotalHaberSumatoria * CDec(0.03)
                                decTotalDeduccion = decTotalDeduccion + .deduccion
                                .Guardar()

                            Case 2009
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 2009
                                .nombre_renglon = "Adicional Obra Social 1,50%"
                                '.cantidad = 0
                                .deduccion = decTotalHaberSumatoria * CDec(0.015)
                                decTotalDeduccion = decTotalDeduccion + .deduccion
                                .Guardar()

                                'Case 2013
                                '    .Insertar()
                                '    .id_empleado = idEmp
                                '    .codigo = 2013
                                '    .nombre_renglon = "Contrib. Extraord. U.O.C.RA."
                                '    '.cantidad = 0
                                '    .deduccion = decSueldoSereno
                                '    decTotalDeduccion = decTotalDeduccion + .deduccion
                                '    .Guardar()
                                'Case 2015
                                '    .Insertar()
                                '    .id_empleado = idEmp
                                '    .codigo = 2015
                                '    .nombre_renglon = "Aporte Solidario UOCRA"
                                '    '.cantidad = 0
                                '    .deduccion = decSueldoSereno
                                '    decTotalDeduccion = decTotalDeduccion + .deduccion
                                '    .Guardar()

                            Case 2017
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 2015
                                .nombre_renglon = "Retención por Embargo Judicial"
                                '.cantidad = 0
                                .deduccion = decCantidad * (decValorHora - decValorEmbargo) * CDec(0.1)
                                decTotalDeduccion = decTotalDeduccion + .deduccion
                                .Guardar()
                        End Select

                    End With
                Next




                '**************************
                '      ADICIONALES
                '**************************


                decTotalNetoCobrar = decTotalHaberSumatoria - decTotalDeduccion + decTotalAdicional
                Dim intParteDecimal As Decimal = 0
                ' Dim intParteEntera As Integer = 0
                ' intParteEntera = CInt(decTotalNetoCobrar - Math.Floor(decTotalNetoCobrar))
                intParteDecimal = 1 - decTotalNetoCobrar + Math.Floor(decTotalNetoCobrar)

                If intParteDecimal > CDec(0.5) Then
                    intParteDecimal = intParteDecimal - CDec(0.5)
                End If

                If intParteDecimal = CDec(0.5) Then
                Else
                    'redondeo
                    With oRecibo_sueldo_temporal
                        .Insertar()
                        .id_empleado = idEmp
                        .codigo = 10000
                        .nombre_renglon = "Redondeo"
                        '.cantidad = 0
                        .adicional = intParteDecimal
                        decTotalAdicional = decTotalAdicional + .adicional
                        decTotalNetoCobrar = decTotalNetoCobrar + .adicional
                        .Guardar()
                    End With
                End If




                '**********************
                '   GUARDAR VALORES
                '**********************
                Dim strTotalLetra As String = ""
                strTotalLetra = Numalet.ToCardinal(decTotalNetoCobrar)

                'si existe lo borro
                oTotal_sueldo.DeleteExistenteAguinaldo(idEmp, fecha_inicio, fecha_fin, "J")

                With oTotal_sueldo
                    .Cargar()
                    .Insertar()
                    .total_haber = decTotalHaberSumatoria
                    .total_deduccion = decTotalDeduccion
                    .total_adicional = decTotalAdicional
                    .total_cobrar = .total_haber - .total_deduccion + .total_adicional
                    .fecha = fecha_inicio
                    .id_empleado = idEmp
                    .letra_sueldo = strTotalLetra.ToUpper
                    .periodo = " " & fecha_inicio.Month & "/" & fecha_inicio.Year
                    .tipo_sueldo = "J"
                    .Guardar()
                End With
            End If

            oRecibo_sueldo.DeleteLiquidacion("J", idEmp, fecha_inicio.Date, fecha_fin.Date)

            Me.GuardarReciboSueldo(oRecibo_sueldo_temporal.ConsultarTodo, decTotalHaberSumatoria, decTotalDeduccion, decTotalAdicional, fecha_inicio.Date, "J")
            oRecibo_sueldo_temporal.Truncate()
        Next
    End Sub


    Sub VacacionAdministrativo(ByVal legajo_desde As Integer, ByVal legajo_hasta As Integer, ByVal fecha_inicio As DateTime, ByVal fecha_fin As DateTime)
        Dim odtEmp As New DataTable
        Dim odtSer As New DataTable
        Dim odtRen As New DataTable

        odtEmp = oEmpleado.GetEntreLegajo(legajo_desde, legajo_hasta)
        odtSer = oSereno.ConsultarTodo
        odtRen = oRenglon.ConsultarTodo
        oRecibo_sueldo_temporal.Cargar()
        oRecibo_sueldo_temporal.Truncate()


        'variables de importes sereno
        Dim decSueldoSereno As Decimal = 0
        Dim decContribucionExtraordinaria As Decimal = 0
        Dim decAporteSolidario As Decimal = 0
        Dim decAyudaEscolar As Decimal = 0
        Dim decValorDiscapacitado As Decimal = 0
        Dim decHoraAdministrativo As Decimal = 0
        Dim decValorEmbargo As Decimal = 0

        'variables de importes empleado
        Dim decValorHora As Decimal = 0
        Dim blCoordinador As Boolean = False
        Dim decHijo As Decimal = 0
        Dim decValorHijo As Decimal = 0
        Dim decSMVM As Decimal = 0
        Dim decAdicionalObraSocial As Decimal = 0
        Dim decHijoDiscapacitado As Decimal = 0
        Dim idEmp As Integer = 0
        Dim idTipoEmpleado As Integer = 0
        Dim decEspecialidad As Decimal = 0
        Dim dtFechaIngreso As DateTime

        'variables de dias tarde
        Dim decDiaTarde As Decimal = 0

        'variables totales
        Dim decTotalHaber As Decimal = 0
        Dim decTotalDeduccion As Decimal = 0
        Dim decTotalAdicional As Decimal = 0
        Dim decTotalNetoCobrar As Decimal = 0
        Dim decHaberEspecialidad As Decimal = 0
        Dim decTotalHaberSumatoria As Decimal = 0

        'set los valores fijos de sueldo
        With odtSer.Rows(0)
            decSueldoSereno = CDec(.Item("sueldo_sereno"))
            decContribucionExtraordinaria = CDec(.Item("contribucion_extraordinaria"))
            decAporteSolidario = CDec(.Item("aporte_solidario"))
            decAyudaEscolar = CDec(.Item("ayuda_escolar"))
            decValorDiscapacitado = CDec(.Item("valor_discapacitado"))
            decHoraAdministrativo = CDec(.Item("hora_administrativo"))
            decValorEmbargo = CDec(.Item("valor_embargo"))
        End With


        'Dim fecha_inicio As DateTime
        'Dim fecha_fin As DateTime

        ''seteo la fecha para la quincena 1
        'fecha_inicio = CDate("01-" & periodo.Month & "-" & periodo.Year)
        'fecha_fin = CDate("15-" & periodo.Month & "-" & periodo.Year)


        'recorro los empleados seleccionados
        For Each rowEmp As DataRow In odtEmp.Rows

            decTotalHaber = 0
            decTotalDeduccion = 0
            decTotalAdicional = 0
            decTotalNetoCobrar = 0
            decHaberEspecialidad = 0
            decTotalHaberSumatoria = 0


            'set los valores del empleado
            idEmp = CInt(rowEmp("id_empleado"))
            idTipoEmpleado = CInt(rowEmp("id_tipo_empleado"))
            decValorHora = CDec(rowEmp("valor_hora"))
            blCoordinador = CBool(rowEmp("coordinador"))
            decHijo = CDec(rowEmp("hijo"))
            decValorHijo = CDec(rowEmp("valor_hijo"))
            decSMVM = CDec(rowEmp("salario_mvm"))
            decAdicionalObraSocial = CDec(rowEmp("adicional_obra_social"))
            decHijoDiscapacitado = CDec(rowEmp("hijo_discapacitado"))
            dtFechaIngreso = CDate(rowEmp("ingreso"))


            'calcular horas cargadas automaticas
            Dim oCalculo As New ClaseHora

            'traigo los datos de las horas automaticas
            oCalculo = Me.CalcularHoraAutomatico(idEmp, fecha_inicio, fecha_fin, False)

            '**************************
            '      HABERES
            '**************************

            'ingreso las horas normales

            With oRecibo_sueldo_temporal
                .Insertar()
                .id_empleado = idEmp
                .codigo = 13
                .nombre_renglon = "Horas - Licencia Anual"
                .cantidad = 1
                .haber = decValorHora
                'calculo del total de haberes
                decTotalHaber = decTotalHaber + .haber
                .Guardar()
            End With



            '******************************
            '   HORAS MANUALES
            '******************************

            Dim odtManual As New DataTable
            odtManual = oMovimiento_manual.GetAllControl(idEmp, fecha_inicio, fecha_fin)
            Dim intCodigoRenglon As Integer = 0
            Dim decCantidad As Decimal = 0
            Dim oCalculoManual As New ClaseHora

            'traigo los datos de las horas automaticas
            oCalculoManual = Me.CalcularHoraManual(idEmp, fecha_inicio, fecha_fin)

            'For Each rowManual As DataRow In odtManual.Rows
            '    intCodigoRenglon = CInt(rowManual("codigo"))
            '    decCantidad = CDec(rowManual("cantidad"))

            '    With oRecibo_sueldo_temporal
            '        'si la cantidad es 0 no lo guardo
            '        If decCantidad <> 0 Then
            '            Select Case intCodigoRenglon

            '                'ingreso las horas normales
            '                Case 1
            '                    .Insertar()
            '                    .id_empleado = idEmp
            '                    .codigo = 1
            '                    .nombre_renglon = "Horas Normales"
            '                    .cantidad = oCalculoManual.HoraNormal
            '                    .haber = (oCalculoManual.HoraNormal + oCalculoManual.HoraViaje + oCalculoManual.HoraNocturna) * decValorHora
            '                    'calculo del total de haberes
            '                    decTotalHaber = decTotalHaber + .haber
            '                    .Guardar()

            '                    'ingreso las horas al 50
            '                Case 2

            '                    .Insertar()
            '                    .id_empleado = idEmp
            '                    .codigo = 2
            '                    .nombre_renglon = "Horas al 50%"
            '                    .cantidad = oCalculoManual.Hora50
            '                    .haber = (oCalculoManual.Hora50 + oCalculoManual.HoraViaje50) * decValorHora * CDec(1.5)
            '                    'calculo del total de haberes
            '                    decTotalHaber = decTotalHaber + .haber
            '                    .Guardar()

            '                    'ingreso las horas al 100
            '                Case 3
            '                    .Insertar()
            '                    .id_empleado = idEmp
            '                    .codigo = 3
            '                    .nombre_renglon = "Horas al 100%"
            '                    .cantidad = oCalculoManual.Hora100
            '                    .haber = (oCalculoManual.Hora100 + oCalculoManual.HoraViaje100) * decValorHora * CDec(2)
            '                    'calculo del total de haberes
            '                    decTotalHaber = decTotalHaber + .haber
            '                    .Guardar()


            '                    'ingreso las horas viaje
            '                Case 4
            '                    .Insertar()
            '                    .id_empleado = idEmp
            '                    .codigo = 4
            '                    .nombre_renglon = "30% Sobre Horas Normales"
            '                    .cantidad = oCalculoManual.HoraViaje
            '                    .haber = oCalculoManual.HoraViaje * decValorHora * CDec(0.3)
            '                    'calculo del total de haberes
            '                    decTotalHaber = decTotalHaber + .haber
            '                    .Guardar()


            '                    'ingreso las horas viaje al 50
            '                Case 5
            '                    .Insertar()
            '                    .id_empleado = idEmp
            '                    .codigo = 5
            '                    .nombre_renglon = "30% Sobre Horas al 50%"
            '                    .cantidad = oCalculoManual.HoraViaje50
            '                    .haber = oCalculoManual.HoraViaje50 * decValorHora * CDec(0.3) * CDec(1.5)
            '                    'calculo del total de haberes
            '                    decTotalHaber = decTotalHaber + .haber
            '                    .Guardar()


            '                    'ingreso las horas nocturnas
            '                Case 6
            '                    .Insertar()
            '                    .id_empleado = idEmp
            '                    .codigo = 6
            '                    .nombre_renglon = "Horas Nocturnas"
            '                    .cantidad = oCalculoManual.HoraNocturna
            '                    .haber = oCalculoManual.HoraNocturna * decValorHora * CDec(0.1334)
            '                    'calculo del total de haberes
            '                    decTotalHaber = decTotalHaber + .haber
            '                    .Guardar()


            '                    'ingreso las horas por enfermedad
            '                Case 7
            '                    .Insertar()
            '                    .id_empleado = idEmp
            '                    .codigo = 7
            '                    .nombre_renglon = "Horas por Enfermedad"
            '                    .cantidad = oCalculoManual.HoraEnfermedad
            '                    .haber = oCalculoManual.HoraEnfermedad * decValorHora
            '                    'calculo del total de haberes
            '                    decTotalHaber = decTotalHaber + .haber
            '                    .Guardar()


            '                    'ingreso las horas por accidente
            '                Case 8
            '                    .Insertar()
            '                    .id_empleado = idEmp
            '                    .codigo = 8
            '                    .nombre_renglon = "Horas por Accidente"
            '                    .cantidad = oCalculoManual.HoraAccidente
            '                    .haber = oCalculoManual.HoraAccidente * decValorHora
            '                    'calculo del total de haberes
            '                    decTotalHaber = decTotalHaber + .haber
            '                    .Guardar()


            '                    'ingreso las horas por feriado
            '                Case 9
            '                    .Insertar()
            '                    .id_empleado = idEmp
            '                    .codigo = 9
            '                    .nombre_renglon = "Horas por Feriado"
            '                    .cantidad = oCalculoManual.HoraFeriado
            '                    .haber = oCalculoManual.HoraFeriado * decValorHora
            '                    'calculo del total de haberes
            '                    decTotalHaber = decTotalHaber + .haber
            '                    .Guardar()


            '                    'ingreso las horas por enfermedad
            '                Case 11
            '                    .Insertar()
            '                    .id_empleado = idEmp
            '                    .codigo = 11
            '                    .nombre_renglon = "Horas no Trabajadas"
            '                    .cantidad = oCalculoManual.HoraNoTrabajada
            '                    .haber = oCalculoManual.HoraNoTrabajada * decValorHora
            '                    'calculo del total de haberes
            '                    decTotalHaber = decTotalHaber + .haber


            '                    'ingreso las horas viaje al 100
            '                Case 22
            '                    .Insertar()
            '                    .id_empleado = idEmp
            '                    .codigo = 22
            '                    .nombre_renglon = "30% Sobre Horas al 100%"
            '                    .cantidad = oCalculoManual.HoraViaje100
            '                    .haber = oCalculoManual.HoraViaje100 * decValorHora * CDec(0.3) * CDec(2)
            '                    'calculo del total de haberes
            '                    decTotalHaber = decTotalHaber + .haber
            '                    .Guardar()
            '            End Select
            '        End If
            '    End With
            'Next


            'si hay haberes continuar sino saltar
            If decTotalHaber > 0 Then

                '******************************************
                '   PRESENTISMO - ANTIGUEDAD - ESPECIALIDAD
                '******************************************

                'ingreso las horas presentismo
                Dim odtTarde As New DataTable
                odtTarde = oDia_tarde.GetAllControl(idEmp, fecha_inicio, fecha_fin)
                decDiaTarde = CDec(odtTarde.Rows(0).Item("cantidad_dia_tarde"))

                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 25
                    .nombre_renglon = "Presentismo"
                    '.cantidad = oCalculo.HoraViaje100
                    .haber = decTotalHaber * (CDec(0.0833) - (decDiaTarde * CDec(0.00833)))
                    decTotalHaberSumatoria = decTotalHaber + .haber
                    .Guardar()
                End With

                ''ingreso de la especialidad
                'Dim odtEsp As New DataTable
                'odtEsp = oTipo_Empleado.GetOne(idTipoEmpleado)
                'decEspecialidad = CDec(odtEsp.Rows(0).Item("porcentaje"))

                'With oRecibo_sueldo_temporal
                '    .Insertar()
                '    .id_empleado = idEmp
                '    .codigo = 26
                '    .nombre_renglon = "Especialidad"
                '    '.cantidad = oCalculo.HoraViaje100
                '    .haber = decTotalHaber * decEspecialidad / 100
                '    decHaberEspecialidad = .haber
                '    decTotalHaberSumatoria = decTotalHaberSumatoria + .haber
                '    .Guardar()
                'End With

                ''ingreso de la antigüedad
                'Dim intAntiguedad As Integer = 0
                'intAntiguedad = CInt(DateDiff(DateInterval.Year, dtFechaIngreso, fecha_fin))

                'If intAntiguedad > 0 Then
                '    With oRecibo_sueldo_temporal
                '        .Insertar()
                '        .id_empleado = idEmp
                '        .codigo = 27
                '        .nombre_renglon = "Antigüedad"
                '        .cantidad = intAntiguedad
                '        .haber = CDec(intAntiguedad / 100 * (decTotalHaber + decHaberEspecialidad))
                '        decTotalHaberSumatoria = decTotalHaberSumatoria + .haber
                '        .Guardar()
                '    End With
                'End If




                '**************************
                '      DEDUCCIONES
                '**************************

                'ingreso de la jubilacion
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 2000
                    .nombre_renglon = "Jubilación  11 %"
                    '.cantidad = 0
                    .deduccion = decTotalHaberSumatoria * CDec(0.11)
                    decTotalDeduccion = decTotalDeduccion + .deduccion
                    .Guardar()
                End With

                'ingreso del INSSJP
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 2001
                    .nombre_renglon = "I.N.S.S.J.P  3%"
                    '.cantidad = 0
                    .deduccion = decTotalHaberSumatoria * CDec(0.03)
                    decTotalDeduccion = decTotalDeduccion + .deduccion
                    .Guardar()
                End With

                ''ingreso de la obra social
                'With oRecibo_sueldo_temporal
                '    .Insertar()
                '    .id_empleado = idEmp
                '    .codigo = 2002
                '    .nombre_renglon = "Obra Social  2,25%"
                '    '.cantidad = 0
                '    .deduccion = decTotalHaberSumatoria * CDec(0.0225)
                '    decTotalDeduccion = decTotalDeduccion + .deduccion
                '    .Guardar()
                'End With

                ''ingreso del ISSPIC
                'With oRecibo_sueldo_temporal
                '    .Insertar()
                '    .id_empleado = idEmp
                '    .codigo = 2003
                '    .nombre_renglon = "I.S.S.P.I.C.  0,45%"
                '    '.cantidad = 0
                '    .deduccion = decTotalHaberSumatoria * CDec(0.0045)
                '    decTotalDeduccion = decTotalDeduccion + .deduccion
                '    .Guardar()
                'End With

                'ingreso del ANSSAL
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 2004
                    .nombre_renglon = "ANSSAL  0,30%"
                    '.cantidad = 0
                    .deduccion = decTotalHaberSumatoria * CDec(0.003)
                    decTotalDeduccion = decTotalDeduccion + .deduccion
                    .Guardar()
                End With

                'ingreso del ANSSAL
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 2008
                    .nombre_renglon = "Obra Social Administ. 3% "
                    '.cantidad = 0
                    .deduccion = decTotalHaberSumatoria * CDec(0.03)
                    decTotalDeduccion = decTotalDeduccion + .deduccion
                    .Guardar()
                End With


                '****************************
                '   HORAS MANUALES RESTO
                '****************************

                Dim odtManualResto As New DataTable
                odtManual = oMovimiento_manual.GetAllControl(idEmp, fecha_inicio, fecha_fin)

                For Each rowManual As DataRow In odtManual.Rows
                    intCodigoRenglon = CInt(rowManual("codigo"))
                    decCantidad = CDec(rowManual("cantidad"))

                    With oRecibo_sueldo_temporal

                        Select Case intCodigoRenglon
                            Case 2007
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 2007
                                .nombre_renglon = "U.O.C.R.A. - Seguros"
                                '.cantidad = 0
                                .deduccion = decSueldoSereno * CDec(0.02)
                                decTotalDeduccion = decTotalDeduccion + .deduccion
                                .Guardar()

                            Case 2016
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 2016
                                .nombre_renglon = "Servicios A.M.M.A."
                                '.cantidad = 0
                                .deduccion = CDec(30)
                                decTotalDeduccion = decTotalDeduccion + .deduccion
                                .Guardar()

                            Case 2005
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 2005
                                .nombre_renglon = "U.O.C.R.A. - C.Sindical  2,5%"
                                '.cantidad = 0
                                .deduccion = decTotalHaberSumatoria * CDec(0.025)
                                decTotalDeduccion = decTotalDeduccion + .deduccion
                                .Guardar()

                            Case 2008
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 2008
                                .nombre_renglon = "Obra Social Administ. 3%"
                                '.cantidad = 0
                                .deduccion = decTotalHaberSumatoria * CDec(0.03)
                                decTotalDeduccion = decTotalDeduccion + .deduccion
                                .Guardar()

                            Case 2009
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 2009
                                .nombre_renglon = "Adicional Obra Social 1,50%"
                                '.cantidad = 0
                                .deduccion = decTotalHaberSumatoria * CDec(0.015)
                                decTotalDeduccion = decTotalDeduccion + .deduccion
                                .Guardar()

                                'Case 2013
                                '    .Insertar()
                                '    .id_empleado = idEmp
                                '    .codigo = 2013
                                '    .nombre_renglon = "Contrib. Extraord. U.O.C.RA."
                                '    '.cantidad = 0
                                '    .deduccion = decSueldoSereno
                                '    decTotalDeduccion = decTotalDeduccion + .deduccion
                                '    .Guardar()
                                'Case 2015
                                '    .Insertar()
                                '    .id_empleado = idEmp
                                '    .codigo = 2015
                                '    .nombre_renglon = "Aporte Solidario UOCRA"
                                '    '.cantidad = 0
                                '    .deduccion = decSueldoSereno
                                '    decTotalDeduccion = decTotalDeduccion + .deduccion
                                '    .Guardar()

                            Case 2017
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 2015
                                .nombre_renglon = "Retención por Embargo Judicial"
                                '.cantidad = 0
                                .deduccion = decCantidad * (decValorHora - decValorEmbargo) * CDec(0.1)
                                decTotalDeduccion = decTotalDeduccion + .deduccion
                                .Guardar()
                        End Select

                    End With
                Next




                '**************************
                '      ADICIONALES
                '**************************


                decTotalNetoCobrar = decTotalHaberSumatoria - decTotalDeduccion + decTotalAdicional
                Dim intParteDecimal As Decimal = 0
                ' Dim intParteEntera As Integer = 0
                ' intParteEntera = CInt(decTotalNetoCobrar - Math.Floor(decTotalNetoCobrar))
                intParteDecimal = 1 - decTotalNetoCobrar + Math.Floor(decTotalNetoCobrar)

                If intParteDecimal > CDec(0.5) Then
                    intParteDecimal = intParteDecimal - CDec(0.5)
                End If

                'redondeo
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 10000
                    .nombre_renglon = "Redondeo"
                    '.cantidad = 0
                    .adicional = intParteDecimal
                    decTotalAdicional = decTotalAdicional + .adicional
                    decTotalNetoCobrar = decTotalNetoCobrar + .adicional
                    .Guardar()
                End With



                '**********************
                '   GUARDAR VALORES
                '**********************
                Dim strTotalLetra As String = ""
                strTotalLetra = Numalet.ToCardinal(decTotalNetoCobrar)

                'si existe lo borro
                oTotal_sueldo.DeleteExistenteAguinaldo(idEmp, fecha_inicio, fecha_fin, "W")

                With oTotal_sueldo
                    .Cargar()
                    .Insertar()
                    .total_haber = decTotalHaberSumatoria
                    .total_deduccion = decTotalDeduccion
                    .total_adicional = decTotalAdicional
                    .total_cobrar = .total_haber - .total_deduccion + .total_adicional
                    .fecha = fecha_inicio
                    .id_empleado = idEmp
                    .letra_sueldo = strTotalLetra.ToUpper
                    .periodo = "Licencia Anual/" & fecha_inicio.Year
                    .tipo_sueldo = "W"
                    .Guardar()
                End With
            End If

            oRecibo_sueldo.DeleteLiquidacion("W", idEmp, fecha_inicio.Date, fecha_fin.Date)

            Me.GuardarReciboSueldo(oRecibo_sueldo_temporal.ConsultarTodo, decTotalHaberSumatoria, decTotalDeduccion, decTotalAdicional, fecha_inicio.Date, "W")
            oRecibo_sueldo_temporal.Truncate()
        Next
    End Sub


    Sub AguinaldoAdministrativo(ByVal legajo_desde As Integer, ByVal legajo_hasta As Integer, ByVal fecha_inicio As DateTime, ByVal fecha_fin As DateTime)
        Dim odtEmp As New DataTable
        Dim odtSer As New DataTable
        Dim odtRen As New DataTable

        odtEmp = oEmpleado.GetEntreLegajo(legajo_desde, legajo_hasta)
        odtSer = oSereno.ConsultarTodo
        odtRen = oRenglon.ConsultarTodo
        oRecibo_sueldo_temporal.Cargar()
        oRecibo_sueldo_temporal.Truncate()


        'variables de importes sereno
        Dim decSueldoSereno As Decimal = 0
        Dim decContribucionExtraordinaria As Decimal = 0
        Dim decAporteSolidario As Decimal = 0
        Dim decAyudaEscolar As Decimal = 0
        Dim decValorDiscapacitado As Decimal = 0
        Dim decHoraAdministrativo As Decimal = 0
        Dim decValorEmbargo As Decimal = 0

        'variables de importes empleado
        Dim decValorHora As Decimal = 0
        Dim blCoordinador As Boolean = False
        Dim decHijo As Decimal = 0
        Dim decValorHijo As Decimal = 0
        Dim decSMVM As Decimal = 0
        Dim decAdicionalObraSocial As Decimal = 0
        Dim decHijoDiscapacitado As Decimal = 0
        Dim idEmp As Integer = 0
        Dim idTipoEmpleado As Integer = 0
        Dim decEspecialidad As Decimal = 0
        Dim dtFechaIngreso As DateTime

        'variables de dias tarde
        Dim decDiaTarde As Decimal = 0

        'variables totales
        Dim decTotalHaber As Decimal = 0
        Dim decTotalDeduccion As Decimal = 0
        Dim decTotalAdicional As Decimal = 0
        Dim decTotalNetoCobrar As Decimal = 0
        Dim decHaberEspecialidad As Decimal = 0
        Dim decTotalHaberSumatoria As Decimal = 0

        'set los valores fijos de sueldo
        With odtSer.Rows(0)
            decSueldoSereno = CDec(.Item("sueldo_sereno"))
            decContribucionExtraordinaria = CDec(.Item("contribucion_extraordinaria"))
            decAporteSolidario = CDec(.Item("aporte_solidario"))
            decAyudaEscolar = CDec(.Item("ayuda_escolar"))
            decValorDiscapacitado = CDec(.Item("valor_discapacitado"))
            decHoraAdministrativo = CDec(.Item("hora_administrativo"))
            decValorEmbargo = CDec(.Item("valor_embargo"))
        End With


        'Dim fecha_inicio As DateTime
        'Dim fecha_fin As DateTime

        ''seteo la fecha para la quincena 1
        'fecha_inicio = CDate("01-" & periodo.Month & "-" & periodo.Year)
        'fecha_fin = CDate("15-" & periodo.Month & "-" & periodo.Year)


        'recorro los empleados seleccionados
        For Each rowEmp As DataRow In odtEmp.Rows

            decTotalHaber = 0
            decTotalDeduccion = 0
            decTotalAdicional = 0
            decTotalNetoCobrar = 0
            decHaberEspecialidad = 0
            decTotalHaberSumatoria = 0


            'set los valores del empleado
            idEmp = CInt(rowEmp("id_empleado"))
            idTipoEmpleado = CInt(rowEmp("id_tipo_empleado"))
            decValorHora = CDec(rowEmp("valor_hora"))
            blCoordinador = CBool(rowEmp("coordinador"))
            decHijo = CDec(rowEmp("hijo"))
            decValorHijo = CDec(rowEmp("valor_hijo"))
            decSMVM = CDec(rowEmp("salario_mvm"))
            decAdicionalObraSocial = CDec(rowEmp("adicional_obra_social"))
            decHijoDiscapacitado = CDec(rowEmp("hijo_discapacitado"))
            dtFechaIngreso = CDate(rowEmp("ingreso"))


            'calcular horas cargadas automaticas
            Dim oCalculo As New ClaseHora

            'traigo los datos de las horas automaticas
            oCalculo = Me.CalcularHoraAutomatico(idEmp, fecha_inicio, fecha_fin, False)

            '**************************
            '      HABERES
            '**************************

            'ingreso las horas normales de aguinaldo

            Dim intCantidadMes As Integer = 0
            Dim decSueldoMasAlto As Decimal = 0
            Dim odtTotalEmpleado As New DataTable

            odtTotalEmpleado = oTotal_sueldo.GetAguinaldo(idEmp, fecha_fin)

            For Each rowTot As DataRow In odtTotalEmpleado.Rows
                intCantidadMes = intCantidadMes + 1
                If CDec(rowTot.Item("total_haber")) > decSueldoMasAlto Then
                    decSueldoMasAlto = CDec(rowTot.Item("total_haber"))
                End If
            Next


            With oRecibo_sueldo_temporal
                .Insertar()
                .id_empleado = idEmp
                .codigo = 12
                .nombre_renglon = "Horas Administrativos"
                .cantidad = decSueldoMasAlto
                .haber = decSueldoMasAlto * intCantidadMes / 12
                'calculo del total de haberes
                decTotalHaber = decTotalHaber + .haber
                .Guardar()
            End With



            ''******************************
            ''   HORAS MANUALES
            ''******************************

            Dim odtManual As New DataTable
            odtManual = oMovimiento_manual.GetAllControl(idEmp, fecha_inicio, fecha_fin)
            Dim intCodigoRenglon As Integer = 0
            Dim decCantidad As Decimal = 0
            Dim oCalculoManual As New ClaseHora

            ''traigo los datos de las horas automaticas
            'oCalculoManual = Me.CalcularHoraManual(idEmp, fecha_inicio, fecha_fin)

            'For Each rowManual As DataRow In odtManual.Rows
            '    intCodigoRenglon = CInt(rowManual("codigo"))
            '    decCantidad = CDec(rowManual("cantidad"))

            '    With oRecibo_sueldo_temporal
            '        'si la cantidad es 0 no lo guardo
            '        If decCantidad <> 0 Then
            '            Select Case intCodigoRenglon

            '                'ingreso las horas normales
            '                Case 1
            '                    .Insertar()
            '                    .id_empleado = idEmp
            '                    .codigo = 1
            '                    .nombre_renglon = "Horas Normales"
            '                    .cantidad = oCalculoManual.HoraNormal
            '                    .haber = (oCalculoManual.HoraNormal + oCalculoManual.HoraViaje + oCalculoManual.HoraNocturna) * decValorHora
            '                    'calculo del total de haberes
            '                    decTotalHaber = decTotalHaber + .haber
            '                    .Guardar()

            '                    'ingreso las horas al 50
            '                Case 2

            '                    .Insertar()
            '                    .id_empleado = idEmp
            '                    .codigo = 2
            '                    .nombre_renglon = "Horas al 50%"
            '                    .cantidad = oCalculoManual.Hora50
            '                    .haber = (oCalculoManual.Hora50 + oCalculoManual.HoraViaje50) * decValorHora * CDec(1.5)
            '                    'calculo del total de haberes
            '                    decTotalHaber = decTotalHaber + .haber
            '                    .Guardar()

            '                    'ingreso las horas al 100
            '                Case 3
            '                    .Insertar()
            '                    .id_empleado = idEmp
            '                    .codigo = 3
            '                    .nombre_renglon = "Horas al 100%"
            '                    .cantidad = oCalculoManual.Hora100
            '                    .haber = (oCalculoManual.Hora100 + oCalculoManual.HoraViaje100) * decValorHora * CDec(2)
            '                    'calculo del total de haberes
            '                    decTotalHaber = decTotalHaber + .haber
            '                    .Guardar()


            '                    'ingreso las horas viaje
            '                Case 4
            '                    .Insertar()
            '                    .id_empleado = idEmp
            '                    .codigo = 4
            '                    .nombre_renglon = "30% Sobre Horas Normales"
            '                    .cantidad = oCalculoManual.HoraViaje
            '                    .haber = oCalculoManual.HoraViaje * decValorHora * CDec(0.3)
            '                    'calculo del total de haberes
            '                    decTotalHaber = decTotalHaber + .haber
            '                    .Guardar()


            '                    'ingreso las horas viaje al 50
            '                Case 5
            '                    .Insertar()
            '                    .id_empleado = idEmp
            '                    .codigo = 5
            '                    .nombre_renglon = "30% Sobre Horas al 50%"
            '                    .cantidad = oCalculoManual.HoraViaje50
            '                    .haber = oCalculoManual.HoraViaje50 * decValorHora * CDec(0.3) * CDec(1.5)
            '                    'calculo del total de haberes
            '                    decTotalHaber = decTotalHaber + .haber
            '                    .Guardar()


            '                    'ingreso las horas nocturnas
            '                Case 6
            '                    .Insertar()
            '                    .id_empleado = idEmp
            '                    .codigo = 6
            '                    .nombre_renglon = "Horas Nocturnas"
            '                    .cantidad = oCalculoManual.HoraNocturna
            '                    .haber = oCalculoManual.HoraNocturna * decValorHora * CDec(0.1334)
            '                    'calculo del total de haberes
            '                    decTotalHaber = decTotalHaber + .haber
            '                    .Guardar()


            '                    'ingreso las horas por enfermedad
            '                Case 7
            '                    .Insertar()
            '                    .id_empleado = idEmp
            '                    .codigo = 7
            '                    .nombre_renglon = "Horas por Enfermedad"
            '                    .cantidad = oCalculoManual.HoraEnfermedad
            '                    .haber = oCalculoManual.HoraEnfermedad * decValorHora
            '                    'calculo del total de haberes
            '                    decTotalHaber = decTotalHaber + .haber
            '                    .Guardar()


            '                    'ingreso las horas por accidente
            '                Case 8
            '                    .Insertar()
            '                    .id_empleado = idEmp
            '                    .codigo = 8
            '                    .nombre_renglon = "Horas por Accidente"
            '                    .cantidad = oCalculoManual.HoraAccidente
            '                    .haber = oCalculoManual.HoraAccidente * decValorHora
            '                    'calculo del total de haberes
            '                    decTotalHaber = decTotalHaber + .haber
            '                    .Guardar()


            '                    'ingreso las horas por feriado
            '                Case 9
            '                    .Insertar()
            '                    .id_empleado = idEmp
            '                    .codigo = 9
            '                    .nombre_renglon = "Horas por Feriado"
            '                    .cantidad = oCalculoManual.HoraFeriado
            '                    .haber = oCalculoManual.HoraFeriado * decValorHora
            '                    'calculo del total de haberes
            '                    decTotalHaber = decTotalHaber + .haber
            '                    .Guardar()


            '                    'ingreso las horas por enfermedad
            '                Case 11
            '                    .Insertar()
            '                    .id_empleado = idEmp
            '                    .codigo = 11
            '                    .nombre_renglon = "Horas no Trabajadas"
            '                    .cantidad = oCalculoManual.HoraNoTrabajada
            '                    .haber = oCalculoManual.HoraNoTrabajada * decValorHora
            '                    'calculo del total de haberes
            '                    decTotalHaber = decTotalHaber + .haber


            '                    'ingreso las horas viaje al 100
            '                Case 22
            '                    .Insertar()
            '                    .id_empleado = idEmp
            '                    .codigo = 22
            '                    .nombre_renglon = "30% Sobre Horas al 100%"
            '                    .cantidad = oCalculoManual.HoraViaje100
            '                    .haber = oCalculoManual.HoraViaje100 * decValorHora * CDec(0.3) * CDec(2)
            '                    'calculo del total de haberes
            '                    decTotalHaber = decTotalHaber + .haber
            '                    .Guardar()
            '            End Select
            '        End If
            '    End With
            'Next


            'si hay haberes continuar sino saltar
            If decTotalHaber > 0 Then

                '******************************************
                '   PRESENTISMO - ANTIGUEDAD - ESPECIALIDAD
                '******************************************

                ''ingreso las horas presentismo
                'Dim odtTarde As New DataTable
                'odtTarde = oDia_tarde.GetAllControl(idEmp, fecha_inicio, fecha_fin)
                'decDiaTarde = CDec(odtTarde.Rows(0).Item("cantidad_dia_tarde"))

                'With oRecibo_sueldo_temporal
                '    .Insertar()
                '    .id_empleado = idEmp
                '    .codigo = 25
                '    .nombre_renglon = "Presentismo"
                '    '.cantidad = oCalculo.HoraViaje100
                '    .haber = decTotalHaber * (CDec(0.0833) - (decDiaTarde * CDec(0.00833)))
                '    decTotalHaberSumatoria = decTotalHaber + .haber
                '    .Guardar()
                'End With

                ''ingreso de la especialidad
                'Dim odtEsp As New DataTable
                'odtEsp = oTipo_Empleado.GetOne(idTipoEmpleado)
                'decEspecialidad = CDec(odtEsp.Rows(0).Item("porcentaje"))

                'With oRecibo_sueldo_temporal
                '    .Insertar()
                '    .id_empleado = idEmp
                '    .codigo = 26
                '    .nombre_renglon = "Especialidad"
                '    '.cantidad = oCalculo.HoraViaje100
                '    .haber = decTotalHaber * decEspecialidad / 100
                '    decHaberEspecialidad = .haber
                '    decTotalHaberSumatoria = decTotalHaberSumatoria + .haber
                '    .Guardar()
                'End With

                ''ingreso de la antigüedad
                'Dim intAntiguedad As Integer = 0
                'intAntiguedad = CInt(DateDiff(DateInterval.Year, dtFechaIngreso, fecha_fin))

                'If intAntiguedad > 0 Then
                '    With oRecibo_sueldo_temporal
                '        .Insertar()
                '        .id_empleado = idEmp
                '        .codigo = 27
                '        .nombre_renglon = "Antigüedad"
                '        .cantidad = intAntiguedad
                '        .haber = CDec(intAntiguedad / 100 * (decTotalHaber + decHaberEspecialidad))
                '        decTotalHaberSumatoria = decTotalHaberSumatoria + .haber
                '        .Guardar()
                '    End With
                'End If




                '**************************
                '      DEDUCCIONES
                '**************************

                'ingreso de la jubilacion
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 2000
                    .nombre_renglon = "Jubilación  11 %"
                    '.cantidad = 0
                    .deduccion = decTotalHaberSumatoria * CDec(0.11)
                    decTotalDeduccion = decTotalDeduccion + .deduccion
                    .Guardar()
                End With

                'ingreso del INSSJP
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 2001
                    .nombre_renglon = "I.N.S.S.J.P  3%"
                    '.cantidad = 0
                    .deduccion = decTotalHaberSumatoria * CDec(0.03)
                    decTotalDeduccion = decTotalDeduccion + .deduccion
                    .Guardar()
                End With

                ''ingreso de la obra social
                'With oRecibo_sueldo_temporal
                '    .Insertar()
                '    .id_empleado = idEmp
                '    .codigo = 2002
                '    .nombre_renglon = "Obra Social  2,25%"
                '    '.cantidad = 0
                '    .deduccion = decTotalHaberSumatoria * CDec(0.0225)
                '    decTotalDeduccion = decTotalDeduccion + .deduccion
                '    .Guardar()
                'End With

                ''ingreso del ISSPIC
                'With oRecibo_sueldo_temporal
                '    .Insertar()
                '    .id_empleado = idEmp
                '    .codigo = 2003
                '    .nombre_renglon = "I.S.S.P.I.C.  0,45%"
                '    '.cantidad = 0
                '    .deduccion = decTotalHaberSumatoria * CDec(0.0045)
                '    decTotalDeduccion = decTotalDeduccion + .deduccion
                '    .Guardar()
                'End With

                'ingreso del ANSSAL
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 2004
                    .nombre_renglon = "ANSSAL  0,30%"
                    '.cantidad = 0
                    .deduccion = decTotalHaberSumatoria * CDec(0.003)
                    decTotalDeduccion = decTotalDeduccion + .deduccion
                    .Guardar()
                End With

                'ingreso del ANSSAL
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 2008
                    .nombre_renglon = "Obra Social Administ. 3% "
                    '.cantidad = 0
                    .deduccion = decTotalHaberSumatoria * CDec(0.03)
                    decTotalDeduccion = decTotalDeduccion + .deduccion
                    .Guardar()
                End With


                '****************************
                '   HORAS MANUALES RESTO
                '****************************

                'Dim odtManualResto As New DataTable
                'odtManual = oMovimiento_manual.GetAllControl(idEmp, fecha_inicio, fecha_fin)

                'For Each rowManual As DataRow In odtManual.Rows
                '    intCodigoRenglon = CInt(rowManual("codigo"))
                '    decCantidad = CDec(rowManual("cantidad"))

                '    With oRecibo_sueldo_temporal

                '        Select Case intCodigoRenglon
                '            Case 2007
                '                .Insertar()
                '                .id_empleado = idEmp
                '                .codigo = 2007
                '                .nombre_renglon = "U.O.C.R.A. - Seguros"
                '                '.cantidad = 0
                '                .deduccion = decSueldoSereno * CDec(0.02)
                '                decTotalDeduccion = decTotalDeduccion + .deduccion
                '                .Guardar()

                '            Case 2016
                '                .Insertar()
                '                .id_empleado = idEmp
                '                .codigo = 2016
                '                .nombre_renglon = "Servicios A.M.M.A."
                '                '.cantidad = 0
                '                .deduccion = CDec(30)
                '                decTotalDeduccion = decTotalDeduccion + .deduccion
                '                .Guardar()

                '            Case 2005
                '                .Insertar()
                '                .id_empleado = idEmp
                '                .codigo = 2005
                '                .nombre_renglon = "U.O.C.R.A. - C.Sindical  2,5%"
                '                '.cantidad = 0
                '                .deduccion = decTotalHaberSumatoria * CDec(0.025)
                '                decTotalDeduccion = decTotalDeduccion + .deduccion
                '                .Guardar()

                '            Case 2008
                '                .Insertar()
                '                .id_empleado = idEmp
                '                .codigo = 2008
                '                .nombre_renglon = "Obra Social Administ. 3%"
                '                '.cantidad = 0
                '                .deduccion = decTotalHaberSumatoria * CDec(0.03)
                '                decTotalDeduccion = decTotalDeduccion + .deduccion
                '                .Guardar()

                '            Case 2009
                '                .Insertar()
                '                .id_empleado = idEmp
                '                .codigo = 2009
                '                .nombre_renglon = "Adicional Obra Social 1,50%"
                '                '.cantidad = 0
                '                .deduccion = decTotalHaberSumatoria * CDec(0.015)
                '                decTotalDeduccion = decTotalDeduccion + .deduccion
                '                .Guardar()

                '                'Case 2013
                '                '    .Insertar()
                '                '    .id_empleado = idEmp
                '                '    .codigo = 2013
                '                '    .nombre_renglon = "Contrib. Extraord. U.O.C.RA."
                '                '    '.cantidad = 0
                '                '    .deduccion = decSueldoSereno
                '                '    decTotalDeduccion = decTotalDeduccion + .deduccion
                '                '    .Guardar()
                '                'Case 2015
                '                '    .Insertar()
                '                '    .id_empleado = idEmp
                '                '    .codigo = 2015
                '                '    .nombre_renglon = "Aporte Solidario UOCRA"
                '                '    '.cantidad = 0
                '                '    .deduccion = decSueldoSereno
                '                '    decTotalDeduccion = decTotalDeduccion + .deduccion
                '                '    .Guardar()

                '            Case 2017
                '                .Insertar()
                '                .id_empleado = idEmp
                '                .codigo = 2015
                '                .nombre_renglon = "Retención por Embargo Judicial"
                '                '.cantidad = 0
                '                .deduccion = decCantidad * (decValorHora - decValorEmbargo) * CDec(0.1)
                '                decTotalDeduccion = decTotalDeduccion + .deduccion
                '                .Guardar()
                '        End Select

                '    End With
                'Next




                '**************************
                '      ADICIONALES
                '**************************


                decTotalNetoCobrar = decTotalHaberSumatoria - decTotalDeduccion + decTotalAdicional
                Dim intParteDecimal As Decimal = 0
                ' Dim intParteEntera As Integer = 0
                ' intParteEntera = CInt(decTotalNetoCobrar - Math.Floor(decTotalNetoCobrar))
                intParteDecimal = 1 - decTotalNetoCobrar + Math.Floor(decTotalNetoCobrar)

                If intParteDecimal > CDec(0.5) Then
                    intParteDecimal = intParteDecimal - CDec(0.5)
                End If

                'redondeo
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 10000
                    .nombre_renglon = "Redondeo"
                    '.cantidad = 0
                    .adicional = intParteDecimal
                    decTotalAdicional = decTotalAdicional + .adicional
                    decTotalNetoCobrar = decTotalNetoCobrar + .adicional
                    .Guardar()
                End With



                '**********************
                '   GUARDAR VALORES
                '**********************
                Dim strTotalLetra As String = ""
                strTotalLetra = Numalet.ToCardinal(decTotalNetoCobrar)

                'si existe lo borro
                oTotal_sueldo.DeleteExistenteAguinaldo(idEmp, fecha_inicio, fecha_fin, "B")

                With oTotal_sueldo
                    .Cargar()
                    .Insertar()
                    .total_haber = decTotalHaberSumatoria
                    .total_deduccion = decTotalDeduccion
                    .total_adicional = decTotalAdicional
                    .total_cobrar = .total_haber - .total_deduccion + .total_adicional
                    .fecha = fecha_inicio
                    .id_empleado = idEmp
                    .letra_sueldo = strTotalLetra.ToUpper
                    Select Case fecha_fin.Month
                        Case 1, 2, 3, 4, 5, 6
                            .periodo = "S.A.C - 1º Semestre/" & fecha_fin.Year
                        Case 7, 8, 9, 10, 11, 12
                            .periodo = "S.A.C - 2º Semestre/" & fecha_fin.Year
                    End Select
                    .tipo_sueldo = "B"
                    .Guardar()
                End With
            End If

            oRecibo_sueldo.DeleteLiquidacion("B", idEmp, fecha_inicio.Date, fecha_fin.Date)

            Me.GuardarReciboSueldo(oRecibo_sueldo_temporal.ConsultarTodo, decTotalHaberSumatoria, decTotalDeduccion, decTotalAdicional, fecha_inicio.Date, "B")
            oRecibo_sueldo_temporal.Truncate()
        Next
    End Sub


    Sub AguinaldoEmpleado(ByVal legajo_desde As Integer, ByVal legajo_hasta As Integer, ByVal fecha_inicio As DateTime, ByVal fecha_fin As DateTime)
        Dim odtEmp As New DataTable
        Dim odtSer As New DataTable
        Dim odtRen As New DataTable

        odtEmp = oEmpleado.GetEntreLegajo(legajo_desde, legajo_hasta)
        odtSer = oSereno.ConsultarTodo
        odtRen = oRenglon.ConsultarTodo
        oRecibo_sueldo_temporal.Cargar()
        oRecibo_sueldo_temporal.Truncate()


        'variables de importes sereno
        Dim decSueldoSereno As Decimal = 0
        Dim decContribucionExtraordinaria As Decimal = 0
        Dim decAporteSolidario As Decimal = 0
        Dim decAyudaEscolar As Decimal = 0
        Dim decValorDiscapacitado As Decimal = 0
        Dim decHoraAdministrativo As Decimal = 0
        Dim decValorEmbargo As Decimal = 0

        'variables de importes empleado
        Dim decValorHora As Decimal = 0
        Dim blCoordinador As Boolean = False
        Dim decHijo As Decimal = 0
        Dim decValorHijo As Decimal = 0
        Dim decSMVM As Decimal = 0
        Dim decAdicionalObraSocial As Decimal = 0
        Dim decHijoDiscapacitado As Decimal = 0
        Dim idEmp As Integer = 0
        Dim idTipoEmpleado As Integer = 0
        Dim decEspecialidad As Decimal = 0
        Dim dtFechaIngreso As DateTime

        'variables de dias tarde
        Dim decDiaTarde As Decimal = 0

        'variables totales
        Dim decTotalHaber As Decimal = 0
        Dim decTotalDeduccion As Decimal = 0
        Dim decTotalAdicional As Decimal = 0
        Dim decTotalNetoCobrar As Decimal = 0
        Dim decHaberEspecialidad As Decimal = 0
        Dim decTotalHaberSumatoria As Decimal = 0

        'set los valores fijos de sueldo
        With odtSer.Rows(0)
            decSueldoSereno = CDec(.Item("sueldo_sereno"))
            decContribucionExtraordinaria = CDec(.Item("contribucion_extraordinaria"))
            decAporteSolidario = CDec(.Item("aporte_solidario"))
            decAyudaEscolar = CDec(.Item("ayuda_escolar"))
            decValorDiscapacitado = CDec(.Item("valor_discapacitado"))
            decHoraAdministrativo = CDec(.Item("hora_administrativo"))
            decValorEmbargo = CDec(.Item("valor_embargo"))
        End With


        'Dim fecha_inicio As DateTime
        'Dim fecha_fin As DateTime

        ''seteo la fecha para la quincena 1
        'fecha_inicio = CDate("01-" & periodo.Month & "-" & periodo.Year)
        'fecha_fin = CDate("15-" & periodo.Month & "-" & periodo.Year)


        'recorro los empleados seleccionados
        For Each rowEmp As DataRow In odtEmp.Rows

            decTotalHaber = 0
            decTotalDeduccion = 0
            decTotalAdicional = 0
            decTotalNetoCobrar = 0
            decHaberEspecialidad = 0
            decTotalHaberSumatoria = 0


            'set los valores del empleado
            idEmp = CInt(rowEmp("id_empleado"))
            idTipoEmpleado = CInt(rowEmp("id_tipo_empleado"))
            decValorHora = CDec(rowEmp("valor_hora"))
            blCoordinador = CBool(rowEmp("coordinador"))
            decHijo = CDec(rowEmp("hijo"))
            decValorHijo = CDec(rowEmp("valor_hijo"))
            decSMVM = CDec(rowEmp("salario_mvm"))
            decAdicionalObraSocial = CDec(rowEmp("adicional_obra_social"))
            decHijoDiscapacitado = CDec(rowEmp("hijo_discapacitado"))
            dtFechaIngreso = CDate(rowEmp("ingreso"))


            'calcular horas cargadas automaticas
            Dim oCalculo As New ClaseHora

            'traigo los datos de las horas automaticas
            oCalculo = Me.CalcularHoraAutomatico(idEmp, fecha_inicio, fecha_fin, False)

            '**************************
            '      HABERES
            '**************************

            'ingreso las horas normales de aguinaldo

            Dim intCantidadMes As Integer = 0
            Dim decSueldoMasAlto As Decimal = 0
            Dim odtTotalEmpleado As New DataTable

            odtTotalEmpleado = oTotal_sueldo.GetAguinaldo(idEmp, fecha_fin)

            For Each rowTot As DataRow In odtTotalEmpleado.Rows
                intCantidadMes = intCantidadMes + 1
                If CDec(rowTot.Item("total_haber")) > decSueldoMasAlto Then
                    decSueldoMasAlto = CDec(rowTot.Item("total_haber"))
                End If
            Next

            'ingreso las horas normales
            If oCalculo.HoraNormal <> 0 Then
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 14
                    .nombre_renglon = "Sdo. Anual Complementario"
                    .cantidad = decSueldoMasAlto
                    .haber = decSueldoMasAlto * intCantidadMes / 12
                    'calculo del total de haberes
                    decTotalHaber = decTotalHaber + .haber
                    .Guardar()
                End With
            End If

            ''ingreso las horas al 50
            'If oCalculo.Hora50 <> 0 Then
            '    With oRecibo_sueldo_temporal
            '        .Insertar()
            '        .id_empleado = idEmp
            '        .codigo = 2
            '        .nombre_renglon = "Horas al 50%"
            '        .cantidad = oCalculo.Hora50
            '        .haber = (oCalculo.Hora50 + oCalculo.HoraViaje50) * decValorHora * CDec(1.5)
            '        'calculo del total de haberes
            '        decTotalHaber = decTotalHaber + .haber
            '        .Guardar()
            '    End With
            'End If

            ''ingreso las horas al 100
            'If oCalculo.Hora100 <> 0 Then
            '    With oRecibo_sueldo_temporal
            '        .Insertar()
            '        .id_empleado = idEmp
            '        .codigo = 3
            '        .nombre_renglon = "Horas al 100%"
            '        .cantidad = oCalculo.Hora100
            '        .haber = (oCalculo.Hora100 + oCalculo.HoraViaje100) * decValorHora * CDec(2)
            '        'calculo del total de haberes
            '        decTotalHaber = decTotalHaber + .haber
            '        .Guardar()
            '    End With
            'End If

            ''ingreso las horas viaje
            'If oCalculo.HoraViaje <> 0 Then
            '    With oRecibo_sueldo_temporal
            '        .Insertar()
            '        .id_empleado = idEmp
            '        .codigo = 4
            '        .nombre_renglon = "30% Sobre Horas Normales"
            '        .cantidad = oCalculo.HoraViaje
            '        .haber = oCalculo.HoraViaje * decValorHora * CDec(0.3)
            '        'calculo del total de haberes
            '        decTotalHaber = decTotalHaber + .haber
            '        .Guardar()
            '    End With
            'End If

            ''ingreso las horas viaje al 50
            'If oCalculo.HoraViaje50 <> 0 Then
            '    With oRecibo_sueldo_temporal
            '        .Insertar()
            '        .id_empleado = idEmp
            '        .codigo = 5
            '        .nombre_renglon = "30% Sobre Horas al 50%"
            '        .cantidad = oCalculo.HoraViaje50
            '        .haber = oCalculo.HoraViaje50 * decValorHora * CDec(0.3) * CDec(1.5)
            '        'calculo del total de haberes
            '        decTotalHaber = decTotalHaber + .haber
            '        .Guardar()
            '    End With
            'End If

            ''ingreso las horas nocturnas
            'If oCalculo.HoraNocturna <> 0 Then
            '    With oRecibo_sueldo_temporal
            '        .Insertar()
            '        .id_empleado = idEmp
            '        .codigo = 6
            '        .nombre_renglon = "Horas Nocturnas"
            '        .cantidad = oCalculo.HoraNocturna
            '        .haber = oCalculo.HoraNocturna * decValorHora * CDec(0.1334)
            '        'calculo del total de haberes
            '        decTotalHaber = decTotalHaber + .haber
            '        .Guardar()
            '    End With
            'End If

            ''ingreso las horas por enfermedad
            'If oCalculo.HoraEnfermedad <> 0 Then
            '    With oRecibo_sueldo_temporal
            '        .Insertar()
            '        .id_empleado = idEmp
            '        .codigo = 7
            '        .nombre_renglon = "Horas por Enfermedad"
            '        .cantidad = oCalculo.HoraEnfermedad
            '        .haber = oCalculo.HoraEnfermedad * decValorHora
            '        'calculo del total de haberes
            '        decTotalHaber = decTotalHaber + .haber
            '        .Guardar()
            '    End With
            'End If

            ''ingreso las horas por accidente
            'If oCalculo.HoraAccidente <> 0 Then
            '    With oRecibo_sueldo_temporal
            '        .Insertar()
            '        .id_empleado = idEmp
            '        .codigo = 8
            '        .nombre_renglon = "Horas por Accidente"
            '        .cantidad = oCalculo.HoraAccidente
            '        .haber = oCalculo.HoraAccidente * decValorHora
            '        'calculo del total de haberes
            '        decTotalHaber = decTotalHaber + .haber
            '        .Guardar()
            '    End With
            'End If

            ''ingreso las horas por feriado
            'If oCalculo.HoraFeriado <> 0 Then
            '    With oRecibo_sueldo_temporal
            '        .Insertar()
            '        .id_empleado = idEmp
            '        .codigo = 9
            '        .nombre_renglon = "Horas por Feriado"
            '        .cantidad = oCalculo.HoraFeriado
            '        .haber = oCalculo.HoraFeriado * decValorHora
            '        'calculo del total de haberes
            '        decTotalHaber = decTotalHaber + .haber
            '        .Guardar()
            '    End With
            'End If



            ''ingreso las horas por enfermedad
            'If oCalculo.HoraNoTrabajada <> 0 Then
            '    With oRecibo_sueldo_temporal
            '        .Insertar()
            '        .id_empleado = idEmp
            '        .codigo = 11
            '        .nombre_renglon = "Horas no Trabajadas"
            '        .cantidad = oCalculo.HoraNoTrabajada
            '        .haber = oCalculo.HoraNoTrabajada * decValorHora
            '        'calculo del total de haberes
            '        decTotalHaber = decTotalHaber + .haber
            '        .Guardar()
            '    End With
            'End If

            ''ingreso las horas viaje al 100
            'If oCalculo.HoraViaje100 <> 0 Then
            '    With oRecibo_sueldo_temporal
            '        .Insertar()
            '        .id_empleado = idEmp
            '        .codigo = 22
            '        .nombre_renglon = "30% Sobre Horas al 100%"
            '        .cantidad = oCalculo.HoraViaje100
            '        .haber = oCalculo.HoraViaje100 * decValorHora * CDec(0.3) * CDec(2)
            '        'calculo del total de haberes
            '        decTotalHaber = decTotalHaber + .haber
            '        .Guardar()
            '    End With
            'End If


            ''******************************
            ''   HORAS MANUALES
            ''******************************

            'Dim odtManual As New DataTable
            'odtManual = oMovimiento_manual.GetAllControl(idEmp, fecha_inicio, fecha_fin)
            'Dim intCodigoRenglon As Integer = 0
            'Dim decCantidad As Decimal = 0
            'Dim oCalculoManual As New ClaseHora

            ''traigo los datos de las horas automaticas
            'oCalculoManual = Me.CalcularHoraManual(idEmp, fecha_inicio, fecha_fin)

            'For Each rowManual As DataRow In odtManual.Rows
            '    intCodigoRenglon = CInt(rowManual("codigo"))
            '    decCantidad = CDec(rowManual("cantidad"))

            '    With oRecibo_sueldo_temporal
            '        'si la cantidad es 0 no lo guardo
            '        If decCantidad <> 0 Then
            '            Select Case intCodigoRenglon

            '                'ingreso las horas normales
            '                Case 1
            '                    .Insertar()
            '                    .id_empleado = idEmp
            '                    .codigo = 1
            '                    .nombre_renglon = "Horas Normales"
            '                    .cantidad = oCalculoManual.HoraNormal
            '                    .haber = (oCalculoManual.HoraNormal + oCalculoManual.HoraViaje + oCalculoManual.HoraNocturna) * decValorHora
            '                    'calculo del total de haberes
            '                    decTotalHaber = decTotalHaber + .haber
            '                    .Guardar()

            '                    'ingreso las horas al 50
            '                Case 2

            '                    .Insertar()
            '                    .id_empleado = idEmp
            '                    .codigo = 2
            '                    .nombre_renglon = "Horas al 50%"
            '                    .cantidad = oCalculoManual.Hora50
            '                    .haber = (oCalculoManual.Hora50 + oCalculoManual.HoraViaje50) * decValorHora * CDec(1.5)
            '                    'calculo del total de haberes
            '                    decTotalHaber = decTotalHaber + .haber
            '                    .Guardar()

            '                    'ingreso las horas al 100
            '                Case 3
            '                    .Insertar()
            '                    .id_empleado = idEmp
            '                    .codigo = 3
            '                    .nombre_renglon = "Horas al 100%"
            '                    .cantidad = oCalculoManual.Hora100
            '                    .haber = (oCalculoManual.Hora100 + oCalculoManual.HoraViaje100) * decValorHora * CDec(2)
            '                    'calculo del total de haberes
            '                    decTotalHaber = decTotalHaber + .haber
            '                    .Guardar()


            '                    'ingreso las horas viaje
            '                Case 4
            '                    .Insertar()
            '                    .id_empleado = idEmp
            '                    .codigo = 4
            '                    .nombre_renglon = "30% Sobre Horas Normales"
            '                    .cantidad = oCalculoManual.HoraViaje
            '                    .haber = oCalculoManual.HoraViaje * decValorHora * CDec(0.3)
            '                    'calculo del total de haberes
            '                    decTotalHaber = decTotalHaber + .haber
            '                    .Guardar()


            '                    'ingreso las horas viaje al 50
            '                Case 5
            '                    .Insertar()
            '                    .id_empleado = idEmp
            '                    .codigo = 5
            '                    .nombre_renglon = "30% Sobre Horas al 50%"
            '                    .cantidad = oCalculoManual.HoraViaje50
            '                    .haber = oCalculoManual.HoraViaje50 * decValorHora * CDec(0.3) * CDec(1.5)
            '                    'calculo del total de haberes
            '                    decTotalHaber = decTotalHaber + .haber
            '                    .Guardar()


            '                    'ingreso las horas nocturnas
            '                Case 6
            '                    .Insertar()
            '                    .id_empleado = idEmp
            '                    .codigo = 6
            '                    .nombre_renglon = "Horas Nocturnas"
            '                    .cantidad = oCalculoManual.HoraNocturna
            '                    .haber = oCalculoManual.HoraNocturna * decValorHora * CDec(0.1334)
            '                    'calculo del total de haberes
            '                    decTotalHaber = decTotalHaber + .haber
            '                    .Guardar()


            '                    'ingreso las horas por enfermedad
            '                Case 7
            '                    .Insertar()
            '                    .id_empleado = idEmp
            '                    .codigo = 7
            '                    .nombre_renglon = "Horas por Enfermedad"
            '                    .cantidad = oCalculoManual.HoraEnfermedad
            '                    .haber = oCalculoManual.HoraEnfermedad * decValorHora
            '                    'calculo del total de haberes
            '                    decTotalHaber = decTotalHaber + .haber
            '                    .Guardar()


            '                    'ingreso las horas por accidente
            '                Case 8
            '                    .Insertar()
            '                    .id_empleado = idEmp
            '                    .codigo = 8
            '                    .nombre_renglon = "Horas por Accidente"
            '                    .cantidad = oCalculoManual.HoraAccidente
            '                    .haber = oCalculoManual.HoraAccidente * decValorHora
            '                    'calculo del total de haberes
            '                    decTotalHaber = decTotalHaber + .haber
            '                    .Guardar()


            '                    'ingreso las horas por feriado
            '                Case 9
            '                    .Insertar()
            '                    .id_empleado = idEmp
            '                    .codigo = 9
            '                    .nombre_renglon = "Horas por Feriado"
            '                    .cantidad = oCalculoManual.HoraFeriado
            '                    .haber = oCalculoManual.HoraFeriado * decValorHora
            '                    'calculo del total de haberes
            '                    decTotalHaber = decTotalHaber + .haber
            '                    .Guardar()


            '                    'ingreso las horas por enfermedad
            '                Case 11
            '                    .Insertar()
            '                    .id_empleado = idEmp
            '                    .codigo = 11
            '                    .nombre_renglon = "Horas no Trabajadas"
            '                    .cantidad = oCalculoManual.HoraNoTrabajada
            '                    .haber = oCalculoManual.HoraNoTrabajada * decValorHora
            '                    'calculo del total de haberes
            '                    decTotalHaber = decTotalHaber + .haber


            '                    'ingreso las horas viaje al 100
            '                Case 22
            '                    .Insertar()
            '                    .id_empleado = idEmp
            '                    .codigo = 22
            '                    .nombre_renglon = "30% Sobre Horas al 100%"
            '                    .cantidad = oCalculoManual.HoraViaje100
            '                    .haber = oCalculoManual.HoraViaje100 * decValorHora * CDec(0.3) * CDec(2)
            '                    'calculo del total de haberes
            '                    decTotalHaber = decTotalHaber + .haber
            '                    .Guardar()
            '            End Select
            '        End If
            '    End With
            'Next


            ''si hay haberes continuar sino saltar
            If decTotalHaber > 0 Then

                '    '******************************************
                '    '   PRESENTISMO - ANTIGUEDAD - ESPECIALIDAD
                '    '******************************************

                '    'ingreso las horas presentismo
                '    Dim odtTarde As New DataTable
                '    odtTarde = oDia_tarde.GetAllControl(idEmp, fecha_inicio, fecha_fin)
                '    decDiaTarde = CDec(odtTarde.Rows(0).Item("cantidad_dia_tarde"))

                '    With oRecibo_sueldo_temporal
                '        .Insertar()
                '        .id_empleado = idEmp
                '        .codigo = 25
                '        .nombre_renglon = "Presentismo"
                '        '.cantidad = oCalculo.HoraViaje100
                '        .haber = decTotalHaber * (CDec(0.2) - (decDiaTarde * CDec(0.02)))
                '        decTotalHaberSumatoria = decTotalHaber + .haber
                '        .Guardar()
                '    End With

                '    'ingreso de la especialidad
                '    Dim odtEsp As New DataTable
                '    odtEsp = oTipo_Empleado.GetOne(idTipoEmpleado)
                '    decEspecialidad = CDec(odtEsp.Rows(0).Item("porcentaje"))

                '    With oRecibo_sueldo_temporal
                '        .Insertar()
                '        .id_empleado = idEmp
                '        .codigo = 26
                '        .nombre_renglon = "Especialidad"
                '        '.cantidad = oCalculo.HoraViaje100
                '        .haber = decTotalHaber * decEspecialidad / 100
                '        decHaberEspecialidad = .haber
                '        decTotalHaberSumatoria = decTotalHaberSumatoria + .haber
                '        .Guardar()
                '    End With

                '    'ingreso de la antigüedad
                '    Dim intAntiguedad As Integer = 0
                '    Dim decAntiguedad As Decimal = 0
                '    'intAntiguedad = CInt(DateDiff(DateInterval.Year, dtFechaIngreso, fecha_fin))
                '    decAntiguedad = DateDiff(DateInterval.DayOfYear, dtFechaIngreso, fecha_fin) / CDec(365)
                '    intAntiguedad = CInt(System.Math.Truncate(decAntiguedad))

                '    If intAntiguedad > 0 Then
                '        With oRecibo_sueldo_temporal
                '            .Insertar()
                '            .id_empleado = idEmp
                '            .codigo = 27
                '            .nombre_renglon = "Antigüedad"
                '            .cantidad = intAntiguedad
                '            .haber = CDec(intAntiguedad / 100 * (decTotalHaber + decHaberEspecialidad))
                '            decTotalHaberSumatoria = decTotalHaberSumatoria + .haber
                '            .Guardar()
                '        End With
                '    End If




                '**************************
                '      DEDUCCIONES
                '**************************

                'ingreso de la jubilacion
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 2000
                    .nombre_renglon = "Jubilación  11 %"
                    '.cantidad = 0
                    .deduccion = decTotalHaberSumatoria * CDec(0.11)
                    decTotalDeduccion = decTotalDeduccion + .deduccion
                    .Guardar()
                End With

                'ingreso del INSSJP
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 2001
                    .nombre_renglon = "I.N.S.S.J.P  3%"
                    '.cantidad = 0
                    .deduccion = decTotalHaberSumatoria * CDec(0.03)
                    decTotalDeduccion = decTotalDeduccion + .deduccion
                    .Guardar()
                End With

                'ingreso de la obra social
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 2002
                    .nombre_renglon = "Obra Social  2,25%"
                    '.cantidad = 0
                    .deduccion = decTotalHaberSumatoria * CDec(0.0225)
                    decTotalDeduccion = decTotalDeduccion + .deduccion
                    .Guardar()
                End With

                'ingreso del ISSPIC
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 2003
                    .nombre_renglon = "I.S.S.P.I.C.  0,45%"
                    '.cantidad = 0
                    .deduccion = decTotalHaberSumatoria * CDec(0.0045)
                    decTotalDeduccion = decTotalDeduccion + .deduccion
                    .Guardar()
                End With

                'ingreso del ANSSAL
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 2004
                    .nombre_renglon = "ANSSAL  0,30%"
                    '.cantidad = 0
                    .deduccion = decTotalHaberSumatoria * CDec(0.003)
                    decTotalDeduccion = decTotalDeduccion + .deduccion
                    .Guardar()
                End With




                '****************************
                '   HORAS MANUALES RESTO
                '****************************

                'Dim odtManualResto As New DataTable
                'odtManual = oMovimiento_manual.GetAllControl(idEmp, fecha_inicio, fecha_fin)

                'For Each rowManual As DataRow In odtManual.Rows
                '    intCodigoRenglon = CInt(rowManual("codigo"))
                '    decCantidad = CDec(rowManual("cantidad"))

                '    With oRecibo_sueldo_temporal

                '        Select Case intCodigoRenglon
                '            Case 2007
                '                .Insertar()
                '                .id_empleado = idEmp
                '                .codigo = 2007
                '                .nombre_renglon = "U.O.C.R.A. - Seguros"
                '                '.cantidad = 0
                '                .deduccion = decSueldoSereno * CDec(0.02)
                '                decTotalDeduccion = decTotalDeduccion + .deduccion
                '                .Guardar()

                '            Case 2016
                '                .Insertar()
                '                .id_empleado = idEmp
                '                .codigo = 2016
                '                .nombre_renglon = "Servicios A.M.M.A."
                '                '.cantidad = 0
                '                .deduccion = CDec(30)
                '                decTotalDeduccion = decTotalDeduccion + .deduccion
                '                .Guardar()

                '            Case 2005
                '                .Insertar()
                '                .id_empleado = idEmp
                '                .codigo = 2005
                '                .nombre_renglon = "U.O.C.R.A. - C.Sindical  2,5%"
                '                '.cantidad = 0
                '                .deduccion = decTotalHaberSumatoria * CDec(0.025)
                '                decTotalDeduccion = decTotalDeduccion + .deduccion
                '                .Guardar()

                '            Case 2008
                '                .Insertar()
                '                .id_empleado = idEmp
                '                .codigo = 2008
                '                .nombre_renglon = "Obra Social Administ. 3%"
                '                '.cantidad = 0
                '                .deduccion = decTotalHaberSumatoria * CDec(0.03)
                '                decTotalDeduccion = decTotalDeduccion + .deduccion
                '                .Guardar()

                '            Case 2009
                '                .Insertar()
                '                .id_empleado = idEmp
                '                .codigo = 2009
                '                .nombre_renglon = "Adicional Obra Social 1,50%"
                '                '.cantidad = 0
                '                .deduccion = decTotalHaberSumatoria * CDec(0.015)
                '                decTotalDeduccion = decTotalDeduccion + .deduccion
                '                .Guardar()

                '                'Case 2013
                '                '    .Insertar()
                '                '    .id_empleado = idEmp
                '                '    .codigo = 2013
                '                '    .nombre_renglon = "Contrib. Extraord. U.O.C.RA."
                '                '    '.cantidad = 0
                '                '    .deduccion = decSueldoSereno
                '                '    decTotalDeduccion = decTotalDeduccion + .deduccion
                '                '    .Guardar()
                '                'Case 2015
                '                '    .Insertar()
                '                '    .id_empleado = idEmp
                '                '    .codigo = 2015
                '                '    .nombre_renglon = "Aporte Solidario UOCRA"
                '                '    '.cantidad = 0
                '                '    .deduccion = decSueldoSereno
                '                '    decTotalDeduccion = decTotalDeduccion + .deduccion
                '                '    .Guardar()

                '            Case 2017
                '                .Insertar()
                '                .id_empleado = idEmp
                '                .codigo = 2015
                '                .nombre_renglon = "Retención por Embargo Judicial"
                '                '.cantidad = 0
                '                .deduccion = decCantidad * (decValorHora - decValorEmbargo) * CDec(0.1)
                '                decTotalDeduccion = decTotalDeduccion + .deduccion
                '                .Guardar()

                '            Case 2019
                '                .Insertar()
                '                .id_empleado = idEmp
                '                .codigo = 2019
                '                .nombre_renglon = "Res. 2032/10 - Obra Social"
                '                .cantidad = 1
                '                .deduccion = CDec(300) * CDec(0.0225)
                '                decTotalDeduccion = decTotalDeduccion + .deduccion
                '                .Guardar()

                '            Case 3018
                '                .Insertar()
                '                .id_empleado = idEmp
                '                .codigo = 3018
                '                .nombre_renglon = "Asig. no Rem. Res. 2032/10"
                '                .cantidad = 1
                '                .adicional = CDec(300)
                '                decTotalAdicional = decTotalAdicional + .adicional
                '                .Guardar()

                '        End Select

                '        End With
                'Next




                '**************************
                '      ADICIONALES
                '**************************


                decTotalNetoCobrar = decTotalHaberSumatoria - decTotalDeduccion + decTotalAdicional
                Dim intParteDecimal As Decimal = 0
                ' Dim intParteEntera As Integer = 0
                ' intParteEntera = CInt(decTotalNetoCobrar - Math.Floor(decTotalNetoCobrar))
                intParteDecimal = 1 - decTotalNetoCobrar + Math.Floor(decTotalNetoCobrar)

                If intParteDecimal > CDec(0.5) Then
                    intParteDecimal = intParteDecimal - CDec(0.5)
                End If

                'redondeo
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 10000
                    .nombre_renglon = "Redondeo"
                    '.cantidad = 0
                    .adicional = intParteDecimal
                    decTotalAdicional = decTotalAdicional + .adicional
                    decTotalNetoCobrar = decTotalNetoCobrar + .adicional
                    .Guardar()
                End With



                '**********************
                '   GUARDAR VALORES
                '**********************
                Dim strTotalLetra As String = ""
                strTotalLetra = Numalet.ToCardinal(decTotalNetoCobrar)

                'si existe lo borro
                oTotal_sueldo.DeleteExistenteAguinaldo(idEmp, fecha_inicio, fecha_fin, "A")

                With oTotal_sueldo
                    .Cargar()
                    .Insertar()
                    .total_haber = decTotalHaberSumatoria
                    .total_deduccion = decTotalDeduccion
                    .total_adicional = decTotalAdicional
                    .total_cobrar = .total_haber - .total_deduccion + .total_adicional
                    .fecha = fecha_inicio
                    .id_empleado = idEmp
                    .letra_sueldo = strTotalLetra.ToUpper
                    Select Case fecha_fin.Month
                        Case 1, 2, 3, 4, 5, 6
                            .periodo = "S.A.C - 1º Semestre/" & fecha_fin.Year
                        Case 7, 8, 9, 10, 11, 12
                            .periodo = "S.A.C - 2º Semestre/" & fecha_fin.Year
                    End Select
                    .tipo_sueldo = "A"
                    .Guardar()
                End With
            End If

            oRecibo_sueldo.DeleteLiquidacion("A", idEmp, fecha_inicio.Date, fecha_fin.Date)

            Me.GuardarReciboSueldo(oRecibo_sueldo_temporal.ConsultarTodo, decTotalHaberSumatoria, decTotalDeduccion, decTotalAdicional, fecha_inicio.Date, "A")
            oRecibo_sueldo_temporal.Truncate()
        Next
    End Sub


    Sub HoraPymem(ByVal legajo_desde As Integer, ByVal legajo_hasta As Integer, ByVal fecha_inicio As DateTime, ByVal fecha_fin As DateTime)
        Dim odtEmp As New DataTable
        Dim odtSer As New DataTable
        Dim odtRen As New DataTable

        odtEmp = oEmpleado.GetEntreLegajo(legajo_desde, legajo_hasta)
        odtSer = oSereno.ConsultarTodo
        odtRen = oRenglon.ConsultarTodo
        oRecibo_sueldo_temporal.Cargar()
        oRecibo_sueldo_temporal.Truncate()


        'variables de importes sereno
        Dim decSueldoSereno As Decimal = 0
        Dim decContribucionExtraordinaria As Decimal = 0
        Dim decAporteSolidario As Decimal = 0
        Dim decAyudaEscolar As Decimal = 0
        Dim decValorDiscapacitado As Decimal = 0
        Dim decHoraAdministrativo As Decimal = 0
        Dim decValorEmbargo As Decimal = 0

        'variables de importes empleado
        Dim decValorHora As Decimal = 0
        Dim blCoordinador As Boolean = False
        Dim decHijo As Decimal = 0
        Dim decValorHijo As Decimal = 0
        Dim decSMVM As Decimal = 0
        Dim decAdicionalObraSocial As Decimal = 0
        Dim decHijoDiscapacitado As Decimal = 0
        Dim idEmp As Integer = 0
        Dim idTipoEmpleado As Integer = 0
        Dim decEspecialidad As Decimal = 0
        Dim dtFechaIngreso As DateTime
        Dim decValorExtra As Decimal = 0

        'variables de dias tarde
        Dim decDiaTarde As Decimal = 0

        'variables totales
        Dim decTotalHaber As Decimal = 0
        Dim decTotalDeduccion As Decimal = 0
        Dim decTotalAdicional As Decimal = 0
        Dim decTotalNetoCobrar As Decimal = 0
        Dim decHaberEspecialidad As Decimal = 0
        Dim decTotalHaberSumatoria As Decimal = 0

        'set los valores fijos de sueldo
        With odtSer.Rows(0)
            decSueldoSereno = CDec(.Item("sueldo_sereno"))
            decContribucionExtraordinaria = CDec(.Item("contribucion_extraordinaria"))
            decAporteSolidario = CDec(.Item("aporte_solidario"))
            decAyudaEscolar = CDec(.Item("ayuda_escolar"))
            decValorDiscapacitado = CDec(.Item("valor_discapacitado"))
            decHoraAdministrativo = CDec(.Item("hora_administrativo"))
            decValorEmbargo = CDec(.Item("valor_embargo"))
        End With


        'Dim fecha_inicio As DateTime
        'Dim fecha_fin As DateTime

        ''seteo la fecha para la quincena 1
        'fecha_inicio = CDate("01-" & periodo.Month & "-" & periodo.Year)
        'fecha_fin = CDate("15-" & periodo.Month & "-" & periodo.Year)


        'recorro los empleados seleccionados
        For Each rowEmp As DataRow In odtEmp.Rows

            decTotalHaber = 0
            decTotalDeduccion = 0
            decTotalAdicional = 0
            decTotalNetoCobrar = 0
            decHaberEspecialidad = 0
            decTotalHaberSumatoria = 0


            'set los valores del empleado
            idEmp = CInt(rowEmp("id_empleado"))
            idTipoEmpleado = CInt(rowEmp("id_tipo_empleado"))
            decValorHora = CDec(rowEmp("valor_hora"))
            blCoordinador = CBool(rowEmp("coordinador"))
            decHijo = CDec(rowEmp("hijo"))
            decValorHijo = CDec(rowEmp("valor_hijo"))
            decSMVM = CDec(rowEmp("salario_mvm"))
            decAdicionalObraSocial = CDec(rowEmp("adicional_obra_social"))
            decHijoDiscapacitado = CDec(rowEmp("hijo_discapacitado"))
            dtFechaIngreso = CDate(rowEmp("ingreso"))
            'valor hora pymem sacado del campo valor hijo
            decValorExtra = CDec(rowEmp("valor_hijo"))

            'calcular horas cargadas automaticas
            Dim oCalculo As New ClaseHora
            Dim oCalculo_Negativo As New ClaseHora


            'traigo los datos de las horas automaticas
            oCalculo = Me.CalcularHoraAutomatico(idEmp, fecha_inicio, fecha_fin, True)
            oCalculo_Negativo = Me.CalcularHoraAutomatico(idEmp, fecha_inicio, fecha_fin, False)

            '**************************
            '      HABERES
            '**************************

            'ingreso las horas normales
            If oCalculo.HoraNormal - oCalculo_Negativo.HoraNormal > 0 Then
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 1
                    .nombre_renglon = "Horas Normales"
                    .cantidad = oCalculo.HoraNormal - oCalculo_Negativo.HoraNormal
                    .haber = (oCalculo.HoraNormal + oCalculo.HoraViaje + oCalculo.HoraNocturna _
                              - oCalculo_Negativo.HoraNormal - oCalculo_Negativo.HoraViaje - oCalculo_Negativo.HoraNocturna) * decValorExtra
                    'calculo del total de haberes
                    decTotalHaber = decTotalHaber + .haber
                    .Guardar()
                End With
            End If

            'ingreso las horas al 50
            If oCalculo.Hora50 - oCalculo_Negativo.Hora50 > 0 Then
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 2
                    .nombre_renglon = "Horas al 50%"
                    .cantidad = oCalculo.Hora50 - oCalculo_Negativo.Hora50
                    .haber = (oCalculo.Hora50 + oCalculo.HoraViaje50 _
                              - oCalculo_Negativo.Hora50 - oCalculo_Negativo.HoraViaje50) * decValorExtra * CDec(1.5)
                    'calculo del total de haberes
                    decTotalHaber = decTotalHaber + .haber
                    .Guardar()
                End With
            End If

            'ingreso las horas al 100
            If oCalculo.Hora100 - oCalculo_Negativo.Hora100 > 0 Then
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 3
                    .nombre_renglon = "Horas al 100%"
                    .cantidad = oCalculo.Hora100 - oCalculo_Negativo.Hora100
                    .haber = (oCalculo.Hora100 + oCalculo.HoraViaje100 _
                              - oCalculo_Negativo.Hora100 - oCalculo_Negativo.HoraViaje100) * decValorExtra * CDec(2)
                    'calculo del total de haberes
                    decTotalHaber = decTotalHaber + .haber
                    .Guardar()
                End With
            End If

            'ingreso las horas viaje
            If oCalculo.HoraViaje - oCalculo_Negativo.HoraViaje > 0 Then
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 4
                    .nombre_renglon = "30% Sobre Horas Normales"
                    .cantidad = oCalculo.HoraViaje - oCalculo_Negativo.HoraViaje
                    .haber = (oCalculo.HoraViaje - oCalculo_Negativo.HoraViaje) * decValorExtra * CDec(0.3)
                    'calculo del total de haberes
                    decTotalHaber = decTotalHaber + .haber
                    .Guardar()
                End With
            End If

            'ingreso las horas viaje al 50
            If oCalculo.HoraViaje50 - oCalculo_Negativo.HoraViaje50 > 0 Then
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 5
                    .nombre_renglon = "30% Sobre Horas al 50%"
                    .cantidad = oCalculo.HoraViaje50 - oCalculo_Negativo.HoraViaje50
                    .haber = (oCalculo.HoraViaje50 - oCalculo_Negativo.HoraViaje50) * decValorExtra * CDec(0.3) * CDec(1.5)
                    'calculo del total de haberes
                    decTotalHaber = decTotalHaber + .haber
                    .Guardar()
                End With
            End If

            'ingreso las horas nocturnas
            If oCalculo.HoraNocturna - oCalculo_Negativo.HoraNocturna > 0 Then
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 6
                    .nombre_renglon = "Horas Nocturnas"
                    .cantidad = oCalculo.HoraNocturna - oCalculo_Negativo.HoraNocturna
                    .haber = (oCalculo.HoraNocturna - oCalculo_Negativo.HoraNocturna) * decValorExtra * CDec(0.1334)
                    'calculo del total de haberes
                    decTotalHaber = decTotalHaber + .haber
                    .Guardar()
                End With
            End If

            'ingreso las horas por enfermedad
            If oCalculo.HoraEnfermedad - oCalculo_Negativo.HoraEnfermedad > 0 Then
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 7
                    .nombre_renglon = "Horas por Enfermedad"
                    .cantidad = oCalculo.HoraEnfermedad - oCalculo_Negativo.HoraEnfermedad
                    .haber = (oCalculo.HoraEnfermedad - oCalculo_Negativo.HoraEnfermedad) * decValorExtra
                    'calculo del total de haberes
                    decTotalHaber = decTotalHaber + .haber
                    .Guardar()
                End With
            End If

            'ingreso las horas por accidente
            If oCalculo.HoraAccidente - oCalculo_Negativo.HoraAccidente > 0 Then
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 8
                    .nombre_renglon = "Horas por Accidente"
                    .cantidad = oCalculo.HoraAccidente - oCalculo_Negativo.HoraAccidente
                    .haber = (oCalculo.HoraAccidente - oCalculo_Negativo.HoraAccidente) * decValorExtra
                    'calculo del total de haberes
                    decTotalHaber = decTotalHaber + .haber
                    .Guardar()
                End With
            End If

            'ingreso las horas por feriado
            If oCalculo.HoraFeriado - oCalculo_Negativo.HoraFeriado > 0 Then
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 9
                    .nombre_renglon = "Horas por Feriado"
                    .cantidad = oCalculo.HoraFeriado - oCalculo_Negativo.HoraFeriado
                    .haber = (oCalculo.HoraFeriado - oCalculo_Negativo.HoraFeriado) * decValorExtra
                    'calculo del total de haberes
                    decTotalHaber = decTotalHaber + .haber
                    .Guardar()
                End With
            End If



            'ingreso las horas por enfermedad
            If oCalculo.HoraNoTrabajada - oCalculo_Negativo.HoraNoTrabajada > 0 Then
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 11
                    .nombre_renglon = "Horas no Trabajadas"
                    .cantidad = oCalculo.HoraNoTrabajada - oCalculo_Negativo.HoraNoTrabajada
                    .haber = (oCalculo.HoraNoTrabajada - oCalculo_Negativo.HoraNoTrabajada) * decValorExtra
                    'calculo del total de haberes
                    decTotalHaber = decTotalHaber + .haber
                    .Guardar()
                End With
            End If

            'ingreso las horas viaje al 100
            If oCalculo.HoraViaje100 - oCalculo_Negativo.HoraViaje100 > 0 Then
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 22
                    .nombre_renglon = "30% Sobre Horas al 100%"
                    .cantidad = oCalculo.HoraViaje100 - oCalculo_Negativo.HoraViaje100
                    .haber = (oCalculo.HoraViaje100 - oCalculo_Negativo.HoraViaje100) * decValorExtra * CDec(0.3) * CDec(2)
                    'calculo del total de haberes
                    decTotalHaber = decTotalHaber + .haber
                    .Guardar()
                End With
            End If


            '******************************
            '   HORAS MANUALES
            '******************************

            Dim odtManual As New DataTable
            odtManual = oMovimiento_manual.GetAllControl(idEmp, fecha_inicio, fecha_fin)
            Dim intCodigoRenglon As Integer = 0
            Dim decCantidad As Decimal = 0
            Dim oCalculoManual As New ClaseHora

            'traigo los datos de las horas automaticas
            oCalculoManual = Me.CalcularHoraManual(idEmp, fecha_inicio, fecha_fin)

            For Each rowManual As DataRow In odtManual.Rows
                intCodigoRenglon = CInt(rowManual("codigo"))
                decCantidad = CDec(rowManual("cantidad"))

                With oRecibo_sueldo_temporal
                    'si la cantidad es 0 no lo guardo
                    If decCantidad <> 0 Then
                        Select Case intCodigoRenglon

                            'ingreso las horas normales
                            Case 1
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 1
                                .nombre_renglon = "Horas Normales"
                                .cantidad = oCalculoManual.HoraNormal
                                .haber = (oCalculoManual.HoraNormal + oCalculoManual.HoraViaje + oCalculoManual.HoraNocturna) * decValorExtra
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()

                                'ingreso las horas al 50
                            Case 2

                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 2
                                .nombre_renglon = "Horas al 50%"
                                .cantidad = oCalculoManual.Hora50
                                .haber = (oCalculoManual.Hora50 + oCalculoManual.HoraViaje50) * decValorExtra * CDec(1.5)
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()

                                'ingreso las horas al 100
                            Case 3
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 3
                                .nombre_renglon = "Horas al 100%"
                                .cantidad = oCalculoManual.Hora100
                                .haber = (oCalculoManual.Hora100 + oCalculoManual.HoraViaje100) * decValorExtra * CDec(2)
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()


                                'ingreso las horas viaje
                            Case 4
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 4
                                .nombre_renglon = "30% Sobre Horas Normales"
                                .cantidad = oCalculoManual.HoraViaje
                                .haber = oCalculoManual.HoraViaje * decValorExtra * CDec(0.3)
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()


                                'ingreso las horas viaje al 50
                            Case 5
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 5
                                .nombre_renglon = "30% Sobre Horas al 50%"
                                .cantidad = oCalculoManual.HoraViaje50
                                .haber = oCalculoManual.HoraViaje50 * decValorExtra * CDec(0.3) * CDec(1.5)
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()


                                'ingreso las horas nocturnas
                            Case 6
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 6
                                .nombre_renglon = "Horas Nocturnas"
                                .cantidad = oCalculoManual.HoraNocturna
                                .haber = oCalculoManual.HoraNocturna * decValorExtra * CDec(0.1334)
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()


                                'ingreso las horas por enfermedad
                            Case 7
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 7
                                .nombre_renglon = "Horas por Enfermedad"
                                .cantidad = oCalculoManual.HoraEnfermedad
                                .haber = oCalculoManual.HoraEnfermedad * decValorExtra
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()


                                'ingreso las horas por accidente
                            Case 8
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 8
                                .nombre_renglon = "Horas por Accidente"
                                .cantidad = oCalculoManual.HoraAccidente
                                .haber = oCalculoManual.HoraAccidente * decValorExtra
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()


                                'ingreso las horas por feriado
                            Case 9
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 9
                                .nombre_renglon = "Horas por Feriado"
                                .cantidad = oCalculoManual.HoraFeriado
                                .haber = oCalculoManual.HoraFeriado * decValorExtra
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()


                                'ingreso las horas por enfermedad
                            Case 11
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 11
                                .nombre_renglon = "Horas no Trabajadas"
                                .cantidad = oCalculoManual.HoraNoTrabajada
                                .haber = oCalculoManual.HoraNoTrabajada * decValorExtra
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber


                                'ingreso las horas viaje al 100
                            Case 22
                                .Insertar()
                                .id_empleado = idEmp
                                .codigo = 22
                                .nombre_renglon = "30% Sobre Horas al 100%"
                                .cantidad = oCalculoManual.HoraViaje100
                                .haber = oCalculoManual.HoraViaje100 * decValorExtra * CDec(0.3) * CDec(2)
                                'calculo del total de haberes
                                decTotalHaber = decTotalHaber + .haber
                                .Guardar()
                        End Select
                    End If
                End With
            Next

            Dim decCantidadHoraTodoNormal As Decimal = 0

            With oCalculo
                decCantidadHoraTodoNormal = CDec(.HoraNormal + (1.5 * .Hora50) + (2 * .Hora100))
            End With

            With oCalculoManual
                decCantidadHoraTodoNormal = decCantidadHoraTodoNormal + CDec(.HoraNormal + (1.5 * .Hora50) + (2 * .Hora100))
            End With

            'si hay haberes continuar sino saltar
            If decTotalHaber > 0 Then

                decTotalHaberSumatoria = decTotalHaber

                '******************************************
                '   PRESENTISMO - ANTIGUEDAD - ESPECIALIDAD
                '******************************************

                ''ingreso las horas presentismo
                'Dim odtTarde As New DataTable
                'odtTarde = oDia_tarde.GetAllControl(idEmp, fecha_inicio, fecha_fin)
                'decDiaTarde = CDec(odtTarde.Rows(0).Item("cantidad_dia_tarde"))

                'With oRecibo_sueldo_temporal
                '    .Insertar()
                '    .id_empleado = idEmp
                '    .codigo = 25
                '    .nombre_renglon = "Presentismo"
                '    '.cantidad = oCalculo.HoraViaje100
                '    .haber = decTotalHaber * (CDec(0.2) - (decDiaTarde * CDec(0.02)))
                '    decTotalHaberSumatoria = decTotalHaber + .haber
                '    .Guardar()
                'End With

                ''ingreso de la especialidad
                'Dim odtEsp As New DataTable
                'odtEsp = oTipo_Empleado.GetOne(idTipoEmpleado)
                'decEspecialidad = CDec(odtEsp.Rows(0).Item("porcentaje"))

                'If decEspecialidad <= 0 Then
                'Else
                '    With oRecibo_sueldo_temporal
                '        .Insertar()
                '        .id_empleado = idEmp
                '        .codigo = 26
                '        .nombre_renglon = "Especialidad"
                '        '.cantidad = oCalculo.HoraViaje100
                '        .haber = decTotalHaber * decEspecialidad / 100
                '        decHaberEspecialidad = .haber
                '        decTotalHaberSumatoria = decTotalHaberSumatoria + .haber
                '        .Guardar()
                '    End With
                'End If

                ''ingreso de la antigüedad
                'Dim intAntiguedad As Integer = 0
                'Dim decAntiguedad As Decimal = 0
                ''intAntiguedad = CInt(DateDiff(DateInterval.Year, dtFechaIngreso, fecha_fin))
                'decAntiguedad = DateDiff(DateInterval.DayOfYear, dtFechaIngreso, fecha_fin) / CDec(365)
                'intAntiguedad = CInt(System.Math.Truncate(decAntiguedad))

                'If intAntiguedad > 0 Then
                '    With oRecibo_sueldo_temporal
                '        .Insertar()
                '        .id_empleado = idEmp
                '        .codigo = 27
                '        .nombre_renglon = "Antigüedad"
                '        .cantidad = intAntiguedad
                '        .haber = CDec(intAntiguedad / 100 * (decTotalHaber + decHaberEspecialidad))
                '        decTotalHaberSumatoria = decTotalHaberSumatoria + .haber
                '        .Guardar()
                '    End With
                'End If




                ''**************************
                ''      DEDUCCIONES
                ''**************************

                ''ingreso de la jubilacion
                'With oRecibo_sueldo_temporal
                '    .Insertar()
                '    .id_empleado = idEmp
                '    .codigo = 2000
                '    .nombre_renglon = "Jubilación  11 %"
                '    '.cantidad = 0
                '    .deduccion = Math.Round(decTotalHaberSumatoria * CDec(0.11), 2)
                '    decTotalDeduccion = decTotalDeduccion + .deduccion
                '    .Guardar()
                'End With

                ''ingreso del INSSJP
                'With oRecibo_sueldo_temporal
                '    .Insertar()
                '    .id_empleado = idEmp
                '    .codigo = 2001
                '    .nombre_renglon = "I.N.S.S.J.P  3%"
                '    '.cantidad = 0
                '    .deduccion = Math.Round(decTotalHaberSumatoria * CDec(0.03), 2)
                '    decTotalDeduccion = decTotalDeduccion + .deduccion
                '    .Guardar()
                'End With

                ''ingreso de la obra social
                'With oRecibo_sueldo_temporal
                '    .Insertar()
                '    .id_empleado = idEmp
                '    .codigo = 2002
                '    .nombre_renglon = "Obra Social  2,25%"
                '    '.cantidad = 0
                '    .deduccion = Math.Round(decTotalHaberSumatoria * CDec(0.0225), 2)
                '    decTotalDeduccion = decTotalDeduccion + .deduccion
                '    .Guardar()
                'End With

                ''ingreso del ISSPIC
                'With oRecibo_sueldo_temporal
                '    .Insertar()
                '    .id_empleado = idEmp
                '    .codigo = 2003
                '    .nombre_renglon = "I.S.S.P.I.C.  0,45%"
                '    '.cantidad = 0
                '    .deduccion = Math.Round(decTotalHaberSumatoria * CDec(0.0045), 2)
                '    decTotalDeduccion = decTotalDeduccion + .deduccion
                '    .Guardar()
                'End With

                ''ingreso del ANSSAL
                'With oRecibo_sueldo_temporal
                '    .Insertar()
                '    .id_empleado = idEmp
                '    .codigo = 2004
                '    .nombre_renglon = "ANSSAL  0,30%"
                '    '.cantidad = 0
                '    .deduccion = Math.Round(decTotalHaberSumatoria * CDec(0.003), 2)
                '    decTotalDeduccion = decTotalDeduccion + .deduccion
                '    .Guardar()
                'End With


                ''****************************
                ''   HORAS MANUALES RESTO
                ''****************************

                'Dim odtManualResto As New DataTable
                'odtManual = oMovimiento_manual.GetAllControl(idEmp, fecha_inicio, fecha_fin)

                'For Each rowManual As DataRow In odtManual.Rows
                '    intCodigoRenglon = CInt(rowManual("codigo"))
                '    decCantidad = CDec(rowManual("cantidad"))

                '    With oRecibo_sueldo_temporal

                '        Select Case intCodigoRenglon
                '            Case 2007
                '                .Insertar()
                '                .id_empleado = idEmp
                '                .codigo = 2007
                '                .nombre_renglon = "U.O.C.R.A. - Seguros"
                '                '.cantidad = 0
                '                .deduccion = decSueldoSereno * CDec(0.02)
                '                decTotalDeduccion = decTotalDeduccion + .deduccion
                '                .Guardar()

                '            Case 2016
                '                .Insertar()
                '                .id_empleado = idEmp
                '                .codigo = 2016
                '                .nombre_renglon = "Servicios A.M.M.A."
                '                '.cantidad = 0
                '                .deduccion = CDec(30)
                '                decTotalDeduccion = decTotalDeduccion + .deduccion
                '                .Guardar()

                '            Case 2005
                '                .Insertar()
                '                .id_empleado = idEmp
                '                .codigo = 2005
                '                .nombre_renglon = "U.O.C.R.A. - C.Sindical  2,5%"
                '                '.cantidad = 0
                '                .deduccion = decTotalHaberSumatoria * CDec(0.025)
                '                decTotalDeduccion = decTotalDeduccion + .deduccion
                '                .Guardar()

                '            Case 2008
                '                .Insertar()
                '                .id_empleado = idEmp
                '                .codigo = 2008
                '                .nombre_renglon = "Obra Social Administ. 3%"
                '                '.cantidad = 0
                '                .deduccion = decTotalHaberSumatoria * CDec(0.03)
                '                decTotalDeduccion = decTotalDeduccion + .deduccion
                '                .Guardar()

                '            Case 2009
                '                .Insertar()
                '                .id_empleado = idEmp
                '                .codigo = 2009
                '                .nombre_renglon = "Adicional Obra Social 1,50%"
                '                '.cantidad = 0
                '                .deduccion = decTotalHaberSumatoria * CDec(0.015)
                '                decTotalDeduccion = decTotalDeduccion + .deduccion
                '                .Guardar()

                '                'Case 2013
                '                '    .Insertar()
                '                '    .id_empleado = idEmp
                '                '    .codigo = 2013
                '                '    .nombre_renglon = "Contrib. Extraord. U.O.C.RA."
                '                '    '.cantidad = 0
                '                '    .deduccion = decSueldoSereno
                '                '    decTotalDeduccion = decTotalDeduccion + .deduccion
                '                '    .Guardar()
                '                'Case 2015
                '                '    .Insertar()
                '                '    .id_empleado = idEmp
                '                '    .codigo = 2015
                '                '    .nombre_renglon = "Aporte Solidario UOCRA"
                '                '    '.cantidad = 0
                '                '    .deduccion = decSueldoSereno
                '                '    decTotalDeduccion = decTotalDeduccion + .deduccion
                '                '    .Guardar()

                '            Case 2017
                '                .Insertar()
                '                .id_empleado = idEmp
                '                .codigo = 2017
                '                .nombre_renglon = "Retención por Embargo Judicial"
                '                '.cantidad = 0
                '                .deduccion = decCantidadHoraTodoNormal * (decValorHora - decValorEmbargo) * CDec(0.1)
                '                decTotalDeduccion = decTotalDeduccion + .deduccion
                '                .Guardar()

                '            Case 2019
                '                .Insertar()
                '                .id_empleado = idEmp
                '                .codigo = 2019
                '                .nombre_renglon = "Asig. no Rem Res. 2032/10"
                '                .cantidad = 1
                '                .deduccion = CDec(300) * CDec(0.0225)
                '                decTotalDeduccion = decTotalDeduccion + .deduccion
                '                .Guardar()

                '            Case 2019
                '                .Insertar()
                '                .id_empleado = idEmp
                '                .codigo = 2019
                '                .nombre_renglon = "Res. 2032/10 - Obra Social"
                '                .cantidad = 1
                '                .deduccion = CDec(300) * CDec(0.0225)
                '                decTotalDeduccion = decTotalDeduccion + .deduccion
                '                .Guardar()

                '            Case 3018
                '                .Insertar()
                '                .id_empleado = idEmp
                '                .codigo = 3018
                '                .nombre_renglon = "Asig. no Rem. Res. 2032/10"
                '                .cantidad = 1
                '                .adicional = CDec(300)
                '                decTotalAdicional = decTotalAdicional + .adicional
                '                .Guardar()

                '        End Select

                '    End With
                'Next




                '**************************
                '      ADICIONALES
                '**************************


                decTotalNetoCobrar = decTotalHaberSumatoria - decTotalDeduccion + decTotalAdicional
                Dim intParteDecimal As Decimal = 0
                ' Dim intParteEntera As Integer = 0
                ' intParteEntera = CInt(decTotalNetoCobrar - Math.Floor(decTotalNetoCobrar))
                intParteDecimal = 1 - decTotalNetoCobrar + Math.Floor(decTotalNetoCobrar)

                If intParteDecimal > CDec(0.5) Then
                    intParteDecimal = intParteDecimal - CDec(0.5)
                End If

                'redondeo
                With oRecibo_sueldo_temporal
                    .Insertar()
                    .id_empleado = idEmp
                    .codigo = 10000
                    .nombre_renglon = "Redondeo"
                    '.cantidad = 0
                    .adicional = intParteDecimal
                    decTotalAdicional = decTotalAdicional + .adicional
                    decTotalNetoCobrar = decTotalNetoCobrar + .adicional
                    .Guardar()
                End With



                '**********************
                '   GUARDAR VALORES
                '**********************
                Dim strTotalLetra As String = ""
                strTotalLetra = Numalet.ToCardinal(decTotalNetoCobrar)

                'si existe lo borro
                oTotal_sueldo.DeleteExistenteAguinaldo(idEmp, fecha_inicio, fecha_fin, "P")

                Me.RemuneracionBasica = decValorExtra

                With oTotal_sueldo
                    .Cargar()
                    .Insertar()
                    .total_haber = decTotalHaberSumatoria
                    .total_deduccion = decTotalDeduccion
                    .total_adicional = decTotalAdicional
                    .total_cobrar = .total_haber - .total_deduccion + .total_adicional
                    .fecha = fecha_inicio
                    .id_empleado = idEmp
                    .letra_sueldo = strTotalLetra.ToUpper
                    .periodo = "1ª Quincena de " & fecha_inicio.Month & "/" & fecha_inicio.Year
                    .tipo_sueldo = "P"
                    .Guardar()
                End With
            End If

            oRecibo_sueldo.DeleteLiquidacion("P", idEmp, fecha_inicio.Date, fecha_fin.Date)

            Me.GuardarReciboSueldo(oRecibo_sueldo_temporal.ConsultarTodo, decTotalHaberSumatoria, decTotalDeduccion, decTotalAdicional, fecha_inicio.Date, "P")
            oRecibo_sueldo_temporal.Truncate()
        Next

    End Sub


    Sub GuardarReciboSueldo(ByVal odtTemp As DataTable, ByVal haber As Decimal, ByVal deduccion As Decimal, _
                            ByVal adicional As Decimal, ByVal fecha As DateTime, ByVal tipo_sueldo As String)
        For Each row As DataRow In odtTemp.Rows

            With oRecibo_sueldo
                .Cargar()
                .Insertar()
                .adicional = CDec(row.Item("adicional"))
                .cantidad = CDec(row.Item("cantidad"))
                .codigo = CDec(row.Item("codigo"))
                .deduccion = CDec(row.Item("deduccion"))
                .fecha_liquidacion = Me.FechaLiquidacion
                .haber = CDec(row.Item("haber"))
                .id_empleado = CInt(row.Item("id_empleado"))
                .liquidacion = Me.Liquidacion
                .neto_cobrado = haber - deduccion + adicional
                .nombre_renglon = CStr(row.Item("nombre_renglon"))
                .remuneracion_basica = Me.RemuneracionBasica
                .remuneracion_basica_a_retenciones = haber
                .remuneracion_no_sujeta_a_retencion = adicional
                .retenciones_descuentos = deduccion
                .fecha = fecha
                .tipo_sueldo = tipo_sueldo
                .Guardar()
            End With
        Next
    End Sub

End Class
