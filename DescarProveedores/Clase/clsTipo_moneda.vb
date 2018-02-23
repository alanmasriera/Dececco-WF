Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Tipo_moneda
    Inherits Tipo_moneda_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Tipo_moneda As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_moneda", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_tipo_moneda", SqlDbType.Int, 4, "id_tipo_moneda")
        oda.SelectCommand.Parameters("@id_tipo_moneda").Value = id_Tipo_moneda

        oda.Fill(odt)
        Return odt
    End Function

End Class
