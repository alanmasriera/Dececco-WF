Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Dia
    Inherits Dia_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Dia As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Dia", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_dia", SqlDbType.Int, 4, "id_dia")
        oda.SelectCommand.Parameters("@id_dia").Value = id_Dia

        oda.Fill(odt)
        Return odt
    End Function

    'combo 2
    Public Function GetCmb_2() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Dia_GetCmb_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure

        oda.Fill(odt)
        Return odt
    End Function
End Class
