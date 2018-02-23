Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Mensual
    Inherits Mensual_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Mensual As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Mensual", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_mensual", SqlDbType.Int, 4, "id_mensual")
        oda.SelectCommand.Parameters("@id_mensual").Value = id_Mensual

        oda.Fill(odt)
        Return odt
    End Function

End Class
