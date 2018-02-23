Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Total_sueldo
    Inherits Total_sueldo_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Total_sueldo As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Total_sueldo", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_total_sueldo", SqlDbType.Int, 4, "id_total_sueldo")
        oda.SelectCommand.Parameters("@id_total_sueldo").Value = id_Total_sueldo

        oda.Fill(odt)
        Return odt
    End Function

    'ejemplo de consulta con parametros
    Public Function GetReporte(ByVal id_empleado As Integer, ByVal fecha_inicio As DateTime, ByVal fecha_fin As DateTime, ByVal tipo_sueldo As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Total_sueldo_GetReporte", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_empleado", SqlDbType.Int, 4, "id_empleado")
        oda.SelectCommand.Parameters("@id_empleado").Value = id_empleado
        oda.SelectCommand.Parameters.Add("@fecha_inicio", SqlDbType.DateTime, 8, "fecha_inicio")
        oda.SelectCommand.Parameters("@fecha_inicio").Value = fecha_inicio
        oda.SelectCommand.Parameters.Add("@fecha_fin", SqlDbType.DateTime, 8, "fecha_fin")
        oda.SelectCommand.Parameters("@fecha_fin").Value = fecha_fin
        oda.SelectCommand.Parameters.Add("@tipo_sueldo", SqlDbType.Char, 1, "tipo_sueldo")
        oda.SelectCommand.Parameters("@tipo_sueldo").Value = tipo_sueldo

        oda.Fill(odt)
        Return odt
    End Function

    'borra si existe
    Public Sub DeleteExistente(ByVal id_empleado As Integer, ByVal fecha_inicio As DateTime, ByVal fecha_fin As DateTime)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Total_sueldo_DeleteExistente"
        Command.Parameters.Add("@id_empleado", SqlDbType.Int, 4, "id_empleado")
        Command.Parameters("@id_empleado").Value = id_empleado
        Command.Parameters.Add("@fecha_inicio", SqlDbType.DateTime, 8, "fecha_inicio")
        Command.Parameters("@fecha_inicio").Value = fecha_inicio
        Command.Parameters.Add("@fecha_fin", SqlDbType.DateTime, 8, "fecha_fin")
        Command.Parameters("@fecha_fin").Value = fecha_fin

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra si existe aguinaldo
    Public Sub DeleteExistenteAguinaldo(ByVal id_empleado As Integer, ByVal fecha_inicio As DateTime, ByVal fecha_fin As DateTime, ByVal tipo_sueldo As String)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Total_sueldo_DeleteExistenteAguinaldo"
        Command.Parameters.Add("@id_empleado", SqlDbType.Int, 4, "id_empleado")
        Command.Parameters("@id_empleado").Value = id_empleado
        Command.Parameters.Add("@fecha_inicio", SqlDbType.DateTime, 8, "fecha_inicio")
        Command.Parameters("@fecha_inicio").Value = fecha_inicio
        Command.Parameters.Add("@fecha_fin", SqlDbType.DateTime, 8, "fecha_fin")
        Command.Parameters("@fecha_fin").Value = fecha_fin
        Command.Parameters.Add("@tipo_sueldo", SqlDbType.Char, 1, "tipo_sueldo")
        Command.Parameters("@tipo_sueldo").Value = tipo_sueldo

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'ejemplo de consulta con parametros
    Public Function GetAguinaldo(ByVal id_empleado As Integer, ByVal fecha As DateTime) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Total_sueldo_GetAguinaldo", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_empleado", SqlDbType.Int, 4, "id_empleado")
        oda.SelectCommand.Parameters("@id_empleado").Value = id_empleado
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = fecha
 
        oda.Fill(odt)
        Return odt
    End Function


End Class
