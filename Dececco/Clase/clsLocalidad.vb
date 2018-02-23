Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Localidad
    Inherits Localidad_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Localidad As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Localidad", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_localidad", SqlDbType.Int, 4, "id_localidad")
        oda.SelectCommand.Parameters("@id_localidad").Value = id_Localidad

        oda.Fill(odt)
        Return odt
    End Function

    'combo
    Public Function GetCmb_2(ByVal id_provincia As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Localidad_GetCmb_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_provincia", SqlDbType.Int, 4, "id_provincia")
        oda.SelectCommand.Parameters("@id_provincia").Value = id_provincia

        oda.Fill(odt)
        Return odt
    End Function

    'funcion de consulta
    Public Function GetAll_2() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_LOCALIDAD_GetAll_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion de busqueda
    Public Function Find_2(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_LOCALIDAD_Find_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function
End Class


