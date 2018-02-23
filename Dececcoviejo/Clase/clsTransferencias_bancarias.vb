Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Transferencias_bancarias
    Inherits Transferencias_bancarias_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Transferencias_bancarias As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Transferencias_bancarias", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_transferencia_bancaria", SqlDbType.Int, 4, "id_transferencia_bancaria")
        oda.SelectCommand.Parameters("@id_transferencia_bancaria").Value = id_Transferencias_bancarias

        oda.Fill(odt)
        Return odt
    End Function

    Public Function Consultar(ByVal Empresa As Integer, ByVal Fecha As DateTime, ByVal Banco As Integer, ByVal Cuenta As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_TransferenciaConsultar", cnn.Coneccion)

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

    Public Function ConsultarEntreFechas(ByVal Empresa As Integer, ByVal Fecha As DateTime, ByVal Banco As Integer, ByVal Cuenta As Integer, ByVal FechaInicio As DateTime, ByVal FechaFin As DateTime) As DataTable

        Dim odt As DataTable = New DataTable
        Dim oda As SqlDataAdapter = New SqlDataAdapter("cop_TransferenciaConsultarEntreFechas", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@Empresa", SqlDbType.Int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@Empresa").Value = Empresa
        oda.SelectCommand.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "periodo")
        oda.SelectCommand.Parameters("@Fecha").Value = Fecha
        oda.SelectCommand.Parameters.Add("@Banco", SqlDbType.Int, 4, "id_banco")
        oda.SelectCommand.Parameters("@Banco").Value = Banco
        oda.SelectCommand.Parameters.Add("@Cuenta", SqlDbType.Int, 4, "id_cuenta")
        oda.SelectCommand.Parameters("@Cuenta").Value = Cuenta
        oda.SelectCommand.Parameters.Add("@Fecha1", SqlDbType.DateTime, 8, "fecha")
        oda.SelectCommand.Parameters("@Fecha1").Value = FechaInicio
        oda.SelectCommand.Parameters.Add("@Fecha2", SqlDbType.DateTime, 8, "fecha")
        oda.SelectCommand.Parameters("@Fecha2").Value = FechaFin

        oda.Fill(odt)

        Return odt
    End Function

    Public Function Get_AllQuery(ByVal Empresa As Integer, ByVal Fecha As DateTime, _
                                 ByVal Banco As Integer, ByVal Cuenta As Integer, _
                                 ByVal FechaInicio As DateTime, ByVal FechaFin As DateTime, _
                                 ByVal Numero As String, ByVal FechaPago As DateTime, _
                                 ByVal bandera_query As Integer, ByVal con_fecha As Boolean) As DataTable

        Dim odt As DataTable = New DataTable
        Dim oda As SqlDataAdapter = New SqlDataAdapter("cop_Transferencia_GetQuery", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@Empresa", SqlDbType.Int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@Empresa").Value = Empresa
        oda.SelectCommand.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "periodo")
        oda.SelectCommand.Parameters("@Fecha").Value = Fecha
        oda.SelectCommand.Parameters.Add("@Banco", SqlDbType.Int, 4, "id_banco")
        oda.SelectCommand.Parameters("@Banco").Value = Banco
        oda.SelectCommand.Parameters.Add("@Cuenta", SqlDbType.Int, 4, "id_cuenta")
        oda.SelectCommand.Parameters("@Cuenta").Value = Cuenta
        oda.SelectCommand.Parameters.Add("@Fecha1", SqlDbType.DateTime, 8, "fecha")
        oda.SelectCommand.Parameters("@Fecha1").Value = FechaInicio
        oda.SelectCommand.Parameters.Add("@Fecha2", SqlDbType.DateTime, 8, "fecha")
        oda.SelectCommand.Parameters("@Fecha2").Value = FechaFin
        oda.SelectCommand.Parameters.Add("@Numero", SqlDbType.NChar, 50, "numero_cheque")
        oda.SelectCommand.Parameters("@Numero").Value = Numero
        oda.SelectCommand.Parameters.Add("@FechaPago", SqlDbType.DateTime, 8, "fecha")
        oda.SelectCommand.Parameters("@FechaPago").Value = FechaPago
        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@bandera_query", SqlDbType.Int, 4, "bandera_query")
        oda.SelectCommand.Parameters("@bandera_query").Value = bandera_query
        oda.SelectCommand.Parameters.Add("@con_fecha", SqlDbType.Bit, 4, "con_fecha")
        oda.SelectCommand.Parameters("@con_fecha").Value = con_fecha


        oda.Fill(odt)

        Return odt
    End Function

    'Public Function ConsultarPorFecha(ByVal Empresa As Integer, ByVal Fecha As DateTime, ByVal Banco As Integer, ByVal Cuenta As Integer, ByVal FechaCobro As DateTime) As DataTable

    '    Dim odt As DataTable = New DataTable
    '    Dim oda As SqlDataAdapter = New SqlDataAdapter("cop_TransferenciaConsultarPorFecha", cnn.Coneccion)

    '    oda.SelectCommand.CommandType = CommandType.StoredProcedure
    '    oda.SelectCommand.Parameters.Add("@Empresa", SqlDbType.Int, 4, "id_empresa")
    '    oda.SelectCommand.Parameters("@Empresa").Value = Empresa
    '    oda.SelectCommand.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "periodo")
    '    oda.SelectCommand.Parameters("@Fecha").Value = Fecha
    '    oda.SelectCommand.Parameters.Add("@Banco", SqlDbType.Int, 4, "id_banco")
    '    oda.SelectCommand.Parameters("@Banco").Value = Banco
    '    oda.SelectCommand.Parameters.Add("@Cuenta", SqlDbType.Int, 4, "id_cuenta")
    '    oda.SelectCommand.Parameters("@Cuenta").Value = Cuenta
    '    oda.SelectCommand.Parameters.Add("@FechaPago", SqlDbType.DateTime, 8, "fecha")
    '    oda.SelectCommand.Parameters("@FechaPago").Value = FechaCobro
    '    oda.Fill(odt)

    '    Return odt
    'End Function

    Public Function ConsultarPorNumero(ByVal Empresa As Integer, ByVal Fecha As DateTime, ByVal Banco As Integer, ByVal Cuenta As Integer, ByVal Numero As String) As DataTable

        Dim odt As DataTable = New DataTable
        Dim oda As SqlDataAdapter = New SqlDataAdapter("cop_TransferenciaConsultarPorNumero", cnn.Coneccion)

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

    'update la transferencia como marcado o no
    Public Sub Update_Check(ByVal id_transferencia_bancaria As Integer, ByVal control As Boolean)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Transferencias_bancarias_Update_Check"
        Command.Parameters.Add("@id_transferencia_bancaria", SqlDbType.Int, 4, "id_transferencia_bancaria")
        Command.Parameters("@id_transferencia_bancaria").Value = id_transferencia_bancaria
        Command.Parameters.Add("@control", SqlDbType.Bit, 1, "control")
        Command.Parameters("@control").Value = control

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

End Class
