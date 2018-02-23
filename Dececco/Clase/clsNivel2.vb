Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Nivel2
    Inherits Nivel2_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Nivel2 As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Nivel2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_nivel2", SqlDbType.Int, 4, "id_nivel2")
        oda.SelectCommand.Parameters("@id_nivel2").Value = id_Nivel2

        oda.Fill(odt)
        Return odt
    End Function

    'funcion de consulta
    Public Function GetAll_2() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Nivel2_GetAll_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion de busqueda
    Public Function Find_2(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Nivel2_Find_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

End Class

