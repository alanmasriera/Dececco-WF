Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Iva_compra
    Inherits Iva_compra_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Iva_compra As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Iva_compra", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_iva_compra", SqlDbType.Int, 4, "id_iva_compra")
        oda.SelectCommand.Parameters("@id_iva_compra").Value = id_Iva_compra

        oda.Fill(odt)
        Return odt
    End Function

    'controla si el periodo esta cerrado
    Public Function GetOneDate(ByVal fecha As DateTime) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Iva_compra_GetOneDate", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = fecha

        oda.Fill(odt)
        Return odt
    End Function

    Public Sub DeleteCierre(ByVal fecha As DateTime)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Iva_compra_DeleteCierre"

        Command.CommandType = CommandType.StoredProcedure
        Command.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        Command.Parameters("@fecha").Value = fecha

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

End Class
