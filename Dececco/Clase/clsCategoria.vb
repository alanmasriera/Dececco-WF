Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Categoria
    Inherits Categoria_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Categoria As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Categoria", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_categoria", SqlDbType.Int, 4, "id_categoria")
        oda.SelectCommand.Parameters("@id_categoria").Value = id_Categoria

        oda.Fill(odt)
        Return odt
    End Function

End Class
