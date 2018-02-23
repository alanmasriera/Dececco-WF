Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Producto
    Inherits Producto_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Producto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Producto", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_producto", SqlDbType.Int, 4, "id_producto")
        oda.SelectCommand.Parameters("@id_producto").Value = id_Producto

        oda.Fill(odt)
        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb2() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Producto_GetCmb2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el codigo
    Public Function GetOneCodigo(ByVal nombre_producto As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Producto_GetOneCodigo", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre_producto", SqlDbType.VarChar, 50, "nombre_producto")
        oda.SelectCommand.Parameters("@nombre_producto").Value = nombre_producto

        oda.Fill(odt)

        Return odt
    End Function

    'Public Sub UpdateStock(ByVal id_producto As Integer, ByVal cantidad As Decimal)
    '    Dim oConexion As New Conexion
    '    Dim Command As SqlCommand = New SqlCommand()

    '    Command.Connection = oConexion.Coneccion
    '    Command.CommandText = "cop_Producto_UpdateStock"

    '    Command.CommandType = CommandType.StoredProcedure
    '    Command.Parameters.Add("@id_producto", SqlDbType.Int, 4, "id_producto")
    '    Command.Parameters("@id_producto").Value = id_producto
    '    Command.Parameters.Add("@cantidad", SqlDbType.Decimal, 9, "cantidad")
    '    Command.Parameters("@cantidad").Value = cantidad

    '    Command.Connection.Open()
    '    Command.ExecuteNonQuery()
    '    Command.Connection.Close()
    'End Sub

    Public Sub UpdateStockFacturaAgrego(ByVal id_factura As Integer, ByVal id_almacen As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Producto_UpdateStockFacturaAgrego"

        Command.CommandType = CommandType.StoredProcedure
        Command.Parameters.Add("@id_factura", SqlDbType.Int, 4, "id_factura")
        Command.Parameters("@id_factura").Value = id_factura
        Command.Parameters.Add("@id_almacen", SqlDbType.Int, 4, "id_almacen")
        Command.Parameters("@id_almacen").Value = id_almacen

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    Public Sub UpdateStockFacturaDescuento(ByVal id_factura As Integer, ByVal id_almacen As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Producto_UpdateStockFacturaDescuento"

        Command.CommandType = CommandType.StoredProcedure
        Command.Parameters.Add("@id_factura", SqlDbType.Int, 4, "id_factura")
        Command.Parameters("@id_factura").Value = id_factura
        Command.Parameters.Add("@id_almacen", SqlDbType.Int, 4, "id_almacen")
        Command.Parameters("@id_almacen").Value = id_almacen

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    Public Sub UpdateStockNDAgrego(ByVal id_nota_devolucion As Integer, ByVal id_almacen As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Producto_UpdateStockNDAgrego"

        Command.CommandType = CommandType.StoredProcedure
        Command.Parameters.Add("@id_nota_devolucion", SqlDbType.Int, 4, "id_nota_devolucion")
        Command.Parameters("@id_nota_devolucion").Value = id_nota_devolucion
        Command.Parameters.Add("@id_almacen", SqlDbType.Int, 4, "id_almacen")
        Command.Parameters("@id_almacen").Value = id_almacen

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    Public Sub UpdateStockNDDescuento(ByVal id_nota_devolucion As Integer, ByVal id_almacen As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Producto_UpdateStockNDDescuento"

        Command.CommandType = CommandType.StoredProcedure
        Command.Parameters.Add("@id_nota_devolucion", SqlDbType.Int, 4, "id_nota_devolucion")
        Command.Parameters("@id_nota_devolucion").Value = id_nota_devolucion
        Command.Parameters.Add("@id_almacen", SqlDbType.Int, 4, "id_almacen")
        Command.Parameters("@id_almacen").Value = id_almacen

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    Public Sub UpdateStockVentaDescuento(ByVal id_venta As Integer, ByVal id_almacen As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Producto_UpdateStockVentaDescuento"

        Command.CommandType = CommandType.StoredProcedure
        Command.Parameters.Add("@id_venta", SqlDbType.Int, 4, "id_venta")
        Command.Parameters("@id_venta").Value = id_venta
        Command.Parameters.Add("@id_almacen", SqlDbType.Int, 4, "id_almacen")
        Command.Parameters("@id_almacen").Value = id_almacen

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'actualizo el stock en las transferencias
    Public Sub UpdateStockTransferencia(ByVal id_transferencia_stock As Integer, ByVal id_almacen_origen As Integer, ByVal id_almacen_destino As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Producto_UpdateStockTransferencia"

        Command.CommandType = CommandType.StoredProcedure
        Command.Parameters.Add("@id_transferencia_stock", SqlDbType.Int, 4, "id_transferencia_stock")
        Command.Parameters("@id_transferencia_stock").Value = id_transferencia_stock
        Command.Parameters.Add("@id_almacen_origen", SqlDbType.Int, 4, "id_almacen_origen")
        Command.Parameters("@id_almacen_origen").Value = id_almacen_origen
        Command.Parameters.Add("@id_almacen_destino", SqlDbType.Int, 4, "id_almacen_destino")
        Command.Parameters("@id_almacen_destino").Value = id_almacen_destino

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub


    'funcion para llenar el combo
    Public Function GetAll_2() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Producto_GetAll_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetAll_3() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Producto_GetAll_3", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'busqueda por codigo
    Public Function Find_2(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Producto_Find_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'busqueda por descripcion
    Public Function Find_3(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Producto_Find_3", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist_2() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Producto_Exist_2", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre_producto", SqlDbType.VarChar, 50, "nombre_producto")
        oda.SelectCommand.Parameters("@nombre_producto").Value = Me.nombre_producto

        oda.Fill(odt)
        Total = CInt(odt.Rows(0).Item("Total").ToString)
        If Total = 0 Then
            Return False  'NO EXISTE
        Else
            Return True 'SI EXISTE
        End If
    End Function


    'funcion que trae un registro poniendo el id
    Public Function GetOne_2(ByVal id_Producto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Producto_GetOne_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_producto", SqlDbType.Int, 4, "id_producto")
        oda.SelectCommand.Parameters("@id_producto").Value = id_Producto

        oda.Fill(odt)

        Return odt
    End Function

End Class
