Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Recibo_cliente
    Inherits Recibo_cliente_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Recibo_cliente As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Recibo_cliente", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_recibo_cliente", SqlDbType.Int, 4, "id_recibo_cliente")
        oda.SelectCommand.Parameters("@id_recibo_cliente").Value = id_Recibo_cliente

        oda.Fill(odt)
        Return odt
    End Function

End Class
