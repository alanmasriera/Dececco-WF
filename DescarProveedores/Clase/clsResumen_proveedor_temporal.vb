Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Resumen_proveedor_temporal
    Inherits Resumen_proveedor_temporal_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Resumen_proveedor_temporal As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Resumen_proveedor_temporal", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_resumen_PROVEEDOR_temporal", SqlDbType.Int, 4, "id_resumen_PROVEEDOR_temporal")
        oda.SelectCommand.Parameters("@id_resumen_PROVEEDOR_temporal").Value = id_Resumen_proveedor_temporal

        oda.Fill(odt)
        Return odt
    End Function

End Class
