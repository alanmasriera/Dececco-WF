Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Temp_grilla_pago_cliente_ent

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_temp_grilla_pago_cliente As Int32
    Public ReadOnly Property id_temp_grilla_pago_cliente() As Int32
        Get
            _id_temp_grilla_pago_cliente = CInt(dr("id_temp_grilla_pago_cliente"))
            Return _id_temp_grilla_pago_cliente
        End Get
    end property

    Private _id_pago_cliente As Int32
    Public Property id_pago_cliente() As Int32
        Get
            _id_pago_cliente = CInt(dr("id_pago_cliente"))
            Return _id_pago_cliente
        End Get
        Set(ByVal Value As Int32)
            dr("id_pago_cliente") = Value
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

    Private _apellido As String
    Public Property apellido() As String
        Get
            _apellido = CStr(dr("apellido"))
            Return _apellido
        End Get
        Set(ByVal Value As String)
            dr("apellido") = Value
        End Set
    end property

    Private _nombre As String
    Public Property nombre() As String
        Get
            _nombre = CStr(dr("nombre"))
            Return _nombre
        End Get
        Set(ByVal Value As String)
            dr("nombre") = Value
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

    Private _numero_orden_compra As String
    Public Property numero_orden_compra() As String
        Get
            _numero_orden_compra = CStr(dr("numero_orden_compra"))
            Return _numero_orden_compra
        End Get
        Set(ByVal Value As String)
            dr("numero_orden_compra") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Temp_grilla_pago_cliente")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Temp_grilla_pago_cliente_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_temp_grilla_pago_cliente", SqlDbType.int, 0, "id_temp_grilla_pago_cliente")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@id_pago_cliente", SqlDbType.int, 4, "id_pago_cliente")
        da.InsertCommand.Parameters.Add("@fecha", SqlDbType.datetime, 8, "fecha")
        da.InsertCommand.Parameters.Add("@apellido", SqlDbType.varchar, 50, "apellido")
        da.InsertCommand.Parameters.Add("@nombre", SqlDbType.varchar, 50, "nombre")
        da.InsertCommand.Parameters.Add("@pago", SqlDbType.decimal, 9, "pago")
        da.InsertCommand.Parameters.Add("@detalle", SqlDbType.varchar, 5000, "detalle")
        da.InsertCommand.Parameters.Add("@numero_recibo", SqlDbType.varchar, 50, "numero_recibo")
        da.InsertCommand.Parameters.Add("@observacion", SqlDbType.varchar, 5000, "observacion")
        da.InsertCommand.Parameters.Add("@numero_orden_compra", SqlDbType.varchar, 50, "numero_orden_compra")

        dr = dt.NewRow()
        dr("id_pago_cliente") = 0
        dr("fecha") = DateTime.Now
        dr("apellido") = ""
        dr("nombre") = ""
        dr("pago") = 0
        dr("detalle") = ""
        dr("numero_recibo") = ""
        dr("observacion") = ""
        dr("numero_orden_compra") = ""
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idTemp_grilla_pago_cliente As Integer)
        dt = New DataTable("Temp_grilla_pago_cliente")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Temp_grilla_pago_cliente WHERE id_temp_grilla_pago_cliente = @id_Temp_grilla_pago_cliente", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Temp_grilla_pago_cliente", idTemp_grilla_pago_cliente)
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
    Public Sub Borrar(ByVal idTemp_grilla_pago_cliente As Integer)
        dt = New DataTable("Temp_grilla_pago_cliente")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Temp_grilla_pago_cliente WHERE id_temp_grilla_pago_cliente = " & _
        idTemp_grilla_pago_cliente, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Temp_grilla_pago_cliente_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_temp_grilla_pago_cliente", SqlDbType.Int, 4, "id_temp_grilla_pago_cliente")
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
               Case "id_temp_grilla_pago_cliente"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_pago_cliente"
                  dc.DataType = Type.GetType("System.Int32")
               Case "fecha"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "apellido"
                  dc.DataType = Type.GetType("System.String")
               Case "nombre"
                  dc.DataType = Type.GetType("System.String")
               Case "pago"
                  dc.DataType = Type.GetType("System.Decimal")
               Case "detalle"
                  dc.DataType = Type.GetType("System.String")
               Case "numero_recibo"
                  dc.DataType = Type.GetType("System.String")
               Case "observacion"
                  dc.DataType = Type.GetType("System.String")
               Case "numero_orden_compra"
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
        dt = New DataTable("Temp_grilla_pago_cliente")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Temp_grilla_pago_cliente WHERE id_temp_grilla_pago_cliente = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Temp_grilla_pago_cliente_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Temp_grilla_pago_cliente_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Temp_grilla_pago_cliente_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Temp_grilla_pago_cliente As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Temp_grilla_pago_cliente_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_temp_grilla_pago_cliente", SqlDbType.Int, 4, "id_temp_grilla_pago_cliente")
        oda.SelectCommand.Parameters("@id_temp_grilla_pago_cliente").Value = id_Temp_grilla_pago_cliente

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Temp_grilla_pago_cliente_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_pago_cliente", SqlDbType.int, 4, "id_pago_cliente")
        oda.SelectCommand.Parameters("@id_pago_cliente").Value = Me.id_pago_cliente
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.datetime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = Me.fecha
        oda.SelectCommand.Parameters.Add("@apellido", SqlDbType.varchar, 50, "apellido")
        oda.SelectCommand.Parameters("@apellido").Value = Me.apellido
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.varchar, 50, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Me.nombre
        oda.SelectCommand.Parameters.Add("@pago", SqlDbType.decimal, 9, "pago")
        oda.SelectCommand.Parameters("@pago").Value = Me.pago
        oda.SelectCommand.Parameters.Add("@detalle", SqlDbType.varchar, 5000, "detalle")
        oda.SelectCommand.Parameters("@detalle").Value = Me.detalle
        oda.SelectCommand.Parameters.Add("@numero_recibo", SqlDbType.varchar, 50, "numero_recibo")
        oda.SelectCommand.Parameters("@numero_recibo").Value = Me.numero_recibo
        oda.SelectCommand.Parameters.Add("@observacion", SqlDbType.varchar, 5000, "observacion")
        oda.SelectCommand.Parameters("@observacion").Value = Me.observacion
        oda.SelectCommand.Parameters.Add("@numero_orden_compra", SqlDbType.varchar, 50, "numero_orden_compra")
        oda.SelectCommand.Parameters("@numero_orden_compra").Value = Me.numero_orden_compra

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
        Command.CommandText = "DELETE FROM Temp_grilla_pago_cliente"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Temp_grilla_pago_cliente"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Temp_grilla_pago_cliente_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Temp_grilla_pago_cliente")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Temp_grilla_pago_cliente.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
