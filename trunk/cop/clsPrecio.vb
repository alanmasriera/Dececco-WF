Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Precio
    Inherits Precio_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Precio As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Precio", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_precio", SqlDbType.Int, 4, "id_precio")
        oda.SelectCommand.Parameters("@id_precio").Value = id_Precio

        oda.Fill(odt)
        Return odt
    End Function

End Class
