Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Calendario_ent

    'defino las variables
    Friend dt As DataTable
    Friend dr As DataRow
    Friend da As SqlClient.SqlDataAdapter
    Friend cnn As New Conexion
    Friend cnntxt As New Conexion_txt

    'defino las propiedades
    Private _id_calendario As Int32
    Public ReadOnly Property id_calendario() As Int32
        Get
            _id_calendario = CInt(dr("id_calendario"))
            Return _id_calendario
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

    Private _id_dia As Int32
    Public Property id_dia() As Int32
        Get
            _id_dia = CInt(dr("id_dia"))
            Return _id_dia
        End Get
        Set(ByVal Value As Int32)
            dr("id_dia") = Value
        End Set
    end property

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

    Private _dia_laboral As Boolean
    Public Property dia_laboral() As Boolean
        Get
            _dia_laboral = CBool(dr("dia_laboral"))
            Return _dia_laboral
        End Get
        Set(ByVal Value As Boolean)
            dr("dia_laboral") = Value
        End Set
    End Property

    Private _feriado As Boolean
    Public Property feriado() As Boolean
        Get
            _feriado = CBool(dr("feriado"))
            Return _feriado
        End Get
        Set(ByVal Value As Boolean)
            dr("feriado") = Value
        End Set
    End Property


    'procedimiento insertar
    Public Sub Insertar()
        dt = New DataTable("Calendario")
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)

        Me.AsignarTipos()

        Dim cmdins As New SqlCommand("cop_Calendario_Insert", cnn.Coneccion)
        cmdins.CommandType = CommandType.StoredProcedure
        da.InsertCommand = cmdins

        Dim prm As SqlParameter
        prm = da.InsertCommand.Parameters.Add("@id_calendario", SqlDbType.int, 0, "id_calendario")
        prm.Direction = ParameterDirection.Output
        da.InsertCommand.Parameters.Add("@fecha", SqlDbType.datetime, 8, "fecha")
        da.InsertCommand.Parameters.Add("@id_dia", SqlDbType.int, 4, "id_dia")
        da.InsertCommand.Parameters.Add("@hora_inicio", SqlDbType.DateTime, 8, "hora_inicio")
        da.InsertCommand.Parameters.Add("@hora_fin", SqlDbType.DateTime, 8, "hora_fin")
        da.InsertCommand.Parameters.Add("@dia_laboral", SqlDbType.Bit, 1, "dia_laboral")
        da.InsertCommand.Parameters.Add("@feriado", SqlDbType.Bit, 1, "feriado")

        dr = dt.NewRow()
        dr("fecha") = DateTime.Now
        dr("id_dia") = 0
        dr("hora_inicio") = DateTime.Now
        dr("hora_fin") = DateTime.Now
        dr("dia_laboral") = 0
        dr("feriado") = 0
        dt.Rows.Add(dr)
        CrearComandoUpdate()
    End Sub

    'procedimiento modificar
    Public Sub Modificar(ByVal idCalendario As Integer)
        dt = New DataTable("Calendario")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Calendario WHERE id_calendario = @id_Calendario", cnn.Coneccion)
        da.SelectCommand.Parameters.AddWithValue("@id_Calendario", idCalendario)
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
    Public Sub Borrar(ByVal idCalendario As Integer)
        dt = New DataTable("Calendario")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Calendario WHERE id_calendario = " & _
        idCalendario, cnn.Coneccion)
        da.Fill(dt)

        Me.AsignarTipos()

        If dt.Rows.Count = 0 Then
            Exit Sub
        Else
            dr = dt.Rows(0)
        End If

        Try
            Dim cmddel As New SqlCommand("cop_Calendario_Delete", cnn.Coneccion)
            cmddel.CommandType = CommandType.StoredProcedure
            da.DeleteCommand = cmddel
            Dim prm As SqlParameter
            prm = da.DeleteCommand.Parameters.Add("@id_calendario", SqlDbType.Int, 4, "id_calendario")
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
               Case "id_calendario"
                  dc.DataType = Type.GetType("System.Int32")
               Case "fecha"
                  dc.DataType = Type.GetType("System.DateTime")
               Case "id_dia"
                  dc.DataType = Type.GetType("System.Int32")
                Case "hora_inicio"
                    dc.DataType = Type.GetType("System.DateTime")
                Case "hora_fin"
                    dc.DataType = Type.GetType("System.DateTime")
                Case "dia_laboral"
                    dc.DataType = Type.GetType("System.Boolean")
                Case "feriado"
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
        dt = New DataTable("Calendario")
        da = New SqlClient.SqlDataAdapter("SELECT * FROM Calendario WHERE id_calendario = 0", cnn.Coneccion)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(dt)
        Return dt
    End Function

    'funcion de busqueda
    Public Function Buscar(ByVal Nombre As String) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Calendario_Find", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@nombre", SqlDbType.NChar, 30, "nombre")
        oda.SelectCommand.Parameters("@nombre").Value = Nombre

        oda.Fill(odt)

        Return odt
    End Function

    'funcion de consulta
    Public Function ConsultarTodo() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Calendario_GetAll", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion para llenar el combo
    Public Function GetCmb() As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Calendario_GetCmb", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.Fill(odt)

        Return odt
    End Function

    'funcion que trae un registro poniendo el id
    Public Function GetOne(ByVal id_Calendario As Integer) As DataTable
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Calendario_GetOne", cnn.Coneccion)

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@id_calendario", SqlDbType.Int, 4, "id_calendario")
        oda.SelectCommand.Parameters("@id_calendario").Value = id_Calendario

        oda.Fill(odt)

        Return odt
    End Function

    'controla si existe el registro en la base de datos
    Public Function Exist() As Boolean
        Dim odt As New DataTable
        Dim oda As New SqlDataAdapter("cop_Calendario_Exist", cnn.Coneccion)
        Dim Total As Integer

        oda.SelectCommand.CommandType = CommandType.StoredProcedure
        oda.SelectCommand.Parameters.Add("@fecha", SqlDbType.datetime, 8, "fecha")
        oda.SelectCommand.Parameters("@fecha").Value = Me.fecha
        oda.SelectCommand.Parameters.Add("@id_dia", SqlDbType.int, 4, "id_dia")
        oda.SelectCommand.Parameters("@id_dia").Value = Me.id_dia
        oda.SelectCommand.Parameters.Add("@hora_inicio", SqlDbType.DateTime, 8, "hora_inicio")
        oda.SelectCommand.Parameters("@hora_inicio").Value = Me.hora_inicio
        oda.SelectCommand.Parameters.Add("@hora_fin", SqlDbType.DateTime, 8, "hora_fin")
        oda.SelectCommand.Parameters("@hora_fin").Value = Me.hora_fin
        oda.SelectCommand.Parameters.Add("@dia_laboral", SqlDbType.Bit, 1, "dia_laboral")
        oda.SelectCommand.Parameters("@dia_laboral").Value = Me.dia_laboral
        oda.SelectCommand.Parameters.Add("@feriado", SqlDbType.Bit, 1, "feriado")
        oda.SelectCommand.Parameters("@feriado").Value = Me.feriado

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
        Command.CommandText = "DELETE FROM Calendario"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'borra todos los datos de la tabla
    Public Sub Truncate()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "TRUNCATE TABLE Calendario"

        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'inserta un registro en la tabla
    Public Sub InsertOne()
        Dim oConexion As New Conexion
        Dim Command As SqlCommand = New SqlCommand()

        Command.Connection = oConexion.Coneccion
        Command.CommandText = "cop_Calendario_InsertOne"

        Command.CommandType = CommandType.StoredProcedure
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Command.Connection.Close()
    End Sub

    'importa los datos de una campaña desde el txt
    Public Function Cargar_Archivo(ByVal path As String) As DataTable
        Dim odt As New DataTable("Calendario")

        Dim oda As New System.Data.OleDb.OleDbDataAdapter( _
        "SELECT * FROM Calendario.txt", cnntxt.Coneccion(path))

        oda.Fill(odt)

        Return odt
    End Function


End Class
