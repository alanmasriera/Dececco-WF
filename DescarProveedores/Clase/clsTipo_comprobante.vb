Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Tipo_comprobante
    Inherits Tipo_comprobante_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Tipo_comprobante As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_comprobante", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_tipo_comprobante", SqlDbType.Int, 4, "id_tipo_comprobante")
        oda.SelectCommand.Parameters("@id_tipo_comprobante").Value = id_Tipo_comprobante

        oda.Fill(odt)
        Return odt
    End Function

End Class
