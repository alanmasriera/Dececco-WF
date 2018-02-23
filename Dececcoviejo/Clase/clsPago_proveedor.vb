Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Pago_proveedor
    Inherits Pago_proveedor_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Pago_proveedor As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Pago_proveedor", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_pago_proveedor", SqlDbType.Int, 4, "id_pago_proveedor")
        oda.SelectCommand.Parameters("@id_pago_proveedor").Value = id_Pago_proveedor

        oda.Fill(odt)
        Return odt
    End Function

    'funcion de consulta
    Public Function GetAll_2(ByVal fecha As DateTime, ByVal id_proveedor As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Pago_proveedor_GetAll_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = fecha
        oda.SelectCommand.Parameters.Add("@id_proveedor", SqlDbType.Int, 4, "id_proveedor")
        oda.SelectCommand.Parameters("@id_proveedor").Value = id_proveedor

        oda.Fill(odt)

        Return odt
    End Function

    ''funcion de busqueda 2
    'Public Function Find_2(ByVal Nombre As String) As DataTable
    '    Dim odt As New DataTable
    '    Dim oda As New SqlDataAdapter("cop_Pago_proveedor_Find_2", cnn.Coneccion)

    '    oda.SelectCommand.CommandType = CommandType.StoredProcedure
    '    oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
    '    oda.SelectCommand.Parameters("@nombre").Value = Nombre

    '    oda.Fill(odt)

    '    Return odt
    'End Function

End Class
