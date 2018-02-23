Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Precio_ent

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_precio As Int32
    Public ReadOnly Property id_precio() As Int32
        Get
            _id_precio = CInt(dr("id_precio"))
            Return _id_precio
        End Get
    end property

    Private _id_producto As Int32
    Public Property id_producto() As Int32
        Get
            _id_producto = CInt(dr("id_producto"))
            Return _id_producto
        End Get
        Set(ByVal Value As Int32)
            dr("id_producto") = Value
        End Set
    end property

    Private _id_proveedor As Int32
    Public Property id_proveedor() As Int32
        Get
            _id_proveedor = CInt(dr("id_proveedor"))
            Return _id_proveedor
        End Get
        Set(ByVal Value As Int32)
            dr("id_proveedor") = Value
        End Set
    end property

    Private _precio As Decimal
    Public Property precio() As Decimal
        Get
            _precio = CDec(dr("precio"))
            Return _precio
        End Get
        Set(ByVal Value As Decimal)
            dr("precio") = Value
        End Set
    end property

    Private _alicuota As Decimal
    Public Property alicuota() As Decimal
        Get
            _alicuota = CDec(dr("alicuota"))
            Return _alicuota
        End Get
        Set(ByVal Value As Decimal)
            dr("alicuota") = Value
        End Set
    end property

    Private _iva As Decimal
    Public Property iva() As Decimal
        Get
            _iva = CDec(dr("iva"))
            Return _iva
        End Get
        Set(ByVal Value As Decimal)
            dr("iva") = Value
        End Set
    end property

    Private _impuesto_interno As Decimal
    Public Property impuesto_interno() As Decimal
        Get
            _impuesto_interno = CDec(dr("impuesto_interno"))
            Return _impuesto_interno
        End Get
        Set(ByVal Value As Decimal)
            dr("impuesto_interno") = Value
        End Set
    end property

    Private _pack As Decimal
    Public Property pack() As Decimal
        Get
            _pack = CDec(dr("pack"))
            Return _pack
        End Get
        Set(ByVal Value As Decimal)
            dr("pack") = Value
        End Set
    end property

    Private _margen_ganancia As Decimal
    Public Property margen_ganancia() As Decimal
        Get
            _margen_ganancia = CDec(dr("margen_ganancia"))
            Return _margen_ganancia
        End Get
        Set(ByVal Value As Decimal)
            dr("margen_ganancia") = Value
        End Set
    end property

    Private _cod_producto_proveedor As String
    Public Property cod_producto_proveedor() As String
        Get
            _cod_producto_proveedor = CStr(dr("cod_producto_proveedor"))
            Return _cod_producto_proveedor
        End Get
        Set(ByVal Value As String)
            dr("cod_producto_proveedor") = Value
        End Set
    end property

    Private _precio_venta_unitario As Decimal
    Public Property precio_venta_unitario() As Decimal
        Get
            _precio_venta_unitario = CDec(dr("precio_venta_unitario"))
            Return _precio_venta_unitario
        End Get
        Set(ByVal Value As Decimal)
            dr("precio_venta_unitario") = Value
        End Set
    end property

    Private _precio_venta_mayorista As Decimal
    Public Property precio_venta_mayorista() As Decimal
        Get
            _precio_venta_mayorista = CDec(dr("precio_venta_mayorista"))
            Return _precio_venta_mayorista
        End Get
        Set(ByVal Value As Decimal)
            dr("precio_venta_mayorista") = Value
        End Set
    end property

    Private _precio_venta_publico As Decimal
    Public Property precio_venta_publico() As Decimal
        Get
            _precio_venta_publico = CDec(dr("precio_venta_publico"))
            Return _precio_venta_publico
        End Get
        Set(ByVal Value As Decimal)
            dr("precio_venta_publico") = Value
        End Set
    end property

    Private _bonificacion1 As Decimal
    Public Property bonificacion1() As Decimal
        Get
            _bonificacion1 = CDec(dr("bonificacion1"))
            Return _bonificacion1
        End Get
        Set(ByVal Value As Decimal)
            dr("bonificacion1") = Value
        End Set
    end property

    Private _bonificacion2 As Decimal
    Public Property bonificacion2() As Decimal
        Get
            _bonificacion2 = CDec(dr("bonificacion2"))
            Return _bonificacion2
        End Get
        Set(ByVal Value As Decimal)
            dr("bonificacion2") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Precio")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Precio_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_precio", SqlDbType.int, 0, "id_precio")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@id_producto", SqlDbType.int, 4, "id_producto")
        da.InsertCommand.Parameters.Add("@id_proveedor", SqlDbType.int, 4, "id_proveedor")
        da.InsertCommand.Parameters.Add("@precio", SqlDbType.decimal, 9, "precio")
        da.InsertCommand.Parameters.Add("@alicuota", SqlDbType.decimal, 9, "alicuota")
        da.InsertCommand.Parameters.Add("@iva", SqlDbType.decimal, 9, "iva")
        da.InsertCommand.Parameters.Add("@impuesto_interno", SqlDbType.decimal, 9, "impuesto_interno")
        da.InsertCommand.Parameters.Add("@pack", SqlDbType.decimal, 9, "pack")
        da.InsertCommand.Parameters.Add("@margen_ganancia", SqlDbType.decimal, 9, "margen_ganancia")
        da.InsertCommand.Parameters.Add("@cod_producto_proveedor", SqlDbType.varchar, 50, "cod_producto_proveedor")
        da.InsertCommand.Parameters.Add("@precio_venta_unitario", SqlDbType.decimal, 9, "precio_venta_unitario")
        da.InsertCommand.Parameters.Add("@precio_venta_mayorista", SqlDbType.decimal, 9, "precio_venta_mayorista")
        da.InsertCommand.Parameters.Add("@precio_venta_publico", SqlDbType.decimal, 9, "precio_venta_publico")
        da.InsertCommand.Parameters.Add("@bonificacion1", SqlDbType.decimal, 9, "bonificacion1")
        da.InsertCommand.Parameters.Add("@bonificacion2", SqlDbType.decimal, 9, "bonificacion2")

        dr = dt.NewRow()
        dr("id_producto") = 0
        dr("id_proveedor") = 0
        dr("precio") = 0
        dr("alicuota") = 0
        dr("iva") = 0
        dr("impuesto_interno") = 0
        dr("pack") = 0
        dr("margen_ganancia") = 0
        dr("cod_producto_proveedor") = ""
        dr("precio_venta_unitario") = 0
        dr("precio_venta_mayorista") = 0
        dr("precio_venta_publico") = 0
        dr("bonificacion1") = 0
        dr("bonificacion2") = 0
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idPrecio As Integer)
        dt = New DataTable("Precio")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Precio WHERE id_precio = @id_Precio", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Precio", idPrecio)
        da.Fill(dt)
        Me.AsignarTipos()
        If dt.Rows.Count = 0 Then
            Throw New Exception("No se a encontrado el Registro")
        Else
            dr = dt.Rows(0)
        End If
        CrearComandoUpdate()
    End Sub

    'procedimiento borrar
    Public Sub Borrar(ByVal idPrecio As Integer)
        dt = New DataTable("Precio")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Precio WHERE id_precio = " & _
        idPrecio, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Precio_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_precio", SqlDbType.Int, 4, "id_precio")
            dt.Rows(0).Delete()
            CrearComandoUpdate()
            Guardar()
        Catch ex As Exception
            If Err.Number = 5 Then
            End If
        End Try
    End Sub

    'asigno el tipo de datos a los parametros
    Private Sub AsignarTipos()
        For Each dc As DataColumn In dt.Columns
            Select Case dc.ColumnName
               Case "id_precio"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_producto"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_proveedor"
                  dc.DataType = Type.GetType("System.Int32")
               Case "precio"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "alicuota"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "iva"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "impuesto_interno"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "pack"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "margen_ganancia"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "cod_producto_proveedor"
                  dc.DataType = Type.GetType("System.String")
               Case "precio_venta_unitario"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "precio_venta_mayorista"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "precio_venta_publico"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "bonificacion1"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "bonificacion2"
                  dc.DataType = Type.GetType("System.Decimal")
            End Select
        Next
    End Sub

    'creo el commandbuilder
    Private Sub CrearComandoUpdate()
        Dim cmd As New SqlCommandBuilder(da)
        da.UpdateCommand = cmd.GetUpdateCommand
    End Sub

    'cancelo los cambios del datatable
    Public Sub Cancelar()
        dt.Clear()
    End Sub

    'asigno el datatable
    Public Function DataTable() As DataTable
        Return dt
    End Function

    'actualizo la base de datos
    Public Sub Guardar()
        da.Update(dt)
    End Sub

    'funcion que carga el datatable
    Public Function Cargar() As DataTable
        dt = New DataTable("Precio")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Precio WHERE id_precio = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Precio_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Precio_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Precio_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Precio As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Precio_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_precio", SqlDbType.Int, 4, "id_precio")
        oda.SelectCommand.Parameters("@id_precio").Value = id_Precio

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Precio_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_producto", SqlDbType.int, 4, "id_producto")
        oda.SelectCommand.Parameters("@id_producto").Value = Me.id_producto
        oda.SelectCommand.Parameters.Add("@id_proveedor", SqlDbType.int, 4, "id_proveedor")
        oda.SelectCommand.Parameters("@id_proveedor").Value = Me.id_proveedor
        oda.SelectCommand.Parameters.Add("@precio", SqlDbType.decimal, 9, "precio")
        oda.SelectCommand.Parameters("@precio").Value = Me.precio
        oda.SelectCommand.Parameters.Add("@alicuota", SqlDbType.decimal, 9, "alicuota")
        oda.SelectCommand.Parameters("@alicuota").Value = Me.alicuota
        oda.SelectCommand.Parameters.Add("@iva", SqlDbType.decimal, 9, "iva")
        oda.SelectCommand.Parameters("@iva").Value = Me.iva
        oda.SelectCommand.Parameters.Add("@impuesto_interno", SqlDbType.decimal, 9, "impuesto_interno")
        oda.SelectCommand.Parameters("@impuesto_interno").Value = Me.impuesto_interno
        oda.SelectCommand.Parameters.Add("@pack", SqlDbType.decimal, 9, "pack")
        oda.SelectCommand.Parameters("@pack").Value = Me.pack
        oda.SelectCommand.Parameters.Add("@margen_ganancia", SqlDbType.decimal, 9, "margen_ganancia")
        oda.SelectCommand.Parameters("@margen_ganancia").Value = Me.margen_ganancia
        oda.SelectCommand.Parameters.Add("@cod_producto_proveedor", SqlDbType.varchar, 50, "cod_producto_proveedor")
        oda.SelectCommand.Parameters("@cod_producto_proveedor").Value = Me.cod_producto_proveedor
        oda.SelectCommand.Parameters.Add("@precio_venta_unitario", SqlDbType.decimal, 9, "precio_venta_unitario")
        oda.SelectCommand.Parameters("@precio_venta_unitario").Value = Me.precio_venta_unitario
        oda.SelectCommand.Parameters.Add("@precio_venta_mayorista", SqlDbType.decimal, 9, "precio_venta_mayorista")
        oda.SelectCommand.Parameters("@precio_venta_mayorista").Value = Me.precio_venta_mayorista
        oda.SelectCommand.Parameters.Add("@precio_venta_publico", SqlDbType.decimal, 9, "precio_venta_publico")
        oda.SelectCommand.Parameters("@precio_venta_publico").Value = Me.precio_venta_publico
        oda.SelectCommand.Parameters.Add("@bonificacion1", SqlDbType.decimal, 9, "bonificacion1")
        oda.SelectCommand.Parameters("@bonificacion1").Value = Me.bonificacion1
        oda.SelectCommand.Parameters.Add("@bonificacion2", SqlDbType.decimal, 9, "bonificacion2")
        oda.SelectCommand.Parameters("@bonificacion2").Value = Me.bonificacion2

        oda.Fill(odt)
        Total = CInt(odt.Rows(0).Item("Total").ToString)
        If Total = 0 Then
            Return False  'NO EXISTE
        Else
            Return True 'SI EXISTE
        End If
    End Function

    'borra todos los datos de la tabla
    Public Sub BorrarTodo()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "DELETE FROM Precio"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Precio"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Precio_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Precio")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Precio.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
