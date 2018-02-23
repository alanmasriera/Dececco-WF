Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Pago_cliente_ent

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_pago_cliente As Int32
    Public ReadOnly Property id_pago_cliente() As Int32
        Get
            _id_pago_cliente = CInt(dr("id_pago_cliente"))
            Return _id_pago_cliente
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

    Private _fecha As DateTime
    Public Property fecha() As DateTime
        Get
            _fecha = CDate(dr("fecha"))
            Return _fecha
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha") = Value
        End Set
    end property

    Private _pago As Decimal
    Public Property pago() As Decimal
        Get
            _pago = CDec(dr("pago"))
            Return _pago
        End Get
        Set(ByVal Value As Decimal)
            dr("pago") = Value
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

    Private _efectivo As Boolean
    Public Property efectivo() As Boolean
        Get
            _efectivo = CBool(dr("efectivo"))
            Return _efectivo
        End Get
        Set(ByVal Value As Boolean)
            dr("efectivo") = Value
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

    Private _retencion_iva As Decimal
    Public Property retencion_iva() As Decimal
        Get
            _retencion_iva = CDec(dr("retencion_iva"))
            Return _retencion_iva
        End Get
        Set(ByVal Value As Decimal)
            dr("retencion_iva") = Value
        End Set
    end property

    Private _ingreso_bruto As Decimal
    Public Property ingreso_bruto() As Decimal
        Get
            _ingreso_bruto = CDec(dr("ingreso_bruto"))
            Return _ingreso_bruto
        End Get
        Set(ByVal Value As Decimal)
            dr("ingreso_bruto") = Value
        End Set
    end property

    Private _impuesto_ganancia As Decimal
    Public Property impuesto_ganancia() As Decimal
        Get
            _impuesto_ganancia = CDec(dr("impuesto_ganancia"))
            Return _impuesto_ganancia
        End Get
        Set(ByVal Value As Decimal)
            dr("impuesto_ganancia") = Value
        End Set
    end property

    Private _suss As Decimal
    Public Property suss() As Decimal
        Get
            _suss = CDec(dr("suss"))
            Return _suss
        End Get
        Set(ByVal Value As Decimal)
            dr("suss") = Value
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

    Private _observacion As String
    Public Property observacion() As String
        Get
            _observacion = CStr(dr("observacion"))
            Return _observacion
        End Get
        Set(ByVal Value As String)
            dr("observacion") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Pago_cliente")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Pago_cliente_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_pago_cliente", SqlDbType.int, 0, "id_pago_cliente")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@id_cliente", SqlDbType.int, 4, "id_cliente")
        da.InsertCommand.Parameters.Add("@fecha", SqlDbType.datetime, 8, "fecha")
        da.InsertCommand.Parameters.Add("@pago", SqlDbType.decimal, 9, "pago")
        da.InsertCommand.Parameters.Add("@detalle", SqlDbType.varchar, 5000, "detalle")
        da.InsertCommand.Parameters.Add("@efectivo", SqlDbType.bit, 1, "efectivo")
        da.InsertCommand.Parameters.Add("@numero_recibo", SqlDbType.varchar, 50, "numero_recibo")
        da.InsertCommand.Parameters.Add("@retencion_iva", SqlDbType.decimal, 9, "retencion_iva")
        da.InsertCommand.Parameters.Add("@ingreso_bruto", SqlDbType.decimal, 9, "ingreso_bruto")
        da.InsertCommand.Parameters.Add("@impuesto_ganancia", SqlDbType.decimal, 9, "impuesto_ganancia")
        da.InsertCommand.Parameters.Add("@suss", SqlDbType.decimal, 9, "suss")
        da.InsertCommand.Parameters.Add("@total_letra", SqlDbType.varchar, 5000, "total_letra")
        da.InsertCommand.Parameters.Add("@observacion", SqlDbType.varchar, 5000, "observacion")

        dr = dt.NewRow()
        dr("id_cliente") = 0
        dr("fecha") = DateTime.Now
        dr("pago") = 0
        dr("detalle") = ""
        dr("efectivo") = False
        dr("numero_recibo") = ""
        dr("retencion_iva") = 0
        dr("ingreso_bruto") = 0
        dr("impuesto_ganancia") = 0
        dr("suss") = 0
        dr("total_letra") = ""
        dr("observacion") = ""
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idPago_cliente As Integer)
        dt = New DataTable("Pago_cliente")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Pago_cliente WHERE id_pago_cliente = @id_Pago_cliente", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Pago_cliente", idPago_cliente)
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
    Public Sub Borrar(ByVal idPago_cliente As Integer)
        dt = New DataTable("Pago_cliente")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Pago_cliente WHERE id_pago_cliente = " & _
        idPago_cliente, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Pago_cliente_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_pago_cliente", SqlDbType.Int, 4, "id_pago_cliente")
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
               Case "id_pago_cliente"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_cliente"
                  dc.DataType = Type.GetType("System.Int32")
               Case "fecha"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "pago"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "detalle"
                  dc.DataType = Type.GetType("System.String")
               Case "efectivo"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "numero_recibo"
                  dc.DataType = Type.GetType("System.String")
               Case "retencion_iva"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "ingreso_bruto"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "impuesto_ganancia"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "suss"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "total_letra"
                  dc.DataType = Type.GetType("System.String")
               Case "observacion"
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
        dt = New DataTable("Pago_cliente")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Pago_cliente WHERE id_pago_cliente = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Pago_cliente_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Pago_cliente_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Pago_cliente_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Pago_cliente As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Pago_cliente_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_pago_cliente", SqlDbType.Int, 4, "id_pago_cliente")
        oda.SelectCommand.Parameters("@id_pago_cliente").Value = id_Pago_cliente

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Pago_cliente_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.int, 4, "id_cliente")
        oda.SelectCommand.Parameters("@id_cliente").Value = Me.id_cliente
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.datetime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = Me.fecha
        oda.SelectCommand.Parameters.Add("@pago", SqlDbType.decimal, 9, "pago")
        oda.SelectCommand.Parameters("@pago").Value = Me.pago
        oda.SelectCommand.Parameters.Add("@detalle", SqlDbType.varchar, 5000, "detalle")
        oda.SelectCommand.Parameters("@detalle").Value = Me.detalle
        oda.SelectCommand.Parameters.Add("@efectivo", SqlDbType.bit, 1, "efectivo")
        oda.SelectCommand.Parameters("@efectivo").Value = Me.efectivo
        oda.SelectCommand.Parameters.Add("@numero_recibo", SqlDbType.varchar, 50, "numero_recibo")
        oda.SelectCommand.Parameters("@numero_recibo").Value = Me.numero_recibo
        oda.SelectCommand.Parameters.Add("@retencion_iva", SqlDbType.decimal, 9, "retencion_iva")
        oda.SelectCommand.Parameters("@retencion_iva").Value = Me.retencion_iva
        oda.SelectCommand.Parameters.Add("@ingreso_bruto", SqlDbType.decimal, 9, "ingreso_bruto")
        oda.SelectCommand.Parameters("@ingreso_bruto").Value = Me.ingreso_bruto
        oda.SelectCommand.Parameters.Add("@impuesto_ganancia", SqlDbType.decimal, 9, "impuesto_ganancia")
        oda.SelectCommand.Parameters("@impuesto_ganancia").Value = Me.impuesto_ganancia
        oda.SelectCommand.Parameters.Add("@suss", SqlDbType.decimal, 9, "suss")
        oda.SelectCommand.Parameters("@suss").Value = Me.suss
        oda.SelectCommand.Parameters.Add("@total_letra", SqlDbType.varchar, 5000, "total_letra")
        oda.SelectCommand.Parameters("@total_letra").Value = Me.total_letra
        oda.SelectCommand.Parameters.Add("@observacion", SqlDbType.varchar, 5000, "observacion")
        oda.SelectCommand.Parameters("@observacion").Value = Me.observacion

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
        Command.CommandText = "DELETE FROM Pago_cliente"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Pago_cliente"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Pago_cliente_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Pago_cliente")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Pago_cliente.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
