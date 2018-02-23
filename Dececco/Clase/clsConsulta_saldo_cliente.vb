Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Consulta_saldo_cliente
    Inherits Consulta_saldo_cliente_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Consulta_saldo_cliente As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Consulta_saldo_cliente", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_consulta_saldo_cliente", SqlDbType.Int, 4, "id_consulta_saldo_cliente")
        oda.SelectCommand.Parameters("@id_consulta_saldo_cliente").Value = id_Consulta_saldo_cliente

        oda.Fill(odt)
        Return odt
    End Function

End Class
