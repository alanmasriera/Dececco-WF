Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Recibo_cliente_ingreso_efectivo
    Inherits Recibo_cliente_ingreso_efectivo_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Recibo_cliente_ingreso_efectivo As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Recibo_cliente_ingreso_efectivo", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_Recibo_cliente_ingreso_efectivo", SqlDbType.Int, 4, "id_Recibo_cliente_ingreso_efectivo")
        oda.SelectCommand.Parameters("@id_Recibo_cliente_ingreso_efectivo").Value = id_Recibo_cliente_ingreso_efectivo

        oda.Fill(odt)
        Return odt
    End Function


    'borra los datos relacionados al encabezado
    Public Sub DeleteRecibo_cliente(ByVal id_pago_cliente As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Recibo_cliente_ingreso_efectivo_DeleteRecibo_cliente"
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
        Command.CommandText = "cop_Recibo_cliente_ingreso_efectivo_UpdateID"
        Command.Parameters.Add("@id_pago_cliente", SqlDbType.Int, 4, "id_pago_cliente")
        Command.Parameters("@id_pago_cliente").Value = id_pago_cliente
        'Command.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        'Command.Parameters("@id_usuario").Value = id_usuario

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'grilla
    'Public Function GetAllPagoCliente(ByVal id_pago_cliente As Integer) As DataTable
    '    Dim odt As New DataTable
    '    Dim oda As New SqlDataAdapter("cop_Recibo_cliente_ingreso_efectivo_GetAllPagoCliente", cnn.Coneccion)

    '    oda.SelectCommand.CommandType = CommandType.StoredProcedure
    '    oda.SelectCommand.Parameters.Add("@id_pago_cliente", SqlDbType.Int, 4, "id_pago_cliente")
    '    oda.SelectCommand.Parameters("@id_pago_cliente").Value = id_pago_cliente

    '    oda.Fill(odt)
    '    Return odt
    'End Function

    Public Function GetAllPagoCliente_2(ByVal id_pago_cliente As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Recibo_cliente_ingreso_efectivo_GetAllPagoCliente_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_pago_cliente", SqlDbType.Int, 4, "id_pago_cliente")
        oda.SelectCommand.Parameters("@id_pago_cliente").Value = id_pago_cliente

        oda.Fill(odt)
        Return odt
    End Function

    Public Function GetImporte(ByVal Id_recibo_cliente_ingreso_efectivo As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Recibo_cliente_ingreso_efectivo_GetImporte", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@Id_recibo_cliente_ingreso_efectivo", SqlDbType.Int, 4, "Id_recibo_cliente_ingreso_efectivo")
        oda.SelectCommand.Parameters("@Id_recibo_cliente_ingreso_efectivo").Value = Id_recibo_cliente_ingreso_efectivo

        oda.Fill(odt)

        Return odt
    End Function
    Public Function GetImporte2(ByVal id_ingreso_efectivo As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Recibo_cliente_ingreso_efectivo_GetImporte2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_ingreso_efectivo", SqlDbType.Int, 4, "id_ingreso_efectivo")
        oda.SelectCommand.Parameters("@id_ingreso_efectivo").Value = id_ingreso_efectivo

        oda.Fill(odt)

        Return odt
    End Function

    'traigo todos los pagos con ese ingreso
    Public Function GetAllIngreso_efectivo(ByVal id_ingreso_efectivo As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Recibo_cliente_ingreso_efectivo_GetAllIngeso_efectivo", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_ingreso_efectivo", SqlDbType.Int, 4, "id_ingreso_efectivo")
        oda.SelectCommand.Parameters("@id_ingreso_efectivo").Value = id_ingreso_efectivo

        oda.Fill(odt)

        Return odt
    End Function
End Class




