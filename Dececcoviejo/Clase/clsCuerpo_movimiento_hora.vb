Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Cuerpo_movimiento_hora
    Inherits Cuerpo_movimiento_hora_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Cuerpo_movimiento_hora As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_hora", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cuerpo_movimiento_hora", SqlDbType.Int, 4, "id_cuerpo_movimiento_hora")
        oda.SelectCommand.Parameters("@id_cuerpo_movimiento_hora").Value = id_Cuerpo_movimiento_hora

        oda.Fill(odt)
        Return odt
    End Function


    'borra todo el cuerpo de la Movimiento_hora
    Public Sub DeleteMovimiento_hora(ByVal id_Movimiento_hora As Integer, ByVal extra As Boolean)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Cuerpo_Movimiento_hora_DeleteMovimiento_hora"

        Command.CommandType = CommandType.StoredProcedure
        Command.Parameters.Add("@id_Movimiento_hora", SqlDbType.Int, 4, "id_Movimiento_hora")
        Command.Parameters("@id_Movimiento_hora").Value = id_Movimiento_hora
        'Command.Parameters.Add("@extra", SqlDbType.Bit, 1, "extra")
        'Command.Parameters("@extra").Value = extra

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'update id
    Public Sub UpdateID(ByVal id_Movimiento_hora As Integer, ByVal extra As Boolean)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Cuerpo_Movimiento_hora_UpdateID"

        Command.CommandType = CommandType.StoredProcedure
        Command.Parameters.Add("@id_Movimiento_hora", SqlDbType.Int, 4, "id_cuerpo_Movimiento_hora")
        Command.Parameters("@id_Movimiento_hora").Value = id_Movimiento_hora
        'Command.Parameters.Add("@extra", SqlDbType.Bit, 1, "extra") no esta como parametro en procedimiento
        'Command.Parameters("@extra").Value = extra

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'grilla
    Public Function GetAllMovimiento(ByVal id_movimiento_hora As Integer, ByVal extra As Boolean) As DataTable
        Dim odt As New DataTable
        'Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_hora_GetAllMovimiento_2", cnn.Coneccion)
        Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_hora_GetAllMovimiento", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_movimiento_hora", SqlDbType.Int, 4, "id_movimiento_hora")
        oda.SelectCommand.Parameters("@id_movimiento_hora").Value = id_movimiento_hora
        'oda.SelectCommand.Parameters.Add("@extra", SqlDbType.Bit, 4, "extra")
        'oda.SelectCommand.Parameters("@extra").Value = extra
        oda.Fill(odt)
        Return odt
    End Function

    'control de horas
    Public Function GetAllMovimientoControl(ByVal id_movimiento_hora As Integer, ByVal extra As Boolean) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_hora_GetAllMovimientoControl", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_movimiento_hora", SqlDbType.Int, 4, "id_movimiento_hora")
        oda.SelectCommand.Parameters("@id_movimiento_hora").Value = id_movimiento_hora
        'oda.SelectCommand.Parameters.Add("@extra", SqlDbType.Bit, 1, "extra")
        'oda.SelectCommand.Parameters("@extra").Value = extra

        oda.Fill(odt)
        Return odt
    End Function

    'control de horas consumidas
    Public Function GetAllConsumida(ByVal id_usuario As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_hora_GetAllConsumida", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = id_usuario

        oda.Fill(odt)
        Return odt
    End Function

    Public Function GetOne_2(ByVal id_Cuerpo_movimiento_hora As Integer, ByVal fin As DateTime) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_hora_GetOne_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cuerpo_movimiento_hora", SqlDbType.Int, 4, "id_cuerpo_movimiento_hora")
        oda.SelectCommand.Parameters("@id_cuerpo_movimiento_hora").Value = id_Cuerpo_movimiento_hora
        oda.SelectCommand.Parameters.Add("@fin", SqlDbType.DateTime, 8, "fin")
        oda.SelectCommand.Parameters("@fin").Value = fin
        oda.Fill(odt)

        Return odt
    End Function

    Public Function GetOne_Act(ByVal id_Cuerpo_movimiento_hora As Integer, ByVal id_actividad_proyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_hora_GetOne_3", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cuerpo_movimiento_hora", SqlDbType.Int, 4, "id_cuerpo_movimiento_hora")
        oda.SelectCommand.Parameters("@id_cuerpo_movimiento_hora").Value = id_Cuerpo_movimiento_hora
        oda.SelectCommand.Parameters.Add("@id_actividad_proyecto", SqlDbType.Int, 4, " id_actividad_proyecto ")
        oda.SelectCommand.Parameters("@id_actividad_proyecto").Value = id_actividad_proyecto

        oda.Fill(odt)

        Return odt
    End Function

    'control de horas
    Public Function GetLogin(ByVal id_usuario As Integer, ByVal fecha As Date, ByRef entrada As Date) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_hora_EstaLogueado", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = id_usuario
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = fecha
        oda.SelectCommand.Parameters.Add("@entrada", SqlDbType.DateTime, 8, "entrada")
        oda.SelectCommand.Parameters("@entrada").Value = entrada
        oda.Fill(odt)
        Return odt
    End Function

    Public Function GetLogueoDia(ByVal id_usuario As Integer, ByVal fecha_inicio As Date, ByVal fecha_fin As Date, ByVal id_cliente As Integer, ByVal id_proyecto As Integer) As DataTable
        Dim odt As New DataTable

        Dim oda As New SqlDataAdapter("cop_cuerpo_movimiento_hora_getLogueoDia", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = id_usuario
        oda.SelectCommand.Parameters.Add("@fecha_inicio", SqlDbType.DateTime, 8, "fecha_inicio")
        oda.SelectCommand.Parameters("@fecha_inicio").Value = fecha_inicio
        oda.SelectCommand.Parameters.Add("@fecha_fin", SqlDbType.DateTime, 8, "fecha_fin")
        oda.SelectCommand.Parameters("@fecha_fin").Value = fecha_fin
        oda.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.Int, 4, "id_cliente")
        oda.SelectCommand.Parameters("@id_cliente").Value = id_cliente
        oda.SelectCommand.Parameters.Add("@id_proyecto", SqlDbType.Int, 4, "id_proyecto")
        oda.SelectCommand.Parameters("@id_proyecto").Value = id_proyecto

        oda.Fill(odt)
        Return odt
    End Function

    Public Function GetLogueoActual() As DataTable
        Dim odt As New DataTable

        Dim oda As New SqlDataAdapter("cop_cuerpo_movimiento_hora_getLogueosActuales", cnn.Coneccion)
        oda.SelectCommand.CommandType = CommandType.StoredProcedure


        oda.Fill(odt)
        Return odt
    End Function

    Public Function ObtenerPorusuarioYFecha(ByVal id_usuario As Integer, ByVal fecha As Date) As DataTable
        Dim odt As New DataTable

        Dim oda As New SqlDataAdapter("cop_cuerpo_movimiento_hora_obtenerPorUsuarioYFecha", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = id_usuario
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = fecha

        oda.Fill(odt)
        Return odt
    End Function



    Public Function GetAllPorActividadProyecto(ByVal id_actividad_proyecto As Integer, ByVal id_usuario As Integer) As DataTable
        Dim odt As New DataTable

        Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_hora_GetAllConsumida_ActividadProyecto", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_actividad_proyecto", SqlDbType.Int, 4, "id_actividad_proyecto")
        oda.SelectCommand.Parameters("@id_actividad_proyecto").Value = id_actividad_proyecto
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = id_usuario

        oda.Fill(odt)
        Return odt
    End Function

    Public Function GetAllPorDetalleRecurso(ByVal id_detalle_recurso As Integer, ByVal id_usuario As Integer) As DataTable
        Dim odt As New DataTable

        Dim oda As New SqlDataAdapter("cop_Cuerpo_movimiento_hora_GetAllConsumida_detalleRecurso", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_detalle_recurso", SqlDbType.Int, 4, "id_detalle_recurso")
        oda.SelectCommand.Parameters("@id_detalle_recurso").Value = id_detalle_recurso
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = id_usuario

        oda.Fill(odt)
        Return odt
    End Function

End Class
