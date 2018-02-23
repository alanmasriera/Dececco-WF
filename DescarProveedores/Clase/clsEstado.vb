Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Estado
    Inherits Estado_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Estado As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Estado", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_estado", SqlDbType.Int, 4, "id_estado")
        oda.SelectCommand.Parameters("@id_estado").Value = id_Estado

        oda.Fill(odt)
        Return odt
    End Function

End Class
