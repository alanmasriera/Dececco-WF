Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Saldo_iva
    Inherits Saldo_iva_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Saldo_iva As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Saldo_iva", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_saldo_Iva", SqlDbType.Int, 4, "id_saldo_Iva")
        oda.SelectCommand.Parameters("@id_saldo_Iva").Value = id_Saldo_iva

        oda.Fill(odt)
        Return odt
    End Function


    'trae el row con el ultimo saldo
    Public Function GetMaxSaldo(ByVal id_empresa As Integer, ByVal id_iva As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Saldo_iva_GetMax", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_empresa", SqlDbType.Int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@id_empresa").Value = id_empresa
        oda.SelectCommand.Parameters.Add("@id_iva", SqlDbType.Int, 4, "id_iva")
        oda.SelectCommand.Parameters("@id_iva").Value = id_Iva

        oda.Fill(odt)

        Return odt
    End Function

    'trae los row desde el ultimo saldo hasta today
    Public Function GetSaldo(ByVal id_empresa As Integer, ByVal id_iva As Integer, ByVal fecha As DateTime) As Decimal
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Saldo_iva_GetTemp", cnn.Coneccion)
        Dim Total As Decimal

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_empresa", SqlDbType.Int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@id_empresa").Value = id_empresa
        oda.SelectCommand.Parameters.Add("@id_iva", SqlDbType.Int, 4, "id_iva")
        oda.SelectCommand.Parameters("@id_iva").Value = id_Iva
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = fecha

        oda.Fill(odt)
        Total = CDec(odt.Rows(0).Item("Total").ToString)
        Return Total
    End Function

    'trae el saldo anterior
    Public Function GetOldSaldo(ByVal id_empresa As Integer, ByVal id_iva As Integer, ByVal fecha As DateTime) As Decimal
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Saldo_iva_GetOld", cnn.Coneccion)
        Dim Total As Decimal

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_empresa", SqlDbType.Int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@id_empresa").Value = id_empresa
        oda.SelectCommand.Parameters.Add("@id_iva", SqlDbType.Int, 4, "id_iva")
        oda.SelectCommand.Parameters("@id_iva").Value = id_Iva
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = fecha

        oda.Fill(odt)
        Total = CDec(odt.Rows(0).Item("Total").ToString)
        Return Total
    End Function

    'verifica si existe el registro
    Public Function Check(ByVal id_empresa As Integer, ByVal id_iva As Integer, ByVal fecha As DateTime) As Integer
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Saldo_iva_Check", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_empresa", SqlDbType.Int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@id_empresa").Value = id_empresa
        oda.SelectCommand.Parameters.Add("@id_iva", SqlDbType.Int, 4, "id_iva")
        oda.SelectCommand.Parameters("@id_iva").Value = id_Iva
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = fecha

        oda.Fill(odt)
        Total = CInt(odt.Rows(0).Item("Total").ToString)
        Return Total
    End Function

End Class
