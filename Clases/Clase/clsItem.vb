Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Item
    Inherits Item_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Item As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Item", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_item", SqlDbType.Int, 4, "id_item")
        oda.SelectCommand.Parameters("@id_item").Value = id_Item

        oda.Fill(odt)
        Return odt
    End Function

End Class
