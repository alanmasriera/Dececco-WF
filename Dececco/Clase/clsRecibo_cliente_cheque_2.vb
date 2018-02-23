Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Recibo_cliente_cheque_2
    Inherits Recibo_cliente_cheque_2_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Recibo_cliente_cheque_2 As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Recibo_cliente_cheque_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_recibo_cliente_cheque_2", SqlDbType.Int, 4, "id_recibo_cliente_cheque_2")
        oda.SelectCommand.Parameters("@id_recibo_cliente_cheque_2").Value = id_Recibo_cliente_cheque_2

        oda.Fill(odt)
        Return odt
    End Function

    'borra los datos relacionados al encabezado
    Public Sub DeleteRecibo_cliente(ByVal id_pago_cliente As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Recibo_cliente_cheque_2_DeleteRecibo_cliente"
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
        Command.CommandText = "cop_Recibo_cliente_cheque_2_UpdateID"
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
    '    Dim oda As New SqlDataAdapter("cop_Recibo_cliente_cheque_GetAllPagoCliente", cnn.Coneccion)

    '    oda.SelectCommand.CommandType = CommandType.StoredProcedure
    '    oda.SelectCommand.Parameters.Add("@id_pago_cliente", SqlDbType.Int, 4, "id_pago_cliente")
    '    oda.SelectCommand.Parameters("@id_pago_cliente").Value = id_pago_cliente

    '    oda.Fill(odt)
    '    Return odt
    'End Function

    Public Function GetAllPagoCliente_2(ByVal id_pago_cliente As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Recibo_cliente_cheque_2_GetAllPagoCliente_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_pago_cliente", SqlDbType.Int, 4, "id_pago_cliente")
        oda.SelectCommand.Parameters("@id_pago_cliente").Value = id_pago_cliente

        oda.Fill(odt)
        Return odt
    End Function

End Class
