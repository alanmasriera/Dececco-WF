Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Factura_exporta_ent

    'defino las variables
    Private dt As DataTable
    Private dr As DataRow
    Private da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_factura As Int32
    Public ReadOnly Property id_factura() As Int32
        Get
            _id_factura = CInt(dr("id_factura"))
            Return _id_factura
        End Get
    end property

    Private _id_cliente As Int32
    Public Property id_cliente() As Int32
        Get
            _id_cliente = CInt(dr("id_cliente"))
            Return _id_cliente
        End Get
        Set(ByVal Value As Int32)
            dr("id_cliente") = Value
        End Set
    end property

    Private _numero_factura As String
    Public Property numero_factura() As String
        Get
            _numero_factura = CStr(dr("numero_factura"))
            Return _numero_factura
        End Get
        Set(ByVal Value As String)
            dr("numero_factura") = Value
        End Set
    end property

    Private _fecha_factura As DateTime
    Public Property fecha_factura() As DateTime
        Get
            _fecha_factura = CDate(dr("fecha_factura"))
            Return _fecha_factura
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha_factura") = Value
        End Set
    end property

    Private _nro_orden As String
    Public Property nro_orden() As String
        Get
            _nro_orden = CStr(dr("nro_orden"))
            Return _nro_orden
        End Get
        Set(ByVal Value As String)
            dr("nro_orden") = Value
        End Set
    end property

    Private _zona As String
    Public Property zona() As String
        Get
            _zona = CStr(dr("zona"))
            Return _zona
        End Get
        Set(ByVal Value As String)
            dr("zona") = Value
        End Set
    end property

    Private _cuenta As String
    Public Property cuenta() As String
        Get
            _cuenta = CStr(dr("cuenta"))
            Return _cuenta
        End Get
        Set(ByVal Value As String)
            dr("cuenta") = Value
        End Set
    end property

    Private _forma_pago As String
    Public Property forma_pago() As String
        Get
            _forma_pago = CStr(dr("forma_pago"))
            Return _forma_pago
        End Get
        Set(ByVal Value As String)
            dr("forma_pago") = Value
        End Set
    end property

    Private _anulada As Boolean
    Public Property anulada() As Boolean
        Get
            _anulada = CBool(dr("anulada"))
            Return _anulada
        End Get
        Set(ByVal Value As Boolean)
            dr("anulada") = Value
        End Set
    end property

    Private _subtotal_factura As Decimal
    Public Property subtotal_factura() As Decimal
        Get
            _subtotal_factura = CDec(dr("subtotal_factura"))
            Return _subtotal_factura
        End Get
        Set(ByVal Value As Decimal)
            dr("subtotal_factura") = Value
        End Set
    end property

    Private _tipo_factura As String
    Public Property tipo_factura() As String
        Get
            _tipo_factura = CStr(dr("tipo_factura"))
            Return _tipo_factura
        End Get
        Set(ByVal Value As String)
            dr("tipo_factura") = Value
        End Set
    end property

    Private _total_factura As Decimal
    Public Property total_factura() As Decimal
        Get
            _total_factura = CDec(dr("total_factura"))
            Return _total_factura
        End Get
        Set(ByVal Value As Decimal)
            dr("total_factura") = Value
        End Set
    end property

    Private _total_letra As String
    Public Property total_letra() As String
        Get
            _total_letra = CStr(dr("total_letra"))
            Return _total_letra
        End Get
        Set(ByVal Value As String)
            dr("total_letra") = Value
        End Set
    end property

    Private _movimiento As String
    Public Property movimiento() As String
        Get
            _movimiento = CStr(dr("movimiento"))
            Return _movimiento
        End Get
        Set(ByVal Value As String)
            dr("movimiento") = Value
        End Set
    end property

    Private _origen As String
    Public Property origen() As String
        Get
            _origen = CStr(dr("origen"))
            Return _origen
        End Get
        Set(ByVal Value As String)
            dr("origen") = Value
        End Set
    end property

    Private _via_transporte As String
    Public Property via_transporte() As String
        Get
            _via_transporte = CStr(dr("via_transporte"))
            Return _via_transporte
        End Get
        Set(ByVal Value As String)
            dr("via_transporte") = Value
        End Set
    end property

    Private _puerto_embarque As String
    Public Property puerto_embarque() As String
        Get
            _puerto_embarque = CStr(dr("puerto_embarque"))
            Return _puerto_embarque
        End Get
        Set(ByVal Value As String)
            dr("puerto_embarque") = Value
        End Set
    end property

    Private _puerto_desembarque As String
    Public Property puerto_desembarque() As String
        Get
            _puerto_desembarque = CStr(dr("puerto_desembarque"))
            Return _puerto_desembarque
        End Get
        Set(ByVal Value As String)
            dr("puerto_desembarque") = Value
        End Set
    end property

    Private _destino As String
    Public Property destino() As String
        Get
            _destino = CStr(dr("destino"))
            Return _destino
        End Get
        Set(ByVal Value As String)
            dr("destino") = Value
        End Set
    end property

    Private _cantidad_tipo_cajas As String
    Public Property cantidad_tipo_cajas() As String
        Get
            _cantidad_tipo_cajas = CStr(dr("cantidad_tipo_cajas"))
            Return _cantidad_tipo_cajas
        End Get
        Set(ByVal Value As String)
            dr("cantidad_tipo_cajas") = Value
        End Set
    end property

    Private _peso_neto As String
    Public Property peso_neto() As String
        Get
            _peso_neto = CStr(dr("peso_neto"))
            Return _peso_neto
        End Get
        Set(ByVal Value As String)
            dr("peso_neto") = Value
        End Set
    end property

    Private _peso_bruto As String
    Public Property peso_bruto() As String
        Get
            _peso_bruto = CStr(dr("peso_bruto"))
            Return _peso_bruto
        End Get
        Set(ByVal Value As String)
            dr("peso_bruto") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Factura_exporta")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Factura_exporta_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_factura", SqlDbType.int, 0, "id_factura")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@id_cliente", SqlDbType.int, 4, "id_cliente")
        da.InsertCommand.Parameters.Add("@numero_factura", SqlDbType.varchar, 50, "numero_factura")
        da.InsertCommand.Parameters.Add("@fecha_factura", SqlDbType.datetime, 8, "fecha_factura")
        da.InsertCommand.Parameters.Add("@nro_orden", SqlDbType.varchar, 50, "nro_orden")
        da.InsertCommand.Parameters.Add("@zona", SqlDbType.varchar, 50, "zona")
        da.InsertCommand.Parameters.Add("@cuenta", SqlDbType.varchar, 50, "cuenta")
        da.InsertCommand.Parameters.Add("@forma_pago", SqlDbType.varchar, 50, "forma_pago")
        da.InsertCommand.Parameters.Add("@anulada", SqlDbType.bit, 1, "anulada")
        da.InsertCommand.Parameters.Add("@subtotal_factura", SqlDbType.decimal, 9, "subtotal_factura")
        da.InsertCommand.Parameters.Add("@tipo_factura", SqlDbType.varchar, 50, "tipo_factura")
        da.InsertCommand.Parameters.Add("@total_factura", SqlDbType.decimal, 9, "total_factura")
        da.InsertCommand.Parameters.Add("@total_letra", SqlDbType.varchar, 500, "total_letra")
        da.InsertCommand.Parameters.Add("@movimiento", SqlDbType.varchar, 50, "movimiento")
        da.InsertCommand.Parameters.Add("@origen", SqlDbType.varchar, 50, "origen")
        da.InsertCommand.Parameters.Add("@via_transporte", SqlDbType.varchar, 50, "via_transporte")
        da.InsertCommand.Parameters.Add("@puerto_embarque", SqlDbType.varchar, 50, "puerto_embarque")
        da.InsertCommand.Parameters.Add("@puerto_desembarque", SqlDbType.varchar, 50, "puerto_desembarque")
        da.InsertCommand.Parameters.Add("@destino", SqlDbType.varchar, 50, "destino")
        da.InsertCommand.Parameters.Add("@cantidad_tipo_cajas", SqlDbType.varchar, 50, "cantidad_tipo_cajas")
        da.InsertCommand.Parameters.Add("@peso_neto", SqlDbType.varchar, 50, "peso_neto")
        da.InsertCommand.Parameters.Add("@peso_bruto", SqlDbType.varchar, 50, "peso_bruto")

        dr = dt.NewRow()
        dr("id_cliente") = 0
        dr("numero_factura") = ""
        dr("fecha_factura") = DateTime.Now
        dr("nro_orden") = ""
        dr("zona") = ""
        dr("cuenta") = ""
        dr("forma_pago") = ""
        dr("anulada") = False
        dr("subtotal_factura") = 0
        dr("tipo_factura") = ""
        dr("total_factura") = 0
        dr("total_letra") = ""
        dr("movimiento") = ""
        dr("origen") = ""
        dr("via_transporte") = ""
        dr("puerto_embarque") = ""
        dr("puerto_desembarque") = ""
        dr("destino") = ""
        dr("cantidad_tipo_cajas") = ""
        dr("peso_neto") = ""
        dr("peso_bruto") = ""
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idFactura_exporta As Integer)
        dt = New DataTable("Factura_exporta")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Factura_exporta WHERE id_factura = @id_Factura_exporta", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Factura_exporta", idFactura_exporta)
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
    Public Sub Borrar(ByVal idFactura_exporta As Integer)
        dt = New DataTable("Factura_exporta")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Factura_exporta WHERE id_factura = " & _
        idFactura_exporta, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Factura_exporta_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_factura", SqlDbType.Int, 4, "id_factura")
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
               Case "id_factura"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_cliente"
                  dc.DataType = Type.GetType("System.Int32")
               Case "numero_factura"
                  dc.DataType = Type.GetType("System.String")
               Case "fecha_factura"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "nro_orden"
                  dc.DataType = Type.GetType("System.String")
               Case "zona"
                  dc.DataType = Type.GetType("System.String")
               Case "cuenta"
                  dc.DataType = Type.GetType("System.String")
               Case "forma_pago"
                  dc.DataType = Type.GetType("System.String")
               Case "anulada"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "subtotal_factura"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "tipo_factura"
                  dc.DataType = Type.GetType("System.String")
               Case "total_factura"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "total_letra"
                  dc.DataType = Type.GetType("System.String")
               Case "movimiento"
                  dc.DataType = Type.GetType("System.String")
               Case "origen"
                  dc.DataType = Type.GetType("System.String")
               Case "via_transporte"
                  dc.DataType = Type.GetType("System.String")
               Case "puerto_embarque"
                  dc.DataType = Type.GetType("System.String")
               Case "puerto_desembarque"
                  dc.DataType = Type.GetType("System.String")
               Case "destino"
                  dc.DataType = Type.GetType("System.String")
               Case "cantidad_tipo_cajas"
                  dc.DataType = Type.GetType("System.String")
               Case "peso_neto"
                  dc.DataType = Type.GetType("System.String")
               Case "peso_bruto"
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
        dt = New DataTable("Factura_exporta")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Factura_exporta WHERE id_factura = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_exporta_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_exporta_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_exporta_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Factura_exporta As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_exporta_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_factura", SqlDbType.Int, 4, "id_factura")
        oda.SelectCommand.Parameters("@id_factura").Value = id_Factura_exporta

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_exporta_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.int, 4, "id_cliente")
        oda.SelectCommand.Parameters("@id_cliente").Value = Me.id_cliente
        oda.SelectCommand.Parameters.Add("@numero_factura", SqlDbType.varchar, 50, "numero_factura")
        oda.SelectCommand.Parameters("@numero_factura").Value = Me.numero_factura
        oda.SelectCommand.Parameters.Add("@fecha_factura", SqlDbType.datetime, 8, "fecha_factura")
        oda.SelectCommand.Parameters("@fecha_factura").Value = Me.fecha_factura
        oda.SelectCommand.Parameters.Add("@nro_orden", SqlDbType.varchar, 50, "nro_orden")
        oda.SelectCommand.Parameters("@nro_orden").Value = Me.nro_orden
        oda.SelectCommand.Parameters.Add("@zona", SqlDbType.varchar, 50, "zona")
        oda.SelectCommand.Parameters("@zona").Value = Me.zona
        oda.SelectCommand.Parameters.Add("@cuenta", SqlDbType.varchar, 50, "cuenta")
        oda.SelectCommand.Parameters("@cuenta").Value = Me.cuenta
        oda.SelectCommand.Parameters.Add("@forma_pago", SqlDbType.varchar, 50, "forma_pago")
        oda.SelectCommand.Parameters("@forma_pago").Value = Me.forma_pago
        oda.SelectCommand.Parameters.Add("@anulada", SqlDbType.bit, 1, "anulada")
        oda.SelectCommand.Parameters("@anulada").Value = Me.anulada
        oda.SelectCommand.Parameters.Add("@subtotal_factura", SqlDbType.decimal, 9, "subtotal_factura")
        oda.SelectCommand.Parameters("@subtotal_factura").Value = Me.subtotal_factura
        oda.SelectCommand.Parameters.Add("@tipo_factura", SqlDbType.varchar, 50, "tipo_factura")
        oda.SelectCommand.Parameters("@tipo_factura").Value = Me.tipo_factura
        oda.SelectCommand.Parameters.Add("@total_factura", SqlDbType.decimal, 9, "total_factura")
        oda.SelectCommand.Parameters("@total_factura").Value = Me.total_factura
        oda.SelectCommand.Parameters.Add("@total_letra", SqlDbType.varchar, 500, "total_letra")
        oda.SelectCommand.Parameters("@total_letra").Value = Me.total_letra
        oda.SelectCommand.Parameters.Add("@movimiento", SqlDbType.varchar, 50, "movimiento")
        oda.SelectCommand.Parameters("@movimiento").Value = Me.movimiento
        oda.SelectCommand.Parameters.Add("@origen", SqlDbType.varchar, 50, "origen")
        oda.SelectCommand.Parameters("@origen").Value = Me.origen
        oda.SelectCommand.Parameters.Add("@via_transporte", SqlDbType.varchar, 50, "via_transporte")
        oda.SelectCommand.Parameters("@via_transporte").Value = Me.via_transporte
        oda.SelectCommand.Parameters.Add("@puerto_embarque", SqlDbType.varchar, 50, "puerto_embarque")
        oda.SelectCommand.Parameters("@puerto_embarque").Value = Me.puerto_embarque
        oda.SelectCommand.Parameters.Add("@puerto_desembarque", SqlDbType.varchar, 50, "puerto_desembarque")
        oda.SelectCommand.Parameters("@puerto_desembarque").Value = Me.puerto_desembarque
        oda.SelectCommand.Parameters.Add("@destino", SqlDbType.varchar, 50, "destino")
        oda.SelectCommand.Parameters("@destino").Value = Me.destino
        oda.SelectCommand.Parameters.Add("@cantidad_tipo_cajas", SqlDbType.varchar, 50, "cantidad_tipo_cajas")
        oda.SelectCommand.Parameters("@cantidad_tipo_cajas").Value = Me.cantidad_tipo_cajas
        oda.SelectCommand.Parameters.Add("@peso_neto", SqlDbType.varchar, 50, "peso_neto")
        oda.SelectCommand.Parameters("@peso_neto").Value = Me.peso_neto
        oda.SelectCommand.Parameters.Add("@peso_bruto", SqlDbType.varchar, 50, "peso_bruto")
        oda.SelectCommand.Parameters("@peso_bruto").Value = Me.peso_bruto

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
        Command.CommandText = "DELETE FROM Factura_exporta"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Factura_exporta"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Factura_exporta_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Factura_exporta")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Factura_exporta.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
