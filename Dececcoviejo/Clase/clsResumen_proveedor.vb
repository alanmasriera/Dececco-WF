Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Resumen_proveedor
    Inherits Resumen_proveedor_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Resumen_proveedor As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Resumen_proveedor", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_resumen_PROVEEDOR", SqlDbType.Int, 4, "id_resumen_PROVEEDOR")
        oda.SelectCommand.Parameters("@id_resumen_PROVEEDOR").Value = id_Resumen_proveedor

        oda.Fill(odt)
        Return odt
    End Function



    'update la tabla
    Public Sub Update()
        Me.CrearComandoUpdate()
    End Sub

    'genero el resumen de compras
    Public Function SetResumen(ByVal id_proveedor As Integer, ByVal fecha As DateTime, ByVal bandera As String) As DataTable
        dt = New DataTable
        da = New SqlDataAdapter("cop_Resumen_proveedor_Set", cnn.Coneccion)

        da.SelectCommand.CommandType = CommandType.StoredProcedure

        da.SelectCommand.Parameters.Add("@id_proveedor", SqlDbType.Int, 4, "id_proveedor")
        da.SelectCommand.Parameters("@id_proveedor").Value = id_proveedor
        da.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        da.SelectCommand.Parameters("@fecha").Value = fecha
        da.SelectCommand.Parameters.Add("@bandera", SqlDbType.VarChar, 50, "bandera")
        da.SelectCommand.Parameters("@bandera").Value = bandera

        da.Fill(dt)
        Return dt
    End Function


    'genero el resumen del mes
    Public Function SetResumenMonth(ByVal id_proveedor As Integer, ByVal fecha As DateTime) As DataTable
        dt = New DataTable
        da = New SqlDataAdapter("cop_Resumen_proveedor_Set_Month", cnn.Coneccion)

        da.SelectCommand.CommandType = CommandType.StoredProcedure

        da.SelectCommand.Parameters.Add("@id_proveedor", SqlDbType.Int, 4, "id_proveedor")
        da.SelectCommand.Parameters("@id_proveedor").Value = id_proveedor
        da.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        da.SelectCommand.Parameters("@fecha").Value = fecha

        da.Fill(dt)
        Return dt
    End Function

    'genero el resumen entre fecha por proveedor
    Public Function SetResumenBD(ByVal id_proveedor As Integer, ByVal fecha_inicio As DateTime, ByVal fecha_fin As DateTime) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Resumen_proveedor_Set_BD", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure

        oda.SelectCommand.Parameters.Add("@id_proveedor", SqlDbType.Int, 4, "id_proveedor")
        oda.SelectCommand.Parameters("@id_proveedor").Value = id_proveedor
        oda.SelectCommand.Parameters.Add("@fecha_inicio", SqlDbType.DateTime, 8, "fecha_inicio")
        oda.SelectCommand.Parameters("@fecha_inicio").Value = fecha_inicio
        oda.SelectCommand.Parameters.Add("@fecha_fin", SqlDbType.DateTime, 8, "fecha_fin")
        oda.SelectCommand.Parameters("@fecha_fin").Value = fecha_fin

        oda.Fill(odt)
        Return odt
    End Function

    'genero el resumen entre fecha
    Public Function SetResumenBD_All(ByVal fecha_inicio As DateTime, ByVal fecha_fin As DateTime, ByVal bandera As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Resumen_proveedor_Set_BD_All", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure

        oda.SelectCommand.Parameters.Add("@fecha_inicio", SqlDbType.DateTime, 8, "fecha_inicio")
        oda.SelectCommand.Parameters("@fecha_inicio").Value = fecha_inicio
        oda.SelectCommand.Parameters.Add("@fecha_fin", SqlDbType.DateTime, 8, "fecha_fin")
        oda.SelectCommand.Parameters("@fecha_fin").Value = fecha_fin
        oda.SelectCommand.Parameters.Add("@bandera", SqlDbType.VarChar, 50, "bandera")
        oda.SelectCommand.Parameters("@bandera").Value = bandera

        oda.Fill(odt)
        Return odt
    End Function

    'sumo
    Public Function SetResumenBD_All_Sum() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Resumen_proveedor_Set_BD_All_Sum", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure

        oda.Fill(odt)
        Return odt
    End Function

End Class
