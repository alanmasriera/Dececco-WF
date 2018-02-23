Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Detalle_recurso
    Inherits Detalle_recurso_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Detalle_recurso As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Detalle_recurso", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_detalle_recurso", SqlDbType.Int, 4, "id_detalle_recurso")
        oda.SelectCommand.Parameters("@id_detalle_recurso").Value = id_Detalle_recurso

        oda.Fill(odt)
        Return odt
    End Function

    'tareas pendientes
    Public Function GetPendiente(ByVal id_usuario As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Detalle_recurso_GetPendiente", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = id_usuario

        oda.Fill(odt)
        Return odt
    End Function

    'controla si existe el registro
    Public Function GetOneIngreso(ByVal id_actividad_proyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Detalle_recurso_GetOneIngreso", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_actividad_proyecto", SqlDbType.Int, 4, "id_actividad_proyecto")
        oda.SelectCommand.Parameters("@id_actividad_proyecto").Value = id_actividad_proyecto

        oda.Fill(odt)
        Return odt
    End Function

    Public Function ObtenerHorasAsignadasUsuario(ByVal id_usuario As Integer, ByVal fecha_inicio As DateTime, ByVal fecha_fin As DateTime) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_detalle_recurso_HorasAsignadasEntreFechasPorUsuario", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure

        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = id_usuario
        oda.SelectCommand.Parameters.Add("@fecha_inicio", SqlDbType.DateTime, 8, "fecha_inicio")
        oda.SelectCommand.Parameters("@fecha_inicio").Value = fecha_inicio
        oda.SelectCommand.Parameters.Add("@fecha_fin", SqlDbType.DateTime, 8, "fecha_fin")
        oda.SelectCommand.Parameters("@fecha_fin").Value = fecha_fin

        oda.Fill(odt)

        Return odt
    End Function

    Public Function VerificarNoTrabajaEntreHoras(ByVal id_usuario As Integer, ByVal fecha_inicio As DateTime, ByVal fecha_fin As DateTime) As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_detalle_recurso_verificarNoTrabajaEntreFechas", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure

        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = id_usuario
        oda.SelectCommand.Parameters.Add("@fecha_inicio", SqlDbType.DateTime, 8, "fecha_inicio")
        oda.SelectCommand.Parameters("@fecha_inicio").Value = fecha_inicio
        oda.SelectCommand.Parameters.Add("@fecha_fin", SqlDbType.DateTime, 8, "fecha_fin")
        oda.SelectCommand.Parameters("@fecha_fin").Value = fecha_fin

        oda.Fill(odt)

        If odt.Rows.Count > 0 Then
            Return False
        Else
            Return True
        End If

    End Function



    Public Function ObtenerCandidatosActividad(ByVal id_actividad_proyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_detalle_recurso_obtenerCandidatosActividad", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure

        oda.SelectCommand.Parameters.Add("@id_actividad_proyecto", SqlDbType.Int, 4, "id_actividad_proyecto")
        oda.SelectCommand.Parameters("@id_actividad_proyecto").Value = id_actividad_proyecto

        oda.Fill(odt)

        Return odt
    End Function

    Public Function ObtenerCandidatosActividadSinTiempo(ByVal id_actividad_proyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_detalle_recurso_obtenerCandidatosActividadSinTiempo", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure

        oda.SelectCommand.Parameters.Add("@id_actividad_proyecto", SqlDbType.Int, 4, "id_actividad_proyecto")
        oda.SelectCommand.Parameters("@id_actividad_proyecto").Value = id_actividad_proyecto

        oda.Fill(odt)

        Return odt
    End Function

    Public Function GetTodaInformacion(ByVal id_detalle_recurso As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_detalle_recurso_TodaInformacion", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_detalle_recurso", SqlDbType.Int, 4, "id_detalle_recurso")
        oda.SelectCommand.Parameters("@id_detalle_recurso").Value = id_detalle_recurso

        oda.Fill(odt)
        Return odt
    End Function

    Public Function GetFromActividad(ByVal id_actividad_proyecto As Integer) As Detalle_recurso
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_detalle_recurso_getFromActividad", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_actividad_proyecto", SqlDbType.Int, 4, "id_detalle_recurso")
        oda.SelectCommand.Parameters("@id_actividad_proyecto").Value = id_actividad_proyecto
        oda.Fill(odt)

        Dim aux As New Detalle_recurso
        If odt.Rows.Count > 0 Then
            aux.Modificar(CInt(odt.Rows(0).Item("id_detalle_recurso")))
        Else
            aux = Nothing
        End If

        Return aux
    End Function

    'pone como realizada una tarea
    Public Sub PonerRealizada(ByVal id_detalle_recurso As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Detalle_recurso_PonerRealizada"

        Command.CommandType = CommandType.StoredProcedure
        Command.Parameters.Add("@id_detalle_recurso", SqlDbType.Int, 4, "id_detalle_recurso")
        Command.Parameters("@id_detalle_recurso").Value = id_detalle_recurso

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'agregado para todas las tareas pendientes
    Public Function GetAllPendiente() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Detalle_recurso_GetAllPendiente", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)
        Return odt
    End Function


    'agregado para filtrar tarea por usuario
    Public Function GetPendienteUsuario(ByVal nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Detalle_recurso_GetPendienteUsuario", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = nombre

        oda.Fill(odt)
        Return odt
    End Function
End Class
