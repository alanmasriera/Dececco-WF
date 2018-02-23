Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Obra
    Inherits Obra_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Obra As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Obra", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_obra", SqlDbType.Int, 4, "id_obra")
        oda.SelectCommand.Parameters("@id_obra").Value = id_Obra

        oda.Fill(odt)
        Return odt
    End Function

    'combo 2
    Public Function GetCmb_2() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Obra_GetCmb_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure

        oda.Fill(odt)
        Return odt
    End Function

    'getone 2
    Public Function GetOne_2(ByVal id_Obra As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Obra_GetOne_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_obra", SqlDbType.Int, 4, "id_obra")
        oda.SelectCommand.Parameters("@id_obra").Value = id_Obra

        oda.Fill(odt)
        Return odt
    End Function

    Public Function GetOne_3(ByVal nombre_obra As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Obra_GetOne_3", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre_obra", SqlDbType.VarChar, 50, "nombre_obra")
        oda.SelectCommand.Parameters("@nombre_obra").Value = nombre_obra

        oda.Fill(odt)

        Return odt
    End Function
End Class
