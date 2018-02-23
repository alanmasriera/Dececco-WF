Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Remito
    Inherits Remito_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Remito As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Remito", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_remito", SqlDbType.Int, 4, "id_remito")
        oda.SelectCommand.Parameters("@id_remito").Value = id_Remito

        oda.Fill(odt)
        Return odt
    End Function

End Class
