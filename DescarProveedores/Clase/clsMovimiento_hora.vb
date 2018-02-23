Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Movimiento_hora
    Inherits Movimiento_hora_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Movimiento_hora As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Movimiento_hora", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_movimiento_hora", SqlDbType.Int, 4, "id_movimiento_hora")
        oda.SelectCommand.Parameters("@id_movimiento_hora").Value = id_Movimiento_hora

        oda.Fill(odt)
        Return odt
    End Function

    ''grilla
    'Public Function GetAll_2() As DataTable
    '    Dim odt As New DataTable
    '    Dim oda As New SqlDataAdapter("cop_Movimiento_hora_GetAll_2", cnn.Coneccion)

    '    oda.SelectCommand.CommandType = CommandType.StoredProcedure

    '    oda.Fill(odt)
    '    Return odt
    'End Function

    'grilla
    Public Function GetAll_3(ByVal id_usuario As Integer, ByVal inicio As DateTime, ByVal fin As DateTime) As DataTable
        Dim odt As New DataTable
        'Dim oda As New SqlDataAdapter("cop_Movimiento_hora_GetAll_3", cnn.Coneccion)
        Dim oda As New SqlDataAdapter("cop_Movimiento_hora_GetAll_4", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = id_usuario
        oda.SelectCommand.Parameters.Add("@inicio", SqlDbType.DateTime, 8, "inicio")
        oda.SelectCommand.Parameters("@inicio").Value = inicio
        oda.SelectCommand.Parameters.Add("@fin", SqlDbType.DateTime, 8, "fin")
        oda.SelectCommand.Parameters("@fin").Value = fin


        oda.Fill(odt)
        Return odt
    End Function

    'grilla
    Public Function GetAll_6(ByVal id_usuario As Integer, ByVal inicio As DateTime, ByVal fin As DateTime, ByVal extra As Boolean) As DataTable
        Dim odt As New DataTable
        'Dim oda As New SqlDataAdapter("cop_Movimiento_hora_GetAll_3", cnn.Coneccion)
        Dim oda As New SqlDataAdapter("cop_Movimiento_hora_GetAll_6", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = id_usuario
        oda.SelectCommand.Parameters.Add("@inicio", SqlDbType.DateTime, 8, "inicio")
        oda.SelectCommand.Parameters("@inicio").Value = inicio
        oda.SelectCommand.Parameters.Add("@fin", SqlDbType.DateTime, 8, "fin")
        oda.SelectCommand.Parameters("@fin").Value = fin
        'oda.SelectCommand.Parameters.Add("@extra", SqlDbType.Bit, 1, "extra")
        'oda.SelectCommand.Parameters("@extra").Value = extra

        oda.Fill(odt)
        Return odt
    End Function

    'sp que arma el resumen
    Public Sub UpdateDia(ByVal id_movimiento_hora As Integer, ByVal id_dia As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Movimiento_hora_UpdateDia"

        Command.CommandType = CommandType.StoredProcedure
        Command.Parameters.Add("@id_movimiento_hora", SqlDbType.Int, 4, "id_movimiento_hora")
        Command.Parameters("@id_movimiento_hora").Value = id_movimiento_hora
        Command.Parameters.Add("@id_dia", SqlDbType.Int, 4, "id_dia")
        Command.Parameters("@id_dia").Value = id_dia

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub






    'ejemplo de consulta con parametros
    Public Function SetResumen(ByVal inicio As DateTime, ByVal fin As DateTime, ByVal extra As Boolean) As DataTable
        'procedimiento de la consulta
        Dim odtusuario As New DataTable
        Dim odtMovi As New DataTable
        Dim odtCuerpo As New DataTable
        Dim intusuario As Integer = 0
        Dim intMovimiento As Integer = 0

        odtusuario = ousuario.GetActivo
        'odtusuario = oMovimiento_hora.Getusuario(inicio, fin)
        oTemp1.Truncate()

        For Each row As DataRow In odtusuario.Rows
            intusuario = CInt(row("id_usuario"))
            odtMovi = oMovimiento_hora.GetAllControl(intusuario, inicio, fin)

            Dim decNormal As Decimal = 0
            Dim dec50 As Decimal = 0
            Dim dec100 As Decimal = 0
            Dim decNormal_30 As Decimal = 0
            Dim decNormal_50 As Decimal = 0
            Dim decNormal_100 As Decimal = 0
            Dim decNocturna As Decimal = 0
            Dim decEnfermedad As Decimal = 0
            Dim decAccidente As Decimal = 0
            Dim decFeriado As Decimal = 0
            Dim decEspecial As Decimal = 0

            Dim decTotal As Decimal = 0
            Dim decTotal_2 As Decimal = 0
            Dim decTotal_3 As Decimal = 0
            Dim decMinuto As Decimal = 0
            Dim decMinuto_2 As Decimal = 0
            Dim decMinuto_3 As Decimal = 0
            Dim dtInicio As DateTime
            Dim dtFin As DateTime

            For Each row_2 As DataRow In odtMovi.Rows
                intMovimiento = CInt(row_2("id_movimiento_hora"))
                odtCuerpo = oCuerpo_movimiento_hora.GetAllMovimientoControl(intMovimiento, extra)

                If odtCuerpo.Rows.Count > 0 Then

                    decMinuto = 0
                    decTotal = 0
                    For Each rowCuerpo As DataRow In odtCuerpo.Rows
                        dtInicio = CDate(rowCuerpo("entrada"))
                        dtFin = CDate(rowCuerpo("salida"))
                        'calcula la cantidad de horas trabajadas
                        decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtFin)
                        decTotal = decTotal + CDec(FormatNumber(decMinuto / 60, 1))
                    Next

                    'dtInicio = CDate(row_2("entrada"))
                    'dtFin = CDate(row_2("salida"))

                    'calcula la cantidad de horas trabajadas
                    'decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtFin)
                    'decTotal = CDec(FormatNumber(decMinuto / 60, 1))

                    Select Case row_2("id_dia").ToString
                        'lunes a jueves
                        Case "1"
                            If decTotal > 9 Then
                                decNormal = decNormal + 9
                                dec50 = dec50 + decTotal - 9
                            Else
                                decNormal = decNormal + decTotal
                            End If
                            'viernes
                        Case "2"
                            If decTotal > 8 Then
                                decNormal = decNormal + 8
                                dec50 = dec50 + decTotal - 8
                            Else
                                decNormal = decNormal + decTotal
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

                            For Each rowCuerpo As DataRow In odtCuerpo.Rows
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
                                decNocturna = decNocturna + 9
                                dec50 = dec50 + decTotal - 9
                            ElseIf decHoraInicio < 21 And decHoraFin < 6 Then
                                If decTotal > 9 Then
                                    decMinuto = DateDiff(DateInterval.Minute, dtAuxI, dtFin)
                                    decHNoct = CDec(FormatNumber(decMinuto / 60, 1))

                                    decNocturna = decNocturna + decHNoct
                                    decHNorm = 9 - decHNoct
                                    decNormal = decNormal + decHNorm
                                    dec50 = dec50 + decTotal - 9
                                Else
                                    decMinuto = DateDiff(DateInterval.Minute, dtAuxI, dtFin)
                                    decHNoct = CDec(FormatNumber(decMinuto / 60, 1))

                                    decNocturna = decNocturna + decHNoct
                                    decHNorm = decTotal - decHNoct
                                    decNormal = decNormal + decHNorm
                                End If
                            ElseIf decHoraInicio > 21 And decHoraFin >= 6 Then
                                If decTotal > 9 Then
                                    decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtAuxF)
                                    decHNoct = CDec(FormatNumber(decMinuto / 60, 1))

                                    decNocturna = decNocturna + decHNoct
                                    decHNorm = 9 - decHNoct
                                    decNormal = decNormal + decHNorm
                                    dec50 = dec50 + decTotal - 9
                                Else
                                    decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtAuxF)
                                    decHNoct = CDec(FormatNumber(decMinuto / 60, 1))

                                    decNocturna = decNocturna + decHNoct
                                    decHNorm = decTotal - decHNoct
                                    decNormal = decNormal + decHNorm
                                End If
                            ElseIf decHoraInicio > 21 And decHoraFin < 6 Then
                                decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtAuxF)
                                decHNoct = CDec(FormatNumber(decMinuto / 60, 1))

                                decNocturna = decNocturna + decHNoct
                            End If

                            'sabados
                        Case "4"
                            decMinuto = 0
                            decTotal = 0
                            For Each rowCuerpo As DataRow In odtCuerpo.Rows
                                dtInicio = CDate(rowCuerpo("entrada"))
                                dtFin = CDate(rowCuerpo("salida"))

                                Dim dtAuxI As DateTime = New DateTime(dtInicio.Year, dtInicio.Month, dtInicio.Day, 13, 0, 0)

                                If dtInicio < dtAuxI And dtFin < dtAuxI Then
                                    'horas 50
                                    decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtFin)
                                    dec50 = dec50 + CDec(FormatNumber(decMinuto / 60, 1))
                                ElseIf dtInicio < dtAuxI And dtFin > dtAuxI Then
                                    'horas 50
                                    decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtAuxI)
                                    dec50 = dec50 + CDec(FormatNumber(decMinuto / 60, 1))
                                    'horas 100
                                    decMinuto = DateDiff(DateInterval.Minute, dtAuxI, dtFin)
                                    dec100 = dec100 + CDec(FormatNumber(decMinuto / 60, 1))
                                ElseIf dtInicio > dtAuxI And dtFin > dtAuxI Then
                                    'horas 100
                                    decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtFin)
                                    dec100 = dec100 + CDec(FormatNumber(decMinuto / 60, 1))
                                End If
                            Next

                            'domingos
                        Case "5"
                            dec100 = dec100 + decTotal
                            'enfermedad
                        Case "6"
                            decEnfermedad = decEnfermedad + 8
                            '  decNormal = decNormal + 8
                            'accidente
                        Case "7"
                            decAccidente = decAccidente + 8
                            ' decNormal = decNormal + 8
                            'viajes
                        Case "8"

                            'feriado trabajado
                        Case "15"
                            If decTotal > 8 Then
                                decFeriado = decFeriado + 8
                                dec100 = dec100 + decTotal - 8
                            Else
                                decFeriado = decFeriado + 8
                            End If

                            'feriado
                        Case "10"
                            decFeriado = decFeriado + 8
                            ' decNormal = decNormal + 8
                            'especial
                        Case "11"
                            decEspecial = decEspecial + 8
                            ' decNormal = decNormal + 8
                    End Select
                End If
            Next

            With oTemp1
                .Cargar()
                .Insertar()
                .legajo = CStr(row("legajo"))
                .nombre_usuario = CStr(row("apellido")) & ", " & CStr(row("nombre"))
                .normal = decNormal
                .extra_50 = dec50
                .extra_100 = dec100
                .normal_30 = decNormal_30
                .extra_50_30 = decNormal_50
                .extra_100_30 = decNormal_100
                .nocturna = decNocturna
                .enfermedad = decEnfermedad
                .accidente = decAccidente
                .feriado = decFeriado
                .especial = decEspecial
                .Guardar()
            End With

        Next

        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Temp1_GetAll_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        'oda.SelectCommand.Parameters.Add("@id_movimiento_hora", SqlDbType.Int, 4, "id_movimiento_hora")
        'oda.SelectCommand.Parameters("@id_movimiento_hora").Value = id_movimiento_hora

        oda.Fill(odt)

        Return odt
    End Function

    'control
    Public Function GetAllControl(ByVal id_usuario As Integer, ByVal inicio As DateTime, ByVal fin As DateTime) As DataTable
        Dim odt As New DataTable
        'Dim oda As New SqlDataAdapter("cop_Movimiento_hora_GetAllControl", cnn.Coneccion)
        Dim oda As New SqlDataAdapter("cop_Movimiento_hora_GetAllControl_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = id_usuario
        oda.SelectCommand.Parameters.Add("@inicio", SqlDbType.DateTime, 8, "inicio")
        oda.SelectCommand.Parameters("@inicio").Value = inicio
        oda.SelectCommand.Parameters.Add("@fin", SqlDbType.DateTime, 8, "fin")
        oda.SelectCommand.Parameters("@fin").Value = fin
        'oda.SelectCommand.Parameters.Add("@extra", SqlDbType.Bit, 1, "extra")
        'oda.SelectCommand.Parameters("@extra").Value = extra

        oda.Fill(odt)
        Return odt
    End Function

    'trae los usuarios con movimientos
    Public Function Getusuario(ByVal inicio As DateTime, ByVal fin As DateTime) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Movimiento_hora_Getusuario", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@inicio", SqlDbType.DateTime, 8, "inicio")
        oda.SelectCommand.Parameters("@inicio").Value = inicio
        oda.SelectCommand.Parameters.Add("@fin", SqlDbType.DateTime, 8, "fin")
        oda.SelectCommand.Parameters("@fin").Value = fin

        oda.Fill(odt)

        Return odt
    End Function

    Public Function GetHoraLogueo(ByVal id_usuario As Integer) As Nullable(Of Date)
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Movimiento_hora_getHoraLogueoHoy", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 8, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = id_usuario

        oda.Fill(odt)

        If Not IsDBNull(odt.Rows(0).Item("Logueo")) Then
            Return CType(odt.Rows(0).Item("Logueo"), Date)
        End If

        Return Nothing
    End Function

    'agregado
    Public Function UpdateSalida(ByVal id_usuario As Integer, ByVal fecha As DateTime) As DataTable
        Dim odt As New DataTable
        'Dim oda As New SqlDataAdapter("cop_Movimiento_hora_GetAll_3", cnn.Coneccion)
        Dim oda As New SqlDataAdapter("cop_Movimiento_hora_UpdateSalida", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = id_usuario
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "inicio")
        oda.SelectCommand.Parameters("@fecha").Value = fecha
        oda.Fill(odt)
        Return odt
    End Function

    'agregado
    Public Function SetResumenEmpleado(ByVal inicio As DateTime, ByVal fin As DateTime, ByVal extra As Boolean, ByVal id_empleado As Integer) As DataTable
        'procedimiento de la consulta
        Dim odtEmpleado As New DataTable
        Dim odtMovi As New DataTable
        Dim odtCuerpo As New DataTable
        Dim intEmpleado As Integer = 0
        Dim intMovimiento As Integer = 0

        'odtEmpleado = oMovimiento_hora.GetEmpleado(inicio, fin)
        oTemp1.Truncate()

        intEmpleado = id_empleado
        odtMovi = oMovimiento_hora.GetAllControl(intEmpleado, inicio, fin)

        Dim decNormal As Decimal = 0
        Dim dec50 As Decimal = 0
        Dim dec100 As Decimal = 0
        Dim decNormal_30 As Decimal = 0
        Dim decNormal_50 As Decimal = 0
        Dim decNormal_100 As Decimal = 0
        Dim decNocturna As Decimal = 0
        Dim decEnfermedad As Decimal = 0
        Dim decAccidente As Decimal = 0
        Dim decFeriado As Decimal = 0
        Dim decEspecial As Decimal = 0

        Dim decTotal As Decimal = 0
        Dim decTotal_2 As Decimal = 0
        Dim decTotal_3 As Decimal = 0
        Dim decMinuto As Decimal = 0
        Dim decMinuto_2 As Decimal = 0
        Dim decMinuto_3 As Decimal = 0
        Dim dtInicio As DateTime
        Dim dtFin As DateTime

        For Each row_2 As DataRow In odtMovi.Rows
            intMovimiento = CInt(row_2("id_movimiento_hora"))
            odtCuerpo = oCuerpo_movimiento_hora.GetAllMovimientoControl(intMovimiento, extra)

            If odtCuerpo.Rows.Count > 0 Then

                decMinuto = 0
                decTotal = 0
                For Each rowCuerpo As DataRow In odtCuerpo.Rows
                    dtInicio = CDate(rowCuerpo("entrada"))
                    dtFin = CDate(rowCuerpo("salida"))
                    'calcula la cantidad de horas trabajadas
                    decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtFin)
                    decTotal = decTotal + CDec(FormatNumber(decMinuto / 60, 1))
                Next

                'dtInicio = CDate(row_2("entrada"))
                'dtFin = CDate(row_2("salida"))

                'calcula la cantidad de horas trabajadas
                'decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtFin)
                'decTotal = CDec(FormatNumber(decMinuto / 60, 1))

                Dim odtCal As New DataTable
                odtCal = oCalendario_usuario.GetDia(CDate(odtCuerpo.Rows(0).Item("entrada")), intEmpleado)

                Dim decParteExtra As Decimal = 0
                Dim decResto As Decimal = 0
                Dim decCociente As Decimal = 0
                Dim decEntero As Decimal = 0
                Dim decCociente_2 As Decimal = 0
                Dim decHoraExtraDecimal As Decimal = 0
                Dim decMediaExtra As Decimal = 0

                Dim intDia As Integer = 0
                intDia = CInt(odtCal.Rows(0).Item("id_dia"))

                'actualizo los tipos de dias
                oMovimiento_hora.UpdateDia(intMovimiento, intDia)

                ' Select Case row_2("id_dia").ToString
                Select Case intDia.ToString
                    'lunes a jueves
                    Case "1"
                        If decTotal > 8 Then
                            'decEntero = Math.Truncate(decCociente)
                            'decResto = decCociente - decEntero

                            decParteExtra = decTotal - 8
                            decCociente = decParteExtra / CDec(0.5)
                            decMediaExtra = Math.Truncate(decCociente) * CDec(0.5)


                            decNormal = decNormal + decTotal - decMediaExtra
                            dec50 = dec50 + decMediaExtra
                        Else
                            decNormal = decNormal + decTotal
                        End If
                        'viernes
                    Case "2"
                        'If decTotal > 8 Then
                        '    decNormal = decNormal + 8
                        '    dec50 = dec50 + decTotal - 8
                        'Else
                        '    decNormal = decNormal + decTotal
                        'End If
                        If decTotal > 8 Then
                            'decEntero = Math.Truncate(decCociente)
                            'decResto = decCociente - decEntero

                            decParteExtra = decTotal - 8
                            decCociente = decParteExtra / CDec(0.5)
                            decMediaExtra = Math.Truncate(decCociente) * CDec(0.5)


                            decNormal = decNormal + decTotal - decMediaExtra
                            dec50 = dec50 + decMediaExtra
                        Else
                            decNormal = decNormal + decTotal
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

                        For Each rowCuerpo As DataRow In odtCuerpo.Rows
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
                            decNocturna = decNocturna + 9
                            dec50 = dec50 + decTotal - 9
                        ElseIf decHoraInicio < 21 And decHoraFin < 6 Then
                            If decTotal > 9 Then
                                decMinuto = DateDiff(DateInterval.Minute, dtAuxI, dtFin)
                                decHNoct = CDec(FormatNumber(decMinuto / 60, 1))

                                decNocturna = decNocturna + decHNoct
                                decHNorm = 9 - decHNoct
                                decNormal = decNormal + decHNorm
                                dec50 = dec50 + decTotal - 9
                            Else
                                decMinuto = DateDiff(DateInterval.Minute, dtAuxI, dtFin)
                                decHNoct = CDec(FormatNumber(decMinuto / 60, 1))

                                decNocturna = decNocturna + decHNoct
                                decHNorm = decTotal - decHNoct
                                decNormal = decNormal + decHNorm
                            End If
                        ElseIf decHoraInicio > 21 And decHoraFin >= 6 Then
                            If decTotal > 9 Then
                                decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtAuxF)
                                decHNoct = CDec(FormatNumber(decMinuto / 60, 1))

                                decNocturna = decNocturna + decHNoct
                                decHNorm = 9 - decHNoct
                                decNormal = decNormal + decHNorm
                                dec50 = dec50 + decTotal - 9
                            Else
                                decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtAuxF)
                                decHNoct = CDec(FormatNumber(decMinuto / 60, 1))

                                decNocturna = decNocturna + decHNoct
                                decHNorm = decTotal - decHNoct
                                decNormal = decNormal + decHNorm
                            End If
                        ElseIf decHoraInicio > 21 And decHoraFin < 6 Then
                            decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtFin) 'cambiado
                            decHNoct = CDec(FormatNumber(decMinuto / 60, 1))

                            decNocturna = decNocturna + decHNoct
                        End If

                        'sabados
                    Case "4"
                        If decTotal > 5 Then

                            'decEntero = Math.Truncate(decCociente)
                            'decResto = decCociente - decEntero

                            decParteExtra = decTotal - 5
                            decCociente = decParteExtra / CDec(0.5)
                            decMediaExtra = Math.Truncate(decCociente) * CDec(0.5)


                            decNormal = decNormal + decTotal - decMediaExtra
                            dec50 = dec50 + decMediaExtra
                        Else
                            decNormal = decNormal + decTotal
                        End If
                        'decMinuto = 0
                        'decTotal = 0
                        'For Each rowCuerpo As DataRow In odtCuerpo.Rows
                        '    dtInicio = CDate(rowCuerpo("entrada"))
                        '    dtFin = CDate(rowCuerpo("salida"))

                        '    Dim dtAuxI As DateTime = New DateTime(dtInicio.Year, dtInicio.Month, dtInicio.Day, 13, 0, 0)

                        '    If dtInicio < dtAuxI And dtFin <= dtAuxI Then
                        '        'horas 50
                        '        decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtFin)
                        '        dec50 = dec50 + CDec(FormatNumber(decMinuto / 60, 1))
                        '    ElseIf dtInicio < dtAuxI And dtFin > dtAuxI Then
                        '        'horas 50
                        '        decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtAuxI)
                        '        dec50 = dec50 + CDec(FormatNumber(decMinuto / 60, 1))
                        '        'horas 100
                        '        decMinuto = DateDiff(DateInterval.Minute, dtAuxI, dtFin)
                        '        dec100 = dec100 + CDec(FormatNumber(decMinuto / 60, 1))
                        '    ElseIf dtInicio >= dtAuxI And dtFin > dtAuxI Then
                        '        'horas 100
                        '        decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtFin)
                        '        dec100 = dec100 + CDec(FormatNumber(decMinuto / 60, 1))
                        '    End If
                        'Next

                        'domingos
                    Case "5"
                        dec100 = dec100 + decTotal
                        'enfermedad
                    Case "6"
                        decEnfermedad = decEnfermedad + 8
                        '  decNormal = decNormal + 8
                        'accidente
                    Case "7"
                        decAccidente = decAccidente + 8
                        ' decNormal = decNormal + 8
                        'viajes
                    Case "8"

                        '    'feriado trabajado
                        'Case "15"
                        '    If decTotal > 8 Then
                        '        decFeriado = decFeriado + 8
                        '        decNormal = decNormal + 8
                        '        dec100 = dec100 + decTotal - 8
                        '    Else
                        '        decFeriado = decFeriado + 8
                        '        decNormal = decNormal + decTotal
                        '    End If

                        'feriado
                    Case "10"
                        decFeriado = decFeriado + 8
                        ' decNormal = decNormal + 8
                        'especial
                    Case "11"
                        decEspecial = decEspecial + 8
                        ' decNormal = decNormal + 8


                        'viaje viernes
                    Case "12"
                        If decTotal > 8 Then
                            decNormal = decNormal + 8
                            dec50 = dec50 + decTotal - 8
                        Else
                            decNormal = decNormal + decTotal
                        End If
                        'viaje sabado
                    Case "13"
                        If decTotal > CDec(5.5) Then
                            dec50 = dec50 + CDec(5.5)
                            dec100 = dec100 + decTotal - CDec(5.5)
                        Else
                            dec50 = dec50 + decTotal
                        End If
                        'viaje domingo
                    Case "14"
                        dec100 = dec100 + decTotal
                        'feriado trabajado
                    Case "15"

                        If decTotal > 8 Then
                            'decEntero = Math.Truncate(decCociente)
                            'decResto = decCociente - decEntero

                            decParteExtra = decTotal - 8
                            decCociente = decParteExtra / CDec(0.5)
                            decMediaExtra = Math.Truncate(decCociente) * CDec(0.5)

                            decNormal = decNormal + decTotal - decMediaExtra
                            dec100 = dec100 + decMediaExtra
                        Else
                            decNormal = decNormal + decTotal
                        End If

                        decFeriado = decFeriado + 8

                        'If decTotal > 8 Then
                        '    decNormal = decNormal + 8
                        '    dec100 = dec100 + decTotal - 8
                        'Else
                        '    decNormal = decNormal + decTotal
                        'End If
                        'decFeriado = decFeriado + 8



                        'nocturna viernes
                    Case "16"
                        decMinuto = 0
                        decTotal = 0
                        Dim i As Integer = 0
                        Dim decHoraInicio As Decimal = 0
                        Dim decHoraFin As Decimal = 0
                        Dim decDiferencia As Decimal = 0
                        Dim decHNoct As Decimal = 0
                        Dim decHNorm As Decimal = 0

                        For Each rowCuerpo As DataRow In odtCuerpo.Rows
                            If i = 0 Then
                                dtInicio = CDate(rowCuerpo("entrada"))
                            Else
                                dtFin = CDate(rowCuerpo("salida"))
                            End If

                            i = i + 1
                        Next

                        Dim dtAuxI As DateTime = New DateTime(dtInicio.Year, dtInicio.Month, dtInicio.Day, 21, 0, 0)
                        Dim dtAuxF As DateTime = New DateTime(dtFin.Year, dtFin.Month, dtFin.Day, 5, 0, 0)

                        decHoraInicio = CDec(dtInicio.Hour + (dtInicio.Minute / 60))
                        decHoraFin = CDec(dtFin.Hour + (dtFin.Minute / 60))
                        decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtFin)
                        decTotal = decTotal + CDec(FormatNumber(decMinuto / 60, 1))

                        If decHoraInicio <= 21 And decHoraFin >= 5 Then
                            decNocturna = decNocturna + 8
                            dec50 = dec50 + decTotal - 8
                        ElseIf decHoraInicio < 21 And decHoraFin < 5 Then
                            If decTotal > 8 Then
                                decMinuto = DateDiff(DateInterval.Minute, dtAuxI, dtFin)
                                decHNoct = CDec(FormatNumber(decMinuto / 60, 1))

                                decNocturna = decNocturna + decHNoct
                                decHNorm = 8 - decHNoct
                                decNormal = decNormal + decHNorm
                                dec50 = dec50 + decTotal - 8
                            Else
                                decMinuto = DateDiff(DateInterval.Minute, dtAuxI, dtFin)
                                decHNoct = CDec(FormatNumber(decMinuto / 60, 1))

                                decNocturna = decNocturna + decHNoct
                                decHNorm = decTotal - decHNoct
                                decNormal = decNormal + decHNorm
                            End If
                        ElseIf decHoraInicio > 21 And decHoraFin >= 5 Then
                            If decTotal > 8 Then
                                decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtAuxF)
                                decHNoct = CDec(FormatNumber(decMinuto / 60, 1))

                                decNocturna = decNocturna + decHNoct
                                decHNorm = 8 - decHNoct
                                decNormal = decNormal + decHNorm
                                dec50 = dec50 + decTotal - 8
                            Else
                                decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtAuxF)
                                decHNoct = CDec(FormatNumber(decMinuto / 60, 1))

                                decNocturna = decNocturna + decHNoct
                                decHNorm = decTotal - decHNoct
                                decNormal = decNormal + decHNorm
                            End If
                        ElseIf decHoraInicio > 21 And decHoraFin < 5 Then
                            decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtFin) '
                            decHNoct = CDec(FormatNumber(decMinuto / 60, 1))

                            decNocturna = decNocturna + decHNoct
                        End If

                        'nocturna sabado
                    Case "17"
                        decMinuto = 0
                        decTotal = 0
                        Dim i As Integer = 0
                        Dim decHoraInicio As Decimal = 0
                        Dim decHoraFin As Decimal = 0
                        Dim decDiferencia As Decimal = 0
                        Dim decHNoct As Decimal = 0
                        Dim decHNorm As Decimal = 0

                        For Each rowCuerpo As DataRow In odtCuerpo.Rows
                            If i = 0 Then
                                dtInicio = CDate(rowCuerpo("entrada"))
                            Else
                                dtFin = CDate(rowCuerpo("salida"))
                            End If

                            i = i + 1
                        Next

                        Dim dtAuxI As DateTime = New DateTime(dtInicio.Year, dtInicio.Month, dtInicio.Day, 21, 0, 0)
                        Dim dtAuxF As DateTime = New DateTime(dtFin.Year, dtFin.Month, dtFin.Day, 5, 0, 0)

                        decHoraInicio = CDec(dtInicio.Hour + (dtInicio.Minute / 60))
                        decHoraFin = CDec(dtFin.Hour + (dtFin.Minute / 60))
                        decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtFin)
                        decTotal = decTotal + CDec(FormatNumber(decMinuto / 60, 1))

                        If decHoraInicio <= 21 And decHoraFin >= 5 Then
                            decNocturna = decNocturna + 8
                            dec100 = dec100 + decTotal
                        ElseIf decHoraInicio < 21 And decHoraFin < 5 Then
                            If decTotal > 8 Then
                                decMinuto = DateDiff(DateInterval.Minute, dtAuxI, dtFin)
                                decHNoct = CDec(FormatNumber(decMinuto / 60, 1))

                                decNocturna = decNocturna + decHNoct
                                dec100 = dec100 + decTotal
                            Else
                                decMinuto = DateDiff(DateInterval.Minute, dtAuxI, dtFin)
                                decHNoct = CDec(FormatNumber(decMinuto / 60, 1))

                                decNocturna = decNocturna + decHNoct
                                dec100 = dec100 + decTotal
                            End If
                        ElseIf decHoraInicio > 21 And decHoraFin >= 5 Then
                            If decTotal > 8 Then
                                decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtAuxF)
                                decHNoct = CDec(FormatNumber(decMinuto / 60, 1))

                                decNocturna = decNocturna + decHNoct
                                dec100 = dec100 + decTotal
                            Else
                                decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtAuxF)
                                decHNoct = CDec(FormatNumber(decMinuto / 60, 1))

                                decNocturna = decNocturna + decHNoct
                                dec100 = dec100 + decTotal
                            End If
                        ElseIf decHoraInicio > 21 And decHoraFin < 5 Then
                            decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtFin) '
                            decHNoct = CDec(FormatNumber(decMinuto / 60, 1))

                            decNocturna = decNocturna + decHNoct
                            dec100 = dec100 + decTotal
                        End If

                        'nocturna domingo
                    Case "18"
                        decMinuto = 0
                        decTotal = 0
                        Dim i As Integer = 0
                        Dim decHoraInicio As Decimal = 0
                        Dim decHoraFin As Decimal = 0
                        Dim decDiferencia As Decimal = 0
                        Dim decHNoct As Decimal = 0
                        Dim decHNorm As Decimal = 0

                        For Each rowCuerpo As DataRow In odtCuerpo.Rows
                            If i = 0 Then
                                dtInicio = CDate(rowCuerpo("entrada"))
                            Else
                                dtFin = CDate(rowCuerpo("salida"))
                            End If

                            i = i + 1
                        Next

                        Dim dtAuxI As DateTime = New DateTime(dtInicio.Year, dtInicio.Month, dtInicio.Day, 21, 0, 0)
                        Dim dtAuxF As DateTime = New DateTime(dtFin.Year, dtFin.Month, dtFin.Day, 5, 0, 0)

                        decHoraInicio = CDec(dtInicio.Hour + (dtInicio.Minute / 60))
                        decHoraFin = CDec(dtFin.Hour + (dtFin.Minute / 60))
                        decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtFin)
                        decTotal = decTotal + CDec(FormatNumber(decMinuto / 60, 1))

                        If decHoraInicio <= 21 And decHoraFin >= 5 Then
                            decNocturna = decNocturna + 8
                            dec100 = dec100 + decTotal
                        ElseIf decHoraInicio < 21 And decHoraFin < 5 Then
                            If decTotal > 8 Then
                                decMinuto = DateDiff(DateInterval.Minute, dtAuxI, dtFin)
                                decHNoct = CDec(FormatNumber(decMinuto / 60, 1))

                                decNocturna = decNocturna + decHNoct
                                dec100 = dec100 + decTotal
                            Else
                                decMinuto = DateDiff(DateInterval.Minute, dtAuxI, dtFin)
                                decHNoct = CDec(FormatNumber(decMinuto / 60, 1))

                                decNocturna = decNocturna + decHNoct
                                dec100 = dec100 + decTotal
                            End If
                        ElseIf decHoraInicio > 21 And decHoraFin >= 5 Then
                            If decTotal > 8 Then
                                decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtAuxF)
                                decHNoct = CDec(FormatNumber(decMinuto / 60, 1))

                                decNocturna = decNocturna + decHNoct
                                dec100 = dec100 + decTotal
                            Else
                                decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtAuxF)
                                decHNoct = CDec(FormatNumber(decMinuto / 60, 1))

                                decNocturna = decNocturna + decHNoct
                                dec100 = dec100 + decTotal
                            End If
                        ElseIf decHoraInicio > 21 And decHoraFin < 5 Then
                            decMinuto = DateDiff(DateInterval.Minute, dtInicio, dtFin) '
                            decHNoct = CDec(FormatNumber(decMinuto / 60, 1))

                            decNocturna = decNocturna + decHNoct
                            dec100 = dec100 + decTotal
                        End If

                        'feriado trabajado sabado
                    Case "19"

                        If decTotal > 5 Then
                            'decEntero = Math.Truncate(decCociente)
                            'decResto = decCociente - decEntero

                            decParteExtra = decTotal - 5
                            decCociente = decParteExtra / CDec(0.5)
                            decMediaExtra = Math.Truncate(decCociente) * CDec(0.5)

                            decNormal = decNormal + decTotal - decMediaExtra
                            dec100 = dec100 + decMediaExtra
                        Else
                            decNormal = decNormal + decTotal
                        End If

                        decFeriado = decFeriado + 5

                        'If decTotal > 8 Then
                        '    decNormal = decNormal + 8
                        '    dec100 = dec100 + decTotal - 8
                        'Else
                        '    decNormal = decNormal + decTotal
                        'End If
                        'decFeriado = decFeriado + 8

                End Select
            End If
        Next
        Dim odt_empleado As New DataTable
        odt_empleado = oUsuario.GetOne(id_empleado)

        With oTemp1
            .Cargar()
            .Insertar()
            .legajo = odt_empleado.Rows(0).Item("legajo").ToString()
            .nombre_empleado = odt_empleado.Rows(0).Item("apellido").ToString() & ", " & odt_empleado.Rows(0).Item("nombre").ToString()
            .normal = decNormal
            .extra_50 = dec50
            .extra_100 = dec100
            .normal_30 = decNormal_30
            .extra_50_30 = decNormal_50
            .extra_100_30 = decNormal_100
            .nocturna = decNocturna
            .enfermedad = decEnfermedad
            .accidente = decAccidente
            .feriado = decFeriado
            .especial = decEspecial
            .Guardar()
        End With


        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Temp1_GetAll_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        'oda.SelectCommand.Parameters.Add("@id_movimiento_hora", SqlDbType.Int, 4, "id_movimiento_hora")
        'oda.SelectCommand.Parameters("@id_movimiento_hora").Value = id_movimiento_hora

        oda.Fill(odt)

        Return odt
    End Function

    'Public Function GetAllMovimiento_3(ByVal id_movimiento_hora As Integer, ByVal fecha As DateTime) As DataTable
    '    Dim odt As New DataTable
    '    Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_hora_GetAllMovimiento_3", cnn.Coneccion)

    '    oda.SelectCommand.CommandType = CommandType.StoredProcedure
    '    oda.SelectCommand.Parameters.Add("@id_movimiento_hora", SqlDbType.Int, 4, "id_movimiento_hora")
    '    oda.SelectCommand.Parameters("@id_movimiento_hora").Value = id_movimiento_hora
    '    oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 4, "fecha")
    '    oda.SelectCommand.Parameters("@fecha").Value = fecha
    '    oda.Fill(odt)
    '    Return odt
    'End Function
End Class
