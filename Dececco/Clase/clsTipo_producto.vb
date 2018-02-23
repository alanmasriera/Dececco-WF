Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Tipo_producto
    Inherits Tipo_producto_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Tipo_producto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_producto", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_tipo_producto", SqlDbType.Int, 4, "id_tipo_producto")
        oda.SelectCommand.Parameters("@id_tipo_producto").Value = id_Tipo_producto

        oda.Fill(odt)
        Return odt
    End Function

    'grilla
    Public Function GetAll_2() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_producto_GetAll_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure

        oda.Fill(odt)
        Return odt
    End Function

    'funcion de busqueda 2
    Public Function Find_2(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_producto_Find_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'combo
    Public Function GeCmb_2() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_producto_GetCmb_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure

        oda.Fill(odt)
        Return odt
    End Function

    'getone 2
    Public Function GetOne_2(ByVal id_Tipo_producto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Tipo_producto_GetOne_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_tipo_producto", SqlDbType.Int, 4, "id_tipo_producto")
        oda.SelectCommand.Parameters("@id_tipo_producto").Value = id_Tipo_producto

        oda.Fill(odt)

        Return odt
    End Function

End Class
