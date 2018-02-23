Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Presupuesto_ent

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_presupuesto As Int32
    Public ReadOnly Property id_presupuesto() As Int32
        Get
            _id_presupuesto = CInt(dr("id_presupuesto"))
            Return _id_presupuesto
        End Get
    end property

    Private _numero As String
    Public Property numero() As String
        Get
            _numero = CStr(dr("numero"))
            Return _numero
        End Get
        Set(ByVal Value As String)
            dr("numero") = Value
        End Set
    end property

    Private _numero_presupuesto As String
    Public Property numero_presupuesto() As String
        Get
            _numero_presupuesto = CStr(dr("numero_presupuesto"))
            Return _numero_presupuesto
        End Get
        Set(ByVal Value As String)
            dr("numero_presupuesto") = Value
        End Set
    end property

    Private _fecha_presupuesto As DateTime
    Public Property fecha_presupuesto() As DateTime
        Get
            _fecha_presupuesto = CDate(dr("fecha_presupuesto"))
            Return _fecha_presupuesto
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha_presupuesto") = Value
        End Set
    end property

    Private _numero_revision As String
    Public Property numero_revision() As String
        Get
            _numero_revision = CStr(dr("numero_revision"))
            Return _numero_revision
        End Get
        Set(ByVal Value As String)
            dr("numero_revision") = Value
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

    Private _plazo_entrega As DateTime
    Public Property plazo_entrega() As DateTime
        Get
            _plazo_entrega = CDate(dr("plazo_entrega"))
            Return _plazo_entrega
        End Get
        Set(ByVal Value As DateTime)
            dr("plazo_entrega") = Value
        End Set
    end property

    Private _importe_total As Decimal
    Public Property importe_total() As Decimal
        Get
            _importe_total = CDec(dr("importe_total"))
            Return _importe_total
        End Get
        Set(ByVal Value As Decimal)
            dr("importe_total") = Value
        End Set
    end property

    Private _id_tipo_moneda As Int32
    Public Property id_tipo_moneda() As Int32
        Get
            _id_tipo_moneda = CInt(dr("id_tipo_moneda"))
            Return _id_tipo_moneda
        End Get
        Set(ByVal Value As Int32)
            dr("id_tipo_moneda") = Value
        End Set
    end property

    Private _id_forma_pago As Int32
    Public Property id_forma_pago() As Int32
        Get
            _id_forma_pago = CInt(dr("id_forma_pago"))
            Return _id_forma_pago
        End Get
        Set(ByVal Value As Int32)
            dr("id_forma_pago") = Value
        End Set
    end property

    Private _id_medio_entrega As Int32
    Public Property id_medio_entrega() As Int32
        Get
            _id_medio_entrega = CInt(dr("id_medio_entrega"))
            Return _id_medio_entrega
        End Get
        Set(ByVal Value As Int32)
            dr("id_medio_entrega") = Value
        End Set
    end property

    Private _id_preparo As Int32
    Public Property id_preparo() As Int32
        Get
            _id_preparo = CInt(dr("id_preparo"))
            Return _id_preparo
        End Get
        Set(ByVal Value As Int32)
            dr("id_preparo") = Value
        End Set
    end property

    Private _id_responsable_calidad As Int32
    Public Property id_responsable_calidad() As Int32
        Get
            _id_responsable_calidad = CInt(dr("id_responsable_calidad"))
            Return _id_responsable_calidad
        End Get
        Set(ByVal Value As Int32)
            dr("id_responsable_calidad") = Value
        End Set
    end property

    Private _id_aprobo As Int32
    Public Property id_aprobo() As Int32
        Get
            _id_aprobo = CInt(dr("id_aprobo"))
            Return _id_aprobo
        End Get
        Set(ByVal Value As Int32)
            dr("id_aprobo") = Value
        End Set
    end property

    Private _id_direccion_general As Int32
    Public Property id_direccion_general() As Int32
        Get
            _id_direccion_general = CInt(dr("id_direccion_general"))
            Return _id_direccion_general
        End Get
        Set(ByVal Value As Int32)
            dr("id_direccion_general") = Value
        End Set
    end property

    Private _fecha_emision As DateTime
    Public Property fecha_emision() As DateTime
        Get
            _fecha_emision = CDate(dr("fecha_emision"))
            Return _fecha_emision
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha_emision") = Value
        End Set
    end property

    Private _fecha_revision As DateTime
    Public Property fecha_revision() As DateTime
        Get
            _fecha_revision = CDate(dr("fecha_revision"))
            Return _fecha_revision
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha_revision") = Value
        End Set
    end property

    Private _id_firma As Int32
    Public Property id_firma() As Int32
        Get
            _id_firma = CInt(dr("id_firma"))
            Return _id_firma
        End Get
        Set(ByVal Value As Int32)
            dr("id_firma") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Presupuesto")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Presupuesto_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_presupuesto", SqlDbType.int, 0, "id_presupuesto")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@numero", SqlDbType.varchar, 50, "numero")
        da.InsertCommand.Parameters.Add("@numero_presupuesto", SqlDbType.varchar, 50, "numero_presupuesto")
        da.InsertCommand.Parameters.Add("@fecha_presupuesto", SqlDbType.datetime, 8, "fecha_presupuesto")
        da.InsertCommand.Parameters.Add("@numero_revision", SqlDbType.varchar, 50, "numero_revision")
        da.InsertCommand.Parameters.Add("@id_cliente", SqlDbType.int, 4, "id_cliente")
        da.InsertCommand.Parameters.Add("@plazo_entrega", SqlDbType.datetime, 8, "plazo_entrega")
        da.InsertCommand.Parameters.Add("@importe_total", SqlDbType.decimal, 9, "importe_total")
        da.InsertCommand.Parameters.Add("@id_tipo_moneda", SqlDbType.int, 4, "id_tipo_moneda")
        da.InsertCommand.Parameters.Add("@id_forma_pago", SqlDbType.int, 4, "id_forma_pago")
        da.InsertCommand.Parameters.Add("@id_medio_entrega", SqlDbType.int, 4, "id_medio_entrega")
        da.InsertCommand.Parameters.Add("@id_preparo", SqlDbType.int, 4, "id_preparo")
        da.InsertCommand.Parameters.Add("@id_responsable_calidad", SqlDbType.int, 4, "id_responsable_calidad")
        da.InsertCommand.Parameters.Add("@id_aprobo", SqlDbType.int, 4, "id_aprobo")
        da.InsertCommand.Parameters.Add("@id_direccion_general", SqlDbType.int, 4, "id_direccion_general")
        da.InsertCommand.Parameters.Add("@fecha_emision", SqlDbType.datetime, 8, "fecha_emision")
        da.InsertCommand.Parameters.Add("@fecha_revision", SqlDbType.datetime, 8, "fecha_revision")
        da.InsertCommand.Parameters.Add("@id_firma", SqlDbType.int, 4, "id_firma")

        dr = dt.NewRow()
        dr("numero") = ""
        dr("numero_presupuesto") = ""
        dr("fecha_presupuesto") = DateTime.Now
        dr("numero_revision") = ""
        dr("id_cliente") = 0
        dr("plazo_entrega") = DateTime.Now
        dr("importe_total") = 0
        dr("id_tipo_moneda") = 0
        dr("id_forma_pago") = 0
        dr("id_medio_entrega") = 0
        dr("id_preparo") = 0
        dr("id_responsable_calidad") = 0
        dr("id_aprobo") = 0
        dr("id_direccion_general") = 0
        dr("fecha_emision") = DateTime.Now
        dr("fecha_revision") = DateTime.Now
        dr("id_firma") = 0
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idPresupuesto As Integer)
        dt = New DataTable("Presupuesto")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Presupuesto WHERE id_presupuesto = @id_Presupuesto", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Presupuesto", idPresupuesto)
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
    Public Sub Borrar(ByVal idPresupuesto As Integer)
        dt = New DataTable("Presupuesto")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Presupuesto WHERE id_presupuesto = " & _
        idPresupuesto, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Presupuesto_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_presupuesto", SqlDbType.Int, 4, "id_presupuesto")
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
               Case "id_presupuesto"
                  dc.DataType = Type.GetType("System.Int32")
               Case "numero"
                  dc.DataType = Type.GetType("System.String")
               Case "numero_presupuesto"
                  dc.DataType = Type.GetType("System.String")
               Case "fecha_presupuesto"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "numero_revision"
                  dc.DataType = Type.GetType("System.String")
               Case "id_cliente"
                  dc.DataType = Type.GetType("System.Int32")
               Case "plazo_entrega"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "importe_total"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "id_tipo_moneda"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_forma_pago"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_medio_entrega"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_preparo"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_responsable_calidad"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_aprobo"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_direccion_general"
                  dc.DataType = Type.GetType("System.Int32")
               Case "fecha_emision"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "fecha_revision"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "id_firma"
                  dc.DataType = Type.GetType("System.Int32")
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
        dt = New DataTable("Presupuesto")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Presupuesto WHERE id_presupuesto = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Presupuesto_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Presupuesto_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Presupuesto_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Presupuesto As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Presupuesto_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_presupuesto", SqlDbType.Int, 4, "id_presupuesto")
        oda.SelectCommand.Parameters("@id_presupuesto").Value = id_Presupuesto

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Presupuesto_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@numero", SqlDbType.varchar, 50, "numero")
        oda.SelectCommand.Parameters("@numero").Value = Me.numero
        oda.SelectCommand.Parameters.Add("@numero_presupuesto", SqlDbType.varchar, 50, "numero_presupuesto")
        oda.SelectCommand.Parameters("@numero_presupuesto").Value = Me.numero_presupuesto
        oda.SelectCommand.Parameters.Add("@fecha_presupuesto", SqlDbType.datetime, 8, "fecha_presupuesto")
        oda.SelectCommand.Parameters("@fecha_presupuesto").Value = Me.fecha_presupuesto
        oda.SelectCommand.Parameters.Add("@numero_revision", SqlDbType.varchar, 50, "numero_revision")
        oda.SelectCommand.Parameters("@numero_revision").Value = Me.numero_revision
        oda.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.int, 4, "id_cliente")
        oda.SelectCommand.Parameters("@id_cliente").Value = Me.id_cliente
        oda.SelectCommand.Parameters.Add("@plazo_entrega", SqlDbType.datetime, 8, "plazo_entrega")
        oda.SelectCommand.Parameters("@plazo_entrega").Value = Me.plazo_entrega
        oda.SelectCommand.Parameters.Add("@importe_total", SqlDbType.decimal, 9, "importe_total")
        oda.SelectCommand.Parameters("@importe_total").Value = Me.importe_total
        oda.SelectCommand.Parameters.Add("@id_tipo_moneda", SqlDbType.int, 4, "id_tipo_moneda")
        oda.SelectCommand.Parameters("@id_tipo_moneda").Value = Me.id_tipo_moneda
        oda.SelectCommand.Parameters.Add("@id_forma_pago", SqlDbType.int, 4, "id_forma_pago")
        oda.SelectCommand.Parameters("@id_forma_pago").Value = Me.id_forma_pago
        oda.SelectCommand.Parameters.Add("@id_medio_entrega", SqlDbType.int, 4, "id_medio_entrega")
        oda.SelectCommand.Parameters("@id_medio_entrega").Value = Me.id_medio_entrega
        oda.SelectCommand.Parameters.Add("@id_preparo", SqlDbType.int, 4, "id_preparo")
        oda.SelectCommand.Parameters("@id_preparo").Value = Me.id_preparo
        oda.SelectCommand.Parameters.Add("@id_responsable_calidad", SqlDbType.int, 4, "id_responsable_calidad")
        oda.SelectCommand.Parameters("@id_responsable_calidad").Value = Me.id_responsable_calidad
        oda.SelectCommand.Parameters.Add("@id_aprobo", SqlDbType.int, 4, "id_aprobo")
        oda.SelectCommand.Parameters("@id_aprobo").Value = Me.id_aprobo
        oda.SelectCommand.Parameters.Add("@id_direccion_general", SqlDbType.int, 4, "id_direccion_general")
        oda.SelectCommand.Parameters("@id_direccion_general").Value = Me.id_direccion_general
        oda.SelectCommand.Parameters.Add("@fecha_emision", SqlDbType.datetime, 8, "fecha_emision")
        oda.SelectCommand.Parameters("@fecha_emision").Value = Me.fecha_emision
        oda.SelectCommand.Parameters.Add("@fecha_revision", SqlDbType.datetime, 8, "fecha_revision")
        oda.SelectCommand.Parameters("@fecha_revision").Value = Me.fecha_revision
        oda.SelectCommand.Parameters.Add("@id_firma", SqlDbType.int, 4, "id_firma")
        oda.SelectCommand.Parameters("@id_firma").Value = Me.id_firma

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
        Command.CommandText = "DELETE FROM Presupuesto"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Presupuesto"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Presupuesto_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Presupuesto")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Presupuesto.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
