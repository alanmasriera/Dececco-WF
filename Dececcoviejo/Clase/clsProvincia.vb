Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Provincia
    Inherits Provincia_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Provincia As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Provincia", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_provincia", SqlDbType.Int, 4, "id_provincia")
        oda.SelectCommand.Parameters("@id_provincia").Value = id_Provincia

        oda.Fill(odt)
        Return odt
    End Function

End Class
