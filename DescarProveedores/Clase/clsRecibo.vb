Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Recibo
    Inherits Recibo_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Recibo As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Recibo", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_recibo", SqlDbType.Int, 4, "id_recibo")
        oda.SelectCommand.Parameters("@id_recibo").Value = id_Recibo

        oda.Fill(odt)
        Return odt
    End Function

End Class
