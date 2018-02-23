Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Cuerpo_factura_proveedor_ent

    'defino las variables
    Private dt As DataTable
    Private dr As DataRow
    Private da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_cuerpo_factura_proveedor As Int32
    Public ReadOnly Property id_cuerpo_factura_proveedor() As Int32
        Get
            _id_cuerpo_factura_proveedor = CInt(dr("id_cuerpo_factura_proveedor"))
            Return _id_cuerpo_factura_proveedor
        End Get
    end property

    Private _id_factura_proveedor As Int32
    Public Property id_factura_proveedor() As Int32
        Get
            _id_factura_proveedor = CInt(dr("id_factura_proveedor"))
            Return _id_factura_proveedor
        End Get
        Set(ByVal Value As Int32)
            dr("id_factura_proveedor") = Value
        End Set
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

    Private _cantidad As Decimal
    Public Property cantidad() As Decimal
        Get
            _cantidad = CDec(dr("cantidad"))
            Return _cantidad
        End Get
        Set(ByVal Value As Decimal)
            dr("cantidad") = Value
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


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Cuerpo_factura_proveedor")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Cuerpo_factura_proveedor_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_cuerpo_factura_proveedor", SqlDbType.int, 0, "id_cuerpo_factura_proveedor")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@id_factura_proveedor", SqlDbType.int, 4, "id_factura_proveedor")
        da.InsertCommand.Parameters.Add("@id_producto", SqlDbType.int, 4, "id_producto")
        da.InsertCommand.Parameters.Add("@cantidad", SqlDbType.decimal, 9, "cantidad")
        da.InsertCommand.Parameters.Add("@precio", SqlDbType.decimal, 9, "precio")
        da.InsertCommand.Parameters.Add("@alicuota", SqlDbType.decimal, 9, "alicuota")
        da.InsertCommand.Parameters.Add("@iva", SqlDbType.decimal, 9, "iva")
        da.InsertCommand.Parameters.Add("@impuesto_interno", SqlDbType.decimal, 9, "impuesto_interno")
        da.InsertCommand.Parameters.Add("@pack", SqlDbType.decimal, 9, "pack")
        da.InsertCommand.Parameters.Add("@tilde", SqlDbType.bit, 1, "tilde")

        dr = dt.NewRow()
        dr("id_factura_proveedor") = 0
        dr("id_producto") = 0
        dr("cantidad") = 0
        dr("precio") = 0
        dr("alicuota") = 0
        dr("iva") = 0
        dr("impuesto_interno") = 0
        dr("pack") = 0
        dr("tilde") = False
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idCuerpo_factura_proveedor As Integer)
        dt = New DataTable("Cuerpo_factura_proveedor")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Cuerpo_factura_proveedor WHERE id_cuerpo_factura_proveedor = @id_Cuerpo_factura_proveedor", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Cuerpo_factura_proveedor", idCuerpo_factura_proveedor)
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
    Public Sub Borrar(ByVal idCuerpo_factura_proveedor As Integer)
        dt = New DataTable("Cuerpo_factura_proveedor")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Cuerpo_factura_proveedor WHERE id_cuerpo_factura_proveedor = " & _
        idCuerpo_factura_proveedor, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Cuerpo_factura_proveedor_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_cuerpo_factura_proveedor", SqlDbType.Int, 4, "id_cuerpo_factura_proveedor")
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
               Case "id_cuerpo_factura_proveedor"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_factura_proveedor"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_producto"
                  dc.DataType = Type.GetType("System.Int32")
               Case "cantidad"
                  dc.DataType = Type.GetType("System.Decimal")
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
               Case "tilde"
                  dc.DataType = Type.GetType("System.Boolean")
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
        dt = New DataTable("Cuerpo_factura_proveedor")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Cuerpo_factura_proveedor WHERE id_cuerpo_factura_proveedor = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_factura_proveedor_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_factura_proveedor_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_factura_proveedor_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Cuerpo_factura_proveedor As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_factura_proveedor_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cuerpo_factura_proveedor", SqlDbType.Int, 4, "id_cuerpo_factura_proveedor")
        oda.SelectCommand.Parameters("@id_cuerpo_factura_proveedor").Value = id_Cuerpo_factura_proveedor

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cuerpo_factura_proveedor_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_factura_proveedor", SqlDbType.int, 4, "id_factura_proveedor")
        oda.SelectCommand.Parameters("@id_factura_proveedor").Value = Me.id_factura_proveedor
        oda.SelectCommand.Parameters.Add("@id_producto", SqlDbType.int, 4, "id_producto")
        oda.SelectCommand.Parameters("@id_producto").Value = Me.id_producto
        oda.SelectCommand.Parameters.Add("@cantidad", SqlDbType.decimal, 9, "cantidad")
        oda.SelectCommand.Parameters("@cantidad").Value = Me.cantidad
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
        oda.SelectCommand.Parameters.Add("@tilde", SqlDbType.bit, 1, "tilde")
        oda.SelectCommand.Parameters("@tilde").Value = Me.tilde

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
        Command.CommandText = "DELETE FROM Cuerpo_factura_proveedor"

        oConexion.Abrir()
        Command.ExecuteNonQuery()
        oConexion.Cerrar()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Cuerpo_factura_proveedor"

        oConexion.Abrir()
        Command.ExecuteNonQuery()
        oConexion.Cerrar()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Cuerpo_factura_proveedor_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        oConexion.Abrir()
        Command.ExecuteNonQuery()
        oConexion.Cerrar()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Cuerpo_factura_proveedor")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Cuerpo_factura_proveedor.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
