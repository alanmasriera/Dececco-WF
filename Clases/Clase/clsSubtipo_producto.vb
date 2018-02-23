Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Subtipo_producto
    Inherits Subtipo_producto_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Subtipo_producto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Subtipo_producto", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_subtipo_producto", SqlDbType.Int, 4, "id_subtipo_producto")
        oda.SelectCommand.Parameters("@id_subtipo_producto").Value = id_Subtipo_producto

        oda.Fill(odt)
        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb_2() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Subtipo_producto_GetCmb_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'grilla
    Public Function GetAll_2() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Subtipo_producto_GetAll_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure

        oda.Fill(odt)
        Return odt
    End Function

    'funcion de busqueda 2
    Public Function Find_2(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Subtipo_producto_Find_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'getone 2
    Public Function GetOne_2(ByVal id_Subtipo_producto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Subtipo_producto_GetOne_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_Subtipo_producto", SqlDbType.Int, 4, "id_Subtipo_producto")
        oda.SelectCommand.Parameters("@id_Subtipo_producto").Value = id_Subtipo_producto

        oda.Fill(odt)

        Return odt
    End Function

End Class
