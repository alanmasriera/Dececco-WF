Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Moneda
    Inherits Moneda_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Moneda As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Moneda", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_moneda", SqlDbType.Int, 4, "id_moneda")
        oda.SelectCommand.Parameters("@id_moneda").Value = id_Moneda

        oda.Fill(odt)
        Return odt
    End Function

End Class
