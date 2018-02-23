Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Temp1
    Inherits Temp1_ent

    Property nombre_usuario As String

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Temp1 As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Temp1", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_temp1", SqlDbType.Int, 4, "id_temp1")
        oda.SelectCommand.Parameters("@id_temp1").Value = id_Temp1

        oda.Fill(odt)
        Return odt
    End Function

    'resumen
    Public Function GetAll_2(ByVal id_Temp1 As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Temp1_GetAll_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure

        oda.Fill(odt)
        Return odt
    End Function


End Class
