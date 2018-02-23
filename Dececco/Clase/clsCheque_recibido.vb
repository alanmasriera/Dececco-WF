Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Cheque_recibido
    Inherits Cheque_recibido_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Cheque_recibido As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cheque_recibido", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cheque_recibido", SqlDbType.Int, 4, "id_cheque_recibido")
        oda.SelectCommand.Parameters("@id_cheque_recibido").Value = id_Cheque_recibido

        oda.Fill(odt)
        Return odt
    End Function

    'update el cheque como marcado o no
    Public Sub Update_Check(ByVal id_cheque_recibido As Integer, ByVal control As Boolean)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Cheque_recibido_Update_Check"
        Command.Parameters.Add("@id_cheque_recibido", SqlDbType.Int, 4, "id_cheque_recibido")
        Command.Parameters("@id_cheque_recibido").Value = id_cheque_recibido
        Command.Parameters.Add("@control", SqlDbType.Bit, 1, "control")
        Command.Parameters("@control").Value = control

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub


    Public Function Consultar(ByVal id_empresa As Integer, ByVal fecha As DateTime) As DataTable
        Dim odt As DataTable = New DataTable
        Dim oda As SqlDataAdapter = New SqlDataAdapter("cop_Cheque_recibido_GetAllGrilla", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_empresa", SqlDbType.Int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@id_empresa").Value = id_empresa
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = fecha

        oda.Fill(odt)

        Return odt
    End Function

    Public Function Consultar2(ByVal id_empresa As Integer, ByVal fecha As DateTime) As DataTable
        Dim odt As DataTable = New DataTable
        Dim oda As SqlDataAdapter = New SqlDataAdapter("cop_Cheque_recibido_GetAllGrilla_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_empresa", SqlDbType.Int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@id_empresa").Value = id_empresa
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = fecha

        oda.Fill(odt)

        Return odt
    End Function

    Public Sub ArchivarCheque(ByVal id_cheque_recibido As Integer, ByVal archivado As Boolean)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Cheque_recibido_ArchivarCheque"
        Command.Parameters.Add("@id_cheque_recibido", SqlDbType.Int, 4, "id_cheque_recibido")
        Command.Parameters("@id_cheque_recibido").Value = id_cheque_recibido
        Command.Parameters.Add("@archivado", SqlDbType.Bit, 1, "archivado")
        Command.Parameters("@archivado").Value = archivado

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub
    
    'funcion para llenar el combo
    Public Function GetCmb_2(ByVal id_proveedor As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cheque_recibido_GetCmb_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proveedor", SqlDbType.Int, 4, "id_proveedor")
        oda.SelectCommand.Parameters("@id_proveedor").Value = id_proveedor

        oda.Fill(odt)

        Return odt
    End Function

    'llena un combo con los cheques de un cliente
    Public Function GetCmbChequeCliente(ByVal id_cliente As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cheque_recibido_GetCmbFacturaCliente", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.Int, 4, "id_cliente")
        oda.SelectCommand.Parameters("@id_cliente").Value = id_cliente

        oda.Fill(odt)
        Return odt
    End Function

   
End Class
