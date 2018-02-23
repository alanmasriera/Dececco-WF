Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Resumen_cuenta
    Inherits Resumen_cuenta_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Resumen_cuenta As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Resumen_cuenta", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_resumen_cuenta", SqlDbType.Int, 4, "id_resumen_cuenta")
        oda.SelectCommand.Parameters("@id_resumen_cuenta").Value = id_Resumen_cuenta

        oda.Fill(odt)
        Return odt
    End Function

    Public Sub Update()
        Me.CrearComandoUpdate()
    End Sub

    Public Sub GenerarResumen(ByVal Empresa As Integer, ByVal Fecha As DateTime, ByVal Banco As Integer, ByVal Cuenta As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Resumen_cuenta_InsertarResumenCuenta"
        Command.Parameters.Add("@Empresa", SqlDbType.Int, 4, "id_empresa")
        Command.Parameters("@Empresa").Value = Empresa
        Command.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "periodo")
        Command.Parameters("@Fecha").Value = Fecha
        Command.Parameters.Add("@Banco", SqlDbType.Int, 4, "id_banco")
        Command.Parameters("@Banco").Value = Banco
        Command.Parameters.Add("@Cuenta", SqlDbType.Int, 4, "id_cuenta")
        Command.Parameters("@Cuenta").Value = Cuenta

        Dim prm As SqlParameter
        prm = Command.Parameters.Add("@idResumenCuenta", SqlDbType.Int, 0, "id_resumen_cuenta")
        prm.Direction = ParameterDirection.Output

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    Public Sub GenerarResumenTotal(ByVal Empresa As Integer, ByVal Fecha As DateTime, ByVal idCuenta As Integer, ByVal Banco As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Resumen_cuenta_InsertarResumenCuenta2"
        Command.Parameters.Add("@Empresa", SqlDbType.Int, 4, "id_empresa")
        Command.Parameters("@Empresa").Value = Empresa
        Command.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "periodo")
        Command.Parameters("@Fecha").Value = Fecha
        Command.Parameters.Add("@idCuenta", SqlDbType.Int, 4, "id_cuenta")
        Command.Parameters("@idCuenta").Value = idCuenta
        Command.Parameters.Add("@Banco", SqlDbType.Int, 4, "id_banco")
        Command.Parameters("@Banco").Value = Banco

        Dim prm As SqlParameter
        prm = Command.Parameters.Add("@idResumenCuenta", SqlDbType.Int, 0, "id_resumen_cuenta")
        prm.Direction = ParameterDirection.Output

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    Public Function TraerSaldoAnteriorBanco(ByVal Empresa As Integer, ByVal Fecha As DateTime, ByVal idCuenta As Integer) As Decimal
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Resumen_cuenta_ConsultarSaldoBanco", cnn.Coneccion)
        Dim Total As Decimal

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@Empresa", SqlDbType.Int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@Empresa").Value = Empresa
        oda.SelectCommand.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "fecha_saldo")
        oda.SelectCommand.Parameters("@Fecha").Value = Fecha
        oda.SelectCommand.Parameters.Add("@idCuenta", SqlDbType.Int, 4, "id_cuenta")
        oda.SelectCommand.Parameters("@idCuenta").Value = idCuenta

        oda.Fill(odt)
        Total = CDec(odt.Rows(0).Item("Total"))

        Return Total
    End Function

    Public Function ConsultarResumen(ByVal Empresa As Integer, ByVal Fecha As DateTime, ByVal Banco As Integer, ByVal Cuenta As Integer) As DataTable
        dt = New DataTable
        da = New SqlDataAdapter("cop_Resumen_cuenta_ConsultarResumenCuenta2", cnn.Coneccion)

        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.SelectCommand.Parameters.Add("@Empresa", SqlDbType.Int, 4, "id_empresa")
        da.SelectCommand.Parameters("@Empresa").Value = Empresa
        da.SelectCommand.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "fecha")
        da.SelectCommand.Parameters("@Fecha").Value = Fecha
        da.SelectCommand.Parameters.Add("@Banco", SqlDbType.Int, 4, "id_banco")
        da.SelectCommand.Parameters("@Banco").Value = Banco
        da.SelectCommand.Parameters.Add("@Cuenta", SqlDbType.Int, 4, "id_cuenta")
        da.SelectCommand.Parameters("@Cuenta").Value = Cuenta

        da.Fill(dt)

        Return dt
    End Function

End Class
