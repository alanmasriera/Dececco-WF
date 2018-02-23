Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Calendario_usuario
    Inherits Calendario_usuario_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Calendario_usuario As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Calendario_usuario", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_calendario_usuario", SqlDbType.Int, 4, "id_calendario_usuario")
        oda.SelectCommand.Parameters("@id_calendario_usuario").Value = id_Calendario_usuario

        oda.Fill(odt)
        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist_2(ByVal id_usuario As Integer, ByVal fecha As DateTime, ByVal id_dia As Integer, ByVal anio As Decimal) As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Calendario_usuario_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = id_usuario
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = fecha
        oda.SelectCommand.Parameters.Add("@id_dia", SqlDbType.Int, 4, "id_dia")
        oda.SelectCommand.Parameters("@id_dia").Value = id_dia
        oda.SelectCommand.Parameters.Add("@anio", SqlDbType.Decimal, 9, "anio")
        oda.SelectCommand.Parameters("@anio").Value = anio

        oda.Fill(odt)
        Total = CInt(odt.Rows(0).Item("Total").ToString)
        If Total = 0 Then
            Return False  'NO EXISTE
        Else
            Return True 'SI EXISTE
        End If
    End Function

    'funcion de consulta
    Public Function GetAll_3(ByVal anio As Decimal, ByVal id_dia As Integer, ByVal id_usuario As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Calendario_usuario_GetAll_3", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure

        oda.SelectCommand.Parameters.Add("@anio", SqlDbType.Decimal, 9, "anio")
        oda.SelectCommand.Parameters("@anio").Value = anio
        oda.SelectCommand.Parameters.Add("@id_dia", SqlDbType.Int, 4, "id_dia")
        oda.SelectCommand.Parameters("@id_dia").Value = id_dia
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = id_usuario

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de busqueda
    Public Function Find_2(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Calendario_usuario_Find_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'actualiza segun la fecha
    Public Sub UpdateFecha(ByVal fecha As DateTime, ByVal id_dia As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Calendario_usuario_UpdateFecha"

        Command.CommandType = CommandType.StoredProcedure
        Command.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        Command.Parameters("@fecha").Value = fecha
        Command.Parameters.Add("@id_dia", SqlDbType.Int, 4, "id_dia")
        Command.Parameters("@id_dia").Value = id_dia

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'actualiza segun la fecha
    Public Sub UpdateFechaUsuario(ByVal fecha As DateTime, ByVal id_dia As Integer, ByVal id_usuario As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Calendario_usuario_UpdateFechaUsuario"

        Command.CommandType = CommandType.StoredProcedure
        Command.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        Command.Parameters("@fecha").Value = fecha
        Command.Parameters.Add("@id_dia", SqlDbType.Int, 4, "id_dia")
        Command.Parameters("@id_dia").Value = id_dia
        Command.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        Command.Parameters("@id_usuario").Value = id_usuario

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'funcion de consulta
    Public Function GetDia(ByVal fecha As DateTime, ByVal id_usuario As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Calendario_usuario_GetDia", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure

        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = fecha
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = id_usuario

        oda.Fill(odt)

        Return odt
    End Function
End Class



