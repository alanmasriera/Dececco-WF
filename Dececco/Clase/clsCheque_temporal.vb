Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Cheque_temporal
    Inherits Cheque_temporal_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Cheque_temporal As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cheque_temporal", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_pk", SqlDbType.Int, 4, "id_pk")
        oda.SelectCommand.Parameters("@id_pk").Value = id_Cheque_temporal

        oda.Fill(odt)
        Return odt
    End Function

End Class
