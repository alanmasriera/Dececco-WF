Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Tipo_proveedor
    Inherits Tipo_proveedor_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Tipo_proveedor As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_proveedor", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_tipo_proveedor", SqlDbType.Int, 4, "id_tipo_proveedor")
        oda.SelectCommand.Parameters("@id_tipo_proveedor").Value = id_Tipo_proveedor

        oda.Fill(odt)
        Return odt
    End Function

End Class
