Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Temp_grilla_pago_cliente
    Inherits Temp_grilla_pago_cliente_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Temp_grilla_pago_cliente As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Temp_grilla_pago_cliente", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_temp_grilla_pago_cliente", SqlDbType.Int, 4, "id_temp_grilla_pago_cliente")
        oda.SelectCommand.Parameters("@id_temp_grilla_pago_cliente").Value = id_Temp_grilla_pago_cliente

        oda.Fill(odt)
        Return odt
    End Function

End Class
