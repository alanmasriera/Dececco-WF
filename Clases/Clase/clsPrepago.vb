Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Prepago
    Inherits Prepago_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Prepago As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Prepago", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_prepago", SqlDbType.Int, 4, "id_prepago")
        oda.SelectCommand.Parameters("@id_prepago").Value = id_Prepago

        oda.Fill(odt)
        Return odt
    End Function

End Class
