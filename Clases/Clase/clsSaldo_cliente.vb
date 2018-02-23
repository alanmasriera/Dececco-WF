Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Saldo_cliente
    Inherits Saldo_cliente_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Saldo_cliente As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Saldo_cliente", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_saldo_cliente", SqlDbType.Int, 4, "id_saldo_cliente")
        oda.SelectCommand.Parameters("@id_saldo_cliente").Value = id_Saldo_cliente

        oda.Fill(odt)
        Return odt
    End Function


    'trae el row con el ultimo saldo
    Public Function GetMaxSaldo(ByVal id_cliente As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Saldo_cliente_GetMax", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.Int, 4, "id_cliente")
        oda.SelectCommand.Parameters("@id_cliente").Value = id_cliente

        oda.Fill(odt)

        Return odt
    End Function

    'trae los row desde el ultimo saldo hasta today
    Public Function GetSaldo(ByVal id_cliente As Integer, ByVal fecha As DateTime) As Decimal
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Saldo_cliente_GetTemp", cnn.Coneccion)
        Dim Total As Decimal

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.Int, 4, "id_cliente")
        oda.SelectCommand.Parameters("@id_cliente").Value = id_cliente
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = fecha

        oda.Fill(odt)
        Total = CDec(odt.Rows(0).Item("Total"))
        Return Total
    End Function

    'trae el saldo anterior
    Public Function GetOldSaldo(ByVal id_cliente As Integer, ByVal fecha As DateTime) As Decimal
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Saldo_cliente_GetOld", cnn.Coneccion)
        Dim Total As Decimal

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.Int, 4, "id_cliente")
        oda.SelectCommand.Parameters("@id_cliente").Value = id_cliente
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = fecha

        oda.Fill(odt)
        Total = CDec(odt.Rows(0).Item("Total"))
        Return Total
    End Function

    'verifica si existe el registro
    Public Function Check(ByVal id_cliente As Integer, ByVal fecha As DateTime) As Integer
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Saldo_cliente_Check", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.Int, 4, "id_cliente")
        oda.SelectCommand.Parameters("@id_cliente").Value = id_cliente
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = fecha

        oda.Fill(odt)
        Total = CInt(odt.Rows(0).Item("Total"))
        Return Total
    End Function

End Class
