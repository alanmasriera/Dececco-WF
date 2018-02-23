Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Orden_compra
    Inherits Orden_compra_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Orden_compra As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Orden_compra", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_orden_compra", SqlDbType.Int, 4, "id_orden_compra")
        oda.SelectCommand.Parameters("@id_orden_compra").Value = id_Orden_compra

        oda.Fill(odt)
        Return odt
    End Function

End Class
