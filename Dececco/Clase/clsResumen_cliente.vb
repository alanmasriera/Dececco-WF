Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Resumen_cliente
    Inherits Resumen_cliente_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Resumen_cliente As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Resumen_cliente", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_resumen_cliente", SqlDbType.Int, 4, "id_resumen_cliente")
        oda.SelectCommand.Parameters("@id_resumen_cliente").Value = id_Resumen_cliente

        oda.Fill(odt)
        Return odt
    End Function

    'update la tabla
    Public Sub Update()
        Me.CrearComandoUpdate()
    End Sub

    'genero el resumen de compras
    Public Function SetResumen(ByVal id_cliente As Integer, ByVal fecha As DateTime) As DataTable
        dt = New DataTable
        da = New SqlDataAdapter("cop_Resumen_cliente_Set", cnn.Coneccion)

        da.SelectCommand.CommandType = CommandType.StoredProcedure

        da.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.Int, 4, "id_cliente")
        da.SelectCommand.Parameters("@id_cliente").Value = id_cliente
        da.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        da.SelectCommand.Parameters("@fecha").Value = fecha

        da.Fill(dt)
        Return dt
    End Function

    'genero el resumen del mes
    Public Function SetResumenMonth(ByVal id_cliente As Integer, ByVal fecha As DateTime) As DataTable
        dt = New DataTable
        da = New SqlDataAdapter("cop_Resumen_cliente_Set_Month", cnn.Coneccion)

        da.SelectCommand.CommandType = CommandType.StoredProcedure

        da.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.Int, 4, "id_cliente")
        da.SelectCommand.Parameters("@id_cliente").Value = id_cliente
        da.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        da.SelectCommand.Parameters("@fecha").Value = fecha

        da.Fill(dt)
        Return dt
    End Function

    'genero el resumen entre fecha por cliente
    Public Function SetResumenBD(ByVal id_cliente As Integer, ByVal fecha_inicio As DateTime, ByVal fecha_fin As DateTime) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Resumen_cliente_Set_BD", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure

        oda.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.Int, 4, "id_cliente")
        oda.SelectCommand.Parameters("@id_cliente").Value = id_cliente
        oda.SelectCommand.Parameters.Add("@fecha_inicio", SqlDbType.DateTime, 8, "fecha_inicio")
        oda.SelectCommand.Parameters("@fecha_inicio").Value = fecha_inicio
        oda.SelectCommand.Parameters.Add("@fecha_fin", SqlDbType.DateTime, 8, "fecha_fin")
        oda.SelectCommand.Parameters("@fecha_fin").Value = fecha_fin

        oda.Fill(odt)
        Return odt
    End Function

    'genero el resumen entre fecha
    Public Function SetResumenBD_All(ByVal fecha_inicio As DateTime, ByVal fecha_fin As DateTime) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Resumen_cliente_Set_BD_All", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure

        oda.SelectCommand.Parameters.Add("@fecha_inicio", SqlDbType.DateTime, 8, "fecha_inicio")
        oda.SelectCommand.Parameters("@fecha_inicio").Value = fecha_inicio
        oda.SelectCommand.Parameters.Add("@fecha_fin", SqlDbType.DateTime, 8, "fecha_fin")
        oda.SelectCommand.Parameters("@fecha_fin").Value = fecha_fin

        oda.Fill(odt)
        Return odt
    End Function

    'sumo
    Public Function SetResumenBD_All_Sum() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Resumen_cliente_Set_BD_All_Sum", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure

        oda.Fill(odt)
        Return odt
    End Function

End Class
