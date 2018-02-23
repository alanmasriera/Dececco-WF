Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Resumen_cuenta_caja
    Inherits Resumen_cuenta_caja_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Resumen_cuenta_caja As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Resumen_cuenta_caja", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_resumen_cuenta_caja", SqlDbType.Int, 4, "id_resumen_cuenta_caja")
        oda.SelectCommand.Parameters("@id_resumen_cuenta_caja").Value = id_Resumen_cuenta_caja

        oda.Fill(odt)
        Return odt
    End Function

    Public Sub GenerarResumen(ByVal id_empresa As Integer, ByVal fecha As DateTime, ByVal id_banco As Integer, ByVal id_cuenta As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Resumen_cuenta_caja_InsertarResumenCuenta"
        Command.Parameters.Add("@id_empresa", SqlDbType.Int, 4, "id_id_empresa")
        Command.Parameters("@id_empresa").Value = id_empresa
        Command.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "periodo")
        Command.Parameters("@fecha").Value = fecha
        Command.Parameters.Add("@id_banco", SqlDbType.Int, 4, "id_id_banco")
        Command.Parameters("@id_banco").Value = id_banco
        Command.Parameters.Add("@id_cuenta", SqlDbType.Int, 4, "id_id_cuenta")
        Command.Parameters("@id_cuenta").Value = id_cuenta

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    Public Function ConsultarResumen(ByVal id_empresa As Integer, ByVal fecha As DateTime, ByVal id_banco As Integer, ByVal id_cuenta As Integer) As DataTable
        dt = New DataTable
        da = New SqlDataAdapter("cop_Resumen_cuenta_caja_ConsultarResumenCuenta2", cnn.Coneccion)

        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.SelectCommand.Parameters.Add("@id_empresa", SqlDbType.Int, 4, "id_empresa")
        da.SelectCommand.Parameters("@id_empresa").Value = id_empresa
        da.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        da.SelectCommand.Parameters("@fecha").Value = fecha
        da.SelectCommand.Parameters.Add("@id_banco", SqlDbType.Int, 4, "id_banco")
        da.SelectCommand.Parameters("@id_banco").Value = id_banco
        da.SelectCommand.Parameters.Add("@id_cuenta", SqlDbType.Int, 4, "id_cuenta")
        da.SelectCommand.Parameters("@id_cuenta").Value = id_cuenta

        da.Fill(dt)

        Return dt
    End Function

    Public Function TraerSaldoAnteriorBanco(ByVal id_empresa As Integer, ByVal fecha As DateTime, ByVal id_cuenta As Integer) As Decimal
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Resumen_cuenta_caja_ConsultarSaldoBanco", cnn.Coneccion)
        Dim Total As Decimal

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_empresa", SqlDbType.Int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@id_empresa").Value = id_empresa
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = fecha
        oda.SelectCommand.Parameters.Add("@id_cuenta", SqlDbType.Int, 4, "id_cuenta")
        oda.SelectCommand.Parameters("@id_cuenta").Value = id_cuenta

        oda.Fill(odt)
        Total = CDec(odt.Rows(0).Item("Total"))

        Return Total
    End Function


    Public Sub GenerarResumenTotal(ByVal id_empresa As Integer, ByVal fecha As DateTime, ByVal id_cuenta As Integer, ByVal id_banco As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Resumen_cuenta_caja_InsertarResumenCuenta2"
        Command.Parameters.Add("@id_empresa", SqlDbType.Int, 4, "id_id_empresa")
        Command.Parameters("@id_empresa").Value = id_empresa
        Command.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "periodo")
        Command.Parameters("@fecha").Value = fecha
        Command.Parameters.Add("@id_banco", SqlDbType.Int, 4, "id_id_banco")
        Command.Parameters("@id_banco").Value = id_banco
        Command.Parameters.Add("@id_cuenta", SqlDbType.Int, 4, "id_id_cuenta")
        Command.Parameters("@id_cuenta").Value = id_cuenta

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    Public Sub Update()
        Me.CrearComandoUpdate()
    End Sub
End Class
