Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Resumen_caja_temporal
    Inherits Resumen_caja_temporal_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Resumen_caja_temporal As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Resumen_caja_temporal", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_resumen_cuenta", SqlDbType.Int, 4, "id_resumen_cuenta")
        oda.SelectCommand.Parameters("@id_resumen_cuenta").Value = id_Resumen_caja_temporal

        oda.Fill(odt)
        Return odt
    End Function

    'get resumen
    Public Sub GetResumen(ByVal id_empresa As Integer, ByVal fecha As DateTime, ByVal id_cuenta As Integer, ByVal id_banco As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Resumen_caja_temporal_GetTemp"
        Command.Parameters.Add("@id_empresa", SqlDbType.Int, 4, "id_empresa")
        Command.Parameters("@id_empresa").Value = id_empresa
        Command.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        Command.Parameters("@fecha").Value = fecha
        Command.Parameters.Add("@id_cuenta", SqlDbType.Int, 4, "id_cuenta")
        Command.Parameters("@id_cuenta").Value = id_cuenta
        Command.Parameters.Add("@id_banco", SqlDbType.Int, 4, "id_banco")
        Command.Parameters("@id_banco").Value = id_banco

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'EJ PARA CONSULTAR CON PARAMETROS Y TRAER UN DECIMAL
    Public Function GetSum() As Decimal
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Resumen_caja_temporal_GetSum", cnn.Coneccion)
        Dim Total As Decimal

        oda.SelectCommand.CommandType = CommandType.StoredProcedure

        oda.Fill(odt)
        Total = CDec(odt.Rows(0).Item("Total"))
        Return Total
    End Function

    'realiza el resumen hasta la fecha ingresada
    Public Sub GetResumenContable(ByVal id_empresa As Integer, ByVal Fecha As DateTime, ByVal id_cuenta As Integer, ByVal id_banco As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Resumen_caja_temporal_GetTempContable"
        Command.Parameters.Add("@id_empresa", SqlDbType.Int, 4, "id_empresa")
        Command.Parameters("@id_empresa").Value = id_empresa
        Command.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        Command.Parameters("@fecha").Value = Fecha
        Command.Parameters.Add("@id_cuenta", SqlDbType.Int, 4, "id_cuenta")
        Command.Parameters("@id_cuenta").Value = id_cuenta
        Command.Parameters.Add("@id_banco", SqlDbType.Int, 4, "id_banco")
        Command.Parameters("@id_banco").Value = id_banco

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

End Class
