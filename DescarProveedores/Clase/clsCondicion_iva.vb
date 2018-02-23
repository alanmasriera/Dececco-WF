Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Condicion_iva
    Inherits Condicion_iva_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Condicion_iva As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Condicion_iva", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_condicion_iva", SqlDbType.Int, 4, "id_condicion_iva")
        oda.SelectCommand.Parameters("@id_condicion_iva").Value = id_Condicion_iva

        oda.Fill(odt)
        Return odt
    End Function

End Class
