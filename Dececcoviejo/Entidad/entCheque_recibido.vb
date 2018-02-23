Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Cheque_recibido_ent

    'defino las variables
    Private dt As DataTable
    Private dr As DataRow
    Private da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_cheque_recibido As Int32
    Public ReadOnly Property id_cheque_recibido() As Int32
        Get
            _id_cheque_recibido = CInt(dr("id_cheque_recibido"))
            Return _id_cheque_recibido
        End Get
    end property

    Private _numero_cheque As String
    Public Property numero_cheque() As String
        Get
            _numero_cheque = CStr(dr("numero_cheque"))
            Return _numero_cheque
        End Get
        Set(ByVal Value As String)
            dr("numero_cheque") = Value
        End Set
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

    Private _id_banco As Int32
    Public Property id_banco() As Int32
        Get
            _id_banco = CInt(dr("id_banco"))
            Return _id_banco
        End Get
        Set(ByVal Value As Int32)
            dr("id_banco") = Value
        End Set
    end property

    Private _detalle As String
    Public Property detalle() As String
        Get
            _detalle = CStr(dr("detalle"))
            Return _detalle
        End Get
        Set(ByVal Value As String)
            dr("detalle") = Value
        End Set
    end property

    Private _fecha_recibido As DateTime
    Public Property fecha_recibido() As DateTime
        Get
            _fecha_recibido = CDate(dr("fecha_recibido"))
            Return _fecha_recibido
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha_recibido") = Value
        End Set
    end property

    Private _fecha_acreditacion As DateTime
    Public Property fecha_acreditacion() As DateTime
        Get
            _fecha_acreditacion = CDate(dr("fecha_acreditacion"))
            Return _fecha_acreditacion
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha_acreditacion") = Value
        End Set
    end property

    Private _importe As Decimal
    Public Property importe() As Decimal
        Get
            _importe = CDec(dr("importe"))
            Return _importe
        End Get
        Set(ByVal Value As Decimal)
            dr("importe") = Value
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

    Private _id_provincia As Int32
    Public Property id_provincia() As Int32
        Get
            _id_provincia = CInt(dr("id_provincia"))
            Return _id_provincia
        End Get
        Set(ByVal Value As Int32)
            dr("id_provincia") = Value
        End Set
    end property

    Private _id_localidad As Int32
    Public Property id_localidad() As Int32
        Get
            _id_localidad = CInt(dr("id_localidad"))
            Return _id_localidad
        End Get
        Set(ByVal Value As Int32)
            dr("id_localidad") = Value
        End Set
    end property

    Private _id_empresa As Int32
    Public Property id_empresa() As Int32
        Get
            _id_empresa = CInt(dr("id_empresa"))
            Return _id_empresa
        End Get
        Set(ByVal Value As Int32)
            dr("id_empresa") = Value
        End Set
    end property

    Private _control As Boolean
    Public Property control() As Boolean
        Get
            _control = CBool(dr("control"))
            Return _control
        End Get
        Set(ByVal Value As Boolean)
            dr("control") = Value
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

    Private _anulado As Boolean
    Public Property anulado() As Boolean
        Get
            _anulado = CBool(dr("anulado"))
            Return _anulado
        End Get
        Set(ByVal Value As Boolean)
            dr("anulado") = Value
        End Set
    end property

    Private _pago_tercero As Boolean
    Public Property pago_tercero() As Boolean
        Get
            _pago_tercero = CBool(dr("pago_tercero"))
            Return _pago_tercero
        End Get
        Set(ByVal Value As Boolean)
            dr("pago_tercero") = Value
        End Set
    end property

    Private _numero_recibo As String
    Public Property numero_recibo() As String
        Get
            _numero_recibo = CStr(dr("numero_recibo"))
            Return _numero_recibo
        End Get
        Set(ByVal Value As String)
            dr("numero_recibo") = Value
        End Set
    end property

    Private _cobro_efectivo As Boolean
    Public Property cobro_efectivo() As Boolean
        Get
            _cobro_efectivo = CBool(dr("cobro_efectivo"))
            Return _cobro_efectivo
        End Get
        Set(ByVal Value As Boolean)
            dr("cobro_efectivo") = Value
        End Set
    end property

    Private _deposito_cuenta As Boolean
    Public Property deposito_cuenta() As Boolean
        Get
            _deposito_cuenta = CBool(dr("deposito_cuenta"))
            Return _deposito_cuenta
        End Get
        Set(ByVal Value As Boolean)
            dr("deposito_cuenta") = Value
        End Set
    end property

    Private _id_banco_deposito As Int32
    Public Property id_banco_deposito() As Int32
        Get
            _id_banco_deposito = CInt(dr("id_banco_deposito"))
            Return _id_banco_deposito
        End Get
        Set(ByVal Value As Int32)
            dr("id_banco_deposito") = Value
        End Set
    end property

    Private _id_cuenta As Int32
    Public Property id_cuenta() As Int32
        Get
            _id_cuenta = CInt(dr("id_cuenta"))
            Return _id_cuenta
        End Get
        Set(ByVal Value As Int32)
            dr("id_cuenta") = Value
        End Set
    end property

    Private _archivado As Boolean
    Public Property archivado() As Boolean
        Get
            _archivado = CBool(dr("archivado"))
            Return _archivado
        End Get
        Set(ByVal Value As Boolean)
            dr("archivado") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Cheque_recibido")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Cheque_recibido_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_cheque_recibido", SqlDbType.int, 0, "id_cheque_recibido")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@numero_cheque", SqlDbType.varchar, 50, "numero_cheque")
        da.InsertCommand.Parameters.Add("@id_cliente", SqlDbType.int, 4, "id_cliente")
        da.InsertCommand.Parameters.Add("@id_banco", SqlDbType.int, 4, "id_banco")
        da.InsertCommand.Parameters.Add("@detalle", SqlDbType.varchar, 50, "detalle")
        da.InsertCommand.Parameters.Add("@fecha_recibido", SqlDbType.datetime, 8, "fecha_recibido")
        da.InsertCommand.Parameters.Add("@fecha_acreditacion", SqlDbType.datetime, 8, "fecha_acreditacion")
        da.InsertCommand.Parameters.Add("@importe", SqlDbType.decimal, 9, "importe")
        da.InsertCommand.Parameters.Add("@iva", SqlDbType.decimal, 9, "iva")
        da.InsertCommand.Parameters.Add("@id_provincia", SqlDbType.int, 4, "id_provincia")
        da.InsertCommand.Parameters.Add("@id_localidad", SqlDbType.int, 4, "id_localidad")
        da.InsertCommand.Parameters.Add("@id_empresa", SqlDbType.int, 4, "id_empresa")
        da.InsertCommand.Parameters.Add("@control", SqlDbType.bit, 1, "control")
        da.InsertCommand.Parameters.Add("@id_proveedor", SqlDbType.int, 4, "id_proveedor")
        da.InsertCommand.Parameters.Add("@anulado", SqlDbType.bit, 1, "anulado")
        da.InsertCommand.Parameters.Add("@pago_tercero", SqlDbType.bit, 1, "pago_tercero")
        da.InsertCommand.Parameters.Add("@numero_recibo", SqlDbType.varchar, 50, "numero_recibo")
        da.InsertCommand.Parameters.Add("@cobro_efectivo", SqlDbType.bit, 1, "cobro_efectivo")
        da.InsertCommand.Parameters.Add("@deposito_cuenta", SqlDbType.bit, 1, "deposito_cuenta")
        da.InsertCommand.Parameters.Add("@id_banco_deposito", SqlDbType.int, 4, "id_banco_deposito")
        da.InsertCommand.Parameters.Add("@id_cuenta", SqlDbType.int, 4, "id_cuenta")
        da.InsertCommand.Parameters.Add("@archivado", SqlDbType.bit, 1, "archivado")

        dr = dt.NewRow()
        dr("numero_cheque") = ""
        dr("id_cliente") = 0
        dr("id_banco") = 0
        dr("detalle") = ""
        dr("fecha_recibido") = DateTime.Now
        dr("fecha_acreditacion") = DateTime.Now
        dr("importe") = 0
        dr("iva") = 0
        dr("id_provincia") = 0
        dr("id_localidad") = 0
        dr("id_empresa") = 0
        dr("control") = False
        dr("id_proveedor") = 0
        dr("anulado") = False
        dr("pago_tercero") = False
        dr("numero_recibo") = ""
        dr("cobro_efectivo") = False
        dr("deposito_cuenta") = False
        dr("id_banco_deposito") = 0
        dr("id_cuenta") = 0
        dr("archivado") = False
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idCheque_recibido As Integer)
        dt = New DataTable("Cheque_recibido")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Cheque_recibido WHERE id_cheque_recibido = @id_Cheque_recibido", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Cheque_recibido", idCheque_recibido)
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
    Public Sub Borrar(ByVal idCheque_recibido As Integer)
        dt = New DataTable("Cheque_recibido")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Cheque_recibido WHERE id_cheque_recibido = " & _
        idCheque_recibido, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Cheque_recibido_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_cheque_recibido", SqlDbType.Int, 4, "id_cheque_recibido")
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
               Case "id_cheque_recibido"
                  dc.DataType = Type.GetType("System.Int32")
               Case "numero_cheque"
                  dc.DataType = Type.GetType("System.String")
               Case "id_cliente"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_banco"
                  dc.DataType = Type.GetType("System.Int32")
               Case "detalle"
                  dc.DataType = Type.GetType("System.String")
               Case "fecha_recibido"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "fecha_acreditacion"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "importe"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "iva"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "id_provincia"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_localidad"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_empresa"
                  dc.DataType = Type.GetType("System.Int32")
               Case "control"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "id_proveedor"
                  dc.DataType = Type.GetType("System.Int32")
               Case "anulado"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "pago_tercero"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "numero_recibo"
                  dc.DataType = Type.GetType("System.String")
               Case "cobro_efectivo"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "deposito_cuenta"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "id_banco_deposito"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_cuenta"
                  dc.DataType = Type.GetType("System.Int32")
               Case "archivado"
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
        dt = New DataTable("Cheque_recibido")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Cheque_recibido WHERE id_cheque_recibido = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cheque_recibido_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cheque_recibido_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cheque_recibido_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Cheque_recibido As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cheque_recibido_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cheque_recibido", SqlDbType.Int, 4, "id_cheque_recibido")
        oda.SelectCommand.Parameters("@id_cheque_recibido").Value = id_Cheque_recibido

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cheque_recibido_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@numero_cheque", SqlDbType.varchar, 50, "numero_cheque")
        oda.SelectCommand.Parameters("@numero_cheque").Value = Me.numero_cheque
        oda.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.int, 4, "id_cliente")
        oda.SelectCommand.Parameters("@id_cliente").Value = Me.id_cliente
        oda.SelectCommand.Parameters.Add("@id_banco", SqlDbType.int, 4, "id_banco")
        oda.SelectCommand.Parameters("@id_banco").Value = Me.id_banco
        oda.SelectCommand.Parameters.Add("@detalle", SqlDbType.varchar, 50, "detalle")
        oda.SelectCommand.Parameters("@detalle").Value = Me.detalle
        oda.SelectCommand.Parameters.Add("@fecha_recibido", SqlDbType.datetime, 8, "fecha_recibido")
        oda.SelectCommand.Parameters("@fecha_recibido").Value = Me.fecha_recibido
        oda.SelectCommand.Parameters.Add("@fecha_acreditacion", SqlDbType.datetime, 8, "fecha_acreditacion")
        oda.SelectCommand.Parameters("@fecha_acreditacion").Value = Me.fecha_acreditacion
        oda.SelectCommand.Parameters.Add("@importe", SqlDbType.decimal, 9, "importe")
        oda.SelectCommand.Parameters("@importe").Value = Me.importe
        oda.SelectCommand.Parameters.Add("@iva", SqlDbType.decimal, 9, "iva")
        oda.SelectCommand.Parameters("@iva").Value = Me.iva
        oda.SelectCommand.Parameters.Add("@id_provincia", SqlDbType.int, 4, "id_provincia")
        oda.SelectCommand.Parameters("@id_provincia").Value = Me.id_provincia
        oda.SelectCommand.Parameters.Add("@id_localidad", SqlDbType.int, 4, "id_localidad")
        oda.SelectCommand.Parameters("@id_localidad").Value = Me.id_localidad
        oda.SelectCommand.Parameters.Add("@id_empresa", SqlDbType.int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@id_empresa").Value = Me.id_empresa
        oda.SelectCommand.Parameters.Add("@control", SqlDbType.bit, 1, "control")
        oda.SelectCommand.Parameters("@control").Value = Me.control
        oda.SelectCommand.Parameters.Add("@id_proveedor", SqlDbType.int, 4, "id_proveedor")
        oda.SelectCommand.Parameters("@id_proveedor").Value = Me.id_proveedor
        oda.SelectCommand.Parameters.Add("@anulado", SqlDbType.bit, 1, "anulado")
        oda.SelectCommand.Parameters("@anulado").Value = Me.anulado
        oda.SelectCommand.Parameters.Add("@pago_tercero", SqlDbType.bit, 1, "pago_tercero")
        oda.SelectCommand.Parameters("@pago_tercero").Value = Me.pago_tercero
        oda.SelectCommand.Parameters.Add("@numero_recibo", SqlDbType.varchar, 50, "numero_recibo")
        oda.SelectCommand.Parameters("@numero_recibo").Value = Me.numero_recibo
        oda.SelectCommand.Parameters.Add("@cobro_efectivo", SqlDbType.bit, 1, "cobro_efectivo")
        oda.SelectCommand.Parameters("@cobro_efectivo").Value = Me.cobro_efectivo
        oda.SelectCommand.Parameters.Add("@deposito_cuenta", SqlDbType.bit, 1, "deposito_cuenta")
        oda.SelectCommand.Parameters("@deposito_cuenta").Value = Me.deposito_cuenta
        oda.SelectCommand.Parameters.Add("@id_banco_deposito", SqlDbType.int, 4, "id_banco_deposito")
        oda.SelectCommand.Parameters("@id_banco_deposito").Value = Me.id_banco_deposito
        oda.SelectCommand.Parameters.Add("@id_cuenta", SqlDbType.int, 4, "id_cuenta")
        oda.SelectCommand.Parameters("@id_cuenta").Value = Me.id_cuenta
        oda.SelectCommand.Parameters.Add("@archivado", SqlDbType.bit, 1, "archivado")
        oda.SelectCommand.Parameters("@archivado").Value = Me.archivado

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
        Command.CommandText = "DELETE FROM Cheque_recibido"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Cheque_recibido"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Cheque_recibido_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Cheque_recibido")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Cheque_recibido.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
