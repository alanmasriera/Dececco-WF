Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Cliente_ent

    'defino las variables
    Private dt As DataTable
    Private dr As DataRow
    Private da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_cliente As Int32
    Public ReadOnly Property id_cliente() As Int32
        Get
            _id_cliente = CInt(dr("id_cliente"))
            Return _id_cliente
        End Get
    end property

    Private _nombre_cliente As String
    Public Property nombre_cliente() As String
        Get
            _nombre_cliente = CStr(dr("nombre_cliente"))
            Return _nombre_cliente
        End Get
        Set(ByVal Value As String)
            dr("nombre_cliente") = Value
        End Set
    end property

    Private _apellido_cliente As String
    Public Property apellido_cliente() As String
        Get
            _apellido_cliente = CStr(dr("apellido_cliente"))
            Return _apellido_cliente
        End Get
        Set(ByVal Value As String)
            dr("apellido_cliente") = Value
        End Set
    end property

    Private _razon_social As String
    Public Property razon_social() As String
        Get
            _razon_social = CStr(dr("razon_social"))
            Return _razon_social
        End Get
        Set(ByVal Value As String)
            dr("razon_social") = Value
        End Set
    end property

    Private _nombre_fantasia As String
    Public Property nombre_fantasia() As String
        Get
            _nombre_fantasia = CStr(dr("nombre_fantasia"))
            Return _nombre_fantasia
        End Get
        Set(ByVal Value As String)
            dr("nombre_fantasia") = Value
        End Set
    end property

    Private _contacto As String
    Public Property contacto() As String
        Get
            _contacto = CStr(dr("contacto"))
            Return _contacto
        End Get
        Set(ByVal Value As String)
            dr("contacto") = Value
        End Set
    end property

    Private _dni_cliente As String
    Public Property dni_cliente() As String
        Get
            _dni_cliente = CStr(dr("dni_cliente"))
            Return _dni_cliente
        End Get
        Set(ByVal Value As String)
            dr("dni_cliente") = Value
        End Set
    end property

    Private _id_tipo_dni As Int32
    Public Property id_tipo_dni() As Int32
        Get
            _id_tipo_dni = CInt(dr("id_tipo_dni"))
            Return _id_tipo_dni
        End Get
        Set(ByVal Value As Int32)
            dr("id_tipo_dni") = Value
        End Set
    end property

    Private _id_calle As Int32
    Public Property id_calle() As Int32
        Get
            _id_calle = CInt(dr("id_calle"))
            Return _id_calle
        End Get
        Set(ByVal Value As Int32)
            dr("id_calle") = Value
        End Set
    end property

    Private _direccion_cliente As String
    Public Property direccion_cliente() As String
        Get
            _direccion_cliente = CStr(dr("direccion_cliente"))
            Return _direccion_cliente
        End Get
        Set(ByVal Value As String)
            dr("direccion_cliente") = Value
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

    Private _telefono As String
    Public Property telefono() As String
        Get
            _telefono = CStr(dr("telefono"))
            Return _telefono
        End Get
        Set(ByVal Value As String)
            dr("telefono") = Value
        End Set
    end property

    Private _mail As String
    Public Property mail() As String
        Get
            _mail = CStr(dr("mail"))
            Return _mail
        End Get
        Set(ByVal Value As String)
            dr("mail") = Value
        End Set
    end property

    Private _web As String
    Public Property web() As String
        Get
            _web = CStr(dr("web"))
            Return _web
        End Get
        Set(ByVal Value As String)
            dr("web") = Value
        End Set
    end property

    Private _id_condicion_iva As Int32
    Public Property id_condicion_iva() As Int32
        Get
            _id_condicion_iva = CInt(dr("id_condicion_iva"))
            Return _id_condicion_iva
        End Get
        Set(ByVal Value As Int32)
            dr("id_condicion_iva") = Value
        End Set
    end property

    Private _ingreso_bruto As String
    Public Property ingreso_bruto() As String
        Get
            _ingreso_bruto = CStr(dr("ingreso_bruto"))
            Return _ingreso_bruto
        End Get
        Set(ByVal Value As String)
            dr("ingreso_bruto") = Value
        End Set
    end property

    Private _lugar_pago As String
    Public Property lugar_pago() As String
        Get
            _lugar_pago = CStr(dr("lugar_pago"))
            Return _lugar_pago
        End Get
        Set(ByVal Value As String)
            dr("lugar_pago") = Value
        End Set
    end property

    Private _percepcion_iva As Boolean
    Public Property percepcion_iva() As Boolean
        Get
            _percepcion_iva = CBool(dr("percepcion_iva"))
            Return _percepcion_iva
        End Get
        Set(ByVal Value As Boolean)
            dr("percepcion_iva") = Value
        End Set
    end property

    Private _percepcion_ingreso_bruto As Boolean
    Public Property percepcion_ingreso_bruto() As Boolean
        Get
            _percepcion_ingreso_bruto = CBool(dr("percepcion_ingreso_bruto"))
            Return _percepcion_ingreso_bruto
        End Get
        Set(ByVal Value As Boolean)
            dr("percepcion_ingreso_bruto") = Value
        End Set
    end property

    Private _retencion_iva As Boolean
    Public Property retencion_iva() As Boolean
        Get
            _retencion_iva = CBool(dr("retencion_iva"))
            Return _retencion_iva
        End Get
        Set(ByVal Value As Boolean)
            dr("retencion_iva") = Value
        End Set
    end property

    Private _retencion_ingreso_bruto As Boolean
    Public Property retencion_ingreso_bruto() As Boolean
        Get
            _retencion_ingreso_bruto = CBool(dr("retencion_ingreso_bruto"))
            Return _retencion_ingreso_bruto
        End Get
        Set(ByVal Value As Boolean)
            dr("retencion_ingreso_bruto") = Value
        End Set
    end property

    Private _numero_proveedor As String
    Public Property numero_proveedor() As String
        Get
            _numero_proveedor = CStr(dr("numero_proveedor"))
            Return _numero_proveedor
        End Get
        Set(ByVal Value As String)
            dr("numero_proveedor") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Cliente")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Cliente_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_cliente", SqlDbType.int, 0, "id_cliente")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@nombre_cliente", SqlDbType.varchar, 50, "nombre_cliente")
        da.InsertCommand.Parameters.Add("@apellido_cliente", SqlDbType.varchar, 50, "apellido_cliente")
        da.InsertCommand.Parameters.Add("@razon_social", SqlDbType.varchar, 50, "razon_social")
        da.InsertCommand.Parameters.Add("@nombre_fantasia", SqlDbType.varchar, 50, "nombre_fantasia")
        da.InsertCommand.Parameters.Add("@contacto", SqlDbType.varchar, 50, "contacto")
        da.InsertCommand.Parameters.Add("@dni_cliente", SqlDbType.varchar, 50, "dni_cliente")
        da.InsertCommand.Parameters.Add("@id_tipo_dni", SqlDbType.int, 4, "id_tipo_dni")
        da.InsertCommand.Parameters.Add("@id_calle", SqlDbType.int, 4, "id_calle")
        da.InsertCommand.Parameters.Add("@direccion_cliente", SqlDbType.varchar, 200, "direccion_cliente")
        da.InsertCommand.Parameters.Add("@id_localidad", SqlDbType.int, 4, "id_localidad")
        da.InsertCommand.Parameters.Add("@id_provincia", SqlDbType.int, 4, "id_provincia")
        da.InsertCommand.Parameters.Add("@telefono", SqlDbType.varchar, 50, "telefono")
        da.InsertCommand.Parameters.Add("@mail", SqlDbType.varchar, 50, "mail")
        da.InsertCommand.Parameters.Add("@web", SqlDbType.varchar, 50, "web")
        da.InsertCommand.Parameters.Add("@id_condicion_iva", SqlDbType.int, 4, "id_condicion_iva")
        da.InsertCommand.Parameters.Add("@ingreso_bruto", SqlDbType.varchar, 50, "ingreso_bruto")
        da.InsertCommand.Parameters.Add("@lugar_pago", SqlDbType.varchar, 50, "lugar_pago")
        da.InsertCommand.Parameters.Add("@percepcion_iva", SqlDbType.bit, 1, "percepcion_iva")
        da.InsertCommand.Parameters.Add("@percepcion_ingreso_bruto", SqlDbType.bit, 1, "percepcion_ingreso_bruto")
        da.InsertCommand.Parameters.Add("@retencion_iva", SqlDbType.bit, 1, "retencion_iva")
        da.InsertCommand.Parameters.Add("@retencion_ingreso_bruto", SqlDbType.bit, 1, "retencion_ingreso_bruto")
        da.InsertCommand.Parameters.Add("@numero_proveedor", SqlDbType.varchar, 50, "numero_proveedor")

        dr = dt.NewRow()
        dr("nombre_cliente") = ""
        dr("apellido_cliente") = ""
        dr("razon_social") = ""
        dr("nombre_fantasia") = ""
        dr("contacto") = ""
        dr("dni_cliente") = ""
        dr("id_tipo_dni") = 0
        dr("id_calle") = 0
        dr("direccion_cliente") = ""
        dr("id_localidad") = 0
        dr("id_provincia") = 0
        dr("telefono") = ""
        dr("mail") = ""
        dr("web") = ""
        dr("id_condicion_iva") = 0
        dr("ingreso_bruto") = ""
        dr("lugar_pago") = ""
        dr("percepcion_iva") = False
        dr("percepcion_ingreso_bruto") = False
        dr("retencion_iva") = False
        dr("retencion_ingreso_bruto") = False
        dr("numero_proveedor") = ""
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idCliente As Integer)
        dt = New DataTable("Cliente")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Cliente WHERE id_cliente = @id_Cliente", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Cliente", idCliente)
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
    Public Sub Borrar(ByVal idCliente As Integer)
        dt = New DataTable("Cliente")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Cliente WHERE id_cliente = " & _
        idCliente, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Cliente_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_cliente", SqlDbType.Int, 4, "id_cliente")
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
               Case "id_cliente"
                  dc.DataType = Type.GetType("System.Int32")
               Case "nombre_cliente"
                  dc.DataType = Type.GetType("System.String")
               Case "apellido_cliente"
                  dc.DataType = Type.GetType("System.String")
               Case "razon_social"
                  dc.DataType = Type.GetType("System.String")
               Case "nombre_fantasia"
                  dc.DataType = Type.GetType("System.String")
               Case "contacto"
                  dc.DataType = Type.GetType("System.String")
               Case "dni_cliente"
                  dc.DataType = Type.GetType("System.String")
               Case "id_tipo_dni"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_calle"
                  dc.DataType = Type.GetType("System.Int32")
               Case "direccion_cliente"
                  dc.DataType = Type.GetType("System.String")
               Case "id_localidad"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_provincia"
                  dc.DataType = Type.GetType("System.Int32")
               Case "telefono"
                  dc.DataType = Type.GetType("System.String")
               Case "mail"
                  dc.DataType = Type.GetType("System.String")
               Case "web"
                  dc.DataType = Type.GetType("System.String")
               Case "id_condicion_iva"
                  dc.DataType = Type.GetType("System.Int32")
               Case "ingreso_bruto"
                  dc.DataType = Type.GetType("System.String")
               Case "lugar_pago"
                  dc.DataType = Type.GetType("System.String")
               Case "percepcion_iva"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "percepcion_ingreso_bruto"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "retencion_iva"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "retencion_ingreso_bruto"
                  dc.DataType = Type.GetType("System.Boolean")
               Case "numero_proveedor"
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
        dt = New DataTable("Cliente")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Cliente WHERE id_cliente = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cliente_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cliente_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cliente_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Cliente As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cliente_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.Int, 4, "id_cliente")
        oda.SelectCommand.Parameters("@id_cliente").Value = id_Cliente

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Cliente_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre_cliente", SqlDbType.varchar, 50, "nombre_cliente")
        oda.SelectCommand.Parameters("@nombre_cliente").Value = Me.nombre_cliente
        oda.SelectCommand.Parameters.Add("@apellido_cliente", SqlDbType.varchar, 50, "apellido_cliente")
        oda.SelectCommand.Parameters("@apellido_cliente").Value = Me.apellido_cliente
        oda.SelectCommand.Parameters.Add("@razon_social", SqlDbType.varchar, 50, "razon_social")
        oda.SelectCommand.Parameters("@razon_social").Value = Me.razon_social
        oda.SelectCommand.Parameters.Add("@nombre_fantasia", SqlDbType.varchar, 50, "nombre_fantasia")
        oda.SelectCommand.Parameters("@nombre_fantasia").Value = Me.nombre_fantasia
        oda.SelectCommand.Parameters.Add("@contacto", SqlDbType.varchar, 50, "contacto")
        oda.SelectCommand.Parameters("@contacto").Value = Me.contacto
        oda.SelectCommand.Parameters.Add("@dni_cliente", SqlDbType.varchar, 50, "dni_cliente")
        oda.SelectCommand.Parameters("@dni_cliente").Value = Me.dni_cliente
        oda.SelectCommand.Parameters.Add("@id_tipo_dni", SqlDbType.int, 4, "id_tipo_dni")
        oda.SelectCommand.Parameters("@id_tipo_dni").Value = Me.id_tipo_dni
        oda.SelectCommand.Parameters.Add("@id_calle", SqlDbType.int, 4, "id_calle")
        oda.SelectCommand.Parameters("@id_calle").Value = Me.id_calle
        oda.SelectCommand.Parameters.Add("@direccion_cliente", SqlDbType.varchar, 200, "direccion_cliente")
        oda.SelectCommand.Parameters("@direccion_cliente").Value = Me.direccion_cliente
        oda.SelectCommand.Parameters.Add("@id_localidad", SqlDbType.int, 4, "id_localidad")
        oda.SelectCommand.Parameters("@id_localidad").Value = Me.id_localidad
        oda.SelectCommand.Parameters.Add("@id_provincia", SqlDbType.int, 4, "id_provincia")
        oda.SelectCommand.Parameters("@id_provincia").Value = Me.id_provincia
        oda.SelectCommand.Parameters.Add("@telefono", SqlDbType.varchar, 50, "telefono")
        oda.SelectCommand.Parameters("@telefono").Value = Me.telefono
        oda.SelectCommand.Parameters.Add("@mail", SqlDbType.varchar, 50, "mail")
        oda.SelectCommand.Parameters("@mail").Value = Me.mail
        oda.SelectCommand.Parameters.Add("@web", SqlDbType.varchar, 50, "web")
        oda.SelectCommand.Parameters("@web").Value = Me.web
        oda.SelectCommand.Parameters.Add("@id_condicion_iva", SqlDbType.int, 4, "id_condicion_iva")
        oda.SelectCommand.Parameters("@id_condicion_iva").Value = Me.id_condicion_iva
        oda.SelectCommand.Parameters.Add("@ingreso_bruto", SqlDbType.varchar, 50, "ingreso_bruto")
        oda.SelectCommand.Parameters("@ingreso_bruto").Value = Me.ingreso_bruto
        oda.SelectCommand.Parameters.Add("@lugar_pago", SqlDbType.varchar, 50, "lugar_pago")
        oda.SelectCommand.Parameters("@lugar_pago").Value = Me.lugar_pago
        oda.SelectCommand.Parameters.Add("@percepcion_iva", SqlDbType.bit, 1, "percepcion_iva")
        oda.SelectCommand.Parameters("@percepcion_iva").Value = Me.percepcion_iva
        oda.SelectCommand.Parameters.Add("@percepcion_ingreso_bruto", SqlDbType.bit, 1, "percepcion_ingreso_bruto")
        oda.SelectCommand.Parameters("@percepcion_ingreso_bruto").Value = Me.percepcion_ingreso_bruto
        oda.SelectCommand.Parameters.Add("@retencion_iva", SqlDbType.bit, 1, "retencion_iva")
        oda.SelectCommand.Parameters("@retencion_iva").Value = Me.retencion_iva
        oda.SelectCommand.Parameters.Add("@retencion_ingreso_bruto", SqlDbType.bit, 1, "retencion_ingreso_bruto")
        oda.SelectCommand.Parameters("@retencion_ingreso_bruto").Value = Me.retencion_ingreso_bruto
        oda.SelectCommand.Parameters.Add("@numero_proveedor", SqlDbType.varchar, 50, "numero_proveedor")
        oda.SelectCommand.Parameters("@numero_proveedor").Value = Me.numero_proveedor

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
        Command.CommandText = "DELETE FROM Cliente"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Cliente"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Cliente_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Cliente")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Cliente.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
