Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Cuerpo_factura_proveedor
    Inherits Cuerpo_factura_proveedor_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Cuerpo_factura_proveedor As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_factura_proveedor", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cuerpo_factura_proveedor", SqlDbType.Int, 4, "id_cuerpo_factura_proveedor")
        oda.SelectCommand.Parameters("@id_cuerpo_factura_proveedor").Value = id_Cuerpo_factura_proveedor

        oda.Fill(odt)
        Return odt
    End Function

    Public Sub UpdateID(ByVal id_factura_proveedor As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Cuerpo_factura_proveedor_UpdateID"

        Command.CommandType = CommandType.StoredProcedure
        Command.Parameters.Add("@id_factura_proveedor", SqlDbType.Int, 4, "id_cuerpo_factura_proveedor")
        Command.Parameters("@id_factura_proveedor").Value = id_factura_proveedor

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'consulta por factura
    Public Function GetAllFactura(ByVal id_factura_proveedor As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_factura_proveedor_GetAllFactura", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_factura_proveedor", SqlDbType.Int, 4, "id_factura_proveedor")
        oda.SelectCommand.Parameters("@id_factura_proveedor").Value = id_factura_proveedor

        oda.Fill(odt)
        Return odt
    End Function

    'consulta por factura el total
    Public Function GetAllFacturaTotal(ByVal id_factura_proveedor As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_factura_proveedor_GetAllFacturaTotal", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_factura_proveedor", SqlDbType.Int, 4, "id_factura_proveedor")
        oda.SelectCommand.Parameters("@id_factura_proveedor").Value = id_factura_proveedor

        oda.Fill(odt)
        Return odt
    End Function

    'consulta por factura el total
    Public Function GetAllFacturaOne(ByVal id_factura_proveedor As Integer, ByVal id_producto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_factura_proveedor_GetAllFacturaOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_factura_proveedor", SqlDbType.Int, 4, "id_factura_proveedor")
        oda.SelectCommand.Parameters("@id_factura_proveedor").Value = id_factura_proveedor
        oda.SelectCommand.Parameters.Add("@id_producto", SqlDbType.Int, 4, "id_producto")
        oda.SelectCommand.Parameters("@id_producto").Value = id_producto

        oda.Fill(odt)
        Return odt
    End Function

    'borra todo el cuerpo de la factura
    Public Sub DeleteFactura(ByVal id_factura_proveedor As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Cuerpo_factura_proveedor_DeleteFactura"

        Command.CommandType = CommandType.StoredProcedure
        Command.Parameters.Add("@id_factura_proveedor", SqlDbType.Int, 4, "id_factura_proveedor")
        Command.Parameters("@id_factura_proveedor").Value = id_factura_proveedor

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'actualiza el stock de todos los item de la factura
    Public Sub DeleteStockFactura(ByVal id_factura_proveedor As Integer, ByVal id_almacen As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Cuerpo_factura_proveedor_DeleteStockFactura"

        Command.CommandType = CommandType.StoredProcedure
        Command.Parameters.Add("@id_factura_proveedor", SqlDbType.Int, 4, "id_cuerpo_factura_proveedor")
        Command.Parameters("@id_factura_proveedor").Value = id_factura_proveedor
        Command.Parameters.Add("@id_almacen", SqlDbType.Int, 4, "id_almacen")
        Command.Parameters("@id_almacen").Value = id_almacen

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'actualiza el stock de un item de la factura
    Public Sub DeleteStockCuerpo(ByVal id_cuerpo_factura_proveedor As Integer, ByVal id_almacen As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Cuerpo_factura_proveedor_DeleteStockCuerpo"

        Command.CommandType = CommandType.StoredProcedure
        Command.Parameters.Add("@id_cuerpo_factura_proveedor", SqlDbType.Int, 4, "id_cuerpo_factura_proveedor")
        Command.Parameters("@id_cuerpo_factura_proveedor").Value = id_cuerpo_factura_proveedor
        Command.Parameters.Add("@id_almacen", SqlDbType.Int, 4, "id_almacen")
        Command.Parameters("@id_almacen").Value = id_almacen

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'actualiza los precios con los precios de la factura * porcentaje
    Public Sub UpdatePrecioNew(ByVal id_factura_proveedor As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Cuerpo_factura_proveedor_UpdatePrecioNew"

        Command.CommandType = CommandType.StoredProcedure
        Command.Parameters.Add("@id_factura_proveedor", SqlDbType.Int, 4, "id_cuerpo_factura_proveedor")
        Command.Parameters("@id_factura_proveedor").Value = id_factura_proveedor

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'insertar un registro vacio
    Public Sub InsertNinguno()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Cuerpo_factura_proveedor_InsertNinguno"

        Command.CommandType = CommandType.StoredProcedure

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

End Class
