Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Mail
    Inherits Mail_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Mail As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Mail", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_mail", SqlDbType.Int, 4, "id_mail")
        oda.SelectCommand.Parameters("@id_mail").Value = id_Mail

        oda.Fill(odt)
        Return odt
    End Function

    'funcion de consulta
    Public Function GetAll_2() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Mail_GetAll_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion de busqueda
    Public Function Find_2(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Mail_Find_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function
End Class


