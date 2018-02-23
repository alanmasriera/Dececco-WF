Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Saldo_bancos
    Inherits Saldo_bancos_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Saldo_bancos As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Saldo_bancos", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_saldo_banco", SqlDbType.Int, 4, "id_saldo_banco")
        oda.SelectCommand.Parameters("@id_saldo_banco").Value = id_Saldo_bancos

        oda.Fill(odt)
        Return odt
    End Function

    Public Function Consultar(ByVal Empresa As Integer, ByVal Fecha As DateTime, ByVal idCuenta As Integer) As Decimal
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Saldo_ConsultarSaldoBanco", cnn.Coneccion)
        Dim Total As Decimal

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@Empresa", SqlDbType.Int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@Empresa").Value = Empresa
        oda.SelectCommand.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "fecha_saldo")
        oda.SelectCommand.Parameters("@Fecha").Value = Fecha
        oda.SelectCommand.Parameters.Add("@idCuenta", SqlDbType.Int, 4, "id_cuenta")
        oda.SelectCommand.Parameters("@idCuenta").Value = idCuenta

        oda.Fill(odt)

        Total = CDec(odt.Rows(0).Item("Total").ToString)

        Return Total
    End Function

    'Public Function ConsultarSaldo2(ByVal Empresa As Integer, ByVal Fecha As DateTime, ByVal idCuenta As Integer) As Decimal
    '    Dim odt As New DataTable
    '    Dim oda As New SqlDataAdapter("ConsultarSaldoBanco2", cnn.Coneccion)
    '    Dim Total As Decimal

    '    oda.SelectCommand.CommandType = CommandType.StoredProcedure
    '    oda.SelectCommand.Parameters.Add("@Empresa", SqlDbType.Int, 4, "id_empresa")
    '    oda.SelectCommand.Parameters("@Empresa").Value = Empresa
    '    oda.SelectCommand.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "fecha_saldo")
    '    oda.SelectCommand.Parameters("@Fecha").Value = Fecha
    '    oda.SelectCommand.Parameters.Add("@idCuenta", SqlDbType.Int, 4, "id_cuenta")
    '    oda.SelectCommand.Parameters("@idCuenta").Value = idCuenta
    '    '    Try
    '    oda.Fill(odt)
    '    Dim odw As DataView
    '    odw = odt.DefaultView
    '    Total = CDec(odw(0)("Total").ToString)
    '    ' Catch ex As Exception
    '    ' MessageBox.Show(ex.Message)
    '    ' End Try
    '    Return Total
    'End Function

    'Public Function ConsultarSaldoLibre(ByVal Empresa As Integer, ByVal Fecha As DateTime) As Decimal
    '    Dim odt As New DataTable
    '    Dim oda As New SqlDataAdapter("ConsultarSaldoLibre", cnn.Coneccion)
    '    Dim Total As Decimal

    '    oda.SelectCommand.CommandType = CommandType.StoredProcedure
    '    oda.SelectCommand.Parameters.Add("@Empresa", SqlDbType.Int, 4, "id_empresa")
    '    oda.SelectCommand.Parameters("@Empresa").Value = Empresa
    '    oda.SelectCommand.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "fecha_saldo")
    '    oda.SelectCommand.Parameters("@Fecha").Value = Fecha
    '    '    Try
    '    oda.Fill(odt)
    '    Dim odw As DataView
    '    odw = odt.DefaultView
    '    Total = CDec(odw(0)("Total").ToString)
    '    ' Catch ex As Exception
    '    ' MessageBox.Show(ex.Message)
    '    ' End Try
    '    Return Total
    'End Function

    Public Function ConsultarSaldoActual(ByVal Empresa As Integer, ByVal Fecha As DateTime, ByVal idCuenta As Integer) As Integer
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Saldo_ConsultarSaldoBancoActual", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@Empresa", SqlDbType.Int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@Empresa").Value = Empresa
        oda.SelectCommand.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "fecha_saldo")
        oda.SelectCommand.Parameters("@Fecha").Value = Fecha
        oda.SelectCommand.Parameters.Add("@idCuenta", SqlDbType.Int, 4, "id_cuenta")
        oda.SelectCommand.Parameters("@idCuenta").Value = idCuenta

        oda.Fill(odt)

        Total = CInt(odt.Rows(0).Item("Total"))

        Return Total
    End Function

    Public Function ControlarSaldo(ByVal Empresa As Integer, ByVal Fecha As DateTime, ByVal idCuenta As Integer) As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Saldo_ControlarSaldoBanco", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@Empresa", SqlDbType.Int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@Empresa").Value = Empresa
        oda.SelectCommand.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "fecha_saldo")
        oda.SelectCommand.Parameters("@Fecha").Value = Fecha
        oda.SelectCommand.Parameters.Add("@idCuenta", SqlDbType.Int, 4, "id_cuenta")
        oda.SelectCommand.Parameters("@idCuenta").Value = idCuenta

        oda.Fill(odt)

        Total = CInt(odt.Rows(0).Item("Total"))

        If Total = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    'Public Function ControlarBandera(ByVal Empresa As Integer, ByVal Fecha As DateTime) As Boolean
    '    Dim odt As New DataTable
    '    Dim oda As New SqlDataAdapter("ControlarBandera", cnn.Coneccion)
    '    Dim Total As Decimal

    '    oda.SelectCommand.CommandType = CommandType.StoredProcedure
    '    oda.SelectCommand.Parameters.Add("@Empresa", SqlDbType.Int, 4, "id_empresa")
    '    oda.SelectCommand.Parameters("@Empresa").Value = Empresa
    '    oda.SelectCommand.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "fecha_saldo")
    '    oda.SelectCommand.Parameters("@Fecha").Value = Fecha

    '    oda.Fill(odt)
    '    Dim odw As DataView
    '    odw = odt.DefaultView
    '    Total = CDec(odw(0)("Total").ToString)

    '    If Total = 0 Then
    '        Return True
    '    Else
    '        Return False
    '    End If
    'End Function


    Public Function GetMaxSaldo(ByVal id_cuenta As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Saldo_bancos_GetMax", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cuenta", SqlDbType.Int, 4, "id_cuenta")
        oda.SelectCommand.Parameters("@id_cuenta").Value = id_cuenta

        oda.Fill(odt)

        Return odt
    End Function

End Class
