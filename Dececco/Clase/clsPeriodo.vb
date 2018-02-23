Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Periodo
    Inherits Periodo_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Periodo As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Periodo", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_periodo", SqlDbType.Int, 4, "id_periodo")
        oda.SelectCommand.Parameters("@id_periodo").Value = id_Periodo

        oda.Fill(odt)
        Return odt
    End Function

End Class
