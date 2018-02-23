Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Resumen_temporal
    Inherits Resumen_temporal_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Resumen_temporal As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Resumen_temporal", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_resumen_cuenta", SqlDbType.Int, 4, "id_resumen_cuenta")
        oda.SelectCommand.Parameters("@id_resumen_cuenta").Value = id_Resumen_temporal

        oda.Fill(odt)
        Return odt
    End Function

    Public Sub GetResumen(ByVal Empresa As Integer, ByVal Fecha As DateTime, ByVal idCuenta As Integer, ByVal Banco As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Resumen_temporal_GetTemp"
        Command.Parameters.Add("@Empresa", SqlDbType.Int, 4, "id_empresa")
        Command.Parameters("@Empresa").Value = Empresa
        Command.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "fecha")
        Command.Parameters("@Fecha").Value = Fecha
        Command.Parameters.Add("@Cuenta", SqlDbType.Int, 4, "id_cuenta")
        Command.Parameters("@Cuenta").Value = idCuenta
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

    'EJ PARA CONSULTAR CON PARAMETROS Y TRAER UN DECIMAL
    Public Function GetSum() As Decimal
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Resumen_temporal_GetSum", cnn.Coneccion)
        Dim Total As Decimal

        oda.SelectCommand.CommandType = CommandType.StoredProcedure

        oda.Fill(odt)
        Total = CDec(odt.Rows(0).Item("Total"))
        Return Total
    End Function

    'realiza el resumen hasta la fecha ingresada
    Public Sub GetResumenContable(ByVal Empresa As Integer, ByVal Fecha As DateTime, ByVal idCuenta As Integer, ByVal Banco As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Resumen_temporal_GetTempContable"
        Command.Parameters.Add("@Empresa", SqlDbType.Int, 4, "id_empresa")
        Command.Parameters("@Empresa").Value = Empresa
        Command.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "fecha")
        Command.Parameters("@Fecha").Value = Fecha
        Command.Parameters.Add("@Cuenta", SqlDbType.Int, 4, "id_cuenta")
        Command.Parameters("@Cuenta").Value = idCuenta
        Command.Parameters.Add("@Banco", SqlDbType.Int, 4, "id_banco")
        Command.Parameters("@Banco").Value = Banco
        '  Command.Parameters.Add("@fecha_limite", SqlDbType.DateTime, 8, "fecha_limite")
        '  Command.Parameters("@fecha_limite").Value = fecha_limite

        Dim prm As SqlParameter
        prm = Command.Parameters.Add("@idResumenCuenta", SqlDbType.Int, 0, "id_resumen_cuenta")
        prm.Direction = ParameterDirection.Output

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

End Class
