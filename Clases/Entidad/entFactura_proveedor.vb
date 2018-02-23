Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Factura_proveedor_ent

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_factura_proveedor As Int32
    Public ReadOnly Property id_factura_proveedor() As Int32
        Get
            _id_factura_proveedor = CInt(dr("id_factura_proveedor"))
            Return _id_factura_proveedor
        End Get
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

    Private _id_tipo_comprobante As Int32
    Public Property id_tipo_comprobante() As Int32
        Get
            _id_tipo_comprobante = CInt(dr("id_tipo_comprobante"))
            Return _id_tipo_comprobante
        End Get
        Set(ByVal Value As Int32)
            dr("id_tipo_comprobante") = Value
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

    Private _estado As String
    Public Property estado() As String
        Get
            _estado = CStr(dr("estado"))
            Return _estado
        End Get
        Set(ByVal Value As String)
            dr("estado") = Value
        End Set
    end property

    Private _alicuota_iva As Decimal
    Public Property alicuota_iva() As Decimal
        Get
            _alicuota_iva = CDec(dr("alicuota_iva"))
            Return _alicuota_iva
        End Get
        Set(ByVal Value As Decimal)
            dr("alicuota_iva") = Value
        End Set
    end property

    Private _iva_21 As Decimal
    Public Property iva_21() As Decimal
        Get
            _iva_21 = CDec(dr("iva_21"))
            Return _iva_21
        End Get
        Set(ByVal Value As Decimal)
            dr("iva_21") = Value
        End Set
    end property

    Private _iva_10_5 As Decimal
    Public Property iva_10_5() As Decimal
        Get
            _iva_10_5 = CDec(dr("iva_10_5"))
            Return _iva_10_5
        End Get
        Set(ByVal Value As Decimal)
            dr("iva_10_5") = Value
        End Set
    end property

    Private _importe_21 As Decimal
    Public Property importe_21() As Decimal
        Get
            _importe_21 = CDec(dr("importe_21"))
            Return _importe_21
        End Get
        Set(ByVal Value As Decimal)
            dr("importe_21") = Value
        End Set
    end property

    Private _importe_10_5 As Decimal
    Public Property importe_10_5() As Decimal
        Get
            _importe_10_5 = CDec(dr("importe_10_5"))
            Return _importe_10_5
        End Get
        Set(ByVal Value As Decimal)
            dr("importe_10_5") = Value
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

    Private _percepcion_iva As Decimal
    Public Property percepcion_iva() As Decimal
        Get
            _percepcion_iva = CDec(dr("percepcion_iva"))
            Return _percepcion_iva
        End Get
        Set(ByVal Value As Decimal)
            dr("percepcion_iva") = Value
        End Set
    end property

    Private _retencion_ingreso_bruto As Decimal
    Public Property retencion_ingreso_bruto() As Decimal
        Get
            _retencion_ingreso_bruto = CDec(dr("retencion_ingreso_bruto"))
            Return _retencion_ingreso_bruto
        End Get
        Set(ByVal Value As Decimal)
            dr("retencion_ingreso_bruto") = Value
        End Set
    end property

    Private _percepcion_ingreso_bruto As Decimal
    Public Property percepcion_ingreso_bruto() As Decimal
        Get
            _percepcion_ingreso_bruto = CDec(dr("percepcion_ingreso_bruto"))
            Return _percepcion_ingreso_bruto
        End Get
        Set(ByVal Value As Decimal)
            dr("percepcion_ingreso_bruto") = Value
        End Set
    end property

    Private _retencion_ganancia As Decimal
    Public Property retencion_ganancia() As Decimal
        Get
            _retencion_ganancia = CDec(dr("retencion_ganancia"))
            Return _retencion_ganancia
        End Get
        Set(ByVal Value As Decimal)
            dr("retencion_ganancia") = Value
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

    Private _otro As Decimal
    Public Property otro() As Decimal
        Get
            _otro = CDec(dr("otro"))
            Return _otro
        End Get
        Set(ByVal Value As Decimal)
            dr("otro") = Value
        End Set
    end property

    Private _total_21 As Decimal
    Public Property total_21() As Decimal
        Get
            _total_21 = CDec(dr("total_21"))
            Return _total_21
        End Get
        Set(ByVal Value As Decimal)
            dr("total_21") = Value
        End Set
    end property

    Private _total_10_5 As Decimal
    Public Property total_10_5() As Decimal
        Get
            _total_10_5 = CDec(dr("total_10_5"))
            Return _total_10_5
        End Get
        Set(ByVal Value As Decimal)
            dr("total_10_5") = Value
        End Set
    end property

    Private _total_sin As Decimal
    Public Property total_sin() As Decimal
        Get
            _total_sin = CDec(dr("total_sin"))
            Return _total_sin
        End Get
        Set(ByVal Value As Decimal)
            dr("total_sin") = Value
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

    Private _id_cuenta_contable As Int32
    Public Property id_cuenta_contable() As Int32
        Get
            _id_cuenta_contable = CInt(dr("id_cuenta_contable"))
            Return _id_cuenta_contable
        End Get
        Set(ByVal Value As Int32)
            dr("id_cuenta_contable") = Value
        End Set
    end property

    Private _id_usuario As Int32
    Public Property id_usuario() As Int32
        Get
            _id_usuario = CInt(dr("id_usuario"))
            Return _id_usuario
        End Get
        Set(ByVal Value As Int32)
            dr("id_usuario") = Value
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

    Private _saldo_factura As Decimal
    Public Property saldo_factura() As Decimal
        Get
            _saldo_factura = CDec(dr("saldo_factura"))
            Return _saldo_factura
        End Get
        Set(ByVal Value As Decimal)
            dr("saldo_factura") = Value
        End Set
    end property

    Private _pagada As Boolean
    Public Property pagada() As Boolean
        Get
            _pagada = CBool(dr("pagada"))
            Return _pagada
        End Get
        Set(ByVal Value As Boolean)
            dr("pagada") = Value
        End Set
    end property

    Private _numero_certificado As Int32
    Public Property numero_certificado() As Int32
        Get
            _numero_certificado = CInt(dr("numero_certificado"))
            Return _numero_certificado
        End Get
        Set(ByVal Value As Int32)
            dr("numero_certificado") = Value
        End Set
    end property

    Private _pago_a_cuenta As Boolean
    Public Property pago_a_cuenta() As Boolean
        Get
            _pago_a_cuenta = CBool(dr("pago_a_cuenta"))
            Return _pago_a_cuenta
        End Get
        Set(ByVal Value As Boolean)
            dr("pago_a_cuenta") = Value
        End Set
    end property

    Private _sin_pago As Boolean
    Public Property sin_pago() As Boolean
        Get
            _sin_pago = CBool(dr("sin_pago"))
            Return _sin_pago
        End Get
        Set(ByVal Value As Boolean)
            dr("sin_pago") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Factura_proveedor")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Factura_proveedor_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_factura_proveedor", SqlDbType.int, 0, "id_factura_proveedor")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@numero_factura", SqlDbType.char, 12, "numero_factura")
        da.InsertCommand.Parameters.Add("@id_empresa", SqlDbType.int, 4, "id_empresa")
        da.InsertCommand.Parameters.Add("@id_tipo_comprobante", SqlDbType.int, 4, "id_tipo_comprobante")
        da.InsertCommand.Parameters.Add("@fecha", SqlDbType.datetime, 8, "fecha")
        da.InsertCommand.Parameters.Add("@fecha_factura", SqlDbType.datetime, 8, "fecha_factura")
        da.InsertCommand.Parameters.Add("@fecha_vencimiento", SqlDbType.datetime, 8, "fecha_vencimiento")
        da.InsertCommand.Parameters.Add("@id_proveedor", SqlDbType.int, 4, "id_proveedor")
        da.InsertCommand.Parameters.Add("@observacion", SqlDbType.varchar, 500, "observacion")
        da.InsertCommand.Parameters.Add("@saldo", SqlDbType.decimal, 9, "saldo")
        da.InsertCommand.Parameters.Add("@estado", SqlDbType.char, 1, "estado")
        da.InsertCommand.Parameters.Add("@alicuota_iva", SqlDbType.decimal, 9, "alicuota_iva")
        da.InsertCommand.Parameters.Add("@iva_21", SqlDbType.decimal, 9, "iva_21")
        da.InsertCommand.Parameters.Add("@iva_10_5", SqlDbType.decimal, 9, "iva_10_5")
        da.InsertCommand.Parameters.Add("@importe_21", SqlDbType.decimal, 9, "importe_21")
        da.InsertCommand.Parameters.Add("@importe_10_5", SqlDbType.decimal, 9, "importe_10_5")
        da.InsertCommand.Parameters.Add("@retencion_iva", SqlDbType.decimal, 9, "retencion_iva")
        da.InsertCommand.Parameters.Add("@percepcion_iva", SqlDbType.decimal, 9, "percepcion_iva")
        da.InsertCommand.Parameters.Add("@retencion_ingreso_bruto", SqlDbType.decimal, 9, "retencion_ingreso_bruto")
        da.InsertCommand.Parameters.Add("@percepcion_ingreso_bruto", SqlDbType.decimal, 9, "percepcion_ingreso_bruto")
        da.InsertCommand.Parameters.Add("@retencion_ganancia", SqlDbType.decimal, 9, "retencion_ganancia")
        da.InsertCommand.Parameters.Add("@impuesto_interno", SqlDbType.decimal, 9, "impuesto_interno")
        da.InsertCommand.Parameters.Add("@otro", SqlDbType.decimal, 9, "otro")
        da.InsertCommand.Parameters.Add("@total_21", SqlDbType.decimal, 9, "total_21")
        da.InsertCommand.Parameters.Add("@total_10_5", SqlDbType.decimal, 9, "total_10_5")
        da.InsertCommand.Parameters.Add("@total_sin", SqlDbType.decimal, 9, "total_sin")
        da.InsertCommand.Parameters.Add("@total_factura", SqlDbType.decimal, 9, "total_factura")
        da.InsertCommand.Parameters.Add("@id_almacen", SqlDbType.int, 4, "id_almacen")
        da.InsertCommand.Parameters.Add("@id_cuenta_contable", SqlDbType.int, 4, "id_cuenta_contable")
        da.InsertCommand.Parameters.Add("@id_usuario", SqlDbType.int, 4, "id_usuario")
        da.InsertCommand.Parameters.Add("@tilde", SqlDbType.bit, 1, "tilde")
        da.InsertCommand.Parameters.Add("@referencia", SqlDbType.varchar, 50, "referencia")
        da.InsertCommand.Parameters.Add("@saldo_factura", SqlDbType.decimal, 9, "saldo_factura")
        da.InsertCommand.Parameters.Add("@pagada", SqlDbType.bit, 1, "pagada")
        da.InsertCommand.Parameters.Add("@numero_certificado", SqlDbType.int, 4, "numero_certificado")
        da.InsertCommand.Parameters.Add("@pago_a_cuenta", SqlDbType.bit, 1, "pago_a_cuenta")
        da.InsertCommand.Parameters.Add("@sin_pago", SqlDbType.bit, 1, "sin_pago")

        dr = dt.NewRow()
        dr("numero_factura") = ""
        dr("id_empresa") = 0
        dr("id_tipo_comprobante") = 0
        dr("fecha") = DateTime.Now
        dr("fecha_factura") = DateTime.Now
        dr("fecha_vencimiento") = DateTime.Now
        dr("id_proveedor") = 0
        dr("observacion") = ""
        dr("saldo") = 0
        dr("estado") = ""
        dr("alicuota_iva") = 0
        dr("iva_21") = 0
        dr("iva_10_5") = 0
        dr("importe_21") = 0
        dr("importe_10_5") = 0
        dr("retencion_iva") = 0
        dr("percepcion_iva") = 0
        dr("retencion_ingreso_bruto") = 0
        dr("percepcion_ingreso_bruto") = 0
        dr("retencion_ganancia") = 0
        dr("impuesto_interno") = 0
        dr("otro") = 0
        dr("total_21") = 0
        dr("total_10_5") = 0
        dr("total_sin") = 0
        dr("total_factura") = 0
        dr("id_almacen") = 0
        dr("id_cuenta_contable") = 0
        dr("id_usuario") = 0
        dr("tilde") = False
        dr("referencia") = ""
        dr("saldo_factura") = 0
        dr("pagada") = False
        dr("numero_certificado") = 0
        dr("pago_a_cuenta") = False
        dr("sin_pago") = False
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idFactura_proveedor As Integer)
        dt = New DataTable("Factura_proveedor")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Factura_proveedor WHERE id_factura_proveedor = @id_Factura_proveedor", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Factura_proveedor", idFactura_proveedor)
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
    Public Sub Borrar(ByVal idFactura_proveedor As Integer)
        dt = New DataTable("Factura_proveedor")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Factura_proveedor WHERE id_factura_proveedor = " & _
        idFactura_proveedor, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Factura_proveedor_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_factura_proveedor", SqlDbType.Int, 4, "id_factura_proveedor")
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
               Case "id_factura_proveedor"
                  dc.DataType = Type.GetType("System.Int32")
               Case "numero_factura"
                  dc.DataType = Type.GetType("System.String")
               Case "id_empresa"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_tipo_comprobante"
                  dc.DataType = Type.GetType("System.Int32")
               Case "fecha"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "fecha_factura"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "fecha_vencimiento"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "id_proveedor"
                  dc.DataType = Type.GetType("System.Int32")
               Case "observacion"
                  dc.DataType = Type.GetType("System.String")
               Case "saldo"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "estado"
                  dc.DataType = Type.GetType("System.String")
               Case "alicuota_iva"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "iva_21"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "iva_10_5"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "importe_21"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "importe_10_5"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "retencion_iva"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "percepcion_iva"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "retencion_ingreso_bruto"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "percepcion_ingreso_bruto"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "retencion_ganancia"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "impuesto_interno"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "otro"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "total_21"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "total_10_5"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "total_sin"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "total_factura"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "id_almacen"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_cuenta_contable"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_usuario"
                  dc.DataType = Type.GetType("System.Int32")
               Case "tilde"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "referencia"
                  dc.DataType = Type.GetType("System.String")
               Case "saldo_factura"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "pagada"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "numero_certificado"
                  dc.DataType = Type.GetType("System.Int32")
               Case "pago_a_cuenta"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "sin_pago"
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
        dt = New DataTable("Factura_proveedor")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Factura_proveedor WHERE id_factura_proveedor = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_proveedor_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_proveedor_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_proveedor_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Factura_proveedor As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_proveedor_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_factura_proveedor", SqlDbType.Int, 4, "id_factura_proveedor")
        oda.SelectCommand.Parameters("@id_factura_proveedor").Value = id_Factura_proveedor

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Factura_proveedor_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@numero_factura", SqlDbType.char, 12, "numero_factura")
        oda.SelectCommand.Parameters("@numero_factura").Value = Me.numero_factura
        oda.SelectCommand.Parameters.Add("@id_empresa", SqlDbType.int, 4, "id_empresa")
        oda.SelectCommand.Parameters("@id_empresa").Value = Me.id_empresa
        oda.SelectCommand.Parameters.Add("@id_tipo_comprobante", SqlDbType.int, 4, "id_tipo_comprobante")
        oda.SelectCommand.Parameters("@id_tipo_comprobante").Value = Me.id_tipo_comprobante
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.datetime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = Me.fecha
        oda.SelectCommand.Parameters.Add("@fecha_factura", SqlDbType.datetime, 8, "fecha_factura")
        oda.SelectCommand.Parameters("@fecha_factura").Value = Me.fecha_factura
        oda.SelectCommand.Parameters.Add("@fecha_vencimiento", SqlDbType.datetime, 8, "fecha_vencimiento")
        oda.SelectCommand.Parameters("@fecha_vencimiento").Value = Me.fecha_vencimiento
        oda.SelectCommand.Parameters.Add("@id_proveedor", SqlDbType.int, 4, "id_proveedor")
        oda.SelectCommand.Parameters("@id_proveedor").Value = Me.id_proveedor
        oda.SelectCommand.Parameters.Add("@observacion", SqlDbType.varchar, 500, "observacion")
        oda.SelectCommand.Parameters("@observacion").Value = Me.observacion
        oda.SelectCommand.Parameters.Add("@saldo", SqlDbType.decimal, 9, "saldo")
        oda.SelectCommand.Parameters("@saldo").Value = Me.saldo
        oda.SelectCommand.Parameters.Add("@estado", SqlDbType.char, 1, "estado")
        oda.SelectCommand.Parameters("@estado").Value = Me.estado
        oda.SelectCommand.Parameters.Add("@alicuota_iva", SqlDbType.decimal, 9, "alicuota_iva")
        oda.SelectCommand.Parameters("@alicuota_iva").Value = Me.alicuota_iva
        oda.SelectCommand.Parameters.Add("@iva_21", SqlDbType.decimal, 9, "iva_21")
        oda.SelectCommand.Parameters("@iva_21").Value = Me.iva_21
        oda.SelectCommand.Parameters.Add("@iva_10_5", SqlDbType.decimal, 9, "iva_10_5")
        oda.SelectCommand.Parameters("@iva_10_5").Value = Me.iva_10_5
        oda.SelectCommand.Parameters.Add("@importe_21", SqlDbType.decimal, 9, "importe_21")
        oda.SelectCommand.Parameters("@importe_21").Value = Me.importe_21
        oda.SelectCommand.Parameters.Add("@importe_10_5", SqlDbType.decimal, 9, "importe_10_5")
        oda.SelectCommand.Parameters("@importe_10_5").Value = Me.importe_10_5
        oda.SelectCommand.Parameters.Add("@retencion_iva", SqlDbType.decimal, 9, "retencion_iva")
        oda.SelectCommand.Parameters("@retencion_iva").Value = Me.retencion_iva
        oda.SelectCommand.Parameters.Add("@percepcion_iva", SqlDbType.decimal, 9, "percepcion_iva")
        oda.SelectCommand.Parameters("@percepcion_iva").Value = Me.percepcion_iva
        oda.SelectCommand.Parameters.Add("@retencion_ingreso_bruto", SqlDbType.decimal, 9, "retencion_ingreso_bruto")
        oda.SelectCommand.Parameters("@retencion_ingreso_bruto").Value = Me.retencion_ingreso_bruto
        oda.SelectCommand.Parameters.Add("@percepcion_ingreso_bruto", SqlDbType.decimal, 9, "percepcion_ingreso_bruto")
        oda.SelectCommand.Parameters("@percepcion_ingreso_bruto").Value = Me.percepcion_ingreso_bruto
        oda.SelectCommand.Parameters.Add("@retencion_ganancia", SqlDbType.decimal, 9, "retencion_ganancia")
        oda.SelectCommand.Parameters("@retencion_ganancia").Value = Me.retencion_ganancia
        oda.SelectCommand.Parameters.Add("@impuesto_interno", SqlDbType.decimal, 9, "impuesto_interno")
        oda.SelectCommand.Parameters("@impuesto_interno").Value = Me.impuesto_interno
        oda.SelectCommand.Parameters.Add("@otro", SqlDbType.decimal, 9, "otro")
        oda.SelectCommand.Parameters("@otro").Value = Me.otro
        oda.SelectCommand.Parameters.Add("@total_21", SqlDbType.decimal, 9, "total_21")
        oda.SelectCommand.Parameters("@total_21").Value = Me.total_21
        oda.SelectCommand.Parameters.Add("@total_10_5", SqlDbType.decimal, 9, "total_10_5")
        oda.SelectCommand.Parameters("@total_10_5").Value = Me.total_10_5
        oda.SelectCommand.Parameters.Add("@total_sin", SqlDbType.decimal, 9, "total_sin")
        oda.SelectCommand.Parameters("@total_sin").Value = Me.total_sin
        oda.SelectCommand.Parameters.Add("@total_factura", SqlDbType.decimal, 9, "total_factura")
        oda.SelectCommand.Parameters("@total_factura").Value = Me.total_factura
        oda.SelectCommand.Parameters.Add("@id_almacen", SqlDbType.int, 4, "id_almacen")
        oda.SelectCommand.Parameters("@id_almacen").Value = Me.id_almacen
        oda.SelectCommand.Parameters.Add("@id_cuenta_contable", SqlDbType.int, 4, "id_cuenta_contable")
        oda.SelectCommand.Parameters("@id_cuenta_contable").Value = Me.id_cuenta_contable
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = Me.id_usuario
        oda.SelectCommand.Parameters.Add("@tilde", SqlDbType.bit, 1, "tilde")
        oda.SelectCommand.Parameters("@tilde").Value = Me.tilde
        oda.SelectCommand.Parameters.Add("@referencia", SqlDbType.varchar, 50, "referencia")
        oda.SelectCommand.Parameters("@referencia").Value = Me.referencia
        oda.SelectCommand.Parameters.Add("@saldo_factura", SqlDbType.decimal, 9, "saldo_factura")
        oda.SelectCommand.Parameters("@saldo_factura").Value = Me.saldo_factura
        oda.SelectCommand.Parameters.Add("@pagada", SqlDbType.bit, 1, "pagada")
        oda.SelectCommand.Parameters("@pagada").Value = Me.pagada
        oda.SelectCommand.Parameters.Add("@numero_certificado", SqlDbType.int, 4, "numero_certificado")
        oda.SelectCommand.Parameters("@numero_certificado").Value = Me.numero_certificado
        oda.SelectCommand.Parameters.Add("@pago_a_cuenta", SqlDbType.bit, 1, "pago_a_cuenta")
        oda.SelectCommand.Parameters("@pago_a_cuenta").Value = Me.pago_a_cuenta
        oda.SelectCommand.Parameters.Add("@sin_pago", SqlDbType.bit, 1, "sin_pago")
        oda.SelectCommand.Parameters("@sin_pago").Value = Me.sin_pago

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
        Command.CommandText = "DELETE FROM Factura_proveedor"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Factura_proveedor"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Factura_proveedor_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Factura_proveedor")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Factura_proveedor.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
