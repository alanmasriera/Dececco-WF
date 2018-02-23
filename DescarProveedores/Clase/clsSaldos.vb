Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Saldos
    Inherits Saldos_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Saldos As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Saldos", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_saldo", SqlDbType.Int, 4, "id_saldo")
        oda.SelectCommand.Parameters("@id_saldo").Value = id_Saldos

        oda.Fill(odt)
        Return odt
    End Function

End Class
