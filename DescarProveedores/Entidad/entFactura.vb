Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Factura_ent

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
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

    Private _iva_factura As Decimal
    Public Property iva_factura() As Decimal
        Get
            _iva_factura = CDec(dr("iva_factura"))
            Return _iva_factura
        End Get
        Set(ByVal Value As Decimal)
            dr("iva_factura") = Value
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

    Private _total_iva As Decimal
    Public Property total_iva() As Decimal
        Get
            _total_iva = CDec(dr("total_iva"))
            Return _total_iva
        End Get
        Set(ByVal Value As Decimal)
            dr("total_iva") = Value
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

    Private _responsable_inscripto As Boolean
    Public Property responsable_inscripto() As Boolean
        Get
            _responsable_inscripto = CBool(dr("responsable_inscripto"))
            Return _responsable_inscripto
        End Get
        Set(ByVal Value As Boolean)
            dr("responsable_inscripto") = Value
        End Set
    end property

    Private _responsable_no_inscripto As Boolean
    Public Property responsable_no_inscripto() As Boolean
        Get
            _responsable_no_inscripto = CBool(dr("responsable_no_inscripto"))
            Return _responsable_no_inscripto
        End Get
        Set(ByVal Value As Boolean)
            dr("responsable_no_inscripto") = Value
        End Set
    end property

    Private _contado As Boolean
    Public Property contado() As Boolean
        Get
            _contado = CBool(dr("contado"))
            Return _contado
        End Get
        Set(ByVal Value As Boolean)
            dr("contado") = Value
        End Set
    end property

    Private _cuenta_corriente As Boolean
    Public Property cuenta_corriente() As Boolean
        Get
            _cuenta_corriente = CBool(dr("cuenta_corriente"))
            Return _cuenta_corriente
        End Get
        Set(ByVal Value As Boolean)
            dr("cuenta_corriente") = Value
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

    Private _impuesto As Decimal
    Public Property impuesto() As Decimal
        Get
            _impuesto = CDec(dr("impuesto"))
            Return _impuesto
        End Get
        Set(ByVal Value As Decimal)
            dr("impuesto") = Value
        End Set
    end property

    Private _iva_no_inscripto As Decimal
    Public Property iva_no_inscripto() As Decimal
        Get
            _iva_no_inscripto = CDec(dr("iva_no_inscripto"))
            Return _iva_no_inscripto
        End Get
        Set(ByVal Value As Decimal)
            dr("iva_no_inscripto") = Value
        End Set
    end property

    Private _condicion_pago As String
    Public Property condicion_pago() As String
        Get
            _condicion_pago = CStr(dr("condicion_pago"))
            Return _condicion_pago
        End Get
        Set(ByVal Value As String)
            dr("condicion_pago") = Value
        End Set
    end property

    Private _referencia As String
    Public Property referencia() As String
        Get
            _referencia = CStr(dr("referencia"))
            Return _referencia
        End Get
        Set(ByVal Value As String)
            dr("referencia") = Value
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

    Private _archivada As Boolean
    Public Property archivada() As Boolean
        Get
            _archivada = CBool(dr("archivada"))
            Return _archivada
        End Get
        Set(ByVal Value As Boolean)
            dr("archivada") = Value
        End Set
    end property

    Private _pago_parcial As Boolean
    Public Property pago_parcial() As Boolean
        Get
            _pago_parcial = CBool(dr("pago_parcial"))
            Return _pago_parcial
        End Get
        Set(ByVal Value As Boolean)
            dr("pago_parcial") = Value
        End Set
    end property

    Private _saldo As Decimal
    Public Property saldo() As Decimal
        Get
            _saldo = CDec(dr("saldo"))
            Return _saldo
        End Get
        Set(ByVal Value As Decimal)
            dr("saldo") = Value
        End Set
    end property

    Private _retencion As Boolean
    Public Property retencion() As Boolean
        Get
            _retencion = CBool(dr("retencion"))
            Return _retencion
        End Get
        Set(ByVal Value As Boolean)
            dr("retencion") = Value
        End Set
    end property

    Private _valor_retencion As Decimal
    Public Property valor_retencion() As Decimal
        Get
            _valor_retencion = CDec(dr("valor_retencion"))
            Return _valor_retencion
        End Get
        Set(ByVal Value As Decimal)
            dr("valor_retencion") = Value
        End Set
    end property

    Private _fecha_vencimiento As DateTime
    Public Property fecha_vencimiento() As DateTime
        Get
            _fecha_vencimiento = CDate(dr("fecha_vencimiento"))
            Return _fecha_vencimiento
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha_vencimiento") = Value
        End Set
    end property

    Private _numero_certificado As String
    Public Property numero_certificado() As String
        Get
            _numero_certificado = CStr(dr("numero_certificado"))
            Return _numero_certificado
        End Get
        Set(ByVal Value As String)
            dr("numero_certificado") = Value
        End Set
    end property

    Private _id_moneda As Int32
    Public Property id_moneda() As Int32
        Get
            _id_moneda = CInt(dr("id_moneda"))
            Return _id_moneda
        End Get
        Set(ByVal Value As Int32)
            dr("id_moneda") = Value
        End Set
    end property

    Private _Tarjeta As Boolean
    Public Property Tarjeta() As Boolean
        Get
            _Tarjeta = CBool(dr("Tarjeta"))
            Return _Tarjeta
        End Get
        Set(ByVal Value As Boolean)
            dr("Tarjeta") = Value
        End Set
    end property

    Private _Cheque As Boolean
    Public Property Cheque() As Boolean
        Get
            _Cheque = CBool(dr("Cheque"))
            Return _Cheque
        End Get
        Set(ByVal Value As Boolean)
            dr("Cheque") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Factura")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Factura_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_factura", SqlDbType.int, 0, "id_factura")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@id_cliente", SqlDbType.int, 4, "id_cliente")
        da.InsertCommand.Parameters.Add("@numero_factura", SqlDbType.varchar, 50, "numero_factura")
        da.InsertCommand.Parameters.Add("@fecha_factura", SqlDbType.datetime, 8, "fecha_factura")
        da.InsertCommand.Parameters.Add("@iva_factura", SqlDbType.decimal, 9, "iva_factura")
        da.InsertCommand.Parameters.Add("@anulada", SqlDbType.bit, 1, "anulada")
        da.InsertCommand.Parameters.Add("@subtotal_factura", SqlDbType.decimal, 9, "subtotal_factura")
        da.InsertCommand.Parameters.Add("@tipo_factura", SqlDbType.varchar, 50, "tipo_factura")
        da.InsertCommand.Parameters.Add("@total_iva", SqlDbType.decimal, 9, "total_iva")
        da.InsertCommand.Parameters.Add("@total_factura", SqlDbType.decimal, 9, "total_factura")
        da.InsertCommand.Parameters.Add("@total_letra", SqlDbType.varchar, 500, "total_letra")
        da.InsertCommand.Parameters.Add("@movimiento", SqlDbType.varchar, 50, "movimiento")
        da.InsertCommand.Parameters.Add("@responsable_inscripto", SqlDbType.bit, 1, "responsable_inscripto")
        da.InsertCommand.Parameters.Add("@responsable_no_inscripto", SqlDbType.bit, 1, "responsable_no_inscripto")
        da.InsertCommand.Parameters.Add("@contado", SqlDbType.bit, 1, "contado")
        da.InsertCommand.Parameters.Add("@cuenta_corriente", SqlDbType.bit, 1, "cuenta_corriente")
        da.InsertCommand.Parameters.Add("@numero_recibo", SqlDbType.varchar, 50, "numero_recibo")
        da.InsertCommand.Parameters.Add("@impuesto", SqlDbType.decimal, 9, "impuesto")
        da.InsertCommand.Parameters.Add("@iva_no_inscripto", SqlDbType.decimal, 9, "iva_no_inscripto")
        da.InsertCommand.Parameters.Add("@condicion_pago", SqlDbType.varchar, 50, "condicion_pago")
        da.InsertCommand.Parameters.Add("@referencia", SqlDbType.varchar, 50, "referencia")
        da.InsertCommand.Parameters.Add("@fecha", SqlDbType.datetime, 8, "fecha")
        da.InsertCommand.Parameters.Add("@retencion_iva", SqlDbType.decimal, 9, "retencion_iva")
        da.InsertCommand.Parameters.Add("@archivada", SqlDbType.bit, 1, "archivada")
        da.InsertCommand.Parameters.Add("@pago_parcial", SqlDbType.bit, 1, "pago_parcial")
        da.InsertCommand.Parameters.Add("@saldo", SqlDbType.decimal, 9, "saldo")
        da.InsertCommand.Parameters.Add("@retencion", SqlDbType.bit, 1, "retencion")
        da.InsertCommand.Parameters.Add("@valor_retencion", SqlDbType.decimal, 9, "valor_retencion")
        da.InsertCommand.Parameters.Add("@fecha_vencimiento", SqlDbType.datetime, 8, "fecha_vencimiento")
        da.InsertCommand.Parameters.Add("@numero_certificado", SqlDbType.varchar, 50, "numero_certificado")
        da.InsertCommand.Parameters.Add("@id_moneda", SqlDbType.int, 4, "id_moneda")
        da.InsertCommand.Parameters.Add("@Tarjeta", SqlDbType.bit, 1, "Tarjeta")
        da.InsertCommand.Parameters.Add("@Cheque", SqlDbType.bit, 1, "Cheque")

        dr = dt.NewRow()
        dr("id_cliente") = 0
        dr("numero_factura") = ""
        dr("fecha_factura") = DateTime.Now
        dr("iva_factura") = 0
        dr("anulada") = False
        dr("subtotal_factura") = 0
        dr("tipo_factura") = ""
        dr("total_iva") = 0
        dr("total_factura") = 0
        dr("total_letra") = ""
        dr("movimiento") = ""
        dr("responsable_inscripto") = False
        dr("responsable_no_inscripto") = False
        dr("contado") = False
        dr("cuenta_corriente") = False
        dr("numero_recibo") = ""
        dr("impuesto") = 0
        dr("iva_no_inscripto") = 0
        dr("condicion_pago") = ""
        dr("referencia") = ""
        dr("fecha") = DateTime.Now
        dr("retencion_iva") = 0
        dr("archivada") = False
        dr("pago_parcial") = False
        dr("saldo") = 0
        dr("retencion") = False
        dr("valor_retencion") = 0
        dr("fecha_vencimiento") = DateTime.Now
        dr("numero_certificado") = ""
        dr("id_moneda") = 0
        dr("Tarjeta") = False
        dr("Cheque") = False
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idFactura As Integer)
        dt = New DataTable("Factura")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Factura WHERE id_factura = @id_Factura", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Factura", idFactura)
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
    Public Sub Borrar(ByVal idFactura As Integer)
        dt = New DataTable("Factura")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Factura WHERE id_factura = " & _
        idFactura, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Factura_Delete", cnn.Coneccion)
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
               Case "iva_factura"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "anulada"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "subtotal_factura"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "tipo_factura"
                  dc.DataType = Type.GetType("System.String")
               Case "total_iva"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "total_factura"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "total_letra"
                  dc.DataType = Type.GetType("System.String")
               Case "movimiento"
                  dc.DataType = Type.GetType("System.String")
               Case "responsable_inscripto"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "responsable_no_inscripto"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "contado"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "cuenta_corriente"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "numero_recibo"
                  dc.DataType = Type.GetType("System.String")
               Case "impuesto"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "iva_no_inscripto"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "condicion_pago"
                  dc.DataType = Type.GetType("System.String")
               Case "referencia"
                  dc.DataType = Type.GetType("System.String")
               Case "fecha"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "retencion_iva"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "archivada"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "pago_parcial"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "saldo"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "retencion"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "valor_retencion"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "fecha_vencimiento"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "numero_certificado"
                  dc.DataType = Type.GetType("System.String")
               Case "id_moneda"
                  dc.DataType = Type.GetType("System.Int32")
               Case "Tarjeta"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "Cheque"
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
        dt = New DataTable("Factura")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Factura WHERE id_factura = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Factura As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_factura", SqlDbType.Int, 4, "id_factura")
        oda.SelectCommand.Parameters("@id_factura").Value = id_Factura

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.int, 4, "id_cliente")
        oda.SelectCommand.Parameters("@id_cliente").Value = Me.id_cliente
        oda.SelectCommand.Parameters.Add("@numero_factura", SqlDbType.varchar, 50, "numero_factura")
        oda.SelectCommand.Parameters("@numero_factura").Value = Me.numero_factura
        oda.SelectCommand.Parameters.Add("@fecha_factura", SqlDbType.datetime, 8, "fecha_factura")
        oda.SelectCommand.Parameters("@fecha_factura").Value = Me.fecha_factura
        oda.SelectCommand.Parameters.Add("@iva_factura", SqlDbType.decimal, 9, "iva_factura")
        oda.SelectCommand.Parameters("@iva_factura").Value = Me.iva_factura
        oda.SelectCommand.Parameters.Add("@anulada", SqlDbType.bit, 1, "anulada")
        oda.SelectCommand.Parameters("@anulada").Value = Me.anulada
        oda.SelectCommand.Parameters.Add("@subtotal_factura", SqlDbType.decimal, 9, "subtotal_factura")
        oda.SelectCommand.Parameters("@subtotal_factura").Value = Me.subtotal_factura
        oda.SelectCommand.Parameters.Add("@tipo_factura", SqlDbType.varchar, 50, "tipo_factura")
        oda.SelectCommand.Parameters("@tipo_factura").Value = Me.tipo_factura
        oda.SelectCommand.Parameters.Add("@total_iva", SqlDbType.decimal, 9, "total_iva")
        oda.SelectCommand.Parameters("@total_iva").Value = Me.total_iva
        oda.SelectCommand.Parameters.Add("@total_factura", SqlDbType.decimal, 9, "total_factura")
        oda.SelectCommand.Parameters("@total_factura").Value = Me.total_factura
        oda.SelectCommand.Parameters.Add("@total_letra", SqlDbType.varchar, 500, "total_letra")
        oda.SelectCommand.Parameters("@total_letra").Value = Me.total_letra
        oda.SelectCommand.Parameters.Add("@movimiento", SqlDbType.varchar, 50, "movimiento")
        oda.SelectCommand.Parameters("@movimiento").Value = Me.movimiento
        oda.SelectCommand.Parameters.Add("@responsable_inscripto", SqlDbType.bit, 1, "responsable_inscripto")
        oda.SelectCommand.Parameters("@responsable_inscripto").Value = Me.responsable_inscripto
        oda.SelectCommand.Parameters.Add("@responsable_no_inscripto", SqlDbType.bit, 1, "responsable_no_inscripto")
        oda.SelectCommand.Parameters("@responsable_no_inscripto").Value = Me.responsable_no_inscripto
        oda.SelectCommand.Parameters.Add("@contado", SqlDbType.bit, 1, "contado")
        oda.SelectCommand.Parameters("@contado").Value = Me.contado
        oda.SelectCommand.Parameters.Add("@cuenta_corriente", SqlDbType.bit, 1, "cuenta_corriente")
        oda.SelectCommand.Parameters("@cuenta_corriente").Value = Me.cuenta_corriente
        oda.SelectCommand.Parameters.Add("@numero_recibo", SqlDbType.varchar, 50, "numero_recibo")
        oda.SelectCommand.Parameters("@numero_recibo").Value = Me.numero_recibo
        oda.SelectCommand.Parameters.Add("@impuesto", SqlDbType.decimal, 9, "impuesto")
        oda.SelectCommand.Parameters("@impuesto").Value = Me.impuesto
        oda.SelectCommand.Parameters.Add("@iva_no_inscripto", SqlDbType.decimal, 9, "iva_no_inscripto")
        oda.SelectCommand.Parameters("@iva_no_inscripto").Value = Me.iva_no_inscripto
        oda.SelectCommand.Parameters.Add("@condicion_pago", SqlDbType.varchar, 50, "condicion_pago")
        oda.SelectCommand.Parameters("@condicion_pago").Value = Me.condicion_pago
        oda.SelectCommand.Parameters.Add("@referencia", SqlDbType.varchar, 50, "referencia")
        oda.SelectCommand.Parameters("@referencia").Value = Me.referencia
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.datetime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = Me.fecha
        oda.SelectCommand.Parameters.Add("@retencion_iva", SqlDbType.decimal, 9, "retencion_iva")
        oda.SelectCommand.Parameters("@retencion_iva").Value = Me.retencion_iva
        oda.SelectCommand.Parameters.Add("@archivada", SqlDbType.bit, 1, "archivada")
        oda.SelectCommand.Parameters("@archivada").Value = Me.archivada
        oda.SelectCommand.Parameters.Add("@pago_parcial", SqlDbType.bit, 1, "pago_parcial")
        oda.SelectCommand.Parameters("@pago_parcial").Value = Me.pago_parcial
        oda.SelectCommand.Parameters.Add("@saldo", SqlDbType.decimal, 9, "saldo")
        oda.SelectCommand.Parameters("@saldo").Value = Me.saldo
        oda.SelectCommand.Parameters.Add("@retencion", SqlDbType.bit, 1, "retencion")
        oda.SelectCommand.Parameters("@retencion").Value = Me.retencion
        oda.SelectCommand.Parameters.Add("@valor_retencion", SqlDbType.decimal, 9, "valor_retencion")
        oda.SelectCommand.Parameters("@valor_retencion").Value = Me.valor_retencion
        oda.SelectCommand.Parameters.Add("@fecha_vencimiento", SqlDbType.datetime, 8, "fecha_vencimiento")
        oda.SelectCommand.Parameters("@fecha_vencimiento").Value = Me.fecha_vencimiento
        oda.SelectCommand.Parameters.Add("@numero_certificado", SqlDbType.varchar, 50, "numero_certificado")
        oda.SelectCommand.Parameters("@numero_certificado").Value = Me.numero_certificado
        oda.SelectCommand.Parameters.Add("@id_moneda", SqlDbType.int, 4, "id_moneda")
        oda.SelectCommand.Parameters("@id_moneda").Value = Me.id_moneda
        oda.SelectCommand.Parameters.Add("@Tarjeta", SqlDbType.bit, 1, "Tarjeta")
        oda.SelectCommand.Parameters("@Tarjeta").Value = Me.Tarjeta
        oda.SelectCommand.Parameters.Add("@Cheque", SqlDbType.bit, 1, "Cheque")
        oda.SelectCommand.Parameters("@Cheque").Value = Me.Cheque

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
        Command.CommandText = "DELETE FROM Factura"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Factura"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Factura_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Factura")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Factura.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
