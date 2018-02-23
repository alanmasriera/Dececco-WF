Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Precedencia
    Inherits Precedencia_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Precedencia As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Precedencia", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_precedencia", SqlDbType.Int, 4, "id_precedencia")
        oda.SelectCommand.Parameters("@id_precedencia").Value = id_Precedencia

        oda.Fill(odt)
        Return odt
    End Function

End Class
