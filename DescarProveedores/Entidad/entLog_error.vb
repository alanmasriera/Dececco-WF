Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Log_error_ent

    'defino las variables
    Private dt As DataTable
    Private dr As DataRow
    Private da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_log_error As Int32
    Public ReadOnly Property id_log_error() As Int32
        Get
            _id_log_error = CInt(dr("id_log_error"))
            Return _id_log_error
        End Get
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

    Private _mensaje As String
    Public Property mensaje() As String
        Get
            _mensaje = CStr(dr("mensaje"))
            Return _mensaje
        End Get
        Set(ByVal Value As String)
            dr("mensaje") = Value
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

    Private _descripcion As String
    Public Property descripcion() As String
        Get
            _descripcion = CStr(dr("descripcion"))
            Return _descripcion
        End Get
        Set(ByVal Value As String)
            dr("descripcion") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Log_error")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Log_error_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_log_error", SqlDbType.int, 0, "id_log_error")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@fecha", SqlDbType.datetime, 8, "fecha")
        da.InsertCommand.Parameters.Add("@numero", SqlDbType.varchar, 50, "numero")
        da.InsertCommand.Parameters.Add("@mensaje", SqlDbType.varchar, 5000, "mensaje")
        da.InsertCommand.Parameters.Add("@origen", SqlDbType.varchar, 5000, "origen")
        da.InsertCommand.Parameters.Add("@descripcion", SqlDbType.varchar, 8000, "descripcion")

        dr = dt.NewRow()
        dr("fecha") = DateTime.Now
        dr("numero") = ""
        dr("mensaje") = ""
        dr("origen") = ""
        dr("descripcion") = ""
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idLog_error As Integer)
        dt = New DataTable("Log_error")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Log_error WHERE id_log_error = @id_Log_error", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Log_error", idLog_error)
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
    Public Sub Borrar(ByVal idLog_error As Integer)
        dt = New DataTable("Log_error")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Log_error WHERE id_log_error = " & _
        idLog_error, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Log_error_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_log_error", SqlDbType.Int, 4, "id_log_error")
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
               Case "id_log_error"
                  dc.DataType = Type.GetType("System.Int32")
               Case "fecha"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "numero"
                  dc.DataType = Type.GetType("System.String")
               Case "mensaje"
                  dc.DataType = Type.GetType("System.String")
               Case "origen"
                  dc.DataType = Type.GetType("System.String")
               Case "descripcion"
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
        dt = New DataTable("Log_error")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Log_error WHERE id_log_error = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Log_error_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Log_error_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Log_error_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Log_error As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Log_error_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_log_error", SqlDbType.Int, 4, "id_log_error")
        oda.SelectCommand.Parameters("@id_log_error").Value = id_Log_error

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Log_error_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.datetime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = Me.fecha
        oda.SelectCommand.Parameters.Add("@numero", SqlDbType.varchar, 50, "numero")
        oda.SelectCommand.Parameters("@numero").Value = Me.numero
        oda.SelectCommand.Parameters.Add("@mensaje", SqlDbType.varchar, 5000, "mensaje")
        oda.SelectCommand.Parameters("@mensaje").Value = Me.mensaje
        oda.SelectCommand.Parameters.Add("@origen", SqlDbType.varchar, 5000, "origen")
        oda.SelectCommand.Parameters("@origen").Value = Me.origen
        oda.SelectCommand.Parameters.Add("@descripcion", SqlDbType.varchar, 8000, "descripcion")
        oda.SelectCommand.Parameters("@descripcion").Value = Me.descripcion

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
        Command.CommandText = "DELETE FROM Log_error"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Log_error"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Log_error_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Log_error")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Log_error.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
