Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Pago_cliente
    Inherits Pago_cliente_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Pago_cliente As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Pago_cliente", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_pago_cliente", SqlDbType.Int, 4, "id_pago_cliente")
        oda.SelectCommand.Parameters("@id_pago_cliente").Value = id_Pago_cliente

        oda.Fill(odt)
        Return odt
    End Function

    'grilla
    Public Function GetAll_2() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Pago_cliente_GetAll_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure

        oda.Fill(odt)
        Return odt
    End Function

    'grilla
    Public Function GetAll_3(ByVal id_cliente As Integer, ByVal periodo As DateTime) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Pago_cliente_GetAll_3", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.Int, 4, "id_cliente")
        oda.SelectCommand.Parameters("@id_cliente").Value = id_cliente
        oda.SelectCommand.Parameters.Add("@periodo", SqlDbType.DateTime, 8, "periodo")
        oda.SelectCommand.Parameters("@periodo").Value = periodo

        oda.Fill(odt)
        Return odt
    End Function

    'funcion de busqueda 2
    Public Function Find_2(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Pago_cliente_Find_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'maximo remito
    Public Function GetMaxRecibo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Pago_cliente_GetMaxRecibo", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure

        oda.Fill(odt)
        Return odt
    End Function

End Class
