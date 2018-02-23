Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Tipo_hora
    Inherits Tipo_hora_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Tipo_hora As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_hora", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_tipo_hora", SqlDbType.Int, 4, "id_tipo_hora")
        oda.SelectCommand.Parameters("@id_tipo_hora").Value = id_Tipo_hora

        oda.Fill(odt)
        Return odt
    End Function

End Class
