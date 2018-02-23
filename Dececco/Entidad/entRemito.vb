Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Remito_ent

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_remito As Int32
    Public ReadOnly Property id_remito() As Int32
        Get
            _id_remito = CInt(dr("id_remito"))
            Return _id_remito
        End Get
    end property

    Private _id_factura As Int32
    Public Property id_factura() As Int32
        Get
            _id_factura = CInt(dr("id_factura"))
            Return _id_factura
        End Get
        Set(ByVal Value As Int32)
            dr("id_factura") = Value
        End Set
    end property

    Private _fecha_remito As DateTime
    Public Property fecha_remito() As DateTime
        Get
            _fecha_remito = CDate(dr("fecha_remito"))
            Return _fecha_remito
        End Get
        Set(ByVal Value As DateTime)
            dr("fecha_remito") = Value
        End Set
    end property

    Private _numero_remito As String
    Public Property numero_remito() As String
        Get
            _numero_remito = CStr(dr("numero_remito"))
            Return _numero_remito
        End Get
        Set(ByVal Value As String)
            dr("numero_remito") = Value
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

    Private _id_condicion_venta As Int32
    Public Property id_condicion_venta() As Int32
        Get
            _id_condicion_venta = CInt(dr("id_condicion_venta"))
            Return _id_condicion_venta
        End Get
        Set(ByVal Value As Int32)
            dr("id_condicion_venta") = Value
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


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Remito")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Remito_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_remito", SqlDbType.int, 0, "id_remito")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@id_factura", SqlDbType.int, 4, "id_factura")
        da.InsertCommand.Parameters.Add("@fecha_remito", SqlDbType.datetime, 8, "fecha_remito")
        da.InsertCommand.Parameters.Add("@numero_remito", SqlDbType.varchar, 50, "numero_remito")
        da.InsertCommand.Parameters.Add("@id_cliente", SqlDbType.int, 4, "id_cliente")
        da.InsertCommand.Parameters.Add("@observacion", SqlDbType.varchar, 5000, "observacion")
        da.InsertCommand.Parameters.Add("@id_condicion_venta", SqlDbType.int, 4, "id_condicion_venta")
        da.InsertCommand.Parameters.Add("@id_usuario", SqlDbType.int, 4, "id_usuario")

        dr = dt.NewRow()
        dr("id_factura") = 0
        dr("fecha_remito") = DateTime.Now
        dr("numero_remito") = ""
        dr("id_cliente") = 0
        dr("observacion") = ""
        dr("id_condicion_venta") = 0
        dr("id_usuario") = 0
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idRemito As Integer)
        dt = New DataTable("Remito")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Remito WHERE id_remito = @id_Remito", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Remito", idRemito)
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
    Public Sub Borrar(ByVal idRemito As Integer)
        dt = New DataTable("Remito")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Remito WHERE id_remito = " & _
        idRemito, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Remito_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_remito", SqlDbType.Int, 4, "id_remito")
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
               Case "id_remito"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_factura"
                  dc.DataType = Type.GetType("System.Int32")
               Case "fecha_remito"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "numero_remito"
                  dc.DataType = Type.GetType("System.String")
               Case "id_cliente"
                  dc.DataType = Type.GetType("System.Int32")
               Case "observacion"
                  dc.DataType = Type.GetType("System.String")
               Case "id_condicion_venta"
                  dc.DataType = Type.GetType("System.Int32")
               Case "id_usuario"
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
        dt = New DataTable("Remito")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Remito WHERE id_remito = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Remito_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Remito_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Remito_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Remito As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Remito_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_remito", SqlDbType.Int, 4, "id_remito")
        oda.SelectCommand.Parameters("@id_remito").Value = id_Remito

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Remito_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_factura", SqlDbType.int, 4, "id_factura")
        oda.SelectCommand.Parameters("@id_factura").Value = Me.id_factura
        oda.SelectCommand.Parameters.Add("@fecha_remito", SqlDbType.datetime, 8, "fecha_remito")
        oda.SelectCommand.Parameters("@fecha_remito").Value = Me.fecha_remito
        oda.SelectCommand.Parameters.Add("@numero_remito", SqlDbType.varchar, 50, "numero_remito")
        oda.SelectCommand.Parameters("@numero_remito").Value = Me.numero_remito
        oda.SelectCommand.Parameters.Add("@id_cliente", SqlDbType.int, 4, "id_cliente")
        oda.SelectCommand.Parameters("@id_cliente").Value = Me.id_cliente
        oda.SelectCommand.Parameters.Add("@observacion", SqlDbType.varchar, 5000, "observacion")
        oda.SelectCommand.Parameters("@observacion").Value = Me.observacion
        oda.SelectCommand.Parameters.Add("@id_condicion_venta", SqlDbType.int, 4, "id_condicion_venta")
        oda.SelectCommand.Parameters("@id_condicion_venta").Value = Me.id_condicion_venta
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = Me.id_usuario

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
        Command.CommandText = "DELETE FROM Remito"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Remito"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Remito_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Remito")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Remito.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
