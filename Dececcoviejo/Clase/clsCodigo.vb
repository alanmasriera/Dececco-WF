Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Codigo
    Inherits Codigo_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Codigo As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Codigo", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_codigo", SqlDbType.Int, 4, "id_codigo")
        oda.SelectCommand.Parameters("@id_codigo").Value = id_Codigo

        oda.Fill(odt)
        Return odt
    End Function

End Class
