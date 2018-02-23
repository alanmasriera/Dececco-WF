Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Unidad
    Inherits Unidad_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Unidad As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Unidad", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_unidad", SqlDbType.Int, 4, "id_unidad")
        oda.SelectCommand.Parameters("@id_unidad").Value = id_Unidad

        oda.Fill(odt)
        Return odt
    End Function

End Class
