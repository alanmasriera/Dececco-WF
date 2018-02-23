Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Factura_recibo_proveedor
    Inherits Factura_recibo_proveedor_ent

    'ejemplo de consulta con parametros
    Public Function Ejemplo(ByVal id_Factura_recibo_proveedor As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_recibo_proveedor", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_factura_recibo_proveedor", SqlDbType.Int, 4, "id_factura_recibo_proveedor")
        oda.SelectCommand.Parameters("@id_factura_recibo_proveedor").Value = id_Factura_recibo_proveedor

        oda.Fill(odt)
        Return odt
    End Function



    'funcion de consulta
    Public Function GetAll_2(ByVal id_recibo_proveedor As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_recibo_proveedor_GetAll_2", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_recibo_proveedor", SqlDbType.Int, 4, "id_recibo_proveedor")
        oda.SelectCommand.Parameters("@id_recibo_proveedor").Value = id_recibo_proveedor

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function GetAll_Sum(ByVal id_recibo_proveedor As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_recibo_proveedor_GetAll_Sum", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_recibo_proveedor", SqlDbType.Int, 4, "id_recibo_proveedor")
        oda.SelectCommand.Parameters("@id_recibo_proveedor").Value = id_recibo_proveedor

        oda.Fill(odt)

        Return odt
    End Function

    'update la factura con el nuevo saldo
    Public Sub Update_saldo_factura(ByVal id_factura As Integer, ByVal saldo_factura As Decimal)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Factura_proveedor_Update_4"
        Command.Parameters.Add("@id_factura", SqlDbType.Int, 4, "id_factura")
        Command.Parameters("@id_factura").Value = id_factura
        Command.Parameters.Add("@saldo_factura", SqlDbType.Decimal, 9, "saldo_factura")
        Command.Parameters("@saldo_factura").Value = saldo_factura
        Command.CommandType = CommandType.StoredProcedure

        oConexion.Abrir()
        Command.ExecuteNonQuery()
        oConexion.Cerrar()
    End Sub


    'controla si existe el registro en la base de datos
    Public Function Exist_2() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_recibo_proveedor_Exist_2", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_factura_proveedor", SqlDbType.Int, 4, "id_factura_proveedor")
        oda.SelectCommand.Parameters("@id_factura_proveedor").Value = Me.id_factura_proveedor
        oda.SelectCommand.Parameters.Add("@id_recibo_proveedor", SqlDbType.Int, 4, "id_recibo_proveedor")
        oda.SelectCommand.Parameters("@id_recibo_proveedor").Value = Me.id_recibo_proveedor

        oda.Fill(odt)
        Total = CInt(odt.Rows(0).Item("Total").ToString)
        If Total = 0 Then
            Return False  'NO EXISTE
        Else
            Return True 'SI EXISTE
        End If
    End Function

    'funcion de consulta
    Public Function GetAll_3(ByVal id_recibo_proveedor As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_recibo_proveedor_GetAll_3", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_recibo_proveedor", SqlDbType.Int, 4, "id_recibo_proveedor")
        oda.SelectCommand.Parameters("@id_recibo_proveedor").Value = id_recibo_proveedor

        oda.Fill(odt)

        Return odt
    End Function

    'controla si hay una factura con recibo
    Public Function Exist_3(ByVal id_factura As Integer, ByVal id_proveedor As Integer) As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_recibo_proveedor_Exist_3", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_factura", SqlDbType.Int, 4, "id_factura")
        oda.SelectCommand.Parameters("@id_factura").Value = id_factura
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

    'funcion de consulta
    Public Function GetAll_4(ByVal id_proveedor As Integer, ByVal numero_recibo As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_recibo_proveedor_GetAll_4", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_proveedor", SqlDbType.Int, 4, "id_proveedor")
        oda.SelectCommand.Parameters("@id_proveedor").Value = id_proveedor
        oda.SelectCommand.Parameters.Add("@numero_recibo", SqlDbType.VarChar, 50, "numero_recibo")
        oda.SelectCommand.Parameters("@numero_recibo").Value = numero_recibo

        oda.Fill(odt)

        Return odt
    End Function

    Public Sub DeleteFacturaRecibo_proveedor(ByVal id_Recibo_proveedor As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_FacturaRecibo_Proveedor_DeleteRecibo_proveedor"
        Command.Parameters.Add("@id_recibo_proveedor", SqlDbType.Int, 4, "id_recibo_proveedor")
        Command.Parameters("@id_recibo_proveedor").Value = id_Recibo_proveedor

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra los datos relacionados al encabezado
    Public Sub UpdateID(ByVal id_Recibo_proveedor As Integer)
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Factura_recibo_proveedor_UpdateID"
        Command.Parameters.Add("@id_recibo_proveedor", SqlDbType.Int, 4, "id_recibo_proveedor")
        Command.Parameters("@id_recibo_proveedor").Value = id_Recibo_proveedor
        'Command.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        'Command.Parameters("@id_usuario").Value = id_usuario

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    Public Function GetAllRecibo_proveedor(ByVal id_recibo_proveedor As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_recibo_proveedor_GetAllRecibo_proveedor", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_recibo_proveedor", SqlDbType.Int, 4, "id_recibo_proveedor")
        oda.SelectCommand.Parameters("@id_recibo_proveedor").Value = id_recibo_proveedor

        oda.Fill(odt)
        Return odt
    End Function

    Public Function GetAllFactura_proveedor(ByVal id_factura_proveedor As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_recibo_proveedor_GetAllFacturaProveedor", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_factura_proveedor", SqlDbType.Int, 4, "id_factura_proveedor")
        oda.SelectCommand.Parameters("@id_factura_proveedor").Value = id_factura_proveedor

        oda.Fill(odt)

        Return odt
    End Function


End Class
