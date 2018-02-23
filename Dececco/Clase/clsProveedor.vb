Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Proveedor
    Inherits Proveedor_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Proveedor As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Proveedor", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proveedor", SqlDbType.Int, 4, "id_proveedor")
        oda.SelectCommand.Parameters("@id_proveedor").Value = id_Proveedor

        oda.Fill(odt)
        Return odt
    End Function

End Class
