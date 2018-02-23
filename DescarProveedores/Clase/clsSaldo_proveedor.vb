Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Saldo_proveedor
    Inherits Saldo_proveedor_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Saldo_proveedor As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Saldo_proveedor", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_saldo_proveedor", SqlDbType.Int, 4, "id_saldo_proveedor")
        oda.SelectCommand.Parameters("@id_saldo_proveedor").Value = id_Saldo_proveedor

        oda.Fill(odt)
        Return odt
    End Function



    'trae el row con el ultimo saldo
    Public Function GetMaxSaldo(ByVal id_proveedor As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Saldo_proveedor_GetMax", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proveedor", SqlDbType.Int, 4, "id_proveedor")
        oda.SelectCommand.Parameters("@id_proveedor").Value = id_proveedor

        oda.Fill(odt)

        Return odt
    End Function

    'trae los row desde el ultimo saldo hasta today
    Public Function GetSaldo(ByVal id_proveedor As Integer, ByVal fecha As DateTime, ByVal bandera As String) As Decimal
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Saldo_proveedor_GetTemp1", cnn.Coneccion)
        Dim Total As Decimal

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proveedor", SqlDbType.Int, 4, "id_proveedor")
        oda.SelectCommand.Parameters("@id_proveedor").Value = id_proveedor
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = fecha
        oda.SelectCommand.Parameters.Add("@bandera", SqlDbType.VarChar, 50, "bandera")
        oda.SelectCommand.Parameters("@bandera").Value = bandera

        oda.Fill(odt)
        Total = CDec(odt.Rows(0).Item("Total").ToString)
        Return Total
    End Function

    'trae el saldo anterior
    Public Function GetOldSaldo(ByVal id_proveedor As Integer, ByVal fecha As DateTime) As Decimal
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Saldo_proveedor_GetOld", cnn.Coneccion)
        Dim Total As Decimal

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proveedor", SqlDbType.Int, 4, "id_proveedor")
        oda.SelectCommand.Parameters("@id_proveedor").Value = id_proveedor
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = fecha

        oda.Fill(odt)
        Total = CDec(odt.Rows(0).Item("Total").ToString)
        Return Total
    End Function

    'verifica si existe el registro
    Public Function Check(ByVal id_proveedor As Integer, ByVal fecha As DateTime) As Integer
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Saldo_proveedor_Check", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proveedor", SqlDbType.Int, 4, "id_proveedor")
        oda.SelectCommand.Parameters("@id_proveedor").Value = id_proveedor
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = fecha

        oda.Fill(odt)
        Total = CInt(odt.Rows(0).Item("Total").ToString)
        Return Total
    End Function

 

    Public Sub AbrirPeriodosProveedor(ByVal fecha As DateTime)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Saldo_proveedor_AbrirPeriodos"

        Command.CommandType = CommandType.StoredProcedure
        Command.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        Command.Parameters("@fecha").Value = fecha

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub


End Class
