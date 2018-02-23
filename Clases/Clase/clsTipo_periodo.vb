Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Tipo_periodo
    Inherits Tipo_periodo_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Tipo_periodo As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_periodo", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_tipo_periodo", SqlDbType.Int, 4, "id_tipo_periodo")
        oda.SelectCommand.Parameters("@id_tipo_periodo").Value = id_Tipo_periodo

        oda.Fill(odt)
        Return odt
    End Function

End Class
