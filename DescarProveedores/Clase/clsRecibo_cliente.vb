Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Recibo_cliente
    Inherits Recibo_cliente_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Recibo_cliente As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Recibo_cliente", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_recibo_cliente", SqlDbType.Int, 4, "id_recibo_cliente")
        oda.SelectCommand.Parameters("@id_recibo_cliente").Value = id_Recibo_cliente

        oda.Fill(odt)
        Return odt
    End Function

    'borra los datos relacionados al encabezado
    Public Sub DeletePago_cliente(ByVal id_pago_cliente As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Recibo_cliente_DeletePago_cliente"
        Command.Parameters.Add("@id_pago_cliente", SqlDbType.Int, 4, "id_pago_cliente")
        Command.Parameters("@id_pago_cliente").Value = id_pago_cliente

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra los datos relacionados al encabezado
    Public Sub UpdateID(ByVal id_pago_cliente As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Recibo_cliente_UpdateID"
        Command.Parameters.Add("@id_pago_cliente", SqlDbType.Int, 4, "id_pago_cliente")
        Command.Parameters("@id_pago_cliente").Value = id_pago_cliente
        'Command.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        'Command.Parameters("@id_usuario").Value = id_usuario

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub


    Public Function GetAllPagoCliente(ByVal id_pago_cliente As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Recibo_cliente_GetAllPagoCliente", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_pago_cliente", SqlDbType.Int, 4, "id_pago_cliente")
        oda.SelectCommand.Parameters("@id_pago_cliente").Value = id_pago_cliente

        oda.Fill(odt)
        Return odt
    End Function

    Public Function GetAllFactura(ByVal id_pago_cliente As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Recibo_cliente_GetAllFactura", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_pago_cliente", SqlDbType.Int, 4, "id_pago_cliente")
        oda.SelectCommand.Parameters("@id_pago_cliente").Value = id_pago_cliente

        oda.Fill(odt)
        Return odt
    End Function

    'traigo todos los pagos con ese ingreso
    Public Function GetAll_X_factura(ByVal id_factura As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Recibo_cliente_GetAllIngeso_factura", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_factura", SqlDbType.Int, 4, "id_factura")
        oda.SelectCommand.Parameters("@id_factura").Value = id_factura

        oda.Fill(odt)

        Return odt
    End Function

    Public Function GetOne_factura(ByVal id_pago_cliente As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Recibo_cliente_GetOne_factura", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_pago_cliente", SqlDbType.Int, 4, "id_pago_cliente")
        oda.SelectCommand.Parameters("@id_pago_cliente").Value = id_pago_cliente

        oda.Fill(odt)
        Return odt
    End Function
End Class
