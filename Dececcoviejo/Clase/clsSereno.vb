Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Sereno
    Inherits Sereno_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Sereno As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Sereno", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_sereno", SqlDbType.Int, 4, "id_sereno")
        oda.SelectCommand.Parameters("@id_sereno").Value = id_Sereno

        oda.Fill(odt)
        Return odt
    End Function

End Class
