Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Calendario
    Inherits Calendario_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Calendario As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Calendario", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_calendario", SqlDbType.Int, 4, "id_calendario")
        oda.SelectCommand.Parameters("@id_calendario").Value = id_Calendario

        oda.Fill(odt)
        Return odt
    End Function

    'consulta los items del año
    Public Function GetAnio() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Calendario_GetAnio", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure

        oda.Fill(odt)
        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist_2(ByVal fecha As DateTime) As Integer
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Calendario_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = fecha


        oda.Fill(odt)
        Total = CInt(odt.Rows(0).Item("Total").ToString)
        If Total = 0 Then
            Return 0  'NO EXISTE
        Else
            Return Total 'SI EXISTE
        End If
    End Function

    'funcion de consulta
    Public Function GetAll_2(ByVal anio As Decimal, ByVal id_dia As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Calendario_GetAll_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@anio", SqlDbType.Decimal, 9, "anio")
        oda.SelectCommand.Parameters("@anio").Value = anio

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function GetAllAnio(ByVal anio As Decimal) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Calendario_GetAllAnio", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@anio", SqlDbType.Decimal, 9, "anio")
        oda.SelectCommand.Parameters("@anio").Value = anio

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de busqueda
    Public Function Find_2(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Calendario_Find_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'actualiza segun la fecha
    Public Sub UpdateFecha(ByVal fecha As DateTime)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Calendario_UpdateFecha"

        Command.CommandType = CommandType.StoredProcedure
        Command.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        Command.Parameters("@fecha").Value = fecha


        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub
End Class




