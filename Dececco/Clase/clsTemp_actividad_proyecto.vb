Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Temp_actividad_proyecto
    Inherits Temp_actividad_proyecto_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Temp_actividad_proyecto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Temp_actividad_proyecto", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_temp_actividad_proyecto", SqlDbType.Int, 4, "id_temp_actividad_proyecto")
        oda.SelectCommand.Parameters("@id_temp_actividad_proyecto").Value = id_Temp_actividad_proyecto

        oda.Fill(odt)
        Return odt
    End Function


    'borra todos los datos de la tabla
    Public Sub BorrarTemporal(ByVal id_usuario As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Temp_actividad_proyecto_DeleteTemporal"
        Command.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        Command.Parameters("@id_usuario").Value = id_usuario

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'ejemplo de consulta con parametros
    Public Function GetAllConsumida(ByVal id_usuario As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Temp_actividad_proyecto_GetAllConsumida", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = id_usuario

        oda.Fill(odt)
        Return odt
    End Function

End Class
