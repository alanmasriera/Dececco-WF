Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Factura
    Inherits Factura_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Factura As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_factura", SqlDbType.Int, 4, "id_factura")
        oda.SelectCommand.Parameters("@id_factura").Value = id_Factura

        oda.Fill(odt)
        Return odt
    End Function

    'autonumerico
    Public Function GetTop() As String
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_GetTop", cnn.Coneccion)
        Dim Total As String

        oda.SelectCommand.CommandType = CommandType.StoredProcedure

        oda.Fill(odt)
        Total = odt.Rows(0).Item("Total").ToString
        Return Total
    End Function

    'update el credito como marcado o no
    Public Sub Anular(ByVal id_factura As Integer, ByVal anulada As Boolean)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Factura_Anular"
        Command.Parameters.Add("@id_factura", SqlDbType.Int, 4, "id_factura")
        Command.Parameters("@id_factura").Value = id_factura
        Command.Parameters.Add("@anulada", SqlDbType.Bit, 1, "anulada")
        Command.Parameters("@anulada").Value = anulada

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'FUNCION PARA CONSULTAR TODO
    Public Overloads Function ConsultarTodo(ByVal fecha_factura As DateTime) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_GetAll_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@fecha_factura", SqlDbType.DateTime, 8, "fecha_factura")
        oda.SelectCommand.Parameters("@fecha_factura").Value = fecha_factura

        oda.Fill(odt)

        Return odt
    End Function

    'FUNCION PARA BUSCAR
    Public Overloads Function Buscar(ByVal Nombre As String, ByVal fecha_factura As DateTime) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_Find_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre
        oda.SelectCommand.Parameters.Add("@fecha_factura", SqlDbType.DateTime, 8, "fecha_factura")
        oda.SelectCommand.Parameters("@fecha_factura").Value = fecha_factura

        oda.Fill(odt)

        Return odt
    End Function

    'busca la factura con el id_cliente y el numero de factura
    Public Function GetOne_2(ByVal id_cliente As Integer, ByVal numero_factura As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_GetOne_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.Int, 4, "id_cliente")
        oda.SelectCommand.Parameters("@id_cliente").Value = id_cliente
        oda.SelectCommand.Parameters.Add("@numero_factura", SqlDbType.VarChar, 12, "numero_factura")
        oda.SelectCommand.Parameters("@numero_factura").Value = numero_factura

        oda.Fill(odt)

        Return odt
    End Function

    'total facturado a un cliente
    Public Function GetAll_Sum(ByVal id_cliente As Integer, ByVal periodo As DateTime) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_GetAll_Sum", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.Int, 4, "id_cliente")
        oda.SelectCommand.Parameters("@id_cliente").Value = id_cliente
        oda.SelectCommand.Parameters.Add("@periodo", SqlDbType.DateTime, 8, "periodo")
        oda.SelectCommand.Parameters("@periodo").Value = periodo

        oda.Fill(odt)

        Return odt
    End Function

    'FUNCION PARA CONSULTAR TODO
    Public Function ConsultarTodo_2(ByVal fecha_factura As DateTime) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_GetAll_2", cnn.Coneccion)
        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@fecha_factura", SqlDbType.DateTime, 8, "fecha_factura")
        oda.SelectCommand.Parameters("@fecha_factura").Value = fecha_factura

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de busqueda
    Public Function Buscarcliente(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_FindCliente", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'llena un combo con las facturas de un cliente
    Public Function GetCmbFacturaCliente(ByVal id_cliente As Integer) As DataTable
        Dim odt As New DataTable
        'Dim oda As New SqlDataAdapter("cop_Factura_GetCmbFacturaCliente", cnn.Coneccion)
        Dim oda As New SqlDataAdapter("cop_Factura_GetCmbFacturaCliente_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.Int, 4, "id_cliente")
        oda.SelectCommand.Parameters("@id_cliente").Value = id_cliente

        oda.Fill(odt)
        Return odt
    End Function

    'archiva y desarchiva una factura
    Public Sub ArchivarFactura(ByVal id_factura As Integer, ByVal archivada As Boolean)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Factura_Archivar"
        Command.Parameters.Add("@id_factura", SqlDbType.Int, 4, "id_factura")
        Command.Parameters("@id_factura").Value = id_factura
        Command.Parameters.Add("@archivada", SqlDbType.Bit, 1, "archivada")
        Command.Parameters("@archivada").Value = archivada

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'busca comprobantes duplicados
    Public Function GetExist(ByVal id_cliente As Integer, ByVal numero_factura As String, ByVal tipo_factura As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_GetExist", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.Int, 4, "id_cliente")
        oda.SelectCommand.Parameters("@id_cliente").Value = id_cliente
        oda.SelectCommand.Parameters.Add("@numero_factura", SqlDbType.VarChar, 12, "numero_factura")
        oda.SelectCommand.Parameters("@numero_factura").Value = numero_factura
        oda.SelectCommand.Parameters.Add("@tipo_factura", SqlDbType.VarChar, 50, "tipo_factura")
        oda.SelectCommand.Parameters("@tipo_factura").Value = tipo_factura

        oda.Fill(odt)

        Return odt
    End Function
    Public Function GetExist1(ByVal id_cliente As Integer, ByVal numero_factura As String, ByVal tipo_factura As String) As DataTable
        Dim odt As New DataTable

        Dim oda As New SqlDataAdapter("cop_Factura_GetExist1", cnn.Coneccion)
        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.Int, 4, "id_cliente")
        oda.SelectCommand.Parameters("@id_cliente").Value = id_cliente
        oda.SelectCommand.Parameters.Add("@numero_factura", SqlDbType.VarChar, 12, "numero_factura")
        oda.SelectCommand.Parameters("@numero_factura").Value = numero_factura
        oda.SelectCommand.Parameters.Add("@tipo_factura", SqlDbType.VarChar, 50, "tipo_factura")
        oda.SelectCommand.Parameters("@tipo_factura").Value = tipo_factura

        oda.Fill(odt)

        Return odt
    End Function

    'agregado obtiene la ultima factura
    Public Function UltimaFactura() As Integer
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_ObtenerUltimo", cnn.Coneccion)
        Dim ultimo As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)
        ultimo = CInt(odt.Rows(0).Item("ultimo").ToString)
        Return ultimo
    End Function


    'agregado
    Public Function GetAll_VencidaBD(ByVal fecha_inicio As DateTime, ByVal fecha_fin As DateTime) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_GetAll_VencidaBD", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@fecha_inicio", SqlDbType.DateTime, 8, "fecha_inicio")
        oda.SelectCommand.Parameters("@fecha_inicio").Value = fecha_inicio
        oda.SelectCommand.Parameters.Add("@fecha_fin", SqlDbType.DateTime, 8, "fecha_fin")
        oda.SelectCommand.Parameters("@fecha_fin").Value = fecha_fin
        oda.Fill(odt)

        Return odt
    End Function


    'funcion de consulta
    Public Function GetAll_VencidaBD(ByVal fecha_inicio As DateTime, ByVal fecha_fin As DateTime, ByVal id_cliente As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_cliente_GetAll_VencidaBD", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@fecha_inicio", SqlDbType.DateTime, 8, "fecha_inicio")
        oda.SelectCommand.Parameters("@fecha_inicio").Value = fecha_inicio
        oda.SelectCommand.Parameters.Add("@fecha_fin", SqlDbType.DateTime, 8, "fecha_fin")
        oda.SelectCommand.Parameters("@fecha_fin").Value = fecha_fin
        oda.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.Int, 4, "id_cliente")
        oda.SelectCommand.Parameters("@id_cliente").Value = id_cliente

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function GetAll_VencidaBD_Sum(ByVal fecha_inicio As DateTime, ByVal fecha_fin As DateTime, ByVal id_cliente As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_cliente_GetAll_VencidaBD_Sum", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@fecha_inicio", SqlDbType.DateTime, 8, "fecha_inicio")
        oda.SelectCommand.Parameters("@fecha_inicio").Value = fecha_inicio
        oda.SelectCommand.Parameters.Add("@fecha_fin", SqlDbType.DateTime, 8, "fecha_fin")
        oda.SelectCommand.Parameters("@fecha_fin").Value = fecha_fin
        oda.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.Int, 4, "id_cliente")
        oda.SelectCommand.Parameters("@id_cliente").Value = id_cliente

        oda.Fill(odt)

        Return odt
    End Function

    ''controla si existe el registro en la base de datos
    'Public Function Exist() As Boolean
    '    Dim odt As New DataTable
    '    Dim oda As New SqlDataAdapter("cop_Factura_cliente_Exist", cnn.Coneccion)
    '    Dim Total As Integer

    '    oda.SelectCommand.CommandType = CommandType.StoredProcedure
    '    oda.SelectCommand.Parameters.Add("@numero_factura", SqlDbType.VarChar, 50, "numero_factura")
    '    oda.SelectCommand.Parameters("@numero_factura").Value = Me.numero_factura
    '    oda.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.Int, 4, "id_cliente")
    '    oda.SelectCommand.Parameters("@id_cliente").Value = Me.id_cliente
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
        Dim oda As New SqlDataAdapter("cop_Factura_cliente_GetAll_VencidaBD_All", cnn.Coneccion)

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
        Dim oda As New SqlDataAdapter("cop_Factura_cliente_GetAll_VencidaBD_All_Sum", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@fecha_inicio", SqlDbType.DateTime, 8, "fecha_inicio")
        oda.SelectCommand.Parameters("@fecha_inicio").Value = fecha_inicio
        oda.SelectCommand.Parameters.Add("@fecha_fin", SqlDbType.DateTime, 8, "fecha_fin")
        oda.SelectCommand.Parameters("@fecha_fin").Value = fecha_fin

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function GetAll_Sum(ByVal fecha As DateTime, ByVal id_cliente As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_cliente_GetAll_Sum", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = fecha
        oda.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.Int, 4, "id_cliente")
        oda.SelectCommand.Parameters("@id_cliente").Value = id_cliente

        oda.Fill(odt)

        Return odt
    End Function

    'facturas entre fechas por cliente
    Public Function GetAll_BPBD(ByVal fecha_inicio As DateTime, ByVal fecha_fin As DateTime) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_cliente_GetAll_BPBD", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@fecha_inicio", SqlDbType.DateTime, 8, "fecha_inicio")
        oda.SelectCommand.Parameters("@fecha_inicio").Value = fecha_inicio
        oda.SelectCommand.Parameters.Add("@fecha_fin", SqlDbType.DateTime, 8, "fecha_fin")
        oda.SelectCommand.Parameters("@fecha_fin").Value = fecha_fin

        oda.Fill(odt)

        Return odt
    End Function

    'facturas entre fechas por cliente suma
    Public Function GetAll_BPBD_Sum(ByVal fecha_inicio As DateTime, ByVal fecha_fin As DateTime) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_cliente_GetAll_BPBD_Sum", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@fecha_inicio", SqlDbType.DateTime, 8, "fecha_inicio")
        oda.SelectCommand.Parameters("@fecha_inicio").Value = fecha_inicio
        oda.SelectCommand.Parameters.Add("@fecha_fin", SqlDbType.DateTime, 8, "fecha_fin")
        oda.SelectCommand.Parameters("@fecha_fin").Value = fecha_fin

        oda.Fill(odt)

        Return odt
    End Function

End Class
