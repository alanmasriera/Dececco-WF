Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Recibo_cliente_cheque_2
    Inherits Recibo_cliente_cheque_2_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Recibo_cliente_cheque_2 As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Recibo_cliente_cheque_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_recibo_cliente_cheque_2", SqlDbType.Int, 4, "id_recibo_cliente_cheque_2")
        oda.SelectCommand.Parameters("@id_recibo_cliente_cheque_2").Value = id_Recibo_cliente_cheque_2

        oda.Fill(odt)
        Return odt
    End Function

End Class
