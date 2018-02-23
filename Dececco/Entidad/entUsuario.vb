Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Usuario_ent

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_usuario As Int32
    Public ReadOnly Property id_usuario() As Int32
        Get
            _id_usuario = CInt(dr("id_usuario"))
            Return _id_usuario
        End Get
    end property

    Private _nombre_usuario As String
    Public Property nombre_usuario() As String
        Get
            _nombre_usuario = CStr(dr("nombre_usuario"))
            Return _nombre_usuario
        End Get
        Set(ByVal Value As String)
            dr("nombre_usuario") = Value
        End Set
    end property

    Private _password_usuario As String
    Public Property password_usuario() As String
        Get
            _password_usuario = CStr(dr("password_usuario"))
            Return _password_usuario
        End Get
        Set(ByVal Value As String)
            dr("password_usuario") = Value
        End Set
    end property

    Private _id_grupo_usuario As Int32
    Public Property id_grupo_usuario() As Int32
        Get
            _id_grupo_usuario = CInt(dr("id_grupo_usuario"))
            Return _id_grupo_usuario
        End Get
        Set(ByVal Value As Int32)
            dr("id_grupo_usuario") = Value
        End Set
    end property

    Private _legajo As String
    Public Property legajo() As String
        Get
            _legajo = CStr(dr("legajo"))
            Return _legajo
        End Get
        Set(ByVal Value As String)
            dr("legajo") = Value
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

    Private _session_activa As DateTime
    Public Property session_activa() As DateTime
        Get
            _session_activa = CDate(dr("session_activa"))
            Return _session_activa
        End Get
        Set(ByVal Value As DateTime)
            dr("session_activa") = Value
        End Set
    end property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Usuario")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Usuario_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_usuario", SqlDbType.int, 0, "id_usuario")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@nombre_usuario", SqlDbType.varchar, 50, "nombre_usuario")
        da.InsertCommand.Parameters.Add("@password_usuario", SqlDbType.varchar, 50, "password_usuario")
        da.InsertCommand.Parameters.Add("@id_grupo_usuario", SqlDbType.int, 4, "id_grupo_usuario")
        da.InsertCommand.Parameters.Add("@legajo", SqlDbType.varchar, 50, "legajo")
        da.InsertCommand.Parameters.Add("@apellido", SqlDbType.varchar, 50, "apellido")
        da.InsertCommand.Parameters.Add("@nombre", SqlDbType.varchar, 50, "nombre")
        da.InsertCommand.Parameters.Add("@session_activa", SqlDbType.datetime, 8, "session_activa")

        dr = dt.NewRow()
        dr("nombre_usuario") = ""
        dr("password_usuario") = ""
        dr("id_grupo_usuario") = 0
        dr("legajo") = ""
        dr("apellido") = ""
        dr("nombre") = ""
        dr("session_activa") = DateTime.Now
        dr("activo") = False
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idUsuario As Integer)
        dt = New DataTable("Usuario")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Usuario WHERE id_usuario = @id_Usuario", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Usuario", idUsuario)
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
    Public Sub Borrar(ByVal idUsuario As Integer)
        dt = New DataTable("Usuario")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Usuario WHERE id_usuario = " & _
        idUsuario, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Usuario_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
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
               Case "id_usuario"
                  dc.DataType = Type.GetType("System.Int32")
               Case "nombre_usuario"
                  dc.DataType = Type.GetType("System.String")
               Case "password_usuario"
                  dc.DataType = Type.GetType("System.String")
               Case "id_grupo_usuario"
                  dc.DataType = Type.GetType("System.Int32")
               Case "legajo"
                  dc.DataType = Type.GetType("System.String")
               Case "apellido"
                  dc.DataType = Type.GetType("System.String")
               Case "nombre"
                  dc.DataType = Type.GetType("System.String")
               Case "session_activa"
                  dc.DataType = Type.GetType("System.DateTime")
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
        dt = New DataTable("Usuario")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Usuario WHERE id_usuario = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Usuario_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Usuario_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    Public Function ConsultarNombreCompleto() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Usuario_GetAllNombres", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Usuario_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Usuario As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Usuario_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.Int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = id_Usuario

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Usuario_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre_usuario", SqlDbType.varchar, 50, "nombre_usuario")
        oda.SelectCommand.Parameters("@nombre_usuario").Value = Me.nombre_usuario
        oda.SelectCommand.Parameters.Add("@password_usuario", SqlDbType.varchar, 50, "password_usuario")
        oda.SelectCommand.Parameters("@password_usuario").Value = Me.password_usuario
        oda.SelectCommand.Parameters.Add("@id_grupo_usuario", SqlDbType.int, 4, "id_grupo_usuario")
        oda.SelectCommand.Parameters("@id_grupo_usuario").Value = Me.id_grupo_usuario
        oda.SelectCommand.Parameters.Add("@legajo", SqlDbType.varchar, 50, "legajo")
        oda.SelectCommand.Parameters("@legajo").Value = Me.legajo
        oda.SelectCommand.Parameters.Add("@apellido", SqlDbType.varchar, 50, "apellido")
        oda.SelectCommand.Parameters("@apellido").Value = Me.apellido
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.varchar, 50, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Me.nombre
        oda.SelectCommand.Parameters.Add("@session_activa", SqlDbType.datetime, 8, "session_activa")
        oda.SelectCommand.Parameters("@session_activa").Value = Me.session_activa

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
        Command.CommandText = "DELETE FROM Usuario"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Usuario"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Usuario_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Usuario")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Usuario.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
