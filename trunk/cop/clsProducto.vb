Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Producto
    Inherits Producto_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Producto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Producto", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_producto", SqlDbType.Int, 4, "id_producto")
        oda.SelectCommand.Parameters("@id_producto").Value = id_Producto

        oda.Fill(odt)
        Return odt
    End Function

End Class
