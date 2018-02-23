Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Tipo_renglon
    Inherits Tipo_renglon_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Tipo_renglon As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_renglon", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_tipo_renglon", SqlDbType.Int, 4, "id_tipo_renglon")
        oda.SelectCommand.Parameters("@id_tipo_renglon").Value = id_Tipo_renglon

        oda.Fill(odt)
        Return odt
    End Function

End Class
