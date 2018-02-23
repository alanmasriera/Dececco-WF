Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Stock_ent

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_stock As Int32
    Public ReadOnly Property id_stock() As Int32
        Get
            _id_stock = CInt(dr("id_stock"))
            Return _id_stock
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

    Private _id_almacen As Int32
    Public Property id_almacen() As Int32
        Get
            _id_almacen = CInt(dr("id_almacen"))
            Return _id_almacen
        End Get
        Set(ByVal Value As Int32)
            dr("id_almacen") = Value
        End Set
    end property

    Private _stock As Decimal
    Public Property stock() As Decimal
        Get
            _stock = CDec(dr("stock"))
            Return _stock
        End Get
        Set(ByVal Value As Decimal)
            dr("stock") = Value
        End Set
    end property

    Private _actualizado As Boolean
    Public Property actualizado() As Boolean
        Get
            _actualizado = CBool(dr("actualizado"))
            Return _actualizado
        End Get
        Set(ByVal Value As Boolean)
            dr("actualizado") = Value
        End Set
    end property

    Private _stock_oferta As Decimal
    Public Property stock_oferta() As Decimal
        Get
            _stock_oferta = CDec(dr("stock_oferta"))
            Return _stock_oferta
        End Get
        Set(ByVal Value As Decimal)
            dr("stock_oferta") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Stock")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Stock_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_stock", SqlDbType.int, 0, "id_stock")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@id_producto", SqlDbType.int, 4, "id_producto")
        da.InsertCommand.Parameters.Add("@id_almacen", SqlDbType.int, 4, "id_almacen")
        da.InsertCommand.Parameters.Add("@stock", SqlDbType.decimal, 9, "stock")
        da.InsertCommand.Parameters.Add("@actualizado", SqlDbType.bit, 1, "actualizado")
        da.InsertCommand.Parameters.Add("@stock_oferta", SqlDbType.decimal, 9, "stock_oferta")

        dr = dt.NewRow()
        dr("id_producto") = 0
        dr("id_almacen") = 0
        dr("stock") = 0
        dr("actualizado") = False
        dr("stock_oferta") = 0
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idStock As Integer)
        dt = New DataTable("Stock")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Stock WHERE id_stock = @id_Stock", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Stock", idStock)
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
    Public Sub Borrar(ByVal idStock As Integer)
        dt = New DataTable("Stock")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Stock WHERE id_stock = " & _
        idStock, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Stock_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_stock", SqlDbType.Int, 4, "id_stock")
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
               Case "id_stock"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_producto"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_almacen"
                  dc.DataType = Type.GetType("System.Int32")
               Case "stock"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "actualizado"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "stock_oferta"
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
        dt = New DataTable("Stock")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Stock WHERE id_stock = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Stock_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Stock_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Stock_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Stock As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Stock_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_stock", SqlDbType.Int, 4, "id_stock")
        oda.SelectCommand.Parameters("@id_stock").Value = id_Stock

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Stock_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_producto", SqlDbType.int, 4, "id_producto")
        oda.SelectCommand.Parameters("@id_producto").Value = Me.id_producto
        oda.SelectCommand.Parameters.Add("@id_almacen", SqlDbType.int, 4, "id_almacen")
        oda.SelectCommand.Parameters("@id_almacen").Value = Me.id_almacen
        oda.SelectCommand.Parameters.Add("@stock", SqlDbType.decimal, 9, "stock")
        oda.SelectCommand.Parameters("@stock").Value = Me.stock
        oda.SelectCommand.Parameters.Add("@actualizado", SqlDbType.bit, 1, "actualizado")
        oda.SelectCommand.Parameters("@actualizado").Value = Me.actualizado
        oda.SelectCommand.Parameters.Add("@stock_oferta", SqlDbType.decimal, 9, "stock_oferta")
        oda.SelectCommand.Parameters("@stock_oferta").Value = Me.stock_oferta

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
        Command.CommandText = "DELETE FROM Stock"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Stock"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Stock_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Stock")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Stock.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
