Public Class TaskManager

    Public Sub AsignarProyectoAUsuario(ByVal id_proyecto As Integer, ByVal id_usuario As Integer)
        Dim _Proyecto As New Proyecto
        Dim _Subproyecto As New entSubproyecto
        Dim _Actividad_Proyecto As New Actividad_proyecto
        Dim _Calendario_Usuario As New Calendario_usuario
        Dim _Actividad As New Actividad

        Dim fecha_actual_asignacion As Date

        With _Proyecto
            .Cargar()
            .Modificar(id_proyecto)
            fecha_actual_asignacion = New Date(.fecha_inicio.Year, .fecha_inicio.Month, .fecha_inicio.Day, 8, 0, 0)
        End With

        'Asume que no tiene otras asignaciones

        Dim dt_subproyectos As DataTable
        Dim dt_actividades As DataTable

        dt_subproyectos = _Subproyecto.ObtenerTodosPorProyecto(id_proyecto)

        'For Each row_subproyecto As DataRow In dt_subproyectos.Rows
        'With _Subproyecto
        '    .Cargar()
        '    .Modificar(CInt(row_subproyecto.Item("id_subproyecto")))
        'End With
        Me.AsignarSubproyecto(1)
        'dt_actividades = _Actividad_Proyecto.GetAllProyecto(0, _Subproyecto.id_suproyecto, 0)

        'For i As Integer = 0 To dt_actividades.Rows.Count
        '    With _Actividad_Proyecto
        '        .Cargar()
        '        .Modificar(CInt(dt_actividades.Rows(i).Item("id_actividad_proyecto")))
        '    End With
        'Next


        'Next

        'dt_actividades = _Actividad_Proyecto.GetAllProyectoConHijos(id_proyecto)
        'Dim horas_disponible_dia As Decimal = 0
        'Dim horas_total As Decimal = 0
        'Dim horas_restantes As Decimal = 0
        'Dim dt_horas As DataTable


        'For Each row As DataRow In dt_actividades.Rows
        '    If CInt(row.Item("id_subproyecto")) <> 0 Then
        '        With _Subproyecto
        '            .Cargar()
        '            .Modificar(CInt(row.Item("id_subproyecto")))
        '        End With

        '        With _Actividad_Proyecto
        '            .Cargar()
        '            .Modificar(CInt(row.Item("id_actividad_proyecto")))

        '            With _Actividad
        '                .Cargar()
        '                .Modificar(_Actividad_Proyecto.id_actividad)
        '            End With

        '            Me.AsignarTarea(.id_actividad_proyecto, id_usuario, fecha_actual_asignacion, _Actividad.costo_standart * _Subproyecto.horas_estimadas / 100)
        '            horas_restantes = _Actividad.costo_standart * _Subproyecto.horas_estimadas / 100
        '            dt_horas = _Calendario_Usuario.ObtenerPorDesdeFechaUsuario(fecha_actual_asignacion, id_usuario)

        '            For Each row_horas As DataRow In dt_horas.Rows

        '                horas_disponible_dia = CDec(row_horas.Item("cantidad_horas"))

        '                Dim horas_para_actividad As Decimal = CDec(DateDiff(DateInterval.Second, fecha_actual_asignacion, CDate(row_horas.Item("hora_fin"))) / 60 / 60)
        '                If horas_restantes > horas_para_actividad Then
        '                    horas_restantes = horas_restantes - horas_para_actividad
        '                    fecha_actual_asignacion = CDate(dt_horas.Rows(dt_horas.Rows().IndexOf(row_horas) + 1).Item("hora_inicio"))
        '                Else
        '                    Dim fecha_fin As Date = CDate(row_horas.Item("hora_inicio"))

        '                    fecha_actual_asignacion = DateAdd(DateInterval.Second, horas_restantes * 60 * 60, New Date(fecha_fin.Year, fecha_fin.Month, fecha_fin.Day, fecha_actual_asignacion.Hour, fecha_actual_asignacion.Minute, fecha_actual_asignacion.Second))

        '                    .Modificar(CInt(row.Item("id_actividad_proyecto")))
        '                    .fecha_fin_previsto = fecha_actual_asignacion
        '                    .Guardar()
        '                    Exit For
        '                End If
        '            Next
        '        End With
        '    End If
        'Next

    End Sub

    Private Sub AsignarTarea(ByVal id_actividad_proyecto As Integer, ByVal id_usuario As Integer, ByVal fecha_inicio As Date, ByVal cantidad_horas As Decimal, ByVal fecha_fin As DateTime)

        Dim _Actividad_proyecto As New Actividad_proyecto
        Dim _Detalle_Recurso As New Detalle_recurso

        With _Actividad_proyecto
            .Cargar()
            .Modificar(id_actividad_proyecto)
            .asignada = True
            .Guardar()
        End With

        Try
            With _Detalle_Recurso
                .Cargar()
                .Insertar()
                .id_actividad_proyecto = id_actividad_proyecto
                .id_usuario = id_usuario
                .motivo = ""
                .cantidad_hora = cantidad_horas
                .porcentaje_avance = 0
                .realizada = False
                .fecha_inicio = fecha_inicio
                .fecha_fin = fecha_fin
                .tipo = "-"
                .Guardar()
            End With

        Catch ex As Exception

        End Try

    End Sub

    Public Function CalcularCantidadDias(ByVal id_usuario As Integer, ByVal fecha_inicio As Date, ByVal cantidad_horas As Decimal) As DateTime
        Dim _Detalle_Recurso As New Detalle_recurso

        Dim dt_horas As DataTable
        Dim _Calendario_Usuario As New Calendario_usuario
        Dim fecha_actual_asignacion As Date = fecha_inicio
        Dim horas_restantes As Decimal = cantidad_horas
        Dim horas_disponible_dia As Decimal
        Dim ok As Boolean = False

        dt_horas = _Calendario_Usuario.ObtenerPorDesdeFechaUsuario(fecha_actual_asignacion, id_usuario)

        For Each row_horas As DataRow In dt_horas.Rows

            horas_disponible_dia = CDec(row_horas.Item("cantidad_horas"))

            Dim horas_para_actividad As Decimal = CDec(DateDiff(DateInterval.Second, fecha_actual_asignacion, CDate(row_horas.Item("hora_fin"))) / 60 / 60)
            If horas_restantes > horas_para_actividad Then
                horas_restantes = horas_restantes - horas_para_actividad
                fecha_actual_asignacion = CDate(dt_horas.Rows(dt_horas.Rows().IndexOf(row_horas) + 1).Item("hora_inicio"))
            Else
                Dim fecha_fin As Date = CDate(row_horas.Item("hora_inicio"))
                Dim fecha_fin_anterior As Date = CDate(row_horas.Item("hora_fin"))

                If fecha_actual_asignacion <= fecha_fin_anterior And fecha_actual_asignacion >= fecha_fin Then
                    ok = True
                End If

                If ok = True Then
                    fecha_actual_asignacion = DateAdd(DateInterval.Second, horas_restantes * 60 * 60, New Date(fecha_fin.Year, fecha_fin.Month, fecha_fin.Day, fecha_actual_asignacion.Hour, fecha_actual_asignacion.Minute, fecha_actual_asignacion.Second))
                Else
                    fecha_actual_asignacion = DateAdd(DateInterval.Second, horas_restantes * 60 * 60, New Date(fecha_fin.Year, fecha_fin.Month, fecha_fin.Day, fecha_fin.Hour, fecha_fin.Minute, fecha_fin.Second))
                End If
                Exit For
            End If
        Next

        Return fecha_actual_asignacion

    End Function

    Private Sub AsignarSubproyecto(ByVal id_subproyecto As Integer)
        Dim _Detalle_recurso As New Detalle_recurso
        Dim _Calendario_Usuario As New Calendario_usuario
        Dim _Actividad_Proyecto As New Actividad_proyecto

        Dim odt_total_horas_usuario As DataTable
        Dim odt_total_horas As DataTable
        Dim odt_tota_horas_asignadas_usuario As DataTable
        Dim odt_candidatos_actividad As DataTable
        Dim odt_actividades_subproyecto As DataTable

        Dim fecha_inicio As Date
        Dim fecha_fin As Date
        Dim id_usuario As Integer
        Dim id_actividad_proyecto As Integer
        Dim cantidad_horas As Decimal
        Dim hora_inicio_asignar As Date

        Dim asignada As Boolean
        Dim salida As String = ""

        'Horas de un usuario específico
        'odt_total_horas_usuario = _Calendario_Usuario.ObtenerHorasDisponiblesUsuario(id_usuario, fecha_inicio, fecha_fin)

        'Horas entre fechas para todos los usuarios
        'odt_total_horas = _Calendario_Usuario.ObtenerHorasDisponiblesEntreFechas(fecha_inicio, fecha_fin)


        'odt_tota_horas_asignadas_usuario = _Detalle_recurso.ObtenerHorasAsignadasUsuario(id_usuario, fecha_inicio, fecha_fin)
        'odt_candidatos_actividad = _Detalle_recurso.ObtenerCandidatosActividad(id_actividad_proyecto)


        'odt_actividades_subproyecto = _Actividad_Proyecto.GetActividadesSubproyectosOrdenadosPorCantidadHoras_ConHijos(id_subproyecto)
        odt_actividades_subproyecto = _Actividad_Proyecto.GetActividadesTodosProyectosOrdenadosPorCantidadHoras_ConHijos()
        For Each row_actividad_subproyecto As DataRow In odt_actividades_subproyecto.Rows
            id_actividad_proyecto = CInt(row_actividad_subproyecto.Item("id_actividad_proyecto"))

            asignada = False

            With _Actividad_Proyecto
                .Cargar()
                .Modificar(id_actividad_proyecto)
            End With

            odt_candidatos_actividad = _Detalle_recurso.ObtenerCandidatosActividad(id_actividad_proyecto)
            If odt_candidatos_actividad.Rows.Count > 0 Then
                For Each row_candidato As DataRow In odt_candidatos_actividad.Rows
                    hora_inicio_asignar = CDate(row_candidato.Item("fecha_inicio"))
                    cantidad_horas = CDec(row_candidato.Item("horas_actividad"))
                    id_usuario = CInt(row_candidato.Item("id_usuario"))
                    fecha_fin = CalcularCantidadDias(id_usuario, hora_inicio_asignar, cantidad_horas)

                    With _Actividad_Proyecto
                        If .forzada_fecha_fin Then
                            If fecha_fin > .fecha_fin_previsto Then
                                Continue For
                            End If
                        End If
                    End With

                    If _Detalle_recurso.VerificarNoTrabajaEntreHoras(id_usuario, hora_inicio_asignar, fecha_fin) Then
                        Me.AsignarTarea(id_actividad_proyecto, id_usuario, hora_inicio_asignar, cantidad_horas, fecha_fin)
                        asignada = True
                        Exit For
                    End If
                Next

                If asignada = False Then
                    MessageBox.Show("No se llega con el tiempo")
                End If
            Else
                salida = salida & " - " & id_actividad_proyecto
                odt_candidatos_actividad = _Detalle_recurso.ObtenerCandidatosActividadSinTiempo(id_actividad_proyecto)
                If odt_candidatos_actividad.Rows.Count > 0 Then
                    'MessageBox.Show("Excede la fecha " & id_actividad_proyecto)
                    'For Each row_candidato As DataRow In odt_candidatos_actividad.Rows
                    '    hora_inicio_asignar = CDate(row_candidato.Item("fecha_inicio"))
                    '    cantidad_horas = CDec(row_candidato.Item("horas_actividad"))
                    '    id_usuario = CInt(row_candidato.Item("id_usuario"))
                    '    Me.AsignarTarea(id_actividad_proyecto, id_usuario, hora_inicio_asignar, cantidad_horas, fecha_fin)
                    '    Exit For
                    'Next
                Else
                    'MessageBox.Show("Actividad sin candidatos " & id_actividad_proyecto)
                End If
            End If

        Next
        MessageBox.Show(salida)
    End Sub
End Class
