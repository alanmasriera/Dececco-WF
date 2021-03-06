Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Limite
    Inherits Limite_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Limite As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Limite", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_limite", SqlDbType.Int, 4, "id_limite")
        oda.SelectCommand.Parameters("@id_limite").Value = id_Limite

        oda.Fill(odt)
        Return odt
    End Function

    'FUNCION PARA CONSULTAR TODO
    Public Function GetLimit(ByVal id_cuenta As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Limite_GetLimit", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cuenta", SqlDbType.Int, 4, "id_cuenta")
        oda.SelectCommand.Parameters("@id_cuenta").Value = id_cuenta

        oda.Fill(odt)

        Return odt
    End Function

    'FUNCION PARA BUSCAR
    Public Function Find_2(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Limite_Find_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'FUNCION PARA CONSULTAR TODO
    Public Function GetAll_2() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Limite_GetAll_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function
End Class
