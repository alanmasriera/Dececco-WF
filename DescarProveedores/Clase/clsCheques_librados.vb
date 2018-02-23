Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Cheques_librados
    Inherits Cheques_librados_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Cheques_librados As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cheques_librados", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cheque_librado", SqlDbType.Int, 4, "id_cheque_librado")
        oda.SelectCommand.Parameters("@id_cheque_librado").Value = id_Cheques_librados

        oda.Fill(odt)
        Return odt
    End Function


    Public Function Consultar(ByVal Empresa As Integer, ByVal Fecha As DateTime, ByVal Banco As Integer, ByVal Cuenta As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_ChequeLibradoConsultar", cnn.Coneccion)

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
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_ChequeLibradoConsultar2", cnn.Coneccion)

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

    'Public Function Autonumerico(ByVal Empresa As Integer, ByVal Fecha As DateTime, ByVal idChequera As Integer) As String
    '    Dim odt As New DataTable
    '    Dim oda As New SqlDataAdapter("AutonumericoChequeLibrado", cnn.Coneccion)
    '    Dim Total As String

    '    oda.SelectCommand.CommandType = CommandType.StoredProcedure
    '    oda.SelectCommand.Parameters.Add("@Empresa", SqlDbType.Int, 4, "id_empresa")
    '    oda.SelectCommand.Parameters("@Empresa").Value = Empresa
    '    oda.SelectCommand.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "fecha_comprobante")
    '    oda.SelectCommand.Parameters("@Fecha").Value = Fecha
    '    oda.SelectCommand.Parameters.Add("@idChequera", SqlDbType.Int, 4, "id_chequera")
    '    oda.SelectCommand.Parameters("@idChequera").Value = IdChequera

    '    oda.Fill(odt)

    '    Total = odt.Rows(0).Item("Total").ToString

    '    Return Total
    'End Function

    Public Function ConsultarEntreFechas(ByVal Empresa As Integer, ByVal Fecha As DateTime, ByVal Banco As Integer, ByVal Cuenta As Integer, ByVal FechaInicio As DateTime, ByVal FechaFin As DateTime) As DataTable
        Dim odt As DataTable = New DataTable
        Dim oda As SqlDataAdapter = New SqlDataAdapter("cop_ChequeLibradoConsultarEntreFechas", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@Empresa", SqlDbType.Int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@Empresa").Value = Empresa
        oda.SelectCommand.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "periodo")
        oda.SelectCommand.Parameters("@Fecha").Value = Fecha
        oda.SelectCommand.Parameters.Add("@Banco", SqlDbType.Int, 4, "id_banco")
        oda.SelectCommand.Parameters("@Banco").Value = Banco
        oda.SelectCommand.Parameters.Add("@Cuenta", SqlDbType.Int, 4, "id_cuenta")
        oda.SelectCommand.Parameters("@Cuenta").Value = Cuenta
        oda.SelectCommand.Parameters.Add("@Fecha1", SqlDbType.DateTime, 8, "fecha_pago")
        oda.SelectCommand.Parameters("@Fecha1").Value = FechaInicio
        oda.SelectCommand.Parameters.Add("@Fecha2", SqlDbType.DateTime, 8, "fecha_pago")
        oda.SelectCommand.Parameters("@Fecha2").Value = FechaFin

        oda.Fill(odt)

        Return odt
    End Function

    Public Function ConsultarPorFechaPago(ByVal Empresa As Integer, ByVal Fecha As DateTime, ByVal Banco As Integer, ByVal Cuenta As Integer, ByVal FechaPago As DateTime, ByVal FechaFin As DateTime) As DataTable
        Dim odt As DataTable = New DataTable
        Dim oda As SqlDataAdapter = New SqlDataAdapter("cop_ChequeLibradoConsultarPorFechaPago", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@Empresa", SqlDbType.Int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@Empresa").Value = Empresa
        oda.SelectCommand.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "periodo")
        oda.SelectCommand.Parameters("@Fecha").Value = Fecha
        oda.SelectCommand.Parameters.Add("@Banco", SqlDbType.Int, 4, "id_banco")
        oda.SelectCommand.Parameters("@Banco").Value = Banco
        oda.SelectCommand.Parameters.Add("@Cuenta", SqlDbType.Int, 4, "id_cuenta")
        oda.SelectCommand.Parameters("@Cuenta").Value = Cuenta
        oda.SelectCommand.Parameters.Add("@FechaPago", SqlDbType.DateTime, 8, "fecha_pago")
        oda.SelectCommand.Parameters("@FechaPago").Value = FechaPago
        oda.SelectCommand.Parameters.Add("@FechaFin", SqlDbType.DateTime, 8, "fecha_pago")
        oda.SelectCommand.Parameters("@FechaFin").Value = FechaFin

        oda.Fill(odt)

        Return odt
    End Function

    Public Function ConsultarPorFechaLibrado(ByVal Empresa As Integer, ByVal Fecha As DateTime, ByVal Banco As Integer, ByVal Cuenta As Integer, ByVal FechaLibrado As DateTime, ByVal FechaFin As DateTime) As DataTable
        Dim odt As DataTable = New DataTable
        Dim oda As SqlDataAdapter = New SqlDataAdapter("cop_ChequeLibradoConsultarPorFechaLibrado", cnn.Coneccion)

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
        oda.SelectCommand.Parameters("@FechaLibrado").Value = FechaLibrado
        oda.SelectCommand.Parameters.Add("@FechaFin", SqlDbType.DateTime, 8, "fecha_librado")
        oda.SelectCommand.Parameters("@FechaFin").Value = FechaFin

        oda.Fill(odt)

        Return odt
    End Function

    Public Function ConsultarPorProveedor(ByVal Empresa As Integer, ByVal Fecha As DateTime, ByVal Banco As Integer, ByVal Cuenta As Integer, ByVal Proveedor As Integer) As DataTable
        Dim odt As DataTable = New DataTable
        Dim oda As SqlDataAdapter = New SqlDataAdapter("cop_ChequeLibradoConsultarPorProveedor", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@Empresa", SqlDbType.Int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@Empresa").Value = Empresa
        oda.SelectCommand.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "periodo")
        oda.SelectCommand.Parameters("@Fecha").Value = Fecha
        oda.SelectCommand.Parameters.Add("@Banco", SqlDbType.Int, 4, "id_banco")
        oda.SelectCommand.Parameters("@Banco").Value = Banco
        oda.SelectCommand.Parameters.Add("@Cuenta", SqlDbType.Int, 4, "id_cuenta")
        oda.SelectCommand.Parameters("@Cuenta").Value = Cuenta
        oda.SelectCommand.Parameters.Add("@Proveedor", SqlDbType.Int, 4, "id_proveedor")
        oda.SelectCommand.Parameters("@Proveedor").Value = Proveedor

        oda.Fill(odt)

        Return odt
    End Function

    Public Function ConsultarPorNumero(ByVal Empresa As Integer, ByVal Fecha As DateTime, ByVal Banco As Integer, ByVal Cuenta As Integer, ByVal Numero As String) As DataTable
        Dim odt As DataTable = New DataTable
        Dim oda As SqlDataAdapter = New SqlDataAdapter("cop_ChequeLibradoConsultarPorCheque", cnn.Coneccion)

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
    Public Sub Update_Check(ByVal id_cheque_librado As Integer, ByVal control As Boolean)

        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Cheques_librados_Update_Check"
        Command.Parameters.Add("@id_cheque_librado", SqlDbType.Int, 4, "id_cheque_librado")
        Command.Parameters("@id_cheque_librado").Value = id_cheque_librado
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

    'consulta ambos cheques: recibidos y librados
    Public Function GetBothCheques(ByVal fecha_librado_desde As DateTime, ByVal fecha_librado_hasta As DateTime, _
    ByVal fecha_pago_desde As DateTime, ByVal fecha_pago_hasta As DateTime, ByVal fecha_recibido_desde As DateTime, _
    ByVal fecha_recibido_hasta As DateTime, ByVal fecha_acreditacion_desde As DateTime, _
    ByVal fecha_acreditacion_hasta As DateTime) As DataTable

        Dim odt As DataTable = New DataTable
        Dim oda As SqlDataAdapter = New SqlDataAdapter("cop_Cheque_temporal_GetTemp", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@fecha_librado_desde", SqlDbType.DateTime, 8, "fecha_librado_desde")
        oda.SelectCommand.Parameters("@fecha_librado_desde").Value = fecha_librado_desde
        oda.SelectCommand.Parameters.Add("@fecha_librado_hasta", SqlDbType.DateTime, 8, "fecha_librado_hasta")
        oda.SelectCommand.Parameters("@fecha_librado_hasta").Value = fecha_librado_hasta
        oda.SelectCommand.Parameters.Add("@fecha_pago_desde", SqlDbType.DateTime, 8, "fecha_pago_desde")
        oda.SelectCommand.Parameters("@fecha_pago_desde").Value = fecha_pago_desde
        oda.SelectCommand.Parameters.Add("@fecha_pago_hasta", SqlDbType.DateTime, 8, "fecha_pago_hasta")
        oda.SelectCommand.Parameters("@fecha_pago_hasta").Value = fecha_pago_hasta

        oda.SelectCommand.Parameters.Add("@fecha_recibido_desde", SqlDbType.DateTime, 8, "fecha_recibido_desde")
        oda.SelectCommand.Parameters("@fecha_recibido_desde").Value = fecha_recibido_desde
        oda.SelectCommand.Parameters.Add("@fecha_recibido_hasta", SqlDbType.DateTime, 8, "fecha_recibido_hasta")
        oda.SelectCommand.Parameters("@fecha_recibido_hasta").Value = fecha_recibido_hasta
        oda.SelectCommand.Parameters.Add("@fecha_acreditacion_desde", SqlDbType.DateTime, 8, "fecha_acreditacion_desde")
        oda.SelectCommand.Parameters("@fecha_acreditacion_desde").Value = fecha_acreditacion_desde
        oda.SelectCommand.Parameters.Add("@fecha_acreditacion_hasta", SqlDbType.DateTime, 8, "fecha_acreditacion_hasta")
        oda.SelectCommand.Parameters("@fecha_acreditacion_hasta").Value = fecha_acreditacion_hasta

        '    Dim prm As SqlParameter
        '    prm = oda.SelectCommand.Parameters.Add("@id_cheque_temporal", SqlDbType.Int, 0, "id_cheque_librado")
        '    prm.Direction = ParameterDirection.Output

        oda.Fill(odt)

        Return odt
    End Function

    'calcula la suma de los cheques
    Public Function GetSum() As Decimal
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cheque_temporal_GetSum", cnn.Coneccion)
        Dim Total As Decimal

        oda.SelectCommand.CommandType = CommandType.StoredProcedure

        oda.Fill(odt)
        Total = CDec(odt.Rows(0).Item("Total"))
        Return Total
    End Function

    'calcula la suma de los cheques chequeados
    Public Function GetSumCheck() As Decimal
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cheque_temporal_GetSumCheck", cnn.Coneccion)
        Dim Total As Decimal

        oda.SelectCommand.CommandType = CommandType.StoredProcedure

        oda.Fill(odt)
        Total = CDec(odt.Rows(0).Item("Total"))
        Return Total
    End Function

    'calcula la suma de los cheques que no estan chequeados
    Public Function GetSumNoCheck() As Decimal
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cheque_temporal_GetSumNoCheck", cnn.Coneccion)
        Dim Total As Decimal

        oda.SelectCommand.CommandType = CommandType.StoredProcedure

        oda.Fill(odt)
        Total = CDec(odt.Rows(0).Item("Total"))
        Return Total
    End Function

    'funcion para llenar el combo
    Public Function GetCmb_2() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cheques_librados_GetCmb_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    Public Sub ArchivarCheque(ByVal id_cheque_librado As Integer, ByVal archivado As Boolean)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Cheques_Librados_ArchivarCheque"
        Command.Parameters.Add("@id_cheque_librado", SqlDbType.Int, 4, "id_cheque_librado")
        Command.Parameters("@id_cheque_librado").Value = id_cheque_librado
        Command.Parameters.Add("@archivado", SqlDbType.Bit, 1, "archivado")
        Command.Parameters("@archivado").Value = archivado

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub
End Class
