Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Precio
    Inherits Precio_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Precio As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Precio", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_precio", SqlDbType.Int, 4, "id_precio")
        oda.SelectCommand.Parameters("@id_precio").Value = id_Precio

        oda.Fill(odt)
        Return odt
    End Function

    'consulta el precio_venta maximo
    Public Function GetMaxPrecio(ByVal id_producto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Precio_GetMaxPrecio", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_producto", SqlDbType.Int, 4, "id_producto")
        oda.SelectCommand.Parameters("@id_producto").Value = id_producto

        oda.Fill(odt)
        Return odt
    End Function

    'consulta por el codigo de proveedor del producto
    Public Function GetProducto(ByVal id_proveedor As Integer, ByVal codigo As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Precio_GetProducto", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proveedor", SqlDbType.Int, 4, "id_proveedor")
        oda.SelectCommand.Parameters("@id_proveedor").Value = id_proveedor
        oda.SelectCommand.Parameters.Add("@codigo", SqlDbType.VarChar, 50, "codigo")
        oda.SelectCommand.Parameters("@codigo").Value = codigo

        oda.Fill(odt)
        Return odt
    End Function

    'consulta por el codigo de proveedor del producto
    Public Function GetProductoId(ByVal id_proveedor As Integer, ByVal id_producto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Precio_GetProductoId", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proveedor", SqlDbType.Int, 4, "id_proveedor")
        oda.SelectCommand.Parameters("@id_proveedor").Value = id_proveedor
        oda.SelectCommand.Parameters.Add("@id_producto", SqlDbType.Int, 4, "id_producto")
        oda.SelectCommand.Parameters("@id_producto").Value = id_producto

        oda.Fill(odt)
        Return odt
    End Function

    'consulta para la grilla
    Public Function GetAll_2() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Precio_GetAll_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure

        oda.Fill(odt)
        Return odt
    End Function

    'funcion de busqueda 2
    Public Function Find_2(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Precio_Find_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'actualiza el precio en porcentajes por proveedor
    Public Sub UpdatePrecio(ByVal id_proveedor As Integer, ByVal porcentaje As Decimal)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Precio_UpdatePrecio"

        Command.CommandType = CommandType.StoredProcedure
        Command.Parameters.Add("@id_proveedor", SqlDbType.Int, 4, "id_proveedor")
        Command.Parameters("@id_proveedor").Value = id_proveedor
        Command.Parameters.Add("@porcentaje", SqlDbType.Decimal, 9, "porcentaje")
        Command.Parameters("@porcentaje").Value = porcentaje

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'actualiza el margen en porcentaje por proveedor
    Public Sub UpdateMargen(ByVal id_proveedor As Integer, ByVal porcentaje As Decimal)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Precio_UpdateMargen"

        Command.CommandType = CommandType.StoredProcedure
        Command.Parameters.Add("@id_proveedor", SqlDbType.Int, 4, "id_proveedor")
        Command.Parameters("@id_proveedor").Value = id_proveedor
        Command.Parameters.Add("@porcentaje", SqlDbType.Decimal, 9, "porcentaje")
        Command.Parameters("@porcentaje").Value = porcentaje

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'actualiza el margen de un producto de todos los proveedores
    Public Sub UpdateMargenProducto(ByVal id_producto As Integer, ByVal porcentaje As Decimal)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Precio_UpdateMargenProducto"

        Command.CommandType = CommandType.StoredProcedure
        Command.Parameters.Add("@id_producto", SqlDbType.Int, 4, "id_producto")
        Command.Parameters("@id_producto").Value = id_producto
        Command.Parameters.Add("@porcentaje", SqlDbType.Decimal, 9, "porcentaje")
        Command.Parameters("@porcentaje").Value = porcentaje

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'consulta por el id del producto
    Public Function GetProductoProducto(ByVal id_producto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Precio_GetProductoProducto", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_producto", SqlDbType.Int, 4, "id_producto")
        oda.SelectCommand.Parameters("@id_producto").Value = id_producto

        oda.Fill(odt)
        Return odt
    End Function


End Class
