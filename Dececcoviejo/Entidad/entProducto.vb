Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Producto_ent

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_producto As Int32
    Public ReadOnly Property id_producto() As Int32
        Get
            _id_producto = CInt(dr("id_producto"))
            Return _id_producto
        End Get
    end property

    Private _nombre_producto As String
    Public Property nombre_producto() As String
        Get
            _nombre_producto = CStr(dr("nombre_producto"))
            Return _nombre_producto
        End Get
        Set(ByVal Value As String)
            dr("nombre_producto") = Value
        End Set
    end property

    Private _descripcion As String
    Public Property descripcion() As String
        Get
            _descripcion = CStr(dr("descripcion"))
            Return _descripcion
        End Get
        Set(ByVal Value As String)
            dr("descripcion") = Value
        End Set
    end property

    Private _abreviatura As String
    Public Property abreviatura() As String
        Get
            _abreviatura = CStr(dr("abreviatura"))
            Return _abreviatura
        End Get
        Set(ByVal Value As String)
            dr("abreviatura") = Value
        End Set
    end property

    Private _ubicacion As String
    Public Property ubicacion() As String
        Get
            _ubicacion = CStr(dr("ubicacion"))
            Return _ubicacion
        End Get
        Set(ByVal Value As String)
            dr("ubicacion") = Value
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

    Private _stock_ideal As Decimal
    Public Property stock_ideal() As Decimal
        Get
            _stock_ideal = CDec(dr("stock_ideal"))
            Return _stock_ideal
        End Get
        Set(ByVal Value As Decimal)
            dr("stock_ideal") = Value
        End Set
    end property

    Private _stock_minimo As Decimal
    Public Property stock_minimo() As Decimal
        Get
            _stock_minimo = CDec(dr("stock_minimo"))
            Return _stock_minimo
        End Get
        Set(ByVal Value As Decimal)
            dr("stock_minimo") = Value
        End Set
    end property

    Private _cantidad_compra As Decimal
    Public Property cantidad_compra() As Decimal
        Get
            _cantidad_compra = CDec(dr("cantidad_compra"))
            Return _cantidad_compra
        End Get
        Set(ByVal Value As Decimal)
            dr("cantidad_compra") = Value
        End Set
    end property

    Private _cantidad_ingreso As Decimal
    Public Property cantidad_ingreso() As Decimal
        Get
            _cantidad_ingreso = CDec(dr("cantidad_ingreso"))
            Return _cantidad_ingreso
        End Get
        Set(ByVal Value As Decimal)
            dr("cantidad_ingreso") = Value
        End Set
    end property

    Private _id_subtipo_producto As Int32
    Public Property id_subtipo_producto() As Int32
        Get
            _id_subtipo_producto = CInt(dr("id_subtipo_producto"))
            Return _id_subtipo_producto
        End Get
        Set(ByVal Value As Int32)
            dr("id_subtipo_producto") = Value
        End Set
    end property

    Private _id_marca As Int32
    Public Property id_marca() As Int32
        Get
            _id_marca = CInt(dr("id_marca"))
            Return _id_marca
        End Get
        Set(ByVal Value As Int32)
            dr("id_marca") = Value
        End Set
    end property

    Private _id_unidad As Int32
    Public Property id_unidad() As Int32
        Get
            _id_unidad = CInt(dr("id_unidad"))
            Return _id_unidad
        End Get
        Set(ByVal Value As Int32)
            dr("id_unidad") = Value
        End Set
    end property

    Private _tilde As Boolean
    Public Property tilde() As Boolean
        Get
            _tilde = CBool(dr("tilde"))
            Return _tilde
        End Get
        Set(ByVal Value As Boolean)
            dr("tilde") = Value
        End Set
    end property

    Private _tipo_venta As String
    Public Property tipo_venta() As String
        Get
            _tipo_venta = CStr(dr("tipo_venta"))
            Return _tipo_venta
        End Get
        Set(ByVal Value As String)
            dr("tipo_venta") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Producto")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Producto_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_producto", SqlDbType.int, 0, "id_producto")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@nombre_producto", SqlDbType.varchar, 50, "nombre_producto")
        da.InsertCommand.Parameters.Add("@descripcion", SqlDbType.varchar, 500, "descripcion")
        da.InsertCommand.Parameters.Add("@abreviatura", SqlDbType.varchar, 50, "abreviatura")
        da.InsertCommand.Parameters.Add("@ubicacion", SqlDbType.varchar, 50, "ubicacion")
        da.InsertCommand.Parameters.Add("@pack", SqlDbType.decimal, 9, "pack")
        da.InsertCommand.Parameters.Add("@stock_ideal", SqlDbType.decimal, 9, "stock_ideal")
        da.InsertCommand.Parameters.Add("@stock_minimo", SqlDbType.decimal, 9, "stock_minimo")
        da.InsertCommand.Parameters.Add("@cantidad_compra", SqlDbType.decimal, 9, "cantidad_compra")
        da.InsertCommand.Parameters.Add("@cantidad_ingreso", SqlDbType.decimal, 9, "cantidad_ingreso")
        da.InsertCommand.Parameters.Add("@id_subtipo_producto", SqlDbType.int, 4, "id_subtipo_producto")
        da.InsertCommand.Parameters.Add("@id_marca", SqlDbType.int, 4, "id_marca")
        da.InsertCommand.Parameters.Add("@id_unidad", SqlDbType.int, 4, "id_unidad")
        da.InsertCommand.Parameters.Add("@tilde", SqlDbType.bit, 1, "tilde")
        da.InsertCommand.Parameters.Add("@tipo_venta", SqlDbType.char, 1, "tipo_venta")

        dr = dt.NewRow()
        dr("nombre_producto") = ""
        dr("descripcion") = ""
        dr("abreviatura") = ""
        dr("ubicacion") = ""
        dr("pack") = 0
        dr("stock_ideal") = 0
        dr("stock_minimo") = 0
        dr("cantidad_compra") = 0
        dr("cantidad_ingreso") = 0
        dr("id_subtipo_producto") = 0
        dr("id_marca") = 0
        dr("id_unidad") = 0
        dr("tilde") = False
        dr("tipo_venta") = ""
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idProducto As Integer)
        dt = New DataTable("Producto")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Producto WHERE id_producto = @id_Producto", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Producto", idProducto)
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
    Public Sub Borrar(ByVal idProducto As Integer)
        dt = New DataTable("Producto")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Producto WHERE id_producto = " & _
        idProducto, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Producto_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_producto", SqlDbType.Int, 4, "id_producto")
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
               Case "id_producto"
                  dc.DataType = Type.GetType("System.Int32")
               Case "nombre_producto"
                  dc.DataType = Type.GetType("System.String")
               Case "descripcion"
                  dc.DataType = Type.GetType("System.String")
               Case "abreviatura"
                  dc.DataType = Type.GetType("System.String")
               Case "ubicacion"
                  dc.DataType = Type.GetType("System.String")
               Case "pack"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "stock_ideal"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "stock_minimo"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "cantidad_compra"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "cantidad_ingreso"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "id_subtipo_producto"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_marca"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_unidad"
                  dc.DataType = Type.GetType("System.Int32")
               Case "tilde"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "tipo_venta"
                  dc.DataType = Type.GetType("System.String")
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
        dt = New DataTable("Producto")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Producto WHERE id_producto = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Producto_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Producto_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Producto_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Producto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Producto_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_producto", SqlDbType.Int, 4, "id_producto")
        oda.SelectCommand.Parameters("@id_producto").Value = id_Producto

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Producto_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre_producto", SqlDbType.varchar, 50, "nombre_producto")
        oda.SelectCommand.Parameters("@nombre_producto").Value = Me.nombre_producto
        oda.SelectCommand.Parameters.Add("@descripcion", SqlDbType.varchar, 500, "descripcion")
        oda.SelectCommand.Parameters("@descripcion").Value = Me.descripcion
        oda.SelectCommand.Parameters.Add("@abreviatura", SqlDbType.varchar, 50, "abreviatura")
        oda.SelectCommand.Parameters("@abreviatura").Value = Me.abreviatura
        oda.SelectCommand.Parameters.Add("@ubicacion", SqlDbType.varchar, 50, "ubicacion")
        oda.SelectCommand.Parameters("@ubicacion").Value = Me.ubicacion
        oda.SelectCommand.Parameters.Add("@pack", SqlDbType.decimal, 9, "pack")
        oda.SelectCommand.Parameters("@pack").Value = Me.pack
        oda.SelectCommand.Parameters.Add("@stock_ideal", SqlDbType.decimal, 9, "stock_ideal")
        oda.SelectCommand.Parameters("@stock_ideal").Value = Me.stock_ideal
        oda.SelectCommand.Parameters.Add("@stock_minimo", SqlDbType.decimal, 9, "stock_minimo")
        oda.SelectCommand.Parameters("@stock_minimo").Value = Me.stock_minimo
        oda.SelectCommand.Parameters.Add("@cantidad_compra", SqlDbType.decimal, 9, "cantidad_compra")
        oda.SelectCommand.Parameters("@cantidad_compra").Value = Me.cantidad_compra
        oda.SelectCommand.Parameters.Add("@cantidad_ingreso", SqlDbType.decimal, 9, "cantidad_ingreso")
        oda.SelectCommand.Parameters("@cantidad_ingreso").Value = Me.cantidad_ingreso
        oda.SelectCommand.Parameters.Add("@id_subtipo_producto", SqlDbType.int, 4, "id_subtipo_producto")
        oda.SelectCommand.Parameters("@id_subtipo_producto").Value = Me.id_subtipo_producto
        oda.SelectCommand.Parameters.Add("@id_marca", SqlDbType.int, 4, "id_marca")
        oda.SelectCommand.Parameters("@id_marca").Value = Me.id_marca
        oda.SelectCommand.Parameters.Add("@id_unidad", SqlDbType.int, 4, "id_unidad")
        oda.SelectCommand.Parameters("@id_unidad").Value = Me.id_unidad
        oda.SelectCommand.Parameters.Add("@tilde", SqlDbType.bit, 1, "tilde")
        oda.SelectCommand.Parameters("@tilde").Value = Me.tilde
        oda.SelectCommand.Parameters.Add("@tipo_venta", SqlDbType.char, 1, "tipo_venta")
        oda.SelectCommand.Parameters("@tipo_venta").Value = Me.tipo_venta

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
        Command.CommandText = "DELETE FROM Producto"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Producto"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Producto_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Producto")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Producto.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
