Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Saldo_caja
    Inherits Saldo_caja_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Saldo_caja As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Saldo_caja", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_saldo_banco", SqlDbType.Int, 4, "id_saldo_banco")
        oda.SelectCommand.Parameters("@id_saldo_banco").Value = id_Saldo_caja

        oda.Fill(odt)
        Return odt
    End Function

    Public Function ControlarSaldo(ByVal id_empresa As Integer, ByVal fecha As DateTime, ByVal id_cuenta As Integer) As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Saldo_caja_ControlarSaldo", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_empresa", SqlDbType.Int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@id_empresa").Value = id_empresa
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = fecha
        oda.SelectCommand.Parameters.Add("@id_cuenta", SqlDbType.Int, 4, "id_cuenta")
        oda.SelectCommand.Parameters("@id_cuenta").Value = id_cuenta

        oda.Fill(odt)

        Total = CInt(odt.Rows(0).Item("Total"))

        If Total = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function ConsultarSaldoActual(ByVal id_empresa As Integer, ByVal fecha As DateTime, ByVal id_cuenta As Integer) As Integer
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Saldo_caja_ConsultarSaldoActual", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_empresa", SqlDbType.Int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@id_empresa").Value = id_empresa
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = fecha
        oda.SelectCommand.Parameters.Add("@id_cuenta", SqlDbType.Int, 4, "id_cuenta")
        oda.SelectCommand.Parameters("@id_cuenta").Value = id_cuenta

        oda.Fill(odt)

        Total = CInt(odt.Rows(0).Item("Total"))

        Return Total
    End Function

    Public Function GetMaxSaldo(ByVal id_cuenta As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Saldo_caja_GetMax", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cuenta", SqlDbType.Int, 4, "id_cuenta")
        oda.SelectCommand.Parameters("@id_cuenta").Value = id_cuenta

        oda.Fill(odt)

        Return odt
    End Function

End Class
