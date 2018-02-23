Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Marca
    Inherits Marca_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Marca As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Marca", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_marca", SqlDbType.Int, 4, "id_marca")
        oda.SelectCommand.Parameters("@id_marca").Value = id_Marca

        oda.Fill(odt)
        Return odt
    End Function

End Class
