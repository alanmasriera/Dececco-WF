Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Iva_venta_temp
    Inherits Iva_venta_temp_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Iva_venta_temp As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Iva_venta_temp", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_iva_venta_temp", SqlDbType.Int, 4, "id_iva_venta_temp")
        oda.SelectCommand.Parameters("@id_iva_venta_temp").Value = id_Iva_venta_temp

        oda.Fill(odt)
        Return odt
    End Function

    'inserta un registro en la tabla
    Public Sub SetIva(ByVal fecha As DateTime, ByVal numero As String)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Iva_venta_temp_SET"

        Command.CommandType = CommandType.StoredProcedure
        Command.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        Command.Parameters("@fecha").Value = fecha
        Command.Parameters.Add("@numero", SqlDbType.VarChar, 50, "numero")
        Command.Parameters("@numero").Value = numero

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    Public Function GetCierre(ByVal fecha As DateTime) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Iva_venta_temp_GetCierre", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = fecha

        oda.Fill(odt)
        Return odt
    End Function

End Class
