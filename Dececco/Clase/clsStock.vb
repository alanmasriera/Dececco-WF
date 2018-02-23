Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Stock
    Inherits Stock_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Stock As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Stock", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_stock", SqlDbType.Int, 4, "id_stock")
        oda.SelectCommand.Parameters("@id_stock").Value = id_Stock

        oda.Fill(odt)
        Return odt
    End Function


    'consulta por el id del producto
    Public Function GetProductoAlmacen(ByVal id_producto As Integer, ByVal id_almacen As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Stock_GetProductoAlmacen", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_producto", SqlDbType.Int, 4, "id_producto")
        oda.SelectCommand.Parameters("@id_producto").Value = id_producto
        oda.SelectCommand.Parameters.Add("@id_almacen", SqlDbType.Int, 4, "id_almacen")
        oda.SelectCommand.Parameters("@id_almacen").Value = id_almacen

        oda.Fill(odt)
        Return odt
    End Function

    'trae los stock de producto 
    Public Function GetAllProducto(ByVal id_producto As Integer) As DataTable

        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Stock_GetAllProducto", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure 'declaro el tipo de producto
        oda.SelectCommand.Parameters.Add("@id_producto", SqlDbType.Int, 4, "id_producto")
        oda.SelectCommand.Parameters("@id_producto").Value = id_producto
        oda.Fill(odt)
        Return odt
    End Function

End Class
