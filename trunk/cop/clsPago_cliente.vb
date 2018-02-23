Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Pago_cliente
    Inherits Pago_cliente_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Pago_cliente As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Pago_cliente", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_pago_cliente", SqlDbType.Int, 4, "id_pago_cliente")
        oda.SelectCommand.Parameters("@id_pago_cliente").Value = id_Pago_cliente

        oda.Fill(odt)
        Return odt
    End Function

End Class
