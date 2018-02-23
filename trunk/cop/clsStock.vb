Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Stock
    Inherits Stock_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Stock As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Stock", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_stock", SqlDbType.Int, 4, "id_stock")
        oda.SelectCommand.Parameters("@id_stock").Value = id_Stock

        oda.Fill(odt)
        Return odt
    End Function

End Class
