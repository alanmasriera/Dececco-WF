Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Calle
    Inherits Calle_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Calle As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Calle", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_calle", SqlDbType.Int, 4, "id_calle")
        oda.SelectCommand.Parameters("@id_calle").Value = id_Calle

        oda.Fill(odt)
        Return odt
    End Function

End Class
