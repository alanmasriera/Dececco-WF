Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Factura_proveedor
    Inherits Factura_proveedor_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Factura_proveedor As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_proveedor", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_factura_proveedor", SqlDbType.Int, 4, "id_factura_proveedor")
        oda.SelectCommand.Parameters("@id_factura_proveedor").Value = id_Factura_proveedor

        oda.Fill(odt)
        Return odt
    End Function

End Class
