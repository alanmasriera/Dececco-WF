Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Banco
    Inherits Banco_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Banco As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Banco", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_banco", SqlDbType.Int, 4, "id_banco")
        oda.SelectCommand.Parameters("@id_banco").Value = id_Banco

        oda.Fill(odt)
        Return odt
    End Function

    'consulto el id de banco = ninguno
    Public Function GetOneNinguno() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Banco_GetOneNinguno", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function GetAll_2() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_BANCO_GetAll_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion de busqueda
    Public Function Find_2(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_BANCO_Find_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function
End Class


