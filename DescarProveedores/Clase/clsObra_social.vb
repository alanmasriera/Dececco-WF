Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Obra_social
    Inherits Obra_social_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Obra_social As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Obra_social", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_obra_social", SqlDbType.Int, 4, "id_obra_social")
        oda.SelectCommand.Parameters("@id_obra_social").Value = id_Obra_social

        oda.Fill(odt)
        Return odt
    End Function

End Class
