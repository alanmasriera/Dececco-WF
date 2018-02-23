Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Calendario_usuario_ent

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_calendario_usuario As Int32
    Public ReadOnly Property id_calendario_usuario() As Int32
        Get
            _id_calendario_usuario = CInt(dr("id_calendario_usuario"))
            Return _id_calendario_usuario
        End Get
    End Property

    Private _id_calendario As Int32
    Public Property id_calendario() As Int32
        Get
            _id_calendario = CInt(dr("id_calendario"))
            Return _id_calendario
        End Get
        Set(ByVal Value As Int32)
            dr("id_calendario") = Value
        End Set
    End Property

    Private _id_usuario As Int32
    Public Property id_usuario() As Int32
        Get
            _id_usuario = CInt(dr("id_usuario"))
            Return _id_usuario
        End Get
        Set(ByVal Value As Int32)
            dr("id_usuario") = Value
        End Set
    End Property

    Private _trabaja As Boolean
    Public Property trabaja() As Boolean
        Get
            _trabaja = CBool(dr("trabaja"))
            Return _trabaja
        End Get
        Set(ByVal value As Boolean)
            dr("trabaja") = value
        End Set
    End Property


    Private _hora_inicio As DateTime
    Public Property hora_inicio() As DateTime
        Get
            _hora_inicio = CDate(dr("hora_inicio"))
            Return _hora_inicio
        End Get
        Set(ByVal Value As DateTime)
            dr("hora_inicio") = Value
        End Set
    End Property

    Private _hora_fin As DateTime
    Public Property hora_fin() As DateTime
        Get
            _hora_fin = CDate(dr("hora_fin"))
            Return _hora_fin
        End Get
        Set(ByVal Value As DateTime)
            dr("hora_fin") = Value
        End Set
    End Property

    Private _motivo As String
    Public Property motivo() As String
        Get
            _motivo = CStr(dr("motivo"))
            Return _motivo
        End Get
        Set(ByVal Value As String)
            dr("motivo") = Value
        End Set
    End Property




    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Calendario_usuario")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Calendario_usuario_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_calendario_usuario", SqlDbType.int, 0, "id_calendario_usuario")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@id_calendario", SqlDbType.Int, 4, "id_calendario")
        da.InsertCommand.Parameters.Add("@id_usuario", SqlDbType.int, 4, "id_usuario")
        da.InsertCommand.Parameters.Add("@hora_inicio", SqlDbType.DateTime, 8, "hora_inicio")
        da.InsertCommand.Parameters.Add("@hora_fin", SqlDbType.DateTime, 8, "hora_fin")
        da.InsertCommand.Parameters.Add("@motivo", SqlDbType.VarChar, 500, "motivo")
        da.InsertCommand.Parameters.Add("@trabaja", SqlDbType.Bit, 1, "trabaja")

        dr = dt.NewRow()
        dr("id_calendario") = 0
        dr("id_usuario") = 0
        dr("hora_inicio") = DateTime.Now
        dr("hora_fin") = DateTime.Now
        dr("motivo") = ""
        dr("trabaja") = 0
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idCalendario_usuario As Integer)
        dt = New DataTable("Calendario_usuario")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Calendario_usuario WHERE id_calendario_usuario = @id_Calendario_usuario", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Calendario_usuario", idCalendario_usuario)
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
    Public Sub Borrar(ByVal idCalendario_usuario As Integer)
        dt = New DataTable("Calendario_usuario")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Calendario_usuario WHERE id_calendario_usuario = " & _
        idCalendario_usuario, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Calendario_usuario_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_calendario_usuario", SqlDbType.Int, 4, "id_calendario_usuario")
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
               Case "id_calendario_usuario"
                    dc.DataType = Type.GetType("System.Int32")
                Case "id_calendario"
                    dc.DataType = Type.GetType("System.Int32")
               Case "id_usuario"
                    dc.DataType = Type.GetType("System.Int32")
                Case "trabaja"
                    dc.DataType = Type.GetType("System.Boolean")
                Case "hora_inicio"
                    dc.DataType = Type.GetType("System.DateTime")
                Case "hora_fin"
                    dc.DataType = Type.GetType("System.DateTime")
                Case "motivo"
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
        dt = New DataTable("Calendario_usuario")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Calendario_usuario WHERE id_calendario_usuario = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Calendario_usuario_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Calendario_usuario_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Calendario_usuario_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Calendario_usuario As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Calendario_usuario_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_calendario_usuario", SqlDbType.Int, 4, "id_calendario_usuario")
        oda.SelectCommand.Parameters("@id_calendario_usuario").Value = id_Calendario_usuario

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Calendario_usuario_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_calendario", SqlDbType.Int, 4, "id_calendario")
        oda.SelectCommand.Parameters("@id_calendario").Value = Me.id_calendario
        oda.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.int, 4, "id_usuario")
        oda.SelectCommand.Parameters("@id_usuario").Value = Me.id_usuario
        oda.SelectCommand.Parameters.Add("@hora_inicio", SqlDbType.DateTime, 8, "hora_inicio")
        oda.SelectCommand.Parameters("@hora_inicio").Value = Me.hora_inicio
        oda.SelectCommand.Parameters.Add("@hora_fin", SqlDbType.DateTime, 8, "hora_fin")
        oda.SelectCommand.Parameters("@hora_fin").Value = Me.hora_fin
        oda.SelectCommand.Parameters.Add("@motivo", SqlDbType.VarChar, 500, "motivo")
        oda.SelectCommand.Parameters("@motivo").Value = Me.motivo

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
        Command.CommandText = "DELETE FROM Calendario_usuario"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Calendario_usuario"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Calendario_usuario_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Calendario_usuario")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Calendario_usuario.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
