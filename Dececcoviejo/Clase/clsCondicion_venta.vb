Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Condicion_venta
    Inherits Condicion_venta_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Condicion_venta As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Condicion_venta", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_condicion_venta", SqlDbType.Int, 4, "id_condicion_venta")
        oda.SelectCommand.Parameters("@id_condicion_venta").Value = id_Condicion_venta

        oda.Fill(odt)
        Return odt
    End Function

End Class
