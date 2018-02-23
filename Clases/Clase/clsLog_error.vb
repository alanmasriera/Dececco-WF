Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Log_error
    Inherits Log_error_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Log_error As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Log_error", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_log_error", SqlDbType.Int, 4, "id_log_error")
        oda.SelectCommand.Parameters("@id_log_error").Value = id_Log_error

        oda.Fill(odt)
        Return odt
    End Function

End Class
