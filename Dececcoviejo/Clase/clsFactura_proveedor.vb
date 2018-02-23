Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Factura_proveedor
    Inherits Factura_proveedor_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Factura_proveedor As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_proveedor", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_factura_proveedor", SqlDbType.Int, 4, "id_factura_proveedor")
        oda.SelectCommand.Parameters("@id_factura_proveedor").Value = id_Factura_proveedor

        oda.Fill(odt)
        Return odt
    End Function

    'consulta la grilla de factura
    Public Function GetAll_3(ByVal id_empresa As Integer, ByVal id_proveedor As Integer, ByVal fecha As DateTime, ByVal consulta As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_proveedor_GetAll_3", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_empresa", SqlDbType.Int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@id_empresa").Value = id_empresa
        oda.SelectCommand.Parameters.Add("@id_proveedor", SqlDbType.Int, 4, "id_proveedor")
        oda.SelectCommand.Parameters("@id_proveedor").Value = id_proveedor
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = fecha
        oda.SelectCommand.Parameters.Add("@consulta", SqlDbType.Int, 4, "consulta")
        oda.SelectCommand.Parameters("@consulta").Value = consulta

        oda.Fill(odt)
        Return odt
    End Function

    Public Sub UpdateTilde(ByVal id_Factura_proveedor As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Factura_proveedor_UpdateTilde"

        Command.CommandType = CommandType.StoredProcedure
        Command.Parameters.Add("@id_Factura_proveedor", SqlDbType.Int, 4, "id_Factura_proveedor")
        Command.Parameters("@id_Factura_proveedor").Value = id_Factura_proveedor

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'consulta segun el estado
    Public Function GetAllEstado(ByVal id_empresa As Integer, ByVal id_proveedor As Integer, ByVal estado As Char) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_proveedor_GetAllEstado", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proveedor", SqlDbType.Int, 4, "id_proveedor")
        oda.SelectCommand.Parameters("@id_proveedor").Value = id_proveedor
        oda.SelectCommand.Parameters.Add("@estado", SqlDbType.Char, 1, "estado")
        oda.SelectCommand.Parameters("@estado").Value = estado
        oda.SelectCommand.Parameters.Add("@id_empresa", SqlDbType.Int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@id_empresa").Value = id_empresa

        oda.Fill(odt)
        Return odt
    End Function

    'update el estado
    Public Function UpdateEstado(ByVal id_empresa As Integer, ByVal id_proveedor As Integer, ByVal estado_viejo As Char, ByVal estado_nuevo As Char) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_proveedor_UpdateEstado", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_empresa", SqlDbType.Int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@id_empresa").Value = id_empresa
        oda.SelectCommand.Parameters.Add("@id_proveedor", SqlDbType.Int, 4, "id_proveedor")
        oda.SelectCommand.Parameters("@id_proveedor").Value = id_proveedor
        oda.SelectCommand.Parameters.Add("@estado_viejo", SqlDbType.Char, 1, "estado_viejo")
        oda.SelectCommand.Parameters("@estado_viejo").Value = estado_viejo
        oda.SelectCommand.Parameters.Add("@estado_nuevo", SqlDbType.Char, 1, "estado_nuevo")
        oda.SelectCommand.Parameters("@estado_nuevo").Value = estado_nuevo

        oda.Fill(odt)
        Return odt
    End Function

    Public Sub ArchivarFactura(ByVal id_factura_proveedor As Integer, ByVal archivada As Boolean)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Factura_Proveedor_Archivar"
        Command.Parameters.Add("@id_factura_proveedor", SqlDbType.Int, 4, "id_factura_proveedor")
        Command.Parameters("@id_factura_proveedor").Value = id_factura_proveedor
        Command.Parameters.Add("@archivada", SqlDbType.Bit, 1, "archivada")
        Command.Parameters("@archivada").Value = archivada

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub



    'funcion de consulta
    Public Function GetAll_2(ByVal fecha As DateTime, ByVal id_proveedor As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_proveedor_GetAll_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = fecha
        oda.SelectCommand.Parameters.Add("@id_proveedor", SqlDbType.Int, 4, "id_proveedor")
        oda.SelectCommand.Parameters("@id_proveedor").Value = id_proveedor

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function GetAll_VencidaBD(ByVal fecha_inicio As DateTime, ByVal fecha_fin As DateTime, ByVal id_proveedor As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_proveedor_GetAll_VencidaBD", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@fecha_inicio", SqlDbType.DateTime, 8, "fecha_inicio")
        oda.SelectCommand.Parameters("@fecha_inicio").Value = fecha_inicio
        oda.SelectCommand.Parameters.Add("@fecha_fin", SqlDbType.DateTime, 8, "fecha_fin")
        oda.SelectCommand.Parameters("@fecha_fin").Value = fecha_fin
        oda.SelectCommand.Parameters.Add("@id_proveedor", SqlDbType.Int, 4, "id_proveedor")
        oda.SelectCommand.Parameters("@id_proveedor").Value = id_proveedor

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function GetAll_VencidaBD_Sum(ByVal fecha_inicio As DateTime, ByVal fecha_fin As DateTime, ByVal id_proveedor As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_proveedor_GetAll_VencidaBD_Sum", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@fecha_inicio", SqlDbType.DateTime, 8, "fecha_inicio")
        oda.SelectCommand.Parameters("@fecha_inicio").Value = fecha_inicio
        oda.SelectCommand.Parameters.Add("@fecha_fin", SqlDbType.DateTime, 8, "fecha_fin")
        oda.SelectCommand.Parameters("@fecha_fin").Value = fecha_fin
        oda.SelectCommand.Parameters.Add("@id_proveedor", SqlDbType.Int, 4, "id_proveedor")
        oda.SelectCommand.Parameters("@id_proveedor").Value = id_proveedor

        oda.Fill(odt)

        Return odt
    End Function

    ''controla si existe el registro en la base de datos
    'Public Function Exist() As Boolean
    '    Dim odt As New DataTable
    '    Dim oda As New SqlDataAdapter("cop_Factura_proveedor_Exist", cnn.Coneccion)
    '    Dim Total As Integer

    '    oda.SelectCommand.CommandType = CommandType.StoredProcedure
    '    oda.SelectCommand.Parameters.Add("@numero_factura", SqlDbType.VarChar, 50, "numero_factura")
    '    oda.SelectCommand.Parameters("@numero_factura").Value = Me.numero_factura
    '    oda.SelectCommand.Parameters.Add("@id_proveedor", SqlDbType.Int, 4, "id_proveedor")
    '    oda.SelectCommand.Parameters("@id_proveedor").Value = Me.id_proveedor
    '    oda.SelectCommand.Parameters.Add("@id_tipo_comprobante", SqlDbType.Int, 4, "id_tipo_comprobante")
    '    oda.SelectCommand.Parameters("@id_tipo_comprobante").Value = Me.id_tipo_comprobante

    '    oda.Fill(odt)
    '    Total = CInt(odt.Rows(0).Item("Total").ToString)
    '    If Total = 0 Then
    '        Return False  'NO EXISTE
    '    Else
    '        Return True 'SI EXISTE
    '    End If
    'End Function

    'facturas entre fechas
    Public Function GetAll_VencidaBD_All(ByVal fecha_inicio As DateTime, ByVal fecha_fin As DateTime) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_proveedor_GetAll_VencidaBD_All", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@fecha_inicio", SqlDbType.DateTime, 8, "fecha_inicio")
        oda.SelectCommand.Parameters("@fecha_inicio").Value = fecha_inicio
        oda.SelectCommand.Parameters.Add("@fecha_fin", SqlDbType.DateTime, 8, "fecha_fin")
        oda.SelectCommand.Parameters("@fecha_fin").Value = fecha_fin

        oda.Fill(odt)

        Return odt
    End Function

    'facturas entre fechas
    Public Function GetAll_VencidaBD_All_Sum(ByVal fecha_inicio As DateTime, ByVal fecha_fin As DateTime) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_proveedor_GetAll_VencidaBD_All_Sum", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@fecha_inicio", SqlDbType.DateTime, 8, "fecha_inicio")
        oda.SelectCommand.Parameters("@fecha_inicio").Value = fecha_inicio
        oda.SelectCommand.Parameters.Add("@fecha_fin", SqlDbType.DateTime, 8, "fecha_fin")
        oda.SelectCommand.Parameters("@fecha_fin").Value = fecha_fin

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function GetAll_Sum(ByVal fecha As DateTime, ByVal id_proveedor As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_proveedor_GetAll_Sum", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = fecha
        oda.SelectCommand.Parameters.Add("@id_proveedor", SqlDbType.Int, 4, "id_proveedor")
        oda.SelectCommand.Parameters("@id_proveedor").Value = id_proveedor

        oda.Fill(odt)

        Return odt
    End Function


    'facturas entre fechas por proveedor
    Public Function GetAll_BPBD(ByVal fecha_inicio As DateTime, ByVal fecha_fin As DateTime) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_proveedor_GetAll_BPBD", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@fecha_inicio", SqlDbType.DateTime, 8, "fecha_inicio")
        oda.SelectCommand.Parameters("@fecha_inicio").Value = fecha_inicio
        oda.SelectCommand.Parameters.Add("@fecha_fin", SqlDbType.DateTime, 8, "fecha_fin")
        oda.SelectCommand.Parameters("@fecha_fin").Value = fecha_fin

        oda.Fill(odt)

        Return odt
    End Function

    'facturas entre fechas por proveedor suma
    Public Function GetAll_BPBD_Sum(ByVal fecha_inicio As DateTime, ByVal fecha_fin As DateTime) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_proveedor_GetAll_BPBD_Sum", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@fecha_inicio", SqlDbType.DateTime, 8, "fecha_inicio")
        oda.SelectCommand.Parameters("@fecha_inicio").Value = fecha_inicio
        oda.SelectCommand.Parameters.Add("@fecha_fin", SqlDbType.DateTime, 8, "fecha_fin")
        oda.SelectCommand.Parameters("@fecha_fin").Value = fecha_fin

        oda.Fill(odt)

        Return odt
    End Function


    'funcion de consulta
    Public Function GetAll_Recibo(ByVal id_proveedor As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_proveedor_GetAll_Recibo", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proveedor", SqlDbType.Int, 4, "id_proveedor")
        oda.SelectCommand.Parameters("@id_proveedor").Value = id_proveedor

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de busqueda de una factura
    Public Function Find_2(ByVal Nombre As String, ByVal id_proveedor As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_proveedor_Find_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre
        oda.SelectCommand.Parameters.Add("@id_proveedor", SqlDbType.Int, 4, "id_proveedor")
        oda.SelectCommand.Parameters("@id_proveedor").Value = id_proveedor

        oda.Fill(odt)

        Return odt
    End Function


    'update la factura con el nuevo saldo
    Public Sub Update_saldo(ByVal id_factura_proveedor As Integer, ByVal saldo_factura_proveedor As Decimal)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Factura_proveedor_Update_2"
        Command.Parameters.Add("@id_factura_proveedor", SqlDbType.Int, 4, "id_factura_proveedor")
        Command.Parameters("@id_factura_proveedor").Value = id_factura_proveedor
        Command.Parameters.Add("@saldo_factura_proveedor", SqlDbType.Decimal, 9, "saldo_factura_proveedor")
        Command.Parameters("@saldo_factura_proveedor").Value = saldo_factura_proveedor
        Command.CommandType = CommandType.StoredProcedure

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'update la factura si esta vendida
    Public Sub Update_pagada(ByVal id_factura_proveedor As Integer, ByVal pagada As Boolean)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Factura_proveedor_Update_3"
        Command.Parameters.Add("@id_factura_proveedor", SqlDbType.Int, 4, "id_factura_proveedor")
        Command.Parameters("@id_factura_proveedor").Value = id_factura_proveedor
        Command.Parameters.Add("@pagada", SqlDbType.Bit, 1, "pagada")
        Command.Parameters("@pagada").Value = pagada
        Command.CommandType = CommandType.StoredProcedure

        oConexion.Abrir()
        Command.ExecuteNonQuery()
        oConexion.Cerrar()
    End Sub

    'funcion que trae un registro poniendo el id
    Public Function GetOne_2(ByVal id_factura_proveedor As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_proveedor_GetOne_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_factura_proveedor", SqlDbType.Int, 4, "id_factura_proveedor")
        oda.SelectCommand.Parameters("@id_factura_proveedor").Value = id_factura_proveedor

        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetPagoRecibo(ByVal id_proveedor As Integer, ByVal id_factura_proveedor As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_proveedor_GetPagoRecibo", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proveedor", SqlDbType.Int, 4, "id_proveedor")
        oda.SelectCommand.Parameters("@id_proveedor").Value = id_proveedor
        oda.SelectCommand.Parameters.Add("@id_factura_proveedor", SqlDbType.Int, 4, "id_factura_proveedor")
        oda.SelectCommand.Parameters("@id_factura_proveedor").Value = id_factura_proveedor

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de busqueda segun el comprobante
    Public Function Find_3(ByVal Nombre As String, ByVal id_proveedor As Integer, ByVal fecha As DateTime) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_proveedor_Find_3", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = fecha
        oda.SelectCommand.Parameters.Add("@id_proveedor", SqlDbType.Int, 4, "id_proveedor")
        oda.SelectCommand.Parameters("@id_proveedor").Value = id_proveedor
        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist_2(ByVal numero As String, ByVal id_proveedor As Integer) As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_proveedor_Exist_2", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@numero", SqlDbType.VarChar, 50, "numero")
        oda.SelectCommand.Parameters("@numero").Value = numero
        oda.SelectCommand.Parameters.Add("@id_proveedor", SqlDbType.Int, 4, "id_proveedor")
        oda.SelectCommand.Parameters("@id_proveedor").Value = id_proveedor

        oda.Fill(odt)
        Total = CInt(odt.Rows(0).Item("Total").ToString)
        If Total = 0 Then
            Return False  'NO EXISTE
        Else
            Return True 'SI EXISTE
        End If
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne_3(ByVal id_factura_proveedor As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_proveedor_GetOne_3", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_factura_proveedor", SqlDbType.Int, 4, "id_factura_proveedor")
        oda.SelectCommand.Parameters("@id_factura_proveedor").Value = id_factura_proveedor

        oda.Fill(odt)

        Return odt
    End Function

    'agregado para obtener un proveedor atraves del numero de factura y id
    Public Function existe(ByVal id_Proveedor As Integer, ByVal id_factura As String, ByVal id_tipo As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_FACTURA_PROVEEDOR_Existe", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proveedor", SqlDbType.Int, 4, "id_proveedor")
        oda.SelectCommand.Parameters("@id_proveedor").Value = id_Proveedor
        oda.SelectCommand.Parameters.Add("@id_factura", SqlDbType.VarChar, 12, "id_factura")
        oda.SelectCommand.Parameters("@id_factura").Value = id_factura
        oda.SelectCommand.Parameters.Add("@id_tipo_comprobante", SqlDbType.Int, 4, "id_tipo_comprobante")
        oda.SelectCommand.Parameters("@id_tipo_comprobante").Value = id_tipo
        oda.Fill(odt)
        Return odt
    End Function

    Public Function GetCmbFacturaProveedor(ByVal id_factura_proveedor As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_GetCmbFacturaProveedor", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        'oda.SelectCommand.Parameters.Add("@id_factura_proveedor", SqlDbType.Int, 4, "id_factura_proveedor")
        'oda.SelectCommand.Parameters("@id_factura_proveedor").Value = id_factura_proveedor

        'agregado borrar
        oda.SelectCommand.Parameters.Add("@id_proveedor", SqlDbType.Int, 4, "id_proveedor")
        oda.SelectCommand.Parameters("@id_proveedor").Value = id_factura_proveedor

        oda.Fill(odt)
        Return odt
    End Function

    'agregado
    Public Function Exist_3(ByVal numero As String, ByVal id_proveedor As Integer) As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_proveedor_Exist_3", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@numero", SqlDbType.VarChar, 50, "numero")
        oda.SelectCommand.Parameters("@numero").Value = numero
        oda.SelectCommand.Parameters.Add("@id_proveedor", SqlDbType.Int, 4, "id_proveedor")
        oda.SelectCommand.Parameters("@id_proveedor").Value = id_proveedor

        oda.Fill(odt)
        Total = CInt(odt.Rows(0).Item("Total").ToString)
        If Total = 0 Then
            Return False  'NO EXISTE
        Else
            Return True 'SI EXISTE
        End If
    End Function

    Public Function GetAll_Entre_Fechas(ByVal fecha_inicio As DateTime, ByVal fecha_fin As DateTime) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_proveedor_GetAll_Entre_Fechas", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@fecha_inicio", SqlDbType.DateTime, 8, "fecha_inicio")
        oda.SelectCommand.Parameters("@fecha_inicio").Value = fecha_inicio
        oda.SelectCommand.Parameters.Add("@fecha_fin", SqlDbType.DateTime, 8, "fecha_fin")
        oda.SelectCommand.Parameters("@fecha_fin").Value = fecha_fin

        oda.Fill(odt)

        Return odt
    End Function


End Class
