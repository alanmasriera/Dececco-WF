Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Cheques_recibidos
    Inherits Cheques_recibidos_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Cheques_recibidos As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cheques_recibidos", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cheque_recibido", SqlDbType.Int, 4, "id_cheque_recibido")
        oda.SelectCommand.Parameters("@id_cheque_recibido").Value = id_Cheques_recibidos

        oda.Fill(odt)
        Return odt
    End Function


    Public Function ConsultarEntreFechas(ByVal Empresa As Integer, ByVal Fecha As DateTime, ByVal Banco As Integer, ByVal Cuenta As Integer, ByVal FechaInicio As DateTime, ByVal FechaFin As DateTime) As DataTable

        Dim odt As DataTable = New DataTable
        Dim oda As SqlDataAdapter = New SqlDataAdapter("cop_ChequeRecibidoEntreFechas", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@Empresa", SqlDbType.Int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@Empresa").Value = Empresa
        oda.SelectCommand.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "periodo")
        oda.SelectCommand.Parameters("@Fecha").Value = Fecha
        oda.SelectCommand.Parameters.Add("@Banco", SqlDbType.Int, 4, "id_banco")
        oda.SelectCommand.Parameters("@Banco").Value = Banco
        oda.SelectCommand.Parameters.Add("@Cuenta", SqlDbType.Int, 4, "id_cuenta")
        oda.SelectCommand.Parameters("@Cuenta").Value = Cuenta
        oda.SelectCommand.Parameters.Add("@Fecha1", SqlDbType.DateTime, 8, "fecha_acreditacion")
        oda.SelectCommand.Parameters("@Fecha1").Value = FechaInicio
        oda.SelectCommand.Parameters.Add("@Fecha2", SqlDbType.DateTime, 8, "fecha_acreditacion")
        oda.SelectCommand.Parameters("@Fecha2").Value = FechaFin

        oda.Fill(odt)

        Return odt
    End Function

    Public Function ConsultarPorFechaCobro(ByVal Empresa As Integer, ByVal Fecha As DateTime, ByVal Banco As Integer, ByVal Cuenta As Integer, ByVal FechaCobro As DateTime, ByVal FechaFin As DateTime) As DataTable

        Dim odt As DataTable = New DataTable
        Dim oda As SqlDataAdapter = New SqlDataAdapter("cop_ChequeRecibidoPorFechaCobro", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@Empresa", SqlDbType.Int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@Empresa").Value = Empresa
        oda.SelectCommand.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "periodo")
        oda.SelectCommand.Parameters("@Fecha").Value = Fecha
        oda.SelectCommand.Parameters.Add("@Banco", SqlDbType.Int, 4, "id_banco")
        oda.SelectCommand.Parameters("@Banco").Value = Banco
        oda.SelectCommand.Parameters.Add("@Cuenta", SqlDbType.Int, 4, "id_cuenta")
        oda.SelectCommand.Parameters("@Cuenta").Value = Cuenta
        oda.SelectCommand.Parameters.Add("@FechaPago", SqlDbType.DateTime, 8, "fecha_acreditacion")
        oda.SelectCommand.Parameters("@FechaPago").Value = FechaCobro
        oda.SelectCommand.Parameters.Add("@FechaFin", SqlDbType.DateTime, 8, "fecha_acreditacion")
        oda.SelectCommand.Parameters("@FechaFin").Value = FechaFin

        oda.Fill(odt)

        Return odt
    End Function

    Public Function ConsultarPorFechaRecibido(ByVal Empresa As Integer, ByVal Fecha As DateTime, ByVal Banco As Integer, ByVal Cuenta As Integer, ByVal FechaRecibido As DateTime, ByVal FechaFin As DateTime) As DataTable
        Dim odt As DataTable = New DataTable
        Dim oda As SqlDataAdapter = New SqlDataAdapter("cop_ChequeRecibidoPorFechaRecibido", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@Empresa", SqlDbType.Int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@Empresa").Value = Empresa
        oda.SelectCommand.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "periodo")
        oda.SelectCommand.Parameters("@Fecha").Value = Fecha
        oda.SelectCommand.Parameters.Add("@Banco", SqlDbType.Int, 4, "id_banco")
        oda.SelectCommand.Parameters("@Banco").Value = Banco
        oda.SelectCommand.Parameters.Add("@Cuenta", SqlDbType.Int, 4, "id_cuenta")
        oda.SelectCommand.Parameters("@Cuenta").Value = Cuenta
        oda.SelectCommand.Parameters.Add("@FechaLibrado", SqlDbType.DateTime, 8, "fecha_librado")
        oda.SelectCommand.Parameters("@FechaLibrado").Value = FechaRecibido
        oda.SelectCommand.Parameters.Add("@FechaFin", SqlDbType.DateTime, 8, "fecha_librado")
        oda.SelectCommand.Parameters("@FechaFin").Value = FechaFin

        oda.Fill(odt)

        Return odt
    End Function

    Public Function ConsultarPorCliente(ByVal Empresa As Integer, ByVal Fecha As DateTime, ByVal Banco As Integer, ByVal Cuenta As Integer, ByVal Cliente As Integer) As DataTable
        Dim odt As DataTable = New DataTable
        Dim oda As SqlDataAdapter = New SqlDataAdapter("cop_ChequeRecibidoPorCliente", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@Empresa", SqlDbType.Int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@Empresa").Value = Empresa
        oda.SelectCommand.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "periodo")
        oda.SelectCommand.Parameters("@Fecha").Value = Fecha
        oda.SelectCommand.Parameters.Add("@Banco", SqlDbType.Int, 4, "id_banco")
        oda.SelectCommand.Parameters("@Banco").Value = Banco
        oda.SelectCommand.Parameters.Add("@Cuenta", SqlDbType.Int, 4, "id_cuenta")
        oda.SelectCommand.Parameters("@Cuenta").Value = Cuenta
        oda.SelectCommand.Parameters.Add("@Cliente", SqlDbType.Int, 4, "id_cliente")
        oda.SelectCommand.Parameters("@Cliente").Value = Cliente

        oda.Fill(odt)

        Return odt
    End Function

    Public Function ConsultarPorNumero(ByVal Empresa As Integer, ByVal Fecha As DateTime, ByVal Banco As Integer, ByVal Cuenta As Integer, ByVal Numero As String) As DataTable
        Dim odt As DataTable = New DataTable
        Dim oda As SqlDataAdapter = New SqlDataAdapter("cop_ChequeRecibidoPorCheque", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@Empresa", SqlDbType.Int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@Empresa").Value = Empresa
        oda.SelectCommand.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "periodo")
        oda.SelectCommand.Parameters("@Fecha").Value = Fecha
        oda.SelectCommand.Parameters.Add("@Banco", SqlDbType.Int, 4, "id_banco")
        oda.SelectCommand.Parameters("@Banco").Value = Banco
        oda.SelectCommand.Parameters.Add("@Cuenta", SqlDbType.Int, 4, "id_cuenta")
        oda.SelectCommand.Parameters("@Cuenta").Value = Cuenta
        oda.SelectCommand.Parameters.Add("@Numero", SqlDbType.NChar, 50, "numero_cheque")
        oda.SelectCommand.Parameters("@Numero").Value = Numero

        oda.Fill(odt)

        Return odt
    End Function

    'update el cheque como marcado o no
    Public Sub Update_Check(ByVal id_cheque_recibido As Integer, ByVal control As Boolean)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Cheques_recibidos_Update_Check"
        Command.Parameters.Add("@id_cheque_recibido", SqlDbType.Int, 4, "id_cheque_recibido")
        Command.Parameters("@id_cheque_recibido").Value = id_cheque_recibido
        Command.Parameters.Add("@control", SqlDbType.Bit, 1, "control")
        Command.Parameters("@control").Value = control

        '   Dim prm As SqlParameter
        '   prm = Command.Parameters.Add("@idResumenCuenta", SqlDbType.Int, 0, "id_resumen_cuenta")
        '   prm.Direction = ParameterDirection.Output

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub


    'trae el total de cheques vendidos
    Public Function GetSpend(ByVal id_cuenta As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cheques_recibidos_GetSpend", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cuenta", SqlDbType.Int, 4, "id_cuenta")
        oda.SelectCommand.Parameters("@id_cuenta").Value = id_cuenta

        oda.Fill(odt)

        Return odt
    End Function

    Public Function Consultar(ByVal Empresa As Integer, ByVal Fecha As DateTime, ByVal Banco As Integer, ByVal Cuenta As Integer) As DataTable
        Dim odt As DataTable = New DataTable
        Dim oda As SqlDataAdapter = New SqlDataAdapter("cop_ChequeRecibidoConsultar", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@Empresa", SqlDbType.Int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@Empresa").Value = Empresa
        oda.SelectCommand.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "periodo")
        oda.SelectCommand.Parameters("@Fecha").Value = Fecha
        oda.SelectCommand.Parameters.Add("@Banco", SqlDbType.Int, 4, "id_banco")
        oda.SelectCommand.Parameters("@Banco").Value = Banco
        oda.SelectCommand.Parameters.Add("@Cuenta", SqlDbType.Int, 4, "id_cuenta")
        oda.SelectCommand.Parameters("@Cuenta").Value = Cuenta

        oda.Fill(odt)

        Return odt
    End Function

    Public Function Consultar2(ByVal Empresa As Integer, ByVal Fecha As DateTime, ByVal Banco As Integer, ByVal Cuenta As Integer) As DataTable
        Dim odt As DataTable = New DataTable
        Dim oda As SqlDataAdapter = New SqlDataAdapter("cop_ChequeRecibidoConsultar2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@Empresa", SqlDbType.Int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@Empresa").Value = Empresa
        oda.SelectCommand.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "periodo")
        oda.SelectCommand.Parameters("@Fecha").Value = Fecha
        oda.SelectCommand.Parameters.Add("@Banco", SqlDbType.Int, 4, "id_banco")
        oda.SelectCommand.Parameters("@Banco").Value = Banco
        oda.SelectCommand.Parameters.Add("@Cuenta", SqlDbType.Int, 4, "id_cuenta")
        oda.SelectCommand.Parameters("@Cuenta").Value = Cuenta

        oda.Fill(odt)

        Return odt
    End Function

    'llena un combo con los cheques de un cliente
    Public Function GetCmbChequeCliente(ByVal id_cliente As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cheques_recibidos_GetCmbFacturaCliente", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.Int, 4, "id_cliente")
        oda.SelectCommand.Parameters("@id_cliente").Value = id_cliente

        oda.Fill(odt)
        Return odt
    End Function

    'archiva o no el cheque
    Public Sub ArchivarCheque(ByVal id_cheque_recibido As Integer, ByVal archivado As Boolean)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Cheques_recibidos_ArchivarCheque"
        Command.Parameters.Add("@id_cheque_recibido", SqlDbType.Int, 4, "id_cheque_recibido")
        Command.Parameters("@id_cheque_recibido").Value = id_cheque_recibido
        Command.Parameters.Add("@archivado", SqlDbType.Bit, 1, "archivado")
        Command.Parameters("@archivado").Value = archivado

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    Public Function GetCheque(ByVal numero_cheque As String, ByVal id_cuenta As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cheques_recibidos_GetCheque", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@numero_cheque", SqlDbType.VarChar, 12, "numero_cheque")
        oda.SelectCommand.Parameters("@numero_cheque").Value = numero_cheque
        oda.SelectCommand.Parameters.Add("@id_cuenta", SqlDbType.Int, 8, "id_cuenta")
        oda.SelectCommand.Parameters("@id_cuenta").Value = id_cuenta

        oda.Fill(odt)
        Return odt
    End Function

    'llena un combo con los cheques de un cliente en los pagos
    Public Function GetCmbCliente(ByVal id_cliente As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cheques_recibidos_GetCmbCliente", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.Int, 4, "id_cliente")
        oda.SelectCommand.Parameters("@id_cliente").Value = id_cliente

        oda.Fill(odt)
        Return odt
    End Function
 
End Class
