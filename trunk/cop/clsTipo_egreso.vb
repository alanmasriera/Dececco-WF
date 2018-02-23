Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Tipo_egreso
    Inherits Tipo_egreso_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Tipo_egreso As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_egreso", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_tipo_egreso", SqlDbType.Int, 4, "id_tipo_egreso")
        oda.SelectCommand.Parameters("@id_tipo_egreso").Value = id_Tipo_egreso

        oda.Fill(odt)
        Return odt
    End Function

End Class
