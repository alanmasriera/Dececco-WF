Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Logueo
    Inherits Logueo_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Logueo As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Logueo", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_logueo", SqlDbType.Int, 4, "id_logueo")
        oda.SelectCommand.Parameters("@id_logueo").Value = id_Logueo

        oda.Fill(odt)
        Return odt
    End Function

    'consulta si esta logueado
    Public Function GetLogueado(ByVal id_usuario As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Logueo_GetLogueado", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = id_usuario

        oda.Fill(odt)
        Return odt
    End Function


End Class
